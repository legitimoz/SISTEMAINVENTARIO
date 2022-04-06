Imports Microsoft.Reporting.WinForms

Public Class ReporteAvance
    Public DtDetallePedido As DataTable
    Private Sub ReporteAvance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargaInicial()
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub CargaInicial()
        Try
            Me.Size = New Size(Me.ReportViewer1.GetPageSettings.PaperSize.Width, Me.Size.Height)
            If IsNothing(DtDetallePedido) Then
                Me.Close()
                Exit Sub
            End If
            Me.ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("data_reporte", DtDetallePedido))
            Me.ReportViewer1.LocalReport.DisplayName = Text
            Me.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception

        End Try
    End Sub
End Class