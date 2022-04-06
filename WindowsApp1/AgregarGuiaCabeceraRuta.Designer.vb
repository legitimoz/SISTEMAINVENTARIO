<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AgregarGuiaCabeceraRuta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.txt_numero = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.combo_Almacen = New System.Windows.Forms.ComboBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cmb_Costos = New System.Windows.Forms.ComboBox()
        Me.cmdAceptar = New FontAwesome.Sharp.IconButton()
        Me.cmb_tipo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Cmb_Site = New System.Windows.Forms.ComboBox()
        Me.Site = New System.Windows.Forms.Label()
        Me.txt_peso = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_bultos = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_glosa = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_departamento = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_provincia = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_distrito = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmb_siteliq = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmb_fisico = New System.Windows.Forms.ComboBox()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_numero
        '
        Me.txt_numero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_numero.Location = New System.Drawing.Point(130, 39)
        Me.txt_numero.Name = "txt_numero"
        Me.txt_numero.Size = New System.Drawing.Size(209, 20)
        Me.txt_numero.TabIndex = 88
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 14)
        Me.Label6.TabIndex = 87
        Me.Label6.Text = "Nº Documento:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 14)
        Me.Label4.TabIndex = 86
        Me.Label4.Text = "Almacen: "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'combo_Almacen
        '
        Me.combo_Almacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_Almacen.FormattingEnabled = True
        Me.combo_Almacen.Location = New System.Drawing.Point(130, 12)
        Me.combo_Almacen.Name = "combo_Almacen"
        Me.combo_Almacen.Size = New System.Drawing.Size(209, 21)
        Me.combo_Almacen.TabIndex = 85
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 91
        Me.Label1.Text = "Centro de Costos:"
        '
        'Cmb_Costos
        '
        Me.Cmb_Costos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_Costos.Enabled = False
        Me.Cmb_Costos.FormattingEnabled = True
        Me.Cmb_Costos.Location = New System.Drawing.Point(130, 65)
        Me.Cmb_Costos.Name = "Cmb_Costos"
        Me.Cmb_Costos.Size = New System.Drawing.Size(209, 21)
        Me.Cmb_Costos.TabIndex = 90
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
        Me.cmdAceptar.Location = New System.Drawing.Point(245, 384)
        Me.cmdAceptar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.cmdAceptar.Size = New System.Drawing.Size(97, 26)
        Me.cmdAceptar.TabIndex = 89
        Me.cmdAceptar.Text = "Aceptar"
        Me.cmdAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdAceptar.UseVisualStyleBackColor = False
        '
        'cmb_tipo
        '
        Me.cmb_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tipo.Enabled = False
        Me.cmb_tipo.FormattingEnabled = True
        Me.cmb_tipo.Items.AddRange(New Object() {"DESPACHO", "RECOJO"})
        Me.cmb_tipo.Location = New System.Drawing.Point(130, 92)
        Me.cmb_tipo.Name = "cmb_tipo"
        Me.cmb_tipo.Size = New System.Drawing.Size(209, 21)
        Me.cmb_tipo.TabIndex = 92
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 93
        Me.Label2.Text = "Tipo Envio:"
        '
        'Cmb_Site
        '
        Me.Cmb_Site.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_Site.Enabled = False
        Me.Cmb_Site.FormattingEnabled = True
        Me.Cmb_Site.Location = New System.Drawing.Point(130, 119)
        Me.Cmb_Site.Name = "Cmb_Site"
        Me.Cmb_Site.Size = New System.Drawing.Size(209, 21)
        Me.Cmb_Site.TabIndex = 94
        '
        'Site
        '
        Me.Site.AutoSize = True
        Me.Site.Location = New System.Drawing.Point(16, 122)
        Me.Site.Name = "Site"
        Me.Site.Size = New System.Drawing.Size(31, 13)
        Me.Site.TabIndex = 95
        Me.Site.Text = "Site: "
        '
        'txt_peso
        '
        Me.txt_peso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_peso.Enabled = False
        Me.txt_peso.Location = New System.Drawing.Point(130, 146)
        Me.txt_peso.Name = "txt_peso"
        Me.txt_peso.Size = New System.Drawing.Size(209, 20)
        Me.txt_peso.TabIndex = 97
        Me.txt_peso.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 14)
        Me.Label3.TabIndex = 96
        Me.Label3.Text = "Peso:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txt_bultos
        '
        Me.txt_bultos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_bultos.Enabled = False
        Me.txt_bultos.Location = New System.Drawing.Point(130, 172)
        Me.txt_bultos.Name = "txt_bultos"
        Me.txt_bultos.Size = New System.Drawing.Size(209, 20)
        Me.txt_bultos.TabIndex = 99
        Me.txt_bultos.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 175)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 14)
        Me.Label5.TabIndex = 98
        Me.Label5.Text = "Bultos:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txt_glosa
        '
        Me.txt_glosa.AutoSize = True
        Me.txt_glosa.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold)
        Me.txt_glosa.Location = New System.Drawing.Point(127, 259)
        Me.txt_glosa.Name = "txt_glosa"
        Me.txt_glosa.Size = New System.Drawing.Size(12, 13)
        Me.txt_glosa.TabIndex = 100
        Me.txt_glosa.Text = "-"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 258)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 14)
        Me.Label7.TabIndex = 101
        Me.Label7.Text = "Glosa:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 287)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 14)
        Me.Label8.TabIndex = 103
        Me.Label8.Text = "Departamento:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txt_departamento
        '
        Me.txt_departamento.AutoSize = True
        Me.txt_departamento.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold)
        Me.txt_departamento.Location = New System.Drawing.Point(127, 288)
        Me.txt_departamento.Name = "txt_departamento"
        Me.txt_departamento.Size = New System.Drawing.Size(12, 13)
        Me.txt_departamento.TabIndex = 102
        Me.txt_departamento.Text = "-"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(16, 317)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 14)
        Me.Label10.TabIndex = 105
        Me.Label10.Text = "Provincia:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txt_provincia
        '
        Me.txt_provincia.AutoSize = True
        Me.txt_provincia.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold)
        Me.txt_provincia.Location = New System.Drawing.Point(127, 318)
        Me.txt_provincia.Name = "txt_provincia"
        Me.txt_provincia.Size = New System.Drawing.Size(12, 13)
        Me.txt_provincia.TabIndex = 104
        Me.txt_provincia.Text = "-"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(16, 348)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(43, 14)
        Me.Label12.TabIndex = 107
        Me.Label12.Text = "Distrito:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txt_distrito
        '
        Me.txt_distrito.AutoSize = True
        Me.txt_distrito.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold)
        Me.txt_distrito.Location = New System.Drawing.Point(127, 349)
        Me.txt_distrito.Name = "txt_distrito"
        Me.txt_distrito.Size = New System.Drawing.Size(12, 13)
        Me.txt_distrito.TabIndex = 106
        Me.txt_distrito.Text = "-"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 228)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 13)
        Me.Label9.TabIndex = 156
        Me.Label9.Text = "Site Liquidacion :"
        '
        'cmb_siteliq
        '
        Me.cmb_siteliq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_siteliq.FormattingEnabled = True
        Me.cmb_siteliq.Location = New System.Drawing.Point(130, 225)
        Me.cmb_siteliq.Name = "cmb_siteliq"
        Me.cmb_siteliq.Size = New System.Drawing.Size(209, 21)
        Me.cmb_siteliq.TabIndex = 155
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(16, 201)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 13)
        Me.Label11.TabIndex = 154
        Me.Label11.Text = "Fisico :"
        '
        'cmb_fisico
        '
        Me.cmb_fisico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_fisico.FormattingEnabled = True
        Me.cmb_fisico.Items.AddRange(New Object() {"SI", "NO"})
        Me.cmb_fisico.Location = New System.Drawing.Point(130, 198)
        Me.cmb_fisico.Name = "cmb_fisico"
        Me.cmb_fisico.Size = New System.Drawing.Size(209, 21)
        Me.cmb_fisico.TabIndex = 153
        '
        'AgregarGuiaCabeceraRuta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(355, 423)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmb_siteliq)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cmb_fisico)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txt_distrito)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txt_provincia)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_departamento)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_glosa)
        Me.Controls.Add(Me.txt_bultos)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_peso)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Site)
        Me.Controls.Add(Me.Cmb_Site)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmb_tipo)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.txt_numero)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.combo_Almacen)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cmb_Costos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "AgregarGuiaCabeceraRuta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Guia CabeceraRuta"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdAceptar As FontAwesome.Sharp.IconButton
    Friend WithEvents txt_numero As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents combo_Almacen As ComboBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Label1 As Label
    Friend WithEvents Cmb_Costos As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmb_tipo As ComboBox
    Friend WithEvents Site As Label
    Friend WithEvents Cmb_Site As ComboBox
    Friend WithEvents txt_bultos As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_peso As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_glosa As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_provincia As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_departamento As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txt_distrito As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cmb_siteliq As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cmb_fisico As ComboBox
End Class
