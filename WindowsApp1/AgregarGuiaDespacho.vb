Public Class AgregarGuiaDespacho
    Public grabado As Boolean = False
    Public rowRetorno As DataRow
    Public dtalmacenessoft As New DataTable
    Private ObjAlmacen As New AlmacenL

    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click
        Try
            Aceptar()
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
            ListarAlmacenSoftcom()
        Catch ex As Exception
            Throw ex
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