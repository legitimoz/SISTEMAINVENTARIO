Imports System.Configuration
Imports ClosedXML.Excel
Imports Nordic.Bl.Be

Public Class ReporteKardexArticulo
    Private idalmacen As Integer = 0
    Private idsite As Integer = 0
    Private dt As New DataTable
    Private AlmObj As New AlmacenL
    Public usr_id As Integer
    Public usr_usuario As String


    Public Function ExportExcel(ByVal dt As DataTable) As Boolean
        Dim RP As Boolean = False
        Dim wb As New XLWorkbook()
        Dim path As String

        Try
            savedialog_Excel.Filter = "Excel File(.xlsx)|*.xlsx"
            savedialog_Excel.Title = Text
            savedialog_Excel.FileName = "REPORTE KARDEX ARTICULO"
            dt.TableName = "Hoja1"
            Dim ws As IXLWorksheet
            If dt.Rows.Count > Constantes.ValorEnteroInicial Then
                If savedialog_Excel.ShowDialog = Windows.Forms.DialogResult.OK Then
                    path = savedialog_Excel.FileName
                    wb.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left
                    ws = wb.Worksheets.Add(dt)
                    ws.Style.Font.FontName = "Arial"
                    ws.Style.Font.FontSize = 8
                    ws.Columns().AdjustToContents()
                    wb.SaveAs(path)
                    Process.Start(path)
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
    Private Sub ReporteKardexArticulo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CargaInicial()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargaInicial()
        Try
            idalmacen = CType(ConfigurationManager.AppSettings("idalmac").ToString.Trim, Integer)
            idsite = CType(ConfigurationManager.AppSettings("CodigoSite").ToString.Trim, Integer)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        Me.Close()
    End Sub

    Private Sub cmdBuscar_Click(sender As Object, e As EventArgs) Handles cmdBuscar.Click
        Try
            If idsite <> 0 Then
                If idalmacen <> 0 Then
                    If ValidarAceptar() Then
                        ListarArticulos()
                    Else
                        MsgBox("Existen Errores Por favor valide e intente nuevamente", MsgBoxStyle.Exclamation, "SISTEMAS NORDIC")
                    End If
                Else
                    MsgBox("Error al recuperar codigo de Almacen, por favor contactar al area de sistemas", MsgBoxStyle.Critical, "SISTEMAS NORDIC")
                End If
            Else
                MsgBox("Error al recuperar codigo de Site, por favor contactar al area de sistemas", MsgBoxStyle.Critical, "SISTEMAS NORDIC")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Public Sub ListarArticulos()
        Dim fechadesde, fechahasta, mes, dia As String

        mes = dt_desde.Value.Month.ToString
        If mes.Length = 1 Then
            mes = "0" + mes
        End If
        dia = dt_desde.Value.Day.ToString
        If dia.Length = 1 Then
            dia = "0" + dia
        End If

        fechadesde = dt_desde.Value.Year.ToString + "-" + mes + "-" + dia


        mes = dt_hasta.Value.Month.ToString
        If mes.Length = 1 Then
            mes = "0" + mes
        End If
        dia = dt_hasta.Value.Day.ToString
        If dia.Length = 1 Then
            dia = "0" + dia
        End If

        fechahasta = dt_hasta.Value.Year.ToString + "-" + mes + "-" + dia

        If dt.Rows.Count > 0 Then
            dt.Rows.Clear()
        End If
        dt = AlmObj.KardexArticulo(txt_codprod.Text.Trim, txt_codlote.Text.Trim, idalmacen, idsite, fechadesde, fechahasta)
        If dt.Rows.Count > 0 Then
            DgArticulos.DataSource = dt
        End If
    End Sub


    Public Function ValidarAceptar() As Boolean
        Dim rp As Boolean = True
        Try
            ErrorProvider1.SetError(txt_codprod, "")
            ErrorProvider1.SetError(txt_codlote, "")
            ErrorProvider1.SetError(dt_hasta, "")
            If txt_codprod.Text = "" Then
                ErrorProvider1.SetError(txt_codprod, "Digite Codigo Articulo")
                rp = False
            End If
            If txt_codlote.Text = "" Then
                ErrorProvider1.SetError(txt_codlote, "Digite Lote Articulo")
                rp = False
            End If
            If dt_hasta.Value < dt_desde.Value Then
                ErrorProvider1.SetError(dt_hasta, "Fecha hasta invalida")
                rp = False
            End If
        Catch ex As Exception
            Throw ex
        End Try
        Return rp
    End Function

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Try
            If dt.Rows.Count > 0 Then
                ExportExcel(dt)
            Else
                MsgBox("El Codigo / Lote Ingresado no tiene movimientos", MsgBoxStyle.Exclamation, "SISTEMAS NORDIC")
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class