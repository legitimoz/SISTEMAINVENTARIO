Public Class ProgressCell
    Inherits DataGridViewImageCell

    'Protected Overrides Function GetFormattedValue(ByVal value As Object, ByVal rowIndex As Integer, ByRef cellStyle As System.Windows.Forms.DataGridViewCellStyle, ByVal valueTypeConverter As System.ComponentModel.TypeConverter, ByVal formattedValueTypeConverter As System.ComponentModel.TypeConverter, ByVal context As System.Windows.Forms.DataGridViewDataErrorContexts) As Object
    '    ' Create bitmap.
    '    Dim bmp As Bitmap = New Bitmap(Me.Size.Width, Me.Size.Height)
    '    Using g As Graphics = Graphics.FromImage(bmp)
    '        ' Percentage.
    '        Dim percentage As Double = 0
    '        Double.TryParse(Me.Value.ToString(), percentage)
    '        Dim text As String = percentage.ToString() + " min"

    '        ' Get width and height of text.
    '        Dim f As Font = New Font("Verdana", 10, FontStyle.Regular)
    '        Dim w As Integer = CType(g.MeasureString(text, f).Width, Integer)
    '        Dim h As Integer = CType(g.MeasureString(text, f).Height, Integer)

    '        ' Draw pile.
    '        g.DrawRectangle(Pens.Black, 2, 2, Me.Size.Width - 6, Me.Size.Height - 6)
    '        g.FillRectangle(Brushes.Blue, 3, 3, CInt((Me.Size.Width - 6) * percentage / 100), CInt(Me.Size.Height - 7))

    '        Dim rect As RectangleF = New RectangleF(0, 0, bmp.Width, bmp.Height)
    '        Dim sf As StringFormat = New StringFormat()
    '        sf.Alignment = StringAlignment.Center
    '        g.DrawString(text, f, Brushes.Red, rect, sf)
    '    End Using
    '    Return bmp
    'End Function

    Protected Overrides Function GetFormattedValue(ByVal value As Object, ByVal rowIndex As Integer, ByRef cellStyle As System.Windows.Forms.DataGridViewCellStyle, ByVal valueTypeConverter As System.ComponentModel.TypeConverter, ByVal formattedValueTypeConverter As System.ComponentModel.TypeConverter, ByVal context As System.Windows.Forms.DataGridViewDataErrorContexts) As Object
        ' Create bitmap.
        Try
            Dim bmp As Bitmap = New Bitmap(Me.Size.Width, Me.Size.Height)

            If value IsNot Nothing Then

                Dim _total As Integer = 0
                Dim _porcentaje As Integer = 0

                'Dim resultado As Decimal
                'Dim _total As Decimal
                'Dim _porcentaje As Decimal

                'resultado = (_total / _porcentaje)

                Dim _indice As Integer = 0
                _indice = CStr(value).IndexOf("-")

                _porcentaje = CStr(value).Substring(0, _indice)
                _total = CStr(value).Remove(0, _indice + 1)

                Using g As Graphics = Graphics.FromImage(bmp)

                    ' Percentage.
                    Dim percentage As Double = 0
                    Double.TryParse(Me.Value.ToString(), percentage)

                    Dim text As String = _porcentaje.ToString() + " min"

                    ' Get width and height of text.
                    Dim f As Font = New Font("Verdana", 10, FontStyle.Regular)
                    Dim w As Integer = CType(g.MeasureString(text, f).Width, Integer)
                    Dim h As Integer = CType(g.MeasureString(text, f).Height, Integer)

                    ' Draw pile.
                    'g.DrawRectangle(Pens.Black, 2, 2, Me.Size.Width - 6, Me.Size.Height - 6)
                    'g.FillRectangle(Brushes.Blue, 3, 3, CInt((Me.Size.Width - 6) * percentage / _total), CInt(Me.Size.Height - 7))

                    g.DrawRectangle(Pens.Black, 2, 2, Me.Size.Width - 6, Me.Size.Height - 6)

                    If _total / _porcentaje >= 3 Then
                        g.FillRectangle(Brushes.Green, 3, 3, CInt((Me.Size.Width - 6) * _porcentaje / _total), CInt(Me.Size.Height - 7))
                    ElseIf ((_total / _porcentaje) < 3 And (_total / _porcentaje) >= 2) Then
                        g.FillRectangle(Brushes.Yellow, 3, 3, CInt((Me.Size.Width - 6) * _porcentaje / _total), CInt(Me.Size.Height - 7))
                    ElseIf (_total / _porcentaje) < 2 And (_total / _porcentaje) > 1 Then
                        g.FillRectangle(Brushes.Orange, 3, 3, CInt((Me.Size.Width - 6) * _porcentaje / _total), CInt(Me.Size.Height - 7))
                    ElseIf (_total / _porcentaje) <= 1 Then
                        g.FillRectangle(Brushes.Red, 3, 3, CInt((Me.Size.Width - 6) * _porcentaje / _total), CInt(Me.Size.Height - 7))
                    End If

                    'If Math.Round(_total Mod _porcentaje, 0) = 3 Then
                    '    g.FillRectangle(Brushes.Green, 3, 3, CInt((Me.Size.Width - 6) * _porcentaje / _total), CInt(Me.Size.Height - 7))
                    'ElseIf Math.Round(_total Mod _porcentaje) = 2 Then
                    '    g.FillRectangle(Brushes.DarkOrange, 3, 3, CInt((Me.Size.Width - 6) * _porcentaje / _total), CInt(Me.Size.Height - 7))
                    'Else
                    '    g.FillRectangle(Brushes.Red, 3, 3, CInt((Me.Size.Width - 6) * _porcentaje / _total), CInt(Me.Size.Height - 7))
                    'End If



                    Dim rect As RectangleF = New RectangleF(0, 0, bmp.Width, bmp.Height)
                    Dim sf As StringFormat = New StringFormat()
                    sf.Alignment = StringAlignment.Center
                    g.DrawString(text, f, Brushes.Blue, rect, sf)
                End Using

            Else
                bmp = Nothing
            End If

            Return bmp
        Catch ex As Exception
            Return Nothing
        End Try
       
    End Function

End Class
