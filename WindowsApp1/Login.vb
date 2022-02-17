

Imports Nordic.Bl.Be

Public Class Login
    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click
        IniciarSesion()
    End Sub

    Public Sub IniciarSesion()
        Try
            Dim objLogin As New BeLogin

            objLogin.prUser = txtusuario.Text.Trim
            objLogin.prClave = txtclave.Text.Trim

            objLogin.Obtener_Logueo(objLogin.prUser, objLogin.prClave, objLogin.PrUserName, objLogin.pridUser, objLogin.PrPer_id)

            Dim frmMenu As New MenuPrincipal

            If objLogin.PrUserName <> "" Then

                frmMenu.prIdUser = objLogin.pridUser
                frmMenu.prUser = objLogin.prUser
                frmMenu.PrUserName = objLogin.PrUserName
                frmMenu.prPerId = objLogin.PrPer_id


                frmMenu.Show()
                'Me.Visible = False
                Me.Close()
            Else
                MessageBox.Show("Usuario o Clave Incorrecta", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtclave_KeyDown(sender As Object, e As KeyEventArgs) Handles txtclave.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                IniciarSesion()
            End If
        Catch ex As Exception
            'Throw ex
            MsgBox("No se pudo Inicial Sesion", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Application.Exit()
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub checkVerPass_CheckedChanged(sender As Object, e As EventArgs) Handles checkVerPass.CheckedChanged
        If checkVerPass.Checked = True Then
            txtclave.PasswordChar = ""
        ElseIf checkVerPass.Checked = False Then
            txtclave.PasswordChar = "*"
        End If

    End Sub
End Class