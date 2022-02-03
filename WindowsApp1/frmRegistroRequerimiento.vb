
Imports Nordic.Bl.Be
Imports System.IO

Public Class frmRegistroRequerimiento

    Public flagAction As String
    Public usr_id As String
    Public per_id As String

    Friend WithEvents BtnQuitarFile As System.Windows.Forms.Button
    Private mnuContextual As New ContextMenuStrip

    Private Sub frmRegistroRequerimiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Cargar_ListaSolicitantes()
            Cargar_ListaEmpresas()
            configurarMenucontextual()
            cboSolicitante.SelectedValue = usr_id

            If per_id = 1 Then
                cboSolicitante.Enabled = True
            Else
                cboSolicitante.Enabled = False
            End If

            If flagAction = "Nuevo" Then
                txtAsunto.Focus()
            End If



        Catch ex As Exception

        End Try
    End Sub


    Public Sub configurarMenucontextual()

        Dim oToolStripItem1 As New ToolStripMenuItem

        oToolStripItem1.Text = "Quitar Archivo"
        oToolStripItem1.Tag = "1"
        'oToolStripItem3.ShortcutKeys = Shortcut.CtrlQ
        AddHandler oToolStripItem1.Click, AddressOf BtnQuitarFile_Click
        mnuContextual.Items.Add(oToolStripItem1)
        dgvArchivosAdjuntos.ContextMenuStrip = mnuContextual

    End Sub

    Private Sub BtnQuitarFile_Click(sender As Object, e As EventArgs) Handles BtnQuitarFile.Click
        Try
            dgvArchivosAdjuntos.Rows.RemoveAt(dgvArchivosAdjuntos.CurrentRow.Index)
            lblCantidadFileAdjuntos.Text = CStr(dgvArchivosAdjuntos.Rows.Count)

        Catch ex As Exception

        End Try
    End Sub


    Sub Cargar_ListaSolicitantes()
        Try
            Dim objReq As New BeRequerimiento
            Dim dt As New DataTable

            dt = objReq.Obtener_Solicitantes()

            cboSolicitante.DataSource = dt
            cboSolicitante.ValueMember = "usr_id"
            cboSolicitante.DisplayMember = "usr_nombre"

        Catch ex As Exception
            MessageBox.Show(ex.Message, "NORDIC", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Sub Cargar_ListaEmpresas()

        Try
            Dim objReq As New BeRequerimiento
            Dim dt As New DataTable

            dt = objReq.Obtener_Empresas()

            cboEmpresas.DataSource = dt
            cboEmpresas.ValueMember = "emp_cod"
            cboEmpresas.DisplayMember = "emp_des"

        Catch ex As Exception
            MessageBox.Show(ex.Message, "NORDIC", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try

            If txtAsunto.Text = "" Then
                MessageBox.Show("Ingrese el asunto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtAsunto.Focus()
            Else
                If cboSolicitante.SelectedIndex = 0 Then
                    MessageBox.Show("Debe seleccionar el solicitante", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    cboSolicitante.Focus()
                Else
                    If rtbDescripcion.Text = "" Then
                        MessageBox.Show("Ingrese la descripcion", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        rtbDescripcion.Focus()
                    Else

                        Dim _tipoRespuesta As String = String.Empty
                        Dim _textoRespuesta As String = String.Empty
                        Dim idReq As String = String.Empty
                        Dim fechaHora As String = String.Empty

                        Dim obj As New BeRequerimiento

                        obj.pr_req_asunto = txtAsunto.Text.Trim
                        obj.pr_usrid_solicitante = cboSolicitante.SelectedValue
                        obj.pr_emp_cod = cboEmpresas.SelectedValue
                        obj.pr_req_descripcion = rtbDescripcion.Text.Trim
                        obj.pr_usr_id = usr_id
                        obj.pr_req_rutaDestino = "\\10.10.0.24\Attachments\NORDIC\Requerimiento\"

                        obj.RegistrarRequerimiento(obj, _tipoRespuesta, _textoRespuesta, idReq, fechaHora)

                        If _tipoRespuesta = "1" Then

                            If dgvArchivosAdjuntos.RowCount > 0 Then
                                CopiarArchivosDirectorioServidor(idReq, obj.pr_req_rutaDestino)
                            End If

                            txtNroReq.Text = idReq
                            txtFechaHoraReg.Text = fechaHora
                            Deshabilitar()

                            MessageBox.Show("Se genero el Requerimiento Nro: " + idReq, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                            Me.Close()
                        Else
                            If _tipoRespuesta = "0" Then

                                Deshabilitar()
                                MessageBox.Show("Error al Registrar: " + _textoRespuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                                Me.Close()
                            End If
                        End If
                    End If
                End If
            End If

        Catch ex As Exception

        End Try
    End Sub


    Sub Deshabilitar()

        txtFechaHoraReg.Enabled = False
        cboSolicitante.Enabled = False
        cboEmpresas.Enabled = False
        txtAsunto.Enabled = False
        rtbDescripcion.ReadOnly = True
        btnGuardar.Enabled = False
        btnCancelar.Enabled = False

    End Sub

    Private Sub btnAdjuntar_Click(sender As Object, e As EventArgs) Handles btnAdjuntar.Click
        Try
            Dim RutaArchivo As String = String.Empty
            Dim cantidad As Integer = 0
            Dim flag As Integer = 0

            Dim cantFile As Integer
            cantFile = dgvArchivosAdjuntos.Rows.Count

            'If cantFile = 1 Then
            '    MessageBox.Show("Solo puede agregar un solo archivo por documento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Else

            'OpenFileDialog1.InitialDirectory = "c:\"
            '14,2,9,18
            'If ckbRutaPrincipal.Checked = True Then
            '    OpenFileDialog1.InitialDirectory = "\\192.168.1.12\area ventas y procesos\CONTROL DE COTIZACIONES\AÑO 2018"
            'Else

            OpenFileDialog1.InitialDirectory = "C:\"


            'End If

            OpenFileDialog1.Filter = "All files (*.*)|*.*|pdf files (*.pdf)|*.pdf"
            OpenFileDialog1.FileName = ""
            Me.OpenFileDialog1.Multiselect = True
            Me.OpenFileDialog1.ShowDialog()

            'RutaArchivo = OpenFileDialog1.FileNames
            'Dim nombreArchivo As String = Path.GetFileName(ruta)

            For Each archivos As String In OpenFileDialog1.FileNames
                flag = 0
                '--OpenFileDialog1
                'If OpenFileDialog1.FileName <> "" And OpenFileDialog1.FileName <> "OpenFileDialog1" Then

                If archivos <> "" Then
                    For i As Integer = 0 To dgvArchivosAdjuntos.Rows.Count - 1
                        If dgvArchivosAdjuntos.Rows(i).Cells.Item(1).Value = archivos Then
                            flag = 1
                            MessageBox.Show("El archivo " + archivos + " ya se encuentra adjunto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Exit For
                        End If
                    Next

                    If flag = 0 Then
                        cantidad = dgvArchivosAdjuntos.Rows.Count
                        dgvArchivosAdjuntos.Rows.Insert(cantidad, Path.GetFileName(archivos), archivos)
                        'dgvArchivosAdjuntos.Rows.Insert(cantidad, OpenFileDialog1.FileName)
                    End If

                    ' lblCantidadFileAdjuntos.Text = CStr(dgvArchivosAdjuntos.Rows.Count)
                End If
                'End If
            Next

            ' End If

            lblCantidadFileAdjuntos.Text = CStr(dgvArchivosAdjuntos.Rows.Count)
        Catch ex As Exception

        End Try
    End Sub


    Sub CopiarArchivosDirectorioServidor(ByVal req_id As String, ByVal ruta_destino As String)
        Try
            Dim nombreArchivo As String
            Dim file As String
            Dim rutaOrigen As String
            Dim rutaDestino As String
            'Dim rd_id As Integer

            Dim _tiporespuesta As String = String.Empty
            Dim _textorespuesta As String = String.Empty


            Dim objDoc As New BeRequerimiento

            For i As Integer = 0 To dgvArchivosAdjuntos.RowCount - 1

                rutaOrigen = dgvArchivosAdjuntos.Rows(i).Cells.Item(1).Value
                nombreArchivo = dgvArchivosAdjuntos.Rows(i).Cells.Item(0).Value

                file = req_id + "_" + nombreArchivo
                rutaDestino = ruta_destino + file

                My.Computer.FileSystem.CopyFile(rutaOrigen, rutaDestino)
                objDoc.SaveAttachments(req_id, rutaDestino, file, 0, _tiporespuesta, _textorespuesta)

            Next

        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Try

            If MessageBox.Show("Esta Usted seguro que desea cancelar ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Me.Close()
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub rtbDescripcion_TextChanged(sender As Object, e As EventArgs) Handles rtbDescripcion.TextChanged
        Try
            Dim cantidad As Integer = rtbDescripcion.Text.Length
            If cantidad < 8000 Then
                '    lblCantAnalisisVenta.Text = cantidad
                '    lblCantAnalisisVenta.ForeColor = Color.Red
                '    Label45.ForeColor = Color.Red
                'ElseIf cantidad >= 100 Then
                lblCantCaracteres.Text = cantidad
                lblCantCaracteres.ForeColor = Color.Green
                Label45.ForeColor = Color.Green
            Else
                lblCantCaracteres.ForeColor = Color.Red
                Label45.ForeColor = Color.Red
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class