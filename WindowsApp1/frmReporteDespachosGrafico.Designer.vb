<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteDespachosGrafico
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
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbtMotivoRechazado = New System.Windows.Forms.RadioButton()
        Me.rbtEstadoDespacho = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpFecfin = New System.Windows.Forms.DateTimePicker()
        Me.dtpFecini = New System.Windows.Forms.DateTimePicker()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtpFecfin)
        Me.GroupBox1.Controls.Add(Me.dtpFecini)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 2)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(883, 64)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtros por:"
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = Global.WindowsApp1.My.Resources.Resources._103
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(664, 18)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(115, 32)
        Me.btnBuscar.TabIndex = 5
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbtMotivoRechazado)
        Me.GroupBox2.Controls.Add(Me.rbtEstadoDespacho)
        Me.GroupBox2.Location = New System.Drawing.Point(358, 9)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(289, 46)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        '
        'rbtMotivoRechazado
        '
        Me.rbtMotivoRechazado.AutoSize = True
        Me.rbtMotivoRechazado.Location = New System.Drawing.Point(145, 17)
        Me.rbtMotivoRechazado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rbtMotivoRechazado.Name = "rbtMotivoRechazado"
        Me.rbtMotivoRechazado.Size = New System.Drawing.Size(128, 17)
        Me.rbtMotivoRechazado.TabIndex = 1
        Me.rbtMotivoRechazado.TabStop = True
        Me.rbtMotivoRechazado.Text = "Motivos de Rechazos"
        Me.rbtMotivoRechazado.UseVisualStyleBackColor = True
        '
        'rbtEstadoDespacho
        '
        Me.rbtEstadoDespacho.AutoSize = True
        Me.rbtEstadoDespacho.Location = New System.Drawing.Point(11, 17)
        Me.rbtEstadoDespacho.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rbtEstadoDespacho.Name = "rbtEstadoDespacho"
        Me.rbtEstadoDespacho.Size = New System.Drawing.Size(125, 17)
        Me.rbtEstadoDespacho.TabIndex = 0
        Me.rbtEstadoDespacho.TabStop = True
        Me.rbtEstadoDespacho.Text = "Estado de Despacho"
        Me.rbtEstadoDespacho.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(181, 26)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Fecha Fin"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Fecha Inicio"
        '
        'dtpFecfin
        '
        Me.dtpFecfin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecfin.Location = New System.Drawing.Point(238, 24)
        Me.dtpFecfin.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpFecfin.Name = "dtpFecfin"
        Me.dtpFecfin.Size = New System.Drawing.Size(89, 20)
        Me.dtpFecfin.TabIndex = 1
        '
        'dtpFecini
        '
        Me.dtpFecini.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecini.Location = New System.Drawing.Point(76, 24)
        Me.dtpFecini.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpFecini.Name = "dtpFecini"
        Me.dtpFecini.Size = New System.Drawing.Size(89, 20)
        Me.dtpFecini.TabIndex = 0
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(4, 70)
        Me.CrystalReportViewer1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(883, 549)
        Me.CrystalReportViewer1.TabIndex = 1
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'frmReporteDespachosGrafico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(890, 609)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmReporteDespachosGrafico"
        Me.Text = "Reporte de Despachos Totalizado"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rbtMotivoRechazado As RadioButton
    Friend WithEvents rbtEstadoDespacho As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpFecfin As DateTimePicker
    Friend WithEvents dtpFecini As DateTimePicker
    Friend WithEvents btnBuscar As Button
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
