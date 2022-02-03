
Imports System.Configuration
Imports Nordic.Bl.Be

Public Class Form1
    ' Public userid As Integer
    Private dtAlmacenes, dtRacks As New DataTable
    Private ObjAlmacen As New AlmacenL
    Private Estructura As New EstructuraTabla
    Public usr_id, idrack, X, Y, Numeracion As Integer
    Private idalmacen, idsite As Integer
    Private nombrealmacen As String
    Public usr_usuario, sitenombre As String
    Dim codalmacen As String = String.Empty
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Public Function LlamarListarAlmacenes(ByVal idsite As Integer, ByVal codalmacen As String) As DataTable

        Dim dtretono As DataTable
        Try
            dtretono = ObjAlmacen.ListarAlmacenes(idsite, codalmacen).Copy
        Catch ex As Exception
            Throw ex
        End Try
        Return dtretono
    End Function

    Public Sub ListarAlmacenes()
        Dim idsite As Integer = 0
        idsite = ConfigurationManager.AppSettings("CodigoSite").ToString.Trim
        codalmacen = ConfigurationManager.AppSettings("CodigoAlmacen").ToString.Trim

        Try
            dtAlmacenes = LlamarListarAlmacenes(idsite, codalmacen)
            If dtAlmacenes.Rows.Count > 0 Then
                DGAlmacenes.DataSource = dtAlmacenes
            End If
        Catch ex As Exception
            Throw ex
            MsgBox(Constantes.MensajeErrorServer, MsgBoxStyle.Critical)
        End Try

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

    Public Function LlamarListarRacks() As DataTable
        Dim dtretono As DataTable
        Try
            dtretono = ObjAlmacen.ListarRacks(idalmacen).Copy
        Catch ex As Exception
            Throw ex
        End Try
        Return dtretono
    End Function

    Public Sub CargaInicial()
        Try
            FormatoTablaDataGridRack()
            FormatoTablaDataGrid()
            ListarAlmacenes()
        Catch ex As Exception

        End Try
    End Sub

    Public Sub Obtener()
        Try
            If DGAlmacenes.Rows.Count > 0 Then
                idalmacen = CType(DGAlmacenes.CurrentRow.Cells("alm_idalmacen").EditedFormattedValue.ToString, Integer)
                idsite = CType(DGAlmacenes.CurrentRow.Cells("alm_idsite").EditedFormattedValue.ToString, Integer)
                nombrealmacen = DGAlmacenes.CurrentRow.Cells("alm_nombrealmacen").EditedFormattedValue.ToString
                sitenombre = DGAlmacenes.CurrentRow.Cells("sit_nombre").EditedFormattedValue.ToString
            End If
        Catch ex As Exception

        End Try
    End Sub
    Public Sub FormatoTablaDataGridRack()

        DGRacks.DataSource = Nothing
        dtRacks.Rows.Clear()
        dtRacks = Estructura.GestioRacknAlmacen().Clone
        DGRacks.DataSource = dtRacks

        DGRacks.Columns("ra_idRack").Visible = False


        DGRacks.Columns("ra_numeracion").HeaderText = "NUMERO DE RACK"
        DGRacks.Columns("ra_numeracion").Width = 100
        DGRacks.Columns("ra_numeracion").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        DGRacks.Columns("ra_cantidadx").HeaderText = "CANTIDAD COLUMNAS"
        DGRacks.Columns("ra_cantidadx").Width = 100
        DGRacks.Columns("ra_cantidadx").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        DGRacks.Columns("ra_cantidady").HeaderText = "CANTIDAD FILAS"
        DGRacks.Columns("ra_cantidady").Width = 100
        DGRacks.Columns("ra_cantidady").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

    End Sub
    Public Sub FormatoTablaDataGrid()

        DGAlmacenes.DataSource = Nothing
        dtAlmacenes.Rows.Clear()
        dtAlmacenes = Estructura.GestionAlmacen.Clone
        DGAlmacenes.DataSource = dtAlmacenes

        DGAlmacenes.Columns("alm_idalmacen").Visible = False


        DGAlmacenes.Columns("alm_nombrealmacen").HeaderText = "BODEGAS"
        DGAlmacenes.Columns("alm_nombrealmacen").Width = 200
        DGAlmacenes.Columns("alm_nombrealmacen").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        DGAlmacenes.Columns("sit_nombre").HeaderText = "SITE"
        DGAlmacenes.Columns("sit_nombre").Width = 300
        DGAlmacenes.Columns("sit_nombre").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        DGAlmacenes.Columns("alm_idsite").Visible = False


    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Try
            Obtener()
            If idalmacen <> 0 And idsite <> 0 Then
                Dim FormGestionRack As New IngresoExcepcionalForm
                FormGestionRack.Text = "Ingreso Excepcional Masivo"
                FormGestionRack.idsite = idsite
                FormGestionRack.nombrealmacen = nombrealmacen
                FormGestionRack.nombreSite = sitenombre
                FormGestionRack.idalmacen = idalmacen
                FormGestionRack.userid = usr_id
                FormGestionRack.ShowDialog()
            Else
                MsgBox("Seleccione Almacen Antes", MsgBoxStyle.Exclamation)
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdVerReporte_Click(sender As Object, e As EventArgs) Handles cmdVerReporte.Click
        Try
            Obtener()
            If idalmacen <> 0 Then
                Dim ReporteMov As New ReporteMovimientosAlmacen
                ReporteMov.idalmacen = idalmacen
                ReporteMov.almacen = nombrealmacen
                ReporteMov.sitenombre = sitenombre
                ReporteMov.Show()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CargaInicial()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub cmd_Racks_Click(sender As Object, e As EventArgs) Handles cmd_Racks.Click
        Obtener()

        If idalmacen <> 0 Then
            Dim FormGestionRack As New GestionRacks
            FormGestionRack.Text = "Gestion Racks Almacen"
            FormGestionRack.idalmacen = idalmacen
            FormGestionRack.nombrealmacen = nombrealmacen
            FormGestionRack.CodigoAlmacen = codalmacen
            FormGestionRack.userid = usr_id
            FormGestionRack.ShowDialog()
        Else
            MsgBox("Seleccione Almacen", "Mensaje", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub DGAlmacenes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGAlmacenes.CellClick
        Try
            Obtener()
            If idalmacen <> 0 Then
                ListarRacks()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Sub ObtenerRack()
        Try
            If DGRacks.Rows.Count > 0 Then
                idrack = CType(DGRacks.CurrentRow.Cells("ra_idRack").EditedFormattedValue.ToString, Integer)
                Numeracion = CType(DGRacks.CurrentRow.Cells("ra_numeracion").EditedFormattedValue.ToString, Integer)
                X = CType(DGRacks.CurrentRow.Cells("ra_cantidadx").EditedFormattedValue.ToString, Integer)
                Y = CType(DGRacks.CurrentRow.Cells("ra_cantidady").EditedFormattedValue.ToString, Integer)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnRegistrarIngreso_Click(sender As Object, e As EventArgs) Handles btnRegistrarIngreso.Click
        ObtenerRack()
        If idrack <> 0 Then
            Dim FormGestionRack As New GestionPartesEntrada
            FormGestionRack.Text = "Lista Partes de Entrada Pendientes de Ingreso"
            FormGestionRack.idsite = idsite
            FormGestionRack.idRack = idrack
            FormGestionRack.nombrealmacen = nombrealmacen
            FormGestionRack.nombreSite = sitenombre
            FormGestionRack.idalmacen = idalmacen
            FormGestionRack.Numeracion = Numeracion
            FormGestionRack.X = X
            FormGestionRack.Y = Y
            FormGestionRack.userid = usr_id
            FormGestionRack.ShowDialog()
        Else
            MsgBox("Seleccione Rack", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click

    End Sub
End Class
