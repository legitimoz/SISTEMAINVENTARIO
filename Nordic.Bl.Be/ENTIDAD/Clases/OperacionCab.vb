Imports System.IO

Public Class OperacionCab
    Public opa_idoperacion As Integer
    Public opa_C5_CALMA As String
    Public opa_C5_CNUMDOC As String
    Public opa_userid As Integer
    Public opa_fechreg As String
    Public idsite As Integer
    Public idalmacen As Integer
    Public idrack As Integer
    Public opa_tipoMovimiento As String
    Public Detalle As List(Of OperacionDet)

    Public Function Serializar(OperacionCab As OperacionCab) As String

        Dim _oStringWriter As StringWriter
        Dim _listaSerializada As String = String.Empty
        Dim _oSerialization As System.Xml.Serialization.XmlSerializer

        Try
            _oStringWriter = New StringWriter()
            _oSerialization = New System.Xml.Serialization.XmlSerializer(OperacionCab.GetType())
            _oSerialization.Serialize(_oStringWriter, OperacionCab)
            _listaSerializada = _oStringWriter.ToString()

        Catch ex As Exception
            Throw ex
        End Try
        Return _listaSerializada

    End Function
End Class
