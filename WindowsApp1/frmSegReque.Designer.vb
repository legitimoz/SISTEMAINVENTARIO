<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSegReque
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSegReque))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkAll = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnAsignar = New System.Windows.Forms.Button()
        Me.cboProductos = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkDetallado = New System.Windows.Forms.CheckBox()
        Me.chkTotalizado = New System.Windows.Forms.CheckBox()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.dtpFecFin = New System.Windows.Forms.DateTimePicker()
        Me.dtpFecIni = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCompania = New System.Windows.Forms.TextBox()
        Me.cbxCotizador = New System.Windows.Forms.ComboBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tslCantidad = New System.Windows.Forms.ToolStripStatusLabel()
        Me.dgvListadoRequerimientos = New System.Windows.Forms.DataGridView()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.dgvListarReqDetalle = New System.Windows.Forms.DataGridView()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgvLitadoRequerimientoDetalle = New System.Windows.Forms.DataGridView()
        Me.chk_selector = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.dgvListadoRequerimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dgvListarReqDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvLitadoRequerimientoDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.GroupBox1.Controls.Add(Me.chkAll)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.btnAsignar)
        Me.GroupBox1.Controls.Add(Me.cboProductos)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.btnExportar)
        Me.GroupBox1.Controls.Add(Me.btnNuevo)
        Me.GroupBox1.Controls.Add(Me.lblStatus)
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.dtpFecFin)
        Me.GroupBox1.Controls.Add(Me.dtpFecIni)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtCompania)
        Me.GroupBox1.Controls.Add(Me.cbxCotizador)
        Me.GroupBox1.Location = New System.Drawing.Point(1, 3)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(1339, 122)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtros"
        '
        'chkAll
        '
        Me.chkAll.AutoSize = True
        Me.chkAll.Location = New System.Drawing.Point(12, 92)
        Me.chkAll.Name = "chkAll"
        Me.chkAll.Size = New System.Drawing.Size(62, 15)
        Me.chkAll.TabIndex = 20
        Me.chkAll.Text = "CHK ALL"
        Me.chkAll.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 70)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 11)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "PRODUCTO:"
        '
        'btnAsignar
        '
        Me.btnAsignar.Image = Global.WindowsApp1.My.Resources.Resources._5711
        Me.btnAsignar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAsignar.Location = New System.Drawing.Point(521, 62)
        Me.btnAsignar.Name = "btnAsignar"
        Me.btnAsignar.Size = New System.Drawing.Size(88, 23)
        Me.btnAsignar.TabIndex = 18
        Me.btnAsignar.Text = "Asignar"
        Me.btnAsignar.UseVisualStyleBackColor = True
        '
        'cboProductos
        '
        Me.cboProductos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboProductos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboProductos.DropDownWidth = 450
        Me.cboProductos.FormattingEnabled = True
        Me.cboProductos.Location = New System.Drawing.Point(94, 65)
        Me.cboProductos.Name = "cboProductos"
        Me.cboProductos.Size = New System.Drawing.Size(417, 19)
        Me.cboProductos.TabIndex = 16
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkDetallado)
        Me.GroupBox2.Controls.Add(Me.chkTotalizado)
        Me.GroupBox2.Location = New System.Drawing.Point(697, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(196, 38)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Vista"
        '
        'chkDetallado
        '
        Me.chkDetallado.AutoSize = True
        Me.chkDetallado.Location = New System.Drawing.Point(106, 15)
        Me.chkDetallado.Name = "chkDetallado"
        Me.chkDetallado.Size = New System.Drawing.Size(79, 15)
        Me.chkDetallado.TabIndex = 1
        Me.chkDetallado.Text = "DETALLADA"
        Me.chkDetallado.UseVisualStyleBackColor = True
        '
        'chkTotalizado
        '
        Me.chkTotalizado.AutoSize = True
        Me.chkTotalizado.Location = New System.Drawing.Point(10, 15)
        Me.chkTotalizado.Name = "chkTotalizado"
        Me.chkTotalizado.Size = New System.Drawing.Size(85, 15)
        Me.chkTotalizado.TabIndex = 0
        Me.chkTotalizado.Text = "TOTALIZADA"
        Me.chkTotalizado.UseVisualStyleBackColor = True
        '
        'btnExportar
        '
        Me.btnExportar.Image = CType(resources.GetObject("btnExportar.Image"), System.Drawing.Image)
        Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExportar.Location = New System.Drawing.Point(1216, 12)
        Me.btnExportar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(98, 28)
        Me.btnExportar.TabIndex = 12
        Me.btnExportar.Text = "   Exportar"
        Me.btnExportar.UseVisualStyleBackColor = True
        Me.btnExportar.Visible = False
        '
        'btnNuevo
        '
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevo.Location = New System.Drawing.Point(1105, 12)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(98, 28)
        Me.btnNuevo.TabIndex = 14
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(76, 37)
        Me.lblStatus.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 11)
        Me.lblStatus.TabIndex = 13
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(991, 12)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(98, 28)
        Me.btnBuscar.TabIndex = 11
        Me.btnBuscar.Text = "Consultar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'dtpFecFin
        '
        Me.dtpFecFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecFin.Location = New System.Drawing.Point(265, 14)
        Me.dtpFecFin.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dtpFecFin.Name = "dtpFecFin"
        Me.dtpFecFin.Size = New System.Drawing.Size(80, 18)
        Me.dtpFecFin.TabIndex = 10
        '
        'dtpFecIni
        '
        Me.dtpFecIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecIni.Location = New System.Drawing.Point(94, 13)
        Me.dtpFecIni.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dtpFecIni.Name = "dtpFecIni"
        Me.dtpFecIni.Size = New System.Drawing.Size(80, 18)
        Me.dtpFecIni.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(201, 17)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 11)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "FECHA FIN:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 17)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 11)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "FECHA INICIO:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 46)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 11)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "CLIENTE:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(364, 17)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 11)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "COTIZADOR:"
        '
        'txtCompania
        '
        Me.txtCompania.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCompania.Location = New System.Drawing.Point(94, 41)
        Me.txtCompania.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtCompania.Name = "txtCompania"
        Me.txtCompania.Size = New System.Drawing.Size(251, 18)
        Me.txtCompania.TabIndex = 4
        '
        'cbxCotizador
        '
        Me.cbxCotizador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxCotizador.DropDownWidth = 300
        Me.cbxCotizador.FormattingEnabled = True
        Me.cbxCotizador.Location = New System.Drawing.Point(436, 13)
        Me.cbxCotizador.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cbxCotizador.Name = "cbxCotizador"
        Me.cbxCotizador.Size = New System.Drawing.Size(230, 19)
        Me.cbxCotizador.TabIndex = 3
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.tslCantidad})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 662)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1343, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(81, 17)
        Me.ToolStripStatusLabel1.Text = "Cantidad Req:"
        '
        'tslCantidad
        '
        Me.tslCantidad.Name = "tslCantidad"
        Me.tslCantidad.Size = New System.Drawing.Size(13, 17)
        Me.tslCantidad.Text = "0"
        '
        'dgvListadoRequerimientos
        '
        Me.dgvListadoRequerimientos.AllowUserToAddRows = False
        Me.dgvListadoRequerimientos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvListadoRequerimientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvListadoRequerimientos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvListadoRequerimientos.BackgroundColor = System.Drawing.Color.White
        Me.dgvListadoRequerimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListadoRequerimientos.Location = New System.Drawing.Point(6, 8)
        Me.dgvListadoRequerimientos.Name = "dgvListadoRequerimientos"
        Me.dgvListadoRequerimientos.Size = New System.Drawing.Size(1292, 238)
        Me.dgvListadoRequerimientos.TabIndex = 4
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(8, 8)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.dgvListadoRequerimientos)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.dgvListarReqDetalle)
        Me.SplitContainer1.Size = New System.Drawing.Size(1306, 485)
        Me.SplitContainer1.SplitterDistance = 260
        Me.SplitContainer1.TabIndex = 5
        '
        'dgvListarReqDetalle
        '
        Me.dgvListarReqDetalle.AllowUserToAddRows = False
        Me.dgvListarReqDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvListarReqDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvListarReqDetalle.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvListarReqDetalle.BackgroundColor = System.Drawing.Color.White
        Me.dgvListarReqDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListarReqDetalle.Location = New System.Drawing.Point(7, 9)
        Me.dgvListarReqDetalle.Name = "dgvListarReqDetalle"
        Me.dgvListarReqDetalle.Size = New System.Drawing.Size(1291, 202)
        Me.dgvListarReqDetalle.TabIndex = 5
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(6, 131)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1328, 527)
        Me.TabControl1.TabIndex = 6
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.SplitContainer1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 20)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1320, 503)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TOTALIZADO"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgvLitadoRequerimientoDetalle)
        Me.TabPage2.Location = New System.Drawing.Point(4, 20)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1320, 503)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "DETALLADO"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgvLitadoRequerimientoDetalle
        '
        Me.dgvLitadoRequerimientoDetalle.AllowUserToAddRows = False
        Me.dgvLitadoRequerimientoDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvLitadoRequerimientoDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvLitadoRequerimientoDetalle.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvLitadoRequerimientoDetalle.BackgroundColor = System.Drawing.Color.White
        Me.dgvLitadoRequerimientoDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLitadoRequerimientoDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.chk_selector})
        Me.dgvLitadoRequerimientoDetalle.Location = New System.Drawing.Point(6, 6)
        Me.dgvLitadoRequerimientoDetalle.Name = "dgvLitadoRequerimientoDetalle"
        Me.dgvLitadoRequerimientoDetalle.Size = New System.Drawing.Size(1307, 509)
        Me.dgvLitadoRequerimientoDetalle.TabIndex = 3
        '
        'chk_selector
        '
        Me.chk_selector.HeaderText = ""
        Me.chk_selector.Name = "chk_selector"
        Me.chk_selector.Width = 5
        '
        'frmSegReque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(5.0!, 11.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1343, 684)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "frmSegReque"
        Me.Text = "Seguimiento Requerimientos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.dgvListadoRequerimientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dgvListarReqDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgvLitadoRequerimientoDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents dtpFecFin As DateTimePicker
    Friend WithEvents dtpFecIni As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCompania As TextBox
    Friend WithEvents cbxCotizador As ComboBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents btnNuevo As Button
    Friend WithEvents dgvListadoRequerimientos As DataGridView
    Friend WithEvents btnExportar As Button
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents dgvListarReqDetalle As DataGridView
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents tslCantidad As ToolStripStatusLabel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chkDetallado As CheckBox
    Friend WithEvents chkTotalizado As CheckBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents dgvLitadoRequerimientoDetalle As DataGridView
    Friend WithEvents chk_selector As DataGridViewCheckBoxColumn
    Friend WithEvents cboProductos As ComboBox
    Friend WithEvents btnAsignar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents chkAll As CheckBox
End Class
