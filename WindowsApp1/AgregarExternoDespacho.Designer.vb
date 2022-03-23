<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarExternoDespacho
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
        Me.txt_documento = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_ruccliente = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_nombrecliente = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_direccion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_departamento = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_provincia = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_distrito = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_volumen = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_importe = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmb_canal = New System.Windows.Forms.ComboBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.cmdAceptar = New FontAwesome.Sharp.IconButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Cmb_Costos = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmb_direcciones = New System.Windows.Forms.ComboBox()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_documento
        '
        Me.txt_documento.Location = New System.Drawing.Point(118, 13)
        Me.txt_documento.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_documento.Name = "txt_documento"
        Me.txt_documento.Size = New System.Drawing.Size(324, 20)
        Me.txt_documento.TabIndex = 126
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(22, 16)
        Me.Label1.Margin = New System.Windows.Forms.Padding(10, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 14)
        Me.Label1.TabIndex = 127
        Me.Label1.Text = "N° Documento :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txt_ruccliente
        '
        Me.txt_ruccliente.Location = New System.Drawing.Point(118, 41)
        Me.txt_ruccliente.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_ruccliente.Name = "txt_ruccliente"
        Me.txt_ruccliente.Size = New System.Drawing.Size(324, 20)
        Me.txt_ruccliente.TabIndex = 128
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(35, 44)
        Me.Label2.Margin = New System.Windows.Forms.Padding(10, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 14)
        Me.Label2.TabIndex = 129
        Me.Label2.Text = "Ruc Cliente :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txt_nombrecliente
        '
        Me.txt_nombrecliente.Location = New System.Drawing.Point(118, 69)
        Me.txt_nombrecliente.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_nombrecliente.Name = "txt_nombrecliente"
        Me.txt_nombrecliente.Size = New System.Drawing.Size(324, 20)
        Me.txt_nombrecliente.TabIndex = 130
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(17, 72)
        Me.Label3.Margin = New System.Windows.Forms.Padding(10, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 14)
        Me.Label3.TabIndex = 131
        Me.Label3.Text = "Nombre Cliente :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txt_direccion
        '
        Me.txt_direccion.Location = New System.Drawing.Point(118, 124)
        Me.txt_direccion.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_direccion.Name = "txt_direccion"
        Me.txt_direccion.Size = New System.Drawing.Size(324, 20)
        Me.txt_direccion.TabIndex = 132
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(8, 127)
        Me.Label4.Margin = New System.Windows.Forms.Padding(10, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 14)
        Me.Label4.TabIndex = 133
        Me.Label4.Text = "Direccion Cliente :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txt_departamento
        '
        Me.txt_departamento.Location = New System.Drawing.Point(118, 152)
        Me.txt_departamento.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_departamento.Name = "txt_departamento"
        Me.txt_departamento.Size = New System.Drawing.Size(324, 20)
        Me.txt_departamento.TabIndex = 134
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(20, 155)
        Me.Label5.Margin = New System.Windows.Forms.Padding(10, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 14)
        Me.Label5.TabIndex = 135
        Me.Label5.Text = "Departamento :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txt_provincia
        '
        Me.txt_provincia.Location = New System.Drawing.Point(118, 180)
        Me.txt_provincia.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_provincia.Name = "txt_provincia"
        Me.txt_provincia.Size = New System.Drawing.Size(324, 20)
        Me.txt_provincia.TabIndex = 136
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(43, 183)
        Me.Label6.Margin = New System.Windows.Forms.Padding(10, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 14)
        Me.Label6.TabIndex = 137
        Me.Label6.Text = "Provincia :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txt_distrito
        '
        Me.txt_distrito.Location = New System.Drawing.Point(118, 208)
        Me.txt_distrito.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_distrito.Name = "txt_distrito"
        Me.txt_distrito.Size = New System.Drawing.Size(324, 20)
        Me.txt_distrito.TabIndex = 138
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(53, 211)
        Me.Label7.Margin = New System.Windows.Forms.Padding(10, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 14)
        Me.Label7.TabIndex = 139
        Me.Label7.Text = "Distrito :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(59, 239)
        Me.Label8.Margin = New System.Windows.Forms.Padding(10, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 14)
        Me.Label8.TabIndex = 141
        Me.Label8.Text = "Canal :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txt_volumen
        '
        Me.txt_volumen.Location = New System.Drawing.Point(118, 264)
        Me.txt_volumen.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_volumen.Name = "txt_volumen"
        Me.txt_volumen.Size = New System.Drawing.Size(324, 20)
        Me.txt_volumen.TabIndex = 142
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(28, 267)
        Me.Label9.Margin = New System.Windows.Forms.Padding(10, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 14)
        Me.Label9.TabIndex = 143
        Me.Label9.Text = "Volumen M3 :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txt_importe
        '
        Me.txt_importe.Location = New System.Drawing.Point(118, 292)
        Me.txt_importe.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_importe.Name = "txt_importe"
        Me.txt_importe.Size = New System.Drawing.Size(324, 20)
        Me.txt_importe.TabIndex = 144
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(51, 295)
        Me.Label10.Margin = New System.Windows.Forms.Padding(10, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 14)
        Me.Label10.TabIndex = 145
        Me.Label10.Text = "Importe :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cmb_canal
        '
        Me.cmb_canal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_canal.DropDownWidth = 250
        Me.cmb_canal.FormattingEnabled = True
        Me.cmb_canal.Location = New System.Drawing.Point(118, 235)
        Me.cmb_canal.Name = "cmb_canal"
        Me.cmb_canal.Size = New System.Drawing.Size(324, 21)
        Me.cmb_canal.TabIndex = 146
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.cmdAceptar.Location = New System.Drawing.Point(350, 354)
        Me.cmdAceptar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.cmdAceptar.Size = New System.Drawing.Size(92, 26)
        Me.cmdAceptar.TabIndex = 147
        Me.cmdAceptar.Text = "Aceptar"
        Me.cmdAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdAceptar.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(7, 322)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(91, 13)
        Me.Label11.TabIndex = 149
        Me.Label11.Text = "Centro de Costos:"
        '
        'Cmb_Costos
        '
        Me.Cmb_Costos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_Costos.FormattingEnabled = True
        Me.Cmb_Costos.Location = New System.Drawing.Point(118, 319)
        Me.Cmb_Costos.Name = "Cmb_Costos"
        Me.Cmb_Costos.Size = New System.Drawing.Size(324, 21)
        Me.Cmb_Costos.TabIndex = 148
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(35, 99)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 13)
        Me.Label12.TabIndex = 151
        Me.Label12.Text = "Direcciones:"
        '
        'cmb_direcciones
        '
        Me.cmb_direcciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_direcciones.FormattingEnabled = True
        Me.cmb_direcciones.Location = New System.Drawing.Point(118, 96)
        Me.cmb_direcciones.Name = "cmb_direcciones"
        Me.cmb_direcciones.Size = New System.Drawing.Size(324, 21)
        Me.cmb_direcciones.TabIndex = 150
        '
        'AgregarExternoDespacho
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(455, 393)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cmb_direcciones)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Cmb_Costos)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.cmb_canal)
        Me.Controls.Add(Me.txt_importe)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txt_volumen)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_distrito)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_provincia)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_departamento)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_direccion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_nombrecliente)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_ruccliente)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_documento)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "AgregarExternoDespacho"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AgregarExternoDespacho"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_documento As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_ruccliente As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_nombrecliente As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_direccion As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_departamento As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_provincia As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_distrito As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_volumen As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_importe As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cmb_canal As ComboBox
    Friend WithEvents cmdAceptar As FontAwesome.Sharp.IconButton
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Label11 As Label
    Friend WithEvents Cmb_Costos As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents cmb_direcciones As ComboBox
End Class
