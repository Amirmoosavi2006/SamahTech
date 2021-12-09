Imports System.Data.OleDb

Public Class frm_login
    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click

        If txt_username.Text.Trim = "" Then
            MsgBox("لطفاً نام کاربری را وارد نمایید",, "PAW")
            txt_username.Focus()
            Exit Sub
        End If
        If txt_password.Text.Trim = "" Then
            MsgBox("لطفاً رمز عبور را وارد نمایید",, "PAW")
            txt_password.Focus()
            Exit Sub
        End If

        For i = 0 To ds.Tables("tbl_users").Rows.Count - 1

            If txt_username.Text.Trim.ToLower = ds.Tables("tbl_users").Rows(i).Item("user_name").ToString.ToLower And txt_password.Text.Trim = ds.Tables("tbl_users").Rows(i).Item("user_pass").ToString Then

                user_role = ds.Tables("tbl_users").Rows(i).Item("user_role").ToString
                Temp_Username = ds.Tables("tbl_users").Rows(i).Item("first_name").ToString & " " & ds.Tables("tbl_users").Rows(i).Item("last_name").ToString

                Dim f_main As New frm_main
                f_main.Show()
                Me.Close()
                Exit Sub

            End If

        Next

        MsgBox("نام کاربری و یا رمز عبور معتبر نمی باشد",, "PAW")
        txt_password.Clear()
        txt_username.SelectAll()
        txt_username.Focus()

    End Sub

    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Clear_form()
        Load_data()

    End Sub

    Sub Clear_form()

        txt_username.Clear()
        txt_password.Clear()
        ActiveControl = txt_username

    End Sub

    Sub Load_data()

        ds.Reset()
        'con = New OleDbConnection(strcon)
        con.Open()

        stroledb = "SELECT * FROM tbl_users"
        da = New OleDbDataAdapter(stroledb, con)
        da.Fill(ds, "tbl_users")

        con.Close()

    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        End
    End Sub

    Private Sub btn_show_pass_MouseDown(sender As Object, e As MouseEventArgs) Handles btn_show_pass.MouseDown
        txt_password.UseSystemPasswordChar = False
    End Sub

    Private Sub btn_show_pass_MouseUp(sender As Object, e As MouseEventArgs) Handles btn_show_pass.MouseUp
        txt_password.UseSystemPasswordChar = True
        txt_password.Focus()
        txt_password.SelectAll()
    End Sub

End Class
