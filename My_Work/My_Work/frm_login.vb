Imports System.Data.OleDb

Public Class frm_login
    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click

        If txt_username.Text = "" Then
            MsgBox("نام کاربری را وارد نمایید")
            txt_username.Focus()
            Exit Sub
        End If

        If txt_password.Text = "" Then
            MsgBox("رمز عبور را وارد نمایید")
            txt_password.Focus()
            Exit Sub
        End If

        For i = 0 To ds.Tables("tbl_user").Rows.Count - 1
            If txt_username.Text = ds.Tables("tbl_user").Rows(i).Item("username").ToString And txt_password.Text = ds.Tables("tbl_user").Rows(i).Item("password").ToString Then
                frm_main.Show()
                Me.Close()
                Exit Sub
            End If
        Next

        MsgBox("نام کاربری و یا رمز عبور صحیح نمی باشد")
        txt_username.SelectAll()
        txt_username.Focus()

    End Sub

    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call Clear_form()
        Call Load_data()

    End Sub
    Sub Clear_form()

        txt_username.Clear()
        txt_password.Clear()
        txt_username.Focus()

    End Sub

    Sub Load_data()

        ds.Reset()
        con = New OleDbConnection(strcon)
        con.Open()

        stroledb = "SELECT * FROM tbl_user"
        da = New OleDbDataAdapter(stroledb, con)
        da.Fill(ds, "tbl_user")

        con.Close()

    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click

        Me.Close()

    End Sub


    Private Sub btn_pass_show_MouseDown(sender As Object, e As MouseEventArgs) Handles btn_pass_show.MouseDown

        txt_password.UseSystemPasswordChar = False

    End Sub

    Private Sub btn_pass_show_MouseUp(sender As Object, e As MouseEventArgs) Handles btn_pass_show.MouseUp

        txt_password.UseSystemPasswordChar = True

    End Sub
End Class