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
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.cmdAceptar = New FontAwesome.Sharp.IconButton()
        Me.DataGridConsolidado = New System.Windows.Forms.DataGridView()
        Me.Dg_Rutas = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Marcar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
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
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        CType(Me.DataGridConsolidado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dg_Rutas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IconButton1
        '
        Me.IconButton1.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.Folder_Add_icon
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconButton1.IconColor = System.Drawing.Color.Black
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.Location = New System.Drawing.Point(1400, 75)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(10, 27)
        Me.IconButton1.TabIndex = 148
        Me.IconButton1.UseVisualStyleBackColor = True
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAceptar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdAceptar.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen
        Me.cmdAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAceptar.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.ForeColor = System.Drawing.Color.ForestGreen
        Me.cmdAceptar.IconChar = FontAwesome.Sharp.IconChar.CheckCircle
        Me.cmdAceptar.IconColor = System.Drawing.Color.ForestGreen
        Me.cmdAceptar.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.cmdAceptar.IconSize = 16
        Me.cmdAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAceptar.Location = New System.Drawing.Point(1016, 589)
        Me.cmdAceptar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.cmdAceptar.Size = New System.Drawing.Size(106, 26)
        Me.cmdAceptar.TabIndex = 149
        Me.cmdAceptar.Text = "Aceptar"
        Me.cmdAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdAceptar.UseVisualStyleBackColor = False
        '
        'DataGridConsolidado
        '
        Me.DataGridConsolidado.AllowUserToAddRows = False
        Me.DataGridConsolidado.AllowUserToDeleteRows = False
        Me.DataGridConsolidado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridConsolidado.BackgroundColor = System.Drawing.Color.White
        Me.DataGridConsolidado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridConsolidado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridConsolidado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Marcar, Me.RutaTentativa, Me.RUTA, Me.Cliente, Me.DESTINO, Me.NOM_CLIENTE, Me.DIRECCION_ENTREGA, Me.DISTRITO, Me.CANAL, Me.DETALLE, Me.RESTRICCION, Me.TOTALIMPORTE, Me.TOTALMETROSCUBICOS, Me.CANTIDADGUIAS, Me.TIEMPOENTREGA, Me.COMENTARIO, Me.idconsolidado})
        Me.DataGridConsolidado.Location = New System.Drawing.Point(9, 32)
        Me.DataGridConsolidado.Margin = New System.Windows.Forms.Padding(0)
        Me.DataGridConsolidado.MultiSelect = False
        Me.DataGridConsolidado.Name = "DataGridConsolidado"
        Me.DataGridConsolidado.RowHeadersVisible = False
        Me.DataGridConsolidado.RowHeadersWidth = 20
        Me.DataGridConsolidado.RowTemplate.Height = 20
        Me.DataGridConsolidado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridConsolidado.Size = New System.Drawing.Size(1113, 361)
        Me.DataGridConsolidado.TabIndex = 143
        '
        'Dg_Rutas
        '
        Me.Dg_Rutas.AllowUserToAddRows = False
        Me.Dg_Rutas.AllowUserToDeleteRows = False
        Me.Dg_Rutas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.Dg_Rutas.BackgroundColor = System.Drawing.Color.White
        Me.Dg_Rutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dg_Rutas.Location = New System.Drawing.Point(9, 437)
        Me.Dg_Rutas.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Dg_Rutas.Name = "Dg_Rutas"
        Me.Dg_Rutas.Size = New System.Drawing.Size(1113, 136)
        Me.Dg_Rutas.TabIndex = 144
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(9, 415)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 18)
        Me.Label1.TabIndex = 150
        Me.Label1.Text = "Rutas Preliminares"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1130, 32)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(33, 23)
        Me.Button1.TabIndex = 151
        Me.Button1.Text = "add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Marcar
        '
        Me.Marcar.HeaderText = "Marcar"
        Me.Marcar.Name = "Marcar"
        Me.Marcar.Width = 54
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Ruta"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 95
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Destino"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 121
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Cliente"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Visible = False
        Me.DataGridViewTextBoxColumn3.Width = 122
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Direccion"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Visible = False
        Me.DataGridViewTextBoxColumn4.Width = 121
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Distrito"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Visible = False
        Me.DataGridViewTextBoxColumn5.Width = 77
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Canal"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Visible = False
        Me.DataGridViewTextBoxColumn6.Width = 71
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "Detalle"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Visible = False
        Me.DataGridViewTextBoxColumn7.Width = 121
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "Restriccion"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Visible = False
        Me.DataGridViewTextBoxColumn8.Width = 67
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = "Importe"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Visible = False
        Me.DataGridViewTextBoxColumn9.Width = 71
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.HeaderText = "Metros Cubicos"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 121
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.HeaderText = "Cant Guias"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 121
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.HeaderText = "T. Entrega"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Width = 122
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.HeaderText = "Cant Guias"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Width = 121
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.HeaderText = "T. Entrega"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Width = 121
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.HeaderText = "Comentario"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.Visible = False
        Me.DataGridViewTextBoxColumn15.Width = 97
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.HeaderText = "idconsolidado"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.Visible = False
        Me.DataGridViewTextBoxColumn16.Width = 110
        '
        'RutaTentativa
        '
        Me.RutaTentativa.HeaderText = "Ruta Tentativa"
        Me.RutaTentativa.Name = "RutaTentativa"
        Me.RutaTentativa.Width = 115
        '
        'RUTA
        '
        Me.RUTA.HeaderText = "Ruta"
        Me.RUTA.Name = "RUTA"
        Me.RUTA.Width = 59
        '
        'Cliente
        '
        Me.Cliente.HeaderText = "Cliente"
        Me.Cliente.Name = "Cliente"
        Me.Cliente.Width = 71
        '
        'DESTINO
        '
        Me.DESTINO.HeaderText = "Destino"
        Me.DESTINO.Name = "DESTINO"
        Me.DESTINO.Visible = False
        Me.DESTINO.Width = 68
        '
        'NOM_CLIENTE
        '
        Me.NOM_CLIENTE.HeaderText = "Cliente"
        Me.NOM_CLIENTE.Name = "NOM_CLIENTE"
        Me.NOM_CLIENTE.Visible = False
        Me.NOM_CLIENTE.Width = 64
        '
        'DIRECCION_ENTREGA
        '
        Me.DIRECCION_ENTREGA.HeaderText = "Direccion"
        Me.DIRECCION_ENTREGA.Name = "DIRECCION_ENTREGA"
        Me.DIRECCION_ENTREGA.Width = 83
        '
        'DISTRITO
        '
        Me.DISTRITO.HeaderText = "Distrito"
        Me.DISTRITO.Name = "DISTRITO"
        Me.DISTRITO.Width = 67
        '
        'CANAL
        '
        Me.CANAL.HeaderText = "Canal"
        Me.CANAL.Name = "CANAL"
        Me.CANAL.Visible = False
        Me.CANAL.Width = 59
        '
        'DETALLE
        '
        Me.DETALLE.HeaderText = "Detalle"
        Me.DETALLE.Name = "DETALLE"
        Me.DETALLE.Visible = False
        Me.DETALLE.Width = 65
        '
        'RESTRICCION
        '
        Me.RESTRICCION.HeaderText = "Restriccion"
        Me.RESTRICCION.Name = "RESTRICCION"
        Me.RESTRICCION.Width = 90
        '
        'TOTALIMPORTE
        '
        Me.TOTALIMPORTE.HeaderText = "Importe"
        Me.TOTALIMPORTE.Name = "TOTALIMPORTE"
        Me.TOTALIMPORTE.Width = 75
        '
        'TOTALMETROSCUBICOS
        '
        Me.TOTALMETROSCUBICOS.HeaderText = "Metros Cubicos"
        Me.TOTALMETROSCUBICOS.Name = "TOTALMETROSCUBICOS"
        Me.TOTALMETROSCUBICOS.Width = 116
        '
        'CANTIDADGUIAS
        '
        Me.CANTIDADGUIAS.HeaderText = "Cant Guias"
        Me.CANTIDADGUIAS.Name = "CANTIDADGUIAS"
        Me.CANTIDADGUIAS.Width = 95
        '
        'TIEMPOENTREGA
        '
        Me.TIEMPOENTREGA.HeaderText = "T. Entrega"
        Me.TIEMPOENTREGA.Name = "TIEMPOENTREGA"
        Me.TIEMPOENTREGA.Width = 86
        '
        'COMENTARIO
        '
        Me.COMENTARIO.HeaderText = "Comentario"
        Me.COMENTARIO.Name = "COMENTARIO"
        Me.COMENTARIO.Visible = False
        Me.COMENTARIO.Width = 85
        '
        'idconsolidado
        '
        Me.idconsolidado.HeaderText = "idconsolidado"
        Me.idconsolidado.Name = "idconsolidado"
        Me.idconsolidado.Visible = False
        Me.idconsolidado.Width = 97
        '
        'EditarProgramacionRuta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1171, 628)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.IconButton1)
        Me.Controls.Add(Me.Dg_Rutas)
        Me.Controls.Add(Me.DataGridConsolidado)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "EditarProgramacionRuta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EditarProgramacionRuta"
        CType(Me.DataGridConsolidado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dg_Rutas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents cmdAceptar As FontAwesome.Sharp.IconButton
    Friend WithEvents DataGridConsolidado As DataGridView
    Friend WithEvents Dg_Rutas As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
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
