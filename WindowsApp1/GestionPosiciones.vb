Imports Nordic.Bl.Be

Public Class GestionPosiciones
    Public idRack, X, Y, idalmacen, idsite As Integer
    Public n, m, Numeracion, userid As Integer
    Public unidades, cajas, cajasmaster, volumen, total, ancho, largo, alto, factorcaja, factormaster As Decimal
    Public rackcodigo, nombrealmacen, codalmacen, coddoc, tipdoc, codarticulo, Lote, unidad, NombreSite, NombreArticulo, vencimiento As String
    Public idposicionObtener As Integer = 0
    Public codPosicionObtener As String
    Private Sub cmdVerReporte_Click(sender As Object, e As EventArgs) Handles cmdVerReporte.Click

        Try

            Dim dtmovimientos As New DataTable
            dtmovimientos = LlamarListarMovimientos()
            If dtmovimientos.Rows.Count > 0 Then
                Dim reporte As New ReporteMovimientos With {
                            .almacen = txt_almacen.Text,
                            .idposicion = idposicionObtener,
                            .rack = cmb_Rack.SelectedValue,
                            .DtDetalleReporte = dtmovimientos,
                            .codposicion = codPosicionObtener
                        }
                reporte.Show()
            Else
                MsgBox("Posicion no tiene movimientos", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnRegistrarIngreso_Click(sender As Object, e As EventArgs) Handles btnRegistrarIngreso.Click
        If idposicionObtener <> 0 Then
            ' If MessageBox.Show("Está a punto de hacer una transferencia. ¿Desea Continuar?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
            Try
                Dim formTraslado As New TrasladoEntreUbicaciones
                formTraslado.idPosicion = idposicionObtener
                formTraslado.idRack = idRack
                formTraslado.numeracion = CType(cmb_Rack.Text, Integer)
                formTraslado.codposicion = codPosicionObtener
                formTraslado.idalmacen = idalmacen
                formTraslado.idsite = idsite
                formTraslado.userid = userid
                formTraslado.ShowDialog()
                ListarPosiciones()
            Catch ex As Exception

            End Try
            ' End If
        Else
            MsgBox("Debe Seleccionar Una Posicion", MsgBoxStyle.Exclamation, "Sistema Inventario")
        End If
    End Sub

    Public textbox As TextBox(,)
    Private dtposicones, dtRacks As New DataTable
    Private ObjAlmacen As New AlmacenL
    Public codigoPosicion As String = ""
    Public idposicion As Integer = 0
    Public grabado As Boolean = False
    Public Accion As String = ""

    Private Sub cmb_Rack_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmb_Rack.SelectionChangeCommitted
        Try
            Dim selectedItem As DataRowView = cmb_Rack.SelectedItem
            idRack = CType(selectedItem.Item("ra_idRack").ToString, Integer)
            X = CType(selectedItem.Item("ra_cantidadx").ToString, Integer)
            Y = CType(selectedItem.Item("ra_cantidady").ToString, Integer)

            If idRack <> 0 And X <> 0 And Y <> 0 Then
                ListarPosiciones()
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click
        Try
            grabado = True
            Me.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub GestionPosiciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CargaInicial()
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function LlamarListarMovimientos() As DataTable

        Dim dtretono As DataTable
        Try
            dtretono = ObjAlmacen.ListarMovimientosXposicion(idposicionObtener).Copy
        Catch ex As Exception
            Throw ex
        End Try
        Return dtretono
    End Function

    Public Function LlamarListarRacks() As DataTable

        Dim dtretono As DataTable
        Try
            dtretono = ObjAlmacen.ListarRacks(idalmacen).Copy
        Catch ex As Exception
            Throw ex
        End Try
        Return dtretono
    End Function
    Public Sub ListarRacks()
        Try
            dtRacks = LlamarListarRacks()
            If dtRacks.Rows.Count > 0 Then
                cmb_Rack.DataSource = dtRacks
                cmb_Rack.DisplayMember = "ra_numeracion"
                cmb_Rack.ValueMember = "ra_idRack"
            End If
        Catch ex As Exception
            Throw ex
            MsgBox(Constantes.MensajeErrorServer, MsgBoxStyle.Critical)
        End Try

    End Sub

    Public Sub CargaInicial()
        Try
            If idalmacen <> 0 And idRack <> 0 Then
                ListarRacks()
                ListarPosiciones()
                txt_almacen.Text = nombrealmacen
                cmb_Rack.SelectedValue = idRack
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function LlamarListarPosiciones() As DataTable

        Dim dtretono As DataTable
        Try
            dtretono = ObjAlmacen.ListarPosiciones(idRack).Copy
        Catch ex As Exception
            Throw ex
        End Try
        Return dtretono
    End Function

    Private Sub Buton_Clicked(sender As Object, e As EventArgs)
        Try
            Dim item As Button = TryCast(sender, Button)
            If Accion = "INGRESO" Then
                If unidades > 0 Then
                    Dim AgregarCantidadPosicionForm As New AgregarCantidadPosicion
                    'AgregarCantidadPosicionForm.txt_disponible.Text = item.TabIndex
                    AgregarCantidadPosicionForm.vencimiento = vencimiento
                    AgregarCantidadPosicionForm.VolumenDisponible = item.TabIndex
                    AgregarCantidadPosicionForm.articuloNombre = NombreArticulo
                    AgregarCantidadPosicionForm.txt_codigo.Text = item.Name.ToString
                    AgregarCantidadPosicionForm.volumen = volumen
                    AgregarCantidadPosicionForm.nombrealmacen = nombrealmacen
                    AgregarCantidadPosicionForm.nombresite = NombreSite
                    AgregarCantidadPosicionForm.numeracionRACK = Numeracion
                    AgregarCantidadPosicionForm.unidades = unidades
                    AgregarCantidadPosicionForm.total = total
                    AgregarCantidadPosicionForm.cajas = cajas
                    AgregarCantidadPosicionForm.cajasmaster = cajasmaster
                    AgregarCantidadPosicionForm.largo = largo
                    AgregarCantidadPosicionForm.ancho = ancho
                    AgregarCantidadPosicionForm.alto = alto
                    AgregarCantidadPosicionForm.codalma = codalmacen
                    AgregarCantidadPosicionForm.codprod = codarticulo
                    AgregarCantidadPosicionForm.nrodoc = coddoc
                    AgregarCantidadPosicionForm.tipdoc = tipdoc
                    AgregarCantidadPosicionForm.userid = userid
                    AgregarCantidadPosicionForm.lote = Lote
                    AgregarCantidadPosicionForm.idposicion = item.ImageIndex
                    AgregarCantidadPosicionForm.idrack = idRack
                    AgregarCantidadPosicionForm.idalmacen = idalmacen
                    AgregarCantidadPosicionForm.idsite = idsite
                    AgregarCantidadPosicionForm.unidad = unidad
                    AgregarCantidadPosicionForm.factorcaja = factorcaja
                    AgregarCantidadPosicionForm.factormaster = factormaster
                    AgregarCantidadPosicionForm.ShowDialog()
                    If AgregarCantidadPosicionForm.grabado = True Then
                        grabado = True
                        Dim cantiresta As Decimal = CType(AgregarCantidadPosicionForm.txt_cantidadIngreso.Text, Decimal)
                        Me.unidades = Me.unidades - cantiresta
                        If Me.alto <> 0 And Me.largo <> 0 And Me.ancho <> 0 And Me.factorcaja <> 0 And Me.factormaster <> 0 Then
                            Dim volumencajamaster, Multiplicacion As Decimal
                            volumencajamaster = Me.alto * Me.largo * Me.ancho
                            Multiplicacion = Me.factorcaja * Me.factormaster
                            Me.volumen = Math.Round((volumencajamaster / Multiplicacion) * Me.unidades, 2)
                        Else
                            Me.volumen = 0
                        End If

                        If Me.unidad.Trim = "UND" Then
                            If factorcaja <> 0 Then
                                Me.cajas = Me.unidades / factorcaja
                            Else
                                Me.cajas = 0
                            End If
                            If factormaster <> 0 And Me.cajas <> 0 Then
                                Me.cajasmaster = Math.Round(Me.cajas / factormaster, 2)
                            Else
                                Me.cajasmaster = 0
                            End If
                        End If

                        If Me.unidad.Trim = "CJA" Then
                            Me.cajas = Me.unidades
                            If factormaster <> 0 And Me.cajas <> 0 Then
                                Me.cajasmaster = Math.Round(Me.cajas / factormaster, 2)
                            Else
                                cajasmaster = 0
                            End If
                        End If
                        ListarPosiciones()
                    End If
                    'End If
                Else
                    MsgBox("Articulo fue ingresado en su totalidad")
                End If
            End If

            If Accion = "GESTION" Then
                Dim idpos As Integer = 0
                idpos = item.ImageIndex
                ObtnerCodigoPosicion(idpos, item.Name)
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ObtnerCodigoPosicion(idps As Integer, codposicion As String)
        Try
            idposicionObtener = idps
            codPosicionObtener = codposicion

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ListarPosiciones()
        Try
            Try
                dtposicones = LlamarListarPosiciones()
                If dtposicones.Rows.Count > 0 Then
                    panelbotones.Controls.Clear()
                    Dim label2 As New Label
                    label2.Name = "label"
                    label2.Visible = False
                    label2.Location = New Point(12, 22)
                    panelbotones.Controls.Add(label2)
                    Dim a As Integer = 10
                    Dim b As Integer = 0

                    Dim merlokacionin As Point = label2.Location
                    n = Y
                    m = X
                    Dim i, j As Integer
                    For i = 1 To n
                        a = merlokacionin.X + 10
                        If i <> 1 Then
                            b = b + 45
                        End If

                        For j = 1 To m
                            If j <> 1 Then
                                a = a + 65
                            End If
                            Dim codigo As String = ""
                            Dim idespacio As Integer = 0
                            Dim disponible As Integer
                            Dim Capacidad As Decimal = 0, Ocupado As Decimal = 0
                            Dim PuntoMedio As Decimal = 0
                            Dim color As String = ""
                            For Each RowPosicion As DataRow In dtposicones.Rows

                                If CType(RowPosicion("esp_ubicacionx").ToString(), Integer) = j And CType(RowPosicion("esp_ubicaciony").ToString(), Integer) = i Then
                                    codigo = RowPosicion("esp_codigoespacio").ToString()
                                    idespacio = CType(RowPosicion("esp_idespacio").ToString(), Integer)
                                    Capacidad = CType(RowPosicion("Capacidad").ToString(), Decimal)
                                    Ocupado = CType(RowPosicion("Ocupado").ToString(), Decimal)
                                    disponible = CType(RowPosicion("Disponible").ToString(), Integer)
                                    PuntoMedio = Capacidad / 2

                                    If Ocupado = 0 Then
                                        color = "BLANCO"
                                    Else
                                        If Ocupado > 0 Then
                                            color = "VERDE"
                                        End If
                                    End If

                                    If RowPosicion("observado") = True Then
                                        color = "ROJO"
                                    End If

                                    Exit For
                                End If
                            Next

                            ''validar cuando disponible es menor a 0
                            If disponible < 0 Then
                                disponible = 0
                            End If

                            Dim buttonnew As New Button
                            buttonnew.Text = codigo
                            buttonnew.Name = codigo
                            buttonnew.TabIndex = disponible
                            buttonnew.ImageIndex = idespacio
                            If color = "BLANCO" Then
                                buttonnew.BackColor = Drawing.Color.White
                                buttonnew.ForeColor = Drawing.Color.Black

                            End If
                            If color = "VERDE" Then
                                buttonnew.BackColor = Drawing.Color.LightGreen
                                buttonnew.ForeColor = Drawing.Color.Black
                            End If

                            If color = "ROJO" Then
                                buttonnew.BackColor = Drawing.Color.IndianRed
                                buttonnew.ForeColor = Drawing.Color.Black
                            End If

                            buttonnew.Width = 60
                            buttonnew.Height = 40
                            buttonnew.Location = New Point(a, b)
                            If disponible >= volumen Then
                                buttonnew.Enabled = True
                            Else
                                'buttonnew.Enabled = False
                            End If
                            AddHandler buttonnew.Click, AddressOf Buton_Clicked
                            Me.panelbotones.Controls.Add(buttonnew)
                        Next
                    Next

                End If

            Catch ex As Exception

            End Try

        Catch ex As Exception
            Throw ex
            MsgBox(Constantes.MensajeErrorServer, MsgBoxStyle.Critical)
        End Try

    End Sub
End Class