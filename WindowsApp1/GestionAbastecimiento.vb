Public Class GestionAbastecimiento
    Public usr_id As Integer
    Public usr_usuario As String

    Private AlmacenObj As New AlmacenL

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CargaInicial()

    End Sub

    Private Sub GestionAbastecimiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CargaInicial()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnBuscar_Click_1(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim Dt_Almacen As New DataTable
        Try
            ListarGuiasCabecera()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function LlamarArticulosAbastencer() As DataTable
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
        Dim dtretono As DataTable
        Try
            dtretono = AlmacenObj.ObtenerArticulosAbastercer(fechadesde, fechahasta).Copy
        Catch ex As Exception
            Throw ex
        End Try
        Return dtretono
    End Function

    Public Sub ListarGuiasCabecera()
        Try
            Dim dtretorno As New DataTable
            dtretorno = LlamarArticulosAbastencer()
            If dtretorno.Rows.Count > 0 Then
                Dim contador As Integer = 0
                For Each RowRetorno As DataRow In dtretorno.Rows

                    If (CType(RowRetorno.Item("ENERO").ToString.Trim, Integer) + CType(RowRetorno.Item("FEBRERO").ToString.Trim, Integer) + CType(RowRetorno.Item("MARZO").ToString.Trim, Integer) + CType(RowRetorno.Item("ABRIL").ToString.Trim, Integer) +
                        CType(RowRetorno.Item("MAYO").ToString.Trim, Integer) + CType(RowRetorno.Item("JUNIO").ToString.Trim, Integer) + CType(RowRetorno.Item("JULIO").ToString.Trim, Integer) + CType(RowRetorno.Item("AGOSTO").ToString.Trim, Integer) +
                        CType(RowRetorno.Item("SETIEMBRE").ToString.Trim, Integer) + CType(RowRetorno.Item("OCTUBRE").ToString.Trim, Integer) + CType(RowRetorno.Item("NOVIEMBRE").ToString.Trim, Integer) + CType(RowRetorno.Item("DICIEMBRE").ToString.Trim, Integer)) > 0 Then

                        Dg_Cabecera.Rows.Add()
                        Dg_Cabecera.Rows(contador).Cells("CODIGO").Value = RowRetorno.Item("CODIGO").ToString.Trim
                        Dg_Cabecera.Rows(contador).Cells("TIPOORIGEN").Value = RowRetorno.Item("TIPO ORIGEN").ToString.Trim
                        Dg_Cabecera.Rows(contador).Cells("ARTICULO").Value = RowRetorno.Item("ARTICULO").ToString.Trim

                        If RowRetorno.Item("CODIGO").ToString.Trim = "PCD0001539".Trim Then
                            ''hola
                            Dim CONTADO As Integer = 0
                            CONTADO = 1
                        End If

                        Dg_Cabecera.Rows(contador).Cells("UUCAJA").Value = RowRetorno.Item("UU CAJA").ToString
                        If CType(Dg_Cabecera.Rows(contador).Cells("UUCAJA").Value, Integer) = 0 Then
                            Dg_Cabecera.Rows(contador).Cells("UUCAJA").Value = 1
                        End If
                        Dg_Cabecera.Rows(contador).Cells("CAJASCM").Value = RowRetorno.Item("CAJA CM").ToString.Trim

                        If Dg_Cabecera.Rows(contador).Cells("CAJASCM").Value = "" Then
                            Dg_Cabecera.Rows(contador).Cells("CAJASCM").Value = 1
                        Else
                            If CType(Dg_Cabecera.Rows(contador).Cells("CAJASCM").Value, Integer) = 0 Then
                                Dg_Cabecera.Rows(contador).Cells("CAJASCM").Value = 1
                            End If
                        End If


                        Dg_Cabecera.Rows(contador).Cells("ANCHO").Value = Math.Round(CType(RowRetorno.Item("AR_NANCHO").ToString, Decimal), 2)
                        If Dg_Cabecera.Rows(contador).Cells("ANCHO").Value = 0 Then
                            Dg_Cabecera.Rows(contador).Cells("ANCHO").Value = 0.35
                        End If

                        Dg_Cabecera.Rows(contador).Cells("LARGO").Value = Math.Round(CType(RowRetorno.Item("AR_NLARGO").ToString, Decimal), 2)
                        If Dg_Cabecera.Rows(contador).Cells("LARGO").Value = 0 Then
                            Dg_Cabecera.Rows(contador).Cells("LARGO").Value = 0.35
                        End If

                        If RowRetorno.Item("AR_CTALLA").ToString.Trim = "" Then
                            Dg_Cabecera.Rows(contador).Cells("ALTO").Value = 0.35
                        Else
                            If CType(RowRetorno.Item("AR_CTALLA").ToString.Trim, Decimal) = 0 Then
                                Dg_Cabecera.Rows(contador).Cells("ALTO").Value = 0.35
                            Else
                                Dg_Cabecera.Rows(contador).Cells("ALTO").Value = RowRetorno.Item("AR_CTALLA").ToString.Trim
                            End If
                        End If

                        Dg_Cabecera.Rows(contador).Cells("ENERO").Value = RowRetorno.Item("ENERO").ToString
                        If CType(Dg_Cabecera.Rows(contador).Cells("ENERO").Value, Integer) < 0 Then
                            Dg_Cabecera.Rows(contador).Cells("ENERO").Value = 0
                        End If
                        Dg_Cabecera.Rows(contador).Cells("FEBRERO").Value = RowRetorno.Item("FEBRERO").ToString
                        If CType(Dg_Cabecera.Rows(contador).Cells("FEBRERO").Value, Integer) < 0 Then
                            Dg_Cabecera.Rows(contador).Cells("FEBRERO").Value = 0
                        End If
                        Dg_Cabecera.Rows(contador).Cells("MARZO").Value = RowRetorno.Item("MARZO").ToString
                        If CType(Dg_Cabecera.Rows(contador).Cells("MARZO").Value, Integer) < 0 Then
                            Dg_Cabecera.Rows(contador).Cells("MARZO").Value = 0
                        End If
                        Dg_Cabecera.Rows(contador).Cells("ABRIL").Value = RowRetorno.Item("ABRIL").ToString
                        If CType(Dg_Cabecera.Rows(contador).Cells("ABRIL").Value, Integer) < 0 Then
                            Dg_Cabecera.Rows(contador).Cells("ABRIL").Value = 0
                        End If
                        Dg_Cabecera.Rows(contador).Cells("MAYO").Value = RowRetorno.Item("MAYO").ToString
                        If CType(Dg_Cabecera.Rows(contador).Cells("MAYO").Value, Integer) < 0 Then
                            Dg_Cabecera.Rows(contador).Cells("MAYO").Value = 0
                        End If
                        Dg_Cabecera.Rows(contador).Cells("JUNIO").Value = RowRetorno.Item("JUNIO").ToString
                        If CType(Dg_Cabecera.Rows(contador).Cells("JUNIO").Value, Integer) < 0 Then
                            Dg_Cabecera.Rows(contador).Cells("JUNIO").Value = 0
                        End If
                        Dg_Cabecera.Rows(contador).Cells("JULIO").Value = RowRetorno.Item("JULIO").ToString
                        If CType(Dg_Cabecera.Rows(contador).Cells("JULIO").Value, Integer) < 0 Then
                            Dg_Cabecera.Rows(contador).Cells("JULIO").Value = 0
                        End If
                        Dg_Cabecera.Rows(contador).Cells("AGOSTO").Value = RowRetorno.Item("AGOSTO").ToString
                        If CType(Dg_Cabecera.Rows(contador).Cells("AGOSTO").Value, Integer) < 0 Then
                            Dg_Cabecera.Rows(contador).Cells("AGOSTO").Value = 0
                        End If
                        Dg_Cabecera.Rows(contador).Cells("SETIEMBRE").Value = RowRetorno.Item("SETIEMBRE").ToString
                        If CType(Dg_Cabecera.Rows(contador).Cells("SETIEMBRE").Value, Integer) < 0 Then
                            Dg_Cabecera.Rows(contador).Cells("SETIEMBRE").Value = 0
                        End If
                        Dg_Cabecera.Rows(contador).Cells("OCTUBRE").Value = RowRetorno.Item("OCTUBRE").ToString
                        If CType(Dg_Cabecera.Rows(contador).Cells("OCTUBRE").Value, Integer) < 0 Then
                            Dg_Cabecera.Rows(contador).Cells("OCTUBRE").Value = 0
                        End If
                        Dg_Cabecera.Rows(contador).Cells("NOVIEMBRE").Value = RowRetorno.Item("NOVIEMBRE").ToString
                        If CType(Dg_Cabecera.Rows(contador).Cells("NOVIEMBRE").Value, Integer) < 0 Then
                            Dg_Cabecera.Rows(contador).Cells("NOVIEMBRE").Value = 0
                        End If
                        Dg_Cabecera.Rows(contador).Cells("DICIEMBRE").Value = RowRetorno.Item("DICIEMBRE").ToString
                        If CType(Dg_Cabecera.Rows(contador).Cells("DICIEMBRE").Value, Integer) < 0 Then
                            Dg_Cabecera.Rows(contador).Cells("DICIEMBRE").Value = 0
                        End If

                        Dim suma As Integer = 0

                        suma = CType(Dg_Cabecera.Rows(contador).Cells("ENERO").Value, Integer) + CType(Dg_Cabecera.Rows(contador).Cells("FEBRERO").Value, Integer) + CType(Dg_Cabecera.Rows(contador).Cells("MARZO").Value, Integer) + CType(Dg_Cabecera.Rows(contador).Cells("ABRIL").Value, Integer) +
                            CType(Dg_Cabecera.Rows(contador).Cells("MAYO").Value, Integer) + CType(Dg_Cabecera.Rows(contador).Cells("JUNIO").Value, Integer) + CType(Dg_Cabecera.Rows(contador).Cells("JULIO").Value, Integer) + CType(Dg_Cabecera.Rows(contador).Cells("AGOSTO").Value, Integer) + CType(Dg_Cabecera.Rows(contador).Cells("SETIEMBRE").Value, Integer) +
                            CType(Dg_Cabecera.Rows(contador).Cells("OCTUBRE").Value, Integer) + CType(Dg_Cabecera.Rows(contador).Cells("NOVIEMBRE").Value, Integer) + CType(Dg_Cabecera.Rows(contador).Cells("DICIEMBRE").Value, Integer)
                        Dg_Cabecera.Rows(contador).Cells("TOTALVENTA").Value = suma

                        Dg_Cabecera.Rows(contador).Cells("VOLCJMU").Value = CType(Dg_Cabecera.Rows(contador).Cells("ANCHO").Value, Decimal) * CType(Dg_Cabecera.Rows(contador).Cells("LARGO").Value, Decimal) * CType(Dg_Cabecera.Rows(contador).Cells("ALTO").Value, Decimal)
                        Dg_Cabecera.Rows(contador).Cells("MULTIPLICACIONFACTORES").Value = CType(Dg_Cabecera.Rows(contador).Cells("UUCAJA").Value, Integer) * CType(Dg_Cabecera.Rows(contador).Cells("CAJASCM").Value, Integer)
                        Dg_Cabecera.Rows(contador).Cells("VOLUMENUNIDAD").Value = Math.Round(CType(Dg_Cabecera.Rows(contador).Cells("VOLCJMU").Value, Decimal) / CType(Dg_Cabecera.Rows(contador).Cells("MULTIPLICACIONFACTORES").Value, Integer), 7)
                        contador = contador + 1
                    End If
                Next
            End If
        Catch ex As Exception

        End Try
    End Sub

End Class