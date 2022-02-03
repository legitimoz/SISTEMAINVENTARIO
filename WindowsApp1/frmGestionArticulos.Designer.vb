<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestionArticulos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGestionArticulos))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboFabricante = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cboPaisOrigen = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cboVidaUtil = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cboPresentacion = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboUnidad = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDes2 = New System.Windows.Forms.TextBox()
        Me.txtDes = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFechaCreacion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboEstado = New System.Windows.Forms.ComboBox()
        Me.btnGuadar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(3, 6)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(685, 423)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(677, 397)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Datos Generales"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboFabricante)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.cboPaisOrigen)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.cboVidaUtil)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.cboPresentacion)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.cboUnidad)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtDes2)
        Me.GroupBox1.Controls.Add(Me.txtDes)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtCodigo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(765, 390)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'cboFabricante
        '
        Me.cboFabricante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFabricante.FormattingEnabled = True
        Me.cboFabricante.Location = New System.Drawing.Point(106, 193)
        Me.cboFabricante.Name = "cboFabricante"
        Me.cboFabricante.Size = New System.Drawing.Size(161, 21)
        Me.cboFabricante.TabIndex = 15
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 198)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 13)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Fabricante"
        '
        'cboPaisOrigen
        '
        Me.cboPaisOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPaisOrigen.FormattingEnabled = True
        Me.cboPaisOrigen.Location = New System.Drawing.Point(106, 167)
        Me.cboPaisOrigen.Name = "cboPaisOrigen"
        Me.cboPaisOrigen.Size = New System.Drawing.Size(161, 21)
        Me.cboPaisOrigen.TabIndex = 13
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 170)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 13)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Pais de Origen"
        '
        'cboVidaUtil
        '
        Me.cboVidaUtil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboVidaUtil.FormattingEnabled = True
        Me.cboVidaUtil.Location = New System.Drawing.Point(106, 142)
        Me.cboVidaUtil.Name = "cboVidaUtil"
        Me.cboVidaUtil.Size = New System.Drawing.Size(161, 21)
        Me.cboVidaUtil.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 145)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Vida Util"
        '
        'cboPresentacion
        '
        Me.cboPresentacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPresentacion.FormattingEnabled = True
        Me.cboPresentacion.Location = New System.Drawing.Point(106, 116)
        Me.cboPresentacion.Name = "cboPresentacion"
        Me.cboPresentacion.Size = New System.Drawing.Size(161, 21)
        Me.cboPresentacion.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 118)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Presentación"
        '
        'cboUnidad
        '
        Me.cboUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUnidad.FormattingEnabled = True
        Me.cboUnidad.Location = New System.Drawing.Point(106, 90)
        Me.cboUnidad.Name = "cboUnidad"
        Me.cboUnidad.Size = New System.Drawing.Size(161, 21)
        Me.cboUnidad.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Unidad"
        '
        'txtDes2
        '
        Me.txtDes2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDes2.Location = New System.Drawing.Point(106, 65)
        Me.txtDes2.Name = "txtDes2"
        Me.txtDes2.Size = New System.Drawing.Size(440, 21)
        Me.txtDes2.TabIndex = 5
        '
        'txtDes
        '
        Me.txtDes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDes.Location = New System.Drawing.Point(106, 40)
        Me.txtDes.Name = "txtDes"
        Me.txtDes.Size = New System.Drawing.Size(440, 21)
        Me.txtDes.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 69)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Descripción 2"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Descripción"
        '
        'txtCodigo
        '
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.Location = New System.Drawing.Point(106, 15)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(108, 21)
        Me.txtCodigo.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Codigo de Articulo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 445)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Usuario"
        '
        'txtUsuario
        '
        Me.txtUsuario.Enabled = False
        Me.txtUsuario.Location = New System.Drawing.Point(54, 442)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(70, 21)
        Me.txtUsuario.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(136, 446)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Fecha Creacion"
        '
        'txtFechaCreacion
        '
        Me.txtFechaCreacion.Enabled = False
        Me.txtFechaCreacion.Location = New System.Drawing.Point(224, 443)
        Me.txtFechaCreacion.Name = "txtFechaCreacion"
        Me.txtFechaCreacion.Size = New System.Drawing.Size(69, 21)
        Me.txtFechaCreacion.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(307, 445)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Estado"
        '
        'cboEstado
        '
        Me.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEstado.FormattingEnabled = True
        Me.cboEstado.Location = New System.Drawing.Point(354, 442)
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.Size = New System.Drawing.Size(121, 21)
        Me.cboEstado.TabIndex = 6
        '
        'btnGuadar
        '
        Me.btnGuadar.Image = CType(resources.GetObject("btnGuadar.Image"), System.Drawing.Image)
        Me.btnGuadar.Location = New System.Drawing.Point(593, 438)
        Me.btnGuadar.Name = "btnGuadar"
        Me.btnGuadar.Size = New System.Drawing.Size(42, 28)
        Me.btnGuadar.TabIndex = 7
        Me.btnGuadar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(641, 437)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(42, 28)
        Me.btnSalir.TabIndex = 8
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'frmGestionArticulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(691, 482)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuadar)
        Me.Controls.Add(Me.cboEstado)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtFechaCreacion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmGestionArticulos"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestion de Articulos"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFechaCreacion As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cboEstado As ComboBox
    Friend WithEvents btnGuadar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cboPresentacion As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cboUnidad As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDes2 As TextBox
    Friend WithEvents txtDes As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cboFabricante As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cboPaisOrigen As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cboVidaUtil As ComboBox
    Friend WithEvents Label9 As Label
End Class
