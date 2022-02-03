<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmObsReq
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
        Me.rtbComentario = New System.Windows.Forms.RichTextBox()
        Me.txtReqId = New System.Windows.Forms.TextBox()
        Me.txtAsunto = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'rtbComentario
        '
        Me.rtbComentario.Location = New System.Drawing.Point(12, 39)
        Me.rtbComentario.Name = "rtbComentario"
        Me.rtbComentario.Size = New System.Drawing.Size(534, 176)
        Me.rtbComentario.TabIndex = 0
        Me.rtbComentario.Text = ""
        '
        'txtReqId
        '
        Me.txtReqId.Location = New System.Drawing.Point(12, 7)
        Me.txtReqId.Name = "txtReqId"
        Me.txtReqId.Size = New System.Drawing.Size(66, 21)
        Me.txtReqId.TabIndex = 1
        '
        'txtAsunto
        '
        Me.txtAsunto.Location = New System.Drawing.Point(84, 7)
        Me.txtAsunto.Name = "txtAsunto"
        Me.txtAsunto.Size = New System.Drawing.Size(462, 21)
        Me.txtAsunto.TabIndex = 2
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.White
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.Image = Global.WindowsApp1.My.Resources.Resources._003
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(210, 226)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(136, 23)
        Me.btnGuardar.TabIndex = 3
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'frmObsReq
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(558, 260)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.txtAsunto)
        Me.Controls.Add(Me.txtReqId)
        Me.Controls.Add(Me.rtbComentario)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmObsReq"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Observacion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rtbComentario As RichTextBox
    Friend WithEvents txtReqId As TextBox
    Friend WithEvents txtAsunto As TextBox
    Friend WithEvents btnGuardar As Button
End Class
