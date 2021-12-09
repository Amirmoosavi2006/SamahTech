Imports System.Data.OleDb

Public Class frm_edit

    Dim Temp_Track_id As New ListBox 'save track ids for edit form
    Dim Temp_People_List As New ListBox 'save people ids for edit form

    Sub Clear_Form()

        For Each obj As Control In Me.Controls

            If obj.GetType = GetType(TextBox) Then
                obj.Text = ""
            End If

        Next

        AttachmentsList.Items.Clear()
        PeopleList.Items.Clear()
        TrackList.Items.Clear()

        chb_end.Checked = False
        chb_track.Checked = False

        ActiveControl = txt_title

    End Sub
    Sub Load_Data()

        ds.Reset()
        con.Open()

        stroledb = "SELECT * FROM tbl_works WHERE (work_id = " & Work_no & ")"
        da = New OleDbDataAdapter(stroledb, con)
        da.Fill(ds, "tbl_Works")

        txt_title.Text = ds.Tables("tbl_Works").Rows(0).Item("work_title")
        txt_desc.Text = ds.Tables("tbl_Works").Rows(0).Item("work_desc")

        With ds.Tables("tbl_Works").Rows(0).Item("work_create_date").ToString
            txt_day.Text = .Chars(8) & .Chars(9)
            txt_month.Text = .Chars(5) & .Chars(6)
            txt_year.Text = .Chars(0) & .Chars(1) & .Chars(2) & .Chars(3)
        End With

        If ds.Tables("tbl_Works").Rows(0).Item("work_track") = "y" Then
            chb_track.Checked = True
            With ds.Tables("tbl_Works").Rows(0).Item("work_track_date").ToString
                txt_t_day.Text = .Chars(8) & .Chars(9)
                txt_t_month.Text = .Chars(5) & .Chars(6)
                txt_t_year.Text = .Chars(0) & .Chars(1) & .Chars(2) & .Chars(3)
            End With
        End If

        If Not ds.Tables("tbl_Works").Rows(0).Item("work_end_date").ToString = "-" Then
            chb_end.Checked = True
            With ds.Tables("tbl_Works").Rows(0).Item("work_end_date").ToString
                txt_end_day.Text = .Chars(8) & .Chars(9)
                txt_end_month.Text = .Chars(5) & .Chars(6)
                txt_end_year.Text = .Chars(0) & .Chars(1) & .Chars(2) & .Chars(3)
            End With
        End If

        stroledb = "SELECT * FROM tbl_track WHERE (work_id = '" & Work_no & "')"
        da = New OleDbDataAdapter(stroledb, con)
        da.Fill(ds, "tbl_track")

        If Not ds.Tables("tbl_track").Rows.Count = 0 Then

            For i = 0 To ds.Tables("tbl_track").Rows.Count - 1
                TrackList.Items.Add(ds.Tables("tbl_track").Rows(i).Item("track_desc"))
                Temp_Track_id.Items.Add(ds.Tables("tbl_track").Rows(i).Item("track_id").ToString)
            Next

        End If

        stroledb = "SELECT * FROM tbl_attachs WHERE (work_id = '" & Work_no & "')"
        da = New OleDbDataAdapter(stroledb, con)
        da.Fill(ds, "tbl_attachs")

        If Not ds.Tables("tbl_attachs").Rows.Count = 0 Then

            For i = 0 To ds.Tables("tbl_attachs").Rows.Count - 1
                AttachmentsList.Items.Add(ds.Tables("tbl_attachs").Rows(i).Item("attach_name"))
            Next

        End If

        stroledb = "SELECT * FROM tbl_users"
        da = New OleDbDataAdapter(stroledb, con)
        da.Fill(ds, "tbl_users")

        For i = 0 To ds.Tables("tbl_users").Rows.Count - 1
            PeopleList.Items.Add(ds.Tables("tbl_users").Rows(i).Item(1).ToString & " " & ds.Tables("tbl_users").Rows(i).Item(2).ToString)
        Next

        stroledb = "SELECT * FROM tbl_people WHERE (work_id = '" & Work_no & "')"
        da = New OleDbDataAdapter(stroledb, con)
        da.Fill(ds, "tbl_people")

        If Not PeopleList.Items.Count = 0 Then

            For i = 0 To ds.Tables("tbl_people").Rows.Count - 1
                For j = 0 To PeopleList.Items.Count - 1
                    If PeopleList.Items(j).ToString = ds.Tables("tbl_people").Rows(i).Item("p_name").ToString Then
                        PeopleList.SetItemChecked(j, True)
                        Temp_People_List.Items.Add(ds.Tables("tbl_people").Rows(i).Item("p_name").ToString)
                    End If
                Next
            Next

        End If

        con.Close()

    End Sub

    Private Sub frm_edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Clear_Form()
        Load_Data()

    End Sub

    Private Sub btn_home_Click(sender As Object, e As EventArgs) Handles btn_home.Click

        frm_main.lbl_title.Text = "برنامه ریزی کارهای اداری / جستجو"

        frm_main.Panel_main.Visible = True
        frm_main.panel_edit.Visible = False

        Me.Close()

    End Sub

    Private Sub chb_track_CheckedChanged(sender As Object, e As EventArgs) Handles chb_track.CheckedChanged

        If chb_track.Checked = True Then
            txt_t_day.Enabled = True
            txt_t_month.Enabled = True
            txt_t_year.Enabled = True
        Else
            txt_t_day.Enabled = False
            txt_t_month.Enabled = False
            txt_t_year.Enabled = False
        End If

    End Sub

    Private Sub chb_end_CheckedChanged(sender As Object, e As EventArgs) Handles chb_end.CheckedChanged

        If chb_end.Checked = True Then
            txt_end_day.Enabled = True
            txt_end_month.Enabled = True
            txt_end_year.Enabled = True
        Else
            txt_end_day.Enabled = False
            txt_end_month.Enabled = False
            txt_end_year.Enabled = False
        End If

    End Sub

    Private Sub txt_day_TextChanged(sender As Object, e As EventArgs) Handles txt_day.TextChanged, txt_t_day.TextChanged, txt_end_day.TextChanged

        If sender.Text = "" Then Exit Sub
        If IsNumeric(sender.Text) = False Then sender.Clear() : Exit Sub
        If Int(sender.Text) < 1 Or Int(sender.Text) > 31 Then sender.Clear() : Exit Sub

    End Sub

    Private Sub txt_month_TextChanged(sender As Object, e As EventArgs) Handles txt_month.TextChanged, txt_t_month.TextChanged, txt_end_month.TextChanged

        If sender.Text = "" Then Exit Sub
        If IsNumeric(sender.Text) = False Then sender.Clear() : Exit Sub
        If Int(sender.Text) < 1 Or Int(sender.Text) > 12 Then sender.Clear() : Exit Sub

    End Sub

    Private Sub txt_day_Leave(sender As Object, e As EventArgs) Handles txt_day.Leave, txt_month.Leave, txt_t_day.Leave, txt_t_month.Leave, txt_end_day.Leave, txt_end_month.Leave

        If sender.text = "" Then Exit Sub
        If sender.Text.Length < 2 Then sender.Text = "0" & sender.Text
        If Not txt_month.Text.Trim = "" Then
            If Int(txt_month.Text) > 6 And Int(txt_day.Text) > 30 Then txt_day.Text = "30"
        End If
        If Not txt_t_month.Text.Trim = "" Then
            If Int(txt_t_month.Text) > 6 And Int(txt_t_day.Text) > 30 Then txt_t_day.Text = "30"
        End If
        If Not txt_end_month.Text.Trim = "" Then
            If Int(txt_end_month.Text) > 6 And Int(txt_end_day.Text) > 30 Then txt_end_day.Text = "30"
        End If

    End Sub

    Private Sub txt_year_Leave(sender As Object, e As EventArgs) Handles txt_year.Leave, txt_t_year.Leave, txt_end_year.Leave

        If sender.text = "" Then Exit Sub
        If sender.Text.Length < 4 Then
            MessageBox.Show("لطفاً سال را بصورت عدد 4 رقمی وارد نمایید", "PAW", MessageBoxButtons.OK, MessageBoxIcon.Error)
            sender.Focus()
            sender.SelectAll()
        End If

    End Sub
    Private Sub txt_year_TextChanged(sender As Object, e As EventArgs) Handles txt_year.TextChanged, txt_t_year.TextChanged, txt_end_year.TextChanged

        If IsNumeric(sender.Text) = False Then sender.Clear() : Exit Sub

    End Sub
    Private Sub txt_t_year_Enter(sender As Object, e As EventArgs) Handles txt_t_year.GotFocus, txt_t_month.GotFocus, txt_t_day.GotFocus, txt_year.GotFocus, txt_month.GotFocus, txt_day.GotFocus, txt_t_year.MouseClick, txt_t_month.MouseClick, txt_t_day.MouseClick, txt_year.MouseClick, txt_month.MouseClick, txt_day.MouseClick, txt_end_day.GotFocus, txt_end_day.MouseClick, txt_end_month.GotFocus, txt_end_month.MouseClick, txt_end_year.GotFocus, txt_end_year.MouseClick

        sender.SelectAll()

    End Sub

    Private Sub btn_attach_Click(sender As Object, e As EventArgs) Handles btn_attach.Click

        Dim ofd As New OpenFileDialog With {
         .RestoreDirectory = False,
         .Multiselect = True,
         .Title = "PAW",
         .Filter = "All files (*.*)|*.*"
        }
        ofd.ShowDialog()

        If ofd.FileName = "" Then
            Exit Sub
        Else
            Dim Temp_Attach_Name As String = ""
            If IO.Directory.Exists(My.Application.Info.DirectoryPath & "\Attaches\") = False Then
                IO.Directory.CreateDirectory(My.Application.Info.DirectoryPath & "\Attaches\")
            End If
            For i = 0 To ofd.FileNames.Count - 1
                With PersianDateTime.Now
                    Temp_Attach_Name = Temp_Year & Temp_Month & Temp_Day & .Hour & .Minute & .Second & i + 1 & IO.Path.GetExtension(ofd.SafeFileNames(i).ToLower)
                End With
                If Not IO.File.Exists(My.Application.Info.DirectoryPath & "\Attaches\" & Temp_Attach_Name) Then
                    IO.File.Copy(ofd.FileNames(i), My.Application.Info.DirectoryPath & "\Attaches\" & Temp_Attach_Name)
                End If
                AttachmentsList.Items.Add(Temp_Attach_Name)
            Next
        End If

    End Sub

    Private Sub btn_attach_del_Click(sender As Object, e As EventArgs) Handles btn_attach_del.Click

        With AttachmentsList

            If .SelectedIndex = -1 Then Exit Sub

            ds.Reset()
            con.Open()
            stroledb = "SELECT * FROM tbl_attachs WHERE (attach_name = '" & .SelectedItem.ToString & "')"
            da = New OleDbDataAdapter(stroledb, con)
            da.Fill(ds, "tbl_attachs")
            con.Close()

            For i = 0 To ds.Tables("tbl_attachs").Rows.Count - 1
                If Not ds.Tables("tbl_attachs").Rows(i).Item("work_id").ToString = Work_no Then
                    Dim msg = MessageBox.Show("این پیوست برای کار دیگری نیز اننخاب شده است" & vbNewLine & "آیا میخواهید آن را بطور کلی حذف نمایید؟" & vbNewLine & "بله: حذف از تمامی کارها" & vbNewLine & "خیر: حذف فقط از کار جاری", "PAW", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign)
                    If msg = DialogResult.Yes Then

                        stroledb = "DELETE FROM tbl_attachs WHERE (tbl_attachs.attach_name = '" & .SelectedItem.ToString & "')"
                        com = New OleDbCommand(stroledb, con)
                        con.Open()
                        com.ExecuteNonQuery()
                        con.Close()

                        IO.File.Delete(My.Application.Info.DirectoryPath & "\Attaches\" & .SelectedItem.ToString)
                        .Items.RemoveAt(.SelectedIndex)

                        Exit Sub

                    ElseIf msg = DialogResult.No Then

                        stroledb = "DELETE FROM tbl_attachs WHERE (tbl_attachs.attach_name = '" & .SelectedItem.ToString & "') AND (tbl_attachs.work_id = '" & Work_no & "')"
                        com = New OleDbCommand(stroledb, con)
                        con.Open()
                        com.ExecuteNonQuery()
                        con.Close()

                        .Items.RemoveAt(.SelectedIndex)

                        Exit Sub

                    Else

                        Exit Sub

                    End If

                End If
            Next

            If MessageBox.Show("این عملیات غیرقابل بازگشت می باشد" & vbNewLine & "آیا برای حذف اطمینان دارید؟", "PAW", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign) = DialogResult.Yes Then

                stroledb = "DELETE FROM tbl_attachs WHERE (tbl_attachs.attach_name = '" & .SelectedItem.ToString & "')"
                com = New OleDbCommand(stroledb, con)
                con.Open()
                com.ExecuteNonQuery()
                con.Close()

                AttachmentsList.Items.RemoveAt(.SelectedIndex)

            End If

        End With

    End Sub
    Private Sub AttachmentsList_DoubleClick(sender As Object, e As EventArgs) Handles AttachmentsList.DoubleClick

        With AttachmentsList

            If .Items.Count = 0 Then Exit Sub

            If IO.Directory.Exists(My.Application.Info.DirectoryPath & "\Attaches\") = False Or IO.File.Exists(My.Application.Info.DirectoryPath & "\Attaches\" & AttachmentsList.SelectedItem.ToString) = False Then
                MessageBox.Show("فایل مورد نظر یافت نشد", "PAW", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Process.Start(My.Application.Info.DirectoryPath & "\Attaches\" & AttachmentsList.SelectedItem.ToString)

        End With

    End Sub


    Private Sub btn_track_del_Click(sender As Object, e As EventArgs) Handles btn_track_del.Click

        With TrackList
            If .SelectedIndex = -1 Then Exit Sub

            If MessageBox.Show("این عملیات غیرقابل بازگشت می باشد" & vbNewLine & "آیا برای حذف اطمینان دارید؟", "PAW", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign) = DialogResult.Yes Then

                stroledb = "DELETE FROM tbl_track WHERE (tbl_track.work_id = '" & Work_no & "') AND (track_id = " & Int(Temp_Track_id.Items(.SelectedIndex)) & ")"
                com = New OleDbCommand(stroledb, con)
                con.Open()
                com.ExecuteNonQuery()
                con.Close()

                Temp_Track_id.Items.RemoveAt(.SelectedIndex)

            End If

        End With

    End Sub

    Private Sub TrackList_DoubleClick(sender As Object, e As MouseEventArgs) Handles TrackList.DoubleClick

        With TrackList
            If .SelectedIndex = -1 Then Exit Sub
            Dim Edit_Text = InputBox("متن مورد نظر را اصلاح نمایید", "PAW", .SelectedItem.ToString)
            If Edit_Text <> "" Then
                .Items(.SelectedIndex) = Edit_Text.ToString
            End If
        End With

    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click

        For Each obj In Me.Controls
            If obj.GetType = GetType(TextBox) Then
                If (obj.maxLength = 2 And obj.TextLength < 2 And obj.enabled = True) Or (obj.maxLength = 4 And obj.TextLength < 4 And obj.enabled = True) Then
                    MessageBox.Show("خطا در ثبت تاریخ", "PAW", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End If
        Next

        If txt_title.Text.Trim = "" Then
            MessageBox.Show("عنوان را وارد نمایید", "PAW", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_title.Focus()
            Exit Sub
        End If

        If txt_desc.Text.Trim = "" Then txt_desc.Text = "-"

        If PeopleList.CheckedItems.Count = 0 Then
            MessageBox.Show("هیچ فردی مرتبط با این کار انتخاب نشده است", "PAW", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        '*********************Work table update***
        stroledb = "UPDATE tbl_works SET work_title =@work_title, work_create_date =@work_create_date, work_desc =@work_desc, work_track =@work_track, work_track_date =@work_track_date, work_end_date =@work_end_date WHERE (tbl_works.work_id = " & Work_no & ")"

        com = New OleDbCommand(stroledb, con)
        com.Parameters.Add("@work_title", OleDbType.VarChar).Value = txt_title.Text.Trim
        com.Parameters.Add("@work_create_date", OleDbType.VarChar).Value = txt_year.Text & "/" & txt_month.Text & "/" & txt_day.Text
        com.Parameters.Add("@work_desc", OleDbType.VarChar).Value = txt_desc.Text.Trim

        If chb_track.Checked = True Then
            com.Parameters.Add("@work_track", OleDbType.VarChar).Value = "y"
            com.Parameters.Add("@work_track_date", OleDbType.VarChar).Value = txt_t_year.Text & "/" & txt_t_month.Text & "/" & txt_t_day.Text
        Else
            com.Parameters.Add("@work_track", OleDbType.VarChar).Value = "n"
            com.Parameters.Add("@work_track_date", OleDbType.VarChar).Value = "-"
        End If

        If chb_end.Checked = True Then
            com.Parameters.Add("@work_end_date", OleDbType.VarChar).Value = txt_end_year.Text & "/" & txt_end_month.Text & "/" & txt_end_day.Text
        Else
            com.Parameters.Add("@work_end_date", OleDbType.VarChar).Value = "-"
        End If

        con.Open()
        com.ExecuteNonQuery()
        con.Close()
        '*********************Work table update***

        '*********************track table update***
        If Not TrackList.Items.Count = 0 Then
            For i = 0 To TrackList.Items.Count - 1
                stroledb = "UPDATE tbl_track SET track_desc =@track_desc WHERE (tbl_track.work_id = '" & Work_no & "') AND (track_id = " & Int(Temp_Track_id.Items(i)) & ")"
                com = New OleDbCommand(stroledb, con)
                com.Parameters.Add("@track_desc", OleDbType.VarChar).Value = TrackList.Items(i).ToString
                con.Open()
                com.ExecuteNonQuery()
                con.Close()
            Next
        End If
        '*********************track table update***

        '*********************people list update***
        stroledb = "DELETE FROM tbl_people WHERE (tbl_people.work_id = '" & Work_no & "')"
        com = New OleDbCommand(stroledb, con)
        con.Open()
        com.ExecuteNonQuery()
        con.Close()

        For i = 0 To PeopleList.CheckedItems.Count - 1
            stroledb = "INSERT INTO tbl_people (p_name, work_id, track_id) VALUES (@p_name, @work_id, @track_id)"
            com = New OleDbCommand(stroledb, con)
            com.Parameters.Add("@p_name", OleDbType.VarChar).Value = PeopleList.CheckedItems(i).ToString
            com.Parameters.Add("@work_id", OleDbType.VarChar).Value = Work_no
            com.Parameters.Add("@track_id", OleDbType.VarChar).Value = "-"
            con.Open()
            com.ExecuteNonQuery()
            con.Close()
        Next
        '*********************people list update***

        '*********************attachments update***
        With AttachmentsList
            If Not .Items.Count = 0 Then
                For i = 0 To .Items.Count - 1
                    ds.Reset()
                    stroledb = "SELECT * FROM tbl_attachs WHERE (attach_name = '" & .Items(i).ToString & "') AND (work_id = '" & Work_no & "')"
                    da = New OleDbDataAdapter(stroledb, con)
                    da.Fill(ds, "check_dub")
                    If ds.Tables("check_dub").Rows.Count = 0 Then
                        stroledb = "INSERT INTO tbl_attachs (attach_name, work_id, track_id) VALUES (@attach_name, @work_id, @track_id)"
                        com = New OleDbCommand(stroledb, con)
                        com.Parameters.Add("@attach_name", OleDbType.VarChar).Value = .Items(i).ToString
                        com.Parameters.Add("@work_id", OleDbType.VarChar).Value = Work_no
                        com.Parameters.Add("@track_id", OleDbType.VarChar).Value = "-"
                        con.Open()
                        com.ExecuteNonQuery()

                        con.Close()
                    End If
                Next
            End If
        End With
        '*********************attachments update***

        MessageBox.Show("بروزرسانی با موفقیت انجام شد", "PAW", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Clear_Form()
        Load_Data()

    End Sub

End Class