Public Class frm_user_login
    Dim check_pass As Boolean = False
    Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles TextBox1.GotFocus, TextBox2.GotFocus
        sender.BackColor = Color.LightBlue
    End Sub

    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TextBox1.LostFocus, TextBox2.LostFocus
        sender.BackColor = Color.White
    End Sub

    Private Sub PictureBox1_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox1.MouseEnter, PictureBox2.MouseEnter
        sender.BorderStyle = BorderStyle.FixedSingle
    End Sub
    Private Sub PictureBox1_MouseDown(sender As Object, e As EventArgs) Handles PictureBox1.MouseDown, PictureBox2.MouseDown
        sender.BorderStyle = BorderStyle.Fixed3D
    End Sub
    Private Sub PictureBox1_MouseUp(sender As Object, e As EventArgs) Handles PictureBox1.MouseUp, PictureBox2.MouseUp
        sender.BorderStyle = BorderStyle.FixedSingle
    End Sub
    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave, PictureBox2.MouseLeave
        sender.BorderStyle = BorderStyle.None
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged, TextBox2.TextChanged
        If (TextBox1.Text = "Admin" Or TextBox1.Text = "admin") And TextBox2.Text = "1234" Then
            PictureBox1.Image = My.Resources.lock2
            check_pass = True
        Else
            PictureBox1.Image = My.Resources.lock1
            check_pass = False
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If check_pass = False Then Exit Sub
        Dim fo_main As New frm_main
        fo_main.Show()
        Me.Close()
    End Sub
End Class
