Public Class LogsForm
    Private Sub LogsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Logs.logs_' table. You can move, or remove it, as needed.
        Me.Logs_TableAdapter2.Fill(Me.Logs.logs_)
        'TODO: This line of code loads data into the 'TestDataSet7.logs_' table. You can move, or remove it, as needed.
        Me.Logs_TableAdapter1.Fill(Me.TestDataSet7.logs_)
        'TODO: This line of code loads data into the 'TestDataSet4.logs_' table. You can move, or remove it, as needed.
        Me.Logs_TableAdapter.Fill(Me.TestDataSet4.logs_)

    End Sub
End Class