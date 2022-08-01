Imports ClosedXML.Excel
Imports Nordic.Bl.Be

Public Class ReporteDespachos
    Private almacenObj As New AlmacenL
    Private Estructura As New EstructuraTabla
    Private dtExcel As New DataTable

    Private Sub cmdCerrar_Click(sender As Object, e As EventArgs) Handles cmdCerrar.Click
        Me.Close()
    End Sub

    Private Sub CargaInicial()
        Try
            dtExcel = Estructura.ReporteDespachos
            ListarDespachos()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function LlamarObnterDespachos() As DataTable
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
        Dim dtretono As DataTable
        Try
            dtretono = almacenObj.SP_CSE_REPORTE_DESPACHOS(fechadesde, fechahasta).Copy
        Catch ex As Exception
            Throw ex
        End Try
        Return dtretono
    End Function

    Public Sub ListarDespachos()
        Try
            If Dg_Cabecera.Rows.Count > 0 Then
                Dg_Cabecera.Rows.Clear()
            End If
            Dim dtretorno As New DataTable
            dtretorno = LlamarObnterDespachos()
            If dtretorno.Rows.Count > 0 Then
                Dim contador As Integer = 0
                For Each RowRetorno As DataRow In dtretorno.Rows
                    Dg_Cabecera.Rows.Add()
                    Dg_Cabecera.Rows(contador).Cells("CodRuta").Value = RowRetorno.Item("Cod Ruta").ToString.Trim
                    Dg_Cabecera.Rows(contador).Cells("FechaDespacho").Value = RowRetorno.Item("Fecha Despacho").ToString.Trim
                    Dg_Cabecera.Rows(contador).Cells("Guia").Value = RowRetorno.Item("Guia").ToString.Trim
                    Dg_Cabecera.Rows(contador).Cells("Cliente").Value = RowRetorno.Item("Cliente").ToString.Trim
                    Dg_Cabecera.Rows(contador).Cells("Direccion").Value = RowRetorno.Item("Direccion").ToString.Trim
                    Dg_Cabecera.Rows(contador).Cells("Departamento").Value = RowRetorno.Item("Departamento").ToString.Trim
                    Dg_Cabecera.Rows(contador).Cells("Provincia").Value = RowRetorno.Item("Provincia").ToString.Trim
                    Dg_Cabecera.Rows(contador).Cells("Lima_Provincia").Value = RowRetorno.Item("Lima_Provincia").ToString.Trim
                    Dg_Cabecera.Rows(contador).Cells("Recojo_Despacho").Value = RowRetorno.Item("Recojo_Despacho").ToString.Trim
                    Dg_Cabecera.Rows(contador).Cells("Canal").Value = RowRetorno.Item("Canal").ToString.Trim
                    Dg_Cabecera.Rows(contador).Cells("Consolidado_Exclusivo").Value = RowRetorno.Item("Consolidado_Exclusivo").ToString.Trim
                    Dg_Cabecera.Rows(contador).Cells("Transportista").Value = RowRetorno.Item("Transportista").ToString.Trim
                    Dg_Cabecera.Rows(contador).Cells("CentroCosto").Value = RowRetorno.Item("Centro Costo").ToString.Trim
                    Dg_Cabecera.Rows(contador).Cells("M3").Value = RowRetorno.Item("M3").ToString.Trim
                    Dg_Cabecera.Rows(contador).Cells("KG").Value = RowRetorno.Item("KG").ToString.Trim
                    Dg_Cabecera.Rows(contador).Cells("Bulto").Value = RowRetorno.Item("Bulto").ToString.Trim
                    Dg_Cabecera.Rows(contador).Cells("FechaRetorno").Value = RowRetorno.Item("Fecha Retorno").ToString.Trim
                    Dg_Cabecera.Rows(contador).Cells("Vehiculo").Value = RowRetorno.Item("Vehiculo").ToString.Trim
                    Dg_Cabecera.Rows(contador).Cells("Capacidad").Value = RowRetorno.Item("Capacidad").ToString
                    Dg_Cabecera.Rows(contador).Cells("Distrito").Value = RowRetorno.Item("Distrito").ToString
                    Dg_Cabecera.Rows(contador).Cells("Restriccion").Value = RowRetorno.Item("Restriccion").ToString
                    Dg_Cabecera.Rows(contador).Cells("Ruc").Value = RowRetorno.Item("Ruc").ToString
                    Dg_Cabecera.Rows(contador).Cells("Importe").Value = RowRetorno.Item("Importe").ToString
                    Dg_Cabecera.Rows(contador).Cells("Comentario").Value = RowRetorno.Item("Comentario").ToString
                    Dg_Cabecera.Rows(contador).Cells("Site").Value = RowRetorno.Item("Site").ToString
                    If RowRetorno.Item("Ruc").ToString.Trim = "20131257750" And RowRetorno.Item("Direccion").ToString.Trim = "PJE. EL SOL 400 CDRA 35 AV. ARGENTINA - CALLAO - CALLAO - CALLAO" Then
                        Dg_Cabecera.Rows(contador).Cells("Canal").Value = "SALOG"
                    Else
                        If RowRetorno.Item("Ruc").ToString.Trim = "20556281140" Then
                            Dg_Cabecera.Rows(contador).Cells("Canal").Value = "IBT"
                        Else
                            If RowRetorno.Item("Ruc").ToString.Trim = "20601054001" Then
                                Dg_Cabecera.Rows(contador).Cells("Canal").Value = "ISCO"
                            Else
                                If RowRetorno.Item("Ruc").ToString.Trim = "20399497257" Then
                                    Dg_Cabecera.Rows(contador).Cells("Canal").Value = "DISTRIBUIDOR"
                                End If
                            End If
                        End If
                    End If
                    If RowRetorno.Item("Provincia").ToString.Trim = "CAÑETE".Trim Or RowRetorno.Item("Provincia").ToString.Trim = "HUARAL".Trim Or RowRetorno.Item("Provincia").ToString.Trim = "HUAURA".Trim Then
                        Dg_Cabecera.Rows(contador).Cells("Lima_Provincia").Value = "PROVINCIA"
                    End If
                    contador = contador + 1
                Next
                txt_cant_Rutas.Text = Dg_Cabecera.Rows.Count.ToString
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ReporteDespachos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargaInicial()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        ListarDespachos()
    End Sub

    Private Sub cmdGenerarExcel_Click(sender As Object, e As EventArgs) Handles cmdGenerarExcel.Click
        Try
            If Dg_Cabecera.Rows.Count > 0 Then
                For Each dgrow As DataGridViewRow In Dg_Cabecera.Rows
                    Dim rowAdd As DataRow = dtExcel.NewRow

                    'TablaAlmacen.Columns.Add("Cod Ruta", GetType(String))
                    'TablaAlmacen.Columns.Add("Fecha Despacho", GetType(String))
                    'TablaAlmacen.Columns.Add("Guia", GetType(String))
                    'TablaAlmacen.Columns.Add("Cliente", GetType(String))
                    'TablaAlmacen.Columns.Add("Direccion", GetType(String))
                    'TablaAlmacen.Columns.Add("Departamento", GetType(String))
                    'TablaAlmacen.Columns.Add("Provincia", GetType(String))
                    'TablaAlmacen.Columns.Add("Lima_Provincia", GetType(String))
                    'TablaAlmacen.Columns.Add("Recojo_Despacho", GetType(String))
                    'TablaAlmacen.Columns.Add("Canal", GetType(String))
                    'TablaAlmacen.Columns.Add("Consolidado_Exclusivo", GetType(String))
                    'TablaAlmacen.Columns.Add("Transportista", GetType(String))
                    'TablaAlmacen.Columns.Add("Centro Costo", GetType(String))
                    'TablaAlmacen.Columns.Add("M3", GetType(String))
                    'TablaAlmacen.Columns.Add("KG", GetType(String))
                    'TablaAlmacen.Columns.Add("Bulto", GetType(String))
                    'TablaAlmacen.Columns.Add("Fecha Retorno", GetType(String))

                    rowAdd.Item("Cod Ruta") = dgrow.Cells("CodRuta").Value
                    rowAdd.Item("Fecha Despacho") = dgrow.Cells("FechaDespacho").Value
                    rowAdd.Item("Guia") = dgrow.Cells("Guia").Value
                    rowAdd.Item("Cliente") = dgrow.Cells("Cliente").Value
                    rowAdd.Item("Direccion") = dgrow.Cells("Direccion").Value
                    rowAdd.Item("Departamento") = dgrow.Cells("Departamento").Value
                    rowAdd.Item("Provincia") = dgrow.Cells("Provincia").Value
                    rowAdd.Item("Lima_Provincia") = dgrow.Cells("Lima_Provincia").Value
                    rowAdd.Item("Recojo_Despacho") = dgrow.Cells("Recojo_Despacho").Value
                    rowAdd.Item("Canal") = dgrow.Cells("Canal").Value
                    rowAdd.Item("Consolidado_Exclusivo") = dgrow.Cells("Consolidado_Exclusivo").Value
                    rowAdd.Item("Transportista") = dgrow.Cells("Transportista").Value
                    rowAdd.Item("Centro Costo") = dgrow.Cells("CentroCosto").Value
                    rowAdd.Item("M3") = dgrow.Cells("M3").Value
                    rowAdd.Item("KG") = dgrow.Cells("KG").Value
                    rowAdd.Item("Bulto") = dgrow.Cells("Bulto").Value
                    rowAdd.Item("Fecha Retorno") = dgrow.Cells("FechaRetorno").Value
                    rowAdd.Item("Vehiculo") = dgrow.Cells("Vehiculo").Value
                    rowAdd.Item("Capacidad_Kg") = dgrow.Cells("Capacidad").Value
                    rowAdd.Item("Distrito") = dgrow.Cells("Distrito").Value
                    rowAdd.Item("Restriccion") = dgrow.Cells("Restriccion").Value
                    rowAdd.Item("Comentario") = dgrow.Cells("Comentario").Value
                    rowAdd.Item("Site") = dgrow.Cells("Site").Value
                    rowAdd.Item("Importe") = dgrow.Cells("Importe").Value
                    dtExcel.Rows.Add(rowAdd)
                Next
                If dtExcel.Rows.Count > 0 Then
                    ExportExcel(dtExcel)
                End If
            End If
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
            savedialog_Excel.FileName = "REPORTE DESPACHOS_" + dt_desde.Value.Day.ToString + "-" + dt_desde.Value.Month.ToString + "-" + dt_desde.Value.Year.ToString + "_" + dt_hasta.Value.Day.ToString + "-" + dt_hasta.Value.Month.ToString + "-" + dt_hasta.Value.Year.ToString
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
                MsgBox("No existe DATA para generar Excel", MsgBoxStyle.Exclamation)
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

End Class