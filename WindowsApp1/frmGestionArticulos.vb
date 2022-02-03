
Imports Nordic.Bl.Be

Public Class frmGestionArticulos

    Public flag As String
    Public usr_id As String
    Public usr_usuario As String
    Public ar_id As Integer



    Private Sub frmGestionArticulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Cargar_Listados()

            If flag = "Nuevo" Then
                Limpiar()
                Habilitar()
                txtUsuario.Text = usr_usuario
            End If

            If flag = "Editar" Then
                Mostrar_Articulo()
            End If


        Catch ex As Exception

        End Try
    End Sub

    Sub Mostrar_Articulo()
        Try
            Dim obj As New BeArticulos
            Dim dt As DataTable

            dt = obj.Obtener_ListadoArticulos(3, "", ar_id)

            txtCodigo.Text = dt.Rows(0).Item(1).ToString
            txtDes.Text = dt.Rows(0).Item(2).ToString
            txtDes2.Text = dt.Rows(0).Item(3).ToString

            cboUnidad.SelectedValue = dt.Rows(0).Item(4).ToString
            cboPresentacion.SelectedValue = dt.Rows(0).Item(5).ToString
            cboVidaUtil.SelectedValue = dt.Rows(0).Item(6).ToString
            cboPaisOrigen.SelectedValue = dt.Rows(0).Item(7).ToString
            cboFabricante.SelectedValue = dt.Rows(0).Item(8).ToString
            cboEstado.SelectedValue = dt.Rows(0).Item(9).ToString

            txtUsuario.Text = dt.Rows(0).Item(10).ToString
            txtFechaCreacion.Text = dt.Rows(0).Item(11).ToString

        Catch ex As Exception

        End Try

    End Sub


    Sub Habilitar()
        Try
            txtCodigo.Enabled = True
            txtDes.Enabled = True
            txtDes2.Enabled = True
            cboUnidad.Enabled = True
            cboPresentacion.Enabled = True
            cboPaisOrigen.Enabled = True
            cboVidaUtil.Enabled = True
            cboFabricante.Enabled = True

            btnGuadar.Enabled = True
            btnSalir.Enabled = True

        Catch ex As Exception

        End Try
    End Sub

    Sub Deshabilitar()
        Try
            txtCodigo.Enabled = False
            txtDes.Enabled = False
            txtDes2.Enabled = False
            cboUnidad.Enabled = False
            cboPresentacion.Enabled = False
            cboPaisOrigen.Enabled = False
            cboVidaUtil.Enabled = False
            cboFabricante.Enabled = False

            btnGuadar.Enabled = False

        Catch ex As Exception

        End Try
    End Sub

    Sub Limpiar()
        Try

            txtCodigo.Text = ""
            txtDes.Text = ""
            txtDes2.Text = ""
            cboUnidad.SelectedIndex = 0
            cboPresentacion.SelectedIndex = 0
            cboPaisOrigen.SelectedIndex = 0
            cboVidaUtil.SelectedIndex = 0
            cboFabricante.SelectedIndex = 0

        Catch ex As Exception

        End Try
    End Sub


    Public Sub Cargar_Listados()
        Try
            ListarUnidades()
            ListarPresentaciones()
            ListarVidaUtil()
            ListarPaisOrigen()
            ListarFabricante()
            ListarEstados()

        Catch ex As Exception

        End Try
    End Sub



    Sub ListarUnidades()
        Try
            Dim objArt As New BeArticulos
            Dim dt As New DataTable

            dt = objArt.Obtener_Unidades()

            cboUnidad.DataSource = dt
            cboUnidad.ValueMember = "und_codigo"
            cboUnidad.DisplayMember = "und_des"

        Catch ex As Exception
            MessageBox.Show(ex.Message, "NORDIC", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Sub ListarPresentaciones()
        Try
            Dim objArt As New BeArticulos
            Dim dt As New DataTable

            dt = objArt.Obtener_Presentaciones()

            cboPresentacion.DataSource = dt
            cboPresentacion.ValueMember = "pre_id"
            cboPresentacion.DisplayMember = "pre_desc"

        Catch ex As Exception
            MessageBox.Show(ex.Message, "NORDIC", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub ListarVidaUtil()
        Try
            Dim objArt As New BeArticulos
            Dim dt As New DataTable

            dt = objArt.Obtener_VidaUtil()

            cboVidaUtil.DataSource = dt
            cboVidaUtil.ValueMember = "vdu_id"
            cboVidaUtil.DisplayMember = "vdu_des"

        Catch ex As Exception
            MessageBox.Show(ex.Message, "NORDIC", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub ListarPaisOrigen()
        Try
            Dim objArt As New BeArticulos
            Dim dt As New DataTable

            dt = objArt.Obtener_PaisOrigen()

            cboPaisOrigen.DataSource = dt
            cboPaisOrigen.ValueMember = "pa_id"
            cboPaisOrigen.DisplayMember = "pa_des"

        Catch ex As Exception
            MessageBox.Show(ex.Message, "NORDIC", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub ListarFabricante()
        Try
            Dim objArt As New BeArticulos
            Dim dt As New DataTable

            dt = objArt.Obtener_Fabricantes()

            cboFabricante.DataSource = dt
            cboFabricante.ValueMember = "fab_id"
            cboFabricante.DisplayMember = "fab_des"

        Catch ex As Exception
            MessageBox.Show(ex.Message, "NORDIC", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub ListarEstados()
        Try
            Dim objArt As New BeArticulos
            Dim dt As New DataTable

            dt = objArt.Obtener_Estados()

            cboEstado.DataSource = dt
            cboEstado.ValueMember = "est_codigo"
            cboEstado.DisplayMember = "est_descripcion"

        Catch ex As Exception
            MessageBox.Show(ex.Message, "NORDIC", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Try
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnGuadar_Click(sender As Object, e As EventArgs) Handles btnGuadar.Click
        Try

            If txtCodigo.Text = "" Then
                MessageBox.Show("Ingrese el Codigo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtCodigo.Focus()
            Else
                If txtDes.Text = "" Then
                    MessageBox.Show("Ingrese la Descripcion", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtDes.Focus()
                Else
                    If txtDes2.Text = "" Then
                        MessageBox.Show("Ingrese la Descripcion 2", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtDes2.Focus()
                    Else
                        If cboUnidad.SelectedIndex = 0 Then
                            MessageBox.Show("Ingrese la unidad", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            cboUnidad.Focus()
                        Else
                            If cboPresentacion.SelectedIndex = 0 Then
                                MessageBox.Show("Seleccione la presentación", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                cboPresentacion.Focus()
                            Else
                                If cboVidaUtil.SelectedIndex = 0 Then
                                    MessageBox.Show("Seleccione la vida util", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    cboVidaUtil.Focus()
                                Else
                                    If cboPaisOrigen.SelectedIndex = 0 Then
                                        MessageBox.Show("Seleccione el Pais de Origen", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                        cboPaisOrigen.Focus()
                                    Else

                                        Dim obj As New BeArticulos
                                        Dim _tipoRespuesta As String = String.Empty
                                        Dim _textoRespuesta As String = String.Empty
                                        Dim _ar_id As String = String.Empty
                                        Dim _fechaReg As String = String.Empty

                                        obj.prAr_codigo = txtCodigo.Text
                                        obj.prAr_des = txtDes.Text
                                        obj.prAr_des2 = txtDes2.Text
                                        obj.prAr_unidad = cboUnidad.SelectedValue
                                        obj.prPre_id = cboPresentacion.SelectedValue
                                        obj.prVdu_id = cboVidaUtil.SelectedValue
                                        obj.prPa_id = cboPaisOrigen.SelectedValue
                                        obj.prFab_id = cboPaisOrigen.SelectedValue
                                        obj.prEst_codigo = cboEstado.SelectedValue
                                        obj.prUsr_id = usr_id

                                        obj.RegistrarArticulos(obj, _tipoRespuesta, _textoRespuesta, _ar_id, _fechaReg)

                                        If _tipoRespuesta = "1" Then

                                            MessageBox.Show("Registro Satisfactorio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                            Deshabilitar()

                                            txtFechaCreacion.Text = _fechaReg
                                        End If

                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If

        Catch ex As Exception

        End Try
    End Sub
End Class