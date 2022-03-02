Imports System.Configuration
Imports System.Text.RegularExpressions
Imports Nordic.Bl.Be

Public Class EditarSalidaAlmacen
    Public CodArticulo, articulo, Lote, codposicion, unidad, F5_CCODAGE, F5_CNUMPED, TIPDOC, correlativo As String
    Public cantidad As Decimal = 0
    Private cantidadpsocion As Decimal = 0
    Public volumen, alto, largo, ancho, unidades, total, cajas, cajasmaster, factorcaja, factormaster As Decimal
    Public dtPosiciones, dtreportePicConfirm As New DataTable
    Private ObjAlmacen As New AlmacenL
    Private Estructura As New EstructuraTabla
    Private idposicion As Integer = 0
    Public iduser, idrack, idalmacen, idsite, idmovimiento As Integer
    Public grabado As Boolean = False

    Private Sub EditarSalidaAlmacen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargaInicial()
    End Sub

    Public Sub CargaInicial()

        Try
            idalmacen = CType(ConfigurationManager.AppSettings("idalmac").ToString.Trim, Integer)
            idsite = CType(ConfigurationManager.AppSettings("CodigoSite").ToString.Trim, Integer)

            If CodArticulo <> "" And Lote <> "" And cantidad <> 0 Then
                txt_codigo.Text = CodArticulo
                txt_lote.Text = Lote
                txt_cantidadsolicitada.Text = CType(cantidad, Integer)
                txt_cantidad.Text = CType(cantidad, Integer)
                dtreportePicConfirm = Estructura.DetaleHojaPickConfirmReport
            End If
            FormatoTablaDetalle()
            Obtenerposiciones()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub FormatoTablaDetalle()

        dtPosiciones = Estructura.TablaPosicionesSalida
        Dg_DatosPosiciones.DataSource = dtPosiciones

        Dg_DatosPosiciones.Columns("esp_idespacio").Visible = False
        Dg_DatosPosiciones.Columns("idmovimiento").Visible = False

        Dg_DatosPosiciones.Columns("Espacio").HeaderText = "Cod Espacio"
        Dg_DatosPosiciones.Columns("Espacio").Width = 215
        Dg_DatosPosiciones.Columns("Espacio").ReadOnly = True
        Dg_DatosPosiciones.Columns("Espacio").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_DatosPosiciones.Columns("Cantidad").HeaderText = "Cantidad Disponible (UND)"
        Dg_DatosPosiciones.Columns("Cantidad").Width = 215
        Dg_DatosPosiciones.Columns("Cantidad").ReadOnly = True
        Dg_DatosPosiciones.Columns("Cantidad").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_DatosPosiciones.Columns("idsite").Visible = False
        Dg_DatosPosiciones.Columns("idrack").Visible = False
        Dg_DatosPosiciones.Columns("idalmacen").Visible = False

        Dg_DatosPosiciones.Columns("numeracion").Visible = False
        Dg_DatosPosiciones.Columns("ANCHO").Visible = False
        Dg_DatosPosiciones.Columns("LARGO").Visible = False
        Dg_DatosPosiciones.Columns("ALTO").Visible = False
        Dg_DatosPosiciones.Columns("FACTORCAJA").Visible = False
        Dg_DatosPosiciones.Columns("FACTORCAJAMASTER").Visible = False
    End Sub

    Public Sub Obtenerposiciones()
        If Lote <> "" And CodArticulo <> "" And cantidad <> 0 Then
            dtPosiciones = LlamarListarPosicionesHojaPicking(CodArticulo, Lote, cantidad, idalmacen, idsite)
            If dtPosiciones.Rows.Count > 0 Then
                Dg_DatosPosiciones.DataSource = dtPosiciones
            Else
                'Dim DtEquivalencia As New DataTable
                'DtEquivalencia = LlamarObtenerCodigoAlternoProducto(CodArticulo.ToString.Trim, Lote.ToString.Trim)
                'If DtEquivalencia.Rows.Count > 0 Then
                '    CodArticulo = DtEquivalencia.Rows(0).Item("dopa_codarticulo").ToString.Trim
                '    If CodArticulo IsNot Nothing Then
                '        If CodArticulo <> "" Then
                '            dtPosiciones = LlamarListarPosicionesHojaPicking(CodArticulo, Lote, cantidad)
                '            If dtPosiciones.Rows.Count > 0 Then
                '                Dg_DatosPosiciones.DataSource = dtPosiciones
                '            End If
                '        End If
                '    End If
                'End If
            End If
        End If
    End Sub

    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click
        Try
            If F5_CNUMPED <> "" And F5_CCODAGE <> "" Then
                Aceptar()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function ValidarDecimal(Dato As String) As Boolean
        Dim retorno As Boolean = Regex.IsMatch(Dato, "^[0-9]+(\.([0-9])+)?$")
        Return retorno
    End Function

    Public Sub ObtenerPosicionRow()
        Try
            idmovimiento = CType(Dg_DatosPosiciones.CurrentRow.Cells("idmovimiento").FormattedValue.ToString, Integer)
            idposicion = CType(Dg_DatosPosiciones.CurrentRow.Cells("esp_idespacio").FormattedValue.ToString, Integer)
            idsite = CType(Dg_DatosPosiciones.CurrentRow.Cells("idsite").FormattedValue.ToString, Integer)
            idrack = CType(Dg_DatosPosiciones.CurrentRow.Cells("idrack").FormattedValue.ToString, Integer)
            idalmacen = CType(Dg_DatosPosiciones.CurrentRow.Cells("idalmacen").FormattedValue.ToString, Integer)
            codposicion = Dg_DatosPosiciones.CurrentRow.Cells("Espacio").FormattedValue.ToString
            cantidadpsocion = CType(Dg_DatosPosiciones.CurrentRow.Cells("Cantidad").FormattedValue.ToString, Decimal)
        Catch ex As Exception

        End Try
    End Sub
    Public Sub calcularvolumen()
        If alto <> 0 And largo <> 0 And ancho <> 0 And factorcaja <> 0 And factormaster <> 0 Then
            Dim volumencajamaster, Multiplicacion As Decimal
            volumencajamaster = alto * largo * ancho
            Multiplicacion = factormaster * factorcaja
            volumen = Math.Round((volumencajamaster / Multiplicacion) * CType(txt_cantidad.Text, Decimal), 2)
        Else
            volumen = 0
        End If
    End Sub
    Public Sub Aceptar()
        Try
            ErrorProvider1.SetError(txt_cantidad, "")
            ErrorProvider1.SetError(Dg_DatosPosiciones, "")
            If txt_cantidad.Text <> "" Then
                If ValidarDecimal(txt_cantidad.Text) Then
                    If CType(txt_cantidad.Text, Decimal) > 0 Then
                        If CType(txt_cantidad.Text, Decimal) <= CType(txt_cantidadsolicitada.Text, Decimal) Then
                            ObtenerPosicionRow()
                            If codposicion <> "" Then
                                If CType(cantidadpsocion, Integer) >= CType(txt_cantidad.Text, Integer) Then
                                    calcularvolumen()
                                    If LlamarRegistrar() <> 0 Then
                                        MsgBox("Operacion Registrada Correctamente", MsgBoxStyle.Information)
                                        grabado = True
                                        Dim rowReporte As DataRow = dtreportePicConfirm.NewRow
                                        rowReporte.Item("CodArticulo") = CodArticulo
                                        rowReporte.Item("Articulo") = articulo
                                        rowReporte.Item("Lote") = Lote
                                        rowReporte.Item("Cantidad") = CType(txt_cantidad.Text, Decimal)
                                        rowReporte.Item("Posicion") = codposicion
                                        dtreportePicConfirm.Rows.Add(rowReporte)
                                        cantidad = cantidad - CType(txt_cantidad.Text, Decimal)
                                        If cantidad = 0 Then
                                            Me.Close()
                                        Else
                                            Obtenerposiciones()
                                            calcularvolumen()
                                            txt_cantidad.Text = cantidad
                                            txt_cantidadsolicitada.Text = cantidad
                                        End If
                                    Else
                                        MsgBox("Operacion No Registrada, Contactar con el Area de Sistemas", MsgBoxStyle.Critical)
                                    End If
                                Else
                                    ErrorProvider1.SetError(txt_cantidad, "Posiciòn no dispone del Stock Solicitado")
                                    ErrorProvider1.SetError(Dg_DatosPosiciones, "Seleccionar Otra Posicion")
                                End If
                            Else
                                MsgBox("Articulo No tiene Entradas Registradas", MsgBoxStyle.Critical)
                                Me.Close()
                            End If
                        Else
                            ErrorProvider1.SetError(txt_cantidad, "Cantidad de Salida no debe superar a Cantidad solicitada")
                        End If
                    Else
                        ErrorProvider1.SetError(txt_cantidad, "Cantidad de Ingreso debe ser mayor a 0")
                    End If
                Else
                    ErrorProvider1.SetError(txt_cantidad, "Cantidad de Ingreso debe ser dato numerico")
                End If
            Else
                ErrorProvider1.SetError(txt_cantidad, "Debe Ingresar Cantidad de Ingreso")
            End If

        Catch ex As Exception

        End Try
    End Sub

    Public Function LlamarRegistrar() As Integer
        Try
            Return ObjAlmacen.RegistrarOperacionSalida(iduser, factorcaja, factormaster, unidad, F5_CCODAGE, F5_CNUMPED, TIPDOC, CodArticulo, Lote, idposicion, CType(txt_cantidad.Text, Decimal), volumen, "S", idsite, idalmacen, idrack, idmovimiento, correlativo)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function LlamarListarPosicionesHojaPicking(codarticulo As String, lote As String, cantidad As Decimal, idalmacen As Integer, idsite As Integer) As DataTable

        Dim dtretono As DataTable
        Try
            dtretono = ObjAlmacen.ObtenerPosicionesHojaPicking(codarticulo, lote, cantidad, idalmacen, idsite).Copy
        Catch ex As Exception
            Throw ex
        End Try
        Return dtretono
    End Function


    Public Function LlamarObtenerCodigoAlternoProducto(CodArticulo As String, Serie As String) As DataTable

        Dim dtretono As DataTable
        Try
            dtretono = ObjAlmacen.ObtenrCodigoAlternoArticulo(CodArticulo, Serie).Copy
        Catch ex As Exception
            Throw ex
        End Try
        Return dtretono
    End Function

End Class