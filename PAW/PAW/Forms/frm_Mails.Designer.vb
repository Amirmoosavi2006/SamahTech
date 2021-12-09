<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Mails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Mails))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_dels = New System.Windows.Forms.Button()
        Me.btn_archive = New System.Windows.Forms.Button()
        Me.btn_new = New System.Windows.Forms.Button()
        Me.btn_output = New System.Windows.Forms.Button()
        Me.btn_input = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_return = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_refresh = New System.Windows.Forms.Button()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.btn_del = New System.Windows.Forms.Button()
        Me.btn_send = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PeopleList = New System.Windows.Forms.CheckedListBox()
        Me.DescText = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MessageText = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgv_message = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgv_message, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.Controls.Add(Me.btn_dels)
        Me.Panel1.Controls.Add(Me.btn_archive)
        Me.Panel1.Controls.Add(Me.btn_new)
        Me.Panel1.Controls.Add(Me.btn_output)
        Me.Panel1.Controls.Add(Me.btn_input)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btn_return)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(609, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(173, 553)
        Me.Panel1.TabIndex = 0
        '
        'btn_dels
        '
        Me.btn_dels.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_dels.FlatAppearance.BorderSize = 0
        Me.btn_dels.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_dels.Image = Global.PAW.My.Resources.Resources.icons8_deleted_message_40
        Me.btn_dels.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_dels.Location = New System.Drawing.Point(0, 250)
        Me.btn_dels.Name = "btn_dels"
        Me.btn_dels.Size = New System.Drawing.Size(173, 50)
        Me.btn_dels.TabIndex = 4
        Me.btn_dels.Text = "بازیافت"
        Me.btn_dels.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_dels.UseVisualStyleBackColor = True
        '
        'btn_archive
        '
        Me.btn_archive.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_archive.FlatAppearance.BorderSize = 0
        Me.btn_archive.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_archive.Image = Global.PAW.My.Resources.Resources.icons8_no_message_40
        Me.btn_archive.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_archive.Location = New System.Drawing.Point(0, 200)
        Me.btn_archive.Name = "btn_archive"
        Me.btn_archive.Size = New System.Drawing.Size(173, 50)
        Me.btn_archive.TabIndex = 3
        Me.btn_archive.Text = "بایگانی"
        Me.btn_archive.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_archive.UseVisualStyleBackColor = True
        '
        'btn_new
        '
        Me.btn_new.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_new.FlatAppearance.BorderSize = 0
        Me.btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_new.Image = Global.PAW.My.Resources.Resources.icons8_new_message_40
        Me.btn_new.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_new.Location = New System.Drawing.Point(0, 150)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(173, 50)
        Me.btn_new.TabIndex = 2
        Me.btn_new.Text = "ارسال پیام"
        Me.btn_new.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_new.UseVisualStyleBackColor = True
        '
        'btn_output
        '
        Me.btn_output.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_output.FlatAppearance.BorderSize = 0
        Me.btn_output.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_output.Image = Global.PAW.My.Resources.Resources.icons8_edit_message_40
        Me.btn_output.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_output.Location = New System.Drawing.Point(0, 100)
        Me.btn_output.Name = "btn_output"
        Me.btn_output.Size = New System.Drawing.Size(173, 50)
        Me.btn_output.TabIndex = 1
        Me.btn_output.Text = "پیام های ارسالی"
        Me.btn_output.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_output.UseVisualStyleBackColor = True
        '
        'btn_input
        '
        Me.btn_input.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_input.FlatAppearance.BorderSize = 0
        Me.btn_input.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_input.Image = Global.PAW.My.Resources.Resources.icons8_add_message_40
        Me.btn_input.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_input.Location = New System.Drawing.Point(0, 50)
        Me.btn_input.Name = "btn_input"
        Me.btn_input.Size = New System.Drawing.Size(173, 50)
        Me.btn_input.TabIndex = 0
        Me.btn_input.Text = "پیام های دریافتی"
        Me.btn_input.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_input.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 50)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "صندوق پیام ها"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_return
        '
        Me.btn_return.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btn_return.Image = Global.PAW.My.Resources.Resources.icons8_end_button_50
        Me.btn_return.Location = New System.Drawing.Point(0, 503)
        Me.btn_return.Name = "btn_return"
        Me.btn_return.Size = New System.Drawing.Size(173, 50)
        Me.btn_return.TabIndex = 9
        Me.btn_return.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightGray
        Me.Panel2.Controls.Add(Me.btn_refresh)
        Me.Panel2.Controls.Add(Me.lbl_title)
        Me.Panel2.Controls.Add(Me.btn_del)
        Me.Panel2.Controls.Add(Me.btn_send)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(609, 50)
        Me.Panel2.TabIndex = 2
        '
        'btn_refresh
        '
        Me.btn_refresh.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_refresh.FlatAppearance.BorderSize = 0
        Me.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_refresh.Image = Global.PAW.My.Resources.Resources.icons8_refresh_40
        Me.btn_refresh.Location = New System.Drawing.Point(262, 0)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(115, 50)
        Me.btn_refresh.TabIndex = 7
        Me.btn_refresh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_refresh.UseVisualStyleBackColor = True
        '
        'lbl_title
        '
        Me.lbl_title.ForeColor = System.Drawing.Color.CadetBlue
        Me.lbl_title.Image = Global.PAW.My.Resources.Resources.icons8_down_3_48
        Me.lbl_title.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_title.Location = New System.Drawing.Point(376, 0)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(227, 50)
        Me.lbl_title.TabIndex = 8
        Me.lbl_title.Text = "پیام های دریافتی"
        Me.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_del
        '
        Me.btn_del.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_del.FlatAppearance.BorderSize = 0
        Me.btn_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_del.Image = Global.PAW.My.Resources.Resources.icons8_deleted_message_40
        Me.btn_del.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_del.Location = New System.Drawing.Point(131, 0)
        Me.btn_del.Name = "btn_del"
        Me.btn_del.Size = New System.Drawing.Size(131, 50)
        Me.btn_del.TabIndex = 6
        Me.btn_del.Text = "حذف"
        Me.btn_del.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_del.UseVisualStyleBackColor = True
        '
        'btn_send
        '
        Me.btn_send.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_send.FlatAppearance.BorderSize = 0
        Me.btn_send.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_send.Image = Global.PAW.My.Resources.Resources.icons8_new_message_40
        Me.btn_send.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_send.Location = New System.Drawing.Point(0, 0)
        Me.btn_send.Name = "btn_send"
        Me.btn_send.Size = New System.Drawing.Size(131, 50)
        Me.btn_send.TabIndex = 5
        Me.btn_send.Text = "ارسال"
        Me.btn_send.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_send.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.PeopleList)
        Me.Panel3.Controls.Add(Me.DescText)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.MessageText)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 50)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(609, 503)
        Me.Panel3.TabIndex = 3
        Me.Panel3.Visible = False
        '
        'PeopleList
        '
        Me.PeopleList.CheckOnClick = True
        Me.PeopleList.FormattingEnabled = True
        Me.PeopleList.Items.AddRange(New Object() {"وحید نوروزنیا", "سیدامیر موسوی", "نوید اسمعیل زاده", "مهدی کهن", "حمید حنانی", "عبداله عسکری"})
        Me.PeopleList.Location = New System.Drawing.Point(22, 297)
        Me.PeopleList.Name = "PeopleList"
        Me.PeopleList.Size = New System.Drawing.Size(480, 140)
        Me.PeopleList.TabIndex = 6
        '
        'DescText
        '
        Me.DescText.Location = New System.Drawing.Point(22, 60)
        Me.DescText.Multiline = True
        Me.DescText.Name = "DescText"
        Me.DescText.Size = New System.Drawing.Size(480, 231)
        Me.DescText.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(508, 297)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 32)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "گیرنده پیام"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(508, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 32)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "شرح پیام"
        '
        'MessageText
        '
        Me.MessageText.Location = New System.Drawing.Point(22, 15)
        Me.MessageText.Name = "MessageText"
        Me.MessageText.Size = New System.Drawing.Size(480, 39)
        Me.MessageText.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(508, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 32)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "عنوان پیام"
        '
        'dgv_message
        '
        Me.dgv_message.AllowUserToAddRows = False
        Me.dgv_message.AllowUserToDeleteRows = False
        Me.dgv_message.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_message.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_message.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_message.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_message.Location = New System.Drawing.Point(0, 50)
        Me.dgv_message.Name = "dgv_message"
        Me.dgv_message.RowHeadersVisible = False
        Me.dgv_message.RowHeadersWidth = 51
        Me.dgv_message.RowTemplate.Height = 24
        Me.dgv_message.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_message.ShowCellErrors = False
        Me.dgv_message.ShowEditingIcon = False
        Me.dgv_message.ShowRowErrors = False
        Me.dgv_message.Size = New System.Drawing.Size(609, 503)
        Me.dgv_message.TabIndex = 100
        Me.dgv_message.TabStop = False
        '
        'frm_Mails
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(782, 553)
        Me.Controls.Add(Me.dgv_message)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("B Kamran", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_Mails"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "برنامه ریزی کارهای اداری / پیام ها"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dgv_message, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_return As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lbl_title As Label
    Friend WithEvents btn_del As Button
    Friend WithEvents btn_send As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DescText As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents MessageText As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PeopleList As CheckedListBox
    Friend WithEvents btn_refresh As Button
    Friend WithEvents btn_dels As Button
    Friend WithEvents btn_archive As Button
    Friend WithEvents btn_new As Button
    Friend WithEvents btn_output As Button
    Friend WithEvents btn_input As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents dgv_message As DataGridView
End Class
