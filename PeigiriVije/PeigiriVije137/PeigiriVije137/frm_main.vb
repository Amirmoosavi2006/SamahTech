Public Class frm_main



    Private Sub M_before_Click(sender As Object, e As EventArgs) Handles M_before.Click

        frm_Before.MdiParent = Me
        frm_Before.Show()

    End Sub

    Private Sub frm_main_Load(sender As Object, e As EventArgs) Handles Me.Load

        Temp_Date = PersianDateTime.Today.Year
        If PersianDateTime.Today.Month < 10 Then
            Temp_Date &= "/0" & PersianDateTime.Today.Month
        Else
            Temp_Date &= "/" & PersianDateTime.Today.Month
        End If
        If PersianDateTime.Today.Day < 10 Then
            Temp_Date &= "/0" & PersianDateTime.Today.Day
        Else
            Temp_Date &= "/" & PersianDateTime.Today.Day
        End If

        ts_date.Text = "امروز " & PersianDateTime.Today.DayName & " مورخ: " & Temp_Date
        MenuStrip1.MdiWindowListItem = Nothing
        Frm_Login.ShowDialog()
        ts_username.Text = User_Name
        If User_Role = True Then
            ts_Role.Text = "مدیر سیستم"
        Else
            ts_Role.Text = "کارشناس بازدید"
        End If

    End Sub

    Private Sub M_exit_Click(sender As Object, e As EventArgs) Handles M_exit.Click

        Try
            End
        Catch ex As Exception
            Me.Close()
        End Try

    End Sub

    Private Sub M_after_Click(sender As Object, e As EventArgs) Handles M_after.Click

        frm_After.MdiParent = Me
        frm_After.Show()

    End Sub

    Private Sub M_Users_Click(sender As Object, e As EventArgs) Handles M_Users.Click

        Frm_Users.MdiParent = Me
        Frm_Users.Show()

    End Sub
End Class