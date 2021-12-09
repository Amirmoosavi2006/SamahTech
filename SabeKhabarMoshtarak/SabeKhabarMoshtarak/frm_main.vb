Public Class frm_main

    Private isMouseDown As Boolean = False
    Private mouseOffset As Point

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click

        End

    End Sub

    Private Sub btn_min_Click(sender As Object, e As EventArgs) Handles btn_min.Click

        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub lbl_title_MouseDown(sender As Object, e As MouseEventArgs) Handles lbl_title.MouseDown

        If e.Button = Windows.Forms.MouseButtons.Left Then

            mouseOffset = New Point(-e.X, -e.Y)
            isMouseDown = True

        End If

    End Sub

    Private Sub lbl_title_MouseMove(sender As Object, e As MouseEventArgs) Handles lbl_title.MouseMove

        If isMouseDown Then

            Dim mousePos As Point = Control.MousePosition
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Me.Location = mousePos

        End If

    End Sub

    Private Sub lbl_title_MouseUp(sender As Object, e As MouseEventArgs) Handles lbl_title.MouseUp

        If e.Button = Windows.Forms.MouseButtons.Left Then

            isMouseDown = False

        End If

    End Sub
End Class
