<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ObservacionPosicionForm
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
        Me.txt_site = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_almacen = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_rack = New System.Windows.Forms.Label()
        Me.Rack = New System.Windows.Forms.Label()
        Me.txt_posicion = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_Conceptos = New System.Windows.Forms.ComboBox()
        Me.cmdAceptar = New FontAwesome.Sharp.IconButton()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_site
        '
        Me.txt_site.AutoSize = True
        Me.txt_site.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_site.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txt_site.Location = New System.Drawing.Point(102, 29)
        Me.txt_site.MaximumSize = New System.Drawing.Size(260, 18)
        Me.txt_site.MinimumSize = New System.Drawing.Size(260, 18)
        Me.txt_site.Name = "txt_site"
        Me.txt_site.Size = New System.Drawing.Size(260, 18)
        Me.txt_site.TabIndex = 89
        Me.txt_site.Text = "-"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 29)
        Me.Label5.Margin = New System.Windows.Forms.Padding(9, 0, 3, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 14)
        Me.Label5.TabIndex = 88
        Me.Label5.Text = "SITE :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txt_almacen
        '
        Me.txt_almacen.AutoSize = True
        Me.txt_almacen.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_almacen.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txt_almacen.Location = New System.Drawing.Point(102, 59)
        Me.txt_almacen.MaximumSize = New System.Drawing.Size(260, 18)
        Me.txt_almacen.MinimumSize = New System.Drawing.Size(260, 18)
        Me.txt_almacen.Name = "txt_almacen"
        Me.txt_almacen.Size = New System.Drawing.Size(260, 18)
        Me.txt_almacen.TabIndex = 91
        Me.txt_almacen.Text = "-"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 59)
        Me.Label2.Margin = New System.Windows.Forms.Padding(9, 0, 3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 14)
        Me.Label2.TabIndex = 90
        Me.Label2.Text = "ALMACEN :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txt_rack
        '
        Me.txt_rack.AutoSize = True
        Me.txt_rack.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_rack.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txt_rack.Location = New System.Drawing.Point(102, 91)
        Me.txt_rack.MaximumSize = New System.Drawing.Size(260, 18)
        Me.txt_rack.MinimumSize = New System.Drawing.Size(260, 18)
        Me.txt_rack.Name = "txt_rack"
        Me.txt_rack.Size = New System.Drawing.Size(260, 18)
        Me.txt_rack.TabIndex = 93
        Me.txt_rack.Text = "-"
        '
        'Rack
        '
        Me.Rack.AutoSize = True
        Me.Rack.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rack.Location = New System.Drawing.Point(7, 91)
        Me.Rack.Margin = New System.Windows.Forms.Padding(9, 0, 3, 0)
        Me.Rack.Name = "Rack"
        Me.Rack.Size = New System.Drawing.Size(43, 14)
        Me.Rack.TabIndex = 92
        Me.Rack.Text = "RACK :"
        Me.Rack.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txt_posicion
        '
        Me.txt_posicion.AutoSize = True
        Me.txt_posicion.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_posicion.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txt_posicion.Location = New System.Drawing.Point(102, 123)
        Me.txt_posicion.MaximumSize = New System.Drawing.Size(260, 18)
        Me.txt_posicion.MinimumSize = New System.Drawing.Size(260, 18)
        Me.txt_posicion.Name = "txt_posicion"
        Me.txt_posicion.Size = New System.Drawing.Size(260, 18)
        Me.txt_posicion.TabIndex = 95
        Me.txt_posicion.Text = "-"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 123)
        Me.Label4.Margin = New System.Windows.Forms.Padding(9, 0, 3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 14)
        Me.Label4.TabIndex = 94
        Me.Label4.Text = "POSICION :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 157)
        Me.Label1.Margin = New System.Windows.Forms.Padding(9, 0, 3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 14)
        Me.Label1.TabIndex = 96
        Me.Label1.Text = "CONCEPTO :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cmb_Conceptos
        '
        Me.cmb_Conceptos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Conceptos.FormattingEnabled = True
        Me.cmb_Conceptos.Location = New System.Drawing.Point(105, 151)
        Me.cmb_Conceptos.Name = "cmb_Conceptos"
        Me.cmb_Conceptos.Size = New System.Drawing.Size(257, 21)
        Me.cmb_Conceptos.TabIndex = 97
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
        Me.cmdAceptar.Location = New System.Drawing.Point(272, 218)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.cmdAceptar.Size = New System.Drawing.Size(90, 24)
        Me.cmdAceptar.TabIndex = 98
        Me.cmdAceptar.Text = "Aceptar"
        Me.cmdAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdAceptar.UseVisualStyleBackColor = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ObservacionPosicionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 254)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.cmb_Conceptos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_posicion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_rack)
        Me.Controls.Add(Me.Rack)
        Me.Controls.Add(Me.txt_almacen)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_site)
        Me.Controls.Add(Me.Label5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "ObservacionPosicionForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ObservacionPosicionForm"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_site As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_almacen As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_rack As Label
    Friend WithEvents Rack As Label
    Friend WithEvents txt_posicion As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmb_Conceptos As ComboBox
    Friend WithEvents cmdAceptar As FontAwesome.Sharp.IconButton
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
