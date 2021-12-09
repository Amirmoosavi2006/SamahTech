Imports System.Data.OleDb

Public Class frm_Track

    Dim Edit_Check As Boolean = False
    Dim Selected_Row As Integer = -1
    Dim Work_id As String = ""
    Sub Clear_Form()

        For Each ctrl As Control In Me.Controls
            If ctrl.GetType = GetType(TextBox) Then
                ctrl.Text = ""
            End If
        Next
        TrackDay.Text = Temp_Day
        TrackMonth.Text = Temp_Month
        TrackYear.Text = Temp_Year
        AttachmentsList.Items.Clear()
        If Edit_Check = False Then Selected_Row = -1
        Edit_Check = False
        Work_id = ""
        WorkTitle.Focus()

    End Sub

    Sub Load_Data()

        ds.Reset()
        'con = New OleDbConnection(strcon)
        con.Open()

        stroledb = "SELECT work_id AS [شناسه کار], work_title AS [عنوان کار], work_desc AS [شرح کار] FROM     tbl_works WHERE  (work_archive = 'n')"
        da = New OleDbDataAdapter(stroledb, con)
        da.Fill(ds, "tbl_works")

        dgv_Track.DataBindings.Clear()
        dgv_Track.DataBindings.Add(New Binding("datasource", ds, "tbl_works"))

        stroledb = "Select * FROM tbl_track"
        da = New OleDbDataAdapter(stroledb, con)
        da.Fill(ds, "tbl_track")

        stroledb = "Select * FROM tbl_attachs"
        da = New OleDbDataAdapter(stroledb, con)
        da.Fill(ds, "tbl_attachs")

        con.Close()

    End Sub
    Private Sub frm_Track_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Clear_Form()
        Load_Data()

    End Sub

    Private Sub btn_return_Click(sender As Object, e As EventArgs) Handles btn_return.Click
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

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click

        If Edit_Check = False Then Exit Sub

        If TrackDesc.Text.Trim = "" Then
            MessageBox.Show("لطفاً شرح پیگیری را وارد نمایید", "PAW", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TrackDesc.Focus()
            Exit Sub
        End If

        '-----------------------saving
        stroledb = "INSERT INTO tbl_track (work_id, track_desc, attach_id, track_date) VALUES (@work_id, @track_desc, @attach_id, @track_date)"

        com = New OleDbCommand(stroledb, con)
        com.Parameters.Add("@work_id", OleDbType.VarChar).Value = Work_id
        com.Parameters.Add("@track_desc", OleDbType.VarChar).Value = TrackDesc.Text.Trim
        com.Parameters.Add("@attach_id", OleDbType.VarChar).Value = ""
        com.Parameters.Add("@track_date", OleDbType.VarChar).Value = TrackYear.Text & "/" & TrackMonth.Text & "/" & TrackDay.Text

        con.Open()
        com.ExecuteNonQuery()
        con.Close()
        '-----------------------saving

        Call Load_Data()

        Dim track_id As String = ds.Tables("tbl_track").Rows(ds.Tables("tbl_track").Rows.Count - 1).Item(0).ToString 'choose a correct work id for saving attaches

        '------------------saving attaches
        Dim Attach_IDs As String = ""
        If Not AttachmentsList.Items.Count = 0 Then
            For i = 0 To AttachmentsList.Items.Count - 1
                stroledb = "INSERT INTO tbl_attachs (attach_name, work_id, track_id) VALUES (@attach_name, @work_id, @track_id)"
                com = New OleDbCommand(stroledb, con)
                com.Parameters.Add("@attach_name", OleDbType.VarChar).Value = AttachmentsList.Items(i).ToString
                com.Parameters.Add("@work_id", OleDbType.VarChar).Value = Work_id
                com.Parameters.Add("@track_id", OleDbType.VarChar).Value = track_id
                con.Open()
                com.ExecuteNonQuery()
                con.Close()
            Next
        End If
        '------------------saving attaches

        Call Load_Data()

        For i = 0 To ds.Tables("tbl_attachs").Rows.Count - 1
            If ds.Tables("tbl_attachs").Rows(i).Item("track_id").ToString = track_id.ToString Then
                Attach_IDs += ds.Tables("tbl_attachs").Rows(i).Item("attach_id").ToString & ","
            End If
        Next

        '------------------Adding Attach IDs to tbl_track
        stroledb = "UPDATE tbl_track SET attach_id = @attach_id WHERE (tbl_track.track_id = " & track_id & ")"

        com = New OleDbCommand(stroledb, con)
        com.Parameters.Add("@attach_id", OleDbType.VarChar).Value = Attach_IDs
        con.Open()
        com.ExecuteNonQuery()
        con.Close()
        '------------------Adding Attach IDs to tbl_track

        Call Clear_Form()
        Call Load_Data()

        Try
            dgv_Track.ClearSelection()
            dgv_Track.Item(0, Selected_Row).Selected = True
        Catch ex As Exception
            dgv_Track.ClearSelection()
        End Try

    End Sub

    Private Sub TrackDay_TextChanged(sender As Object, e As EventArgs) Handles TrackDay.TextChanged

        If sender.Text = "" Then Exit Sub
        If IsNumeric(sender.Text) = False Then sender.Clear() : Exit Sub
        If Int(sender.Text) < 1 Or Int(sender.Text) > 31 Then sender.Clear() : Exit Sub
        If Int(Temp_Month) > 6 And Int(sender.Text) > 30 Then sender.Text = "30"

    End Sub

    Private Sub TrackMonth_TextChanged(sender As Object, e As EventArgs) Handles TrackMonth.TextChanged

        If sender.Text = "" Then Exit Sub
        If IsNumeric(sender.Text) = False Then sender.Clear() : Exit Sub
        If Int(sender.Text) < 1 Or Int(sender.Text) > 12 Then sender.Clear() : Exit Sub

    End Sub

    Private Sub TrackYear_Leave(sender As Object, e As EventArgs) Handles TrackYear.Leave

        If sender.text = "" Then Exit Sub
        If sender.Text.Length < 4 Then
            MessageBox.Show("لطفاً سال را بصورت عدد 4 رقمی وارد نمایید", "PAW", MessageBoxButtons.OK, MessageBoxIcon.Error)
            sender.Focus()
            sender.SelectAll()
        End If

    End Sub

    Private Sub TrackDay_Leave(sender As Object, e As EventArgs) Handles TrackDay.Leave, TrackMonth.Leave

        If sender.text = "" Then Exit Sub
        If sender.Text.Length < 2 Then sender.Text = "0" & sender.Text

    End Sub

    Private Sub TrackYear_TextChanged(sender As Object, e As EventArgs) Handles TrackYear.TextChanged

        If IsNumeric(sender.Text) = False Then sender.Clear() : Exit Sub

    End Sub


    Private Sub dgv_Track_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Track.CellDoubleClick

        If e.RowIndex = -1 Or dgv_Track.RowCount = 0 Then Exit Sub

        WorkTitle.Text = dgv_Track.Item(1, e.RowIndex).Value
        Work_id = dgv_Track.Item(0, e.RowIndex).Value
        Selected_Row = e.RowIndex
        Edit_Check = True
        TrackDesc.Focus()

    End Sub

    Private Sub TrackDay_GotFocus(sender As Object, e As EventArgs) Handles TrackDay.GotFocus, TrackMonth.GotFocus, TrackYear.GotFocus, TrackDay.MouseClick, TrackMonth.MouseClick, TrackYear.MouseClick

        sender.selectall()

    End Sub
End Class