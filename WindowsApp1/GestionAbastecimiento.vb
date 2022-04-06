Imports ClosedXML.Excel
Imports Nordic.Bl.Be

Public Class GestionAbastecimiento
    Public usr_id As Integer
    Public usr_usuario As String

    Private AlmacenObj As New AlmacenL
    Private Estructura As New EstructuraTabla
    Private totalabcci As Decimal = 0
    Private AcumuladoPorcentaje As Decimal = 0
    Private MesesTranscurridos As Integer = 0
    Private MesInicio As Integer
    Private MesFin As Integer
    Private DtReporte As New DataTable

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CargaInicial()
        DtReporte = Estructura.ReporteAbastecimiento
    End Sub

    Private Sub GestionAbastecimiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CargaInicial()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Function GridAExcel_Stock(ByVal ElGrid As DataGridView) As Boolean

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
                exHoja.Cells.Item(1, i) = ElGrid.Columns(i - 1).HeaderText.ToString()
                exHoja.Cells.Item(1, i).Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.DarkBlue)
                'exHoja.Cells.Item(1, i).HorizontalAlignment = 3
            Next

            Dim fecha As String = String.Empty

            For Fila As Integer = 0 To NRow - 1
                For Col As Integer = 0 To NCol - 1


                    'If Col <> 19 And Col <> 20 And Col <> 21 Then
                    If ElGrid.Rows(Fila).Cells(Col).Value Is DBNull.Value Then
                        exHoja.Cells.Item(Fila + 2, Col + 1) = ""
                    Else
                        exHoja.Cells.Item(Fila + 2, Col + 1) = CStr(ElGrid.Rows(Fila).Cells(Col).Value)
                    End If

                    'End If



                    'exHoja.Cells.Item(Fila + 2, Col + 1).Font.Name = "Calibri"
                    'exHoja.Cells.Item(Fila + 2, Col + 1).Font.Size = 9
                    'If Col = 3 Or Col = 0 Or Col = 13 Or Col = 14 Or Col = 15 Or Col = 16 Or Col = 17 Then
                    '    fecha = "'" & CStr(ElGrid.Rows(Fila).Cells(Col).Value)
                    '    exHoja.Cells.Item(Fila + 2, Col + 1) = "'" & CStr(ElGrid.Rows(Fila).Cells(Col).Value)
                    'Else
                    '    If ElGrid.Rows(Fila).Cells(Col).Value Is DBNull.Value Then
                    '        exHoja.Cells.Item(Fila + 2, Col + 1) = ""
                    '    Else
                    '        exHoja.Cells.Item(Fila + 2, Col + 1) = CStr(ElGrid.Rows(Fila).Cells(Col).Value)
                    '    End If

                    'End If
                Next
            Next


            'For i As Integer = 0 To dgvControlStock.Rows.Count - 1
            '    Dim valor2 As String
            '    'Dim valor As Integer = CType(e.Value, Integer)
            '    valor2 = CStr(dgvControlStock.Rows(i).Cells.Item("COLOR1").Value)


            '    If valor2 = "NEGRO" Then
            '        exHoja.Cells.Item(i + 2, 4).Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black)

            '    Else
            '        If valor2 = "ROJO" Then
            '            exHoja.Cells.Item(i + 2, 4).Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red)

            '        Else
            '            If valor2 = "NARANJA" Then
            '                exHoja.Cells.Item(i + 2, 4).Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Orange)

            '            Else
            '                If valor2 = "AMARILLO" Then
            '                    exHoja.Cells.Item(i + 2, 4).Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow)

            '                End If
            '            End If
            '        End If
            '    End If


            'Next

            'exHoja.Cells.Item(2, 1).Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red)

            'Titulo en negrita, Alineado al centro y que el tamaño de la columna se
            'ajuste al texto
            exHoja.Rows.Item(1).Font.Name = "Calibri"
            exHoja.Rows.Item(1).Font.Size = 9
            exHoja.Rows.Item(1).Font.color = Color.White
            exHoja.Rows.Item(1).Font.Bold = 1
            exHoja.Rows.Item(1).HorizontalAlignment = 3

            exHoja.Columns.AutoFit()

            'exHoja.Rows.AutoFit()

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

    Private Sub btnBuscar_Click_1(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim Dt_Almacen As New DataTable
        Try
            ListarGuiasCabecera()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function LlamarArticulosAbastencer() As DataTable
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
            dtretono = AlmacenObj.ObtenerArticulosAbastercer(fechadesde, fechahasta).Copy
        Catch ex As Exception
            Throw ex
        End Try
        Return dtretono
    End Function

    Public Function ConsolidarDataGrid(dTconSolidad As DataTable) As DataTable
        Dim dtRetorno As New DataTable

        Try
            If dTconSolidad.Rows.Count > 0 Then
                dtRetorno = dTconSolidad.Clone
                For Each RowValidar As DataRow In dTconSolidad.Rows
                    If RowValidar.Item("CODIGO").ToString.Trim.Substring(0, 3) <> "PRC".ToString.Trim Then
                        dtRetorno.Rows.Add(RowValidar.ItemArray)
                    End If
                Next


                For Each RowVal2 As DataRow In dTconSolidad.Rows
                    If RowVal2.Item("CODIGO").ToString.Trim.Substring(0, 3) = "PRC".ToString.Trim Then

                        Dim Dt_Prd As New DataTable

                        Dt_Prd = LlamarObtenerPrdxPrc(RowVal2.Item("ARTICULO").ToString.Trim)

                        If Dt_Prd.Rows.Count > 0 Then
                            Dim Articulo As String = Dt_Prd.Rows(0).Item("AR_CCODIGO").ToString.Trim
                            RowVal2.Item("CODIGO") = Articulo
                            If dtRetorno.Rows.Count > 0 Then
                                Dim rp As Boolean = False
                                For Each RowRet As DataRow In dtRetorno.Rows
                                    If RowRet.Item("CODIGO").ToString.Trim = Articulo.Trim Then
                                        RowRet.Item("ENERO") = CType(RowRet.Item("ENERO").ToString, Integer) + CType(RowVal2.Item("ENERO").ToString, Integer)
                                        RowRet.Item("FEBRERO") = RowRet.Item("FEBRERO").ToString + CType(RowVal2.Item("FEBRERO").ToString, Integer)
                                        RowRet.Item("MARZO") = RowRet.Item("MARZO").ToString + CType(RowVal2.Item("MARZO").ToString, Integer)
                                        RowRet.Item("ABRIL") = RowRet.Item("ABRIL").ToString + CType(RowVal2.Item("ABRIL").ToString, Integer)
                                        RowRet.Item("MAYO") = RowRet.Item("MAYO").ToString + CType(RowVal2.Item("MAYO").ToString, Integer)
                                        RowRet.Item("JUNIO") = RowRet.Item("JUNIO").ToString + CType(RowVal2.Item("JUNIO").ToString, Integer)
                                        RowRet.Item("JULIO") = RowRet.Item("JULIO").ToString + CType(RowVal2.Item("JULIO").ToString, Integer)
                                        RowRet.Item("AGOSTO") = RowRet.Item("AGOSTO").ToString + CType(RowVal2.Item("AGOSTO").ToString, Integer)
                                        RowRet.Item("SETIEMBRE") = RowRet.Item("SETIEMBRE").ToString + CType(RowVal2.Item("SETIEMBRE").ToString, Integer)
                                        RowRet.Item("OCTUBRE") = RowRet.Item("OCTUBRE").ToString + CType(RowVal2.Item("OCTUBRE").ToString, Integer)
                                        RowRet.Item("NOVIEMBRE") = RowRet.Item("NOVIEMBRE").ToString + CType(RowVal2.Item("NOVIEMBRE").ToString, Integer)
                                        RowRet.Item("DICIEMBRE") = RowRet.Item("DICIEMBRE").ToString + CType(RowVal2.Item("DICIEMBRE").ToString, Integer)
                                        RowRet.Item("TOTAL") = RowRet.Item("TOTAL").ToString + CType(RowVal2.Item("TOTAL").ToString, Integer)
                                        RowRet.Item("ABC CI") = RowRet.Item("ABC CI").ToString + CType(RowVal2.Item("ABC CI").ToString, Integer)
                                        rp = True
                                        Exit For
                                    End If
                                Next
                                If rp = False Then
                                    dtRetorno.Rows.Add(RowVal2.ItemArray)
                                End If
                            End If
                        End If
                    End If
                Next

            End If
        Catch ex As Exception
            Throw ex
        End Try
        Return dtRetorno
    End Function

    Public Function LlamarObtenerPrdxPrc(descripcion As String) As DataTable
        Dim rp_retorno As New DataTable
        Try
            rp_retorno = AlmacenObj.SP_CSE_OBTENER_PRD_X_DESCRIPCION(descripcion)
        Catch ex As Exception
            Throw ex
        End Try
        Return rp_retorno
    End Function

    Public Sub ListarGuiasCabecera()
        Try
            totalabcci = 0
            AcumuladoPorcentaje = 0
            mesesDiferencia()

            Dim DataAbastecer As New DataTable
            Dim RetornoTabla As New DataTable
            If Dg_Cabecera.Rows.Count > 0 Then
                Dg_Cabecera.Rows.Clear()
            End If
            Dim dtretorno As New DataTable
            dtretorno = LlamarArticulosAbastencer()
            If dtretorno.Rows.Count > 0 Then
                DataAbastecer = Estructura.Tabla_Abastecer
                Dim RowAbastercer As DataRow

                For Each Recorre As DataRow In dtretorno.Rows
                    RowAbastercer = DataAbastecer.NewRow

                    If Recorre.Item("CODIGO").ToString.Trim = "PRD0000160" Then
                        Dim gola As Integer = 0
                        gola = 2
                    End If

                    RowAbastercer.Item("CODIGO") = Recorre.Item("CODIGO").ToString.Trim
                    RowAbastercer.Item("TIPO ORIGEN") = Recorre.Item("TIPO ORIGEN").ToString.Trim
                    RowAbastercer.Item("ARTICULO") = Recorre.Item("ARTICULO").ToString.Trim
                    RowAbastercer.Item("UU CAJA") = CType(Recorre.Item("UU CAJA").ToString.Trim, Integer)
                    RowAbastercer.Item("AR_NANCHO") = Recorre.Item("AR_NANCHO").ToString.Trim
                    RowAbastercer.Item("AR_NLARGO") = Recorre.Item("AR_NLARGO").ToString.Trim
                    RowAbastercer.Item("AR_CTALLA") = Recorre.Item("AR_CTALLA").ToString.Trim
                    RowAbastercer.Item("CAJA CM") = Recorre.Item("CAJA CM").ToString.Trim
                    RowAbastercer.Item("ENERO") = Recorre.Item("ENERO").ToString.Trim
                    RowAbastercer.Item("FEBRERO") = Recorre.Item("FEBRERO").ToString.Trim
                    RowAbastercer.Item("MARZO") = Recorre.Item("MARZO").ToString.Trim
                    RowAbastercer.Item("ABRIL") = Recorre.Item("ABRIL").ToString.Trim
                    RowAbastercer.Item("MAYO") = Recorre.Item("MAYO").ToString.Trim
                    RowAbastercer.Item("JUNIO") = Recorre.Item("JUNIO").ToString.Trim
                    RowAbastercer.Item("JULIO") = Recorre.Item("JULIO").ToString.Trim
                    RowAbastercer.Item("AGOSTO") = Recorre.Item("AGOSTO").ToString.Trim
                    RowAbastercer.Item("SETIEMBRE") = Recorre.Item("SETIEMBRE").ToString.Trim
                    RowAbastercer.Item("OCTUBRE") = Recorre.Item("OCTUBRE").ToString.Trim
                    RowAbastercer.Item("NOVIEMBRE") = Recorre.Item("NOVIEMBRE").ToString.Trim
                    RowAbastercer.Item("DICIEMBRE") = Recorre.Item("DICIEMBRE").ToString.Trim
                    RowAbastercer.Item("TOTAL") = Recorre.Item("TOTAL").ToString.Trim
                    RowAbastercer.Item("ABC CI") = Math.Round(CType(Recorre.Item("ABC CI").ToString.Trim, Decimal), 3)
                    DataAbastecer.Rows.Add(RowAbastercer)
                Next

            End If
            If DataAbastecer.Rows.Count > 0 Then
                RetornoTabla = ConsolidarDataGrid(DataAbastecer)
            End If

            If RetornoTabla.Rows.Count > 0 Then

                For Each rowCi As DataRow In RetornoTabla.Rows
                    totalabcci = totalabcci + rowCi.Item("ABC CI").ToString
                Next

                Dim contador As Integer = 0
                For Each RowRetorno As DataRow In RetornoTabla.Rows
                    Dim Frecuencia As Integer = 0
                    Dim FrecuenciaB As Integer = 0

                    If (CType(RowRetorno.Item("TOTAL").ToString.Trim, Integer)) > 0 Then

                        Dg_Cabecera.Rows.Add()
                        Dg_Cabecera.Rows(contador).Cells("CODIGO").Value = RowRetorno.Item("CODIGO").ToString.Trim

                        If RowRetorno.Item("CODIGO").ToString.Trim = "PRD0000160" Then
                            Dim gola As Integer = 0
                            gola = 2
                        End If
                        Dg_Cabecera.Rows(contador).Cells("TIPOORIGEN").Value = RowRetorno.Item("TIPO ORIGEN").ToString.Trim
                        Dg_Cabecera.Rows(contador).Cells("ARTICULO").Value = RowRetorno.Item("ARTICULO").ToString.Trim
                        Dg_Cabecera.Rows(contador).Cells("UUCAJA").Value = RowRetorno.Item("UU CAJA").ToString
                        If CType(Dg_Cabecera.Rows(contador).Cells("UUCAJA").Value, Integer) = 0 Then
                            Dg_Cabecera.Rows(contador).Cells("UUCAJA").Value = 1
                        End If
                        Dg_Cabecera.Rows(contador).Cells("CAJASCM").Value = RowRetorno.Item("CAJA CM").ToString.Trim

                        If Dg_Cabecera.Rows(contador).Cells("CAJASCM").Value = "" Then
                            Dg_Cabecera.Rows(contador).Cells("CAJASCM").Value = 1
                        Else
                            If CType(Dg_Cabecera.Rows(contador).Cells("CAJASCM").Value, Integer) = 0 Then
                                Dg_Cabecera.Rows(contador).Cells("CAJASCM").Value = 1
                            End If
                        End If
                        ' Dim FactorCJCJM As Integer = CType(Dg_Cabecera.Rows(contador).Cells("CAJASCM").Value, Integer) * CType(Dg_Cabecera.Rows(contador).Cells("UUCAJA").Value, Integer)
                        Dg_Cabecera.Rows(contador).Cells("ANCHO").Value = Math.Round(CType(RowRetorno.Item("AR_NANCHO").ToString, Decimal), 2)
                        If Dg_Cabecera.Rows(contador).Cells("ANCHO").Value = 0 Then
                            Dg_Cabecera.Rows(contador).Cells("ANCHO").Value = 0.35
                        End If

                        Dg_Cabecera.Rows(contador).Cells("LARGO").Value = Math.Round(CType(RowRetorno.Item("AR_NLARGO").ToString, Decimal), 2)
                        If Dg_Cabecera.Rows(contador).Cells("LARGO").Value = 0 Then
                            Dg_Cabecera.Rows(contador).Cells("LARGO").Value = 0.35
                        End If

                        If RowRetorno.Item("AR_CTALLA").ToString.Trim = "" Then
                            Dg_Cabecera.Rows(contador).Cells("ALTO").Value = 0.35
                        Else
                            If CType(RowRetorno.Item("AR_CTALLA").ToString.Trim, Decimal) = 0 Then
                                Dg_Cabecera.Rows(contador).Cells("ALTO").Value = 0.35
                            Else
                                Dg_Cabecera.Rows(contador).Cells("ALTO").Value = RowRetorno.Item("AR_CTALLA").ToString.Trim
                            End If
                        End If

                        Dg_Cabecera.Rows(contador).Cells("ENERO").Value = RowRetorno.Item("ENERO").ToString
                        If CType(RowRetorno.Item("ENERO").ToString, Integer) <> 0 Then
                            Frecuencia = Frecuencia + 1
                        End If
                        Dg_Cabecera.Rows(contador).Cells("FEBRERO").Value = RowRetorno.Item("FEBRERO").ToString
                        If CType(RowRetorno.Item("FEBRERO").ToString, Integer) <> 0 Then
                            Frecuencia = Frecuencia + 1
                        End If
                        Dg_Cabecera.Rows(contador).Cells("MARZO").Value = RowRetorno.Item("MARZO").ToString
                        If CType(RowRetorno.Item("MARZO").ToString, Integer) <> 0 Then
                            Frecuencia = Frecuencia + 1
                        End If
                        Dg_Cabecera.Rows(contador).Cells("ABRIL").Value = RowRetorno.Item("ABRIL").ToString
                        If CType(RowRetorno.Item("ABRIL").ToString, Integer) <> 0 Then
                            Frecuencia = Frecuencia + 1
                        End If
                        Dg_Cabecera.Rows(contador).Cells("MAYO").Value = RowRetorno.Item("MAYO").ToString
                        If CType(RowRetorno.Item("MAYO").ToString, Integer) <> 0 Then
                            Frecuencia = Frecuencia + 1
                        End If
                        Dg_Cabecera.Rows(contador).Cells("JUNIO").Value = RowRetorno.Item("JUNIO").ToString
                        If CType(RowRetorno.Item("JUNIO").ToString, Integer) <> 0 Then
                            Frecuencia = Frecuencia + 1
                        End If
                        Dg_Cabecera.Rows(contador).Cells("JULIO").Value = RowRetorno.Item("JULIO").ToString
                        If CType(RowRetorno.Item("JULIO").ToString, Integer) <> 0 Then
                            Frecuencia = Frecuencia + 1
                        End If
                        Dg_Cabecera.Rows(contador).Cells("AGOSTO").Value = RowRetorno.Item("AGOSTO").ToString
                        If CType(RowRetorno.Item("AGOSTO").ToString, Integer) <> 0 Then
                            Frecuencia = Frecuencia + 1
                        End If
                        Dg_Cabecera.Rows(contador).Cells("SETIEMBRE").Value = RowRetorno.Item("SETIEMBRE").ToString
                        If CType(RowRetorno.Item("SETIEMBRE").ToString, Integer) <> 0 Then
                            Frecuencia = Frecuencia + 1
                        End If
                        Dg_Cabecera.Rows(contador).Cells("OCTUBRE").Value = RowRetorno.Item("OCTUBRE").ToString
                        If CType(RowRetorno.Item("OCTUBRE").ToString, Integer) <> 0 Then
                            Frecuencia = Frecuencia + 1
                        End If
                        Dg_Cabecera.Rows(contador).Cells("NOVIEMBRE").Value = RowRetorno.Item("NOVIEMBRE").ToString
                        If CType(RowRetorno.Item("NOVIEMBRE").ToString, Integer) <> 0 Then
                            Frecuencia = Frecuencia + 1
                        End If
                        Dg_Cabecera.Rows(contador).Cells("DICIEMBRE").Value = RowRetorno.Item("DICIEMBRE").ToString
                        If CType(RowRetorno.Item("DICIEMBRE").ToString, Integer) <> 0 Then
                            Frecuencia = Frecuencia + 1
                        End If

                        If Frecuencia > MesesTranscurridos Then
                            Frecuencia = MesesTranscurridos
                        End If

                        If MesFin = 1 Then
                            If CType(RowRetorno.Item("ENERO").ToString, Integer) <> 0 Then
                                FrecuenciaB = FrecuenciaB + 1
                            End If

                            If CType(RowRetorno.Item("DICIEMBRE").ToString, Integer) <> 0 Then
                                FrecuenciaB = FrecuenciaB + 1
                            End If

                            If CType(RowRetorno.Item("NOVIEMBRE").ToString, Integer) <> 0 Then
                                FrecuenciaB = FrecuenciaB + 1
                            End If
                        End If

                        If MesFin = 2 Then
                            If CType(RowRetorno.Item("FEBRERO").ToString, Integer) <> 0 Then
                                FrecuenciaB = FrecuenciaB + 1
                            End If

                            If CType(RowRetorno.Item("ENERO").ToString, Integer) <> 0 Then
                                FrecuenciaB = FrecuenciaB + 1
                            End If

                            If CType(RowRetorno.Item("DICIEMBRE").ToString, Integer) <> 0 Then
                                FrecuenciaB = FrecuenciaB + 1
                            End If
                        End If

                        If MesFin = 3 Then
                            If CType(RowRetorno.Item("MARZO").ToString, Integer) <> 0 Then
                                FrecuenciaB = FrecuenciaB + 1
                            End If
                            If CType(RowRetorno.Item("FEBRERO").ToString, Integer) <> 0 Then
                                FrecuenciaB = FrecuenciaB + 1
                            End If

                            If CType(RowRetorno.Item("ENERO").ToString, Integer) <> 0 Then
                                FrecuenciaB = FrecuenciaB + 1
                            End If
                        End If

                        If MesFin = 4 Then
                            If CType(RowRetorno.Item("ABRIL").ToString, Integer) <> 0 Then
                                FrecuenciaB = FrecuenciaB + 1
                            End If
                            If CType(RowRetorno.Item("MARZO").ToString, Integer) <> 0 Then
                                FrecuenciaB = FrecuenciaB + 1
                            End If
                            If CType(RowRetorno.Item("FEBRERO").ToString, Integer) <> 0 Then
                                FrecuenciaB = FrecuenciaB + 1
                            End If
                        End If

                        If MesFin = 5 Then
                            If CType(RowRetorno.Item("MAYO").ToString, Integer) <> 0 Then
                                FrecuenciaB = FrecuenciaB + 1
                            End If
                            If CType(RowRetorno.Item("ABRIL").ToString, Integer) <> 0 Then
                                FrecuenciaB = FrecuenciaB + 1
                            End If
                            If CType(RowRetorno.Item("MARZO").ToString, Integer) <> 0 Then
                                FrecuenciaB = FrecuenciaB + 1
                            End If
                        End If

                        If MesFin = 6 Then
                            If CType(RowRetorno.Item("JUNIO").ToString, Integer) <> 0 Then
                                FrecuenciaB = FrecuenciaB + 1
                            End If
                            If CType(RowRetorno.Item("MAYO").ToString, Integer) <> 0 Then
                                FrecuenciaB = FrecuenciaB + 1
                            End If
                            If CType(RowRetorno.Item("ABRIL").ToString, Integer) <> 0 Then
                                FrecuenciaB = FrecuenciaB + 1
                            End If

                        End If

                        If MesFin = 7 Then
                            If CType(RowRetorno.Item("JULIO").ToString, Integer) <> 0 Then
                                FrecuenciaB = FrecuenciaB + 1
                            End If
                            If CType(RowRetorno.Item("JUNIO").ToString, Integer) <> 0 Then
                                FrecuenciaB = FrecuenciaB + 1
                            End If
                            If CType(RowRetorno.Item("MAYO").ToString, Integer) <> 0 Then
                                FrecuenciaB = FrecuenciaB + 1
                            End If
                        End If

                        If MesFin = 8 Then
                            If CType(RowRetorno.Item("AGOSTO").ToString, Integer) <> 0 Then
                                FrecuenciaB = FrecuenciaB + 1
                            End If
                            If CType(RowRetorno.Item("JULIO").ToString, Integer) <> 0 Then
                                FrecuenciaB = FrecuenciaB + 1
                            End If
                            If CType(RowRetorno.Item("JUNIO").ToString, Integer) <> 0 Then
                                FrecuenciaB = FrecuenciaB + 1
                            End If

                        End If

                        If MesFin = 9 Then

                            If CType(RowRetorno.Item("SETIEMBRE").ToString, Integer) <> 0 Then
                                FrecuenciaB = FrecuenciaB + 1
                            End If
                            If CType(RowRetorno.Item("AGOSTO").ToString, Integer) <> 0 Then
                                FrecuenciaB = FrecuenciaB + 1
                            End If
                            If CType(RowRetorno.Item("JULIO").ToString, Integer) <> 0 Then
                                FrecuenciaB = FrecuenciaB + 1
                            End If


                        End If
                        If MesFin = 10 Then
                            If CType(RowRetorno.Item("OCTUBRE").ToString, Integer) <> 0 Then
                                FrecuenciaB = FrecuenciaB + 1
                            End If
                            If CType(RowRetorno.Item("SETIEMBRE").ToString, Integer) <> 0 Then
                                FrecuenciaB = FrecuenciaB + 1
                            End If
                            If CType(RowRetorno.Item("AGOSTO").ToString, Integer) <> 0 Then
                                FrecuenciaB = FrecuenciaB + 1
                            End If
                        End If
                        If MesFin = 11 Then
                            If CType(RowRetorno.Item("NOVIEMBRE").ToString, Integer) <> 0 Then
                                FrecuenciaB = FrecuenciaB + 1
                            End If
                            If CType(RowRetorno.Item("OCTUBRE").ToString, Integer) <> 0 Then
                                FrecuenciaB = FrecuenciaB + 1
                            End If

                            If CType(RowRetorno.Item("SETIEMBRE").ToString, Integer) <> 0 Then
                                FrecuenciaB = FrecuenciaB + 1
                            End If

                        End If

                        If MesFin = 12 Then
                            If CType(RowRetorno.Item("DICIEMBRE").ToString, Integer) <> 0 Then
                                FrecuenciaB = FrecuenciaB + 1
                            End If
                            If CType(RowRetorno.Item("NOVIEMBRE").ToString, Integer) <> 0 Then
                                FrecuenciaB = FrecuenciaB + 1
                            End If
                            If CType(RowRetorno.Item("OCTUBRE").ToString, Integer) <> 0 Then
                                FrecuenciaB = FrecuenciaB + 1
                            End If
                        End If

                        Dim Mayor As Integer = 0
                        Mayor = CType(RowRetorno.Item("ENERO").ToString, Integer)
                        If CType(RowRetorno.Item("FEBRERO").ToString, Integer) > Mayor Then
                            Mayor = CType(RowRetorno.Item("FEBRERO").ToString, Integer)
                        End If
                        If CType(RowRetorno.Item("MARZO").ToString, Integer) > Mayor Then
                            Mayor = CType(RowRetorno.Item("MARZO").ToString, Integer)
                        End If
                        If CType(RowRetorno.Item("ABRIL").ToString, Integer) > Mayor Then
                            Mayor = CType(RowRetorno.Item("ABRIL").ToString, Integer)
                        End If
                        If CType(RowRetorno.Item("MAYO").ToString, Integer) > Mayor Then
                            Mayor = CType(RowRetorno.Item("MAYO").ToString, Integer)
                        End If
                        If CType(RowRetorno.Item("JUNIO").ToString, Integer) > Mayor Then
                            Mayor = CType(RowRetorno.Item("JUNIO").ToString, Integer)
                        End If
                        If CType(RowRetorno.Item("JULIO").ToString, Integer) > Mayor Then
                            Mayor = CType(RowRetorno.Item("JULIO").ToString, Integer)
                        End If
                        If CType(RowRetorno.Item("AGOSTO").ToString, Integer) > Mayor Then
                            Mayor = CType(RowRetorno.Item("AGOSTO").ToString, Integer)
                        End If
                        If CType(RowRetorno.Item("SETIEMBRE").ToString, Integer) > Mayor Then
                            Mayor = CType(RowRetorno.Item("SETIEMBRE").ToString, Integer)
                        End If
                        If CType(RowRetorno.Item("OCTUBRE").ToString, Integer) > Mayor Then
                            Mayor = CType(RowRetorno.Item("OCTUBRE").ToString, Integer)
                        End If
                        If CType(RowRetorno.Item("NOVIEMBRE").ToString, Integer) > Mayor Then
                            Mayor = CType(RowRetorno.Item("NOVIEMBRE").ToString, Integer)
                        End If
                        If CType(RowRetorno.Item("DICIEMBRE").ToString, Integer) > Mayor Then
                            Mayor = CType(RowRetorno.Item("DICIEMBRE").ToString, Integer)
                        End If

                        Dg_Cabecera.Rows(contador).Cells("FRECUENCIA").Value = Frecuencia
                        Dg_Cabecera.Rows(contador).Cells("FRECUENCIAB").Value = FrecuenciaB
                        Dg_Cabecera.Rows(contador).Cells("TOTALVENTA").Value = CType(RowRetorno.Item("TOTAL").ToString, Integer)
                        Dg_Cabecera.Rows(contador).Cells("ABCCI").Value = RowRetorno.Item("ABC CI").ToString
                        Dg_Cabecera.Rows(contador).Cells("PORCENTAJE").Value = Math.Round(CType((CType(RowRetorno.Item("ABC CI").ToString, Decimal) / totalabcci) * 100, Decimal), 5)
                        AcumuladoPorcentaje = AcumuladoPorcentaje + Dg_Cabecera.Rows(contador).Cells("PORCENTAJE").Value
                        If AcumuladoPorcentaje <= 80 And AcumuladoPorcentaje > 0 Then
                            Dg_Cabecera.Rows(contador).Cells("ABC").Value = "A"
                        Else
                            If AcumuladoPorcentaje > 80 And AcumuladoPorcentaje <= 95 Then
                                Dg_Cabecera.Rows(contador).Cells("ABC").Value = "B"
                            Else
                                If AcumuladoPorcentaje > 0 And AcumuladoPorcentaje > 95 Then
                                    Dg_Cabecera.Rows(contador).Cells("ABC").Value = "C"
                                End If
                            End If
                        End If
                        Dg_Cabecera.Rows(contador).Cells("PORCENACUMU").Value = Math.Ceiling(AcumuladoPorcentaje)
                        Dg_Cabecera.Rows(contador).Cells("VOLCJMU").Value = CType(Dg_Cabecera.Rows(contador).Cells("ANCHO").Value, Decimal) * CType(Dg_Cabecera.Rows(contador).Cells("LARGO").Value, Decimal) * CType(Dg_Cabecera.Rows(contador).Cells("ALTO").Value, Decimal)
                        Dg_Cabecera.Rows(contador).Cells("MULTIPLICACIONFACTORES").Value = CType(Dg_Cabecera.Rows(contador).Cells("UUCAJA").Value, Integer) * CType(Dg_Cabecera.Rows(contador).Cells("CAJASCM").Value, Integer)
                        Dg_Cabecera.Rows(contador).Cells("VOLUMENUNIDAD").Value = Math.Round(CType(Dg_Cabecera.Rows(contador).Cells("VOLCJMU").Value, Decimal) / CType(Dg_Cabecera.Rows(contador).Cells("MULTIPLICACIONFACTORES").Value, Integer), 7)

                        Dim porcentajeMeses As Decimal = 0
                        Dim Tipo As String = ""
                        porcentajeMeses = (Frecuencia / MesesTranscurridos) * 100
                        If porcentajeMeses >= 80 Then
                            Tipo = "STOCK"
                        Else
                            If porcentajeMeses < 80 And porcentajeMeses >= 50 Then
                                Tipo = "A PEDIDO"
                            Else
                                If porcentajeMeses < 50 Then
                                    Tipo = "TEMPORAL"
                                End If
                            End If
                        End If

                        If FrecuenciaB = 3 Then
                            Tipo = "STOCK"
                        End If
                        Dg_Cabecera.Rows(contador).Cells("TIPO").Value = Tipo

                        Dim Total As Integer = 0
                        Total = (CType(RowRetorno.Item("TOTAL").ToString, Integer))
                        'If Frecuencia > 3 Then
                        '    Total = Total - Mayor
                        'End If



                        Dg_Cabecera.Rows(contador).Cells("VENTAMES").Value = Math.Ceiling(Total / (MesesTranscurridos))

                        Dim PromedioActual As Integer = Dg_Cabecera.Rows(contador).Cells("VENTAMES").Value

                        Dim Dt_Promedio As New DataTable
                        Dt_Promedio = AlmacenObj.sp_obtener_promedio_fijo(RowRetorno.Item("CODIGO").ToString.Trim)
                        If Dt_Promedio.Rows.Count > 0 Then
                            Dim PromedioFijo As Integer = 0
                            PromedioFijo = Dt_Promedio.Rows(0).Item("PROMEDIO").ToString
                            If PromedioFijo > PromedioActual Then
                                Dg_Cabecera.Rows(contador).Cells("VENTAMES").Value = PromedioFijo
                            End If
                        End If

                        Dg_Cabecera.Rows(contador).Cells("METROSVF").Value = Math.Ceiling(CType(Dg_Cabecera.Rows(contador).Cells("VENTAMES").Value * Dg_Cabecera.Rows(contador).Cells("VOLUMENUNIDAD").Value, Decimal))
                        Dg_Cabecera.Rows(contador).Cells("PORCENABASTECER").Value = 100
                        If Dg_Cabecera.Rows(contador).Cells("CODIGO").Value.ToString.Trim = "PRD0002663".Trim Then
                            Dg_Cabecera.Rows(contador).Cells("PORCENABASTECER").Value = 40
                        End If
                        If Dg_Cabecera.Rows(contador).Cells("CODIGO").Value.ToString.Trim = "PRD0011203".Trim Then
                            Dg_Cabecera.Rows(contador).Cells("PORCENABASTECER").Value = 40
                        End If
                        If Dg_Cabecera.Rows(contador).Cells("CODIGO").Value.ToString.Trim = "PRD0011106".Trim Then
                            Dg_Cabecera.Rows(contador).Cells("PORCENABASTECER").Value = 40
                        End If

                        Dim DtStock As New DataTable
                        DtStock = ObtenerStocks(Dg_Cabecera.Rows(contador).Cells("CODIGO").Value.ToString.Trim)

                        If DtStock.Rows.Count > 0 Then
                            Dg_Cabecera.Rows(contador).Cells("STOCKATE").Value = DtStock.Rows(0).Item("STOCKATE").ToString
                            Dg_Cabecera.Rows(contador).Cells("STOCKCJM").Value = DtStock.Rows(0).Item("STOCKCJM").ToString
                        Else
                            Dg_Cabecera.Rows(contador).Cells("STOCKATE").Value = 0
                            Dg_Cabecera.Rows(contador).Cells("STOCKCJM").Value = 0
                        End If
                        Dg_Cabecera.Rows(contador).Cells("UUABASTECE").Value = Math.Ceiling((Dg_Cabecera.Rows(contador).Cells("PORCENABASTECER").Value * Dg_Cabecera.Rows(contador).Cells("VENTAMES").Value) / 100)
                        Dg_Cabecera.Rows(contador).Cells("M3ABASTECER").Value = Math.Ceiling(Dg_Cabecera.Rows(contador).Cells("UUABASTECE").Value * Dg_Cabecera.Rows(contador).Cells("VOLUMENUNIDAD").Value)

                        If Dg_Cabecera.Rows(contador).Cells("STOCKATE").Value > Dg_Cabecera.Rows(contador).Cells("UUABASTECE").Value Then
                            Dg_Cabecera.Rows(contador).Cells("UUABASTATE").Value = 0
                        Else
                            Dg_Cabecera.Rows(contador).Cells("UUABASTATE").Value = Dg_Cabecera.Rows(contador).Cells("UUABASTECE").Value - Dg_Cabecera.Rows(contador).Cells("STOCKATE").Value
                        End If

                        If Dg_Cabecera.Rows(contador).Cells("STOCKCJM").Value < Dg_Cabecera.Rows(contador).Cells("UUABASTATE").Value Then
                            Dg_Cabecera.Rows(contador).Cells("UUREALABASATE").Value = Dg_Cabecera.Rows(contador).Cells("STOCKCJM").Value
                        Else
                            Dg_Cabecera.Rows(contador).Cells("UUREALABASATE").Value = Dg_Cabecera.Rows(contador).Cells("UUABASTATE").Value
                        End If
                        Dg_Cabecera.Rows(contador).Cells("ABASTECJMATE").Value = Math.Ceiling(CType((Dg_Cabecera.Rows(contador).Cells("UUREALABASATE").Value / Dg_Cabecera.Rows(contador).Cells("MULTIPLICACIONFACTORES").Value), Decimal))
                        Dg_Cabecera.Rows(contador).Cells("ABASTEM3").Value = Dg_Cabecera.Rows(contador).Cells("VOLCJMU").Value * Dg_Cabecera.Rows(contador).Cells("ABASTECJMATE").Value
                        Dg_Cabecera.Rows(contador).Cells("COBERTACTUAL").Value = Math.Ceiling((Dg_Cabecera.Rows(contador).Cells("STOCKATE").Value / Dg_Cabecera.Rows(contador).Cells("VENTAMES").Value) * 30)
                        Dg_Cabecera.Rows(contador).Cells("ABASTUNI").Value = Dg_Cabecera.Rows(contador).Cells("ABASTECJMATE").Value * Dg_Cabecera.Rows(contador).Cells("MULTIPLICACIONFACTORES").Value
                        Dg_Cabecera.Rows(contador).Cells("STOCKFINALATE").Value = Dg_Cabecera.Rows(contador).Cells("ABASTUNI").Value + Dg_Cabecera.Rows(contador).Cells("STOCKATE").Value
                        Dg_Cabecera.Rows(contador).Cells("COBERTFINAL").Value = Math.Ceiling((Dg_Cabecera.Rows(contador).Cells("STOCKFINALATE").Value / Dg_Cabecera.Rows(contador).Cells("VENTAMES").Value) * 30)
                        Dg_Cabecera.Rows(contador).Cells("SELECCIONAR").Value = False
                        If CType(Dg_Cabecera.Rows(contador).Cells("COBERTFINAL").Value, Integer) <= 7 Then
                            Dg_Cabecera.Rows(contador).Cells("ACCION").Value = "ABASTECER"
                        Else
                            If CType(Dg_Cabecera.Rows(contador).Cells("COBERTFINAL").Value, Integer) > 7 And CType(Dg_Cabecera.Rows(contador).Cells("COBERTFINAL").Value, Integer) <= 50 Then
                                Dg_Cabecera.Rows(contador).Cells("ACCION").Value = "OK"
                            Else
                                If CType(Dg_Cabecera.Rows(contador).Cells("COBERTFINAL").Value, Integer) > 50 Then
                                    Dg_Cabecera.Rows(contador).Cells("ACCION").Value = "DEVOLVER CJM"
                                End If
                            End If
                        End If

                        'If Dg_Cabecera.Rows(contador).Cells("UUREALABASATE").Value > Dg_Cabecera.Rows(contador).Cells("STOCKCJM").Value Then
                        '    Dg_Cabecera.Rows(contador).Cells("ACCIONFINAL").Value = "SIN STOCK SUF_CJM"
                        'Else
                        '    Dg_Cabecera.Rows(contador).Cells("ACCIONFINAL").Value = "OK"
                        'End If
                        If CType(Dg_Cabecera.Rows(contador).Cells("STOCKCJM").Value, Integer) = 0 Then
                            Dg_Cabecera.Rows(contador).Cells("ACCIONFINAL").Value = "SIN STOCK CJM"
                        Else
                            If CType(Dg_Cabecera.Rows(contador).Cells("STOCKCJM").Value, Integer) > 0 And CType(Dg_Cabecera.Rows(contador).Cells("STOCKCJM").Value, Integer) < CType(Dg_Cabecera.Rows(contador).Cells("UUABASTECE").Value, Integer) Then
                                Dg_Cabecera.Rows(contador).Cells("ACCIONFINAL").Value = "STOCK DE CJM INSUFICIENTE"
                            Else
                                If CType(Dg_Cabecera.Rows(contador).Cells("STOCKCJM").Value, Integer) > 0 And CType(Dg_Cabecera.Rows(contador).Cells("STOCKCJM").Value, Integer) >= CType(Dg_Cabecera.Rows(contador).Cells("UUABASTECE").Value, Integer) Then
                                    Dg_Cabecera.Rows(contador).Cells("ACCIONFINAL").Value = "OK"
                                End If
                            End If
                        End If

                        Dg_Cabecera.Rows(contador).Cells("DEVOLVERCJM").Value = CType(0, Decimal)
                        Dg_Cabecera.Rows(contador).Cells("M3DEVOLVERCJM").Value = CType(0, Decimal)

                        If Dg_Cabecera.Rows(contador).Cells("ACCION").Value.ToString = "DEVOLVER CJM" Then
                            Dg_Cabecera.Rows(contador).Cells("DEVOLVERCJM").Value = CType(Math.Ceiling(((CType(Dg_Cabecera.Rows(contador).Cells("STOCKFINALATE").Value, Integer) - Dg_Cabecera.Rows(contador).Cells("VENTAMES").Value) * 2) / Dg_Cabecera.Rows(contador).Cells("MULTIPLICACIONFACTORES").Value), Decimal)
                            If Dg_Cabecera.Rows(contador).Cells("DEVOLVERCJM").Value <> 0 Then
                                Dg_Cabecera.Rows(contador).Cells("M3DEVOLVERCJM").Value = CType(Math.Ceiling(Dg_Cabecera.Rows(contador).Cells("DEVOLVERCJM").Value * Dg_Cabecera.Rows(contador).Cells("VOLCJMU").Value), Decimal)
                            Else
                                Dg_Cabecera.Rows(contador).Cells("M3DEVOLVERCJM").Value = CType(0, Decimal)
                            End If
                        Else
                            Dg_Cabecera.Rows(contador).Cells("DEVOLVERCJM").Value = CType(0, Decimal)
                            Dg_Cabecera.Rows(contador).Cells("M3DEVOLVERCJM").Value = CType(0, Decimal)
                        End If

                        contador = contador + 1
                    End If
                Next
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Function ObtenerStocks(codarticulo As String) As DataTable
        Dim dtrpa As New DataTable
        Try
            dtrpa = AlmacenObj.obtenerStock_ATE_CJM_X_CODIGOARTI(codarticulo.Trim)
        Catch ex As Exception
            Throw ex
        End Try
        Return dtrpa
    End Function

    Public Sub mesesDiferencia()
        Dim meses As Integer = 0

        Dim fechaIni As Date = dt_desde.Value
        Dim FechaFin As Date = dt_hasta.Value

        Dim dias As Integer = 0
        dias = DateDiff(DateInterval.Day, fechaIni, FechaFin)

        meses = DateDiff(DateInterval.Month, fechaIni, FechaFin)
        Dim residuo As Decimal = dias Mod 30
        If (dias Mod 30 = 0) Then
            'MsgBox("meses transcurridos" & meses & "NumDias: " & dias & "residuo: " & residuo)
        Else
            meses += 1
            ' MsgBox("meses transcurridos" & meses & "NumDias: " & dias & "residuo: " & residuo)
        End If
        MesesTranscurridos = meses
        MesInicio = CType(fechaIni.Month.ToString, Integer)
        MesFin = CType(FechaFin.Month.ToString, Integer)

    End Sub

    Private Sub Dg_Cabecera_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles Dg_Cabecera.CellEndEdit
        Try
            If e.RowIndex >= 0 Then
                If e.ColumnIndex = 35 Then
                    Dg_Cabecera.Rows(e.RowIndex).Cells("UUABASTECE").Value = Math.Ceiling((Dg_Cabecera.Rows(e.RowIndex).Cells("PORCENABASTECER").EditedFormattedValue * Dg_Cabecera.Rows(e.RowIndex).Cells("VENTAMES").Value) / 100)
                    Dg_Cabecera.Rows(e.RowIndex).Cells("M3ABASTECER").Value = Math.Ceiling(Dg_Cabecera.Rows(e.RowIndex).Cells("UUABASTECE").Value * Dg_Cabecera.Rows(e.RowIndex).Cells("VOLUMENUNIDAD").Value)

                    If Dg_Cabecera.Rows(e.RowIndex).Cells("STOCKATE").Value > Dg_Cabecera.Rows(e.RowIndex).Cells("UUABASTECE").Value Then
                        Dg_Cabecera.Rows(e.RowIndex).Cells("UUABASTATE").Value = 0
                    Else
                        Dg_Cabecera.Rows(e.RowIndex).Cells("UUABASTATE").Value = Dg_Cabecera.Rows(e.RowIndex).Cells("UUABASTECE").Value - Dg_Cabecera.Rows(e.RowIndex).Cells("STOCKATE").Value
                    End If

                    If Dg_Cabecera.Rows(e.RowIndex).Cells("STOCKCJM").Value < Dg_Cabecera.Rows(e.RowIndex).Cells("UUABASTATE").Value Then
                        Dg_Cabecera.Rows(e.RowIndex).Cells("UUREALABASATE").Value = Dg_Cabecera.Rows(e.RowIndex).Cells("STOCKCJM").Value
                    Else
                        Dg_Cabecera.Rows(e.RowIndex).Cells("UUREALABASATE").Value = Dg_Cabecera.Rows(e.RowIndex).Cells("UUABASTATE").Value
                    End If

                    Dg_Cabecera.Rows(e.RowIndex).Cells("ABASTECJMATE").Value = Math.Ceiling(CType((Dg_Cabecera.Rows(e.RowIndex).Cells("UUREALABASATE").Value / Dg_Cabecera.Rows(e.RowIndex).Cells("MULTIPLICACIONFACTORES").Value), Decimal))
                    'If Dg_Cabecera.Rows(e.RowIndex).Cells("ABASTECJMATE").Value > 0 And Dg_Cabecera.Rows(e.RowIndex).Cells("ABASTECJMATE").Value < 1 Then
                    '    Dg_Cabecera.Rows(e.RowIndex).Cells("ABASTECJMATE").Value = 1
                    'End If
                    Dg_Cabecera.Rows(e.RowIndex).Cells("ABASTUNI").Value = Dg_Cabecera.Rows(e.RowIndex).Cells("ABASTECJMATE").Value * Dg_Cabecera.Rows(e.RowIndex).Cells("MULTIPLICACIONFACTORES").Value

                    Dg_Cabecera.Rows(e.RowIndex).Cells("STOCKFINALATE").Value = Dg_Cabecera.Rows(e.RowIndex).Cells("ABASTUNI").Value + Dg_Cabecera.Rows(e.RowIndex).Cells("STOCKATE").Value

                    Dg_Cabecera.Rows(e.RowIndex).Cells("ABASTEM3").Value = Dg_Cabecera.Rows(e.RowIndex).Cells("VOLCJMU").Value * Dg_Cabecera.Rows(e.RowIndex).Cells("ABASTECJMATE").Value
                    Dg_Cabecera.Rows(e.RowIndex).Cells("COBERTACTUAL").Value = Math.Ceiling((Dg_Cabecera.Rows(e.RowIndex).Cells("STOCKATE").Value / Dg_Cabecera.Rows(e.RowIndex).Cells("VENTAMES").Value) * 30)
                    Dg_Cabecera.Rows(e.RowIndex).Cells("COBERTFINAL").Value = Math.Ceiling((Dg_Cabecera.Rows(e.RowIndex).Cells("STOCKFINALATE").Value / Dg_Cabecera.Rows(e.RowIndex).Cells("VENTAMES").Value) * 30)

                    If CType(Dg_Cabecera.Rows(e.RowIndex).Cells("COBERTFINAL").Value, Integer) <= 7 Then
                        Dg_Cabecera.Rows(e.RowIndex).Cells("ACCION").Value = "ABASTECER"
                    Else
                        If CType(Dg_Cabecera.Rows(e.RowIndex).Cells("COBERTFINAL").Value, Integer) > 7 And CType(Dg_Cabecera.Rows(e.RowIndex).Cells("COBERTFINAL").Value, Integer) <= 50 Then
                            Dg_Cabecera.Rows(e.RowIndex).Cells("ACCION").Value = "OK"
                        Else
                            If CType(Dg_Cabecera.Rows(e.RowIndex).Cells("COBERTFINAL").Value, Integer) > 50 Then
                                Dg_Cabecera.Rows(e.RowIndex).Cells("ACCION").Value = "DEVOLVER CJM"
                            End If
                        End If
                    End If

                    'If Dg_Cabecera.Rows(contador).Cells("UUREALABASATE").Value > Dg_Cabecera.Rows(contador).Cells("STOCKCJM").Value Then
                    '    Dg_Cabecera.Rows(contador).Cells("ACCIONFINAL").Value = "SIN STOCK SUF_CJM"
                    'Else
                    '    Dg_Cabecera.Rows(contador).Cells("ACCIONFINAL").Value = "OK"
                    'End If
                    If CType(Dg_Cabecera.Rows(e.RowIndex).Cells("STOCKCJM").Value, Integer) = 0 Then
                        Dg_Cabecera.Rows(e.RowIndex).Cells("ACCIONFINAL").Value = "SIN STOCK CJM"
                    Else
                        If CType(Dg_Cabecera.Rows(e.RowIndex).Cells("STOCKCJM").Value, Integer) > 0 And CType(Dg_Cabecera.Rows(e.RowIndex).Cells("STOCKCJM").Value, Integer) < CType(Dg_Cabecera.Rows(e.RowIndex).Cells("UUABASTECE").Value, Integer) Then
                            Dg_Cabecera.Rows(e.RowIndex).Cells("ACCIONFINAL").Value = "STOCK DE CJM INSUFICIENTE"
                        Else
                            If CType(Dg_Cabecera.Rows(e.RowIndex).Cells("STOCKCJM").Value, Integer) > 0 And CType(Dg_Cabecera.Rows(e.RowIndex).Cells("STOCKCJM").Value, Integer) >= CType(Dg_Cabecera.Rows(e.RowIndex).Cells("UUABASTECE").Value, Integer) Then
                                Dg_Cabecera.Rows(e.RowIndex).Cells("ACCIONFINAL").Value = "OK"
                            End If
                        End If
                    End If

                    Dg_Cabecera.Rows(e.RowIndex).Cells("DEVOLVERCJM").Value = CType(0, Decimal)
                    Dg_Cabecera.Rows(e.RowIndex).Cells("M3DEVOLVERCJM").Value = CType(0, Decimal)

                    If Dg_Cabecera.Rows(e.RowIndex).Cells("ACCION").Value.ToString = "DEVOLVER CJM" Then
                        Dg_Cabecera.Rows(e.RowIndex).Cells("DEVOLVERCJM").Value = Math.Ceiling(CType(((CType(Dg_Cabecera.Rows(e.RowIndex).Cells("STOCKFINALATE").Value, Integer) - Dg_Cabecera.Rows(e.RowIndex).Cells("VENTAMES").Value) * 2) / Dg_Cabecera.Rows(e.RowIndex).Cells("MULTIPLICACIONFACTORES").Value, Decimal))
                        If Dg_Cabecera.Rows(e.RowIndex).Cells("DEVOLVERCJM").Value <> 0 Then
                            Dg_Cabecera.Rows(e.RowIndex).Cells("M3DEVOLVERCJM").Value = Math.Ceiling(CType(Dg_Cabecera.Rows(e.RowIndex).Cells("DEVOLVERCJM").Value * Dg_Cabecera.Rows(e.RowIndex).Cells("VOLCJMU").Value, Decimal))
                        Else
                            Dg_Cabecera.Rows(e.RowIndex).Cells("M3DEVOLVERCJM").Value = CType(0, Decimal)
                        End If
                    Else
                        Dg_Cabecera.Rows(e.RowIndex).Cells("DEVOLVERCJM").Value = CType(0, Decimal)
                        Dg_Cabecera.Rows(e.RowIndex).Cells("M3DEVOLVERCJM").Value = CType(0, Decimal)
                    End If

                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdGenerarExcel_Click(sender As Object, e As EventArgs) Handles cmdGenerarExcel.Click
        Try
            If Dg_Cabecera.Rows.Count > 0 Then
                For Each Dgrow As DataGridViewRow In Dg_Cabecera.Rows
                    If CType(Dgrow.Cells("ABASTECJMATE").EditedFormattedValue.ToString, Integer) > 0 Then
                        If Dgrow.Cells("SELECCIONAR").EditedFormattedValue = True Then
                            Dim RowAdd As DataRow = DtReporte.NewRow
                            RowAdd.Item("Cod Articulo") = Dgrow.Cells("CODIGO").EditedFormattedValue.ToString
                            RowAdd.Item("Articulo") = Dgrow.Cells("ARTICULO").EditedFormattedValue.ToString
                            RowAdd.Item("CJ Master Abastercer") = Dgrow.Cells("ABASTECJMATE").EditedFormattedValue.ToString
                            RowAdd.Item("M3 Abastecer") = Dgrow.Cells("ABASTEM3").EditedFormattedValue.ToString
                            RowAdd.Item("Cobertura Final Dias") = Dgrow.Cells("COBERTFINAL").EditedFormattedValue.ToString
                            RowAdd.Item("Cobertura Actual Dias") = Dgrow.Cells("COBERTACTUAL").EditedFormattedValue.ToString
                            DtReporte.Rows.Add(RowAdd)
                        End If
                    End If
                Next
            End If

            If DtReporte.Rows.Count > 0 Then
                ExportExcel(DtReporte)
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
            savedialog_Excel.FileName = "REPORTE ABASTECIMIENTO" + Now.Day.ToString + "_" + Now.Month.ToString + "_" + Now.Year.ToString
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

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles Check_mostrar.CheckedChanged
        Try
            If Check_mostrar.Checked = True Then
                Dg_Cabecera.Columns("UUCAJA").Visible = True
                Dg_Cabecera.Columns("CAJASCM").Visible = True
                Dg_Cabecera.Columns("MULTIPLICACIONFACTORES").Visible = True
                Dg_Cabecera.Columns("VOLCJMU").Visible = True
                Dg_Cabecera.Columns("VOLUMENUNIDAD").Visible = True

            ElseIf Check_mostrar.Checked = False Then
                Dg_Cabecera.Columns("UUCAJA").Visible = False
                Dg_Cabecera.Columns("CAJASCM").Visible = False
                Dg_Cabecera.Columns("MULTIPLICACIONFACTORES").Visible = False
                Dg_Cabecera.Columns("VOLCJMU").Visible = False
                Dg_Cabecera.Columns("VOLUMENUNIDAD").Visible = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txt_numero_TextChanged(sender As Object, e As EventArgs) Handles txt_numero.TextChanged
        Try
            If txt_numero.Text <> "" Then
                For i As Integer = 0 To Dg_Cabecera.RowCount - 1
                    Dim Cod As String = txt_numero.Text.Trim + "*"
                    If Dg_Cabecera.Rows(i).Cells("CODIGO").EditedFormattedValue.ToString.Trim Like Cod Then
                        Dg_Cabecera.Rows(i).Visible = True
                    Else
                        Dg_Cabecera.Rows(i).Visible = False
                    End If
                Next
            Else
                For i As Integer = 0 To Dg_Cabecera.RowCount - 1
                    Dg_Cabecera.Rows(i).Visible = True
                Next
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If Dg_Cabecera.Rows.Count > 0 Then
            GridAExcel_Stock(Dg_Cabecera)
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged_1(sender As Object, e As EventArgs) Handles Check_MostrarDemanda.CheckedChanged
        Try
            If Check_MostrarDemanda.Checked = True Then
                Dim ContadorMeses As Integer = MesInicio
                While (ContadorMeses <> MesFin) = True
                    Select Case ContadorMeses
                        Case 1
                            Dg_Cabecera.Columns("ENERO").Visible = True

                        Case 2
                            Dg_Cabecera.Columns("FEBRERO").Visible = True

                        Case 3
                            Dg_Cabecera.Columns("MARZO").Visible = True
                        Case 4
                            Dg_Cabecera.Columns("ABRIL").Visible = True
                        Case 5
                            Dg_Cabecera.Columns("MAYO").Visible = True
                        Case 6
                            Dg_Cabecera.Columns("JUNIO").Visible = True
                        Case 7
                            Dg_Cabecera.Columns("JULIO").Visible = True
                        Case 8
                            Dg_Cabecera.Columns("AGOSTO").Visible = True
                        Case 9
                            Dg_Cabecera.Columns("SETIEMBRE").Visible = True
                        Case 10
                            Dg_Cabecera.Columns("OCTUBRE").Visible = True
                        Case 11
                            Dg_Cabecera.Columns("NOVIEMBRE").Visible = True
                        Case 12
                            Dg_Cabecera.Columns("DICIEMBRE").Visible = True
                    End Select
                    If ContadorMeses < 12 Then
                        ContadorMeses = ContadorMeses + 1
                    Else
                        If ContadorMeses = 12 Then
                            ContadorMeses = 1
                        End If
                    End If

                End While
                Select Case MesFin
                    Case 1
                        Dg_Cabecera.Columns("ENERO").Visible = True

                    Case 2
                        Dg_Cabecera.Columns("FEBRERO").Visible = True

                    Case 3
                        Dg_Cabecera.Columns("MARZO").Visible = True
                    Case 4
                        Dg_Cabecera.Columns("ABRIL").Visible = True
                    Case 5
                        Dg_Cabecera.Columns("MAYO").Visible = True
                    Case 6
                        Dg_Cabecera.Columns("JUNIO").Visible = True
                    Case 7
                        Dg_Cabecera.Columns("JULIO").Visible = True
                    Case 8
                        Dg_Cabecera.Columns("AGOSTO").Visible = True
                    Case 9
                        Dg_Cabecera.Columns("SETIEMBRE").Visible = True
                    Case 10
                        Dg_Cabecera.Columns("OCTUBRE").Visible = True
                    Case 11
                        Dg_Cabecera.Columns("NOVIEMBRE").Visible = True
                    Case 12
                        Dg_Cabecera.Columns("DICIEMBRE").Visible = True
                End Select
                Dg_Cabecera.Columns("TOTALVENTA").Visible = True

            ElseIf Check_MostrarDemanda.Checked = False Then

                Dg_Cabecera.Columns("ENERO").Visible = False
                Dg_Cabecera.Columns("FEBRERO").Visible = False
                Dg_Cabecera.Columns("MARZO").Visible = False
                Dg_Cabecera.Columns("ABRIL").Visible = False
                Dg_Cabecera.Columns("MAYO").Visible = False
                Dg_Cabecera.Columns("JUNIO").Visible = False
                Dg_Cabecera.Columns("JULIO").Visible = False
                Dg_Cabecera.Columns("AGOSTO").Visible = False
                Dg_Cabecera.Columns("SETIEMBRE").Visible = False
                Dg_Cabecera.Columns("OCTUBRE").Visible = False
                Dg_Cabecera.Columns("NOVIEMBRE").Visible = False
                Dg_Cabecera.Columns("DICIEMBRE").Visible = False
                Dg_Cabecera.Columns("TOTALVENTA").Visible = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Check_MostrarTipo_CheckedChanged(sender As Object, e As EventArgs) Handles Check_MostrarTipo.CheckedChanged

        If Check_MostrarTipo.Checked = True Then

            Dg_Cabecera.Columns("ABCCI").Visible = True
            Dg_Cabecera.Columns("PORCENTAJE").Visible = True
            Dg_Cabecera.Columns("PORCENACUMU").Visible = True
            Dg_Cabecera.Columns("FRECUENCIA").Visible = True
            Dg_Cabecera.Columns("FRECUENCIAB").Visible = True

        ElseIf Check_MostrarTipo.Checked = False Then
            Dg_Cabecera.Columns("ABCCI").Visible = False
            Dg_Cabecera.Columns("PORCENTAJE").Visible = False
            Dg_Cabecera.Columns("PORCENACUMU").Visible = False
            Dg_Cabecera.Columns("FRECUENCIA").Visible = False
            Dg_Cabecera.Columns("FRECUENCIAB").Visible = False
        End If

    End Sub

    Private Sub Check_MostrarOtros_CheckedChanged(sender As Object, e As EventArgs) Handles Check_MostrarOtros.CheckedChanged
        If Check_MostrarOtros.Checked = True Then

            Dg_Cabecera.Columns("UUABASTECE").Visible = True
            Dg_Cabecera.Columns("M3ABASTECER").Visible = True
            Dg_Cabecera.Columns("UUABASTATE").Visible = True
            Dg_Cabecera.Columns("UUREALABASATE").Visible = True


        ElseIf Check_MostrarOtros.Checked = False Then
            Dg_Cabecera.Columns("UUABASTECE").Visible = False
            Dg_Cabecera.Columns("M3ABASTECER").Visible = False
            Dg_Cabecera.Columns("UUABASTATE").Visible = False
            Dg_Cabecera.Columns("UUREALABASATE").Visible = False

        End If
    End Sub
End Class