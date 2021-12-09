Imports System.Data.OleDb

Public Class Frm_Login
    Private Sub btn_return_Click(sender As Object, e As EventArgs) Handles btn_return.Click

        Me.Close()

    End Sub

    Private Sub Frm_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call Clear_form()
        Call Load_data()

        If ds.Tables("tbl_user").Rows.Count = 0 Then

            MsgBox("تاکنون هیچ کاربری ثبت نشده است" & vbNewLine & "لطفاً اولین کاربر را ثبت نمایید",, "انبارداری سامان")
            Frm_Users.ShowDialog()
            Call Load_data()

        End If

    End Sub

    Sub Clear_form()

        txt_Username.Clear()
        txt_Password.Clear()
        txt_Username.Focus()

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

    Private Sub btn_Ok_Click(sender As Object, e As EventArgs) Handles btn_Ok.Click

        If txt_Username.Text = "" Or txt_Password.Text = "" Then

            MsgBox("نام کاربری و یا رمز عبور نمی توانند خالی باشند",, "انبارداری سامان")

            If txt_Username.Text = "" Then
                txt_Username.Focus()
            Else
                txt_Password.Focus()
            End If

            Exit Sub

        End If

        For i = 0 To ds.Tables("tbl_user").Rows.Count - 1

            If txt_Username.Text.Trim = ds.Tables("tbl_user").Rows(i).Item("user_name") And txt_Password.Text.Trim = ds.Tables("tbl_user").Rows(i).Item("pass_word") Then

                If ds.Tables("tbl_user").Rows(i).Item("user_admin") = "Y" Then User_Admin = True
                frm_main.Show()
                Exit For

            End If

        Next

        Me.Close()

    End Sub
End Class