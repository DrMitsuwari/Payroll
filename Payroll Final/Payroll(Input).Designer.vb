<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Payroll_Input_
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
        Me.FName = New System.Windows.Forms.TextBox()
        Me.LName = New System.Windows.Forms.TextBox()
        Me.MName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Occu = New System.Windows.Forms.ComboBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.PayrollDB = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TS = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.OT = New System.Windows.Forms.ComboBox()
        Me.SSS = New System.Windows.Forms.CheckBox()
        Me.PhilHealth = New System.Windows.Forms.CheckBox()
        Me.PAGIBIG = New System.Windows.Forms.CheckBox()
        Me.Clear = New System.Windows.Forms.Button()
        Me.add = New System.Windows.Forms.Button()
        Me.LogOut = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.PayrollDB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FName
        '
        Me.FName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FName.Location = New System.Drawing.Point(36, 44)
        Me.FName.Name = "FName"
        Me.FName.Size = New System.Drawing.Size(289, 29)
        Me.FName.TabIndex = 0
        '
        'LName
        '
        Me.LName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LName.Location = New System.Drawing.Point(36, 133)
        Me.LName.Name = "LName"
        Me.LName.Size = New System.Drawing.Size(289, 29)
        Me.LName.TabIndex = 1
        '
        'MName
        '
        Me.MName.AcceptsReturn = True
        Me.MName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MName.Location = New System.Drawing.Point(36, 89)
        Me.MName.Name = "MName"
        Me.MName.Size = New System.Drawing.Size(289, 29)
        Me.MName.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Candara", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "First Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Candara", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(33, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Middle Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Candara", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(33, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Last Name"
        '
        'Occu
        '
        Me.Occu.FormattingEnabled = True
        Me.Occu.Items.AddRange(New Object() {"Manager", "Senior Programmer", "Junior Programmer", "Paid Inter"})
        Me.Occu.Location = New System.Drawing.Point(356, 44)
        Me.Occu.Name = "Occu"
        Me.Occu.Size = New System.Drawing.Size(191, 21)
        Me.Occu.TabIndex = 6
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(23, 214)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(688, 195)
        Me.TabControl1.TabIndex = 7
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.PayrollDB)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(680, 169)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Payroll"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'PayrollDB
        '
        Me.PayrollDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PayrollDB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PayrollDB.Location = New System.Drawing.Point(3, 3)
        Me.PayrollDB.Name = "PayrollDB"
        Me.PayrollDB.Size = New System.Drawing.Size(674, 163)
        Me.PayrollDB.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Candara", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(353, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Occupation"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Candara", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(353, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Time spent"
        '
        'TS
        '
        Me.TS.FormattingEnabled = True
        Me.TS.Items.AddRange(New Object() {"5", "6", "7", "8"})
        Me.TS.Location = New System.Drawing.Point(356, 89)
        Me.TS.Name = "TS"
        Me.TS.Size = New System.Drawing.Size(57, 21)
        Me.TS.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Candara", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(419, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Overtime"
        '
        'OT
        '
        Me.OT.FormattingEnabled = True
        Me.OT.Items.AddRange(New Object() {"1", "2", "3"})
        Me.OT.Location = New System.Drawing.Point(422, 89)
        Me.OT.Name = "OT"
        Me.OT.Size = New System.Drawing.Size(57, 21)
        Me.OT.TabIndex = 12
        '
        'SSS
        '
        Me.SSS.AutoSize = True
        Me.SSS.Location = New System.Drawing.Point(356, 125)
        Me.SSS.Name = "SSS"
        Me.SSS.Size = New System.Drawing.Size(47, 17)
        Me.SSS.TabIndex = 13
        Me.SSS.Text = "SSS"
        Me.SSS.UseVisualStyleBackColor = True
        '
        'PhilHealth
        '
        Me.PhilHealth.AutoSize = True
        Me.PhilHealth.Location = New System.Drawing.Point(443, 125)
        Me.PhilHealth.Name = "PhilHealth"
        Me.PhilHealth.Size = New System.Drawing.Size(72, 17)
        Me.PhilHealth.TabIndex = 14
        Me.PhilHealth.Text = "Philhealth"
        Me.PhilHealth.UseVisualStyleBackColor = True
        '
        'PAGIBIG
        '
        Me.PAGIBIG.AutoSize = True
        Me.PAGIBIG.Location = New System.Drawing.Point(356, 148)
        Me.PAGIBIG.Name = "PAGIBIG"
        Me.PAGIBIG.Size = New System.Drawing.Size(72, 17)
        Me.PAGIBIG.TabIndex = 15
        Me.PAGIBIG.Text = "PAG-IBIG"
        Me.PAGIBIG.UseVisualStyleBackColor = True
        '
        'Clear
        '
        Me.Clear.Location = New System.Drawing.Point(28, 415)
        Me.Clear.Name = "Clear"
        Me.Clear.Size = New System.Drawing.Size(75, 23)
        Me.Clear.TabIndex = 17
        Me.Clear.Text = "Clear"
        Me.Clear.UseVisualStyleBackColor = True
        '
        'add
        '
        Me.add.Location = New System.Drawing.Point(109, 415)
        Me.add.Name = "add"
        Me.add.Size = New System.Drawing.Size(75, 23)
        Me.add.TabIndex = 18
        Me.add.Text = "Add"
        Me.add.UseVisualStyleBackColor = True
        '
        'LogOut
        '
        Me.LogOut.Location = New System.Drawing.Point(696, 415)
        Me.LogOut.Name = "LogOut"
        Me.LogOut.Size = New System.Drawing.Size(75, 23)
        Me.LogOut.TabIndex = 19
        Me.LogOut.Text = "Log out"
        Me.LogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.LogOut.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.Payroll_Final.My.Resources.Resources.m
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Location = New System.Drawing.Point(587, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(201, 196)
        Me.Panel1.TabIndex = 16
        '
        'Payroll_Input_
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.LogOut)
        Me.Controls.Add(Me.add)
        Me.Controls.Add(Me.Clear)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PAGIBIG)
        Me.Controls.Add(Me.PhilHealth)
        Me.Controls.Add(Me.SSS)
        Me.Controls.Add(Me.OT)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TS)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Occu)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MName)
        Me.Controls.Add(Me.LName)
        Me.Controls.Add(Me.FName)
        Me.Name = "Payroll_Input_"
        Me.Text = " "
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.PayrollDB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FName As TextBox
    Friend WithEvents LName As TextBox
    Friend WithEvents MName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Occu As ComboBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TS As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents OT As ComboBox
    Friend WithEvents SSS As CheckBox
    Friend WithEvents PhilHealth As CheckBox
    Friend WithEvents PAGIBIG As CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Clear As Button
    Friend WithEvents add As Button
    Friend WithEvents LogOut As Button
    Friend WithEvents PayrollDB As DataGridView
End Class
