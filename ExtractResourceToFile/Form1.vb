Imports ExtractResourceToFile.Extensions

Public Class Form1
    Private Sub ExtractButton_Click(sender As Object, e As EventArgs) _
        Handles ExtractButton.Click

        Dim exportFileName = "TODO\Customers.xlsx"
        My.Resources.Customers.FileSave(exportFileName)

    End Sub
End Class