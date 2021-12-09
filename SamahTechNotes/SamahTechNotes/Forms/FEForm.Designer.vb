<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FEForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FEForm))
        Me.FEText = New System.Windows.Forms.TextBox()
        Me.FEEditBtn = New System.Windows.Forms.Button()
        Me.FEReturnBtn = New System.Windows.Forms.Button()
        Me.FEFindBtn = New System.Windows.Forms.Button()
        Me.FEDGV = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.AssignToChb = New System.Windows.Forms.CheckedListBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Group2Combo = New System.Windows.Forms.ComboBox()
        Me.Group1Combo = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.FEYearText = New System.Windows.Forms.TextBox()
        Me.FEMonthText = New System.Windows.Forms.TextBox()
        Me.FEDayText = New System.Windows.Forms.TextBox()
        Me.FEDescText = New System.Windows.Forms.TextBox()
        Me.FETitleText = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.FEDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'FEText
        '
        Me.FEText.BackColor = Color.Gray 'System.Drawing.Color.PaleGreen
        Me.FEText.Location = New System.Drawing.Point(66, 24)
        Me.FEText.Name = "FEText"
        Me.FEText.Size = New System.Drawing.Size(476, 34)
        Me.FEText.TabIndex = 2
        '
        'FEEditBtn
        '
        Me.FEEditBtn.FlatAppearance.BorderSize = 0
        Me.FEEditBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aquamarine
        Me.FEEditBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.FEEditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FEEditBtn.Image = CType(resources.GetObject("FEEditBtn.Image"), System.Drawing.Image)
        Me.FEEditBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.FEEditBtn.Location = New System.Drawing.Point(129, 569)
        Me.FEEditBtn.Name = "FEEditBtn"
        Me.FEEditBtn.Size = New System.Drawing.Size(97, 43)
        Me.FEEditBtn.TabIndex = 4
        Me.FEEditBtn.Text = "ویرایش"
        Me.FEEditBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.FEEditBtn.UseVisualStyleBackColor = True
        '
        'FEReturnBtn
        '
        Me.FEReturnBtn.FlatAppearance.BorderSize = 0
        Me.FEReturnBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tomato
        Me.FEReturnBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed
        Me.FEReturnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FEReturnBtn.Font = New System.Drawing.Font("B Zar", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FEReturnBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FEReturnBtn.Image = CType(resources.GetObject("FEReturnBtn.Image"), System.Drawing.Image)
        Me.FEReturnBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.FEReturnBtn.Location = New System.Drawing.Point(12, 569)
        Me.FEReturnBtn.Name = "FEReturnBtn"
        Me.FEReturnBtn.Size = New System.Drawing.Size(97, 43)
        Me.FEReturnBtn.TabIndex = 19
        Me.FEReturnBtn.Text = "بازگشت"
        Me.FEReturnBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.FEReturnBtn.UseVisualStyleBackColor = True
        '
        'FEFindBtn
        '
        Me.FEFindBtn.FlatAppearance.BorderSize = 0
        Me.FEFindBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen
        Me.FEFindBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GreenYellow
        Me.FEFindBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FEFindBtn.Image = CType(resources.GetObject("FEFindBtn.Image"), System.Drawing.Image)
        Me.FEFindBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.FEFindBtn.Location = New System.Drawing.Point(12, 24)
        Me.FEFindBtn.Name = "FEFindBtn"
        Me.FEFindBtn.Size = New System.Drawing.Size(576, 34)
        Me.FEFindBtn.TabIndex = 4
        Me.FEFindBtn.Text = "جستجو"
        Me.FEFindBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.FEFindBtn.UseVisualStyleBackColor = True
        '
        'FEDGV
        '
        Me.FEDGV.AllowUserToAddRows = False
        Me.FEDGV.AllowUserToDeleteRows = False
        Me.FEDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.FEDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.FEDGV.BackgroundColor = System.Drawing.Color.Orchid
        Me.FEDGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FEDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FEDGV.GridColor = System.Drawing.Color.Black
        Me.FEDGV.Location = New System.Drawing.Point(12, 65)
        Me.FEDGV.MultiSelect = False
        Me.FEDGV.Name = "FEDGV"
        Me.FEDGV.RowHeadersVisible = False
        Me.FEDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.FEDGV.ShowCellErrors = False
        Me.FEDGV.ShowCellToolTips = False
        Me.FEDGV.ShowEditingIcon = False
        Me.FEDGV.ShowRowErrors = False
        Me.FEDGV.Size = New System.Drawing.Size(576, 180)
        Me.FEDGV.TabIndex = 22
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.FEYearText)
        Me.GroupBox1.Controls.Add(Me.FEMonthText)
        Me.GroupBox1.Controls.Add(Me.FEDayText)
        Me.GroupBox1.Controls.Add(Me.FEDescText)
        Me.GroupBox1.Controls.Add(Me.FETitleText)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 251)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(576, 312)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ویرایش"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.AssignToChb)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 146)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(283, 160)
        Me.GroupBox2.TabIndex = 34
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
        Me.AssignToChb.Location = New System.Drawing.Point(6, 36)
        Me.AssignToChb.Name = "AssignToChb"
        Me.AssignToChb.Size = New System.Drawing.Size(241, 102)
        Me.AssignToChb.TabIndex = 18
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Group2Combo)
        Me.GroupBox3.Controls.Add(Me.Group1Combo)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Location = New System.Drawing.Point(301, 146)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(258, 160)
        Me.GroupBox3.TabIndex = 32
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "دسته بندی کار"
        '
        'Group2Combo
        '
        Me.Group2Combo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Group2Combo.BackColor = Color.Gray 'System.Drawing.Color.PaleGreen
        Me.Group2Combo.FormattingEnabled = True
        Me.Group2Combo.Items.AddRange(New Object() {"زیر آیتم 1", "زیر آیتم 2", "زیر آیتم 3"})
        Me.Group2Combo.Location = New System.Drawing.Point(6, 91)
        Me.Group2Combo.Name = "Group2Combo"
        Me.Group2Combo.Size = New System.Drawing.Size(178, 35)
        Me.Group2Combo.TabIndex = 25
        '
        'Group1Combo
        '
        Me.Group1Combo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Group1Combo.BackColor = Color.Gray 'System.Drawing.Color.PaleGreen
        Me.Group1Combo.FormattingEnabled = True
        Me.Group1Combo.Items.AddRange(New Object() {"نرم افزار", "تهران من", "نقشه", "کال سنتر", "گزارش ساز"})
        Me.Group1Combo.Location = New System.Drawing.Point(6, 50)
        Me.Group1Combo.Name = "Group1Combo"
        Me.Group1Combo.Size = New System.Drawing.Size(178, 35)
        Me.Group1Combo.TabIndex = 26
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("B Zar", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(190, 91)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 32)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "زیر گروه"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("B Zar", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(190, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 32)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "گروه"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FEYearText
        '
        Me.FEYearText.BackColor = Color.Gray 'System.Drawing.Color.PaleGreen
        Me.FEYearText.Location = New System.Drawing.Point(330, 33)
        Me.FEYearText.MaxLength = 4
        Me.FEYearText.Name = "FEYearText"
        Me.FEYearText.Size = New System.Drawing.Size(68, 34)
        Me.FEYearText.TabIndex = 29
        Me.FEYearText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FEMonthText
        '
        Me.FEMonthText.BackColor = Color.Gray 'System.Drawing.Color.PaleGreen
        Me.FEMonthText.Location = New System.Drawing.Point(404, 33)
        Me.FEMonthText.MaxLength = 2
        Me.FEMonthText.Name = "FEMonthText"
        Me.FEMonthText.Size = New System.Drawing.Size(34, 34)
        Me.FEMonthText.TabIndex = 30
        Me.FEMonthText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FEDayText
        '
        Me.FEDayText.BackColor = Color.Gray 'System.Drawing.Color.PaleGreen
        Me.FEDayText.Location = New System.Drawing.Point(444, 33)
        Me.FEDayText.MaxLength = 2
        Me.FEDayText.Name = "FEDayText"
        Me.FEDayText.Size = New System.Drawing.Size(34, 34)
        Me.FEDayText.TabIndex = 31
        Me.FEDayText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FEDescText
        '
        Me.FEDescText.BackColor = Color.Gray 'System.Drawing.Color.PaleGreen
        Me.FEDescText.Location = New System.Drawing.Point(12, 73)
        Me.FEDescText.Multiline = True
        Me.FEDescText.Name = "FEDescText"
        Me.FEDescText.Size = New System.Drawing.Size(466, 67)
        Me.FEDescText.TabIndex = 28
        '
        'FETitleText
        '
        Me.FETitleText.BackColor = Color.Gray 'System.Drawing.Color.PaleGreen
        Me.FETitleText.Location = New System.Drawing.Point(12, 33)
        Me.FETitleText.Name = "FETitleText"
        Me.FETitleText.Size = New System.Drawing.Size(247, 34)
        Me.FETitleText.TabIndex = 27
        Me.FETitleText.Text = "کار جدید 1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("B Zar", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(484, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 27)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "تاریخ ثبت کار"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("B Zar", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(484, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 27)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "شرح کار"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("B Zar", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(265, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 27)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "عنوان کار"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FEForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = Color.Gray 'System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(600, 650)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.FEDGV)
        Me.Controls.Add(Me.FEReturnBtn)
        Me.Controls.Add(Me.FEEditBtn)
        Me.Controls.Add(Me.FEText)
        Me.Controls.Add(Me.FEFindBtn)
        Me.Font = New System.Drawing.Font("B Zar", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FEForm"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "دفترچه یادداشت سما / جستجو / ویرایش"
        CType(Me.FEDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FEText As TextBox
    Friend WithEvents FEEditBtn As Button
    Friend WithEvents FEReturnBtn As Button
    Friend WithEvents FEFindBtn As Button
    Friend WithEvents FEDGV As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents FEYearText As TextBox
    Friend WithEvents FEMonthText As TextBox
    Friend WithEvents FEDayText As TextBox
    Friend WithEvents FEDescText As TextBox
    Friend WithEvents FETitleText As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents AssignToChb As CheckedListBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Group2Combo As ComboBox
    Friend WithEvents Group1Combo As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
End Class
