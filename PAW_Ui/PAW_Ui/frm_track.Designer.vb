<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_track
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_refresh = New System.Windows.Forms.Button()
        Me.btn_home = New System.Windows.Forms.Button()
        Me.WorksList = New System.Windows.Forms.ListBox()
        Me.btn_attach_del = New System.Windows.Forms.Button()
        Me.btn_attach = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.AttachmentsList = New System.Windows.Forms.ListBox()
        Me.txt_desc = New System.Windows.Forms.TextBox()
        Me.txt_title = New System.Windows.Forms.TextBox()
        Me.txt_year = New System.Windows.Forms.TextBox()
        Me.txt_month = New System.Windows.Forms.TextBox()
        Me.txt_day = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("B Koodak", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.Location = New System.Drawing.Point(822, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 28)
        Me.Label3.TabIndex = 159
        Me.Label3.Text = "شرح پیگیری"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("B Koodak", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.Location = New System.Drawing.Point(822, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 28)
        Me.Label2.TabIndex = 160
        Me.Label2.Text = "عنوان کار"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("B Koodak", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.Location = New System.Drawing.Point(822, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 28)
        Me.Label1.TabIndex = 158
        Me.Label1.Text = "تاریخ پیگیری"
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
        Me.Panel1.TabIndex = 157
        '
        'btn_save
        '
        Me.btn_save.Image = Global.PAW_Ui.My.Resources.Resources.save_64px
        Me.btn_save.Location = New System.Drawing.Point(174, 13)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(72, 72)
        Me.btn_save.TabIndex = 3
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_refresh
        '
        Me.btn_refresh.Image = Global.PAW_Ui.My.Resources.Resources.repeat_64px
        Me.btn_refresh.Location = New System.Drawing.Point(96, 13)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(72, 72)
        Me.btn_refresh.TabIndex = 4
        Me.btn_refresh.UseVisualStyleBackColor = True
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
        'WorksList
        '
        Me.WorksList.BackColor = System.Drawing.Color.LightGreen
        Me.WorksList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WorksList.FormattingEnabled = True
        Me.WorksList.HorizontalScrollbar = True
        Me.WorksList.IntegralHeight = False
        Me.WorksList.ItemHeight = 28
        Me.WorksList.Location = New System.Drawing.Point(90, 117)
        Me.WorksList.Name = "WorksList"
        Me.WorksList.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.WorksList.Size = New System.Drawing.Size(376, 465)
        Me.WorksList.TabIndex = 187
        '
        'btn_attach_del
        '
        Me.btn_attach_del.Image = Global.PAW_Ui.My.Resources.Resources.delete_30px
        Me.btn_attach_del.Location = New System.Drawing.Point(516, 308)
        Me.btn_attach_del.Name = "btn_attach_del"
        Me.btn_attach_del.Size = New System.Drawing.Size(42, 42)
        Me.btn_attach_del.TabIndex = 2
        Me.btn_attach_del.UseVisualStyleBackColor = True
        '
        'btn_attach
        '
        Me.btn_attach.Image = Global.PAW_Ui.My.Resources.Resources.attach_30px
        Me.btn_attach.Location = New System.Drawing.Point(564, 308)
        Me.btn_attach.Name = "btn_attach"
        Me.btn_attach.Size = New System.Drawing.Size(42, 42)
        Me.btn_attach.TabIndex = 1
        Me.btn_attach.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.LightGray
        Me.Label5.Location = New System.Drawing.Point(612, 308)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(204, 42)
        Me.Label5.TabIndex = 184
        Me.Label5.Text = "پیوست"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AttachmentsList
        '
        Me.AttachmentsList.BackColor = System.Drawing.Color.LightGreen
        Me.AttachmentsList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AttachmentsList.FormattingEnabled = True
        Me.AttachmentsList.HorizontalScrollbar = True
        Me.AttachmentsList.ItemHeight = 28
        Me.AttachmentsList.Items.AddRange(New Object() {"پیوست 1", "پیوست 2", "پیوست 3"})
        Me.AttachmentsList.Location = New System.Drawing.Point(516, 356)
        Me.AttachmentsList.Name = "AttachmentsList"
        Me.AttachmentsList.Size = New System.Drawing.Size(300, 226)
        Me.AttachmentsList.TabIndex = 182
        '
        'txt_desc
        '
        Me.txt_desc.BackColor = System.Drawing.Color.LightGreen
        Me.txt_desc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_desc.Font = New System.Drawing.Font("B Koodak", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txt_desc.Location = New System.Drawing.Point(516, 117)
        Me.txt_desc.MaxLength = 255
        Me.txt_desc.Multiline = True
        Me.txt_desc.Name = "txt_desc"
        Me.txt_desc.Size = New System.Drawing.Size(300, 185)
        Me.txt_desc.TabIndex = 0
        '
        'txt_title
        '
        Me.txt_title.BackColor = System.Drawing.Color.LightGreen
        Me.txt_title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_title.Enabled = False
        Me.txt_title.Font = New System.Drawing.Font("B Koodak", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txt_title.Location = New System.Drawing.Point(516, 75)
        Me.txt_title.MaxLength = 100
        Me.txt_title.Name = "txt_title"
        Me.txt_title.Size = New System.Drawing.Size(300, 35)
        Me.txt_title.TabIndex = 180
        '
        'txt_year
        '
        Me.txt_year.BackColor = System.Drawing.Color.LightGreen
        Me.txt_year.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_year.Font = New System.Drawing.Font("B Koodak", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txt_year.Location = New System.Drawing.Point(648, 34)
        Me.txt_year.MaxLength = 4
        Me.txt_year.Name = "txt_year"
        Me.txt_year.Size = New System.Drawing.Size(78, 35)
        Me.txt_year.TabIndex = 179
        Me.txt_year.Text = "1400"
        Me.txt_year.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_month
        '
        Me.txt_month.BackColor = System.Drawing.Color.LightGreen
        Me.txt_month.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_month.Font = New System.Drawing.Font("B Koodak", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txt_month.Location = New System.Drawing.Point(732, 34)
        Me.txt_month.MaxLength = 2
        Me.txt_month.Name = "txt_month"
        Me.txt_month.Size = New System.Drawing.Size(39, 35)
        Me.txt_month.TabIndex = 178
        Me.txt_month.Text = "04"
        Me.txt_month.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_day
        '
        Me.txt_day.BackColor = System.Drawing.Color.LightGreen
        Me.txt_day.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_day.Font = New System.Drawing.Font("B Koodak", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txt_day.Location = New System.Drawing.Point(777, 34)
        Me.txt_day.MaxLength = 2
        Me.txt_day.Name = "txt_day"
        Me.txt_day.Size = New System.Drawing.Size(39, 35)
        Me.txt_day.TabIndex = 177
        Me.txt_day.Text = "05"
        Me.txt_day.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.LightGray
        Me.Label4.Location = New System.Drawing.Point(90, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(376, 35)
        Me.Label4.TabIndex = 189
        Me.Label4.Text = "پیگیری های قبلی"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frm_track
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(990, 704)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.WorksList)
        Me.Controls.Add(Me.btn_attach_del)
        Me.Controls.Add(Me.btn_attach)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.AttachmentsList)
        Me.Controls.Add(Me.txt_desc)
        Me.Controls.Add(Me.txt_title)
        Me.Controls.Add(Me.txt_year)
        Me.Controls.Add(Me.txt_month)
        Me.Controls.Add(Me.txt_day)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("B Koodak", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_track"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_save As Button
    Friend WithEvents btn_refresh As Button
    Friend WithEvents btn_home As Button
    Friend WithEvents WorksList As ListBox
    Friend WithEvents btn_attach_del As Button
    Friend WithEvents btn_attach As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents AttachmentsList As ListBox
    Friend WithEvents txt_desc As TextBox
    Friend WithEvents txt_title As TextBox
    Friend WithEvents txt_year As TextBox
    Friend WithEvents txt_month As TextBox
    Friend WithEvents txt_day As TextBox
    Friend WithEvents Label4 As Label
End Class
