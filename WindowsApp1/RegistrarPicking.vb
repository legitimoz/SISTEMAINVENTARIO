Public Class RegistrarPicking

    Private Almacenobj As New AlmacenL
    Private dtpicador, dtfiltro As New DataTable
    Public grabado As Boolean = False
    Public idpicador As Integer = 0
    Public idfiltro As Integer = 0
    Public nrodocM As String
    Private Sub RegistrarPicking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargaInicial()
    End Sub


    Private Sub CargaInicial()
        Try
            LlenarCombos()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click
        Try
            If dtfiltro.Rows.Count > 0 And dtpicador.Rows.Count > 0 Then
                If MessageBox.Show("Está seguro que el picador " + cmb_picador.Text + " y el Filtro " + cmb_filtro.Text + " es el correcto para la guia " + nrodocM + " ?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    idfiltro = cmb_filtro.SelectedValue
                    idpicador = cmb_picador.SelectedValue
                    If idfiltro <> 0 And idpicador <> 0 Then
                        grabado = True
                        Me.Close()
                    End If
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LlenarCombos()
        Try
            Dim dtpicadores, dtfiltros As DataTable
            dtpicadores = Almacenobj.ListarPicadores
            dtfiltros = Almacenobj.ListarPicadores

            If dtpicadores.Rows.Count > 0 Then
                dtpicador = dtpicadores
                cmb_picador.DataSource = dtpicador
                cmb_picador.DisplayMember = "pic_nombrepicador"
                cmb_picador.ValueMember = "pic_idpicador"
            End If

            If dtfiltros.Rows.Count > 0 Then
                dtfiltro = dtfiltros
                cmb_filtro.DataSource = dtfiltro
                cmb_filtro.DisplayMember = "pic_nombrepicador"
                cmb_filtro.ValueMember = "pic_idpicador"
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class