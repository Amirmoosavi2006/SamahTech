<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_new_work
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_refresh = New System.Windows.Forms.Button()
        Me.btn_home = New System.Windows.Forms.Button()
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
        Me.btn_attach_del = New System.Windows.Forms.Button()
        Me.btn_attach = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btn_save)
        Me.Panel1.Controls.Add(Me.btn_refresh)
        Me.Panel1.Controls.Add(Me.btn_home)
        Me.Panel1.Location = New System.Drawing.Point(12, 592)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(267, 100)
        Me.Panel1.TabIndex = 138
        '
        'btn_save
        '
        Me.btn_save.Image = Global.PAW_Ui.My.Resources.Resources.save_64px
        Me.btn_save.Location = New System.Drawing.Point(174, 13)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(72, 72)
        Me.btn_save.TabIndex = 145
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
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.LightGray
        Me.Label5.Location = New System.Drawing.Point(200, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(204, 42)
        Me.Label5.TabIndex = 154
        Me.Label5.Text = "پیوست"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AttachmentsList
        '
        Me.AttachmentsList.BackColor = System.Drawing.Color.LightBlue
        Me.AttachmentsList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AttachmentsList.FormattingEnabled = True
        Me.AttachmentsList.HorizontalScrollbar = True
        Me.AttachmentsList.ItemHeight = 28
        Me.AttachmentsList.Items.AddRange(New Object() {"پیوست 1", "پیوست 2", "پیوست 3"})
        Me.AttachmentsList.Location = New System.Drawing.Point(104, 175)
        Me.AttachmentsList.Name = "AttachmentsList"
        Me.AttachmentsList.Size = New System.Drawing.Size(300, 226)
        Me.AttachmentsList.TabIndex = 153
        '
        'chb_track
        '
        Me.chb_track.AutoSize = True
        Me.chb_track.Location = New System.Drawing.Point(636, 594)
        Me.chb_track.Name = "chb_track"
        Me.chb_track.Size = New System.Drawing.Size(102, 32)
        Me.chb_track.TabIndex = 149
        Me.chb_track.Text = "پیگیری بعدی"
        Me.chb_track.UseVisualStyleBackColor = True
        '
        'txt_t_year
        '
        Me.txt_t_year.BackColor = System.Drawing.Color.LightBlue
        Me.txt_t_year.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_t_year.Enabled = False
        Me.txt_t_year.Location = New System.Drawing.Point(462, 592)
        Me.txt_t_year.MaxLength = 4
        Me.txt_t_year.Name = "txt_t_year"
        Me.txt_t_year.Size = New System.Drawing.Size(78, 35)
        Me.txt_t_year.TabIndex = 152
        Me.txt_t_year.Text = "1400"
        Me.txt_t_year.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_t_month
        '
        Me.txt_t_month.BackColor = System.Drawing.Color.LightBlue
        Me.txt_t_month.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_t_month.Enabled = False
        Me.txt_t_month.Location = New System.Drawing.Point(546, 592)
        Me.txt_t_month.MaxLength = 2
        Me.txt_t_month.Name = "txt_t_month"
        Me.txt_t_month.Size = New System.Drawing.Size(39, 35)
        Me.txt_t_month.TabIndex = 151
        Me.txt_t_month.Text = "04"
        Me.txt_t_month.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_t_day
        '
        Me.txt_t_day.BackColor = System.Drawing.Color.LightBlue
        Me.txt_t_day.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_t_day.Enabled = False
        Me.txt_t_day.Location = New System.Drawing.Point(591, 592)
        Me.txt_t_day.MaxLength = 2
        Me.txt_t_day.Name = "txt_t_day"
        Me.txt_t_day.Size = New System.Drawing.Size(39, 35)
        Me.txt_t_day.TabIndex = 150
        Me.txt_t_day.Text = "05"
        Me.txt_t_day.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PeopleList
        '
        Me.PeopleList.BackColor = System.Drawing.Color.LightBlue
        Me.PeopleList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PeopleList.CheckOnClick = True
        Me.PeopleList.FormattingEnabled = True
        Me.PeopleList.Items.AddRange(New Object() {"وحید نوروزنیا", "سیدامیر موسوی", "نوید اسمعیل زاده", "مهدی کهن", "حمید حنانی", "عبداله عسکری"})
        Me.PeopleList.Location = New System.Drawing.Point(462, 370)
        Me.PeopleList.Name = "PeopleList"
        Me.PeopleList.Size = New System.Drawing.Size(300, 182)
        Me.PeopleList.TabIndex = 147
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(768, 370)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 28)
        Me.Label4.TabIndex = 148
        Me.Label4.Text = "افراد مرتبط"
        '
        'txt_desc
        '
        Me.txt_desc.BackColor = System.Drawing.Color.LightBlue
        Me.txt_desc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_desc.Font = New System.Drawing.Font("B Koodak", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txt_desc.Location = New System.Drawing.Point(462, 175)
        Me.txt_desc.MaxLength = 255
        Me.txt_desc.Multiline = True
        Me.txt_desc.Name = "txt_desc"
        Me.txt_desc.Size = New System.Drawing.Size(300, 189)
        Me.txt_desc.TabIndex = 146
        '
        'txt_title
        '
        Me.txt_title.BackColor = System.Drawing.Color.LightBlue
        Me.txt_title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_title.Font = New System.Drawing.Font("B Koodak", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txt_title.Location = New System.Drawing.Point(462, 127)
        Me.txt_title.MaxLength = 100
        Me.txt_title.Name = "txt_title"
        Me.txt_title.Size = New System.Drawing.Size(300, 35)
        Me.txt_title.TabIndex = 145
        '
        'txt_year
        '
        Me.txt_year.BackColor = System.Drawing.Color.LightBlue
        Me.txt_year.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_year.Font = New System.Drawing.Font("B Koodak", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txt_year.Location = New System.Drawing.Point(594, 79)
        Me.txt_year.MaxLength = 4
        Me.txt_year.Name = "txt_year"
        Me.txt_year.Size = New System.Drawing.Size(78, 35)
        Me.txt_year.TabIndex = 144
        Me.txt_year.Text = "1400"
        Me.txt_year.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_month
        '
        Me.txt_month.BackColor = System.Drawing.Color.LightBlue
        Me.txt_month.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_month.Font = New System.Drawing.Font("B Koodak", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txt_month.Location = New System.Drawing.Point(678, 79)
        Me.txt_month.MaxLength = 2
        Me.txt_month.Name = "txt_month"
        Me.txt_month.Size = New System.Drawing.Size(39, 35)
        Me.txt_month.TabIndex = 143
        Me.txt_month.Text = "04"
        Me.txt_month.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("B Koodak", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.Location = New System.Drawing.Point(768, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 28)
        Me.Label3.TabIndex = 140
        Me.Label3.Text = "شرح کار"
        '
        'txt_day
        '
        Me.txt_day.BackColor = System.Drawing.Color.LightBlue
        Me.txt_day.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_day.Font = New System.Drawing.Font("B Koodak", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txt_day.Location = New System.Drawing.Point(723, 79)
        Me.txt_day.MaxLength = 2
        Me.txt_day.Name = "txt_day"
        Me.txt_day.Size = New System.Drawing.Size(39, 35)
        Me.txt_day.TabIndex = 142
        Me.txt_day.Text = "05"
        Me.txt_day.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("B Koodak", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.Location = New System.Drawing.Point(768, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 28)
        Me.Label2.TabIndex = 141
        Me.Label2.Text = "عنوان کار"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("B Koodak", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.Location = New System.Drawing.Point(768, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 28)
        Me.Label1.TabIndex = 139
        Me.Label1.Text = "تاریخ شروع کار"
        '
        'btn_attach_del
        '
        Me.btn_attach_del.Image = Global.PAW_Ui.My.Resources.Resources.delete_30px
        Me.btn_attach_del.Location = New System.Drawing.Point(104, 127)
        Me.btn_attach_del.Name = "btn_attach_del"
        Me.btn_attach_del.Size = New System.Drawing.Size(42, 42)
        Me.btn_attach_del.TabIndex = 156
        Me.btn_attach_del.UseVisualStyleBackColor = True
        '
        'btn_attach
        '
        Me.btn_attach.Image = Global.PAW_Ui.My.Resources.Resources.attach_30px
        Me.btn_attach.Location = New System.Drawing.Point(152, 127)
        Me.btn_attach.Name = "btn_attach"
        Me.btn_attach.Size = New System.Drawing.Size(42, 42)
        Me.btn_attach.TabIndex = 155
        Me.btn_attach.UseVisualStyleBackColor = True
        '
        'frm_new_work
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(990, 704)
        Me.ControlBox = False
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
        Me.Font = New System.Drawing.Font("B Koodak", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_new_work"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
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
    Friend WithEvents btn_save As Button
    Friend WithEvents btn_refresh As Button
    Friend WithEvents btn_home As Button
End Class
