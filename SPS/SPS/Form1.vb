Public Class Form1
    Dim Chooses As Integer = -1
    Dim rnd_number
    Dim rsult = -1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        reset_form()

    End Sub
    Sub reset_form()

        b_computer.Image = SPS.My.Resources.M_83
        Chooses = -1
        b_paper.Enabled = False
        b_scissor.Enabled = False
        b_stone.Enabled = False
        lbl_computer.Text = 0
        lbl_user.Text = 0

    End Sub

    Private Sub btn_start_Click(sender As Object, e As EventArgs) Handles btn_start.Click

        Call reset_form()
        b_paper.Enabled = True
        b_scissor.Enabled = True
        b_stone.Enabled = True

    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click

        End

    End Sub
    Sub play_game()

        Randomize()

        rnd_number = CInt(Math.Ceiling(Rnd() * 3))
        Select Case rnd_number
            Case 1
                b_computer.Image = My.Resources.Stone
            Case 2
                b_computer.Image = My.Resources.Paper
            Case 3
                b_computer.Image = My.Resources.Scissors
        End Select

    End Sub
    Sub end_result()

        If rsult = 0 Then
            MsgBox("It's a tie...")
            Exit Sub
        End If

        If rsult = Chooses Then
            lbl_user.Text += 1
        ElseIf rsult = rnd_number Then
            lbl_computer.Text += 1
        End If

    End Sub

    Private Sub b_stone_Click(sender As Object, e As EventArgs) Handles b_stone.Click

        Chooses = 1
        Call play_game()
        rsult = check_play(Chooses, rnd_number)
        Call end_result()

    End Sub

    Private Sub b_paper_Click(sender As Object, e As EventArgs) Handles b_paper.Click

        Chooses = 2
        Call play_game()
        rsult = check_play(Chooses, rnd_number)
        Call end_result()

    End Sub

    Private Sub b_scissor_Click(sender As Object, e As EventArgs) Handles b_scissor.Click

        Chooses = 3
        Call play_game()
        rsult = check_play(Chooses, rnd_number)
        Call end_result()

    End Sub
    Public Function check_play(x, y)

        If x = y Then Return 0

        If (x = 1 And y = 2) Or (x = 2 And y = 1) Then Return 2
        If (x = 1 And y = 3) Or (x = 3 And y = 1) Then Return 1
        If (x = 3 And y = 2) Or (x = 2 And y = 3) Then Return 3

        Return 0

    End Function
End Class
