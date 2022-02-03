
Imports Nordic.Bl.Be
Imports System.IO

Public Class frmRegistrar_Documentos

    Public usr_id As Integer
    Friend WithEvents BtnQuitarFile As System.Windows.Forms.Button
    Private mnuContextual As New ContextMenuStrip

    Private Sub frmRegistrar_Documentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            Cargar_Area()
            Cargar_TipoDocumentos()


            configurarMenucontextual()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub BtnQuitarFile_Click(sender As Object, e As EventArgs) Handles BtnQuitarFile.Click
        Try
            dgvArchivosAdjuntos.Rows.RemoveAt(dgvArchivosAdjuntos.CurrentRow.Index)
            lblCantidadFileAdjuntos.Text = CStr(dgvArchivosAdjuntos.Rows.Count)

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


    Sub Cargar_RutasDestino(ByVal ar_cod As String, ByVal tpd_codigo As String)
        Try
            Dim objDoc As New BeDocumentos
            Dim dt As New DataTable

            dt = objDoc.Obtener_RutasDocumentos(ar_cod, tpd_codigo)

            cbxRutasDestino.DataSource = dt
            cbxRutasDestino.ValueMember = "rd_id"
            cbxRutasDestino.DisplayMember = "rd_ruta"

        Catch ex As Exception
            MessageBox.Show(ex.Message, "NORDIC", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Try
            If cbxTipDoc.SelectedIndex = 1 Then
                Dim objListarGuias As New frmListaGuias

                objListarGuias.flag = 1
                objListarGuias.ShowDialog()

                txtNroDocumento.Text = objListarGuias.c5_cnumdoc
                lblc5_alma.Text = objListarGuias.c5_calma
                lblc5_ctd.Text = objListarGuias.c5_ctd

            End If

            If cbxTipDoc.SelectedIndex = 2 Then
                Dim objListarComprobantes As New frmListaComprobantes

                objListarComprobantes.flag = 1
                objListarComprobantes.ShowDialog()

                lbl_f5_ccodage.Text = objListarComprobantes.f5_ccodage
                lbl_f5_ctd.Text = objListarComprobantes.f5_ctd
                lbl_f5_cnumser.Text = objListarComprobantes.f5_cnumser
                lbl_f5_cnumdoc.Text = objListarComprobantes.f5_cnumdoc
                txtNroDocumento.Text = objListarComprobantes.nombre_archivo

                'txtNroDocumento.Text = objListarGuias.c5_cnumdoc
                'lblc5_alma.Text = objListarGuias.c5_calma
                'lblc5_ctd.Text = objListarGuias.c5_ctd

            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAdjuntar_Click(sender As Object, e As EventArgs) Handles btnAdjuntar.Click
        Try
            Dim RutaArchivo As String = String.Empty
            Dim cantidad As Integer = 0
            Dim flag As Integer = 0

            Dim cantFile As Integer
            cantFile = dgvArchivosAdjuntos.Rows.Count

            If cantFile = 1 Then
                MessageBox.Show("Solo puede agregar un solo archivo por documento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else

                'OpenFileDialog1.InitialDirectory = "c:\"
                '14,2,9,18
                'If ckbRutaPrincipal.Checked = True Then
                '    OpenFileDialog1.InitialDirectory = "\\192.168.1.12\area ventas y procesos\CONTROL DE COTIZACIONES\AÑO 2018"
                'Else
                If usr_id = 57 Then
                    OpenFileDialog1.InitialDirectory = "G:\Scaner"
                Else
                    OpenFileDialog1.InitialDirectory = "D:\attachments"
                End If


                'End If

                OpenFileDialog1.Filter = "All files (*.*)|*.*|pdf files (*.pdf)|*.pdf"
                OpenFileDialog1.FileName = ""
                Me.OpenFileDialog1.Multiselect = False
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

            End If

            lblCantidadFileAdjuntos.Text = CStr(dgvArchivosAdjuntos.Rows.Count)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim tipoRespuesta As String = String.Empty
            Dim textoRespuesta As String = String.Empty
            Dim ga_id As String = String.Empty
            Dim fechaRegistro As String = String.Empty

            Dim objDoc As New BeDocumentos

            If cbxArea.SelectedIndex = 0 Then
                MessageBox.Show("Debe Seleccionar el Area", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            Else
                If cbxTipDoc.SelectedIndex = 0 Then
                    MessageBox.Show("Debe Seleccionar el Tipo de Documento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    If (cbxTipDoc.SelectedValue = 1 Or cbxTipDoc.SelectedValue = 2 Or cbxTipDoc.SelectedValue = 3) And txtNroDocumento.Text = "" Then
                        MessageBox.Show("Debe ingresar el numero de Documento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        txtNroDocumento.Focus()
                    Else
                        If cbxRutasDestino.SelectedIndex = 0 Then
                            MessageBox.Show("Debe Seleccionar la ruta Destino", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            cbxRutasDestino.Focus()
                        Else
                            If dgvArchivosAdjuntos.Rows.Count = 0 Then
                                MessageBox.Show("Debe adjuntar el archivo scaneado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                btnAdjuntar.Focus()
                            Else

                                objDoc.prar_cod = cbxArea.SelectedValue
                                objDoc.prta_id = cbxTipDoc.SelectedValue

                                objDoc.prga_obs = txtDescripcion.Text
                                objDoc.prga_usrid = usr_id
                                objDoc.prga_rutaDestino = cbxRutasDestino.Text.Trim

                                If cbxTipDoc.SelectedValue = 1 Then
                                    objDoc.prc5_calma = lblc5_alma.Text
                                    objDoc.prc5_ctd = lblc5_ctd.Text
                                    objDoc.prc5_cnumdoc = txtNroDocumento.Text

                                Else
                                    objDoc.prc5_calma = ""
                                    objDoc.prc5_ctd = ""
                                    objDoc.prc5_cnumdoc = ""

                                End If

                                If cbxTipDoc.SelectedValue = 2 Then
                                    objDoc.prf5_ccodage = lbl_f5_ccodage.Text
                                    objDoc.prf5_ctd = lbl_f5_ctd.Text
                                    objDoc.prf5_cnumser = lbl_f5_cnumser.Text
                                    objDoc.prf5_cnumdoc = lbl_f5_cnumdoc.Text
                                Else
                                    objDoc.prf5_ccodage = ""
                                    objDoc.prf5_ctd = ""
                                    objDoc.prf5_cnumser = ""
                                    objDoc.prf5_cnumdoc = ""
                                End If

                                objDoc.RegistrarDocumento(objDoc, tipoRespuesta, textoRespuesta, ga_id, fechaRegistro)

                                If tipoRespuesta = 1 Then
                                    txtCodigo.Text = ga_id
                                    txtFecRegistro.Text = fechaRegistro

                                    If dgvArchivosAdjuntos.RowCount > 0 Then
                                        CopiarArchivosDirectorioServidor(ga_id, objDoc.prga_rutaDestino)
                                    End If

                                    MessageBox.Show("Se registró de forma exitosa el documento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                                    Me.Close()
                                End If

                            End If
                        End If
                    End If
                End If
            End If


        Catch ex As Exception

        End Try
    End Sub


    Sub CopiarArchivosDirectorioServidor(ByVal ga_id As String, ByVal ruta_destino As String)
        Try
            Dim nombreArchivo As String
            Dim file As String
            Dim rutaOrigen As String
            Dim rutaDestino As String
            Dim rd_id As Integer

            Dim _tiporespuesta As String = String.Empty
            Dim _textorespuesta As String = String.Empty
            Dim posicion As Integer
            Dim extension As String

            Dim objDoc As New BeDocumentos

            For i As Integer = 0 To dgvArchivosAdjuntos.RowCount - 1

                nombreArchivo = dgvArchivosAdjuntos.Rows(i).Cells.Item(0).Value
                'file = ga_id + "_" + nombreArchivo
                posicion = nombreArchivo.IndexOf(".")

                extension = nombreArchivo.Substring(nombreArchivo.IndexOf("."), (nombreArchivo.Length - nombreArchivo.IndexOf(".")))

                file = ga_id + "_" + txtNroDocumento.Text.Trim + extension

                'rutaDestino = "\\SRVWEB\attachments_coti\" + file

                'rutaDestino = "D:\attachments\" + file
                rutaDestino = ruta_destino + file

                rutaOrigen = dgvArchivosAdjuntos.Rows(i).Cells.Item(1).Value

                rd_id = cbxRutasDestino.SelectedValue

                My.Computer.FileSystem.CopyFile(rutaOrigen, rutaDestino)
                objDoc.SaveAttachments(ga_id, rutaDestino, file, rd_id, _tiporespuesta, _textorespuesta)

            Next

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Try
            Me.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvArchivosAdjuntos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvArchivosAdjuntos.CellContentClick

    End Sub

    Private Sub cbxTipDoc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxTipDoc.SelectedIndexChanged
        Try
            Dim ar_cod As String
            Dim tpd_codigo As String

            ar_cod = cbxArea.SelectedValue
            tpd_codigo = cbxTipDoc.SelectedValue

            Cargar_RutasDestino(ar_cod, tpd_codigo)

            lblc5_alma.Text = ""
            lblc5_ctd.Text = ""
            txtNroDocumento.Text = ""

            lbl_f5_ccodage.Text = ""
            lbl_f5_ctd.Text = ""
            lbl_f5_cnumser.Text = ""
            lbl_f5_cnumdoc.Text = ""


        Catch ex As Exception

        End Try
    End Sub

    Private Sub lblCantidadFileAdjuntos_Click(sender As Object, e As EventArgs) Handles lblCantidadFileAdjuntos.Click

    End Sub
End Class