Public Class DetallePosiciones
    Private ObjAlmacen As New AlmacenL
    Public codalmacen, numdoc, tipodoc, codarticulo, lote As String
    Private dtposiciones As New DataTable

    Private Sub DetallePosiciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtposiciones = ObjAlmacen.ListarPosicionesDetalle(codalmacen, numdoc, tipodoc, codarticulo, lote)
        If dtposiciones.Rows.Count > 0 Then
            Dg_Posiciones.DataSource = dtposiciones
        End If
    End Sub
End Class