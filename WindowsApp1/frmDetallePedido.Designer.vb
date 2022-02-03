<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetallePedido
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvListarDetalleProductos = New System.Windows.Forms.DataGridView()
        CType(Me.dgvListarDetalleProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvListarDetalleProductos
        '
        Me.dgvListarDetalleProductos.AllowUserToAddRows = False
        Me.dgvListarDetalleProductos.AllowUserToDeleteRows = False
        Me.dgvListarDetalleProductos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvListarDetalleProductos.BackgroundColor = System.Drawing.Color.White
        Me.dgvListarDetalleProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvListarDetalleProductos.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvListarDetalleProductos.Location = New System.Drawing.Point(4, 4)
        Me.dgvListarDetalleProductos.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvListarDetalleProductos.MultiSelect = False
        Me.dgvListarDetalleProductos.Name = "dgvListarDetalleProductos"
        Me.dgvListarDetalleProductos.ReadOnly = True
        Me.dgvListarDetalleProductos.RowTemplate.Height = 24
        Me.dgvListarDetalleProductos.Size = New System.Drawing.Size(662, 238)
        Me.dgvListarDetalleProductos.TabIndex = 1
        '
        'frmDetallePedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(670, 246)
        Me.Controls.Add(Me.dgvListarDetalleProductos)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDetallePedido"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalle Pedido"
        CType(Me.dgvListarDetalleProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvListarDetalleProductos As DataGridView
End Class
