<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRequerimientos_TI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRequerimientos_TI))
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ckbSincronizar = New System.Windows.Forms.CheckBox()
        Me.chkPendProg = New System.Windows.Forms.CheckBox()
        Me.cboEstados = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboResponsable = New System.Windows.Forms.ComboBox()
        Me.dtpFecFin = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpFecIni = New System.Windows.Forms.DateTimePicker()
        Me.dgvListadoRequerimientos = New System.Windows.Forms.DataGridView()
        Me.req_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.color1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.est_descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.req_fecreg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.req_asunto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.usr_nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.emp_des = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.res_nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rpr_fecinicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rpr_fecfin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.req_descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Editar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Programar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column_cerrado = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Anular = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tslCantidad = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.rtbDetalleReq = New System.Windows.Forms.RichTextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgvArchivosAdjuntos = New System.Windows.Forms.DataGridView()
        Me.fileName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ruta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_ver = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.dgvListarObservaciones = New System.Windows.Forms.DataGridView()
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvListadoRequerimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvArchivosAdjuntos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.dgvListarObservaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox1.Controls.Add(Me.ckbSincronizar)
        Me.GroupBox1.Controls.Add(Me.chkPendProg)
        Me.GroupBox1.Controls.Add(Me.cboEstados)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btnExportar)
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.btnNuevo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cboResponsable)
        Me.GroupBox1.Controls.Add(Me.dtpFecFin)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtpFecIni)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(884, 89)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtros"
        '
        'ckbSincronizar
        '
        Me.ckbSincronizar.AutoSize = True
        Me.ckbSincronizar.Location = New System.Drawing.Point(797, 63)
        Me.ckbSincronizar.Name = "ckbSincronizar"
        Me.ckbSincronizar.Size = New System.Drawing.Size(78, 17)
        Me.ckbSincronizar.TabIndex = 11
        Me.ckbSincronizar.Text = "Sincronizar"
        Me.ckbSincronizar.UseVisualStyleBackColor = True
        '
        'chkPendProg
        '
        Me.chkPendProg.AutoSize = True
        Me.chkPendProg.Location = New System.Drawing.Point(454, 66)
        Me.chkPendProg.Name = "chkPendProg"
        Me.chkPendProg.Size = New System.Drawing.Size(144, 17)
        Me.chkPendProg.TabIndex = 10
        Me.chkPendProg.Text = "Pendiente y Programado"
        Me.chkPendProg.UseVisualStyleBackColor = True
        '
        'cboEstados
        '
        Me.cboEstados.BackColor = System.Drawing.Color.White
        Me.cboEstados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEstados.FormattingEnabled = True
        Me.cboEstados.Location = New System.Drawing.Point(454, 39)
        Me.cboEstados.Name = "cboEstados"
        Me.cboEstados.Size = New System.Drawing.Size(164, 21)
        Me.cboEstados.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(379, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Estado"
        '
        'btnExportar
        '
        Me.btnExportar.BackColor = System.Drawing.Color.White
        Me.btnExportar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExportar.Image = Global.WindowsApp1.My.Resources.Resources.icon_excel3
        Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExportar.Location = New System.Drawing.Point(123, 55)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(106, 26)
        Me.btnExportar.TabIndex = 7
        Me.btnExportar.Text = "Exportar"
        Me.btnExportar.UseVisualStyleBackColor = False
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.White
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(666, 14)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(106, 26)
        Me.btnBuscar.TabIndex = 6
        Me.btnBuscar.Text = "&Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.White
        Me.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNuevo.Image = Global.WindowsApp1.My.Resources.Resources._0011
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevo.Location = New System.Drawing.Point(8, 55)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(106, 26)
        Me.btnNuevo.TabIndex = 5
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(379, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Responsable:"
        '
        'cboResponsable
        '
        Me.cboResponsable.BackColor = System.Drawing.Color.White
        Me.cboResponsable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboResponsable.FormattingEnabled = True
        Me.cboResponsable.Location = New System.Drawing.Point(454, 15)
        Me.cboResponsable.Name = "cboResponsable"
        Me.cboResponsable.Size = New System.Drawing.Size(164, 21)
        Me.cboResponsable.TabIndex = 4
        '
        'dtpFecFin
        '
        Me.dtpFecFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecFin.Location = New System.Drawing.Point(253, 15)
        Me.dtpFecFin.Name = "dtpFecFin"
        Me.dtpFecFin.Size = New System.Drawing.Size(97, 21)
        Me.dtpFecFin.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(195, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fecha Fin:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Fecha Inicio:"
        '
        'dtpFecIni
        '
        Me.dtpFecIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecIni.Location = New System.Drawing.Point(79, 15)
        Me.dtpFecIni.Name = "dtpFecIni"
        Me.dtpFecIni.Size = New System.Drawing.Size(97, 21)
        Me.dtpFecIni.TabIndex = 0
        '
        'dgvListadoRequerimientos
        '
        Me.dgvListadoRequerimientos.AllowUserToAddRows = False
        Me.dgvListadoRequerimientos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvListadoRequerimientos.BackgroundColor = System.Drawing.Color.White
        Me.dgvListadoRequerimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListadoRequerimientos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.req_id, Me.color1, Me.est_descripcion, Me.req_fecreg, Me.req_asunto, Me.usr_nombre, Me.emp_des, Me.res_nombre, Me.rpr_fecinicio, Me.rpr_fecfin, Me.req_descripcion, Me.Editar, Me.Programar, Me.Column_cerrado, Me.Anular})
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvListadoRequerimientos.DefaultCellStyle = DataGridViewCellStyle14
        Me.dgvListadoRequerimientos.Location = New System.Drawing.Point(6, 6)
        Me.dgvListadoRequerimientos.MultiSelect = False
        Me.dgvListadoRequerimientos.Name = "dgvListadoRequerimientos"
        Me.dgvListadoRequerimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListadoRequerimientos.Size = New System.Drawing.Size(870, 214)
        Me.dgvListadoRequerimientos.TabIndex = 1
        '
        'req_id
        '
        Me.req_id.Frozen = True
        Me.req_id.HeaderText = "Nro Reque."
        Me.req_id.Name = "req_id"
        Me.req_id.Width = 40
        '
        'color1
        '
        Me.color1.HeaderText = ""
        Me.color1.Name = "color1"
        Me.color1.Width = 50
        '
        'est_descripcion
        '
        Me.est_descripcion.HeaderText = "Estado"
        Me.est_descripcion.Name = "est_descripcion"
        Me.est_descripcion.Width = 80
        '
        'req_fecreg
        '
        DataGridViewCellStyle10.Format = "g"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.req_fecreg.DefaultCellStyle = DataGridViewCellStyle10
        Me.req_fecreg.HeaderText = "Fecha Registro"
        Me.req_fecreg.Name = "req_fecreg"
        '
        'req_asunto
        '
        Me.req_asunto.HeaderText = "Asunto"
        Me.req_asunto.Name = "req_asunto"
        Me.req_asunto.Width = 400
        '
        'usr_nombre
        '
        Me.usr_nombre.HeaderText = "Solicitante"
        Me.usr_nombre.Name = "usr_nombre"
        Me.usr_nombre.Width = 130
        '
        'emp_des
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.emp_des.DefaultCellStyle = DataGridViewCellStyle11
        Me.emp_des.HeaderText = "Empresa"
        Me.emp_des.Name = "emp_des"
        Me.emp_des.Width = 70
        '
        'res_nombre
        '
        Me.res_nombre.HeaderText = "Responsable"
        Me.res_nombre.Name = "res_nombre"
        '
        'rpr_fecinicio
        '
        DataGridViewCellStyle12.Format = "g"
        DataGridViewCellStyle12.NullValue = Nothing
        Me.rpr_fecinicio.DefaultCellStyle = DataGridViewCellStyle12
        Me.rpr_fecinicio.HeaderText = "Fecha Inicio"
        Me.rpr_fecinicio.Name = "rpr_fecinicio"
        '
        'rpr_fecfin
        '
        DataGridViewCellStyle13.Format = "g"
        DataGridViewCellStyle13.NullValue = Nothing
        Me.rpr_fecfin.DefaultCellStyle = DataGridViewCellStyle13
        Me.rpr_fecfin.HeaderText = "Fecha Fin"
        Me.rpr_fecfin.Name = "rpr_fecfin"
        '
        'req_descripcion
        '
        Me.req_descripcion.HeaderText = "Detalle Requerimiento"
        Me.req_descripcion.Name = "req_descripcion"
        Me.req_descripcion.Visible = False
        '
        'Editar
        '
        Me.Editar.HeaderText = ""
        Me.Editar.Name = "Editar"
        Me.Editar.Text = "Editar"
        Me.Editar.ToolTipText = "Editar"
        Me.Editar.UseColumnTextForButtonValue = True
        Me.Editar.Width = 80
        '
        'Programar
        '
        Me.Programar.HeaderText = ""
        Me.Programar.Name = "Programar"
        Me.Programar.Text = "Programar"
        Me.Programar.ToolTipText = "Programar"
        Me.Programar.UseColumnTextForButtonValue = True
        Me.Programar.Width = 80
        '
        'Column_cerrado
        '
        Me.Column_cerrado.HeaderText = ""
        Me.Column_cerrado.Name = "Column_cerrado"
        Me.Column_cerrado.Text = "Cerrado"
        Me.Column_cerrado.ToolTipText = "Cerrado"
        Me.Column_cerrado.UseColumnTextForButtonValue = True
        '
        'Anular
        '
        Me.Anular.HeaderText = ""
        Me.Anular.Name = "Anular"
        Me.Anular.Text = "Anular"
        Me.Anular.ToolTipText = "Anular"
        Me.Anular.UseColumnTextForButtonValue = True
        Me.Anular.Width = 80
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.tslCantidad})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 489)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(893, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(84, 17)
        Me.ToolStripStatusLabel1.Text = "Cantidad Req :"
        '
        'tslCantidad
        '
        Me.tslCantidad.Name = "tslCantidad"
        Me.tslCantidad.Size = New System.Drawing.Size(13, 17)
        Me.tslCantidad.Text = "0"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(5, 100)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.dgvListadoRequerimientos)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(882, 386)
        Me.SplitContainer1.SplitterDistance = 223
        Me.SplitContainer1.TabIndex = 3
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(7, 6)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(869, 150)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.rtbDetalleReq)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(861, 124)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Detalle del Requerimiento"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'rtbDetalleReq
        '
        Me.rtbDetalleReq.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtbDetalleReq.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbDetalleReq.Location = New System.Drawing.Point(6, 6)
        Me.rtbDetalleReq.Name = "rtbDetalleReq"
        Me.rtbDetalleReq.Size = New System.Drawing.Size(849, 112)
        Me.rtbDetalleReq.TabIndex = 0
        Me.rtbDetalleReq.Text = ""
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgvArchivosAdjuntos)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(861, 124)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Archivos Adjuntos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgvArchivosAdjuntos
        '
        Me.dgvArchivosAdjuntos.AllowUserToAddRows = False
        Me.dgvArchivosAdjuntos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvArchivosAdjuntos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvArchivosAdjuntos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.fileName, Me.ruta, Me.Column_ver})
        Me.dgvArchivosAdjuntos.Location = New System.Drawing.Point(6, 6)
        Me.dgvArchivosAdjuntos.Name = "dgvArchivosAdjuntos"
        Me.dgvArchivosAdjuntos.ReadOnly = True
        Me.dgvArchivosAdjuntos.RowHeadersVisible = False
        Me.dgvArchivosAdjuntos.Size = New System.Drawing.Size(849, 112)
        Me.dgvArchivosAdjuntos.TabIndex = 36
        '
        'fileName
        '
        Me.fileName.HeaderText = "Nombre Archivo"
        Me.fileName.Name = "fileName"
        Me.fileName.ReadOnly = True
        Me.fileName.Width = 250
        '
        'ruta
        '
        Me.ruta.HeaderText = "Archivos Adjuntos"
        Me.ruta.Name = "ruta"
        Me.ruta.ReadOnly = True
        Me.ruta.Width = 500
        '
        'Column_ver
        '
        Me.Column_ver.HeaderText = ""
        Me.Column_ver.Name = "Column_ver"
        Me.Column_ver.ReadOnly = True
        Me.Column_ver.Text = "Abrir "
        Me.Column_ver.ToolTipText = "Abrir"
        Me.Column_ver.UseColumnTextForButtonValue = True
        Me.Column_ver.Width = 80
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.dgvListarObservaciones)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(861, 124)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Observaciones"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'dgvListarObservaciones
        '
        Me.dgvListarObservaciones.AllowUserToAddRows = False
        Me.dgvListarObservaciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvListarObservaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListarObservaciones.Location = New System.Drawing.Point(5, 5)
        Me.dgvListarObservaciones.Name = "dgvListarObservaciones"
        Me.dgvListarObservaciones.Size = New System.Drawing.Size(850, 112)
        Me.dgvListarObservaciones.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nombre Archivo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 250
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Archivos Adjuntos"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 500
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Estado"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 70
        '
        'DataGridViewTextBoxColumn4
        '
        DataGridViewCellStyle15.Format = "g"
        DataGridViewCellStyle15.NullValue = Nothing
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle15
        Me.DataGridViewTextBoxColumn4.HeaderText = "Fecha Registro"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 120
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Asunto"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 200
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Solicitante"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 130
        '
        'DataGridViewTextBoxColumn7
        '
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle16
        Me.DataGridViewTextBoxColumn7.HeaderText = "Empresa"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 70
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "Responsable"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        DataGridViewCellStyle17.Format = "g"
        DataGridViewCellStyle17.NullValue = Nothing
        Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle17
        Me.DataGridViewTextBoxColumn9.HeaderText = "Fecha Inicio"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 120
        '
        'DataGridViewTextBoxColumn10
        '
        DataGridViewCellStyle18.Format = "g"
        DataGridViewCellStyle18.NullValue = Nothing
        Me.DataGridViewTextBoxColumn10.DefaultCellStyle = DataGridViewCellStyle18
        Me.DataGridViewTextBoxColumn10.HeaderText = "Fecha Fin"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 120
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.HeaderText = "Nombre Archivo"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Visible = False
        Me.DataGridViewTextBoxColumn11.Width = 250
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.HeaderText = "Archivos Adjuntos"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Width = 500
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.HeaderText = "Archivos Adjuntos"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Width = 500
        '
        'Timer1
        '
        Me.Timer1.Interval = 3600000
        '
        'frmRequerimientos_TI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(893, 511)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmRequerimientos_TI"
        Me.Text = "Requerimientos TI"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvListadoRequerimientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgvArchivosAdjuntos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.dgvListarObservaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtpFecFin As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpFecIni As DateTimePicker
    Friend WithEvents btnNuevo As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents cboResponsable As ComboBox
    Friend WithEvents dgvListadoRequerimientos As DataGridView
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents btnBuscar As Button
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents rtbDetalleReq As RichTextBox
    Friend WithEvents dgvArchivosAdjuntos As DataGridView
    Friend WithEvents dgvListarObservaciones As DataGridView
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
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents tslCantidad As ToolStripStatusLabel
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents btnExportar As Button
    Friend WithEvents fileName As DataGridViewTextBoxColumn
    Friend WithEvents ruta As DataGridViewTextBoxColumn
    Friend WithEvents Column_ver As DataGridViewButtonColumn
    Friend WithEvents cboEstados As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents chkPendProg As CheckBox
    Friend WithEvents ckbSincronizar As CheckBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents req_id As DataGridViewTextBoxColumn
    Friend WithEvents color1 As DataGridViewTextBoxColumn
    Friend WithEvents est_descripcion As DataGridViewTextBoxColumn
    Friend WithEvents req_fecreg As DataGridViewTextBoxColumn
    Friend WithEvents req_asunto As DataGridViewTextBoxColumn
    Friend WithEvents usr_nombre As DataGridViewTextBoxColumn
    Friend WithEvents emp_des As DataGridViewTextBoxColumn
    Friend WithEvents res_nombre As DataGridViewTextBoxColumn
    Friend WithEvents rpr_fecinicio As DataGridViewTextBoxColumn
    Friend WithEvents rpr_fecfin As DataGridViewTextBoxColumn
    Friend WithEvents req_descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Editar As DataGridViewButtonColumn
    Friend WithEvents Programar As DataGridViewButtonColumn
    Friend WithEvents Column_cerrado As DataGridViewButtonColumn
    Friend WithEvents Anular As DataGridViewButtonColumn
End Class
