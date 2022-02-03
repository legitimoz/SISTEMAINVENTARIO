Imports System.Configuration
Imports Microsoft.Reporting.WinForms
Imports Nordic.Bl.Be

Public Class HojaPicking
    Public codigoguia, fechapedido, razoncliente, ruccliente, direccioncliente, codalmacen, codpedido As String
    Public DtDetallePedido As DataTable
    Private ObjAlmacen As New AlmacenL
    Private Estructura As New EstructuraTabla
    Private Sub HojaPicking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CargaInicial()
        Catch ex As Exception
            Throw ex
        End Try
        Me.ReportViewer1.RefreshReport()
    End Sub

    Public Function LlamarListarPosicionesHojaPicking(codarticulo As String, lote As String, cantidad As Decimal) As DataTable

        Dim dtretono As DataTable
        Try
            dtretono = ObjAlmacen.ObtenerPosicionesHojaPicking(codarticulo, lote, cantidad).Copy
        Catch ex As Exception
            Throw ex
        End Try
        Return dtretono
    End Function

    Public Function ObtenerPosiciones(codarticulo As String, lote As String, cantidad As Decimal) As List(Of String)
        Dim dtposicion As New DataTable
        Dim rp As New List(Of String)
        Dim contador As Integer
        Dim cajas, cajasmaster As Decimal
        Try
            dtposicion = LlamarListarPosicionesHojaPicking(codarticulo, lote, cantidad)
            contador = 1
            If dtposicion.Rows.Count > 0 Then
                For Each rowpos As DataRow In dtposicion.Rows
                    If rp.Count = 3 Then
                        Exit For
                    End If
                    If rowpos.Item("FACTORCAJA") <> 0 Then
                        cajas = CType(rowpos.Item("Cantidad"), Integer) / rowpos.Item("FACTORCAJA")
                    Else
                        cajas = 0
                    End If
                    If rowpos.Item("FACTORCAJAMASTER") <> 0 And cajas <> 0 Then
                        cajasmaster = Math.Round(cajas / CType(rowpos.Item("FACTORCAJAMASTER"), Decimal), 2)
                    Else
                        cajasmaster = 0
                    End If
                    'rp.Add(rowpos.Item("Espacio").ToString.Trim + " | " + CType(rowpos.Item("Cantidad"), Integer).ToString + " UND" & vbCrLf +
                    '       " | " + Math.Round(cajas, 2).ToString + " CJ | " + Math.Round(cajasmaster, 2).ToString + " CJM")
                    rp.Add(rowpos.Item("Espacio").ToString.Trim)

                Next
            Else
                rp.Add("-")
                rp.Add("-")
                rp.Add("-")
            End If
            If rp.Count = 1 Then
                rp.Add("-")
                rp.Add("-")
            Else
                If rp.Count = 2 Then
                    rp.Add("-")
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
        Return rp
    End Function

    Public Sub CargaInicial()
        Try
            Me.Size = New Size(Me.ReportViewer1.GetPageSettings.PaperSize.Width, Me.Size.Height)
            Dim nombreempresa, RUC, Direccion As String
            Dim DtDetalleReporte As New DataTable
            Dim cajas As Decimal = 0, cajasm As Decimal = 0, saldo As Decimal = 0, totalvolumen As Decimal = 0
            DtDetalleReporte = Estructura.DetaleHojaPickingReport.Clone
            If IsNothing(DtDetallePedido) Then
                Me.Close()
                Exit Sub
            End If

            nombreempresa = ConfigurationManager.AppSettings("Empresa").ToString.Trim
            RUC = ConfigurationManager.AppSettings("nombreAlmacen").ToString.Trim
            Direccion = ConfigurationManager.AppSettings("nombreSite").ToString.Trim
            Dim RowDetalleReporte As DataRow
            For Each rowDetalle As DataRow In DtDetallePedido.Rows
                RowDetalleReporte = DtDetalleReporte.NewRow
                RowDetalleReporte.Item("CodArticulo") = rowDetalle.Item("CODIGO")
                RowDetalleReporte.Item("Articulo") = rowDetalle.Item("PRODUCTO")
                RowDetalleReporte.Item("Lote") = rowDetalle.Item("SERIE")
                RowDetalleReporte.Item("CantidadSalida") = rowDetalle.Item("SALDO")
                RowDetalleReporte.Item("Unidad") = rowDetalle.Item("UNIDAD")
                RowDetalleReporte.Item("Vencimiento") = rowDetalle.Item("FECHA_VECIMIENTO")
                If rowDetalle.Item("UNIDAD").ToString = "UND" Then
                    If rowDetalle.Item("FACTORCAJA").ToString <> 0 And rowDetalle.Item("FACTORCAJAMASTER").ToString <> 0 Then
                        cajas = (rowDetalle.Item("SALDO") / rowDetalle.Item("FACTORCAJA"))
                        saldo = rowDetalle.Item("SALDO") Mod rowDetalle.Item("FACTORCAJA")
                        cajasm = cajas / rowDetalle.Item("FACTORCAJAMASTER")
                        cajasm = Math.Floor(cajasm)
                        cajas = cajas Mod rowDetalle.Item("FACTORCAJAMASTER")
                    End If
                Else
                    If rowDetalle.Item("UNIDAD").ToString = "CJA" Then
                        saldo = 0
                        cajas = rowDetalle.Item("SALDO")
                        cajasm = cajas / rowDetalle.Item("FACTORCAJAMASTER")
                        cajasm = Math.Floor(cajasm)
                        cajas = cajas Mod rowDetalle.Item("FACTORCAJAMASTER")
                    End If
                End If
                RowDetalleReporte.Item("CajasM") = cajasm
                RowDetalleReporte.Item("CajasI") = cajas
                RowDetalleReporte.Item("Saldo") = saldo
                Dim posiciones As List(Of String)
                posiciones = ObtenerPosiciones(rowDetalle.Item("CODIGO").ToString.Trim, rowDetalle.Item("SERIE").ToString.Trim, CType(rowDetalle.Item("SALDO"), Decimal))
                If posiciones.Count > 0 Then
                    RowDetalleReporte.Item("Posicion1") = posiciones.ElementAt(0)
                    RowDetalleReporte.Item("Posicion2") = posiciones.ElementAt(1)

                End If
                totalvolumen = totalvolumen + rowDetalle.Item("VOLUMEN")
                DtDetalleReporte.Rows.Add(RowDetalleReporte)
            Next

            Me.ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DetalleHojaPicking", DtDetalleReporte))

            Dim logooperador As String = ""
            Dim color As String = "White"

            Select Case nombreempresa
                Case "NORDIC PHARMACEUTICAL COMPANY SAC"
                    logooperador = "LogoNordic"
                    color = "IndianRed"
                Case "HEADMARK CORPORATION SAC"
                    logooperador = "SendaLogo"
                    color = "DarkOrange"

            End Select
            totalvolumen = Math.Round(totalvolumen, 7)
            Dim codParteEntradaparam As New ReportParameter("codPedido", codpedido)
            Dim codGuiaparam As New ReportParameter("codGuia", codigoguia)
            Dim nombreempresaparam As New ReportParameter("nombreempresa", nombreempresa)
            Dim rucempresaparam As New ReportParameter("rucempresa", RUC)
            Dim direccionempresaparam As New ReportParameter("direccionempresa", Direccion)
            Dim nombreimagenparam As New ReportParameter("nombreimagen", logooperador)
            Dim colorheaderparam As New ReportParameter("colorheader", color)
            Dim fechaparam As New ReportParameter("fechaPedido", fechapedido)
            Dim razonclienteparam As New ReportParameter("Cliente", razoncliente)
            Dim rucclienteparam As New ReportParameter("RucCliente", ruccliente)
            Dim direccionclienteparam As New ReportParameter("DireccionCliente", direccioncliente)
            Dim cantidadbultosparam As New ReportParameter("cantbultos", DtDetalleReporte.Rows.Count)
            Dim totalvolumenparam As New ReportParameter("totalvolumen", totalvolumen.ToString + " M3")
            Dim codalmacenparam As New ReportParameter("almacenSoftcom", codalmacen)


            Me.ReportViewer1.LocalReport.SetParameters(codParteEntradaparam)
            Me.ReportViewer1.LocalReport.SetParameters(nombreempresaparam)
            Me.ReportViewer1.LocalReport.SetParameters(rucempresaparam)
            Me.ReportViewer1.LocalReport.SetParameters(direccionempresaparam)
            Me.ReportViewer1.LocalReport.SetParameters(nombreimagenparam)
            Me.ReportViewer1.LocalReport.SetParameters(colorheaderparam)
            Me.ReportViewer1.LocalReport.SetParameters(fechaparam)
            Me.ReportViewer1.LocalReport.SetParameters(razonclienteparam)
            Me.ReportViewer1.LocalReport.SetParameters(rucclienteparam)
            Me.ReportViewer1.LocalReport.SetParameters(direccionclienteparam)
            Me.ReportViewer1.LocalReport.SetParameters(cantidadbultosparam)
            Me.ReportViewer1.LocalReport.SetParameters(totalvolumenparam)
            Me.ReportViewer1.LocalReport.SetParameters(codalmacenparam)
            Me.ReportViewer1.LocalReport.SetParameters(codGuiaparam)

            Me.ReportViewer1.LocalReport.DisplayName = Text
            Me.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
            Me.ReportViewer1.RefreshReport()

        Catch ex As Exception

        End Try
    End Sub
End Class