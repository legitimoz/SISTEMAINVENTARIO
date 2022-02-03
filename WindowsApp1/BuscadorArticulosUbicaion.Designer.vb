<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BuscadorArticulosUbicaion
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BuscadorArticulosUbicaion))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dt_hasta = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dt_desde = New System.Windows.Forms.DateTimePicker()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.cmdVerReporte = New System.Windows.Forms.ToolStripButton()
        Me.separador1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdActulizarDatos = New System.Windows.Forms.ToolStripButton()
        Me.separador4 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnSalir = New System.Windows.Forms.ToolStripButton()
        Me.txt_descr = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_codprod = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_codlote = New System.Windows.Forms.TextBox()
        Me.cmdBuscar = New FontAwesome.Sharp.IconButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DgArticulos = New System.Windows.Forms.DataGridView()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DgArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(264, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 14)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "Hasta:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'dt_hasta
        '
        Me.dt_hasta.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt_hasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_hasta.Location = New System.Drawing.Point(366, 6)
        Me.dt_hasta.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dt_hasta.Name = "dt_hasta"
        Me.dt_hasta.Size = New System.Drawing.Size(160, 20)
        Me.dt_hasta.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 14)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "Desde:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'dt_desde
        '
        Me.dt_desde.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt_desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_desde.Location = New System.Drawing.Point(80, 6)
        Me.dt_desde.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dt_desde.Name = "dt_desde"
        Me.dt_desde.Size = New System.Drawing.Size(160, 20)
        Me.dt_desde.TabIndex = 5
        Me.dt_desde.Value = New Date(2019, 12, 25, 0, 0, 0, 0)
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdVerReporte, Me.separador1, Me.cmdActulizarDatos, Me.separador4, Me.btnSalir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(884, 41)
        Me.ToolStrip1.TabIndex = 29
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'cmdVerReporte
        '
        Me.cmdVerReporte.Image = CType(resources.GetObject("cmdVerReporte.Image"), System.Drawing.Image)
        Me.cmdVerReporte.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdVerReporte.Margin = New System.Windows.Forms.Padding(1)
        Me.cmdVerReporte.Name = "cmdVerReporte"
        Me.cmdVerReporte.Size = New System.Drawing.Size(43, 39)
        Me.cmdVerReporte.Text = "&Detalle"
        Me.cmdVerReporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'separador1
        '
        Me.separador1.Name = "separador1"
        Me.separador1.Size = New System.Drawing.Size(6, 41)
        '
        'cmdActulizarDatos
        '
        Me.cmdActulizarDatos.Image = CType(resources.GetObject("cmdActulizarDatos.Image"), System.Drawing.Image)
        Me.cmdActulizarDatos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdActulizarDatos.Name = "cmdActulizarDatos"
        Me.cmdActulizarDatos.Size = New System.Drawing.Size(91, 38)
        Me.cmdActulizarDatos.Text = "&Actualizar Datos"
        Me.cmdActulizarDatos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'separador4
        '
        Me.separador4.Name = "separador4"
        Me.separador4.Size = New System.Drawing.Size(6, 41)
        '
        'btnSalir
        '
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(1)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(32, 39)
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'txt_descr
        '
        Me.txt_descr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_descr.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_descr.Location = New System.Drawing.Point(616, 38)
        Me.txt_descr.Name = "txt_descr"
        Me.txt_descr.Size = New System.Drawing.Size(160, 20)
        Me.txt_descr.TabIndex = 77
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(543, 41)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 14)
        Me.Label7.TabIndex = 76
        Me.Label7.Text = "Descripcion:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txt_codprod
        '
        Me.txt_codprod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_codprod.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_codprod.Location = New System.Drawing.Point(366, 38)
        Me.txt_codprod.Name = "txt_codprod"
        Me.txt_codprod.Size = New System.Drawing.Size(160, 20)
        Me.txt_codprod.TabIndex = 75
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(265, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 14)
        Me.Label6.TabIndex = 73
        Me.Label6.Text = "Cod Producto : "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 14)
        Me.Label2.TabIndex = 71
        Me.Label2.Text = "Lote : "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txt_codlote
        '
        Me.txt_codlote.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_codlote.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_codlote.Location = New System.Drawing.Point(80, 38)
        Me.txt_codlote.Name = "txt_codlote"
        Me.txt_codlote.Size = New System.Drawing.Size(160, 20)
        Me.txt_codlote.TabIndex = 69
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
        Me.cmdBuscar.Location = New System.Drawing.Point(782, 38)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.cmdBuscar.Size = New System.Drawing.Size(25, 20)
        Me.cmdBuscar.TabIndex = 66
        Me.cmdBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdBuscar.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.cmdBuscar)
        Me.Panel2.Controls.Add(Me.txt_descr)
        Me.Panel2.Controls.Add(Me.dt_desde)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.txt_codprod)
        Me.Panel2.Controls.Add(Me.txt_codlote)
        Me.Panel2.Controls.Add(Me.dt_hasta)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 41)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(884, 76)
        Me.Panel2.TabIndex = 60
        '
        'DgArticulos
        '
        Me.DgArticulos.AllowUserToAddRows = False
        Me.DgArticulos.AllowUserToDeleteRows = False
        Me.DgArticulos.AllowUserToResizeRows = False
        Me.DgArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgArticulos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DgArticulos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgArticulos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveBorder
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgArticulos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgArticulos.ColumnHeadersHeight = 40
        Me.DgArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgArticulos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgArticulos.EnableHeadersVisualStyles = False
        Me.DgArticulos.Location = New System.Drawing.Point(0, 117)
        Me.DgArticulos.MultiSelect = False
        Me.DgArticulos.Name = "DgArticulos"
        Me.DgArticulos.ReadOnly = True
        Me.DgArticulos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgArticulos.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgArticulos.RowHeadersVisible = False
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DgArticulos.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DgArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgArticulos.Size = New System.Drawing.Size(884, 344)
        Me.DgArticulos.TabIndex = 64
        '
        'BuscadorArticulosUbicaion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 461)
        Me.Controls.Add(Me.DgArticulos)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Name = "BuscadorArticulosUbicaion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GestionContratacionForm"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DgArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As Label
    Friend WithEvents dt_hasta As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents dt_desde As DateTimePicker
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents cmdVerReporte As ToolStripButton
    Friend WithEvents separador1 As ToolStripSeparator
    Friend WithEvents btnSalir As ToolStripButton
    Friend WithEvents cmdBuscar As FontAwesome.Sharp.IconButton
    Friend WithEvents txt_descr As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_codprod As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_codlote As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cmdActulizarDatos As ToolStripButton
    Friend WithEvents separador4 As ToolStripSeparator
    Friend WithEvents DgArticulos As DataGridView
End Class
