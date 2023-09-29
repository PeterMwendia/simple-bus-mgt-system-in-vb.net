Public Class LocationScheduleForm
    Private Sub LocationScheduleForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Locationschedule._locationschedule' table. You can move, or remove it, as needed.
        Me.LocationscheduleTableAdapter.Fill(Me.Locationschedule._locationschedule)

    End Sub
End Class