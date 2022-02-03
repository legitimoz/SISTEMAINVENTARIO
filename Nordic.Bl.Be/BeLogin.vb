
Imports System.Data.SqlClient
Imports System.Configuration

Public Class BeLogin


    Private idUser As String
    Public Property pridUser() As String
        Get
            Return idUser
        End Get
        Set(ByVal value As String)
            idUser = value
        End Set
    End Property

    Private User As String
    Public Property prUser() As String
        Get
            Return User
        End Get
        Set(ByVal value As String)
            User = value
        End Set
    End Property

    Private UserName As String
    Public Property PrUserName() As String
        Get
            Return UserName
        End Get
        Set(ByVal value As String)
            UserName = value
        End Set
    End Property

    Private per_id As String
    Public Property PrPer_id() As String
        Get
            Return per_id
        End Get
        Set(ByVal value As String)
            per_id = value
        End Set
    End Property

    Private Clave As String
    Public Property prClave() As String
        Get
            Return Clave
        End Get
        Set(ByVal value As String)
            Clave = value
        End Set
    End Property

    Public Conexion As String = String.Empty


    Public Sub Obtener_Logueo(ByVal usr_code As String, ByVal pass As String, ByRef usr_name As String, ByRef idUser As String, ByRef per_id As String)

        Dim ds As New Data.DataSet
        Try
            Conexion = System.Configuration.ConfigurationManager.ConnectionStrings("ConexionHeadMark").ConnectionString

            Using oSqlConnection As SqlConnection = New SqlConnection(Conexion)
                Using oSqlCommand As SqlCommand = New SqlCommand("DSN_NORDIC_LOGUEAR_USUARIO", oSqlConnection)
                    oSqlCommand.CommandType = CommandType.StoredProcedure

                    oSqlCommand.Parameters.Add("@UserCode", SqlDbType.NVarChar, 25).Value = usr_code
                    oSqlCommand.Parameters.Add("@Password", SqlDbType.NVarChar, 25).Value = pass

                    If (oSqlConnection.State = ConnectionState.Closed) Then
                        oSqlConnection.Open()
                    End If
                    If (oSqlCommand.Connection.State = ConnectionState.Closed) Then
                        oSqlCommand.Connection.Open()
                    End If

                    Using adapter As SqlDataAdapter = New SqlDataAdapter
                        adapter.SelectCommand = oSqlCommand
                        adapter.Fill(ds, "Listado")
                    End Using

                    If ds.Tables("Listado").Rows.Count > 0 Then

                        idUser = ds.Tables("Listado").Rows(0).Item(0)
                        usr_name = ds.Tables("Listado").Rows(0).Item(2)
                        per_id = ds.Tables("Listado").Rows(0).Item(3)

                    Else
                        idUser = ""
                        usr_name = ""
                        per_id = ""
                    End If

                    If (oSqlCommand.Connection.State = ConnectionState.Open) Then
                        oSqlCommand.Connection.Close()
                    End If
                    If (oSqlConnection.State = ConnectionState.Open) Then
                        oSqlConnection.Close()
                    End If
                End Using
            End Using


        Catch ex As Exception
            '_tiporespuesta = 0
            '_textorespuesta = "Error : " & ex.Message

        End Try

    End Sub

    Public Function ObtenerAnioActual() As String
        Try
            Conexion = System.Configuration.ConfigurationManager.ConnectionStrings("ConexionHeadMark").ConnectionString

            Dim queryhora = "select YEAR(GETDATE())"
            Dim con As New SqlConnection(Conexion)
            Dim cmd As New SqlCommand(queryhora, con)
            con.Open()
            Dim hora = cmd.ExecuteScalar()
            con.Close()
            cmd.Connection.Close()
            Return hora
        Catch ex As Exception
            Return Nothing
        End Try

    End Function



End Class
