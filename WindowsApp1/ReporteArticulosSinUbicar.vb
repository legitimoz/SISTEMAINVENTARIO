Imports ClosedXML.Excel
Imports Nordic.Bl.Be


Public Class ReporteArticulosSinUbicar
    Private dtcabecera2, dtcabecera As New DataTable
    Public Estructura As New EstructuraTabla
    Private ObjAlmacen As New AlmacenL

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs)
        'Try

        '    Dim obj As New BePedidos
        '    Dim dt As New DataTable

        '    Dim fecini As String
        '    Dim fecfin As String

        '    fecini = dtpFecIni.Value.ToShortDateString
        '    fecfin = dtpFecFin.Value.ToShortDateString

        '    dt = obj.ListarPedidosProgramacionPicking(fecini, fecfin)

        '    dgvListarPedidosPicking.DataSource = dt

        '    tslCantidad.Text = CStr(dgvListarPedidosPicking.Rows.Count)



        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub btnExportar_Click(sender As Object, e As EventArgs)
        'Try
        '    Me.Cursor = Cursors.WaitCursor

        '    GridAExcel(dgvListarPedidosPicking)

        '    Me.Cursor = Cursors.Default
        'Catch ex As Exception

        'End Try
    End Sub




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
                'If i <> 1 And i <> 10 And i <> 11 And i <> 12 Then
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
                    'If Col <> 1 And Col <> 10 And Col <> 11 And Col <> 12 And Col <> 13 Then

                    If ElGrid.Rows(Fila).Cells(Col).Value Is DBNull.Value Then
                        exHoja.Cells.Item(Fila + 2, Col + 1) = ""
                    Else
                        exHoja.Cells.Item(Fila + 2, Col + 1) = CStr(ElGrid.Rows(Fila).Cells(Col).Value)
                    End If

                    'End If


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

    Private Sub CargaInicial()
        Try
            FormatoTablaCabecera()
            ListarReporteArticulosSinUbicacion()
        Catch ex As Exception

        End Try
    End Sub

    Public Function LlamarListarReporteArticulosSinUbicacion() As DataTable
        Dim dtretono As DataTable
        Try
            dtretono = ObjAlmacen.Reporte_Articulos_Sin_Ubicar().Copy
        Catch ex As Exception
            Throw ex
        End Try
        Return dtretono
    End Function


    Public Sub ListarReporteArticulosSinUbicacion()
        Try
            Dim dtretorno As New DataTable
            dtretorno = LlamarListarReporteArticulosSinUbicacion()
            If dtretorno.Rows.Count > 0 Then
                dtcabecera.Rows.Clear()
                dtcabecera = dtretorno
                dtcabecera2.Rows.Clear()
                For Each RowRetorno As DataRow In dtretorno.Rows
                    Dim rowcabecera As DataRow
                    rowcabecera = dtcabecera2.NewRow

                    rowcabecera.Item("UBICACION") = RowRetorno.Item("UBICACION").ToString.Trim
                    rowcabecera.Item("CODIGO") = RowRetorno.Item("CODIGO").ToString.Trim
                    rowcabecera.Item("CANTIDAD") = CType(RowRetorno.Item("CANTIDAD").ToString, Decimal)
                    rowcabecera.Item("LOTE") = RowRetorno.Item("LOTE").ToString.Trim
                    rowcabecera.Item("ALMACEN") = RowRetorno.Item("ALMACEN").ToString.Trim
                    dtcabecera2.Rows.Add(rowcabecera)
                Next
                Dg_Cabecera.DataSource = dtcabecera2
                ToolStripStatusLabel1.Text = dtcabecera2.Rows.Count
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub FormatoTablaCabecera()

        dtcabecera2.Clear()
        dtcabecera2 = Estructura.ReporteArticulosSinUbicar
        Dg_Cabecera.DataSource = dtcabecera2

        Dg_Cabecera.Columns("UBICACION").HeaderText = "Ubicacion Articulo"
        Dg_Cabecera.Columns("UBICACION").Width = 150
        Dg_Cabecera.Columns("UBICACION").ReadOnly = True

        Dg_Cabecera.Columns("CODIGO").HeaderText = "Codigo Articulo"
        Dg_Cabecera.Columns("CODIGO").Width = 150
        Dg_Cabecera.Columns("CODIGO").ReadOnly = True

        Dg_Cabecera.Columns("CANTIDAD").HeaderText = "Stock Softcom"
        Dg_Cabecera.Columns("CANTIDAD").Width = 150
        Dg_Cabecera.Columns("CANTIDAD").ReadOnly = True

        Dg_Cabecera.Columns("LOTE").HeaderText = "Lote Articulo"
        Dg_Cabecera.Columns("LOTE").Width = 150
        Dg_Cabecera.Columns("LOTE").ReadOnly = True

        Dg_Cabecera.Columns("ALMACEN").HeaderText = "Almacen Softcom"
        Dg_Cabecera.Columns("ALMACEN").Width = 150
        Dg_Cabecera.Columns("ALMACEN").ReadOnly = True

    End Sub

    Private Sub btnBuscar_Click_1(sender As Object, e As EventArgs)
        ListarReporteArticulosSinUbicacion()
    End Sub

    Public Sub ProcesoExportar()
        Try
            If dtcabecera2.Rows.Count > 0 Then
                If ExportExcel(dtcabecera2) Then
                    MsgBox("Excel Exportado Correctamente", MsgBoxStyle.Information)
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub



    Private Sub btnExportar_Click_1(sender As Object, e As EventArgs)
        Try
            ProcesoExportar()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub cmdCerrar_Click(sender As Object, e As EventArgs) Handles cmdCerrar.Click
        Me.Close()
    End Sub

    Private Sub cmdGenerarExcel_Click(sender As Object, e As EventArgs) Handles cmdGenerarExcel.Click
        Try
            ProcesoExportar()
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
            savedialog_Excel.FileName = "ARTICULOS SIN UBICACION " + Text
            dt.TableName = "PEDIDOS"
            Dim ws As IXLWorksheet
            If dt.Rows.Count > Constantes.ValorEnteroInicial Then
                dt.TableName = "Hoja2"
                If savedialog_Excel.ShowDialog = Windows.Forms.DialogResult.OK Then
                    path = savedialog_Excel.FileName
                    wb.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left
                    ws = wb.Worksheets.Add(dt)
                    ws.Style.Font.FontName = "Arial"
                    ws.Style.Font.FontSize = 8
                    ws.Columns().AdjustToContents()
                    wb.SaveAs(path)
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

    Private Sub frmReportePedidosPicking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CargaInicial()
        Catch ex As Exception

        End Try
    End Sub
End Class