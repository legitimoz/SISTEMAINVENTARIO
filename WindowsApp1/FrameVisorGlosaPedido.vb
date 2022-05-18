Public Class FrameVisorGlosaPedido

    Public Glosa As String = ""

    Private Sub FrameVisorGlosaPedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CargaInicial()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CargaInicial()
        Try
            If Glosa <> "" Then
                RichTextBox1.Text = Glosa
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click
        Me.Close()
    End Sub
End Class