
Imports Nordic.Bl.Be

Public Class frmVisorRepre
    Private Sub frmVisorRepre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cboTipo.SelectedIndex = 0
            Cargar_Representante(0, "", dtpFecha.Value.ToShortDateString, dtpFechaFin.Value.ToShortDateString, "TODOS")

        Catch ex As Exception

        End Try
    End Sub

    Sub PintarFilas()
        Try

            For i As Integer = 0 To dgvVisitasMedicas.Rows.Count - 1

                If dgvVisitasMedicas.Rows(i).Cells.Item(6).Value = "AM" Then

                    dgvVisitasMedicas.Rows(i).DefaultCellStyle.BackColor = Color.LightGoldenrodYellow

                End If

            Next


            For i As Integer = 0 To dgvBoticasFarmacias.Rows.Count - 1

                If dgvBoticasFarmacias.Rows(i).Cells.Item(3).Value = "AM" Then

                    dgvBoticasFarmacias.Rows(i).DefaultCellStyle.BackColor = Color.LightGoldenrodYellow

                End If

            Next

        Catch ex As Exception

        End Try
    End Sub

    Sub Cargar_Representante(ByVal flag As String, ByVal nombre As String, ByVal fecIni As String, ByVal fecFin As String, ByVal prefijo As String)
        Try

            Dim obj As New BeRepresentante
            Dim dt As DataTable

            dt = obj.Listar_Representante(flag, nombre, fecIni, fecFin, prefijo)

            If dt.Rows.Count > 0 Then

                dgvRepresentantes.Rows.Clear()

                For i As Integer = 0 To dt.Rows.Count - 1

                    dgvRepresentantes.Rows.Add(dt.Rows(i).Item(0), dt.Rows(i).Item(1), dt.Rows(i).Item(2), dt.Rows(i).Item(3), dt.Rows(i).Item(4), dt.Rows(i).Item(5), dt.Rows(i).Item(1))

                Next

                tslCantRepre.Text = CStr(dgvRepresentantes.Rows.Count)

            End If




        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtBusRepre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBusRepre.KeyPress
        Try

            Dim tipo As String = String.Empty

            If cboTipo.SelectedIndex = 0 Then
                tipo = "TODOS"
            End If

            If cboTipo.SelectedIndex = 1 Then
                tipo = "RMN"
            End If

            If cboTipo.SelectedIndex = 2 Then
                tipo = "RMP"
            End If

            If e.KeyChar = Convert.ToChar(Keys.Enter) Then

                Cargar_Representante(1, txtBusRepre.Text.Trim, dtpFecha.Value.ToShortDateString, dtpFechaFin.Value.ToShortDateString, tipo)

            End If


            If e.KeyChar = Convert.ToChar(Keys.Escape) Then

                txtBusRepre.Text = ""
                Cargar_Representante(0, "", dtpFecha.Value.ToShortDateString, dtpFechaFin.Value.ToShortDateString, tipo)

            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvRepresentantes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRepresentantes.CellDoubleClick
        Try

            Dim obj As New BeRepresentante
            Dim dt As DataTable
            Dim dt1 As DataTable
            Dim dt2 As DataTable


            Dim codrepre As String
            Dim Representante As String
            Dim fecha As String
            Dim fecfin As String

            codrepre = dgvRepresentantes.CurrentRow.Cells.Item(1).Value
            Representante = dgvRepresentantes.CurrentRow.Cells.Item(0).Value
            fecha = dtpFecha.Value.ToShortDateString
            fecfin = dtpFechaFin.Value.ToShortDateString

            txtRepresentante.Text = Representante + " - " + codrepre

            lblRepre.Text = Representante
            dt = obj.Listar_VisitasMedicas(fecha, fecfin, codrepre)
            dt1 = obj.Listar_VisitasFarmacias(fecha, fecfin, codrepre)
            dt2 = obj.ListaPedidos(fecha, fecfin, codrepre)

            Mostrar_Lineas_xRepresentante(codrepre)
            dgvVisitasMedicas.DataSource = dt

            dgvVisitasMedicas.Columns(0).Visible = False
            dgvVisitasMedicas.Columns(1).Width = 200
            dgvVisitasMedicas.Columns(2).Width = 30
            dgvVisitasMedicas.Columns(3).Width = 200
            dgvVisitasMedicas.Columns(4).Width = 80
            dgvVisitasMedicas.Columns(5).Width = 80
            dgvVisitasMedicas.Columns(6).Width = 30
            dgvVisitasMedicas.Columns(7).Width = 60
            dgvVisitasMedicas.Columns(10).Width = 400
            'dgvVisitasMedicas.Columns(10).Visible = False


            dgvBoticasFarmacias.DataSource = dt1

            dgvBoticasFarmacias.Columns(0).Width = 200
            dgvBoticasFarmacias.Columns(1).Width = 80
            dgvBoticasFarmacias.Columns(2).Width = 80
            dgvBoticasFarmacias.Columns(3).Width = 30
            dgvBoticasFarmacias.Columns(6).Width = 400

            dgvPedidos.DataSource = dt2

            dgvPedidos.Columns(0).Width = 80
            dgvPedidos.Columns(1).Width = 250
            dgvPedidos.Columns(2).Width = 70
            dgvPedidos.Columns(3).Width = 80
            dgvPedidos.Columns(4).Width = 120
            dgvPedidos.Columns(5).Width = 80

            dgvPedidos.Columns(6).Width = 100
            dgvPedidos.Columns(7).Width = 100
            dgvPedidos.Columns(8).Visible = False
            dgvPedidos.Columns(9).Visible = False




            PintarFilas()


        Catch ex As Exception

        End Try
    End Sub

    Sub Mostrar_Lineas_xRepresentante(ByVal codrepre As String)
        Try
            Dim dt3 As DataTable
            Dim obj As New BeRepresentante

            ckbBhealth.Checked = False
            ckbHuman.Checked = False
            ckbLifeScience.Checked = False
            ckbPneumo.Checked = False
            chkComercial.Checked = False

            dt3 = obj.Obtener_Lineas_xRepre(codrepre)

            For i As Integer = 0 To dt3.Rows.Count - 1

                If dt3.Rows(i).Item(0) = "01" Then
                    ckbBhealth.Checked = True
                End If

                If dt3.Rows(i).Item(0) = "02" Then
                    ckbHuman.Checked = True
                End If

                If dt3.Rows(i).Item(0) = "03" Then
                    ckbLifeScience.Checked = True
                End If

                If dt3.Rows(i).Item(0) = "04" Then
                    ckbPneumo.Checked = True
                End If

                If dt3.Rows(i).Item(0) = "05" Then
                    chkComercial.Checked = True
                End If


            Next


        Catch ex As Exception

        End Try

    End Sub


    Public Sub CargarCuentasXCobrar(ByVal ruc As String)
        Try

            Dim dt As New DataTable
            Dim objPedidos As New BePedidos


            'dt = objPedidos.ObtenerCuentasxCobrar(ruc)

            'dgvCuentasxCobrar.DataSource = dt

            'dgvCuentasxCobrar.Columns(9).Width = 120
            'dgvCuentasxCobrar.Columns(10).Width = 120
            'dgvCuentasxCobrar.Columns(11).Width = 120
            'dgvCuentasxCobrar.Columns(12).Width = 120

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Try
            Dim tipo As String = String.Empty

            If cboTipo.SelectedIndex = 0 Then
                tipo = "TODOS"
            End If

            If cboTipo.SelectedIndex = 1 Then
                tipo = "RMN"
            End If

            If cboTipo.SelectedIndex = 2 Then
                tipo = "RMP"
            End If


            Cargar_Representante(0, "", dtpFecha.Value.ToShortDateString, dtpFechaFin.Value.ToShortDateString, tipo)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvVisitasMedicas_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvVisitasMedicas.CellFormatting
        Try
            Dim dt As New DataTable
            'Dim idDet As Integer = 0
            Dim columna As Integer
            Dim texto As String = String.Empty

            If e.ColumnIndex = Me.dgvVisitasMedicas.Columns(7).Index _
        AndAlso (e.Value IsNot Nothing) Then

                With Me.dgvVisitasMedicas.Rows(e.RowIndex).Cells(e.ColumnIndex)
                    columna = (e.ColumnIndex - 1)
                    texto = dgvVisitasMedicas.Rows(e.RowIndex).Cells.Item(10).Value


                    'texto = "Fecha Registro: " + dt.Rows(0).Item(0).ToString + vbLf + "Cantidad: " + dt.Rows(0).Item(1).ToString
                    .ToolTipText = texto

                End With

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvPedidos_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvPedidos.CellMouseDoubleClick
        Try
            Dim obj As New frmDetallePedido

            obj.codpro = dgvPedidos.CurrentRow.Cells.Item(9).Value
            obj.numPed = dgvPedidos.CurrentRow.Cells.Item(0).Value

            obj.ShowDialog()


        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvVisitasMedicas_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvVisitasMedicas.CellMouseDoubleClick
        Try
            Dim comentario As String = String.Empty
            Dim medico As String = String.Empty
            Dim centroMedico As String = String.Empty
            Dim observacion As String = String.Empty

            Dim obj As New frmTexto

            medico = "DR(A).  " + dgvVisitasMedicas.CurrentRow.Cells.Item(1).Value.ToString + " " + "(ESP. " + dgvVisitasMedicas.CurrentRow.Cells.Item(2).Value.ToString + ")"
            centroMedico = "CENTRO MEDICO: " + dgvVisitasMedicas.CurrentRow.Cells.Item(3).Value.ToString
            observacion = dgvVisitasMedicas.CurrentRow.Cells.Item(10).Value.ToString
            comentario = medico + vbCrLf + centroMedico + vbCrLf + vbCrLf + observacion

            If observacion.Length = 0 Then
                MessageBox.Show("La Visita Medica no tiene comentario.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            Else
                obj.observacion = observacion
                obj.comentario = comentario
                obj.ShowDialog()
            End If



        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvBoticasFarmacias_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvBoticasFarmacias.CellMouseDoubleClick

        Try
            Dim comentario As String = String.Empty
            Dim cliente As String = String.Empty
            Dim observacion As String = String.Empty

            Dim obj As New frmTexto


            cliente = "CLIENTE: " + dgvBoticasFarmacias.CurrentRow.Cells.Item(0).Value.ToString
            observacion = dgvBoticasFarmacias.CurrentRow.Cells.Item(6).Value.ToString
            comentario = cliente + vbCrLf + vbCrLf + observacion

            If observacion.Length = 0 Then
                MessageBox.Show("La Visita a Boticas y Farmacias no tiene comentario.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            Else
                obj.observacion = observacion
                obj.comentario = comentario
                obj.ShowDialog()
            End If



        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        Try
            Me.Cursor = Cursors.WaitCursor

            GridAExcel(dgvRepresentantes)


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

End Class