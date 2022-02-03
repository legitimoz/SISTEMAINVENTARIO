<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVendedores
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
        Me.dgvVendedores = New System.Windows.Forms.DataGridView()
        Me.txtBusqVend = New System.Windows.Forms.TextBox()
        CType(Me.dgvVendedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvVendedores
        '
        Me.dgvVendedores.AllowUserToAddRows = False
        Me.dgvVendedores.BackgroundColor = System.Drawing.Color.White
        Me.dgvVendedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvVendedores.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvVendedores.Location = New System.Drawing.Point(3, 37)
        Me.dgvVendedores.MultiSelect = False
        Me.dgvVendedores.Name = "dgvVendedores"
        Me.dgvVendedores.ReadOnly = True
        Me.dgvVendedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvVendedores.Size = New System.Drawing.Size(265, 309)
        Me.dgvVendedores.TabIndex = 0
        '
        'txtBusqVend
        '
        Me.txtBusqVend.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBusqVend.Location = New System.Drawing.Point(3, 11)
        Me.txtBusqVend.Name = "txtBusqVend"
        Me.txtBusqVend.Size = New System.Drawing.Size(265, 20)
        Me.txtBusqVend.TabIndex = 1
        '
        'frmVendedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(273, 349)
        Me.Controls.Add(Me.txtBusqVend)
        Me.Controls.Add(Me.dgvVendedores)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmVendedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vendedores"
        CType(Me.dgvVendedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvVendedores As DataGridView
    Friend WithEvents txtBusqVend As TextBox
End Class
