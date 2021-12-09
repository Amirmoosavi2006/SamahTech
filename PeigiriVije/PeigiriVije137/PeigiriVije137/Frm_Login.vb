Imports System.ComponentModel
Imports System.Data.OleDb

Public Class Frm_Login
    Dim ook As Boolean

    Private Sub btn_Ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Ok.Click

        If ds.Tables("tbl_Users").Rows.Count = 0 Then
            If txt_Username.Text = "admin" And txt_Password.Text = "1234" Then
                User_Name = "First User Login..."
                ook = True
                User_Role = True
                Pass_Keeper = txt_Password.Text.Trim
                Me.Close()
                Exit Sub
            End If
        End If

        For i = 0 To ds.Tables("tbl_Users").Rows.Count - 1
            If ds.Tables("tbl_Users").Rows(i).Item("User_name").ToString = txt_Username.Text And ds.Tables("tbl_Users").Rows(i).Item("Pass_word").ToString = txt_Password.Text Then
                User_Name = ds.Tables("tbl_Users").Rows(i).Item("F_Name").ToString & " " & ds.Tables("tbl_Users").Rows(i).Item("L_Name").ToString
                ook = True
                If ds.Tables("tbl_Users").Rows(i).Item("User_Role") = "1" Then User_Role = True
                Pass_Keeper = txt_Password.Text.Trim
                Me.Close()
                MessageBox.Show(Parent, "ورود شما با موفقیت انجام شد" & vbNewLine & "خوش آمدید", "پیگیری ویژه", MessageBoxButtons.OK,
                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
                Exit Sub
            End If
        Next

        MessageBox.Show(Parent, "نام کاربری و یا رمز عبور صحیح نمی باشد" & vbNewLine & "دوباره امتحان کنید", "پیگیری ویژه", MessageBoxButtons.OK,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        User_Role = False
        txt_Password.Clear()
        txt_Username.SelectAll()
        txt_Username.Focus()

    End Sub

    Private Sub btn_return_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_return.Click
        End
    End Sub

    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ds.Reset()
        con = New OleDbConnection(strcon)
        con.Open()

        stroledb = "SELECT * FROM tbl_Users"
        da = New OleDbDataAdapter(stroledb, con)
        da.Fill(ds, "tbl_Users")

        con.Close()

    End Sub

    Private Sub frm_login_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        If ook = False Then End

    End Sub
End Class