<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistroRequerimiento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegistroRequerimiento))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNroReq = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAsunto = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rtbDescripcion = New System.Windows.Forms.RichTextBox()
        Me.Label45 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblCantCaracteres = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboSolicitante = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboEmpresas = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtFechaHoraReg = New System.Windows.Forms.TextBox()
        Me.lblCantidadFileAdjuntos = New System.Windows.Forms.Label()
        Me.dgvArchivosAdjuntos = New System.Windows.Forms.DataGridView()
        Me.btnAdjuntar = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fileName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rutas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvArchivosAdjuntos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Label45, Me.lblCantCaracteres})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 445)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(635, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nro Requerimiento"
        '
        'txtNroReq
        '
        Me.txtNroReq.BackColor = System.Drawing.Color.White
        Me.txtNroReq.Location = New System.Drawing.Point(110, 19)
        Me.txtNroReq.Name = "txtNroReq"
        Me.txtNroReq.ReadOnly = True
        Me.txtNroReq.Size = New System.Drawing.Size(101, 21)
        Me.txtNroReq.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Asunto"
        '
        'txtAsunto
        '
        Me.txtAsunto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAsunto.Location = New System.Drawing.Point(110, 69)
        Me.txtAsunto.MaxLength = 100
        Me.txtAsunto.Name = "txtAsunto"
        Me.txtAsunto.Size = New System.Drawing.Size(506, 21)
        Me.txtAsunto.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox1.Controls.Add(Me.txtFechaHoraReg)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cboEmpresas)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cboSolicitante)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btnCancelar)
        Me.GroupBox1.Controls.Add(Me.btnGuardar)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TabControl1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtAsunto)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtNroReq)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(625, 442)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(9, 114)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(611, 282)
        Me.TabControl1.TabIndex = 5
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.rtbDescripcion)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(603, 256)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Descripción"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lblCantidadFileAdjuntos)
        Me.TabPage2.Controls.Add(Me.dgvArchivosAdjuntos)
        Me.TabPage2.Controls.Add(Me.btnAdjuntar)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(603, 256)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Adjuntos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Descripcion"
        '
        'rtbDescripcion
        '
        Me.rtbDescripcion.Location = New System.Drawing.Point(6, 6)
        Me.rtbDescripcion.MaxLength = 8000
        Me.rtbDescripcion.Name = "rtbDescripcion"
        Me.rtbDescripcion.Size = New System.Drawing.Size(591, 244)
        Me.rtbDescripcion.TabIndex = 0
        Me.rtbDescripcion.Text = ""
        '
        'Label45
        '
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(60, 17)
        Me.Label45.Text = "Contador:"
        '
        'lblCantCaracteres
        '
        Me.lblCantCaracteres.Name = "lblCantCaracteres"
        Me.lblCantCaracteres.Size = New System.Drawing.Size(13, 17)
        Me.lblCantCaracteres.Text = "0"
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.White
        Me.btnCancelar.Image = Global.WindowsApp1.My.Resources.Resources.icon_delete_on1
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(314, 408)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(111, 23)
        Me.btnCancelar.TabIndex = 8
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.White
        Me.btnGuardar.Image = Global.WindowsApp1.My.Resources.Resources._003
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(179, 408)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(111, 23)
        Me.btnGuardar.TabIndex = 7
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Solicitante"
        '
        'cboSolicitante
        '
        Me.cboSolicitante.FormattingEnabled = True
        Me.cboSolicitante.Location = New System.Drawing.Point(110, 43)
        Me.cboSolicitante.Name = "cboSolicitante"
        Me.cboSolicitante.Size = New System.Drawing.Size(222, 21)
        Me.cboSolicitante.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(385, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Empresa"
        '
        'cboEmpresas
        '
        Me.cboEmpresas.BackColor = System.Drawing.Color.White
        Me.cboEmpresas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEmpresas.FormattingEnabled = True
        Me.cboEmpresas.Location = New System.Drawing.Point(435, 43)
        Me.cboEmpresas.Name = "cboEmpresas"
        Me.cboEmpresas.Size = New System.Drawing.Size(181, 21)
        Me.cboEmpresas.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(354, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Fecha Registro"
        '
        'txtFechaHoraReg
        '
        Me.txtFechaHoraReg.BackColor = System.Drawing.Color.White
        Me.txtFechaHoraReg.Location = New System.Drawing.Point(435, 19)
        Me.txtFechaHoraReg.Name = "txtFechaHoraReg"
        Me.txtFechaHoraReg.ReadOnly = True
        Me.txtFechaHoraReg.Size = New System.Drawing.Size(181, 21)
        Me.txtFechaHoraReg.TabIndex = 14
        '
        'lblCantidadFileAdjuntos
        '
        Me.lblCantidadFileAdjuntos.AutoSize = True
        Me.lblCantidadFileAdjuntos.ForeColor = System.Drawing.Color.Black
        Me.lblCantidadFileAdjuntos.Location = New System.Drawing.Point(69, 13)
        Me.lblCantidadFileAdjuntos.Name = "lblCantidadFileAdjuntos"
        Me.lblCantidadFileAdjuntos.Size = New System.Drawing.Size(13, 13)
        Me.lblCantidadFileAdjuntos.TabIndex = 36
        Me.lblCantidadFileAdjuntos.Text = "0"
        '
        'dgvArchivosAdjuntos
        '
        Me.dgvArchivosAdjuntos.AllowUserToAddRows = False
        Me.dgvArchivosAdjuntos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvArchivosAdjuntos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvArchivosAdjuntos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.fileName, Me.rutas})
        Me.dgvArchivosAdjuntos.Location = New System.Drawing.Point(6, 36)
        Me.dgvArchivosAdjuntos.Name = "dgvArchivosAdjuntos"
        Me.dgvArchivosAdjuntos.ReadOnly = True
        Me.dgvArchivosAdjuntos.RowHeadersVisible = False
        Me.dgvArchivosAdjuntos.Size = New System.Drawing.Size(591, 214)
        Me.dgvArchivosAdjuntos.TabIndex = 35
        '
        'btnAdjuntar
        '
        Me.btnAdjuntar.ForeColor = System.Drawing.Color.Black
        Me.btnAdjuntar.Image = CType(resources.GetObject("btnAdjuntar.Image"), System.Drawing.Image)
        Me.btnAdjuntar.Location = New System.Drawing.Point(6, 7)
        Me.btnAdjuntar.Name = "btnAdjuntar"
        Me.btnAdjuntar.Size = New System.Drawing.Size(54, 23)
        Me.btnAdjuntar.TabIndex = 34
        Me.btnAdjuntar.Text = ".."
        Me.btnAdjuntar.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nombre Archivo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 250
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Archivos Adjuntos"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 500
        '
        'fileName
        '
        Me.fileName.HeaderText = "Nombre Archivo"
        Me.fileName.Name = "fileName"
        Me.fileName.ReadOnly = True
        Me.fileName.Width = 250
        '
        'rutas
        '
        Me.rutas.HeaderText = "Archivos Adjuntos"
        Me.rutas.Name = "rutas"
        Me.rutas.ReadOnly = True
        Me.rutas.Width = 500
        '
        'frmRegistroRequerimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(635, 467)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRegistroRequerimiento"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro Requerimiento"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dgvArchivosAdjuntos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNroReq As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAsunto As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents rtbDescripcion As RichTextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents Label45 As ToolStripStatusLabel
    Friend WithEvents lblCantCaracteres As ToolStripStatusLabel
    Friend WithEvents cboSolicitante As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cboEmpresas As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtFechaHoraReg As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lblCantidadFileAdjuntos As Label
    Friend WithEvents dgvArchivosAdjuntos As DataGridView
    Friend WithEvents fileName As DataGridViewTextBoxColumn
    Friend WithEvents rutas As DataGridViewTextBoxColumn
    Friend WithEvents btnAdjuntar As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
End Class
