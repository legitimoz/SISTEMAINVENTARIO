
Imports Nordic.Bl.Be

Public Class frmClientes

    Public ruc As String
    Public cliente As String
    Public codvend As String
    Public vendedor As String
    Public codCot As String
    Public Cotizador As String




    Private Sub frmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Listar_Clientes(0, "")

        Catch ex As Exception

        End Try
    End Sub


    Sub Listar_Clientes(ByVal flag As String, ByVal cliente As String)
        Try

            Dim obj As New BeSolicitudInstitucional
            Dim dt As DataTable

            dt = obj.Listar_Clientes(flag, cliente)

            dgvListarClientes.DataSource = dt

            dgvListarClientes.Columns(1).Width = 250


        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCliente.KeyPress
        Try

            If e.KeyChar = Convert.ToChar(Keys.Enter) Then

                If txtCliente.Text = "" Then
                    MessageBox.Show("Ingrese el nombre del cliente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtCliente.Focus()

                Else
                    Listar_Clientes(1, txtCliente.Text.Trim)

                End If


            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvListarClientes_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgvListarClientes.MouseDoubleClick
        Try
            ruc = dgvListarClientes.CurrentRow.Cells(0).Value
            cliente = dgvListarClientes.CurrentRow.Cells(1).Value
            codvend = dgvListarClientes.CurrentRow.Cells(2).Value
            vendedor = dgvListarClientes.CurrentRow.Cells(3).Value
            codCot = dgvListarClientes.CurrentRow.Cells(4).Value
            Cotizador = dgvListarClientes.CurrentRow.Cells(5).Value

            Me.Close()


        Catch ex As Exception

        End Try
    End Sub
End Class