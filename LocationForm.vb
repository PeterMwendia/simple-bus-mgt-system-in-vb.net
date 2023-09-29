Public Class LocationForm
    Private Sub LocationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Location._location' table. You can move, or remove it, as needed.
        Me.LocationTableAdapter1.Fill(Me.Location._location)
        'TODO: This line of code loads data into the 'TestDataSet2.location' table. You can move, or remove it, as needed.
        Me.LocationTableAdapter.Fill(Me.TestDataSet2.location)

    End Sub
End Class