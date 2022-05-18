Imports Microsoft.Reporting.WinForms
Imports Nordic.Bl.Be

Public Class GestionControlLinea
    Private AlmacenObj As New AlmacenL
    Private DtActual, DtActualDetalle, dtDetalle As New DataTable
    Private DtDetalleReporte, DtDetalleXLinea As New DataTable
    Private Estructura As New EstructuraTabla
    Private RowObtener As DataGridViewRow


    Private Sub cmdCerrar_Click(sender As Object, e As EventArgs) Handles cmdCerrar.Click
        Me.Close()
    End Sub

    Public Function LlamarListarDataInicial() As DataTable

        Dim dtretono As DataTable
        Try
            dtretono = AlmacenObj.SP_LISTAR_REPORTE_AVANCE_LINEA().Copy
        Catch ex As Exception
            Throw ex
        End Try
        Return dtretono
    End Function

    Public Function LlamarListarDataActual() As DataTable

        Dim dtretono As DataTable
        Try
            dtretono = AlmacenObj.SP_CSE_OBTENER_DATA_ACTUAL().Copy
        Catch ex As Exception
            Throw ex
        End Try
        Return dtretono
    End Function

    Public Function LlamarListarDataActualDetalle() As DataTable

        Dim dtretono As DataTable
        Try
            dtretono = AlmacenObj.SP_CSE_OBTENER_DATA_ACTUAL_DETALLE().Copy
        Catch ex As Exception
            Throw ex
        End Try
        Return dtretono
    End Function

    Public Sub FormatoTablaDetalle()
        dtDetalle.Clear()

        dtDetalle = Estructura.DetalleReporteAvance

        Dg_Detalle.DataSource = dtDetalle

        Dg_Detalle.Columns("Linea").HeaderText = "                      "
        Dg_Detalle.Columns("Linea").Width = 80
        Dg_Detalle.Columns("Linea").ReadOnly = True
        Dg_Detalle.Columns("Linea").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_Detalle.Columns("MES1").HeaderText = "Und x vencer 1 mes"
        Dg_Detalle.Columns("MES1").Width = 80
        Dg_Detalle.Columns("MES1").ReadOnly = True
        Dg_Detalle.Columns("MES1").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_Detalle.Columns("MES2").HeaderText = "Und x vencer 2 meses"
        Dg_Detalle.Columns("MES2").Width = 80
        Dg_Detalle.Columns("MES2").ReadOnly = True
        Dg_Detalle.Columns("MES2").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_Detalle.Columns("MES3").HeaderText = "Und x vencer 3 meses"
        Dg_Detalle.Columns("MES3").Width = 80
        Dg_Detalle.Columns("MES3").ReadOnly = True
        Dg_Detalle.Columns("MES3").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_Detalle.Columns("MES4").HeaderText = "Und x vencer 4 meses"
        Dg_Detalle.Columns("MES4").Width = 80
        Dg_Detalle.Columns("MES4").ReadOnly = True
        Dg_Detalle.Columns("MES4").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_Detalle.Columns("MES5").HeaderText = "Und x vencer 5 meses"
        Dg_Detalle.Columns("MES5").Width = 80
        Dg_Detalle.Columns("MES5").ReadOnly = True
        Dg_Detalle.Columns("MES5").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_Detalle.Columns("MES6").HeaderText = "Und x vencer 6 meses"
        Dg_Detalle.Columns("MES6").Width = 80
        Dg_Detalle.Columns("MES6").ReadOnly = True
        Dg_Detalle.Columns("MES6").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_Detalle.Columns("Total").HeaderText = "Tot_Und Inicial"
        Dg_Detalle.Columns("Total").Width = 80
        Dg_Detalle.Columns("Total").ReadOnly = True
        Dg_Detalle.Columns("Total").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter



    End Sub

    Private Sub CargaInicial()
        Try
            FormatoTablaDetalle()
            DtDetalleReporte = Estructura.GraficoAvanceLinea.Clone
            DtDetalleXLinea = Estructura.DetalleProductosXLinea.Clone
            ListarDataActualDetalle()
            ListarDataActual()
            ListarCabecera()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ListarDataActual()
        Try

            DtActual = LlamarListarDataActual()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ListarDataActualDetalle()
        Try

            DtActualDetalle = LlamarListarDataActualDetalle()

        Catch ex As Exception

        End Try
    End Sub

    Public Function Obtener(LineA As String) As Integer
        Dim retorno As Integer = 0
        Try

            If LineA <> "UNIDAD TOTAL INICIAL" Then
                For Each Rowbusca As DataRow In DtActual.Rows
                    If LineA.Trim = Rowbusca.Item("LINEA").ToString.Trim Then
                        retorno = Rowbusca.Item("CANTIDADX_LINEA")
                        Exit For
                    End If
                Next
            Else
                For Each Rowbusca As DataRow In DtActual.Rows
                    retorno = retorno + Rowbusca.Item("CANTIDADX_LINEA")
                Next
            End If

        Catch ex As Exception

        End Try
        Return retorno
    End Function

    Private Sub ListarCabecera()
        Try
            Dim DtCargar As New DataTable
            DtCargar = LlamarListarDataInicial()
            If DtCargar.Rows.Count > 0 Then
                Dim RowIndex As Integer = 0
                RowIndex = DtCargar.Rows.Count - 1
                Dim Total As Integer = CType(DtCargar.Rows(RowIndex).Item("UNIDADESTOLTA").ToString, Integer)


                Dim Contador As Integer = 0
                For Each RowAdd As DataRow In DtCargar.Rows
                    Dg_Cabecera.Rows.Add()
                    If RowIndex = Contador Then
                        Dg_Cabecera.Rows(Contador).DefaultCellStyle.BackColor = Color.DarkGray
                        Dg_Cabecera.Rows(Contador).DefaultCellStyle.ForeColor = Color.White
                        Dg_Cabecera.Rows(Contador).DefaultCellStyle.Font = New Font("Century Gothic", 9, FontStyle.Bold)
                    End If
                    Dg_Cabecera.Rows(Contador).Cells("LINEA").Value = RowAdd.Item("LINEA").ToString.Trim
                    Dg_Cabecera.Rows(Contador).Cells("MES1").Value = CType(RowAdd.Item("MES1"), Integer)
                    Dg_Cabecera.Rows(Contador).Cells("MES2").Value = CType(RowAdd.Item("MES2"), Integer)
                    Dg_Cabecera.Rows(Contador).Cells("MES3").Value = CType(RowAdd.Item("MES3"), Integer)
                    Dg_Cabecera.Rows(Contador).Cells("MES4").Value = CType(RowAdd.Item("MES4"), Integer)
                    Dg_Cabecera.Rows(Contador).Cells("MES5").Value = CType(RowAdd.Item("MES5"), Integer)
                    Dg_Cabecera.Rows(Contador).Cells("MES6").Value = CType(RowAdd.Item("MES6"), Integer)
                    Dg_Cabecera.Rows(Contador).Cells("UNIDADESTOLTA").Value = CType(RowAdd.Item("UNIDADESTOLTA"), Integer)
                    Dg_Cabecera.Rows(Contador).Cells("TOTALACTUAL").Value = Obtener(RowAdd.Item("LINEA"))
                    Dg_Cabecera.Rows(Contador).Cells("PORCENTAJETOTAL").Value = Math.Ceiling(CType(RowAdd.Item("UNIDADESTOLTA"), Integer) / Total * 100).ToString + "%"
                    Dim Diferencia As Integer = 0, Porcentaje As Decimal = 0

                    Diferencia = Dg_Cabecera.Rows(Contador).Cells("UNIDADESTOLTA").Value - Dg_Cabecera.Rows(Contador).Cells("TOTALACTUAL").Value
                    Porcentaje = (Diferencia * 100) / CType(Dg_Cabecera.Rows(Contador).Cells("UNIDADESTOLTA").Value, Integer)

                    Dg_Cabecera.Rows(Contador).Cells("PORCENTAJE").Value = Math.Ceiling(Porcentaje).ToString + "%"
                    Dim rowReporte As DataRow = DtDetalleReporte.NewRow
                    rowReporte.Item("LINEA") = Dg_Cabecera.Rows(Contador).Cells("LINEA").Value
                    rowReporte.Item("PORCENTAJE") = Dg_Cabecera.Rows(Contador).Cells("PORCENTAJE").Value.ToString.Replace("%", "")
                    DtDetalleReporte.Rows.Add(rowReporte)
                    Contador = Contador + 1
                Next
                Dg_Cabecera.Rows.Add()
                Dg_Cabecera.Rows(Contador).Cells("LINEA").Value = "UNIDAD TOTAL ACTUAL"
                Dg_Cabecera.Rows(Contador).Cells("MES1").Value = ObtenerTotalXMes(1)
                Dg_Cabecera.Rows(Contador).Cells("MES2").Value = ObtenerTotalXMes(2)
                Dg_Cabecera.Rows(Contador).Cells("MES3").Value = ObtenerTotalXMes(3)
                Dg_Cabecera.Rows(Contador).Cells("MES4").Value = ObtenerTotalXMes(4)
                Dg_Cabecera.Rows(Contador).Cells("MES5").Value = ObtenerTotalXMes(5)
                Dg_Cabecera.Rows(Contador).Cells("MES6").Value = ObtenerTotalXMes(6)
                Dg_Cabecera.Rows(Contador).Cells("UNIDADESTOLTA").Value = CType(Dg_Cabecera.Rows(Contador).Cells("MES1").Value, Integer) + CType(Dg_Cabecera.Rows(Contador).Cells("MES2").Value, Integer) + CType(Dg_Cabecera.Rows(Contador).Cells("MES3").Value, Integer) + CType(Dg_Cabecera.Rows(Contador).Cells("MES4").Value, Integer) + CType(Dg_Cabecera.Rows(Contador).Cells("MES5").Value, Integer) + CType(Dg_Cabecera.Rows(Contador).Cells("MES6").Value, Integer)
                Dg_Cabecera.Rows(Contador).Cells("TOTALACTUAL").Value = ""
                Dg_Cabecera.Rows(Contador).Cells("TOTALACTUAL").Style.BackColor = Color.DarkGray
                Dg_Cabecera.Rows(Contador).Cells("PORCENTAJETOTAL").Value = ""
                Dg_Cabecera.Rows(Contador).Cells("PORCENTAJETOTAL").Style.BackColor = Color.DarkGray
                Dg_Cabecera.Rows(Contador).Cells("PORCENTAJE").Value = ""
                Dg_Cabecera.Rows(Contador).Cells("PORCENTAJE").Style.BackColor = Color.DarkGray
                Contador = Contador + 1

                Dg_Cabecera.Rows.Add()

                Dg_Cabecera.Rows(Contador).Cells("LINEA").Value = "% AVANCE TOT_ X .MES_ VENC"
                Dg_Cabecera.Rows(Contador).Cells("MES1").Value = Math.Ceiling((CType(Dg_Cabecera.Rows(Contador - 2).Cells("MES1").Value, Integer) - CType(Dg_Cabecera.Rows(Contador - 1).Cells("MES1").Value, Integer)) / CType(Dg_Cabecera.Rows(Contador - 2).Cells("MES1").Value, Integer) * 100).ToString + "%"
                Dg_Cabecera.Rows(Contador).Cells("MES2").Value = Math.Ceiling((CType(Dg_Cabecera.Rows(Contador - 2).Cells("MES2").Value, Integer) - CType(Dg_Cabecera.Rows(Contador - 1).Cells("MES1").Value, Integer)) / CType(Dg_Cabecera.Rows(Contador - 2).Cells("MES2").Value, Integer) * 100).ToString + "%"
                Dg_Cabecera.Rows(Contador).Cells("MES3").Value = Math.Ceiling((CType(Dg_Cabecera.Rows(Contador - 2).Cells("MES3").Value, Integer) - CType(Dg_Cabecera.Rows(Contador - 1).Cells("MES1").Value, Integer)) / CType(Dg_Cabecera.Rows(Contador - 2).Cells("MES3").Value, Integer) * 100).ToString + "%"
                Dg_Cabecera.Rows(Contador).Cells("MES4").Value = Math.Ceiling((CType(Dg_Cabecera.Rows(Contador - 2).Cells("MES4").Value, Integer) - CType(Dg_Cabecera.Rows(Contador - 1).Cells("MES1").Value, Integer)) / CType(Dg_Cabecera.Rows(Contador - 2).Cells("MES4").Value, Integer) * 100).ToString + "%"
                Dg_Cabecera.Rows(Contador).Cells("MES5").Value = Math.Ceiling((CType(Dg_Cabecera.Rows(Contador - 2).Cells("MES5").Value, Integer) - CType(Dg_Cabecera.Rows(Contador - 1).Cells("MES1").Value, Integer)) / CType(Dg_Cabecera.Rows(Contador - 2).Cells("MES5").Value, Integer) * 100).ToString + "%"
                Dg_Cabecera.Rows(Contador).Cells("MES6").Value = Math.Ceiling((CType(Dg_Cabecera.Rows(Contador - 2).Cells("MES6").Value, Integer) - CType(Dg_Cabecera.Rows(Contador - 1).Cells("MES1").Value, Integer)) / CType(Dg_Cabecera.Rows(Contador - 2).Cells("MES6").Value, Integer) * 100).ToString + "%"
                Dg_Cabecera.Rows(Contador).Cells("UNIDADESTOLTA").Value = Math.Ceiling((CType(Dg_Cabecera.Rows(Contador - 2).Cells("UNIDADESTOLTA").Value, Integer) - CType(Dg_Cabecera.Rows(Contador - 1).Cells("UNIDADESTOLTA").Value, Integer)) / CType(Dg_Cabecera.Rows(Contador - 2).Cells("UNIDADESTOLTA").Value, Integer) * 100).ToString + "%"
                Dg_Cabecera.Rows(Contador).Cells("TOTALACTUAL").Value = ""
                Dg_Cabecera.Rows(Contador).Cells("TOTALACTUAL").Style.BackColor = Color.DarkGray
                Dg_Cabecera.Rows(Contador).Cells("PORCENTAJETOTAL").Value = ""
                Dg_Cabecera.Rows(Contador).Cells("PORCENTAJETOTAL").Style.BackColor = Color.DarkGray
                Dg_Cabecera.Rows(Contador).Cells("PORCENTAJE").Value = ""
                Dg_Cabecera.Rows(Contador).Cells("PORCENTAJE").Style.BackColor = Color.DarkGray
                If DtDetalleReporte.Rows.Count > 0 Then
                    MostrarReporte()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GestionControlLinea_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargaInicial()
    End Sub

    Public Sub MostrarReporte()
        Try

            If IsNothing(DtDetalleReporte) Then
                Me.Close()
                Exit Sub
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Dg_Cabecera_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dg_Cabecera.CellContentClick
        If Dg_Cabecera.Rows.Count > 0 Then
            Try
                If e.RowIndex >= 0 Then
                    If e.ColumnIndex = 11 Then
                        DtDetalleXLinea.Rows.Clear()
                        Dim Linea As String = ""
                        Linea = Dg_Cabecera.Rows(e.RowIndex).Cells(0).Value
                        For Each DatarowBus As DataRow In DtActualDetalle.Rows
                            If Linea.Trim = DatarowBus.Item("LINEA").ToString.Trim Then
                                Dim RowDetalle As DataRow = DtDetalleXLinea.NewRow()
                                RowDetalle.Item("CODIGO") = DatarowBus.Item("CODIGO").ToString.Trim
                                RowDetalle.Item("ARTICULO") = DatarowBus.Item("ARTICULO").ToString.Trim
                                RowDetalle.Item("LOTE") = DatarowBus.Item("LOTE").ToString.Trim
                                RowDetalle.Item("CANTIDAD") = DatarowBus.Item("CANTIDAD").ToString.Trim
                                RowDetalle.Item("CANT_MESES") = DatarowBus.Item("CANT_MESES").ToString.Trim
                                DtDetalleXLinea.Rows.Add(RowDetalle)
                            End If
                        Next
                        If DtDetalleXLinea.Rows.Count > 0 Then
                            Dim DetalleForm As New DetalleProductosXLinea
                            DetalleForm.dtDetalle = DtDetalleXLinea
                            DetalleForm.Linea = Linea
                            DetalleForm.Show()
                        End If
                    End If
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub Dg_Cabecera_SelectionChanged(sender As Object, e As EventArgs) Handles Dg_Cabecera.SelectionChanged
        ObtenerCab()
        ListarDetalle()
    End Sub

    Private Sub ObtenerCab()
        Try
            If Dg_Cabecera.Rows.Count > 0 Then
                If Dg_Cabecera.CurrentRow.Index > -1 And Dg_Cabecera.CurrentRow.Index <= 7 Then
                    RowObtener = Dg_Cabecera.CurrentRow
                Else
                    RowObtener = Nothing
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Function ObtenerTotalXLineaMes(Linea As String, Mes As Integer) As Integer
        Dim rp As Integer = 0
        Try
            If DtActualDetalle.Rows.Count > 0 Then
                For Each RowBuscar As DataRow In DtActualDetalle.Rows
                    If RowBuscar.Item("LINEA").ToString.Trim = Linea.Trim And CType(RowBuscar.Item("CANT_MESES").ToString.Trim, Integer) = Mes Then
                        rp = rp + CType(RowBuscar.Item("CANTIDAD").ToString.Trim, Integer)
                    End If
                Next
            End If
        Catch ex As Exception

        End Try
        Return rp
    End Function

    Private Function ObtenerTotalXMes(Mes As Integer) As Integer
        Dim rp As Integer = 0
        Try
            If DtActualDetalle.Rows.Count > 0 Then
                For Each RowBuscar As DataRow In DtActualDetalle.Rows
                    If CType(RowBuscar.Item("CANT_MESES").ToString.Trim, Integer) = Mes Then
                        rp = rp + CType(RowBuscar.Item("CANTIDAD").ToString.Trim, Integer)
                    End If
                Next
            End If
        Catch ex As Exception

        End Try
        Return rp
    End Function

    Private Sub ListarDetalle()
        If dtDetalle.Rows.Count > 0 Then
            dtDetalle.Rows.Clear()
        End If
        If RowObtener IsNot Nothing Then
            Dim RowAdd As DataRow = dtDetalle.NewRow
            If RowObtener.Cells("LINEA").Value IsNot Nothing Then
                Dg_Detalle.Columns("Linea").HeaderText = RowObtener.Cells("LINEA").Value.ToString.Trim
                RowAdd.Item("Linea") = "UND_INICIAL"
                RowAdd.Item("MES1") = RowObtener.Cells("MES1").Value.ToString.Trim
                RowAdd.Item("MES2") = RowObtener.Cells("MES2").Value.ToString.Trim
                RowAdd.Item("MES3") = RowObtener.Cells("MES3").Value.ToString.Trim
                RowAdd.Item("MES4") = RowObtener.Cells("MES4").Value.ToString.Trim
                RowAdd.Item("MES5") = RowObtener.Cells("MES5").Value.ToString.Trim
                RowAdd.Item("MES6") = RowObtener.Cells("MES6").Value.ToString.Trim
                RowAdd.Item("Total") = RowObtener.Cells("UNIDADESTOLTA").Value.ToString.Trim
                dtDetalle.Rows.Add(RowAdd)

                Dim RowAdd2 As DataRow = dtDetalle.NewRow
                RowAdd2.Item("Linea") = "UND_ACTUAL"
                RowAdd2.Item("MES1") = ObtenerTotalXLineaMes(RowObtener.Cells("LINEA").Value.ToString.Trim, 1)
                RowAdd2.Item("MES2") = ObtenerTotalXLineaMes(RowObtener.Cells("LINEA").Value.ToString.Trim, 2)
                RowAdd2.Item("MES3") = ObtenerTotalXLineaMes(RowObtener.Cells("LINEA").Value.ToString.Trim, 3)
                RowAdd2.Item("MES4") = ObtenerTotalXLineaMes(RowObtener.Cells("LINEA").Value.ToString.Trim, 4)
                RowAdd2.Item("MES5") = ObtenerTotalXLineaMes(RowObtener.Cells("LINEA").Value.ToString.Trim, 5)
                RowAdd2.Item("MES6") = ObtenerTotalXLineaMes(RowObtener.Cells("LINEA").Value.ToString.Trim, 6)
                RowAdd2.Item("Total") = CType(RowAdd2.Item("MES1").ToString, Integer) + CType(RowAdd2.Item("MES2").ToString, Integer) + CType(RowAdd2.Item("MES3").ToString, Integer) + CType(RowAdd2.Item("MES4").ToString, Integer) + CType(RowAdd2.Item("MES5").ToString, Integer) + CType(RowAdd2.Item("MES6").ToString, Integer)
                dtDetalle.Rows.Add(RowAdd2)

                Dim RowAdd3 As DataRow = dtDetalle.NewRow
                RowAdd3.Item("Linea") = "% AVANCE X MES VENC_"
                RowAdd3.Item("MES1") = Math.Ceiling((CType(RowAdd.Item("MES1"), Integer) - CType(RowAdd2.Item("MES1"), Integer)) / CType(RowAdd.Item("MES1"), Integer) * 100).ToString + "%"
                RowAdd3.Item("MES2") = Math.Ceiling((CType(RowAdd.Item("MES2"), Integer) - CType(RowAdd2.Item("MES2"), Integer)) / CType(RowAdd.Item("MES2"), Integer) * 100).ToString + "%"
                RowAdd3.Item("MES3") = Math.Ceiling((CType(RowAdd.Item("MES3"), Integer) - CType(RowAdd2.Item("MES3"), Integer)) / CType(RowAdd.Item("MES3"), Integer) * 100).ToString + "%"
                RowAdd3.Item("MES4") = Math.Ceiling((CType(RowAdd.Item("MES4"), Integer) - CType(RowAdd2.Item("MES4"), Integer)) / CType(RowAdd.Item("MES4"), Integer) * 100).ToString + "%"
                RowAdd3.Item("MES5") = Math.Ceiling((CType(RowAdd.Item("MES5"), Integer) - CType(RowAdd2.Item("MES5"), Integer)) / CType(RowAdd.Item("MES5"), Integer) * 100).ToString + "%"
                RowAdd3.Item("MES6") = Math.Ceiling((CType(RowAdd.Item("MES6"), Integer) - CType(RowAdd2.Item("MES6"), Integer)) / CType(RowAdd.Item("MES6"), Integer) * 100).ToString + "%"
                RowAdd3.Item("Total") = Math.Ceiling((CType(RowAdd.Item("Total"), Integer) - CType(RowAdd2.Item("Total"), Integer)) / CType(RowAdd.Item("Total"), Integer) * 100).ToString + "%"
                dtDetalle.Rows.Add(RowAdd3)
                'Dg_Cabecera.Rows(Contador).Cells("PORCENTAJETOTAL").Value = Math.Ceiling(CType(RowAdd.Item("UNIDADESTOLTA"), Integer) / Total * 100).ToString + "%"

                Dg_Detalle.DataSource = dtDetalle
            End If
        End If
    End Sub

    Private Sub cmdGenerarExcel_Click(sender As Object, e As EventArgs) Handles cmdGenerarExcel.Click
        Try
            Dim ReporteObj As New ReporteAvance
            ReporteObj.DtDetallePedido = DtDetalleReporte
            ReporteObj.Show()

        Catch ex As Exception

        End Try
    End Sub
End Class