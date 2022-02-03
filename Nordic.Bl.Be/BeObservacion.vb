
Imports System.Data.SqlClient
Imports System.Configuration

Public Class BeObservacion

    Private idObs As String
    Public Property pridObser() As String
        Get
            Return idObs
        End Get
        Set(ByVal value As String)
            idObs = value
        End Set
    End Property


    Private observacion As String
    Public Property prObservacion() As String
        Get
            Return observacion
        End Get
        Set(ByVal value As String)
            observacion = value
        End Set
    End Property

    Private codigoPedido As String
    Public Property prcodigoPedido() As String
        Get
            Return codigoPedido
        End Get
        Set(ByVal value As String)
            codigoPedido = value
        End Set
    End Property

    Private numeroPedido As String
    Public Property prnumeroPedido() As String
        Get
            Return numeroPedido
        End Get
        Set(ByVal value As String)
            numeroPedido = value
        End Set
    End Property

    Private idUser As String
    Public Property pridUser() As String
        Get
            Return idUser
        End Get
        Set(ByVal value As String)
            idUser = value
        End Set
    End Property

    Public Conexion As String = String.Empty



    Public Function Obtener_Observacion(ByVal idObs As String) As DataTable
        Try
            Dim _listadoPruebas As New DataTable
            Conexion = System.Configuration.ConfigurationManager.ConnectionStrings("ConexionHeadMark").ConnectionString

            Using oSqlConnection As SqlConnection = New SqlConnection(Conexion)
                Dim _consulta As String = String.Empty
                '_consulta = "   SELECT A.ID,A.FECHA,A.HORA,A.nombre_razonSocial,A.Diferencia,A.Tiempo,A.TipoReclamo,A.reclamo,A.nombre_contacto,A.Telefono,A.DEPARTAMENTO,A.direccion   FROM " & _
                '"(SELECT id, nombre_razonSocial,CONVERT(VARCHAR,[fec_reg],103) as [FECHA], " & _
                '"CONVERT(VARCHAR,[fec_reg],108) as HORA, DATEDIFF(minute,fec_reg,getdate()) as Diferencia, '10' as Tiempo," & _
                '"(SELECT descripcion FROM TIPORECLAMO where idTipoRe= b.codreclamo) as [TipoReclamo],reclamo,nombre_contacto,Telefono," & _
                '"(SELECT UPPER(NOMBRE) FROM UBIGEO WHERE CODPROV = '00' and CODDIST = '00' and CODDPTO =b.CODDPTO) AS DEPARTAMENTO, b.direccion FROM RECLAMOS b) A "

                Using oSqlCommand As SqlCommand = New SqlCommand("SPDSN_OBTENER_OBSERVACION", oSqlConnection)
                    oSqlCommand.CommandType = CommandType.StoredProcedure
                    oSqlCommand.Parameters.Add("@obp_id", SqlDbType.Int).Value = idObs

                    If (oSqlConnection.State = Data.ConnectionState.Closed) Then
                        oSqlConnection.Open()
                    End If

                    If (oSqlCommand.Connection.State = Data.ConnectionState.Closed) Then
                        oSqlCommand.Connection.Open()
                    End If

                    Using adapter As SqlDataAdapter = New SqlDataAdapter
                        adapter.SelectCommand = oSqlCommand
                        adapter.Fill(_listadoPruebas)
                    End Using

                    If (oSqlCommand.Connection.State = Data.ConnectionState.Open) Then
                        oSqlCommand.Connection.Close()
                    End If

                    If (oSqlConnection.State = Data.ConnectionState.Open) Then
                        oSqlConnection.Close()
                    End If

                End Using
            End Using

            Return _listadoPruebas

        Catch ex As Exception
            Return Nothing
        End Try

    End Function


    Public Function Registrar_Observacion_Pedido(ByVal descripcion As String, ByVal Codigo As String, ByVal numeroPedido As String, ByVal userId As String) As Integer
        Try
            Dim filasAfectadas As Integer = 0

            Conexion = System.Configuration.ConfigurationManager.ConnectionStrings("ConexionHeadMark").ConnectionString


            Using oSqlConnectionMedlab As SqlConnection = New SqlConnection(Conexion)
                Using oSqlCommandMedlab As SqlCommand = New SqlCommand("SPDSN_REGISTRAR_OBSERVACION", oSqlConnectionMedlab)
                    oSqlCommandMedlab.CommandType = CommandType.StoredProcedure

                    oSqlCommandMedlab.Parameters.Add("@obp_descripcion", SqlDbType.VarChar, 500).Value = descripcion
                    oSqlCommandMedlab.Parameters.Add("@f5_ccodage", SqlDbType.VarChar, 4).Value = Codigo
                    oSqlCommandMedlab.Parameters.Add("@f5_cnumped", SqlDbType.VarChar, 11).Value = numeroPedido
                    oSqlCommandMedlab.Parameters.Add("@UserId", SqlDbType.Int).Value = userId

                    If (oSqlConnectionMedlab.State = ConnectionState.Closed) Then
                        oSqlConnectionMedlab.Open()
                    End If

                    If (oSqlCommandMedlab.Connection.State = ConnectionState.Closed) Then
                        oSqlCommandMedlab.Connection.Open()
                    End If


                    filasAfectadas = oSqlCommandMedlab.ExecuteNonQuery()

                    'Using oSqlDataReader As SqlDataReader = oSqlCommandMedlab.ExecuteReader(CommandBehavior.SingleRow)
                    '    If oSqlDataReader.Read Then
                    '        _tiporespuesta = oSqlDataReader.GetValue(0).ToString()
                    '        _textorespuesta = oSqlDataReader.GetValue(1).ToString()
                    '        idCoord = oSqlDataReader.GetValue(2).ToString()
                    '        fecHoraReg = oSqlDataReader.GetValue(3).ToString()
                    '    End If
                    '    oSqlDataReader.Close()
                    'End Using

                    If (oSqlCommandMedlab.Connection.State = ConnectionState.Open) Then
                        oSqlCommandMedlab.Connection.Close()
                    End If

                    If (oSqlConnectionMedlab.State = ConnectionState.Open) Then
                        oSqlConnectionMedlab.Close()
                    End If
                End Using
            End Using

            Return filasAfectadas

        Catch ex As Exception
            Return 0
        End Try
    End Function





End Class
