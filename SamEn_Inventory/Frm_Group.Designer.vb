<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Group
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Group))
        Me.btn_del = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_new = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_return = New System.Windows.Forms.Button()
        Me.dgv_Store = New System.Windows.Forms.DataGridView()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgv_Store, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_del
        '
        Me.btn_del.Location = New System.Drawing.Point(213, 102)
        Me.btn_del.Name = "btn_del"
        Me.btn_del.Size = New System.Drawing.Size(168, 39)
        Me.btn_del.TabIndex = 37
        Me.btn_del.Text = "حذف"
        Me.btn_del.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Location = New System.Drawing.Point(213, 57)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(168, 39)
        Me.btn_edit.TabIndex = 36
        Me.btn_edit.Text = "ویرایش"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'btn_new
        '
        Me.btn_new.Location = New System.Drawing.Point(213, 147)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(168, 39)
        Me.btn_new.TabIndex = 38
        Me.btn_new.Text = "فرم جدید"
        Me.btn_new.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(213, 12)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(168, 39)
        Me.btn_save.TabIndex = 34
        Me.btn_save.Text = "ذخیره"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_return
        '
        Me.btn_return.Location = New System.Drawing.Point(213, 192)
        Me.btn_return.Name = "btn_return"
        Me.btn_return.Size = New System.Drawing.Size(168, 39)
        Me.btn_return.TabIndex = 39
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
        Me.dgv_Store.Dock = System.Windows.Forms.DockStyle.Left
        Me.dgv_Store.Location = New System.Drawing.Point(0, 0)
        Me.dgv_Store.Name = "dgv_Store"
        Me.dgv_Store.ReadOnly = True
        Me.dgv_Store.RowHeadersVisible = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgv_Store.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_Store.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Store.ShowCellErrors = False
        Me.dgv_Store.ShowEditingIcon = False
        Me.dgv_Store.ShowRowErrors = False
        Me.dgv_Store.Size = New System.Drawing.Size(207, 239)
        Me.dgv_Store.TabIndex = 44
        Me.dgv_Store.TabStop = False
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(387, 12)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(201, 34)
        Me.txt_name.TabIndex = 27
        Me.txt_name.Text = "مرکزی"
        Me.txt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(594, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 27)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "عنوان گروه"
        '
        'Frm_Group
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(685, 239)
        Me.Controls.Add(Me.btn_del)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.btn_new)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.btn_return)
        Me.Controls.Add(Me.dgv_Store)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("B Zar", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Frm_Group"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "نرم افزار انبارداری سامان: فرم تعریف گروه اقلام"
        CType(Me.dgv_Store, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_del As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_new As Button
    Friend WithEvents btn_save As Button
    Friend WithEvents btn_return As Button
    Friend WithEvents dgv_Store As DataGridView
    Friend WithEvents txt_name As TextBox
    Friend WithEvents Label1 As Label
End Class
