Imports Nordic.Bl.Be


Public Class frmVendedores

    Public codven_var1 As String
    Public vended_var1 As String

    Private Sub frmVendedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Listar_Vendedores("0", "")

            txtBusqVend.Focus()

        Catch ex As Exception

        End Try
    End Sub

    Sub Listar_Vendedores(ByVal flag As String, ByVal nombre As String)
        Try
            Dim obj As New BeCabReque
            Dim dt As New DataTable


            dt = obj.Listar_Vendedores(flag, nombre)

            dgvVendedores.DataSource = dt

            dgvVendedores.Columns(0).Width = 50
            dgvVendedores.Columns(1).Width = 200

        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvVendedores_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVendedores.CellDoubleClick
        Try
            codven_var1 = dgvVendedores.CurrentRow.Cells.Item(0).Value
            vended_var1 = dgvVendedores.CurrentRow.Cells.Item(1).Value

            Me.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvVendedores_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dgvVendedores.KeyPress
        Try
            If e.KeyChar = Convert.ToChar(Keys.F1) Then

                codven_var1 = dgvVendedores.CurrentRow.Cells.Item(0).Value
                vended_var1 = dgvVendedores.CurrentRow.Cells.Item(1).Value
                Me.Close()
            End If



        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtBusqVend_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBusqVend.KeyPress
        Try

            If e.KeyChar = Convert.ToChar(Keys.Enter) Then

                Listar_Vendedores("1", txtBusqVend.Text.Trim)

            End If

        Catch ex As Exception

        End Try
    End Sub
End Class