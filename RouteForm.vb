Public Class RouteForm
    Private Sub RouteForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Route._route' table. You can move, or remove it, as needed.
        Me.RouteTableAdapter.Fill(Me.Route._route)

    End Sub
End Class