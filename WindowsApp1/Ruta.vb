Public Class Ruta

    Public dtnorte, dtsur, dtcentro, dtoeste, dtoeste1 As New DataTable

    Private Sub btn_moverNorte_Click(sender As Object, e As EventArgs) Handles btn_moverNorte.Click
        Try
            Dim SelecFrom As New SelectDestinoRuta
            Dim destino As String
            SelecFrom.Origen = "NORTE"
            SelecFrom.ShowDialog()
            If SelecFrom.grabado = True Then
                destino = SelecFrom.Destino
                For Each dr As DataGridViewRow In Dg_NORTE.Rows
                    If dr.Selected = True Then
                        If destino = "SUR" Then
                            Dim Rowsur As DataRow = dtsur.NewRow
                            Rowsur.Item("RUTA") = dr.Cells("RUTA").EditedFormattedValue
                            Rowsur.Item("DETALLE") = dr.Cells("DETALLE").EditedFormattedValue
                            Rowsur.Item("NOM_CLIENTE") = dr.Cells("NOM_CLIENTE").EditedFormattedValue
                            Rowsur.Item("DISTRITO") = dr.Cells("DISTRITO").EditedFormattedValue
                            Rowsur.Item("DIRECCION_ENTREGA") = dr.Cells("DIRECCION_ENTREGA").EditedFormattedValue
                            Rowsur.Item("CANAL") = dr.Cells("CANAL").EditedFormattedValue
                            Rowsur.Item("RESTRICCION") = dr.Cells("RESTRICCION").EditedFormattedValue
                            Rowsur.Item("TOTALIMPORTE") = dr.Cells("TOTALIMPORTE").EditedFormattedValue
                            Rowsur.Item("CANTIDADGUIAS") = dr.Cells("CANTIDADGUIAS").EditedFormattedValue
                            Rowsur.Item("TIEMPOENTREGA") = dr.Cells("TIEMPOENTREGA").EditedFormattedValue
                            Rowsur.Item("TOTALMETROSCUBICOS") = dr.Cells("TOTALMETROSCUBICOS").EditedFormattedValue
                            Rowsur.Item("COMENTARIO") = dr.Cells("COMENTARIO").EditedFormattedValue
                            dtsur.Rows.Add(Rowsur)
                            Dg_NORTE.Rows.RemoveAt(dr.Index)
                        End If
                        If destino = "CENTRO" Then
                            Dim Rowsur As DataRow = dtcentro.NewRow
                            Rowsur.Item("RUTA") = dr.Cells("RUTA").EditedFormattedValue
                            Rowsur.Item("DETALLE") = dr.Cells("DETALLE").EditedFormattedValue
                            Rowsur.Item("NOM_CLIENTE") = dr.Cells("NOM_CLIENTE").EditedFormattedValue
                            Rowsur.Item("DISTRITO") = dr.Cells("DISTRITO").EditedFormattedValue
                            Rowsur.Item("DIRECCION_ENTREGA") = dr.Cells("DIRECCION_ENTREGA").EditedFormattedValue
                            Rowsur.Item("CANAL") = dr.Cells("CANAL").EditedFormattedValue
                            Rowsur.Item("RESTRICCION") = dr.Cells("RESTRICCION").EditedFormattedValue
                            Rowsur.Item("TOTALIMPORTE") = dr.Cells("TOTALIMPORTE").EditedFormattedValue
                            Rowsur.Item("CANTIDADGUIAS") = dr.Cells("CANTIDADGUIAS").EditedFormattedValue
                            Rowsur.Item("TIEMPOENTREGA") = dr.Cells("TIEMPOENTREGA").EditedFormattedValue
                            Rowsur.Item("TOTALMETROSCUBICOS") = dr.Cells("TOTALMETROSCUBICOS").EditedFormattedValue
                            Rowsur.Item("COMENTARIO") = dr.Cells("COMENTARIO").EditedFormattedValue
                            dtcentro.Rows.Add(Rowsur)
                            Dg_NORTE.Rows.RemoveAt(dr.Index)
                        End If

                        If destino = "OESTE" Then
                            Dim Rowsur As DataRow = dtoeste.NewRow
                            Rowsur.Item("RUTA") = dr.Cells("RUTA").EditedFormattedValue
                            Rowsur.Item("DETALLE") = dr.Cells("DETALLE").EditedFormattedValue
                            Rowsur.Item("NOM_CLIENTE") = dr.Cells("NOM_CLIENTE").EditedFormattedValue
                            Rowsur.Item("DISTRITO") = dr.Cells("DISTRITO").EditedFormattedValue
                            Rowsur.Item("DIRECCION_ENTREGA") = dr.Cells("DIRECCION_ENTREGA").EditedFormattedValue
                            Rowsur.Item("CANAL") = dr.Cells("CANAL").EditedFormattedValue
                            Rowsur.Item("RESTRICCION") = dr.Cells("RESTRICCION").EditedFormattedValue
                            Rowsur.Item("TOTALIMPORTE") = dr.Cells("TOTALIMPORTE").EditedFormattedValue
                            Rowsur.Item("CANTIDADGUIAS") = dr.Cells("CANTIDADGUIAS").EditedFormattedValue
                            Rowsur.Item("TIEMPOENTREGA") = dr.Cells("TIEMPOENTREGA").EditedFormattedValue
                            Rowsur.Item("TOTALMETROSCUBICOS") = dr.Cells("TOTALMETROSCUBICOS").EditedFormattedValue
                            Rowsur.Item("COMENTARIO") = dr.Cells("COMENTARIO").EditedFormattedValue
                            dtoeste.Rows.Add(Rowsur)
                            Dg_NORTE.Rows.RemoveAt(dr.Index)
                        End If

                        If destino = "OESTE1" Then
                            Dim Rowsur As DataRow = dtoeste1.NewRow
                            Rowsur.Item("RUTA") = dr.Cells("RUTA").EditedFormattedValue
                            Rowsur.Item("DETALLE") = dr.Cells("DETALLE").EditedFormattedValue
                            Rowsur.Item("NOM_CLIENTE") = dr.Cells("NOM_CLIENTE").EditedFormattedValue
                            Rowsur.Item("DISTRITO") = dr.Cells("DISTRITO").EditedFormattedValue
                            Rowsur.Item("DIRECCION_ENTREGA") = dr.Cells("DIRECCION_ENTREGA").EditedFormattedValue
                            Rowsur.Item("CANAL") = dr.Cells("CANAL").EditedFormattedValue
                            Rowsur.Item("RESTRICCION") = dr.Cells("RESTRICCION").EditedFormattedValue
                            Rowsur.Item("TOTALIMPORTE") = dr.Cells("TOTALIMPORTE").EditedFormattedValue
                            Rowsur.Item("CANTIDADGUIAS") = dr.Cells("CANTIDADGUIAS").EditedFormattedValue
                            Rowsur.Item("TIEMPOENTREGA") = dr.Cells("TIEMPOENTREGA").EditedFormattedValue
                            Rowsur.Item("TOTALMETROSCUBICOS") = dr.Cells("TOTALMETROSCUBICOS").EditedFormattedValue
                            Rowsur.Item("COMENTARIO") = dr.Cells("COMENTARIO").EditedFormattedValue
                            dtoeste1.Rows.Add(Rowsur)
                            Dg_NORTE.Rows.RemoveAt(dr.Index)
                        End If

                    End If
                Next
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_moverSur_Click(sender As Object, e As EventArgs) Handles btn_moverSur.Click
        Try
            Dim SelecFrom As New SelectDestinoRuta
            Dim destino As String
            SelecFrom.Origen = "SUR"
            SelecFrom.ShowDialog()
            If SelecFrom.grabado = True Then
                destino = SelecFrom.Destino
                For Each dr As DataGridViewRow In DG_SUR.Rows
                    If dr.Selected = True Then
                        If destino = "NORTE" Then
                            Dim Rowsur As DataRow = dtnorte.NewRow
                            Rowsur.Item("RUTA") = dr.Cells("RUTA").EditedFormattedValue
                            Rowsur.Item("DETALLE") = dr.Cells("DETALLE").EditedFormattedValue
                            Rowsur.Item("NOM_CLIENTE") = dr.Cells("NOM_CLIENTE").EditedFormattedValue
                            Rowsur.Item("DISTRITO") = dr.Cells("DISTRITO").EditedFormattedValue
                            Rowsur.Item("DIRECCION_ENTREGA") = dr.Cells("DIRECCION_ENTREGA").EditedFormattedValue
                            Rowsur.Item("CANAL") = dr.Cells("CANAL").EditedFormattedValue
                            Rowsur.Item("RESTRICCION") = dr.Cells("RESTRICCION").EditedFormattedValue
                            Rowsur.Item("TOTALIMPORTE") = dr.Cells("TOTALIMPORTE").EditedFormattedValue
                            Rowsur.Item("CANTIDADGUIAS") = dr.Cells("CANTIDADGUIAS").EditedFormattedValue
                            Rowsur.Item("TIEMPOENTREGA") = dr.Cells("TIEMPOENTREGA").EditedFormattedValue
                            Rowsur.Item("TOTALMETROSCUBICOS") = dr.Cells("TOTALMETROSCUBICOS").EditedFormattedValue
                            Rowsur.Item("COMENTARIO") = dr.Cells("COMENTARIO").EditedFormattedValue
                            dtnorte.Rows.Add(Rowsur)
                            DG_SUR.Rows.RemoveAt(dr.Index)
                        End If
                        If destino = "CENTRO" Then
                            Dim Rowsur As DataRow = dtcentro.NewRow
                            Rowsur.Item("RUTA") = dr.Cells("RUTA").EditedFormattedValue
                            Rowsur.Item("DETALLE") = dr.Cells("DETALLE").EditedFormattedValue
                            Rowsur.Item("NOM_CLIENTE") = dr.Cells("NOM_CLIENTE").EditedFormattedValue
                            Rowsur.Item("DISTRITO") = dr.Cells("DISTRITO").EditedFormattedValue
                            Rowsur.Item("DIRECCION_ENTREGA") = dr.Cells("DIRECCION_ENTREGA").EditedFormattedValue
                            Rowsur.Item("CANAL") = dr.Cells("CANAL").EditedFormattedValue
                            Rowsur.Item("RESTRICCION") = dr.Cells("RESTRICCION").EditedFormattedValue
                            Rowsur.Item("TOTALIMPORTE") = dr.Cells("TOTALIMPORTE").EditedFormattedValue
                            Rowsur.Item("CANTIDADGUIAS") = dr.Cells("CANTIDADGUIAS").EditedFormattedValue
                            Rowsur.Item("TIEMPOENTREGA") = dr.Cells("TIEMPOENTREGA").EditedFormattedValue
                            Rowsur.Item("TOTALMETROSCUBICOS") = dr.Cells("TOTALMETROSCUBICOS").EditedFormattedValue
                            Rowsur.Item("COMENTARIO") = dr.Cells("COMENTARIO").EditedFormattedValue
                            dtcentro.Rows.Add(Rowsur)
                            DG_SUR.Rows.RemoveAt(dr.Index)
                        End If

                        If destino = "OESTE" Then
                            Dim Rowsur As DataRow = dtoeste.NewRow
                            Rowsur.Item("RUTA") = dr.Cells("RUTA").EditedFormattedValue
                            Rowsur.Item("DETALLE") = dr.Cells("DETALLE").EditedFormattedValue
                            Rowsur.Item("NOM_CLIENTE") = dr.Cells("NOM_CLIENTE").EditedFormattedValue
                            Rowsur.Item("DISTRITO") = dr.Cells("DISTRITO").EditedFormattedValue
                            Rowsur.Item("DIRECCION_ENTREGA") = dr.Cells("DIRECCION_ENTREGA").EditedFormattedValue
                            Rowsur.Item("CANAL") = dr.Cells("CANAL").EditedFormattedValue
                            Rowsur.Item("RESTRICCION") = dr.Cells("RESTRICCION").EditedFormattedValue
                            Rowsur.Item("TOTALIMPORTE") = dr.Cells("TOTALIMPORTE").EditedFormattedValue
                            Rowsur.Item("CANTIDADGUIAS") = dr.Cells("CANTIDADGUIAS").EditedFormattedValue
                            Rowsur.Item("TIEMPOENTREGA") = dr.Cells("TIEMPOENTREGA").EditedFormattedValue
                            Rowsur.Item("TOTALMETROSCUBICOS") = dr.Cells("TOTALMETROSCUBICOS").EditedFormattedValue
                            Rowsur.Item("COMENTARIO") = dr.Cells("COMENTARIO").EditedFormattedValue
                            dtoeste.Rows.Add(Rowsur)
                            DG_SUR.Rows.RemoveAt(dr.Index)
                        End If

                        If destino = "OESTE1" Then
                            Dim Rowsur As DataRow = dtoeste1.NewRow
                            Rowsur.Item("RUTA") = dr.Cells("RUTA").EditedFormattedValue
                            Rowsur.Item("DETALLE") = dr.Cells("DETALLE").EditedFormattedValue
                            Rowsur.Item("NOM_CLIENTE") = dr.Cells("NOM_CLIENTE").EditedFormattedValue
                            Rowsur.Item("DISTRITO") = dr.Cells("DISTRITO").EditedFormattedValue
                            Rowsur.Item("DIRECCION_ENTREGA") = dr.Cells("DIRECCION_ENTREGA").EditedFormattedValue
                            Rowsur.Item("CANAL") = dr.Cells("CANAL").EditedFormattedValue
                            Rowsur.Item("RESTRICCION") = dr.Cells("RESTRICCION").EditedFormattedValue
                            Rowsur.Item("TOTALIMPORTE") = dr.Cells("TOTALIMPORTE").EditedFormattedValue
                            Rowsur.Item("CANTIDADGUIAS") = dr.Cells("CANTIDADGUIAS").EditedFormattedValue
                            Rowsur.Item("TIEMPOENTREGA") = dr.Cells("TIEMPOENTREGA").EditedFormattedValue
                            Rowsur.Item("TOTALMETROSCUBICOS") = dr.Cells("TOTALMETROSCUBICOS").EditedFormattedValue
                            Rowsur.Item("COMENTARIO") = dr.Cells("COMENTARIO").EditedFormattedValue
                            dtoeste1.Rows.Add(Rowsur)
                            DG_SUR.Rows.RemoveAt(dr.Index)
                        End If

                    End If
                Next
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_moverCentro_Click(sender As Object, e As EventArgs) Handles btn_moverCentro.Click
        Try
            Dim SelecFrom As New SelectDestinoRuta
            Dim destino As String
            SelecFrom.Origen = "CENTRO"
            SelecFrom.ShowDialog()
            If SelecFrom.grabado = True Then
                destino = SelecFrom.Destino
                For Each dr As DataGridViewRow In DG_CENTRO.Rows
                    If dr.Selected = True Then
                        If destino = "NORTE" Then
                            Dim Rowsur As DataRow = dtnorte.NewRow
                            Rowsur.Item("RUTA") = dr.Cells("RUTA").EditedFormattedValue
                            Rowsur.Item("DETALLE") = dr.Cells("DETALLE").EditedFormattedValue
                            Rowsur.Item("NOM_CLIENTE") = dr.Cells("NOM_CLIENTE").EditedFormattedValue
                            Rowsur.Item("DISTRITO") = dr.Cells("DISTRITO").EditedFormattedValue
                            Rowsur.Item("DIRECCION_ENTREGA") = dr.Cells("DIRECCION_ENTREGA").EditedFormattedValue
                            Rowsur.Item("CANAL") = dr.Cells("CANAL").EditedFormattedValue
                            Rowsur.Item("RESTRICCION") = dr.Cells("RESTRICCION").EditedFormattedValue
                            Rowsur.Item("TOTALIMPORTE") = dr.Cells("TOTALIMPORTE").EditedFormattedValue
                            Rowsur.Item("CANTIDADGUIAS") = dr.Cells("CANTIDADGUIAS").EditedFormattedValue
                            Rowsur.Item("TIEMPOENTREGA") = dr.Cells("TIEMPOENTREGA").EditedFormattedValue
                            Rowsur.Item("TOTALMETROSCUBICOS") = dr.Cells("TOTALMETROSCUBICOS").EditedFormattedValue
                            Rowsur.Item("COMENTARIO") = dr.Cells("COMENTARIO").EditedFormattedValue
                            dtnorte.Rows.Add(Rowsur)
                            DG_CENTRO.Rows.RemoveAt(dr.Index)
                        End If
                        If destino = "SUR" Then
                            Dim Rowsur As DataRow = dtsur.NewRow
                            Rowsur.Item("RUTA") = dr.Cells("RUTA").EditedFormattedValue
                            Rowsur.Item("DETALLE") = dr.Cells("DETALLE").EditedFormattedValue
                            Rowsur.Item("NOM_CLIENTE") = dr.Cells("NOM_CLIENTE").EditedFormattedValue
                            Rowsur.Item("DISTRITO") = dr.Cells("DISTRITO").EditedFormattedValue
                            Rowsur.Item("DIRECCION_ENTREGA") = dr.Cells("DIRECCION_ENTREGA").EditedFormattedValue
                            Rowsur.Item("CANAL") = dr.Cells("CANAL").EditedFormattedValue
                            Rowsur.Item("RESTRICCION") = dr.Cells("RESTRICCION").EditedFormattedValue
                            Rowsur.Item("TOTALIMPORTE") = dr.Cells("TOTALIMPORTE").EditedFormattedValue
                            Rowsur.Item("CANTIDADGUIAS") = dr.Cells("CANTIDADGUIAS").EditedFormattedValue
                            Rowsur.Item("TIEMPOENTREGA") = dr.Cells("TIEMPOENTREGA").EditedFormattedValue
                            Rowsur.Item("TOTALMETROSCUBICOS") = dr.Cells("TOTALMETROSCUBICOS").EditedFormattedValue
                            Rowsur.Item("COMENTARIO") = dr.Cells("COMENTARIO").EditedFormattedValue
                            dtsur.Rows.Add(Rowsur)
                            DG_CENTRO.Rows.RemoveAt(dr.Index)
                        End If

                        If destino = "OESTE" Then
                            Dim Rowsur As DataRow = dtoeste.NewRow
                            Rowsur.Item("RUTA") = dr.Cells("RUTA").EditedFormattedValue
                            Rowsur.Item("DETALLE") = dr.Cells("DETALLE").EditedFormattedValue
                            Rowsur.Item("NOM_CLIENTE") = dr.Cells("NOM_CLIENTE").EditedFormattedValue
                            Rowsur.Item("DISTRITO") = dr.Cells("DISTRITO").EditedFormattedValue
                            Rowsur.Item("DIRECCION_ENTREGA") = dr.Cells("DIRECCION_ENTREGA").EditedFormattedValue
                            Rowsur.Item("CANAL") = dr.Cells("CANAL").EditedFormattedValue
                            Rowsur.Item("RESTRICCION") = dr.Cells("RESTRICCION").EditedFormattedValue
                            Rowsur.Item("TOTALIMPORTE") = dr.Cells("TOTALIMPORTE").EditedFormattedValue
                            Rowsur.Item("CANTIDADGUIAS") = dr.Cells("CANTIDADGUIAS").EditedFormattedValue
                            Rowsur.Item("TIEMPOENTREGA") = dr.Cells("TIEMPOENTREGA").EditedFormattedValue
                            Rowsur.Item("TOTALMETROSCUBICOS") = dr.Cells("TOTALMETROSCUBICOS").EditedFormattedValue
                            Rowsur.Item("COMENTARIO") = dr.Cells("COMENTARIO").EditedFormattedValue
                            dtoeste.Rows.Add(Rowsur)
                            DG_CENTRO.Rows.RemoveAt(dr.Index)
                        End If

                        If destino = "OESTE1" Then
                            Dim Rowsur As DataRow = dtoeste1.NewRow
                            Rowsur.Item("RUTA") = dr.Cells("RUTA").EditedFormattedValue
                            Rowsur.Item("DETALLE") = dr.Cells("DETALLE").EditedFormattedValue
                            Rowsur.Item("NOM_CLIENTE") = dr.Cells("NOM_CLIENTE").EditedFormattedValue
                            Rowsur.Item("DISTRITO") = dr.Cells("DISTRITO").EditedFormattedValue
                            Rowsur.Item("DIRECCION_ENTREGA") = dr.Cells("DIRECCION_ENTREGA").EditedFormattedValue
                            Rowsur.Item("CANAL") = dr.Cells("CANAL").EditedFormattedValue
                            Rowsur.Item("RESTRICCION") = dr.Cells("RESTRICCION").EditedFormattedValue
                            Rowsur.Item("TOTALIMPORTE") = dr.Cells("TOTALIMPORTE").EditedFormattedValue
                            Rowsur.Item("CANTIDADGUIAS") = dr.Cells("CANTIDADGUIAS").EditedFormattedValue
                            Rowsur.Item("TIEMPOENTREGA") = dr.Cells("TIEMPOENTREGA").EditedFormattedValue
                            Rowsur.Item("TOTALMETROSCUBICOS") = dr.Cells("TOTALMETROSCUBICOS").EditedFormattedValue
                            Rowsur.Item("COMENTARIO") = dr.Cells("COMENTARIO").EditedFormattedValue
                            dtoeste1.Rows.Add(Rowsur)
                            DG_CENTRO.Rows.RemoveAt(dr.Index)
                        End If

                    End If
                Next
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_moverOeste_Click(sender As Object, e As EventArgs) Handles btn_moverOeste.Click
        Try
            Dim SelecFrom As New SelectDestinoRuta
            Dim destino As String
            SelecFrom.Origen = "OESTE"
            SelecFrom.ShowDialog()
            If SelecFrom.grabado = True Then
                destino = SelecFrom.Destino
                For Each dr As DataGridViewRow In DG_OESTE.Rows
                    If dr.Selected = True Then
                        If destino = "NORTE" Then
                            Dim Rowsur As DataRow = dtnorte.NewRow
                            Rowsur.Item("RUTA") = dr.Cells("RUTA").EditedFormattedValue
                            Rowsur.Item("DETALLE") = dr.Cells("DETALLE").EditedFormattedValue
                            Rowsur.Item("NOM_CLIENTE") = dr.Cells("NOM_CLIENTE").EditedFormattedValue
                            Rowsur.Item("DISTRITO") = dr.Cells("DISTRITO").EditedFormattedValue
                            Rowsur.Item("DIRECCION_ENTREGA") = dr.Cells("DIRECCION_ENTREGA").EditedFormattedValue
                            Rowsur.Item("CANAL") = dr.Cells("CANAL").EditedFormattedValue
                            Rowsur.Item("RESTRICCION") = dr.Cells("RESTRICCION").EditedFormattedValue
                            Rowsur.Item("TOTALIMPORTE") = dr.Cells("TOTALIMPORTE").EditedFormattedValue
                            Rowsur.Item("CANTIDADGUIAS") = dr.Cells("CANTIDADGUIAS").EditedFormattedValue
                            Rowsur.Item("TIEMPOENTREGA") = dr.Cells("TIEMPOENTREGA").EditedFormattedValue
                            Rowsur.Item("TOTALMETROSCUBICOS") = dr.Cells("TOTALMETROSCUBICOS").EditedFormattedValue
                            Rowsur.Item("COMENTARIO") = dr.Cells("COMENTARIO").EditedFormattedValue
                            dtnorte.Rows.Add(Rowsur)
                            DG_OESTE.Rows.RemoveAt(dr.Index)
                        End If
                        If destino = "SUR" Then
                            Dim Rowsur As DataRow = dtsur.NewRow
                            Rowsur.Item("RUTA") = dr.Cells("RUTA").EditedFormattedValue
                            Rowsur.Item("DETALLE") = dr.Cells("DETALLE").EditedFormattedValue
                            Rowsur.Item("NOM_CLIENTE") = dr.Cells("NOM_CLIENTE").EditedFormattedValue
                            Rowsur.Item("DISTRITO") = dr.Cells("DISTRITO").EditedFormattedValue
                            Rowsur.Item("DIRECCION_ENTREGA") = dr.Cells("DIRECCION_ENTREGA").EditedFormattedValue
                            Rowsur.Item("CANAL") = dr.Cells("CANAL").EditedFormattedValue
                            Rowsur.Item("RESTRICCION") = dr.Cells("RESTRICCION").EditedFormattedValue
                            Rowsur.Item("TOTALIMPORTE") = dr.Cells("TOTALIMPORTE").EditedFormattedValue
                            Rowsur.Item("CANTIDADGUIAS") = dr.Cells("CANTIDADGUIAS").EditedFormattedValue
                            Rowsur.Item("TIEMPOENTREGA") = dr.Cells("TIEMPOENTREGA").EditedFormattedValue
                            Rowsur.Item("TOTALMETROSCUBICOS") = dr.Cells("TOTALMETROSCUBICOS").EditedFormattedValue
                            Rowsur.Item("COMENTARIO") = dr.Cells("COMENTARIO").EditedFormattedValue
                            dtsur.Rows.Add(Rowsur)
                            DG_OESTE.Rows.RemoveAt(dr.Index)
                        End If

                        If destino = "CENTRO" Then
                            Dim Rowsur As DataRow = dtcentro.NewRow
                            Rowsur.Item("RUTA") = dr.Cells("RUTA").EditedFormattedValue
                            Rowsur.Item("DETALLE") = dr.Cells("DETALLE").EditedFormattedValue
                            Rowsur.Item("NOM_CLIENTE") = dr.Cells("NOM_CLIENTE").EditedFormattedValue
                            Rowsur.Item("DISTRITO") = dr.Cells("DISTRITO").EditedFormattedValue
                            Rowsur.Item("DIRECCION_ENTREGA") = dr.Cells("DIRECCION_ENTREGA").EditedFormattedValue
                            Rowsur.Item("CANAL") = dr.Cells("CANAL").EditedFormattedValue
                            Rowsur.Item("RESTRICCION") = dr.Cells("RESTRICCION").EditedFormattedValue
                            Rowsur.Item("TOTALIMPORTE") = dr.Cells("TOTALIMPORTE").EditedFormattedValue
                            Rowsur.Item("CANTIDADGUIAS") = dr.Cells("CANTIDADGUIAS").EditedFormattedValue
                            Rowsur.Item("TIEMPOENTREGA") = dr.Cells("TIEMPOENTREGA").EditedFormattedValue
                            Rowsur.Item("TOTALMETROSCUBICOS") = dr.Cells("TOTALMETROSCUBICOS").EditedFormattedValue
                            Rowsur.Item("COMENTARIO") = dr.Cells("COMENTARIO").EditedFormattedValue
                            dtcentro.Rows.Add(Rowsur)
                            DG_OESTE.Rows.RemoveAt(dr.Index)
                        End If

                        If destino = "OESTE1" Then
                            Dim Rowsur As DataRow = dtoeste1.NewRow
                            Rowsur.Item("RUTA") = dr.Cells("RUTA").EditedFormattedValue
                            Rowsur.Item("DETALLE") = dr.Cells("DETALLE").EditedFormattedValue
                            Rowsur.Item("NOM_CLIENTE") = dr.Cells("NOM_CLIENTE").EditedFormattedValue
                            Rowsur.Item("DISTRITO") = dr.Cells("DISTRITO").EditedFormattedValue
                            Rowsur.Item("DIRECCION_ENTREGA") = dr.Cells("DIRECCION_ENTREGA").EditedFormattedValue
                            Rowsur.Item("CANAL") = dr.Cells("CANAL").EditedFormattedValue
                            Rowsur.Item("RESTRICCION") = dr.Cells("RESTRICCION").EditedFormattedValue
                            Rowsur.Item("TOTALIMPORTE") = dr.Cells("TOTALIMPORTE").EditedFormattedValue
                            Rowsur.Item("CANTIDADGUIAS") = dr.Cells("CANTIDADGUIAS").EditedFormattedValue
                            Rowsur.Item("TIEMPOENTREGA") = dr.Cells("TIEMPOENTREGA").EditedFormattedValue
                            Rowsur.Item("TOTALMETROSCUBICOS") = dr.Cells("TOTALMETROSCUBICOS").EditedFormattedValue
                            Rowsur.Item("COMENTARIO") = dr.Cells("COMENTARIO").EditedFormattedValue
                            dtoeste1.Rows.Add(Rowsur)
                            DG_OESTE.Rows.RemoveAt(dr.Index)
                        End If

                    End If
                Next
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_moverOeste1_Click(sender As Object, e As EventArgs) Handles btn_moverOeste1.Click
        Try
            Dim SelecFrom As New SelectDestinoRuta
            Dim destino As String
            SelecFrom.Origen = "OESTE1"
            SelecFrom.ShowDialog()
            If SelecFrom.grabado = True Then
                destino = SelecFrom.Destino
                For Each dr As DataGridViewRow In DG_OESTE1.Rows
                    If dr.Selected = True Then
                        If destino = "NORTE" Then
                            Dim Rowsur As DataRow = dtnorte.NewRow
                            Rowsur.Item("RUTA") = dr.Cells("RUTA").EditedFormattedValue
                            Rowsur.Item("DETALLE") = dr.Cells("DETALLE").EditedFormattedValue
                            Rowsur.Item("NOM_CLIENTE") = dr.Cells("NOM_CLIENTE").EditedFormattedValue
                            Rowsur.Item("DISTRITO") = dr.Cells("DISTRITO").EditedFormattedValue
                            Rowsur.Item("DIRECCION_ENTREGA") = dr.Cells("DIRECCION_ENTREGA").EditedFormattedValue
                            Rowsur.Item("CANAL") = dr.Cells("CANAL").EditedFormattedValue
                            Rowsur.Item("RESTRICCION") = dr.Cells("RESTRICCION").EditedFormattedValue
                            Rowsur.Item("TOTALIMPORTE") = dr.Cells("TOTALIMPORTE").EditedFormattedValue
                            Rowsur.Item("CANTIDADGUIAS") = dr.Cells("CANTIDADGUIAS").EditedFormattedValue
                            Rowsur.Item("TIEMPOENTREGA") = dr.Cells("TIEMPOENTREGA").EditedFormattedValue
                            Rowsur.Item("TOTALMETROSCUBICOS") = dr.Cells("TOTALMETROSCUBICOS").EditedFormattedValue
                            Rowsur.Item("COMENTARIO") = dr.Cells("COMENTARIO").EditedFormattedValue
                            dtnorte.Rows.Add(Rowsur)
                            DG_OESTE1.Rows.RemoveAt(dr.Index)
                        End If
                        If destino = "SUR" Then
                            Dim Rowsur As DataRow = dtsur.NewRow
                            Rowsur.Item("RUTA") = dr.Cells("RUTA").EditedFormattedValue
                            Rowsur.Item("DETALLE") = dr.Cells("DETALLE").EditedFormattedValue
                            Rowsur.Item("NOM_CLIENTE") = dr.Cells("NOM_CLIENTE").EditedFormattedValue
                            Rowsur.Item("DISTRITO") = dr.Cells("DISTRITO").EditedFormattedValue
                            Rowsur.Item("DIRECCION_ENTREGA") = dr.Cells("DIRECCION_ENTREGA").EditedFormattedValue
                            Rowsur.Item("CANAL") = dr.Cells("CANAL").EditedFormattedValue
                            Rowsur.Item("RESTRICCION") = dr.Cells("RESTRICCION").EditedFormattedValue
                            Rowsur.Item("TOTALIMPORTE") = dr.Cells("TOTALIMPORTE").EditedFormattedValue
                            Rowsur.Item("CANTIDADGUIAS") = dr.Cells("CANTIDADGUIAS").EditedFormattedValue
                            Rowsur.Item("TIEMPOENTREGA") = dr.Cells("TIEMPOENTREGA").EditedFormattedValue
                            Rowsur.Item("TOTALMETROSCUBICOS") = dr.Cells("TOTALMETROSCUBICOS").EditedFormattedValue
                            Rowsur.Item("COMENTARIO") = dr.Cells("COMENTARIO").EditedFormattedValue
                            dtsur.Rows.Add(Rowsur)
                            DG_OESTE1.Rows.RemoveAt(dr.Index)
                        End If

                        If destino = "CENTRO" Then
                            Dim Rowsur As DataRow = dtcentro.NewRow
                            Rowsur.Item("RUTA") = dr.Cells("RUTA").EditedFormattedValue
                            Rowsur.Item("DETALLE") = dr.Cells("DETALLE").EditedFormattedValue
                            Rowsur.Item("NOM_CLIENTE") = dr.Cells("NOM_CLIENTE").EditedFormattedValue
                            Rowsur.Item("DISTRITO") = dr.Cells("DISTRITO").EditedFormattedValue
                            Rowsur.Item("DIRECCION_ENTREGA") = dr.Cells("DIRECCION_ENTREGA").EditedFormattedValue
                            Rowsur.Item("CANAL") = dr.Cells("CANAL").EditedFormattedValue
                            Rowsur.Item("RESTRICCION") = dr.Cells("RESTRICCION").EditedFormattedValue
                            Rowsur.Item("TOTALIMPORTE") = dr.Cells("TOTALIMPORTE").EditedFormattedValue
                            Rowsur.Item("CANTIDADGUIAS") = dr.Cells("CANTIDADGUIAS").EditedFormattedValue
                            Rowsur.Item("TIEMPOENTREGA") = dr.Cells("TIEMPOENTREGA").EditedFormattedValue
                            Rowsur.Item("TOTALMETROSCUBICOS") = dr.Cells("TOTALMETROSCUBICOS").EditedFormattedValue
                            Rowsur.Item("COMENTARIO") = dr.Cells("COMENTARIO").EditedFormattedValue
                            dtcentro.Rows.Add(Rowsur)
                            DG_OESTE1.Rows.RemoveAt(dr.Index)
                        End If

                        If destino = "OESTE" Then
                            Dim Rowsur As DataRow = dtoeste.NewRow
                            Rowsur.Item("RUTA") = dr.Cells("RUTA").EditedFormattedValue
                            Rowsur.Item("DETALLE") = dr.Cells("DETALLE").EditedFormattedValue
                            Rowsur.Item("NOM_CLIENTE") = dr.Cells("NOM_CLIENTE").EditedFormattedValue
                            Rowsur.Item("DISTRITO") = dr.Cells("DISTRITO").EditedFormattedValue
                            Rowsur.Item("DIRECCION_ENTREGA") = dr.Cells("DIRECCION_ENTREGA").EditedFormattedValue
                            Rowsur.Item("CANAL") = dr.Cells("CANAL").EditedFormattedValue
                            Rowsur.Item("RESTRICCION") = dr.Cells("RESTRICCION").EditedFormattedValue
                            Rowsur.Item("TOTALIMPORTE") = dr.Cells("TOTALIMPORTE").EditedFormattedValue
                            Rowsur.Item("CANTIDADGUIAS") = dr.Cells("CANTIDADGUIAS").EditedFormattedValue
                            Rowsur.Item("TIEMPOENTREGA") = dr.Cells("TIEMPOENTREGA").EditedFormattedValue
                            Rowsur.Item("TOTALMETROSCUBICOS") = dr.Cells("TOTALMETROSCUBICOS").EditedFormattedValue
                            Rowsur.Item("COMENTARIO") = dr.Cells("COMENTARIO").EditedFormattedValue
                            dtoeste.Rows.Add(Rowsur)
                            DG_OESTE1.Rows.RemoveAt(dr.Index)
                        End If

                    End If
                Next
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Dg_NORTE_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Dg_NORTE.DragEnter
        e.Effect = DragDropEffects.Move
    End Sub

    Private Sub Ruta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Rutas LIMA & PROVINCIA"
        'If dtruta.Rows.Count > 0 Then
        '    Dg_Ruta.DataSource = dtruta
        'End If

        If dtcentro.Rows.Count > 0 Then
            btn_moverCentro.Visible = True
            DG_CENTRO.Visible = True
            DG_CENTRO.DataSource = dtcentro
        End If

        If dtoeste.Rows.Count > 0 Then
            btn_moverOeste.Visible = True
            DG_OESTE.Visible = True
            DG_OESTE.DataSource = dtoeste
        End If

        If dtsur.Rows.Count > 0 Then
            btn_moverSur.Visible = True
            DG_SUR.Visible = True
            DG_SUR.DataSource = dtsur
        End If

        If dtnorte.Rows.Count > 0 Then
            Dg_NORTE.Visible = True
            btn_moverNorte.Visible = True
            Dg_NORTE.DataSource = dtnorte

        End If

        If dtoeste1.Rows.Count > 0 Then
            btn_moverOeste1.Visible = True
            DG_OESTE1.Visible = True
            DG_OESTE1.DataSource = dtoeste1

        End If


    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub DataGridView4_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
End Class