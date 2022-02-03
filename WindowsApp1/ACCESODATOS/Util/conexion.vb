
Imports System.Data.SqlClient

Public Class conexion

#Region "Campos"
    Private mBase As String
    Private mServidor As String
    Private mUsuario As String
    Private mclave As String
    Private mSeguridad As Boolean = False
    Public Conn As SqlConnection
#End Region

#Region "Propiedades"
    Public Property Base As String
        Get
            Return mBase
        End Get
        Set(value As String)
            mBase = value
        End Set
    End Property

    Public Property Servidor As String
        Get
            Return mServidor
        End Get
        Set(value As String)
            mServidor = value
        End Set
    End Property

    Public Property Usuario As String
        Get
            Return mUsuario
        End Get
        Set(value As String)
            mUsuario = value
        End Set
    End Property

    Public Property clave As String
        Get
            Return mclave
        End Get
        Set(value As String)
            mclave = value
        End Set
    End Property

    Public Property Seguridad As Boolean
        Get
            Return mSeguridad
        End Get
        Set(value As Boolean)
            mSeguridad = value
        End Set
    End Property
#End Region

#Region "Constructor"

    Sub New()
        Me.Base = "BDLABFAR_BK"
        Me.Servidor = "10.10.0.5"
        Me.Usuario = "headmark"
        Me.clave = "N0rd1c06$21"
        Dim Conexion As String = System.Configuration.ConfigurationManager.ConnectionStrings("ConexionHeadMark").ConnectionString
        Me.Conn = New SqlConnection(Conexion)
    End Sub

    Public Function CrearCadena() As String
        Dim Cadena As String
        Cadena = "Server=" & Me.Servidor & "; Database=" &
                  Me.Base & ";"
        If Me.Seguridad Then
            Cadena = Cadena & "Integrated Security= SSPI"
        Else
            Cadena &= "User id=" & Me.Usuario & "; Password=" & Me.clave
        End If
        Return Cadena
    End Function

#End Region

End Class