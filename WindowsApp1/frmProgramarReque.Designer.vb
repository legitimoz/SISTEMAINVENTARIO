<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProgramarReque
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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboResponsable = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpFecIni = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.mtbHoraIni = New System.Windows.Forms.MaskedTextBox()
        Me.dtpFecFin = New System.Windows.Forms.DateTimePicker()
        Me.mtbHoraFin = New System.Windows.Forms.MaskedTextBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNroPro = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtIdReq = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 202)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(546, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Responsable"
        '
        'cboResponsable
        '
        Me.cboResponsable.BackColor = System.Drawing.Color.White
        Me.cboResponsable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboResponsable.FormattingEnabled = True
        Me.cboResponsable.Location = New System.Drawing.Point(100, 40)
        Me.cboResponsable.Name = "cboResponsable"
        Me.cboResponsable.Size = New System.Drawing.Size(189, 21)
        Me.cboResponsable.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Fecha Inicio"
        '
        'dtpFecIni
        '
        Me.dtpFecIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecIni.Location = New System.Drawing.Point(100, 72)
        Me.dtpFecIni.Name = "dtpFecIni"
        Me.dtpFecIni.Size = New System.Drawing.Size(120, 20)
        Me.dtpFecIni.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Fecha Fin"
        '
        'mtbHoraIni
        '
        Me.mtbHoraIni.Location = New System.Drawing.Point(231, 72)
        Me.mtbHoraIni.Mask = "00:00"
        Me.mtbHoraIni.Name = "mtbHoraIni"
        Me.mtbHoraIni.Size = New System.Drawing.Size(54, 20)
        Me.mtbHoraIni.TabIndex = 13
        Me.mtbHoraIni.ValidatingType = GetType(Date)
        '
        'dtpFecFin
        '
        Me.dtpFecFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecFin.Location = New System.Drawing.Point(100, 98)
        Me.dtpFecFin.Name = "dtpFecFin"
        Me.dtpFecFin.Size = New System.Drawing.Size(120, 20)
        Me.dtpFecFin.TabIndex = 14
        '
        'mtbHoraFin
        '
        Me.mtbHoraFin.Location = New System.Drawing.Point(231, 97)
        Me.mtbHoraFin.Mask = "00:00"
        Me.mtbHoraFin.Name = "mtbHoraFin"
        Me.mtbHoraFin.Size = New System.Drawing.Size(54, 20)
        Me.mtbHoraFin.TabIndex = 15
        Me.mtbHoraFin.ValidatingType = GetType(Date)
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.White
        Me.btnSalir.Image = Global.WindowsApp1.My.Resources.Resources.actn1121
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(197, 149)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(104, 23)
        Me.btnSalir.TabIndex = 17
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.White
        Me.btnGuardar.Image = Global.WindowsApp1.My.Resources.Resources._003
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(77, 149)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(104, 23)
        Me.btnGuardar.TabIndex = 16
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Nro Progra"
        '
        'txtNroPro
        '
        Me.txtNroPro.Location = New System.Drawing.Point(100, 12)
        Me.txtNroPro.Name = "txtNroPro"
        Me.txtNroPro.ReadOnly = True
        Me.txtNroPro.Size = New System.Drawing.Size(67, 20)
        Me.txtNroPro.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(173, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Nro Req"
        '
        'txtIdReq
        '
        Me.txtIdReq.Location = New System.Drawing.Point(222, 12)
        Me.txtIdReq.Name = "txtIdReq"
        Me.txtIdReq.ReadOnly = True
        Me.txtIdReq.Size = New System.Drawing.Size(67, 20)
        Me.txtIdReq.TabIndex = 21
        '
        'frmProgramarReque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(546, 224)
        Me.Controls.Add(Me.txtIdReq)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtNroPro)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.mtbHoraFin)
        Me.Controls.Add(Me.dtpFecFin)
        Me.Controls.Add(Me.mtbHoraIni)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpFecIni)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboResponsable)
        Me.Controls.Add(Me.StatusStrip1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmProgramarReque"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Programar Requerimiento"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents Label3 As Label
    Friend WithEvents cboResponsable As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpFecIni As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents mtbHoraIni As MaskedTextBox
    Friend WithEvents dtpFecFin As DateTimePicker
    Friend WithEvents mtbHoraFin As MaskedTextBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNroPro As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtIdReq As TextBox
End Class
