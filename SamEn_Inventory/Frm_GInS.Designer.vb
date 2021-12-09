<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_GInS
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_GInS))
        Me.cmb_Store = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmb_Kname = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_del = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_new = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_return = New System.Windows.Forms.Button()
        Me.dgv_Store = New System.Windows.Forms.DataGridView()
        Me.txt_Exp_day = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_Kcount = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_Locating = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_Category = New System.Windows.Forms.TextBox()
        Me.txt_Group = New System.Windows.Forms.TextBox()
        Me.txt_Unit = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_Exp_month = New System.Windows.Forms.TextBox()
        Me.txt_Exp_year = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.dgv_Store, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmb_Store
        '
        Me.cmb_Store.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmb_Store.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_Store.FormattingEnabled = True
        Me.cmb_Store.Location = New System.Drawing.Point(533, 103)
        Me.cmb_Store.Name = "cmb_Store"
        Me.cmb_Store.Size = New System.Drawing.Size(154, 35)
        Me.cmb_Store.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("B Zar", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label6.Location = New System.Drawing.Point(151, 113)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 25)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "دسته بندی"
        '
        'cmb_Kname
        '
        Me.cmb_Kname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmb_Kname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_Kname.FormattingEnabled = True
        Me.cmb_Kname.Location = New System.Drawing.Point(533, 12)
        Me.cmb_Kname.Name = "cmb_Kname"
        Me.cmb_Kname.Size = New System.Drawing.Size(154, 35)
        Me.cmb_Kname.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("B Zar", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label5.Location = New System.Drawing.Point(151, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 25)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "گروه اقلام"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("B Zar", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label4.Location = New System.Drawing.Point(151, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 25)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "واحد سنجش"
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
        Me.dgv_Store.TabIndex = 48
        Me.dgv_Store.TabStop = False
        '
        'txt_Exp_day
        '
        Me.txt_Exp_day.Location = New System.Drawing.Point(654, 194)
        Me.txt_Exp_day.MaxLength = 2
        Me.txt_Exp_day.Name = "txt_Exp_day"
        Me.txt_Exp_day.Size = New System.Drawing.Size(33, 34)
        Me.txt_Exp_day.TabIndex = 5
        Me.txt_Exp_day.Text = "26"
        Me.txt_Exp_day.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(693, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 27)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "انبار مقصد"
        '
        'txt_Kcount
        '
        Me.txt_Kcount.Location = New System.Drawing.Point(533, 58)
        Me.txt_Kcount.Name = "txt_Kcount"
        Me.txt_Kcount.Size = New System.Drawing.Size(154, 34)
        Me.txt_Kcount.TabIndex = 2
        Me.txt_Kcount.Text = "مرکزی"
        Me.txt_Kcount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(693, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 27)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "تعداد"
        '
        'txt_Locating
        '
        Me.txt_Locating.Location = New System.Drawing.Point(533, 149)
        Me.txt_Locating.Name = "txt_Locating"
        Me.txt_Locating.Size = New System.Drawing.Size(154, 34)
        Me.txt_Locating.TabIndex = 4
        Me.txt_Locating.Text = "مرکزی"
        Me.txt_Locating.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(693, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 27)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "نام کالا"
        '
        'txt_Category
        '
        Me.txt_Category.Enabled = False
        Me.txt_Category.Font = New System.Drawing.Font("B Zar", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txt_Category.Location = New System.Drawing.Point(27, 108)
        Me.txt_Category.Name = "txt_Category"
        Me.txt_Category.Size = New System.Drawing.Size(118, 32)
        Me.txt_Category.TabIndex = 54
        Me.txt_Category.TabStop = False
        Me.txt_Category.Text = "مرکزی"
        Me.txt_Category.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_Group
        '
        Me.txt_Group.Enabled = False
        Me.txt_Group.Font = New System.Drawing.Font("B Zar", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txt_Group.Location = New System.Drawing.Point(27, 70)
        Me.txt_Group.Name = "txt_Group"
        Me.txt_Group.Size = New System.Drawing.Size(118, 32)
        Me.txt_Group.TabIndex = 53
        Me.txt_Group.TabStop = False
        Me.txt_Group.Text = "مرکزی"
        Me.txt_Group.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_Unit
        '
        Me.txt_Unit.Enabled = False
        Me.txt_Unit.Font = New System.Drawing.Font("B Zar", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txt_Unit.Location = New System.Drawing.Point(27, 32)
        Me.txt_Unit.Name = "txt_Unit"
        Me.txt_Unit.Size = New System.Drawing.Size(118, 32)
        Me.txt_Unit.TabIndex = 52
        Me.txt_Unit.TabStop = False
        Me.txt_Unit.Text = "مرکزی"
        Me.txt_Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(693, 152)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 27)
        Me.Label7.TabIndex = 55
        Me.Label7.Text = "جانمایی در انبار"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(693, 197)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 27)
        Me.Label8.TabIndex = 55
        Me.Label8.Text = "تاریخ انقضاء"
        '
        'txt_Exp_month
        '
        Me.txt_Exp_month.Location = New System.Drawing.Point(615, 194)
        Me.txt_Exp_month.MaxLength = 2
        Me.txt_Exp_month.Name = "txt_Exp_month"
        Me.txt_Exp_month.Size = New System.Drawing.Size(33, 34)
        Me.txt_Exp_month.TabIndex = 6
        Me.txt_Exp_month.Text = "09"
        Me.txt_Exp_month.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_Exp_year
        '
        Me.txt_Exp_year.Location = New System.Drawing.Point(533, 194)
        Me.txt_Exp_year.MaxLength = 4
        Me.txt_Exp_year.Name = "txt_Exp_year"
        Me.txt_Exp_year.Size = New System.Drawing.Size(76, 34)
        Me.txt_Exp_year.TabIndex = 7
        Me.txt_Exp_year.Text = "1399"
        Me.txt_Exp_year.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_Category)
        Me.GroupBox1.Controls.Add(Me.txt_Group)
        Me.GroupBox1.Controls.Add(Me.txt_Unit)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("B Zar", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(236, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(237, 162)
        Me.GroupBox1.TabIndex = 56
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "مشخصات کالا"
        '
        'Frm_GInS
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(800, 488)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmb_Store)
        Me.Controls.Add(Me.cmb_Kname)
        Me.Controls.Add(Me.btn_del)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.btn_new)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.btn_return)
        Me.Controls.Add(Me.txt_Exp_year)
        Me.Controls.Add(Me.txt_Exp_month)
        Me.Controls.Add(Me.txt_Exp_day)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_Kcount)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_Locating)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgv_Store)
        Me.Font = New System.Drawing.Font("B Zar", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Frm_GInS"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "نرم افزار انبارداری سامان: فرم ورود کالا به انبار"
        CType(Me.dgv_Store, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmb_Store As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmb_Kname As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_del As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_new As Button
    Friend WithEvents btn_save As Button
    Friend WithEvents btn_return As Button
    Friend WithEvents dgv_Store As DataGridView
    Friend WithEvents txt_Exp_day As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_Kcount As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_Locating As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_Category As TextBox
    Friend WithEvents txt_Group As TextBox
    Friend WithEvents txt_Unit As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_Exp_month As TextBox
    Friend WithEvents txt_Exp_year As TextBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
