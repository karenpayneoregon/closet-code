Imports System.ComponentModel.DataAnnotations
Imports System.Text.RegularExpressions

Public Class CustomEmailAttribute
    Inherits ValidationAttribute

    Public Overrides Function IsValid(ByVal value As Object) As Boolean
        Dim pattern As String = "^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|" & "([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)" & "@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$"
        Dim regex As New Regex(pattern, RegexOptions.IgnoreCase)
        Return regex.IsMatch(value.ToString())
    End Function
End Class