<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Ruta
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
        Me.LIMA = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btn_moverOeste1 = New FontAwesome.Sharp.IconButton()
        Me.btn_moverOeste = New FontAwesome.Sharp.IconButton()
        Me.btn_moverCentro = New FontAwesome.Sharp.IconButton()
        Me.btn_moverSur = New FontAwesome.Sharp.IconButton()
        Me.btn_moverNorte = New FontAwesome.Sharp.IconButton()
        Me.Dg_NORTE = New System.Windows.Forms.DataGridView()
        Me.DG_SUR = New System.Windows.Forms.DataGridView()
        Me.DG_CENTRO = New System.Windows.Forms.DataGridView()
        Me.DG_OESTE = New System.Windows.Forms.DataGridView()
        Me.DG_OESTE1 = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.LIMA.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.Dg_NORTE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_SUR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_CENTRO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_OESTE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_OESTE1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LIMA
        '
        Me.LIMA.Controls.Add(Me.TabPage1)
        Me.LIMA.Controls.Add(Me.TabPage2)
        Me.LIMA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LIMA.Location = New System.Drawing.Point(0, 0)
        Me.LIMA.Name = "LIMA"
        Me.LIMA.SelectedIndex = 0
        Me.LIMA.Size = New System.Drawing.Size(1311, 749)
        Me.LIMA.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btn_moverOeste1)
        Me.TabPage1.Controls.Add(Me.btn_moverOeste)
        Me.TabPage1.Controls.Add(Me.btn_moverCentro)
        Me.TabPage1.Controls.Add(Me.btn_moverSur)
        Me.TabPage1.Controls.Add(Me.btn_moverNorte)
        Me.TabPage1.Controls.Add(Me.Dg_NORTE)
        Me.TabPage1.Controls.Add(Me.DG_SUR)
        Me.TabPage1.Controls.Add(Me.DG_CENTRO)
        Me.TabPage1.Controls.Add(Me.DG_OESTE)
        Me.TabPage1.Controls.Add(Me.DG_OESTE1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1303, 723)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "LIMA"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btn_moverOeste1
        '
        Me.btn_moverOeste1.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btn_moverOeste1.IconColor = System.Drawing.Color.Black
        Me.btn_moverOeste1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_moverOeste1.Location = New System.Drawing.Point(1246, 567)
        Me.btn_moverOeste1.Name = "btn_moverOeste1"
        Me.btn_moverOeste1.Size = New System.Drawing.Size(45, 39)
        Me.btn_moverOeste1.TabIndex = 13
        Me.btn_moverOeste1.Text = "Mover"
        Me.btn_moverOeste1.UseVisualStyleBackColor = True
        Me.btn_moverOeste1.Visible = False
        '
        'btn_moverOeste
        '
        Me.btn_moverOeste.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btn_moverOeste.IconColor = System.Drawing.Color.Black
        Me.btn_moverOeste.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_moverOeste.Location = New System.Drawing.Point(1246, 438)
        Me.btn_moverOeste.Name = "btn_moverOeste"
        Me.btn_moverOeste.Size = New System.Drawing.Size(45, 39)
        Me.btn_moverOeste.TabIndex = 12
        Me.btn_moverOeste.Text = "Mover"
        Me.btn_moverOeste.UseVisualStyleBackColor = True
        Me.btn_moverOeste.Visible = False
        '
        'btn_moverCentro
        '
        Me.btn_moverCentro.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btn_moverCentro.IconColor = System.Drawing.Color.Black
        Me.btn_moverCentro.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_moverCentro.Location = New System.Drawing.Point(1246, 309)
        Me.btn_moverCentro.Name = "btn_moverCentro"
        Me.btn_moverCentro.Size = New System.Drawing.Size(45, 39)
        Me.btn_moverCentro.TabIndex = 11
        Me.btn_moverCentro.Text = "Mover"
        Me.btn_moverCentro.UseVisualStyleBackColor = True
        Me.btn_moverCentro.Visible = False
        '
        'btn_moverSur
        '
        Me.btn_moverSur.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btn_moverSur.IconColor = System.Drawing.Color.Black
        Me.btn_moverSur.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_moverSur.Location = New System.Drawing.Point(1246, 180)
        Me.btn_moverSur.Name = "btn_moverSur"
        Me.btn_moverSur.Size = New System.Drawing.Size(45, 39)
        Me.btn_moverSur.TabIndex = 10
        Me.btn_moverSur.Text = "Mover"
        Me.btn_moverSur.UseVisualStyleBackColor = True
        Me.btn_moverSur.Visible = False
        '
        'btn_moverNorte
        '
        Me.btn_moverNorte.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btn_moverNorte.IconColor = System.Drawing.Color.Black
        Me.btn_moverNorte.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_moverNorte.Location = New System.Drawing.Point(1246, 51)
        Me.btn_moverNorte.Name = "btn_moverNorte"
        Me.btn_moverNorte.Size = New System.Drawing.Size(45, 39)
        Me.btn_moverNorte.TabIndex = 9
        Me.btn_moverNorte.Text = "Mover"
        Me.btn_moverNorte.UseVisualStyleBackColor = True
        Me.btn_moverNorte.Visible = False
        '
        'Dg_NORTE
        '
        Me.Dg_NORTE.AllowUserToAddRows = False
        Me.Dg_NORTE.BackgroundColor = System.Drawing.Color.White
        Me.Dg_NORTE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dg_NORTE.Location = New System.Drawing.Point(8, 51)
        Me.Dg_NORTE.Margin = New System.Windows.Forms.Padding(0)
        Me.Dg_NORTE.Name = "Dg_NORTE"
        Me.Dg_NORTE.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dg_NORTE.Size = New System.Drawing.Size(1232, 123)
        Me.Dg_NORTE.TabIndex = 8
        '
        'DG_SUR
        '
        Me.DG_SUR.AllowUserToAddRows = False
        Me.DG_SUR.BackgroundColor = System.Drawing.Color.White
        Me.DG_SUR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_SUR.Location = New System.Drawing.Point(8, 180)
        Me.DG_SUR.Name = "DG_SUR"
        Me.DG_SUR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_SUR.Size = New System.Drawing.Size(1232, 123)
        Me.DG_SUR.TabIndex = 7
        Me.DG_SUR.Visible = False
        '
        'DG_CENTRO
        '
        Me.DG_CENTRO.AllowUserToAddRows = False
        Me.DG_CENTRO.BackgroundColor = System.Drawing.Color.White
        Me.DG_CENTRO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_CENTRO.Location = New System.Drawing.Point(8, 309)
        Me.DG_CENTRO.Name = "DG_CENTRO"
        Me.DG_CENTRO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_CENTRO.Size = New System.Drawing.Size(1232, 123)
        Me.DG_CENTRO.TabIndex = 6
        Me.DG_CENTRO.Visible = False
        '
        'DG_OESTE
        '
        Me.DG_OESTE.AllowUserToAddRows = False
        Me.DG_OESTE.BackgroundColor = System.Drawing.Color.White
        Me.DG_OESTE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_OESTE.Location = New System.Drawing.Point(8, 438)
        Me.DG_OESTE.Name = "DG_OESTE"
        Me.DG_OESTE.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_OESTE.Size = New System.Drawing.Size(1232, 123)
        Me.DG_OESTE.TabIndex = 5
        Me.DG_OESTE.Visible = False
        '
        'DG_OESTE1
        '
        Me.DG_OESTE1.AllowUserToAddRows = False
        Me.DG_OESTE1.BackgroundColor = System.Drawing.Color.White
        Me.DG_OESTE1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_OESTE1.Location = New System.Drawing.Point(8, 567)
        Me.DG_OESTE1.Name = "DG_OESTE1"
        Me.DG_OESTE1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_OESTE1.Size = New System.Drawing.Size(1232, 123)
        Me.DG_OESTE1.TabIndex = 4
        Me.DG_OESTE1.Visible = False
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1303, 723)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "PROVINCIA"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Ruta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1311, 749)
        Me.Controls.Add(Me.LIMA)
        Me.Name = "Ruta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ruta"
        Me.LIMA.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.Dg_NORTE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG_SUR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG_CENTRO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG_OESTE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG_OESTE1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LIMA As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents DG_OESTE1 As DataGridView
    Friend WithEvents DG_CENTRO As DataGridView
    Friend WithEvents DG_OESTE As DataGridView
    Friend WithEvents Dg_NORTE As DataGridView
    Friend WithEvents btn_moverNorte As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_moverOeste1 As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_moverOeste As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_moverCentro As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_moverSur As FontAwesome.Sharp.IconButton
    Friend WithEvents DG_SUR As DataGridView
End Class
