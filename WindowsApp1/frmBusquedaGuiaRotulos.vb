Imports Nordic.Bl.Be



Public Class frmBusquedaGuiaRotulos

    Public nroguia As String

    Public c5_calma As String
    Public c5_cctd As String
    Public c5_cnumdoc As String
    Public c5_ccodigo As String
    Public articulo As String
    Public lote As String
    Public fechaVenc As String
    Public cantidad As String



    Private Sub frmBusquedaGuiaRotulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            Dim dt As DataTable
            Dim obj As New BeGuias

            dt = obj.Obtener_Guia_Rotulos(nroguia)

            dgvListarDetalleGuias.DataSource = dt

            dgvListarDetalleGuias.Columns(1).Visible = False
            dgvListarDetalleGuias.Columns(2).Visible = False

        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvListarDetalleGuias_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgvListarDetalleGuias.MouseDoubleClick
        Try

            c5_calma = dgvListarDetalleGuias.CurrentRow.Cells(0).Value
            c5_cctd = dgvListarDetalleGuias.CurrentRow.Cells(1).Value
            c5_cnumdoc = dgvListarDetalleGuias.CurrentRow.Cells(2).Value
            nroguia = dgvListarDetalleGuias.CurrentRow.Cells(3).Value
            c5_ccodigo = dgvListarDetalleGuias.CurrentRow.Cells(4).Value
            articulo = dgvListarDetalleGuias.CurrentRow.Cells(5).Value
            lote = dgvListarDetalleGuias.CurrentRow.Cells(6).Value
            fechaVenc = dgvListarDetalleGuias.CurrentRow.Cells(7).Value
            cantidad = dgvListarDetalleGuias.CurrentRow.Cells(8).Value

            Me.Close()

        Catch ex As Exception

        End Try
    End Sub
End Class