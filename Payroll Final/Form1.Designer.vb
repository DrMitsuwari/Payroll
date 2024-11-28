<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogIn
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
        Me.Username = New System.Windows.Forms.TextBox()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Log = New System.Windows.Forms.Button()
        Me.Power = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'Username
        '
        Me.Username.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Username.Location = New System.Drawing.Point(482, 101)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(270, 31)
        Me.Username.TabIndex = 0
        '
        'Password
        '
        Me.Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password.Location = New System.Drawing.Point(482, 175)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(270, 31)
        Me.Password.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(478, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(478, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Password"
        '
        'Log
        '
        Me.Log.BackColor = System.Drawing.Color.LightCyan
        Me.Log.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Log.Location = New System.Drawing.Point(677, 235)
        Me.Log.Name = "Log"
        Me.Log.Size = New System.Drawing.Size(75, 23)
        Me.Log.TabIndex = 6
        Me.Log.Text = "Log In"
        Me.Log.UseVisualStyleBackColor = False
        '
        'Power
        '
        Me.Power.BackgroundImage = Global.Payroll_Final.My.Resources.Resources.images
        Me.Power.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Power.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Power.Location = New System.Drawing.Point(752, 400)
        Me.Power.Name = "Power"
        Me.Power.Size = New System.Drawing.Size(36, 38)
        Me.Power.TabIndex = 7
        Me.Power.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.Payroll_Final.My.Resources.Resources.m
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(476, 468)
        Me.Panel1.TabIndex = 2
        '
        'LogIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.Power)
        Me.Controls.Add(Me.Log)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.Username)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LogIn"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Username As TextBox
    Friend WithEvents Password As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Log As Button
    Friend WithEvents Power As Button
End Class
