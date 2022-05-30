Namespace Models
	Public Class DeviceType
		Public Property Id() As Integer
		Public Property Description() As String
		Public Overrides Function ToString() As String
			Return Description
		End Function

	End Class
End Namespace