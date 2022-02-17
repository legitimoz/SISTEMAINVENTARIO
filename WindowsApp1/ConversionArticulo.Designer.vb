<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConversionArticulo
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_codanterior = New System.Windows.Forms.Label()
        Me.Descripcion = New System.Windows.Forms.Label()
        Me.txt_Descripcion = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_nuevocodigo = New System.Windows.Forms.TextBox()
        Me.cmb_unidad = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmdAceptar = New FontAwesome.Sharp.IconButton()
        Me.txt_lote = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txt_cantidad = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo Actual :"
        '
        'txt_codanterior
        '
        Me.txt_codanterior.AutoSize = True
        Me.txt_codanterior.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_codanterior.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txt_codanterior.Location = New System.Drawing.Point(98, 18)
        Me.txt_codanterior.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txt_codanterior.MaximumSize = New System.Drawing.Size(210, 22)
        Me.txt_codanterior.MinimumSize = New System.Drawing.Size(210, 22)
        Me.txt_codanterior.Name = "txt_codanterior"
        Me.txt_codanterior.Size = New System.Drawing.Size(210, 22)
        Me.txt_codanterior.TabIndex = 97
        Me.txt_codanterior.Text = "-"
        '
        'Descripcion
        '
        Me.Descripcion.AutoSize = True
        Me.Descripcion.Location = New System.Drawing.Point(22, 50)
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.Size = New System.Drawing.Size(69, 13)
        Me.Descripcion.TabIndex = 98
        Me.Descripcion.Text = "Descripcion :"
        '
        'txt_Descripcion
        '
        Me.txt_Descripcion.AutoSize = True
        Me.txt_Descripcion.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Descripcion.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txt_Descripcion.Location = New System.Drawing.Point(97, 50)
        Me.txt_Descripcion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txt_Descripcion.MaximumSize = New System.Drawing.Size(210, 22)
        Me.txt_Descripcion.MinimumSize = New System.Drawing.Size(210, 22)
        Me.txt_Descripcion.Name = "txt_Descripcion"
        Me.txt_Descripcion.Size = New System.Drawing.Size(210, 22)
        Me.txt_Descripcion.TabIndex = 99
        Me.txt_Descripcion.Text = "-"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 100
        Me.Label4.Text = "Nuevo Codigo :"
        '
        'txt_nuevocodigo
        '
        Me.txt_nuevocodigo.Location = New System.Drawing.Point(100, 159)
        Me.txt_nuevocodigo.Name = "txt_nuevocodigo"
        Me.txt_nuevocodigo.Size = New System.Drawing.Size(207, 20)
        Me.txt_nuevocodigo.TabIndex = 101
        '
        'cmb_unidad
        '
        Me.cmb_unidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_unidad.FormattingEnabled = True
        Me.cmb_unidad.Items.AddRange(New Object() {"UND", "CJA"})
        Me.cmb_unidad.Location = New System.Drawing.Point(100, 132)
        Me.cmb_unidad.Name = "cmb_unidad"
        Me.cmb_unidad.Size = New System.Drawing.Size(207, 21)
        Me.cmb_unidad.TabIndex = 102
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(43, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 103
        Me.Label5.Text = "Unidad :"
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
        Me.cmdAceptar.Location = New System.Drawing.Point(216, 198)
        Me.cmdAceptar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.cmdAceptar.Size = New System.Drawing.Size(92, 29)
        Me.cmdAceptar.TabIndex = 104
        Me.cmdAceptar.Text = "Aceptar"
        Me.cmdAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdAceptar.UseVisualStyleBackColor = False
        '
        'txt_lote
        '
        Me.txt_lote.AutoSize = True
        Me.txt_lote.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_lote.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txt_lote.Location = New System.Drawing.Point(97, 81)
        Me.txt_lote.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txt_lote.MaximumSize = New System.Drawing.Size(210, 22)
        Me.txt_lote.MinimumSize = New System.Drawing.Size(210, 22)
        Me.txt_lote.Name = "txt_lote"
        Me.txt_lote.Size = New System.Drawing.Size(210, 22)
        Me.txt_lote.TabIndex = 106
        Me.txt_lote.Text = "-"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(54, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 105
        Me.Label6.Text = "Lote :"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'txt_cantidad
        '
        Me.txt_cantidad.Location = New System.Drawing.Point(100, 106)
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.Size = New System.Drawing.Size(207, 20)
        Me.txt_cantidad.TabIndex = 108
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 107
        Me.Label2.Text = "Cantidad :"
        '
        'ConversionArticulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(347, 242)
        Me.Controls.Add(Me.txt_cantidad)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_lote)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmb_unidad)
        Me.Controls.Add(Me.txt_nuevocodigo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_Descripcion)
        Me.Controls.Add(Me.Descripcion)
        Me.Controls.Add(Me.txt_codanterior)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "ConversionArticulo"
        Me.Text = "Conversion de Codigo Articulo"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_codanterior As Label
    Friend WithEvents Descripcion As Label
    Friend WithEvents txt_Descripcion As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_nuevocodigo As TextBox
    Friend WithEvents cmb_unidad As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmdAceptar As FontAwesome.Sharp.IconButton
    Friend WithEvents txt_lote As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents txt_cantidad As TextBox
    Friend WithEvents Label2 As Label
End Class
