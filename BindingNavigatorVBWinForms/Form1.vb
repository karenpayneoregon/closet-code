Imports BindingNavigatorVBWinForms.Classes

Public Class Form1
    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        BindingSource1.DataSource = BogusOperations.PeopleList(10)
        DataGridView1.DataSource = BindingSource1

    End Sub
End Class