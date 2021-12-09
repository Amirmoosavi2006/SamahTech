Public Class UsersForm
    Private Sub ReturnBtn_Click(sender As Object, e As EventArgs) Handles ReturnBtn.Click

        MainForm.MainFormBtn.PerformClick()

    End Sub

    Private Sub UsersForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For Each obj In GroupBox1.Controls
            Try
                obj.clear()
            Catch ex As Exception

            End Try
        Next

    End Sub
End Class