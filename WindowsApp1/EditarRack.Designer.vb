<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditarRack
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_y = New System.Windows.Forms.TextBox()
        Me.txt_numeracion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_x = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdCancelar = New FontAwesome.Sharp.IconButton()
        Me.cmdAceptar = New FontAwesome.Sharp.IconButton()
        Me.Error1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Error1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.cmdCancelar)
        Me.Panel1.Controls.Add(Me.cmdAceptar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(384, 179)
        Me.Panel1.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_y)
        Me.GroupBox1.Controls.Add(Me.txt_numeracion)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_x)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(360, 123)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Rack"
        '
        'txt_y
        '
        Me.txt_y.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_y.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_y.Location = New System.Drawing.Point(124, 73)
        Me.txt_y.MaxLength = 50
        Me.txt_y.Name = "txt_y"
        Me.txt_y.Size = New System.Drawing.Size(230, 20)
        Me.txt_y.TabIndex = 3
        '
        'txt_numeracion
        '
        Me.txt_numeracion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_numeracion.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_numeracion.Location = New System.Drawing.Point(124, 21)
        Me.txt_numeracion.MaxLength = 50
        Me.txt_numeracion.Name = "txt_numeracion"
        Me.txt_numeracion.Size = New System.Drawing.Size(230, 20)
        Me.txt_numeracion.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 14)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Cantidad Posiciones:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 14)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Cantidad Niveles:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txt_x
        '
        Me.txt_x.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_x.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_x.Location = New System.Drawing.Point(124, 47)
        Me.txt_x.MaxLength = 50
        Me.txt_x.Name = "txt_x"
        Me.txt_x.Size = New System.Drawing.Size(230, 20)
        Me.txt_x.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 14)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Numeracion:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cmdCancelar
        '
        Me.cmdCancelar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Crimson
        Me.cmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCancelar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.ForeColor = System.Drawing.Color.Crimson
        Me.cmdCancelar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle
        Me.cmdCancelar.IconColor = System.Drawing.Color.Crimson
        Me.cmdCancelar.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.cmdCancelar.IconSize = 16
        Me.cmdCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCancelar.Location = New System.Drawing.Point(282, 141)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.cmdCancelar.Size = New System.Drawing.Size(90, 24)
        Me.cmdCancelar.TabIndex = 5
        Me.cmdCancelar.Text = "Cancelar"
        Me.cmdCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdCancelar.UseVisualStyleBackColor = False
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
        Me.cmdAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAceptar.Location = New System.Drawing.Point(186, 141)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.cmdAceptar.Size = New System.Drawing.Size(90, 24)
        Me.cmdAceptar.TabIndex = 4
        Me.cmdAceptar.Text = "Aceptar"
        Me.cmdAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdAceptar.UseVisualStyleBackColor = False
        '
        'Error1
        '
        Me.Error1.ContainerControl = Me
        '
        'EditarRack
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 179)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "EditarRack"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EditarRack"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Error1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_y As TextBox
    Friend WithEvents txt_numeracion As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_x As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmdCancelar As FontAwesome.Sharp.IconButton
    Friend WithEvents cmdAceptar As FontAwesome.Sharp.IconButton
    Friend WithEvents Error1 As ErrorProvider
End Class
