<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_p
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_p))
        Me.txt_wno = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_wtitle = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_py = New System.Windows.Forms.TextBox()
        Me.txt_pm = New System.Windows.Forms.TextBox()
        Me.txt_pd = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_pdesc = New System.Windows.Forms.RichTextBox()
        Me.btn_return = New System.Windows.Forms.Button()
        Me.btn_new = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.dgv_p = New System.Windows.Forms.DataGridView()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgv_p, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_wno
        '
        Me.txt_wno.BackColor = System.Drawing.Color.Khaki
        Me.txt_wno.Enabled = False
        Me.txt_wno.Location = New System.Drawing.Point(487, 11)
        Me.txt_wno.MaxLength = 10
        Me.txt_wno.Name = "txt_wno"
        Me.txt_wno.Size = New System.Drawing.Size(113, 28)
        Me.txt_wno.TabIndex = 104
        Me.txt_wno.Text = "123456789"
        Me.txt_wno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(606, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 21)
        Me.Label1.TabIndex = 102
        Me.Label1.Text = "شماره کار"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(606, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 21)
        Me.Label2.TabIndex = 103
        Me.Label2.Text = "عنوان کار"
        '
        'txt_wtitle
        '
        Me.txt_wtitle.BackColor = System.Drawing.Color.Khaki
        Me.txt_wtitle.Enabled = False
        Me.txt_wtitle.Location = New System.Drawing.Point(82, 45)
        Me.txt_wtitle.MaxLength = 100
        Me.txt_wtitle.Name = "txt_wtitle"
        Me.txt_wtitle.Size = New System.Drawing.Size(518, 28)
        Me.txt_wtitle.TabIndex = 101
        Me.txt_wtitle.Text = "عنوان عنوان عنوان"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_py)
        Me.GroupBox2.Controls.Add(Me.txt_pm)
        Me.GroupBox2.Controls.Add(Me.txt_pd)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txt_pdesc)
        Me.GroupBox2.Location = New System.Drawing.Point(82, 79)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(570, 176)
        Me.GroupBox2.TabIndex = 105
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "شرح پیگیری"
        '
        'txt_py
        '
        Me.txt_py.Location = New System.Drawing.Point(6, 138)
        Me.txt_py.MaxLength = 4
        Me.txt_py.Name = "txt_py"
        Me.txt_py.Size = New System.Drawing.Size(60, 28)
        Me.txt_py.TabIndex = 11
        Me.txt_py.Text = "97"
        Me.txt_py.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_pm
        '
        Me.txt_pm.Location = New System.Drawing.Point(72, 138)
        Me.txt_pm.MaxLength = 2
        Me.txt_pm.Name = "txt_pm"
        Me.txt_pm.Size = New System.Drawing.Size(30, 28)
        Me.txt_pm.TabIndex = 10
        Me.txt_pm.Text = "97"
        Me.txt_pm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_pd
        '
        Me.txt_pd.Location = New System.Drawing.Point(108, 138)
        Me.txt_pd.MaxLength = 2
        Me.txt_pd.Name = "txt_pd"
        Me.txt_pd.Size = New System.Drawing.Size(30, 28)
        Me.txt_pd.TabIndex = 8
        Me.txt_pd.Text = "97"
        Me.txt_pd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(144, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 21)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "تاریخ ثبت پیگیری"
        '
        'txt_pdesc
        '
        Me.txt_pdesc.AutoWordSelection = True
        Me.txt_pdesc.Location = New System.Drawing.Point(6, 31)
        Me.txt_pdesc.Name = "txt_pdesc"
        Me.txt_pdesc.ShowSelectionMargin = True
        Me.txt_pdesc.Size = New System.Drawing.Size(554, 101)
        Me.txt_pdesc.TabIndex = 7
        Me.txt_pdesc.Text = "شرح توضیحات کار"
        '
        'btn_return
        '
        Me.btn_return.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_return.Image = Global.My_Work.My.Resources.Resources.Small_Exit
        Me.btn_return.Location = New System.Drawing.Point(12, 190)
        Me.btn_return.Name = "btn_return"
        Me.btn_return.Size = New System.Drawing.Size(64, 64)
        Me.btn_return.TabIndex = 108
        Me.ToolTip1.SetToolTip(Me.btn_return, "بازگشت به صفحه قبل")
        Me.btn_return.UseVisualStyleBackColor = True
        '
        'btn_new
        '
        Me.btn_new.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_new.Image = Global.My_Work.My.Resources.Resources.Small_Undo
        Me.btn_new.Location = New System.Drawing.Point(12, 101)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(64, 64)
        Me.btn_new.TabIndex = 107
        Me.ToolTip1.SetToolTip(Me.btn_new, "بروزآوری صفحه")
        Me.btn_new.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_save.Image = Global.My_Work.My.Resources.Resources.Small_Ok1
        Me.btn_save.Location = New System.Drawing.Point(12, 12)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(64, 64)
        Me.btn_save.TabIndex = 106
        Me.ToolTip1.SetToolTip(Me.btn_save, "ثبت پیگیری انجام شده")
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'dgv_p
        '
        Me.dgv_p.AllowUserToAddRows = False
        Me.dgv_p.AllowUserToDeleteRows = False
        Me.dgv_p.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_p.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
        Me.dgv_p.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_p.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgv_p.Location = New System.Drawing.Point(0, 261)
        Me.dgv_p.Name = "dgv_p"
        Me.dgv_p.ReadOnly = True
        Me.dgv_p.RowHeadersVisible = False
        Me.dgv_p.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_p.ShowCellErrors = False
        Me.dgv_p.ShowCellToolTips = False
        Me.dgv_p.ShowEditingIcon = False
        Me.dgv_p.ShowRowErrors = False
        Me.dgv_p.Size = New System.Drawing.Size(659, 343)
        Me.dgv_p.TabIndex = 109
        '
        'ToolTip1
        '
        Me.ToolTip1.BackColor = System.Drawing.Color.Aquamarine
        Me.ToolTip1.ForeColor = System.Drawing.Color.Black
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "دفترچه یادداشت کاری من"
        '
        'frm_p
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(659, 604)
        Me.Controls.Add(Me.dgv_p)
        Me.Controls.Add(Me.btn_return)
        Me.Controls.Add(Me.btn_new)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txt_wno)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_wtitle)
        Me.Font = New System.Drawing.Font("B Mitra", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_p"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ثبت پیگیری"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgv_p, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_wno As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_wtitle As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txt_pdesc As RichTextBox
    Friend WithEvents btn_return As Button
    Friend WithEvents btn_new As Button
    Friend WithEvents btn_save As Button
    Friend WithEvents dgv_p As DataGridView
    Friend WithEvents txt_py As TextBox
    Friend WithEvents txt_pm As TextBox
    Friend WithEvents txt_pd As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ToolTip1 As ToolTip
End Class
