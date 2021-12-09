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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_main))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.btn_reports = New System.Windows.Forms.Button()
        Me.btn_notes = New System.Windows.Forms.Button()
        Me.btn_users = New System.Windows.Forms.Button()
        Me.btn_msg = New System.Windows.Forms.Button()
        Me.btn_track = New System.Windows.Forms.Button()
        Me.btn_find_edit = New System.Windows.Forms.Button()
        Me.btn_new_work = New System.Windows.Forms.Button()
        Me.lbl_user = New System.Windows.Forms.Label()
        Me.pic_user = New System.Windows.Forms.PictureBox()
        Me.Panel_main = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btn_min = New System.Windows.Forms.Button()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.panel_edit = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.pic_user, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btn_exit)
        Me.Panel1.Controls.Add(Me.btn_reports)
        Me.Panel1.Controls.Add(Me.btn_notes)
        Me.Panel1.Controls.Add(Me.btn_users)
        Me.Panel1.Controls.Add(Me.btn_msg)
        Me.Panel1.Controls.Add(Me.btn_track)
        Me.Panel1.Controls.Add(Me.btn_find_edit)
        Me.Panel1.Controls.Add(Me.btn_new_work)
        Me.Panel1.Controls.Add(Me.lbl_user)
        Me.Panel1.Controls.Add(Me.pic_user)
        Me.Panel1.Location = New System.Drawing.Point(998, 42)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 704)
        Me.Panel1.TabIndex = 0
        '
        'btn_exit
        '
        Me.btn_exit.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_exit.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.btn_exit.FlatAppearance.BorderSize = 0
        Me.btn_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed
        Me.btn_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose
        Me.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_exit.Font = New System.Drawing.Font("B Koodak", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btn_exit.ForeColor = System.Drawing.Color.Navy
        Me.btn_exit.Image = Global.PAW_Ui.My.Resources.Resources.shutdown_64px
        Me.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_exit.Location = New System.Drawing.Point(0, 637)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(198, 64)
        Me.btn_exit.TabIndex = 12
        Me.btn_exit.Text = "خروج"
        Me.btn_exit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'btn_reports
        '
        Me.btn_reports.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_reports.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.btn_reports.FlatAppearance.BorderSize = 0
        Me.btn_reports.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btn_reports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose
        Me.btn_reports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_reports.Font = New System.Drawing.Font("B Koodak", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btn_reports.Image = Global.PAW_Ui.My.Resources.Resources.business_report_64px
        Me.btn_reports.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_reports.Location = New System.Drawing.Point(0, 573)
        Me.btn_reports.Name = "btn_reports"
        Me.btn_reports.Size = New System.Drawing.Size(198, 64)
        Me.btn_reports.TabIndex = 11
        Me.btn_reports.Text = "گزارشات"
        Me.btn_reports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_reports.UseVisualStyleBackColor = True
        '
        'btn_notes
        '
        Me.btn_notes.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_notes.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.btn_notes.FlatAppearance.BorderSize = 0
        Me.btn_notes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btn_notes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose
        Me.btn_notes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_notes.Font = New System.Drawing.Font("B Koodak", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btn_notes.Image = Global.PAW_Ui.My.Resources.Resources.calendar_64px
        Me.btn_notes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_notes.Location = New System.Drawing.Point(0, 509)
        Me.btn_notes.Name = "btn_notes"
        Me.btn_notes.Size = New System.Drawing.Size(198, 64)
        Me.btn_notes.TabIndex = 10
        Me.btn_notes.Text = "تقویم / یادداشت"
        Me.btn_notes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_notes.UseVisualStyleBackColor = True
        '
        'btn_users
        '
        Me.btn_users.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_users.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.btn_users.FlatAppearance.BorderSize = 0
        Me.btn_users.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btn_users.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose
        Me.btn_users.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_users.Font = New System.Drawing.Font("B Koodak", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btn_users.Image = Global.PAW_Ui.My.Resources.Resources.user_64px
        Me.btn_users.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_users.Location = New System.Drawing.Point(0, 445)
        Me.btn_users.Name = "btn_users"
        Me.btn_users.Size = New System.Drawing.Size(198, 64)
        Me.btn_users.TabIndex = 8
        Me.btn_users.Text = "اطلاعات کاربران"
        Me.btn_users.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_users.UseVisualStyleBackColor = True
        '
        'btn_msg
        '
        Me.btn_msg.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_msg.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.btn_msg.FlatAppearance.BorderSize = 0
        Me.btn_msg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btn_msg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose
        Me.btn_msg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_msg.Font = New System.Drawing.Font("B Koodak", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btn_msg.Image = Global.PAW_Ui.My.Resources.Resources.email_64px
        Me.btn_msg.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_msg.Location = New System.Drawing.Point(0, 381)
        Me.btn_msg.Name = "btn_msg"
        Me.btn_msg.Size = New System.Drawing.Size(198, 64)
        Me.btn_msg.TabIndex = 7
        Me.btn_msg.Text = "ارسال / دریافت پیام"
        Me.btn_msg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_msg.UseVisualStyleBackColor = True
        '
        'btn_track
        '
        Me.btn_track.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_track.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.btn_track.FlatAppearance.BorderSize = 0
        Me.btn_track.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btn_track.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose
        Me.btn_track.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_track.Font = New System.Drawing.Font("B Koodak", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btn_track.Image = Global.PAW_Ui.My.Resources.Resources.edit_property_64px1
        Me.btn_track.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_track.Location = New System.Drawing.Point(0, 317)
        Me.btn_track.Name = "btn_track"
        Me.btn_track.Size = New System.Drawing.Size(198, 64)
        Me.btn_track.TabIndex = 6
        Me.btn_track.Text = "ثبت پیگیری"
        Me.btn_track.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_track.UseVisualStyleBackColor = True
        '
        'btn_find_edit
        '
        Me.btn_find_edit.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_find_edit.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.btn_find_edit.FlatAppearance.BorderSize = 0
        Me.btn_find_edit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btn_find_edit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose
        Me.btn_find_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_find_edit.Font = New System.Drawing.Font("B Koodak", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btn_find_edit.Image = Global.PAW_Ui.My.Resources.Resources.search_64px
        Me.btn_find_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_find_edit.Location = New System.Drawing.Point(0, 253)
        Me.btn_find_edit.Name = "btn_find_edit"
        Me.btn_find_edit.Size = New System.Drawing.Size(198, 64)
        Me.btn_find_edit.TabIndex = 5
        Me.btn_find_edit.Text = "جستجو / ویرایش"
        Me.btn_find_edit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_find_edit.UseVisualStyleBackColor = True
        '
        'btn_new_work
        '
        Me.btn_new_work.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_new_work.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.btn_new_work.FlatAppearance.BorderSize = 0
        Me.btn_new_work.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btn_new_work.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose
        Me.btn_new_work.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_new_work.Font = New System.Drawing.Font("B Koodak", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btn_new_work.Image = Global.PAW_Ui.My.Resources.Resources.document_64px
        Me.btn_new_work.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_new_work.Location = New System.Drawing.Point(0, 189)
        Me.btn_new_work.Name = "btn_new_work"
        Me.btn_new_work.Size = New System.Drawing.Size(198, 64)
        Me.btn_new_work.TabIndex = 4
        Me.btn_new_work.Text = "تعریف کار جدید"
        Me.btn_new_work.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_new_work.UseVisualStyleBackColor = True
        '
        'lbl_user
        '
        Me.lbl_user.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_user.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_user.ForeColor = System.Drawing.Color.DarkRed
        Me.lbl_user.Location = New System.Drawing.Point(0, 149)
        Me.lbl_user.Name = "lbl_user"
        Me.lbl_user.Size = New System.Drawing.Size(198, 40)
        Me.lbl_user.TabIndex = 3
        Me.lbl_user.Text = "نام کاربر"
        Me.lbl_user.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pic_user
        '
        Me.pic_user.Dock = System.Windows.Forms.DockStyle.Top
        Me.pic_user.ErrorImage = Global.PAW_Ui.My.Resources.Resources.office_address_book_icon
        Me.pic_user.Image = Global.PAW_Ui.My.Resources.Resources.office_address_book_icon
        Me.pic_user.InitialImage = Global.PAW_Ui.My.Resources.Resources.office_address_book_icon
        Me.pic_user.Location = New System.Drawing.Point(0, 0)
        Me.pic_user.Name = "pic_user"
        Me.pic_user.Size = New System.Drawing.Size(198, 149)
        Me.pic_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_user.TabIndex = 0
        Me.pic_user.TabStop = False
        '
        'Panel_main
        '
        Me.Panel_main.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel_main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_main.Location = New System.Drawing.Point(3, 42)
        Me.Panel_main.Name = "Panel_main"
        Me.Panel_main.Size = New System.Drawing.Size(990, 704)
        Me.Panel_main.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightGray
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.btn_min)
        Me.Panel3.Controls.Add(Me.btn_close)
        Me.Panel3.Controls.Add(Me.lbl_title)
        Me.Panel3.Location = New System.Drawing.Point(3, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1194, 32)
        Me.Panel3.TabIndex = 2
        '
        'btn_min
        '
        Me.btn_min.BackColor = System.Drawing.Color.LightGray
        Me.btn_min.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_min.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btn_min.FlatAppearance.BorderSize = 0
        Me.btn_min.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btn_min.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btn_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_min.Image = Global.PAW_Ui.My.Resources.Resources.minus_30px
        Me.btn_min.Location = New System.Drawing.Point(1128, 0)
        Me.btn_min.Name = "btn_min"
        Me.btn_min.Size = New System.Drawing.Size(32, 30)
        Me.btn_min.TabIndex = 3
        Me.btn_min.UseVisualStyleBackColor = False
        '
        'btn_close
        '
        Me.btn_close.BackColor = System.Drawing.Color.LightGray
        Me.btn_close.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_close.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btn_close.FlatAppearance.BorderSize = 0
        Me.btn_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_close.Image = Global.PAW_Ui.My.Resources.Resources.cancel_30px
        Me.btn_close.Location = New System.Drawing.Point(1160, 0)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(32, 30)
        Me.btn_close.TabIndex = 0
        Me.btn_close.UseVisualStyleBackColor = False
        '
        'lbl_title
        '
        Me.lbl_title.Dock = System.Windows.Forms.DockStyle.Left
        Me.lbl_title.ForeColor = System.Drawing.Color.DarkRed
        Me.lbl_title.Location = New System.Drawing.Point(0, 0)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(1122, 30)
        Me.lbl_title.TabIndex = 2
        Me.lbl_title.Text = "برنامه ریزی کارهای اداری"
        Me.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panel_edit
        '
        Me.panel_edit.BackColor = System.Drawing.Color.WhiteSmoke
        Me.panel_edit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel_edit.Location = New System.Drawing.Point(3, 42)
        Me.panel_edit.Name = "panel_edit"
        Me.panel_edit.Size = New System.Drawing.Size(990, 704)
        Me.panel_edit.TabIndex = 3
        Me.panel_edit.Visible = False
        '
        'frm_main
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1200, 750)
        Me.Controls.Add(Me.panel_edit)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel_main)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("B Koodak", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Name = "frm_main"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TransparencyKey = System.Drawing.Color.White
        Me.Panel1.ResumeLayout(False)
        CType(Me.pic_user, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel_main As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lbl_user As Label
    Friend WithEvents pic_user As PictureBox
    Friend WithEvents lbl_title As Label
    Friend WithEvents btn_new_work As Button
    Friend WithEvents btn_msg As Button
    Friend WithEvents btn_track As Button
    Friend WithEvents btn_find_edit As Button
    Friend WithEvents btn_users As Button
    Friend WithEvents btn_notes As Button
    Friend WithEvents btn_exit As Button
    Friend WithEvents btn_reports As Button
    Friend WithEvents btn_close As Button
    Friend WithEvents btn_min As Button
    Friend WithEvents panel_edit As Panel
End Class
