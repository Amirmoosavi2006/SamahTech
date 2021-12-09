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
        Me.panel_titlebar = New System.Windows.Forms.Panel()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.btn_min = New System.Windows.Forms.Button()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.panel_sidebar = New System.Windows.Forms.Panel()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_username = New System.Windows.Forms.Label()
        Me.panel_titlebar.SuspendLayout()
        Me.panel_sidebar.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel_titlebar
        '
        Me.panel_titlebar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.panel_titlebar.Controls.Add(Me.lbl_title)
        Me.panel_titlebar.Controls.Add(Me.btn_min)
        Me.panel_titlebar.Controls.Add(Me.btn_close)
        Me.panel_titlebar.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_titlebar.Location = New System.Drawing.Point(0, 0)
        Me.panel_titlebar.Name = "panel_titlebar"
        Me.panel_titlebar.Size = New System.Drawing.Size(1065, 35)
        Me.panel_titlebar.TabIndex = 0
        '
        'lbl_title
        '
        Me.lbl_title.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_title.Font = New System.Drawing.Font("B Titr", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_title.ForeColor = System.Drawing.Color.Maroon
        Me.lbl_title.Location = New System.Drawing.Point(0, 0)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(985, 35)
        Me.lbl_title.TabIndex = 2
        Me.lbl_title.Text = "صفحه ثبت خبر مشترک سامانه ها"
        Me.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_min
        '
        Me.btn_min.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_min.FlatAppearance.BorderSize = 0
        Me.btn_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_min.Image = CType(resources.GetObject("btn_min.Image"), System.Drawing.Image)
        Me.btn_min.Location = New System.Drawing.Point(985, 0)
        Me.btn_min.Name = "btn_min"
        Me.btn_min.Size = New System.Drawing.Size(40, 35)
        Me.btn_min.TabIndex = 1
        Me.btn_min.UseVisualStyleBackColor = True
        '
        'btn_close
        '
        Me.btn_close.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_close.FlatAppearance.BorderSize = 0
        Me.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_close.Image = CType(resources.GetObject("btn_close.Image"), System.Drawing.Image)
        Me.btn_close.Location = New System.Drawing.Point(1025, 0)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(40, 35)
        Me.btn_close.TabIndex = 0
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'panel_sidebar
        '
        Me.panel_sidebar.Controls.Add(Me.Button8)
        Me.panel_sidebar.Controls.Add(Me.Button7)
        Me.panel_sidebar.Controls.Add(Me.Button6)
        Me.panel_sidebar.Controls.Add(Me.Button5)
        Me.panel_sidebar.Controls.Add(Me.Button4)
        Me.panel_sidebar.Controls.Add(Me.Button3)
        Me.panel_sidebar.Controls.Add(Me.lbl_username)
        Me.panel_sidebar.Controls.Add(Me.PictureBox1)
        Me.panel_sidebar.Dock = System.Windows.Forms.DockStyle.Right
        Me.panel_sidebar.Location = New System.Drawing.Point(1065, 0)
        Me.panel_sidebar.Name = "panel_sidebar"
        Me.panel_sidebar.Size = New System.Drawing.Size(135, 700)
        Me.panel_sidebar.TabIndex = 1
        '
        'Button8
        '
        Me.Button8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("B Lotus", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button8.ForeColor = System.Drawing.Color.White
        Me.Button8.Location = New System.Drawing.Point(0, 312)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(135, 34)
        Me.Button8.TabIndex = 6
        Me.Button8.Text = "قطع تماس"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("B Lotus", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button7.ForeColor = System.Drawing.Color.White
        Me.Button7.Location = New System.Drawing.Point(0, 278)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(135, 34)
        Me.Button7.TabIndex = 5
        Me.Button7.Text = "انتقال تماس"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("B Lotus", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(0, 244)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(135, 34)
        Me.Button6.TabIndex = 4
        Me.Button6.Text = "مزاحمت/ تماس اشتباه"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("B Lotus", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(0, 210)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(135, 34)
        Me.Button5.TabIndex = 3
        Me.Button5.Text = "راهنمایی"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("B Lotus", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(0, 176)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(135, 34)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "پیگیری"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("B Lotus", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(0, 142)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(135, 34)
        Me.Button3.TabIndex = 0
        Me.Button3.Text = "ثبت پیام"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(135, 102)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'lbl_username
        '
        Me.lbl_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_username.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_username.ForeColor = System.Drawing.Color.Yellow
        Me.lbl_username.Location = New System.Drawing.Point(0, 102)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(135, 40)
        Me.lbl_username.TabIndex = 7
        Me.lbl_username.Text = "سیدامیر موسوی"
        Me.lbl_username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frm_main
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1200, 700)
        Me.ControlBox = False
        Me.Controls.Add(Me.panel_titlebar)
        Me.Controls.Add(Me.panel_sidebar)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_main"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.panel_titlebar.ResumeLayout(False)
        Me.panel_sidebar.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panel_titlebar As Panel
    Friend WithEvents lbl_title As Label
    Friend WithEvents btn_min As Button
    Friend WithEvents btn_close As Button
    Friend WithEvents panel_sidebar As Panel
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbl_username As Label
End Class
