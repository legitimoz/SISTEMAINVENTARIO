<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetalleProductosXLinea
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DetalleProductosXLinea))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.savedialog_Excel = New System.Windows.Forms.SaveFileDialog()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdGenerarExcel = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdCerrar = New System.Windows.Forms.ToolStripButton()
        Me.Dg_Detalle = New System.Windows.Forms.DataGridView()
        Me.CODIGO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ARTICULO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LOTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CANTIDAD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CANT_MESES = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbl_Cabecera = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.Dg_Detalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Dg_Detalle)
        Me.Panel1.Location = New System.Drawing.Point(0, 88)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(954, 264)
        Me.Panel1.TabIndex = 87
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Codigo Articulo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 92
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Descr. Articulo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 101
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Lote Articulo"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 91
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 74
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Cant. Meses para vencer"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 136
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lbl_Cabecera)
        Me.Panel2.Controls.Add(Me.ToolStrip1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(954, 82)
        Me.Panel2.TabIndex = 88
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStrip1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.cmdGenerarExcel, Me.ToolStripSeparator3, Me.cmdCerrar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(954, 40)
        Me.ToolStrip1.TabIndex = 90
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 40)
        '
        'cmdGenerarExcel
        '
        Me.cmdGenerarExcel.Image = CType(resources.GetObject("cmdGenerarExcel.Image"), System.Drawing.Image)
        Me.cmdGenerarExcel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdGenerarExcel.Margin = New System.Windows.Forms.Padding(1)
        Me.cmdGenerarExcel.Name = "cmdGenerarExcel"
        Me.cmdGenerarExcel.Size = New System.Drawing.Size(81, 38)
        Me.cmdGenerarExcel.Text = "&Exportar Excel"
        Me.cmdGenerarExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 40)
        '
        'cmdCerrar
        '
        Me.cmdCerrar.Image = CType(resources.GetObject("cmdCerrar.Image"), System.Drawing.Image)
        Me.cmdCerrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdCerrar.Margin = New System.Windows.Forms.Padding(1)
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.Size = New System.Drawing.Size(32, 38)
        Me.cmdCerrar.Text = "&Salir"
        Me.cmdCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Dg_Detalle
        '
        Me.Dg_Detalle.AllowUserToAddRows = False
        Me.Dg_Detalle.AllowUserToDeleteRows = False
        Me.Dg_Detalle.AllowUserToResizeRows = False
        Me.Dg_Detalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Dg_Detalle.BackgroundColor = System.Drawing.Color.White
        Me.Dg_Detalle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Dg_Detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dg_Detalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CODIGO, Me.ARTICULO, Me.LOTE, Me.CANTIDAD, Me.CANT_MESES})
        Me.Dg_Detalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dg_Detalle.Location = New System.Drawing.Point(0, 0)
        Me.Dg_Detalle.MultiSelect = False
        Me.Dg_Detalle.Name = "Dg_Detalle"
        Me.Dg_Detalle.RowHeadersVisible = False
        Me.Dg_Detalle.RowTemplate.Height = 24
        Me.Dg_Detalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dg_Detalle.Size = New System.Drawing.Size(954, 264)
        Me.Dg_Detalle.TabIndex = 28
        '
        'CODIGO
        '
        Me.CODIGO.HeaderText = "Cord Articulo"
        Me.CODIGO.Name = "CODIGO"
        Me.CODIGO.Width = 85
        '
        'ARTICULO
        '
        Me.ARTICULO.HeaderText = "Descr. Articulo"
        Me.ARTICULO.Name = "ARTICULO"
        Me.ARTICULO.Width = 93
        '
        'LOTE
        '
        Me.LOTE.HeaderText = "Lote Articulo"
        Me.LOTE.Name = "LOTE"
        Me.LOTE.Width = 84
        '
        'CANTIDAD
        '
        Me.CANTIDAD.HeaderText = "Cantidad"
        Me.CANTIDAD.Name = "CANTIDAD"
        Me.CANTIDAD.Width = 74
        '
        'CANT_MESES
        '
        Me.CANT_MESES.HeaderText = "Meses Para Vencimiento"
        Me.CANT_MESES.Name = "CANT_MESES"
        Me.CANT_MESES.Width = 136
        '
        'lbl_Cabecera
        '
        Me.lbl_Cabecera.AutoSize = True
        Me.lbl_Cabecera.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Cabecera.ForeColor = System.Drawing.Color.Blue
        Me.lbl_Cabecera.Location = New System.Drawing.Point(13, 44)
        Me.lbl_Cabecera.Name = "lbl_Cabecera"
        Me.lbl_Cabecera.Size = New System.Drawing.Size(433, 28)
        Me.lbl_Cabecera.TabIndex = 91
        Me.lbl_Cabecera.Text = "PRODUCTOS PROXIMOS A VENCER _ "
        '
        'DetalleProductosXLinea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(954, 354)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.Name = "DetalleProductosXLinea"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalle Productos Por Linea"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.Dg_Detalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents savedialog_Excel As SaveFileDialog
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents cmdGenerarExcel As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents cmdCerrar As ToolStripButton
    Friend WithEvents lbl_Cabecera As Label
    Friend WithEvents Dg_Detalle As DataGridView
    Friend WithEvents CODIGO As DataGridViewTextBoxColumn
    Friend WithEvents ARTICULO As DataGridViewTextBoxColumn
    Friend WithEvents LOTE As DataGridViewTextBoxColumn
    Friend WithEvents CANTIDAD As DataGridViewTextBoxColumn
    Friend WithEvents CANT_MESES As DataGridViewTextBoxColumn
End Class
