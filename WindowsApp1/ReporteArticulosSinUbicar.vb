Imports System.Configuration
Imports ClosedXML.Excel
Imports Nordic.Bl.Be


Public Class ReporteArticulosSinUbicar
    Private dtcabecera2, dtcabecera As New DataTable
    Public Estructura As New EstructuraTabla
    Private ObjAlmacen As New AlmacenL
    Private idalmacen As Integer = 0, idsite As Integer = 0

    Private Sub CargaInicial()
        Try
            idalmacen = CType(ConfigurationManager.AppSettings("idalmac").ToString.Trim, Integer)
            idsite = CType(ConfigurationManager.AppSettings("CodigoSite").ToString.Trim, Integer)
            FormatoTablaCabecera()
            ListarReporteArticulosSinUbicacion()

        Catch ex As Exception

        End Try
    End Sub

    Public Function LlamarListarReporteArticulosSinUbicacion() As DataTable
        Dim dtretono As DataTable
        Try
            dtretono = ObjAlmacen.Reporte_Articulos_Sin_Ubicar(idalmacen, idsite).Copy
        Catch ex As Exception
            Throw ex
        End Try
        Return dtretono
    End Function


    Public Sub ListarReporteArticulosSinUbicacion()
        Try
            Dim dtretorno As New DataTable
            dtretorno = LlamarListarReporteArticulosSinUbicacion()
            If dtretorno.Rows.Count > 0 Then
                dtcabecera.Rows.Clear()
                dtcabecera = dtretorno
                dtcabecera2.Rows.Clear()
                For Each RowRetorno As DataRow In dtretorno.Rows
                    Dim rowcabecera As DataRow
                    rowcabecera = dtcabecera2.NewRow

                    rowcabecera.Item("UBICACION") = RowRetorno.Item("UBICACION").ToString.Trim
                    rowcabecera.Item("CODIGO") = RowRetorno.Item("CODIGO").ToString.Trim
                    rowcabecera.Item("CANTIDAD") = CType(RowRetorno.Item("CANTIDAD").ToString, Decimal)
                    rowcabecera.Item("LOTE") = RowRetorno.Item("LOTE").ToString.Trim
                    rowcabecera.Item("ALMACEN") = RowRetorno.Item("ALMACEN").ToString.Trim
                    dtcabecera2.Rows.Add(rowcabecera)
                Next
                Dg_Cabecera.DataSource = dtcabecera2
                ToolStripStatusLabel1.Text = dtcabecera2.Rows.Count
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub FormatoTablaCabecera()

        dtcabecera2.Clear()
        dtcabecera2 = Estructura.ReporteArticulosSinUbicar
        Dg_Cabecera.DataSource = dtcabecera2

        Dg_Cabecera.Columns("UBICACION").HeaderText = "Ubicacion Articulo"
        Dg_Cabecera.Columns("UBICACION").Width = 150
        Dg_Cabecera.Columns("UBICACION").ReadOnly = True

        Dg_Cabecera.Columns("CODIGO").HeaderText = "Codigo Articulo"
        Dg_Cabecera.Columns("CODIGO").Width = 150
        Dg_Cabecera.Columns("CODIGO").ReadOnly = True

        Dg_Cabecera.Columns("CANTIDAD").HeaderText = "Stock Softcom"
        Dg_Cabecera.Columns("CANTIDAD").Width = 150
        Dg_Cabecera.Columns("CANTIDAD").ReadOnly = True

        Dg_Cabecera.Columns("LOTE").HeaderText = "Lote Articulo"
        Dg_Cabecera.Columns("LOTE").Width = 150
        Dg_Cabecera.Columns("LOTE").ReadOnly = True

        Dg_Cabecera.Columns("ALMACEN").HeaderText = "Almacen Softcom"
        Dg_Cabecera.Columns("ALMACEN").Width = 150
        Dg_Cabecera.Columns("ALMACEN").ReadOnly = True

    End Sub

    Private Sub btnBuscar_Click_1(sender As Object, e As EventArgs)
        ListarReporteArticulosSinUbicacion()
    End Sub

    Public Sub ProcesoExportar()
        Try
            If dtcabecera2.Rows.Count > 0 Then
                If ExportExcel(dtcabecera2) Then
                    MsgBox("Excel Exportado Correctamente", MsgBoxStyle.Information)
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub



    Private Sub btnExportar_Click_1(sender As Object, e As EventArgs)
        Try
            ProcesoExportar()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub cmdCerrar_Click(sender As Object, e As EventArgs) Handles cmdCerrar.Click
        Me.Close()
    End Sub

    Private Sub cmdGenerarExcel_Click(sender As Object, e As EventArgs) Handles cmdGenerarExcel.Click
        Try
            ProcesoExportar()
        Catch ex As Exception

        End Try
    End Sub

    Public Function ExportExcel(ByVal dt As DataTable) As Boolean
        Dim RP As Boolean = False
        Dim wb As New XLWorkbook()
        Dim path As String

        Try
            savedialog_Excel.Filter = "Excel File(.xlsx)|*.xlsx"
            savedialog_Excel.Title = Text
            savedialog_Excel.FileName = "ARTICULOS SIN UBICACION " + Text
            dt.TableName = "PEDIDOS"
            Dim ws As IXLWorksheet
            If dt.Rows.Count > Constantes.ValorEnteroInicial Then
                dt.TableName = "Hoja2"
                If savedialog_Excel.ShowDialog = Windows.Forms.DialogResult.OK Then
                    path = savedialog_Excel.FileName
                    wb.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left
                    ws = wb.Worksheets.Add(dt)
                    ws.Style.Font.FontName = "Arial"
                    ws.Style.Font.FontSize = 8
                    ws.Columns().AdjustToContents()
                    wb.SaveAs(path)
                    RP = True
                End If
            Else
                MsgBox("No existe DATA para generar Excel, Confirme Orden de Pago", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            Dim iderror As Integer
            iderror = ex.HResult
            If iderror = Constantes.errorexcel Then
                MsgBox("Archivo Excel se encuentra abierto, cierre el archivo e intente de nuevo", MsgBoxStyle.Exclamation)
            End If
        End Try
        Return RP

    End Function

    Private Sub frmReportePedidosPicking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CargaInicial()
        Catch ex As Exception

        End Try
    End Sub
End Class