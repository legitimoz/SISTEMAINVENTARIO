Imports System.Data.SqlClient
Imports System.Configuration


Public Class BeArticulos

    Private ar_id As Integer
    Public Property prAr_id() As Integer
        Get
            Return ar_id
        End Get
        Set(ByVal value As Integer)
            ar_id = value
        End Set
    End Property

    Private ar_codigo As String
    Public Property prAr_codigo() As String
        Get
            Return ar_codigo
        End Get
        Set(ByVal value As String)
            ar_codigo = value
        End Set
    End Property

    Private ar_des As String
    Public Property prAr_des() As String
        Get
            Return ar_des
        End Get
        Set(ByVal value As String)
            ar_des = value
        End Set
    End Property

    Private ar_des2 As String
    Public Property prAr_des2() As String
        Get
            Return ar_des2
        End Get
        Set(ByVal value As String)
            ar_des2 = value
        End Set
    End Property

    Private ar_unidad As String
    Public Property prAr_unidad() As String
        Get
            Return ar_unidad
        End Get
        Set(ByVal value As String)
            ar_unidad = value
        End Set
    End Property

    Private pre_id As Integer
    Public Property prPre_id() As Integer
        Get
            Return pre_id
        End Get
        Set(ByVal value As Integer)
            pre_id = value
        End Set
    End Property

    Private vdu_id As Integer
    Public Property prVdu_id() As Integer
        Get
            Return vdu_id
        End Get
        Set(ByVal value As Integer)
            vdu_id = value
        End Set
    End Property


    Private pa_id As Integer
    Public Property prPa_id() As Integer
        Get
            Return pa_id
        End Get
        Set(ByVal value As Integer)
            pa_id = value
        End Set
    End Property


    Private fab_id As Integer
    Public Property prFab_id() As Integer
        Get
            Return fab_id
        End Get
        Set(ByVal value As Integer)
            fab_id = value
        End Set
    End Property

    Private est_codigo As String
    Public Property prEst_codigo() As String
        Get
            Return est_codigo
        End Get
        Set(ByVal value As String)
            est_codigo = value
        End Set
    End Property


    Private usr_id As Integer
    Public Property prUsr_id() As Integer
        Get
            Return usr_id
        End Get
        Set(ByVal value As Integer)
            usr_id = value
        End Set
    End Property


    Public Function Obtener_Unidades() As DataTable
        Try

            Dim _listadoPruebas As New DataTable
            Conexion = System.Configuration.ConfigurationManager.ConnectionStrings("ConexionHeadMark").ConnectionString

            Using oSqlConnection As SqlConnection = New SqlConnection(Conexion)
                Dim _consulta As String = String.Empty
                _consulta = "SELECT '0' und_codigo, '--SELECCIONE--' und_des UNION ALL SELECT und_codigo,und_des FROM BDLABFAR..Unidades WHERE und_est = 'A'"
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




    Public Function Obtener_Presentaciones() As DataTable
        Try

            Dim _listadoPruebas As New DataTable
            Conexion = System.Configuration.ConfigurationManager.ConnectionStrings("ConexionHeadMark").ConnectionString

            Using oSqlConnection As SqlConnection = New SqlConnection(Conexion)
                Dim _consulta As String = String.Empty
                _consulta = "SELECT '0' pre_id, '--SELECCIONE--' pre_desc UNION ALL SELECT pre_id, pre_desc FROM BDLABFAR..Presentacion WHERE pre_est = 'A'"
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


    Public Function Obtener_VidaUtil() As DataTable
        Try

            Dim _listadoPruebas As New DataTable
            Conexion = System.Configuration.ConfigurationManager.ConnectionStrings("ConexionHeadMark").ConnectionString

            Using oSqlConnection As SqlConnection = New SqlConnection(Conexion)
                Dim _consulta As String = String.Empty
                _consulta = "SELECT '0' vdu_id, '--SELECCIONE--' vdu_des UNION ALL SELECT vdu_id, convert(varchar,vdu_des)  vdu_des FROM BDLABFAR..Vida_Util WHERE vdu_est = 'A'"
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



    Public Function Obtener_PaisOrigen() As DataTable
        Try

            Dim _listadoPruebas As New DataTable
            Conexion = System.Configuration.ConfigurationManager.ConnectionStrings("ConexionHeadMark").ConnectionString

            Using oSqlConnection As SqlConnection = New SqlConnection(Conexion)
                Dim _consulta As String = String.Empty
                _consulta = "SELECT '0' pa_id, '--SELECCIONE--' pa_des UNION ALL SELECT pa_id, pa_des FROM BDLABFAR..Pais_Origen WHERE pa_est = 'A'"
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



    Public Function Obtener_Fabricantes() As DataTable
        Try

            Dim _listadoPruebas As New DataTable
            Conexion = System.Configuration.ConfigurationManager.ConnectionStrings("ConexionHeadMark").ConnectionString

            Using oSqlConnection As SqlConnection = New SqlConnection(Conexion)
                Dim _consulta As String = String.Empty
                _consulta = "SELECT '0' fab_id, '--SELECCIONE--' fab_des UNION ALL SELECT fab_id,fab_des FROM BDLABFAR..Fabricante WHERE fab_est = 'A'"
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


    Public Function Obtener_Estados() As DataTable
        Try

            Dim _listadoPruebas As New DataTable
            Conexion = System.Configuration.ConfigurationManager.ConnectionStrings("ConexionHeadMark").ConnectionString

            Using oSqlConnection As SqlConnection = New SqlConnection(Conexion)
                Dim _consulta As String = String.Empty
                _consulta = "SELECT '0' est_codigo, '--SELECCIONE--' est_descripcion UNION ALL SELECT est_codigo,est_descripcion FROM Estados WHERE est_codigo in ('AC','IN','PR')
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

    Public Conexion As String = String.Empty

    Public Function Listar_Control_Stock() As DataTable
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

                Using oSqlCommand As SqlCommand = New SqlCommand("SPDSN_STK_MESES_INVENTARIO_4", oSqlConnection)
                    oSqlCommand.CommandType = CommandType.StoredProcedure
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


    Public Sub RegistrarArticulos(ByVal beArt As BeArticulos, ByRef _tiporespuesta As String, ByRef _textorespuesta As String, ByRef ar_id As String, ByRef fecHoraReg As String)
        Try
            Conexion = System.Configuration.ConfigurationManager.ConnectionStrings("ConexionHeadMark").ConnectionString

            Using oSqlConnection As SqlConnection = New SqlConnection(Conexion)
                Using oSqlCommandMedlab As SqlCommand = New SqlCommand("SPDSN_REGISTRAR_ARTICULOS", oSqlConnection)
                    oSqlCommandMedlab.CommandType = CommandType.StoredProcedure

                    oSqlCommandMedlab.Parameters.Add("@ar_codigo", SqlDbType.VarChar, 25).Value = beArt.ar_codigo
                    oSqlCommandMedlab.Parameters.Add("@ar_cdescri", SqlDbType.VarChar, 60).Value = beArt.ar_des
                    oSqlCommandMedlab.Parameters.Add("@ar_cdescri2", SqlDbType.VarChar, 60).Value = beArt.ar_des2
                    oSqlCommandMedlab.Parameters.Add("@ar_cunidad", SqlDbType.VarChar, 3).Value = beArt.ar_unidad

                    oSqlCommandMedlab.Parameters.Add("@pre_id", SqlDbType.Int).Value = beArt.pre_id
                    oSqlCommandMedlab.Parameters.Add("@vdu_id", SqlDbType.Int).Value = beArt.prVdu_id
                    oSqlCommandMedlab.Parameters.Add("@pa_id", SqlDbType.Int).Value = beArt.prPa_id
                    oSqlCommandMedlab.Parameters.Add("@fab_id", SqlDbType.Int).Value = beArt.prFab_id
                    oSqlCommandMedlab.Parameters.Add("@est_codigo", SqlDbType.Char, 2).Value = beArt.prEst_codigo
                    oSqlCommandMedlab.Parameters.Add("@usr_id", SqlDbType.Int).Value = beArt.prUsr_id


                    If (oSqlConnection.State = ConnectionState.Closed) Then
                        oSqlConnection.Open()
                    End If

                    If (oSqlCommandMedlab.Connection.State = ConnectionState.Closed) Then
                        oSqlCommandMedlab.Connection.Open()
                    End If

                    Using oSqlDataReader As SqlDataReader = oSqlCommandMedlab.ExecuteReader(CommandBehavior.SingleRow)
                        If oSqlDataReader.Read Then

                            _tiporespuesta = oSqlDataReader.GetValue(0).ToString()
                            _textorespuesta = oSqlDataReader.GetValue(1).ToString()
                            ar_id = oSqlDataReader.GetValue(2).ToString()
                            fecHoraReg = oSqlDataReader.GetValue(3).ToString()

                        End If

                        oSqlDataReader.Close()

                    End Using

                    If (oSqlCommandMedlab.Connection.State = ConnectionState.Open) Then
                        oSqlCommandMedlab.Connection.Close()
                    End If

                    If (oSqlConnection.State = ConnectionState.Open) Then
                        oSqlConnection.Close()
                    End If
                End Using
            End Using

        Catch ex As Exception

        End Try
    End Sub




    Public Function Obtener_ListadoArticulos(ByVal flag As String, ByVal nombre As String, ByVal ar_id As Integer) As DataTable
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

                Using oSqlCommand As SqlCommand = New SqlCommand("SPDSN_LISTAR_ARTICULOS", oSqlConnection)
                    oSqlCommand.CommandType = CommandType.StoredProcedure
                    oSqlCommand.Parameters.Add("@Flag", SqlDbType.Int).Value = flag
                    oSqlCommand.Parameters.Add("@Nomusu", SqlDbType.VarChar, 100).Value = nombre
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


    Public Function Obtener_ListadoArticulos_XRequerimiento(ByVal flag As String, ByVal nombre As String) As DataTable
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

                Using oSqlCommand As SqlCommand = New SqlCommand("SPDSN_LISTAR_ARTICULOS_REQ", oSqlConnection)
                    oSqlCommand.CommandType = CommandType.StoredProcedure
                    oSqlCommand.Parameters.Add("@FLAG", SqlDbType.Int).Value = flag
                    oSqlCommand.Parameters.Add("@NOMBRE", SqlDbType.VarChar, 100).Value = nombre



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
