<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ComplemetarRuta
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_repartidor = New System.Windows.Forms.ComboBox()
        Me.cmb_tipotransporte = New System.Windows.Forms.ComboBox()
        Me.cmdAceptar = New FontAwesome.Sharp.IconButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "REPARTIDOR : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "TIPO VEHÍCULO : "
        '
        'cmb_repartidor
        '
        Me.cmb_repartidor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_repartidor.DropDownWidth = 250
        Me.cmb_repartidor.FormattingEnabled = True
        Me.cmb_repartidor.Location = New System.Drawing.Point(119, 22)
        Me.cmb_repartidor.Name = "cmb_repartidor"
        Me.cmb_repartidor.Size = New System.Drawing.Size(210, 21)
        Me.cmb_repartidor.TabIndex = 2
        '
        'cmb_tipotransporte
        '
        Me.cmb_tipotransporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tipotransporte.DropDownWidth = 250
        Me.cmb_tipotransporte.FormattingEnabled = True
        Me.cmb_tipotransporte.Location = New System.Drawing.Point(119, 56)
        Me.cmb_tipotransporte.Name = "cmb_tipotransporte"
        Me.cmb_tipotransporte.Size = New System.Drawing.Size(210, 21)
        Me.cmb_tipotransporte.TabIndex = 3
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
        Me.cmdAceptar.Location = New System.Drawing.Point(244, 109)
        Me.cmdAceptar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.cmdAceptar.Size = New System.Drawing.Size(84, 29)
        Me.cmdAceptar.TabIndex = 131
        Me.cmdAceptar.Text = "Aceptar"
        Me.cmdAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdAceptar.UseVisualStyleBackColor = False
        '
        'ComplemetarRuta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(341, 151)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.cmb_tipotransporte)
        Me.Controls.Add(Me.cmb_repartidor)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "ComplemetarRuta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ComplemetarRuta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmb_repartidor As ComboBox
    Friend WithEvents cmb_tipotransporte As ComboBox
    Friend WithEvents cmdAceptar As FontAwesome.Sharp.IconButton
End Class
