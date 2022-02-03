<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAsignarCliente
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
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.btnAsignar = New System.Windows.Forms.Button()
        Me.txtCotizador = New System.Windows.Forms.TextBox()
        Me.txtCodCoti = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtVendedor = New System.Windows.Forms.TextBox()
        Me.txtCodVend = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtRuc = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtIdSolicitud = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtIdSolicitud)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.btnConsultar)
        Me.GroupBox1.Controls.Add(Me.btnAsignar)
        Me.GroupBox1.Controls.Add(Me.txtCotizador)
        Me.GroupBox1.Controls.Add(Me.txtCodCoti)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtVendedor)
        Me.GroupBox1.Controls.Add(Me.txtCodVend)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtCliente)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtRuc)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 7)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(623, 303)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Cliente"
        '
        'btnConsultar
        '
        Me.btnConsultar.Image = Global.WindowsApp1.My.Resources.Resources._103
        Me.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConsultar.Location = New System.Drawing.Point(455, 20)
        Me.btnConsultar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(145, 35)
        Me.btnConsultar.TabIndex = 21
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'btnAsignar
        '
        Me.btnAsignar.Image = Global.WindowsApp1.My.Resources.Resources._0032
        Me.btnAsignar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAsignar.Location = New System.Drawing.Point(226, 235)
        Me.btnAsignar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAsignar.Name = "btnAsignar"
        Me.btnAsignar.Size = New System.Drawing.Size(145, 35)
        Me.btnAsignar.TabIndex = 20
        Me.btnAsignar.Text = "Asignar"
        Me.btnAsignar.UseVisualStyleBackColor = True
        '
        'txtCotizador
        '
        Me.txtCotizador.Location = New System.Drawing.Point(168, 147)
        Me.txtCotizador.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.txtCotizador.Name = "txtCotizador"
        Me.txtCotizador.ReadOnly = True
        Me.txtCotizador.Size = New System.Drawing.Size(432, 21)
        Me.txtCotizador.TabIndex = 19
        '
        'txtCodCoti
        '
        Me.txtCodCoti.Location = New System.Drawing.Point(71, 147)
        Me.txtCodCoti.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.txtCodCoti.Name = "txtCodCoti"
        Me.txtCodCoti.ReadOnly = True
        Me.txtCodCoti.Size = New System.Drawing.Size(81, 21)
        Me.txtCodCoti.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 152)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Cotizador"
        '
        'txtVendedor
        '
        Me.txtVendedor.Location = New System.Drawing.Point(168, 115)
        Me.txtVendedor.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.txtVendedor.Name = "txtVendedor"
        Me.txtVendedor.ReadOnly = True
        Me.txtVendedor.Size = New System.Drawing.Size(432, 21)
        Me.txtVendedor.TabIndex = 16
        '
        'txtCodVend
        '
        Me.txtCodVend.Location = New System.Drawing.Point(71, 115)
        Me.txtCodVend.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.txtCodVend.Name = "txtCodVend"
        Me.txtCodVend.ReadOnly = True
        Me.txtCodVend.Size = New System.Drawing.Size(81, 21)
        Me.txtCodVend.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 120)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Vendedor"
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(71, 82)
        Me.txtCliente.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.ReadOnly = True
        Me.txtCliente.Size = New System.Drawing.Size(529, 21)
        Me.txtCliente.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 85)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Cliente"
        '
        'txtRuc
        '
        Me.txtRuc.Location = New System.Drawing.Point(71, 52)
        Me.txtRuc.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.txtRuc.Name = "txtRuc"
        Me.txtRuc.ReadOnly = True
        Me.txtRuc.Size = New System.Drawing.Size(218, 21)
        Me.txtRuc.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 55)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Ruc"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 27)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Solicitud"
        '
        'txtIdSolicitud
        '
        Me.txtIdSolicitud.Location = New System.Drawing.Point(71, 22)
        Me.txtIdSolicitud.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.txtIdSolicitud.Name = "txtIdSolicitud"
        Me.txtIdSolicitud.ReadOnly = True
        Me.txtIdSolicitud.Size = New System.Drawing.Size(218, 21)
        Me.txtIdSolicitud.TabIndex = 23
        '
        'frmAsignarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(637, 313)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAsignarCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asignar Cliente"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnConsultar As Button
    Friend WithEvents btnAsignar As Button
    Friend WithEvents txtCotizador As TextBox
    Friend WithEvents txtCodCoti As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtVendedor As TextBox
    Friend WithEvents txtCodVend As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtRuc As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtIdSolicitud As TextBox
    Friend WithEvents Label5 As Label
End Class
