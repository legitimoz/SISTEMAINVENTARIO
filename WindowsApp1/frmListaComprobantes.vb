Imports Nordic.Bl.Be

Public Class frmListaComprobantes

    'F5_CCODAGE, F5_CTD, F5_CNUMSER, F5_CNUMDOC,
    Public flag As Integer
    Public f5_ccodage As String
    Public f5_ctd As String
    Public f5_cnumser As String
    Public f5_cnumdoc As String
    Public nombre_archivo As String

    Private Sub frmListaComprobantes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Listar_Comprobantes(1, "", "", "")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvListarComprobantes_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgvListarComprobantes.MouseDoubleClick
        Try

            f5_ccodage = dgvListarComprobantes.CurrentRow.Cells(0).Value
            f5_ctd = dgvListarComprobantes.CurrentRow.Cells(1).Value
            f5_cnumser = dgvListarComprobantes.CurrentRow.Cells(2).Value
            f5_cnumdoc = dgvListarComprobantes.CurrentRow.Cells(3).Value
            nombre_archivo = dgvListarComprobantes.CurrentRow.Cells(9).Value

            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try

            If txtComprobante.Text = "" Then
                Listar_Comprobantes(2, dtpFecIni.Value.ToShortDateString, dtpFecFin.Value.ToShortDateString, "")
            Else
                Listar_Comprobantes(3, "", "", txtComprobante.Text.Trim)
            End If

        Catch ex As Exception

        End Try
    End Sub


    Sub Listar_Comprobantes(ByVal flag As String, ByVal fecIni As String, ByVal fecFin As String, ByVal comprobante As String)
        Try

            Dim dt As New DataTable
            Dim objDoc As New BeDocumentos

            dt = objDoc.Listar_Comprobantes(flag, fecIni, fecFin, comprobante)

            dgvListarComprobantes.DataSource = dt

            dgvListarComprobantes.Columns(0).Width = 50
            dgvListarComprobantes.Columns(1).Width = 50
            dgvListarComprobantes.Columns(2).Width = 50
            dgvListarComprobantes.Columns(3).Width = 50
            dgvListarComprobantes.Columns(4).Width = 50
            dgvListarComprobantes.Columns(5).Width = 100
            dgvListarComprobantes.Columns(6).Width = 100
            dgvListarComprobantes.Columns(7).Width = 100
            dgvListarComprobantes.Columns(8).Width = 400
            dgvListarComprobantes.Columns(9).Width = 100


            dgvListarComprobantes.Columns(0).Visible = False
            dgvListarComprobantes.Columns(1).Visible = False
            dgvListarComprobantes.Columns(2).Visible = False
            dgvListarComprobantes.Columns(3).Visible = False

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtComprobante_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtComprobante.KeyPress
        Try

            If e.KeyChar = Convert.ToChar(Keys.Enter) Then

                If txtComprobante.Text = "" Then
                    MessageBox.Show("Ingrese el numero de comprobante", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtComprobante.Focus()

                Else
                    btnBuscar_Click(sender, e)
                End If


            End If


        Catch ex As Exception

        End Try
    End Sub



End Class