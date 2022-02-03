Imports Nordic.Bl.Be


Public Class frmObsReq

    Public nroReq As String
    Public asunto As String
    Public usr_id As String

    Private Sub frmObsReq_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            txtReqId.Text = nroReq
            txtAsunto.Text = asunto

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim obj As New BeRequerimiento
            Dim _tipoRespuesta As String = String.Empty
            Dim _textoRespuestas As String = String.Empty
            Dim idProg As String = String.Empty
            Dim fechaReg As String = String.Empty


            obj.RegistrarObservacion(txtReqId.Text.Trim, rtbComentario.Text.Trim, usr_id, _tipoRespuesta, _textoRespuestas, idProg, fechaReg)

            If _tipoRespuesta = "1" Then
                MessageBox.Show("Se registro satisfactoriamente la observacion", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.Close()
            Else
                If _tipoRespuesta = "0" Then
                    MessageBox.Show("Error en el registro: " + _textoRespuestas, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                End If

            End If

        Catch ex As Exception

        End Try
    End Sub
End Class