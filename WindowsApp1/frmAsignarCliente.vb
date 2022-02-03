

Imports Nordic.Bl.Be

Public Class frmAsignarCliente

    Public idSolicitud As String
    Public usr_id As String


    Private Sub frmAsignarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txtIdSolicitud.Text = idSolicitud
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Try
            Dim obj As New frmClientes

            obj.ShowDialog()


            txtRuc.Text = obj.ruc
            txtCliente.Text = obj.cliente
            txtCodVend.Text = obj.codvend
            txtVendedor.Text = obj.vendedor
            txtCodCoti.Text = obj.codCot
            txtCotizador.Text = obj.Cotizador

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAsignar_Click(sender As Object, e As EventArgs) Handles btnAsignar.Click
        Try

            Dim obj As New BeSolicitudInstitucional


            If txtCliente.Text = "" Then
                MessageBox.Show("No existe el Cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtCliente.Focus()
            Else
                If txtCodVend.Text = "" Then
                    MessageBox.Show("No existe Vendedor", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtCodVend.Focus()
                Else
                    If txtCodCoti.Text = "" Then
                        MessageBox.Show("No existe Cotizador", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        txtCodCoti.Focus()
                    Else
                        Dim filas As Integer

                        filas = obj.Asignar_Cliente_Solicitud(txtIdSolicitud.Text, txtRuc.Text.Trim, txtCliente.Text.Trim, txtCodVend.Text.Trim, txtCodCoti.Text.Trim, usr_id)

                        If filas = 1 Then
                            MessageBox.Show("Asignación Satisfactoria", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Me.Close()

                        End If

                    End If

                End If


            End If
        Catch ex As Exception

        End Try
    End Sub
End Class