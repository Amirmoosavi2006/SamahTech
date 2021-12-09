Imports System.Data.OleDb

Public Class Frm_Users
    Private Sub Frm_Users_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call Clear_form()
        Call Load_data()

    End Sub

    Sub Clear_form()

        txt_fname.Clear()
        txt_phone.Clear()
        txt_lname.Clear()
        txt_password.Clear()
        txt_semat.Clear()
        txt_username.Clear()
        txt_wrokpalce.Clear()
        btn_edit.Enabled = False
        btn_save.Enabled = True
        txt_fname.Focus()

    End Sub

    Sub Load_data()

        ds.Reset()
        con = New OleDbConnection(strcon)
        con.Open()

        stroledb = "SELECT fname AS نام, lname AS [نام خانوادگی], phone AS [شماره تماس], semat AS سمت, workplace AS [محل خدمت], user_name AS [نام کاربری], pass_word AS [رمز عبور] FROM tbl_User"
        da = New OleDbDataAdapter(stroledb, con)
        da.Fill(ds, "tbl_User")

        con.Close()

        dgv_Store.DataBindings.Clear()
        dgv_Store.DataBindings.Add(New Binding("datasource", ds, "tbl_User"))
        dgv_Store.Columns(6).Visible = False
        dgv_Store.ClearSelection()

    End Sub

    Private Sub btn_return_Click(sender As Object, e As EventArgs) Handles btn_return.Click

        Me.Close()

    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click

        If txt_lname.Text.Trim = "" Then

            MsgBox("نام خانوادگی نمی تواند خالی باشد",, "انبارداری سامان")
            txt_lname.Focus()
            Exit Sub

        End If

        If txt_username.Text.Trim = "" Then

            MsgBox("نام کاربری نمی تواند خالی باشد",, "انبارداری سامان")
            txt_username.Focus()
            Exit Sub

        End If

        If txt_password.Text.Trim = "" Then

            MsgBox("رمز عبور نمی تواند خالی باشد",, "انبارداری سامان")
            txt_password.Focus()
            Exit Sub

        End If

        If txt_fname.Text.Trim = "" Then txt_fname.Text = "-"
        If txt_phone.Text.Trim = "" Then txt_phone.Text = "0"
        If txt_semat.Text.Trim = "" Then txt_semat.Text = "-"
        If txt_wrokpalce.Text.Trim = "" Then txt_wrokpalce.Text = "-"

        For i = 0 To dgv_Store.Rows.Count - 1

            If txt_username.Text.Trim = dgv_Store.Item(0, i).value.tostring Then

                MsgBox("نام کاربری نمی تواند تکراری باشد",, "انبارداری سامان")
                dgv_Store.Item(0, i).Selected = True
                txt_username.SelectionStart = 0
                txt_username.SelectionLength = Len(txt_username.Text)
                txt_username.Focus()
                Exit Sub

            End If

        Next

        stroledb = "INSERT INTO tbl_User (fname, lname, phone, semat, workplace, user_name, pass_word, user_admin) VALUES (@fname,@lname,@phone,@semat,@workplace,@user_name,@pass_word,@user_admin)"

        com = New OleDbCommand(stroledb, con)
        com.Parameters.Add("@fname", OleDbType.VarChar).Value = txt_fname.Text.Trim
        com.Parameters.Add("@lname", OleDbType.VarChar).Value = txt_lname.Text.Trim
        com.Parameters.Add("@phone", OleDbType.VarChar).Value = txt_phone.Text.Trim
        com.Parameters.Add("@semat", OleDbType.VarChar).Value = txt_semat.Text.Trim
        com.Parameters.Add("@workplace", OleDbType.VarChar).Value = txt_wrokpalce.Text.Trim
        com.Parameters.Add("@user_name", OleDbType.VarChar).Value = txt_username.Text.Trim
        com.Parameters.Add("@pass_word", OleDbType.VarChar).Value = txt_password.Text.Trim
        If CheckBox1.Checked = True Then
            com.Parameters.Add("@user_admin", OleDbType.VarChar).Value = "Y"
        Else
            com.Parameters.Add("@user_admin", OleDbType.VarChar).Value = "N"
        End If

        con.Open()
        com.ExecuteNonQuery()
        con.Close()

        Call Clear_form()
        Call Load_data()

    End Sub



    Private Sub dgv_Store_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Store.CellDoubleClick

        If e.RowIndex = -1 Then Exit Sub

        Row_for_edit = e.RowIndex

        txt_fname.Text = dgv_Store.Item(0, Row_for_edit).Value.ToString
        txt_lname.Text = dgv_Store.Item(1, Row_for_edit).Value.ToString
        txt_phone.Text = dgv_Store.Item(2, Row_for_edit).Value.ToString
        txt_semat.Text = dgv_Store.Item(3, Row_for_edit).Value.ToString
        txt_wrokpalce.Text = dgv_Store.Item(4, Row_for_edit).Value.ToString
        txt_username.Text = dgv_Store.Item(5, Row_for_edit).Value.ToString
        txt_password.Text = dgv_Store.Item(6, Row_for_edit).Value.ToString

        btn_edit.Enabled = True
        btn_save.Enabled = False
        Temp_String = txt_username.Text.Trim

    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click

        If txt_lname.Text.Trim = "" Then

            MsgBox("نام خانوادگی نمی تواند خالی باشد",, "انبارداری سامان")
            txt_lname.Focus()
            Exit Sub

        End If

        If txt_username.Text.Trim = "" Then

            MsgBox("نام کاربری نمی تواند خالی باشد",, "انبارداری سامان")
            txt_username.Focus()
            Exit Sub

        End If

        If txt_password.Text.Trim = "" Then

            MsgBox("رمز عبور نمی تواند خالی باشد",, "انبارداری سامان")
            txt_password.Focus()
            Exit Sub

        End If

        If txt_fname.Text.Trim = "" Then txt_fname.Text = "-"
        If txt_phone.Text.Trim = "" Then txt_phone.Text = "0"
        If txt_semat.Text.Trim = "" Then txt_semat.Text = "-"
        If txt_wrokpalce.Text.Trim = "" Then txt_wrokpalce.Text = "-"

        For i = 0 To dgv_Store.Rows.Count - 1

            If txt_username.Text.Trim = dgv_Store.Item(0, i).Value.ToString Then

                If txt_username.Text.Trim = Temp_String Then Exit For

                MsgBox("نام کاربری نمی تواند تکراری باشد",, "انبارداری سامان")
                dgv_Store.Item(0, i).Selected = True
                txt_username.SelectionStart = 0
                txt_username.SelectionLength = Len(txt_username.Text)
                txt_username.Focus()
                Exit Sub

            End If

        Next

        stroledb = "UPDATE tbl_User SET fname =@fname, lname =@lname, phone =@phone, semat =@semat, workplace =@workplace, user_name =@user_name, pass_word =@pass_word WHERE (tbl_User.user_name = '" & Temp_String & "')"

        com = New OleDbCommand(stroledb, con)
        com.Parameters.Add("@fname", OleDbType.VarChar).Value = txt_fname.Text.Trim
        com.Parameters.Add("@lname", OleDbType.VarChar).Value = txt_lname.Text.Trim
        com.Parameters.Add("@phone", OleDbType.VarChar).Value = txt_phone.Text.Trim
        com.Parameters.Add("@semat", OleDbType.VarChar).Value = txt_semat.Text.Trim
        com.Parameters.Add("@workplace", OleDbType.VarChar).Value = txt_wrokpalce.Text.Trim
        com.Parameters.Add("@user_name", OleDbType.VarChar).Value = txt_username.Text.Trim
        com.Parameters.Add("@pass_word", OleDbType.VarChar).Value = txt_password.Text.Trim

        con.Open()
        com.ExecuteNonQuery()
        con.Close()

        Call Clear_form()
        Call Load_data()

    End Sub


    Private Sub dgv_Store_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Store.CellClick

        Row_for_del = e.RowIndex

        If btn_edit.Enabled = False And btn_save.Enabled = True And e.RowIndex <> -1 Then
            Temp_String = dgv_Store.Item(5, e.RowIndex).value.tostring
        End If

    End Sub

    Private Sub btn_del_Click(sender As Object, e As EventArgs) Handles btn_del.Click

        If Row_for_del = -1 Then MsgBox("ردیفی برای حذف انتخاب نشده است",, "انبارداری سامان") : Exit Sub

        Dim Dialog_Resault = MsgBox("آیا برای حذف اطمینان دارید؟", vbYesNo, "انبارداری سامان")

        If Dialog_Resault = MsgBoxResult.Yes Then

            stroledb = "DELETE FROM tbl_User WHERE (tbl_User.user_name = '" & Temp_String & "')"
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