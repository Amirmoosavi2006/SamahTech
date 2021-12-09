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
        txt_username.Clear()
        Row_for_del = -1
        Row_for_edit = -1
        cmb_Role.SelectedIndex = 0
        btn_edit.Enabled = False
        btn_save.Enabled = True
        txt_fname.Focus()

    End Sub

    Sub Load_data()

        ds.Reset()
        con = New OleDbConnection(strcon)
        con.Open()

        stroledb = "SELECT F_Name AS نام, L_Name AS [نام خانوادگی], User_name AS [نام کاربری], User_Role AS نقش, User_Phone AS [شماره تماس]
        FROM tbl_Users"
        da = New OleDbDataAdapter(stroledb, con)
        da.Fill(ds, "tbl_Users")

        con.Close()

        dgv_Store.DataBindings.Clear()
        dgv_Store.DataBindings.Add(New Binding("datasource", ds, "tbl_Users"))
        dgv_Store.ClearSelection()

        For i = 0 To dgv_Store.Rows.Count - 1
            Select Case dgv_Store.Item("نقش", i).Value
                Case 0
                    dgv_Store.Item("نقش", i).Value = cmb_Role.Items(0).ToString
                Case 1
                    dgv_Store.Item("نقش", i).Value = cmb_Role.Items(1).ToString
            End Select
        Next

    End Sub

    Private Sub btn_return_Click(sender As Object, e As EventArgs) Handles btn_return.Click

        Me.Close()

    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click

        If txt_lname.Text.Trim = "" Then

            MsgBox("نام خانوادگی نمی تواند خالی باشد",, "پیگیری ویژه")
            txt_lname.Focus()
            Exit Sub

        End If

        If txt_username.Text.Trim = "" Then

            MsgBox("نام کاربری نمی تواند خالی باشد",, "پیگیری ویژه")
            txt_username.Focus()
            Exit Sub

        End If

        If txt_password.Text.Trim = "" Then

            MsgBox("رمز عبور نمی تواند خالی باشد",, "پیگیری ویژه")
            txt_password.Focus()
            Exit Sub

        End If

        If txt_fname.Text.Trim = "" Then txt_fname.Text = "-"
        If txt_phone.Text.Trim = "" Then txt_phone.Text = "0"

        For i = 0 To dgv_Store.Rows.Count - 1

            If txt_username.Text.Trim = dgv_Store.Item(0, i).Value.ToString Then

                MsgBox("نام کاربری نمی تواند تکراری باشد",, "پیگیری ویژه")
                dgv_Store.Item(0, i).Selected = True
                txt_username.SelectAll()
                txt_username.Focus()
                Exit Sub

            End If

        Next

        If cmb_Role.SelectedIndex = -1 Then
            cmb_Role.SelectedIndex = 0
        ElseIf cmb_Role.SelectedIndex = 1 Then
            If User_Role = False Then
                MsgBox("شما دسترسی لازم برای تعریف نقش مدیر سیستم را ندارید",, "پیگیری ویژه")
                cmb_Role.SelectedIndex = 0
                Exit Sub
            End If
        End If

        stroledb = "INSERT INTO tbl_Users (F_Name, L_Name, User_name, Pass_word, User_Role, User_Phone) VALUES (@F_Name, @L_Name, @User_name, @Pass_word, @User_Role, @User_Phone)"

        com = New OleDbCommand(stroledb, con)
        com.Parameters.Add("@F_Name", OleDbType.VarChar).Value = txt_fname.Text.Trim
        com.Parameters.Add("@L_Name", OleDbType.VarChar).Value = txt_lname.Text.Trim
        com.Parameters.Add("@User_name", OleDbType.VarChar).Value = txt_username.Text.Trim
        com.Parameters.Add("@Pass_word", OleDbType.VarChar).Value = txt_password.Text.Trim
        If cmb_Role.SelectedIndex = 1 Then
            com.Parameters.Add("@User_Role", OleDbType.VarChar).Value = "1"
        Else
            com.Parameters.Add("@User_Role", OleDbType.VarChar).Value = "0"
        End If
        com.Parameters.Add("@User_Phone", OleDbType.VarChar).Value = txt_phone.Text.Trim

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
        txt_username.Text = dgv_Store.Item(2, Row_for_edit).Value.ToString
        cmb_Role.Text = dgv_Store.Item(3, Row_for_edit).Value.ToString
        txt_phone.Text = dgv_Store.Item(4, Row_for_edit).Value.ToString

        btn_edit.Enabled = True
        btn_save.Enabled = False
        Temp_String = txt_username.Text.Trim

    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click

        If txt_lname.Text.Trim = "" Then

            MsgBox("نام خانوادگی نمی تواند خالی باشد",, "پیگیری ویژه")
            txt_lname.Focus()
            Exit Sub

        End If

        If txt_username.Text.Trim = "" Then

            MsgBox("نام کاربری نمی تواند خالی باشد",, "پیگیری ویژه")
            txt_username.Focus()
            Exit Sub

        End If

        If txt_password.Text.Trim = "" Then

            MsgBox("رمز عبور خود را وارد نمایید",, "پیگیری ویژه")
            txt_password.Focus()
            Exit Sub

        ElseIf txt_password.Text <> Pass_Keeper Then

            MsgBox("رمز عبور وارد شده صحیح نمی باشد",, "پیگیری ویژه")
            txt_password.Focus()
            Exit Sub

        End If

        If txt_fname.Text.Trim = "" Then txt_fname.Text = "-"
        If txt_phone.Text.Trim = "" Then txt_phone.Text = "0"

        For i = 0 To dgv_Store.Rows.Count - 1

            If txt_username.Text.Trim = dgv_Store.Item(0, i).Value.ToString Then

                If txt_username.Text.Trim = Temp_String Then Exit For

                MsgBox("نام کاربری نمی تواند تکراری باشد",, "پیگیری ویژه")
                dgv_Store.Item(0, i).Selected = True
                txt_username.SelectAll()
                txt_username.Focus()
                Exit Sub

            End If

        Next

        If cmb_Role.SelectedIndex = -1 Then
            cmb_Role.SelectedIndex = 0
        ElseIf cmb_Role.SelectedIndex = 1 Then
            If User_Role = False Then
                MsgBox("شما دسترسی لازم برای تعریف نقش مدیر سیستم را ندارید",, "پیگیری ویژه")
                cmb_Role.SelectedIndex = 0
                Exit Sub
            End If
        End If

        stroledb = "UPDATE tbl_Users SET F_Name =@F_Name, L_Name =@L_Name, User_name =@User_name, User_Role =@User_Role, User_Phone =@User_Phone WHERE (User_name = '" & Temp_String & "')"

        com = New OleDbCommand(stroledb, con)
        com.Parameters.Add("@F_Name", OleDbType.VarChar).Value = txt_fname.Text.Trim
        com.Parameters.Add("@L_Name", OleDbType.VarChar).Value = txt_lname.Text.Trim
        com.Parameters.Add("@User_name", OleDbType.VarChar).Value = txt_username.Text.Trim
        If cmb_Role.SelectedIndex = 1 Then
            com.Parameters.Add("@User_Role", OleDbType.VarChar).Value = "1"
        Else
            com.Parameters.Add("@User_Role", OleDbType.VarChar).Value = "0"
        End If
        com.Parameters.Add("@User_Phone", OleDbType.VarChar).Value = txt_phone.Text.Trim

        con.Open()
        com.ExecuteNonQuery()
        con.Close()

        Call Clear_form()
        Call Load_data()

    End Sub


    Private Sub dgv_Store_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Store.CellClick

        Row_for_del = e.RowIndex

        If btn_edit.Enabled = False And btn_save.Enabled = True And e.RowIndex <> -1 Then
            Temp_String = dgv_Store.Item("نام کاربری", e.RowIndex).Value.ToString
        End If

    End Sub

    Private Sub btn_del_Click(sender As Object, e As EventArgs) Handles btn_del.Click

        If Row_for_del = -1 Then Exit Sub

        Dim Dialog_Resault = MsgBox("آیا برای حذف اطمینان دارید؟", vbYesNo, "پیگیری ویژه")

        If Dialog_Resault = MsgBoxResult.Yes Then

            stroledb = "DELETE FROM tbl_Users WHERE (tbl_Users.user_name = '" & Temp_String & "')"
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