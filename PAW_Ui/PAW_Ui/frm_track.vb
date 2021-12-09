Imports System.Data.OleDb

Public Class frm_track

    Sub clear_form()

        txt_day.Text = Temp_Day
        txt_month.Text = Temp_Month
        txt_year.Text = Temp_Year
        txt_desc.Clear()
        txt_title.Enabled = False
        WorksList.Items.Clear()
        AttachmentsList.Items.Clear()

        ActiveControl = txt_desc

    End Sub

    Sub load_data()

        ds.Reset()
        con.Open()

        stroledb = "SELECT * FROM tbl_works WHERE (tbl_works.work_id = " & Work_no & ")"
        da = New OleDbDataAdapter(stroledb, con)
        da.Fill(ds, "tbl_works")

        txt_title.Text = ds.Tables("tbl_works").Rows(0).Item("work_title").ToString

        stroledb = "SELECT * FROM tbl_track WHERE (tbl_track.work_id = '" & Work_no & "')"
        da = New OleDbDataAdapter(stroledb, con)
        da.Fill(ds, "tbl_track")

        With ds.Tables("tbl_track")
            If Not .Rows.Count = 0 Then
                For i = 0 To .Rows.Count - 1
                    WorksList.Items.Add(.Rows(i).Item("track_desc").ToString & " - تاریخ پیگیری: " & .Rows(i).Item("track_date").ToString)
                Next
            End If
        End With

        con.Close()

    End Sub
    Private Sub frm_track_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        clear_form()
        load_data()

        frm_main.lbl_title.Text = "برنامه ریزی کارهای ادرای / ثبت پیگیری"

    End Sub

    Private Sub btn_home_Click(sender As Object, e As EventArgs) Handles btn_home.Click

        frm_main.lbl_title.Text = "برنامه ریزی کارهای اداری / جستجو"

        frm_main.Panel_main.Visible = True
        frm_main.panel_edit.Visible = False

        Me.Close()

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

                    .Items.RemoveAt(.SelectedIndex)
                    Exit Sub

                End If
            Next

            IO.File.Delete(My.Application.Info.DirectoryPath & "\Attaches\" & .SelectedItem.ToString)
            .Items.RemoveAt(.SelectedIndex)

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


        If txt_desc.Text.Trim = "" Then
            MessageBox.Show("شرح پیگیری را وارد نمایید", "PAW", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_desc.Focus()
            Exit Sub
        End If

        stroledb = "INSERT INTO tbl_track (track_desc, work_id, track_date) VALUES (@track_desc, @work_id, @track_date)"

        com = New OleDbCommand(stroledb, con)
        com.Parameters.Add("@track_desc", OleDbType.VarChar).Value = txt_desc.Text
        com.Parameters.Add("@work_id", OleDbType.VarChar).Value = Work_no
        com.Parameters.Add("@track_date", OleDbType.VarChar).Value = txt_year.Text & "/" & txt_month.Text & "/" & txt_day.Text

        con.Open()
        com.ExecuteNonQuery()
        con.Close()

        If Not AttachmentsList.Items.Count = 0 Then
            For i = 0 To AttachmentsList.Items.Count - 1
                stroledb = "INSERT INTO tbl_attachs (attach_name, work_id, track_id) VALUES (@attach_name, @work_id, @track_id)"
                com = New OleDbCommand(stroledb, con)
                com.Parameters.Add("@attach_name", OleDbType.VarChar).Value = AttachmentsList.Items(i).ToString
                com.Parameters.Add("@work_id", OleDbType.VarChar).Value = Work_no
                com.Parameters.Add("@track_id", OleDbType.VarChar).Value = "-"
                con.Open()
                com.ExecuteNonQuery()
                con.Close()
            Next
        End If

        clear_form()
        load_data()


    End Sub

    Private Sub txt_day_TextChanged(sender As Object, e As EventArgs) Handles txt_day.TextChanged

        If sender.Text = "" Then Exit Sub
        If IsNumeric(sender.Text) = False Then sender.Clear() : Exit Sub
        If Int(sender.Text) < 1 Or Int(sender.Text) > 31 Then sender.Clear() : Exit Sub

    End Sub

    Private Sub txt_month_TextChanged(sender As Object, e As EventArgs) Handles txt_month.TextChanged

        If sender.Text = "" Then Exit Sub
        If IsNumeric(sender.Text) = False Then sender.Clear() : Exit Sub
        If Int(sender.Text) < 1 Or Int(sender.Text) > 12 Then sender.Clear() : Exit Sub

    End Sub

    Private Sub txt_day_Leave(sender As Object, e As EventArgs) Handles txt_day.Leave, txt_month.Leave

        If sender.text = "" Then Exit Sub
        If sender.Text.Length < 2 Then sender.Text = "0" & sender.Text
        If Not txt_month.Text.Trim = "" Then
            If Int(txt_month.Text) > 6 And Int(txt_day.Text) > 30 Then txt_day.Text = "30"
        End If

    End Sub

    Private Sub txt_year_Leave(sender As Object, e As EventArgs) Handles txt_year.Leave

        If sender.text = "" Then Exit Sub
        If sender.Text.Length < 4 Then
            MessageBox.Show("لطفاً سال را بصورت عدد 4 رقمی وارد نمایید", "PAW", MessageBoxButtons.OK, MessageBoxIcon.Error)
            sender.Focus()
            sender.SelectAll()
        End If

    End Sub
    Private Sub txt_year_TextChanged(sender As Object, e As EventArgs) Handles txt_year.TextChanged

        If IsNumeric(sender.Text) = False Then sender.Clear() : Exit Sub

    End Sub
    Private Sub txt_year_GotFocus(sender As Object, e As EventArgs) Handles txt_year.GotFocus, txt_month.GotFocus, txt_day.GotFocus, txt_year.MouseClick, txt_month.MouseClick, txt_day.MouseClick

        sender.SelectAll()

    End Sub
End Class