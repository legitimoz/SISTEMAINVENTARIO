<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSolicitud_Institucional
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSolicitud_Institucional))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dtpFecFin = New System.Windows.Forms.DateTimePicker()
        Me.dtpFecIni = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCompania = New System.Windows.Forms.TextBox()
        Me.cbxCotizador = New System.Windows.Forms.ComboBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.dgvListarSolicitudes = New System.Windows.Forms.DataGridView()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgvArchivosAdjuntos = New System.Windows.Forms.DataGridView()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbIniciar = New System.Windows.Forms.ToolStripButton()
        Me.tsbDetener = New System.Windows.Forms.ToolStripButton()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProgressColumn2 = New WindowsApp1.ProgressColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sol_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sol_fecrecep = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sol_hora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sol_tiempo2 = New WindowsApp1.ProgressColumn()
        Me.est_codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sol_correo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sol_asunto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sol_contacto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sol_cuerpohtml = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cotizador = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Vendedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ruc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codvend = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codcot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dgvListarSolicitudes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvArchivosAdjuntos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.lblStatus)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.dtpFecFin)
        Me.GroupBox1.Controls.Add(Me.dtpFecIni)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtCompania)
        Me.GroupBox1.Controls.Add(Me.cbxCotizador)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 28)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(925, 64)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtros"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(91, 41)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 11)
        Me.lblStatus.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 11)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Sincronizado:"
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(839, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 25)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Consultar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dtpFecFin
        '
        Me.dtpFecFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecFin.Location = New System.Drawing.Point(239, 12)
        Me.dtpFecFin.Name = "dtpFecFin"
        Me.dtpFecFin.Size = New System.Drawing.Size(95, 18)
        Me.dtpFecFin.TabIndex = 10
        '
        'dtpFecIni
        '
        Me.dtpFecIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecIni.Location = New System.Drawing.Point(70, 14)
        Me.dtpFecIni.Name = "dtpFecIni"
        Me.dtpFecIni.Size = New System.Drawing.Size(95, 18)
        Me.dtpFecIni.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(186, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 11)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Fecha Fin:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 11)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Fecha Inicio:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(586, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 11)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Cliente:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(355, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 11)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Cotizador:"
        '
        'txtCompania
        '
        Me.txtCompania.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCompania.Location = New System.Drawing.Point(628, 13)
        Me.txtCompania.Name = "txtCompania"
        Me.txtCompania.Size = New System.Drawing.Size(200, 18)
        Me.txtCompania.TabIndex = 4
        '
        'cbxCotizador
        '
        Me.cbxCotizador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxCotizador.FormattingEnabled = True
        Me.cbxCotizador.Location = New System.Drawing.Point(406, 12)
        Me.cbxCotizador.Name = "cbxCotizador"
        Me.cbxCotizador.Size = New System.Drawing.Size(166, 19)
        Me.cbxCotizador.TabIndex = 3
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(10, 98)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.dgvListarSolicitudes)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.Gray
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(926, 368)
        Me.SplitContainer1.SplitterDistance = 184
        Me.SplitContainer1.TabIndex = 1
        '
        'dgvListarSolicitudes
        '
        Me.dgvListarSolicitudes.AllowUserToAddRows = False
        Me.dgvListarSolicitudes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvListarSolicitudes.BackgroundColor = System.Drawing.Color.White
        Me.dgvListarSolicitudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListarSolicitudes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sol_id, Me.sol_fecrecep, Me.sol_hora, Me.sol_tiempo2, Me.est_codigo, Me.sol_correo, Me.sol_asunto, Me.sol_contacto, Me.sol_cuerpohtml, Me.Cliente, Me.Cotizador, Me.Vendedor, Me.ruc, Me.codvend, Me.codcot})
        Me.dgvListarSolicitudes.Location = New System.Drawing.Point(3, 3)
        Me.dgvListarSolicitudes.Name = "dgvListarSolicitudes"
        Me.dgvListarSolicitudes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListarSolicitudes.Size = New System.Drawing.Size(918, 178)
        Me.dgvListarSolicitudes.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(3, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(918, 174)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.WebBrowser1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 20)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(910, 150)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Cuerpo Correo"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(3, 3)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(904, 144)
        Me.WebBrowser1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgvArchivosAdjuntos)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(910, 148)
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
        Me.dgvArchivosAdjuntos.Location = New System.Drawing.Point(6, 6)
        Me.dgvArchivosAdjuntos.Name = "dgvArchivosAdjuntos"
        Me.dgvArchivosAdjuntos.Size = New System.Drawing.Size(773, 124)
        Me.dgvArchivosAdjuntos.TabIndex = 0
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 469)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(958, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Timer1
        '
        Me.Timer1.Interval = 60000
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbIniciar, Me.tsbDetener})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(958, 25)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbIniciar
        '
        Me.tsbIniciar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbIniciar.Image = CType(resources.GetObject("tsbIniciar.Image"), System.Drawing.Image)
        Me.tsbIniciar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbIniciar.Name = "tsbIniciar"
        Me.tsbIniciar.Size = New System.Drawing.Size(23, 22)
        Me.tsbIniciar.Text = "Actualización Automática"
        '
        'tsbDetener
        '
        Me.tsbDetener.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbDetener.Image = CType(resources.GetObject("tsbDetener.Image"), System.Drawing.Image)
        Me.tsbDetener.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbDetener.Name = "tsbDetener"
        Me.tsbDetener.Size = New System.Drawing.Size(23, 22)
        Me.tsbDetener.Text = "Detener Actualización"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nro Solicitud"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 60
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 80
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Hora"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 60
        '
        'ProgressColumn2
        '
        Me.ProgressColumn2.HeaderText = "Progreso"
        Me.ProgressColumn2.Name = "ProgressColumn2"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Estado"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Correo Electronico"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 180
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Asunto"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 200
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "Contacto"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 150
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "CuerpoCorreo"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = "Cliente"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 300
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.HeaderText = "Cotizador"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 150
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.HeaderText = "Vendedor"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 150
        '
        'sol_id
        '
        Me.sol_id.HeaderText = "Nro Solicitud"
        Me.sol_id.Name = "sol_id"
        Me.sol_id.Width = 60
        '
        'sol_fecrecep
        '
        Me.sol_fecrecep.HeaderText = "Fecha"
        Me.sol_fecrecep.Name = "sol_fecrecep"
        Me.sol_fecrecep.Width = 80
        '
        'sol_hora
        '
        Me.sol_hora.HeaderText = "Hora"
        Me.sol_hora.Name = "sol_hora"
        Me.sol_hora.Width = 60
        '
        'sol_tiempo2
        '
        Me.sol_tiempo2.HeaderText = "Progreso"
        Me.sol_tiempo2.Name = "sol_tiempo2"
        '
        'est_codigo
        '
        Me.est_codigo.HeaderText = "Estado"
        Me.est_codigo.Name = "est_codigo"
        '
        'sol_correo
        '
        Me.sol_correo.HeaderText = "Correo Electronico"
        Me.sol_correo.Name = "sol_correo"
        Me.sol_correo.Width = 180
        '
        'sol_asunto
        '
        Me.sol_asunto.HeaderText = "Asunto"
        Me.sol_asunto.Name = "sol_asunto"
        Me.sol_asunto.Width = 300
        '
        'sol_contacto
        '
        Me.sol_contacto.HeaderText = "Contacto"
        Me.sol_contacto.Name = "sol_contacto"
        Me.sol_contacto.Width = 130
        '
        'sol_cuerpohtml
        '
        Me.sol_cuerpohtml.HeaderText = "CuerpoCorreo"
        Me.sol_cuerpohtml.Name = "sol_cuerpohtml"
        Me.sol_cuerpohtml.Visible = False
        '
        'Cliente
        '
        Me.Cliente.HeaderText = "Cliente"
        Me.Cliente.Name = "Cliente"
        Me.Cliente.Width = 300
        '
        'Cotizador
        '
        Me.Cotizador.HeaderText = "Cotizador"
        Me.Cotizador.Name = "Cotizador"
        Me.Cotizador.Width = 150
        '
        'Vendedor
        '
        Me.Vendedor.HeaderText = "Vendedor"
        Me.Vendedor.Name = "Vendedor"
        Me.Vendedor.Width = 150
        '
        'ruc
        '
        Me.ruc.HeaderText = "RUC"
        Me.ruc.Name = "ruc"
        '
        'codvend
        '
        Me.codvend.HeaderText = "codvend"
        Me.codvend.Name = "codvend"
        '
        'codcot
        '
        Me.codcot.HeaderText = "codcot"
        Me.codcot.Name = "codcot"
        '
        'frmSolicitud_Institucional
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(5.0!, 11.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(958, 491)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "frmSolicitud_Institucional"
        Me.Text = "Solicitudes Institucional"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dgvListarSolicitudes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgvArchivosAdjuntos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents dtpFecFin As DateTimePicker
    Friend WithEvents dtpFecIni As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCompania As TextBox
    Friend WithEvents cbxCotizador As ComboBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents dgvArchivosAdjuntos As DataGridView
    Friend WithEvents dgvListarSolicitudes As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents ProgressColumn1 As ProgressColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents Timer1 As Timer
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents Button1 As Button
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsbIniciar As ToolStripButton
    Friend WithEvents tsbDetener As ToolStripButton
    Friend WithEvents lblStatus As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents sol_tiempo As ProgressColumn
    Friend WithEvents ProgressColumn2 As ProgressColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents sol_id As DataGridViewTextBoxColumn
    Friend WithEvents sol_fecrecep As DataGridViewTextBoxColumn
    Friend WithEvents sol_hora As DataGridViewTextBoxColumn
    Friend WithEvents sol_tiempo2 As ProgressColumn
    Friend WithEvents est_codigo As DataGridViewTextBoxColumn
    Friend WithEvents sol_correo As DataGridViewTextBoxColumn
    Friend WithEvents sol_asunto As DataGridViewTextBoxColumn
    Friend WithEvents sol_contacto As DataGridViewTextBoxColumn
    Friend WithEvents sol_cuerpohtml As DataGridViewTextBoxColumn
    Friend WithEvents Cliente As DataGridViewTextBoxColumn
    Friend WithEvents Cotizador As DataGridViewTextBoxColumn
    Friend WithEvents Vendedor As DataGridViewTextBoxColumn
    Friend WithEvents ruc As DataGridViewTextBoxColumn
    Friend WithEvents codvend As DataGridViewTextBoxColumn
    Friend WithEvents codcot As DataGridViewTextBoxColumn
End Class
