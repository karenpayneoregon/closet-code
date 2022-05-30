

Namespace Models
	Public Class ContactDevice
		Public Property Id() As Integer
		Public Property DeviceType() As DeviceType
		Public Property DeviceTypeId() As Integer
		Public Property Value() As String
		Public Overrides Function ToString() As String
			Return $"{DeviceType.Description} : {Value}"
		End Function

		Public Sub New(ByVal id As Integer)
			Me.Id = id
		End Sub

		Public Sub New()

		End Sub
	End Class
End Namespace