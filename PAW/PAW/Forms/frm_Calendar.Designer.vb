<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Calendar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Calendar))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_next = New System.Windows.Forms.Button()
        Me.btn_pre = New System.Windows.Forms.Button()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.lbl_dayname = New System.Windows.Forms.Label()
        Me.btn_return = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txt_min = New System.Windows.Forms.NumericUpDown()
        Me.txt_h = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RemindYear = New System.Windows.Forms.TextBox()
        Me.RemindMonth = New System.Windows.Forms.TextBox()
        Me.RemindDay = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PeopleList = New System.Windows.Forms.CheckedListBox()
        Me.RemindList = New System.Windows.Forms.CheckedListBox()
        Me.chb_reminder = New System.Windows.Forms.CheckBox()
        Me.NoteList = New System.Windows.Forms.CheckedListBox()
        Me.NoteText = New System.Windows.Forms.TextBox()
        Me.btn_del_all = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_del = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.txt_min, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_h, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.btn_next)
        Me.Panel1.Controls.Add(Me.btn_pre)
        Me.Panel1.Controls.Add(Me.lbl_date)
        Me.Panel1.Controls.Add(Me.lbl_dayname)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(782, 79)
        Me.Panel1.TabIndex = 8
        '
        'btn_next
        '
        Me.btn_next.BackColor = System.Drawing.Color.Silver
        Me.btn_next.FlatAppearance.BorderSize = 0
        Me.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_next.Image = Global.PAW.My.Resources.Resources.icons8_back_arrow_50
        Me.btn_next.Location = New System.Drawing.Point(232, 14)
        Me.btn_next.Name = "btn_next"
        Me.btn_next.Size = New System.Drawing.Size(50, 50)
        Me.btn_next.TabIndex = 15
        Me.btn_next.UseVisualStyleBackColor = False
        '
        'btn_pre
        '
        Me.btn_pre.BackColor = System.Drawing.Color.Silver
        Me.btn_pre.FlatAppearance.BorderSize = 0
        Me.btn_pre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_pre.Image = Global.PAW.My.Resources.Resources.icons8_forward_button_50
        Me.btn_pre.Location = New System.Drawing.Point(500, 14)
        Me.btn_pre.Name = "btn_pre"
        Me.btn_pre.Size = New System.Drawing.Size(50, 50)
        Me.btn_pre.TabIndex = 14
        Me.btn_pre.UseVisualStyleBackColor = False
        '
        'lbl_date
        '
        Me.lbl_date.Location = New System.Drawing.Point(288, 14)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(100, 50)
        Me.lbl_date.TabIndex = 2
        Me.lbl_date.Text = "1400/04/17"
        Me.lbl_date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_dayname
        '
        Me.lbl_dayname.Location = New System.Drawing.Point(394, 14)
        Me.lbl_dayname.Name = "lbl_dayname"
        Me.lbl_dayname.Size = New System.Drawing.Size(100, 50)
        Me.lbl_dayname.TabIndex = 3
        Me.lbl_dayname.Text = "پنج شنبه"
        Me.lbl_dayname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_return
        '
        Me.btn_return.Image = Global.PAW.My.Resources.Resources.icons8_end_button_50
        Me.btn_return.Location = New System.Drawing.Point(12, 491)
        Me.btn_return.Name = "btn_return"
        Me.btn_return.Size = New System.Drawing.Size(50, 50)
        Me.btn_return.TabIndex = 16
        Me.btn_return.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.txt_min)
        Me.Panel2.Controls.Add(Me.txt_h)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.RemindYear)
        Me.Panel2.Controls.Add(Me.RemindMonth)
        Me.Panel2.Controls.Add(Me.RemindDay)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.PeopleList)
        Me.Panel2.Controls.Add(Me.RemindList)
        Me.Panel2.Location = New System.Drawing.Point(439, 218)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(312, 232)
        Me.Panel2.TabIndex = 22
        Me.Panel2.Visible = False
        '
        'txt_min
        '
        Me.txt_min.Location = New System.Drawing.Point(117, 183)
        Me.txt_min.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.txt_min.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
        Me.txt_min.Name = "txt_min"
        Me.txt_min.Size = New System.Drawing.Size(42, 39)
        Me.txt_min.TabIndex = 8
        Me.txt_min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_h
        '
        Me.txt_h.Location = New System.Drawing.Point(69, 183)
        Me.txt_h.Maximum = New Decimal(New Integer() {24, 0, 0, 0})
        Me.txt_h.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
        Me.txt_h.Name = "txt_h"
        Me.txt_h.Size = New System.Drawing.Size(42, 39)
        Me.txt_h.TabIndex = 9
        Me.txt_h.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(165, 185)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 32)
        Me.Label1.TabIndex = 132
        Me.Label1.Text = "زمان یادآوری"
        '
        'RemindYear
        '
        Me.RemindYear.Location = New System.Drawing.Point(29, 12)
        Me.RemindYear.MaxLength = 4
        Me.RemindYear.Name = "RemindYear"
        Me.RemindYear.Size = New System.Drawing.Size(78, 39)
        Me.RemindYear.TabIndex = 5
        Me.RemindYear.Text = "1400"
        Me.RemindYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RemindMonth
        '
        Me.RemindMonth.Location = New System.Drawing.Point(113, 12)
        Me.RemindMonth.MaxLength = 2
        Me.RemindMonth.Name = "RemindMonth"
        Me.RemindMonth.Size = New System.Drawing.Size(39, 39)
        Me.RemindMonth.TabIndex = 4
        Me.RemindMonth.Text = "04"
        Me.RemindMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RemindDay
        '
        Me.RemindDay.Location = New System.Drawing.Point(158, 12)
        Me.RemindDay.MaxLength = 2
        Me.RemindDay.Name = "RemindDay"
        Me.RemindDay.Size = New System.Drawing.Size(39, 39)
        Me.RemindDay.TabIndex = 3
        Me.RemindDay.Text = "05"
        Me.RemindDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(203, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 32)
        Me.Label3.TabIndex = 128
        Me.Label3.Text = "تاریخ یادآوری"
        '
        'PeopleList
        '
        Me.PeopleList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PeopleList.CheckOnClick = True
        Me.PeopleList.FormattingEnabled = True
        Me.PeopleList.Items.AddRange(New Object() {"وحید نوروزنیا", "سیدامیر موسوی", "نوید اسمعیل زاده", "مهدی کهن", "حمید حنانی", "عبداله عسکری"})
        Me.PeopleList.Location = New System.Drawing.Point(3, 53)
        Me.PeopleList.Name = "PeopleList"
        Me.PeopleList.Size = New System.Drawing.Size(136, 102)
        Me.PeopleList.TabIndex = 7
        Me.PeopleList.Visible = False
        '
        'RemindList
        '
        Me.RemindList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RemindList.CheckOnClick = True
        Me.RemindList.FormattingEnabled = True
        Me.RemindList.Items.AddRange(New Object() {"نمایش در صفحه اصلی", "نمایش پیغام یادآوری", "ارسال پیام به خود", "ارسال پیام به دیگران"})
        Me.RemindList.Location = New System.Drawing.Point(144, 53)
        Me.RemindList.Name = "RemindList"
        Me.RemindList.Size = New System.Drawing.Size(165, 102)
        Me.RemindList.TabIndex = 6
        '
        'chb_reminder
        '
        Me.chb_reminder.AutoSize = True
        Me.chb_reminder.Location = New System.Drawing.Point(681, 182)
        Me.chb_reminder.Name = "chb_reminder"
        Me.chb_reminder.Size = New System.Drawing.Size(86, 36)
        Me.chb_reminder.TabIndex = 2
        Me.chb_reminder.Text = "یادآوری"
        Me.chb_reminder.UseVisualStyleBackColor = True
        '
        'NoteList
        '
        Me.NoteList.CheckOnClick = True
        Me.NoteList.FormattingEnabled = True
        Me.NoteList.HorizontalScrollbar = True
        Me.NoteList.Items.AddRange(New Object() {"ارسال گزارش ماهانه", "بررسی سامانه تحلیل", "تماس با آقای ...", "ارسال گزارش ماهانهارسال گزارش ماهانهارسال گزارش ماهانهارسال گزارش ماهانه"})
        Me.NoteList.Location = New System.Drawing.Point(31, 138)
        Me.NoteList.Name = "NoteList"
        Me.NoteList.Size = New System.Drawing.Size(346, 310)
        Me.NoteList.TabIndex = 13
        '
        'NoteText
        '
        Me.NoteText.Location = New System.Drawing.Point(439, 138)
        Me.NoteText.Name = "NoteText"
        Me.NoteText.Size = New System.Drawing.Size(312, 39)
        Me.NoteText.TabIndex = 0
        '
        'btn_del_all
        '
        Me.btn_del_all.FlatAppearance.BorderSize = 0
        Me.btn_del_all.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_del_all.Image = Global.PAW.My.Resources.Resources.icons8_delete_document_40
        Me.btn_del_all.Location = New System.Drawing.Point(383, 409)
        Me.btn_del_all.Name = "btn_del_all"
        Me.btn_del_all.Size = New System.Drawing.Size(50, 39)
        Me.btn_del_all.TabIndex = 12
        Me.btn_del_all.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.FlatAppearance.BorderSize = 0
        Me.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_edit.Image = Global.PAW.My.Resources.Resources.icons8_edit_50
        Me.btn_edit.Location = New System.Drawing.Point(383, 319)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(50, 39)
        Me.btn_edit.TabIndex = 10
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'btn_del
        '
        Me.btn_del.FlatAppearance.BorderSize = 0
        Me.btn_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_del.Image = Global.PAW.My.Resources.Resources.icons8_delete_bin_40
        Me.btn_del.Location = New System.Drawing.Point(383, 364)
        Me.btn_del.Name = "btn_del"
        Me.btn_del.Size = New System.Drawing.Size(50, 39)
        Me.btn_del.TabIndex = 11
        Me.btn_del.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.FlatAppearance.BorderSize = 0
        Me.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add.Image = Global.PAW.My.Resources.Resources.icons8_rewind_40
        Me.btn_add.Location = New System.Drawing.Point(383, 138)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(50, 39)
        Me.btn_add.TabIndex = 1
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(657, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 32)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "یادداشت روز"
        '
        'frm_Calendar
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(782, 553)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.chb_reminder)
        Me.Controls.Add(Me.NoteList)
        Me.Controls.Add(Me.NoteText)
        Me.Controls.Add(Me.btn_del_all)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.btn_del)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_return)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("B Kamran", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_Calendar"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "برنامه ریزی کارهای اداری / یادداشت کاری"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.txt_min, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_h, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_next As Button
    Friend WithEvents btn_pre As Button
    Friend WithEvents lbl_date As Label
    Friend WithEvents lbl_dayname As Label
    Friend WithEvents btn_return As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txt_min As NumericUpDown
    Friend WithEvents txt_h As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents RemindYear As TextBox
    Friend WithEvents RemindMonth As TextBox
    Friend WithEvents RemindDay As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PeopleList As CheckedListBox
    Friend WithEvents RemindList As CheckedListBox
    Friend WithEvents chb_reminder As CheckBox
    Friend WithEvents NoteList As CheckedListBox
    Friend WithEvents NoteText As TextBox
    Friend WithEvents btn_del_all As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_del As Button
    Friend WithEvents btn_add As Button
    Friend WithEvents Label2 As Label
End Class
