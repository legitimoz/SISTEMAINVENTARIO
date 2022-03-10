
Imports Nordic.Bl.Be


Public Class frmSegReque

    Public usr_id As String
    Public usr_usuario As String

    Friend WithEvents BtnEditarReq As System.Windows.Forms.Button
    Private mnuContextual As New ContextMenuStrip


    Private Sub frmSegReque_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            configurarMenucontextual2()
            ListarCotizadores()
            ListarProductos()

            cboProductos.SelectedValue = "0"
            chkTotalizado.Checked = True

        Catch ex As Exception

        End Try
    End Sub


    Public Sub configurarMenucontextual2()
        Try

            Dim oToolStripItem1 As New ToolStripMenuItem

            oToolStripItem1.Text = "Editar Requerimiento"
            oToolStripItem1.Tag = "1"
            'oToolStripItem3.ShortcutKeys = Shortcut.CtrlQ
            AddHandler oToolStripItem1.Click, AddressOf BtnEditarReq_Click
            mnuContextual.Items.Add(oToolStripItem1)

            dgvListadoRequerimientos.ContextMenuStrip = mnuContextual
            '--------------------------------------------------------  
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnEditarReq_Click(sender As Object, e As EventArgs) Handles BtnEditarReq.Click
        Try

            Dim fila As Integer
            fila = dgvListadoRequerimientos.CurrentCell.RowIndex

            Dim Obj As New frmRequerimientoIns

            Obj.idReq = dgvListadoRequerimientos.CurrentRow.Cells.Item(0).Value
            Obj.usr_id = usr_id
            Obj.flagAccion = "Editar"
            Obj.ShowDialog()


        Catch ex As Exception

        End Try
    End Sub


    Sub ListarCotizadores()
        Try
            Dim objDoc As New BeSolicitudInstitucional
            Dim dt As New DataTable

            dt = objDoc.Obtener_Cotizadores()

            cbxCotizador.DataSource = dt
            cbxCotizador.ValueMember = "cot_codigo"
            cbxCotizador.DisplayMember = "cot_nombre"

        Catch ex As Exception
            MessageBox.Show(ex.Message, "NORDIC", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Sub ListarProductos()
        Try
            Dim objDoc As New BeSolicitudInstitucional
            Dim dt As New DataTable

            dt = objDoc.Obtener_Productos()

            cboProductos.DataSource = dt
            cboProductos.ValueMember = "ar_id"
            cboProductos.DisplayMember = "articulo"

        Catch ex As Exception
            MessageBox.Show(ex.Message, "NORDIC", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Try
            Dim obj As New frmRequerimientoIns

            obj.usr_id = usr_id
            obj.usr_usuario = usr_usuario
            obj.ShowDialog()

            btnBuscar_Click(sender, e)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            Dim obj As New BeCabReque

            Dim fec1 As String
            Dim fec2 As String
            Dim dt As DataTable

            fec1 = dtpFecIni.Value.ToShortDateString
            fec2 = dtpFecFin.Value.ToShortDateString

            If chkTotalizado.Checked = True Then

                If cbxCotizador.SelectedIndex = 0 And txtCompania.Text = "" Then

                    dt = obj.Filtros_Requerimientos("0", fec1, fec2, "", "")
                    dgvListadoRequerimientos.DataSource = dt
                    tslCantidad.Text = CStr(dgvListadoRequerimientos.Rows.Count)

                Else
                    If cbxCotizador.SelectedIndex <> 0 Then

                        dt = obj.Filtros_Requerimientos("1", fec1, fec2, cbxCotizador.SelectedValue, "")
                        dgvListadoRequerimientos.DataSource = dt
                        tslCantidad.Text = CStr(dgvListadoRequerimientos.Rows.Count)

                    Else
                        If txtCompania.Text <> "" Then

                            dt = obj.Filtros_Requerimientos("2", fec1, fec2, "", txtCompania.Text.Trim)
                            dgvListadoRequerimientos.DataSource = dt
                            tslCantidad.Text = CStr(dgvListadoRequerimientos.Rows.Count)

                        End If
                    End If
                End If
            End If


            If chkDetallado.Checked = True Then

                Dim obj2 As New BeCabReque
                Dim dt2 As New DataTable
                Dim fecini As String
                Dim fecfin As String
                Dim a As Integer = 0

                fecini = dtpFecIni.Value.ToShortDateString
                fecfin = dtpFecFin.Value.ToShortDateString

                If cbxCotizador.SelectedIndex = 0 And cboProductos.Text = "" Then
                    dt2 = obj2.Control_Requerimientos_Detalle(0, fecini, fecfin, "", 0)
                Else
                    If cbxCotizador.SelectedIndex <> 0 And cboProductos.Text = "" Then
                        dt2 = obj2.Control_Requerimientos_Detalle(1, fecini, fecfin, cbxCotizador.SelectedValue, 0)
                    Else
                        If cbxCotizador.SelectedIndex <> 0 And cboProductos.Text <> "" Then
                            dt2 = obj2.Control_Requerimientos_Detalle(2, fecini, fecfin, cbxCotizador.SelectedValue, cboProductos.SelectedValue)
                        Else
                            If cbxCotizador.SelectedIndex = 0 And cboProductos.Text <> "" Then
                                dt2 = obj2.Control_Requerimientos_Detalle(3, fecini, fecfin, "", cboProductos.SelectedValue)
                            End If
                        End If
                    End If
                End If

                dgvLitadoRequerimientoDetalle.DataSource = dt2

                If dgvLitadoRequerimientoDetalle.Rows.Count > 0 Then
                    For i As Integer = 0 To dgvLitadoRequerimientoDetalle.Rows.Count - 1
                        dgvLitadoRequerimientoDetalle.Rows(i).Cells.Item("chk_selector").Value = True
                    Next

                    chkAll.Checked = True

                End If

            End If

        Catch ex As Exception

        End Try
    End Sub


    Private Sub dgvListadoRequerimientos_SelectionChanged(sender As Object, e As EventArgs) Handles dgvListadoRequerimientos.SelectionChanged
        Try
            Dim obj As New BeCabReque
            Dim idReq As Integer
            Dim dt As New DataTable

            idReq = dgvListadoRequerimientos.CurrentRow.Cells.Item(0).Value

            dt = obj.Filtros_Requerimientos_Detalle(idReq)

            dgvListarReqDetalle.DataSource = dt
            dgvListarReqDetalle.Columns(1).Visible = False
            dgvListarReqDetalle.Columns(2).Visible = False
            dgvListarReqDetalle.Columns(3).Visible = False
            dgvListarReqDetalle.Columns(4).Visible = False
            dgvListarReqDetalle.Columns(5).Visible = False
            dgvListarReqDetalle.Columns(16).Visible = False
            dgvListarReqDetalle.Columns(17).Visible = False
            dgvListarReqDetalle.Columns(18).Visible = False
            dgvListarReqDetalle.Columns(19).Visible = False
            dgvListarReqDetalle.Columns(20).Visible = False

        Catch ex As Exception

        End Try
    End Sub


    Private Sub txtCompania_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCompania.KeyPress
        Try

            Dim dt As New DataTable
            Dim obj As New BeCabReque
            Dim fec1 As String
            Dim fec2 As String

            fec1 = dtpFecIni.Value.ToShortDateString
            fec2 = dtpFecFin.Value.ToShortDateString

            If e.KeyChar = Convert.ToChar(Keys.Enter) Then

                If txtCompania.Text = "" Then
                    MessageBox.Show("Ingrese el nombre del cliente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtCompania.Focus()

                Else
                    dt = obj.Filtros_Requerimientos("2", fec1, fec2, "", txtCompania.Text.Trim)

                    dgvListadoRequerimientos.DataSource = dt

                End If


            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub chkTotalizado_CheckedChanged(sender As Object, e As EventArgs) Handles chkTotalizado.CheckedChanged
        Try

            If chkTotalizado.Checked = True Then
                chkDetallado.Checked = False
            End If

            If chkTotalizado.Checked = False Then
                chkDetallado.Checked = True
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub chkDetallado_CheckedChanged(sender As Object, e As EventArgs) Handles chkDetallado.CheckedChanged
        Try

            If chkDetallado.Checked = True Then
                chkTotalizado.Checked = False
            End If

            If chkDetallado.Checked = False Then
                chkTotalizado.Checked = True
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAsignar_Click(sender As Object, e As EventArgs) Handles btnAsignar.Click
        Try
            Dim obj As New frmAsignarValor
            Dim dt As New DataTable
            Dim dt2 As New DataTable
            Dim obj2 As New BeCabReque
            Dim fecini As String
            Dim fecfin As String

            fecini = dtpFecIni.Value.ToShortDateString
            fecfin = dtpFecFin.Value.ToShortDateString

            If cboProductos.Text = "" And dgvLitadoRequerimientoDetalle.Rows.Count = 0 Then
                MessageBox.Show("Debe filtrar algun codigo de Producto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            Else
                If cbxCotizador.SelectedIndex <> 0 And cboProductos.Text <> "" Then
                    dt2 = obj2.Control_Requerimientos_Detalle(2, fecini, fecfin, cbxCotizador.SelectedValue, cboProductos.SelectedValue)
                Else
                    If cbxCotizador.SelectedIndex = 0 And cboProductos.Text <> "" Then
                        dt2 = obj2.Control_Requerimientos_Detalle(3, fecini, fecfin, "", cboProductos.SelectedValue)
                    End If
                End If

                dgvLitadoRequerimientoDetalle.DataSource = dt2

                If dgvLitadoRequerimientoDetalle.Rows.Count > 0 Then

                    For i As Integer = 0 To dgvLitadoRequerimientoDetalle.Rows.Count - 1
                        dgvLitadoRequerimientoDetalle.Rows(i).Cells.Item("chk_selector").Value = True
                    Next

                End If


                obj.codigo = cboProductos.SelectedValue
                obj.articulo = cboProductos.Text

                dt.Columns.Add()

                For i As Integer = 0 To dgvLitadoRequerimientoDetalle.Rows.Count - 1

                    If dgvLitadoRequerimientoDetalle.Rows(i).Cells.Item("chk_selector").Value = True Then
                        dt.Rows.Add()
                        dt.Rows(i).Item(0) = dgvLitadoRequerimientoDetalle.Rows(i).Cells.Item(1).Value

                    End If

                Next

                obj.dtIds = dt

                obj.ShowDialog()
            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub chkAll_CheckedChanged(sender As Object, e As EventArgs) Handles chkAll.CheckedChanged
        Try

            If chkAll.Checked = True Then
                For i As Integer = 0 To dgvLitadoRequerimientoDetalle.Rows.Count - 1
                    dgvLitadoRequerimientoDetalle.Rows(i).Cells.Item("chk_selector").Value = True
                Next
            End If

            If chkAll.Checked = False Then
                For i As Integer = 0 To dgvLitadoRequerimientoDetalle.Rows.Count - 1
                    dgvLitadoRequerimientoDetalle.Rows(i).Cells.Item("chk_selector").Value = False
                Next
            End If

        Catch ex As Exception

        End Try
    End Sub
End Class