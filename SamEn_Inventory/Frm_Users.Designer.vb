<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Users
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Users))
        Me.btn_del = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_new = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_return = New System.Windows.Forms.Button()
        Me.dgv_Store = New System.Windows.Forms.DataGridView()
        Me.txt_phone = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_lname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_fname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_semat = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_wrokpalce = New System.Windows.Forms.TextBox()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        CType(Me.dgv_Store, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_del
        '
        Me.btn_del.Location = New System.Drawing.Point(12, 102)
        Me.btn_del.Name = "btn_del"
        Me.btn_del.Size = New System.Drawing.Size(168, 39)
        Me.btn_del.TabIndex = 10
        Me.btn_del.Text = "حذف"
        Me.btn_del.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Location = New System.Drawing.Point(12, 57)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(168, 39)
        Me.btn_edit.TabIndex = 9
        Me.btn_edit.Text = "ویرایش"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'btn_new
        '
        Me.btn_new.Location = New System.Drawing.Point(12, 147)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(168, 39)
        Me.btn_new.TabIndex = 11
        Me.btn_new.Text = "فرم جدید"
        Me.btn_new.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(12, 12)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(168, 39)
        Me.btn_save.TabIndex = 8
        Me.btn_save.Text = "ذخیره"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_return
        '
        Me.btn_return.Location = New System.Drawing.Point(12, 192)
        Me.btn_return.Name = "btn_return"
        Me.btn_return.Size = New System.Drawing.Size(168, 39)
        Me.btn_return.TabIndex = 12
        Me.btn_return.Text = "بازگشت"
        Me.btn_return.UseVisualStyleBackColor = True
        '
        'dgv_Store
        '
        Me.dgv_Store.AllowUserToAddRows = False
        Me.dgv_Store.AllowUserToDeleteRows = False
        Me.dgv_Store.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_Store.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("B Zar", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Store.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_Store.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("B Zar", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_Store.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_Store.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgv_Store.Location = New System.Drawing.Point(0, 241)
        Me.dgv_Store.Name = "dgv_Store"
        Me.dgv_Store.ReadOnly = True
        Me.dgv_Store.RowHeadersVisible = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgv_Store.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_Store.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Store.ShowCellErrors = False
        Me.dgv_Store.ShowEditingIcon = False
        Me.dgv_Store.ShowRowErrors = False
        Me.dgv_Store.Size = New System.Drawing.Size(800, 247)
        Me.dgv_Store.TabIndex = 18
        Me.dgv_Store.TabStop = False
        '
        'txt_phone
        '
        Me.txt_phone.Location = New System.Drawing.Point(572, 147)
        Me.txt_phone.Name = "txt_phone"
        Me.txt_phone.Size = New System.Drawing.Size(129, 34)
        Me.txt_phone.TabIndex = 4
        Me.txt_phone.Text = "مرکزی"
        Me.txt_phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(707, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 27)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "شماره تماس"
        '
        'txt_lname
        '
        Me.txt_lname.Location = New System.Drawing.Point(572, 57)
        Me.txt_lname.Name = "txt_lname"
        Me.txt_lname.Size = New System.Drawing.Size(129, 34)
        Me.txt_lname.TabIndex = 2
        Me.txt_lname.Text = "مرکزی"
        Me.txt_lname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(707, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 27)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "نام خانوادگی"
        '
        'txt_fname
        '
        Me.txt_fname.Location = New System.Drawing.Point(572, 12)
        Me.txt_fname.Name = "txt_fname"
        Me.txt_fname.Size = New System.Drawing.Size(129, 34)
        Me.txt_fname.TabIndex = 1
        Me.txt_fname.Text = "مرکزی"
        Me.txt_fname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(707, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 27)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "نام"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(707, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 27)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "سمت"
        '
        'txt_semat
        '
        Me.txt_semat.Location = New System.Drawing.Point(572, 102)
        Me.txt_semat.Name = "txt_semat"
        Me.txt_semat.Size = New System.Drawing.Size(129, 34)
        Me.txt_semat.TabIndex = 3
        Me.txt_semat.Text = "مرکزی"
        Me.txt_semat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(707, 195)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 27)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "محل خدمت"
        '
        'txt_wrokpalce
        '
        Me.txt_wrokpalce.Location = New System.Drawing.Point(572, 192)
        Me.txt_wrokpalce.Name = "txt_wrokpalce"
        Me.txt_wrokpalce.Size = New System.Drawing.Size(129, 34)
        Me.txt_wrokpalce.TabIndex = 5
        Me.txt_wrokpalce.Text = "مرکزی"
        Me.txt_wrokpalce.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_password
        '
        Me.txt_password.Location = New System.Drawing.Point(264, 123)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_password.Size = New System.Drawing.Size(184, 34)
        Me.txt_password.TabIndex = 7
        Me.txt_password.Text = "مرکزی"
        Me.txt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_password.UseSystemPasswordChar = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(454, 126)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 27)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "رمز عبور"
        '
        'txt_username
        '
        Me.txt_username.Location = New System.Drawing.Point(264, 78)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(184, 34)
        Me.txt_username.TabIndex = 6
        Me.txt_username.Text = "مرکزی"
        Me.txt_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(454, 81)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 27)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "نام کاربری"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(553, 60)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(20, 27)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "*"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(245, 81)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(20, 27)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "*"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(245, 126)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(20, 27)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "*"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(363, 163)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(85, 31)
        Me.CheckBox1.TabIndex = 27
        Me.CheckBox1.Text = "مدیر سیستم"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Frm_Users
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(800, 488)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_username)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btn_del)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.btn_new)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.btn_return)
        Me.Controls.Add(Me.dgv_Store)
        Me.Controls.Add(Me.txt_wrokpalce)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_phone)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_semat)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_lname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_fname)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Font = New System.Drawing.Font("B Zar", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Frm_Users"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "نرم افزار انبارداری سامان: فرم تعریف کاربران"
        CType(Me.dgv_Store, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_del As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_new As Button
    Friend WithEvents btn_save As Button
    Friend WithEvents btn_return As Button
    Friend WithEvents dgv_Store As DataGridView
    Friend WithEvents txt_phone As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_lname As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_fname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_semat As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_wrokpalce As TextBox
    Friend WithEvents txt_password As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_username As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents CheckBox1 As CheckBox
End Class
