Imports Nordic.Bl.Be


Public Class frmSeguimientoRuta

    Public usr_id As String
    Public crg_id As String



    Private Sub frmSeguimientoRuta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try


            Dim objCabRuta As New BeCabGuiaRuta
            Dim dt As New DataTable
            Dim dt1 As New DataTable

            dt1 = objCabRuta.Cabecera_por_Ruta(crg_id)

            lblNroruta.Text = dt1.Rows(0).Item("crg_id").ToString
            lblFecharuta.Text = dt1.Rows(0).Item("crg_fechaRuta").ToString
            lblTrans.Text = dt1.Rows(0).Item("tr_cnombre").ToString
            lblUsuario.Text = dt1.Rows(0).Item("usr_nombre").ToString
            lblFecregistro.Text = dt1.Rows(0).Item("fecha_hora").ToString


            dt = objCabRuta.Seguimiento_por_Ruta(crg_id)


            For i As Integer = 0 To dt.Rows.Count - 1

                'dgvSeguimientoGuiasx.Rows.Add(dt.Rows(i).Item("GUIA").ToString, dt.Rows(i).Item("CLIENTE").ToString,
                '                         dt.Rows(i).Item("DE_CDEPT").ToString, dt.Rows(i).Item("DE_CPROV").ToString,
                '                         dt.Rows(i).Item("TG_CDESCRI").ToString, dt.Rows(i).Item("C5_CDIRENV").ToString, "", dt.Rows(i).Item("ESTADO_GUIA").ToString,
                '                         dt.Rows(i).Item("MOTIVO").ToString, "", dt.Rows(i).Item("COMENTARIO").ToString, dt.Rows(i).Item("ESTADO_DESPACHO").ToString, dt.Rows(i).Item("FECHA_SALIDARUTA").ToString,
                '                         dt.Rows(i).Item("USUARIO_SALIDARUTA").ToString, dt.Rows(i).Item("FECHA_RETORNORUTA").ToString,
                '                         dt.Rows(i).Item("USUARIO_RETORNORUTA").ToString, dt.Rows(i).Item("IMAGEN1").ToString)

                dgvSeguimientoGuiasx.Rows.Add(dt.Rows(i).Item("GUIA").ToString, dt.Rows(i).Item("CLIENTE").ToString,
                          dt.Rows(i).Item("DE_CDEPT").ToString, dt.Rows(i).Item("DE_CPROV").ToString,
                          dt.Rows(i).Item("TG_CDESCRI").ToString, dt.Rows(i).Item("C5_CDIRENV").ToString, "", dt.Rows(i).Item("ESTADO_GUIA").ToString,
                          dt.Rows(i).Item("MOTIVO").ToString, "", dt.Rows(i).Item("COMENTARIO").ToString, dt.Rows(i).Item("ESTADO_DESPACHO").ToString, dt.Rows(i).Item("FECHA_SALIDARUTA").ToString,
                          dt.Rows(i).Item("USUARIO_SALIDARUTA").ToString, dt.Rows(i).Item("FECHA_TRANSPORTSITA").ToString, dt.Rows(i).Item("FECHA_RETORNORUTA").ToString,
                          dt.Rows(i).Item("USUARIO_RETORNORUTA").ToString, dt.Rows(i).Item("IMAGEN1").ToString)

            Next

            Pintar_GrillaSemaforo()
            Contabilizar_Estados()

        Catch ex As Exception

        End Try
    End Sub


    Sub Contabilizar_Estados()
        Try
            Dim contPend As Integer = 0
            Dim contEntre As Integer = 0
            Dim contRech As Integer = 0


            For i As Integer = 0 To dgvSeguimientoGuiasx.Rows.Count - 1

                If dgvSeguimientoGuiasx.Rows(i).Cells.Item("EST_CODIGO2x").Value = "PENDIENTE" Then
                    contPend = contPend + 1
                End If

                If dgvSeguimientoGuiasx.Rows(i).Cells.Item("EST_CODIGO2x").Value = "ENTREGADO" Then
                    contEntre = contEntre + 1
                End If

                If dgvSeguimientoGuiasx.Rows(i).Cells.Item("EST_CODIGO2x").Value = "RECHAZADO" Then
                    contRech = contRech + 1
                End If


            Next

            tslCantGuias.Text = dgvSeguimientoGuiasx.Rows.Count
            tslCantPend.Text = contPend.ToString
            tslCantEntregados.Text = contEntre.ToString
            tslCantRech.Text = contRech.ToString

        Catch ex As Exception

        End Try
    End Sub

    Sub Pintar_GrillaSemaforo()
        Try
            For i As Integer = 0 To dgvSeguimientoGuiasx.Rows.Count - 1


                If dgvSeguimientoGuiasx.Rows(i).Cells("EST_CODIGO2x").Value = "PENDIENTE" Then
                    dgvSeguimientoGuiasx.Rows(i).Cells("color1x").Style.BackColor = Color.Yellow
                End If

                If dgvSeguimientoGuiasx.Rows(i).Cells("EST_CODIGO2x").Value = "ENTREGADO" Then
                    dgvSeguimientoGuiasx.Rows(i).Cells("color1x").Style.BackColor = Color.Green
                End If


                If dgvSeguimientoGuiasx.Rows(i).Cells("EST_CODIGO2x").Value = "RECHAZADO" Then
                    dgvSeguimientoGuiasx.Rows(i).Cells("color1x").Style.BackColor = Color.Red
                End If


            Next

        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvSeguimientoGuiasx_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSeguimientoGuiasx.CellContentClick
        Try
            Dim ruta As String = String.Empty
            Dim file As String = String.Empty

            If e.ColumnIndex = 9 Then

                file = dgvSeguimientoGuiasx.CurrentRow.Cells.Item("ColumNomFilex").Value


                If file <> "" Then
                    ruta = "T:\" + file

                    Process.Start(ruta)
                Else
                    MessageBox.Show("No se cargo imagen para este numero de Guía", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                End If



            End If
        Catch ex As Exception

        End Try
    End Sub
End Class