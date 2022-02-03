<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistrarRuta
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblNroRuta = New System.Windows.Forms.Label()
        Me.txtNroGuia = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpFecRuta = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbxTransportista = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvGuiaRuta = New System.Windows.Forms.DataGridView()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tslCantTotal = New System.Windows.Forms.ToolStripStatusLabel()
        Me.C5_CALMA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C5_CTD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C5_CNUMDOC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rl_cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rl_departamento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rl_provincia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rl_distrito = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rl_direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EST_CODIGO2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.peso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bulto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvGuiaRuta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.DarkRed
        Me.GroupBox1.Controls.Add(Me.lblNroRuta)
        Me.GroupBox1.Controls.Add(Me.txtNroGuia)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.dtpFecRuta)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cbxTransportista)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(3, 4)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(836, 136)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'lblNroRuta
        '
        Me.lblNroRuta.AutoSize = True
        Me.lblNroRuta.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNroRuta.Location = New System.Drawing.Point(110, 17)
        Me.lblNroRuta.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNroRuta.Name = "lblNroRuta"
        Me.lblNroRuta.Size = New System.Drawing.Size(39, 19)
        Me.lblNroRuta.TabIndex = 11
        Me.lblNroRuta.Text = "000"
        '
        'txtNroGuia
        '
        Me.txtNroGuia.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroGuia.Location = New System.Drawing.Point(112, 97)
        Me.txtNroGuia.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNroGuia.Name = "txtNroGuia"
        Me.txtNroGuia.Size = New System.Drawing.Size(217, 32)
        Me.txtNroGuia.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(87, 103)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(13, 17)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = ":"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 103)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 17)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Nro Guia"
        '
        'dtpFecRuta
        '
        Me.dtpFecRuta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecRuta.Location = New System.Drawing.Point(113, 69)
        Me.dtpFecRuta.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpFecRuta.Name = "dtpFecRuta"
        Me.dtpFecRuta.Size = New System.Drawing.Size(98, 24)
        Me.dtpFecRuta.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(87, 71)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(13, 17)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = ":"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 71)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Fecha Ruta"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(87, 42)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(13, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = ":"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(88, 20)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = ":"
        '
        'cbxTransportista
        '
        Me.cbxTransportista.BackColor = System.Drawing.Color.White
        Me.cbxTransportista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTransportista.FormattingEnabled = True
        Me.cbxTransportista.Location = New System.Drawing.Point(112, 41)
        Me.cbxTransportista.Margin = New System.Windows.Forms.Padding(2)
        Me.cbxTransportista.Name = "cbxTransportista"
        Me.cbxTransportista.Size = New System.Drawing.Size(322, 25)
        Me.cbxTransportista.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 43)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Transportista"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 19)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nro Ruta"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.dgvGuiaRuta)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 146)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(836, 398)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Lista de Guías"
        '
        'dgvGuiaRuta
        '
        Me.dgvGuiaRuta.AllowUserToAddRows = False
        Me.dgvGuiaRuta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvGuiaRuta.BackgroundColor = System.Drawing.Color.White
        Me.dgvGuiaRuta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGuiaRuta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.C5_CALMA, Me.C5_CTD, Me.C5_CNUMDOC, Me.rl_cliente, Me.rl_departamento, Me.rl_provincia, Me.rl_distrito, Me.rl_direccion, Me.EST_CODIGO2, Me.peso, Me.bulto})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvGuiaRuta.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvGuiaRuta.Location = New System.Drawing.Point(6, 17)
        Me.dgvGuiaRuta.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvGuiaRuta.Name = "dgvGuiaRuta"
        Me.dgvGuiaRuta.RowTemplate.Height = 24
        Me.dgvGuiaRuta.Size = New System.Drawing.Size(825, 376)
        Me.dgvGuiaRuta.TabIndex = 0
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.Image = Global.WindowsApp1.My.Resources.Resources.icon_delete_on
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.Location = New System.Drawing.Point(438, 550)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(115, 32)
        Me.btnCancelar.TabIndex = 4
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.Image = Global.WindowsApp1.My.Resources.Resources._003
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.Location = New System.Drawing.Point(272, 550)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(115, 32)
        Me.btnGuardar.TabIndex = 3
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.tslCantTotal})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 587)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 10, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(848, 22)
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(67, 17)
        Me.ToolStripStatusLabel1.Text = "Total Guias:"
        '
        'tslCantTotal
        '
        Me.tslCantTotal.Name = "tslCantTotal"
        Me.tslCantTotal.Size = New System.Drawing.Size(13, 17)
        Me.tslCantTotal.Text = "0"
        '
        'C5_CALMA
        '
        Me.C5_CALMA.HeaderText = "C5_CALMA"
        Me.C5_CALMA.Name = "C5_CALMA"
        Me.C5_CALMA.Visible = False
        '
        'C5_CTD
        '
        Me.C5_CTD.HeaderText = "C5_CTD"
        Me.C5_CTD.Name = "C5_CTD"
        Me.C5_CTD.Visible = False
        '
        'C5_CNUMDOC
        '
        Me.C5_CNUMDOC.HeaderText = "Nro Guia"
        Me.C5_CNUMDOC.Name = "C5_CNUMDOC"
        Me.C5_CNUMDOC.Width = 80
        '
        'rl_cliente
        '
        Me.rl_cliente.FillWeight = 300.0!
        Me.rl_cliente.HeaderText = "Cliente"
        Me.rl_cliente.Name = "rl_cliente"
        Me.rl_cliente.Width = 350
        '
        'rl_departamento
        '
        Me.rl_departamento.HeaderText = "Departamento"
        Me.rl_departamento.Name = "rl_departamento"
        Me.rl_departamento.Width = 60
        '
        'rl_provincia
        '
        Me.rl_provincia.HeaderText = "Provincia"
        Me.rl_provincia.Name = "rl_provincia"
        Me.rl_provincia.Width = 60
        '
        'rl_distrito
        '
        Me.rl_distrito.HeaderText = "Disitrito"
        Me.rl_distrito.Name = "rl_distrito"
        Me.rl_distrito.Width = 70
        '
        'rl_direccion
        '
        Me.rl_direccion.HeaderText = "Direccion"
        Me.rl_direccion.Name = "rl_direccion"
        Me.rl_direccion.Width = 500
        '
        'EST_CODIGO2
        '
        Me.EST_CODIGO2.HeaderText = "Estado Guía"
        Me.EST_CODIGO2.Name = "EST_CODIGO2"
        Me.EST_CODIGO2.Width = 120
        '
        'peso
        '
        Me.peso.HeaderText = "Peso"
        Me.peso.Name = "peso"
        '
        'bulto
        '
        Me.bulto.HeaderText = "Bulto"
        Me.bulto.Name = "bulto"
        '
        'frmRegistrarRuta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(848, 609)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmRegistrarRuta"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar Ruta"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvGuiaRuta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtNroGuia As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents dtpFecRuta As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cbxTransportista As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents dgvGuiaRuta As DataGridView
    Friend WithEvents lblNroRuta As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents tslCantTotal As ToolStripStatusLabel
    Friend WithEvents C5_CALMA As DataGridViewTextBoxColumn
    Friend WithEvents C5_CTD As DataGridViewTextBoxColumn
    Friend WithEvents C5_CNUMDOC As DataGridViewTextBoxColumn
    Friend WithEvents rl_cliente As DataGridViewTextBoxColumn
    Friend WithEvents rl_departamento As DataGridViewTextBoxColumn
    Friend WithEvents rl_provincia As DataGridViewTextBoxColumn
    Friend WithEvents rl_distrito As DataGridViewTextBoxColumn
    Friend WithEvents rl_direccion As DataGridViewTextBoxColumn
    Friend WithEvents EST_CODIGO2 As DataGridViewTextBoxColumn
    Friend WithEvents peso As DataGridViewTextBoxColumn
    Friend WithEvents bulto As DataGridViewTextBoxColumn
End Class
