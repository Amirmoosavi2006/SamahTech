<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_new
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_new))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_wno = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_wtitle = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_wday = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_pyear = New System.Windows.Forms.TextBox()
        Me.txt_wyear = New System.Windows.Forms.TextBox()
        Me.txt_pmonth = New System.Windows.Forms.TextBox()
        Me.txt_wmonth = New System.Windows.Forms.TextBox()
        Me.txt_pday = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_wdesc = New System.Windows.Forms.RichTextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txt_cno = New System.Windows.Forms.TextBox()
        Me.txt_cyear = New System.Windows.Forms.TextBox()
        Me.txt_ano = New System.Windows.Forms.TextBox()
        Me.txt_cmonth = New System.Windows.Forms.TextBox()
        Me.txt_ayear = New System.Windows.Forms.TextBox()
        Me.txt_cday = New System.Windows.Forms.TextBox()
        Me.txt_amonth = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_aday = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_ctitle = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_atitle = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btn_return = New System.Windows.Forms.Button()
        Me.btn_works = New System.Windows.Forms.Button()
        Me.btn_final = New System.Windows.Forms.Button()
        Me.btn_p = New System.Windows.Forms.Button()
        Me.btn_new = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(515, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "شماره کار"
        '
        'txt_wno
        '
        Me.txt_wno.Enabled = False
        Me.txt_wno.Location = New System.Drawing.Point(396, 27)
        Me.txt_wno.MaxLength = 10
        Me.txt_wno.Name = "txt_wno"
        Me.txt_wno.Size = New System.Drawing.Size(113, 28)
        Me.txt_wno.TabIndex = 100
        Me.txt_wno.Text = "123456789"
        Me.txt_wno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(515, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "عنوان کار"
        '
        'txt_wtitle
        '
        Me.txt_wtitle.Location = New System.Drawing.Point(6, 61)
        Me.txt_wtitle.MaxLength = 100
        Me.txt_wtitle.Name = "txt_wtitle"
        Me.txt_wtitle.Size = New System.Drawing.Size(503, 28)
        Me.txt_wtitle.TabIndex = 0
        Me.txt_wtitle.Text = "عنوان عنوان عنوان"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(343, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 21)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "تاریخ ثبت"
        '
        'txt_wday
        '
        Me.txt_wday.Location = New System.Drawing.Point(307, 27)
        Me.txt_wday.MaxLength = 2
        Me.txt_wday.Name = "txt_wday"
        Me.txt_wday.Size = New System.Drawing.Size(30, 28)
        Me.txt_wday.TabIndex = 1
        Me.txt_wday.Text = "97"
        Me.txt_wday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_wno)
        Me.GroupBox1.Controls.Add(Me.txt_pyear)
        Me.GroupBox1.Controls.Add(Me.txt_wyear)
        Me.GroupBox1.Controls.Add(Me.txt_pmonth)
        Me.GroupBox1.Controls.Add(Me.txt_wmonth)
        Me.GroupBox1.Controls.Add(Me.txt_pday)
        Me.GroupBox1.Controls.Add(Me.txt_wday)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_wtitle)
        Me.GroupBox1.Location = New System.Drawing.Point(110, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(570, 110)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "تعریف کار"
        '
        'txt_pyear
        '
        Me.txt_pyear.BackColor = System.Drawing.Color.LightSkyBlue
        Me.txt_pyear.Location = New System.Drawing.Point(6, 27)
        Me.txt_pyear.MaxLength = 4
        Me.txt_pyear.Name = "txt_pyear"
        Me.txt_pyear.Size = New System.Drawing.Size(60, 28)
        Me.txt_pyear.TabIndex = 6
        Me.txt_pyear.Text = "97"
        Me.txt_pyear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_wyear
        '
        Me.txt_wyear.Location = New System.Drawing.Point(205, 27)
        Me.txt_wyear.MaxLength = 4
        Me.txt_wyear.Name = "txt_wyear"
        Me.txt_wyear.Size = New System.Drawing.Size(60, 28)
        Me.txt_wyear.TabIndex = 3
        Me.txt_wyear.Text = "97"
        Me.txt_wyear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_pmonth
        '
        Me.txt_pmonth.BackColor = System.Drawing.Color.LightSkyBlue
        Me.txt_pmonth.Location = New System.Drawing.Point(72, 27)
        Me.txt_pmonth.MaxLength = 2
        Me.txt_pmonth.Name = "txt_pmonth"
        Me.txt_pmonth.Size = New System.Drawing.Size(30, 28)
        Me.txt_pmonth.TabIndex = 5
        Me.txt_pmonth.Text = "97"
        Me.txt_pmonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_wmonth
        '
        Me.txt_wmonth.Location = New System.Drawing.Point(271, 27)
        Me.txt_wmonth.MaxLength = 2
        Me.txt_wmonth.Name = "txt_wmonth"
        Me.txt_wmonth.Size = New System.Drawing.Size(30, 28)
        Me.txt_wmonth.TabIndex = 2
        Me.txt_wmonth.Text = "97"
        Me.txt_wmonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_pday
        '
        Me.txt_pday.BackColor = System.Drawing.Color.LightSkyBlue
        Me.txt_pday.Location = New System.Drawing.Point(108, 27)
        Me.txt_pday.MaxLength = 2
        Me.txt_pday.Name = "txt_pday"
        Me.txt_pday.Size = New System.Drawing.Size(30, 28)
        Me.txt_pday.TabIndex = 4
        Me.txt_pday.Text = "97"
        Me.txt_pday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(140, 30)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 21)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "تاریخ پیگیری"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_wdesc)
        Me.GroupBox2.Location = New System.Drawing.Point(110, 128)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(570, 151)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "توضیحات"
        '
        'txt_wdesc
        '
        Me.txt_wdesc.AutoWordSelection = True
        Me.txt_wdesc.Location = New System.Drawing.Point(6, 31)
        Me.txt_wdesc.Name = "txt_wdesc"
        Me.txt_wdesc.ShowSelectionMargin = True
        Me.txt_wdesc.Size = New System.Drawing.Size(554, 100)
        Me.txt_wdesc.TabIndex = 7
        Me.txt_wdesc.Text = "شرح توضیحات کار"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txt_cno)
        Me.GroupBox3.Controls.Add(Me.txt_cyear)
        Me.GroupBox3.Controls.Add(Me.txt_ano)
        Me.GroupBox3.Controls.Add(Me.txt_cmonth)
        Me.GroupBox3.Controls.Add(Me.txt_ayear)
        Me.GroupBox3.Controls.Add(Me.txt_cday)
        Me.GroupBox3.Controls.Add(Me.txt_amonth)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.txt_aday)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.txt_ctitle)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.txt_atitle)
        Me.GroupBox3.Location = New System.Drawing.Point(110, 285)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(570, 189)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "اتوماسیون و CTS"
        '
        'txt_cno
        '
        Me.txt_cno.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_cno.Location = New System.Drawing.Point(327, 110)
        Me.txt_cno.MaxLength = 15
        Me.txt_cno.Name = "txt_cno"
        Me.txt_cno.Size = New System.Drawing.Size(134, 28)
        Me.txt_cno.TabIndex = 13
        Me.txt_cno.Text = "123456789"
        Me.txt_cno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_cyear
        '
        Me.txt_cyear.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_cyear.Location = New System.Drawing.Point(118, 110)
        Me.txt_cyear.MaxLength = 4
        Me.txt_cyear.Name = "txt_cyear"
        Me.txt_cyear.Size = New System.Drawing.Size(60, 28)
        Me.txt_cyear.TabIndex = 16
        Me.txt_cyear.Text = "97"
        Me.txt_cyear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_ano
        '
        Me.txt_ano.BackColor = System.Drawing.Color.LavenderBlush
        Me.txt_ano.Location = New System.Drawing.Point(327, 33)
        Me.txt_ano.MaxLength = 15
        Me.txt_ano.Name = "txt_ano"
        Me.txt_ano.Size = New System.Drawing.Size(134, 28)
        Me.txt_ano.TabIndex = 8
        Me.txt_ano.Text = "123456789"
        Me.txt_ano.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_cmonth
        '
        Me.txt_cmonth.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_cmonth.Location = New System.Drawing.Point(184, 110)
        Me.txt_cmonth.MaxLength = 2
        Me.txt_cmonth.Name = "txt_cmonth"
        Me.txt_cmonth.Size = New System.Drawing.Size(30, 28)
        Me.txt_cmonth.TabIndex = 15
        Me.txt_cmonth.Text = "97"
        Me.txt_cmonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_ayear
        '
        Me.txt_ayear.BackColor = System.Drawing.Color.LavenderBlush
        Me.txt_ayear.Location = New System.Drawing.Point(118, 33)
        Me.txt_ayear.MaxLength = 4
        Me.txt_ayear.Name = "txt_ayear"
        Me.txt_ayear.Size = New System.Drawing.Size(60, 28)
        Me.txt_ayear.TabIndex = 11
        Me.txt_ayear.Text = "97"
        Me.txt_ayear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_cday
        '
        Me.txt_cday.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_cday.Location = New System.Drawing.Point(220, 110)
        Me.txt_cday.MaxLength = 2
        Me.txt_cday.Name = "txt_cday"
        Me.txt_cday.Size = New System.Drawing.Size(30, 28)
        Me.txt_cday.TabIndex = 14
        Me.txt_cday.Text = "97"
        Me.txt_cday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_amonth
        '
        Me.txt_amonth.BackColor = System.Drawing.Color.LavenderBlush
        Me.txt_amonth.Location = New System.Drawing.Point(184, 33)
        Me.txt_amonth.MaxLength = 2
        Me.txt_amonth.Name = "txt_amonth"
        Me.txt_amonth.Size = New System.Drawing.Size(30, 28)
        Me.txt_amonth.TabIndex = 10
        Me.txt_amonth.Text = "97"
        Me.txt_amonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(467, 113)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 21)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "شماره نامه پشتیبانی"
        '
        'txt_aday
        '
        Me.txt_aday.BackColor = System.Drawing.Color.LavenderBlush
        Me.txt_aday.Location = New System.Drawing.Point(220, 33)
        Me.txt_aday.MaxLength = 2
        Me.txt_aday.Name = "txt_aday"
        Me.txt_aday.Size = New System.Drawing.Size(30, 28)
        Me.txt_aday.TabIndex = 9
        Me.txt_aday.Text = "97"
        Me.txt_aday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(256, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 21)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "تاریخ CTS"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(467, 36)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 21)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "شماره نامه اتوماسیون"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(467, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 21)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "عنوان نامه"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(256, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 21)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "تاریخ نامه"
        '
        'txt_ctitle
        '
        Me.txt_ctitle.BackColor = System.Drawing.Color.LemonChiffon
        Me.txt_ctitle.Location = New System.Drawing.Point(7, 144)
        Me.txt_ctitle.MaxLength = 100
        Me.txt_ctitle.Name = "txt_ctitle"
        Me.txt_ctitle.Size = New System.Drawing.Size(454, 28)
        Me.txt_ctitle.TabIndex = 17
        Me.txt_ctitle.Text = "عنوان عنوان عنوان"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(467, 70)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 21)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "عنوان نامه"
        '
        'txt_atitle
        '
        Me.txt_atitle.BackColor = System.Drawing.Color.LavenderBlush
        Me.txt_atitle.Location = New System.Drawing.Point(7, 67)
        Me.txt_atitle.MaxLength = 100
        Me.txt_atitle.Name = "txt_atitle"
        Me.txt_atitle.Size = New System.Drawing.Size(454, 28)
        Me.txt_atitle.TabIndex = 12
        Me.txt_atitle.Text = "عنوان عنوان عنوان"
        '
        'ToolTip1
        '
        Me.ToolTip1.BackColor = System.Drawing.Color.LightSalmon
        Me.ToolTip1.ForeColor = System.Drawing.Color.Black
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "دفترچه یادداشت کاری من"
        '
        'btn_return
        '
        Me.btn_return.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_return.Image = Global.My_Work.My.Resources.Resources.Small_Exit
        Me.btn_return.Location = New System.Drawing.Point(19, 406)
        Me.btn_return.Name = "btn_return"
        Me.btn_return.Size = New System.Drawing.Size(64, 64)
        Me.btn_return.TabIndex = 23
        Me.ToolTip1.SetToolTip(Me.btn_return, "خروج")
        Me.btn_return.UseVisualStyleBackColor = True
        '
        'btn_works
        '
        Me.btn_works.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_works.Image = Global.My_Work.My.Resources.Resources.Small_Calendar
        Me.btn_works.Location = New System.Drawing.Point(19, 329)
        Me.btn_works.Name = "btn_works"
        Me.btn_works.Size = New System.Drawing.Size(64, 64)
        Me.btn_works.TabIndex = 22
        Me.ToolTip1.SetToolTip(Me.btn_works, "نمایش تمامی کارهای ثبت شده")
        Me.btn_works.UseVisualStyleBackColor = True
        '
        'btn_final
        '
        Me.btn_final.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_final.Image = Global.My_Work.My.Resources.Resources.Small_Note2
        Me.btn_final.Location = New System.Drawing.Point(19, 252)
        Me.btn_final.Name = "btn_final"
        Me.btn_final.Size = New System.Drawing.Size(64, 64)
        Me.btn_final.TabIndex = 21
        Me.ToolTip1.SetToolTip(Me.btn_final, "ثبت نتیجه نهایی کار")
        Me.btn_final.UseVisualStyleBackColor = True
        '
        'btn_p
        '
        Me.btn_p.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_p.Image = Global.My_Work.My.Resources.Resources.Small_Note
        Me.btn_p.Location = New System.Drawing.Point(19, 175)
        Me.btn_p.Name = "btn_p"
        Me.btn_p.Size = New System.Drawing.Size(64, 64)
        Me.btn_p.TabIndex = 20
        Me.ToolTip1.SetToolTip(Me.btn_p, "ثبت پیگیری")
        Me.btn_p.UseVisualStyleBackColor = True
        '
        'btn_new
        '
        Me.btn_new.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_new.Image = Global.My_Work.My.Resources.Resources.Small_Undo
        Me.btn_new.Location = New System.Drawing.Point(19, 98)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(64, 64)
        Me.btn_new.TabIndex = 19
        Me.ToolTip1.SetToolTip(Me.btn_new, "ایجاد فرم جدید")
        Me.btn_new.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_save.Image = Global.My_Work.My.Resources.Resources.Small_Ok1
        Me.btn_save.Location = New System.Drawing.Point(19, 21)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(64, 64)
        Me.btn_save.TabIndex = 18
        Me.ToolTip1.SetToolTip(Me.btn_save, "دخیره کار جدید")
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'frm_new
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(703, 490)
        Me.Controls.Add(Me.btn_return)
        Me.Controls.Add(Me.btn_works)
        Me.Controls.Add(Me.btn_final)
        Me.Controls.Add(Me.btn_p)
        Me.Controls.Add(Me.btn_new)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("B Mitra", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_new"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "کار جدید من"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_wno As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_wtitle As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_wday As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_pyear As TextBox
    Friend WithEvents txt_wyear As TextBox
    Friend WithEvents txt_pmonth As TextBox
    Friend WithEvents txt_wmonth As TextBox
    Friend WithEvents txt_pday As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txt_wdesc As RichTextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txt_cno As TextBox
    Friend WithEvents txt_cyear As TextBox
    Friend WithEvents txt_ano As TextBox
    Friend WithEvents txt_cmonth As TextBox
    Friend WithEvents txt_ayear As TextBox
    Friend WithEvents txt_cday As TextBox
    Friend WithEvents txt_amonth As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_aday As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_ctitle As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_atitle As TextBox
    Friend WithEvents btn_save As Button
    Friend WithEvents btn_new As Button
    Friend WithEvents btn_p As Button
    Friend WithEvents btn_final As Button
    Friend WithEvents btn_return As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents btn_works As Button
End Class
