<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImpreMasivaPickingvb
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnExcel = New System.Windows.Forms.Button()
        Me.chkAll = New System.Windows.Forms.CheckBox()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.dtpFecFin = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpFecIni = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboTransportistas = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.dgvGuiasImpresion = New System.Windows.Forms.DataGridView()
        Me.selecGuia = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.FECHA_GUIA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GUIA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NPEDIDO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RUC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIENTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TRANSPORTES = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESTADO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IMPRESO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHA_IMPRESION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.USUARIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C5_DFECCRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C5_DFECDOC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tslCantidad = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tslPendImp = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tslImpresos = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvGuiasImpresion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.DarkRed
        Me.GroupBox1.Controls.Add(Me.btnExcel)
        Me.GroupBox1.Controls.Add(Me.chkAll)
        Me.GroupBox1.Controls.Add(Me.btnImprimir)
        Me.GroupBox1.Controls.Add(Me.dtpFecFin)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dtpFecIni)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cboTransportistas)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(1, 2)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(1366, 142)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'btnExcel
        '
        Me.btnExcel.BackColor = System.Drawing.Color.White
        Me.btnExcel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExcel.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcel.ForeColor = System.Drawing.Color.Black
        Me.btnExcel.Image = Global.WindowsApp1.My.Resources.Resources.icon_excel
        Me.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExcel.Location = New System.Drawing.Point(1104, 30)
        Me.btnExcel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(128, 40)
        Me.btnExcel.TabIndex = 79
        Me.btnExcel.Text = "Excel"
        Me.btnExcel.UseVisualStyleBackColor = False
        '
        'chkAll
        '
        Me.chkAll.AutoSize = True
        Me.chkAll.ForeColor = System.Drawing.Color.White
        Me.chkAll.Location = New System.Drawing.Point(60, 106)
        Me.chkAll.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkAll.Name = "chkAll"
        Me.chkAll.Size = New System.Drawing.Size(125, 25)
        Me.chkAll.TabIndex = 10
        Me.chkAll.Text = "Marcar Todo"
        Me.chkAll.UseVisualStyleBackColor = True
        '
        'btnImprimir
        '
        Me.btnImprimir.BackColor = System.Drawing.Color.White
        Me.btnImprimir.Image = Global.WindowsApp1.My.Resources.Resources._004
        Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImprimir.Location = New System.Drawing.Point(911, 31)
        Me.btnImprimir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(139, 38)
        Me.btnImprimir.TabIndex = 9
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = False
        '
        'dtpFecFin
        '
        Me.dtpFecFin.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtpFecFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecFin.Location = New System.Drawing.Point(408, 28)
        Me.dtpFecFin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtpFecFin.Name = "dtpFecFin"
        Me.dtpFecFin.Size = New System.Drawing.Size(135, 28)
        Me.dtpFecFin.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(315, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 21)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Fecha Fin:"
        '
        'dtpFecIni
        '
        Me.dtpFecIni.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtpFecIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecIni.Location = New System.Drawing.Point(149, 28)
        Me.dtpFecIni.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtpFecIni.Name = "dtpFecIni"
        Me.dtpFecIni.Size = New System.Drawing.Size(135, 28)
        Me.dtpFecIni.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(20, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 21)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Fecha Inicio:"
        '
        'cboTransportistas
        '
        Me.cboTransportistas.BackColor = System.Drawing.Color.White
        Me.cboTransportistas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTransportistas.FormattingEnabled = True
        Me.cboTransportistas.Location = New System.Drawing.Point(149, 66)
        Me.cboTransportistas.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboTransportistas.Name = "cboTransportistas"
        Me.cboTransportistas.Size = New System.Drawing.Size(495, 29)
        Me.cboTransportistas.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(20, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 21)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Transportistas:"
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.White
        Me.btnBuscar.Image = Global.WindowsApp1.My.Resources.Resources._104
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(719, 31)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(131, 38)
        Me.btnBuscar.TabIndex = 3
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'dgvGuiasImpresion
        '
        Me.dgvGuiasImpresion.AllowUserToAddRows = False
        Me.dgvGuiasImpresion.AllowUserToDeleteRows = False
        Me.dgvGuiasImpresion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvGuiasImpresion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGuiasImpresion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.selecGuia, Me.FECHA_GUIA, Me.GUIA, Me.NPEDIDO, Me.RUC, Me.CLIENTE, Me.TRANSPORTES, Me.ESTADO, Me.IMPRESO, Me.FECHA_IMPRESION, Me.USUARIO, Me.C5_DFECCRE, Me.C5_DFECDOC})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvGuiasImpresion.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvGuiasImpresion.Location = New System.Drawing.Point(1, 146)
        Me.dgvGuiasImpresion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvGuiasImpresion.MultiSelect = False
        Me.dgvGuiasImpresion.Name = "dgvGuiasImpresion"
        Me.dgvGuiasImpresion.RowTemplate.Height = 24
        Me.dgvGuiasImpresion.Size = New System.Drawing.Size(1364, 567)
        Me.dgvGuiasImpresion.TabIndex = 8
        '
        'selecGuia
        '
        Me.selecGuia.HeaderText = "CHK"
        Me.selecGuia.Name = "selecGuia"
        Me.selecGuia.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.selecGuia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.selecGuia.Width = 40
        '
        'FECHA_GUIA
        '
        Me.FECHA_GUIA.HeaderText = "FECHA GUIA"
        Me.FECHA_GUIA.Name = "FECHA_GUIA"
        Me.FECHA_GUIA.ReadOnly = True
        Me.FECHA_GUIA.Width = 150
        '
        'GUIA
        '
        Me.GUIA.HeaderText = "NRO GUIA"
        Me.GUIA.Name = "GUIA"
        Me.GUIA.ReadOnly = True
        '
        'NPEDIDO
        '
        Me.NPEDIDO.HeaderText = "NRO PEDIDO"
        Me.NPEDIDO.Name = "NPEDIDO"
        Me.NPEDIDO.ReadOnly = True
        '
        'RUC
        '
        Me.RUC.HeaderText = "RUC"
        Me.RUC.Name = "RUC"
        Me.RUC.ReadOnly = True
        Me.RUC.Width = 150
        '
        'CLIENTE
        '
        Me.CLIENTE.HeaderText = "CLIENTE"
        Me.CLIENTE.Name = "CLIENTE"
        Me.CLIENTE.ReadOnly = True
        Me.CLIENTE.Width = 350
        '
        'TRANSPORTES
        '
        Me.TRANSPORTES.HeaderText = "TRANSPORTES"
        Me.TRANSPORTES.Name = "TRANSPORTES"
        Me.TRANSPORTES.ReadOnly = True
        Me.TRANSPORTES.Width = 200
        '
        'ESTADO
        '
        Me.ESTADO.HeaderText = "ESTADO"
        Me.ESTADO.Name = "ESTADO"
        Me.ESTADO.ReadOnly = True
        '
        'IMPRESO
        '
        Me.IMPRESO.HeaderText = "IMPRESO"
        Me.IMPRESO.Name = "IMPRESO"
        Me.IMPRESO.ReadOnly = True
        Me.IMPRESO.Width = 60
        '
        'FECHA_IMPRESION
        '
        Me.FECHA_IMPRESION.HeaderText = "FECHA IMPRESION"
        Me.FECHA_IMPRESION.Name = "FECHA_IMPRESION"
        Me.FECHA_IMPRESION.Width = 120
        '
        'USUARIO
        '
        Me.USUARIO.HeaderText = "USUARIO"
        Me.USUARIO.Name = "USUARIO"
        Me.USUARIO.Width = 150
        '
        'C5_DFECCRE
        '
        Me.C5_DFECCRE.HeaderText = "C5_DFECCRE"
        Me.C5_DFECCRE.Name = "C5_DFECCRE"
        Me.C5_DFECCRE.Visible = False
        '
        'C5_DFECDOC
        '
        Me.C5_DFECDOC.HeaderText = "C5_DFECDOC"
        Me.C5_DFECDOC.Name = "C5_DFECDOC"
        Me.C5_DFECDOC.Visible = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.tslCantidad, Me.ToolStripStatusLabel2, Me.tslPendImp, Me.ToolStripStatusLabel3, Me.tslImpresos})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 725)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 13, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1371, 25)
        Me.StatusStrip1.TabIndex = 9
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(110, 20)
        Me.ToolStripStatusLabel1.Text = "Total Registros:"
        '
        'tslCantidad
        '
        Me.tslCantidad.Name = "tslCantidad"
        Me.tslCantidad.Size = New System.Drawing.Size(17, 20)
        Me.tslCantidad.Text = "0"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(144, 20)
        Me.ToolStripStatusLabel2.Text = "Pendientes Imprimir:"
        '
        'tslPendImp
        '
        Me.tslPendImp.Name = "tslPendImp"
        Me.tslPendImp.Size = New System.Drawing.Size(17, 20)
        Me.tslPendImp.Text = "0"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(72, 20)
        Me.ToolStripStatusLabel3.Text = "Impresos:"
        '
        'tslImpresos
        '
        Me.tslImpresos.Name = "tslImpresos"
        Me.tslImpresos.Size = New System.Drawing.Size(17, 20)
        Me.tslImpresos.Text = "0"
        '
        'frmImpreMasivaPickingvb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1371, 750)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.dgvGuiasImpresion)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmImpreMasivaPickingvb"
        Me.Text = "Impresion Masiva Picking"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvGuiasImpresion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cboTransportistas As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents dtpFecFin As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpFecIni As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvGuiasImpresion As DataGridView
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents tslCantidad As ToolStripStatusLabel
    Friend WithEvents btnImprimir As Button
    Friend WithEvents chkAll As CheckBox
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents tslPendImp As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents tslImpresos As ToolStripStatusLabel
    Friend WithEvents btnExcel As Button
    Friend WithEvents selecGuia As DataGridViewCheckBoxColumn
    Friend WithEvents FECHA_GUIA As DataGridViewTextBoxColumn
    Friend WithEvents GUIA As DataGridViewTextBoxColumn
    Friend WithEvents NPEDIDO As DataGridViewTextBoxColumn
    Friend WithEvents RUC As DataGridViewTextBoxColumn
    Friend WithEvents CLIENTE As DataGridViewTextBoxColumn
    Friend WithEvents TRANSPORTES As DataGridViewTextBoxColumn
    Friend WithEvents ESTADO As DataGridViewTextBoxColumn
    Friend WithEvents IMPRESO As DataGridViewTextBoxColumn
    Friend WithEvents FECHA_IMPRESION As DataGridViewTextBoxColumn
    Friend WithEvents USUARIO As DataGridViewTextBoxColumn
    Friend WithEvents C5_DFECCRE As DataGridViewTextBoxColumn
    Friend WithEvents C5_DFECDOC As DataGridViewTextBoxColumn
End Class
