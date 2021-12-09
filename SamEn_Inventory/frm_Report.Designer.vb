<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Report
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Report))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btn_Exp2 = New System.Windows.Forms.Button()
        Me.btn_Exp1 = New System.Windows.Forms.Button()
        Me.btn_Fin2 = New System.Windows.Forms.Button()
        Me.btn_Fin1 = New System.Windows.Forms.Button()
        Me.btn_All = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_Exp_year = New System.Windows.Forms.TextBox()
        Me.txt_Exp_month = New System.Windows.Forms.TextBox()
        Me.txt_Exp_day = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.dgv_Store = New System.Windows.Forms.DataGridView()
        Me.btn_Return = New System.Windows.Forms.Button()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgv_Store, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabControl1.ItemSize = New System.Drawing.Size(180, 40)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.RightToLeftLayout = True
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(848, 244)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage1.Controls.Add(Me.btn_Exp2)
        Me.TabPage1.Controls.Add(Me.btn_Exp1)
        Me.TabPage1.Controls.Add(Me.btn_Fin2)
        Me.TabPage1.Controls.Add(Me.btn_Fin1)
        Me.TabPage1.Controls.Add(Me.btn_All)
        Me.TabPage1.Location = New System.Drawing.Point(4, 44)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(840, 196)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "موجودی کالا"
        '
        'btn_Exp2
        '
        Me.btn_Exp2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Exp2.Font = New System.Drawing.Font("B Zar", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btn_Exp2.Location = New System.Drawing.Point(7, 19)
        Me.btn_Exp2.Name = "btn_Exp2"
        Me.btn_Exp2.Size = New System.Drawing.Size(160, 160)
        Me.btn_Exp2.TabIndex = 63
        Me.btn_Exp2.Text = "کالاهای منقضی شده"
        Me.btn_Exp2.UseVisualStyleBackColor = False
        '
        'btn_Exp1
        '
        Me.btn_Exp1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_Exp1.Font = New System.Drawing.Font("B Zar", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btn_Exp1.Location = New System.Drawing.Point(173, 19)
        Me.btn_Exp1.Name = "btn_Exp1"
        Me.btn_Exp1.Size = New System.Drawing.Size(160, 160)
        Me.btn_Exp1.TabIndex = 63
        Me.btn_Exp1.Text = "کالاهای درحال انقضاء"
        Me.btn_Exp1.UseVisualStyleBackColor = False
        '
        'btn_Fin2
        '
        Me.btn_Fin2.BackColor = System.Drawing.Color.Red
        Me.btn_Fin2.Font = New System.Drawing.Font("B Zar", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btn_Fin2.Location = New System.Drawing.Point(339, 19)
        Me.btn_Fin2.Name = "btn_Fin2"
        Me.btn_Fin2.Size = New System.Drawing.Size(160, 160)
        Me.btn_Fin2.TabIndex = 63
        Me.btn_Fin2.Text = "کالاهای تمام شده"
        Me.btn_Fin2.UseVisualStyleBackColor = False
        '
        'btn_Fin1
        '
        Me.btn_Fin1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_Fin1.Font = New System.Drawing.Font("B Zar", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btn_Fin1.Location = New System.Drawing.Point(505, 19)
        Me.btn_Fin1.Name = "btn_Fin1"
        Me.btn_Fin1.Size = New System.Drawing.Size(160, 160)
        Me.btn_Fin1.TabIndex = 63
        Me.btn_Fin1.Text = "کالاهای روبه اتمام"
        Me.btn_Fin1.UseVisualStyleBackColor = False
        '
        'btn_All
        '
        Me.btn_All.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_All.Font = New System.Drawing.Font("B Zar", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btn_All.Location = New System.Drawing.Point(671, 19)
        Me.btn_All.Name = "btn_All"
        Me.btn_All.Size = New System.Drawing.Size(160, 160)
        Me.btn_All.TabIndex = 63
        Me.btn_All.Text = "تمامی کالاها"
        Me.btn_All.UseVisualStyleBackColor = False
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.txt_Exp_year)
        Me.TabPage2.Controls.Add(Me.txt_Exp_month)
        Me.TabPage2.Controls.Add(Me.txt_Exp_day)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.TextBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 44)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(840, 196)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "سفارشات"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(444, 111)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 27)
        Me.Label8.TabIndex = 70
        Me.Label8.Text = "تاریخ ثبت سفارش"
        '
        'txt_Exp_year
        '
        Me.txt_Exp_year.Location = New System.Drawing.Point(284, 108)
        Me.txt_Exp_year.MaxLength = 4
        Me.txt_Exp_year.Name = "txt_Exp_year"
        Me.txt_Exp_year.Size = New System.Drawing.Size(76, 34)
        Me.txt_Exp_year.TabIndex = 69
        Me.txt_Exp_year.Text = "1399"
        Me.txt_Exp_year.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_Exp_month
        '
        Me.txt_Exp_month.Location = New System.Drawing.Point(366, 108)
        Me.txt_Exp_month.MaxLength = 2
        Me.txt_Exp_month.Name = "txt_Exp_month"
        Me.txt_Exp_month.Size = New System.Drawing.Size(33, 34)
        Me.txt_Exp_month.TabIndex = 68
        Me.txt_Exp_month.Text = "09"
        Me.txt_Exp_month.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_Exp_day
        '
        Me.txt_Exp_day.Location = New System.Drawing.Point(405, 108)
        Me.txt_Exp_day.MaxLength = 2
        Me.txt_Exp_day.Name = "txt_Exp_day"
        Me.txt_Exp_day.Size = New System.Drawing.Size(33, 34)
        Me.txt_Exp_day.TabIndex = 67
        Me.txt_Exp_day.Text = "26"
        Me.txt_Exp_day.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(497, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 27)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "Label1"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(273, 49)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(87, 34)
        Me.TextBox1.TabIndex = 65
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage3.Location = New System.Drawing.Point(4, 44)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(840, 196)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "مشتریان"
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
        Me.dgv_Store.Location = New System.Drawing.Point(0, 295)
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
        Me.dgv_Store.Size = New System.Drawing.Size(848, 486)
        Me.dgv_Store.TabIndex = 116
        Me.dgv_Store.TabStop = False
        '
        'btn_Return
        '
        Me.btn_Return.Location = New System.Drawing.Point(12, 250)
        Me.btn_Return.Name = "btn_Return"
        Me.btn_Return.Size = New System.Drawing.Size(168, 39)
        Me.btn_Return.TabIndex = 117
        Me.btn_Return.Text = "بازگشت"
        Me.btn_Return.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Location = New System.Drawing.Point(4, 44)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(840, 196)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "ارزش کالا"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'frm_Report
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(848, 781)
        Me.Controls.Add(Me.btn_Return)
        Me.Controls.Add(Me.dgv_Store)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("B Zar", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_Report"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_Report"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dgv_Store, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents dgv_Store As DataGridView
    Friend WithEvents btn_Exp2 As Button
    Friend WithEvents btn_Exp1 As Button
    Friend WithEvents btn_Fin2 As Button
    Friend WithEvents btn_Fin1 As Button
    Friend WithEvents btn_All As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_Exp_year As TextBox
    Friend WithEvents txt_Exp_month As TextBox
    Friend WithEvents txt_Exp_day As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btn_Return As Button
    Friend WithEvents TabPage4 As TabPage
End Class
