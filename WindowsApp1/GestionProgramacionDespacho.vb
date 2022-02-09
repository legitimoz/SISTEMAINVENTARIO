Imports ClosedXML.Excel
Imports Nordic.Bl.Be

Public Class GestionProgramacionDespacho
    Public usr_usuario, cnumdoc, ctd, calma, estadoOB As String
    Public usr_id As Integer
    Public Estructura As New EstructuraTabla
    Private ObjAlmacen As New AlmacenL
    Private dtcabecera2, dtcabecera, dtTiempos, dtrutas, dtConsolidar, DtDetalleConsolidado As New DataTable


    Private Sub GestionProgramacionDespacho_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CargaInicial()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CargaInicial()
        Try
            cmb_serie.SelectedIndex = 0
            dtConsolidar = Estructura.TablaConsolidadaDestino
            DtDetalleConsolidado = Estructura.DetalleConsolidado
            CheckMarcar.Checked = True
            Me.Text = "Programacion Despacho"
            ListarTiemposEspera()
            ListarRutas()
            '  FormatoTablaCabecera()
            ListarGuiasCabecera()
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
            savedialog_Excel.FileName = "PEDIDOS DESPACHO" + Text
            dt.TableName = "PEDIDOS"
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

    Public Function LlamarPedidosDespacho() As DataTable
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
            dtretono = ObjAlmacen.ListarPedidosDespacho(fechadesde, fechahasta).Copy
        Catch ex As Exception
            Throw ex
        End Try
        Return dtretono
    End Function

    Public Sub ListarTiemposEspera()
        Try
            Dim dtretnor As New DataTable
            dtretnor = ObjAlmacen.ListarTiemposEntrega
            If dtretnor.Rows.Count > 0 Then
                dtTiempos = dtretnor
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Sub ListarRutas()
        Try
            Dim dtretnor As New DataTable
            dtretnor = ObjAlmacen.ListarRutas
            If dtretnor.Rows.Count > 0 Then
                dtrutas = dtretnor
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Public Sub ListarGuiasCabecera()
        Try
            If Dg_Cabecera.Rows.Count > 0 Then
                Dg_Cabecera.Rows.Clear()
            End If
            Dim dtretorno As New DataTable
            dtretorno = LlamarPedidosDespacho()
            If dtretorno.Rows.Count > 0 Then
                Dim contador As Integer = 0
                For Each RowRetorno As DataRow In dtretorno.Rows
                    Dg_Cabecera.Rows.Add()
                    Dg_Cabecera.Rows(contador).Cells("MARCAR").Value = False
                    Dg_Cabecera.Rows(contador).Cells("FECHA").Value = RowRetorno.Item("FECHA").ToString.Trim
                    Dg_Cabecera.Rows(contador).Cells("REPRESENTANTE").Value = RowRetorno.Item("REPRESENTANTE").ToString.Trim
                    Dg_Cabecera.Rows(contador).Cells("FECHA_GUIA").Value = RowRetorno.Item("FECHA_GUIA").ToString.Trim
                    Dg_Cabecera.Rows(contador).Cells("HORA").Value = RowRetorno.Item("HORA").ToString.Trim
                    Dg_Cabecera.Rows(contador).Cells("CONDICION").Value = RowRetorno.Item("DESCRIP_PED").ToString.Trim
                    Dg_Cabecera.Rows(contador).Cells("HORA_GUIA").Value = RowRetorno.Item("HORA_GUIA").ToString.Trim
                    Dg_Cabecera.Rows(contador).Cells("COD_PED").Value = RowRetorno.Item("COD_PED").ToString.Trim
                    Dg_Cabecera.Rows(contador).Cells("NRO_GUIA").Value = RowRetorno.Item("NRO_GUIA").ToString.Trim
                    Dg_Cabecera.Rows(contador).Cells("RUC").Value = RowRetorno.Item("RUC").ToString.Trim
                    Dg_Cabecera.Rows(contador).Cells("NOM_CLIENTE").Value = RowRetorno.Item("NOM_CLIENTE").ToString.Trim
                    Dg_Cabecera.Rows(contador).Cells("DIRECCION_ENTREGA").Value = RowRetorno.Item("DIRECCION_ENTREGA").ToString.Trim
                    Dg_Cabecera.Rows(contador).Cells("UBIGEO").Value = RowRetorno.Item("UBIGEO").ToString.Trim
                    Dg_Cabecera.Rows(contador).Cells("PROVINCIA").Value = RowRetorno.Item("PROVINCIA").ToString.Trim
                    Dg_Cabecera.Rows(contador).Cells("DEPARTAMENTO").Value = RowRetorno.Item("DEPARTAMENTO").ToString.Trim
                    Dg_Cabecera.Rows(contador).Cells("ESTADO").Value = RowRetorno.Item("ESTADO_RECEP").ToString.Trim
                    Dg_Cabecera.Rows(contador).Cells("SERIE").Value = RowRetorno.Item("SERIE").ToString.Trim
                    Dg_Cabecera.Rows(contador).Cells("COMENTARIO").Value = RowRetorno.Item("COMENTARIO").ToString.Trim
                    Dg_Cabecera.Rows(contador).Cells("SITUACION").Value = RowRetorno.Item("SITUACION").ToString.Trim

                    Dg_Cabecera.Rows(contador).Cells("C5_CTD").Value = RowRetorno.Item("C5_CTD").ToString.Trim

                    Dg_Cabecera.Rows(contador).Cells("C5_CALMA").Value = RowRetorno.Item("C5_CALMA").ToString.Trim

                    If Dg_Cabecera.Rows(contador).Cells("ESTADO").Value.ToString.Trim = "PENDIENTE DE REPCEPCION" Then
                        Dg_Cabecera.Rows(contador).DefaultCellStyle.BackColor = Color.LightPink
                    Else
                        If Dg_Cabecera.Rows(contador).Cells("ESTADO").Value.ToString.Trim = "RECEPCIONADO" Then
                            Dg_Cabecera.Rows(contador).DefaultCellStyle.BackColor = Color.LightGreen
                        Else
                            If Dg_Cabecera.Rows(contador).Cells("ESTADO").Value.ToString.Trim = "REPROGRAMADO" Then
                                Dg_Cabecera.Rows(contador).DefaultCellStyle.BackColor = Color.LightBlue
                            End If
                        End If
                    End If
                    If RowRetorno.Item("PROVINCIA").ToString.Trim = "CALLAO" And RowRetorno.Item("DEPARTAMENTO").ToString = "CALLAO" Then
                        Dg_Cabecera.Rows(contador).Cells("LIMA_PROV").Value = "LIMA"
                    Else
                        If RowRetorno.Item("PROVINCIA").ToString.Trim = "LIMA" And RowRetorno.Item("DEPARTAMENTO").ToString = "LIMA" Then
                            Dg_Cabecera.Rows(contador).Cells("LIMA_PROV").Value = "LIMA"
                        Else
                            Dg_Cabecera.Rows(contador).Cells("LIMA_PROV").Value = "PROVINCIA"
                        End If
                    End If
                    Dg_Cabecera.Rows(contador).Cells("DISTRITO").Value = RowRetorno.Item("DISTRITO").ToString.Trim
                    Dg_Cabecera.Rows(contador).Cells("CANAL").Value = RowRetorno.Item("CANAL").ToString.Trim

                    If RowRetorno.Item("RUC").ToString.Trim = "20131257750" And RowRetorno.Item("DIRECCION_ENTREGA").ToString.Trim = "PJE. EL SOL 400 CDRA 35 AV. ARGENTINA - CALLAO - CALLAO - CALLAO" Then
                        Dg_Cabecera.Rows(contador).Cells("CANAL").Value = "SALOG"
                    Else
                        If RowRetorno.Item("RUC").ToString.Trim = "20556281140" Then
                            Dg_Cabecera.Rows(contador).Cells("CANAL").Value = "IBT"
                        Else
                            If RowRetorno.Item("RUC").ToString.Trim = "20601054001" Then
                                Dg_Cabecera.Rows(contador).Cells("CANAL").Value = "ISCO"
                            Else
                                If RowRetorno.Item("RUC").ToString.Trim = "20399497257" Then
                                    Dg_Cabecera.Rows(contador).Cells("CANAL").Value = "DISTRIBUIDOR"
                                End If
                            End If
                        End If
                    End If

                    Dg_Cabecera.Rows(contador).Cells("TRANSPORTE").Value = RowRetorno.Item("TRANSPORTE").ToString.Trim
                    Dg_Cabecera.Rows(contador).Cells("M3UN").Value = CType(RowRetorno.Item("M3UN").ToString, Decimal)
                    Dg_Cabecera.Rows(contador).Cells("IMPORTE").Value = CType(RowRetorno.Item("IMPORTE").ToString, Decimal)
                    Dg_Cabecera.Rows(contador).Cells("TIEMPOENTREGA").Value = ObtenerTiempoEntrega(Dg_Cabecera.Rows(contador).Cells("CANAL").Value.ToString.Trim)


                    If Dg_Cabecera.Rows(contador).Cells("M3UN").Value <> 0 Then
                        Dim cal As Decimal = 0
                        cal = 0.012 / 3
                        If Dg_Cabecera.Rows(contador).Cells("M3UN").Value < cal Then
                            Dg_Cabecera.Rows(contador).Cells("M3FIN").Value = 0.005
                        Else
                            Dg_Cabecera.Rows(contador).Cells("M3FIN").Value = Dg_Cabecera.Rows(contador).Cells("M3UN").Value * 1.4
                        End If
                    Else
                        Dg_Cabecera.Rows(contador).Cells("M3FIN").Value = 0
                    End If

                    Dg_Cabecera.Rows(contador).Cells("DESTINO").Value = Dg_Cabecera.Rows(contador).Cells("FECHA_GUIA").Value.ToString + " " + Dg_Cabecera.Rows(contador).Cells("DIRECCION_ENTREGA").Value.ToString

                    Dim RP As New List(Of String)
                    RP = ObtenerRuta(Dg_Cabecera.Rows(contador).Cells("DISTRITO").Value.ToString.Trim)
                    If RP.Count > 0 Then
                        Dg_Cabecera.Rows(contador).Cells("RUTA").Value = RP.ElementAt(0)
                        Dg_Cabecera.Rows(contador).Cells("DETALLE").Value = RP.ElementAt(1)
                    End If

                    If Dg_Cabecera.Rows(contador).Cells("CANAL").Value.ToString.Trim = "SALOG" Then
                        Dg_Cabecera.Rows(contador).Cells("RESTRICCION").Value = "Cita - TODO EL DIA"
                    Else
                        If Dg_Cabecera.Rows(contador).Cells("CANAL").Value.ToString.Trim = "IBT" And Dg_Cabecera.Rows(contador).Cells("DISTRITO").Value.ToString.Trim = "PUNTA HERMOSA" Then
                            Dg_Cabecera.Rows(contador).Cells("RESTRICCION").Value = "Cita - atencion hasta las 3 PM"
                        Else
                            If Dg_Cabecera.Rows(contador).Cells("DISTRITO").Value.ToString.Trim = "CHORRILLOS" And Dg_Cabecera.Rows(contador).Cells("RUC").Value.ToString.Trim = "20604890617" And Dg_Cabecera.Rows(contador).Cells("CANAL").Value.ToString.Trim = "INKAFARMA/MIFARMA" Then
                                Dg_Cabecera.Rows(contador).Cells("RESTRICCION").Value = "Cita - Exclusiva"
                            Else
                                If Dg_Cabecera.Rows(contador).Cells("DISTRITO").Value.ToString.Trim = "SANTA ANITA" And Dg_Cabecera.Rows(contador).Cells("RUC").Value.ToString.Trim = "20604890617" And Dg_Cabecera.Rows(contador).Cells("CANAL").Value.ToString.Trim = "INKAFARMA/MIFARMA" Then
                                    Dg_Cabecera.Rows(contador).Cells("RESTRICCION").Value = "Cita"
                                Else
                                    If Dg_Cabecera.Rows(contador).Cells("DISTRITO").Value.ToString.Trim = "SANTA ANITA" And Dg_Cabecera.Rows(contador).Cells("RUC").Value.ToString.Trim = "20100054184" And Dg_Cabecera.Rows(contador).Cells("CANAL").Value.ToString.Trim = "CLINICAS TOP" Then
                                        Dg_Cabecera.Rows(contador).Cells("RESTRICCION").Value = "Cita - atencion hasta las 2 p.m."
                                    Else
                                        If Dg_Cabecera.Rows(contador).Cells("CANAL").Value.ToString.Trim = "HORIZONTAL" Then
                                            Dg_Cabecera.Rows(contador).Cells("RESTRICCION").Value = "S/R"
                                        Else
                                            If Dg_Cabecera.Rows(contador).Cells("CANAL").Value.ToString.Trim = "HORIZONTAL" And Dg_Cabecera.Rows(contador).Cells("RUC").Value.ToString.Trim = "20524524067" Then
                                                Dg_Cabecera.Rows(contador).Cells("RESTRICCION").Value = "LUNES A VIERNES 8AM A 5PM"
                                            Else
                                                If Dg_Cabecera.Rows(contador).Cells("CANAL").Value.ToString.Trim = "CLINICAS" And Dg_Cabecera.Rows(contador).Cells("RUC").Value.ToString.Trim = "20101267467" Then
                                                    Dg_Cabecera.Rows(contador).Cells("RESTRICCION").Value = "LUNES A VIERNES 8:00 AM A 1:00 PM"
                                                Else
                                                    If Dg_Cabecera.Rows(contador).Cells("CANAL").Value.ToString.Trim = "CLINICAS" And Dg_Cabecera.Rows(contador).Cells("RUC").Value.ToString.Trim = "20100251176" Then
                                                        Dg_Cabecera.Rows(contador).Cells("RESTRICCION").Value = "LUNES A VIERNES 8AM A 5PM"
                                                    Else
                                                        If Dg_Cabecera.Rows(contador).Cells("CANAL").Value.ToString.Trim = "HORIZONTAL" And Dg_Cabecera.Rows(contador).Cells("RUC").Value.ToString.Trim = "20263805021" Then
                                                            Dg_Cabecera.Rows(contador).Cells("RESTRICCION").Value = "LUNES A VIERNES 8AM A 6PM"
                                                        Else
                                                            If Dg_Cabecera.Rows(contador).Cells("CANAL").Value.ToString.Trim = "HORIZONTAL" And Dg_Cabecera.Rows(contador).Cells("RUC").Value.ToString.Trim = "20544478096" Then
                                                                Dg_Cabecera.Rows(contador).Cells("RESTRICCION").Value = "LUNES A VIERNES 8AM A 6PM"
                                                            Else
                                                                If Dg_Cabecera.Rows(contador).Cells("DISTRITO").Value.ToString.Trim = "LINCE" And Dg_Cabecera.Rows(contador).Cells("RUC").Value.ToString.Trim = "20492080811" Then
                                                                    Dg_Cabecera.Rows(contador).Cells("RESTRICCION").Value = "LUNES A VIERNES DE 08:30 AM HASTA LAS 04:00 PM"
                                                                Else
                                                                    If Dg_Cabecera.Rows(contador).Cells("DISTRITO").Value.ToString.Trim = "MIRAFLORES" And Dg_Cabecera.Rows(contador).Cells("RUC").Value.ToString.Trim = "20492080811" Then
                                                                        Dg_Cabecera.Rows(contador).Cells("RESTRICCION").Value = "LUNES A VIERNES DE 08:30 AM HASTA LAS 12:30 PM"
                                                                    Else
                                                                        If Dg_Cabecera.Rows(contador).Cells("DISTRITO").Value.ToString.Trim = "BREÑA" And Dg_Cabecera.Rows(contador).Cells("RUC").Value.ToString.Trim = "20131368403" Then
                                                                            Dg_Cabecera.Rows(contador).Cells("RESTRICCION").Value = "LUNES A SABADO DE 08:00 AM HASTA LAS 02:00 PM"
                                                                        Else
                                                                            If Dg_Cabecera.Rows(contador).Cells("DISTRITO").Value.ToString.Trim = "MAGDALENA DEL MAR" And Dg_Cabecera.Rows(contador).Cells("RUC").Value.ToString.Trim = "20159855938" Then
                                                                                Dg_Cabecera.Rows(contador).Cells("RESTRICCION").Value = "LUNES A VIERNES DE 08:00 AM HASTA LAS 12:00 PM"
                                                                            Else
                                                                                If Dg_Cabecera.Rows(contador).Cells("DISTRITO").Value.ToString.Trim = "LIMA" And Dg_Cabecera.Rows(contador).Cells("RUC").Value.ToString.Trim = "20100025168" Then
                                                                                    Dg_Cabecera.Rows(contador).Cells("RESTRICCION").Value = "LUNES A SABADO DE 08:00 AM HASTA LAS 02:00 PM"
                                                                                Else
                                                                                    If Dg_Cabecera.Rows(contador).Cells("DISTRITO").Value.ToString.Trim = "JESUS MARIA" And Dg_Cabecera.Rows(contador).Cells("RUC").Value.ToString.Trim = "20101267467" Then
                                                                                        Dg_Cabecera.Rows(contador).Cells("RESTRICCION").Value = "LUNES A VIERNES DE 08:30 AM HASTA LAS 11:30 AM"
                                                                                    Else
                                                                                        If Dg_Cabecera.Rows(contador).Cells("DISTRITO").Value.ToString.Trim = "LIMA" And Dg_Cabecera.Rows(contador).Cells("RUC").Value.ToString.Trim = "20562616561" Then
                                                                                            'Dim nombredia As String = Date.Now.ToString("dddd").Trim
                                                                                            'If nombredia = "Lunes" Then
                                                                                            Dg_Cabecera.Rows(contador).Cells("RESTRICCION").Value = "LUNES 02:00 PM HASTA 05:00 PM / MIERCOLES 09:00 AM HASTA 12:00 AM / VIERNES  09:00 AM HASTA 12:00 AM"
                                                                                            'End If
                                                                                        Else
                                                                                            Dg_Cabecera.Rows(contador).Cells("RESTRICCION").Value = "S/R"
                                                                                        End If
                                                                                    End If
                                                                                End If
                                                                            End If
                                                                        End If
                                                                    End If
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                    contador = contador + 1
                Next

                'ColorearGrilla()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function ObtenerTiempoEntrega(Canal As String) As Decimal
        Dim RP As Decimal = 0
        Try
            If dtTiempos.Rows.Count > 0 Then
                For Each rowti As DataRow In dtTiempos.Rows
                    If rowti.Item("tie_canal").ToString.Trim = Canal Then
                        RP = rowti.Item("tie_tiempoentrega")
                        Exit For
                    End If
                Next
            End If
        Catch ex As Exception
            Throw ex
        End Try
        Return RP
    End Function


    Public Function ObtenerRuta(Distrito As String) As List(Of String)
        Dim RP As New List(Of String)
        Try
            If dtrutas.Rows.Count > 0 Then
                For Each rowti As DataRow In dtrutas.Rows
                    If rowti.Item("DISTRITO").ToString.Trim = Distrito Then
                        RP.Add(rowti.Item("RUTA"))
                        RP.Add(rowti.Item("DETALLE"))
                        Exit For
                    End If
                Next
            End If
            If RP.Count = 0 Then
                RP.Add("")
                RP.Add("")
            Else

            End If
        Catch ex As Exception
            Throw ex
        End Try
        Return RP
    End Function

    Private Sub btnBuscar_Click_1(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            ListarGuiasCabecera()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdGenerarExcel_Click(sender As Object, e As EventArgs) Handles cmdGenerarExcel.Click
        Try
            ProcesoExportar()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ProcesoExportar()

        Try
            If dtcabecera2.Rows.Count > 0 Then
                Dim DtExel As New DataTable
                DtExel = Estructura.ExcelProgramacionDespacho
                Dim RowExcel As DataRow
                For Each Rowcab As DataRow In dtcabecera2.Rows
                    If Rowcab.Item("MARCAR") = True Then
                        RowExcel = DtExel.NewRow
                        RowExcel.Item("FECHA") = Rowcab.Item("FECHA").ToString
                        RowExcel.Item("FECHA_GUIA") = Rowcab.Item("FECHA_GUIA").ToString
                        RowExcel.Item("HORA") = Rowcab.Item("HORA").ToString
                        RowExcel.Item("HORA_GUIA") = Rowcab.Item("HORA_GUIA").ToString
                        RowExcel.Item("COD_PED") = Rowcab.Item("COD_PED").ToString
                        RowExcel.Item("NRO_GUIA") = Rowcab.Item("NRO_GUIA").ToString
                        RowExcel.Item("RUC") = Rowcab.Item("RUC").ToString
                        RowExcel.Item("NOM_CLIENTE") = Rowcab.Item("NOM_CLIENTE").ToString
                        RowExcel.Item("DIRECCION_ENTREGA") = Rowcab.Item("DIRECCION_ENTREGA").ToString
                        RowExcel.Item("UBIGEO") = Rowcab.Item("UBIGEO").ToString
                        RowExcel.Item("PROVINCIA") = Rowcab.Item("PROVINCIA").ToString
                        RowExcel.Item("DEPARTAMENTO") = Rowcab.Item("DEPARTAMENTO").ToString
                        RowExcel.Item("LIMA_PROV") = Rowcab.Item("LIMA_PROV").ToString
                        RowExcel.Item("DISTRITO") = Rowcab.Item("DISTRITO").ToString
                        RowExcel.Item("CANAL") = Rowcab.Item("CANAL").ToString
                        RowExcel.Item("TRANSPORTE") = Rowcab.Item("TRANSPORTE").ToString
                        RowExcel.Item("M3UN") = CType(Rowcab.Item("M3UN").ToString, Decimal)
                        RowExcel.Item("IMPORTE") = CType(Rowcab.Item("IMPORTE").ToString, Decimal)
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

    Private Sub Dg_Cabecera_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        Try
            If e.RowIndex <> -1 Then
                If e.ColumnIndex = 0 Then
                    Dim row As DataGridViewRow = Dg_Cabecera.Rows(e.RowIndex)
                    row.Cells("MARCAR").Value = Not row.Cells("MARCAR").EditedFormattedValue
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CheckMarcar_CheckedChanged(sender As Object, e As EventArgs) Handles CheckMarcar.CheckedChanged
        Try
            If Dg_Cabecera.Rows.Count > 0 Then
                If CheckMarcar.Checked = True Then
                    For Each RowCab As DataGridViewRow In Dg_Cabecera.Rows
                        If RowCab.Cells("MARCAR").Value = False Then
                            RowCab.Cells("MARCAR").Value = Not RowCab.Cells("MARCAR").EditedFormattedValue
                        End If
                    Next
                End If
                If CheckMarcar.Checked = False Then
                    For Each RowCab As DataGridViewRow In Dg_Cabecera.Rows
                        If RowCab.Cells("MARCAR").Value = True Then
                            RowCab.Cells("MARCAR").Value = Not RowCab.Cells("MARCAR").EditedFormattedValue
                        End If
                    Next
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Try
            ProcesarRutas()
        Catch ex As Exception

        End Try
    End Sub
    'Public Sub Buscar()
    '    Dim dtbusqueda As New DataTable
    '    ' Try
    '    '    If ValidarFechasbuscar() = True Then
    '    '        Dim stringfiltro As String = ""

    '    '        If combo_Almacen.SelectedIndex = Constantes.ValorEnteroInicial Then
    '    '            stringfiltro = String.Format("FECHA >= #{0}# AND FECHA <= #{1}# AND NDOCUMENTO LIKE '%{2}%' ", dt_desde.Value.ToString("MM/dd/yyyy"), dt_hasta.Value.ToString("MM/dd/yyyy"), txt_numero.Text)
    '    '        End If
    '    '        If combo_Almacen.SelectedIndex <> Constantes.ValorEnteroInicial Then
    '    '            stringfiltro = String.Format("FECHA >= #{0}# AND FECHA <= #{1}# AND NDOCUMENTO LIKE '%{2}%' AND ALAMACEN_ORIGEN = '{3}' ", dt_desde.Value.ToString("MM/dd/yyyy"), dt_hasta.Value.ToString("MM/dd/yyyy"), txt_numero.Text, combo_Almacen.Text)
    '    '        End If
    '    '        dtcabecera.DefaultView.RowFilter = stringfiltro
    '    '    End If
    '    'Catch ex As Exception
    '    '    Throw ex
    '    '    MsgBox(Constantes.MensajeErrorServer, MsgBoxStyle.Critical)
    '    'End Try
    'End Sub
    Private Sub ComboBox1_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmb_serie.SelectionChangeCommitted
        Try
            If cmb_serie.Text.Trim = "TODAS" Then
                For i As Integer = 0 To Dg_Cabecera.RowCount - 1
                    Dg_Cabecera.Rows(i).Visible = True
                Next
            Else
                Dim n = cmb_serie.Text

                For i As Integer = 0 To Dg_Cabecera.RowCount - 1
                    Dg_Cabecera.Rows(i).Visible = (Dg_Cabecera.Rows(i).Cells("SERIE").Value = n)
                Next

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Dg_Cabecera_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles Dg_Cabecera.CellValueChanged

    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Try
            'Obtener()
            'If cnumdoc <> "" Then
            '    If estadoOB.ToString.Trim <> "RECEPCIONADO" Then
            '        If MessageBox.Show("Confirmar Recepción de Guía " + cnumdoc + " ?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
            '            ConfirmarRecepcion()
            '        End If
            '    Else
            '        MsgBox("GUIA " + cnumdoc + " ya fue recepcionada", MsgBoxStyle.Exclamation, "SISTEMAS NORDIC")
            '    End If

            'Else
            '    MsgBox("Seleccione la GUIA a confirmar", MsgBoxStyle.Exclamation, "SISTEMAS NORDIC")
            'End If
            Dim rp As Boolean = True

            If Dg_Cabecera.Rows.Count > 0 Then
                If MessageBox.Show("Confirmar Recepción de Guías?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                    For Each dg As DataGridViewRow In Dg_Cabecera.Rows
                        '  If dg.Cells("NRO_GUIA").EditedFormattedValue.ToString.Trim = "0110032261" Then
                        If dg.Cells("MARCAR").EditedFormattedValue = True And dg.Cells("ESTADO").EditedFormattedValue.ToString.Trim <> "RECEPCIONADO" Then
                            cnumdoc = dg.Cells("NRO_GUIA").EditedFormattedValue.ToString
                            ctd = dg.Cells("C5_CTD").EditedFormattedValue.ToString
                            calma = dg.Cells("C5_CALMA").EditedFormattedValue.ToString
                            LlamarConfirmarRecepcion()
                        End If
                        'End If

                    Next
                    MsgBox("Guias Recepcionadas Correctamente", MsgBoxStyle.Information, "SISTEMAS NORDIC")
                    ListarGuiasCabecera()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Dg_Cabecera_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles Dg_Cabecera.CellEndEdit
        Dim cnumdocM, ctdM, calmaM, comentario As String
        Try
            If Dg_Cabecera.Rows.Count > 0 Then
                If e.RowIndex >= 0 Then
                    cnumdocM = Dg_Cabecera.Rows(e.RowIndex).Cells("NRO_GUIA").EditedFormattedValue.ToString.Trim
                    ctdM = Dg_Cabecera.Rows(e.RowIndex).Cells("C5_CTD").EditedFormattedValue.ToString.Trim
                    calmaM = Dg_Cabecera.Rows(e.RowIndex).Cells("C5_CALMA").EditedFormattedValue.ToString.Trim
                    comentario = Dg_Cabecera.Rows(e.RowIndex).Cells("COMENTARIO").EditedFormattedValue.ToString.Trim
                    If cnumdocM <> "" And ctdM <> "" And calmaM <> "" And comentario <> "" Then
                        If LlamarRegistrarComentario(calmaM, ctdM, cnumdocM, comentario) <> 0 Then
                            MsgBox("Comentario Registrado Correctamente", MsgBoxStyle.Information, "SISTEMAS NORDIC")
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ConfirmarRecepcion()
        Try
            If LlamarConfirmarRecepcion() > 0 Then
                MsgBox("Confirmación de Recepción Exitosa", MsgBoxStyle.Information, "SISTEMAS NORDIC")
                ListarGuiasCabecera()
            Else
                MsgBox("Confirmación Fallida, contactar con el área de Sistemas", MsgBoxStyle.Critical, "SISTEMAS NORDIC")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Function LlamarConfirmarRecepcion() As Integer
        Dim RP As Integer = 0
        Try
            RP = ObjAlmacen.RegistrarRecepcionGuiaDespacho(calma, ctd, cnumdoc)
        Catch ex As Exception
            Throw ex
        End Try
        Return RP
    End Function

    Public Function LlamarRegistrarComentario(calma As String, ctd As String, cnumdoc As String, comentario As String) As Integer
        Dim RP As Integer = 0
        Try
            RP = ObjAlmacen.RegistrarComentarioGuiaDespacho(calma, ctd, cnumdoc, comentario)
        Catch ex As Exception
            Throw ex
        End Try
        Return RP
    End Function

    Public Sub Obtener()
        Try
            If Dg_Cabecera.Rows.Count > 0 Then
                cnumdoc = Dg_Cabecera.CurrentRow.Cells("NRO_GUIA").EditedFormattedValue.ToString
                ctd = Dg_Cabecera.CurrentRow.Cells("C5_CTD").EditedFormattedValue.ToString
                calma = Dg_Cabecera.CurrentRow.Cells("C5_CALMA").EditedFormattedValue.ToString
                estadoOB = Dg_Cabecera.CurrentRow.Cells("ESTADO").EditedFormattedValue.ToString
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Function ExisteEnNueva(Destino As String) As Boolean
        Dim rp As Boolean = False
        Try
            For Each RowConso As DataRow In dtConsolidar.Rows
                If RowConso.Item("DESTINO").ToString.Trim = Destino Then
                    rp = True
                    Exit For
                End If
            Next
            Return rp
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub ProcesarRutas()
        Dim totalimporte As Decimal = 0, totalvolumen As Decimal = 0
        Dim totalguias As Integer = 0
        Dim idconsolidado As Integer = 1
        dtConsolidar.Rows.Clear()
        DtDetalleConsolidado.Rows.Clear()
        Try
            If Dg_Cabecera.Rows.Count > 0 Then
                For Each RowPri As DataGridViewRow In Dg_Cabecera.Rows
                    If RowPri.Cells("ESTADO").Value.ToString.Trim = "RECEPCIONADO" Or RowPri.Cells("ESTADO").Value.ToString.Trim = "REPROGRAMADO" Then
                        If RowPri.Cells("MARCAR").Value = True Then
                            If RowPri.Cells("LIMA_PROV").Value.ToString.Trim = "LIMA" Then
                                If ExisteEnNueva(RowPri.Cells("DESTINO").Value.ToString.Trim) = False Then
                                    Dim rowConsolidad As DataRow = dtConsolidar.NewRow
                                    For Each rowseg As DataGridViewRow In Dg_Cabecera.Rows
                                        If RowPri.Cells("DESTINO").Value.ToString.Trim = rowseg.Cells("DESTINO").Value.ToString.Trim Then
                                            Dim rowDetalle As DataRow = DtDetalleConsolidado.NewRow
                                            totalimporte = totalimporte + rowseg.Cells("IMPORTE").Value
                                            totalguias = totalguias + 1
                                            totalvolumen = totalvolumen + rowseg.Cells("M3FIN").Value
                                            rowConsolidad.Item("DESTINO") = RowPri.Cells("DESTINO").Value.ToString.Trim
                                            rowConsolidad.Item("NOM_CLIENTE") = RowPri.Cells("NOM_CLIENTE").Value.ToString.Trim
                                            rowConsolidad.Item("DIRECCION_ENTREGA") = RowPri.Cells("DIRECCION_ENTREGA").Value.ToString.Trim
                                            rowConsolidad.Item("DISTRITO") = RowPri.Cells("DISTRITO").Value.ToString.Trim
                                            rowConsolidad.Item("CANAL") = RowPri.Cells("CANAL").Value.ToString.Trim
                                            rowConsolidad.Item("RUTA") = RowPri.Cells("RUTA").Value.ToString.Trim
                                            rowConsolidad.Item("DETALLE") = RowPri.Cells("DETALLE").Value.ToString.Trim
                                            rowConsolidad.Item("RESTRICCION") = RowPri.Cells("RESTRICCION").Value.ToString.Trim
                                            rowConsolidad.Item("TIEMPOENTREGA") = RowPri.Cells("TIEMPOENTREGA").Value.ToString.Trim
                                            rowConsolidad.Item("CONDICION") = RowPri.Cells("CONDICION").Value.ToString.Trim

                                            'llenar detalle'
                                            rowDetalle.Item("idconsolidado") = idconsolidado
                                            rowDetalle.Item("IMPORTE") = rowseg.Cells("IMPORTE").Value
                                            rowDetalle.Item("NRO_GUIA") = rowseg.Cells("NRO_GUIA").Value
                                            rowDetalle.Item("NOM_CLIENTE") = rowseg.Cells("NOM_CLIENTE").Value
                                            rowDetalle.Item("DIRECCION_ENTREGA") = rowseg.Cells("DIRECCION_ENTREGA").Value
                                            rowDetalle.Item("CONDICION") = rowseg.Cells("CONDICION").Value
                                            rowDetalle.Item("M3UN") = rowseg.Cells("M3FIN").Value
                                            rowDetalle.Item("TIEMPO") = rowseg.Cells("TIEMPOENTREGA").Value
                                            rowDetalle.Item("REPRESENTANTE") = rowseg.Cells("REPRESENTANTE").Value
                                            rowDetalle.Item("RESTRICCION") = rowseg.Cells("RESTRICCION").Value
                                            DtDetalleConsolidado.Rows.Add(rowDetalle)

                                        End If
                                    Next
                                    ' rowConsolidad.Item("CONDICION") =
                                    rowConsolidad.Item("TOTALIMPORTE") = totalimporte
                                    rowConsolidad.Item("TOTALMETROSCUBICOS") = totalvolumen
                                    rowConsolidad.Item("CANTIDADGUIAS") = totalguias
                                    If rowConsolidad.Item("RESTRICCION").ToString.Trim = "Cita - TODO EL DIA" Then
                                        rowConsolidad.Item("RUTA") = "INDEPENDIENTE"
                                    End If
                                    rowConsolidad.Item("idconsolidado") = idconsolidado
                                    dtConsolidar.Rows.Add(rowConsolidad)
                                    totalimporte = 0
                                    totalvolumen = 0
                                    totalguias = 0
                                    idconsolidado = idconsolidado + 1
                                End If
                            End If
                        End If
                    End If
                Next

                If dtConsolidar.Rows.Count > 0 Then
                    Dim RutaForm As New EditarProgramacionRuta
                    RutaForm.dtConsolidado = dtConsolidar
                    RutaForm.dtdetalleConso = DtDetalleConsolidado
                    RutaForm.Show()
                Else
                    MsgBox("No existen Guias disponibles para generar despacho", MsgBoxStyle.Exclamation, "SISTEMAS NORDIC")
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txt_numero_TextChanged(sender As Object, e As EventArgs) Handles txt_numero.TextChanged
        Try
            Buscar()
        Catch ex As Exception

        End Try
    End Sub

    Public Sub Buscar()
        Dim dtbusqueda As New DataTable
        Try
            Dim stringfiltro As String = ""
            stringfiltro = String.Format("NRO_GUIA Like '%{0}%' ", txt_numero.Text)
                    dtcabecera2.DefaultView.RowFilter = stringfiltro
        Catch ex As Exception
            Throw ex
            MsgBox(Constantes.MensajeErrorServer, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub FormatoTablaCabecera()

        dtcabecera2.Clear()
        dtcabecera2 = Estructura.TablaGestionProgramacionDespacho
        Dg_Cabecera.DataSource = dtcabecera2

        Dg_Cabecera.Columns("MARCAR").HeaderText = "Marcar"
        Dg_Cabecera.Columns("MARCAR").Width = 50
        Dg_Cabecera.Columns("MARCAR").ReadOnly = True

        Dg_Cabecera.Columns("FECHA").HeaderText = "Fecha"
        Dg_Cabecera.Columns("FECHA").Width = 70
        Dg_Cabecera.Columns("FECHA").ReadOnly = True

        Dg_Cabecera.Columns("FECHA_GUIA").Visible = False

        Dg_Cabecera.Columns("HORA").HeaderText = "Hora"
        Dg_Cabecera.Columns("HORA").Width = 70
        Dg_Cabecera.Columns("HORA").ReadOnly = True

        Dg_Cabecera.Columns("CONDICION").HeaderText = "Condicion Pago"
        Dg_Cabecera.Columns("CONDICION").Width = 70
        Dg_Cabecera.Columns("CONDICION").ReadOnly = True

        Dg_Cabecera.Columns("HORA_GUIA").Visible = False

        Dg_Cabecera.Columns("COD_PED").HeaderText = "Cod Pedido"
        Dg_Cabecera.Columns("COD_PED").Width = 70
        Dg_Cabecera.Columns("COD_PED").ReadOnly = True

        Dg_Cabecera.Columns("NRO_GUIA").HeaderText = "N° Guia"
        Dg_Cabecera.Columns("NRO_GUIA").Width = 70
        Dg_Cabecera.Columns("NRO_GUIA").ReadOnly = True
        Dg_Cabecera.Columns("NRO_GUIA").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_Cabecera.Columns("RUC").HeaderText = "RUC Cliente"
        Dg_Cabecera.Columns("RUC").Width = 90
        Dg_Cabecera.Columns("RUC").ReadOnly = True
        Dg_Cabecera.Columns("RUC").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_Cabecera.Columns("NOM_CLIENTE").HeaderText = "Cliente"
        Dg_Cabecera.Columns("NOM_CLIENTE").Width = 250
        Dg_Cabecera.Columns("NOM_CLIENTE").ReadOnly = True
        Dg_Cabecera.Columns("NOM_CLIENTE").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_Cabecera.Columns("DIRECCION_ENTREGA").HeaderText = "Direccion Cliente"
        Dg_Cabecera.Columns("DIRECCION_ENTREGA").Width = 300
        Dg_Cabecera.Columns("DIRECCION_ENTREGA").ReadOnly = True
        Dg_Cabecera.Columns("DIRECCION_ENTREGA").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_Cabecera.Columns("UBIGEO").HeaderText = "Ubigeo"
        Dg_Cabecera.Columns("UBIGEO").Width = 100
        Dg_Cabecera.Columns("UBIGEO").ReadOnly = True
        Dg_Cabecera.Columns("UBIGEO").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_Cabecera.Columns("PROVINCIA").HeaderText = "Provincia"
        Dg_Cabecera.Columns("PROVINCIA").Width = 100
        Dg_Cabecera.Columns("PROVINCIA").ReadOnly = True
        Dg_Cabecera.Columns("PROVINCIA").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_Cabecera.Columns("DEPARTAMENTO").HeaderText = "Departamento"
        Dg_Cabecera.Columns("DEPARTAMENTO").Width = 100
        Dg_Cabecera.Columns("DEPARTAMENTO").ReadOnly = True
        Dg_Cabecera.Columns("DEPARTAMENTO").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_Cabecera.Columns("LIMA_PROV").HeaderText = "Lima / Provincia"
        Dg_Cabecera.Columns("LIMA_PROV").Width = 100
        Dg_Cabecera.Columns("LIMA_PROV").ReadOnly = True
        Dg_Cabecera.Columns("LIMA_PROV").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_Cabecera.Columns("DISTRITO").HeaderText = "Distrito"
        Dg_Cabecera.Columns("DISTRITO").Width = 100
        Dg_Cabecera.Columns("DISTRITO").ReadOnly = True
        Dg_Cabecera.Columns("DISTRITO").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_Cabecera.Columns("CANAL").HeaderText = "Canal"
        Dg_Cabecera.Columns("CANAL").Width = 80
        Dg_Cabecera.Columns("CANAL").ReadOnly = True
        Dg_Cabecera.Columns("CANAL").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_Cabecera.Columns("TRANSPORTE").HeaderText = "Transporte"
        Dg_Cabecera.Columns("TRANSPORTE").Width = 80
        Dg_Cabecera.Columns("TRANSPORTE").ReadOnly = True
        Dg_Cabecera.Columns("TRANSPORTE").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_Cabecera.Columns("M3UN").HeaderText = "Metros Cubicos"
        Dg_Cabecera.Columns("M3UN").Width = 100
        Dg_Cabecera.Columns("M3UN").ReadOnly = True
        Dg_Cabecera.Columns("M3UN").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_Cabecera.Columns("IMPORTE").HeaderText = "Importe"
        Dg_Cabecera.Columns("IMPORTE").Width = 80
        Dg_Cabecera.Columns("IMPORTE").ReadOnly = True
        Dg_Cabecera.Columns("IMPORTE").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_Cabecera.Columns("M3FIN").HeaderText = "M. Cubicos Final"
        Dg_Cabecera.Columns("M3FIN").Width = 80
        Dg_Cabecera.Columns("M3FIN").ReadOnly = True
        Dg_Cabecera.Columns("M3FIN").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_Cabecera.Columns("TIEMPOENTREGA").HeaderText = "Tiempo Entrega"
        Dg_Cabecera.Columns("TIEMPOENTREGA").Width = 80
        Dg_Cabecera.Columns("TIEMPOENTREGA").ReadOnly = True
        Dg_Cabecera.Columns("TIEMPOENTREGA").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_Cabecera.Columns("DESTINO").HeaderText = "Destino"
        Dg_Cabecera.Columns("DESTINO").Width = 80
        Dg_Cabecera.Columns("DESTINO").ReadOnly = True
        Dg_Cabecera.Columns("DESTINO").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_Cabecera.Columns("RUTA").HeaderText = "Ruta"
        Dg_Cabecera.Columns("RUTA").Width = 80
        Dg_Cabecera.Columns("RUTA").ReadOnly = True
        Dg_Cabecera.Columns("RUTA").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_Cabecera.Columns("DETALLE").HeaderText = "Detalle Ruta"
        Dg_Cabecera.Columns("DETALLE").Width = 80
        Dg_Cabecera.Columns("DETALLE").ReadOnly = True
        Dg_Cabecera.Columns("DETALLE").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_Cabecera.Columns("RESTRICCION").HeaderText = "Restricciones"
        Dg_Cabecera.Columns("RESTRICCION").Width = 80
        Dg_Cabecera.Columns("RESTRICCION").ReadOnly = True
        Dg_Cabecera.Columns("RESTRICCION").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

    End Sub

End Class