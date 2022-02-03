<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLotesUbicacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLotesUbicacion))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtLote = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboEstados = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpFecfin = New System.Windows.Forms.DateTimePicker()
        Me.dtpFecini = New System.Windows.Forms.DateTimePicker()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgvListarLotesUbicaciones = New System.Windows.Forms.DataGridView()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tslCantFila = New System.Windows.Forms.ToolStripStatusLabel()
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
        Me.C6_CLOCALI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C6_CALMA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C5_CTD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C5_CCODMOV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C6_CTD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C6_CNUMDOC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C6_CITEM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C6_CCODIGO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C6_CSERIE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SR_CCODIGO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AR_CDESCRI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SR_CSERIE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STOCK = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SR_NSKDIS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECMOV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECVEN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TU_NOMUSU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SK_CUBIAL1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SK_CUBIAL2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SK_CUBIAL3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SK_CUBIAL4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvListarLotesUbicaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.GroupBox1.Controls.Add(Me.txtCodigo)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtLote)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cboEstados)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btnExportar)
        Me.GroupBox1.Controls.Add(Me.btnConsultar)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtpFecfin)
        Me.GroupBox1.Controls.Add(Me.dtpFecini)
        Me.GroupBox1.Location = New System.Drawing.Point(5, -2)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(1322, 107)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtros"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(530, 49)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(131, 22)
        Me.txtCodigo.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(471, 51)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Codigo"
        '
        'txtLote
        '
        Me.txtLote.Location = New System.Drawing.Point(323, 50)
        Me.txtLote.Name = "txtLote"
        Me.txtLote.Size = New System.Drawing.Size(131, 22)
        Me.txtLote.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(261, 52)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Lote"
        '
        'cboEstados
        '
        Me.cboEstados.BackColor = System.Drawing.Color.White
        Me.cboEstados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEstados.FormattingEnabled = True
        Me.cboEstados.Items.AddRange(New Object() {"TODOS", "PENDIENTE", "UBICADO"})
        Me.cboEstados.Location = New System.Drawing.Point(103, 49)
        Me.cboEstados.Name = "cboEstados"
        Me.cboEstados.Size = New System.Drawing.Size(131, 24)
        Me.cboEstados.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 51)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Estados"
        '
        'btnExportar
        '
        Me.btnExportar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExportar.Image = CType(resources.GetObject("btnExportar.Image"), System.Drawing.Image)
        Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExportar.Location = New System.Drawing.Point(987, 17)
        Me.btnExportar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(118, 51)
        Me.btnExportar.TabIndex = 5
        Me.btnExportar.Text = "    Exportar"
        Me.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'btnConsultar
        '
        Me.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConsultar.Image = CType(resources.GetObject("btnConsultar.Image"), System.Drawing.Image)
        Me.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnConsultar.Location = New System.Drawing.Point(849, 17)
        Me.btnConsultar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(120, 51)
        Me.btnConsultar.TabIndex = 4
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(249, 21)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Fecha Fin"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Fecha Inicio"
        '
        'dtpFecfin
        '
        Me.dtpFecfin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecfin.Location = New System.Drawing.Point(324, 20)
        Me.dtpFecfin.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpFecfin.Name = "dtpFecfin"
        Me.dtpFecfin.Size = New System.Drawing.Size(131, 22)
        Me.dtpFecfin.TabIndex = 1
        '
        'dtpFecini
        '
        Me.dtpFecini.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecini.Location = New System.Drawing.Point(103, 20)
        Me.dtpFecini.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpFecini.Name = "dtpFecini"
        Me.dtpFecini.Size = New System.Drawing.Size(131, 22)
        Me.dtpFecini.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(7, 113)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1327, 574)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgvListarLotesUbicaciones)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Size = New System.Drawing.Size(1319, 545)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Lotes / Ubicaciones"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgvListarLotesUbicaciones
        '
        Me.dgvListarLotesUbicaciones.AllowUserToAddRows = False
        Me.dgvListarLotesUbicaciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvListarLotesUbicaciones.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListarLotesUbicaciones.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvListarLotesUbicaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListarLotesUbicaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.C6_CLOCALI, Me.C6_CALMA, Me.C5_CTD, Me.C5_CCODMOV, Me.C6_CTD, Me.C6_CNUMDOC, Me.C6_CITEM, Me.C6_CCODIGO, Me.C6_CSERIE, Me.SR_CCODIGO, Me.AR_CDESCRI, Me.SR_CSERIE, Me.STOCK, Me.Column1, Me.SR_NSKDIS, Me.FECMOV, Me.FECVEN, Me.TU_NOMUSU, Me.Estado, Me.SK_CUBIAL1, Me.SK_CUBIAL2, Me.SK_CUBIAL3, Me.SK_CUBIAL4})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvListarLotesUbicaciones.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvListarLotesUbicaciones.Location = New System.Drawing.Point(8, 7)
        Me.dgvListarLotesUbicaciones.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvListarLotesUbicaciones.Name = "dgvListarLotesUbicaciones"
        Me.dgvListarLotesUbicaciones.RowHeadersWidth = 51
        Me.dgvListarLotesUbicaciones.Size = New System.Drawing.Size(1300, 527)
        Me.dgvListarLotesUbicaciones.TabIndex = 0
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.tslCantFila})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 692)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1340, 25)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(106, 20)
        Me.ToolStripStatusLabel1.Text = "Cantidad Total"
        '
        'tslCantFila
        '
        Me.tslCantFila.Name = "tslCantFila"
        Me.tslCantFila.Size = New System.Drawing.Size(17, 20)
        Me.tslCantFila.Text = "0"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "C6_CLOCALI"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "ALM"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 40
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "DO"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 30
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "MO"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 30
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "C6_CTD"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Visible = False
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "NUMDOC"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 90
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "C6_CITEM"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Visible = False
        Me.DataGridViewTextBoxColumn7.Width = 125
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "C6_CCODIGO"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Visible = False
        Me.DataGridViewTextBoxColumn8.Width = 125
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = "C6_CSERIE"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Visible = False
        Me.DataGridViewTextBoxColumn9.Width = 125
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.HeaderText = "CODIGO"
        Me.DataGridViewTextBoxColumn10.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 80
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.HeaderText = "ARTICULO"
        Me.DataGridViewTextBoxColumn11.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 270
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.HeaderText = "LOTE / SERIE"
        Me.DataGridViewTextBoxColumn12.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Width = 120
        '
        'DataGridViewTextBoxColumn13
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn13.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn13.HeaderText = "CANTIDAD"
        Me.DataGridViewTextBoxColumn13.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Width = 80
        '
        'DataGridViewTextBoxColumn14
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn14.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn14.HeaderText = "FECHA REG"
        Me.DataGridViewTextBoxColumn14.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Width = 70
        '
        'DataGridViewTextBoxColumn15
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn15.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn15.HeaderText = "FECHA VENC"
        Me.DataGridViewTextBoxColumn15.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.Width = 70
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.HeaderText = "USUARIO"
        Me.DataGridViewTextBoxColumn16.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.Width = 90
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.HeaderText = "ESTADO"
        Me.DataGridViewTextBoxColumn17.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.Width = 70
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.HeaderText = "UBI 1"
        Me.DataGridViewTextBoxColumn18.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.Width = 80
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.HeaderText = "UBI 2"
        Me.DataGridViewTextBoxColumn19.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.Width = 80
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.HeaderText = "UBI 3"
        Me.DataGridViewTextBoxColumn20.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.Width = 80
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.HeaderText = "UBI 4"
        Me.DataGridViewTextBoxColumn21.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.Width = 80
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.HeaderText = "UBI 4"
        Me.DataGridViewTextBoxColumn22.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.Width = 80
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.HeaderText = "UBI 4"
        Me.DataGridViewTextBoxColumn23.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.Width = 80
        '
        'C6_CLOCALI
        '
        Me.C6_CLOCALI.HeaderText = "C6_CLOCALI"
        Me.C6_CLOCALI.MinimumWidth = 6
        Me.C6_CLOCALI.Name = "C6_CLOCALI"
        Me.C6_CLOCALI.Visible = False
        Me.C6_CLOCALI.Width = 125
        '
        'C6_CALMA
        '
        Me.C6_CALMA.HeaderText = "ALM"
        Me.C6_CALMA.MinimumWidth = 6
        Me.C6_CALMA.Name = "C6_CALMA"
        Me.C6_CALMA.Width = 40
        '
        'C5_CTD
        '
        Me.C5_CTD.HeaderText = "DO"
        Me.C5_CTD.MinimumWidth = 6
        Me.C5_CTD.Name = "C5_CTD"
        Me.C5_CTD.Width = 30
        '
        'C5_CCODMOV
        '
        Me.C5_CCODMOV.HeaderText = "MO"
        Me.C5_CCODMOV.MinimumWidth = 6
        Me.C5_CCODMOV.Name = "C5_CCODMOV"
        Me.C5_CCODMOV.Width = 30
        '
        'C6_CTD
        '
        Me.C6_CTD.HeaderText = "C6_CTD"
        Me.C6_CTD.MinimumWidth = 6
        Me.C6_CTD.Name = "C6_CTD"
        Me.C6_CTD.Visible = False
        Me.C6_CTD.Width = 125
        '
        'C6_CNUMDOC
        '
        Me.C6_CNUMDOC.HeaderText = "NUMDOC"
        Me.C6_CNUMDOC.MinimumWidth = 6
        Me.C6_CNUMDOC.Name = "C6_CNUMDOC"
        Me.C6_CNUMDOC.Width = 90
        '
        'C6_CITEM
        '
        Me.C6_CITEM.HeaderText = "C6_CITEM"
        Me.C6_CITEM.MinimumWidth = 6
        Me.C6_CITEM.Name = "C6_CITEM"
        Me.C6_CITEM.Visible = False
        Me.C6_CITEM.Width = 125
        '
        'C6_CCODIGO
        '
        Me.C6_CCODIGO.HeaderText = "C6_CCODIGO"
        Me.C6_CCODIGO.MinimumWidth = 6
        Me.C6_CCODIGO.Name = "C6_CCODIGO"
        Me.C6_CCODIGO.Visible = False
        Me.C6_CCODIGO.Width = 125
        '
        'C6_CSERIE
        '
        Me.C6_CSERIE.HeaderText = "C6_CSERIE"
        Me.C6_CSERIE.MinimumWidth = 6
        Me.C6_CSERIE.Name = "C6_CSERIE"
        Me.C6_CSERIE.Visible = False
        Me.C6_CSERIE.Width = 125
        '
        'SR_CCODIGO
        '
        Me.SR_CCODIGO.HeaderText = "CODIGO"
        Me.SR_CCODIGO.MinimumWidth = 6
        Me.SR_CCODIGO.Name = "SR_CCODIGO"
        Me.SR_CCODIGO.Width = 80
        '
        'AR_CDESCRI
        '
        Me.AR_CDESCRI.HeaderText = "ARTICULO"
        Me.AR_CDESCRI.MinimumWidth = 6
        Me.AR_CDESCRI.Name = "AR_CDESCRI"
        Me.AR_CDESCRI.Width = 270
        '
        'SR_CSERIE
        '
        Me.SR_CSERIE.HeaderText = "LOTE / SERIE"
        Me.SR_CSERIE.MinimumWidth = 6
        Me.SR_CSERIE.Name = "SR_CSERIE"
        Me.SR_CSERIE.Width = 120
        '
        'STOCK
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N0"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.STOCK.DefaultCellStyle = DataGridViewCellStyle2
        Me.STOCK.HeaderText = "STK ART"
        Me.STOCK.MinimumWidth = 6
        Me.STOCK.Name = "STOCK"
        '
        'Column1
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N0"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column1.HeaderText = "STK LOTE"
        Me.Column1.Name = "Column1"
        '
        'SR_NSKDIS
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.SR_NSKDIS.DefaultCellStyle = DataGridViewCellStyle4
        Me.SR_NSKDIS.HeaderText = "CANTIDAD"
        Me.SR_NSKDIS.MinimumWidth = 6
        Me.SR_NSKDIS.Name = "SR_NSKDIS"
        Me.SR_NSKDIS.Width = 80
        '
        'FECMOV
        '
        Me.FECMOV.HeaderText = "FECHA REG"
        Me.FECMOV.MinimumWidth = 6
        Me.FECMOV.Name = "FECMOV"
        Me.FECMOV.Width = 70
        '
        'FECVEN
        '
        Me.FECVEN.HeaderText = "FECHA VENC"
        Me.FECVEN.MinimumWidth = 6
        Me.FECVEN.Name = "FECVEN"
        Me.FECVEN.Width = 70
        '
        'TU_NOMUSU
        '
        Me.TU_NOMUSU.HeaderText = "USUARIO"
        Me.TU_NOMUSU.MinimumWidth = 6
        Me.TU_NOMUSU.Name = "TU_NOMUSU"
        Me.TU_NOMUSU.Width = 90
        '
        'Estado
        '
        Me.Estado.HeaderText = "ESTADO"
        Me.Estado.MinimumWidth = 6
        Me.Estado.Name = "Estado"
        Me.Estado.Width = 70
        '
        'SK_CUBIAL1
        '
        Me.SK_CUBIAL1.HeaderText = "UBI 1"
        Me.SK_CUBIAL1.MinimumWidth = 6
        Me.SK_CUBIAL1.Name = "SK_CUBIAL1"
        Me.SK_CUBIAL1.Width = 80
        '
        'SK_CUBIAL2
        '
        Me.SK_CUBIAL2.HeaderText = "UBI 2"
        Me.SK_CUBIAL2.MinimumWidth = 6
        Me.SK_CUBIAL2.Name = "SK_CUBIAL2"
        Me.SK_CUBIAL2.Width = 80
        '
        'SK_CUBIAL3
        '
        Me.SK_CUBIAL3.HeaderText = "UBI 3"
        Me.SK_CUBIAL3.MinimumWidth = 6
        Me.SK_CUBIAL3.Name = "SK_CUBIAL3"
        Me.SK_CUBIAL3.Width = 80
        '
        'SK_CUBIAL4
        '
        Me.SK_CUBIAL4.HeaderText = "UBI 4"
        Me.SK_CUBIAL4.MinimumWidth = 6
        Me.SK_CUBIAL4.Name = "SK_CUBIAL4"
        Me.SK_CUBIAL4.Width = 80
        '
        'frmLotesUbicacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1340, 717)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmLotesUbicacion"
        Me.Text = "Lotes Ubicación"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgvListarLotesUbicaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents dgvListarLotesUbicaciones As DataGridView
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents btnConsultar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpFecfin As DateTimePicker
    Friend WithEvents dtpFecini As DateTimePicker
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents tslCantFila As ToolStripStatusLabel
    Friend WithEvents btnExportar As Button
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtLote As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cboEstados As ComboBox
    Friend WithEvents Label3 As Label
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
    Friend WithEvents C6_CLOCALI As DataGridViewTextBoxColumn
    Friend WithEvents C6_CALMA As DataGridViewTextBoxColumn
    Friend WithEvents C5_CTD As DataGridViewTextBoxColumn
    Friend WithEvents C5_CCODMOV As DataGridViewTextBoxColumn
    Friend WithEvents C6_CTD As DataGridViewTextBoxColumn
    Friend WithEvents C6_CNUMDOC As DataGridViewTextBoxColumn
    Friend WithEvents C6_CITEM As DataGridViewTextBoxColumn
    Friend WithEvents C6_CCODIGO As DataGridViewTextBoxColumn
    Friend WithEvents C6_CSERIE As DataGridViewTextBoxColumn
    Friend WithEvents SR_CCODIGO As DataGridViewTextBoxColumn
    Friend WithEvents AR_CDESCRI As DataGridViewTextBoxColumn
    Friend WithEvents SR_CSERIE As DataGridViewTextBoxColumn
    Friend WithEvents STOCK As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents SR_NSKDIS As DataGridViewTextBoxColumn
    Friend WithEvents FECMOV As DataGridViewTextBoxColumn
    Friend WithEvents FECVEN As DataGridViewTextBoxColumn
    Friend WithEvents TU_NOMUSU As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
    Friend WithEvents SK_CUBIAL1 As DataGridViewTextBoxColumn
    Friend WithEvents SK_CUBIAL2 As DataGridViewTextBoxColumn
    Friend WithEvents SK_CUBIAL3 As DataGridViewTextBoxColumn
    Friend WithEvents SK_CUBIAL4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
End Class
