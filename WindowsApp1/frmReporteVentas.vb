
Imports System.ComponentModel
Imports Nordic.Bl.Be


Public Class frmReporteVentas

    Public prIdUser As String


    Private Sub frmReporteVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            ckbBhealth.Checked = False
            ckbLifeScience.Checked = False
            ckbHuman.Checked = False
            ckbPneumo.Checked = False
            chkComercial.Checked = False

            cbxTipVenta.SelectedIndex = 0

            If prIdUser = 1 Then
                ckbBhealth.Enabled = True
                ckbLifeScience.Enabled = True
                ckbHuman.Enabled = True
                ckbPneumo.Enabled = True
                chkComercial.Enabled = True

                ckbBhealth.Checked = True
                ckbLifeScience.Checked = True
                ckbHuman.Checked = True
                ckbPneumo.Checked = True
                chkComercial.Checked = True


            End If

            'Claudia Ruggel
            If prIdUser = 1120 Then
                ckbBhealth.Enabled = True
                ckbLifeScience.Enabled = False
                ckbHuman.Enabled = False
                ckbPneumo.Enabled = False
                chkComercial.Enabled = False

                ckbBhealth.Checked = True
                ckbLifeScience.Checked = False
                ckbHuman.Checked = False
                ckbPneumo.Checked = False
                chkComercial.Checked = False

            End If

            'Gonzalo Torres
            If prIdUser = 1121 Then
                ckbBhealth.Enabled = False
                ckbLifeScience.Enabled = False
                ckbHuman.Enabled = False
                ckbPneumo.Enabled = False
                chkComercial.Enabled = True

                ckbBhealth.Checked = False
                ckbLifeScience.Checked = False
                ckbHuman.Checked = False
                ckbPneumo.Checked = False
                chkComercial.Checked = True

            End If

            'Gina Moschella
            If prIdUser = 1122 Then
                ckbBhealth.Enabled = False
                ckbLifeScience.Enabled = True
                ckbHuman.Enabled = False
                ckbPneumo.Enabled = False
                chkComercial.Enabled = False

                ckbBhealth.Checked = False
                ckbLifeScience.Checked = True
                ckbHuman.Checked = False
                ckbPneumo.Checked = False
                chkComercial.Checked = False


            End If

            'Rosendry Rodriguez
            If prIdUser = 1117 Then
                ckbBhealth.Enabled = False
                ckbLifeScience.Enabled = False
                ckbHuman.Enabled = True
                ckbPneumo.Enabled = True
                chkComercial.Enabled = False

                ckbBhealth.Checked = False
                ckbLifeScience.Checked = False
                ckbHuman.Checked = True
                ckbPneumo.Checked = True
                chkComercial.Checked = False

            End If



            'Cargar_GirosNegocios()
            Cargar_Canales()
            ListarAnios()
            rbtCliente.Checked = True
            chkCaja.Checked = True
            chkVenta.Checked = True

            For i As Integer = 0 To CheckedListBox_Giros.Items.Count - 1
                CheckedListBox_Giros.SetItemChecked(i, True)
            Next


        Catch ex As Exception

        End Try
    End Sub


    Public Sub ListarAnios()
        Dim anioIni As Integer = 2019
        Dim anioFin As Integer
        Dim val As Integer = 0
        Dim dif As Integer = 0
        ' Dim ds As String
        Try
            'ds = objSeg.Obtener_Fecha_Actual()
            Dim obj As New BeReporteVenta
            anioFin = CInt(obj.Obtener_Anio_Actual)

            dif = anioFin - anioIni
            Dim vect(dif) As Integer

            For i As Integer = 0 To dif
                val = anioIni + i
                cbxAnio.Items.Add(val)
                ' cbxAniox.Items.Add(val)
            Next
            cbxAnio.SelectedItem = anioFin
            'cbxAniox.SelectedItem = anioFin
        Catch ex As Exception

        End Try
    End Sub



    Sub Cargar_Totales_Horizontal()

        For i As Integer = 0 To dgvListarVentas.Rows.Count - 1

            Dim acumCaj_Hori As Integer = 0
            Dim acumVta_Hori As Double = 0.0

            For j As Integer = 0 To dgvListarVentas.Columns.Count - 1

                If j = 1 Or j = 3 Or j = 5 Or j = 7 Or j = 9 Or j = 11 Or j = 13 Or j = 15 Or j = 17 Or j = 19 Or j = 21 Or j = 23 Then

                    If dgvListarVentas.Rows(i).Cells.Item(j).Value Is DBNull.Value Then
                        acumCaj_Hori = acumCaj_Hori + 0
                    Else
                        acumCaj_Hori = acumCaj_Hori + CInt(dgvListarVentas.Rows(i).Cells.Item(j).Value)
                    End If

                End If

                dgvListarVentas.Rows(i).Cells.Item("Total_Cj").Value = acumCaj_Hori.ToString("###,###,##0")

                If j = 2 Or j = 4 Or j = 6 Or j = 8 Or j = 10 Or j = 12 Or j = 14 Or j = 16 Or j = 18 Or j = 20 Or j = 22 Or j = 24 Then

                    If dgvListarVentas.Rows(i).Cells.Item(j).Value Is DBNull.Value Then
                        acumVta_Hori = acumVta_Hori + 0.0
                    Else
                        acumVta_Hori = acumVta_Hori + CInt(dgvListarVentas.Rows(i).Cells.Item(j).Value)
                    End If

                End If

                dgvListarVentas.Rows(i).Cells.Item("Total_Vt").Value = acumVta_Hori

            Next
        Next

    End Sub

    Sub Cargar_Ventas_Vertical()

        dgvListarVentas.Rows.Add("TOTAL")

        Dim acumCjVert As Integer = 0
        Dim acumVtVert As Double = 0.0

        Dim UltFila As Integer = dgvListarVentas.Rows.Count - 1

        For j As Integer = 1 To dgvListarVentas.Columns.Count - 1

            For i As Integer = 0 To dgvListarVentas.Rows.Count - 1

                If j = 1 Or j = 3 Or j = 5 Or j = 7 Or j = 9 Or j = 11 Or j = 13 Or j = 15 Or j = 17 Or j = 19 Or j = 21 Or j = 23 Or j = 25 Then
                    If dgvListarVentas.Rows(i).Cells.Item(j).Value Is DBNull.Value Then
                        acumCjVert = acumCjVert + 0
                    Else
                        acumCjVert = acumCjVert + CInt(dgvListarVentas.Rows(i).Cells.Item(j).Value)
                    End If
                End If

                If j = 2 Or j = 4 Or j = 6 Or j = 8 Or j = 10 Or j = 12 Or j = 14 Or j = 16 Or j = 18 Or j = 20 Or j = 22 Or j = 24 Then

                    If dgvListarVentas.Rows(i).Cells.Item(j).Value Is DBNull.Value Then
                        acumVtVert = acumVtVert + 0.0
                    Else
                        acumVtVert = acumVtVert + CInt(dgvListarVentas.Rows(i).Cells.Item(j).Value)
                    End If
                End If
            Next

            If j = 1 Or j = 3 Or j = 5 Or j = 7 Or j = 9 Or j = 11 Or j = 13 Or j = 15 Or j = 17 Or j = 19 Or j = 21 Or j = 23 Or j = 25 Then
                dgvListarVentas.Rows(UltFila).Cells.Item(j).Value = acumCjVert
            End If

            If j = 2 Or j = 4 Or j = 6 Or j = 8 Or j = 10 Or j = 12 Or j = 14 Or j = 16 Or j = 18 Or j = 20 Or j = 22 Or j = 24 Or j = 26 Then
                dgvListarVentas.Rows(UltFila).Cells.Item(j).Value = acumVtVert
            End If

        Next

        'dgvListarVentas.Rows(UltFila).DefaultCellStyle.Font.Bold = True


    End Sub

    Sub Cargar_Ventas_Prueba()
        Try
            Dim fila As Integer = 0

            fila = dgvListarVentas.Rows.Count + 1

            dgvListarVentas.Rows.Add("CLINICA RICARDO PALMA", "24,000", "40,000.00", "28,000", "50,000.00", "30,000", "60,000.00",
                                     "24,000", "40,000.00", "28,000", "50,000.00", "30,000", "60,000.00",
                                     "24,000", "40,000.00", "28,000", "50,000.00", "30,000", "60,000.00",
                                     "24,000", "40,000.00", "28,000", "50,000.00", "30,000", "60,000.00")


            dgvListarVentas.Rows.Add("BOTICA FARMA MARKET", "24,000", "40,000.00", "28,000", "50,000.00", "30,000", "60,000.00",
                                     "24,000", "40,000.00", "28,000", "50,000.00", "30,000", "60,000.00",
                                     "24,000", "40,000.00", "28,000", "50,000.00", "30,000", "60,000.00",
                                     "24,000", "40,000.00", "28,000", "50,000.00", "30,000", "60,000.00")


            dgvListarVentas.Rows.Add("FARMACIA SANTA SOFIA", "24,000", "40,000.00", "28,000", "50,000.00", "30,000", "60,000.00",
                                     "24,000", "40,000.00", "28,000", "50,000.00", "30,000", "60,000.00",
                                     "24,000", "40,000.00", "28,000", "50,000.00", "30,000", "60,000.00",
                                     "24,000", "40,000.00", "28,000", "50,000.00", "30,000", "60,000.00")


        Catch ex As Exception

        End Try
    End Sub

    Public Sub Cargar_GirosNegocios()
        Try

            Dim obj As New BeReporteVenta
            Dim dt As DataTable
            dt = obj.Listar_GirosNegocio()

            For i As Integer = 0 To dt.Rows.Count - 1
                CheckedListBox_Giros.Items.Add(dt.Rows(i).Item(0).ToString)
            Next

        Catch ex As Exception

        End Try
    End Sub


    Public Sub Cargar_Canales()
        Try

            Dim obj As New BeReporteVenta
            Dim dt As DataTable
            dt = obj.Listar_Canales()

            For i As Integer = 0 To dt.Rows.Count - 1
                CheckedListBox_Giros.Items.Add(dt.Rows(i).Item(0).ToString)
            Next

        Catch ex As Exception

        End Try
    End Sub


    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim fecIni As String = String.Empty
            Dim fecFin As String = String.Empty
            Dim anio As String = String.Empty
            Dim str_cadenasLineas As String = String.Empty
            Dim str_cadenasGiros As String = String.Empty

            If CheckedListBox_Giros.CheckedItems.Count = 0 Then
                MessageBox.Show("Debe seleccionar al menos un giro de negocio !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                If ckbBhealth.Checked = False And ckbLifeScience.Checked = False And ckbHuman.Checked = False And ckbPneumo.Checked = False And chkComercial.Checked = False Then
                    MessageBox.Show("Debe seleccionar al menos una Línea !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else

                    fecIni = dtpFecIni.Value.ToShortDateString
                    fecFin = dtpFecFin.Value.ToShortDateString

                    str_cadenasLineas = ObtenerCadenaLineas()
                    str_cadenasGiros = ObtenerCadenaGirosNegocio()

                    anio = cbxAnio.Text

                    If rbtCliente.Checked = True Then

                        dgvListarVentas.Columns(0).HeaderText = "CLIENTE"

                        Cargar_Ventas(fecIni, fecFin, str_cadenasGiros, str_cadenasLineas, anio)

                    Else
                        If rbtArticulo.Checked = True Then

                            dgvListarVentas.Columns(0).HeaderText = "ARTICULO"

                            Cargar_Ventas_Articulos(fecIni, fecFin, str_cadenasGiros, str_cadenasLineas, anio)
                        End If
                    End If


                    Cargar_Totales_Horizontal()

                    If dgvListarVentas.Rows.Count > 0 Then
                        dgvListarVentas.Sort(dgvListarVentas.Columns("Total_Vt"), ListSortDirection.Descending)
                    End If

                    Cargar_Ventas_Vertical()

                End If
            End If

            Me.Cursor = Cursors.Default

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Function ObtenerCadenaLineas() As String

        Dim str_cadenaLineas As String = String.Empty

        If ckbBhealth.Checked = True Then
            str_cadenaLineas = str_cadenaLineas + "01" + ","
        End If

        If ckbHuman.Checked = True Then
            str_cadenaLineas = str_cadenaLineas + "02" + ","
        End If

        If ckbLifeScience.Checked = True Then
            str_cadenaLineas = str_cadenaLineas + "03" + ","
        End If

        If ckbPneumo.Checked = True Then
            str_cadenaLineas = str_cadenaLineas + "04" + ","
        End If

        If chkComercial.Checked = True Then
            str_cadenaLineas = str_cadenaLineas + "05" + ","
        End If

        str_cadenaLineas = str_cadenaLineas.Substring(0, Len(str_cadenaLineas) - 1)

        Return str_cadenaLineas

    End Function


    Function ObtenerCadenaGirosNegocio() As String
        Dim str_cadenaGiros As String = String.Empty

        For i As Integer = 0 To CheckedListBox_Giros.Items.Count - 1

            If CheckedListBox_Giros.GetItemChecked(i) Then

                str_cadenaGiros = str_cadenaGiros + CheckedListBox_Giros.Items(i).ToString.Substring(0, 2) + ","

            End If
        Next

        str_cadenaGiros = str_cadenaGiros.Substring(0, Len(str_cadenaGiros) - 1)

        Return str_cadenaGiros
    End Function


    Sub Cargar_Ventas(ByVal fecIni As String, ByVal fecFin As String, ByVal cadgiros As String, ByVal cadlineas As String, ByVal anio As String)
        Try
            Dim obj As New BeReporteVenta
            Dim dt As DataTable

            dgvListarVentas.Rows.Clear()

            dt = obj.Listar_Ventas_Nordic(fecIni, fecFin, cadgiros, cadlineas, anio)

            If dt.Rows.Count = 0 Then
                MessageBox.Show("No se encontraron registros !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else

                For i As Integer = 0 To dt.Rows.Count - 1

                    dgvListarVentas.Rows.Add(dt.Rows(i).Item(0).ToString, dt.Rows(i).Item(1), dt.Rows(i).Item(2), dt.Rows(i).Item(3), dt.Rows(i).Item(4),
                                         dt.Rows(i).Item(5), dt.Rows(i).Item(6), dt.Rows(i).Item(7), dt.Rows(i).Item(8), dt.Rows(i).Item(9), dt.Rows(i).Item(10),
                                         dt.Rows(i).Item(11), dt.Rows(i).Item(12), dt.Rows(i).Item(13), dt.Rows(i).Item(14), dt.Rows(i).Item(15), dt.Rows(i).Item(16),
                                         dt.Rows(i).Item(17), dt.Rows(i).Item(18), dt.Rows(i).Item(19), dt.Rows(i).Item(20), dt.Rows(i).Item(21), dt.Rows(i).Item(22),
                                         dt.Rows(i).Item(23), dt.Rows(i).Item(24))

                Next

                tslCant.Text = CStr(dgvListarVentas.Rows.Count)

            End If


        Catch ex As Exception

        End Try
    End Sub


    Sub Cargar_Ventas_Articulos(ByVal fecIni As String, ByVal fecFin As String, ByVal cadgiros As String, ByVal cadlineas As String, ByVal anio As String)
        Try
            Dim obj As New BeReporteVenta
            Dim dt As DataTable

            dgvListarVentas.Rows.Clear()

            dt = obj.Listar_Ventas_xArticulos_Nordic(fecIni, fecFin, cadgiros, cadlineas, anio)

            If dt.Rows.Count = 0 Then
                MessageBox.Show("No se encontraron registros !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else

                For i As Integer = 0 To dt.Rows.Count - 1

                    dgvListarVentas.Rows.Add(dt.Rows(i).Item(0).ToString, dt.Rows(i).Item(1), dt.Rows(i).Item(2), dt.Rows(i).Item(3), dt.Rows(i).Item(4),
                                         dt.Rows(i).Item(5), dt.Rows(i).Item(6), dt.Rows(i).Item(7), dt.Rows(i).Item(8), dt.Rows(i).Item(9), dt.Rows(i).Item(10),
                                         dt.Rows(i).Item(11), dt.Rows(i).Item(12), dt.Rows(i).Item(13), dt.Rows(i).Item(14), dt.Rows(i).Item(15), dt.Rows(i).Item(16),
                                         dt.Rows(i).Item(17), dt.Rows(i).Item(18), dt.Rows(i).Item(19), dt.Rows(i).Item(20), dt.Rows(i).Item(21), dt.Rows(i).Item(22),
                                         dt.Rows(i).Item(23), dt.Rows(i).Item(24))
                Next

            End If

            tslCant.Text = CStr(dgvListarVentas.Rows.Count)

        Catch ex As Exception

        End Try
    End Sub



    Private Sub CheckedListBox_Giros_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox_Giros.SelectedIndexChanged
        Try

            If CheckedListBox_Giros.SelectedIndex = 0 Then

                If CheckedListBox_Giros.GetItemChecked(0) = True Then
                    For i As Integer = 0 To CheckedListBox_Giros.Items.Count - 1
                        CheckedListBox_Giros.SetItemChecked(i, True)
                    Next
                End If

                If CheckedListBox_Giros.GetItemChecked(0) = False Then
                    For i As Integer = 0 To CheckedListBox_Giros.Items.Count - 1
                        CheckedListBox_Giros.SetItemChecked(i, False)
                    Next
                End If

            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub chkCaja_CheckedChanged(sender As Object, e As EventArgs) Handles chkCaja.CheckedChanged
        Try

            If chkCaja.Checked = True Then
                For j As Integer = 0 To dgvListarVentas.Columns.Count - 1

                    If j = 1 Or j = 3 Or j = 5 Or j = 7 Or j = 9 Or j = 11 Or j = 13 Or j = 15 Or j = 17 Or j = 19 Or j = 21 Or j = 23 Or j = 25 Then
                        dgvListarVentas.Columns(j).Visible = True
                    End If

                Next
            End If

            If chkCaja.Checked = False Then
                For j As Integer = 0 To dgvListarVentas.Columns.Count - 1

                    If j = 1 Or j = 3 Or j = 5 Or j = 7 Or j = 9 Or j = 11 Or j = 13 Or j = 15 Or j = 17 Or j = 19 Or j = 21 Or j = 23 Or j = 25 Then
                        dgvListarVentas.Columns(j).Visible = False
                    End If

                Next
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub chkVenta_CheckedChanged(sender As Object, e As EventArgs) Handles chkVenta.CheckedChanged
        Try

            If chkVenta.Checked = True Then
                For j As Integer = 0 To dgvListarVentas.Columns.Count - 1

                    If j = 2 Or j = 4 Or j = 6 Or j = 8 Or j = 10 Or j = 12 Or j = 14 Or j = 16 Or j = 18 Or j = 20 Or j = 22 Or j = 24 Or j = 26 Then
                        dgvListarVentas.Columns(j).Visible = True
                    End If

                Next
            End If

            If chkVenta.Checked = False Then
                For j As Integer = 0 To dgvListarVentas.Columns.Count - 1

                    If j = 2 Or j = 4 Or j = 6 Or j = 8 Or j = 10 Or j = 12 Or j = 14 Or j = 16 Or j = 18 Or j = 20 Or j = 22 Or j = 24 Or j = 26 Then
                        dgvListarVentas.Columns(j).Visible = False
                    End If

                Next
            End If

        Catch ex As Exception

        End Try
    End Sub
End Class