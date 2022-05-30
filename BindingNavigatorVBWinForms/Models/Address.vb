Imports System.Collections.Generic

Namespace Models
	Public Class Address
		Public Property Id() As Integer
		Public Property Street() As String
		Public Property PostalCode() As String
		Public Property Residents() As List(Of Person)
		Public Overrides Function ToString() As String
			Return Street
		End Function

		Public Sub New(ByVal id As Integer)
			Me.Id = id
		End Sub

		Public Sub New()

		End Sub

	End Class
End Namespace