Imports Nordic.Bl.Be


Public Class frmRequerimientoIns

    Public usr_id As Integer
    Public flagAccion As String = String.Empty
    Public usr_usuario As String = String.Empty
    Public Bandera_nuevo As Boolean = False


    Public nrosol_var As String = String.Empty
    Public ruc_var As String = String.Empty
    Public nomcli_var As String = String.Empty
    Public codCoti_var As String = String.Empty
    Public nomCoti_var As String = String.Empty
    Public codVend_var As String = String.Empty
    Public vendedor_var As String = String.Empty
    Public observacion_var As String = String.Empty

    Public idReq As String


    Private Sub frmRequerimientoIns_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            DeshabilitarOpciones()
            ListarEstados()
            Inicio()

            If Bandera_nuevo = True Then
                tsbNuevo_Click(sender, e)
                txtRuc.Text = ruc_var
                txtCliente.Text = nomcli_var
                txtCodCot.Text = codCoti_var
                txtCotizador.Text = nomCoti_var
                txtCodVend.Text = codVend_var
                txtVendedor.Text = vendedor_var
                txtSol.Text = nrosol_var
            End If

            If flagAccion = "Editar" Then

                Cargar_Requerimiento(idReq)
                Inicio2()
            End If

        Catch ex As Exception

        End Try
    End Sub

    Sub Cargar_Requerimiento(ByVal cre_id As String)
        Try
            Dim obj As New BeCabReque
            Dim obj2 As New DetReque
            Dim dt As DataTable


            dt = obj.Obtener_Cabecera_Requerimiento(cre_id)

            txtNroReq.Text = dt.Rows(0).Item(0).ToString
            txtSol.Text = dt.Rows(0).Item(1).ToString
            txtRuc.Text = dt.Rows(0).Item(2).ToString
            txtCliente.Text = dt.Rows(0).Item(3).ToString

            txtCodCot.Text = dt.Rows(0).Item(4).ToString
            txtCodVend.Text = dt.Rows(0).Item(5).ToString

            cboEstado.SelectedValue = dt.Rows(0).Item(6).ToString
            rtbDescripcion.Text = dt.Rows(0).Item(7).ToString

            For i As Integer = 0 To dt.Rows.Count - 1

                'dgvDetalleReque.Rows.Add(dt2.Rows(0).Item(0), dt2.Rows(0).Item(0),)
            Next

            obj2.prar_id = dt.Rows(0).Item(0).ToString

        Catch ex As Exception

        End Try
    End Sub


    Sub Inicio()
        tsbNuevo.Enabled = True
        tsbGuardar.Enabled = False
        tsbEditar.Enabled = False
        tsbEliminar.Enabled = False
        tsbDetener.Enabled = False
    End Sub

    Sub Inicio2()
        tsbNuevo.Enabled = True
        tsbGuardar.Enabled = False
        tsbEditar.Enabled = True
        tsbEliminar.Enabled = False
        tsbDetener.Enabled = False
    End Sub

    Sub ListarEstados()
        Try
            Dim objArt As New BeCabReque
            Dim dt As New DataTable

            dt = objArt.Obtener_Estados()

            cboEstado.DataSource = dt
            cboEstado.ValueMember = "est_codigo"
            cboEstado.DisplayMember = "est_descripcion"

        Catch ex As Exception
            MessageBox.Show(ex.Message, "NORDIC", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub BuscarListadoAritculos(ByVal flag As String, ByVal numero As String)
        Try

            Dim obj As New BeArticulos
            Dim dt As New DataTable

            dt = obj.Obtener_ListadoArticulos_XRequerimiento(flag, numero)

            dgvListadoArticulos.DataSource = dt

            dgvListadoArticulos.Columns(0).Visible = False
            dgvListadoArticulos.Columns(1).Width = 70
            dgvListadoArticulos.Columns(2).Width = 150



        Catch ex As Exception

        End Try
    End Sub


    Sub DeshabilitarOpciones()
        Try

            txtNroReq.Enabled = False
            txtRuc.Enabled = False
            txtCliente.Enabled = False
            btnCliente.Enabled = False
            txtCodCot.Enabled = False
            txtCotizador.Enabled = False
            txtCodVend.Enabled = False
            txtVendedor.Enabled = False
            rbtNombre.Enabled = False
            rbtCodigo.Enabled = False
            txtBusqueda.Enabled = False
            cboEstado.Enabled = False
            rtbDescripcion.Enabled = False


        Catch ex As Exception

        End Try
    End Sub



    Sub HabilitarOpciones()
        Try

            txtNroReq.Enabled = True
            txtRuc.Enabled = True
            txtCliente.Enabled = True
            btnCliente.Enabled = True
            txtCodCot.Enabled = True
            txtCotizador.Enabled = True
            txtCodVend.Enabled = True
            txtVendedor.Enabled = True
            rbtNombre.Enabled = True
            rbtCodigo.Enabled = True
            txtBusqueda.Enabled = True
            cboEstado.Enabled = True
            rtbDescripcion.Enabled = True
        Catch ex As Exception

        End Try
    End Sub


    Sub Limpiar()
        txtNroReq.Text = ""
        txtRuc.Text = ""
        txtCliente.Text = ""
        txtCodCot.Text = ""
        txtCotizador.Text = ""
        txtCodVend.Text = ""
        txtVendedor.Text = ""
        rtbDescripcion.Text = ""
        dgvDetalleReque.Rows.Clear()

    End Sub

    Private Sub tsbNuevo_Click(sender As Object, e As EventArgs) Handles tsbNuevo.Click
        Try
            flagAccion = "Nuevo"

            tsbNuevo.Enabled = False
            tsbGuardar.Enabled = True
            tsbEditar.Enabled = False
            tsbEliminar.Enabled = False
            tsbDetener.Enabled = True

            Limpiar()
            HabilitarOpciones()

            BuscarListadoAritculos(0, "")
            cboEstado.SelectedIndex = 2
            txtUsuario.Text = usr_usuario


        Catch ex As Exception

        End Try
    End Sub

    Private Sub rbtNombre_CheckedChanged(sender As Object, e As EventArgs) Handles rbtNombre.CheckedChanged
        Try
            If rbtNombre.Checked = True Then
                rbtCodigo.Checked = False
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub rbtCodigo_CheckedChanged(sender As Object, e As EventArgs) Handles rbtCodigo.CheckedChanged
        Try
            If rbtCodigo.Checked = True Then
                rbtNombre.Checked = False

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCliente_Click(sender As Object, e As EventArgs) Handles btnCliente.Click
        Try
            Dim obj As New frmClientes

            obj.ShowDialog()

            txtRuc.Text = obj.ruc
            txtCliente.Text = obj.cliente
            txtCodCot.Text = obj.codCot
            txtCotizador.Text = obj.Cotizador
            txtCodVend.Text = obj.codvend
            txtVendedor.Text = obj.vendedor

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtBusqueda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBusqueda.KeyPress
        Try
            If e.KeyChar = Convert.ToChar(Keys.Enter) Then

                If rbtCodigo.Checked = True Then
                    BuscarListadoAritculos("2", txtBusqueda.Text.Trim)
                End If

                If rbtNombre.Checked = True Then
                    BuscarListadoAritculos("1", txtBusqueda.Text.Trim)
                End If

            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvListadoArticulos_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvListadoArticulos.CellMouseDoubleClick
        Try

            Dim id As String = String.Empty
            Dim codigo As String = String.Empty
            Dim descripcion As String = String.Empty
            Dim bandera As Boolean = False


            id = dgvListadoArticulos.CurrentRow.Cells.Item(0).Value
            codigo = dgvListadoArticulos.CurrentRow.Cells.Item(1).Value
            descripcion = dgvListadoArticulos.CurrentRow.Cells.Item(2).Value


            For i As Integer = 0 To dgvDetalleReque.Rows.Count - 1

                If dgvDetalleReque.Rows(i).Cells.Item(0).Value = id Then
                    MessageBox.Show("Ya existe el articulo seleccionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    bandera = True
                    Exit For
                End If
            Next

            If bandera = False Then
                dgvDetalleReque.Rows.Add(id, codigo, descripcion)
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub tsbGuardar_Click(sender As Object, e As EventArgs) Handles tsbGuardar.Click
        Try

            Dim _BeCabReque As New BeCabReque
            Dim _BeDetReque As DetReque


            Dim _listadoDetalleGuia As New List(Of DetReque)
            Dim xml As String

            Dim _tipoespuesta As String = String.Empty
            Dim _textorespuesta As String = String.Empty
            Dim idRuta As String = String.Empty
            Dim fecHorReg As String = String.Empty
            Dim fecMod As String = String.Empty


            If txtRuc.Text = "" Then
                MessageBox.Show("Ingrese el nombre del cliente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtRuc.Focus()

            Else
                If dgvDetalleReque.Rows.Count = 0 Then
                    MessageBox.Show("Ingrese el detalle de articulos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else

                    _BeCabReque.pr_cre_id = txtNroReq.Text.Trim
                    _BeCabReque.pr_sol_id = txtSol.Text.Trim
                    _BeCabReque.pr_codcli = txtRuc.Text.Trim
                    _BeCabReque.pr_nomcli = txtCliente.Text.Trim
                    _BeCabReque.pr_cvende = txtCodVend.Text.Trim
                    _BeCabReque.pr_cvende2 = txtCodCot.Text.Trim
                    _BeCabReque.pr_est_codigo = cboEstado.SelectedValue
                    _BeCabReque.pr_creobs = rtbDescripcion.Text.Trim
                    _BeCabReque.pr_usr_id = usr_id

                    For i As Integer = 0 To dgvDetalleReque.Rows.Count - 1

                        _BeDetReque = New DetReque

                        _BeDetReque.prar_id = dgvDetalleReque.Rows(i).Cells.Item("id").Value
                        _BeDetReque.prcrd_cant = dgvDetalleReque.Rows(i).Cells.Item("cantidad").Value
                        _BeDetReque.prcrd_cost = dgvDetalleReque.Rows(i).Cells.Item("costo").Value
                        _BeDetReque.prusr_id = usr_id

                        _listadoDetalleGuia.Add(_BeDetReque)

                    Next

                    _BeCabReque.prListaItem = _listadoDetalleGuia
                    xml = _BeCabReque.Serializar_Requerimiento(_BeCabReque)


                    Dim obj As New BeCabReque

                    If flagAccion = "Nuevo" Then
                        obj.RegistrarRequerimiento(xml, _tipoespuesta, _textorespuesta, idRuta, fecHorReg)

                    Else
                        If flagAccion = "Actualizar" Then
                            obj.ActualizarRequerimiento(xml, _tipoespuesta, _textorespuesta, idRuta, fecHorReg)

                        End If
                    End If
                End If
            End If



            If _tipoespuesta = "1" Then


                If flagAccion = "Nuevo" Then
                    txtNroReq.Text = idRuta
                    MessageBox.Show("Se Registro el Requerimiento satisfactoriamente !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()

                End If

                If flagAccion = "Actualizar" Then
                    MessageBox.Show("Se actualizó el Requerimiento satisfactoriamente !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If

                DeshabilitarOpciones()
                Inicio2()

            End If



        Catch ex As Exception

        End Try
    End Sub

    Private Sub tsbDetener_Click(sender As Object, e As EventArgs) Handles tsbDetener.Click
        Try
            DeshabilitarOpciones()

            Inicio()
        Catch ex As Exception

        End Try
    End Sub



    Private Sub txtCodCot_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodCot.KeyPress
        Try
            Dim obj As New frmVendedores

            If e.KeyChar = Convert.ToChar(Keys.Escape) Then
                obj.ShowDialog()

                txtCodCot.Text = obj.codven_var1
                txtCotizador.Text = obj.vended_var1


            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtCodVend_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodVend.KeyPress
        Try
            Dim obj As New frmVendedores

            If e.KeyChar = Convert.ToChar(Keys.Escape) Then
                obj.ShowDialog()

                txtCodVend.Text = obj.codven_var1
                txtVendedor.Text = obj.vended_var1


            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub rtbDescripcion_TextChanged(sender As Object, e As EventArgs) Handles rtbDescripcion.TextChanged
        Try
            Dim cantidad As Integer = rtbDescripcion.Text.Length
            If cantidad > 250 Then
                'lblCantAnalisisVenta.Text = cantidad
                'lblCantAnalisisVenta.ForeColor = Color.Red
                'Label45.ForeColor = Color.Red
            ElseIf cantidad >= 0 Then
                lblCantAnalisisVenta.Text = cantidad
                lblCantAnalisisVenta.ForeColor = Color.Green
                Label45.ForeColor = Color.Green
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class