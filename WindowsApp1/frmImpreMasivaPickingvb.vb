'Imports Microsoft.Office.Interop
Imports Nordic.Bl.Be



Public Class frmImpreMasivaPickingvb

    Public usr_id As String

    Dim rutaArchivo As String = Application.StartupPath + "\Config.ini"
    Private mINI As New InitArray

    Private Sub frmImpreMasivaPickingvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            Cargar_Transportistas()

            cboTransportistas.SelectedValue = "TODOS"
        Catch ex As Exception

        End Try
    End Sub


    Sub Cargar_Transportistas()
        Try

            Dim objGuia As New BeGuias
            Dim dt As New DataTable

            dt = objGuia.Obtener_Transportistas()

            cboTransportistas.DataSource = dt
            cboTransportistas.ValueMember = "C5_CNOMTRA"
            cboTransportistas.DisplayMember = "C5_CNOMTRA"


            'Formato()
            'Me.lbldeuda.Text = CStr(dt.Rows.Count)
            'dt.Rows(0).Item(0).ToString.Trim
            'CStr(datagridview1.Row.Count)
            'CboVendedor.SelectedIndex = 0

        Catch ex As Exception
            MessageBox.Show(ex.Message, "NORDIC", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try

            CargarGuias_ImpresionMasiva(dtpFecIni.Value, dtpFecFin.Value, cboTransportistas.SelectedValue.ToString())
            PintarRegistrosImpresos()

        Catch ex As Exception

        End Try
    End Sub


    Public Sub PintarRegistrosImpresos()
        Try
            For i As Integer = 0 To dgvGuiasImpresion.Rows.Count - 1

                If dgvGuiasImpresion.Rows(i).Cells.Item("IMPRESO").Value = "SI" Then
                    dgvGuiasImpresion.Rows(i).DefaultCellStyle.BackColor = Color.Aqua

                End If

            Next

        Catch ex As Exception

        End Try

    End Sub

    Public Sub CargarGuias_ImpresionMasiva(ByVal fec1 As Date, ByVal fec2 As Date, ByVal transporte As String)
        Try
            Dim objGuia As New BeGuias
            Dim dt As New DataTable


            'If cboTransportistas.SelectedIndex = 0 Then
            '    MessageBox.Show("Debe seleccionar el Transportista", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'Else
            Me.Cursor = Cursors.WaitCursor

            dgvGuiasImpresion.Rows.Clear()


            dt = objGuia.Obtener_Guias_ImpresionMasiva(fec1, fec2, transporte)

                If dt.Rows.Count = 0 Then
                    MessageBox.Show("No se encontraron registros", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    For i As Integer = 0 To dt.Rows.Count - 1
                        dgvGuiasImpresion.Rows.Add(False, dt.Rows(i).Item("FECHA_GUIA").ToString, dt.Rows(i).Item("GUIA").ToString, dt.Rows(i).Item("NPEDIDO").ToString, dt.Rows(i).Item("RUC").ToString, dt.Rows(i).Item("CLIENTE").ToString, dt.Rows(i).Item("TRANSPORTES").ToString, dt.Rows(i).Item("ESTADO").ToString, dt.Rows(i).Item("IMPRESO").ToString, dt.Rows(i).Item("FECHA_IMPRESO").ToString, dt.Rows(i).Item("USUARIO").ToString, dt.Rows(i).Item("C5_DFECCRE").ToString, dt.Rows(i).Item("C5_DFECDOC").ToString)
                    Next

                    chkAll.Checked = True
                    CargarMarcadores()


                End If

                Contadores()

                Me.Cursor = Cursors.Default
            'End If



        Catch ex As Exception

        End Try
    End Sub


    Public Sub Contadores()
        Try
            Dim contPend As Integer = 0
            Dim contImp As Integer = 0


            For i As Integer = 0 To dgvGuiasImpresion.Rows.Count - 1

                If dgvGuiasImpresion.Rows(i).Cells.Item("IMPRESO").Value = "SI" Then
                    contImp = contImp + 1
                End If

            Next

            tslCantidad.Text = CStr(dgvGuiasImpresion.Rows.Count)
            tslPendImp.Text = CStr(dgvGuiasImpresion.Rows.Count - contImp)
            tslImpresos.Text = CStr(contImp)


        Catch ex As Exception

        End Try
    End Sub


    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Try

            Dim cont As Integer = 0

            For i As Integer = 0 To dgvGuiasImpresion.Rows.Count - 1
                If dgvGuiasImpresion.Rows(i).Cells.Item(0).Value = True Then
                    cont = cont + 1
                End If
            Next

            If cont = 0 Then
                MessageBox.Show("No existe ningun registro para imprimir !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                If MessageBox.Show("Esta Usted seguro que desea mandar a imprimir " + CStr(cont) + " documentos ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                    Me.Cursor = Cursors.WaitCursor

                    Registar_Impresion()

                    Me.Cursor = Cursors.Default

                End If

            End If



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Public Sub Registar_Impresion()
        Try
            Dim _BeDetallePicking As BeDetallePicking
            Dim _BeCabPicking As New BeCabPicking

            Dim _listadoPicking As New List(Of BeDetallePicking)

            Dim xml As String

            _BeCabPicking.prusr_id = usr_id

            For i As Integer = 0 To dgvGuiasImpresion.Rows.Count - 1

                If dgvGuiasImpresion.Rows(i).Cells.Item("selecGuia").Value = True Then
                    _BeDetallePicking = New BeDetallePicking

                    _BeDetallePicking.prc5_ctd = "GS"
                    _BeDetallePicking.prc5_cnumdoc = dgvGuiasImpresion.Rows(i).Cells.Item("GUIA").Value
                    _BeDetallePicking.prusr_id = usr_id

                    _listadoPicking.Add(_BeDetallePicking)
                End If

            Next

            _BeCabPicking.prListaItem = _listadoPicking
            xml = (_BeCabPicking.Registrar_Picking(_BeCabPicking))

            Dim _tipoespuesta As String = String.Empty
            Dim _textorespuesta As String = String.Empty
            Dim idPicking As String = String.Empty
            Dim fecHorReg As String = String.Empty
            Dim fecMod As String = String.Empty

            Dim obj As New BeCabPicking
            obj.RegistrarImpresionMasiva(xml, _tipoespuesta, _textorespuesta, idPicking, fecHorReg)
            'xml = (_BeProyCab.Registrar_Orden(_BeProyCab))

            If _tipoespuesta = "1" Then
                ImpresionMasiva()
                MessageBox.Show("Se completo la impresión !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If


        Catch ex As Exception

        End Try
    End Sub


    Public Sub ImpresionMasiva()

        Try
            For i As Integer = 0 To dgvGuiasImpresion.Rows.Count - 1

                If dgvGuiasImpresion.Rows(i).Cells.Item(0).Value = True Then

                    Dim aoReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                    Dim o_cuenta As String
                    Dim repFields1 As New CrystalDecisions.Shared.ParameterFields
                    Dim descField1 As New CrystalDecisions.Shared.ParameterField
                    Dim pDiscVal1 As New CrystalDecisions.Shared.ParameterDiscreteValue

                    o_cuenta = dgvGuiasImpresion.Rows(i).Cells.Item("GUIA").Value

                    descField1.Name = "@NROGUIA"
                    pDiscVal1.Value = o_cuenta

                    descField1.CurrentValues.Add(pDiscVal1)

                    repFields1.Add(descField1)

                    'Dim obj As New Medlab.Dl.Dalc.DalcConexion
                    'obj.ObenerImpresora()
                    'Dim valor As String
                    'Dim armat As String() = Nothing
                    'Dim posicion As Integer
                    Dim var As String
                    'var = Directory.
                    var = My.Application.Info.DirectoryPath


                    'var = Microsoft.VisualBasic.Left(Microsoft.VisualBasic.Left(var, 64), var.Length)
                    'posicion = InStr(var, "bin")
                    'var = var.Substring(0, posicion - 2)
                    aoReport.Load(var & "\Reporte\Reporte_GuiaNordic.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)
                    'aoReport.Load("D:\Reporte\Reporte_GuiaNordic.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)
                    'MsgBox(var & "\Reporte\Reporte_GuiaNordic.rpt")
                    aoReport.SetDatabaseLogon("sa", "D3b4s3", "10.10.0.5", "BDLABFAR")
                    'If logo = 1 Then
                    '    'MsgBox(var & "\Reportes\LabCore\CallCenter\Reporte_Resultados_Web_LabCore_logo.rpt")
                    '    aoReport.Load(var & "\Reportes\LabCore\Counter\CoReporte_Resultados_Web_LabCore_logo_x.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)

                    'Else
                    '    'aoReport.Load("D:\FuenteRvar & esultadoMedlab\ExportPDF\Medlab.Export.Frm.Ui\Reportes\LabCore\CallCenter\Reporte_Resultados_Web_LabCore.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)
                    '    'MsgBox(var & "\Reportes\LabCore\CallCenter\Reporte_Resultados_Web_LabCore.rpt")
                    '    aoReport.Load(var & "\Reportes\LabCore\Counter\CoReporte_Resultados_Web_LabCore_x.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)
                    'End If
                    aoReport.ParameterFields(0).CurrentValues.Add(pDiscVal1)

                    repFields1.Add(descField1)

                    Dim sFicINI As String = rutaArchivo
                    Dim sSeccion As String = "Laser"
                    Dim sTema1 As String = "Printer"
                    Dim sValor1 As String = ""


                    'Dim sGetValor As String = "\\10.10.0.2\HP LaserJet 425"
                    'sGetValor = mINI.IniGet(sFicINI, sSeccion, sTema1, sValor1)
                    Dim sGetValor As String = String.Empty
                    sGetValor = System.Configuration.ConfigurationManager.AppSettings("PrintPicking")

                    printCrystalReport(aoReport, 0, 0, 0, sGetValor)

                    aoReport.Dispose()
                    aoReport.Close()

                End If
            Next



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub printCrystalReport(ByVal aoReport As CrystalDecisions.CrystalReports.Engine.ReportDocument, ByVal aiNumCopias As Integer, ByVal aiPageBegin As Integer, ByVal aiPageEnd As Integer, ByVal asPrinterName As String)
        Try
            If (asPrinterName = String.Empty) Then
                Dim printDoc As New System.Drawing.Printing.PrintDocument()
                asPrinterName = printDoc.PrinterSettings.PrinterName
            End If

            ''Buscamos la impresora por defecto del sistema

            aoReport.PrintOptions.PrinterName = asPrinterName
            aoReport.PrintToPrinter(aiNumCopias, False, aiPageBegin, aiPageEnd)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Sub CargarMarcadores()
        Try
            For i As Integer = 0 To dgvGuiasImpresion.Rows.Count - 1

                If dgvGuiasImpresion.Rows(i).Cells.Item("IMPRESO").Value = "NO" Then

                    dgvGuiasImpresion.Rows(i).Cells.Item("selecGuia").Value = True
                Else
                    dgvGuiasImpresion.Rows(i).Cells.Item("selecGuia").Value = False
                End If

            Next
        Catch ex As Exception

        End Try
    End Sub


    Private Sub chkAll_CheckedChanged(sender As Object, e As EventArgs) Handles chkAll.CheckedChanged
        Try

            If chkAll.Checked = True Then
                For i As Integer = 0 To dgvGuiasImpresion.Rows.Count - 1

                    If dgvGuiasImpresion.Rows(i).Cells.Item("IMPRESO").Value = "NO" Then

                        dgvGuiasImpresion.Rows(i).Cells.Item("selecGuia").Value = True
                    Else
                        dgvGuiasImpresion.Rows(i).Cells.Item("selecGuia").Value = False
                    End If

                Next
            End If

            If chkAll.Checked = False Then
                For i As Integer = 0 To dgvGuiasImpresion.Rows.Count - 1
                    dgvGuiasImpresion.Rows(i).Cells.Item("selecGuia").Value = False
                Next
            End If



        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        Try

            If dgvGuiasImpresion.Rows.Count = 0 Then
                MessageBox.Show("No existen registros para exportar !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Me.Cursor = Cursors.WaitCursor

                GridAExcel(dgvGuiasImpresion)



                Me.Cursor = Cursors.Default

            End If



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