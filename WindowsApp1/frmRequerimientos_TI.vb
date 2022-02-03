Imports Nordic.Bl.Be


Public Class frmRequerimientos_TI
    Public usr_id As String
    Public prPerId As String

    Private mnuContextual As New ContextMenuStrip
    Friend WithEvents BtnRegistrarObservacion As System.Windows.Forms.Button

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Try
            Dim obj As New frmRegistroRequerimiento

            obj.usr_id = usr_id
            obj.per_id = prPerId
            obj.flagAction = "Nuevo"

            obj.ShowDialog()

            Listar_Requerimientos_Pendientes_Programados()

        Catch ex As Exception

        End Try

    End Sub


    Public Sub configurarMenucontextual()
        Try

            Dim oToolStripItem1 As New ToolStripMenuItem
            oToolStripItem1.Text = "Registrar Observacion"
            oToolStripItem1.Tag = "1"
            AddHandler oToolStripItem1.Click, AddressOf BtnRegistrarObservacion_Click
            mnuContextual.Items.Add(oToolStripItem1)

            dgvListadoRequerimientos.ContextMenuStrip = mnuContextual

        Catch ex As Exception

        End Try

    End Sub



    Private Sub BtnRegistrarObservacion_Click(sender As Object, e As EventArgs) Handles BtnRegistrarObservacion.Click
        Try

            Dim obj As New frmObsReq
            Dim req_id As String
            Dim asunto As String


            req_id = dgvListadoRequerimientos.CurrentRow.Cells.Item("req_id").Value
            asunto = dgvListadoRequerimientos.CurrentRow.Cells.Item("req_asunto").Value

            obj.nroReq = req_id
            obj.asunto = asunto
            obj.usr_id = usr_id

            obj.ShowDialog()


        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmRequerimientos_TI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            configurarMenucontextual()
            Cargar_ListaResponsables()
            Cargar_ListaEstados()
            Listar_Requerimientos_Pendientes_Programados()


            Timer1.Start()

        Catch ex As Exception

        End Try
    End Sub


    Sub Pintar_GrillaSemaforo()
        Try
            For i As Integer = 0 To dgvListadoRequerimientos.Rows.Count - 1

                If dgvListadoRequerimientos.Rows(i).Cells("est_descripcion").Value = "PENDIENTE" Then
                    dgvListadoRequerimientos.Rows(i).Cells("color1").Style.BackColor = Color.Yellow
                End If

                If dgvListadoRequerimientos.Rows(i).Cells("est_descripcion").Value = "CERRADO" Then
                    dgvListadoRequerimientos.Rows(i).Cells("color1").Style.BackColor = Color.Green
                End If

                If dgvListadoRequerimientos.Rows(i).Cells("est_descripcion").Value = "PROGRAMADO" Then
                    dgvListadoRequerimientos.Rows(i).Cells("color1").Style.BackColor = Color.Orange
                End If

                If dgvListadoRequerimientos.Rows(i).Cells("est_descripcion").Value = "ANULADO" Then
                    dgvListadoRequerimientos.Rows(i).Cells("color1").Style.BackColor = Color.Black
                End If


            Next

        Catch ex As Exception

        End Try
    End Sub


    Sub Cargar_ListaResponsables()
        Try
            Dim objReq As New BeRequerimiento
            Dim dt As New DataTable

            dt = objReq.Obtener_Responsables

            cboResponsable.DataSource = dt
            cboResponsable.ValueMember = "res_id"
            cboResponsable.DisplayMember = "res_nombre"

        Catch ex As Exception
            MessageBox.Show(ex.Message, "NORDIC", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Sub Cargar_ListaEstados()
        Try
            Dim objReq As New BeRequerimiento
            Dim dt As New DataTable

            dt = objReq.Listar_Estados()

            cboEstados.DataSource = dt
            cboEstados.ValueMember = "est_codigo"
            cboEstados.DisplayMember = "est_descripcion"

        Catch ex As Exception
            MessageBox.Show(ex.Message, "NORDIC", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try

            If chkPendProg.Checked = True Then
                Listar_Requerimientos_Pendientes_Programados()
            Else
                If chkPendProg.Checked = False Then
                    Listar_Requerimientos()
                End If

            End If



        Catch ex As Exception

        End Try

    End Sub


    Sub Listar_Requerimientos()
        Try
            Dim obj As New BeRequerimiento
            Dim dt As New DataTable

            dgvListadoRequerimientos.Rows.Clear()

            If cboResponsable.SelectedIndex = 0 And cboEstados.SelectedIndex = 0 Then
                dt = obj.Listar_Requerimientos(0, dtpFecIni.Value.ToShortDateString, dtpFecFin.Value.ToShortDateString, 0, 0)
            Else
                If cboResponsable.SelectedIndex <> 0 And cboEstados.SelectedIndex = 0 Then
                    dt = obj.Listar_Requerimientos(1, dtpFecIni.Value.ToShortDateString, dtpFecFin.Value.ToShortDateString, cboResponsable.SelectedValue, 0)
                Else
                    If cboResponsable.SelectedIndex = 0 And cboEstados.SelectedIndex <> 0 Then
                        dt = obj.Listar_Requerimientos(2, dtpFecIni.Value.ToShortDateString, dtpFecFin.Value.ToShortDateString, 0, cboEstados.SelectedValue)
                    Else
                        If cboResponsable.SelectedIndex <> 0 And cboEstados.SelectedIndex <> 0 Then
                            dt = obj.Listar_Requerimientos(3, dtpFecIni.Value.ToShortDateString, dtpFecFin.Value.ToShortDateString, cboResponsable.SelectedValue, cboEstados.SelectedValue)

                        End If
                    End If
                End If
            End If

            If dt.Rows.Count > 0 Then
                For i As Integer = 0 To dt.Rows.Count - 1

                    dgvListadoRequerimientos.Rows.Add(dt.Rows(i).Item("req_id"), "", dt.Rows(i).Item("est_descripcion").ToString,
                       dt.Rows(i).Item("req_fecreg"), dt.Rows(i).Item("req_asunto").ToString, dt.Rows(i).Item("usr_nombre").ToString,
                       dt.Rows(i).Item("emp_des").ToString, dt.Rows(i).Item("res_nombre").ToString, dt.Rows(i).Item("rpr_fecinicio"), dt.Rows(i).Item("rpr_fecfin"),
                       dt.Rows(i).Item("req_descripcion"))

                Next

                Pintar_GrillaSemaforo()

                tslCantidad.Text = CStr(dgvListadoRequerimientos.Rows.Count)
            Else
                MessageBox.Show("No se encontraron registros.", "NORDIC", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If



        Catch ex As Exception

        End Try
    End Sub



    Sub Listar_Requerimientos_Pendientes_Programados()
        Try
            Dim obj As New BeRequerimiento
            Dim dt As New DataTable

            dgvListadoRequerimientos.Rows.Clear()


            dt = obj.Listar_Requerimientos(4, 0, 0, 0, 0)


            If dt.Rows.Count > 0 Then
                For i As Integer = 0 To dt.Rows.Count - 1

                    dgvListadoRequerimientos.Rows.Add(dt.Rows(i).Item("req_id"), "", dt.Rows(i).Item("est_descripcion").ToString,
                       dt.Rows(i).Item("req_fecreg"), dt.Rows(i).Item("req_asunto").ToString, dt.Rows(i).Item("usr_nombre").ToString,
                       dt.Rows(i).Item("emp_des").ToString, dt.Rows(i).Item("res_nombre").ToString, dt.Rows(i).Item("rpr_fecinicio"), dt.Rows(i).Item("rpr_fecfin"),
                       dt.Rows(i).Item("req_descripcion"))

                Next

                Pintar_GrillaSemaforo()

                tslCantidad.Text = CStr(dgvListadoRequerimientos.Rows.Count)
            Else
                MessageBox.Show("No se encontraron registros.", "NORDIC", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If



        Catch ex As Exception

        End Try
    End Sub




    Private Sub dgvListadoRequerimientos_SelectionChanged(sender As Object, e As EventArgs) Handles dgvListadoRequerimientos.SelectionChanged
        Try
            Dim DetalleReque As String = String.Empty
            Dim idReq As Integer

            idReq = dgvListadoRequerimientos.CurrentRow.Cells.Item("req_id").Value.ToString
            DetalleReque = dgvListadoRequerimientos.CurrentRow.Cells.Item("req_descripcion").Value.ToString


            rtbDetalleReq.Text = DetalleReque
            Listar_Documentos_Adjuntos(idReq)
            Listar_Observaciones(idReq)

        Catch ex As Exception

        End Try
    End Sub


    Sub Listar_Observaciones(ByVal idReq As String)
        Try

            Dim dt As New DataTable
            Dim obj As New BeRequerimiento

            dt = obj.Listar_Observaciones(idReq)

            dgvListarObservaciones.DataSource = dt

            dgvListarObservaciones.Columns(0).Width = 50
            dgvListarObservaciones.Columns(1).Width = 50
            dgvListarObservaciones.Columns(2).Width = 130
            dgvListarObservaciones.Columns(3).Width = 130
            dgvListarObservaciones.Columns(4).Width = 1000

        Catch ex As Exception

        End Try
    End Sub

    Sub Listar_Documentos_Adjuntos(ByVal idReq As Integer)
        Try

            Dim obj As New BeRequerimiento
            Dim dt As DataTable

            dgvArchivosAdjuntos.Rows.Clear()

            dt = obj.Listar_Documentos_Adjuntos(idReq)

            For i As Integer = 0 To dt.Rows.Count - 1

                dgvArchivosAdjuntos.Rows.Add(dt.Rows(i).Item("filename"), dt.Rows(i).Item("ruta"))
            Next

        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvArchivosAdjuntos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvArchivosAdjuntos.CellContentClick
        Try
            Dim ruta As String = String.Empty

            If e.ColumnIndex = 2 Then


                ruta = dgvArchivosAdjuntos.CurrentRow.Cells.Item("ruta").Value

                'ruta = "G:\INSTITUCIONAL\CARGOS\F203-00\142_FT_F203_0000046.pdf"

                Process.Start(ruta)

            End If
        Catch ex As Exception

            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        Try
            Me.Cursor = Cursors.WaitCursor

            GridAExcel(dgvListadoRequerimientos)

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
                'If i <> 1 And i <> 10 And i <> 11 And i <> 12 Then
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
                    If Col <> 1 And Col <> 10 And Col <> 11 And Col <> 12 And Col <> 13 Then

                        If ElGrid.Rows(Fila).Cells(Col).Value Is DBNull.Value Then
                            exHoja.Cells.Item(Fila + 2, Col + 1) = ""
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

    Private Sub dgvListadoRequerimientos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListadoRequerimientos.CellContentClick
        Try


            Dim req_id As String
            Dim _tipoRespuesta As String = String.Empty
            Dim _textoRespuesta As String = String.Empty
            Dim _estado As String = String.Empty

            If e.ColumnIndex = 12 Then

                Dim obj As New frmProgramarReque

                obj.idReq = dgvListadoRequerimientos.CurrentRow.Cells.Item("req_id").Value
                obj.usr_id = usr_id
                obj.ShowDialog()
                Listar_Requerimientos_Pendientes_Programados()

            End If

            If e.ColumnIndex = 13 Then


                Dim obj1 As New BeRequerimiento
                req_id = dgvListadoRequerimientos.CurrentRow.Cells.Item("req_id").Value
                _estado = dgvListadoRequerimientos.CurrentRow.Cells.Item("est_descripcion").Value

                If _estado <> "PROGRAMADO" Then
                    MessageBox.Show("Para Cerrar el Requerimiento debe estar en estado Programado", "NORDIC", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    If MessageBox.Show("Esta Usted seguro que desea Cerrar el Requerimiento Nro: " + req_id + " ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                        obj1.Cerrar_Requerimiento(req_id, usr_id, _tipoRespuesta, _textoRespuesta)

                        If _tipoRespuesta = "1" Then
                            MessageBox.Show("Se cerro el requerimiento numero : " + req_id + " de forma satisfactoria.", "NORDIC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Listar_Requerimientos_Pendientes_Programados()
                        Else
                            If _tipoRespuesta = "0" Then
                                MessageBox.Show("Error en la actualización: " + _textoRespuesta, "NORDIC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            End If
                        End If

                    End If

                End If

            End If

            If e.ColumnIndex = 14 Then

                Dim obj1 As New BeRequerimiento
                req_id = dgvListadoRequerimientos.CurrentRow.Cells.Item("req_id").Value
                _estado = dgvListadoRequerimientos.CurrentRow.Cells.Item("est_descripcion").Value

                If _estado <> "PENDIENTE" Then
                    MessageBox.Show("No se puede Anular el Requerimiento, debe estar en estado Pendiente", "NORDIC", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    If MessageBox.Show("Esta Usted seguro que desea Anular el Requerimiento Nro: " + req_id + " ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                        obj1.Anular_Requerimiento(req_id, usr_id, _tipoRespuesta, _textoRespuesta)

                        If _tipoRespuesta = "1" Then
                            MessageBox.Show("Se anulo el requerimiento numero : " + req_id + " de forma satisfactoria.", "NORDIC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Listar_Requerimientos_Pendientes_Programados()
                        Else
                            If _tipoRespuesta = "0" Then
                                MessageBox.Show("Error en la actualización: " + _textoRespuesta, "NORDIC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            End If
                        End If

                    End If
                End If

            End If

        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try

            If ckbSincronizar.Checked = True Then
                Listar_Requerimientos_Pendientes_Programados()
            End If


        Catch ex As Exception

        End Try
    End Sub
End Class