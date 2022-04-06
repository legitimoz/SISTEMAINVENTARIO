Imports Nordic.Bl.Be


Public Class frmRegistrarRuta

    Public usr_id As String
    Public flagAccion As String

    Public crg_id As String
    Public trd_ccodigo As String
    Public fechaRuta As String

    Private mnuContextual As New ContextMenuStrip
    Friend WithEvents _BtnQuitarGuia As System.Windows.Forms.Button



    Private Sub frmRegistrarRuta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            configurarMenucontextual()
            Cargar_Transportistas()

            If flagAccion = "Nuevo" Then
                btnGuardar.Text = "Guardar"
            Else
                If flagAccion = "Actualizar" Then
                    btnGuardar.Text = "Actualizar"

                    lblNroRuta.Text = crg_id
                    cbxTransportista.SelectedValue = trd_ccodigo
                    dtpFecRuta.Value = fechaRuta

                    Cargar_Detalle_Ruta(crg_id)

                End If
            End If

            tslCantTotal.Text = dgvGuiaRuta.Rows.Count

        Catch ex As Exception

        End Try
    End Sub


    Public Sub configurarMenucontextual()
        Try

            Dim oToolStripItem1 As New ToolStripMenuItem
            oToolStripItem1.Text = "Quitar Guía"
            oToolStripItem1.Tag = "1"
            AddHandler oToolStripItem1.Click, AddressOf _BtnQuitarGuia_Click
            mnuContextual.Items.Add(oToolStripItem1)

            dgvGuiaRuta.ContextMenuStrip = mnuContextual

        Catch ex As Exception

        End Try

    End Sub


    Private Sub _BtnQuitarGuia_Click(sender As Object, e As EventArgs) Handles _BtnQuitarGuia.Click
        Try


            Dim fila As Integer
            fila = dgvGuiaRuta.CurrentRow.Index

            If dgvGuiaRuta.Rows(fila).Cells.Item("EST_CODIGO2").Value = "PENDIENTE" Then
                dgvGuiaRuta.Rows.RemoveAt(fila)
            Else
                MessageBox.Show("No se puede Quitar la GUiA, su estado es diferente de PENDIENTE !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If


        Catch ex As Exception

        End Try
    End Sub


    Sub Cargar_Transportistas()
        Try
            Dim objGuia As New BeGuias
            Dim dt As New DataTable

            dt = objGuia.Obtener_Transportistas2()

            cbxTransportista.DataSource = dt
            cbxTransportista.ValueMember = "TR_CCODIGO"
            cbxTransportista.DisplayMember = "TR_CNOMBRE"

        Catch ex As Exception
            MessageBox.Show(ex.Message, "NORDIC", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub txtNroGuia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNroGuia.KeyPress
        Try
            'If e.KeyChar = Convert.ToChar(Keys.Enter) Then

            '    Anadir_GuiaRuta(txtNroGuia.Text.Trim)

            'End If

        Catch ex As Exception

        End Try
    End Sub



    Public Sub Anadir_GuiaRuta(ByVal c5_cnumdoc As String)
        Try
            Dim objGuia As New BeGuias
            Dim dt As New DataTable
            Dim existe As Boolean

            existe = False

            dt = objGuia.Agregar_GuiasRuta(c5_cnumdoc)

            'Dim indice As Integer = 0
            'indice = dgvGuiaRuta.Rows.Count - 1

            If dt.Rows.Count = 0 Then
                MessageBox.Show("La GUIA ingresada no existe !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            Else

                'If dgvGuiaRuta.Rows.Count = 0 Then
                '    indice = 0
                'Else
                '    indice = dgvGuiaRuta.Rows.Count
                'End If

                For i As Integer = 0 To dgvGuiaRuta.Rows.Count - 1

                    If dgvGuiaRuta.Rows(i).Cells.Item("C5_CNUMDOC").Value.ToString.Trim = c5_cnumdoc.Trim Then
                        existe = True
                        Exit For
                    End If

                Next


                If existe = False Then
                    dgvGuiaRuta.Rows.Add(dt.Rows(0).Item("C5_CALMA").ToString, dt.Rows(0).Item("C5_CTD").ToString, dt.Rows(0).Item("C5_CNUMDOC").ToString,
                                     dt.Rows(0).Item("C5_CNOMCLI").ToString, dt.Rows(0).Item("DE_CDEPT").ToString, dt.Rows(0).Item("DE_CPROV").ToString,
                                     dt.Rows(0).Item("TG_CDESCRI").ToString, dt.Rows(0).Item("C5_CDIRENV").ToString, dt.Rows(0).Item("EST_CODIGO2").ToString, "0.00", "0")

                Else
                    MessageBox.Show("La GUIA ya se encuentra cargada en esta ruta !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                End If

            End If


            tslCantTotal.Text = dgvGuiaRuta.Rows.Count

        Catch ex As Exception

        End Try
    End Sub


    Public Sub Cargar_Detalle_Ruta(ByVal crg_id As String)
        Try
            If dgvGuiaRuta.Rows.Count > 0 Then
                dgvGuiaRuta.Rows.Clear()
            End If
            Dim objRuta As New BeCabGuiaRuta
            Dim dt As New DataTable

            dt = objRuta.Obtener_Detalle_Ruta(crg_id)

            'Dim indice As Integer = 0
            'indice = dgvGuiaRuta.Rows.Count - 1

            If dt.Rows.Count = 0 Then
                MessageBox.Show("No existe detalle para esta Ruta !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            Else

                For i As Integer = 0 To dt.Rows.Count - 1

                    dgvGuiaRuta.Rows.Add(dt.Rows(i).Item("C5_CALMA").ToString, dt.Rows(i).Item("C5_CTD").ToString, dt.Rows(i).Item("C5_CNUMDOC").ToString,
                                                      dt.Rows(i).Item("C5_CNOMCLI").ToString, dt.Rows(i).Item("DE_CDEPT").ToString, dt.Rows(i).Item("DE_CPROV").ToString,
                                                      dt.Rows(i).Item("TG_CDESCRI").ToString, dt.Rows(i).Item("C5_CDIRENV").ToString, dt.Rows(i).Item("EST_CODIGO2").ToString,
                                                      dt.Rows(i).Item("drg_peso").ToString, dt.Rows(i).Item("drg_bulto").ToString)

                Next

            End If


        Catch ex As Exception

        End Try
    End Sub


    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim _BeDetGuiaRutaDetalle As BeDetGuiaRutaDetalle
            Dim _BeCabGuiaRuta As New BeCabGuiaRuta

            Dim _listadoDetalleGuia As New List(Of BeDetGuiaRutaDetalle)
            Dim xml As String


            If cbxTransportista.SelectedIndex = 0 Then
                MessageBox.Show("Seleccione el Transportista", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                If dgvGuiaRuta.Rows.Count = 0 Then
                    MessageBox.Show("No existe ninguna guía cargada en la ruta !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else

                    If flagAccion = "Actualizar" Then
                        _BeCabGuiaRuta.pr_crg_id = lblNroRuta.Text

                    End If


                    _BeCabGuiaRuta.pr_trd_ccodigo = cbxTransportista.SelectedValue
                    _BeCabGuiaRuta.pr_crg_fechaRuta = dtpFecRuta.Value.ToShortDateString
                    _BeCabGuiaRuta.pr_usr_id = usr_id


                    For i As Integer = 0 To dgvGuiaRuta.Rows.Count - 1

                        _BeDetGuiaRutaDetalle = New BeDetGuiaRutaDetalle

                        _BeDetGuiaRutaDetalle.pr_c5_calma = dgvGuiaRuta.Rows(i).Cells.Item("C5_CALMA").Value
                        _BeDetGuiaRutaDetalle.pr_c5_ctd = dgvGuiaRuta.Rows(i).Cells.Item("C5_CTD").Value
                        _BeDetGuiaRutaDetalle.pr_c5_numdoc = dgvGuiaRuta.Rows(i).Cells.Item("C5_CNUMDOC").Value
                        _BeDetGuiaRutaDetalle.pr_usr_idSalidaRuta = usr_id

                        _BeDetGuiaRutaDetalle.pr_drg_peso = dgvGuiaRuta.Rows(i).Cells.Item("peso").Value
                        _BeDetGuiaRutaDetalle.pr_drg_bulto = dgvGuiaRuta.Rows(i).Cells.Item("bulto").Value
                        _listadoDetalleGuia.Add(_BeDetGuiaRutaDetalle)

                    Next


                    _BeCabGuiaRuta.prListaItem = _listadoDetalleGuia
                    xml = (_BeCabGuiaRuta.Serializar_RutaGuias(_BeCabGuiaRuta))


                    Dim _tipoespuesta As String = String.Empty
                    Dim _textorespuesta As String = String.Empty
                    Dim idRuta As String = String.Empty
                    Dim fecHorReg As String = String.Empty
                    Dim fecMod As String = String.Empty

                    Dim obj As New BeCabGuiaRuta

                    If flagAccion = "Nuevo" Then
                        obj.RegistrarRuta_Guias(xml, _tipoespuesta, _textorespuesta, idRuta, fecHorReg)

                    Else
                        If flagAccion = "Actualizar" Then
                            obj.ActualizarRuta_Guias(xml, _tipoespuesta, _textorespuesta, idRuta, fecHorReg)

                        End If
                    End If

                    'xml = (_BeProyCab.Registrar_Orden(_BeProyCab))

                    If _tipoespuesta = "1" Then

                        If flagAccion = "Nuevo" Then
                            lblNroRuta.Text = idRuta
                            MessageBox.Show("Se Registro la Ruta satisfactoriamente !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Me.Close()

                        End If

                        If flagAccion = "Actualizar" Then
                            MessageBox.Show("Se actualizó la Ruta satisfactoriamente !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Me.Close()
                        End If

                    Else
                        If _tipoespuesta = "0" Then
                            MessageBox.Show("Error en Registro de la Ruta ! " + _textorespuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        End If

                    End If
                End If
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Try

            If dgvGuiaRuta.Rows.Count > 0 Then
                If MessageBox.Show("Esta Usted seguro que desea salir ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Me.Close()
                End If
            Else
                Me.Close()
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim FrameAddGuia As New AgregarGuiaCabeceraRuta
            FrameAddGuia.crg_id = CType(lblNroRuta.Text, Integer)
            FrameAddGuia.user_id = CType(usr_id, Integer)
            FrameAddGuia.ShowDialog()
            If FrameAddGuia.grabado = True Then
                Cargar_Detalle_Ruta(crg_id)
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class