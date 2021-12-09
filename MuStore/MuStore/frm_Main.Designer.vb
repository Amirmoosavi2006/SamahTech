<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Main
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Main))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btn_Add = New System.Windows.Forms.ToolStripButton()
        Me.btn_Find = New System.Windows.Forms.ToolStripButton()
        Me.btn_Reports = New System.Windows.Forms.ToolStripButton()
        Me.btn_Setting = New System.Windows.Forms.ToolStripButton()
        Me.btn_Exit = New System.Windows.Forms.ToolStripButton()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.WearhouseReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalseReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.FactorPrint = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SalseChange = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdChange = New System.Windows.Forms.ToolStripMenuItem()
        Me.KindChange = New System.Windows.Forms.ToolStripMenuItem()
        Me.PassChange = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddPanel = New System.Windows.Forms.Panel()
        Me.DGVStore = New System.Windows.Forms.DataGridView()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.AddPanel.SuspendLayout()
        CType(Me.DGVStore, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Right
        Me.ToolStrip1.Font = New System.Drawing.Font("B Koodak", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_Add, Me.btn_Find, Me.btn_Reports, Me.btn_Setting, Me.btn_Exit})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip1.Location = New System.Drawing.Point(898, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(110, 729)
        Me.ToolStrip1.Stretch = True
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btn_Add
        '
        Me.btn_Add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_Add.Image = CType(resources.GetObject("btn_Add.Image"), System.Drawing.Image)
        Me.btn_Add.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btn_Add.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Add.Name = "btn_Add"
        Me.btn_Add.Size = New System.Drawing.Size(108, 68)
        Me.btn_Add.Text = "ToolStripButton1"
        Me.btn_Add.ToolTipText = "افزودن کالا"
        '
        'btn_Find
        '
        Me.btn_Find.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_Find.Image = CType(resources.GetObject("btn_Find.Image"), System.Drawing.Image)
        Me.btn_Find.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btn_Find.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Find.Name = "btn_Find"
        Me.btn_Find.Size = New System.Drawing.Size(108, 68)
        Me.btn_Find.Text = "ToolStripButton2"
        Me.btn_Find.ToolTipText = "جستجو"
        '
        'btn_Reports
        '
        Me.btn_Reports.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_Reports.Image = CType(resources.GetObject("btn_Reports.Image"), System.Drawing.Image)
        Me.btn_Reports.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btn_Reports.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Reports.Name = "btn_Reports"
        Me.btn_Reports.Size = New System.Drawing.Size(108, 68)
        Me.btn_Reports.Text = "ToolStripButton4"
        Me.btn_Reports.ToolTipText = "گزارشات"
        '
        'btn_Setting
        '
        Me.btn_Setting.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_Setting.Image = CType(resources.GetObject("btn_Setting.Image"), System.Drawing.Image)
        Me.btn_Setting.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btn_Setting.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Setting.Name = "btn_Setting"
        Me.btn_Setting.Size = New System.Drawing.Size(108, 68)
        Me.btn_Setting.Text = "ToolStripButton3"
        Me.btn_Setting.ToolTipText = "تنظیمات"
        '
        'btn_Exit
        '
        Me.btn_Exit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_Exit.Image = CType(resources.GetObject("btn_Exit.Image"), System.Drawing.Image)
        Me.btn_Exit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btn_Exit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Exit.Name = "btn_Exit"
        Me.btn_Exit.Size = New System.Drawing.Size(108, 68)
        Me.btn_Exit.Text = "ToolStripButton5"
        Me.btn_Exit.ToolTipText = "خروج"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.BackColor = System.Drawing.Color.Khaki
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("B Compset", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WearhouseReport, Me.SalseReport, Me.FactorPrint})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ContextMenuStrip1.ShowImageMargin = False
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(134, 100)
        '
        'WearhouseReport
        '
        Me.WearhouseReport.Name = "WearhouseReport"
        Me.WearhouseReport.ShortcutKeyDisplayString = ""
        Me.WearhouseReport.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.WearhouseReport.ShowShortcutKeys = False
        Me.WearhouseReport.Size = New System.Drawing.Size(133, 32)
        Me.WearhouseReport.Text = "موجودی انبار"
        Me.WearhouseReport.ToolTipText = "Press F2 ..."
        '
        'SalseReport
        '
        Me.SalseReport.Name = "SalseReport"
        Me.SalseReport.Size = New System.Drawing.Size(133, 32)
        Me.SalseReport.Text = "وضعیت فروش"
        '
        'FactorPrint
        '
        Me.FactorPrint.Name = "FactorPrint"
        Me.FactorPrint.Size = New System.Drawing.Size(133, 32)
        Me.FactorPrint.Text = "صدور فاکتور"
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.BackColor = System.Drawing.Color.DarkKhaki
        Me.ContextMenuStrip2.Font = New System.Drawing.Font("B Compset", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalseChange, Me.AdChange, Me.KindChange, Me.PassChange})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.ShowImageMargin = False
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(134, 132)
        '
        'SalseChange
        '
        Me.SalseChange.Name = "SalseChange"
        Me.SalseChange.Size = New System.Drawing.Size(133, 32)
        Me.SalseChange.Text = "محل فروش"
        '
        'AdChange
        '
        Me.AdChange.Name = "AdChange"
        Me.AdChange.Size = New System.Drawing.Size(133, 32)
        Me.AdChange.Text = "محل تبلیغ"
        '
        'KindChange
        '
        Me.KindChange.Name = "KindChange"
        Me.KindChange.Size = New System.Drawing.Size(133, 32)
        Me.KindChange.Text = "نوع فروش"
        '
        'PassChange
        '
        Me.PassChange.Name = "PassChange"
        Me.PassChange.Size = New System.Drawing.Size(133, 32)
        Me.PassChange.Text = "تغییر رمز عبور"
        '
        'AddPanel
        '
        Me.AddPanel.Controls.Add(Me.DGVStore)
        Me.AddPanel.Controls.Add(Me.Button3)
        Me.AddPanel.Controls.Add(Me.Button2)
        Me.AddPanel.Controls.Add(Me.Button1)
        Me.AddPanel.Controls.Add(Me.CheckedListBox1)
        Me.AddPanel.Controls.Add(Me.TextBox6)
        Me.AddPanel.Controls.Add(Me.TextBox5)
        Me.AddPanel.Controls.Add(Me.Label6)
        Me.AddPanel.Controls.Add(Me.TextBox4)
        Me.AddPanel.Controls.Add(Me.Label5)
        Me.AddPanel.Controls.Add(Me.Label4)
        Me.AddPanel.Controls.Add(Me.TextBox8)
        Me.AddPanel.Controls.Add(Me.Label9)
        Me.AddPanel.Controls.Add(Me.Label8)
        Me.AddPanel.Controls.Add(Me.TextBox7)
        Me.AddPanel.Controls.Add(Me.Label7)
        Me.AddPanel.Controls.Add(Me.TextBox3)
        Me.AddPanel.Controls.Add(Me.Label3)
        Me.AddPanel.Controls.Add(Me.TextBox2)
        Me.AddPanel.Controls.Add(Me.Label2)
        Me.AddPanel.Controls.Add(Me.TextBox1)
        Me.AddPanel.Controls.Add(Me.Label1)
        Me.AddPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AddPanel.Location = New System.Drawing.Point(0, 0)
        Me.AddPanel.Name = "AddPanel"
        Me.AddPanel.Size = New System.Drawing.Size(898, 729)
        Me.AddPanel.TabIndex = 2
        Me.AddPanel.Visible = False
        '
        'DGVStore
        '
        Me.DGVStore.AllowUserToAddRows = False
        Me.DGVStore.AllowUserToDeleteRows = False
        Me.DGVStore.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGVStore.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGVStore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVStore.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DGVStore.Location = New System.Drawing.Point(0, 339)
        Me.DGVStore.MultiSelect = False
        Me.DGVStore.Name = "DGVStore"
        Me.DGVStore.ReadOnly = True
        Me.DGVStore.RowHeadersVisible = False
        Me.DGVStore.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVStore.ShowCellErrors = False
        Me.DGVStore.ShowCellToolTips = False
        Me.DGVStore.ShowEditingIcon = False
        Me.DGVStore.ShowRowErrors = False
        Me.DGVStore.Size = New System.Drawing.Size(898, 390)
        Me.DGVStore.TabIndex = 4
        '
        'Button3
        '
        Me.Button3.AutoSize = True
        Me.Button3.Location = New System.Drawing.Point(12, 212)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(339, 32)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "ثبت"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.AutoSize = True
        Me.Button2.Location = New System.Drawing.Point(12, 250)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(339, 32)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "فرم جدید"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.Location = New System.Drawing.Point(12, 288)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(339, 32)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "انصراف"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckedListBox1.CheckOnClick = True
        Me.CheckedListBox1.ColumnWidth = 50
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.HorizontalExtent = 5
        Me.CheckedListBox1.Items.AddRange(New Object() {"آبی", "بنفش", "بی رنگ", "چند رنگ", "خاکستری", "سبز", "سفید", "صورتی", "طوسی", "قرمز", "قهوه ای", "مشکی"})
        Me.CheckedListBox1.Location = New System.Drawing.Point(357, 17)
        Me.CheckedListBox1.Margin = New System.Windows.Forms.Padding(10, 3, 10, 3)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(172, 304)
        Me.CheckedListBox1.Sorted = True
        Me.CheckedListBox1.TabIndex = 2
        Me.CheckedListBox1.UseCompatibleTextRendering = True
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(608, 183)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(60, 30)
        Me.TextBox6.TabIndex = 1
        Me.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(694, 183)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(30, 30)
        Me.TextBox5.TabIndex = 1
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(674, 186)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(14, 22)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "/"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(750, 183)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(30, 30)
        Me.TextBox4.TabIndex = 1
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(730, 186)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(14, 22)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "/"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(786, 186)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 22)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "تاریخ خرید"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(608, 291)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(172, 30)
        Me.TextBox8.TabIndex = 1
        Me.TextBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(535, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 22)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "انتخاب رنگ"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(786, 298)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 22)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "حداقل قیمت فروش"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(608, 237)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(172, 30)
        Me.TextBox7.TabIndex = 1
        Me.TextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(786, 240)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 22)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "قیمت خرید"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(608, 129)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(172, 30)
        Me.TextBox3.TabIndex = 1
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(786, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 22)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "تعداد موجودی"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(608, 75)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(172, 30)
        Me.TextBox2.TabIndex = 1
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(786, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 22)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "مدل"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(608, 21)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(172, 30)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(786, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "نام کالا"
        '
        'frm_Main
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.AddPanel)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("B Mitra", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_Main"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.AddPanel.ResumeLayout(False)
        Me.AddPanel.PerformLayout()
        CType(Me.DGVStore, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btn_Add As ToolStripButton
    Friend WithEvents btn_Find As ToolStripButton
    Friend WithEvents btn_Setting As ToolStripButton
    Friend WithEvents btn_Reports As ToolStripButton
    Friend WithEvents btn_Exit As ToolStripButton
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents WearhouseReport As ToolStripMenuItem
    Friend WithEvents SalseReport As ToolStripMenuItem
    Friend WithEvents FactorPrint As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip2 As ContextMenuStrip
    Friend WithEvents SalseChange As ToolStripMenuItem
    Friend WithEvents AdChange As ToolStripMenuItem
    Friend WithEvents KindChange As ToolStripMenuItem
    Friend WithEvents PassChange As ToolStripMenuItem
    Friend WithEvents AddPanel As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents DGVStore As DataGridView
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
