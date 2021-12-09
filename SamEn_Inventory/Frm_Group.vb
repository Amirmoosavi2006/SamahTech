Imports System.Data.OleDb

Public Class Frm_Group
    Private Sub Frm_Group_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call Clear_form()
        Call Load_data()

    End Sub

    Sub Clear_form()

        txt_name.Clear()
        btn_edit.Enabled = False
        btn_save.Enabled = True
        txt_name.Focus()

    End Sub

    Sub Load_data()

        ds.Reset()
        con = New OleDbConnection(strcon)
        con.Open()

        stroledb = "SELECT Gname AS [عنوان گروه] FROM tbl_Group"
        da = New OleDbDataAdapter(stroledb, con)
        da.Fill(ds, "tbl_Group")

        con.Close()

        dgv_Store.DataBindings.Clear()
        dgv_Store.DataBindings.Add(New Binding("datasource", ds, "tbl_Group"))
        dgv_Store.ClearSelection()

    End Sub

    Private Sub btn_return_Click(sender As Object, e As EventArgs) Handles btn_return.Click

        Me.Close()

    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click

        If txt_name.Text.Trim = "" Then

            MsgBox("عنوان گروه نمی تواند خالی باشد",, "انبارداری سامان")
            txt_name.Focus()
            Exit Sub

        End If

        For i = 0 To dgv_Store.Rows.Count - 1

            If txt_name.Text.Trim = dgv_Store.Item(0, i).value.tostring Then

                MsgBox("عنوان گروه نمی تواند تکراری باشد",, "انبارداری سامان")
                dgv_Store.Item(0, i).Selected = True
                txt_name.SelectionStart = 0
                txt_name.SelectionLength = Len(txt_name.Text)
                txt_name.Focus()
                Exit Sub

            End If

        Next

        stroledb = "INSERT INTO tbl_Group (Gname) VALUES (@Gname)"

        com = New OleDbCommand(stroledb, con)
        com.Parameters.Add("@Gname", OleDbType.VarChar).value = txt_name.Text.Trim

        con.Open()
        com.ExecuteNonQuery()
        con.Close()

        Call Clear_form()
        Call Load_data()

    End Sub



    Private Sub dgv_Store_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Store.CellDoubleClick

        If e.RowIndex = -1 Then Exit Sub

        Row_for_edit = e.RowIndex

        txt_name.Text = dgv_Store.Item(0, Row_for_edit).value.tostring

        btn_edit.Enabled = True
        btn_save.Enabled = False
        Temp_String = txt_name.Text.Trim

    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click

        If txt_name.Text.Trim = "" Then

            MsgBox("عنوان گروه نمی تواند خالی باشد",, "انبارداری سامان")
            txt_name.Focus()
            Exit Sub

        End If

        For i = 0 To dgv_Store.Rows.Count - 1

            If txt_name.Text.Trim = dgv_Store.Item(0, i).value.tostring Then

                If txt_name.Text.Trim = Temp_String Then Exit For

                MsgBox("عنوان گروه نمی تواند تکراری باشد",, "انبارداری سامان")
                dgv_Store.Item(0, i).Selected = True
                txt_name.SelectionStart = 0
                txt_name.SelectionLength = Len(txt_name.Text)
                txt_name.Focus()
                Exit Sub

            End If

        Next

        stroledb = "UPDATE tbl_Group SET Gname =@Gname WHERE (tbl_Group.Gname = '" & Temp_String & "')"

        com = New OleDbCommand(stroledb, con)
        com.Parameters.Add("@Gname", OleDbType.VarChar).value = txt_name.Text.Trim

        con.Open()
        com.ExecuteNonQuery()
        con.Close()

        Call Clear_form()
        Call Load_data()

    End Sub


    Private Sub dgv_Store_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Store.CellClick

        Row_for_del = e.RowIndex

        If btn_edit.Enabled = False And btn_save.Enabled = True And e.RowIndex <> -1 Then
            Temp_String = dgv_Store.Item(0, e.RowIndex).value.tostring
        End If

    End Sub

    Private Sub btn_del_Click(sender As Object, e As EventArgs) Handles btn_del.Click

        If Row_for_del = -1 Then MsgBox("ردیفی برای حذف انتخاب نشده است",, "انبارداری سامان") : Exit Sub

        Dim Dialog_Resault = MsgBox("آیا برای حذف اطمینان دارید؟", vbYesNo, "انبارداری سامان")

        If Dialog_Resault = MsgBoxResult.Yes Then

            stroledb = "DELETE FROM tbl_Group WHERE (tbl_Group.Gname = '" & Temp_String & "')"
            com = New OleDbCommand(stroledb, con)
            con.Open()
            com.ExecuteNonQuery()
            con.Close()

            Call Clear_form()
            Call Load_data()

        End If

    End Sub

    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click

        Call Clear_form()
        Call Load_data()

    End Sub
End Class