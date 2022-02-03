
Imports System.Data.SqlClient
Imports System.Configuration

<Serializable()> Public Class BeCabRotuloxArticulo

    Private _listaItem As List(Of BeDetalleRotulosxArticulo)
    Public Property prListaItem() As List(Of BeDetalleRotulosxArticulo)
        Get
            Return _listaItem
        End Get
        Set(ByVal value As List(Of BeDetalleRotulosxArticulo))
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

    Public Function Registrar_Rotulos(ByVal BeCabRotulos As BeCabRotuloxArticulo) As String
        Dim _oStringWriter As IO.StringWriter
        Dim _listaSerializada As String = String.Empty
        Dim _oSerialization As Xml.Serialization.XmlSerializer
        Try
            '_oBeCargo = New BeCargo
            _oStringWriter = New IO.StringWriter
            _oSerialization = New Xml.Serialization.XmlSerializer(BeCabRotulos.GetType)
            _oSerialization.Serialize(_oStringWriter, BeCabRotulos)
            _listaSerializada = _oStringWriter.ToString()

            Return _listaSerializada

        Catch ex As Exception
            Return ""

        End Try

    End Function


    Public Sub RegistrarImpresionRotulosxArticulos(ByVal _xmlserializado As String, ByRef _tiporespuesta As String, ByRef _textorespuesta As String, ByRef idRentabilidad As String, ByRef fecHoraReg As String)
        Try
            Conexion = System.Configuration.ConfigurationManager.ConnectionStrings("ConexionHeadMark").ConnectionString

            Using oSqlConnectionMedlab As SqlConnection = New SqlConnection(Conexion)
                Using oSqlCommandMedlab As SqlCommand = New SqlCommand("DSN_REGISTRAR_ROTULOS_ARTICULO", oSqlConnectionMedlab)
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



    Public Function Obtener_RotuloxArticulos(ByVal c5_calma As String, ByVal c5_ctd As String, ByVal c5_cnumdoc As String, ByVal sr_codigo As String, ByVal sr_serie As String) As DataTable
        Try
            Dim _listadoPruebas As New DataTable
            Conexion = System.Configuration.ConfigurationManager.ConnectionStrings("ConexionHeadMark").ConnectionString

            Using oSqlConnection As SqlConnection = New SqlConnection(Conexion)
                Dim _consulta As String = String.Empty

                Using oSqlCommand As SqlCommand = New SqlCommand("SPDSN_OBTENER_ROTULOXARTICULO", oSqlConnection)
                    oSqlCommand.CommandType = CommandType.StoredProcedure
                    oSqlCommand.Parameters.Add("@C5_CALMA", SqlDbType.VarChar, 4).Value = c5_calma
                    oSqlCommand.Parameters.Add("@C5_CTD", SqlDbType.VarChar, 2).Value = c5_ctd
                    oSqlCommand.Parameters.Add("@C5_CNUMDOC", SqlDbType.VarChar, 18).Value = c5_cnumdoc
                    oSqlCommand.Parameters.Add("@SR_CODIGO", SqlDbType.VarChar, 25).Value = sr_codigo
                    oSqlCommand.Parameters.Add("@SR_CSERIE", SqlDbType.VarChar, 18).Value = sr_serie


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
