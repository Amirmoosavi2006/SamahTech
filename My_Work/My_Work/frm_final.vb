Imports System.Data.OleDb

Public Class frm_final
    Private Sub btn_return_Click(sender As Object, e As EventArgs) Handles btn_return.Click

        Me.Close()

    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click

        If txt_final_desc.Text = "" Then
            MsgBox("شرح اتمام کار نمی تواند خالی باشد")
            txt_final_desc.Focus()
            Exit Sub
        End If

        Temp_date = txt_fy.Text & "/" & txt_fm.Text & "/" & txt_fd.Text

        If Len(Temp_date) < 10 Then MsgBox("خطا در ثبت تاریخ") : Exit Sub

        stroledb = "UPDATE tbl_work SET final_desc =@final_desc, final_ok =@final_ok, final_date =@final_date WHERE (tbl_work.work_no = " & Temp_Work_no & ")"

        com = New OleDbCommand(stroledb, con)
        com.Parameters.Add("@final_desc", OleDbType.VarChar).Value = txt_final_desc.Text
        com.Parameters.Add("@final_ok", OleDbType.VarChar).Value = "Y"
        com.Parameters.Add("@final_date", OleDbType.VarChar).Value = Temp_date

        con.Open()
        com.ExecuteNonQuery()
        con.Close()

        MsgBox("کار شماره " & Temp_Work_no & " به انجام رسید")

        frm_new.Show()
        Me.Close()

    End Sub
    Private Sub txt_fd_Leave(sender As Object, e As EventArgs) Handles txt_fd.Leave

        On Error Resume Next
        If sender.text = "" Then Exit Sub
        If Int(sender.text) < 1 Or Int(sender.text) > 31 Then sender.text = "" : sender.focus() : Exit Sub
        If sender.text.Length < 2 Then sender.text = "0" & sender.text

    End Sub

    Private Sub txt_fm_Leave(sender As Object, e As EventArgs) Handles txt_fm.Leave

        On Error Resume Next
        If sender.text = "" Then Exit Sub
        If Int(sender.text) < 1 Or Int(sender.text) > 12 Then sender.text = "" : sender.focus() : Exit Sub
        If sender.text.Length < 2 Then sender.text = "0" & sender.text

    End Sub

    Private Sub txt_fy_Leave(sender As Object, e As EventArgs) Handles txt_fy.Leave

        If sender.text = "" Then Exit Sub
        If sender.text.Length < 4 Then sender.text = "" : sender.focus()

    End Sub
End Class