<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditarProgramacionRuta
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LIMA = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.IconButton3 = New FontAwesome.Sharp.IconButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.Dg_Rutas = New System.Windows.Forms.DataGridView()
        Me.DataGridConsolidado = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
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
        Me.Marcar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.RutaTentativa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RUTA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESTINO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOM_CLIENTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DIRECCION_ENTREGA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DISTRITO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CANAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DETALLE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RESTRICCION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTALIMPORTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTALMETROSCUBICOS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CANTIDADGUIAS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIEMPOENTREGA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COMENTARIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idconsolidado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LIMA.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.Dg_Rutas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridConsolidado, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.LIMA.Size = New System.Drawing.Size(1273, 648)
        Me.LIMA.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.IconButton3)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.IconButton2)
        Me.TabPage1.Controls.Add(Me.IconButton1)
        Me.TabPage1.Controls.Add(Me.Dg_Rutas)
        Me.TabPage1.Controls.Add(Me.DataGridConsolidado)
        Me.TabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1265, 622)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "LIMA"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'IconButton3
        '
        Me.IconButton3.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.print_icon3
        Me.IconButton3.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconButton3.IconColor = System.Drawing.Color.Black
        Me.IconButton3.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton3.Location = New System.Drawing.Point(1221, 533)
        Me.IconButton3.Name = "IconButton3"
        Me.IconButton3.Size = New System.Drawing.Size(36, 35)
        Me.IconButton3.TabIndex = 15
        Me.IconButton3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 473)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "RUTAS"
        '
        'IconButton2
        '
        Me.IconButton2.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.print_icon3
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconButton2.IconColor = System.Drawing.Color.Black
        Me.IconButton2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton2.Location = New System.Drawing.Point(1221, 492)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Size = New System.Drawing.Size(36, 35)
        Me.IconButton2.TabIndex = 13
        Me.IconButton2.UseVisualStyleBackColor = True
        '
        'IconButton1
        '
        Me.IconButton1.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.floppy_icon
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconButton1.IconColor = System.Drawing.Color.Black
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.Location = New System.Drawing.Point(1223, 9)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(34, 35)
        Me.IconButton1.TabIndex = 12
        Me.IconButton1.UseVisualStyleBackColor = True
        '
        'Dg_Rutas
        '
        Me.Dg_Rutas.AllowUserToAddRows = False
        Me.Dg_Rutas.AllowUserToDeleteRows = False
        Me.Dg_Rutas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.Dg_Rutas.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dg_Rutas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Dg_Rutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Dg_Rutas.DefaultCellStyle = DataGridViewCellStyle2
        Me.Dg_Rutas.Location = New System.Drawing.Point(3, 492)
        Me.Dg_Rutas.Name = "Dg_Rutas"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dg_Rutas.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.Dg_Rutas.Size = New System.Drawing.Size(1215, 122)
        Me.Dg_Rutas.TabIndex = 11
        '
        'DataGridConsolidado
        '
        Me.DataGridConsolidado.AllowDrop = True
        Me.DataGridConsolidado.AllowUserToAddRows = False
        Me.DataGridConsolidado.AllowUserToDeleteRows = False
        Me.DataGridConsolidado.BackgroundColor = System.Drawing.Color.White
        Me.DataGridConsolidado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridConsolidado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Marcar, Me.RutaTentativa, Me.RUTA, Me.Cliente, Me.DESTINO, Me.NOM_CLIENTE, Me.DIRECCION_ENTREGA, Me.DISTRITO, Me.CANAL, Me.DETALLE, Me.RESTRICCION, Me.TOTALIMPORTE, Me.TOTALMETROSCUBICOS, Me.CANTIDADGUIAS, Me.TIEMPOENTREGA, Me.COMENTARIO, Me.idconsolidado})
        Me.DataGridConsolidado.Location = New System.Drawing.Point(3, 9)
        Me.DataGridConsolidado.Margin = New System.Windows.Forms.Padding(0)
        Me.DataGridConsolidado.MultiSelect = False
        Me.DataGridConsolidado.Name = "DataGridConsolidado"
        Me.DataGridConsolidado.RowHeadersVisible = False
        Me.DataGridConsolidado.RowHeadersWidth = 20
        Me.DataGridConsolidado.RowTemplate.Height = 20
        Me.DataGridConsolidado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridConsolidado.Size = New System.Drawing.Size(1215, 460)
        Me.DataGridConsolidado.TabIndex = 8
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1265, 622)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "PROVINCIA"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Ruta"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Destino"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Cliente"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Direccion"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Distrito"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Canal"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "Detalle"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "Restriccion"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = "Importe"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.HeaderText = "Metros Cubicos"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.HeaderText = "Cant Guias"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.HeaderText = "T. Entrega"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'Marcar
        '
        Me.Marcar.HeaderText = "Marcar"
        Me.Marcar.Name = "Marcar"
        Me.Marcar.Width = 121
        '
        'RutaTentativa
        '
        Me.RutaTentativa.HeaderText = "Ruta Tentativa"
        Me.RutaTentativa.Name = "RutaTentativa"
        '
        'RUTA
        '
        Me.RUTA.HeaderText = "Ruta"
        Me.RUTA.Name = "RUTA"
        Me.RUTA.Width = 121
        '
        'Cliente
        '
        Me.Cliente.HeaderText = "Cliente"
        Me.Cliente.Name = "Cliente"
        Me.Cliente.Width = 122
        '
        'DESTINO
        '
        Me.DESTINO.HeaderText = "Destino"
        Me.DESTINO.Name = "DESTINO"
        Me.DESTINO.Width = 121
        '
        'NOM_CLIENTE
        '
        Me.NOM_CLIENTE.HeaderText = "Cliente"
        Me.NOM_CLIENTE.Name = "NOM_CLIENTE"
        Me.NOM_CLIENTE.Visible = False
        '
        'DIRECCION_ENTREGA
        '
        Me.DIRECCION_ENTREGA.HeaderText = "Direccion"
        Me.DIRECCION_ENTREGA.Name = "DIRECCION_ENTREGA"
        Me.DIRECCION_ENTREGA.Visible = False
        '
        'DISTRITO
        '
        Me.DISTRITO.HeaderText = "Distrito"
        Me.DISTRITO.Name = "DISTRITO"
        Me.DISTRITO.Width = 121
        '
        'CANAL
        '
        Me.CANAL.HeaderText = "Canal"
        Me.CANAL.Name = "CANAL"
        Me.CANAL.Visible = False
        '
        'DETALLE
        '
        Me.DETALLE.HeaderText = "Detalle"
        Me.DETALLE.Name = "DETALLE"
        Me.DETALLE.Visible = False
        '
        'RESTRICCION
        '
        Me.RESTRICCION.HeaderText = "Restriccion"
        Me.RESTRICCION.Name = "RESTRICCION"
        Me.RESTRICCION.Width = 121
        '
        'TOTALIMPORTE
        '
        Me.TOTALIMPORTE.HeaderText = "Importe"
        Me.TOTALIMPORTE.Name = "TOTALIMPORTE"
        Me.TOTALIMPORTE.Width = 121
        '
        'TOTALMETROSCUBICOS
        '
        Me.TOTALMETROSCUBICOS.HeaderText = "Metros Cubicos"
        Me.TOTALMETROSCUBICOS.Name = "TOTALMETROSCUBICOS"
        Me.TOTALMETROSCUBICOS.Width = 122
        '
        'CANTIDADGUIAS
        '
        Me.CANTIDADGUIAS.HeaderText = "Cant Guias"
        Me.CANTIDADGUIAS.Name = "CANTIDADGUIAS"
        Me.CANTIDADGUIAS.Width = 121
        '
        'TIEMPOENTREGA
        '
        Me.TIEMPOENTREGA.HeaderText = "T. Entrega"
        Me.TIEMPOENTREGA.Name = "TIEMPOENTREGA"
        Me.TIEMPOENTREGA.Width = 121
        '
        'COMENTARIO
        '
        Me.COMENTARIO.HeaderText = "Comentario"
        Me.COMENTARIO.Name = "COMENTARIO"
        Me.COMENTARIO.Visible = False
        '
        'idconsolidado
        '
        Me.idconsolidado.HeaderText = "idconsolidado"
        Me.idconsolidado.Name = "idconsolidado"
        '
        'EditarProgramacionRuta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1273, 648)
        Me.Controls.Add(Me.LIMA)
        Me.Name = "EditarProgramacionRuta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EditarProgramacionRuta"
        Me.LIMA.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.Dg_Rutas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridConsolidado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LIMA As TabControl
    Friend WithEvents TabPage2 As TabPage
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
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents DataGridConsolidado As DataGridView
    Friend WithEvents Dg_Rutas As DataGridView
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents Label1 As Label
    Friend WithEvents IconButton3 As FontAwesome.Sharp.IconButton
    Friend WithEvents Marcar As DataGridViewCheckBoxColumn
    Friend WithEvents RutaTentativa As DataGridViewTextBoxColumn
    Friend WithEvents RUTA As DataGridViewTextBoxColumn
    Friend WithEvents Cliente As DataGridViewTextBoxColumn
    Friend WithEvents DESTINO As DataGridViewTextBoxColumn
    Friend WithEvents NOM_CLIENTE As DataGridViewTextBoxColumn
    Friend WithEvents DIRECCION_ENTREGA As DataGridViewTextBoxColumn
    Friend WithEvents DISTRITO As DataGridViewTextBoxColumn
    Friend WithEvents CANAL As DataGridViewTextBoxColumn
    Friend WithEvents DETALLE As DataGridViewTextBoxColumn
    Friend WithEvents RESTRICCION As DataGridViewTextBoxColumn
    Friend WithEvents TOTALIMPORTE As DataGridViewTextBoxColumn
    Friend WithEvents TOTALMETROSCUBICOS As DataGridViewTextBoxColumn
    Friend WithEvents CANTIDADGUIAS As DataGridViewTextBoxColumn
    Friend WithEvents TIEMPOENTREGA As DataGridViewTextBoxColumn
    Friend WithEvents COMENTARIO As DataGridViewTextBoxColumn
    Friend WithEvents idconsolidado As DataGridViewTextBoxColumn
End Class
