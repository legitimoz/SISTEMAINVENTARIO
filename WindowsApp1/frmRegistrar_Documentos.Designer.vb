<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistrar_Documentos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegistrar_Documentos))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_f5_cnumdoc = New System.Windows.Forms.Label()
        Me.lbl_f5_cnumser = New System.Windows.Forms.Label()
        Me.lbl_f5_ctd = New System.Windows.Forms.Label()
        Me.lbl_f5_ccodage = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbxRutasDestino = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblCantidadFileAdjuntos = New System.Windows.Forms.Label()
        Me.lblc5_ctd = New System.Windows.Forms.Label()
        Me.lblc5_alma = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.dgvArchivosAdjuntos = New System.Windows.Forms.DataGridView()
        Me.fileName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rutas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAdjuntar = New System.Windows.Forms.Button()
        Me.txtFecRegistro = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.txtNroDocumento = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbxTipDoc = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbxArea = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvArchivosAdjuntos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.lbl_f5_cnumdoc)
        Me.GroupBox1.Controls.Add(Me.lbl_f5_cnumser)
        Me.GroupBox1.Controls.Add(Me.lbl_f5_ctd)
        Me.GroupBox1.Controls.Add(Me.lbl_f5_ccodage)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.cbxRutasDestino)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.lblCantidadFileAdjuntos)
        Me.GroupBox1.Controls.Add(Me.lblc5_ctd)
        Me.GroupBox1.Controls.Add(Me.lblc5_alma)
        Me.GroupBox1.Controls.Add(Me.btnCancelar)
        Me.GroupBox1.Controls.Add(Me.btnGuardar)
        Me.GroupBox1.Controls.Add(Me.dgvArchivosAdjuntos)
        Me.GroupBox1.Controls.Add(Me.btnAdjuntar)
        Me.GroupBox1.Controls.Add(Me.txtFecRegistro)
        Me.GroupBox1.Controls.Add(Me.txtUsuario)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtDescripcion)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.btnConsultar)
        Me.GroupBox1.Controls.Add(Me.txtNroDocumento)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cbxTipDoc)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cbxArea)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtCodigo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(644, 490)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'lbl_f5_cnumdoc
        '
        Me.lbl_f5_cnumdoc.AutoSize = True
        Me.lbl_f5_cnumdoc.Location = New System.Drawing.Point(512, 106)
        Me.lbl_f5_cnumdoc.Name = "lbl_f5_cnumdoc"
        Me.lbl_f5_cnumdoc.Size = New System.Drawing.Size(76, 13)
        Me.lbl_f5_cnumdoc.TabIndex = 40
        Me.lbl_f5_cnumdoc.Text = "F5_CNUMDOC"
        '
        'lbl_f5_cnumser
        '
        Me.lbl_f5_cnumser.AutoSize = True
        Me.lbl_f5_cnumser.Location = New System.Drawing.Point(441, 106)
        Me.lbl_f5_cnumser.Name = "lbl_f5_cnumser"
        Me.lbl_f5_cnumser.Size = New System.Drawing.Size(73, 13)
        Me.lbl_f5_cnumser.TabIndex = 39
        Me.lbl_f5_cnumser.Text = "F5_CNUMSER"
        '
        'lbl_f5_ctd
        '
        Me.lbl_f5_ctd.AutoSize = True
        Me.lbl_f5_ctd.Location = New System.Drawing.Point(398, 106)
        Me.lbl_f5_ctd.Name = "lbl_f5_ctd"
        Me.lbl_f5_ctd.Size = New System.Drawing.Size(45, 13)
        Me.lbl_f5_ctd.TabIndex = 38
        Me.lbl_f5_ctd.Text = "F5_CTD"
        '
        'lbl_f5_ccodage
        '
        Me.lbl_f5_ccodage.AutoSize = True
        Me.lbl_f5_ccodage.Location = New System.Drawing.Point(326, 106)
        Me.lbl_f5_ccodage.Name = "lbl_f5_ccodage"
        Me.lbl_f5_ccodage.Size = New System.Drawing.Size(74, 13)
        Me.lbl_f5_ccodage.TabIndex = 37
        Me.lbl_f5_ccodage.Text = "F5_CCODAGE"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(100, 134)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(11, 13)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = ":"
        '
        'cbxRutasDestino
        '
        Me.cbxRutasDestino.BackColor = System.Drawing.Color.White
        Me.cbxRutasDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxRutasDestino.FormattingEnabled = True
        Me.cbxRutasDestino.Location = New System.Drawing.Point(116, 130)
        Me.cbxRutasDestino.Name = "cbxRutasDestino"
        Me.cbxRutasDestino.Size = New System.Drawing.Size(509, 21)
        Me.cbxRutasDestino.TabIndex = 35
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 134)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 13)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Rutas Destino"
        '
        'lblCantidadFileAdjuntos
        '
        Me.lblCantidadFileAdjuntos.AutoSize = True
        Me.lblCantidadFileAdjuntos.ForeColor = System.Drawing.Color.Black
        Me.lblCantidadFileAdjuntos.Location = New System.Drawing.Point(178, 291)
        Me.lblCantidadFileAdjuntos.Name = "lblCantidadFileAdjuntos"
        Me.lblCantidadFileAdjuntos.Size = New System.Drawing.Size(13, 13)
        Me.lblCantidadFileAdjuntos.TabIndex = 33
        Me.lblCantidadFileAdjuntos.Text = "0"
        '
        'lblc5_ctd
        '
        Me.lblc5_ctd.AutoSize = True
        Me.lblc5_ctd.Location = New System.Drawing.Point(377, 84)
        Me.lblc5_ctd.Name = "lblc5_ctd"
        Me.lblc5_ctd.Size = New System.Drawing.Size(46, 13)
        Me.lblc5_ctd.TabIndex = 32
        Me.lblc5_ctd.Text = "C5_CTD"
        '
        'lblc5_alma
        '
        Me.lblc5_alma.AutoSize = True
        Me.lblc5_alma.Location = New System.Drawing.Point(325, 84)
        Me.lblc5_alma.Name = "lblc5_alma"
        Me.lblc5_alma.Size = New System.Drawing.Size(53, 13)
        Me.lblc5_alma.TabIndex = 31
        Me.lblc5_alma.Text = "C5_ALMA"
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = Global.WindowsApp1.My.Resources.Resources.icon_delete_on
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.Location = New System.Drawing.Point(345, 455)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(112, 23)
        Me.btnCancelar.TabIndex = 30
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = Global.WindowsApp1.My.Resources.Resources._003
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.Location = New System.Drawing.Point(193, 455)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(112, 23)
        Me.btnGuardar.TabIndex = 29
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'dgvArchivosAdjuntos
        '
        Me.dgvArchivosAdjuntos.AllowUserToAddRows = False
        Me.dgvArchivosAdjuntos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvArchivosAdjuntos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvArchivosAdjuntos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.fileName, Me.rutas})
        Me.dgvArchivosAdjuntos.Location = New System.Drawing.Point(115, 314)
        Me.dgvArchivosAdjuntos.Name = "dgvArchivosAdjuntos"
        Me.dgvArchivosAdjuntos.ReadOnly = True
        Me.dgvArchivosAdjuntos.RowHeadersVisible = False
        Me.dgvArchivosAdjuntos.Size = New System.Drawing.Size(513, 115)
        Me.dgvArchivosAdjuntos.TabIndex = 28
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
        'btnAdjuntar
        '
        Me.btnAdjuntar.ForeColor = System.Drawing.Color.Black
        Me.btnAdjuntar.Image = CType(resources.GetObject("btnAdjuntar.Image"), System.Drawing.Image)
        Me.btnAdjuntar.Location = New System.Drawing.Point(115, 285)
        Me.btnAdjuntar.Name = "btnAdjuntar"
        Me.btnAdjuntar.Size = New System.Drawing.Size(54, 23)
        Me.btnAdjuntar.TabIndex = 27
        Me.btnAdjuntar.Text = ".."
        Me.btnAdjuntar.UseVisualStyleBackColor = True
        '
        'txtFecRegistro
        '
        Me.txtFecRegistro.Location = New System.Drawing.Point(497, 38)
        Me.txtFecRegistro.Name = "txtFecRegistro"
        Me.txtFecRegistro.Size = New System.Drawing.Size(129, 21)
        Me.txtFecRegistro.TabIndex = 26
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(497, 14)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(129, 21)
        Me.txtUsuario.TabIndex = 25
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(480, 42)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(11, 13)
        Me.Label18.TabIndex = 24
        Me.Label18.Text = ":"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(480, 17)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(11, 13)
        Me.Label17.TabIndex = 23
        Me.Label17.Text = ":"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(419, 42)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(62, 13)
        Me.Label16.TabIndex = 22
        Me.Label16.Text = "Fecha Reg."
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(419, 17)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(43, 13)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "Usuario"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(100, 290)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(11, 13)
        Me.Label14.TabIndex = 20
        Me.Label14.Text = ":"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(12, 289)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(88, 13)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "Adjuntar Archivo"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(116, 163)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(510, 111)
        Me.txtDescripcion.TabIndex = 18
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(100, 160)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(11, 13)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = ":"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(16, 160)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 13)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Observación"
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(284, 101)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(27, 23)
        Me.btnConsultar.TabIndex = 12
        Me.btnConsultar.Text = "..."
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'txtNroDocumento
        '
        Me.txtNroDocumento.Location = New System.Drawing.Point(116, 102)
        Me.txtNroDocumento.Name = "txtNroDocumento"
        Me.txtNroDocumento.ReadOnly = True
        Me.txtNroDocumento.Size = New System.Drawing.Size(163, 21)
        Me.txtNroDocumento.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(100, 107)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(11, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = ":"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 107)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Nro Documento"
        '
        'cbxTipDoc
        '
        Me.cbxTipDoc.BackColor = System.Drawing.Color.White
        Me.cbxTipDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTipDoc.FormattingEnabled = True
        Me.cbxTipDoc.Location = New System.Drawing.Point(116, 71)
        Me.cbxTipDoc.Name = "cbxTipDoc"
        Me.cbxTipDoc.Size = New System.Drawing.Size(164, 21)
        Me.cbxTipDoc.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(100, 76)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(11, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = ":"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Tipo Documento"
        '
        'cbxArea
        '
        Me.cbxArea.BackColor = System.Drawing.Color.White
        Me.cbxArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxArea.FormattingEnabled = True
        Me.cbxArea.Location = New System.Drawing.Point(115, 41)
        Me.cbxArea.Name = "cbxArea"
        Me.cbxArea.Size = New System.Drawing.Size(164, 21)
        Me.cbxArea.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(98, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(11, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = ":"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(98, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(11, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = ":"
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(115, 14)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(100, 21)
        Me.txtCodigo.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Area"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 497)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(656, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
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
        'frmRegistrar_Documentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(656, 519)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRegistrar_Documentos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar Documentos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvArchivosAdjuntos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbxTipDoc As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cbxArea As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btnConsultar As Button
    Friend WithEvents txtNroDocumento As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtFecRegistro As TextBox
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents dgvArchivosAdjuntos As DataGridView
    Friend WithEvents fileName As DataGridViewTextBoxColumn
    Friend WithEvents rutas As DataGridViewTextBoxColumn
    Friend WithEvents btnAdjuntar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents lblc5_ctd As Label
    Friend WithEvents lblc5_alma As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents lblCantidadFileAdjuntos As Label
    Friend WithEvents cbxRutasDestino As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lbl_f5_cnumdoc As Label
    Friend WithEvents lbl_f5_cnumser As Label
    Friend WithEvents lbl_f5_ctd As Label
    Friend WithEvents lbl_f5_ccodage As Label
End Class
