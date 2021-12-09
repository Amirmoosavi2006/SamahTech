Imports System.Data.OleDb

Public Class frm_find

    Dim Selected_Row As Integer

    Sub Clear_Form()

        txt_from_day.Text = "01"
        txt_from_month.Text = Temp_Month
        txt_from_year.Text = Temp_Year
        txt_to_day.Text = Temp_Day
        txt_to_month.Text = Temp_Month
        txt_to_year.Text = Temp_Year

        Selected_Row = -1

        ActiveControl = txt_find

    End Sub

    Sub Load_Data()

        ds.Reset()
        con.Open()

        stroledb = "SELECT * FROM tbl_users"
        da = New OleDbDataAdapter(stroledb, con)
        da.Fill(ds, "tbl_users")

        stroledb = "SELECT * FROM tbl_attachs"
        da = New OleDbDataAdapter(stroledb, con)
        da.Fill(ds, "tbl_attachs")

        stroledb = "SELECT * FROM tbl_people"
        da = New OleDbDataAdapter(stroledb, con)
        da.Fill(ds, "tbl_people")

        stroledb = "Select * FROM tbl_works"
        da = New OleDbDataAdapter(stroledb, con)
        da.Fill(ds, "tbl_works")

        stroledb = "Select * FROM tbl_track"
        da = New OleDbDataAdapter(stroledb, con)
        da.Fill(ds, "tbl_track")

        With dgv_find

            .Rows.Clear()
            For i = 0 To ds.Tables("tbl_works").Rows.Count - 1
                .Rows.Add()
                .Item(0, i).Value = ds.Tables("tbl_works").Rows(i).Item("work_id").ToString
                .Item(1, i).Value = ds.Tables("tbl_works").Rows(i).Item("work_title").ToString
                .Item(2, i).Value = ds.Tables("tbl_works").Rows(i).Item("work_create_date").ToString
                .Item(3, i).Value = ds.Tables("tbl_works").Rows(i).Item("work_desc").ToString
            Next

            For i = 0 To ds.Tables("tbl_track").Rows.Count - 1
                For j = 0 To .RowCount - 1
                    If ds.Tables("tbl_track").Rows(i).Item("work_id").ToString = .Item(0, j).Value Then
                        If .Item(4, j).Value = "" Then
                            .Item(4, j).Value = ds.Tables("tbl_track").Rows(i).Item("track_desc").ToString
                        Else
                            .Item(4, j).Value += vbNewLine & ds.Tables("tbl_track").Rows(i).Item("track_desc").ToString
                        End If
                    End If
                Next
            Next

            For i = 0 To ds.Tables("tbl_attachs").Rows.Count - 1
                For j = 0 To .RowCount - 1
                    If ds.Tables("tbl_attachs").Rows(i).Item("work_id").ToString = .Item(0, j).Value Then
                        .Item(5, j).Value = "دارد"
                    Else
                        If Not .Item(5, j).Value = "دارد" Then .Item(5, j).Value = "ندارد"
                    End If
                Next
            Next

            For i = 0 To ds.Tables("tbl_people").Rows.Count - 1
                For j = 0 To .RowCount - 1
                    If ds.Tables("tbl_people").Rows(i).Item("work_id").ToString = .Item(0, j).Value Then
                        If .Item(6, j).Value = "" Then
                            .Item(6, j).Value = ds.Tables("tbl_people").Rows(i).Item("p_name").ToString
                        Else
                            .Item(6, j).Value += vbNewLine & ds.Tables("tbl_people").Rows(i).Item("p_name").ToString
                        End If
                    End If
                Next
            Next

            For i = 0 To .ColumnCount - 1
                For j = 0 To .RowCount - 1
                    If .Item(i, j).Value = "" Then
                        .Item(i, j).Value = "-"
                    End If
                Next
            Next

            .ClearSelection()

        End With

        con.Close()

    End Sub

    Private Sub frm_find_edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Clear_Form()
        Load_Data()

        frm_main.lbl_title.Text = "برنامه ریزی کارهای اداری / جستجو"

    End Sub
    Private Sub txt_from_day_TextChanged(sender As Object, e As EventArgs) Handles txt_from_day.TextChanged, txt_to_day.TextChanged

        If sender.Text = "" Then Exit Sub
        If IsNumeric(sender.Text) = False Then sender.Clear() : Exit Sub
        If Int(sender.Text) < 1 Or Int(sender.Text) > 31 Then sender.Clear() : Exit Sub
        If Int(Temp_Month) > 6 And Int(sender.Text) > 30 Then sender.Text = "30"

    End Sub

    Private Sub txt_from_month_TextChanged(sender As Object, e As EventArgs) Handles txt_from_month.TextChanged, txt_to_month.TextChanged

        If sender.Text = "" Then Exit Sub
        If IsNumeric(sender.Text) = False Then sender.Clear() : Exit Sub
        If Int(sender.Text) < 1 Or Int(sender.Text) > 12 Then sender.Clear() : Exit Sub

    End Sub

    Private Sub txt_from_day_Leave(sender As Object, e As EventArgs) Handles txt_from_day.Leave, txt_from_month.Leave, txt_to_day.Leave, txt_to_month.Leave

        If sender.text = "" Then Exit Sub
        If sender.Text.Length < 2 Then sender.Text = "0" & sender.Text

    End Sub

    Private Sub txt_from_year_Leave(sender As Object, e As EventArgs) Handles txt_from_year.Leave, txt_to_year.Leave

        If sender.text = "" Then Exit Sub
        If sender.Text.Length < 4 Then
            MessageBox.Show("لطفاً سال را بصورت عدد 4 رقمی وارد نمایید", "PAW", MessageBoxButtons.OK, MessageBoxIcon.Error)
            sender.Focus()
            sender.SelectAll()
        End If

    End Sub
    Private Sub txt_from_year_Enter(sender As Object, e As EventArgs) Handles txt_to_year.GotFocus, txt_to_month.GotFocus, txt_to_day.GotFocus, txt_from_year.GotFocus, txt_from_month.GotFocus, txt_from_day.GotFocus, txt_to_year.MouseClick, txt_to_month.MouseClick, txt_to_day.MouseClick, txt_from_year.MouseClick, txt_from_month.MouseClick, txt_from_day.MouseClick

        sender.SelectAll()

    End Sub
    Private Sub txt_from_year_TextChanged(sender As Object, e As EventArgs) Handles txt_from_year.TextChanged, txt_to_year.TextChanged

        If IsNumeric(sender.Text) = False Then sender.Clear() : Exit Sub

    End Sub

    Private Sub dgv_find_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgv_find.CellFormatting

        For i = 0 To dgv_find.RowCount - 1

            If i Mod 2 = 0 Then
                dgv_find.Rows(i).DefaultCellStyle.BackColor = Color.LightGray
            Else
                dgv_find.Rows(i).DefaultCellStyle.BackColor = Color.Silver
            End If

        Next

    End Sub

    Private Sub btn_home_Click(sender As Object, e As EventArgs) Handles btn_home.Click

        frm_main.lbl_title.Text = "برنامه ریزی کارهای اداری / صفحه اصلی"

        For Each obj In frm_main.Panel1.Controls

            obj.enabled = True

        Next

        Me.Close()

    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click

        Clear_Form()
        Load_Data()

        ActiveControl = txt_find

    End Sub

    Private Sub btn_find_Click(sender As Object, e As EventArgs) Handles btn_find.Click

        For Each obj In Me.Controls
            If obj.GetType().ToString.Contains("TextBox") = True Then
                If obj.text = "" And obj.name <> txt_find.Name Then
                    MsgBox("برخی داده ها بدرستی وارد نشده است" & vbNewLine & "دوباره سعی کنید")
                    obj.focus()
                    Exit Sub
                End If
            End If
        Next

        Dim F_date = txt_from_year.Text & "/" & txt_from_month.Text & "/" & txt_from_day.Text
        Dim L_date = txt_to_year.Text & "/" & txt_to_month.Text & "/" & txt_to_day.Text

        With dgv_find

            For i = .RowCount - 1 To 0 Step -1

                If .Item(1, i).Value.ToString.Contains(txt_find.Text.Trim) = False And
                .Item(3, i).Value.ToString.Contains(txt_find.Text.Trim) = False And
                .Item(4, i).Value.ToString.Contains(txt_find.Text.Trim) = False Then
                    .Rows.RemoveAt(i)
                    Continue For
                End If

                If .Item(2, i).Value < F_date Or .Item(2, i).Value > L_date Then
                    .Rows.RemoveAt(i)
                End If

            Next

            .ClearSelection()

        End With

    End Sub

    Private Sub dgv_Find_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_find.CellClick

        If e.RowIndex <> -1 Then Selected_Row = e.RowIndex

    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click

        If dgv_find.RowCount = 0 Or Selected_Row = -1 Then
            MessageBox.Show("هیچ کاری برای ویرایش انتخاب نشده است", "PAW", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Work_no = dgv_find.Item(0, Selected_Row).Value

        frm_main.lbl_title.Text = "برنامه ریزی کارهای اداری / ویرایش"

        Dim f_edit As New frm_edit With {
      .TopLevel = False,
      .TopMost = True,
      .StartPosition = FormStartPosition.CenterParent
      }

        With frm_main.panel_edit
            .Controls.Add(f_edit)
            .Visible = True
        End With

        f_edit.Show()

        frm_main.Panel_main.Visible = False

    End Sub

    Private Sub btn_del_Click(sender As Object, e As EventArgs) Handles btn_del.Click

        If Selected_Row = -1 Then Exit Sub

        With dgv_find

            Dim w_no As String = .Item(0, Selected_Row).Value.ToString

            If MessageBox.Show("این عملیات غیرقابل بازگشت می باشد" & vbNewLine & "آیا برای حذف اطمینان دارید؟", "PAW", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign) = DialogResult.No Then

                Exit Sub

            Else

                stroledb = "DELETE FROM tbl_works WHERE (tbl_works.work_id = " & w_no & ")"
                deletefromtables(stroledb)
                stroledb = "DELETE FROM tbl_track WHERE (tbl_works.work_id = " & w_no & ")"
                deletefromtables(stroledb)
                stroledb = "DELETE FROM tbl_attachs WHERE (tbl_works.work_id = " & w_no & ")"
                deletefromtables(stroledb)
                stroledb = "DELETE FROM tbl_people WHERE (tbl_works.work_id = " & w_no & ")"
                deletefromtables(stroledb)

                .Rows.RemoveAt(Selected_Row)

            End If

        End With

    End Sub
    Sub deletefromtables(ByVal str As String)

        stroledb = str
        com = New OleDbCommand(stroledb, con)
        con.Open()
        Try
            com.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            con.Close()
        End Try

    End Sub

    Private Sub dgv_find_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_find.CellDoubleClick

        If e.RowIndex <> -1 Then Selected_Row = e.RowIndex
        Call btn_edit_Click(sender, e)

    End Sub

    Private Sub btn_track_Click(sender As Object, e As EventArgs) Handles btn_track.Click

        If dgv_find.RowCount = 0 Or Selected_Row = -1 Then
            MessageBox.Show("هیچ کاری برای ثبت پیگیری انتخاب نشده است", "PAW", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Work_no = dgv_find.Item(0, Selected_Row).Value

        frm_main.lbl_title.Text = "برنامه ریزی کارهای اداری / ثبت پیگیری"

        Dim f_track As New frm_track With {
          .TopLevel = False,
          .TopMost = True,
          .StartPosition = FormStartPosition.CenterParent
          }

        With frm_main.panel_edit
            .Controls.Add(f_track)
            .Visible = True
        End With

        f_track.Show()

        frm_main.Panel_main.Visible = False

    End Sub

    Private Sub frm_find_Activated(sender As Object, e As EventArgs) Handles Me.Activated

        Clear_Form()
        Load_Data()

    End Sub
End Class