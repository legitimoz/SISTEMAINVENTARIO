
Imports System.Data.SqlClient
Imports Nordic.Bl.Be

Public Class frmLogin
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        Try
            Dim objLogin As New BeLogin

            objLogin.prUser = txtUsername.Text
            objLogin.prClave = txtPassword.Text

            objLogin.Obtener_Logueo(objLogin.prUser, objLogin.prClave, objLogin.PrUserName, objLogin.pridUser, objLogin.PrPer_id)

            Dim frmMenu As New MenuPrincipal

            If objLogin.PrUserName <> "" Then

                frmMenu.prIdUser = objLogin.pridUser
                frmMenu.prUser = objLogin.prUser
                frmMenu.PrUserName = objLogin.PrUserName
                frmMenu.prPerId = objLogin.PrPer_id


                frmMenu.Show()
                Me.Visible = False
            Else
                MessageBox.Show("Usuario o Clave Incorrecta", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        Try
            If e.KeyChar = Convert.ToChar(Keys.Return) Then
                OK_Click(sender, e)
                e.Handled = True
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Try
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub
End Class