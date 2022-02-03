<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdBuscar = New FontAwesome.Sharp.IconButton()
        Me.txtProveedores = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.ToolStripButton()
        Me.cmd_Racks = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.cmdNuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.separador1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnRegistrarIngreso = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdVerReporte = New System.Windows.Forms.ToolStripButton()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.DGAlmacenes = New System.Windows.Forms.DataGridView()
        Me.DGRacks = New System.Windows.Forms.DataGridView()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.Panel2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.DGAlmacenes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGRacks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.cmdBuscar)
        Me.Panel2.Controls.Add(Me.txtProveedores)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 40)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(933, 72)
        Me.Panel2.TabIndex = 66
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(590, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "RACKS ALMACEN"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "ALMACENES"
        '
        'cmdBuscar
        '
        Me.cmdBuscar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdBuscar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.cmdBuscar.FlatAppearance.BorderSize = 0
        Me.cmdBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdBuscar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdBuscar.IconChar = FontAwesome.Sharp.IconChar.Search
        Me.cmdBuscar.IconColor = System.Drawing.SystemColors.ControlText
        Me.cmdBuscar.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.cmdBuscar.IconSize = 16
        Me.cmdBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdBuscar.Location = New System.Drawing.Point(225, 15)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.cmdBuscar.Size = New System.Drawing.Size(25, 20)
        Me.cmdBuscar.TabIndex = 66
        Me.cmdBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdBuscar.UseVisualStyleBackColor = False
        '
        'txtProveedores
        '
        Me.txtProveedores.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProveedores.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProveedores.Location = New System.Drawing.Point(59, 15)
        Me.txtProveedores.Name = "txtProveedores"
        Me.txtProveedores.Size = New System.Drawing.Size(160, 20)
        Me.txtProveedores.TabIndex = 77
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
        Me.Label7.TabIndex = 76
        Me.Label7.Text = "Nombre:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnSalir
        '
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(1)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(31, 38)
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'cmd_Racks
        '
        Me.cmd_Racks.Image = CType(resources.GetObject("cmd_Racks.Image"), System.Drawing.Image)
        Me.cmd_Racks.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmd_Racks.Margin = New System.Windows.Forms.Padding(1)
        Me.cmd_Racks.Name = "cmd_Racks"
        Me.cmd_Racks.Size = New System.Drawing.Size(39, 38)
        Me.cmd_Racks.Text = "&Racks"
        Me.cmd_Racks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdNuevo, Me.ToolStripSeparator3, Me.cmd_Racks, Me.separador1, Me.btnRegistrarIngreso, Me.ToolStripSeparator1, Me.ToolStripButton1, Me.ToolStripSeparator2, Me.btnSalir, Me.ToolStripSeparator4, Me.cmdVerReporte})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(933, 40)
        Me.ToolStrip1.TabIndex = 65
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Image = CType(resources.GetObject("cmdNuevo.Image"), System.Drawing.Image)
        Me.cmdNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdNuevo.Margin = New System.Windows.Forms.Padding(1)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(42, 38)
        Me.cmdNuevo.Text = "&Nuevo"
        Me.cmdNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 40)
        '
        'separador1
        '
        Me.separador1.Name = "separador1"
        Me.separador1.Size = New System.Drawing.Size(6, 40)
        '
        'btnRegistrarIngreso
        '
        Me.btnRegistrarIngreso.Image = CType(resources.GetObject("btnRegistrarIngreso.Image"), System.Drawing.Image)
        Me.btnRegistrarIngreso.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRegistrarIngreso.Name = "btnRegistrarIngreso"
        Me.btnRegistrarIngreso.Size = New System.Drawing.Size(96, 37)
        Me.btnRegistrarIngreso.Text = "&Registrar Entrada"
        Me.btnRegistrarIngreso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 40)
        '
        'cmdVerReporte
        '
        Me.cmdVerReporte.Image = CType(resources.GetObject("cmdVerReporte.Image"), System.Drawing.Image)
        Me.cmdVerReporte.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdVerReporte.Margin = New System.Windows.Forms.Padding(1)
        Me.cmdVerReporte.Name = "cmdVerReporte"
        Me.cmdVerReporte.Size = New System.Drawing.Size(44, 38)
        Me.cmdVerReporte.Text = "&Detalle"
        Me.cmdVerReporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 112)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.DGAlmacenes)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.DGRacks)
        Me.SplitContainer1.Size = New System.Drawing.Size(933, 349)
        Me.SplitContainer1.SplitterDistance = 402
        Me.SplitContainer1.TabIndex = 0
        '
        'DGAlmacenes
        '
        Me.DGAlmacenes.AllowUserToAddRows = False
        Me.DGAlmacenes.AllowUserToDeleteRows = False
        Me.DGAlmacenes.AllowUserToResizeRows = False
        Me.DGAlmacenes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGAlmacenes.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DGAlmacenes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGAlmacenes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.ActiveBorder
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGAlmacenes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.DGAlmacenes.ColumnHeadersHeight = 40
        Me.DGAlmacenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGAlmacenes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGAlmacenes.EnableHeadersVisualStyles = False
        Me.DGAlmacenes.Location = New System.Drawing.Point(0, 0)
        Me.DGAlmacenes.MultiSelect = False
        Me.DGAlmacenes.Name = "DGAlmacenes"
        Me.DGAlmacenes.ReadOnly = True
        Me.DGAlmacenes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGAlmacenes.RowHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.DGAlmacenes.RowHeadersVisible = False
        DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DGAlmacenes.RowsDefaultCellStyle = DataGridViewCellStyle15
        Me.DGAlmacenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGAlmacenes.Size = New System.Drawing.Size(402, 349)
        Me.DGAlmacenes.TabIndex = 71
        '
        'DGRacks
        '
        Me.DGRacks.AllowUserToAddRows = False
        Me.DGRacks.AllowUserToDeleteRows = False
        Me.DGRacks.AllowUserToResizeRows = False
        Me.DGRacks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGRacks.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DGRacks.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGRacks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.ActiveBorder
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGRacks.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle16
        Me.DGRacks.ColumnHeadersHeight = 40
        Me.DGRacks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGRacks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGRacks.EnableHeadersVisualStyles = False
        Me.DGRacks.Location = New System.Drawing.Point(0, 0)
        Me.DGRacks.MultiSelect = False
        Me.DGRacks.Name = "DGRacks"
        Me.DGRacks.ReadOnly = True
        Me.DGRacks.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGRacks.RowHeadersDefaultCellStyle = DataGridViewCellStyle17
        Me.DGRacks.RowHeadersVisible = False
        DataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DGRacks.RowsDefaultCellStyle = DataGridViewCellStyle18
        Me.DGRacks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGRacks.Size = New System.Drawing.Size(527, 349)
        Me.DGRacks.TabIndex = 71
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(107, 37)
        Me.ToolStripButton1.Text = "&Ingreso Excepcional"
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 40)
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 40)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 461)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.DGAlmacenes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGRacks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSalir As ToolStripButton
    Friend WithEvents cmd_Racks As ToolStripButton
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents cmdBuscar As FontAwesome.Sharp.IconButton
    Friend WithEvents txtProveedores As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cmdNuevo As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents separador1 As ToolStripSeparator
    Friend WithEvents Panel2 As Panel
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DGAlmacenes As DataGridView
    Friend WithEvents DGRacks As DataGridView
    Friend WithEvents btnRegistrarIngreso As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents cmdVerReporte As ToolStripButton
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
End Class
