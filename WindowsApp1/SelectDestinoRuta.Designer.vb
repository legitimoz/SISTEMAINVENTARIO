﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectDestinoRuta
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
        Me.cmbo_destino = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmbo_destino
        '
        Me.cmbo_destino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbo_destino.FormattingEnabled = True
        Me.cmbo_destino.Location = New System.Drawing.Point(12, 12)
        Me.cmbo_destino.Name = "cmbo_destino"
        Me.cmbo_destino.Size = New System.Drawing.Size(206, 21)
        Me.cmbo_destino.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 67)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SelectDestinoRuta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(230, 102)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmbo_destino)
        Me.MaximizeBox = False
        Me.Name = "SelectDestinoRuta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seleccion Destino"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmbo_destino As ComboBox
    Friend WithEvents Button1 As Button
End Class
