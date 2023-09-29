<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogsForm
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
        Me.TestDataSet3 = New Ent.testDataSet3()
        Me.DistanceTableAdapter = New Ent.testDataSet3TableAdapters.distanceTableAdapter()
        Me.LogsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TestDataSet7 = New Ent.testDataSet7()
        Me.DistanceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.lblcusid = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TestDataSet = New Ent.testDataSet()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerTableAdapter = New Ent.testDataSetTableAdapters.customerTableAdapter()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TestDataSet4 = New Ent.testDataSet4()
        Me.LogsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Logs_TableAdapter = New Ent.testDataSet4TableAdapters.logs_TableAdapter()
        Me.Logs_TableAdapter1 = New Ent.testDataSet7TableAdapters.logs_TableAdapter()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btnremove = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.logsview = New System.Windows.Forms.DataGridView()
        Me.Logs = New Ent.logs()
        Me.LogsBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Logs_TableAdapter2 = New Ent.logsTableAdapters.logs_TableAdapter()
        Me.LogIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LogTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RiderStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DistanceIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatecreatedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastchangedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActiveYNDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.TestDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestDataSet7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DistanceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.TestDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.TestDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.logsview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Logs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogsBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TestDataSet3
        '
        Me.TestDataSet3.DataSetName = "testDataSet3"
        Me.TestDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DistanceTableAdapter
        '
        Me.DistanceTableAdapter.ClearBeforeFill = True
        '
        'LogsBindingSource1
        '
        Me.LogsBindingSource1.DataMember = "logs_"
        Me.LogsBindingSource1.DataSource = Me.TestDataSet7
        '
        'TestDataSet7
        '
        Me.TestDataSet7.DataSetName = "testDataSet7"
        Me.TestDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DistanceBindingSource
        '
        Me.DistanceBindingSource.DataMember = "distance"
        Me.DistanceBindingSource.DataSource = Me.TestDataSet3
        '
        'txtactiv
        '
        Me.txtactiv.Location = New System.Drawing.Point(163, 353)
        Me.txtactiv.Name = "txtactiv"
        Me.txtactiv.Size = New System.Drawing.Size(190, 20)
        Me.txtactiv.TabIndex = 29
        '
        'txtlchd
        '
        Me.txtlchd.Location = New System.Drawing.Point(163, 315)
        Me.txtlchd.Name = "txtlchd"
        Me.txtlchd.Size = New System.Drawing.Size(190, 20)
        Me.txtlchd.TabIndex = 28
        '
        'txtdte
        '
        Me.txtdte.Location = New System.Drawing.Point(165, 279)
        Me.txtdte.Name = "txtdte"
        Me.txtdte.Size = New System.Drawing.Size(190, 20)
        Me.txtdte.TabIndex = 27
        '
        'txtfname
        '
        Me.txtfname.Location = New System.Drawing.Point(166, 134)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(190, 20)
        Me.txtfname.TabIndex = 24
        '
        'txteml
        '
        Me.txteml.Location = New System.Drawing.Point(166, 236)
        Me.txteml.Name = "txteml"
        Me.txteml.Size = New System.Drawing.Size(190, 20)
        Me.txteml.TabIndex = 18
        '
        'txtlname
        '
        Me.txtlname.Location = New System.Drawing.Point(166, 203)
        Me.txtlname.Name = "txtlname"
        Me.txtlname.Size = New System.Drawing.Size(190, 20)
        Me.txtlname.TabIndex = 17
        '
        'txtmname
        '
        Me.txtmname.Location = New System.Drawing.Point(166, 166)
        Me.txtmname.Name = "txtmname"
        Me.txtmname.Size = New System.Drawing.Size(190, 20)
        Me.txtmname.TabIndex = 15
        '
        'txtcustid
        '
        Me.txtcustid.Location = New System.Drawing.Point(166, 99)
        Me.txtcustid.Name = "txtcustid"
        Me.txtcustid.Size = New System.Drawing.Size(190, 20)
        Me.txtcustid.TabIndex = 14
        '
        'lblfname
        '
        Me.lblfname.AutoSize = True
        Me.lblfname.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfname.ForeColor = System.Drawing.Color.White
        Me.lblfname.Location = New System.Drawing.Point(61, 136)
        Me.lblfname.Name = "lblfname"
        Me.lblfname.Size = New System.Drawing.Size(70, 18)
        Me.lblfname.TabIndex = 13
        Me.lblfname.Text = "Log Time"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(43, 205)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(88, 18)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "CustomerID"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(45, 168)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 18)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Rider Status"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(54, 243)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 18)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "DistanceID"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(35, 281)
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
        Me.Label5.Location = New System.Drawing.Point(31, 314)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Last Changed:"
        '
        'lblcusid
        '
        Me.lblcusid.AutoSize = True
        Me.lblcusid.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcusid.ForeColor = System.Drawing.Color.White
        Me.lblcusid.Location = New System.Drawing.Point(79, 101)
        Me.lblcusid.Name = "lblcusid"
        Me.lblcusid.Size = New System.Drawing.Size(48, 18)
        Me.lblcusid.TabIndex = 1
        Me.lblcusid.Text = "LogId:"
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
        Me.Label1.Location = New System.Drawing.Point(420, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(222, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Manage Logs"
        '
        'TestDataSet
        '
        Me.TestDataSet.DataSetName = "testDataSet"
        Me.TestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "customer"
        Me.CustomerBindingSource.DataSource = Me.TestDataSet
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(83, 355)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Active:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel1.Controls.Add(Me.logsview)
        Me.Panel1.Controls.Add(Me.btnedit)
        Me.Panel1.Controls.Add(Me.btnremove)
        Me.Panel1.Controls.Add(Me.btnadd)
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
        Me.Panel1.Size = New System.Drawing.Size(1325, 620)
        Me.Panel1.TabIndex = 2
        '
        'TestDataSet4
        '
        Me.TestDataSet4.DataSetName = "testDataSet4"
        Me.TestDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LogsBindingSource
        '
        Me.LogsBindingSource.DataMember = "logs_"
        Me.LogsBindingSource.DataSource = Me.TestDataSet4
        '
        'Logs_TableAdapter
        '
        Me.Logs_TableAdapter.ClearBeforeFill = True
        '
        'Logs_TableAdapter1
        '
        Me.Logs_TableAdapter1.ClearBeforeFill = True
        '
        'btnedit
        '
        Me.btnedit.BackColor = System.Drawing.Color.Blue
        Me.btnedit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnedit.Location = New System.Drawing.Point(171, 479)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(85, 38)
        Me.btnedit.TabIndex = 35
        Me.btnedit.Text = "Edit"
        Me.btnedit.UseVisualStyleBackColor = False
        '
        'btnremove
        '
        Me.btnremove.BackColor = System.Drawing.Color.Red
        Me.btnremove.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnremove.Location = New System.Drawing.Point(303, 479)
        Me.btnremove.Name = "btnremove"
        Me.btnremove.Size = New System.Drawing.Size(85, 38)
        Me.btnremove.TabIndex = 34
        Me.btnremove.Text = "Remove"
        Me.btnremove.UseVisualStyleBackColor = False
        '
        'btnadd
        '
        Me.btnadd.BackColor = System.Drawing.Color.Green
        Me.btnadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.Location = New System.Drawing.Point(49, 479)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(85, 38)
        Me.btnadd.TabIndex = 33
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = False
        '
        'logsview
        '
        Me.logsview.AutoGenerateColumns = False
        Me.logsview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.logsview.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LogIDDataGridViewTextBoxColumn, Me.LogTimeDataGridViewTextBoxColumn, Me.RiderStatusDataGridViewTextBoxColumn, Me.CustomerIDDataGridViewTextBoxColumn, Me.DistanceIDDataGridViewTextBoxColumn, Me.DatecreatedDataGridViewTextBoxColumn, Me.LastchangedDataGridViewTextBoxColumn, Me.ActiveYNDataGridViewTextBoxColumn})
        Me.logsview.DataSource = Me.LogsBindingSource2
        Me.logsview.Location = New System.Drawing.Point(463, 99)
        Me.logsview.Name = "logsview"
        Me.logsview.Size = New System.Drawing.Size(839, 247)
        Me.logsview.TabIndex = 1
        '
        'Logs
        '
        Me.Logs.DataSetName = "logs"
        Me.Logs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LogsBindingSource2
        '
        Me.LogsBindingSource2.DataMember = "logs_"
        Me.LogsBindingSource2.DataSource = Me.Logs
        '
        'Logs_TableAdapter2
        '
        Me.Logs_TableAdapter2.ClearBeforeFill = True
        '
        'LogIDDataGridViewTextBoxColumn
        '
        Me.LogIDDataGridViewTextBoxColumn.DataPropertyName = "LogID"
        Me.LogIDDataGridViewTextBoxColumn.HeaderText = "LogID"
        Me.LogIDDataGridViewTextBoxColumn.Name = "LogIDDataGridViewTextBoxColumn"
        '
        'LogTimeDataGridViewTextBoxColumn
        '
        Me.LogTimeDataGridViewTextBoxColumn.DataPropertyName = "LogTime"
        Me.LogTimeDataGridViewTextBoxColumn.HeaderText = "LogTime"
        Me.LogTimeDataGridViewTextBoxColumn.Name = "LogTimeDataGridViewTextBoxColumn"
        '
        'RiderStatusDataGridViewTextBoxColumn
        '
        Me.RiderStatusDataGridViewTextBoxColumn.DataPropertyName = "RiderStatus"
        Me.RiderStatusDataGridViewTextBoxColumn.HeaderText = "RiderStatus"
        Me.RiderStatusDataGridViewTextBoxColumn.Name = "RiderStatusDataGridViewTextBoxColumn"
        '
        'CustomerIDDataGridViewTextBoxColumn
        '
        Me.CustomerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID"
        Me.CustomerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID"
        Me.CustomerIDDataGridViewTextBoxColumn.Name = "CustomerIDDataGridViewTextBoxColumn"
        '
        'DistanceIDDataGridViewTextBoxColumn
        '
        Me.DistanceIDDataGridViewTextBoxColumn.DataPropertyName = "DistanceID"
        Me.DistanceIDDataGridViewTextBoxColumn.HeaderText = "DistanceID"
        Me.DistanceIDDataGridViewTextBoxColumn.Name = "DistanceIDDataGridViewTextBoxColumn"
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
        'LogsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1325, 620)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "LogsForm"
        Me.Text = "LogsForm"
        CType(Me.TestDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestDataSet7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DistanceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.TestDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TestDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.logsview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Logs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogsBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TestDataSet3 As testDataSet3
    Friend WithEvents DistanceTableAdapter As testDataSet3TableAdapters.distanceTableAdapter
    Friend WithEvents DistanceBindingSource As BindingSource
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
    Friend WithEvents lblcusid As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TestDataSet As testDataSet
    Friend WithEvents CustomerBindingSource As BindingSource
    Friend WithEvents CustomerTableAdapter As testDataSetTableAdapters.customerTableAdapter
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TestDataSet4 As testDataSet4
    Friend WithEvents LogsBindingSource As BindingSource
    Friend WithEvents Logs_TableAdapter As testDataSet4TableAdapters.logs_TableAdapter
    Friend WithEvents TestDataSet7 As testDataSet7
    Friend WithEvents LogsBindingSource1 As BindingSource
    Friend WithEvents Logs_TableAdapter1 As testDataSet7TableAdapters.logs_TableAdapter
    Friend WithEvents btnedit As Button
    Friend WithEvents btnremove As Button
    Friend WithEvents btnadd As Button
    Friend WithEvents logsview As DataGridView
    Friend WithEvents Logs As logs
    Friend WithEvents LogsBindingSource2 As BindingSource
    Friend WithEvents Logs_TableAdapter2 As logsTableAdapters.logs_TableAdapter
    Friend WithEvents LogIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LogTimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RiderStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DistanceIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DatecreatedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastchangedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ActiveYNDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
