Public Class frm_login
    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click

        Dim f_main As New frm_main
        f_main.Show()
        Me.Close()

    End Sub
End Class
