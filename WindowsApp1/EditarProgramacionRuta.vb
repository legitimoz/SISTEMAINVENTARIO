Imports System.Configuration
Imports Nordic.Bl.Be

Public Class EditarProgramacionRuta
    Public dtConsolidado, dtruta, dtRutas, dtdetalleConso As New DataTable
    Public usr_id As Integer = 0
    Public Estructura As New EstructuraTabla
    Private ObjAlmacen As New AlmacenL
    Private idconsolidadoCab As Integer = 0
    Private nombreRutaCab As String = ""
    Private importe As Decimal = 0, volumen As Decimal = 0, tiempo As Decimal = 0
    Private estadoruta As String = ""


    Private Sub EditarProgramacionRuta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CargaInicial()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargaInicial()
        Try
            FormatoTablaCabecera()
            dtruta = Estructura.HojaDeRuta
            dtRutas = Estructura.RutasTemporales
            Listar()
            CarlcularValores()
        Catch ex As Exception

        End Try
    End Sub


    Public Sub Listar()
        Try
            If dtConsolidado.Rows.Count > 0 Then
                Dim contador As Integer = 0

                For Each RowConsolidad As DataRow In dtConsolidado.Rows
                    DataGridConsolidado.Rows.Add()
                    DataGridConsolidado.Rows(contador).Cells(0).Value = False
                    DataGridConsolidado.Rows(contador).Cells(1).Value = RowConsolidad.Item("RUTA").ToString.Trim
                    DataGridConsolidado.Rows(contador).Cells(2).Value = ""
                    DataGridConsolidado.Rows(contador).Cells(3).Value = RowConsolidad.Item("NOM_CLIENTE").ToString.Trim
                    DataGridConsolidado.Rows(contador).Cells(4).Value = RowConsolidad.Item("DESTINO").ToString.Trim
                    DataGridConsolidado.Rows(contador).Cells(5).Value = RowConsolidad.Item("NOM_CLIENTE").ToString.Trim
                    DataGridConsolidado.Rows(contador).Cells(6).Value = RowConsolidad.Item("DIRECCION_ENTREGA").ToString.Trim
                    DataGridConsolidado.Rows(contador).Cells(7).Value = RowConsolidad.Item("DISTRITO").ToString.Trim
                    DataGridConsolidado.Rows(contador).Cells(8).Value = RowConsolidad.Item("CANAL").ToString.Trim
                    DataGridConsolidado.Rows(contador).Cells(9).Value = RowConsolidad.Item("DETALLE").ToString.Trim
                    DataGridConsolidado.Rows(contador).Cells(10).Value = RowConsolidad.Item("RESTRICCION").ToString.Trim
                    DataGridConsolidado.Rows(contador).Cells(11).Value = RowConsolidad.Item("TOTALIMPORTE")
                    DataGridConsolidado.Rows(contador).Cells(12).Value = RowConsolidad.Item("TOTALMETROSCUBICOS")
                    DataGridConsolidado.Rows(contador).Cells(13).Value = RowConsolidad.Item("CANTIDADGUIAS")
                    DataGridConsolidado.Rows(contador).Cells(14).Value = RowConsolidad.Item("TIEMPOENTREGA")
                    DataGridConsolidado.Rows(contador).Cells(15).Value = ""
                    DataGridConsolidado.Rows(contador).Cells(16).Value = RowConsolidad.Item("idconsolidado")
                    contador = contador + 1
                Next
            End If
        Catch ex As Exception

        End Try
    End Sub
    Public Sub FormatoTablaCabecera()

        dtRutas.Clear()
        dtRutas = Estructura.RutasTemporales
        Dg_Rutas.DataSource = dtRutas

        Dg_Rutas.Columns("ids").Visible = False


        Dg_Rutas.Columns("NombreRuta").HeaderText = "Nombre Ruta"
        Dg_Rutas.Columns("NombreRuta").Width = 100
        Dg_Rutas.Columns("NombreRuta").ReadOnly = True
        Dg_Rutas.Columns("NombreRuta").Visible = True

        Dg_Rutas.Columns("Transportista").HeaderText = "Transportista"
        Dg_Rutas.Columns("Transportista").Width = 150
        Dg_Rutas.Columns("Transportista").ReadOnly = True
        Dg_Rutas.Columns("Transportista").Visible = False

        Dg_Rutas.Columns("Vehiculo").HeaderText = "Vehiculo"
        Dg_Rutas.Columns("Vehiculo").Width = 100
        Dg_Rutas.Columns("Vehiculo").ReadOnly = True
        Dg_Rutas.Columns("Vehiculo").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Dg_Rutas.Columns("Vehiculo").Visible = False

        Dg_Rutas.Columns("Importe").HeaderText = "Total Importe"
        Dg_Rutas.Columns("Importe").Width = 100
        Dg_Rutas.Columns("Importe").ReadOnly = True
        Dg_Rutas.Columns("Importe").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_Rutas.Columns("Volumen").HeaderText = "Metros Cubicos"
        Dg_Rutas.Columns("Volumen").Width = 100
        Dg_Rutas.Columns("Volumen").ReadOnly = True
        Dg_Rutas.Columns("Volumen").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_Rutas.Columns("Guias").HeaderText = "Cant. Guias"
        Dg_Rutas.Columns("Guias").Width = 100
        Dg_Rutas.Columns("Guias").ReadOnly = True
        Dg_Rutas.Columns("Guias").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_Rutas.Columns("Tiempo").HeaderText = "Tiempo Ruta"
        Dg_Rutas.Columns("Tiempo").Width = 80
        Dg_Rutas.Columns("Tiempo").ReadOnly = True
        Dg_Rutas.Columns("Tiempo").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_Rutas.Columns("Estado").HeaderText = "Estado Ruta"
        Dg_Rutas.Columns("Estado").Width = 80
        Dg_Rutas.Columns("Estado").ReadOnly = True
        Dg_Rutas.Columns("Estado").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dim btn As New DataGridViewButtonColumn With {
           .Name = "Modificar",
           .DataPropertyName = "Modificar",
           .HeaderText = "Accion",
           .Text = "Modificar",
           .UseColumnTextForButtonValue = True,
           .Width = 80
       }
        btn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Dg_Rutas.Columns.Add(btn)

    End Sub


    Private Sub DataGridConsolidado_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs)
        'Dim handler = CType(sender, DataGridView)
        'Dim row = CType(e.Data.GetData(GetType(DataGridViewRow)), DataGridViewRow)
        'handler.Rows.Add(row.Cells(0).Value, row.Cells(1).Value, row.Cells(2).Value, row.Cells(3).Value, row.Cells(4).Value, row.Cells(5).Value, row.Cells(6).Value, row.Cells(7).Value, row.Cells(8).Value, row.Cells(9).Value, row.Cells(10).Value, row.Cells(11).Value, row.Cells(12).Value)
        'handler.Sort(handler.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
        'DataGridConsolidado.Rows.RemoveAt(row.Index)
    End Sub

    Private Sub DataGridConsolidado_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs)
        ' e.Effect = DragDropEffects.Move
    End Sub

    Private Sub DataGridConsolidado_DragOver(ByVal sender As Object,
                                   ByVal e As DragEventArgs) _
        'Handles DataGridConsolidado.DragOver
        'e.Effect = DragDropEffects.Move
    End Sub

    Private Sub DataGridConsolidado_MouseDown(sender As Object,
                                    ByVal e As MouseEventArgs) _


        'Dim rowIndex As Integer = DataGridConsolidado.HitTest(e.X, e.Y).RowIndex
        'Dim cell As Integer = DataGridConsolidado.HitTest(e.X, e.Y).ColumnIndex
        'If rowIndex > -1 And cell > 0 Then
        '    Dim handler = CType(sender, DataGridView)
        '    If e.Button <> Windows.Forms.MouseButtons.Left OrElse handler.SelectedRows.Count = 0 Then Return
        '    For Each row As DataGridViewRow In handler.SelectedRows
        '        If handler.DoDragDrop(row, DragDropEffects.Move) = DragDropEffects.Move Then
        '            '  handler.Rows.Remove(row)
        '        End If
        '    Next
        'End If

    End Sub



    Private Sub Dg_Final_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs)
        Try
            Dim handler = CType(sender, DataGridView)
            Dim row As DataGridViewRow = CType(e.Data.GetData(GetType(DataGridViewRow)), DataGridViewRow)
            If row.Index >= 0 Then
                handler.Rows.Add(row.Cells(0).Value, row.Cells(1).Value, row.Cells(2).Value, row.Cells(3).Value, row.Cells(4).Value, row.Cells(5).Value, row.Cells(6).Value, row.Cells(7).Value, row.Cells(8).Value, row.Cells(9).Value, row.Cells(10).Value, row.Cells(11).Value)
                handler.Sort(handler.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
                DataGridConsolidado.Rows.RemoveAt(row.Index)
                CarlcularValores()
                CalcularFinal()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Sub CalcularFinal()
        Dim contadorfinalM As Integer = 0
        Dim metrosfinalM As Decimal = 0
        Dim importefinalM As Decimal = 0
        Dim tiempofinalM As Decimal = 0

        Try
            If DataGridConsolidado.Rows.Count > 0 Then
                For Each row As DataGridViewRow In DataGridConsolidado.Rows
                    If row.Cells(0).Value = True Then
                        contadorfinalM = contadorfinalM + row.Cells(13).Value
                        metrosfinalM = metrosfinalM + CType(row.Cells(12).Value.ToString, Decimal)
                        importefinalM = importefinalM + CType(row.Cells(11).Value.ToString, Decimal)
                        tiempofinalM = tiempofinalM + CType(row.Cells(14).Value.ToString, Decimal)
                    End If
                Next
                'metrofinal.Text = metrosfinalM.ToString
                'importefinal.Text = importefinalM.ToString
                'tiempofinal.Text = tiempofinalM.ToString
                'guiasfinal.Text = contadorfinalM.ToString
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Sub CarlcularValores()
        Dim contadornorte As Integer = 0, contadorsur As Integer = 0, contadorcentro As Integer = 0, contadoroeste As Integer = 0, contadoroeste1 As Integer = 0
        Dim contnorte As Integer = 0, contsur As Integer = 0, contcentro As Integer = 0, contoeste As Integer = 0, contoeste1 As Integer = 0
        Dim metrosnorte As Decimal = 0, metrossur As Decimal = 0, metroscentro As Decimal = 0, metroseste As Decimal = 0, metrososte1 As Decimal = 0
        Dim importenorte As Decimal = 0, importesur As Decimal = 0, importecentro As Decimal = 0, importeoeste As Decimal = 0, importeoeste1 As Decimal = 0
        Dim tiemponorte As Decimal = 0, tiemposur As Decimal = 0, tiempocentro As Decimal = 0, tiempooeste As Decimal = 0, tiempooeste1 As Decimal = 0

        Try
            If DataGridConsolidado.Rows.Count > 0 Then
                For Each row As DataGridViewRow In DataGridConsolidado.Rows
                    If row.Cells("RutaTentativa").Value.ToString.Trim = "SUR" Then
                        contsur = contsur + 1
                        contadorsur = contadorsur + row.Cells("CANTIDADGUIAS").Value
                        metrossur = metrossur + CType(row.Cells("TOTALMETROSCUBICOS").Value.ToString, Decimal)
                        importesur = importesur + CType(row.Cells("TOTALIMPORTE").Value.ToString, Decimal)
                        tiemposur = tiemposur + CType(row.Cells("TIEMPOENTREGA").Value.ToString, Decimal)
                    Else
                        If row.Cells("RutaTentativa").Value.ToString.Trim = "NORTE" Then
                            contnorte = contnorte + 1
                            contadornorte = contadornorte + row.Cells("CANTIDADGUIAS").Value
                            metrosnorte = metrosnorte + CType(row.Cells("TOTALMETROSCUBICOS").Value.ToString, Decimal)
                            importenorte = importenorte + CType(row.Cells("TOTALIMPORTE").Value.ToString, Decimal)
                            tiemponorte = tiemponorte + CType(row.Cells("TIEMPOENTREGA").Value.ToString, Decimal)
                        Else
                            If row.Cells("RutaTentativa").Value.ToString.Trim = "CENTRO" Then
                                contcentro = contcentro + 1
                                contadorcentro = contadorcentro + row.Cells("CANTIDADGUIAS").Value
                                metroscentro = metroscentro + CType(row.Cells("TOTALMETROSCUBICOS").Value.ToString, Decimal)
                                importecentro = importecentro + CType(row.Cells("TOTALIMPORTE").Value.ToString, Decimal)
                                tiempocentro = tiempocentro + CType(row.Cells("TIEMPOENTREGA").Value.ToString, Decimal)
                            Else
                                If row.Cells("RutaTentativa").Value.ToString.Trim = "OESTE" Then
                                    contoeste = contoeste + 1
                                    contadoroeste = contadoroeste + row.Cells("CANTIDADGUIAS").Value
                                    metroseste = metroseste + CType(row.Cells("TOTALMETROSCUBICOS").Value.ToString, Decimal)
                                    importeoeste = importeoeste + CType(row.Cells("TOTALIMPORTE").Value.ToString, Decimal)
                                    tiempooeste = tiempooeste + CType(row.Cells("TIEMPOENTREGA").Value.ToString, Decimal)
                                Else
                                    If row.Cells("RutaTentativa").Value.ToString.Trim = "OESTE1" Then
                                        contoeste1 = contoeste1 + 1
                                        contadoroeste1 = contadoroeste1 + row.Cells("CANTIDADGUIAS").Value
                                        metrososte1 = metrososte1 + CType(row.Cells("TOTALMETROSCUBICOS").Value.ToString, Decimal)
                                        importeoeste1 = importeoeste1 + CType(row.Cells("TOTALIMPORTE").Value.ToString, Decimal)
                                        tiempooeste1 = tiempooeste1 + CType(row.Cells("TIEMPOENTREGA").Value.ToString, Decimal)

                                    End If
                                End If
                            End If
                        End If
                    End If
                Next
                If contsur > 0 Then
                    'txtiemposur.Text = tiemposur.ToString
                    'txt_importesur.Text = importesur.ToString
                    'txt_metrossur.Text = metrossur.ToString
                    'guiassur.Text = contadorsur.ToString
                End If

                If contnorte > 0 Then
                    'txtiemponorte.Text = tiemponorte.ToString
                    'txt_importenorte.Text = importenorte.ToString
                    'txt_metrosnorte.Text = metrosnorte.ToString
                    'guiasnote.Text = contadornorte.ToString
                End If

                If contcentro > 0 Then
                    'txtiempocentro.Text = tiempocentro.ToString
                    'txt_importecentro.Text = importecentro.ToString
                    'txt_metroscentro.Text = metroscentro.ToString
                    'guiascentro.Text = contadorcentro.ToString
                End If


                If contoeste > 0 Then
                    'txtiempooeste.Text = tiempooeste.ToString
                    'txt_importeoeste.Text = importeoeste.ToString
                    'txt_metrosoeste.Text = metroseste.ToString
                    'guiasoeste.Text = contadoroeste.ToString
                End If

                If contoeste1 > 0 Then
                    'txtiempooeste1.Text = tiempooeste1.ToString
                    'txt_importeoeste1.Text = importeoeste1.ToString
                    'txt_metrosoeste1.Text = metrososte1.ToString
                    'guiasoeste1.Text = contadoroeste1.ToString
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Dg_Final_MouseDown(sender As Object,
                                    ByVal e As MouseEventArgs)


        'Dim rowIndex As Integer = Dg_Final.HitTest(e.X, e.Y).RowIndex

        'If rowIndex > -1 Then
        '    Dim handler = CType(sender, DataGridView)
        '    If e.Button <> Windows.Forms.MouseButtons.Left OrElse handler.SelectedRows.Count = 0 Then Return

        '    For Each row As DataGridViewRow In handler.SelectedRows
        '        If handler.DoDragDrop(row, DragDropEffects.Move) = DragDropEffects.Move Then
        '            '  handler.Rows.Remove(row)
        '        End If
        '    Next
        'End If

    End Sub

    Private Sub DataGridConsolidado_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs)
        Try
            If e.RowIndex >= 0 Then
                'Recalcular()
                If e.ColumnIndex = 2 Then
                    Recalcular()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Sub Recalcular()
        Dim Volumen As Decimal = 0, Tiempo As Decimal = 0, Importe As Decimal = 0
        Dim Guias As Integer = 0
        Try

            If DataGridConsolidado.Rows.Count > 0 Then
                If dtRutas.Rows.Count > 0 Then
                    For Each RowRutas As DataRow In dtRutas.Rows
                        For Each DgCon As DataGridViewRow In DataGridConsolidado.Rows
                            If RowRutas.Item("NombreRuta").ToString.Trim = DgCon.Cells(2).Value.ToString.Trim Then
                                Volumen = Volumen + DgCon.Cells(12).Value
                                Tiempo = Tiempo + DgCon.Cells(14).Value
                                Importe = Importe + DgCon.Cells(11).Value
                                Guias = Guias + DgCon.Cells(13).Value
                            End If
                        Next
                        RowRutas.Item("Volumen") = Volumen
                        RowRutas.Item("Tiempo") = Tiempo
                        RowRutas.Item("Guias") = Guias
                        RowRutas.Item("Importe") = Importe
                        Volumen = 0
                        Tiempo = 0
                        Guias = 0
                        Importe = 0
                    Next
                End If
                For Each RowRutas2 As DataRow In dtRutas.Rows
                    If RowRutas2.Item("Guias") = 0 Then
                        dtRutas.Rows.Remove(RowRutas2)
                    End If
                Next
            End If

        Catch ex As Exception

        End Try
    End Sub



    Private Sub DataGridConsolidado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        Try
            'CalcularFinal()
            If e.ColumnIndex = 0 Then
                Dim row As DataGridViewRow = DataGridConsolidado.Rows(e.RowIndex)
                row.Cells(0).Value = Not row.Cells(0).Value
            End If
            CalcularFinal()
            CarlcularValores()
        Catch ex As Exception

        End Try
    End Sub

    Public Sub EliminarRuteadas(Indices As List(Of Integer))
        Try
            'DataGridConsolidado.Rows.RemoveAt
            If Indices.Count > 0 Then
                For Index As Integer = 1 To Indices.Count
                    DataGridConsolidado.Rows.RemoveAt(Indices.ElementAt(Index - 1))
                Next
                DataGridConsolidado.Refresh()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataGridConsolidado_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs)
        'CalcularFinal()
        If e.ColumnIndex = 0 Then
            Dim row As DataGridViewRow = DataGridConsolidado.Rows(e.RowIndex)
            row.Cells(0).Value = Not row.Cells(0).Value
        End If
        CalcularFinal()
        CarlcularValores()
    End Sub

    Public Function ValidarRegistroRuta() As Boolean
        Dim RP As Boolean = False
        Try
            If DataGridConsolidado.Rows.Count > 0 Then
                For Each RowCons As DataGridViewRow In DataGridConsolidado.Rows
                    If RowCons.Cells(0).Value = True And RowCons.Cells(2).Value = "" Then
                        RP = True
                    End If
                Next
            End If
        Catch ex As Exception
            Throw ex
        End Try
        Return RP
    End Function
    Private Sub IconButton1_Click_1(sender As Object, e As EventArgs)

    End Sub
    Private Sub bt_modificar_Click(sender As Object, e As EventArgs)
        Try
            If Dg_Rutas.Rows.Count > Constantes.ValorEnteroInicial Then
                If Dg_Rutas.CurrentRow IsNot Nothing Then
                    ProcesoModificar(Dg_Rutas.CurrentRow.Cells("NombreRuta").Value.ToString.Trim)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SISTEMAS NORDIC")
        End Try
    End Sub
    Private Sub ProcesoModificar(RutaMod As String)
        Try
            For Each RowConsolidados As DataGridViewRow In DataGridConsolidado.Rows
                If RowConsolidados.Cells("Marcar").EditedFormattedValue = True Then
                    RowConsolidados.Cells("RUTA").Value = RutaMod
                End If
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub Dg_Rutas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dg_Rutas.CellContentClick
        Dim dtRutasB As New DataTable
        Dim NombreRuta As String = ""
        Dim Row As DataRow = Nothing
        Try
            If Dg_Rutas.Rows.Count > Constantes.ValorEnteroInicial Then
                If Dg_Rutas.CurrentRow IsNot Nothing Then
                    If Dg_Rutas.CurrentRow.Cells("Estado").Value <> "REGISTRADA" Then
                        NombreRuta = Dg_Rutas.CurrentRow.Cells("NombreRuta").Value.ToString.Trim
                        If DataGridConsolidado.Rows.Count > Constantes.ValorEnteroInicial Then
                            dtRutasB = Estructura.RutaPreliminar
                            For Each Rowcon As DataGridViewRow In DataGridConsolidado.Rows
                                If NombreRuta = Rowcon.Cells("RUTA").Value.ToString.Trim Or Rowcon.Cells("RUTA").Value.ToString.Trim = "" Then
                                    Row = dtRutasB.NewRow
                                    If NombreRuta = Rowcon.Cells("RUTA").Value.ToString.Trim Then
                                        Row.Item("Marcar") = True
                                    ElseIf Rowcon.Cells("RUTA").Value.ToString.Trim = "" Then
                                        Row.Item("Marcar") = False
                                    End If
                                    Row.Item("idconsolidado") = Rowcon.Cells("idconsolidado").Value.ToString
                                    Row.Item("RutaTentativa") = Rowcon.Cells("RutaTentativa").Value.ToString
                                    Row.Item("Destino") = Rowcon.Cells("DESTINO").Value
                                    Row.Item("Cliente") = Rowcon.Cells("NOM_CLIENTE").Value
                                    dtRutasB.Rows.Add(Row)
                                End If
                            Next
                            If dtRutasB.Rows.Count > Constantes.ValorEnteroInicial Then
                                Dim FormModificarRuta As New ModificarRutaPreliminar
                                FormModificarRuta.dt_Rutas = dtRutasB
                                FormModificarRuta.Ruta = NombreRuta
                                FormModificarRuta.ShowDialog()
                                If FormModificarRuta.grabado = True Then
                                    If FormModificarRuta.dt_Rutas.Rows.Count > Constantes.ValorEnteroInicial Then
                                        For Each RowMod As DataRow In FormModificarRuta.dt_Rutas.Rows
                                            If DataGridConsolidado.Rows.Count > Constantes.ValorEnteroInicial Then
                                                For Each RowConsoM As DataGridViewRow In DataGridConsolidado.Rows
                                                    If RowMod.Item("Marcar") = True Then
                                                        If RowMod.Item("idconsolidado") = RowConsoM.Cells("idconsolidado").Value Then
                                                            RowConsoM.Cells("RUTA").Value = NombreRuta
                                                            RowConsoM.Cells("Marcar").Value = True
                                                        End If
                                                    ElseIf RowMod.Item("Marcar") = False Then
                                                        If RowMod.Item("idconsolidado") = RowConsoM.Cells("idconsolidado").Value And RowConsoM.Cells("RUTA").Value = NombreRuta Then
                                                            RowConsoM.Cells("RUTA").Value = ""
                                                            RowConsoM.Cells("Marcar").Value = False
                                                        End If
                                                    End If
                                                Next
                                            End If
                                        Next
                                    End If
                                    Recalcular()
                                End If
                            End If
                        End If
                    Else
                        MsgBox("Ruta se encuentra registrada, no se peude modificar", MsgBoxStyle.Exclamation, "SISTEMAS NORDIC")
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SISTEMAS SSENDA")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            GuardarRuta()
            Recalcular()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SISTEMAS SSENDA")
        End Try
    End Sub

    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click
        Try
            Dim dtDetallePorRuta As New DataTable
            If Dg_Rutas.Rows.Count > 0 Then
                ObtenerRutaCab()
                If idconsolidadoCab <> 0 And nombreRutaCab <> "" Then
                    If estadoruta = "PENDIENTE" Then
                        If DataGridConsolidado.Rows.Count > 0 Then
                            dtDetallePorRuta = dtdetalleConso.Clone
                            For Each DgCon As DataGridViewRow In DataGridConsolidado.Rows
                                If nombreRutaCab.ToString.Trim = DgCon.Cells(2).Value.ToString.Trim Then
                                    If dtdetalleConso.Rows.Count > 0 Then
                                        For Each DetalleCon As DataRow In dtdetalleConso.Rows
                                            If CType(DgCon.Cells(16).Value.ToString.Trim, Integer) = CType(DetalleCon.Item("idconsolidado").ToString.Trim, Integer) Then
                                                dtDetallePorRuta.Rows.Add(DetalleCon.ItemArray)
                                            End If
                                        Next
                                    End If
                                End If
                            Next
                        End If
                        If dtDetallePorRuta.Rows.Count > 0 Then
                            Dim formEditRuta As New EditarRuta
                            formEditRuta.usr_id = usr_id
                            formEditRuta.nombreRutaCab = nombreRutaCab
                            formEditRuta.volumen = volumen
                            formEditRuta.tiempo = tiempo
                            formEditRuta.importe = importe
                            formEditRuta.flagAccion = "Nuevo"
                            formEditRuta.dtDetalleRuta = dtDetallePorRuta
                            formEditRuta.ShowDialog()
                            If formEditRuta.Grabado = True Then
                                For Each ruedit As DataRow In dtRutas.Rows
                                    If ruedit.Item("ids").ToString = idconsolidadoCab Then
                                        ruedit.Item("Estado") = "REGISTRADA"
                                        Exit For
                                    End If
                                Next
                            End If
                        End If
                    Else
                        MsgBox("Ruta ya se encuentra registrada", MsgBoxStyle.Exclamation, "SISTEMAS NORDIC")
                    End If
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Public Sub ObtenerRutaCab()
        Try
            If Dg_Rutas.Rows.Count > 0 Then
                idconsolidadoCab = Dg_Rutas.CurrentRow.Cells("ids").EditedFormattedValue.ToString
                nombreRutaCab = Dg_Rutas.CurrentRow.Cells("NombreRuta").EditedFormattedValue.ToString
                volumen = Dg_Rutas.CurrentRow.Cells("Volumen").EditedFormattedValue.ToString
                importe = Dg_Rutas.CurrentRow.Cells("Importe").EditedFormattedValue.ToString
                tiempo = Dg_Rutas.CurrentRow.Cells("Tiempo").EditedFormattedValue.ToString
                estadoruta = Dg_Rutas.CurrentRow.Cells("Estado").EditedFormattedValue.ToString
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Private Sub IconButton2_Click(sender As Object, e As EventArgs)
        Try
            ImprimirRuta()
        Catch ex As Exception

        End Try
    End Sub


    Public Sub GuardarRuta()
        Dim ListaIndex As New List(Of Integer)
        Dim NombreRuta As String = "RUTA " + (dtRutas.Rows.Count + 1).ToString
        Dim repartidor As String = "", movilidad As String = ""
        Dim RowRutaTemporal As DataRow = dtRutas.NewRow
        Dim Volumen As Decimal = 0, Tiempo As Decimal = 0, Importe As Decimal = 0
        Dim Guias As Integer = 0
        Try
            If ValidarRegistroRuta() = True Then
                repartidor = ""
                movilidad = ""
                For Each RowDg As DataGridViewRow In DataGridConsolidado.Rows
                    If RowDg.Cells(0).Value = True And RowDg.Cells(2).Value = "" Then
                        RowDg.Cells(2).Value = NombreRuta
                        Volumen = Volumen + RowDg.Cells(12).Value
                        Tiempo = Tiempo + RowDg.Cells(14).Value
                        Importe = Importe + RowDg.Cells(11).Value
                        Guias = Guias + RowDg.Cells(13).Value
                        RowRutaTemporal.Item("ids") = RowDg.Cells(16).Value
                    End If
                Next
                RowRutaTemporal.Item("NombreRuta") = NombreRuta
                RowRutaTemporal.Item("Transportista") = repartidor
                RowRutaTemporal.Item("Vehiculo") = movilidad
                RowRutaTemporal.Item("Volumen") = Volumen.ToString + " M3"
                RowRutaTemporal.Item("Importe") = Importe.ToString
                RowRutaTemporal.Item("Guias") = Guias.ToString
                RowRutaTemporal.Item("Tiempo") = Tiempo.ToString
                RowRutaTemporal.Item("Estado") = "PENDIENTE"
                dtRutas.Rows.Add(RowRutaTemporal)
                Dg_Rutas.DataSource = dtRutas
                'End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ImprimirRuta()
        Dim rowRuta As DataRow
        Dim nombreempresa, RUC, Direccion As String
        Dim totalvolumen As Decimal = 0

        nombreempresa = ConfigurationManager.AppSettings("Empresa").ToString.Trim
        RUC = ConfigurationManager.AppSettings("nombreAlmacen").ToString.Trim
        Direccion = ConfigurationManager.AppSettings("nombreSite").ToString.Trim

        ' Me.ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DetalleRuta", dtruta))


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
            If dtRutas.Rows.Count > 0 Then
                For Each RowR As DataRow In dtRutas.Rows
                    Dim repartidor As String = ""
                    Dim movilidad As String = ""
                    Dim Codigo As String = ""
                    repartidor = RowR.Item("Transportista").ToString.Trim
                    movilidad = RowR.Item("Vehiculo").ToString.Trim
                    Codigo = RowR.Item("NombreRuta").ToString.Trim + " - " + DateTime.Now.Day.ToString + "/" + DateTime.Now.Month.ToString + "/" + DateTime.Now.Year.ToString
                    dtruta.Rows.Clear()
                    For Each DgCon As DataGridViewRow In DataGridConsolidado.Rows
                        If RowR.Item("NombreRuta").ToString.Trim = DgCon.Cells(2).Value.ToString.Trim Then
                            For Each DetalleCon As DataRow In dtdetalleConso.Rows
                                If CType(DgCon.Cells(16).Value.ToString.Trim, Integer) = CType(DetalleCon.Item("idconsolidado").ToString.Trim, Integer) Then
                                    rowRuta = dtruta.NewRow
                                    rowRuta.Item("Numero") = dtruta.Rows.Count + 1.ToString
                                    rowRuta.Item("Guia") = DetalleCon.Item("NRO_GUIA")
                                    rowRuta.Item("Cliente") = DetalleCon.Item("NOM_CLIENTE")
                                    rowRuta.Item("Restriccion") = DetalleCon.Item("RESTRICCION")
                                    rowRuta.Item("Direccion") = DetalleCon.Item("DIRECCION_ENTREGA")
                                    rowRuta.Item("Condicion") = DetalleCon.Item("CONDICION")
                                    rowRuta.Item("Importe") = CType(DetalleCon.Item("IMPORTE"), Integer)
                                    rowRuta.Item("Representante") = DetalleCon.Item("REPRESENTANTE")
                                    rowRuta.Item("Volumen") = Math.Round(CType(DetalleCon.Item("M3UN"), Decimal), 3)
                                    rowRuta.Item("TiempoEntrega") = DetalleCon.Item("TIEMPO")
                                    dtruta.Rows.Add(rowRuta)
                                End If
                            Next

                        End If
                    Next
                    Dim reporte As New Demo
                    dtruta.TableName = "DetalleRuta"

                    '  reporte.ImprimirRuta(Codigo, nombreempresa, RUC, Direccion, logooperador, color, "HojaDeRuta.rdlc", dtruta, repartidor, movilidad, RowR.Item("Volumen"))

                Next
            End If
        Catch ex As Exception

        End Try

    End Sub

End Class