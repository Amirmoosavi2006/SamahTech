<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Find
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Find))
        Me.dgv_Find = New System.Windows.Forms.DataGridView()
        Me.FindYearFrom = New System.Windows.Forms.TextBox()
        Me.FindMonthFrom = New System.Windows.Forms.TextBox()
        Me.FindDayFrom = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FindYearTo = New System.Windows.Forms.TextBox()
        Me.FindMonthTo = New System.Windows.Forms.TextBox()
        Me.FindDayTo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FindText = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_find = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_return = New System.Windows.Forms.Button()
        CType(Me.dgv_Find, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_Find
        '
        Me.dgv_Find.AllowUserToAddRows = False
        Me.dgv_Find.AllowUserToDeleteRows = False
        Me.dgv_Find.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_Find.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_Find.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Find.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgv_Find.Location = New System.Drawing.Point(0, 101)
        Me.dgv_Find.Name = "dgv_Find"
        Me.dgv_Find.ReadOnly = True
        Me.dgv_Find.RowHeadersVisible = False
        Me.dgv_Find.RowHeadersWidth = 51
        Me.dgv_Find.RowTemplate.Height = 24
        Me.dgv_Find.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Find.ShowCellErrors = False
        Me.dgv_Find.ShowEditingIcon = False
        Me.dgv_Find.ShowRowErrors = False
        Me.dgv_Find.Size = New System.Drawing.Size(782, 452)
        Me.dgv_Find.TabIndex = 100
        Me.dgv_Find.TabStop = False
        '
        'FindYearFrom
        '
        Me.FindYearFrom.Location = New System.Drawing.Point(524, 11)
        Me.FindYearFrom.MaxLength = 4
        Me.FindYearFrom.Name = "FindYearFrom"
        Me.FindYearFrom.Size = New System.Drawing.Size(78, 39)
        Me.FindYearFrom.TabIndex = 2
        Me.FindYearFrom.Text = "1400"
        Me.FindYearFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FindMonthFrom
        '
        Me.FindMonthFrom.Location = New System.Drawing.Point(608, 11)
        Me.FindMonthFrom.MaxLength = 2
        Me.FindMonthFrom.Name = "FindMonthFrom"
        Me.FindMonthFrom.Size = New System.Drawing.Size(39, 39)
        Me.FindMonthFrom.TabIndex = 1
        Me.FindMonthFrom.Text = "04"
        Me.FindMonthFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FindDayFrom
        '
        Me.FindDayFrom.Location = New System.Drawing.Point(653, 11)
        Me.FindDayFrom.MaxLength = 2
        Me.FindDayFrom.Name = "FindDayFrom"
        Me.FindDayFrom.Size = New System.Drawing.Size(39, 39)
        Me.FindDayFrom.TabIndex = 0
        Me.FindDayFrom.Text = "05"
        Me.FindDayFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(698, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 32)
        Me.Label3.TabIndex = 118
        Me.Label3.Text = "از تاریخ"
        '
        'FindYearTo
        '
        Me.FindYearTo.Location = New System.Drawing.Point(282, 11)
        Me.FindYearTo.MaxLength = 4
        Me.FindYearTo.Name = "FindYearTo"
        Me.FindYearTo.Size = New System.Drawing.Size(78, 39)
        Me.FindYearTo.TabIndex = 5
        Me.FindYearTo.Text = "1400"
        Me.FindYearTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FindMonthTo
        '
        Me.FindMonthTo.Location = New System.Drawing.Point(366, 11)
        Me.FindMonthTo.MaxLength = 2
        Me.FindMonthTo.Name = "FindMonthTo"
        Me.FindMonthTo.Size = New System.Drawing.Size(39, 39)
        Me.FindMonthTo.TabIndex = 4
        Me.FindMonthTo.Text = "04"
        Me.FindMonthTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FindDayTo
        '
        Me.FindDayTo.Location = New System.Drawing.Point(411, 11)
        Me.FindDayTo.MaxLength = 2
        Me.FindDayTo.Name = "FindDayTo"
        Me.FindDayTo.Size = New System.Drawing.Size(39, 39)
        Me.FindDayTo.TabIndex = 3
        Me.FindDayTo.Text = "05"
        Me.FindDayTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(456, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 32)
        Me.Label1.TabIndex = 122
        Me.Label1.Text = "تا تاریخ"
        '
        'FindText
        '
        Me.FindText.Location = New System.Drawing.Point(282, 56)
        Me.FindText.Name = "FindText"
        Me.FindText.Size = New System.Drawing.Size(410, 39)
        Me.FindText.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(698, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 32)
        Me.Label2.TabIndex = 126
        Me.Label2.Text = "متن جستجو"
        '
        'btn_find
        '
        Me.btn_find.Image = Global.PAW.My.Resources.Resources.icons8_search_50
        Me.btn_find.Location = New System.Drawing.Point(124, 45)
        Me.btn_find.Name = "btn_find"
        Me.btn_find.Size = New System.Drawing.Size(50, 50)
        Me.btn_find.TabIndex = 8
        Me.btn_find.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Image = Global.PAW.My.Resources.Resources.icons8_edit_50
        Me.btn_edit.Location = New System.Drawing.Point(68, 45)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(50, 50)
        Me.btn_edit.TabIndex = 9
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'btn_return
        '
        Me.btn_return.Image = Global.PAW.My.Resources.Resources.icons8_end_button_50
        Me.btn_return.Location = New System.Drawing.Point(12, 45)
        Me.btn_return.Name = "btn_return"
        Me.btn_return.Size = New System.Drawing.Size(50, 50)
        Me.btn_return.TabIndex = 10
        Me.btn_return.UseVisualStyleBackColor = True
        '
        'frm_Find
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(782, 553)
        Me.Controls.Add(Me.btn_find)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.btn_return)
        Me.Controls.Add(Me.FindText)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.FindYearTo)
        Me.Controls.Add(Me.FindMonthTo)
        Me.Controls.Add(Me.FindDayTo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FindYearFrom)
        Me.Controls.Add(Me.FindMonthFrom)
        Me.Controls.Add(Me.FindDayFrom)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgv_Find)
        Me.Font = New System.Drawing.Font("B Kamran", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_Find"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "برنامه ریزی کارهای اداری / جستجو"
        CType(Me.dgv_Find, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_Find As DataGridView
    Friend WithEvents FindYearFrom As TextBox
    Friend WithEvents FindMonthFrom As TextBox
    Friend WithEvents FindDayFrom As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents FindYearTo As TextBox
    Friend WithEvents FindMonthTo As TextBox
    Friend WithEvents FindDayTo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents FindText As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_return As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_find As Button
End Class
