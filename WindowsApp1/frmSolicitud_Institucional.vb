

Imports Nordic.Bl.Be


Public Class frmSolicitud_Institucional

    Public usr_id As String
    Public usr_usuario As String = String.Empty

    Private mnuContextual As New ContextMenuStrip
    Private mnuContextual2 As New ContextMenuStrip

    Friend WithEvents BtnAbrirArchivo As System.Windows.Forms.Button
    Friend WithEvents BtnAsignarCliente As System.Windows.Forms.Button
    Friend WithEvents BtnRequerimiento As System.Windows.Forms.Button
    Friend WithEvents BtnAnularSolicitudCotizacion As System.Windows.Forms.Button


    Private Sub frmSolicitud_Institucional_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            configurarMenucontextual()
            configurarMenucontextual2()
            Cargar_Solicitudes(0, "", "")
            ListarCotizadores()

            Timer1.Start()
            tsbIniciar.Enabled = False
            lblStatus.Text = "ACTIVO"
            lblStatus.ForeColor = Color.Green


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


    Public Sub configurarMenucontextual()

        Dim oToolStripItem1 As New ToolStripMenuItem

        oToolStripItem1.Text = "Abrir Archivo"
        oToolStripItem1.Tag = "1"
        'oToolStripItem3.ShortcutKeys = Shortcut.CtrlQ
        AddHandler oToolStripItem1.Click, AddressOf BtnAbrirArchivo_Click
        mnuContextual.Items.Add(oToolStripItem1)


        dgvArchivosAdjuntos.ContextMenuStrip = mnuContextual
        '--------------        
    End Sub


    Public Sub configurarMenucontextual2()

        Dim oToolStripItem1 As New ToolStripMenuItem

        oToolStripItem1.Text = "Anular Solicitud"
        oToolStripItem1.Tag = "1"
        'oToolStripItem3.ShortcutKeys = Shortcut.CtrlQ
        AddHandler oToolStripItem1.Click, AddressOf BtnAnularSolicitudCotizacion_Click
        mnuContextual2.Items.Add(oToolStripItem1)

        Dim oToolStripItem2 As New ToolStripMenuItem

        oToolStripItem2.Text = "Asignar Cliente"
        oToolStripItem2.Tag = "2"
        'oToolStripItem3.ShortcutKeys = Shortcut.CtrlQ
        AddHandler oToolStripItem2.Click, AddressOf BtnAsignarCliente_Click
        mnuContextual2.Items.Add(oToolStripItem2)

        Dim oToolStripItem3 As New ToolStripMenuItem

        oToolStripItem3.Text = "Requerimiento"
        oToolStripItem3.Tag = "3"
        'oToolStripItem3.ShortcutKeys = Shortcut.CtrlQ
        AddHandler oToolStripItem3.Click, AddressOf BtnRequerimiento_Click
        mnuContextual2.Items.Add(oToolStripItem3)


        dgvListarSolicitudes.ContextMenuStrip = mnuContextual2
        '--------------        
    End Sub


    Private Sub BtnAnularSolicitudCotizacion_Click(sender As Object, e As EventArgs) Handles BtnAnularSolicitudCotizacion.Click
        Try

            Dim fila As Integer
            fila = dgvListarSolicitudes.CurrentCell.RowIndex

            Dim idSol As Integer
            Dim tipoRespuesta As String = String.Empty
            Dim textoRespuesta As String = String.Empty
            Dim ObjElim As New frmMotivoAnulacion

            idSol = dgvListarSolicitudes.CurrentRow.Cells.Item("sol_id").Value

            If MessageBox.Show("Esta Usted Seguro que desea anular la Solicitud de Cotización Nro: " + CStr(idSol), "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then


                Timer1.Stop()

                ObjElim.idSolicitud = idSol
                ObjElim.usr_id = usr_id
                ObjElim.ShowDialog()

                Cargar_Solicitudes(0, "", "")
                Timer1.Start()

            End If

        Catch ex As Exception

        End Try
    End Sub


    Private Sub BtnRequerimiento_Click(sender As Object, e As EventArgs) Handles BtnRequerimiento.Click
        Try

            Dim obj As New frmRequerimientoIns

            obj.Bandera_nuevo = True

            obj.nrosol_var = dgvListarSolicitudes.CurrentRow.Cells.Item("sol_id").Value
            obj.ruc_var = dgvListarSolicitudes.CurrentRow.Cells.Item("ruc").Value
            obj.nomcli_var = dgvListarSolicitudes.CurrentRow.Cells.Item("Cliente").Value
            obj.codVend_var = dgvListarSolicitudes.CurrentRow.Cells.Item("codvend").Value
            obj.vendedor_var = dgvListarSolicitudes.CurrentRow.Cells.Item("Vendedor").Value
            obj.codCoti_var = dgvListarSolicitudes.CurrentRow.Cells.Item("codcot").Value
            obj.nomCoti_var = dgvListarSolicitudes.CurrentRow.Cells.Item("Cotizador").Value
            obj.usr_usuario = usr_usuario

            obj.ShowDialog()

            'Dim fila As Integer
            'fila = dgvListarSolicitudes.CurrentCell.RowIndex

            'Dim idSol As Integer

            'Dim ObjAsigCliente As New frmAsignarCliente

            'idSol = dgvListarSolicitudes.CurrentRow.Cells.Item("sol_id").Value

            'Timer1.Stop()

            'ObjAsigCliente.idSolicitud = idSol
            'ObjAsigCliente.usr_id = usr_id
            'ObjAsigCliente.ShowDialog()

            'Cargar_Solicitudes(0, "", "")

            'Timer1.Start()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnAsignarCliente_Click(sender As Object, e As EventArgs) Handles BtnAsignarCliente.Click
        Try

            Dim fila As Integer
            fila = dgvListarSolicitudes.CurrentCell.RowIndex

            Dim idSol As Integer = 0

            Dim ObjAsigCliente As New frmAsignarCliente

            idSol = dgvListarSolicitudes.CurrentRow.Cells.Item("sol_id").Value

            Timer1.Stop()

            ObjAsigCliente.idSolicitud = idSol
            ObjAsigCliente.usr_id = usr_id
            ObjAsigCliente.ShowDialog()

            Cargar_Solicitudes(0, "", "")

            Timer1.Start()

        Catch ex As Exception

        End Try
    End Sub





    Private Sub BtnAbrirArchivo_Click(sender As Object, e As EventArgs) Handles BtnAbrirArchivo.Click
        Try
            Dim ruta As String

            ruta = dgvArchivosAdjuntos.CurrentRow.Cells(2).Value.ToString

            Process.Start(ruta)

        Catch ex As Exception

        End Try
    End Sub

    Sub Cargar_Solicitudes(ByVal flag As String, ByVal fecini As String, ByVal fecfin As String)
        Try
            Dim objSolicitud As New BeSolicitudInstitucional
            Dim dt As New DataTable

            dgvListarSolicitudes.Rows.Clear()

            dt = objSolicitud.Listar_Solicitudes(flag, fecini, fecfin)

            For i As Integer = 0 To dt.Rows.Count - 1
                dgvListarSolicitudes.Rows.Add(dt.Rows(i).Item("sol_id").ToString, dt.Rows(i).Item("sol_fecrecep").ToString, dt.Rows(i).Item("hora").ToString, dt.Rows(i).Item("diferencia").ToString & "-" & dt.Rows(i).Item("tiempo").ToString, dt.Rows(i).Item("estado").ToString, dt.Rows(i).Item("sol_correo").ToString,
                                              dt.Rows(i).Item("sol_asunto").ToString, dt.Rows(i).Item("sol_contacto").ToString, dt.Rows(i).Item("sol_cuerpohtml").ToString, dt.Rows(i).Item("Cliente").ToString, dt.Rows(i).Item("Cotizador").ToString, dt.Rows(i).Item("Vendedor").ToString,
                                              dt.Rows(i).Item("ruc").ToString, dt.Rows(i).Item("codvend").ToString, dt.Rows(i).Item("codcot").ToString)
            Next

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            Cargar_Solicitudes(0, "", "")

        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvListarSolicitudes_SelectionChanged(sender As Object, e As EventArgs) Handles dgvListarSolicitudes.SelectionChanged
        Try

            Dim cuerpoMail As String = String.Empty
            Dim sol_id As String = String.Empty

            sol_id = dgvListarSolicitudes.CurrentRow.Cells.Item("sol_id").Value
            cuerpoMail = dgvListarSolicitudes.CurrentRow.Cells.Item("sol_cuerpohtml").Value

            WebBrowser1.Navigate("about:blank")
            WebBrowser1.Document.OpenNew(False)
            WebBrowser1.Document.Write(cuerpoMail)

            WebBrowser1.Refresh()


            Cargar_AttachmentsCoti(sol_id)
        Catch ex As Exception

        End Try
    End Sub




    Sub Cargar_AttachmentsCoti(ByVal idSolicitud As String)
        Try
            Dim dt As New DataTable
            Dim objSolicitud As New BeSolicitudInstitucional

            dt = objSolicitud.Listar_Adjuntos_x_Solicitud(idSolicitud)

            dgvArchivosAdjuntos.DataSource = dt

            dgvArchivosAdjuntos.Columns(0).Visible = False
            dgvArchivosAdjuntos.Columns(1).Width = 320
            dgvArchivosAdjuntos.Columns(2).Width = 250


        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Cargar_Solicitudes(1, dtpFecIni.Value.ToShortDateString, dtpFecFin.Value.ToShortDateString)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub tsbIniciar_Click(sender As Object, e As EventArgs) Handles tsbIniciar.Click
        Try

            Timer1.Start()
            tsbDetener.Enabled = True
            tsbIniciar.Enabled = False

            lblStatus.Text = "ACTIVO"

            lblStatus.ForeColor = Color.Green

        Catch ex As Exception

        End Try
    End Sub

    Private Sub tsbDetener_Click(sender As Object, e As EventArgs) Handles tsbDetener.Click
        Try
            Timer1.Stop()
            tsbDetener.Enabled = False
            tsbIniciar.Enabled = True

            lblStatus.Text = "DETENIDO"
            lblStatus.ForeColor = Color.Red

        Catch ex As Exception

        End Try
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class