
Imports System.Drawing
Imports Nordic.Bl.Be

Public Class frmControlStock

    Private Sub tsbRefrescar_Click(sender As Object, e As EventArgs) Handles tsbRefrescar.Click
        Try
            Me.Cursor = Cursors.WaitCursor

            CargarControlStock()
            PintarRegistrosObservados()
            Calcular_CantidadUnidades()

            'dgvControlStock.Columns("COLOR2").Frozen = True

            Me.Cursor = Cursors.Default


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub




    Sub CargarControlStock()
        Try
            Dim objStock As New BeArticulos
            Dim dt As New DataTable


            dgvControlStock.Rows.Clear()

            dt = objStock.Listar_Control_Stock()

            If dt.Rows.Count = 0 Then
                MessageBox.Show("No se encontraron registros", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else

                For i As Integer = 0 To dt.Rows.Count - 1

                    dgvControlStock.Rows.Add(dt.Rows(i).Item("LINEA").ToString, dt.Rows(i).Item("CODIGO").ToString, dt.Rows(i).Item("DESCRIPCION").ToString, dt.Rows(i).Item("PRESENTACION").ToString,
                                dt.Rows(i).Item("1-2 M").ToString, dt.Rows(i).Item("3-5 M").ToString, dt.Rows(i).Item("6-8 M").ToString,
                                dt.Rows(i).Item("9-11 M").ToString, dt.Rows(i).Item("12-14 M").ToString, dt.Rows(i).Item("15-17 M").ToString,
                                 dt.Rows(i).Item("18-20 M").ToString, dt.Rows(i).Item("21-23 M").ToString, dt.Rows(i).Item("24-26 M").ToString,
                                 dt.Rows(i).Item("27-29 M").ToString, dt.Rows(i).Item("30-32 M").ToString, dt.Rows(i).Item("33-35 M").ToString,
                                 dt.Rows(i).Item("+36 M").ToString, "0", "0",
                                 dt.Rows(i).Item("COSTO_MN").ToString, dt.Rows(i).Item("COSTO_US").ToString, dt.Rows(i).Item("MONEDA").ToString)

                Next

                dgvControlStock.Rows.Add()

            End If




        Catch ex As Exception

        End Try
    End Sub

    Sub Calcular_CantidadUnidades()
        Try
            Dim cantCajas As Integer = 0
            Dim factor As Integer = 0
            Dim cantUnd As Integer = 0

            For i As Integer = 0 To dgvControlStock.Rows.Count - 1

                cantCajas = dgvControlStock.Rows(i).Cells.Item("totalCajas").Value
                factor = dgvControlStock.Rows(i).Cells.Item("PRESENTACION").Value

                cantUnd = CInt(cantCajas * factor)

                dgvControlStock.Rows(i).Cells.Item("totalUnd").Value = cantUnd

            Next

        Catch ex As Exception

        End Try
    End Sub

    Sub PintarRegistrosObservados()
        Try

            Dim cantNegro As Integer = 0
            Dim cantRojo As Integer = 0
            Dim cantNaranja As Integer = 0
            Dim cantAmarillo As Integer = 0
            Dim cantSinColor As Integer = 0
            Dim CantTotalCajas As Integer = 0

            Dim acumUno As Integer = 0
            Dim acumDos As Integer = 0
            Dim acumTres As Integer = 0
            Dim acumCuatro As Integer = 0
            Dim acumCinco As Integer = 0
            Dim acumSeis As Integer = 0
            Dim acumSiete As Integer = 0
            Dim acumOcho As Integer = 0
            Dim acumNueve As Integer = 0
            Dim acumDiez As Integer = 0
            Dim acumOnce As Integer = 0
            Dim acumDoce As Integer = 0
            Dim acumTrece As Integer = 0
            Dim TotalFilas As Integer


            For i As Integer = 0 To dgvControlStock.Rows.Count - 1

                CantTotalCajas = CInt(dgvControlStock.Rows(i).Cells("uno").Value) +
                                 CInt(dgvControlStock.Rows(i).Cells("dos").Value) +
                                 CInt(dgvControlStock.Rows(i).Cells("tres").Value) +
                                 CInt(dgvControlStock.Rows(i).Cells("cuatro").Value) +
                                 CInt(dgvControlStock.Rows(i).Cells("cinco").Value) +
                                 CInt(dgvControlStock.Rows(i).Cells("seis").Value) +
                                 CInt(dgvControlStock.Rows(i).Cells("siete").Value) +
                                 CInt(dgvControlStock.Rows(i).Cells("ocho").Value) +
                                 CInt(dgvControlStock.Rows(i).Cells("nueve").Value) +
                                 CInt(dgvControlStock.Rows(i).Cells("diez").Value) +
                                 CInt(dgvControlStock.Rows(i).Cells("once").Value) +
                                 CInt(dgvControlStock.Rows(i).Cells("doce").Value) +
                                 CInt(dgvControlStock.Rows(i).Cells("trece").Value)

                acumUno = acumUno + CInt(dgvControlStock.Rows(i).Cells("uno").Value)
                acumDos = acumDos + CInt(dgvControlStock.Rows(i).Cells("dos").Value)
                acumTres = acumTres + CInt(dgvControlStock.Rows(i).Cells("tres").Value)
                acumCuatro = acumCuatro + CInt(dgvControlStock.Rows(i).Cells("cuatro").Value)
                acumCinco = acumCinco + CInt(dgvControlStock.Rows(i).Cells("cinco").Value)
                acumSeis = acumSeis + CInt(dgvControlStock.Rows(i).Cells("seis").Value) +
                acumSiete = acumSiete + CInt(dgvControlStock.Rows(i).Cells("siete").Value)
                acumOcho = acumOcho + CInt(dgvControlStock.Rows(i).Cells("ocho").Value)
                acumNueve = acumNueve + CInt(dgvControlStock.Rows(i).Cells("nueve").Value)
                acumDiez = acumDiez + CInt(dgvControlStock.Rows(i).Cells("diez").Value)
                acumOnce = acumOnce + CInt(dgvControlStock.Rows(i).Cells("once").Value)
                acumDoce = acumDoce + CInt(dgvControlStock.Rows(i).Cells("doce").Value)
                acumTrece = acumTrece + CInt(dgvControlStock.Rows(i).Cells("trece").Value)



                'If dgvControlStock.Rows(i).Cells("COLOR1").Value = "NEGRO" Then
                '    dgvControlStock.Rows(i).Cells("COLOR2").Style.BackColor = Color.Black
                '    cantNegro = cantNegro + 1
                'Else
                '    If dgvControlStock.Rows(i).Cells("COLOR1").Value = "ROJO" Then
                '        dgvControlStock.Rows(i).Cells("COLOR2").Style.BackColor = Color.Red
                '        cantRojo = cantRojo + 1
                '    Else
                '        If dgvControlStock.Rows(i).Cells("COLOR1").Value = "NARANJA" Then
                '            dgvControlStock.Rows(i).Cells("COLOR2").Style.BackColor = Color.Orange
                '            cantNaranja = cantNaranja + 1

                '        Else
                '            If dgvControlStock.Rows(i).Cells("COLOR1").Value = "AMARILLO" Then
                '                dgvControlStock.Rows(i).Cells("COLOR2").Style.BackColor = Color.Yellow
                '                cantAmarillo = cantAmarillo + 1
                '            Else
                '                cantSinColor = cantSinColor + 1

                '            End If
                '        End If

                '    End If
                'End If

                dgvControlStock.Rows(i).Cells.Item("totalCajas").Value = CantTotalCajas
            Next

            TotalFilas = dgvControlStock.Rows.Count - 1

            dgvControlStock.Rows(TotalFilas).Cells.Item("DESCRIPCION").Value = "TOTAL"
            dgvControlStock.Rows(TotalFilas).Cells.Item("uno").Value = acumUno
            dgvControlStock.Rows(TotalFilas).Cells.Item("dos").Value = acumDos
            dgvControlStock.Rows(TotalFilas).Cells.Item("tres").Value = acumTres
            dgvControlStock.Rows(TotalFilas).Cells.Item("cuatro").Value = acumCuatro
            dgvControlStock.Rows(TotalFilas).Cells.Item("cinco").Value = acumCinco
            dgvControlStock.Rows(TotalFilas).Cells.Item("seis").Value = acumSeis

            dgvControlStock.Rows(TotalFilas).Cells.Item("siete").Value = acumSiete
            dgvControlStock.Rows(TotalFilas).Cells.Item("ocho").Value = acumOcho
            dgvControlStock.Rows(TotalFilas).Cells.Item("nueve").Value = acumNueve
            dgvControlStock.Rows(TotalFilas).Cells.Item("diez").Value = acumDiez
            dgvControlStock.Rows(TotalFilas).Cells.Item("once").Value = acumOnce
            dgvControlStock.Rows(TotalFilas).Cells.Item("doce").Value = acumDoce
            dgvControlStock.Rows(TotalFilas).Cells.Item("trece").Value = acumTrece


            tsbCantTotal.Text = CStr(dgvControlStock.Rows.Count)
            tsbCantNegro.Text = CStr(cantNegro)
            tsbRojo.Text = CStr(cantRojo)
            tsbNaranja.Text = CStr(cantNaranja)
            tsbAmarillo.Text = CStr(cantAmarillo)
            tsbSinColor.Text = CStr(cantSinColor)


        Catch ex As Exception

        End Try

    End Sub



    Private Sub tsbExportar_Click(sender As Object, e As EventArgs) Handles tsbExportar.Click
        Try
            Me.Cursor = Cursors.WaitCursor

            If dgvControlStock.Rows.Count = 0 Then
                MessageBox.Show("No se encontraron registros para exportar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                If MessageBox.Show("Esta Usted seguro que desea exportar ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    GridAExcel_Stock(dgvControlStock)
                End If
            End If

            Me.Cursor = Cursors.Default

        Catch ex As Exception

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

    Private Sub frmControlStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'dgvControlStock.Columns.Item("COSTO_MN").Visible = False
            'dgvControlStock.Columns.Item("COSTO_US").Visible = False
            'dgvControlStock.Columns.Item("C6_CCODMON").Visible = False

        Catch ex As Exception

        End Try
    End Sub

    Private Sub chkOcutar_CheckedChanged(sender As Object, e As EventArgs) Handles chkOcutar.CheckedChanged
        Try

            If chkOcutar.Checked = True Then

                dgvControlStock.Columns.Item("uno").Visible = False
                dgvControlStock.Columns.Item("dos").Visible = False
                dgvControlStock.Columns.Item("tres").Visible = False
                dgvControlStock.Columns.Item("cuatro").Visible = False

                dgvControlStock.Columns.Item("cinco").Visible = False
                dgvControlStock.Columns.Item("seis").Visible = False
                dgvControlStock.Columns.Item("siete").Visible = False
                dgvControlStock.Columns.Item("ocho").Visible = False

                dgvControlStock.Columns.Item("nueve").Visible = False
                dgvControlStock.Columns.Item("diez").Visible = False
                dgvControlStock.Columns.Item("once").Visible = False
                dgvControlStock.Columns.Item("doce").Visible = False
                dgvControlStock.Columns.Item("trece").Visible = False



            End If

            If chkOcutar.Checked = False Then

                dgvControlStock.Columns.Item("uno").Visible = True
                dgvControlStock.Columns.Item("dos").Visible = True
                dgvControlStock.Columns.Item("tres").Visible = True
                dgvControlStock.Columns.Item("cuatro").Visible = True

                dgvControlStock.Columns.Item("cinco").Visible = True
                dgvControlStock.Columns.Item("seis").Visible = True
                dgvControlStock.Columns.Item("siete").Visible = True
                dgvControlStock.Columns.Item("ocho").Visible = True

                dgvControlStock.Columns.Item("nueve").Visible = True
                dgvControlStock.Columns.Item("diez").Visible = True
                dgvControlStock.Columns.Item("once").Visible = True
                dgvControlStock.Columns.Item("doce").Visible = True
                dgvControlStock.Columns.Item("trece").Visible = True

            End If

        Catch ex As Exception

        End Try
    End Sub
End Class