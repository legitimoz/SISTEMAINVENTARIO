Imports ClosedXML.Excel
Imports Nordic.Bl.Be

Public Class GestionLiquidacionDocumentaria
    Private dtcabecera2 As New DataTable
    Private Estructura As New EstructuraTabla
    Private ObjAlmacen As New AlmacenL
    Private CNUMDOC As String = "", CTD As String = "", CALMA As String = "", Estado As String = ""
    Private GUIA As String = ""
    Private Sub cmdCerrar_Click(sender As Object, e As EventArgs) Handles cmdCerrar.Click
        Me.Close()
    End Sub

    Private Sub CargaInicial()
        Try
            FormatoTablaCabecera()
        Catch ex As Exception

        End Try
    End Sub

    Public Sub ListarGuiasCabecera()
        Try
            Dim contadorL As Integer = 0, cantidadL As Integer = 0, ContadorP As Integer = 0, cantidadP As Integer = 0
            Dim dtretorno As New DataTable
            Dim contador As Integer = 0
            Dim cant As Integer = 0
            dtretorno = LlamarListarBaseLiquidacionDoc()
            If dtretorno.Rows.Count > 0 Then

                dtcabecera2.Rows.Clear()
                For Each RowRetorno As DataRow In dtretorno.Rows
                    Dim rowcabecera As DataRow
                    rowcabecera = dtcabecera2.NewRow
                    rowcabecera.Item("NRO_GUIA") = RowRetorno.Item("NRO_GUIA").ToString.Trim
                    GUIA = RowRetorno.Item("NRO_GUIA").ToString.Trim
                    rowcabecera.Item("FECHA_DESPACHO") = RowRetorno.Item("FECHA_DESPACHO").ToString.Trim
                    rowcabecera.Item("FECHA_RETORNO") = RowRetorno.Item("FECHA_RETORNO").ToString.Trim
                    rowcabecera.Item("RUC_CLIENTE") = RowRetorno.Item("RUC_CLIENTE").ToString.Trim
                    rowcabecera.Item("CLIENTE") = RowRetorno.Item("CLIENTE").ToString.Trim
                    rowcabecera.Item("DIRECCION_CLIENTE") = RowRetorno.Item("DIRECCION_CLIENTE").ToString.Trim
                    rowcabecera.Item("TRANSPORTISTA") = RowRetorno.Item("TRANSPORTISTA").ToString.Trim
                    rowcabecera.Item("LIM_PROV") = RowRetorno.Item("LIM_PROV").ToString.Trim
                    rowcabecera.Item("C5_CTD") = RowRetorno.Item("C5_CTD").ToString.Trim
                    rowcabecera.Item("C5_CALMA") = RowRetorno.Item("C5_CALMA").ToString.Trim
                    rowcabecera.Item("MOTIVO") = RowRetorno.Item("MOTIVO").ToString.Trim
                    rowcabecera.Item("AREA") = RowRetorno.Item("AREA").ToString.Trim
                    rowcabecera.Item("FACTURA TRANSPORTISTA") = RowRetorno.Item("FacturaTransportista").ToString.Trim


                    If RowRetorno.Item("PROVINCIA").ToString.Trim = "CAÑETE".Trim Or RowRetorno.Item("PROVINCIA").ToString.Trim = "HUARAL".Trim Or RowRetorno.Item("PROVINCIA").ToString.Trim = "HUAURA".Trim Then
                        rowcabecera.Item("LIM_PROV") = "PROVINCIA"
                    End If
                    'If GUIA = "0120014131" Then
                    '    Dim HOLA As Integer = 0
                    '    HOLA = 1
                    'End If
                    Dim Diferencia As Integer = 0
                    If RowRetorno.Item("FECHA_DESPACHO").ToString.Trim <> "" And RowRetorno.Item("FECHA_RETORNO").ToString.Trim <> "" Then
                        Diferencia = DateDiff(DateInterval.Day, Convert.ToDateTime(RowRetorno.Item("FECHA_DESPACHO").ToString.Trim), Convert.ToDateTime(RowRetorno.Item("FECHA_RETORNO").ToString.Trim))
                    ElseIf RowRetorno.Item("FECHA_DESPACHO").ToString.Trim <> "" And RowRetorno.Item("FECHA_RETORNO").ToString.Trim = "" Then
                        Diferencia = DateDiff(DateInterval.Day, Convert.ToDateTime(RowRetorno.Item("FECHA_DESPACHO")), Convert.ToDateTime(Now))
                        'Diferencia = DateDiff(DateInterval.Day, Convert.ToDateTime(Now), Convert.ToDateTime(Now))
                    End If

                    rowcabecera.Item("Diferencia") = Diferencia

                    Dim Tolerancia As Integer = 1

                    If rowcabecera.Item("LIM_PROV").ToString.Trim = "PROVINCIA" Then
                        'If RowRetorno.Item("HORA_DESPACHO").ToString.Trim > #12:00:00 PM# Then
                        '    Tolerancia = 2
                        'End If
                        Dim Serie As String = ""
                        Serie = RowRetorno.Item("NRO_GUIA").ToString.Trim.Substring(0, 3)
                        If Serie = "011" Then
                            Tolerancia = 8
                        ElseIf Serie = "012" Then
                            Tolerancia = 16
                        End If
                    End If
                    Dim fechadespacho As Date
                    fechadespacho = RowRetorno.Item("FECHA_DESPACHO").ToString.Trim

                    Dim DIA As Integer = 0
                    DIA = fechadespacho.DayOfWeek
                    If DIA = 6 Then
                        Tolerancia = Tolerancia + 1
                    End If

                    If RowRetorno.Item("TRANSPORTISTA").ToString.Trim = "NORDIC BASE LA VICTORIA".Trim Then
                        Tolerancia = 15
                    End If

                    rowcabecera.Item("Tolerancia") = Tolerancia

                    Dim Estado As String = ""
                    If Diferencia <= Tolerancia Then
                        Estado = "DENTRO DE TIEMPO"
                    ElseIf Diferencia > Tolerancia Then
                        Estado = "FUERA DE TIEMPO"
                    End If


                    rowcabecera.Item("ESTADO") = Estado
                    'rowcabecera.Item("ESTADO2") = Estado2


                    If rowcabecera.Item("ESTADO") IsNot Nothing Then
                        If rowcabecera.Item("ESTADO").ToString.Trim = "DENTRO DE TIEMPO" Then
                            contador = contador + 1
                        End If
                    End If

                    If rowcabecera.Item("LIM_PROV").ToString.Trim = "LIMA" Then
                        cantidadL = cantidadL + 1
                        If rowcabecera.Item("ESTADO").ToString.Trim = "DENTRO DE TIEMPO" Then
                            contadorL = contadorL + 1
                        End If
                    End If
                    If rowcabecera.Item("LIM_PROV").ToString.Trim = "PROVINCIA" Then
                        cantidadP = cantidadP + 1
                        If rowcabecera.Item("ESTADO").ToString.Trim = "DENTRO DE TIEMPO" Then
                            ContadorP = ContadorP + 1
                        End If
                    End If

                    dtcabecera2.Rows.Add(rowcabecera)
                Next
                cant = dtcabecera2.Rows.Count

                Dg_Cabecera.DataSource = dtcabecera2
                txt_Cantpedidos.Text = dtcabecera2.Rows.Count.ToString
                txt_cantatiempo.Text = contador.ToString
                txt_indicador.Text = CType((contador / cant) * 100, Integer).ToString + " %"
            Else
                dtcabecera2.Rows.Clear()
                txt_Cantpedidos.Text = "0"
                txt_cantatiempo.Text = "0"
                txt_indicador.Text = "0 %"
            End If

            If cantidadL <> 0 Then
                txt_cantlim.Text = cantidadL.ToString
                txt_dentrolim.Text = contadorL.ToString
                txt_indlima.Text = CType((contadorL / cantidadL) * 100, Integer).ToString + " %"
            Else
                txt_cantlim.Text = "0"
                txt_dentrolim.Text = "0"
                txt_indlima.Text = "0 %"
            End If

            If cantidadP <> 0 Then
                txt_cantpro.Text = cantidadP.ToString
                txt_dentropro.Text = ContadorP.ToString
                txt_indpro.Text = CType((ContadorP / cantidadP) * 100, Integer).ToString + " %"
            Else
                txt_cantpro.Text = "0"
                txt_dentropro.Text = "0"
                txt_indpro.Text = "0 %"
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Public Function LlamarListarBaseLiquidacionDoc() As DataTable
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
            dtretono = ObjAlmacen.ObtenerIndicarLiquidacionDocumentaria(fechadesde, fechahasta).Copy
        Catch ex As Exception
            Throw ex
        End Try
        Return dtretono
    End Function

    Private Sub GestionLiquidacionDocumentaria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CargaInicial()
        Catch ex As Exception

        End Try
    End Sub

    Public Sub FormatoTablaCabecera()

        dtcabecera2.Clear()
        dtcabecera2 = Estructura.IndicadorLiquidacionDocumentaria
        Dg_Cabecera.DataSource = dtcabecera2

        Dg_Cabecera.Columns("NRO_GUIA").HeaderText = "N° Guia"
        Dg_Cabecera.Columns("NRO_GUIA").Width = 70
        Dg_Cabecera.Columns("NRO_GUIA").ReadOnly = True

        Dg_Cabecera.Columns("FECHA_DESPACHO").HeaderText = "Fech. Despacho"
        Dg_Cabecera.Columns("FECHA_DESPACHO").Width = 100
        Dg_Cabecera.Columns("FECHA_DESPACHO").ReadOnly = True

        Dg_Cabecera.Columns("FECHA_RETORNO").HeaderText = "Fech. Retorno Ruta"
        Dg_Cabecera.Columns("FECHA_RETORNO").Width = 100
        Dg_Cabecera.Columns("FECHA_RETORNO").ReadOnly = True

        Dg_Cabecera.Columns("Diferencia").HeaderText = "Diferencia Días"
        Dg_Cabecera.Columns("Diferencia").Width = 70
        Dg_Cabecera.Columns("Diferencia").ReadOnly = True

        Dg_Cabecera.Columns("Tolerancia").HeaderText = "Tolerancia Días"
        Dg_Cabecera.Columns("Tolerancia").Width = 70
        Dg_Cabecera.Columns("Tolerancia").ReadOnly = True

        Dg_Cabecera.Columns("ESTADO").HeaderText = "Estado"
        Dg_Cabecera.Columns("ESTADO").Width = 100
        Dg_Cabecera.Columns("ESTADO").ReadOnly = True

        Dg_Cabecera.Columns("RUC_CLIENTE").HeaderText = "Ruc Cliente"
        Dg_Cabecera.Columns("RUC_CLIENTE").Width = 100
        Dg_Cabecera.Columns("RUC_CLIENTE").ReadOnly = True

        Dg_Cabecera.Columns("CLIENTE").HeaderText = "Cliente"
        Dg_Cabecera.Columns("CLIENTE").Width = 250
        Dg_Cabecera.Columns("CLIENTE").ReadOnly = True

        Dg_Cabecera.Columns("C5_CTD").HeaderText = "CTD"
        Dg_Cabecera.Columns("C5_CTD").Width = 250
        Dg_Cabecera.Columns("C5_CTD").Visible = False

        Dg_Cabecera.Columns("C5_CALMA").HeaderText = "CALMA"
        Dg_Cabecera.Columns("C5_CALMA").Width = 250
        Dg_Cabecera.Columns("C5_CALMA").Visible = False

        Dg_Cabecera.Columns("DIRECCION_CLIENTE").HeaderText = "Direccion Cliente"
        Dg_Cabecera.Columns("DIRECCION_CLIENTE").Width = 250
        Dg_Cabecera.Columns("DIRECCION_CLIENTE").ReadOnly = True

        Dg_Cabecera.Columns("TRANSPORTISTA").HeaderText = "Transportista"
        Dg_Cabecera.Columns("TRANSPORTISTA").Width = 120
        Dg_Cabecera.Columns("TRANSPORTISTA").ReadOnly = True

        Dg_Cabecera.Columns("LIM_PROV").HeaderText = "Lima Provincia"
        Dg_Cabecera.Columns("LIM_PROV").Width = 100
        Dg_Cabecera.Columns("LIM_PROV").ReadOnly = True

        Dg_Cabecera.Columns("MOTIVO").HeaderText = "Motivo"
        Dg_Cabecera.Columns("MOTIVO").Width = 80
        Dg_Cabecera.Columns("MOTIVO").ReadOnly = True

        Dg_Cabecera.Columns("AREA").HeaderText = "Area Responsable"
        Dg_Cabecera.Columns("AREA").Width = 80
        Dg_Cabecera.Columns("AREA").ReadOnly = True

        Dg_Cabecera.Columns("FACTURA TRANSPORTISTA").HeaderText = "FACTURA TRANSPORTISTA"
        Dg_Cabecera.Columns("FACTURA TRANSPORTISTA").Width = 80
        Dg_Cabecera.Columns("FACTURA TRANSPORTISTA").ReadOnly = True

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            ListarGuiasCabecera()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdGenerarExcel_Click(sender As Object, e As EventArgs) Handles cmdGenerarExcel.Click
        Try
            If dtcabecera2.Rows.Count > 0 Then
                ExportExcel(dtcabecera2)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function ExportExcel(ByVal dt As DataTable) As Boolean
        Dim RP As Boolean = False
        Dim wb As New XLWorkbook()
        Dim path As String

        Try
            savedialog_Excel.Filter = "Excel File(.xlsx)|*.xlsx"
            savedialog_Excel.Title = Text
            savedialog_Excel.FileName = "REPORTE LIQUIDACION DOCUMENTARIA " + Now.Day.ToString + "_" + Now.Month.ToString + "_" + Now.Year.ToString
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
    Public Sub Obtener()
        Try
            If Dg_Cabecera.Rows.Count > 0 Then
                CNUMDOC = Dg_Cabecera.CurrentRow.Cells("NRO_GUIA").EditedFormattedValue.ToString
                CTD = Dg_Cabecera.CurrentRow.Cells("C5_CTD").EditedFormattedValue.ToString
                CALMA = Dg_Cabecera.CurrentRow.Cells("C5_CALMA").EditedFormattedValue.ToString
                Estado = Dg_Cabecera.CurrentRow.Cells("ESTADO").EditedFormattedValue.ToString
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Try
            If Dg_Cabecera.Rows.Count > 0 Then
                Obtener()
                If Estado.Trim <> "DENTRO DE TIEMPO" Then
                    If CNUMDOC <> "" And CTD <> "" And CALMA <> "" Then
                        Dim RegistroForm As New RegistroObservacion
                        RegistroForm.cnumdoc = CNUMDOC
                        RegistroForm.ctd = CTD
                        RegistroForm.calma = CALMA
                        RegistroForm.tipoobservacion = 3
                        RegistroForm.ShowDialog()
                        If RegistroForm.grabado = True Then
                            ListarGuiasCabecera()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class