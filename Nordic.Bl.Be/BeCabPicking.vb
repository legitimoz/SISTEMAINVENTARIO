

Imports System.Data.SqlClient
Imports System.Configuration



<Serializable()> Public Class BeCabPicking

    Private _listaItem As List(Of BeDetallePicking)
    Public Property prListaItem() As List(Of BeDetallePicking)
        Get
            Return _listaItem
        End Get
        Set(ByVal value As List(Of BeDetallePicking))
            _listaItem = value
        End Set
    End Property



    Private cgpi_id As String
    Public Property prcgpi_id() As String
        Get
            Return cgpi_id
        End Get
        Set(ByVal value As String)
            cgpi_id = value
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

    Public Function Registrar_Picking(ByVal BeCabPicking As BeCabPicking) As String
        Dim _oStringWriter As IO.StringWriter
        Dim _listaSerializada As String = String.Empty
        Dim _oSerialization As Xml.Serialization.XmlSerializer
        Try
            ' _oBeCargo = New BeCargo
            _oStringWriter = New IO.StringWriter
            _oSerialization = New Xml.Serialization.XmlSerializer(BeCabPicking.GetType)
            _oSerialization.Serialize(_oStringWriter, BeCabPicking)
            _listaSerializada = _oStringWriter.ToString()

            Return _listaSerializada

        Catch ex As Exception
            Return ""

        End Try

    End Function


    Public Sub RegistrarImpresionMasiva(ByVal _xmlserializado As String, ByRef _tiporespuesta As String, ByRef _textorespuesta As String, ByRef idRentabilidad As String, ByRef fecHoraReg As String)
        Try
            Conexion = System.Configuration.ConfigurationManager.ConnectionStrings("ConexionHeadMark").ConnectionString

            Using oSqlConnectionMedlab As SqlConnection = New SqlConnection(Conexion)
                Using oSqlCommandMedlab As SqlCommand = New SqlCommand("DSN_REGISTRAR_PICKING_MASIVO", oSqlConnectionMedlab)
                    oSqlCommandMedlab.CommandType = CommandType.StoredProcedure

                    oSqlCommandMedlab.Parameters.Add("@Xml", SqlDbType.Xml).Value = _xmlserializado
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
