Imports ClosedXML.Excel
Imports Nordic.Bl.Be


Public Class frmReportePedidosPicking
    Private dtcabecera2, dtcabecera As New DataTable
    Public Estructura As New EstructuraTabla
    Private ObjAlmacen As New AlmacenL

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs)
        'Try

        '    Dim obj As New BePedidos
        '    Dim dt As New DataTable

        '    Dim fecini As String
        '    Dim fecfin As String

        '    fecini = dtpFecIni.Value.ToShortDateString
        '    fecfin = dtpFecFin.Value.ToShortDateString

        '    dt = obj.ListarPedidosProgramacionPicking(fecini, fecfin)

        '    dgvListarPedidosPicking.DataSource = dt

        '    tslCantidad.Text = CStr(dgvListarPedidosPicking.Rows.Count)



        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub btnExportar_Click(sender As Object, e As EventArgs)
        'Try
        '    Me.Cursor = Cursors.WaitCursor

        '    GridAExcel(dgvListarPedidosPicking)

        '    Me.Cursor = Cursors.Default
        'Catch ex As Exception

        'End Try
    End Sub




    Function GridAExcel(ByVal ElGrid As DataGridView) As Boolean

        Dim exApp As Object
        Dim exLibro As Object
        Dim exHoja As Object

        exApp = CreateObject("Excel.Application")

        ' -- Referencia a la Hoja activa ( la que añade por defecto Excel )   
        exHoja = exApp.ActiveSheet

        Try

            'Añadimos el Libro al programa, y la hoja al libro
            exLibro = exApp.Workbooks.Add()
            exHoja = exLibro.Worksheets(1)



            'exLibro = exApp.Workbooks
            'exHoja = exLibro.Worksheets.Add()

            ' ¿Cuantas columnas y cuantas filas?
            Dim NCol As Integer = ElGrid.ColumnCount
            Dim NRow As Integer = ElGrid.RowCount

            'Aqui recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.
            For i As Integer = 1 To NCol
                'If i <> 1 And i <> 10 And i <> 11 And i <> 12 Then
                exHoja.Cells.Item(1, i) = ElGrid.Columns(i - 1).HeaderText.ToString()
                'End If
                'exHoja.Cells.Item(1, i).HorizontalAlignment = 3
            Next

            Dim fecha As String = String.Empty

            For Fila As Integer = 0 To NRow - 1
                For Col As Integer = 0 To NCol - 1

                    'If Col = 13 Or Col = 14 Or Col = 15 Or Col = 16 Or Col = 17 Then
                    '    fecha = "'" & CStr(ElGrid.Rows(Fila).Cells(Col).Value)
                    '    exHoja.Cells.Item(Fila + 2, Col + 1) = "'" & CStr(ElGrid.Rows(Fila).Cells(Col).Value)
                    'Else
                    '    exHoja.Cells.Item(Fila + 2, Col + 1) = CStr(ElGrid.Rows(Fila).Cells(Col).Value)

                    'End If
                    ' If Col <> 8 And Col <> 22 And Col <> 24 Then
                    'If Col = 3 Or Col = 0 Or Col = 2 Or Col = 13 Or Col = 14 Or Col = 15 Or Col = 16 Or Col = 17 Then
                    '    fecha = "'" & CStr(ElGrid.Rows(Fila).Cells(Col).Value)
                    '    exHoja.Cells.Item(Fila + 2, Col + 1) = "'" & CStr(ElGrid.Rows(Fila).Cells(Col).Value)
                    'Else
                    '    exHoja.Cells.Item(Fila + 2, Col + 1) = CStr(ElGrid.Rows(Fila).Cells(Col).Value)

                    'End If
                    'If Col <> 1 And Col <> 10 And Col <> 11 And Col <> 12 And Col <> 13 Then

                    If ElGrid.Rows(Fila).Cells(Col).Value Is DBNull.Value Then
                        exHoja.Cells.Item(Fila + 2, Col + 1) = ""
                    Else
                        exHoja.Cells.Item(Fila + 2, Col + 1) = CStr(ElGrid.Rows(Fila).Cells(Col).Value)
                    End If

                    'End If


                    ' End If
                Next
            Next

            'Titulo en negrita, Alineado al centro y que el tamaño de la columna se
            'ajuste al texto


            exHoja.Rows.Item(1).Font.Bold = 1
            exHoja.Rows.Item(1).HorizontalAlignment = 3

            exHoja.Columns.AutoFit()

            exHoja.Rows.AutoFit()

            'exHoja.RowHeight = 12

            'Aplicación visible
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

    Private Sub CargaInicial()
        Try
            FormatoTablaCabecera()
            ListarGuiasCabecera()
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
            dtretono = ObjAlmacen.ListarPedidosPicking(fechadesde, fechahasta).Copy
        Catch ex As Exception
            Throw ex
        End Try
        Return dtretono
    End Function

    Public Function ExistePedido(codpedido As String) As Boolean
        Dim rp As Boolean = False
        Try
            If dtcabecera2.Rows.Count > 0 Then
                For Each Rowfil As DataRow In dtcabecera2.Rows
                    If codpedido = Rowfil.Item("COD_PED") Then
                        rp = True
                        Exit For
                    End If
                Next
            Else
                rp = False
            End If
            Return rp
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Public Function obtenerComplementos(codpedido As String) As List(Of Decimal)
        Dim rp As Decimal = 0
        Dim VALOR As Decimal = 0
        Dim CajasMaster As Decimal = 0
        Dim CajasInternas As Decimal = 0
        Dim Saldos As Decimal = 0
        Dim rpList As New List(Of Decimal)

        Try
            For Each Rowfil As DataRow In dtcabecera.Rows
                Dim cajas As Decimal = 0, cajasm As Decimal = 0, saldo As Decimal = 0
                If codpedido = Rowfil.Item("COD_PED") Then
                    VALOR = Math.Round(CType(Rowfil.Item("M3UN").ToString, Decimal), 6)
                    rp = rp + VALOR

                    If Rowfil.Item("UNIDAD").ToString = "UND" Then
                        If Rowfil.Item("FACTORCI").ToString <> 0 And Rowfil.Item("FACTORCM").ToString.Trim <> 0 Then
                            cajas = (Rowfil.Item("CANTIDAD") / Rowfil.Item("FACTORCI"))
                            saldo = Rowfil.Item("CANTIDAD") Mod Rowfil.Item("FACTORCI")
                            cajasm = cajas / Rowfil.Item("FACTORCM")
                            cajasm = Math.Floor(cajasm)
                            cajas = cajas Mod Rowfil.Item("FACTORCM")
                        End If
                    Else
                        If Rowfil.Item("UNIDAD").ToString = "CJA" Then
                            saldo = 0
                            cajas = Rowfil.Item("CANTIDAD")
                            cajasm = cajas / Rowfil.Item("FACTORCM")
                            cajasm = Math.Floor(cajasm)
                            cajas = cajas Mod Rowfil.Item("FACTORCM")
                        End If
                    End If
                    CajasMaster = CajasMaster + cajasm
                    CajasInternas = CajasInternas + cajas
                    Saldos = Saldos + saldo
                End If
            Next

            rpList.Add(Math.Round(rp, 3))
            rpList.Add(CajasMaster)
            rpList.Add(CajasInternas)
            rpList.Add(Saldos)

            Return rpList
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub ListarGuiasCabecera()
        Try
            Dim dtretorno As New DataTable
            dtretorno = LlamarPedidosPickin()
            If dtretorno.Rows.Count > 0 Then
                dtcabecera.Rows.Clear()
                dtcabecera = dtretorno
                dtcabecera2.Rows.Clear()
                For Each RowRetorno As DataRow In dtretorno.Rows
                    Dim RP As Boolean = ExistePedido(RowRetorno.Item("COD_PED").ToString)
                    If RP = False Then
                        Dim rowcabecera As DataRow
                        Dim cajas As Decimal = 0, cajasm As Decimal = 0, saldo As Decimal = 0
                        Dim rpList As New List(Of Decimal)
                        rowcabecera = dtcabecera2.NewRow
                        rowcabecera.Item("MARCAR") = True
                        rowcabecera.Item("FECHA") = RowRetorno.Item("FECHA").ToString.Trim
                        rowcabecera.Item("HORA") = RowRetorno.Item("HORA").ToString.Trim
                        rowcabecera.Item("COD_PED") = RowRetorno.Item("COD_PED").ToString.Trim
                        rowcabecera.Item("DESCRIPCION") = RowRetorno.Item("DESCRIP_PED").ToString.Trim
                        rowcabecera.Item("ESTADO") = RowRetorno.Item("ESTADO").ToString.Trim
                        rowcabecera.Item("NRO_GUIA") = RowRetorno.Item("NRO_GUIA").ToString.Trim
                        rowcabecera.Item("RUC") = RowRetorno.Item("RUC").ToString.Trim
                        rowcabecera.Item("NOM_CLIENTE") = RowRetorno.Item("NOM_CLIENTE").ToString.Trim
                        rowcabecera.Item("DIRECCION_ENTREGA") = RowRetorno.Item("DIRECCION_ENTREGA").ToString.Trim
                        rowcabecera.Item("UBIGEO") = RowRetorno.Item("UBIGEO").ToString.Trim
                        rowcabecera.Item("PROVINCIA") = RowRetorno.Item("PROVINCIA").ToString.Trim
                        rowcabecera.Item("DEPARTAMENTO") = RowRetorno.Item("DEPARTAMENTO").ToString.Trim
                        If rowcabecera.Item("PROVINCIA").ToString.Trim = "CALLAO" And rowcabecera.Item("DEPARTAMENTO").ToString = "CALLAO" Then
                            rowcabecera.Item("LIMA_PROV") = "LIMA"
                        Else
                            If rowcabecera.Item("PROVINCIA").ToString.Trim = "LIMA" And rowcabecera.Item("DEPARTAMENTO").ToString = "LIMA" Then
                                rowcabecera.Item("LIMA_PROV") = "LIMA"
                            Else
                                rowcabecera.Item("LIMA_PROV") = "PROVINCIA"
                            End If
                        End If

                        rowcabecera.Item("DISTRITO") = RowRetorno.Item("DISTRITO").ToString.Trim
                        rpList = obtenerComplementos(RowRetorno.Item("COD_PED").ToString.Trim)

                        rowcabecera.Item("M3UN") = CType(rpList.ElementAt(0), Decimal)

                        rowcabecera.Item("CAJASM") = CType(rpList.ElementAt(1), Integer)
                        rowcabecera.Item("CAJAS") = CType(rpList.ElementAt(2), Integer)
                        rowcabecera.Item("SALDO") = CType(rpList.ElementAt(3), Integer)
                        dtcabecera2.Rows.Add(rowcabecera)
                    End If
                Next
                Dg_Cabecera.DataSource = dtcabecera2
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub FormatoTablaCabecera()

        'Tabladetalle.Columns.Add("MARCAR", GetType(Boolean))
        'Tabladetalle.Columns.Add("FECHA", GetType(String))
        'Tabladetalle.Columns.Add("HORA", GetType(String))
        'Tabladetalle.Columns.Add("COD_PED", GetType(String))
        'Tabladetalle.Columns.Add("DESCRIPCION", GetType(String))
        'Tabladetalle.Columns.Add("ESTADO", GetType(String))
        'Tabladetalle.Columns.Add("NRO_GUIA", GetType(String))
        'Tabladetalle.Columns.Add("RUC", GetType(String))
        'Tabladetalle.Columns.Add("NOM_CLIENTE", GetType(String))
        'Tabladetalle.Columns.Add("DIRECCION_ENTREGA", GetType(String))
        'Tabladetalle.Columns.Add("UBIGEO", GetType(String))
        'Tabladetalle.Columns.Add("PROVINCIA", GetType(String))
        'Tabladetalle.Columns.Add("DEPARTAMENTO", GetType(String))
        'Tabladetalle.Columns.Add("DISTRITO", GetType(String))
        'Tabladetalle.Columns.Add("LIMA_PROV", GetType(String))
        'Tabladetalle.Columns.Add("CAJAS", GetType(String))
        'Tabladetalle.Columns.Add("CAJASM", GetType(String))
        'Tabladetalle.Columns.Add("SALDO", GetType(String))
        'Tabladetalle.Columns.Add("M3UN", GetType(Decimal))

        dtcabecera2.Clear()
        dtcabecera2 = Estructura.TablaProgramacionPicking
        Dg_Cabecera.DataSource = dtcabecera2

        Dg_Cabecera.Columns("MARCAR").HeaderText = "Marcar"
        Dg_Cabecera.Columns("MARCAR").Width = 50
        Dg_Cabecera.Columns("MARCAR").ReadOnly = True

        Dg_Cabecera.Columns("FECHA").HeaderText = "Fecha"
        Dg_Cabecera.Columns("FECHA").Width = 70
        Dg_Cabecera.Columns("FECHA").ReadOnly = True

        Dg_Cabecera.Columns("HORA").HeaderText = "Fecha"
        Dg_Cabecera.Columns("HORA").Width = 70
        Dg_Cabecera.Columns("HORA").ReadOnly = True

        Dg_Cabecera.Columns("COD_PED").HeaderText = "Cod Pedido"
        Dg_Cabecera.Columns("COD_PED").Width = 70
        Dg_Cabecera.Columns("COD_PED").ReadOnly = True

        Dg_Cabecera.Columns("DESCRIPCION").HeaderText = "Descripcion Pedido"
        Dg_Cabecera.Columns("DESCRIPCION").Width = 120
        Dg_Cabecera.Columns("DESCRIPCION").ReadOnly = True


        Dg_Cabecera.Columns("ESTADO").HeaderText = "Estado Pedido"
        Dg_Cabecera.Columns("ESTADO").Width = 70
        Dg_Cabecera.Columns("ESTADO").ReadOnly = True

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

        Dg_Cabecera.Columns("CAJAS").HeaderText = "Cajas Internas"
        Dg_Cabecera.Columns("CAJAS").Width = 80
        Dg_Cabecera.Columns("CAJAS").ReadOnly = True
        Dg_Cabecera.Columns("CAJAS").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_Cabecera.Columns("CAJASM").HeaderText = "Cajas Master"
        Dg_Cabecera.Columns("CAJASM").Width = 80
        Dg_Cabecera.Columns("CAJASM").ReadOnly = True
        Dg_Cabecera.Columns("CAJASM").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_Cabecera.Columns("SALDO").HeaderText = "Saldo"
        Dg_Cabecera.Columns("SALDO").Width = 80
        Dg_Cabecera.Columns("SALDO").ReadOnly = True
        Dg_Cabecera.Columns("SALDO").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_Cabecera.Columns("M3UN").HeaderText = "Metros Cubicos"
        Dg_Cabecera.Columns("M3UN").Width = 100
        Dg_Cabecera.Columns("M3UN").ReadOnly = True
        Dg_Cabecera.Columns("M3UN").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter



    End Sub

    Private Sub btnBuscar_Click_1(sender As Object, e As EventArgs) Handles btnBuscar.Click
        ListarGuiasCabecera()
    End Sub

    Public Sub ProcesoExportar()

        'Tabladetalle.Columns.Add("FECHA", GetType(String))
        'Tabladetalle.Columns.Add("HORA", GetType(String))
        'Tabladetalle.Columns.Add("COD_PED", GetType(String))
        'Tabladetalle.Columns.Add("NRO_GUIA", GetType(String))
        'Tabladetalle.Columns.Add("RUC", GetType(String))
        'Tabladetalle.Columns.Add("NOM_CLIENTE", GetType(String))
        'Tabladetalle.Columns.Add("DIRECCION_ENTREGA", GetType(String))
        'Tabladetalle.Columns.Add("UBIGEO", GetType(String))
        'Tabladetalle.Columns.Add("PROVINCIA", GetType(String))
        'Tabladetalle.Columns.Add("DEPARTAMENTO", GetType(String))
        'Tabladetalle.Columns.Add("LIMA_PROV", GetType(String))
        'Tabladetalle.Columns.Add("DISTRITO", GetType(String))
        'Tabladetalle.Columns.Add("CANAL", GetType(String))
        'Tabladetalle.Columns.Add("TRANSPORTE", GetType(String))
        'Tabladetalle.Columns.Add("M3UN", GetType(Decimal))
        Try
            If dtcabecera2.Rows.Count > 0 Then
                Dim DtExel As New DataTable
                DtExel = Estructura.ExcelProgramacionPicking
                Dim RowExcel As DataRow
                For Each Rowcab As DataRow In dtcabecera2.Rows
                    If Rowcab.Item("MARCAR") = True Then
                        RowExcel = DtExel.NewRow
                        RowExcel.Item("FECHA") = Rowcab.Item("FECHA").ToString
                        RowExcel.Item("HORA") = Rowcab.Item("HORA").ToString
                        RowExcel.Item("COD_PED") = Rowcab.Item("COD_PED").ToString
                        RowExcel.Item("DESCRIPCION") = Rowcab.Item("DESCRIPCION").ToString
                        RowExcel.Item("ESTADO") = Rowcab.Item("ESTADO").ToString
                        RowExcel.Item("NRO_GUIA") = Rowcab.Item("NRO_GUIA").ToString
                        RowExcel.Item("RUC") = Rowcab.Item("RUC").ToString
                        RowExcel.Item("NOM_CLIENTE") = Rowcab.Item("NOM_CLIENTE").ToString
                        RowExcel.Item("DIRECCION_ENTREGA") = Rowcab.Item("DIRECCION_ENTREGA").ToString
                        RowExcel.Item("UBIGEO") = Rowcab.Item("UBIGEO").ToString
                        RowExcel.Item("PROVINCIA") = Rowcab.Item("PROVINCIA").ToString
                        RowExcel.Item("DEPARTAMENTO") = Rowcab.Item("DEPARTAMENTO").ToString
                        RowExcel.Item("LIMA_PROV") = Rowcab.Item("LIMA_PROV").ToString
                        RowExcel.Item("DISTRITO") = Rowcab.Item("DISTRITO").ToString
                        RowExcel.Item("CAJASM") = Rowcab.Item("CAJASM")
                        RowExcel.Item("CAJAS") = Rowcab.Item("CAJAS")
                        RowExcel.Item("M3UN") = CType(Rowcab.Item("M3UN").ToString, Decimal)
                        RowExcel.Item("SALDO") = CType(Rowcab.Item("SALDO").ToString, Integer)
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

    Public Function ExportExcel(ByVal dt As DataTable) As Boolean
        Dim RP As Boolean = False
        Dim wb As New XLWorkbook()
        Dim path As String

        Try
            savedialog_Excel.Filter = "Excel File(.xlsx)|*.xlsx"
            savedialog_Excel.Title = Text
            savedialog_Excel.FileName = "PEDIDOS PICKING " + Text
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

    Private Sub btnExportar_Click_1(sender As Object, e As EventArgs) Handles btnExportar.Click
        Try
            ProcesoExportar()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub frmReportePedidosPicking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CargaInicial()
        Catch ex As Exception

        End Try
    End Sub
End Class