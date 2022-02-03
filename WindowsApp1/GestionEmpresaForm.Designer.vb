<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GestionEmpresaForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GestionEmpresaForm))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.savedialog_Excel = New System.Windows.Forms.SaveFileDialog()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.cmdNuevo = New System.Windows.Forms.ToolStripButton()
        Me.cmdModificar = New System.Windows.Forms.ToolStripButton()
        Me.cmdEliminar = New System.Windows.Forms.ToolStripButton()
        Me.separador1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdCuentasBancarias = New System.Windows.Forms.ToolStripButton()
        Me.separador2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdGenerarExcel = New System.Windows.Forms.ToolStripButton()
        Me.separador3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnCuadroDePagos = New System.Windows.Forms.ToolStripButton()
        Me.separador4 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdVerDetalle = New System.Windows.Forms.ToolStripButton()
        Me.separador5 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdCerrar = New System.Windows.Forms.ToolStripButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_empresa = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Combo_TipoEmpresa = New System.Windows.Forms.ComboBox()
        Me.DgEmpresas = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DgEmpresas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 16)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Buscar:"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStrip1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdNuevo, Me.cmdModificar, Me.cmdEliminar, Me.separador1, Me.cmdCuentasBancarias, Me.separador2, Me.cmdGenerarExcel, Me.separador3, Me.btnCuadroDePagos, Me.separador4, Me.cmdVerDetalle, Me.separador5, Me.cmdCerrar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(784, 41)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Image = CType(resources.GetObject("cmdNuevo.Image"), System.Drawing.Image)
        Me.cmdNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdNuevo.Margin = New System.Windows.Forms.Padding(1)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(42, 39)
        Me.cmdNuevo.Text = "&Nuevo"
        Me.cmdNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'cmdModificar
        '
        Me.cmdModificar.Image = CType(resources.GetObject("cmdModificar.Image"), System.Drawing.Image)
        Me.cmdModificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdModificar.Margin = New System.Windows.Forms.Padding(1)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(55, 39)
        Me.cmdModificar.Text = "&Modificar"
        Me.cmdModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'cmdEliminar
        '
        Me.cmdEliminar.Image = CType(resources.GetObject("cmdEliminar.Image"), System.Drawing.Image)
        Me.cmdEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdEliminar.Margin = New System.Windows.Forms.Padding(1)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(47, 39)
        Me.cmdEliminar.Text = "&Eliminar"
        Me.cmdEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'separador1
        '
        Me.separador1.Name = "separador1"
        Me.separador1.Size = New System.Drawing.Size(6, 41)
        '
        'cmdCuentasBancarias
        '
        Me.cmdCuentasBancarias.Image = CType(resources.GetObject("cmdCuentasBancarias.Image"), System.Drawing.Image)
        Me.cmdCuentasBancarias.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdCuentasBancarias.Name = "cmdCuentasBancarias"
        Me.cmdCuentasBancarias.Size = New System.Drawing.Size(103, 38)
        Me.cmdCuentasBancarias.Text = "&Cuentas Bancarias"
        Me.cmdCuentasBancarias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'separador2
        '
        Me.separador2.Name = "separador2"
        Me.separador2.Size = New System.Drawing.Size(6, 41)
        '
        'cmdGenerarExcel
        '
        Me.cmdGenerarExcel.Image = CType(resources.GetObject("cmdGenerarExcel.Image"), System.Drawing.Image)
        Me.cmdGenerarExcel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdGenerarExcel.Margin = New System.Windows.Forms.Padding(1)
        Me.cmdGenerarExcel.Name = "cmdGenerarExcel"
        Me.cmdGenerarExcel.Size = New System.Drawing.Size(88, 39)
        Me.cmdGenerarExcel.Text = "&Bancos - Pagos"
        Me.cmdGenerarExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'separador3
        '
        Me.separador3.Name = "separador3"
        Me.separador3.Size = New System.Drawing.Size(6, 41)
        '
        'btnCuadroDePagos
        '
        Me.btnCuadroDePagos.Image = CType(resources.GetObject("btnCuadroDePagos.Image"), System.Drawing.Image)
        Me.btnCuadroDePagos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCuadroDePagos.Margin = New System.Windows.Forms.Padding(1)
        Me.btnCuadroDePagos.Name = "btnCuadroDePagos"
        Me.btnCuadroDePagos.Size = New System.Drawing.Size(95, 39)
        Me.btnCuadroDePagos.Text = "&Cuadro De Pagos"
        Me.btnCuadroDePagos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'separador4
        '
        Me.separador4.Name = "separador4"
        Me.separador4.Size = New System.Drawing.Size(6, 41)
        '
        'cmdVerDetalle
        '
        Me.cmdVerDetalle.Image = CType(resources.GetObject("cmdVerDetalle.Image"), System.Drawing.Image)
        Me.cmdVerDetalle.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdVerDetalle.Margin = New System.Windows.Forms.Padding(1)
        Me.cmdVerDetalle.Name = "cmdVerDetalle"
        Me.cmdVerDetalle.Size = New System.Drawing.Size(43, 39)
        Me.cmdVerDetalle.Text = "&Detalle"
        Me.cmdVerDetalle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'separador5
        '
        Me.separador5.Name = "separador5"
        Me.separador5.Size = New System.Drawing.Size(6, 41)
        '
        'cmdCerrar
        '
        Me.cmdCerrar.Image = CType(resources.GetObject("cmdCerrar.Image"), System.Drawing.Image)
        Me.cmdCerrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdCerrar.Margin = New System.Windows.Forms.Padding(1)
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.Size = New System.Drawing.Size(32, 39)
        Me.cmdCerrar.Text = "&Salir"
        Me.cmdCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txt_empresa)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Combo_TipoEmpresa)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 41)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(784, 35)
        Me.Panel1.TabIndex = 48
        '
        'txt_empresa
        '
        Me.txt_empresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_empresa.Location = New System.Drawing.Point(348, 5)
        Me.txt_empresa.MaxLength = 40
        Me.txt_empresa.Name = "txt_empresa"
        Me.txt_empresa.Size = New System.Drawing.Size(160, 20)
        Me.txt_empresa.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 14)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "Tipo Empresa:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(250, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 14)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "Nombre Empresa:"
        '
        'Combo_TipoEmpresa
        '
        Me.Combo_TipoEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo_TipoEmpresa.FormattingEnabled = True
        Me.Combo_TipoEmpresa.Location = New System.Drawing.Point(84, 5)
        Me.Combo_TipoEmpresa.Name = "Combo_TipoEmpresa"
        Me.Combo_TipoEmpresa.Size = New System.Drawing.Size(160, 22)
        Me.Combo_TipoEmpresa.TabIndex = 2
        '
        'DgEmpresas
        '
        Me.DgEmpresas.AllowUserToAddRows = False
        Me.DgEmpresas.AllowUserToDeleteRows = False
        Me.DgEmpresas.AllowUserToResizeRows = False
        Me.DgEmpresas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgEmpresas.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DgEmpresas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgEmpresas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveBorder
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgEmpresas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgEmpresas.ColumnHeadersHeight = 40
        Me.DgEmpresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgEmpresas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgEmpresas.EnableHeadersVisualStyles = False
        Me.DgEmpresas.Location = New System.Drawing.Point(0, 76)
        Me.DgEmpresas.MultiSelect = False
        Me.DgEmpresas.Name = "DgEmpresas"
        Me.DgEmpresas.ReadOnly = True
        Me.DgEmpresas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgEmpresas.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgEmpresas.RowHeadersVisible = False
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DgEmpresas.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DgEmpresas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgEmpresas.Size = New System.Drawing.Size(784, 385)
        Me.DgEmpresas.TabIndex = 65
        '
        'GestionEmpresaForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.DgEmpresas)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "GestionEmpresaForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GestionEmpresaForm"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DgEmpresas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    'Friend WithEvents cmdBuscar As FontAwesome.Sharp.IconButton
    'Friend WithEvents txtBuscar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents savedialog_Excel As SaveFileDialog
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents cmdNuevo As ToolStripButton
    Friend WithEvents cmdModificar As ToolStripButton
    Friend WithEvents cmdEliminar As ToolStripButton
    Friend WithEvents separador1 As ToolStripSeparator
    Friend WithEvents cmdGenerarExcel As ToolStripButton
    Friend WithEvents separador3 As ToolStripSeparator
    Friend WithEvents btnCuadroDePagos As ToolStripButton
    Friend WithEvents cmdVerDetalle As ToolStripButton
    Friend WithEvents separador5 As ToolStripSeparator
    Friend WithEvents cmdCerrar As ToolStripButton
    Friend WithEvents separador4 As ToolStripSeparator
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Combo_TipoEmpresa As ComboBox
    Friend WithEvents txt_empresa As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DgEmpresas As DataGridView
    Friend WithEvents cmdCuentasBancarias As ToolStripButton
    Friend WithEvents separador2 As ToolStripSeparator
End Class
