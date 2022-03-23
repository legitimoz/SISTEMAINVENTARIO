Public Class ComplementoDespacho

    Public Grabado As Boolean
    Public idCosto As Integer
    Private DtCentrosCosto As New DataTable
    Private AlmacenObj As New AlmacenL

    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click
        Try
            Aceptar()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarCentrosCosto()
        Try
            DtCentrosCosto = AlmacenObj.SP_OBTENER_COSTOS
            If DtCentrosCosto.Rows.Count > 0 Then
                Cmb_Costos.DataSource = DtCentrosCosto
                Cmb_Costos.DisplayMember = "nombre"
                Cmb_Costos.ValueMember = "idcliente"
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargaInicial()
        Try
            CargarCentrosCosto()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ComplementoDespacho_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargaInicial()
    End Sub

    Private Sub Aceptar()
        Try
            idCosto = CType(Cmb_Costos.SelectedValue.ToString, Integer)

            If ValidarAceptar() Then
                Grabado = True
                Me.Close()
            Else
                MsgBox("Existen Errores, Valide e intente nuevamente", MsgBoxStyle.Exclamation, "SISTEMAS NORDCI")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Function ValidarAceptar() As Boolean
        Dim rp As Boolean = True
        Try
            ErrorProvider1.SetError(Cmb_Costos, "")
            If idCosto = 0 Then
                ErrorProvider1.SetError(Cmb_Costos, "Seleccione Centro de Costos")
                rp = False
            End If
        Catch ex As Exception
            Throw ex
        End Try
        Return rp
    End Function



End Class