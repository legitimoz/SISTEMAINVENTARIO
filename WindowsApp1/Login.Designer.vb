<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ErrorProvider2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnCerrar = New FontAwesome.Sharp.IconPictureBox()
        Me.btnMinimizar = New FontAwesome.Sharp.IconPictureBox()
        Me.panelTituloBar = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtusuario = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtclave = New System.Windows.Forms.TextBox()
        Me.checkVerPass = New System.Windows.Forms.CheckBox()
        Me.cmdAceptar = New FontAwesome.Sharp.IconButton()
        Me.checkRecordar = New System.Windows.Forms.CheckBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelTituloBar.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(246, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Version 2.0.0.1"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 513)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(340, 37)
        Me.Panel2.TabIndex = 8
        '
        'ErrorProvider2
        '
        Me.ErrorProvider2.ContainerControl = Me
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.SystemColors.Control
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.ForeColor = System.Drawing.Color.Maroon
        Me.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.WindowClose
        Me.btnCerrar.IconColor = System.Drawing.Color.Maroon
        Me.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.btnCerrar.IconSize = 22
        Me.btnCerrar.Location = New System.Drawing.Point(304, 9)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(22, 22)
        Me.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnCerrar.TabIndex = 0
        Me.btnCerrar.TabStop = False
        '
        'btnMinimizar
        '
        Me.btnMinimizar.BackColor = System.Drawing.SystemColors.Control
        Me.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimizar.ForeColor = System.Drawing.Color.Maroon
        Me.btnMinimizar.IconChar = FontAwesome.Sharp.IconChar.Minus
        Me.btnMinimizar.IconColor = System.Drawing.Color.Maroon
        Me.btnMinimizar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnMinimizar.IconSize = 22
        Me.btnMinimizar.Location = New System.Drawing.Point(276, 9)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(22, 22)
        Me.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnMinimizar.TabIndex = 1
        Me.btnMinimizar.TabStop = False
        '
        'panelTituloBar
        '
        Me.panelTituloBar.BackColor = System.Drawing.SystemColors.Control
        Me.panelTituloBar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panelTituloBar.Controls.Add(Me.btnMinimizar)
        Me.panelTituloBar.Controls.Add(Me.btnCerrar)
        Me.panelTituloBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTituloBar.Location = New System.Drawing.Point(0, 0)
        Me.panelTituloBar.Name = "panelTituloBar"
        Me.panelTituloBar.Size = New System.Drawing.Size(340, 40)
        Me.panelTituloBar.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 260)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 14)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "USUARIO:"
        '
        'txtusuario
        '
        Me.txtusuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtusuario.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtusuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtusuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtusuario.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtusuario.Location = New System.Drawing.Point(38, 284)
        Me.txtusuario.Margin = New System.Windows.Forms.Padding(3, 10, 3, 4)
        Me.txtusuario.Multiline = True
        Me.txtusuario.Name = "txtusuario"
        Me.txtusuario.Size = New System.Drawing.Size(260, 20)
        Me.txtusuario.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(37, 325)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 14)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "CONTRASEÑA:"
        '
        'txtclave
        '
        Me.txtclave.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtclave.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtclave.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtclave.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtclave.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtclave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtclave.Location = New System.Drawing.Point(38, 349)
        Me.txtclave.Margin = New System.Windows.Forms.Padding(3, 10, 3, 4)
        Me.txtclave.Multiline = True
        Me.txtclave.Name = "txtclave"
        Me.txtclave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtclave.Size = New System.Drawing.Size(260, 20)
        Me.txtclave.TabIndex = 2
        '
        'checkVerPass
        '
        Me.checkVerPass.AutoSize = True
        Me.checkVerPass.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkVerPass.Location = New System.Drawing.Point(38, 378)
        Me.checkVerPass.Name = "checkVerPass"
        Me.checkVerPass.Size = New System.Drawing.Size(102, 18)
        Me.checkVerPass.TabIndex = 3
        Me.checkVerPass.Text = "Ver Contraseña"
        Me.checkVerPass.UseVisualStyleBackColor = True
        '
        'cmdAceptar
        '
        Me.cmdAceptar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.cmdAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdAceptar.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen
        Me.cmdAceptar.FlatAppearance.BorderSize = 0
        Me.cmdAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAceptar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAceptar.IconChar = FontAwesome.Sharp.IconChar._500Px
        Me.cmdAceptar.IconColor = System.Drawing.SystemColors.Control
        Me.cmdAceptar.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.cmdAceptar.IconSize = 16
        Me.cmdAceptar.Location = New System.Drawing.Point(38, 423)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.cmdAceptar.Size = New System.Drawing.Size(260, 30)
        Me.cmdAceptar.TabIndex = 5
        Me.cmdAceptar.Text = "INGRESAR"
        Me.cmdAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdAceptar.UseVisualStyleBackColor = False
        '
        'checkRecordar
        '
        Me.checkRecordar.AutoSize = True
        Me.checkRecordar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkRecordar.Location = New System.Drawing.Point(179, 378)
        Me.checkRecordar.Name = "checkRecordar"
        Me.checkRecordar.Size = New System.Drawing.Size(111, 18)
        Me.checkRecordar.TabIndex = 4
        Me.checkRecordar.Text = "Recordar Usuario"
        Me.checkRecordar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = Global.WindowsApp1.My.Resources.Resources.LogoNordicResize
        Me.PictureBox1.Location = New System.Drawing.Point(71, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(197, 199)
        Me.PictureBox1.TabIndex = 39
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.checkRecordar)
        Me.Panel1.Controls.Add(Me.cmdAceptar)
        Me.Panel1.Controls.Add(Me.checkVerPass)
        Me.Panel1.Controls.Add(Me.txtclave)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtusuario)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 40)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(340, 510)
        Me.Panel1.TabIndex = 1
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(340, 550)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.panelTituloBar)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelTituloBar.ResumeLayout(False)
        Me.panelTituloBar.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ErrorProvider2 As ErrorProvider
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents checkRecordar As CheckBox
    Friend WithEvents cmdAceptar As FontAwesome.Sharp.IconButton
    Friend WithEvents checkVerPass As CheckBox
    Friend WithEvents txtclave As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtusuario As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents panelTituloBar As Panel
    Friend WithEvents btnMinimizar As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents btnCerrar As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
