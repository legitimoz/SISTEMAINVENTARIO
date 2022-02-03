﻿Imports Nordic.Bl.Be

Public Class GestionDeliveryOnTime

    Private dtcabecera2, dtcabecera As New DataTable
    Public Estructura As New EstructuraTabla
    Private ObjAlmacen As New AlmacenL

    Private Sub GestionDeliveryOnTime_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CargaInicial()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CargaInicial()
        Try
            FormatoTablaCabecera()
            'ListarGuiasCabecera()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            ListarGuiasCabecera()
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

    Public Sub ListarGuiasCabecera()

        Try
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


                    'Tabladetalle.Columns.Add("COD_PED", GetType(String))
                    'Tabladetalle.Columns.Add("LIM_PROV", GetType(String))
                    'Tabladetalle.Columns.Add("PROVINCIA", GetType(String))
                    'Tabladetalle.Columns.Add("FECHA_PEDIDO", GetType(String))
                    'Tabladetalle.Columns.Add("FECHA_DESPACHO", GetType(String))
                    'Tabladetalle.Columns.Add("FECHA_RECEPCLIENTE", GetType(String))
                    'Tabladetalle.Columns.Add("TIEMPO_MAX", GetType(String))
                    'Tabladetalle.Columns.Add("TIEMPO_TRASN", GetType(String))
                    'Tabladetalle.Columns.Add("Estado", GetType(String))

                    rowcabecera.Item("COD_PED") = RowRetorno.Item("COD_PED").ToString.Trim

                    rowcabecera.Item("GUIA") = RowRetorno.Item("GUIA").ToString.Trim
                    rowcabecera.Item("LIM_PROV") = RowRetorno.Item("LIM_PROV").ToString.Trim
                    rowcabecera.Item("PROVINCIA") = RowRetorno.Item("PROVINCIA").ToString.Trim
                    rowcabecera.Item("FECHA_PEDIDO") = RowRetorno.Item("FECHA_PEDIDO").ToString.Trim
                    rowcabecera.Item("FECHA_GUIA") = RowRetorno.Item("FECHA_GUIA").ToString.Trim
                    rowcabecera.Item("FECHA_DESPACHO") = RowRetorno.Item("FECHA_DESPACHO").ToString.Trim
                    rowcabecera.Item("FECHA_RECEPCLIENTE") = RowRetorno.Item("FECHA_RECEPCLIENTE").ToString.Trim
                    rowcabecera.Item("TIEMPO_MAX") = RowRetorno.Item("TIEMPO_MAX").ToString.Trim
                    rowcabecera.Item("TIEMPO_TRASN") = RowRetorno.Item("TIEMPO_TRASN").ToString.Trim
                    rowcabecera.Item("Estado") = RowRetorno.Item("Estado").ToString.Trim

                    If rowcabecera.Item("Estado") IsNot Nothing Then
                        If rowcabecera.Item("Estado").ToString.Trim = "DENTRO DE TIEMPO" Then
                            contador = contador + 1
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
        Catch ex As Exception
            Throw ex
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
            Me.Cursor = Cursors.WaitCursor

            GridAExcel(Dg_Cabecera)

            Me.Cursor = Cursors.Default

        Catch ex As Exception

        End Try
    End Sub

    Public Sub FormatoTablaCabecera()

        dtcabecera2.Clear()
        dtcabecera2 = Estructura.IndicadorDeliveryOnTime
        Dg_Cabecera.DataSource = dtcabecera2

        Dg_Cabecera.Columns("COD_PED").HeaderText = "N° Pedido"
        Dg_Cabecera.Columns("COD_PED").Width = 70
        Dg_Cabecera.Columns("COD_PED").ReadOnly = True

        Dg_Cabecera.Columns("GUIA").HeaderText = "N° Guia"
        Dg_Cabecera.Columns("GUIA").Width = 70
        Dg_Cabecera.Columns("GUIA").ReadOnly = True

        Dg_Cabecera.Columns("FECHA_PEDIDO").HeaderText = "Fecha Pedido"
        Dg_Cabecera.Columns("FECHA_PEDIDO").Width = 100
        Dg_Cabecera.Columns("FECHA_PEDIDO").ReadOnly = True

        Dg_Cabecera.Columns("FECHA_GUIA").HeaderText = "Fecha Guia"
        Dg_Cabecera.Columns("FECHA_GUIA").Width = 100
        Dg_Cabecera.Columns("FECHA_GUIA").ReadOnly = True

        Dg_Cabecera.Columns("FECHA_DESPACHO").HeaderText = "Fecha Despacho"
        Dg_Cabecera.Columns("FECHA_DESPACHO").Width = 100
        Dg_Cabecera.Columns("FECHA_DESPACHO").ReadOnly = True

        Dg_Cabecera.Columns("LIM_PROV").HeaderText = "Lima Provincia"
        Dg_Cabecera.Columns("LIM_PROV").Width = 100
        Dg_Cabecera.Columns("LIM_PROV").ReadOnly = True

        Dg_Cabecera.Columns("PROVINCIA").HeaderText = "Provincia"
        Dg_Cabecera.Columns("PROVINCIA").Width = 100
        Dg_Cabecera.Columns("PROVINCIA").ReadOnly = True

        Dg_Cabecera.Columns("FECHA_RECEPCLIENTE").HeaderText = "Fecha Recepcion Cliente"
        Dg_Cabecera.Columns("FECHA_RECEPCLIENTE").Width = 70
        Dg_Cabecera.Columns("FECHA_RECEPCLIENTE").ReadOnly = True

        Dg_Cabecera.Columns("TIEMPO_MAX").HeaderText = "Tiempo Maximo"
        Dg_Cabecera.Columns("TIEMPO_MAX").Width = 70
        Dg_Cabecera.Columns("TIEMPO_MAX").ReadOnly = True

        Dg_Cabecera.Columns("TIEMPO_TRASN").HeaderText = "Tiempo Transcurrido"
        Dg_Cabecera.Columns("TIEMPO_TRASN").Width = 70
        Dg_Cabecera.Columns("TIEMPO_TRASN").ReadOnly = True

        Dg_Cabecera.Columns("Estado").HeaderText = "Estado"
        Dg_Cabecera.Columns("Estado").Width = 70
        Dg_Cabecera.Columns("Estado").ReadOnly = True

    End Sub

End Class