Imports Nordic.Bl.Be

Public Class GestionPartesEntrada

    Private ObjAlmacen As New AlmacenL
    Private dtcabecera, dtDetalle, dtalmacenessoft As New DataTable
    Public Estructura As New EstructuraTabla
    Public idRack As Integer = 0
    Public codalmacen, coddoc, tipdoc, fecha, tipomovimiento, nombreSite, nombrealmacen As String
    Public X, Y, Numeracion, idalmacen, volumen, userid, idsite As Integer
    Private Sub IngresoAlmacen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargaInicial()
    End Sub

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

    Public Sub FormatoTablaCabecera()
        dtcabecera.Clear()
        dtcabecera = Estructura.TablaCabeceraParteEntrda
        Dg_Cabecera.DataSource = dtcabecera
        Dg_Cabecera.Columns("CODALMACEN_ORIGEN").HeaderText = "Cod Almacen Origen"
        Dg_Cabecera.Columns("CODALMACEN_ORIGEN").Width = 75
        Dg_Cabecera.Columns("CODALMACEN_ORIGEN").ReadOnly = True
        'Dg_Cabecera.Columns("CODALMACEN_ORIGEN").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Dg_Cabecera.Columns("Resta").Visible = False
        Dg_Cabecera.Columns("ALAMACEN_ORIGEN").HeaderText = "Almacen Origen"
        Dg_Cabecera.Columns("ALAMACEN_ORIGEN").Width = 100
        Dg_Cabecera.Columns("ALAMACEN_ORIGEN").ReadOnly = True
        ''Dg_Cabecera.Columns("ALAMACEN_ORIGEN").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_Cabecera.Columns("TIP_DOC").HeaderText = "Tipo Documento"
        Dg_Cabecera.Columns("TIP_DOC").Width = 80
        Dg_Cabecera.Columns("TIP_DOC").ReadOnly = True
        Dg_Cabecera.Columns("TIP_DOC").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_Cabecera.Columns("NDOCUMENTO").HeaderText = "N° Documento"
        Dg_Cabecera.Columns("NDOCUMENTO").Width = 100
        Dg_Cabecera.Columns("NDOCUMENTO").ReadOnly = True
        Dg_Cabecera.Columns("NDOCUMENTO").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_Cabecera.Columns("MES").HeaderText = "Mes"
        Dg_Cabecera.Columns("MES").Width = 80
        Dg_Cabecera.Columns("MES").ReadOnly = True
        Dg_Cabecera.Columns("MES").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_Cabecera.Columns("FECHA").HeaderText = "Fecha"
        Dg_Cabecera.Columns("FECHA").Width = 80
        Dg_Cabecera.Columns("FECHA").ReadOnly = True
        Dg_Cabecera.Columns("FECHA").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_Cabecera.Columns("TIPO_MOV").HeaderText = "Tipo Movimiento"
        Dg_Cabecera.Columns("TIPO_MOV").Width = 70
        Dg_Cabecera.Columns("TIPO_MOV").ReadOnly = True
        Dg_Cabecera.Columns("TIPO_MOV").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_Cabecera.Columns("COD_MOV").HeaderText = "Cod Movimiento"
        Dg_Cabecera.Columns("COD_MOV").Width = 70
        Dg_Cabecera.Columns("COD_MOV").ReadOnly = True
        Dg_Cabecera.Columns("COD_MOV").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_Cabecera.Columns("MOVIMIENTO").HeaderText = "Movimiento"
        Dg_Cabecera.Columns("MOVIMIENTO").Width = 130
        Dg_Cabecera.Columns("MOVIMIENTO").ReadOnly = True
        Dg_Cabecera.Columns("MOVIMIENTO").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_Cabecera.Columns("NDOC_REFERENCIA").HeaderText = "Doc. Referencia"
        Dg_Cabecera.Columns("NDOC_REFERENCIA").Width = 130
        Dg_Cabecera.Columns("NDOC_REFERENCIA").ReadOnly = True
        Dg_Cabecera.Columns("NDOC_REFERENCIA").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_Cabecera.Columns("NORDEN_COMPRA").HeaderText = "N° Orden Compra"
        Dg_Cabecera.Columns("NORDEN_COMPRA").Width = 100
        Dg_Cabecera.Columns("NORDEN_COMPRA").ReadOnly = True
        Dg_Cabecera.Columns("NORDEN_COMPRA").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_Cabecera.Columns("CODPROV").HeaderText = "Cod Provedor"
        Dg_Cabecera.Columns("CODPROV").Width = 100
        Dg_Cabecera.Columns("CODPROV").ReadOnly = True
        Dg_Cabecera.Columns("CODPROV").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_Cabecera.Columns("PROVEEDOR").HeaderText = "Proveedor"
        Dg_Cabecera.Columns("PROVEEDOR").Width = 160
        Dg_Cabecera.Columns("PROVEEDOR").ReadOnly = True
        Dg_Cabecera.Columns("PROVEEDOR").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_Cabecera.Columns("GLOSA").HeaderText = "Glosa"
        Dg_Cabecera.Columns("GLOSA").Width = 160
        Dg_Cabecera.Columns("GLOSA").ReadOnly = True
        Dg_Cabecera.Columns("GLOSA").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

    End Sub

    Public Sub FormatoTablaDetalle()

        dtDetalle.Clear()

        dtDetalle = Estructura.TablaDetalleParteEntrda

        Dg_Detalle.DataSource = dtDetalle

        Dg_Detalle.Columns("CODIGO").HeaderText = "Cod Articulo"
        Dg_Detalle.Columns("CODIGO").Width = 80
        Dg_Detalle.Columns("CODIGO").ReadOnly = True
        Dg_Detalle.Columns("CODIGO").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_Detalle.Columns("PRODUCTO").HeaderText = "Articulo"
        Dg_Detalle.Columns("PRODUCTO").Width = 250
        Dg_Detalle.Columns("PRODUCTO").ReadOnly = True
        Dg_Detalle.Columns("PRODUCTO").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_Detalle.Columns("FACTORCAJA").HeaderText = "Factor Caja"
        Dg_Detalle.Columns("FACTORCAJA").Width = 70
        Dg_Detalle.Columns("FACTORCAJA").ReadOnly = True
        Dg_Detalle.Columns("FACTORCAJA").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_Detalle.Columns("FACTORCAJAMASTER").HeaderText = "Factor C. Master"
        Dg_Detalle.Columns("FACTORCAJAMASTER").Width = 70
        Dg_Detalle.Columns("FACTORCAJAMASTER").ReadOnly = True
        Dg_Detalle.Columns("FACTORCAJAMASTER").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_Detalle.Columns("SERIE").HeaderText = "Lote"
        Dg_Detalle.Columns("SERIE").Width = 70
        Dg_Detalle.Columns("SERIE").ReadOnly = True
        Dg_Detalle.Columns("SERIE").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_Detalle.Columns("FECHA_VECIMIENTO").HeaderText = "Vencimiento Lote"
        Dg_Detalle.Columns("FECHA_VECIMIENTO").Width = 70
        Dg_Detalle.Columns("FECHA_VECIMIENTO").ReadOnly = False

        Dg_Detalle.Columns("CANTIDAD").HeaderText = "Cantidad"
        Dg_Detalle.Columns("CANTIDAD").Width = 65
        Dg_Detalle.Columns("CANTIDAD").ReadOnly = False

        Dg_Detalle.Columns("SALDO").HeaderText = "Saldo"
        Dg_Detalle.Columns("SALDO").Width = 65
        Dg_Detalle.Columns("SALDO").ReadOnly = False

        Dg_Detalle.Columns("CAJAS").HeaderText = "Cajas"
        Dg_Detalle.Columns("CAJAS").Width = 65
        Dg_Detalle.Columns("CAJAS").ReadOnly = False

        Dg_Detalle.Columns("CAJASMASTER").HeaderText = "Cajas Master"
        Dg_Detalle.Columns("CAJASMASTER").Width = 65
        Dg_Detalle.Columns("CAJASMASTER").ReadOnly = False

        Dg_Detalle.Columns("VOLUMEN").HeaderText = "Volumen"
        Dg_Detalle.Columns("VOLUMEN").Width = 70
        Dg_Detalle.Columns("VOLUMEN").ReadOnly = False

        Dg_Detalle.Columns("ANCHO").Visible = False
        Dg_Detalle.Columns("LARGO").Visible = False
        Dg_Detalle.Columns("ALTO").Visible = False
        Dg_Detalle.Columns("CODALMACEN_DESTINO").Visible = False
        Dg_Detalle.Columns("ALMACEN_DESTINO").Visible = False

        Dg_Detalle.Columns("CANAL").HeaderText = "Canal"
        Dg_Detalle.Columns("CANAL").Width = 75
        Dg_Detalle.Columns("CANAL").ReadOnly = False

        Dg_Detalle.Columns("RUC").HeaderText = "Ruc"
        Dg_Detalle.Columns("RUC").Width = 75
        Dg_Detalle.Columns("RUC").ReadOnly = False

        Dg_Detalle.Columns("CLIENTE").HeaderText = "Cliente"
        Dg_Detalle.Columns("CLIENTE").Width = 75
        Dg_Detalle.Columns("CLIENTE").ReadOnly = False

        Dg_Detalle.Columns("UNIDAD").HeaderText = "Unidad"
        Dg_Detalle.Columns("UNIDAD").Width = 70
        Dg_Detalle.Columns("UNIDAD").ReadOnly = False

        Dg_Detalle.Columns("DEPARTAMENTO").Visible = False
        Dg_Detalle.Columns("PROVINCIA").Visible = False
        Dg_Detalle.Columns("DISTRITO").Visible = False
        Dg_Detalle.Columns("TRANSPORTES").Visible = False

        Dg_Detalle.Columns("UBICAR").HeaderText = "Ubicar"
        Dg_Detalle.Columns("UBICAR").Width = 40
        Dg_Detalle.Columns("UBICAR").ReadOnly = False

        Dim btn As New DataGridViewButtonColumn With {
            .Name = "Posicion",
            .DataPropertyName = "Posicion",
            .HeaderText = "Posiciones",
            .Text = "Ver",
            .UseColumnTextForButtonValue = True,
            .Width = 70
        }
        btn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Dg_Detalle.Columns.Add(btn)

    End Sub

    Private Sub CargaInicial()
        Try
            FormatoTablaCabecera()
            FormatoTablaDetalle()
            ListarPartesEntradaCabecera()
            ListarAlmacenSoftcom()
        Catch ex As Exception

        End Try
    End Sub
    Public Sub ObtenerParteEntrada()
        Try
            If Dg_Cabecera.Rows.Count > 0 Then
                codalmacen = Dg_Cabecera.CurrentRow.Cells("CODALMACEN_ORIGEN").EditedFormattedValue.ToString.Trim
                tipdoc = Dg_Cabecera.CurrentRow.Cells("TIP_DOC").EditedFormattedValue.ToString.Trim
                coddoc = Dg_Cabecera.CurrentRow.Cells("NDOCUMENTO").EditedFormattedValue.ToString.Trim
                fecha = Dg_Cabecera.CurrentRow.Cells("FECHA").EditedFormattedValue.ToString
                tipomovimiento = Dg_Cabecera.CurrentRow.Cells("TIPO_MOV").EditedFormattedValue.ToString
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Sub ObtenerDetalle()
        Try
            If Dg_Detalle.Rows.Count > 0 Then
                volumen = Dg_Detalle.CurrentRow.Cells("VOLUMEN").EditedFormattedValue.ToString.Trim
            End If
        Catch ex As Exception

        End Try
    End Sub
    Public Function LlamarListarPartesEntradaCab() As DataTable

        Dim dtretono As DataTable
        Dim fechadesde, fechahasta, mes, dia As String

        mes = dt_desde.Value.Month.ToString
        If mes.Length = 1 Then
            mes = "0" + mes
        End If
        dia = dt_desde.Value.Day.ToString
        If dia.Length = 1 Then
            dia = "0" + dia
        End If

        fechadesde = dt_desde.Value.Year.ToString + "/" + mes + "/" + dia


        mes = dt_hasta.Value.Month.ToString
        If mes.Length = 1 Then
            mes = "0" + mes
        End If
        dia = dt_hasta.Value.Day.ToString
        If dia.Length = 1 Then
            dia = "0" + dia
        End If

        fechahasta = dt_hasta.Value.Year.ToString + "/" + mes + "/" + dia
        Try
            dtretono = ObjAlmacen.ListarParteEntradaCAB(fechadesde, fechahasta).Copy
        Catch ex As Exception
            Throw ex
        End Try
        Return dtretono
    End Function

    Public Function LlamarListarAlmacenesSoft() As DataTable

        Dim dtretono As DataTable
        Try
            dtretono = ObjAlmacen.ListarAlmacenesSoftcom().Copy
        Catch ex As Exception
            Throw ex
        End Try
        Return dtretono
    End Function

    Private Sub Dg_Cabecera_CellClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles Dg_Cabecera.CellClick
        Try
            ObtenerParteEntrada()
            If codalmacen <> "" Then
                ListarPartesEntradaDetalle()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Dg_Cabecera_SelectionChanged(sender As Object, e As EventArgs) Handles Dg_Cabecera.SelectionChanged
        ObtenerParteEntrada()
        If codalmacen <> "" And coddoc <> "" Then
            ListarPartesEntradaDetalle()
        End If
    End Sub

    Private Sub Dg_Detalle_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dg_Detalle.CellContentClick
        If e.RowIndex <> -1 Then
            If e.ColumnIndex = 0 Then
                ObtenerDetalle()
                Dim row As DataGridViewRow = Dg_Detalle.Rows(e.RowIndex)
                row.Cells("UBICAR").Value = Not row.Cells("UBICAR").EditedFormattedValue
                Dim valorcheck = row.Cells("UBICAR").Value
                If valorcheck Then
                    If row.Cells("SERIE").EditedFormattedValue.ToString.Trim <> "" And row.Cells("SERIE").EditedFormattedValue.ToString.Trim <> "SIN/LOTE" Then
                        If CType(row.Cells("SALDO").EditedFormattedValue.ToString, Decimal) > 0 Then
                            Dim addposicion As New GestionPosiciones With {
                        .idRack = idRack,
                        .X = X,
                        .Y = Y,
                        .idsite = idsite,
                        .NombreSite = nombreSite,
                        .Numeracion = Numeracion,
                        .Accion = "INGRESO",
                        .nombrealmacen = nombrealmacen,
                        .idalmacen = idalmacen,
                        .volumen = CType(row.Cells("VOLUMEN").EditedFormattedValue.ToString, Decimal),
                        .alto = CType(row.Cells("ALTO").EditedFormattedValue.ToString, Decimal),
                        .ancho = CType(row.Cells("ANCHO").EditedFormattedValue.ToString, Decimal),
                        .largo = CType(row.Cells("LARGO").EditedFormattedValue.ToString, Decimal),
                        .unidades = CType(row.Cells("SALDO").EditedFormattedValue.ToString, Decimal),
                        .total = CType(row.Cells("CANTIDAD").EditedFormattedValue.ToString, Decimal),
                        .cajas = CType(row.Cells("CAJAS").EditedFormattedValue.ToString, Decimal),
                        .cajasmaster = CType(row.Cells("CAJASMASTER").EditedFormattedValue.ToString, Decimal),
                        .unidad = row.Cells("UNIDAD").EditedFormattedValue.ToString.Trim,
                        .factorcaja = CType(row.Cells("FACTORCAJA").EditedFormattedValue.ToString, Decimal),
                        .factormaster = CType(row.Cells("FACTORCAJAMASTER").EditedFormattedValue.ToString, Decimal),
                        .Text = "Ingreso Almacen - Posiciones",
                        .userid = userid,
                        .codalmacen = codalmacen,
                        .codarticulo = row.Cells("CODIGO").EditedFormattedValue.ToString,
                        .NombreArticulo = row.Cells("PRODUCTO").EditedFormattedValue.ToString,
                        .vencimiento = row.Cells("FECHA_VECIMIENTO").EditedFormattedValue.ToString,
                        .coddoc = coddoc,
                        .tipdoc = tipdoc,
                        .Lote = row.Cells("SERIE").EditedFormattedValue.ToString
                        }
                            addposicion.ShowDialog()
                            If addposicion.grabado = True Then
                                ListarPartesEntradaCabecera()
                            Else
                                row.Cells("UBICAR").Value = False
                            End If
                        Else
                            MsgBox("El Articulo ya se ingresò en su totalidad", MsgBoxStyle.Exclamation)
                            row.Cells("UBICAR").Value = False
                        End If
                    Else
                        MsgBox("El Articulo no tiene un Lote", MsgBoxStyle.Exclamation)
                        row.Cells("UBICAR").Value = False
                    End If
                Else
                    row.Cells("UBICAR").Value = False
                End If
            End If

            If e.ColumnIndex = 26 Then
                Dim row As DataGridViewRow = Dg_Detalle.Rows(e.RowIndex)
                Dim Item As String = ""
                Dim Lote As String = ""
                Item = row.Cells("CODIGO").EditedFormattedValue.ToString
                Lote = row.Cells("SERIE").EditedFormattedValue.ToString
                Dim formDetallePos As New DetallePosiciones
                formDetallePos.txt_item.Text = Item
                formDetallePos.txt_lote.Text = row.Cells("SERIE").EditedFormattedValue.ToString

                formDetallePos.codalmacen = codalmacen
                formDetallePos.codarticulo = row.Cells("CODIGO").EditedFormattedValue.ToString
                formDetallePos.lote = row.Cells("SERIE").EditedFormattedValue.ToString
                formDetallePos.tipodoc = tipdoc
                formDetallePos.numdoc = coddoc
                formDetallePos.Show()
            End If
            Dg_Detalle.Refresh()
        End If
    End Sub

    Private Sub txt_numero_TextChanged(sender As Object, e As EventArgs) Handles txt_numero.TextChanged
        Try
            Buscar()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub combo_Almacen_SelectedValueChanged(sender As Object, e As EventArgs) Handles combo_Almacen.SelectedValueChanged

    End Sub

    Private Sub combo_Almacen_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles combo_Almacen.SelectionChangeCommitted
        Try
            Buscar()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            ListarPartesEntradaCabecera()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_imprimir.Click
        Try
            If dtcabecera.Rows.Count > 0 Then
                If dtDetalle.Rows.Count > 0 Then
                    ObtenerParteEntrada()
                    If ValidarDetalle() = False Then
                        If coddoc <> "" Then
                            Dim DetalleImprimirForm As New DetalleIngresoImprimir
                            DetalleImprimirForm.Text = "Definicion de Ubicaciones Para Hoja de Ingreso"
                            DetalleImprimirForm.idrack = idRack
                            DetalleImprimirForm.dtDetalleParteEntrada = dtDetalle
                            DetalleImprimirForm.ShowDialog()
                            If DetalleImprimirForm.grabado = True Then
                                Dim reporte As New HojaIngreso With {
                                    .nrodocumento = coddoc,
                                    .DetalleParteEntrada = DetalleImprimirForm.dtIngresoImprimir,
                                    .nombrealmacen = nombrealmacen,
                                    .nombreSite = nombreSite,
                                    .fecha = fecha,
                                    .tipomovimiento = tipomovimiento,
                                    .idrack = idRack
                                }
                                reporte.Show()
                            End If
                        End If
                    Else
                        ErrorProvider1.SetError(btn_imprimir, "Parte de Entrada Tiene Articulos Sin Lote")
                    End If
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Buscar()
        Dim dtbusqueda As New DataTable
        Try
            If ValidarFechasbuscar() = True Then
                Dim stringfiltro As String = ""

                If combo_Almacen.SelectedIndex = Constantes.ValorEnteroInicial Then
                    stringfiltro = String.Format("FECHA >= #{0}# AND FECHA <= #{1}# AND NDOCUMENTO LIKE '%{2}%' ", dt_desde.Value.ToString("MM/dd/yyyy"), dt_hasta.Value.ToString("MM/dd/yyyy"), txt_numero.Text)
                End If
                If combo_Almacen.SelectedIndex <> Constantes.ValorEnteroInicial Then
                    stringfiltro = String.Format("FECHA >= #{0}# AND FECHA <= #{1}# AND NDOCUMENTO LIKE '%{2}%' AND ALAMACEN_ORIGEN = '{3}' ", dt_desde.Value.ToString("MM/dd/yyyy"), dt_hasta.Value.ToString("MM/dd/yyyy"), txt_numero.Text, combo_Almacen.Text)
                End If
                dtcabecera.DefaultView.RowFilter = stringfiltro
            End If
        Catch ex As Exception
            Throw ex
            MsgBox(Constantes.MensajeErrorServer, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click

    End Sub

    Public Function LlamarListarPartesEntradaDET() As DataTable

        Dim dtretono As DataTable
        Try
            dtretono = ObjAlmacen.ListarParteEntradaDET(codalmacen, coddoc, tipdoc).Copy
        Catch ex As Exception
            Throw ex
        End Try
        Return dtretono
    End Function

    Public Sub ListarPartesEntradaCabecera()
        Try
            Dim dtretorno As New DataTable
            dtretorno = LlamarListarPartesEntradaCab()

            If dtretorno.Rows.Count > 0 Then
                dtcabecera.Rows.Clear()
                For Each RowRetorno As DataRow In dtretorno.Rows
                    If RowRetorno.Item("Resta") <> 0 Then
                        Dim rowcabecera As DataRow
                        rowcabecera = dtcabecera.NewRow
                        rowcabecera.Item("CODALMACEN_ORIGEN") = RowRetorno.Item("CODALMACEN_ORIGEN").ToString.Trim
                        rowcabecera.Item("ALAMACEN_ORIGEN") = RowRetorno.Item("ALAMACEN_ORIGEN").ToString.Trim
                        rowcabecera.Item("TIP_DOC") = RowRetorno.Item("TIP_DOC").ToString.Trim
                        rowcabecera.Item("NDOCUMENTO") = RowRetorno.Item("NDOCUMENTO").ToString.Trim
                        rowcabecera.Item("MES") = RowRetorno.Item("MES").ToString.Trim
                        rowcabecera.Item("FECHA") = RowRetorno.Item("FECHA").ToString.Trim
                        rowcabecera.Item("TIPO_MOV") = RowRetorno.Item("TIPO_MOV").ToString.Trim
                        rowcabecera.Item("COD_MOV") = RowRetorno.Item("COD_MOV").ToString.Trim
                        rowcabecera.Item("MOVIMIENTO") = RowRetorno.Item("MOVIMIENTO").ToString.Trim
                        rowcabecera.Item("NDOC_REFERENCIA") = RowRetorno.Item("NDOC_REFERENCIA").ToString.Trim
                        rowcabecera.Item("NORDEN_COMPRA") = RowRetorno.Item("NORDEN_COMPRA").ToString.Trim
                        rowcabecera.Item("CODPROV") = RowRetorno.Item("CODPROV").ToString.Trim
                        rowcabecera.Item("PROVEEDOR") = RowRetorno.Item("PROVEEDOR").ToString.Trim
                        rowcabecera.Item("GLOSA") = RowRetorno.Item("GLOSA").ToString.Trim
                        dtcabecera.Rows.Add(rowcabecera)
                    End If
                Next
                Dg_Cabecera.DataSource = dtcabecera
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ListarAlmacenSoftcom()
        Try

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

    Public Sub ListarPartesEntradaDetalle()
        Try
            Dim dtretorno As New DataTable
            dtretorno = LlamarListarPartesEntradaDET()

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
                    rowDetalle.Item("FECHA_VECIMIENTO") = RowRetorno.Item("FECHA_VECIMIENTO").ToString.Trim
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
                    If CType(rowDetalle.Item("ALTO").ToString, Decimal) <> 0 And CType(rowDetalle.Item("LARGO").ToString, Decimal) <> 0 And CType(rowDetalle.Item("ANCHO").ToString, Decimal) <> 0 And rowDetalle.Item("FACTORCAJA") <> 0 And rowDetalle.Item("FACTORCAJAMASTER") <> 0 Then
                        Dim volumencajamaster, Multiplicacion As Decimal
                        volumencajamaster = CType(rowDetalle.Item("ALTO").ToString, Decimal) * CType(rowDetalle.Item("LARGO").ToString, Decimal) * CType(rowDetalle.Item("ANCHO").ToString, Decimal)
                        Multiplicacion = (CType(rowDetalle.Item("FACTORCAJA"), Decimal) * CType(rowDetalle.Item("FACTORCAJAMASTER"), Decimal))
                        rowDetalle.Item("VOLUMEN") = Math.Round((volumencajamaster / Multiplicacion) * CType(rowDetalle.Item("SALDO"), Decimal), 2)
                    Else
                        rowDetalle.Item("VOLUMEN") = 0
                    End If

                    rowDetalle.Item("CODALMACEN_DESTINO") = RowRetorno.Item("CODALMACEN_DESTINO").ToString.Trim
                    rowDetalle.Item("ALMACEN_DESTINO") = RowRetorno.Item("ALMACEN_DESTINO").ToString.Trim
                    rowDetalle.Item("CANAL") = RowRetorno.Item("CANAL").ToString.Trim
                    rowDetalle.Item("RUC") = RowRetorno.Item("RUC").ToString.Trim
                    rowDetalle.Item("CLIENTE") = RowRetorno.Item("CLIENTE")
                    rowDetalle.Item("DEPARTAMENTO") = RowRetorno.Item("DEPARTAMENTO").ToString.Trim
                    rowDetalle.Item("PROVINCIA") = RowRetorno.Item("PROVINCIA").ToString.Trim
                    rowDetalle.Item("DISTRITO") = RowRetorno.Item("DISTRITO").ToString.Trim
                    rowDetalle.Item("TRANSPORTES") = RowRetorno.Item("TRANSPORTES").ToString.Trim
                    rowDetalle.Item("UBICAR") = False
                    dtDetalle.Rows.Add(rowDetalle)
                Next
                Dg_Detalle.DataSource = dtDetalle
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class