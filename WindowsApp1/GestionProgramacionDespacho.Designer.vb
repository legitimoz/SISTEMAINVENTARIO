﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionProgramacionDespacho
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GestionProgramacionDespacho))
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Dg_Cabecera = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.CheckMarcar = New System.Windows.Forms.CheckBox()
        Me.txt_numero = New System.Windows.Forms.TextBox()
        Me.dt_hasta = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dt_desde = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnBuscar = New FontAwesome.Sharp.IconButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.cmdGenerarExcel = New System.Windows.Forms.ToolStripButton()
        Me.separador5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdCerrar = New System.Windows.Forms.ToolStripButton()
        Me.savedialog_Excel = New System.Windows.Forms.SaveFileDialog()
        Me.MARCAR = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESTADO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHA_GUIA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HORA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HORA_GUIA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COD_PED = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NRO_GUIA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONDICION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RUC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOM_CLIENTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DIRECCION_ENTREGA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UBIGEO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PROVINCIA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DEPARTAMENTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DISTRITO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LIMA_PROV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CANAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TRANSPORTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M3UN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IMPORTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M3FIN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIEMPOENTREGA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESTINO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RUTA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DETALLE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RESTRICCION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REPRESENTANTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C5_CTD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C5_CALMA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel6.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Dg_Cabecera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
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
        Me.Panel6.Size = New System.Drawing.Size(1299, 430)
        Me.Panel6.TabIndex = 55
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Dg_Cabecera)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 139)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1295, 287)
        Me.Panel2.TabIndex = 48
        '
        'Dg_Cabecera
        '
        Me.Dg_Cabecera.AllowDrop = True
        Me.Dg_Cabecera.AllowUserToAddRows = False
        Me.Dg_Cabecera.AllowUserToDeleteRows = False
        Me.Dg_Cabecera.BackgroundColor = System.Drawing.Color.White
        Me.Dg_Cabecera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dg_Cabecera.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MARCAR, Me.ESTADO, Me.FECHA, Me.FECHA_GUIA, Me.HORA, Me.HORA_GUIA, Me.COD_PED, Me.NRO_GUIA, Me.CONDICION, Me.RUC, Me.NOM_CLIENTE, Me.DIRECCION_ENTREGA, Me.UBIGEO, Me.PROVINCIA, Me.DEPARTAMENTO, Me.DISTRITO, Me.LIMA_PROV, Me.CANAL, Me.TRANSPORTE, Me.M3UN, Me.IMPORTE, Me.M3FIN, Me.TIEMPOENTREGA, Me.DESTINO, Me.RUTA, Me.DETALLE, Me.RESTRICCION, Me.REPRESENTANTE, Me.C5_CTD, Me.C5_CALMA})
        Me.Dg_Cabecera.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dg_Cabecera.Location = New System.Drawing.Point(0, 0)
        Me.Dg_Cabecera.Margin = New System.Windows.Forms.Padding(0)
        Me.Dg_Cabecera.MultiSelect = False
        Me.Dg_Cabecera.Name = "Dg_Cabecera"
        Me.Dg_Cabecera.RowHeadersVisible = False
        Me.Dg_Cabecera.RowHeadersWidth = 20
        Me.Dg_Cabecera.RowTemplate.Height = 20
        Me.Dg_Cabecera.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dg_Cabecera.Size = New System.Drawing.Size(1295, 287)
        Me.Dg_Cabecera.TabIndex = 9
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.ToolStrip1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1295, 139)
        Me.Panel1.TabIndex = 47
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.CheckMarcar)
        Me.Panel3.Controls.Add(Me.txt_numero)
        Me.Panel3.Controls.Add(Me.dt_hasta)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.dt_desde)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.btnBuscar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 40)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1295, 99)
        Me.Panel3.TabIndex = 50
        '
        'CheckMarcar
        '
        Me.CheckMarcar.AutoSize = True
        Me.CheckMarcar.Location = New System.Drawing.Point(13, 76)
        Me.CheckMarcar.Name = "CheckMarcar"
        Me.CheckMarcar.Size = New System.Drawing.Size(87, 17)
        Me.CheckMarcar.TabIndex = 90
        Me.CheckMarcar.Text = "Marcar Todo"
        Me.CheckMarcar.UseVisualStyleBackColor = True
        '
        'txt_numero
        '
        Me.txt_numero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_numero.Location = New System.Drawing.Point(95, 43)
        Me.txt_numero.Name = "txt_numero"
        Me.txt_numero.Size = New System.Drawing.Size(209, 20)
        Me.txt_numero.TabIndex = 89
        '
        'dt_hasta
        '
        Me.dt_hasta.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt_hasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_hasta.Location = New System.Drawing.Point(408, 12)
        Me.dt_hasta.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dt_hasta.Name = "dt_hasta"
        Me.dt_hasta.Size = New System.Drawing.Size(219, 20)
        Me.dt_hasta.TabIndex = 86
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(10, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 14)
        Me.Label6.TabIndex = 88
        Me.Label6.Text = "Nº Documento:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(365, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 14)
        Me.Label9.TabIndex = 84
        Me.Label9.Text = "Hasta:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'dt_desde
        '
        Me.dt_desde.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt_desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_desde.Location = New System.Drawing.Point(95, 12)
        Me.dt_desde.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dt_desde.Name = "dt_desde"
        Me.dt_desde.Size = New System.Drawing.Size(208, 20)
        Me.dt_desde.TabIndex = 87
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(17, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 14)
        Me.Label8.TabIndex = 83
        Me.Label8.Text = "Desde:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
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
        Me.btnBuscar.Location = New System.Drawing.Point(632, 13)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.btnBuscar.Size = New System.Drawing.Size(25, 20)
        Me.btnBuscar.TabIndex = 85
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStrip1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdGenerarExcel, Me.separador5, Me.ToolStripButton1, Me.ToolStripSeparator1, Me.ToolStripButton2, Me.ToolStripSeparator2, Me.cmdCerrar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(1295, 40)
        Me.ToolStrip1.TabIndex = 49
        Me.ToolStrip1.Text = "ToolStrip1"
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
        Me.ToolStripButton1.Size = New System.Drawing.Size(86, 38)
        Me.ToolStripButton1.Text = "&Procesar Rutas"
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
        Me.ToolStripButton2.Size = New System.Drawing.Size(112, 38)
        Me.ToolStripButton2.Text = "&Confirmar Recepcion"
        Me.ToolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 40)
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
        'MARCAR
        '
        Me.MARCAR.HeaderText = "Marcar"
        Me.MARCAR.Name = "MARCAR"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Fecha Guia"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Hora"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Condicion Pago"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Hora Guia"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Cod Pedido"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "N° Guia"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "Ruc Cliente"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = "Cliente"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.HeaderText = "Direccion Entrega"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.HeaderText = "Ubigeo"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.HeaderText = "Provincia"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.HeaderText = "Departamento"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.HeaderText = "Distrito"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.HeaderText = "Lima / Provincia"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.HeaderText = "Canal"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.HeaderText = "Transporte"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.HeaderText = "Metros Cubicos"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.HeaderText = "Importe"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.HeaderText = "M. Cubicos Final"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.HeaderText = "Tiempo Entrega"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.HeaderText = "Destino"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.HeaderText = "Ruta"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.HeaderText = "Detalle Ruta"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.HeaderText = "Restriccion"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.HeaderText = "Representante"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.HeaderText = "Estado"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.HeaderText = "C5_CTD"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        Me.DataGridViewTextBoxColumn28.Visible = False
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.HeaderText = "C5_CALMA"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        Me.DataGridViewTextBoxColumn29.Visible = False
        '
        'ESTADO
        '
        Me.ESTADO.HeaderText = "Estado"
        Me.ESTADO.Name = "ESTADO"
        '
        'FECHA
        '
        Me.FECHA.HeaderText = "Fecha"
        Me.FECHA.Name = "FECHA"
        Me.FECHA.Visible = False
        '
        'FECHA_GUIA
        '
        Me.FECHA_GUIA.HeaderText = "Fecha Guia"
        Me.FECHA_GUIA.Name = "FECHA_GUIA"
        '
        'HORA
        '
        Me.HORA.HeaderText = "Hora"
        Me.HORA.Name = "HORA"
        '
        'HORA_GUIA
        '
        Me.HORA_GUIA.HeaderText = "Hora Guia"
        Me.HORA_GUIA.Name = "HORA_GUIA"
        Me.HORA_GUIA.Visible = False
        '
        'COD_PED
        '
        Me.COD_PED.HeaderText = "Cod Pedido"
        Me.COD_PED.Name = "COD_PED"
        '
        'NRO_GUIA
        '
        Me.NRO_GUIA.HeaderText = "N° Guia"
        Me.NRO_GUIA.Name = "NRO_GUIA"
        '
        'CONDICION
        '
        Me.CONDICION.HeaderText = "Condicion Pago"
        Me.CONDICION.Name = "CONDICION"
        '
        'RUC
        '
        Me.RUC.HeaderText = "Ruc Cliente"
        Me.RUC.Name = "RUC"
        '
        'NOM_CLIENTE
        '
        Me.NOM_CLIENTE.HeaderText = "Cliente"
        Me.NOM_CLIENTE.Name = "NOM_CLIENTE"
        '
        'DIRECCION_ENTREGA
        '
        Me.DIRECCION_ENTREGA.HeaderText = "Direccion Entrega"
        Me.DIRECCION_ENTREGA.Name = "DIRECCION_ENTREGA"
        '
        'UBIGEO
        '
        Me.UBIGEO.HeaderText = "Ubigeo"
        Me.UBIGEO.Name = "UBIGEO"
        '
        'PROVINCIA
        '
        Me.PROVINCIA.HeaderText = "Provincia"
        Me.PROVINCIA.Name = "PROVINCIA"
        '
        'DEPARTAMENTO
        '
        Me.DEPARTAMENTO.HeaderText = "Departamento"
        Me.DEPARTAMENTO.Name = "DEPARTAMENTO"
        '
        'DISTRITO
        '
        Me.DISTRITO.HeaderText = "Distrito"
        Me.DISTRITO.Name = "DISTRITO"
        '
        'LIMA_PROV
        '
        Me.LIMA_PROV.HeaderText = "Lima / Provincia"
        Me.LIMA_PROV.Name = "LIMA_PROV"
        '
        'CANAL
        '
        Me.CANAL.HeaderText = "Canal"
        Me.CANAL.Name = "CANAL"
        '
        'TRANSPORTE
        '
        Me.TRANSPORTE.HeaderText = "Transporte"
        Me.TRANSPORTE.Name = "TRANSPORTE"
        '
        'M3UN
        '
        Me.M3UN.HeaderText = "Metros Cubicos"
        Me.M3UN.Name = "M3UN"
        '
        'IMPORTE
        '
        Me.IMPORTE.HeaderText = "Importe"
        Me.IMPORTE.Name = "IMPORTE"
        '
        'M3FIN
        '
        Me.M3FIN.HeaderText = "M. Cubicos Final"
        Me.M3FIN.Name = "M3FIN"
        '
        'TIEMPOENTREGA
        '
        Me.TIEMPOENTREGA.HeaderText = "Tiempo Entrega"
        Me.TIEMPOENTREGA.Name = "TIEMPOENTREGA"
        '
        'DESTINO
        '
        Me.DESTINO.HeaderText = "Destino"
        Me.DESTINO.Name = "DESTINO"
        '
        'RUTA
        '
        Me.RUTA.HeaderText = "Ruta"
        Me.RUTA.Name = "RUTA"
        '
        'DETALLE
        '
        Me.DETALLE.HeaderText = "Detalle Ruta"
        Me.DETALLE.Name = "DETALLE"
        '
        'RESTRICCION
        '
        Me.RESTRICCION.HeaderText = "Restriccion"
        Me.RESTRICCION.Name = "RESTRICCION"
        '
        'REPRESENTANTE
        '
        Me.REPRESENTANTE.HeaderText = "Representante"
        Me.REPRESENTANTE.Name = "REPRESENTANTE"
        '
        'C5_CTD
        '
        Me.C5_CTD.HeaderText = "C5_CTD"
        Me.C5_CTD.Name = "C5_CTD"
        Me.C5_CTD.Visible = False
        '
        'C5_CALMA
        '
        Me.C5_CALMA.HeaderText = "C5_CALMA"
        Me.C5_CALMA.Name = "C5_CALMA"
        Me.C5_CALMA.Visible = False
        '
        'GestionProgramacionDespacho
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1299, 430)
        Me.Controls.Add(Me.Panel6)
        Me.Name = "GestionProgramacionDespacho"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GestionProgramacionDespacho"
        Me.Panel6.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.Dg_Cabecera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents savedialog_Excel As SaveFileDialog
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txt_numero As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents dt_desde As DateTimePicker
    Friend WithEvents dt_hasta As DateTimePicker
    Friend WithEvents btnBuscar As FontAwesome.Sharp.IconButton
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents cmdGenerarExcel As ToolStripButton
    Friend WithEvents separador5 As ToolStripSeparator
    Friend WithEvents cmdCerrar As ToolStripButton
    Friend WithEvents CheckMarcar As CheckBox
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents Dg_Cabecera As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As DataGridViewTextBoxColumn
    Friend WithEvents MARCAR As DataGridViewCheckBoxColumn
    Friend WithEvents ESTADO As DataGridViewTextBoxColumn
    Friend WithEvents FECHA As DataGridViewTextBoxColumn
    Friend WithEvents FECHA_GUIA As DataGridViewTextBoxColumn
    Friend WithEvents HORA As DataGridViewTextBoxColumn
    Friend WithEvents HORA_GUIA As DataGridViewTextBoxColumn
    Friend WithEvents COD_PED As DataGridViewTextBoxColumn
    Friend WithEvents NRO_GUIA As DataGridViewTextBoxColumn
    Friend WithEvents CONDICION As DataGridViewTextBoxColumn
    Friend WithEvents RUC As DataGridViewTextBoxColumn
    Friend WithEvents NOM_CLIENTE As DataGridViewTextBoxColumn
    Friend WithEvents DIRECCION_ENTREGA As DataGridViewTextBoxColumn
    Friend WithEvents UBIGEO As DataGridViewTextBoxColumn
    Friend WithEvents PROVINCIA As DataGridViewTextBoxColumn
    Friend WithEvents DEPARTAMENTO As DataGridViewTextBoxColumn
    Friend WithEvents DISTRITO As DataGridViewTextBoxColumn
    Friend WithEvents LIMA_PROV As DataGridViewTextBoxColumn
    Friend WithEvents CANAL As DataGridViewTextBoxColumn
    Friend WithEvents TRANSPORTE As DataGridViewTextBoxColumn
    Friend WithEvents M3UN As DataGridViewTextBoxColumn
    Friend WithEvents IMPORTE As DataGridViewTextBoxColumn
    Friend WithEvents M3FIN As DataGridViewTextBoxColumn
    Friend WithEvents TIEMPOENTREGA As DataGridViewTextBoxColumn
    Friend WithEvents DESTINO As DataGridViewTextBoxColumn
    Friend WithEvents RUTA As DataGridViewTextBoxColumn
    Friend WithEvents DETALLE As DataGridViewTextBoxColumn
    Friend WithEvents RESTRICCION As DataGridViewTextBoxColumn
    Friend WithEvents REPRESENTANTE As DataGridViewTextBoxColumn
    Friend WithEvents C5_CTD As DataGridViewTextBoxColumn
    Friend WithEvents C5_CALMA As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As DataGridViewTextBoxColumn
End Class