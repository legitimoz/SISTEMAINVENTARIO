Imports System.ComponentModel
Imports System.Configuration
Imports System.Text.RegularExpressions
Imports Nordic.Bl.Be

Public Class EditarRuta
    Public dtDetalleRuta, dt_tipoenvio As New DataTable
    Public Grabado As Boolean = False
    Private dt_vehiculos As New DataTable
    Public volumen As Decimal, tiempo As Decimal, importe As Decimal, totalpeso As Decimal = 0
    Public flagAccion As String
    Public idsite As Integer = 0
    Public usr_id As Integer
    Private AlmacenObj As New AlmacenL
    Private Estructura As New EstructuraTabla
    Public nombreRutaCab As String
    Private dtruta As New DataTable

    Private Sub EditarRuta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargaInicial()
    End Sub

    Private Sub CargarSite()
        Try
            Dim dt As New DataTable
            dt = AlmacenObj.ListarSites

            Dim cbo = CType(Dg_Detalle.Columns("SITE"), DataGridViewComboBoxColumn)
            cbo.DataSource = dt
            cbo.ValueMember = "sit_idsite"
            cbo.DisplayMember = "sit_nombre"
        Catch ex As Exception

        End Try

    End Sub

    Private Sub CargaInicial()
        CargarSite()

        '  cmb_tipoenvio.SelectedIndex = 0
        idsite = CType(ConfigurationManager.AppSettings("CodigoSite").ToString.Trim, Integer)
        dtruta = Estructura.HojaDeRuta
        Try
            txt_volumen.Text = Math.Round(volumen, 2).ToString + " M3"
            txt_tiempo.Text = Math.Round(tiempo, 2).ToString + " Horas"
            txt_importe.Text = "S/. " + importe.ToString
            txt_totalpeso.Text = "0 KG."
            Cargar_Transportistas()
            ListarVehiculos()
            ListarTipoEnvioRuta()
            Dim contador As Integer = 0
            If dtDetalleRuta.Rows.Count > 0 Then
                For Each RowRuta As DataRow In dtDetalleRuta.Rows
                    Dg_Detalle.Rows.Add()
                    Dg_Detalle.Rows(contador).Cells("Orden").Value = ""
                    Dg_Detalle.Rows(contador).Cells("GUIA").Value = RowRuta.Item("NRO_GUIA").ToString.Trim
                    Dg_Detalle.Rows(contador).Cells("CTD").Value = RowRuta.Item("CTD").ToString.Trim
                    Dg_Detalle.Rows(contador).Cells("ALMACEN").Value = RowRuta.Item("CALMA").ToString.Trim
                    Dg_Detalle.Rows(contador).Cells("Cliente").Value = RowRuta.Item("NOM_CLIENTE").ToString.Trim
                    Dg_Detalle.Rows(contador).Cells("Direccion").Value = RowRuta.Item("DIRECCION_ENTREGA").ToString.Trim
                    Dg_Detalle.Rows(contador).Cells("Peso").Value = 0
                    Dg_Detalle.Rows(contador).Cells("Bultos").Value = 0
                    Dg_Detalle.Rows(contador).Cells("TiempoGuia").Value = RowRuta.Item("TIEMPO").ToString
                    Dg_Detalle.Rows(contador).Cells("RestriccionUn").Value = RowRuta.Item("RESTRICCION").ToString
                    Dg_Detalle.Rows(contador).Cells("VoluemnUn").Value = RowRuta.Item("M3UN").ToString
                    Dg_Detalle.Rows(contador).Cells("Representante").Value = RowRuta.Item("REPRESENTANTE").ToString
                    Dg_Detalle.Rows(contador).Cells("Condicion").Value = RowRuta.Item("CONDICION").ToString
                    Dg_Detalle.Rows(contador).Cells("ImporteUn").Value = RowRuta.Item("IMPORTE").ToString
                    Dg_Detalle.Rows(contador).Cells("idcosto").Value = RowRuta.Item("idcosto").ToString
                    Dg_Detalle.Rows(contador).Cells("nombrecosto").Value = RowRuta.Item("nombrecosto").ToString
                    Dg_Detalle.Rows(contador).Cells("FECHARECEPCION").Value = RowRuta.Item("FechaRecepcion").ToString
                    Dg_Detalle.Rows(contador).Cells("HORARECEPCION").Value = RowRuta.Item("HoraRecepcion").ToString
                    Dg_Detalle.Rows(contador).Cells("DEPARTAMENTO").Value = RowRuta.Item("DEPARTAMENTO").ToString
                    Dg_Detalle.Rows(contador).Cells("PROVINCIA").Value = RowRuta.Item("PROVINCIA").ToString
                    Dg_Detalle.Rows(contador).Cells("DISTRITO").Value = RowRuta.Item("DISTRITO").ToString
                    Dg_Detalle.Rows(contador).Cells("FISICO").Value = RowRuta.Item("FISICO").ToString
                    Dg_Detalle.Rows(contador).Cells("siteliq").Value = RowRuta.Item("siteliq").ToString
                    Dg_Detalle.Rows(contador).Cells("sitepick").Value = RowRuta.Item("sitepick").ToString
                    Dg_Detalle.Rows(contador).Cells("CANAL").Value = RowRuta.Item("CANAL").ToString
                    Dg_Detalle.Rows(contador).Cells("LIMA_PROV").Value = RowRuta.Item("LIMA_PROV").ToString


                    contador = contador + 1
                Next
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub Cargar_Transportistas()
        Try
            Dim objGuia As New BeGuias
            Dim dt As New DataTable

            dt = objGuia.Obtener_Transportistas2()

            cbxTransportista.DataSource = dt
            cbxTransportista.ValueMember = "TR_CCODIGO"
            cbxTransportista.DisplayMember = "TR_CNOMBRE"

        Catch ex As Exception
            MessageBox.Show(ex.Message, "NORDIC", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click
        Try
            Dg_Detalle.Sort(Dg_Detalle.Columns(0), ListSortDirection.Ascending)
            Dim _BeDetGuiaRutaDetalle As BeDetGuiaRutaDetalle
            Dim _BeCabGuiaRuta As New BeCabGuiaRuta
            Dim _listadoDetalleGuia As New List(Of BeDetGuiaRutaDetalle)
            Dim xml As String
            If ValidarAceptar() Then
                _BeCabGuiaRuta.pr_trd_ccodigo = cbxTransportista.SelectedValue
                _BeCabGuiaRuta.pr_crg_fechaRuta = dtpFecRuta.Value.ToShortDateString
                _BeCabGuiaRuta.pr_usr_id = usr_id
                _BeCabGuiaRuta.pr_importetotal = importe
                _BeCabGuiaRuta.pr_volumentotal = volumen
                _BeCabGuiaRuta.pr_pesototal = totalpeso
                _BeCabGuiaRuta.pr_tiempototal = tiempo
                _BeCabGuiaRuta.pr_tipoEnvio = cmb_tipoenvio.Text.ToString
                _BeCabGuiaRuta.pr_idvehiculo = cmb_tipotransporte.SelectedValue
                _BeCabGuiaRuta.pr_idsite = idsite
                _BeCabGuiaRuta.pr_Comentario = txt_comentario.Text
                For i As Integer = 0 To Dg_Detalle.Rows.Count - 1
                    _BeDetGuiaRutaDetalle = New BeDetGuiaRutaDetalle
                    _BeDetGuiaRutaDetalle.pr_c5_calma = Dg_Detalle.Rows(i).Cells.Item("ALMACEN").Value
                    _BeDetGuiaRutaDetalle.pr_c5_ctd = Dg_Detalle.Rows(i).Cells.Item("CTD").Value
                    _BeDetGuiaRutaDetalle.pr_c5_numdoc = Dg_Detalle.Rows(i).Cells.Item("GUIA").Value
                    _BeDetGuiaRutaDetalle.pr_usr_idSalidaRuta = usr_id
                    _BeDetGuiaRutaDetalle.pr_drg_peso = Dg_Detalle.Rows(i).Cells.Item("Peso").Value
                    _BeDetGuiaRutaDetalle.pr_drg_bulto = Dg_Detalle.Rows(i).Cells.Item("Bultos").Value
                    _BeDetGuiaRutaDetalle.pr_tiempo = Dg_Detalle.Rows(i).Cells.Item("TiempoGuia").Value
                    _BeDetGuiaRutaDetalle.pr_volumen = Dg_Detalle.Rows(i).Cells.Item("VoluemnUn").Value
                    _BeDetGuiaRutaDetalle.pr_restriccion = Dg_Detalle.Rows(i).Cells.Item("RestriccionUn").Value
                    _BeDetGuiaRutaDetalle.pr_TipoRuta = Dg_Detalle.Rows(i).Cells.Item("TipoRuta").Value
                    _BeDetGuiaRutaDetalle.pr_Cliente = Dg_Detalle.Rows(i).Cells.Item("Cliente").Value
                    _BeDetGuiaRutaDetalle.pr_DireccionEntrega = Dg_Detalle.Rows(i).Cells.Item("Direccion").Value
                    _BeDetGuiaRutaDetalle.pr_importe = Dg_Detalle.Rows(i).Cells.Item("ImporteUn").Value
                    _BeDetGuiaRutaDetalle.pr_Condicion = Dg_Detalle.Rows(i).Cells.Item("Condicion").Value
                    _BeDetGuiaRutaDetalle.pr_Representante = Dg_Detalle.Rows(i).Cells.Item("Representante").Value
                    _BeDetGuiaRutaDetalle.pr_idcosto = Dg_Detalle.Rows(i).Cells.Item("idcosto").Value
                    _BeDetGuiaRutaDetalle.pr_FechaRecepcion = Dg_Detalle.Rows(i).Cells.Item("FECHARECEPCION").Value
                    _BeDetGuiaRutaDetalle.pr_HoraRecepcion = Dg_Detalle.Rows(i).Cells.Item("HORARECEPCION").Value
                    _BeDetGuiaRutaDetalle.pr_idsite = Dg_Detalle.Rows(i).Cells.Item("SITE").Value
                    _BeDetGuiaRutaDetalle.pr_departamento = Dg_Detalle.Rows(i).Cells.Item("DEPARTAMENTO").Value
                    _BeDetGuiaRutaDetalle.pr_provincia = Dg_Detalle.Rows(i).Cells.Item("PROVINCIA").Value
                    _BeDetGuiaRutaDetalle.pr_distrito = Dg_Detalle.Rows(i).Cells.Item("DISTRITO").Value
                    _BeDetGuiaRutaDetalle.pr_fisico = Dg_Detalle.Rows(i).Cells.Item("FISICO").Value
                    _BeDetGuiaRutaDetalle.pr_idsiteliq = Dg_Detalle.Rows(i).Cells.Item("siteliq").Value
                    _BeDetGuiaRutaDetalle.pr_idsitepicking = Dg_Detalle.Rows(i).Cells.Item("sitepick").Value
                    _BeDetGuiaRutaDetalle.pr_canal = Dg_Detalle.Rows(i).Cells.Item("CANAL").Value
                    _BeDetGuiaRutaDetalle.pr_nroorden = Dg_Detalle.Rows(i).Cells.Item("Orden").Value
                    _listadoDetalleGuia.Add(_BeDetGuiaRutaDetalle)
                Next

                _BeCabGuiaRuta.prListaItem = _listadoDetalleGuia
                xml = (_BeCabGuiaRuta.Serializar_RutaGuias(_BeCabGuiaRuta))
                Dim _tipoespuesta As String = String.Empty
                Dim _textorespuesta As String = String.Empty
                Dim idRuta As String = String.Empty
                Dim fecHorReg As String = String.Empty
                Dim fecMod As String = String.Empty

                Dim obj As New BeCabGuiaRuta
                If flagAccion = "Nuevo" Then
                    obj.RegistrarRuta_Guias_CS(xml, _tipoespuesta, _textorespuesta, idRuta, fecHorReg)
                End If

                If _tipoespuesta = "1" Then

                    If flagAccion = "Nuevo" Then
                        MessageBox.Show("Se Registro la Ruta satisfactoriamente !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Grabado = True
                        ImprimirRuta(idRuta)
                        Me.Close()
                    End If
                Else
                    If _tipoespuesta = "0" Then
                        MessageBox.Show("Error en Registro de la Ruta ! " + _textorespuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            Else
                MsgBox("Existen Errores, Valide e intente nuevamente", MsgBoxStyle.Exclamation, "SISTEMAS NORIDC")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ImprimirRuta(idruta As String)
        Dim rowRuta As DataRow
        Dim nombreempresa, RUC, Direccion As String
        Dim totalvolumen As Decimal = 0

        nombreempresa = ConfigurationManager.AppSettings("Empresa").ToString.Trim
        RUC = ConfigurationManager.AppSettings("nombreAlmacen").ToString.Trim
        Direccion = ConfigurationManager.AppSettings("nombreSite").ToString.Trim

        Dim logooperador As String = ""
        Dim color As String = "White"

        Select Case nombreempresa
            Case "NORDIC PHARMACEUTICAL COMPANY SAC"
                logooperador = "LogoNordic"
                color = "IndianRed"

            Case "HEADMARK CORPORATION SAC"
                logooperador = "SendaLogo"
                color = "DarkOrange"
                'Case "3"
                '    logooperador = "BARDEX"
                '    color = "DarkSeaGreen"
                'Case "4"
                '    logooperador = "ESCAME"
                '    color = "CornflowerBlue"
                'Case Else
                '    logooperador = ""
                '    color = "Silver"
        End Select
        Try

            Dim repartidor As String = ""
            Dim tipoEnvio As String = ""
            Dim movilidad As String = ""
            Dim Codigo As String = ""
            repartidor = cbxTransportista.Text.ToString
            movilidad = cmb_tipotransporte.Text.ToString
            tipoEnvio = cmb_tipoenvio.Text.ToString
            Codigo = idruta.ToString.Trim + " - " + DateTime.Now.Day.ToString + "/" + DateTime.Now.Month.ToString + "/" + DateTime.Now.Year.ToString
            dtruta.Rows.Clear()

            For Each DetalleCon As DataGridViewRow In Dg_Detalle.Rows
                rowRuta = dtruta.NewRow
                rowRuta.Item("Numero") = DetalleCon.Cells("Orden").Value
                rowRuta.Item("Guia") = DetalleCon.Cells("GUIA").Value
                rowRuta.Item("Cliente") = DetalleCon.Cells("Cliente").Value
                rowRuta.Item("Restriccion") = DetalleCon.Cells("RestriccionUn").Value
                rowRuta.Item("Direccion") = DetalleCon.Cells("Direccion").Value
                rowRuta.Item("Condicion") = DetalleCon.Cells("Condicion").Value
                rowRuta.Item("Importe") = DetalleCon.Cells("nombrecosto").Value
                'rowRuta.Item("Importe") = CType(0, Decimal)
                rowRuta.Item("Representante") = DetalleCon.Cells("Representante").Value
                rowRuta.Item("Volumen") = Math.Round(CType(DetalleCon.Cells("VoluemnUn").Value, Decimal), 3)
                rowRuta.Item("TiempoEntrega") = DetalleCon.Cells("TiempoGuia").Value
                rowRuta.Item("TipoRuta") = ""
                dtruta.Rows.Add(rowRuta)
            Next
            Dim reporte As New Demo
            dtruta.TableName = "DetalleRuta"
            'reporte.ImprimirRuta(Codigo, nombreempresa, RUC, Direccion, logooperador, color, "HojaDeRuta.rdlc", dtruta, repartidor, movilidad, volumen, Math.Round(tiempo, 2).ToString + " Horas", "S/. " + importe.ToString, totalpeso.ToString + " KG.", tipoEnvio)
            reporte.ImprimirRuta(Codigo, nombreempresa, RUC, Direccion, logooperador, color, "HojaDeRuta.rdlc", dtruta, repartidor, movilidad, volumen, Math.Round(tiempo, 2).ToString + " Horas", "S/. " + 0.ToString, totalpeso.ToString + " KG.", tipoEnvio)
            'Dim REPORT As New HojaRuta
            'REPORT.CodigoRuta = Codigo
            'REPORT.totalvolumen = volumen.ToString + " M3"
            'REPORT.totalpeso = totalpeso.ToString + " KG."
            'REPORT.totalimporte = "S/. " + importe.ToString
            'REPORT.totaltiempo = Math.Round(tiempo, 2).ToString + " Horas"
            'REPORT.tipoenvio = tipoEnvio
            'REPORT.movilidad = movilidad
            'REPORT.transportista = repartidor
            'REPORT.Dtruta = dtruta
            'REPORT.Show()
        Catch ex As Exception

        End Try

    End Sub

    Public Function ObtenerTipoRuta(guia As String) As String
        Dim TipoRuta As String = ""
        Try
            If Dg_Detalle.Rows.Count > 0 Then
                For Each DGRow As DataGridViewRow In Dg_Detalle.Rows
                    If DGRow.Cells("GUIA").Value.ToString.Trim = guia.Trim Then
                        TipoRuta = DGRow.Cells("TipoRuta").Value
                        Exit For
                    End If
                Next
            End If
        Catch ex As Exception
            Throw ex
        End Try
        Return TipoRuta
    End Function

    Public Sub ListarVehiculos()
        Try
            ' Dim dtretorno As New DataTable

            dt_vehiculos = AlmacenObj.ListarVehiculoDespacho(idsite)
            If dt_vehiculos.Rows.Count > 0 Then
                cmb_tipotransporte.DataSource = dt_vehiculos
                cmb_tipotransporte.DisplayMember = "veh_tipovehiculo"
                cmb_tipotransporte.ValueMember = "veh_idvehiculo"
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Sub ListarTipoEnvioRuta()
        Try
            ' Dim dtretorno As New DataTable

            dt_tipoenvio = AlmacenObj.SP_CSE_LISTARTIPOENVIORUTA()
            If dt_tipoenvio.Rows.Count > 0 Then
                cmb_tipoenvio.DataSource = dt_tipoenvio
                cmb_tipoenvio.DisplayMember = "descripcion"
                cmb_tipoenvio.ValueMember = "tip_idtipo"
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Dg_Detalle_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles Dg_Detalle.CellEndEdit
        Try
            If e.RowIndex >= 0 Then
                If e.ColumnIndex = 7 Then
                    ErrorProvider1.SetError(Dg_Detalle, "")
                    If ValidarDecimal(Dg_Detalle.Rows(e.RowIndex).Cells("Peso").EditedFormattedValue.ToString) = False Then
                        ErrorProvider1.SetError(Dg_Detalle, "Peso debe valor numérico")
                        Dg_Detalle.Rows(e.RowIndex).Cells("Peso").Value = 0
                    Else
                        Dim Nueva As Decimal = CType(Dg_Detalle.Rows(e.RowIndex).Cells("Peso").EditedFormattedValue, Decimal)
                        If Nueva < 0 Then
                            ErrorProvider1.SetError(Dg_Detalle, "Peso debe ser mayor o igual 0")
                            Dg_Detalle.Rows(e.RowIndex).Cells("Peso").Value = 0
                        Else
                            totalpeso = 0
                            For Each dgDet As DataGridViewRow In Dg_Detalle.Rows
                                totalpeso = totalpeso + CType(dgDet.Cells("Peso").Value, Decimal)
                            Next
                            txt_totalpeso.Text = totalpeso.ToString + " KG."
                        End If
                    End If
                End If
                If e.ColumnIndex = 0 Then
                    ErrorProvider1.SetError(Dg_Detalle, "")
                    If Dg_Detalle.Rows(e.RowIndex).Cells("Orden").EditedFormattedValue Is Nothing Then
                        ErrorProvider1.SetError(Dg_Detalle, "Debe Ingresar el Orden de Reparto")
                        Dg_Detalle.Rows(e.RowIndex).Cells("Orden").Value = ""
                    Else
                        If ValidarNumerico(Dg_Detalle.Rows(e.RowIndex).Cells("Orden").EditedFormattedValue) = False Then
                            ErrorProvider1.SetError(Dg_Detalle, "Nro Orden debe ser un dato numerico")
                            Dg_Detalle.Rows(e.RowIndex).Cells("Orden").Value = ""
                        Else
                            If CType(Dg_Detalle.Rows(e.RowIndex).Cells("Orden").EditedFormattedValue, Integer) <= 0 Then
                                ErrorProvider1.SetError(Dg_Detalle, "Nro Orden debe ser mayor a 0")
                                Dg_Detalle.Rows(e.RowIndex).Cells("Orden").Value = ""
                            Else
                                If Dg_Detalle.Rows.Count > 1 Then
                                    For Each DgVal As DataGridViewRow In Dg_Detalle.Rows
                                        If CType(DgVal.Cells("Orden").Value.ToString.Trim, Integer) = CType(Dg_Detalle.Rows(e.RowIndex).Cells("Orden").Value.ToString.Trim, Integer) And DgVal.Cells("GUIA").Value.ToString.Trim <> Dg_Detalle.Rows(e.RowIndex).Cells("GUIA").Value.ToString.Trim Then
                                            ErrorProvider1.SetError(Dg_Detalle, "Nro Orden ya fue asignada a otra guia")
                                            Dg_Detalle.Rows(e.RowIndex).Cells("Orden").Value = ""
                                        End If
                                    Next
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Function ValidarDecimal(Dato As String) As Boolean
        Dim retorno As Boolean = Regex.IsMatch(Dato, "^[0-9]+(\.([0-9])+)?$")
        Return retorno
    End Function


    Public Function ValidarNumerico(Dato As String) As Boolean
        Dim canConvert As Boolean
        Try
            Dim convertido As Integer
            canConvert = Integer.TryParse(Dato, convertido)

        Catch ex As Exception

        End Try
        Return canConvert
    End Function

    Private Function ValidarAceptar() As Boolean
        Dim rp As Boolean = True

        Try
            ErrorProvider1.SetError(cbxTransportista, "")
            ErrorProvider1.SetError(Dg_Detalle, "")
            ErrorProvider1.SetError(cmb_tipoenvio, "")
            If cbxTransportista.SelectedIndex = 0 Then
                ErrorProvider1.SetError(cbxTransportista, "Seleccione Transportista")
                rp = False
            End If

            If cmb_tipoenvio.SelectedValue = 0 Then
                ErrorProvider1.SetError(cmb_tipoenvio, "Seleccione Tipo de Envio")
                rp = False
            End If

            If Dg_Detalle.Rows.Count > 0 Then
                For Each rowdg As DataGridViewRow In Dg_Detalle.Rows

                    If rowdg.Cells("Bultos").Value.ToString.Trim = "" Then
                        ErrorProvider1.SetError(Dg_Detalle, "Ingrese Cantidad de Bultos")
                        rp = False
                        Exit For
                    Else
                        If ValidarDecimal(rowdg.Cells("Bultos").Value.ToString.Trim) = False Then
                            ErrorProvider1.SetError(Dg_Detalle, "Cantidad Bultos debe ser valor numerico")
                            rp = False
                            Exit For
                        Else
                            If CType(rowdg.Cells("Bultos").Value.ToString.Trim, Integer) <= 0 Then
                                ErrorProvider1.SetError(Dg_Detalle, "Cantidad Bultos debe ser mayor o igual a 0")
                                rp = False
                                Exit For
                            End If
                        End If
                    End If

                    If rowdg.Cells("Peso").Value.ToString.Trim = "" Then
                        ErrorProvider1.SetError(Dg_Detalle, "Ingrese Peso de Guia")
                        rp = False
                        Exit For
                    Else
                        If ValidarDecimal(rowdg.Cells("Peso").Value.ToString.Trim) = False Then
                            ErrorProvider1.SetError(Dg_Detalle, "Peso debe ser valor numerico")
                            rp = False
                            Exit For
                        Else
                            If CType(rowdg.Cells("Peso").Value.ToString.Trim, Decimal) <= 0 Then
                                ErrorProvider1.SetError(Dg_Detalle, "Peso debe ser mayor o igual a 0")
                                rp = False
                                Exit For
                            End If
                        End If
                    End If

                    If rowdg.Cells("TipoRuta").Value Is Nothing Then
                        ErrorProvider1.SetError(Dg_Detalle, "Ingrese Tipo Despacho")
                        rp = False
                        Exit For
                    Else
                        If rowdg.Cells("TipoRuta").Value.ToString.Trim = "" Then
                            ErrorProvider1.SetError(Dg_Detalle, "Ingrese Tipo Despacho")
                            rp = False
                            Exit For
                        End If
                    End If
                    If rowdg.Cells("SITE").Value Is Nothing Then
                        ErrorProvider1.SetError(Dg_Detalle, "Ingrese Site Origen")
                        rp = False
                        Exit For
                    Else
                        If rowdg.Cells("SITE").Value.ToString.Trim = "" Then
                            ErrorProvider1.SetError(Dg_Detalle, "Ingrese Site Origen")
                            rp = False
                            Exit For
                        End If
                    End If

                    If rowdg.Cells("Orden").Value Is Nothing Then
                        ErrorProvider1.SetError(Dg_Detalle, "Ingrese N° Orden de todas las guias")
                        rp = False
                        Exit For
                    Else
                        If rowdg.Cells("Orden").Value.ToString.Trim = "" Then
                            ErrorProvider1.SetError(Dg_Detalle, "Ingrese N° Orden de todas las guias")
                            rp = False
                            Exit For
                        Else
                            If ValidarNumerico(rowdg.Cells("Orden").Value.ToString.Trim) = False Then
                                ErrorProvider1.SetError(Dg_Detalle, "N° Orden deben ser datos numericos")
                                rp = False
                                Exit For
                            Else
                                If CType(rowdg.Cells("Orden").Value.ToString.Trim, Integer) <= 0 Then
                                    ErrorProvider1.SetError(Dg_Detalle, "N° Orden debe ser un valor mayor a 0")
                                    rp = False
                                    Exit For
                                End If
                            End If
                        End If
                    End If
                Next
            End If
        Catch ex As Exception
            Throw ex
        End Try
        Return rp
    End Function

End Class