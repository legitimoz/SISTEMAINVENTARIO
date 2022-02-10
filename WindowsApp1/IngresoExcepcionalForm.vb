Imports Nordic.Bl.Be

Public Class IngresoExcepcionalForm
    Private strFileName As String
    Public idalmacen, idsite, userid As Integer
    Public nombrealmacen, nombreSite As String
    Public objAlmacen As New AlmacenL
    Private dtUbicaciones As New DataTable
    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click
        Aceptar()
    End Sub

    Private Sub ListarUbicacionesXSite_Almacen()
        Try
            dtUbicaciones = objAlmacen.ListarUbicacionesXSite_Almacen(idsite, idalmacen)
        Catch ex As Exception

        End Try
    End Sub

    Public Sub Aceptar()
        Dim dtProductos As New DataTable
        Try
            If idalmacen <> 0 And idsite <> 0 Then
                If input_archivo.Text <> "" Then
                    dtProductos = ConvertExcelToDatatable(input_archivo.Text)
                    If dtProductos IsNot Nothing Then
                        If dtProductos.Rows.Count > 0 Then
                            If CargaMasiva(dtProductos) Then
                                MsgBox("Ingreso Registrado Correctamente", MsgBoxStyle.Information, "Alerta")
                            End If
                        Else
                            MsgBox("No existen Productos para Ingreso", MsgBoxStyle.Exclamation, "Alerta")
                        End If
                    Else
                        MsgBox("No se pudo cargar Archivo", MsgBoxStyle.Exclamation, "Alerta")
                    End If
                Else
                    MsgBox("Seleccione Archivo a cargar", MsgBoxStyle.Exclamation, "Alerta")
                End If
            Else
                MsgBox("No se recuperaron datos de Almacen y Site, Contactar con el área de Sistemas", MsgBoxStyle.Critical, "Alerta")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Function CargaMasiva(dtproductos As DataTable) As Boolean
        Dim rp As Boolean = True
        Dim XML As String = ""
        Dim rowcomplemente As DataRow = Nothing
        Try
            If dtproductos.Rows.Count > 0 Then
                Dim Operacion As New OperacionCab
                Operacion.opa_userid = userid
                Operacion.idsite = idsite
                Operacion.idalmacen = idalmacen
                Operacion.Detalle = New List(Of OperacionDet)

                For Each RowArticulo As DataRow In dtproductos.Rows
                    If RowArticulo.Item("CODIGO").ToString.Trim <> "" And RowArticulo.Item("LOTE").ToString.Trim <> "" Then
                        Dim DetalleObj As New OperacionDet
                        DetalleObj.dopa_C5_CALMA = RowArticulo.Item("ALMACEN").ToString.Trim
                        DetalleObj.dopa_userid = userid
                        DetalleObj.dopa_codarticulo = RowArticulo.Item("CODIGO").ToString.Trim
                        DetalleObj.fechavecimiento = RowArticulo.Item("FECHAVENCIMIENTO").ToString.Trim
                        DetalleObj.dopa_serie = RowArticulo.Item("LOTE").ToString.Trim
                        DetalleObj.dopa_cantidad = CType(RowArticulo.Item("CANTIDAD").ToString.Trim, Integer)
                        DetalleObj.idsite = idsite
                        DetalleObj.idalmacen = idalmacen
                        DetalleObj.dopa_cantMov = CType(RowArticulo.Item("CANTIDAD").ToString.Trim, Integer)
                        rowcomplemente = ObtenerComplemento(RowArticulo.Item("UBICACION").ToString.Trim)
                        If True Then

                        End If
                        If rowcomplemente.ItemArray.Length > 0 Then
                            DetalleObj.dopa_codposicion = CType(rowcomplemente.Item("esp_idespacio").ToString, Integer)
                            DetalleObj.idrack = CType(rowcomplemente.Item("esp_idrack").ToString, Integer)
                        End If

                        Operacion.Detalle.Add(DetalleObj)
                    End If
                Next
                If (Operacion.Detalle.Count > 0) Then
                    XML = Operacion.Serializar(Operacion)
                    rp = objAlmacen.RegistrarIngresoMasivo(XML)
                End If
            End If
        Catch ex As Exception

        End Try
        Return rp
    End Function

    Private Sub IngresoExcepcionalForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargaInicial()
    End Sub

    Private Sub CargaInicial()
        Try
            If idsite <> 0 And idalmacen <> 0 Then
                ListarUbicacionesXSite_Almacen()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Function ObtenerComplemento(codposicion As String) As DataRow
        Dim RowRetorno As DataRow = Nothing
        Try
            If dtUbicaciones.Rows.Count > 0 Then
                For Each RowRecorre As DataRow In dtUbicaciones.Rows
                    If RowRecorre.Item("esp_codigoespacio").ToString.Trim = codposicion Then
                        RowRetorno = dtUbicaciones.NewRow
                        RowRetorno = RowRecorre
                        Exit For
                    End If
                Next
            End If
        Catch ex As Exception
            Throw ex
            RowRetorno = Nothing
        End Try
        Return RowRetorno
    End Function



    Private Sub btnCargaDeArchivos_Click(sender As Object, e As EventArgs) Handles btnCargaDeArchivos.Click
        Dim fd As OpenFileDialog = New OpenFileDialog With {
        .Title = Text,
        .InitialDirectory = "C:\",
        .Filter = "Todos los archivos(*.*)|*.*",
        .FilterIndex = 1,
        .RestoreDirectory = True
        }
        If fd.ShowDialog() = DialogResult.OK Then
            strFileName = UCase(fd.SafeFileName)
            input_archivo.Text = UCase(fd.FileName)
            StartPosition = FormStartPosition.CenterScreen
        End If
    End Sub

    Private Function ConvertExcelToDatatable(ByVal path As String) As DataTable
        Dim dt As DataTable = New DataTable()
        Using con As OleDb.OleDbConnection = New OleDb.OleDbConnection()
            Try
                Dim Extension As String = System.IO.Path.GetExtension(path)
                If Extension = ".XLSX" Then
                    con.ConnectionString = String.Format("Provider={0};Data Source={1};Extended Properties=""Excel 12.0 XML;HDR=Yes;""", "Microsoft.ACE.OLEDB.12.0", path)
                End If
                Using cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand("SELECT * FROM [Hoja2$]", con)
                    Using da As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(cmd)
                        con.Open()
                        da.Fill(dt)
                        con.Close()
                    End Using
                End Using
            Catch ex As Exception
                Console.WriteLine(ex.ToString())
                dt = Nothing
            Finally
                If con IsNot Nothing AndAlso con.State = ConnectionState.Open Then
                    con.Close()
                End If
            End Try
        End Using
        Return dt
    End Function

End Class