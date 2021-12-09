Public Class frm_main

    Private isMouseDown As Boolean = False
    Private mouseOffset As Point

    Private Sub lbl_title_MouseDown(sender As Object, e As MouseEventArgs) Handles panel_title.MouseDown, lbl_lotus_name.MouseDown

        If e.Button = Windows.Forms.MouseButtons.Left Then

            mouseOffset = New Point(-e.X, -e.Y)
            isMouseDown = True

        End If

    End Sub

    Private Sub lbl_title_MouseMove(sender As Object, e As MouseEventArgs) Handles panel_title.MouseMove, lbl_lotus_name.MouseMove

        If isMouseDown Then

            Dim mousePos As Point = Control.MousePosition
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Me.Location = mousePos

        End If

    End Sub

    Private Sub lbl_title_MouseUp(sender As Object, e As MouseEventArgs) Handles panel_title.MouseUp, lbl_lotus_name.MouseUp

        If e.Button = Windows.Forms.MouseButtons.Left Then

            isMouseDown = False

        End If

    End Sub

    Private Sub btn_min_Click(sender As Object, e As EventArgs) Handles btn_min.Click

        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click

        End

    End Sub

    Private Sub frm_main_Load(sender As Object, e As EventArgs) Handles Me.Load

        With panel_main
            frm_login.TopLevel = False
            .Controls.Add(frm_login)
            frm_login.Left = (.Width / 2) - (frm_login.Width / 2)
            frm_login.Top = (.Height / 2) - (frm_login.Height / 2)
            frm_login.Show()
        End With

    End Sub
End Class
