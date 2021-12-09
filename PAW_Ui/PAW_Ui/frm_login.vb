Imports System.Data.OleDb

Public Class frm_login

    Sub Load_data()

        ds.Reset()
        con.Open()

        stroledb = "SELECT * FROM tbl_users"
        da = New OleDbDataAdapter(stroledb, con)
        da.Fill(ds, "tbl_users")

        con.Close()

    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click

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

                frm_main.lbl_title.Text = "برنامه ریزی کارهای اداری / صفحه اصلی"
                frm_main.lbl_user.Text = Temp_Username.ToString
                Try
                    frm_main.pic_user.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\UserPics\" & ds.Tables("tbl_users").Rows(i).Item("first_name").ToString & "_" & ds.Tables("tbl_users").Rows(i).Item("last_name").ToString)
                Catch ex As Exception

                End Try

                For Each obj In frm_main.Panel1.Controls

                    obj.enabled = True

                Next

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

        Me.CancelButton = frm_main.btn_exit
        ActiveControl = txt_username

        Dim tooltip As New ToolTip
        With tooltip
            .SetToolTip(txt_username, "نام کاربری")
            .SetToolTip(txt_password, "رمز عبور")
            .Active = True
        End With

        Load_data()

    End Sub

    Private Sub txt_username_GotFocus(sender As Object, e As EventArgs) Handles txt_username.GotFocus, txt_username.MouseClick, txt_password.GotFocus, txt_password.MouseClick

        If Not sender.text = "" Then sender.selectall()

    End Sub
End Class