<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditarSalidaAlmacen
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_cantidadsolicitada = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_codigo = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_lote = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Dg_DatosPosiciones = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_cantidad = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmdAceptar = New FontAwesome.Sharp.IconButton()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Dg_DatosPosiciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_cantidadsolicitada)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_codigo)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_lote)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(481, 146)
        Me.GroupBox1.TabIndex = 98
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATOS DE SALIDA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(165, 109)
        Me.Label1.Margin = New System.Windows.Forms.Padding(10, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(10, 14)
        Me.Label1.TabIndex = 97
        Me.Label1.Text = ":"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(31, 109)
        Me.Label2.Margin = New System.Windows.Forms.Padding(10, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 14)
        Me.Label2.TabIndex = 95
        Me.Label2.Text = "CANTIDAD SOLICITADA"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txt_cantidadsolicitada
        '
        Me.txt_cantidadsolicitada.AutoSize = True
        Me.txt_cantidadsolicitada.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cantidadsolicitada.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txt_cantidadsolicitada.Location = New System.Drawing.Point(215, 109)
        Me.txt_cantidadsolicitada.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txt_cantidadsolicitada.MaximumSize = New System.Drawing.Size(210, 22)
        Me.txt_cantidadsolicitada.MinimumSize = New System.Drawing.Size(210, 22)
        Me.txt_cantidadsolicitada.Name = "txt_cantidadsolicitada"
        Me.txt_cantidadsolicitada.Size = New System.Drawing.Size(210, 22)
        Me.txt_cantidadsolicitada.TabIndex = 96
        Me.txt_cantidadsolicitada.Text = "-"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(31, 29)
        Me.Label5.Margin = New System.Windows.Forms.Padding(10, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 14)
        Me.Label5.TabIndex = 84
        Me.Label5.Text = "ARTICULO"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txt_codigo
        '
        Me.txt_codigo.AutoSize = True
        Me.txt_codigo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_codigo.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txt_codigo.Location = New System.Drawing.Point(215, 28)
        Me.txt_codigo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txt_codigo.MaximumSize = New System.Drawing.Size(210, 22)
        Me.txt_codigo.MinimumSize = New System.Drawing.Size(210, 22)
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.Size = New System.Drawing.Size(210, 22)
        Me.txt_codigo.TabIndex = 85
        Me.txt_codigo.Text = "-"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(165, 29)
        Me.Label7.Margin = New System.Windows.Forms.Padding(10, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(10, 14)
        Me.Label7.TabIndex = 94
        Me.Label7.Text = ":"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(165, 67)
        Me.Label6.Margin = New System.Windows.Forms.Padding(10, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(10, 14)
        Me.Label6.TabIndex = 93
        Me.Label6.Text = ":"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(31, 67)
        Me.Label3.Margin = New System.Windows.Forms.Padding(10, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 14)
        Me.Label3.TabIndex = 89
        Me.Label3.Text = "LOTE"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txt_lote
        '
        Me.txt_lote.AutoSize = True
        Me.txt_lote.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_lote.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txt_lote.Location = New System.Drawing.Point(215, 67)
        Me.txt_lote.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txt_lote.MaximumSize = New System.Drawing.Size(210, 22)
        Me.txt_lote.MinimumSize = New System.Drawing.Size(210, 22)
        Me.txt_lote.Name = "txt_lote"
        Me.txt_lote.Size = New System.Drawing.Size(210, 22)
        Me.txt_lote.TabIndex = 90
        Me.txt_lote.Text = "-"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Dg_DatosPosiciones)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 183)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(481, 192)
        Me.GroupBox2.TabIndex = 123
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DATOS DE POSICIONES"
        '
        'Dg_DatosPosiciones
        '
        Me.Dg_DatosPosiciones.AllowUserToAddRows = False
        Me.Dg_DatosPosiciones.AllowUserToDeleteRows = False
        Me.Dg_DatosPosiciones.AllowUserToResizeColumns = False
        Me.Dg_DatosPosiciones.AllowUserToResizeRows = False
        Me.Dg_DatosPosiciones.BackgroundColor = System.Drawing.Color.White
        Me.Dg_DatosPosiciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dg_DatosPosiciones.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.Dg_DatosPosiciones.ColumnHeadersHeight = 50
        Me.Dg_DatosPosiciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Dg_DatosPosiciones.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.Dg_DatosPosiciones.EnableHeadersVisualStyles = False
        Me.Dg_DatosPosiciones.Location = New System.Drawing.Point(30, 31)
        Me.Dg_DatosPosiciones.Margin = New System.Windows.Forms.Padding(4)
        Me.Dg_DatosPosiciones.MultiSelect = False
        Me.Dg_DatosPosiciones.Name = "Dg_DatosPosiciones"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dg_DatosPosiciones.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.Dg_DatosPosiciones.RowHeadersVisible = False
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Dg_DatosPosiciones.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.Dg_DatosPosiciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dg_DatosPosiciones.Size = New System.Drawing.Size(425, 136)
        Me.Dg_DatosPosiciones.TabIndex = 127
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(208, 386)
        Me.Label9.Margin = New System.Windows.Forms.Padding(10, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(10, 14)
        Me.Label9.TabIndex = 126
        Me.Label9.Text = ":"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txt_cantidad
        '
        Me.txt_cantidad.Location = New System.Drawing.Point(261, 382)
        Me.txt_cantidad.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.Size = New System.Drawing.Size(206, 20)
        Me.txt_cantidad.TabIndex = 122
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(39, 386)
        Me.Label8.Margin = New System.Windows.Forms.Padding(10, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 14)
        Me.Label8.TabIndex = 123
        Me.Label8.Text = "Cantidad salida"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
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
        Me.cmdAceptar.Location = New System.Drawing.Point(401, 419)
        Me.cmdAceptar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.cmdAceptar.Size = New System.Drawing.Size(92, 29)
        Me.cmdAceptar.TabIndex = 127
        Me.cmdAceptar.Text = "Aceptar"
        Me.cmdAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdAceptar.UseVisualStyleBackColor = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'EditarSalidaAlmacen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(506, 455)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txt_cantidad)
        Me.Controls.Add(Me.Label8)
        Me.MaximizeBox = False
        Me.Name = "EditarSalidaAlmacen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EditarSalidaAlmacen"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.Dg_DatosPosiciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_codigo As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_lote As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_cantidadsolicitada As Label
    Friend WithEvents GroupBox2 As GroupBox
    Public WithEvents Dg_DatosPosiciones As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_cantidad As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cmdAceptar As FontAwesome.Sharp.IconButton
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
