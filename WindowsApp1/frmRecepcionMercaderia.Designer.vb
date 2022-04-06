<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecepcionMercaderia
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboAlmacenes = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBuscarOC = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.dtpFecFin = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpFecIni = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.dgvCabOrdenesCompra = New System.Windows.Forms.DataGridView()
        Me.FechaRecepcion = New WindowsApp1.DateTimeGridColumn()
        Me.numero_oc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.razon_social = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_doc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_entrega = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lugar_entrega = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.almacen_destino = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.destino = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvDetOrdenesCompra = New System.Windows.Forms.DataGridView()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tslTotalRegistro = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tslPendiente = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tslRecepcionados = New System.Windows.Forms.ToolStripStatusLabel()
        Me.DateTimeGridColumn1 = New WindowsApp1.DateTimeGridColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dgvCabOrdenesCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDetOrdenesCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.cboAlmacenes)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtBuscarOC)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.dtpFecFin)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dtpFecIni)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(1, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1173, 119)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtros de Busqueda:"
        '
        'cboAlmacenes
        '
        Me.cboAlmacenes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboAlmacenes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboAlmacenes.FormattingEnabled = True
        Me.cboAlmacenes.Location = New System.Drawing.Point(103, 59)
        Me.cboAlmacenes.Name = "cboAlmacenes"
        Me.cboAlmacenes.Size = New System.Drawing.Size(324, 21)
        Me.cboAlmacenes.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Almacen Destino:"
        '
        'txtBuscarOC
        '
        Me.txtBuscarOC.Location = New System.Drawing.Point(519, 57)
        Me.txtBuscarOC.Name = "txtBuscarOC"
        Me.txtBuscarOC.Size = New System.Drawing.Size(153, 21)
        Me.txtBuscarOC.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(445, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Numero OC:"
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = Global.WindowsApp1.My.Resources.Resources._104
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscar.Location = New System.Drawing.Point(552, 21)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(120, 26)
        Me.btnBuscar.TabIndex = 4
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'dtpFecFin
        '
        Me.dtpFecFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecFin.Location = New System.Drawing.Point(308, 23)
        Me.dtpFecFin.Name = "dtpFecFin"
        Me.dtpFecFin.Size = New System.Drawing.Size(116, 21)
        Me.dtpFecFin.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(240, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fecha Fin:"
        '
        'dtpFecIni
        '
        Me.dtpFecIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecIni.Location = New System.Drawing.Point(103, 23)
        Me.dtpFecIni.Name = "dtpFecIni"
        Me.dtpFecIni.Size = New System.Drawing.Size(116, 21)
        Me.dtpFecIni.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha Inicio:"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(1, 127)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.dgvCabOrdenesCompra)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.dgvDetOrdenesCompra)
        Me.SplitContainer1.Size = New System.Drawing.Size(1173, 481)
        Me.SplitContainer1.SplitterDistance = 265
        Me.SplitContainer1.TabIndex = 1
        '
        'dgvCabOrdenesCompra
        '
        Me.dgvCabOrdenesCompra.AllowUserToAddRows = False
        Me.dgvCabOrdenesCompra.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.dgvCabOrdenesCompra.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCabOrdenesCompra.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCabOrdenesCompra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvCabOrdenesCompra.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvCabOrdenesCompra.BackgroundColor = System.Drawing.Color.White
        Me.dgvCabOrdenesCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCabOrdenesCompra.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FechaRecepcion, Me.numero_oc, Me.razon_social, Me.fecha_doc, Me.tipo, Me.fecha_entrega, Me.lugar_entrega, Me.usuario, Me.almacen_destino, Me.destino})
        Me.dgvCabOrdenesCompra.Location = New System.Drawing.Point(7, 8)
        Me.dgvCabOrdenesCompra.MultiSelect = False
        Me.dgvCabOrdenesCompra.Name = "dgvCabOrdenesCompra"
        Me.dgvCabOrdenesCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCabOrdenesCompra.Size = New System.Drawing.Size(1160, 241)
        Me.dgvCabOrdenesCompra.TabIndex = 0
        '
        'FechaRecepcion
        '
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.FechaRecepcion.DefaultCellStyle = DataGridViewCellStyle2
        Me.FechaRecepcion.HeaderText = "FECHA RECEPCION MERCADERIA"
        Me.FechaRecepcion.Name = "FechaRecepcion"
        Me.FechaRecepcion.Width = 168
        '
        'numero_oc
        '
        Me.numero_oc.HeaderText = "NUMERO OC"
        Me.numero_oc.Name = "numero_oc"
        Me.numero_oc.Width = 90
        '
        'razon_social
        '
        Me.razon_social.HeaderText = "RAZON SOCIAL"
        Me.razon_social.Name = "razon_social"
        Me.razon_social.Width = 102
        '
        'fecha_doc
        '
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.fecha_doc.DefaultCellStyle = DataGridViewCellStyle3
        Me.fecha_doc.HeaderText = "FECHA DOC"
        Me.fecha_doc.Name = "fecha_doc"
        Me.fecha_doc.Width = 86
        '
        'tipo
        '
        Me.tipo.HeaderText = "TIPO"
        Me.tipo.Name = "tipo"
        Me.tipo.Width = 57
        '
        'fecha_entrega
        '
        DataGridViewCellStyle4.Format = "d"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.fecha_entrega.DefaultCellStyle = DataGridViewCellStyle4
        Me.fecha_entrega.HeaderText = "FECHA ENTREGA"
        Me.fecha_entrega.Name = "fecha_entrega"
        Me.fecha_entrega.Width = 112
        '
        'lugar_entrega
        '
        Me.lugar_entrega.HeaderText = "LUGAR ENTREGA"
        Me.lugar_entrega.Name = "lugar_entrega"
        Me.lugar_entrega.Width = 114
        '
        'usuario
        '
        Me.usuario.HeaderText = "USUARIO"
        Me.usuario.Name = "usuario"
        Me.usuario.Width = 81
        '
        'almacen_destino
        '
        Me.almacen_destino.HeaderText = "ALMACEN DESTINO"
        Me.almacen_destino.Name = "almacen_destino"
        Me.almacen_destino.Width = 123
        '
        'destino
        '
        Me.destino.HeaderText = "DESTINO"
        Me.destino.Name = "destino"
        Me.destino.Width = 80
        '
        'dgvDetOrdenesCompra
        '
        Me.dgvDetOrdenesCompra.AllowUserToAddRows = False
        Me.dgvDetOrdenesCompra.AllowUserToDeleteRows = False
        Me.dgvDetOrdenesCompra.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDetOrdenesCompra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvDetOrdenesCompra.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvDetOrdenesCompra.BackgroundColor = System.Drawing.Color.White
        Me.dgvDetOrdenesCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetOrdenesCompra.Location = New System.Drawing.Point(7, 4)
        Me.dgvDetOrdenesCompra.Name = "dgvDetOrdenesCompra"
        Me.dgvDetOrdenesCompra.Size = New System.Drawing.Size(1160, 202)
        Me.dgvDetOrdenesCompra.TabIndex = 1
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.tslTotalRegistro, Me.ToolStripStatusLabel2, Me.tslPendiente, Me.ToolStripStatusLabel3, Me.tslRecepcionados})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 611)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1180, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(82, 17)
        Me.ToolStripStatusLabel1.Text = "Total Registro:"
        '
        'tslTotalRegistro
        '
        Me.tslTotalRegistro.Name = "tslTotalRegistro"
        Me.tslTotalRegistro.Size = New System.Drawing.Size(13, 17)
        Me.tslTotalRegistro.Text = "0"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(63, 17)
        Me.ToolStripStatusLabel2.Text = "Pendiente:"
        '
        'tslPendiente
        '
        Me.tslPendiente.Name = "tslPendiente"
        Me.tslPendiente.Size = New System.Drawing.Size(13, 17)
        Me.tslPendiente.Text = "0"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(90, 17)
        Me.ToolStripStatusLabel3.Text = "Recepcionados:"
        '
        'tslRecepcionados
        '
        Me.tslRecepcionados.Name = "tslRecepcionados"
        Me.tslRecepcionados.Size = New System.Drawing.Size(13, 17)
        Me.tslRecepcionados.Text = "0"
        '
        'DateTimeGridColumn1
        '
        Me.DateTimeGridColumn1.HeaderText = "Fecha Recepcion Mercaderia"
        Me.DateTimeGridColumn1.Name = "DateTimeGridColumn1"
        Me.DateTimeGridColumn1.Width = 139
        '
        'frmRecepcionMercaderia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1180, 633)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmRecepcionMercaderia"
        Me.Text = "Gestion Recepcion de Mercaderia"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dgvCabOrdenesCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDetOrdenesCompra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents btnBuscar As Button
    Friend WithEvents dtpFecFin As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpFecIni As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvCabOrdenesCompra As DataGridView
    Friend WithEvents dgvDetOrdenesCompra As DataGridView
    Friend WithEvents DateTimeGridColumn1 As DateTimeGridColumn
    Friend WithEvents txtBuscarOC As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents FechaRecepcion As DateTimeGridColumn
    Friend WithEvents numero_oc As DataGridViewTextBoxColumn
    Friend WithEvents razon_social As DataGridViewTextBoxColumn
    Friend WithEvents fecha_doc As DataGridViewTextBoxColumn
    Friend WithEvents tipo As DataGridViewTextBoxColumn
    Friend WithEvents fecha_entrega As DataGridViewTextBoxColumn
    Friend WithEvents lugar_entrega As DataGridViewTextBoxColumn
    Friend WithEvents usuario As DataGridViewTextBoxColumn
    Friend WithEvents almacen_destino As DataGridViewTextBoxColumn
    Friend WithEvents destino As DataGridViewTextBoxColumn
    Friend WithEvents cboAlmacenes As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents tslTotalRegistro As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents tslPendiente As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents tslRecepcionados As ToolStripStatusLabel
End Class
