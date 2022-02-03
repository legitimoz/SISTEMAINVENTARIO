Public Class frmTexto

    Public comentario As String
    Public observacion As String

    Private Sub frmTexto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            rtbComentario.Text = comentario

            tslCantidad.Text = CStr(observacion.Length)

        Catch ex As Exception

        End Try
    End Sub
End Class