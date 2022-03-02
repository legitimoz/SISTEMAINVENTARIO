
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
        Catch ex As Exception

        End Try
    End Sub



    Public Sub configurarMenucontextual2()

        Dim oToolStripItem1 As New ToolStripMenuItem

        oToolStripItem1.Text = "Editar Requerimiento"
        oToolStripItem1.Tag = "1"
        'oToolStripItem3.ShortcutKeys = Shortcut.CtrlQ
        AddHandler oToolStripItem1.Click, AddressOf BtnEditarReq_Click
        mnuContextual.Items.Add(oToolStripItem1)


        dgvListadoRequerimientos.ContextMenuStrip = mnuContextual
        '--------------        
    End Sub



    Private Sub BtnEditarReq_Click(sender As Object, e As EventArgs) Handles BtnEditarReq.Click
        Try

            'Public nrosol_var As String = String.Empty
            'Public ruc_var As String = String.Empty
            'Public nomcli_var As String = String.Empty
            'Public codCoti_var As String = String.Empty
            'Public nomCoti_var As String = String.Empty
            'Public codVend_var As String = String.Empty
            'Public vendedor_var As String = String.Empty
            'Public observacion_var As String = String.Empty

            Dim fila As Integer
            fila = dgvListadoRequerimientos.CurrentCell.RowIndex

            Dim Obj As New frmRequerimientoIns
            Obj.idReq = dgvListadoRequerimientos.CurrentRow.Cells.Item(0).Value
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
            Dim dt As New DataTable

            fec1 = dtpFecIni.Value.ToShortDateString
            fec2 = dtpFecFin.Value.ToShortDateString

            If cbxCotizador.SelectedIndex = 0 And txtCompania.Text = "" Then
                dt = obj.Filtros_Requerimientos("0", fec1, fec2, "", "")

            Else
                If cbxCotizador.SelectedIndex <> 0 Then
                    dt = obj.Filtros_Requerimientos("1", fec1, fec2, cbxCotizador.SelectedValue, "")
                Else
                    If txtCompania.Text <> "" Then
                        dt = obj.Filtros_Requerimientos("2", fec1, fec2, "", txtCompania.Text.Trim)
                    End If

                End If
            End If

            dgvListadoRequerimientos.DataSource = dt

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        Try

        Catch ex As Exception

        End Try
    End Sub
End Class