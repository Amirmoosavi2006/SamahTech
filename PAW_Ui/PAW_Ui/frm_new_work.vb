Imports System.Data.OleDb

Public Class frm_new_work

    Sub Clear_Form()

        For Each ctrl As Control In Me.Controls
            If ctrl.GetType = GetType(TextBox) Then
                ctrl.Text = ""
            End If
        Next
        txt_day.Text = Temp_Day
        txt_month.Text = Temp_Month
        txt_year.Text = Temp_Year
        AttachmentsList.Items.Clear()
        PeopleList.Items.Clear()
        chb_track.Checked = False
        txt_title.Focus()

    End Sub

    Sub Load_Data()

        ds.Reset()
        con.Open()

        stroledb = "SELECT * FROM tbl_users"
        da = New OleDbDataAdapter(stroledb, con)
        da.Fill(ds, "tbl_users")

        For i = 0 To ds.Tables("tbl_users").Rows.Count - 1
            PeopleList.Items.Add(ds.Tables("tbl_users").Rows(i).Item(1).ToString & " " & ds.Tables("tbl_users").Rows(i).Item(2).ToString)
        Next

        stroledb = "SELECT * FROM tbl_Works"
        da = New OleDbDataAdapter(stroledb, con)
        da.Fill(ds, "tbl_Works")

        stroledb = "Select * FROM tbl_attachs"
        da = New OleDbDataAdapter(stroledb, con)
        da.Fill(ds, "tbl_attachs")

        con.Close()

    End Sub

    Private Sub frm_new_work_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        frm_main.lbl_title.Text = "برنامه ریزی کارهای اداری / تعریف کار جدید"

        Dim tooltip As New ToolTip
        With tooltip
            .SetToolTip(btn_home, "بازگشت به صفحه اصلی")
            .SetToolTip(btn_attach, "افزودن پیوست")
            .SetToolTip(btn_attach_del, "حذف پیوست")
            .SetToolTip(btn_save, "ذخیره کار جدید")
            .SetToolTip(btn_refresh, "بازسازی صفحه تعریف کار" & vbNewLine & "تمامی اطلاعات وارد شده بدون ذخیره سازی، پاک می شوند")
            .Active = True
        End With

        Clear_Form()
        Load_Data()

    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click

        '------------------checking save items
        If txt_title.Text.Trim = "" Then
            MessageBox.Show("عنوان کار جدید را وارد نمایید", "PAW", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If txt_desc.Text.Trim = "" Then txt_desc.Text = "-"

        If PeopleList.CheckedItems.Count = 0 Then
            MessageBox.Show("هیچ فردی برای این کار انتخاب نشده است", "PAW", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If txt_day.TextLength < 2 Or txt_month.TextLength < 2 Or txt_year.TextLength < 4 Then
            MessageBox.Show("تاریخ شروع کار بدرستی وارد نشده است", "PAW", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_day.Focus()
            txt_day.SelectAll()
            Exit Sub
        End If

        If chb_track.CheckState = CheckState.Checked Then
            If txt_t_day.TextLength < 2 Or txt_t_month.TextLength < 2 Or txt_t_year.TextLength < 4 Then
                MessageBox.Show("تاریخ پیگیری بدرستی وارد نشده است", "PAW", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_t_day.Focus()
                txt_t_day.SelectAll()
                Exit Sub
            End If
            If Int(txt_year.Text & txt_month.Text & txt_day.Text) > Int(txt_t_year.Text & txt_t_month.Text & txt_t_day.Text) Then
                MessageBox.Show("تاریخ پیگیری نمی تواند قبل از تاریخ شروع کار باشد", "PAW", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
        End If
        '------------------checking save items

        '------------------saving...
        stroledb = "INSERT INTO tbl_works (work_title, work_create_date, work_desc, work_track, work_track_date, work_end_date) VALUES (@work_title, @work_create_date, @work_desc, @work_track, @work_track_date, work_end_date)"

        com = New OleDbCommand(stroledb, con)
        com.Parameters.Add("@work_title", OleDbType.VarChar).Value = txt_title.Text.Trim
        com.Parameters.Add("@work_create_date", OleDbType.VarChar).Value = txt_year.Text & "/" & txt_month.Text & "/" & txt_day.Text
        com.Parameters.Add("@work_desc", OleDbType.VarChar).Value = txt_desc.Text.Trim
        If chb_track.CheckState = CheckState.Checked Then
            com.Parameters.Add("@work_track", OleDbType.VarChar).Value = "y"
            com.Parameters.Add("@work_track_date", OleDbType.VarChar).Value = txt_t_year.Text & "/" & txt_t_month.Text & "/" & txt_t_day.Text
        Else
            com.Parameters.Add("@work_track", OleDbType.VarChar).Value = "n"
            com.Parameters.Add("@work_track_date", OleDbType.VarChar).Value = "-"
        End If
        com.Parameters.Add("@work_track_date", OleDbType.VarChar).Value = "-"

        con.Open()
        com.ExecuteNonQuery()
        con.Close()
        '------------------saving...

        Call Load_Data()

        Dim work_id As String = ds.Tables("tbl_Works").Rows(ds.Tables("tbl_Works").Rows.Count - 1).Item(0).ToString 'choose a correct work id for saving attaches

        '------------------saving attaches
        If Not AttachmentsList.Items.Count = 0 Then
            For i = 0 To AttachmentsList.Items.Count - 1
                stroledb = "INSERT INTO tbl_attachs (attach_name, work_id, track_id) VALUES (@attach_name, @work_id, @track_id)"
                com = New OleDbCommand(stroledb, con)
                com.Parameters.Add("@attach_name", OleDbType.VarChar).Value = AttachmentsList.Items(i).ToString
                com.Parameters.Add("@work_id", OleDbType.VarChar).Value = work_id
                com.Parameters.Add("@track_id", OleDbType.VarChar).Value = "-"
                con.Open()
                com.ExecuteNonQuery()
                con.Close()
            Next
        End If
        '------------------saving attaches

        '------------------saving people
        For i = 0 To PeopleList.CheckedItems.Count - 1
            stroledb = "INSERT INTO tbl_people (p_name, work_id, track_id) VALUES (@p_name, @work_id, @track_id)"
            com = New OleDbCommand(stroledb, con)
            com.Parameters.Add("@p_name", OleDbType.VarChar).Value = PeopleList.CheckedItems(i).ToString
            com.Parameters.Add("@work_id", OleDbType.VarChar).Value = work_id
            com.Parameters.Add("@track_id", OleDbType.VarChar).Value = "-"
            con.Open()
            com.ExecuteNonQuery()
            con.Close()
        Next
        '------------------saving people

        Call Clear_Form()
        Call Load_Data()

    End Sub

    Private Sub txt_day_TextChanged(sender As Object, e As EventArgs) Handles txt_day.TextChanged, txt_t_day.TextChanged

        If sender.Text = "" Then Exit Sub
        If IsNumeric(sender.Text) = False Then sender.Clear() : Exit Sub
        If Int(sender.Text) < 1 Or Int(sender.Text) > 31 Then sender.Clear() : Exit Sub

    End Sub

    Private Sub txt_month_TextChanged(sender As Object, e As EventArgs) Handles txt_month.TextChanged, txt_t_month.TextChanged

        If sender.Text = "" Then Exit Sub
        If IsNumeric(sender.Text) = False Then sender.Clear() : Exit Sub
        If Int(sender.Text) < 1 Or Int(sender.Text) > 12 Then sender.Clear() : Exit Sub

    End Sub

    Private Sub txt_day_Leave(sender As Object, e As EventArgs) Handles txt_day.Leave, txt_month.Leave, txt_t_day.Leave, txt_t_month.Leave

        If sender.text = "" Then Exit Sub
        If sender.Text.Length < 2 Then sender.Text = "0" & sender.Text
        If Not txt_month.Text.Trim = "" Then
            If Int(txt_month.Text) > 6 And Int(txt_day.Text) > 30 Then txt_day.Text = "30"
        End If
        If Not txt_t_month.Text.Trim = "" Then
            If Int(txt_t_month.Text) > 6 And Int(txt_t_day.Text) > 30 Then txt_t_day.Text = "30"
        End If

    End Sub

    Private Sub txt_year_Leave(sender As Object, e As EventArgs) Handles txt_year.Leave, txt_t_year.Leave

        If sender.text = "" Then Exit Sub
        If sender.Text.Length < 4 Then
            MessageBox.Show("لطفاً سال را بصورت عدد 4 رقمی وارد نمایید", "PAW", MessageBoxButtons.OK, MessageBoxIcon.Error)
            sender.Focus()
            sender.SelectAll()
        End If

    End Sub
    Private Sub txt_year_TextChanged(sender As Object, e As EventArgs) Handles txt_year.TextChanged, txt_t_year.TextChanged

        If IsNumeric(sender.Text) = False Then sender.Clear() : Exit Sub

    End Sub
    Private Sub txt_t_year_Enter(sender As Object, e As EventArgs) Handles txt_t_year.GotFocus, txt_t_month.GotFocus, txt_t_day.GotFocus, txt_year.GotFocus, txt_month.GotFocus, txt_day.GotFocus, txt_t_year.MouseClick, txt_t_month.MouseClick, txt_t_day.MouseClick, txt_year.MouseClick, txt_month.MouseClick, txt_day.MouseClick

        sender.SelectAll()

    End Sub

    Private Sub chb_track_CheckedChanged(sender As Object, e As EventArgs) Handles chb_track.CheckedChanged

        If chb_track.CheckState = CheckState.Checked Then
            txt_t_day.Enabled = True
            txt_t_month.Enabled = True
            txt_t_year.Enabled = True
        Else
            txt_t_day.Enabled = False
            txt_t_month.Enabled = False
            txt_t_year.Enabled = False
        End If

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

    Private Sub btn_del_Click(sender As Object, e As EventArgs) Handles btn_attach_del.Click

        With AttachmentsList
            If .SelectedIndex = -1 Then Exit Sub
            IO.File.Delete(My.Application.Info.DirectoryPath & "\Attaches\" & .SelectedItem.ToString)
            .Items.RemoveAt(.SelectedIndex)
        End With

    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click

        Clear_Form()
        Load_Data()

    End Sub

    Private Sub AttachmentsList_DoubleClick(sender As Object, e As EventArgs) Handles AttachmentsList.DoubleClick

        With AttachmentsList

            If .Items.Count = 0 Then Exit Sub
            Process.Start(My.Application.Info.DirectoryPath & "\Attaches\" & AttachmentsList.SelectedItem.ToString)

        End With

    End Sub


    Private Sub btn_home_Click(sender As Object, e As EventArgs) Handles btn_home.Click

        frm_main.lbl_title.Text = "برنامه ریزی کارهای اداری / صفحه اصلی"

        For Each obj In frm_main.Panel1.Controls

            obj.enabled = True

        Next

        Me.Close()

    End Sub


End Class