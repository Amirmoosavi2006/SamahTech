<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UsersForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UsersForm))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SexCombo = New System.Windows.Forms.ComboBox()
        Me.AccessLevelCombo = New System.Windows.Forms.ComboBox()
        Me.ContractStatusCombo = New System.Windows.Forms.ComboBox()
        Me.InternalPhoneText = New System.Windows.Forms.TextBox()
        Me.MobileText = New System.Windows.Forms.TextBox()
        Me.PhoneText = New System.Windows.Forms.TextBox()
        Me.PasswordText = New System.Windows.Forms.TextBox()
        Me.UserNameText = New System.Windows.Forms.TextBox()
        Me.EmailText = New System.Windows.Forms.TextBox()
        Me.PostText = New System.Windows.Forms.TextBox()
        Me.LnameText = New System.Windows.Forms.TextBox()
        Me.FnameText = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.ReturnBtn = New System.Windows.Forms.Button()
        Me.FindBtn = New System.Windows.Forms.Button()
        Me.UsersDGV = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.UsersDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.SexCombo)
        Me.GroupBox1.Controls.Add(Me.AccessLevelCombo)
        Me.GroupBox1.Controls.Add(Me.ContractStatusCombo)
        Me.GroupBox1.Controls.Add(Me.InternalPhoneText)
        Me.GroupBox1.Controls.Add(Me.MobileText)
        Me.GroupBox1.Controls.Add(Me.PhoneText)
        Me.GroupBox1.Controls.Add(Me.PasswordText)
        Me.GroupBox1.Controls.Add(Me.UserNameText)
        Me.GroupBox1.Controls.Add(Me.EmailText)
        Me.GroupBox1.Controls.Add(Me.PostText)
        Me.GroupBox1.Controls.Add(Me.LnameText)
        Me.GroupBox1.Controls.Add(Me.FnameText)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(576, 290)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "اطلاعات کاربری"
        '
        'SexCombo
        '
        Me.SexCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.SexCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.SexCombo.BackColor = Color.Gray 'System.Drawing.Color.DarkSlateGray
        Me.SexCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SexCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SexCombo.ForeColor = System.Drawing.Color.LightCoral
        Me.SexCombo.FormattingEnabled = True
        Me.SexCombo.Items.AddRange(New Object() {"مرد", "زن"})
        Me.SexCombo.Location = New System.Drawing.Point(71, 147)
        Me.SexCombo.Name = "SexCombo"
        Me.SexCombo.Size = New System.Drawing.Size(145, 35)
        Me.SexCombo.TabIndex = 26
        '
        'AccessLevelCombo
        '
        Me.AccessLevelCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.AccessLevelCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.AccessLevelCombo.BackColor = Color.Gray 'System.Drawing.Color.DarkSlateGray
        Me.AccessLevelCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AccessLevelCombo.ForeColor = System.Drawing.Color.LightCoral
        Me.AccessLevelCombo.FormattingEnabled = True
        Me.AccessLevelCombo.Items.AddRange(New Object() {"کاربر ارشد", "کاربر ویژه", "کاربر عادی"})
        Me.AccessLevelCombo.Location = New System.Drawing.Point(71, 190)
        Me.AccessLevelCombo.Name = "AccessLevelCombo"
        Me.AccessLevelCombo.Size = New System.Drawing.Size(145, 35)
        Me.AccessLevelCombo.TabIndex = 26
        '
        'ContractStatusCombo
        '
        Me.ContractStatusCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ContractStatusCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ContractStatusCombo.BackColor = Color.Gray 'System.Drawing.Color.DarkSlateGray
        Me.ContractStatusCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ContractStatusCombo.ForeColor = System.Drawing.Color.LightCoral
        Me.ContractStatusCombo.FormattingEnabled = True
        Me.ContractStatusCombo.Items.AddRange(New Object() {"رسمی", "قراردادی", "پیمانکاری", "روز مزد"})
        Me.ContractStatusCombo.Location = New System.Drawing.Point(306, 190)
        Me.ContractStatusCombo.Name = "ContractStatusCombo"
        Me.ContractStatusCombo.Size = New System.Drawing.Size(145, 35)
        Me.ContractStatusCombo.TabIndex = 25
        '
        'InternalPhoneText
        '
        Me.InternalPhoneText.BackColor = Color.Gray 'System.Drawing.Color.DarkSlateGray
        Me.InternalPhoneText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.InternalPhoneText.ForeColor = System.Drawing.Color.LightCoral
        Me.InternalPhoneText.Location = New System.Drawing.Point(71, 110)
        Me.InternalPhoneText.Name = "InternalPhoneText"
        Me.InternalPhoneText.Size = New System.Drawing.Size(145, 27)
        Me.InternalPhoneText.TabIndex = 23
        Me.InternalPhoneText.Text = "سیدامیر"
        Me.InternalPhoneText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MobileText
        '
        Me.MobileText.BackColor = Color.Gray 'System.Drawing.Color.DarkSlateGray
        Me.MobileText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MobileText.ForeColor = System.Drawing.Color.LightCoral
        Me.MobileText.Location = New System.Drawing.Point(71, 30)
        Me.MobileText.Name = "MobileText"
        Me.MobileText.Size = New System.Drawing.Size(145, 27)
        Me.MobileText.TabIndex = 22
        Me.MobileText.Text = "سیدامیر"
        Me.MobileText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PhoneText
        '
        Me.PhoneText.BackColor = Color.Gray 'System.Drawing.Color.DarkSlateGray
        Me.PhoneText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PhoneText.ForeColor = System.Drawing.Color.LightCoral
        Me.PhoneText.Location = New System.Drawing.Point(71, 70)
        Me.PhoneText.Name = "PhoneText"
        Me.PhoneText.Size = New System.Drawing.Size(145, 27)
        Me.PhoneText.TabIndex = 21
        Me.PhoneText.Text = "سیدامیر"
        Me.PhoneText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PasswordText
        '
        Me.PasswordText.BackColor = Color.Gray 'System.Drawing.Color.Indigo
        Me.PasswordText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PasswordText.ForeColor = System.Drawing.Color.White
        Me.PasswordText.Location = New System.Drawing.Point(71, 248)
        Me.PasswordText.Name = "PasswordText"
        Me.PasswordText.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordText.Size = New System.Drawing.Size(145, 27)
        Me.PasswordText.TabIndex = 20
        Me.PasswordText.Text = "سیدامیر"
        Me.PasswordText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'UserNameText
        '
        Me.UserNameText.BackColor = Color.Gray 'System.Drawing.Color.Indigo
        Me.UserNameText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.UserNameText.ForeColor = System.Drawing.Color.White
        Me.UserNameText.Location = New System.Drawing.Point(306, 248)
        Me.UserNameText.Name = "UserNameText"
        Me.UserNameText.Size = New System.Drawing.Size(145, 27)
        Me.UserNameText.TabIndex = 19
        Me.UserNameText.Text = "سیدامیر"
        Me.UserNameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'EmailText
        '
        Me.EmailText.BackColor = Color.Gray 'System.Drawing.Color.DarkSlateGray
        Me.EmailText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.EmailText.ForeColor = System.Drawing.Color.LightCoral
        Me.EmailText.Location = New System.Drawing.Point(306, 150)
        Me.EmailText.Name = "EmailText"
        Me.EmailText.Size = New System.Drawing.Size(145, 27)
        Me.EmailText.TabIndex = 17
        Me.EmailText.Text = "سیدامیر"
        Me.EmailText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PostText
        '
        Me.PostText.BackColor = Color.Gray 'System.Drawing.Color.DarkSlateGray
        Me.PostText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PostText.ForeColor = System.Drawing.Color.LightCoral
        Me.PostText.Location = New System.Drawing.Point(306, 110)
        Me.PostText.Name = "PostText"
        Me.PostText.Size = New System.Drawing.Size(145, 27)
        Me.PostText.TabIndex = 16
        Me.PostText.Text = "سیدامیر"
        Me.PostText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LnameText
        '
        Me.LnameText.BackColor = Color.Gray 'System.Drawing.Color.DarkSlateGray
        Me.LnameText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LnameText.ForeColor = System.Drawing.Color.LightCoral
        Me.LnameText.Location = New System.Drawing.Point(306, 70)
        Me.LnameText.Name = "LnameText"
        Me.LnameText.Size = New System.Drawing.Size(145, 27)
        Me.LnameText.TabIndex = 24
        Me.LnameText.Text = "سیدامیر"
        Me.LnameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FnameText
        '
        Me.FnameText.BackColor = Color.Gray 'System.Drawing.Color.DarkSlateGray
        Me.FnameText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FnameText.ForeColor = System.Drawing.Color.LightCoral
        Me.FnameText.Location = New System.Drawing.Point(306, 30)
        Me.FnameText.Name = "FnameText"
        Me.FnameText.Size = New System.Drawing.Size(145, 27)
        Me.FnameText.TabIndex = 15
        Me.FnameText.Text = "سیدامیر"
        Me.FnameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(222, 194)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(78, 27)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "سطح دسترسی"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(457, 194)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(86, 27)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "وضعیت قرارداد"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(222, 150)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 27)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "جنسیت"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(222, 248)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 27)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "رمز عبور"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(457, 248)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 27)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "نام کاربری"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(457, 150)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 27)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "آدرس پستی"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(222, 110)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 27)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "داخلی"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(222, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 27)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "تلفن ثابت"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(222, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 27)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "شماره همراه"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(466, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 27)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "سمت"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(457, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 27)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "نام خانوادگی"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(457, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 27)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "نام"
        '
        'SaveBtn
        '
        Me.SaveBtn.FlatAppearance.BorderSize = 0
        Me.SaveBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tan
        Me.SaveBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveBtn.Image = CType(resources.GetObject("SaveBtn.Image"), System.Drawing.Image)
        Me.SaveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SaveBtn.Location = New System.Drawing.Point(202, 308)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(89, 39)
        Me.SaveBtn.TabIndex = 28
        Me.SaveBtn.Text = "ثبت"
        Me.SaveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SaveBtn.UseVisualStyleBackColor = True
        '
        'ReturnBtn
        '
        Me.ReturnBtn.FlatAppearance.BorderSize = 0
        Me.ReturnBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tan
        Me.ReturnBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.ReturnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ReturnBtn.Image = CType(resources.GetObject("ReturnBtn.Image"), System.Drawing.Image)
        Me.ReturnBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ReturnBtn.Location = New System.Drawing.Point(12, 308)
        Me.ReturnBtn.Name = "ReturnBtn"
        Me.ReturnBtn.Size = New System.Drawing.Size(89, 39)
        Me.ReturnBtn.TabIndex = 29
        Me.ReturnBtn.Text = "بازگشت"
        Me.ReturnBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ReturnBtn.UseVisualStyleBackColor = True
        '
        'FindBtn
        '
        Me.FindBtn.FlatAppearance.BorderSize = 0
        Me.FindBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tan
        Me.FindBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.FindBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FindBtn.Image = CType(resources.GetObject("FindBtn.Image"), System.Drawing.Image)
        Me.FindBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.FindBtn.Location = New System.Drawing.Point(107, 308)
        Me.FindBtn.Name = "FindBtn"
        Me.FindBtn.Size = New System.Drawing.Size(89, 39)
        Me.FindBtn.TabIndex = 30
        Me.FindBtn.Text = "جستجو"
        Me.FindBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.FindBtn.UseVisualStyleBackColor = True
        '
        'UsersDGV
        '
        Me.UsersDGV.AllowUserToAddRows = False
        Me.UsersDGV.AllowUserToDeleteRows = False
        Me.UsersDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.UsersDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.UsersDGV.BackgroundColor = System.Drawing.Color.CadetBlue
        Me.UsersDGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.UsersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UsersDGV.GridColor = System.Drawing.Color.Black
        Me.UsersDGV.Location = New System.Drawing.Point(12, 353)
        Me.UsersDGV.MultiSelect = False
        Me.UsersDGV.Name = "UsersDGV"
        Me.UsersDGV.RowHeadersVisible = False
        Me.UsersDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.UsersDGV.ShowCellErrors = False
        Me.UsersDGV.ShowCellToolTips = False
        Me.UsersDGV.ShowEditingIcon = False
        Me.UsersDGV.ShowRowErrors = False
        Me.UsersDGV.Size = New System.Drawing.Size(576, 259)
        Me.UsersDGV.TabIndex = 31
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tan
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(297, 308)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 39)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "جدید"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'UsersForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = Color.Gray 'System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(600, 650)
        Me.ControlBox = False
        Me.Controls.Add(Me.UsersDGV)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.SaveBtn)
        Me.Controls.Add(Me.ReturnBtn)
        Me.Controls.Add(Me.FindBtn)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("B Zar", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "UsersForm"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "دفترچه یادداشت سما / تنظیمات کاربری"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.UsersDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents AccessLevelCombo As ComboBox
    Friend WithEvents ContractStatusCombo As ComboBox
    Friend WithEvents InternalPhoneText As TextBox
    Friend WithEvents MobileText As TextBox
    Friend WithEvents PhoneText As TextBox
    Friend WithEvents PasswordText As TextBox
    Friend WithEvents UserNameText As TextBox
    Friend WithEvents EmailText As TextBox
    Friend WithEvents PostText As TextBox
    Friend WithEvents LnameText As TextBox
    Friend WithEvents FnameText As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents SexCombo As ComboBox
    Friend WithEvents SaveBtn As Button
    Friend WithEvents ReturnBtn As Button
    Friend WithEvents FindBtn As Button
    Friend WithEvents UsersDGV As DataGridView
    Friend WithEvents Button1 As Button
End Class
