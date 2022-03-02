Imports System.Configuration
Imports Nordic.Bl.Be

Public Class GestionGuiasRotulos
    Private dtcabecera As New DataTable
    Public Estructura As New EstructuraTabla
    Public usr_id As Integer
    Public usr_usuario As String
    Private ObjAlmacen As New AlmacenL
    Private Sub GestionGuiasRotulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargaInicial()
    End Sub

#Region "Metodos"

    Private Sub CargaInicial()
        Try
            Me.Text = "Impresión Rotulos Provincia"
            Cargar_Transportistas()
            FormatoTablaCabecera()
            ListarGuiasCabecera()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Buscar()
        Dim dtbusqueda As New DataTable
        Try
            Dim stringfiltro As String = ""
            stringfiltro = String.Format("C5_CNUMDOC LIKE '%{0}%' ", txt_numero.Text)
            dtcabecera.DefaultView.RowFilter = stringfiltro
        Catch ex As Exception
            Throw ex
            MsgBox(Constantes.MensajeErrorServer, MsgBoxStyle.Critical)
        End Try
    End Sub


    Sub Cargar_Transportistas()
        Try

            Dim objGuia As New BeGuias
            Dim dt As New DataTable

            dt = ObjAlmacen.Obtener_Transportistas_paraRotulos()

            cmb_transportistas.DataSource = dt
            cmb_transportistas.ValueMember = "TR_CCODIGO"
            cmb_transportistas.DisplayMember = "TR_CNOMBRE"

        Catch ex As Exception
            MessageBox.Show(ex.Message, "NORDIC", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Function LlamarListarGuiasRotulos() As DataTable
        Dim dtretorno As New DataTable
        Try
            If cmb_transportistas.SelectedIndex = 0 Then
                dtretorno = ObjAlmacen.Obtener_Guia_Impresion_Rotulos("0", dt_desde.Value.ToShortDateString, dt_hasta.Value.ToShortDateString, "")
            Else
                If cmb_transportistas.SelectedIndex <> 0 Then
                    dtretorno = ObjAlmacen.Obtener_Guia_Impresion_Rotulos("1", dt_desde.Value.ToShortDateString, dt_hasta.Value.ToShortDateString, cmb_transportistas.SelectedValue)
                End If
            End If
            Return dtretorno
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub ListarGuiasCabecera()
        Try
            Dim dtretorno As New DataTable
            dtretorno = LlamarListarGuiasRotulos()
            If dtretorno.Rows.Count > 0 Then
                dtcabecera.Rows.Clear()
                For Each RowRetorno As DataRow In dtretorno.Rows
                    Dim rowcabecera As DataRow
                    rowcabecera = dtcabecera.NewRow

                    rowcabecera.Item("MARCAR") = False
                    rowcabecera.Item("C5_CALMA") = RowRetorno.Item("C5_CALMA").ToString.Trim
                    rowcabecera.Item("C5_CTD") = RowRetorno.Item("C5_CTD").ToString.Trim
                    rowcabecera.Item("C5_CNUMDOC") = RowRetorno.Item("C5_CNUMDOC").ToString.Trim
                    rowcabecera.Item("C5_CCODTRA") = RowRetorno.Item("C5_CCODTRA").ToString.Trim
                    rowcabecera.Item("C5_CNOMTRA") = RowRetorno.Item("C5_CNOMTRA").ToString.Trim
                    rowcabecera.Item("drg_fecSalidaRuta") = RowRetorno.Item("drg_fecSalidaRuta").ToString.Trim
                    rowcabecera.Item("C5_CNOMCLI") = RowRetorno.Item("C5_CNOMCLI").ToString.Trim
                    rowcabecera.Item("C5_CDIRENV") = RowRetorno.Item("C5_CDIRENV").ToString.Trim
                    rowcabecera.Item("DE_CPROV") = RowRetorno.Item("DE_CPROV").ToString.Trim
                    rowcabecera.Item("DE_CDEPT") = RowRetorno.Item("DE_CDEPT").ToString.Trim
                    rowcabecera.Item("TG_CDESCRI") = RowRetorno.Item("TG_CDESCRI").ToString.Trim
                    rowcabecera.Item("drg_bulto") = RowRetorno.Item("drg_bulto")
                    rowcabecera.Item("IMPRESO") = RowRetorno.Item("IMPRESO").ToString.Trim
                    rowcabecera.Item("FECHA_IMP") = RowRetorno.Item("FECHA_IMP").ToString.Trim
                    rowcabecera.Item("USUARIO") = RowRetorno.Item("USUARIO").ToString.Trim

                    dtcabecera.Rows.Add(rowcabecera)

                Next
                Dg_Cabecera.DataSource = dtcabecera
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub FormatoTablaCabecera()

        dtcabecera.Clear()
        dtcabecera = Estructura.TablaCabeceraGuiaRotulo
        Dg_Cabecera.DataSource = dtcabecera

        Dg_Cabecera.Columns("MARCAR").HeaderText = "Marcar"
        Dg_Cabecera.Columns("MARCAR").Width = 50
        Dg_Cabecera.Columns("MARCAR").ReadOnly = True

        Dg_Cabecera.Columns("C5_CALMA").HeaderText = "Cod Almacen"
        Dg_Cabecera.Columns("C5_CALMA").Width = 75
        Dg_Cabecera.Columns("C5_CALMA").ReadOnly = True

        Dg_Cabecera.Columns("C5_CTD").HeaderText = "Tipo Documento"
        Dg_Cabecera.Columns("C5_CTD").Width = 80
        Dg_Cabecera.Columns("C5_CTD").ReadOnly = True
        Dg_Cabecera.Columns("C5_CTD").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_Cabecera.Columns("C5_CNUMDOC").HeaderText = "N° Documento"
        Dg_Cabecera.Columns("C5_CNUMDOC").Width = 100
        Dg_Cabecera.Columns("C5_CNUMDOC").ReadOnly = True
        Dg_Cabecera.Columns("C5_CNUMDOC").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_Cabecera.Columns("C5_CCODTRA").Visible = False
        Dg_Cabecera.Columns("C5_CNOMTRA").Visible = False

        Dg_Cabecera.Columns("drg_fecSalidaRuta").HeaderText = "Fecha Salida Ruta"
        Dg_Cabecera.Columns("drg_fecSalidaRuta").Width = 80
        Dg_Cabecera.Columns("drg_fecSalidaRuta").ReadOnly = True
        Dg_Cabecera.Columns("drg_fecSalidaRuta").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_Cabecera.Columns("C5_CNOMCLI").HeaderText = "CLIENTE"
        Dg_Cabecera.Columns("C5_CNOMCLI").Width = 250
        Dg_Cabecera.Columns("C5_CNOMCLI").ReadOnly = True
        Dg_Cabecera.Columns("C5_CNOMCLI").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_Cabecera.Columns("C5_CDIRENV").HeaderText = "DIRECCION CLIENTE"
        Dg_Cabecera.Columns("C5_CDIRENV").Width = 300
        Dg_Cabecera.Columns("C5_CDIRENV").ReadOnly = True
        Dg_Cabecera.Columns("C5_CDIRENV").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_Cabecera.Columns("DE_CPROV").HeaderText = "PROVINCIA"
        Dg_Cabecera.Columns("DE_CPROV").Width = 100
        Dg_Cabecera.Columns("DE_CPROV").ReadOnly = True
        Dg_Cabecera.Columns("DE_CPROV").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_Cabecera.Columns("DE_CDEPT").HeaderText = "DEPARTAMENTO"
        Dg_Cabecera.Columns("DE_CDEPT").Width = 100
        Dg_Cabecera.Columns("DE_CDEPT").ReadOnly = True
        Dg_Cabecera.Columns("DE_CDEPT").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_Cabecera.Columns("TG_CDESCRI").Visible = False

        Dg_Cabecera.Columns("drg_bulto").HeaderText = "CANT. BULTOS"
        Dg_Cabecera.Columns("drg_bulto").Width = 80
        Dg_Cabecera.Columns("drg_bulto").ReadOnly = True
        Dg_Cabecera.Columns("drg_bulto").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_Cabecera.Columns("IMPRESO").HeaderText = "IMPRESO"
        Dg_Cabecera.Columns("IMPRESO").Width = 80
        Dg_Cabecera.Columns("IMPRESO").ReadOnly = True
        Dg_Cabecera.Columns("IMPRESO").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_Cabecera.Columns("FECHA_IMP").HeaderText = "FECHA IMPRESION"
        Dg_Cabecera.Columns("FECHA_IMP").Width = 100
        Dg_Cabecera.Columns("FECHA_IMP").ReadOnly = True
        Dg_Cabecera.Columns("FECHA_IMP").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_Cabecera.Columns("USUARIO").Visible = False

    End Sub

    Private Sub Dg_Cabecera_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dg_Cabecera.CellContentClick
        Try
            If e.RowIndex <> -1 Then
                If e.ColumnIndex = 0 Then
                    Dim row As DataGridViewRow = Dg_Cabecera.Rows(e.RowIndex)
                    row.Cells("MARCAR").Value = Not row.Cells("MARCAR").EditedFormattedValue
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txt_numero_TextChanged(sender As Object, e As EventArgs) Handles txt_numero.TextChanged
        Try
            Buscar()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub cmdVerDetalle_Click(sender As Object, e As EventArgs) Handles cmdVerDetalle.Click
        Dim numdoc, cliente, direccion, provincia, departamento, nombreempresa As String
        nombreempresa = ConfigurationManager.AppSettings("Empresa").ToString.Trim
        Dim bultos As Integer = 0
        Dim logooperador As String = ""
        Try
            If Dg_Cabecera.Rows.Count > 0 Then
                For Each rowCab As DataGridViewRow In Dg_Cabecera.Rows
                    If rowCab.Cells("MARCAR").Value = True Then
                        numdoc = rowCab.Cells("C5_CTD").EditedFormattedValue.ToString.Trim + "    " + rowCab.Cells("C5_CNUMDOC").EditedFormattedValue.ToString.Trim
                        cliente = rowCab.Cells("C5_CNOMCLI").EditedFormattedValue.ToString.Trim
                        direccion = rowCab.Cells("C5_CDIRENV").EditedFormattedValue.ToString.Trim
                        provincia = rowCab.Cells("DE_CPROV").EditedFormattedValue.ToString.Trim
                        departamento = rowCab.Cells("DE_CDEPT").EditedFormattedValue.ToString.Trim
                        bultos = CType(rowCab.Cells("drg_bulto").EditedFormattedValue.ToString, Integer)

                        Select Case nombreempresa
                            Case "NORDIC PHARMACEUTICAL COMPANY SAC"
                                logooperador = "LogoNordic"
                            Case "HEADMARK CORPORATION SAC"
                        End Select

                        If bultos > 0 Then
                            Dim bultoactual As Integer
                            Dim cadenabulto As String
                            For Index As Integer = 1 To bultos
                                bultoactual = Index
                                cadenabulto = bultoactual.ToString + " DE " + bultos.ToString
                                Dim reporte As New Demo
                                reporte.reporteRoute("EtiquetasProvincia.rdlc", numdoc, cliente, direccion, provincia, departamento, cadenabulto, logooperador)
                            Next
                        Else

                        End If
                    End If
                Next
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub cmdCerrar_Click(sender As Object, e As EventArgs) Handles cmdCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            ListarGuiasCabecera()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CheckMarcar_CheckedChanged(sender As Object, e As EventArgs) Handles CheckMarcar.CheckedChanged
        Try
            If Dg_Cabecera.Rows.Count > 0 Then
                For Each rowcab As DataGridViewRow In Dg_Cabecera.Rows
                    rowcab.Cells("MARCAR").Value = Not rowcab.Cells("MARCAR").EditedFormattedValue
                Next

            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Try
            ProcesoImpresionPronvincia()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ProcesoImpresionPronvincia()
        Dim numdoc As String = "", cliente As String = "", direccion As String = "", provincia As String = "", departamento As String = "", nombreempresa As String = ""
        Dim CadenaGuias As String = ""
        Dim bultos As Integer = 0
        Dim logooperador As String = ""
        Dim bandera As Boolean = False
        Try
            If dtcabecera.Rows.Count > 0 Then
                nombreempresa = ConfigurationManager.AppSettings("Empresa").ToString.Trim
                For Each RowCas As DataRow In dtcabecera.Rows
                    If RowCas.Item("MARCAR") = True Then
                        numdoc = RowCas.Item("C5_CTD").ToString.Trim + " " + RowCas.Item("C5_CNUMDOC").ToString.Trim
                        If CadenaGuias = "" Then
                            CadenaGuias = CadenaGuias + numdoc
                        Else
                            CadenaGuias = CadenaGuias + " - " + numdoc
                        End If
                        cliente = RowCas.Item("C5_CNOMCLI").ToString.Trim
                        direccion = RowCas.Item("C5_CDIRENV").ToString.Trim
                        provincia = RowCas.Item("DE_CPROV").ToString.Trim
                        departamento = RowCas.Item("DE_CDEPT").ToString.Trim
                        bultos = CType(RowCas.Item("drg_bulto").ToString, Integer)
                        bandera = True
                    End If
                Next

                Select Case nombreempresa
                    Case "NORDIC PHARMACEUTICAL COMPANY SAC"
                        logooperador = "LogoNordic"
                    Case "HEADMARK CORPORATION SAC"
                End Select
                If bandera = True Then
                    If bultos > 0 Then
                        Dim bultoactual As Integer
                        Dim cadenabulto As String
                        For Index As Integer = 1 To bultos
                            bultoactual = Index
                            cadenabulto = bultoactual.ToString + " DE " + bultos.ToString
                            Dim reporte As New Demo
                            reporte.reporteRoute("EtiquetasProvincia.rdlc", CadenaGuias, cliente, direccion, provincia, departamento, cadenabulto, logooperador)
                        Next
                    Else

                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

#End Region

End Class