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
        Me.txt_sip = New System.Windows.Forms.TextBox()
        Me.btn_start = New System.Windows.Forms.Button()
        Me.txt_sport = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_cport = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_connect = New System.Windows.Forms.Button()
        Me.txt_cip = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_chats = New System.Windows.Forms.TextBox()
        Me.txt_msg = New System.Windows.Forms.TextBox()
        Me.btn_send = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Server IP"
        '
        'txt_sip
        '
        Me.txt_sip.Enabled = False
        Me.txt_sip.Location = New System.Drawing.Point(84, 17)
        Me.txt_sip.Name = "txt_sip"
        Me.txt_sip.Size = New System.Drawing.Size(126, 22)
        Me.txt_sip.TabIndex = 1
        '
        'btn_start
        '
        Me.btn_start.Location = New System.Drawing.Point(448, 17)
        Me.btn_start.Name = "btn_start"
        Me.btn_start.Size = New System.Drawing.Size(97, 23)
        Me.btn_start.TabIndex = 2
        Me.btn_start.Text = "Start"
        Me.btn_start.UseVisualStyleBackColor = True
        '
        'txt_sport
        '
        Me.txt_sport.Location = New System.Drawing.Point(316, 17)
        Me.txt_sport.Name = "txt_sport"
        Me.txt_sport.Size = New System.Drawing.Size(126, 22)
        Me.txt_sport.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(230, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Server Port"
        '
        'txt_cport
        '
        Me.txt_cport.Location = New System.Drawing.Point(316, 45)
        Me.txt_cport.Name = "txt_cport"
        Me.txt_cport.Size = New System.Drawing.Size(126, 22)
        Me.txt_cport.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(230, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Client Port"
        '
        'btn_connect
        '
        Me.btn_connect.Location = New System.Drawing.Point(448, 45)
        Me.btn_connect.Name = "btn_connect"
        Me.btn_connect.Size = New System.Drawing.Size(97, 23)
        Me.btn_connect.TabIndex = 7
        Me.btn_connect.Text = "Connect"
        Me.btn_connect.UseVisualStyleBackColor = True
        '
        'txt_cip
        '
        Me.txt_cip.Location = New System.Drawing.Point(84, 45)
        Me.txt_cip.Name = "txt_cip"
        Me.txt_cip.Size = New System.Drawing.Size(126, 22)
        Me.txt_cip.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Client IP"
        '
        'txt_chats
        '
        Me.txt_chats.Location = New System.Drawing.Point(15, 73)
        Me.txt_chats.Multiline = True
        Me.txt_chats.Name = "txt_chats"
        Me.txt_chats.Size = New System.Drawing.Size(530, 312)
        Me.txt_chats.TabIndex = 10
        '
        'txt_msg
        '
        Me.txt_msg.Location = New System.Drawing.Point(15, 391)
        Me.txt_msg.Multiline = True
        Me.txt_msg.Name = "txt_msg"
        Me.txt_msg.Size = New System.Drawing.Size(427, 67)
        Me.txt_msg.TabIndex = 11
        '
        'btn_send
        '
        Me.btn_send.Location = New System.Drawing.Point(449, 391)
        Me.btn_send.Name = "btn_send"
        Me.btn_send.Size = New System.Drawing.Size(97, 67)
        Me.btn_send.TabIndex = 12
        Me.btn_send.Text = "Send"
        Me.btn_send.UseVisualStyleBackColor = True
        '
        'BackgroundWorker1
        '
        '
        'BackgroundWorker2
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 476)
        Me.Controls.Add(Me.btn_send)
        Me.Controls.Add(Me.txt_msg)
        Me.Controls.Add(Me.txt_chats)
        Me.Controls.Add(Me.txt_cport)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btn_connect)
        Me.Controls.Add(Me.txt_cip)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_sport)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_start)
        Me.Controls.Add(Me.txt_sip)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_sip As TextBox
    Friend WithEvents btn_start As Button
    Friend WithEvents txt_sport As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_cport As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_connect As Button
    Friend WithEvents txt_cip As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_chats As TextBox
    Friend WithEvents txt_msg As TextBox
    Friend WithEvents btn_send As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
End Class
