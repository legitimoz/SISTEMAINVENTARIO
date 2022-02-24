<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MedicionEsfuerzo
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
        Me.components = New System.ComponentModel.Container()
        Me.Dg_Cabecera = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumGuia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantCM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAJASINT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UNIDADES = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PROCM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PROCI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PROUN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HORASHOMBRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_Horas = New System.Windows.Forms.Label()
        Me.txt_horasfaltan = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_cantPersonas = New System.Windows.Forms.TextBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.Dg_Cabecera, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Dg_Cabecera
        '
        Me.Dg_Cabecera.AllowDrop = True
        Me.Dg_Cabecera.AllowUserToAddRows = False
        Me.Dg_Cabecera.AllowUserToDeleteRows = False
        Me.Dg_Cabecera.BackgroundColor = System.Drawing.Color.White
        Me.Dg_Cabecera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dg_Cabecera.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumGuia, Me.CantCM, Me.CAJASINT, Me.UNIDADES, Me.PROCM, Me.PROCI, Me.PROUN, Me.HORASHOMBRE})
        Me.Dg_Cabecera.Location = New System.Drawing.Point(9, 9)
        Me.Dg_Cabecera.Margin = New System.Windows.Forms.Padding(0)
        Me.Dg_Cabecera.MultiSelect = False
        Me.Dg_Cabecera.Name = "Dg_Cabecera"
        Me.Dg_Cabecera.RowHeadersVisible = False
        Me.Dg_Cabecera.RowHeadersWidth = 20
        Me.Dg_Cabecera.RowTemplate.Height = 20
        Me.Dg_Cabecera.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dg_Cabecera.Size = New System.Drawing.Size(813, 479)
        Me.Dg_Cabecera.TabIndex = 10
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "N° GUIA"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "CAJAS MASTER"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "CAJAS INTERNAS"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "UNIDADES"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "PCM"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "PCI"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "PU"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "HORAS HOMBRE"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'NumGuia
        '
        Me.NumGuia.HeaderText = "N° GUIA"
        Me.NumGuia.Name = "NumGuia"
        '
        'CantCM
        '
        Me.CantCM.HeaderText = "CAJAS MASTER"
        Me.CantCM.Name = "CantCM"
        '
        'CAJASINT
        '
        Me.CAJASINT.HeaderText = "CAJAS INTERNAS"
        Me.CAJASINT.Name = "CAJASINT"
        '
        'UNIDADES
        '
        Me.UNIDADES.HeaderText = "UNIDADES"
        Me.UNIDADES.Name = "UNIDADES"
        '
        'PROCM
        '
        Me.PROCM.HeaderText = "PCM"
        Me.PROCM.Name = "PROCM"
        '
        'PROCI
        '
        Me.PROCI.HeaderText = "PCI"
        Me.PROCI.Name = "PROCI"
        '
        'PROUN
        '
        Me.PROUN.HeaderText = "PU"
        Me.PROUN.Name = "PROUN"
        '
        'HORASHOMBRE
        '
        Me.HORASHOMBRE.HeaderText = "HORAS HOMBRE"
        Me.HORASHOMBRE.Name = "HORASHOMBRE"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(825, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Procesar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(825, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Total Horas"
        '
        'txt_Horas
        '
        Me.txt_Horas.AutoSize = True
        Me.txt_Horas.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Horas.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txt_Horas.Location = New System.Drawing.Point(908, 58)
        Me.txt_Horas.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txt_Horas.MaximumSize = New System.Drawing.Size(50, 18)
        Me.txt_Horas.MinimumSize = New System.Drawing.Size(50, 18)
        Me.txt_Horas.Name = "txt_Horas"
        Me.txt_Horas.Size = New System.Drawing.Size(50, 18)
        Me.txt_Horas.TabIndex = 99
        Me.txt_Horas.Text = "-"
        '
        'txt_horasfaltan
        '
        Me.txt_horasfaltan.Location = New System.Drawing.Point(910, 81)
        Me.txt_horasfaltan.Name = "txt_horasfaltan"
        Me.txt_horasfaltan.Size = New System.Drawing.Size(100, 20)
        Me.txt_horasfaltan.TabIndex = 100
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(825, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 101
        Me.Label2.Text = "Horas Faltan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(825, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 103
        Me.Label3.Text = "Cant. Personas"
        '
        'txt_cantPersonas
        '
        Me.txt_cantPersonas.Location = New System.Drawing.Point(910, 107)
        Me.txt_cantPersonas.Name = "txt_cantPersonas"
        Me.txt_cantPersonas.Size = New System.Drawing.Size(100, 20)
        Me.txt_cantPersonas.TabIndex = 102
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'MedicionEsfuerzo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1038, 497)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_cantPersonas)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_horasfaltan)
        Me.Controls.Add(Me.txt_Horas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Dg_Cabecera)
        Me.MaximizeBox = False
        Me.Name = "MedicionEsfuerzo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Medicion Productividad"
        CType(Me.Dg_Cabecera, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Dg_Cabecera As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents NumGuia As DataGridViewTextBoxColumn
    Friend WithEvents CantCM As DataGridViewTextBoxColumn
    Friend WithEvents CAJASINT As DataGridViewTextBoxColumn
    Friend WithEvents UNIDADES As DataGridViewTextBoxColumn
    Friend WithEvents PROCM As DataGridViewTextBoxColumn
    Friend WithEvents PROCI As DataGridViewTextBoxColumn
    Friend WithEvents PROUN As DataGridViewTextBoxColumn
    Friend WithEvents HORASHOMBRE As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_Horas As Label
    Friend WithEvents txt_horasfaltan As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_cantPersonas As TextBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
