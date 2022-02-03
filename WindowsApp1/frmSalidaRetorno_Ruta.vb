
Imports Nordic.Bl.Be

Public Class frmSalidaRetorno_Ruta

    Public usr_id As String

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Try
            Dim objFrmRegRuta As New frmRegistrarRuta

            objFrmRegRuta.usr_id = usr_id
            objFrmRegRuta.flagAccion = "Nuevo"

            objFrmRegRuta.ShowDialog()


        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmSalidaRetorno_Ruta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Cargar_Transportistas()
        Catch ex As Exception

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


    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try

            If cbxTransportista.SelectedIndex = 0 Then
                Cargar_Seguimiento_Rutas(dtpFecIni.Value.ToShortDateString, dtpFecFin.Value.ToShortDateString)
            Else
                If cbxTransportista.SelectedIndex <> 0 Then
                    Cargar_Seguimiento_Rutas_Transporte(dtpFecIni.Value.ToShortDateString, dtpFecFin.Value.ToShortDateString, cbxTransportista.SelectedValue)
                End If
            End If

        Catch ex As Exception

        End Try
    End Sub


    Sub Cargar_Seguimiento_Rutas(ByVal fecIni As String, ByVal fecFin As String)
        Try

            Dim objCabRuta As New BeCabGuiaRuta
            Dim dt As DataTable

            dt = objCabRuta.Listar_Rutas_Guias_Status(fecIni, fecFin)

            If dt.Rows.Count = 0 Then
                MessageBox.Show("No se encontraron registros", "Aviso")

                dgvListadoRutas.Rows.Clear()
            Else

                dgvListadoRutas.Rows.Clear()

                For i As Integer = 0 To dt.Rows.Count - 1
                    dgvListadoRutas.Rows.Add(dt.Rows(i).Item("RUTA").ToString, dt.Rows(i).Item("TRD_CCODIGO").ToString, dt.Rows(i).Item("TR_CNOMBRE").ToString,
                                         dt.Rows(i).Item("CRG_FECHARUTA").ToString.Substring(0, 10), dt.Rows(i).Item("FechaHoraCreacion").ToString, dt.Rows(i).Item("TOTAL").ToString,
                                         dt.Rows(i).Item("TOTAL_EN").ToString, dt.Rows(i).Item("PRC_EN").ToString,
                                         dt.Rows(i).Item("TOTAL_RE").ToString, dt.Rows(i).Item("PRC_RE").ToString,
                                         dt.Rows(i).Item("TOTAL_PE").ToString, dt.Rows(i).Item("PRC_PE").ToString)
                Next

            End If

        Catch ex As Exception

        End Try
    End Sub



    Sub Cargar_Seguimiento_Rutas_Transporte(ByVal fecIni As String, ByVal fecFin As String, ByVal trd_ccodigo As String)
        Try

            Dim objCabRuta As New BeCabGuiaRuta
            Dim dt As DataTable

            dt = objCabRuta.Listar_Rutas_Guias_Status_Transporte(fecIni, fecFin, trd_ccodigo)

            If dt.Rows.Count = 0 Then
                MessageBox.Show("No se encontraron registros", "Aviso")

                dgvListadoRutas.Rows.Clear()
            Else

                dgvListadoRutas.Rows.Clear()

                For i As Integer = 0 To dt.Rows.Count - 1
                    dgvListadoRutas.Rows.Add(dt.Rows(i).Item("RUTA").ToString, dt.Rows(i).Item("TRD_CCODIGO").ToString, dt.Rows(i).Item("TR_CNOMBRE").ToString,
                                         dt.Rows(i).Item("CRG_FECHARUTA").ToString.Substring(0, 10), dt.Rows(i).Item("FechaHoraCreacion").ToString, dt.Rows(i).Item("TOTAL").ToString,
                                         dt.Rows(i).Item("TOTAL_EN").ToString, dt.Rows(i).Item("PRC_EN").ToString,
                                         dt.Rows(i).Item("TOTAL_RE").ToString, dt.Rows(i).Item("PRC_RE").ToString,
                                         dt.Rows(i).Item("TOTAL_PE").ToString, dt.Rows(i).Item("PRC_PE").ToString)
                Next

            End If

        Catch ex As Exception

        End Try
    End Sub



    Private Sub dgvListadoRutas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListadoRutas.CellContentClick
        Try

            If e.ColumnIndex = 12 Then
                Dim objFrmRegistro As New frmRegistrarRuta

                objFrmRegistro.usr_id = usr_id

                objFrmRegistro.crg_id = dgvListadoRutas.CurrentRow.Cells.Item("r_ruta").Value
                objFrmRegistro.trd_ccodigo = dgvListadoRutas.CurrentRow.Cells.Item("TRD_CCODIGO").Value
                objFrmRegistro.fechaRuta = dgvListadoRutas.CurrentRow.Cells.Item("r_fecharuta").Value

                objFrmRegistro.flagAccion = "Actualizar"

                objFrmRegistro.ShowDialog()

            End If


            If e.ColumnIndex = 13 Then
                Dim objFrmSeguimiento As New frmSeguimientoRuta

                objFrmSeguimiento.crg_id = dgvListadoRutas.CurrentRow.Cells.Item("r_ruta").Value

                objFrmSeguimiento.ShowDialog()

            End If


            If e.ColumnIndex = 14 Then
                Dim objFrmRetornoRuta As New frmRetornoRuta

                objFrmRetornoRuta.nroRuta = dgvListadoRutas.CurrentRow.Cells.Item("r_ruta").Value
                objFrmRetornoRuta.fechaRuta = dgvListadoRutas.CurrentRow.Cells.Item("r_fecharuta").Value
                objFrmRetornoRuta.transportista = dgvListadoRutas.CurrentRow.Cells.Item("r_transportista").Value
                objFrmRetornoRuta.usr_id = usr_id

                objFrmRetornoRuta.ShowDialog()

            End If


            If e.ColumnIndex = 15 Then
                Dim objImprRuta As New frmImpresionRuta

                objImprRuta.nroRuta = dgvListadoRutas.CurrentRow.Cells.Item("r_ruta").Value

                objImprRuta.ShowDialog()
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        Try
            Me.Cursor = Cursors.WaitCursor

            GridAExcel(dgvListadoRutas)

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
            Dim NCol As Integer = ElGrid.ColumnCount - 4
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
                        exHoja.Cells.Item(Fila + 2, Col + 1) = CStr(ElGrid.Rows(Fila).Cells(Col).Value)

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

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub btnRetornoProveedor_Click(sender As Object, e As EventArgs) Handles btnRetornoProveedor.Click
        Try

            Dim obj As New frmRetornoRuta
            obj.nroRuta = "SINRUTA"
            obj.usr_id = usr_id
            obj.ShowDialog()


        Catch ex As Exception

        End Try
    End Sub
End Class