Imports System.Data.SqlClient
Imports System.Configuration

Public Class BeProgramacion

    Private rpr_id As String
    Public Property prrpr_id() As String
        Get
            Return rpr_id
        End Get
        Set(ByVal value As String)
            rpr_id = value
        End Set
    End Property

    Private req_id As String
    Public Property prreq_id() As String
        Get
            Return req_id
        End Get
        Set(ByVal value As String)
            req_id = value
        End Set
    End Property

    Private res_id As String
    Public Property prres_id() As String
        Get
            Return res_id
        End Get
        Set(ByVal value As String)
            res_id = value
        End Set
    End Property

    Private rpr_fecinicio As String
    Public Property prrpr_fecinicio() As String
        Get
            Return rpr_fecinicio
        End Get
        Set(ByVal value As String)
            rpr_fecinicio = value
        End Set
    End Property

    Private rpr_fecfin As String
    Public Property prrpr_fecfin() As String
        Get
            Return rpr_fecfin
        End Get
        Set(ByVal value As String)
            rpr_fecfin = value
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


    Public Sub RegistrarProgramacion(ByVal BeProg As BeProgramacion, ByRef _tiporespuesta As String, ByRef _textorespuesta As String, ByRef rpr_id As String, ByRef fecHoraReg As String)
        Try
            Conexion = System.Configuration.ConfigurationManager.ConnectionStrings("ConexionHeadMark").ConnectionString

            Using oSqlConnection As SqlConnection = New SqlConnection(Conexion)
                Using oSqlCommandMedlab As SqlCommand = New SqlCommand("SPDSN_REGISTRAR_PROGRAMACION_REQUE", oSqlConnection)
                    oSqlCommandMedlab.CommandType = CommandType.StoredProcedure

                    oSqlCommandMedlab.Parameters.Add("@req_id", SqlDbType.Int).Value = BeProg.prreq_id
                    oSqlCommandMedlab.Parameters.Add("@res_id", SqlDbType.Int).Value = BeProg.prres_id
                    oSqlCommandMedlab.Parameters.Add("@rpr_fecinicio", SqlDbType.VarChar, 30).Value = BeProg.prrpr_fecinicio
                    oSqlCommandMedlab.Parameters.Add("@rpr_fecfin", SqlDbType.VarChar, 30).Value = BeProg.prrpr_fecfin
                    oSqlCommandMedlab.Parameters.Add("@usr_id", SqlDbType.Int).Value = BeProg.prusr_id

                    If (oSqlConnection.State = ConnectionState.Closed) Then
                        oSqlConnection.Open()
                    End If

                    If (oSqlCommandMedlab.Connection.State = ConnectionState.Closed) Then
                        oSqlCommandMedlab.Connection.Open()
                    End If

                    Using oSqlDataReader As SqlDataReader = oSqlCommandMedlab.ExecuteReader(CommandBehavior.SingleRow)
                        If oSqlDataReader.Read Then

                            _tiporespuesta = oSqlDataReader.GetValue(0).ToString()
                            _textorespuesta = oSqlDataReader.GetValue(1).ToString()
                            rpr_id = oSqlDataReader.GetValue(2).ToString()
                            fecHoraReg = oSqlDataReader.GetValue(3).ToString()

                        End If

                        oSqlDataReader.Close()

                    End Using

                    If (oSqlCommandMedlab.Connection.State = ConnectionState.Open) Then
                        oSqlCommandMedlab.Connection.Close()
                    End If

                    If (oSqlConnection.State = ConnectionState.Open) Then
                        oSqlConnection.Close()
                    End If
                End Using
            End Using

        Catch ex As Exception

        End Try
    End Sub


End Class
