Imports System.ComponentModel.DataAnnotations

Public Class Example
    <CustomEmail(), Required(ErrorMessage:="{0} is required")>
    Public Property EmailAddress() As String
End Class