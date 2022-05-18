Public Class ComplementoDespacho

    Public Grabado As Boolean
    Public idCosto As Integer = 0
    Public idsiteliqu As Integer = 0
    Public idsitePicking As Integer = 0
    Public Comentario As String = ""
    Private DtCentrosCosto As New DataTable
    Private AlmacenObj As New AlmacenL

    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click
        Try
            Aceptar()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarCentrosCosto()
        Try
            DtCentrosCosto = AlmacenObj.SP_OBTENER_COSTOS
            If DtCentrosCosto.Rows.Count > 0 Then
                Cmb_Costos.DataSource = DtCentrosCosto
                Cmb_Costos.DisplayMember = "nombre"
                Cmb_Costos.ValueMember = "idcliente"
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargaInicial()
        Try
            CargarSitePicking()
            CargarSite()
            CargarCentrosCosto()
            cmb_site.SelectedIndex = 1
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarSite()
        Try
            Dim dt As New DataTable
            dt = AlmacenObj.ListarSites

            If dt.Rows.Count > 0 Then
                cmb_site.DataSource = dt
                cmb_site.ValueMember = "sit_idsite"
                cmb_site.DisplayMember = "sit_nombre"
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub CargarSitePicking()
        Try
            Dim dt As New DataTable
            dt = AlmacenObj.ListarSites

            If dt.Rows.Count > 0 Then
                cmb_SitePicking.DataSource = dt
                cmb_SitePicking.ValueMember = "sit_idsite"
                cmb_SitePicking.DisplayMember = "sit_nombre"
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub ComplementoDespacho_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargaInicial()
    End Sub

    Private Sub Aceptar()
        Try
            idCosto = CType(Cmb_Costos.SelectedValue.ToString, Integer)
            idsiteliqu = CType(cmb_site.SelectedValue.ToString, Integer)
            idsitePicking = CType(cmb_SitePicking.SelectedValue.ToString, Integer)
            If ValidarAceptar() Then

                Comentario = RichTextBox1.Text.ToString.Trim
                Grabado = True
                Me.Close()
            Else
                MsgBox("Existen Errores, Valide e intente nuevamente", MsgBoxStyle.Exclamation, "SISTEMAS NORDCI")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Function ValidarAceptar() As Boolean
        Dim rp As Boolean = True
        Try
            ErrorProvider1.SetError(Cmb_Costos, "")
            If idCosto = 0 Then
                ErrorProvider1.SetError(Cmb_Costos, "Seleccione Centro de Costos")
                rp = False
            End If

            ErrorProvider1.SetError(cmb_fisico, "")
            If cmb_fisico.Text = "" Then
                ErrorProvider1.SetError(cmb_fisico, "Seleccione Fisico")
                rp = False
            End If

        Catch ex As Exception
            Throw ex
        End Try
        Return rp
    End Function



End Class