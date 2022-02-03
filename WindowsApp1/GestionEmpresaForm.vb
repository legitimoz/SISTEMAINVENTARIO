Imports LOGICANEGOCIO
Imports ENTIDAD
Imports System.Globalization
Imports System.Reflection

Public Class GestionEmpresaForm

    '    Public empresaobj As New EmpresaL
    '    Public dtempresas As New DataTable
    '    Public Estructura As New EstructuraTabla
    '    Private idempresa As Integer = Constantes.ValorEnteroInicial
    '    Private ReadOnly reporteobj As New ReporteL
    '    Public recuperando As Boolean = False
    '    Public idtipotrabajador As Integer
    '    Public idtrabajador As Integer
    '    Private empresaactual As String = ""
    '    Private tipoempresaactual As String = ""
    '    Private rucempresaactual As String = ""
    '    Private direccionempresaactual As String = ""
    '    Private presupuesto As Double

    '    'PASAR VALORE DE VARIABLES ENTRE FORMULARIO
    '    Public IDEmpresa_CuentaB As Integer
    '    Public NombreEmpres_CuentaB As String

    '    Private Sub GestionEmpresaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '        DoubleBufferedASD(DgEmpresas, True)
    '        CargaInicial()
    '    End Sub

    '    Public Sub DoubleBufferedASD(dgv As DataGridView, setting As Boolean)
    '        Dim dgvType As Type = dgv.[GetType]()
    '        Dim pi As PropertyInfo = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance Or BindingFlags.NonPublic)
    '        pi.SetValue(dgv, setting, Nothing)
    '    End Sub



    '#Region "Peticiones Servidor"
    '    Public Function LlamarListarEmpresas() As DataSet
    '        Dim dsretorno As DataSet
    '        Try
    '            dsretorno = empresaobj.ListarEmpresas()
    '        Catch ex As Exception
    '            Throw ex
    '            dsretorno = Nothing
    '        End Try
    '        Return dsretorno
    '    End Function

    '    Public Function LlamarListarDatosexcel() As DataTable
    '        Dim dtretono As DataTable
    '        Try
    '            dtretono = reporteobj.cargardatosExcel(idempresa).Copy
    '        Catch ex As Exception
    '            Throw ex
    '        End Try
    '        Return dtretono
    '    End Function

    '    Public Function LlamarBorrar() As Respuesta
    '        Dim respuestaservicio As Respuesta
    '        Try
    '            Dim Empre As New Empresa With {
    '                .idempresa = Me.idempresa
    '            }

    '            respuestaservicio = empresaobj.BorrarEmpresa(Empre)

    '        Catch ex As Exception
    '            Throw ex
    '            respuestaservicio.Estado = Constantes.ValorEnteroNegativo
    '            respuestaservicio.Respuesta = Constantes.MensajeErrorServer
    '        End Try
    '        Return respuestaservicio
    '    End Function
    '#End Region

    '#Region "Metodos"

    '    Public Sub FormatoDataGrid()

    '        DgEmpresas.DataSource = Nothing
    '        dtempresas.Rows.Clear()
    '        dtempresas = Estructura.ListarEmpresas().Clone
    '        DgEmpresas.DataSource = dtempresas

    '        DgEmpresas.Columns("idempresa").Visible = False

    '        DgEmpresas.Columns("nombreempresa").HeaderText = "NOMBRE EMPRESA"
    '        DgEmpresas.Columns("nombreempresa").Width = "300"

    '        DgEmpresas.Columns("eliminado").HeaderText = "ESTADO"
    '        DgEmpresas.Columns("eliminado").Width = "100"

    '        DgEmpresas.Columns("RUC").HeaderText = "RUC"
    '        DgEmpresas.Columns("RUC").Width = "100"

    '        DgEmpresas.Columns("Direccion").HeaderText = "DIRECCION"
    '        DgEmpresas.Columns("Direccion").Width = "600"

    '        DgEmpresas.Columns("tipoempresa").HeaderText = "TIPO EMPRESA"
    '        DgEmpresas.Columns("tipoempresa").Width = "120"

    '        DgEmpresas.Columns("presupuesto").HeaderText = "PRESUPUESTO"
    '        DgEmpresas.Columns("presupuesto").Width = "120"

    '    End Sub

    '    Public Sub CargaInicial()
    '        Try
    '            If recuperando = True Then
    '                Me.Text = "Recuperar Obra"
    '                ListarEmpresas()
    '            Else
    '                idtipotrabajador = CType(Me.TabIndex, Integer)
    '                idtrabajador = CType(Me.Name, Integer)
    '            End If

    '            If idtrabajador <> Constantes.ValorEnteroInicial And idtipotrabajador <> Constantes.ValorEnteroInicial Then
    '                If idtipotrabajador = Constantes.idtipoadmin Then
    '                    FormatoDataGrid()
    '                    ListarEmpresas()
    '                ElseIf idtipotrabajador = Constantes.idtipologistico Then
    '                    cmdNuevo.Visible = False
    '                    cmdModificar.Visible = False
    '                    cmdEliminar.Visible = False
    '                    separador1.Visible = False
    '                    cmdCuentasBancarias.Visible = False
    '                    separador2.Visible = False
    '                    cmdVerDetalle.Visible = False
    '                    separador5.Visible = False
    '                    FormatoDataGrid()
    '                    ListarEmpresas()
    '                Else
    '                    cmdNuevo.Visible = False
    '                    cmdModificar.Visible = False
    '                    cmdEliminar.Visible = False
    '                    separador1.Visible = False
    '                    cmdVerDetalle.Visible = False
    '                    separador5.Visible = False
    '                    FormatoDataGrid()
    '                    ListarEmpresas()
    '                End If
    '            End If

    '        Catch ex As Exception
    '            MsgBox(ex.Message, MsgBoxStyle.Critical)
    '        End Try
    '    End Sub

    '    Public Sub ListarEmpresas()
    '        Try
    '            Dim dsrespuesta As DataSet = LlamarListarEmpresas()
    '            If dsrespuesta.Tables.Count > Constantes.ValorEnteroInicial Then
    '                If dsrespuesta.Tables.Contains("dtempresas") Then
    '                    If dsrespuesta.Tables("dtempresas").Rows.Count > Constantes.ValorEnteroInicial Then
    '                        dtempresas = dsrespuesta.Tables("dtempresas")
    '                        For Each row As DataRow In dtempresas.Rows
    '                            If row.Item("eliminado") = Constantes.ValorEntero1 Then
    '                                row.Item("eliminado") = "INACTIVO"
    '                            Else
    '                                row.Item("eliminado") = "ACTIVO"
    '                            End If
    '                        Next
    '                        DgEmpresas.DataSource = dtempresas
    '                    End If
    '                End If
    '                If dsrespuesta.Tables.Contains("dttipoempresa") Then
    '                    If dsrespuesta.Tables("dttipoempresa").Rows.Count > Constantes.ValorEnteroInicial Then
    '                        Dim dttipoempresa As DataTable = dsrespuesta.Tables("dttipoempresa")
    '                        Combo_TipoEmpresa.DataSource = dttipoempresa
    '                        Combo_TipoEmpresa.DisplayMember = "nombre"
    '                        Combo_TipoEmpresa.ValueMember = "idtipoempresa"
    '                    End If
    '                End If
    '            End If
    '        Catch ex As Exception
    '            Throw ex
    '            MsgBox(Constantes.MensajeErrorServer, MsgBoxStyle.Critical)
    '        End Try
    '    End Sub

    '    Public Sub Obtener()
    '        Try
    '            If DgEmpresas.Rows.Count > 0 Then
    '                Me.idempresa = CType(DgEmpresas.CurrentRow.Cells("idempresa").EditedFormattedValue, Integer)
    '                Me.empresaactual = DgEmpresas.CurrentRow.Cells("nombreempresa").EditedFormattedValue
    '                Dim tipo As String = DgEmpresas.CurrentRow.Cells("tipoempresa").EditedFormattedValue
    '                If tipo = "INTERNA" Then
    '                    Me.tipoempresaactual = "1"
    '                Else
    '                    Me.tipoempresaactual = "2"
    '                End If
    '                Me.rucempresaactual = DgEmpresas.CurrentRow.Cells("RUC").EditedFormattedValue
    '                Me.direccionempresaactual = DgEmpresas.CurrentRow.Cells("Direccion").EditedFormattedValue
    '                Me.presupuesto = CType(DgEmpresas.CurrentRow.Cells("presupuesto").EditedFormattedValue, Double)
    '            End If
    '        Catch ex As Exception
    '        End Try
    '    End Sub

    '    Private Sub BorrarEmpresa()

    '        If Me.idempresa <> Constantes.ValorEnteroInicial Then
    '            Dim rp As Respuesta = LlamarBorrar()
    '            If rp.Estado <> Constantes.ValorEnteroInicial Then
    '                MsgBox(rp.Respuesta, MsgBoxStyle.Information)
    '                ListarEmpresas()
    '            Else
    '                MsgBox(rp.Respuesta, MsgBoxStyle.Critical)
    '            End If

    '        End If
    '    End Sub
    '#End Region

    '    'Public Sub Contar()
    '    '    Dim contINT, contEXT As Integer
    '    '    contEXT = 0
    '    '    contINT = 0
    '    '    'recorre el grid fila por fila
    '    '    For Each r As DataGridViewRow In DgEmpresas.Rows
    '    '        'en cells() va el indice de la columna que quiere verificar que tenga datos
    '    '        If Not r.Cells(5).Value <> "INTERNA" Then
    '    '            contINT += 1
    '    '        Else
    '    '            contEXT += 1
    '    '        End If
    '    '    Next
    '    '    If contINT = 1 Then
    '    '        txtContador.Text = CStr(contINT & " EMPRESA INTERNA")
    '    '    Else
    '    '        txtContador.Text = CStr(contINT & " EMPRESAS INTERNAS")
    '    '    End If
    '    '    If contEXT = 1 Then
    '    '        txtContador2.Text = CStr(contEXT & " EMPRESA EXTERNA")
    '    '    Else
    '    '        txtContador2.Text = CStr(contEXT & " EMPRESAS EXTERNAS")
    '    '    End If
    '    'End Sub

    '    Private Sub Buscar()
    '        Try
    '            Dim stringfiltro As String = ""
    '            If Combo_TipoEmpresa.SelectedIndex = 0 Then
    '                stringfiltro = String.Format("nombreempresa LIKE '%{0}%'", txt_empresa.Text.ToUpper())
    '            End If
    '            If Combo_TipoEmpresa.SelectedIndex <> 0 Then
    '                stringfiltro = String.Format("nombreempresa LIKE '%{0}%' AND tipoempresa = '{1}'", txt_empresa.Text.ToUpper(), Combo_TipoEmpresa.Text)
    '            End If
    '            dtempresas.DefaultView.RowFilter = stringfiltro
    '        Catch ex As Exception

    '        End Try
    '    End Sub

    '    Private Sub CmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
    '        Try
    '            Dim form As New EditarEmpresa With {
    '                .Text = "Nueva Empresa",
    '                .Accion = ENTIDAD.Constantes.Nuevo
    '            }
    '            form.ShowDialog()
    '            If form.Grabadook = True Then
    '                ListarEmpresas()
    '            End If

    '        Catch ex As Exception
    '            Throw ex
    '        End Try
    '    End Sub

    '    Private Sub CmdModificar_Click(sender As Object, e As EventArgs) Handles cmdModificar.Click
    '        Try
    '            Dim form As New EditarEmpresa With {
    '                .Text = "Editar Empresa",
    '                .Accion = ENTIDAD.Constantes.Modificar
    '            }
    '            Obtener()
    '            form.idempresa = Me.idempresa
    '            form.nombreempresa = Me.empresaactual
    '            form.rucempresa = Me.rucempresaactual
    '            form.direccionempresa = Me.direccionempresaactual
    '            form.tipoempresa = Me.tipoempresaactual
    '            form.ShowDialog()
    '            If form.Grabadook = True Then
    '                ListarEmpresas()
    '            End If
    '        Catch ex As Exception
    '            Throw ex
    '        End Try
    '    End Sub

    '    Private Sub BtnCuadroDePagos_Click(sender As Object, e As EventArgs) Handles btnCuadroDePagos.Click
    '        Try
    '            Dim form As New CuadroPagosForm With {
    '                .Text = "Cuadro Pagos"
    '            }
    '            Obtener()
    '            form.idempresa = Me.idempresa
    '            form.nombreempresa = Me.empresaactual
    '            form.presupuesto = Me.presupuesto
    '            form.ShowDialog()
    '        Catch ex As Exception
    '            Throw ex
    '        End Try
    '    End Sub

    '    Private Sub CmdVerDetalle_Click(sender As Object, e As EventArgs) Handles cmdVerDetalle.Click
    '        Try
    '            Dim form As New EditarEmpresa With {
    '                .Text = "Detalle Empresa",
    '                .Accion = ENTIDAD.Constantes.Detalle
    '            }
    '            Obtener()
    '            form.idempresa = Me.idempresa
    '            form.nombreempresa = Me.empresaactual
    '            form.rucempresa = Me.rucempresaactual
    '            form.direccionempresa = Me.direccionempresaactual
    '            form.tipoempresa = Me.tipoempresaactual
    '            form.ShowDialog()
    '        Catch ex As Exception
    '            Throw ex
    '        End Try
    '    End Sub

    '    Private Sub CmdGenerarExcel_Click(sender As Object, e As EventArgs) Handles cmdGenerarExcel.Click
    '        Try
    '            Obtener()
    '            If idempresa <> Constantes.ValorEnteroInicial Then
    '                Dim dtdata As DataTable = LlamarListarDatosexcel()
    '                If dtdata.Rows.Count > Constantes.ValorEnteroInicial Then
    '                    Dim GenerarExcelForm As New GenerarExcelForm With {
    '                        .dtData = dtdata,
    '                        .Text = empresaactual
    '                    }
    '                    GenerarExcelForm.ShowDialog()
    '                    If GenerarExcelForm.Grabadook = True Then
    '                        MsgBox("Documento Generado Correctamente", MsgBoxStyle.Information)
    '                    End If
    '                Else
    '                    MsgBox("No existe Data para generar Excel", MsgBoxStyle.Exclamation)
    '                End If

    '            End If

    '        Catch ex As Exception

    '        End Try
    '    End Sub

    '    Private Sub CmdEliminar_Click(sender As Object, e As EventArgs) Handles cmdEliminar.Click
    '        Obtener()
    '        If MessageBox.Show("¿Desea eliminar la empresa " + Me.empresaactual + "?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
    '            BorrarEmpresa()
    '        End If
    '    End Sub

    '    Private Sub CmdCerrar_Click(sender As Object, e As EventArgs) Handles cmdCerrar.Click
    '        Me.Close()
    '    End Sub

    '    Private Sub Txt_empresa_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_empresa.KeyDown
    '        If e.KeyCode = Keys.Enter Then
    '            Buscar()
    '        End If
    '    End Sub

    '    Private Sub Combo_TipoEmpresa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Combo_TipoEmpresa.KeyPress
    '        Buscar()
    '    End Sub

    '    Private Sub BtnCuentasBancarias_Click(sender As Object, e As EventArgs) Handles cmdCuentasBancarias.Click
    '        Try
    '            Obtener()
    '            'OBTENGO EL ID DE LA EMPRESA PARA GUARDARLO EN UNA VARIABLE Y PASARLO ENTRE FORMS
    '            NombreEmpres_CuentaB = DgEmpresas.CurrentRow.Cells(1).Value.ToString()

    '            If idempresa <> Constantes.ValorEnteroInicial Then
    '                'ABRO GESTION CUENTA BANCARIA EMPRESA
    '                Dim form As New GestionCuentaBancariaEmpresa With {
    '                .Text = "Cuentas Bancarias: " & NombreEmpres_CuentaB,
    '                .idEmpresapasar = idempresa
    '            }
    '                form.ShowDialog()
    '            Else
    '                MsgBox(Constantes.MensajeSeleccioneCentroCosto, MsgBoxStyle.Exclamation)
    '            End If

    '        Catch ex As Exception
    '            Throw ex
    '        End Try
    '    End Sub
End Class