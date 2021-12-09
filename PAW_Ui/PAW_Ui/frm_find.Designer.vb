<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_find
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_track = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_del = New System.Windows.Forms.Button()
        Me.btn_refresh = New System.Windows.Forms.Button()
        Me.btn_home = New System.Windows.Forms.Button()
        Me.txt_from_year = New System.Windows.Forms.TextBox()
        Me.txt_from_month = New System.Windows.Forms.TextBox()
        Me.txt_from_day = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_to_year = New System.Windows.Forms.TextBox()
        Me.txt_to_month = New System.Windows.Forms.TextBox()
        Me.txt_to_day = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_find = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgv_find = New System.Windows.Forms.DataGridView()
        Me.col_work_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_work_title = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_work_create_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_desc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_track = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_attach = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_people = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_find = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv_find, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btn_track)
        Me.Panel1.Controls.Add(Me.btn_edit)
        Me.Panel1.Controls.Add(Me.btn_del)
        Me.Panel1.Controls.Add(Me.btn_refresh)
        Me.Panel1.Controls.Add(Me.btn_home)
        Me.Panel1.Location = New System.Drawing.Point(12, 592)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(432, 100)
        Me.Panel1.TabIndex = 139
        '
        'btn_track
        '
        Me.btn_track.Image = Global.PAW_Ui.My.Resources.Resources.edit_property_64px
        Me.btn_track.Location = New System.Drawing.Point(333, 13)
        Me.btn_track.Name = "btn_track"
        Me.btn_track.Size = New System.Drawing.Size(72, 72)
        Me.btn_track.TabIndex = 148
        Me.btn_track.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Image = Global.PAW_Ui.My.Resources.Resources.edit_64px
        Me.btn_edit.Location = New System.Drawing.Point(255, 13)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(72, 72)
        Me.btn_edit.TabIndex = 147
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'btn_del
        '
        Me.btn_del.Image = Global.PAW_Ui.My.Resources.Resources.trash_can_64px
        Me.btn_del.Location = New System.Drawing.Point(177, 13)
        Me.btn_del.Name = "btn_del"
        Me.btn_del.Size = New System.Drawing.Size(72, 72)
        Me.btn_del.TabIndex = 146
        Me.btn_del.UseVisualStyleBackColor = True
        '
        'btn_refresh
        '
        Me.btn_refresh.Image = Global.PAW_Ui.My.Resources.Resources.repeat_64px
        Me.btn_refresh.Location = New System.Drawing.Point(99, 13)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(72, 72)
        Me.btn_refresh.TabIndex = 145
        Me.btn_refresh.UseVisualStyleBackColor = True
        '
        'btn_home
        '
        Me.btn_home.Image = Global.PAW_Ui.My.Resources.Resources.home_64px
        Me.btn_home.Location = New System.Drawing.Point(21, 13)
        Me.btn_home.Name = "btn_home"
        Me.btn_home.Size = New System.Drawing.Size(72, 72)
        Me.btn_home.TabIndex = 144
        Me.btn_home.UseVisualStyleBackColor = True
        '
        'txt_from_year
        '
        Me.txt_from_year.BackColor = System.Drawing.Color.LightBlue
        Me.txt_from_year.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_from_year.Font = New System.Drawing.Font("B Koodak", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txt_from_year.Location = New System.Drawing.Point(686, 31)
        Me.txt_from_year.MaxLength = 4
        Me.txt_from_year.Name = "txt_from_year"
        Me.txt_from_year.Size = New System.Drawing.Size(78, 35)
        Me.txt_from_year.TabIndex = 148
        Me.txt_from_year.Text = "1400"
        Me.txt_from_year.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_from_month
        '
        Me.txt_from_month.BackColor = System.Drawing.Color.LightBlue
        Me.txt_from_month.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_from_month.Font = New System.Drawing.Font("B Koodak", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txt_from_month.Location = New System.Drawing.Point(770, 31)
        Me.txt_from_month.MaxLength = 2
        Me.txt_from_month.Name = "txt_from_month"
        Me.txt_from_month.Size = New System.Drawing.Size(39, 35)
        Me.txt_from_month.TabIndex = 147
        Me.txt_from_month.Text = "04"
        Me.txt_from_month.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_from_day
        '
        Me.txt_from_day.BackColor = System.Drawing.Color.LightBlue
        Me.txt_from_day.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_from_day.Font = New System.Drawing.Font("B Koodak", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txt_from_day.Location = New System.Drawing.Point(815, 31)
        Me.txt_from_day.MaxLength = 2
        Me.txt_from_day.Name = "txt_from_day"
        Me.txt_from_day.Size = New System.Drawing.Size(39, 35)
        Me.txt_from_day.TabIndex = 146
        Me.txt_from_day.Text = "05"
        Me.txt_from_day.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("B Koodak", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.Location = New System.Drawing.Point(860, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 28)
        Me.Label1.TabIndex = 145
        Me.Label1.Text = "از تاریخ"
        '
        'txt_to_year
        '
        Me.txt_to_year.BackColor = System.Drawing.Color.LightBlue
        Me.txt_to_year.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_to_year.Font = New System.Drawing.Font("B Koodak", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txt_to_year.Location = New System.Drawing.Point(440, 31)
        Me.txt_to_year.MaxLength = 4
        Me.txt_to_year.Name = "txt_to_year"
        Me.txt_to_year.Size = New System.Drawing.Size(78, 35)
        Me.txt_to_year.TabIndex = 152
        Me.txt_to_year.Text = "1400"
        Me.txt_to_year.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_to_month
        '
        Me.txt_to_month.BackColor = System.Drawing.Color.LightBlue
        Me.txt_to_month.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_to_month.Font = New System.Drawing.Font("B Koodak", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txt_to_month.Location = New System.Drawing.Point(524, 31)
        Me.txt_to_month.MaxLength = 2
        Me.txt_to_month.Name = "txt_to_month"
        Me.txt_to_month.Size = New System.Drawing.Size(39, 35)
        Me.txt_to_month.TabIndex = 151
        Me.txt_to_month.Text = "04"
        Me.txt_to_month.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_to_day
        '
        Me.txt_to_day.BackColor = System.Drawing.Color.LightBlue
        Me.txt_to_day.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_to_day.Font = New System.Drawing.Font("B Koodak", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txt_to_day.Location = New System.Drawing.Point(569, 31)
        Me.txt_to_day.MaxLength = 2
        Me.txt_to_day.Name = "txt_to_day"
        Me.txt_to_day.Size = New System.Drawing.Size(39, 35)
        Me.txt_to_day.TabIndex = 150
        Me.txt_to_day.Text = "05"
        Me.txt_to_day.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("B Koodak", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.Location = New System.Drawing.Point(614, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 28)
        Me.Label2.TabIndex = 149
        Me.Label2.Text = "تا تاریخ"
        '
        'txt_find
        '
        Me.txt_find.BackColor = System.Drawing.Color.LightBlue
        Me.txt_find.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_find.Font = New System.Drawing.Font("B Koodak", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txt_find.ForeColor = System.Drawing.Color.Black
        Me.txt_find.Location = New System.Drawing.Point(440, 79)
        Me.txt_find.MaxLength = 100
        Me.txt_find.Name = "txt_find"
        Me.txt_find.Size = New System.Drawing.Size(414, 35)
        Me.txt_find.TabIndex = 154
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("B Koodak", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.Location = New System.Drawing.Point(860, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 28)
        Me.Label3.TabIndex = 153
        Me.Label3.Text = "متن جستجو"
        '
        'dgv_find
        '
        Me.dgv_find.AllowUserToAddRows = False
        Me.dgv_find.AllowUserToDeleteRows = False
        Me.dgv_find.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_find.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_find.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgv_find.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_find.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgv_find.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("B Koodak", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.NullValue = "-"
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.MistyRose
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_find.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_find.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_find.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_work_id, Me.col_work_title, Me.col_work_create_date, Me.col_desc, Me.col_track, Me.col_attach, Me.col_people})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.LightBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("B Koodak", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.NullValue = "=str(""-"")"
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.MistyRose
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_find.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_find.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgv_find.EnableHeadersVisualStyles = False
        Me.dgv_find.GridColor = System.Drawing.Color.Black
        Me.dgv_find.Location = New System.Drawing.Point(12, 127)
        Me.dgv_find.MultiSelect = False
        Me.dgv_find.Name = "dgv_find"
        Me.dgv_find.RowHeadersVisible = False
        Me.dgv_find.RowHeadersWidth = 51
        Me.dgv_find.RowTemplate.Height = 24
        Me.dgv_find.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_find.ShowCellErrors = False
        Me.dgv_find.ShowEditingIcon = False
        Me.dgv_find.ShowRowErrors = False
        Me.dgv_find.Size = New System.Drawing.Size(966, 459)
        Me.dgv_find.TabIndex = 200
        Me.dgv_find.TabStop = False
        '
        'col_work_id
        '
        Me.col_work_id.FillWeight = 1.0!
        Me.col_work_id.HeaderText = "شماره کار"
        Me.col_work_id.MinimumWidth = 6
        Me.col_work_id.Name = "col_work_id"
        Me.col_work_id.Visible = False
        '
        'col_work_title
        '
        Me.col_work_title.FillWeight = 15.0!
        Me.col_work_title.HeaderText = "عنوان"
        Me.col_work_title.MinimumWidth = 6
        Me.col_work_title.Name = "col_work_title"
        '
        'col_work_create_date
        '
        Me.col_work_create_date.FillWeight = 10.0!
        Me.col_work_create_date.HeaderText = "تاریخ شروع"
        Me.col_work_create_date.MinimumWidth = 6
        Me.col_work_create_date.Name = "col_work_create_date"
        '
        'col_desc
        '
        Me.col_desc.FillWeight = 30.0!
        Me.col_desc.HeaderText = "شرح کار"
        Me.col_desc.MinimumWidth = 6
        Me.col_desc.Name = "col_desc"
        '
        'col_track
        '
        Me.col_track.FillWeight = 30.0!
        Me.col_track.HeaderText = "شرح پیگیری"
        Me.col_track.MinimumWidth = 6
        Me.col_track.Name = "col_track"
        '
        'col_attach
        '
        Me.col_attach.FillWeight = 5.0!
        Me.col_attach.HeaderText = "پیوست"
        Me.col_attach.MinimumWidth = 6
        Me.col_attach.Name = "col_attach"
        '
        'col_people
        '
        Me.col_people.FillWeight = 10.0!
        Me.col_people.HeaderText = "افراد"
        Me.col_people.MinimumWidth = 6
        Me.col_people.Name = "col_people"
        '
        'btn_find
        '
        Me.btn_find.Image = Global.PAW_Ui.My.Resources.Resources.search_30px
        Me.btn_find.Location = New System.Drawing.Point(392, 79)
        Me.btn_find.Name = "btn_find"
        Me.btn_find.Size = New System.Drawing.Size(42, 42)
        Me.btn_find.TabIndex = 156
        Me.btn_find.UseVisualStyleBackColor = True
        '
        'frm_find
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(990, 704)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgv_find)
        Me.Controls.Add(Me.btn_find)
        Me.Controls.Add(Me.txt_find)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_to_year)
        Me.Controls.Add(Me.txt_to_month)
        Me.Controls.Add(Me.txt_to_day)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_from_year)
        Me.Controls.Add(Me.txt_from_month)
        Me.Controls.Add(Me.txt_from_day)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("B Koodak", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_find"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgv_find, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txt_from_year As TextBox
    Friend WithEvents txt_from_month As TextBox
    Friend WithEvents txt_from_day As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_to_year As TextBox
    Friend WithEvents txt_to_month As TextBox
    Friend WithEvents txt_to_day As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_find As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_find As Button
    Friend WithEvents dgv_find As DataGridView
    Friend WithEvents col_work_id As DataGridViewTextBoxColumn
    Friend WithEvents col_work_title As DataGridViewTextBoxColumn
    Friend WithEvents col_work_create_date As DataGridViewTextBoxColumn
    Friend WithEvents col_desc As DataGridViewTextBoxColumn
    Friend WithEvents col_track As DataGridViewTextBoxColumn
    Friend WithEvents col_attach As DataGridViewTextBoxColumn
    Friend WithEvents col_people As DataGridViewTextBoxColumn
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_del As Button
    Friend WithEvents btn_refresh As Button
    Friend WithEvents btn_home As Button
    Friend WithEvents btn_track As Button
End Class
