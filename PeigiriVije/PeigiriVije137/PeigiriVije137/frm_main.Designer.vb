<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_main
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_main))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.M_main = New System.Windows.Forms.ToolStripMenuItem()
        Me.M_before = New System.Windows.Forms.ToolStripMenuItem()
        Me.M_after = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.M_exit = New System.Windows.Forms.ToolStripMenuItem()
        Me.M_Reports = New System.Windows.Forms.ToolStripMenuItem()
        Me.M_visit_report = New System.Windows.Forms.ToolStripMenuItem()
        Me.M_visit_daily = New System.Windows.Forms.ToolStripMenuItem()
        Me.M_visit_all = New System.Windows.Forms.ToolStripMenuItem()
        Me.M_Seting = New System.Windows.Forms.ToolStripMenuItem()
        Me.M_Users = New System.Windows.Forms.ToolStripMenuItem()
        Me.M_PassChange = New System.Windows.Forms.ToolStripMenuItem()
        Me.M_Mails = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ts_username = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ts_date = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ts_Role = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("B Nazanin", 14.0!, System.Drawing.FontStyle.Bold)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.M_main, Me.M_Reports, Me.M_Seting})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.MdiWindowListItem = Me.M_main
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(984, 38)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "File"
        '
        'M_main
        '
        Me.M_main.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.M_before, Me.M_after, Me.ToolStripSeparator1, Me.M_exit})
        Me.M_main.Name = "M_main"
        Me.M_main.Size = New System.Drawing.Size(100, 34)
        Me.M_main.Text = "منوی اصلی"
        '
        'M_before
        '
        Me.M_before.Image = Global.PeigiriVije137.My.Resources.Resources.Small_Note
        Me.M_before.Name = "M_before"
        Me.M_before.Size = New System.Drawing.Size(197, 34)
        Me.M_before.Text = "فرم قبل از بازدید"
        '
        'M_after
        '
        Me.M_after.Image = Global.PeigiriVije137.My.Resources.Resources.bill_of_document
        Me.M_after.Name = "M_after"
        Me.M_after.Size = New System.Drawing.Size(197, 34)
        Me.M_after.Text = "فرم بعد از بازدید"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(194, 6)
        '
        'M_exit
        '
        Me.M_exit.Image = Global.PeigiriVije137.My.Resources.Resources.Small_Exit
        Me.M_exit.Name = "M_exit"
        Me.M_exit.Size = New System.Drawing.Size(197, 34)
        Me.M_exit.Text = "خروج"
        '
        'M_Reports
        '
        Me.M_Reports.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.M_visit_report, Me.M_visit_daily, Me.M_visit_all})
        Me.M_Reports.Name = "M_Reports"
        Me.M_Reports.Size = New System.Drawing.Size(82, 34)
        Me.M_Reports.Text = "گزارشات"
        '
        'M_visit_report
        '
        Me.M_visit_report.Image = Global.PeigiriVije137.My.Resources.Resources.pen
        Me.M_visit_report.Name = "M_visit_report"
        Me.M_visit_report.Size = New System.Drawing.Size(174, 34)
        Me.M_visit_report.Text = "گزارش بازدید"
        '
        'M_visit_daily
        '
        Me.M_visit_daily.Image = Global.PeigiriVije137.My.Resources.Resources.Diagram
        Me.M_visit_daily.Name = "M_visit_daily"
        Me.M_visit_daily.Size = New System.Drawing.Size(174, 34)
        Me.M_visit_daily.Text = "گزارش روزانه"
        '
        'M_visit_all
        '
        Me.M_visit_all.Image = Global.PeigiriVije137.My.Resources.Resources.book1
        Me.M_visit_all.Name = "M_visit_all"
        Me.M_visit_all.Size = New System.Drawing.Size(174, 34)
        Me.M_visit_all.Text = "کزارش کلی"
        '
        'M_Seting
        '
        Me.M_Seting.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.M_Users, Me.M_PassChange, Me.M_Mails})
        Me.M_Seting.Name = "M_Seting"
        Me.M_Seting.Size = New System.Drawing.Size(81, 34)
        Me.M_Seting.Text = "تنظیمات"
        '
        'M_Users
        '
        Me.M_Users.Image = Global.PeigiriVije137.My.Resources.Resources.news2
        Me.M_Users.Name = "M_Users"
        Me.M_Users.Size = New System.Drawing.Size(183, 34)
        Me.M_Users.Text = "لیست کاربران"
        '
        'M_PassChange
        '
        Me.M_PassChange.Image = Global.PeigiriVije137.My.Resources.Resources.Small_Lock
        Me.M_PassChange.Name = "M_PassChange"
        Me.M_PassChange.Size = New System.Drawing.Size(183, 34)
        Me.M_PassChange.Text = "تغییر رمز عبور"
        '
        'M_Mails
        '
        Me.M_Mails.Image = Global.PeigiriVije137.My.Resources.Resources.Host2
        Me.M_Mails.Name = "M_Mails"
        Me.M_Mails.Size = New System.Drawing.Size(183, 34)
        Me.M_Mails.Text = "صندوق پیام"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.StatusStrip1.Font = New System.Drawing.Font("B Nazanin", 14.0!, System.Drawing.FontStyle.Bold)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ts_username, Me.ToolStripStatusLabel4, Me.ts_Role, Me.ToolStripStatusLabel2, Me.ts_date, Me.ToolStripStatusLabel5})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 626)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(984, 35)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(73, 30)
        Me.ToolStripStatusLabel1.Text = "نام کاربر: "
        '
        'ts_username
        '
        Me.ts_username.Name = "ts_username"
        Me.ts_username.Size = New System.Drawing.Size(113, 30)
        Me.ts_username.Text = "**********"
        Me.ts_username.ToolTipText = "کاربر فعال: & ts_username.text"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(85, 30)
        Me.ToolStripStatusLabel2.Text = "______"
        '
        'ts_date
        '
        Me.ts_date.Name = "ts_date"
        Me.ts_date.Size = New System.Drawing.Size(234, 30)
        Me.ts_date.Text = "امروز سه شنبه مورخ 1399/06/03"
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripStatusLabel5.Font = New System.Drawing.Font("B Nazanin", 12.0!)
        Me.ToolStripStatusLabel5.ForeColor = System.Drawing.Color.DimGray
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(235, 30)
        Me.ToolStripStatusLabel5.Spring = True
        Me.ToolStripStatusLabel5.Text = "Powered by: SamahTech.co"
        Me.ToolStripStatusLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ts_Role
        '
        Me.ts_Role.Name = "ts_Role"
        Me.ts_Role.Size = New System.Drawing.Size(113, 30)
        Me.ts_Role.Text = "**********"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(85, 30)
        Me.ToolStripStatusLabel4.Text = "______"
        '
        'frm_main
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(984, 661)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("B Nazanin", 11.25!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frm_main"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "معاونت پیگیری و کنترل : صفحه اصلی"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents M_main As ToolStripMenuItem
    Friend WithEvents M_before As ToolStripMenuItem
    Friend WithEvents M_after As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents M_exit As ToolStripMenuItem
    Friend WithEvents M_Reports As ToolStripMenuItem
    Friend WithEvents M_visit_report As ToolStripMenuItem
    Friend WithEvents M_visit_daily As ToolStripMenuItem
    Friend WithEvents M_visit_all As ToolStripMenuItem
    Friend WithEvents M_Seting As ToolStripMenuItem
    Friend WithEvents M_Users As ToolStripMenuItem
    Friend WithEvents M_PassChange As ToolStripMenuItem
    Friend WithEvents M_Mails As ToolStripMenuItem
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ts_username As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents ts_date As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As ToolStripStatusLabel
    Friend WithEvents ts_Role As ToolStripStatusLabel
End Class
