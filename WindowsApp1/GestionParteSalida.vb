Imports System.Configuration
Imports Nordic.Bl.Be

Public Class GestionParteSalida
    Private dtcabecera, dtDetalle, dtalmacenessoft As New DataTable
    Private ObjAlmacen As New AlmacenL
    Public Estructura As New EstructuraTabla
    Public usr_id As Integer, perfilUsuario As Integer
    Public usr_usuario, codalmacen, tipdoc, nrodoc, fecha, direccionCliente, ruccliente, clienterazon, codpedido As String
    Private idalmacen As Integer = 0, idsite As Integer = 0

    Private Sub cmdCerrar_Click(sender As Object, e As EventArgs) Handles cmdCerrar.Click
        Me.Close()
    End Sub
    Public Sub FormatoTablaCabecera()

        dtcabecera.Clear()
        dtcabecera = Estructura.TablaCabeceraGuia
        Dg_Cabecera.DataSource = dtcabecera

        Dg_Cabecera.Columns("GlosaPicking").Visible = False

        Dg_Cabecera.Columns("MARCAR").HeaderText = "Marcar"
        Dg_Cabecera.Columns("MARCAR").Width = 50
        Dg_Cabecera.Columns("MARCAR").ReadOnly = True

        Dg_Cabecera.Columns("ESTADO_RECEP").HeaderText = "Recepcionado"
        Dg_Cabecera.Columns("ESTADO_RECEP").Width = 70
        Dg_Cabecera.Columns("ESTADO_RECEP").ReadOnly = True

        Dg_Cabecera.Columns("FECHA_RECEP").HeaderText = "Fecha Recepcion"
        Dg_Cabecera.Columns("FECHA_RECEP").Width = 70
        Dg_Cabecera.Columns("FECHA_RECEP").ReadOnly = True

        Dg_Cabecera.Columns("HORA_RECEP").HeaderText = "Hora Recepcion"
        Dg_Cabecera.Columns("HORA_RECEP").Width = 70
        Dg_Cabecera.Columns("HORA_RECEP").ReadOnly = True

        Dg_Cabecera.Columns("ESTADO").HeaderText = "Estado"
        Dg_Cabecera.Columns("ESTADO").Width = 70
        Dg_Cabecera.Columns("ESTADO").ReadOnly = True

        Dg_Cabecera.Columns("FECHA_IMPRE").HeaderText = "Fecha Impresion"
        Dg_Cabecera.Columns("FECHA_IMPRE").Width = 70
        Dg_Cabecera.Columns("FECHA_IMPRE").ReadOnly = True

        Dg_Cabecera.Columns("HORA_IMPRE").HeaderText = "Hora Impresion"
        Dg_Cabecera.Columns("HORA_IMPRE").Width = 70
        Dg_Cabecera.Columns("HORA_IMPRE").ReadOnly = True

        Dg_Cabecera.Columns("USUARIO_IMPRE").HeaderText = "Usuario Impresion"
        Dg_Cabecera.Columns("USUARIO_IMPRE").Width = 70
        Dg_Cabecera.Columns("USUARIO_IMPRE").ReadOnly = True

        Dg_Cabecera.Columns("CODALMACEN_ORIGEN").HeaderText = "Cod Almacen"
        Dg_Cabecera.Columns("CODALMACEN_ORIGEN").Width = 75
        Dg_Cabecera.Columns("CODALMACEN_ORIGEN").ReadOnly = True

        Dg_Cabecera.Columns("Resta").Visible = False
        Dg_Cabecera.Columns("ALAMACEN_ORIGEN").HeaderText = "Almacen"
        Dg_Cabecera.Columns("ALAMACEN_ORIGEN").Width = 250
        Dg_Cabecera.Columns("ALAMACEN_ORIGEN").ReadOnly = True

        Dg_Cabecera.Columns("TIP_DOC").HeaderText = "Tipo Documento"
        Dg_Cabecera.Columns("TIP_DOC").Width = 80
        Dg_Cabecera.Columns("TIP_DOC").ReadOnly = True
        Dg_Cabecera.Columns("TIP_DOC").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_Cabecera.Columns("NDOCUMENTO").HeaderText = "Cod Guia"
        Dg_Cabecera.Columns("NDOCUMENTO").Width = 100
        Dg_Cabecera.Columns("NDOCUMENTO").ReadOnly = True
        Dg_Cabecera.Columns("NDOCUMENTO").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_Cabecera.Columns("FECHA").HeaderText = "Fecha"
        Dg_Cabecera.Columns("FECHA").Width = 80
        Dg_Cabecera.Columns("FECHA").ReadOnly = True
        Dg_Cabecera.Columns("FECHA").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_Cabecera.Columns("TIPO_MOV").HeaderText = "Tipo Movimiento"
        Dg_Cabecera.Columns("TIPO_MOV").Width = 70
        Dg_Cabecera.Columns("TIPO_MOV").ReadOnly = True
        Dg_Cabecera.Columns("TIPO_MOV").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_Cabecera.Columns("MOVIMIENTO").HeaderText = "Movimiento"
        Dg_Cabecera.Columns("MOVIMIENTO").Width = 130
        Dg_Cabecera.Columns("MOVIMIENTO").ReadOnly = True
        Dg_Cabecera.Columns("MOVIMIENTO").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_Cabecera.Columns("USUARIO").HeaderText = "Cod Usuario"
        Dg_Cabecera.Columns("USUARIO").Width = 100
        Dg_Cabecera.Columns("USUARIO").ReadOnly = True
        Dg_Cabecera.Columns("USUARIO").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_Cabecera.Columns("RUC").HeaderText = "Ruc"
        Dg_Cabecera.Columns("RUC").Width = 100
        Dg_Cabecera.Columns("RUC").ReadOnly = True
        Dg_Cabecera.Columns("RUC").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_Cabecera.Columns("CLIENTE").HeaderText = "Cliente"
        Dg_Cabecera.Columns("CLIENTE").Width = 250
        Dg_Cabecera.Columns("CLIENTE").ReadOnly = True
        Dg_Cabecera.Columns("CLIENTE").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Dg_Cabecera.Columns("DIRECCIONCLIENTE").Visible = False

        Dg_Cabecera.Columns("CODPEDIDO").HeaderText = "Cod Pedido"
        Dg_Cabecera.Columns("CODPEDIDO").Width = 100
        Dg_Cabecera.Columns("CODPEDIDO").ReadOnly = True
        Dg_Cabecera.Columns("CODPEDIDO").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_Cabecera.Columns("PICADOR").HeaderText = "Picador"
        Dg_Cabecera.Columns("PICADOR").Width = 100
        Dg_Cabecera.Columns("PICADOR").ReadOnly = True
        Dg_Cabecera.Columns("PICADOR").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_Cabecera.Columns("FILTRO").HeaderText = "Filtro"
        Dg_Cabecera.Columns("FILTRO").Width = 100
        Dg_Cabecera.Columns("FILTRO").ReadOnly = True
        Dg_Cabecera.Columns("FILTRO").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub

    Public Function LlamarListarGuiasCab() As DataTable
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
        Dim dtretono As DataTable
        Try
            dtretono = ObjAlmacen.ListarParteSalidaCab(fechadesde, fechahasta, idalmacen, idsite).Copy
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
                If Dg_Cabecera.Rows.Count = 0 Then
                    dtDetalle.Rows.Clear()
                End If
            End If
        Catch ex As Exception
            Throw ex
            MsgBox(Constantes.MensajeErrorServer, MsgBoxStyle.Critical)
        End Try
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
            '' Buscar()
            If ValidarFechasbuscar() Then
                ListarGuiasCabecera()
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub txt_numero_TextChanged(sender As Object, e As EventArgs) Handles txt_numero.TextChanged
        Try
            Buscar()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Function GridAExcel(ByVal ElGrid As DataGridView) As Boolean

        Dim exApp As Object
        Dim exLibro As Object
        Dim exHoja As Object

        exApp = CreateObject("Excel.Application")
        exHoja = exApp.ActiveSheet
        Try

            exLibro = exApp.Workbooks.Add()
            exHoja = exLibro.Worksheets(1)
            Dim NCol As Integer = ElGrid.ColumnCount
            Dim NRow As Integer = ElGrid.RowCount
            For i As Integer = 1 To NCol
                exHoja.Cells.Item(1, i) = ElGrid.Columns(i - 1).HeaderText.ToString()
            Next

            Dim fecha As String = String.Empty

            For Fila As Integer = 0 To NRow - 1
                For Col As Integer = 0 To NCol - 1
                    If Col = 3 Then
                        fecha = "'" & CStr(ElGrid.Rows(Fila).Cells(Col).Value)
                        exHoja.Cells.Item(Fila + 2, Col + 1) = CStr(ElGrid.Rows(Fila).Cells(Col).Value)
                    Else
                        If Col = 2 Or Col = 14 Or Col = 15 Or Col = 16 Or Col = 17 Then
                            exHoja.Cells.Item(Fila + 2, Col + 1) = ElGrid.Rows(Fila).Cells(Col).Value
                        Else
                            exHoja.Cells.Item(Fila + 2, Col + 1) = CStr(ElGrid.Rows(Fila).Cells(Col).Value)
                        End If
                    End If
                Next
            Next

            exHoja.Rows.Item(1).Font.Bold = 1
            exHoja.Rows.Item(1).HorizontalAlignment = 3
            exHoja.Columns.AutoFit()
            exHoja.Rows.AutoFit()
            exApp.Application.Visible = True
            exHoja = Nothing
            exLibro = Nothing
            exApp = Nothing

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")
            Return False
        End Try

        Return True

    End Function

    Private Sub cmdGenerarExcel_Click(sender As Object, e As EventArgs) Handles cmdGenerarExcel.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            GridAExcel(Dg_Cabecera)
            Me.Cursor = Cursors.Default
        Catch ex As Exception

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
                            ObtenerGuiaCab()
                            If codalmacen <> "" And nrodoc <> "" And tipdoc <> "" Then
                                Dim RegistrarSalidaForm As New EditarSalidaAlmacen
                                RegistrarSalidaForm.perfilusuario = perfilUsuario
                                RegistrarSalidaForm.Lote = row.Cells("SERIE").EditedFormattedValue.ToString.Trim
                                RegistrarSalidaForm.correlativo = row.Cells("C6_CITEM").EditedFormattedValue.ToString.Trim
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
                                RegistrarSalidaForm.F5_CCODAGE = codalmacen
                                RegistrarSalidaForm.F5_CNUMPED = nrodoc
                                RegistrarSalidaForm.TIPDOC = tipdoc
                                RegistrarSalidaForm.iduser = usr_id
                                RegistrarSalidaForm.ShowDialog()
                                If RegistrarSalidaForm.grabado = True Then
                                    'If RegistrarSalidaForm.dtreportePicConfirm.Rows.Count > 0 Then
                                    '    Try
                                    '        If nrodoc <> "" Then
                                    '            Dim reporte As New HojaPickConfirm With {
                                    '                    .codigopedido = RegistrarSalidaForm.F5_CNUMPED,
                                    '                    .DtDetallePedido = RegistrarSalidaForm.dtreportePicConfirm,
                                    '                    .fechapedido = fecha
                                    '                }
                                    '            reporte.Show()
                                    '        End If
                                    '    Catch ex As Exception
                                    '        Throw ex
                                    '    End Try
                                    'End If
                                    ListarGuiasCabecera()
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

    Private Sub CargaInicial()
        Try
            idalmacen = CType(ConfigurationManager.AppSettings("idalmac").ToString.Trim, Integer)
            idsite = CType(ConfigurationManager.AppSettings("CodigoSite").ToString.Trim, Integer)
            Me.Text = "Gestion Partes de Salida"
            FormatoTablaCabecera()
            FormatoTablaDetalle()
            ListarGuiasCabecera()
            ListarAlmacenSoftcom()

            'ColorearGrid()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ListarGuiasCabecera()
        Dim totalGuias As Integer = 0, TotalPendientes As Integer = 0, TotalImpresos As Integer = 0, TotalPicados As Integer = 0
        Try
            Dim dtretorno As New DataTable
            dtretorno = LlamarListarGuiasCab()
            If dtretorno.Rows.Count > 0 Then
                dtcabecera.Rows.Clear()
                'dtcabecera = dtretorno
                For Each RowRetorno As DataRow In dtretorno.Rows

                    Dim rowcabecera As DataRow
                    rowcabecera = dtcabecera.NewRow
                    rowcabecera.Item("MARCAR") = False
                    rowcabecera.Item("CODALMACEN_ORIGEN") = RowRetorno.Item("CODALMACEN_ORIGEN").ToString.Trim
                    rowcabecera.Item("ALAMACEN_ORIGEN") = RowRetorno.Item("ALAMACEN_ORIGEN").ToString.Trim
                    rowcabecera.Item("TIP_DOC") = RowRetorno.Item("TIP_DOC").ToString.Trim
                    rowcabecera.Item("NDOCUMENTO") = RowRetorno.Item("NDOCUMENTO").ToString.Trim
                    rowcabecera.Item("CODPEDIDO") = RowRetorno.Item("CODPEDIDO").ToString.Trim
                    rowcabecera.Item("FECHA") = RowRetorno.Item("FECHA").ToString.Trim
                    rowcabecera.Item("TIPO_MOV") = RowRetorno.Item("TIPO_MOV").ToString.Trim
                    rowcabecera.Item("MOVIMIENTO") = RowRetorno.Item("MOVIMIENTO").ToString.Trim
                    rowcabecera.Item("USUARIO") = RowRetorno.Item("USUARIO").ToString.Trim
                    rowcabecera.Item("RUC") = RowRetorno.Item("RUC").ToString.Trim
                    rowcabecera.Item("CLIENTE") = RowRetorno.Item("CLIENTE").ToString.Trim
                    rowcabecera.Item("DIRECCIONCLIENTE") = RowRetorno.Item("DIRECCIONCLIENTE").ToString.Trim
                    rowcabecera.Item("PICADOR") = RowRetorno.Item("PICADOR").ToString.Trim
                    rowcabecera.Item("FILTRO") = RowRetorno.Item("FILTRO").ToString.Trim
                    rowcabecera.Item("Resta") = RowRetorno.Item("Resta").ToString.Trim
                    rowcabecera.Item("FECHA_IMPRE") = RowRetorno.Item("FECHA_IMPRE").ToString.Trim
                    rowcabecera.Item("HORA_IMPRE") = RowRetorno.Item("HORA_IMPRE").ToString.Trim
                    rowcabecera.Item("USUARIO_IMPRE") = RowRetorno.Item("USUARIO_IMPRE").ToString.Trim
                    rowcabecera.Item("ESTADO_RECEP") = RowRetorno.Item("ESTADO_RECEP").ToString.Trim
                    rowcabecera.Item("FECHA_RECEP") = RowRetorno.Item("FECHA_RECEP").ToString.Trim
                    rowcabecera.Item("HORA_RECEP") = RowRetorno.Item("HORA_RECEP").ToString.Trim
                    If RowRetorno.Item("ESTADO").ToString.Trim = "PE" Then
                        rowcabecera.Item("ESTADO") = "PENDIENTE"
                        ' TotalPendientes = TotalPendientes + 1
                    Else
                        If RowRetorno.Item("ESTADO").ToString.Trim = "PI" Then
                            rowcabecera.Item("ESTADO") = "PICADO"
                            '  TotalPicados = TotalPicados + 1
                        Else
                            rowcabecera.Item("ESTADO") = "IMPRESO"
                            'TotalImpresos = TotalImpresos + 1
                        End If
                    End If

                    If rowcabecera.Item("CODALMACEN_ORIGEN").ToString.Trim = "00AT" Or rowcabecera.Item("CODALMACEN_ORIGEN").ToString.Trim = "01AT" Or rowcabecera.Item("CODALMACEN_ORIGEN").ToString.Trim = "02AT" Or rowcabecera.Item("CODALMACEN_ORIGEN").ToString.Trim = "03AT" Or rowcabecera.Item("CODALMACEN_ORIGEN").ToString.Trim = "05AT" Or rowcabecera.Item("CODALMACEN_ORIGEN").ToString.Trim = "06AT" Or rowcabecera.Item("CODALMACEN_ORIGEN").ToString.Trim = "07AT" Or rowcabecera.Item("CODALMACEN_ORIGEN").ToString.Trim = "08AT" Or rowcabecera.Item("CODALMACEN_ORIGEN").ToString.Trim = "09AT" Or rowcabecera.Item("CODALMACEN_ORIGEN").ToString.Trim = "1008" Or rowcabecera.Item("CODALMACEN_ORIGEN").ToString.Trim = "AT01" Or rowcabecera.Item("CODALMACEN_ORIGEN").ToString.Trim = "CM01" Or rowcabecera.Item("CODALMACEN_ORIGEN").ToString.Trim = "DI08" Or rowcabecera.Item("CODALMACEN_ORIGEN").ToString.Trim = "DV01" Or rowcabecera.Item("CODALMACEN_ORIGEN").ToString.Trim = "RE01" Or rowcabecera.Item("CODALMACEN_ORIGEN").ToString.Trim = "RET1" Then

                        If RowRetorno.Item("ESTADO_RECEP").ToString.Trim = "SI" Then
                            totalGuias = totalGuias + 1
                            If RowRetorno.Item("ESTADO").ToString.Trim = "PE" Then
                                rowcabecera.Item("ESTADO") = "PENDIENTE"
                                TotalPendientes = TotalPendientes + 1
                            Else
                                If RowRetorno.Item("ESTADO").ToString.Trim = "PI" Then
                                    rowcabecera.Item("ESTADO") = "PICADO"
                                    TotalPicados = TotalPicados + 1
                                Else
                                    rowcabecera.Item("ESTADO") = "IMPRESO"
                                    TotalImpresos = TotalImpresos + 1
                                End If
                            End If
                        End If
                    End If

                    dtcabecera.Rows.Add(rowcabecera)
                Next
                Dg_Cabecera.DataSource = dtcabecera

            Else
                dtcabecera.Rows.Clear()
                dtDetalle.Rows.Clear()
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
                    'Dim rowa As DataRow = dtcabecera.Rows(e.RowIndex)
                    'rowa.Item("MARCAR") = Not row.Cells("MARCAR").EditedFormattedValue
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Sub ObtenerGuiaCab()
        Try
            If Dg_Cabecera.Rows.Count > 0 Then
                codalmacen = Dg_Cabecera.CurrentRow.Cells("CODALMACEN_ORIGEN").EditedFormattedValue.ToString.Trim
                tipdoc = Dg_Cabecera.CurrentRow.Cells("TIP_DOC").EditedFormattedValue.ToString.Trim
                nrodoc = Dg_Cabecera.CurrentRow.Cells("NDOCUMENTO").EditedFormattedValue.ToString.Trim
                fecha = Dg_Cabecera.CurrentRow.Cells("FECHA").EditedFormattedValue.ToString.Trim
                direccionCliente = Dg_Cabecera.CurrentRow.Cells("DIRECCIONCLIENTE").EditedFormattedValue.ToString.Trim
                ruccliente = Dg_Cabecera.CurrentRow.Cells("RUC").EditedFormattedValue.ToString.Trim
                clienterazon = Dg_Cabecera.CurrentRow.Cells("CLIENTE").EditedFormattedValue.ToString.Trim
                codpedido = Dg_Cabecera.CurrentRow.Cells("CODPEDIDO").EditedFormattedValue.ToString.Trim
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Function LlamarListarGuiasDET() As DataTable

        Dim dtretono As DataTable
        Try
            dtretono = ObjAlmacen.ListarGuiasDET(codalmacen, tipdoc, nrodoc, idalmacen, idsite).Copy
        Catch ex As Exception
            Throw ex
        End Try
        Return dtretono
    End Function
    Public Function LlamarObtenerCantiSalida(codarticulo As String, serie As String, item As String) As DataTable
        Dim rpRetorno As New DataTable
        Try
            rpRetorno = ObjAlmacen.ObtenerCantidadSalidaDetalle(codalmacen, tipdoc, nrodoc, codarticulo, serie, item, idsite, idalmacen)
        Catch ex As Exception

        End Try
        Return rpRetorno
    End Function
    Public Sub ListarGuiasDetalle()
        Try
            Dim dtretorno As New DataTable
            dtretorno = LlamarListarGuiasDET()

            If dtretorno.Rows.Count > 0 Then
                dtDetalle.Rows.Clear()
                For Each RowRetorno As DataRow In dtretorno.Rows
                    Dim rowDetalle As DataRow
                    rowDetalle = dtDetalle.NewRow
                    rowDetalle.Item("CODIGO") = RowRetorno.Item("CODIGO").ToString.Trim
                    rowDetalle.Item("PRODUCTO") = RowRetorno.Item("PRODUCTO").ToString.Trim
                    rowDetalle.Item("UNIDAD") = RowRetorno.Item("UNIDAD").ToString.Trim
                    rowDetalle.Item("FACTORCAJA") = RowRetorno.Item("FACTORCAJA").ToString.Trim
                    rowDetalle.Item("C6_CITEM") = RowRetorno.Item("C6_CITEM").ToString.Trim

                    If RowRetorno.Item("FACTORCAJAMASTER").ToString.Trim <> "" Then
                        rowDetalle.Item("FACTORCAJAMASTER") = CType(RowRetorno.Item("FACTORCAJAMASTER").ToString.Trim, Decimal)
                    Else
                        rowDetalle.Item("FACTORCAJAMASTER") = 0
                    End If
                    rowDetalle.Item("SERIE") = RowRetorno.Item("SERIE").ToString.Trim
                    rowDetalle.Item("FECHA_VECIMIENTO") = RowRetorno.Item("FECHA_VECIMIENTO").ToString.Trim
                    rowDetalle.Item("CANTIDAD") = RowRetorno.Item("CANTIDAD")
                    'rowDetalle.Item("SALDO") = RowRetorno.Item("SALDO")
                    Dim rp As New DataTable
                    rp = LlamarObtenerCantiSalida(rowDetalle.Item("CODIGO").ToString.Trim, rowDetalle.Item("SERIE").ToString.Trim, rowDetalle.Item("C6_CITEM").ToString.Trim)
                    If rp.Rows.Count > 0 Then
                        Dim SaliCant = CType(rp.Rows(0).Item("Salida").ToString, Integer)
                        rowDetalle.Item("SALDO") = CType(rowDetalle.Item("CANTIDAD"), Integer) - SaliCant
                    Else
                        rowDetalle.Item("SALDO") = rowDetalle.Item("CANTIDAD")
                    End If

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
                        rowDetalle.Item("CAJAS") = rowDetalle.Item("SALDO")
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
                    rowDetalle.Item("SALIDA") = False
                    dtDetalle.Rows.Add(rowDetalle)
                Next
                Dg_Detalle.DataSource = dtDetalle
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Private Sub Dg_Cabecera_SelectionChanged(sender As Object, e As EventArgs) Handles Dg_Cabecera.SelectionChanged
        Try
            ObtenerGuiaCab()
            If codalmacen <> "" And tipdoc <> "" And nrodoc <> "" Then
                ListarGuiasDetalle()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GestionParteSalida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargaInicial()
    End Sub

    Public Sub FormatoTablaDetalle()
        dtDetalle.Clear()
        dtDetalle = Estructura.TablaDetalleGuia

        Dg_Detalle.DataSource = dtDetalle

        Dg_Detalle.Columns("C6_CITEM").HeaderText = "Correlativo Item"
        Dg_Detalle.Columns("C6_CITEM").Width = 80
        Dg_Detalle.Columns("C6_CITEM").ReadOnly = True
        Dg_Detalle.Columns("C6_CITEM").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter


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
        Dg_Detalle.Columns("CANAL").Width = 85
        Dg_Detalle.Columns("CANAL").ReadOnly = False

        Dg_Detalle.Columns("RUC").Visible = False
        Dg_Detalle.Columns("CLIENTE").Visible = False

        Dg_Detalle.Columns("UNIDAD").HeaderText = "Unidad"
        Dg_Detalle.Columns("UNIDAD").Width = 70
        Dg_Detalle.Columns("UNIDAD").ReadOnly = False

        Dg_Detalle.Columns("DEPARTAMENTO").Visible = False
        Dg_Detalle.Columns("PROVINCIA").Visible = False
        Dg_Detalle.Columns("DISTRITO").Visible = False
        Dg_Detalle.Columns("TRANSPORTES").Visible = False

        Dg_Detalle.Columns("SALIDA").HeaderText = "Salida"
        Dg_Detalle.Columns("SALIDA").Width = 70
        Dg_Detalle.Columns("SALIDA").ReadOnly = False

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

End Class