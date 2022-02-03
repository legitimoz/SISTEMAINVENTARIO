Imports System.IO

<Serializable()> Public Class Rack
    Public ra_idalmacen As Integer
    Public ra_numeracion As Integer
    Public ra_codigoalmacen As String
    Public ra_cantidadx As Integer
    Public ra_cantidady As Integer
    Public ListaEspacios As List(Of EspeacioRack)

    Public Function Serializar(Rack As Rack) As String

        Dim _oStringWriter As StringWriter
        Dim _listaSerializada As String = String.Empty
        Dim _oSerialization As System.Xml.Serialization.XmlSerializer

        Try
            _oStringWriter = New StringWriter()
            _oSerialization = New System.Xml.Serialization.XmlSerializer(Rack.GetType())
            _oSerialization.Serialize(_oStringWriter, Rack)
            _listaSerializada = _oStringWriter.ToString()

        Catch ex As Exception
            Throw ex
        End Try
        Return _listaSerializada

    End Function
End Class
