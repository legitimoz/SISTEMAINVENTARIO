Imports System.Configuration
Imports Microsoft.Reporting.WinForms
Imports Nordic.Bl.Be

Public Class HojaIngreso

    Public DetalleParteEntrada As New DataTable
    Public nrodocumento, fecha, tipomovimiento, nombrealmacen, nombreSite As String
    Public idrack As Integer = 0
    Private ObjAlmacen As New AlmacenL
    Private Estructura As New EstructuraTabla


    Private Sub HojaIngreso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

            Dim origen, codParteEntrada, fechaParteEntrada, nombreempresa, AlmacenNombre, SiteNombre As String
            Dim DtDetalleReporte As New DataTable
            DtDetalleReporte = Estructura.DetaleHojaIngresoReport(False).Clone

            If IsNothing(DetalleParteEntrada) Then
                Me.Close()
                Exit Sub
            End If

            origen = tipomovimiento
            codParteEntrada = nrodocumento
            fechaParteEntrada = fecha
            nombreempresa = ConfigurationManager.AppSettings("Empresa").ToString.Trim
            AlmacenNombre = nombrealmacen
            SiteNombre = nombreSite
            Dim RowDetalleReporte As DataRow
            For Each rowDetalle As DataRow In DetalleParteEntrada.Rows
                RowDetalleReporte = DtDetalleReporte.NewRow
                RowDetalleReporte.Item("CodArticulo") = rowDetalle.Item("CodArticulo")
                RowDetalleReporte.Item("Articulo") = rowDetalle.Item("Articulo")
                RowDetalleReporte.Item("Lote") = rowDetalle.Item("Lote")
                RowDetalleReporte.Item("Cantidad") = rowDetalle.Item("Cantidad").ToString
                RowDetalleReporte.Item("Volumen") = rowDetalle.Item("Volumen").ToString
                RowDetalleReporte.Item("Posicion1") = rowDetalle.Item("Posicion1").ToString
                RowDetalleReporte.Item("Posicion2") = rowDetalle.Item("Posicion2").ToString
                RowDetalleReporte.Item("Posicion3") = rowDetalle.Item("Posicion3").ToString

                RowDetalleReporte.Item("Cajas") = rowDetalle.Item("Cajas").ToString
                RowDetalleReporte.Item("CajasM") = rowDetalle.Item("CajasM").ToString
                RowDetalleReporte.Item("Saldo") = rowDetalle.Item("Saldo").ToString

                DtDetalleReporte.Rows.Add(RowDetalleReporte)
            Next

            Me.ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("hojaingresoReport", DtDetalleReporte))


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

            Dim origenparam As New ReportParameter("origen", origen)
            Dim codParteEntradaparam As New ReportParameter("codParteEntrada", codParteEntrada)
            Dim nombreempresaparam As New ReportParameter("nombreempresa", nombreempresa)
            Dim rucempresaparam As New ReportParameter("rucempresa", AlmacenNombre)
            Dim direccionempresaparam As New ReportParameter("direccionempresa", SiteNombre)
            Dim nombreimagenparam As New ReportParameter("nombreimagen", logooperador)
            Dim colorheaderparam As New ReportParameter("colorheader", color)
            Dim fechaparam As New ReportParameter("fechaParteEntrada", fechaParteEntrada)

            Me.ReportViewer1.LocalReport.SetParameters(origenparam)
            Me.ReportViewer1.LocalReport.SetParameters(codParteEntradaparam)
            Me.ReportViewer1.LocalReport.SetParameters(nombreempresaparam)
            Me.ReportViewer1.LocalReport.SetParameters(rucempresaparam)
            Me.ReportViewer1.LocalReport.SetParameters(direccionempresaparam)
            Me.ReportViewer1.LocalReport.SetParameters(nombreimagenparam)
            Me.ReportViewer1.LocalReport.SetParameters(colorheaderparam)
            Me.ReportViewer1.LocalReport.SetParameters(fechaparam)

            Me.ReportViewer1.LocalReport.DisplayName = Text
            Me.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
            Me.ReportViewer1.RefreshReport()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function LlamarListarPosiciones() As DataTable

        Dim dtretono As DataTable
        Try
            dtretono = ObjAlmacen.ListarPosiciones(idrack).Copy
        Catch ex As Exception
            Throw ex
        End Try
        Return dtretono
    End Function

End Class