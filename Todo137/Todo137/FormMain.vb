Public Class FormMain
    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim f2 As New FormLogin
        f2.ShowDialog()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim f2 As New FormWorks
        f2.ShowDialog()

    End Sub
End Class
