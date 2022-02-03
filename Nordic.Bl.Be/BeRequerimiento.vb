Imports System.Data.SqlClient
Imports System.Configuration


Public Class BeRequerimiento

    Private req_id As String
    Public Property pr_req_id() As String
        Get
            Return req_id
        End Get
        Set(ByVal value As String)
            req_id = value
        End Set
    End Property

    Private req_asunto As String
    Public Property pr_req_asunto() As String
        Get
            Return req_asunto
        End Get
        Set(ByVal value As String)
            req_asunto = value
        End Set
    End Property

    Private req_descripcion As String
    Public Property pr_req_descripcion() As String
        Get
            Return req_descripcion
        End Get
        Set(ByVal value As String)
            req_descripcion = value
        End Set
    End Property


    Private usrid_solicitante As String
    Public Property pr_usrid_solicitante() As String
        Get
            Return usrid_solicitante
        End Get
        Set(ByVal value As String)
            usrid_solicitante = value
        End Set
    End Property

    Private emp_cod As String
    Public Property pr_emp_cod() As String
        Get
            Return emp_cod
        End Get
        Set(ByVal value As String)
            emp_cod = value
        End Set
    End Property

    Private est_codigo As String
    Public Property pr_est_codigo() As String
        Get
            Return est_codigo
        End Get
        Set(ByVal value As String)
            est_codigo = value
        End Set
    End Property

    Private usr_id As String
    Public Property pr_usr_id() As String
        Get
            Return usr_id
        End Get
        Set(ByVal value As String)
            usr_id = value
        End Set
    End Property

    Private req_rutaDestino As String
    Public Property pr_req_rutaDestino() As String
        Get
            Return req_rutaDestino
        End Get
        Set(ByVal value As String)
            req_rutaDestino = value
        End Set
    End Property


    Public Conexion As String

    Public Function Obtener_Solicitantes() As DataTable
        Try

            Dim _listadoPruebas As New DataTable
            Conexion = System.Configuration.ConfigurationManager.ConnectionStrings("ConexionHeadMark").ConnectionString

            Using oSqlConnection As SqlConnection = New SqlConnection(Conexion)
                Dim _consulta As String = String.Empty
                _consulta = "SELECT '0' usr_id, '--SELECCIONE--' usr_nombre UNION ALL SELECT usr_id, usr_nombre FROM Usuarios WHERE usr_estado = 'A' ORDER BY 2 ASC"
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


    Public Function Obtener_Responsables() As DataTable
        Try

            Dim _listadoPruebas As New DataTable
            Conexion = System.Configuration.ConfigurationManager.ConnectionStrings("ConexionHeadMark").ConnectionString

            Using oSqlConnection As SqlConnection = New SqlConnection(Conexion)
                Dim _consulta As String = String.Empty
                _consulta = "SELECT '0' res_id, '--TODOS--' res_nombre UNION ALL SELECT res_id, res_nombre FROM Responsable WHERE est_codigo = 'A'"
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
                _consulta = "SELECT '0' est_codigo, '--TODOS--' est_descripcion UNION ALL SELECT est_codigo,est_descripcion  FROM Estados WHERE est_codigo in ('PE','PG','CR','AN')"
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


    Public Function Obtener_Empresas() As DataTable
        Try

            Dim _listadoPruebas As New DataTable
            Conexion = System.Configuration.ConfigurationManager.ConnectionStrings("ConexionHeadMark").ConnectionString

            Using oSqlConnection As SqlConnection = New SqlConnection(Conexion)
                Dim _consulta As String = String.Empty
                _consulta = "SELECT emp_cod, emp_des FROM Empresa WHERE est_codigo = 'A'"
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


    Public Sub RegistrarRequerimiento(ByVal BeReque As BeRequerimiento, ByRef _tiporespuesta As String, ByRef _textorespuesta As String, ByRef idReque As String, ByRef fecHoraReg As String)
        Try
            Conexion = System.Configuration.ConfigurationManager.ConnectionStrings("ConexionHeadMark").ConnectionString

            Using oSqlConnectionMedlab As SqlConnection = New SqlConnection(Conexion)
                Using oSqlCommandMedlab As SqlCommand = New SqlCommand("SPDSN_REGISTRAR_REQUERIMIENTOS_GENERAL", oSqlConnectionMedlab)
                    oSqlCommandMedlab.CommandType = CommandType.StoredProcedure

                    oSqlCommandMedlab.Parameters.Add("@req_asunto", SqlDbType.VarChar, 100).Value = BeReque.pr_req_asunto
                    oSqlCommandMedlab.Parameters.Add("@req_descripcion", SqlDbType.VarChar, 8000).Value = BeReque.pr_req_descripcion
                    oSqlCommandMedlab.Parameters.Add("@usrid_solicitante", SqlDbType.Int).Value = BeReque.pr_usrid_solicitante
                    oSqlCommandMedlab.Parameters.Add("@emp_cod", SqlDbType.VarChar, 4).Value = BeReque.pr_emp_cod
                    oSqlCommandMedlab.Parameters.Add("@usr_id", SqlDbType.Int).Value = BeReque.pr_usr_id


                    If (oSqlConnectionMedlab.State = ConnectionState.Closed) Then
                        oSqlConnectionMedlab.Open()
                    End If

                    If (oSqlCommandMedlab.Connection.State = ConnectionState.Closed) Then
                        oSqlCommandMedlab.Connection.Open()
                    End If

                    Using oSqlDataReader As SqlDataReader = oSqlCommandMedlab.ExecuteReader(CommandBehavior.SingleRow)
                        If oSqlDataReader.Read Then
                            _tiporespuesta = oSqlDataReader.GetValue(0).ToString()
                            _textorespuesta = oSqlDataReader.GetValue(1).ToString()
                            idReque = oSqlDataReader.GetValue(2).ToString()
                            fecHoraReg = oSqlDataReader.GetValue(3).ToString()
                        End If
                        oSqlDataReader.Close()
                    End Using

                    If (oSqlCommandMedlab.Connection.State = ConnectionState.Open) Then
                        oSqlCommandMedlab.Connection.Close()
                    End If

                    If (oSqlConnectionMedlab.State = ConnectionState.Open) Then
                        oSqlConnectionMedlab.Close()
                    End If
                End Using
            End Using



        Catch ex As Exception
            _tiporespuesta = "0"
            _textorespuesta = ex.Message
        End Try
    End Sub



    Sub SaveAttachments(ByVal req_id As String, ByVal ruta As String, ByVal filename As String, ByVal ra_id As String, ByRef _tiporespuesta As String, ByRef _textorespuesta As String)
        Dim cantidad As Integer = 0
        Try
            Conexion = System.Configuration.ConfigurationManager.ConnectionStrings("ConexionHeadMark").ConnectionString

            Using oSqlConnection As SqlConnection = New SqlConnection(Conexion)
                Using oSqlCommand As SqlCommand = New SqlCommand("SPDSN_REGISTRAR_ATTACHMENT_REQUERIMIENTOS", oSqlConnection)
                    oSqlCommand.CommandType = CommandType.StoredProcedure

                    oSqlCommand.Parameters.Add("@req_id", SqlDbType.Int).Value = req_id
                    oSqlCommand.Parameters.Add("@ruta", SqlDbType.VarChar, 8000).Value = ruta
                    oSqlCommand.Parameters.Add("@filename", SqlDbType.VarChar, 8000).Value = filename
                    oSqlCommand.Parameters.Add("@rd_id", SqlDbType.Int).Value = ra_id

                    If (oSqlConnection.State = ConnectionState.Closed) Then
                        oSqlConnection.Open()
                    End If
                    If (oSqlCommand.Connection.State = ConnectionState.Closed) Then
                        oSqlCommand.Connection.Open()
                    End If

                    cantidad = CInt(oSqlCommand.ExecuteNonQuery)

                    If cantidad > 0 Then
                        _tiporespuesta = 1
                        _textorespuesta = "Se actualizaron los datos"
                    Else
                        _tiporespuesta = 0
                        _textorespuesta = "No se actualizaron datos"
                    End If

                    If (oSqlCommand.Connection.State = ConnectionState.Open) Then
                        oSqlCommand.Connection.Close()
                    End If
                    If (oSqlConnection.State = ConnectionState.Open) Then
                        oSqlConnection.Close()
                    End If
                End Using
            End Using


        Catch ex As Exception

        End Try
    End Sub



    Public Function Listar_Requerimientos(ByVal flag As String, ByVal fecini As String, ByVal fecfin As String, ByVal res_id As String, ByVal est_codigo As String) As DataTable
        Try
            Dim _listadoPruebas As New DataTable
            Conexion = System.Configuration.ConfigurationManager.ConnectionStrings("ConexionHeadMark").ConnectionString

            Using oSqlConnection As SqlConnection = New SqlConnection(Conexion)
                Dim _consulta As String = String.Empty

                Using oSqlCommand As SqlCommand = New SqlCommand("SPDSN_LISTAR_REQUERIMIENTOS_XFILTROS", oSqlConnection)
                    oSqlCommand.CommandType = CommandType.StoredProcedure
                    oSqlCommand.Parameters.Add("@FLAG", SqlDbType.Int).Value = flag
                    oSqlCommand.Parameters.Add("@FECINI", SqlDbType.VarChar, 20).Value = fecini
                    oSqlCommand.Parameters.Add("@FECFIN", SqlDbType.VarChar, 20).Value = fecfin
                    oSqlCommand.Parameters.Add("@RES_ID", SqlDbType.Int).Value = res_id
                    oSqlCommand.Parameters.Add("@EST_CODIGO", SqlDbType.Char, 2).Value = est_codigo

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



    Public Function Listar_Documentos_Adjuntos(ByVal idReq As String) As DataTable
        Try
            Dim _listadoPruebas As New DataTable
            Conexion = System.Configuration.ConfigurationManager.ConnectionStrings("ConexionHeadMark").ConnectionString

            Using oSqlConnection As SqlConnection = New SqlConnection(Conexion)
                Dim _consulta As String = String.Empty

                Using oSqlCommand As SqlCommand = New SqlCommand("SPDSN_LISTAR_DOCUMENTOS_ADJUNTOS", oSqlConnection)
                    oSqlCommand.CommandType = CommandType.StoredProcedure
                    oSqlCommand.Parameters.Add("@id", SqlDbType.Int).Value = idReq


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



    Public Function Listar_Observaciones(ByVal idReq As String) As DataTable
        Try
            Dim _listadoPruebas As New DataTable
            Conexion = System.Configuration.ConfigurationManager.ConnectionStrings("ConexionHeadMark").ConnectionString

            Using oSqlConnection As SqlConnection = New SqlConnection(Conexion)
                Dim _consulta As String = String.Empty

                Using oSqlCommand As SqlCommand = New SqlCommand("SPDSN_LISTAR_REQOBSERVACIONES", oSqlConnection)
                    oSqlCommand.CommandType = CommandType.StoredProcedure
                    oSqlCommand.Parameters.Add("@req_id", SqlDbType.Int).Value = idReq


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


    Public Sub Cerrar_Requerimiento(ByVal req_id As String, ByVal usr_id As String, ByRef _tiporespuesta As String, ByRef _textorespuesta As String)
        Try
            Conexion = System.Configuration.ConfigurationManager.ConnectionStrings("ConexionHeadMark").ConnectionString

            Using oSqlConnectionMedlab As SqlConnection = New SqlConnection(Conexion)
                Using oSqlCommandMedlab As SqlCommand = New SqlCommand("SPDSN_CERRAR_REQUERIMIENTO", oSqlConnectionMedlab)
                    oSqlCommandMedlab.CommandType = CommandType.StoredProcedure

                    oSqlCommandMedlab.Parameters.Add("@req_id", SqlDbType.Int).Value = req_id
                    oSqlCommandMedlab.Parameters.Add("@usr_id", SqlDbType.Int).Value = usr_id

                    If (oSqlConnectionMedlab.State = ConnectionState.Closed) Then
                        oSqlConnectionMedlab.Open()
                    End If

                    If (oSqlCommandMedlab.Connection.State = ConnectionState.Closed) Then
                        oSqlCommandMedlab.Connection.Open()
                    End If

                    Using oSqlDataReader As SqlDataReader = oSqlCommandMedlab.ExecuteReader(CommandBehavior.SingleRow)
                        If oSqlDataReader.Read Then
                            _tiporespuesta = oSqlDataReader.GetValue(0).ToString()
                            _textorespuesta = oSqlDataReader.GetValue(1).ToString()
                            'idReque = oSqlDataReader.GetValue(2).ToString()
                            'fecHoraReg = oSqlDataReader.GetValue(3).ToString()
                        End If
                        oSqlDataReader.Close()
                    End Using

                    If (oSqlCommandMedlab.Connection.State = ConnectionState.Open) Then
                        oSqlCommandMedlab.Connection.Close()
                    End If

                    If (oSqlConnectionMedlab.State = ConnectionState.Open) Then
                        oSqlConnectionMedlab.Close()
                    End If
                End Using
            End Using



        Catch ex As Exception
            _tiporespuesta = "0"
            _textorespuesta = ex.Message
        End Try
    End Sub


    Public Sub Anular_Requerimiento(ByVal req_id As String, ByVal usr_id As String, ByRef _tiporespuesta As String, ByRef _textorespuesta As String)
        Try
            Conexion = System.Configuration.ConfigurationManager.ConnectionStrings("ConexionHeadMark").ConnectionString

            Using oSqlConnectionMedlab As SqlConnection = New SqlConnection(Conexion)
                Using oSqlCommandMedlab As SqlCommand = New SqlCommand("SPDSN_ANULAR_REQUERIMIENTO", oSqlConnectionMedlab)
                    oSqlCommandMedlab.CommandType = CommandType.StoredProcedure

                    oSqlCommandMedlab.Parameters.Add("@req_id", SqlDbType.Int).Value = req_id
                    oSqlCommandMedlab.Parameters.Add("@usr_id", SqlDbType.Int).Value = usr_id

                    If (oSqlConnectionMedlab.State = ConnectionState.Closed) Then
                        oSqlConnectionMedlab.Open()
                    End If

                    If (oSqlCommandMedlab.Connection.State = ConnectionState.Closed) Then
                        oSqlCommandMedlab.Connection.Open()
                    End If

                    Using oSqlDataReader As SqlDataReader = oSqlCommandMedlab.ExecuteReader(CommandBehavior.SingleRow)
                        If oSqlDataReader.Read Then
                            _tiporespuesta = oSqlDataReader.GetValue(0).ToString()
                            _textorespuesta = oSqlDataReader.GetValue(1).ToString()
                            'idReque = oSqlDataReader.GetValue(2).ToString()
                            'fecHoraReg = oSqlDataReader.GetValue(3).ToString()
                        End If
                        oSqlDataReader.Close()
                    End Using

                    If (oSqlCommandMedlab.Connection.State = ConnectionState.Open) Then
                        oSqlCommandMedlab.Connection.Close()
                    End If

                    If (oSqlConnectionMedlab.State = ConnectionState.Open) Then
                        oSqlConnectionMedlab.Close()
                    End If
                End Using
            End Using



        Catch ex As Exception
            _tiporespuesta = "0"
            _textorespuesta = ex.Message
        End Try
    End Sub


    Public Sub RegistrarObservacion(ByVal req_id As String, ByVal observacion As String, ByVal usr_id As String, ByRef _tiporespuesta As String, ByRef _textorespuesta As String, ByRef idProg As String, ByRef fecHoraReg As String)
        Try
            Conexion = System.Configuration.ConfigurationManager.ConnectionStrings("ConexionHeadMark").ConnectionString

            Using oSqlConnectionMedlab As SqlConnection = New SqlConnection(Conexion)
                Using oSqlCommandMedlab As SqlCommand = New SqlCommand("SPDSN_REGISTRAR_REQOBSERVACION", oSqlConnectionMedlab)
                    oSqlCommandMedlab.CommandType = CommandType.StoredProcedure

                    oSqlCommandMedlab.Parameters.Add("@req_id", SqlDbType.Int).Value = req_id
                    oSqlCommandMedlab.Parameters.Add("@rob_observacion", SqlDbType.VarChar, 500).Value = observacion
                    oSqlCommandMedlab.Parameters.Add("@usr_id", SqlDbType.Int).Value = usr_id

                    If (oSqlConnectionMedlab.State = ConnectionState.Closed) Then
                        oSqlConnectionMedlab.Open()
                    End If

                    If (oSqlCommandMedlab.Connection.State = ConnectionState.Closed) Then
                        oSqlCommandMedlab.Connection.Open()
                    End If

                    Using oSqlDataReader As SqlDataReader = oSqlCommandMedlab.ExecuteReader(CommandBehavior.SingleRow)
                        If oSqlDataReader.Read Then
                            _tiporespuesta = oSqlDataReader.GetValue(0).ToString()
                            _textorespuesta = oSqlDataReader.GetValue(1).ToString()
                            idProg = oSqlDataReader.GetValue(2).ToString()
                            fecHoraReg = oSqlDataReader.GetValue(3).ToString()
                        End If
                        oSqlDataReader.Close()
                    End Using

                    If (oSqlCommandMedlab.Connection.State = ConnectionState.Open) Then
                        oSqlCommandMedlab.Connection.Close()
                    End If

                    If (oSqlConnectionMedlab.State = ConnectionState.Open) Then
                        oSqlConnectionMedlab.Close()
                    End If
                End Using
            End Using



        Catch ex As Exception
            _tiporespuesta = "0"
            _textorespuesta = ex.Message
        End Try
    End Sub



End Class
