Imports Nordic.Bl.Be

Public Class frmObservacionPedido

    Public codigo As String
    Public numped As String
    Public cliente As String
    Public flagObser As String
    Public idUser As String
    Public idObs As String


    Private Sub frmObservacionPedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            If flagObser = "N" Then

                txtCodigo.Text = codigo
                txtNumPedido.Text = numped
                txtCliente.Text = cliente

                rtbObservacion.Enabled = True
                rtbObservacion.Text = ""
                btnGuardar.Enabled = True
                btnCancelar.Enabled = True

                rtbObservacion.Focus()
            Else

                If flagObser = "L" Then

                    Dim objObs As New BeObservacion
                    Dim dt As New DataTable

                    dt = objObs.Obtener_Observacion(idObs)

                    txtCodigo.Text = dt.Rows(0).Item(0).ToString
                    txtNumPedido.Text = dt.Rows(0).Item(1).ToString
                    txtCliente.Text = dt.Rows(0).Item(2).ToString
                    rtbObservacion.Text = dt.Rows(0).Item(3).ToString

                    rtbObservacion.ReadOnly = True
                    btnGuardar.Enabled = False
                    btnCancelar.Enabled = True
                End If
            End If


        Catch ex As Exception

        End Try
    End Sub





    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Try
            Me.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim objObs As New BeObservacion
            Dim filasAfec As Integer

            objObs.prObservacion = rtbObservacion.Text
            objObs.prcodigoPedido = txtCodigo.Text
            objObs.prnumeroPedido = txtNumPedido.Text
            objObs.pridUser = idUser

            If rtbObservacion.Text = "" Then
                MessageBox.Show("Ingrese su Observación", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                rtbObservacion.Focus()
            Else
                filasAfec = objObs.Registrar_Observacion_Pedido(objObs.prObservacion, objObs.prcodigoPedido, objObs.prnumeroPedido, objObs.pridUser)

                If filasAfec > 0 Then
                    MessageBox.Show("Registro Satisfactorio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Me.Close()
                Else
                    MessageBox.Show("Error en el Registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Me.Close()

                End If

            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub rtbObservacion_TextChanged(sender As Object, e As EventArgs) Handles rtbObservacion.TextChanged
        Try
            Dim cantidad As Integer = rtbObservacion.Text.Length
            If cantidad < 500 Then
                '    lblCantAnalisisVenta.Text = cantidad
                '    lblCantAnalisisVenta.ForeColor = Color.Red
                '    Label45.ForeColor = Color.Red
                'ElseIf cantidad >= 100 Then
                lblCantAnalisisVenta.Text = cantidad
                lblCantAnalisisVenta.ForeColor = Color.Green
                Label45.ForeColor = Color.Green
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub rtbObservacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rtbObservacion.KeyPress
        Try
            e.KeyChar = Char.ToUpper(e.KeyChar)
        Catch ex As Exception

        End Try
    End Sub
End Class