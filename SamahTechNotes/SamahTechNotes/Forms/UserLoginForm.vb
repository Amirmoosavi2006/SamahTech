Public Class UserLoginForm
    Private Sub OkBtn_Click(sender As Object, e As EventArgs) Handles OkBtn.Click

        MainForm.CommandPanel.Enabled = True
        MainForm.MainFormBtn.PerformClick()

    End Sub

    Private Sub UserLoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        UserNameText.Clear()
        PasswordText.Clear()
        UserNameText.Focus()
        Me.CancelButton = MainForm.CloseBtn

    End Sub
End Class
