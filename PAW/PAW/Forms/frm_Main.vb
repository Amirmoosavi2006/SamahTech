Public Class frm_main

    Private Sub ExitMenu_Click(sender As Object, e As EventArgs) Handles ExitMenu.Click, btn_exit.Click

        End

    End Sub

    Private Sub frm_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        With PersianDateTime.Today
            If .Day < 10 Then
                Temp_Day = "0" & .Day
            Else
                Temp_Day = .Day
            End If
            If .Month < 10 Then
                Temp_Month = "0" & .Month
            Else
                Temp_Month = .Month
            End If
            Temp_Year = .Year
            Date_Name = .DayName
        End With

        Active_User.Text = Temp_Username.ToString

        Current_Date = Temp_Year & "/" & Temp_Month & "/" & Temp_Day
        Today_Name.Text = Date_Name
        Today_Date.Text = Current_Date.ToString

    End Sub

    Private Sub NewWorkMenu_Click(sender As Object, e As EventArgs) Handles NewWorkMenu.Click

        Dim f2 As New frm_NewWork
        f2.ShowDialog()

    End Sub

    Private Sub TrackMenu_Click(sender As Object, e As EventArgs) Handles TrackMenu.Click

        Dim f2 As New frm_Track
        f2.ShowDialog()

    End Sub

    Private Sub ReportMenu_Click(sender As Object, e As EventArgs) Handles ReportMenu.Click

        Dim f2 As New frm_Reports
        f2.ShowDialog()

    End Sub

    Private Sub FindEditMenu_Click(sender As Object, e As EventArgs) Handles FindEditMenu.Click

        Dim f2 As New frm_Find
        f2.ShowDialog()

    End Sub

    Private Sub CalendarMenu_Click(sender As Object, e As EventArgs) Handles CalendarMenu.Click

        Dim f2 As New frm_Calendar
        f2.ShowDialog()

    End Sub

    Private Sub MailMenu_Click(sender As Object, e As EventArgs) Handles MailMenu.Click

        Dim f2 As New frm_Mails
        f2.ShowDialog()

    End Sub

    Private Sub ArchiveMenu_Click(sender As Object, e As EventArgs) Handles ArchiveMenu.Click

        Dim f2 As New frm_Find With {
            .Text = "برنامه ریزی کارهای اداری / بایگانی"
        }
        'فیلنر پیام های بایگانی شده در این قسمت مشخص گردد
        f2.ShowDialog()

    End Sub

    Private Sub UsersMenu_Click(sender As Object, e As EventArgs) Handles UsersMenu.Click

        Dim f2 As New frm_Users
        f2.ShowDialog()

    End Sub

    Private Sub NotifyIcon1_MouseClick(sender As Object, e As MouseEventArgs)
        Dim f2 As New frm_Mails
        f2.ShowDialog()
    End Sub

End Class