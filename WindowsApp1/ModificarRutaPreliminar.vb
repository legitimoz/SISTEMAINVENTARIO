Imports Nordic.Bl.Be

Public Class ModificarRutaPreliminar
    Public Ruta As String = ""
    Public dt_Rutas As New DataTable
    Private Estructura As New EstructuraTabla
    Public grabado As Boolean = False
    Public Bandera As Boolean = False

#Region "Metodos"
    Private Sub CargaInicial()
        Try

            LBL_ruta.Text = Ruta
            If dt_Rutas.Rows.Count > 0 Then
                DG_Rutas.DataSource = dt_Rutas
                FormatoTablaCabecera()
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub FormatoTablaCabecera()
        DG_Rutas.Columns("idconsolidado").Visible = False
        DG_Rutas.Columns("RutaTentativa").HeaderText = "Ruta Tentativa"
    End Sub
#End Region

#Region "Peticion Servidor"

#End Region

#Region "Eventos"
    Private Sub ModificarRutaPreliminar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargaInicial()
    End Sub

    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click

        Try
            For Each Dr As DataRow In dt_Rutas.Rows
                If Dr.Item("Marcar") = True Then
                    Bandera = True
                End If
            Next
            'If Bandera = False Then
            '    MsgBox("Debe seleccionar al menos un consolidado de guias", MsgBoxStyle.Exclamation, "SISTEMAS SSENDA")
            'Else
            '    grabado = True
            '    Me.Close()
            'End If

            grabado = True
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SISTEMAS SSENDA")
        End Try
    End Sub
#End Region
End Class