
Imports Nordic.Bl.Be

Public Class frmRecepcionMercaderia

    Public usr_id As String

    Private Sub frmRecepcionMercaderia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ListarAlmacenes()
        Catch ex As Exception

        End Try
    End Sub

    Sub CargarCabeceraOrdenesCompra(ByVal flag As Integer, ByVal fecini As String, ByVal fecfin As String, ByVal numeroOC As String, ByVal codAlma As String)
        Try

            'Dim obj As New BeOrdenesCompra
            'Dim dt As New DataTable

            'dgvCabOrdenesCompra.Rows.Clear()

            'dt = obj.Listar_Cabecera_OrdenesCompra(flag, fecini, fecfin, numeroOC, codAlma)


            'For i As Integer = 0 To dt.Rows.Count - 1

            '    'dgvCabOrdenesCompra.Rows.Add()
            '    dgvCabOrdenesCompra.Rows.Add(dt.Rows(i).Item(0).ToString, dt.Rows(i).Item(1).ToString, dt.Rows(i).Item(2).ToString,
            '                                 dt.Rows(i).Item(3), dt.Rows(i).Item(4).ToString, dt.Rows(i).Item(5),
            '                                 dt.Rows(i).Item(6).ToString, dt.Rows(i).Item(7).ToString, dt.Rows(i).Item(8).ToString,
            '                                 dt.Rows(i).Item(9).ToString)

            '    'dgvCabOrdenesCompra.Rows(i).Cells.Item(0).Value = dt.Rows(i).Item(0).ToString
            '    'dgvCabOrdenesCompra.Rows(i).Cells.Item(1).Value = dt.Rows(i).Item(1).ToString
            '    'dgvCabOrdenesCompra.Rows(i).Cells.Item(2).Value = dt.Rows(i).Item(2).ToString
            '    'dgvCabOrdenesCompra.Rows(i).Cells.Item(3).Value = dt.Rows(i).Item(3).ToString
            '    'dgvCabOrdenesCompra.Rows(i).Cells.Item(4).Value = dt.Rows(i).Item(4).ToString
            '    'dgvCabOrdenesCompra.Rows(i).Cells.Item(5).Value = dt.Rows(i).Item(5).ToString
            '    'dgvCabOrdenesCompra.Rows(i).Cells.Item(6).Value = dt.Rows(i).Item(6).ToString
            '    'dgvCabOrdenesCompra.Rows(i).Cells.Item(7).Value = dt.Rows(i).Item(7).ToString
            '    'dgvCabOrdenesCompra.Rows(i).Cells.Item(8).Value = dt.Rows(i).Item(8).ToString
            '    'dgvCabOrdenesCompra.Rows(i).Cells.Item(9).Value = dt.Rows(i).Item(9).ToString

            'Next


            ''dgvCabOrdenesCompra.DataSource = dt

            'CalcularCantidades()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            If cboAlmacenes.SelectedIndex = 0 And txtBuscarOC.Text = "" Then
                CargarCabeceraOrdenesCompra(1, dtpFecIni.Value.ToShortDateString, dtpFecFin.Value.ToShortDateString, "", "")
            Else
                If txtBuscarOC.Text <> "" Then
                    CargarCabeceraOrdenesCompra(2, dtpFecIni.Value.ToShortDateString, dtpFecFin.Value.ToShortDateString, txtBuscarOC.Text.Trim, "")
                Else
                    If cboAlmacenes.SelectedIndex <> 0 And txtBuscarOC.Text = "" Then
                        CargarCabeceraOrdenesCompra(3, dtpFecIni.Value.ToShortDateString, dtpFecFin.Value.ToShortDateString, "", cboAlmacenes.SelectedValue)
                    End If

                End If
            End If



        Catch ex As Exception

        End Try
    End Sub

    Sub CalcularCantidades()
        Try

            Dim acumPend As Integer = 0
            Dim acumRece As Integer = 0

            For i As Integer = 0 To dgvCabOrdenesCompra.Rows.Count - 1

                If dgvCabOrdenesCompra.Rows(0).Cells(0).Value = "" Then
                    acumPend = acumPend + 1
                Else
                    If dgvCabOrdenesCompra.Rows(0).Cells(0).Value <> "" Then
                        acumRece = acumRece + 1
                    End If
                End If
            Next


            tslTotalRegistro.Text = CStr(dgvCabOrdenesCompra.Rows.Count)
            tslPendiente.Text = CStr(acumPend)
            tslRecepcionados.Text = CStr(acumRece)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvCabOrdenesCompra_SelectionChanged(sender As Object, e As EventArgs) Handles dgvCabOrdenesCompra.SelectionChanged
        Try
            'Dim obj As New BeOrdenesCompra
            'Dim dt As New DataTable

            'Dim oc_numord As String

            'oc_numord = dgvCabOrdenesCompra.CurrentRow.Cells.Item(1).Value

            'dt = obj.Listar_Detalle_OrdenesCompra(oc_numord)

            'dgvDetOrdenesCompra.DataSource = dt

        Catch ex As Exception

        End Try
    End Sub


    Sub ListarAlmacenes()
        Try
            'Dim obj As New BeOrdenesCompra
            'Dim dt As New DataTable

            'dt = obj.Obtener_Almacenes

            'cboAlmacenes.DataSource = dt
            'cboAlmacenes.ValueMember = "A1_CALMA"
            'cboAlmacenes.DisplayMember = "ALMACEN"

        Catch ex As Exception
            MessageBox.Show(ex.Message, "NORDIC", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtBuscarOC_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBuscarOC.KeyPress
        Try

            If e.KeyChar = Convert.ToChar(Keys.Enter) Then

                If cboAlmacenes.SelectedIndex = 0 And txtBuscarOC.Text = "" Then
                    CargarCabeceraOrdenesCompra(1, dtpFecIni.Value.ToShortDateString, dtpFecFin.Value.ToShortDateString, "", "")
                Else
                    If txtBuscarOC.Text <> "" Then
                        CargarCabeceraOrdenesCompra(2, dtpFecIni.Value.ToShortDateString, dtpFecFin.Value.ToShortDateString, txtBuscarOC.Text.Trim, "")
                    Else
                        If cboAlmacenes.SelectedIndex <> 0 And txtBuscarOC.Text = "" Then
                            CargarCabeceraOrdenesCompra(3, dtpFecIni.Value.ToShortDateString, dtpFecFin.Value.ToShortDateString, "", cboAlmacenes.SelectedValue)
                        End If

                    End If
                End If
            End If


        Catch ex As Exception

        End Try
    End Sub


    Function ConversionFechaDate(ByVal fecha As String) As String
        Try

            Dim fechaConverDate As String = String.Empty
            Dim dia As String
            Dim mes As String
            Dim anio As String

            anio = fecha.Substring(6, 4)
            mes = fecha.Substring(3, 2)
            dia = fecha.Substring(0, 2)

            fechaConverDate = anio + "-" + mes + "-" + dia

            Return fechaConverDate

        Catch ex As Exception

            Return Nothing

        End Try
    End Function

    Private Sub dgvCabOrdenesCompra_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCabOrdenesCompra.CellValueChanged
        Try

            'Dim fechaRecepDate As String
            'Dim numeroOc As String
            'Dim filas As Integer = 0

            'Dim obj As New BeOrdenesCompra

            'If dgvCabOrdenesCompra.Rows.Count > 0 Then
            '    fechaRecepDate = ConversionFechaDate(dgvCabOrdenesCompra.CurrentRow.Cells.Item("FechaRecepcion").Value.ToString())
            '    numeroOc = dgvCabOrdenesCompra.CurrentRow.Cells.Item("numero_oc").Value.ToString()

            '    filas = obj.Registrar_RecepcionMercaderia(fechaRecepDate, numeroOc, usr_id)

            '    If filas > 0 Then
            '        MessageBox.Show("Registro Satisfactorio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    Else
            '        If filas <= 0 Then
            '            MessageBox.Show("Error en el Registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '        End If

            '    End If
            'End If



        Catch ex As Exception

        End Try
    End Sub





End Class