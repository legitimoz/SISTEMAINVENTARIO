


Imports System.Data.SqlClient
Imports System.Configuration

<Serializable()> Public Class BeCabGuiaRuta

    Private _listaItem As List(Of BeDetGuiaRutaDetalle)
    Public Property prListaItem() As List(Of BeDetGuiaRutaDetalle)
        Get
            Return _listaItem
        End Get
        Set(ByVal value As List(Of BeDetGuiaRutaDetalle))
            _listaItem = value
        End Set
    End Property

    Private crg_id As String
    Public Property pr_crg_id() As String
        Get
            Return crg_id
        End Get
        Set(ByVal value As String)
            crg_id = value
        End Set
    End Property

    Private trd_ccodigo As String
    Public Property pr_trd_ccodigo() As String
        Get
            Return trd_ccodigo
        End Get
        Set(ByVal value As String)
            trd_ccodigo = value
        End Set
    End Property

    Private crg_fechaRuta As String
    Public Property pr_crg_fechaRuta() As String
        Get
            Return crg_fechaRuta
        End Get
        Set(ByVal value As String)
            crg_fechaRuta = value
        End Set
    End Property

    Private usr_id As String
    Public Property pr_usr_id() As String
        Get
            Return usr_id
        End Get
        Set(ByVal value As String)
            usr_id = value
        End Set
    End Property


    Public Function Serializar_RutaGuias(ByVal _BeCabGuiaRuta As BeCabGuiaRuta) As String
        Dim _oStringWriter As IO.StringWriter
        Dim _listaSerializada As String = String.Empty
        Dim _oSerialization As Xml.Serialization.XmlSerializer
        Try
            '  _oBeCargo = New BeCargo
            _oStringWriter = New IO.StringWriter
            _oSerialization = New Xml.Serialization.XmlSerializer(_BeCabGuiaRuta.GetType)
            _oSerialization.Serialize(_oStringWriter, _BeCabGuiaRuta)
            _listaSerializada = _oStringWriter.ToString()

            Return _listaSerializada

        Catch ex As Exception
            Return ""

        End Try

    End Function


    Public Conexion As String = String.Empty

    Public Sub RegistrarRuta_Guias(ByVal _xmlserializado As String, ByRef _tiporespuesta As String, ByRef _textorespuesta As String, ByRef idRentabilidad As String, ByRef fecHoraReg As String)
        Try
            Conexion = System.Configuration.ConfigurationManager.ConnectionStrings("ConexionHeadMark").ConnectionString

            Using oSqlConnectionMedlab As SqlConnection = New SqlConnection(Conexion)
                Using oSqlCommandMedlab As SqlCommand = New SqlCommand("DSN_REGISTRAR_RUTA_GUIAS_V2", oSqlConnectionMedlab)
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



    Public Sub ActualizarRuta_Guias(ByVal _xmlserializado As String, ByRef _tiporespuesta As String, ByRef _textorespuesta As String, ByRef idRentabilidad As String, ByRef fecHoraReg As String)
        Try
            Conexion = System.Configuration.ConfigurationManager.ConnectionStrings("ConexionHeadMark").ConnectionString

            Using oSqlConnectionMedlab As SqlConnection = New SqlConnection(Conexion)
                Using oSqlCommandMedlab As SqlCommand = New SqlCommand("DSN_ACTUALIZAR_RUTA_GUIAS_V2", oSqlConnectionMedlab)
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



    Public Function Listar_Rutas_Guias_Status(ByVal fecini As String, ByVal fecfin As String) As DataTable
        Try
            Dim _listadoRutas As New DataTable
            Conexion = System.Configuration.ConfigurationManager.ConnectionStrings("ConexionHeadMark").ConnectionString

            Using oSqlConnection As SqlConnection = New SqlConnection(Conexion)
                Dim _consulta As String = String.Empty
                '_consulta = "   SELECT A.ID,A.FECHA,A.HORA,A.nombre_razonSocial,A.Diferencia,A.Tiempo,A.TipoReclamo,A.reclamo,A.nombre_contacto,A.Telefono,A.DEPARTAMENTO,A.direccion   FROM " & _
                '"(SELECT id, nombre_razonSocial,CONVERT(VARCHAR,[fec_reg],103) as [FECHA], " & _
                '"CONVERT(VARCHAR,[fec_reg],108) as HORA, DATEDIFF(minute,fec_reg,getdate()) as Diferencia, '10' as Tiempo," & _
                '"(SELECT descripcion FROM TIPORECLAMO where idTipoRe= b.codreclamo) as [TipoReclamo],reclamo,nombre_contacto,Telefono," & _
                '"(SELECT UPPER(NOMBRE) FROM UBIGEO WHERE CODPROV = '00' and CODDIST = '00' and CODDPTO =b.CODDPTO) AS DEPARTAMENTO, b.direccion FROM RECLAMOS b) A "

                Using oSqlCommand As SqlCommand = New SqlCommand("SPDSN_LISTAR_RUTAS_X_FECHA", oSqlConnection)
                    oSqlCommand.CommandType = CommandType.StoredProcedure
                    oSqlCommand.Parameters.Add("@fecIni", SqlDbType.VarChar, 15).Value = fecini
                    oSqlCommand.Parameters.Add("@fecfin", SqlDbType.VarChar, 15).Value = fecfin


                    If (oSqlConnection.State = Data.ConnectionState.Closed) Then
                        oSqlConnection.Open()
                    End If

                    If (oSqlCommand.Connection.State = Data.ConnectionState.Closed) Then
                        oSqlCommand.Connection.Open()
                    End If

                    Using adapter As SqlDataAdapter = New SqlDataAdapter
                        adapter.SelectCommand = oSqlCommand
                        adapter.Fill(_listadoRutas)
                    End Using

                    If (oSqlCommand.Connection.State = Data.ConnectionState.Open) Then
                        oSqlCommand.Connection.Close()
                    End If

                    If (oSqlConnection.State = Data.ConnectionState.Open) Then
                        oSqlConnection.Close()
                    End If

                End Using
            End Using

            Return _listadoRutas

        Catch ex As Exception
            Return Nothing
        End Try
    End Function


    Public Function Listar_Rutas_Guias_Status_Transporte(ByVal fecini As String, ByVal fecfin As String, ByVal trd_ccodigo As String) As DataTable
        Try
            Dim _listadoRutas As New DataTable
            Conexion = System.Configuration.ConfigurationManager.ConnectionStrings("ConexionHeadMark").ConnectionString

            Using oSqlConnection As SqlConnection = New SqlConnection(Conexion)
                Dim _consulta As String = String.Empty

                Using oSqlCommand As SqlCommand = New SqlCommand("SPDSN_LISTAR_RUTAS_X_FECHA_TRANSPORTE", oSqlConnection)
                    oSqlCommand.CommandType = CommandType.StoredProcedure
                    oSqlCommand.Parameters.Add("@fecIni", SqlDbType.VarChar, 15).Value = fecini
                    oSqlCommand.Parameters.Add("@fecfin", SqlDbType.VarChar, 15).Value = fecfin
                    oSqlCommand.Parameters.Add("@trd_ccodigo", SqlDbType.VarChar, 20).Value = trd_ccodigo


                    If (oSqlConnection.State = Data.ConnectionState.Closed) Then
                        oSqlConnection.Open()
                    End If

                    If (oSqlCommand.Connection.State = Data.ConnectionState.Closed) Then
                        oSqlCommand.Connection.Open()
                    End If

                    Using adapter As SqlDataAdapter = New SqlDataAdapter
                        adapter.SelectCommand = oSqlCommand
                        adapter.Fill(_listadoRutas)
                    End Using

                    If (oSqlCommand.Connection.State = Data.ConnectionState.Open) Then
                        oSqlCommand.Connection.Close()
                    End If

                    If (oSqlConnection.State = Data.ConnectionState.Open) Then
                        oSqlConnection.Close()
                    End If

                End Using
            End Using

            Return _listadoRutas

        Catch ex As Exception
            Return Nothing
        End Try
    End Function


    Public Function Seguimiento_por_Ruta(ByVal nroRuta As String) As DataTable
        Try
            Dim _listadoRutas As New DataTable
            Conexion = System.Configuration.ConfigurationManager.ConnectionStrings("ConexionHeadMark").ConnectionString

            Using oSqlConnection As SqlConnection = New SqlConnection(Conexion)
                Dim _consulta As String = String.Empty
                '_consulta = "   SELECT A.ID,A.FECHA,A.HORA,A.nombre_razonSocial,A.Diferencia,A.Tiempo,A.TipoReclamo,A.reclamo,A.nombre_contacto,A.Telefono,A.DEPARTAMENTO,A.direccion   FROM " & _
                '"(SELECT id, nombre_razonSocial,CONVERT(VARCHAR,[fec_reg],103) as [FECHA], " & _
                '"CONVERT(VARCHAR,[fec_reg],108) as HORA, DATEDIFF(minute,fec_reg,getdate()) as Diferencia, '10' as Tiempo," & _
                '"(SELECT descripcion FROM TIPORECLAMO where idTipoRe= b.codreclamo) as [TipoReclamo],reclamo,nombre_contacto,Telefono," & _
                '"(SELECT UPPER(NOMBRE) FROM UBIGEO WHERE CODPROV = '00' and CODDIST = '00' and CODDPTO =b.CODDPTO) AS DEPARTAMENTO, b.direccion FROM RECLAMOS b) A "

                Using oSqlCommand As SqlCommand = New SqlCommand("SPDSN_SEGUIMIENTO_RUTA_V3", oSqlConnection)
                    oSqlCommand.CommandType = CommandType.StoredProcedure
                    oSqlCommand.Parameters.Add("@CRG_ID", SqlDbType.Int).Value = nroRuta

                    If (oSqlConnection.State = Data.ConnectionState.Closed) Then
                        oSqlConnection.Open()
                    End If

                    If (oSqlCommand.Connection.State = Data.ConnectionState.Closed) Then
                        oSqlCommand.Connection.Open()
                    End If

                    Using adapter As SqlDataAdapter = New SqlDataAdapter
                        adapter.SelectCommand = oSqlCommand
                        adapter.Fill(_listadoRutas)
                    End Using

                    If (oSqlCommand.Connection.State = Data.ConnectionState.Open) Then
                        oSqlCommand.Connection.Close()
                    End If

                    If (oSqlConnection.State = Data.ConnectionState.Open) Then
                        oSqlConnection.Close()
                    End If

                End Using
            End Using

            Return _listadoRutas

        Catch ex As Exception
            Return Nothing
        End Try
    End Function



    Public Function Cabecera_por_Ruta(ByVal nroRuta As String) As DataTable
        Try
            Dim _listadoRutas As New DataTable
            Conexion = System.Configuration.ConfigurationManager.ConnectionStrings("ConexionHeadMark").ConnectionString

            Using oSqlConnection As SqlConnection = New SqlConnection(Conexion)
                Dim _consulta As String = String.Empty
                '_consulta = "   SELECT A.ID,A.FECHA,A.HORA,A.nombre_razonSocial,A.Diferencia,A.Tiempo,A.TipoReclamo,A.reclamo,A.nombre_contacto,A.Telefono,A.DEPARTAMENTO,A.direccion   FROM " & _
                '"(SELECT id, nombre_razonSocial,CONVERT(VARCHAR,[fec_reg],103) as [FECHA], " & _
                '"CONVERT(VARCHAR,[fec_reg],108) as HORA, DATEDIFF(minute,fec_reg,getdate()) as Diferencia, '10' as Tiempo," & _
                '"(SELECT descripcion FROM TIPORECLAMO where idTipoRe= b.codreclamo) as [TipoReclamo],reclamo,nombre_contacto,Telefono," & _
                '"(SELECT UPPER(NOMBRE) FROM UBIGEO WHERE CODPROV = '00' and CODDIST = '00' and CODDPTO =b.CODDPTO) AS DEPARTAMENTO, b.direccion FROM RECLAMOS b) A "

                Using oSqlCommand As SqlCommand = New SqlCommand("SPDSN_CABECERA_RUTA", oSqlConnection)
                    oSqlCommand.CommandType = CommandType.StoredProcedure
                    oSqlCommand.Parameters.Add("@CRG_ID", SqlDbType.Int).Value = nroRuta

                    If (oSqlConnection.State = Data.ConnectionState.Closed) Then
                        oSqlConnection.Open()
                    End If

                    If (oSqlCommand.Connection.State = Data.ConnectionState.Closed) Then
                        oSqlCommand.Connection.Open()
                    End If

                    Using adapter As SqlDataAdapter = New SqlDataAdapter
                        adapter.SelectCommand = oSqlCommand
                        adapter.Fill(_listadoRutas)
                    End Using

                    If (oSqlCommand.Connection.State = Data.ConnectionState.Open) Then
                        oSqlCommand.Connection.Close()
                    End If

                    If (oSqlConnection.State = Data.ConnectionState.Open) Then
                        oSqlConnection.Close()
                    End If

                End Using
            End Using

            Return _listadoRutas

        Catch ex As Exception
            Return Nothing
        End Try
    End Function


    Public Function Obtener_Detalle_Ruta(ByVal nroRuta As String) As DataTable
        Try
            Dim _listadoRutas As New DataTable
            Conexion = System.Configuration.ConfigurationManager.ConnectionStrings("ConexionHeadMark").ConnectionString

            Using oSqlConnection As SqlConnection = New SqlConnection(Conexion)
                Dim _consulta As String = String.Empty


                Using oSqlCommand As SqlCommand = New SqlCommand("SPDSN_LISTAR_DETALLERUTA", oSqlConnection)
                    oSqlCommand.CommandType = CommandType.StoredProcedure
                    oSqlCommand.Parameters.Add("@CRG_ID", SqlDbType.Int).Value = nroRuta

                    If (oSqlConnection.State = Data.ConnectionState.Closed) Then
                        oSqlConnection.Open()
                    End If

                    If (oSqlCommand.Connection.State = Data.ConnectionState.Closed) Then
                        oSqlCommand.Connection.Open()
                    End If

                    Using adapter As SqlDataAdapter = New SqlDataAdapter
                        adapter.SelectCommand = oSqlCommand
                        adapter.Fill(_listadoRutas)
                    End Using

                    If (oSqlCommand.Connection.State = Data.ConnectionState.Open) Then
                        oSqlCommand.Connection.Close()
                    End If

                    If (oSqlConnection.State = Data.ConnectionState.Open) Then
                        oSqlConnection.Close()
                    End If

                End Using
            End Using

            Return _listadoRutas

        Catch ex As Exception
            Return Nothing
        End Try
    End Function



    Public Function Retorno_Ruta_xcargo_xguia(ByVal nroRuta As String, ByVal guia As String, ByVal estado As String, ByVal motivo As String) As DataTable
        Try
            Dim _listadoRutas As New DataTable
            Conexion = System.Configuration.ConfigurationManager.ConnectionStrings("ConexionHeadMark").ConnectionString

            Using oSqlConnection As SqlConnection = New SqlConnection(Conexion)
                Dim _consulta As String = String.Empty
                '_consulta = "   SELECT A.ID,A.FECHA,A.HORA,A.nombre_razonSocial,A.Diferencia,A.Tiempo,A.TipoReclamo,A.reclamo,A.nombre_contacto,A.Telefono,A.DEPARTAMENTO,A.direccion   FROM " & _
                '"(SELECT id, nombre_razonSocial,CONVERT(VARCHAR,[fec_reg],103) as [FECHA], " & _
                '"CONVERT(VARCHAR,[fec_reg],108) as HORA, DATEDIFF(minute,fec_reg,getdate()) as Diferencia, '10' as Tiempo," & _
                '"(SELECT descripcion FROM TIPORECLAMO where idTipoRe= b.codreclamo) as [TipoReclamo],reclamo,nombre_contacto,Telefono," & _
                '"(SELECT UPPER(NOMBRE) FROM UBIGEO WHERE CODPROV = '00' and CODDIST = '00' and CODDPTO =b.CODDPTO) AS DEPARTAMENTO, b.direccion FROM RECLAMOS b) A "

                Using oSqlCommand As SqlCommand = New SqlCommand("SPDSN_SEGUIMIENTO_RUTA", oSqlConnection)
                    oSqlCommand.CommandType = CommandType.StoredProcedure
                    oSqlCommand.Parameters.Add("@CRG_ID", SqlDbType.Int).Value = nroRuta

                    If (oSqlConnection.State = Data.ConnectionState.Closed) Then
                        oSqlConnection.Open()
                    End If

                    If (oSqlCommand.Connection.State = Data.ConnectionState.Closed) Then
                        oSqlCommand.Connection.Open()
                    End If

                    Using adapter As SqlDataAdapter = New SqlDataAdapter
                        adapter.SelectCommand = oSqlCommand
                        adapter.Fill(_listadoRutas)
                    End Using

                    If (oSqlCommand.Connection.State = Data.ConnectionState.Open) Then
                        oSqlCommand.Connection.Close()
                    End If

                    If (oSqlConnection.State = Data.ConnectionState.Open) Then
                        oSqlConnection.Close()
                    End If

                End Using
            End Using

            Return _listadoRutas

        Catch ex As Exception
            Return Nothing
        End Try
    End Function


    Public Sub Motivar_RutaGuia(ByVal c5_cnumdoc As String, ByVal est_codigo2 As String, ByVal mot_codigo As Integer, ByVal crg_id As Integer, ByVal usr_id As String, ByRef _tiporespuesta As String, ByRef _textorespuesta As String, ByRef idRentabilidad As String, ByRef fecHoraReg As String)
        Try
            Conexion = System.Configuration.ConfigurationManager.ConnectionStrings("ConexionHeadMark").ConnectionString

            Using oSqlConnectionMedlab As SqlConnection = New SqlConnection(Conexion)
                Using oSqlCommandMedlab As SqlCommand = New SqlCommand("SPDSN_MOTIVAR_RUTAGUIA_V2", oSqlConnectionMedlab)
                    oSqlCommandMedlab.CommandType = CommandType.StoredProcedure

                    oSqlCommandMedlab.Parameters.Add("@C5_CNUMDOC", SqlDbType.VarChar, 11).Value = c5_cnumdoc
                    oSqlCommandMedlab.Parameters.Add("@est_codigo2", SqlDbType.Char, 2).Value = est_codigo2
                    oSqlCommandMedlab.Parameters.Add("@usr_idRetornoRuta", SqlDbType.Int).Value = usr_id
                    oSqlCommandMedlab.Parameters.Add("@mot_codigo", SqlDbType.Int).Value = mot_codigo
                    oSqlCommandMedlab.Parameters.Add("@crg_id", SqlDbType.Int).Value = crg_id


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



    Public Sub Motivar_RutaGuia_Proveedor(ByVal c5_cnumdoc As String, ByVal est_codigo2 As String, ByVal mot_codigo As Integer, ByVal usr_id As String, ByRef _tiporespuesta As String, ByRef _textorespuesta As String, ByRef idRentabilidad As String, ByRef fecHoraReg As String)
        Try
            Conexion = System.Configuration.ConfigurationManager.ConnectionStrings("ConexionHeadMark").ConnectionString

            Using oSqlConnectionMedlab As SqlConnection = New SqlConnection(Conexion)
                Using oSqlCommandMedlab As SqlCommand = New SqlCommand("SPDSN_MOTIVAR_RUTAGUIA_PROVEEDOR", oSqlConnectionMedlab)
                    oSqlCommandMedlab.CommandType = CommandType.StoredProcedure

                    oSqlCommandMedlab.Parameters.Add("@C5_CNUMDOC", SqlDbType.VarChar, 11).Value = c5_cnumdoc
                    oSqlCommandMedlab.Parameters.Add("@est_codigo2", SqlDbType.Char, 2).Value = est_codigo2
                    oSqlCommandMedlab.Parameters.Add("@usr_idRetornoRuta", SqlDbType.Int).Value = usr_id
                    oSqlCommandMedlab.Parameters.Add("@mot_codigo", SqlDbType.Int).Value = mot_codigo



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



    Public Sub RegistrarFechaRetornoRuta(ByVal crg_id As String, ByVal c5_cnumdoc As String, ByVal fechaRecepClienteDate As String, ByVal fechaInterFacturaDate As String, ByVal fechaVtoOrdenCompraDate As String,
                                        ByVal fechaRecepClienteCadena As String, ByVal fechaInterFacturaCadena As String, ByVal fechaVtoOrdenCompraCadena As String, ByVal fechaReProgramacion As String,
                                        ByRef _tiporespuesta As String)

        Dim _textorespuesta As String = String.Empty

        Try
            Conexion = System.Configuration.ConfigurationManager.ConnectionStrings("ConexionHeadMark").ConnectionString

            Using oSqlConnectionMedlab As SqlConnection = New SqlConnection(Conexion)
                Using oSqlCommandMedlab As SqlCommand = New SqlCommand("SPDSN_ACTUALIZAR_FECHARUTA_V3", oSqlConnectionMedlab)
                    oSqlCommandMedlab.CommandType = CommandType.StoredProcedure

                    oSqlCommandMedlab.Parameters.Add("@CRG_ID", SqlDbType.Int).Value = crg_id
                    oSqlCommandMedlab.Parameters.Add("@C5_CNUMDOC", SqlDbType.VarChar, 15).Value = c5_cnumdoc.Trim
                    oSqlCommandMedlab.Parameters.Add("@fechaRecepClienteDate", SqlDbType.VarChar, 20).Value = fechaRecepClienteDate
                    oSqlCommandMedlab.Parameters.Add("@fechaInterFacturaDate", SqlDbType.VarChar, 20).Value = fechaInterFacturaDate
                    oSqlCommandMedlab.Parameters.Add("@fechaVtoOrdenCompraDate", SqlDbType.VarChar, 20).Value = fechaInterFacturaDate

                    oSqlCommandMedlab.Parameters.Add("@fechaRecepClienteCadena", SqlDbType.VarChar, 20).Value = fechaRecepClienteCadena
                    oSqlCommandMedlab.Parameters.Add("@fechaInterFacturaCadena", SqlDbType.VarChar, 20).Value = fechaInterFacturaCadena
                    oSqlCommandMedlab.Parameters.Add("@fechaVtoOrdenCompraCadena", SqlDbType.VarChar, 20).Value = fechaInterFacturaCadena

                    oSqlCommandMedlab.Parameters.Add("@fechaReProgramacion", SqlDbType.VarChar, 20).Value = fechaReProgramacion


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
                            'idRentabilidad = oSqlDataReader.GetValue(2).ToString()
                            'fecHoraReg = oSqlDataReader.GetValue(3).ToString()
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
            '_textorespuesta = ex.Message
        End Try
    End Sub


    Public Sub RegistrarFechaRetornoRuta_SinRuta(ByVal c5_cnumdoc As String, ByVal fechaRecepClienteDate As String, ByVal fechaInterFacturaDate As String, ByVal fechaVtoOrdenCompraDate As String,
                                        ByVal fechaRecepClienteCadena As String, ByVal fechaInterFacturaCadena As String, ByVal fechaVtoOrdenCompraCadena As String, ByVal fechaReProgramacion As String,
                                        ByRef _tiporespuesta As String)

        Dim _textorespuesta As String = String.Empty

        Try
            Conexion = System.Configuration.ConfigurationManager.ConnectionStrings("ConexionHeadMark").ConnectionString

            Using oSqlConnectionMedlab As SqlConnection = New SqlConnection(Conexion)
                Using oSqlCommandMedlab As SqlCommand = New SqlCommand("SPDSN_ACTUALIZAR_FECHARUTA_SINRUTA_V2", oSqlConnectionMedlab)
                    oSqlCommandMedlab.CommandType = CommandType.StoredProcedure

                    'oSqlCommandMedlab.Parameters.Add("@CRG_ID", SqlDbType.Int).Value = crg_id
                    oSqlCommandMedlab.Parameters.Add("@C5_CNUMDOC", SqlDbType.VarChar, 15).Value = c5_cnumdoc.Trim
                    oSqlCommandMedlab.Parameters.Add("@fechaRecepClienteDate", SqlDbType.VarChar, 20).Value = fechaRecepClienteDate
                    oSqlCommandMedlab.Parameters.Add("@fechaInterFacturaDate", SqlDbType.VarChar, 20).Value = fechaInterFacturaDate
                    oSqlCommandMedlab.Parameters.Add("@fechaVtoOrdenCompraDate", SqlDbType.VarChar, 20).Value = fechaVtoOrdenCompraDate

                    oSqlCommandMedlab.Parameters.Add("@fechaRecepClienteCadena", SqlDbType.VarChar, 20).Value = fechaRecepClienteCadena
                    oSqlCommandMedlab.Parameters.Add("@fechaInterFacturaCadena", SqlDbType.VarChar, 20).Value = fechaInterFacturaCadena
                    oSqlCommandMedlab.Parameters.Add("@fechaVtoOrdenCompraCadena", SqlDbType.VarChar, 20).Value = fechaVtoOrdenCompraCadena

                    oSqlCommandMedlab.Parameters.Add("@fechaReProgramacion", SqlDbType.VarChar, 20).Value = fechaReProgramacion


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
                            'idRentabilidad = oSqlDataReader.GetValue(2).ToString()
                            'fecHoraReg = oSqlDataReader.GetValue(3).ToString()
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
            '_textorespuesta = ex.Message
        End Try
    End Sub

    Public Function Reporte_Despachos_Filtros(ByVal flag As String, ByVal fecIni As String, ByVal fecFin As String, ByVal trd_ccodigo As String, ByVal est_codigo As String, ByVal c5_cnumdoc As String) As DataTable
        Try
            Dim _listadoRutas As New DataTable
            Conexion = System.Configuration.ConfigurationManager.ConnectionStrings("ConexionHeadMark").ConnectionString

            Using oSqlConnection As SqlConnection = New SqlConnection(Conexion)
                Dim _consulta As String = String.Empty
                '_consulta = "   SELECT A.ID,A.FECHA,A.HORA,A.nombre_razonSocial,A.Diferencia,A.Tiempo,A.TipoReclamo,A.reclamo,A.nombre_contacto,A.Telefono,A.DEPARTAMENTO,A.direccion   FROM " & _
                '"(SELECT id, nombre_razonSocial,CONVERT(VARCHAR,[fec_reg],103) as [FECHA], " & _
                '"CONVERT(VARCHAR,[fec_reg],108) as HORA, DATEDIFF(minute,fec_reg,getdate()) as Diferencia, '10' as Tiempo," & _
                '"(SELECT descripcion FROM TIPORECLAMO where idTipoRe= b.codreclamo) as [TipoReclamo],reclamo,nombre_contacto,Telefono," & _
                '"(SELECT UPPER(NOMBRE) FROM UBIGEO WHERE CODPROV = '00' and CODDIST = '00' and CODDPTO =b.CODDPTO) AS DEPARTAMENTO, b.direccion FROM RECLAMOS b) A "

                Using oSqlCommand As SqlCommand = New SqlCommand("SPDSN_REPORTE_DESPACHOS_FILTROS", oSqlConnection)
                    oSqlCommand.CommandType = CommandType.StoredProcedure
                    oSqlCommand.Parameters.Add("@flag", SqlDbType.Int).Value = flag
                    oSqlCommand.Parameters.Add("@fecIni", SqlDbType.VarChar, 20).Value = fecIni
                    oSqlCommand.Parameters.Add("@fecFin", SqlDbType.VarChar, 20).Value = fecFin
                    oSqlCommand.Parameters.Add("@trd_ccodigo", SqlDbType.VarChar, 20).Value = trd_ccodigo
                    oSqlCommand.Parameters.Add("@est_codigo", SqlDbType.VarChar, 2).Value = est_codigo
                    oSqlCommand.Parameters.Add("@c5_cnumdoc", SqlDbType.VarChar, 20).Value = c5_cnumdoc




                    If (oSqlConnection.State = Data.ConnectionState.Closed) Then
                        oSqlConnection.Open()
                    End If

                    If (oSqlCommand.Connection.State = Data.ConnectionState.Closed) Then
                        oSqlCommand.Connection.Open()
                    End If

                    Using adapter As SqlDataAdapter = New SqlDataAdapter
                        adapter.SelectCommand = oSqlCommand
                        adapter.Fill(_listadoRutas)
                    End Using

                    If (oSqlCommand.Connection.State = Data.ConnectionState.Open) Then
                        oSqlCommand.Connection.Close()
                    End If

                    If (oSqlConnection.State = Data.ConnectionState.Open) Then
                        oSqlConnection.Close()
                    End If

                End Using
            End Using

            Return _listadoRutas

        Catch ex As Exception
            Return Nothing
        End Try
    End Function


    Public Function ReporteSeguimientoDespachos(ByVal fecIni As String, ByVal fecFin As String) As DataTable
        Try
            Dim _listadoRutas As New DataTable
            Conexion = System.Configuration.ConfigurationManager.ConnectionStrings("ConexionHeadMark").ConnectionString

            Using oSqlConnection As SqlConnection = New SqlConnection(Conexion)
                Dim _consulta As String = String.Empty
                '_consulta = "   SELECT A.ID,A.FECHA,A.HORA,A.nombre_razonSocial,A.Diferencia,A.Tiempo,A.TipoReclamo,A.reclamo,A.nombre_contacto,A.Telefono,A.DEPARTAMENTO,A.direccion   FROM " & _
                '"(SELECT id, nombre_razonSocial,CONVERT(VARCHAR,[fec_reg],103) as [FECHA], " & _
                '"CONVERT(VARCHAR,[fec_reg],108) as HORA, DATEDIFF(minute,fec_reg,getdate()) as Diferencia, '10' as Tiempo," & _
                '"(SELECT descripcion FROM TIPORECLAMO where idTipoRe= b.codreclamo) as [TipoReclamo],reclamo,nombre_contacto,Telefono," & _
                '"(SELECT UPPER(NOMBRE) FROM UBIGEO WHERE CODPROV = '00' and CODDIST = '00' and CODDPTO =b.CODDPTO) AS DEPARTAMENTO, b.direccion FROM RECLAMOS b) A "

                Using oSqlCommand As SqlCommand = New SqlCommand("SPDSN_INDICADORES_DESPACHOS", oSqlConnection)
                    oSqlCommand.CommandType = CommandType.StoredProcedure
                    oSqlCommand.Parameters.Add("@FECINI", SqlDbType.VarChar, 12).Value = fecIni
                    oSqlCommand.Parameters.Add("@FECFIN", SqlDbType.VarChar, 12).Value = fecFin


                    If (oSqlConnection.State = Data.ConnectionState.Closed) Then
                        oSqlConnection.Open()
                    End If

                    If (oSqlCommand.Connection.State = Data.ConnectionState.Closed) Then
                        oSqlCommand.Connection.Open()
                    End If

                    Using adapter As SqlDataAdapter = New SqlDataAdapter
                        adapter.SelectCommand = oSqlCommand
                        adapter.Fill(_listadoRutas)
                    End Using

                    If (oSqlCommand.Connection.State = Data.ConnectionState.Open) Then
                        oSqlCommand.Connection.Close()
                    End If

                    If (oSqlConnection.State = Data.ConnectionState.Open) Then
                        oSqlConnection.Close()
                    End If

                End Using
            End Using

            Return _listadoRutas

        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function ReporteSeguimientoDespachos_Rechazados(ByVal fecIni As String, ByVal fecFin As String) As DataTable
        Try
            Dim _listadoRutas As New DataTable
            Conexion = System.Configuration.ConfigurationManager.ConnectionStrings("ConexionHeadMark").ConnectionString

            Using oSqlConnection As SqlConnection = New SqlConnection(Conexion)
                Dim _consulta As String = String.Empty
                '_consulta = "   SELECT A.ID,A.FECHA,A.HORA,A.nombre_razonSocial,A.Diferencia,A.Tiempo,A.TipoReclamo,A.reclamo,A.nombre_contacto,A.Telefono,A.DEPARTAMENTO,A.direccion   FROM " & _
                '"(SELECT id, nombre_razonSocial,CONVERT(VARCHAR,[fec_reg],103) as [FECHA], " & _
                '"CONVERT(VARCHAR,[fec_reg],108) as HORA, DATEDIFF(minute,fec_reg,getdate()) as Diferencia, '10' as Tiempo," & _
                '"(SELECT descripcion FROM TIPORECLAMO where idTipoRe= b.codreclamo) as [TipoReclamo],reclamo,nombre_contacto,Telefono," & _
                '"(SELECT UPPER(NOMBRE) FROM UBIGEO WHERE CODPROV = '00' and CODDIST = '00' and CODDPTO =b.CODDPTO) AS DEPARTAMENTO, b.direccion FROM RECLAMOS b) A "

                Using oSqlCommand As SqlCommand = New SqlCommand("SPDSN_INDICADORES_DESPACHOS_RECHAZADOS", oSqlConnection)
                    oSqlCommand.CommandType = CommandType.StoredProcedure
                    oSqlCommand.Parameters.Add("@FECINI", SqlDbType.VarChar, 12).Value = fecIni
                    oSqlCommand.Parameters.Add("@FECFIN", SqlDbType.VarChar, 12).Value = fecFin


                    If (oSqlConnection.State = Data.ConnectionState.Closed) Then
                        oSqlConnection.Open()
                    End If

                    If (oSqlCommand.Connection.State = Data.ConnectionState.Closed) Then
                        oSqlCommand.Connection.Open()
                    End If

                    Using adapter As SqlDataAdapter = New SqlDataAdapter
                        adapter.SelectCommand = oSqlCommand
                        adapter.Fill(_listadoRutas)
                    End Using

                    If (oSqlCommand.Connection.State = Data.ConnectionState.Open) Then
                        oSqlCommand.Connection.Close()
                    End If

                    If (oSqlConnection.State = Data.ConnectionState.Open) Then
                        oSqlConnection.Close()
                    End If

                End Using
            End Using

            Return _listadoRutas

        Catch ex As Exception
            Return Nothing
        End Try
    End Function


End Class
