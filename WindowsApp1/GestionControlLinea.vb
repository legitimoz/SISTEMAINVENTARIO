Imports Microsoft.Reporting.WinForms
Imports Nordic.Bl.Be

Public Class GestionControlLinea
    Private AlmacenObj As New AlmacenL
    Private DtActual, DtActualDetalle As New DataTable
    Private DtDetalleReporte, DtDetalleXLinea As New DataTable
    Private Estructura As New EstructuraTabla
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



    Private Sub CargaInicial()
        Try
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

    Public Function Obtener(LineA As String) As Decimal
        Dim retorno As Decimal = 0
        Try
            For Each Rowbusca As DataRow In DtActual.Rows
                If LineA.Trim = Rowbusca.Item("LINEA").ToString.Trim Then
                    retorno = Rowbusca.Item("CANTIDADX_LINEA")
                    Exit For
                End If
            Next
            Return retorno
        Catch ex As Exception

        End Try
    End Function

    Private Sub ListarCabecera()
        Try
            Dim DtCargar As New DataTable
            DtCargar = LlamarListarDataInicial()
            If DtCargar.Rows.Count > 0 Then
                Dim Contador As Integer = 0
                For Each RowAdd As DataRow In DtCargar.Rows
                    Dg_Cabecera.Rows.Add()
                    Dg_Cabecera.Rows(Contador).Cells("LINEA").Value = RowAdd.Item("LINEA").ToString.Trim
                    Dg_Cabecera.Rows(Contador).Cells("MES1").Value = RowAdd.Item("MES1")
                    Dg_Cabecera.Rows(Contador).Cells("MES2").Value = RowAdd.Item("MES2")
                    Dg_Cabecera.Rows(Contador).Cells("MES3").Value = RowAdd.Item("MES3")
                    Dg_Cabecera.Rows(Contador).Cells("MES4").Value = RowAdd.Item("MES4")
                    Dg_Cabecera.Rows(Contador).Cells("MES5").Value = RowAdd.Item("MES5")
                    Dg_Cabecera.Rows(Contador).Cells("MES6").Value = RowAdd.Item("MES6")
                    Dg_Cabecera.Rows(Contador).Cells("UNIDADESTOLTA").Value = RowAdd.Item("UNIDADESTOLTA")

                    Dg_Cabecera.Rows(Contador).Cells("TOTALACTUAL").Value = Obtener(RowAdd.Item("LINEA"))

                    Dim Diferencia As Integer = 0, Porcentaje As Decimal = 0

                    Diferencia = Dg_Cabecera.Rows(Contador).Cells("UNIDADESTOLTA").Value - Dg_Cabecera.Rows(Contador).Cells("TOTALACTUAL").Value
                    Porcentaje = (Diferencia * 100) / CType(Dg_Cabecera.Rows(Contador).Cells("UNIDADESTOLTA").Value, Integer)

                    Dg_Cabecera.Rows(Contador).Cells("PORCENTAJE").Value = Math.Ceiling(Porcentaje)
                    Dim rowReporte As DataRow = DtDetalleReporte.NewRow
                    rowReporte.Item("LINEA") = Dg_Cabecera.Rows(Contador).Cells("LINEA").Value
                    rowReporte.Item("PORCENTAJE") = Dg_Cabecera.Rows(Contador).Cells("PORCENTAJE").Value
                    DtDetalleReporte.Rows.Add(rowReporte)
                    Contador = Contador + 1
                Next
                If DtDetalleReporte.Rows.Count > 0 Then
                    MostrarReporte()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GestionControlLinea_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargaInicial()
        'Me.ReportViewer1.RefreshReport()
    End Sub

    Public Sub MostrarReporte()
        Try
            'Me.Size = New Size(Me.ReportViewer1.GetPageSettings.PaperSize.Width, panle_report.Size.Height)




            If IsNothing(DtDetalleReporte) Then
                Me.Close()
                Exit Sub
            End If



            'Me.ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("data_reporte", DtDetalleReporte))



            'Me.ReportViewer1.LocalReport.DisplayName = Text
            'Me.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
            'Me.ReportViewer1.RefreshReport()

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
                    If e.ColumnIndex = 10 Then
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

    Private Sub cmdGenerarExcel_Click(sender As Object, e As EventArgs) Handles cmdGenerarExcel.Click
        Try
            Dim ReporteObj As New ReporteAvance
            ReporteObj.DtDetallePedido = DtDetalleReporte
            ReporteObj.Show()

        Catch ex As Exception

        End Try
    End Sub
End Class