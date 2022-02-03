Public Class ReporteMovimientosAlmacen
    Public idalmacen As Integer
    Public almacen, sitenombre As String
    Private ObjAlmacen As New AlmacenL
    Private Sub ReporteMovimientosAlmacen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Function ValidarFechasbuscar() As Boolean
        Dim rp As Boolean = True
        ErrorProvider1.SetError(dt_hasta, "")
        Try
            If dt_hasta.Value < dt_desde.Value Then
                ErrorProvider1.SetError(dt_hasta, "Fecha hasta invalida")
                rp = False
            End If
        Catch ex As Exception

        End Try
        Return rp
    End Function

    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click
        Dim fechadesde, fechahasta As String
        Dim dtMovAlmacen As New DataTable
        Try
            If ValidarFechasbuscar() Then
                'Dim ReporteMovimientosAlmacen As
                fechadesde = dt_desde.Value.Year.ToString + "/" + dt_desde.Value.Month.ToString + "/" + (dt_desde.Value.Day).ToString

                fechahasta = dt_hasta.Value.Year.ToString + "/" + dt_hasta.Value.Month.ToString + "/" + (dt_hasta.Value.Day).ToString
                dtMovAlmacen = LlamarListarMovimientosXAlmacen(idalmacen, fechadesde, fechahasta)
                If dtMovAlmacen.Rows.Count > 0 Then
                    Dim Form As New ReportMovAlmacenForm
                    Form.almacen = almacen
                    Form.sitenombre = sitenombre
                    Form.fechadesde = fechadesde
                    Form.fechahasta = fechahasta
                    Form.DtDetalleReporte = dtMovAlmacen
                    Form.Show()
                    Me.Close()
                Else
                    MsgBox("Almacen No tiene Movimientos", MsgBoxStyle.Exclamation, "Alerta")
                End If
            Else

            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Function LlamarListarMovimientosXAlmacen(idalmacen As Integer, fechadesde As String, fechahasta As String) As DataTable

        Dim dtretono As DataTable
        Try
            dtretono = ObjAlmacen.ListarMovimientosXAlmacen(idalmacen, fechadesde, fechahasta).Copy
        Catch ex As Exception
            Throw ex
        End Try
        Return dtretono
    End Function
End Class