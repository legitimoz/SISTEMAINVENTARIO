Imports System.Configuration
Imports System.Text.RegularExpressions

Public Class MedicionEsfuerzo
    Public datatableConsolidada As New DataTable
    Private ObjAlmacen As New AlmacenL
    Private Const PCJ As Integer = 150 '150'
    Private Const PCIU As Integer = 240 '240
    Private idalmacen As Integer = 0, idsite As Integer = 0

    Private Sub MedicionEsfuerzo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            idalmacen = CType(ConfigurationManager.AppSettings("idalmac").ToString.Trim, Integer)
            idsite = CType(ConfigurationManager.AppSettings("CodigoSite").ToString.Trim, Integer)
            CargaInicial()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub CargaInicial()
        Try
            txt_cantPersonas.Text = "3"
            If datatableConsolidada.Rows.Count > 0 Then
                Dim TotalHorasTotalHoras As Decimal = 0
                Dim contador As Integer = 0
                For Each RowConsolidado As DataRow In datatableConsolidada.Rows
                    Dim TotalMaster As Integer = 0, TotalCajasInternas As Integer = 0, TotalUnidades As Integer = 0
                    Dim ProductividadCM As Decimal = 0, ProductividadCI As Decimal = 0, ProductividadU As Decimal = 0
                    Dg_Cabecera.Rows.Add()
                    Dg_Cabecera.Rows(contador).Cells("NumGuia").Value = RowConsolidado.Item("NDOCUMENTO").ToString.Trim

                    Dim DtDetalle As New DataTable
                    DtDetalle = LlamarListarGuiasDET(RowConsolidado.Item("CODALMACEN_ORIGEN").ToString.Trim, RowConsolidado.Item("TIP_DOC").ToString.Trim, RowConsolidado.Item("NDOCUMENTO").ToString.Trim)
                    If DtDetalle.Rows.Count > 0 Then
                        For Each rowDetalle As DataRow In DtDetalle.Rows
                            Dim cajas As Decimal = 0, cajasm As Decimal = 0, saldo As Decimal = 0
                            If rowDetalle.Item("UNIDAD").ToString = "UND" Then
                                If rowDetalle.Item("FACTORCAJA").ToString <> 0 And rowDetalle.Item("FACTORCAJAMASTER").ToString <> 0 Then
                                    cajas = (rowDetalle.Item("SALDO") / rowDetalle.Item("FACTORCAJA"))
                                    saldo = rowDetalle.Item("SALDO") Mod rowDetalle.Item("FACTORCAJA")
                                    cajasm = cajas / rowDetalle.Item("FACTORCAJAMASTER")
                                    cajasm = Math.Floor(cajasm)
                                    cajas = cajas Mod rowDetalle.Item("FACTORCAJAMASTER")
                                End If
                            Else
                                If rowDetalle.Item("UNIDAD").ToString = "CJA" Then
                                    saldo = 0
                                    cajas = rowDetalle.Item("SALDO")
                                    cajasm = cajas / rowDetalle.Item("FACTORCAJAMASTER")
                                    cajasm = Math.Floor(cajasm)
                                    cajas = cajas Mod rowDetalle.Item("FACTORCAJAMASTER")
                                End If
                            End If
                            TotalMaster = TotalMaster + cajasm
                            TotalCajasInternas = TotalCajasInternas + cajas
                            TotalUnidades = TotalUnidades + saldo
                        Next
                    End If
                    Dg_Cabecera.Rows(contador).Cells("CantCM").Value = TotalMaster
                    Dg_Cabecera.Rows(contador).Cells("CAJASINT").Value = TotalCajasInternas
                    Dg_Cabecera.Rows(contador).Cells("UNIDADES").Value = TotalUnidades
                    ProductividadCM = Math.Round(TotalMaster / PCJ, 2)
                    ProductividadCI = Math.Round(TotalCajasInternas / PCIU, 2)
                    ProductividadU = Math.Round(TotalUnidades / PCIU, 2)

                    If ProductividadCM < 0.17 Then
                        ProductividadCM = 0.17

                    End If

                    If ProductividadCI < 0.17 Then
                        ProductividadCI = 0.17
                    End If

                    If ProductividadU < 0.17 Then
                        ProductividadU = 0.17
                    End If

                    Dg_Cabecera.Rows(contador).Cells("PROCM").Value = ProductividadCM
                    Dg_Cabecera.Rows(contador).Cells("PROCI").Value = ProductividadCI
                    Dg_Cabecera.Rows(contador).Cells("PROUN").Value = ProductividadU
                    Dg_Cabecera.Rows(contador).Cells("HORASHOMBRE").Value = (ProductividadCM + ProductividadCI + ProductividadU)

                    TotalHorasTotalHoras = TotalHorasTotalHoras + CType(Dg_Cabecera.Rows(contador).Cells("HORASHOMBRE").Value, Decimal)

                    contador = contador + 1
                Next
                txt_Horas.Text = TotalHorasTotalHoras.ToString
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function LlamarListarGuiasDET(codalmacen As String, tipdoc As String, nrodoc As String) As DataTable

        Dim dtretono As DataTable
        Try
            dtretono = ObjAlmacen.ListarGuiasDET(codalmacen, tipdoc, nrodoc, idalmacen, idsite).Copy
        Catch ex As Exception
            Throw ex
        End Try
        Return dtretono
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If ValidarAceptar() Then
                If txt_cantPersonas.Text <> "" Then
                    Dim TotalHoras As Decimal = CType(txt_Horas.Text, Decimal)
                    Dim CantidadPersonas As Integer = CType(txt_cantPersonas.Text, Integer)
                    Dim Horas As Decimal = 0
                    Horas = Math.Round(TotalHoras / CantidadPersonas, 2)
                    txt_horasfaltan.Text = Horas.ToString
                End If
                If txt_horasfaltan.Text <> "" Then
                    Dim TotalHoras As Decimal = CType(txt_Horas.Text, Decimal)
                    Dim CantidadHoras As Decimal = CType(txt_horasfaltan.Text, Decimal)
                    Dim Personas As Integer
                    Personas = TotalHoras / CantidadHoras
                    txt_cantPersonas.Text = Personas.ToString
                End If
            Else
                MsgBox("Existen Errores, Valide e intente de nuevo", MsgBoxStyle.Exclamation, "SISTEMAS NORDIC")
            End If
        Catch ex As Exception

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

    Public Function ValidarDecimal(Dato As String) As Boolean
        Dim retorno As Boolean = Regex.IsMatch(Dato, "^[0-9]+(\.([0-9])+)?$")
        Return retorno
    End Function

    Private Function ValidarAceptar() As Boolean
        Dim Rp As Boolean = True
        Try
            ErrorProvider1.SetError(txt_cantPersonas, "")

            ErrorProvider1.SetError(txt_horasfaltan, "")

            If txt_cantPersonas.Text = "" And txt_horasfaltan.Text = "" Then
                ErrorProvider1.SetError(txt_horasfaltan, "Debe Ingresar Cantidad Horas o Cantidad Personas")
                ErrorProvider1.SetError(txt_cantPersonas, "Debe Ingresar Cantidad Horas o Cantidad Personas")
                Rp = False
            End If
            If txt_cantPersonas.Text <> "" And txt_horasfaltan.Text <> "" Then
                ErrorProvider1.SetError(txt_horasfaltan, "Solo debe Ingresar Cantidad Horas o Cantidad Personas")
                ErrorProvider1.SetError(txt_cantPersonas, "Dolo dDebe Ingresar Cantidad Horas o Cantidad Personas")
                Rp = False
            End If
            If txt_cantPersonas.Text <> "" And txt_horasfaltan.Text = "" Then
                If ValidarNumerico(txt_cantPersonas.Text) = False Then
                    ErrorProvider1.SetError(txt_cantPersonas, "Cantidad Personas debe ser dato numerico")
                    Rp = False
                Else
                    If CType(txt_cantPersonas.Text, Integer) <= 0 Then
                        ErrorProvider1.SetError(txt_cantPersonas, "Cantidad Personas debe ser mayor a 0")
                        Rp = False
                    End If
                End If
            End If

            If txt_cantPersonas.Text = "" And txt_horasfaltan.Text <> "" Then
                If ValidarDecimal(txt_horasfaltan.Text) = False Then
                    ErrorProvider1.SetError(txt_horasfaltan, "Cantidad Hora debe ser dato numerico")
                    Rp = False
                Else
                    If CType(txt_horasfaltan.Text, Decimal) <= 0 Then
                        ErrorProvider1.SetError(txt_horasfaltan, "Cantidad Hora debe ser mayor a 0")
                        Rp = False
                    End If
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
        Return Rp
    End Function
End Class