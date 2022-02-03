Public Class MenuPrincipal
    Public prUser As String
    Public PrUserName As String
    Public prIdUser As String
    Public prPerId As String

    Private Sub MenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.Text = "<< SISTEMA DE LABORATORIO FARMACEUTICO >>  " _
                        & "            BIENVENIDO: " & PrUserName & ""
            If prPerId = 1 Or prPerId = 2 Or prPerId = 3 Then
                ReporteVentasToolStripMenuItem.Enabled = True
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub MenuPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            If MsgBox("¿ DESEA SALIR DEL SISTEMA ?", MsgBoxStyle.YesNo, "Aviso") = MsgBoxResult.No Then
                e.Cancel = True
            Else
                ' EndD
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AprobacionDePedidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AprobacionDePedidosToolStripMenuItem.Click
        Try
            Dim frmrPedidos As New frmVisorPedidos
            If ExisteChildrens(frmrPedidos) = False Then
                frmrPedidos.tu_alias1 = prUser
                frmrPedidos.idUser = prIdUser
                frmrPedidos.MdiParent = Me
                frmrPedidos.Show()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Function ExisteChildrens(ByVal ofrm As Form) As Boolean
        Dim bValido As Boolean
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            If Me.MdiChildren(i).Name = ofrm.Name Then
                Me.MdiChildren(i).Focus()
                bValido = True
            End If
        Next
        For i As Integer = 0 To Me.OwnedForms.Length - 1
            If Me.OwnedForms(i).Name = ofrm.Name Then
                Me.OwnedForms(i).Focus()
                bValido = True
            End If
        Next
        Return bValido
    End Function

    Private Sub PresupuestosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PresupuestosToolStripMenuItem.Click
        Try
            Dim frmrPresu As New frmRepPresupuesto
            If ExisteChildrens(frmrPresu) = False Then
                frmrPresu.MdiParent = Me
                frmrPresu.Show()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PickingToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Try
            Dim frmrPicking As New frmRepPicking
            If ExisteChildrens(frmrPicking) = False Then
                frmrPicking.MdiParent = Me
                frmrPicking.Show()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PickingMasivoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Try
            Dim frmPickingMasivo As New frmImpreMasivaPickingvb
            If ExisteChildrens(frmPickingMasivo) = False Then
                frmPickingMasivo.usr_id = prIdUser
                frmPickingMasivo.MdiParent = Me
                frmPickingMasivo.Show()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ControlDeStockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ControlDeStockToolStripMenuItem.Click
        Try
            Dim frmControlStock As New frmControlStock
            If ExisteChildrens(frmControlStock) = False Then
                frmControlStock.MdiParent = Me
                frmControlStock.Show()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SalidaRetornoRutaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalidaRetornoRutaToolStripMenuItem.Click
        Try
            Dim frmSalidaRetorno As New frmSalidaRetorno_Ruta
            If ExisteChildrens(frmSalidaRetorno) = False Then
                frmSalidaRetorno.usr_id = prIdUser
                frmSalidaRetorno.MdiParent = Me
                frmSalidaRetorno.Show()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PickingUnitarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PickingUnitarioToolStripMenuItem.Click
        Try
            Dim frmrPicking As New frmRepPicking
            If ExisteChildrens(frmrPicking) = False Then
                frmrPicking.MdiParent = Me
                frmrPicking.Show()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PickingMasivoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PickingMasivoToolStripMenuItem1.Click
        Try
            Dim frmPickingMasivo As New frmImpreMasivaPickingvb
            If ExisteChildrens(frmPickingMasivo) = False Then
                frmPickingMasivo.usr_id = prIdUser
                frmPickingMasivo.MdiParent = Me
                frmPickingMasivo.Show()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CerrarSesionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesionToolStripMenuItem.Click
        Try
            Dim a As New FormClosingEventArgs(CloseReason.ApplicationExitCall, True)
            MenuPrincipal_FormClosing(sender, a)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ReporteDeDespachosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeDespachosToolStripMenuItem.Click
        Try
            Dim frmReportDespacho As New frmReporteDespacho
            If ExisteChildrens(frmReportDespacho) = False Then
                frmReportDespacho.MdiParent = Me
                frmReportDespacho.Show()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RegistrarDocumentosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarDocumentosToolStripMenuItem.Click
        Try
            Dim frmGestorDoc As New frmListado_Documentos
            If ExisteChildrens(frmGestorDoc) = False Then
                frmGestorDoc.MdiParent = Me
                frmGestorDoc.usr_id = prIdUser
                frmGestorDoc.Show()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SolicitudesInstitucionalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SolicitudesInstitucionalToolStripMenuItem.Click
        Try
            Dim frmSolInstitucional As New frmSolicitud_Institucional
            If ExisteChildrens(frmSolInstitucional) = False Then
                frmSolInstitucional.MdiParent = Me
                frmSolInstitucional.usr_id = prIdUser
                frmSolInstitucional.usr_usuario = prUser
                frmSolInstitucional.Show()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ImportarArchivoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportarArchivoToolStripMenuItem.Click
        Try
            Dim frmImportar As New Importar_Archivos
            If ExisteChildrens(frmImportar) = False Then
                frmImportar.MdiParent = Me
                frmImportar.usr_id = prIdUser
                frmImportar.Show()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ArticulosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArticulosToolStripMenuItem.Click
        Try
            Dim frmArt As New frmArticulos
            If ExisteChildrens(frmArt) = False Then
                frmArt.MdiParent = Me
                frmArt.usr_id = prIdUser
                frmArt.usr_usuario = prUser
                frmArt.Show()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub tsmRequerimiento_Click(sender As Object, e As EventArgs) Handles tsmRequerimiento.Click
        Try
            Dim frmReq As New frmSegReque
            If ExisteChildrens(frmReq) = False Then
                frmReq.MdiParent = Me
                frmReq.usr_id = prIdUser
                frmReq.usr_usuario = prUser
                frmReq.Show()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub VisorDeRepresentantesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VisorDeRepresentantesToolStripMenuItem.Click
        Try
            Dim frmVisorRepre As New frmVisorRepre
            If ExisteChildrens(frmVisorRepre) = False Then
                frmVisorRepre.MdiParent = Me
                frmVisorRepre.Show()
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub ImportarArchivoSsendaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportarArchivoSsendaToolStripMenuItem.Click
        Try
            Dim frmImportarSsenda As New frmImportar_Ssenda
            If ExisteChildrens(frmImportarSsenda) = False Then
                frmImportarSsenda.MdiParent = Me
                frmImportarSsenda.usr_id = prIdUser
                frmImportarSsenda.Show()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LotesYUbicacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LotesYUbicacionesToolStripMenuItem.Click
        Try
            Dim frmLotesUbi As New frmLotesUbicacion
            If ExisteChildrens(frmLotesUbi) = False Then
                frmLotesUbi.MdiParent = Me
                frmLotesUbi.usr_id = prIdUser
                frmLotesUbi.Show()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ReporteVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteVentasToolStripMenuItem.Click
        Try
            Dim frmRepVenta As New frmReporteVentas
            If ExisteChildrens(frmRepVenta) = False Then
                frmRepVenta.MdiParent = Me
                frmRepVenta.prIdUser = prIdUser
                frmRepVenta.Show()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ImpresiónGuiaSsendaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImpresiónGuiaSsendaToolStripMenuItem.Click
        Try
            Dim frmRepVenta As New frmImpGuiaSsenda
            If ExisteChildrens(frmRepVenta) = False Then
                frmRepVenta.MdiParent = Me
                'frmRepVenta.usr_id = prIdUser
                frmRepVenta.Show()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ReporteDeDespachosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ReporteDeDespachosToolStripMenuItem1.Click
        Try
            Dim frmReptDes As New frmReporteDespachosGrafico
            If ExisteChildrens(frmReptDes) = False Then
                frmReptDes.MdiParent = Me
                'frmRepVenta.usr_id = prIdUser
                frmReptDes.Show()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub tsmGestorRequerimientos_Click(sender As Object, e As EventArgs) Handles tsmGestorRequerimientos.Click
        Try
            Dim frmReque As New frmRequerimientos_TI
            If ExisteChildrens(frmReque) = False Then
                frmReque.MdiParent = Me
                frmReque.usr_id = prIdUser
                frmReque.prPerId = prPerId
                frmReque.Show()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ReporteDocumentosPendientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDocumentosPendientesToolStripMenuItem.Click
        Try
            Dim frmDocPend As New frmReporteDocPendScan
            If ExisteChildrens(frmDocPend) = False Then
                frmDocPend.MdiParent = Me
                frmDocPend.Show()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AlmacenesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlmacenesToolStripMenuItem.Click
        Try
            Dim frmArt As New Form1
            If ExisteChildrens(frmArt) = False Then
                frmArt.MdiParent = Me
                frmArt.usr_id = prIdUser
                frmArt.usr_usuario = prUser
                frmArt.WindowState = FormWindowState.Maximized
                frmArt.Text = "Gestion Almacenes"
                frmArt.Width = Me.Width
                frmArt.Height = Me.Height
                frmArt.Show()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub PickConfirmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PickConfirmToolStripMenuItem.Click
        Try
            Dim frmArt As New GestionPedidoSalida
            If ExisteChildrens(frmArt) = False Then
                frmArt.MdiParent = Me
                frmArt.usr_id = prIdUser
                frmArt.usr_usuario = prUser
                frmArt.WindowState = FormWindowState.Maximized
                frmArt.Text = "Gestion Pedidos"
                frmArt.Width = Me.Width
                frmArt.Height = Me.Height
                frmArt.Show()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub GuiasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuiasToolStripMenuItem.Click
        Try
            Dim frmArt As New GestionGuiasSalida
            If ExisteChildrens(frmArt) = False Then
                frmArt.MdiParent = Me
                frmArt.usr_id = prIdUser
                frmArt.usr_usuario = prUser
                frmArt.WindowState = FormWindowState.Maximized
                frmArt.Text = "Gestion Guias"
                frmArt.Width = Me.Width
                frmArt.Height = Me.Height
                frmArt.Show()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Private Sub ImpresiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImpresiónToolStripMenuItem.Click
        Try

            Dim frmRotulado As New frmRotuladoxCodigoxSerie

            If ExisteChildrens(frmRotulado) = False Then

                frmRotulado.MdiParent = Me
                frmRotulado.usr_id = prIdUser
                'frmArt.usr_usuario = prUser
                'frmArt.Text = "Lista Pedidos - Salida"
                frmRotulado.Show()
            End If

        Catch ex As Exception

        End Try
    End Sub


    Private Sub UbicacionesArticuloToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UbicacionesArticuloToolStripMenuItem.Click
        Try
            Dim frmArt As New BuscadorArticulosUbicaion
            If ExisteChildrens(frmArt) = False Then
                frmArt.MdiParent = Me
                frmArt.usr_id = prIdUser
                frmArt.usr_usuario = prUser
                frmArt.WindowState = FormWindowState.Maximized
                frmArt.Width = Me.Width
                frmArt.Height = Me.Height
                frmArt.Show()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ProgramacionDespachoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProgramacionDespachoToolStripMenuItem.Click
        Try
            Dim frmArt As New GestionProgramacionDespacho
            If ExisteChildrens(frmArt) = False Then
                frmArt.MdiParent = Me
                frmArt.usr_id = prIdUser
                frmArt.usr_usuario = prUser
                ' frmArt.WindowState = FormWindowState.Maximized
                frmArt.Width = Me.Width
                frmArt.Height = Me.Height
                frmArt.Show()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub PedidosProgramacionPickingToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Try
            Dim frmPed As New frmReportePedidosPicking
            If ExisteChildrens(frmPed) = False Then
                frmPed.MdiParent = Me

                frmPed.Show()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub PedidosProgramacionPickingToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PedidosProgramacionPickingToolStripMenuItem1.Click
        Try
            Dim frmPed As New frmReportePedidosPicking
            If ExisteChildrens(frmPed) = False Then
                frmPed.MdiParent = Me

                frmPed.Show()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub DispatchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DispatchToolStripMenuItem.Click
        Try
            Dim frmPed As New GestionDispatchOnTime
            If ExisteChildrens(frmPed) = False Then
                frmPed.MdiParent = Me
                frmPed.Show()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub DeliveryOnTimeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeliveryOnTimeToolStripMenuItem.Click
        Try
            Dim frmPed As New GestionDeliveryOnTime
            If ExisteChildrens(frmPed) = False Then
                frmPed.MdiParent = Me
                frmPed.Show()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ArticulosSinUbicacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArticulosSinUbicacionToolStripMenuItem.Click
        Try
            Dim frmPed As New ReporteArticulosSinUbicar
            If ExisteChildrens(frmPed) = False Then
                frmPed.MdiParent = Me

                frmPed.Show()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ExcelRotuladosProvinciaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExcelRotuladosProvinciaToolStripMenuItem.Click
        Try
            Dim frmPed As New GestionImportarRotulosProvincia
            If ExisteChildrens(frmPed) = False Then
                frmPed.MdiParent = Me
                frmPed.Show()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub NonConformityRatioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NonConformityRatioToolStripMenuItem.Click
        Try
            Dim frmPed As New GestionNonConformityRatio
            If ExisteChildrens(frmPed) = False Then
                frmPed.MdiParent = Me
                frmPed.Show()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub GenerarAbastecimientoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenerarAbastecimientoToolStripMenuItem.Click
        Try

        Catch ex As Exception

        End Try
    End Sub

    Private Sub SeguimientoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeguimientoToolStripMenuItem.Click

    End Sub
End Class