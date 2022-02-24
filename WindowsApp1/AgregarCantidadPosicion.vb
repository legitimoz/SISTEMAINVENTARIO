Imports System.Text.RegularExpressions
Imports Nordic.Bl.Be

Public Class AgregarCantidadPosicion
    Public VolumenDisponible, userid, idposicion, idsite, idalmacen, idrack As Integer
    Public grabado As Boolean = False
    Private dtdatosingreso As New DataTable
    Private Estructura As New EstructuraTabla
    Public unidades, cajas, cajasmaster, volumen, total, largo, alto, ancho, factorcaja, factormaster As Decimal
    Public codalma, nrodoc, tipdoc, codprod, lote, unidad, codpos, nombrealmacen, nombresite, numeracionRACK, articuloNombre, vencimiento, correlativo As String
    Private almacenobj As New AlmacenL

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        Try
            If codprod <> "" And articuloNombre <> "" Then
                'Dim nombre As String
                ''Entrada de datos mediante un inputbox
                'nombre = InputBox("Ingrese Cantidad de Rotulos ", "Cantidad Rotulos", "", 100, 50)
                'MessageBox.Show("" + nombre, "",
                '                MessageBoxButtons.OK,
                '                MessageBoxIcon.Information


                Dim cantrotuForm As New CantidadRotulos
                cantrotuForm.ShowDialog()
                If cantrotuForm.grabado = True Then
                    Dim cantidad = cantrotuForm.cantidad
                    If cantidad <> 0 Then
                        Dim Obj As New Demo
                        For Index As Integer = 1 To cantidad
                            Obj.ImprimirRotuloArticulo("RetuloArticuloIngreso.rdlc", codprod, articuloNombre, vencimiento, lote, factorcaja.ToString + " UND", (factorcaja * factormaster).ToString + " UND")
                        Next
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub



    Public Function LlamarRegistrar() As Integer
        Try
            Return almacenobj.RegistrarOperacion(factorcaja, factormaster, unidad, codalma, nrodoc, tipdoc, userid, codprod, lote, idposicion, CType(txt_cantidadIngreso.Text, Decimal), total, volumen, "E", idsite, idalmacen, idrack, vencimiento, correlativo)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub Aceptar()
        ErrorProvider1.SetError(txt_cantidadIngreso, "")
        Try
            If txt_cantidadIngreso.Text <> "" Then
                If ValidarDecimal(txt_cantidadIngreso.Text) Then
                    If CType(txt_cantidadIngreso.Text, Decimal) > 0 Then
                        If CType(txt_cantidadIngreso.Text, Decimal) > unidades Then
                            ErrorProvider1.SetError(txt_cantidadIngreso, "Cantidad Digitada Supera a Cantidad de Ingreso")
                        Else
                            If alto <> 0 And largo <> 0 And ancho <> 0 And factorcaja <> 0 And factormaster <> 0 Then
                                Dim volumencajamaster, Multiplicacion As Decimal
                                volumencajamaster = alto * largo * ancho
                                Multiplicacion = factormaster * factorcaja
                                volumen = Math.Round((volumencajamaster / Multiplicacion) * CType(txt_cantidadIngreso.Text, Decimal), 2)
                            Else
                                volumen = 0
                            End If
                            If volumen > VolumenDisponible Then
                                If MessageBox.Show("Volumen de Ingreso Supera Volumen Disponible de Ubicacion, debe Observar Ubicacion. ¿Desea Continuar?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                                    If LlamarRegistrar() <> 0 Then
                                        'Dim observarForm As New ObservacionPosicionForm
                                        'observarForm.Text = "Observar Posicion"
                                        'observarForm.idrack = idrack
                                        'observarForm.idalmacen = idalmacen
                                        'observarForm.idsite = idsite
                                        'observarForm.userid = userid
                                        'observarForm.idposicion = idposicion
                                        'observarForm.codposicion = txt_codigo.Text
                                        'observarForm.almacen = nombrealmacen
                                        'observarForm.sitenombre = nombresite
                                        'observarForm.numeracion = numeracionRACK
                                        'observarForm.cantidad = unidades
                                        'observarForm.cajas = cajas
                                        'observarForm.cajasmaster = cajasmaster
                                        'observarForm.CodAlma = codalma
                                        'observarForm.CodArticulo = codprod
                                        'observarForm.codNumero = nrodoc
                                        'observarForm.tipodoc = tipdoc
                                        'observarForm.lote = lote
                                        'observarForm.ocupado = volumen
                                        'observarForm.ShowDialog()
                                        'If observarForm.grabado = True Then
                                        MsgBox("Operacion Registrada Correctamente", MsgBoxStyle.Information, "SISTEMAS NORDIC")
                                        grabado = True
                                        Me.Close()
                                        'End If
                                    Else
                                        MsgBox("Operacion No Registrada, Contactar con el Area de Sistemas", MsgBoxStyle.Critical, "SISTEMAS NORDIC")
                                    End If
                                End If
                            Else
                                If LlamarRegistrar() <> 0 Then
                                    MsgBox("Operacion Registrada Correctamente", MsgBoxStyle.Information, "SISTEMAS NORDIC")
                                    grabado = True
                                    Me.Close()
                                Else
                                    MsgBox("Operacion No Registrada, Contactar con el Area de Sistemas", MsgBoxStyle.Critical, "SISTEMAS NORDIC")
                                End If
                            End If
                        End If
                    Else
                        ErrorProvider1.SetError(txt_cantidadIngreso, "Cantidad de Ingreso debe ser mayor a 0")
                    End If
                Else
                    ErrorProvider1.SetError(txt_cantidadIngreso, "Cantidad de Ingreso debe ser dato numerico")
                End If
            Else
                ErrorProvider1.SetError(txt_cantidadIngreso, "Debe Ingresar Cantidad de Ingreso")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click
        Aceptar()
    End Sub

    Private Sub AgregarCantidadPosicion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CargaInicial()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub CargaInicial()
        FormatoTablaDetalle()
        If VolumenDisponible <> 0 Then
            txt_disponible.Text = VolumenDisponible.ToString + " Metros Cubicos"
            txt_rack.Text = "R" + numeracionRACK.ToString
        End If

        Dim rowIngreso As DataRow
        rowIngreso = dtdatosingreso.NewRow
        rowIngreso("CORRELATIVO") = correlativo
        rowIngreso("ARTICULO") = articuloNombre
        rowIngreso("LOTE") = lote
        rowIngreso("UNIDADES") = unidades
        rowIngreso("CAJAS") = cajas
        rowIngreso("CAJASMASTER") = cajasmaster
        rowIngreso("METROSCUBICOS") = volumen
        dtdatosingreso.Rows.Add(rowIngreso)

        Dg_DatosIngreso.DataSource = dtdatosingreso
        txt_cantidadIngreso.Text = CType(CType(unidades, Integer), Decimal)

    End Sub

    Public Function ValidarDecimal(Dato As String) As Boolean
        Dim retorno As Boolean = Regex.IsMatch(Dato, "^[0-9]+(\.([0-9])+)?$")
        Return retorno
    End Function

    Public Sub FormatoTablaDetalle()

        dtdatosingreso = Estructura.TablaDetalleIngreso
        Dg_DatosIngreso.DataSource = dtdatosingreso

        Dg_DatosIngreso.Columns("CORRELATIVO").HeaderText = "Correlativo"
        Dg_DatosIngreso.Columns("CORRELATIVO").Width = 270
        Dg_DatosIngreso.Columns("CORRELATIVO").ReadOnly = True
        Dg_DatosIngreso.Columns("CORRELATIVO").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_DatosIngreso.Columns("ARTICULO").HeaderText = "Articulo"
        Dg_DatosIngreso.Columns("ARTICULO").Width = 270
        Dg_DatosIngreso.Columns("ARTICULO").ReadOnly = True
        Dg_DatosIngreso.Columns("ARTICULO").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_DatosIngreso.Columns("LOTE").HeaderText = "Lote"
        Dg_DatosIngreso.Columns("LOTE").Width = 70
        Dg_DatosIngreso.Columns("LOTE").ReadOnly = True
        Dg_DatosIngreso.Columns("LOTE").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_DatosIngreso.Columns("UNIDADES").HeaderText = "Unidades"
        Dg_DatosIngreso.Columns("UNIDADES").Width = 70
        Dg_DatosIngreso.Columns("UNIDADES").ReadOnly = True
        Dg_DatosIngreso.Columns("UNIDADES").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_DatosIngreso.Columns("CAJAS").HeaderText = "Cajas"
        Dg_DatosIngreso.Columns("CAJAS").Width = 50
        Dg_DatosIngreso.Columns("CAJAS").ReadOnly = True
        Dg_DatosIngreso.Columns("CAJAS").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_DatosIngreso.Columns("CAJASMASTER").HeaderText = "Cajas Master"
        Dg_DatosIngreso.Columns("CAJASMASTER").Width = 50
        Dg_DatosIngreso.Columns("CAJASMASTER").ReadOnly = True
        Dg_DatosIngreso.Columns("CAJASMASTER").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_DatosIngreso.Columns("METROSCUBICOS").HeaderText = "Metros Cubicos"
        Dg_DatosIngreso.Columns("METROSCUBICOS").Width = 50
        Dg_DatosIngreso.Columns("METROSCUBICOS").ReadOnly = True
        Dg_DatosIngreso.Columns("METROSCUBICOS").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

    End Sub

End Class