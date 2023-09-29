Imports Devart.Data.MySql
Public Class DBconnectionForm

    Dim connection As New MySqlConnection("Data Source=localhost;Port=3306;User Id=root;Password=mwendiabae;Database=test")

    ' button connect
    Private Sub ButtonConnect_Click(sender As Object, e As EventArgs) Handles btnconnect.Click
        Try

            connection.Open()

            lblstatus.Text = "Connection Succeessful!"
            lblproceed.Text = "dashboard"
            'lblproceed_Click(lblproceed)
        Catch ex As Exception

            MessageBox.Show(ex.ToString())
            MessageBox.Show(ex.ToString())

        End Try


    End Sub

    ' button deconnect
    Private Sub ButtonDeconnect_Click(sender As Object, e As EventArgs) Handles btndisconnect.Click
        Try

            connection.Close()
            lblstatus.Text = "Disconnected successfully"


        Catch ex As Exception

            MessageBox.Show(ex.ToString())

        End Try


    End Sub

    Private Sub lblproceed_Click(sender As Object, e As EventArgs) Handles lblproceed.Click
        Dim dashboard As New MainForm()
        dashboard.ShowDialog()
    End Sub

End Class