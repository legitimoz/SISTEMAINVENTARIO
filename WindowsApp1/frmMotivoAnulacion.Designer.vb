<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMotivoAnulacion
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
        Me.txtSolid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbxTipoMotivos = New System.Windows.Forms.ComboBox()
        Me.rtbDescripcion = New System.Windows.Forms.RichTextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 19)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 11)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nro Solicitud"
        '
        'txtSolid
        '
        Me.txtSolid.Enabled = False
        Me.txtSolid.Location = New System.Drawing.Point(83, 16)
        Me.txtSolid.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtSolid.Name = "txtSolid"
        Me.txtSolid.Size = New System.Drawing.Size(87, 18)
        Me.txtSolid.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 44)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 11)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tipo Motivo"
        '
        'cbxTipoMotivos
        '
        Me.cbxTipoMotivos.BackColor = System.Drawing.Color.White
        Me.cbxTipoMotivos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTipoMotivos.FormattingEnabled = True
        Me.cbxTipoMotivos.Location = New System.Drawing.Point(83, 40)
        Me.cbxTipoMotivos.Name = "cbxTipoMotivos"
        Me.cbxTipoMotivos.Size = New System.Drawing.Size(366, 19)
        Me.cbxTipoMotivos.TabIndex = 3
        '
        'rtbDescripcion
        '
        Me.rtbDescripcion.Location = New System.Drawing.Point(13, 77)
        Me.rtbDescripcion.Name = "rtbDescripcion"
        Me.rtbDescripcion.Size = New System.Drawing.Size(436, 176)
        Me.rtbDescripcion.TabIndex = 4
        Me.rtbDescripcion.Text = ""
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = Global.WindowsApp1.My.Resources.Resources._0032
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(167, 272)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(124, 30)
        Me.btnGuardar.TabIndex = 5
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'frmMotivoAnulacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(5.0!, 11.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 314)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.rtbDescripcion)
        Me.Controls.Add(Me.cbxTipoMotivos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSolid)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMotivoAnulacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Motivo de Anulación"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtSolid As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbxTipoMotivos As ComboBox
    Friend WithEvents rtbDescripcion As RichTextBox
    Friend WithEvents btnGuardar As Button
End Class
