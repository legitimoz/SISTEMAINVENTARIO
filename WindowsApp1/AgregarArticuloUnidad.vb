Imports System.Configuration

Public Class AgregarArticuloUnidad
    Public grabado As Boolean = False
    Private ObjAlmacen As New AlmacenL
    Private dtalmacenessoft, dtRacks, dtposiciones As New DataTable
    Public idalmacen As Integer = 0
    Public user_id As Integer = 0
    Public idsite As Integer = 0, idrack As Integer = 0
    Public Sub CargaInicial()
        Try
            idalmacen = ConfigurationManager.AppSettings("idalmac").ToString.Trim
            idsite = ConfigurationManager.AppSettings("CodigoSite").ToString.Trim
            If idalmacen <> 0 And idsite <> 0 Then
                ListarAlmacenSoftcom()
                ListarRacks()
                idrack = cmb_Rack.SelectedValue
                LlamarListarUbicacion()
            End If

        Catch ex As Exception

        End Try
    End Sub
    Public Function ValidarAceptar() As Boolean

        Dim rp As Boolean = True
        Try
            ErrorProvider1.SetError(txt_cantidad, "")
            ErrorProvider1.SetError(txt_codarti, "")
            ErrorProvider1.SetError(txt_codlote, "")

            If txt_codarti.Text = "" Then
                ErrorProvider1.SetError(txt_codarti, "Ingrese Codigo Articulo")
                rp = False
            End If

            If txt_codlote.Text = "" Then
                ErrorProvider1.SetError(txt_codlote, "Ingrese Lote Articulo")
                rp = False
            End If

            If txt_cantidad.Text = "" Then
                ErrorProvider1.SetError(txt_cantidad, "Ingrese Cantidad Rotulos")
                rp = False
            Else
                If ValidarNumerico(txt_cantidad.Text) = False Then
                    ErrorProvider1.SetError(txt_cantidad, "Cantidad debe ser dato Numerico")
                    rp = False
                Else
                    If CType(txt_cantidad.Text, Integer) <= 0 Then
                        ErrorProvider1.SetError(txt_cantidad, "Cantidad debe ser mayor a 0")
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


    Public Function LlamarListarUbicacion() As DataTable
        Try
            Dim dtretorno As New DataTable
            dtretorno = ObjAlmacen.ListarUbicacionesXSite_Almacen(idsite, idalmacen)
            Return dtretorno
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Public Function LlamarListarRacks() As DataTable
        Try
            Dim dtretorno As New DataTable
            dtretorno = ObjAlmacen.ListarRacks(idalmacen)
            Return dtretorno
        Catch ex As Exception
            Throw ex
        End Try
    End Function

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

    Private Sub cmb_Rack_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_Rack.SelectedIndexChanged

    End Sub

    Private Sub cmb_Rack_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmb_Rack.SelectionChangeCommitted
        Try
            idrack = cmb_Rack.SelectedValue
            ListarUbicacion()

        Catch ex As Exception

        End Try
    End Sub

    Public Function LlamarListarPosiciones() As DataTable

        Dim dtretono As DataTable
        Try
            dtretono = ObjAlmacen.ListarPosiciones(idrack).Copy
        Catch ex As Exception
            Throw ex
        End Try
        Return dtretono
    End Function

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

        End Try
    End Sub

    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click
        Try
            Aceptar()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function LlamarRegistrar(CALMA As String, userid As Integer, idsite As Integer, idalmacen As Integer, idrack As Integer, codarticulo As String, serie As String, idposicion As Integer, cantidad As Integer, vencimiento As String) As Integer
        Dim rp As Integer = 0
        Try
            rp = ObjAlmacen.RegistroArticuloUnitario(CALMA, userid, idsite, idalmacen, idrack, codarticulo, serie, idposicion, cantidad, vencimiento)
        Catch ex As Exception
            Throw ex
        End Try
        Return rp
    End Function

    Public Sub Aceptar()
        Try
            If ValidarAceptar() = True Then
                ' cantidad = txt_cantidad.Text
                Dim rp As Integer = 0
                rp = LlamarRegistrar(combo_Almacen.SelectedValue.ToString.Trim, user_id, idsite, idalmacen, CType(cmb_Rack.SelectedValue.ToString.Trim, Integer), txt_codarti.Text.Trim, txt_codlote.Text.Trim, CType(cmb_posiciones.SelectedValue.ToString.Trim, Integer), CType(txt_cantidad.Text, Decimal), txt_vence.Text.Trim)
                If rp <> 0 Then
                    grabado = True
                    MsgBox("Articulo Registrado Correctamente", MsgBoxStyle.Information, "SISTEMAS NORDIC")
                    Me.Close()
                Else
                    MsgBox("Fallo al registrar Articulo, Contactar con el area de sistemas", MsgBoxStyle.Information, "SISTEMAS NORDIC")
                End If

            Else
                MsgBox("Existen Errores, Valide y vuelva a intentar", MsgBoxStyle.Exclamation, "SISTEMAS NORDIC")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AgregarArticuloUnidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CargaInicial()
        Catch ex As Exception
            Throw
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
End Class