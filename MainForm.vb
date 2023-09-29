Public Class MainForm
    Private Sub mngcus_Click(sender As Object, e As EventArgs) Handles mngcus.Click
        Dim Manage_Customers As New Manage_customersForm()
        Manage_Customers.ShowDialog()
    End Sub

    Private Sub lblemp_Click(sender As Object, e As EventArgs) Handles lblemp.Click
        Dim Manage_employees As New EmployeesForm()
        Manage_employees.ShowDialog()
    End Sub

    Private Sub lbllocation_Click(sender As Object, e As EventArgs) Handles lbllocation.Click
        Dim location As New LocationForm()
        location.ShowDialog()
    End Sub

    Private Sub lbldistance_Click(sender As Object, e As EventArgs) Handles lbldistance.Click
        Dim distance As New DistanceForm()
        distance.ShowDialog()
    End Sub

    Private Sub lblbus_Click(sender As Object, e As EventArgs) Handles lblbus.Click
        Dim bus As New BusForm()
        bus.ShowDialog()
    End Sub

    Private Sub lbllogs_Click(sender As Object, e As EventArgs) Handles lbllogs.Click
        Dim logs As New LogsForm()
        logs.ShowDialog()
    End Sub

    Private Sub lbllocsched_Click(sender As Object, e As EventArgs) Handles lbllocsched.Click
        Dim loc_schedule As New LocationScheduleForm()
        loc_schedule.ShowDialog()
    End Sub

    Private Sub lblroute_Click(sender As Object, e As EventArgs) Handles lblroute.Click
        Dim route As New RouteForm()
        route.ShowDialog()
    End Sub

    Private Sub lblrouteloc_Click(sender As Object, e As EventArgs) Handles lblrouteloc.Click
        Dim route_loc As New RouteLocationForm()
        route_loc.ShowDialog()
    End Sub

    Private Sub lbldriverbus_Click(sender As Object, e As EventArgs) Handles lbldriverbus.Click
        Dim driver_bus As New Driver_BusForm()
        driver_bus.ShowDialog()
    End Sub

    Private Sub lblschedule_Click(sender As Object, e As EventArgs) Handles lblschedule.Click
        Dim schedule As New ScheduleForm()
        schedule.ShowDialog()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Application.Exit()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
