Public Class BusForm
    Private Sub BusForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Bus._bus' table. You can move, or remove it, as needed.
        Me.BusTableAdapter3.Fill(Me.Bus._bus)
        'TODO: This line of code loads data into the 'TestDataSet10.bus' table. You can move, or remove it, as needed.
        Me.BusTableAdapter2.Fill(Me.TestDataSet10.bus)
        'TODO: This line of code loads data into the 'TestDataSet9.bus' table. You can move, or remove it, as needed.
        Me.BusTableAdapter1.Fill(Me.TestDataSet9.bus)
        'TODO: This line of code loads data into the 'TestDataSet8.bus' table. You can move, or remove it, as needed.
        Me.BusTableAdapter.Fill(Me.TestDataSet8.bus)

    End Sub
End Class