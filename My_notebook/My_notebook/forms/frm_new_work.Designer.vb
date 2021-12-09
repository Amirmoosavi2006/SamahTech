<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_new_work
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
        Me.btn_return = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_desc = New System.Windows.Forms.RichTextBox()
        Me.txt_subtitle = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_day = New System.Windows.Forms.TextBox()
        Me.txt_month = New System.Windows.Forms.TextBox()
        Me.txt_year = New System.Windows.Forms.TextBox()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_return
        '
        Me.btn_return.Location = New System.Drawing.Point(12, 221)
        Me.btn_return.Name = "btn_return"
        Me.btn_return.Size = New System.Drawing.Size(136, 42)
        Me.btn_return.TabIndex = 6
        Me.btn_return.Text = "بازگشت"
        Me.btn_return.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("B Lotus", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.Location = New System.Drawing.Point(749, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 39)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "عنوان"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("B Lotus", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.Location = New System.Drawing.Point(749, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 39)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "جزئیات"
        '
        'txt_desc
        '
        Me.txt_desc.BackColor = System.Drawing.Color.PaleTurquoise
        Me.txt_desc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_desc.ForeColor = System.Drawing.Color.DarkBlue
        Me.txt_desc.Location = New System.Drawing.Point(320, 59)
        Me.txt_desc.Name = "txt_desc"
        Me.txt_desc.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.txt_desc.Size = New System.Drawing.Size(423, 204)
        Me.txt_desc.TabIndex = 1
        Me.txt_desc.Text = ""
        '
        'txt_subtitle
        '
        Me.txt_subtitle.BackColor = System.Drawing.Color.Aquamarine
        Me.txt_subtitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_subtitle.Location = New System.Drawing.Point(320, 12)
        Me.txt_subtitle.Name = "txt_subtitle"
        Me.txt_subtitle.Size = New System.Drawing.Size(423, 41)
        Me.txt_subtitle.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("B Lotus", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.Location = New System.Drawing.Point(194, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 39)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "تاریخ ثبت کار"
        '
        'txt_day
        '
        Me.txt_day.BackColor = System.Drawing.Color.Turquoise
        Me.txt_day.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_day.Location = New System.Drawing.Point(147, 12)
        Me.txt_day.MaxLength = 2
        Me.txt_day.Name = "txt_day"
        Me.txt_day.Size = New System.Drawing.Size(41, 41)
        Me.txt_day.TabIndex = 2
        Me.txt_day.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_month
        '
        Me.txt_month.BackColor = System.Drawing.Color.Turquoise
        Me.txt_month.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_month.Location = New System.Drawing.Point(100, 12)
        Me.txt_month.MaxLength = 2
        Me.txt_month.Name = "txt_month"
        Me.txt_month.Size = New System.Drawing.Size(41, 41)
        Me.txt_month.TabIndex = 3
        Me.txt_month.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_year
        '
        Me.txt_year.BackColor = System.Drawing.Color.Turquoise
        Me.txt_year.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_year.Location = New System.Drawing.Point(12, 12)
        Me.txt_year.MaxLength = 4
        Me.txt_year.Name = "txt_year"
        Me.txt_year.Size = New System.Drawing.Size(82, 41)
        Me.txt_year.TabIndex = 4
        Me.txt_year.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(12, 173)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(136, 42)
        Me.btn_save.TabIndex = 5
        Me.btn_save.Text = "ذخیره"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'frm_new_work
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(827, 274)
        Me.Controls.Add(Me.txt_year)
        Me.Controls.Add(Me.txt_month)
        Me.Controls.Add(Me.txt_day)
        Me.Controls.Add(Me.txt_subtitle)
        Me.Controls.Add(Me.txt_desc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.btn_return)
        Me.Font = New System.Drawing.Font("B Lotus", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_new_work"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "دفترچه یادداشت من / ثبت کار جدید"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_return As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_desc As RichTextBox
    Friend WithEvents txt_subtitle As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_day As TextBox
    Friend WithEvents txt_month As TextBox
    Friend WithEvents txt_year As TextBox
    Friend WithEvents btn_save As Button
End Class
