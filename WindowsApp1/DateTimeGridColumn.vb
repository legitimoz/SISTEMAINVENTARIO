Public Class DateTimeGridColumn

    Inherits DataGridViewColumn

    Public Sub New()
        MyBase.New(New DateTimeCell())
    End Sub

    Public Overrides Property CellTemplate As DataGridViewCell
        Get
            Return MyBase.CellTemplate
        End Get
        Set(value As DataGridViewCell)
            If value IsNot Nothing AndAlso _
                Not value.GetType().IsAssignableFrom(GetType(DateTimeCell)) Then
                Throw New InvalidCastException("Debe especificar una instancia de DateTimeCell")
            End If
            MyBase.CellTemplate = value
        End Set
    End Property

End Class
