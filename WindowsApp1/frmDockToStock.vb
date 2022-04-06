
Imports Nordic.Bl.Be

Public Class frmDockToStock
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try

            'Dim obj As New BeOrdenesCompra
            'Dim dt As New DataTable
            'dt = obj.Listar_Indicador_OrdenesCompra(dt_desde.Value.ToShortDateString, dt_hasta.Value.ToShortDateString)
            'dgvListarIndicadorDockToStock.DataSource = dt

        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmDockToStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class