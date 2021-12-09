<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Users
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Users))
        Me.dgv_users = New System.Windows.Forms.DataGridView()
        Me.btn_return = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.NameText = New System.Windows.Forms.TextBox()
        Me.FamilyText = New System.Windows.Forms.TextBox()
        Me.MobileText = New System.Windows.Forms.TextBox()
        Me.PhoneText = New System.Windows.Forms.TextBox()
        Me.NoText = New System.Windows.Forms.TextBox()
        Me.UserNameText = New System.Windows.Forms.TextBox()
        Me.PasswordText = New System.Windows.Forms.TextBox()
        Me.cmb_role = New System.Windows.Forms.ComboBox()
        Me.btn_find = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_del = New System.Windows.Forms.Button()
        CType(Me.dgv_users, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_users
        '
        Me.dgv_users.AllowUserToAddRows = False
        Me.dgv_users.AllowUserToDeleteRows = False
        Me.dgv_users.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_users.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_users.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgv_users.Location = New System.Drawing.Point(0, 283)
        Me.dgv_users.Name = "dgv_users"
        Me.dgv_users.ReadOnly = True
        Me.dgv_users.RowHeadersVisible = False
        Me.dgv_users.RowHeadersWidth = 51
        Me.dgv_users.RowTemplate.Height = 24
        Me.dgv_users.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_users.ShowCellErrors = False
        Me.dgv_users.ShowEditingIcon = False
        Me.dgv_users.ShowRowErrors = False
        Me.dgv_users.Size = New System.Drawing.Size(782, 270)
        Me.dgv_users.TabIndex = 135
        Me.dgv_users.TabStop = False
        '
        'btn_return
        '
        Me.btn_return.Image = Global.PAW.My.Resources.Resources.icons8_end_button_50
        Me.btn_return.Location = New System.Drawing.Point(12, 227)
        Me.btn_return.Name = "btn_return"
        Me.btn_return.Size = New System.Drawing.Size(50, 50)
        Me.btn_return.TabIndex = 12
        Me.btn_return.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(678, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 32)
        Me.Label1.TabIndex = 137
        Me.Label1.Text = "نام"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(678, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 32)
        Me.Label2.TabIndex = 137
        Me.Label2.Text = "نام خانوادگی"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(678, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 32)
        Me.Label3.TabIndex = 137
        Me.Label3.Text = "شماره همراه"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(678, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 32)
        Me.Label4.TabIndex = 137
        Me.Label4.Text = "شماره تماس"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(678, 195)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 32)
        Me.Label5.TabIndex = 137
        Me.Label5.Text = "داخلی"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(678, 240)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 32)
        Me.Label6.TabIndex = 137
        Me.Label6.Text = "نقش کاربر"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(331, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 32)
        Me.Label7.TabIndex = 137
        Me.Label7.Text = "نام کاربری"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(331, 60)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 32)
        Me.Label8.TabIndex = 137
        Me.Label8.Text = "رمز عبور"
        '
        'NameText
        '
        Me.NameText.Location = New System.Drawing.Point(480, 12)
        Me.NameText.Name = "NameText"
        Me.NameText.Size = New System.Drawing.Size(192, 39)
        Me.NameText.TabIndex = 0
        Me.NameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FamilyText
        '
        Me.FamilyText.Location = New System.Drawing.Point(480, 57)
        Me.FamilyText.Name = "FamilyText"
        Me.FamilyText.Size = New System.Drawing.Size(192, 39)
        Me.FamilyText.TabIndex = 1
        Me.FamilyText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MobileText
        '
        Me.MobileText.Location = New System.Drawing.Point(480, 102)
        Me.MobileText.Name = "MobileText"
        Me.MobileText.Size = New System.Drawing.Size(192, 39)
        Me.MobileText.TabIndex = 2
        Me.MobileText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PhoneText
        '
        Me.PhoneText.Location = New System.Drawing.Point(480, 147)
        Me.PhoneText.Name = "PhoneText"
        Me.PhoneText.Size = New System.Drawing.Size(192, 39)
        Me.PhoneText.TabIndex = 3
        Me.PhoneText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NoText
        '
        Me.NoText.Location = New System.Drawing.Point(480, 192)
        Me.NoText.Name = "NoText"
        Me.NoText.Size = New System.Drawing.Size(192, 39)
        Me.NoText.TabIndex = 4
        Me.NoText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'UserNameText
        '
        Me.UserNameText.BackColor = System.Drawing.Color.LightSkyBlue
        Me.UserNameText.Location = New System.Drawing.Point(133, 12)
        Me.UserNameText.Name = "UserNameText"
        Me.UserNameText.Size = New System.Drawing.Size(192, 39)
        Me.UserNameText.TabIndex = 6
        Me.UserNameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PasswordText
        '
        Me.PasswordText.BackColor = System.Drawing.Color.LightSkyBlue
        Me.PasswordText.Location = New System.Drawing.Point(133, 57)
        Me.PasswordText.Name = "PasswordText"
        Me.PasswordText.Size = New System.Drawing.Size(192, 39)
        Me.PasswordText.TabIndex = 7
        Me.PasswordText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmb_role
        '
        Me.cmb_role.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_role.FormattingEnabled = True
        Me.cmb_role.Items.AddRange(New Object() {"معاون", "رییس اداره", "کارشناس"})
        Me.cmb_role.Location = New System.Drawing.Point(480, 237)
        Me.cmb_role.Name = "cmb_role"
        Me.cmb_role.Size = New System.Drawing.Size(192, 40)
        Me.cmb_role.TabIndex = 5
        '
        'btn_find
        '
        Me.btn_find.Image = Global.PAW.My.Resources.Resources.icons8_search_50
        Me.btn_find.Location = New System.Drawing.Point(124, 227)
        Me.btn_find.Name = "btn_find"
        Me.btn_find.Size = New System.Drawing.Size(50, 50)
        Me.btn_find.TabIndex = 10
        Me.btn_find.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Image = Global.PAW.My.Resources.Resources.icons8_edit_50
        Me.btn_edit.Location = New System.Drawing.Point(180, 227)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(50, 50)
        Me.btn_edit.TabIndex = 9
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.Image = Global.PAW.My.Resources.Resources.icons8_save_close_50
        Me.btn_add.Location = New System.Drawing.Point(236, 227)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(50, 50)
        Me.btn_add.TabIndex = 8
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'btn_del
        '
        Me.btn_del.Image = Global.PAW.My.Resources.Resources.icons8_delete_bin_40
        Me.btn_del.Location = New System.Drawing.Point(68, 227)
        Me.btn_del.Name = "btn_del"
        Me.btn_del.Size = New System.Drawing.Size(50, 50)
        Me.btn_del.TabIndex = 11
        Me.btn_del.UseVisualStyleBackColor = True
        '
        'frm_Users
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(782, 553)
        Me.Controls.Add(Me.cmb_role)
        Me.Controls.Add(Me.PasswordText)
        Me.Controls.Add(Me.UserNameText)
        Me.Controls.Add(Me.NoText)
        Me.Controls.Add(Me.PhoneText)
        Me.Controls.Add(Me.MobileText)
        Me.Controls.Add(Me.FamilyText)
        Me.Controls.Add(Me.NameText)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.btn_find)
        Me.Controls.Add(Me.btn_del)
        Me.Controls.Add(Me.btn_return)
        Me.Controls.Add(Me.dgv_users)
        Me.Font = New System.Drawing.Font("B Kamran", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_Users"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "برنامه ریزی کارهای اداری / کاربران"
        CType(Me.dgv_users, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_users As DataGridView
    Friend WithEvents btn_return As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents NameText As TextBox
    Friend WithEvents FamilyText As TextBox
    Friend WithEvents MobileText As TextBox
    Friend WithEvents PhoneText As TextBox
    Friend WithEvents NoText As TextBox
    Friend WithEvents UserNameText As TextBox
    Friend WithEvents PasswordText As TextBox
    Friend WithEvents cmb_role As ComboBox
    Friend WithEvents btn_find As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_add As Button
    Friend WithEvents btn_del As Button
End Class
