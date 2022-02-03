<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRotuladoxCodigoxSerie
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBusquedaGuia = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.C5_CNUMDOC = New System.Windows.Forms.Label()
        Me.C5_CTD = New System.Windows.Forms.Label()
        Me.C5_CALMA = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.txtFechaVenc = New System.Windows.Forms.TextBox()
        Me.txtLote = New System.Windows.Forms.TextBox()
        Me.txtArticulo = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtNroGuia = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblSaldo = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnImprimirEtiqueta = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.txtAnadirCantidad = New System.Windows.Forms.TextBox()
        Me.dgvCantidades = New System.Windows.Forms.DataGridView()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnBusqueda = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvCantidades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NRO GUIA"
        '
        'txtBusquedaGuia
        '
        Me.txtBusquedaGuia.Location = New System.Drawing.Point(94, 12)
        Me.txtBusquedaGuia.Name = "txtBusquedaGuia"
        Me.txtBusquedaGuia.Size = New System.Drawing.Size(179, 21)
        Me.txtBusquedaGuia.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.C5_CNUMDOC)
        Me.GroupBox1.Controls.Add(Me.C5_CTD)
        Me.GroupBox1.Controls.Add(Me.C5_CALMA)
        Me.GroupBox1.Controls.Add(Me.txtCantidad)
        Me.GroupBox1.Controls.Add(Me.txtFechaVenc)
        Me.GroupBox1.Controls.Add(Me.txtLote)
        Me.GroupBox1.Controls.Add(Me.txtArticulo)
        Me.GroupBox1.Controls.Add(Me.txtCodigo)
        Me.GroupBox1.Controls.Add(Me.txtNroGuia)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(872, 136)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Articulos"
        '
        'C5_CNUMDOC
        '
        Me.C5_CNUMDOC.AutoSize = True
        Me.C5_CNUMDOC.Location = New System.Drawing.Point(424, 30)
        Me.C5_CNUMDOC.Name = "C5_CNUMDOC"
        Me.C5_CNUMDOC.Size = New System.Drawing.Size(85, 13)
        Me.C5_CNUMDOC.TabIndex = 20
        Me.C5_CNUMDOC.Text = "[C5_CNUMDOC]"
        '
        'C5_CTD
        '
        Me.C5_CTD.AutoSize = True
        Me.C5_CTD.Location = New System.Drawing.Point(364, 30)
        Me.C5_CTD.Name = "C5_CTD"
        Me.C5_CTD.Size = New System.Drawing.Size(54, 13)
        Me.C5_CTD.TabIndex = 19
        Me.C5_CTD.Text = "[C5_CTD]"
        '
        'C5_CALMA
        '
        Me.C5_CALMA.AutoSize = True
        Me.C5_CALMA.Location = New System.Drawing.Point(291, 30)
        Me.C5_CALMA.Name = "C5_CALMA"
        Me.C5_CALMA.Size = New System.Drawing.Size(68, 13)
        Me.C5_CALMA.TabIndex = 18
        Me.C5_CALMA.Text = "[C5_CALMA]"
        '
        'txtCantidad
        '
        Me.txtCantidad.BackColor = System.Drawing.Color.White
        Me.txtCantidad.Location = New System.Drawing.Point(644, 85)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.ReadOnly = True
        Me.txtCantidad.Size = New System.Drawing.Size(181, 21)
        Me.txtCantidad.TabIndex = 17
        '
        'txtFechaVenc
        '
        Me.txtFechaVenc.BackColor = System.Drawing.Color.White
        Me.txtFechaVenc.Location = New System.Drawing.Point(644, 58)
        Me.txtFechaVenc.Name = "txtFechaVenc"
        Me.txtFechaVenc.ReadOnly = True
        Me.txtFechaVenc.Size = New System.Drawing.Size(181, 21)
        Me.txtFechaVenc.TabIndex = 16
        '
        'txtLote
        '
        Me.txtLote.BackColor = System.Drawing.Color.White
        Me.txtLote.Location = New System.Drawing.Point(644, 30)
        Me.txtLote.Name = "txtLote"
        Me.txtLote.ReadOnly = True
        Me.txtLote.Size = New System.Drawing.Size(181, 21)
        Me.txtLote.TabIndex = 15
        '
        'txtArticulo
        '
        Me.txtArticulo.BackColor = System.Drawing.Color.White
        Me.txtArticulo.Location = New System.Drawing.Point(86, 86)
        Me.txtArticulo.Name = "txtArticulo"
        Me.txtArticulo.ReadOnly = True
        Me.txtArticulo.Size = New System.Drawing.Size(423, 21)
        Me.txtArticulo.TabIndex = 14
        '
        'txtCodigo
        '
        Me.txtCodigo.BackColor = System.Drawing.Color.White
        Me.txtCodigo.Location = New System.Drawing.Point(86, 57)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(181, 21)
        Me.txtCodigo.TabIndex = 13
        '
        'txtNroGuia
        '
        Me.txtNroGuia.BackColor = System.Drawing.Color.White
        Me.txtNroGuia.Location = New System.Drawing.Point(87, 28)
        Me.txtNroGuia.Name = "txtNroGuia"
        Me.txtNroGuia.ReadOnly = True
        Me.txtNroGuia.Size = New System.Drawing.Size(181, 21)
        Me.txtNroGuia.TabIndex = 12
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(627, 90)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(11, 13)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = ":"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(627, 61)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(11, 13)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = ":"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(627, 33)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(11, 13)
        Me.Label13.TabIndex = 9
        Me.Label13.Text = ":"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(70, 89)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(11, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = ":"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(70, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(11, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = ":"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(70, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(11, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = ":"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(552, 90)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "CANTIDAD"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "NRO GUIA"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(552, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "FECHA VENC."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(552, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "LOTE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "ARTICULO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "CODIGO"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblTotal)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.lblSaldo)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.btnImprimirEtiqueta)
        Me.GroupBox2.Controls.Add(Me.btnAgregar)
        Me.GroupBox2.Controls.Add(Me.txtAnadirCantidad)
        Me.GroupBox2.Controls.Add(Me.dgvCantidades)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 187)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(872, 238)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Fraccionar Cantidad"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(393, 50)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(13, 13)
        Me.lblTotal.TabIndex = 20
        Me.lblTotal.Text = "0"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(339, 50)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(43, 13)
        Me.Label17.TabIndex = 19
        Me.Label17.Text = "TOTAL:"
        '
        'lblSaldo
        '
        Me.lblSaldo.AutoSize = True
        Me.lblSaldo.Location = New System.Drawing.Point(393, 23)
        Me.lblSaldo.Name = "lblSaldo"
        Me.lblSaldo.Size = New System.Drawing.Size(13, 13)
        Me.lblSaldo.TabIndex = 18
        Me.lblSaldo.Text = "0"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(337, 23)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(44, 13)
        Me.Label16.TabIndex = 17
        Me.Label16.Text = "SALDO:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(11, 23)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(90, 13)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = "Ingrese Cantidad"
        '
        'btnImprimirEtiqueta
        '
        Me.btnImprimirEtiqueta.Image = Global.WindowsApp1.My.Resources.Resources._004
        Me.btnImprimirEtiqueta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImprimirEtiqueta.Location = New System.Drawing.Point(344, 110)
        Me.btnImprimirEtiqueta.Name = "btnImprimirEtiqueta"
        Me.btnImprimirEtiqueta.Size = New System.Drawing.Size(136, 42)
        Me.btnImprimirEtiqueta.TabIndex = 15
        Me.btnImprimirEtiqueta.Text = "IMPRIMIR"
        Me.btnImprimirEtiqueta.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(220, 18)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 14
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'txtAnadirCantidad
        '
        Me.txtAnadirCantidad.Location = New System.Drawing.Point(112, 20)
        Me.txtAnadirCantidad.Name = "txtAnadirCantidad"
        Me.txtAnadirCantidad.Size = New System.Drawing.Size(99, 21)
        Me.txtAnadirCantidad.TabIndex = 13
        '
        'dgvCantidades
        '
        Me.dgvCantidades.AllowUserToAddRows = False
        Me.dgvCantidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCantidades.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cantidad})
        Me.dgvCantidades.Location = New System.Drawing.Point(10, 50)
        Me.dgvCantidades.Name = "dgvCantidades"
        Me.dgvCantidades.Size = New System.Drawing.Size(285, 162)
        Me.dgvCantidades.TabIndex = 0
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 428)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(890, 22)
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(77, 15)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(11, 13)
        Me.Label14.TabIndex = 7
        Me.Label14.Text = ":"
        '
        'btnBusqueda
        '
        Me.btnBusqueda.Image = Global.WindowsApp1.My.Resources.Resources._104
        Me.btnBusqueda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBusqueda.Location = New System.Drawing.Point(286, 11)
        Me.btnBusqueda.Name = "btnBusqueda"
        Me.btnBusqueda.Size = New System.Drawing.Size(101, 23)
        Me.btnBusqueda.TabIndex = 2
        Me.btnBusqueda.Text = "Buscar"
        Me.btnBusqueda.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "CANTIDADES"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 240
        '
        'cantidad
        '
        Me.cantidad.HeaderText = "CANTIDADES"
        Me.cantidad.Name = "cantidad"
        Me.cantidad.Width = 240
        '
        'frmRotuladoxCodigoxSerie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(890, 450)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnBusqueda)
        Me.Controls.Add(Me.txtBusquedaGuia)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmRotuladoxCodigoxSerie"
        Me.Text = "Rotulado por Codigo y Serie"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvCantidades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtBusquedaGuia As TextBox
    Friend WithEvents btnBusqueda As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents txtFechaVenc As TextBox
    Friend WithEvents txtLote As TextBox
    Friend WithEvents txtArticulo As TextBox
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents txtNroGuia As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents txtAnadirCantidad As TextBox
    Friend WithEvents dgvCantidades As DataGridView
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents Label14 As Label
    Friend WithEvents btnImprimirEtiqueta As Button
    Friend WithEvents C5_CNUMDOC As Label
    Friend WithEvents C5_CTD As Label
    Friend WithEvents C5_CALMA As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents lblSaldo As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents cantidad As DataGridViewTextBoxColumn
End Class
