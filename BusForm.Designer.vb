<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BusForm
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
        Me.Logs_TableAdapter1 = New Ent.testDataSet7TableAdapters.logs_TableAdapter()
        Me.LogsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TestDataSet4 = New Ent.testDataSet4()
        Me.LogsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TestDataSet7 = New Ent.testDataSet7()
        Me.CustomerTableAdapter = New Ent.testDataSetTableAdapters.customerTableAdapter()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TestDataSet = New Ent.testDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Logs_TableAdapter = New Ent.testDataSet4TableAdapters.logs_TableAdapter()
        Me.txtactiv = New System.Windows.Forms.TextBox()
        Me.txtlchd = New System.Windows.Forms.TextBox()
        Me.txtdte = New System.Windows.Forms.TextBox()
        Me.txtfname = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BusBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TestDataSet10 = New Ent.testDataSet10()
        Me.txtmname = New System.Windows.Forms.TextBox()
        Me.txtcustid = New System.Windows.Forms.TextBox()
        Me.lblfname = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblcusid = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TestDataSet3 = New Ent.testDataSet3()
        Me.DistanceTableAdapter = New Ent.testDataSet3TableAdapters.distanceTableAdapter()
        Me.DistanceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TestDataSet8 = New Ent.testDataSet8()
        Me.BusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BusTableAdapter = New Ent.testDataSet8TableAdapters.busTableAdapter()
        Me.TestDataSet9 = New Ent.testDataSet9()
        Me.BusBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BusTableAdapter1 = New Ent.testDataSet9TableAdapters.busTableAdapter()
        Me.TestDataSet1 = New Ent.testDataSet()
        Me.BusTableAdapter2 = New Ent.testDataSet10TableAdapters.busTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.busview = New System.Windows.Forms.DataGridView()
        Me.Bus = New Ent.bus()
        Me.BusBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BusTableAdapter3 = New Ent.busTableAdapters.busTableAdapter()
        Me.BusIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VinNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatecreatedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastchangedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActiveYNDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.LogsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestDataSet7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.BusBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestDataSet10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.TestDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DistanceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestDataSet8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestDataSet9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BusBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.busview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BusBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Logs_TableAdapter1
        '
        Me.Logs_TableAdapter1.ClearBeforeFill = True
        '
        'LogsBindingSource
        '
        Me.LogsBindingSource.DataMember = "logs_"
        Me.LogsBindingSource.DataSource = Me.TestDataSet4
        '
        'TestDataSet4
        '
        Me.TestDataSet4.DataSetName = "testDataSet4"
        Me.TestDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(319, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(206, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Manage Bus"
        '
        'Logs_TableAdapter
        '
        Me.Logs_TableAdapter.ClearBeforeFill = True
        '
        'txtactiv
        '
        Me.txtactiv.Location = New System.Drawing.Point(163, 278)
        Me.txtactiv.Name = "txtactiv"
        Me.txtactiv.Size = New System.Drawing.Size(190, 20)
        Me.txtactiv.TabIndex = 29
        '
        'txtlchd
        '
        Me.txtlchd.Location = New System.Drawing.Point(163, 240)
        Me.txtlchd.Name = "txtlchd"
        Me.txtlchd.Size = New System.Drawing.Size(190, 20)
        Me.txtlchd.TabIndex = 28
        '
        'txtdte
        '
        Me.txtdte.Location = New System.Drawing.Point(165, 204)
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel1.Controls.Add(Me.busview)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.txtactiv)
        Me.Panel1.Controls.Add(Me.txtlchd)
        Me.Panel1.Controls.Add(Me.txtdte)
        Me.Panel1.Controls.Add(Me.txtfname)
        Me.Panel1.Controls.Add(Me.txtmname)
        Me.Panel1.Controls.Add(Me.txtcustid)
        Me.Panel1.Controls.Add(Me.lblfname)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.lblcusid)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1157, 619)
        Me.Panel1.TabIndex = 3
        '
        'BusBindingSource2
        '
        Me.BusBindingSource2.DataMember = "bus"
        Me.BusBindingSource2.DataSource = Me.TestDataSet10
        '
        'TestDataSet10
        '
        Me.TestDataSet10.DataSetName = "testDataSet10"
        Me.TestDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.lblfname.Location = New System.Drawing.Point(75, 136)
        Me.lblfname.Name = "lblfname"
        Me.lblfname.Size = New System.Drawing.Size(53, 18)
        Me.lblfname.TabIndex = 13
        Me.lblfname.Text = "Model:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(45, 168)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(85, 18)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "VinNumber:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(35, 206)
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
        Me.Label5.Location = New System.Drawing.Point(31, 239)
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
        Me.Label3.Location = New System.Drawing.Point(83, 280)
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
        Me.lblcusid.Location = New System.Drawing.Point(79, 101)
        Me.lblcusid.Name = "lblcusid"
        Me.lblcusid.Size = New System.Drawing.Size(49, 18)
        Me.lblcusid.TabIndex = 1
        Me.lblcusid.Text = "BusId:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Yellow
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1367, 72)
        Me.Panel2.TabIndex = 0
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
        'DistanceBindingSource
        '
        Me.DistanceBindingSource.DataMember = "distance"
        Me.DistanceBindingSource.DataSource = Me.TestDataSet3
        '
        'TestDataSet8
        '
        Me.TestDataSet8.DataSetName = "testDataSet8"
        Me.TestDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BusBindingSource
        '
        Me.BusBindingSource.DataMember = "bus"
        Me.BusBindingSource.DataSource = Me.TestDataSet8
        '
        'BusTableAdapter
        '
        Me.BusTableAdapter.ClearBeforeFill = True
        '
        'TestDataSet9
        '
        Me.TestDataSet9.DataSetName = "testDataSet9"
        Me.TestDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BusBindingSource1
        '
        Me.BusBindingSource1.DataMember = "bus"
        Me.BusBindingSource1.DataSource = Me.TestDataSet9
        '
        'BusTableAdapter1
        '
        Me.BusTableAdapter1.ClearBeforeFill = True
        '
        'TestDataSet1
        '
        Me.TestDataSet1.DataSetName = "testDataSet"
        Me.TestDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BusTableAdapter2
        '
        Me.BusTableAdapter2.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Blue
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(182, 400)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 38)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = "Edit"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(314, 400)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(85, 38)
        Me.Button2.TabIndex = 34
        Me.Button2.Text = "Remove"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Green
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(60, 400)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(85, 38)
        Me.Button3.TabIndex = 33
        Me.Button3.Text = "Add"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'busview
        '
        Me.busview.AutoGenerateColumns = False
        Me.busview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.busview.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BusIDDataGridViewTextBoxColumn, Me.ModelDataGridViewTextBoxColumn, Me.VinNumberDataGridViewTextBoxColumn, Me.DatecreatedDataGridViewTextBoxColumn, Me.LastchangedDataGridViewTextBoxColumn, Me.ActiveYNDataGridViewTextBoxColumn})
        Me.busview.DataSource = Me.BusBindingSource3
        Me.busview.Location = New System.Drawing.Point(484, 99)
        Me.busview.Name = "busview"
        Me.busview.Size = New System.Drawing.Size(642, 213)
        Me.busview.TabIndex = 36
        '
        'Bus
        '
        Me.Bus.DataSetName = "bus"
        Me.Bus.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BusBindingSource3
        '
        Me.BusBindingSource3.DataMember = "bus"
        Me.BusBindingSource3.DataSource = Me.Bus
        '
        'BusTableAdapter3
        '
        Me.BusTableAdapter3.ClearBeforeFill = True
        '
        'BusIDDataGridViewTextBoxColumn
        '
        Me.BusIDDataGridViewTextBoxColumn.DataPropertyName = "BusID"
        Me.BusIDDataGridViewTextBoxColumn.HeaderText = "BusID"
        Me.BusIDDataGridViewTextBoxColumn.Name = "BusIDDataGridViewTextBoxColumn"
        '
        'ModelDataGridViewTextBoxColumn
        '
        Me.ModelDataGridViewTextBoxColumn.DataPropertyName = "Model"
        Me.ModelDataGridViewTextBoxColumn.HeaderText = "Model"
        Me.ModelDataGridViewTextBoxColumn.Name = "ModelDataGridViewTextBoxColumn"
        '
        'VinNumberDataGridViewTextBoxColumn
        '
        Me.VinNumberDataGridViewTextBoxColumn.DataPropertyName = "VinNumber"
        Me.VinNumberDataGridViewTextBoxColumn.HeaderText = "VinNumber"
        Me.VinNumberDataGridViewTextBoxColumn.Name = "VinNumberDataGridViewTextBoxColumn"
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
        'BusForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1157, 619)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "BusForm"
        Me.Text = "BusForm"
        CType(Me.LogsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestDataSet7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.BusBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestDataSet10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.TestDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DistanceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestDataSet8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestDataSet9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BusBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.busview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BusBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Logs_TableAdapter1 As testDataSet7TableAdapters.logs_TableAdapter
    Friend WithEvents LogsBindingSource As BindingSource
    Friend WithEvents TestDataSet4 As testDataSet4
    Friend WithEvents LogsBindingSource1 As BindingSource
    Friend WithEvents TestDataSet7 As testDataSet7
    Friend WithEvents CustomerTableAdapter As testDataSetTableAdapters.customerTableAdapter
    Friend WithEvents CustomerBindingSource As BindingSource
    Friend WithEvents TestDataSet As testDataSet
    Friend WithEvents Label1 As Label
    Friend WithEvents Logs_TableAdapter As testDataSet4TableAdapters.logs_TableAdapter
    Friend WithEvents txtactiv As TextBox
    Friend WithEvents txtlchd As TextBox
    Friend WithEvents txtdte As TextBox
    Friend WithEvents txtfname As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtmname As TextBox
    Friend WithEvents txtcustid As TextBox
    Friend WithEvents lblfname As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblcusid As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TestDataSet3 As testDataSet3
    Friend WithEvents DistanceTableAdapter As testDataSet3TableAdapters.distanceTableAdapter
    Friend WithEvents DistanceBindingSource As BindingSource
    Friend WithEvents TestDataSet8 As testDataSet8
    Friend WithEvents BusBindingSource As BindingSource
    Friend WithEvents BusTableAdapter As testDataSet8TableAdapters.busTableAdapter
    Friend WithEvents TestDataSet9 As testDataSet9
    Friend WithEvents BusBindingSource1 As BindingSource
    Friend WithEvents BusTableAdapter1 As testDataSet9TableAdapters.busTableAdapter
    Friend WithEvents TestDataSet1 As testDataSet
    Friend WithEvents TestDataSet10 As testDataSet10
    Friend WithEvents BusBindingSource2 As BindingSource
    Friend WithEvents BusTableAdapter2 As testDataSet10TableAdapters.busTableAdapter
    Friend WithEvents busview As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Bus As bus
    Friend WithEvents BusBindingSource3 As BindingSource
    Friend WithEvents BusTableAdapter3 As busTableAdapters.busTableAdapter
    Friend WithEvents BusIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ModelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VinNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DatecreatedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastchangedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ActiveYNDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
