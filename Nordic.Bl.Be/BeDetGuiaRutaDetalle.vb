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


End Class
