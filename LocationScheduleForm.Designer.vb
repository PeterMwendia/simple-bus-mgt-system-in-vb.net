<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LocationScheduleForm
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
        Me.components = New System.ComponentModel.Container()
        Me.CustomerTableAdapter = New Ent.testDataSetTableAdapters.customerTableAdapter()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TestDataSet = New Ent.testDataSet()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtactiv = New System.Windows.Forms.TextBox()
        Me.txtlchd = New System.Windows.Forms.TextBox()
        Me.txtdte = New System.Windows.Forms.TextBox()
        Me.txtfname = New System.Windows.Forms.TextBox()
        Me.txteml = New System.Windows.Forms.TextBox()
        Me.txtlname = New System.Windows.Forms.TextBox()
        Me.txtmname = New System.Windows.Forms.TextBox()
        Me.txtcustid = New System.Windows.Forms.TextBox()
        Me.lblfname = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblcusid = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Locationschedule = New Ent.locationschedule()
        Me.LocationscheduleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LocationscheduleTableAdapter = New Ent.locationscheduleTableAdapters.locationscheduleTableAdapter()
        Me.LocationScheduleIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RouteLocationIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ScheduleIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BusDirectionADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BusDirectionBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatecreatedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastchangedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActiveYNDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Locationschedule, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocationscheduleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "customer"
        Me.CustomerBindingSource.DataSource = Me.TestDataSet
        '
        'TestDataSet
        '
        Me.TestDataSet.DataSetName = "testDataSet"
        Me.TestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.txtactiv)
        Me.Panel1.Controls.Add(Me.txtlchd)
        Me.Panel1.Controls.Add(Me.txtdte)
        Me.Panel1.Controls.Add(Me.txtfname)
        Me.Panel1.Controls.Add(Me.txteml)
        Me.Panel1.Controls.Add(Me.txtlname)
        Me.Panel1.Controls.Add(Me.txtmname)
        Me.Panel1.Controls.Add(Me.txtcustid)
        Me.Panel1.Controls.Add(Me.lblfname)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.lblcusid)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1300, 675)
        Me.Panel1.TabIndex = 1
        '
        'txtactiv
        '
        Me.txtactiv.Location = New System.Drawing.Point(167, 348)
        Me.txtactiv.Name = "txtactiv"
        Me.txtactiv.Size = New System.Drawing.Size(190, 20)
        Me.txtactiv.TabIndex = 29
        '
        'txtlchd
        '
        Me.txtlchd.Location = New System.Drawing.Point(167, 310)
        Me.txtlchd.Name = "txtlchd"
        Me.txtlchd.Size = New System.Drawing.Size(190, 20)
        Me.txtlchd.TabIndex = 28
        '
        'txtdte
        '
        Me.txtdte.Location = New System.Drawing.Point(167, 274)
        Me.txtdte.Name = "txtdte"
        Me.txtdte.Size = New System.Drawing.Size(190, 20)
        Me.txtdte.TabIndex = 27
        '
        'txtfname
        '
        Me.txtfname.Location = New System.Drawing.Point(167, 134)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(190, 20)
        Me.txtfname.TabIndex = 24
        '
        'txteml
        '
        Me.txteml.Location = New System.Drawing.Point(167, 236)
        Me.txteml.Name = "txteml"
        Me.txteml.Size = New System.Drawing.Size(190, 20)
        Me.txteml.TabIndex = 18
        '
        'txtlname
        '
        Me.txtlname.Location = New System.Drawing.Point(167, 203)
        Me.txtlname.Name = "txtlname"
        Me.txtlname.Size = New System.Drawing.Size(190, 20)
        Me.txtlname.TabIndex = 17
        '
        'txtmname
        '
        Me.txtmname.Location = New System.Drawing.Point(167, 166)
        Me.txtmname.Name = "txtmname"
        Me.txtmname.Size = New System.Drawing.Size(190, 20)
        Me.txtmname.TabIndex = 15
        '
        'txtcustid
        '
        Me.txtcustid.Location = New System.Drawing.Point(167, 99)
        Me.txtcustid.Name = "txtcustid"
        Me.txtcustid.Size = New System.Drawing.Size(190, 20)
        Me.txtcustid.TabIndex = 14
        '
        'lblfname
        '
        Me.lblfname.AutoSize = True
        Me.lblfname.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfname.ForeColor = System.Drawing.Color.White
        Me.lblfname.Location = New System.Drawing.Point(31, 136)
        Me.lblfname.Name = "lblfname"
        Me.lblfname.Size = New System.Drawing.Size(123, 18)
        Me.lblfname.TabIndex = 13
        Me.lblfname.Text = "RouteLocationID:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(42, 205)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(110, 18)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Bus_DirectionA"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(63, 168)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 18)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "ScheduleID:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(43, 240)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(115, 18)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Bus_DirectionB:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(55, 276)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 18)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Date Created:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(51, 312)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Last Changed:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(99, 350)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Active:"
        '
        'lblcusid
        '
        Me.lblcusid.AutoSize = True
        Me.lblcusid.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcusid.ForeColor = System.Drawing.Color.White
        Me.lblcusid.Location = New System.Drawing.Point(14, 101)
        Me.lblcusid.Name = "lblcusid"
        Me.lblcusid.Size = New System.Drawing.Size(144, 18)
        Me.lblcusid.TabIndex = 1
        Me.lblcusid.Text = "LocationScheduleID:"
        Me.lblcusid.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Yellow
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(1, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1299, 75)
        Me.Panel2.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(309, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(297, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Location Schedule"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LocationScheduleIDDataGridViewTextBoxColumn, Me.RouteLocationIDDataGridViewTextBoxColumn, Me.ScheduleIDDataGridViewTextBoxColumn, Me.BusDirectionADataGridViewTextBoxColumn, Me.BusDirectionBDataGridViewTextBoxColumn, Me.DatecreatedDataGridViewTextBoxColumn, Me.LastchangedDataGridViewTextBoxColumn, Me.ActiveYNDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.LocationscheduleBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(458, 99)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(842, 356)
        Me.DataGridView1.TabIndex = 33
        '
        'Locationschedule
        '
        Me.Locationschedule.DataSetName = "locationschedule"
        Me.Locationschedule.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LocationscheduleBindingSource
        '
        Me.LocationscheduleBindingSource.DataMember = "locationschedule"
        Me.LocationscheduleBindingSource.DataSource = Me.Locationschedule
        '
        'LocationscheduleTableAdapter
        '
        Me.LocationscheduleTableAdapter.ClearBeforeFill = True
        '
        'LocationScheduleIDDataGridViewTextBoxColumn
        '
        Me.LocationScheduleIDDataGridViewTextBoxColumn.DataPropertyName = "LocationScheduleID"
        Me.LocationScheduleIDDataGridViewTextBoxColumn.HeaderText = "LocationScheduleID"
        Me.LocationScheduleIDDataGridViewTextBoxColumn.Name = "LocationScheduleIDDataGridViewTextBoxColumn"
        '
        'RouteLocationIDDataGridViewTextBoxColumn
        '
        Me.RouteLocationIDDataGridViewTextBoxColumn.DataPropertyName = "RouteLocationID"
        Me.RouteLocationIDDataGridViewTextBoxColumn.HeaderText = "RouteLocationID"
        Me.RouteLocationIDDataGridViewTextBoxColumn.Name = "RouteLocationIDDataGridViewTextBoxColumn"
        '
        'ScheduleIDDataGridViewTextBoxColumn
        '
        Me.ScheduleIDDataGridViewTextBoxColumn.DataPropertyName = "ScheduleID"
        Me.ScheduleIDDataGridViewTextBoxColumn.HeaderText = "ScheduleID"
        Me.ScheduleIDDataGridViewTextBoxColumn.Name = "ScheduleIDDataGridViewTextBoxColumn"
        '
        'BusDirectionADataGridViewTextBoxColumn
        '
        Me.BusDirectionADataGridViewTextBoxColumn.DataPropertyName = "Bus_DirectionA"
        Me.BusDirectionADataGridViewTextBoxColumn.HeaderText = "Bus_DirectionA"
        Me.BusDirectionADataGridViewTextBoxColumn.Name = "BusDirectionADataGridViewTextBoxColumn"
        '
        'BusDirectionBDataGridViewTextBoxColumn
        '
        Me.BusDirectionBDataGridViewTextBoxColumn.DataPropertyName = "Bus_DirectionB"
        Me.BusDirectionBDataGridViewTextBoxColumn.HeaderText = "Bus_DirectionB"
        Me.BusDirectionBDataGridViewTextBoxColumn.Name = "BusDirectionBDataGridViewTextBoxColumn"
        '
        'DatecreatedDataGridViewTextBoxColumn
        '
        Me.DatecreatedDataGridViewTextBoxColumn.DataPropertyName = "Date_created"
        Me.DatecreatedDataGridViewTextBoxColumn.HeaderText = "Date_created"
        Me.DatecreatedDataGridViewTextBoxColumn.Name = "DatecreatedDataGridViewTextBoxColumn"
        '
        'LastchangedDataGridViewTextBoxColumn
        '
        Me.LastchangedDataGridViewTextBoxColumn.DataPropertyName = "Last_changed"
        Me.LastchangedDataGridViewTextBoxColumn.HeaderText = "Last_changed"
        Me.LastchangedDataGridViewTextBoxColumn.Name = "LastchangedDataGridViewTextBoxColumn"
        '
        'ActiveYNDataGridViewTextBoxColumn
        '
        Me.ActiveYNDataGridViewTextBoxColumn.DataPropertyName = "ActiveYN"
        Me.ActiveYNDataGridViewTextBoxColumn.HeaderText = "ActiveYN"
        Me.ActiveYNDataGridViewTextBoxColumn.Name = "ActiveYNDataGridViewTextBoxColumn"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Blue
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(203, 449)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 38)
        Me.Button1.TabIndex = 36
        Me.Button1.Text = "Edit"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(335, 449)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(85, 38)
        Me.Button2.TabIndex = 35
        Me.Button2.Text = "Remove"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Green
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(81, 449)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(85, 38)
        Me.Button3.TabIndex = 34
        Me.Button3.Text = "Add"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'LocationScheduleForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1300, 675)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "LocationScheduleForm"
        Me.Text = "LocationScheduleForm"
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Locationschedule, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocationscheduleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CustomerTableAdapter As testDataSetTableAdapters.customerTableAdapter
    Friend WithEvents CustomerBindingSource As BindingSource
    Friend WithEvents TestDataSet As testDataSet
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtactiv As TextBox
    Friend WithEvents txtlchd As TextBox
    Friend WithEvents txtdte As TextBox
    Friend WithEvents txtfname As TextBox
    Friend WithEvents txteml As TextBox
    Friend WithEvents txtlname As TextBox
    Friend WithEvents txtmname As TextBox
    Friend WithEvents txtcustid As TextBox
    Friend WithEvents lblfname As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblcusid As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Locationschedule As locationschedule
    Friend WithEvents LocationscheduleBindingSource As BindingSource
    Friend WithEvents LocationscheduleTableAdapter As locationscheduleTableAdapters.locationscheduleTableAdapter
    Friend WithEvents LocationScheduleIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RouteLocationIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ScheduleIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BusDirectionADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BusDirectionBDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DatecreatedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastchangedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ActiveYNDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
