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
        Me.cmdAceptar = New FontAwesome.Sharp.IconButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpFecRuta = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbxTransportista = New System.Windows.Forms.ComboBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.cmb_tipotransporte = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_volumen = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_tiempo = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_importe = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_totalpeso = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmb_tipoenvio = New System.Windows.Forms.ComboBox()
        Me.GUIA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CTD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ALMACEN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Bultos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Peso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TiempoGuia = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.Dg_Detalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.GUIA, Me.CTD, Me.ALMACEN, Me.Cliente, Me.Direccion, Me.Bultos, Me.Peso, Me.TiempoGuia})
        Me.Dg_Detalle.Location = New System.Drawing.Point(12, 147)
        Me.Dg_Detalle.Name = "Dg_Detalle"
        Me.Dg_Detalle.Size = New System.Drawing.Size(943, 288)
        Me.Dg_Detalle.TabIndex = 0
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
        Me.cmdAceptar.Location = New System.Drawing.Point(851, 447)
        Me.cmdAceptar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.cmdAceptar.Size = New System.Drawing.Size(103, 26)
        Me.cmdAceptar.TabIndex = 141
        Me.cmdAceptar.Text = "Aceptar"
        Me.cmdAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdAceptar.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(24, 64)
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
        Me.dtpFecRuta.Location = New System.Drawing.Point(101, 61)
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
        'cmb_tipotransporte
        '
        Me.cmb_tipotransporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tipotransporte.DropDownWidth = 200
        Me.cmb_tipotransporte.FormattingEnabled = True
        Me.cmb_tipotransporte.Location = New System.Drawing.Point(101, 35)
        Me.cmb_tipotransporte.Name = "cmb_tipotransporte"
        Me.cmb_tipotransporte.Size = New System.Drawing.Size(190, 21)
        Me.cmb_tipotransporte.TabIndex = 147
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(15, 38)
        Me.Label3.Margin = New System.Windows.Forms.Padding(10, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 14)
        Me.Label3.TabIndex = 148
        Me.Label3.Text = "Tipo Vehiculo : "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txt_volumen
        '
        Me.txt_volumen.AutoSize = True
        Me.txt_volumen.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_volumen.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txt_volumen.Location = New System.Drawing.Point(410, 11)
        Me.txt_volumen.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txt_volumen.MaximumSize = New System.Drawing.Size(120, 20)
        Me.txt_volumen.MinimumSize = New System.Drawing.Size(120, 20)
        Me.txt_volumen.Name = "txt_volumen"
        Me.txt_volumen.Size = New System.Drawing.Size(120, 20)
        Me.txt_volumen.TabIndex = 149
        Me.txt_volumen.Text = "-"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(330, 12)
        Me.Label4.Margin = New System.Windows.Forms.Padding(10, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 14)
        Me.Label4.TabIndex = 150
        Me.Label4.Text = "Total Metros : "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(330, 39)
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
        Me.txt_tiempo.Location = New System.Drawing.Point(410, 38)
        Me.txt_tiempo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txt_tiempo.MaximumSize = New System.Drawing.Size(120, 20)
        Me.txt_tiempo.MinimumSize = New System.Drawing.Size(120, 20)
        Me.txt_tiempo.Name = "txt_tiempo"
        Me.txt_tiempo.Size = New System.Drawing.Size(120, 20)
        Me.txt_tiempo.TabIndex = 151
        Me.txt_tiempo.Text = "-"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(330, 64)
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
        Me.txt_importe.Location = New System.Drawing.Point(410, 63)
        Me.txt_importe.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txt_importe.MaximumSize = New System.Drawing.Size(120, 20)
        Me.txt_importe.MinimumSize = New System.Drawing.Size(120, 20)
        Me.txt_importe.Name = "txt_importe"
        Me.txt_importe.Size = New System.Drawing.Size(120, 20)
        Me.txt_importe.TabIndex = 153
        Me.txt_importe.Text = "-"
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
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(341, 89)
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
        Me.txt_totalpeso.Location = New System.Drawing.Point(410, 88)
        Me.txt_totalpeso.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txt_totalpeso.MaximumSize = New System.Drawing.Size(120, 20)
        Me.txt_totalpeso.MinimumSize = New System.Drawing.Size(120, 20)
        Me.txt_totalpeso.Name = "txt_totalpeso"
        Me.txt_totalpeso.Size = New System.Drawing.Size(120, 20)
        Me.txt_totalpeso.TabIndex = 155
        Me.txt_totalpeso.Text = "-"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(30, 89)
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
        Me.cmb_tipoenvio.Location = New System.Drawing.Point(101, 86)
        Me.cmb_tipoenvio.Name = "cmb_tipoenvio"
        Me.cmb_tipoenvio.Size = New System.Drawing.Size(190, 21)
        Me.cmb_tipoenvio.TabIndex = 157
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
        'EditarRuta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(967, 486)
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
    Friend WithEvents GUIA As DataGridViewTextBoxColumn
    Friend WithEvents CTD As DataGridViewTextBoxColumn
    Friend WithEvents ALMACEN As DataGridViewTextBoxColumn
    Friend WithEvents Cliente As DataGridViewTextBoxColumn
    Friend WithEvents Direccion As DataGridViewTextBoxColumn
    Friend WithEvents Bultos As DataGridViewTextBoxColumn
    Friend WithEvents Peso As DataGridViewTextBoxColumn
    Friend WithEvents TiempoGuia As DataGridViewTextBoxColumn
End Class
