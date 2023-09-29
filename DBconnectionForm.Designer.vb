<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DBconnectionForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btndisconnect = New System.Windows.Forms.Button()
        Me.lblstatus = New System.Windows.Forms.Label()
        Me.btnconnect = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblproceed = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkGray
        Me.Panel1.Controls.Add(Me.lblproceed)
        Me.Panel1.Controls.Add(Me.lblstatus)
        Me.Panel1.Controls.Add(Me.btndisconnect)
        Me.Panel1.Controls.Add(Me.btnconnect)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(655, 450)
        Me.Panel1.TabIndex = 1
        '
        'btndisconnect
        '
        Me.btndisconnect.BackColor = System.Drawing.Color.Red
        Me.btndisconnect.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndisconnect.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btndisconnect.Location = New System.Drawing.Point(74, 297)
        Me.btndisconnect.Name = "btndisconnect"
        Me.btndisconnect.Size = New System.Drawing.Size(158, 55)
        Me.btndisconnect.TabIndex = 16
        Me.btndisconnect.Text = "Disconnect"
        Me.btndisconnect.UseVisualStyleBackColor = False
        '
        'lblstatus
        '
        Me.lblstatus.AutoSize = True
        Me.lblstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstatus.Location = New System.Drawing.Point(379, 233)
        Me.lblstatus.Name = "lblstatus"
        Me.lblstatus.Size = New System.Drawing.Size(0, 24)
        Me.lblstatus.TabIndex = 15
        '
        'btnconnect
        '
        Me.btnconnect.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnconnect.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnconnect.ForeColor = System.Drawing.Color.Magenta
        Me.btnconnect.Location = New System.Drawing.Point(74, 161)
        Me.btnconnect.Name = "btnconnect"
        Me.btnconnect.Size = New System.Drawing.Size(158, 55)
        Me.btnconnect.TabIndex = 13
        Me.btnconnect.Text = "Connect "
        Me.btnconnect.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Yellow
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(655, 88)
        Me.Panel2.TabIndex = 12
        Me.Panel2.Tag = "Dashboard"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(168, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(320, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Manage Connection"
        '
        'lblproceed
        '
        Me.lblproceed.AutoSize = True
        Me.lblproceed.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblproceed.Location = New System.Drawing.Point(379, 268)
        Me.lblproceed.Name = "lblproceed"
        Me.lblproceed.Size = New System.Drawing.Size(0, 24)
        Me.lblproceed.TabIndex = 16
        '
        'DBconnectionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(655, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "DBconnectionForm"
        Me.Text = "DBconnectionForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btndisconnect As Button
    Friend WithEvents lblstatus As Label
    Friend WithEvents btnconnect As Button
    Friend WithEvents lblproceed As Label
End Class
