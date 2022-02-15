<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TrasladoEntreUbicaciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TrasladoEntreUbicaciones))
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_codigo = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_rack = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_lote = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_codarti = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_operacion = New System.Windows.Forms.TextBox()
        Me.Dg_Operaciones = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmb_posiciones = New System.Windows.Forms.ComboBox()
        Me.cmb_Rack = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.cmdAceptar = New FontAwesome.Sharp.IconButton()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Dg_Operaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(246, 218)
        Me.Label8.Margin = New System.Windows.Forms.Padding(10, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(10, 14)
        Me.Label8.TabIndex = 99
        Me.Label8.Text = ":"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txt_codigo
        '
        Me.txt_codigo.AutoSize = True
        Me.txt_codigo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_codigo.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txt_codigo.Location = New System.Drawing.Point(85, 47)
        Me.txt_codigo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txt_codigo.MaximumSize = New System.Drawing.Size(210, 19)
        Me.txt_codigo.MinimumSize = New System.Drawing.Size(210, 19)
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.Size = New System.Drawing.Size(210, 19)
        Me.txt_codigo.TabIndex = 85
        Me.txt_codigo.Text = "-"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(13, 48)
        Me.Label5.Margin = New System.Windows.Forms.Padding(10, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 14)
        Me.Label5.TabIndex = 84
        Me.Label5.Text = "UBICACION"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txt_rack
        '
        Me.txt_rack.AutoSize = True
        Me.txt_rack.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_rack.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txt_rack.Location = New System.Drawing.Point(85, 24)
        Me.txt_rack.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txt_rack.MaximumSize = New System.Drawing.Size(210, 19)
        Me.txt_rack.MinimumSize = New System.Drawing.Size(210, 19)
        Me.txt_rack.Name = "txt_rack"
        Me.txt_rack.Size = New System.Drawing.Size(210, 19)
        Me.txt_rack.TabIndex = 96
        Me.txt_rack.Text = "-"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(13, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(10, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 14)
        Me.Label1.TabIndex = 95
        Me.Label1.Text = "RACK"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txt_lote)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txt_codarti)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_operacion)
        Me.GroupBox1.Controls.Add(Me.Dg_Operaciones)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_rack)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_codigo)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(15, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(595, 287)
        Me.GroupBox1.TabIndex = 100
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "UBICACION DE ORIGEN"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(429, 81)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 103
        Me.Label7.Text = "Lote :"
        '
        'txt_lote
        '
        Me.txt_lote.Location = New System.Drawing.Point(471, 78)
        Me.txt_lote.Name = "txt_lote"
        Me.txt_lote.Size = New System.Drawing.Size(93, 21)
        Me.txt_lote.TabIndex = 102
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(192, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 13)
        Me.Label6.TabIndex = 101
        Me.Label6.Text = "Cod Articulo :"
        '
        'txt_codarti
        '
        Me.txt_codarti.Location = New System.Drawing.Point(279, 78)
        Me.txt_codarti.Name = "txt_codarti"
        Me.txt_codarti.Size = New System.Drawing.Size(86, 21)
        Me.txt_codarti.TabIndex = 100
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 99
        Me.Label3.Text = "Op :"
        '
        'txt_operacion
        '
        Me.txt_operacion.Location = New System.Drawing.Point(37, 78)
        Me.txt_operacion.Name = "txt_operacion"
        Me.txt_operacion.Size = New System.Drawing.Size(86, 21)
        Me.txt_operacion.TabIndex = 98
        '
        'Dg_Operaciones
        '
        Me.Dg_Operaciones.AllowUserToAddRows = False
        Me.Dg_Operaciones.AllowUserToDeleteRows = False
        Me.Dg_Operaciones.BackgroundColor = System.Drawing.Color.White
        Me.Dg_Operaciones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Dg_Operaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dg_Operaciones.Location = New System.Drawing.Point(6, 103)
        Me.Dg_Operaciones.Name = "Dg_Operaciones"
        Me.Dg_Operaciones.Size = New System.Drawing.Size(559, 169)
        Me.Dg_Operaciones.TabIndex = 97
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmb_posiciones)
        Me.GroupBox2.Controls.Add(Me.cmb_Rack)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(15, 308)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(571, 92)
        Me.GroupBox2.TabIndex = 101
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "UBICACION DE DESTINO"
        '
        'cmb_posiciones
        '
        Me.cmb_posiciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_posiciones.FormattingEnabled = True
        Me.cmb_posiciones.Location = New System.Drawing.Point(104, 60)
        Me.cmb_posiciones.Name = "cmb_posiciones"
        Me.cmb_posiciones.Size = New System.Drawing.Size(111, 21)
        Me.cmb_posiciones.TabIndex = 97
        '
        'cmb_Rack
        '
        Me.cmb_Rack.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Rack.FormattingEnabled = True
        Me.cmb_Rack.Location = New System.Drawing.Point(104, 29)
        Me.cmb_Rack.Name = "cmb_Rack"
        Me.cmb_Rack.Size = New System.Drawing.Size(111, 21)
        Me.cmb_Rack.TabIndex = 96
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(13, 32)
        Me.Label2.Margin = New System.Windows.Forms.Padding(10, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 14)
        Me.Label2.TabIndex = 95
        Me.Label2.Text = "Rack"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(13, 63)
        Me.Label4.Margin = New System.Windows.Forms.Padding(10, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 14)
        Me.Label4.TabIndex = 84
        Me.Label4.Text = "Ubicacion"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'cmdAceptar
        '
        Me.cmdAceptar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdAceptar.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen
        Me.cmdAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAceptar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.ForeColor = System.Drawing.Color.ForestGreen
        Me.cmdAceptar.IconChar = FontAwesome.Sharp.IconChar.CheckCircle
        Me.cmdAceptar.IconColor = System.Drawing.Color.ForestGreen
        Me.cmdAceptar.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.cmdAceptar.IconSize = 16
        Me.cmdAceptar.Location = New System.Drawing.Point(482, 407)
        Me.cmdAceptar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.cmdAceptar.Size = New System.Drawing.Size(103, 29)
        Me.cmdAceptar.TabIndex = 102
        Me.cmdAceptar.Text = "Aceptar"
        Me.cmdAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdAceptar.UseVisualStyleBackColor = False
        '
        'TrasladoEntreUbicaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(622, 449)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label8)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "TrasladoEntreUbicaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Traslado Ubicaciones"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Dg_Operaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_codigo As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_rack As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Dg_Operaciones As DataGridView
    Friend WithEvents cmdAceptar As FontAwesome.Sharp.IconButton
    Friend WithEvents cmb_posiciones As ComboBox
    Friend WithEvents cmb_Rack As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_lote As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_codarti As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_operacion As TextBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
