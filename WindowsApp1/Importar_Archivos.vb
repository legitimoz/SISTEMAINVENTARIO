
Imports Nordic.Bl.Be


Public Class Importar_Archivos

    Public usr_id As String


    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Try

            If cboTipoArchivo.SelectedIndex = 0 Then
                MessageBox.Show("Debe seleccionar el tipo de Archivo que desea cargar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cboTipoArchivo.Focus()
            Else

                Me.Cursor = Cursors.WaitCursor

                ImportarExcel(DataGridView1)

                tslCantidad.Text = CStr(DataGridView1.Rows.Count)

                Me.Cursor = Cursors.Default

            End If


        Catch ex As Exception

        End Try

    End Sub

    Private Sub tsbGuardar_Click(sender As Object, e As EventArgs) Handles tsbGuardar.Click
        Try
            Dim _clsImportDetalle As New clsImportDetalle
            Dim _clsCabImportar As New clsCabImportar
            Dim _listadoDetalleGuia As New List(Of clsImportDetalle)

            Dim _clsImportDetalleTargetMedico As New clsImportarDetalleTargeMedico
            Dim _clsCabImportarTargetMedico As New clsCabImportarTargetMedico
            Dim _listadoDetalleGuia2 As New List(Of clsImportarDetalleTargeMedico)

            Dim xml As String


            If DataGridView1.Rows.Count = 0 Then

                MessageBox.Show("No existen registros para cargar, importe el archivo excel.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                If MessageBox.Show("Esta Usted seguro que desea importar los datos al Sistema?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                    Dim _tipoespuesta As String = String.Empty
                    Dim _textorespuesta As String = String.Empty
                    Dim idRuta As String = String.Empty
                    Dim fecHorReg As String = String.Empty
                    Dim fecMod As String = String.Empty

                    Me.Cursor = Cursors.WaitCursor

                    If cboTipoArchivo.SelectedIndex = 2 Then

                        _clsCabImportar.pr_imp_id = 1

                        For i As Integer = 0 To DataGridView1.Rows.Count - 1

                            _clsImportDetalle = New clsImportDetalle

                            _clsImportDetalle.pr_codzona = DataGridView1.Rows(i).Cells.Item(0).Value
                            _clsImportDetalle.pr_codlinea = DataGridView1.Rows(i).Cells.Item(1).Value
                            _clsImportDetalle.pr_codrepre = DataGridView1.Rows(i).Cells.Item(2).Value
                            _clsImportDetalle.pr_ubigeo = DataGridView1.Rows(i).Cells.Item(3).Value
                            _clsImportDetalle.pr_tipo = DataGridView1.Rows(i).Cells.Item(4).Value
                            _clsImportDetalle.pr_depart = DataGridView1.Rows(i).Cells.Item(5).Value
                            _clsImportDetalle.pr_prov = DataGridView1.Rows(i).Cells.Item(6).Value
                            _clsImportDetalle.pr_dist = DataGridView1.Rows(i).Cells.Item(7).Value


                            _listadoDetalleGuia.Add(_clsImportDetalle)

                        Next


                        _clsCabImportar.prListaItem = _listadoDetalleGuia
                        xml = (_clsCabImportar.Serializar_Importar(_clsCabImportar))


                        Dim obj As New clsCabImportar

                        obj.RegistrarImportacion(xml, _tipoespuesta, _textorespuesta, idRuta, fecHorReg)

                    Else
                        If cboTipoArchivo.SelectedIndex = 1 Then

                            _clsCabImportarTargetMedico.pr_imp_id = "1"

                            For i As Integer = 0 To DataGridView1.Rows.Count - 1

                                _clsImportDetalleTargetMedico = New clsImportarDetalleTargeMedico

                                _clsImportDetalleTargetMedico.pr_dsRepresentante = DataGridView1.Rows(i).Cells.Item(0).Value.ToString.Trim
                                _clsImportDetalleTargetMedico.pr_codrepre = DataGridView1.Rows(i).Cells.Item(1).Value.ToString.Trim
                                _clsImportDetalleTargetMedico.pr_dsRol = DataGridView1.Rows(i).Cells.Item(2).Value.ToString.Trim
                                _clsImportDetalleTargetMedico.pr_dsLinea = DataGridView1.Rows(i).Cells.Item(3).Value.ToString.Trim
                                _clsImportDetalleTargetMedico.pr_idLinea = DataGridView1.Rows(i).Cells.Item(4).Value.ToString.Trim
                                _clsImportDetalleTargetMedico.pr_dsZona = DataGridView1.Rows(i).Cells.Item(5).Value.ToString.Trim
                                _clsImportDetalleTargetMedico.pr_idZona = DataGridView1.Rows(i).Cells.Item(6).Value.ToString.Trim
                                _clsImportDetalleTargetMedico.pr_CentroMedico = DataGridView1.Rows(i).Cells.Item(7).Value.ToString.Trim
                                _clsImportDetalleTargetMedico.pr_direccion = DataGridView1.Rows(i).Cells.Item(8).Value.ToString.Trim
                                _clsImportDetalleTargetMedico.pr_departamento = DataGridView1.Rows(i).Cells.Item(9).Value.ToString.Trim
                                _clsImportDetalleTargetMedico.pr_provincia = DataGridView1.Rows(i).Cells.Item(10).Value.ToString.Trim
                                _clsImportDetalleTargetMedico.pr_distrito = DataGridView1.Rows(i).Cells.Item(11).Value.ToString.Trim
                                _clsImportDetalleTargetMedico.pr_ubigeo = DataGridView1.Rows(i).Cells.Item(12).Value.ToString.Trim
                                _clsImportDetalleTargetMedico.pr_cmp = DataGridView1.Rows(i).Cells.Item(13).Value.ToString.Trim
                                _clsImportDetalleTargetMedico.pr_idEsp = DataGridView1.Rows(i).Cells.Item(14).Value.ToString.Trim
                                _clsImportDetalleTargetMedico.pr_Esp1 = DataGridView1.Rows(i).Cells.Item(15).Value.ToString.Trim
                                _clsImportDetalleTargetMedico.pr_dsMedico = DataGridView1.Rows(i).Cells.Item(16).Value.ToString.Trim
                                _clsImportDetalleTargetMedico.pr_frecuencia = DataGridView1.Rows(i).Cells.Item(17).Value.ToString.Trim
                                _clsImportDetalleTargetMedico.pr_estado = DataGridView1.Rows(i).Cells.Item(18).Value.ToString.Trim


                                _listadoDetalleGuia2.Add(_clsImportDetalleTargetMedico)

                            Next

                            _clsCabImportarTargetMedico.prListaItem = _listadoDetalleGuia2
                            xml = (_clsCabImportarTargetMedico.Serializar_Importar(_clsCabImportarTargetMedico))

                            Dim obj As New clsCabImportarTargetMedico

                            obj.RegistrarImportacion_TargetMedico(xml, usr_id, _tipoespuesta, _textorespuesta, idRuta, fecHorReg)

                        End If
                    End If



                    If _tipoespuesta = "1" Then

                        MessageBox.Show("Carga de Datos Satisfactoria !!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        DataGridView1.DataSource = Nothing
                        tslCantidad.Text = "0"
                    Else

                        MessageBox.Show("Error en la Carga de Datos: " + _textorespuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    End If

                    Me.Cursor = Cursors.Default

                End If

            End If


        Catch ex As Exception
            MsgBox("Error en la carga de datos: " + ex.Message, MsgBoxStyle.Information, "Aviso")

        Finally


        End Try
    End Sub

    Private Sub Importar_Archivos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cboTipoArchivo.SelectedIndex = 0

        Catch ex As Exception

        End Try
    End Sub
End Class