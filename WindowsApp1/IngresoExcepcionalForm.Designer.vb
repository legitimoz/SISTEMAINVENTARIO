<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IngresoExcepcionalForm
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.input_archivo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCargaDeArchivos = New FontAwesome.Sharp.IconButton()
        Me.cmdCancelar = New FontAwesome.Sharp.IconButton()
        Me.cmdAceptar = New FontAwesome.Sharp.IconButton()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.btnCargaDeArchivos)
        Me.Panel1.Controls.Add(Me.cmdCancelar)
        Me.Panel1.Controls.Add(Me.cmdAceptar)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(378, 123)
        Me.Panel1.TabIndex = 0
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.input_archivo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(360, 72)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Archivo"
        '
        'input_archivo
        '
        Me.input_archivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.input_archivo.Enabled = False
        Me.input_archivo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.input_archivo.Location = New System.Drawing.Point(9, 43)
        Me.input_archivo.Name = "input_archivo"
        Me.input_archivo.Size = New System.Drawing.Size(345, 20)
        Me.input_archivo.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 14)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Archivo:"
        '
        'btnCargaDeArchivos
        '
        Me.btnCargaDeArchivos.BackColor = System.Drawing.SystemColors.Control
        Me.btnCargaDeArchivos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCargaDeArchivos.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack
        Me.btnCargaDeArchivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCargaDeArchivos.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCargaDeArchivos.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnCargaDeArchivos.IconChar = FontAwesome.Sharp.IconChar.Upload
        Me.btnCargaDeArchivos.IconColor = System.Drawing.SystemColors.HotTrack
        Me.btnCargaDeArchivos.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.btnCargaDeArchivos.IconSize = 16
        Me.btnCargaDeArchivos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCargaDeArchivos.Location = New System.Drawing.Point(3, 81)
        Me.btnCargaDeArchivos.Name = "btnCargaDeArchivos"
        Me.btnCargaDeArchivos.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.btnCargaDeArchivos.Size = New System.Drawing.Size(130, 24)
        Me.btnCargaDeArchivos.TabIndex = 7
        Me.btnCargaDeArchivos.Text = "Cargar archivos"
        Me.btnCargaDeArchivos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCargaDeArchivos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCargaDeArchivos.UseVisualStyleBackColor = False
        '
        'cmdCancelar
        '
        Me.cmdCancelar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Crimson
        Me.cmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCancelar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.ForeColor = System.Drawing.Color.Crimson
        Me.cmdCancelar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle
        Me.cmdCancelar.IconColor = System.Drawing.Color.Crimson
        Me.cmdCancelar.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.cmdCancelar.IconSize = 16
        Me.cmdCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCancelar.Location = New System.Drawing.Point(273, 81)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.cmdCancelar.Size = New System.Drawing.Size(90, 24)
        Me.cmdCancelar.TabIndex = 9
        Me.cmdCancelar.Text = "Cancelar"
        Me.cmdCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdCancelar.UseVisualStyleBackColor = False
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
        Me.cmdAceptar.Location = New System.Drawing.Point(177, 81)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.cmdAceptar.Size = New System.Drawing.Size(90, 24)
        Me.cmdAceptar.TabIndex = 8
        Me.cmdAceptar.Text = "Aceptar"
        Me.cmdAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdAceptar.UseVisualStyleBackColor = False
        '
        'IngresoExcepcionalForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 147)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "IngresoExcepcionalForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IngresoExcepcionalForm"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents input_archivo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCargaDeArchivos As FontAwesome.Sharp.IconButton
    Friend WithEvents cmdCancelar As FontAwesome.Sharp.IconButton
    Friend WithEvents cmdAceptar As FontAwesome.Sharp.IconButton
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
