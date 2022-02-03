Public Class BeDetalleRotulosxArticulo


    Private VENCIMIENTO As String
    Public Property VENCIMIENTO_P() As String
        Get
            Return VENCIMIENTO
        End Get
        Set(ByVal value As String)
            VENCIMIENTO = value
        End Set
    End Property

    Private gpi_id As String
    Public Property prgpi_id() As String
        Get
            Return gpi_id
        End Get
        Set(ByVal value As String)
            gpi_id = value
        End Set
    End Property


    Private cgpi_id As String
    Public Property prcgpi_id() As String
        Get
            Return cgpi_id
        End Get
        Set(ByVal value As String)
            cgpi_id = value
        End Set
    End Property


    Private c5_calma As String
    Public Property prc5_calma() As String
        Get
            Return c5_calma
        End Get
        Set(ByVal value As String)
            c5_calma = value
        End Set
    End Property

    Private c5_ctd As String
    Public Property prc5_ctd() As String
        Get
            Return c5_ctd
        End Get
        Set(ByVal value As String)
            c5_ctd = value
        End Set
    End Property

    Private c5_cnumdoc As String
    Public Property prc5_cnumdoc() As String
        Get
            Return c5_cnumdoc
        End Get
        Set(ByVal value As String)
            c5_cnumdoc = value
        End Set
    End Property

    Private sr_ccodigo As String
    Public Property prsr_ccodigo() As String
        Get
            Return sr_ccodigo
        End Get
        Set(ByVal value As String)
            sr_ccodigo = value
        End Set
    End Property

    Private sr_cserie As String
    Public Property prsr_cserie() As String
        Get
            Return sr_cserie
        End Get
        Set(ByVal value As String)
            sr_cserie = value
        End Set
    End Property


    Private cantidad As String
    Public Property prCantidad() As String
        Get
            Return cantidad
        End Get
        Set(ByVal value As String)
            cantidad = value
        End Set
    End Property


    Private usr_id As String
    Public Property prusr_id() As String
        Get
            Return usr_id
        End Get
        Set(ByVal value As String)
            usr_id = value
        End Set
    End Property


End Class
