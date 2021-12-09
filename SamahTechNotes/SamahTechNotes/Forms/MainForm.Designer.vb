<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.CommandPanel = New System.Windows.Forms.Panel()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.PostMailBtn = New System.Windows.Forms.Button()
        Me.CalendarBtn = New System.Windows.Forms.Button()
        Me.GroupBtn = New System.Windows.Forms.Button()
        Me.UserAccountBtn = New System.Windows.Forms.Button()
        Me.ArchiveBtn = New System.Windows.Forms.Button()
        Me.FindEditBtn = New System.Windows.Forms.Button()
        Me.NewWorkBtn = New System.Windows.Forms.Button()
        Me.MainFormBtn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CommandLine = New System.Windows.Forms.PictureBox()
        Me.TitlePanel = New System.Windows.Forms.Panel()
        Me.LogoLabel = New System.Windows.Forms.Label()
        Me.BarPanel = New System.Windows.Forms.Panel()
        Me.MinBtn = New System.Windows.Forms.Button()
        Me.CloseBtn = New System.Windows.Forms.Button()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.MLabel = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.HLabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TodayNewSms = New System.Windows.Forms.Label()
        Me.ListOfWorks = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TodayWork10 = New System.Windows.Forms.Label()
        Me.TodayWork9 = New System.Windows.Forms.Label()
        Me.TodayWork8 = New System.Windows.Forms.Label()
        Me.TodayWork7 = New System.Windows.Forms.Label()
        Me.TodayWork6 = New System.Windows.Forms.Label()
        Me.TodayWork5 = New System.Windows.Forms.Label()
        Me.TodayWork4 = New System.Windows.Forms.Label()
        Me.TodayWork2 = New System.Windows.Forms.Label()
        Me.TodayWork3 = New System.Windows.Forms.Label()
        Me.TodayWork1 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.DayNameStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.DateStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel6 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.UserStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.CommandPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.CommandLine, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TitlePanel.SuspendLayout()
        Me.BarPanel.SuspendLayout()
        Me.MainPanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CommandPanel
        '
        Me.CommandPanel.BackColor = Color.Gray 'System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.CommandPanel.Controls.Add(Me.ExitBtn)
        Me.CommandPanel.Controls.Add(Me.PostMailBtn)
        Me.CommandPanel.Controls.Add(Me.CalendarBtn)
        Me.CommandPanel.Controls.Add(Me.GroupBtn)
        Me.CommandPanel.Controls.Add(Me.UserAccountBtn)
        Me.CommandPanel.Controls.Add(Me.ArchiveBtn)
        Me.CommandPanel.Controls.Add(Me.FindEditBtn)
        Me.CommandPanel.Controls.Add(Me.NewWorkBtn)
        Me.CommandPanel.Controls.Add(Me.MainFormBtn)
        Me.CommandPanel.Controls.Add(Me.Panel1)
        Me.CommandPanel.Controls.Add(Me.TitlePanel)
        Me.CommandPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.CommandPanel.Location = New System.Drawing.Point(0, 0)
        Me.CommandPanel.Name = "CommandPanel"
        Me.CommandPanel.Size = New System.Drawing.Size(180, 700)
        Me.CommandPanel.TabIndex = 1
        '
        'ExitBtn
        '
        Me.ExitBtn.BackColor = Color.Gray 'System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.ExitBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.ExitBtn.FlatAppearance.BorderSize = 0
        Me.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExitBtn.Font = New System.Drawing.Font("B Titr", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ExitBtn.ForeColor = System.Drawing.Color.GhostWhite
        Me.ExitBtn.Image = CType(resources.GetObject("ExitBtn.Image"), System.Drawing.Image)
        Me.ExitBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ExitBtn.Location = New System.Drawing.Point(0, 630)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(180, 70)
        Me.ExitBtn.TabIndex = 11
        Me.ExitBtn.Text = "خروج از برنامه"
        Me.ExitBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ExitBtn.UseVisualStyleBackColor = False
        '
        'PostMailBtn
        '
        Me.PostMailBtn.BackColor = Color.Gray 'System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.PostMailBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.PostMailBtn.FlatAppearance.BorderSize = 0
        Me.PostMailBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PostMailBtn.Font = New System.Drawing.Font("B Titr", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.PostMailBtn.ForeColor = System.Drawing.Color.GhostWhite
        Me.PostMailBtn.Image = CType(resources.GetObject("PostMailBtn.Image"), System.Drawing.Image)
        Me.PostMailBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PostMailBtn.Location = New System.Drawing.Point(0, 560)
        Me.PostMailBtn.Name = "PostMailBtn"
        Me.PostMailBtn.Size = New System.Drawing.Size(180, 70)
        Me.PostMailBtn.TabIndex = 10
        Me.PostMailBtn.Text = "صندوق پستی"
        Me.PostMailBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.PostMailBtn.UseVisualStyleBackColor = False
        '
        'CalendarBtn
        '
        Me.CalendarBtn.BackColor = Color.Gray 'System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.CalendarBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.CalendarBtn.FlatAppearance.BorderSize = 0
        Me.CalendarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CalendarBtn.Font = New System.Drawing.Font("B Titr", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.CalendarBtn.ForeColor = System.Drawing.Color.GhostWhite
        Me.CalendarBtn.Image = CType(resources.GetObject("CalendarBtn.Image"), System.Drawing.Image)
        Me.CalendarBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CalendarBtn.Location = New System.Drawing.Point(0, 490)
        Me.CalendarBtn.Name = "CalendarBtn"
        Me.CalendarBtn.Size = New System.Drawing.Size(180, 70)
        Me.CalendarBtn.TabIndex = 9
        Me.CalendarBtn.Text = "تقویم کاری"
        Me.CalendarBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CalendarBtn.UseVisualStyleBackColor = False
        '
        'GroupBtn
        '
        Me.GroupBtn.BackColor = Color.Gray 'System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.GroupBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBtn.FlatAppearance.BorderSize = 0
        Me.GroupBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBtn.Font = New System.Drawing.Font("B Titr", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.GroupBtn.ForeColor = System.Drawing.Color.GhostWhite
        Me.GroupBtn.Image = CType(resources.GetObject("GroupBtn.Image"), System.Drawing.Image)
        Me.GroupBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GroupBtn.Location = New System.Drawing.Point(0, 420)
        Me.GroupBtn.Name = "GroupBtn"
        Me.GroupBtn.Size = New System.Drawing.Size(180, 70)
        Me.GroupBtn.TabIndex = 8
        Me.GroupBtn.Text = "گروه / زیر گروه"
        Me.GroupBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.GroupBtn.UseVisualStyleBackColor = False
        '
        'UserAccountBtn
        '
        Me.UserAccountBtn.BackColor = Color.Gray 'System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.UserAccountBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.UserAccountBtn.FlatAppearance.BorderSize = 0
        Me.UserAccountBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UserAccountBtn.Font = New System.Drawing.Font("B Titr", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UserAccountBtn.ForeColor = System.Drawing.Color.GhostWhite
        Me.UserAccountBtn.Image = CType(resources.GetObject("UserAccountBtn.Image"), System.Drawing.Image)
        Me.UserAccountBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UserAccountBtn.Location = New System.Drawing.Point(0, 350)
        Me.UserAccountBtn.Name = "UserAccountBtn"
        Me.UserAccountBtn.Size = New System.Drawing.Size(180, 70)
        Me.UserAccountBtn.TabIndex = 7
        Me.UserAccountBtn.Text = "تنظیمات کاربری"
        Me.UserAccountBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UserAccountBtn.UseVisualStyleBackColor = False
        '
        'ArchiveBtn
        '
        Me.ArchiveBtn.BackColor = Color.Gray 'System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.ArchiveBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.ArchiveBtn.FlatAppearance.BorderSize = 0
        Me.ArchiveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ArchiveBtn.Font = New System.Drawing.Font("B Titr", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ArchiveBtn.ForeColor = System.Drawing.Color.GhostWhite
        Me.ArchiveBtn.Image = CType(resources.GetObject("ArchiveBtn.Image"), System.Drawing.Image)
        Me.ArchiveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ArchiveBtn.Location = New System.Drawing.Point(0, 280)
        Me.ArchiveBtn.Name = "ArchiveBtn"
        Me.ArchiveBtn.Size = New System.Drawing.Size(180, 70)
        Me.ArchiveBtn.TabIndex = 6
        Me.ArchiveBtn.Text = "بایگانی / پیگیری"
        Me.ArchiveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ArchiveBtn.UseVisualStyleBackColor = False
        '
        'FindEditBtn
        '
        Me.FindEditBtn.BackColor = Color.Gray 'System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.FindEditBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.FindEditBtn.FlatAppearance.BorderSize = 0
        Me.FindEditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FindEditBtn.Font = New System.Drawing.Font("B Titr", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FindEditBtn.ForeColor = System.Drawing.Color.GhostWhite
        Me.FindEditBtn.Image = CType(resources.GetObject("FindEditBtn.Image"), System.Drawing.Image)
        Me.FindEditBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.FindEditBtn.Location = New System.Drawing.Point(0, 210)
        Me.FindEditBtn.Name = "FindEditBtn"
        Me.FindEditBtn.Size = New System.Drawing.Size(180, 70)
        Me.FindEditBtn.TabIndex = 4
        Me.FindEditBtn.Text = "جستجو / ویرایش"
        Me.FindEditBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.FindEditBtn.UseVisualStyleBackColor = False
        '
        'NewWorkBtn
        '
        Me.NewWorkBtn.BackColor = Color.Gray 'System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.NewWorkBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.NewWorkBtn.FlatAppearance.BorderSize = 0
        Me.NewWorkBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NewWorkBtn.Font = New System.Drawing.Font("B Titr", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NewWorkBtn.ForeColor = System.Drawing.Color.GhostWhite
        Me.NewWorkBtn.Image = CType(resources.GetObject("NewWorkBtn.Image"), System.Drawing.Image)
        Me.NewWorkBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewWorkBtn.Location = New System.Drawing.Point(0, 140)
        Me.NewWorkBtn.Name = "NewWorkBtn"
        Me.NewWorkBtn.Size = New System.Drawing.Size(180, 70)
        Me.NewWorkBtn.TabIndex = 3
        Me.NewWorkBtn.Text = "کار جدید"
        Me.NewWorkBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.NewWorkBtn.UseVisualStyleBackColor = False
        '
        'MainFormBtn
        '
        Me.MainFormBtn.BackColor = Color.Gray 'System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.MainFormBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.MainFormBtn.FlatAppearance.BorderSize = 0
        Me.MainFormBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MainFormBtn.Font = New System.Drawing.Font("B Titr", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.MainFormBtn.ForeColor = System.Drawing.Color.GhostWhite
        Me.MainFormBtn.Image = CType(resources.GetObject("MainFormBtn.Image"), System.Drawing.Image)
        Me.MainFormBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MainFormBtn.Location = New System.Drawing.Point(0, 70)
        Me.MainFormBtn.Name = "MainFormBtn"
        Me.MainFormBtn.Size = New System.Drawing.Size(180, 70)
        Me.MainFormBtn.TabIndex = 2
        Me.MainFormBtn.Text = "صفحه اصلی"
        Me.MainFormBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.MainFormBtn.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = Color.Gray 'System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.CommandLine)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 50)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(180, 20)
        Me.Panel1.TabIndex = 1
        '
        'CommandLine
        '
        Me.CommandLine.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CommandLine.Image = CType(resources.GetObject("CommandLine.Image"), System.Drawing.Image)
        Me.CommandLine.Location = New System.Drawing.Point(0, 0)
        Me.CommandLine.Name = "CommandLine"
        Me.CommandLine.Size = New System.Drawing.Size(180, 20)
        Me.CommandLine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CommandLine.TabIndex = 0
        Me.CommandLine.TabStop = False
        '
        'TitlePanel
        '
        Me.TitlePanel.BackColor = Color.Gray 'System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.TitlePanel.Controls.Add(Me.LogoLabel)
        Me.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TitlePanel.Location = New System.Drawing.Point(0, 0)
        Me.TitlePanel.Name = "TitlePanel"
        Me.TitlePanel.Size = New System.Drawing.Size(180, 50)
        Me.TitlePanel.TabIndex = 0
        '
        'LogoLabel
        '
        Me.LogoLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LogoLabel.Font = New System.Drawing.Font("NPIMaryam", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogoLabel.ForeColor = System.Drawing.Color.White
        Me.LogoLabel.Location = New System.Drawing.Point(0, 0)
        Me.LogoLabel.Name = "LogoLabel"
        Me.LogoLabel.Size = New System.Drawing.Size(180, 50)
        Me.LogoLabel.TabIndex = 3
        Me.LogoLabel.Text = "SamahTechNotes"
        Me.LogoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BarPanel
        '
        Me.BarPanel.BackColor = Color.Gray 'System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.BarPanel.Controls.Add(Me.MinBtn)
        Me.BarPanel.Controls.Add(Me.CloseBtn)
        Me.BarPanel.Controls.Add(Me.TitleLabel)
        Me.BarPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarPanel.Location = New System.Drawing.Point(180, 0)
        Me.BarPanel.Name = "BarPanel"
        Me.BarPanel.Size = New System.Drawing.Size(600, 50)
        Me.BarPanel.TabIndex = 2
        '
        'MinBtn
        '
        Me.MinBtn.Image = CType(resources.GetObject("MinBtn.Image"), System.Drawing.Image)
        Me.MinBtn.Location = New System.Drawing.Point(522, 8)
        Me.MinBtn.Name = "MinBtn"
        Me.MinBtn.Size = New System.Drawing.Size(32, 32)
        Me.MinBtn.TabIndex = 1
        Me.MinBtn.UseVisualStyleBackColor = True
        '
        'CloseBtn
        '
        Me.CloseBtn.Image = CType(resources.GetObject("CloseBtn.Image"), System.Drawing.Image)
        Me.CloseBtn.Location = New System.Drawing.Point(560, 8)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(32, 32)
        Me.CloseBtn.TabIndex = 1
        Me.CloseBtn.UseVisualStyleBackColor = True
        '
        'TitleLabel
        '
        Me.TitleLabel.Dock = System.Windows.Forms.DockStyle.Left
        Me.TitleLabel.Font = New System.Drawing.Font("B Zar", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TitleLabel.ForeColor = System.Drawing.Color.White
        Me.TitleLabel.Location = New System.Drawing.Point(0, 0)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(516, 50)
        Me.TitleLabel.TabIndex = 0
        Me.TitleLabel.Text = "صفحه اصلی"
        Me.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MainPanel
        '
        Me.MainPanel.Controls.Add(Me.MLabel)
        Me.MainPanel.Controls.Add(Me.Label6)
        Me.MainPanel.Controls.Add(Me.HLabel)
        Me.MainPanel.Controls.Add(Me.PictureBox1)
        Me.MainPanel.Controls.Add(Me.TableLayoutPanel1)
        Me.MainPanel.Controls.Add(Me.StatusStrip1)
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPanel.Location = New System.Drawing.Point(180, 50)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(600, 650)
        Me.MainPanel.TabIndex = 4
        '
        'MLabel
        '
        Me.MLabel.BackColor = Color.Gray 'System.Drawing.Color.Transparent
        Me.MLabel.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MLabel.Location = New System.Drawing.Point(111, 64)
        Me.MLabel.Name = "MLabel"
        Me.MLabel.Size = New System.Drawing.Size(46, 40)
        Me.MLabel.TabIndex = 18
        Me.MLabel.Text = "14"
        Me.MLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = Color.Gray 'System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("B Titr", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label6.Location = New System.Drawing.Point(95, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(20, 40)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = ":"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'HLabel
        '
        Me.HLabel.BackColor = Color.Gray 'System.Drawing.Color.Transparent
        Me.HLabel.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HLabel.Location = New System.Drawing.Point(52, 64)
        Me.HLabel.Name = "HLabel"
        Me.HLabel.Size = New System.Drawing.Size(46, 40)
        Me.HLabel.TabIndex = 18
        Me.HLabel.Text = "14"
        Me.HLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = Color.Gray 'System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(188, 151)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 236.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TodayNewSms, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ListOfWorks, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 2, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(6, 160)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(591, 386)
        Me.TableLayoutPanel1.TabIndex = 16
        '
        'TodayNewSms
        '
        Me.TodayNewSms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TodayNewSms.Dock = System.Windows.Forms.DockStyle.Top
        Me.TodayNewSms.Font = New System.Drawing.Font("B Zar", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TodayNewSms.ForeColor = System.Drawing.Color.White
        Me.TodayNewSms.Location = New System.Drawing.Point(334, 38)
        Me.TodayNewSms.Name = "TodayNewSms"
        Me.TodayNewSms.Size = New System.Drawing.Size(124, 97)
        Me.TodayNewSms.TabIndex = 4
        Me.TodayNewSms.Text = "2"
        Me.TodayNewSms.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ListOfWorks
        '
        Me.ListOfWorks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListOfWorks.Dock = System.Windows.Forms.DockStyle.Top
        Me.ListOfWorks.Font = New System.Drawing.Font("B Zar", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ListOfWorks.ForeColor = System.Drawing.Color.White
        Me.ListOfWorks.Location = New System.Drawing.Point(464, 38)
        Me.ListOfWorks.Name = "ListOfWorks"
        Me.ListOfWorks.Size = New System.Drawing.Size(124, 97)
        Me.ListOfWorks.TabIndex = 3
        Me.ListOfWorks.Text = "12"
        Me.ListOfWorks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("B Zar", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(325, 38)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "یادآوری های روز"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("B Zar", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.Location = New System.Drawing.Point(334, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 38)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "پیام های جدید"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("B Zar", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.Location = New System.Drawing.Point(464, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "کارهای جاری"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TodayWork10, 0, 8)
        Me.TableLayoutPanel2.Controls.Add(Me.TodayWork9, 0, 7)
        Me.TableLayoutPanel2.Controls.Add(Me.TodayWork8, 0, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.TodayWork7, 0, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.TodayWork6, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.TodayWork5, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.TodayWork4, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.TodayWork2, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.TodayWork3, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.TodayWork1, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 41)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 9
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(325, 342)
        Me.TableLayoutPanel2.TabIndex = 5
        '
        'TodayWork10
        '
        Me.TodayWork10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TodayWork10.Dock = System.Windows.Forms.DockStyle.Top
        Me.TodayWork10.Font = New System.Drawing.Font("B Zar", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TodayWork10.ForeColor = System.Drawing.Color.White
        Me.TodayWork10.Location = New System.Drawing.Point(3, 306)
        Me.TodayWork10.Name = "TodayWork10"
        Me.TodayWork10.Size = New System.Drawing.Size(319, 33)
        Me.TodayWork10.TabIndex = 14
        Me.TodayWork10.Text = "کار جدید امروز 1"
        Me.TodayWork10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TodayWork9
        '
        Me.TodayWork9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TodayWork9.Dock = System.Windows.Forms.DockStyle.Top
        Me.TodayWork9.Font = New System.Drawing.Font("B Zar", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TodayWork9.ForeColor = System.Drawing.Color.White
        Me.TodayWork9.Location = New System.Drawing.Point(3, 272)
        Me.TodayWork9.Name = "TodayWork9"
        Me.TodayWork9.Size = New System.Drawing.Size(319, 27)
        Me.TodayWork9.TabIndex = 13
        Me.TodayWork9.Text = "کار جدید امروز 1"
        Me.TodayWork9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TodayWork8
        '
        Me.TodayWork8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TodayWork8.Dock = System.Windows.Forms.DockStyle.Top
        Me.TodayWork8.Font = New System.Drawing.Font("B Zar", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TodayWork8.ForeColor = System.Drawing.Color.White
        Me.TodayWork8.Location = New System.Drawing.Point(3, 238)
        Me.TodayWork8.Name = "TodayWork8"
        Me.TodayWork8.Size = New System.Drawing.Size(319, 27)
        Me.TodayWork8.TabIndex = 12
        Me.TodayWork8.Text = "کار جدید امروز 1"
        Me.TodayWork8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TodayWork7
        '
        Me.TodayWork7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TodayWork7.Dock = System.Windows.Forms.DockStyle.Top
        Me.TodayWork7.Font = New System.Drawing.Font("B Zar", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TodayWork7.ForeColor = System.Drawing.Color.White
        Me.TodayWork7.Location = New System.Drawing.Point(3, 204)
        Me.TodayWork7.Name = "TodayWork7"
        Me.TodayWork7.Size = New System.Drawing.Size(319, 27)
        Me.TodayWork7.TabIndex = 11
        Me.TodayWork7.Text = "کار جدید امروز 1"
        Me.TodayWork7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TodayWork6
        '
        Me.TodayWork6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TodayWork6.Dock = System.Windows.Forms.DockStyle.Top
        Me.TodayWork6.Font = New System.Drawing.Font("B Zar", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TodayWork6.ForeColor = System.Drawing.Color.White
        Me.TodayWork6.Location = New System.Drawing.Point(3, 170)
        Me.TodayWork6.Name = "TodayWork6"
        Me.TodayWork6.Size = New System.Drawing.Size(319, 27)
        Me.TodayWork6.TabIndex = 10
        Me.TodayWork6.Text = "کار جدید امروز 1"
        Me.TodayWork6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TodayWork5
        '
        Me.TodayWork5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TodayWork5.Dock = System.Windows.Forms.DockStyle.Top
        Me.TodayWork5.Font = New System.Drawing.Font("B Zar", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TodayWork5.ForeColor = System.Drawing.Color.White
        Me.TodayWork5.Location = New System.Drawing.Point(3, 136)
        Me.TodayWork5.Name = "TodayWork5"
        Me.TodayWork5.Size = New System.Drawing.Size(319, 27)
        Me.TodayWork5.TabIndex = 9
        Me.TodayWork5.Text = "کار جدید امروز 1"
        Me.TodayWork5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TodayWork4
        '
        Me.TodayWork4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TodayWork4.Dock = System.Windows.Forms.DockStyle.Top
        Me.TodayWork4.Font = New System.Drawing.Font("B Zar", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TodayWork4.ForeColor = System.Drawing.Color.White
        Me.TodayWork4.Location = New System.Drawing.Point(3, 102)
        Me.TodayWork4.Name = "TodayWork4"
        Me.TodayWork4.Size = New System.Drawing.Size(319, 27)
        Me.TodayWork4.TabIndex = 8
        Me.TodayWork4.Text = "کار جدید امروز 1"
        Me.TodayWork4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TodayWork2
        '
        Me.TodayWork2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TodayWork2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TodayWork2.Font = New System.Drawing.Font("B Zar", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TodayWork2.ForeColor = System.Drawing.Color.White
        Me.TodayWork2.Location = New System.Drawing.Point(3, 34)
        Me.TodayWork2.Name = "TodayWork2"
        Me.TodayWork2.Size = New System.Drawing.Size(319, 27)
        Me.TodayWork2.TabIndex = 7
        Me.TodayWork2.Text = "کار جدید امروز 1"
        Me.TodayWork2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TodayWork3
        '
        Me.TodayWork3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TodayWork3.Dock = System.Windows.Forms.DockStyle.Top
        Me.TodayWork3.Font = New System.Drawing.Font("B Zar", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TodayWork3.ForeColor = System.Drawing.Color.White
        Me.TodayWork3.Location = New System.Drawing.Point(3, 68)
        Me.TodayWork3.Name = "TodayWork3"
        Me.TodayWork3.Size = New System.Drawing.Size(319, 27)
        Me.TodayWork3.TabIndex = 6
        Me.TodayWork3.Text = "کار جدید امروز 1"
        Me.TodayWork3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TodayWork1
        '
        Me.TodayWork1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TodayWork1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TodayWork1.Font = New System.Drawing.Font("B Zar", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TodayWork1.ForeColor = System.Drawing.Color.White
        Me.TodayWork1.Location = New System.Drawing.Point(3, 0)
        Me.TodayWork1.Name = "TodayWork1"
        Me.TodayWork1.Size = New System.Drawing.Size(319, 27)
        Me.TodayWork1.TabIndex = 5
        Me.TodayWork1.Text = "کار جدید امروز 1"
        Me.TodayWork1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = Color.Gray 'System.Drawing.Color.Transparent
        Me.StatusStrip1.Font = New System.Drawing.Font("B Mitra", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.DayNameStatus, Me.ToolStripStatusLabel3, Me.DateStatus, Me.ToolStripStatusLabel5, Me.ToolStripStatusLabel6, Me.UserStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 618)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(600, 32)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 15
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(45, 27)
        Me.ToolStripStatusLabel1.Text = "امروز: "
        '
        'DayNameStatus
        '
        Me.DayNameStatus.Name = "DayNameStatus"
        Me.DayNameStatus.Size = New System.Drawing.Size(60, 27)
        Me.DayNameStatus.Text = "چهارشنبه"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(28, 27)
        Me.ToolStripStatusLabel3.Text = " - "
        '
        'DateStatus
        '
        Me.DateStatus.Name = "DateStatus"
        Me.DateStatus.Size = New System.Drawing.Size(86, 27)
        Me.DateStatus.Text = "1400/01/18"
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(28, 27)
        Me.ToolStripStatusLabel5.Text = " - "
        '
        'ToolStripStatusLabel6
        '
        Me.ToolStripStatusLabel6.Name = "ToolStripStatusLabel6"
        Me.ToolStripStatusLabel6.Size = New System.Drawing.Size(72, 27)
        Me.ToolStripStatusLabel6.Text = "کاربر فعال: "
        '
        'UserStatus
        '
        Me.UserStatus.Name = "UserStatus"
        Me.UserStatus.Size = New System.Drawing.Size(266, 27)
        Me.UserStatus.Spring = True
        Me.UserStatus.Text = "سیدامیر موسوی"
        Me.UserStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'MainForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = Color.Gray 'System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(780, 700)
        Me.ControlBox = False
        Me.Controls.Add(Me.MainPanel)
        Me.Controls.Add(Me.BarPanel)
        Me.Controls.Add(Me.CommandPanel)
        Me.Font = New System.Drawing.Font("B Zar", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "دفترچه یاداشت سما / صفحه اصلی"
        Me.CommandPanel.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.CommandLine, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TitlePanel.ResumeLayout(False)
        Me.BarPanel.ResumeLayout(False)
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanel.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CommandPanel As Panel
    Friend WithEvents TitlePanel As Panel
    Friend WithEvents LogoLabel As Label
    Friend WithEvents BarPanel As Panel
    Friend WithEvents TitleLabel As Label
    Friend WithEvents CloseBtn As Button
    Friend WithEvents MinBtn As Button
    Friend WithEvents MainFormBtn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ArchiveBtn As Button
    Friend WithEvents FindEditBtn As Button
    Friend WithEvents NewWorkBtn As Button
    Friend WithEvents ExitBtn As Button
    Friend WithEvents PostMailBtn As Button
    Friend WithEvents CalendarBtn As Button
    Friend WithEvents GroupBtn As Button
    Friend WithEvents UserAccountBtn As Button
    Friend WithEvents CommandLine As PictureBox
    Friend WithEvents MainPanel As Panel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents DayNameStatus As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents DateStatus As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel6 As ToolStripStatusLabel
    Friend WithEvents UserStatus As ToolStripStatusLabel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TodayNewSms As Label
    Friend WithEvents ListOfWorks As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TodayWork10 As Label
    Friend WithEvents TodayWork9 As Label
    Friend WithEvents TodayWork8 As Label
    Friend WithEvents TodayWork7 As Label
    Friend WithEvents TodayWork6 As Label
    Friend WithEvents TodayWork5 As Label
    Friend WithEvents TodayWork4 As Label
    Friend WithEvents TodayWork2 As Label
    Friend WithEvents TodayWork3 As Label
    Friend WithEvents TodayWork1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label6 As Label
    Friend WithEvents MLabel As Label
    Friend WithEvents HLabel As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
