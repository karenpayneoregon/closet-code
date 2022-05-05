Imports System.ComponentModel.DataAnnotations

Public Class Annotations
    Public Shared Function ValidEmail(ByVal emailAddress As String) As Boolean
        Return (New EmailAddressAttribute()).IsValid(emailAddress)
    End Function
End Class