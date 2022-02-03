Imports System.Data.SqlClient
Imports System.Configuration

Public Class BeLoteUbicacion


    Public Conexion As String = String.Empty



    Public Function Listar_Lotes_Ubicaciones_Filtros(ByVal flag As String, ByVal fecini As String, ByVal fecfin As String, ByVal estado As String, ByVal lote As String, ByVal codigo As String) As DataTable
        Try
            Dim _listadoPruebas As New DataTable
            Conexion = System.Configuration.ConfigurationManager.ConnectionStrings("ConexionHeadMark").ConnectionString

            Using oSqlConnection As SqlConnection = New SqlConnection(Conexion)
                Dim _consulta As String = String.Empty

                Using oSqlCommand As SqlCommand = New SqlCommand("SPDSN_LISTAR_LOTES_UBICACIONES_FILTROS", oSqlConnection)
                    oSqlCommand.CommandType = CommandType.StoredProcedure
                    oSqlCommand.Parameters.Add("@FLAG", SqlDbType.Int).Value = flag
                    oSqlCommand.Parameters.Add("@FECINI", SqlDbType.VarChar, 12).Value = fecini
                    oSqlCommand.Parameters.Add("@FECFIN", SqlDbType.VarChar, 12).Value = fecfin
                    oSqlCommand.Parameters.Add("@ESTADO", SqlDbType.VarChar, 12).Value = estado
                    oSqlCommand.Parameters.Add("@LOTE", SqlDbType.VarChar, 30).Value = lote
                    oSqlCommand.Parameters.Add("@CODIGO", SqlDbType.VarChar, 12).Value = codigo


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


    Public Function Listar_Lotes_Ubicaciones(ByVal fecini As String, ByVal fecfin As String) As DataTable
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

                Using oSqlCommand As SqlCommand = New SqlCommand("SPDSN_LISTAR_LOTES_UBICACIOENS", oSqlConnection)
                    oSqlCommand.CommandType = CommandType.StoredProcedure
                    oSqlCommand.Parameters.Add("@FECINI", SqlDbType.VarChar, 12).Value = fecini
                    oSqlCommand.Parameters.Add("@FECFIN", SqlDbType.VarChar, 12).Value = fecfin

                    'oSqlCommand.Parameters.Add("@NROGUIA", SqlDbType.VarChar, 20).Value = numdoc

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

    Public Function Registrar_Actualizar_Ubicaciones(ByVal C6_CLOCALI As String, ByVal C6_CALMA As String, ByVal C6_CTD As String, ByVal C6_CNUMDOC As String,
                                                     ByVal C6_CITEM As String, ByVal C6_CCODIGO As String, ByVal C6_CSERIE As String,
                                                     ByVal SK_CUBIAL1 As String, ByVal SK_CUBIAL2 As String, ByVal SK_CUBIAL3 As String,
                                                     ByVal SK_CUBIAL4 As String, ByVal usr_id As String, ByRef _tiporespuesta As String,
                                                     ByRef _textorespuesta As String) As DataTable
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

                Using oSqlCommand As SqlCommand = New SqlCommand("SPDSN_REGISTRAR_LOTEYUBIACION", oSqlConnection)
                    oSqlCommand.CommandType = CommandType.StoredProcedure
                    oSqlCommand.Parameters.Add("@C6_CLOCALI", SqlDbType.VarChar, 4).Value = C6_CLOCALI
                    oSqlCommand.Parameters.Add("@C6_CALMA", SqlDbType.VarChar, 4).Value = C6_CALMA
                    oSqlCommand.Parameters.Add("@C6_CTD", SqlDbType.VarChar, 2).Value = C6_CTD
                    oSqlCommand.Parameters.Add("@C6_CNUMDOC", SqlDbType.VarChar, 11).Value = C6_CNUMDOC
                    oSqlCommand.Parameters.Add("@C6_CITEM", SqlDbType.VarChar, 4).Value = C6_CITEM
                    oSqlCommand.Parameters.Add("@C6_CCODIGO", SqlDbType.VarChar, 25).Value = C6_CCODIGO
                    oSqlCommand.Parameters.Add("@C6_CSERIE", SqlDbType.VarChar, 18).Value = C6_CSERIE
                    oSqlCommand.Parameters.Add("@SK_CUBIAL1", SqlDbType.VarChar, 10).Value = SK_CUBIAL1
                    oSqlCommand.Parameters.Add("@SK_CUBIAL2", SqlDbType.VarChar, 10).Value = SK_CUBIAL2
                    oSqlCommand.Parameters.Add("@SK_CUBIAL3", SqlDbType.VarChar, 10).Value = SK_CUBIAL3
                    oSqlCommand.Parameters.Add("@SK_CUBIAL4", SqlDbType.VarChar, 10).Value = SK_CUBIAL4
                    oSqlCommand.Parameters.Add("@USR_ID", SqlDbType.Int).Value = usr_id

                    'oSqlCommand.Parameters.Add("@NROGUIA", SqlDbType.VarChar, 20).Value = numdoc


                    If (oSqlConnection.State = ConnectionState.Closed) Then
                        oSqlConnection.Open()
                    End If

                    If (oSqlCommand.Connection.State = ConnectionState.Closed) Then
                        oSqlCommand.Connection.Open()
                    End If

                    Using oSqlDataReader As SqlDataReader = oSqlCommand.ExecuteReader(CommandBehavior.SingleRow)
                        If oSqlDataReader.Read Then
                            _tiporespuesta = oSqlDataReader.GetValue(0).ToString()
                            _textorespuesta = oSqlDataReader.GetValue(1).ToString()
                            'idRentabilidad = oSqlDataReader.GetValue(2).ToString()
                            'fecHoraReg = oSqlDataReader.GetValue(3).ToString()
                        End If
                        oSqlDataReader.Close()
                    End Using

                    If (oSqlCommand.Connection.State = ConnectionState.Open) Then
                        oSqlCommand.Connection.Close()
                    End If

                    If (oSqlConnection.State = ConnectionState.Open) Then
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






