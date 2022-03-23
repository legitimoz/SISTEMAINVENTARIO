<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteDespacho
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Filtros = New System.Windows.Forms.GroupBox()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtGuia = New System.Windows.Forms.TextBox()
        Me.chkBxGuia = New System.Windows.Forms.CheckBox()
        Me.cbxEstados = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbxTransportista = New System.Windows.Forms.ComboBox()
        Me.Transportista = New System.Windows.Forms.Label()
        Me.dtpFecFin = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvListarRutas_Guias = New System.Windows.Forms.DataGridView()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsbCantTotal = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tslCantPend = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tslCantEntregados = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tslCantRechaz = New System.Windows.Forms.ToolStripStatusLabel()
        Me.savedialog_Excel = New System.Windows.Forms.SaveFileDialog()
        Me.Filtros.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvListarRutas_Guias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Filtros
        '
        Me.Filtros.Controls.Add(Me.btnExportar)
        Me.Filtros.Controls.Add(Me.btnBuscar)
        Me.Filtros.Controls.Add(Me.txtGuia)
        Me.Filtros.Controls.Add(Me.chkBxGuia)
        Me.Filtros.Controls.Add(Me.cbxEstados)
        Me.Filtros.Controls.Add(Me.Label3)
        Me.Filtros.Controls.Add(Me.cbxTransportista)
        Me.Filtros.Controls.Add(Me.Transportista)
        Me.Filtros.Controls.Add(Me.dtpFecFin)
        Me.Filtros.Controls.Add(Me.dtpFechaInicio)
        Me.Filtros.Controls.Add(Me.Label2)
        Me.Filtros.Controls.Add(Me.Label1)
        Me.Filtros.Location = New System.Drawing.Point(2, 2)
        Me.Filtros.Margin = New System.Windows.Forms.Padding(2)
        Me.Filtros.Name = "Filtros"
        Me.Filtros.Padding = New System.Windows.Forms.Padding(2)
        Me.Filtros.Size = New System.Drawing.Size(952, 87)
        Me.Filtros.TabIndex = 0
        Me.Filtros.TabStop = False
        Me.Filtros.Text = "Filtros:"
        '
        'btnExportar
        '
        Me.btnExportar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExportar.Image = Global.WindowsApp1.My.Resources.Resources.icon_excel2
        Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExportar.Location = New System.Drawing.Point(359, 50)
        Me.btnExportar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(90, 28)
        Me.btnExportar.TabIndex = 10
        Me.btnExportar.Text = "Exportar"
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.Image = Global.WindowsApp1.My.Resources.Resources._1043
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscar.Location = New System.Drawing.Point(249, 50)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(90, 28)
        Me.btnBuscar.TabIndex = 9
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtGuia
        '
        Me.txtGuia.Location = New System.Drawing.Point(82, 51)
        Me.txtGuia.Margin = New System.Windows.Forms.Padding(2)
        Me.txtGuia.Name = "txtGuia"
        Me.txtGuia.Size = New System.Drawing.Size(131, 20)
        Me.txtGuia.TabIndex = 8
        '
        'chkBxGuia
        '
        Me.chkBxGuia.AutoSize = True
        Me.chkBxGuia.Location = New System.Drawing.Point(12, 51)
        Me.chkBxGuia.Margin = New System.Windows.Forms.Padding(2)
        Me.chkBxGuia.Name = "chkBxGuia"
        Me.chkBxGuia.Size = New System.Drawing.Size(67, 17)
        Me.chkBxGuia.TabIndex = 7
        Me.chkBxGuia.Text = "Por Guia"
        Me.chkBxGuia.UseVisualStyleBackColor = True
        '
        'cbxEstados
        '
        Me.cbxEstados.BackColor = System.Drawing.Color.White
        Me.cbxEstados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxEstados.FormattingEnabled = True
        Me.cbxEstados.Location = New System.Drawing.Point(764, 18)
        Me.cbxEstados.Margin = New System.Windows.Forms.Padding(2)
        Me.cbxEstados.Name = "cbxEstados"
        Me.cbxEstados.Size = New System.Drawing.Size(120, 21)
        Me.cbxEstados.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(712, 22)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Estados:"
        '
        'cbxTransportista
        '
        Me.cbxTransportista.BackColor = System.Drawing.Color.White
        Me.cbxTransportista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTransportista.FormattingEnabled = True
        Me.cbxTransportista.Location = New System.Drawing.Point(477, 20)
        Me.cbxTransportista.Margin = New System.Windows.Forms.Padding(2)
        Me.cbxTransportista.Name = "cbxTransportista"
        Me.cbxTransportista.Size = New System.Drawing.Size(212, 21)
        Me.cbxTransportista.TabIndex = 4
        '
        'Transportista
        '
        Me.Transportista.AutoSize = True
        Me.Transportista.Location = New System.Drawing.Point(400, 22)
        Me.Transportista.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Transportista.Name = "Transportista"
        Me.Transportista.Size = New System.Drawing.Size(71, 13)
        Me.Transportista.TabIndex = 3
        Me.Transportista.Text = "Transportista:"
        '
        'dtpFecFin
        '
        Me.dtpFecFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecFin.Location = New System.Drawing.Point(249, 20)
        Me.dtpFecFin.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpFecFin.Name = "dtpFecFin"
        Me.dtpFecFin.Size = New System.Drawing.Size(91, 20)
        Me.dtpFecFin.TabIndex = 2
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.Location = New System.Drawing.Point(80, 20)
        Me.dtpFechaInicio.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(91, 20)
        Me.dtpFechaInicio.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(189, 22)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fecha Fin:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha Inicio:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.dgvListarRutas_Guias)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 93)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(952, 495)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Listado Rutas/Guias"
        '
        'dgvListarRutas_Guias
        '
        Me.dgvListarRutas_Guias.AllowUserToAddRows = False
        Me.dgvListarRutas_Guias.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgvListarRutas_Guias.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvListarRutas_Guias.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvListarRutas_Guias.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListarRutas_Guias.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvListarRutas_Guias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvListarRutas_Guias.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvListarRutas_Guias.Location = New System.Drawing.Point(8, 17)
        Me.dgvListarRutas_Guias.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvListarRutas_Guias.Name = "dgvListarRutas_Guias"
        Me.dgvListarRutas_Guias.RowTemplate.Height = 24
        Me.dgvListarRutas_Guias.Size = New System.Drawing.Size(940, 473)
        Me.dgvListarRutas_Guias.TabIndex = 0
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.tsbCantTotal, Me.ToolStripStatusLabel3, Me.tslCantPend, Me.ToolStripStatusLabel2, Me.tslCantEntregados, Me.ToolStripStatusLabel4, Me.tslCantRechaz})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 587)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 10, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(960, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(87, 17)
        Me.ToolStripStatusLabel1.Text = "Cantidad Total:"
        '
        'tsbCantTotal
        '
        Me.tsbCantTotal.Name = "tsbCantTotal"
        Me.tsbCantTotal.Size = New System.Drawing.Size(13, 17)
        Me.tsbCantTotal.Text = "0"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.ActiveLinkColor = System.Drawing.Color.Red
        Me.ToolStripStatusLabel3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel3.ForeColor = System.Drawing.Color.DarkRed
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(72, 17)
        Me.ToolStripStatusLabel3.Text = "Pendientes:"
        '
        'tslCantPend
        '
        Me.tslCantPend.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tslCantPend.ForeColor = System.Drawing.Color.DarkRed
        Me.tslCantPend.Name = "tslCantPend"
        Me.tslCantPend.Size = New System.Drawing.Size(14, 17)
        Me.tslCantPend.Text = "0"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(69, 17)
        Me.ToolStripStatusLabel2.Text = "Entregados:"
        '
        'tslCantEntregados
        '
        Me.tslCantEntregados.Name = "tslCantEntregados"
        Me.tslCantEntregados.Size = New System.Drawing.Size(13, 17)
        Me.tslCantEntregados.Text = "0"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(72, 17)
        Me.ToolStripStatusLabel4.Text = "Rechazados:"
        '
        'tslCantRechaz
        '
        Me.tslCantRechaz.Name = "tslCantRechaz"
        Me.tslCantRechaz.Size = New System.Drawing.Size(13, 17)
        Me.tslCantRechaz.Text = "0"
        '
        'frmReporteDespacho
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(960, 609)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Filtros)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmReporteDespacho"
        Me.Text = "Reporte Salida & RetornoRuta"
        Me.Filtros.ResumeLayout(False)
        Me.Filtros.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvListarRutas_Guias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Filtros As GroupBox
    Friend WithEvents btnExportar As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtGuia As TextBox
    Friend WithEvents chkBxGuia As CheckBox
    Friend WithEvents cbxEstados As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbxTransportista As ComboBox
    Friend WithEvents Transportista As Label
    Friend WithEvents dtpFecFin As DateTimePicker
    Friend WithEvents dtpFechaInicio As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvListarRutas_Guias As DataGridView
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents tsbCantTotal As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents tslCantPend As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents tslCantEntregados As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As ToolStripStatusLabel
    Friend WithEvents tslCantRechaz As ToolStripStatusLabel
    Friend WithEvents savedialog_Excel As SaveFileDialog
End Class
