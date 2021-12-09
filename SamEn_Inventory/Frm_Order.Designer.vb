<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Order
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Order))
        Me.cmb_Customer = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_Order_No = New System.Windows.Forms.TextBox()
        Me.btn_Save = New System.Windows.Forms.Button()
        Me.btn_New = New System.Windows.Forms.Button()
        Me.btn_Return = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_Exp_year = New System.Windows.Forms.TextBox()
        Me.txt_Exp_month = New System.Windows.Forms.TextBox()
        Me.txt_Exp_day = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_Desc = New System.Windows.Forms.RichTextBox()
        Me.dgv_Store = New System.Windows.Forms.DataGridView()
        Me.ColName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColCount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColStore = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_Kname = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_Kcount = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_Add = New System.Windows.Forms.Button()
        Me.btn_Del = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmb_Store = New System.Windows.Forms.ComboBox()
        Me.txt_Balance = New System.Windows.Forms.TextBox()
        Me.txt_AfterOrder = New System.Windows.Forms.TextBox()
        Me.txt_balance1 = New System.Windows.Forms.TextBox()
        Me.txt_AfterOrder1 = New System.Windows.Forms.TextBox()
        CType(Me.dgv_Store, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmb_Customer
        '
        Me.cmb_Customer.FormattingEnabled = True
        Me.cmb_Customer.Location = New System.Drawing.Point(507, 52)
        Me.cmb_Customer.Name = "cmb_Customer"
        Me.cmb_Customer.Size = New System.Drawing.Size(154, 35)
        Me.cmb_Customer.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(667, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 27)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "شماره ثبت"
        '
        'txt_Order_No
        '
        Me.txt_Order_No.BackColor = System.Drawing.Color.LightSkyBlue
        Me.txt_Order_No.Enabled = False
        Me.txt_Order_No.ForeColor = System.Drawing.Color.Black
        Me.txt_Order_No.Location = New System.Drawing.Point(507, 12)
        Me.txt_Order_No.MaxLength = 10
        Me.txt_Order_No.Name = "txt_Order_No"
        Me.txt_Order_No.Size = New System.Drawing.Size(154, 34)
        Me.txt_Order_No.TabIndex = 100
        Me.txt_Order_No.TabStop = False
        Me.txt_Order_No.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_Save
        '
        Me.btn_Save.Location = New System.Drawing.Point(12, 12)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(168, 39)
        Me.btn_Save.TabIndex = 13
        Me.btn_Save.Text = "ذخیره"
        Me.btn_Save.UseVisualStyleBackColor = True
        '
        'btn_New
        '
        Me.btn_New.Location = New System.Drawing.Point(12, 57)
        Me.btn_New.Name = "btn_New"
        Me.btn_New.Size = New System.Drawing.Size(168, 39)
        Me.btn_New.TabIndex = 14
        Me.btn_New.Text = "فرم جدید"
        Me.btn_New.UseVisualStyleBackColor = True
        '
        'btn_Return
        '
        Me.btn_Return.Location = New System.Drawing.Point(12, 102)
        Me.btn_Return.Name = "btn_Return"
        Me.btn_Return.Size = New System.Drawing.Size(168, 39)
        Me.btn_Return.TabIndex = 15
        Me.btn_Return.Text = "بازگشت"
        Me.btn_Return.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(667, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 27)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "سفارش دهنده"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(667, 96)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 27)
        Me.Label8.TabIndex = 59
        Me.Label8.Text = "تاریخ ثبت سفارش"
        '
        'txt_Exp_year
        '
        Me.txt_Exp_year.Location = New System.Drawing.Point(507, 93)
        Me.txt_Exp_year.MaxLength = 4
        Me.txt_Exp_year.Name = "txt_Exp_year"
        Me.txt_Exp_year.Size = New System.Drawing.Size(76, 34)
        Me.txt_Exp_year.TabIndex = 5
        Me.txt_Exp_year.Text = "1399"
        Me.txt_Exp_year.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_Exp_month
        '
        Me.txt_Exp_month.Location = New System.Drawing.Point(589, 93)
        Me.txt_Exp_month.MaxLength = 2
        Me.txt_Exp_month.Name = "txt_Exp_month"
        Me.txt_Exp_month.Size = New System.Drawing.Size(33, 34)
        Me.txt_Exp_month.TabIndex = 4
        Me.txt_Exp_month.Text = "09"
        Me.txt_Exp_month.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_Exp_day
        '
        Me.txt_Exp_day.Location = New System.Drawing.Point(628, 93)
        Me.txt_Exp_day.MaxLength = 2
        Me.txt_Exp_day.Name = "txt_Exp_day"
        Me.txt_Exp_day.Size = New System.Drawing.Size(33, 34)
        Me.txt_Exp_day.TabIndex = 3
        Me.txt_Exp_day.Text = "26"
        Me.txt_Exp_day.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(393, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 27)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "توضیحات سفارش"
        '
        'txt_Desc
        '
        Me.txt_Desc.Font = New System.Drawing.Font("B Zar", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txt_Desc.Location = New System.Drawing.Point(186, 45)
        Me.txt_Desc.Name = "txt_Desc"
        Me.txt_Desc.Size = New System.Drawing.Size(309, 96)
        Me.txt_Desc.TabIndex = 12
        Me.txt_Desc.Text = ""
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
        Me.dgv_Store.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColName, Me.ColCount, Me.ColStore})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("B Zar", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_Store.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_Store.Enabled = False
        Me.dgv_Store.Location = New System.Drawing.Point(12, 147)
        Me.dgv_Store.Name = "dgv_Store"
        Me.dgv_Store.ReadOnly = True
        Me.dgv_Store.RowHeadersVisible = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New System.Drawing.Font("B Zar", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Store.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_Store.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Store.ShowCellErrors = False
        Me.dgv_Store.ShowEditingIcon = False
        Me.dgv_Store.ShowRowErrors = False
        Me.dgv_Store.Size = New System.Drawing.Size(483, 244)
        Me.dgv_Store.TabIndex = 101
        Me.dgv_Store.TabStop = False
        '
        'ColName
        '
        Me.ColName.FillWeight = 131.9797!
        Me.ColName.HeaderText = "نام کالا"
        Me.ColName.MaxInputLength = 50
        Me.ColName.Name = "ColName"
        Me.ColName.ReadOnly = True
        '
        'ColCount
        '
        Me.ColCount.FillWeight = 68.02032!
        Me.ColCount.HeaderText = "تعداد سفارش"
        Me.ColCount.Name = "ColCount"
        Me.ColCount.ReadOnly = True
        '
        'ColStore
        '
        Me.ColStore.HeaderText = "انبار منتخب"
        Me.ColStore.Name = "ColStore"
        Me.ColStore.ReadOnly = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(667, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 27)
        Me.Label4.TabIndex = 64
        Me.Label4.Text = "انتخاب کالا"
        '
        'cmb_Kname
        '
        Me.cmb_Kname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmb_Kname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_Kname.FormattingEnabled = True
        Me.cmb_Kname.Location = New System.Drawing.Point(507, 133)
        Me.cmb_Kname.Name = "cmb_Kname"
        Me.cmb_Kname.Size = New System.Drawing.Size(154, 35)
        Me.cmb_Kname.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(667, 258)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 27)
        Me.Label5.TabIndex = 65
        Me.Label5.Text = "موجودی فعلی انبار"
        '
        'txt_Kcount
        '
        Me.txt_Kcount.Location = New System.Drawing.Point(507, 174)
        Me.txt_Kcount.Name = "txt_Kcount"
        Me.txt_Kcount.Size = New System.Drawing.Size(154, 34)
        Me.txt_Kcount.TabIndex = 7
        Me.txt_Kcount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(667, 177)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 27)
        Me.Label6.TabIndex = 67
        Me.Label6.Text = "تعداد سفارش"
        '
        'btn_Add
        '
        Me.btn_Add.Location = New System.Drawing.Point(507, 348)
        Me.btn_Add.Name = "btn_Add"
        Me.btn_Add.Size = New System.Drawing.Size(92, 39)
        Me.btn_Add.TabIndex = 10
        Me.btn_Add.Text = "افزودن"
        Me.btn_Add.UseVisualStyleBackColor = True
        '
        'btn_Del
        '
        Me.btn_Del.Location = New System.Drawing.Point(605, 348)
        Me.btn_Del.Name = "btn_Del"
        Me.btn_Del.Size = New System.Drawing.Size(92, 39)
        Me.btn_Del.TabIndex = 11
        Me.btn_Del.Text = "حذف"
        Me.btn_Del.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(667, 298)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(141, 27)
        Me.Label7.TabIndex = 103
        Me.Label7.Text = "مجموع سفارشات ثبت شده"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(667, 217)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 27)
        Me.Label9.TabIndex = 105
        Me.Label9.Text = "انتخاب انبار"
        '
        'cmb_Store
        '
        Me.cmb_Store.FormattingEnabled = True
        Me.cmb_Store.Location = New System.Drawing.Point(507, 214)
        Me.cmb_Store.Name = "cmb_Store"
        Me.cmb_Store.Size = New System.Drawing.Size(154, 35)
        Me.cmb_Store.TabIndex = 2
        '
        'txt_Balance
        '
        Me.txt_Balance.Enabled = False
        Me.txt_Balance.Location = New System.Drawing.Point(605, 255)
        Me.txt_Balance.Name = "txt_Balance"
        Me.txt_Balance.Size = New System.Drawing.Size(56, 34)
        Me.txt_Balance.TabIndex = 8
        Me.txt_Balance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_AfterOrder
        '
        Me.txt_AfterOrder.Enabled = False
        Me.txt_AfterOrder.Location = New System.Drawing.Point(605, 295)
        Me.txt_AfterOrder.Name = "txt_AfterOrder"
        Me.txt_AfterOrder.Size = New System.Drawing.Size(56, 34)
        Me.txt_AfterOrder.TabIndex = 9
        Me.txt_AfterOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_balance1
        '
        Me.txt_balance1.Enabled = False
        Me.txt_balance1.Location = New System.Drawing.Point(507, 255)
        Me.txt_balance1.Name = "txt_balance1"
        Me.txt_balance1.Size = New System.Drawing.Size(92, 34)
        Me.txt_balance1.TabIndex = 8
        Me.txt_balance1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_AfterOrder1
        '
        Me.txt_AfterOrder1.Enabled = False
        Me.txt_AfterOrder1.Location = New System.Drawing.Point(507, 295)
        Me.txt_AfterOrder1.Name = "txt_AfterOrder1"
        Me.txt_AfterOrder1.Size = New System.Drawing.Size(92, 34)
        Me.txt_AfterOrder1.TabIndex = 9
        Me.txt_AfterOrder1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Frm_Order
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(826, 399)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmb_Store)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btn_Del)
        Me.Controls.Add(Me.btn_Add)
        Me.Controls.Add(Me.txt_AfterOrder1)
        Me.Controls.Add(Me.txt_balance1)
        Me.Controls.Add(Me.txt_AfterOrder)
        Me.Controls.Add(Me.txt_Balance)
        Me.Controls.Add(Me.txt_Kcount)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmb_Kname)
        Me.Controls.Add(Me.dgv_Store)
        Me.Controls.Add(Me.txt_Desc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_Exp_year)
        Me.Controls.Add(Me.txt_Exp_month)
        Me.Controls.Add(Me.txt_Exp_day)
        Me.Controls.Add(Me.btn_New)
        Me.Controls.Add(Me.btn_Return)
        Me.Controls.Add(Me.btn_Save)
        Me.Controls.Add(Me.txt_Order_No)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_Customer)
        Me.Font = New System.Drawing.Font("B Zar", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Frm_Order"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "نرم افزار انبارداری سامان: فرم ثبت سفارشات"
        CType(Me.dgv_Store, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmb_Customer As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_Order_No As TextBox
    Friend WithEvents btn_Save As Button
    Friend WithEvents btn_New As Button
    Friend WithEvents btn_Return As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_Exp_year As TextBox
    Friend WithEvents txt_Exp_month As TextBox
    Friend WithEvents txt_Exp_day As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_Desc As RichTextBox
    Friend WithEvents dgv_Store As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents cmb_Kname As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_Kcount As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btn_Add As Button
    Friend WithEvents btn_Del As Button
    Friend WithEvents ColName As DataGridViewTextBoxColumn
    Friend WithEvents ColCount As DataGridViewTextBoxColumn
    Friend WithEvents ColStore As DataGridViewTextBoxColumn
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cmb_Store As ComboBox
    Friend WithEvents txt_Balance As TextBox
    Friend WithEvents txt_AfterOrder As TextBox
    Friend WithEvents txt_balance1 As TextBox
    Friend WithEvents txt_AfterOrder1 As TextBox
End Class
