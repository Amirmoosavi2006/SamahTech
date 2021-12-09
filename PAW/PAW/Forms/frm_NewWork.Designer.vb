<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_NewWork
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_NewWork))
        Me.TrackCHB = New System.Windows.Forms.CheckBox()
        Me.TrackYear = New System.Windows.Forms.TextBox()
        Me.TrackMonth = New System.Windows.Forms.TextBox()
        Me.TrackDay = New System.Windows.Forms.TextBox()
        Me.AttachmentsList = New System.Windows.Forms.ListBox()
        Me.PeopleList = New System.Windows.Forms.CheckedListBox()
        Me.NewWorkYear = New System.Windows.Forms.TextBox()
        Me.NewWorkMonth = New System.Windows.Forms.TextBox()
        Me.NewWorkDay = New System.Windows.Forms.TextBox()
        Me.NewWorkDesc = New System.Windows.Forms.TextBox()
        Me.NewWorkTitle = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_return = New System.Windows.Forms.Button()
        Me.btn_new = New System.Windows.Forms.Button()
        Me.btn_attach = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_del = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'TrackCHB
        '
        Me.TrackCHB.AutoSize = True
        Me.TrackCHB.Location = New System.Drawing.Point(542, 484)
        Me.TrackCHB.Name = "TrackCHB"
        Me.TrackCHB.Size = New System.Drawing.Size(118, 37)
        Me.TrackCHB.TabIndex = 8
        Me.TrackCHB.Text = "پیگیری بعدی"
        Me.TrackCHB.UseVisualStyleBackColor = True
        '
        'TrackYear
        '
        Me.TrackYear.Enabled = False
        Me.TrackYear.Location = New System.Drawing.Point(368, 482)
        Me.TrackYear.MaxLength = 4
        Me.TrackYear.Name = "TrackYear"
        Me.TrackYear.Size = New System.Drawing.Size(78, 41)
        Me.TrackYear.TabIndex = 11
        Me.TrackYear.Text = "1400"
        Me.TrackYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TrackMonth
        '
        Me.TrackMonth.Enabled = False
        Me.TrackMonth.Location = New System.Drawing.Point(452, 482)
        Me.TrackMonth.MaxLength = 2
        Me.TrackMonth.Name = "TrackMonth"
        Me.TrackMonth.Size = New System.Drawing.Size(39, 41)
        Me.TrackMonth.TabIndex = 10
        Me.TrackMonth.Text = "04"
        Me.TrackMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TrackDay
        '
        Me.TrackDay.Enabled = False
        Me.TrackDay.Location = New System.Drawing.Point(497, 482)
        Me.TrackDay.MaxLength = 2
        Me.TrackDay.Name = "TrackDay"
        Me.TrackDay.Size = New System.Drawing.Size(39, 41)
        Me.TrackDay.TabIndex = 9
        Me.TrackDay.Text = "05"
        Me.TrackDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AttachmentsList
        '
        Me.AttachmentsList.FormattingEnabled = True
        Me.AttachmentsList.HorizontalScrollbar = True
        Me.AttachmentsList.ItemHeight = 33
        Me.AttachmentsList.Items.AddRange(New Object() {"پیوست 1", "پیوست 2", "پیوست 3"})
        Me.AttachmentsList.Location = New System.Drawing.Point(11, 129)
        Me.AttachmentsList.Name = "AttachmentsList"
        Me.AttachmentsList.ScrollAlwaysVisible = True
        Me.AttachmentsList.Size = New System.Drawing.Size(193, 301)
        Me.AttachmentsList.TabIndex = 7
        '
        'PeopleList
        '
        Me.PeopleList.CheckOnClick = True
        Me.PeopleList.FormattingEnabled = True
        Me.PeopleList.Items.AddRange(New Object() {"وحید نوروزنیا", "سیدامیر موسوی", "نوید اسمعیل زاده", "مهدی کهن", "حمید حنانی", "عبداله عسکری"})
        Me.PeopleList.Location = New System.Drawing.Point(303, 286)
        Me.PeopleList.Name = "PeopleList"
        Me.PeopleList.Size = New System.Drawing.Size(356, 174)
        Me.PeopleList.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.PeopleList, "با انتخاب افراد مرتبط، آنها را از کار جدید مطلع نمایید.")
        '
        'NewWorkYear
        '
        Me.NewWorkYear.Location = New System.Drawing.Point(11, 31)
        Me.NewWorkYear.MaxLength = 4
        Me.NewWorkYear.Name = "NewWorkYear"
        Me.NewWorkYear.Size = New System.Drawing.Size(78, 41)
        Me.NewWorkYear.TabIndex = 4
        Me.NewWorkYear.Text = "1400"
        Me.NewWorkYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NewWorkMonth
        '
        Me.NewWorkMonth.Location = New System.Drawing.Point(95, 31)
        Me.NewWorkMonth.MaxLength = 2
        Me.NewWorkMonth.Name = "NewWorkMonth"
        Me.NewWorkMonth.Size = New System.Drawing.Size(39, 41)
        Me.NewWorkMonth.TabIndex = 3
        Me.NewWorkMonth.Text = "04"
        Me.NewWorkMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NewWorkDay
        '
        Me.NewWorkDay.Location = New System.Drawing.Point(140, 31)
        Me.NewWorkDay.MaxLength = 2
        Me.NewWorkDay.Name = "NewWorkDay"
        Me.NewWorkDay.Size = New System.Drawing.Size(39, 41)
        Me.NewWorkDay.TabIndex = 2
        Me.NewWorkDay.Text = "05"
        Me.NewWorkDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NewWorkDesc
        '
        Me.NewWorkDesc.Location = New System.Drawing.Point(303, 76)
        Me.NewWorkDesc.MaxLength = 255
        Me.NewWorkDesc.Multiline = True
        Me.NewWorkDesc.Name = "NewWorkDesc"
        Me.NewWorkDesc.Size = New System.Drawing.Size(356, 204)
        Me.NewWorkDesc.TabIndex = 1
        Me.NewWorkDesc.Text = "g"
        '
        'NewWorkTitle
        '
        Me.NewWorkTitle.Location = New System.Drawing.Point(303, 31)
        Me.NewWorkTitle.MaxLength = 100
        Me.NewWorkTitle.Name = "NewWorkTitle"
        Me.NewWorkTitle.Size = New System.Drawing.Size(356, 41)
        Me.NewWorkTitle.TabIndex = 0
        Me.NewWorkTitle.Text = "a"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(665, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 33)
        Me.Label2.TabIndex = 111
        Me.Label2.Text = "شرح کار"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(665, 286)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 33)
        Me.Label4.TabIndex = 110
        Me.Label4.Text = "افراد مرتبط"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(210, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 33)
        Me.Label5.TabIndex = 109
        Me.Label5.Text = "پیوست ها"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(185, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 33)
        Me.Label3.TabIndex = 113
        Me.Label3.Text = "تاریخ شروع کار"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(665, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 33)
        Me.Label1.TabIndex = 108
        Me.Label1.Text = "عنوان کار جدید"
        '
        'btn_return
        '
        Me.btn_return.Image = Global.PAW.My.Resources.Resources.icons8_end_button_50
        Me.btn_return.Location = New System.Drawing.Point(12, 476)
        Me.btn_return.Name = "btn_return"
        Me.btn_return.Size = New System.Drawing.Size(50, 50)
        Me.btn_return.TabIndex = 14
        Me.ToolTip1.SetToolTip(Me.btn_return, "بازگشت")
        Me.btn_return.UseVisualStyleBackColor = True
        '
        'btn_new
        '
        Me.btn_new.Image = Global.PAW.My.Resources.Resources.icons8_new_view_501
        Me.btn_new.Location = New System.Drawing.Point(68, 476)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(50, 50)
        Me.btn_new.TabIndex = 13
        Me.ToolTip1.SetToolTip(Me.btn_new, "تعریف کار جدید")
        Me.btn_new.UseVisualStyleBackColor = True
        '
        'btn_attach
        '
        Me.btn_attach.Image = Global.PAW.My.Resources.Resources.icons8_attach_50
        Me.btn_attach.Location = New System.Drawing.Point(180, 476)
        Me.btn_attach.Name = "btn_attach"
        Me.btn_attach.Size = New System.Drawing.Size(50, 50)
        Me.btn_attach.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.btn_attach, "پیوست")
        Me.btn_attach.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Image = Global.PAW.My.Resources.Resources.icons8_save_close_50
        Me.btn_save.Location = New System.Drawing.Point(236, 476)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(50, 50)
        Me.btn_save.TabIndex = 12
        Me.ToolTip1.SetToolTip(Me.btn_save, "ذخیره")
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_del
        '
        Me.btn_del.FlatAppearance.BorderSize = 0
        Me.btn_del.Image = Global.PAW.My.Resources.Resources.icons8_delete_bin_40
        Me.btn_del.Location = New System.Drawing.Point(124, 476)
        Me.btn_del.Name = "btn_del"
        Me.btn_del.Size = New System.Drawing.Size(50, 50)
        Me.btn_del.TabIndex = 114
        Me.ToolTip1.SetToolTip(Me.btn_del, "حذف پیوست")
        Me.btn_del.UseVisualStyleBackColor = True
        '
        'frm_NewWork
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(782, 553)
        Me.Controls.Add(Me.btn_del)
        Me.Controls.Add(Me.TrackCHB)
        Me.Controls.Add(Me.TrackYear)
        Me.Controls.Add(Me.TrackMonth)
        Me.Controls.Add(Me.TrackDay)
        Me.Controls.Add(Me.AttachmentsList)
        Me.Controls.Add(Me.PeopleList)
        Me.Controls.Add(Me.btn_return)
        Me.Controls.Add(Me.btn_new)
        Me.Controls.Add(Me.btn_attach)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.NewWorkYear)
        Me.Controls.Add(Me.NewWorkMonth)
        Me.Controls.Add(Me.NewWorkDay)
        Me.Controls.Add(Me.NewWorkDesc)
        Me.Controls.Add(Me.NewWorkTitle)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("B Compset", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_NewWork"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "برنامه ریزی کارهای اداری / کار جدید"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TrackCHB As CheckBox
    Friend WithEvents TrackYear As TextBox
    Friend WithEvents TrackMonth As TextBox
    Friend WithEvents TrackDay As TextBox
    Friend WithEvents AttachmentsList As ListBox
    Friend WithEvents PeopleList As CheckedListBox
    Friend WithEvents btn_return As Button
    Friend WithEvents btn_new As Button
    Friend WithEvents btn_attach As Button
    Friend WithEvents btn_save As Button
    Friend WithEvents NewWorkYear As TextBox
    Friend WithEvents NewWorkMonth As TextBox
    Friend WithEvents NewWorkDay As TextBox
    Friend WithEvents NewWorkDesc As TextBox
    Friend WithEvents NewWorkTitle As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_del As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
