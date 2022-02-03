Public Class ObservacionPosicionForm
    Public idsite, idrack, idalmacen, idposicion, userid As Integer
    Public almacen, sitenombre, codposicion, numeracion As String
    Public CodAlma, codNumero, tipodoc, CodArticulo, lote, respuesta As String
    Public cantidad, ocupado, cajas, cajasmaster As Decimal
    Private ObjAlmacen As New AlmacenL
    Private dtconceptos As New DataTable
    Public grabado As Boolean = False

    Public Function LlamarRegistrar() As Integer
        Try
            Return ObjAlmacen.RegistrarObservacionPosicion(idalmacen, cajas, cajasmaster, idrack, userid, idposicion, idsite, 8, cmb_Conceptos.SelectedValue, CodAlma, codNumero, tipodoc, CodArticulo, lote, cantidad, ocupado, "E", respuesta)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click
        Try
            Aceptar()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ObservacionPosicionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargaInicial()
    End Sub

    Private Function ValidarAceptar() As Boolean
        Dim rp As Boolean = True
        Try
            ErrorProvider1.SetError(cmb_Conceptos, "")
            If cmb_Conceptos.SelectedIndex = 0 Then
                rp = False
                ErrorProvider1.SetError(cmb_Conceptos, "Seleccione Concepto de Observacion")
            End If
        Catch ex As Exception

        End Try
        Return rp
    End Function

    Private Sub Aceptar()
        Try
            If ValidarAceptar() = True Then
                'If MessageBox.Show("¿Desea Enviar Articulo a Almacen de Diferencia?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                '    respuesta = "SI"
                'Else
                '    respuesta = "NO"
                'End If
                respuesta = "NO"
                If LlamarRegistrar() <> 0 Then
                    MsgBox("Observacion Registrada Correctamente", MsgBoxStyle.Information)
                    grabado = True
                    Me.Close()
                Else
                    MsgBox("Observacion No Registrada, Contactar con el Area de Sistemas", MsgBoxStyle.Critical)
                End If
            Else
                MsgBox("Existen Errores Valide", MsgBoxStyle.Exclamation, "")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargaInicial()
        Try
            If idsite <> 0 And idrack <> 0 And idalmacen <> 0 And idposicion <> 0 Then
                txt_almacen.Text = almacen
                txt_site.Text = sitenombre
                txt_posicion.Text = codposicion
                txt_rack.Text = numeracion
                ListarConceptos()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function LlamarListarConceptosObservacion() As DataTable

        Dim dtretono As DataTable
        Try
            dtretono = ObjAlmacen.ListarConceptosObservacion().Copy
        Catch ex As Exception
            Throw ex
        End Try
        Return dtretono

    End Function

    Public Sub ListarConceptos()
        Try

            Dim dtretorno As New DataTable
            dtretorno = LlamarListarConceptosObservacion()

            If dtretorno.Rows.Count > 0 Then

                dtconceptos.Rows.Clear()
                dtconceptos = dtretorno.Clone

                Dim rowalma As DataRow
                rowalma = dtconceptos.NewRow
                rowalma.Item("con_idconcepto") = "00"
                rowalma.Item("descripcion") = "TODOS"
                dtconceptos.Rows.Add(rowalma)

                For Each RowRetorno As DataRow In dtretorno.Rows
                    Dim rowcabecera As DataRow
                    rowcabecera = dtconceptos.NewRow
                    rowcabecera.Item("descripcion") = RowRetorno.Item("descripcion").ToString.Trim
                    rowcabecera.Item("con_idconcepto") = RowRetorno.Item("con_idconcepto").ToString.Trim

                    dtconceptos.Rows.Add(rowcabecera)
                Next
                cmb_Conceptos.DataSource = dtconceptos
                cmb_Conceptos.DisplayMember = "descripcion"
                cmb_Conceptos.ValueMember = "con_idconcepto"
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class