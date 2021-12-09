Imports System.Data.OleDb

Public Class frm_NewWork
    Private Sub btn_return_Click(sender As Object, e As EventArgs) Handles btn_return.Click

        Me.Close()

    End Sub

    Private Sub frm_NewWork_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Clear_Form()
        Load_Data()

    End Sub

    Sub Clear_Form()

        For Each ctrl As Control In Me.Controls
            If ctrl.GetType = GetType(TextBox) Then
                ctrl.Text = ""
            End If
        Next
        NewWorkDay.Text = Temp_Day
        NewWorkMonth.Text = Temp_Month
        NewWorkYear.Text = Temp_Year
        AttachmentsList.Items.Clear()
        PeopleList.Items.Clear()
        TrackCHB.Checked = False
        NewWorkTitle.Focus()

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

        stroledb = "SELECT * FROM tbl_Works"
        da = New OleDbDataAdapter(stroledb, con)
        da.Fill(ds, "tbl_Works")

        stroledb = "Select * FROM tbl_attachs"
        da = New OleDbDataAdapter(stroledb, con)
        da.Fill(ds, "tbl_attachs")

        con.Close()

    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click

        '------------------checking save items
        If NewWorkTitle.Text.Trim = "" Then
            MessageBox.Show("عنوان کار نمی تواند خالی باشد", "PAW", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If NewWorkDesc.Text.Trim = "" Then NewWorkDesc.Text = "-"

        If PeopleList.CheckedItems.Count = 0 Then
            MessageBox.Show("در لیست افراد، حداقل یکنفر باید انتخاب شود", "PAW", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If NewWorkDay.TextLength < 2 Or NewWorkMonth.TextLength < 2 Or NewWorkYear.TextLength < 4 Then
            MessageBox.Show("تاریخ شروع کار بدرستی وارد نشده است", "PAW", MessageBoxButtons.OK, MessageBoxIcon.Error)
            NewWorkDay.Focus()
            NewWorkDay.SelectAll()
            Exit Sub
        End If

        If TrackCHB.CheckState = CheckState.Checked Then
            If TrackDay.TextLength < 2 Or TrackMonth.TextLength < 2 Or TrackYear.TextLength < 4 Then
                MessageBox.Show("تاریخ پیگیری بدرستی وارد نشده است", "PAW", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TrackDay.Focus()
                TrackDay.SelectAll()
                Exit Sub
            End If
            If Int(NewWorkYear.Text & NewWorkMonth.Text & NewWorkDay.Text) > Int(TrackYear.Text & TrackMonth.Text & TrackDay.Text) Then
                MessageBox.Show("تاریخ پیگیری نمی تواند قبل از تاریخ شروع کار باشد", "PAW", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
        End If
        '------------------checking save items

        '------------------saving...
        stroledb = "INSERT INTO tbl_works (work_title, work_desc, work_track, work_track_date, work_create_date, work_archive, work_end_date) VALUES (@work_title, @work_desc, @work_track, @work_track_date, @work_create_date, @work_archive, @work_end_date)"

        com = New OleDbCommand(stroledb, con)
        com.Parameters.Add("@work_title", OleDbType.VarChar).Value = NewWorkTitle.Text.Trim
        com.Parameters.Add("@work_desc", OleDbType.VarChar).Value = NewWorkDesc.Text.Trim
        If TrackCHB.CheckState = CheckState.Checked Then
            com.Parameters.Add("@work_track", OleDbType.VarChar).Value = "y"
            com.Parameters.Add("@work_track_date", OleDbType.VarChar).Value = TrackYear.Text & "/" & TrackMonth.Text & "/" & TrackDay.Text
        Else
            com.Parameters.Add("@work_track", OleDbType.VarChar).Value = "n"
            com.Parameters.Add("@work_track_date", OleDbType.VarChar).Value = ""
        End If
        com.Parameters.Add("@work_create_date", OleDbType.VarChar).Value = NewWorkYear.Text & "/" & NewWorkMonth.Text & "/" & NewWorkDay.Text
        com.Parameters.Add("@work_archive", OleDbType.VarChar).Value = "n"
        com.Parameters.Add("@work_end_date", OleDbType.VarChar).Value = ""

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

    Private Sub NewWorkDay_TextChanged(sender As Object, e As EventArgs) Handles NewWorkDay.TextChanged, TrackDay.TextChanged

        If sender.Text = "" Then Exit Sub
        If IsNumeric(sender.Text) = False Then sender.Clear() : Exit Sub
        If Int(sender.Text) < 1 Or Int(sender.Text) > 31 Then sender.Clear() : Exit Sub
        If Int(Temp_Month) > 6 And Int(sender.Text) > 30 Then sender.Text = "30"

    End Sub

    Private Sub NewWorkMonth_TextChanged(sender As Object, e As EventArgs) Handles NewWorkMonth.TextChanged, TrackMonth.TextChanged

        If sender.Text = "" Then Exit Sub
        If IsNumeric(sender.Text) = False Then sender.Clear() : Exit Sub
        If Int(sender.Text) < 1 Or Int(sender.Text) > 12 Then sender.Clear() : Exit Sub

    End Sub

    Private Sub NewWorkDay_Leave(sender As Object, e As EventArgs) Handles NewWorkDay.Leave, NewWorkMonth.Leave, TrackDay.Leave, TrackMonth.Leave

        If sender.text = "" Then Exit Sub
        If sender.Text.Length < 2 Then sender.Text = "0" & sender.Text

    End Sub

    Private Sub NewWorkYear_Leave(sender As Object, e As EventArgs) Handles NewWorkYear.Leave, TrackYear.Leave

        If sender.text = "" Then Exit Sub
        If sender.Text.Length < 4 Then
            MessageBox.Show("لطفاً سال را بصورت عدد 4 رقمی وارد نمایید", "PAW", MessageBoxButtons.OK, MessageBoxIcon.Error)
            sender.Focus()
            sender.SelectAll()
        End If

    End Sub

    Private Sub TrackCHB_CheckedChanged(sender As Object, e As EventArgs) Handles TrackCHB.CheckedChanged

        If TrackCHB.CheckState = CheckState.Checked Then
            TrackDay.Enabled = True
            TrackMonth.Enabled = True
            TrackYear.Enabled = True
        Else
            TrackDay.Enabled = False
            TrackMonth.Enabled = False
            TrackYear.Enabled = False
        End If

    End Sub

    Private Sub TrackYear_Enter(sender As Object, e As EventArgs) Handles TrackYear.GotFocus, TrackMonth.GotFocus, TrackDay.GotFocus, NewWorkYear.GotFocus, NewWorkMonth.GotFocus, NewWorkDay.GotFocus, TrackYear.MouseClick, TrackMonth.MouseClick, TrackDay.MouseClick, NewWorkYear.MouseClick, NewWorkMonth.MouseClick, NewWorkDay.MouseClick

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
            If IO.Directory.Exists(My.Application.Info.DirectoryPath & "\Attaches\") = False Then
                IO.Directory.CreateDirectory(My.Application.Info.DirectoryPath & "\Attaches\")
            End If
            For i = 0 To ofd.FileNames.Count - 1
                If Not IO.File.Exists(My.Application.Info.DirectoryPath & "\Attaches\" & ofd.SafeFileNames(i).ToString) Then
                    IO.File.Copy(ofd.FileNames(i), My.Application.Info.DirectoryPath & "\Attaches\" & ofd.SafeFileNames(i).ToString)
                End If
                AttachmentsList.Items.Add(ofd.SafeFileNames(i).ToString)
            Next
        End If

    End Sub

    Private Sub btn_del_Click(sender As Object, e As EventArgs) Handles btn_del.Click

        With AttachmentsList
            If .SelectedIndex = -1 Then Exit Sub
            IO.File.Delete(My.Application.Info.DirectoryPath & "\Attaches\" & .SelectedItem.ToString)
            .Items.RemoveAt(.SelectedIndex)
        End With

    End Sub

    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click

        Clear_Form()
        Load_Data()

    End Sub

    Private Sub AttachmentsList_DoubleClick(sender As Object, e As EventArgs) Handles AttachmentsList.DoubleClick

        With AttachmentsList

            If .Items.Count = 0 Then Exit Sub
            Process.Start(My.Application.Info.DirectoryPath & "\Attaches\" & AttachmentsList.SelectedItem.ToString)

        End With

    End Sub

    Private Sub NewWorkYear_TextChanged(sender As Object, e As EventArgs) Handles NewWorkYear.TextChanged, TrackYear.TextChanged

        If IsNumeric(sender.Text) = False Then sender.Clear() : Exit Sub

    End Sub
End Class