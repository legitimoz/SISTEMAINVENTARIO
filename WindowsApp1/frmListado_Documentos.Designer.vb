<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListado_Documentos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListado_Documentos))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.chkCliente = New System.Windows.Forms.CheckBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btn_Exportar = New System.Windows.Forms.Button()
        Me.btn_Nuevo = New System.Windows.Forms.Button()
        Me.txtOrdenCompra = New System.Windows.Forms.TextBox()
        Me.chk_porOrdenC = New System.Windows.Forms.CheckBox()
        Me.txtComp = New System.Windows.Forms.TextBox()
        Me.chk_porComp = New System.Windows.Forms.CheckBox()
        Me.txtGuia = New System.Windows.Forms.TextBox()
        Me.chk_porGuia = New System.Windows.Forms.CheckBox()
        Me.cbxTipDoc = New System.Windows.Forms.ComboBox()
        Me.cbxArea = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpFecFin = New System.Windows.Forms.DateTimePicker()
        Me.dtpFecIni = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tslCantidad = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvListarDocumentos = New System.Windows.Forms.DataGridView()
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
        Me.ga_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ar_des = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ta_des = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C5_CNUMDOC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Comprobante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Saldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ruc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.usr_nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha_Registro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.usr_nombremod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha_Mod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.filename = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ruta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_verdoc = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.GroupBox1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvListarDocumentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txtCliente)
        Me.GroupBox1.Controls.Add(Me.chkCliente)
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.btn_Exportar)
        Me.GroupBox1.Controls.Add(Me.btn_Nuevo)
        Me.GroupBox1.Controls.Add(Me.txtOrdenCompra)
        Me.GroupBox1.Controls.Add(Me.chk_porOrdenC)
        Me.GroupBox1.Controls.Add(Me.txtComp)
        Me.GroupBox1.Controls.Add(Me.chk_porComp)
        Me.GroupBox1.Controls.Add(Me.txtGuia)
        Me.GroupBox1.Controls.Add(Me.chk_porGuia)
        Me.GroupBox1.Controls.Add(Me.cbxTipDoc)
        Me.GroupBox1.Controls.Add(Me.cbxArea)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dtpFecFin)
        Me.GroupBox1.Controls.Add(Me.dtpFecIni)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(907, 114)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Búsqueda"
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(510, 49)
        Me.txtCliente.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(348, 21)
        Me.txtCliente.TabIndex = 20
        '
        'chkCliente
        '
        Me.chkCliente.AutoSize = True
        Me.chkCliente.Location = New System.Drawing.Point(448, 50)
        Me.chkCliente.Name = "chkCliente"
        Me.chkCliente.Size = New System.Drawing.Size(63, 17)
        Me.chkCliente.TabIndex = 19
        Me.chkCliente.Text = "Cliente:"
        Me.chkCliente.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(215, 84)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(91, 23)
        Me.btnBuscar.TabIndex = 18
        Me.btnBuscar.Text = "  &Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btn_Exportar
        '
        Me.btn_Exportar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Exportar.Image = CType(resources.GetObject("btn_Exportar.Image"), System.Drawing.Image)
        Me.btn_Exportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Exportar.Location = New System.Drawing.Point(112, 84)
        Me.btn_Exportar.Name = "btn_Exportar"
        Me.btn_Exportar.Size = New System.Drawing.Size(91, 23)
        Me.btn_Exportar.TabIndex = 17
        Me.btn_Exportar.Text = "  &Exportar"
        Me.btn_Exportar.UseVisualStyleBackColor = True
        '
        'btn_Nuevo
        '
        Me.btn_Nuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Nuevo.Image = CType(resources.GetObject("btn_Nuevo.Image"), System.Drawing.Image)
        Me.btn_Nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Nuevo.Location = New System.Drawing.Point(10, 84)
        Me.btn_Nuevo.Name = "btn_Nuevo"
        Me.btn_Nuevo.Size = New System.Drawing.Size(91, 23)
        Me.btn_Nuevo.TabIndex = 1
        Me.btn_Nuevo.Text = "&Nuevo"
        Me.btn_Nuevo.UseVisualStyleBackColor = True
        '
        'txtOrdenCompra
        '
        Me.txtOrdenCompra.Enabled = False
        Me.txtOrdenCompra.Location = New System.Drawing.Point(812, 84)
        Me.txtOrdenCompra.Margin = New System.Windows.Forms.Padding(2)
        Me.txtOrdenCompra.Name = "txtOrdenCompra"
        Me.txtOrdenCompra.Size = New System.Drawing.Size(89, 21)
        Me.txtOrdenCompra.TabIndex = 16
        Me.txtOrdenCompra.Visible = False
        '
        'chk_porOrdenC
        '
        Me.chk_porOrdenC.AutoSize = True
        Me.chk_porOrdenC.Enabled = False
        Me.chk_porOrdenC.Location = New System.Drawing.Point(696, 87)
        Me.chk_porOrdenC.Name = "chk_porOrdenC"
        Me.chk_porOrdenC.Size = New System.Drawing.Size(115, 17)
        Me.chk_porOrdenC.TabIndex = 15
        Me.chk_porOrdenC.Text = "Orden de Compra:"
        Me.chk_porOrdenC.UseVisualStyleBackColor = True
        Me.chk_porOrdenC.Visible = False
        '
        'txtComp
        '
        Me.txtComp.Location = New System.Drawing.Point(345, 48)
        Me.txtComp.Margin = New System.Windows.Forms.Padding(2)
        Me.txtComp.Name = "txtComp"
        Me.txtComp.Size = New System.Drawing.Size(89, 21)
        Me.txtComp.TabIndex = 14
        '
        'chk_porComp
        '
        Me.chk_porComp.AutoSize = True
        Me.chk_porComp.Location = New System.Drawing.Point(209, 50)
        Me.chk_porComp.Name = "chk_porComp"
        Me.chk_porComp.Size = New System.Drawing.Size(135, 17)
        Me.chk_porComp.TabIndex = 13
        Me.chk_porComp.Text = "Numero Comprobante:"
        Me.chk_porComp.UseVisualStyleBackColor = True
        '
        'txtGuia
        '
        Me.txtGuia.Location = New System.Drawing.Point(100, 48)
        Me.txtGuia.Margin = New System.Windows.Forms.Padding(2)
        Me.txtGuia.Name = "txtGuia"
        Me.txtGuia.Size = New System.Drawing.Size(89, 21)
        Me.txtGuia.TabIndex = 12
        '
        'chk_porGuia
        '
        Me.chk_porGuia.AutoSize = True
        Me.chk_porGuia.Location = New System.Drawing.Point(11, 50)
        Me.chk_porGuia.Name = "chk_porGuia"
        Me.chk_porGuia.Size = New System.Drawing.Size(91, 17)
        Me.chk_porGuia.TabIndex = 11
        Me.chk_porGuia.Text = "Numero Guía:"
        Me.chk_porGuia.UseVisualStyleBackColor = True
        '
        'cbxTipDoc
        '
        Me.cbxTipDoc.BackColor = System.Drawing.Color.White
        Me.cbxTipDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTipDoc.FormattingEnabled = True
        Me.cbxTipDoc.Location = New System.Drawing.Point(713, 18)
        Me.cbxTipDoc.Margin = New System.Windows.Forms.Padding(2)
        Me.cbxTipDoc.Name = "cbxTipDoc"
        Me.cbxTipDoc.Size = New System.Drawing.Size(145, 21)
        Me.cbxTipDoc.TabIndex = 10
        '
        'cbxArea
        '
        Me.cbxArea.BackColor = System.Drawing.Color.White
        Me.cbxArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxArea.FormattingEnabled = True
        Me.cbxArea.Location = New System.Drawing.Point(448, 17)
        Me.cbxArea.Margin = New System.Windows.Forms.Padding(2)
        Me.cbxArea.Name = "cbxArea"
        Me.cbxArea.Size = New System.Drawing.Size(145, 21)
        Me.cbxArea.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(697, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(11, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = ":"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(435, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(11, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = ":"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(613, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Tipo Documento"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(406, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Area"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(240, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(11, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = ":"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(69, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(11, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = ":"
        '
        'dtpFecFin
        '
        Me.dtpFecFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecFin.Location = New System.Drawing.Point(255, 16)
        Me.dtpFecFin.Name = "dtpFecFin"
        Me.dtpFecFin.Size = New System.Drawing.Size(90, 21)
        Me.dtpFecFin.TabIndex = 3
        '
        'dtpFecIni
        '
        Me.dtpFecIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecIni.Location = New System.Drawing.Point(83, 16)
        Me.dtpFecIni.Name = "dtpFecIni"
        Me.dtpFecIni.Size = New System.Drawing.Size(90, 21)
        Me.dtpFecIni.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(191, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fecha Fin"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha Inicio"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.tslCantidad})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 474)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(917, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(165, 17)
        Me.ToolStripStatusLabel1.Text = "Total Documentos Scaneados:"
        '
        'tslCantidad
        '
        Me.tslCantidad.Name = "tslCantidad"
        Me.tslCantidad.Size = New System.Drawing.Size(13, 17)
        Me.tslCantidad.Text = "0"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.dgvListarDocumentos)
        Me.GroupBox2.Location = New System.Drawing.Point(5, 127)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(907, 347)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Listado"
        '
        'dgvListarDocumentos
        '
        Me.dgvListarDocumentos.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightBlue
        Me.dgvListarDocumentos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvListarDocumentos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvListarDocumentos.BackgroundColor = System.Drawing.Color.White
        Me.dgvListarDocumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListarDocumentos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ga_id, Me.ar_des, Me.ta_des, Me.C5_CNUMDOC, Me.Comprobante, Me.Importe, Me.Saldo, Me.Ruc, Me.Cliente, Me.usr_nombre, Me.Fecha_Registro, Me.usr_nombremod, Me.Fecha_Mod, Me.filename, Me.ruta, Me.btn_verdoc})
        Me.dgvListarDocumentos.Location = New System.Drawing.Point(4, 18)
        Me.dgvListarDocumentos.MultiSelect = False
        Me.dgvListarDocumentos.Name = "dgvListarDocumentos"
        Me.dgvListarDocumentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListarDocumentos.Size = New System.Drawing.Size(897, 321)
        Me.dgvListarDocumentos.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Codigo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 50
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Area"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Tipo Documento"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Numero Guía"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Usuario Registro"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 120
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Fecha Registro"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 70
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "Usuario Modificación"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 350
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "Fecha Modificación"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = "Nombre Archivo"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 350
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.HeaderText = "Ruta"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 150
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.HeaderText = "Ruta"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.HeaderText = "Nombre Archivo"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Width = 150
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.HeaderText = "Ruta"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.HeaderText = "Nombre Archivo"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Width = 150
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.HeaderText = "Ruta"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'ga_id
        '
        Me.ga_id.HeaderText = "Codigo"
        Me.ga_id.Name = "ga_id"
        Me.ga_id.Width = 50
        '
        'ar_des
        '
        Me.ar_des.HeaderText = "Area"
        Me.ar_des.Name = "ar_des"
        '
        'ta_des
        '
        Me.ta_des.HeaderText = "Tipo Documento"
        Me.ta_des.Name = "ta_des"
        Me.ta_des.Width = 150
        '
        'C5_CNUMDOC
        '
        Me.C5_CNUMDOC.HeaderText = "Numero Guía"
        Me.C5_CNUMDOC.Name = "C5_CNUMDOC"
        '
        'Comprobante
        '
        Me.Comprobante.HeaderText = "Nro Comprobante Venta"
        Me.Comprobante.Name = "Comprobante"
        Me.Comprobante.Width = 120
        '
        'Importe
        '
        Me.Importe.HeaderText = "Importe"
        Me.Importe.Name = "Importe"
        Me.Importe.Visible = False
        Me.Importe.Width = 70
        '
        'Saldo
        '
        Me.Saldo.HeaderText = "Saldo"
        Me.Saldo.Name = "Saldo"
        Me.Saldo.Visible = False
        Me.Saldo.Width = 70
        '
        'Ruc
        '
        Me.Ruc.HeaderText = "Ruc"
        Me.Ruc.Name = "Ruc"
        '
        'Cliente
        '
        Me.Cliente.HeaderText = "Cliente"
        Me.Cliente.Name = "Cliente"
        Me.Cliente.Width = 350
        '
        'usr_nombre
        '
        Me.usr_nombre.HeaderText = "Usuario Registro"
        Me.usr_nombre.Name = "usr_nombre"
        '
        'Fecha_Registro
        '
        Me.Fecha_Registro.HeaderText = "Fecha Registro"
        Me.Fecha_Registro.Name = "Fecha_Registro"
        '
        'usr_nombremod
        '
        Me.usr_nombremod.HeaderText = "Usuario Modificación"
        Me.usr_nombremod.Name = "usr_nombremod"
        Me.usr_nombremod.Visible = False
        '
        'Fecha_Mod
        '
        Me.Fecha_Mod.HeaderText = "Fecha Modificación"
        Me.Fecha_Mod.Name = "Fecha_Mod"
        Me.Fecha_Mod.Visible = False
        '
        'filename
        '
        Me.filename.HeaderText = "Nombre Archivo"
        Me.filename.Name = "filename"
        Me.filename.Visible = False
        Me.filename.Width = 150
        '
        'ruta
        '
        Me.ruta.HeaderText = "Ruta"
        Me.ruta.Name = "ruta"
        Me.ruta.Visible = False
        '
        'btn_verdoc
        '
        Me.btn_verdoc.HeaderText = ""
        Me.btn_verdoc.Name = "btn_verdoc"
        Me.btn_verdoc.Text = "Ver File"
        Me.btn_verdoc.ToolTipText = "Ver File"
        Me.btn_verdoc.UseColumnTextForButtonValue = True
        '
        'frmListado_Documentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(917, 496)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmListado_Documentos"
        Me.Text = "Gestor de Documentos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvListarDocumentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpFecFin As DateTimePicker
    Friend WithEvents dtpFecIni As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents chk_porGuia As CheckBox
    Friend WithEvents cbxTipDoc As ComboBox
    Friend WithEvents cbxArea As ComboBox
    Friend WithEvents txtOrdenCompra As TextBox
    Friend WithEvents chk_porOrdenC As CheckBox
    Friend WithEvents txtComp As TextBox
    Friend WithEvents chk_porComp As CheckBox
    Friend WithEvents txtGuia As TextBox
    Friend WithEvents btn_Nuevo As Button
    Friend WithEvents btn_Exportar As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents dgvListarDocumentos As DataGridView
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
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents chkCliente As CheckBox
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents tslCantidad As ToolStripStatusLabel
    Friend WithEvents ga_id As DataGridViewTextBoxColumn
    Friend WithEvents ar_des As DataGridViewTextBoxColumn
    Friend WithEvents ta_des As DataGridViewTextBoxColumn
    Friend WithEvents C5_CNUMDOC As DataGridViewTextBoxColumn
    Friend WithEvents Comprobante As DataGridViewTextBoxColumn
    Friend WithEvents Importe As DataGridViewTextBoxColumn
    Friend WithEvents Saldo As DataGridViewTextBoxColumn
    Friend WithEvents Ruc As DataGridViewTextBoxColumn
    Friend WithEvents Cliente As DataGridViewTextBoxColumn
    Friend WithEvents usr_nombre As DataGridViewTextBoxColumn
    Friend WithEvents Fecha_Registro As DataGridViewTextBoxColumn
    Friend WithEvents usr_nombremod As DataGridViewTextBoxColumn
    Friend WithEvents Fecha_Mod As DataGridViewTextBoxColumn
    Friend WithEvents filename As DataGridViewTextBoxColumn
    Friend WithEvents ruta As DataGridViewTextBoxColumn
    Friend WithEvents btn_verdoc As DataGridViewButtonColumn
End Class
