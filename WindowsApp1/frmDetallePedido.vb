Imports Nordic.Bl.Be

Public Class frmDetallePedido

    Public codpro As String
    Public numPed As String


    Private Sub frmDetallePedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CargarDetalleProductos(codpro, numPed)

        Catch ex As Exception

        End Try
    End Sub

    Public Sub CargarDetalleProductos(ByVal codPro As String, ByVal numPed As String)
        Try

            Dim dt As New DataTable
            Dim objPedidos As New BePedidos

            dt = objPedidos.ObtenerDetalleProductos(codPro, numPed)

            dgvListarDetalleProductos.DataSource = dt

            dgvListarDetalleProductos.Columns(0).Visible = False
            dgvListarDetalleProductos.Columns(1).Visible = False

            dgvListarDetalleProductos.Columns(0).Width = 50
            dgvListarDetalleProductos.Columns(1).Width = 150
            dgvListarDetalleProductos.Columns(2).Width = 80
            dgvListarDetalleProductos.Columns(3).Width = 250
            dgvListarDetalleProductos.Columns(4).Width = 80

        Catch ex As Exception

        End Try
    End Sub

End Class