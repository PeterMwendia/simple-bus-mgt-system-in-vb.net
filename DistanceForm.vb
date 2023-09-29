Public Class DistanceForm
    Private Sub DistanceForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Distance._distance' table. You can move, or remove it, as needed.
        Me.DistanceTableAdapter3.Fill(Me.Distance._distance)
        'TODO: This line of code loads data into the 'TestDataSet6.distance' table. You can move, or remove it, as needed.
        Me.DistanceTableAdapter2.Fill(Me.TestDataSet6.distance)
        'TODO: This line of code loads data into the 'TestDataSet5.distance' table. You can move, or remove it, as needed.
        Me.DistanceTableAdapter1.Fill(Me.TestDataSet5.distance)
        'TODO: This line of code loads data into the 'TestDataSet3.distance' table. You can move, or remove it, as needed.
        Me.DistanceTableAdapter.Fill(Me.TestDataSet3.distance)

    End Sub
End Class