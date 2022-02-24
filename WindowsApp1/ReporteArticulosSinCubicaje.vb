Imports ClosedXML.Excel
Imports Nordic.Bl.Be

Public Class ReporteArticulosSinCubicaje
    Dim dt As New DataTable
    Private AlmObj As New AlmacenL
    Public usr_id As Integer
    Public usr_usuario As String
    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        Me.Close()
    End Sub

    Public Function ExportExcel(ByVal dt As DataTable) As Boolean
        Dim RP As Boolean = False
        Dim wb As New XLWorkbook()
        Dim path As String

        Try
            savedialog_Excel.Filter = "Excel File(.xlsx)|*.xlsx"
            savedialog_Excel.Title = Text
            savedialog_Excel.FileName = "ARTICULOS SIN CUBICAJE"
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

    Private Sub ReporteArticulosSinCubicaje_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargaInicial()
    End Sub

    Private Sub CargaInicial()
        Try
            ListarArticulos()
            ToolStripStatusLabel1.Text = dt.Rows.Count
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ListarArticulos()

        If dt.Rows.Count > 0 Then
            dt.Rows.Clear()
        End If
        dt = AlmObj.ObtenerArticulosSinCubicaje()
        If dt.Rows.Count > 0 Then
            DgArticulos.DataSource = dt
        End If
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        If dt.Rows.Count > 0 Then
            ExportExcel(dt)
        End If
    End Sub
End Class