Imports System.Text.RegularExpressions

Public Class AgregarGuiaCabeceraRuta

    Private dtalmacenessoft, DtCentrosCosto, dtGuia, dtTiempos As New DataTable
    Private ObjAlmacen As New AlmacenL
    Public grabado As Boolean = False
    Public codRuta As Integer = 0
    Public crg_id As Integer = 0
    Public user_id As Integer = 0


    Private Sub CargaInicial()
        Try
            CargarSite2()
            CargarCentrosCosto()
            ListarAlmacenSoftcom()
            CargarSite()
            ListarTiemposEspera()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function LlamarListarAlmacenesSoft() As DataTable

        Dim dtretono As DataTable
        Try
            dtretono = ObjAlmacen.ListarAlmacenesSoftcom().Copy
        Catch ex As Exception
            Throw ex
        End Try
        Return dtretono
    End Function

    Public Sub ListarAlmacenSoftcom()
        Try
            Dim dtretorno As New DataTable
            dtretorno = LlamarListarAlmacenesSoft()

            If dtretorno.Rows.Count > 0 Then
                dtalmacenessoft.Rows.Clear()
                dtalmacenessoft = dtretorno.Clone
                For Each RowRetorno As DataRow In dtretorno.Rows
                    Dim rowcabecera As DataRow
                    rowcabecera = dtalmacenessoft.NewRow
                    rowcabecera.Item("A1_CALMA") = RowRetorno.Item("A1_CALMA").ToString.Trim
                    rowcabecera.Item("A1_CDESCRI") = RowRetorno.Item("A1_CDESCRI").ToString.Trim
                    dtalmacenessoft.Rows.Add(rowcabecera)
                Next
                combo_Almacen.DataSource = dtalmacenessoft
                combo_Almacen.DisplayMember = "A1_CDESCRI"
                combo_Almacen.ValueMember = "A1_CALMA"
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub AgregarGuiaCabeceraRuta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargaInicial()
    End Sub

    Private Sub txt_numero_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_numero.KeyUp
        If e.KeyCode = Keys.Enter Then
            BuscarGuia()
        End If
    End Sub
    Public Sub BuscarGuia()

        Try
            ErrorProvider1.SetError(txt_numero, "")
            If txt_numero.Text = "" Then
                ErrorProvider1.SetError(txt_numero, "Debe Ingresar Numero de Guia")
            Else
                dtGuia = LlamarObtenerGuiaDespacho(combo_Almacen.SelectedValue.ToString.Trim, "GS", txt_numero.Text.Trim)
                If dtGuia.Rows.Count > 0 Then
                    'grabado = True
                    'rowRetorno = dtGuia.Rows(0)
                    'idcosto = Cmb_Costos.SelectedValue
                    'nombrecosto = Cmb_Costos.Text
                    'Me.Close()
                    Cmb_Costos.Enabled = True

                    cmb_tipo.Enabled = True
                    Cmb_Site.Enabled = True
                    txt_peso.Enabled = True
                    txt_bultos.Enabled = True
                    If dtGuia.Rows(0).Item("GLOSA").ToString.Trim <> "" Then
                        txt_glosa.Text = dtGuia.Rows(0).Item("GLOSA").ToString.Trim
                    Else
                        txt_glosa.Text = "-"
                    End If

                    If dtGuia.Rows(0).Item("DEPARTAMENTO").ToString.Trim <> "" Then
                        txt_departamento.Text = dtGuia.Rows(0).Item("DEPARTAMENTO").ToString.Trim
                    Else
                        txt_departamento.Text = "-"
                    End If

                    If dtGuia.Rows(0).Item("PROVINCIA").ToString.Trim <> "" Then
                        txt_provincia.Text = dtGuia.Rows(0).Item("PROVINCIA").ToString.Trim
                    Else
                        txt_provincia.Text = "-"
                    End If

                    If dtGuia.Rows(0).Item("DISTRITO").ToString.Trim <> "" Then
                        txt_distrito.Text = dtGuia.Rows(0).Item("DISTRITO").ToString.Trim
                    Else
                        txt_distrito.Text = "-"
                    End If

                Else
                    Cmb_Costos.Enabled = False
                    cmb_tipo.Enabled = False
                    Cmb_Site.Enabled = False
                    txt_peso.Enabled = False
                    txt_bultos.Enabled = False
                    txt_glosa.Text = "-"
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function LlamarObtenerGuiaDespacho(calma As String, ctd As String, cnumdoc As String) As DataTable
        Dim dtreotno As New DataTable
        Try
            dtreotno = ObjAlmacen.ObtenerGuiaProgramacion(calma, ctd, cnumdoc)
        Catch ex As Exception
            Throw ex
        End Try
        Return dtreotno

    End Function

    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click
        Try
            If ValidarAceptar() = True Then
                Aceptar()
            Else
                MsgBox("Existen Errores, Valide e intente nuevamente", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function LlamarRegistrar(crg_id As Integer, calma As String, ctd As String, cnumdoc As String, userid As Integer, peso As Decimal, bultos As Integer, tiempo As Decimal, volumen As Decimal, restriccion As String, tiporuta As String, cliente As String, Direccion As String, importe As Decimal, condicion As String, REPRESENTATE As String, idcosto As Integer, fecharecepcion As String, horarecepcion As String, idsite As Integer, departamento As String, provincia As String, distrito As String, fisico As String, idsiteliq As Integer) As Integer
        Dim rp As Integer = 0

        Try
            rp = ObjAlmacen.Agregar_Guia_Ruta(crg_id, calma, ctd, cnumdoc, userid, peso, bultos, tiempo, volumen, restriccion, tiporuta, cliente, Direccion, importe, condicion, REPRESENTATE, idcosto, fecharecepcion, horarecepcion, idsite, departamento, provincia, distrito, fisico, idsiteliq)
        Catch ex As Exception
            Throw ex
        End Try

        Return rp
    End Function

    Public Function ValidarDecimal(Dato As String) As Boolean
        Dim retorno As Boolean = Regex.IsMatch(Dato, "^[0-9]+(\.([0-9])+)?$")
        Return retorno
    End Function
    Private Sub CargarSite2()
        Try
            Dim dt As New DataTable
            dt = ObjAlmacen.ListarSites

            If dt.Rows.Count > 0 Then
                cmb_siteliq.DataSource = dt
                cmb_siteliq.ValueMember = "sit_idsite"
                cmb_siteliq.DisplayMember = "sit_nombre"
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub
    Private Function ValidarAceptar() As Boolean
        Dim rp As Boolean = True

        Try
            ErrorProvider1.SetError(txt_bultos, "")
            ErrorProvider1.SetError(txt_peso, "")
            ErrorProvider1.SetError(cmb_tipo, "")
            ErrorProvider1.SetError(cmdAceptar, "")
            ErrorProvider1.SetError(cmb_fisico, "")

            If cmb_tipo.Text = "" Then
                ErrorProvider1.SetError(cmb_tipo, "Seleccione Tipo Ruta")
                rp = False
            End If

            If cmb_fisico.Text = "" Then
                ErrorProvider1.SetError(cmb_fisico, "Seleccione Fisico")
                rp = False
            End If

            If dtGuia.Rows.Count = 0 Then
                ErrorProvider1.SetError(cmdAceptar, "Debe Cargar Datos de una Guia antes de aceptar")
                rp = False
            End If

            If txt_bultos.Text = "" Then
                ErrorProvider1.SetError(txt_bultos, "Debe Ingresar el valor Bultos")
                rp = False
            Else
                If ValidarNumerico(txt_bultos.Text) = False Then
                    ErrorProvider1.SetError(txt_bultos, "Bultos debe ser un valor numerico")
                    rp = False
                Else
                    If CType(txt_bultos.Text, Integer) < 0 Then
                        ErrorProvider1.SetError(txt_bultos, "Bultos debe ser mayor o igual a 0")
                        rp = False
                    End If
                End If
            End If

            If txt_peso.Text = "" Then
                ErrorProvider1.SetError(txt_peso, "Debe Ingresar el valor Peso")
                rp = False
            Else
                If ValidarDecimal(txt_peso.Text) = False Then
                    ErrorProvider1.SetError(txt_peso, "Peso debe ser un valor numerico")
                    rp = False
                Else
                    If CType(txt_peso.Text, Integer) < 0 Then
                        ErrorProvider1.SetError(txt_peso, "Peso debe ser mayor o igual a 0")
                        rp = False
                    End If
                End If
            End If

        Catch ex As Exception
            Throw ex
        End Try

        Return rp
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

    Private Sub CargarSite()
        Try
            Dim dt As New DataTable
            dt = ObjAlmacen.ListarSites

            If dt.Rows.Count > 0 Then
                Cmb_Site.DataSource = dt
                Cmb_Site.ValueMember = "sit_idsite"
                Cmb_Site.DisplayMember = "sit_nombre"
            End If
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Aceptar()
        Try
            If dtGuia.Rows.Count > 0 Then
                Dim fechaactual As DateTime
                Dim tiempo As Decimal = 0, volumen As Decimal = 0, Importe As Decimal = 0, peso As Decimal = 0
                Dim Restriccion As String = "", TipoRuta As String = "", Cliente As String = "", Direccion As String = "", Condicion As String = "", Representante As String = "", fecharecep As String = "", horadescrip As String = "", cnumdoc As String = "", ctd As String = "", calma As String = "", departamento As String = "", provincia As String = "", distrito As String = "", fisico As String = ""

                Dim idcosto As Integer = 0, idsite As Integer = 0, bultos As Integer = 0, idsiteliquidacion As Integer = 0
                fechaactual = Date.Now


                idsite = Cmb_Site.SelectedValue.ToString
                idcosto = Cmb_Costos.SelectedValue.ToString
                TipoRuta = cmb_tipo.Text.ToString
                fisico = cmb_fisico.Text.ToString
                idsiteliquidacion = cmb_siteliq.SelectedValue

                Cliente = dtGuia.Rows(0).Item("NOM_CLIENTE").ToString.Trim
                Direccion = dtGuia.Rows(0).Item("DIRECCION_ENTREGA").ToString.Trim
                If CType(dtGuia.Rows(0).Item("M3UN").ToString, Decimal) <> 0 Then
                    Dim cal As Decimal = 0
                    cal = 0.012 / 3
                    If dtGuia.Rows(0).Item("M3UN") < cal Then
                        volumen = 0.005
                    Else
                        volumen = dtGuia.Rows(0).Item("M3UN") * 1.4
                    End If
                Else
                    volumen = 0
                End If
                ctd = dtGuia.Rows(0).Item("C5_CTD").ToString.Trim
                calma = dtGuia.Rows(0).Item("C5_CALMA").ToString.Trim
                cnumdoc = dtGuia.Rows(0).Item("NRO_GUIA").ToString.Trim
                departamento = dtGuia.Rows(0).Item("DEPARTAMENTO").ToString.Trim
                provincia = dtGuia.Rows(0).Item("PROVINCIA").ToString.Trim
                distrito = dtGuia.Rows(0).Item("DISTRITO").ToString.Trim

                Importe = dtGuia.Rows(0).Item("IMPORTE").ToString.Trim
                peso = CType(txt_peso.Text, Decimal)
                bultos = CType(txt_bultos.Text, Integer)
                tiempo = ObtenerTiempoEntrega(dtGuia.Rows(0).Item("CANAL").ToString.Trim)
                Condicion = dtGuia.Rows(0).Item("DESCRIP_PED").ToString.Trim
                Representante = dtGuia.Rows(0).Item("REPRESENTANTE").ToString.Trim

                fecharecep = fechaactual.Day.ToString + "/" + fechaactual.Month.ToString + "/" + fechaactual.Year.ToString
                horadescrip = fechaactual.ToString("hh:mm:ss")

                If dtGuia.Rows(0).Item("CANAL").ToString.Trim = "SALOG" Then
                    Restriccion = "Cita - TODO EL DIA"
                Else
                    If dtGuia.Rows(0).Item("CANAL").ToString.Trim = "IBT" And dtGuia.Rows(0).Item("DISTRITO").ToString.Trim = "PUNTA HERMOSA" Then
                        Restriccion = "Cita - atencion hasta las 3 PM"
                    Else
                        If dtGuia.Rows(0).Item("DISTRITO").ToString.Trim = "CHORRILLOS" And dtGuia.Rows(0).Item("RUC").ToString.Trim = "20604890617" And dtGuia.Rows(0).Item("CANAL").ToString.Trim = "INKAFARMA/MIFARMA" Then
                            Restriccion = "Cita - Exclusiva"
                        Else
                            If dtGuia.Rows(0).Item("DISTRITO").ToString.Trim = "SANTA ANITA" And dtGuia.Rows(0).Item("RUC").ToString.Trim = "20604890617" And dtGuia.Rows(0).Item("CANAL").ToString.Trim = "INKAFARMA/MIFARMA" Then
                                Restriccion = "Cita"
                            Else
                                If dtGuia.Rows(0).Item("DISTRITO").ToString.Trim = "SANTA ANITA" And dtGuia.Rows(0).Item("RUC").ToString.Trim = "20100054184" And dtGuia.Rows(0).Item("CANAL").ToString.Trim = "CLINICAS TOP" Then
                                    Restriccion = "Cita - atencion hasta las 2 p.m."
                                Else
                                    If dtGuia.Rows(0).Item("CANAL").ToString.Trim = "HORIZONTAL" Then
                                        Restriccion = "S/R"
                                    Else
                                        If dtGuia.Rows(0).Item("CANAL").ToString.Trim = "HORIZONTAL" And dtGuia.Rows(0).Item("RUC").ToString.Trim = "20524524067" Then
                                            Restriccion = "LUNES A VIERNES 8AM A 5PM"
                                        Else
                                            If dtGuia.Rows(0).Item("CANAL").ToString.Trim = "CLINICAS" And dtGuia.Rows(0).Item("RUC").ToString.Trim = "20101267467" Then
                                                Restriccion = "LUNES A VIERNES 8:00 AM A 1:00 PM"
                                            Else
                                                If dtGuia.Rows(0).Item("CANAL").ToString.Trim = "CLINICAS" And dtGuia.Rows(0).Item("RUC").ToString.Trim = "20100251176" Then
                                                    Restriccion = "LUNES A VIERNES 8AM A 5PM"
                                                Else
                                                    If dtGuia.Rows(0).Item("CANAL").ToString.Trim = "HORIZONTAL" And dtGuia.Rows(0).Item("RUC").ToString.Trim = "20263805021" Then
                                                        Restriccion = "LUNES A VIERNES 8AM A 6PM"
                                                    Else
                                                        If dtGuia.Rows(0).Item("CANAL").ToString.Trim = "HORIZONTAL" And dtGuia.Rows(0).Item("RUC").ToString.Trim = "20544478096" Then
                                                            Restriccion = "LUNES A VIERNES 8AM A 6PM"
                                                        Else
                                                            If dtGuia.Rows(0).Item("DISTRITO").ToString.Trim = "LINCE" And dtGuia.Rows(0).Item("RUC").ToString.Trim = "20492080811" Then
                                                                Restriccion = "LUNES A VIERNES DE 08:30 AM HASTA LAS 04:00 PM"
                                                            Else
                                                                If dtGuia.Rows(0).Item("DISTRITO").ToString.Trim = "MIRAFLORES" And dtGuia.Rows(0).Item("RUC").ToString.Trim = "20492080811" Then
                                                                    Restriccion = "LUNES A VIERNES DE 08:30 AM HASTA LAS 12:30 PM"
                                                                Else
                                                                    If dtGuia.Rows(0).Item("DISTRITO").ToString.Trim = "BREÑA" And dtGuia.Rows(0).Item("RUC").ToString.Trim = "20131368403" Then
                                                                        Restriccion = "LUNES A SABADO DE 08:00 AM HASTA LAS 02:00 PM"
                                                                    Else
                                                                        If dtGuia.Rows(0).Item("DISTRITO").ToString.Trim = "MAGDALENA DEL MAR" And dtGuia.Rows(0).Item("RUC").ToString.Trim = "20159855938" Then
                                                                            Restriccion = "LUNES A VIERNES DE 08:00 AM HASTA LAS 12:00 PM"
                                                                        Else
                                                                            If dtGuia.Rows(0).Item("DISTRITO").ToString.Trim = "LIMA" And dtGuia.Rows(0).Item("RUC").ToString.Trim = "20100025168" Then
                                                                                Restriccion = "LUNES A SABADO DE 08:00 AM HASTA LAS 02:00 PM"
                                                                            Else
                                                                                If dtGuia.Rows(0).Item("DISTRITO").ToString.Trim = "JESUS MARIA" And dtGuia.Rows(0).Item("RUC").ToString.Trim = "20101267467" Then
                                                                                    Restriccion = "LUNES A VIERNES DE 08:30 AM HASTA LAS 11:30 AM"
                                                                                Else
                                                                                    If dtGuia.Rows(0).Item("DISTRITO").ToString.Trim = "LIMA" And dtGuia.Rows(0).Item("RUC").ToString.Trim = "20562616561" Then
                                                                                        'Dim nombredia As String = Date.Now.ToString("dddd").Trim
                                                                                        'If nombredia = "Lunes" Then
                                                                                        Restriccion = "LUNES 02:00 PM HASTA 05:00 PM / MIERCOLES 09:00 AM HASTA 12:00 AM / VIERNES  09:00 AM HASTA 12:00 AM"
                                                                                        'End If
                                                                                    Else
                                                                                        Restriccion = "S/R"
                                                                                    End If
                                                                                End If
                                                                            End If
                                                                        End If
                                                                    End If
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
                If LlamarRegistrar(crg_id, calma, ctd, cnumdoc, user_id, peso, bultos, tiempo, volumen, Restriccion, TipoRuta, Cliente, Direccion, Importe, Condicion, Representante, idcosto, fecharecep, horadescrip, idsite, departamento, provincia, distrito, fisico, idsiteliquidacion) Then
                    MsgBox("GUIA SE AGREGÓ A RUTA CORRECTAMENTE", MsgBoxStyle.Information, "SISTEMAS NORDIC")
                    grabado = True
                    Me.Close()
                End If
            Else

            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ListarTiemposEspera()
        Try
            Dim dtretnor As New DataTable
            dtretnor = ObjAlmacen.ListarTiemposEntrega
            If dtretnor.Rows.Count > 0 Then
                dtTiempos = dtretnor
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Function ObtenerTiempoEntrega(Canal As String) As Decimal
        Dim RP As Decimal = 0
        Try
            If dtTiempos.Rows.Count > 0 Then
                For Each rowti As DataRow In dtTiempos.Rows
                    If rowti.Item("tie_canal").ToString.Trim = Canal Then
                        RP = rowti.Item("tie_tiempoentrega")
                        Exit For
                    End If
                Next
            End If
        Catch ex As Exception
            Throw ex
        End Try
        Return RP
    End Function

    Private Sub CargarCentrosCosto()
        Try
            DtCentrosCosto = ObjAlmacen.SP_OBTENER_COSTOS
            If DtCentrosCosto.Rows.Count > 0 Then
                Cmb_Costos.DataSource = DtCentrosCosto
                Cmb_Costos.DisplayMember = "nombre"
                Cmb_Costos.ValueMember = "idcliente"
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class