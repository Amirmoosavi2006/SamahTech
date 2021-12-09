<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_final
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_final))
        Me.txt_final_desc = New System.Windows.Forms.RichTextBox()
        Me.txt_fy = New System.Windows.Forms.TextBox()
        Me.txt_fm = New System.Windows.Forms.TextBox()
        Me.txt_fd = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_return = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt_final_desc
        '
        Me.txt_final_desc.AutoWordSelection = True
        Me.txt_final_desc.Location = New System.Drawing.Point(82, 33)
        Me.txt_final_desc.Name = "txt_final_desc"
        Me.txt_final_desc.ShowSelectionMargin = True
        Me.txt_final_desc.Size = New System.Drawing.Size(554, 100)
        Me.txt_final_desc.TabIndex = 8
        Me.txt_final_desc.Text = "شرح توضیحات کار"
        '
        'txt_fy
        '
        Me.txt_fy.Location = New System.Drawing.Point(82, 139)
        Me.txt_fy.MaxLength = 4
        Me.txt_fy.Name = "txt_fy"
        Me.txt_fy.Size = New System.Drawing.Size(60, 28)
        Me.txt_fy.TabIndex = 12
        Me.txt_fy.Text = "97"
        Me.txt_fy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_fm
        '
        Me.txt_fm.Location = New System.Drawing.Point(148, 139)
        Me.txt_fm.MaxLength = 2
        Me.txt_fm.Name = "txt_fm"
        Me.txt_fm.Size = New System.Drawing.Size(30, 28)
        Me.txt_fm.TabIndex = 11
        Me.txt_fm.Text = "97"
        Me.txt_fm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_fd
        '
        Me.txt_fd.Location = New System.Drawing.Point(184, 139)
        Me.txt_fd.MaxLength = 2
        Me.txt_fd.Name = "txt_fd"
        Me.txt_fd.Size = New System.Drawing.Size(30, 28)
        Me.txt_fd.TabIndex = 9
        Me.txt_fd.Text = "97"
        Me.txt_fd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(220, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 21)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "تاریخ انجام کار"
        '
        'btn_return
        '
        Me.btn_return.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_return.Image = Global.My_Work.My.Resources.Resources.Small_Exit
        Me.btn_return.Location = New System.Drawing.Point(12, 103)
        Me.btn_return.Name = "btn_return"
        Me.btn_return.Size = New System.Drawing.Size(64, 64)
        Me.btn_return.TabIndex = 25
        Me.btn_return.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_save.Image = Global.My_Work.My.Resources.Resources.Small_Ok1
        Me.btn_save.Location = New System.Drawing.Point(12, 33)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(64, 64)
        Me.btn_save.TabIndex = 24
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(541, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 21)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "شرح نتیجه نهایی کار"
        '
        'frm_final
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(643, 177)
        Me.Controls.Add(Me.btn_return)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.txt_fy)
        Me.Controls.Add(Me.txt_fm)
        Me.Controls.Add(Me.txt_fd)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_final_desc)
        Me.Font = New System.Drawing.Font("B Mitra", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_final"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ثبت نتیجه نهایی کار"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_final_desc As RichTextBox
    Friend WithEvents txt_fy As TextBox
    Friend WithEvents txt_fm As TextBox
    Friend WithEvents txt_fd As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_return As Button
    Friend WithEvents btn_save As Button
    Friend WithEvents Label1 As Label
End Class
