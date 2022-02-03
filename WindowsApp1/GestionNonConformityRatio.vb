Imports Nordic.Bl.Be

Public Class GestionNonConformityRatio
    Public Estructura As New EstructuraTabla
    Private ObjAlmacen As New AlmacenL

    Private Sub GestionNonConformityRatio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CargaInicial()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CargaInicial()
        Try
            cmb_tipo.SelectedIndex = 0
            'FormatoTablaCabecera()
            'ObtenerDATA()
        Catch ex As Exception

        End Try
    End Sub

    Public Sub ObtenerDATA(ByVal tipo As Integer)
        Dim contador As Integer = 0
        Try
            Dim fechadesde, fechahasta, mes, dia As String

            mes = dt_desde.Value.Month.ToString
            If mes.Length = 1 Then
                mes = "0" + mes
            End If
            dia = dt_desde.Value.Day.ToString
            If dia.Length = 1 Then
                dia = "0" + dia
            End If

            fechadesde = dia + "/" + mes + "/" + dt_desde.Value.Year.ToString


            mes = dt_hasta.Value.Month.ToString
            If mes.Length = 1 Then
                mes = "0" + mes
            End If
            dia = dt_hasta.Value.Day.ToString
            If dia.Length = 1 Then
                dia = "0" + dia
            End If

            fechahasta = dia + "/" + mes + "/" + dt_hasta.Value.Year.ToString
            Dim dt As New DataTable
            dt = ObjAlmacen.ObtenerDataNonConfirmintyRatio(fechadesde, fechahasta)
            If tipo = 1 Then
                If dt.Rows.Count > 0 Then
                    Dg_Cabecera.DataSource = dt
                    For Each row As DataRow In dt.Rows
                        If row.Item("CODIGOMOV").ToString.Trim = "24" Or row.Item("CODIGOMOV").ToString.Trim = "29" Or row.Item("CODIGOMOV").ToString.Trim = "31" Or row.Item("CODIGOMOV").ToString.Trim = "32" Then
                            contador = contador + 1
                        End If
                    Next
                    Dim indicador As Decimal
                    indicador = contador / dt.Rows.Count
                    txt_cantatiempo.Text = contador.ToString
                    txt_Cantpedidos.Text = dt.Rows.Count.ToString
                    txt_indicador.Text = CType(indicador * 100, Integer).ToString + " %"
                Else
                    Dg_Cabecera.DataSource = dt
                    txt_Cantpedidos.Text = "0"
                    txt_cantatiempo.Text = "0"
                    txt_indicador.Text = "0 %"
                End If
            Else
                If tipo = 0 Then
                    If dt.Rows.Count > 0 Then
                        Dg_Cabecera.DataSource = dt
                        For Each row As DataRow In dt.Rows
                            If row.Item("CODIGOMOV").ToString.Trim <> "" Then
                                contador = contador + 1
                            End If
                        Next
                        Dim indicador As Decimal
                        indicador = contador / dt.Rows.Count
                        txt_cantatiempo.Text = contador.ToString
                        txt_Cantpedidos.Text = dt.Rows.Count.ToString
                        txt_indicador.Text = CType(indicador * 100, Integer).ToString + " %"
                    Else
                        Dg_Cabecera.DataSource = dt
                        txt_Cantpedidos.Text = "0"
                        txt_cantatiempo.Text = "0"
                        txt_indicador.Text = "0 %"
                    End If
                End If
            End If

        Catch ex As Exception

        End Try
    End Sub

    'Public Sub OBTENERINDICADOR()
    '    Try
    '        If Dg_Cabecera.Rows.Count Then

    '        End If
    '    Catch ex As Exception

    '    End Try

    'End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        ObtenerDATA(cmb_tipo.SelectedIndex)
    End Sub

    Private Sub cmb_tipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_tipo.SelectedIndexChanged
        Try

            '  ObtenerDATA(cmb_tipo.SelectedIndex)

        Catch ex As Exception

        End Try
    End Sub
End Class