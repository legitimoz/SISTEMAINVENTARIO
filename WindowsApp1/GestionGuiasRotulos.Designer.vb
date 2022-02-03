<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionGuiasRotulos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GestionGuiasRotulos))
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CheckMarcar = New System.Windows.Forms.CheckBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.cmdVerDetalle = New System.Windows.Forms.ToolStripButton()
        Me.separador5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdCerrar = New System.Windows.Forms.ToolStripButton()
        Me.txt_numero = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dt_desde = New System.Windows.Forms.DateTimePicker()
        Me.dt_hasta = New System.Windows.Forms.DateTimePicker()
        Me.btnBuscar = New FontAwesome.Sharp.IconButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_transportistas = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Dg_Cabecera = New System.Windows.Forms.DataGridView()
        Me.Panel6.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.Dg_Cabecera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.Control
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel6.Controls.Add(Me.Panel2)
        Me.Panel6.Controls.Add(Me.Panel1)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1295, 426)
        Me.Panel6.TabIndex = 54
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Dg_Cabecera)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 133)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1291, 289)
        Me.Panel2.TabIndex = 48
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CheckMarcar)
        Me.Panel1.Controls.Add(Me.ToolStrip1)
        Me.Panel1.Controls.Add(Me.txt_numero)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.dt_desde)
        Me.Panel1.Controls.Add(Me.dt_hasta)
        Me.Panel1.Controls.Add(Me.btnBuscar)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.cmb_transportistas)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1291, 133)
        Me.Panel1.TabIndex = 47
        '
        'CheckMarcar
        '
        Me.CheckMarcar.AutoSize = True
        Me.CheckMarcar.Location = New System.Drawing.Point(20, 113)
        Me.CheckMarcar.Name = "CheckMarcar"
        Me.CheckMarcar.Size = New System.Drawing.Size(87, 17)
        Me.CheckMarcar.TabIndex = 84
        Me.CheckMarcar.Text = "Marcar Todo"
        Me.CheckMarcar.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStrip1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdVerDetalle, Me.separador5, Me.ToolStripButton1, Me.ToolStripSeparator1, Me.cmdCerrar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(1291, 40)
        Me.ToolStrip1.TabIndex = 83
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'cmdVerDetalle
        '
        Me.cmdVerDetalle.Image = CType(resources.GetObject("cmdVerDetalle.Image"), System.Drawing.Image)
        Me.cmdVerDetalle.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdVerDetalle.Margin = New System.Windows.Forms.Padding(1)
        Me.cmdVerDetalle.Name = "cmdVerDetalle"
        Me.cmdVerDetalle.Size = New System.Drawing.Size(84, 38)
        Me.cmdVerDetalle.Text = "&Rotulos Masivo"
        Me.cmdVerDetalle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'separador5
        '
        Me.separador5.Name = "separador5"
        Me.separador5.Size = New System.Drawing.Size(6, 40)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Margin = New System.Windows.Forms.Padding(1)
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(94, 38)
        Me.ToolStripButton1.Text = "&Rotulos Provincia"
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 40)
        '
        'cmdCerrar
        '
        Me.cmdCerrar.Image = CType(resources.GetObject("cmdCerrar.Image"), System.Drawing.Image)
        Me.cmdCerrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdCerrar.Margin = New System.Windows.Forms.Padding(1)
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.Size = New System.Drawing.Size(32, 38)
        Me.cmdCerrar.Text = "&Salir"
        Me.cmdCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'txt_numero
        '
        Me.txt_numero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_numero.Location = New System.Drawing.Point(420, 80)
        Me.txt_numero.Name = "txt_numero"
        Me.txt_numero.Size = New System.Drawing.Size(219, 20)
        Me.txt_numero.TabIndex = 82
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(335, 83)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 14)
        Me.Label6.TabIndex = 81
        Me.Label6.Text = "Nº Documento:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'dt_desde
        '
        Me.dt_desde.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt_desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_desde.Location = New System.Drawing.Point(95, 49)
        Me.dt_desde.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dt_desde.Name = "dt_desde"
        Me.dt_desde.Size = New System.Drawing.Size(208, 20)
        Me.dt_desde.TabIndex = 80
        '
        'dt_hasta
        '
        Me.dt_hasta.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt_hasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_hasta.Location = New System.Drawing.Point(420, 49)
        Me.dt_hasta.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dt_hasta.Name = "dt_hasta"
        Me.dt_hasta.Size = New System.Drawing.Size(219, 20)
        Me.dt_hasta.TabIndex = 79
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.SystemColors.Control
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnBuscar.FlatAppearance.BorderSize = 0
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search
        Me.btnBuscar.IconColor = System.Drawing.SystemColors.ControlText
        Me.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.btnBuscar.IconSize = 16
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(644, 50)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.btnBuscar.Size = New System.Drawing.Size(25, 20)
        Me.btnBuscar.TabIndex = 78
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 14)
        Me.Label4.TabIndex = 69
        Me.Label4.Text = "Almacen: "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cmb_transportistas
        '
        Me.cmb_transportistas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_transportistas.FormattingEnabled = True
        Me.cmb_transportistas.Location = New System.Drawing.Point(94, 79)
        Me.cmb_transportistas.Name = "cmb_transportistas"
        Me.cmb_transportistas.Size = New System.Drawing.Size(209, 21)
        Me.cmb_transportistas.TabIndex = 67
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(17, 53)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 14)
        Me.Label8.TabIndex = 61
        Me.Label8.Text = "Desde:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(377, 53)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 14)
        Me.Label9.TabIndex = 65
        Me.Label9.Text = "Hasta:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Dg_Cabecera
        '
        Me.Dg_Cabecera.AllowUserToAddRows = False
        Me.Dg_Cabecera.AllowUserToDeleteRows = False
        Me.Dg_Cabecera.AllowUserToResizeColumns = False
        Me.Dg_Cabecera.AllowUserToResizeRows = False
        Me.Dg_Cabecera.BackgroundColor = System.Drawing.Color.White
        Me.Dg_Cabecera.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Dg_Cabecera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dg_Cabecera.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dg_Cabecera.Location = New System.Drawing.Point(0, 0)
        Me.Dg_Cabecera.MultiSelect = False
        Me.Dg_Cabecera.Name = "Dg_Cabecera"
        Me.Dg_Cabecera.RowHeadersVisible = False
        Me.Dg_Cabecera.RowTemplate.Height = 24
        Me.Dg_Cabecera.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dg_Cabecera.Size = New System.Drawing.Size(1291, 289)
        Me.Dg_Cabecera.TabIndex = 51
        '
        'GestionGuiasRotulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1295, 426)
        Me.Controls.Add(Me.Panel6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "GestionGuiasRotulos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GestionGuiasRotulos"
        Me.Panel6.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.Dg_Cabecera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents separador5 As ToolStripSeparator
    Friend WithEvents cmdCerrar As ToolStripButton
    Friend WithEvents txt_numero As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents dt_desde As DateTimePicker
    Friend WithEvents dt_hasta As DateTimePicker
    Friend WithEvents btnBuscar As FontAwesome.Sharp.IconButton
    Friend WithEvents Label4 As Label
    Friend WithEvents cmb_transportistas As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cmdVerDetalle As ToolStripButton
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents CheckMarcar As CheckBox
    Friend WithEvents Dg_Cabecera As DataGridView
End Class
