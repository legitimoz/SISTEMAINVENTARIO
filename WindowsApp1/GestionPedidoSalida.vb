Imports System.Configuration
Imports Nordic.Bl.Be

Public Class GestionPedidoSalida
    Private dtcabecera, dtDetalle, dtDetalleM, dtalmacenessoft As New DataTable
    Public Estructura As New EstructuraTabla
    Public usr_id As Integer
    Public usr_usuario, F5_CCODAGE, F5_CNUMPED, FechaPedido, clienterazon, ruccliente, direccionCliente, codalmacen As String
    Private ObjAlmacen As New AlmacenL

    Private Sub PickConfirm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargaInicial()
    End Sub

    Private Sub CargaInicial()
        Try
            Me.Text = "Gestion Pedidos"
            FormatoTablaCabecera()
            FormatoTablaDetalle()
            ListarPedidosCabecera()
            ListarAlmacenSoftcom()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub FormatoTablaCabecera()

        dtcabecera.Clear()
        dtcabecera = Estructura.TablaCabeceraPedido
        Dg_Cabecera.DataSource = dtcabecera


        Dg_Cabecera.Columns("MARCAR").HeaderText = "Marcar"
        Dg_Cabecera.Columns("MARCAR").Width = 50
        Dg_Cabecera.Columns("MARCAR").ReadOnly = True

        Dg_Cabecera.Columns("Resta").Visible = False
        Dg_Cabecera.Columns("CodAlmacen").HeaderText = "Cod Almacen Origen"
        Dg_Cabecera.Columns("CodAlmacen").Width = 100
        Dg_Cabecera.Columns("CodAlmacen").ReadOnly = True

        Dg_Cabecera.Columns("Almacen").HeaderText = "Almacen Origen"
        Dg_Cabecera.Columns("Almacen").Width = 250
        Dg_Cabecera.Columns("Almacen").ReadOnly = True
        Dg_Cabecera.Columns("Almacen").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_Cabecera.Columns("F5_CCODAGE").Visible = False

        Dg_Cabecera.Columns("F5_CNUMPED").HeaderText = "Nº Pedido"
        Dg_Cabecera.Columns("F5_CNUMPED").Width = 150
        Dg_Cabecera.Columns("F5_CNUMPED").ReadOnly = True
        Dg_Cabecera.Columns("F5_CNUMPED").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter


        Dg_Cabecera.Columns("OrdenCompra").HeaderText = "Orden Compra"
        Dg_Cabecera.Columns("OrdenCompra").Width = 150
        Dg_Cabecera.Columns("OrdenCompra").ReadOnly = True
        Dg_Cabecera.Columns("OrdenCompra").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_Cabecera.Columns("Direccion").HeaderText = "Dirección Entrega"
        Dg_Cabecera.Columns("Direccion").Width = 100
        Dg_Cabecera.Columns("Direccion").ReadOnly = True
        Dg_Cabecera.Columns("Direccion").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_Cabecera.Columns("FECHA").HeaderText = "Fecha"
        Dg_Cabecera.Columns("FECHA").Width = 100
        Dg_Cabecera.Columns("FECHA").ReadOnly = True
        Dg_Cabecera.Columns("FECHA").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_Cabecera.Columns("F5_CVENDE").HeaderText = "Cod. Vendedor"
        Dg_Cabecera.Columns("F5_CVENDE").Width = 100
        Dg_Cabecera.Columns("F5_CVENDE").ReadOnly = True
        Dg_Cabecera.Columns("F5_CVENDE").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_Cabecera.Columns("CodCli").HeaderText = "Cod. Cliente"
        Dg_Cabecera.Columns("CodCli").Width = 100
        Dg_Cabecera.Columns("CodCli").ReadOnly = True
        Dg_Cabecera.Columns("CodCli").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_Cabecera.Columns("Cliente").HeaderText = "Cliente"
        Dg_Cabecera.Columns("Cliente").Width = 350
        Dg_Cabecera.Columns("Cliente").ReadOnly = True
        Dg_Cabecera.Columns("Cliente").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_Cabecera.Columns("Ruc").HeaderText = "Ruc Cliente"
        Dg_Cabecera.Columns("Ruc").Width = 100
        Dg_Cabecera.Columns("Ruc").ReadOnly = True
        Dg_Cabecera.Columns("Ruc").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

    End Sub

    Public Sub FormatoTablaDetalle()
        dtDetalle.Clear()
        dtDetalleM.Clear()
        dtDetalle = Estructura.TablaDetallePedidos
        dtDetalleM = Estructura.TablaDetallePedidos
        Dg_Detalle.DataSource = dtDetalle


        Dg_Detalle.Columns("SALIDA").HeaderText = "Salida"
        Dg_Detalle.Columns("SALIDA").Width = 70
        Dg_Detalle.Columns("SALIDA").ReadOnly = False

        Dg_Detalle.Columns("FECHA_VECIMIENTO").Visible = False

        Dg_Detalle.Columns("CODIGO").HeaderText = "Cod Articulo"
        Dg_Detalle.Columns("CODIGO").Width = 80
        Dg_Detalle.Columns("CODIGO").ReadOnly = True
        Dg_Detalle.Columns("CODIGO").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_Detalle.Columns("PRODUCTO").HeaderText = "Articulo"
        Dg_Detalle.Columns("PRODUCTO").Width = 300
        Dg_Detalle.Columns("PRODUCTO").ReadOnly = True
        Dg_Detalle.Columns("PRODUCTO").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_Detalle.Columns("UNIDAD").HeaderText = "Unidad"
        Dg_Detalle.Columns("UNIDAD").Width = 80
        Dg_Detalle.Columns("UNIDAD").ReadOnly = False

        Dg_Detalle.Columns("FACTORCAJA").HeaderText = "Factor Caja"
        Dg_Detalle.Columns("FACTORCAJA").Width = 80
        Dg_Detalle.Columns("FACTORCAJA").ReadOnly = True
        Dg_Detalle.Columns("FACTORCAJA").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_Detalle.Columns("FACTORCAJAMASTER").HeaderText = "Factor C. Master"
        Dg_Detalle.Columns("FACTORCAJAMASTER").Width = 80
        Dg_Detalle.Columns("FACTORCAJAMASTER").ReadOnly = True
        Dg_Detalle.Columns("FACTORCAJAMASTER").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_Detalle.Columns("SERIE").HeaderText = "Lote"
        Dg_Detalle.Columns("SERIE").Width = 80
        Dg_Detalle.Columns("SERIE").ReadOnly = True
        Dg_Detalle.Columns("SERIE").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_Detalle.Columns("CANTIDAD").HeaderText = "Cantidad"
        Dg_Detalle.Columns("CANTIDAD").Width = 80
        Dg_Detalle.Columns("CANTIDAD").ReadOnly = False

        Dg_Detalle.Columns("SALDO").HeaderText = "Saldo"
        Dg_Detalle.Columns("SALDO").Width = 80
        Dg_Detalle.Columns("SALDO").ReadOnly = False

        Dg_Detalle.Columns("CAJAS").HeaderText = "Cajas"
        Dg_Detalle.Columns("CAJAS").Width = 80
        Dg_Detalle.Columns("CAJAS").ReadOnly = False

        Dg_Detalle.Columns("CAJASMASTER").HeaderText = "Cajas Master"
        Dg_Detalle.Columns("CAJASMASTER").Width = 80
        Dg_Detalle.Columns("CAJASMASTER").ReadOnly = False

        Dg_Detalle.Columns("VOLUMEN").HeaderText = "Volumen"
        Dg_Detalle.Columns("VOLUMEN").Width = 70
        Dg_Detalle.Columns("VOLUMEN").ReadOnly = False

        Dg_Detalle.Columns("ANCHO").Visible = False
        Dg_Detalle.Columns("LARGO").Visible = False
        Dg_Detalle.Columns("ALTO").Visible = False

        Dim btn As New DataGridViewButtonColumn With {
            .Name = "Detalle",
            .DataPropertyName = "Detalle",
            .HeaderText = "Detalle Salida",
            .Text = "Ver",
            .UseColumnTextForButtonValue = True,
            .Width = 80
        }
        btn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Dg_Detalle.Columns.Add(btn)

    End Sub

    Public Sub ObtenerCabecera()
        Try
            If Dg_Cabecera.Rows.Count > 0 Then
                codalmacen = Dg_Cabecera.CurrentRow.Cells("CodAlmacen").EditedFormattedValue.ToString.Trim
                F5_CCODAGE = Dg_Cabecera.CurrentRow.Cells("F5_CCODAGE").EditedFormattedValue.ToString.Trim
                F5_CNUMPED = Dg_Cabecera.CurrentRow.Cells("F5_CNUMPED").EditedFormattedValue.ToString.Trim
                FechaPedido = Dg_Cabecera.CurrentRow.Cells("FECHA").EditedFormattedValue.ToString.Trim
                ruccliente = Dg_Cabecera.CurrentRow.Cells("Ruc").EditedFormattedValue.ToString
                clienterazon = Dg_Cabecera.CurrentRow.Cells("Cliente").EditedFormattedValue.ToString
                direccionCliente = Dg_Cabecera.CurrentRow.Cells("Direccion").EditedFormattedValue.ToString
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Dg_Cabecera_SelectionChanged(sender As Object, e As EventArgs) Handles Dg_Cabecera.SelectionChanged
        Try
            ObtenerCabecera()
            If F5_CCODAGE <> "" And F5_CNUMPED <> "" Then
                ListarPedidosDetalle()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function LlamarListarPedidosDET() As DataTable

        Dim dtretono As DataTable
        Try
            dtretono = ObjAlmacen.ListarPedidosDET(F5_CCODAGE, F5_CNUMPED).Copy
        Catch ex As Exception
            Throw ex
        End Try
        Return dtretono
    End Function

    Public Function LlamarListarPedidosDETM(F5_CCODAGE As String, F5_CNUMPED As String) As DataTable

        Dim dtretono As DataTable
        Try
            dtretono = ObjAlmacen.ListarPedidosDET(F5_CCODAGE, F5_CNUMPED).Copy
        Catch ex As Exception
            Throw ex
        End Try
        Return dtretono
    End Function

    Private Function ValidarDetalle() As Boolean
        Dim rp As Boolean = False

        Try
            For Each rowDetalle As DataRow In dtDetalle.Rows
                If rowDetalle.Item("SERIE") = "" Or rowDetalle.Item("SERIE") = "SIN/LOTE" Then
                    rp = True
                    Exit For
                End If
            Next
        Catch ex As Exception
            Throw ex
        End Try

        Return rp
    End Function

    Private Sub btn_imprimir_Click(sender As Object, e As EventArgs) Handles btn_imprimir.Click
        Dim F5_CCODAGEM, F5_CNUMPEDM, FechaPedidoM, direccionClienteM, rucclienteM, clienterazonM, nombreempresa, Direccion, RUC, codalmacenM As String
        Dim cajas As Decimal = 0, cajasm As Decimal = 0, saldo As Decimal = 0, totalvolumen As Decimal = 0
        nombreempresa = ConfigurationManager.AppSettings("Empresa").ToString.Trim
        RUC = ConfigurationManager.AppSettings("nombreAlmacen").ToString.Trim
        Direccion = ConfigurationManager.AppSettings("nombreSite").ToString.Trim
        Dim DtDetalleReporte As New DataTable
        DtDetalleReporte = Estructura.DetaleHojaPickingReport.Clone
        Dim logooperador As String = ""
        Dim color As String = "White"
        Try
            If Dg_Cabecera.Rows.Count > 0 Then
                For Each rowCab As DataGridViewRow In Dg_Cabecera.Rows
                    If rowCab.Cells("MARCAR").Value = True Then
                        codalmacenM = rowCab.Cells("CodAlmacen").EditedFormattedValue.ToString.Trim
                        F5_CCODAGEM = rowCab.Cells("F5_CCODAGE").EditedFormattedValue.ToString.Trim
                        F5_CNUMPEDM = rowCab.Cells("F5_CNUMPED").EditedFormattedValue.ToString.Trim
                        FechaPedidoM = rowCab.Cells("FECHA").EditedFormattedValue.ToString.Trim
                        direccionClienteM = rowCab.Cells("Direccion").EditedFormattedValue.ToString.Trim
                        rucclienteM = rowCab.Cells("Ruc").EditedFormattedValue.ToString.Trim
                        clienterazonM = rowCab.Cells("Cliente").EditedFormattedValue.ToString.Trim

                        If F5_CCODAGEM <> "" And F5_CNUMPEDM <> "" Then
                            ListaredidosMasivo(F5_CCODAGEM, F5_CNUMPEDM)
                        End If
                        If dtDetalleM.Rows.Count > 0 Then
                            DtDetalleReporte.Rows.Clear()
                            Dim RowDetalleReporte As DataRow
                            For Each rowDetalle As DataRow In dtDetalleM.Rows
                                RowDetalleReporte = DtDetalleReporte.NewRow
                                RowDetalleReporte.Item("CodArticulo") = rowDetalle.Item("CODIGO")
                                RowDetalleReporte.Item("Articulo") = rowDetalle.Item("PRODUCTO")
                                RowDetalleReporte.Item("Lote") = rowDetalle.Item("SERIE")
                                RowDetalleReporte.Item("CantidadSalida") = rowDetalle.Item("SALDO")
                                RowDetalleReporte.Item("Unidad") = rowDetalle.Item("UNIDAD")
                                RowDetalleReporte.Item("Vencimiento") = rowDetalle.Item("FECHA_VECIMIENTO")
                                If rowDetalle.Item("UNIDAD").ToString = "UND" Then
                                    If rowDetalle.Item("FACTORCAJA").ToString <> 0 And rowDetalle.Item("FACTORCAJAMASTER").ToString <> 0 Then
                                        cajas = (rowDetalle.Item("SALDO") / rowDetalle.Item("FACTORCAJA"))
                                        saldo = rowDetalle.Item("SALDO") Mod rowDetalle.Item("FACTORCAJA")
                                        cajasm = cajas / rowDetalle.Item("FACTORCAJAMASTER")
                                        cajasm = Math.Floor(cajasm)
                                        cajas = cajas Mod rowDetalle.Item("FACTORCAJAMASTER")
                                    End If
                                Else
                                    If rowDetalle.Item("UNIDAD").ToString = "CJA" Then
                                        saldo = 0
                                        cajas = rowDetalle.Item("SALDO")
                                        cajasm = cajas / rowDetalle.Item("FACTORCAJAMASTER")
                                        cajasm = Math.Floor(cajasm)
                                        cajas = cajas Mod rowDetalle.Item("FACTORCAJAMASTER")
                                    End If
                                End If
                                RowDetalleReporte.Item("CajasM") = cajasm
                                RowDetalleReporte.Item("CajasI") = cajas
                                RowDetalleReporte.Item("Saldo") = saldo
                                Dim posiciones As List(Of String)
                                posiciones = ObtenerPosiciones(rowDetalle.Item("CODIGO").ToString.Trim, rowDetalle.Item("SERIE").ToString.Trim, CType(rowDetalle.Item("SALDO"), Decimal))
                                If posiciones.Count > 0 Then
                                    RowDetalleReporte.Item("Posicion1") = posiciones.ElementAt(0)
                                    RowDetalleReporte.Item("Posicion2") = posiciones.ElementAt(1)
                                End If
                                totalvolumen = totalvolumen + rowDetalle.Item("VOLUMEN")
                                DtDetalleReporte.Rows.Add(RowDetalleReporte)
                            Next


                            Select Case nombreempresa
                                Case "NORDIC PHARMACEUTICAL COMPANY SAC"
                                    logooperador = "LogoNordic"
                                    color = "IndianRed"
                                Case "HEADMARK CORPORATION SAC"
                                    logooperador = "SendaLogo"
                                    color = "DarkOrange"

                            End Select

                            If DtDetalleReporte.Rows.Count > 0 Then
                                Dim reporte As New Demo
                                DtDetalleReporte.TableName = "DetalleHojaPicking"
                                reporte.ReportePicking("HojaPicking.rdlc", DtDetalleReporte, "", F5_CNUMPEDM, nombreempresa, RUC, Direccion, logooperador, color, FechaPedidoM, clienterazonM, rucclienteM, direccionClienteM, codalmacenM, DtDetalleReporte.Rows.Count, totalvolumen)
                            End If

                        End If
                    End If
                Next
            End If
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function LlamarListarPosicionesHojaPicking(codarticulo As String, lote As String, cantidad As Decimal) As DataTable

        Dim dtretono As DataTable
        Try
            dtretono = ObjAlmacen.ObtenerPosicionesHojaPicking(codarticulo, lote, cantidad).Copy
        Catch ex As Exception
            Throw ex
        End Try
        Return dtretono
    End Function

    Public Function ObtenerPosiciones(codarticulo As String, lote As String, cantidad As Decimal) As List(Of String)
        Dim dtposicion As New DataTable
        Dim rp As New List(Of String)
        Dim contador As Integer
        Dim cajas, cajasmaster As Decimal
        Try
            dtposicion = LlamarListarPosicionesHojaPicking(codarticulo, lote, cantidad)
            contador = 1
            If dtposicion.Rows.Count > 0 Then
                For Each rowpos As DataRow In dtposicion.Rows
                    If rp.Count = 3 Then
                        Exit For
                    End If
                    If rowpos.Item("FACTORCAJA") <> 0 Then
                        cajas = CType(rowpos.Item("Cantidad"), Integer) / rowpos.Item("FACTORCAJA")
                    Else
                        cajas = 0
                    End If
                    If rowpos.Item("FACTORCAJAMASTER") <> 0 And cajas <> 0 Then
                        cajasmaster = Math.Round(cajas / CType(rowpos.Item("FACTORCAJAMASTER"), Decimal), 2)
                    Else
                        cajasmaster = 0
                    End If
                    'rp.Add(rowpos.Item("Espacio").ToString.Trim + " | " + CType(rowpos.Item("Cantidad"), Integer).ToString + " UND" & vbCrLf +
                    '       " | " + Math.Round(cajas, 2).ToString + " CJ | " + Math.Round(cajasmaster, 2).ToString + " CJM")
                    rp.Add(rowpos.Item("Espacio").ToString.Trim)

                Next
            Else
                rp.Add("-")
                rp.Add("-")
                rp.Add("-")
            End If
            If rp.Count = 1 Then
                rp.Add("-")
                rp.Add("-")
            Else
                If rp.Count = 2 Then
                    rp.Add("-")
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
        Return rp
    End Function

    Public Function ValidarFechasbuscar() As Boolean
        Dim rp As Boolean = True
        ErrorProvider1.SetError(dt_hasta, "")
        Try
            If dt_hasta.Value < dt_desde.Value Then
                ErrorProvider1.SetError(dt_hasta, "Fecha hasta invalida")
                rp = False
            End If
        Catch ex As Exception

        End Try
        Return rp
    End Function
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            Buscar()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function LlamarListarAlmacenesSoft() As DataTable

        Dim dtretono As DataTable
        Try
            dtretono = ObjAlmacen.ListarAlmacenesSoftcom().Copy
        Catch ex As Exception
            Throw ex
        End Try
        Return dtretono
    End Function

    Public Sub ListarAlmacenSoftcom()
        Try
            'Dg_Detalle.Rows.Clear()
            Dim dtretorno As New DataTable
            dtretorno = LlamarListarAlmacenesSoft()

            If dtretorno.Rows.Count > 0 Then

                dtalmacenessoft.Rows.Clear()
                dtalmacenessoft = dtretorno.Clone

                Dim rowalma As DataRow
                rowalma = dtalmacenessoft.NewRow
                rowalma.Item("A1_CALMA") = "00"
                rowalma.Item("A1_CDESCRI") = "TODOS"
                dtalmacenessoft.Rows.Add(rowalma)

                For Each RowRetorno As DataRow In dtretorno.Rows
                    Dim rowcabecera As DataRow
                    rowcabecera = dtalmacenessoft.NewRow
                    rowcabecera.Item("A1_CALMA") = RowRetorno.Item("A1_CALMA").ToString.Trim
                    rowcabecera.Item("A1_CDESCRI") = RowRetorno.Item("A1_CDESCRI").ToString.Trim

                    dtalmacenessoft.Rows.Add(rowcabecera)
                Next
                combo_Almacen.DataSource = dtalmacenessoft
                combo_Almacen.DisplayMember = "A1_CDESCRI"
                combo_Almacen.ValueMember = "A1_CALMA"
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If dtcabecera.Rows.Count > 0 Then
                If dtDetalle.Rows.Count > 0 Then
                    ObtenerCabecera()
                    If ValidarDetalle() = False Then
                        If F5_CNUMPED <> "" Then
                            Dim reporte As New HojaPicking With {
                                .codpedido = F5_CNUMPED,
                                .codigoguia = "",
                                .codalmacen = codalmacen,
                                .DtDetallePedido = dtDetalle,
                                .fechapedido = FechaPedido,
                                .razoncliente = clienterazon,
                                .ruccliente = ruccliente,
                                .direccioncliente = direccionCliente
                            }
                            reporte.Show()
                        End If
                    Else
                        ErrorProvider1.SetError(btn_imprimir, "Pedido Tiene Articulos Sin Lote")
                    End If
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Dg_Cabecera_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dg_Cabecera.CellContentClick
        Try
            If e.RowIndex <> -1 Then
                If e.ColumnIndex = 0 Then
                    Dim row As DataGridViewRow = Dg_Cabecera.Rows(e.RowIndex)
                    row.Cells("MARCAR").Value = Not row.Cells("MARCAR").EditedFormattedValue
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Sub Buscar()
        Dim dtbusqueda As New DataTable
        Try
            If ValidarFechasbuscar() = True Then
                Dim stringfiltro As String = ""

                If combo_Almacen.SelectedIndex = Constantes.ValorEnteroInicial Then
                    stringfiltro = String.Format("FECHA >= #{0}# AND FECHA <= #{1}# AND F5_CNUMPED LIKE '%{2}%' ", dt_desde.Value.ToString("MM/dd/yyyy"), dt_hasta.Value.ToString("MM/dd/yyyy"), txt_numero.Text)
                End If
                If combo_Almacen.SelectedIndex <> Constantes.ValorEnteroInicial Then
                    stringfiltro = String.Format("FECHA >= #{0}# AND FECHA <= #{1}# AND F5_CNUMPED LIKE '%{2}%' AND Almacen = '{3}' ", dt_desde.Value.ToString("MM/dd/yyyy"), dt_hasta.Value.ToString("MM/dd/yyyy"), txt_numero.Text, combo_Almacen.Text)
                End If
                dtcabecera.DefaultView.RowFilter = stringfiltro
            End If
        Catch ex As Exception
            Throw ex
            MsgBox(Constantes.MensajeErrorServer, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub Dg_Detalle_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dg_Detalle.CellContentClick
        If e.RowIndex <> -1 Then
            If e.ColumnIndex = 1 Then
                Dim row As DataGridViewRow = Dg_Detalle.Rows(e.RowIndex)
                row.Cells("SALIDA").Value = Not row.Cells("SALIDA").EditedFormattedValue
                Dim valorcheck = row.Cells("SALIDA").Value
                If valorcheck Then
                    If row.Cells("SERIE").EditedFormattedValue.ToString.Trim <> "" And row.Cells("SERIE").EditedFormattedValue.ToString.Trim <> "SIN/LOTE" Then
                        If CType(row.Cells("SALDO").EditedFormattedValue.ToString, Decimal) > 0 Then
                            ObtenerCabecera()
                            If F5_CCODAGE <> "" And F5_CNUMPED <> "" Then
                                Dim RegistrarSalidaForm As New EditarSalidaAlmacen
                                RegistrarSalidaForm.Lote = row.Cells("SERIE").EditedFormattedValue.ToString.Trim
                                RegistrarSalidaForm.articulo = row.Cells("PRODUCTO").EditedFormattedValue.ToString.Trim
                                RegistrarSalidaForm.CodArticulo = row.Cells("CODIGO").EditedFormattedValue.ToString.Trim
                                RegistrarSalidaForm.cantidad = CType(row.Cells("SALDO").EditedFormattedValue.ToString, Integer)
                                RegistrarSalidaForm.volumen = CType(row.Cells("VOLUMEN").EditedFormattedValue.ToString, Decimal)
                                RegistrarSalidaForm.alto = CType(row.Cells("ALTO").EditedFormattedValue.ToString, Decimal)
                                RegistrarSalidaForm.ancho = CType(row.Cells("ANCHO").EditedFormattedValue.ToString, Decimal)
                                RegistrarSalidaForm.largo = CType(row.Cells("LARGO").EditedFormattedValue.ToString, Decimal)
                                RegistrarSalidaForm.unidades = CType(row.Cells("SALDO").EditedFormattedValue.ToString, Decimal)
                                RegistrarSalidaForm.total = CType(row.Cells("CANTIDAD").EditedFormattedValue.ToString, Decimal)
                                RegistrarSalidaForm.cajas = CType(row.Cells("CAJAS").EditedFormattedValue.ToString, Decimal)
                                RegistrarSalidaForm.cajasmaster = CType(row.Cells("CAJASMASTER").EditedFormattedValue.ToString, Decimal)
                                RegistrarSalidaForm.unidad = row.Cells("UNIDAD").EditedFormattedValue.ToString.Trim
                                RegistrarSalidaForm.factorcaja = CType(row.Cells("FACTORCAJA").EditedFormattedValue.ToString, Decimal)
                                RegistrarSalidaForm.factormaster = CType(row.Cells("FACTORCAJAMASTER").EditedFormattedValue.ToString, Decimal)
                                RegistrarSalidaForm.F5_CCODAGE = F5_CCODAGE
                                RegistrarSalidaForm.F5_CNUMPED = F5_CNUMPED
                                RegistrarSalidaForm.TIPDOC = ""
                                RegistrarSalidaForm.iduser = usr_id
                                RegistrarSalidaForm.ShowDialog()
                                If RegistrarSalidaForm.grabado = True Then
                                    If RegistrarSalidaForm.dtreportePicConfirm.Rows.Count > 0 Then
                                        Try
                                            If F5_CNUMPED <> "" Then
                                                Dim reporte As New HojaPickConfirm With {
                                                        .codigopedido = RegistrarSalidaForm.F5_CNUMPED,
                                                        .DtDetallePedido = RegistrarSalidaForm.dtreportePicConfirm,
                                                        .fechapedido = FechaPedido
                                                    }
                                                reporte.Show()
                                            End If
                                        Catch ex As Exception
                                            Throw ex
                                        End Try
                                    End If
                                    ListarPedidosCabecera()
                                Else
                                    row.Cells("SALIDA").Value = False
                                End If
                            End If
                        Else
                            MsgBox("El Articulo Saliò en su totalidad", MsgBoxStyle.Exclamation)
                            row.Cells("SALIDA").Value = False
                        End If
                    Else
                        MsgBox("El Articulo no tiene un Lote", MsgBoxStyle.Exclamation)
                        row.Cells("SALIDA").Value = False
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click

    End Sub

    Private Sub txt_numero_TextChanged(sender As Object, e As EventArgs) Handles txt_numero.TextChanged
        Try
            Buscar()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub combo_Almacen_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles combo_Almacen.SelectionChangeCommitted
        Try
            Buscar()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ListarPedidosDetalle()
        Try
            Dim dtretorno As New DataTable
            dtretorno = LlamarListarPedidosDET()
            If dtretorno.Rows.Count > 0 Then
                dtDetalle.Rows.Clear()
                For Each RowRetorno As DataRow In dtretorno.Rows
                    Dim rowDetalle As DataRow
                    rowDetalle = dtDetalle.NewRow
                    rowDetalle.Item("CODIGO") = RowRetorno.Item("CODIGO").ToString.Trim
                    rowDetalle.Item("PRODUCTO") = RowRetorno.Item("PRODUCTO").ToString.Trim
                    rowDetalle.Item("UNIDAD") = RowRetorno.Item("UNIDAD").ToString.Trim
                    rowDetalle.Item("FACTORCAJA") = RowRetorno.Item("FACTORCAJA").ToString.Trim

                    If RowRetorno.Item("FACTORCAJAMASTER").ToString.Trim <> "" Then
                        rowDetalle.Item("FACTORCAJAMASTER") = CType(RowRetorno.Item("FACTORCAJAMASTER").ToString.Trim, Decimal)
                    Else
                        rowDetalle.Item("FACTORCAJAMASTER") = 0
                    End If
                    rowDetalle.Item("SERIE") = RowRetorno.Item("SERIE").ToString.Trim
                    rowDetalle.Item("CANTIDAD") = RowRetorno.Item("CANTIDAD")
                    rowDetalle.Item("SALDO") = RowRetorno.Item("SALDO")

                    If rowDetalle.Item("UNIDAD").ToString.Trim = "UND" Then
                        If rowDetalle.Item("FACTORCAJA") <> 0 Then
                            rowDetalle.Item("CAJAS") = rowDetalle.Item("SALDO").ToString / rowDetalle.Item("FACTORCAJA")
                        Else
                            rowDetalle.Item("CAJAS") = 0
                        End If
                        If rowDetalle.Item("FACTORCAJAMASTER") <> 0 And rowDetalle.Item("CAJAS") <> 0 Then
                            rowDetalle.Item("CAJASMASTER") = Math.Round(CType(rowDetalle.Item("CAJAS").ToString, Decimal) / CType(rowDetalle.Item("FACTORCAJAMASTER"), Decimal), 2)
                        Else
                            rowDetalle.Item("CAJASMASTER") = 0
                        End If
                    End If

                    If rowDetalle.Item("UNIDAD").ToString.Trim = "CJA" Then
                        rowDetalle.Item("CAJAS") = RowRetorno.Item("SALDO")
                        If rowDetalle.Item("FACTORCAJAMASTER") <> 0 And rowDetalle.Item("CAJAS") <> 0 Then
                            rowDetalle.Item("CAJASMASTER") = Math.Round(CType(rowDetalle.Item("CAJAS").ToString, Decimal) / CType(rowDetalle.Item("FACTORCAJAMASTER"), Decimal), 2)
                        Else
                            rowDetalle.Item("CAJASMASTER") = 0
                        End If
                    End If
                    rowDetalle.Item("ALTO") = RowRetorno.Item("ALTO")
                    rowDetalle.Item("LARGO") = RowRetorno.Item("LARGO")
                    rowDetalle.Item("ANCHO") = RowRetorno.Item("ANCHO")
                    rowDetalle.Item("FECHA_VECIMIENTO") = RowRetorno.Item("FECHA_VECIMIENTO")


                    If CType(rowDetalle.Item("ALTO").ToString, Decimal) <> 0 And CType(rowDetalle.Item("LARGO").ToString, Decimal) <> 0 And CType(rowDetalle.Item("ANCHO").ToString, Decimal) <> 0 And rowDetalle.Item("FACTORCAJA") <> 0 And rowDetalle.Item("FACTORCAJAMASTER") <> 0 Then
                        Dim volumencajamaster, Multiplicacion As Decimal
                        volumencajamaster = CType(rowDetalle.Item("ALTO").ToString, Decimal) * CType(rowDetalle.Item("LARGO").ToString, Decimal) * CType(rowDetalle.Item("ANCHO").ToString, Decimal)
                        Multiplicacion = (CType(rowDetalle.Item("FACTORCAJA"), Decimal) * CType(rowDetalle.Item("FACTORCAJAMASTER"), Decimal))
                        rowDetalle.Item("VOLUMEN") = (volumencajamaster / Multiplicacion) * CType(rowDetalle.Item("SALDO"), Decimal)
                    Else
                        rowDetalle.Item("VOLUMEN") = 0
                    End If
                    rowDetalle.Item("SALIDA") = False
                    dtDetalle.Rows.Add(rowDetalle)
                Next
                Dg_Detalle.DataSource = dtDetalle
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ListaredidosMasivo(F5_CCODAGE As String, F5_CNUMPED As String)
        Try
            Dim dtretorno As New DataTable
            dtretorno = LlamarListarPedidosDET()
            If dtretorno.Rows.Count > 0 Then
                dtDetalleM.Rows.Clear()
                For Each RowRetorno As DataRow In dtretorno.Rows
                    Dim rowDetalle As DataRow
                    rowDetalle = dtDetalleM.NewRow
                    rowDetalle.Item("CODIGO") = RowRetorno.Item("CODIGO").ToString.Trim
                    rowDetalle.Item("PRODUCTO") = RowRetorno.Item("PRODUCTO").ToString.Trim
                    rowDetalle.Item("UNIDAD") = RowRetorno.Item("UNIDAD").ToString.Trim
                    rowDetalle.Item("FACTORCAJA") = RowRetorno.Item("FACTORCAJA").ToString.Trim

                    If RowRetorno.Item("FACTORCAJAMASTER").ToString.Trim <> "" Then
                        rowDetalle.Item("FACTORCAJAMASTER") = CType(RowRetorno.Item("FACTORCAJAMASTER").ToString.Trim, Decimal)
                    Else
                        rowDetalle.Item("FACTORCAJAMASTER") = 0
                    End If
                    rowDetalle.Item("SERIE") = RowRetorno.Item("SERIE").ToString.Trim
                    rowDetalle.Item("CANTIDAD") = RowRetorno.Item("CANTIDAD")
                    rowDetalle.Item("SALDO") = RowRetorno.Item("SALDO")

                    If rowDetalle.Item("UNIDAD").ToString.Trim = "UND" Then
                        If rowDetalle.Item("FACTORCAJA") <> 0 Then
                            rowDetalle.Item("CAJAS") = rowDetalle.Item("SALDO").ToString / rowDetalle.Item("FACTORCAJA")
                        Else
                            rowDetalle.Item("CAJAS") = 0
                        End If
                        If rowDetalle.Item("FACTORCAJAMASTER") <> 0 And rowDetalle.Item("CAJAS") <> 0 Then
                            rowDetalle.Item("CAJASMASTER") = Math.Round(CType(rowDetalle.Item("CAJAS").ToString, Decimal) / CType(rowDetalle.Item("FACTORCAJAMASTER"), Decimal), 2)
                        Else
                            rowDetalle.Item("CAJASMASTER") = 0
                        End If
                    End If

                    If rowDetalle.Item("UNIDAD").ToString.Trim = "CJA" Then
                        rowDetalle.Item("CAJAS") = RowRetorno.Item("SALDO")
                        If rowDetalle.Item("FACTORCAJAMASTER") <> 0 And rowDetalle.Item("CAJAS") <> 0 Then
                            rowDetalle.Item("CAJASMASTER") = Math.Round(CType(rowDetalle.Item("CAJAS").ToString, Decimal) / CType(rowDetalle.Item("FACTORCAJAMASTER"), Decimal), 2)
                        Else
                            rowDetalle.Item("CAJASMASTER") = 0
                        End If
                    End If
                    rowDetalle.Item("ALTO") = RowRetorno.Item("ALTO")
                    rowDetalle.Item("LARGO") = RowRetorno.Item("LARGO")
                    rowDetalle.Item("ANCHO") = RowRetorno.Item("ANCHO")
                    rowDetalle.Item("FECHA_VECIMIENTO") = RowRetorno.Item("FECHA_VECIMIENTO")


                    If CType(rowDetalle.Item("ALTO").ToString, Decimal) <> 0 And CType(rowDetalle.Item("LARGO").ToString, Decimal) <> 0 And CType(rowDetalle.Item("ANCHO").ToString, Decimal) <> 0 And rowDetalle.Item("FACTORCAJA") <> 0 And rowDetalle.Item("FACTORCAJAMASTER") <> 0 Then
                        Dim volumencajamaster, Multiplicacion As Decimal
                        volumencajamaster = CType(rowDetalle.Item("ALTO").ToString, Decimal) * CType(rowDetalle.Item("LARGO").ToString, Decimal) * CType(rowDetalle.Item("ANCHO").ToString, Decimal)
                        Multiplicacion = (CType(rowDetalle.Item("FACTORCAJA"), Decimal) * CType(rowDetalle.Item("FACTORCAJAMASTER"), Decimal))
                        rowDetalle.Item("VOLUMEN") = (volumencajamaster / Multiplicacion) * CType(rowDetalle.Item("SALDO"), Decimal)
                    Else
                        rowDetalle.Item("VOLUMEN") = 0
                    End If
                    rowDetalle.Item("SALIDA") = False
                    dtDetalleM.Rows.Add(rowDetalle)
                Next
                Dg_Detalle.DataSource = dtDetalle
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function LlamarListarPedidosCab() As DataTable

        Dim dtretono As DataTable
        Try
            dtretono = ObjAlmacen.ListarPedidosCAB().Copy
        Catch ex As Exception
            Throw ex
        End Try
        Return dtretono
    End Function

    Public Sub ListarPedidosCabecera()
        Try
            Dim dtretorno As New DataTable
            dtretorno = LlamarListarPedidosCab()
            If dtretorno.Rows.Count > 0 Then
                dtcabecera.Rows.Clear()
                For Each RowRetorno As DataRow In dtretorno.Rows
                    If RowRetorno.Item("Resta") <> 0 Then
                        Dim rowcabecera As DataRow
                        rowcabecera = dtcabecera.NewRow
                        rowcabecera.Item("MARCAR") = False
                        rowcabecera.Item("CodAlmacen") = RowRetorno.Item("CodAlmacen").ToString.Trim
                        rowcabecera.Item("Almacen") = RowRetorno.Item("Almacen").ToString.Trim
                        rowcabecera.Item("F5_CCODAGE") = RowRetorno.Item("F5_CCODAGE").ToString.Trim
                        rowcabecera.Item("F5_CNUMPED") = RowRetorno.Item("F5_CNUMPED").ToString.Trim
                        rowcabecera.Item("FECHA") = RowRetorno.Item("FECHA").ToString.Trim
                        rowcabecera.Item("F5_CVENDE") = RowRetorno.Item("F5_CVENDE").ToString.Trim
                        rowcabecera.Item("CodCli") = RowRetorno.Item("CodCli").ToString.Trim
                        rowcabecera.Item("Cliente") = RowRetorno.Item("Cliente").ToString.Trim
                        rowcabecera.Item("Direccion") = RowRetorno.Item("Direccion").ToString.Trim
                        rowcabecera.Item("Ruc") = RowRetorno.Item("Ruc").ToString.Trim
                        rowcabecera.Item("OrdenCompra") = RowRetorno.Item("OrdenCompra").ToString.Trim
                        dtcabecera.Rows.Add(rowcabecera)
                    End If
                Next
                Dg_Cabecera.DataSource = dtcabecera
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class