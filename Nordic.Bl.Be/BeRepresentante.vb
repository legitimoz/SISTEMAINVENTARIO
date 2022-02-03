
Imports System.Data.SqlClient
Imports System.Configuration

Public Class BeRepresentante

    Public Conexion As String = String.Empty



    Public Function Obtener_Lineas_xRepre(ByVal codrepre As String) As DataTable
        Try

            Dim _listadoPruebas As New DataTable
            Conexion = System.Configuration.ConfigurationManager.ConnectionStrings("ConexionHeadMark").ConnectionString

            Using oSqlConnection As SqlConnection = New SqlConnection(Conexion)
                Dim _consulta As String = String.Empty
                _consulta = "SELECT distinct codlineaneg FROM DB_Prueba..tbZonas_clasi_4 WHERE codrepresentante ='" + codrepre + "'"

                Using oSqlCommand As SqlCommand = New SqlCommand(_consulta, oSqlConnection)
                    oSqlCommand.CommandType = CommandType.Text

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


    Public Function Listar_Representante(ByVal flag As String, ByVal nombre As String, ByVal fecini As String, ByVal fecfin As String, ByVal prefijo As String) As DataTable
        Try
            Dim _listadoPruebas As New DataTable
            Conexion = System.Configuration.ConfigurationManager.ConnectionStrings("ConexionHeadMark").ConnectionString

            Using oSqlConnection As SqlConnection = New SqlConnection(Conexion)
                Dim _consulta As String = String.Empty

                Using oSqlCommand As SqlCommand = New SqlCommand("SPDSN_LISTADO_REPRE", oSqlConnection)
                    oSqlCommand.CommandType = CommandType.StoredProcedure

                    oSqlCommand.Parameters.Add("@flag", SqlDbType.Int).Value = flag
                    oSqlCommand.Parameters.Add("@nombre", SqlDbType.VarChar, 100).Value = nombre
                    oSqlCommand.Parameters.Add("@fecini", SqlDbType.VarChar, 12).Value = fecini
                    oSqlCommand.Parameters.Add("@fecfin", SqlDbType.VarChar, 12).Value = fecfin
                    oSqlCommand.Parameters.Add("@prefijo", SqlDbType.VarChar, 12).Value = prefijo


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



    Public Function Listar_VisitasMedicas(ByVal fecIni As String, ByVal fecFin As String, ByVal codrepre As String) As DataTable
        Try
            Dim _listadoPruebas As New DataTable
            Conexion = System.Configuration.ConfigurationManager.ConnectionStrings("ConexionHeadMark").ConnectionString

            Using oSqlConnection As SqlConnection = New SqlConnection(Conexion)
                Dim _consulta As String = String.Empty

                Using oSqlCommand As SqlCommand = New SqlCommand("SPDSN_LSITAR_VISITAS", oSqlConnection)
                    oSqlCommand.CommandType = CommandType.StoredProcedure

                    oSqlCommand.Parameters.Add("@FECINI", SqlDbType.VarChar, 20).Value = fecIni
                    oSqlCommand.Parameters.Add("@FECFIN", SqlDbType.VarChar, 20).Value = fecFin
                    oSqlCommand.Parameters.Add("@CODREPRE", SqlDbType.VarChar, 20).Value = codrepre


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


    Public Function Listar_VisitasFarmacias(ByVal fechaIni As String, ByVal fechaFin As String, ByVal codrepre As String) As DataTable
        Try
            Dim _listadoPruebas As New DataTable
            Conexion = System.Configuration.ConfigurationManager.ConnectionStrings("ConexionHeadMark").ConnectionString

            Using oSqlConnection As SqlConnection = New SqlConnection(Conexion)
                Dim _consulta As String = String.Empty

                Using oSqlCommand As SqlCommand = New SqlCommand("SPDSN_LISTAR_VISITAS_FARBOTI", oSqlConnection)
                    oSqlCommand.CommandType = CommandType.StoredProcedure

                    oSqlCommand.Parameters.Add("@FECHA", SqlDbType.VarChar, 20).Value = fechaIni
                    oSqlCommand.Parameters.Add("@FECHAFIN", SqlDbType.VarChar, 20).Value = fechaFin
                    oSqlCommand.Parameters.Add("@CODREPRE", SqlDbType.VarChar, 20).Value = codrepre


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




    Public Function ListaPedidos(ByVal fechaIni As String, ByVal fecFin As String, ByVal codrepre As String) As DataTable
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

                Using oSqlCommand As SqlCommand = New SqlCommand("SPDSN_LISTAR_PEDIDOS_XREPRE", oSqlConnection)
                    oSqlCommand.CommandType = CommandType.StoredProcedure
                    oSqlCommand.Parameters.Add("@FECHA", SqlDbType.VarChar, 20).Value = fechaIni
                    oSqlCommand.Parameters.Add("@FECHAFIN", SqlDbType.VarChar, 20).Value = fecFin
                    oSqlCommand.Parameters.Add("@CODREPRE", SqlDbType.VarChar, 20).Value = codrepre

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



End Class
