<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Delivered
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Delivered))
        Me.dgv_Store = New System.Windows.Forms.DataGridView()
        Me.btn_Return = New System.Windows.Forms.Button()
        Me.btn_Show_Orders = New System.Windows.Forms.Button()
        Me.btn_Print_Reports = New System.Windows.Forms.Button()
        Me.txt_Order_No = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_Customer = New System.Windows.Forms.TextBox()
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
        Me.dgv_Store.Location = New System.Drawing.Point(0, 152)
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
        Me.dgv_Store.Size = New System.Drawing.Size(874, 461)
        Me.dgv_Store.TabIndex = 102
        Me.dgv_Store.TabStop = False
        '
        'btn_Return
        '
        Me.btn_Return.Location = New System.Drawing.Point(12, 102)
        Me.btn_Return.Name = "btn_Return"
        Me.btn_Return.Size = New System.Drawing.Size(168, 39)
        Me.btn_Return.TabIndex = 103
        Me.btn_Return.Text = "بازگشت"
        Me.btn_Return.UseVisualStyleBackColor = True
        '
        'btn_Show_Orders
        '
        Me.btn_Show_Orders.Location = New System.Drawing.Point(12, 57)
        Me.btn_Show_Orders.Name = "btn_Show_Orders"
        Me.btn_Show_Orders.Size = New System.Drawing.Size(168, 39)
        Me.btn_Show_Orders.TabIndex = 103
        Me.btn_Show_Orders.Text = "نمایش سفارشات"
        Me.btn_Show_Orders.UseVisualStyleBackColor = True
        '
        'btn_Print_Reports
        '
        Me.btn_Print_Reports.Location = New System.Drawing.Point(12, 12)
        Me.btn_Print_Reports.Name = "btn_Print_Reports"
        Me.btn_Print_Reports.Size = New System.Drawing.Size(168, 39)
        Me.btn_Print_Reports.TabIndex = 103
        Me.btn_Print_Reports.Text = "چاپ گزارش"
        Me.btn_Print_Reports.UseVisualStyleBackColor = True
        '
        'txt_Order_No
        '
        Me.txt_Order_No.BackColor = System.Drawing.Color.LightSkyBlue
        Me.txt_Order_No.Enabled = False
        Me.txt_Order_No.ForeColor = System.Drawing.Color.Black
        Me.txt_Order_No.Location = New System.Drawing.Point(641, 102)
        Me.txt_Order_No.MaxLength = 10
        Me.txt_Order_No.Name = "txt_Order_No"
        Me.txt_Order_No.Size = New System.Drawing.Size(154, 34)
        Me.txt_Order_No.TabIndex = 113
        Me.txt_Order_No.TabStop = False
        Me.txt_Order_No.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(556, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 27)
        Me.Label2.TabIndex = 105
        Me.Label2.Text = "سفارش دهنده"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(801, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 27)
        Me.Label1.TabIndex = 106
        Me.Label1.Text = "شماره ثبت"
        '
        'txt_Customer
        '
        Me.txt_Customer.BackColor = System.Drawing.Color.LightSkyBlue
        Me.txt_Customer.Enabled = False
        Me.txt_Customer.ForeColor = System.Drawing.Color.Black
        Me.txt_Customer.Location = New System.Drawing.Point(396, 102)
        Me.txt_Customer.MaxLength = 10
        Me.txt_Customer.Name = "txt_Customer"
        Me.txt_Customer.Size = New System.Drawing.Size(154, 34)
        Me.txt_Customer.TabIndex = 113
        Me.txt_Customer.TabStop = False
        Me.txt_Customer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frm_Delivered
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(874, 613)
        Me.Controls.Add(Me.txt_Customer)
        Me.Controls.Add(Me.txt_Order_No)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_Print_Reports)
        Me.Controls.Add(Me.btn_Show_Orders)
        Me.Controls.Add(Me.btn_Return)
        Me.Controls.Add(Me.dgv_Store)
        Me.Font = New System.Drawing.Font("B Zar", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_Delivered"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "نرم افزار انبارداری سامان: لیست سفارشات تحویل داده شده"
        CType(Me.dgv_Store, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_Store As DataGridView
    Friend WithEvents btn_Return As Button
    Friend WithEvents btn_Show_Orders As Button
    Friend WithEvents btn_Print_Reports As Button
    Friend WithEvents txt_Order_No As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_Customer As TextBox
End Class
