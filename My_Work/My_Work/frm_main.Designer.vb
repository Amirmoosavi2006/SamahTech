<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_main))
        Me.dgv_w = New System.Windows.Forms.DataGridView()
        Me.txt_find_word = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_find = New System.Windows.Forms.Button()
        Me.btn_return = New System.Windows.Forms.Button()
        Me.btn_all_w = New System.Windows.Forms.Button()
        Me.btn_new = New System.Windows.Forms.Button()
        Me.btn_today_p = New System.Windows.Forms.Button()
        Me.btn_wfinal = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.dgv_w, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_w
        '
        Me.dgv_w.AllowUserToAddRows = False
        Me.dgv_w.AllowUserToDeleteRows = False
        Me.dgv_w.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_w.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
        Me.dgv_w.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_w.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgv_w.Location = New System.Drawing.Point(0, 152)
        Me.dgv_w.Name = "dgv_w"
        Me.dgv_w.ReadOnly = True
        Me.dgv_w.RowHeadersVisible = False
        Me.dgv_w.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_w.ShowCellErrors = False
        Me.dgv_w.ShowCellToolTips = False
        Me.dgv_w.ShowEditingIcon = False
        Me.dgv_w.ShowRowErrors = False
        Me.dgv_w.Size = New System.Drawing.Size(650, 368)
        Me.dgv_w.TabIndex = 2
        '
        'txt_find_word
        '
        Me.txt_find_word.Location = New System.Drawing.Point(6, 27)
        Me.txt_find_word.Name = "txt_find_word"
        Me.txt_find_word.Size = New System.Drawing.Size(265, 28)
        Me.txt_find_word.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_find_word)
        Me.GroupBox1.Controls.Add(Me.btn_find)
        Me.GroupBox1.Location = New System.Drawing.Point(362, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(277, 133)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "جستجو"
        '
        'btn_find
        '
        Me.btn_find.Image = Global.My_Work.My.Resources.Resources.icons8_search_50
        Me.btn_find.Location = New System.Drawing.Point(6, 61)
        Me.btn_find.Name = "btn_find"
        Me.btn_find.Size = New System.Drawing.Size(64, 64)
        Me.btn_find.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.btn_find, "جستجوی متن مورد نظر")
        Me.btn_find.UseVisualStyleBackColor = True
        '
        'btn_return
        '
        Me.btn_return.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_return.Image = Global.My_Work.My.Resources.Resources.Small_Exit
        Me.btn_return.Location = New System.Drawing.Point(12, 20)
        Me.btn_return.Name = "btn_return"
        Me.btn_return.Size = New System.Drawing.Size(64, 64)
        Me.btn_return.TabIndex = 24
        Me.ToolTip1.SetToolTip(Me.btn_return, "خروج از برنامه")
        Me.btn_return.UseVisualStyleBackColor = True
        '
        'btn_all_w
        '
        Me.btn_all_w.Image = Global.My_Work.My.Resources.Resources.icons8_book_50
        Me.btn_all_w.Location = New System.Drawing.Point(82, 20)
        Me.btn_all_w.Name = "btn_all_w"
        Me.btn_all_w.Size = New System.Drawing.Size(64, 64)
        Me.btn_all_w.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.btn_all_w, "نمایش تمامی کارهای در دست اقدام")
        Me.btn_all_w.UseVisualStyleBackColor = True
        '
        'btn_new
        '
        Me.btn_new.Image = Global.My_Work.My.Resources.Resources.icons8_add_property_50_2
        Me.btn_new.Location = New System.Drawing.Point(292, 20)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(64, 64)
        Me.btn_new.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.btn_new, "تعریف کار جدید")
        Me.btn_new.UseVisualStyleBackColor = True
        '
        'btn_today_p
        '
        Me.btn_today_p.Image = Global.My_Work.My.Resources.Resources.icons8_today_50
        Me.btn_today_p.Location = New System.Drawing.Point(222, 20)
        Me.btn_today_p.Name = "btn_today_p"
        Me.btn_today_p.Size = New System.Drawing.Size(64, 64)
        Me.btn_today_p.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.btn_today_p, "پیگیری های امروز")
        Me.btn_today_p.UseVisualStyleBackColor = True
        '
        'btn_wfinal
        '
        Me.btn_wfinal.Image = Global.My_Work.My.Resources.Resources.icons8_edit_file_50_2
        Me.btn_wfinal.Location = New System.Drawing.Point(152, 20)
        Me.btn_wfinal.Name = "btn_wfinal"
        Me.btn_wfinal.Size = New System.Drawing.Size(64, 64)
        Me.btn_wfinal.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.btn_wfinal, "لیست کارهای تمام شده")
        Me.btn_wfinal.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(220, 21)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "برای ویرایش هر ردیف بر روی آن دوبار کلیک نمایید"
        '
        'ToolTip1
        '
        Me.ToolTip1.BackColor = System.Drawing.Color.Violet
        Me.ToolTip1.ForeColor = System.Drawing.Color.Black
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "دفترچه یادداشت کاری من"
        '
        'frm_main
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(650, 520)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_return)
        Me.Controls.Add(Me.dgv_w)
        Me.Controls.Add(Me.btn_all_w)
        Me.Controls.Add(Me.btn_new)
        Me.Controls.Add(Me.btn_today_p)
        Me.Controls.Add(Me.btn_wfinal)
        Me.Font = New System.Drawing.Font("B Mitra", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_main"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "صفحه اصلی"
        CType(Me.dgv_w, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_find As Button
    Friend WithEvents dgv_w As DataGridView
    Friend WithEvents txt_find_word As TextBox
    Friend WithEvents btn_return As Button
    Friend WithEvents btn_wfinal As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_today_p As Button
    Friend WithEvents btn_all_w As Button
    Friend WithEvents btn_new As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolTip1 As ToolTip
End Class
