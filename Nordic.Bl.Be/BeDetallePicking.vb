Public Class BeDetallePicking


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
