<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SeleccionarPosicionesIngreso
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
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Dg_Posiciones = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.cmdAceptar = New FontAwesome.Sharp.IconButton()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.txt_ubicacion = New System.Windows.Forms.TextBox()
        CType(Me.Dg_Posiciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Dg_Posiciones
        '
        Me.Dg_Posiciones.AllowUserToAddRows = False
        Me.Dg_Posiciones.AllowUserToDeleteRows = False
        Me.Dg_Posiciones.AllowUserToResizeColumns = False
        Me.Dg_Posiciones.AllowUserToResizeRows = False
        Me.Dg_Posiciones.BackgroundColor = System.Drawing.Color.White
        Me.Dg_Posiciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Tahoma", 7.8!)
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dg_Posiciones.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.Dg_Posiciones.ColumnHeadersHeight = 50
        Me.Dg_Posiciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Dg_Posiciones.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.Dg_Posiciones.EnableHeadersVisualStyles = False
        Me.Dg_Posiciones.Location = New System.Drawing.Point(13, 63)
        Me.Dg_Posiciones.Margin = New System.Windows.Forms.Padding(4)
        Me.Dg_Posiciones.MultiSelect = False
        Me.Dg_Posiciones.Name = "Dg_Posiciones"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Tahoma", 7.8!)
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dg_Posiciones.RowHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.Dg_Posiciones.RowHeadersVisible = False
        DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Dg_Posiciones.RowsDefaultCellStyle = DataGridViewCellStyle15
        Me.Dg_Posiciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dg_Posiciones.Size = New System.Drawing.Size(332, 165)
        Me.Dg_Posiciones.TabIndex = 128
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 13)
        Me.Label1.TabIndex = 130
        Me.Label1.Text = "POSICIONES DE ARTICULO"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
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
        Me.cmdAceptar.Location = New System.Drawing.Point(253, 305)
        Me.cmdAceptar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.cmdAceptar.Size = New System.Drawing.Size(92, 24)
        Me.cmdAceptar.TabIndex = 129
        Me.cmdAceptar.Text = "Aceptar"
        Me.cmdAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdAceptar.UseVisualStyleBackColor = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(13, 244)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(105, 17)
        Me.CheckBox1.TabIndex = 131
        Me.CheckBox1.Text = "Definir Ubicacion"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'txt_ubicacion
        '
        Me.txt_ubicacion.Enabled = False
        Me.txt_ubicacion.Location = New System.Drawing.Point(12, 267)
        Me.txt_ubicacion.Name = "txt_ubicacion"
        Me.txt_ubicacion.Size = New System.Drawing.Size(139, 20)
        Me.txt_ubicacion.TabIndex = 132
        '
        'SeleccionarPosicionesIngreso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(358, 342)
        Me.Controls.Add(Me.txt_ubicacion)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.Dg_Posiciones)
        Me.Font = New System.Drawing.Font("Tahoma", 7.8!)
        Me.MaximizeBox = False
        Me.Name = "SeleccionarPosicionesIngreso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SeleccionarPosicionesIngreso"
        CType(Me.Dg_Posiciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents Dg_Posiciones As DataGridView
    Friend WithEvents cmdAceptar As FontAwesome.Sharp.IconButton
    Friend WithEvents Label1 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents txt_ubicacion As TextBox
End Class
