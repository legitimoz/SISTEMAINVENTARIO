Imports ClosedXML.Excel
Imports Nordic.Bl.Be

Public Class DetalleProductosXLinea

    Public dtDetalle As New DataTable
    Public Linea As String

    Private Sub cmdCerrar_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub DetalleProductosXLinea_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_Cabecera.Text = lbl_Cabecera.Text + Linea
        CargaInicial()
    End Sub

    Private Sub CargaInicial()
        Try
            Dim Contador As Integer = 0
            If dtDetalle.Rows.Count > 0 Then
                'Dg_Detalle.DataSource = dtDetalle
                For Each RowDetalle As DataRow In dtDetalle.Rows
                    Dg_Detalle.Rows.Add()
                    Dg_Detalle.Rows(Contador).Cells("CODIGO").Value = RowDetalle.Item("CODIGO").ToString.Trim
                    Dg_Detalle.Rows(Contador).Cells("ARTICULO").Value = RowDetalle.Item("ARTICULO").ToString.Trim
                    Dg_Detalle.Rows(Contador).Cells("LOTE").Value = RowDetalle.Item("LOTE").ToString.Trim
                    Dg_Detalle.Rows(Contador).Cells("CANTIDAD").Value = RowDetalle.Item("CANTIDAD").ToString.Trim
                    Dg_Detalle.Rows(Contador).Cells("CANT_MESES").Value = RowDetalle.Item("CANT_MESES").ToString.Trim
                    Contador = Contador + 1
                Next
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdGenerarExcel_Click(sender As Object, e As EventArgs)
        Try
            If dtDetalle.Rows.Count > 0 Then
                ExportExcel(dtDetalle)
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
            savedialog_Excel.FileName = "PRODUCTOS PROXIMOS A VENCER_" + Linea
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

    Private Sub cmdCerrar_Click_1(sender As Object, e As EventArgs) Handles cmdCerrar.Click
        Me.Close()
    End Sub
End Class