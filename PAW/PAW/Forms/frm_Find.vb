Imports System.Data.OleDb


Public Class frm_Find

    Dim Selected_Row As Integer

    Private Sub btn_return_Click(sender As Object, e As EventArgs) Handles btn_return.Click
        Me.Close()
    End Sub

    Sub Clear_Form()

        For Each ctrl As Control In Me.Controls
            If ctrl.GetType = GetType(TextBox) Then
                ctrl.Text = ""
            End If
        Next

        FindDayFrom.Text = "01"
        FindDayTo.Text = Temp_Day
        FindMonthFrom.Text = Temp_Month
        FindMonthTo.Text = Temp_Month
        FindYearFrom.Text = Temp_Year
        FindYearTo.Text = Temp_Year

        Selected_Row = -1

        FindText.Focus()

    End Sub

    Sub Load_Data()

        ds.Reset()
        'con = New OleDbConnection(strcon)
        con.Open()

        stroledb = "SELECT * FROM tbl_users"
        da = New OleDbDataAdapter(stroledb, con)
        da.Fill(ds, "tbl_users")

        stroledb = "Select * FROM tbl_works"
        da = New OleDbDataAdapter(stroledb, con)
        da.Fill(ds, "tbl_works")

        stroledb = "Select * FROM tbl_track"
        da = New OleDbDataAdapter(stroledb, con)
        da.Fill(ds, "tbl_track")

        con.Close()

    End Sub

    Private Sub frm_Find_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Clear_Form()
        Load_Data()

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

    Private Sub btn_find_Click(sender As Object, e As EventArgs) Handles btn_find.Click

        If FindText.Text = "" Then FindText.Text = "*"
        For Each obj In Me.Controls
            If obj.GetType().ToString.Contains("TextBox") = True Then
                If obj.text = "" Then
                    MsgBox("برخی داده ها بدرستی وارد نشده است" & vbNewLine & "دوباره سعی کنید")
                    obj.focus()
                    Exit Sub
                End If
            End If
        Next

        Dim F_date = FindYearFrom.Text & "/" & FindMonthFrom.Text & "/" & FindDayFrom.Text
        Dim L_date = FindYearTo.Text & "/" & FindMonthTo.Text & "/" & FindDayTo.Text

        ds.Reset()
        con.Open()

        If FindText.Text = "*" Then FindText.Text = ""

        stroledb = "SELECT work_id AS [شماره کار], work_title AS عنوان, work_create_date AS [تاریخ شروع کار], work_desc AS شرح, work_track_date AS [تاریخ پیگیری بعدی], work_archive AS [کار پایان یافته], work_end_date AS [تاریخ پایان کار] FROM tbl_works WHERE(work_title Like '%" & FindText.Text.ToString & "%') AND (work_create_date BETWEEN '" & F_date & "' AND '" & L_date & "') OR (work_desc LIKE '%" & FindText.Text.ToString & "%') AND (work_create_date BETWEEN '" & F_date & "' AND '" & L_date & "')"
        da = New OleDbDataAdapter(stroledb, con)
        da.Fill(ds, "tbl_works")

        dgv_Find.DataBindings.Clear()
        dgv_Find.DataBindings.Add(New Binding("datasource", ds, "tbl_works"))

        If FindText.Text = "" Then FindText.Text = "*"

        If dgv_Find.RowCount = 0 Then Exit Sub

        For i = 0 To dgv_Find.RowCount - 1
            If dgv_Find.Item(4, i).Value = "" Then dgv_Find.Item(4, i).Value = "-"
            If dgv_Find.Item(5, i).Value = "n" Then dgv_Find.Item(5, i).Value = "خیر" Else dgv_Find.Item(5, i).Value = "بلی"
            If dgv_Find.Item(6, i).Value = "" Then dgv_Find.Item(6, i).Value = "-"
        Next

        con.Close()
        dgv_Find.ClearSelection()

    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click

        If dgv_Find.RowCount = 0 Or Selected_Row = -1 Then
            MessageBox.Show("هیچ کاری برای ویرایش انتخاب نشده است", "PAW", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Work_no = dgv_Find.Item(0, Selected_Row).Value

        Dim f2 As New frm_Edit
        f2.ShowDialog()

    End Sub

    Private Sub dgv_Find_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Find.CellClick

        If e.RowIndex <> -1 Then Selected_Row = e.RowIndex

    End Sub
End Class