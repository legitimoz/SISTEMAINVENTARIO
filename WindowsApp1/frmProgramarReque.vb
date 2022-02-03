Imports Nordic.Bl.Be


Public Class frmProgramarReque

    Public idReq As String
    Public usr_id As String


    Private Sub frmProgramarReque_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            txtIdReq.Text = idReq
            Cargar_ListaResponsables()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Try
            Me.Close()


        Catch ex As Exception

        End Try
    End Sub



    Sub Cargar_ListaResponsables()
        Try
            Dim objReq As New BeRequerimiento
            Dim dt As New DataTable

            dt = objReq.Obtener_Responsables

            cboResponsable.DataSource = dt
            cboResponsable.ValueMember = "res_id"
            cboResponsable.DisplayMember = "res_nombre"

        Catch ex As Exception
            MessageBox.Show(ex.Message, "NORDIC", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try

            Dim obj As New BeProgramacion

            Dim anio As String
            Dim mes As String
            Dim dia As String
            Dim hora As String

            Dim rpr_id As String = String.Empty
            Dim fechora As String = String.Empty
            Dim _tipoRespuesta As String = String.Empty
            Dim _textoRespuesta As String = String.Empty


            If cboResponsable.SelectedIndex = 0 Then
                MessageBox.Show("Debe seleccionar el responsable", "NORDIC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                'If mtbHoraIni.Text = "_:_" Then
                '    MessageBox.Show("Debe ingresar la hora Inicio", "NORDIC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                'Else
                '    If mtbHoraFin.Text = "_:_" Then
                '        MessageBox.Show("Debe ingresar la hora Fin", "NORDIC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                '    Else

                obj.prreq_id = txtIdReq.Text
                obj.prres_id = cboResponsable.SelectedValue


                If mtbHoraIni.Text = "  :" Then
                    obj.prrpr_fecinicio = ""
                Else
                    anio = dtpFecIni.Value.Year.ToString
                    mes = dtpFecIni.Value.Month.ToString
                    dia = dtpFecIni.Value.Day.ToString

                    If mes.Length = 1 Then
                        mes = "0" + mes
                    End If

                    If dia.Length = 1 Then
                        dia = "0" + dia
                    End If

                    hora = mtbHoraIni.Text

                    obj.prrpr_fecinicio = anio + "-" + dia + "-" + mes + " " + hora + ":00.000"

                End If

                '--------------------------------------------------------------

                If mtbHoraFin.Text = "  :" Then
                    obj.prrpr_fecfin = ""
                Else
                    anio = dtpFecFin.Value.Year.ToString
                    mes = dtpFecFin.Value.Month.ToString
                    dia = dtpFecFin.Value.Day.ToString


                    If mes.Length = 1 Then
                        mes = "0" + mes
                    End If

                    If dia.Length = 1 Then
                        dia = "0" + dia
                    End If

                    hora = mtbHoraFin.Text

                    obj.prrpr_fecfin = anio + "-" + dia + "-" + mes + " " + hora + ":00.000"
                End If

                '---------------------------------------------------------------

                obj.prusr_id = usr_id

                obj.RegistrarProgramacion(obj, _tipoRespuesta, _textoRespuesta, rpr_id, fechora)

                        If _tipoRespuesta = "1" Then

                            txtNroPro.Text = rpr_id
                            Deshabilitar()
                            MessageBox.Show("Se registro la programación de forma satisfactoria", "NORDIC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Me.Close()
                        Else
                            If _tipoRespuesta = "0" Then
                                MessageBox.Show("Error al registrar: " + _textoRespuesta, "NORDIC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                Deshabilitar()
                            End If

                        End If

                'End If
                'End If
            End If


        Catch ex As Exception

        End Try
    End Sub


    Sub Deshabilitar()
        dtpFecIni.Enabled = False
        dtpFecIni.Enabled = False
        mtbHoraIni.Enabled = False
        mtbHoraFin.Enabled = False
        btnGuardar.Enabled = False

    End Sub


End Class