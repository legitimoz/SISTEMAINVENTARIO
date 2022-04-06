<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditarRuta
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
        Me.Dg_Detalle = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_comentario = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmb_tipoenvio = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_totalpeso = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_importe = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_tiempo = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_volumen = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmb_tipotransporte = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpFecRuta = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbxTransportista = New System.Windows.Forms.ComboBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmdAceptar = New FontAwesome.Sharp.IconButton()
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
        Me.GUIA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CTD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ALMACEN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Bultos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Peso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TiempoGuia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoRuta = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.VoluemnUn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RestriccionUn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImporteUn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Condicion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Representante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idcosto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombrecosto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHARECEPCION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HORARECEPCION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SITE = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DEPARTAMENTO = New WindowsApp1.ProgressColumn()
        Me.PROVINCIA = New WindowsApp1.ProgressColumn()
        Me.DISTRITO = New WindowsApp1.ProgressColumn()
        Me.FISICO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.siteliq = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Dg_Detalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Dg_Detalle
        '
        Me.Dg_Detalle.AllowUserToAddRows = False
        Me.Dg_Detalle.BackgroundColor = System.Drawing.Color.White
        Me.Dg_Detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dg_Detalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.GUIA, Me.CTD, Me.ALMACEN, Me.Cliente, Me.Direccion, Me.Bultos, Me.Peso, Me.TiempoGuia, Me.TipoRuta, Me.VoluemnUn, Me.RestriccionUn, Me.ImporteUn, Me.Condicion, Me.Representante, Me.idcosto, Me.nombrecosto, Me.FECHARECEPCION, Me.HORARECEPCION, Me.SITE, Me.DEPARTAMENTO, Me.PROVINCIA, Me.DISTRITO, Me.FISICO, Me.siteliq})
        Me.Dg_Detalle.Location = New System.Drawing.Point(12, 147)
        Me.Dg_Detalle.Name = "Dg_Detalle"
        Me.Dg_Detalle.Size = New System.Drawing.Size(943, 288)
        Me.Dg_Detalle.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.txt_comentario)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.cmb_tipoenvio)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txt_totalpeso)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txt_importe)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txt_tiempo)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txt_volumen)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.cmb_tipotransporte)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.dtpFecRuta)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cbxTransportista)
        Me.Panel1.Location = New System.Drawing.Point(12, 7)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(943, 120)
        Me.Panel1.TabIndex = 142
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(25, 39)
        Me.Label10.Margin = New System.Windows.Forms.Padding(10, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 14)
        Me.Label10.TabIndex = 160
        Me.Label10.Text = "Comentario : "
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txt_comentario
        '
        Me.txt_comentario.Location = New System.Drawing.Point(101, 36)
        Me.txt_comentario.Name = "txt_comentario"
        Me.txt_comentario.Size = New System.Drawing.Size(190, 20)
        Me.txt_comentario.TabIndex = 159
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(336, 11)
        Me.Label8.Margin = New System.Windows.Forms.Padding(10, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 14)
        Me.Label8.TabIndex = 158
        Me.Label8.Text = "Tipo Envío : "
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cmb_tipoenvio
        '
        Me.cmb_tipoenvio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tipoenvio.DropDownWidth = 200
        Me.cmb_tipoenvio.FormattingEnabled = True
        Me.cmb_tipoenvio.Items.AddRange(New Object() {"TODOS", "EXCLUSIVO", "CONSOLIDADO"})
        Me.cmb_tipoenvio.Location = New System.Drawing.Point(407, 8)
        Me.cmb_tipoenvio.Name = "cmb_tipoenvio"
        Me.cmb_tipoenvio.Size = New System.Drawing.Size(190, 21)
        Me.cmb_tipoenvio.TabIndex = 157
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(612, 11)
        Me.Label6.Margin = New System.Windows.Forms.Padding(10, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 14)
        Me.Label6.TabIndex = 156
        Me.Label6.Text = "Total Peso : "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txt_totalpeso
        '
        Me.txt_totalpeso.AutoSize = True
        Me.txt_totalpeso.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_totalpeso.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txt_totalpeso.Location = New System.Drawing.Point(681, 10)
        Me.txt_totalpeso.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txt_totalpeso.MaximumSize = New System.Drawing.Size(120, 20)
        Me.txt_totalpeso.MinimumSize = New System.Drawing.Size(120, 20)
        Me.txt_totalpeso.Name = "txt_totalpeso"
        Me.txt_totalpeso.Size = New System.Drawing.Size(120, 20)
        Me.txt_totalpeso.TabIndex = 155
        Me.txt_totalpeso.Text = "-"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(327, 94)
        Me.Label7.Margin = New System.Windows.Forms.Padding(10, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 14)
        Me.Label7.TabIndex = 154
        Me.Label7.Text = "Total Importe : "
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txt_importe
        '
        Me.txt_importe.AutoSize = True
        Me.txt_importe.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_importe.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txt_importe.Location = New System.Drawing.Point(407, 93)
        Me.txt_importe.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txt_importe.MaximumSize = New System.Drawing.Size(120, 20)
        Me.txt_importe.MinimumSize = New System.Drawing.Size(120, 20)
        Me.txt_importe.Name = "txt_importe"
        Me.txt_importe.Size = New System.Drawing.Size(120, 20)
        Me.txt_importe.TabIndex = 153
        Me.txt_importe.Text = "-"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(327, 69)
        Me.Label5.Margin = New System.Windows.Forms.Padding(10, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 14)
        Me.Label5.TabIndex = 152
        Me.Label5.Text = "Total Tiempo : "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txt_tiempo
        '
        Me.txt_tiempo.AutoSize = True
        Me.txt_tiempo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tiempo.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txt_tiempo.Location = New System.Drawing.Point(407, 68)
        Me.txt_tiempo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txt_tiempo.MaximumSize = New System.Drawing.Size(120, 20)
        Me.txt_tiempo.MinimumSize = New System.Drawing.Size(120, 20)
        Me.txt_tiempo.Name = "txt_tiempo"
        Me.txt_tiempo.Size = New System.Drawing.Size(120, 20)
        Me.txt_tiempo.TabIndex = 151
        Me.txt_tiempo.Text = "-"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(327, 42)
        Me.Label4.Margin = New System.Windows.Forms.Padding(10, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 14)
        Me.Label4.TabIndex = 150
        Me.Label4.Text = "Total Metros : "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txt_volumen
        '
        Me.txt_volumen.AutoSize = True
        Me.txt_volumen.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_volumen.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txt_volumen.Location = New System.Drawing.Point(407, 41)
        Me.txt_volumen.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txt_volumen.MaximumSize = New System.Drawing.Size(120, 20)
        Me.txt_volumen.MinimumSize = New System.Drawing.Size(120, 20)
        Me.txt_volumen.Name = "txt_volumen"
        Me.txt_volumen.Size = New System.Drawing.Size(120, 20)
        Me.txt_volumen.TabIndex = 149
        Me.txt_volumen.Text = "-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(15, 65)
        Me.Label3.Margin = New System.Windows.Forms.Padding(10, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 14)
        Me.Label3.TabIndex = 148
        Me.Label3.Text = "Tipo Vehiculo : "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cmb_tipotransporte
        '
        Me.cmb_tipotransporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tipotransporte.DropDownWidth = 200
        Me.cmb_tipotransporte.FormattingEnabled = True
        Me.cmb_tipotransporte.Location = New System.Drawing.Point(101, 62)
        Me.cmb_tipotransporte.Name = "cmb_tipotransporte"
        Me.cmb_tipotransporte.Size = New System.Drawing.Size(190, 21)
        Me.cmb_tipotransporte.TabIndex = 147
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(24, 91)
        Me.Label2.Margin = New System.Windows.Forms.Padding(10, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 14)
        Me.Label2.TabIndex = 146
        Me.Label2.Text = "Fecha Ruta : "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'dtpFecRuta
        '
        Me.dtpFecRuta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecRuta.Location = New System.Drawing.Point(101, 88)
        Me.dtpFecRuta.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpFecRuta.Name = "dtpFecRuta"
        Me.dtpFecRuta.Size = New System.Drawing.Size(190, 20)
        Me.dtpFecRuta.TabIndex = 145
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(15, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(10, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 14)
        Me.Label1.TabIndex = 144
        Me.Label1.Text = "Transportista : "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cbxTransportista
        '
        Me.cbxTransportista.BackColor = System.Drawing.Color.White
        Me.cbxTransportista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTransportista.DropDownWidth = 350
        Me.cbxTransportista.FormattingEnabled = True
        Me.cbxTransportista.Location = New System.Drawing.Point(101, 9)
        Me.cbxTransportista.Margin = New System.Windows.Forms.Padding(2)
        Me.cbxTransportista.Name = "cbxTransportista"
        Me.cbxTransportista.Size = New System.Drawing.Size(190, 21)
        Me.cbxTransportista.TabIndex = 143
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(9, 130)
        Me.Label9.Margin = New System.Windows.Forms.Padding(10, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 14)
        Me.Label9.TabIndex = 155
        Me.Label9.Text = "DETALLE RUTA : "
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAceptar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdAceptar.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen
        Me.cmdAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAceptar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.ForeColor = System.Drawing.Color.ForestGreen
        Me.cmdAceptar.IconChar = FontAwesome.Sharp.IconChar.CheckCircle
        Me.cmdAceptar.IconColor = System.Drawing.Color.ForestGreen
        Me.cmdAceptar.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.cmdAceptar.IconSize = 16
        Me.cmdAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAceptar.Location = New System.Drawing.Point(845, 447)
        Me.cmdAceptar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.cmdAceptar.Size = New System.Drawing.Size(110, 26)
        Me.cmdAceptar.TabIndex = 141
        Me.cmdAceptar.Text = "Aceptar"
        Me.cmdAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdAceptar.UseVisualStyleBackColor = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.FillWeight = 77.77779!
        Me.DataGridViewTextBoxColumn1.HeaderText = "Guia"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.FillWeight = 86.65882!
        Me.DataGridViewTextBoxColumn2.HeaderText = "Ctd"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 111
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.FillWeight = 94.55309!
        Me.DataGridViewTextBoxColumn3.HeaderText = "Almacen"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 122
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.FillWeight = 101.5702!
        Me.DataGridViewTextBoxColumn4.HeaderText = "Cliente"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 131
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.FillWeight = 107.8076!
        Me.DataGridViewTextBoxColumn5.HeaderText = "Direccion"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 138
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.FillWeight = 113.3521!
        Me.DataGridViewTextBoxColumn6.HeaderText = "Bultos"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 146
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.FillWeight = 118.2804!
        Me.DataGridViewTextBoxColumn7.HeaderText = "Peso"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 152
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "Tiempo"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = "Volumen"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Visible = False
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.HeaderText = "Restriccion"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Visible = False
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.HeaderText = "Importe"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.HeaderText = "Condicion"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Visible = False
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.HeaderText = "Representante"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Visible = False
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.HeaderText = "idcosto"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Visible = False
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.HeaderText = "Centro Costo"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.HeaderText = "FECHARECEP"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.Visible = False
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.HeaderText = "horarecepcion"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.Visible = False
        '
        'GUIA
        '
        Me.GUIA.FillWeight = 77.77779!
        Me.GUIA.HeaderText = "Guia"
        Me.GUIA.Name = "GUIA"
        '
        'CTD
        '
        Me.CTD.FillWeight = 86.65882!
        Me.CTD.HeaderText = "Ctd"
        Me.CTD.Name = "CTD"
        Me.CTD.Width = 111
        '
        'ALMACEN
        '
        Me.ALMACEN.FillWeight = 94.55309!
        Me.ALMACEN.HeaderText = "Almacen"
        Me.ALMACEN.Name = "ALMACEN"
        Me.ALMACEN.Width = 122
        '
        'Cliente
        '
        Me.Cliente.FillWeight = 101.5702!
        Me.Cliente.HeaderText = "Cliente"
        Me.Cliente.Name = "Cliente"
        Me.Cliente.Width = 131
        '
        'Direccion
        '
        Me.Direccion.FillWeight = 107.8076!
        Me.Direccion.HeaderText = "Direccion"
        Me.Direccion.Name = "Direccion"
        Me.Direccion.Width = 138
        '
        'Bultos
        '
        Me.Bultos.FillWeight = 113.3521!
        Me.Bultos.HeaderText = "Bultos"
        Me.Bultos.Name = "Bultos"
        Me.Bultos.Width = 146
        '
        'Peso
        '
        Me.Peso.FillWeight = 118.2804!
        Me.Peso.HeaderText = "Peso"
        Me.Peso.Name = "Peso"
        Me.Peso.Width = 152
        '
        'TiempoGuia
        '
        Me.TiempoGuia.HeaderText = "Tiempo"
        Me.TiempoGuia.Name = "TiempoGuia"
        '
        'TipoRuta
        '
        Me.TipoRuta.HeaderText = "Tipo Ruta"
        Me.TipoRuta.Items.AddRange(New Object() {"DESPACHO", "RECOJO"})
        Me.TipoRuta.Name = "TipoRuta"
        '
        'VoluemnUn
        '
        Me.VoluemnUn.HeaderText = "Volumen"
        Me.VoluemnUn.Name = "VoluemnUn"
        Me.VoluemnUn.Visible = False
        '
        'RestriccionUn
        '
        Me.RestriccionUn.HeaderText = "Restriccion"
        Me.RestriccionUn.Name = "RestriccionUn"
        Me.RestriccionUn.Visible = False
        '
        'ImporteUn
        '
        Me.ImporteUn.HeaderText = "Importe"
        Me.ImporteUn.Name = "ImporteUn"
        '
        'Condicion
        '
        Me.Condicion.HeaderText = "Condicion"
        Me.Condicion.Name = "Condicion"
        Me.Condicion.Visible = False
        '
        'Representante
        '
        Me.Representante.HeaderText = "Representante"
        Me.Representante.Name = "Representante"
        Me.Representante.Visible = False
        '
        'idcosto
        '
        Me.idcosto.HeaderText = "idcosto"
        Me.idcosto.Name = "idcosto"
        Me.idcosto.Visible = False
        '
        'nombrecosto
        '
        Me.nombrecosto.HeaderText = "Centro Costo"
        Me.nombrecosto.Name = "nombrecosto"
        '
        'FECHARECEPCION
        '
        Me.FECHARECEPCION.HeaderText = "FECHARECEP"
        Me.FECHARECEPCION.Name = "FECHARECEPCION"
        Me.FECHARECEPCION.Visible = False
        '
        'HORARECEPCION
        '
        Me.HORARECEPCION.HeaderText = "horarecepcion"
        Me.HORARECEPCION.Name = "HORARECEPCION"
        Me.HORARECEPCION.Visible = False
        '
        'SITE
        '
        Me.SITE.HeaderText = "Site"
        Me.SITE.Name = "SITE"
        '
        'DEPARTAMENTO
        '
        Me.DEPARTAMENTO.HeaderText = "DEPARTAMENTO"
        Me.DEPARTAMENTO.Name = "DEPARTAMENTO"
        Me.DEPARTAMENTO.Visible = False
        '
        'PROVINCIA
        '
        Me.PROVINCIA.HeaderText = "PROVINCIA"
        Me.PROVINCIA.Name = "PROVINCIA"
        Me.PROVINCIA.Visible = False
        '
        'DISTRITO
        '
        Me.DISTRITO.HeaderText = "DISTRITO"
        Me.DISTRITO.Name = "DISTRITO"
        Me.DISTRITO.Visible = False
        '
        'FISICO
        '
        Me.FISICO.HeaderText = "Column1"
        Me.FISICO.Name = "FISICO"
        Me.FISICO.Visible = False
        '
        'siteliq
        '
        Me.siteliq.HeaderText = "Column1"
        Me.siteliq.Name = "siteliq"
        Me.siteliq.Visible = False
        '
        'EditarRuta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(974, 486)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.Dg_Detalle)
        Me.MaximizeBox = False
        Me.Name = "EditarRuta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar Ruta"
        CType(Me.Dg_Detalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Dg_Detalle As DataGridView
    Friend WithEvents cmdAceptar As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents cbxTransportista As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpFecRuta As DateTimePicker
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Label3 As Label
    Friend WithEvents cmb_tipotransporte As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_tiempo As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_volumen As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_importe As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_totalpeso As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cmb_tipoenvio As ComboBox
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
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_comentario As TextBox
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents GUIA As DataGridViewTextBoxColumn
    Friend WithEvents CTD As DataGridViewTextBoxColumn
    Friend WithEvents ALMACEN As DataGridViewTextBoxColumn
    Friend WithEvents Cliente As DataGridViewTextBoxColumn
    Friend WithEvents Direccion As DataGridViewTextBoxColumn
    Friend WithEvents Bultos As DataGridViewTextBoxColumn
    Friend WithEvents Peso As DataGridViewTextBoxColumn
    Friend WithEvents TiempoGuia As DataGridViewTextBoxColumn
    Friend WithEvents TipoRuta As DataGridViewComboBoxColumn
    Friend WithEvents VoluemnUn As DataGridViewTextBoxColumn
    Friend WithEvents RestriccionUn As DataGridViewTextBoxColumn
    Friend WithEvents ImporteUn As DataGridViewTextBoxColumn
    Friend WithEvents Condicion As DataGridViewTextBoxColumn
    Friend WithEvents Representante As DataGridViewTextBoxColumn
    Friend WithEvents idcosto As DataGridViewTextBoxColumn
    Friend WithEvents nombrecosto As DataGridViewTextBoxColumn
    Friend WithEvents FECHARECEPCION As DataGridViewTextBoxColumn
    Friend WithEvents HORARECEPCION As DataGridViewTextBoxColumn
    Friend WithEvents SITE As DataGridViewComboBoxColumn
    Friend WithEvents DEPARTAMENTO As ProgressColumn
    Friend WithEvents PROVINCIA As ProgressColumn
    Friend WithEvents DISTRITO As ProgressColumn
    Friend WithEvents FISICO As DataGridViewTextBoxColumn
    Friend WithEvents siteliq As DataGridViewTextBoxColumn
End Class
