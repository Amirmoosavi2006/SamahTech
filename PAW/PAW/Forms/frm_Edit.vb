Imports System.Data.OleDb

Public Class frm_Edit

    Sub Clear_Form()

        For Each obj As Control In Me.Controls

            If obj.GetType = GetType(TextBox) Then
                obj.Text = ""
                obj.Enabled = False
            End If

        Next

        WorkTitle.Enabled = True
        WorkDesc.Enabled = True

        AttachmentsList.Items.Clear()
        PeopleList.Items.Clear()
        TrackList.Items.Clear()

        EndWorkCHB.Checked = False
        TrackCHB.Checked = False

        WorkTitle.Focus()

    End Sub
    Sub Load_Data()

        ds.Reset()
        'con = New OleDbConnection(strcon)
        con.Open()

        stroledb = "SELECT * FROM tbl_works WHERE (work_id = " & Work_no & ")"
        da = New OleDbDataAdapter(stroledb, con)
        da.Fill(ds, "tbl_Works")

        WorkTitle.Text = ds.Tables("tbl_Works").Rows(0).Item("work_title")
        WorkDesc.Text = ds.Tables("tbl_Works").Rows(0).Item("work_desc")

        If ds.Tables("tbl_Works").Rows(0).Item("work_track") = "y" Then
            TrackCHB.Checked = True
            With ds.Tables("tbl_Works").Rows(0).Item("work_track_date").ToString
                TrackDay.Text = .Chars(8) & .Chars(9)
                TrackMonth.Text = .Chars(5) & .Chars(6)
                TrackYear.Text = .Chars(0) & .Chars(1) & .Chars(2) & .Chars(3)
            End With
        End If

        stroledb = "SELECT * FROM tbl_track WHERE (work_id = '" & Work_no & "')"
        da = New OleDbDataAdapter(stroledb, con)
        da.Fill(ds, "tbl_track")

        If ds.Tables("tbl_track").Rows.Count = 0 Then
            TrackList.Enabled = False
        Else
            For i = 0 To ds.Tables("tbl_track").Rows.Count - 1
                TrackList.Items.Add(ds.Tables("tbl_track").Rows(i).Item("track_desc"))
            Next
        End If

        stroledb = "SELECT * FROM tbl_attachs WHERE (work_id = '" & Work_no & "')"
        da = New OleDbDataAdapter(stroledb, con)
        da.Fill(ds, "tbl_attachs")

        If ds.Tables("tbl_attachs").Rows.Count = 0 Then
            AttachmentsList.Enabled = False
        Else
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

        If PeopleList.Items.Count = 0 Then
            PeopleList.Enabled = False
        Else
            For i = 0 To ds.Tables("tbl_people").Rows.Count - 1
                For j = 0 To PeopleList.Items.Count - 1
                    If PeopleList.Items(j).ToString = ds.Tables("tbl_people").Rows(i).Item("p_name").ToString Then
                        PeopleList.SetItemChecked(j, True)
                    End If
                Next
            Next
        End If

        con.Close()

    End Sub

    Private Sub frm_Edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Clear_Form()
        Load_Data()

    End Sub

    Private Sub btn_return_Click(sender As Object, e As EventArgs) Handles btn_return.Click
        Me.Close()
    End Sub

    Private Sub TrackCHB_CheckedChanged(sender As Object, e As EventArgs) Handles TrackCHB.CheckedChanged

        If TrackCHB.Checked = True Then
            TrackDay.Enabled = True
            TrackMonth.Enabled = True
            TrackYear.Enabled = True
        Else
            TrackDay.Enabled = False
            TrackMonth.Enabled = False
            TrackYear.Enabled = False
        End If

    End Sub

    Private Sub EndWorkCHB_CheckedChanged(sender As Object, e As EventArgs) Handles EndWorkCHB.CheckedChanged

        If EndWorkCHB.Checked = True Then
            EndDay.Enabled = True
            EndMonth.Enabled = True
            EndYear.Enabled = True
        Else
            EndDay.Enabled = False
            EndMonth.Enabled = False
            EndYear.Enabled = False
        End If

    End Sub

    Private Sub AttachmentsList_DoubleClick(sender As Object, e As EventArgs) Handles AttachmentsList.DoubleClick

        With AttachmentsList

            If .Items.Count = 0 Then Exit Sub
            Process.Start(My.Application.Info.DirectoryPath & "\Attaches\" & AttachmentsList.SelectedItem.ToString)

        End With

    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click

    End Sub

    Private Sub TrackList_DoubleClick(sender As Object, e As EventArgs) Handles TrackList.DoubleClick

        With TrackList
            If .SelectedIndex = -1 Then Exit Sub
            Dim Edit_Text = InputBox("متن مورد نظر را اصلاح نمایید", "PAW", .SelectedItem.ToString)
            If Edit_Text <> "" Then
                .Items(.SelectedIndex) = Edit_Text.ToString
            End If
        End With

    End Sub

    Private Sub Track_del_Click(sender As Object, e As EventArgs) Handles Track_del.Click

        With TrackList
            If .SelectedIndex <> -1 Then .Items.RemoveAt(.SelectedIndex)
        End With

    End Sub

    Private Sub TrackList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TrackList.SelectedIndexChanged

    End Sub
End Class