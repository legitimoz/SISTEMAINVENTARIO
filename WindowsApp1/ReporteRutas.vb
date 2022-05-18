Imports ClosedXML.Excel
Imports Nordic.Bl.Be

Public Class ReporteRutas
    Private almacenObj As New AlmacenL
    Private Estructura As New EstructuraTabla
    Private dtExcel As New DataTable

    Private Sub cmdCerrar_Click(sender As Object, e As EventArgs) Handles cmdCerrar.Click
        Me.Close()
    End Sub

    Private Sub ReporteRutas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargaInicial()
    End Sub

    Private Sub CargaInicial()
        Try
            dtExcel = Estructura.ReporteRutas
            ListarRutas()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Public Function LlamarObnterRutas() As DataTable
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
            dtretono = almacenObj.SP_CSE_REPORTE_RUTAS(fechadesde, fechahasta).Copy
        Catch ex As Exception
            Throw ex
        End Try
        Return dtretono
    End Function

    Public Sub ListarRutas()
        Try

            Dim cantidadAnuladas As Integer = 0, CantidadPendientes As Integer = 0, CantidadRecepcionadas As Integer = 0
            If Dg_Cabecera.Rows.Count > 0 Then
                Dg_Cabecera.Rows.Clear()
            End If
            Dim dtretorno As New DataTable
            dtretorno = LlamarObnterRutas()

            If dtretorno.Rows.Count > 0 Then

                Dim contador As Integer = 0
                For Each RowRetorno As DataRow In dtretorno.Rows
                    Dg_Cabecera.Rows.Add()

                    Dg_Cabecera.Rows(contador).Cells("CodRuta").Value = RowRetorno.Item("CodRuta").ToString.Trim
                    Dg_Cabecera.Rows(contador).Cells("Fecha").Value = RowRetorno.Item("Fecha").ToString.Trim
                    Dg_Cabecera.Rows(contador).Cells("Guias").Value = RowRetorno.Item("Guias").ToString.Trim
                    Dg_Cabecera.Rows(contador).Cells("Destinos").Value = RowRetorno.Item("Destinos").ToString.Trim
                    Dg_Cabecera.Rows(contador).Cells("M3").Value = RowRetorno.Item("M3").ToString.Trim
                    Dg_Cabecera.Rows(contador).Cells("Vehiculo").Value = RowRetorno.Item("Vehiculo").ToString.Trim
                    Dg_Cabecera.Rows(contador).Cells("Placa").Value = RowRetorno.Item("Placa").ToString.Trim
                    Dg_Cabecera.Rows(contador).Cells("Tiempo").Value = RowRetorno.Item("Tiempo").ToString.Trim
                    Dg_Cabecera.Rows(contador).Cells("Transportista").Value = RowRetorno.Item("Transportista").ToString.Trim
                    Dg_Cabecera.Rows(contador).Cells("CapacidadVehiculo").Value = RowRetorno.Item("CapacidadVehiculo").ToString.Trim
                    Dg_Cabecera.Rows(contador).Cells("Consolidado_Exclusivo").Value = RowRetorno.Item("Consolidado_Exclusivo").ToString.Trim


                    If CType(RowRetorno.Item("M3").ToString.Trim, Decimal) <> 0 And CType(RowRetorno.Item("CapacidadVehiculo").ToString.Trim, Decimal) <> 0 Then
                        Dg_Cabecera.Rows(contador).Cells("porcentajem3").Value = Math.Ceiling(CType(RowRetorno.Item("M3").ToString.Trim, Decimal) / CType(RowRetorno.Item("CapacidadVehiculo").ToString.Trim, Decimal) * 100).ToString + " %"
                    Else
                        Dg_Cabecera.Rows(contador).Cells("porcentajem3").Value = 0.ToString + " %"
                    End If
                    If CType(RowRetorno.Item("Tiempo").ToString.Trim, Decimal) <> 0 Then
                        Dg_Cabecera.Rows(contador).Cells("porcentajetiempo").Value = Math.Ceiling((CType(RowRetorno.Item("Tiempo").ToString.Trim, Decimal) / 8) * 100).ToString + " %"
                    Else
                        Dg_Cabecera.Rows(contador).Cells("porcentajetiempo").Value = 0.ToString + " %"
                    End If
                    'porcentajem3
                    '

                    contador = contador + 1
                Next
                txt_cant_Rutas.Text = Dg_Cabecera.Rows.Count.ToString

                'ColorearGrilla()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            ListarRutas()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub cmdGenerarExcel_Click(sender As Object, e As EventArgs) Handles cmdGenerarExcel.Click
        Try
            If Dg_Cabecera.Rows.Count > 0 Then
                For Each dgrow As DataGridViewRow In Dg_Cabecera.Rows
                    Dim rowAdd As DataRow = dtExcel.NewRow
                    rowAdd.Item("CodRuta") = dgrow.Cells("CodRuta").Value
                    rowAdd.Item("Fecha") = dgrow.Cells("Fecha").Value
                    rowAdd.Item("Guias") = dgrow.Cells("Guias").Value
                    rowAdd.Item("Destinos") = dgrow.Cells("Destinos").Value
                    rowAdd.Item("M3") = dgrow.Cells("M3").Value
                    rowAdd.Item("Vehiculo") = dgrow.Cells("Vehiculo").Value
                    rowAdd.Item("Placa") = dgrow.Cells("Placa").Value
                    rowAdd.Item("Tiempo") = dgrow.Cells("Tiempo").Value
                    rowAdd.Item("Transportista") = dgrow.Cells("Transportista").Value
                    rowAdd.Item("porcentajem3") = dgrow.Cells("porcentajem3").Value
                    rowAdd.Item("porcentajetiempo") = dgrow.Cells("porcentajetiempo").Value
                    rowAdd.Item("Consolidado_Exclusivo") = dgrow.Cells("Consolidado_Exclusivo").Value
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
            savedialog_Excel.FileName = "REPORTE RUTAS_" + dt_desde.Value.Day.ToString + "-" + dt_desde.Value.Month.ToString + "-" + dt_desde.Value.Year.ToString + "_" + dt_hasta.Value.Day.ToString + "-" + dt_hasta.Value.Month.ToString + "-" + dt_hasta.Value.Year.ToString
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