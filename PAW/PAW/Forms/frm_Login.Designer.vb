<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_login))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_show_pass = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(246, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "نام کاربری"
        '
        'txt_username
        '
        Me.txt_username.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txt_username.Location = New System.Drawing.Point(40, 26)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(200, 32)
        Me.txt_username.TabIndex = 0
        Me.txt_username.Text = "amir"
        Me.txt_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(246, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 28)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "کلمه عبور"
        '
        'txt_password
        '
        Me.txt_password.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txt_password.Location = New System.Drawing.Point(40, 67)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.Size = New System.Drawing.Size(200, 32)
        Me.txt_password.TabIndex = 1
        Me.txt_password.Text = "moosavi/12345"
        Me.txt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_password.UseSystemPasswordChar = True
        '
        'btn_ok
        '
        Me.btn_ok.Image = Global.PAW.My.Resources.Resources.Small_Ok
        Me.btn_ok.Location = New System.Drawing.Point(40, 105)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(75, 75)
        Me.btn_ok.TabIndex = 2
        Me.btn_ok.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_cancel.Image = Global.PAW.My.Resources.Resources.Small_No
        Me.btn_cancel.Location = New System.Drawing.Point(121, 105)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(75, 75)
        Me.btn_cancel.TabIndex = 3
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PAW.My.Resources.Resources.padlock
        Me.PictureBox1.Location = New System.Drawing.Point(320, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(154, 154)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'btn_show_pass
        '
        Me.btn_show_pass.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_show_pass.FlatAppearance.BorderSize = 0
        Me.btn_show_pass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.btn_show_pass.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.btn_show_pass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_show_pass.Image = Global.PAW.My.Resources.Resources.icons8_vision_24
        Me.btn_show_pass.Location = New System.Drawing.Point(9, 73)
        Me.btn_show_pass.Name = "btn_show_pass"
        Me.btn_show_pass.Size = New System.Drawing.Size(25, 25)
        Me.btn_show_pass.TabIndex = 3
        Me.btn_show_pass.UseVisualStyleBackColor = True
        '
        'frm_login
        '
        Me.AcceptButton = Me.btn_ok
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.CancelButton = Me.btn_cancel
        Me.ClientSize = New System.Drawing.Size(493, 207)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_ok)
        Me.Controls.Add(Me.btn_show_pass)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.txt_username)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("B Kamran", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_login"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "برنامه ریزی کارهای اداری / ورود کاربر"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_username As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_password As TextBox
    Friend WithEvents btn_cancel As Button
    Friend WithEvents btn_ok As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_show_pass As Button
End Class
