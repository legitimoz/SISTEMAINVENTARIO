Imports System.Globalization

Public Class DateTimeCell

    Inherits DataGridViewTextBoxCell

    Public Sub New()
        MyBase.New()
    End Sub

    Public Overrides ReadOnly Property EditType As Type
        Get
            Return GetType(DateTimeEditingControl)
        End Get
    End Property

    Public Overrides ReadOnly Property ValueType As Type
        Get
            Return GetType(DateTime)
        End Get
    End Property

    Public Overrides ReadOnly Property DefaultNewRowValue As Object
        Get
            Dim defaultValue As Object = MyBase.DefaultNewRowValue
            If TypeOf defaultValue Is DateTime Then
                Return defaultValue
            Else
                Return DateTime.Now
            End If
        End Get
    End Property

    Public Overrides Sub InitializeEditingControl(rowIndex As Integer, initialFormattedValue As Object, _
                                                  dataGridViewCellStyle As DataGridViewCellStyle)
        MyBase.InitializeEditingControl(rowIndex, initialFormattedValue, dataGridViewCellStyle)
        Dim ctl As DateTimeEditingControl = CType(DataGridView.EditingControl, DateTimeEditingControl)
        Try
            If Me.Value = Nothing Then
                ctl.Value = CType(Me.DefaultNewRowValue, DateTime)
            Else
                ctl.Value = CType(Me.Value, DateTime)
            End If
        Catch ex As Exception
            ctl.Value = CType(Me.DefaultNewRowValue, DateTime)
        End Try

        If dataGridViewCellStyle.Format.Length = 1 Then
            Dim patterns As String() = DateTimeFormatInfo.CurrentInfo.GetAllDateTimePatterns( _
                dataGridViewCellStyle.Format.ToCharArray()(0))
            If patterns.Length > 0 Then
                ctl.CustomFormat = patterns(0).ToString()
            Else
                ctl.CustomFormat = dataGridViewCellStyle.Format
            End If
        Else
            ctl.CustomFormat = dataGridViewCellStyle.Format
        End If
    End Sub


End Class
