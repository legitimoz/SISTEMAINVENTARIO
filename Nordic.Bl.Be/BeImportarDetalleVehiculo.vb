Public Class BeImportarDetalleVehiculo

    Private ve_dua As String
    Public Property pr_vedua() As String
        Get
            Return ve_dua
        End Get
        Set(ByVal value As String)
            ve_dua = value
        End Set
    End Property


    Private ve_fecha_dua As String
    Public Property pr_ve_fecha_dua() As String
        Get
            Return ve_fecha_dua
        End Get
        Set(ByVal value As String)
            ve_fecha_dua = value
        End Set
    End Property

    Private ve_modelo As String
    Public Property pr_ve_modelo() As String
        Get
            Return ve_modelo
        End Get
        Set(ByVal value As String)
            ve_modelo = value
        End Set
    End Property

    Private ve_cchasis As String
    Public Property pr_ve_cchasis() As String
        Get
            Return ve_cchasis
        End Get
        Set(ByVal value As String)
            ve_cchasis = value
        End Set
    End Property

    Private ve_ccodvin As String
    Public Property pr_ve_ccodvin() As String
        Get
            Return ve_ccodvin
        End Get
        Set(ByVal value As String)
            ve_ccodvin = value
        End Set
    End Property

    Private ve_invoice As String
    Public Property pr_ve_invoice() As String
        Get
            Return ve_invoice
        End Get
        Set(ByVal value As String)
            ve_invoice = value
        End Set
    End Property


    Private usr_id As String
    Public Property pr_usr_id() As String
        Get
            Return usr_id
        End Get
        Set(ByVal value As String)
            usr_id = value
        End Set
    End Property



End Class
