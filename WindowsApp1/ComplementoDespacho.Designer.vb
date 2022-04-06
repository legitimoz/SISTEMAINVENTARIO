<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ComplementoDespacho
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
        Me.Cmb_Costos = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdAceptar = New FontAwesome.Sharp.IconButton()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_fisico = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmb_site = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_SitePicking = New System.Windows.Forms.ComboBox()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cmb_Costos
        '
        Me.Cmb_Costos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_Costos.FormattingEnabled = True
        Me.Cmb_Costos.Location = New System.Drawing.Point(114, 17)
        Me.Cmb_Costos.Name = "Cmb_Costos"
        Me.Cmb_Costos.Size = New System.Drawing.Size(212, 21)
        Me.Cmb_Costos.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Centro de Costos :"
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
        Me.cmdAceptar.Location = New System.Drawing.Point(225, 149)
        Me.cmdAceptar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.cmdAceptar.Size = New System.Drawing.Size(100, 26)
        Me.cmdAceptar.TabIndex = 148
        Me.cmdAceptar.Text = "Aceptar"
        Me.cmdAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdAceptar.UseVisualStyleBackColor = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 150
        Me.Label2.Text = "Fisico :"
        '
        'cmb_fisico
        '
        Me.cmb_fisico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_fisico.FormattingEnabled = True
        Me.cmb_fisico.Items.AddRange(New Object() {"SI", "NO"})
        Me.cmb_fisico.Location = New System.Drawing.Point(114, 44)
        Me.cmb_fisico.Name = "cmb_fisico"
        Me.cmb_fisico.Size = New System.Drawing.Size(212, 21)
        Me.cmb_fisico.TabIndex = 149
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 152
        Me.Label3.Text = "Site Liquidacion :"
        '
        'cmb_site
        '
        Me.cmb_site.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_site.FormattingEnabled = True
        Me.cmb_site.Location = New System.Drawing.Point(114, 71)
        Me.cmb_site.Name = "cmb_site"
        Me.cmb_site.Size = New System.Drawing.Size(212, 21)
        Me.cmb_site.TabIndex = 151
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 154
        Me.Label4.Text = "Site Picking :"
        '
        'cmb_SitePicking
        '
        Me.cmb_SitePicking.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_SitePicking.FormattingEnabled = True
        Me.cmb_SitePicking.Location = New System.Drawing.Point(113, 98)
        Me.cmb_SitePicking.Name = "cmb_SitePicking"
        Me.cmb_SitePicking.Size = New System.Drawing.Size(212, 21)
        Me.cmb_SitePicking.TabIndex = 153
        '
        'ComplementoDespacho
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(338, 188)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmb_SitePicking)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmb_site)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmb_fisico)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cmb_Costos)
        Me.MaximizeBox = False
        Me.Name = "ComplementoDespacho"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Complemento Costo"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Cmb_Costos As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmdAceptar As FontAwesome.Sharp.IconButton
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Label2 As Label
    Friend WithEvents cmb_fisico As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmb_site As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmb_SitePicking As ComboBox
End Class
