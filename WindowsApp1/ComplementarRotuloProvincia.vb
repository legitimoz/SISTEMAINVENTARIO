Public Class ComplementarRotuloProvincia
    Public grabado As Boolean = False

    Private Sub ComplementarRotuloProvincia_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click
        Try
            Aceptar()
        Catch ex As Exception

        End Try
    End Sub

    Public Sub Aceptar()
        Try
            If ValidarAceptar() Then
                grabado = True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function ValidarAceptar() As Boolean
        ErrorProvider1.SetError(txt_alto, "")
        Dim rp As Boolean = True
        Try
            If txt_alto.Text = "" Then
                rp = False
                ErrorProvider1.SetError(txt_alto, "Ingrese Cantidad de Bultos")
            Else
                If IsNumeric(txt_alto.Text) = False Then
                    rp = False
                    ErrorProvider1.SetError(txt_alto, "Cantidad de bultos debe ser Dato Numerico")
                Else
                    If CType(txt_alto.Text, Integer) <= 0 Then
                        rp = False
                        ErrorProvider1.SetError(txt_alto, "Cantidad de bultos debe ser mayor a 0")
                    End If
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
        Return rp
    End Function
End Class