Imports ClosedXML.Excel
Imports Nordic.Bl.Be

Public Class ReportePartesEntradaSinUbicar

    Private ObjAlmacen As New AlmacenL
    Private dt As New DataTable
    Public usr_id As Integer
    Public usr_usuario As String
    Public Function ExportExcel(ByVal dt As DataTable) As Boolean
        Dim RP As Boolean = False
        Dim wb As New XLWorkbook()
        Dim path As String

        Try
            savedialog_Excel.Filter = "Excel File(.xlsx)|*.xlsx"
            savedialog_Excel.Title = Text
            savedialog_Excel.FileName = "PARTES DE ENTRADA SIN INGRESO A SISTEMA"
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
    Private Sub ReportePartesEntradaSinUbicar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CargaIicial()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        Me.Close()
    End Sub
    Private Sub CargaIicial()
        Try
            Listar()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub cmdBuscar_Click(sender As Object, e As EventArgs) Handles cmdBuscar.Click
        Try
            If ValidarAceptar() Then
                Listar()
            Else
                MsgBox("Existen Errores Por favor valide e intente nuevamente", MsgBoxStyle.Exclamation, "SISTEMAS NORDIC")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Function ValidarAceptar() As Boolean
        Dim rp As Boolean = True
        Try
            If dt_hasta.Value < dt_desde.Value Then
                ErrorProvider1.SetError(dt_hasta, "Fecha hasta invalida")
                rp = False
            End If
        Catch ex As Exception
            Throw ex
        End Try
        Return rp
    End Function

    Public Sub Listar()
        If dt.Rows.Count > 0 Then
            dt.Rows.Clear()
        End If
        dt = LlamarListarPartesEntradaCab()

        If dt.Rows.Count > 0 Then
            Dg_Cabecera.DataSource = dt
            ToolStripStatusLabel1.Text = Dg_Cabecera.Rows.Count
        End If
    End Sub

    Public Function LlamarListarPartesEntradaCab() As DataTable

        Dim dtretono As DataTable
        Dim fechadesde, fechahasta, mes, dia As String

        mes = dt_desde.Value.Month.ToString
        If mes.Length = 1 Then
            mes = "0" + mes
        End If
        dia = dt_desde.Value.Day.ToString
        If dia.Length = 1 Then
            dia = "0" + dia
        End If

        fechadesde = dt_desde.Value.Year.ToString + "/" + mes + "/" + dia


        mes = dt_hasta.Value.Month.ToString
        If mes.Length = 1 Then
            mes = "0" + mes
        End If
        dia = dt_hasta.Value.Day.ToString
        If dia.Length = 1 Then
            dia = "0" + dia
        End If

        fechahasta = dt_hasta.Value.Year.ToString + "/" + mes + "/" + dia
        Try
            dtretono = ObjAlmacen.ListarParteEntradaSinUbicar(fechadesde, fechahasta).Copy
        Catch ex As Exception
            Throw ex
        End Try
        Return dtretono
    End Function

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Try
            If dt.Rows.Count > 0 Then
                ExportExcel(dt)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class