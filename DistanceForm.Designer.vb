<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DistanceForm
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
        Me.DistanceBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TestDataSet6 = New Ent.testDataSet6()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TestDataSet = New Ent.testDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtactiv = New System.Windows.Forms.TextBox()
        Me.txtlchd = New System.Windows.Forms.TextBox()
        Me.txtdte = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
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
        Me.TestDataSet3 = New Ent.testDataSet3()
        Me.DistanceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DistanceTableAdapter = New Ent.testDataSet3TableAdapters.distanceTableAdapter()
        Me.TestDataSet5 = New Ent.testDataSet5()
        Me.DistanceBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DistanceTableAdapter1 = New Ent.testDataSet5TableAdapters.distanceTableAdapter()
        Me.DistanceTableAdapter2 = New Ent.testDataSet6TableAdapters.distanceTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.distanceview = New System.Windows.Forms.DataGridView()
        Me.Distance = New Ent.distance()
        Me.DistanceBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DistanceTableAdapter3 = New Ent.distanceTableAdapters.distanceTableAdapter()
        Me.DistanceIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FromLocationIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToLocationIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DistanceApartDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeApartDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatecreatedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastchangedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActiveYNDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DistanceBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestDataSet6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.TestDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DistanceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestDataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DistanceBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.distanceview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Distance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DistanceBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'DistanceBindingSource2
        '
        Me.DistanceBindingSource2.DataMember = "distance"
        Me.DistanceBindingSource2.DataSource = Me.TestDataSet6
        '
        'TestDataSet6
        '
        Me.TestDataSet6.DataSetName = "testDataSet6"
        Me.TestDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.Label1.Location = New System.Drawing.Point(371, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(280, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Manage Distance"
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel1.Controls.Add(Me.distanceview)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button3)
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
        Me.Panel1.Size = New System.Drawing.Size(1348, 749)
        Me.Panel1.TabIndex = 1
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
        Me.lblfname.Location = New System.Drawing.Point(23, 136)
        Me.lblfname.Name = "lblfname"
        Me.lblfname.Size = New System.Drawing.Size(119, 18)
        Me.lblfname.TabIndex = 13
        Me.lblfname.Text = "From LocationID"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(34, 205)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(104, 18)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Distance Apart"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(41, 168)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(101, 18)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "To LocationID"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(63, 238)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 18)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Time Apart"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(43, 281)
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
        Me.Label5.Location = New System.Drawing.Point(35, 317)
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
        Me.Label3.Location = New System.Drawing.Point(87, 355)
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
        Me.lblcusid.Location = New System.Drawing.Point(61, 101)
        Me.lblcusid.Name = "lblcusid"
        Me.lblcusid.Size = New System.Drawing.Size(81, 18)
        Me.lblcusid.TabIndex = 1
        Me.lblcusid.Text = "DistanceId:"
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
        'DistanceBindingSource
        '
        Me.DistanceBindingSource.DataMember = "distance"
        Me.DistanceBindingSource.DataSource = Me.TestDataSet3
        '
        'DistanceTableAdapter
        '
        Me.DistanceTableAdapter.ClearBeforeFill = True
        '
        'TestDataSet5
        '
        Me.TestDataSet5.DataSetName = "testDataSet5"
        Me.TestDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DistanceBindingSource1
        '
        Me.DistanceBindingSource1.DataMember = "distance"
        Me.DistanceBindingSource1.DataSource = Me.TestDataSet5
        '
        'DistanceTableAdapter1
        '
        Me.DistanceTableAdapter1.ClearBeforeFill = True
        '
        'DistanceTableAdapter2
        '
        Me.DistanceTableAdapter2.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Blue
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(205, 467)
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
        Me.Button2.Location = New System.Drawing.Point(337, 467)
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
        Me.Button3.Location = New System.Drawing.Point(83, 467)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(85, 38)
        Me.Button3.TabIndex = 33
        Me.Button3.Text = "Add"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'distanceview
        '
        Me.distanceview.AutoGenerateColumns = False
        Me.distanceview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.distanceview.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DistanceIDDataGridViewTextBoxColumn, Me.FromLocationIDDataGridViewTextBoxColumn, Me.ToLocationIDDataGridViewTextBoxColumn, Me.DistanceApartDataGridViewTextBoxColumn, Me.TimeApartDataGridViewTextBoxColumn, Me.DatecreatedDataGridViewTextBoxColumn, Me.LastchangedDataGridViewTextBoxColumn, Me.ActiveYNDataGridViewTextBoxColumn})
        Me.distanceview.DataSource = Me.DistanceBindingSource3
        Me.distanceview.Location = New System.Drawing.Point(478, 99)
        Me.distanceview.Name = "distanceview"
        Me.distanceview.Size = New System.Drawing.Size(842, 274)
        Me.distanceview.TabIndex = 36
        '
        'Distance
        '
        Me.Distance.DataSetName = "distance"
        Me.Distance.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DistanceBindingSource3
        '
        Me.DistanceBindingSource3.DataMember = "distance"
        Me.DistanceBindingSource3.DataSource = Me.Distance
        '
        'DistanceTableAdapter3
        '
        Me.DistanceTableAdapter3.ClearBeforeFill = True
        '
        'DistanceIDDataGridViewTextBoxColumn
        '
        Me.DistanceIDDataGridViewTextBoxColumn.DataPropertyName = "DistanceID"
        Me.DistanceIDDataGridViewTextBoxColumn.HeaderText = "DistanceID"
        Me.DistanceIDDataGridViewTextBoxColumn.Name = "DistanceIDDataGridViewTextBoxColumn"
        '
        'FromLocationIDDataGridViewTextBoxColumn
        '
        Me.FromLocationIDDataGridViewTextBoxColumn.DataPropertyName = "From_LocationID"
        Me.FromLocationIDDataGridViewTextBoxColumn.HeaderText = "From_LocationID"
        Me.FromLocationIDDataGridViewTextBoxColumn.Name = "FromLocationIDDataGridViewTextBoxColumn"
        '
        'ToLocationIDDataGridViewTextBoxColumn
        '
        Me.ToLocationIDDataGridViewTextBoxColumn.DataPropertyName = "To_LocationID"
        Me.ToLocationIDDataGridViewTextBoxColumn.HeaderText = "To_LocationID"
        Me.ToLocationIDDataGridViewTextBoxColumn.Name = "ToLocationIDDataGridViewTextBoxColumn"
        '
        'DistanceApartDataGridViewTextBoxColumn
        '
        Me.DistanceApartDataGridViewTextBoxColumn.DataPropertyName = "Distance_Apart"
        Me.DistanceApartDataGridViewTextBoxColumn.HeaderText = "Distance_Apart"
        Me.DistanceApartDataGridViewTextBoxColumn.Name = "DistanceApartDataGridViewTextBoxColumn"
        '
        'TimeApartDataGridViewTextBoxColumn
        '
        Me.TimeApartDataGridViewTextBoxColumn.DataPropertyName = "Time_Apart"
        Me.TimeApartDataGridViewTextBoxColumn.HeaderText = "Time_Apart"
        Me.TimeApartDataGridViewTextBoxColumn.Name = "TimeApartDataGridViewTextBoxColumn"
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
        'DistanceForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1348, 749)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "DistanceForm"
        Me.Text = "DistanceForm"
        CType(Me.DistanceBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestDataSet6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.TestDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DistanceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestDataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DistanceBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.distanceview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Distance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DistanceBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CustomerTableAdapter As testDataSetTableAdapters.customerTableAdapter
    Friend WithEvents CustomerBindingSource As BindingSource
    Friend WithEvents TestDataSet As testDataSet
    Friend WithEvents Label1 As Label
    Friend WithEvents txtactiv As TextBox
    Friend WithEvents txtlchd As TextBox
    Friend WithEvents txtdte As TextBox
    Friend WithEvents Panel1 As Panel
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
    Friend WithEvents TestDataSet3 As testDataSet3
    Friend WithEvents DistanceBindingSource As BindingSource
    Friend WithEvents DistanceTableAdapter As testDataSet3TableAdapters.distanceTableAdapter
    Friend WithEvents TestDataSet5 As testDataSet5
    Friend WithEvents DistanceBindingSource1 As BindingSource
    Friend WithEvents DistanceTableAdapter1 As testDataSet5TableAdapters.distanceTableAdapter
    Friend WithEvents TestDataSet6 As testDataSet6
    Friend WithEvents DistanceBindingSource2 As BindingSource
    Friend WithEvents DistanceTableAdapter2 As testDataSet6TableAdapters.distanceTableAdapter
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents distanceview As DataGridView
    Friend WithEvents Distance As distance
    Friend WithEvents DistanceBindingSource3 As BindingSource
    Friend WithEvents DistanceTableAdapter3 As distanceTableAdapters.distanceTableAdapter
    Friend WithEvents DistanceIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FromLocationIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ToLocationIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DistanceApartDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TimeApartDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DatecreatedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastchangedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ActiveYNDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
