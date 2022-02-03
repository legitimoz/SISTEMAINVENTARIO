
Imports System.Data.SqlClient
Imports System.Configuration


Public Class BeDocumentos


    Public Conexion As String = String.Empty



    Private ga_id As String
    Public Property prga_id() As String
        Get
            Return ga_id
        End Get
        Set(ByVal value As String)
            ga_id = value
        End Set
    End Property

    Private ar_cod As String
    Public Property prar_cod() As String
        Get
            Return ar_cod
        End Get
        Set(ByVal value As String)
            ar_cod = value
        End Set
    End Property

    Private ta_id As String
    Public Property prta_id() As String
        Get
            Return ta_id
        End Get
        Set(ByVal value As String)
            ta_id = value
        End Set
    End Property

    Private c5_calma As String
    Public Property prc5_calma() As String
        Get
            Return c5_calma
        End Get
        Set(ByVal value As String)
            c5_calma = value
        End Set
    End Property

    Private c5_ctd As String
    Public Property prc5_ctd() As String
        Get
            Return c5_ctd
        End Get
        Set(ByVal value As String)
            c5_ctd = value
        End Set
    End Property

    Private c5_cnumdoc As String
    Public Property prc5_cnumdoc() As String
        Get
            Return c5_cnumdoc
        End Get
        Set(ByVal value As String)
            c5_cnumdoc = value
        End Set
    End Property


    Private ga_nomfile As String
    Public Property prga_nomfile() As String
        Get
            Return ga_nomfile
        End Get
        Set(ByVal value As String)
            ga_nomfile = value
        End Set
    End Property

    Private ga_obs As String
    Public Property prga_obs() As String
        Get
            Return ga_obs
        End Get
        Set(ByVal value As String)
            ga_obs = value
        End Set
    End Property

    Private ga_rutaDestino As String
    Public Property prga_rutaDestino() As String
        Get
            Return ga_rutaDestino
        End Get
        Set(ByVal value As String)
            ga_rutaDestino = value
        End Set
    End Property

    Private ga_usrid As String
    Public Property prga_usrid() As String
        Get
            Return ga_usrid
        End Get
        Set(ByVal value As String)
            ga_usrid = value
        End Set
    End Property

    Private f5_ccodage As String
    Public Property prf5_ccodage() As String
        Get
            Return f5_ccodage
        End Get
        Set(ByVal value As String)
            f5_ccodage = value
        End Set
    End Property

    Private f5_ctd As String
    Public Property prf5_ctd() As String
        Get
            Return f5_ctd
        End Get
        Set(ByVal value As String)
            f5_ctd = value
        End Set
    End Property


    Private f5_cnumser As String
    Public Property prf5_cnumser() As String
        Get
            Return f5_cnumser
        End Get
        Set(ByVal value As String)
            f5_cnumser = value
        End Set
    End Property

    Private f5_cnumdoc As String
    Public Property prf5_cnumdoc() As String
        Get
            Return f5_cnumdoc
        End Get
        Set(ByVal value As String)
            f5_cnumdoc = value
        End Set
    End Property


    Public Function Obtener_Areas() As DataTable
        Try

            Dim _listadoPruebas As New DataTable
            Conexion = System.Configuration.ConfigurationManager.ConnectionStrings("ConexionHeadMark").ConnectionString

            Using oSqlConnection As SqlConnection = New SqlConnection(Conexion)
                Dim _consulta As String = String.Empty
                _consulta = "SELECT '0' ar_cod, '--TODOS--' ar_des UNION ALL SELECT ar_cod, ar_des FROM Area WHERE ar_est = 'A'"
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


    Public Function Obtener_TipoDocumentos() As DataTable
        Try

            Dim _listadoPruebas As New DataTable
            Conexion = System.Configuration.ConfigurationManager.ConnectionStrings("ConexionHeadMark").ConnectionString

            Using oSqlConnection As SqlConnection = New SqlConnection(Conexion)
                Dim _consulta As String = String.Empty
                _consulta = "SELECT '0' ta_id, '--TODOS--' ta_des UNION ALL SELECT ta_id, ta_des FROM Tipo_Archivo WHERE ta_est = 'A'"
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



    Public Function Listar_Guias(ByVal flag As Integer, ByVal fecIni As String, ByVal fecFin As String, ByVal nroguia As String) As DataTable
        Try
            Dim _listadoPruebas As New DataTable
            Conexion = System.Configuration.ConfigurationManager.ConnectionStrings("ConexionHeadMark").ConnectionString

            Using oSqlConnection As SqlConnection = New SqlConnection(Conexion)
                Dim _consulta As String = String.Empty

                Using oSqlCommand As SqlCommand = New SqlCommand("SPDSN_FILTRAR_GUIAS_X_FECHA", oSqlConnection)
                    oSqlCommand.CommandType = CommandType.StoredProcedure
                    oSqlCommand.Parameters.Add("@FLAG", SqlDbType.Int).Value = flag
                    oSqlCommand.Parameters.Add("@FECINI", SqlDbType.VarChar, 20).Value = fecIni
                    oSqlCommand.Parameters.Add("@FECFIN", SqlDbType.VarChar, 20).Value = fecFin
                    oSqlCommand.Parameters.Add("@C5_CNUMDOC", SqlDbType.VarChar, 30).Value = nroguia


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


    Public Sub RegistrarDocumento(ByVal beDoc As BeDocumentos, ByRef _tiporespuesta As String, ByRef _textorespuesta As String, ByRef ga_id As String, ByRef fecHoraReg As String)
        Try
            Conexion = System.Configuration.ConfigurationManager.ConnectionStrings("ConexionHeadMark").ConnectionString

            Using oSqlConnection As SqlConnection = New SqlConnection(Conexion)
                Using oSqlCommandMedlab As SqlCommand = New SqlCommand("SPDSN_REGISTRAR_DOCUMENTO", oSqlConnection)
                    oSqlCommandMedlab.CommandType = CommandType.StoredProcedure

                    oSqlCommandMedlab.Parameters.Add("@ar_cod", SqlDbType.Int).Value = beDoc.prar_cod
                    oSqlCommandMedlab.Parameters.Add("@ta_id", SqlDbType.Int).Value = beDoc.prta_id
                    oSqlCommandMedlab.Parameters.Add("@C5_CALMA", SqlDbType.VarChar, 4).Value = beDoc.prc5_calma
                    oSqlCommandMedlab.Parameters.Add("@C5_CTD", SqlDbType.VarChar, 2).Value = beDoc.prc5_ctd
                    oSqlCommandMedlab.Parameters.Add("@C5_CNUMDOC", SqlDbType.VarChar, 11).Value = beDoc.prc5_cnumdoc
                    oSqlCommandMedlab.Parameters.Add("@ga_obs", SqlDbType.VarChar, 200).Value = beDoc.prga_obs
                    oSqlCommandMedlab.Parameters.Add("@usr_id", SqlDbType.Int).Value = beDoc.prga_usrid

                    oSqlCommandMedlab.Parameters.Add("@F5_CCODAGE", SqlDbType.Char, 4).Value = beDoc.f5_ccodage
                    oSqlCommandMedlab.Parameters.Add("@F5_CTD", SqlDbType.Char, 2).Value = beDoc.f5_ctd
                    oSqlCommandMedlab.Parameters.Add("@F5_CNUMSER", SqlDbType.Char, 4).Value = beDoc.f5_cnumser
                    oSqlCommandMedlab.Parameters.Add("@F5_CNUMDOC", SqlDbType.Char, 7).Value = beDoc.f5_cnumdoc


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
                            ga_id = oSqlDataReader.GetValue(2).ToString()
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


    Sub SaveAttachments(ByVal ga_id As String, ByVal ruta As String, ByVal filename As String, ByVal ra_id As String, ByRef _tiporespuesta As String, ByRef _textorespuesta As String)
        Dim cantidad As Integer = 0
        Try
            Conexion = System.Configuration.ConfigurationManager.ConnectionStrings("ConexionHeadMark").ConnectionString

            Using oSqlConnection As SqlConnection = New SqlConnection(Conexion)
                Using oSqlCommand As SqlCommand = New SqlCommand("SPDSN_REGISTRAR_ATTACHMENT_DOCUMENTO", oSqlConnection)
                    oSqlCommand.CommandType = CommandType.StoredProcedure

                    oSqlCommand.Parameters.Add("@ga_id", SqlDbType.Int).Value = ga_id
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



    Public Function Filtrar_documentos(ByVal flag As Integer, ByVal fecIni As String, ByVal fecFin As String, ByVal ar_cod As Integer, ByVal ta_id As Integer, ByVal c5_cnumdoc As String, ByVal f5_cnumdoc As String, ByVal cliente As String) As DataTable
        Try
            Dim _listadoPruebas As New DataTable
            Conexion = System.Configuration.ConfigurationManager.ConnectionStrings("ConexionHeadMark").ConnectionString

            Using oSqlConnection As SqlConnection = New SqlConnection(Conexion)
                Dim _consulta As String = String.Empty

                Using oSqlCommand As SqlCommand = New SqlCommand("SPDSN_FILTRAR_DOCUMENTOS", oSqlConnection)
                    oSqlCommand.CommandType = CommandType.StoredProcedure
                    oSqlCommand.Parameters.Add("@FLAG", SqlDbType.Int).Value = flag
                    oSqlCommand.Parameters.Add("@FECINI", SqlDbType.VarChar, 20).Value = fecIni
                    oSqlCommand.Parameters.Add("@FECFIN", SqlDbType.VarChar, 20).Value = fecFin
                    oSqlCommand.Parameters.Add("@ar_cod", SqlDbType.Int).Value = ar_cod
                    oSqlCommand.Parameters.Add("@ta_id", SqlDbType.Int).Value = ta_id
                    oSqlCommand.Parameters.Add("@c5_cnumdoc", SqlDbType.VarChar, 11).Value = c5_cnumdoc
                    oSqlCommand.Parameters.Add("@f5_cnumdoc", SqlDbType.VarChar, 7).Value = f5_cnumdoc
                    oSqlCommand.Parameters.Add("@Cliente", SqlDbType.VarChar, 30).Value = cliente



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



    Public Function Obtener_RutasDocumentos(ByVal ar_cod As String, ByVal tpd_codigo As String) As DataTable
        Try

            Dim _listadoPruebas As New DataTable
            Conexion = System.Configuration.ConfigurationManager.ConnectionStrings("ConexionHeadMark").ConnectionString

            Using oSqlConnection As SqlConnection = New SqlConnection(Conexion)
                Dim _consulta As String = String.Empty
                _consulta = "SELECT '0' rd_id, '--SELECCIONE--' rd_ruta UNION ALL SELECT rd_id, rd_ruta FROM Rutas_Destino WHERE rd_est = 'A' and tpd_codigo=" + tpd_codigo + " and ar_cod= " + ar_cod
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



    Public Function Listar_Comprobantes(ByVal flag As Integer, ByVal fecIni As String, ByVal fecFin As String, ByVal comprobante As String) As DataTable
        Try
            Dim _listadoPruebas As New DataTable
            Conexion = System.Configuration.ConfigurationManager.ConnectionStrings("ConexionHeadMark").ConnectionString

            Using oSqlConnection As SqlConnection = New SqlConnection(Conexion)
                Dim _consulta As String = String.Empty

                Using oSqlCommand As SqlCommand = New SqlCommand("SPDSN_FILTRAR_COMPROBANTES_X_FECHA", oSqlConnection)
                    oSqlCommand.CommandType = CommandType.StoredProcedure
                    oSqlCommand.Parameters.Add("@FLAG", SqlDbType.Int).Value = flag
                    oSqlCommand.Parameters.Add("@FECINI", SqlDbType.VarChar, 20).Value = fecIni
                    oSqlCommand.Parameters.Add("@FECFIN", SqlDbType.VarChar, 20).Value = fecFin
                    oSqlCommand.Parameters.Add("@COMPROBANTE", SqlDbType.VarChar, 20).Value = comprobante


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


    Public Function Listar_DocumentosPendientes(ByVal fecIni As String, ByVal fecFin As String) As DataTable
        Try
            Dim _listadoPruebas As New DataTable
            Conexion = System.Configuration.ConfigurationManager.ConnectionStrings("ConexionHeadMark").ConnectionString

            Using oSqlConnection As SqlConnection = New SqlConnection(Conexion)
                Dim _consulta As String = String.Empty

                Using oSqlCommand As SqlCommand = New SqlCommand("SPDSN_DOCUMENTOS_PENDIENTES_SCANEAR", oSqlConnection)
                    oSqlCommand.CommandType = CommandType.StoredProcedure
                    oSqlCommand.Parameters.Add("@FECINI", SqlDbType.VarChar, 20).Value = fecIni
                    oSqlCommand.Parameters.Add("@FECFIN", SqlDbType.VarChar, 20).Value = fecFin



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
