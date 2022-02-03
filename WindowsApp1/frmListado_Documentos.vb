
Imports Nordic.Bl.Be
Imports System.IO

Public Class frmListado_Documentos

    Public usr_id As Integer

    Private Sub frmListado_Documentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            Cargar_Area()
            Cargar_TipoDocumentos()

        Catch ex As Exception

        End Try
    End Sub


    Sub Cargar_Area()
        Try
            Dim objDoc As New BeDocumentos
            Dim dt As New DataTable

            dt = objDoc.Obtener_Areas()

            cbxArea.DataSource = dt
            cbxArea.ValueMember = "ar_cod"
            cbxArea.DisplayMember = "ar_des"

        Catch ex As Exception
            MessageBox.Show(ex.Message, "NORDIC", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Sub Cargar_TipoDocumentos()
        Try
            Dim objDoc As New BeDocumentos
            Dim dt As New DataTable

            dt = objDoc.Obtener_TipoDocumentos()

            cbxTipDoc.DataSource = dt
            cbxTipDoc.ValueMember = "ta_id"
            cbxTipDoc.DisplayMember = "ta_des"

        Catch ex As Exception
            MessageBox.Show(ex.Message, "NORDIC", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btn_Nuevo_Click(sender As Object, e As EventArgs) Handles btn_Nuevo.Click
        Try
            Dim objRegDoc As New frmRegistrar_Documentos

            objRegDoc.usr_id = usr_id
            objRegDoc.ShowDialog()

            ObtenerDocumentosDia()

        Catch ex As Exception

        End Try
    End Sub


    Sub ObtenerDocumentosDia()
        Try
            Listar_Documentos(0, "", "", 0, 0, "", "", "")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try

            If chk_porGuia.Checked = False And chk_porComp.Checked = False And chk_porOrdenC.Checked = False Then

                If cbxArea.SelectedIndex = 0 And cbxTipDoc.SelectedIndex = 0 Then
                    Listar_Documentos(1, dtpFecIni.Value.ToShortDateString, dtpFecFin.Value.ToShortDateString, 0, 0, "", "", "")
                End If

                If cbxArea.SelectedIndex <> 0 And cbxTipDoc.SelectedIndex = 0 Then
                    Listar_Documentos(2, dtpFecIni.Value.ToShortDateString, dtpFecFin.Value.ToShortDateString, cbxArea.SelectedValue, 0, "", "", "")
                End If

                If cbxArea.SelectedIndex <> 0 And cbxTipDoc.SelectedIndex <> 0 Then
                    Listar_Documentos(3, dtpFecIni.Value.ToShortDateString, dtpFecFin.Value.ToShortDateString, cbxArea.SelectedValue, cbxTipDoc.SelectedValue, "", "", "")
                End If

            End If

            If chk_porGuia.Checked = True Then

                If txtGuia.Text = "" Then
                    MessageBox.Show("Ingrese el Numero de Guía", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtGuia.Focus()
                Else

                    Listar_Documentos(4, dtpFecIni.Value.ToShortDateString, dtpFecFin.Value.ToShortDateString, cbxArea.SelectedValue, cbxTipDoc.SelectedValue, txtGuia.Text.Trim, "", "")
                End If


            End If

            If chk_porComp.Checked = True Then
                If txtComp.Text = "" Then
                    MessageBox.Show("Ingrese el Numero de Comprobante", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtComp.Focus()
                Else

                    Listar_Documentos(5, dtpFecIni.Value.ToShortDateString, dtpFecFin.Value.ToShortDateString, cbxArea.SelectedValue, cbxTipDoc.SelectedValue, "", txtComp.Text.Trim, "")

                End If

            End If

            If chkCliente.Checked = True Then
                If txtCliente.Text = "" Then
                    MessageBox.Show("Ingrese el nombre del cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtCliente.Focus()
                Else

                    Listar_Documentos(6, dtpFecIni.Value.ToShortDateString, dtpFecFin.Value.ToShortDateString, 0, 0, "", "", txtCliente.Text.Trim)

                End If

            End If

            tslCantidad.Text = CStr(dgvListarDocumentos.Rows.Count)


        Catch ex As Exception

        End Try
    End Sub


    Sub Listar_Documentos(ByVal flag As Integer, ByVal fecini As String, ByVal fecfin As String, ByVal ar_cod As Integer, ByVal ta_id As Integer, ByVal c5_cnumdoc As String, ByVal f5_cnumdoc As String, ByVal cliente As String)
        Try

            Dim beDoc As New BeDocumentos
            Dim dt As DataTable

            dgvListarDocumentos.Rows.Clear()

            dt = beDoc.Filtrar_documentos(flag, fecini, fecfin, ar_cod, ta_id, c5_cnumdoc, f5_cnumdoc, cliente)

            For i As Integer = 0 To dt.Rows.Count - 1

                dgvListarDocumentos.Rows.Add(dt.Rows(i).Item("ga_id").ToString,
                                             dt.Rows(i).Item("ar_des").ToString,
                                             dt.Rows(i).Item("ta_des").ToString,
                                             dt.Rows(i).Item("C5_CNUMDOC").ToString,
                                             dt.Rows(i).Item("Comprobante").ToString,
                                             dt.Rows(i).Item("Importe").ToString,
                                             dt.Rows(i).Item("Saldo").ToString,
                                             dt.Rows(i).Item("Ruc").ToString,
                                             dt.Rows(i).Item("Cliente").ToString,
                                             dt.Rows(i).Item("usr_nombre").ToString,
                                             dt.Rows(i).Item("Fecha_Registro").ToString,
                                             dt.Rows(i).Item("usr_nombremod").ToString,
                                             dt.Rows(i).Item("Fecha_Mod").ToString,
                                             dt.Rows(i).Item("filename").ToString,
                                             dt.Rows(i).Item("ruta").ToString)

            Next


        Catch ex As Exception

        End Try
    End Sub


    Private Sub dgvListarDocumentos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListarDocumentos.CellContentClick
        Try
            Dim ruta As String = String.Empty

            If e.ColumnIndex = 15 Then

                ruta = dgvListarDocumentos.CurrentRow.Cells.Item("ruta").Value

                'ruta = "G:\INSTITUCIONAL\CARGOS\F203-00\142_FT_F203_0000046.pdf"

                Process.Start(ruta)

            End If
        Catch ex As Exception

            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub chk_porGuia_CheckedChanged(sender As Object, e As EventArgs) Handles chk_porGuia.CheckedChanged
        Try
            If chk_porGuia.Checked = True Then

                chk_porComp.Checked = False
                txtComp.Text = ""

                chkCliente.Checked = False
                txtCliente.Text = ""


                txtGuia.Focus()
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub chk_porComp_CheckedChanged(sender As Object, e As EventArgs) Handles chk_porComp.CheckedChanged
        Try
            If chk_porComp.Checked = True Then
                chk_porGuia.Checked = False
                txtGuia.Text = ""

                chkCliente.Checked = False
                txtCliente.Text = ""


                txtComp.Focus()

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtGuia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGuia.KeyPress
        Try

            If e.KeyChar = Convert.ToChar(Keys.Enter) Then

                If txtGuia.Text = "" Then
                    MessageBox.Show("Ingrese la Guía", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtGuia.Focus()

                Else
                    btnBuscar_Click(sender, e)
                End If


            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtComp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtComp.KeyPress


        Try

            If e.KeyChar = Convert.ToChar(Keys.Enter) Then

                If txtComp.Text = "" Then
                    MessageBox.Show("Ingrese Numero Comprobante", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtComp.Focus()

                Else
                    btnBuscar_Click(sender, e)
                End If


            End If


        Catch ex As Exception

        End Try

    End Sub

    Private Sub chkCliente_CheckedChanged(sender As Object, e As EventArgs) Handles chkCliente.CheckedChanged
        Try
            If chkCliente.Checked = True Then

                chk_porGuia.Checked = False
                txtGuia.Text = ""

                chk_porComp.Checked = False
                txtComp.Text = ""


                txtCliente.Focus()

            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCliente.KeyPress
        Try


            If e.KeyChar = Convert.ToChar(Keys.Enter) Then

                If txtCliente.Text = "" Then
                    MessageBox.Show("Ingrese el nombre del Cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtCliente.Focus()

                Else
                    btnBuscar_Click(sender, e)
                End If


            End If



        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_Exportar_Click(sender As Object, e As EventArgs) Handles btn_Exportar.Click
        Try

            Me.Cursor = Cursors.WaitCursor

            GridAExcel(dgvListarDocumentos)

            Me.Cursor = Cursors.Default

        Catch ex As Exception

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
End Class