Imports ClosedXML.Excel
Imports Nordic.Bl.Be

Public Class GestionDeliveryOnTime

    Private dtcabecera2, dtcabecera, DTtiemposJJ As New DataTable
    Public Estructura As New EstructuraTabla
    Private ObjAlmacen As New AlmacenL
    Private CNUMDOC, CTD, CALMA, Estado As String

    Private Sub GestionDeliveryOnTime_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CargaInicial()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CargaInicial()
        Try
            CargarTiemposJJ()
            cmb_filtro.SelectedIndex = 0
            FormatoTablaCabecera()
            'ListarGuiasCabecera()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Filtrar()
        Try
            Dim stringfiltro As String = ""
            stringfiltro = String.Format("NRO_GUIA LIKE '%{0}%'", txt_guia.Text)
            dtcabecera2.DefaultView.RowFilter = stringfiltro
        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Private Sub CargarTiemposJJ()
        Try
            DTtiemposJJ = ObjAlmacen.CSE_SP_LISTAR_TIEMPSO_JJ
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            ListarGuiasCabecera()
            ' MsgBox(Dg_Cabecera.Rows.Count.ToString, MsgBoxStyle.Information, "MENSAJE")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Public Function LlamarListarBaseDeliveryOnTime() As DataTable
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
            dtretono = ObjAlmacen.ObtenerIndicarDeliveryhOnTime(fechadesde, fechahasta).Copy
        Catch ex As Exception
            Throw ex
        End Try
        Return dtretono
    End Function
    Private guia As String = ""
    Public Sub ListarGuiasCabecera()

        Try
            Dim contadorL As Integer = 0, cantidadL As Integer = 0, ContadorP As Integer = 0, cantidadP As Integer = 0
            Dim dtretorno As New DataTable
            Dim contador As Integer = 0
            Dim cant As Integer = 0
            dtretorno = LlamarListarBaseDeliveryOnTime()
            If dtretorno.Rows.Count > 0 Then
                dtcabecera.Rows.Clear()
                dtcabecera = dtretorno
                dtcabecera2.Rows.Clear()
                For Each RowRetorno As DataRow In dtretorno.Rows

                    Dim rowcabecera As DataRow
                    rowcabecera = dtcabecera2.NewRow
                    rowcabecera.Item("NRO_GUIA") = RowRetorno.Item("NRO_GUIA").ToString.Trim
                    '  guia = RowRetorno.Item("NRO_GUIA").ToString.Trim
                    rowcabecera.Item("FECHA_DESPACHO") = RowRetorno.Item("FECHA_DESPACHO").ToString.Trim
                    rowcabecera.Item("FECHA_RECEPCION_CLIENTE") = RowRetorno.Item("FECHA_RECEPCION_CLIENTE").ToString.Trim
                    rowcabecera.Item("FECHA_SUBE_FOTO") = RowRetorno.Item("FECHA_SUBE_FOTO").ToString.Trim
                    rowcabecera.Item("RUC_CLIENTE") = RowRetorno.Item("RUC_CLIENTE").ToString.Trim
                    rowcabecera.Item("CLIENTE") = RowRetorno.Item("CLIENTE").ToString.Trim
                    rowcabecera.Item("DIRECCION_CLIENTE") = RowRetorno.Item("DIRECCION_CLIENTE").ToString.Trim
                    rowcabecera.Item("TRANSPORTISTA") = RowRetorno.Item("TRANSPORTISTA").ToString.Trim
                    rowcabecera.Item("LIM_PROV") = RowRetorno.Item("LIM_PROV").ToString.Trim
                    rowcabecera.Item("MOTIVO") = RowRetorno.Item("MOTIVO").ToString.Trim
                    rowcabecera.Item("AREA") = RowRetorno.Item("AREA").ToString.Trim
                    rowcabecera.Item("HORA_DESPACHO") = RowRetorno.Item("HORA_DESPACHO").ToString.Trim
                    rowcabecera.Item("TIPO_DOCUMENTO") = RowRetorno.Item("TIPO_DOCUMENTO").ToString.Trim
                    rowcabecera.Item("ALMACEN") = RowRetorno.Item("ALMACEN").ToString.Trim
                    rowcabecera.Item("FECHA_RETORNO_GUIA") = RowRetorno.Item("FECHA_RETORNO_GUIA").ToString.Trim

                    If RowRetorno.Item("NRO_GUIA").ToString.Trim = "0110034879".Trim Then
                        Dim GUIA As String = "a"
                        GUIA = "0120014046"
                    End If

                    If RowRetorno.Item("PROVINCIA").ToString.Trim = "BARRANCA".Trim Or RowRetorno.Item("PROVINCIA").ToString.Trim = "CAÑETE".Trim Or RowRetorno.Item("PROVINCIA").ToString.Trim = "HUARAL".Trim Or RowRetorno.Item("PROVINCIA").ToString.Trim = "HUAURA".Trim Then
                        rowcabecera.Item("LIM_PROV") = "PROVINCIA"
                    End If

                    Dim Diferencia As Integer = 0, DiferenciaRecep As Integer = 0
                    Dim Tolerancia As Integer = 1

                    If rowcabecera.Item("LIM_PROV").ToString.Trim = "LIMA" Then

                        If RowRetorno.Item("FECHA_DESPACHO").ToString.Trim <> "" Then
                            Dim FechaRecepcion, FechaFoto As Date
                            If RowRetorno.Item("FECHA_SUBE_FOTO").ToString.Trim <> "" And RowRetorno.Item("FECHA_RECEPCION_CLIENTE").ToString.Trim <> "" Then
                                FechaRecepcion = DateTime.Parse(RowRetorno.Item("FECHA_RECEPCION_CLIENTE").ToString.Trim)
                                FechaFoto = DateTime.Parse(RowRetorno.Item("FECHA_SUBE_FOTO").ToString.Trim)
                                If FechaRecepcion > FechaFoto Then
                                    Diferencia = DateDiff(DateInterval.Day, Convert.ToDateTime(RowRetorno.Item("FECHA_DESPACHO").ToString.Trim), FechaFoto)
                                ElseIf FechaFoto > FechaRecepcion Then
                                    Diferencia = DateDiff(DateInterval.Day, Convert.ToDateTime(RowRetorno.Item("FECHA_DESPACHO").ToString.Trim), FechaRecepcion)
                                End If
                            ElseIf RowRetorno.Item("FECHA_SUBE_FOTO").ToString.Trim = "" And RowRetorno.Item("FECHA_RECEPCION_CLIENTE").ToString.Trim <> "" Then
                                FechaRecepcion = DateTime.Parse(RowRetorno.Item("FECHA_RECEPCION_CLIENTE").ToString.Trim)
                                Diferencia = DateDiff(DateInterval.Day, Convert.ToDateTime(RowRetorno.Item("FECHA_DESPACHO").ToString.Trim), FechaRecepcion)
                            ElseIf RowRetorno.Item("FECHA_SUBE_FOTO").ToString.Trim <> "" And RowRetorno.Item("FECHA_RECEPCION_CLIENTE").ToString.Trim = "" Then
                                FechaFoto = DateTime.Parse(RowRetorno.Item("FECHA_SUBE_FOTO").ToString.Trim)
                                Diferencia = DateDiff(DateInterval.Day, Convert.ToDateTime(RowRetorno.Item("FECHA_DESPACHO").ToString.Trim), FechaFoto)
                            ElseIf RowRetorno.Item("FECHA_SUBE_FOTO").ToString.Trim = "" And RowRetorno.Item("FECHA_RECEPCION_CLIENTE").ToString.Trim = "" Then
                                Diferencia = DateDiff(DateInterval.Day, Convert.ToDateTime(RowRetorno.Item("FECHA_DESPACHO").ToString.Trim), Now)
                            End If
                        End If

                        If RowRetorno.Item("FECHA_DESPACHO").ToString.Trim <> "" And RowRetorno.Item("FECHA_RECEPCION_CLIENTE").ToString.Trim <> "" Then
                            DiferenciaRecep = DateDiff(DateInterval.Day, Convert.ToDateTime(RowRetorno.Item("FECHA_DESPACHO").ToString.Trim), Convert.ToDateTime(RowRetorno.Item("FECHA_RECEPCION_CLIENTE").ToString.Trim))
                        ElseIf RowRetorno.Item("FECHA_DESPACHO").ToString.Trim <> "" And RowRetorno.Item("FECHA_RECEPCION_CLIENTE").ToString.Trim = "" Then
                            DiferenciaRecep = DateDiff(DateInterval.Day, Convert.ToDateTime(RowRetorno.Item("FECHA_DESPACHO").ToString.Trim), Convert.ToDateTime(Now))
                        End If

                        If RowRetorno.Item("HORA_DESPACHO").ToString.Trim > #04:30:00 PM# Then
                            Tolerancia = 2
                        End If
                        Dim FechaDespacho As Date
                        FechaDespacho = RowRetorno.Item("FECHA_DESPACHO").ToString.Trim
                        Dim DIA As Integer = 0
                        DIA = FechaDespacho.DayOfWeek

                        If DIA = 6 Then
                            If RowRetorno.Item("HORA_DESPACHO").ToString.Trim > #10:30:00 AM# Then
                                Tolerancia = 3
                            Else
                                Tolerancia = 2
                            End If

                        End If

                    End If

                    If rowcabecera.Item("LIM_PROV").ToString.Trim = "PROVINCIA" Then

                        If RowRetorno.Item("FECHA_DESPACHO").ToString.Trim <> "" And RowRetorno.Item("FECHA_SUBE_FOTO").ToString.Trim <> "" Then
                            Diferencia = DateDiff(DateInterval.Day, Convert.ToDateTime(RowRetorno.Item("FECHA_DESPACHO").ToString.Trim), Convert.ToDateTime(RowRetorno.Item("FECHA_SUBE_FOTO").ToString.Trim))
                        ElseIf RowRetorno.Item("FECHA_DESPACHO").ToString.Trim <> "" And RowRetorno.Item("FECHA_SUBE_FOTO").ToString.Trim = "" Then
                            Diferencia = DateDiff(DateInterval.Day, Convert.ToDateTime(RowRetorno.Item("FECHA_DESPACHO").ToString.Trim), Convert.ToDateTime(Now))
                        End If

                        If RowRetorno.Item("FECHA_DESPACHO").ToString.Trim <> "" And RowRetorno.Item("FECHA_RECEPCION_CLIENTE").ToString.Trim <> "" Then
                            DiferenciaRecep = DateDiff(DateInterval.Day, Convert.ToDateTime(RowRetorno.Item("FECHA_DESPACHO").ToString.Trim), Convert.ToDateTime(RowRetorno.Item("FECHA_RECEPCION_CLIENTE").ToString.Trim))
                        ElseIf RowRetorno.Item("FECHA_DESPACHO").ToString.Trim <> "" And RowRetorno.Item("FECHA_RECEPCION_CLIENTE").ToString.Trim = "" Then
                            DiferenciaRecep = DateDiff(DateInterval.Day, Convert.ToDateTime(RowRetorno.Item("FECHA_DESPACHO").ToString.Trim), Convert.ToDateTime(Now))
                        End If

                        If RowRetorno.Item("HORA_DESPACHO").ToString.Trim > #12:00:00 PM# Then
                            Tolerancia = 2
                        End If

                        If RowRetorno.Item("TRANSPORTISTA").ToString.Trim = "J Y J CARGO S.A.C - PRIVADO".Trim Or RowRetorno.Item("TRANSPORTISTA").ToString.Trim = "J Y J CARGO S.A.C - REPRESENTANTE".Trim Or RowRetorno.Item("TRANSPORTISTA").ToString.Trim = "J Y J CARGO S.A.C - ENCOMIENDAS".Trim Then
                            Dim nuevaoTolerancia As Integer = 0
                            nuevaoTolerancia = ObtenerToleranciaXProvincia(RowRetorno.Item("PROVINCIA").ToString.Trim, "P")
                            If nuevaoTolerancia <> 0 Then
                                Tolerancia = nuevaoTolerancia
                            End If
                        ElseIf RowRetorno.Item("TRANSPORTISTA").ToString.Trim = "J Y J CARGO S.A.C - INSTITUCIONAL".Trim Then
                            Dim nuevaoTolerancia As Integer = 0
                            nuevaoTolerancia = ObtenerToleranciaXProvincia(RowRetorno.Item("PROVINCIA").ToString.Trim, "I")
                            If nuevaoTolerancia <> 0 Then
                                Tolerancia = nuevaoTolerancia
                            End If
                        End If

                        Dim FechaDespacho As Date
                        FechaDespacho = RowRetorno.Item("FECHA_DESPACHO").ToString.Trim
                        Dim DIA As Integer = 0
                        DIA = FechaDespacho.DayOfWeek

                        If DIA = 6 Then
                            If RowRetorno.Item("HORA_DESPACHO").ToString.Trim > #10:30:00 AM# Then
                                Tolerancia = 2
                            Else
                                Tolerancia = 2
                            End If

                        End If

                    End If

                    rowcabecera.Item("Diferencia Foto") = Diferencia
                    rowcabecera.Item("Diferencia Recepcion") = DiferenciaRecep

                    'If RowRetorno.Item("ALMACEN").ToString.Trim = "" Then

                    'End If

                    rowcabecera.Item("Tolerancia") = Tolerancia

                    Dim Estado As String = "", Estado2 As String = ""
                    If Diferencia <= Tolerancia Then
                        Estado = "DENTRO DE TIEMPO"
                    ElseIf Diferencia > Tolerancia Then
                        Estado = "FUERA DE TIEMPO"
                    End If


                    If DiferenciaRecep <= Tolerancia Then
                        Estado2 = "DENTRO DE TIEMPO"
                    ElseIf DiferenciaRecep > Tolerancia Then
                        Estado2 = "FUERA DE TIEMPO"
                    End If

                    'Dg_Cabecera.Columns("ESTADO FECHA FOTO").HeaderText = "Estado Foto"
                    'Dg_Cabecera.Columns("ESTADO FECHA FOTO").Width = 100
                    'Dg_Cabecera.Columns("ESTADO FECHA FOTO").ReadOnly = True

                    'Dg_Cabecera.Columns("ESTADO FECHA RECEPCION").HeaderText = "Estado Recepcion"
                    'Dg_Cabecera.Columns("ESTADO FECHA RECEPCION").Width = 100
                    'Dg_Cabecera.Columns("ESTADO FECHA RECEPCION").ReadOnly = True

                    rowcabecera.Item("ESTADO FECHA FOTO") = Estado
                    rowcabecera.Item("ESTADO FECHA RECEPCION") = Estado2


                    If rowcabecera.Item("ESTADO FECHA FOTO") IsNot Nothing Then
                        If rowcabecera.Item("ESTADO FECHA FOTO").ToString.Trim = "DENTRO DE TIEMPO" Then
                            contador = contador + 1
                        End If
                    End If

                    If rowcabecera.Item("LIM_PROV").ToString.Trim = "LIMA" Then
                        cantidadL = cantidadL + 1
                        If rowcabecera.Item("ESTADO FECHA FOTO").ToString.Trim = "DENTRO DE TIEMPO" Then
                            contadorL = contadorL + 1
                        End If
                    End If
                    If rowcabecera.Item("LIM_PROV").ToString.Trim = "PROVINCIA" Then
                        cantidadP = cantidadP + 1
                        If rowcabecera.Item("ESTADO FECHA FOTO").ToString.Trim = "DENTRO DE TIEMPO" Then
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

    Private Function ObtenerToleranciaXProvincia(PROVINCIA As String, Tipo As String) As Integer
        Dim Tolerancia As Integer = 0
        Try
            For Each RowTiempos As DataRow In DTtiemposJJ.Rows
                If RowTiempos.Item("PROVINCIA").ToString.Trim = PROVINCIA.Trim Then
                    If Tipo = "P" Then
                        Tolerancia = CType(RowTiempos.Item("PRIVADO").ToString, Integer) + 1
                    ElseIf Tipo = "I" Then
                        Tolerancia = CType(RowTiempos.Item("INSTITUCIONAL").ToString, Integer) + 1
                    End If
                    Exit For
                End If
            Next
        Catch ex As Exception

        End Try
        Return Tolerancia
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If Dg_Cabecera.Rows.Count > 0 Then
                Obtener()
                If Estado.Trim <> "DENTRO DE TIEMPO" Then
                    If CNUMDOC <> "" And CTD <> "" And CALMA <> "" Then
                        Dim RegistroForm As New RegistroObservacion
                        RegistroForm.cnumdoc = CNUMDOC
                        RegistroForm.ctd = CTD
                        RegistroForm.calma = CALMA
                        RegistroForm.tipoobservacion = 2
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

    Private Sub ComboBox1_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmb_filtro.SelectionChangeCommitted
        Try
            Buscar()
        Catch ex As Exception

        End Try
    End Sub

    Public Sub Buscar()
        Dim contador As Integer = 0
        Dim cant As Integer = 0
        Dim contadorL As Integer = 0, cantidadL As Integer = 0, ContadorP As Integer = 0, cantidadP As Integer = 0
        Try

            'Dim stringfiltro As String = ""

            'If cmb_filtro.SelectedIndex <> Constantes.ValorEnteroInicial Then
            '    stringfiltro = String.Format("AREA = '{0}' ", "LOGISTICO")
            'End If
            'dtcabecera2.DefaultView.RowFilter = stringfiltro

            If Dg_Cabecera.Rows.Count > 0 Then

                For Each RowCab As DataRow In dtcabecera2.Rows
                    If cmb_filtro.SelectedIndex = 1 Then
                        If RowCab.Item("ESTADO FECHA FOTO") IsNot Nothing Then
                            If RowCab.Item("ESTADO FECHA FOTO").ToString.Trim = "DENTRO DE TIEMPO" Or RowCab.Item("AREA").ToString.Trim = "LOGISTICO" Then
                                contador = contador + 1
                            End If
                            If RowCab.Item("LIM_PROV").ToString.Trim = "LIMA" Then
                                cantidadL = cantidadL + 1
                                If RowCab.Item("ESTADO FECHA FOTO").ToString.Trim = "DENTRO DE TIEMPO" Or RowCab.Item("AREA").ToString.Trim = "LOGISTICO" Then
                                    contadorL = contadorL + 1
                                End If
                            End If
                            If RowCab.Item("LIM_PROV").ToString.Trim = "PROVINCIA" Then
                                cantidadP = cantidadP + 1
                                If RowCab.Item("ESTADO FECHA FOTO").ToString.Trim = "DENTRO DE TIEMPO" Or RowCab.Item("AREA").ToString.Trim = "LOGISTICO" Then
                                    ContadorP = ContadorP + 1
                                End If
                            End If
                        End If
                    Else
                        If cmb_filtro.SelectedIndex = 0 Then
                            If RowCab.Item("ESTADO FECHA FOTO") IsNot Nothing Then
                                If RowCab.Item("ESTADO FECHA FOTO").ToString.Trim = "DENTRO DE TIEMPO" Then
                                    contador = contador + 1
                                End If
                            End If
                            If RowCab.Item("LIM_PROV").ToString.Trim = "LIMA" Then
                                cantidadL = cantidadL + 1
                                If RowCab.Item("ESTADO FECHA FOTO").ToString.Trim = "DENTRO DE TIEMPO" Then
                                    contadorL = contadorL + 1
                                End If
                            End If
                            If RowCab.Item("LIM_PROV").ToString.Trim = "PROVINCIA" Then
                                cantidadP = cantidadP + 1
                                If RowCab.Item("ESTADO FECHA FOTO").ToString.Trim = "DENTRO DE TIEMPO" Then
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

    Private Sub txt_guia_TextChanged(sender As Object, e As EventArgs) Handles txt_guia.TextChanged
        Try
            Filtrar()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SISTEMAS NORDIC")
        End Try
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
                'If i <> 9 And i <> 23 And i <> 25 Then
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

                    If Col = 3 Then
                        fecha = "'" & CStr(ElGrid.Rows(Fila).Cells(Col).Value)
                        exHoja.Cells.Item(Fila + 2, Col + 1) = "'" & CStr(ElGrid.Rows(Fila).Cells(Col).Value)
                    Else
                        If Col = 2 Or Col = 14 Or Col = 15 Or Col = 16 Or Col = 17 Then
                            exHoja.Cells.Item(Fila + 2, Col + 1) = ElGrid.Rows(Fila).Cells(Col).Value
                        Else
                            exHoja.Cells.Item(Fila + 2, Col + 1) = CStr(ElGrid.Rows(Fila).Cells(Col).Value)
                        End If


                    End If
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
            savedialog_Excel.FileName = "REPORTE DELIVERY ON TIME " + Now.Day.ToString + "_" + Now.Month.ToString + "_" + Now.Year.ToString
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
                CTD = Dg_Cabecera.CurrentRow.Cells("TIPO_DOCUMENTO").EditedFormattedValue.ToString
                CALMA = Dg_Cabecera.CurrentRow.Cells("ALMACEN").EditedFormattedValue.ToString
                Estado = Dg_Cabecera.CurrentRow.Cells("ESTADO FECHA FOTO").EditedFormattedValue.ToString
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Sub FormatoTablaCabecera()

        dtcabecera2.Clear()
        dtcabecera2 = Estructura.IndicadorDeliveryOnTime
        Dg_Cabecera.DataSource = dtcabecera2

        Dg_Cabecera.Columns("NRO_GUIA").HeaderText = "N° Guia"
        Dg_Cabecera.Columns("NRO_GUIA").Width = 70
        Dg_Cabecera.Columns("NRO_GUIA").ReadOnly = True

        Dg_Cabecera.Columns("TIPO_DOCUMENTO").HeaderText = "NTro Guia"
        Dg_Cabecera.Columns("TIPO_DOCUMENTO").Width = 70
        Dg_Cabecera.Columns("TIPO_DOCUMENTO").Visible = False

        Dg_Cabecera.Columns("FECHA_RETORNO_GUIA").HeaderText = "Fecha Retorno"
        Dg_Cabecera.Columns("FECHA_RETORNO_GUIA").Width = 70
        Dg_Cabecera.Columns("FECHA_RETORNO_GUIA").Visible = True



        Dg_Cabecera.Columns("ALMACEN").HeaderText = "Nro Guia"
        Dg_Cabecera.Columns("ALMACEN").Width = 70
        Dg_Cabecera.Columns("ALMACEN").Visible = False

        Dg_Cabecera.Columns("FECHA_DESPACHO").HeaderText = "Fech. Despacho"
        Dg_Cabecera.Columns("FECHA_DESPACHO").Width = 100
        Dg_Cabecera.Columns("FECHA_DESPACHO").ReadOnly = True

        Dg_Cabecera.Columns("HORA_DESPACHO").HeaderText = "Hora Despacho"
        Dg_Cabecera.Columns("HORA_DESPACHO").Width = 100
        Dg_Cabecera.Columns("HORA_DESPACHO").ReadOnly = True

        Dg_Cabecera.Columns("FECHA_SUBE_FOTO").HeaderText = "Fech. Sube Foto"
        Dg_Cabecera.Columns("FECHA_SUBE_FOTO").Width = 100
        Dg_Cabecera.Columns("FECHA_SUBE_FOTO").ReadOnly = True

        Dg_Cabecera.Columns("FECHA_RECEPCION_CLIENTE").HeaderText = "Fech. Recepcion Cliente"
        Dg_Cabecera.Columns("FECHA_RECEPCION_CLIENTE").Width = 100
        Dg_Cabecera.Columns("FECHA_RECEPCION_CLIENTE").ReadOnly = True

        Dg_Cabecera.Columns("Diferencia Foto").HeaderText = "Diferencia Días Foto"
        Dg_Cabecera.Columns("Diferencia Foto").Width = 70
        Dg_Cabecera.Columns("Diferencia Foto").ReadOnly = True

        Dg_Cabecera.Columns("Diferencia Recepcion").HeaderText = "Diferencia Días Recepcion"
        Dg_Cabecera.Columns("Diferencia Recepcion").Width = 70
        Dg_Cabecera.Columns("Diferencia Recepcion").ReadOnly = True

        Dg_Cabecera.Columns("Tolerancia").HeaderText = "Tolerancia Días"
        Dg_Cabecera.Columns("Tolerancia").Width = 70
        Dg_Cabecera.Columns("Tolerancia").ReadOnly = True


        Dg_Cabecera.Columns("ESTADO FECHA FOTO").HeaderText = "Estado Foto"
        Dg_Cabecera.Columns("ESTADO FECHA FOTO").Width = 100
        Dg_Cabecera.Columns("ESTADO FECHA FOTO").ReadOnly = True

        Dg_Cabecera.Columns("ESTADO FECHA RECEPCION").HeaderText = "Estado Recepcion"
        Dg_Cabecera.Columns("ESTADO FECHA RECEPCION").Width = 100
        Dg_Cabecera.Columns("ESTADO FECHA RECEPCION").ReadOnly = True

        Dg_Cabecera.Columns("RUC_CLIENTE").HeaderText = "Ruc Cliente"
        Dg_Cabecera.Columns("RUC_CLIENTE").Width = 100
        Dg_Cabecera.Columns("RUC_CLIENTE").ReadOnly = True

        Dg_Cabecera.Columns("CLIENTE").HeaderText = "Cliente"
        Dg_Cabecera.Columns("CLIENTE").Width = 250
        Dg_Cabecera.Columns("CLIENTE").ReadOnly = True

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

    End Sub

End Class