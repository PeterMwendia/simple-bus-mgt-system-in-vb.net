﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Driver_BusForm
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
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btnremove = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.txtactiv = New System.Windows.Forms.TextBox()
        Me.txtlchd = New System.Windows.Forms.TextBox()
        Me.txtdte = New System.Windows.Forms.TextBox()
        Me.txtfname = New System.Windows.Forms.TextBox()
        Me.txtmname = New System.Windows.Forms.TextBox()
        Me.txtcustid = New System.Windows.Forms.TextBox()
        Me.lblfname = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblcusid = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Driverbus = New Ent.Driverbus()
        Me.DriverbusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DriverbusTableAdapter = New Ent.DriverbusTableAdapters.driverbusTableAdapter()
        Me.DriverBusIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DriverIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BusIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatecreatedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastchangedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActiveYNDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Driverbus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DriverbusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.btnedit)
        Me.Panel1.Controls.Add(Me.btnremove)
        Me.Panel1.Controls.Add(Me.btnadd)
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
        Me.Panel1.Size = New System.Drawing.Size(1139, 684)
        Me.Panel1.TabIndex = 1
        '
        'btnedit
        '
        Me.btnedit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnedit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnedit.Location = New System.Drawing.Point(203, 366)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(85, 38)
        Me.btnedit.TabIndex = 32
        Me.btnedit.Text = "Edit"
        Me.btnedit.UseVisualStyleBackColor = False
        '
        'btnremove
        '
        Me.btnremove.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnremove.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnremove.Location = New System.Drawing.Point(335, 366)
        Me.btnremove.Name = "btnremove"
        Me.btnremove.Size = New System.Drawing.Size(85, 38)
        Me.btnremove.TabIndex = 31
        Me.btnremove.Text = "Remove"
        Me.btnremove.UseVisualStyleBackColor = False
        '
        'btnadd
        '
        Me.btnadd.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.Location = New System.Drawing.Point(81, 366)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(85, 38)
        Me.btnadd.TabIndex = 30
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = False
        '
        'txtactiv
        '
        Me.txtactiv.Location = New System.Drawing.Point(128, 279)
        Me.txtactiv.Name = "txtactiv"
        Me.txtactiv.Size = New System.Drawing.Size(190, 20)
        Me.txtactiv.TabIndex = 29
        '
        'txtlchd
        '
        Me.txtlchd.Location = New System.Drawing.Point(128, 241)
        Me.txtlchd.Name = "txtlchd"
        Me.txtlchd.Size = New System.Drawing.Size(190, 20)
        Me.txtlchd.TabIndex = 28
        '
        'txtdte
        '
        Me.txtdte.Location = New System.Drawing.Point(128, 205)
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
        'txtmname
        '
        Me.txtmname.Location = New System.Drawing.Point(128, 166)
        Me.txtmname.Name = "txtmname"
        Me.txtmname.Size = New System.Drawing.Size(190, 20)
        Me.txtmname.TabIndex = 15
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
        Me.lblfname.Location = New System.Drawing.Point(49, 136)
        Me.lblfname.Name = "lblfname"
        Me.lblfname.Size = New System.Drawing.Size(62, 18)
        Me.lblfname.TabIndex = 13
        Me.lblfname.Text = "DriverId:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(62, 168)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 18)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "BusId:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(16, 207)
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
        Me.Label5.Location = New System.Drawing.Point(12, 243)
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
        Me.Label3.Location = New System.Drawing.Point(60, 281)
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
        Me.lblcusid.Location = New System.Drawing.Point(23, 101)
        Me.lblcusid.Name = "lblcusid"
        Me.lblcusid.Size = New System.Drawing.Size(88, 18)
        Me.lblcusid.TabIndex = 1
        Me.lblcusid.Text = "DriverBusId:"
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
        Me.Label1.Location = New System.Drawing.Point(309, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Driver Bus"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DriverBusIDDataGridViewTextBoxColumn, Me.DriverIDDataGridViewTextBoxColumn, Me.BusIDDataGridViewTextBoxColumn, Me.DatecreatedDataGridViewTextBoxColumn, Me.LastchangedDataGridViewTextBoxColumn, Me.ActiveYNDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.DriverbusBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(462, 101)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(643, 150)
        Me.DataGridView1.TabIndex = 33
        '
        'Driverbus
        '
        Me.Driverbus.DataSetName = "Driverbus"
        Me.Driverbus.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DriverbusBindingSource
        '
        Me.DriverbusBindingSource.DataMember = "driverbus"
        Me.DriverbusBindingSource.DataSource = Me.Driverbus
        '
        'DriverbusTableAdapter
        '
        Me.DriverbusTableAdapter.ClearBeforeFill = True
        '
        'DriverBusIDDataGridViewTextBoxColumn
        '
        Me.DriverBusIDDataGridViewTextBoxColumn.DataPropertyName = "DriverBusID"
        Me.DriverBusIDDataGridViewTextBoxColumn.HeaderText = "DriverBusID"
        Me.DriverBusIDDataGridViewTextBoxColumn.Name = "DriverBusIDDataGridViewTextBoxColumn"
        '
        'DriverIDDataGridViewTextBoxColumn
        '
        Me.DriverIDDataGridViewTextBoxColumn.DataPropertyName = "DriverID"
        Me.DriverIDDataGridViewTextBoxColumn.HeaderText = "DriverID"
        Me.DriverIDDataGridViewTextBoxColumn.Name = "DriverIDDataGridViewTextBoxColumn"
        '
        'BusIDDataGridViewTextBoxColumn
        '
        Me.BusIDDataGridViewTextBoxColumn.DataPropertyName = "BusID"
        Me.BusIDDataGridViewTextBoxColumn.HeaderText = "BusID"
        Me.BusIDDataGridViewTextBoxColumn.Name = "BusIDDataGridViewTextBoxColumn"
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
        'Driver_BusForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1139, 684)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Driver_BusForm"
        Me.Text = "Driver_BusForm"
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Driverbus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DriverbusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CustomerTableAdapter As testDataSetTableAdapters.customerTableAdapter
    Friend WithEvents CustomerBindingSource As BindingSource
    Friend WithEvents TestDataSet As testDataSet
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnedit As Button
    Friend WithEvents btnremove As Button
    Friend WithEvents btnadd As Button
    Friend WithEvents txtactiv As TextBox
    Friend WithEvents txtlchd As TextBox
    Friend WithEvents txtdte As TextBox
    Friend WithEvents txtfname As TextBox
    Friend WithEvents txtmname As TextBox
    Friend WithEvents txtcustid As TextBox
    Friend WithEvents lblfname As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblcusid As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Driverbus As Driverbus
    Friend WithEvents DriverbusBindingSource As BindingSource
    Friend WithEvents DriverbusTableAdapter As DriverbusTableAdapters.driverbusTableAdapter
    Friend WithEvents DriverBusIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DriverIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BusIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DatecreatedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastchangedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ActiveYNDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
