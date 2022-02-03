<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GestionDispatchOnTime
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GestionDispatchOnTime))
        Me.savedialog_Excel = New System.Windows.Forms.SaveFileDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_indicador = New System.Windows.Forms.Label()
        Me.txt_indicador = New System.Windows.Forms.Label()
        Me.LBL_can = New System.Windows.Forms.Label()
        Me.txt_cantatiempo = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_Cantpedidos = New System.Windows.Forms.Label()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.dt_hasta = New System.Windows.Forms.DateTimePicker()
        Me.dt_desde = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Dg_Cabecera = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Dg_Cabecera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1299, 81)
        Me.Panel1.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.lbl_indicador)
        Me.GroupBox1.Controls.Add(Me.txt_indicador)
        Me.GroupBox1.Controls.Add(Me.LBL_can)
        Me.GroupBox1.Controls.Add(Me.txt_cantatiempo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_Cantpedidos)
        Me.GroupBox1.Controls.Add(Me.btnExportar)
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.dt_hasta)
        Me.GroupBox1.Controls.Add(Me.dt_desde)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1291, 69)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'lbl_indicador
        '
        Me.lbl_indicador.AutoSize = True
        Me.lbl_indicador.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_indicador.ForeColor = System.Drawing.Color.Black
        Me.lbl_indicador.Location = New System.Drawing.Point(900, 48)
        Me.lbl_indicador.Margin = New System.Windows.Forms.Padding(10, 0, 4, 0)
        Me.lbl_indicador.Name = "lbl_indicador"
        Me.lbl_indicador.Size = New System.Drawing.Size(103, 14)
        Me.lbl_indicador.TabIndex = 101
        Me.lbl_indicador.Text = "Dispatch One Time :"
        Me.lbl_indicador.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txt_indicador
        '
        Me.txt_indicador.AutoSize = True
        Me.txt_indicador.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_indicador.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txt_indicador.Location = New System.Drawing.Point(1012, 48)
        Me.txt_indicador.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txt_indicador.MaximumSize = New System.Drawing.Size(210, 18)
        Me.txt_indicador.MinimumSize = New System.Drawing.Size(210, 18)
        Me.txt_indicador.Name = "txt_indicador"
        Me.txt_indicador.Size = New System.Drawing.Size(210, 18)
        Me.txt_indicador.TabIndex = 102
        Me.txt_indicador.Text = "-"
        '
        'LBL_can
        '
        Me.LBL_can.AutoSize = True
        Me.LBL_can.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_can.ForeColor = System.Drawing.Color.Black
        Me.LBL_can.Location = New System.Drawing.Point(920, 23)
        Me.LBL_can.Margin = New System.Windows.Forms.Padding(10, 0, 4, 0)
        Me.LBL_can.Name = "LBL_can"
        Me.LBL_can.Size = New System.Drawing.Size(84, 14)
        Me.LBL_can.TabIndex = 99
        Me.LBL_can.Text = "Cant. a Tiempo :"
        Me.LBL_can.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txt_cantatiempo
        '
        Me.txt_cantatiempo.AutoSize = True
        Me.txt_cantatiempo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cantatiempo.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txt_cantatiempo.Location = New System.Drawing.Point(1012, 23)
        Me.txt_cantatiempo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txt_cantatiempo.MaximumSize = New System.Drawing.Size(210, 18)
        Me.txt_cantatiempo.MinimumSize = New System.Drawing.Size(210, 18)
        Me.txt_cantatiempo.Name = "txt_cantatiempo"
        Me.txt_cantatiempo.Size = New System.Drawing.Size(210, 18)
        Me.txt_cantatiempo.TabIndex = 100
        Me.txt_cantatiempo.Text = "-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(925, 0)
        Me.Label3.Margin = New System.Windows.Forms.Padding(10, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 14)
        Me.Label3.TabIndex = 97
        Me.Label3.Text = "Cant. Pedidos :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txt_Cantpedidos
        '
        Me.txt_Cantpedidos.AutoSize = True
        Me.txt_Cantpedidos.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Cantpedidos.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txt_Cantpedidos.Location = New System.Drawing.Point(1012, 0)
        Me.txt_Cantpedidos.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txt_Cantpedidos.MaximumSize = New System.Drawing.Size(210, 18)
        Me.txt_Cantpedidos.MinimumSize = New System.Drawing.Size(210, 18)
        Me.txt_Cantpedidos.Name = "txt_Cantpedidos"
        Me.txt_Cantpedidos.Size = New System.Drawing.Size(210, 18)
        Me.txt_Cantpedidos.TabIndex = 98
        Me.txt_Cantpedidos.Text = "-"
        '
        'btnExportar
        '
        Me.btnExportar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExportar.Location = New System.Drawing.Point(542, 13)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(100, 26)
        Me.btnExportar.TabIndex = 5
        Me.btnExportar.Text = "Exportar"
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.Image = Global.WindowsApp1.My.Resources.Resources._103
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(420, 13)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(100, 26)
        Me.btnBuscar.TabIndex = 4
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'dt_hasta
        '
        Me.dt_hasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_hasta.Location = New System.Drawing.Point(262, 14)
        Me.dt_hasta.Name = "dt_hasta"
        Me.dt_hasta.Size = New System.Drawing.Size(101, 20)
        Me.dt_hasta.TabIndex = 3
        '
        'dt_desde
        '
        Me.dt_desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_desde.Location = New System.Drawing.Point(80, 14)
        Me.dt_desde.Name = "dt_desde"
        Me.dt_desde.Size = New System.Drawing.Size(101, 20)
        Me.dt_desde.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(199, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fecha Fin:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha Inicio:"
        '
        'Dg_Cabecera
        '
        Me.Dg_Cabecera.AllowUserToAddRows = False
        Me.Dg_Cabecera.AllowUserToDeleteRows = False
        Me.Dg_Cabecera.AllowUserToResizeRows = False
        Me.Dg_Cabecera.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Dg_Cabecera.BackgroundColor = System.Drawing.Color.White
        Me.Dg_Cabecera.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Dg_Cabecera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dg_Cabecera.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dg_Cabecera.Location = New System.Drawing.Point(0, 81)
        Me.Dg_Cabecera.Name = "Dg_Cabecera"
        Me.Dg_Cabecera.RowHeadersVisible = False
        Me.Dg_Cabecera.RowTemplate.Height = 24
        Me.Dg_Cabecera.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dg_Cabecera.Size = New System.Drawing.Size(1299, 349)
        Me.Dg_Cabecera.TabIndex = 53
        '
        'GestionDispatchOnTime
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1299, 430)
        Me.Controls.Add(Me.Dg_Cabecera)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "GestionDispatchOnTime"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dispatch On Time"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Dg_Cabecera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents savedialog_Excel As SaveFileDialog
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnExportar As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents dt_hasta As DateTimePicker
    Friend WithEvents dt_desde As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_indicador As Label
    Friend WithEvents txt_indicador As Label
    Friend WithEvents LBL_can As Label
    Friend WithEvents txt_cantatiempo As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_Cantpedidos As Label
    Friend WithEvents Dg_Cabecera As DataGridView
End Class
