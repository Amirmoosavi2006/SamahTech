<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_note
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_refresh = New System.Windows.Forms.Button()
        Me.btn_home = New System.Windows.Forms.Button()
        Me.tlp = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btn_save)
        Me.Panel1.Controls.Add(Me.btn_refresh)
        Me.Panel1.Controls.Add(Me.btn_home)
        Me.Panel1.Location = New System.Drawing.Point(12, 592)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(267, 100)
        Me.Panel1.TabIndex = 139
        '
        'btn_save
        '
        Me.btn_save.Image = Global.PAW_Ui.My.Resources.Resources.save_64px
        Me.btn_save.Location = New System.Drawing.Point(174, 13)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(72, 72)
        Me.btn_save.TabIndex = 145
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_refresh
        '
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
        'tlp
        '
        Me.tlp.ColumnCount = 7
        Me.tlp.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.tlp.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572!))
        Me.tlp.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572!))
        Me.tlp.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572!))
        Me.tlp.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572!))
        Me.tlp.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572!))
        Me.tlp.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572!))
        Me.tlp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tlp.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.tlp.Location = New System.Drawing.Point(12, 11)
        Me.tlp.Margin = New System.Windows.Forms.Padding(2)
        Me.tlp.Name = "tlp"
        Me.tlp.RowCount = 7
        Me.tlp.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.tlp.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.tlp.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.tlp.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.tlp.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.tlp.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.tlp.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.tlp.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16.0!))
        Me.tlp.Size = New System.Drawing.Size(650, 300)
        Me.tlp.TabIndex = 140
        '
        'frm_note
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(990, 704)
        Me.ControlBox = False
        Me.Controls.Add(Me.tlp)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("B Koodak", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_note"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_save As Button
    Friend WithEvents btn_refresh As Button
    Friend WithEvents btn_home As Button
    Friend WithEvents tlp As TableLayoutPanel
End Class
