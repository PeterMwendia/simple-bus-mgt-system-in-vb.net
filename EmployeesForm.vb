Public Class EmployeesForm
    Private Sub EmployeesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Employees.employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter1.Fill(Me.Employees.employee)
        'TODO: This line of code loads data into the 'TestDataSet1.employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter.Fill(Me.TestDataSet1.employee)

    End Sub
End Class