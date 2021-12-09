<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_main))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.cmb_new_work = New System.Windows.Forms.ToolStripButton()
        Me.cmb_find = New System.Windows.Forms.ToolStripButton()
        Me.cmb_edit = New System.Windows.Forms.ToolStripButton()
        Me.cmb_share = New System.Windows.Forms.ToolStripButton()
        Me.cmb_final_work = New System.Windows.Forms.ToolStripButton()
        Me.cmb_attach = New System.Windows.Forms.ToolStripButton()
        Me.cmb_archive = New System.Windows.Forms.ToolStripButton()
        Me.cmb_reminder = New System.Windows.Forms.ToolStripButton()
        Me.cmb_users = New System.Windows.Forms.ToolStripButton()
        Me.cmb_exit = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv_main_works = New System.Windows.Forms.DataGridView()
        Me.dgv_main_sms = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbl_user_name = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lbl_day_name = New System.Windows.Forms.Label()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.find_panel = New System.Windows.Forms.Panel()
        Me.dgv_find = New System.Windows.Forms.DataGridView()
        Me.txt_find_day2 = New System.Windows.Forms.TextBox()
        Me.txt_find_day1 = New System.Windows.Forms.TextBox()
        Me.txt_find_month2 = New System.Windows.Forms.TextBox()
        Me.txt_find_month1 = New System.Windows.Forms.TextBox()
        Me.txt_find_year2 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_find_year1 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_find_work_desc = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_find_work_title = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_find_work_id = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btn_find_ok = New System.Windows.Forms.Button()
        Me.btn_find_return = New System.Windows.Forms.Button()
        Me.new_work_panel = New System.Windows.Forms.Panel()
        Me.dgv_new_work = New System.Windows.Forms.DataGridView()
        Me.btn_new_work_return = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_new = New System.Windows.Forms.Button()
        Me.txt_new_work_desc = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_new_work_day = New System.Windows.Forms.TextBox()
        Me.txt_new_work_month = New System.Windows.Forms.TextBox()
        Me.txt_new_work_year = New System.Windows.Forms.TextBox()
        Me.txt_new_work_title = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgv_main_works, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_main_sms, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.find_panel.SuspendLayout()
        CType(Me.dgv_find, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.new_work_panel.SuspendLayout()
        CType(Me.dgv_new_work, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Right
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(64, 64)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmb_new_work, Me.cmb_find, Me.cmb_edit, Me.cmb_share, Me.cmb_final_work, Me.cmb_attach, Me.cmb_archive, Me.cmb_reminder, Me.cmb_users, Me.cmb_exit})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip1.Location = New System.Drawing.Point(791, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(69, 711)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'cmb_new_work
        '
        Me.cmb_new_work.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmb_new_work.Image = Global.My_notebook.My.Resources.Resources.plus
        Me.cmb_new_work.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmb_new_work.Name = "cmb_new_work"
        Me.cmb_new_work.Size = New System.Drawing.Size(66, 68)
        Me.cmb_new_work.Text = "کار جدید"
        Me.cmb_new_work.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmb_find
        '
        Me.cmb_find.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmb_find.Image = Global.My_notebook.My.Resources.Resources.pan
        Me.cmb_find.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmb_find.Name = "cmb_find"
        Me.cmb_find.Size = New System.Drawing.Size(66, 68)
        Me.cmb_find.Text = "جستجو"
        '
        'cmb_edit
        '
        Me.cmb_edit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmb_edit.Image = Global.My_notebook.My.Resources.Resources.edit
        Me.cmb_edit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmb_edit.Name = "cmb_edit"
        Me.cmb_edit.Size = New System.Drawing.Size(66, 68)
        Me.cmb_edit.Text = "ویرایش / ثبت پیگیری"
        '
        'cmb_share
        '
        Me.cmb_share.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmb_share.Image = Global.My_notebook.My.Resources.Resources.share2
        Me.cmb_share.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmb_share.Name = "cmb_share"
        Me.cmb_share.Size = New System.Drawing.Size(66, 68)
        Me.cmb_share.Text = "اشتراک گذاری"
        '
        'cmb_final_work
        '
        Me.cmb_final_work.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmb_final_work.Image = Global.My_notebook.My.Resources.Resources.clipboard1
        Me.cmb_final_work.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmb_final_work.Name = "cmb_final_work"
        Me.cmb_final_work.Size = New System.Drawing.Size(66, 68)
        Me.cmb_final_work.Text = "ثبت نهایی کار"
        '
        'cmb_attach
        '
        Me.cmb_attach.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmb_attach.Image = Global.My_notebook.My.Resources.Resources.paperclip
        Me.cmb_attach.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmb_attach.Name = "cmb_attach"
        Me.cmb_attach.Size = New System.Drawing.Size(66, 68)
        Me.cmb_attach.Text = "ضمیمه"
        '
        'cmb_archive
        '
        Me.cmb_archive.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmb_archive.Image = Global.My_notebook.My.Resources.Resources.archive
        Me.cmb_archive.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmb_archive.Name = "cmb_archive"
        Me.cmb_archive.Size = New System.Drawing.Size(66, 68)
        Me.cmb_archive.Text = "بایگانی"
        '
        'cmb_reminder
        '
        Me.cmb_reminder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmb_reminder.Image = Global.My_notebook.My.Resources.Resources.time3
        Me.cmb_reminder.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmb_reminder.Name = "cmb_reminder"
        Me.cmb_reminder.Size = New System.Drawing.Size(66, 68)
        Me.cmb_reminder.Text = "ثبت یادآوری"
        '
        'cmb_users
        '
        Me.cmb_users.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmb_users.Image = Global.My_notebook.My.Resources.Resources.user3
        Me.cmb_users.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmb_users.Name = "cmb_users"
        Me.cmb_users.Size = New System.Drawing.Size(66, 68)
        Me.cmb_users.Text = "تنظیمات کاربری"
        '
        'cmb_exit
        '
        Me.cmb_exit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmb_exit.Image = Global.My_notebook.My.Resources.Resources.cross1
        Me.cmb_exit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmb_exit.Name = "cmb_exit"
        Me.cmb_exit.Size = New System.Drawing.Size(66, 68)
        Me.cmb_exit.Text = "خروج"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Snow
        Me.Label1.Location = New System.Drawing.Point(665, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "لیست کارهای جاری"
        '
        'dgv_main_works
        '
        Me.dgv_main_works.AllowUserToAddRows = False
        Me.dgv_main_works.AllowUserToDeleteRows = False
        Me.dgv_main_works.AllowUserToResizeColumns = False
        Me.dgv_main_works.AllowUserToResizeRows = False
        Me.dgv_main_works.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_main_works.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_main_works.BackgroundColor = System.Drawing.Color.SeaGreen
        Me.dgv_main_works.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_main_works.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_main_works.Location = New System.Drawing.Point(5, 45)
        Me.dgv_main_works.Name = "dgv_main_works"
        Me.dgv_main_works.ReadOnly = True
        Me.dgv_main_works.RowHeadersVisible = False
        Me.dgv_main_works.Size = New System.Drawing.Size(783, 236)
        Me.dgv_main_works.TabIndex = 3
        '
        'dgv_main_sms
        '
        Me.dgv_main_sms.AllowUserToAddRows = False
        Me.dgv_main_sms.AllowUserToDeleteRows = False
        Me.dgv_main_sms.AllowUserToResizeColumns = False
        Me.dgv_main_sms.AllowUserToResizeRows = False
        Me.dgv_main_sms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_main_sms.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_main_sms.BackgroundColor = System.Drawing.Color.ForestGreen
        Me.dgv_main_sms.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_main_sms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_main_sms.Location = New System.Drawing.Point(5, 326)
        Me.dgv_main_sms.Name = "dgv_main_sms"
        Me.dgv_main_sms.ReadOnly = True
        Me.dgv_main_sms.RowHeadersVisible = False
        Me.dgv_main_sms.Size = New System.Drawing.Size(783, 236)
        Me.dgv_main_sms.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Snow
        Me.Label2.Location = New System.Drawing.Point(686, 294)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 29)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "پیام های ورودی"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Plum
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 568)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(791, 143)
        Me.Panel1.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.My_notebook.My.Resources.Resources.imac
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.lbl_user_name)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(255, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(268, 143)
        Me.Panel2.TabIndex = 16
        '
        'lbl_user_name
        '
        Me.lbl_user_name.AutoSize = True
        Me.lbl_user_name.BackColor = System.Drawing.Color.Transparent
        Me.lbl_user_name.Font = New System.Drawing.Font("B Lotus", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbl_user_name.ForeColor = System.Drawing.Color.Black
        Me.lbl_user_name.Location = New System.Drawing.Point(73, 45)
        Me.lbl_user_name.Name = "lbl_user_name"
        Me.lbl_user_name.Size = New System.Drawing.Size(125, 39)
        Me.lbl_user_name.TabIndex = 7
        Me.lbl_user_name.Text = "سیدامیر موسوی"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(148, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 29)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "کاربر فعال"
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = Global.My_notebook.My.Resources.Resources.calendar11
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Controls.Add(Me.lbl_day_name)
        Me.Panel3.Controls.Add(Me.lbl_date)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(523, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(268, 143)
        Me.Panel3.TabIndex = 15
        '
        'lbl_day_name
        '
        Me.lbl_day_name.AutoSize = True
        Me.lbl_day_name.BackColor = System.Drawing.Color.Transparent
        Me.lbl_day_name.ForeColor = System.Drawing.Color.Black
        Me.lbl_day_name.Location = New System.Drawing.Point(105, 35)
        Me.lbl_day_name.Name = "lbl_day_name"
        Me.lbl_day_name.Size = New System.Drawing.Size(60, 29)
        Me.lbl_day_name.TabIndex = 9
        Me.lbl_day_name.Text = "چهارشنبه"
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.BackColor = System.Drawing.Color.Transparent
        Me.lbl_date.Font = New System.Drawing.Font("B Lotus", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbl_date.ForeColor = System.Drawing.Color.Black
        Me.lbl_date.Location = New System.Drawing.Point(80, 63)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(109, 39)
        Me.lbl_date.TabIndex = 8
        Me.lbl_date.Text = "1400/01/12"
        '
        'Panel4
        '
        Me.Panel4.BackgroundImage = Global.My_notebook.My.Resources.Resources.book31
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(255, 143)
        Me.Panel4.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("B Lotus", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(70, 60)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 29)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "دفترچه یادداشت من"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.LightGray
        Me.Label7.Location = New System.Drawing.Point(45, 117)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(165, 19)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Powered by: SamahTech"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Gold
        Me.Panel5.Location = New System.Drawing.Point(-9, 288)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(805, 2)
        Me.Panel5.TabIndex = 7
        '
        'find_panel
        '
        Me.find_panel.Controls.Add(Me.dgv_find)
        Me.find_panel.Controls.Add(Me.txt_find_day2)
        Me.find_panel.Controls.Add(Me.txt_find_day1)
        Me.find_panel.Controls.Add(Me.txt_find_month2)
        Me.find_panel.Controls.Add(Me.txt_find_month1)
        Me.find_panel.Controls.Add(Me.txt_find_year2)
        Me.find_panel.Controls.Add(Me.Label13)
        Me.find_panel.Controls.Add(Me.txt_find_year1)
        Me.find_panel.Controls.Add(Me.Label12)
        Me.find_panel.Controls.Add(Me.txt_find_work_desc)
        Me.find_panel.Controls.Add(Me.Label11)
        Me.find_panel.Controls.Add(Me.txt_find_work_title)
        Me.find_panel.Controls.Add(Me.Label10)
        Me.find_panel.Controls.Add(Me.txt_find_work_id)
        Me.find_panel.Controls.Add(Me.Label9)
        Me.find_panel.Controls.Add(Me.btn_find_ok)
        Me.find_panel.Controls.Add(Me.btn_find_return)
        Me.find_panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.find_panel.Location = New System.Drawing.Point(0, 0)
        Me.find_panel.Name = "find_panel"
        Me.find_panel.Size = New System.Drawing.Size(860, 711)
        Me.find_panel.TabIndex = 8
        Me.find_panel.Visible = False
        '
        'dgv_find
        '
        Me.dgv_find.AllowUserToAddRows = False
        Me.dgv_find.AllowUserToDeleteRows = False
        Me.dgv_find.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_find.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_find.BackgroundColor = System.Drawing.Color.DarkCyan
        Me.dgv_find.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_find.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_find.Location = New System.Drawing.Point(3, 165)
        Me.dgv_find.Name = "dgv_find"
        Me.dgv_find.RowHeadersVisible = False
        Me.dgv_find.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_find.ShowCellErrors = False
        Me.dgv_find.ShowEditingIcon = False
        Me.dgv_find.ShowRowErrors = False
        Me.dgv_find.Size = New System.Drawing.Size(785, 327)
        Me.dgv_find.TabIndex = 3
        '
        'txt_find_day2
        '
        Me.txt_find_day2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.txt_find_day2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_find_day2.Location = New System.Drawing.Point(485, 25)
        Me.txt_find_day2.MaxLength = 2
        Me.txt_find_day2.Name = "txt_find_day2"
        Me.txt_find_day2.Size = New System.Drawing.Size(29, 29)
        Me.txt_find_day2.TabIndex = 2
        Me.txt_find_day2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_find_day1
        '
        Me.txt_find_day1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.txt_find_day1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_find_day1.Location = New System.Drawing.Point(676, 25)
        Me.txt_find_day1.MaxLength = 2
        Me.txt_find_day1.Name = "txt_find_day1"
        Me.txt_find_day1.Size = New System.Drawing.Size(29, 29)
        Me.txt_find_day1.TabIndex = 2
        Me.txt_find_day1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_find_month2
        '
        Me.txt_find_month2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.txt_find_month2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_find_month2.Location = New System.Drawing.Point(450, 25)
        Me.txt_find_month2.MaxLength = 2
        Me.txt_find_month2.Name = "txt_find_month2"
        Me.txt_find_month2.Size = New System.Drawing.Size(29, 29)
        Me.txt_find_month2.TabIndex = 2
        Me.txt_find_month2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_find_month1
        '
        Me.txt_find_month1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.txt_find_month1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_find_month1.Location = New System.Drawing.Point(641, 25)
        Me.txt_find_month1.MaxLength = 2
        Me.txt_find_month1.Name = "txt_find_month1"
        Me.txt_find_month1.Size = New System.Drawing.Size(29, 29)
        Me.txt_find_month1.TabIndex = 2
        Me.txt_find_month1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_find_year2
        '
        Me.txt_find_year2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.txt_find_year2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_find_year2.Location = New System.Drawing.Point(386, 25)
        Me.txt_find_year2.MaxLength = 4
        Me.txt_find_year2.Name = "txt_find_year2"
        Me.txt_find_year2.Size = New System.Drawing.Size(58, 29)
        Me.txt_find_year2.TabIndex = 2
        Me.txt_find_year2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(517, 25)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(53, 29)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "تا تاریخ"
        '
        'txt_find_year1
        '
        Me.txt_find_year1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.txt_find_year1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_find_year1.Location = New System.Drawing.Point(577, 25)
        Me.txt_find_year1.MaxLength = 4
        Me.txt_find_year1.Name = "txt_find_year1"
        Me.txt_find_year1.Size = New System.Drawing.Size(58, 29)
        Me.txt_find_year1.TabIndex = 2
        Me.txt_find_year1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(708, 25)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(54, 29)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "از تاریخ"
        '
        'txt_find_work_desc
        '
        Me.txt_find_work_desc.BackColor = System.Drawing.Color.LightSkyBlue
        Me.txt_find_work_desc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_find_work_desc.Location = New System.Drawing.Point(386, 130)
        Me.txt_find_work_desc.Name = "txt_find_work_desc"
        Me.txt_find_work_desc.Size = New System.Drawing.Size(319, 29)
        Me.txt_find_work_desc.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(708, 130)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 29)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "شرح کار"
        '
        'txt_find_work_title
        '
        Me.txt_find_work_title.BackColor = System.Drawing.Color.LightSkyBlue
        Me.txt_find_work_title.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_find_work_title.Location = New System.Drawing.Point(386, 95)
        Me.txt_find_work_title.Name = "txt_find_work_title"
        Me.txt_find_work_title.Size = New System.Drawing.Size(319, 29)
        Me.txt_find_work_title.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(708, 95)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 29)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "عنوان کار"
        '
        'txt_find_work_id
        '
        Me.txt_find_work_id.BackColor = System.Drawing.Color.LightSkyBlue
        Me.txt_find_work_id.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_find_work_id.Location = New System.Drawing.Point(386, 60)
        Me.txt_find_work_id.Name = "txt_find_work_id"
        Me.txt_find_work_id.Size = New System.Drawing.Size(319, 29)
        Me.txt_find_work_id.TabIndex = 2
        Me.txt_find_work_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(708, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 29)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "شماره کار"
        '
        'btn_find_ok
        '
        Me.btn_find_ok.BackgroundImage = Global.My_notebook.My.Resources.Resources.pan
        Me.btn_find_ok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_find_ok.FlatAppearance.BorderSize = 0
        Me.btn_find_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_find_ok.Location = New System.Drawing.Point(316, 95)
        Me.btn_find_ok.Name = "btn_find_ok"
        Me.btn_find_ok.Size = New System.Drawing.Size(64, 64)
        Me.btn_find_ok.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.btn_find_ok, "جستجوی کار")
        Me.btn_find_ok.UseVisualStyleBackColor = True
        '
        'btn_find_return
        '
        Me.btn_find_return.BackgroundImage = Global.My_notebook.My.Resources.Resources.home2
        Me.btn_find_return.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_find_return.FlatAppearance.BorderSize = 0
        Me.btn_find_return.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_find_return.Location = New System.Drawing.Point(12, 498)
        Me.btn_find_return.Name = "btn_find_return"
        Me.btn_find_return.Size = New System.Drawing.Size(64, 64)
        Me.btn_find_return.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.btn_find_return, "بازگشت به صفحه اصلی")
        Me.btn_find_return.UseVisualStyleBackColor = True
        '
        'new_work_panel
        '
        Me.new_work_panel.BackColor = System.Drawing.Color.LightGreen
        Me.new_work_panel.Controls.Add(Me.dgv_new_work)
        Me.new_work_panel.Controls.Add(Me.btn_new_work_return)
        Me.new_work_panel.Controls.Add(Me.btn_save)
        Me.new_work_panel.Controls.Add(Me.btn_new)
        Me.new_work_panel.Controls.Add(Me.txt_new_work_desc)
        Me.new_work_panel.Controls.Add(Me.Label5)
        Me.new_work_panel.Controls.Add(Me.txt_new_work_day)
        Me.new_work_panel.Controls.Add(Me.txt_new_work_month)
        Me.new_work_panel.Controls.Add(Me.txt_new_work_year)
        Me.new_work_panel.Controls.Add(Me.txt_new_work_title)
        Me.new_work_panel.Controls.Add(Me.Label6)
        Me.new_work_panel.Controls.Add(Me.Label4)
        Me.new_work_panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.new_work_panel.Location = New System.Drawing.Point(0, 0)
        Me.new_work_panel.Name = "new_work_panel"
        Me.new_work_panel.Size = New System.Drawing.Size(860, 711)
        Me.new_work_panel.TabIndex = 9
        Me.new_work_panel.Visible = False
        '
        'dgv_new_work
        '
        Me.dgv_new_work.AllowUserToAddRows = False
        Me.dgv_new_work.AllowUserToDeleteRows = False
        Me.dgv_new_work.AllowUserToResizeColumns = False
        Me.dgv_new_work.AllowUserToResizeRows = False
        Me.dgv_new_work.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_new_work.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_new_work.BackgroundColor = System.Drawing.Color.PaleTurquoise
        Me.dgv_new_work.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_new_work.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_new_work.Location = New System.Drawing.Point(5, 351)
        Me.dgv_new_work.Name = "dgv_new_work"
        Me.dgv_new_work.Size = New System.Drawing.Size(783, 141)
        Me.dgv_new_work.TabIndex = 3
        '
        'btn_new_work_return
        '
        Me.btn_new_work_return.FlatAppearance.BorderSize = 0
        Me.btn_new_work_return.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_new_work_return.Image = Global.My_notebook.My.Resources.Resources.home21
        Me.btn_new_work_return.Location = New System.Drawing.Point(12, 498)
        Me.btn_new_work_return.Name = "btn_new_work_return"
        Me.btn_new_work_return.Size = New System.Drawing.Size(64, 64)
        Me.btn_new_work_return.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.btn_new_work_return, "بازگشت به صفحه اصلی")
        Me.btn_new_work_return.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.FlatAppearance.BorderSize = 0
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save.Image = Global.My_notebook.My.Resources.Resources.check1
        Me.btn_save.Location = New System.Drawing.Point(290, 281)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(64, 64)
        Me.btn_save.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.btn_save, "ذخیره کار جدید")
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_new
        '
        Me.btn_new.FlatAppearance.BorderSize = 0
        Me.btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_new.Image = Global.My_notebook.My.Resources.Resources.plus
        Me.btn_new.Location = New System.Drawing.Point(360, 281)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(64, 64)
        Me.btn_new.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.btn_new, "پاکسازی فرم " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ایجاد کار جدید")
        Me.btn_new.UseVisualStyleBackColor = True
        '
        'txt_new_work_desc
        '
        Me.txt_new_work_desc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_new_work_desc.Location = New System.Drawing.Point(430, 95)
        Me.txt_new_work_desc.Multiline = True
        Me.txt_new_work_desc.Name = "txt_new_work_desc"
        Me.txt_new_work_desc.Size = New System.Drawing.Size(250, 250)
        Me.txt_new_work_desc.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(686, 95)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 29)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "شرح کار"
        '
        'txt_new_work_day
        '
        Me.txt_new_work_day.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_new_work_day.Location = New System.Drawing.Point(651, 24)
        Me.txt_new_work_day.MaxLength = 2
        Me.txt_new_work_day.Name = "txt_new_work_day"
        Me.txt_new_work_day.Size = New System.Drawing.Size(29, 29)
        Me.txt_new_work_day.TabIndex = 1
        '
        'txt_new_work_month
        '
        Me.txt_new_work_month.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_new_work_month.Location = New System.Drawing.Point(616, 24)
        Me.txt_new_work_month.MaxLength = 2
        Me.txt_new_work_month.Name = "txt_new_work_month"
        Me.txt_new_work_month.Size = New System.Drawing.Size(29, 29)
        Me.txt_new_work_month.TabIndex = 1
        '
        'txt_new_work_year
        '
        Me.txt_new_work_year.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_new_work_year.Location = New System.Drawing.Point(552, 24)
        Me.txt_new_work_year.MaxLength = 4
        Me.txt_new_work_year.Name = "txt_new_work_year"
        Me.txt_new_work_year.Size = New System.Drawing.Size(58, 29)
        Me.txt_new_work_year.TabIndex = 1
        '
        'txt_new_work_title
        '
        Me.txt_new_work_title.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_new_work_title.Location = New System.Drawing.Point(430, 60)
        Me.txt_new_work_title.Name = "txt_new_work_title"
        Me.txt_new_work_title.Size = New System.Drawing.Size(250, 29)
        Me.txt_new_work_title.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(686, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 29)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "تاریخ ثبت کار"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(686, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 29)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "عنوان کار"
        '
        'ToolTip1
        '
        Me.ToolTip1.BackColor = System.Drawing.Color.Black
        Me.ToolTip1.ForeColor = System.Drawing.Color.White
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ToolTipTitle = "دفترچه یادداشت من"
        '
        'frm_main
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(860, 711)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.find_panel)
        Me.Controls.Add(Me.new_work_panel)
        Me.Controls.Add(Me.dgv_main_sms)
        Me.Controls.Add(Me.dgv_main_works)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("B Lotus", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_main"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "دفترچه یادداشت من / صفحه اصلی"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgv_main_works, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_main_sms, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.find_panel.ResumeLayout(False)
        Me.find_panel.PerformLayout()
        CType(Me.dgv_find, System.ComponentModel.ISupportInitialize).EndInit()
        Me.new_work_panel.ResumeLayout(False)
        Me.new_work_panel.PerformLayout()
        CType(Me.dgv_new_work, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents cmb_new_work As ToolStripButton
    Friend WithEvents cmb_find As ToolStripButton
    Friend WithEvents cmb_edit As ToolStripButton
    Friend WithEvents cmb_share As ToolStripButton
    Friend WithEvents cmb_final_work As ToolStripButton
    Friend WithEvents cmb_attach As ToolStripButton
    Friend WithEvents cmb_archive As ToolStripButton
    Friend WithEvents cmb_reminder As ToolStripButton
    Friend WithEvents cmb_users As ToolStripButton
    Friend WithEvents cmb_exit As ToolStripButton
    Friend WithEvents Label1 As Label
    Friend WithEvents dgv_main_works As DataGridView
    Friend WithEvents dgv_main_sms As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lbl_user_name As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lbl_day_name As Label
    Friend WithEvents lbl_date As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents find_panel As Panel
    Friend WithEvents btn_find_return As Button
    Friend WithEvents txt_find_day2 As TextBox
    Friend WithEvents txt_find_day1 As TextBox
    Friend WithEvents txt_find_month2 As TextBox
    Friend WithEvents txt_find_month1 As TextBox
    Friend WithEvents txt_find_year2 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txt_find_year1 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txt_find_work_desc As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_find_work_title As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_find_work_id As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btn_find_ok As Button
    Friend WithEvents dgv_find As DataGridView
    Friend WithEvents new_work_panel As Panel
    Friend WithEvents dgv_new_work As DataGridView
    Friend WithEvents btn_new_work_return As Button
    Friend WithEvents btn_new As Button
    Friend WithEvents txt_new_work_desc As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_new_work_day As TextBox
    Friend WithEvents txt_new_work_month As TextBox
    Friend WithEvents txt_new_work_year As TextBox
    Friend WithEvents txt_new_work_title As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_save As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
