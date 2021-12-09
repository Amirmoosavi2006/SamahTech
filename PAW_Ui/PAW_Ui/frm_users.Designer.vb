<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_users
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_del_all = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_refresh = New System.Windows.Forms.Button()
        Me.btn_home = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbtn_3 = New System.Windows.Forms.RadioButton()
        Me.rbtn_2 = New System.Windows.Forms.RadioButton()
        Me.rbtn_1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_inphone = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_phone = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_mobile = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_semat = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_lname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_fname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.pic_def = New System.Windows.Forms.PictureBox()
        Me.btn_attach_del = New System.Windows.Forms.Button()
        Me.btn_attach = New System.Windows.Forms.Button()
        Me.pic_user = New System.Windows.Forms.PictureBox()
        Me.dgv_users = New System.Windows.Forms.DataGridView()
        Me.col_work_title = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_track = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_work_create_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_desc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_attach = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.pic_def, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_user, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_users, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btn_edit)
        Me.Panel1.Controls.Add(Me.btn_del_all)
        Me.Panel1.Controls.Add(Me.btn_save)
        Me.Panel1.Controls.Add(Me.btn_refresh)
        Me.Panel1.Controls.Add(Me.btn_home)
        Me.Panel1.Location = New System.Drawing.Point(12, 592)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(421, 100)
        Me.Panel1.TabIndex = 139
        '
        'btn_edit
        '
        Me.btn_edit.Image = Global.PAW_Ui.My.Resources.Resources.save_as_64px
        Me.btn_edit.Location = New System.Drawing.Point(252, 13)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(72, 72)
        Me.btn_edit.TabIndex = 147
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'btn_del_all
        '
        Me.btn_del_all.Image = Global.PAW_Ui.My.Resources.Resources.trash_can_64px
        Me.btn_del_all.Location = New System.Drawing.Point(174, 13)
        Me.btn_del_all.Name = "btn_del_all"
        Me.btn_del_all.Size = New System.Drawing.Size(72, 72)
        Me.btn_del_all.TabIndex = 146
        Me.btn_del_all.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Image = Global.PAW_Ui.My.Resources.Resources.save_64px
        Me.btn_save.Location = New System.Drawing.Point(330, 13)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(72, 72)
        Me.btn_save.TabIndex = 14
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_refresh
        '
        Me.btn_refresh.Image = Global.PAW_Ui.My.Resources.Resources.repeat_64px
        Me.btn_refresh.Location = New System.Drawing.Point(96, 13)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(72, 72)
        Me.btn_refresh.TabIndex = 144
        Me.btn_refresh.UseVisualStyleBackColor = True
        '
        'btn_home
        '
        Me.btn_home.Image = Global.PAW_Ui.My.Resources.Resources.home_64px
        Me.btn_home.Location = New System.Drawing.Point(18, 13)
        Me.btn_home.Name = "btn_home"
        Me.btn_home.Size = New System.Drawing.Size(72, 72)
        Me.btn_home.TabIndex = 143
        Me.btn_home.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbtn_3)
        Me.GroupBox1.Controls.Add(Me.rbtn_2)
        Me.GroupBox1.Controls.Add(Me.rbtn_1)
        Me.GroupBox1.Location = New System.Drawing.Point(454, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(170, 169)
        Me.GroupBox1.TabIndex = 148
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "سطح دسترسی"
        '
        'rbtn_3
        '
        Me.rbtn_3.AutoSize = True
        Me.rbtn_3.Location = New System.Drawing.Point(33, 115)
        Me.rbtn_3.Name = "rbtn_3"
        Me.rbtn_3.Size = New System.Drawing.Size(104, 32)
        Me.rbtn_3.TabIndex = 9
        Me.rbtn_3.TabStop = True
        Me.rbtn_3.Text = "کارشناس آمار"
        Me.rbtn_3.UseVisualStyleBackColor = True
        '
        'rbtn_2
        '
        Me.rbtn_2.AutoSize = True
        Me.rbtn_2.Location = New System.Drawing.Point(35, 77)
        Me.rbtn_2.Name = "rbtn_2"
        Me.rbtn_2.Size = New System.Drawing.Size(102, 32)
        Me.rbtn_2.TabIndex = 8
        Me.rbtn_2.TabStop = True
        Me.rbtn_2.Text = "کارشناس فنی"
        Me.rbtn_2.UseVisualStyleBackColor = True
        '
        'rbtn_1
        '
        Me.rbtn_1.AutoSize = True
        Me.rbtn_1.Location = New System.Drawing.Point(82, 39)
        Me.rbtn_1.Name = "rbtn_1"
        Me.rbtn_1.Size = New System.Drawing.Size(55, 32)
        Me.rbtn_1.TabIndex = 7
        Me.rbtn_1.TabStop = True
        Me.rbtn_1.Text = "مدیر"
        Me.rbtn_1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_password)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txt_username)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Location = New System.Drawing.Point(132, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(316, 169)
        Me.GroupBox2.TabIndex = 149
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "اطلاعات کاربری"
        '
        'txt_password
        '
        Me.txt_password.BackColor = System.Drawing.Color.LightBlue
        Me.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_password.Font = New System.Drawing.Font("B Koodak", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txt_password.Location = New System.Drawing.Point(26, 93)
        Me.txt_password.MaxLength = 100
        Me.txt_password.Name = "txt_password"
        Me.txt_password.Size = New System.Drawing.Size(203, 35)
        Me.txt_password.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("B Koodak", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label7.Location = New System.Drawing.Point(235, 97)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 28)
        Me.Label7.TabIndex = 152
        Me.Label7.Text = "کلمه عبور"
        '
        'txt_username
        '
        Me.txt_username.BackColor = System.Drawing.Color.LightBlue
        Me.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_username.Font = New System.Drawing.Font("B Koodak", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txt_username.Location = New System.Drawing.Point(26, 52)
        Me.txt_username.MaxLength = 100
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(203, 35)
        Me.txt_username.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("B Koodak", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label8.Location = New System.Drawing.Point(235, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 28)
        Me.Label8.TabIndex = 153
        Me.Label8.Text = "نام کاربری"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("B Koodak", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(11, 98)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(18, 24)
        Me.Label12.TabIndex = 203
        Me.Label12.Text = "*"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("B Koodak", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(11, 59)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(18, 24)
        Me.Label13.TabIndex = 204
        Me.Label13.Text = "*"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txt_email)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.txt_inphone)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.txt_phone)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txt_mobile)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.txt_semat)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txt_lname)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.txt_fname)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Location = New System.Drawing.Point(630, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(348, 334)
        Me.GroupBox3.TabIndex = 150
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "مشخصات فردی"
        '
        'txt_email
        '
        Me.txt_email.BackColor = System.Drawing.Color.LightBlue
        Me.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_email.Font = New System.Drawing.Font("B Koodak", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txt_email.Location = New System.Drawing.Point(20, 280)
        Me.txt_email.MaxLength = 100
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(216, 35)
        Me.txt_email.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("B Koodak", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label9.Location = New System.Drawing.Point(242, 284)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(99, 28)
        Me.Label9.TabIndex = 160
        Me.Label9.Text = "پست الکترونیکی"
        '
        'txt_inphone
        '
        Me.txt_inphone.BackColor = System.Drawing.Color.LightBlue
        Me.txt_inphone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_inphone.Font = New System.Drawing.Font("B Koodak", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txt_inphone.Location = New System.Drawing.Point(20, 239)
        Me.txt_inphone.MaxLength = 5
        Me.txt_inphone.Name = "txt_inphone"
        Me.txt_inphone.Size = New System.Drawing.Size(216, 35)
        Me.txt_inphone.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("B Koodak", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label6.Location = New System.Drawing.Point(242, 243)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 28)
        Me.Label6.TabIndex = 148
        Me.Label6.Text = "تلفن داخلی"
        '
        'txt_phone
        '
        Me.txt_phone.BackColor = System.Drawing.Color.LightBlue
        Me.txt_phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_phone.Font = New System.Drawing.Font("B Koodak", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txt_phone.Location = New System.Drawing.Point(20, 198)
        Me.txt_phone.MaxLength = 11
        Me.txt_phone.Name = "txt_phone"
        Me.txt_phone.Size = New System.Drawing.Size(216, 35)
        Me.txt_phone.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("B Koodak", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label5.Location = New System.Drawing.Point(242, 202)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 28)
        Me.Label5.TabIndex = 149
        Me.Label5.Text = "تلفن ثابت"
        '
        'txt_mobile
        '
        Me.txt_mobile.BackColor = System.Drawing.Color.LightBlue
        Me.txt_mobile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_mobile.Font = New System.Drawing.Font("B Koodak", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txt_mobile.Location = New System.Drawing.Point(20, 157)
        Me.txt_mobile.MaxLength = 11
        Me.txt_mobile.Name = "txt_mobile"
        Me.txt_mobile.Size = New System.Drawing.Size(216, 35)
        Me.txt_mobile.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("B Koodak", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label4.Location = New System.Drawing.Point(242, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 28)
        Me.Label4.TabIndex = 150
        Me.Label4.Text = "شماره همراه"
        '
        'txt_semat
        '
        Me.txt_semat.BackColor = System.Drawing.Color.LightBlue
        Me.txt_semat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_semat.Font = New System.Drawing.Font("B Koodak", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txt_semat.Location = New System.Drawing.Point(20, 116)
        Me.txt_semat.MaxLength = 100
        Me.txt_semat.Name = "txt_semat"
        Me.txt_semat.Size = New System.Drawing.Size(216, 35)
        Me.txt_semat.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("B Koodak", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.Location = New System.Drawing.Point(242, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 28)
        Me.Label3.TabIndex = 151
        Me.Label3.Text = "سمت"
        '
        'txt_lname
        '
        Me.txt_lname.BackColor = System.Drawing.Color.LightBlue
        Me.txt_lname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_lname.Font = New System.Drawing.Font("B Koodak", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txt_lname.Location = New System.Drawing.Point(20, 75)
        Me.txt_lname.MaxLength = 50
        Me.txt_lname.Name = "txt_lname"
        Me.txt_lname.Size = New System.Drawing.Size(216, 35)
        Me.txt_lname.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("B Koodak", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.Location = New System.Drawing.Point(242, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 28)
        Me.Label1.TabIndex = 152
        Me.Label1.Text = "نام خانوادگی"
        '
        'txt_fname
        '
        Me.txt_fname.BackColor = System.Drawing.Color.LightBlue
        Me.txt_fname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_fname.Font = New System.Drawing.Font("B Koodak", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txt_fname.Location = New System.Drawing.Point(20, 34)
        Me.txt_fname.MaxLength = 50
        Me.txt_fname.Name = "txt_fname"
        Me.txt_fname.Size = New System.Drawing.Size(216, 35)
        Me.txt_fname.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("B Koodak", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.Location = New System.Drawing.Point(242, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 28)
        Me.Label2.TabIndex = 153
        Me.Label2.Text = "نام"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("B Koodak", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(5, 80)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(18, 24)
        Me.Label11.TabIndex = 202
        Me.Label11.Text = "*"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("B Koodak", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(5, 41)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(18, 24)
        Me.Label10.TabIndex = 202
        Me.Label10.Text = "*"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.pic_def)
        Me.GroupBox4.Controls.Add(Me.btn_attach_del)
        Me.GroupBox4.Controls.Add(Me.btn_attach)
        Me.GroupBox4.Controls.Add(Me.pic_user)
        Me.GroupBox4.Location = New System.Drawing.Point(630, 352)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(348, 297)
        Me.GroupBox4.TabIndex = 151
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "عکس پرسنلی"
        '
        'pic_def
        '
        Me.pic_def.Image = Global.PAW_Ui.My.Resources.Resources.office_address_book_icon1
        Me.pic_def.Location = New System.Drawing.Point(54, 35)
        Me.pic_def.Name = "pic_def"
        Me.pic_def.Size = New System.Drawing.Size(240, 185)
        Me.pic_def.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_def.TabIndex = 154
        Me.pic_def.TabStop = False
        Me.pic_def.Visible = False
        '
        'btn_attach_del
        '
        Me.btn_attach_del.Image = Global.PAW_Ui.My.Resources.Resources.delete_30px
        Me.btn_attach_del.Location = New System.Drawing.Point(129, 237)
        Me.btn_attach_del.Name = "btn_attach_del"
        Me.btn_attach_del.Size = New System.Drawing.Size(42, 42)
        Me.btn_attach_del.TabIndex = 13
        Me.btn_attach_del.UseVisualStyleBackColor = True
        '
        'btn_attach
        '
        Me.btn_attach.Image = Global.PAW_Ui.My.Resources.Resources.attach_30px
        Me.btn_attach.Location = New System.Drawing.Point(177, 237)
        Me.btn_attach.Name = "btn_attach"
        Me.btn_attach.Size = New System.Drawing.Size(42, 42)
        Me.btn_attach.TabIndex = 12
        Me.btn_attach.UseVisualStyleBackColor = True
        '
        'pic_user
        '
        Me.pic_user.Image = Global.PAW_Ui.My.Resources.Resources.office_address_book_icon1
        Me.pic_user.Location = New System.Drawing.Point(54, 35)
        Me.pic_user.Name = "pic_user"
        Me.pic_user.Size = New System.Drawing.Size(240, 185)
        Me.pic_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_user.TabIndex = 153
        Me.pic_user.TabStop = False
        '
        'dgv_users
        '
        Me.dgv_users.AllowUserToAddRows = False
        Me.dgv_users.AllowUserToDeleteRows = False
        Me.dgv_users.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_users.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_users.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgv_users.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_users.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgv_users.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("B Koodak", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.NullValue = "-"
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_users.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_users.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_work_title, Me.col_track, Me.col_work_create_date, Me.col_desc, Me.col_attach})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.MintCream
        DataGridViewCellStyle2.Font = New System.Drawing.Font("B Koodak", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.NullValue = "=str(""-"")"
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.MistyRose
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_users.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_users.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgv_users.EnableHeadersVisualStyles = False
        Me.dgv_users.GridColor = System.Drawing.Color.Black
        Me.dgv_users.Location = New System.Drawing.Point(12, 187)
        Me.dgv_users.MultiSelect = False
        Me.dgv_users.Name = "dgv_users"
        Me.dgv_users.RowHeadersVisible = False
        Me.dgv_users.RowHeadersWidth = 51
        Me.dgv_users.RowTemplate.Height = 24
        Me.dgv_users.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_users.ShowCellErrors = False
        Me.dgv_users.ShowEditingIcon = False
        Me.dgv_users.ShowRowErrors = False
        Me.dgv_users.Size = New System.Drawing.Size(612, 399)
        Me.dgv_users.TabIndex = 201
        Me.dgv_users.TabStop = False
        '
        'col_work_title
        '
        Me.col_work_title.FillWeight = 20.0!
        Me.col_work_title.HeaderText = "نام"
        Me.col_work_title.MinimumWidth = 6
        Me.col_work_title.Name = "col_work_title"
        '
        'col_track
        '
        Me.col_track.FillWeight = 20.0!
        Me.col_track.HeaderText = "نام خانوادگی"
        Me.col_track.MinimumWidth = 6
        Me.col_track.Name = "col_track"
        '
        'col_work_create_date
        '
        Me.col_work_create_date.FillWeight = 20.0!
        Me.col_work_create_date.HeaderText = "سمت"
        Me.col_work_create_date.MinimumWidth = 6
        Me.col_work_create_date.Name = "col_work_create_date"
        '
        'col_desc
        '
        Me.col_desc.FillWeight = 20.0!
        Me.col_desc.HeaderText = "دسترسی"
        Me.col_desc.MinimumWidth = 6
        Me.col_desc.Name = "col_desc"
        '
        'col_attach
        '
        Me.col_attach.FillWeight = 20.0!
        Me.col_attach.HeaderText = "نام کاربری"
        Me.col_attach.MinimumWidth = 6
        Me.col_attach.Name = "col_attach"
        '
        'frm_users
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(990, 704)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgv_users)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("B Koodak", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_users"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.pic_def, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_user, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_users, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_save As Button
    Friend WithEvents btn_refresh As Button
    Friend WithEvents btn_home As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbtn_3 As RadioButton
    Friend WithEvents rbtn_2 As RadioButton
    Friend WithEvents rbtn_1 As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txt_password As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_username As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txt_email As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_inphone As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_phone As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_mobile As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_semat As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_lname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_fname As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_del_all As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents pic_user As PictureBox
    Friend WithEvents btn_attach_del As Button
    Friend WithEvents btn_attach As Button
    Friend WithEvents dgv_users As DataGridView
    Friend WithEvents col_work_title As DataGridViewTextBoxColumn
    Friend WithEvents col_track As DataGridViewTextBoxColumn
    Friend WithEvents col_work_create_date As DataGridViewTextBoxColumn
    Friend WithEvents col_desc As DataGridViewTextBoxColumn
    Friend WithEvents col_attach As DataGridViewTextBoxColumn
    Friend WithEvents pic_def As PictureBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
End Class
