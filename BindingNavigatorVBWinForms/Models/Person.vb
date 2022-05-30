Imports System.Collections.Generic

Namespace Models
	Public Class Person
		Public Property Id() As Integer
		Public Property FirstName() As String
		Public Property LastName() As String
		Public Property Addresses() As List(Of Address)
		Public Property ContactDevices() As List(Of ContactDevice)
		Public Overrides Function ToString() As String
			Return $"{FirstName} {LastName}"
		End Function

		Public Sub New()

		End Sub

		Public Sub New(ByVal id As Integer)
			Me.Id = id
			Addresses = New List(Of Address)()
			ContactDevices = New List(Of ContactDevice)()
		End Sub
	End Class
End Namespace