﻿Imports System.Configuration
Imports Microsoft.Reporting.WinForms

Public Class HojaRuta
    Public movilidad As String = ""
    Public transportista As String = ""
    Public totalvolumen As String = ""
    Public Dtruta As New DataTable
    Private Sub HojaRuta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

            If IsNothing(Dtruta) Then
                Me.Close()
                Exit Sub
            End If

            nombreempresa = ConfigurationManager.AppSettings("Empresa").ToString.Trim
            RUC = ConfigurationManager.AppSettings("nombreAlmacen").ToString.Trim
            Direccion = ConfigurationManager.AppSettings("nombreSite").ToString.Trim

            Me.ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DetalleRuta", Dtruta))


            Dim logooperador As String = ""
            Dim color As String = "White"

            Select Case nombreempresa
                Case "NORDIC PHARMACEUTICAL COMPANY SAC"
                    logooperador = "LogoNordic"
                    color = "IndianRed"

                Case "HEADMARK CORPORATION SAC"
                    logooperador = "SendaLogo"
                    color = "DarkOrange"
                    'Case "3"
                    '    logooperador = "BARDEX"
                    '    color = "DarkSeaGreen"
                    'Case "4"
                    '    logooperador = "ESCAME"
                    '    color = "CornflowerBlue"
                    'Case Else
                    '    logooperador = ""
                    '    color = "Silver"
            End Select

            Dim nombreempresaparam As New ReportParameter("nombreempresa", nombreempresa)
            Dim rucempresaparam As New ReportParameter("rucempresa", RUC)
            Dim direccionempresaparam As New ReportParameter("direccionempresa", Direccion)
            Dim nombreimagenparam As New ReportParameter("nombreimagen", logooperador)
            Dim colorheaderparam As New ReportParameter("colorheader", color)
            Dim totalvolumenparam As New ReportParameter("totalvolumen", totalvolumen)
            Dim tipotransporteparam As New ReportParameter("tipotransporte", movilidad)
            Dim transportistaparam As New ReportParameter("transportista", transportista)

            Me.ReportViewer1.LocalReport.SetParameters(nombreempresaparam)
            Me.ReportViewer1.LocalReport.SetParameters(rucempresaparam)
            Me.ReportViewer1.LocalReport.SetParameters(direccionempresaparam)
            Me.ReportViewer1.LocalReport.SetParameters(nombreimagenparam)
            Me.ReportViewer1.LocalReport.SetParameters(colorheaderparam)
            Me.ReportViewer1.LocalReport.SetParameters(totalvolumenparam)
            Me.ReportViewer1.LocalReport.SetParameters(tipotransporteparam)
            Me.ReportViewer1.LocalReport.SetParameters(transportistaparam)

            Me.ReportViewer1.LocalReport.DisplayName = Text
            Me.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
            Me.ReportViewer1.RefreshReport()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class