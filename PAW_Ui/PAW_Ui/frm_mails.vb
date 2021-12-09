Public Class frm_mails
    Private Sub btn_home_Click(sender As Object, e As EventArgs) Handles btn_home.Click

        frm_main.lbl_title.Text = "برنامه ریزی کارهای اداری / صفحه اصلی"

        For Each obj In frm_main.Panel1.Controls

            obj.enabled = True

        Next

        Me.Close()

    End Sub

    Private Sub frm_mails_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        frm_main.lbl_title.Text = "برنامه ریزی کارهای اداری / پیام ها"

    End Sub
End Class