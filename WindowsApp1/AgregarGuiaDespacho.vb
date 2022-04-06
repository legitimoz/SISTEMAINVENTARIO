Public Class AgregarGuiaDespacho
    Public grabado As Boolean = False
    Public rowRetorno As DataRow
    Public dtalmacenessoft, DtCentrosCosto As New DataTable
    Public nombrecosto As String = "", fisico As String = ""
    Public idcosto As Integer = 0, idsiteliq As Integer = 0
    Private ObjAlmacen As New AlmacenL

    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click
        Try
            Aceptar()
            cmb_fisico.SelectedIndex = 0
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Aceptar()
        Dim dtGuia As New DataTable
        Try
            ErrorProvider1.SetError(txt_numero, "")
            If txt_numero.Text = "" Then
                ErrorProvider1.SetError(txt_numero, "Debe Ingresar Numero de Guia")
            Else
                dtGuia = LlamarObtenerGuiaDespacho(combo_Almacen.SelectedValue.ToString.Trim, "GS", txt_numero.Text.Trim)
                If dtGuia.Rows.Count > 0 Then
                    grabado = True
                    rowRetorno = dtGuia.Rows(0)
                    idcosto = Cmb_Costos.SelectedValue
                    nombrecosto = Cmb_Costos.Text
                    idsiteliq = cmb_site.SelectedValue
                    fisico = cmb_fisico.Text.Trim
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function LlamarObtenerGuiaDespacho(calma As String, ctd As String, cnumdoc As String) As DataTable
        Dim dtreotno As New DataTable
        Try
            dtreotno = ObjAlmacen.ObtenerGuiaProgramacion(calma, ctd, cnumdoc)
        Catch ex As Exception
            Throw ex
        End Try
        Return dtreotno

    End Function

    Private Sub CargaInicial()
        Try
            CargarSite()
            CargarCentrosCosto()
            ListarAlmacenSoftcom()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarSite()
        Try
            Dim dt As New DataTable
            dt = ObjAlmacen.ListarSites
            If dt.Rows.Count > 0 Then
                cmb_site.DataSource = dt
                cmb_site.ValueMember = "sit_idsite"
                cmb_site.DisplayMember = "sit_nombre"
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub AgregarGuiaDespacho_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CargaInicial()
            Me.combo_Almacen.SelectedIndex = 0
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Function LlamarListarAlmacenesSoft() As DataTable

        Dim dtretono As DataTable
        Try
            dtretono = ObjAlmacen.ListarAlmacenesSoftcom().Copy
        Catch ex As Exception
            Throw ex
        End Try
        Return dtretono
    End Function

    Private Sub CargarCentrosCosto()
        Try
            DtCentrosCosto = ObjAlmacen.SP_OBTENER_COSTOS
            If DtCentrosCosto.Rows.Count > 0 Then
                Cmb_Costos.DataSource = DtCentrosCosto
                Cmb_Costos.DisplayMember = "nombre"
                Cmb_Costos.ValueMember = "idcliente"
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ListarAlmacenSoftcom()
        Try
            Dim dtretorno As New DataTable
            dtretorno = LlamarListarAlmacenesSoft()

            If dtretorno.Rows.Count > 0 Then
                dtalmacenessoft.Rows.Clear()
                dtalmacenessoft = dtretorno.Clone
                For Each RowRetorno As DataRow In dtretorno.Rows
                    Dim rowcabecera As DataRow
                    rowcabecera = dtalmacenessoft.NewRow
                    rowcabecera.Item("A1_CALMA") = RowRetorno.Item("A1_CALMA").ToString.Trim
                    rowcabecera.Item("A1_CDESCRI") = RowRetorno.Item("A1_CDESCRI").ToString.Trim
                    dtalmacenessoft.Rows.Add(rowcabecera)
                Next
                combo_Almacen.DataSource = dtalmacenessoft
                combo_Almacen.DisplayMember = "A1_CDESCRI"
                combo_Almacen.ValueMember = "A1_CALMA"
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class