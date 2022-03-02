Public Class EstructuraTabla
    Public Function GestionAlmacen() As DataTable
        Dim TablaAlmacen As DataTable
        TablaAlmacen = New DataTable()
        Try
            TablaAlmacen.Columns.Add("alm_idalmacen", GetType(Integer))
            TablaAlmacen.Columns.Add("alm_nombrealmacen", GetType(String))
            TablaAlmacen.Columns.Add("sit_nombre", GetType(String))
            TablaAlmacen.Columns.Add("alm_idsite", GetType(Integer))
        Catch ex As Exception
            Throw ex
        End Try

        Return TablaAlmacen
    End Function

    Public Function DetaleHojaIngresoReport(ByVal imprimir As Boolean) As DataTable
        Dim TablaAlmacen As DataTable
        TablaAlmacen = New DataTable()
        Try
            If imprimir = True Then
                TablaAlmacen.Columns.Add("Ubicaciones", GetType(Boolean))
                TablaAlmacen.Columns.Add("CodArticulo", GetType(String))
                TablaAlmacen.Columns.Add("Articulo", GetType(String))
                TablaAlmacen.Columns.Add("Lote", GetType(String))
                TablaAlmacen.Columns.Add("Cantidad", GetType(String))
                TablaAlmacen.Columns.Add("Volumen", GetType(String))
                TablaAlmacen.Columns.Add("Posicion1", GetType(String))
                TablaAlmacen.Columns.Add("Posicion2", GetType(String))
                TablaAlmacen.Columns.Add("Posicion3", GetType(String))
                TablaAlmacen.Columns.Add("Cajas", GetType(String))
                TablaAlmacen.Columns.Add("CajasM", GetType(String))
                TablaAlmacen.Columns.Add("Saldo", GetType(String))
            Else
                TablaAlmacen.Columns.Add("CodArticulo", GetType(String))
                TablaAlmacen.Columns.Add("Articulo", GetType(String))
                TablaAlmacen.Columns.Add("Lote", GetType(String))
                TablaAlmacen.Columns.Add("Cantidad", GetType(String))
                TablaAlmacen.Columns.Add("Volumen", GetType(String))
                TablaAlmacen.Columns.Add("Posicion1", GetType(String))
                TablaAlmacen.Columns.Add("Posicion2", GetType(String))
                TablaAlmacen.Columns.Add("Posicion3", GetType(String))
                TablaAlmacen.Columns.Add("Cajas", GetType(String))
                TablaAlmacen.Columns.Add("CajasM", GetType(String))
                TablaAlmacen.Columns.Add("Saldo", GetType(String))
            End If
        Catch ex As Exception
            Throw ex
        End Try

        Return TablaAlmacen
    End Function

    Public Function DetalleSeleccionPosicion() As DataTable
        Dim TablaAlmacen As DataTable
        TablaAlmacen = New DataTable()
        Try
            TablaAlmacen.Columns.Add("Seleccionado", GetType(Boolean))
            TablaAlmacen.Columns.Add("Posicion", GetType(String))
        Catch ex As Exception
            Throw ex
        End Try

        Return TablaAlmacen
    End Function


    Public Function HojaDeRuta() As DataTable
        Dim TablaRuta As DataTable
        TablaRuta = New DataTable()
        Try
            TablaRuta.Columns.Add("Guia", GetType(String))
            TablaRuta.Columns.Add("Cliente", GetType(String))
            TablaRuta.Columns.Add("Direccion", GetType(String))
            TablaRuta.Columns.Add("Condicion", GetType(String))
            TablaRuta.Columns.Add("Importe", GetType(String))
            TablaRuta.Columns.Add("Representante", GetType(String))
            TablaRuta.Columns.Add("Volumen", GetType(String))
            TablaRuta.Columns.Add("TiempoEntrega", GetType(String))
            TablaRuta.Columns.Add("Numero", GetType(String))
            TablaRuta.Columns.Add("Restriccion", GetType(String))

        Catch ex As Exception
            Throw ex
        End Try

        Return TablaRuta
    End Function

    Public Function RutasTemporales() As DataTable
        Dim TablaRuta As DataTable
        TablaRuta = New DataTable()
        Try
            TablaRuta.Columns.Add("ids", GetType(String))
            TablaRuta.Columns.Add("NombreRuta", GetType(String))
            TablaRuta.Columns.Add("Transportista", GetType(String))
            TablaRuta.Columns.Add("Vehiculo", GetType(String))
            TablaRuta.Columns.Add("Volumen", GetType(String))
            TablaRuta.Columns.Add("Importe", GetType(String))
            TablaRuta.Columns.Add("Tiempo", GetType(String))
            TablaRuta.Columns.Add("Guias", GetType(String))
            TablaRuta.Columns.Add("Estado", GetType(String))
        Catch ex As Exception
            Throw ex
        End Try

        Return TablaRuta
    End Function

    Public Function DetaleHojaPickingReport() As DataTable
        Dim TablaAlmacen As DataTable
        TablaAlmacen = New DataTable()
        Try
            TablaAlmacen.Columns.Add("CodArticulo", GetType(String))
            TablaAlmacen.Columns.Add("Articulo", GetType(String))
            TablaAlmacen.Columns.Add("Lote", GetType(String))
            TablaAlmacen.Columns.Add("CantidadSalida", GetType(String))
            TablaAlmacen.Columns.Add("Unidad", GetType(String))
            TablaAlmacen.Columns.Add("Posicion1", GetType(String))
            TablaAlmacen.Columns.Add("Posicion2", GetType(String))
            TablaAlmacen.Columns.Add("Vencimiento", GetType(String))
            TablaAlmacen.Columns.Add("CajasM", GetType(String))
            TablaAlmacen.Columns.Add("CajasI", GetType(String))
            TablaAlmacen.Columns.Add("Saldo", GetType(String))
            'TablaAlmacen.Columns.Add("Posicion3", GetType(String))
        Catch ex As Exception
            Throw ex
        End Try

        Return TablaAlmacen
    End Function

    Public Function DetaleHojaPickConfirmReport() As DataTable
        Dim TablaAlmacen As DataTable
        TablaAlmacen = New DataTable()
        Try
            TablaAlmacen.Columns.Add("CodArticulo", GetType(String))
            TablaAlmacen.Columns.Add("Articulo", GetType(String))
            TablaAlmacen.Columns.Add("Lote", GetType(String))
            TablaAlmacen.Columns.Add("Cantidad", GetType(String))
            TablaAlmacen.Columns.Add("Posicion", GetType(String))
        Catch ex As Exception
            Throw ex
        End Try

        Return TablaAlmacen
    End Function

    Public Function TablaPosicionesCompletar() As DataTable
        Dim Tabladetalle As DataTable
        Tabladetalle = New DataTable()
        Try
            Tabladetalle.Columns.Add("esp_idespacio", GetType(Integer))
            Tabladetalle.Columns.Add("esp_codigoespacio", GetType(String))
            Tabladetalle.Columns.Add("esp_alto", GetType(String))
            Tabladetalle.Columns.Add("esp_largo", GetType(String))
            Tabladetalle.Columns.Add("esp_ancho", GetType(String))

        Catch ex As Exception

        End Try
        Return Tabladetalle
    End Function

    Public Function TablaPosicionesArticulo() As DataTable
        Dim Tabladetalle As DataTable
        Tabladetalle = New DataTable()
        Try
            Tabladetalle.Columns.Add("esp_idespacio", GetType(Integer))
            Tabladetalle.Columns.Add("CODARTI", GetType(String))
            Tabladetalle.Columns.Add("ARTICULO", GetType(String))
            Tabladetalle.Columns.Add("LOTE", GetType(String))
            Tabladetalle.Columns.Add("VENCIMIENTO", GetType(String))
            Tabladetalle.Columns.Add("SITE", GetType(String))
            Tabladetalle.Columns.Add("ALMACEN", GetType(String))
            Tabladetalle.Columns.Add("RACK", GetType(String))
            Tabladetalle.Columns.Add("CODUBI", GetType(String))
            Tabladetalle.Columns.Add("CANTIDADUBI", GetType(String))
            Tabladetalle.Columns.Add("CANTIDADEXTRAER", GetType(String))

        Catch ex As Exception

        End Try
        Return Tabladetalle
    End Function

    Public Function GestioRacknAlmacen() As DataTable
        Dim TablaAlmacen As DataTable
        TablaAlmacen = New DataTable()
        Try
            TablaAlmacen.Columns.Add("ra_idRack", GetType(Integer))
            TablaAlmacen.Columns.Add("ra_numeracion", GetType(Integer))
            TablaAlmacen.Columns.Add("ra_cantidadx", GetType(Integer))
            TablaAlmacen.Columns.Add("ra_cantidady", GetType(Integer))

        Catch ex As Exception

        End Try

        Return TablaAlmacen
    End Function

    Public Function FormatoGridTrasferencia() As DataTable
        Dim TablaAlmacen As DataTable
        TablaAlmacen = New DataTable()
        Try
            TablaAlmacen.Columns.Add("Marcar", GetType(Boolean))
            TablaAlmacen.Columns.Add("idoperacion", GetType(Integer))
            TablaAlmacen.Columns.Add("Operacion", GetType(String))
            TablaAlmacen.Columns.Add("CodArticulo", GetType(String))
            TablaAlmacen.Columns.Add("Articulo", GetType(String))
            TablaAlmacen.Columns.Add("Lote", GetType(String))
            TablaAlmacen.Columns.Add("Cantidad", GetType(String))
            TablaAlmacen.Columns.Add("CantidadAnterior", GetType(String))
        Catch ex As Exception
            Throw ex
        End Try

        Return TablaAlmacen
    End Function

    Public Function TablaDetalleParteEntrda() As DataTable
        Dim Tabladetalle As DataTable
        Tabladetalle = New DataTable()

        Try
            Tabladetalle.Columns.Add("UBICAR", GetType(Boolean))
            Tabladetalle.Columns.Add("C6_CITEM", GetType(String))
            Tabladetalle.Columns.Add("CODIGO", GetType(String))
            Tabladetalle.Columns.Add("PRODUCTO", GetType(String))
            Tabladetalle.Columns.Add("UNIDAD", GetType(String))
            Tabladetalle.Columns.Add("FACTORCAJA", GetType(Decimal))
            Tabladetalle.Columns.Add("FACTORCAJAMASTER", GetType(Decimal))
            Tabladetalle.Columns.Add("SERIE", GetType(String))
            Tabladetalle.Columns.Add("FECHA_VECIMIENTO", GetType(String))
            Tabladetalle.Columns.Add("CANTIDAD", GetType(Decimal))
            Tabladetalle.Columns.Add("SALDO", GetType(Decimal))
            Tabladetalle.Columns.Add("CAJAS", GetType(Decimal))
            Tabladetalle.Columns.Add("CAJASMASTER", GetType(Decimal))
            Tabladetalle.Columns.Add("VOLUMEN", GetType(String))
            Tabladetalle.Columns.Add("ANCHO", GetType(Decimal))
            Tabladetalle.Columns.Add("LARGO", GetType(Decimal))
            Tabladetalle.Columns.Add("ALTO", GetType(Decimal))
            Tabladetalle.Columns.Add("CODALMACEN_DESTINO", GetType(String))
            Tabladetalle.Columns.Add("ALMACEN_DESTINO", GetType(String))
            Tabladetalle.Columns.Add("CANAL", GetType(String))
            Tabladetalle.Columns.Add("RUC", GetType(String))
            Tabladetalle.Columns.Add("CLIENTE", GetType(String))
            Tabladetalle.Columns.Add("DEPARTAMENTO", GetType(String))
            Tabladetalle.Columns.Add("PROVINCIA", GetType(String))
            Tabladetalle.Columns.Add("DISTRITO", GetType(String))
            Tabladetalle.Columns.Add("TRANSPORTES", GetType(String))
        Catch ex As Exception
            Throw ex
        End Try
        Return Tabladetalle
    End Function


    Public Function TablaDetalleGuia() As DataTable
        Dim Tabladetalle As DataTable
        Tabladetalle = New DataTable()

        Try
            Tabladetalle.Columns.Add("SALIDA", GetType(Boolean))
            Tabladetalle.Columns.Add("C6_CITEM", GetType(String))
            Tabladetalle.Columns.Add("CODIGO", GetType(String))
            Tabladetalle.Columns.Add("PRODUCTO", GetType(String))
            Tabladetalle.Columns.Add("UNIDAD", GetType(String))
            Tabladetalle.Columns.Add("FACTORCAJA", GetType(Decimal))
            Tabladetalle.Columns.Add("FACTORCAJAMASTER", GetType(Decimal))
            Tabladetalle.Columns.Add("SERIE", GetType(String))
            Tabladetalle.Columns.Add("FECHA_VECIMIENTO", GetType(String))
            Tabladetalle.Columns.Add("CANTIDAD", GetType(Decimal))
            Tabladetalle.Columns.Add("SALDO", GetType(Decimal))
            Tabladetalle.Columns.Add("CAJAS", GetType(Decimal))
            Tabladetalle.Columns.Add("CAJASMASTER", GetType(Decimal))
            Tabladetalle.Columns.Add("VOLUMEN", GetType(String))
            Tabladetalle.Columns.Add("ANCHO", GetType(Decimal))
            Tabladetalle.Columns.Add("LARGO", GetType(Decimal))
            Tabladetalle.Columns.Add("ALTO", GetType(Decimal))
            Tabladetalle.Columns.Add("CODALMACEN_DESTINO", GetType(String))
            Tabladetalle.Columns.Add("ALMACEN_DESTINO", GetType(String))
            Tabladetalle.Columns.Add("CANAL", GetType(String))
            Tabladetalle.Columns.Add("RUC", GetType(String))
            Tabladetalle.Columns.Add("CLIENTE", GetType(String))
            Tabladetalle.Columns.Add("DEPARTAMENTO", GetType(String))
            Tabladetalle.Columns.Add("PROVINCIA", GetType(String))
            Tabladetalle.Columns.Add("DISTRITO", GetType(String))
            Tabladetalle.Columns.Add("TRANSPORTES", GetType(String))

        Catch ex As Exception
            Throw ex
        End Try
        Return Tabladetalle
    End Function
    Public Function TablaDetallePedidos() As DataTable
        Dim Tabladetalle As DataTable
        Tabladetalle = New DataTable()

        Try
            Tabladetalle.Columns.Add("SALIDA", GetType(Boolean))
            Tabladetalle.Columns.Add("CODIGO", GetType(String))
            Tabladetalle.Columns.Add("PRODUCTO", GetType(String))
            Tabladetalle.Columns.Add("UNIDAD", GetType(String))
            Tabladetalle.Columns.Add("FACTORCAJA", GetType(Decimal))
            Tabladetalle.Columns.Add("FACTORCAJAMASTER", GetType(Decimal))
            Tabladetalle.Columns.Add("SERIE", GetType(String))
            Tabladetalle.Columns.Add("FECHA_VECIMIENTO", GetType(String))

            Tabladetalle.Columns.Add("CANTIDAD", GetType(Decimal))
            Tabladetalle.Columns.Add("SALDO", GetType(Decimal))
            Tabladetalle.Columns.Add("CAJAS", GetType(Decimal))
            Tabladetalle.Columns.Add("CAJASMASTER", GetType(Decimal))
            Tabladetalle.Columns.Add("VOLUMEN", GetType(String))
            Tabladetalle.Columns.Add("ANCHO", GetType(Decimal))
            Tabladetalle.Columns.Add("LARGO", GetType(Decimal))
            Tabladetalle.Columns.Add("ALTO", GetType(Decimal))
        Catch ex As Exception
            Throw ex
        End Try
        Return Tabladetalle
    End Function


    Public Function TablaDetalleIngreso() As DataTable
        Dim Tabladetalle As DataTable
        Tabladetalle = New DataTable()
        Try
            Tabladetalle.Columns.Add("CORRELATIVO", GetType(String))
            Tabladetalle.Columns.Add("ARTICULO", GetType(String))
            Tabladetalle.Columns.Add("LOTE", GetType(String))
            Tabladetalle.Columns.Add("UNIDADES", GetType(Decimal))
            Tabladetalle.Columns.Add("CAJAS", GetType(Decimal))
            Tabladetalle.Columns.Add("CAJASMASTER", GetType(Decimal))
            Tabladetalle.Columns.Add("METROSCUBICOS", GetType(Decimal))
        Catch ex As Exception
            Throw ex
        End Try
        Return Tabladetalle
    End Function

    Public Function TablaPosicionesSalida() As DataTable
        Dim Tabladetalle As DataTable
        Tabladetalle = New DataTable()
        Try
            Tabladetalle.Columns.Add("idmovimiento", GetType(Integer))
            Tabladetalle.Columns.Add("esp_idespacio", GetType(Integer))
            Tabladetalle.Columns.Add("Espacio", GetType(String))
            Tabladetalle.Columns.Add("Cantidad", GetType(Integer))
            Tabladetalle.Columns.Add("idrack", GetType(Integer))
            Tabladetalle.Columns.Add("idalmacen", GetType(Integer))
            Tabladetalle.Columns.Add("idsite", GetType(Integer))
            Tabladetalle.Columns.Add("numeracion", GetType(String))
            Tabladetalle.Columns.Add("ANCHO", GetType(String))
            Tabladetalle.Columns.Add("LARGO", GetType(String))
            Tabladetalle.Columns.Add("ALTO", GetType(String))
            Tabladetalle.Columns.Add("FACTORCAJA", GetType(String))
            Tabladetalle.Columns.Add("FACTORCAJAMASTER", GetType(String))
        Catch ex As Exception
            Throw ex
        End Try
        Return Tabladetalle
    End Function

    Public Function TablaCabeceraParteEntrda() As DataTable
        Dim Tabladetalle As DataTable
        Tabladetalle = New DataTable()
        Try
            Tabladetalle.Columns.Add("CODALMACEN_ORIGEN", GetType(String))
            Tabladetalle.Columns.Add("Resta", GetType(String))
            Tabladetalle.Columns.Add("ALAMACEN_ORIGEN", GetType(String))
            Tabladetalle.Columns.Add("TIP_DOC", GetType(String))
            Tabladetalle.Columns.Add("NDOCUMENTO", GetType(String))
            Tabladetalle.Columns.Add("MES", GetType(String))
            Tabladetalle.Columns.Add("FECHA", GetType(String))
            Tabladetalle.Columns.Add("TIPO_MOV", GetType(String))
            Tabladetalle.Columns.Add("COD_MOV", GetType(String))
            Tabladetalle.Columns.Add("MOVIMIENTO", GetType(String))
            Tabladetalle.Columns.Add("NDOC_REFERENCIA", GetType(String))
            Tabladetalle.Columns.Add("NORDEN_COMPRA", GetType(String))
            Tabladetalle.Columns.Add("CODPROV", GetType(String))
            Tabladetalle.Columns.Add("PROVEEDOR", GetType(String))
            Tabladetalle.Columns.Add("GLOSA", GetType(String))
        Catch ex As Exception
            Throw ex
        End Try
        Return Tabladetalle
    End Function


    Public Function TablaCabeceraPedido() As DataTable
        Dim Tabladetalle As DataTable
        Tabladetalle = New DataTable()
        Try
            Tabladetalle.Columns.Add("MARCAR", GetType(Boolean))
            Tabladetalle.Columns.Add("Resta", GetType(String))
            Tabladetalle.Columns.Add("CodAlmacen", GetType(String))
            Tabladetalle.Columns.Add("Almacen", GetType(String))
            Tabladetalle.Columns.Add("F5_CCODAGE", GetType(String))
            Tabladetalle.Columns.Add("F5_CNUMPED", GetType(String))
            Tabladetalle.Columns.Add("OrdenCompra", GetType(String))
            Tabladetalle.Columns.Add("FECHA", GetType(String))
            Tabladetalle.Columns.Add("F5_CVENDE", GetType(String))
            Tabladetalle.Columns.Add("CodCli", GetType(String))
            Tabladetalle.Columns.Add("Cliente", GetType(String))
            Tabladetalle.Columns.Add("Ruc", GetType(String))
            Tabladetalle.Columns.Add("Direccion", GetType(String))

        Catch ex As Exception

        End Try
        Return Tabladetalle
    End Function

    Public Function TablaCabeceraGuia() As DataTable
        Dim Tabladetalle As DataTable
        Tabladetalle = New DataTable()
        Try
            Tabladetalle.Columns.Add("MARCAR", GetType(Boolean))
            Tabladetalle.Columns.Add("ESTADO_RECEP", GetType(String))
            Tabladetalle.Columns.Add("FECHA_RECEP", GetType(String))
            Tabladetalle.Columns.Add("HORA_RECEP", GetType(String))
            Tabladetalle.Columns.Add("ESTADO", GetType(String))
            Tabladetalle.Columns.Add("FECHA_IMPRE", GetType(String))
            Tabladetalle.Columns.Add("HORA_IMPRE", GetType(String))
            Tabladetalle.Columns.Add("USUARIO_IMPRE", GetType(String))
            Tabladetalle.Columns.Add("CODALMACEN_ORIGEN", GetType(String))
            Tabladetalle.Columns.Add("Resta", GetType(String))
            Tabladetalle.Columns.Add("ALAMACEN_ORIGEN", GetType(String))
            Tabladetalle.Columns.Add("TIP_DOC", GetType(String))
            Tabladetalle.Columns.Add("NDOCUMENTO", GetType(String))
            Tabladetalle.Columns.Add("CODPEDIDO", GetType(String))
            Tabladetalle.Columns.Add("FECHA", GetType(String))
            Tabladetalle.Columns.Add("TIPO_MOV", GetType(String))
            Tabladetalle.Columns.Add("MOVIMIENTO", GetType(String))
            Tabladetalle.Columns.Add("USUARIO", GetType(String))
            Tabladetalle.Columns.Add("RUC", GetType(String))
            Tabladetalle.Columns.Add("CLIENTE", GetType(String))
            Tabladetalle.Columns.Add("DIRECCIONCLIENTE", GetType(String))
            Tabladetalle.Columns.Add("PICADOR", GetType(String))
            Tabladetalle.Columns.Add("FILTRO", GetType(String))

        Catch ex As Exception
            Throw ex
        End Try
        Return Tabladetalle
    End Function

    Public Function TablaCabeceraGuiaRotulo() As DataTable
        Dim Tabladetalle As DataTable
        Tabladetalle = New DataTable()
        Try
            Tabladetalle.Columns.Add("MARCAR", GetType(Boolean))
            Tabladetalle.Columns.Add("C5_CALMA", GetType(String))
            Tabladetalle.Columns.Add("C5_CTD", GetType(String))
            Tabladetalle.Columns.Add("C5_CNUMDOC", GetType(String))
            Tabladetalle.Columns.Add("C5_CCODTRA", GetType(String))
            Tabladetalle.Columns.Add("C5_CNOMTRA", GetType(String))
            Tabladetalle.Columns.Add("drg_fecSalidaRuta", GetType(String))
            Tabladetalle.Columns.Add("C5_CNOMCLI", GetType(String))
            Tabladetalle.Columns.Add("C5_CDIRENV", GetType(String))
            Tabladetalle.Columns.Add("DE_CPROV", GetType(String))
            Tabladetalle.Columns.Add("DE_CDEPT", GetType(String))
            Tabladetalle.Columns.Add("TG_CDESCRI", GetType(String))
            Tabladetalle.Columns.Add("drg_bulto", GetType(Integer))
            Tabladetalle.Columns.Add("IMPRESO", GetType(String))
            Tabladetalle.Columns.Add("FECHA_IMP", GetType(String))
            Tabladetalle.Columns.Add("USUARIO", GetType(String))
        Catch ex As Exception
            Throw ex
        End Try
        Return Tabladetalle
    End Function

    Public Function TablaGestionProgramacionDespacho() As DataTable
        Dim Tabladetalle As DataTable
        Tabladetalle = New DataTable()
        Try
            Tabladetalle.Columns.Add("MARCAR", GetType(Boolean))
            Tabladetalle.Columns.Add("FECHA", GetType(String))
            Tabladetalle.Columns.Add("FECHA_GUIA", GetType(String))
            Tabladetalle.Columns.Add("HORA", GetType(String))
            Tabladetalle.Columns.Add("HORA_GUIA", GetType(String))
            Tabladetalle.Columns.Add("COD_PED", GetType(String))
            Tabladetalle.Columns.Add("NRO_GUIA", GetType(String))
            Tabladetalle.Columns.Add("CONDICION", GetType(String))
            Tabladetalle.Columns.Add("RUC", GetType(String))
            Tabladetalle.Columns.Add("NOM_CLIENTE", GetType(String))
            Tabladetalle.Columns.Add("DIRECCION_ENTREGA", GetType(String))
            Tabladetalle.Columns.Add("UBIGEO", GetType(String))
            Tabladetalle.Columns.Add("PROVINCIA", GetType(String))
            Tabladetalle.Columns.Add("DEPARTAMENTO", GetType(String))
            Tabladetalle.Columns.Add("DISTRITO", GetType(String))
            Tabladetalle.Columns.Add("LIMA_PROV", GetType(String))
            Tabladetalle.Columns.Add("CANAL", GetType(String))
            Tabladetalle.Columns.Add("TRANSPORTE", GetType(String))
            Tabladetalle.Columns.Add("M3UN", GetType(Decimal))
            Tabladetalle.Columns.Add("IMPORTE", GetType(Decimal))
            Tabladetalle.Columns.Add("M3FIN", GetType(Decimal))
            Tabladetalle.Columns.Add("TIEMPOENTREGA", GetType(Decimal))
            Tabladetalle.Columns.Add("DESTINO", GetType(String))
            Tabladetalle.Columns.Add("RUTA", GetType(String))
            Tabladetalle.Columns.Add("DETALLE", GetType(String))
            Tabladetalle.Columns.Add("RESTRICCION", GetType(String))
            Tabladetalle.Columns.Add("REPRESENTANTE", GetType(String))
        Catch ex As Exception
            Throw ex
        End Try
        Return Tabladetalle
    End Function

    Public Function DetalleConsolidado() As DataTable
        Dim Tabladetalle As DataTable
        Tabladetalle = New DataTable()
        Try
            Tabladetalle.Columns.Add("idconsolidado", GetType(Integer))
            Tabladetalle.Columns.Add("NRO_GUIA", GetType(String))
            Tabladetalle.Columns.Add("CTD", GetType(String))
            Tabladetalle.Columns.Add("CALMA", GetType(String))
            Tabladetalle.Columns.Add("NOM_CLIENTE", GetType(String))
            Tabladetalle.Columns.Add("DIRECCION_ENTREGA", GetType(String))
            Tabladetalle.Columns.Add("CONDICION", GetType(String))
            Tabladetalle.Columns.Add("IMPORTE", GetType(Decimal))
            Tabladetalle.Columns.Add("M3UN", GetType(Decimal))
            Tabladetalle.Columns.Add("TIEMPO", GetType(Decimal))
            Tabladetalle.Columns.Add("REPRESENTANTE", GetType(String))
            Tabladetalle.Columns.Add("RESTRICCION", GetType(String))
        Catch ex As Exception
            Throw ex
        End Try
        Return Tabladetalle
    End Function

    Public Function TablaConsolidadaDestino() As DataTable
        Dim Tabladetalle As DataTable
        Tabladetalle = New DataTable()
        Try
            Tabladetalle.Columns.Add("idconsolidado", GetType(Integer))
            Tabladetalle.Columns.Add("DESTINO", GetType(String))
            Tabladetalle.Columns.Add("NOM_CLIENTE", GetType(String))
            Tabladetalle.Columns.Add("DIRECCION_ENTREGA", GetType(String))
            Tabladetalle.Columns.Add("DISTRITO", GetType(String))
            Tabladetalle.Columns.Add("CANAL", GetType(String))
            Tabladetalle.Columns.Add("RUTA", GetType(String))
            Tabladetalle.Columns.Add("DETALLE", GetType(String))
            Tabladetalle.Columns.Add("RESTRICCION", GetType(String))
            Tabladetalle.Columns.Add("TOTALIMPORTE", GetType(Decimal))
            Tabladetalle.Columns.Add("TOTALMETROSCUBICOS", GetType(Decimal))
            Tabladetalle.Columns.Add("CANTIDADGUIAS", GetType(Integer))
            Tabladetalle.Columns.Add("TIEMPOENTREGA", GetType(Decimal))
            Tabladetalle.Columns.Add("CONDICION", GetType(String))
        Catch ex As Exception
            Throw ex
        End Try
        Return Tabladetalle
    End Function

    Public Function TablaRutasLima() As DataTable
        Dim Tabladetalle As DataTable
        Tabladetalle = New DataTable()
        Try
            Tabladetalle.Columns.Add("RUTA", GetType(String))
            Tabladetalle.Columns.Add("DETALLE", GetType(String))
            Tabladetalle.Columns.Add("NOM_CLIENTE", GetType(String))
            Tabladetalle.Columns.Add("DISTRITO", GetType(String))
            Tabladetalle.Columns.Add("DIRECCION_ENTREGA", GetType(String))
            Tabladetalle.Columns.Add("CANAL", GetType(String))
            Tabladetalle.Columns.Add("RESTRICCION", GetType(String))
            Tabladetalle.Columns.Add("DESTINO", GetType(String))
            Tabladetalle.Columns.Add("TOTALIMPORTE", GetType(Decimal))
            Tabladetalle.Columns.Add("CANTIDADGUIAS", GetType(Integer))
            Tabladetalle.Columns.Add("TIEMPOENTREGA", GetType(Decimal))
            Tabladetalle.Columns.Add("TOTALMETROSCUBICOS", GetType(Decimal))
            Tabladetalle.Columns.Add("COMENTARIO", GetType(String))
        Catch ex As Exception
            Throw ex
        End Try
        Return Tabladetalle
    End Function

    Public Function IndicadorDispatchOnTime() As DataTable
        Dim Tabladetalle As DataTable
        Tabladetalle = New DataTable()
        Try

            Tabladetalle.Columns.Add("NRO_GUIA", GetType(String))
            Tabladetalle.Columns.Add("FECHA_GUIA", GetType(String))
            'Tabladetalle.Columns.Add("HORA_INGRESO", GetType(String))
            Tabladetalle.Columns.Add("FECHA_DESPACHO", GetType(String))
            'Tabladetalle.Columns.Add("HORA_DESPACHO", GetType(String))
            Tabladetalle.Columns.Add("LIM_PROV", GetType(String))
            Tabladetalle.Columns.Add("Hora", GetType(String))
            Tabladetalle.Columns.Add("ESTADO", GetType(String))
            Tabladetalle.Columns.Add("Direferencia", GetType(String))
            Tabladetalle.Columns.Add("CTD", GetType(String))
            Tabladetalle.Columns.Add("CALMA", GetType(String))
            Tabladetalle.Columns.Add("FECHA_GUIAB", GetType(String))
            Tabladetalle.Columns.Add("FECHA_DESPACHOB", GetType(String))
            Tabladetalle.Columns.Add("MOTIVO", GetType(String))
            Tabladetalle.Columns.Add("AREA", GetType(String))
        Catch ex As Exception
            Throw ex
        End Try
        Return Tabladetalle
    End Function

    Public Function GridImportarRotulos() As DataTable
        Dim TablaRetorno As DataTable
        TablaRetorno = New DataTable()
        Try
            TablaRetorno.Columns.Add("Marcar", GetType(Boolean))
            TablaRetorno.Columns.Add("C5_CNUMDOC", GetType(String))
            TablaRetorno.Columns.Add("C5_CNOMCLI", GetType(String))
            TablaRetorno.Columns.Add("C5_CDIRENV", GetType(String))
            TablaRetorno.Columns.Add("DE_CPROV", GetType(String))
            TablaRetorno.Columns.Add("DE_CDEPT", GetType(String))
            TablaRetorno.Columns.Add("BULTO", GetType(String))
            TablaRetorno.Columns.Add("drg_bulto", GetType(Integer))
        Catch ex As Exception
            Throw ex
        End Try
        Return TablaRetorno
    End Function

    Public Function GridImportarRotulosExcel() As DataTable
        Dim TablaRetorno As DataTable
        TablaRetorno = New DataTable()
        Try
            'TablaRetorno.Columns.Add("Marcar", GetType(Boolean))
            TablaRetorno.Columns.Add("C5_CNUMDOC", GetType(String))
            TablaRetorno.Columns.Add("C5_CNOMCLI", GetType(String))
            TablaRetorno.Columns.Add("C5_CDIRENV", GetType(String))
            TablaRetorno.Columns.Add("DE_CPROV", GetType(String))
            TablaRetorno.Columns.Add("DE_CDEPT", GetType(String))
            TablaRetorno.Columns.Add("BULTO", GetType(String))
        Catch ex As Exception
            Throw ex
        End Try
        Return TablaRetorno
    End Function

    Public Function IndicadorDeliveryOnTime() As DataTable
        Dim Tabladetalle As DataTable
        Tabladetalle = New DataTable()
        Try

            Tabladetalle.Columns.Add("COD_PED", GetType(String))
            Tabladetalle.Columns.Add("GUIA", GetType(String))
            Tabladetalle.Columns.Add("LIM_PROV", GetType(String))
            Tabladetalle.Columns.Add("PROVINCIA", GetType(String))
            Tabladetalle.Columns.Add("FECHA_PEDIDO", GetType(String))
            Tabladetalle.Columns.Add("FECHA_GUIA", GetType(String))
            Tabladetalle.Columns.Add("FECHA_DESPACHO", GetType(String))
            Tabladetalle.Columns.Add("FECHA_RECEPCLIENTE", GetType(String))
            Tabladetalle.Columns.Add("TIEMPO_MAX", GetType(String))
            Tabladetalle.Columns.Add("TIEMPO_TRASN", GetType(String))
            Tabladetalle.Columns.Add("Estado", GetType(String))
            Tabladetalle.Columns.Add("MOTIVO", GetType(String))
            Tabladetalle.Columns.Add("AREA", GetType(String))
            Tabladetalle.Columns.Add("C5_CALMA", GetType(String))
            Tabladetalle.Columns.Add("C5_CTD", GetType(String))

        Catch ex As Exception
            Throw ex
        End Try
        Return Tabladetalle
    End Function
    Public Function ReporteArticulosSinUbicar() As DataTable
        Dim Tabladetalle As DataTable
        Tabladetalle = New DataTable()
        Try
            Tabladetalle.Columns.Add("UBICACION", GetType(String))
            Tabladetalle.Columns.Add("CODIGO", GetType(String))
            Tabladetalle.Columns.Add("CANTIDAD", GetType(Decimal))
            Tabladetalle.Columns.Add("LOTE", GetType(String))
            Tabladetalle.Columns.Add("ALMACEN", GetType(String))
        Catch ex As Exception
            Throw ex
        End Try
        Return Tabladetalle
    End Function

    Public Function TablaProgramacionPicking() As DataTable
        Dim Tabladetalle As DataTable
        Tabladetalle = New DataTable()
        Try
            Tabladetalle.Columns.Add("MARCAR", GetType(Boolean))
            Tabladetalle.Columns.Add("FECHA", GetType(String))
            Tabladetalle.Columns.Add("HORA", GetType(String))
            Tabladetalle.Columns.Add("COD_PED", GetType(String))
            Tabladetalle.Columns.Add("DESCRIPCION", GetType(String))
            Tabladetalle.Columns.Add("ESTADO", GetType(String))
            Tabladetalle.Columns.Add("NRO_GUIA", GetType(String))
            Tabladetalle.Columns.Add("RUC", GetType(String))
            Tabladetalle.Columns.Add("NOM_CLIENTE", GetType(String))
            Tabladetalle.Columns.Add("DIRECCION_ENTREGA", GetType(String))
            Tabladetalle.Columns.Add("UBIGEO", GetType(String))
            Tabladetalle.Columns.Add("PROVINCIA", GetType(String))
            Tabladetalle.Columns.Add("DEPARTAMENTO", GetType(String))
            Tabladetalle.Columns.Add("DISTRITO", GetType(String))
            Tabladetalle.Columns.Add("LIMA_PROV", GetType(String))
            Tabladetalle.Columns.Add("CAJASM", GetType(String))
            Tabladetalle.Columns.Add("CAJAS", GetType(String))
            Tabladetalle.Columns.Add("SALDO", GetType(String))
            Tabladetalle.Columns.Add("M3UN", GetType(Decimal))
        Catch ex As Exception
            Throw ex
        End Try
        Return Tabladetalle
    End Function

    Public Function ExcelProgramacionPicking() As DataTable
        Dim Tabladetalle As DataTable
        Tabladetalle = New DataTable()
        Try

            Tabladetalle.Columns.Add("FECHA", GetType(String))
            Tabladetalle.Columns.Add("HORA", GetType(String))
            Tabladetalle.Columns.Add("COD_PED", GetType(String))
            Tabladetalle.Columns.Add("DESCRIPCION", GetType(String))
            Tabladetalle.Columns.Add("ESTADO", GetType(String))
            Tabladetalle.Columns.Add("NRO_GUIA", GetType(String))
            Tabladetalle.Columns.Add("RUC", GetType(String))
            Tabladetalle.Columns.Add("NOM_CLIENTE", GetType(String))
            Tabladetalle.Columns.Add("DIRECCION_ENTREGA", GetType(String))
            Tabladetalle.Columns.Add("UBIGEO", GetType(String))
            Tabladetalle.Columns.Add("PROVINCIA", GetType(String))
            Tabladetalle.Columns.Add("DEPARTAMENTO", GetType(String))
            Tabladetalle.Columns.Add("DISTRITO", GetType(String))
            Tabladetalle.Columns.Add("LIMA_PROV", GetType(String))
            Tabladetalle.Columns.Add("CAJASM", GetType(String))
            Tabladetalle.Columns.Add("CAJAS", GetType(String))
            Tabladetalle.Columns.Add("SALDO", GetType(String))
            Tabladetalle.Columns.Add("M3UN", GetType(Decimal))
        Catch ex As Exception
            Throw ex
        End Try
        Return Tabladetalle
    End Function

    Public Function ExcelProgramacionDespacho() As DataTable
        Dim Tabladetalle As DataTable
        Tabladetalle = New DataTable()
        Try
            Tabladetalle.Columns.Add("FECHA", GetType(String))
            Tabladetalle.Columns.Add("FECHA_GUIA", GetType(String))
            Tabladetalle.Columns.Add("HORA", GetType(String))
            Tabladetalle.Columns.Add("HORA_GUIA", GetType(String))
            Tabladetalle.Columns.Add("COD_PED", GetType(String))
            Tabladetalle.Columns.Add("NRO_GUIA", GetType(String))
            Tabladetalle.Columns.Add("RUC", GetType(String))
            Tabladetalle.Columns.Add("NOM_CLIENTE", GetType(String))
            Tabladetalle.Columns.Add("DIRECCION_ENTREGA", GetType(String))
            Tabladetalle.Columns.Add("UBIGEO", GetType(String))
            Tabladetalle.Columns.Add("PROVINCIA", GetType(String))
            Tabladetalle.Columns.Add("DEPARTAMENTO", GetType(String))
            Tabladetalle.Columns.Add("DISTRITO", GetType(String))
            Tabladetalle.Columns.Add("LIMA_PROV", GetType(String))
            Tabladetalle.Columns.Add("CANAL", GetType(String))
            Tabladetalle.Columns.Add("TRANSPORTE", GetType(String))
            Tabladetalle.Columns.Add("M3UN", GetType(Decimal))
            Tabladetalle.Columns.Add("IMPORTE", GetType(Decimal))

        Catch ex As Exception
            Throw ex
        End Try
        Return Tabladetalle
    End Function

    Public Function TablaDetallePedidoReport() As DataTable
        Dim Tabladetalle As DataTable
        Tabladetalle = New DataTable()
        Try
            Tabladetalle.Columns.Add("ITEM", GetType(String))
            Tabladetalle.Columns.Add("CODARTICULO", GetType(String))
            Tabladetalle.Columns.Add("ARTICULO", GetType(String))
            Tabladetalle.Columns.Add("LOTE", GetType(String))
            Tabladetalle.Columns.Add("CANTIDADPEDIDO", GetType(Integer))
            Tabladetalle.Columns.Add("CAJAS", GetType(Integer))
            Tabladetalle.Columns.Add("CAJASMASTER", GetType(Integer))

        Catch ex As Exception

        End Try
        Return Tabladetalle
    End Function

End Class
