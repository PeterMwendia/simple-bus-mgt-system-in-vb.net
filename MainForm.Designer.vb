<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbllocsched = New System.Windows.Forms.Label()
        Me.lblschedule = New System.Windows.Forms.Label()
        Me.lbldriverbus = New System.Windows.Forms.Label()
        Me.lblrouteloc = New System.Windows.Forms.Label()
        Me.lblbus = New System.Windows.Forms.Label()
        Me.lblroute = New System.Windows.Forms.Label()
        Me.lbllogs = New System.Windows.Forms.Label()
        Me.lbldistance = New System.Windows.Forms.Label()
        Me.lbllocation = New System.Windows.Forms.Label()
        Me.lblemp = New System.Windows.Forms.Label()
        Me.mngcus = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkGray
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.lbllocsched)
        Me.Panel1.Controls.Add(Me.lblschedule)
        Me.Panel1.Controls.Add(Me.lbldriverbus)
        Me.Panel1.Controls.Add(Me.lblrouteloc)
        Me.Panel1.Controls.Add(Me.lblbus)
        Me.Panel1.Controls.Add(Me.lblroute)
        Me.Panel1.Controls.Add(Me.lbllogs)
        Me.Panel1.Controls.Add(Me.lbldistance)
        Me.Panel1.Controls.Add(Me.lbllocation)
        Me.Panel1.Controls.Add(Me.lblemp)
        Me.Panel1.Controls.Add(Me.mngcus)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(510, 516)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Yellow
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(510, 88)
        Me.Panel2.TabIndex = 12
        Me.Panel2.Tag = "Dashboard"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(152, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Dashboard"
        '
        'lbllocsched
        '
        Me.lbllocsched.AutoSize = True
        Me.lbllocsched.Location = New System.Drawing.Point(300, 169)
        Me.lbllocsched.Name = "lbllocsched"
        Me.lbllocsched.Size = New System.Drawing.Size(93, 13)
        Me.lbllocsched.TabIndex = 11
        Me.lbllocsched.Text = "LocationSchedule"
        '
        'lblschedule
        '
        Me.lblschedule.AutoSize = True
        Me.lblschedule.Location = New System.Drawing.Point(300, 125)
        Me.lblschedule.Name = "lblschedule"
        Me.lblschedule.Size = New System.Drawing.Size(52, 13)
        Me.lblschedule.TabIndex = 9
        Me.lblschedule.Text = "Schedule"
        '
        'lbldriverbus
        '
        Me.lbldriverbus.AutoSize = True
        Me.lbldriverbus.Location = New System.Drawing.Point(300, 299)
        Me.lbldriverbus.Name = "lbldriverbus"
        Me.lbldriverbus.Size = New System.Drawing.Size(53, 13)
        Me.lbldriverbus.TabIndex = 8
        Me.lbldriverbus.Text = "DriverBus"
        '
        'lblrouteloc
        '
        Me.lblrouteloc.AutoSize = True
        Me.lblrouteloc.Location = New System.Drawing.Point(300, 255)
        Me.lblrouteloc.Name = "lblrouteloc"
        Me.lblrouteloc.Size = New System.Drawing.Size(77, 13)
        Me.lblrouteloc.TabIndex = 7
        Me.lblrouteloc.Text = "RouteLocation"
        '
        'lblbus
        '
        Me.lblbus.AutoSize = True
        Me.lblbus.Location = New System.Drawing.Point(113, 299)
        Me.lblbus.Name = "lblbus"
        Me.lblbus.Size = New System.Drawing.Size(25, 13)
        Me.lblbus.TabIndex = 6
        Me.lblbus.Text = "Bus"
        '
        'lblroute
        '
        Me.lblroute.AutoSize = True
        Me.lblroute.Location = New System.Drawing.Point(300, 213)
        Me.lblroute.Name = "lblroute"
        Me.lblroute.Size = New System.Drawing.Size(36, 13)
        Me.lblroute.TabIndex = 5
        Me.lblroute.Text = "Route"
        '
        'lbllogs
        '
        Me.lbllogs.AutoSize = True
        Me.lbllogs.Location = New System.Drawing.Point(221, 356)
        Me.lbllogs.Name = "lbllogs"
        Me.lbllogs.Size = New System.Drawing.Size(30, 13)
        Me.lbllogs.TabIndex = 4
        Me.lbllogs.Text = "Logs"
        '
        'lbldistance
        '
        Me.lbldistance.AutoSize = True
        Me.lbldistance.Location = New System.Drawing.Point(113, 255)
        Me.lbldistance.Name = "lbldistance"
        Me.lbldistance.Size = New System.Drawing.Size(49, 13)
        Me.lbldistance.TabIndex = 3
        Me.lbldistance.Text = "Distance"
        '
        'lbllocation
        '
        Me.lbllocation.AutoSize = True
        Me.lbllocation.Location = New System.Drawing.Point(113, 213)
        Me.lbllocation.Name = "lbllocation"
        Me.lbllocation.Size = New System.Drawing.Size(48, 13)
        Me.lbllocation.TabIndex = 2
        Me.lbllocation.Text = "Location"
        '
        'lblemp
        '
        Me.lblemp.AutoSize = True
        Me.lblemp.Location = New System.Drawing.Point(113, 169)
        Me.lblemp.Name = "lblemp"
        Me.lblemp.Size = New System.Drawing.Size(103, 13)
        Me.lblemp.TabIndex = 1
        Me.lblemp.Text = "Manage_Employees"
        '
        'mngcus
        '
        Me.mngcus.AutoSize = True
        Me.mngcus.Location = New System.Drawing.Point(113, 125)
        Me.mngcus.Name = "mngcus"
        Me.mngcus.Size = New System.Drawing.Size(101, 13)
        Me.mngcus.TabIndex = 0
        Me.mngcus.Text = "Manage_Customers"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(510, 516)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "MainForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents mngcus As Label
    Friend WithEvents lblroute As Label
    Friend WithEvents lbllogs As Label
    Friend WithEvents lbldistance As Label
    Friend WithEvents lbllocation As Label
    Friend WithEvents lblemp As Label
    Friend WithEvents lbllocsched As Label
    Friend WithEvents lblschedule As Label
    Friend WithEvents lbldriverbus As Label
    Friend WithEvents lblrouteloc As Label
    Friend WithEvents lblbus As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
End Class
