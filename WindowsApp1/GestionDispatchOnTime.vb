Imports ClosedXML.Excel
Imports Nordic.Bl.Be

Public Class GestionDispatchOnTime

    Private dtcabecera2, dtcabecera As New DataTable
    Public Estructura As New EstructuraTabla
    Private ObjAlmacen As New AlmacenL
    Public CALMA, CTD, CNUMDOC, estado As String

    Private Sub GestionDispatchOnTime_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CargaInicial()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CargaInicial()
        Try
            cmb_filtro.SelectedIndex = 0
            FormatoTablaCabecera()
            'ListarGuiasCabecera()
        Catch ex As Exception

        End Try
    End Sub


    Public Function LlamarPedidosPickin() As DataTable
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
            dtretono = ObjAlmacen.ObtenerIndicarDIspatchOnTime(fechadesde, fechahasta).Copy
        Catch ex As Exception
            Throw ex
        End Try
        Return dtretono
    End Function

    Public Sub ListarGuiasCabecera()

        Try
            Dim contadorL As Integer = 0, cantidadL As Integer = 0, ContadorP As Integer = 0, cantidadP As Integer = 0
            Dim dtretorno As New DataTable
            Dim contador As Integer = 0
            Dim cant As Integer = 0
            dtretorno = LlamarPedidosPickin()
            If dtretorno.Rows.Count > 0 Then
                dtcabecera.Rows.Clear()
                dtcabecera = dtretorno
                dtcabecera2.Rows.Clear()
                For Each RowRetorno As DataRow In dtretorno.Rows

                    Dim rowcabecera As DataRow
                    rowcabecera = dtcabecera2.NewRow

                    'Tabladetalle.Columns.Add("NRO_GUIA", GetType(String))
                    'Tabladetalle.Columns.Add("FECHA_RECEPCION", GetType(String))
                    'Tabladetalle.Columns.Add("HORA_RECEPCION", GetType(String))
                    'Tabladetalle.Columns.Add("FECHA_DESPACHO", GetType(String))
                    'Tabladetalle.Columns.Add("Diferencia", GetType(String))
                    'Tabladetalle.Columns.Add("ESTADO", GetType(String))
                    'Tabladetalle.Columns.Add("CLIENTE", GetType(String))
                    'Tabladetalle.Columns.Add("LIM_PROV", GetType(String))
                    'Tabladetalle.Columns.Add("MOTIVO", GetType(String))
                    'Tabladetalle.Columns.Add("AREA", GetType(String))

                    rowcabecera.Item("NRO_GUIA") = RowRetorno.Item("NRO_GUIA").ToString.Trim
                    rowcabecera.Item("FECHA_RECEPCION") = RowRetorno.Item("FECHA_RECEPCION").ToString.Trim
                    rowcabecera.Item("HORA_RECEPCION") = RowRetorno.Item("HORA_RECEPCION").ToString.Trim
                    rowcabecera.Item("FECHA_DESPACHO") = RowRetorno.Item("FECHA_DESPACHO").ToString.Trim
                    rowcabecera.Item("CLIENTE") = RowRetorno.Item("CLIENTE").ToString.Trim
                    rowcabecera.Item("LIM_PROV") = RowRetorno.Item("LIM_PROV").ToString.Trim
                    rowcabecera.Item("MOTIVO") = RowRetorno.Item("MOTIVO").ToString.Trim
                    rowcabecera.Item("AREA") = RowRetorno.Item("AREA").ToString.Trim
                    rowcabecera.Item("TRANSPORTISTA") = RowRetorno.Item("TRANSPORTISTA").ToString.Trim
                    rowcabecera.Item("DIRECCION_CLIENTE") = RowRetorno.Item("DIRECCION_CLIENTE").ToString.Trim
                    rowcabecera.Item("RUC_CLIENTE") = RowRetorno.Item("RUC_CLIENTE").ToString.Trim

                    Dim Diferencia As Integer = 0
                    Diferencia = DateDiff(DateInterval.Day, Convert.ToDateTime(RowRetorno.Item("FECHA_RECEPCION").ToString.Trim), Convert.ToDateTime(RowRetorno.Item("FECHA_DESPACHO").ToString.Trim))
                    rowcabecera.Item("Diferencia") = Diferencia
                    Dim Tolerancia As Integer = 1

                    If RowRetorno.Item("LIM_PROV").ToString.Trim = "LIMA" Then
                        If RowRetorno.Item("HORA_RECEPCION").ToString.Trim > #04:30:00 PM# Then
                            Tolerancia = 2
                        End If
                    End If

                    If RowRetorno.Item("LIM_PROV").ToString.Trim = "PROVINCIA" Then
                        If RowRetorno.Item("HORA_RECEPCION").ToString.Trim > #12:00:00 PM# Then
                            Tolerancia = 2
                        End If
                    End If

                    rowcabecera.Item("Tolerancia") = Tolerancia

                    Dim Estado As String = ""
                    If Diferencia <= Tolerancia Then
                        Estado = "DENTRO DE TIEMPO"
                    ElseIf Diferencia > Tolerancia Then
                        Estado = "FUERA DE TIEMPO"
                    End If

                    rowcabecera.Item("ESTADO") = Estado

                    If rowcabecera.Item("ESTADO").ToString.Trim = "DENTRO DE TIEMPO" Then
                        contador = contador + 1
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

    Public Sub Obtener()
        Try
            If Dg_Cabecera.Rows.Count > 0 Then
                CNUMDOC = Dg_Cabecera.CurrentRow.Cells("NRO_GUIA").EditedFormattedValue.ToString
                CTD = Dg_Cabecera.CurrentRow.Cells("CTD").EditedFormattedValue.ToString
                CALMA = Dg_Cabecera.CurrentRow.Cells("CALMA").EditedFormattedValue.ToString
                estado = Dg_Cabecera.CurrentRow.Cells("ESTADO").EditedFormattedValue.ToString
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        ListarGuiasCabecera()

    End Sub

    Private Sub cmb_filtro_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmb_filtro.SelectionChangeCommitted
        Try
            Buscar()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Buscar()
        Dim contador As Integer = 0
        Dim cant As Integer = 0
        Dim contadorL As Integer = 0, cantidadL As Integer = 0, ContadorP As Integer = 0, cantidadP As Integer = 0
        Try

            If Dg_Cabecera.Rows.Count > 0 Then
                For Each RowCab As DataRow In dtcabecera2.Rows
                    If cmb_filtro.SelectedIndex = 1 Then
                        If RowCab.Item("ESTADO") IsNot Nothing Then
                            If RowCab.Item("ESTADO").ToString.Trim = "DENTRO DE TIEMPO" Or RowCab.Item("AREA").ToString.Trim = "LOGISTICO" Then
                                contador = contador + 1
                            End If
                            If RowCab.Item("LIM_PROV").ToString.Trim = "LIMA" Then
                                cantidadL = cantidadL + 1
                                If RowCab.Item("ESTADO").ToString.Trim = "DENTRO DE TIEMPO" Or RowCab.Item("AREA").ToString.Trim = "LOGISTICO" Then
                                    contadorL = contadorL + 1
                                End If
                            End If
                            If RowCab.Item("LIM_PROV").ToString.Trim = "PROVINCIA" Then
                                cantidadP = cantidadP + 1
                                If RowCab.Item("ESTADO").ToString.Trim = "DENTRO DE TIEMPO" Or RowCab.Item("AREA").ToString.Trim = "LOGISTICO" Then
                                    ContadorP = ContadorP + 1
                                End If
                            End If
                        End If
                    Else
                        If cmb_filtro.SelectedIndex = 0 Then
                            If RowCab.Item("ESTADO") IsNot Nothing Then
                                If RowCab.Item("ESTADO").ToString.Trim = "DENTRO DE TIEMPO" Then
                                    contador = contador + 1
                                End If
                            End If
                            If RowCab.Item("LIM_PROV").ToString.Trim = "LIMA" Then
                                cantidadL = cantidadL + 1
                                If RowCab.Item("ESTADO").ToString.Trim = "DENTRO DE TIEMPO" Then
                                    contadorL = contadorL + 1
                                End If
                            End If
                            If RowCab.Item("LIM_PROV").ToString.Trim = "PROVINCIA" Then
                                cantidadP = cantidadP + 1
                                If RowCab.Item("ESTADO").ToString.Trim = "DENTRO DE TIEMPO" Then
                                    ContadorP = ContadorP + 1
                                End If
                            End If
                        End If
                    End If
                Next

                cant = dtcabecera2.Rows.Count
                txt_Cantpedidos.Text = dtcabecera2.Rows.Count.ToString
                txt_cantatiempo.Text = contador.ToString
                txt_indicador.Text = CType((contador / cant) * 100, Integer).ToString + " %"

            Else
                ' dtcabecera2.Rows.Clear()
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

    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        Try
            'Me.Cursor = Cursors.WaitCursor
            'GridAExcel(Dg_Cabecera)
            'Me.Cursor = Cursors.Default
            If dtcabecera2.Rows.Count > 0 Then
                ExportExcel(dtcabecera2)
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
            savedialog_Excel.FileName = "REPORTE DISPATCH ON TIME"
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

    Function GridAExcel(ByVal ElGrid As DataGridView) As Boolean

        Dim exApp As Object
        Dim exLibro As Object
        Dim exHoja As Object

        exApp = CreateObject("Excel.Application")
        exHoja = exApp.ActiveSheet
        Try

            exLibro = exApp.Workbooks.Add()
            exHoja = exLibro.Worksheets(1)
            Dim NCol As Integer = ElGrid.ColumnCount
            Dim NRow As Integer = ElGrid.RowCount
            For i As Integer = 1 To NCol
                exHoja.Cells.Item(1, i) = ElGrid.Columns(i - 1).HeaderText.ToString()
            Next

            Dim fecha As String = String.Empty

            For Fila As Integer = 0 To NRow - 1
                For Col As Integer = 0 To NCol - 1
                    If Col = 3 Then
                        fecha = "'" & CStr(ElGrid.Rows(Fila).Cells(Col).Value)
                        exHoja.Cells.Item(Fila + 2, Col + 1) = CStr(ElGrid.Rows(Fila).Cells(Col).Value)
                    Else
                        If Col = 2 Or Col = 14 Or Col = 15 Or Col = 16 Or Col = 17 Then
                            exHoja.Cells.Item(Fila + 2, Col + 1) = ElGrid.Rows(Fila).Cells(Col).Value
                        Else
                            exHoja.Cells.Item(Fila + 2, Col + 1) = CStr(ElGrid.Rows(Fila).Cells(Col).Value)
                        End If
                    End If
                Next
            Next

            exHoja.Rows.Item(1).Font.Bold = 1
            exHoja.Rows.Item(1).HorizontalAlignment = 3
            exHoja.Columns.AutoFit()
            exHoja.Rows.AutoFit()
            exApp.Application.Visible = True
            exHoja = Nothing
            exLibro = Nothing
            exApp = Nothing

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")
            Return False
        End Try

        Return True

    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If Dg_Cabecera.Rows.Count > 0 Then
                Obtener()
                If estado.Trim <> "DENTRO DE TIEMPO" Then
                    If CNUMDOC <> "" And CTD <> "" And CALMA <> "" Then
                        Dim RegistroForm As New RegistroObservacion
                        RegistroForm.cnumdoc = CNUMDOC
                        RegistroForm.ctd = CTD
                        RegistroForm.calma = CALMA
                        RegistroForm.tipoobservacion = 1
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

    Public Sub FormatoTablaCabecera()

        dtcabecera2.Clear()
        dtcabecera2 = Estructura.IndicadorDispatchOnTime
        Dg_Cabecera.DataSource = dtcabecera2



        Dg_Cabecera.Columns("NRO_GUIA").HeaderText = "Nro Guia"
        Dg_Cabecera.Columns("NRO_GUIA").Width = 70
        Dg_Cabecera.Columns("NRO_GUIA").ReadOnly = True

        Dg_Cabecera.Columns("FECHA_RECEPCION").HeaderText = "Fech. Recep Guia"
        Dg_Cabecera.Columns("FECHA_RECEPCION").Width = 100
        Dg_Cabecera.Columns("FECHA_RECEPCION").ReadOnly = True

        Dg_Cabecera.Columns("TRANSPORTISTA").HeaderText = "Transportistas"
        Dg_Cabecera.Columns("TRANSPORTISTA").Width = 100
        Dg_Cabecera.Columns("TRANSPORTISTA").ReadOnly = True

        Dg_Cabecera.Columns("RUC_CLIENTE").HeaderText = "Ruc Cliente"
        Dg_Cabecera.Columns("RUC_CLIENTE").Width = 100
        Dg_Cabecera.Columns("RUC_CLIENTE").ReadOnly = True

        Dg_Cabecera.Columns("DIRECCION_CLIENTE").HeaderText = "Dirección Cliente"
        Dg_Cabecera.Columns("DIRECCION_CLIENTE").Width = 100
        Dg_Cabecera.Columns("DIRECCION_CLIENTE").ReadOnly = True

        Dg_Cabecera.Columns("HORA_RECEPCION").HeaderText = "Hora Recep Guia"
        Dg_Cabecera.Columns("HORA_RECEPCION").Width = 100
        Dg_Cabecera.Columns("HORA_RECEPCION").ReadOnly = True

        Dg_Cabecera.Columns("FECHA_DESPACHO").HeaderText = "Fecha Despacho"
        Dg_Cabecera.Columns("FECHA_DESPACHO").Width = 100
        Dg_Cabecera.Columns("FECHA_DESPACHO").ReadOnly = True

        Dg_Cabecera.Columns("Diferencia").HeaderText = "Diferencia en Dias"
        Dg_Cabecera.Columns("Diferencia").Width = 100
        Dg_Cabecera.Columns("Diferencia").ReadOnly = True


        Dg_Cabecera.Columns("Tolerancia").HeaderText = "Tolerancia Dias"
        Dg_Cabecera.Columns("Tolerancia").Width = 100
        Dg_Cabecera.Columns("Tolerancia").ReadOnly = True

        Dg_Cabecera.Columns("ESTADO").HeaderText = "Estado Despacho"
        Dg_Cabecera.Columns("ESTADO").Width = 100
        Dg_Cabecera.Columns("ESTADO").ReadOnly = True

        Dg_Cabecera.Columns("CLIENTE").HeaderText = "Cliente"
        Dg_Cabecera.Columns("CLIENTE").Width = 100
        Dg_Cabecera.Columns("CLIENTE").ReadOnly = True

        Dg_Cabecera.Columns("LIM_PROV").HeaderText = "Lima Provincia"
        Dg_Cabecera.Columns("LIM_PROV").Width = 100
        Dg_Cabecera.Columns("LIM_PROV").ReadOnly = True

        Dg_Cabecera.Columns("MOTIVO").HeaderText = "Motivo"
        Dg_Cabecera.Columns("MOTIVO").Width = 200
        Dg_Cabecera.Columns("MOTIVO").ReadOnly = True

        Dg_Cabecera.Columns("AREA").HeaderText = "Area Responsable"
        Dg_Cabecera.Columns("AREA").Width = 100
        Dg_Cabecera.Columns("AREA").ReadOnly = True

    End Sub

End Class