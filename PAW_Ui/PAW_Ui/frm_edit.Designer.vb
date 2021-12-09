<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_edit
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_del_all = New System.Windows.Forms.Button()
        Me.btn_home = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TrackList = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.AttachmentsList = New System.Windows.Forms.ListBox()
        Me.chb_track = New System.Windows.Forms.CheckBox()
        Me.txt_t_year = New System.Windows.Forms.TextBox()
        Me.txt_t_month = New System.Windows.Forms.TextBox()
        Me.txt_t_day = New System.Windows.Forms.TextBox()
        Me.PeopleList = New System.Windows.Forms.CheckedListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_desc = New System.Windows.Forms.TextBox()
        Me.txt_title = New System.Windows.Forms.TextBox()
        Me.txt_year = New System.Windows.Forms.TextBox()
        Me.txt_month = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_day = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chb_end = New System.Windows.Forms.CheckBox()
        Me.txt_end_year = New System.Windows.Forms.TextBox()
        Me.txt_end_month = New System.Windows.Forms.TextBox()
        Me.txt_end_day = New System.Windows.Forms.TextBox()
        Me.btn_track_del = New System.Windows.Forms.Button()
        Me.btn_attach_del = New System.Windows.Forms.Button()
        Me.btn_attach = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btn_save)
        Me.Panel1.Controls.Add(Me.btn_del_all)
        Me.Panel1.Controls.Add(Me.btn_home)
        Me.Panel1.Location = New System.Drawing.Point(12, 592)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(267, 100)
        Me.Panel1.TabIndex = 156
        '
        'btn_save
        '
        Me.btn_save.Image = Global.PAW_Ui.My.Resources.Resources.save_as_64px
        Me.btn_save.Location = New System.Drawing.Point(174, 13)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(72, 72)
        Me.btn_save.TabIndex = 145
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_del_all
        '
        Me.btn_del_all.Image = Global.PAW_Ui.My.Resources.Resources.trash_can_64px
        Me.btn_del_all.Location = New System.Drawing.Point(96, 13)
        Me.btn_del_all.Name = "btn_del_all"
        Me.btn_del_all.Size = New System.Drawing.Size(72, 72)
        Me.btn_del_all.TabIndex = 144
        Me.btn_del_all.UseVisualStyleBackColor = True
        '
        'btn_home
        '
        Me.btn_home.Image = Global.PAW_Ui.My.Resources.Resources.return_64px
        Me.btn_home.Location = New System.Drawing.Point(18, 13)
        Me.btn_home.Name = "btn_home"
        Me.btn_home.Size = New System.Drawing.Size(72, 72)
        Me.btn_home.TabIndex = 143
        Me.btn_home.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.LightGray
        Me.Label6.Location = New System.Drawing.Point(169, 340)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(252, 42)
        Me.Label6.TabIndex = 198
        Me.Label6.Text = "شرح پیگیری"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TrackList
        '
        Me.TrackList.BackColor = System.Drawing.Color.Orange
        Me.TrackList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TrackList.FormattingEnabled = True
        Me.TrackList.HorizontalScrollbar = True
        Me.TrackList.ItemHeight = 24
        Me.TrackList.Items.AddRange(New Object() {"پیوست 1", "پیوست 2", "پیوست 3"})
        Me.TrackList.Location = New System.Drawing.Point(121, 387)
        Me.TrackList.Name = "TrackList"
        Me.TrackList.Size = New System.Drawing.Size(300, 146)
        Me.TrackList.TabIndex = 197
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.LightGray
        Me.Label5.Location = New System.Drawing.Point(217, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(204, 42)
        Me.Label5.TabIndex = 194
        Me.Label5.Text = "پیوست"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AttachmentsList
        '
        Me.AttachmentsList.BackColor = System.Drawing.Color.Orange
        Me.AttachmentsList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AttachmentsList.FormattingEnabled = True
        Me.AttachmentsList.HorizontalScrollbar = True
        Me.AttachmentsList.ItemHeight = 24
        Me.AttachmentsList.Items.AddRange(New Object() {"پیوست 1", "پیوست 2", "پیوست 3"})
        Me.AttachmentsList.Location = New System.Drawing.Point(121, 173)
        Me.AttachmentsList.Name = "AttachmentsList"
        Me.AttachmentsList.Size = New System.Drawing.Size(300, 146)
        Me.AttachmentsList.TabIndex = 193
        '
        'chb_track
        '
        Me.chb_track.BackColor = System.Drawing.Color.LightGray
        Me.chb_track.Location = New System.Drawing.Point(666, 556)
        Me.chb_track.Name = "chb_track"
        Me.chb_track.Size = New System.Drawing.Size(126, 33)
        Me.chb_track.TabIndex = 189
        Me.chb_track.Text = "پیگیری بعدی"
        Me.chb_track.UseVisualStyleBackColor = False
        '
        'txt_t_year
        '
        Me.txt_t_year.BackColor = System.Drawing.Color.Orange
        Me.txt_t_year.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_t_year.Enabled = False
        Me.txt_t_year.Location = New System.Drawing.Point(492, 557)
        Me.txt_t_year.MaxLength = 4
        Me.txt_t_year.Name = "txt_t_year"
        Me.txt_t_year.Size = New System.Drawing.Size(78, 31)
        Me.txt_t_year.TabIndex = 192
        Me.txt_t_year.Text = "1400"
        Me.txt_t_year.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_t_month
        '
        Me.txt_t_month.BackColor = System.Drawing.Color.Orange
        Me.txt_t_month.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_t_month.Enabled = False
        Me.txt_t_month.Location = New System.Drawing.Point(576, 557)
        Me.txt_t_month.MaxLength = 2
        Me.txt_t_month.Name = "txt_t_month"
        Me.txt_t_month.Size = New System.Drawing.Size(39, 31)
        Me.txt_t_month.TabIndex = 191
        Me.txt_t_month.Text = "04"
        Me.txt_t_month.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_t_day
        '
        Me.txt_t_day.BackColor = System.Drawing.Color.Orange
        Me.txt_t_day.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_t_day.Enabled = False
        Me.txt_t_day.Location = New System.Drawing.Point(621, 557)
        Me.txt_t_day.MaxLength = 2
        Me.txt_t_day.Name = "txt_t_day"
        Me.txt_t_day.Size = New System.Drawing.Size(39, 31)
        Me.txt_t_day.TabIndex = 190
        Me.txt_t_day.Text = "05"
        Me.txt_t_day.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PeopleList
        '
        Me.PeopleList.BackColor = System.Drawing.Color.Orange
        Me.PeopleList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PeopleList.CheckOnClick = True
        Me.PeopleList.FormattingEnabled = True
        Me.PeopleList.Items.AddRange(New Object() {"وحید نوروزنیا", "سیدامیر موسوی", "نوید اسمعیل زاده", "مهدی کهن", "حمید حنانی", "عبداله عسکری"})
        Me.PeopleList.Location = New System.Drawing.Point(492, 372)
        Me.PeopleList.Name = "PeopleList"
        Me.PeopleList.Size = New System.Drawing.Size(300, 158)
        Me.PeopleList.TabIndex = 187
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("B Koodak", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label4.Location = New System.Drawing.Point(798, 372)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 28)
        Me.Label4.TabIndex = 188
        Me.Label4.Text = "افراد مرتبط"
        '
        'txt_desc
        '
        Me.txt_desc.BackColor = System.Drawing.Color.Orange
        Me.txt_desc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_desc.Font = New System.Drawing.Font("B Koodak", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txt_desc.Location = New System.Drawing.Point(492, 177)
        Me.txt_desc.MaxLength = 255
        Me.txt_desc.Multiline = True
        Me.txt_desc.Name = "txt_desc"
        Me.txt_desc.Size = New System.Drawing.Size(300, 189)
        Me.txt_desc.TabIndex = 186
        Me.ToolTip1.SetToolTip(Me.txt_desc, "توضیحات لارم را در این قسمت وارد نمایید")
        '
        'txt_title
        '
        Me.txt_title.BackColor = System.Drawing.Color.Orange
        Me.txt_title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_title.Font = New System.Drawing.Font("B Koodak", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txt_title.Location = New System.Drawing.Point(492, 129)
        Me.txt_title.MaxLength = 100
        Me.txt_title.Name = "txt_title"
        Me.txt_title.Size = New System.Drawing.Size(300, 35)
        Me.txt_title.TabIndex = 185
        Me.ToolTip1.SetToolTip(Me.txt_title, "عنوان کار را وارد نمایید")
        '
        'txt_year
        '
        Me.txt_year.BackColor = System.Drawing.Color.Orange
        Me.txt_year.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_year.Font = New System.Drawing.Font("B Koodak", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txt_year.Location = New System.Drawing.Point(624, 81)
        Me.txt_year.MaxLength = 4
        Me.txt_year.Name = "txt_year"
        Me.txt_year.Size = New System.Drawing.Size(78, 35)
        Me.txt_year.TabIndex = 184
        Me.txt_year.Text = "1400"
        Me.txt_year.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txt_year, "یک عدد 4 رقمی برای سال وارد نمایید")
        '
        'txt_month
        '
        Me.txt_month.BackColor = System.Drawing.Color.Orange
        Me.txt_month.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_month.Font = New System.Drawing.Font("B Koodak", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txt_month.Location = New System.Drawing.Point(708, 81)
        Me.txt_month.MaxLength = 2
        Me.txt_month.Name = "txt_month"
        Me.txt_month.Size = New System.Drawing.Size(39, 35)
        Me.txt_month.TabIndex = 183
        Me.txt_month.Text = "04"
        Me.txt_month.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txt_month, "رقمی بین 1 تا 12 وارد نمایید")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("B Koodak", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.Location = New System.Drawing.Point(798, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 28)
        Me.Label3.TabIndex = 180
        Me.Label3.Text = "شرح کار"
        '
        'txt_day
        '
        Me.txt_day.BackColor = System.Drawing.Color.Orange
        Me.txt_day.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_day.Font = New System.Drawing.Font("B Koodak", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txt_day.Location = New System.Drawing.Point(753, 81)
        Me.txt_day.MaxLength = 2
        Me.txt_day.Name = "txt_day"
        Me.txt_day.Size = New System.Drawing.Size(39, 35)
        Me.txt_day.TabIndex = 182
        Me.txt_day.Text = "05"
        Me.txt_day.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txt_day, "رقمی بین 1 تا 30 (یا 31) وارد نمایید")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("B Koodak", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.Location = New System.Drawing.Point(798, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 28)
        Me.Label2.TabIndex = 181
        Me.Label2.Text = "عنوان کار"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("B Koodak", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.Location = New System.Drawing.Point(798, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 28)
        Me.Label1.TabIndex = 179
        Me.Label1.Text = "تاریخ شروع کار"
        '
        'chb_end
        '
        Me.chb_end.BackColor = System.Drawing.Color.LightGray
        Me.chb_end.Location = New System.Drawing.Point(666, 599)
        Me.chb_end.Name = "chb_end"
        Me.chb_end.Size = New System.Drawing.Size(126, 33)
        Me.chb_end.TabIndex = 200
        Me.chb_end.Text = "تاریخ پایان کار"
        Me.chb_end.UseVisualStyleBackColor = False
        '
        'txt_end_year
        '
        Me.txt_end_year.BackColor = System.Drawing.Color.Orange
        Me.txt_end_year.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_end_year.Enabled = False
        Me.txt_end_year.Location = New System.Drawing.Point(492, 600)
        Me.txt_end_year.MaxLength = 4
        Me.txt_end_year.Name = "txt_end_year"
        Me.txt_end_year.Size = New System.Drawing.Size(78, 31)
        Me.txt_end_year.TabIndex = 203
        Me.txt_end_year.Text = "1400"
        Me.txt_end_year.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_end_month
        '
        Me.txt_end_month.BackColor = System.Drawing.Color.Orange
        Me.txt_end_month.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_end_month.Enabled = False
        Me.txt_end_month.Location = New System.Drawing.Point(576, 600)
        Me.txt_end_month.MaxLength = 2
        Me.txt_end_month.Name = "txt_end_month"
        Me.txt_end_month.Size = New System.Drawing.Size(39, 31)
        Me.txt_end_month.TabIndex = 202
        Me.txt_end_month.Text = "04"
        Me.txt_end_month.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_end_day
        '
        Me.txt_end_day.BackColor = System.Drawing.Color.Orange
        Me.txt_end_day.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_end_day.Enabled = False
        Me.txt_end_day.Location = New System.Drawing.Point(621, 600)
        Me.txt_end_day.MaxLength = 2
        Me.txt_end_day.Name = "txt_end_day"
        Me.txt_end_day.Size = New System.Drawing.Size(39, 31)
        Me.txt_end_day.TabIndex = 201
        Me.txt_end_day.Text = "05"
        Me.txt_end_day.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_track_del
        '
        Me.btn_track_del.Image = Global.PAW_Ui.My.Resources.Resources.delete_30px
        Me.btn_track_del.Location = New System.Drawing.Point(121, 340)
        Me.btn_track_del.Name = "btn_track_del"
        Me.btn_track_del.Size = New System.Drawing.Size(42, 42)
        Me.btn_track_del.TabIndex = 199
        Me.btn_track_del.UseVisualStyleBackColor = True
        '
        'btn_attach_del
        '
        Me.btn_attach_del.Image = Global.PAW_Ui.My.Resources.Resources.delete_30px
        Me.btn_attach_del.Location = New System.Drawing.Point(121, 126)
        Me.btn_attach_del.Name = "btn_attach_del"
        Me.btn_attach_del.Size = New System.Drawing.Size(42, 42)
        Me.btn_attach_del.TabIndex = 196
        Me.btn_attach_del.UseVisualStyleBackColor = True
        '
        'btn_attach
        '
        Me.btn_attach.Image = Global.PAW_Ui.My.Resources.Resources.attach_30px
        Me.btn_attach.Location = New System.Drawing.Point(169, 126)
        Me.btn_attach.Name = "btn_attach"
        Me.btn_attach.Size = New System.Drawing.Size(42, 42)
        Me.btn_attach.TabIndex = 195
        Me.btn_attach.UseVisualStyleBackColor = True
        '
        'frm_edit
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(990, 704)
        Me.ControlBox = False
        Me.Controls.Add(Me.chb_end)
        Me.Controls.Add(Me.txt_end_year)
        Me.Controls.Add(Me.txt_end_month)
        Me.Controls.Add(Me.txt_end_day)
        Me.Controls.Add(Me.btn_track_del)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TrackList)
        Me.Controls.Add(Me.btn_attach_del)
        Me.Controls.Add(Me.btn_attach)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.AttachmentsList)
        Me.Controls.Add(Me.chb_track)
        Me.Controls.Add(Me.txt_t_year)
        Me.Controls.Add(Me.txt_t_month)
        Me.Controls.Add(Me.txt_t_day)
        Me.Controls.Add(Me.PeopleList)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_desc)
        Me.Controls.Add(Me.txt_title)
        Me.Controls.Add(Me.txt_year)
        Me.Controls.Add(Me.txt_month)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_day)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("B Koodak", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_edit"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_save As Button
    Friend WithEvents btn_del_all As Button
    Friend WithEvents btn_home As Button
    Friend WithEvents btn_track_del As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents TrackList As ListBox
    Friend WithEvents btn_attach_del As Button
    Friend WithEvents btn_attach As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents AttachmentsList As ListBox
    Friend WithEvents chb_track As CheckBox
    Friend WithEvents txt_t_year As TextBox
    Friend WithEvents txt_t_month As TextBox
    Friend WithEvents txt_t_day As TextBox
    Friend WithEvents PeopleList As CheckedListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_desc As TextBox
    Friend WithEvents txt_title As TextBox
    Friend WithEvents txt_year As TextBox
    Friend WithEvents txt_month As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_day As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents chb_end As CheckBox
    Friend WithEvents txt_end_year As TextBox
    Friend WithEvents txt_end_month As TextBox
    Friend WithEvents txt_end_day As TextBox
    Friend WithEvents ToolTip1 As ToolTip
End Class
