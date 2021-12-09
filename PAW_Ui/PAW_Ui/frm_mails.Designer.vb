<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_mails
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_del_all = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_refresh = New System.Windows.Forms.Button()
        Me.btn_home = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(447, 338)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 28)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "در دست طراحی"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btn_edit)
        Me.Panel1.Controls.Add(Me.btn_del_all)
        Me.Panel1.Controls.Add(Me.btn_save)
        Me.Panel1.Controls.Add(Me.btn_refresh)
        Me.Panel1.Controls.Add(Me.btn_home)
        Me.Panel1.Location = New System.Drawing.Point(12, 592)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(421, 100)
        Me.Panel1.TabIndex = 140
        '
        'btn_edit
        '
        Me.btn_edit.Enabled = False
        Me.btn_edit.Image = Global.PAW_Ui.My.Resources.Resources.save_as_64px
        Me.btn_edit.Location = New System.Drawing.Point(252, 13)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(72, 72)
        Me.btn_edit.TabIndex = 147
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'btn_del_all
        '
        Me.btn_del_all.Enabled = False
        Me.btn_del_all.Image = Global.PAW_Ui.My.Resources.Resources.trash_can_64px
        Me.btn_del_all.Location = New System.Drawing.Point(174, 13)
        Me.btn_del_all.Name = "btn_del_all"
        Me.btn_del_all.Size = New System.Drawing.Size(72, 72)
        Me.btn_del_all.TabIndex = 146
        Me.btn_del_all.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Enabled = False
        Me.btn_save.Image = Global.PAW_Ui.My.Resources.Resources.save_64px
        Me.btn_save.Location = New System.Drawing.Point(330, 13)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(72, 72)
        Me.btn_save.TabIndex = 14
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_refresh
        '
        Me.btn_refresh.Enabled = False
        Me.btn_refresh.Image = Global.PAW_Ui.My.Resources.Resources.repeat_64px
        Me.btn_refresh.Location = New System.Drawing.Point(96, 13)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(72, 72)
        Me.btn_refresh.TabIndex = 144
        Me.btn_refresh.UseVisualStyleBackColor = True
        '
        'btn_home
        '
        Me.btn_home.Image = Global.PAW_Ui.My.Resources.Resources.home_64px
        Me.btn_home.Location = New System.Drawing.Point(18, 13)
        Me.btn_home.Name = "btn_home"
        Me.btn_home.Size = New System.Drawing.Size(72, 72)
        Me.btn_home.TabIndex = 143
        Me.btn_home.UseVisualStyleBackColor = True
        '
        'frm_mails
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(990, 704)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("B Koodak", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_mails"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_del_all As Button
    Friend WithEvents btn_save As Button
    Friend WithEvents btn_refresh As Button
    Friend WithEvents btn_home As Button
End Class
