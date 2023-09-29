Public Class RouteLocationForm
    Private Sub RouteLocationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Routelocation._routelocation' table. You can move, or remove it, as needed.
        Me.RoutelocationTableAdapter.Fill(Me.Routelocation._routelocation)

    End Sub
End Class