<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_main))
        Me.btn_Store = New System.Windows.Forms.Button()
        Me.lbl_DateTime = New System.Windows.Forms.Label()
        Me.btn_Customers = New System.Windows.Forms.Button()
        Me.btn_Groups = New System.Windows.Forms.Button()
        Me.bnt_Category = New System.Windows.Forms.Button()
        Me.btn_Units = New System.Windows.Forms.Button()
        Me.btn_Goods = New System.Windows.Forms.Button()
        Me.btn_GIS = New System.Windows.Forms.Button()
        Me.btn_Users = New System.Windows.Forms.Button()
        Me.btn_Support = New System.Windows.Forms.Button()
        Me.btn_Exit = New System.Windows.Forms.Button()
        Me.lbl_day_name = New System.Windows.Forms.Label()
        Me.btn_Archive = New System.Windows.Forms.Button()
        Me.btn_Give_Order = New System.Windows.Forms.Button()
        Me.btn_Order = New System.Windows.Forms.Button()
        Me.btn_Report = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_percent = New System.Windows.Forms.Label()
        Me.lbl_Order = New System.Windows.Forms.Label()
        Me.lbl_Delivery = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.ProgressBar3 = New System.Windows.Forms.ProgressBar()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Store
        '
        Me.btn_Store.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Store.Location = New System.Drawing.Point(528, 12)
        Me.btn_Store.Name = "btn_Store"
        Me.btn_Store.Size = New System.Drawing.Size(244, 46)
        Me.btn_Store.TabIndex = 0
        Me.btn_Store.Text = "تعریف انبار"
        Me.btn_Store.UseVisualStyleBackColor = True
        '
        'lbl_DateTime
        '
        Me.lbl_DateTime.BackColor = System.Drawing.Color.LightSkyBlue
        Me.lbl_DateTime.Font = New System.Drawing.Font("B Titr", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbl_DateTime.ForeColor = System.Drawing.Color.Green
        Me.lbl_DateTime.Location = New System.Drawing.Point(528, 451)
        Me.lbl_DateTime.Name = "lbl_DateTime"
        Me.lbl_DateTime.Size = New System.Drawing.Size(244, 74)
        Me.lbl_DateTime.TabIndex = 1
        Me.lbl_DateTime.Text = "امروز: شنبه"
        Me.lbl_DateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_Customers
        '
        Me.btn_Customers.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Customers.Location = New System.Drawing.Point(528, 64)
        Me.btn_Customers.Name = "btn_Customers"
        Me.btn_Customers.Size = New System.Drawing.Size(244, 46)
        Me.btn_Customers.TabIndex = 0
        Me.btn_Customers.Text = "لیست تحویل گیرندگان"
        Me.btn_Customers.UseVisualStyleBackColor = True
        '
        'btn_Groups
        '
        Me.btn_Groups.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Groups.Location = New System.Drawing.Point(528, 116)
        Me.btn_Groups.Name = "btn_Groups"
        Me.btn_Groups.Size = New System.Drawing.Size(244, 46)
        Me.btn_Groups.TabIndex = 0
        Me.btn_Groups.Text = "تعریف گروه اقلام"
        Me.btn_Groups.UseVisualStyleBackColor = True
        '
        'bnt_Category
        '
        Me.bnt_Category.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bnt_Category.Location = New System.Drawing.Point(528, 168)
        Me.bnt_Category.Name = "bnt_Category"
        Me.bnt_Category.Size = New System.Drawing.Size(244, 46)
        Me.bnt_Category.TabIndex = 0
        Me.bnt_Category.Text = "تعریف دسته بندی ها"
        Me.bnt_Category.UseVisualStyleBackColor = True
        '
        'btn_Units
        '
        Me.btn_Units.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Units.Location = New System.Drawing.Point(528, 220)
        Me.btn_Units.Name = "btn_Units"
        Me.btn_Units.Size = New System.Drawing.Size(244, 46)
        Me.btn_Units.TabIndex = 0
        Me.btn_Units.Text = "واحد سنجش کالا"
        Me.btn_Units.UseVisualStyleBackColor = True
        '
        'btn_Goods
        '
        Me.btn_Goods.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Goods.Location = New System.Drawing.Point(528, 272)
        Me.btn_Goods.Name = "btn_Goods"
        Me.btn_Goods.Size = New System.Drawing.Size(244, 46)
        Me.btn_Goods.TabIndex = 0
        Me.btn_Goods.Text = "تعریف کالا"
        Me.btn_Goods.UseVisualStyleBackColor = True
        '
        'btn_GIS
        '
        Me.btn_GIS.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_GIS.Location = New System.Drawing.Point(528, 324)
        Me.btn_GIS.Name = "btn_GIS"
        Me.btn_GIS.Size = New System.Drawing.Size(244, 46)
        Me.btn_GIS.TabIndex = 0
        Me.btn_GIS.Text = "ورود کالا به انبار"
        Me.btn_GIS.UseVisualStyleBackColor = True
        '
        'btn_Users
        '
        Me.btn_Users.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Users.Location = New System.Drawing.Point(12, 220)
        Me.btn_Users.Name = "btn_Users"
        Me.btn_Users.Size = New System.Drawing.Size(244, 46)
        Me.btn_Users.TabIndex = 0
        Me.btn_Users.Text = "لیست کاربران"
        Me.btn_Users.UseVisualStyleBackColor = True
        '
        'btn_Support
        '
        Me.btn_Support.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Support.Location = New System.Drawing.Point(12, 272)
        Me.btn_Support.Name = "btn_Support"
        Me.btn_Support.Size = New System.Drawing.Size(244, 46)
        Me.btn_Support.TabIndex = 0
        Me.btn_Support.Text = "پشتیبانی"
        Me.btn_Support.UseVisualStyleBackColor = True
        '
        'btn_Exit
        '
        Me.btn_Exit.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn_Exit.Location = New System.Drawing.Point(12, 324)
        Me.btn_Exit.Name = "btn_Exit"
        Me.btn_Exit.Size = New System.Drawing.Size(244, 46)
        Me.btn_Exit.TabIndex = 0
        Me.btn_Exit.Text = "خروج"
        Me.btn_Exit.UseVisualStyleBackColor = False
        '
        'lbl_day_name
        '
        Me.lbl_day_name.BackColor = System.Drawing.Color.LightSkyBlue
        Me.lbl_day_name.Font = New System.Drawing.Font("B Titr", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbl_day_name.ForeColor = System.Drawing.Color.Green
        Me.lbl_day_name.Location = New System.Drawing.Point(528, 373)
        Me.lbl_day_name.Name = "lbl_day_name"
        Me.lbl_day_name.Size = New System.Drawing.Size(244, 78)
        Me.lbl_day_name.TabIndex = 1
        Me.lbl_day_name.Text = "امروز: شنبه"
        Me.lbl_day_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_Archive
        '
        Me.btn_Archive.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Archive.Location = New System.Drawing.Point(12, 168)
        Me.btn_Archive.Name = "btn_Archive"
        Me.btn_Archive.Size = New System.Drawing.Size(244, 46)
        Me.btn_Archive.TabIndex = 2
        Me.btn_Archive.Text = "بایگانی"
        Me.btn_Archive.UseVisualStyleBackColor = True
        '
        'btn_Give_Order
        '
        Me.btn_Give_Order.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Give_Order.Location = New System.Drawing.Point(12, 64)
        Me.btn_Give_Order.Name = "btn_Give_Order"
        Me.btn_Give_Order.Size = New System.Drawing.Size(244, 46)
        Me.btn_Give_Order.TabIndex = 2
        Me.btn_Give_Order.Text = "فرم تحویل سفارش"
        Me.btn_Give_Order.UseVisualStyleBackColor = True
        '
        'btn_Order
        '
        Me.btn_Order.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Order.Location = New System.Drawing.Point(12, 12)
        Me.btn_Order.Name = "btn_Order"
        Me.btn_Order.Size = New System.Drawing.Size(244, 46)
        Me.btn_Order.TabIndex = 2
        Me.btn_Order.Text = "ثبت سفارش"
        Me.btn_Order.UseVisualStyleBackColor = True
        '
        'btn_Report
        '
        Me.btn_Report.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Report.Location = New System.Drawing.Point(12, 116)
        Me.btn_Report.Name = "btn_Report"
        Me.btn_Report.Size = New System.Drawing.Size(244, 46)
        Me.btn_Report.TabIndex = 2
        Me.btn_Report.Text = "گزارشات"
        Me.btn_Report.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Label1.Font = New System.Drawing.Font("B Titr", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Green
        Me.Label1.Location = New System.Drawing.Point(82, 424)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 51)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "اسناد دردست اقدام"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Label2.Font = New System.Drawing.Font("B Titr", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Green
        Me.Label2.Location = New System.Drawing.Point(82, 372)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(174, 52)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "اسناد تحویل داده شده:"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Label3.Font = New System.Drawing.Font("B Titr", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Green
        Me.Label3.Location = New System.Drawing.Point(82, 475)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(174, 51)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "درصد انجام"
        '
        'lbl_percent
        '
        Me.lbl_percent.BackColor = System.Drawing.Color.LightSkyBlue
        Me.lbl_percent.Font = New System.Drawing.Font("B Titr", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbl_percent.ForeColor = System.Drawing.Color.Green
        Me.lbl_percent.Location = New System.Drawing.Point(12, 475)
        Me.lbl_percent.Name = "lbl_percent"
        Me.lbl_percent.Size = New System.Drawing.Size(84, 51)
        Me.lbl_percent.TabIndex = 5
        Me.lbl_percent.Text = "60%"
        Me.lbl_percent.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl_Order
        '
        Me.lbl_Order.BackColor = System.Drawing.Color.LightSkyBlue
        Me.lbl_Order.Font = New System.Drawing.Font("B Titr", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbl_Order.ForeColor = System.Drawing.Color.Green
        Me.lbl_Order.Location = New System.Drawing.Point(12, 424)
        Me.lbl_Order.Name = "lbl_Order"
        Me.lbl_Order.Size = New System.Drawing.Size(84, 51)
        Me.lbl_Order.TabIndex = 6
        Me.lbl_Order.Text = "30"
        Me.lbl_Order.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl_Delivery
        '
        Me.lbl_Delivery.BackColor = System.Drawing.Color.LightSkyBlue
        Me.lbl_Delivery.Font = New System.Drawing.Font("B Titr", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbl_Delivery.ForeColor = System.Drawing.Color.Green
        Me.lbl_Delivery.Location = New System.Drawing.Point(12, 372)
        Me.lbl_Delivery.Name = "lbl_Delivery"
        Me.lbl_Delivery.Size = New System.Drawing.Size(84, 52)
        Me.lbl_Delivery.TabIndex = 7
        Me.lbl_Delivery.Text = "45"
        Me.lbl_Delivery.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.Color.DodgerBlue
        Me.ProgressBar1.ForeColor = System.Drawing.Color.Black
        Me.ProgressBar1.Location = New System.Drawing.Point(18, 399)
        Me.ProgressBar1.MarqueeAnimationSpeed = 1000
        Me.ProgressBar1.Maximum = 75
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ProgressBar1.Size = New System.Drawing.Size(233, 19)
        Me.ProgressBar1.Step = 1
        Me.ProgressBar1.TabIndex = 8
        Me.ProgressBar1.Value = 45
        '
        'ProgressBar2
        '
        Me.ProgressBar2.BackColor = System.Drawing.Color.DodgerBlue
        Me.ProgressBar2.ForeColor = System.Drawing.Color.Black
        Me.ProgressBar2.Location = New System.Drawing.Point(18, 451)
        Me.ProgressBar2.MarqueeAnimationSpeed = 1000
        Me.ProgressBar2.Maximum = 75
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ProgressBar2.Size = New System.Drawing.Size(233, 19)
        Me.ProgressBar2.Step = 1
        Me.ProgressBar2.TabIndex = 9
        Me.ProgressBar2.Value = 30
        '
        'ProgressBar3
        '
        Me.ProgressBar3.BackColor = System.Drawing.Color.DodgerBlue
        Me.ProgressBar3.ForeColor = System.Drawing.Color.Black
        Me.ProgressBar3.Location = New System.Drawing.Point(18, 502)
        Me.ProgressBar3.MarqueeAnimationSpeed = 1000
        Me.ProgressBar3.Name = "ProgressBar3"
        Me.ProgressBar3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ProgressBar3.Size = New System.Drawing.Size(233, 19)
        Me.ProgressBar3.Step = 1
        Me.ProgressBar3.TabIndex = 9
        Me.ProgressBar3.Value = 60
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("IranNastaliq", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label7.Location = New System.Drawing.Point(393, 249)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 62)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "نرم افزار"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("IranNastaliq", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label8.Location = New System.Drawing.Point(331, 192)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(125, 43)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "سازمان بازرسی شهرداری تهران"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("IranNastaliq", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label9.Location = New System.Drawing.Point(335, 311)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 62)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "انبارداری"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("IranNastaliq", 32.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label10.Location = New System.Drawing.Point(280, 372)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 83)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "سامان"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SamEn_Inventory.My.Resources.Resources._01
        Me.PictureBox1.Location = New System.Drawing.Point(298, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(190, 183)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'frm_main
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.CancelButton = Me.btn_Exit
        Me.ClientSize = New System.Drawing.Size(781, 530)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ProgressBar3)
        Me.Controls.Add(Me.ProgressBar2)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.lbl_percent)
        Me.Controls.Add(Me.lbl_Order)
        Me.Controls.Add(Me.lbl_Delivery)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_Order)
        Me.Controls.Add(Me.btn_Report)
        Me.Controls.Add(Me.btn_Give_Order)
        Me.Controls.Add(Me.btn_Archive)
        Me.Controls.Add(Me.lbl_day_name)
        Me.Controls.Add(Me.lbl_DateTime)
        Me.Controls.Add(Me.btn_Exit)
        Me.Controls.Add(Me.btn_GIS)
        Me.Controls.Add(Me.btn_Support)
        Me.Controls.Add(Me.btn_Goods)
        Me.Controls.Add(Me.btn_Users)
        Me.Controls.Add(Me.btn_Units)
        Me.Controls.Add(Me.bnt_Category)
        Me.Controls.Add(Me.btn_Groups)
        Me.Controls.Add(Me.btn_Customers)
        Me.Controls.Add(Me.btn_Store)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label10)
        Me.Font = New System.Drawing.Font("B Zar", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_main"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "نرم افزار انبارداری سامان - صفحه اصلی"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_Store As Button
    Friend WithEvents lbl_DateTime As Label
    Friend WithEvents btn_Customers As Button
    Friend WithEvents btn_Groups As Button
    Friend WithEvents bnt_Category As Button
    Friend WithEvents btn_Units As Button
    Friend WithEvents btn_Goods As Button
    Friend WithEvents btn_GIS As Button
    Friend WithEvents btn_Users As Button
    Friend WithEvents btn_Support As Button
    Friend WithEvents btn_Exit As Button
    Friend WithEvents lbl_day_name As Label
    Friend WithEvents btn_Archive As Button
    Friend WithEvents btn_Give_Order As Button
    Friend WithEvents btn_Order As Button
    Friend WithEvents btn_Report As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_percent As Label
    Friend WithEvents lbl_Order As Label
    Friend WithEvents lbl_Delivery As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents ProgressBar2 As ProgressBar
    Friend WithEvents ProgressBar3 As ProgressBar
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
End Class
