Imports System.Data.SqlClient
Imports System.Configuration

Public Class clsCabImportarTargetMedico

    Private _listaItem As List(Of clsImportarDetalleTargeMedico)
    Public Property prListaItem() As List(Of clsImportarDetalleTargeMedico)
        Get
            Return _listaItem
        End Get
        Set(ByVal value As List(Of clsImportarDetalleTargeMedico))
            _listaItem = value
        End Set
    End Property

    Private imp_id As String
    Public Property pr_imp_id() As String
        Get
            Return imp_id
        End Get
        Set(ByVal value As String)
            imp_id = value
        End Set
    End Property

    Public Function Serializar_Importar(ByVal _clsCabImportar As clsCabImportarTargetMedico) As String
        Dim _oStringWriter As IO.StringWriter
        Dim _listaSerializada As String = String.Empty
        Dim _oSerialization As Xml.Serialization.XmlSerializer
        Try
            '  _oBeCargo = New BeCargo
            _oStringWriter = New IO.StringWriter
            _oSerialization = New Xml.Serialization.XmlSerializer(_clsCabImportar.GetType)
            _oSerialization.Serialize(_oStringWriter, _clsCabImportar)
            _listaSerializada = _oStringWriter.ToString()

            Return _listaSerializada

        Catch ex As Exception
            Return ""

        End Try
    End Function


    Public Conexion As String = String.Empty

    Public Sub RegistrarImportacion_TargetMedico(ByVal _xmlserializado As String, ByVal usr_id As String, ByRef _tiporespuesta As String, ByRef _textorespuesta As String, ByRef idRentabilidad As String, ByRef fecHoraReg As String)
        Try
            Conexion = System.Configuration.ConfigurationManager.ConnectionStrings("ConexionHeadMark").ConnectionString

            Using oSqlConnectionMedlab As SqlConnection = New SqlConnection(Conexion)
                Using oSqlCommandMedlab As SqlCommand = New SqlCommand("DSN_REGISTRAR_IMPORTAR_ARCHIVO_TARGETMEDICO", oSqlConnectionMedlab)
                    oSqlCommandMedlab.CommandType = CommandType.StoredProcedure

                    oSqlCommandMedlab.Parameters.Add("@Xml", SqlDbType.Xml).Value = _xmlserializado
                    oSqlCommandMedlab.Parameters.Add("@usr_id", SqlDbType.Int).Value = usr_id

                    If (oSqlConnectionMedlab.State = ConnectionState.Closed) Then
                        oSqlConnectionMedlab.Open()
                    End If

                    If (oSqlCommandMedlab.Connection.State = ConnectionState.Closed) Then
                        oSqlCommandMedlab.Connection.Open()
                    End If

                    Using oSqlDataReader As SqlDataReader = oSqlCommandMedlab.ExecuteReader(CommandBehavior.SingleRow)
                        If oSqlDataReader.Read Then
                            _tiporespuesta = oSqlDataReader.GetValue(0).ToString()
                            _textorespuesta = oSqlDataReader.GetValue(1).ToString()
                            idRentabilidad = oSqlDataReader.GetValue(2).ToString()
                            fecHoraReg = oSqlDataReader.GetValue(3).ToString()
                        End If
                        oSqlDataReader.Close()
                    End Using

                    If (oSqlCommandMedlab.Connection.State = ConnectionState.Open) Then
                        oSqlCommandMedlab.Connection.Close()
                    End If

                    If (oSqlConnectionMedlab.State = ConnectionState.Open) Then
                        oSqlConnectionMedlab.Close()
                    End If
                End Using
            End Using

        Catch ex As Exception
            _tiporespuesta = "0"
            _textorespuesta = ex.Message
        End Try
    End Sub

End Class
