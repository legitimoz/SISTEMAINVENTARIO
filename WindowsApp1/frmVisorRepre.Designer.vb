<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVisorRepre
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVisorRepre))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboTipo = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkComercial = New System.Windows.Forms.CheckBox()
        Me.ckbPneumo = New System.Windows.Forms.CheckBox()
        Me.ckbHuman = New System.Windows.Forms.CheckBox()
        Me.ckbLifeScience = New System.Windows.Forms.CheckBox()
        Me.ckbBhealth = New System.Windows.Forms.CheckBox()
        Me.txtRepresentante = New System.Windows.Forms.TextBox()
        Me.lblRepre = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.btnExcel = New System.Windows.Forms.Button()
        Me.dgvRepresentantes = New System.Windows.Forms.DataGridView()
        Me.repre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codrepre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Venta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantPed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantVisMed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantVisBF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codrepre2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtBusRepre = New System.Windows.Forms.TextBox()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgvVisitasMedicas = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgvBoticasFarmacias = New System.Windows.Forms.DataGridView()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.dgvPedidos = New System.Windows.Forms.DataGridView()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tslCantRepre = New System.Windows.Forms.ToolStripStatusLabel()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dgvRepresentantes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvVisitasMedicas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvBoticasFarmacias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.dgvPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.GroupBox1.Controls.Add(Me.cboTipo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.dtpFechaFin)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.chkComercial)
        Me.GroupBox1.Controls.Add(Me.ckbPneumo)
        Me.GroupBox1.Controls.Add(Me.ckbHuman)
        Me.GroupBox1.Controls.Add(Me.ckbLifeScience)
        Me.GroupBox1.Controls.Add(Me.ckbBhealth)
        Me.GroupBox1.Controls.Add(Me.txtRepresentante)
        Me.GroupBox1.Controls.Add(Me.lblRepre)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnConsultar)
        Me.GroupBox1.Controls.Add(Me.dtpFecha)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1064, 65)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtros"
        '
        'cboTipo
        '
        Me.cboTipo.BackColor = System.Drawing.Color.White
        Me.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.Items.AddRange(New Object() {"--TODOS--", "LIMA", "PROVINCIA"})
        Me.cboTipo.Location = New System.Drawing.Point(77, 41)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(89, 21)
        Me.cboTipo.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(42, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Tipo:"
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.Location = New System.Drawing.Point(229, 17)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(89, 21)
        Me.dtpFechaFin.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(172, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Fecha Fin:"
        '
        'chkComercial
        '
        Me.chkComercial.AutoSize = True
        Me.chkComercial.Location = New System.Drawing.Point(821, 44)
        Me.chkComercial.Name = "chkComercial"
        Me.chkComercial.Size = New System.Drawing.Size(85, 17)
        Me.chkComercial.TabIndex = 9
        Me.chkComercial.Text = "COMERCIAL"
        Me.chkComercial.UseVisualStyleBackColor = True
        '
        'ckbPneumo
        '
        Me.ckbPneumo.AutoSize = True
        Me.ckbPneumo.Location = New System.Drawing.Point(719, 44)
        Me.ckbPneumo.Name = "ckbPneumo"
        Me.ckbPneumo.Size = New System.Drawing.Size(98, 17)
        Me.ckbPneumo.TabIndex = 8
        Me.ckbPneumo.Text = "PNEUMO CARE"
        Me.ckbPneumo.UseVisualStyleBackColor = True
        '
        'ckbHuman
        '
        Me.ckbHuman.AutoSize = True
        Me.ckbHuman.Location = New System.Drawing.Point(620, 44)
        Me.ckbHuman.Name = "ckbHuman"
        Me.ckbHuman.Size = New System.Drawing.Size(92, 17)
        Me.ckbHuman.TabIndex = 7
        Me.ckbHuman.Text = "HUMAN CARE"
        Me.ckbHuman.UseVisualStyleBackColor = True
        '
        'ckbLifeScience
        '
        Me.ckbLifeScience.AutoSize = True
        Me.ckbLifeScience.Location = New System.Drawing.Point(524, 44)
        Me.ckbLifeScience.Name = "ckbLifeScience"
        Me.ckbLifeScience.Size = New System.Drawing.Size(93, 17)
        Me.ckbLifeScience.TabIndex = 6
        Me.ckbLifeScience.Text = "LIFE SCIENCE"
        Me.ckbLifeScience.UseVisualStyleBackColor = True
        '
        'ckbBhealth
        '
        Me.ckbBhealth.AutoSize = True
        Me.ckbBhealth.Location = New System.Drawing.Point(448, 44)
        Me.ckbBhealth.Name = "ckbBhealth"
        Me.ckbBhealth.Size = New System.Drawing.Size(70, 17)
        Me.ckbBhealth.TabIndex = 1
        Me.ckbBhealth.Text = "BHEALTH"
        Me.ckbBhealth.UseVisualStyleBackColor = True
        '
        'txtRepresentante
        '
        Me.txtRepresentante.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRepresentante.Location = New System.Drawing.Point(448, 17)
        Me.txtRepresentante.Name = "txtRepresentante"
        Me.txtRepresentante.Size = New System.Drawing.Size(333, 22)
        Me.txtRepresentante.TabIndex = 5
        '
        'lblRepre
        '
        Me.lblRepre.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRepre.AutoSize = True
        Me.lblRepre.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRepre.Location = New System.Drawing.Point(460, 20)
        Me.lblRepre.Name = "lblRepre"
        Me.lblRepre.Size = New System.Drawing.Size(10, 13)
        Me.lblRepre.TabIndex = 4
        Me.lblRepre.Text = "."
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(348, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "REPRESENTANTE:"
        '
        'btnConsultar
        '
        Me.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConsultar.Image = Global.WindowsApp1.My.Resources.Resources._104
        Me.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConsultar.Location = New System.Drawing.Point(178, 40)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(140, 23)
        Me.btnConsultar.TabIndex = 2
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(77, 17)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(89, 21)
        Me.dtpFecha.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha Inicio:"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(4, 70)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnExcel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.dgvRepresentantes)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtBusRepre)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1063, 420)
        Me.SplitContainer1.SplitterDistance = 285
        Me.SplitContainer1.TabIndex = 1
        '
        'btnExcel
        '
        Me.btnExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExcel.Image = CType(resources.GetObject("btnExcel.Image"), System.Drawing.Image)
        Me.btnExcel.Location = New System.Drawing.Point(238, 6)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(38, 23)
        Me.btnExcel.TabIndex = 2
        Me.btnExcel.Text = ".."
        Me.btnExcel.UseVisualStyleBackColor = True
        '
        'dgvRepresentantes
        '
        Me.dgvRepresentantes.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.MistyRose
        Me.dgvRepresentantes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvRepresentantes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvRepresentantes.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.dgvRepresentantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRepresentantes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.repre, Me.codrepre, Me.Venta, Me.CantPed, Me.CantVisMed, Me.CantVisBF, Me.codrepre2})
        Me.dgvRepresentantes.Location = New System.Drawing.Point(7, 34)
        Me.dgvRepresentantes.MultiSelect = False
        Me.dgvRepresentantes.Name = "dgvRepresentantes"
        Me.dgvRepresentantes.ReadOnly = True
        Me.dgvRepresentantes.RowHeadersWidth = 51
        Me.dgvRepresentantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRepresentantes.Size = New System.Drawing.Size(267, 381)
        Me.dgvRepresentantes.TabIndex = 1
        '
        'repre
        '
        Me.repre.HeaderText = "REPRESENTANTE"
        Me.repre.MinimumWidth = 6
        Me.repre.Name = "repre"
        Me.repre.ReadOnly = True
        Me.repre.Width = 120
        '
        'codrepre
        '
        Me.codrepre.HeaderText = "CODREPRE"
        Me.codrepre.MinimumWidth = 6
        Me.codrepre.Name = "codrepre"
        Me.codrepre.ReadOnly = True
        Me.codrepre.Visible = False
        Me.codrepre.Width = 50
        '
        'Venta
        '
        Me.Venta.FillWeight = 50.0!
        Me.Venta.HeaderText = "VENTA"
        Me.Venta.MinimumWidth = 6
        Me.Venta.Name = "Venta"
        Me.Venta.ReadOnly = True
        Me.Venta.Width = 60
        '
        'CantPed
        '
        Me.CantPed.HeaderText = "PEDIDO"
        Me.CantPed.MinimumWidth = 6
        Me.CantPed.Name = "CantPed"
        Me.CantPed.ReadOnly = True
        Me.CantPed.Width = 40
        '
        'CantVisMed
        '
        Me.CantVisMed.HeaderText = "MEDICO"
        Me.CantVisMed.MinimumWidth = 6
        Me.CantVisMed.Name = "CantVisMed"
        Me.CantVisMed.ReadOnly = True
        Me.CantVisMed.Width = 40
        '
        'CantVisBF
        '
        Me.CantVisBF.HeaderText = "FARM_BOT"
        Me.CantVisBF.MinimumWidth = 6
        Me.CantVisBF.Name = "CantVisBF"
        Me.CantVisBF.ReadOnly = True
        Me.CantVisBF.Width = 40
        '
        'codrepre2
        '
        Me.codrepre2.HeaderText = "CODIGO"
        Me.codrepre2.MinimumWidth = 6
        Me.codrepre2.Name = "codrepre2"
        Me.codrepre2.ReadOnly = True
        Me.codrepre2.Width = 70
        '
        'txtBusRepre
        '
        Me.txtBusRepre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBusRepre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBusRepre.Location = New System.Drawing.Point(7, 7)
        Me.txtBusRepre.Name = "txtBusRepre"
        Me.txtBusRepre.Size = New System.Drawing.Size(228, 21)
        Me.txtBusRepre.TabIndex = 0
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer2.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.TabControl1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.TabControl2)
        Me.SplitContainer2.Size = New System.Drawing.Size(768, 415)
        Me.SplitContainer2.SplitterDistance = 226
        Me.SplitContainer2.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(5, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(757, 216)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgvVisitasMedicas)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(749, 190)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Visitas Medicas"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgvVisitasMedicas
        '
        Me.dgvVisitasMedicas.AllowUserToAddRows = False
        Me.dgvVisitasMedicas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvVisitasMedicas.BackgroundColor = System.Drawing.Color.White
        Me.dgvVisitasMedicas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVisitasMedicas.Location = New System.Drawing.Point(6, 6)
        Me.dgvVisitasMedicas.Name = "dgvVisitasMedicas"
        Me.dgvVisitasMedicas.RowHeadersWidth = 51
        Me.dgvVisitasMedicas.Size = New System.Drawing.Size(733, 181)
        Me.dgvVisitasMedicas.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgvBoticasFarmacias)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(749, 190)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Visitas Boticas & Farmacias"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgvBoticasFarmacias
        '
        Me.dgvBoticasFarmacias.AllowUserToAddRows = False
        Me.dgvBoticasFarmacias.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvBoticasFarmacias.BackgroundColor = System.Drawing.Color.White
        Me.dgvBoticasFarmacias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBoticasFarmacias.Location = New System.Drawing.Point(6, 5)
        Me.dgvBoticasFarmacias.Name = "dgvBoticasFarmacias"
        Me.dgvBoticasFarmacias.RowHeadersWidth = 51
        Me.dgvBoticasFarmacias.Size = New System.Drawing.Size(733, 179)
        Me.dgvBoticasFarmacias.TabIndex = 0
        '
        'TabControl2
        '
        Me.TabControl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl2.Controls.Add(Me.TabPage3)
        Me.TabControl2.Location = New System.Drawing.Point(4, 7)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(754, 174)
        Me.TabControl2.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.dgvPedidos)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(746, 148)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "Pedidos"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'dgvPedidos
        '
        Me.dgvPedidos.AllowUserToAddRows = False
        Me.dgvPedidos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPedidos.BackgroundColor = System.Drawing.Color.White
        Me.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPedidos.Location = New System.Drawing.Point(7, 6)
        Me.dgvPedidos.Name = "dgvPedidos"
        Me.dgvPedidos.RowHeadersWidth = 51
        Me.dgvPedidos.Size = New System.Drawing.Size(733, 135)
        Me.dgvPedidos.TabIndex = 0
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.tslCantRepre})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 495)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1069, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(71, 17)
        Me.ToolStripStatusLabel1.Text = "Cant. Repre:"
        '
        'tslCantRepre
        '
        Me.tslCantRepre.Name = "tslCantRepre"
        Me.tslCantRepre.Size = New System.Drawing.Size(13, 17)
        Me.tslCantRepre.Text = "0"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "REPRESENTANTE"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 205
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "CODREPRE"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        Me.DataGridViewTextBoxColumn2.Width = 80
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.FillWeight = 50.0!
        Me.DataGridViewTextBoxColumn3.HeaderText = "NRO_VISMED"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 40
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "NRO_VISBF"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 40
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "CODREPRE"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 50
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "FARM_BOT"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 40
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "CODIGO"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 70
        '
        'frmVisorRepre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1069, 517)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmVisorRepre"
        Me.Text = "Dashboard Representantes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dgvRepresentantes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgvVisitasMedicas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgvBoticasFarmacias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        CType(Me.dgvPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents txtBusRepre As TextBox
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents dgvRepresentantes As DataGridView
    Friend WithEvents dgvVisitasMedicas As DataGridView
    Friend WithEvents dgvPedidos As DataGridView
    Friend WithEvents dgvBoticasFarmacias As DataGridView
    Friend WithEvents btnConsultar As Button
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents lblRepre As Label
    Friend WithEvents txtRepresentante As TextBox
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents chkComercial As CheckBox
    Friend WithEvents ckbPneumo As CheckBox
    Friend WithEvents ckbHuman As CheckBox
    Friend WithEvents ckbLifeScience As CheckBox
    Friend WithEvents ckbBhealth As CheckBox
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents dtpFechaFin As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents cboTipo As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents repre As DataGridViewTextBoxColumn
    Friend WithEvents codrepre As DataGridViewTextBoxColumn
    Friend WithEvents Venta As DataGridViewTextBoxColumn
    Friend WithEvents CantPed As DataGridViewTextBoxColumn
    Friend WithEvents CantVisMed As DataGridViewTextBoxColumn
    Friend WithEvents CantVisBF As DataGridViewTextBoxColumn
    Friend WithEvents codrepre2 As DataGridViewTextBoxColumn
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents tslCantRepre As ToolStripStatusLabel
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents btnExcel As Button
End Class
