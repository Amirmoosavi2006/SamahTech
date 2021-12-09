Public Class frm_Mails
    Private Sub btn_return_Click(sender As Object, e As EventArgs) Handles btn_return.Click

        Me.Close()

    End Sub

    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click

        Panel3.Visible = True
        dgv_message.Visible = False

    End Sub

End Class