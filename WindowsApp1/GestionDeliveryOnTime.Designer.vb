<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GestionDeliveryOnTime
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GestionDeliveryOnTime))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_cantpro = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_filtro = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lbl_indicador = New System.Windows.Forms.Label()
        Me.txt_indicador = New System.Windows.Forms.Label()
        Me.LBL_can = New System.Windows.Forms.Label()
        Me.txt_cantatiempo = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_Cantpedidos = New System.Windows.Forms.Label()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.dt_hasta = New System.Windows.Forms.DateTimePicker()
        Me.dt_desde = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Dg_Cabecera = New System.Windows.Forms.DataGridView()
        Me.savedialog_Excel = New System.Windows.Forms.SaveFileDialog()
        Me.txt_guia = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Dg_Cabecera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1299, 81)
        Me.Panel1.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txt_guia)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txt_indlima)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txt_dentrolim)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txt_cantlim)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_indpro)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txt_dentropro)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txt_cantpro)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmb_filtro)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.lbl_indicador)
        Me.GroupBox1.Controls.Add(Me.txt_indicador)
        Me.GroupBox1.Controls.Add(Me.LBL_can)
        Me.GroupBox1.Controls.Add(Me.txt_cantatiempo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_Cantpedidos)
        Me.GroupBox1.Controls.Add(Me.btnExportar)
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.dt_hasta)
        Me.GroupBox1.Controls.Add(Me.dt_desde)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1291, 78)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(1122, 59)
        Me.Label11.Margin = New System.Windows.Forms.Padding(10, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(100, 14)
        Me.Label11.TabIndex = 117
        Me.Label11.Text = "Delivery One Time :"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txt_indlima
        '
        Me.txt_indlima.AutoSize = True
        Me.txt_indlima.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_indlima.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txt_indlima.Location = New System.Drawing.Point(1230, 59)
        Me.txt_indlima.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txt_indlima.MaximumSize = New System.Drawing.Size(50, 18)
        Me.txt_indlima.MinimumSize = New System.Drawing.Size(50, 18)
        Me.txt_indlima.Name = "txt_indlima"
        Me.txt_indlima.Size = New System.Drawing.Size(50, 18)
        Me.txt_indlima.TabIndex = 118
        Me.txt_indlima.Text = "-"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(1138, 34)
        Me.Label13.Margin = New System.Windows.Forms.Padding(10, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(84, 14)
        Me.Label13.TabIndex = 115
        Me.Label13.Text = "Cant. a Tiempo :"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txt_dentrolim
        '
        Me.txt_dentrolim.AutoSize = True
        Me.txt_dentrolim.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_dentrolim.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txt_dentrolim.Location = New System.Drawing.Point(1230, 34)
        Me.txt_dentrolim.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txt_dentrolim.MaximumSize = New System.Drawing.Size(50, 18)
        Me.txt_dentrolim.MinimumSize = New System.Drawing.Size(50, 18)
        Me.txt_dentrolim.Name = "txt_dentrolim"
        Me.txt_dentrolim.Size = New System.Drawing.Size(50, 18)
        Me.txt_dentrolim.TabIndex = 116
        Me.txt_dentrolim.Text = "-"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(1159, 11)
        Me.Label15.Margin = New System.Windows.Forms.Padding(10, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(63, 14)
        Me.Label15.TabIndex = 113
        Me.Label15.Text = "Cant. Lima :"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txt_cantlim
        '
        Me.txt_cantlim.AutoSize = True
        Me.txt_cantlim.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cantlim.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txt_cantlim.Location = New System.Drawing.Point(1230, 11)
        Me.txt_cantlim.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txt_cantlim.MaximumSize = New System.Drawing.Size(50, 18)
        Me.txt_cantlim.MinimumSize = New System.Drawing.Size(50, 18)
        Me.txt_cantlim.Name = "txt_cantlim"
        Me.txt_cantlim.Size = New System.Drawing.Size(50, 18)
        Me.txt_cantlim.TabIndex = 114
        Me.txt_cantlim.Text = "-"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(957, 56)
        Me.Label5.Margin = New System.Windows.Forms.Padding(10, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 14)
        Me.Label5.TabIndex = 111
        Me.Label5.Text = "Delivery One Time :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txt_indpro
        '
        Me.txt_indpro.AutoSize = True
        Me.txt_indpro.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_indpro.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txt_indpro.Location = New System.Drawing.Point(1065, 56)
        Me.txt_indpro.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txt_indpro.MaximumSize = New System.Drawing.Size(50, 18)
        Me.txt_indpro.MinimumSize = New System.Drawing.Size(50, 18)
        Me.txt_indpro.Name = "txt_indpro"
        Me.txt_indpro.Size = New System.Drawing.Size(50, 18)
        Me.txt_indpro.TabIndex = 112
        Me.txt_indpro.Text = "-"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(973, 31)
        Me.Label7.Margin = New System.Windows.Forms.Padding(10, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 14)
        Me.Label7.TabIndex = 109
        Me.Label7.Text = "Cant. a Tiempo :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txt_dentropro
        '
        Me.txt_dentropro.AutoSize = True
        Me.txt_dentropro.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_dentropro.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txt_dentropro.Location = New System.Drawing.Point(1065, 31)
        Me.txt_dentropro.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txt_dentropro.MaximumSize = New System.Drawing.Size(50, 18)
        Me.txt_dentropro.MinimumSize = New System.Drawing.Size(50, 18)
        Me.txt_dentropro.Name = "txt_dentropro"
        Me.txt_dentropro.Size = New System.Drawing.Size(50, 18)
        Me.txt_dentropro.TabIndex = 110
        Me.txt_dentropro.Text = "-"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(972, 8)
        Me.Label9.Margin = New System.Windows.Forms.Padding(10, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 14)
        Me.Label9.TabIndex = 107
        Me.Label9.Text = "Cant. Provincia :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txt_cantpro
        '
        Me.txt_cantpro.AutoSize = True
        Me.txt_cantpro.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cantpro.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txt_cantpro.Location = New System.Drawing.Point(1065, 8)
        Me.txt_cantpro.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txt_cantpro.MaximumSize = New System.Drawing.Size(50, 18)
        Me.txt_cantpro.MinimumSize = New System.Drawing.Size(50, 18)
        Me.txt_cantpro.Name = "txt_cantpro"
        Me.txt_cantpro.Size = New System.Drawing.Size(50, 18)
        Me.txt_cantpro.TabIndex = 108
        Me.txt_cantpro.Text = "-"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 106
        Me.Label4.Text = "Filtro:"
        '
        'cmb_filtro
        '
        Me.cmb_filtro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_filtro.FormattingEnabled = True
        Me.cmb_filtro.Items.AddRange(New Object() {"TODOS", "LOGISTICO"})
        Me.cmb_filtro.Location = New System.Drawing.Point(80, 40)
        Me.cmb_filtro.Name = "cmb_filtro"
        Me.cmb_filtro.Size = New System.Drawing.Size(101, 21)
        Me.cmb_filtro.TabIndex = 105
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(667, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 26)
        Me.Button1.TabIndex = 104
        Me.Button1.Text = "Observacion"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lbl_indicador
        '
        Me.lbl_indicador.AutoSize = True
        Me.lbl_indicador.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_indicador.ForeColor = System.Drawing.Color.Black
        Me.lbl_indicador.Location = New System.Drawing.Point(791, 56)
        Me.lbl_indicador.Margin = New System.Windows.Forms.Padding(10, 0, 4, 0)
        Me.lbl_indicador.Name = "lbl_indicador"
        Me.lbl_indicador.Size = New System.Drawing.Size(100, 14)
        Me.lbl_indicador.TabIndex = 101
        Me.lbl_indicador.Text = "Delivery One Time :"
        Me.lbl_indicador.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txt_indicador
        '
        Me.txt_indicador.AutoSize = True
        Me.txt_indicador.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_indicador.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txt_indicador.Location = New System.Drawing.Point(899, 56)
        Me.txt_indicador.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txt_indicador.MaximumSize = New System.Drawing.Size(50, 18)
        Me.txt_indicador.MinimumSize = New System.Drawing.Size(50, 18)
        Me.txt_indicador.Name = "txt_indicador"
        Me.txt_indicador.Size = New System.Drawing.Size(50, 18)
        Me.txt_indicador.TabIndex = 102
        Me.txt_indicador.Text = "-"
        '
        'LBL_can
        '
        Me.LBL_can.AutoSize = True
        Me.LBL_can.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_can.ForeColor = System.Drawing.Color.Black
        Me.LBL_can.Location = New System.Drawing.Point(807, 31)
        Me.LBL_can.Margin = New System.Windows.Forms.Padding(10, 0, 4, 0)
        Me.LBL_can.Name = "LBL_can"
        Me.LBL_can.Size = New System.Drawing.Size(84, 14)
        Me.LBL_can.TabIndex = 99
        Me.LBL_can.Text = "Cant. a Tiempo :"
        Me.LBL_can.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txt_cantatiempo
        '
        Me.txt_cantatiempo.AutoSize = True
        Me.txt_cantatiempo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cantatiempo.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txt_cantatiempo.Location = New System.Drawing.Point(899, 31)
        Me.txt_cantatiempo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txt_cantatiempo.MaximumSize = New System.Drawing.Size(50, 18)
        Me.txt_cantatiempo.MinimumSize = New System.Drawing.Size(50, 18)
        Me.txt_cantatiempo.Name = "txt_cantatiempo"
        Me.txt_cantatiempo.Size = New System.Drawing.Size(50, 18)
        Me.txt_cantatiempo.TabIndex = 100
        Me.txt_cantatiempo.Text = "-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(812, 8)
        Me.Label3.Margin = New System.Windows.Forms.Padding(10, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 14)
        Me.Label3.TabIndex = 97
        Me.Label3.Text = "Cant. Pedidos :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txt_Cantpedidos
        '
        Me.txt_Cantpedidos.AutoSize = True
        Me.txt_Cantpedidos.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Cantpedidos.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txt_Cantpedidos.Location = New System.Drawing.Point(899, 8)
        Me.txt_Cantpedidos.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txt_Cantpedidos.MaximumSize = New System.Drawing.Size(50, 18)
        Me.txt_Cantpedidos.MinimumSize = New System.Drawing.Size(50, 18)
        Me.txt_Cantpedidos.Name = "txt_Cantpedidos"
        Me.txt_Cantpedidos.Size = New System.Drawing.Size(50, 18)
        Me.txt_Cantpedidos.TabIndex = 98
        Me.txt_Cantpedidos.Text = "-"
        '
        'btnExportar
        '
        Me.btnExportar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExportar.Location = New System.Drawing.Point(542, 4)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(100, 26)
        Me.btnExportar.TabIndex = 5
        Me.btnExportar.Text = "Exportar"
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.Image = Global.WindowsApp1.My.Resources.Resources._103
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(420, 4)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(100, 26)
        Me.btnBuscar.TabIndex = 4
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'dt_hasta
        '
        Me.dt_hasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_hasta.Location = New System.Drawing.Point(262, 5)
        Me.dt_hasta.Name = "dt_hasta"
        Me.dt_hasta.Size = New System.Drawing.Size(101, 20)
        Me.dt_hasta.TabIndex = 3
        '
        'dt_desde
        '
        Me.dt_desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_desde.Location = New System.Drawing.Point(80, 5)
        Me.dt_desde.Name = "dt_desde"
        Me.dt_desde.Size = New System.Drawing.Size(101, 20)
        Me.dt_desde.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(199, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fecha Fin:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha Inicio:"
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
        Me.Dg_Cabecera.Location = New System.Drawing.Point(0, 81)
        Me.Dg_Cabecera.Name = "Dg_Cabecera"
        Me.Dg_Cabecera.RowHeadersVisible = False
        Me.Dg_Cabecera.RowTemplate.Height = 24
        Me.Dg_Cabecera.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dg_Cabecera.Size = New System.Drawing.Size(1299, 349)
        Me.Dg_Cabecera.TabIndex = 54
        '
        'txt_guia
        '
        Me.txt_guia.Location = New System.Drawing.Point(262, 40)
        Me.txt_guia.Name = "txt_guia"
        Me.txt_guia.Size = New System.Drawing.Size(101, 20)
        Me.txt_guia.TabIndex = 136
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(221, 43)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 135
        Me.Label6.Text = "Guia :"
        '
        'GestionDeliveryOnTime
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1299, 430)
        Me.Controls.Add(Me.Dg_Cabecera)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "GestionDeliveryOnTime"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GestionDeliveryOnTime"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Dg_Cabecera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Dg_Cabecera As DataGridView
    Friend WithEvents savedialog_Excel As SaveFileDialog
    Friend WithEvents GroupBox1 As GroupBox
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
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_cantpro As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmb_filtro As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents lbl_indicador As Label
    Friend WithEvents txt_indicador As Label
    Friend WithEvents LBL_can As Label
    Friend WithEvents txt_cantatiempo As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_Cantpedidos As Label
    Friend WithEvents btnExportar As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents dt_hasta As DateTimePicker
    Friend WithEvents dt_desde As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_guia As TextBox
    Friend WithEvents Label6 As Label
End Class
