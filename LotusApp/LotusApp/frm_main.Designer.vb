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
        Me.panel_title = New System.Windows.Forms.Panel()
        Me.lbl_lotus_name = New System.Windows.Forms.Label()
        Me.btn_min = New System.Windows.Forms.Button()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.panel_menu = New System.Windows.Forms.Panel()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panel_status = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panel_main = New System.Windows.Forms.Panel()
        Me.panel_title.SuspendLayout()
        Me.panel_menu.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_status.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel_title
        '
        Me.panel_title.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.panel_title.Controls.Add(Me.lbl_lotus_name)
        Me.panel_title.Controls.Add(Me.btn_min)
        Me.panel_title.Controls.Add(Me.btn_close)
        Me.panel_title.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_title.Location = New System.Drawing.Point(0, 0)
        Me.panel_title.Name = "panel_title"
        Me.panel_title.Size = New System.Drawing.Size(1020, 43)
        Me.panel_title.TabIndex = 0
        '
        'lbl_lotus_name
        '
        Me.lbl_lotus_name.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.lbl_lotus_name.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_lotus_name.Font = New System.Drawing.Font("B Zar", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbl_lotus_name.ForeColor = System.Drawing.Color.White
        Me.lbl_lotus_name.Location = New System.Drawing.Point(82, 0)
        Me.lbl_lotus_name.Name = "lbl_lotus_name"
        Me.lbl_lotus_name.Size = New System.Drawing.Size(938, 43)
        Me.lbl_lotus_name.TabIndex = 0
        Me.lbl_lotus_name.Text = "هلدینگ لوتوس"
        Me.lbl_lotus_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_min
        '
        Me.btn_min.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btn_min.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_min.FlatAppearance.BorderSize = 0
        Me.btn_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_min.Image = Global.LotusApp.My.Resources.Resources.minus
        Me.btn_min.Location = New System.Drawing.Point(41, 0)
        Me.btn_min.Name = "btn_min"
        Me.btn_min.Size = New System.Drawing.Size(41, 43)
        Me.btn_min.TabIndex = 2
        Me.btn_min.UseVisualStyleBackColor = False
        '
        'btn_close
        '
        Me.btn_close.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btn_close.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_close.FlatAppearance.BorderSize = 0
        Me.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_close.Image = Global.LotusApp.My.Resources.Resources.cross
        Me.btn_close.Location = New System.Drawing.Point(0, 0)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(41, 43)
        Me.btn_close.TabIndex = 1
        Me.btn_close.UseVisualStyleBackColor = False
        '
        'panel_menu
        '
        Me.panel_menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.panel_menu.Controls.Add(Me.Button8)
        Me.panel_menu.Controls.Add(Me.Button7)
        Me.panel_menu.Controls.Add(Me.Button6)
        Me.panel_menu.Controls.Add(Me.Button5)
        Me.panel_menu.Controls.Add(Me.Button4)
        Me.panel_menu.Controls.Add(Me.Button3)
        Me.panel_menu.Controls.Add(Me.Button2)
        Me.panel_menu.Controls.Add(Me.Button1)
        Me.panel_menu.Controls.Add(Me.Label7)
        Me.panel_menu.Controls.Add(Me.PictureBox1)
        Me.panel_menu.Dock = System.Windows.Forms.DockStyle.Right
        Me.panel_menu.Location = New System.Drawing.Point(1020, 0)
        Me.panel_menu.Name = "panel_menu"
        Me.panel_menu.Size = New System.Drawing.Size(164, 761)
        Me.panel_menu.TabIndex = 2
        '
        'Button8
        '
        Me.Button8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("B Zar", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.White
        Me.Button8.Location = New System.Drawing.Point(0, 648)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(164, 81)
        Me.Button8.TabIndex = 9
        Me.Button8.Text = "خروج"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("B Zar", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.White
        Me.Button7.Location = New System.Drawing.Point(0, 583)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(164, 65)
        Me.Button7.TabIndex = 8
        Me.Button7.Text = "تنظیمات"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("B Zar", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(0, 518)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(164, 65)
        Me.Button6.TabIndex = 7
        Me.Button6.Text = "گزارشات"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("B Zar", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(0, 453)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(164, 65)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "سئو"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("B Zar", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(0, 388)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(164, 65)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "مالی"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("B Zar", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(0, 323)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(164, 65)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "پیشگامان"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("B Zar", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(0, 258)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(164, 65)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "هوم لوتوس"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("B Zar", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(0, 193)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(164, 65)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "ابنیه گستر"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label7.Location = New System.Drawing.Point(0, 156)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(164, 37)
        Me.Label7.TabIndex = 10
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = Global.LotusApp.My.Resources.Resources.Logo
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(164, 156)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'panel_status
        '
        Me.panel_status.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.panel_status.Controls.Add(Me.Label6)
        Me.panel_status.Controls.Add(Me.Label5)
        Me.panel_status.Controls.Add(Me.Label4)
        Me.panel_status.Controls.Add(Me.Label3)
        Me.panel_status.Controls.Add(Me.Label2)
        Me.panel_status.Controls.Add(Me.Label1)
        Me.panel_status.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel_status.Location = New System.Drawing.Point(0, 729)
        Me.panel_status.Name = "panel_status"
        Me.panel_status.Size = New System.Drawing.Size(1020, 32)
        Me.panel_status.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(197, 32)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Powered by: SamahTech"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label5.Font = New System.Drawing.Font("B Zar", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(483, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 32)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "1400/09/18"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label4.Font = New System.Drawing.Font("B Zar", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(603, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 32)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "چهارشنبه"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label3.Font = New System.Drawing.Font("B Zar", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(690, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 32)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "تاریخ روز"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label2.Font = New System.Drawing.Font("B Zar", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(783, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(161, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "کاربر فعال"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label1.Font = New System.Drawing.Font("B Zar", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(944, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "کاربر فعال"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panel_main
        '
        Me.panel_main.BackColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.panel_main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel_main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_main.Location = New System.Drawing.Point(0, 43)
        Me.panel_main.Name = "panel_main"
        Me.panel_main.Size = New System.Drawing.Size(1020, 686)
        Me.panel_main.TabIndex = 4
        '
        'frm_main
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1184, 761)
        Me.ControlBox = False
        Me.Controls.Add(Me.panel_main)
        Me.Controls.Add(Me.panel_status)
        Me.Controls.Add(Me.panel_title)
        Me.Controls.Add(Me.panel_menu)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("B Zar", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_main"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.panel_title.ResumeLayout(False)
        Me.panel_menu.ResumeLayout(False)
        Me.panel_menu.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_status.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panel_title As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbl_lotus_name As Label
    Friend WithEvents panel_menu As Panel
    Friend WithEvents btn_close As Button
    Friend WithEvents btn_min As Button
    Friend WithEvents panel_status As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents panel_main As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label7 As Label
End Class
