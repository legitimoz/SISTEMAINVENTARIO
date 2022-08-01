<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionArticulosSoftcom
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GestionArticulosSoftcom))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.cmdGenerarExcel = New System.Windows.Forms.ToolStripButton()
        Me.separador5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdCerrar = New System.Windows.Forms.ToolStripButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txt_codigo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Dg_Articulos = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.Dg_Articulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStrip1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdGenerarExcel, Me.separador5, Me.ToolStripButton2, Me.ToolStripSeparator2, Me.cmdCerrar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(1168, 42)
        Me.ToolStrip1.TabIndex = 51
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'cmdGenerarExcel
        '
        Me.cmdGenerarExcel.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGenerarExcel.Image = CType(resources.GetObject("cmdGenerarExcel.Image"), System.Drawing.Image)
        Me.cmdGenerarExcel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdGenerarExcel.Margin = New System.Windows.Forms.Padding(1)
        Me.cmdGenerarExcel.Name = "cmdGenerarExcel"
        Me.cmdGenerarExcel.Size = New System.Drawing.Size(88, 40)
        Me.cmdGenerarExcel.Text = "&Exportar Excel"
        Me.cmdGenerarExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'separador5
        '
        Me.separador5.Name = "separador5"
        Me.separador5.Size = New System.Drawing.Size(6, 42)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Margin = New System.Windows.Forms.Padding(1)
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(103, 40)
        Me.ToolStripButton2.Text = "&Validar Cubicaje"
        Me.ToolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 42)
        '
        'cmdCerrar
        '
        Me.cmdCerrar.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCerrar.Image = CType(resources.GetObject("cmdCerrar.Image"), System.Drawing.Image)
        Me.cmdCerrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdCerrar.Margin = New System.Windows.Forms.Padding(1)
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.Size = New System.Drawing.Size(33, 40)
        Me.cmdCerrar.Text = "&Salir"
        Me.cmdCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.txt_nombre)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.txt_codigo)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 42)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1168, 57)
        Me.Panel3.TabIndex = 52
        '
        'txt_codigo
        '
        Me.txt_codigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_codigo.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_codigo.Location = New System.Drawing.Point(77, 15)
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.Size = New System.Drawing.Size(182, 21)
        Me.txt_codigo.TabIndex = 89
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(11, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 16)
        Me.Label6.TabIndex = 88
        Me.Label6.Text = "Codigo :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txt_nombre
        '
        Me.txt_nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_nombre.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nombre.Location = New System.Drawing.Point(360, 15)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(182, 21)
        Me.txt_nombre.TabIndex = 91
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(294, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 16)
        Me.Label1.TabIndex = 90
        Me.Label1.Text = "Nombre :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Dg_Articulos
        '
        Me.Dg_Articulos.AllowUserToAddRows = False
        Me.Dg_Articulos.AllowUserToDeleteRows = False
        Me.Dg_Articulos.AllowUserToResizeRows = False
        Me.Dg_Articulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Dg_Articulos.BackgroundColor = System.Drawing.Color.White
        Me.Dg_Articulos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Dg_Articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dg_Articulos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dg_Articulos.Location = New System.Drawing.Point(0, 99)
        Me.Dg_Articulos.Margin = New System.Windows.Forms.Padding(0)
        Me.Dg_Articulos.MultiSelect = False
        Me.Dg_Articulos.Name = "Dg_Articulos"
        Me.Dg_Articulos.RowHeadersVisible = False
        Me.Dg_Articulos.RowHeadersWidth = 20
        Me.Dg_Articulos.RowTemplate.Height = 20
        Me.Dg_Articulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dg_Articulos.Size = New System.Drawing.Size(1168, 392)
        Me.Dg_Articulos.TabIndex = 53
        '
        'GestionArticulosSoftcom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1168, 491)
        Me.Controls.Add(Me.Dg_Articulos)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "GestionArticulosSoftcom"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GestionArticulosSoftcom"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.Dg_Articulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents cmdGenerarExcel As ToolStripButton
    Friend WithEvents separador5 As ToolStripSeparator
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents cmdCerrar As ToolStripButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txt_codigo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Dg_Articulos As DataGridView
End Class
