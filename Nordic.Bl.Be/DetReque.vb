Imports System.Data.SqlClient
Imports System.Configuration

Public Class DetReque

    Private crd_id As String
    Public Property prcrd_id() As String
        Get
            Return crd_id
        End Get
        Set(ByVal value As String)
            crd_id = value
        End Set
    End Property

    Private cre_id As String
    Public Property prcre_id() As String
        Get
            Return cre_id
        End Get
        Set(ByVal value As String)
            cre_id = value
        End Set
    End Property

    Private ar_id As String
    Public Property prar_id() As String
        Get
            Return ar_id
        End Get
        Set(ByVal value As String)
            ar_id = value
        End Set
    End Property

    Private crd_cant As String
    Public Property prcrd_cant() As String
        Get
            Return crd_cant
        End Get
        Set(ByVal value As String)
            crd_cant = value
        End Set
    End Property

    Private crd_cost As String
    Public Property prcrd_cost() As String
        Get
            Return crd_cost
        End Get
        Set(ByVal value As String)
            crd_cost = value
        End Set
    End Property

    Private usr_id As String
    Public Property prusr_id() As String
        Get
            Return usr_id
        End Get
        Set(ByVal value As String)
            usr_id = value
        End Set
    End Property

    Public Conexion As String = String.Empty

    Public Function Obtener_Detalle_Requerimiento(ByVal cre_id As String) As DataTable
        Try
            Dim _listadoPruebas As New DataTable
            Conexion = System.Configuration.ConfigurationManager.ConnectionStrings("ConexionHeadMark").ConnectionString

            Using oSqlConnection As SqlConnection = New SqlConnection(Conexion)
                Dim _consulta As String = String.Empty

                Using oSqlCommand As SqlCommand = New SqlCommand("SPDSN_OBTENER_DET_REQUERIMIENTO", oSqlConnection)
                    oSqlCommand.CommandType = CommandType.StoredProcedure
                    oSqlCommand.Parameters.Add("@cre_id", SqlDbType.BigInt).Value = cre_id

                    If (oSqlConnection.State = Data.ConnectionState.Closed) Then
                        oSqlConnection.Open()
                    End If

                    If (oSqlCommand.Connection.State = Data.ConnectionState.Closed) Then
                        oSqlCommand.Connection.Open()
                    End If

                    Using adapter As SqlDataAdapter = New SqlDataAdapter
                        adapter.SelectCommand = oSqlCommand
                        adapter.Fill(_listadoPruebas)
                    End Using

                    If (oSqlCommand.Connection.State = Data.ConnectionState.Open) Then
                        oSqlCommand.Connection.Close()
                    End If

                    If (oSqlConnection.State = Data.ConnectionState.Open) Then
                        oSqlConnection.Close()
                    End If

                End Using
            End Using

            Return _listadoPruebas

        Catch ex As Exception
            Return Nothing
        End Try

    End Function


End Class
