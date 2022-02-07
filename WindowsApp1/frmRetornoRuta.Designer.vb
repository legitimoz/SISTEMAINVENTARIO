<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRetornoRuta
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblFechaRuta = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblTrans = New System.Windows.Forms.Label()
        Me.lblRuta = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbxMotivos = New System.Windows.Forms.ComboBox()
        Me.rbtRechazado = New System.Windows.Forms.RadioButton()
        Me.rbtEntregado = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvRetornoRuta = New System.Windows.Forms.DataGridView()
        Me.C5_CNUMDOC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C5_CNOMCLI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DE_CDEPT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DE_CPROV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TG_CDESCRI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C5_CDIRENV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.color1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EST_CODIGO2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.motivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EST_CODIGO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHA_SALIDARUTA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.USUARIO_SALIDARUTA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHA_RETORNORUTA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.USUARIO_RETORNORUTA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaRecepCliente = New WindowsApp1.DateTimeGridColumn()
        Me.fechaInterFactura = New WindowsApp1.DateTimeGridColumn()
        Me.fecha_vto_oc = New WindowsApp1.DateTimeGridColumn()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtGuia = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateTimeGridColumn1 = New WindowsApp1.DateTimeGridColumn()
        Me.DateTimeGridColumn2 = New WindowsApp1.DateTimeGridColumn()
        Me.DateTimeGridColumn3 = New WindowsApp1.DateTimeGridColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvRetornoRuta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.DarkRed
        Me.GroupBox1.Controls.Add(Me.lblFechaRuta)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.lblTrans)
        Me.GroupBox1.Controls.Add(Me.lblRuta)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(4, 2)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(999, 63)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'lblFechaRuta
        '
        Me.lblFechaRuta.AutoSize = True
        Me.lblFechaRuta.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaRuta.Location = New System.Drawing.Point(581, 15)
        Me.lblFechaRuta.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFechaRuta.Name = "lblFechaRuta"
        Me.lblFechaRuta.Size = New System.Drawing.Size(80, 13)
        Me.lblFechaRuta.TabIndex = 14
        Me.lblFechaRuta.Text = "lblFechaRuta"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(565, 15)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(11, 14)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = ":"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(475, 15)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 13)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "FECHA RUTA"
        '
        'lblTrans
        '
        Me.lblTrans.AutoSize = True
        Me.lblTrans.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTrans.Location = New System.Drawing.Point(156, 43)
        Me.lblTrans.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTrans.Name = "lblTrans"
        Me.lblTrans.Size = New System.Drawing.Size(97, 13)
        Me.lblTrans.TabIndex = 11
        Me.lblTrans.Text = "lblTransportista"
        '
        'lblRuta
        '
        Me.lblRuta.AutoSize = True
        Me.lblRuta.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRuta.Location = New System.Drawing.Point(156, 15)
        Me.lblRuta.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRuta.Name = "lblRuta"
        Me.lblRuta.Size = New System.Drawing.Size(62, 18)
        Me.lblRuta.TabIndex = 10
        Me.lblRuta.Text = "lblRuta"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(136, 15)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(11, 14)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = ":"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(136, 43)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(11, 14)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = ":"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 43)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "TRANSPORTISTA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 17)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 14)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "NRO RUTA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(311, 31)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 14)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "MOTIVO"
        '
        'cbxMotivos
        '
        Me.cbxMotivos.BackColor = System.Drawing.Color.White
        Me.cbxMotivos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxMotivos.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxMotivos.FormattingEnabled = True
        Me.cbxMotivos.Location = New System.Drawing.Point(383, 24)
        Me.cbxMotivos.Margin = New System.Windows.Forms.Padding(2)
        Me.cbxMotivos.Name = "cbxMotivos"
        Me.cbxMotivos.Size = New System.Drawing.Size(251, 25)
        Me.cbxMotivos.TabIndex = 2
        '
        'rbtRechazado
        '
        Me.rbtRechazado.AutoSize = True
        Me.rbtRechazado.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtRechazado.Location = New System.Drawing.Point(151, 28)
        Me.rbtRechazado.Margin = New System.Windows.Forms.Padding(2)
        Me.rbtRechazado.Name = "rbtRechazado"
        Me.rbtRechazado.Size = New System.Drawing.Size(101, 18)
        Me.rbtRechazado.TabIndex = 1
        Me.rbtRechazado.TabStop = True
        Me.rbtRechazado.Text = "RECHAZADO"
        Me.rbtRechazado.UseVisualStyleBackColor = True
        '
        'rbtEntregado
        '
        Me.rbtEntregado.AutoSize = True
        Me.rbtEntregado.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtEntregado.Location = New System.Drawing.Point(23, 28)
        Me.rbtEntregado.Margin = New System.Windows.Forms.Padding(2)
        Me.rbtEntregado.Name = "rbtEntregado"
        Me.rbtEntregado.Size = New System.Drawing.Size(98, 18)
        Me.rbtEntregado.TabIndex = 0
        Me.rbtEntregado.TabStop = True
        Me.rbtEntregado.Text = "ENTREGADO"
        Me.rbtEntregado.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.dgvRetornoRuta)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 208)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(978, 402)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Listado Guias Validadas"
        '
        'dgvRetornoRuta
        '
        Me.dgvRetornoRuta.AllowUserToAddRows = False
        Me.dgvRetornoRuta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvRetornoRuta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRetornoRuta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.C5_CNUMDOC, Me.C5_CNOMCLI, Me.DE_CDEPT, Me.DE_CPROV, Me.TG_CDESCRI, Me.C5_CDIRENV, Me.color1, Me.EST_CODIGO2, Me.motivo, Me.EST_CODIGO, Me.FECHA_SALIDARUTA, Me.USUARIO_SALIDARUTA, Me.FECHA_RETORNORUTA, Me.USUARIO_RETORNORUTA, Me.fechaRecepCliente, Me.fechaInterFactura, Me.fecha_vto_oc})
        Me.dgvRetornoRuta.Location = New System.Drawing.Point(5, 19)
        Me.dgvRetornoRuta.Name = "dgvRetornoRuta"
        Me.dgvRetornoRuta.Size = New System.Drawing.Size(968, 378)
        Me.dgvRetornoRuta.TabIndex = 2
        '
        'C5_CNUMDOC
        '
        Me.C5_CNUMDOC.HeaderText = "Guia"
        Me.C5_CNUMDOC.Name = "C5_CNUMDOC"
        Me.C5_CNUMDOC.Width = 110
        '
        'C5_CNOMCLI
        '
        Me.C5_CNOMCLI.HeaderText = "Cliente"
        Me.C5_CNOMCLI.Name = "C5_CNOMCLI"
        Me.C5_CNOMCLI.Width = 250
        '
        'DE_CDEPT
        '
        Me.DE_CDEPT.HeaderText = "Departamento"
        Me.DE_CDEPT.Name = "DE_CDEPT"
        Me.DE_CDEPT.Width = 70
        '
        'DE_CPROV
        '
        Me.DE_CPROV.HeaderText = "Provincia"
        Me.DE_CPROV.Name = "DE_CPROV"
        '
        'TG_CDESCRI
        '
        Me.TG_CDESCRI.HeaderText = "Distrito"
        Me.TG_CDESCRI.Name = "TG_CDESCRI"
        Me.TG_CDESCRI.Width = 70
        '
        'C5_CDIRENV
        '
        Me.C5_CDIRENV.HeaderText = "Dirección"
        Me.C5_CDIRENV.Name = "C5_CDIRENV"
        '
        'color1
        '
        Me.color1.HeaderText = "Semaforo"
        Me.color1.Name = "color1"
        Me.color1.Width = 75
        '
        'EST_CODIGO2
        '
        Me.EST_CODIGO2.HeaderText = "Estado Guía"
        Me.EST_CODIGO2.Name = "EST_CODIGO2"
        '
        'motivo
        '
        Me.motivo.HeaderText = "Motivo"
        Me.motivo.Name = "motivo"
        Me.motivo.Width = 180
        '
        'EST_CODIGO
        '
        Me.EST_CODIGO.HeaderText = "Estado Despacho"
        Me.EST_CODIGO.Name = "EST_CODIGO"
        '
        'FECHA_SALIDARUTA
        '
        Me.FECHA_SALIDARUTA.HeaderText = "Fecha Salida Ruta"
        Me.FECHA_SALIDARUTA.Name = "FECHA_SALIDARUTA"
        '
        'USUARIO_SALIDARUTA
        '
        Me.USUARIO_SALIDARUTA.HeaderText = "Usuario Salida Ruta"
        Me.USUARIO_SALIDARUTA.Name = "USUARIO_SALIDARUTA"
        '
        'FECHA_RETORNORUTA
        '
        Me.FECHA_RETORNORUTA.HeaderText = "Fecha Retorno Ruta"
        Me.FECHA_RETORNORUTA.Name = "FECHA_RETORNORUTA"
        '
        'USUARIO_RETORNORUTA
        '
        Me.USUARIO_RETORNORUTA.HeaderText = "Usuario Retorno Ruta"
        Me.USUARIO_RETORNORUTA.Name = "USUARIO_RETORNORUTA"
        '
        'fechaRecepCliente
        '
        Me.fechaRecepCliente.HeaderText = "Fecha RecepcionCliente"
        Me.fechaRecepCliente.Name = "fechaRecepCliente"
        '
        'fechaInterFactura
        '
        Me.fechaInterFactura.HeaderText = "Fecha Inter. Factura"
        Me.fechaInterFactura.Name = "fechaInterFactura"
        '
        'fecha_vto_oc
        '
        Me.fecha_vto_oc.HeaderText = "Fecha Vto OC"
        Me.fecha_vto_oc.Name = "fecha_vto_oc"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 612)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 12, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1006, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(367, 30)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(11, 14)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = ":"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.txtGuia)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.cbxMotivos)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.rbtEntregado)
        Me.GroupBox3.Controls.Add(Me.rbtRechazado)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(148, 76)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(659, 130)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Status"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(191, 78)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(11, 14)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = ":"
        '
        'txtGuia
        '
        Me.txtGuia.Font = New System.Drawing.Font("Tahoma", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuia.Location = New System.Drawing.Point(208, 71)
        Me.txtGuia.Margin = New System.Windows.Forms.Padding(2)
        Me.txtGuia.Name = "txtGuia"
        Me.txtGuia.Size = New System.Drawing.Size(276, 34)
        Me.txtGuia.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(119, 78)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 14)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "NRO GUIA"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.Frozen = True
        Me.DataGridViewTextBoxColumn1.HeaderText = "Guía"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 110
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.Frozen = True
        Me.DataGridViewTextBoxColumn2.HeaderText = "Cliente"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 250
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.Frozen = True
        Me.DataGridViewTextBoxColumn3.HeaderText = "Departamento"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 70
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.Frozen = True
        Me.DataGridViewTextBoxColumn4.HeaderText = "Provincia"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.Frozen = True
        Me.DataGridViewTextBoxColumn5.HeaderText = "Distrito"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 70
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.Frozen = True
        Me.DataGridViewTextBoxColumn6.HeaderText = "Direccion"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "Semaforo"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 75
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "Estado Guía"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = "Motivo"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 180
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.HeaderText = "Estado Despacho"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.HeaderText = "Fecha Salida Ruta"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.HeaderText = "Usuario Salida Ruta"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.HeaderText = "Fecha Retorno Ruta"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.HeaderText = "Usuario Retorno Ruta"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DateTimeGridColumn1
        '
        Me.DateTimeGridColumn1.HeaderText = "Fecha RecepcionCliente"
        Me.DateTimeGridColumn1.Name = "DateTimeGridColumn1"
        '
        'DateTimeGridColumn2
        '
        Me.DateTimeGridColumn2.HeaderText = "Fecha Inter. Factura"
        Me.DateTimeGridColumn2.Name = "DateTimeGridColumn2"
        '
        'DateTimeGridColumn3
        '
        Me.DateTimeGridColumn3.HeaderText = "Fecha Vto OC"
        Me.DateTimeGridColumn3.Name = "DateTimeGridColumn3"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.HeaderText = "Fecha RecepcionCliente"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.HeaderText = "Fecha Inter. Factura"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'frmRetornoRuta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1006, 634)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmRetornoRuta"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Retorno a Ruta"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvRetornoRuta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbxMotivos As ComboBox
    Friend WithEvents rbtRechazado As RadioButton
    Friend WithEvents rbtEntregado As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblTrans As Label
    Friend WithEvents lblRuta As Label
    Friend WithEvents lblFechaRuta As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtGuia As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents dgvRetornoRuta As DataGridView
    Friend WithEvents C5_CNUMDOC As DataGridViewTextBoxColumn
    Friend WithEvents C5_CNOMCLI As DataGridViewTextBoxColumn
    Friend WithEvents DE_CDEPT As DataGridViewTextBoxColumn
    Friend WithEvents DE_CPROV As DataGridViewTextBoxColumn
    Friend WithEvents TG_CDESCRI As DataGridViewTextBoxColumn
    Friend WithEvents C5_CDIRENV As DataGridViewTextBoxColumn
    Friend WithEvents color1 As DataGridViewTextBoxColumn
    Friend WithEvents EST_CODIGO2 As DataGridViewTextBoxColumn
    Friend WithEvents motivo As DataGridViewTextBoxColumn
    Friend WithEvents EST_CODIGO As DataGridViewTextBoxColumn
    Friend WithEvents FECHA_SALIDARUTA As DataGridViewTextBoxColumn
    Friend WithEvents USUARIO_SALIDARUTA As DataGridViewTextBoxColumn
    Friend WithEvents FECHA_RETORNORUTA As DataGridViewTextBoxColumn
    Friend WithEvents USUARIO_RETORNORUTA As DataGridViewTextBoxColumn
    Friend WithEvents fechaRecepCliente As DateTimeGridColumn
    Friend WithEvents fechaInterFactura As DateTimeGridColumn
    Friend WithEvents fecha_vto_oc As DateTimeGridColumn
    Friend WithEvents DateTimeGridColumn1 As DateTimeGridColumn
    Friend WithEvents DateTimeGridColumn2 As DateTimeGridColumn
    Friend WithEvents DateTimeGridColumn3 As DateTimeGridColumn
End Class
