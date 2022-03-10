Public Class BeDetGuiaRutaDetalle

    Private drg_id As String
    Public Property pr_drg_id() As String
        Get
            Return drg_id
        End Get
        Set(ByVal value As String)
            drg_id = value
        End Set
    End Property


    Private crg_id As String
    Public Property pr_crg_id() As String
        Get
            Return crg_id
        End Get
        Set(ByVal value As String)
            crg_id = value
        End Set
    End Property


    Private c5_calma As String
    Public Property pr_c5_calma() As String
        Get
            Return c5_calma
        End Get
        Set(ByVal value As String)
            c5_calma = value
        End Set
    End Property

    Private c5_ctd As String
    Public Property pr_c5_ctd() As String
        Get
            Return c5_ctd
        End Get
        Set(ByVal value As String)
            c5_ctd = value
        End Set
    End Property

    Private c5_numdoc As String
    Public Property pr_c5_numdoc() As String
        Get
            Return c5_numdoc
        End Get
        Set(ByVal value As String)
            c5_numdoc = value
        End Set
    End Property


    Private usr_idSalidaRuta As String
    Public Property pr_usr_idSalidaRuta() As String
        Get
            Return usr_idSalidaRuta
        End Get
        Set(ByVal value As String)
            usr_idSalidaRuta = value
        End Set
    End Property


    Private usr_idRetornoRuta As String
    Public Property pr_usr_idRetornoRuta() As String
        Get
            Return usr_idRetornoRuta
        End Get
        Set(ByVal value As String)
            usr_idRetornoRuta = value
        End Set
    End Property


    Private drg_peso As String
    Public Property pr_drg_peso() As String
        Get
            Return drg_peso
        End Get
        Set(ByVal value As String)
            drg_peso = value
        End Set
    End Property

    Private drg_bulto As String
    Public Property pr_drg_bulto() As String
        Get
            Return drg_bulto
        End Get
        Set(ByVal value As String)
            drg_bulto = value
        End Set
    End Property

    Private tiempo As Decimal
    Public Property pr_tiempo() As Decimal
        Get
            Return tiempo
        End Get
        Set(ByVal value As Decimal)
            tiempo = value
        End Set
    End Property

    Private volumen As String
    Public Property pr_volumen() As String
        Get
            Return volumen
        End Get
        Set(ByVal value As String)
            volumen = value
        End Set
    End Property

    Private restriccion As String
    Public Property pr_restriccion() As String
        Get
            Return restriccion
        End Get
        Set(ByVal value As String)
            restriccion = value
        End Set
    End Property

    Private TipoRuta As String
    Public Property pr_TipoRuta() As String
        Get
            Return TipoRuta
        End Get
        Set(ByVal value As String)
            TipoRuta = value
        End Set
    End Property

    Private Cliente As String
    Public Property pr_Cliente() As String
        Get
            Return Cliente
        End Get
        Set(ByVal value As String)
            Cliente = value
        End Set
    End Property

    Private DireccionEntrega As String
    Public Property pr_DireccionEntrega() As String
        Get
            Return DireccionEntrega
        End Get
        Set(ByVal value As String)
            DireccionEntrega = value
        End Set
    End Property

    Private importe As Decimal
    Public Property pr_importe() As Decimal
        Get
            Return importe
        End Get
        Set(ByVal value As Decimal)
            importe = value
        End Set
    End Property


    Private Condicion As String
    Public Property pr_Condicion() As String
        Get
            Return Condicion
        End Get
        Set(ByVal value As String)
            Condicion = value
        End Set
    End Property

    Private Representante As String
    Public Property pr_Representante() As String
        Get
            Return Representante
        End Get
        Set(ByVal value As String)
            Representante = value
        End Set
    End Property

End Class
