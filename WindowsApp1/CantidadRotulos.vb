Public Class CantidadRotulos
    Public grabado As Boolean = True
    Public cantidad As Integer = 0

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        grabado = False
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If ValidarAceptar() = True Then
                cantidad = txt_cantidad.Text
                grabado = True
                Me.Close()
            Else
                MsgBox("Existen Errores, Valide y vuelva a intentar", MsgBoxStyle.Exclamation, "SISTEMAS NORDIC")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Function ValidarAceptar() As Boolean

        Dim rp As Boolean = True
        Try
            ErrorProvider1.SetError(txt_cantidad, "")

            If txt_cantidad.Text = "" Then
                ErrorProvider1.SetError(txt_cantidad, "Ingrese Cantidad Rotulos")
                rp = False
            Else
                If ValidarNumerico(txt_cantidad.Text) = False Then
                    ErrorProvider1.SetError(txt_cantidad, "Cantidad debe ser dato Numerico")
                    rp = False
                Else
                    If CType(txt_cantidad.Text, Integer) <= 0 Then
                        ErrorProvider1.SetError(txt_cantidad, "Cantidad debe ser mayor a 0")
                        rp = False
                    End If
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
        Return rp
    End Function

    Public Function ValidarNumerico(Dato As String) As Boolean
        Dim canConvert As Boolean
        Try
            Dim convertido As Integer
            canConvert = Integer.TryParse(Dato, convertido)

        Catch ex As Exception

        End Try
        Return canConvert
    End Function

End Class