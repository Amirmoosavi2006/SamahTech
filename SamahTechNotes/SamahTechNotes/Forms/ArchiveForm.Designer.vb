<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ArchiveForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ArchiveForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ArchiveDGV = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.AllWorksRb = New System.Windows.Forms.RadioButton()
        Me.WorksRb = New System.Windows.Forms.RadioButton()
        Me.ArchiveRb = New System.Windows.Forms.RadioButton()
        Me.SendArchiveBtn = New System.Windows.Forms.Button()
        Me.FollowUpBtn = New System.Windows.Forms.Button()
        Me.ArchiveReturnBtn = New System.Windows.Forms.Button()
        Me.FollowUpBox = New System.Windows.Forms.GroupBox()
        Me.CancelFollowUpBtn = New System.Windows.Forms.Button()
        Me.ArchiveYearText = New System.Windows.Forms.TextBox()
        Me.ArchiveMonthText = New System.Windows.Forms.TextBox()
        Me.ArchiveDayText = New System.Windows.Forms.TextBox()
        Me.ArchiveDescText = New System.Windows.Forms.TextBox()
        Me.ArchiveTitleText = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SaveFollowUpBtn = New System.Windows.Forms.Button()
        CType(Me.ArchiveDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.FollowUpBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 618)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(600, 32)
        Me.Panel1.TabIndex = 0
        '
        'ArchiveDGV
        '
        Me.ArchiveDGV.AllowUserToAddRows = False
        Me.ArchiveDGV.AllowUserToDeleteRows = False
        Me.ArchiveDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ArchiveDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.ArchiveDGV.BackgroundColor = System.Drawing.Color.RoyalBlue
        Me.ArchiveDGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ArchiveDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ArchiveDGV.GridColor = System.Drawing.Color.Black
        Me.ArchiveDGV.Location = New System.Drawing.Point(12, 64)
        Me.ArchiveDGV.MultiSelect = False
        Me.ArchiveDGV.Name = "ArchiveDGV"
        Me.ArchiveDGV.RowHeadersVisible = False
        Me.ArchiveDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ArchiveDGV.ShowCellErrors = False
        Me.ArchiveDGV.ShowCellToolTips = False
        Me.ArchiveDGV.ShowEditingIcon = False
        Me.ArchiveDGV.ShowRowErrors = False
        Me.ArchiveDGV.Size = New System.Drawing.Size(576, 298)
        Me.ArchiveDGV.TabIndex = 23
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.AllWorksRb)
        Me.GroupBox1.Controls.Add(Me.WorksRb)
        Me.GroupBox1.Controls.Add(Me.ArchiveRb)
        Me.GroupBox1.Location = New System.Drawing.Point(262, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(326, 56)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        '
        'AllWorksRb
        '
        Me.AllWorksRb.AutoSize = True
        Me.AllWorksRb.Location = New System.Drawing.Point(35, 19)
        Me.AllWorksRb.Name = "AllWorksRb"
        Me.AllWorksRb.Size = New System.Drawing.Size(79, 31)
        Me.AllWorksRb.TabIndex = 25
        Me.AllWorksRb.Text = "همه کارها"
        Me.AllWorksRb.UseVisualStyleBackColor = True
        '
        'WorksRb
        '
        Me.WorksRb.AutoSize = True
        Me.WorksRb.Location = New System.Drawing.Point(120, 19)
        Me.WorksRb.Name = "WorksRb"
        Me.WorksRb.Size = New System.Drawing.Size(98, 31)
        Me.WorksRb.TabIndex = 25
        Me.WorksRb.Text = "کارهای جاری"
        Me.WorksRb.UseVisualStyleBackColor = True
        '
        'ArchiveRb
        '
        Me.ArchiveRb.AutoSize = True
        Me.ArchiveRb.Checked = True
        Me.ArchiveRb.Location = New System.Drawing.Point(224, 19)
        Me.ArchiveRb.Name = "ArchiveRb"
        Me.ArchiveRb.Size = New System.Drawing.Size(76, 31)
        Me.ArchiveRb.TabIndex = 25
        Me.ArchiveRb.TabStop = True
        Me.ArchiveRb.Text = "بایگانی ها"
        Me.ArchiveRb.UseVisualStyleBackColor = True
        '
        'SendArchiveBtn
        '
        Me.SendArchiveBtn.FlatAppearance.BorderSize = 0
        Me.SendArchiveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SendArchiveBtn.Font = New System.Drawing.Font("B Zar", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.SendArchiveBtn.ForeColor = System.Drawing.Color.Black
        Me.SendArchiveBtn.Image = CType(resources.GetObject("SendArchiveBtn.Image"), System.Drawing.Image)
        Me.SendArchiveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SendArchiveBtn.Location = New System.Drawing.Point(441, 368)
        Me.SendArchiveBtn.Name = "SendArchiveBtn"
        Me.SendArchiveBtn.Size = New System.Drawing.Size(147, 43)
        Me.SendArchiveBtn.TabIndex = 26
        Me.SendArchiveBtn.Text = "ارسال به بایگانی"
        Me.SendArchiveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SendArchiveBtn.UseVisualStyleBackColor = True
        '
        'FollowUpBtn
        '
        Me.FollowUpBtn.FlatAppearance.BorderSize = 0
        Me.FollowUpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FollowUpBtn.Font = New System.Drawing.Font("B Zar", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FollowUpBtn.ForeColor = System.Drawing.Color.Black
        Me.FollowUpBtn.Image = CType(resources.GetObject("FollowUpBtn.Image"), System.Drawing.Image)
        Me.FollowUpBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.FollowUpBtn.Location = New System.Drawing.Point(315, 368)
        Me.FollowUpBtn.Name = "FollowUpBtn"
        Me.FollowUpBtn.Size = New System.Drawing.Size(120, 43)
        Me.FollowUpBtn.TabIndex = 26
        Me.FollowUpBtn.Text = "ثبت پیگیری"
        Me.FollowUpBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.FollowUpBtn.UseVisualStyleBackColor = True
        '
        'ArchiveReturnBtn
        '
        Me.ArchiveReturnBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ArchiveReturnBtn.FlatAppearance.BorderSize = 0
        Me.ArchiveReturnBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tomato
        Me.ArchiveReturnBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed
        Me.ArchiveReturnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ArchiveReturnBtn.Font = New System.Drawing.Font("B Zar", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ArchiveReturnBtn.ForeColor = System.Drawing.Color.Black
        Me.ArchiveReturnBtn.Image = CType(resources.GetObject("ArchiveReturnBtn.Image"), System.Drawing.Image)
        Me.ArchiveReturnBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ArchiveReturnBtn.Location = New System.Drawing.Point(12, 368)
        Me.ArchiveReturnBtn.Name = "ArchiveReturnBtn"
        Me.ArchiveReturnBtn.Size = New System.Drawing.Size(103, 43)
        Me.ArchiveReturnBtn.TabIndex = 27
        Me.ArchiveReturnBtn.Text = "بازگشت"
        Me.ArchiveReturnBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ArchiveReturnBtn.UseVisualStyleBackColor = True
        '
        'FollowUpBox
        '
        Me.FollowUpBox.Controls.Add(Me.SaveFollowUpBtn)
        Me.FollowUpBox.Controls.Add(Me.CancelFollowUpBtn)
        Me.FollowUpBox.Controls.Add(Me.ArchiveYearText)
        Me.FollowUpBox.Controls.Add(Me.ArchiveMonthText)
        Me.FollowUpBox.Controls.Add(Me.ArchiveDayText)
        Me.FollowUpBox.Controls.Add(Me.ArchiveDescText)
        Me.FollowUpBox.Controls.Add(Me.ArchiveTitleText)
        Me.FollowUpBox.Controls.Add(Me.Label3)
        Me.FollowUpBox.Controls.Add(Me.Label2)
        Me.FollowUpBox.Controls.Add(Me.Label1)
        Me.FollowUpBox.Enabled = False
        Me.FollowUpBox.Location = New System.Drawing.Point(12, 417)
        Me.FollowUpBox.Name = "FollowUpBox"
        Me.FollowUpBox.Size = New System.Drawing.Size(576, 195)
        Me.FollowUpBox.TabIndex = 28
        Me.FollowUpBox.TabStop = False
        Me.FollowUpBox.Text = "پیگیری"
        '
        'CancelFollowUpBtn
        '
        Me.CancelFollowUpBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.CancelFollowUpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelFollowUpBtn.Font = New System.Drawing.Font("B Zar", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.CancelFollowUpBtn.ForeColor = System.Drawing.Color.Black
        Me.CancelFollowUpBtn.Image = CType(resources.GetObject("CancelFollowUpBtn.Image"), System.Drawing.Image)
        Me.CancelFollowUpBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CancelFollowUpBtn.Location = New System.Drawing.Point(10, 134)
        Me.CancelFollowUpBtn.Name = "CancelFollowUpBtn"
        Me.CancelFollowUpBtn.Size = New System.Drawing.Size(43, 43)
        Me.CancelFollowUpBtn.TabIndex = 37
        Me.CancelFollowUpBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CancelFollowUpBtn.UseVisualStyleBackColor = True
        '
        'ArchiveYearText
        '
        Me.ArchiveYearText.BackColor = Color.Gray  'System.Drawing.Color.RoyalBlue
        Me.ArchiveYearText.ForeColor = System.Drawing.Color.White
        Me.ArchiveYearText.Location = New System.Drawing.Point(328, 36)
        Me.ArchiveYearText.MaxLength = 4
        Me.ArchiveYearText.Name = "ArchiveYearText"
        Me.ArchiveYearText.Size = New System.Drawing.Size(68, 34)
        Me.ArchiveYearText.TabIndex = 34
        Me.ArchiveYearText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ArchiveMonthText
        '
        Me.ArchiveMonthText.BackColor = Color.Gray 'System.Drawing.Color.RoyalBlue
        Me.ArchiveMonthText.ForeColor = System.Drawing.Color.White
        Me.ArchiveMonthText.Location = New System.Drawing.Point(402, 36)
        Me.ArchiveMonthText.MaxLength = 2
        Me.ArchiveMonthText.Name = "ArchiveMonthText"
        Me.ArchiveMonthText.Size = New System.Drawing.Size(34, 34)
        Me.ArchiveMonthText.TabIndex = 35
        Me.ArchiveMonthText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ArchiveDayText
        '
        Me.ArchiveDayText.BackColor = Color.Gray 'System.Drawing.Color.RoyalBlue
        Me.ArchiveDayText.ForeColor = System.Drawing.Color.White
        Me.ArchiveDayText.Location = New System.Drawing.Point(442, 36)
        Me.ArchiveDayText.MaxLength = 2
        Me.ArchiveDayText.Name = "ArchiveDayText"
        Me.ArchiveDayText.Size = New System.Drawing.Size(34, 34)
        Me.ArchiveDayText.TabIndex = 36
        Me.ArchiveDayText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ArchiveDescText
        '
        Me.ArchiveDescText.BackColor = Color.Gray 'System.Drawing.Color.RoyalBlue
        Me.ArchiveDescText.ForeColor = System.Drawing.Color.White
        Me.ArchiveDescText.Location = New System.Drawing.Point(59, 76)
        Me.ArchiveDescText.Multiline = True
        Me.ArchiveDescText.Name = "ArchiveDescText"
        Me.ArchiveDescText.Size = New System.Drawing.Size(417, 101)
        Me.ArchiveDescText.TabIndex = 33
        '
        'ArchiveTitleText
        '
        Me.ArchiveTitleText.BackColor = Color.Gray 'System.Drawing.Color.RoyalBlue
        Me.ArchiveTitleText.ForeColor = System.Drawing.Color.White
        Me.ArchiveTitleText.Location = New System.Drawing.Point(59, 36)
        Me.ArchiveTitleText.Name = "ArchiveTitleText"
        Me.ArchiveTitleText.Size = New System.Drawing.Size(182, 34)
        Me.ArchiveTitleText.TabIndex = 32
        Me.ArchiveTitleText.Text = "کار جدید 1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(482, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 27)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "شرح پیگیری"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(247, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 27)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "عنوان پیگیری"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(481, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "تاریخ پیگیری"
        '
        'SaveFollowUpBtn
        '
        Me.SaveFollowUpBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.SaveFollowUpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveFollowUpBtn.Font = New System.Drawing.Font("B Zar", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.SaveFollowUpBtn.ForeColor = System.Drawing.Color.Black
        Me.SaveFollowUpBtn.Image = CType(resources.GetObject("SaveFollowUpBtn.Image"), System.Drawing.Image)
        Me.SaveFollowUpBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SaveFollowUpBtn.Location = New System.Drawing.Point(10, 85)
        Me.SaveFollowUpBtn.Name = "SaveFollowUpBtn"
        Me.SaveFollowUpBtn.Size = New System.Drawing.Size(43, 43)
        Me.SaveFollowUpBtn.TabIndex = 37
        Me.SaveFollowUpBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SaveFollowUpBtn.UseVisualStyleBackColor = True
        '
        'ArchiveForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = Color.Gray 'System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.CancelButton = Me.ArchiveReturnBtn
        Me.ClientSize = New System.Drawing.Size(600, 650)
        Me.ControlBox = False
        Me.Controls.Add(Me.FollowUpBox)
        Me.Controls.Add(Me.ArchiveReturnBtn)
        Me.Controls.Add(Me.FollowUpBtn)
        Me.Controls.Add(Me.SendArchiveBtn)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ArchiveDGV)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("B Zar", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ArchiveForm"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "دفترچه یادداشت سما / بایگانی"
        Me.TopMost = True
        CType(Me.ArchiveDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.FollowUpBox.ResumeLayout(False)
        Me.FollowUpBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents ArchiveDGV As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents AllWorksRb As RadioButton
    Friend WithEvents WorksRb As RadioButton
    Friend WithEvents ArchiveRb As RadioButton
    Friend WithEvents SendArchiveBtn As Button
    Friend WithEvents FollowUpBtn As Button
    Friend WithEvents ArchiveReturnBtn As Button
    Friend WithEvents FollowUpBox As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CancelFollowUpBtn As Button
    Friend WithEvents ArchiveYearText As TextBox
    Friend WithEvents ArchiveMonthText As TextBox
    Friend WithEvents ArchiveDayText As TextBox
    Friend WithEvents ArchiveDescText As TextBox
    Friend WithEvents ArchiveTitleText As TextBox
    Friend WithEvents SaveFollowUpBtn As Button
End Class
