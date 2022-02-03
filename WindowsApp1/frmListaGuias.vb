
Imports Nordic.Bl.Be

Public Class frmListaGuias

    Public flag As Integer
    Public c5_cnumdoc As String
    Public c5_ctd As String
    Public c5_calma As String

    Private Sub frmListaGuias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            Listar_Guias(1, "", "", "")

        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvListarGuias_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgvListarGuias.MouseDoubleClick
        Try

            c5_calma = dgvListarGuias.CurrentRow.Cells(0).Value
            c5_ctd = dgvListarGuias.CurrentRow.Cells(1).Value
            c5_cnumdoc = dgvListarGuias.CurrentRow.Cells(2).Value

            Me.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            If txtNroGuia.Text = "" Then
                Listar_Guias(2, dtpFecIni.Value.ToShortDateString, dtpFecFin.Value.ToShortDateString, "")
            Else

                Listar_Guias(3, dtpFecIni.Value.ToShortDateString, dtpFecFin.Value.ToShortDateString, txtNroGuia.Text.Trim)

            End If

        Catch ex As Exception

        End Try
    End Sub


    Sub Listar_Guias(ByVal flag As String, ByVal fecIni As String, ByVal fecFin As String, ByVal nroguia As String)
        Try
            Dim dt As New DataTable
            Dim objDoc As New BeDocumentos

            dt = objDoc.Listar_Guias(flag, fecIni, fecFin, nroguia)

            dgvListarGuias.DataSource = dt

            dgvListarGuias.Columns(0).Width = 50
            dgvListarGuias.Columns(1).Width = 50
            dgvListarGuias.Columns(2).Width = 100
            dgvListarGuias.Columns(3).Width = 100
            dgvListarGuias.Columns(4).Width = 100
            dgvListarGuias.Columns(5).Width = 100
            dgvListarGuias.Columns(6).Width = 400

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtNroGuia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNroGuia.KeyPress
        Try

            If e.KeyChar = Convert.ToChar(Keys.Enter) Then

                If txtNroGuia.Text = "" Then
                    MessageBox.Show("Ingrese el numero de Guía.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtNroGuia.Focus()

                Else
                    btnBuscar_Click(sender, e)
                End If


            End If

        Catch ex As Exception

        End Try
    End Sub
End Class