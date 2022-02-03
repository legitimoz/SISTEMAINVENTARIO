Imports ClosedXML.Excel
Imports Nordic.Bl.Be

Public Class GestionImportarRotulosProvincia

    Private dtcabecera2 As New DataTable
    Public Estructura As New EstructuraTabla
    Private ObjAlmacen As New AlmacenL

    Private Sub GestionImportarRotulosProvincia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargaInicial()
    End Sub

    Private Sub CargaInicial()
        Try
            FormatoTablaCabecera()
            ListarImportarRotulosProvincia()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ListarImportarRotulosProvincia()

        Try
            Dim dtretorno As New DataTable
            Dim contador As Integer = 0
            Dim cant As Integer = 0
            dtretorno = LlamarImportarRotulos()
            If dtretorno.Rows.Count > 0 Then
                dtcabecera2.Rows.Clear()
                For Each RowRetorno As DataRow In dtretorno.Rows
                    Dim rowcabecera As DataRow
                    rowcabecera = dtcabecera2.NewRow
                    rowcabecera.Item("Marcar") = False
                    rowcabecera.Item("C5_CNUMDOC") = RowRetorno.Item("C5_CNUMDOC").ToString.Trim
                    rowcabecera.Item("C5_CNOMCLI") = RowRetorno.Item("C5_CNOMCLI").ToString.Trim
                    rowcabecera.Item("C5_CDIRENV") = RowRetorno.Item("C5_CDIRENV").ToString.Trim
                    rowcabecera.Item("DE_CPROV") = RowRetorno.Item("DE_CPROV").ToString.Trim
                    rowcabecera.Item("DE_CDEPT") = RowRetorno.Item("DE_CDEPT").ToString.Trim
                    rowcabecera.Item("BULTO") = RowRetorno.Item("BULTO").ToString.Trim
                    rowcabecera.Item("drg_bulto") = RowRetorno.Item("drg_bulto").ToString
                    dtcabecera2.Rows.Add(rowcabecera)

                Next
                cant = dtcabecera2.Rows.Count
                Dg_Cabecera.DataSource = dtcabecera2
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function LlamarImportarRotulos() As DataTable
        Dim fechadesde, fechahasta, mes, dia As String

        mes = dt_desde.Value.Month.ToString
        If mes.Length = 1 Then
            mes = "0" + mes
        End If
        dia = dt_desde.Value.Day.ToString
        If dia.Length = 1 Then
            dia = "0" + dia
        End If

        fechadesde = dia + "/" + mes + "/" + dt_desde.Value.Year.ToString


        mes = dt_hasta.Value.Month.ToString
        If mes.Length = 1 Then
            mes = "0" + mes
        End If
        dia = dt_hasta.Value.Day.ToString
        If dia.Length = 1 Then
            dia = "0" + dia
        End If

        fechahasta = dia + "/" + mes + "/" + dt_hasta.Value.Year.ToString
        Dim dtretono As DataTable
        Try
            dtretono = ObjAlmacen.ListarImportarRotulos(fechadesde, fechahasta).Copy
        Catch ex As Exception
            Throw ex
        End Try
        Return dtretono
    End Function

    Public Sub FormatoTablaCabecera()

        dtcabecera2.Clear()
        dtcabecera2 = Estructura.GridImportarRotulos
        Dg_Cabecera.DataSource = dtcabecera2

        'TablaRetorno.Columns.Add("C5_CNUMDOC", GetType(String))
        'TablaRetorno.Columns.Add("C5_CNOMCLI", GetType(String))
        'TablaRetorno.Columns.Add("C5_CDIRENV", GetType(String))
        'TablaRetorno.Columns.Add("DE_CPROV", GetType(String))
        'TablaRetorno.Columns.Add("DE_CDEPT", GetType(String))
        'TablaRetorno.Columns.Add("BULTO", GetType(String))

        Dg_Cabecera.Columns("Marcar").HeaderText = "Marcar"
        Dg_Cabecera.Columns("Marcar").Width = 70
        Dg_Cabecera.Columns("Marcar").ReadOnly = True

        Dg_Cabecera.Columns("C5_CNUMDOC").HeaderText = "N° Guia"
        Dg_Cabecera.Columns("C5_CNUMDOC").Width = 70
        Dg_Cabecera.Columns("C5_CNUMDOC").ReadOnly = True

        Dg_Cabecera.Columns("C5_CNOMCLI").HeaderText = "Cliente"
        Dg_Cabecera.Columns("C5_CNOMCLI").Width = 100
        Dg_Cabecera.Columns("C5_CNOMCLI").ReadOnly = True

        Dg_Cabecera.Columns("C5_CDIRENV").HeaderText = "Direccion Entrega"
        Dg_Cabecera.Columns("C5_CDIRENV").Width = 100
        Dg_Cabecera.Columns("C5_CDIRENV").ReadOnly = True

        Dg_Cabecera.Columns("DE_CPROV").HeaderText = "Provincia"
        Dg_Cabecera.Columns("DE_CPROV").Width = 100
        Dg_Cabecera.Columns("DE_CPROV").ReadOnly = True

        Dg_Cabecera.Columns("DE_CDEPT").HeaderText = "Departamento"
        Dg_Cabecera.Columns("DE_CDEPT").Width = 100
        Dg_Cabecera.Columns("DE_CDEPT").ReadOnly = True

        Dg_Cabecera.Columns("BULTO").HeaderText = "Bulto"
        Dg_Cabecera.Columns("BULTO").Width = 70
        Dg_Cabecera.Columns("BULTO").ReadOnly = True

        Dg_Cabecera.Columns("drg_bulto").Visible = False

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            ListarImportarRotulosProvincia()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
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
            savedialog_Excel.FileName = "ROTULOS GUIAS"
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

    Public Sub ProcesoExportar()

        Try
            If dtcabecera2.Rows.Count > 0 Then
                Dim DtExel As New DataTable
                DtExel = Estructura.GridImportarRotulosExcel
                Dim RowExcel As DataRow
                For Each Rowcab As DataRow In dtcabecera2.Rows
                    If Rowcab.Item("MARCAR") = True Then
                        RowExcel = DtExel.NewRow
                        RowExcel.Item("C5_CNUMDOC") = Rowcab.Item("C5_CNUMDOC").ToString.Trim
                        RowExcel.Item("C5_CNOMCLI") = Rowcab.Item("C5_CNOMCLI").ToString.Trim
                        RowExcel.Item("C5_CDIRENV") = Rowcab.Item("C5_CDIRENV").ToString.Trim
                        RowExcel.Item("DE_CPROV") = Rowcab.Item("DE_CPROV").ToString.Trim
                        RowExcel.Item("DE_CDEPT") = Rowcab.Item("DE_CDEPT").ToString.Trim
                        RowExcel.Item("BULTO") = Rowcab.Item("BULTO").ToString.Trim
                        DtExel.Rows.Add(RowExcel)
                    End If
                Next
                If DtExel.Rows.Count > 0 Then
                    If ExportExcel(DtExel) Then
                        MsgBox("Excel Exportado Correctamente", MsgBoxStyle.Information)
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Dg_Cabecera_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dg_Cabecera.CellContentClick
        Try
            If e.RowIndex <> -1 Then
                If e.ColumnIndex = 0 Then
                    Dim row As DataGridViewRow = Dg_Cabecera.Rows(e.RowIndex)
                    row.Cells("Marcar").Value = Not row.Cells("Marcar").EditedFormattedValue
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CheckMarcar_CheckedChanged(sender As Object, e As EventArgs) Handles CheckMarcar.CheckedChanged
        If Dg_Cabecera.Rows.Count > 0 Then
            If CheckMarcar.Checked = True Then
                For Each RowCab As DataGridViewRow In Dg_Cabecera.Rows
                    If RowCab.Cells("Marcar").Value = False Then
                        RowCab.Cells("Marcar").Value = Not RowCab.Cells("Marcar").EditedFormattedValue
                    End If
                Next
            End If
            If CheckMarcar.Checked = False Then
                For Each RowCab As DataGridViewRow In Dg_Cabecera.Rows
                    If RowCab.Cells("Marcar").Value = True Then
                        RowCab.Cells("Marcar").Value = Not RowCab.Cells("Marcar").EditedFormattedValue
                    End If
                Next
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_Agrupar.Click
        Try
            If dtcabecera2.Rows.Count > 0 Then
                Dim DtExel As New DataTable
                DtExel = Estructura.GridImportarRotulosExcel
                Dim RowExcel As DataRow
                Dim Cadena As String = "", codcli As String = "", direccion As String = "", provincia As String = "", departamento As String = "", bulto As String = ""
                Dim cantBultos As Integer = 0
                For Each RowCab As DataRow In dtcabecera2.Rows
                    If RowCab.Item("Marcar") = True Then
                        If Cadena = "" Then
                            Cadena = Cadena + RowCab.Item("C5_CNUMDOC").ToString.Trim
                        Else
                            Cadena = Cadena + " / " + RowCab.Item("C5_CNUMDOC").ToString.Trim
                        End If
                        codcli = RowCab.Item("C5_CNOMCLI").ToString.Trim
                        direccion = RowCab.Item("C5_CDIRENV").ToString.Trim
                        provincia = RowCab.Item("DE_CPROV").ToString.Trim
                        departamento = RowCab.Item("DE_CDEPT").ToString.Trim
                        bulto = RowCab.Item("BULTO").ToString.Trim
                        cantBultos = CType(RowCab.Item("drg_bulto").ToString.Trim, Integer)
                    End If
                Next

                If cantBultos <> 0 Then
                    For Index As Integer = 1 To cantBultos
                        RowExcel = DtExel.NewRow
                        RowExcel.Item("C5_CNUMDOC") = Cadena
                        RowExcel.Item("C5_CNOMCLI") = codcli
                        RowExcel.Item("C5_CDIRENV") = direccion
                        RowExcel.Item("DE_CPROV") = provincia
                        RowExcel.Item("DE_CDEPT") = departamento
                        RowExcel.Item("BULTO") = Index.ToString + " DE " + cantBultos.ToString
                        DtExel.Rows.Add(RowExcel)
                    Next
                End If

                If DtExel.Rows.Count > 0 Then
                    ExportExcel(DtExel)
                End If


            End If
        Catch ex As Exception

        End Try
    End Sub
End Class