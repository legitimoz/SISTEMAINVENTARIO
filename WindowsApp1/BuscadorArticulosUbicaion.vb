

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

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Public Sub Obtener()
        Try
            If DgArticulos.Rows.Count > 0 Then
                codprod = DgArticulos.CurrentRow.Cells("CodArticulo").Value.ToString.Trim
                articuloNombre = DgArticulos.CurrentRow.Cells("Articulo").Value.ToString.Trim
                lote = DgArticulos.CurrentRow.Cells("Lote").Value.ToString.Trim
                vencimiento = DgArticulos.CurrentRow.Cells("Vencimiento").Value.ToString.Trim
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public codprod, articuloNombre, lote, vencimiento As String

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Try
            Obtener()

            If codprod <> "" And articuloNombre <> "" Then
                Dim factorcaja, factormaster As Integer
                Dim Dtfactores As New DataTable
                Dtfactores = ObtenerFacrores(codprod)
                If Dtfactores.Rows.Count > 0 Then
                    factorcaja = Dtfactores.Rows(0).Item("cinternas").ToString
                    factormaster = Dtfactores.Rows(0).Item("cmaster").ToString
                Else
                    factormaster = 0
                    factorcaja = 0
                End If

                Dim cantrotuForm As New CantidadRotulos
                cantrotuForm.ShowDialog()
                If cantrotuForm.grabado = True Then
                    Dim cantidad = cantrotuForm.cantidad
                    If cantidad <> 0 Then
                        Dim Obj As New Demo
                        For Index As Integer = 1 To cantidad
                            Obj.ImprimirRotuloArticulo("RetuloArticuloIngreso.rdlc", codprod, articuloNombre, vencimiento, lote, factorcaja.ToString + " UND", (factorcaja * factormaster).ToString + " UND")
                        Next
                    End If
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function ObtenerFacrores(CodArticulo As String) As DataTable
        Dim dtretorno As New DataTable
        Try
            dtretorno = AlmObj.ObtenerFactoresArticulo(CodArticulo)
        Catch ex As Exception
            Throw ex
        End Try
        Return dtretorno
    End Function

End Class