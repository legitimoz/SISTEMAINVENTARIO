Imports Nordic.Bl.Be

Public Class AlmacenL
    Private objAlmacen As New AlmacenAD
    Public Function SP_CSE_ValidarAlerta() As DataTable
        Try
            Return objAlmacen.SP_CSE_ValidarAlerta
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function ObtenerIndicarLiquidacionDocumentaria(fechadesde As String, fechahasta As String) As DataTable
        Try
            Return objAlmacen.ObtenerIndicarLiquidacionDocumentaria(fechadesde, fechahasta)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function SP_LISTAR_ARTICULOS_CUBICAJE() As DataTable
        Try
            Return objAlmacen.SP_LISTAR_ARTICULOS_CUBICAJE()
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarGuiasCAB(fechadesde As String, fechahasta As String, idalmacen As Integer, idsite As Integer) As DataTable
        Try
            Return objAlmacen.ListarGuiasCAB(fechadesde, fechahasta, idalmacen, idsite)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function SP_CSE_ObtenerEstadoValidacion(CodArticulo As String) As DataTable
        Try
            Return objAlmacen.SP_CSE_ObtenerEstadoValidacion(CodArticulo)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ObtenerDataBonificacion(CCODAGE As String, CNUMPED As String) As DataTable
        Try
            Return objAlmacen.ObtenerDataBonificacion(CCODAGE, CNUMPED)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function SP_CSE_ACTUALIZAR_CUBICAJE_ART(codarticulo As String, alto As Decimal, ancho As Decimal, largo As Decimal, factorcji As Decimal, factorcjm As Decimal, peso As Decimal) As Integer
        Try
            Return objAlmacen.SP_CSE_ACTUALIZAR_CUBICAJE_ART(codarticulo, alto, ancho, largo, factorcji, factorcjm, peso)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function SP_CSE_RegistrarValidacionArticulo(codarticulo As String, userid As Integer) As Integer
        Try
            Return objAlmacen.SP_CSE_RegistrarValidacionArticulo(codarticulo, userid)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function SP_CSE_REPORTE_RUTAS(fechadesde As String, fechahasta As String) As DataTable
        Try
            Return objAlmacen.SP_CSE_REPORTE_RUTAS(fechadesde, fechahasta)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function SP_CSE_REPORTE_DESPACHOS(fechadesde As String, fechahasta As String) As DataTable
        Try
            Return objAlmacen.SP_CSE_REPORTE_DESPACHOS(fechadesde, fechahasta)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function SP_LISTAR_REPORTE_AVANCE_LINEA() As DataTable
        Try
            Return objAlmacen.SP_LISTAR_REPORTE_AVANCE_LINEA
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function SP_CSE_OBTENER_DATA_ACTUAL() As DataTable
        Try
            Return objAlmacen.SP_CSE_OBTENER_DATA_ACTUAL
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function SP_CSE_OBTENER_DATA_ACTUAL_DETALLE() As DataTable
        Try
            Return objAlmacen.SP_CSE_OBTENER_DATA_ACTUAL_DETALLE
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function sp_obtener_promedio_fijo(codarticulo As String) As DataTable
        Try
            Return objAlmacen.sp_obtener_promedio_fijo(codarticulo)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function SP_OBTENER_COSTOS() As DataTable
        Try
            Return objAlmacen.SP_OBTENER_COSTOS
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarSites() As DataTable
        Try
            Return objAlmacen.ListarSites()
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function RegistrarAlerta() As Integer
        Try
            Return objAlmacen.RegistrarAlerta()
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ObtenerArticulosAbastercer(fechadesde As String, fechahasta As String) As DataTable
        Try
            Return objAlmacen.ObtenerArticulosAbastercer(fechadesde, fechahasta)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarParteEntradaSinUbicar(fechadesde As String, fechahasta As String, idalmacen As Integer, idsite As Integer) As DataTable
        Try
            Return objAlmacen.ListarParteEntradaSinUbicar(fechadesde, fechahasta, idalmacen, idsite)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarParteSalidaCab(fechadesde As String, fechahasta As String, idalmacen As Integer, idsite As Integer) As DataTable
        Try
            Return objAlmacen.ListarParteSalidaCab(fechadesde, fechahasta, idalmacen, idsite)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarGuiasAnularPicking(fechadesde As String, fechahasta As String, idsite As Integer, idalmacen As Integer) As DataTable
        Try
            Return objAlmacen.ListarGuiasAnularPicking(fechadesde, fechahasta, idsite, idalmacen)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ObtenerFactoresArticulo(ByVal codarticulo As String) As DataTable
        Try
            Return objAlmacen.ObtenerFactoresArticulo(codarticulo)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function ListarMotivosDispatch() As DataTable
        Try
            Return objAlmacen.ListarMotivosDispatch
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ObtenerGuiaProgramacion(codAlmacen As String, ctd As String, nrodoc As String) As DataTable
        Try
            Return objAlmacen.ObtenerGuiaProgramacion(codAlmacen, ctd, nrodoc)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function ObtenerGuiaProgramacion(ctd As String, nrodoc As String) As DataTable
        Try
            Return objAlmacen.ObtenerGuiaProgramacion(ctd, nrodoc)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarMotivosDelivery() As DataTable
        Try
            Return objAlmacen.ListarMotivosDelivery
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarMotivosLiquidacion() As DataTable
        Try
            Return objAlmacen.ListarMotivosLiquidacion
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function RegistrarObservacionDispatch(CALMA As String, CTD As String, CNUMDOC As String, idmotivo As Integer) As Integer
        Try
            Return objAlmacen.RegistrarObservacionDispatch(CALMA, CTD, CNUMDOC, idmotivo)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function RegistrarObservacionDelivery(CALMA As String, CTD As String, CNUMDOC As String, idmotivo As Integer) As Integer
        Try
            Return objAlmacen.RegistrarObservacionDelivery(CALMA, CTD, CNUMDOC, idmotivo)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function SP_CSE_RegistrarObservacionLiquidacion(CALMA As String, CTD As String, CNUMDOC As String, idmotivo As Integer) As Integer
        Try
            Return objAlmacen.SP_CSE_RegistrarObservacionLiquidacion(CALMA, CTD, CNUMDOC, idmotivo)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ReporteRotulosProducto(ByVal CALMA As String, ByVal CTD As String, CNUMDOC As String) As DataTable
        Try
            Return objAlmacen.ReporteRotulosProducto(CALMA, CTD, CNUMDOC)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function RegistrarRecepcionGuiaDespacho(CALMA As String, CTD As String, CNUMDOC As String, userid As Integer, idcosto As Integer, fisico As String, idsiteliq As Integer, idsitePicking As Integer, Comentario As String) As Integer
        Try
            Return objAlmacen.RegistrarRecepcionGuiaDespacho(CALMA, CTD, CNUMDOC, userid, idcosto, fisico, idsiteliq, idsitePicking, Comentario)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function SP_CSE_RegistrarFechaVC_OC(CALMA As String, CTD As String, CNUMDOC As String, userid As Integer, fecha As String) As Integer
        Try
            Return objAlmacen.SP_CSE_RegistrarFechaVC_OC(CALMA, CTD, CNUMDOC, userid, fecha)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function RegistrarComentarioGuiaDespacho(CALMA As String, CTD As String, CNUMDOC As String, comentario As String, user_id As Integer) As Integer
        Try
            Return objAlmacen.RegistrarComentarioGuiaDespacho(CALMA, CTD, CNUMDOC, comentario, user_id)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function ListarTransportistaDespacho() As DataTable
        Try
            Return objAlmacen.ListarTransportistaDespacho
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function ListarVehiculoDespacho(ByVal idsite As Integer) As DataTable
        Try
            Return objAlmacen.ListarVehiculoDespacho(idsite)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarImportarRotulos(fechadesde As String, fechahasta As String) As DataTable
        Try
            Return objAlmacen.ListarImportarRotulos(fechadesde, fechahasta)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ObtenerDataNonConfirmintyRatio(fechadesde As String, fechahasta As String) As DataTable
        Try
            Return objAlmacen.ObtenerDataNonConfirmintyRatio(fechadesde, fechahasta)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarPicadores(idsite As Integer) As DataTable
        Try
            Return objAlmacen.ListarPicadores(idsite)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function CambiarEstadoGuia(C5_CALMA As String, C5_CTD As String, C5_CNUMDOC As String, ESTADO As String, idpicador As Integer, idfiltro As Integer, userimpresion As Integer, comentario As String) As Integer
        Try
            Return objAlmacen.CambiarEstadoGuia(C5_CALMA, C5_CTD, C5_CNUMDOC, ESTADO, idpicador, idfiltro, userimpresion, comentario)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function BuscarUbicacionArticulo(idalmacen As Integer, idsite As Integer) As DataTable
        Try
            Return objAlmacen.BuscarUbicacionArticulo(idalmacen, idsite)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function SP_CSE_ConversioCodigo(iddetalle As Integer, CodigoNuevo As String, userid As Integer, cantidadIngreso As Decimal, cantidadSalida As Decimal) As Integer
        Try
            Return objAlmacen.SP_CSE_ConversioCodigo(iddetalle, CodigoNuevo, userid, cantidadIngreso, cantidadSalida)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function SP_CSE_ObtenerFactorCodigo(CodArticulo As String) As DataTable
        Try
            Return objAlmacen.SP_CSE_ObtenerFactorCodigo(CodArticulo)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function RegistrarFacturaTransportista(CNUMDOC As String, factura As String, ctd As String, calma As String) As Integer
        Try
            Return objAlmacen.RegistrarFacturaTransportista(CNUMDOC, factura, ctd, calma)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function RegistrarFacturaInyectado(CNUMDOC As String, factura As String, ctd As String, calma As String) As Integer
        Try
            Return objAlmacen.RegistrarFacturaInyectado(CNUMDOC, factura, ctd, calma)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ObtenrCodigoAlternoArticulo(CodArticulo As String, Serie As String) As DataTable
        Try
            Return objAlmacen.ObtenrCodigoAlternoArticulo(CodArticulo, Serie)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function SP_CSE_OBTENER_PRD_X_DESCRIPCION(descripcion As String) As DataTable
        Try
            Return objAlmacen.SP_CSE_OBTENER_PRD_X_DESCRIPCION(descripcion)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Reporte_Articulos_Sin_Ubicar(idalmacen As Integer, idsite As Integer) As DataTable
        Try
            Return objAlmacen.Reporte_Articulos_Sin_Ubicar(idalmacen, idsite)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ObtenerIndicarDIspatchOnTime(fechadesde As String, fechahasta As String) As DataTable
        Try
            Return objAlmacen.ObtenerIndicarDIspatchOnTime(fechadesde, fechahasta)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ObtenerIndicarDeliveryhOnTime(fechadesde As String, fechahasta As String) As DataTable
        Try
            Return objAlmacen.ObtenerIndicarDeliveryhOnTime(fechadesde, fechahasta)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarPedidosPicking(fechadesde As String, fechahasta As String) As DataTable
        Try
            Return objAlmacen.ListarPedidosPicking(fechadesde, fechahasta)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarCaneles() As DataTable
        Try
            Return objAlmacen.ListarCaneles
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ReveritrDetallePickin(iddetalle As Integer, userid As Integer) As Integer
        Try
            Return objAlmacen.ReveritrDetallePickin(iddetalle, userid)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ObtenerDetallePickin(codAlmacen As String, ctd As String, nrodoc As String) As DataTable
        Try
            Return objAlmacen.ObtenerDetallePickin(codAlmacen, ctd, nrodoc)
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Public Function ObtenerDataRuta(idruta As Integer) As DataTable
        Try
            Return objAlmacen.ObtenerDataRuta(idruta)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function SP_VALIDAR_DOCUMENTO(C5_CNUMDOC As String) As DataTable
        Try
            Return objAlmacen.SP_VALIDAR_DOCUMENTO(C5_CNUMDOC)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarPedidosDespacho(fechadesde As String, fechahasta As String, idalmacen As Integer, idsite As Integer) As DataTable
        Try

            Dim rp, rp2 As New DataTable
            rp = objAlmacen.ListarPedidosDespacho(fechadesde, fechahasta, idalmacen, idsite)
            rp2 = objAlmacen.ListarPedidosDespachoReprogramar(idsite, idalmacen)
            rp.Merge(rp2)

            Return rp
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function SP_CSE_LISTARTIPOENVIORUTA() As DataTable
        Dim rp, rp2 As New DataTable
        Try
            rp = objAlmacen.SP_CSE_LISTARTIPOENVIORUTA()
        Catch ex As Exception
            Throw ex
        End Try
        Return rp
    End Function

    Public Function SP_CSE_LISTAR_ARTICULOS() As DataTable
        Dim rp As New DataTable
        Try
            rp = objAlmacen.SP_CSE_LISTAR_ARTICULOS()
        Catch ex As Exception
            Throw ex
        End Try
        Return rp
    End Function
    Public Function obtenerStock_ATE_CJM_X_CODIGOARTI(Codarticulo As String) As DataTable
        Try
            Return objAlmacen.obtenerStock_ATE_CJM_X_CODIGOARTI(Codarticulo)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener_Transportistas_paraRotulos() As DataTable
        Try
            Return objAlmacen.Obtener_Transportistas_paraRotulos
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function Agregar_Guia_Ruta(crg_id As Integer, calma As String, ctd As String, cnumdoc As String, userid As Integer, peso As Decimal, bultos As Integer, tiempo As Decimal, volumen As Decimal, restriccion As String, tiporuta As String, cliente As String, Direccion As String, importe As Decimal, condicion As String, REPRESENTATE As String, idcosto As Integer, fecharecepcion As String, horarecepcion As String, idsite As Integer, departamento As String, provincia As String, distrito As String, fisico As String, idsiteliq As Integer, idsitepicking As Integer, canal As String) As Integer
        Try
            Return objAlmacen.Agregar_Guia_Ruta(crg_id, calma, ctd, cnumdoc, userid, peso, bultos, tiempo, volumen, restriccion, tiporuta, cliente, Direccion, importe, condicion, REPRESENTATE, idcosto, fecharecepcion, horarecepcion, idsite, departamento, provincia, distrito, fisico, idsiteliq, idsitepicking, canal)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function CSE_SP_LISTAR_TIEMPSO_JJ() As DataTable
        Try
            Return objAlmacen.CSE_SP_LISTAR_TIEMPSO_JJ
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarTiemposEntrega() As DataTable
        Try
            Return objAlmacen.ListarTiemposEntrega
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarRutas() As DataTable
        Try
            Return objAlmacen.ListarRutas
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarPosicionesXArticulo(ByVal codarticulo As String, idsite As Integer, idalmacen As Integer) As DataTable
        Try
            Return objAlmacen.ListarPosicionesXArticulo(codarticulo, idsite, idalmacen)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function ListarConceptosObservacion() As DataTable
        Try
            Return objAlmacen.ListarConceptosObservacion
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Public Function RegistrarObservacionPosicion(idalmacenobservar As Integer, cajas As Decimal, cajasmaster As Decimal, idrack As Integer, userid As Integer, codubicacion As Integer, idsite As Integer, idalmacen As Integer, idconcepto As Integer, CodAlma As String, codNumero As String, tipodoc As String, CodArticulo As String, lote As String, cantidad As Decimal, ocupado As Decimal, tipooperacion As String, respuesta As String) As Integer
        Try
            Return objAlmacen.RegistrarObservacionPosicion(idalmacenobservar, cajas, cajasmaster, idrack, userid, codubicacion, idsite, idalmacen, idconcepto, CodAlma, codNumero, tipodoc, CodArticulo, lote, cantidad, ocupado, tipooperacion, respuesta)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarGuiasDET(codAlmacen As String, tipdoc As String, nrodoc As String, idalmacen As Integer, idsite As Integer) As DataTable
        Try
            Return objAlmacen.ListarGuiasDET(codAlmacen, tipdoc, nrodoc, idalmacen, idsite)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarAlmacenes(ByVal idsite As Integer, ByVal codalmacen As String) As DataTable
        Try
            Return objAlmacen.ListarAlmacenes(idsite, codalmacen)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarAlmacenesSoftcom() As DataTable
        Try
            Return objAlmacen.ListarAlmacenesSoftcom
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarRacks(idalmacen As Integer) As DataTable
        Try
            Return objAlmacen.ListarRacks(idalmacen)
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Public Function RegistroArticuloUnitario(CALMA As String, userid As Integer, idsite As Integer, idalmacen As Integer, idrack As Integer, codarticulo As String, serie As String, idposicion As Integer, cantidad As Integer, vencimiento As String) As Integer
        Try
            Return objAlmacen.RegistroArticuloUnitario(CALMA, userid, idsite, idalmacen, idrack, codarticulo, serie, idposicion, cantidad, vencimiento)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function ListarPosiciones(idRack As Integer) As DataTable
        Try
            Return objAlmacen.ListarPosiciones(idRack)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function ListarStockPosicion(idubicacion As Integer) As DataTable
        Try
            Return objAlmacen.ListarStockPosicion(idubicacion)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarPedidosCAB() As DataTable
        Try
            Return objAlmacen.ListarPedidosCAB
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ObtenerPosicionesHojaPicking(ByVal codarticulo As String, ByVal Lote As String, cantidadrequerida As Decimal, idalmacen As Integer, idsite As Integer, PerfilUsuario As Integer) As DataTable
        Try
            Return objAlmacen.ObtenerPosicionesHojaPicking(codarticulo, Lote, cantidadrequerida, idalmacen, idsite, PerfilUsuario)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ObtenerDatosCliente(ruc As String) As DataTable
        Try
            Return objAlmacen.ObtenerDatosCliente(ruc)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ObtenerDireccionesCliente(ruc As String) As DataTable
        Try
            Return objAlmacen.ObtenerDireccionesCliente(ruc)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ObtenerCantidadSalidaDetalle(calma As String, ctd As String, cnumdoc As String, codarticulo As String, serie As String, item As String, idsite As Integer, idalmacen As Integer) As DataTable
        Try
            Return objAlmacen.ObtenerCantidadSalidaDetalle(calma, ctd, cnumdoc, codarticulo, serie, item, idsite, idalmacen)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ObtenerComplementeArticulo(codarticulo As String, idsite As Integer, idalmacen As Integer) As DataTable
        Try
            Return objAlmacen.ObtenerComplementeArticulo(codarticulo, idsite, idalmacen)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function EliminarRuta(idruta As Integer) As List(Of String)
        Try
            Return objAlmacen.EliminarRuta(idruta)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function RegistrarAlmacen(idalmacen As Integer, numeracion As Integer, x As Integer, y As Integer, codigoAlmacen As String) As Integer

        Dim rp As Integer = 0
        Dim CodigoEspacio As String
        Dim SerieA, SerieB, SerieC As String
        Dim XML As String = ""
        Try
            Dim ObjRack As New Rack
            ObjRack.ra_idalmacen = idalmacen
            ObjRack.ra_numeracion = numeracion
            ObjRack.ra_codigoalmacen = codigoAlmacen
            ObjRack.ra_cantidadx = x
            ObjRack.ra_cantidady = y
            ObjRack.ListaEspacios = New List(Of EspeacioRack)
            If numeracion < 10 Then
                SerieA = "0" + numeracion.ToString()
            Else
                SerieA = numeracion.ToString()
            End If

            If x <> 0 And y <> 0 Then
                For i As Integer = 1 To y
                    For i2 As Integer = 1 To x
                        If i < 10 Then
                            SerieB = "0" + i.ToString()
                        Else
                            SerieB = i.ToString()
                        End If

                        If i2 < 10 Then
                            SerieC = "0" + i2.ToString()
                        Else
                            SerieC = i2.ToString()
                        End If
                        CodigoEspacio = SerieA + SerieB + SerieC
                        Dim Espacio As New EspeacioRack
                        Espacio.esp_codigoespacio = CodigoEspacio
                        Espacio.esp_ubicacionx = i2
                        Espacio.esp_ubicaciony = i
                        ObjRack.ListaEspacios.Add(Espacio)
                    Next
                Next
                If (ObjRack.ListaEspacios.Count > 0) Then
                    XML = ObjRack.Serializar(ObjRack)
                    rp = objAlmacen.RegistrarRack(XML)
                End If
            End If

        Catch ex As Exception
            Throw ex
        End Try
        Return rp

    End Function

    Public Function RegistrarIngresoMasivo(XML As String) As Integer
        Try
            Return objAlmacen.RegistrarIngresoMasivo(XML)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function TrasladoUbicaciones(idrack As Integer, idubicacion As Integer, iddetalle As Integer, cantidad As Decimal, userid As Integer) As Integer
        Try
            Return objAlmacen.TrasladoUbicaciones(idrack, idubicacion, iddetalle, cantidad, userid)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarUbicacionesXSite_Almacen(ByVal idsite As Integer, ByVal idalmacen As Integer) As DataTable
        Try
            Return objAlmacen.ListarUbicacionesXSite_Almacen(idsite, idalmacen)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarPosicionesCompletar(idRack As Integer) As DataTable
        Try
            Return objAlmacen.ListarPosicionesCompletar(idRack)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ComplementarEspaciosTodos(idrack As Integer, alto As Decimal, largo As Decimal, ancho As Decimal) As Integer
        Try
            Return objAlmacen.ComplementarEspaciosTodos(idrack, alto, largo, ancho)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarParteEntradaCAB(fechadesde As String, fechahasta As String, idalmacen As Integer, idsite As Integer) As DataTable
        Try
            Return objAlmacen.ListarParteEntradaCAB(fechadesde, fechahasta, idalmacen, idsite)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarParteEntradaDET(codAlmacen As String, codcabecera As String, tipdoc As String, idalmacen As Integer, idsite As Integer) As DataTable
        Try
            Return objAlmacen.ListarParteEntradaDET(codAlmacen, codcabecera, tipdoc, idalmacen, idsite)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function ObtenerArticulosSinCubicaje() As DataTable
        Try
            Return objAlmacen.ObtenerArticulosSinCubicaje
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function KardexArticulo(codarticulo As String, lote As String, idalmacen As Integer, idsite As Integer, fechadesde As String, fechahasta As String) As DataTable
        Try
            Return objAlmacen.KardexArticulo(codarticulo, lote, idalmacen, idsite, fechadesde, fechahasta)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function RegistrarOperacion(factorcaja As Decimal, factormaster As Decimal, unidad As String, CodAlma As String, codNumero As String, tipodoc As String, userid As Integer, CodArticulo As String, lote As String, idposicion As Integer, cantidad As Decimal, total As Decimal, ocuado As Decimal, tipooperacion As String, idsite As Integer, idalmacen As Integer, idrack As Integer, vencimiento As String, correlativo As String) As Integer
        Dim cajas, cajasmaster As Decimal
        Try
            If unidad.Trim = "UND" Then
                If factorcaja <> 0 Then
                    cajas = cantidad / factorcaja
                Else
                    cajas = 0
                End If
                If factormaster <> 0 And cajas <> 0 Then
                    cajasmaster = Math.Round(cajas / factormaster, 2)
                Else
                    cajasmaster = 0
                End If
            End If

            If unidad.Trim = "CJA" Then
                cajas = cantidad
                If factormaster <> 0 And cajas <> 0 Then
                    cajasmaster = Math.Round(cajas / factormaster, 2)
                Else
                    cajasmaster = 0
                End If
            End If

            Return objAlmacen.RegistrarOperacion(cajas, cajasmaster, unidad, CodAlma, codNumero, tipodoc, userid, CodArticulo, lote, idposicion, cantidad, total, ocuado, tipooperacion, idsite, idalmacen, idrack, vencimiento, correlativo)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function RegistrarOperacionSalida(userid As Integer, factorcaja As Decimal, factormaster As Decimal, unidad As String, CodAlma As String, codNumero As String, tipdoc As String, CodArticulo As String, lote As String, idposicion As Integer, cantidad As Decimal, ocuado As Decimal, tipooperacion As String, idsite As Integer, idalmacen As Integer, idrack As Integer, idmovimiento As Integer, correlativo As String) As Integer
        Dim cajas, cajasmaster As Decimal
        Try
            If unidad.Trim = "UND" Then
                If factorcaja <> 0 Then
                    cajas = cantidad / factorcaja
                Else
                    cajas = 0
                End If
                If factormaster <> 0 And cajas <> 0 Then
                    cajasmaster = Math.Round(cajas / factormaster, 2)
                Else
                    cajasmaster = 0
                End If
            End If

            If unidad.Trim = "CJA" Then
                cajas = cantidad
                If factormaster <> 0 And cajas <> 0 Then
                    cajasmaster = Math.Round(cajas / factormaster, 2)
                Else
                    cajasmaster = 0
                End If
            End If

            Return objAlmacen.RegistrarOperacionSalida(userid, cajas, cajasmaster, CodAlma, codNumero, tipdoc, CodArticulo, lote, idposicion, cantidad, ocuado, tipooperacion, idsite, idalmacen, idrack, idmovimiento, correlativo)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarMovimientosXposicion(ByVal idposicion As Integer) As DataTable
        Try
            Return objAlmacen.ListarMovimientosXposicion(idposicion)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarUbicacionesVacias(idalmacen As Integer, idsite As Integer) As DataTable
        Try
            Return objAlmacen.ListarUbicacionesVacias(idalmacen, idsite)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarMovimientosXAlmacen(ByVal idalmacen As Integer, fechadesde As String, fechahasta As String) As DataTable
        Try
            Return objAlmacen.ListarMovimientosXAlmacen(idalmacen, fechadesde, fechahasta)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarPosicionesDetalle(codAlmacen As String, codcabecera As String, tipdoc As String, codarticulo As String, codlote As String) As DataTable
        Try
            Return objAlmacen.ListarPosicionesDetalle(codAlmacen, codcabecera, tipdoc, codarticulo, codlote)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarPedidosDET(F6_CCODAGE As String, F6_CNUMPED As String) As DataTable
        Try
            Return objAlmacen.ListarPedidosDET(F6_CCODAGE, F6_CNUMPED)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener_Guia_Impresion_Rotulos(ByVal flag As String, ByVal fecIni As String, ByVal fecFin As String, ByVal c5_ccodtra As String) As DataTable
        Try
            Return objAlmacen.Obtener_Guia_Impresion_Rotulos(flag, fecIni, fecFin, c5_ccodtra)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Proceso() As DataTable
        Try
            Return objAlmacen.Proceso
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function reemplazar(id As Integer) As Integer
        Try
            Return objAlmacen.reemplazar(id)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Obtener_Html_Alerta() As String
        Try
            Return objAlmacen.Obtener_Html_Alerta
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
