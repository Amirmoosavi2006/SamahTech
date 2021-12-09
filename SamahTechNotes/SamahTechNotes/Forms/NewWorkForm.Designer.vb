<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NewWorkForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewWorkForm))
        Me.NewWorkCancelBtn = New System.Windows.Forms.Button()
        Me.NewWorkSaveBtn = New System.Windows.Forms.Button()
        Me.NewWorkYearText = New System.Windows.Forms.TextBox()
        Me.NewWorkMonthText = New System.Windows.Forms.TextBox()
        Me.NewWorkDayText = New System.Windows.Forms.TextBox()
        Me.NewWorkDescText = New System.Windows.Forms.TextBox()
        Me.NewWorkTitleText = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Group2Combo = New System.Windows.Forms.ComboBox()
        Me.Group1Combo = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.AssignToChb = New System.Windows.Forms.CheckedListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'NewWorkCancelBtn
        '
        Me.NewWorkCancelBtn.FlatAppearance.BorderSize = 0
        Me.NewWorkCancelBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tomato
        Me.NewWorkCancelBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed
        Me.NewWorkCancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NewWorkCancelBtn.Font = New System.Drawing.Font("B Zar", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NewWorkCancelBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.NewWorkCancelBtn.Image = CType(resources.GetObject("NewWorkCancelBtn.Image"), System.Drawing.Image)
        Me.NewWorkCancelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewWorkCancelBtn.Location = New System.Drawing.Point(37, 521)
        Me.NewWorkCancelBtn.Name = "NewWorkCancelBtn"
        Me.NewWorkCancelBtn.Size = New System.Drawing.Size(107, 53)
        Me.NewWorkCancelBtn.TabIndex = 18
        Me.NewWorkCancelBtn.Text = "انصراف"
        Me.NewWorkCancelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.NewWorkCancelBtn.UseVisualStyleBackColor = True
        '
        'NewWorkSaveBtn
        '
        Me.NewWorkSaveBtn.FlatAppearance.BorderSize = 0
        Me.NewWorkSaveBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LawnGreen
        Me.NewWorkSaveBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GreenYellow
        Me.NewWorkSaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NewWorkSaveBtn.Font = New System.Drawing.Font("B Zar", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NewWorkSaveBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.NewWorkSaveBtn.Image = CType(resources.GetObject("NewWorkSaveBtn.Image"), System.Drawing.Image)
        Me.NewWorkSaveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewWorkSaveBtn.Location = New System.Drawing.Point(37, 462)
        Me.NewWorkSaveBtn.Name = "NewWorkSaveBtn"
        Me.NewWorkSaveBtn.Size = New System.Drawing.Size(107, 53)
        Me.NewWorkSaveBtn.TabIndex = 19
        Me.NewWorkSaveBtn.Text = "ثبت کار"
        Me.NewWorkSaveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.NewWorkSaveBtn.UseVisualStyleBackColor = True
        '
        'NewWorkYearText
        '
        Me.NewWorkYearText.BackColor = Color.Gray 'System.Drawing.Color.PaleGreen
        Me.NewWorkYearText.Location = New System.Drawing.Point(337, 24)
        Me.NewWorkYearText.MaxLength = 4
        Me.NewWorkYearText.Name = "NewWorkYearText"
        Me.NewWorkYearText.Size = New System.Drawing.Size(68, 34)
        Me.NewWorkYearText.TabIndex = 13
        Me.NewWorkYearText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NewWorkMonthText
        '
        Me.NewWorkMonthText.BackColor = Color.Gray 'System.Drawing.Color.PaleGreen
        Me.NewWorkMonthText.Location = New System.Drawing.Point(411, 24)
        Me.NewWorkMonthText.MaxLength = 2
        Me.NewWorkMonthText.Name = "NewWorkMonthText"
        Me.NewWorkMonthText.Size = New System.Drawing.Size(34, 34)
        Me.NewWorkMonthText.TabIndex = 14
        Me.NewWorkMonthText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NewWorkDayText
        '
        Me.NewWorkDayText.BackColor = Color.Gray 'System.Drawing.Color.PaleGreen
        Me.NewWorkDayText.Location = New System.Drawing.Point(451, 24)
        Me.NewWorkDayText.MaxLength = 2
        Me.NewWorkDayText.Name = "NewWorkDayText"
        Me.NewWorkDayText.Size = New System.Drawing.Size(34, 34)
        Me.NewWorkDayText.TabIndex = 15
        Me.NewWorkDayText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NewWorkDescText
        '
        Me.NewWorkDescText.BackColor = Color.Gray 'System.Drawing.Color.PaleGreen
        Me.NewWorkDescText.Location = New System.Drawing.Point(37, 104)
        Me.NewWorkDescText.Multiline = True
        Me.NewWorkDescText.Name = "NewWorkDescText"
        Me.NewWorkDescText.Size = New System.Drawing.Size(448, 139)
        Me.NewWorkDescText.TabIndex = 12
        '
        'NewWorkTitleText
        '
        Me.NewWorkTitleText.BackColor = Color.Gray 'System.Drawing.Color.PaleGreen
        Me.NewWorkTitleText.Location = New System.Drawing.Point(37, 64)
        Me.NewWorkTitleText.Name = "NewWorkTitleText"
        Me.NewWorkTitleText.Size = New System.Drawing.Size(448, 34)
        Me.NewWorkTitleText.TabIndex = 11
        Me.NewWorkTitleText.Text = "کار جدید 1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("B Zar", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(491, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 32)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "تاریخ ثبت کار"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("B Zar", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(495, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 32)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "شرح کار"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("B Zar", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(491, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 32)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "عنوان کار"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Group2Combo)
        Me.GroupBox1.Controls.Add(Me.Group1Combo)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(175, 249)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(310, 125)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "دسته بندی کار"
        '
        'Group2Combo
        '
        Me.Group2Combo.BackColor = Color.Gray 'System.Drawing.Color.PaleGreen
        Me.Group2Combo.FormattingEnabled = True
        Me.Group2Combo.Items.AddRange(New Object() {"زیر آیتم 1", "زیر آیتم 2", "زیر آیتم 3"})
        Me.Group2Combo.Location = New System.Drawing.Point(11, 74)
        Me.Group2Combo.Name = "Group2Combo"
        Me.Group2Combo.Size = New System.Drawing.Size(217, 35)
        Me.Group2Combo.TabIndex = 25
        '
        'Group1Combo
        '
        Me.Group1Combo.BackColor = Color.Gray 'System.Drawing.Color.PaleGreen
        Me.Group1Combo.FormattingEnabled = True
        Me.Group1Combo.Items.AddRange(New Object() {"نرم افزار", "تهران من", "نقشه", "کال سنتر", "گزارش ساز"})
        Me.Group1Combo.Location = New System.Drawing.Point(11, 33)
        Me.Group1Combo.Name = "Group1Combo"
        Me.Group1Combo.Size = New System.Drawing.Size(217, 35)
        Me.Group1Combo.TabIndex = 26
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("B Zar", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(234, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 32)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "زیر گروه"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("B Zar", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(234, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 32)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "گروه"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.AssignToChb)
        Me.GroupBox2.Location = New System.Drawing.Point(175, 380)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(310, 203)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "تخصیص به"
        '
        'AssignToChb
        '
        Me.AssignToChb.BackColor = Color.Gray 'System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.AssignToChb.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AssignToChb.CheckOnClick = True
        Me.AssignToChb.Font = New System.Drawing.Font("B Zar", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.AssignToChb.FormattingEnabled = True
        Me.AssignToChb.Items.AddRange(New Object() {"نفر اول", "نفر دوم", "نفر سوم"})
        Me.AssignToChb.Location = New System.Drawing.Point(35, 36)
        Me.AssignToChb.Name = "AssignToChb"
        Me.AssignToChb.Size = New System.Drawing.Size(206, 136)
        Me.AssignToChb.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("B Zar", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(232, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 32)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "شماره کار"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = Color.Gray 'System.Drawing.Color.PaleGreen
        Me.TextBox1.Font = New System.Drawing.Font("B Zar", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Crimson
        Me.TextBox1.Location = New System.Drawing.Point(37, 24)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(189, 34)
        Me.TextBox1.TabIndex = 23
        Me.TextBox1.Text = "12345"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NewWorkForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = Color.Gray 'System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(600, 650)
        Me.ControlBox = False
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.NewWorkCancelBtn)
        Me.Controls.Add(Me.NewWorkSaveBtn)
        Me.Controls.Add(Me.NewWorkYearText)
        Me.Controls.Add(Me.NewWorkMonthText)
        Me.Controls.Add(Me.NewWorkDayText)
        Me.Controls.Add(Me.NewWorkDescText)
        Me.Controls.Add(Me.NewWorkTitleText)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("B Zar", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "NewWorkForm"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "دفترچه یادداشت سما / تعریف کار جدید"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NewWorkCancelBtn As Button
    Friend WithEvents NewWorkSaveBtn As Button
    Friend WithEvents NewWorkYearText As TextBox
    Friend WithEvents NewWorkMonthText As TextBox
    Friend WithEvents NewWorkDayText As TextBox
    Friend WithEvents NewWorkDescText As TextBox
    Friend WithEvents NewWorkTitleText As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Group2Combo As ComboBox
    Friend WithEvents Group1Combo As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents AssignToChb As CheckedListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
End Class
