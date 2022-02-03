Imports ClosedXML.Excel
Imports Nordic.Bl.Be

Public Class frmRotuladoxCodigoxSerie

    Public nroguia As String
    Public usr_id As String

    Dim rutaArchivo As String = Application.StartupPath + "\Config.ini"
    Private mINI As New InitArray
    Private AlmacenObj As New AlmacenL

    Private Sub btnBusqueda_Click(sender As Object, e As EventArgs) Handles btnBusqueda.Click
        Try
            Dim objFrm As New frmBusquedaGuiaRotulos
            objFrm.nroguia = txtBusquedaGuia.Text.Trim
            objFrm.ShowDialog()
            txtNroGuia.Text = objFrm.nroguia
            C5_CALMA.Text = objFrm.c5_calma
            C5_CTD.Text = objFrm.c5_cctd
            C5_CNUMDOC.Text = objFrm.c5_cnumdoc
            txtCodigo.Text = objFrm.c5_ccodigo
            txtArticulo.Text = objFrm.articulo
            txtLote.Text = objFrm.lote
            txtFechaVenc.Text = objFrm.fechaVenc
            txtCantidad.Text = objFrm.cantidad
            lblSaldo.Text = txtCantidad.Text
        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            Dim cantidad As Integer = 0
            Dim saldo As Integer = 0

            cantidad = CInt(txtAnadirCantidad.Text)
            saldo = CInt(lblSaldo.Text)

            If cantidad > saldo Then
                MessageBox.Show("La cantidad ingresada no puede ser superior al saldo !!")

            Else
                dgvCantidades.Rows.Add(CStr(cantidad))
                CalcularTotal()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub CalcularTotal()
        Try
            Dim cantidad As Integer = 0
            Dim acum As Integer = 0
            Dim cantTotal As Integer = 0
            Dim saldo As Integer = 0


            For i As Integer = 0 To dgvCantidades.Rows.Count - 1
                cantidad = CInt(dgvCantidades.Rows(i).Cells.Item(0).Value)
                acum = acum + cantidad
            Next

            cantTotal = txtCantidad.Text
            saldo = cantTotal - acum

            lblSaldo.Text = CStr(saldo)
            lblTotal.Text = CStr(acum)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnImprimirEtiqueta_Click(sender As Object, e As EventArgs) Handles btnImprimirEtiqueta.Click
        Try
            Dim _BeDetalleRotulos As BeDetalleRotulosxArticulo
            Dim _BeCabRotulos As New BeCabRotuloxArticulo

            Dim _listadoPicking As New List(Of BeDetalleRotulosxArticulo)

            Dim xml As String

            _BeCabRotulos.prusr_id = usr_id

            For i As Integer = 0 To dgvCantidades.Rows.Count - 1

                If dgvCantidades.Rows(i).Cells.Item(0).Value = True Then
                    _BeDetalleRotulos = New BeDetalleRotulosxArticulo
                    _BeDetalleRotulos.VENCIMIENTO_P = txtFechaVenc.Text
                    _BeDetalleRotulos.prc5_calma = C5_CALMA.Text
                    _BeDetalleRotulos.prc5_ctd = C5_CTD.Text
                    _BeDetalleRotulos.prc5_cnumdoc = C5_CNUMDOC.Text
                    _BeDetalleRotulos.prsr_ccodigo = txtCodigo.Text
                    _BeDetalleRotulos.prsr_cserie = txtLote.Text
                    _BeDetalleRotulos.prCantidad = dgvCantidades.Rows(i).Cells.Item("cantidad").Value

                    _BeDetalleRotulos.prusr_id = usr_id

                    _listadoPicking.Add(_BeDetalleRotulos)
                End If

            Next

            _BeCabRotulos.prListaItem = _listadoPicking
            xml = (_BeCabRotulos.Registrar_Rotulos(_BeCabRotulos))

            Dim _tipoespuesta As String = String.Empty
            Dim _textorespuesta As String = String.Empty
            Dim idPicking As String = String.Empty
            Dim fecHorReg As String = String.Empty
            Dim fecMod As String = String.Empty

            Dim obj As New BeCabRotuloxArticulo
            obj.RegistrarImpresionRotulosxArticulos(xml, _tipoespuesta, _textorespuesta, idPicking, fecHorReg)
            'xml = (_BeProyCab.Registrar_Orden(_BeProyCab))

            If _tipoespuesta = "1" Then
                'ImpresionMasiva()
                MessageBox.Show("Se completo la impresión !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception

        End Try
    End Sub




    Public Sub ImpresionMasiva()

        Try

            Dim aoReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument

            Dim _C5_CALMA As String = String.Empty
            Dim _C5_CTD As String = String.Empty
            Dim _C5_CNUMDOC As String = String.Empty
            Dim _CODIGO As String = String.Empty
            Dim _SERIE As String = String.Empty


            Dim repFields1 As New CrystalDecisions.Shared.ParameterFields
            Dim descField1 As New CrystalDecisions.Shared.ParameterField
            Dim pDiscVal1 As New CrystalDecisions.Shared.ParameterDiscreteValue

            Dim repFields2 As New CrystalDecisions.Shared.ParameterFields
            Dim descField2 As New CrystalDecisions.Shared.ParameterField
            Dim pDiscVal2 As New CrystalDecisions.Shared.ParameterDiscreteValue

            Dim repFields3 As New CrystalDecisions.Shared.ParameterFields
            Dim descField3 As New CrystalDecisions.Shared.ParameterField
            Dim pDiscVal3 As New CrystalDecisions.Shared.ParameterDiscreteValue

            Dim repFields4 As New CrystalDecisions.Shared.ParameterFields
            Dim descField4 As New CrystalDecisions.Shared.ParameterField
            Dim pDiscVal4 As New CrystalDecisions.Shared.ParameterDiscreteValue

            Dim repFields5 As New CrystalDecisions.Shared.ParameterFields
            Dim descField5 As New CrystalDecisions.Shared.ParameterField
            Dim pDiscVal5 As New CrystalDecisions.Shared.ParameterDiscreteValue


            _C5_CALMA = C5_CALMA.Text
            _C5_CTD = C5_CTD.Text
            _C5_CNUMDOC = C5_CNUMDOC.Text
            _CODIGO = txtCodigo.Text
            _SERIE = txtLote.Text


            descField1.Name = "@C5_CALMA"
            pDiscVal1.Value = C5_CALMA
            descField1.CurrentValues.Add(pDiscVal1)
            repFields1.Add(descField1)


            descField2.Name = "@C5_CTD"
            pDiscVal2.Value = C5_CTD
            descField2.CurrentValues.Add(pDiscVal2)
            repFields2.Add(descField2)


            descField3.Name = "@C5_CNUMDOC"
            pDiscVal3.Value = C5_CNUMDOC
            descField3.CurrentValues.Add(pDiscVal3)
            repFields3.Add(descField3)

            descField4.Name = "@SR_CODIGO"
            pDiscVal4.Value = _CODIGO
            descField4.CurrentValues.Add(pDiscVal4)
            repFields4.Add(descField4)


            descField5.Name = "@SR_CSERIE"
            pDiscVal5.Value = _SERIE
            descField5.CurrentValues.Add(pDiscVal5)
            repFields5.Add(descField5)


            Dim var As String
            var = My.Application.Info.DirectoryPath

            aoReport.Load(var & "\Reporte\Reporte_RotulosProvincia.rpt", CrystalDecisions.Shared.OpenReportMethod.OpenReportByDefault)
            aoReport.SetDatabaseLogon("headmark", "N0rd1c06$21", "", "BDLABFAR")

            aoReport.ParameterFields(0).CurrentValues.Add(pDiscVal1)
            repFields1.Add(descField1)

            aoReport.ParameterFields(1).CurrentValues.Add(pDiscVal2)
            repFields2.Add(descField2)

            aoReport.ParameterFields(2).CurrentValues.Add(pDiscVal3)
            repFields3.Add(descField3)

            aoReport.ParameterFields(3).CurrentValues.Add(pDiscVal4)
            repFields4.Add(descField4)

            aoReport.ParameterFields(4).CurrentValues.Add(pDiscVal5)
            repFields4.Add(descField5)


            Dim sFicINI As String = rutaArchivo
            Dim sSeccion As String = "Laser"
            Dim sTema1 As String = "Printer"
            Dim sValor1 As String = ""

            'Dim sGetValor As String = "\\10.10.0.2\HP LaserJet 425"
            'sGetValor = mINI.IniGet(sFicINI, sSeccion, sTema1, sValor1)
            Dim sGetValor As String = String.Empty
            sGetValor = System.Configuration.ConfigurationManager.AppSettings("PrintRotulosArti")

            'printCrystalReport(aoReport, 0, 0, 0, sGetValor)

            aoReport.Dispose()
            aoReport.Close()



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Function ExportExcel(ByVal dt As DataTable) As Boolean
        Dim RP As Boolean = False
        Dim wb As New XLWorkbook()
        Dim path As String

        Try
            savedialog_Excel.Filter = "Excel File(.xlsx)|*.xlsx"
            savedialog_Excel.Title = Text
            savedialog_Excel.FileName = "ROTULOS ARTICULO"
            dt.TableName = "Hoja1"
            Dim ws As IXLWorksheet
            If dt.Rows.Count > Constantes.ValorEnteroInicial Then
                If savedialog_Excel.ShowDialog = Windows.Forms.DialogResult.OK Then
                    path = savedialog_Excel.FileName
                    wb.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left
                    ws = wb.Worksheets.Add(dt)
                    ws.Style.Font.FontName = "Arial"
                    ws.Style.Font.FontSize = 8
                    ws.Columns().AdjustToContents()
                    wb.SaveAs(path)
                    Process.Start(path)
                    RP = True
                End If
            Else
                MsgBox("No existe DATA para generar Excel, Confirme Orden de Pago", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            Dim iderror As Integer
            iderror = ex.HResult
            If iderror = Constantes.errorexcel Then
                MsgBox("Archivo Excel se encuentra abierto, cierre el archivo e intente de nuevo", MsgBoxStyle.Exclamation)
            End If
        End Try
        Return RP

    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If C5_CALMA.Text.Trim <> "[C5_CALMA]" And C5_CTD.Text.Trim <> "[C5_CTD]" And C5_CNUMDOC.Text.Trim <> "[C5_CNUMDOC]" Then
                Dim dt As New DataTable
                dt = AlmacenObj.ReporteRotulosProducto(C5_CALMA.Text.Trim, C5_CTD.Text.Trim, C5_CNUMDOC.Text.Trim)
                If dt.Rows.Count > 0 Then
                    If ExportExcel(dt) Then
                        MsgBox("Excel Exportado Correctamente", MsgBoxStyle.Information, "SISTEMAS NORDIC")
                    Else
                        MsgBox("Error al exportar Excel", MsgBoxStyle.Critical, "SISTEMAS NORDIC")
                    End If
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class