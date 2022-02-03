Imports System.Configuration
Imports Microsoft.Reporting.WinForms
Imports Nordic.Bl.Be
Public Class ReportMovAlmacenForm

    Public rack As Integer
    Public sitenombre, almacen, fechadesde, fechahasta As String
    Public DtDetalleReporte As New DataTable
    Private Sub ReporteMovimientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CargaInicial()
        Catch ex As Exception
            Throw ex
        End Try
        Me.ReportViewer1.RefreshReport()
    End Sub

    Public Sub CargaInicial()
        Try
            Me.Size = New Size(Me.ReportViewer1.GetPageSettings.PaperSize.Width, Me.Size.Height)
            Dim nombreempresa, RUC, Direccion As String

            If IsNothing(DtDetalleReporte) Then
                Me.Close()
                Exit Sub
            End If

            nombreempresa = ConfigurationManager.AppSettings("Empresa").ToString.Trim
            RUC = ConfigurationManager.AppSettings("nombreAlmacen").ToString.Trim
            Direccion = ConfigurationManager.AppSettings("nombreSite").ToString.Trim


            Me.ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("MovAlmacenReport", DtDetalleReporte))


            Dim logooperador As String = ""
            Dim color As String = "White"

            logooperador = "LogoNordic"

            Dim codposicionparam As New ReportParameter("Site", sitenombre)
            Dim almacenparam As New ReportParameter("Almacen", almacen)
            Dim nombreempresaparam As New ReportParameter("nombreempresa", nombreempresa)
            Dim rucempresaparam As New ReportParameter("rucempresa", RUC)
            Dim direccionempresaparam As New ReportParameter("direccionempresa", Direccion)
            Dim nombreimagenparam As New ReportParameter("nombreimagen", logooperador)
            Dim colorheaderparam As New ReportParameter("colorheader", color)
            Dim fechadesdeparam As New ReportParameter("fechadesde", fechadesde)
            Dim fechahastaparam As New ReportParameter("fechahasta", fechahasta)

            Me.ReportViewer1.LocalReport.SetParameters(codposicionparam)
            Me.ReportViewer1.LocalReport.SetParameters(almacenparam)
            Me.ReportViewer1.LocalReport.SetParameters(nombreempresaparam)
            Me.ReportViewer1.LocalReport.SetParameters(rucempresaparam)
            Me.ReportViewer1.LocalReport.SetParameters(direccionempresaparam)
            Me.ReportViewer1.LocalReport.SetParameters(nombreimagenparam)
            Me.ReportViewer1.LocalReport.SetParameters(colorheaderparam)
            Me.ReportViewer1.LocalReport.SetParameters(fechadesdeparam)
            Me.ReportViewer1.LocalReport.SetParameters(fechahastaparam)

            Me.ReportViewer1.LocalReport.DisplayName = Text
            Me.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
            Me.ReportViewer1.RefreshReport()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class