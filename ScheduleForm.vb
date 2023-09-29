Public Class ScheduleForm
    Private Sub ScheduleForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Schedule.schedule_' table. You can move, or remove it, as needed.
        Me.Schedule_TableAdapter.Fill(Me.Schedule.schedule_)

    End Sub
End Class