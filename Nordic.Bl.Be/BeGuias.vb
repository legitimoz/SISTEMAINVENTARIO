
Imports System.Data.SqlClient
Imports System.Configuration


Public Class BeGuias


    Public Conexion As String = String.Empty


    Public Function Imprimir_Ruta(ByVal crg_id As String) As DataTable
        Try
            Dim _listadoPruebas As New DataTable
            Conexion = System.Configuration.ConfigurationManager.ConnectionStrings("ConexionHeadMark").ConnectionString

            Using oSqlConnection As SqlConnection = New SqlConnection(Conexion)
                Dim _consulta As String = String.Empty

                Using oSqlCommand As SqlCommand = New SqlCommand("SPDSN_IMPRIMIR_RUTA", oSqlConnection)
                    oSqlCommand.CommandType = CommandType.StoredProcedure
                    oSqlCommand.Parameters.Add("@CRG_ID", SqlDbType.Int).Value = crg_id

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



    Public Function Obtener_Guia(ByVal numdoc As String) As DataTable
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

                Using oSqlCommand As SqlCommand = New SqlCommand("SPDSN_NORDIC_OBTENER_GUIA", oSqlConnection)
                    oSqlCommand.CommandType = CommandType.StoredProcedure
                    oSqlCommand.Parameters.Add("@NROGUIA", SqlDbType.VarChar, 20).Value = numdoc

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



    Public Function Obtener_Guia_Ssenda(ByVal numdoc As String) As DataTable
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

                Using oSqlCommand As SqlCommand = New SqlCommand("SPDSN_SSENDA_OBTENER_GUIA", oSqlConnection)
                    oSqlCommand.CommandType = CommandType.StoredProcedure
                    oSqlCommand.Parameters.Add("@NROGUIA", SqlDbType.VarChar, 20).Value = numdoc

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


    Public Function Obtener_Transportistas() As DataTable
        Try

            Dim _listadoPruebas As New DataTable
            Conexion = System.Configuration.ConfigurationManager.ConnectionStrings("ConexionHeadMark").ConnectionString

            Using oSqlConnection As SqlConnection = New SqlConnection(Conexion)
                Dim _consulta As String = String.Empty
                _consulta = "SELECT 'TODOS' AS C5_CNOMTRA UNION ALL SELECT DISTINCT RTRIM(LTRIM(C5_CNOMTRA)) AS C5_CNOMTRA FROM RSFACCAR..AL0018MOVC WHERE C5_CNOMTRA <> ''"
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




    Public Function Obtener_Guias_ImpresionMasiva(ByVal FEC1 As Date, ByVal FEC2 As Date, ByVal TRANSPORTE As String) As DataTable
        Try
            Dim _listadoPruebas As New DataTable
            Conexion = System.Configuration.ConfigurationManager.ConnectionStrings("ConexionHeadMark").ConnectionString

            Using oSqlConnection As SqlConnection = New SqlConnection(Conexion)
                Dim _consulta As String = String.Empty
                '_consulta = "SELECT DISTINCT RTRIM(LTRIM(C5_CNOMTRA)) AS C5_CNOMTRA FROM RSFACCAR..AL0018MOVC WHERE C5_CNOMTRA <> '' ORDER BY 1 ASC"
                Using oSqlCommand As SqlCommand = New SqlCommand("SPDSN_LISTA_GRID_GUIA_NORDIC", oSqlConnection)
                    oSqlCommand.CommandType = CommandType.StoredProcedure

                    oSqlCommand.Parameters.Add("@F1", SqlDbType.Date).Value = FEC1
                    oSqlCommand.Parameters.Add("@F2", SqlDbType.Date).Value = FEC2
                    oSqlCommand.Parameters.Add("@TRANSPORTE", SqlDbType.VarChar, 100).Value = TRANSPORTE


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



    Public Function Obtener_Transportistas2() As DataTable
        Try

            Dim _listadoPruebas As New DataTable
            Conexion = System.Configuration.ConfigurationManager.ConnectionStrings("ConexionHeadMark").ConnectionString

            Using oSqlConnection As SqlConnection = New SqlConnection(Conexion)
                Dim _consulta As String = String.Empty
                _consulta = "SELECT '0' TR_CCODIGO, '--TODOS--' TR_CNOMBRE UNION ALL SELECT TR_CCODIGO, TR_CNOMBRE FROM RSFACCAR..AL0018TRAN WHERE TR_CESTADO = 'V'"
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


    Public Function Agregar_GuiasRuta(ByVal c5_cnumdoc As String) As DataTable
        Try
            Dim _listadoGuias As New DataTable
            Conexion = System.Configuration.ConfigurationManager.ConnectionStrings("ConexionHeadMark").ConnectionString

            Using oSqlConnection As SqlConnection = New SqlConnection(Conexion)
                Dim _consulta As String = String.Empty
                '_consulta = "SELECT DISTINCT RTRIM(LTRIM(C5_CNOMTRA)) AS C5_CNOMTRA FROM RSFACCAR..AL0018MOVC WHERE C5_CNOMTRA <> '' ORDER BY 1 ASC"
                Using oSqlCommand As SqlCommand = New SqlCommand("SPDSN_AGREGAR_GUIA_RUTA", oSqlConnection)
                    oSqlCommand.CommandType = CommandType.StoredProcedure

                    oSqlCommand.Parameters.Add("@C5_CNUMDOC", SqlDbType.VarChar, 15).Value = c5_cnumdoc

                    If (oSqlConnection.State = Data.ConnectionState.Closed) Then
                        oSqlConnection.Open()
                    End If

                    If (oSqlCommand.Connection.State = Data.ConnectionState.Closed) Then
                        oSqlCommand.Connection.Open()
                    End If

                    Using adapter As SqlDataAdapter = New SqlDataAdapter
                        adapter.SelectCommand = oSqlCommand
                        adapter.Fill(_listadoGuias)
                    End Using

                    If (oSqlCommand.Connection.State = Data.ConnectionState.Open) Then
                        oSqlCommand.Connection.Close()
                    End If

                    If (oSqlConnection.State = Data.ConnectionState.Open) Then
                        oSqlConnection.Close()
                    End If

                End Using
            End Using

            Return _listadoGuias

        Catch ex As Exception
            Return Nothing
        End Try

    End Function



    Public Function Obtener_Motivos(ByVal est_codigo As String) As DataTable
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

                Using oSqlCommand As SqlCommand = New SqlCommand("SPDSN_LISTAR_RRMOTIVOS", oSqlConnection)
                    oSqlCommand.CommandType = CommandType.StoredProcedure
                    oSqlCommand.Parameters.Add("@est_codigo", SqlDbType.Char, 2).Value = est_codigo

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



    Public Function Agregar_GuiasRuta_RetornoRuta(ByVal crg_id As Integer, ByVal c5_cnumdoc As String) As DataTable
        Try
            Dim _listadoGuias As New DataTable
            Conexion = System.Configuration.ConfigurationManager.ConnectionStrings("ConexionHeadMark").ConnectionString

            Using oSqlConnection As SqlConnection = New SqlConnection(Conexion)
                Dim _consulta As String = String.Empty
                '_consulta = "SELECT DISTINCT RTRIM(LTRIM(C5_CNOMTRA)) AS C5_CNOMTRA FROM RSFACCAR..AL0018MOVC WHERE C5_CNOMTRA <> '' ORDER BY 1 ASC"
                Using oSqlCommand As SqlCommand = New SqlCommand("SPDSN_SEGUIMIENTO_RUTA_GUIA", oSqlConnection)
                    oSqlCommand.CommandType = CommandType.StoredProcedure



                    oSqlCommand.Parameters.Add("@CRG_ID", SqlDbType.Int).Value = crg_id
                    oSqlCommand.Parameters.Add("@C5_CNUMDOC", SqlDbType.VarChar, 15).Value = c5_cnumdoc

                    If (oSqlConnection.State = Data.ConnectionState.Closed) Then
                        oSqlConnection.Open()
                    End If

                    If (oSqlCommand.Connection.State = Data.ConnectionState.Closed) Then
                        oSqlCommand.Connection.Open()
                    End If

                    Using adapter As SqlDataAdapter = New SqlDataAdapter
                        adapter.SelectCommand = oSqlCommand
                        adapter.Fill(_listadoGuias)
                    End Using

                    If (oSqlCommand.Connection.State = Data.ConnectionState.Open) Then
                        oSqlCommand.Connection.Close()
                    End If

                    If (oSqlConnection.State = Data.ConnectionState.Open) Then
                        oSqlConnection.Close()
                    End If

                End Using
            End Using

            Return _listadoGuias

        Catch ex As Exception
            Return Nothing
        End Try

    End Function




    Public Function Agregar_GuiasRuta_RetornoRuta_SinRuta(ByVal c5_cnumdoc As String) As DataTable
        Try
            Dim _listadoGuias As New DataTable
            Conexion = System.Configuration.ConfigurationManager.ConnectionStrings("ConexionHeadMark").ConnectionString

            Using oSqlConnection As SqlConnection = New SqlConnection(Conexion)
                Dim _consulta As String = String.Empty
                '_consulta = "SELECT DISTINCT RTRIM(LTRIM(C5_CNOMTRA)) AS C5_CNOMTRA FROM RSFACCAR..AL0018MOVC WHERE C5_CNOMTRA <> '' ORDER BY 1 ASC"
                Using oSqlCommand As SqlCommand = New SqlCommand("SPDSN_SEGUIMIENTO_SINRUTA_GUIA", oSqlConnection)
                    oSqlCommand.CommandType = CommandType.StoredProcedure

                    'oSqlCommand.Parameters.Add("@CRG_ID", SqlDbType.Int).Value = crg_id
                    oSqlCommand.Parameters.Add("@C5_CNUMDOC", SqlDbType.VarChar, 15).Value = c5_cnumdoc

                    If (oSqlConnection.State = Data.ConnectionState.Closed) Then
                        oSqlConnection.Open()
                    End If

                    If (oSqlCommand.Connection.State = Data.ConnectionState.Closed) Then
                        oSqlCommand.Connection.Open()
                    End If

                    Using adapter As SqlDataAdapter = New SqlDataAdapter
                        adapter.SelectCommand = oSqlCommand
                        adapter.Fill(_listadoGuias)
                    End Using

                    If (oSqlCommand.Connection.State = Data.ConnectionState.Open) Then
                        oSqlCommand.Connection.Close()
                    End If

                    If (oSqlConnection.State = Data.ConnectionState.Open) Then
                        oSqlConnection.Close()
                    End If

                End Using
            End Using

            Return _listadoGuias

        Catch ex As Exception
            Return Nothing
        End Try

    End Function



    Public Function Listar_GuiasMotivadas(ByVal crg_id As Integer) As DataTable
        Try
            Dim _listadoGuias As New DataTable
            Conexion = System.Configuration.ConfigurationManager.ConnectionStrings("ConexionHeadMark").ConnectionString

            Using oSqlConnection As SqlConnection = New SqlConnection(Conexion)
                Dim _consulta As String = String.Empty
                '_consulta = "SELECT DISTINCT RTRIM(LTRIM(C5_CNOMTRA)) AS C5_CNOMTRA FROM RSFACCAR..AL0018MOVC WHERE C5_CNOMTRA <> '' ORDER BY 1 ASC"
                Using oSqlCommand As SqlCommand = New SqlCommand("SPDSN_LISTAR_GUIASMOTIVADAS", oSqlConnection)
                    oSqlCommand.CommandType = CommandType.StoredProcedure



                    oSqlCommand.Parameters.Add("@CRG_ID", SqlDbType.Int).Value = crg_id


                    If (oSqlConnection.State = Data.ConnectionState.Closed) Then
                        oSqlConnection.Open()
                    End If

                    If (oSqlCommand.Connection.State = Data.ConnectionState.Closed) Then
                        oSqlCommand.Connection.Open()
                    End If

                    Using adapter As SqlDataAdapter = New SqlDataAdapter
                        adapter.SelectCommand = oSqlCommand
                        adapter.Fill(_listadoGuias)
                    End Using

                    If (oSqlCommand.Connection.State = Data.ConnectionState.Open) Then
                        oSqlCommand.Connection.Close()
                    End If

                    If (oSqlConnection.State = Data.ConnectionState.Open) Then
                        oSqlConnection.Close()
                    End If

                End Using
            End Using

            Return _listadoGuias

        Catch ex As Exception
            Return Nothing
        End Try

    End Function


    Public Function ValidaExisteGuiaenRuta(ByVal ruta As String, ByVal nroguia As String) As DataTable

        Try

            Dim _listadoPruebas As New DataTable
            Conexion = System.Configuration.ConfigurationManager.ConnectionStrings("ConexionHeadMark").ConnectionString

            Using oSqlConnection As SqlConnection = New SqlConnection(Conexion)
                Dim _consulta As String = String.Empty
                _consulta = "SELECT C5_CNUMDOC FROM Det_RutaGuia WHERE crg_id = " + ruta + " and C5_CNUMDOC = '" + nroguia + "'"
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



    Public Function Listar_Estados() As DataTable
        Try
            Dim _listadoPruebas As New DataTable
            Conexion = System.Configuration.ConfigurationManager.ConnectionStrings("ConexionHeadMark").ConnectionString

            Using oSqlConnection As SqlConnection = New SqlConnection(Conexion)
                Dim _consulta As String = String.Empty
                '_consulta = "SELECT DISTINCT RTRIM(LTRIM(C5_CNOMTRA)) AS C5_CNOMTRA FROM RSFACCAR..AL0018MOVC WHERE C5_CNOMTRA <> '' ORDER BY 1 ASC"
                Using oSqlCommand As SqlCommand = New SqlCommand("SPDSN_LISTAR_ESTADOS", oSqlConnection)
                    oSqlCommand.CommandType = CommandType.StoredProcedure


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
