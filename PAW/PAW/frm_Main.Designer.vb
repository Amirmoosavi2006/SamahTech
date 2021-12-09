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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_main))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MainMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewWorkMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrackMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.FindEditMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalendarMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.MailMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArchiveMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsersMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStrip_Active_User = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel9 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStrip_Today_Name = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStrip_Date = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel10 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("B Kamran", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MainMenu, Me.SettingMenu})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(782, 40)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MainMenu
        '
        Me.MainMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewWorkMenu, Me.TrackMenu, Me.ReportMenu, Me.ToolStripSeparator1, Me.ExitMenu})
        Me.MainMenu.Name = "MainMenu"
        Me.MainMenu.Size = New System.Drawing.Size(101, 36)
        Me.MainMenu.Text = "منوی اصلی"
        '
        'NewWorkMenu
        '
        Me.NewWorkMenu.Image = Global.PAW.My.Resources.Resources.file
        Me.NewWorkMenu.Name = "NewWorkMenu"
        Me.NewWorkMenu.Size = New System.Drawing.Size(224, 36)
        Me.NewWorkMenu.Text = "کار جدید"
        '
        'TrackMenu
        '
        Me.TrackMenu.Image = Global.PAW.My.Resources.Resources.tag2
        Me.TrackMenu.Name = "TrackMenu"
        Me.TrackMenu.Size = New System.Drawing.Size(224, 36)
        Me.TrackMenu.Text = "ثبت پیگیری"
        '
        'ReportMenu
        '
        Me.ReportMenu.Image = Global.PAW.My.Resources.Resources.line_chart
        Me.ReportMenu.Name = "ReportMenu"
        Me.ReportMenu.Size = New System.Drawing.Size(224, 36)
        Me.ReportMenu.Text = "گزارشات"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(221, 6)
        '
        'ExitMenu
        '
        Me.ExitMenu.Image = Global.PAW.My.Resources.Resources.cross
        Me.ExitMenu.Name = "ExitMenu"
        Me.ExitMenu.Size = New System.Drawing.Size(224, 36)
        Me.ExitMenu.Text = "خروج"
        '
        'SettingMenu
        '
        Me.SettingMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FindEditMenu, Me.CalendarMenu, Me.MailMenu, Me.ArchiveMenu, Me.UsersMenu})
        Me.SettingMenu.Name = "SettingMenu"
        Me.SettingMenu.Size = New System.Drawing.Size(79, 36)
        Me.SettingMenu.Text = "امکانات"
        '
        'FindEditMenu
        '
        Me.FindEditMenu.Image = Global.PAW.My.Resources.Resources.magnifier
        Me.FindEditMenu.Name = "FindEditMenu"
        Me.FindEditMenu.Size = New System.Drawing.Size(201, 36)
        Me.FindEditMenu.Text = "جستجو/ ویرایش"
        '
        'CalendarMenu
        '
        Me.CalendarMenu.Image = Global.PAW.My.Resources.Resources.calendar2
        Me.CalendarMenu.Name = "CalendarMenu"
        Me.CalendarMenu.Size = New System.Drawing.Size(201, 36)
        Me.CalendarMenu.Text = "تقویم کاری"
        '
        'MailMenu
        '
        Me.MailMenu.Image = Global.PAW.My.Resources.Resources.email2
        Me.MailMenu.Name = "MailMenu"
        Me.MailMenu.Size = New System.Drawing.Size(201, 36)
        Me.MailMenu.Text = "پیام ها"
        '
        'ArchiveMenu
        '
        Me.ArchiveMenu.Image = Global.PAW.My.Resources.Resources.books2
        Me.ArchiveMenu.Name = "ArchiveMenu"
        Me.ArchiveMenu.Size = New System.Drawing.Size(201, 36)
        Me.ArchiveMenu.Text = "بایگانی"
        '
        'UsersMenu
        '
        Me.UsersMenu.Image = Global.PAW.My.Resources.Resources.user1
        Me.UsersMenu.Name = "UsersMenu"
        Me.UsersMenu.Size = New System.Drawing.Size(201, 36)
        Me.UsersMenu.Text = "کاربران"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Font = New System.Drawing.Font("B Kamran", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStrip_Active_User, Me.ToolStripStatusLabel9, Me.ToolStripStatusLabel3, Me.ToolStrip_Today_Name, Me.ToolStripStatusLabel5, Me.ToolStrip_Date, Me.ToolStripStatusLabel10})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 515)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(782, 38)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(83, 32)
        Me.ToolStripStatusLabel1.Text = "کاربر فعال:"
        '
        'ToolStrip_Active_User
        '
        Me.ToolStrip_Active_User.Name = "ToolStrip_Active_User"
        Me.ToolStrip_Active_User.Size = New System.Drawing.Size(110, 32)
        Me.ToolStrip_Active_User.Text = "سیدامیر موسوی"
        '
        'ToolStripStatusLabel9
        '
        Me.ToolStripStatusLabel9.Name = "ToolStripStatusLabel9"
        Me.ToolStripStatusLabel9.Size = New System.Drawing.Size(25, 32)
        Me.ToolStripStatusLabel9.Text = "-"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(47, 32)
        Me.ToolStripStatusLabel3.Text = "امروز"
        '
        'ToolStrip_Today_Name
        '
        Me.ToolStrip_Today_Name.Name = "ToolStrip_Today_Name"
        Me.ToolStrip_Today_Name.Size = New System.Drawing.Size(67, 32)
        Me.ToolStrip_Today_Name.Text = "چهارشنبه"
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(45, 32)
        Me.ToolStripStatusLabel5.Text = "مورخ"
        '
        'ToolStrip_Date
        '
        Me.ToolStrip_Date.Name = "ToolStrip_Date"
        Me.ToolStrip_Date.Size = New System.Drawing.Size(90, 32)
        Me.ToolStrip_Date.Text = "1400/03/04"
        '
        'ToolStripStatusLabel10
        '
        Me.ToolStripStatusLabel10.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ToolStripStatusLabel10.ForeColor = System.Drawing.Color.Silver
        Me.ToolStripStatusLabel10.Name = "ToolStripStatusLabel10"
        Me.ToolStripStatusLabel10.Size = New System.Drawing.Size(300, 32)
        Me.ToolStripStatusLabel10.Spring = True
        Me.ToolStripStatusLabel10.Text = "Poweredby: SamahTech.ir"
        Me.ToolStripStatusLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox4, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 40)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(153, 475)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'PictureBox4
        '
        Me.PictureBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox4.Image = Global.PAW.My.Resources.Resources.qlikView_1_min
        Me.PictureBox4.Location = New System.Drawing.Point(3, 357)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(147, 115)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 3
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox3.Image = Global.PAW.My.Resources.Resources.mitel
        Me.PictureBox3.Location = New System.Drawing.Point(3, 239)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(147, 112)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox2.Image = Global.PAW.My.Resources.Resources.My_Tehran_1_600x4501
        Me.PictureBox2.Location = New System.Drawing.Point(3, 121)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(147, 112)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.PAW.My.Resources.Resources._137_old_logo
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(147, 112)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.White
        Me.PictureBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox5.Image = Global.PAW.My.Resources.Resources._137New
        Me.PictureBox5.Location = New System.Drawing.Point(153, 40)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(629, 475)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox5.TabIndex = 3
        Me.PictureBox5.TabStop = False
        '
        'frm_main
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(782, 553)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("B Kamran", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "frm_main"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "برنامه ریزی کارهای اداری / صفحه اصلی"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MainMenu As ToolStripMenuItem
    Friend WithEvents NewWorkMenu As ToolStripMenuItem
    Friend WithEvents TrackMenu As ToolStripMenuItem
    Friend WithEvents ReportMenu As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ExitMenu As ToolStripMenuItem
    Friend WithEvents SettingMenu As ToolStripMenuItem
    Friend WithEvents FindEditMenu As ToolStripMenuItem
    Friend WithEvents CalendarMenu As ToolStripMenuItem
    Friend WithEvents MailMenu As ToolStripMenuItem
    Friend WithEvents ArchiveMenu As ToolStripMenuItem
    Friend WithEvents UsersMenu As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStrip_Active_User As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel9 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents ToolStrip_Today_Name As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As ToolStripStatusLabel
    Friend WithEvents ToolStrip_Date As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel10 As ToolStripStatusLabel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
End Class
