Imports System.Configuration
Imports Nordic.Bl.Be

Public Class GestionAnulacionPicking
    Private ObjAlmacen As New AlmacenL
    Public usr_id, perfilusuario As Integer
    Public usr_usuario As String
    Public codalmacen, tipdoc, nrodoc, fechaR, direccionclienteR, ruccliente, clienterazon, codpedido As String
    Private dtDetalle As New DataTable
    Private Estructura As New EstructuraTabla
    Private idalmacen As Integer = 0, idsite As Integer = 0

    Private Sub cmdCerrar_Click(sender As Object, e As EventArgs) Handles cmdCerrar.Click
        Me.Close()
    End Sub

    Private Sub GestionAnulacionPicking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            idalmacen = CType(ConfigurationManager.AppSettings("idalmac").ToString.Trim, Integer)
            idsite = CType(ConfigurationManager.AppSettings("CodigoSite").ToString.Trim, Integer)
            CargaInicial()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargaInicial()
        Try
            FormatoTablaDetalle()
            ListarGuiasCabecera()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ListarGuiasCabecera()
        Try
            If Dg_Cabecera.Rows.Count > 0 Then
                Dg_Cabecera.Rows.Clear()
            End If
            Dim dtretorno As New DataTable
            dtretorno = LlamarListarGuiasAnularPicking()

            If dtretorno.Rows.Count > 0 Then

                Dim contador As Integer = 0
                For Each RowRetorno As DataRow In dtretorno.Rows
                    Dg_Cabecera.Rows.Add()
                    Dg_Cabecera.Rows(contador).Cells("MARCAR").Value = False
                    Dg_Cabecera.Rows(contador).Cells("CODALMACEN_ORIGEN").Value = RowRetorno.Item("CODALMACEN_ORIGEN").ToString.Trim
                    Dg_Cabecera.Rows(contador).Cells("ALAMACEN_ORIGEN").Value = RowRetorno.Item("ALAMACEN_ORIGEN").ToString.Trim
                    Dg_Cabecera.Rows(contador).Cells("TIP_DOC").Value = RowRetorno.Item("TIP_DOC").ToString.Trim
                    Dg_Cabecera.Rows(contador).Cells("NDOCUMENTO").Value = RowRetorno.Item("NDOCUMENTO").ToString.Trim
                    Dg_Cabecera.Rows(contador).Cells("FECHA").Value = RowRetorno.Item("FECHA").ToString.Trim
                    Dg_Cabecera.Rows(contador).Cells("TIPO_MOV").Value = RowRetorno.Item("TIPO_MOV").ToString.Trim
                    Dg_Cabecera.Rows(contador).Cells("COD_PEDIDO").Value = RowRetorno.Item("COD_PEDIDO").ToString.Trim
                    Dg_Cabecera.Rows(contador).Cells("MOVIMIENTO").Value = RowRetorno.Item("MOVIMIENTO").ToString.Trim
                    Dg_Cabecera.Rows(contador).Cells("RUC").Value = RowRetorno.Item("RUC").ToString.Trim
                    Dg_Cabecera.Rows(contador).Cells("CLIENTE").Value = RowRetorno.Item("CLIENTE").ToString.Trim
                    Dg_Cabecera.Rows(contador).Cells("DIRECCIONCLIENTE").Value = RowRetorno.Item("DIRECCIONCLIENTE").ToString.Trim
                    Dg_Cabecera.Rows(contador).Cells("ESTADO").Value = RowRetorno.Item("ESTADO").ToString.Trim
                    Dg_Cabecera.Rows(contador).Cells("PICADOR").Value = RowRetorno.Item("PICADOR").ToString.Trim
                    Dg_Cabecera.Rows(contador).Cells("FILTRO").Value = RowRetorno.Item("FILTRO").ToString.Trim
                    contador = contador + 1
                Next
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function LlamarListarGuiasAnularPicking() As DataTable
        Dim fechadesde, fechahasta, mes, dia As String

        mes = dt_desde.Value.Month.ToString
        If mes.Length = 1 Then
            mes = "0" + mes
        End If
        dia = dt_desde.Value.Day.ToString
        If dia.Length = 1 Then
            dia = "0" + dia
        End If

        fechadesde = dt_desde.Value.Year.ToString + "/" + mes + "/" + dia


        mes = dt_hasta.Value.Month.ToString
        If mes.Length = 1 Then
            mes = "0" + mes
        End If
        dia = dt_hasta.Value.Day.ToString
        If dia.Length = 1 Then
            dia = "0" + dia
        End If

        fechahasta = dt_hasta.Value.Year.ToString + "/" + mes + "/" + dia
        Dim dtretono As DataTable
        Try
            dtretono = ObjAlmacen.ListarGuiasAnularPicking(fechadesde, fechahasta, idsite, idalmacen).Copy
        Catch ex As Exception
            Throw ex
        End Try
        Return dtretono
    End Function

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            ListarGuiasCabecera()
        Catch ex As Exception

        End Try
    End Sub

    Public Function LlamarRevertirPicking(iddetalle As Integer, userid As Integer) As Integer
        Dim RP As Integer
        Try
            RP = ObjAlmacen.ReveritrDetallePickin(iddetalle, userid)
        Catch ex As Exception
            Throw ex
        End Try
        Return RP
    End Function

    Public Function llamarRegistrarImpresion(codalmacen As String, ctd As String, numero As String, estado As String, idpicador As Integer, idfiltro As Integer, userimpresion As Integer) As Integer
        Dim RP As Integer
        Try
            RP = ObjAlmacen.CambiarEstadoGuia(codalmacen, ctd, numero, estado, idpicador, idfiltro, userimpresion, "")
        Catch ex As Exception
            Throw ex
        End Try
        Return RP
    End Function

    Private Sub cmdGenerarExcel_Click(sender As Object, e As EventArgs) Handles cmdGenerarExcel.Click
        Dim rp As Integer = 0
        Try
            If Dg_Cabecera.Rows.Count Then
                ObtenerGuiaCab()
                If nrodoc <> "" And tipdoc <> "" And codalmacen <> "" Then
                    If MessageBox.Show("Está seguro que desea revertir el Picking de la guia : " + nrodoc + " ?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        Dim dtDetalle As New DataTable
                        dtDetalle = llamarObtenerDetallePicking()
                        If dtDetalle.Rows.Count > 0 Then
                            For Each DtRow As DataRow In dtDetalle.Rows
                                rp = LlamarRevertirPicking(CType(DtRow.Item("dopa_iddetalle").ToString.Trim, Integer), usr_id)
                                If rp = 0 Then
                                    MsgBox("Error al Revertir Picking, Contactar con el area de sistemas y validar los ingresos", MsgBoxStyle.Exclamation, "SISTEMAS NORDIC")
                                    Exit For
                                End If
                            Next
                            If rp <> 0 Then
                                llamarRegistrarImpresion(codalmacen, tipdoc, nrodoc, "PA", 0, 0, 0)
                                MsgBox("Reversion de Picking Existosa", MsgBoxStyle.Information, "SISTEMAS NORDIC")
                                ListarGuiasCabecera()
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub FormatoTablaDetalle()
        dtDetalle.Clear()
        dtDetalle = Estructura.TablaDetalleGuia
    End Sub

    Public Sub ObtenerGuiaCab()
        Try
            If Dg_Cabecera.Rows.Count > 0 Then
                codalmacen = Dg_Cabecera.CurrentRow.Cells("CODALMACEN_ORIGEN").EditedFormattedValue.ToString.Trim
                tipdoc = Dg_Cabecera.CurrentRow.Cells("TIP_DOC").EditedFormattedValue.ToString.Trim
                nrodoc = Dg_Cabecera.CurrentRow.Cells("NDOCUMENTO").EditedFormattedValue.ToString.Trim
                fechaR = Dg_Cabecera.CurrentRow.Cells("FECHA").EditedFormattedValue.ToString.Trim
                direccionclienteR = Dg_Cabecera.CurrentRow.Cells("DIRECCIONCLIENTE").EditedFormattedValue.ToString.Trim
                ruccliente = Dg_Cabecera.CurrentRow.Cells("RUC").EditedFormattedValue.ToString.Trim
                clienterazon = Dg_Cabecera.CurrentRow.Cells("CLIENTE").EditedFormattedValue.ToString.Trim
                codpedido = Dg_Cabecera.CurrentRow.Cells("COD_PEDIDO").EditedFormattedValue.ToString.Trim
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Function LlamarListarGuiasDET() As DataTable

        Dim dtretono As DataTable
        Try
            dtretono = ObjAlmacen.ListarGuiasDET(codalmacen, tipdoc, nrodoc, idalmacen, idsite).Copy
        Catch ex As Exception
            Throw ex
        End Try
        Return dtretono
    End Function

    Public Function llamarObtenerDetallePicking() As DataTable

        Dim dtretono As DataTable
        Try
            dtretono = ObjAlmacen.ObtenerDetallePickin(codalmacen, tipdoc, nrodoc).Copy
        Catch ex As Exception
            Throw ex
        End Try
        Return dtretono
    End Function

    Public Function LlamarObtenerCantiSalida(codarticulo As String, serie As String, item As String) As DataTable
        Dim rpRetorno As New DataTable
        Try
            rpRetorno = ObjAlmacen.ObtenerCantidadSalidaDetalle(codalmacen, tipdoc, nrodoc, codarticulo, serie, item, idsite, idalmacen)
        Catch ex As Exception

        End Try
        Return rpRetorno
    End Function
    Public Sub ListarGuiasDetalle()
        Try
            Dim dtretorno As New DataTable
            dtretorno = LlamarListarGuiasDET()

            If dtretorno.Rows.Count > 0 Then
                dtDetalle.Rows.Clear()
                For Each RowRetorno As DataRow In dtretorno.Rows
                    Dim rowDetalle As DataRow
                    rowDetalle = dtDetalle.NewRow
                    rowDetalle.Item("CODIGO") = RowRetorno.Item("CODIGO").ToString.Trim
                    rowDetalle.Item("PRODUCTO") = RowRetorno.Item("PRODUCTO").ToString.Trim
                    rowDetalle.Item("UNIDAD") = RowRetorno.Item("UNIDAD").ToString.Trim
                    rowDetalle.Item("FACTORCAJA") = RowRetorno.Item("FACTORCAJA").ToString.Trim
                    rowDetalle.Item("C6_CITEM") = RowRetorno.Item("C6_CITEM").ToString.Trim

                    If RowRetorno.Item("FACTORCAJAMASTER").ToString.Trim <> "" Then
                        rowDetalle.Item("FACTORCAJAMASTER") = CType(RowRetorno.Item("FACTORCAJAMASTER").ToString.Trim, Decimal)
                    Else
                        rowDetalle.Item("FACTORCAJAMASTER") = 0
                    End If
                    rowDetalle.Item("SERIE") = RowRetorno.Item("SERIE").ToString.Trim
                    rowDetalle.Item("FECHA_VECIMIENTO") = RowRetorno.Item("FECHA_VECIMIENTO").ToString.Trim
                    rowDetalle.Item("CANTIDAD") = RowRetorno.Item("CANTIDAD")

                    'rowDetalle.Item("SALDO") = RowRetorno.Item("SALDO")
                    Dim rp As New DataTable
                    rp = LlamarObtenerCantiSalida(rowDetalle.Item("CODIGO").ToString.Trim, rowDetalle.Item("SERIE").ToString.Trim, rowDetalle.Item("C6_CITEM").ToString.Trim)
                    If rp.Rows.Count > 0 Then
                        Dim SaliCant = CType(rp.Rows(0).Item("Salida").ToString, Integer)
                        rowDetalle.Item("SALDO") = CType(rowDetalle.Item("CANTIDAD"), Integer) - SaliCant
                    Else
                        rowDetalle.Item("SALDO") = rowDetalle.Item("CANTIDAD")
                    End If

                    If rowDetalle.Item("UNIDAD").ToString.Trim = "UND" Then
                        If rowDetalle.Item("FACTORCAJA") <> 0 Then
                            rowDetalle.Item("CAJAS") = rowDetalle.Item("SALDO").ToString / rowDetalle.Item("FACTORCAJA")
                        Else
                            rowDetalle.Item("CAJAS") = 0
                        End If
                        If rowDetalle.Item("FACTORCAJAMASTER") <> 0 And rowDetalle.Item("CAJAS") <> 0 Then
                            rowDetalle.Item("CAJASMASTER") = Math.Round(CType(rowDetalle.Item("CAJAS").ToString, Decimal) / CType(rowDetalle.Item("FACTORCAJAMASTER"), Decimal), 2)
                        Else
                            rowDetalle.Item("CAJASMASTER") = 0
                        End If
                    End If

                    If rowDetalle.Item("UNIDAD").ToString.Trim = "CJA" Then
                        rowDetalle.Item("CAJAS") = rowDetalle.Item("SALDO")
                        If rowDetalle.Item("FACTORCAJAMASTER") <> 0 And rowDetalle.Item("CAJAS") <> 0 Then
                            rowDetalle.Item("CAJASMASTER") = Math.Round(CType(rowDetalle.Item("CAJAS").ToString, Decimal) / CType(rowDetalle.Item("FACTORCAJAMASTER"), Decimal), 2)
                        Else
                            rowDetalle.Item("CAJASMASTER") = 0
                        End If
                    End If

                    rowDetalle.Item("ALTO") = RowRetorno.Item("ALTO")
                    rowDetalle.Item("LARGO") = RowRetorno.Item("LARGO")
                    rowDetalle.Item("ANCHO") = RowRetorno.Item("ANCHO")
                    If CType(rowDetalle.Item("ALTO").ToString, Decimal) <> 0 And CType(rowDetalle.Item("LARGO").ToString, Decimal) <> 0 And CType(rowDetalle.Item("ANCHO").ToString, Decimal) <> 0 And rowDetalle.Item("FACTORCAJA") <> 0 And rowDetalle.Item("FACTORCAJAMASTER") <> 0 Then
                        Dim volumencajamaster, Multiplicacion As Decimal
                        volumencajamaster = CType(rowDetalle.Item("ALTO").ToString, Decimal) * CType(rowDetalle.Item("LARGO").ToString, Decimal) * CType(rowDetalle.Item("ANCHO").ToString, Decimal)
                        Multiplicacion = (CType(rowDetalle.Item("FACTORCAJA"), Decimal) * CType(rowDetalle.Item("FACTORCAJAMASTER"), Decimal))
                        rowDetalle.Item("VOLUMEN") = Math.Round((volumencajamaster / Multiplicacion) * CType(rowDetalle.Item("SALDO"), Decimal), 2)
                    Else
                        rowDetalle.Item("VOLUMEN") = 0
                    End If

                    rowDetalle.Item("CODALMACEN_DESTINO") = RowRetorno.Item("CODALMACEN_DESTINO").ToString.Trim
                    rowDetalle.Item("ALMACEN_DESTINO") = RowRetorno.Item("ALMACEN_DESTINO").ToString.Trim
                    rowDetalle.Item("CANAL") = RowRetorno.Item("CANAL").ToString.Trim
                    rowDetalle.Item("RUC") = RowRetorno.Item("RUC").ToString.Trim
                    rowDetalle.Item("CLIENTE") = RowRetorno.Item("CLIENTE")
                    rowDetalle.Item("DEPARTAMENTO") = RowRetorno.Item("DEPARTAMENTO").ToString.Trim
                    rowDetalle.Item("PROVINCIA") = RowRetorno.Item("PROVINCIA").ToString.Trim
                    rowDetalle.Item("DISTRITO") = RowRetorno.Item("DISTRITO").ToString.Trim
                    rowDetalle.Item("TRANSPORTES") = RowRetorno.Item("TRANSPORTES").ToString.Trim
                    rowDetalle.Item("SALIDA") = False
                    dtDetalle.Rows.Add(rowDetalle)
                Next
                'DG.DataSource = dtDetalle
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Function ValidarDetalle() As Boolean
        Dim rp As Boolean = False
        Try
            For Each rowDetalle As DataRow In dtDetalle.Rows
                If rowDetalle.Item("SERIE") = "" Or rowDetalle.Item("SERIE") = "SIN/LOTE" Then
                    rp = True
                    Exit For
                End If
            Next
        Catch ex As Exception
            Throw ex
        End Try
        Return rp
    End Function

    Private Sub cmdVerReporte_Click(sender As Object, e As EventArgs) Handles cmdVerReporte.Click

        Try
            If Dg_Cabecera.Rows.Count > 0 Then

                ObtenerGuiaCab()
                ' Dim dtDetalle As New DataTable
                ListarGuiasDetalle()

                If dtDetalle.Rows.Count > 0 Then

                    If ValidarDetalle() = False Then
                        If nrodoc <> "" Then
                            Dim reporte As New HojaPicking With {
                                .codigoguia = nrodoc,
                                .DtDetallePedido = dtDetalle,
                                .idperfil = perfilusuario,
                                .codalmacen = codalmacen,
                                .fechapedido = fechaR,
                                .razoncliente = clienterazon,
                                .ruccliente = ruccliente,
                                .direccioncliente = direccionclienteR,
                                .codpedido = codpedido
                            }
                            reporte.Show()
                        End If
                    Else
                        ''ErrorProvider1.SetError(btn_imprimir, "Pedido Tiene Articulos Sin Lote")
                    End If
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try

    End Sub
End Class