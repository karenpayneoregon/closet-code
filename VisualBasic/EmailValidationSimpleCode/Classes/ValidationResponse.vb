Imports System.ComponentModel.DataAnnotations

Public Class ValidationResponse
    Public Property Results() As List(Of ValidationResult)
    Public Property IsValid() As Boolean

    Public Sub New()
        Results = New List(Of ValidationResult)()
        IsValid = False
    End Sub
End Class