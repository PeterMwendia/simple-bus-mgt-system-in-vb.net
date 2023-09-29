Public Class Driver_BusForm
    Private Sub Driver_BusForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Driverbus._driverbus' table. You can move, or remove it, as needed.
        Me.DriverbusTableAdapter.Fill(Me.Driverbus._driverbus)

    End Sub
End Class