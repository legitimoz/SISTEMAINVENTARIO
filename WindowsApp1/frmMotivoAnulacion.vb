
Imports Nordic.Bl.Be
Imports System.IO

Public Class frmMotivoAnulacion

    Public idSolicitud As String
    Public usr_id As Integer

    Private Sub frmMotivoAnulacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txtSolid.Text = idSolicitud
            ListarMotivosAnulacion()



        Catch ex As Exception

        End Try
    End Sub



    Sub ListarMotivosAnulacion()
        Try
            Dim objDoc As New BeSolicitudInstitucional
            Dim dt As New DataTable

            dt = objDoc.Obtener_MotivosAnulacionSolicitud()

            cbxTipoMotivos.DataSource = dt
            cbxTipoMotivos.ValueMember = "mot_id"
            cbxTipoMotivos.DisplayMember = "mot_des"

        Catch ex As Exception
            MessageBox.Show(ex.Message, "NORDIC", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try

            If cbxTipoMotivos.SelectedIndex = 0 Then
                MessageBox.Show("Seleccione el motivo de anulación", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Dim obj As New BeSolicitudInstitucional
                Dim filas As Integer

                filas = obj.Registrar_SolicitudAnulada(txtSolid.Text.Trim, cbxTipoMotivos.SelectedValue, usr_id, rtbDescripcion.Text)

                If filas = 2 Then

                    MessageBox.Show("Se registro su motivo de anulación", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()

                End If
            End If



        Catch ex As Exception

        End Try
    End Sub
End Class