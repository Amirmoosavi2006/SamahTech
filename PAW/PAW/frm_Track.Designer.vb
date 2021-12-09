<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Track
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Track))
        Me.dgv_Track = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.WorkTitle = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.WorkDesc = New System.Windows.Forms.TextBox()
        Me.AttachmentsList = New System.Windows.Forms.ListBox()
        Me.btn_attach = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_return = New System.Windows.Forms.Button()
        CType(Me.dgv_Track, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_Track
        '
        Me.dgv_Track.AllowUserToAddRows = False
        Me.dgv_Track.AllowUserToDeleteRows = False
        Me.dgv_Track.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Track.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgv_Track.Location = New System.Drawing.Point(0, 278)
        Me.dgv_Track.Name = "dgv_Track"
        Me.dgv_Track.ReadOnly = True
        Me.dgv_Track.RowHeadersWidth = 51
        Me.dgv_Track.RowTemplate.Height = 24
        Me.dgv_Track.Size = New System.Drawing.Size(782, 275)
        Me.dgv_Track.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(686, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 26)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "عنوان کار"
        '
        'WorkTitle
        '
        Me.WorkTitle.Enabled = False
        Me.WorkTitle.Location = New System.Drawing.Point(379, 12)
        Me.WorkTitle.Name = "WorkTitle"
        Me.WorkTitle.Size = New System.Drawing.Size(301, 33)
        Me.WorkTitle.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(686, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 26)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "شرح پیگیری"
        '
        'WorkDesc
        '
        Me.WorkDesc.Location = New System.Drawing.Point(379, 57)
        Me.WorkDesc.Multiline = True
        Me.WorkDesc.Name = "WorkDesc"
        Me.WorkDesc.Size = New System.Drawing.Size(301, 215)
        Me.WorkDesc.TabIndex = 2
        '
        'AttachmentsList
        '
        Me.AttachmentsList.FormattingEnabled = True
        Me.AttachmentsList.ItemHeight = 25
        Me.AttachmentsList.Items.AddRange(New Object() {"پیوست 1", "پیوست 2", "پیوست 3"})
        Me.AttachmentsList.Location = New System.Drawing.Point(12, 12)
        Me.AttachmentsList.Name = "AttachmentsList"
        Me.AttachmentsList.Size = New System.Drawing.Size(193, 254)
        Me.AttachmentsList.TabIndex = 126
        '
        'btn_attach
        '
        Me.btn_attach.Image = Global.PAW.My.Resources.Resources.icons8_attach_50
        Me.btn_attach.Location = New System.Drawing.Point(211, 222)
        Me.btn_attach.Name = "btn_attach"
        Me.btn_attach.Size = New System.Drawing.Size(50, 50)
        Me.btn_attach.TabIndex = 125
        Me.btn_attach.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(211, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 26)
        Me.Label5.TabIndex = 124
        Me.Label5.Text = "پیوست ها"
        '
        'btn_save
        '
        Me.btn_save.Image = Global.PAW.My.Resources.Resources.icons8_save_close_50
        Me.btn_save.Location = New System.Drawing.Point(323, 222)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(50, 50)
        Me.btn_save.TabIndex = 127
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_return
        '
        Me.btn_return.Image = Global.PAW.My.Resources.Resources.icons8_end_button_50
        Me.btn_return.Location = New System.Drawing.Point(267, 222)
        Me.btn_return.Name = "btn_return"
        Me.btn_return.Size = New System.Drawing.Size(50, 50)
        Me.btn_return.TabIndex = 128
        Me.btn_return.UseVisualStyleBackColor = True
        '
        'frm_Track
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(782, 553)
        Me.Controls.Add(Me.btn_return)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.AttachmentsList)
        Me.Controls.Add(Me.btn_attach)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.WorkDesc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.WorkTitle)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgv_Track)
        Me.Font = New System.Drawing.Font("B Kamran", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_Track"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "برنامه ریزی کارهای اداری / ثبت پیگیری"
        CType(Me.dgv_Track, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_Track As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents WorkTitle As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents WorkDesc As TextBox
    Friend WithEvents AttachmentsList As ListBox
    Friend WithEvents btn_attach As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_save As Button
    Friend WithEvents btn_return As Button
End Class
