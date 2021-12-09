Public Class frm_main

    Sub Panel_Visible()

        For Each a As Control In Me.Controls

            If TypeOf a Is Panel Then a.Visible = False

        Next

        Panel1.Visible = True
        Panel2.Visible = True
        Panel3.Visible = True
        Panel4.Visible = True
        Panel5.Visible = True

    End Sub
    Private Sub cmb_exit_Click(sender As Object, e As EventArgs) Handles cmb_exit.Click

        End

    End Sub

    Private Sub cmb_new_work_Click(sender As Object, e As EventArgs) Handles cmb_new_work.Click

        Call Panel_Visible()
        new_work_panel.Visible = True
        new_work_panel.BringToFront()

    End Sub

    Private Sub cmb_find_Click(sender As Object, e As EventArgs) Handles cmb_find.Click

        Call Panel_Visible()
        find_panel.Visible = True
        find_panel.BringToFront()

    End Sub

    Private Sub btn_return_find_Click(sender As Object, e As EventArgs) Handles btn_find_return.Click

        find_panel.Visible = False

    End Sub

    Private Sub btn_new_work_return_Click(sender As Object, e As EventArgs) Handles btn_new_work_return.Click

        new_work_panel.Visible = False

    End Sub
End Class