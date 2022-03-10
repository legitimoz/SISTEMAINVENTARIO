<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalidaRetorno_Ruta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSalidaRetorno_Ruta))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpFecIni = New System.Windows.Forms.DateTimePicker()
        Me.dtpFecFin = New System.Windows.Forms.DateTimePicker()
        Me.dgvListadoRutas = New System.Windows.Forms.DataGridView()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.cbxTransportista = New System.Windows.Forms.ComboBox()
        Me.Transportista = New System.Windows.Forms.Label()
        Me.btnRetornoProveedor = New System.Windows.Forms.Button()
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
        Me.r_ruta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TRD_CCODIGO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.r_transportista = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.r_fecharuta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.r_fechaCreacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.r_totalguias = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.r_gentregadas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.r_porcguiasentreg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.r_totalrezagados = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.r_porctotalrezag = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.r_pendiente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.r_porcpendiente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_Editar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column_retorno = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colImprimir = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.dgvListadoRutas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.DarkRed
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1343, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 504)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 12, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1343, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 14)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Fecha Inicio:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(249, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 14)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Fecha Fin:"
        '
        'dtpFecIni
        '
        Me.dtpFecIni.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecIni.Location = New System.Drawing.Point(108, 34)
        Me.dtpFecIni.Name = "dtpFecIni"
        Me.dtpFecIni.Size = New System.Drawing.Size(111, 22)
        Me.dtpFecIni.TabIndex = 5
        '
        'dtpFecFin
        '
        Me.dtpFecFin.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecFin.Location = New System.Drawing.Point(330, 34)
        Me.dtpFecFin.Name = "dtpFecFin"
        Me.dtpFecFin.Size = New System.Drawing.Size(111, 22)
        Me.dtpFecFin.TabIndex = 6
        '
        'dgvListadoRutas
        '
        Me.dgvListadoRutas.AllowUserToAddRows = False
        Me.dgvListadoRutas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvListadoRutas.BackgroundColor = System.Drawing.Color.White
        Me.dgvListadoRutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListadoRutas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.r_ruta, Me.TRD_CCODIGO, Me.r_transportista, Me.r_fecharuta, Me.r_fechaCreacion, Me.r_totalguias, Me.r_gentregadas, Me.r_porcguiasentreg, Me.r_totalrezagados, Me.r_porctotalrezag, Me.r_pendiente, Me.r_porcpendiente, Me.Column_Editar, Me.Column1, Me.Column_retorno, Me.colImprimir, Me.Column2})
        Me.dgvListadoRutas.Location = New System.Drawing.Point(10, 129)
        Me.dgvListadoRutas.Name = "dgvListadoRutas"
        Me.dgvListadoRutas.Size = New System.Drawing.Size(1321, 372)
        Me.dgvListadoRutas.TabIndex = 11
        '
        'btnExportar
        '
        Me.btnExportar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExportar.Image = Global.WindowsApp1.My.Resources.Resources.icon_excel
        Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExportar.Location = New System.Drawing.Point(257, 79)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(115, 36)
        Me.btnExportar.TabIndex = 10
        Me.btnExportar.Text = "Exportar"
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNuevo.Location = New System.Drawing.Point(138, 79)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(99, 36)
        Me.btnNuevo.TabIndex = 9
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.Image = Global.WindowsApp1.My.Resources.Resources._1042
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscar.Location = New System.Drawing.Point(13, 79)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(107, 36)
        Me.btnBuscar.TabIndex = 8
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'cbxTransportista
        '
        Me.cbxTransportista.BackColor = System.Drawing.Color.White
        Me.cbxTransportista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTransportista.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxTransportista.FormattingEnabled = True
        Me.cbxTransportista.Location = New System.Drawing.Point(619, 36)
        Me.cbxTransportista.Name = "cbxTransportista"
        Me.cbxTransportista.Size = New System.Drawing.Size(281, 22)
        Me.cbxTransportista.TabIndex = 13
        '
        'Transportista
        '
        Me.Transportista.AutoSize = True
        Me.Transportista.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Transportista.Location = New System.Drawing.Point(514, 40)
        Me.Transportista.Name = "Transportista"
        Me.Transportista.Size = New System.Drawing.Size(82, 14)
        Me.Transportista.TabIndex = 12
        Me.Transportista.Text = "Transportista:"
        '
        'btnRetornoProveedor
        '
        Me.btnRetornoProveedor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRetornoProveedor.Image = CType(resources.GetObject("btnRetornoProveedor.Image"), System.Drawing.Image)
        Me.btnRetornoProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRetornoProveedor.Location = New System.Drawing.Point(389, 79)
        Me.btnRetornoProveedor.Name = "btnRetornoProveedor"
        Me.btnRetornoProveedor.Size = New System.Drawing.Size(143, 36)
        Me.btnRetornoProveedor.TabIndex = 14
        Me.btnRetornoProveedor.Text = "Retorno Proveedor"
        Me.btnRetornoProveedor.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Ruta"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 70
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "TRD_CCODIGO"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Transportista"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 250
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Fecha Ruta"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 80
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Total Guias"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "GU Entregadas"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 70
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "%"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 50
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "Total Rechazadas"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 50
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = "%"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 50
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.HeaderText = "Pendiente"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 50
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.HeaderText = "%"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 50
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.HeaderText = "%"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Width = 50
        '
        'r_ruta
        '
        Me.r_ruta.HeaderText = "Ruta"
        Me.r_ruta.Name = "r_ruta"
        Me.r_ruta.Width = 70
        '
        'TRD_CCODIGO
        '
        Me.TRD_CCODIGO.HeaderText = "TRD_CCODIGO"
        Me.TRD_CCODIGO.Name = "TRD_CCODIGO"
        Me.TRD_CCODIGO.Visible = False
        '
        'r_transportista
        '
        Me.r_transportista.HeaderText = "Transportista"
        Me.r_transportista.Name = "r_transportista"
        Me.r_transportista.Width = 200
        '
        'r_fecharuta
        '
        Me.r_fecharuta.HeaderText = "Fecha Ruta"
        Me.r_fecharuta.Name = "r_fecharuta"
        Me.r_fecharuta.Width = 80
        '
        'r_fechaCreacion
        '
        Me.r_fechaCreacion.HeaderText = "Fecha Creación"
        Me.r_fechaCreacion.Name = "r_fechaCreacion"
        '
        'r_totalguias
        '
        Me.r_totalguias.HeaderText = "Total Guias"
        Me.r_totalguias.Name = "r_totalguias"
        Me.r_totalguias.Width = 70
        '
        'r_gentregadas
        '
        Me.r_gentregadas.HeaderText = "GU Entregadas"
        Me.r_gentregadas.Name = "r_gentregadas"
        Me.r_gentregadas.Width = 70
        '
        'r_porcguiasentreg
        '
        Me.r_porcguiasentreg.HeaderText = "%"
        Me.r_porcguiasentreg.Name = "r_porcguiasentreg"
        Me.r_porcguiasentreg.Width = 50
        '
        'r_totalrezagados
        '
        Me.r_totalrezagados.HeaderText = "Total Rechazadas"
        Me.r_totalrezagados.Name = "r_totalrezagados"
        Me.r_totalrezagados.Width = 70
        '
        'r_porctotalrezag
        '
        Me.r_porctotalrezag.HeaderText = "%"
        Me.r_porctotalrezag.Name = "r_porctotalrezag"
        Me.r_porctotalrezag.Width = 50
        '
        'r_pendiente
        '
        Me.r_pendiente.HeaderText = "Pendiente"
        Me.r_pendiente.Name = "r_pendiente"
        Me.r_pendiente.Width = 70
        '
        'r_porcpendiente
        '
        Me.r_porcpendiente.HeaderText = "%"
        Me.r_porcpendiente.Name = "r_porcpendiente"
        Me.r_porcpendiente.Width = 50
        '
        'Column_Editar
        '
        Me.Column_Editar.HeaderText = ""
        Me.Column_Editar.Name = "Column_Editar"
        Me.Column_Editar.Text = "Editar"
        Me.Column_Editar.ToolTipText = "Editar"
        Me.Column_Editar.UseColumnTextForButtonValue = True
        '
        'Column1
        '
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column1.Text = "Ver Seguimiento"
        Me.Column1.UseColumnTextForButtonValue = True
        '
        'Column_retorno
        '
        Me.Column_retorno.HeaderText = ""
        Me.Column_retorno.Name = "Column_retorno"
        Me.Column_retorno.Text = "Retorno Ruta"
        Me.Column_retorno.UseColumnTextForButtonValue = True
        '
        'colImprimir
        '
        Me.colImprimir.HeaderText = ""
        Me.colImprimir.Name = "colImprimir"
        Me.colImprimir.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colImprimir.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colImprimir.Text = "Imprimir"
        Me.colImprimir.UseColumnTextForButtonValue = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Imprimir Anterior"
        Me.Column2.Name = "Column2"
        Me.Column2.Text = "Imprimir A."
        Me.Column2.UseColumnTextForButtonValue = True
        '
        'frmSalidaRetorno_Ruta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1343, 526)
        Me.Controls.Add(Me.btnRetornoProveedor)
        Me.Controls.Add(Me.cbxTransportista)
        Me.Controls.Add(Me.Transportista)
        Me.Controls.Add(Me.dgvListadoRutas)
        Me.Controls.Add(Me.btnExportar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.dtpFecFin)
        Me.Controls.Add(Me.dtpFecIni)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmSalidaRetorno_Ruta"
        Me.Text = "Salida & Retorno a Ruta"
        CType(Me.dgvListadoRutas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpFecIni As DateTimePicker
    Friend WithEvents dtpFecFin As DateTimePicker
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnExportar As Button
    Friend WithEvents dgvListadoRutas As DataGridView
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
    Friend WithEvents cbxTransportista As ComboBox
    Friend WithEvents Transportista As Label
    Friend WithEvents btnRetornoProveedor As Button
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents r_ruta As DataGridViewTextBoxColumn
    Friend WithEvents TRD_CCODIGO As DataGridViewTextBoxColumn
    Friend WithEvents r_transportista As DataGridViewTextBoxColumn
    Friend WithEvents r_fecharuta As DataGridViewTextBoxColumn
    Friend WithEvents r_fechaCreacion As DataGridViewTextBoxColumn
    Friend WithEvents r_totalguias As DataGridViewTextBoxColumn
    Friend WithEvents r_gentregadas As DataGridViewTextBoxColumn
    Friend WithEvents r_porcguiasentreg As DataGridViewTextBoxColumn
    Friend WithEvents r_totalrezagados As DataGridViewTextBoxColumn
    Friend WithEvents r_porctotalrezag As DataGridViewTextBoxColumn
    Friend WithEvents r_pendiente As DataGridViewTextBoxColumn
    Friend WithEvents r_porcpendiente As DataGridViewTextBoxColumn
    Friend WithEvents Column_Editar As DataGridViewButtonColumn
    Friend WithEvents Column1 As DataGridViewButtonColumn
    Friend WithEvents Column_retorno As DataGridViewButtonColumn
    Friend WithEvents colImprimir As DataGridViewButtonColumn
    Friend WithEvents Column2 As DataGridViewButtonColumn
End Class
