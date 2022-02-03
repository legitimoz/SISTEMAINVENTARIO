Imports Nordic.Bl.Be

Public Class DetalleIngresoImprimir
    Public dtIngresoImprimir, dtDetalleParteEntrada As New DataTable
    Private Estructura As New EstructuraTabla
    Public idrack As Integer
    Public grabado As Boolean = False
    Private Sub DetalleIngresoImprimir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargaInicial()
    End Sub

    Private Sub CargaInicial()
        Try
            FormatoDatagrid()
            LlenarDataGrid()
        Catch ex As Exception

        End Try
    End Sub

    Public Sub FormatoDatagrid()
        Try
            dtIngresoImprimir.Clear()
            dtIngresoImprimir = Estructura.DetaleHojaIngresoReport(True)
            Dg_Detalle.DataSource = dtIngresoImprimir

            Dg_Detalle.Columns("Ubicaciones").HeaderText = "Ubicaciones"
            Dg_Detalle.Columns("Ubicaciones").Width = 70
            Dg_Detalle.Columns("Ubicaciones").ReadOnly = True
            Dg_Detalle.Columns("Ubicaciones").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            Dg_Detalle.Columns("CodArticulo").HeaderText = "Cod Articulo"
            Dg_Detalle.Columns("CodArticulo").Width = 85
            Dg_Detalle.Columns("CodArticulo").ReadOnly = True
            Dg_Detalle.Columns("CodArticulo").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            Dg_Detalle.Columns("Articulo").HeaderText = "Articulo"
            Dg_Detalle.Columns("Articulo").Width = 250
            Dg_Detalle.Columns("Articulo").ReadOnly = True
            Dg_Detalle.Columns("Articulo").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            Dg_Detalle.Columns("Lote").HeaderText = "Lote"
            Dg_Detalle.Columns("Lote").Width = 70
            Dg_Detalle.Columns("Lote").ReadOnly = True
            Dg_Detalle.Columns("Lote").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            Dg_Detalle.Columns("Cantidad").HeaderText = "Cantidad"
            Dg_Detalle.Columns("Cantidad").Width = 70
            Dg_Detalle.Columns("Cantidad").ReadOnly = True
            Dg_Detalle.Columns("Cantidad").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            Dg_Detalle.Columns("Volumen").HeaderText = "Volumen"
            Dg_Detalle.Columns("Volumen").Width = 70
            Dg_Detalle.Columns("Volumen").ReadOnly = True
            Dg_Detalle.Columns("Volumen").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            Dg_Detalle.Columns("Posicion1").HeaderText = "Posicion 1"
            Dg_Detalle.Columns("Posicion1").Width = 77
            Dg_Detalle.Columns("Posicion1").ReadOnly = True
            Dg_Detalle.Columns("Posicion1").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            Dg_Detalle.Columns("Posicion2").HeaderText = "Posicion 2"
            Dg_Detalle.Columns("Posicion2").Width = 77
            Dg_Detalle.Columns("Posicion2").ReadOnly = True
            Dg_Detalle.Columns("Posicion2").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            Dg_Detalle.Columns("Posicion3").HeaderText = "Posicion 3"
            Dg_Detalle.Columns("Posicion3").Width = 77
            Dg_Detalle.Columns("Posicion3").ReadOnly = True
            Dg_Detalle.Columns("Posicion3").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            Dg_Detalle.Columns("Cajas").Visible = False
            Dg_Detalle.Columns("CajasM").Visible = False
            Dg_Detalle.Columns("Saldo").Visible = False

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Dg_Detalle_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dg_Detalle.CellContentClick
        Try
            If e.RowIndex <> -1 Then
                'If e.RowIndex = 0 Then
                Dim row As DataGridViewRow = Dg_Detalle.Rows(e.RowIndex)
                    If row.Cells("Ubicaciones").Value = False Then
                        Dim SeleccionPosicionForm As New SeleccionarPosicionesIngreso
                        SeleccionPosicionForm.Text = "Seleccion de Ubicaciones para Articulo"
                    SeleccionPosicionForm.idrack = idrack
                    SeleccionPosicionForm.codArticulo = row.Cells("CodArticulo").EditedFormattedValue.ToString
                    SeleccionPosicionForm.ShowDialog()
                    If SeleccionPosicionForm.grabado = True Then
                            row.Cells("Posicion1").Value = SeleccionPosicionForm.posiciones.ElementAt(0)
                            row.Cells("Posicion2").Value = SeleccionPosicionForm.posiciones.ElementAt(1)
                            row.Cells("Posicion3").Value = SeleccionPosicionForm.posiciones.ElementAt(2)
                            row.Cells("Ubicaciones").Value = Not row.Cells("Ubicaciones").EditedFormattedValue
                        End If
                    End If
                'End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click
        Aceptar()
    End Sub

    Private Sub Aceptar()
        ErrorProvider1.SetError(Dg_Detalle, "")
        Try
            If ValidarAceptar() = False Then
                grabado = True
                Me.Close()
            Else
                ErrorProvider1.SetError(Dg_Detalle, "Debe Ingresar las Posiciones de Articulo")
                MsgBox("Existen Errore, valide", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function ValidarAceptar() As Boolean
        Dim rp As Boolean = False
        Try
            For Each rowdg As DataGridViewRow In Dg_Detalle.Rows
                If rowdg.Cells("Ubicaciones").Value = False Then
                    rp = True
                    Exit For
                End If
            Next
        Catch ex As Exception
            Throw ex
        End Try
        Return rp
    End Function

    Public Sub LlenarDataGrid()
        Dim cajas As Decimal = 0, cajasm As Decimal = 0, saldo As Decimal = 0
        Try
            If dtDetalleParteEntrada.Rows.Count > 0 Then
                For Each rowPe As DataRow In dtDetalleParteEntrada.Rows
                    Dim RowImpre As DataRow = dtIngresoImprimir.NewRow
                    RowImpre.Item("Ubicaciones") = False
                    RowImpre.Item("CodArticulo") = rowPe.Item("CODIGO")
                    RowImpre.Item("Articulo") = rowPe.Item("PRODUCTO")
                    RowImpre.Item("Lote") = rowPe.Item("SERIE")
                    RowImpre.Item("Cantidad") = rowPe.Item("SALDO")
                    RowImpre.Item("Lote") = rowPe.Item("SERIE")
                    RowImpre.Item("Volumen") = rowPe.Item("VOLUMEN")
                    RowImpre.Item("Posicion1") = ""
                    RowImpre.Item("Posicion2") = ""
                    RowImpre.Item("Posicion3") = ""

                    If rowPe.Item("UNIDAD").ToString = "UND" Then
                        If rowPe.Item("FACTORCAJA").ToString <> 0 And rowPe.Item("FACTORCAJAMASTER").ToString <> 0 Then
                            cajas = (rowPe.Item("SALDO") / rowPe.Item("FACTORCAJA"))
                            saldo = rowPe.Item("SALDO") Mod rowPe.Item("FACTORCAJA")
                            cajasm = cajas / rowPe.Item("FACTORCAJAMASTER")
                            cajasm = Math.Floor(cajasm)
                            cajas = cajas Mod rowPe.Item("FACTORCAJAMASTER")
                        End If
                    Else
                        If rowPe.Item("UNIDAD").ToString = "CJA" Then
                            saldo = 0
                            cajas = rowPe.Item("SALDO")
                            cajasm = cajas / rowPe.Item("FACTORCAJAMASTER")
                            cajasm = Math.Floor(cajasm)
                            cajas = cajas Mod rowPe.Item("FACTORCAJAMASTER")
                        End If
                    End If
                    RowImpre.Item("CajasM") = cajasm
                    RowImpre.Item("Cajas") = cajas
                    RowImpre.Item("Saldo") = saldo

                    dtIngresoImprimir.Rows.Add(RowImpre)
                Next
                Dg_Detalle.DataSource = dtIngresoImprimir
            End If
        Catch ex As Exception

        End Try
    End Sub

End Class