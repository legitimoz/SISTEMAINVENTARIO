Public Class RegistroObservacion

    Public dtobservacion As New DataTable
    Public grabado As Boolean = False
    Private almacenObj As New AlmacenL
    Public tipoobservacion As Integer
    Public cnumdoc, ctd, calma As String

    Private Sub RegistroObservacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CargaInicial()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click
        Try
            Registrar()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Registrar()
        If tipoobservacion = 1 Then
            If LlamarRegistrarObservacionDispatch() <> 0 Then
                MsgBox("Motivo RegistradO Correctamente", MsgBoxStyle.Information, "SISTEMAS NORDIC")
                grabado = True
                Me.Close()
            Else
                MsgBox("Motivo NO Registrado Correctamente", MsgBoxStyle.Critical, "SISTEMAS NORDIC")
            End If
        Else
            If tipoobservacion = 2 Then
                If LlamarRegistrarObservacionDelivery() <> 0 Then
                    MsgBox("Motivo RegistradO Correctamente", MsgBoxStyle.Information, "SISTEMAS NORDIC")
                    grabado = True
                    Me.Close()
                Else
                    MsgBox("Motivo NO Registrado Correctamente", MsgBoxStyle.Critical, "SISTEMAS NORDIC")
                End If
            End If
        End If
    End Sub

    Public Function LlamarRegistrarObservacionDispatch() As Integer
        Dim rp As Integer = 0

        Try
            rp = almacenObj.RegistrarObservacionDispatch(calma, ctd, cnumdoc, cmb_motivos.SelectedValue)
        Catch ex As Exception
            Throw ex
        End Try

        Return rp
    End Function

    Public Function LlamarRegistrarObservacionDelivery() As Integer
        Dim rp As Integer = 0

        Try
            rp = almacenObj.RegistrarObservacionDelivery(calma, ctd, cnumdoc, cmb_motivos.SelectedValue)
        Catch ex As Exception
            Throw ex
        End Try

        Return rp
    End Function

    Public Sub ListarMotivosDispatch()
        Try
            Dim dt As New DataTable
            dt = almacenObj.ListarMotivosDispatch
            If dt.Rows.Count > 0 Then
                dtobservacion = dt
                cmb_motivos.DataSource = dtobservacion
                cmb_motivos.DisplayMember = "mot_descripcion"
                cmb_motivos.ValueMember = "mot_idmotivo"
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Sub ListarMotivosDelivery()
        Try
            Dim dt As New DataTable
            dt = almacenObj.ListarMotivosDelivery
            If dt.Rows.Count > 0 Then
                dtobservacion = dt
                cmb_motivos.DataSource = dtobservacion
                cmb_motivos.DisplayMember = "mot_descripcion"
                cmb_motivos.ValueMember = "mot_idmotivo"
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CargaInicial()
        Try
            txt_guia.Text = cnumdoc
            If tipoobservacion = 1 Then
                Me.Text = "Registrar Observacion DispatchOnTime"
                ListarMotivosDispatch()
            Else
                If tipoobservacion = 2 Then
                    Me.Text = "Registrar Observacion DeliveryOnTime"
                    ListarMotivosDelivery()
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub


End Class