Imports System.Data.SqlClient
Imports System.Configuration



Public Class BeSolicitudInstitucional

    Public Conexion As String = String.Empty

    Public Function Listar_Clientes(ByVal flag As Integer, ByVal Cliente As String) As DataTable
        Try
            Dim _listadoPruebas As New DataTable
            Conexion = System.Configuration.ConfigurationManager.ConnectionStrings("ConexionHeadMark").ConnectionString

            Using oSqlConnection As SqlConnection = New SqlConnection(Conexion)
                Dim _consulta As String = String.Empty

                Using oSqlCommand As SqlCommand = New SqlCommand("SPDSN_LISTAR_CLIENTES", oSqlConnection)
                    oSqlCommand.CommandType = CommandType.StoredProcedure
                    oSqlCommand.Parameters.Add("@flag", SqlDbType.Int).Value = flag
                    oSqlCommand.Parameters.Add("@cliente", SqlDbType.VarChar, 50).Value = Cliente


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



    Public Function Listar_Adjuntos_x_Solicitud(ByVal sol_id As String) As DataTable
        Try

            Dim _listadoPruebas As New DataTable
            Conexion = System.Configuration.ConfigurationManager.ConnectionStrings("ConexionHeadMark").ConnectionString

            Using oSqlConnection As SqlConnection = New SqlConnection(Conexion)
                Dim _consulta As String = String.Empty
                _consulta = "SELECT id, filename, ruta FROM [dbo].[AttachmentsCoti] WHERE sol_id=" + sol_id
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



    Public Function Obtener_MotivosAnulacionSolicitud() As DataTable
        Try

            Dim _listadoPruebas As New DataTable
            Conexion = System.Configuration.ConfigurationManager.ConnectionStrings("ConexionHeadMark").ConnectionString

            Using oSqlConnection As SqlConnection = New SqlConnection(Conexion)
                Dim _consulta As String = String.Empty
                _consulta = "SELECT '0' mot_id, '--SELECCIONE--' mot_des UNION ALL SELECT mot_id, mot_des FROM MotivoAnulacionCotizacion WHERE mot_est='A'   
"
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


    Public Function Obtener_Cotizadores() As DataTable
        Try

            Dim _listadoPruebas As New DataTable
            Conexion = System.Configuration.ConfigurationManager.ConnectionStrings("ConexionHeadMark").ConnectionString

            Using oSqlConnection As SqlConnection = New SqlConnection(Conexion)
                Dim _consulta As String = String.Empty
                _consulta = "SELECT '0' cot_codigo, '--TODOS--' cot_nombre UNION ALL SELECT cot_codigo, (cot_nombre +' - '+ cot_codigo) cot_nombre  FROM Cotizadores WHERE cot_est = 'A'   
"
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


    Public Function Obtener_Productos() As DataTable
        Try

            Dim _listadoPruebas As New DataTable
            Conexion = System.Configuration.ConfigurationManager.ConnectionStrings("ConexionHeadMark").ConnectionString

            Using oSqlConnection As SqlConnection = New SqlConnection(Conexion)
                Dim _consulta As String = String.Empty
                '_consulta = "SELECT 0 ar_id,'--SELECCIONE--' articulo UNION ALL SELECT ar_id, (rtrim(ar_codigo) +' - '+ ar_cdescri) articulo  FROM [dbo].[Articulos] order by 2 asc"
                _consulta = "SELECT ar_id, ar_cdescri articulo  FROM [dbo].[Articulos] order by 2 asc"

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



    Public Function Registrar_SolicitudAnulada(ByVal sol_id As Integer, ByVal mot_id As String, ByVal usr_id As Integer, ByVal sol_anudes As String) As Integer
        Try
            Dim filasAfectadas As Integer = 0

            Conexion = System.Configuration.ConfigurationManager.ConnectionStrings("ConexionHeadMark").ConnectionString


            Using oSqlConnectionMedlab As SqlConnection = New SqlConnection(Conexion)
                Using oSqlCommandMedlab As SqlCommand = New SqlCommand("SPDSN_REGISTRAR_ANULACION_SOLICITUD", oSqlConnectionMedlab)
                    oSqlCommandMedlab.CommandType = CommandType.StoredProcedure

                    oSqlCommandMedlab.Parameters.Add("@sol_id", SqlDbType.BigInt).Value = sol_id
                    oSqlCommandMedlab.Parameters.Add("@mot_id", SqlDbType.Int).Value = mot_id
                    oSqlCommandMedlab.Parameters.Add("@usr_id", SqlDbType.Int).Value = usr_id
                    oSqlCommandMedlab.Parameters.Add("@sol_anudes", SqlDbType.VarChar, 50).Value = sol_anudes

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


    Public Function Asignar_Cliente_Solicitud(ByVal sol_id As Integer, ByVal ruc As String, ByVal nomcli As String, ByVal codvend As String, ByVal codCoti As String, ByVal usr_id As String) As Integer
        Try
            Dim filasAfectadas As Integer = 0

            Conexion = System.Configuration.ConfigurationManager.ConnectionStrings("ConexionHeadMark").ConnectionString


            Using oSqlConnectionMedlab As SqlConnection = New SqlConnection(Conexion)
                Using oSqlCommandMedlab As SqlCommand = New SqlCommand("SPDSN_ASIGNAR_CLIENTE_SOLICITUD", oSqlConnectionMedlab)
                    oSqlCommandMedlab.CommandType = CommandType.StoredProcedure

                    oSqlCommandMedlab.Parameters.Add("@sol_id", SqlDbType.BigInt).Value = sol_id
                    oSqlCommandMedlab.Parameters.Add("@CL_CCODCLI", SqlDbType.Char, 8).Value = ruc
                    oSqlCommandMedlab.Parameters.Add("@CL_CNOMCLI", SqlDbType.VarChar, 80).Value = nomcli
                    oSqlCommandMedlab.Parameters.Add("@CL_CVENDE", SqlDbType.Char, 5).Value = codvend
                    oSqlCommandMedlab.Parameters.Add("@CL_CVENDE2", SqlDbType.Char, 5).Value = codCoti
                    oSqlCommandMedlab.Parameters.Add("@usr_id", SqlDbType.Int).Value = usr_id



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



    Public Function Listar_Solicitudes(ByVal flag As Integer, ByVal fecIni As String, ByVal fecFin As String) As DataTable
        Try
            Dim _listadoPruebas As New DataTable
            Conexion = System.Configuration.ConfigurationManager.ConnectionStrings("ConexionHeadMark").ConnectionString

            Using oSqlConnection As SqlConnection = New SqlConnection(Conexion)
                Dim _consulta As String = String.Empty

                Using oSqlCommand As SqlCommand = New SqlCommand("SPDSN_LISTAR_SOLICITUDES_INSTITUCIONAL", oSqlConnection)
                    oSqlCommand.CommandType = CommandType.StoredProcedure
                    oSqlCommand.Parameters.Add("@flag", SqlDbType.Int).Value = flag
                    oSqlCommand.Parameters.Add("@fecIni", SqlDbType.VarChar, 20).Value = fecIni
                    oSqlCommand.Parameters.Add("@fecFin", SqlDbType.VarChar, 20).Value = fecFin


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
