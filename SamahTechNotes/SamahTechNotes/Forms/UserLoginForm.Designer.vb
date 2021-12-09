<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserLoginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserLoginForm))
        Me.UserNameText = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PasswordText = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.OkBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'UserNameText
        '
        Me.UserNameText.BackColor = Color.Gray 'System.Drawing.Color.Maroon
        Me.UserNameText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.UserNameText.ForeColor = System.Drawing.Color.White
        Me.UserNameText.Location = New System.Drawing.Point(179, 182)
        Me.UserNameText.Name = "UserNameText"
        Me.UserNameText.Size = New System.Drawing.Size(242, 29)
        Me.UserNameText.TabIndex = 4
        Me.UserNameText.Text = "sdfsdgsgsd"
        Me.UserNameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("B Nazanin", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(261, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 30)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "نام کاربری"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(177, 191)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(247, 28)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "______________________"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PasswordText
        '
        Me.PasswordText.BackColor = Color.Gray 'System.Drawing.Color.Maroon
        Me.PasswordText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PasswordText.ForeColor = System.Drawing.Color.White
        Me.PasswordText.Location = New System.Drawing.Point(179, 297)
        Me.PasswordText.Name = "PasswordText"
        Me.PasswordText.Size = New System.Drawing.Size(242, 29)
        Me.PasswordText.TabIndex = 7
        Me.PasswordText.Text = "sdfsdgsgsd"
        Me.PasswordText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.PasswordText.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("B Nazanin", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(261, 250)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 30)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "کلمه عبور"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(177, 306)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(247, 28)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "______________________"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'OkBtn
        '
        Me.OkBtn.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.OkBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.OkBtn.FlatAppearance.BorderSize = 0
        Me.OkBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LawnGreen
        Me.OkBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GreenYellow
        Me.OkBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OkBtn.Image = CType(resources.GetObject("OkBtn.Image"), System.Drawing.Image)
        Me.OkBtn.Location = New System.Drawing.Point(12, 363)
        Me.OkBtn.Name = "OkBtn"
        Me.OkBtn.Size = New System.Drawing.Size(576, 64)
        Me.OkBtn.TabIndex = 9
        Me.OkBtn.UseVisualStyleBackColor = True
        '
        'UserLoginForm
        '
        Me.AcceptButton = Me.OkBtn
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = Color.Gray 'System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(600, 650)
        Me.ControlBox = False
        Me.Controls.Add(Me.OkBtn)
        Me.Controls.Add(Me.PasswordText)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.UserNameText)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("B Nazanin", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "UserLoginForm"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "دفترچه یادداشت سما / ورود کاربر"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UserNameText As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PasswordText As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents OkBtn As Button
End Class
