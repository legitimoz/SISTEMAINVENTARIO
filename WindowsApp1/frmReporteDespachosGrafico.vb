Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Imports System.IO
Imports Nordic.Bl.Be
Imports CrystalDecisions.CrystalReports.Engine


Public Class frmReporteDespachosGrafico


    Public reporte As New Reporte_Despachos
    Public reporte2 As New Reporte_MotivosRechazados

    Private Sub frmReporteDespachosGrafico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            rbtEstadoDespacho.Checked = True
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        Try
            Me.Cursor = Cursors.WaitCursor



            Dim ds As New DataSet
                Dim dt As New DataTable
                'Dim numdoc As String

                CrystalReportViewer1.Visible = True


                reporte.DataSourceConnections.Item(0).SetLogon("headmark", "N0rd1c06$21")

                'reporte.SetDatabaseLogon("sa", "D3b4s3", "10.10.0.5", "BDLABFAR")

                Dim objBeGuia As New BeCabGuiaRuta


            If rbtEstadoDespacho.Checked = True Then
                dt = objBeGuia.ReporteSeguimientoDespachos(dtpFecini.Value.ToShortDateString, dtpFecfin.Value.ToShortDateString)
                reporte.SetDataSource(dt)
                CrystalReportViewer1.ReportSource = reporte
                CrystalReportViewer1.Zoom(100)

            Else
                If rbtMotivoRechazado.Checked = True Then

                    dt = objBeGuia.ReporteSeguimientoDespachos_Rechazados(dtpFecini.Value.ToShortDateString, dtpFecfin.Value.ToShortDateString)
                    reporte2.SetDataSource(dt)
                    CrystalReportViewer1.ReportSource = reporte2
                    CrystalReportViewer1.Zoom(100)

                End If
            End If


                Me.Cursor = Cursors.Default

        Catch ex As Exception
            MessageBox.Show(ex.Message, "NORDIC", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub
End Class