Public Class ArchiveForm
    Private Sub FollowUpBtn_Click(sender As Object, e As EventArgs) Handles FollowUpBtn.Click

        FollowUpBox.Enabled = True

    End Sub

    Private Sub ArchiveReturnBtn_Click(sender As Object, e As EventArgs) Handles ArchiveReturnBtn.Click

        MainForm.MainFormBtn.PerformClick()

    End Sub

    Private Sub CancelFollowUpBtn_Click(sender As Object, e As EventArgs) Handles CancelFollowUpBtn.Click

        For Each Obj In FollowUpBox.Controls
            Try
                Obj.clear()
            Catch ex As Exception
                'Return
            End Try
        Next

        FollowUpBox.Enabled = False

    End Sub
End Class