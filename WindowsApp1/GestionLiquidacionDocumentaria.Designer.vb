<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GestionLiquidacionDocumentaria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GestionLiquidacionDocumentaria))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_indlima = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_dentrolim = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_cantlim = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_indpro = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_dentropro = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_cantpro = New System.Windows.Forms.Label()
        Me.lbl_indicador = New System.Windows.Forms.Label()
        Me.txt_indicador = New System.Windows.Forms.Label()
        Me.LBL_can = New System.Windows.Forms.Label()
        Me.txt_cantatiempo = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_Cantpedidos = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdGenerarExcel = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdCerrar = New System.Windows.Forms.ToolStripButton()
        Me.dt_desde = New System.Windows.Forms.DateTimePicker()
        Me.dt_hasta = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnBuscar = New FontAwesome.Sharp.IconButton()
        Me.Dg_Cabecera = New System.Windows.Forms.DataGridView()
        Me.savedialog_Excel = New System.Windows.Forms.SaveFileDialog()
        Me.Panel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.Dg_Cabecera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.txt_indlima)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.txt_dentrolim)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.txt_cantlim)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txt_indpro)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txt_dentropro)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txt_cantpro)
        Me.Panel1.Controls.Add(Me.lbl_indicador)
        Me.Panel1.Controls.Add(Me.txt_indicador)
        Me.Panel1.Controls.Add(Me.LBL_can)
        Me.Panel1.Controls.Add(Me.txt_cantatiempo)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txt_Cantpedidos)
        Me.Panel1.Controls.Add(Me.ToolStrip1)
        Me.Panel1.Controls.Add(Me.dt_desde)
        Me.Panel1.Controls.Add(Me.dt_hasta)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.btnBuscar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1299, 115)
        Me.Panel1.TabIndex = 56
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(1011, 96)
        Me.Label11.Margin = New System.Windows.Forms.Padding(10, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(99, 14)
        Me.Label11.TabIndex = 135
        Me.Label11.Text = "Liq. Documentaria :"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txt_indlima
        '
        Me.txt_indlima.AutoSize = True
        Me.txt_indlima.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_indlima.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txt_indlima.Location = New System.Drawing.Point(1118, 96)
        Me.txt_indlima.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txt_indlima.MaximumSize = New System.Drawing.Size(50, 18)
        Me.txt_indlima.MinimumSize = New System.Drawing.Size(50, 18)
        Me.txt_indlima.Name = "txt_indlima"
        Me.txt_indlima.Size = New System.Drawing.Size(50, 18)
        Me.txt_indlima.TabIndex = 136
        Me.txt_indlima.Text = "-"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(1026, 71)
        Me.Label13.Margin = New System.Windows.Forms.Padding(10, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(84, 14)
        Me.Label13.TabIndex = 133
        Me.Label13.Text = "Cant. a Tiempo :"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txt_dentrolim
        '
        Me.txt_dentrolim.AutoSize = True
        Me.txt_dentrolim.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_dentrolim.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txt_dentrolim.Location = New System.Drawing.Point(1118, 71)
        Me.txt_dentrolim.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txt_dentrolim.MaximumSize = New System.Drawing.Size(50, 18)
        Me.txt_dentrolim.MinimumSize = New System.Drawing.Size(50, 18)
        Me.txt_dentrolim.Name = "txt_dentrolim"
        Me.txt_dentrolim.Size = New System.Drawing.Size(50, 18)
        Me.txt_dentrolim.TabIndex = 134
        Me.txt_dentrolim.Text = "-"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(1047, 48)
        Me.Label15.Margin = New System.Windows.Forms.Padding(10, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(63, 14)
        Me.Label15.TabIndex = 131
        Me.Label15.Text = "Cant. Lima :"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txt_cantlim
        '
        Me.txt_cantlim.AutoSize = True
        Me.txt_cantlim.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cantlim.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txt_cantlim.Location = New System.Drawing.Point(1118, 48)
        Me.txt_cantlim.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txt_cantlim.MaximumSize = New System.Drawing.Size(50, 18)
        Me.txt_cantlim.MinimumSize = New System.Drawing.Size(50, 18)
        Me.txt_cantlim.Name = "txt_cantlim"
        Me.txt_cantlim.Size = New System.Drawing.Size(50, 18)
        Me.txt_cantlim.TabIndex = 132
        Me.txt_cantlim.Text = "-"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(846, 93)
        Me.Label5.Margin = New System.Windows.Forms.Padding(10, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 14)
        Me.Label5.TabIndex = 129
        Me.Label5.Text = "Liq. Documentaria :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txt_indpro
        '
        Me.txt_indpro.AutoSize = True
        Me.txt_indpro.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_indpro.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txt_indpro.Location = New System.Drawing.Point(953, 93)
        Me.txt_indpro.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txt_indpro.MaximumSize = New System.Drawing.Size(50, 18)
        Me.txt_indpro.MinimumSize = New System.Drawing.Size(50, 18)
        Me.txt_indpro.Name = "txt_indpro"
        Me.txt_indpro.Size = New System.Drawing.Size(50, 18)
        Me.txt_indpro.TabIndex = 130
        Me.txt_indpro.Text = "-"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(861, 68)
        Me.Label7.Margin = New System.Windows.Forms.Padding(10, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 14)
        Me.Label7.TabIndex = 127
        Me.Label7.Text = "Cant. a Tiempo :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txt_dentropro
        '
        Me.txt_dentropro.AutoSize = True
        Me.txt_dentropro.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_dentropro.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txt_dentropro.Location = New System.Drawing.Point(953, 68)
        Me.txt_dentropro.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txt_dentropro.MaximumSize = New System.Drawing.Size(50, 18)
        Me.txt_dentropro.MinimumSize = New System.Drawing.Size(50, 18)
        Me.txt_dentropro.Name = "txt_dentropro"
        Me.txt_dentropro.Size = New System.Drawing.Size(50, 18)
        Me.txt_dentropro.TabIndex = 128
        Me.txt_dentropro.Text = "-"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(860, 45)
        Me.Label1.Margin = New System.Windows.Forms.Padding(10, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 14)
        Me.Label1.TabIndex = 125
        Me.Label1.Text = "Cant. Provincia :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txt_cantpro
        '
        Me.txt_cantpro.AutoSize = True
        Me.txt_cantpro.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cantpro.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txt_cantpro.Location = New System.Drawing.Point(953, 45)
        Me.txt_cantpro.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txt_cantpro.MaximumSize = New System.Drawing.Size(50, 18)
        Me.txt_cantpro.MinimumSize = New System.Drawing.Size(50, 18)
        Me.txt_cantpro.Name = "txt_cantpro"
        Me.txt_cantpro.Size = New System.Drawing.Size(50, 18)
        Me.txt_cantpro.TabIndex = 126
        Me.txt_cantpro.Text = "-"
        '
        'lbl_indicador
        '
        Me.lbl_indicador.AutoSize = True
        Me.lbl_indicador.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_indicador.ForeColor = System.Drawing.Color.Black
        Me.lbl_indicador.Location = New System.Drawing.Point(680, 93)
        Me.lbl_indicador.Margin = New System.Windows.Forms.Padding(10, 0, 4, 0)
        Me.lbl_indicador.Name = "lbl_indicador"
        Me.lbl_indicador.Size = New System.Drawing.Size(99, 14)
        Me.lbl_indicador.TabIndex = 123
        Me.lbl_indicador.Text = "Liq. Documentaria :"
        Me.lbl_indicador.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txt_indicador
        '
        Me.txt_indicador.AutoSize = True
        Me.txt_indicador.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_indicador.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txt_indicador.Location = New System.Drawing.Point(787, 93)
        Me.txt_indicador.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txt_indicador.MaximumSize = New System.Drawing.Size(50, 18)
        Me.txt_indicador.MinimumSize = New System.Drawing.Size(50, 18)
        Me.txt_indicador.Name = "txt_indicador"
        Me.txt_indicador.Size = New System.Drawing.Size(50, 18)
        Me.txt_indicador.TabIndex = 124
        Me.txt_indicador.Text = "-"
        '
        'LBL_can
        '
        Me.LBL_can.AutoSize = True
        Me.LBL_can.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_can.ForeColor = System.Drawing.Color.Black
        Me.LBL_can.Location = New System.Drawing.Point(695, 68)
        Me.LBL_can.Margin = New System.Windows.Forms.Padding(10, 0, 4, 0)
        Me.LBL_can.Name = "LBL_can"
        Me.LBL_can.Size = New System.Drawing.Size(84, 14)
        Me.LBL_can.TabIndex = 121
        Me.LBL_can.Text = "Cant. a Tiempo :"
        Me.LBL_can.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txt_cantatiempo
        '
        Me.txt_cantatiempo.AutoSize = True
        Me.txt_cantatiempo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cantatiempo.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txt_cantatiempo.Location = New System.Drawing.Point(787, 68)
        Me.txt_cantatiempo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txt_cantatiempo.MaximumSize = New System.Drawing.Size(50, 18)
        Me.txt_cantatiempo.MinimumSize = New System.Drawing.Size(50, 18)
        Me.txt_cantatiempo.Name = "txt_cantatiempo"
        Me.txt_cantatiempo.Size = New System.Drawing.Size(50, 18)
        Me.txt_cantatiempo.TabIndex = 122
        Me.txt_cantatiempo.Text = "-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(700, 45)
        Me.Label3.Margin = New System.Windows.Forms.Padding(10, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 14)
        Me.Label3.TabIndex = 119
        Me.Label3.Text = "Cant. Pedidos :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txt_Cantpedidos
        '
        Me.txt_Cantpedidos.AutoSize = True
        Me.txt_Cantpedidos.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Cantpedidos.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txt_Cantpedidos.Location = New System.Drawing.Point(787, 45)
        Me.txt_Cantpedidos.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txt_Cantpedidos.MaximumSize = New System.Drawing.Size(50, 18)
        Me.txt_Cantpedidos.MinimumSize = New System.Drawing.Size(50, 18)
        Me.txt_Cantpedidos.Name = "txt_Cantpedidos"
        Me.txt_Cantpedidos.Size = New System.Drawing.Size(50, 18)
        Me.txt_Cantpedidos.TabIndex = 120
        Me.txt_Cantpedidos.Text = "-"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStrip1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator2, Me.cmdGenerarExcel, Me.ToolStripSeparator1, Me.ToolStripButton2, Me.ToolStripSeparator3, Me.cmdCerrar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(1299, 40)
        Me.ToolStrip1.TabIndex = 85
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 40)
        '
        'cmdGenerarExcel
        '
        Me.cmdGenerarExcel.Image = CType(resources.GetObject("cmdGenerarExcel.Image"), System.Drawing.Image)
        Me.cmdGenerarExcel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdGenerarExcel.Margin = New System.Windows.Forms.Padding(1)
        Me.cmdGenerarExcel.Name = "cmdGenerarExcel"
        Me.cmdGenerarExcel.Size = New System.Drawing.Size(81, 38)
        Me.cmdGenerarExcel.Text = "&Exportar Excel"
        Me.cmdGenerarExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 40)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Margin = New System.Windows.Forms.Padding(1)
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(85, 38)
        Me.ToolStripButton2.Text = "&Agregar Motivo"
        Me.ToolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 40)
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
        'dt_desde
        '
        Me.dt_desde.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt_desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_desde.Location = New System.Drawing.Point(91, 48)
        Me.dt_desde.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dt_desde.Name = "dt_desde"
        Me.dt_desde.Size = New System.Drawing.Size(208, 20)
        Me.dt_desde.TabIndex = 84
        '
        'dt_hasta
        '
        Me.dt_hasta.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt_hasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_hasta.Location = New System.Drawing.Point(420, 48)
        Me.dt_hasta.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dt_hasta.Name = "dt_hasta"
        Me.dt_hasta.Size = New System.Drawing.Size(209, 20)
        Me.dt_hasta.TabIndex = 83
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(5, 52)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 14)
        Me.Label8.TabIndex = 81
        Me.Label8.Text = "Desde:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(360, 52)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 14)
        Me.Label9.TabIndex = 82
        Me.Label9.Text = "Hasta:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
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
        Me.btnBuscar.Location = New System.Drawing.Point(634, 48)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.btnBuscar.Size = New System.Drawing.Size(25, 20)
        Me.btnBuscar.TabIndex = 78
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'Dg_Cabecera
        '
        Me.Dg_Cabecera.AllowUserToAddRows = False
        Me.Dg_Cabecera.AllowUserToDeleteRows = False
        Me.Dg_Cabecera.AllowUserToResizeRows = False
        Me.Dg_Cabecera.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Dg_Cabecera.BackgroundColor = System.Drawing.Color.White
        Me.Dg_Cabecera.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Dg_Cabecera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dg_Cabecera.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dg_Cabecera.Location = New System.Drawing.Point(0, 115)
        Me.Dg_Cabecera.Name = "Dg_Cabecera"
        Me.Dg_Cabecera.RowHeadersVisible = False
        Me.Dg_Cabecera.RowTemplate.Height = 24
        Me.Dg_Cabecera.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dg_Cabecera.Size = New System.Drawing.Size(1299, 315)
        Me.Dg_Cabecera.TabIndex = 57
        '
        'GestionLiquidacionDocumentaria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1299, 430)
        Me.Controls.Add(Me.Dg_Cabecera)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "GestionLiquidacionDocumentaria"
        Me.Text = "GestionLiquidacionDocumentaria"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.Dg_Cabecera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents cmdGenerarExcel As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents cmdCerrar As ToolStripButton
    Friend WithEvents dt_desde As DateTimePicker
    Friend WithEvents dt_hasta As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnBuscar As FontAwesome.Sharp.IconButton
    Friend WithEvents Dg_Cabecera As DataGridView
    Friend WithEvents savedialog_Excel As SaveFileDialog
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_indlima As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txt_dentrolim As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txt_cantlim As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_indpro As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_dentropro As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_cantpro As Label
    Friend WithEvents lbl_indicador As Label
    Friend WithEvents txt_indicador As Label
    Friend WithEvents LBL_can As Label
    Friend WithEvents txt_cantatiempo As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_Cantpedidos As Label
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
End Class
