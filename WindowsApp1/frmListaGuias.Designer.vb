<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaGuias
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
        Me.dgvListarGuias = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtNroGuia = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpFecFin = New System.Windows.Forms.DateTimePicker()
        Me.dtpFecIni = New System.Windows.Forms.DateTimePicker()
        CType(Me.dgvListarGuias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvListarGuias
        '
        Me.dgvListarGuias.AllowUserToAddRows = False
        Me.dgvListarGuias.AllowUserToDeleteRows = False
        Me.dgvListarGuias.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvListarGuias.BackgroundColor = System.Drawing.Color.White
        Me.dgvListarGuias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListarGuias.Location = New System.Drawing.Point(6, 67)
        Me.dgvListarGuias.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvListarGuias.MultiSelect = False
        Me.dgvListarGuias.Name = "dgvListarGuias"
        Me.dgvListarGuias.ReadOnly = True
        Me.dgvListarGuias.RowTemplate.Height = 24
        Me.dgvListarGuias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListarGuias.Size = New System.Drawing.Size(595, 342)
        Me.dgvListarGuias.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtNroGuia)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtpFecFin)
        Me.GroupBox1.Controls.Add(Me.dtpFecIni)
        Me.GroupBox1.Controls.Add(Me.dgvListarGuias)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(606, 418)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'txtNroGuia
        '
        Me.txtNroGuia.Location = New System.Drawing.Point(73, 40)
        Me.txtNroGuia.Name = "txtNroGuia"
        Me.txtNroGuia.Size = New System.Drawing.Size(126, 21)
        Me.txtNroGuia.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Nro Guia"
        '
        'btnBuscar
        '
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.Image = Global.WindowsApp1.My.Resources.Resources._104
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscar.Location = New System.Drawing.Point(364, 11)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(85, 24)
        Me.btnBuscar.TabIndex = 8
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(190, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Fecha Fin"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Fecha Inicio"
        '
        'dtpFecFin
        '
        Me.dtpFecFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecFin.Location = New System.Drawing.Point(247, 13)
        Me.dtpFecFin.Name = "dtpFecFin"
        Me.dtpFecFin.Size = New System.Drawing.Size(87, 21)
        Me.dtpFecFin.TabIndex = 5
        '
        'dtpFecIni
        '
        Me.dtpFecIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecIni.Location = New System.Drawing.Point(73, 12)
        Me.dtpFecIni.Name = "dtpFecIni"
        Me.dtpFecIni.Size = New System.Drawing.Size(87, 21)
        Me.dtpFecIni.TabIndex = 4
        '
        'frmListaGuias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(613, 419)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmListaGuias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado Guias"
        CType(Me.dgvListarGuias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvListarGuias As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpFecFin As DateTimePicker
    Friend WithEvents dtpFecIni As DateTimePicker
    Friend WithEvents txtNroGuia As TextBox
    Friend WithEvents Label3 As Label
End Class
