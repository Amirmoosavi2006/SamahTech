<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lbl_computer = New System.Windows.Forms.Label()
        Me.lbl_user = New System.Windows.Forms.Label()
        Me.btn_start = New System.Windows.Forms.Button()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.b_computer = New System.Windows.Forms.PictureBox()
        Me.b_stone = New System.Windows.Forms.Button()
        Me.b_paper = New System.Windows.Forms.Button()
        Me.b_scissor = New System.Windows.Forms.Button()
        CType(Me.b_computer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("B Compset", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.Location = New System.Drawing.Point(596, 246)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 48)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "امتیاز"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_computer
        '
        Me.lbl_computer.AutoSize = True
        Me.lbl_computer.Font = New System.Drawing.Font("B Compset", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbl_computer.Location = New System.Drawing.Point(610, 67)
        Me.lbl_computer.Name = "lbl_computer"
        Me.lbl_computer.Size = New System.Drawing.Size(33, 48)
        Me.lbl_computer.TabIndex = 2
        Me.lbl_computer.Text = "0"
        Me.lbl_computer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_user
        '
        Me.lbl_user.AutoSize = True
        Me.lbl_user.Font = New System.Drawing.Font("B Compset", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbl_user.Location = New System.Drawing.Point(610, 433)
        Me.lbl_user.Name = "lbl_user"
        Me.lbl_user.Size = New System.Drawing.Size(33, 48)
        Me.lbl_user.TabIndex = 2
        Me.lbl_user.Text = "0"
        Me.lbl_user.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_start
        '
        Me.btn_start.Font = New System.Drawing.Font("B Compset", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btn_start.Location = New System.Drawing.Point(170, 220)
        Me.btn_start.Name = "btn_start"
        Me.btn_start.Size = New System.Drawing.Size(152, 56)
        Me.btn_start.TabIndex = 3
        Me.btn_start.Text = "بازی جدید"
        Me.btn_start.UseVisualStyleBackColor = True
        '
        'btn_exit
        '
        Me.btn_exit.Font = New System.Drawing.Font("B Compset", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btn_exit.Location = New System.Drawing.Point(170, 282)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(152, 56)
        Me.btn_exit.TabIndex = 3
        Me.btn_exit.Text = "خروج"
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'b_computer
        '
        Me.b_computer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.b_computer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.b_computer.Image = Global.SPS.My.Resources.Resources.M_83
        Me.b_computer.Location = New System.Drawing.Point(170, 12)
        Me.b_computer.Name = "b_computer"
        Me.b_computer.Size = New System.Drawing.Size(152, 176)
        Me.b_computer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.b_computer.TabIndex = 1
        Me.b_computer.TabStop = False
        '
        'b_stone
        '
        Me.b_stone.BackgroundImage = Global.SPS.My.Resources.Resources.Stone
        Me.b_stone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.b_stone.Location = New System.Drawing.Point(328, 369)
        Me.b_stone.Name = "b_stone"
        Me.b_stone.Size = New System.Drawing.Size(152, 176)
        Me.b_stone.TabIndex = 0
        Me.b_stone.UseVisualStyleBackColor = True
        '
        'b_paper
        '
        Me.b_paper.BackgroundImage = Global.SPS.My.Resources.Resources.Paper
        Me.b_paper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.b_paper.Location = New System.Drawing.Point(170, 369)
        Me.b_paper.Name = "b_paper"
        Me.b_paper.Size = New System.Drawing.Size(152, 176)
        Me.b_paper.TabIndex = 0
        Me.b_paper.UseVisualStyleBackColor = True
        '
        'b_scissor
        '
        Me.b_scissor.BackgroundImage = Global.SPS.My.Resources.Resources.Scissors
        Me.b_scissor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.b_scissor.Location = New System.Drawing.Point(12, 369)
        Me.b_scissor.Name = "b_scissor"
        Me.b_scissor.Size = New System.Drawing.Size(152, 176)
        Me.b_scissor.TabIndex = 0
        Me.b_scissor.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(759, 557)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.btn_start)
        Me.Controls.Add(Me.lbl_computer)
        Me.Controls.Add(Me.lbl_user)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.b_computer)
        Me.Controls.Add(Me.b_stone)
        Me.Controls.Add(Me.b_paper)
        Me.Controls.Add(Me.b_scissor)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.b_computer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents b_scissor As Button
    Friend WithEvents b_paper As Button
    Friend WithEvents b_stone As Button
    Friend WithEvents b_computer As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_computer As Label
    Friend WithEvents lbl_user As Label
    Friend WithEvents btn_start As Button
    Friend WithEvents btn_exit As Button
End Class
