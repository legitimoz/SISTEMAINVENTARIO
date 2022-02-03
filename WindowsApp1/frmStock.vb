Public Class frmStock
    Private Sub frmStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Sub PintarRegistrosObservados()
        Try
            For i As Integer = 0 To DataGridView1.Rows.Count - 1

                If DataGridView1.Rows(i).Cells(0).Value = "NEGRO" Then
                    DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.Black

                End If

            Next

        Catch ex As Exception

        End Try

    End Sub

End Class