

Imports ClosedXML.Excel
Imports Nordic.Bl.Be

Public Class BuscadorArticulosUbicaion
    Public usr_id As Integer
    Public usr_usuario As String
    Private AlmObj As New AlmacenL
    Public dt As New DataTable
    Public iddetalle As Integer = 0, cantidad As Integer = 0

    Private Sub GestionContratacionForm_Load(sender As Object, e As EventArgs)
        Try
            CargaInicial()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub CargaInicial()
        Try
            ListarArticulos()
        Catch ex As Exception

        End Try
    End Sub

    Public Sub ListarArticulos()
        If dt.Rows.Count > 0 Then
            dt.Rows.Clear()
        End If
        dt = AlmObj.BuscarUbicacionArticulo
        If dt.Rows.Count > 0 Then
            DgArticulos.DataSource = dt
        End If
    End Sub

    Public Sub Buscar()
        Dim dtbusqueda As New DataTable
        Try
            Dim stringfiltro As String = ""
            stringfiltro = String.Format("Lote LIKE '%{0}%' AND CodArticulo LIKE '%{1}%' AND  Articulo LIKE '%{2}%' ", txt_codlote.Text, txt_codprod.Text, txt_descr.Text)
            dt.DefaultView.RowFilter = stringfiltro
        Catch ex As Exception
            Throw ex
            MsgBox(Constantes.MensajeErrorServer, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub BuscadorArticulosUbicaion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargaInicial()
    End Sub

    Private Sub txtCodRq_TextChanged(sender As Object, e As EventArgs) Handles txt_codlote.TextChanged
        Try
            Buscar()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txt_nroSerie_TextChanged(sender As Object, e As EventArgs) Handles txt_codprod.TextChanged
        Try
            Buscar()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtProveedores_TextChanged(sender As Object, e As EventArgs) Handles txt_descr.TextChanged
        Try
            Buscar()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Public Sub Obtener()
        Try
            If DgArticulos.Rows.Count > 0 Then
                codprod = DgArticulos.CurrentRow.Cells("CodArticulo").Value.ToString.Trim
                articuloNombre = DgArticulos.CurrentRow.Cells("Articulo").Value.ToString.Trim
                lote = DgArticulos.CurrentRow.Cells("Lote").Value.ToString.Trim
                vencimiento = DgArticulos.CurrentRow.Cells("Vencimiento").Value.ToString.Trim
                Dim Codigo As String = DgArticulos.CurrentRow.Cells("CODIGO").Value.ToString.Trim
                iddetalle = CType(Codigo.Replace(DgArticulos.CurrentRow.Cells("CodArticulo").Value.ToString.Trim, ""), Integer)
                cantidad = DgArticulos.CurrentRow.Cells("Cantidad").Value.ToString.Trim
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public codprod, articuloNombre, lote, vencimiento As String

    Private Sub cmdGenerarExcel_Click(sender As Object, e As EventArgs) Handles cmdGenerarExcel.Click
        Try
            'Me.Cursor = Cursors.WaitCursor
            'GridAExcel(DgArticulos)
            'Me.Cursor = Cursors.Default
            If dt.Rows.Count > 0 Then
                ExportExcel(dt)
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
            savedialog_Excel.FileName = "REPORTE UBICACION ARTICULOS"
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

    Private Sub cmdActulizarDatos_Click(sender As Object, e As EventArgs) Handles cmdActulizarDatos.Click
        Try
            ListarArticulos()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdBuscar_Click(sender As Object, e As EventArgs) Handles cmdBuscar.Click

    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Try
            Obtener()
            If iddetalle <> 0 Then
                Dim ConverForm As New ConversionArticulo
                ConverForm.iddetalle = iddetalle
                ConverForm.codigo = codprod
                ConverForm.lote = lote
                ConverForm.articuloNombre = articuloNombre
                ConverForm.cantidadAn = cantidad
                ConverForm.userid = usr_id
                ConverForm.ShowDialog()
                If ConverForm.grabado = True Then
                    ListarArticulos()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Try
            Dim AgregarArtiUn As New AgregarArticuloUnidad
            AgregarArticuloUnidad.user_id = usr_id
            AgregarArticuloUnidad.ShowDialog()
            If AgregarArticuloUnidad.grabado = True Then
                ListarArticulos()
            End If
        Catch ex As Exception

        End Try
    End Sub



    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Try
            Obtener()

            If codprod <> "" And articuloNombre <> "" Then
                Dim factorcaja, factormaster As Integer
                Dim Dtfactores As New DataTable
                Dtfactores = ObtenerFacrores(codprod)
                If Dtfactores.Rows.Count > 0 Then
                    factorcaja = Dtfactores.Rows(0).Item("cinternas").ToString
                    factormaster = Dtfactores.Rows(0).Item("cmaster").ToString
                Else
                    factormaster = 0
                    factorcaja = 0
                End If

                Dim cantrotuForm As New CantidadRotulos
                cantrotuForm.ShowDialog()
                If cantrotuForm.grabado = True Then
                    Dim cantidad = cantrotuForm.cantidad
                    If cantidad <> 0 Then
                        Dim Obj As New Demo
                        For Index As Integer = 1 To cantidad
                            Obj.ImprimirRotuloArticulo("RetuloArticuloIngreso.rdlc", codprod, articuloNombre, vencimiento, lote, factorcaja.ToString + " UND", (factorcaja * factormaster).ToString + " UND")
                        Next
                    End If
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function ObtenerFacrores(CodArticulo As String) As DataTable
        Dim dtretorno As New DataTable
        Try
            dtretorno = AlmObj.ObtenerFactoresArticulo(CodArticulo)
        Catch ex As Exception
            Throw ex
        End Try
        Return dtretorno
    End Function

End Class