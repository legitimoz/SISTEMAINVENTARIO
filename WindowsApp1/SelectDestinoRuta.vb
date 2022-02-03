Public Class SelectDestinoRuta
    Public Origen As String
    Public Destino As String
    Public grabado As Boolean = False
    Private Sub SelectDestinoRuta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargaInicial()
    End Sub

    Private Sub CargaInicial()
        Try
            If Origen = "NORTE" Then
                cmbo_destino.Items.Add("SUR")
                cmbo_destino.Items.Add("CENTRO")
                cmbo_destino.Items.Add("OESTE")
                cmbo_destino.Items.Add("OESTE1")
                cmbo_destino.SelectedIndex = 0
            Else
                If Origen = "SUR" Then
                    cmbo_destino.Items.Add("NORTE")
                    cmbo_destino.Items.Add("CENTRO")
                    cmbo_destino.Items.Add("OESTE")
                    cmbo_destino.Items.Add("OESTE1")
                    cmbo_destino.SelectedIndex = 0
                Else
                    If Origen = "CENTRO" Then
                        cmbo_destino.Items.Add("NORTE")
                        cmbo_destino.Items.Add("SUR")
                        cmbo_destino.Items.Add("OESTE")
                        cmbo_destino.Items.Add("OESTE1")
                        cmbo_destino.SelectedIndex = 0
                    Else
                        If Origen = "OESTE" Then
                            cmbo_destino.Items.Add("NORTE")
                            cmbo_destino.Items.Add("SUR")
                            cmbo_destino.Items.Add("CENTRO")
                            cmbo_destino.Items.Add("OESTE1")
                            cmbo_destino.SelectedIndex = 0
                        Else
                            If Origen = "OESTE1" Then
                                cmbo_destino.Items.Add("NORTE")
                                cmbo_destino.Items.Add("SUR")
                                cmbo_destino.Items.Add("CENTRO")
                                cmbo_destino.Items.Add("OESTE")
                                cmbo_destino.SelectedIndex = 0
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If MessageBox.Show("Moverá Rutas de " + Origen + " A " + cmbo_destino.Text + " . ¿Desea Continuar?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                Destino = cmbo_destino.Text
                grabado = True
                Me.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class