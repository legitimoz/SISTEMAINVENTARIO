Imports Nordic.Bl.Be

Public Class TrasladoEntreUbicaciones
    Public idPosicion As Integer
    Public idsite As Integer = 0
    Public idalmacen As Integer
    Public idRack As Integer
    Public dtRacks, dtposiciones, dt_operaciones As New DataTable
    Public numeracion As Integer
    Public codposicion As String
    Private almacenobj As New AlmacenL
    Private ObjAlmacen As New AlmacenL
    Private Estructura As New EstructuraTabla
    Public userid As Integer

    Public Function LlamarListarRacks() As DataTable
        Try
            Dim dtretorno As New DataTable
            dtretorno = almacenobj.ListarRacks(idalmacen)
            Return dtretorno
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function LlamarListarUbicacion() As DataTable
        Try
            Dim dtretorno As New DataTable
            dtretorno = almacenobj.ListarUbicacionesXSite_Almacen(idsite, idalmacen)
            Return dtretorno
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub TrasladoEntreUbicaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargaInicial()
    End Sub

    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click
        Try
            Aceptar()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function LlamarTransferirUbicacion(iddetalle As Integer, idrack As Integer, idubicacion As Integer, cantidad As Decimal, userid As Integer) As Integer
        Dim rp As Integer = 0
        Try
            rp = almacenobj.TrasladoUbicaciones(idrack, idubicacion, iddetalle, cantidad, userid)
            Return rp
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub Aceptar()
        Dim bandera As Boolean = False
        Dim banderaregistros As Boolean = True
        ErrorProvider1.SetError(cmdAceptar, "")
        Try
            If MessageBox.Show("Está a punto de hacer una transferencia. ¿Desea Continuar?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then

                If dt_operaciones.Rows.Count > 0 Then
                    For Each RowOp As DataRow In dt_operaciones.Rows
                        If RowOp.Item("Marcar") = True Then
                            bandera = True
                            If LlamarTransferirUbicacion(RowOp.Item("idoperacion"), cmb_Rack.SelectedValue, cmb_posiciones.SelectedValue, RowOp.Item("Cantidad"), userid) <> 0 Then
                            Else
                                banderaregistros = False
                            End If
                        Else

                        End If
                    Next
                    If bandera = False Then
                        ErrorProvider1.SetError(cmdAceptar, "Debe seleccionar al menos 1 Operacion a trasladar")
                    End If
                    If banderaregistros = True Then
                        MsgBox("Traslado Realizado Correctamente", MsgBoxStyle.Information)
                        ListarOperaciones()
                    Else
                        MsgBox("Traslado con Errores, es problable que 1 o mas operacion no a sido movido, Valide y vuelva a Intentarlo ", MsgBoxStyle.Exclamation)
                    End If

                End If
            Else

            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Function LlamarListarOperaciones() As DataTable
        Try
            Dim dt_retorno As New DataTable

            dt_retorno = almacenobj.ListarStockPosicion(idPosicion)
            Return dt_retorno
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub ListarOperaciones()
        Try
            Dim dt_retorno As New DataTable
            dt_retorno = LlamarListarOperaciones()
            Dim Rowgrid As DataRow
            dt_operaciones.Rows.Clear()
            If dt_retorno.Rows.Count > 0 Then
                For Each Rowop As DataRow In dt_retorno.Rows
                    Rowgrid = dt_operaciones.NewRow
                    Rowgrid.Item("Marcar") = False
                    Rowgrid.Item("CodArticulo") = Rowop.Item("CodArticulo")
                    Rowgrid.Item("Articulo") = Rowop.Item("Articulo")
                    Rowgrid.Item("Lote") = Rowop.Item("Lote")
                    Rowgrid.Item("Cantidad") = Rowop.Item("Cantidad")
                    Rowgrid.Item("CantidadAnterior") = Rowop.Item("Cantidad")
                    Rowgrid.Item("Operacion") = Rowop.Item("Operacion")
                    Rowgrid.Item("idoperacion") = Rowop.Item("idoperacion")
                    dt_operaciones.Rows.Add(Rowgrid)
                Next
            End If
            Dg_Operaciones.DataSource = dt_operaciones
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub FormatoTablaDataGrid()

        Dg_Operaciones.DataSource = Nothing
        dt_operaciones.Rows.Clear()
        dt_operaciones = Estructura.FormatoGridTrasferencia().Clone
        Dg_Operaciones.DataSource = dt_operaciones

        Dg_Operaciones.Columns("idoperacion").Visible = False

        Dg_Operaciones.Columns("Marcar").HeaderText = "Marcar"
        Dg_Operaciones.Columns("Marcar").Width = 40
        Dg_Operaciones.Columns("Marcar").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_Operaciones.Columns("Operacion").HeaderText = "Operacion"
        Dg_Operaciones.Columns("Operacion").Width = 100
        Dg_Operaciones.Columns("Operacion").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_Operaciones.Columns("CodArticulo").HeaderText = "Cod Articulo"
        Dg_Operaciones.Columns("CodArticulo").Width = 100
        Dg_Operaciones.Columns("CodArticulo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_Operaciones.Columns("Articulo").HeaderText = "Articulo"
        Dg_Operaciones.Columns("Articulo").Width = 100
        Dg_Operaciones.Columns("Articulo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_Operaciones.Columns("Lote").HeaderText = "Lote"
        Dg_Operaciones.Columns("Lote").Width = 100
        Dg_Operaciones.Columns("Lote").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_Operaciones.Columns("Cantidad").HeaderText = "Cantidad"
        Dg_Operaciones.Columns("Cantidad").Width = 100
        Dg_Operaciones.Columns("Cantidad").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_Operaciones.Columns("CantidadAnterior").Visible = False

    End Sub

    Private Sub CargaInicial()
        Try
            txt_rack.Text = numeracion
            txt_codigo.Text = codposicion
            ListarRacks()
            idRack = cmb_Rack.SelectedValue
            ListarUbicacion()
            FormatoTablaDataGrid()
            ListarOperaciones()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ListarRacks()
        Try
            Dim dtretorno As New DataTable
            dtretorno = LlamarListarRacks()

            If dtretorno.Rows.Count > 0 Then
                dtRacks = dtretorno
                cmb_Rack.DataSource = dtretorno
                cmb_Rack.ValueMember = "ra_idRack"
                cmb_Rack.DisplayMember = "ra_numeracion"
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Function LlamarListarPosiciones() As DataTable
        Dim dtretono As DataTable
        Try
            dtretono = almacenobj.ListarPosiciones(idRack).Copy
        Catch ex As Exception
            Throw ex
        End Try
        Return dtretono
    End Function

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_operacion.TextChanged
        Try
            Buscar()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Buscar()
        Dim dtbusqueda As New DataTable
        Try
            Dim stringfiltro As String = ""
            stringfiltro = String.Format("Operacion LIKE '%{0}%' AND CodArticulo LIKE '%{1}%' AND  Lote LIKE '%{2}%' ", txt_operacion.Text, txt_codarti.Text, txt_lote.Text)
            dt_operaciones.DefaultView.RowFilter = stringfiltro
        Catch ex As Exception
            Throw ex
            MsgBox(Constantes.MensajeErrorServer, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub txt_codarti_TextChanged(sender As Object, e As EventArgs) Handles txt_codarti.TextChanged
        Buscar()
    End Sub

    Private Sub txt_lote_TextChanged(sender As Object, e As EventArgs) Handles txt_lote.TextChanged
        Buscar()
    End Sub

    Private Sub Dg_Operaciones_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles Dg_Operaciones.CellEndEdit
        Try
            If e.RowIndex >= 0 Then
                If e.ColumnIndex = 6 Then
                    ErrorProvider1.SetError(Dg_Operaciones, "")
                    If ValidarNumerico(Dg_Operaciones.Rows(e.RowIndex).Cells(6).EditedFormattedValue.ToString) = False Then
                        ErrorProvider1.SetError(Dg_Operaciones, "Nueva Cantidad debe ser un valor numérico")
                        Dg_Operaciones.Rows(e.RowIndex).Cells(6).Value = Dg_Operaciones.Rows(e.RowIndex).Cells(7).Value
                    Else
                        Dim Nueva As Integer = CType(Dg_Operaciones.Rows(e.RowIndex).Cells(6).EditedFormattedValue, Integer)
                        Dim Anterior As Integer = CType(Dg_Operaciones.Rows(e.RowIndex).Cells(7).Value, Integer)
                        If Nueva > Anterior Then
                            ErrorProvider1.SetError(Dg_Operaciones, "Nueva Cantidad no puede superar a cantidad Anterior")
                            Dg_Operaciones.Rows(e.RowIndex).Cells(6).Value = Dg_Operaciones.Rows(e.RowIndex).Cells(7).Value
                        Else
                            If Nueva <= 0 Then
                                ErrorProvider1.SetError(Dg_Operaciones, "Nueva Cantidad debe ser mayor a 0")
                                Dg_Operaciones.Rows(e.RowIndex).Cells(6).Value = Dg_Operaciones.Rows(e.RowIndex).Cells(7).Value
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Function ValidarNumerico(Dato As String) As Boolean
        Dim canConvert As Boolean
        Try
            Dim convertido As Integer
            canConvert = Integer.TryParse(Dato, convertido)

        Catch ex As Exception

        End Try
        Return canConvert
    End Function

    Private Sub cmb_Rack_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmb_Rack.SelectionChangeCommitted
        Try
            idRack = cmb_Rack.SelectedValue
            ListarUbicacion()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ListarUbicacion()
        Try
            Dim dtretorno As New DataTable
            dtretorno = LlamarListarPosiciones()
            If dtretorno.Rows.Count > 0 Then
                dtposiciones = dtretorno
                cmb_posiciones.DataSource = dtposiciones
                cmb_posiciones.ValueMember = "esp_idespacio"
                cmb_posiciones.DisplayMember = "esp_codigoespacio"
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class