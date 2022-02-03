

Imports Nordic.Bl.Be

Public Class BuscadorArticulosUbicaion
    Public usr_id As Integer
    Public usr_usuario As String
    Private AlmObj As New AlmacenL
    Public dt As New DataTable

    Private Sub GestionContratacionForm_Load(sender As Object, e As EventArgs)
        Try
            CargaInicial()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub CargaInicial()
        Try
            ListarArticulos()
        Catch ex As Exception

        End Try
    End Sub

    Public Sub ListarArticulos()
        If dt.Rows.Count > 0 Then
            dt.Rows.Clear()
        End If
        dt = AlmObj.BuscarUbicacionArticulo
        If dt.Rows.Count > 0 Then
            DgArticulos.DataSource = dt
        End If
    End Sub

    Public Sub Buscar()
        Dim dtbusqueda As New DataTable
        Try
            Dim stringfiltro As String = ""
            stringfiltro = String.Format("Lote LIKE '%{0}%' AND CodArticulo LIKE '%{1}%' AND  Articulo LIKE '%{2}%' ", txt_codlote.Text, txt_codprod.Text, txt_descr.Text)
            dt.DefaultView.RowFilter = stringfiltro
        Catch ex As Exception
            Throw ex
            MsgBox(Constantes.MensajeErrorServer, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub BuscadorArticulosUbicaion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargaInicial()
    End Sub

    Private Sub txtCodRq_TextChanged(sender As Object, e As EventArgs) Handles txt_codlote.TextChanged
        Try
            Buscar()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txt_nroSerie_TextChanged(sender As Object, e As EventArgs) Handles txt_codprod.TextChanged
        Try
            Buscar()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtProveedores_TextChanged(sender As Object, e As EventArgs) Handles txt_descr.TextChanged
        Try
            Buscar()
        Catch ex As Exception

        End Try
    End Sub
End Class