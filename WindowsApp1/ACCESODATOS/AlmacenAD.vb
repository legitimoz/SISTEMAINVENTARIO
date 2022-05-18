Imports System.Data.SqlClient

Public Class AlmacenAD
    Inherits conexion


    Public Function Obtener_Transportistas_paraRotulos() As DataTable
        Try
            Dim com As New SqlCommand("ListarTransportistas_Rotulos", MyBase.Conn)
            MyBase.Conn.Open()
            com.CommandType = CommandType.StoredProcedure
            Dim Result As SqlDataReader
            Dim Tabla As New DataTable
            Result = com.ExecuteReader()
            Tabla.Load(Result)
            MyBase.Conn.Close()
            Return Tabla
        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Public Function SP_CSE_ValidarAlerta() As DataTable
        Try
            Dim com As New SqlCommand("SP_CSE_ValidarAlerta", MyBase.Conn)
            MyBase.Conn.Open()
            com.CommandType = CommandType.StoredProcedure
            Dim Result As SqlDataReader
            Dim Tabla As New DataTable
            Result = com.ExecuteReader()
            Tabla.Load(Result)
            MyBase.Conn.Close()
            Return Tabla
        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Public Function CSE_SP_LISTAR_TIEMPSO_JJ() As DataTable
        Try
            Dim com As New SqlCommand("CSE_SP_LISTAR_TIEMPSO_JJ", MyBase.Conn)
            MyBase.Conn.Open()
            com.CommandType = CommandType.StoredProcedure
            Dim Result As SqlDataReader
            Dim Tabla As New DataTable
            Result = com.ExecuteReader()
            Tabla.Load(Result)
            MyBase.Conn.Close()
            Return Tabla
        Catch ex As Exception
            Return Nothing
        End Try

    End Function


    Public Function SP_OBTENER_COSTOS() As DataTable
        Try
            Dim com As New SqlCommand("SP_OBTENER_COSTOS", MyBase.Conn)
            MyBase.Conn.Open()
            com.CommandType = CommandType.StoredProcedure
            Dim Result As SqlDataReader
            Dim Tabla As New DataTable
            Result = com.ExecuteReader()
            Tabla.Load(Result)
            MyBase.Conn.Close()
            Return Tabla
        Catch ex As Exception
            Return Nothing
        End Try

    End Function


    Public Function ListarTiemposEntrega() As DataTable
        Try
            Dim com As New SqlCommand("SP_CSE_LISTAR_TIEMPOS", MyBase.Conn)
            MyBase.Conn.Open()
            com.CommandType = CommandType.StoredProcedure
            Dim Result As SqlDataReader
            Dim Tabla As New DataTable
            Result = com.ExecuteReader()
            Tabla.Load(Result)
            MyBase.Conn.Close()
            Return Tabla
        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Public Function ListarRutas() As DataTable
        Try
            Dim com As New SqlCommand("SP_CSE_LISTAR_RUTAS", MyBase.Conn)
            MyBase.Conn.Open()
            com.CommandType = CommandType.StoredProcedure
            Dim Result As SqlDataReader
            Dim Tabla As New DataTable
            Result = com.ExecuteReader()
            Tabla.Load(Result)
            MyBase.Conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
            Return Nothing
            MyBase.Conn.Close()
        End Try
    End Function

    Public Function Reporte_Articulos_Sin_Ubicar(idalmacen As Integer, idsite As Integer) As DataTable
        Try
            Dim com As New SqlCommand("SP_CSE_ARTICULOS_SIN_UBICACION", MyBase.Conn)
            MyBase.Conn.Open()
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@idalmacen", SqlDbType.Int).Value = idalmacen
            com.Parameters.Add("@idsite", SqlDbType.Int).Value = idsite
            Dim Result As SqlDataReader
            Dim Tabla As New DataTable
            Result = com.ExecuteReader()
            Tabla.Load(Result)
            MyBase.Conn.Close()
            Return Tabla
        Catch ex As Exception
            MyBase.Conn.Close()
            Throw ex
            Return Nothing
        End Try

    End Function

    Public Function SP_CSE_ObtenerEstadoValidacion(CodArticulo As String) As DataTable
        Try
            Dim com As New SqlCommand("SP_CSE_ObtenerEstadoValidacion", MyBase.Conn)
            MyBase.Conn.Open()
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@codarticulo", SqlDbType.Char, 25).Value = CodArticulo

            Dim Result As SqlDataReader
            Dim Tabla As New DataTable
            Result = com.ExecuteReader()
            Tabla.Load(Result)
            MyBase.Conn.Close()
            Return Tabla
        Catch ex As Exception
            MyBase.Conn.Close()
            Throw ex
            Return Nothing
        End Try

    End Function

    Public Function SP_LISTAR_ARTICULOS_CUBICAJE() As DataTable
        Try
            Dim com As New SqlCommand("SP_LISTAR_ARTICULOS_CUBICAJE", MyBase.Conn)
            MyBase.Conn.Open()
            com.CommandType = CommandType.StoredProcedure


            Dim Result As SqlDataReader
            Dim Tabla As New DataTable
            Result = com.ExecuteReader()
            Tabla.Load(Result)
            MyBase.Conn.Close()
            Return Tabla
        Catch ex As Exception
            MyBase.Conn.Close()
            Throw ex
            Return Nothing
        End Try

    End Function


    Public Function ListarTransportistaDespacho() As DataTable
        Try
            Dim com As New SqlCommand("SP_ListarTransportista", MyBase.Conn)
            MyBase.Conn.Open()
            com.CommandType = CommandType.StoredProcedure
            Dim Result As SqlDataReader
            Dim Tabla As New DataTable
            Result = com.ExecuteReader()
            Tabla.Load(Result)
            MyBase.Conn.Close()
            Return Tabla
        Catch ex As Exception
            MyBase.Conn.Close()
            Throw ex
            Return Nothing
        End Try

    End Function

    Public Function ListarVehiculoDespacho(ByVal idsite As Integer) As DataTable
        Try
            Dim com As New SqlCommand("SP_ListarVehiculo", MyBase.Conn)
            MyBase.Conn.Open()
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@idsite", SqlDbType.Int).Value = idsite
            Dim Result As SqlDataReader
            Dim Tabla As New DataTable
            Result = com.ExecuteReader()
            Tabla.Load(Result)
            MyBase.Conn.Close()
            Return Tabla
        Catch ex As Exception
            MyBase.Conn.Close()
            Throw ex
            Return Nothing
        End Try

    End Function

    Public Function ListarUbicacionesXSite_Almacen(ByVal idsite As Integer, ByVal idalmacen As Integer) As DataTable

        Try
            Dim com As New SqlCommand("SP_CSE_ListarUbicacionesXSite_Almacen", MyBase.Conn)
            MyBase.Conn.Open()
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@idalmacen", SqlDbType.Int).Value = idalmacen
            com.Parameters.Add("@idsite", SqlDbType.Int).Value = idsite

            Dim Result As SqlDataReader
            Dim Tabla As New DataTable
            Result = com.ExecuteReader()
            Tabla.Load(Result)
            MyBase.Conn.Close()
            Return Tabla
        Catch ex As Exception
            MyBase.Conn.Close()
            Throw ex
            Return Nothing
        End Try

    End Function

    Public Function ReporteRotulosProducto(ByVal CALMA As String, ByVal CTD As String, CNUMDOC As String) As DataTable

        Try
            Dim com As New SqlCommand("SP_CSE_RotulosArticulo", MyBase.Conn)
            MyBase.Conn.Open()
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@CALMA", SqlDbType.Char, 4).Value = CALMA
            com.Parameters.Add("@CTD", SqlDbType.Char, 2).Value = CTD
            com.Parameters.Add("@CNUMDOC", SqlDbType.Char, 11).Value = CNUMDOC

            Dim Result As SqlDataReader
            Dim Tabla As New DataTable
            Result = com.ExecuteReader()
            Tabla.Load(Result)
            MyBase.Conn.Close()
            Return Tabla
        Catch ex As Exception
            MyBase.Conn.Close()
            Throw ex
            Return Nothing
        End Try

    End Function


    Public Function BuscarUbicacionArticulo(idalmacen As Integer, idsite As Integer) As DataTable

        Try
            Dim com As New SqlCommand("SP_CSE_BuscarUbicacionArticulo", MyBase.Conn)
            MyBase.Conn.Open()
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@idalmacen", SqlDbType.Int).Value = idalmacen
            com.Parameters.Add("@idsite", SqlDbType.Int).Value = idsite
            Dim Result As SqlDataReader
            Dim Tabla As New DataTable
            Result = com.ExecuteReader()
            Tabla.Load(Result)
            MyBase.Conn.Close()
            Return Tabla
        Catch ex As Exception
            MyBase.Conn.Close()
            Throw ex
            Return Nothing
        End Try

    End Function

    Public Function ListarPosicionesXArticulo(ByVal codarticulo As String, idsite As Integer, idalmacen As Integer) As DataTable

        Try
            Dim com As New SqlCommand("Obtener_PosicionesArticuloV2", MyBase.Conn)
            MyBase.Conn.Open()
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@codarticulo", SqlDbType.Char, 25).Value = codarticulo
            com.Parameters.Add("@idsite", SqlDbType.Int).Value = idsite
            com.Parameters.Add("@idalmacen", SqlDbType.Int).Value = idalmacen
            Dim Result As SqlDataReader
            Dim Tabla As New DataTable
            Result = com.ExecuteReader()
            Tabla.Load(Result)
            MyBase.Conn.Close()
            Return Tabla
        Catch ex As Exception
            MyBase.Conn.Close()
            Throw ex
            Return Nothing
        End Try

    End Function

    Public Function ObtenerFactoresArticulo(ByVal codarticulo As String) As DataTable

        Try
            Dim com As New SqlCommand("SP_CSE_ObtenerFactoresArticulo", MyBase.Conn)
            MyBase.Conn.Open()
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@codarticulo", SqlDbType.Char, 25).Value = codarticulo
            Dim Result As SqlDataReader
            Dim Tabla As New DataTable
            Result = com.ExecuteReader()
            Tabla.Load(Result)
            MyBase.Conn.Close()
            Return Tabla
        Catch ex As Exception
            MyBase.Conn.Close()
            Throw ex
            Return Nothing
        End Try

    End Function

    Public Function ListarAlmacenes(ByVal idsite As Integer, ByVal codalmacen As String) As DataTable

        Try
            Dim com As New SqlCommand("SP_CSE_ListarAlmacenes", MyBase.Conn)
            MyBase.Conn.Open()
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@idsite", SqlDbType.Int).Value = idsite
            com.Parameters.Add("@codalm", SqlDbType.Char, 5).Value = codalmacen
            Dim Result As SqlDataReader
            Dim Tabla As New DataTable
            Result = com.ExecuteReader()
            Tabla.Load(Result)
            MyBase.Conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
            MyBase.Conn.Close()
        End Try

    End Function

    Public Function ObtenrCodigoAlternoArticulo(CodArticulo As String, Serie As String) As DataTable

        Try
            Dim com As New SqlCommand("SP_CSE_OBTENERCODIGOALTERNO", MyBase.Conn)
            MyBase.Conn.Open()
            com.CommandType = CommandType.StoredProcedure
            'com.Parameters.Add("@CodArticulo", SqlDbType.Int).Value = idsite
            com.Parameters.Add("@CodArticulo", SqlDbType.Char, 25).Value = CodArticulo
            com.Parameters.Add("@Serie", SqlDbType.Char, 18).Value = Serie
            Dim Result As SqlDataReader
            Dim Tabla As New DataTable
            Result = com.ExecuteReader()
            Tabla.Load(Result)
            MyBase.Conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
            MyBase.Conn.Close()
        End Try

    End Function

    Public Function ListarConceptosObservacion() As DataTable
        Try
            Dim com As New SqlCommand("CSE_SP_ListarConceptosObservacion", MyBase.Conn)
            MyBase.Conn.Open()
            com.CommandType = CommandType.StoredProcedure
            Dim Result As SqlDataReader
            Dim Tabla As New DataTable
            Result = com.ExecuteReader()
            Tabla.Load(Result)
            MyBase.Conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
            MyBase.Conn.Close()
        End Try
    End Function

    Public Function ObtenerPosicionesHojaPicking(ByVal codarticulo As String, ByVal Lote As String, cantidadrequerida As Decimal, idalmacen As Integer, idsite As Integer, PerfilUsuario As Integer) As DataTable
        Try
            Dim com As New SqlCommand("CSE_SP_OBTENER_POSICIONES_SALIDA", MyBase.Conn)
            MyBase.Conn.Open()
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@codarticulo", SqlDbType.Char, 25).Value = codarticulo
            com.Parameters.Add("@lote", SqlDbType.Char, 18).Value = Lote
            com.Parameters.Add("@cantidadreq", SqlDbType.Decimal).Value = cantidadrequerida
            com.Parameters.Add("@idalmacen", SqlDbType.Int).Value = idalmacen
            com.Parameters.Add("@idsite", SqlDbType.Int).Value = idsite
            com.Parameters.Add("@perfil", SqlDbType.Int).Value = PerfilUsuario
            Dim Result As SqlDataReader
            Dim Tabla As New DataTable
            Result = com.ExecuteReader()
            Tabla.Load(Result)
            MyBase.Conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
            MyBase.Conn.Close()
        End Try
    End Function

    Public Function ObtenerCantidadSalidaDetalle(calma As String, ctd As String, cnumdoc As String, codarticulo As String, serie As String, item As String, idsite As Integer, idalmacen As Integer) As DataTable

        Try
            Dim com As New SqlCommand("SP_CSE_OBTENER_CANT_SALIDA", MyBase.Conn)
            MyBase.Conn.Open()
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@calma", SqlDbType.Char, 4).Value = calma
            com.Parameters.Add("@ctd", SqlDbType.Char, 2).Value = ctd
            com.Parameters.Add("@cnumdoc", SqlDbType.Char, 11).Value = cnumdoc
            com.Parameters.Add("@codarticulo", SqlDbType.Char, 25).Value = codarticulo
            com.Parameters.Add("@serie", SqlDbType.Char, 18).Value = serie
            com.Parameters.Add("@item", SqlDbType.Char, 4).Value = item
            com.Parameters.Add("@idsite", SqlDbType.Int).Value = idsite
            com.Parameters.Add("@idalmacen", SqlDbType.Int).Value = idalmacen
            Dim Result As SqlDataReader
            Dim Tabla As New DataTable
            Result = com.ExecuteReader()
            Tabla.Load(Result)
            MyBase.Conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
            MyBase.Conn.Close()
        End Try

    End Function

    Public Function ObtenerComplementeArticulo(codarticulo As String, idsite As Integer, idalmacen As Integer) As DataTable
        Try
            Dim com As New SqlCommand("SP_CSE_OBTENER_CAPACIDAD", MyBase.Conn)
            MyBase.Conn.Open()
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@codarticulo", SqlDbType.Char, 25).Value = codarticulo
            com.Parameters.Add("@idsite", SqlDbType.Int).Value = idsite
            com.Parameters.Add("@idalmacen", SqlDbType.Int).Value = idalmacen
            Dim Result As SqlDataReader
            Dim Tabla As New DataTable
            Result = com.ExecuteReader()
            Tabla.Load(Result)
            MyBase.Conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
            MyBase.Conn.Close()
        End Try

    End Function

    Public Function ListarMovimientosXposicion(ByVal idposicion As Integer) As DataTable

        Try
            Dim com As New SqlCommand("SP_CSE_ReporteMovimientos", MyBase.Conn)
            MyBase.Conn.Open()
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@idposicion", SqlDbType.Int).Value = idposicion
            Dim Result As SqlDataReader
            Dim Tabla As New DataTable
            Result = com.ExecuteReader()
            Tabla.Load(Result)
            MyBase.Conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
            MyBase.Conn.Close()
        End Try

    End Function

    Public Function ListarUbicacionesVacias(idalmacen As Integer, idsite As Integer) As DataTable

        Try
            Dim com As New SqlCommand("SP_UBICACIONES_VACIAS", MyBase.Conn)
            MyBase.Conn.Open()
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@idalmacen", SqlDbType.Int).Value = idalmacen
            com.Parameters.Add("@idsite", SqlDbType.Int).Value = idsite
            Dim Result As SqlDataReader
            Dim Tabla As New DataTable
            Result = com.ExecuteReader()
            Tabla.Load(Result)
            MyBase.Conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
            MyBase.Conn.Close()
        End Try

    End Function

    Public Function SP_CSE_REPORTE_RUTAS(fechadesde As String, fechahasta As String) As DataTable
        Try
            Dim com As New SqlCommand("SP_CSE_REPORTE_RUTAS", MyBase.Conn)
            MyBase.Conn.Open()
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@fechainicio", SqlDbType.Char, 10).Value = fechadesde
            com.Parameters.Add("@fechafin", SqlDbType.Char, 10).Value = fechahasta
            Dim Result As SqlDataReader
            Dim Tabla As New DataTable
            Result = com.ExecuteReader()
            Tabla.Load(Result)
            MyBase.Conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
            MyBase.Conn.Close()
        End Try
    End Function

    Public Function SP_CSE_REPORTE_DESPACHOS(fechadesde As String, fechahasta As String) As DataTable
        Try
            Dim com As New SqlCommand("SP_CSE_REPORTE_DESPACHOS", MyBase.Conn)
            MyBase.Conn.Open()
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@fechainicio", SqlDbType.Char, 10).Value = fechadesde
            com.Parameters.Add("@fechafin", SqlDbType.Char, 10).Value = fechahasta
            Dim Result As SqlDataReader
            Dim Tabla As New DataTable
            Result = com.ExecuteReader()
            Tabla.Load(Result)
            MyBase.Conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
            MyBase.Conn.Close()
        End Try
    End Function

    Public Function ListarMovimientosXAlmacen(ByVal idalmacen As Integer, fechadesde As String, fechahasta As String) As DataTable

        Try
            Dim com As New SqlCommand("SP_CSE_ReporteMovimientosXAlmacen", MyBase.Conn)
            MyBase.Conn.Open()
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@idalmacen", SqlDbType.Int).Value = idalmacen
            com.Parameters.Add("@fechadesde", SqlDbType.Char, 10).Value = fechadesde
            com.Parameters.Add("@fechahasta", SqlDbType.Char, 10).Value = fechahasta
            Dim Result As SqlDataReader
            Dim Tabla As New DataTable
            Result = com.ExecuteReader()
            Tabla.Load(Result)
            MyBase.Conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
            MyBase.Conn.Close()
        End Try

    End Function

    Public Function ListarAlmacenesSoftcom() As DataTable

        Try
            Dim com As New SqlCommand("SP_CSE_ListarAlmacenesSoftcom", MyBase.Conn)
            MyBase.Conn.Open()
            com.CommandType = CommandType.StoredProcedure
            Dim Result As SqlDataReader
            Dim Tabla As New DataTable
            Result = com.ExecuteReader()
            Tabla.Load(Result)
            MyBase.Conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
            MyBase.Conn.Close()
        End Try

    End Function

    Public Function ListarRacks(idalmacen As Integer) As DataTable

        Try
            Dim com As New SqlCommand("SP_CSE_ListarRacks", MyBase.Conn)
            MyBase.Conn.Open()
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@idalmacen", SqlDbType.NVarChar).Value = idalmacen
            Dim Result As SqlDataReader
            Dim Tabla As New DataTable
            Result = com.ExecuteReader()
            Tabla.Load(Result)
            MyBase.Conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
            MyBase.Conn.Close()
        End Try

    End Function


    Public Function ListarStockPosicion(idubicacion As Integer) As DataTable

        Try
            Dim com As New SqlCommand("SP_STOCK_POSICION", MyBase.Conn)
            MyBase.Conn.Open()
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@idubicacion", SqlDbType.Int).Value = idubicacion
            Dim Result As SqlDataReader
            Dim Tabla As New DataTable
            Result = com.ExecuteReader()
            Tabla.Load(Result)
            MyBase.Conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
            MyBase.Conn.Close()
        End Try

    End Function

    Public Function ListarSites() As DataTable

        Try
            Dim com As New SqlCommand("SP_CSE_LISTAR_SITES", MyBase.Conn)
            MyBase.Conn.Open()
            com.CommandType = CommandType.StoredProcedure
            Dim Result As SqlDataReader
            Dim Tabla As New DataTable
            Result = com.ExecuteReader()
            Tabla.Load(Result)
            MyBase.Conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
            MyBase.Conn.Close()
        End Try

    End Function

    Public Function ListarPosiciones(idRack As Integer) As DataTable

        Try
            Dim com As New SqlCommand("SP_CSE_ListarEspacios", MyBase.Conn)
            MyBase.Conn.Open()
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@idrack", SqlDbType.NVarChar).Value = idRack
            Dim Result As SqlDataReader
            Dim Tabla As New DataTable
            Result = com.ExecuteReader()
            Tabla.Load(Result)
            MyBase.Conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
            MyBase.Conn.Close()
        End Try

    End Function

    Public Function ListarPosicionesCompletar(idRack As Integer) As DataTable
        Try
            Dim com As New SqlCommand("SP_CSE_ListarEspaciosCompletar", MyBase.Conn)
            MyBase.Conn.Open()
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@idrack", SqlDbType.NVarChar).Value = idRack
            Dim Result As SqlDataReader
            Dim Tabla As New DataTable
            Result = com.ExecuteReader()
            Tabla.Load(Result)
            MyBase.Conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
            MyBase.Conn.Close()
        End Try

    End Function

    Public Function ListarParteEntradaCAB(fechadesde As String, fechahasta As String, idalmacen As Integer, idsite As Integer) As DataTable

        Try
            Dim com As New SqlCommand("SP_CSE_ListarParteEntradaCAB", MyBase.Conn)
            MyBase.Conn.Open()
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@fechadesde", SqlDbType.Char, 10).Value = fechadesde
            com.Parameters.Add("@fechahasta", SqlDbType.Char, 10).Value = fechahasta
            com.Parameters.Add("@idalmacen", SqlDbType.Int).Value = idalmacen
            com.Parameters.Add("@idsite", SqlDbType.Int).Value = idsite
            Dim Result As SqlDataReader
            Dim Tabla As New DataTable
            Result = com.ExecuteReader()
            Tabla.Load(Result)
            MyBase.Conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
            MyBase.Conn.Close()
        End Try

    End Function

    Public Function ListarParteEntradaSinUbicar(fechadesde As String, fechahasta As String, idalmacen As Integer, idsite As Integer) As DataTable

        Try
            Dim com As New SqlCommand("SP_CSE_ListarParteEntradaSinUbicar", MyBase.Conn)
            MyBase.Conn.Open()
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@fechadesde", SqlDbType.Char, 10).Value = fechadesde
            com.Parameters.Add("@fechahasta", SqlDbType.Char, 10).Value = fechahasta
            com.Parameters.Add("@idalmacen", SqlDbType.Int).Value = idalmacen
            com.Parameters.Add("@idsite", SqlDbType.Int).Value = idsite
            Dim Result As SqlDataReader
            Dim Tabla As New DataTable
            Result = com.ExecuteReader()
            Tabla.Load(Result)
            MyBase.Conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
            MyBase.Conn.Close()
        End Try

    End Function

    Public Function ListarImportarRotulos(fechadesde As String, fechahasta As String) As DataTable

        Try
            Dim com As New SqlCommand("SPDSN_LISTAR_GUIASROTULOS", MyBase.Conn)
            MyBase.Conn.Open()
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@FECINI", SqlDbType.Char, 20).Value = fechadesde
            com.Parameters.Add("@FECFIN", SqlDbType.Char, 20).Value = fechahasta
            Dim Result As SqlDataReader
            Dim Tabla As New DataTable
            Result = com.ExecuteReader()
            Tabla.Load(Result)
            MyBase.Conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
            MyBase.Conn.Close()
        End Try

    End Function

    Public Function ObtenerDataNonConfirmintyRatio(fechadesde As String, fechahasta As String) As DataTable

        Try
            Dim com As New SqlCommand("SPDSN_NON_CONFORMITY_RATIO", MyBase.Conn)
            MyBase.Conn.Open()
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@FECINI", SqlDbType.Char, 20).Value = fechadesde
            com.Parameters.Add("@FECFIN", SqlDbType.Char, 20).Value = fechahasta
            Dim Result As SqlDataReader
            Dim Tabla As New DataTable
            Result = com.ExecuteReader()
            Tabla.Load(Result)
            MyBase.Conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
            MyBase.Conn.Close()
        End Try

    End Function

    Public Function ListarPedidosCAB() As DataTable

        Try
            Dim com As New SqlCommand("SP_CSE_ListarPedidosCAB", MyBase.Conn)
            MyBase.Conn.Open()
            com.CommandType = CommandType.StoredProcedure
            Dim Result As SqlDataReader
            Dim Tabla As New DataTable
            Result = com.ExecuteReader()
            Tabla.Load(Result)
            MyBase.Conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
            MyBase.Conn.Close()
        End Try

    End Function

    Public Function ListarCaneles() As DataTable

        Try
            Dim com As New SqlCommand("SP_CSE_LISTARCANALES", MyBase.Conn)
            MyBase.Conn.Open()
            com.CommandType = CommandType.StoredProcedure
            Dim Result As SqlDataReader
            Dim Tabla As New DataTable
            Result = com.ExecuteReader()
            Tabla.Load(Result)
            MyBase.Conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
            MyBase.Conn.Close()
        End Try

    End Function


    Public Function ListarPedidosDespacho(fechadesde As String, fechahasta As String, idalmacen As Integer, idsite As Integer) As DataTable

        Try
            Dim com As New SqlCommand("SP_CSE_ListarPedidosDespachoV2", MyBase.Conn)
            MyBase.Conn.Open()
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@fechadesde", SqlDbType.Char, 10).Value = fechadesde
            com.Parameters.Add("@fechahasta", SqlDbType.Char, 10).Value = fechahasta
            com.Parameters.Add("@idalmacen", SqlDbType.Int).Value = idalmacen
            com.Parameters.Add("@idsite", SqlDbType.Int).Value = idsite
            Dim Result As SqlDataReader
            Dim Tabla As New DataTable
            Result = com.ExecuteReader()
            Tabla.Load(Result)
            MyBase.Conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
            MyBase.Conn.Close()
        End Try

    End Function


    Public Function SP_CSE_OBTENER_PRD_X_DESCRIPCION(descripcion As String) As DataTable

        Try
            Dim com As New SqlCommand("SP_CSE_OBTENER_PRD_X_DESCRIPCION", MyBase.Conn)
            MyBase.Conn.Open()
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@descrip", SqlDbType.VarChar, 60).Value = descripcion

            Dim Result As SqlDataReader
            Dim Tabla As New DataTable
            Result = com.ExecuteReader()
            Tabla.Load(Result)
            MyBase.Conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
            MyBase.Conn.Close()
        End Try

    End Function



    Public Function ObtenerDatosCliente(ruc As String) As DataTable
        Try
            Dim com As New SqlCommand("SP_CSE_OBTENER_DATOS_CLIENTE", MyBase.Conn)
            MyBase.Conn.Open()
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@RUC", SqlDbType.Char, 18).Value = ruc
            Dim Result As SqlDataReader
            Dim Tabla As New DataTable
            Result = com.ExecuteReader()
            Tabla.Load(Result)
            MyBase.Conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
            MyBase.Conn.Close()
        End Try

    End Function

    Public Function ObtenerDireccionesCliente(ruc As String) As DataTable

        Try
            Dim com As New SqlCommand("SP_CSE_OBTENER_DIRECCIONES_CLIENTE", MyBase.Conn)
            MyBase.Conn.Open()
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@RUC", SqlDbType.Char, 18).Value = ruc

            Dim Result As SqlDataReader
            Dim Tabla As New DataTable
            Result = com.ExecuteReader()
            Tabla.Load(Result)
            MyBase.Conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
            MyBase.Conn.Close()
        End Try

    End Function

    Public Function SP_CSE_ObtenerFactorCodigo(CodArticulo As String) As DataTable

        Try
            Dim com As New SqlCommand("SP_CSE_ObtenerFactorCodigo", MyBase.Conn)
            MyBase.Conn.Open()
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@codarticulo", SqlDbType.Char, 25).Value = CodArticulo
            Dim Result As SqlDataReader
            Dim Tabla As New DataTable
            Result = com.ExecuteReader()
            Tabla.Load(Result)
            MyBase.Conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
            MyBase.Conn.Close()
        End Try

    End Function

    Public Function ListarPedidosDespachoReprogramar(idsite As Integer, idalmacen As Integer) As DataTable
        Try
            Dim com As New SqlCommand("SP_CSE_ObtenerGuiasReprogramarV2", MyBase.Conn)
            MyBase.Conn.Open()
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@idsite", SqlDbType.Int).Value = idsite
            com.Parameters.Add("@idalmacen", SqlDbType.Int).Value = idalmacen
            Dim Result As SqlDataReader
            Dim Tabla As New DataTable
            Result = com.ExecuteReader()
            Tabla.Load(Result)
            MyBase.Conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
            MyBase.Conn.Close()
        End Try

    End Function

    Public Function SP_VALIDAR_DOCUMENTO(C5_CNUMDOC As String) As DataTable
        Try
            Dim com As New SqlCommand("SP_VALIDAR_DOCUMENTO", MyBase.Conn)
            MyBase.Conn.Open()
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@CNUMDOC", SqlDbType.Char, 11).Value = C5_CNUMDOC

            Dim Result As SqlDataReader
            Dim Tabla As New DataTable
            Result = com.ExecuteReader()
            Tabla.Load(Result)
            MyBase.Conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
            MyBase.Conn.Close()
        End Try

    End Function

    Public Function SP_CSE_LISTARTIPOENVIORUTA() As DataTable
        Try
            Dim com As New SqlCommand("SP_CSE_LISTARTIPOENVIORUTA", MyBase.Conn)
            MyBase.Conn.Open()

            Dim Result As SqlDataReader
            Dim Tabla As New DataTable
            Result = com.ExecuteReader()
            Tabla.Load(Result)
            MyBase.Conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
            MyBase.Conn.Close()
        End Try

    End Function

    Public Function ObtenerIndicarDIspatchOnTime(fechadesde As String, fechahasta As String) As DataTable
        Try
            Dim com As New SqlCommand("SPDSN_DISPATCH_ONTIME", MyBase.Conn)
            MyBase.Conn.Open()
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@FECINI", SqlDbType.Char, 20).Value = fechadesde
            com.Parameters.Add("@FECFIN", SqlDbType.Char, 20).Value = fechahasta
            Dim Result As SqlDataReader
            Dim Tabla As New DataTable
            Result = com.ExecuteReader()
            Tabla.Load(Result)
            MyBase.Conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
            MyBase.Conn.Close()
        End Try

    End Function


    Public Function ObtenerDataRuta(idruta As Integer) As DataTable

        Try
            Dim com As New SqlCommand("SP_CSE_OBTENER_DATA_RUTA", MyBase.Conn)
            MyBase.Conn.Open()
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@idruta", SqlDbType.Int).Value = idruta

            Dim Result As SqlDataReader
            Dim Tabla As New DataTable
            Result = com.ExecuteReader()
            Tabla.Load(Result)
            MyBase.Conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
            MyBase.Conn.Close()
        End Try

    End Function



    Public Function ObtenerIndicarDeliveryhOnTime(fechadesde As String, fechahasta As String) As DataTable

        Try
            Dim com As New SqlCommand("SPDSN_DELIVERY_ON_TIME", MyBase.Conn)
            MyBase.Conn.Open()
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@FECINI", SqlDbType.Char, 20).Value = fechadesde
            com.Parameters.Add("@FECFIN", SqlDbType.Char, 20).Value = fechahasta
            Dim Result As SqlDataReader
            Dim Tabla As New DataTable
            Result = com.ExecuteReader()
            Tabla.Load(Result)
            MyBase.Conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
            MyBase.Conn.Close()
        End Try

    End Function

    Public Function ObtenerIndicarLiquidacionDocumentaria(fechadesde As String, fechahasta As String) As DataTable

        Try
            Dim com As New SqlCommand("SP_CSE_INDICADOR_LIQUIDACION", MyBase.Conn)
            MyBase.Conn.Open()
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@FECINI", SqlDbType.Char, 20).Value = fechadesde
            com.Parameters.Add("@FECFIN", SqlDbType.Char, 20).Value = fechahasta
            Dim Result As SqlDataReader
            Dim Tabla As New DataTable
            Result = com.ExecuteReader()
            Tabla.Load(Result)
            MyBase.Conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
            MyBase.Conn.Close()
        End Try

    End Function

    Public Function ListarPedidosPicking(fechadesde As String, fechahasta As String) As DataTable

        Try
            Dim com As New SqlCommand("SPDSN_LISTARPEDIDOS_PROGRAPICKING", MyBase.Conn)
            MyBase.Conn.Open()
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@FECINI", SqlDbType.Char, 12).Value = fechadesde
            com.Parameters.Add("@FECFIN", SqlDbType.Char, 12).Value = fechahasta
            Dim Result As SqlDataReader
            Dim Tabla As New DataTable
            Result = com.ExecuteReader()
            Tabla.Load(Result)
            MyBase.Conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
            MyBase.Conn.Close()
        End Try

    End Function

    Public Function ListarGuiasCAB(fechadesde As String, fechahasta As String, idalmacen As Integer, idsite As Integer) As DataTable

        Try
            Dim com As New SqlCommand("CSE_SP_ListarGuiasCab", MyBase.Conn)
            MyBase.Conn.Open()
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@fechadesde", SqlDbType.Char, 10).Value = fechadesde
            com.Parameters.Add("@fechahasta", SqlDbType.Char, 10).Value = fechahasta
            com.Parameters.Add("@idalmacen", SqlDbType.Int).Value = idalmacen
            com.Parameters.Add("@idsite", SqlDbType.Int).Value = idsite
            Dim Result As SqlDataReader
            Dim Tabla As New DataTable
            Result = com.ExecuteReader()
            Tabla.Load(Result)
            MyBase.Conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
            MyBase.Conn.Close()
        End Try

    End Function


    Public Function ObtenerArticulosAbastercer(fechadesde As String, fechahasta As String) As DataTable

        Try
            Dim com As New SqlCommand("SP_OBTENER_ARTICULOS_ABASTECER", MyBase.Conn)
            MyBase.Conn.Open()
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@FECINI", SqlDbType.Char, 10).Value = fechadesde
            com.Parameters.Add("@FECFIN", SqlDbType.Char, 10).Value = fechahasta
            Dim Result As SqlDataReader
            Dim Tabla As New DataTable
            Result = com.ExecuteReader()
            Tabla.Load(Result)
            MyBase.Conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
            MyBase.Conn.Close()
        End Try

    End Function


    Public Function SP_LISTAR_REPORTE_AVANCE_LINEA() As DataTable

        Try
            Dim com As New SqlCommand("SP_LISTAR_REPORTE_AVANCE_LINEA", MyBase.Conn)
            MyBase.Conn.Open()
            com.CommandType = CommandType.StoredProcedure

            Dim Result As SqlDataReader
            Dim Tabla As New DataTable
            Result = com.ExecuteReader()
            Tabla.Load(Result)
            MyBase.Conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
            MyBase.Conn.Close()
        End Try

    End Function

    Public Function SP_CSE_OBTENER_DATA_ACTUAL() As DataTable

        Try
            Dim com As New SqlCommand("SP_CSE_OBTENER_DATA_ACTUAL", MyBase.Conn)
            MyBase.Conn.Open()
            com.CommandType = CommandType.StoredProcedure

            Dim Result As SqlDataReader
            Dim Tabla As New DataTable
            Result = com.ExecuteReader()
            Tabla.Load(Result)
            MyBase.Conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
            MyBase.Conn.Close()
        End Try

    End Function

    Public Function SP_CSE_OBTENER_DATA_ACTUAL_DETALLE() As DataTable

        Try
            Dim com As New SqlCommand("SP_CSE_OBTENER_DATA_ACTUAL_DETALLE", MyBase.Conn)
            MyBase.Conn.Open()
            com.CommandType = CommandType.StoredProcedure

            Dim Result As SqlDataReader
            Dim Tabla As New DataTable
            Result = com.ExecuteReader()
            Tabla.Load(Result)
            MyBase.Conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
            MyBase.Conn.Close()
        End Try

    End Function


    Public Function sp_obtener_promedio_fijo(codarticulo As String) As DataTable

        Try
            Dim com As New SqlCommand("sp_obtener_promedio_fijo", MyBase.Conn)
            MyBase.Conn.Open()
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@codarticulo", SqlDbType.Char, 25).Value = codarticulo
            Dim Result As SqlDataReader
            Dim Tabla As New DataTable
            Result = com.ExecuteReader()
            Tabla.Load(Result)
            MyBase.Conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
            MyBase.Conn.Close()
        End Try

    End Function


    Public Function ListarParteSalidaCab(fechadesde As String, fechahasta As String, idalmacen As Integer, idsite As Integer) As DataTable

        Try
            Dim com As New SqlCommand("CSE_SP_ListarPartesSalidaCab", MyBase.Conn)
            MyBase.Conn.Open()
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@fechadesde", SqlDbType.Char, 10).Value = fechadesde
            com.Parameters.Add("@fechahasta", SqlDbType.Char, 10).Value = fechahasta
            com.Parameters.Add("@idalmacen", SqlDbType.Int).Value = idalmacen
            com.Parameters.Add("@idsite", SqlDbType.Int).Value = idsite
            Dim Result As SqlDataReader
            Dim Tabla As New DataTable
            Result = com.ExecuteReader()
            Tabla.Load(Result)
            MyBase.Conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
            MyBase.Conn.Close()
        End Try

    End Function

    Public Function ListarGuiasAnularPicking(fechadesde As String, fechahasta As String, idsite As Integer, idalmacen As Integer) As DataTable

        Try
            Dim com As New SqlCommand("CSE_SP_ListarGuiasAnularPickinV2", MyBase.Conn)
            MyBase.Conn.Open()
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@fechadesde", SqlDbType.Char, 10).Value = fechadesde
            com.Parameters.Add("@fechahasta", SqlDbType.Char, 10).Value = fechahasta
            com.Parameters.Add("@idsite", SqlDbType.Int).Value = idsite
            com.Parameters.Add("@idalmacen", SqlDbType.Int).Value = idalmacen
            Dim Result As SqlDataReader
            Dim Tabla As New DataTable
            Result = com.ExecuteReader()
            Tabla.Load(Result)
            MyBase.Conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
            MyBase.Conn.Close()
        End Try

    End Function

    Public Function ListarGuiasDET(codAlmacen As String, tipdoc As String, nrodoc As String, idalmacen As Integer, idsite As Integer) As DataTable
        Try
            Dim com As New SqlCommand("SP_CSE_ListarGuiaDetalle", MyBase.Conn)
            MyBase.Conn.Open()
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@C6_CALMA", SqlDbType.Char, 4).Value = codAlmacen
            com.Parameters.Add("@C6_CTD", SqlDbType.Char, 2).Value = tipdoc
            com.Parameters.Add("@C6_CNUMDOC", SqlDbType.Char, 11).Value = nrodoc
            com.Parameters.Add("@idalmacen", SqlDbType.Int).Value = idalmacen
            com.Parameters.Add("@idsite", SqlDbType.Int).Value = idsite
            Dim Result As SqlDataReader
            Dim Tabla As New DataTable
            Result = com.ExecuteReader()
            Tabla.Load(Result)
            MyBase.Conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
            MyBase.Conn.Close()
        End Try
    End Function

    Public Function ObtenerGuiaProgramacion(codAlmacen As String, ctd As String, nrodoc As String) As DataTable
        Try
            Dim com As New SqlCommand("SP_CSE_ListarPedidosDespacho_v", MyBase.Conn)
            MyBase.Conn.Open()
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@C5_CALMA", SqlDbType.Char, 4).Value = codAlmacen
            com.Parameters.Add("@C5_CTD", SqlDbType.Char, 2).Value = ctd
            com.Parameters.Add("@C5_CNUMDOC", SqlDbType.Char, 11).Value = nrodoc
            Dim Result As SqlDataReader
            Dim Tabla As New DataTable
            Result = com.ExecuteReader()
            Tabla.Load(Result)
            MyBase.Conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
            MyBase.Conn.Close()
        End Try
    End Function

    Public Function ObtenerDataBonificacion(CCODAGE As String, CNUMPED As String) As DataTable
        Try
            Dim com As New SqlCommand("SP_CSE_OBTENER_BONIFICACION", MyBase.Conn)
            MyBase.Conn.Open()
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@F5_CCODAGE", SqlDbType.Char, 20).Value = CCODAGE
            com.Parameters.Add("@F5_CNUMPED", SqlDbType.Char, 20).Value = CNUMPED
            Dim Result As SqlDataReader
            Dim Tabla As New DataTable
            Result = com.ExecuteReader()
            Tabla.Load(Result)
            MyBase.Conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
            MyBase.Conn.Close()
        End Try
    End Function

    Public Function ObtenerArticulosSinCubicaje() As DataTable
        Try
            Dim com As New SqlCommand("SP_CSE_ARTICULOS_SIN_CUBICAE", MyBase.Conn)
            MyBase.Conn.Open()
            com.CommandType = CommandType.StoredProcedure
            Dim Result As SqlDataReader
            Dim Tabla As New DataTable
            Result = com.ExecuteReader()
            Tabla.Load(Result)
            MyBase.Conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
            MyBase.Conn.Close()
        End Try
    End Function

    Public Function ObtenerDetallePickin(codAlmacen As String, ctd As String, nrodoc As String) As DataTable
        Try
            Dim com As New SqlCommand("SP_CSE_OBTENER_DETALLE_PICKING", MyBase.Conn)
            MyBase.Conn.Open()
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@dopa_C5_CALMA", SqlDbType.Char, 4).Value = codAlmacen
            com.Parameters.Add("@dopa_C5_CTD", SqlDbType.Char, 2).Value = ctd
            com.Parameters.Add("@dopa_C5_CNUMDOC", SqlDbType.Char, 11).Value = nrodoc
            Dim Result As SqlDataReader
            Dim Tabla As New DataTable
            Result = com.ExecuteReader()
            Tabla.Load(Result)
            MyBase.Conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
            MyBase.Conn.Close()
        End Try
    End Function

    Public Function ListarParteEntradaDET(codAlmacen As String, codcabecera As String, tipdoc As String, idalmacen As Integer, idsite As Integer) As DataTable

        Try
            Dim com As New SqlCommand("SP_CSE_ListarParteEntradaDetalle", MyBase.Conn)
            MyBase.Conn.Open()
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@C6_CALMA", SqlDbType.Char, 4).Value = codAlmacen
            com.Parameters.Add("@C6_CTD", SqlDbType.Char, 2).Value = tipdoc
            com.Parameters.Add("@C6_CNUMDOC", SqlDbType.Char, 11).Value = codcabecera
            com.Parameters.Add("@idalmacen", SqlDbType.Int).Value = idalmacen
            com.Parameters.Add("@idsite", SqlDbType.Int).Value = idsite
            Dim Result As SqlDataReader
            Dim Tabla As New DataTable
            Result = com.ExecuteReader()
            Tabla.Load(Result)
            MyBase.Conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
            MyBase.Conn.Close()
        End Try
    End Function

    Public Function ListarPedidosDET(F6_CCODAGE As String, F6_CNUMPED As String) As DataTable

        Try
            Dim com As New SqlCommand("SP_CSE_ListarPedidoDetalle", MyBase.Conn)
            MyBase.Conn.Open()
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@F6_CCODAGE", SqlDbType.Char, 4).Value = F6_CCODAGE
            com.Parameters.Add("@F6_CNUMPED", SqlDbType.Char, 11).Value = F6_CNUMPED
            Dim Result As SqlDataReader
            Dim Tabla As New DataTable
            Result = com.ExecuteReader()
            Tabla.Load(Result)
            MyBase.Conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
            MyBase.Conn.Close()
        End Try
    End Function

    Public Function ListarMotivosDispatch() As DataTable

        Try
            Dim com As New SqlCommand("SP_CSE_ListarMotivosDispatch", MyBase.Conn)
            MyBase.Conn.Open()
            com.CommandType = CommandType.StoredProcedure
            Dim Result As SqlDataReader
            Dim Tabla As New DataTable
            Result = com.ExecuteReader()
            Tabla.Load(Result)
            MyBase.Conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
            MyBase.Conn.Close()
        End Try

    End Function

    Public Function ListarPicadores(idsite As Integer) As DataTable

        Try
            Dim com As New SqlCommand("SP_CSE_LISTARPICADORESV2", MyBase.Conn)
            MyBase.Conn.Open()
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@idsite", SqlDbType.Int).Value = idsite
            Dim Result As SqlDataReader
            Dim Tabla As New DataTable
            Result = com.ExecuteReader()
            Tabla.Load(Result)
            MyBase.Conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
            MyBase.Conn.Close()
        End Try

    End Function

    Public Function ListarMotivosDelivery() As DataTable

        Try
            Dim com As New SqlCommand("SP_CSE_ListarMotivosDelivery", MyBase.Conn)
            MyBase.Conn.Open()
            com.CommandType = CommandType.StoredProcedure
            Dim Result As SqlDataReader
            Dim Tabla As New DataTable
            Result = com.ExecuteReader()
            Tabla.Load(Result)
            MyBase.Conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
            MyBase.Conn.Close()
        End Try

    End Function

    Public Function ListarMotivosLiquidacion() As DataTable

        Try
            Dim com As New SqlCommand("SP_CSE_ListarMotivosLiquidacion", MyBase.Conn)
            MyBase.Conn.Open()
            com.CommandType = CommandType.StoredProcedure
            Dim Result As SqlDataReader
            Dim Tabla As New DataTable
            Result = com.ExecuteReader()
            Tabla.Load(Result)
            MyBase.Conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
            MyBase.Conn.Close()
        End Try

    End Function

    Public Function ListarPosicionesDetalle(codAlmacen As String, codcabecera As String, tipdoc As String, codarticulo As String, codlote As String) As DataTable

        Try
            Dim com As New SqlCommand("SP_CSE_ListarPosicionesDetalle", MyBase.Conn)
            MyBase.Conn.Open()
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@C5_CALMA", SqlDbType.Char, 4).Value = codAlmacen
            com.Parameters.Add("@C5_CNUMDOC", SqlDbType.Char, 11).Value = codcabecera
            com.Parameters.Add("@C5_CTD", SqlDbType.Char, 2).Value = tipdoc
            com.Parameters.Add("@codarticulo", SqlDbType.Char, 25).Value = codarticulo
            com.Parameters.Add("@lote", SqlDbType.Char, 18).Value = codlote
            Dim Result As SqlDataReader
            Dim Tabla As New DataTable
            Result = com.ExecuteReader()
            Tabla.Load(Result)
            MyBase.Conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
            MyBase.Conn.Close()
        End Try

    End Function

    Public Function RegistrarObservacionDispatch(CALMA As String, CTD As String, CNUMDOC As String, idmotivo As Integer) As Integer
        Dim rp As Integer = 0
        'Dim RpStore As SqlDataReader = Nothing
        Dim Comm As New SqlCommand("SP_CSE_RegistrarObservacionDispatch", MyBase.Conn)
        Try
            Comm.CommandType = CommandType.StoredProcedure
            With Comm.Parameters
                .Add("@CALMA", SqlDbType.Char, 4).Value = CALMA
                .Add("@CTD", SqlDbType.Char, 2).Value = CTD
                .Add("@CNUMDOC", SqlDbType.Char, 11).Value = CNUMDOC
                .Add("@idMotivo", SqlDbType.Int).Value = idmotivo
            End With
            MyBase.Conn.Open()
            ''RpStore = Comm.ExecuteReader(CommandBehavior.SingleRow)
            ''If (RpStore.Read()) Then
            ''    rp = Convert.ToInt32(RpStore.GetValue(0).ToString())
            ''End If
            rp = Comm.ExecuteNonQuery

            MyBase.Conn.Close()
        Catch ex As Exception
            MyBase.Conn.Close()
        End Try
        Return rp
    End Function


    Public Function RegistrarFacturaTransportista(CNUMDOC As String, factura As String) As Integer
        Dim rp As Integer = 0
        'Dim RpStore As SqlDataReader = Nothing
        Dim Comm As New SqlCommand("SP_REGISTRAR_FACTURA_GUIA_RUTA", MyBase.Conn)
        Try
            Comm.CommandType = CommandType.StoredProcedure
            With Comm.Parameters

                .Add("@C5_CNUMDOC", SqlDbType.Char, 15).Value = CNUMDOC
                .Add("@factura", SqlDbType.Char, 50).Value = factura
            End With
            MyBase.Conn.Open()
            ''RpStore = Comm.ExecuteReader(CommandBehavior.SingleRow)
            ''If (RpStore.Read()) Then
            ''    rp = Convert.ToInt32(RpStore.GetValue(0).ToString())
            ''End If
            rp = Comm.ExecuteNonQuery

            MyBase.Conn.Close()
        Catch ex As Exception
            MyBase.Conn.Close()
        End Try
        Return rp
    End Function

    Public Function RegistrarAlerta() As Integer
        Dim rp As Integer = 0
        'Dim RpStore As SqlDataReader = Nothing
        Dim Comm As New SqlCommand("SP_CSE_RegistrarAlerta", MyBase.Conn)
        Try
            Comm.CommandType = CommandType.StoredProcedure

            MyBase.Conn.Open()
            ''RpStore = Comm.ExecuteReader(CommandBehavior.SingleRow)
            ''If (RpStore.Read()) Then
            ''    rp = Convert.ToInt32(RpStore.GetValue(0).ToString())
            ''End If
            rp = Comm.ExecuteNonQuery

            MyBase.Conn.Close()
        Catch ex As Exception
            MyBase.Conn.Close()
        End Try
        Return rp
    End Function

    Public Function SP_CSE_ACTUALIZAR_CUBICAJE_ART(codarticulo As String, alto As Decimal, ancho As Decimal, largo As Decimal, factorcji As Decimal, factorcjm As Decimal) As Integer
        Dim rp As Integer = 0
        Dim RpStore As SqlDataReader = Nothing
        Dim Comm As New SqlCommand("SP_CSE_ACTUALIZAR_CUBICAJE_ART", MyBase.Conn)
        Try
            Comm.CommandType = CommandType.StoredProcedure
            With Comm.Parameters
                .Add("@codarticulo", SqlDbType.Char, 25).Value = codarticulo
                .Add("@alto", SqlDbType.Decimal, 16, 3).Value = alto
                .Add("@ancho", SqlDbType.Decimal, 16, 3).Value = ancho
                .Add("@largo", SqlDbType.Decimal, 16, 3).Value = largo
                .Add("@factorcji", SqlDbType.Decimal, 16, 3).Value = factorcji
                .Add("@factorcjm", SqlDbType.Decimal, 16, 3).Value = factorcjm
            End With
            MyBase.Conn.Open()
            RpStore = Comm.ExecuteReader(CommandBehavior.SingleRow)
            If (RpStore.Read()) Then
                rp = Convert.ToInt32(RpStore.GetValue(0).ToString())
            End If
            'rp = Comm.ExecuteNonQuery

            MyBase.Conn.Close()
        Catch ex As Exception
            MyBase.Conn.Close()
        End Try
        Return rp
    End Function

    Public Function SP_CSE_RegistrarValidacionArticulo(codarticulo As String, userid As Integer) As Integer
        Dim rp As Integer = 0
        Dim RpStore As SqlDataReader = Nothing
        Dim Comm As New SqlCommand("SP_CSE_RegistrarValidacionArticulo", MyBase.Conn)
        Try
            Comm.CommandType = CommandType.StoredProcedure
            With Comm.Parameters
                .Add("@codarticulo", SqlDbType.Char, 25).Value = codarticulo
                .Add("@user_id", SqlDbType.Int).Value = userid

            End With
            MyBase.Conn.Open()
            RpStore = Comm.ExecuteReader(CommandBehavior.SingleRow)
            If (RpStore.Read()) Then
                rp = Convert.ToInt32(RpStore.GetValue(0).ToString())
            End If
            'rp = Comm.ExecuteNonQuery

            MyBase.Conn.Close()
        Catch ex As Exception
            MyBase.Conn.Close()
        End Try
        Return rp
    End Function


    '@representante varchar (100),
    '@idcosto int,
    '@fecharecepcion char (10),
    '@horarecepcion char (8),
    '@idsite int

    Public Function Agregar_Guia_Ruta(crg_id As Integer, calma As String, ctd As String, cnumdoc As String, userid As Integer, peso As Decimal, bultos As Integer, tiempo As Decimal, volumen As Decimal, restriccion As String, tiporuta As String, cliente As String, Direccion As String, importe As Decimal, condicion As String, REPRESENTATE As String, idcosto As Integer, fecharecepcion As String, horarecepcion As String, idsite As Integer, departamento As String, provincia As String, distrito As String, fisico As String, idsiteliq As Integer, idsitepicking As Integer, canal As String) As Integer
        Dim rp As Integer = 0
        'Dim RpStore As SqlDataReader = Nothing
        Dim Comm As New SqlCommand("SP_CSE_AGREGAR_DETALLE_RUTA", MyBase.Conn)
        Try
            Comm.CommandType = CommandType.StoredProcedure
            With Comm.Parameters
                .Add("@crg_id", SqlDbType.Int).Value = crg_id
                .Add("@calma", SqlDbType.Char, 4).Value = calma
                .Add("@ctd", SqlDbType.Char, 2).Value = ctd
                .Add("@cnumdoc", SqlDbType.Char, 11).Value = cnumdoc
                .Add("@userid", SqlDbType.Int).Value = userid
                .Add("@peso", SqlDbType.Decimal, 13, 2).Value = peso
                .Add("@bultos", SqlDbType.Int).Value = bultos
                .Add("@tiempo", SqlDbType.Decimal, 16, 2).Value = tiempo
                .Add("@volumen", SqlDbType.Decimal, 16, 3).Value = volumen
                .Add("@restriccion", SqlDbType.VarChar, 100).Value = restriccion
                .Add("@tiporuta", SqlDbType.Char, 20).Value = tiporuta
                .Add("@cliente", SqlDbType.VarChar, 150).Value = cliente
                .Add("@direccion", SqlDbType.VarChar, 300).Value = Direccion
                .Add("@importe", SqlDbType.Decimal, 16, 2).Value = importe
                .Add("@condicon", SqlDbType.VarChar, 100).Value = condicion
                .Add("@representante", SqlDbType.VarChar, 100).Value = REPRESENTATE
                .Add("@idcosto", SqlDbType.Int).Value = idcosto
                .Add("@fecharecepcion", SqlDbType.Char, 10).Value = fecharecepcion
                .Add("@horarecepcion", SqlDbType.Char, 8).Value = horarecepcion
                .Add("@idsite", SqlDbType.Int).Value = idsite
                .Add("@departamento", SqlDbType.Char, 50).Value = departamento
                .Add("@provincia", SqlDbType.Char, 50).Value = provincia
                .Add("@distrito", SqlDbType.Char, 50).Value = distrito
                .Add("@fisico", SqlDbType.Char, 2).Value = fisico
                .Add("@idsiteliq", SqlDbType.Int).Value = idsiteliq
                .Add("@idsitepicking", SqlDbType.Int).Value = idsitepicking
                .Add("@canal", SqlDbType.Char, 50).Value = canal
            End With
            MyBase.Conn.Open()
            ''RpStore = Comm.ExecuteReader(CommandBehavior.SingleRow)
            ''If (RpStore.Read()) Then
            ''    rp = Convert.ToInt32(RpStore.GetValue(0).ToString())
            ''End If
            rp = Comm.ExecuteNonQuery

            MyBase.Conn.Close()
        Catch ex As Exception
            MyBase.Conn.Close()
        End Try
        Return rp
    End Function

    Public Function ReveritrDetallePickin(iddetalle As Integer, userid As Integer) As Integer
        Dim rp As Integer = 0
        'Dim RpStore As SqlDataReader = Nothing
        Dim Comm As New SqlCommand("SP_CSE_REVERTIRPICKINGXDETALLE", MyBase.Conn)
        Try
            Comm.CommandType = CommandType.StoredProcedure
            With Comm.Parameters
                .Add("@idddetalle", SqlDbType.Int).Value = iddetalle
                .Add("@user_id", SqlDbType.Int).Value = userid
            End With
            MyBase.Conn.Open()
            ''RpStore = Comm.ExecuteReader(CommandBehavior.SingleRow)
            ''If (RpStore.Read()) Then
            ''    rp = Convert.ToInt32(RpStore.GetValue(0).ToString())
            ''End If
            rp = Comm.ExecuteNonQuery

            MyBase.Conn.Close()
        Catch ex As Exception
            MyBase.Conn.Close()
        End Try
        Return rp
    End Function

    Public Function RegistroArticuloUnitario(CALMA As String, userid As Integer, idsite As Integer, idalmacen As Integer, idrack As Integer, codarticulo As String, serie As String, idposicion As Integer, cantidad As Integer, vencimiento As String) As Integer
        Dim rp As Integer = 0
        'Dim RpStore As SqlDataReader = Nothing
        Dim Comm As New SqlCommand("SP_INGRESO_ARTICULO_UNITARIO", MyBase.Conn)
        Try
            Comm.CommandType = CommandType.StoredProcedure
            With Comm.Parameters
                .Add("@CALMA", SqlDbType.Char, 4).Value = CALMA
                .Add("@userid", SqlDbType.Int).Value = userid
                .Add("@idsite", SqlDbType.Int).Value = idsite
                .Add("@idalmacen", SqlDbType.Int).Value = idalmacen
                .Add("@idrack", SqlDbType.Int).Value = idrack
                .Add("@codarticulo", SqlDbType.Char, 25).Value = codarticulo
                .Add("@serie", SqlDbType.Char, 18).Value = serie
                .Add("@idposicion", SqlDbType.Int).Value = idposicion
                .Add("@cantidad", SqlDbType.Decimal, 16, 2).Value = cantidad
                .Add("@vencimiento", SqlDbType.Char, 10).Value = vencimiento
            End With
            MyBase.Conn.Open()
            ''RpStore = Comm.ExecuteReader(CommandBehavior.SingleRow)
            ''If (RpStore.Read()) Then
            ''    rp = Convert.ToInt32(RpStore.GetValue(0).ToString())
            ''End If
            rp = Comm.ExecuteNonQuery

            MyBase.Conn.Close()
        Catch ex As Exception
            MyBase.Conn.Close()
        End Try
        Return rp
    End Function

    Public Function RegistrarObservacionDelivery(CALMA As String, CTD As String, CNUMDOC As String, idmotivo As Integer) As Integer
        Dim rp As Integer = 0
        Dim Comm As New SqlCommand("SP_CSE_RegistrarObservacionDelivery", MyBase.Conn)
        Try
            Comm.CommandType = CommandType.StoredProcedure
            With Comm.Parameters
                .Add("@CALMA", SqlDbType.Char, 4).Value = CALMA
                .Add("@CTD", SqlDbType.Char, 2).Value = CTD
                .Add("@CNUMDOC", SqlDbType.Char, 11).Value = CNUMDOC
                .Add("@idMotivo", SqlDbType.Int).Value = idmotivo
            End With
            MyBase.Conn.Open()
            rp = Comm.ExecuteNonQuery

            MyBase.Conn.Close()
        Catch ex As Exception
            MyBase.Conn.Close()
        End Try
        Return rp
    End Function

    Public Function SP_CSE_RegistrarObservacionLiquidacion(CALMA As String, CTD As String, CNUMDOC As String, idmotivo As Integer) As Integer
        Dim rp As Integer = 0
        Dim Comm As New SqlCommand("SP_CSE_RegistrarObservacionLiquidacion", MyBase.Conn)
        Try
            Comm.CommandType = CommandType.StoredProcedure
            With Comm.Parameters
                .Add("@CALMA", SqlDbType.Char, 4).Value = CALMA
                .Add("@CTD", SqlDbType.Char, 2).Value = CTD
                .Add("@CNUMDOC", SqlDbType.Char, 11).Value = CNUMDOC
                .Add("@idMotivo", SqlDbType.Int).Value = idmotivo
            End With
            MyBase.Conn.Open()
            rp = Comm.ExecuteNonQuery

            MyBase.Conn.Close()
        Catch ex As Exception
            MyBase.Conn.Close()
        End Try
        Return rp
    End Function


    Public Function RegistrarRecepcionGuiaDespacho(CALMA As String, CTD As String, CNUMDOC As String, userid As Integer, idcosto As Integer, fisico As String, idsiteliq As Integer, idsitePicking As Integer, Comentario As String) As Integer
        Dim rp As Integer = 0
        Dim Comm As New SqlCommand("SP_CSE_CONFIRMARRECEPCIONGUIAV2", MyBase.Conn)
        Try
            Comm.CommandType = CommandType.StoredProcedure
            With Comm.Parameters
                .Add("@C5_CALMA", SqlDbType.Char, 4).Value = CALMA
                .Add("@C5_CTD", SqlDbType.Char, 2).Value = CTD
                .Add("@C5_CNUMDOC", SqlDbType.Char, 11).Value = CNUMDOC
                .Add("@iduser", SqlDbType.Int).Value = userid
                .Add("@idcosto", SqlDbType.Int).Value = idcosto
                .Add("@fisico", SqlDbType.Char, 2).Value = fisico
                .Add("@idsiteliq", SqlDbType.Int).Value = idsiteliq
                .Add("@idsitepicking", SqlDbType.Int).Value = idsitePicking
                .Add("@ComentarioPicking", SqlDbType.VarChar, 300).Value = Comentario
            End With
            MyBase.Conn.Open()
            rp = Comm.ExecuteNonQuery
            MyBase.Conn.Close()
        Catch ex As Exception
            Throw ex
            MyBase.Conn.Close()
        End Try
        Return rp
    End Function

    Public Function SP_CSE_RegistrarFechaVC_OC(CALMA As String, CTD As String, CNUMDOC As String, userid As Integer, fecha As String) As Integer
        Dim rp As Integer = 0
        Dim Comm As New SqlCommand("SP_CSE_RegistrarFechaVC_OC", MyBase.Conn)
        Try
            Comm.CommandType = CommandType.StoredProcedure
            With Comm.Parameters
                .Add("@C5_CALMA", SqlDbType.Char, 4).Value = CALMA
                .Add("@C5_CTD", SqlDbType.Char, 2).Value = CTD
                .Add("@C5_CNUMDOC", SqlDbType.Char, 11).Value = CNUMDOC
                .Add("@userId", SqlDbType.Int).Value = userid
                .Add("@fecha", SqlDbType.Char, 10).Value = fecha
            End With
            MyBase.Conn.Open()
            rp = Comm.ExecuteNonQuery
            MyBase.Conn.Close()
        Catch ex As Exception
            Throw ex
            MyBase.Conn.Close()
        End Try
        Return rp
    End Function

    Public Function RegistrarComentarioGuiaDespacho(CALMA As String, CTD As String, CNUMDOC As String, comentario As String, user_id As Integer) As Integer
        Dim rp As Integer = 0
        Dim Comm As New SqlCommand("SP_CSE_RegistrarComentarioGuiaDespacho", MyBase.Conn)
        Try
            Comm.CommandType = CommandType.StoredProcedure
            With Comm.Parameters
                .Add("@C5_CALMA", SqlDbType.Char, 4).Value = CALMA
                .Add("@C5_CTD", SqlDbType.Char, 2).Value = CTD
                .Add("@C5_CNUMDOC", SqlDbType.Char, 11).Value = CNUMDOC
                .Add("@Comentario", SqlDbType.VarChar, 200).Value = comentario
                .Add("@userId", SqlDbType.Int).Value = user_id
            End With
            MyBase.Conn.Open()
            rp = Comm.ExecuteNonQuery
            MyBase.Conn.Close()
        Catch ex As Exception
            MyBase.Conn.Close()
        End Try
        Return rp
    End Function


    Public Function RegistrarRack(XML As String) As Integer
        Dim rp As Integer = 0
        Dim RpStore As SqlDataReader = Nothing
        Dim Comm As New SqlCommand("SP_CSE_RegistrarRack", MyBase.Conn)
        Try
            Comm.CommandType = CommandType.StoredProcedure
            With Comm.Parameters
                .Add("@XML", SqlDbType.Xml).Value = XML
            End With
            MyBase.Conn.Open()
            RpStore = Comm.ExecuteReader(CommandBehavior.SingleRow)
            If (RpStore.Read()) Then
                rp = Convert.ToInt32(RpStore.GetValue(0).ToString())
            End If
            MyBase.Conn.Close()
        Catch ex As Exception
            MyBase.Conn.Close()
        End Try
        Return rp
    End Function

    Public Function obtenerStock_ATE_CJM_X_CODIGOARTI(Codarticulo As String) As DataTable
        Try
            Dim com As New SqlCommand("SP_CSE_OBTENERSTOCK_ATE_CJM", MyBase.Conn)
            MyBase.Conn.Open()
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@codarticulo", SqlDbType.Char, 25).Value = Codarticulo

            Dim Result As SqlDataReader
            Dim Tabla As New DataTable
            Result = com.ExecuteReader()
            Tabla.Load(Result)
            MyBase.Conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
            MyBase.Conn.Close()
        End Try
    End Function

    Public Function RegistrarIngresoMasivo(XML As String) As Integer
        Dim rp As Integer = 0
        Dim RpStore As SqlDataReader = Nothing
        Dim Comm As New SqlCommand("SP_CSE_RegistroMasivoIngresos", MyBase.Conn)
        Try
            Comm.CommandType = CommandType.StoredProcedure
            With Comm.Parameters
                .Add("@XML", SqlDbType.Xml).Value = XML
            End With
            MyBase.Conn.Open()
            RpStore = Comm.ExecuteReader(CommandBehavior.SingleRow)
            If (RpStore.Read()) Then
                rp = Convert.ToInt32(RpStore.GetValue(0).ToString())
            End If
            MyBase.Conn.Close()
        Catch ex As Exception
            MyBase.Conn.Close()
        End Try
        Return rp
    End Function

    Public Function ComplementarEspaciosTodos(idrack As Integer, alto As Decimal, largo As Decimal, ancho As Decimal) As Integer
        Dim rp As Integer = 0
        Dim RpStore As SqlDataReader = Nothing
        Dim Comm As New SqlCommand("SP_CSE_ComplementarespacioTodos", MyBase.Conn)
        Try
            Comm.CommandType = CommandType.StoredProcedure
            With Comm.Parameters
                .Add("@idrack", SqlDbType.Int).Value = idrack
                .Add("@alto", SqlDbType.Decimal).Value = alto
                .Add("@largo", SqlDbType.Decimal).Value = largo
                .Add("@ancho", SqlDbType.Decimal).Value = ancho
            End With
            MyBase.Conn.Open()
            rp = Comm.ExecuteNonQuery()
            MyBase.Conn.Close()
        Catch ex As Exception
            MyBase.Conn.Close()
        End Try
        Return rp
    End Function

    Public Function CambiarEstadoGuia(C5_CALMA As String, C5_CTD As String, C5_CNUMDOC As String, ESTADO As String, idpicador As Integer, idfiltro As Integer, userimpresion As Integer, comentario As String) As Integer
        Dim rp As Integer = 0
        Dim RpStore As SqlDataReader = Nothing
        Dim Comm As New SqlCommand("SP_CSE_CAMBIARESTADO_GUIA", MyBase.Conn)
        Try
            Comm.CommandType = CommandType.StoredProcedure
            With Comm.Parameters
                .Add("@C5_CALMA", SqlDbType.Char, 4).Value = C5_CALMA
                .Add("@C5_CTD", SqlDbType.Char, 2).Value = C5_CTD
                .Add("@C5_CNUMDOC", SqlDbType.Char, 11).Value = C5_CNUMDOC
                .Add("@ESTADO", SqlDbType.Char, 2).Value = ESTADO
                .Add("@idpicador", SqlDbType.Int).Value = idpicador
                .Add("@idfiltro", SqlDbType.Int).Value = idfiltro
                .Add("@idimpresor", SqlDbType.Int).Value = userimpresion
                .Add("@comentario", SqlDbType.Char, 150).Value = comentario
            End With
            MyBase.Conn.Open()
            rp = Comm.ExecuteNonQuery()
            MyBase.Conn.Close()
        Catch ex As Exception
            MyBase.Conn.Close()
        End Try
        Return rp
    End Function

    Public Function TrasladoUbicaciones(idrack As Integer, idubicacion As Integer, iddetalle As Integer, cantidad As Decimal, userid As Integer) As Integer
        Dim rp As Integer = 0
        Dim RpStore As SqlDataReader = Nothing
        Dim Comm As New SqlCommand("SP_CSE_TRASFERENCIA_UBICACION", MyBase.Conn)
        Try
            Comm.CommandType = CommandType.StoredProcedure
            With Comm.Parameters
                .Add("@iddetalle", SqlDbType.Int).Value = iddetalle
                .Add("@idrack", SqlDbType.Int).Value = idrack
                .Add("@idubicacion", SqlDbType.Int).Value = idubicacion
                .Add("@Cantidad", SqlDbType.Decimal, 16, 2).Value = cantidad
                .Add("@userid", SqlDbType.Int).Value = userid
            End With
            MyBase.Conn.Open()
            rp = Comm.ExecuteNonQuery()
            MyBase.Conn.Close()
        Catch ex As Exception
            MyBase.Conn.Close()
        End Try
        Return rp
    End Function

    Public Function SP_CSE_ConversioCodigo(iddetalle As Integer, CodigoNuevo As String, userid As Integer, cantidadIngreso As Decimal, cantidadSalida As Decimal) As Integer
        Dim rp As Integer = 0
        Dim RpStore As SqlDataReader = Nothing
        Dim Comm As New SqlCommand("SP_CSE_ConversioCodigo", MyBase.Conn)
        Try
            Comm.CommandType = CommandType.StoredProcedure
            With Comm.Parameters
                .Add("@iddetalle", SqlDbType.Int).Value = iddetalle
                .Add("@CodigoNuevo", SqlDbType.Char, 25).Value = CodigoNuevo
                .Add("@cantidadIngreso", SqlDbType.Decimal, 16, 2).Value = cantidadIngreso
                .Add("@cantidadSalida", SqlDbType.Decimal, 16, 2).Value = cantidadSalida
                .Add("@userid", SqlDbType.Int).Value = userid
            End With
            MyBase.Conn.Open()
            rp = Comm.ExecuteNonQuery()
            MyBase.Conn.Close()
        Catch ex As Exception
            MyBase.Conn.Close()
        End Try
        Return rp
    End Function

    Public Function RegistrarObservacionPosicion(idalmacenobservar As Integer, cajas As Decimal, cajasmaster As Decimal, idrack As Integer, userid As Integer, codubicacion As Integer, idsite As Integer, idalmacen As Integer, idconcepto As Integer, CodAlma As String, codNumero As String, tipodoc As String, CodArticulo As String, lote As String, cantidad As Decimal, ocupado As Decimal, tipooperacion As String, respuesta As String) As Integer
        Dim rp As Integer = 0
        Dim RpStore As SqlDataReader = Nothing
        Dim Comm As New SqlCommand("CSE_SP_RegistrarObservacion", MyBase.Conn)
        Try
            Comm.CommandType = CommandType.StoredProcedure
            With Comm.Parameters

                .Add("@C5_CALMA", SqlDbType.Char, 4).Value = CodAlma
                .Add("@C5_CNUMDOC", SqlDbType.Char, 11).Value = codNumero
                .Add("@C5_CTD", SqlDbType.Char, 2).Value = tipodoc
                .Add("@userid", SqlDbType.Int).Value = userid
                .Add("@codarticulo", SqlDbType.Char, 25).Value = CodArticulo
                .Add("@lote", SqlDbType.Char, 18).Value = lote
                .Add("@codposicion", SqlDbType.Int).Value = codubicacion
                .Add("@cantidad", SqlDbType.Decimal).Value = cantidad
                .Add("@ocupado", SqlDbType.Decimal).Value = ocupado
                .Add("@tipo", SqlDbType.Char, 1).Value = tipooperacion
                .Add("@idsite", SqlDbType.Int).Value = idsite
                .Add("@idalmacen", SqlDbType.Int).Value = idalmacen
                .Add("@idrack", SqlDbType.Int).Value = idrack
                .Add("@cantcajas", SqlDbType.Decimal).Value = cajas
                .Add("@cantcajasmaster", SqlDbType.Decimal).Value = cajasmaster
                .Add("@idconcepto", SqlDbType.Int).Value = idconcepto
                .Add("@almacenobservar", SqlDbType.Int).Value = idalmacenobservar
                .Add("@ingresardiferencia", SqlDbType.Char, 2).Value = respuesta
            End With
            MyBase.Conn.Open()
            rp = Comm.ExecuteNonQuery()
            MyBase.Conn.Close()
        Catch ex As Exception
            MyBase.Conn.Close()
        End Try
        Return rp
    End Function

    Public Function RegistrarOperacion(cajas As Decimal, cajasmaster As Decimal, unidad As String, CodAlma As String, codNumero As String, tipodoc As String, userid As Integer, CodArticulo As String, lote As String, idposicion As Integer, cantidad As Decimal, total As Decimal, ocupado As Decimal, tipooperacion As String, idsite As Integer, idalmacen As Integer, idrack As Integer, vencimiento As String, correlativo As String) As Integer
        Dim rp As Integer = 0
        Dim Comm As New SqlCommand("SP_CSE_RegistrarOperacionAlmacen", MyBase.Conn)
        Try
            Comm.CommandType = CommandType.StoredProcedure
            With Comm.Parameters
                .Add("@C5_CALMA", SqlDbType.Char, 4).Value = CodAlma
                .Add("@C5_CNUMDOC", SqlDbType.Char, 11).Value = codNumero
                .Add("@C5_CTD", SqlDbType.Char, 2).Value = tipodoc
                .Add("@userid", SqlDbType.Int).Value = userid
                .Add("@codarticulo", SqlDbType.Char, 25).Value = CodArticulo
                .Add("@lote", SqlDbType.Char, 18).Value = lote
                .Add("@codposicion", SqlDbType.Int).Value = idposicion
                .Add("@cantidad", SqlDbType.Decimal).Value = cantidad
                .Add("@total", SqlDbType.Decimal).Value = total
                .Add("@ocupado", SqlDbType.Decimal).Value = ocupado
                .Add("@tipo", SqlDbType.Char, 1).Value = tipooperacion
                .Add("@idsite", SqlDbType.Int).Value = idsite
                .Add("@idalmacen", SqlDbType.Int).Value = idalmacen
                .Add("@idrack", SqlDbType.Int).Value = idrack
                .Add("@cantcajas", SqlDbType.Decimal).Value = cajas
                .Add("@cantcajasmaster", SqlDbType.Decimal).Value = cajasmaster
                .Add("@vencimiento", SqlDbType.Char, 10).Value = vencimiento
                .Add("@correlativo", SqlDbType.Char, 4).Value = correlativo
            End With
            MyBase.Conn.Open()
            rp = Comm.ExecuteNonQuery()
            MyBase.Conn.Close()
        Catch ex As Exception
            MyBase.Conn.Close()
        End Try
        Return rp
    End Function

    Public Function RegistrarOperacionSalida(userid As Integer, cajas As Decimal, cajasmaster As Decimal, CodAlma As String, codNumero As String, tipdoc As String, CodArticulo As String, lote As String, idposicion As Integer, cantidad As Decimal, ocupado As Decimal, tipooperacion As String, idsite As Integer, idalmacen As Integer, idrack As Integer, idmovimiento As Integer, correlativo As String) As Integer
        Dim rp As Integer = 0
        Dim Comm As New SqlCommand("SP_CSE_RegistrarOperacionSalida", MyBase.Conn)
        Try
            Comm.CommandType = CommandType.StoredProcedure
            With Comm.Parameters
                .Add("@C5_CALMA", SqlDbType.Char, 4).Value = CodAlma
                .Add("@C5_CNUMDOC", SqlDbType.Char, 11).Value = codNumero
                .Add("@C5_CTD", SqlDbType.Char, 2).Value = tipdoc
                .Add("@userid", SqlDbType.Int).Value = userid
                .Add("@codarticulo", SqlDbType.Char, 25).Value = CodArticulo
                .Add("@lote", SqlDbType.Char, 18).Value = lote
                .Add("@codposicion", SqlDbType.Int).Value = idposicion
                .Add("@cantidad", SqlDbType.Decimal).Value = cantidad * (-1)
                .Add("@tipo", SqlDbType.Char, 1).Value = tipooperacion
                .Add("@idsite", SqlDbType.Int).Value = idsite
                .Add("@idalmacen", SqlDbType.Int).Value = idalmacen
                .Add("@idrack", SqlDbType.Int).Value = idrack
                .Add("@ocupado", SqlDbType.Decimal).Value = ocupado
                .Add("@cantcajas", SqlDbType.Decimal).Value = cajas * (-1)
                .Add("@cantcajasmaster", SqlDbType.Decimal).Value = cajasmaster * (-1)
                .Add("@idmovimiento", SqlDbType.Int).Value = idmovimiento
                .Add("@correlativo", SqlDbType.Char, 4).Value = correlativo

            End With
            MyBase.Conn.Open()
            rp = Comm.ExecuteNonQuery()
            MyBase.Conn.Close()
        Catch ex As Exception
            MyBase.Conn.Close()
        End Try
        Return rp
    End Function

    Public Function Obtener_Guia_Impresion_Rotulos(ByVal flag As String, ByVal fecIni As String, ByVal fecFin As String, ByVal c5_ccodtra As String) As DataTable

        Try
            Dim com As New SqlCommand("SPDSN_LISTAR_GUIAS_IMP_ROTULOS", MyBase.Conn)
            MyBase.Conn.Open()
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@flag", SqlDbType.Int).Value = flag
            com.Parameters.Add("@fecIni", SqlDbType.VarChar, 12).Value = fecIni
            com.Parameters.Add("@fecFin", SqlDbType.VarChar, 12).Value = fecFin
            com.Parameters.Add("@c5_ccodtra", SqlDbType.VarChar, 20).Value = c5_ccodtra

            Dim Result As SqlDataReader
            Dim Tabla As New DataTable
            Result = com.ExecuteReader()
            Tabla.Load(Result)
            MyBase.Conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
            MyBase.Conn.Close()
        End Try

    End Function

    Public Function KardexArticulo(codarticulo As String, lote As String, idalmacen As Integer, idsite As Integer, fechadesde As String, fechahasta As String) As DataTable

        Try
            Dim com As New SqlCommand("SP_CSE_KARDEX_ARTICULO", MyBase.Conn)
            MyBase.Conn.Open()
            com.CommandType = CommandType.StoredProcedure
            com.Parameters.Add("@codarticulo", SqlDbType.Char, 25).Value = codarticulo
            com.Parameters.Add("@lote", SqlDbType.Char, 18).Value = lote
            com.Parameters.Add("@idalmacen", SqlDbType.Int).Value = idalmacen
            com.Parameters.Add("@idsite", SqlDbType.Int).Value = idsite
            com.Parameters.Add("@fechadesde", SqlDbType.Char, 10).Value = fechadesde
            com.Parameters.Add("@fechahasta", SqlDbType.Char, 10).Value = fechahasta

            Dim Result As SqlDataReader
            Dim Tabla As New DataTable
            Result = com.ExecuteReader()
            Tabla.Load(Result)
            MyBase.Conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
            MyBase.Conn.Close()
        End Try

    End Function

    Public Function Proceso() As DataTable

        Try
            Dim com As New SqlCommand("SP_CSE_OBTENERID", MyBase.Conn)
            MyBase.Conn.Open()
            com.CommandType = CommandType.StoredProcedure

            Dim Result As SqlDataReader
            Dim Tabla As New DataTable
            Result = com.ExecuteReader()
            Tabla.Load(Result)
            MyBase.Conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
            MyBase.Conn.Close()
        End Try

    End Function


    Public Function reemplazar(id As Integer) As Integer
        Dim rp As Integer = 0
        Dim Comm As New SqlCommand("SP_CSE_REEMPLAZARFEHCAS", MyBase.Conn)
        Try
            Comm.CommandType = CommandType.StoredProcedure
            With Comm.Parameters
                .Add("@drg_id", SqlDbType.Int).Value = id
            End With
            MyBase.Conn.Open()
            rp = Comm.ExecuteNonQuery()
            MyBase.Conn.Close()
        Catch ex As Exception
            MyBase.Conn.Close()
        End Try
        Return rp
    End Function


End Class
