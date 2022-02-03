<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditarPosicionesComplemento
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnNuevo = New FontAwesome.Sharp.IconButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_alto = New System.Windows.Forms.TextBox()
        Me.txt_largo = New System.Windows.Forms.TextBox()
        Me.txt_ancho = New System.Windows.Forms.TextBox()
        Me.Dg_Confirmados = New System.Windows.Forms.DataGridView()
        Me.ErrorDimensiones = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorPrecios = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorCuenta = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorEntidad = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorComboFormaPago = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorIdRq = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Check_Todos = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.Dg_Confirmados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorDimensiones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorPrecios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorEntidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorComboFormaPago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorIdRq, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.SystemColors.Control
        Me.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.ForeColor = System.Drawing.Color.ForestGreen
        Me.btnNuevo.IconChar = FontAwesome.Sharp.IconChar.CheckCircle
        Me.btnNuevo.IconColor = System.Drawing.Color.ForestGreen
        Me.btnNuevo.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.btnNuevo.IconSize = 16
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevo.Location = New System.Drawing.Point(584, 10)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Padding = New System.Windows.Forms.Padding(9, 0, 0, 0)
        Me.btnNuevo.Size = New System.Drawing.Size(87, 24)
        Me.btnNuevo.TabIndex = 6
        Me.btnNuevo.Text = "Aceptar"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(502, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Ancho"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(325, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Largo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(159, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Alto"
        '
        'txt_alto
        '
        Me.txt_alto.Location = New System.Drawing.Point(196, 10)
        Me.txt_alto.Name = "txt_alto"
        Me.txt_alto.Size = New System.Drawing.Size(116, 21)
        Me.txt_alto.TabIndex = 3
        '
        'txt_largo
        '
        Me.txt_largo.Location = New System.Drawing.Point(373, 10)
        Me.txt_largo.Name = "txt_largo"
        Me.txt_largo.Size = New System.Drawing.Size(116, 21)
        Me.txt_largo.TabIndex = 4
        '
        'txt_ancho
        '
        Me.txt_ancho.Location = New System.Drawing.Point(554, 10)
        Me.txt_ancho.Name = "txt_ancho"
        Me.txt_ancho.Size = New System.Drawing.Size(116, 21)
        Me.txt_ancho.TabIndex = 5
        '
        'Dg_Confirmados
        '
        Me.Dg_Confirmados.AllowUserToAddRows = False
        Me.Dg_Confirmados.AllowUserToDeleteRows = False
        Me.Dg_Confirmados.AllowUserToResizeRows = False
        Me.Dg_Confirmados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Dg_Confirmados.BackgroundColor = System.Drawing.SystemColors.Control
        Me.Dg_Confirmados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dg_Confirmados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.Dg_Confirmados.ColumnHeadersHeight = 50
        Me.Dg_Confirmados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Dg_Confirmados.EnableHeadersVisualStyles = False
        Me.Dg_Confirmados.Location = New System.Drawing.Point(12, 15)
        Me.Dg_Confirmados.Name = "Dg_Confirmados"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dg_Confirmados.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.Dg_Confirmados.RowHeadersVisible = False
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Dg_Confirmados.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.Dg_Confirmados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dg_Confirmados.Size = New System.Drawing.Size(659, 213)
        Me.Dg_Confirmados.TabIndex = 1
        '
        'ErrorDimensiones
        '
        Me.ErrorDimensiones.ContainerControl = Me
        Me.ErrorDimensiones.RightToLeft = True
        '
        'ErrorPrecios
        '
        Me.ErrorPrecios.ContainerControl = Me
        '
        'ErrorCuenta
        '
        Me.ErrorCuenta.ContainerControl = Me
        Me.ErrorCuenta.RightToLeft = True
        '
        'ErrorEntidad
        '
        Me.ErrorEntidad.ContainerControl = Me
        Me.ErrorEntidad.RightToLeft = True
        '
        'ErrorComboFormaPago
        '
        Me.ErrorComboFormaPago.ContainerControl = Me
        Me.ErrorComboFormaPago.RightToLeft = True
        '
        'ErrorIdRq
        '
        Me.ErrorIdRq.ContainerControl = Me
        Me.ErrorIdRq.RightToLeft = True
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.Control
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel6.Controls.Add(Me.Dg_Confirmados)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(0, 54)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(687, 230)
        Me.Panel6.TabIndex = 50
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.btnNuevo)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 284)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(687, 48)
        Me.Panel2.TabIndex = 49
        '
        'Check_Todos
        '
        Me.Check_Todos.AutoSize = True
        Me.Check_Todos.Location = New System.Drawing.Point(12, 12)
        Me.Check_Todos.Name = "Check_Todos"
        Me.Check_Todos.Size = New System.Drawing.Size(101, 17)
        Me.Check_Todos.TabIndex = 2
        Me.Check_Todos.Text = "Definir Todos"
        Me.Check_Todos.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Check_Todos)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txt_alto)
        Me.Panel1.Controls.Add(Me.txt_largo)
        Me.Panel1.Controls.Add(Me.txt_ancho)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(687, 54)
        Me.Panel1.TabIndex = 48
        '
        'EditarPosicionesComplemento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(687, 332)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EditarPosicionesComplemento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EditarPosicionesComplemento"
        CType(Me.Dg_Confirmados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorDimensiones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorPrecios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorEntidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorComboFormaPago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorIdRq, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnNuevo As FontAwesome.Sharp.IconButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_alto As TextBox
    Friend WithEvents txt_largo As TextBox
    Friend WithEvents txt_ancho As TextBox
    Friend WithEvents Dg_Confirmados As DataGridView
    Friend WithEvents ErrorDimensiones As ErrorProvider
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Check_Todos As CheckBox
    Friend WithEvents ErrorPrecios As ErrorProvider
    Friend WithEvents ErrorCuenta As ErrorProvider
    Friend WithEvents ErrorEntidad As ErrorProvider
    Friend WithEvents ErrorComboFormaPago As ErrorProvider
    Friend WithEvents ErrorIdRq As ErrorProvider
End Class
