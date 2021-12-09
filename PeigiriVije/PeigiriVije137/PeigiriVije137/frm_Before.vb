Imports System.IO
Imports Microsoft.Office.Interop.Excel

Public Class frm_Before
    Private Sub btn_xls_load_Click(sender As Object, e As EventArgs) Handles btn_Excel_Load.Click

        Dim xl_adres As String
        Dim xl_app As Application = New Application
        Dim xl_workbook As Workbook

        xl_adres = ofd_xls.ShowDialog()

        If xl_adres = vbCancel Then Exit Sub

        xl_workbook = xl_app.Workbooks.Open(ofd_xls.FileName)
        Dim xl_sheet As Worksheet
        Try
            xl_sheet = xl_app.Sheets("sheet1")
        Catch ex As Exception
            xl_sheet = xl_app.Sheets(1)
        End Try

        If IsNothing(xl_sheet) Then

            MsgBox("در هنگام خواندن فایل خطایی رخ داده است" & vbNewLine & "لطفاً فایل را بررسی نموده و مجدداً بارگزاری نمایید",, "خطا")

        End If

        Dim R_Counter = 0
        Dim A_R_Z = "" 'رشته مورد استفاده برای تفکیک حوزه، منطقه و ناحیه

        If Dgv_Data.ColumnCount = 0 Then
            Dgv_Data.Columns.Add("col_Row", "ردیف")
            Dgv_Data.Columns.Add("col_Code", "کد پیام")
            Dgv_Data.Columns.Add("col_Area", "حوزه")
            Dgv_Data.Columns.Add("col_Region", "منطقه")
            Dgv_Data.Columns.Add("col_Zone", "ناحیه")
            Dgv_Data.Columns.Add("col_Subject", "موضوع پیام")
            Dgv_Data.Columns.Add("col_Summary", "خلاصه پیام")
            Dgv_Data.Columns.Add("col_Adres", "آدرس")
            Dgv_Data.Columns.Add("col_Status", "وضعیت پیام")
            Dgv_Data.Columns.Add("col_Answer", "جوابیه ناحیه")
            Dgv_Data.Columns.Add("col_Ax_Before", "تصویر قبل بازدید")
            Dgv_Data.Columns.Add("col_Sys_Check", "بررسی سیستمی")
            Dgv_Data.Columns.Add("col_Field_Check", "بررسی میدانی")
            Dgv_Data.Columns.Add("col_Ok", "تایید")
            Dgv_Data.Columns.Add("col_Nok", "عدم تایید")
        End If

        For i = 1 To xl_sheet.UsedRange.Rows.Count

            If IsNumeric(xl_sheet.Range("B" & i).Value) And (Len(xl_sheet.Range("B" & i).Value) > 9 Or Len(xl_sheet.Range("B" & i).Value) < 13) Then

                R_Counter += 1
                If Dgv_Data.RowCount < xl_sheet.UsedRange.Rows.Count Then Dgv_Data.Rows.Add()
                Dgv_Data.Item("col_Row", R_Counter - 1).Value = R_Counter
                Dgv_Data.Item("col_code", R_Counter - 1).Value = xl_sheet.Range("B" & i).Value
                Dgv_Data.Item("col_summary", R_Counter - 1).Value = xl_sheet.Range("I" & i).Value
                Dgv_Data.Item("col_subject", R_Counter - 1).Value = xl_sheet.Range("F" & i).Value
                Dgv_Data.Item("col_adres", R_Counter - 1).Value = xl_sheet.Range("H" & i).Value
                Dgv_Data.Item("col_status", R_Counter - 1).Value = xl_sheet.Range("S" & i).Value
                A_R_Z = xl_sheet.Range("J" & i).Value
                Dgv_Data.Item("col_Area", R_Counter - 1).Value = Mid(A_R_Z, A_R_Z.IndexOf("حوزه") + 1, A_R_Z.IndexOf("ناحیه"))
                Dgv_Data.Item("col_region", R_Counter - 1).Value = Mid(A_R_Z, A_R_Z.IndexOf("منطقه") + 6, 2)
                Dgv_Data.Item("col_zone", R_Counter - 1).Value = Mid(A_R_Z, A_R_Z.IndexOf("ناحیه") + 6, 2)

            ElseIf IsNumeric(xl_sheet.Range("D" & i).Value) And (Len(xl_sheet.Range("D" & i).Value) > 9 Or Len(xl_sheet.Range("D" & i).Value) < 13) Then

                R_Counter += 1
                If Dgv_Data.RowCount < xl_sheet.UsedRange.Rows.Count Then Dgv_Data.Rows.Add()
                Dgv_Data.Item("col_Row", R_Counter - 1).Value = R_Counter
                Dgv_Data.Item("col_code", R_Counter - 1).Value = xl_sheet.Range("D" & i).Value
                Dgv_Data.Item("col_summary", R_Counter - 1).Value = xl_sheet.Range("J" & i).Value
                Dgv_Data.Item("col_subject", R_Counter - 1).Value = xl_sheet.Range("G" & i).Value
                Dgv_Data.Item("col_adres", R_Counter - 1).Value = xl_sheet.Range("H" & i).Value
                Dgv_Data.Item("col_status", R_Counter - 1).Value = xl_sheet.Range("P" & i).Value
                A_R_Z = xl_sheet.Range("I" & i).Value
                Dgv_Data.Item("col_Area", R_Counter - 1).Value = Mid(A_R_Z, A_R_Z.IndexOf("حوزه") + 1, A_R_Z.IndexOf("ناحیه"))
                Dgv_Data.Item("col_region", R_Counter - 1).Value = Mid(A_R_Z, A_R_Z.IndexOf("منطقه") + 6, 2)
                Dgv_Data.Item("col_zone", R_Counter - 1).Value = Mid(A_R_Z, A_R_Z.IndexOf("ناحیه") + 6, 2)

            End If
        Next i

        If Dgv_Data.RowCount = 0 Then

            MsgBox("در هنگام خواندن فایل خطایی رخ داده است" & vbNewLine & "لطفاً فایل را بررسی نموده و مجدداً بارگزاری نمایید",, "خطا")

        End If

        Dgv_Data.AutoResizeColumns()

        xl_app.DisplayAlerts = False
        xl_app.Quit()

        releaseObject(xl_app)
        releaseObject(xl_workbook)

        ' پر کردن تب کنترل ها
        TabControl1.TabPages.Item(0).Text = Dgv_Data.Item(1, 0).Value
        For i = 1 To Dgv_Data.RowCount - 1
            If i > 10 Then MsgBox("تعداد پیام های مجاز برای هر فرم 10 عدد می باشد" & vbNewLine & "درصورت نیاز به ثبت بیش از 10 کد پیام از فرم جدید برای ردیف های 11 به بعد استفاده نمایید",, "توجه") : Exit For
            TabControl1.TabPages.Add(Dgv_Data.Item(1, i).Value)
        Next

    End Sub
    Sub releaseObject(ByVal obj As Object)

        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try

    End Sub

    Private Sub btn_return_Click(sender As Object, e As EventArgs) Handles btn_Return.Click

        Me.Close()

    End Sub

    Private Sub Dgv_Data_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_Data.CellDoubleClick

        If e.RowIndex = -1 Then Exit Sub

        If e.ColumnIndex = 9 Then
            Dim resultt = InputBox("جوابیه ناحیه مربوط به کد پیام: " & Dgv_Data.Item(1, e.RowIndex).Value.ToString & vbNewLine & " را وارد نمایید", "جوابیه ناحیه")
            If resultt <> "" Then Dgv_Data.Item(9, e.RowIndex).Value = resultt
        End If

        If e.ColumnIndex = 11 Then

            Dim resultt = InputBox("متن مربوط به بررسی سیستمی صورت گرفته را در کادر زیر وارد نمایید", "توضیحات: بررسی سیستمی")
            If resultt <> "" Then Dgv_Data.Item(11, e.RowIndex).Value = resultt

        End If

        If e.ColumnIndex = 10 Then
            ofd_xls.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG"
            ofd_xls.RestoreDirectory = True
            ofd_xls.Multiselect = False
            Dim axx = ofd_xls.ShowDialog()
            If axx = vbOK Then
                Dgv_Data.Item(10, e.RowIndex).Value = "√"
            End If
        End If

    End Sub

    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_Print_Report.Click

        If Dgv_Data.RowCount = 0 Then
            MsgBox("ردیفی برای چاپ یافت نشد",, "خطا")
            Exit Sub
        End If

        Dim xl_adres As String
        Dim xl_app As Application = New Application
        Dim xl_workbook As Workbook

        If File.Exists(My.Application.Info.DirectoryPath & "\freeForm_M.xlsx") Then
            xl_adres = My.Application.Info.DirectoryPath & "\freeForm_M.xlsx"
            xl_workbook = xl_app.Workbooks.Open(xl_adres,, vbReadOnly)
            xl_workbook.ActiveSheet.Range("C1").Value = txt_Letter_No.Text.Trim
            xl_workbook.ActiveSheet.Range("N19").Value = txt_Visitor_Name.Text.Trim
            xl_workbook.ActiveSheet.Range("C2").Value = ""
            xl_workbook.ActiveSheet.Range("C3").Value = ""
            xl_workbook.ActiveSheet.Range("O1").Value = ""
            xl_workbook.ActiveSheet.Range("O2").Value = ""
            xl_workbook.ActiveSheet.Range("O3").Value = ""
            For i = 0 To Dgv_Data.RowCount - 1
                xl_workbook.ActiveSheet.Range("A" & i + 8).Value = i + 1
                xl_workbook.ActiveSheet.Range("B" & i + 8).Value = Dgv_Data.Item("col_Code", i).Value
                xl_workbook.ActiveSheet.Range("C" & i + 8).Value = Dgv_Data.Item("col_Area", i).Value
                xl_workbook.ActiveSheet.Range("F" & i + 8).Value = Dgv_Data.Item("col_Region", i).Value
                xl_workbook.ActiveSheet.Range("G" & i + 8).Value = Dgv_Data.Item("col_Zone", i).Value
                xl_workbook.ActiveSheet.Range("H" & i + 8).Value = Dgv_Data.Item("col_Subject", i).Value
                xl_workbook.ActiveSheet.Range("I" & i + 8).Value = Dgv_Data.Item("col_Summary", i).Value
                xl_workbook.ActiveSheet.Range("J" & i + 8).Value = Dgv_Data.Item("col_Adres", i).Value
                xl_workbook.ActiveSheet.Range("K" & i + 8).Value = Dgv_Data.Item("col_Status", i).Value
                xl_workbook.ActiveSheet.Range("L" & i + 8).Value = Dgv_Data.Item("col_Answer", i).Value
                xl_workbook.ActiveSheet.Range("M" & i + 8).Value = Dgv_Data.Item("col_Sys_Check", i).Value
                xl_workbook.ActiveSheet.Range("N" & i + 8).Value = Dgv_Data.Item("col_Field_Check", i).Value
                xl_workbook.ActiveSheet.Range("O" & i + 8).Value = Dgv_Data.Item("col_Ok", i).Value
                xl_workbook.ActiveSheet.Range("P" & i + 8).Value = Dgv_Data.Item("col_Nok", i).Value
            Next
            xl_workbook.ActiveSheet.protect("aaa")
            xl_app.WindowState = XlWindowState.xlMaximized
            xl_app.Visible = True
        End If

    End Sub

    Private Sub frm_Before_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txt_Visitor_Name.Text = User_Name

        txt_Report_Create_Date_Month.Text = Mid(Temp_Date, 6, 2)
        txt_Report_Create_Date_Day.Text = Mid(Temp_Date, 9, 2)

        pic_Before.Image = My.Resources.plus
        TabControl1.SelectedTab.Text = "***"

    End Sub



    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged

        If Change_Check = True Then

            For i = 0 To Dgv_Data.Rows.Count - 1

                If Dgv_Data.Item(1, i).Value = temp_i Then

                    If Not Dgv_Data.Item(9, i).Value = txt_Answer.Text Then

                        Dgv_Data.Item(9, i).Value = txt_Answer.Text
                        Exit For

                    End If

                End If

            Next

        End If

        txt_Code.Text = TabControl1.SelectedTab.Text

        For i = 0 To Dgv_Data.Rows.Count - 1

            If Dgv_Data.Item(1, i).Value = txt_Code.Text Then

                txt_Area.Text = Dgv_Data.Item(2, i).Value
                txt_Region.Text = Dgv_Data.Item(3, i).Value
                txt_Zone.Text = Dgv_Data.Item(4, i).Value
                txt_Subject.Text = Dgv_Data.Item(5, i).Value
                txt_Summary.Text = Dgv_Data.Item(6, i).Value
                txt_Adres.Text = Dgv_Data.Item(7, i).Value
                txt_status.Text = Dgv_Data.Item(8, i).Value
                txt_Answer.Text = Dgv_Data.Item(9, i).Value
                Exit For

            End If

        Next

    End Sub

    Private Sub txt_Answer_TextChanged(sender As Object, e As EventArgs) Handles txt_Answer.TextChanged

        If Not txt_Answer.Text.Trim = "" Then
            Change_Check = True
            temp_i = TabControl1.SelectedTab.Text
        Else
            Change_Check = False
        End If

    End Sub
End Class

'Dim cn As New OLEDBConnection("Provider = Microsoft.Jet.OleDb.4.0;Data Source = " & Application.StartupPath & "\database.mdb;")
'Dim cm As New OleDbCommand

'Dim bytImage() As Byte
'Private Sub Browse_Click(sender As Object, e As EventArgs) Handles Browse.Click
'    Dim dialog As New OpenFileDialog()
'    dialog.Title = "Browse Picture"
'    dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG"
'    If dialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
'        PictureBox1.Image = Image.FromFile(dialog.FileName)
'    End If
'End Sub

'Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
'    Try
'        Dim ms As New System.IO.MemoryStream
'        Dim bmpImage As New Bitmap(PictureBox1.Image)

'        bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
'        bytImage = ms.ToArray()
'        ms.Close()
'    Catch ex As Exception
'        MsgBox(ex.Message)
'    End Try
'    cn.Open()
'    cm.Connection = cn
'    cm.CommandType = CommandType.Text
'    cm.CommandText = "INSERT INTO `table` (pic) VALUES (@image)"
'    cm.Parameters.AddWithValue("@image", bytImage)
'    cm.ExecuteNonQuery()
'    cn.Close()
'End Sub