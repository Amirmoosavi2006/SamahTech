Imports System.Data.OleDb
Imports Microsoft.Office.Interop.Excel

Public Class frm_Reports

    Sub Clear_Form()

        PeopleList.Items.Clear()

        FindDayFrom.Text = "01"
        FindDayTo.Text = Temp_Day
        FindMonthFrom.Text = Temp_Month
        FindMonthTo.Text = Temp_Month
        FindYearFrom.Text = Temp_Year
        FindYearTo.Text = Temp_Year

    End Sub
    Sub Load_Data()

        ds.Reset()
        'con = New OleDbConnection(strcon)
        con.Open()

        stroledb = "SELECT * FROM tbl_users"
        da = New OleDbDataAdapter(stroledb, con)
        da.Fill(ds, "tbl_users")

        For i = 0 To ds.Tables("tbl_users").Rows.Count - 1
            PeopleList.Items.Add(ds.Tables("tbl_users").Rows(i).Item(1).ToString & " " & ds.Tables("tbl_users").Rows(i).Item(2).ToString)
        Next

        con.Close()

    End Sub
    Private Sub frm_Reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Clear_Form()
        Load_Data()

    End Sub

    Private Sub btn_find_Click(sender As Object, e As EventArgs) Handles btn_find.Click

        For Each obj In Me.Controls
            If obj.GetType().ToString.Contains("TextBox") = True Then
                If obj.text = "" Then
                    MsgBox("خطا در بازه زمانی انتخاب شده" & vbNewLine & "دوباره سعی کنید")
                    obj.focus()
                    Exit Sub
                End If
            End If
        Next
        If PeopleList.SelectedIndex = -1 Or PeopleList.Text = "" Then Exit Sub

        ds.Reset()
        'con = New OleDbConnection(strcon)
        con.Open()

        stroledb = "SELECT work_id FROM tbl_people WHERE (p_name = '" & PeopleList.Text & "')"
        da = New OleDbDataAdapter(stroledb, con)
        da.Fill(ds, "tbl_people")

        If ds.Tables("tbl_people").Rows.Count = 0 Then Exit Sub

        stroledb = "SELECT work_id AS [شماره کار], work_title AS [عنوان کار], work_create_date AS [تاریخ شروع], work_desc AS شرح, work_track_date AS [تاریخ پیگیری بعدی], work_end_date AS [تاریخ پایان کار] FROM tbl_works"
        da = New OleDbDataAdapter(stroledb, con)
        da.Fill(ds, "tbl_works")

        dgv_Find.DataBindings.Clear()
        dgv_Find.DataBindings.Add(New Binding("datasource", ds, "tbl_works"))

        Dim Equal_Check As Boolean = False

        For i = dgv_Find.RowCount - 1 To 0 Step -1
            For j = 0 To ds.Tables("tbl_people").Rows.Count - 1
                If dgv_Find.Item(0, i).Value = ds.Tables("tbl_people").Rows(j).Item("work_id") Then
                    Equal_Check = True
                End If
            Next
            If Equal_Check = False Then
                dgv_Find.Rows.RemoveAt(i)
            End If
            Equal_Check = False
        Next

        con.Close()

    End Sub

    Private Sub FindDayFrom_TextChanged(sender As Object, e As EventArgs) Handles FindDayFrom.TextChanged, FindDayTo.TextChanged

        If sender.Text = "" Then Exit Sub
        If IsNumeric(sender.Text) = False Then sender.Clear() : Exit Sub
        If Int(sender.Text) < 1 Or Int(sender.Text) > 31 Then sender.Clear() : Exit Sub
        If Int(Temp_Month) > 6 And Int(sender.Text) > 30 Then sender.Text = "30"

    End Sub

    Private Sub FindMonthFrom_TextChanged(sender As Object, e As EventArgs) Handles FindMonthFrom.TextChanged, FindMonthTo.TextChanged

        If sender.Text = "" Then Exit Sub
        If IsNumeric(sender.Text) = False Then sender.Clear() : Exit Sub
        If Int(sender.Text) < 1 Or Int(sender.Text) > 12 Then sender.Clear() : Exit Sub

    End Sub

    Private Sub FindYearFrom_TextChanged(sender As Object, e As EventArgs) Handles FindYearFrom.TextChanged, FindYearTo.TextChanged

        If IsNumeric(sender.Text) = False Then sender.Clear() : Exit Sub

    End Sub

    Private Sub FindDayTo_Leave(sender As Object, e As EventArgs) Handles FindDayTo.Leave, FindDayFrom.Leave, FindMonthFrom.Leave, FindMonthTo.Leave

        If sender.text = "" Then Exit Sub
        If sender.Text.Length < 2 Then sender.Text = "0" & sender.Text

    End Sub

    Private Sub FindYearTo_Leave(sender As Object, e As EventArgs) Handles FindYearTo.Leave

        If sender.text = "" Then Exit Sub
        If sender.Text.Length < 4 Then
            MessageBox.Show("لطفاً سال را بصورت عدد 4 رقمی وارد نمایید", "PAW", MessageBoxButtons.OK, MessageBoxIcon.Error)
            sender.Focus()
            sender.SelectAll()
        End If

    End Sub

    Private Sub FindDayTo_GotFocus(sender As Object, e As EventArgs) Handles FindDayTo.GotFocus, FindDayFrom.GotFocus, FindMonthFrom.GotFocus, FindMonthTo.GotFocus, FindYearFrom.GotFocus, FindYearTo.GotFocus

        sender.SelectAll()

    End Sub

    Private Sub btn_return_Click(sender As Object, e As EventArgs) Handles btn_return.Click
        Me.Close()
    End Sub

    Private Sub FindInHand_Click(sender As Object, e As EventArgs) Handles FindInHand.Click

        For Each obj In Me.Controls
            If obj.GetType().ToString.Contains("TextBox") = True Then
                If obj.text = "" Then
                    MsgBox("خطا در بازه زمانی انتخاب شده" & vbNewLine & "دوباره سعی کنید")
                    obj.focus()
                    Exit Sub
                End If
            End If
        Next

        ds.Reset()
        'con = New OleDbConnection(strcon)
        con.Open()

        Dim F_date = FindYearFrom.Text & "/" & FindMonthFrom.Text & "/" & FindDayFrom.Text
        Dim L_date = FindYearTo.Text & "/" & FindMonthTo.Text & "/" & FindDayTo.Text

        stroledb = "SELECT work_id AS [شماره کار], work_title AS [عنوان کار], work_create_date AS [تاریخ شروع], work_desc AS شرح, work_track_date AS [تاریخ پیگیری بعدی], work_end_date AS [تاریخ پایان کار] FROM tbl_works WHERE (work_archive = 'n') AND (work_create_date BETWEEN '" & F_date & "' AND '" & L_date & "')"
        da = New OleDbDataAdapter(stroledb, con)
        da.Fill(ds, "tbl_works")

        dgv_Find.DataBindings.Clear()
        dgv_Find.DataBindings.Add(New Binding("datasource", ds, "tbl_works"))

        con.Close()

    End Sub

    Private Sub FindEnd_Click(sender As Object, e As EventArgs) Handles FindEnd.Click

        For Each obj In Me.Controls
            If obj.GetType().ToString.Contains("TextBox") = True Then
                If obj.text = "" Then
                    MsgBox("خطا در بازه زمانی انتخاب شده" & vbNewLine & "دوباره سعی کنید")
                    obj.focus()
                    Exit Sub
                End If
            End If
        Next

        ds.Reset()
        'con = New OleDbConnection(strcon)
        con.Open()

        Dim F_date = FindYearFrom.Text & "/" & FindMonthFrom.Text & "/" & FindDayFrom.Text
        Dim L_date = FindYearTo.Text & "/" & FindMonthTo.Text & "/" & FindDayTo.Text

        stroledb = "SELECT work_id AS [شماره کار], work_title AS [عنوان کار], work_create_date AS [تاریخ شروع], work_desc AS شرح, work_track_date AS [تاریخ پیگیری بعدی], work_end_date AS [تاریخ پایان کار] FROM tbl_works WHERE (work_archive = 'y') AND (work_create_date BETWEEN '" & F_date & "' AND '" & L_date & "')"
        da = New OleDbDataAdapter(stroledb, con)
        da.Fill(ds, "tbl_works")

        dgv_Find.DataBindings.Clear()
        dgv_Find.DataBindings.Add(New Binding("datasource", ds, "tbl_works"))

        con.Close()

    End Sub

    Private Sub FindTodo_Click(sender As Object, e As EventArgs) Handles FindTodo.Click

        For Each obj In Me.Controls
            If obj.GetType().ToString.Contains("TextBox") = True Then
                If obj.text = "" Then
                    MsgBox("خطا در بازه زمانی انتخاب شده" & vbNewLine & "دوباره سعی کنید")
                    obj.focus()
                    Exit Sub
                End If
            End If
        Next

        ds.Reset()
        'con = New OleDbConnection(strcon)
        con.Open()

        Dim F_date = FindYearFrom.Text & "/" & FindMonthFrom.Text & "/" & FindDayFrom.Text
        Dim L_date = FindYearTo.Text & "/" & FindMonthTo.Text & "/" & FindDayTo.Text

        stroledb = "SELECT work_id AS [شماره کار], work_title AS [عنوان کار], work_create_date AS [تاریخ شروع], work_desc AS شرح, work_track_date AS [تاریخ پیگیری بعدی], work_end_date AS [تاریخ پایان کار] FROM tbl_works WHERE (work_archive = 'n') AND (work_track_date <> '') AND (work_track_date <= '" & Current_Date & "') AND (work_create_date BETWEEN '" & F_date & "' AND '" & L_date & "')"
        da = New OleDbDataAdapter(stroledb, con)
        da.Fill(ds, "tbl_works")

        dgv_Find.DataBindings.Clear()
        dgv_Find.DataBindings.Add(New Binding("datasource", ds, "tbl_works"))

        con.Close()

    End Sub

    Private Sub FindTrack_Click(sender As Object, e As EventArgs) Handles FindTrack.Click
        '
        For Each obj In Me.Controls
            If obj.GetType().ToString.Contains("TextBox") = True Then
                If obj.text = "" Then
                    MsgBox("خطا در بازه زمانی انتخاب شده" & vbNewLine & "دوباره سعی کنید")
                    obj.focus()
                    Exit Sub
                End If
            End If
        Next

        ds.Reset()
        'con = New OleDbConnection(strcon)
        con.Open()

        Dim F_date = FindYearFrom.Text & "/" & FindMonthFrom.Text & "/" & FindDayFrom.Text
        Dim L_date = FindYearTo.Text & "/" & FindMonthTo.Text & "/" & FindDayTo.Text

        stroledb = "SELECT tbl_works.work_title AS [عنوان کار], tbl_track.track_desc AS [شرح پیگیری], tbl_track.track_date AS [تاریخ پیگیری] FROM (tbl_track INNER JOIN tbl_works ON tbl_track.work_id LIKE tbl_works.work_id) WHERE (tbl_works.work_create_date BETWEEN '" & F_date & "' AND '" & L_date & "')"
        da = New OleDbDataAdapter(stroledb, con)
        da.Fill(ds, "tbl_track")

        dgv_Find.DataBindings.Clear()
        dgv_Find.DataBindings.Add(New Binding("datasource", ds, "tbl_track"))

        con.Close()

    End Sub

    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click

        Dim app As New Application
        Dim work_book As Workbook
        Dim work_sheet As Worksheet

        work_book = app.Workbooks.Add()
        work_sheet = app.Sheets("sheet1")

        For i = 0 To dgv_Find.ColumnCount - 1
            work_sheet.Cells(1, i + 1) = dgv_Find.Columns(i).Name.ToString
            For j = 0 To dgv_Find.RowCount - 1
                work_sheet.Cells(j + 2, i + 1) = dgv_Find.Item(i, j).Value.ToString
            Next
        Next

        work_sheet.Cells.HorizontalAlignment = XlPhoneticAlignment.xlPhoneticAlignCenter
        work_sheet.Cells.VerticalAlignment = XlPhoneticAlignment.xlPhoneticAlignCenter
        work_sheet.Cells.EntireColumn.AutoFit()
        app.WindowState = XlWindowState.xlMaximized
        app.Visible = True

    End Sub


End Class