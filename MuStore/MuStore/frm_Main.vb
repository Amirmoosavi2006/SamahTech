Public Class frm_Main
    Private Sub btn_Reports_Click(sender As Object, e As EventArgs) Handles btn_Reports.Click

        ContextMenuStrip1.Show(MousePosition.X, MousePosition.Y)

    End Sub

    Private Sub btn_Setting_Click(sender As Object, e As EventArgs) Handles btn_Setting.Click

        ContextMenuStrip2.Show(MousePosition.X, MousePosition.Y)

    End Sub

    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click

        End

    End Sub

    Private Sub btn_Add_Click(sender As Object, e As EventArgs) Handles btn_Add.Click

        AddPanel.Visible = True

    End Sub

End Class
