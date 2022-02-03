Imports Nordic.Bl.Be

Public Class SeleccionarPosicionesIngreso

    Private dtPosiciones As New DataTable
    Private almacenobj As New AlmacenL
    Private Estructura As New EstructuraTabla
    Public idrack As Integer
    Public grabado As Boolean
    Public posiciones As New List(Of String)
    Public codArticulo As String

    Private Sub SeleccionarPosicionesIngreso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargaInicial()
    End Sub

    Private Sub CargaInicial()
        Try
            FormatoTablaDetalle()
            ListarPosiciones()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function LlamarListarPosicionesXrack() As DataTable
        Dim dtretono As DataTable
        Try
            'dtretono = almacenobj.ListarPosiciones(17).Copy
            dtretono = almacenobj.ListarPosiciones(idrack).Copy
        Catch ex As Exception
            Throw ex
        End Try
        Return dtretono
    End Function

    Public Function LlamarListarPosicionesXCodArticulo() As DataTable
        Dim dtretono As DataTable
        Try
            dtretono = almacenobj.ListarPosicionesXArticulo(codArticulo).Copy
        Catch ex As Exception
            Throw ex
        End Try
        Return dtretono
    End Function

    Public Sub ListarPosiciones()
        Try
            Dim dtretorno As New DataTable
            dtretorno = LlamarListarPosicionesXCodArticulo()
            If dtretorno.Rows.Count > 0 Then
                dtPosiciones.Rows.Clear()
                For Each RowRetorno As DataRow In dtretorno.Rows
                    Dim rowDetalle As DataRow
                    rowDetalle = dtPosiciones.NewRow
                    rowDetalle.Item("Posicion") = RowRetorno.Item("Posicion").ToString.Trim
                    rowDetalle.Item("Seleccionado") = False
                    dtPosiciones.Rows.Add(rowDetalle)
                Next
                Dg_Posiciones.DataSource = dtPosiciones
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    'Public Sub ListarPosiciones()
    '    Try
    '        Dim dtretorno As New DataTable
    '        dtretorno = LlamarListarPosicionesXrack()
    '        If dtretorno.Rows.Count > 0 Then
    '            dtPosiciones.Rows.Clear()
    '            For Each RowRetorno As DataRow In dtretorno.Rows
    '                Dim rowDetalle As DataRow
    '                rowDetalle = dtPosiciones.NewRow
    '                rowDetalle.Item("Posicion") = RowRetorno.Item("esp_codigoespacio").ToString.Trim
    '                rowDetalle.Item("Seleccionado") = False
    '                dtPosiciones.Rows.Add(rowDetalle)
    '            Next
    '            Dg_Posiciones.DataSource = dtPosiciones
    '        End If
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Sub

    Public Sub FormatoTablaDetalle()
        dtPosiciones.Clear()
        dtPosiciones = Estructura.DetalleSeleccionPosicion
        Dg_Posiciones.DataSource = dtPosiciones

        Dg_Posiciones.Columns("Seleccionado").HeaderText = "Seleccionado"
        Dg_Posiciones.Columns("Seleccionado").Width = 155
        Dg_Posiciones.Columns("Seleccionado").ReadOnly = True
        Dg_Posiciones.Columns("Seleccionado").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_Posiciones.Columns("Posicion").HeaderText = "Ubicacion"
        Dg_Posiciones.Columns("Posicion").Width = 155
        Dg_Posiciones.Columns("Posicion").ReadOnly = True
        Dg_Posiciones.Columns("Posicion").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

    End Sub

    Private Sub Dg_Posiciones_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dg_Posiciones.CellContentClick
        Try
            If e.RowIndex <> -1 Then
                If e.ColumnIndex = 0 Then
                    Dim row As DataGridViewRow = Dg_Posiciones.Rows(e.RowIndex)
                    If row.Cells("Seleccionado").Value = True Then
                        row.Cells("Seleccionado").Value = Not row.Cells("Seleccionado").EditedFormattedValue
                    Else
                        If ConteoSeleccionados() <= 2 Then
                            row.Cells("Seleccionado").Value = Not row.Cells("Seleccionado").EditedFormattedValue
                        Else
                            MsgBox("Solo se pueden seleccionar 3 Posiciones como maximo", MsgBoxStyle.Exclamation)
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function ConteoSeleccionados() As Integer
        Dim contador As Integer = 0
        Try
            For Each RowDg As DataGridViewRow In Dg_Posiciones.Rows
                If RowDg.Cells("Seleccionado").Value = True Then
                    contador = contador + 1
                End If
            Next
        Catch ex As Exception
            Throw ex
        End Try
        Return contador
    End Function

    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click
        Aceptar()
    End Sub
    Public Sub Aceptar()
        Try
            ErrorProvider1.SetError(Dg_Posiciones, "")
            'If ConteoSeleccionados() > 0 Then
            LlenarPosicion()
                grabado = True
                Me.Close()
            'Else
            'ErrorProvider1.SetError(Dg_Posiciones, "Debe seleccionar al menos 1 Posicion")
            'MsgBox("Hay Errores, valide", MsgBoxStyle.Exclamation)
            'End If
        Catch ex As Exception

        End Try
    End Sub

    Public Sub LlenarPosicion()
        Try
            Dim contador As Integer = 0
            If Dg_Posiciones.Rows.Count > 0 Then
                For Each RowDg As DataGridViewRow In Dg_Posiciones.Rows
                    If RowDg.Cells("Seleccionado").Value = True Then
                        posiciones.Add(RowDg.Cells("Posicion").FormattedValue.ToString)
                    End If
                Next
            End If

            If posiciones.Count = 1 Then
                posiciones.Add("")
                posiciones.Add("")
            Else
                If posiciones.Count = 2 Then
                    posiciones.Add("")
                Else
                    If posiciones.Count = 0 Then
                        posiciones.Add("")
                        posiciones.Add("")
                        posiciones.Add("")
                    End If
                End If
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txt_ubicacion.Enabled = True
        Else
            txt_ubicacion.Enabled = False

        End If
    End Sub
End Class