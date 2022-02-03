Public Class ProgressColumn
    Inherits DataGridViewColumn

    Public Sub New()
        'MyBase.New()
        'Dim a As New ProgressCell
        'a.Total = _total1
        MyBase.New(New ProgressCell())
    End Sub

    Public Overrides Property CellTemplate() As DataGridViewCell
        Get
            Return MyBase.CellTemplate
        End Get

        Set(ByVal Value As DataGridViewCell)
            ' Ensure that the cell used for the template is a ProgressCell.
            If Value IsNot Nothing And Not TypeOf (Value) Is ProgressCell Then
                Throw New InvalidCastException("Must be a ProgressCell")
            End If
            MyBase.CellTemplate = Value
        End Set

    End Property

End Class
