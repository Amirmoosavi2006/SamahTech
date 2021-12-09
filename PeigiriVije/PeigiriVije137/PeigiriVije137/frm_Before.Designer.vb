<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Before
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Before))
        Me.btn_Excel_Load = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_Letter_No = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_Visitor_Name = New System.Windows.Forms.TextBox()
        Me.btn_Print_Report = New System.Windows.Forms.Button()
        Me.btn_Report_New = New System.Windows.Forms.Button()
        Me.btn_Return = New System.Windows.Forms.Button()
        Me.ofd_xls = New System.Windows.Forms.OpenFileDialog()
        Me.Dgv_Data = New System.Windows.Forms.DataGridView()
        Me.btn_Pic_Load = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_Save_Report = New System.Windows.Forms.Button()
        Me.txt_Report_Create_Date_Day = New System.Windows.Forms.DomainUpDown()
        Me.txt_Report_Create_Date_Month = New System.Windows.Forms.DomainUpDown()
        Me.txt_Report_Create_Date_Year = New System.Windows.Forms.DomainUpDown()
        Me.TabPage9 = New System.Windows.Forms.TabPage()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_Answer = New System.Windows.Forms.RichTextBox()
        Me.txt_Zone = New System.Windows.Forms.TextBox()
        Me.txt_Region = New System.Windows.Forms.TextBox()
        Me.txt_status = New System.Windows.Forms.TextBox()
        Me.txt_Adres = New System.Windows.Forms.TextBox()
        Me.txt_Summary = New System.Windows.Forms.TextBox()
        Me.txt_Subject = New System.Windows.Forms.TextBox()
        Me.pic_Before = New System.Windows.Forms.PictureBox()
        Me.txt_Code = New System.Windows.Forms.TextBox()
        Me.txt_Area = New System.Windows.Forms.TextBox()
        Me.Label76 = New System.Windows.Forms.Label()
        Me.Label77 = New System.Windows.Forms.Label()
        Me.Label78 = New System.Windows.Forms.Label()
        Me.Label79 = New System.Windows.Forms.Label()
        Me.Label80 = New System.Windows.Forms.Label()
        Me.Label81 = New System.Windows.Forms.Label()
        Me.Label82 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label83 = New System.Windows.Forms.Label()
        Me.Label84 = New System.Windows.Forms.Label()
        CType(Me.Dgv_Data, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.pic_Before, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Excel_Load
        '
        Me.btn_Excel_Load.Font = New System.Drawing.Font("B Nazanin", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btn_Excel_Load.Location = New System.Drawing.Point(165, 12)
        Me.btn_Excel_Load.Name = "btn_Excel_Load"
        Me.btn_Excel_Load.Size = New System.Drawing.Size(147, 47)
        Me.btn_Excel_Load.TabIndex = 6
        Me.btn_Excel_Load.Text = "بارگزاری فایل اکسل "
        Me.btn_Excel_Load.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(874, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 23)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "شماره نامه"
        '
        'txt_Letter_No
        '
        Me.txt_Letter_No.Location = New System.Drawing.Point(696, 38)
        Me.txt_Letter_No.Name = "txt_Letter_No"
        Me.txt_Letter_No.Size = New System.Drawing.Size(172, 30)
        Me.txt_Letter_No.TabIndex = 0
        Me.txt_Letter_No.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(874, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 23)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "نام بازدید کننده"
        '
        'txt_Visitor_Name
        '
        Me.txt_Visitor_Name.Location = New System.Drawing.Point(696, 74)
        Me.txt_Visitor_Name.Name = "txt_Visitor_Name"
        Me.txt_Visitor_Name.Size = New System.Drawing.Size(172, 30)
        Me.txt_Visitor_Name.TabIndex = 1
        Me.txt_Visitor_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_Print_Report
        '
        Me.btn_Print_Report.Font = New System.Drawing.Font("B Nazanin", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btn_Print_Report.Location = New System.Drawing.Point(12, 12)
        Me.btn_Print_Report.Name = "btn_Print_Report"
        Me.btn_Print_Report.Size = New System.Drawing.Size(147, 47)
        Me.btn_Print_Report.TabIndex = 7
        Me.btn_Print_Report.Text = "چاپ فرم بازدید"
        Me.btn_Print_Report.UseVisualStyleBackColor = True
        '
        'btn_Report_New
        '
        Me.btn_Report_New.Font = New System.Drawing.Font("B Nazanin", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btn_Report_New.Location = New System.Drawing.Point(12, 65)
        Me.btn_Report_New.Name = "btn_Report_New"
        Me.btn_Report_New.Size = New System.Drawing.Size(147, 47)
        Me.btn_Report_New.TabIndex = 8
        Me.btn_Report_New.Text = "ایجاد فرم جدید"
        Me.btn_Report_New.UseVisualStyleBackColor = True
        '
        'btn_Return
        '
        Me.btn_Return.Font = New System.Drawing.Font("B Nazanin", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btn_Return.Location = New System.Drawing.Point(12, 118)
        Me.btn_Return.Name = "btn_Return"
        Me.btn_Return.Size = New System.Drawing.Size(147, 47)
        Me.btn_Return.TabIndex = 9
        Me.btn_Return.Text = "بازگشت"
        Me.btn_Return.UseVisualStyleBackColor = True
        '
        'ofd_xls
        '
        Me.ofd_xls.DefaultExt = """"""
        Me.ofd_xls.Filter = "xls files (*.xls)|*.xls|xlsx files (*.xlsx)|*.xlsx|xlsm files (*.xlsm)|*.xlsm"
        Me.ofd_xls.FilterIndex = 2
        Me.ofd_xls.RestoreDirectory = True
        Me.ofd_xls.Title = "معاونت پیگیری و کنترل"
        '
        'Dgv_Data
        '
        Me.Dgv_Data.AllowUserToAddRows = False
        Me.Dgv_Data.AllowUserToDeleteRows = False
        Me.Dgv_Data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Dgv_Data.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.Dgv_Data.BackgroundColor = System.Drawing.Color.LightYellow
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Coral
        DataGridViewCellStyle1.Font = New System.Drawing.Font("B Nazanin", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv_Data.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Dgv_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Data.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Dgv_Data.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.Dgv_Data.Location = New System.Drawing.Point(0, 541)
        Me.Dgv_Data.MultiSelect = False
        Me.Dgv_Data.Name = "Dgv_Data"
        Me.Dgv_Data.ReadOnly = True
        Me.Dgv_Data.RowHeadersVisible = False
        Me.Dgv_Data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgv_Data.ShowCellErrors = False
        Me.Dgv_Data.ShowCellToolTips = False
        Me.Dgv_Data.ShowEditingIcon = False
        Me.Dgv_Data.ShowRowErrors = False
        Me.Dgv_Data.Size = New System.Drawing.Size(984, 120)
        Me.Dgv_Data.TabIndex = 10
        Me.Dgv_Data.TabStop = False
        '
        'btn_Pic_Load
        '
        Me.btn_Pic_Load.Font = New System.Drawing.Font("B Nazanin", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btn_Pic_Load.Location = New System.Drawing.Point(165, 65)
        Me.btn_Pic_Load.Name = "btn_Pic_Load"
        Me.btn_Pic_Load.Size = New System.Drawing.Size(147, 47)
        Me.btn_Pic_Load.TabIndex = 5
        Me.btn_Pic_Load.Text = "بارگزاری عکس"
        Me.btn_Pic_Load.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(874, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 23)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "تاریخ ذخیره فرم"
        '
        'btn_Save_Report
        '
        Me.btn_Save_Report.Font = New System.Drawing.Font("B Nazanin", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btn_Save_Report.Location = New System.Drawing.Point(165, 118)
        Me.btn_Save_Report.Name = "btn_Save_Report"
        Me.btn_Save_Report.Size = New System.Drawing.Size(147, 47)
        Me.btn_Save_Report.TabIndex = 5
        Me.btn_Save_Report.Text = "ذخیره فرم"
        Me.btn_Save_Report.UseVisualStyleBackColor = True
        '
        'txt_Report_Create_Date_Day
        '
        Me.txt_Report_Create_Date_Day.Items.Add("31")
        Me.txt_Report_Create_Date_Day.Items.Add("30")
        Me.txt_Report_Create_Date_Day.Items.Add("29")
        Me.txt_Report_Create_Date_Day.Items.Add("28")
        Me.txt_Report_Create_Date_Day.Items.Add("27")
        Me.txt_Report_Create_Date_Day.Items.Add("26")
        Me.txt_Report_Create_Date_Day.Items.Add("25")
        Me.txt_Report_Create_Date_Day.Items.Add("24")
        Me.txt_Report_Create_Date_Day.Items.Add("23")
        Me.txt_Report_Create_Date_Day.Items.Add("22")
        Me.txt_Report_Create_Date_Day.Items.Add("21")
        Me.txt_Report_Create_Date_Day.Items.Add("20")
        Me.txt_Report_Create_Date_Day.Items.Add("19")
        Me.txt_Report_Create_Date_Day.Items.Add("18")
        Me.txt_Report_Create_Date_Day.Items.Add("17")
        Me.txt_Report_Create_Date_Day.Items.Add("16")
        Me.txt_Report_Create_Date_Day.Items.Add("15")
        Me.txt_Report_Create_Date_Day.Items.Add("14")
        Me.txt_Report_Create_Date_Day.Items.Add("13")
        Me.txt_Report_Create_Date_Day.Items.Add("12")
        Me.txt_Report_Create_Date_Day.Items.Add("11")
        Me.txt_Report_Create_Date_Day.Items.Add("10")
        Me.txt_Report_Create_Date_Day.Items.Add("09")
        Me.txt_Report_Create_Date_Day.Items.Add("08")
        Me.txt_Report_Create_Date_Day.Items.Add("07")
        Me.txt_Report_Create_Date_Day.Items.Add("06")
        Me.txt_Report_Create_Date_Day.Items.Add("05")
        Me.txt_Report_Create_Date_Day.Items.Add("04")
        Me.txt_Report_Create_Date_Day.Items.Add("03")
        Me.txt_Report_Create_Date_Day.Items.Add("02")
        Me.txt_Report_Create_Date_Day.Items.Add("01")
        Me.txt_Report_Create_Date_Day.Location = New System.Drawing.Point(828, 112)
        Me.txt_Report_Create_Date_Day.Name = "txt_Report_Create_Date_Day"
        Me.txt_Report_Create_Date_Day.Size = New System.Drawing.Size(40, 30)
        Me.txt_Report_Create_Date_Day.TabIndex = 17
        Me.txt_Report_Create_Date_Day.TabStop = False
        Me.txt_Report_Create_Date_Day.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_Report_Create_Date_Day.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        '
        'txt_Report_Create_Date_Month
        '
        Me.txt_Report_Create_Date_Month.Items.Add("12")
        Me.txt_Report_Create_Date_Month.Items.Add("11")
        Me.txt_Report_Create_Date_Month.Items.Add("10")
        Me.txt_Report_Create_Date_Month.Items.Add("09")
        Me.txt_Report_Create_Date_Month.Items.Add("08")
        Me.txt_Report_Create_Date_Month.Items.Add("07")
        Me.txt_Report_Create_Date_Month.Items.Add("06")
        Me.txt_Report_Create_Date_Month.Items.Add("05")
        Me.txt_Report_Create_Date_Month.Items.Add("04")
        Me.txt_Report_Create_Date_Month.Items.Add("03")
        Me.txt_Report_Create_Date_Month.Items.Add("02")
        Me.txt_Report_Create_Date_Month.Items.Add("01")
        Me.txt_Report_Create_Date_Month.Location = New System.Drawing.Point(782, 112)
        Me.txt_Report_Create_Date_Month.Name = "txt_Report_Create_Date_Month"
        Me.txt_Report_Create_Date_Month.Size = New System.Drawing.Size(40, 30)
        Me.txt_Report_Create_Date_Month.TabIndex = 17
        Me.txt_Report_Create_Date_Month.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_Report_Create_Date_Month.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        '
        'txt_Report_Create_Date_Year
        '
        Me.txt_Report_Create_Date_Year.Items.Add("1410")
        Me.txt_Report_Create_Date_Year.Items.Add("1409")
        Me.txt_Report_Create_Date_Year.Items.Add("1408")
        Me.txt_Report_Create_Date_Year.Items.Add("1407")
        Me.txt_Report_Create_Date_Year.Items.Add("1406")
        Me.txt_Report_Create_Date_Year.Items.Add("1405")
        Me.txt_Report_Create_Date_Year.Items.Add("1404")
        Me.txt_Report_Create_Date_Year.Items.Add("1403")
        Me.txt_Report_Create_Date_Year.Items.Add("1402")
        Me.txt_Report_Create_Date_Year.Items.Add("1401")
        Me.txt_Report_Create_Date_Year.Items.Add("1400")
        Me.txt_Report_Create_Date_Year.Items.Add("1399")
        Me.txt_Report_Create_Date_Year.Location = New System.Drawing.Point(696, 113)
        Me.txt_Report_Create_Date_Year.Name = "txt_Report_Create_Date_Year"
        Me.txt_Report_Create_Date_Year.Size = New System.Drawing.Size(80, 30)
        Me.txt_Report_Create_Date_Year.TabIndex = 17
        Me.txt_Report_Create_Date_Year.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_Report_Create_Date_Year.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        '
        'TabPage9
        '
        Me.TabPage9.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage9.Font = New System.Drawing.Font("B Nazanin", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TabPage9.Location = New System.Drawing.Point(4, 29)
        Me.TabPage9.Name = "TabPage9"
        Me.TabPage9.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage9.Size = New System.Drawing.Size(976, 0)
        Me.TabPage9.TabIndex = 8
        Me.TabPage9.Text = "1234567890"
        Me.TabPage9.ToolTipText = "کد پیام"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage9)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TabControl1.HotTrack = True
        Me.TabControl1.ItemSize = New System.Drawing.Size(10, 25)
        Me.TabControl1.Location = New System.Drawing.Point(0, 511)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.RightToLeftLayout = True
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(984, 30)
        Me.TabControl1.TabIndex = 18
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txt_Answer)
        Me.Panel1.Controls.Add(Me.txt_Zone)
        Me.Panel1.Controls.Add(Me.txt_Region)
        Me.Panel1.Controls.Add(Me.txt_status)
        Me.Panel1.Controls.Add(Me.txt_Adres)
        Me.Panel1.Controls.Add(Me.txt_Summary)
        Me.Panel1.Controls.Add(Me.txt_Subject)
        Me.Panel1.Controls.Add(Me.pic_Before)
        Me.Panel1.Controls.Add(Me.txt_Code)
        Me.Panel1.Controls.Add(Me.txt_Area)
        Me.Panel1.Controls.Add(Me.Label76)
        Me.Panel1.Controls.Add(Me.Label77)
        Me.Panel1.Controls.Add(Me.Label78)
        Me.Panel1.Controls.Add(Me.Label79)
        Me.Panel1.Controls.Add(Me.Label80)
        Me.Panel1.Controls.Add(Me.Label81)
        Me.Panel1.Controls.Add(Me.Label82)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label83)
        Me.Panel1.Controls.Add(Me.Label84)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 173)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(984, 338)
        Me.Panel1.TabIndex = 19
        '
        'txt_Answer
        '
        Me.txt_Answer.Location = New System.Drawing.Point(7, 7)
        Me.txt_Answer.Name = "txt_Answer"
        Me.txt_Answer.Size = New System.Drawing.Size(347, 138)
        Me.txt_Answer.TabIndex = 56
        Me.txt_Answer.Text = ""
        '
        'txt_Zone
        '
        Me.txt_Zone.Location = New System.Drawing.Point(734, 76)
        Me.txt_Zone.Name = "txt_Zone"
        Me.txt_Zone.Size = New System.Drawing.Size(46, 30)
        Me.txt_Zone.TabIndex = 53
        Me.txt_Zone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_Region
        '
        Me.txt_Region.Location = New System.Drawing.Point(839, 76)
        Me.txt_Region.Name = "txt_Region"
        Me.txt_Region.Size = New System.Drawing.Size(46, 30)
        Me.txt_Region.TabIndex = 50
        Me.txt_Region.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_status
        '
        Me.txt_status.Location = New System.Drawing.Point(481, 256)
        Me.txt_status.Name = "txt_status"
        Me.txt_status.Size = New System.Drawing.Size(404, 30)
        Me.txt_status.TabIndex = 55
        '
        'txt_Adres
        '
        Me.txt_Adres.Location = New System.Drawing.Point(481, 220)
        Me.txt_Adres.Name = "txt_Adres"
        Me.txt_Adres.Size = New System.Drawing.Size(404, 30)
        Me.txt_Adres.TabIndex = 51
        '
        'txt_Summary
        '
        Me.txt_Summary.Location = New System.Drawing.Point(481, 184)
        Me.txt_Summary.Name = "txt_Summary"
        Me.txt_Summary.Size = New System.Drawing.Size(404, 30)
        Me.txt_Summary.TabIndex = 52
        '
        'txt_Subject
        '
        Me.txt_Subject.Location = New System.Drawing.Point(481, 148)
        Me.txt_Subject.Name = "txt_Subject"
        Me.txt_Subject.Size = New System.Drawing.Size(404, 30)
        Me.txt_Subject.TabIndex = 54
        '
        'pic_Before
        '
        Me.pic_Before.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pic_Before.Image = Global.PeigiriVije137.My.Resources.Resources.plus
        Me.pic_Before.Location = New System.Drawing.Point(7, 151)
        Me.pic_Before.Name = "pic_Before"
        Me.pic_Before.Size = New System.Drawing.Size(347, 180)
        Me.pic_Before.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_Before.TabIndex = 57
        Me.pic_Before.TabStop = False
        '
        'txt_Code
        '
        Me.txt_Code.Font = New System.Drawing.Font("B Nazanin", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txt_Code.Location = New System.Drawing.Point(734, 40)
        Me.txt_Code.Name = "txt_Code"
        Me.txt_Code.Size = New System.Drawing.Size(151, 31)
        Me.txt_Code.TabIndex = 49
        Me.txt_Code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_Area
        '
        Me.txt_Area.Location = New System.Drawing.Point(734, 112)
        Me.txt_Area.Name = "txt_Area"
        Me.txt_Area.Size = New System.Drawing.Size(151, 30)
        Me.txt_Area.TabIndex = 49
        '
        'Label76
        '
        Me.Label76.AutoSize = True
        Me.Label76.Location = New System.Drawing.Point(786, 79)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(35, 23)
        Me.Label76.TabIndex = 48
        Me.Label76.Text = "ناحیه"
        '
        'Label77
        '
        Me.Label77.AutoSize = True
        Me.Label77.Location = New System.Drawing.Point(891, 79)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(39, 23)
        Me.Label77.TabIndex = 47
        Me.Label77.Text = "منطقه"
        '
        'Label78
        '
        Me.Label78.AutoSize = True
        Me.Label78.Location = New System.Drawing.Point(360, 154)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(101, 23)
        Me.Label78.TabIndex = 45
        Me.Label78.Text = "تصویر قبل از بازدید"
        '
        'Label79
        '
        Me.Label79.AutoSize = True
        Me.Label79.Location = New System.Drawing.Point(360, 10)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(68, 23)
        Me.Label79.TabIndex = 40
        Me.Label79.Text = "جوابیه ناحیه"
        '
        'Label80
        '
        Me.Label80.AutoSize = True
        Me.Label80.Location = New System.Drawing.Point(891, 259)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(66, 23)
        Me.Label80.TabIndex = 44
        Me.Label80.Text = "وضعیت پیام"
        '
        'Label81
        '
        Me.Label81.AutoSize = True
        Me.Label81.Location = New System.Drawing.Point(891, 223)
        Me.Label81.Name = "Label81"
        Me.Label81.Size = New System.Drawing.Size(60, 23)
        Me.Label81.TabIndex = 43
        Me.Label81.Text = "آدرس پیام"
        '
        'Label82
        '
        Me.Label82.AutoSize = True
        Me.Label82.Location = New System.Drawing.Point(891, 187)
        Me.Label82.Name = "Label82"
        Me.Label82.Size = New System.Drawing.Size(63, 23)
        Me.Label82.TabIndex = 42
        Me.Label82.Text = "خلاصه پیام"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("B Nazanin", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.Location = New System.Drawing.Point(891, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 24)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "کد پیام"
        '
        'Label83
        '
        Me.Label83.AutoSize = True
        Me.Label83.Location = New System.Drawing.Point(891, 151)
        Me.Label83.Name = "Label83"
        Me.Label83.Size = New System.Drawing.Size(64, 23)
        Me.Label83.TabIndex = 41
        Me.Label83.Text = "موضوع پیام"
        '
        'Label84
        '
        Me.Label84.AutoSize = True
        Me.Label84.Location = New System.Drawing.Point(891, 115)
        Me.Label84.Name = "Label84"
        Me.Label84.Size = New System.Drawing.Size(34, 23)
        Me.Label84.TabIndex = 46
        Me.Label84.Text = "حوزه"
        '
        'frm_Before
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(984, 661)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.txt_Report_Create_Date_Year)
        Me.Controls.Add(Me.txt_Report_Create_Date_Month)
        Me.Controls.Add(Me.txt_Report_Create_Date_Day)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Dgv_Data)
        Me.Controls.Add(Me.txt_Visitor_Name)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_Letter_No)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_Return)
        Me.Controls.Add(Me.btn_Save_Report)
        Me.Controls.Add(Me.btn_Pic_Load)
        Me.Controls.Add(Me.btn_Report_New)
        Me.Controls.Add(Me.btn_Print_Report)
        Me.Controls.Add(Me.btn_Excel_Load)
        Me.Font = New System.Drawing.Font("B Nazanin", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_Before"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "فرم قبل از بازدید"
        CType(Me.Dgv_Data, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pic_Before, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_Excel_Load As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_Letter_No As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_Visitor_Name As TextBox
    Friend WithEvents btn_Print_Report As Button
    Friend WithEvents btn_Report_New As Button
    Friend WithEvents btn_Return As Button
    Friend WithEvents ofd_xls As OpenFileDialog
    Friend WithEvents Dgv_Data As DataGridView
    Friend WithEvents btn_Pic_Load As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_Save_Report As Button
    Friend WithEvents txt_Report_Create_Date_Day As DomainUpDown
    Friend WithEvents txt_Report_Create_Date_Month As DomainUpDown
    Friend WithEvents txt_Report_Create_Date_Year As DomainUpDown
    Friend WithEvents TabPage9 As TabPage
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txt_Answer As RichTextBox
    Friend WithEvents txt_Zone As TextBox
    Friend WithEvents txt_Region As TextBox
    Friend WithEvents txt_status As TextBox
    Friend WithEvents txt_Adres As TextBox
    Friend WithEvents txt_Summary As TextBox
    Friend WithEvents txt_Subject As TextBox
    Friend WithEvents pic_Before As PictureBox
    Friend WithEvents txt_Code As TextBox
    Friend WithEvents txt_Area As TextBox
    Friend WithEvents Label76 As Label
    Friend WithEvents Label77 As Label
    Friend WithEvents Label78 As Label
    Friend WithEvents Label79 As Label
    Friend WithEvents Label80 As Label
    Friend WithEvents Label81 As Label
    Friend WithEvents Label82 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label83 As Label
    Friend WithEvents Label84 As Label
End Class
