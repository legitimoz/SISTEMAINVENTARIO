Imports Nordic.Bl.Be


Public Class frmRetornoRuta

    Public nroRuta As String
    Public transportista As String
    Public fechaRuta As String
    Public usr_id As String


    Private Sub frmRetornoRuta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            If nroRuta <> "SINRUTA" Then

                lblRuta.Text = nroRuta
                lblTrans.Text = transportista
                lblFechaRuta.Text = fechaRuta.Substring(0, 10)
                rbtEntregado.Checked = True
                Cargar_GuiasMotivadas()

            Else
                If nroRuta = "SINRUTA" Then

                    lblRuta.Text = "0"
                    lblTrans.Text = "PROVEEDORES DE TRANSPORTE"
                    lblFechaRuta.Text = ""
                    rbtEntregado.Checked = True
                    Cargar_GuiasMotivadas()

                End If
            End If


        Catch ex As Exception

        End Try
    End Sub


    Sub Cargar_GuiasMotivadas()
        Try

            Dim objGuia As New BeGuias
            Dim dt As New DataTable
            dt = objGuia.Listar_GuiasMotivadas(nroRuta)

            For i As Integer = 0 To dt.Rows.Count - 1

                dgvRetornoRuta.Rows.Add(dt.Rows(i).Item("GUIA").ToString, dt.Rows(i).Item("CLIENTE").ToString,
                               dt.Rows(i).Item("DE_CDEPT").ToString, dt.Rows(i).Item("DE_CPROV").ToString,
                               dt.Rows(i).Item("TG_CDESCRI").ToString, dt.Rows(i).Item("C5_CDIRENV").ToString, "", dt.Rows(i).Item("ESTADO_GUIA").ToString,
                               dt.Rows(i).Item("MOTIVO").ToString, dt.Rows(i).Item("ESTADO_DESPACHO").ToString, dt.Rows(i).Item("FECHA_SALIDARUTA").ToString,
                               dt.Rows(i).Item("USUARIO_SALIDARUTA").ToString, dt.Rows(i).Item("FECHA_RETORNORUTA").ToString,
                               dt.Rows(i).Item("USUARIO_RETORNORUTA").ToString,
                               dt.Rows(i).Item("FECHA_RECEPCION_CLIENTE").ToString, dt.Rows(i).Item("FECHA_INTER_FACTURA").ToString,
                               dt.Rows(i).Item("FECHA_VTO_OC").ToString, dt.Rows(i).Item("FECHA_REPROG").ToString)

            Next



            Pintar_GrillaSemaforo()


        Catch ex As Exception

        End Try
    End Sub


    Sub Cargar_Motivos(ByVal est_codigo As String)
        Try
            Dim objGuia As New BeGuias
            Dim dt As New DataTable

            dt = objGuia.Obtener_Motivos(est_codigo)

            cbxMotivos.DataSource = dt
            cbxMotivos.ValueMember = "mot_codigo"
            cbxMotivos.DisplayMember = "mot_descripcion"

        Catch ex As Exception
            MessageBox.Show(ex.Message, "NORDIC", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub rbtEntregado_CheckedChanged(sender As Object, e As EventArgs) Handles rbtEntregado.CheckedChanged
        Try

            If rbtEntregado.Checked = True Then
                rbtRechazado.Checked = False
                Cargar_Motivos("EN")
                cbxMotivos.SelectedIndex = 1

            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub rbtRechazado_CheckedChanged(sender As Object, e As EventArgs) Handles rbtRechazado.CheckedChanged
        Try
            If rbtRechazado.Checked = True Then
                rbtEntregado.Checked = False
                Cargar_Motivos("RE")

            End If

        Catch ex As Exception

        End Try
    End Sub


    Sub Motivar_RutaGuia(ByVal c5_cnumdoc As String, ByVal est_codigo2 As String, ByVal mot_codigo As String, ByVal usr_id As String, ByRef tipoRespuesta As String)
        Try

            Dim objBeCabGuia As New BeCabGuiaRuta
            Dim objBeGuia As New BeGuias
            Dim dt As New DataTable

            Dim _tipoespuesta As String = String.Empty
            Dim _textorespuesta As String = String.Empty
            Dim nroguia As String = String.Empty
            Dim fecHorReg As String = String.Empty
            Dim fecMod As String = String.Empty

            If nroRuta <> "SINRUTA" Then
                objBeCabGuia.Motivar_RutaGuia(c5_cnumdoc, est_codigo2, mot_codigo, nroRuta, usr_id, tipoRespuesta, _textorespuesta, nroguia, fecHorReg)
            End If

            If nroRuta = "SINRUTA" Then
                objBeCabGuia.Motivar_RutaGuia_Proveedor(c5_cnumdoc, est_codigo2, mot_codigo, usr_id, tipoRespuesta, _textorespuesta, nroguia, fecHorReg)
            End If


        Catch ex As Exception

        End Try
    End Sub


    Private Sub txtGuia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGuia.KeyPress
        Try
            If e.KeyChar = Convert.ToChar(Keys.Enter) Then

                Dim numeroRuta As String = String.Empty
                Dim numeroGuia As String = String.Empty
                Dim estado As String = String.Empty
                Dim mot_codigo As Integer = 0
                Dim dt1 As New DataTable
                Dim objGuias As New BeGuias


                If rbtEntregado.Checked = False And rbtRechazado.Checked = False Then
                    MessageBox.Show("Debe Seleccionar algun Estado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    If cbxMotivos.SelectedIndex = 0 Then
                        MessageBox.Show("Debe seleccionar un motivo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Else
                        If txtGuia.Text = "" Then
                            MessageBox.Show("Debe ingresar la Guía", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            txtGuia.Focus()
                        Else

                            numeroRuta = lblRuta.Text.Trim
                            numeroGuia = txtGuia.Text.Trim
                            mot_codigo = cbxMotivos.SelectedValue

                            dt1 = objGuias.ValidaExisteGuiaenRuta(numeroRuta, numeroGuia)

                            If (dt1.Rows.Count = 0 Or dt1 Is Nothing) And numeroRuta <> "0" Then
                                MessageBox.Show("La Guía no corresponde a esta ruta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Else

                                Dim tipoRespuesta As String = String.Empty
                                Dim dt As New DataTable

                                If rbtEntregado.Checked = True Then
                                    estado = "EN"
                                Else
                                    If rbtRechazado.Checked = True Then
                                        estado = "RE"
                                    End If
                                End If

                                Motivar_RutaGuia(numeroGuia, estado, mot_codigo, usr_id, tipoRespuesta)

                                If tipoRespuesta = "1" Then

                                    If nroRuta <> "SINRUTA" Then
                                        dt = objGuias.Agregar_GuiasRuta_RetornoRuta(numeroRuta, numeroGuia)
                                    Else
                                        dt = objGuias.Agregar_GuiasRuta_RetornoRuta_SinRuta(numeroGuia)
                                    End If


                                    dgvRetornoRuta.Rows.Add(dt.Rows(0).Item("GUIA").ToString, dt.Rows(0).Item("CLIENTE").ToString,
                                         dt.Rows(0).Item("DE_CDEPT").ToString, dt.Rows(0).Item("DE_CPROV").ToString,
                                         dt.Rows(0).Item("TG_CDESCRI").ToString, dt.Rows(0).Item("C5_CDIRENV").ToString, "", dt.Rows(0).Item("ESTADO_GUIA").ToString,
                                         dt.Rows(0).Item("MOTIVO").ToString, dt.Rows(0).Item("ESTADO_DESPACHO").ToString, dt.Rows(0).Item("FECHA_SALIDARUTA").ToString,
                                         dt.Rows(0).Item("USUARIO_SALIDARUTA").ToString, dt.Rows(0).Item("FECHA_RETORNORUTA").ToString,
                                         dt.Rows(0).Item("USUARIO_RETORNORUTA").ToString,
                                         dt.Rows(0).Item("FECHA_RECEPCION_CLIENTE").ToString, dt.Rows(0).Item("FECHA_INTER_FACTURA").ToString,
                                         dt.Rows(0).Item("FECHA_VTO_OC").ToString, dt.Rows(0).Item("FECHA_REPROG").ToString)

                                    Pintar_GrillaSemaforo()

                                End If

                            End If
                        End If
                    End If
                End If


            End If

        Catch ex As Exception

        End Try


    End Sub



    Sub Pintar_GrillaSemaforo()
        Try
            For i As Integer = 0 To dgvRetornoRuta.Rows.Count - 1


                If dgvRetornoRuta.Rows(i).Cells("EST_CODIGO2").Value = "PENDIENTE" Then
                    dgvRetornoRuta.Rows(i).Cells("color1").Style.BackColor = Color.Yellow
                End If

                If dgvRetornoRuta.Rows(i).Cells("EST_CODIGO2").Value = "ENTREGADO" Then
                    dgvRetornoRuta.Rows(i).Cells("color1").Style.BackColor = Color.Green
                End If


                If dgvRetornoRuta.Rows(i).Cells("EST_CODIGO2").Value = "RECHAZADO" Then
                    dgvRetornoRuta.Rows(i).Cells("color1").Style.BackColor = Color.Red
                End If


            Next

        Catch ex As Exception

        End Try
    End Sub

    'Private Sub dgvRetornoRuta_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs)
    '    Try

    '        Dim numeroGuia As String = String.Empty
    '        Dim fechaRecepClienteDate As String = String.Empty
    '        Dim fechaInterFacturaDate As String = String.Empty
    '        Dim fechaVtoOrdenCompraDate As String = String.Empty

    '        Dim fechaRecepClienteCadena As String = String.Empty
    '        Dim fechaInterFacturaCadena As String = String.Empty
    '        Dim fechaVtoOrdenCompraCadena As String = String.Empty
    '        Dim tipoTextoRespuesta As String = String.Empty


    '        numeroGuia = dgvRetornoRuta.CurrentRow.Cells.Item("C5_CNUMDOC").Value.ToString()
    '        fechaRecepClienteDate = ConversionFechaDate(dgvRetornoRuta.CurrentRow.Cells.Item("fechaRecepCliente").Value.ToString())
    '        fechaInterFacturaDate = ConversionFechaDate(dgvRetornoRuta.CurrentRow.Cells.Item("fechaInterFactura").Value.ToString())
    '        fechaVtoOrdenCompraDate = ConversionFechaDate(dgvRetornoRuta.CurrentRow.Cells.Item("fecha_vto_oc").Value.ToString())

    '        fechaRecepClienteCadena = ConversionFechaTexto(dgvRetornoRuta.CurrentRow.Cells.Item("fechaRecepCliente").Value.ToString())
    '        fechaInterFacturaCadena = ConversionFechaTexto(dgvRetornoRuta.CurrentRow.Cells.Item("fechaInterFactura").Value.ToString())
    '        fechaVtoOrdenCompraCadena = ConversionFechaTexto(dgvRetornoRuta.CurrentRow.Cells.Item("fecha_vto_oc").Value.ToString())

    '        Dim objGuias As New BeCabGuiaRuta

    '        If nroRuta <> "SINRUTA" Then
    '            objGuias.RegistrarFechaRetornoRuta(lblRuta.Text, numeroGuia, fechaRecepClienteDate, fechaInterFacturaDate, fechaVtoOrdenCompraDate, fechaRecepClienteCadena, fechaInterFacturaCadena, fechaVtoOrdenCompraCadena, tipoTextoRespuesta)
    '        Else
    '            objGuias.RegistrarFechaRetornoRuta_SinRuta(numeroGuia, fechaRecepClienteDate, fechaInterFacturaDate, fechaVtoOrdenCompraDate, fechaRecepClienteCadena, fechaInterFacturaCadena, fechaVtoOrdenCompraCadena, tipoTextoRespuesta)
    '        End If

    '        If tipoTextoRespuesta = "1" Then
    '            MessageBox.Show("Se acualizó satisfactoriamente", "Aviso", MessageBoxButtons.OK)
    '        End If


    '    Catch ex As Exception

    '    End Try
    'End Sub


    Function ConversionFechaDate(ByVal fecha As String) As String
        Try

            Dim fechaConverDate As String = String.Empty
            Dim dia As String
            Dim mes As String
            Dim anio As String

            anio = fecha.Substring(6, 4)
            mes = fecha.Substring(3, 2)
            dia = fecha.Substring(0, 2)

            fechaConverDate = anio + "-" + dia + "-" + mes

            Return fechaConverDate

        Catch ex As Exception

            Return Nothing

        End Try
    End Function

    Function ConversionFechaTexto(ByVal fecha As String)
        Try

            Dim fechaConverTexto As String = String.Empty

            fechaConverTexto = fecha.Substring(0, 10)

            Return fechaConverTexto

        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Private Sub dgvRetornoRuta_CellValueChanged_1(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRetornoRuta.CellValueChanged
        Try

            If dgvRetornoRuta.Rows.Count > 0 Then
                Dim numeroGuia As String = String.Empty
                Dim fechaRecepClienteDate As String = String.Empty
                Dim fechaInterFacturaDate As String = String.Empty
                Dim fechaVtoOrdenCompraDate As String = String.Empty

                Dim fechaRecepClienteCadena As String = String.Empty
                Dim fechaInterFacturaCadena As String = String.Empty
                Dim fechaVtoOrdenCompraCadena As String = String.Empty
                Dim tipoTextoRespuesta As String = String.Empty
                Dim fechaReProgramacion As String = String.Empty


                numeroGuia = dgvRetornoRuta.CurrentRow.Cells.Item("C5_CNUMDOC").Value.ToString()
                fechaRecepClienteDate = ConversionFechaDate(dgvRetornoRuta.CurrentRow.Cells.Item("fechaRecepCliente").Value.ToString())
                fechaInterFacturaDate = ConversionFechaDate(dgvRetornoRuta.CurrentRow.Cells.Item("fechaInterFactura").Value.ToString())
                fechaVtoOrdenCompraDate = ConversionFechaDate(dgvRetornoRuta.CurrentRow.Cells.Item("fecha_vto_oc").Value.ToString())
                fechaReProgramacion = ConversionFechaDate(dgvRetornoRuta.CurrentRow.Cells.Item("fecReProg").Value.ToString())

                fechaRecepClienteCadena = ConversionFechaTexto(dgvRetornoRuta.CurrentRow.Cells.Item("fechaRecepCliente").Value.ToString())
                fechaInterFacturaCadena = ConversionFechaTexto(dgvRetornoRuta.CurrentRow.Cells.Item("fechaInterFactura").Value.ToString())
                fechaVtoOrdenCompraCadena = ConversionFechaTexto(dgvRetornoRuta.CurrentRow.Cells.Item("fecha_vto_oc").Value.ToString())


                Dim objGuias As New BeCabGuiaRuta

                If nroRuta <> "SINRUTA" Then
                    objGuias.RegistrarFechaRetornoRuta(lblRuta.Text, numeroGuia, fechaRecepClienteDate, fechaInterFacturaDate, fechaVtoOrdenCompraDate, fechaRecepClienteCadena, fechaInterFacturaCadena, fechaVtoOrdenCompraCadena, fechaReProgramacion, tipoTextoRespuesta)
                Else
                    objGuias.RegistrarFechaRetornoRuta_SinRuta(numeroGuia, fechaRecepClienteDate, fechaInterFacturaDate, fechaVtoOrdenCompraDate, fechaRecepClienteCadena, fechaInterFacturaCadena, fechaVtoOrdenCompraCadena, fechaReProgramacion, tipoTextoRespuesta)
                End If

                If tipoTextoRespuesta = "1" Then
                    MessageBox.Show("Se acualizó satisfactoriamente", "Aviso", MessageBoxButtons.OK)
                End If
            End If


        Catch ex As Exception

        End Try
    End Sub
End Class