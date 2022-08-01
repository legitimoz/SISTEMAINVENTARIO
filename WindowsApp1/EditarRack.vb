
Public Class EditarRack
    Private ObjAlmacen As New AlmacenL
    Public idalmacen As Integer
    Public grabado = False
    Public codigoalmacen As String
    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click
        Try
            LlamarRegistrar()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub LlamarRegistrar()
        Dim rp As Integer = 0
        Try
            If txt_numeracion.Text <> "" And txt_x.Text <> "" And txt_y.Text <> "" Then
                rp = ObjAlmacen.RegistrarAlmacen(idalmacen, Convert.ToInt32(txt_numeracion.Text), Convert.ToInt32(txt_x.Text), Convert.ToInt32(txt_y.Text), codigoalmacen)
                If rp <> 0 Then
                    Dim FormEditPos As New EditarPosicionesComplemento
                    FormEditPos.Text = "Complementar Posiciones"
                    FormEditPos.idrack = rp
                    FormEditPos.ShowDialog()
                    If FormEditPos.grabado = True Then
                        MsgBox("Rack Registrado Correctamente", MsgBoxStyle.Information)
                        grabado = True
                        Me.Close()
                    End If
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub EditarRack_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class