Imports ACCESODATOS
Imports Nordic.Bl.Be

Public Class AlmacenL
    Private objAlmacen As New AlmacenAD

    Public Function ListarGuiasCAB(fechadesde As String, fechahasta As String) As DataTable
        Try
            Return objAlmacen.ListarGuiasCAB(fechadesde, fechahasta)
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




    Public Function ListarMotivosDelivery() As DataTable
        Try
            Return objAlmacen.ListarMotivosDelivery
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

    Public Function ReporteRotulosProducto(ByVal CALMA As String, ByVal CTD As String, CNUMDOC As String) As DataTable
        Try
            Return objAlmacen.ReporteRotulosProducto(CALMA, CTD, CNUMDOC)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function RegistrarRecepcionGuiaDespacho(CALMA As String, CTD As String, CNUMDOC As String) As Integer
        Try
            Return objAlmacen.RegistrarRecepcionGuiaDespacho(CALMA, CTD, CNUMDOC)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function RegistrarComentarioGuiaDespacho(CALMA As String, CTD As String, CNUMDOC As String, comentario As String) As Integer
        Try
            Return objAlmacen.RegistrarComentarioGuiaDespacho(CALMA, CTD, CNUMDOC, comentario)
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
    Public Function ListarVehiculoDespacho() As DataTable
        Try
            Return objAlmacen.ListarVehiculoDespacho
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

    Public Function ListarPicadores() As DataTable
        Try
            Return objAlmacen.ListarPicadores
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function CambiarEstadoGuia(C5_CALMA As String, C5_CTD As String, C5_CNUMDOC As String, ESTADO As String, idpicador As Integer, idfiltro As Integer) As Integer
        Try
            Return objAlmacen.CambiarEstadoGuia(C5_CALMA, C5_CTD, C5_CNUMDOC, ESTADO, idpicador, idfiltro)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function BuscarUbicacionArticulo() As DataTable
        Try
            Return objAlmacen.BuscarUbicacionArticulo
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function Reporte_Articulos_Sin_Ubicar() As DataTable
        Try
            Return objAlmacen.Reporte_Articulos_Sin_Ubicar
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

    Public Function ListarPedidosDespacho(fechadesde As String, fechahasta As String) As DataTable
        Try

            Dim rp, rp2 As New DataTable
            rp = objAlmacen.ListarPedidosDespacho(fechadesde, fechahasta)
            rp2 = objAlmacen.ListarPedidosDespachoReprogramar
            rp.Merge(rp2)

            Return rp
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

    Public Function ListarPosicionesXArticulo(ByVal codarticulo As String) As DataTable
        Try
            Return objAlmacen.ListarPosicionesXArticulo(codarticulo)
        Catch ex As Exception

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

    Public Function ListarGuiasDET(codAlmacen As String, tipdoc As String, nrodoc As String) As DataTable
        Try
            Return objAlmacen.ListarGuiasDET(codAlmacen, tipdoc, nrodoc)
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

    Public Function ObtenerPosicionesHojaPicking(ByVal codarticulo As String, ByVal Lote As String, cantidadrequerida As Decimal) As DataTable
        Try
            Return objAlmacen.ObtenerPosicionesHojaPicking(codarticulo, Lote, cantidadrequerida)
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

    Public Function ListarParteEntradaCAB(fechadesde As String, fechahasta As String) As DataTable
        Try
            Return objAlmacen.ListarParteEntradaCAB(fechadesde, fechahasta)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarParteEntradaDET(codAlmacen As String, codcabecera As String, tipdoc As String) As DataTable
        Try
            Return objAlmacen.ListarParteEntradaDET(codAlmacen, codcabecera, tipdoc)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function RegistrarOperacion(factorcaja As Decimal, factormaster As Decimal, unidad As String, CodAlma As String, codNumero As String, tipodoc As String, userid As Integer, CodArticulo As String, lote As String, idposicion As Integer, cantidad As Decimal, total As Decimal, ocuado As Decimal, tipooperacion As String, idsite As Integer, idalmacen As Integer, idrack As Integer, vencimiento As String) As Integer
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

            Return objAlmacen.RegistrarOperacion(cajas, cajasmaster, unidad, CodAlma, codNumero, tipodoc, userid, CodArticulo, lote, idposicion, cantidad, total, ocuado, tipooperacion, idsite, idalmacen, idrack, vencimiento)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function RegistrarOperacionSalida(userid As Integer, factorcaja As Decimal, factormaster As Decimal, unidad As String, CodAlma As String, codNumero As String, tipdoc As String, CodArticulo As String, lote As String, idposicion As Integer, cantidad As Decimal, ocuado As Decimal, tipooperacion As String, idsite As Integer, idalmacen As Integer, idrack As Integer, idmovimiento As Integer) As Integer
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

            Return objAlmacen.RegistrarOperacionSalida(userid, cajas, cajasmaster, CodAlma, codNumero, tipdoc, CodArticulo, lote, idposicion, cantidad, ocuado, tipooperacion, idsite, idalmacen, idrack, idmovimiento)
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

End Class
