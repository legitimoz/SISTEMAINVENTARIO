Imports System
Imports System.IO
Imports System.Data
Imports System.Text
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Drawing.Printing
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports Microsoft.Reporting.WinForms

Public Class Demo
    Implements IDisposable
    Private m_currentPageIndex As Integer
    Private m_streams As IList(Of Stream)

    Private Function LoadSalesData() As DataTable
        ' Create a new DataSet and read sales data file 
        ' data.xml into the first DataTable.
        Dim dataSet As New DataSet()
        dataSet.ReadXml("..\..\data.xml")
        Return dataSet.Tables(0)
    End Function

    ' Routine to provide to the report renderer, in order to
    ' save an image for each page of the report.
    Private Function CreateStream(ByVal name As String, ByVal fileNameExtension As String, ByVal encoding As Encoding, ByVal mimeType As String, ByVal willSeek As Boolean) As Stream
        Dim stream As Stream = New MemoryStream()
        m_streams.Add(stream)
        Return stream
    End Function

    ' Export the given report as an EMF (Enhanced Metafile) file.
    Private Sub Export(ByVal report As LocalReport)

        Dim deviceInfo As String = "<DeviceInfo>" &
            "<OutputFormat>EMF</OutputFormat>" &
            "<PageWidth>8.5in</PageWidth>" &
            "<PageHeight>11in</PageHeight>" &
            "<MarginTop>0.25in</MarginTop>" &
            "<MarginLeft>0.25in</MarginLeft>" &
            "<MarginRight>0.25in</MarginRight>" &
            "<MarginBottom>0.25in</MarginBottom>" &
            "</DeviceInfo>"
        Dim warnings As Warning()
        m_streams = New List(Of Stream)()
        report.Render("Image", deviceInfo, AddressOf CreateStream, warnings)
        For Each stream As Stream In m_streams
            stream.Position = 0
        Next
    End Sub

    Private Sub ExportHorizontal(ByVal report As LocalReport)

        Dim deviceInfo As String = "<DeviceInfo>" &
            "<OutputFormat>EMF</OutputFormat>" &
            "<PageWidth>29.7cm</PageWidth>" &
            "<PageHeight>21cm</PageHeight>" &
            "<MarginTop>0.25in</MarginTop>" &
            "<MarginLeft>0.25in</MarginLeft>" &
            "<MarginRight>0.25in</MarginRight>" &
            "<MarginBottom>0.25in</MarginBottom>" &
            "</DeviceInfo>"
        Dim warnings As Warning()
        m_streams = New List(Of Stream)()
        report.Render("Image", deviceInfo, AddressOf CreateStream, warnings)
        For Each stream As Stream In m_streams
            stream.Position = 0
        Next
    End Sub

    ' Handler for PrintPageEvents
    Private Sub PrintPage(ByVal sender As Object, ByVal ev As PrintPageEventArgs)
        Dim pageImage As New Metafile(m_streams(m_currentPageIndex))

        ' Adjust rectangular area with printer margins.
        Dim adjustedRect As New Rectangle(ev.PageBounds.Left - CInt(ev.PageSettings.HardMarginX),
                                          ev.PageBounds.Top - CInt(ev.PageSettings.HardMarginY),
                                          ev.PageBounds.Width,
                                          ev.PageBounds.Height)

        ' Draw a white background for the report
        ev.Graphics.FillRectangle(Brushes.White, adjustedRect)

        ' Draw the report content
        ev.Graphics.DrawImage(pageImage, adjustedRect)
        ' Prepare for the next page. Make sure we haven't hit the end.
        m_currentPageIndex += 1
        ev.HasMorePages = (m_currentPageIndex < m_streams.Count)
    End Sub

    Private Sub Print(orientacion As String)
        Try
            If m_streams Is Nothing OrElse m_streams.Count = 0 Then
                Throw New Exception("Error: no stream to print.")
            End If
            Dim printDoc As New PrintDocument()
            If orientacion = "H" Then
                printDoc.DefaultPageSettings.Landscape = True
            End If

            'printDoc.PrinterSettings.DE
            If Not printDoc.PrinterSettings.IsValid Then
                Throw New Exception("Error: cannot find the default printer.")
            Else
                AddHandler printDoc.PrintPage, AddressOf PrintPage
                m_currentPageIndex = 0

                printDoc.Print()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ReportePicking(ByVal nombrereporte As String, ByVal Data As DataTable, codigoguia As String, codpedido As String, nombreEmpresa As String,
                              RUC As String, Direccion As String, logooperador As String, Color As String, fechapedido As String,
                              razoncliente As String, ruccliente As String, direccioncliente As String, codalmacen As String, cantidadItems As Integer, totalvolumen As Decimal, GlosaPicking As String, Bultos As Integer, Peso As Decimal)


        Try
            totalvolumen = Math.Round(totalvolumen, 7)
            Dim report As New LocalReport()
            report.ReportPath = "..\..\Reporte\" + nombrereporte
            'report.DataSources.Add(New ReportDataSource(Data.TableName.ToString, LoadSalesData()))
            report.DataSources.Add(New ReportDataSource(Data.TableName.ToString, Data))
            Dim nombreempresaparam As New ReportParameter("nombreempresa", nombreEmpresa)
            Dim codParteEntradaparam As New ReportParameter("codPedido", codpedido)
            Dim codGuiaparam As New ReportParameter("codGuia", codigoguia)
            Dim rucempresaparam As New ReportParameter("rucempresa", RUC)
            Dim direccionempresaparam As New ReportParameter("direccionempresa", Direccion)
            Dim nombreimagenparam As New ReportParameter("nombreimagen", logooperador)
            Dim colorheaderparam As New ReportParameter("colorheader", Color)
            Dim fechaparam As New ReportParameter("fechaPedido", fechapedido)
            Dim razonclienteparam As New ReportParameter("Cliente", razoncliente)
            Dim rucclienteparam As New ReportParameter("RucCliente", ruccliente)
            Dim direccionclienteparam As New ReportParameter("DireccionCliente", direccioncliente)
            Dim cantidadbultosparam As New ReportParameter("cantbultos", cantidadItems)
            Dim totalvolumenparam As New ReportParameter("totalvolumen", totalvolumen.ToString + "M3")
            Dim codalmacenparam As New ReportParameter("almacenSoftcom", codalmacen)

            Dim bultosparam As New ReportParameter("bultos", Bultos)
            Dim Pesoparam As New ReportParameter("Peso", Peso)

            Dim glosaparam As New ReportParameter("Glosa", GlosaPicking)

            report.SetParameters(nombreempresaparam)
            report.SetParameters(codParteEntradaparam)
            report.SetParameters(codGuiaparam)
            report.SetParameters(rucempresaparam)
            report.SetParameters(direccionempresaparam)
            report.SetParameters(nombreimagenparam)
            report.SetParameters(colorheaderparam)
            report.SetParameters(fechaparam)
            report.SetParameters(razonclienteparam)
            report.SetParameters(rucclienteparam)
            report.SetParameters(direccionclienteparam)
            report.SetParameters(cantidadbultosparam)
            report.SetParameters(totalvolumenparam)
            report.SetParameters(codalmacenparam)
            report.SetParameters(glosaparam)
            report.SetParameters(bultosparam)
            report.SetParameters(Pesoparam)
            Export(report)
            Print("H")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ImprimirRuta(CodigoRuta As String, nombreEmpresa As String,
                              RUC As String, Direccion As String, logooperador As String, Color As String, ByVal nombrereporte As String, ByVal Data As DataTable, transportista As String, Vehiculo As String, totalvolumen As Decimal, totaltiempo As String, totalpeso As String, tipoenvio As String, totalbultos As Integer)

        Try
            Dim report As New LocalReport()
            report.ReportPath = "..\..\Reporte\" + nombrereporte
            report.DataSources.Add(New ReportDataSource(Data.TableName.ToString, Data))
            Dim CodRutaparam As New ReportParameter("CodRuta", CodigoRuta)
            Dim nombreempresaparam As New ReportParameter("nombreempresa", nombreEmpresa)
            Dim rucempresaparam As New ReportParameter("rucempresa", RUC)
            Dim direccionempresaparam As New ReportParameter("direccionempresa", Direccion)
            Dim nombreimagenparam As New ReportParameter("nombreimagen", logooperador)
            Dim colorheaderparam As New ReportParameter("colorheader", Color)
            Dim totalvolumenparam As New ReportParameter("totalvolumen", Math.Round(totalvolumen, 3).ToString + " M3")
            Dim tipotransporteparam As New ReportParameter("tipotransporte", Vehiculo)
            Dim transportistaparam As New ReportParameter("transportista", transportista)
            Dim totaltiempoparam As New ReportParameter("totaltiempo", totaltiempo)
            Dim totalpesoparam As New ReportParameter("totalpeso", totalpeso)
            Dim tipoenvioparam As New ReportParameter("tipoenvio", tipoenvio)
            Dim totalbultosparam As New ReportParameter("totalbultos", totalbultos)

            Dim ps As New System.Drawing.Printing.PageSettings()

            report.SetParameters(nombreempresaparam)
            report.SetParameters(rucempresaparam)
            report.SetParameters(direccionempresaparam)
            report.SetParameters(nombreimagenparam)
            report.SetParameters(colorheaderparam)
            report.SetParameters(totalvolumenparam)
            report.SetParameters(tipotransporteparam)
            report.SetParameters(transportistaparam)
            report.SetParameters(CodRutaparam)
            report.SetParameters(totaltiempoparam)
            report.SetParameters(totalpesoparam)
            report.SetParameters(tipoenvioparam)
            report.SetParameters(totalbultosparam)

            ExportHorizontal(report)
            Print("H")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ImprimirRotuloArticulo(ByVal nombrereporte As String, codigo As String, nombre As String, vecimiento As String, lote As String, cajasiner As String, cajasmaster As String)
        Try
            Dim report As New LocalReport()
            report.ReportPath = "..\..\Reporte\" + nombrereporte
            Dim codigoparam As New ReportParameter("codigo", codigo)
            Dim descripcionparam As New ReportParameter("descripcion", nombre)
            Dim loteparam As New ReportParameter("lote", lote)
            Dim vencimientoparam As New ReportParameter("vencimiento", vecimiento)

            Dim cajasinerparam As New ReportParameter("cajasiner", cajasiner)
            Dim cajasmasterparam As New ReportParameter("cajasmaster", cajasmaster)

            report.SetParameters(codigoparam)
            report.SetParameters(descripcionparam)
            report.SetParameters(loteparam)
            report.SetParameters(vencimientoparam)
            report.SetParameters(cajasinerparam)
            report.SetParameters(cajasmasterparam)

            ExportHorizontal(report)
            Print("H")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    'Public Sub reporteRouteP(ByVal nombrereporte As String)

    '    Try
    '        Dim report As New LocalReport()
    '        report.ReportPath = "..\..\Reporte\" + nombrereporte

    '        Export(report)
    '        Print("V")
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Sub

    Public Sub reporteRoute(ByVal nombrereporte As String, nroguia As String, cliente As String, direccion As String, provincia As String, departamento As String, bulto As String, logooperador As String)

        Try
            Dim report As New LocalReport()
            report.ReportPath = "..\..\Reporte\" + nombrereporte

            Dim nroguiaparam As New ReportParameter("nroguia", nroguia)
            Dim clienteparam As New ReportParameter("cliente", cliente)
            Dim direccionparam As New ReportParameter("direccion", direccion)
            Dim provinciaparam As New ReportParameter("provincia", provincia)
            Dim departamentoparam As New ReportParameter("departamento", departamento)
            Dim bultoparam As New ReportParameter("bulto", bulto)
            Dim nombreimagenparam As New ReportParameter("nombreimagen", logooperador)

            report.SetParameters(nroguiaparam)
            report.SetParameters(clienteparam)
            report.SetParameters(direccionparam)
            report.SetParameters(provinciaparam)
            report.SetParameters(departamentoparam)
            report.SetParameters(bultoparam)
            report.SetParameters(nombreimagenparam)
            Export(report)
            Print("V")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Dispose() Implements IDisposable.Dispose
        If m_streams IsNot Nothing Then
            For Each stream As Stream In m_streams
                stream.Close()
            Next
            m_streams = Nothing
        End If
    End Sub

    Public Shared Sub Main(ByVal args As String())
        Using demo As New Demo()
            'demo.Run()
        End Using
    End Sub
End Class