<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteMovimientosAlmacen
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dt_desde = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmdAceptar = New FontAwesome.Sharp.IconButton()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.dt_hasta = New System.Windows.Forms.DateTimePicker()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(29, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 14)
        Me.Label8.TabIndex = 68
        Me.Label8.Text = "Desde:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'dt_desde
        '
        Me.dt_desde.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt_desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_desde.Location = New System.Drawing.Point(106, 12)
        Me.dt_desde.Name = "dt_desde"
        Me.dt_desde.Size = New System.Drawing.Size(209, 20)
        Me.dt_desde.TabIndex = 66
        Me.dt_desde.Value = New Date(2019, 12, 25, 0, 0, 0, 0)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(29, 46)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 14)
        Me.Label9.TabIndex = 69
        Me.Label9.Text = "Hasta:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
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
        Me.cmdAceptar.Location = New System.Drawing.Point(218, 95)
        Me.cmdAceptar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.cmdAceptar.Size = New System.Drawing.Size(97, 26)
        Me.cmdAceptar.TabIndex = 70
        Me.cmdAceptar.Text = "Aceptar"
        Me.cmdAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdAceptar.UseVisualStyleBackColor = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'dt_hasta
        '
        Me.dt_hasta.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt_hasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_hasta.Location = New System.Drawing.Point(106, 40)
        Me.dt_hasta.Name = "dt_hasta"
        Me.dt_hasta.Size = New System.Drawing.Size(209, 20)
        Me.dt_hasta.TabIndex = 71
        Me.dt_hasta.Value = New Date(2022, 1, 1, 0, 0, 0, 0)
        '
        'ReporteMovimientosAlmacen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(341, 134)
        Me.Controls.Add(Me.dt_hasta)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dt_desde)
        Me.Controls.Add(Me.Label9)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "ReporteMovimientosAlmacen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ReporteMovimientosAlmacen"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents dt_desde As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents cmdAceptar As FontAwesome.Sharp.IconButton
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents dt_hasta As DateTimePicker
End Class
