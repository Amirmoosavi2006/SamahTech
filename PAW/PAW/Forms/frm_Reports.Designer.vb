<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Reports
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Reports))
        Me.FindYearTo = New System.Windows.Forms.TextBox()
        Me.FindMonthTo = New System.Windows.Forms.TextBox()
        Me.FindDayTo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FindYearFrom = New System.Windows.Forms.TextBox()
        Me.FindMonthFrom = New System.Windows.Forms.TextBox()
        Me.FindDayFrom = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FindInHand = New System.Windows.Forms.Button()
        Me.btn_print = New System.Windows.Forms.Button()
        Me.btn_return = New System.Windows.Forms.Button()
        Me.dgv_Find = New System.Windows.Forms.DataGridView()
        Me.FindEnd = New System.Windows.Forms.Button()
        Me.btn_find = New System.Windows.Forms.Button()
        Me.PeopleList = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.FindTodo = New System.Windows.Forms.Button()
        Me.FindTrack = New System.Windows.Forms.Button()
        CType(Me.dgv_Find, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FindYearTo
        '
        Me.FindYearTo.Location = New System.Drawing.Point(296, 12)
        Me.FindYearTo.MaxLength = 4
        Me.FindYearTo.Name = "FindYearTo"
        Me.FindYearTo.Size = New System.Drawing.Size(78, 39)
        Me.FindYearTo.TabIndex = 5
        Me.FindYearTo.Text = "1400"
        Me.FindYearTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FindMonthTo
        '
        Me.FindMonthTo.Location = New System.Drawing.Point(380, 12)
        Me.FindMonthTo.MaxLength = 2
        Me.FindMonthTo.Name = "FindMonthTo"
        Me.FindMonthTo.Size = New System.Drawing.Size(39, 39)
        Me.FindMonthTo.TabIndex = 4
        Me.FindMonthTo.Text = "04"
        Me.FindMonthTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FindDayTo
        '
        Me.FindDayTo.Location = New System.Drawing.Point(425, 12)
        Me.FindDayTo.MaxLength = 2
        Me.FindDayTo.Name = "FindDayTo"
        Me.FindDayTo.Size = New System.Drawing.Size(39, 39)
        Me.FindDayTo.TabIndex = 3
        Me.FindDayTo.Text = "05"
        Me.FindDayTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(470, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 32)
        Me.Label1.TabIndex = 130
        Me.Label1.Text = "تا تاریخ"
        '
        'FindYearFrom
        '
        Me.FindYearFrom.Location = New System.Drawing.Point(538, 12)
        Me.FindYearFrom.MaxLength = 4
        Me.FindYearFrom.Name = "FindYearFrom"
        Me.FindYearFrom.Size = New System.Drawing.Size(78, 39)
        Me.FindYearFrom.TabIndex = 2
        Me.FindYearFrom.Text = "1400"
        Me.FindYearFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FindMonthFrom
        '
        Me.FindMonthFrom.Location = New System.Drawing.Point(622, 12)
        Me.FindMonthFrom.MaxLength = 2
        Me.FindMonthFrom.Name = "FindMonthFrom"
        Me.FindMonthFrom.Size = New System.Drawing.Size(39, 39)
        Me.FindMonthFrom.TabIndex = 1
        Me.FindMonthFrom.Text = "04"
        Me.FindMonthFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FindDayFrom
        '
        Me.FindDayFrom.Location = New System.Drawing.Point(667, 12)
        Me.FindDayFrom.MaxLength = 2
        Me.FindDayFrom.Name = "FindDayFrom"
        Me.FindDayFrom.Size = New System.Drawing.Size(39, 39)
        Me.FindDayFrom.TabIndex = 0
        Me.FindDayFrom.Text = "05"
        Me.FindDayFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(712, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 32)
        Me.Label3.TabIndex = 129
        Me.Label3.Text = "از تاریخ"
        '
        'FindInHand
        '
        Me.FindInHand.Image = Global.PAW.My.Resources.Resources.icons8_search_50
        Me.FindInHand.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.FindInHand.Location = New System.Drawing.Point(529, 111)
        Me.FindInHand.Name = "FindInHand"
        Me.FindInHand.Size = New System.Drawing.Size(177, 43)
        Me.FindInHand.TabIndex = 8
        Me.FindInHand.Text = "دردست اقدام"
        Me.FindInHand.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.FindInHand.UseVisualStyleBackColor = True
        '
        'btn_print
        '
        Me.btn_print.Image = Global.PAW.My.Resources.Resources.icons8_print_50
        Me.btn_print.Location = New System.Drawing.Point(68, 153)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(50, 50)
        Me.btn_print.TabIndex = 12
        Me.btn_print.UseVisualStyleBackColor = True
        '
        'btn_return
        '
        Me.btn_return.Image = Global.PAW.My.Resources.Resources.icons8_end_button_50
        Me.btn_return.Location = New System.Drawing.Point(12, 153)
        Me.btn_return.Name = "btn_return"
        Me.btn_return.Size = New System.Drawing.Size(50, 50)
        Me.btn_return.TabIndex = 13
        Me.btn_return.UseVisualStyleBackColor = True
        '
        'dgv_Find
        '
        Me.dgv_Find.AllowUserToAddRows = False
        Me.dgv_Find.AllowUserToDeleteRows = False
        Me.dgv_Find.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_Find.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_Find.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Find.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgv_Find.Location = New System.Drawing.Point(0, 209)
        Me.dgv_Find.Name = "dgv_Find"
        Me.dgv_Find.ReadOnly = True
        Me.dgv_Find.RowHeadersVisible = False
        Me.dgv_Find.RowHeadersWidth = 51
        Me.dgv_Find.RowTemplate.Height = 24
        Me.dgv_Find.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Find.ShowCellErrors = False
        Me.dgv_Find.ShowEditingIcon = False
        Me.dgv_Find.ShowRowErrors = False
        Me.dgv_Find.Size = New System.Drawing.Size(782, 344)
        Me.dgv_Find.TabIndex = 14
        Me.dgv_Find.TabStop = False
        '
        'FindEnd
        '
        Me.FindEnd.Image = Global.PAW.My.Resources.Resources.icons8_search_50
        Me.FindEnd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.FindEnd.Location = New System.Drawing.Point(346, 111)
        Me.FindEnd.Name = "FindEnd"
        Me.FindEnd.Size = New System.Drawing.Size(177, 43)
        Me.FindEnd.TabIndex = 9
        Me.FindEnd.Text = "مختومه"
        Me.FindEnd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.FindEnd.UseVisualStyleBackColor = True
        '
        'btn_find
        '
        Me.btn_find.Image = Global.PAW.My.Resources.Resources.icons8_search_50
        Me.btn_find.Location = New System.Drawing.Point(346, 63)
        Me.btn_find.Name = "btn_find"
        Me.btn_find.Size = New System.Drawing.Size(50, 42)
        Me.btn_find.TabIndex = 7
        Me.btn_find.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_find.UseVisualStyleBackColor = True
        '
        'PeopleList
        '
        Me.PeopleList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.PeopleList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.PeopleList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PeopleList.FormattingEnabled = True
        Me.PeopleList.Items.AddRange(New Object() {"سیدامیر موسوی", "مریم همتی", "نوید اسمعیل زاده", "وحید نوروزنیا"})
        Me.PeopleList.Location = New System.Drawing.Point(402, 64)
        Me.PeopleList.Name = "PeopleList"
        Me.PeopleList.Size = New System.Drawing.Size(304, 40)
        Me.PeopleList.Sorted = True
        Me.PeopleList.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(712, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 32)
        Me.Label4.TabIndex = 136
        Me.Label4.Text = "افراد"
        '
        'FindTodo
        '
        Me.FindTodo.Image = Global.PAW.My.Resources.Resources.icons8_search_50
        Me.FindTodo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.FindTodo.Location = New System.Drawing.Point(529, 160)
        Me.FindTodo.Name = "FindTodo"
        Me.FindTodo.Size = New System.Drawing.Size(177, 43)
        Me.FindTodo.TabIndex = 10
        Me.FindTodo.Text = "سررسید شده"
        Me.FindTodo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.FindTodo.UseVisualStyleBackColor = True
        '
        'FindTrack
        '
        Me.FindTrack.Image = Global.PAW.My.Resources.Resources.icons8_search_50
        Me.FindTrack.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.FindTrack.Location = New System.Drawing.Point(346, 160)
        Me.FindTrack.Name = "FindTrack"
        Me.FindTrack.Size = New System.Drawing.Size(177, 43)
        Me.FindTrack.TabIndex = 11
        Me.FindTrack.Text = "پیگیری"
        Me.FindTrack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.FindTrack.UseVisualStyleBackColor = True
        '
        'frm_Reports
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(782, 553)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PeopleList)
        Me.Controls.Add(Me.btn_find)
        Me.Controls.Add(Me.FindEnd)
        Me.Controls.Add(Me.FindTrack)
        Me.Controls.Add(Me.FindTodo)
        Me.Controls.Add(Me.FindInHand)
        Me.Controls.Add(Me.btn_print)
        Me.Controls.Add(Me.btn_return)
        Me.Controls.Add(Me.dgv_Find)
        Me.Controls.Add(Me.FindYearTo)
        Me.Controls.Add(Me.FindMonthTo)
        Me.Controls.Add(Me.FindDayTo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FindYearFrom)
        Me.Controls.Add(Me.FindMonthFrom)
        Me.Controls.Add(Me.FindDayFrom)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("B Kamran", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_Reports"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "برنامه ریزی کارهای اداری / گزارشات"
        CType(Me.dgv_Find, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FindYearTo As TextBox
    Friend WithEvents FindMonthTo As TextBox
    Friend WithEvents FindDayTo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents FindYearFrom As TextBox
    Friend WithEvents FindMonthFrom As TextBox
    Friend WithEvents FindDayFrom As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents FindInHand As Button
    Friend WithEvents btn_print As Button
    Friend WithEvents btn_return As Button
    Friend WithEvents dgv_Find As DataGridView
    Friend WithEvents FindEnd As Button
    Friend WithEvents btn_find As Button
    Friend WithEvents PeopleList As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents FindTodo As Button
    Friend WithEvents FindTrack As Button
End Class
