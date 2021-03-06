Imports System.Configuration
Imports Microsoft.Reporting.WinForms
Imports Nordic.Bl.Be
Public Class ReporteMovimientos

    Public idposicion, rack As Integer
    Public codposicion, almacen As String
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


            Me.ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("MovimientosReport", DtDetalleReporte))


            Dim logooperador As String = ""
            Dim color As String = "White"

            'operariotributario = 1

            'Select Case operariotributario
            '    Case "1"
            '        logooperador = "NEBUSI"
            '        color = "IndianRed"
            '    Case "2"
            '        logooperador = "RIBAB"
            '        color = "DarkOrange"
            '    Case "3"
            '        logooperador = "BARDEX"
            '        color = "DarkSeaGreen"
            '    Case "4"
            '        logooperador = "ESCAME"
            '        color = "CornflowerBlue"
            '    Case Else
            '        logooperador = ""
            '        color = "Silver"
            'End Select

            logooperador = "LogoNordic"

            Dim codposicionparam As New ReportParameter("codPosicion", codposicion)
            Dim almacenparam As New ReportParameter("Almacen", almacen)
            Dim nombreempresaparam As New ReportParameter("nombreempresa", nombreempresa)
            Dim rucempresaparam As New ReportParameter("rucempresa", RUC)
            Dim direccionempresaparam As New ReportParameter("direccionempresa", Direccion)
            Dim nombreimagenparam As New ReportParameter("nombreimagen", logooperador)
            Dim colorheaderparam As New ReportParameter("colorheader", color)
            Dim rackparam As New ReportParameter("Rack", rack)

            Me.ReportViewer1.LocalReport.SetParameters(codposicionparam)
            Me.ReportViewer1.LocalReport.SetParameters(almacenparam)
            Me.ReportViewer1.LocalReport.SetParameters(nombreempresaparam)
            Me.ReportViewer1.LocalReport.SetParameters(rucempresaparam)
            Me.ReportViewer1.LocalReport.SetParameters(direccionempresaparam)
            Me.ReportViewer1.LocalReport.SetParameters(nombreimagenparam)
            Me.ReportViewer1.LocalReport.SetParameters(colorheaderparam)
            Me.ReportViewer1.LocalReport.SetParameters(rackparam)

            Me.ReportViewer1.LocalReport.DisplayName = Text
            Me.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
            Me.ReportViewer1.RefreshReport()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class