<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScheduleForm
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
        Me.txtcustid = New System.Windows.Forms.TextBox()
        Me.lblfname = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblcusid = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Schedule = New Ent.schedule()
        Me.ScheduleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Schedule_TableAdapter = New Ent.scheduleTableAdapters.schedule_TableAdapter()
        Me.ScheduleIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        CType(Me.Schedule, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ScheduleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Controls.Add(Me.txtcustid)
        Me.Panel1.Controls.Add(Me.lblfname)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.lblcusid)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1108, 524)
        Me.Panel1.TabIndex = 1
        '
        'txtactiv
        '
        Me.txtactiv.Location = New System.Drawing.Point(128, 247)
        Me.txtactiv.Name = "txtactiv"
        Me.txtactiv.Size = New System.Drawing.Size(190, 20)
        Me.txtactiv.TabIndex = 29
        '
        'txtlchd
        '
        Me.txtlchd.Location = New System.Drawing.Point(128, 209)
        Me.txtlchd.Name = "txtlchd"
        Me.txtlchd.Size = New System.Drawing.Size(190, 20)
        Me.txtlchd.TabIndex = 28
        '
        'txtdte
        '
        Me.txtdte.Location = New System.Drawing.Point(128, 173)
        Me.txtdte.Name = "txtdte"
        Me.txtdte.Size = New System.Drawing.Size(190, 20)
        Me.txtdte.TabIndex = 27
        '
        'txtfname
        '
        Me.txtfname.Location = New System.Drawing.Point(128, 134)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(190, 20)
        Me.txtfname.TabIndex = 24
        '
        'txtcustid
        '
        Me.txtcustid.Location = New System.Drawing.Point(128, 99)
        Me.txtcustid.Name = "txtcustid"
        Me.txtcustid.Size = New System.Drawing.Size(190, 20)
        Me.txtcustid.TabIndex = 14
        '
        'lblfname
        '
        Me.lblfname.AutoSize = True
        Me.lblfname.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfname.ForeColor = System.Drawing.Color.White
        Me.lblfname.Location = New System.Drawing.Point(57, 136)
        Me.lblfname.Name = "lblfname"
        Me.lblfname.Size = New System.Drawing.Size(53, 18)
        Me.lblfname.TabIndex = 13
        Me.lblfname.Text = "Times:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(16, 175)
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
        Me.Label5.Location = New System.Drawing.Point(12, 211)
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
        Me.Label3.Location = New System.Drawing.Point(60, 249)
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
        Me.lblcusid.Location = New System.Drawing.Point(31, 101)
        Me.lblcusid.Name = "lblcusid"
        Me.lblcusid.Size = New System.Drawing.Size(84, 18)
        Me.lblcusid.TabIndex = 1
        Me.lblcusid.Text = "ScheduleId:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Yellow
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(1, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1367, 72)
        Me.Panel2.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(361, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(288, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Manage Schedule"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ScheduleIDDataGridViewTextBoxColumn, Me.TimesDataGridViewTextBoxColumn, Me.DatecreatedDataGridViewTextBoxColumn, Me.LastchangedDataGridViewTextBoxColumn, Me.ActiveYNDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ScheduleBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(506, 99)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(542, 150)
        Me.DataGridView1.TabIndex = 33
        '
        'Schedule
        '
        Me.Schedule.DataSetName = "schedule"
        Me.Schedule.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ScheduleBindingSource
        '
        Me.ScheduleBindingSource.DataMember = "schedule_"
        Me.ScheduleBindingSource.DataSource = Me.Schedule
        '
        'Schedule_TableAdapter
        '
        Me.Schedule_TableAdapter.ClearBeforeFill = True
        '
        'ScheduleIDDataGridViewTextBoxColumn
        '
        Me.ScheduleIDDataGridViewTextBoxColumn.DataPropertyName = "ScheduleID"
        Me.ScheduleIDDataGridViewTextBoxColumn.HeaderText = "ScheduleID"
        Me.ScheduleIDDataGridViewTextBoxColumn.Name = "ScheduleIDDataGridViewTextBoxColumn"
        '
        'TimesDataGridViewTextBoxColumn
        '
        Me.TimesDataGridViewTextBoxColumn.DataPropertyName = "Times"
        Me.TimesDataGridViewTextBoxColumn.HeaderText = "Times"
        Me.TimesDataGridViewTextBoxColumn.Name = "TimesDataGridViewTextBoxColumn"
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
        Me.Button1.Location = New System.Drawing.Point(203, 340)
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
        Me.Button2.Location = New System.Drawing.Point(335, 340)
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
        Me.Button3.Location = New System.Drawing.Point(81, 340)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(85, 38)
        Me.Button3.TabIndex = 34
        Me.Button3.Text = "Add"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'ScheduleForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1108, 524)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ScheduleForm"
        Me.Text = "ScheduleForm"
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Schedule, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ScheduleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txtcustid As TextBox
    Friend WithEvents lblfname As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblcusid As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Schedule As schedule
    Friend WithEvents ScheduleBindingSource As BindingSource
    Friend WithEvents Schedule_TableAdapter As scheduleTableAdapters.schedule_TableAdapter
    Friend WithEvents ScheduleIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TimesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DatecreatedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastchangedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ActiveYNDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
