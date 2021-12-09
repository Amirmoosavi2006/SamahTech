Imports System.Data.OleDb

Public Class frm_new
    Private Sub frm_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call Clear_form()
        Call Load_data()

        If Final_Check = True Then
            btn_save.Enabled = False

        End If

    End Sub
    Sub Clear_form()

        txt_wno.Clear()
        txt_wday.Text = PersianDateTime.Today.Day
        If txt_wday.TextLength < 2 Then txt_wday.Text = "0" & txt_wday.Text
        txt_wmonth.Text = PersianDateTime.Today.Month
        If txt_wmonth.TextLength < 2 Then txt_wmonth.Text = "0" & txt_wmonth.Text
        txt_wyear.Text = PersianDateTime.Today.Year
        txt_wtitle.Clear()
        txt_wdesc.Clear()
        txt_pday.Clear()
        txt_pmonth.Clear()
        txt_pyear.Clear()
        txt_ano.Clear()
        txt_aday.Clear()
        txt_amonth.Clear()
        txt_ayear.Clear()
        txt_atitle.Clear()
        txt_cno.Clear()
        txt_cday.Clear()
        txt_cmonth.Clear()
        txt_cyear.Clear()
        txt_ctitle.Clear()
        Temp_date = ""
        txt_wtitle.Focus()

    End Sub
    Sub Load_data()

        If P_bool = False Then

            ds.Reset()
            con = New OleDbConnection(strcon)
            con.Open()

            stroledb = "SELECT * FROM tbl_work ORDER BY work_no"
            da = New OleDbDataAdapter(stroledb, con)
            da.Fill(ds, "tbl_work")

            con.Close()

            If ds.Tables("tbl_work").Rows.Count = 0 Then
                txt_wno.Text = "1000"
                Exit Sub
            End If

            txt_wno.Text = Int(ds.Tables("tbl_work").Rows((ds.Tables("tbl_work").Rows.Count) - 1).Item("work_no")) + 1

        Else

            ds.Reset()
            con = New OleDbConnection(strcon)
            con.Open()

            stroledb = "SELECT * FROM tbl_work WHERE (work_no = " & Temp_Work_no & ")"
            da = New OleDbDataAdapter(stroledb, con)
            da.Fill(ds, "tbl_work")

            con.Close()

            txt_wno.Text = ds.Tables("tbl_work").Rows(0).Item("work_no")
            txt_wtitle.Text = ds.Tables("tbl_work").Rows(0).Item("work_title")
            txt_wyear.Text = Mid(ds.Tables("tbl_work").Rows(0).Item("work_date"), 1, 4)
            txt_wmonth.Text = Mid(ds.Tables("tbl_work").Rows(0).Item("work_date"), 6, 2)
            txt_wday.Text = Mid(ds.Tables("tbl_work").Rows(0).Item("work_date"), 9, 2)
            txt_pyear.Text = Mid(ds.Tables("tbl_work").Rows(0).Item("p_date"), 1, 4)
            txt_pmonth.Text = Mid(ds.Tables("tbl_work").Rows(0).Item("p_date"), 6, 2)
            txt_pday.Text = Mid(ds.Tables("tbl_work").Rows(0).Item("p_date"), 9, 2)
            txt_wdesc.Text = ds.Tables("tbl_work").Rows(0).Item("work_desc")
            txt_ano.Text = ds.Tables("tbl_work").Rows(0).Item("auto_no")
            txt_atitle.Text = ds.Tables("tbl_work").Rows(0).Item("auto_title")
            txt_ayear.Text = Mid(ds.Tables("tbl_work").Rows(0).Item("auto_date"), 1, 4)
            txt_amonth.Text = Mid(ds.Tables("tbl_work").Rows(0).Item("auto_date"), 6, 2)
            txt_aday.Text = Mid(ds.Tables("tbl_work").Rows(0).Item("auto_date"), 9, 2)
            txt_cno.Text = ds.Tables("tbl_work").Rows(0).Item("cts_no")
            txt_ctitle.Text = ds.Tables("tbl_work").Rows(0).Item("cts_title")
            txt_cyear.Text = Mid(ds.Tables("tbl_work").Rows(0).Item("cts_date"), 1, 4)
            txt_cmonth.Text = Mid(ds.Tables("tbl_work").Rows(0).Item("cts_date"), 6, 2)
            txt_cday.Text = Mid(ds.Tables("tbl_work").Rows(0).Item("cts_date"), 9, 2)

        End If
    End Sub
    Private Sub btn_return_Click(sender As Object, e As EventArgs) Handles btn_return.Click

        frm_main.Show()
        Me.Close()

    End Sub


    Private Sub txt_wday_Leave(sender As Object, e As EventArgs) Handles txt_wday.Leave, txt_aday.Leave, txt_cday.Leave, txt_pday.Leave

        On Error Resume Next
        If sender.text = "" Then Exit Sub
        If Int(sender.text) < 1 Or Int(sender.text) > 31 Then sender.text = "" : sender.focus() : Exit Sub
        If sender.text.Length < 2 Then sender.text = "0" & sender.text

    End Sub

    Private Sub txt_wmonth_Leave(sender As Object, e As EventArgs) Handles txt_wmonth.Leave, txt_amonth.Leave, txt_cmonth.Leave, txt_pmonth.Leave

        On Error Resume Next
        If sender.text = "" Then Exit Sub
        If Int(sender.text) < 1 Or Int(sender.text) > 12 Then sender.text = "" : sender.focus() : Exit Sub
        If sender.text.Length < 2 Then sender.text = "0" & sender.text

    End Sub

    Private Sub txt_wyear_Leave(sender As Object, e As EventArgs) Handles txt_wyear.Leave, txt_ayear.Leave, txt_cyear.Leave, txt_pyear.Leave

        If sender.text = "" Then Exit Sub
        If sender.text.Length < 4 Then sender.text = "" : sender.focus()

    End Sub

    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click

        Call Clear_form()
        Call Load_data()

    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click

        If txt_wtitle.Text = "" Then MsgBox("عنوان کار نمی تواند خالی باشد") : txt_wtitle.Focus() : Exit Sub
        If txt_wday.Text = "" Or txt_wmonth.Text = "" Or txt_wyear.Text = "" Then MsgBox("تاریخ ثبت ایراد دارد") : txt_wday.Focus() : Exit Sub
        If txt_pday.Text = "" Or txt_pmonth.Text = "" Or txt_pyear.Text = "" Then MsgBox("تاریخ پیگیری ایراد دارد") : txt_pday.Focus() : Exit Sub

        If P_bool = False Then 'Insert new work

            stroledb = "INSERT INTO tbl_work (work_no, work_title, work_desc, work_date, auto_no, auto_title, auto_date, cts_no, cts_title, cts_date, p_date) VALUES (@work_no, @work_title, @work_desc, @work_date, @auto_no, @auto_title, @auto_date, @cts_no, @cts_title, @cts_date, @p_date)"

            com = New OleDbCommand(stroledb, con)
            com.Parameters.Add("@work_no", OleDbType.VarChar).Value = txt_wno.Text.Trim
            com.Parameters.Add("@work_title", OleDbType.VarChar).Value = txt_wtitle.Text.Trim
            com.Parameters.Add("@work_desc", OleDbType.VarChar).Value = txt_wdesc.Text
            Temp_date = txt_wyear.Text & "/" & txt_wmonth.Text & "/" & txt_wday.Text
            com.Parameters.Add("@work_date", OleDbType.VarChar).Value = Temp_date
            com.Parameters.Add("@auto_no", OleDbType.VarChar).Value = txt_ano.Text.Trim
            com.Parameters.Add("@auto_title", OleDbType.VarChar).Value = txt_atitle.Text.Trim
            Temp_date = txt_ayear.Text & "/" & txt_amonth.Text & "/" & txt_aday.Text
            If Len(Temp_date) < 10 Then Temp_date = ""
            com.Parameters.Add("@auto_date", OleDbType.VarChar).Value = Temp_date
            com.Parameters.Add("@cts_no", OleDbType.VarChar).Value = txt_cno.Text.Trim
            com.Parameters.Add("@cts_title", OleDbType.VarChar).Value = txt_ctitle.Text.Trim
            Temp_date = txt_cyear.Text & "/" & txt_cmonth.Text & "/" & txt_cday.Text
            If Len(Temp_date) < 10 Then Temp_date = ""
            com.Parameters.Add("@cts_date", OleDbType.VarChar).Value = Temp_date
            Temp_date = txt_pyear.Text & "/" & txt_pmonth.Text & "/" & txt_pday.Text
            com.Parameters.Add("@p_date", OleDbType.VarChar).Value = Temp_date

            con.Open()
            com.ExecuteNonQuery()
            con.Close()

            MsgBox("کار جدید شما با شماره " & txt_wno.Text & " ثبت گردید")

            Call Clear_form()
            Call Load_data()

        Else 'Update selected work

            stroledb = "UPDATE tbl_work SET work_title =@work_title, work_desc =@work_desc, work_date =@work_date, auto_no =@auto_no, auto_title =@auto_title, auto_date =@auto_date, cts_no =@cts_no, cts_title =@cts_title, cts_date =@cts_date, p_date =@p_date WHERE (tbl_work.work_no = " & txt_wno.Text & ")"

            com = New OleDbCommand(stroledb, con)
            com.Parameters.Add("@work_title", OleDbType.VarChar).Value = txt_wtitle.Text.Trim
            com.Parameters.Add("@work_desc", OleDbType.VarChar).Value = txt_wdesc.Text
            Temp_date = txt_wyear.Text & "/" & txt_wmonth.Text & "/" & txt_wday.Text
            com.Parameters.Add("@work_date", OleDbType.VarChar).Value = Temp_date
            com.Parameters.Add("@auto_no", OleDbType.VarChar).Value = txt_ano.Text.Trim
            com.Parameters.Add("@auto_title", OleDbType.VarChar).Value = txt_atitle.Text.Trim
            Temp_date = txt_ayear.Text & "/" & txt_amonth.Text & "/" & txt_aday.Text
            If Len(Temp_date) < 10 Then Temp_date = ""
            com.Parameters.Add("@auto_date", OleDbType.VarChar).Value = Temp_date
            com.Parameters.Add("@cts_no", OleDbType.VarChar).Value = txt_cno.Text.Trim
            com.Parameters.Add("@cts_title", OleDbType.VarChar).Value = txt_ctitle.Text.Trim
            Temp_date = txt_cyear.Text & "/" & txt_cmonth.Text & "/" & txt_cday.Text
            If Len(Temp_date) < 10 Then Temp_date = ""
            com.Parameters.Add("@cts_date", OleDbType.VarChar).Value = Temp_date
            Temp_date = txt_pyear.Text & "/" & txt_pmonth.Text & "/" & txt_pday.Text
            com.Parameters.Add("@p_date", OleDbType.VarChar).Value = Temp_date

            con.Open()
            com.ExecuteNonQuery()
            con.Close()

            MsgBox("کار شماره " & txt_wno.Text & " ویرایش گردید")

            Call Load_data()

        End If

    End Sub

    Private Sub btn_p_Click(sender As Object, e As EventArgs) Handles btn_p.Click

        If txt_wtitle.Text.Trim = "" Then MsgBox("امکان ثبت پیگیری وجود ندارد") : txt_wtitle.Focus() : Exit Sub

        Dim boool As Boolean = False

        For i = 0 To ds.Tables("tbl_work").Rows.Count - 1
            If ds.Tables("tbl_work").Rows(i).Item("work_no") = txt_wno.Text Then boool = True : Exit For
        Next

        If boool = False Then
            MsgBox("این کار هنوز دخیره نشده است" & vbNewLine & "برای ثبت پیگیری ابتدا کار خود را ذخیره نمایید")
            Exit Sub
        End If

        Temp_Work_no = txt_wno.Text
        Temp_Work_title = txt_wtitle.Text
        frm_p.Show()
        Me.Close()

    End Sub

    Private Sub btn_final_Click(sender As Object, e As EventArgs) Handles btn_final.Click

        Dim boool As Boolean = False

        For i = 0 To ds.Tables("tbl_work").Rows.Count - 1
            If ds.Tables("tbl_work").Rows(i).Item("work_no") = txt_wno.Text Then boool = True : Exit For
        Next

        If boool = False Then
            MsgBox("این کار هنوز دخیره نشده است" & vbNewLine & "برای ثبت نتیجه نهایی، ابتدا کار خود را ذخیره نمایید")
            Exit Sub
        End If

        Temp_Work_no = txt_wno.Text
        frm_final.Show()
        Me.Close()

    End Sub
End Class