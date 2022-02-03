<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVisorPedidos
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVisorPedidos))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvListarPedidos = New System.Windows.Forms.DataGridView()
        Me.F5_CCODAGE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.F5_CNUMPED = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FV_CDESCRI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ORDEN_COMPRA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VAR_GUIA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VAR_FACTURA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHA_HORA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DIFERENCIA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New WindowsApp1.ProgressColumn()
        Me.TIEMPO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.F5_CCODCLI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.F5_CNOMBRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.F5_NIMPORT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SALDO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CL_CDEPT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESTADO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.F5_CUSUAP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.F5_DFECAPR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TU_ALIAS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TU_NOMUSU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.F5_CESTADO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FV_CCODIGO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VAR_OBS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OBSERV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tslCantidad = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsbCantPenApr = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsbPendFac = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tslMontoTotal = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tslContado = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tslContado1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tslCredito1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbRefrescar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ProgressColumn1 = New WindowsApp1.ProgressColumn()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.dgvTrazabilidad = New System.Windows.Forms.DataGridView()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgvListarDetalleProductos = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgvListarObservaciones = New System.Windows.Forms.DataGridView()
        Me.obp_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.dgvCuentasxCobrar = New System.Windows.Forms.DataGridView()
        Me.chk_PendAprob = New System.Windows.Forms.CheckBox()
        Me.chkPendFact = New System.Windows.Forms.CheckBox()
        Me.chkTodo = New System.Windows.Forms.CheckBox()
        Me.cboUnidad = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkPendContado = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtPedido = New System.Windows.Forms.TextBox()
        Me.chkPedido = New System.Windows.Forms.CheckBox()
        Me.txtGuia = New System.Windows.Forms.TextBox()
        Me.chkPorGuia = New System.Windows.Forms.CheckBox()
        Me.txtDocumento = New System.Windows.Forms.TextBox()
        Me.lblDocumento = New System.Windows.Forms.Label()
        Me.lblSerie = New System.Windows.Forms.Label()
        Me.txtSerie = New System.Windows.Forms.TextBox()
        Me.txtTD = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chkFiltroFactura = New System.Windows.Forms.CheckBox()
        Me.dtpFecFin = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpFecIni = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkFiltroFecha = New System.Windows.Forms.CheckBox()
        Me.chkAprobarComercial = New System.Windows.Forms.CheckBox()
        Me.lblSincro = New System.Windows.Forms.Label()
        CType(Me.dgvListarPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.dgvTrazabilidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvListarDetalleProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvListarObservaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.dgvCuentasxCobrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvListarPedidos
        '
        Me.dgvListarPedidos.AllowUserToAddRows = False
        Me.dgvListarPedidos.AllowUserToDeleteRows = False
        Me.dgvListarPedidos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvListarPedidos.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListarPedidos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvListarPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListarPedidos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.F5_CCODAGE, Me.F5_CNUMPED, Me.FV_CDESCRI, Me.ORDEN_COMPRA, Me.VAR_GUIA, Me.VAR_FACTURA, Me.FECHA_HORA, Me.DIFERENCIA, Me.Column2, Me.TIEMPO, Me.F5_CCODCLI, Me.F5_CNOMBRE, Me.F5_NIMPORT, Me.SALDO, Me.CL_CDEPT, Me.ESTADO, Me.F5_CUSUAP, Me.F5_DFECAPR, Me.TU_ALIAS, Me.TU_NOMUSU, Me.F5_CESTADO, Me.FV_CCODIGO, Me.VAR_OBS, Me.OBSERV})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvListarPedidos.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvListarPedidos.Location = New System.Drawing.Point(3, 3)
        Me.dgvListarPedidos.MultiSelect = False
        Me.dgvListarPedidos.Name = "dgvListarPedidos"
        Me.dgvListarPedidos.ReadOnly = True
        Me.dgvListarPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListarPedidos.Size = New System.Drawing.Size(991, 282)
        Me.dgvListarPedidos.TabIndex = 38
        '
        'F5_CCODAGE
        '
        Me.F5_CCODAGE.HeaderText = "F5_CCODAGE"
        Me.F5_CCODAGE.Name = "F5_CCODAGE"
        Me.F5_CCODAGE.ReadOnly = True
        Me.F5_CCODAGE.Visible = False
        '
        'F5_CNUMPED
        '
        Me.F5_CNUMPED.HeaderText = "NRO PEDIDO"
        Me.F5_CNUMPED.Name = "F5_CNUMPED"
        Me.F5_CNUMPED.ReadOnly = True
        '
        'FV_CDESCRI
        '
        Me.FV_CDESCRI.FillWeight = 250.0!
        Me.FV_CDESCRI.HeaderText = "FORMA DE PAGO"
        Me.FV_CDESCRI.Name = "FV_CDESCRI"
        Me.FV_CDESCRI.ReadOnly = True
        Me.FV_CDESCRI.Width = 180
        '
        'ORDEN_COMPRA
        '
        Me.ORDEN_COMPRA.HeaderText = "ORDEN COMPRA"
        Me.ORDEN_COMPRA.Name = "ORDEN_COMPRA"
        Me.ORDEN_COMPRA.ReadOnly = True
        Me.ORDEN_COMPRA.Width = 80
        '
        'VAR_GUIA
        '
        Me.VAR_GUIA.HeaderText = "GUIA"
        Me.VAR_GUIA.Name = "VAR_GUIA"
        Me.VAR_GUIA.ReadOnly = True
        Me.VAR_GUIA.Width = 80
        '
        'VAR_FACTURA
        '
        Me.VAR_FACTURA.HeaderText = "FACTURA"
        Me.VAR_FACTURA.Name = "VAR_FACTURA"
        Me.VAR_FACTURA.ReadOnly = True
        '
        'FECHA_HORA
        '
        Me.FECHA_HORA.HeaderText = "FECHA HORA"
        Me.FECHA_HORA.Name = "FECHA_HORA"
        Me.FECHA_HORA.ReadOnly = True
        Me.FECHA_HORA.Width = 120
        '
        'DIFERENCIA
        '
        Me.DIFERENCIA.HeaderText = "TIEMPO TRANSCURRIDO"
        Me.DIFERENCIA.Name = "DIFERENCIA"
        Me.DIFERENCIA.ReadOnly = True
        Me.DIFERENCIA.Visible = False
        Me.DIFERENCIA.Width = 75
        '
        'Column2
        '
        Me.Column2.HeaderText = "PROGRESO"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column2.Width = 200
        '
        'TIEMPO
        '
        Me.TIEMPO.HeaderText = "TIEMPO"
        Me.TIEMPO.Name = "TIEMPO"
        Me.TIEMPO.ReadOnly = True
        Me.TIEMPO.Visible = False
        Me.TIEMPO.Width = 50
        '
        'F5_CCODCLI
        '
        Me.F5_CCODCLI.HeaderText = "RUC"
        Me.F5_CCODCLI.Name = "F5_CCODCLI"
        Me.F5_CCODCLI.ReadOnly = True
        '
        'F5_CNOMBRE
        '
        Me.F5_CNOMBRE.HeaderText = "CLIENTE"
        Me.F5_CNOMBRE.Name = "F5_CNOMBRE"
        Me.F5_CNOMBRE.ReadOnly = True
        Me.F5_CNOMBRE.Width = 200
        '
        'F5_NIMPORT
        '
        Me.F5_NIMPORT.HeaderText = "IMPORTE"
        Me.F5_NIMPORT.Name = "F5_NIMPORT"
        Me.F5_NIMPORT.ReadOnly = True
        Me.F5_NIMPORT.Width = 70
        '
        'SALDO
        '
        Me.SALDO.HeaderText = "SALDO"
        Me.SALDO.Name = "SALDO"
        Me.SALDO.ReadOnly = True
        Me.SALDO.Width = 70
        '
        'CL_CDEPT
        '
        Me.CL_CDEPT.HeaderText = "DEPARTAMENTO"
        Me.CL_CDEPT.Name = "CL_CDEPT"
        Me.CL_CDEPT.ReadOnly = True
        '
        'ESTADO
        '
        Me.ESTADO.HeaderText = "ESTADO"
        Me.ESTADO.Name = "ESTADO"
        Me.ESTADO.ReadOnly = True
        Me.ESTADO.Width = 200
        '
        'F5_CUSUAP
        '
        Me.F5_CUSUAP.HeaderText = "USUARIO APROBACION"
        Me.F5_CUSUAP.Name = "F5_CUSUAP"
        Me.F5_CUSUAP.ReadOnly = True
        Me.F5_CUSUAP.Width = 70
        '
        'F5_DFECAPR
        '
        Me.F5_DFECAPR.HeaderText = "FECHA APROBACION"
        Me.F5_DFECAPR.Name = "F5_DFECAPR"
        Me.F5_DFECAPR.ReadOnly = True
        '
        'TU_ALIAS
        '
        Me.TU_ALIAS.HeaderText = "USUARIO REPRE"
        Me.TU_ALIAS.Name = "TU_ALIAS"
        Me.TU_ALIAS.ReadOnly = True
        Me.TU_ALIAS.Width = 70
        '
        'TU_NOMUSU
        '
        Me.TU_NOMUSU.HeaderText = "REPRESENTANTE"
        Me.TU_NOMUSU.Name = "TU_NOMUSU"
        Me.TU_NOMUSU.ReadOnly = True
        Me.TU_NOMUSU.Width = 150
        '
        'F5_CESTADO
        '
        Me.F5_CESTADO.HeaderText = "F5_CESTADO"
        Me.F5_CESTADO.Name = "F5_CESTADO"
        Me.F5_CESTADO.ReadOnly = True
        Me.F5_CESTADO.Width = 40
        '
        'FV_CCODIGO
        '
        Me.FV_CCODIGO.HeaderText = "FV_CCODIGO"
        Me.FV_CCODIGO.Name = "FV_CCODIGO"
        Me.FV_CCODIGO.ReadOnly = True
        Me.FV_CCODIGO.Width = 40
        '
        'VAR_OBS
        '
        Me.VAR_OBS.HeaderText = "OBSER"
        Me.VAR_OBS.Name = "VAR_OBS"
        Me.VAR_OBS.ReadOnly = True
        Me.VAR_OBS.Width = 40
        '
        'OBSERV
        '
        Me.OBSERV.HeaderText = "OBSERV"
        Me.OBSERV.Name = "OBSERV"
        Me.OBSERV.ReadOnly = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.tslCantidad, Me.ToolStripStatusLabel4, Me.tsbCantPenApr, Me.ToolStripStatusLabel5, Me.tsbPendFac, Me.ToolStripStatusLabel2, Me.tslMontoTotal, Me.tslContado, Me.tslContado1, Me.ToolStripStatusLabel3, Me.tslCredito1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 572)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 10, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1011, 22)
        Me.StatusStrip1.TabIndex = 39
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(87, 17)
        Me.ToolStripStatusLabel1.Text = "#Total Pedidos:"
        '
        'tslCantidad
        '
        Me.tslCantidad.Name = "tslCantidad"
        Me.tslCantidad.Size = New System.Drawing.Size(10, 17)
        Me.tslCantidad.Text = "."
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(113, 17)
        Me.ToolStripStatusLabel4.Text = "#PendienteAprobar:"
        '
        'tsbCantPenApr
        '
        Me.tsbCantPenApr.Name = "tsbCantPenApr"
        Me.tsbCantPenApr.Size = New System.Drawing.Size(10, 17)
        Me.tsbCantPenApr.Text = "."
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(113, 17)
        Me.ToolStripStatusLabel5.Text = "#PendienteFacturar:"
        '
        'tsbPendFac
        '
        Me.tsbPendFac.Name = "tsbPendFac"
        Me.tsbPendFac.Size = New System.Drawing.Size(10, 17)
        Me.tsbPendFac.Text = "."
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(74, 17)
        Me.ToolStripStatusLabel2.Text = "Monto Total:"
        '
        'tslMontoTotal
        '
        Me.tslMontoTotal.Name = "tslMontoTotal"
        Me.tslMontoTotal.Size = New System.Drawing.Size(10, 17)
        Me.tslMontoTotal.Text = "."
        '
        'tslContado
        '
        Me.tslContado.Name = "tslContado"
        Me.tslContado.Size = New System.Drawing.Size(56, 17)
        Me.tslContado.Text = "Contado:"
        '
        'tslContado1
        '
        Me.tslContado1.Name = "tslContado1"
        Me.tslContado1.Size = New System.Drawing.Size(10, 17)
        Me.tslContado1.Text = "."
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(49, 17)
        Me.ToolStripStatusLabel3.Text = "Credito:"
        '
        'tslCredito1
        '
        Me.tslCredito1.Name = "tslCredito1"
        Me.tslCredito1.Size = New System.Drawing.Size(10, 17)
        Me.tslCredito1.Text = "."
        '
        'Timer1
        '
        Me.Timer1.Interval = 120000
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbRefrescar, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1011, 27)
        Me.ToolStrip1.TabIndex = 40
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbRefrescar
        '
        Me.tsbRefrescar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbRefrescar.Image = CType(resources.GetObject("tsbRefrescar.Image"), System.Drawing.Image)
        Me.tsbRefrescar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbRefrescar.Name = "tsbRefrescar"
        Me.tsbRefrescar.Size = New System.Drawing.Size(24, 24)
        Me.tsbRefrescar.Text = "Refrescar"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(24, 24)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        Me.ToolStripButton1.ToolTipText = "Detener Sincronización"
        '
        'ProgressColumn1
        '
        Me.ProgressColumn1.HeaderText = "PROGRESO"
        Me.ProgressColumn1.Name = "ProgressColumn1"
        Me.ProgressColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ProgressColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ProgressColumn1.Width = 200
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(4, 90)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.dgvListarPedidos)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(997, 470)
        Me.SplitContainer1.SplitterDistance = 288
        Me.SplitContainer1.SplitterWidth = 3
        Me.SplitContainer1.TabIndex = 41
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(3, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(979, 172)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.dgvTrazabilidad)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPage3.Size = New System.Drawing.Size(971, 146)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Trazabilidad"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'dgvTrazabilidad
        '
        Me.dgvTrazabilidad.AllowUserToAddRows = False
        Me.dgvTrazabilidad.AllowUserToDeleteRows = False
        Me.dgvTrazabilidad.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvTrazabilidad.BackgroundColor = System.Drawing.Color.White
        Me.dgvTrazabilidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTrazabilidad.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvTrazabilidad.Location = New System.Drawing.Point(6, 5)
        Me.dgvTrazabilidad.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgvTrazabilidad.MultiSelect = False
        Me.dgvTrazabilidad.Name = "dgvTrazabilidad"
        Me.dgvTrazabilidad.ReadOnly = True
        Me.dgvTrazabilidad.RowTemplate.Height = 24
        Me.dgvTrazabilidad.Size = New System.Drawing.Size(961, 141)
        Me.dgvTrazabilidad.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgvListarDetalleProductos)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.TabPage1.Size = New System.Drawing.Size(971, 145)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Detalle de Productos"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgvListarDetalleProductos
        '
        Me.dgvListarDetalleProductos.AllowUserToAddRows = False
        Me.dgvListarDetalleProductos.AllowUserToDeleteRows = False
        Me.dgvListarDetalleProductos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvListarDetalleProductos.BackgroundColor = System.Drawing.Color.White
        Me.dgvListarDetalleProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvListarDetalleProductos.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvListarDetalleProductos.Location = New System.Drawing.Point(5, 5)
        Me.dgvListarDetalleProductos.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgvListarDetalleProductos.MultiSelect = False
        Me.dgvListarDetalleProductos.Name = "dgvListarDetalleProductos"
        Me.dgvListarDetalleProductos.ReadOnly = True
        Me.dgvListarDetalleProductos.RowTemplate.Height = 24
        Me.dgvListarDetalleProductos.Size = New System.Drawing.Size(896, 132)
        Me.dgvListarDetalleProductos.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgvListarObservaciones)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.TabPage2.Size = New System.Drawing.Size(971, 145)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Historial Observaciones"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgvListarObservaciones
        '
        Me.dgvListarObservaciones.AllowUserToAddRows = False
        Me.dgvListarObservaciones.AllowUserToDeleteRows = False
        Me.dgvListarObservaciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvListarObservaciones.BackgroundColor = System.Drawing.Color.White
        Me.dgvListarObservaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListarObservaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.obp_id, Me.Column1, Me.Column3, Me.Column4})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvListarObservaciones.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvListarObservaciones.Location = New System.Drawing.Point(5, 5)
        Me.dgvListarObservaciones.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgvListarObservaciones.MultiSelect = False
        Me.dgvListarObservaciones.Name = "dgvListarObservaciones"
        Me.dgvListarObservaciones.ReadOnly = True
        Me.dgvListarObservaciones.RowTemplate.Height = 24
        Me.dgvListarObservaciones.Size = New System.Drawing.Size(896, 131)
        Me.dgvListarObservaciones.TabIndex = 1
        '
        'obp_id
        '
        Me.obp_id.HeaderText = "ID"
        Me.obp_id.Name = "obp_id"
        Me.obp_id.ReadOnly = True
        Me.obp_id.Width = 40
        '
        'Column1
        '
        Me.Column1.HeaderText = "FECHA HORA"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "USUARIO"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 120
        '
        'Column4
        '
        Me.Column4.HeaderText = "OBSERVACION"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 1000
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.dgvCuentasxCobrar)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPage4.Size = New System.Drawing.Size(971, 145)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Cuentas x Cobrar"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'dgvCuentasxCobrar
        '
        Me.dgvCuentasxCobrar.AllowUserToAddRows = False
        Me.dgvCuentasxCobrar.AllowUserToDeleteRows = False
        Me.dgvCuentasxCobrar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCuentasxCobrar.BackgroundColor = System.Drawing.Color.White
        Me.dgvCuentasxCobrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCuentasxCobrar.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvCuentasxCobrar.Location = New System.Drawing.Point(6, 4)
        Me.dgvCuentasxCobrar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgvCuentasxCobrar.MultiSelect = False
        Me.dgvCuentasxCobrar.Name = "dgvCuentasxCobrar"
        Me.dgvCuentasxCobrar.ReadOnly = True
        Me.dgvCuentasxCobrar.RowTemplate.Height = 24
        Me.dgvCuentasxCobrar.Size = New System.Drawing.Size(961, 140)
        Me.dgvCuentasxCobrar.TabIndex = 3
        '
        'chk_PendAprob
        '
        Me.chk_PendAprob.AutoSize = True
        Me.chk_PendAprob.Location = New System.Drawing.Point(422, 9)
        Me.chk_PendAprob.Name = "chk_PendAprob"
        Me.chk_PendAprob.Size = New System.Drawing.Size(155, 17)
        Me.chk_PendAprob.TabIndex = 42
        Me.chk_PendAprob.Text = "Pendiente Aprobar Creditos"
        Me.chk_PendAprob.UseVisualStyleBackColor = True
        '
        'chkPendFact
        '
        Me.chkPendFact.AutoSize = True
        Me.chkPendFact.Location = New System.Drawing.Point(586, 9)
        Me.chkPendFact.Name = "chkPendFact"
        Me.chkPendFact.Size = New System.Drawing.Size(116, 17)
        Me.chkPendFact.TabIndex = 43
        Me.chkPendFact.Text = "Pendiente Facturar"
        Me.chkPendFact.UseVisualStyleBackColor = True
        '
        'chkTodo
        '
        Me.chkTodo.AutoSize = True
        Me.chkTodo.Location = New System.Drawing.Point(938, 5)
        Me.chkTodo.Name = "chkTodo"
        Me.chkTodo.Size = New System.Drawing.Size(51, 17)
        Me.chkTodo.TabIndex = 44
        Me.chkTodo.Text = "Todo"
        Me.chkTodo.UseVisualStyleBackColor = True
        Me.chkTodo.Visible = False
        '
        'cboUnidad
        '
        Me.cboUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUnidad.FormattingEnabled = True
        Me.cboUnidad.Items.AddRange(New Object() {"Todos", "Privado", "Institucional"})
        Me.cboUnidad.Location = New System.Drawing.Point(150, 5)
        Me.cboUnidad.Name = "cboUnidad"
        Me.cboUnidad.Size = New System.Drawing.Size(82, 21)
        Me.cboUnidad.TabIndex = 45
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(63, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Unidad Negocio:"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(759, 576)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Sincronización:"
        '
        'chkPendContado
        '
        Me.chkPendContado.AutoSize = True
        Me.chkPendContado.Location = New System.Drawing.Point(710, 9)
        Me.chkPendContado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkPendContado.Name = "chkPendContado"
        Me.chkPendContado.Size = New System.Drawing.Size(117, 17)
        Me.chkPendContado.TabIndex = 49
        Me.chkPendContado.Text = "Pendiente Contado"
        Me.chkPendContado.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.DarkRed
        Me.Panel1.Controls.Add(Me.btnExportar)
        Me.Panel1.Controls.Add(Me.btnBuscar)
        Me.Panel1.Controls.Add(Me.txtPedido)
        Me.Panel1.Controls.Add(Me.chkPedido)
        Me.Panel1.Controls.Add(Me.txtGuia)
        Me.Panel1.Controls.Add(Me.chkPorGuia)
        Me.Panel1.Controls.Add(Me.txtDocumento)
        Me.Panel1.Controls.Add(Me.lblDocumento)
        Me.Panel1.Controls.Add(Me.lblSerie)
        Me.Panel1.Controls.Add(Me.txtSerie)
        Me.Panel1.Controls.Add(Me.txtTD)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.chkFiltroFactura)
        Me.Panel1.Controls.Add(Me.dtpFecFin)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.dtpFecIni)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.chkFiltroFecha)
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(4, 28)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(998, 61)
        Me.Panel1.TabIndex = 50
        '
        'btnExportar
        '
        Me.btnExportar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExportar.ForeColor = System.Drawing.Color.Black
        Me.btnExportar.Image = Global.WindowsApp1.My.Resources.Resources.icon_excel1
        Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExportar.Location = New System.Drawing.Point(722, 28)
        Me.btnExportar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(87, 28)
        Me.btnExportar.TabIndex = 52
        Me.btnExportar.Text = "Exportar"
        Me.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.Black
        Me.btnBuscar.Image = Global.WindowsApp1.My.Resources.Resources._1041
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscar.Location = New System.Drawing.Point(616, 27)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(92, 28)
        Me.btnBuscar.TabIndex = 51
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtPedido
        '
        Me.txtPedido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPedido.Location = New System.Drawing.Point(320, 30)
        Me.txtPedido.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtPedido.Name = "txtPedido"
        Me.txtPedido.Size = New System.Drawing.Size(111, 20)
        Me.txtPedido.TabIndex = 59
        '
        'chkPedido
        '
        Me.chkPedido.AutoSize = True
        Me.chkPedido.Location = New System.Drawing.Point(244, 31)
        Me.chkPedido.Name = "chkPedido"
        Me.chkPedido.Size = New System.Drawing.Size(78, 17)
        Me.chkPedido.TabIndex = 58
        Me.chkPedido.Text = "Por Pedido"
        Me.chkPedido.UseVisualStyleBackColor = True
        '
        'txtGuia
        '
        Me.txtGuia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGuia.Location = New System.Drawing.Point(74, 30)
        Me.txtGuia.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtGuia.Name = "txtGuia"
        Me.txtGuia.Size = New System.Drawing.Size(126, 20)
        Me.txtGuia.TabIndex = 57
        '
        'chkPorGuia
        '
        Me.chkPorGuia.AutoSize = True
        Me.chkPorGuia.Location = New System.Drawing.Point(8, 31)
        Me.chkPorGuia.Name = "chkPorGuia"
        Me.chkPorGuia.Size = New System.Drawing.Size(67, 17)
        Me.chkPorGuia.TabIndex = 57
        Me.chkPorGuia.Text = "Por Guia"
        Me.chkPorGuia.UseVisualStyleBackColor = True
        '
        'txtDocumento
        '
        Me.txtDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDocumento.Location = New System.Drawing.Point(722, 5)
        Me.txtDocumento.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDocumento.Name = "txtDocumento"
        Me.txtDocumento.Size = New System.Drawing.Size(88, 20)
        Me.txtDocumento.TabIndex = 56
        '
        'lblDocumento
        '
        Me.lblDocumento.AutoSize = True
        Me.lblDocumento.ForeColor = System.Drawing.Color.White
        Me.lblDocumento.Location = New System.Drawing.Point(662, 6)
        Me.lblDocumento.Name = "lblDocumento"
        Me.lblDocumento.Size = New System.Drawing.Size(62, 13)
        Me.lblDocumento.TabIndex = 55
        Me.lblDocumento.Text = "Documento"
        '
        'lblSerie
        '
        Me.lblSerie.AutoSize = True
        Me.lblSerie.ForeColor = System.Drawing.Color.White
        Me.lblSerie.Location = New System.Drawing.Point(585, 6)
        Me.lblSerie.Name = "lblSerie"
        Me.lblSerie.Size = New System.Drawing.Size(31, 13)
        Me.lblSerie.TabIndex = 54
        Me.lblSerie.Text = "Serie"
        '
        'txtSerie
        '
        Me.txtSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSerie.Location = New System.Drawing.Point(616, 5)
        Me.txtSerie.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(46, 20)
        Me.txtSerie.TabIndex = 53
        '
        'txtTD
        '
        Me.txtTD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTD.Location = New System.Drawing.Point(550, 5)
        Me.txtTD.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTD.Name = "txtTD"
        Me.txtTD.Size = New System.Drawing.Size(32, 20)
        Me.txtTD.TabIndex = 52
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(530, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(22, 13)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "TD"
        '
        'chkFiltroFactura
        '
        Me.chkFiltroFactura.AutoSize = True
        Me.chkFiltroFactura.Location = New System.Drawing.Point(418, 6)
        Me.chkFiltroFactura.Name = "chkFiltroFactura"
        Me.chkFiltroFactura.Size = New System.Drawing.Size(116, 17)
        Me.chkFiltroFactura.TabIndex = 50
        Me.chkFiltroFactura.Text = "Por Factura/Boleta"
        Me.chkFiltroFactura.UseVisualStyleBackColor = True
        '
        'dtpFecFin
        '
        Me.dtpFecFin.Enabled = False
        Me.dtpFecFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecFin.Location = New System.Drawing.Point(306, 6)
        Me.dtpFecFin.Name = "dtpFecFin"
        Me.dtpFecFin.Size = New System.Drawing.Size(96, 20)
        Me.dtpFecFin.TabIndex = 49
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(244, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Fecha Fin:"
        '
        'dtpFecIni
        '
        Me.dtpFecIni.Enabled = False
        Me.dtpFecIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecIni.Location = New System.Drawing.Point(147, 6)
        Me.dtpFecIni.Name = "dtpFecIni"
        Me.dtpFecIni.Size = New System.Drawing.Size(96, 20)
        Me.dtpFecIni.TabIndex = 47
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(80, 9)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Fecha inicio:"
        '
        'chkFiltroFecha
        '
        Me.chkFiltroFecha.AutoSize = True
        Me.chkFiltroFecha.Location = New System.Drawing.Point(8, 7)
        Me.chkFiltroFecha.Name = "chkFiltroFecha"
        Me.chkFiltroFecha.Size = New System.Drawing.Size(75, 17)
        Me.chkFiltroFecha.TabIndex = 43
        Me.chkFiltroFecha.Text = "Por Fecha"
        Me.chkFiltroFecha.UseVisualStyleBackColor = True
        '
        'chkAprobarComercial
        '
        Me.chkAprobarComercial.AutoSize = True
        Me.chkAprobarComercial.Location = New System.Drawing.Point(251, 9)
        Me.chkAprobarComercial.Name = "chkAprobarComercial"
        Me.chkAprobarComercial.Size = New System.Drawing.Size(163, 17)
        Me.chkAprobarComercial.TabIndex = 51
        Me.chkAprobarComercial.Text = "Pendiente Aprobar Comercial"
        Me.chkAprobarComercial.UseVisualStyleBackColor = True
        '
        'lblSincro
        '
        Me.lblSincro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSincro.AutoSize = True
        Me.lblSincro.Location = New System.Drawing.Point(843, 576)
        Me.lblSincro.Name = "lblSincro"
        Me.lblSincro.Size = New System.Drawing.Size(39, 13)
        Me.lblSincro.TabIndex = 52
        Me.lblSincro.Text = "Label3"
        '
        'frmVisorPedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1011, 594)
        Me.Controls.Add(Me.lblSincro)
        Me.Controls.Add(Me.chkAprobarComercial)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.chkPendContado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboUnidad)
        Me.Controls.Add(Me.chkTodo)
        Me.Controls.Add(Me.chkPendFact)
        Me.Controls.Add(Me.chk_PendAprob)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmVisorPedidos"
        Me.Text = "Visor Pedidos"
        CType(Me.dgvListarPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        CType(Me.dgvTrazabilidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgvListarDetalleProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgvListarObservaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.dgvCuentasxCobrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvListarPedidos As DataGridView
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents tslCantidad As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents tslMontoTotal As ToolStripStatusLabel
    Friend WithEvents tslContado As ToolStripStatusLabel
    Friend WithEvents tslContado1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents tslCredito1 As ToolStripStatusLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsbRefrescar As ToolStripButton
    Friend WithEvents ProgressColumn1 As ProgressColumn
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents dgvListarDetalleProductos As DataGridView
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents chk_PendAprob As CheckBox
    Friend WithEvents chkPendFact As CheckBox
    Friend WithEvents chkTodo As CheckBox
    Friend WithEvents ToolStripStatusLabel4 As ToolStripStatusLabel
    Friend WithEvents tsbCantPenApr As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As ToolStripStatusLabel
    Friend WithEvents tsbPendFac As ToolStripStatusLabel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents dgvListarObservaciones As DataGridView
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents dgvTrazabilidad As DataGridView
    Friend WithEvents cboUnidad As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents obp_id As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents chkPendContado As CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents chkFiltroFactura As CheckBox
    Friend WithEvents dtpFecFin As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpFecIni As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents chkFiltroFecha As CheckBox
    Friend WithEvents txtDocumento As TextBox
    Friend WithEvents lblDocumento As Label
    Friend WithEvents lblSerie As Label
    Friend WithEvents txtSerie As TextBox
    Friend WithEvents txtTD As TextBox
    Friend WithEvents txtGuia As TextBox
    Friend WithEvents chkPorGuia As CheckBox
    Friend WithEvents btnExportar As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtPedido As TextBox
    Friend WithEvents chkPedido As CheckBox
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents dgvCuentasxCobrar As DataGridView
    Friend WithEvents chkAprobarComercial As CheckBox
    Friend WithEvents F5_CCODAGE As DataGridViewTextBoxColumn
    Friend WithEvents F5_CNUMPED As DataGridViewTextBoxColumn
    Friend WithEvents FV_CDESCRI As DataGridViewTextBoxColumn
    Friend WithEvents ORDEN_COMPRA As DataGridViewTextBoxColumn
    Friend WithEvents VAR_GUIA As DataGridViewTextBoxColumn
    Friend WithEvents VAR_FACTURA As DataGridViewTextBoxColumn
    Friend WithEvents FECHA_HORA As DataGridViewTextBoxColumn
    Friend WithEvents DIFERENCIA As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As ProgressColumn
    Friend WithEvents TIEMPO As DataGridViewTextBoxColumn
    Friend WithEvents F5_CCODCLI As DataGridViewTextBoxColumn
    Friend WithEvents F5_CNOMBRE As DataGridViewTextBoxColumn
    Friend WithEvents F5_NIMPORT As DataGridViewTextBoxColumn
    Friend WithEvents SALDO As DataGridViewTextBoxColumn
    Friend WithEvents CL_CDEPT As DataGridViewTextBoxColumn
    Friend WithEvents ESTADO As DataGridViewTextBoxColumn
    Friend WithEvents F5_CUSUAP As DataGridViewTextBoxColumn
    Friend WithEvents F5_DFECAPR As DataGridViewTextBoxColumn
    Friend WithEvents TU_ALIAS As DataGridViewTextBoxColumn
    Friend WithEvents TU_NOMUSU As DataGridViewTextBoxColumn
    Friend WithEvents F5_CESTADO As DataGridViewTextBoxColumn
    Friend WithEvents FV_CCODIGO As DataGridViewTextBoxColumn
    Friend WithEvents VAR_OBS As DataGridViewTextBoxColumn
    Friend WithEvents OBSERV As DataGridViewTextBoxColumn
    Friend WithEvents lblSincro As Label
End Class
