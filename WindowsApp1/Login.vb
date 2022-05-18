

Imports System.Net
Imports System.Net.Mail
Imports ClosedXML.Excel
Imports Nordic.Bl.Be

Public Class Login
    Private AlmacenLoBJ As New AlmacenL
    Private Estructura As New EstructuraTabla
    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click
        IniciarSesion()
    End Sub

    Public Sub IniciarSesion()
        Try
            Dim objLogin As New BeLogin

            objLogin.prUser = txtusuario.Text.Trim
            objLogin.prClave = txtclave.Text.Trim

            objLogin.Obtener_Logueo(objLogin.prUser, objLogin.prClave, objLogin.PrUserName, objLogin.pridUser, objLogin.PrPer_id)

            Dim frmMenu As New MenuPrincipal

            If objLogin.PrUserName <> "" Then

                frmMenu.prIdUser = objLogin.pridUser
                frmMenu.prUser = objLogin.prUser
                frmMenu.PrUserName = objLogin.PrUserName
                frmMenu.prPerId = objLogin.PrPer_id

                'If objLogin.PrPer_id = 9 Then
                '    If objLogin.prUser.Trim = "CAS" Then
                ProcesoAlerta()
                '    End If
                'End If

                frmMenu.Show()
                Me.Close()
            Else
                MessageBox.Show("Usuario o Clave Incorrecta", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub ProcesoAlerta()
        Dim ExisteAlerta As Integer = 0
        Dim FechaInicio As String = "", FechaFin As String = ""
        Try
            ExisteAlerta = AlmacenLoBJ.SP_CSE_ValidarAlerta.Rows.Count
            If ExisteAlerta = 0 Then
                Dim dia As String = "", Mes As String = ""

                dia = Now.Day.ToString
                Mes = Now.Month.ToString

                If Mes.Length = 1 Then
                    Mes = "0" + Mes
                End If
                If dia.Length = 1 Then
                    dia = "0" + dia
                End If
                FechaFin = dia + "/" + Mes + "/" + Now.Year.ToString
                Dim fEC As Date = DateAdd(DateInterval.Month, -6, Now).ToShortDateString()
                dia = fEC.Day.ToString
                Mes = fEC.Month.ToString

                If Mes.Length = 1 Then
                    Mes = "0" + Mes
                End If
                If dia.Length = 1 Then
                    dia = "0" + dia
                End If

                FechaInicio = "01/" + Mes.ToString + "/" + fEC.Year.ToString

                Dim DtAbastecer As New DataTable
                DtAbastecer = AlmacenLoBJ.ObtenerArticulosAbastercer(FechaInicio, FechaFin)
                Dim Form As New GestionAbastecimiento
                Form.bandera = 1
                Form.ListarGuiasCabecera()
                Dim Count As Integer = Form.Dg_Cabecera.Rows.Count
                If Count > 0 Then
                    Dim DtReporte As New DataTable
                    DtReporte = Estructura.ReporteAbastecimiento
                    For Each Dgrow As DataGridViewRow In Form.Dg_Cabecera.Rows
                        'If CType(Dgrow.Cells("COBERTACTUAL").Value, Integer) <= 7 And CType(Dgrow.Cells("STOCKCJM").Value, Integer) > 0 And Dgrow.Cells("ACCIONFINAL").Value.ToString.Trim = "OK".Trim Then
                        If CType(Dgrow.Cells("COBERTACTUAL").Value, Integer) <= 7 And CType(Dgrow.Cells("STOCKCJM").Value, Integer) > 0 Then
                            Dim RowAdd As DataRow = DtReporte.NewRow
                            RowAdd.Item("Cod Articulo") = Dgrow.Cells("CODIGO").EditedFormattedValue.ToString
                            RowAdd.Item("Articulo") = Dgrow.Cells("ARTICULO").EditedFormattedValue.ToString
                            RowAdd.Item("CJ Master Abastercer") = Dgrow.Cells("ABASTECJMATE").EditedFormattedValue.ToString
                            RowAdd.Item("M3 Abastecer") = Dgrow.Cells("ABASTEM3").EditedFormattedValue.ToString
                            RowAdd.Item("Cobertura Final Dias") = Dgrow.Cells("COBERTFINAL").EditedFormattedValue.ToString
                            RowAdd.Item("Cobertura Actual Dias") = Dgrow.Cells("COBERTACTUAL").EditedFormattedValue.ToString
                            RowAdd.Item("Accion") = Dgrow.Cells("ACCIONFINAL").EditedFormattedValue.ToString

                            DtReporte.Rows.Add(RowAdd)
                        End If
                    Next
                    If DtReporte.Rows.Count > 0 Then
                        ExportExcel(DtReporte)
                    End If
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Function ExportExcel(ByVal dt As DataTable) As Boolean
        Dim RP As Boolean = False
        Dim wb As New XLWorkbook()
        Dim path As String

        Try

            dt.TableName = "Hoja1"
            Dim ws As IXLWorksheet
            If dt.Rows.Count > Constantes.ValorEnteroInicial Then
                '.xlsx
                Dim desktopPath = My.Computer.FileSystem.SpecialDirectories.Desktop
                path = desktopPath + "\AlertaAbastecer.xlsx"
                If System.IO.File.Exists(path) Then
                    System.IO.File.Delete(path)
                End If
                wb.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left
                ws = wb.Worksheets.Add(dt)
                ws.Style.Font.FontName = "Arial"
                ws.Style.Font.FontSize = 8
                ws.Columns().AdjustToContents()
                wb.SaveAs(path)
                If SendMail(path) Then
                    If System.IO.File.Exists(path) Then
                        System.IO.File.Delete(path)
                    End If
                    Dim rpRegis As Integer = 0
                    rpRegis = AlmacenLoBJ.RegistrarAlerta

                End If
                'Process.Start(path)
                RP = True
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

    Public Function SendMail(patch As String) As Boolean
        Dim archivoAdjunto As Attachment = Nothing
        Dim smtpClient As New SmtpClient("smtp.office365.com", 587) 'I tried using different hosts and ports
        smtpClient.UseDefaultCredentials = False
        smtpClient.Credentials = New NetworkCredential("reportes@nordicperu.com", "N0rd1c15$21")
        smtpClient.EnableSsl = True 'Also tried setting this to false

        Dim mm As New MailMessage
        mm.From = New MailAddress("reportes@nordicperu.com")
        mm.Subject = "ALERTA ABASTECIMIENTO ATE"
        mm.IsBodyHtml = True
        mm.Body = "<h2>ESTOS SON LOS ARTICULOS CON COBERTURA MENOR A 7 DIAS</h2> <br> <h3>SISTEMAS NORDIC.</h3>"
        If System.IO.File.Exists(patch) Then
            archivoAdjunto = New System.Net.Mail.Attachment(patch)
        End If
        mm.Attachments.Add(archivoAdjunto)
        mm.To.Add("nicolas.calderon@nordicperu.com")
        mm.To.Add("aseguramientodelacalidad@nordicperu.com")
        mm.To.Add("mr@nordicperu.com")
        mm.To.Add("cesarsanchezelescano@salesland.net")
        Try
            smtpClient.Send(mm)
        Catch ex As Exception
        End Try

        mm.Dispose()
        smtpClient.Dispose()

        Return True

    End Function

    Private Sub txtclave_KeyDown(sender As Object, e As KeyEventArgs) Handles txtclave.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                IniciarSesion()
            End If
        Catch ex As Exception
            'Throw ex
            MsgBox("No se pudo Inicial Sesion", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Application.Exit()
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub checkVerPass_CheckedChanged(sender As Object, e As EventArgs) Handles checkVerPass.CheckedChanged
        If checkVerPass.Checked = True Then
            txtclave.PasswordChar = ""
        ElseIf checkVerPass.Checked = False Then
            txtclave.PasswordChar = "*"
        End If

    End Sub
End Class