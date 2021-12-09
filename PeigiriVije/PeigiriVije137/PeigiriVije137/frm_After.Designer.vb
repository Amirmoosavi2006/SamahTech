<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_After
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_After))
        Me.Dgv_Data = New System.Windows.Forms.DataGridView()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_return = New System.Windows.Forms.Button()
        CType(Me.Dgv_Data, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Dgv_Data
        '
        Me.Dgv_Data.AllowUserToAddRows = False
        Me.Dgv_Data.AllowUserToDeleteRows = False
        Me.Dgv_Data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Dgv_Data.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.Dgv_Data.BackgroundColor = System.Drawing.Color.DarkSeaGreen
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Coral
        DataGridViewCellStyle1.Font = New System.Drawing.Font("B Nazanin", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv_Data.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Dgv_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Data.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Dgv_Data.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.Dgv_Data.Location = New System.Drawing.Point(0, 628)
        Me.Dgv_Data.MultiSelect = False
        Me.Dgv_Data.Name = "Dgv_Data"
        Me.Dgv_Data.ReadOnly = True
        Me.Dgv_Data.RowHeadersVisible = False
        Me.Dgv_Data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgv_Data.ShowCellErrors = False
        Me.Dgv_Data.ShowCellToolTips = False
        Me.Dgv_Data.ShowEditingIcon = False
        Me.Dgv_Data.ShowRowErrors = False
        Me.Dgv_Data.Size = New System.Drawing.Size(984, 33)
        Me.Dgv_Data.TabIndex = 5
        Me.Dgv_Data.TabStop = False
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(723, 84)
        Me.TextBox7.MaxLength = 4
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(60, 30)
        Me.TextBox7.TabIndex = 8
        Me.TextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(789, 84)
        Me.TextBox6.MaxLength = 2
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(30, 30)
        Me.TextBox6.TabIndex = 9
        Me.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(723, 48)
        Me.TextBox4.MaxLength = 4
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(60, 30)
        Me.TextBox4.TabIndex = 10
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(825, 84)
        Me.TextBox5.MaxLength = 2
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(30, 30)
        Me.TextBox5.TabIndex = 11
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(789, 48)
        Me.TextBox3.MaxLength = 2
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(30, 30)
        Me.TextBox3.TabIndex = 12
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(861, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 23)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "تاریخ بازدید"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(825, 48)
        Me.TextBox2.MaxLength = 2
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(30, 30)
        Me.TextBox2.TabIndex = 13
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(861, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 23)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "تاریخ گزارش"
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(430, 116)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(132, 30)
        Me.TextBox11.TabIndex = 17
        Me.TextBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(568, 119)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 23)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "شماره تماس"
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(430, 80)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(132, 30)
        Me.TextBox10.TabIndex = 18
        Me.TextBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(568, 83)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 23)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "سمت همراه"
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(430, 44)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(132, 30)
        Me.TextBox9.TabIndex = 19
        Me.TextBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(568, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 23)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "نام همراه بازدید کننده"
        '
        'btn_return
        '
        Me.btn_return.Location = New System.Drawing.Point(12, 171)
        Me.btn_return.Name = "btn_return"
        Me.btn_return.Size = New System.Drawing.Size(147, 47)
        Me.btn_return.TabIndex = 20
        Me.btn_return.Text = "بازگشت"
        Me.btn_return.UseVisualStyleBackColor = True
        '
        'frm_After
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(984, 661)
        Me.Controls.Add(Me.btn_return)
        Me.Controls.Add(Me.TextBox11)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox10)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Dgv_Data)
        Me.Font = New System.Drawing.Font("B Nazanin", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "frm_After"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "فرم بعداز بازدید"
        CType(Me.Dgv_Data, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Dgv_Data As DataGridView
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_return As Button
End Class
