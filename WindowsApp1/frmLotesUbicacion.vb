Imports Nordic.Bl.Be


Public Class frmLotesUbicacion


    Private mnuContextual As New ContextMenuStrip
    Friend WithEvents _BtnReAfirmar As System.Windows.Forms.Button

    Public usr_id As String
    Private Sub frmLotesUbicacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cboEstados.SelectedIndex = 0
            configurarMenucontextual()
        Catch ex As Exception

        End Try
    End Sub


    Public Sub configurarMenucontextual()
        Try

            Dim oToolStripItem1 As New ToolStripMenuItem
            oToolStripItem1.Text = "Reafirmar Ubicación"
            oToolStripItem1.Tag = "1"
            AddHandler oToolStripItem1.Click, AddressOf _BtnReAfirmar_Click
            mnuContextual.Items.Add(oToolStripItem1)

            dgvListarLotesUbicaciones.ContextMenuStrip = mnuContextual

        Catch ex As Exception

        End Try

    End Sub


    Private Sub _BtnReAfirmar_Click(sender As Object, e As EventArgs) Handles _BtnReAfirmar.Click
        Try

            Dim fila As Integer
            fila = dgvListarLotesUbicaciones.CurrentRow.Index

            If dgvListarLotesUbicaciones.Rows(fila).Cells.Item("Estado").Value = "PENDIENTE" Then
                ReafirmarUbicacion(fila)
            Else
                MessageBox.Show("No se puede reafirmar ubicación, su estado es diferente de PENDIENTE !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If


        Catch ex As Exception

        End Try
    End Sub




    Sub Cargar_Lotes_Ubicaciones_x_filtros(ByVal flag As String, ByVal fecini As String, ByVal fecfin As String, ByVal estado As String, ByVal lote As String, ByVal codigo As String)
        Try

            Dim obj As New BeLoteUbicacion
            Dim dt As DataTable

            dt = obj.Listar_Lotes_Ubicaciones_Filtros(flag, fecini, fecfin, estado, lote, codigo)

            dgvListarLotesUbicaciones.Rows.Clear()

            For i As Integer = 0 To dt.Rows.Count - 1

                dgvListarLotesUbicaciones.Rows.Add(dt.Rows(i).Item(0).ToString,
                                                   dt.Rows(i).Item(1).ToString,
                                                   dt.Rows(i).Item(2).ToString,
                                                   dt.Rows(i).Item(3).ToString,
                                                   dt.Rows(i).Item(4).ToString,
                                                   dt.Rows(i).Item(5).ToString,
                                                   dt.Rows(i).Item(6).ToString,
                                                   dt.Rows(i).Item(7).ToString,
                                                   dt.Rows(i).Item(8).ToString,
                                                   dt.Rows(i).Item(9).ToString,
                                                   dt.Rows(i).Item(10).ToString,
                                                   dt.Rows(i).Item(11).ToString,
                                                   dt.Rows(i).Item(12).ToString,
                                                   dt.Rows(i).Item(13).ToString,
                                                   dt.Rows(i).Item(14).ToString,
                                                   dt.Rows(i).Item(15).ToString,
                                                   dt.Rows(i).Item(16).ToString,
                                                   dt.Rows(i).Item(17).ToString,
                                                   dt.Rows(i).Item(18).ToString,
                                                   dt.Rows(i).Item(19).ToString,
                                                   dt.Rows(i).Item(20).ToString,
                                                   dt.Rows(i).Item(21).ToString,
                                                   dt.Rows(i).Item(22).ToString)

            Next

            tslCantFila.Text = CStr(dgvListarLotesUbicaciones.Rows.Count)
            Pintar_GrillaSemaforo()

        Catch ex As Exception

        End Try
    End Sub


    Sub Cargar_Lotes_Ubicaciones_x_fecha(ByVal fecini As String, ByVal fecfin As String)
        Try

            Dim obj As New BeLoteUbicacion
            Dim dt As DataTable

            dgvListarLotesUbicaciones.Rows.Clear()
            dt = obj.Listar_Lotes_Ubicaciones(fecini, fecfin)


            For i As Integer = 0 To dt.Rows.Count - 1

                dgvListarLotesUbicaciones.Rows.Add(dt.Rows(i).Item(0).ToString,
                                                   dt.Rows(i).Item(1).ToString,
                                                   dt.Rows(i).Item(2).ToString,
                                                   dt.Rows(i).Item(3).ToString,
                                                   dt.Rows(i).Item(4).ToString,
                                                   dt.Rows(i).Item(5).ToString,
                                                   dt.Rows(i).Item(6).ToString,
                                                   dt.Rows(i).Item(7).ToString,
                                                   dt.Rows(i).Item(8).ToString,
                                                   dt.Rows(i).Item(9).ToString,
                                                   dt.Rows(i).Item(10).ToString,
                                                   dt.Rows(i).Item(11).ToString,
                                                   dt.Rows(i).Item(12).ToString,
                                                   dt.Rows(i).Item(13).ToString,
                                                   dt.Rows(i).Item(14).ToString,
                                                   dt.Rows(i).Item(15).ToString,
                                                   dt.Rows(i).Item(16).ToString,
                                                   dt.Rows(i).Item(17).ToString,
                                                   dt.Rows(i).Item(18).ToString,
                                                   dt.Rows(i).Item(19).ToString,
                                                   dt.Rows(i).Item(20).ToString,
                                                   dt.Rows(i).Item(21).ToString,
                                                   dt.Rows(i).Item(22).ToString)

            Next


            tslCantFila.Text = CStr(dgvListarLotesUbicaciones.Rows.Count)
            Pintar_GrillaSemaforo()

        Catch ex As Exception

        End Try
    End Sub



    Sub Pintar_GrillaSemaforo()
        Try
            For i As Integer = 0 To dgvListarLotesUbicaciones.Rows.Count - 1


                If dgvListarLotesUbicaciones.Rows(i).Cells("Estado").Value = "PENDIENTE" Then
                    dgvListarLotesUbicaciones.Rows(i).Cells("Estado").Style.BackColor = Color.Yellow
                End If

                If dgvListarLotesUbicaciones.Rows(i).Cells("Estado").Value = "UBICADO" Then
                    dgvListarLotesUbicaciones.Rows(i).Cells("Estado").Style.BackColor = Color.Green
                    dgvListarLotesUbicaciones.Rows(i).Cells("Estado").Style.ForeColor = Color.White
                End If


                'If dgvListarLotesUbicaciones.Rows(i).Cells("EST_CODIGO2x").Value = "RECHAZADO" Then
                '    dgvListarLotesUbicaciones.Rows(i).Cells("color1x").Style.BackColor = Color.Red
                'End If


            Next

        Catch ex As Exception

        End Try
    End Sub


    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click

        Try
            Dim fecIni As String
            Dim fecfin As String
            Dim lote As String
            Dim codigo As String


            fecIni = dtpFecini.Value.ToShortDateString
            fecfin = dtpFecfin.Value.ToShortDateString
            lote = txtLote.Text
            codigo = txtCodigo.Text

            If cboEstados.SelectedIndex = 0 And txtLote.Text = "" And txtCodigo.Text = "" Then
                Cargar_Lotes_Ubicaciones_x_fecha(fecIni, fecfin)
            Else
                If cboEstados.SelectedIndex = 1 Then
                    Cargar_Lotes_Ubicaciones_x_filtros(0, fecIni, fecfin, "PENDIENTE", lote, codigo)
                Else
                    If cboEstados.SelectedIndex = 2 Then
                        Cargar_Lotes_Ubicaciones_x_filtros(1, fecIni, fecfin, "UBICADO", lote, codigo)
                    Else
                        If txtLote.Text <> "" Then
                            Cargar_Lotes_Ubicaciones_x_filtros(2, fecIni, fecfin, "", lote, codigo)

                        Else
                            If txtCodigo.Text <> "" Then
                                Cargar_Lotes_Ubicaciones_x_filtros(3, fecIni, fecfin, "", lote, codigo)

                            End If
                        End If
                    End If
                End If
            End If



        Catch ex As Exception

        End Try

    End Sub

    Public Sub ReafirmarUbicacion(ByVal fila As Integer)
        Try


            Dim C6_CLOCALI As String = String.Empty
            Dim C6_CALMA As String = String.Empty
            Dim C6_CTD As String = String.Empty
            Dim C6_CNUMDOC As String = String.Empty
            Dim C6_CITEM As String = String.Empty
            Dim C6_CCODIGO As String = String.Empty
            Dim C6_CSERIE As String = String.Empty
            Dim SK_CUBIAL1 As String = String.Empty
            Dim SK_CUBIAL2 As String = String.Empty
            Dim SK_CUBIAL3 As String = String.Empty
            Dim SK_CUBIAL4 As String = String.Empty
            Dim VAR_USR_ID As String = String.Empty

            Dim tipoTextoRespuesta As String = String.Empty
            Dim _textorespuesta As String = String.Empty


            C6_CLOCALI = dgvListarLotesUbicaciones.Rows(fila).Cells.Item("C6_CLOCALI").Value.ToString()
            C6_CALMA = dgvListarLotesUbicaciones.Rows(fila).Cells.Item("C6_CALMA").Value.ToString()
            C6_CTD = dgvListarLotesUbicaciones.Rows(fila).Cells.Item("C6_CTD").Value.ToString()
            C6_CNUMDOC = dgvListarLotesUbicaciones.Rows(fila).Cells.Item("C6_CNUMDOC").Value.ToString()
            C6_CITEM = dgvListarLotesUbicaciones.Rows(fila).Cells.Item("C6_CITEM").Value.ToString()
            C6_CCODIGO = dgvListarLotesUbicaciones.Rows(fila).Cells.Item("C6_CCODIGO").Value.ToString()
            C6_CSERIE = dgvListarLotesUbicaciones.Rows(fila).Cells.Item("C6_CSERIE").Value.ToString()

            'SK_CUBIAL1 = dgvListarLotesUbicaciones.CurrentRow.Cells.Item("SK_CUBIAL1").Value.ToString()
            If dgvListarLotesUbicaciones.Rows(fila).Cells.Item("SK_CUBIAL1").Value Is Nothing Then
                SK_CUBIAL1 = ""
            Else
                SK_CUBIAL1 = dgvListarLotesUbicaciones.Rows(fila).Cells.Item("SK_CUBIAL1").Value
            End If

            'SK_CUBIAL2 = dgvListarLotesUbicaciones.CurrentRow.Cells.Item("SK_CUBIAL2").Value.ToString()
            If dgvListarLotesUbicaciones.Rows(fila).Cells.Item("SK_CUBIAL2").Value Is Nothing Then
                SK_CUBIAL2 = ""
            Else
                SK_CUBIAL2 = dgvListarLotesUbicaciones.Rows(fila).Cells.Item("SK_CUBIAL2").Value
            End If

            'SK_CUBIAL3 = dgvListarLotesUbicaciones.CurrentRow.Cells.Item("SK_CUBIAL3").Value.ToString()
            If dgvListarLotesUbicaciones.Rows(fila).Cells.Item("SK_CUBIAL3").Value Is Nothing Then
                SK_CUBIAL3 = ""
            Else
                SK_CUBIAL3 = dgvListarLotesUbicaciones.Rows(fila).Cells.Item("SK_CUBIAL3").Value
            End If

            'SK_CUBIAL4 = dgvListarLotesUbicaciones.CurrentRow.Cells.Item("SK_CUBIAL4").Value.ToString()
            If dgvListarLotesUbicaciones.Rows(fila).Cells.Item("SK_CUBIAL4").Value Is Nothing Then
                SK_CUBIAL4 = ""
            Else
                SK_CUBIAL4 = dgvListarLotesUbicaciones.Rows(fila).Cells.Item("SK_CUBIAL4").Value
            End If

            VAR_USR_ID = usr_id

            Dim obj As New BeLoteUbicacion

            If SK_CUBIAL1 = "" And SK_CUBIAL2 = "" And SK_CUBIAL3 = "" And SK_CUBIAL4 = "" Then
                MessageBox.Show("No se puede reafirmar porque las ubicaciones estan vacias!!", "Aviso", MessageBoxButtons.OK)
            Else

                obj.Registrar_Actualizar_Ubicaciones(C6_CLOCALI, C6_CALMA, C6_CTD, C6_CNUMDOC, C6_CITEM, C6_CCODIGO, C6_CSERIE,
                                                      SK_CUBIAL1, SK_CUBIAL2, SK_CUBIAL3, SK_CUBIAL4, VAR_USR_ID,
                                                      tipoTextoRespuesta, _textorespuesta)


                If tipoTextoRespuesta = "1" Then
                    MessageBox.Show("Se realizo la reafirmación satisfactoriamente", "Aviso", MessageBoxButtons.OK)
                    dgvListarLotesUbicaciones.Rows(fila).Cells.Item("Estado").Value = "UBICADO"
                    dgvListarLotesUbicaciones.Rows(fila).Cells.Item("Estado").Style.BackColor = Color.Green
                    dgvListarLotesUbicaciones.Rows(fila).Cells("Estado").Style.ForeColor = Color.White
                Else
                    If tipoTextoRespuesta = "0" Then
                        MessageBox.Show("Error en la actualización: " + _textorespuesta, "Aviso", MessageBoxButtons.OK)
                    End If
                End If

            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub dgvListarLotesUbicaciones_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListarLotesUbicaciones.CellValueChanged
        Try

            Dim C6_CLOCALI As String = String.Empty
            Dim C6_CALMA As String = String.Empty
            Dim C6_CTD As String = String.Empty
            Dim C6_CNUMDOC As String = String.Empty
            Dim C6_CITEM As String = String.Empty
            Dim C6_CCODIGO As String = String.Empty
            Dim C6_CSERIE As String = String.Empty
            Dim SK_CUBIAL1 As String = String.Empty
            Dim SK_CUBIAL2 As String = String.Empty
            Dim SK_CUBIAL3 As String = String.Empty
            Dim SK_CUBIAL4 As String = String.Empty
            Dim VAR_USR_ID As String = String.Empty

            Dim tipoTextoRespuesta As String = String.Empty
            Dim _textorespuesta As String = String.Empty


            C6_CLOCALI = dgvListarLotesUbicaciones.CurrentRow.Cells.Item("C6_CLOCALI").Value.ToString()
            C6_CALMA = dgvListarLotesUbicaciones.CurrentRow.Cells.Item("C6_CALMA").Value.ToString()
            C6_CTD = dgvListarLotesUbicaciones.CurrentRow.Cells.Item("C6_CTD").Value.ToString()
            C6_CNUMDOC = dgvListarLotesUbicaciones.CurrentRow.Cells.Item("C6_CNUMDOC").Value.ToString()
            C6_CITEM = dgvListarLotesUbicaciones.CurrentRow.Cells.Item("C6_CITEM").Value.ToString()
            C6_CCODIGO = dgvListarLotesUbicaciones.CurrentRow.Cells.Item("C6_CCODIGO").Value.ToString()
            C6_CSERIE = dgvListarLotesUbicaciones.CurrentRow.Cells.Item("C6_CSERIE").Value.ToString()

            'SK_CUBIAL1 = dgvListarLotesUbicaciones.CurrentRow.Cells.Item("SK_CUBIAL1").Value.ToString()
            If dgvListarLotesUbicaciones.CurrentRow.Cells.Item("SK_CUBIAL1").Value Is Nothing Then
                SK_CUBIAL1 = ""
            Else
                SK_CUBIAL1 = dgvListarLotesUbicaciones.CurrentRow.Cells.Item("SK_CUBIAL1").Value
            End If

            'SK_CUBIAL2 = dgvListarLotesUbicaciones.CurrentRow.Cells.Item("SK_CUBIAL2").Value.ToString()
            If dgvListarLotesUbicaciones.CurrentRow.Cells.Item("SK_CUBIAL2").Value Is Nothing Then
                SK_CUBIAL2 = ""
            Else
                SK_CUBIAL2 = dgvListarLotesUbicaciones.CurrentRow.Cells.Item("SK_CUBIAL2").Value
            End If

            'SK_CUBIAL3 = dgvListarLotesUbicaciones.CurrentRow.Cells.Item("SK_CUBIAL3").Value.ToString()
            If dgvListarLotesUbicaciones.CurrentRow.Cells.Item("SK_CUBIAL3").Value Is Nothing Then
                SK_CUBIAL3 = ""
            Else
                SK_CUBIAL3 = dgvListarLotesUbicaciones.CurrentRow.Cells.Item("SK_CUBIAL3").Value
            End If

            'SK_CUBIAL4 = dgvListarLotesUbicaciones.CurrentRow.Cells.Item("SK_CUBIAL4").Value.ToString()
            If dgvListarLotesUbicaciones.CurrentRow.Cells.Item("SK_CUBIAL4").Value Is Nothing Then
                SK_CUBIAL4 = ""
            Else
                SK_CUBIAL4 = dgvListarLotesUbicaciones.CurrentRow.Cells.Item("SK_CUBIAL4").Value
            End If

            VAR_USR_ID = usr_id

            Dim obj As New BeLoteUbicacion

            If SK_CUBIAL1 = "" And SK_CUBIAL2 = "" And SK_CUBIAL3 = "" And SK_CUBIAL4 = "" Then
                MessageBox.Show("No se puede reafirmar porque las ubicaciones estan vacias!!", "Aviso", MessageBoxButtons.OK)
            Else

                obj.Registrar_Actualizar_Ubicaciones(C6_CLOCALI, C6_CALMA, C6_CTD, C6_CNUMDOC, C6_CITEM, C6_CCODIGO, C6_CSERIE,
                                                SK_CUBIAL1, SK_CUBIAL2, SK_CUBIAL3, SK_CUBIAL4, VAR_USR_ID,
                                                tipoTextoRespuesta, _textorespuesta)
            End If


            If tipoTextoRespuesta = "1" Then
                MessageBox.Show("Se actualizó ubicación satisfactoriamente", "Aviso", MessageBoxButtons.OK)
                dgvListarLotesUbicaciones.CurrentRow.Cells.Item("Estado").Value = "UBICADO"
                dgvListarLotesUbicaciones.CurrentRow.Cells.Item("Estado").Style.BackColor = Color.Green
                dgvListarLotesUbicaciones.CurrentRow.Cells.Item("Estado").Style.ForeColor = Color.White
            Else
                If tipoTextoRespuesta = "0" Then
                    MessageBox.Show("Error en la actualización: " + _textorespuesta, "Aviso", MessageBoxButtons.OK)
                End If
            End If

        Catch ex As Exception

        End Try
    End Sub


    Function ConversionFechaDate(ByVal fecha As String) As String
        Try
            Dim fechaConverDate As String = String.Empty
            Dim dia As String
            Dim mes As String
            Dim anio As String

            anio = fecha.Substring(6, 4)
            mes = fecha.Substring(3, 2)
            dia = fecha.Substring(0, 2)

            fechaConverDate = anio + "-" + dia + "-" + mes

            Return fechaConverDate

        Catch ex As Exception

            Return Nothing

        End Try
    End Function



    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        Try
            Me.Cursor = Cursors.WaitCursor

            GridAExcel(dgvListarLotesUbicaciones)

            Me.Cursor = Cursors.Default
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
                        If Col = 2 Or Col = 14 Or Col = 15 Or Col = 16 Or Col = 17 Then
                            exHoja.Cells.Item(Fila + 2, Col + 1) = ElGrid.Rows(Fila).Cells(Col).Value
                        Else
                            exHoja.Cells.Item(Fila + 2, Col + 1) = CStr(ElGrid.Rows(Fila).Cells(Col).Value)
                        End If


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


End Class