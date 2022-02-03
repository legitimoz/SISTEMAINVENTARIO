<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetallePosiciones
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
        Me.Dg_Posiciones = New System.Windows.Forms.DataGridView()
        Me.Posicion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_lote = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_item = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.Dg_Posiciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Dg_Posiciones
        '
        Me.Dg_Posiciones.AllowUserToAddRows = False
        Me.Dg_Posiciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Dg_Posiciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dg_Posiciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Posicion, Me.Cantidad})
        Me.Dg_Posiciones.Location = New System.Drawing.Point(12, 66)
        Me.Dg_Posiciones.Name = "Dg_Posiciones"
        Me.Dg_Posiciones.RowHeadersWidth = 50
        Me.Dg_Posiciones.Size = New System.Drawing.Size(400, 177)
        Me.Dg_Posiciones.TabIndex = 0
        '
        'Posicion
        '
        Me.Posicion.HeaderText = "Posicion"
        Me.Posicion.Name = "Posicion"
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Posicion"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 174
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 174
        '
        'txt_lote
        '
        Me.txt_lote.AutoSize = True
        Me.txt_lote.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_lote.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txt_lote.Location = New System.Drawing.Point(70, 38)
        Me.txt_lote.MaximumSize = New System.Drawing.Size(180, 18)
        Me.txt_lote.MinimumSize = New System.Drawing.Size(180, 18)
        Me.txt_lote.Name = "txt_lote"
        Me.txt_lote.Size = New System.Drawing.Size(180, 18)
        Me.txt_lote.TabIndex = 94
        Me.txt_lote.Text = "-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 40)
        Me.Label3.Margin = New System.Windows.Forms.Padding(9, 0, 3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 14)
        Me.Label3.TabIndex = 93
        Me.Label3.Text = "Lote :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txt_item
        '
        Me.txt_item.AutoSize = True
        Me.txt_item.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_item.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txt_item.Location = New System.Drawing.Point(70, 7)
        Me.txt_item.MaximumSize = New System.Drawing.Size(180, 18)
        Me.txt_item.MinimumSize = New System.Drawing.Size(180, 18)
        Me.txt_item.Name = "txt_item"
        Me.txt_item.Size = New System.Drawing.Size(180, 18)
        Me.txt_item.TabIndex = 92
        Me.txt_item.Text = "-"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(33, 9)
        Me.Label5.Margin = New System.Windows.Forms.Padding(9, 0, 3, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 14)
        Me.Label5.TabIndex = 91
        Me.Label5.Text = "Item :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'DetallePosiciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 255)
        Me.Controls.Add(Me.txt_lote)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_item)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Dg_Posiciones)
        Me.MaximizeBox = False
        Me.Name = "DetallePosiciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DetallePosiciones"
        CType(Me.Dg_Posiciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Dg_Posiciones As DataGridView
    Friend WithEvents Posicion As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents txt_lote As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_item As Label
    Friend WithEvents Label5 As Label
End Class
