Public Class ConversionArticulo
    Public iddetalle As Integer
    Public codigo As String = "", lote As String = "", articuloNombre As String = ""
    Public grabado As Boolean = False
    Public factor As Integer = 0
    Public cantidadAn As Integer = 0
    Public objalmacen As New AlmacenL
    Public userid As Integer = 0
    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click
        Aceptar()
    End Sub

    Public Sub Aceptar()
        Dim intCantidadNueva As Integer = 0
        Dim CantidadSalida As Integer = 0
        Try
            If factor <> 0 Then
                If ValidarAceptar() Then
                    If cmb_unidad.SelectedIndex = 0 Then
                        intCantidadNueva = CType(txt_cantidad.Text, Integer) * factor
                        CantidadSalida = CType(txt_cantidad.Text, Integer)
                    End If
                    If cmb_unidad.SelectedIndex = 1 Then
                        intCantidadNueva = CType(txt_cantidad.Text, Integer) / factor
                        CantidadSalida = CType(txt_cantidad.Text, Integer)
                    End If
                    Dim Rp As Integer = 0
                    Rp = LlamarConvertirCodigo(iddetalle, txt_nuevocodigo.Text.Trim, userid, intCantidadNueva, CantidadSalida)
                    If Rp <> 0 Then
                        MsgBox("Conversion de Codigo Correcta", MsgBoxStyle.Information, "SISTEMAS NORDIC")
                        grabado = True
                        Me.Close()
                    Else
                        MsgBox("Conversion de Codigo Erronea, Conctactar con el area de sistemas", MsgBoxStyle.Exclamation, "SISTEMAS NORDIC")
                    End If
                Else
                    MsgBox("Existen Errores, Valide e intente nuevamente", MsgBoxStyle.Exclamation, "SISTEMAS NORDIC")
                End If
            Else
                MsgBox("El factor del articulo no se recuperó", MsgBoxStyle.Critical, "SISTEMAS NORDIC")
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function LlamarConvertirCodigo(iddetalle As Integer, CodigoNuevo As String, userid As Integer, cantidadIngreso As Decimal, cantidadSalida As Decimal) As Integer
        Dim rp As Integer = 0
        Try
            rp = objalmacen.SP_CSE_ConversioCodigo(iddetalle, CodigoNuevo, userid, cantidadIngreso, cantidadSalida)
        Catch ex As Exception
            Throw ex
        End Try
        Return rp
    End Function

    Public Function ValidarAceptar() As Boolean
        Dim rp As Boolean = True
        Try
            ErrorProvider1.SetError(txt_nuevocodigo, "")
            ErrorProvider1.SetError(txt_cantidad, "")
            If txt_nuevocodigo.Text = "" Then
                ErrorProvider1.SetError(txt_nuevocodigo, "Ingrese Nuevo Codigo")
                '
                rp = False
            End If

            If txt_cantidad.Text = "" Then
                ErrorProvider1.SetError(txt_cantidad, "Ingrese Cantidad Conversion")
                rp = False
            Else
                If ValidarNumerico(txt_cantidad.Text) = False Then
                    ErrorProvider1.SetError(txt_cantidad, "Cantidad Conversion debe ser dato numerico")
                    rp = False
                Else
                    If CType(txt_cantidad.Text, Integer) <= 0 Then
                        ErrorProvider1.SetError(txt_cantidad, "Cantidad Conversion debe ser mayor a 0")
                        rp = False
                    Else
                        If CType(txt_cantidad.Text, Integer) > cantidadAn Then
                            ErrorProvider1.SetError(txt_cantidad, "Cantidad Conversion no debe superar Cantidad de Stock")
                            rp = False
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
        Return rp
    End Function

    Private Sub ConversionArticulo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cargaInicial()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function ValidarNumerico(Dato As String) As Boolean
        Dim canConvert As Boolean
        Try
            Dim convertido As Integer
            canConvert = Integer.TryParse(Dato, convertido)

        Catch ex As Exception

        End Try
        Return canConvert

    End Function
    Private Sub cargaInicial()
        Try
            If iddetalle <> 0 Then
                If codigo <> "" Then
                    cmb_unidad.SelectedIndex = 0
                    txt_codanterior.Text = codigo
                    txt_Descripcion.Text = articuloNombre
                    txt_lote.Text = lote
                    Dim dtfactor As New DataTable
                    dtfactor = objalmacen.SP_CSE_ObtenerFactorCodigo(codigo)
                    If dtfactor.Rows.Count > 0 Then
                        factor = CType(dtfactor.Rows(0).Item("AR_NFACREF").ToString.Trim, Integer)
                    End If
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class