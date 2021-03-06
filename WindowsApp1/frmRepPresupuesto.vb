Imports Nordic.Bl.Be

Public Class frmRepPresupuesto
    Private Sub frmRepPresupuesto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cboEmpresa.SelectedIndex = 0
            ListarAnios()


        Catch ex As Exception

        End Try
    End Sub



    Public Sub ListarAnios()
        Dim anioIni As Integer = 2018
        Dim anioFin As Integer
        Dim val As Integer = 0
        Dim dif As Integer = 0
        Dim ds As String
        Try
            Dim objLogin As New BeLogin
            'ds = 'objSeg.Obtener_Fecha_Actual()
            ds = objLogin.ObtenerAnioActual()
            'ds = ds.Substring(6)
            anioFin = CInt(ds)
            dif = anioFin - anioIni
            Dim vect(dif) As Integer

            For i As Integer = 0 To dif
                val = anioIni + i
                cbxAnio.Items.Add(val)
                ' cbxAniox.Items.Add(val)
            Next
            cbxAnio.SelectedItem = anioFin
            'cbxAniox.SelectedItem = anioFin
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            Dim objPedido As New BePedidos
            Dim dt As New DataTable
            Dim anio As String

            anio = cbxAnio.Text

            Me.Cursor = Cursors.WaitCursor

            If dgvListarMovimientos.Rows.Count > 0 Then
                dgvListarMovimientos.DataSource = Nothing
            End If

            If cboEmpresa.SelectedIndex = 0 Then
                dt = objPedido.Obtener_Movimientos(anio)
            Else
                If cboEmpresa.SelectedIndex = 1 Then
                    dt = objPedido.Obtener_Movimientos_Ssenda(anio)
                Else
                    If cboEmpresa.SelectedIndex = 2 Then
                        dt = objPedido.Obtener_Movimientos_Maquinarias(anio)
                    End If

                End If

            End If

            dgvListarMovimientos.DataSource = dt

            Me.Cursor = Cursors.Default

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        Try

            Me.Cursor = Cursors.WaitCursor

            If dgvListarMovimientos.Rows.Count > 0 Then
                GridAExcel(dgvListarMovimientos)
            Else
                MessageBox.Show("No hay registros para exportar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End If

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
                    If Col = 3 Or Col = 0 Or Col = 2 Or Col = 13 Or Col = 14 Or Col = 15 Or Col = 16 Or Col = 17 Then
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