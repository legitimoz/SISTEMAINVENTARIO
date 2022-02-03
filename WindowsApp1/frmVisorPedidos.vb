
Imports Nordic.Bl.Be

Public Class frmVisorPedidos

    Public tu_alias1 As String
    Public flagEstAccion As String
    Public idUser As String
    Public unidad_negocio As String

    Private mnuContextual As New ContextMenuStrip
    Friend WithEvents BtnLlamadaCall As System.Windows.Forms.Button


    Private Sub frmVisorPedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            unidad_negocio = "TDO"
            flagEstAccion = "T"
            cboUnidad.SelectedIndex = 0

            lblSincro.Text = "Activado"
            lblSincro.ForeColor = Color.Green

            txtTD.Enabled = False
            txtSerie.Enabled = False
            txtDocumento.Enabled = False

            txtGuia.Enabled = False
            txtDocumento.Enabled = False
            txtPedido.Enabled = False

            Timer1.Start()
            configurarMenucontextual()
            'chkTodo.Checked = True

            CargarPedidosVisor(unidad_negocio, flagEstAccion)



        Catch ex As Exception

        End Try
    End Sub




    Public Sub configurarMenucontextual()
        Try

            Dim oToolStripItem1 As New ToolStripMenuItem
            oToolStripItem1.Text = "Registrar Observacion"
            oToolStripItem1.Tag = "1"
            AddHandler oToolStripItem1.Click, AddressOf BtnLlamadaCall_Click
            mnuContextual.Items.Add(oToolStripItem1)

            dgvListarPedidos.ContextMenuStrip = mnuContextual

        Catch ex As Exception

        End Try

    End Sub



    Private Sub BtnLlamadaCall_Click(sender As Object, e As EventArgs) Handles BtnLlamadaCall.Click
        Try
            Timer1.Stop()

            Dim fila As Integer
            fila = dgvListarPedidos.CurrentRow.Index

            Dim frmObservacion As New frmObservacionPedido

            frmObservacion.idUser = idUser
            frmObservacion.codigo = dgvListarPedidos.CurrentRow.Cells.Item("F5_CCODAGE").Value
            frmObservacion.numped = dgvListarPedidos.CurrentRow.Cells.Item("F5_CNUMPED").Value
            frmObservacion.cliente = dgvListarPedidos.CurrentRow.Cells.Item("F5_CNOMBRE").Value.ToString
            frmObservacion.flagObser = "N"

            frmObservacion.ShowDialog()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvListarObservaciones_DoubleClick(sender As Object, e As EventArgs) Handles dgvListarObservaciones.DoubleClick
        Try
            Timer1.Stop()

            Dim frmObservacion As New frmObservacionPedido

            frmObservacion.flagObser = "L"
            frmObservacion.idObs = dgvListarObservaciones.CurrentRow.Cells.Item("obp_id").Value
            frmObservacion.ShowDialog()

        Catch ex As Exception

        End Try
    End Sub

    Public Sub CargarPedidosVisor(ByVal unidadNegocio As String, ByVal flaAccion As String)
        Try
            Dim objPedidos As New BePedidos
            Dim dt As New DataTable

            Dim acum As Integer = 0
            Dim acumCont As Integer = 0
            Dim acumCred As Integer = 0
            Dim contPendApr As Integer = 0
            Dim contPendFac As Integer = 0

            dgvListarPedidos.Rows.Clear()

            If flaAccion = "T" Then
                dt = objPedidos.Obtener_ListaPedidos_porAprobar2(unidadNegocio)
            Else
                If flaAccion = "PX" Then
                    dt = objPedidos.Obtener_ListaPedidos_PendienteAprobarComercial(unidadNegocio)
                Else
                    If flaAccion = "PA" Then
                        dt = objPedidos.Obtener_ListaPedidos_PendienteAprobar2(unidadNegocio)
                    Else
                        If flaAccion = "PF" Then
                            dt = objPedidos.Obtener_ListaPedidos_PendienteFacturar2(unidadNegocio)
                        Else
                            If flaAccion = "PC" Then
                                dt = objPedidos.Obtener_ListaPedidos_PendienteContados(unidadNegocio)
                            End If
                        End If
                    End If
                End If
            End If


            For i As Integer = 0 To dt.Rows.Count - 1
                dgvListarPedidos.Rows.Add(dt.Rows(i).Item("F5_CCODAGE").ToString, dt.Rows(i).Item("F5_CNUMPED").ToString, dt.Rows(i).Item("FV_CDESCRI").ToString, dt.Rows(i).Item("ORDEN_COMPRA").ToString, dt.Rows(i).Item("GUIA").ToString, dt.Rows(i).Item("FACTURA").ToString, dt.Rows(i).Item("FECHA_HORA").ToString, dt.Rows(i).Item("DIFERENCIA").ToString, dt.Rows(i).Item("DIFERENCIA").ToString & "-" & dt.Rows(i).Item("TIEMPO").ToString, dt.Rows(i).Item("TIEMPO").ToString, dt.Rows(i).Item("F5_CCODCLI").ToString, dt.Rows(i).Item("F5_CNOMBRE").ToString, dt.Rows(i).Item("F5_NIMPORT").ToString, dt.Rows(i).Item("CD_NSALDMN").ToString, dt.Rows(i).Item("CL_CDEPT").ToString, dt.Rows(i).Item("ESTADO").ToString, dt.Rows(i).Item("F5_CUSUAP").ToString, dt.Rows(i).Item("F5_DFECAPR").ToString, dt.Rows(i).Item("TU_ALIAS").ToString, dt.Rows(i).Item("TU_NOMUSU").ToString, dt.Rows(i).Item("F5_CESTADO").ToString, dt.Rows(i).Item("FV_CCODIGO").ToString, dt.Rows(i).Item("OBS").ToString, dt.Rows(i).Item("OBSERV").ToString)
                acum = acum + CInt(dt.Rows(i).Item("F5_NIMPORT").ToString)

                If dt.Rows(i).Item("FV_CCODIGO").ToString = "C01" Or dt.Rows(i).Item("FV_CCODIGO").ToString = "C06" Or dt.Rows(i).Item("FV_CCODIGO").ToString = "C07" Then
                    acumCont = acumCont + CInt(dt.Rows(i).Item("F5_NIMPORT").ToString)
                Else
                    acumCred = acumCred + CInt(dt.Rows(i).Item("F5_NIMPORT").ToString)
                End If

                If dt.Rows(i).Item("F5_CESTADO").ToString = "P" Or dt.Rows(i).Item("F5_CESTADO").ToString = "Q" Then
                    contPendApr = contPendApr + 1
                Else
                    If dt.Rows(i).Item("F5_CESTADO").ToString = "A" Then
                        contPendFac = contPendFac + 1
                    End If

                End If

            Next

            PintarRegistrosObservados()

            tslCantidad.Text = CStr(dgvListarPedidos.Rows.Count)
            tsbCantPenApr.Text = CStr(contPendApr)
            tsbPendFac.Text = CStr(contPendFac)
            tslMontoTotal.Text = acum.ToString("###,###,###.00")
            tslContado1.Text = acumCont.ToString("###,###,###.00")
            tslCredito1.Text = acumCred.ToString("###,###,###.00")

        Catch ex As Exception

        End Try
    End Sub



    Public Sub CargarPedidosVisor_Filtros(ByVal tipoFiltro As String, ByVal unidadNegocio As String, ByVal fecIni As String, ByVal fecFin As String, ByVal f5_ctd As String, ByVal f5_cnumser As String, ByVal f5_cnumdoc As String, ByVal f5_cnumped As String, ByVal c5_numdoc As String, ByVal flagCont As String)
        Try
            Dim objPedidos As New BePedidos
            Dim dt As New DataTable

            Dim acum As Integer = 0
            Dim acumCont As Integer = 0
            Dim acumCred As Integer = 0
            Dim contPendApr As Integer = 0
            Dim contPendFac As Integer = 0

            dgvListarPedidos.Rows.Clear()

            If tipoFiltro = "XF" Then
                dt = objPedidos.Obtener_ListaPedidos_PorFiltroFecha(unidadNegocio, fecIni, fecFin, flagCont)
            Else
                dt = objPedidos.Obtener_ListaPedidos_filtrosVarios(tipoFiltro, f5_ctd, f5_cnumser, f5_cnumdoc, f5_cnumped, c5_numdoc)
            End If

            If dt.Rows.Count = 0 Then
                MessageBox.Show("No se encontraron registros.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            Else
                For i As Integer = 0 To dt.Rows.Count - 1
                    dgvListarPedidos.Rows.Add(dt.Rows(i).Item("F5_CCODAGE").ToString, dt.Rows(i).Item("F5_CNUMPED").ToString, dt.Rows(i).Item("FV_CDESCRI").ToString, dt.Rows(i).Item("ORDEN_COMPRA").ToString, dt.Rows(i).Item("GUIA").ToString, dt.Rows(i).Item("FACTURA").ToString, dt.Rows(i).Item("FECHA_HORA").ToString, dt.Rows(i).Item("DIFERENCIA").ToString, dt.Rows(i).Item("DIFERENCIA").ToString & "-" & dt.Rows(i).Item("TIEMPO").ToString, dt.Rows(i).Item("TIEMPO").ToString, dt.Rows(i).Item("F5_CCODCLI").ToString, dt.Rows(i).Item("F5_CNOMBRE").ToString, dt.Rows(i).Item("F5_NIMPORT").ToString, dt.Rows(i).Item("CD_NSALDMN").ToString, dt.Rows(i).Item("CL_CDEPT").ToString, dt.Rows(i).Item("ESTADO").ToString, dt.Rows(i).Item("F5_CUSUAP").ToString, dt.Rows(i).Item("F5_DFECAPR").ToString, dt.Rows(i).Item("TU_ALIAS").ToString, dt.Rows(i).Item("TU_NOMUSU").ToString, dt.Rows(i).Item("F5_CESTADO").ToString, dt.Rows(i).Item("FV_CCODIGO").ToString, dt.Rows(i).Item("OBS").ToString, dt.Rows(i).Item("OBSERV").ToString)
                    acum = acum + CInt(dt.Rows(i).Item("F5_NIMPORT").ToString)

                    If dt.Rows(i).Item("FV_CCODIGO").ToString = "C01" Or dt.Rows(i).Item("FV_CCODIGO").ToString = "C06" Or dt.Rows(i).Item("FV_CCODIGO").ToString = "C07" Then
                        acumCont = acumCont + CInt(dt.Rows(i).Item("F5_NIMPORT").ToString)
                    Else
                        acumCred = acumCred + CInt(dt.Rows(i).Item("F5_NIMPORT").ToString)
                    End If

                    If dt.Rows(i).Item("F5_CESTADO").ToString = "P" Or dt.Rows(i).Item("F5_CESTADO").ToString = "Q" Then
                        contPendApr = contPendApr + 1
                    Else
                        If dt.Rows(i).Item("F5_CESTADO").ToString = "A" Then
                            contPendFac = contPendFac + 1
                        End If

                    End If

                Next

                PintarRegistrosObservados()

                tslCantidad.Text = CStr(dgvListarPedidos.Rows.Count)
                tsbCantPenApr.Text = CStr(contPendApr)
                tsbPendFac.Text = CStr(contPendFac)
                tslMontoTotal.Text = acum.ToString("###,###,###.00")
                tslContado1.Text = acumCont.ToString("###,###,###.00")
                tslCredito1.Text = acumCred.ToString("###,###,###.00")
            End If



        Catch ex As Exception

        End Try
    End Sub



    Public Sub PintarRegistrosObservados()
        Try
            For i As Integer = 0 To dgvListarPedidos.Rows.Count - 1

                If dgvListarPedidos.Rows(i).Cells("VAR_OBS").Value = "SI" Then
                    dgvListarPedidos.Rows(i).DefaultCellStyle.BackColor = Color.Orange

                End If

            Next

        Catch ex As Exception

        End Try

    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try

            If flagEstAccion <> "PC" Then
                CargarPedidosVisor(unidad_negocio, flagEstAccion)
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub tsbRefrescar_Click(sender As Object, e As EventArgs) Handles tsbRefrescar.Click
        Try
            lblSincro.Text = "Activado"
            lblSincro.ForeColor = Color.Green

            Timer1.Start()

            CargarPedidosVisor(unidad_negocio, flagEstAccion)
        Catch ex As Exception

        End Try
    End Sub


    Private Sub dgvListarPedidos_SelectionChanged(sender As Object, e As EventArgs) Handles dgvListarPedidos.SelectionChanged
        Try
            Dim codPro As String
            Dim numPed As String
            Dim ruc As String

            codPro = dgvListarPedidos.CurrentRow.Cells.Item("F5_CCODAGE").Value.ToString
            numPed = dgvListarPedidos.CurrentRow.Cells.Item("F5_CNUMPED").Value.ToString

            ruc = dgvListarPedidos.CurrentRow.Cells.Item("F5_CCODCLI").Value.ToString

            CargarDetalleProductos(codPro, numPed)
            CargarDetalleObservacion(codPro, numPed)
            CargarTrazabilidadPedio(codPro, numPed)
            CargarCuentasXCobrar(ruc)


        Catch ex As Exception

        End Try
    End Sub

    Public Sub CargarDetalleProductos(ByVal codPro As String, ByVal numPed As String)
        Try

            Dim dt As New DataTable
            Dim objPedidos As New BePedidos

            dt = objPedidos.ObtenerDetalleProductos(codPro, numPed)

            dgvListarDetalleProductos.DataSource = dt

            dgvListarDetalleProductos.Columns(0).Width = 50
            dgvListarDetalleProductos.Columns(1).Width = 150
            dgvListarDetalleProductos.Columns(2).Width = 150
            dgvListarDetalleProductos.Columns(3).Width = 400
            dgvListarDetalleProductos.Columns(4).Width = 100

        Catch ex As Exception

        End Try
    End Sub


    Public Sub CargarDetalleObservacion(ByVal codPro As String, ByVal numPed As String)
        Try

            Dim dt As New DataTable
            Dim objPedidos As New BePedidos

            dgvListarObservaciones.Rows.Clear()

            dt = objPedidos.ObtenerObservaciones(codPro, numPed)

            For i As Integer = 0 To dt.Rows.Count - 1
                dgvListarObservaciones.Rows.Add(dt.Rows(i).Item("obp_id").ToString, dt.Rows(i).Item("Fecha_Hora").ToString, dt.Rows(i).Item("usr_nombre").ToString, dt.Rows(i).Item("obp_descripcion").ToString)
            Next


        Catch ex As Exception

        End Try
    End Sub


    Public Sub CargarTrazabilidadPedio(ByVal codPro As String, ByVal numPed As String)
        Try

            Dim dt As New DataTable
            Dim objPedidos As New BePedidos


            dt = objPedidos.ObtenerTrazabilidad(codPro, numPed)

            dgvTrazabilidad.DataSource = dt

            dgvTrazabilidad.Columns(9).Width = 120
            dgvTrazabilidad.Columns(10).Width = 120
            dgvTrazabilidad.Columns(11).Width = 120
            dgvTrazabilidad.Columns(12).Width = 120

        Catch ex As Exception

        End Try
    End Sub



    Public Sub CargarCuentasXCobrar(ByVal ruc As String)
        Try

            Dim dt As New DataTable
            Dim objPedidos As New BePedidos


            dt = objPedidos.ObtenerCuentasxCobrar(ruc)

            dgvCuentasxCobrar.DataSource = dt

            'dgvCuentasxCobrar.Columns(9).Width = 120
            'dgvCuentasxCobrar.Columns(10).Width = 120
            'dgvCuentasxCobrar.Columns(11).Width = 120
            'dgvCuentasxCobrar.Columns(12).Width = 120

        Catch ex As Exception

        End Try
    End Sub



    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Try
            lblSincro.Text = "Detenido"
            lblSincro.ForeColor = Color.Red

            Timer1.Stop()


        Catch ex As Exception

        End Try
    End Sub

    Private Sub chk_PendAprob_CheckedChanged(sender As Object, e As EventArgs) Handles chk_PendAprob.CheckedChanged
        Try
            If chk_PendAprob.Checked = True Then

                chkTodo.Checked = False
                chkPendFact.Checked = False
                chkPendContado.Checked = False
                chkAprobarComercial.Checked = False

                flagEstAccion = "PA"
                CargarPedidosVisor(unidad_negocio, flagEstAccion)

            End If

            If chk_PendAprob.Checked = False And chkPendFact.Checked = False And chkPendContado.Checked = False And chkAprobarComercial.Checked = False Then
                flagEstAccion = "T"
                CargarPedidosVisor(unidad_negocio, flagEstAccion)
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub chkPendFact_CheckedChanged(sender As Object, e As EventArgs) Handles chkPendFact.CheckedChanged
        Try
            If chkPendFact.Checked = True Then
                chkTodo.Checked = False
                chk_PendAprob.Checked = False
                chkPendContado.Checked = False
                chkAprobarComercial.Checked = False

                flagEstAccion = "PF"
                CargarPedidosVisor(unidad_negocio, flagEstAccion)
            End If

            If chk_PendAprob.Checked = False And chkPendFact.Checked = False And chkPendContado.Checked = False And chkAprobarComercial.Checked = False Then
                flagEstAccion = "T"
                CargarPedidosVisor(unidad_negocio, flagEstAccion)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub chkTodo_CheckedChanged(sender As Object, e As EventArgs) Handles chkTodo.CheckedChanged
        'Try

        '    If chkTodo.Checked = True Then
        '        chk_PendAprob.Checked = False
        '        chkPendFact.Checked = False
        '        flagEstAccion = "T"
        '        CargarPedidosVisor(unidad_negocio, flagEstAccion)
        '    End If

        '    If chkTodo.Checked = False And chk_PendAprob.Checked = False And chkPendFact.Checked = False Then
        '        dgvListarPedidos.Rows.Clear()
        '    End If

        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub cboUnidad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboUnidad.SelectedIndexChanged
        Try
            If cboUnidad.SelectedIndex = 0 Then
                unidad_negocio = "TDO"
            End If

            If cboUnidad.SelectedIndex = 1 Then
                unidad_negocio = "PRV"
            End If

            If cboUnidad.SelectedIndex = 2 Then
                unidad_negocio = "INS"
            End If

            CargarPedidosVisor(unidad_negocio, flagEstAccion)


        Catch ex As Exception

        End Try
    End Sub

    Private Sub chkPendContado_CheckedChanged(sender As Object, e As EventArgs) Handles chkPendContado.CheckedChanged
        Try
            If chkPendContado.Checked = True Then
                chkTodo.Checked = False
                chk_PendAprob.Checked = False
                chkPendFact.Checked = False
                chkAprobarComercial.Checked = False

                flagEstAccion = "PC"
                CargarPedidosVisor(unidad_negocio, flagEstAccion)
            End If

            If chk_PendAprob.Checked = False And chkPendFact.Checked = False And chkPendContado.Checked = False And chkAprobarComercial.Checked = False Then
                flagEstAccion = "T"
                CargarPedidosVisor(unidad_negocio, flagEstAccion)
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub chkFiltroFecha_CheckedChanged(sender As Object, e As EventArgs) Handles chkFiltroFecha.CheckedChanged
        Try
            If chkFiltroFecha.Checked = True Then

                Timer1.Stop()

                chk_PendAprob.Enabled = False
                chkPendFact.Enabled = False
                chkPendContado.Enabled = True
                chkAprobarComercial.Enabled = False

                chk_PendAprob.Checked = False
                chkPendFact.Checked = False
                chkAprobarComercial.Checked = False

                'chkPendContado.Checked = False

                chkFiltroFactura.Checked = False
                chkPorGuia.Checked = False
                chkPedido.Checked = False

                cboUnidad.Enabled = True
                dtpFecIni.Enabled = True
                dtpFecFin.Enabled = True
                txtTD.Enabled = False

                txtTD.Text = ""
                txtSerie.Enabled = False
                txtSerie.Text = ""
                txtDocumento.Enabled = False
                txtDocumento.Text = ""

                txtGuia.Enabled = False
                txtGuia.Text = ""

                txtPedido.Enabled = False
                txtPedido.Text = ""

            End If


            If chkFiltroFecha.Checked = False And chkFiltroFactura.Checked = False And chkPorGuia.Checked = False And chkPedido.Checked = False Then

                Timer1.Start()

                chk_PendAprob.Enabled = True
                chkPendFact.Enabled = True
                chkPendContado.Enabled = True
                chkFiltroFactura.Enabled = True
                chkAprobarComercial.Enabled = True
                cboUnidad.Enabled = True


            End If




        Catch ex As Exception

        End Try
    End Sub

    Private Sub chkFiltroFactura_CheckedChanged(sender As Object, e As EventArgs) Handles chkFiltroFactura.CheckedChanged
        Try
            If chkFiltroFactura.Checked = True Then
                Timer1.Stop()

                cboUnidad.Enabled = False
                chk_PendAprob.Enabled = False
                chkPendFact.Enabled = False
                chkPendContado.Enabled = False
                chkAprobarComercial.Enabled = False

                chkFiltroFecha.Checked = False
                chkPorGuia.Checked = False
                chkPedido.Checked = False

                dtpFecIni.Enabled = False
                dtpFecFin.Enabled = False

                txtTD.Enabled = True
                txtTD.Text = ""
                txtSerie.Enabled = True
                txtSerie.Text = ""
                txtDocumento.Enabled = True
                txtDocumento.Text = ""

                txtGuia.Enabled = False
                txtGuia.Text = ""

                txtPedido.Enabled = False
                txtPedido.Text = ""
                txtTD.Focus()


            End If


            If chkFiltroFecha.Checked = False And chkFiltroFactura.Checked = False And chkPorGuia.Checked = False And chkPedido.Checked = False Then
                Timer1.Start()

                chk_PendAprob.Enabled = True
                chkPendFact.Enabled = True
                chkPendContado.Enabled = True
                chkFiltroFactura.Enabled = True
                chkAprobarComercial.Enabled = True
                cboUnidad.Enabled = True

            End If



        Catch ex As Exception

        End Try
    End Sub

    Private Sub chkPorGuia_CheckedChanged(sender As Object, e As EventArgs) Handles chkPorGuia.CheckedChanged
        Try

            If chkPorGuia.Checked = True Then
                Timer1.Stop()

                cboUnidad.Enabled = False
                chk_PendAprob.Enabled = False
                chkPendFact.Enabled = False
                chkPendContado.Enabled = False
                chkAprobarComercial.Enabled = False

                chk_PendAprob.Checked = False
                chkPendFact.Checked = False
                chkPendContado.Checked = False
                chkAprobarComercial.Checked = False


                chkFiltroFecha.Checked = False
                chkFiltroFactura.Checked = False
                chkPedido.Checked = False

                dtpFecIni.Enabled = False
                dtpFecFin.Enabled = False

                txtTD.Enabled = False
                txtTD.Text = ""
                txtSerie.Enabled = False
                txtSerie.Text = ""
                txtDocumento.Enabled = False
                txtDocumento.Text = ""

                txtPedido.Enabled = False
                txtPedido.Text = ""

                txtGuia.Enabled = True
                txtGuia.Text = ""
                txtGuia.Focus()

            End If

            If chkFiltroFecha.Checked = False And chkFiltroFactura.Checked = False And chkPorGuia.Checked = False And chkPedido.Checked = False Then
                Timer1.Start()

                chk_PendAprob.Enabled = True
                chkPendFact.Enabled = True
                chkPendContado.Enabled = True
                chkFiltroFactura.Enabled = True
                chkAprobarComercial.Enabled = True
                cboUnidad.Enabled = True

            End If



        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try

            Me.Cursor = Cursors.WaitCursor

            If chkFiltroFecha.Checked = True Then
                Dim fecIni As String
                Dim fecFin As String
                Dim flagCont As String = String.Empty

                fecIni = dtpFecIni.Value
                fecFin = dtpFecFin.Value

                If chkPendContado.Checked = True Then
                    flagCont = "SI"
                Else
                    If chkPendContado.Checked = False Then
                        flagCont = "NO"
                    End If
                End If

                CargarPedidosVisor_Filtros("XF", unidad_negocio, fecIni, fecFin, "", "", "", "", "", flagCont)

            Else
                If chkFiltroFactura.Checked = True Then
                    Dim f5_ctd As String
                    Dim f5_cnumser As String
                    Dim f5_cnumdoc As String

                    'If txtTD.Text = "" Then
                    '    MessageBox.Show("Ingrese el Tipo de Documento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    '    txtTD.Focus()
                    'Else
                    '    If txtSerie.Text = "" Then
                    '        MessageBox.Show("Ingrese el Tipo de Documento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    '        txtSerie.Focus()
                    '    Else
                    If txtDocumento.Text = "" Then
                        MessageBox.Show("Ingrese el Tipo de Documento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        txtDocumento.Focus()
                    Else
                        f5_ctd = txtTD.Text
                        f5_cnumser = txtSerie.Text
                        f5_cnumdoc = txtDocumento.Text

                        CargarPedidosVisor_Filtros("XC", "", "", "", f5_ctd, f5_cnumser, f5_cnumdoc, "", "", "")

                    End If
                    'End If
                    'End If
                Else
                    If chkPorGuia.Checked = True Then
                        Dim c5_cnumdoc As String

                        If txtGuia.Text = "" Then
                            MessageBox.Show("Ingrese la Guía", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            txtGuia.Focus()

                        Else
                            c5_cnumdoc = txtGuia.Text
                            CargarPedidosVisor_Filtros("XG", "", "", "", "", "", "", "", c5_cnumdoc, "")
                        End If
                    Else
                        If chkPedido.Checked = True Then
                            Dim f5_cnumped As String

                            If txtPedido.Text = "" Then
                                MessageBox.Show("Ingrese el Pedido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                txtPedido.Focus()
                            Else
                                f5_cnumped = txtPedido.Text
                                CargarPedidosVisor_Filtros("XP", "", "", "", "", "", "", f5_cnumped, "", "")
                            End If

                        End If
                    End If
                End If
            End If

            Me.Cursor = Cursors.Default

        Catch ex As Exception

        End Try
    End Sub

    Private Sub chkPedido_CheckedChanged(sender As Object, e As EventArgs) Handles chkPedido.CheckedChanged
        Try

            If chkPedido.Checked = True Then
                Timer1.Stop()

                cboUnidad.Enabled = False
                chk_PendAprob.Enabled = False
                chkPendFact.Enabled = False
                chkPendContado.Enabled = False
                chkAprobarComercial.Enabled = False

                chk_PendAprob.Checked = False
                chkPendFact.Checked = False
                chkPendContado.Checked = False
                chkAprobarComercial.Checked = False

                chkFiltroFecha.Checked = False
                chkFiltroFactura.Checked = False
                chkPorGuia.Checked = False

                dtpFecIni.Enabled = False
                dtpFecFin.Enabled = False

                txtTD.Enabled = False
                txtTD.Text = ""
                txtSerie.Enabled = False
                txtSerie.Text = ""
                txtDocumento.Enabled = False
                txtDocumento.Text = ""

                txtGuia.Enabled = False
                txtGuia.Text = ""


                txtPedido.Enabled = True
                txtPedido.Text = ""
                txtPedido.Focus()


            End If

            If chkFiltroFecha.Checked = False And chkFiltroFactura.Checked = False And chkPorGuia.Checked = False And chkPedido.Checked = False Then
                Timer1.Start()

                chk_PendAprob.Enabled = True
                chkPendFact.Enabled = True
                chkPendContado.Enabled = True
                chkFiltroFactura.Enabled = True
                cboUnidad.Enabled = True
                chkAprobarComercial.Enabled = True

                txtPedido.Text = ""

            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtGuia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGuia.KeyPress
        Try
            Dim c5_cnumdoc As String

            If e.KeyChar = Convert.ToChar(Keys.Enter) Then

                If txtGuia.Text = "" Then
                    MessageBox.Show("Ingrese la Guía", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtGuia.Focus()

                Else
                    c5_cnumdoc = txtGuia.Text
                    CargarPedidosVisor_Filtros("XG", "", "", "", "", "", "", "", c5_cnumdoc, "")
                End If


            End If


        Catch ex As Exception

        End Try
    End Sub




    Function GridAExcel(ByVal ElGrid As DataGridView) As Boolean

        Dim exApp As Object
        Dim exLibro As Object
        Dim exHoja As Object

        exApp = CreateObject("Excel.Application")

        ' -- Referencia a la Hoja activa ( la que añade por defecto Excel )   
        exHoja = exApp.ActiveSheet

        Try

            'Añadimos el Libro al programa, y la hoja al libro
            exLibro = exApp.Workbooks.Add()
            exHoja = exLibro.Worksheets(1)



            'exLibro = exApp.Workbooks
            'exHoja = exLibro.Worksheets.Add()

            ' ¿Cuantas columnas y cuantas filas?
            Dim NCol As Integer = ElGrid.ColumnCount
            Dim NRow As Integer = ElGrid.RowCount

            'Aqui recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.
            For i As Integer = 1 To NCol
                'If i <> 9 And i <> 23 And i <> 25 Then
                exHoja.Cells.Item(1, i) = ElGrid.Columns(i - 1).HeaderText.ToString()
                'End If
                'exHoja.Cells.Item(1, i).HorizontalAlignment = 3
            Next

            Dim fecha As String = String.Empty

            For Fila As Integer = 0 To NRow - 1
                For Col As Integer = 0 To NCol - 1

                    'If Col = 13 Or Col = 14 Or Col = 15 Or Col = 16 Or Col = 17 Then
                    '    fecha = "'" & CStr(ElGrid.Rows(Fila).Cells(Col).Value)
                    '    exHoja.Cells.Item(Fila + 2, Col + 1) = "'" & CStr(ElGrid.Rows(Fila).Cells(Col).Value)
                    'Else
                    '    exHoja.Cells.Item(Fila + 2, Col + 1) = CStr(ElGrid.Rows(Fila).Cells(Col).Value)

                    'End If
                    ' If Col <> 8 And Col <> 22 And Col <> 24 Then
                    'If Col = 3 Or Col = 0 Or Col = 2 Or Col = 13 Or Col = 14 Or Col = 15 Or Col = 16 Or Col = 17 Then
                    '    fecha = "'" & CStr(ElGrid.Rows(Fila).Cells(Col).Value)
                    '    exHoja.Cells.Item(Fila + 2, Col + 1) = "'" & CStr(ElGrid.Rows(Fila).Cells(Col).Value)
                    'Else
                    '    exHoja.Cells.Item(Fila + 2, Col + 1) = CStr(ElGrid.Rows(Fila).Cells(Col).Value)

                    'End If

                    If Col = 3 Then
                        fecha = "'" & CStr(ElGrid.Rows(Fila).Cells(Col).Value)
                        exHoja.Cells.Item(Fila + 2, Col + 1) = "'" & CStr(ElGrid.Rows(Fila).Cells(Col).Value)
                    Else
                        exHoja.Cells.Item(Fila + 2, Col + 1) = CStr(ElGrid.Rows(Fila).Cells(Col).Value)

                    End If
                    ' End If
                Next
            Next

            'Titulo en negrita, Alineado al centro y que el tamaño de la columna se
            'ajuste al texto


            exHoja.Rows.Item(1).Font.Bold = 1
            exHoja.Rows.Item(1).HorizontalAlignment = 3

            exHoja.Columns.AutoFit()

            exHoja.Rows.AutoFit()

            'exHoja.RowHeight = 12

            'Aplicación visible
            exApp.Application.Visible = True

            exHoja = Nothing
            exLibro = Nothing
            exApp = Nothing

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")
            Return False
        End Try

        Return True

    End Function

    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        Try
            Me.Cursor = Cursors.WaitCursor

            GridAExcel(dgvListarPedidos)

            Me.Cursor = Cursors.Default
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtPedido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPedido.KeyPress
        Try
            If e.KeyChar = Convert.ToChar(Keys.Enter) Then

                Dim f5_cnumped As String

                If txtPedido.Text = "" Then
                    MessageBox.Show("Ingrese el Pedido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtPedido.Focus()
                Else
                    f5_cnumped = txtPedido.Text
                    CargarPedidosVisor_Filtros("XP", "", "", "", "", "", "", f5_cnumped, "", "")
                End If


            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtDocumento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDocumento.KeyPress
        Try

            If e.KeyChar = Convert.ToChar(Keys.Enter) Then
                Dim f5_ctd As String
                Dim f5_cnumser As String
                Dim f5_cnumdoc As String

                'If txtTD.Text = "" Then
                '    MessageBox.Show("Ingrese el Tipo de Documento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                '    txtTD.Focus()
                'Else
                '    If txtSerie.Text = "" Then
                '        MessageBox.Show("Ingrese el Tipo de Documento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                '        txtSerie.Focus()
                '    Else
                If txtDocumento.Text = "" Then
                    MessageBox.Show("Ingrese el Tipo de Documento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtDocumento.Focus()
                Else
                    f5_ctd = txtTD.Text
                    f5_cnumser = txtSerie.Text
                    f5_cnumdoc = txtDocumento.Text

                    CargarPedidosVisor_Filtros("XC", "", "", "", f5_ctd, f5_cnumser, f5_cnumdoc, "", "", "")

                End If
                'End If
                'End If

            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub chkAprobarComercial_CheckedChanged(sender As Object, e As EventArgs) Handles chkAprobarComercial.CheckedChanged
        Try
            If chkAprobarComercial.Checked = True Then

                chkTodo.Checked = False
                chkPendFact.Checked = False
                chkPendContado.Checked = False
                chk_PendAprob.Checked = False

                flagEstAccion = "PX"
                CargarPedidosVisor(unidad_negocio, flagEstAccion)

            End If

            If chk_PendAprob.Checked = False And chkPendFact.Checked = False And chkPendContado.Checked = False And chkAprobarComercial.Checked = False Then
                flagEstAccion = "T"
                CargarPedidosVisor(unidad_negocio, flagEstAccion)
            End If


        Catch ex As Exception

        End Try
    End Sub


End Class




