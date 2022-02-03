Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Imports System.IO
Imports Nordic.Bl.Be
Imports CrystalDecisions.CrystalReports.Engine

Public Class frmImpGuiaSsenda

    Public reporte As New Reporte_GuiaSsenda

    Private Sub btnVerInforme_Click(sender As Object, e As EventArgs) Handles btnVerInforme.Click
        Try
            Dim ds As New DataSet
            Dim dt As New DataTable
            Dim numdoc As String

            CrystalReportViewer1.Visible = True


            reporte.DataSourceConnections.Item(0).SetLogon("sa", "D3b4s3")

            'reporte.SetDatabaseLogon("sa", "D3b4s3", "10.10.0.5", "BDLABFAR")

            Dim objBeGuia As New BeGuias

            If txtNroGuia.Text = "" Then
                MessageBox.Show("Ingrese un Numero de Guia", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtNroGuia.Focus()

            Else

                numdoc = txtNroGuia.Text.Trim

                dt = objBeGuia.Obtener_Guia_Ssenda(numdoc)

                reporte.SetDataSource(dt)
                CrystalReportViewer1.ReportSource = reporte
                CrystalReportViewer1.Zoom(150)

            End If



        Catch ex As Exception
            MessageBox.Show(ex.Message, "NORDIC", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub frmImpGuiaSsenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtNroGuia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNroGuia.KeyPress
        Try

            If e.KeyChar = Convert.ToChar(Keys.Enter) Then

                Dim ds As New DataSet
                Dim dt As New DataTable
                Dim numdoc As String

                CrystalReportViewer1.Visible = True


                reporte.DataSourceConnections.Item(0).SetLogon("sa", "D3b4s3")

                'reporte.SetDatabaseLogon("sa", "D3b4s3", "10.10.0.5", "BDLABFAR")

                Dim objBeGuia As New BeGuias

                If txtNroGuia.Text = "" Then
                    MessageBox.Show("Ingrese un Numero de Guia", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtNroGuia.Focus()

                Else

                    numdoc = txtNroGuia.Text.Trim

                    dt = objBeGuia.Obtener_Guia_Ssenda(numdoc)

                    reporte.SetDataSource(dt)
                    CrystalReportViewer1.ReportSource = reporte
                    CrystalReportViewer1.Zoom(150)

                End If

            End If



        Catch ex As Exception
            MessageBox.Show(ex.Message, "NORDIC", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class