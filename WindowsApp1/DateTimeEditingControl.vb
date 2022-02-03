Public Class DateTimeEditingControl

    Inherits DateTimePicker
    Implements IDataGridViewEditingControl

    Private grid As DataGridView
    Private valChanged As Boolean

    Public Sub New()
        Me.Format = DateTimePickerFormat.Custom
    End Sub

    Protected Overrides Sub OnValueChanged(eventargs As EventArgs)
        MyBase.OnValueChanged(eventargs)
        SendToGridValueChanged()
    End Sub

    Private Sub SendToGridValueChanged()
        valChanged = True
        If grid IsNot Nothing Then
            grid.NotifyCurrentCellDirty(True)
        End If
    End Sub

#Region "Miembros de IDataGridViewEditingControl"

    Public Sub ApplyCellStyleToEditingControl(dataGridViewCellStyle As DataGridViewCellStyle) _
        Implements IDataGridViewEditingControl.ApplyCellStyleToEditingControl
        Me.Font = dataGridViewCellStyle.Font
        Me.CalendarForeColor = dataGridViewCellStyle.ForeColor
        Me.CalendarMonthBackground = dataGridViewCellStyle.BackColor
    End Sub

    Public Property EditingControlDataGridView As DataGridView _
        Implements IDataGridViewEditingControl.EditingControlDataGridView
        Get
            Return grid
        End Get
        Set(value As DataGridView)
            grid = value
        End Set
    End Property

    Public Property EditingControlFormattedValue As Object _
        Implements IDataGridViewEditingControl.EditingControlFormattedValue
        Get
            Return Me.Value.ToString(Me.CustomFormat)
        End Get
        Set(value As Object)
            Try
                Me.Value = DateTime.Parse(CType(value, String))
            Catch ex As Exception
                Me.Value = DateTime.Now
            End Try
            SendToGridValueChanged()
        End Set
    End Property

    Public Property EditingControlRowIndex As Integer _
        Implements IDataGridViewEditingControl.EditingControlRowIndex

    Public Property EditingControlValueChanged As Boolean _
        Implements IDataGridViewEditingControl.EditingControlValueChanged
        Get
            Return valChanged
        End Get
        Set(value As Boolean)
            valChanged = value
        End Set
    End Property

    Public Function EditingControlWantsInputKey(keyData As Keys, dataGridViewWantsInputKey As Boolean) As Boolean _
        Implements IDataGridViewEditingControl.EditingControlWantsInputKey
        Select Case keyData And Keys.KeyCode
            Case Keys.Left, Keys.Up, Keys.Down, Keys.Right, _
                Keys.Home, Keys.End, Keys.PageDown, Keys.PageUp
                Return True
            Case Else
                Return Not dataGridViewWantsInputKey
        End Select
    End Function

    Public ReadOnly Property EditingPanelCursor As Cursor _
        Implements IDataGridViewEditingControl.EditingPanelCursor
        Get
            Return MyBase.Cursor
        End Get
    End Property

    Public Function GetEditingControlFormattedValue(context As DataGridViewDataErrorContexts) As Object _
        Implements IDataGridViewEditingControl.GetEditingControlFormattedValue
        Return EditingControlFormattedValue
    End Function

    Public Sub PrepareEditingControlForEdit(selectAll As Boolean) _
        Implements IDataGridViewEditingControl.PrepareEditingControlForEdit

    End Sub

    Public ReadOnly Property RepositionEditingControlOnValueChange As Boolean _
        Implements IDataGridViewEditingControl.RepositionEditingControlOnValueChange
        Get
            Return False
        End Get
    End Property

#End Region
End Class
