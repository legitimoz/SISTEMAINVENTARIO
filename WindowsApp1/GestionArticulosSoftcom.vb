Imports Nordic.Bl.Be

Public Class GestionArticulosSoftcom
    Private DtArticulos As New DataTable
    Private OjbAlmacen As New AlmacenL
    Public usr_id As Integer = Constantes.ValorEnteroInicial

#Region "Metodos"

    Public Sub Filtrar()

        Try
            Dim stringfiltro As String = ""
            stringfiltro = String.Format("Codigo LIKE '%{0}%' AND Nombre LIKE '%{1}%' ", txt_codigo.Text, txt_nombre.Text)
            DtArticulos.DefaultView.RowFilter = stringfiltro
        Catch ex As Exception
            Throw ex
            MsgBox(Constantes.MensajeErrorServer, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub CargaInicial()
        Try
            ListarArticulos()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ListarArticulos()
        Try
            DtArticulos = OjbAlmacen.SP_CSE_LISTAR_ARTICULOS
            If DtArticulos.Rows.Count > Constantes.ValorEnteroInicial Then
                Dg_Articulos.DataSource = DtArticulos
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Eventos"
    Private Sub cmdCerrar_Click(sender As Object, e As EventArgs) Handles cmdCerrar.Click
        Me.Close()
    End Sub

    Private Sub GestionArticulosSoftcom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CargaInicial()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SISTEMAS NORDIC")
        End Try
    End Sub

    Private Sub txt_numero_TextChanged(sender As Object, e As EventArgs) Handles txt_codigo.TextChanged
        Try
            Filtrar()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SISTEMAS NORDIC")
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_nombre.TextChanged
        Try
            Filtrar()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SISTEMAS NORDIC")
        End Try
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Try
            If Dg_Articulos.Rows.Count > Constantes.ValorEnteroInicial Then
                If Dg_Articulos.CurrentRow IsNot Nothing Then
                    Dim formVal As New ValidarCubicajeArticulo
                    formVal.usr_id = usr_id
                    formVal.CurrentRow = Dg_Articulos.CurrentRow
                    formVal.ShowDialog()
                    If formVal.grabado = True Then
                        ListarArticulos()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SISTEMAS NORDIC")
        End Try
    End Sub
#End Region
End Class