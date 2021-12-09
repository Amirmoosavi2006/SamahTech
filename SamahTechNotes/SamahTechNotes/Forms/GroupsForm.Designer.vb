<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GroupsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GroupsForm))
        Me.ReturnBtn = New System.Windows.Forms.Button()
        Me.Group2Btn = New System.Windows.Forms.Button()
        Me.Group2Text = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Group2List = New System.Windows.Forms.ListBox()
        Me.Group1Btn = New System.Windows.Forms.Button()
        Me.Group1Text = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Group1List = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'ReturnBtn
        '
        Me.ReturnBtn.FlatAppearance.BorderSize = 0
        Me.ReturnBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tan
        Me.ReturnBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.ReturnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ReturnBtn.Image = CType(resources.GetObject("ReturnBtn.Image"), System.Drawing.Image)
        Me.ReturnBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ReturnBtn.Location = New System.Drawing.Point(60, 538)
        Me.ReturnBtn.Name = "ReturnBtn"
        Me.ReturnBtn.Size = New System.Drawing.Size(89, 39)
        Me.ReturnBtn.TabIndex = 39
        Me.ReturnBtn.Text = "بازگشت"
        Me.ReturnBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ReturnBtn.UseVisualStyleBackColor = True
        '
        'Group2Btn
        '
        Me.Group2Btn.Image = CType(resources.GetObject("Group2Btn.Image"), System.Drawing.Image)
        Me.Group2Btn.Location = New System.Drawing.Point(60, 449)
        Me.Group2Btn.Name = "Group2Btn"
        Me.Group2Btn.Size = New System.Drawing.Size(40, 34)
        Me.Group2Btn.TabIndex = 38
        Me.Group2Btn.UseVisualStyleBackColor = True
        '
        'Group2Text
        '
        Me.Group2Text.BackColor = Color.Gray 'System.Drawing.Color.Teal
        Me.Group2Text.Location = New System.Drawing.Point(106, 449)
        Me.Group2Text.Name = "Group2Text"
        Me.Group2Text.Size = New System.Drawing.Size(153, 34)
        Me.Group2Text.TabIndex = 37
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("B Zar", 14.0!)
        Me.Label2.Location = New System.Drawing.Point(199, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 32)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "زیر گروه"
        '
        'Group2List
        '
        Me.Group2List.BackColor = Color.Gray 'System.Drawing.Color.Teal
        Me.Group2List.Font = New System.Drawing.Font("B Zar", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Group2List.ForeColor = System.Drawing.Color.White
        Me.Group2List.FormattingEnabled = True
        Me.Group2List.ItemHeight = 32
        Me.Group2List.Items.AddRange(New Object() {"ثبت خبر", "فهرست پیام ها", "جستجوی موردی", "فهرست تذکرها", "مدیریت", "سایر"})
        Me.Group2List.Location = New System.Drawing.Point(60, 87)
        Me.Group2List.Name = "Group2List"
        Me.Group2List.Size = New System.Drawing.Size(199, 356)
        Me.Group2List.TabIndex = 35
        '
        'Group1Btn
        '
        Me.Group1Btn.Image = CType(resources.GetObject("Group1Btn.Image"), System.Drawing.Image)
        Me.Group1Btn.Location = New System.Drawing.Point(336, 449)
        Me.Group1Btn.Name = "Group1Btn"
        Me.Group1Btn.Size = New System.Drawing.Size(40, 34)
        Me.Group1Btn.TabIndex = 34
        Me.Group1Btn.UseVisualStyleBackColor = True
        '
        'Group1Text
        '
        Me.Group1Text.BackColor = Color.Gray 'System.Drawing.Color.Teal
        Me.Group1Text.Location = New System.Drawing.Point(382, 449)
        Me.Group1Text.Name = "Group1Text"
        Me.Group1Text.Size = New System.Drawing.Size(153, 34)
        Me.Group1Text.TabIndex = 33
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("B Zar", 14.0!)
        Me.Label1.Location = New System.Drawing.Point(497, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 32)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "گروه"
        '
        'Group1List
        '
        Me.Group1List.BackColor = Color.Gray 'System.Drawing.Color.Teal
        Me.Group1List.Font = New System.Drawing.Font("B Zar", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Group1List.ForeColor = System.Drawing.Color.White
        Me.Group1List.FormattingEnabled = True
        Me.Group1List.ItemHeight = 32
        Me.Group1List.Items.AddRange(New Object() {"نرم افزار", "کال سنتر", "گزارش ساز", "تهران من", "نقشه"})
        Me.Group1List.Location = New System.Drawing.Point(336, 87)
        Me.Group1List.Name = "Group1List"
        Me.Group1List.Size = New System.Drawing.Size(199, 356)
        Me.Group1List.TabIndex = 31
        '
        'GroupsForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = Color.Gray 'System.Drawing.Color.IndianRed
        Me.ClientSize = New System.Drawing.Size(600, 650)
        Me.ControlBox = False
        Me.Controls.Add(Me.ReturnBtn)
        Me.Controls.Add(Me.Group2Btn)
        Me.Controls.Add(Me.Group2Text)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Group2List)
        Me.Controls.Add(Me.Group1Btn)
        Me.Controls.Add(Me.Group1Text)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Group1List)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("B Zar", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "GroupsForm"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "دفترچه یادداشت سما / گروه بندی"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReturnBtn As Button
    Friend WithEvents Group2Btn As Button
    Friend WithEvents Group2Text As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Group2List As ListBox
    Friend WithEvents Group1Btn As Button
    Friend WithEvents Group1Text As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Group1List As ListBox
End Class
