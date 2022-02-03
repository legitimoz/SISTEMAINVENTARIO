
Imports Nordic.Bl.Be


Public Class frmArticulos

    Public usr_id As String
    Public usr_usuario As String

    Private Sub tsbNuevo_Click(sender As Object, e As EventArgs) Handles tsbNuevo.Click
        Try
            Dim objArt As New frmGestionArticulos

            objArt.flag = "Nuevo"
            objArt.usr_id = usr_id
            objArt.usr_usuario = usr_usuario
            objArt.ShowDialog()

            Cargar_Articulos(1, "", 0)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmArticulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Cargar_Articulos(1, "", 0)
        Catch ex As Exception

        End Try
    End Sub

    Sub Cargar_Articulos(ByVal flag As String, ByVal nombre As String, ByVal ar_id As String)
        Try

            Dim obj As New BeArticulos
            Dim dt As DataTable

            dt = obj.Obtener_ListadoArticulos(flag, nombre, ar_id)

            dgvListadoArticulos.DataSource = dt

            dgvListadoArticulos.Columns(0).Visible = False
            dgvListadoArticulos.Columns(1).Width = 80


        Catch ex As Exception

        End Try
    End Sub

    Private Sub tsbAbrir_Click(sender As Object, e As EventArgs) Handles tsbAbrir.Click
        Try
            Dim ar_id As Integer

            ar_id = dgvListadoArticulos.CurrentRow.Cells.Item(0).Value

            Dim obj As New frmGestionArticulos
            obj.flag = "Editar"
            obj.usr_id = usr_id
            obj.ar_id = ar_id

            obj.ShowDialog()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtBusArticulo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBusArticulo.KeyPress
        Try

            If e.KeyChar = Convert.ToChar(Keys.Enter) Then

                If txtBusArticulo.Text = "" Then
                    MessageBox.Show("Ingrese el nombre del Articulo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtBusArticulo.Focus()
                Else
                    Cargar_Articulos(2, txtBusArticulo.Text.Trim, 0)
                End If
            Else
                If e.KeyChar = Convert.ToChar(Keys.Escape) Then
                    Cargar_Articulos(1, "", 0)
                    txtBusArticulo.Text = ""
                End If
            End If

        Catch ex As Exception

        End Try
    End Sub


End Class