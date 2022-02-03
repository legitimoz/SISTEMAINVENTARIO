Public Class ComplemetarRuta
    Public grabado As Boolean = False
    Public repartidor As String, movilidad As String
    Public AlmacenObj As New AlmacenL
    Public dt_transportista, dt_vehiculos As New DataTable

    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click
        Try
            repartidor = cmb_repartidor.Text
            movilidad = cmb_tipotransporte.Text
            grabado = True
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub CargaInicial()
        Try
            'cmb_repartidor.SelectedIndex = 0
            'cmb_tipotransporte.SelectedIndex = 0
            ListarVehiculos()
            ListarTransportista()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub ComplemetarRuta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CargaInicial()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub ListarTransportista()
        Try
            ' Dim dtretorno As New DataTable

            dt_transportista = AlmacenObj.ListarTransportistaDespacho
            If dt_transportista.Rows.Count > 0 Then
                cmb_repartidor.DataSource = dt_transportista
                cmb_repartidor.DisplayMember = "tra_nombretransportista"
                cmb_repartidor.ValueMember = "tra_idtransportista"
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Sub ListarVehiculos()
        Try
            ' Dim dtretorno As New DataTable

            dt_vehiculos = AlmacenObj.ListarVehiculoDespacho
            If dt_vehiculos.Rows.Count > 0 Then
                cmb_tipotransporte.DataSource = dt_vehiculos
                cmb_tipotransporte.DisplayMember = "veh_tipovehiculo"
                'cmb_tipotransporte.ValueMember = "veh_placa"
            End If
        Catch ex As Exception

        End Try
    End Sub

End Class