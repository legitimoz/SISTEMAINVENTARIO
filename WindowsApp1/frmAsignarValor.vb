
Imports Nordic.Bl.Be

Public Class frmAsignarValor

    Public usr_id As String
    Public codigo As String
    Public articulo As String
    Public dtIds As DataTable

    Private Sub frmAsignarValor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txtCodigo.Text = codigo
            txtArticulo.Text = articulo
            Cargar_Listados()

        Catch ex As Exception

        End Try
    End Sub

    Public Sub Cargar_Listados()
        Try
            ListarPresentaciones()
            ListarProcedencia()
            ListarMarcas()
            ListarFabricante()
            ListarTitularesRegistro()

        Catch ex As Exception

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

    Sub ListarProcedencia()
        Try
            Dim objArt As New BeArticulos
            Dim dt As New DataTable

            dt = objArt.Obtener_PaisOrigen()

            cboProcedencia.DataSource = dt
            cboProcedencia.ValueMember = "pa_id"
            cboProcedencia.DisplayMember = "pa_des"

        Catch ex As Exception
            MessageBox.Show(ex.Message, "NORDIC", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub ListarMarcas()
        Try
            Dim objArt As New BeArticulos
            Dim dt As New DataTable

            dt = objArt.Obtener_Marcas()

            cboMarca.DataSource = dt
            cboMarca.ValueMember = "mar_id"
            cboMarca.DisplayMember = "mar_descripcion"

        Catch ex As Exception
            MessageBox.Show(ex.Message, "NORDIC", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub ListarTitularesRegistro()
        Try
            Dim objArt As New BeArticulos
            Dim dt As New DataTable

            dt = objArt.Obtener_Titulares()

            cboTitularRegistro.DataSource = dt
            cboTitularRegistro.ValueMember = "tit_id"
            cboTitularRegistro.DisplayMember = "tit_descripcion"

        Catch ex As Exception
            MessageBox.Show(ex.Message, "NORDIC", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Try
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try

            Dim _BeCabReque As New BeCabReque
            Dim _BeDetReque As DetReque

            Dim _listadoDetalleGuia As New List(Of DetReque)
            Dim xml As String

            Dim _tipoespuesta As String = String.Empty
            Dim _textorespuesta As String = String.Empty
            Dim dia As String
            Dim mes As String
            Dim anio As String
            Dim fechaVcto As String

            _BeCabReque.pr_usr_id = usr_id

            For i As Integer = 0 To dtIds.Rows.Count - 1

                _BeDetReque = New DetReque

                _BeDetReque.prcrd_id = dtIds.Rows(i).Item(0)
                _BeDetReque.prpre_id = cboPresentacion.SelectedValue
                _BeDetReque.prmar_id = cboMarca.SelectedValue
                _BeDetReque.prpa_id = cboProcedencia.SelectedValue
                _BeDetReque.prfab_id = cboFabricante.SelectedValue
                _BeDetReque.prtit_id = cboTitularRegistro.SelectedValue
                _BeDetReque.prcrd_cost = txtCosto.Text

                dia = mtbFechaVcto.Text.Substring(0, 2)
                mes = mtbFechaVcto.Text.Substring(3, 2)
                anio = mtbFechaVcto.Text.Substring(6, 4)

                fechaVcto = anio + "-" + mes + "-" + dia

                _BeDetReque.prcrd_fecVenc = fechaVcto
                _BeDetReque.prcrd_Obs = rtbObservacion.Text
                _listadoDetalleGuia.Add(_BeDetReque)

            Next

            _BeCabReque.prListaItem = _listadoDetalleGuia
            xml = _BeCabReque.Serializar_Requerimiento(_BeCabReque)

            Dim obj As New BeCabReque

            obj.ActualizacionMasivaValorizada(xml, _tipoespuesta, _textorespuesta)

            If _tipoespuesta = "1" Then
                MessageBox.Show("Actualización Masiva Exitosa !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                If _tipoespuesta = "0" Then
                    MessageBox.Show("Error en la Actualización Masiva !" + _textorespuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If

        Catch ex As Exception

        End Try
    End Sub
End Class