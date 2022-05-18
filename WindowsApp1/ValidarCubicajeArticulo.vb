Imports System.Text.RegularExpressions

Public Class ValidarCubicajeArticulo
    Public CodArticulo As String = "", DescripArticulo As String = ""
    Private AlmacenObj As New AlmacenL
    Public dt_Articulo As New DataTable
    Public usr_id As Integer
    Private Sub ValidarCubicajeArticulo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CargaInicial()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub CargaInicial()
        Try
            ListarArticulos()
            'If DescripArticulo <> "" Then
            '    txt_articulo.Text = DescripArticulo
            'End If
            'txt_codarticulo.Text = CodArticulo
            'ObtenerCubicaje()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click
        Try
            If ValidarAceptar() = True Then
                Dim Alto As Decimal = 0, largo As Decimal = 0, ancho As Decimal = 0, factorcji As Decimal = 0, factorcjm As Decimal = 0
                '  Dim Codarticulo As String = ""
                Alto = txt_alto.Text
                largo = txt_largo.Text
                ancho = txt_ancho.Text
                factorcji = txt_factorci.Text
                factorcjm = txt_factorcjm.Text
                'Codarticulo = txt_codarticulo.Text.Trim
                Dim rp As Integer = 0
                If CodArticulo <> "" Then
                    rp = LlamarActualizarCubicaje(CodArticulo, Alto, ancho, largo, factorcji, factorcjm)
                    If rp <> 0 Then

                        rp = LlamarSP_CSE_RegistrarValidacionArticulo(CodArticulo.Trim, usr_id)
                        If rp <> 0 Then
                            MsgBox("Cubicaje de Articulo Actualizado Correctamente", MsgBoxStyle.Information, "SISTEMAS NORDIC")
                            Me.Close()
                        End If
                    Else
                        MsgBox("Cubicaje de Articulo NO Actualizado, Contactar con el Area de Sistemas", MsgBoxStyle.Critical, "SISTEMAS NORDIC")
                    End If
                End If
            Else
                MsgBox("Existe Errores, valide e intente nuevamente", MsgBoxStyle.Exclamation, "SISTEMAS NORDIC")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Function LlamarActualizarCubicaje(codarticulo As String, alto As Decimal, ancho As Decimal, largo As Decimal, factorcji As Decimal, factorcjm As Decimal) As Integer
        Dim rp As Integer = 0
        Try
            rp = AlmacenObj.SP_CSE_ACTUALIZAR_CUBICAJE_ART(codarticulo, alto, ancho, largo, factorcji, factorcjm)
        Catch ex As Exception

        End Try
        Return rp
    End Function

    Private Function LlamarSP_CSE_RegistrarValidacionArticulo(codarticulo As String, userid As Integer) As Integer
        Dim rp As Integer = 0
        Try
            rp = AlmacenObj.SP_CSE_RegistrarValidacionArticulo(codarticulo, userid)
        Catch ex As Exception

        End Try
        Return rp
    End Function



    Public Function ValidarDecimal(Dato As String) As Boolean
        Dim retorno As Boolean = Regex.IsMatch(Dato, "^[0-9]+(\.([0-9])+)?$")
        Return retorno
    End Function

    Private Function ValidarAceptar() As Boolean
        Dim rp As Boolean = True
        Try
            ErrorProvider1.SetError(txt_alto, "")
            ErrorProvider1.SetError(txt_ancho, "")
            ErrorProvider1.SetError(txt_largo, "")
            ErrorProvider1.SetError(txt_factorci, "")
            ErrorProvider1.SetError(txt_factorcjm, "")

            If txt_alto.Text = "" Then
                ErrorProvider1.SetError(txt_alto, "Debe Ingresar Alto de Articulo")
                rp = False
            Else
                If ValidarDecimal(txt_alto.Text.ToString.Trim) = False Then
                    ErrorProvider1.SetError(txt_alto, "Alto de Articulo debe ser Numérico")
                    rp = False
                Else
                    If CType(txt_alto.Text.ToString.Trim, Decimal) <= 0 Then
                        ErrorProvider1.SetError(txt_alto, "Alto de Articulo debe ser mayor a 0")
                        rp = False
                    End If
                End If
            End If

            If txt_ancho.Text = "" Then
                ErrorProvider1.SetError(txt_ancho, "Debe Ingresar Ancho de Articulo")
                rp = False
            Else
                If ValidarDecimal(txt_ancho.Text.ToString.Trim) = False Then
                    ErrorProvider1.SetError(txt_ancho, "Ancho de Articulo debe ser Numérico")
                    rp = False
                Else
                    If CType(txt_ancho.Text.ToString.Trim, Decimal) <= 0 Then
                        ErrorProvider1.SetError(txt_ancho, "Ancho de Articulo debe ser mayor a 0")
                        rp = False
                    End If
                End If
            End If


            If txt_largo.Text = "" Then
                ErrorProvider1.SetError(txt_largo, "Debe Ingresar Largo de Articulo")
                rp = False
            Else
                If ValidarDecimal(txt_largo.Text.ToString.Trim) = False Then
                    ErrorProvider1.SetError(txt_largo, "Largo de Articulo debe ser Numérico")
                    rp = False
                Else
                    If CType(txt_largo.Text.ToString.Trim, Decimal) <= 0 Then
                        ErrorProvider1.SetError(txt_largo, "Largo de Articulo debe ser mayor a 0")
                        rp = False
                    End If
                End If
            End If


            If txt_factorci.Text = "" Then
                ErrorProvider1.SetError(txt_factorci, "Debe Ingresar Factor Caja Interna de Articulo")
                rp = False
            Else
                If ValidarDecimal(txt_factorci.Text.ToString.Trim) = False Then
                    ErrorProvider1.SetError(txt_factorci, "Factor Caja Interna de Articulo debe ser Numérico")
                    rp = False
                Else
                    If CType(txt_factorci.Text.ToString.Trim, Decimal) <= 0 Then
                        ErrorProvider1.SetError(txt_factorci, "Factor Caja Interna de Articulo debe ser mayor a 0")
                        rp = False
                    End If
                End If
            End If


            If txt_factorcjm.Text = "" Then
                ErrorProvider1.SetError(txt_factorcjm, "Debe Ingresar Factor Caja Master de Articulo")
                rp = False
            Else
                If ValidarDecimal(txt_factorcjm.Text.ToString.Trim) = False Then
                    ErrorProvider1.SetError(txt_factorcjm, "Factor Caja Master debe ser Numérico")
                    rp = False
                Else
                    If CType(txt_factorcjm.Text.ToString.Trim, Decimal) <= 0 Then
                        ErrorProvider1.SetError(txt_factorcjm, "Factor Caja Master debe ser mayor a 0")
                        rp = False
                    End If
                End If
            End If

        Catch ex As Exception

        End Try
        Return rp
    End Function

    Private Sub ListarArticulos()
        Try

            dt_Articulo = AlmacenObj.SP_LISTAR_ARTICULOS_CUBICAJE
            If dt_Articulo.Rows.Count > 0 Then
                ComboBox1.DataSource = dt_Articulo
                ComboBox1.ValueMember = "Codigo"
                ComboBox1.DisplayMember = "Codigo"
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txt_codarticulo_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txt_codarticulo_KeyUp(sender As Object, e As KeyEventArgs)
        'If txt_articulo.Text <> "" Then
        '    If e.KeyCode = Keys.Enter Then

        '    End If
        'End If
    End Sub

    'Private Sub ComboBox1_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedValueChanged
    '    Try
    '        Dim Row As DataRowView = ComboBox1.SelectedItem
    '        txt_largo.Text = CType(Row.Item("largo").ToString.Trim, Decimal) '.Replace(".", ",")
    '        txt_ancho.Text = CType(Row.Item("ancho").ToString.Trim, Decimal) '.Replace(".", ",")
    '        txt_alto.Text = CType(Row.Item("alto").ToString.Trim, Decimal) '.Replace(".", ",")
    '        txt_factorci.Text = CType(Row.Item("factorci").ToString.Trim, Decimal) '.Replace(".", ",")
    '        txt_factorcjm.Text = CType(Row.Item("factorcjm").ToString.Trim, Decimal) '.Replace(".", ",")
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Sub

    Private Sub ComboBox1_KeyUp(sender As Object, e As KeyEventArgs) Handles ComboBox1.KeyUp
        Try
            If ComboBox1.Text.ToString.Trim <> "" Then
                If e.KeyCode = Keys.Enter Then
                    Try
                        Dim Row As DataRowView = ComboBox1.SelectedItem
                        If Row IsNot Nothing Then
                            txt_largo.Text = CType(Row.Item("largo").ToString.Trim, Decimal) '.Replace(".", ",")
                            txt_ancho.Text = CType(Row.Item("ancho").ToString.Trim, Decimal) '.Replace(".", ",")
                            txt_alto.Text = CType(Row.Item("alto").ToString.Trim, Decimal) '.Replace(".", ",")
                            txt_factorci.Text = CType(Row.Item("factorci").ToString.Trim, Decimal) '.Replace(".", ",")
                            txt_factorcjm.Text = CType(Row.Item("factorcjm").ToString.Trim, Decimal) '.Replace(".", ",")
                            txt_articulo.Text = Row.Item("Descripcion").ToString.Trim
                            CodArticulo = Row.Item("Codigo").ToString.Trim
                            ObtenerCubicaje(Row.Item("Codigo").ToString.Trim)
                        End If

                    Catch ex As Exception
                        Throw ex
                    End Try
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    'Private Sub ComboBox1_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox1.SelectionChangeCommitted

    'End Sub

    Private Sub ObtenerCubicaje(Codarticulo As String)
        Try
            Dim DtValores As New DataTable
            DtValores = AlmacenObj.SP_CSE_ObtenerEstadoValidacion(Codarticulo.Trim)
            If DtValores.Rows.Count > 0 Then
                'txt_largo.Text = CType(DtValores.Rows(0).Item("largo").ToString.Trim, Decimal) '.Replace(".", ",")
                'txt_ancho.Text = CType(DtValores.Rows(0).Item("ancho").ToString.Trim, Decimal) '.Replace(".", ",")
                'txt_alto.Text = CType(DtValores.Rows(0).Item("alto").ToString.Trim, Decimal) '.Replace(".", ",")
                'txt_factorci.Text = CType(DtValores.Rows(0).Item("factorci").ToString.Trim, Decimal) '.Replace(".", ",")
                'txt_factorcjm.Text = CType(DtValores.Rows(0).Item("factorcjm").ToString.Trim, Decimal) '.Replace(".", ",")
                btn_Estado.BackColor = Color.Green
                txt_usuario.Text = DtValores.Rows(0).Item("Usuario").ToString
                txt_fechavali.Text = DtValores.Rows(0).Item("Fecha").ToString
            Else
                btn_Estado.BackColor = Color.Red
                txt_usuario.Text = "-"
                txt_fechavali.Text = "-"
            End If
        Catch ex As Exception

        End Try
    End Sub

End Class