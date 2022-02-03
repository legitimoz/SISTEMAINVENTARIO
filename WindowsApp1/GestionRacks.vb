

Imports Nordic.Bl.Be

Public Class GestionRacks
    Public idalmacen, idrack, X, Y As Integer
    Public userid As Integer
    Private dtRacks As New DataTable
    Private ObjAlmacen As New AlmacenL
    Private Estructura As New EstructuraTabla
    Public nombrealmacen, CodigoAlmacen, numeracion As String

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub GestionRacks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargaInicial()
    End Sub

    Public Sub CargaInicial()
        Try
            txt_almacen.Text = nombrealmacen
            FormatoTablaDataGrid()
            ListarRacks()

        Catch ex As Exception

        End Try
    End Sub
    Public Function LlamarListarRacks() As DataTable

        Dim dtretono As DataTable
        Try
            dtretono = ObjAlmacen.ListarRacks(idalmacen).Copy
        Catch ex As Exception
            Throw ex
        End Try
        Return dtretono
    End Function

    Private Sub cmd_Posiciones_Click(sender As Object, e As EventArgs) Handles cmd_Posiciones.Click
        Obtener()
        If idrack <> 0 Then
            Dim FormGestionRack As New GestionPosiciones
            FormGestionRack.idRack = idrack
            FormGestionRack.Accion = "GESTION"
            FormGestionRack.nombrealmacen = nombrealmacen
            FormGestionRack.Numeracion = CType(numeracion, Integer)
            FormGestionRack.idalmacen = idalmacen
            FormGestionRack.userid = userid
            FormGestionRack.X = X
            FormGestionRack.Y = Y
            FormGestionRack.ShowDialog()
        Else
            MsgBox("Seleccione Rack", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        Try
            Dim FormRegistrarRack As New EditarRack
            FormRegistrarRack.Text = "Nuevo Rack"
            FormRegistrarRack.idalmacen = idalmacen
            FormRegistrarRack.codigoalmacen = CodigoAlmacen
            FormRegistrarRack.ShowDialog()
            If FormRegistrarRack.grabado = True Then
                ListarRacks()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Obtener()

        If idrack <> 0 Then
            Dim FormGestionRack As New GestionPartesEntrada
            FormGestionRack.idRack = idrack
            FormGestionRack.ShowDialog()
        Else
            MsgBox("Seleccione Rack", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Public Sub ListarRacks()
        Try
            dtRacks = LlamarListarRacks()
            If dtRacks.Rows.Count > 0 Then
                DGRacks.DataSource = dtRacks
            End If
        Catch ex As Exception
            Throw ex
            MsgBox(Constantes.MensajeErrorServer, MsgBoxStyle.Critical)
        End Try

    End Sub

    Public Sub Obtener()
        Try
            If DGRacks.Rows.Count > 0 Then
                idrack = CType(DGRacks.CurrentRow.Cells("ra_idRack").EditedFormattedValue.ToString, Integer)
                X = CType(DGRacks.CurrentRow.Cells("ra_cantidadx").EditedFormattedValue.ToString, Integer)
                Y = CType(DGRacks.CurrentRow.Cells("ra_cantidady").EditedFormattedValue.ToString, Integer)
                numeracion = DGRacks.CurrentRow.Cells("ra_numeracion").EditedFormattedValue.ToString
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Sub FormatoTablaDataGrid()

        DGRacks.DataSource = Nothing
        dtRacks.Rows.Clear()
        dtRacks = Estructura.GestioRacknAlmacen().Clone
        DGRacks.DataSource = dtRacks

        DGRacks.Columns("ra_idRack").Visible = False

        DGRacks.Columns("ra_numeracion").HeaderText = "NUMERACION"
        DGRacks.Columns("ra_numeracion").Width = 100
        DGRacks.Columns("ra_numeracion").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        DGRacks.Columns("ra_cantidadx").HeaderText = "CANTIDAD COLUMNAS"
        DGRacks.Columns("ra_cantidadx").Width = 100
        DGRacks.Columns("ra_cantidadx").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        DGRacks.Columns("ra_cantidady").HeaderText = "CANTIDAD FILAS"
        DGRacks.Columns("ra_cantidady").Width = 100
        DGRacks.Columns("ra_cantidady").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter


    End Sub
End Class