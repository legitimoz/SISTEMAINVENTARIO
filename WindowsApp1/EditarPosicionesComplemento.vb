Imports System.Text.RegularExpressions
Imports Nordic.Bl.Be
Public Class EditarPosicionesComplemento
    Public idrack As Integer
    Private ObjAlmacen As New AlmacenL
    Private dtposiciones As New DataTable
    Public Estructura As New EstructuraTabla
    Public grabado As Boolean = False
    Private Sub EditarPosicionesComplemento_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CargaInicial()
    End Sub

    Public Sub CargaInicial()
        Try
            FormatoTablaTemporal()
            If idrack <> 0 Then
                ListarPosiciones()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Function LlamarListarPosiciones() As DataTable

        Dim dtretono As DataTable
        Try
            dtretono = ObjAlmacen.ListarPosicionesCompletar(idrack).Copy
        Catch ex As Exception
            Throw ex
        End Try
        Return dtretono
    End Function

    Public Sub ListarPosiciones()
        Try
            Dim dtretorno As New DataTable
            dtretorno = LlamarListarPosiciones()

            If dtretorno.Rows.Count > 0 Then

                For Each RowRetorno As DataRow In dtretorno.Rows
                    Dim rowPosicion As DataRow
                    rowPosicion = dtposiciones.NewRow
                    rowPosicion.Item("esp_idespacio") = RowRetorno.Item("esp_idespacio")
                    rowPosicion.Item("esp_codigoespacio") = RowRetorno.Item("esp_codigoespacio")
                    rowPosicion.Item("esp_alto") = RowRetorno.Item("esp_alto").ToString()
                    rowPosicion.Item("esp_largo") = RowRetorno.Item("esp_largo").ToString()
                    rowPosicion.Item("esp_ancho") = RowRetorno.Item("esp_ancho").ToString()
                    dtposiciones.Rows.Add(rowPosicion)
                Next

                Dg_Confirmados.DataSource = dtposiciones
            End If

        Catch ex As Exception

        End Try
    End Sub

    Public Sub FormatoTablaTemporal()

        dtposiciones = Estructura.TablaPosicionesCompletar.Clone

        Dg_Confirmados.DataSource = dtposiciones

        Dg_Confirmados.Columns("esp_idespacio").Visible = False

        Dg_Confirmados.Columns("esp_codigoespacio").HeaderText = "Codigo"
        Dg_Confirmados.Columns("esp_codigoespacio").Width = 150
        Dg_Confirmados.Columns("esp_codigoespacio").ReadOnly = True
        Dg_Confirmados.Columns("esp_codigoespacio").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_Confirmados.Columns("esp_alto").HeaderText = "Alto"
        Dg_Confirmados.Columns("esp_alto").Width = 100
        Dg_Confirmados.Columns("esp_alto").ReadOnly = False
        Dg_Confirmados.Columns("esp_alto").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dg_Confirmados.Columns("esp_largo").HeaderText = "Largo"
        Dg_Confirmados.Columns("esp_largo").Width = 100
        Dg_Confirmados.Columns("esp_largo").ReadOnly = False
        Dg_Confirmados.Columns("esp_largo").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter


        Dg_Confirmados.Columns("esp_ancho").HeaderText = "Ancho"
        Dg_Confirmados.Columns("esp_ancho").Width = 100
        Dg_Confirmados.Columns("esp_ancho").ReadOnly = False
        Dg_Confirmados.Columns("esp_ancho").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter


    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        ComplementarPosiciones()
    End Sub


    Public Function ValidarDecimal(Dato As String) As Boolean
        Dim retorno As Boolean = Regex.IsMatch(Dato, "^[0-9]+(\,([0-9])+)?$")
        Return retorno
    End Function

    Private Sub ComplementarPosiciones()
        Try
            If Check_Todos.Checked = True Then
                If ValidarAceptar() Then
                    LlamarComplementarTodos()
                Else
                    MsgBox("Existen Errores, Valide e intente nuevamente", MsgBoxStyle.Exclamation)
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function ValidarAceptar() As Boolean
        Dim rp As Boolean = True
        Try
            ErrorDimensiones.SetError(txt_alto, "")
            ErrorDimensiones.SetError(txt_ancho, "")
            ErrorDimensiones.SetError(txt_largo, "")

            If txt_alto.Text = "" Then
                ErrorDimensiones.SetError(txt_alto, "Ingrese Alto de Posicion")
                rp = False
            Else
                If ValidarDecimal(txt_alto.Text) Then
                    If CType(txt_alto.Text, Decimal) <= 0 Then
                        ErrorDimensiones.SetError(txt_alto, "Alto de Posicion debe ser un valor mayor a 0")
                        rp = False
                    End If
                Else
                    ErrorDimensiones.SetError(txt_alto, "Alto de Posicion debe ser un valor Numerico")
                    rp = False
                End If
            End If

            If txt_ancho.Text = "" Then
                ErrorDimensiones.SetError(txt_ancho, "Ingrese Ancho de Posicion")
                rp = False
            Else
                If ValidarDecimal(txt_ancho.Text) Then
                    If CType(txt_ancho.Text, Decimal) <= 0 Then
                        ErrorDimensiones.SetError(txt_ancho, "Ancho de Posicion debe ser un valor mayor a 0")
                        rp = False
                    End If
                Else
                    ErrorDimensiones.SetError(txt_ancho, "Ancho de Posicion debe ser un valor Numerico")
                    rp = False
                End If
            End If

            If txt_largo.Text = "" Then
                ErrorDimensiones.SetError(txt_largo, "Ingrese Largo de Posicion")
                rp = False
            Else
                If ValidarDecimal(txt_largo.Text) Then
                    If CType(txt_largo.Text, Decimal) <= 0 Then
                        ErrorDimensiones.SetError(txt_largo, "Largo de Posicion debe ser un valor mayor a 0")
                        rp = False
                    End If
                Else
                    ErrorDimensiones.SetError(txt_largo, "Largo de Posicion debe ser un valor Numerico")
                    rp = False
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
        Return rp
    End Function

    Public Sub LlamarComplementarTodos()
        Dim rp As Integer = 0
        Try
            If idrack <> 0 Then
                rp = ObjAlmacen.ComplementarEspaciosTodos(idrack, Convert.ToDecimal(txt_alto.Text), Convert.ToDecimal(txt_largo.Text), Convert.ToDecimal(txt_ancho.Text))
                If rp <> 0 Then
                    grabado = True
                    Me.Close()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

End Class