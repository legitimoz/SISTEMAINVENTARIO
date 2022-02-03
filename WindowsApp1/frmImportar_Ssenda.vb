Imports Nordic.Bl.Be

Public Class frmImportar_Ssenda

    Public usr_id As String = String.Empty

    Private Sub tsbAbrir_Click(sender As Object, e As EventArgs) Handles tsbAbrir.Click
        Try

            'If cboTipoArchivo.SelectedIndex = 0 Then
            '    MessageBox.Show("Debe seleccionar el tipo de Archivo que desea cargar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    cboTipoArchivo.Focus()
            'Else

            Me.Cursor = Cursors.WaitCursor

            ImportarExcel(dgvImportarSsenda)

            tslCantidad.Text = CStr(dgvImportarSsenda.Rows.Count)

            Me.Cursor = Cursors.Default

            ' End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmImportar_Ssenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cboTipoArchivo.SelectedIndex = 0

        Catch ex As Exception

        End Try
    End Sub


    Private Sub tsbGuardar_Click(sender As Object, e As EventArgs) Handles tsbGuardar.Click
        Try
            Dim _clsImportDetalle As New BeImportarDetalleVehiculo
            Dim _clsCabImportar As New BeCabImpVehiculo
            Dim _listadoDetalleGuia As New List(Of BeImportarDetalleVehiculo)

            Dim xml As String = String.Empty


            If dgvImportarSsenda.Rows.Count = 0 Then
                MessageBox.Show("No existen registros para cargar, importe el archivo excel.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                If MessageBox.Show("Esta Usted seguro que desea importar los datos al Sistema?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                    Dim _tipoespuesta As String = String.Empty
                    Dim _textorespuesta As String = String.Empty
                    Dim idRuta As String = String.Empty
                    Dim fecHorReg As String = String.Empty
                    Dim fecMod As String = String.Empty

                    Dim fecha As String = String.Empty
                    Dim dua As String = String.Empty

                    Me.Cursor = Cursors.WaitCursor

                    If cboTipoArchivo.SelectedIndex = 0 Then

                        _clsCabImportar.pr_imp_id = 1

                        For i As Integer = 0 To dgvImportarSsenda.Rows.Count - 1

                            dua = dgvImportarSsenda.Rows(i).Cells.Item(0).Value.ToString.Trim

                            If dua <> "" Then
                                _clsImportDetalle = New BeImportarDetalleVehiculo

                                _clsImportDetalle.pr_vedua = dgvImportarSsenda.Rows(i).Cells.Item(0).Value.ToString.Trim

                                fecha = dgvImportarSsenda.Rows(i).Cells.Item(1).Value.ToString.Trim

                                _clsImportDetalle.pr_ve_fecha_dua = Convertir_fecha(fecha)

                                _clsImportDetalle.pr_ve_modelo = dgvImportarSsenda.Rows(i).Cells.Item(2).Value.ToString.Trim
                                _clsImportDetalle.pr_ve_cchasis = dgvImportarSsenda.Rows(i).Cells.Item(3).Value.ToString.Trim
                                _clsImportDetalle.pr_ve_ccodvin = dgvImportarSsenda.Rows(i).Cells.Item(4).Value.ToString.Trim
                                _clsImportDetalle.pr_ve_invoice = dgvImportarSsenda.Rows(i).Cells.Item(5).Value.ToString.Trim

                                _listadoDetalleGuia.Add(_clsImportDetalle)

                            End If

                        Next


                        _clsCabImportar.prListaItem = _listadoDetalleGuia
                        xml = (_clsCabImportar.Serializar_Importar(_clsCabImportar))

                        Dim obj As New BeCabImpVehiculo

                        obj.RegistrarImportacion(xml, _tipoespuesta, _textorespuesta, idRuta, fecHorReg, usr_id)

                    End If



                    If _tipoespuesta = "1" Then

                        MessageBox.Show("Carga de Datos Satisfactoria !!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        dgvImportarSsenda.DataSource = Nothing
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

    Function Convertir_fecha(ByVal fecha As String) As String

        Dim anio As String
        Dim mes As String
        Dim dia As String
        Dim var_fecha As String

        anio = fecha.Substring(6, 4)
        mes = fecha.Substring(3, 2)
        dia = fecha.Substring(0, 2)

        var_fecha = anio + "-" + mes + "-" + dia

        Return var_fecha

    End Function


End Class