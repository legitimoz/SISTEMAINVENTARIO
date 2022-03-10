Imports System.Data.SqlClient
Imports System.Configuration

<Serializable()> Public Class BeCabReque

    Private _listaItem As List(Of DetReque)
    Public Property prListaItem() As List(Of DetReque)
        Get
            Return _listaItem
        End Get
        Set(ByVal value As List(Of DetReque))
            _listaItem = value
        End Set
    End Property

    Private cre_id As String
    Public Property pr_cre_id() As String
        Get
            Return cre_id
        End Get
        Set(ByVal value As String)
            cre_id = value
        End Set
    End Property

    Private sol_id As String
    Public Property pr_sol_id() As String
        Get
            Return sol_id
        End Get
        Set(ByVal value As String)
            sol_id = value
        End Set
    End Property


    Private codcli As String
    Public Property pr_codcli() As String
        Get
            Return codcli
        End Get
        Set(ByVal value As String)
            codcli = value
        End Set
    End Property

    Private nomcli As String
    Public Property pr_nomcli() As String
        Get
            Return nomcli
        End Get
        Set(ByVal value As String)
            nomcli = value
        End Set
    End Property

    Private cvende As String
    Public Property pr_cvende() As String
        Get
            Return cvende
        End Get
        Set(ByVal value As String)
            cvende = value
        End Set
    End Property

    Private cvende2 As String
    Public Property pr_cvende2() As String
        Get
            Return cvende2
        End Get
        Set(ByVal value As String)
            cvende2 = value
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

    Private cre_obs As String
    Public Property pr_creobs() As String
        Get
            Return cre_obs
        End Get
        Set(ByVal value As String)
            cre_obs = value
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

    Private usrmod_id As String
    Public Property pr_usrmod_id() As String
        Get
            Return usrmod_id
        End Get
        Set(ByVal value As String)
            usrmod_id = value
        End Set
    End Property

    Private cre_fecEnt As String
    Public Property pr_cre_fecEnt() As String
        Get
            Return cre_fecEnt
        End Get
        Set(ByVal value As String)
            cre_fecEnt = value
        End Set
    End Property


    Public Conexion As String = String.Empty

    Public Function Obtener_Estados() As DataTable
        Try

            Dim _listadoPruebas As New DataTable
            Conexion = System.Configuration.ConfigurationManager.ConnectionStrings("ConexionHeadMark").ConnectionString

            Using oSqlConnection As SqlConnection = New SqlConnection(Conexion)
                Dim _consulta As String = String.Empty
                _consulta = "SELECT '0' est_codigo, '--SELECCIONE--' est_descripcion UNION ALL SELECT est_codigo,est_descripcion FROM Estados WHERE est_codigo in ('PE','AN')
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



    Public Function Serializar_Requerimiento(ByVal _BeCabReque As BeCabReque) As String
        Dim _oStringWriter As IO.StringWriter
        Dim _listaSerializada As String = String.Empty
        Dim _oSerialization As Xml.Serialization.XmlSerializer
        Try
            '  _oBeCargo = New BeCargo
            _oStringWriter = New IO.StringWriter
            _oSerialization = New Xml.Serialization.XmlSerializer(_BeCabReque.GetType)
            _oSerialization.Serialize(_oStringWriter, _BeCabReque)
            _listaSerializada = _oStringWriter.ToString()

            Return _listaSerializada

        Catch ex As Exception
            Return ""

        End Try

    End Function


    Public Sub RegistrarRequerimiento(ByVal _xmlserializado As String, ByRef _tiporespuesta As String, ByRef _textorespuesta As String, ByRef idRentabilidad As String, ByRef fecHoraReg As String)
        Try
            Conexion = System.Configuration.ConfigurationManager.ConnectionStrings("ConexionHeadMark").ConnectionString

            Using oSqlConnectionMedlab As SqlConnection = New SqlConnection(Conexion)
                Using oSqlCommandMedlab As SqlCommand = New SqlCommand("SPDSN_REGISTRAR_REQUERIMIENTO", oSqlConnectionMedlab)
                    oSqlCommandMedlab.CommandType = CommandType.StoredProcedure

                    oSqlCommandMedlab.Parameters.Add("@Xml", SqlDbType.Xml).Value = _xmlserializado
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
                            idRentabilidad = oSqlDataReader.GetValue(2).ToString()
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


    Public Sub ActualizarRequerimiento(ByVal _xmlserializado As String, ByRef _tiporespuesta As String, ByRef _textorespuesta As String, ByRef idRentabilidad As String, ByRef fecHoraReg As String)
        Try
            Conexion = System.Configuration.ConfigurationManager.ConnectionStrings("ConexionHeadMark").ConnectionString

            Using oSqlConnectionMedlab As SqlConnection = New SqlConnection(Conexion)
                Using oSqlCommandMedlab As SqlCommand = New SqlCommand("SPDSN_ACTUALIZAR_REQUERIMIENTO", oSqlConnectionMedlab)
                    oSqlCommandMedlab.CommandType = CommandType.StoredProcedure

                    oSqlCommandMedlab.Parameters.Add("@Xml", SqlDbType.Xml).Value = _xmlserializado
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
                            idRentabilidad = oSqlDataReader.GetValue(2).ToString()
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


    Public Sub ActualizacionMasivaValorizada(ByVal _xmlserializado As String, ByRef _tiporespuesta As String, ByRef _textorespuesta As String)
        Try
            Conexion = System.Configuration.ConfigurationManager.ConnectionStrings("ConexionHeadMark").ConnectionString

            Using oSqlConnectionMedlab As SqlConnection = New SqlConnection(Conexion)
                Using oSqlCommandMedlab As SqlCommand = New SqlCommand("SPDSN_ACTUALIZACION_MASIVA_VALORIZADA", oSqlConnectionMedlab)
                    oSqlCommandMedlab.CommandType = CommandType.StoredProcedure

                    oSqlCommandMedlab.Parameters.Add("@Xml", SqlDbType.Xml).Value = _xmlserializado
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
                            'idRentabilidad = oSqlDataReader.GetValue(2).ToString()
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


    Public Function Filtros_Requerimientos(ByVal flag As Integer, ByVal fec1 As String, ByVal fec2 As String, ByVal cvend2 As String, ByVal nomcli As String) As DataTable
        Try
            Dim _listadoPruebas As New DataTable
            Conexion = System.Configuration.ConfigurationManager.ConnectionStrings("ConexionHeadMark").ConnectionString

            Using oSqlConnection As SqlConnection = New SqlConnection(Conexion)
                Dim _consulta As String = String.Empty

                Using oSqlCommand As SqlCommand = New SqlCommand("SPDSN_LISTAR_REQUERIMIENTOS_CABECERA", oSqlConnection)
                    oSqlCommand.CommandType = CommandType.StoredProcedure
                    oSqlCommand.Parameters.Add("@flag", SqlDbType.Int).Value = flag
                    oSqlCommand.Parameters.Add("@FEC1", SqlDbType.VarChar, 10).Value = fec1
                    oSqlCommand.Parameters.Add("@FEC2", SqlDbType.VarChar, 10).Value = fec2
                    oSqlCommand.Parameters.Add("@CVEND2", SqlDbType.VarChar, 5).Value = cvend2
                    oSqlCommand.Parameters.Add("@CL_NOMCLI", SqlDbType.VarChar, 50).Value = nomcli



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



    Public Function Filtros_Requerimientos_Detalle(ByVal idReq As Integer) As DataTable
        Try
            Dim _listadoPruebas As New DataTable
            Conexion = System.Configuration.ConfigurationManager.ConnectionStrings("ConexionHeadMark").ConnectionString

            Using oSqlConnection As SqlConnection = New SqlConnection(Conexion)
                Dim _consulta As String = String.Empty

                Using oSqlCommand As SqlCommand = New SqlCommand("SPDSN_LISTAR_REQUERIMIENTOS_DETALLE", oSqlConnection)
                    oSqlCommand.CommandType = CommandType.StoredProcedure
                    oSqlCommand.Parameters.Add("@CRE_ID", SqlDbType.Int).Value = idReq


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



    Public Function Listar_Vendedores(ByVal flag As String, ByVal nombre As String) As DataTable
        Try

            Dim _listadoPruebas As New DataTable
            Conexion = System.Configuration.ConfigurationManager.ConnectionStrings("ConexionHeadMark").ConnectionString

            Using oSqlConnection As SqlConnection = New SqlConnection(Conexion)
                Dim _consulta As String = String.Empty

                If flag = "0" Then
                    _consulta = "SELECT VE_CCODIGO as CODIGO, VE_CNOMBRE as NOMBRE FROM RSFACCAR..FT0018VEND  WHERE VE_CTIPVEN = 'V'"
                End If

                If flag = "1" Then
                    _consulta = "SELECT VE_CCODIGO as CODIGO, VE_CNOMBRE as NOMBRE FROM RSFACCAR..FT0018VEND  WHERE VE_CTIPVEN = 'V' and VE_CNOMBRE like '%" + nombre + "%'"
                End If


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


    Public Function Obtener_Cabecera_Requerimiento(ByVal cre_id As String) As DataTable
        Try
            Dim _listadoPruebas As New DataTable
            Conexion = System.Configuration.ConfigurationManager.ConnectionStrings("ConexionHeadMark").ConnectionString

            Using oSqlConnection As SqlConnection = New SqlConnection(Conexion)
                Dim _consulta As String = String.Empty

                Using oSqlCommand As SqlCommand = New SqlCommand("SPDSN_OBTENER_CAB_REQUERIMIENTO", oSqlConnection)
                    oSqlCommand.CommandType = CommandType.StoredProcedure
                    oSqlCommand.Parameters.Add("@cre_id", SqlDbType.BigInt).Value = cre_id

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




    Public Function Filtros_Requerimientos_Detalle_fechas(ByVal fec1 As String, ByVal fec2 As String) As DataTable
        Try
            Dim _listadoPruebas As New DataTable
            Conexion = System.Configuration.ConfigurationManager.ConnectionStrings("ConexionHeadMark").ConnectionString

            Using oSqlConnection As SqlConnection = New SqlConnection(Conexion)
                Dim _consulta As String = String.Empty

                Using oSqlCommand As SqlCommand = New SqlCommand("SPDSN_LISTAR_REQUERIMIENTOS_DETALLE_FECHAS", oSqlConnection)
                    oSqlCommand.CommandType = CommandType.StoredProcedure
                    oSqlCommand.Parameters.Add("@fec1", SqlDbType.VarChar, 20).Value = fec1
                    oSqlCommand.Parameters.Add("@fec2", SqlDbType.VarChar, 20).Value = fec2


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


    Public Function Control_Requerimientos_Detalle(ByVal flag As Integer, ByVal fec1 As String, ByVal fec2 As String, ByVal c_vende2 As String, ByVal ar_id As String) As DataTable
        Try
            Dim _listadoPruebas As New DataTable
            Conexion = System.Configuration.ConfigurationManager.ConnectionStrings("ConexionHeadMark").ConnectionString

            Using oSqlConnection As SqlConnection = New SqlConnection(Conexion)
                Dim _consulta As String = String.Empty

                Using oSqlCommand As SqlCommand = New SqlCommand("SPDSN_CONTROL_REQUERIMIENTOS_DETALLE", oSqlConnection)
                    oSqlCommand.CommandType = CommandType.StoredProcedure

                    oSqlCommand.Parameters.Add("@flag", SqlDbType.Int).Value = flag
                    oSqlCommand.Parameters.Add("@fec1", SqlDbType.VarChar, 20).Value = fec1
                    oSqlCommand.Parameters.Add("@fec2", SqlDbType.VarChar, 20).Value = fec2
                    oSqlCommand.Parameters.Add("@cl_cvende2", SqlDbType.VarChar, 5).Value = c_vende2
                    oSqlCommand.Parameters.Add("@ar_id", SqlDbType.Int).Value = ar_id


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


    Public Function Control_Requerimientos_Detalle_xProducto(ByVal fec1 As String, ByVal fec2 As String, ByVal ar_id As String) As DataTable
        Try
            Dim _listadoPruebas As New DataTable
            Conexion = System.Configuration.ConfigurationManager.ConnectionStrings("ConexionHeadMark").ConnectionString

            Using oSqlConnection As SqlConnection = New SqlConnection(Conexion)
                Dim _consulta As String = String.Empty

                Using oSqlCommand As SqlCommand = New SqlCommand("SPDSN_CONTROL_REQUERIMIENTOS_DETALLE", oSqlConnection)
                    oSqlCommand.CommandType = CommandType.StoredProcedure
                    oSqlCommand.Parameters.Add("@fec1", SqlDbType.VarChar, 20).Value = fec1
                    oSqlCommand.Parameters.Add("@fec2", SqlDbType.VarChar, 20).Value = fec2


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
