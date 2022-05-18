
Imports ClosedXML.Excel
Imports Nordic.Bl.Be



Public Class frmReporteDespacho

    Private mnuContextual As New ContextMenuStrip
    Friend WithEvents BtnVerImagen As System.Windows.Forms.Button
    Dim DTretorno As New DataTable

    Private Sub frmReporteDespacho_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            configurarMenucontextual()
            Cargar_Transportistas()
            Cargar_Estados()
            txtGuia.Enabled = False

        Catch ex As Exception

        End Try

    End Sub


    Sub Cargar_Transportistas()
        Try
            Dim objGuia As New BeGuias
            Dim dt As New DataTable

            dt = objGuia.Obtener_Transportistas2()

            cbxTransportista.DataSource = dt
            cbxTransportista.ValueMember = "TR_CCODIGO"
            cbxTransportista.DisplayMember = "TR_CNOMBRE"

        Catch ex As Exception
            MessageBox.Show(ex.Message, "NORDIC", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Sub Cargar_Estados()
        Try
            Dim objGuia As New BeGuias
            Dim dt As New DataTable

            dt = objGuia.Listar_Estados()

            cbxEstados.DataSource = dt
            cbxEstados.ValueMember = "est_codigo"
            cbxEstados.DisplayMember = "est_descripcon"

        Catch ex As Exception
            MessageBox.Show(ex.Message, "NORDIC", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            Dim objBeCabRuta As New BeCabGuiaRuta
            Dim dt As New DataTable
            Dim fecInicio As String = String.Empty
            Dim fecFin As String = String.Empty
            Dim NumGuias As String = String.Empty

            fecInicio = dtpFechaInicio.Value.ToShortDateString
            fecFin = dtpFecFin.Value.ToShortDateString

            If chkBxGuia.Checked = True Then
                NumGuias = txtGuia.Text.Trim

                If NumGuias = "" Then
                    MessageBox.Show("Ingresa el Numero de Guía", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    dt = objBeCabRuta.Reporte_Despachos_Filtros(5, 0, 0, 0, 0, NumGuias)

                End If

            Else
                If cbxTransportista.SelectedIndex = 0 And cbxEstados.SelectedIndex = 0 Then

                    dt = objBeCabRuta.Reporte_Despachos_Filtros(1, fecInicio, fecFin, 0, 0, 0)

                End If

                If cbxTransportista.SelectedIndex <> 0 And cbxEstados.SelectedIndex = 0 Then

                    dt = objBeCabRuta.Reporte_Despachos_Filtros(2, fecInicio, fecFin, cbxTransportista.SelectedValue, 0, 0)

                End If

                If cbxTransportista.SelectedIndex = 0 And cbxEstados.SelectedIndex <> 0 Then

                    dt = objBeCabRuta.Reporte_Despachos_Filtros(3, fecInicio, fecFin, 0, cbxEstados.SelectedValue, 0)

                End If

                If cbxTransportista.SelectedIndex <> 0 And cbxEstados.SelectedIndex <> 0 Then

                    dt = objBeCabRuta.Reporte_Despachos_Filtros(4, fecInicio, fecFin, cbxTransportista.SelectedValue, cbxEstados.SelectedValue, 0)

                End If

            End If

            If dt.Rows.Count = 0 Then
                MessageBox.Show("No se encontraron registros", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                DTretorno = dt.Copy
                dgvListarRutas_Guias.DataSource = dt

            End If


            Mostrar_Totales()


        Catch ex As Exception

        End Try
    End Sub


    Sub Mostrar_Totales()
        Try
            Dim contPend As Integer = 0
            Dim contEntr As Integer = 0
            Dim contRecha As Integer = 0

            For i As Integer = 0 To dgvListarRutas_Guias.Rows.Count - 1

                If dgvListarRutas_Guias.Rows(i).Cells.Item(11).Value = "PENDIENTE" Then
                    contPend = contPend + 1
                End If

                If dgvListarRutas_Guias.Rows(i).Cells.Item(11).Value = "ENTREGADO" Then
                    contEntr = contEntr + 1
                End If

                If dgvListarRutas_Guias.Rows(i).Cells.Item(11).Value = "RECHAZADO" Then
                    contRecha = contRecha + 1
                End If


            Next

            tsbCantTotal.Text = CStr(dgvListarRutas_Guias.Rows.Count)

            tslCantPend.Text = contPend.ToString()
            tslCantEntregados.Text = contEntr.ToString()
            tslCantRechaz.Text = contRecha.ToString()


        Catch ex As Exception

        End Try
    End Sub


    Private Sub chkBxGuia_CheckedChanged(sender As Object, e As EventArgs) Handles chkBxGuia.CheckedChanged
        Try
            If chkBxGuia.Checked = True Then
                cbxTransportista.Enabled = False
                cbxEstados.Enabled = False
                dtpFechaInicio.Enabled = False
                dtpFecFin.Enabled = False
                txtGuia.Enabled = True
                txtGuia.Text = ""
                txtGuia.Focus()
            End If

            If chkBxGuia.Checked = False Then
                cbxTransportista.Enabled = True
                cbxEstados.Enabled = True
                dtpFechaInicio.Enabled = True
                dtpFecFin.Enabled = True
                txtGuia.Enabled = False
                txtGuia.Text = ""
            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        Try
            'Me.Cursor = Cursors.WaitCursor

            'GridAExcel(dgvListarRutas_Guias)

            'Me.Cursor = Cursors.Default
            If DTretorno.Rows.Count > 0 Then
                ExportExcel(DTretorno)
            End If


        Catch ex As Exception

        End Try
    End Sub
    Public Function ExportExcel(ByVal dt As DataTable) As Boolean
        Dim RP As Boolean = False
        Dim wb As New XLWorkbook()
        Dim path As String

        Try
            savedialog_Excel.Filter = "Excel File(.xlsx)|*.xlsx"
            savedialog_Excel.Title = Text
            savedialog_Excel.FileName = "REPORTE DESPACHO " + Now.Day.ToString + "_" + Now.Month.ToString + "_" + Now.Year.ToString
            dt.TableName = "Hoja1"
            Dim ws As IXLWorksheet
            If dt.Rows.Count > Constantes.ValorEnteroInicial Then
                If savedialog_Excel.ShowDialog = Windows.Forms.DialogResult.OK Then
                    path = savedialog_Excel.FileName
                    wb.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left
                    ws = wb.Worksheets.Add(dt)
                    ws.Style.Font.FontName = "Arial"
                    ws.Style.Font.FontSize = 8
                    ws.Columns().AdjustToContents()
                    wb.SaveAs(path)
                    Process.Start(path)
                    RP = True
                End If
            Else
                MsgBox("No existe DATA para generar Excel, Confirme Orden de Pago", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            Dim iderror As Integer
            iderror = ex.HResult
            If iderror = Constantes.errorexcel Then
                MsgBox("Archivo Excel se encuentra abierto, cierre el archivo e intente de nuevo", MsgBoxStyle.Exclamation)
            End If
        End Try
        Return RP

    End Function


    Function GridAExcel(ByVal ElGrid As DataGridView) As Boolean

        Dim exApp As Object
        Dim exLibro As Object
        Dim exHoja As Object

        exApp = CreateObject("Excel.Application")

        ' -- Referencia a la Hoja activa ( la que añade por defecto Excel )   
        exHoja = exApp.ActiveSheet

        Try

            'Añadimos el Libro al programa, y la hoja al libro
            exLibro = exApp.Workbooks.Add()
            exHoja = exLibro.Worksheets(1)

            'exLibro = exApp.Workbooks
            'exHoja = exLibro.Worksheets.Add()

            ' ¿Cuantas columnas y cuantas filas?
            Dim NCol As Integer = ElGrid.ColumnCount
            Dim NRow As Integer = ElGrid.RowCount

            'Aqui recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.
            For i As Integer = 1 To NCol
                'If i <> 9 And i <> 23 And i <> 25 Then
                exHoja.Cells.Item(1, i) = ElGrid.Columns(i - 1).HeaderText.ToString()
                'End If
                'exHoja.Cells.Item(1, i).HorizontalAlignment = 3
            Next

            Dim fecha As String = String.Empty

            For Fila As Integer = 0 To NRow - 1
                For Col As Integer = 0 To NCol - 1

                    'If Col = 13 Or Col = 14 Or Col = 15 Or Col = 16 Or Col = 17 Then
                    '    fecha = "'" & CStr(ElGrid.Rows(Fila).Cells(Col).Value)
                    '    exHoja.Cells.Item(Fila + 2, Col + 1) = "'" & CStr(ElGrid.Rows(Fila).Cells(Col).Value)
                    'Else
                    '    exHoja.Cells.Item(Fila + 2, Col + 1) = CStr(ElGrid.Rows(Fila).Cells(Col).Value)

                    'End If
                    ' If Col <> 8 And Col <> 22 And Col <> 24 Then
                    'If Col = 3 Or Col = 0 Or Col = 2 Or Col = 13 Or Col = 14 Or Col = 15 Or Col = 16 Or Col = 17 Then
                    '    fecha = "'" & CStr(ElGrid.Rows(Fila).Cells(Col).Value)
                    '    exHoja.Cells.Item(Fila + 2, Col + 1) = "'" & CStr(ElGrid.Rows(Fila).Cells(Col).Value)
                    'Else
                    '    exHoja.Cells.Item(Fila + 2, Col + 1) = CStr(ElGrid.Rows(Fila).Cells(Col).Value)

                    'End If

                    If Col = 3 Then
                        fecha = "'" & CStr(ElGrid.Rows(Fila).Cells(Col).Value)
                        exHoja.Cells.Item(Fila + 2, Col + 1) = "'" & CStr(ElGrid.Rows(Fila).Cells(Col).Value)
                    Else
                        If Col = 2 Or Col = 14 Or Col = 15 Or Col = 16 Or Col = 17 Then
                            exHoja.Cells.Item(Fila + 2, Col + 1) = ElGrid.Rows(Fila).Cells(Col).Value
                        Else
                            exHoja.Cells.Item(Fila + 2, Col + 1) = CStr(ElGrid.Rows(Fila).Cells(Col).Value)
                        End If


                    End If
                    ' End If
                Next
            Next

            'Titulo en negrita, Alineado al centro y que el tamaño de la columna se
            'ajuste al texto


            exHoja.Rows.Item(1).Font.Bold = 1
            exHoja.Rows.Item(1).HorizontalAlignment = 3

            exHoja.Columns.AutoFit()

            exHoja.Rows.AutoFit()

            'exHoja.RowHeight = 12

            'Aplicación visible
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


    Private Sub txtGuia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGuia.KeyPress
        Try

            If e.KeyChar = Convert.ToChar(Keys.Enter) Then

                Dim objBeCabRuta As New BeCabGuiaRuta
                Dim dt As New DataTable
                Dim fecInicio As String = String.Empty
                Dim fecFin As String = String.Empty
                Dim NumGuias As String = String.Empty

                fecInicio = dtpFechaInicio.Value.ToShortDateString
                fecFin = dtpFecFin.Value.ToShortDateString



                If chkBxGuia.Checked = True Then
                    NumGuias = txtGuia.Text.Trim

                    If NumGuias = "" Then
                        MessageBox.Show("Ingresa el Numero de Guía", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Else
                        dt = objBeCabRuta.Reporte_Despachos_Filtros(5, 0, 0, 0, 0, NumGuias)

                    End If

                Else
                    If cbxTransportista.SelectedIndex = 0 And cbxEstados.SelectedIndex = 0 Then

                        dt = objBeCabRuta.Reporte_Despachos_Filtros(1, fecInicio, fecFin, 0, 0, 0)

                    End If

                    If cbxTransportista.SelectedIndex <> 0 And cbxEstados.SelectedIndex = 0 Then

                        dt = objBeCabRuta.Reporte_Despachos_Filtros(2, fecInicio, fecFin, cbxTransportista.SelectedValue, 0, 0)

                    End If

                    If cbxTransportista.SelectedIndex = 0 And cbxEstados.SelectedIndex <> 0 Then

                        dt = objBeCabRuta.Reporte_Despachos_Filtros(3, fecInicio, fecFin, 0, cbxEstados.SelectedValue, 0)

                    End If

                    If cbxTransportista.SelectedIndex <> 0 And cbxEstados.SelectedIndex <> 0 Then

                        dt = objBeCabRuta.Reporte_Despachos_Filtros(4, fecInicio, fecFin, cbxTransportista.SelectedValue, cbxEstados.SelectedValue, 0)

                    End If

                End If

                If dt.Rows.Count = 0 Then
                    MessageBox.Show("No se encontraron registros", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    dgvListarRutas_Guias.DataSource = dt

                End If


                Mostrar_Totales()


            End If


        Catch ex As Exception

        End Try
    End Sub

    Public Sub configurarMenucontextual()
        Try
            Dim oToolStripItem1 As New ToolStripMenuItem
            oToolStripItem1.Text = "Ver Imagen"
            oToolStripItem1.Tag = "1"
            AddHandler oToolStripItem1.Click, AddressOf BtnVerImagen_Click
            mnuContextual.Items.Add(oToolStripItem1)
            dgvListarRutas_Guias.ContextMenuStrip = mnuContextual
        Catch ex As Exception

        End Try
    End Sub


    Private Sub BtnVerImagen_Click(sender As Object, e As EventArgs) Handles BtnVerImagen.Click
        Try

            Dim fila As Integer
            fila = dgvListarRutas_Guias.CurrentRow.Index

            Dim ruta As String = String.Empty
            Dim file As String = String.Empty

            'If e.ColumnIndex = 9 Then

            file = dgvListarRutas_Guias.CurrentRow.Cells.Item("IMAGEN1").Value


            If file <> "" Then
                ruta = "T:\" + file

                Process.Start(ruta)
            Else
                MessageBox.Show("No se cargo imagen para este numero de Guía", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End If


        Catch ex As Exception

        End Try
    End Sub

    'Private Sub dgvListarRutas_Guias_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListarRutas_Guias.CellContentClick
    '    Try
    '        Dim ruta As String = String.Empty
    '        Dim file As String = String.Empty

    '        'If e.ColumnIndex = 9 Then

    '        file = dgvListarRutas_Guias.CurrentRow.Cells.Item("IMAGEN1").Value


    '            If file <> "" Then
    '                ruta = "T:\" + file

    '                Process.Start(ruta)
    '            Else
    '                MessageBox.Show("No se cargo imagen para este numero de Guía", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

    '            End If



    '        'End If
    '    Catch ex As Exception

    '    End Try
    'End Sub
End Class