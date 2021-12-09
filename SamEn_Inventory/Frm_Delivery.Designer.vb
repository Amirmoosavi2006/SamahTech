<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Delivery
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Delivery))
        Me.dgv_Store = New System.Windows.Forms.DataGridView()
        Me.txt_Desc = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_Exp_year = New System.Windows.Forms.TextBox()
        Me.txt_Exp_month = New System.Windows.Forms.TextBox()
        Me.txt_Exp_day = New System.Windows.Forms.TextBox()
        Me.btn_New = New System.Windows.Forms.Button()
        Me.btn_Return = New System.Windows.Forms.Button()
        Me.btn_Print = New System.Windows.Forms.Button()
        Me.txt_Delivery_No = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_Ok = New System.Windows.Forms.Button()
        Me.txt_Delivery_Name = New System.Windows.Forms.TextBox()
        Me.btn_Delivery = New System.Windows.Forms.Button()
        CType(Me.dgv_Store, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.dgv_Store.Location = New System.Drawing.Point(0, 197)
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
        Me.dgv_Store.Size = New System.Drawing.Size(643, 240)
        Me.dgv_Store.TabIndex = 115
        Me.dgv_Store.TabStop = False
        '
        'txt_Desc
        '
        Me.txt_Desc.Font = New System.Drawing.Font("B Zar", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txt_Desc.Location = New System.Drawing.Point(186, 135)
        Me.txt_Desc.Name = "txt_Desc"
        Me.txt_Desc.Size = New System.Drawing.Size(336, 51)
        Me.txt_Desc.TabIndex = 6
        Me.txt_Desc.Text = "7"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(528, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 27)
        Me.Label3.TabIndex = 113
        Me.Label3.Text = "توضیحات برای چاپ"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(528, 98)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 27)
        Me.Label8.TabIndex = 112
        Me.Label8.Text = "تاریخ تحویل"
        '
        'txt_Exp_year
        '
        Me.txt_Exp_year.BackColor = System.Drawing.Color.LightSkyBlue
        Me.txt_Exp_year.Location = New System.Drawing.Point(368, 95)
        Me.txt_Exp_year.MaxLength = 4
        Me.txt_Exp_year.Name = "txt_Exp_year"
        Me.txt_Exp_year.Size = New System.Drawing.Size(76, 34)
        Me.txt_Exp_year.TabIndex = 6
        Me.txt_Exp_year.Text = "1399"
        Me.txt_Exp_year.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_Exp_month
        '
        Me.txt_Exp_month.BackColor = System.Drawing.Color.LightSkyBlue
        Me.txt_Exp_month.Location = New System.Drawing.Point(450, 95)
        Me.txt_Exp_month.MaxLength = 2
        Me.txt_Exp_month.Name = "txt_Exp_month"
        Me.txt_Exp_month.Size = New System.Drawing.Size(33, 34)
        Me.txt_Exp_month.TabIndex = 5
        Me.txt_Exp_month.Text = "09"
        Me.txt_Exp_month.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_Exp_day
        '
        Me.txt_Exp_day.BackColor = System.Drawing.Color.LightSkyBlue
        Me.txt_Exp_day.Location = New System.Drawing.Point(489, 95)
        Me.txt_Exp_day.MaxLength = 2
        Me.txt_Exp_day.Name = "txt_Exp_day"
        Me.txt_Exp_day.Size = New System.Drawing.Size(33, 34)
        Me.txt_Exp_day.TabIndex = 4
        Me.txt_Exp_day.Text = "26"
        Me.txt_Exp_day.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_New
        '
        Me.btn_New.Location = New System.Drawing.Point(12, 102)
        Me.btn_New.Name = "btn_New"
        Me.btn_New.Size = New System.Drawing.Size(168, 39)
        Me.btn_New.TabIndex = 10
        Me.btn_New.Text = "فرم جدید"
        Me.btn_New.UseVisualStyleBackColor = True
        '
        'btn_Return
        '
        Me.btn_Return.Location = New System.Drawing.Point(12, 147)
        Me.btn_Return.Name = "btn_Return"
        Me.btn_Return.Size = New System.Drawing.Size(168, 39)
        Me.btn_Return.TabIndex = 11
        Me.btn_Return.Text = "بازگشت"
        Me.btn_Return.UseVisualStyleBackColor = True
        '
        'btn_Print
        '
        Me.btn_Print.Location = New System.Drawing.Point(12, 57)
        Me.btn_Print.Name = "btn_Print"
        Me.btn_Print.Size = New System.Drawing.Size(168, 39)
        Me.btn_Print.TabIndex = 8
        Me.btn_Print.Text = "چاپ سفارش"
        Me.btn_Print.UseVisualStyleBackColor = True
        '
        'txt_Delivery_No
        '
        Me.txt_Delivery_No.BackColor = System.Drawing.Color.LightSkyBlue
        Me.txt_Delivery_No.ForeColor = System.Drawing.Color.Black
        Me.txt_Delivery_No.Location = New System.Drawing.Point(368, 15)
        Me.txt_Delivery_No.MaxLength = 10
        Me.txt_Delivery_No.Name = "txt_Delivery_No"
        Me.txt_Delivery_No.Size = New System.Drawing.Size(154, 34)
        Me.txt_Delivery_No.TabIndex = 1
        Me.txt_Delivery_No.TabStop = False
        Me.txt_Delivery_No.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(528, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 27)
        Me.Label2.TabIndex = 104
        Me.Label2.Text = "تحویل گیرنده"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(528, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 27)
        Me.Label1.TabIndex = 105
        Me.Label1.Text = "شماره ثبت"
        '
        'btn_Ok
        '
        Me.btn_Ok.Location = New System.Drawing.Point(277, 15)
        Me.btn_Ok.Name = "btn_Ok"
        Me.btn_Ok.Size = New System.Drawing.Size(85, 34)
        Me.btn_Ok.TabIndex = 2
        Me.btn_Ok.Text = "انتخاب"
        Me.btn_Ok.UseVisualStyleBackColor = True
        '
        'txt_Delivery_Name
        '
        Me.txt_Delivery_Name.BackColor = System.Drawing.Color.LightSkyBlue
        Me.txt_Delivery_Name.ForeColor = System.Drawing.Color.Black
        Me.txt_Delivery_Name.Location = New System.Drawing.Point(368, 55)
        Me.txt_Delivery_Name.MaxLength = 10
        Me.txt_Delivery_Name.Name = "txt_Delivery_Name"
        Me.txt_Delivery_Name.Size = New System.Drawing.Size(154, 34)
        Me.txt_Delivery_Name.TabIndex = 3
        Me.txt_Delivery_Name.TabStop = False
        Me.txt_Delivery_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_Delivery
        '
        Me.btn_Delivery.Location = New System.Drawing.Point(12, 12)
        Me.btn_Delivery.Name = "btn_Delivery"
        Me.btn_Delivery.Size = New System.Drawing.Size(168, 39)
        Me.btn_Delivery.TabIndex = 9
        Me.btn_Delivery.Text = "تحویل سفارش"
        Me.btn_Delivery.UseVisualStyleBackColor = True
        '
        'Frm_Delivery
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(643, 437)
        Me.Controls.Add(Me.dgv_Store)
        Me.Controls.Add(Me.txt_Desc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_Exp_year)
        Me.Controls.Add(Me.txt_Exp_month)
        Me.Controls.Add(Me.txt_Exp_day)
        Me.Controls.Add(Me.btn_New)
        Me.Controls.Add(Me.btn_Return)
        Me.Controls.Add(Me.btn_Ok)
        Me.Controls.Add(Me.btn_Delivery)
        Me.Controls.Add(Me.btn_Print)
        Me.Controls.Add(Me.txt_Delivery_Name)
        Me.Controls.Add(Me.txt_Delivery_No)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("B Zar", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Frm_Delivery"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "نرم افزار انبارداری سامان: فرم تحویل سفارشات"
        CType(Me.dgv_Store, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_Store As DataGridView
    Friend WithEvents txt_Desc As RichTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_Exp_year As TextBox
    Friend WithEvents txt_Exp_month As TextBox
    Friend WithEvents txt_Exp_day As TextBox
    Friend WithEvents btn_New As Button
    Friend WithEvents btn_Return As Button
    Friend WithEvents btn_Print As Button
    Friend WithEvents txt_Delivery_No As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_Ok As Button
    Friend WithEvents txt_Delivery_Name As TextBox
    Friend WithEvents btn_Delivery As Button
End Class
