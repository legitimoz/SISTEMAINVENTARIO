<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBusquedaGuiaRotulos
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
        Me.dgvListarDetalleGuias = New System.Windows.Forms.DataGridView()
        CType(Me.dgvListarDetalleGuias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvListarDetalleGuias
        '
        Me.dgvListarDetalleGuias.AllowUserToAddRows = False
        Me.dgvListarDetalleGuias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListarDetalleGuias.Location = New System.Drawing.Point(5, 3)
        Me.dgvListarDetalleGuias.MultiSelect = False
        Me.dgvListarDetalleGuias.Name = "dgvListarDetalleGuias"
        Me.dgvListarDetalleGuias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListarDetalleGuias.Size = New System.Drawing.Size(761, 299)
        Me.dgvListarDetalleGuias.TabIndex = 0
        '
        'frmBusquedaGuiaRotulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(771, 306)
        Me.Controls.Add(Me.dgvListarDetalleGuias)
        Me.Name = "frmBusquedaGuiaRotulos"
        Me.Text = "Detalle Guia"
        CType(Me.dgvListarDetalleGuias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvListarDetalleGuias As DataGridView
End Class
