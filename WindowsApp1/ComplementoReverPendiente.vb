Public Class ComplementoReverPendiente

    Public Grabado As Boolean = False
    Public comentario As String

    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click
        Try
            Aceptar()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Aceptar()
        Try
            ErrorProvider1.SetError(RichTextBox1, "")
            If RichTextBox1.Text = "" Then
                ErrorProvider1.SetError(RichTextBox1, "Ingrese Comentario que justifique la Reversión del Estado de Guias")
            Else
                comentario = RichTextBox1.Text.Trim
                Grabado = True
                Me.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class