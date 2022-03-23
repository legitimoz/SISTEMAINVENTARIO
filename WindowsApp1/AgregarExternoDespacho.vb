Imports System.Text.RegularExpressions

Public Class AgregarExternoDespacho
    Private dt_Caneles, DtCentrosCosto As New DataTable
    Private almacenObj As New AlmacenL
    Public grabado As Boolean = False
    Public idcosto As Integer = 0
    Public nombrecosto As String = ""

    Private Sub AgregarExternoDespacho_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CargaInicial()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CargarCentrosCosto()
        Try
            DtCentrosCosto = almacenObj.SP_OBTENER_COSTOS
            If DtCentrosCosto.Rows.Count > 0 Then
                Cmb_Costos.DataSource = DtCentrosCosto
                Cmb_Costos.DisplayMember = "nombre"
                Cmb_Costos.ValueMember = "idcliente"
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function ValidarAceptar() As Boolean
        Dim retorno As Boolean = True

        Try
            ErrorProvider1.SetError(txt_documento, "")
            ErrorProvider1.SetError(txt_ruccliente, "")
            ErrorProvider1.SetError(txt_nombrecliente, "")
            ErrorProvider1.SetError(txt_direccion, "")
            ErrorProvider1.SetError(txt_departamento, "")
            ErrorProvider1.SetError(txt_provincia, "")
            ErrorProvider1.SetError(txt_distrito, "")
            ErrorProvider1.SetError(cmb_canal, "")
            ErrorProvider1.SetError(txt_volumen, "")
            ErrorProvider1.SetError(txt_importe, "")

            If txt_documento.Text = "" Then
                ErrorProvider1.SetError(txt_documento, "Ingrese Documento")
                retorno = False
            End If

            If txt_ruccliente.Text = "" Then
                ErrorProvider1.SetError(txt_ruccliente, "Ingrese Ruc de Cliente")
                retorno = False
            End If

            If txt_nombrecliente.Text = "" Then
                ErrorProvider1.SetError(txt_nombrecliente, "Ingrese Nombre de Cliente")
                retorno = False
            End If

            If txt_direccion.Text = "" Then
                ErrorProvider1.SetError(txt_direccion, "Ingrese Direccion de Cliente")
                retorno = False
            End If

            If txt_departamento.Text = "" Then
                ErrorProvider1.SetError(txt_departamento, "Ingrese Departamento de despacho")
                retorno = False
            End If

            If txt_provincia.Text = "" Then
                ErrorProvider1.SetError(txt_provincia, "Ingrese Provincia de despacho")
                retorno = False
            End If

            If txt_distrito.Text = "" Then
                ErrorProvider1.SetError(txt_distrito, "Ingrese Distrito de despacho")
                retorno = False
            End If

            If txt_volumen.Text = "" Then
                ErrorProvider1.SetError(txt_volumen, "Ingrese Volumen de despacho")
                retorno = False
            Else
                If ValidarDecimal(txt_volumen.Text) = False Then
                    ErrorProvider1.SetError(txt_volumen, "Volumen debe ser un dato numérico")
                    retorno = False
                Else
                    If CType(txt_volumen.Text, Decimal) <= 0 Then
                        ErrorProvider1.SetError(txt_volumen, "Volumen debe ser mayor a 0")
                        retorno = False
                    End If
                End If
            End If
            If txt_importe.Text = "" Then
                ErrorProvider1.SetError(txt_importe, "Ingrese Importe de despacho")
                retorno = False
            Else
                If ValidarDecimal(txt_importe.Text) = False Then
                    ErrorProvider1.SetError(txt_importe, "Importe debe ser un dato numérico")
                    retorno = False
                Else
                    If CType(txt_importe.Text, Decimal) < 0 Then
                        ErrorProvider1.SetError(txt_importe, "Impore debe ser mayor o igual 0")
                        retorno = False
                    End If
                End If
            End If

        Catch ex As Exception

        End Try

        Return retorno
    End Function

    Public Function ValidarDecimal(Dato As String) As Boolean
        Dim retorno As Boolean = Regex.IsMatch(Dato, "^[0-9]+(\,([0-9])+)?$")
        Return retorno
    End Function

    Public Sub CargaInicial()
        Try
            CargarCentrosCosto()
            ListarCaneles()
            cmb_canal.SelectedIndex = 0
        Catch ex As Exception

        End Try
    End Sub

    Public Sub ListarCaneles()
        Try
            dt_Caneles = almacenObj.ListarCaneles
            If dt_Caneles.Rows.Count > 0 Then
                cmb_canal.DataSource = dt_Caneles
                cmb_canal.DisplayMember = "TG_CDESCRI"
                cmb_canal.ValueMember = "TG_CDESCRI"
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click
        Try
            If ValidarAceptar() = True Then
                idcosto = Cmb_Costos.SelectedValue
                nombrecosto = Cmb_Costos.Text.ToString
                grabado = True
                Me.Close()
            Else
                MsgBox("Existen Erroes, Valide e intente nuevamente", MsgBoxStyle.Exclamation, "SISTEMAS NORDIC")
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub txt_ruccliente_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_ruccliente.KeyUp
        If e.KeyCode = Keys.Enter Then
            If txt_ruccliente.Text <> "" Then
                Dim DtCliente, DtDirecciones As New DataTable

                DtCliente = LlamarObtenerDatosCliente(txt_ruccliente.Text.Trim)
                If DtCliente.Rows.Count > 0 Then
                    txt_nombrecliente.Text = DtCliente.Rows(0).Item("NombreCliente").ToString.Trim
                    If DtCliente.Rows(0).Item("CANAL_ DISTRIB").ToString.Trim <> "" Then
                        cmb_canal.SelectedValue = DtCliente.Rows(0).Item("CANAL_ DISTRIB").ToString.Trim
                    End If
                End If
                DtDirecciones = LlamarObtenerDireccionesCliente(txt_ruccliente.Text.Trim)
                If DtDirecciones.Rows.Count > 0 Then
                    cmb_direcciones.DataSource = DtDirecciones
                    cmb_direcciones.DisplayMember = "DIREC_ENTREGA"

                End If
            End If
        End If
    End Sub

    Public Function LlamarObtenerDatosCliente(Ruc As String) As DataTable
        Dim DtRetorno As New DataTable

        Try
            DtRetorno = almacenObj.ObtenerDatosCliente(Ruc)
        Catch ex As Exception
            Throw ex
        End Try

        Return DtRetorno

    End Function

    Private Sub cmb_direcciones_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmb_direcciones.SelectionChangeCommitted
        If cmb_direcciones.Items.Count > 0 Then
            Dim Row As DataRowView = cmb_direcciones.SelectedItem
            txt_departamento.Text = Row.Item("DEPARTAMENTO").ToString.Trim
            txt_direccion.Text = Row.Item("DIREC_ENTREGA").ToString.Trim
            txt_distrito.Text = Row.Item("DISTRITO").ToString.Trim
            txt_provincia.Text = Row.Item("PROVINCIA").ToString.Trim
            ' txt_distrito.Text = Row.Item("DISTRITO").ToString
        End If
    End Sub

    Public Function LlamarObtenerDireccionesCliente(Ruc As String) As DataTable
        Dim DtRetorno As New DataTable

        Try
            DtRetorno = almacenObj.ObtenerDireccionesCliente(Ruc)
        Catch ex As Exception
            Throw ex
        End Try

        Return DtRetorno

    End Function

End Class