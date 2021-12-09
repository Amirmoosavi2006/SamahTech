<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Edit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Edit))
        Me.WorkDesc = New System.Windows.Forms.TextBox()
        Me.WorkTitle = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PeopleList = New System.Windows.Forms.CheckedListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.AttachmentsList = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TrackCHB = New System.Windows.Forms.CheckBox()
        Me.TrackYear = New System.Windows.Forms.TextBox()
        Me.TrackMonth = New System.Windows.Forms.TextBox()
        Me.TrackDay = New System.Windows.Forms.TextBox()
        Me.EndWorkCHB = New System.Windows.Forms.CheckBox()
        Me.EndYear = New System.Windows.Forms.TextBox()
        Me.EndMonth = New System.Windows.Forms.TextBox()
        Me.EndDay = New System.Windows.Forms.TextBox()
        Me.TrackList = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Attach_del = New System.Windows.Forms.Button()
        Me.btn_return = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.Track_del = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'WorkDesc
        '
        Me.WorkDesc.Location = New System.Drawing.Point(386, 57)
        Me.WorkDesc.MaxLength = 255
        Me.WorkDesc.Multiline = True
        Me.WorkDesc.Name = "WorkDesc"
        Me.WorkDesc.Size = New System.Drawing.Size(270, 129)
        Me.WorkDesc.TabIndex = 1
        Me.WorkDesc.Text = "g"
        '
        'WorkTitle
        '
        Me.WorkTitle.Location = New System.Drawing.Point(386, 12)
        Me.WorkTitle.MaxLength = 100
        Me.WorkTitle.Name = "WorkTitle"
        Me.WorkTitle.Size = New System.Drawing.Size(270, 39)
        Me.WorkTitle.TabIndex = 0
        Me.WorkTitle.Text = "a"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(662, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 32)
        Me.Label2.TabIndex = 115
        Me.Label2.Text = "شرح کار"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(662, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 32)
        Me.Label1.TabIndex = 114
        Me.Label1.Text = "عنوان کار جدید"
        '
        'PeopleList
        '
        Me.PeopleList.CheckOnClick = True
        Me.PeopleList.FormattingEnabled = True
        Me.PeopleList.Items.AddRange(New Object() {"وحید نوروزنیا", "سیدامیر موسوی", "نوید اسمعیل زاده", "مهدی کهن", "حمید حنانی", "عبداله عسکری"})
        Me.PeopleList.Location = New System.Drawing.Point(12, 12)
        Me.PeopleList.Name = "PeopleList"
        Me.PeopleList.Size = New System.Drawing.Size(275, 174)
        Me.PeopleList.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(293, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 32)
        Me.Label4.TabIndex = 117
        Me.Label4.Text = "افراد مرتبط"
        '
        'AttachmentsList
        '
        Me.AttachmentsList.FormattingEnabled = True
        Me.AttachmentsList.HorizontalScrollbar = True
        Me.AttachmentsList.ItemHeight = 32
        Me.AttachmentsList.Items.AddRange(New Object() {"پیوست 1", "پیوست 2", "پیوست 3"})
        Me.AttachmentsList.Location = New System.Drawing.Point(12, 192)
        Me.AttachmentsList.Name = "AttachmentsList"
        Me.AttachmentsList.ScrollAlwaysVisible = True
        Me.AttachmentsList.Size = New System.Drawing.Size(275, 228)
        Me.AttachmentsList.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(293, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 32)
        Me.Label5.TabIndex = 119
        Me.Label5.Text = "پیوست ها"
        '
        'TrackCHB
        '
        Me.TrackCHB.Location = New System.Drawing.Point(560, 446)
        Me.TrackCHB.Name = "TrackCHB"
        Me.TrackCHB.Size = New System.Drawing.Size(131, 39)
        Me.TrackCHB.TabIndex = 5
        Me.TrackCHB.Text = "پیگیری بعدی"
        Me.TrackCHB.UseVisualStyleBackColor = True
        '
        'TrackYear
        '
        Me.TrackYear.Location = New System.Drawing.Point(386, 446)
        Me.TrackYear.MaxLength = 4
        Me.TrackYear.Name = "TrackYear"
        Me.TrackYear.Size = New System.Drawing.Size(78, 39)
        Me.TrackYear.TabIndex = 8
        Me.TrackYear.Text = "1400"
        Me.TrackYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TrackMonth
        '
        Me.TrackMonth.Location = New System.Drawing.Point(470, 446)
        Me.TrackMonth.MaxLength = 2
        Me.TrackMonth.Name = "TrackMonth"
        Me.TrackMonth.Size = New System.Drawing.Size(39, 39)
        Me.TrackMonth.TabIndex = 7
        Me.TrackMonth.Text = "04"
        Me.TrackMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TrackDay
        '
        Me.TrackDay.Location = New System.Drawing.Point(515, 446)
        Me.TrackDay.MaxLength = 2
        Me.TrackDay.Name = "TrackDay"
        Me.TrackDay.Size = New System.Drawing.Size(39, 39)
        Me.TrackDay.TabIndex = 6
        Me.TrackDay.Text = "05"
        Me.TrackDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'EndWorkCHB
        '
        Me.EndWorkCHB.Location = New System.Drawing.Point(560, 491)
        Me.EndWorkCHB.Name = "EndWorkCHB"
        Me.EndWorkCHB.Size = New System.Drawing.Size(131, 39)
        Me.EndWorkCHB.TabIndex = 9
        Me.EndWorkCHB.Text = "تاریخ پایان کار"
        Me.EndWorkCHB.UseVisualStyleBackColor = True
        '
        'EndYear
        '
        Me.EndYear.Location = New System.Drawing.Point(386, 491)
        Me.EndYear.MaxLength = 4
        Me.EndYear.Name = "EndYear"
        Me.EndYear.Size = New System.Drawing.Size(78, 39)
        Me.EndYear.TabIndex = 12
        Me.EndYear.Text = "1400"
        Me.EndYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'EndMonth
        '
        Me.EndMonth.Location = New System.Drawing.Point(470, 491)
        Me.EndMonth.MaxLength = 2
        Me.EndMonth.Name = "EndMonth"
        Me.EndMonth.Size = New System.Drawing.Size(39, 39)
        Me.EndMonth.TabIndex = 11
        Me.EndMonth.Text = "04"
        Me.EndMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'EndDay
        '
        Me.EndDay.Location = New System.Drawing.Point(515, 491)
        Me.EndDay.MaxLength = 2
        Me.EndDay.Name = "EndDay"
        Me.EndDay.Size = New System.Drawing.Size(39, 39)
        Me.EndDay.TabIndex = 10
        Me.EndDay.Text = "05"
        Me.EndDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TrackList
        '
        Me.TrackList.FormattingEnabled = True
        Me.TrackList.HorizontalScrollbar = True
        Me.TrackList.ItemHeight = 32
        Me.TrackList.Items.AddRange(New Object() {"پیوست 1", "پیوست 2", "پیوست 3"})
        Me.TrackList.Location = New System.Drawing.Point(386, 192)
        Me.TrackList.Name = "TrackList"
        Me.TrackList.ScrollAlwaysVisible = True
        Me.TrackList.Size = New System.Drawing.Size(270, 228)
        Me.TrackList.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(662, 192)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 32)
        Me.Label3.TabIndex = 129
        Me.Label3.Text = "شرح پیگیری"
        '
        'Attach_del
        '
        Me.Attach_del.FlatAppearance.BorderSize = 0
        Me.Attach_del.Image = Global.PAW.My.Resources.Resources.icons8_delete_bin_40
        Me.Attach_del.Location = New System.Drawing.Point(293, 370)
        Me.Attach_del.Name = "Attach_del"
        Me.Attach_del.Size = New System.Drawing.Size(50, 50)
        Me.Attach_del.TabIndex = 134
        Me.Attach_del.UseVisualStyleBackColor = True
        '
        'btn_return
        '
        Me.btn_return.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_return.Image = Global.PAW.My.Resources.Resources.icons8_end_button_50
        Me.btn_return.Location = New System.Drawing.Point(12, 491)
        Me.btn_return.Name = "btn_return"
        Me.btn_return.Size = New System.Drawing.Size(50, 50)
        Me.btn_return.TabIndex = 133
        Me.btn_return.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Image = Global.PAW.My.Resources.Resources.icons8_save_close_50
        Me.btn_save.Location = New System.Drawing.Point(68, 491)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(50, 50)
        Me.btn_save.TabIndex = 131
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'Track_del
        '
        Me.Track_del.FlatAppearance.BorderSize = 0
        Me.Track_del.Image = Global.PAW.My.Resources.Resources.icons8_delete_bin_40
        Me.Track_del.Location = New System.Drawing.Point(662, 370)
        Me.Track_del.Name = "Track_del"
        Me.Track_del.Size = New System.Drawing.Size(50, 50)
        Me.Track_del.TabIndex = 134
        Me.Track_del.UseVisualStyleBackColor = True
        '
        'frm_Edit
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.CancelButton = Me.btn_return
        Me.ClientSize = New System.Drawing.Size(782, 553)
        Me.Controls.Add(Me.Track_del)
        Me.Controls.Add(Me.Attach_del)
        Me.Controls.Add(Me.btn_return)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.TrackList)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.EndYear)
        Me.Controls.Add(Me.EndMonth)
        Me.Controls.Add(Me.EndDay)
        Me.Controls.Add(Me.EndWorkCHB)
        Me.Controls.Add(Me.TrackCHB)
        Me.Controls.Add(Me.TrackYear)
        Me.Controls.Add(Me.TrackMonth)
        Me.Controls.Add(Me.TrackDay)
        Me.Controls.Add(Me.AttachmentsList)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PeopleList)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.WorkDesc)
        Me.Controls.Add(Me.WorkTitle)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("B Kamran", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_Edit"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "برنامه ریزی کارهای اداری / ویرایش کار"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WorkDesc As TextBox
    Friend WithEvents WorkTitle As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PeopleList As CheckedListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents AttachmentsList As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TrackCHB As CheckBox
    Friend WithEvents TrackYear As TextBox
    Friend WithEvents TrackMonth As TextBox
    Friend WithEvents TrackDay As TextBox
    Friend WithEvents EndWorkCHB As CheckBox
    Friend WithEvents EndYear As TextBox
    Friend WithEvents EndMonth As TextBox
    Friend WithEvents EndDay As TextBox
    Friend WithEvents TrackList As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Attach_del As Button
    Friend WithEvents btn_return As Button
    Friend WithEvents btn_save As Button
    Friend WithEvents Track_del As Button
End Class
