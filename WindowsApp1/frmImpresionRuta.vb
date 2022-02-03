
Imports Nordic.Bl.Be

Public Class frmImpresionRuta

    Public nroRuta As String
    Public reporte As New Reporte_RutaNordic

    Private Sub frmImpresionRuta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim ds As New DataSet
            Dim dt As New DataTable

            CrystalReportViewer1.Visible = True
            reporte.DataSourceConnections.Item(0).SetLogon("sa", "D3b4s3")

            Dim objBeGuia As New BeGuias

            dt = objBeGuia.Imprimir_Ruta(nroRuta)

            reporte.SetDataSource(dt)
            CrystalReportViewer1.ReportSource = reporte
            CrystalReportViewer1.Zoom(100)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "NORDIC", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class