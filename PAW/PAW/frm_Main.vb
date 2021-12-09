Public Class frm_main
    Private Sub ExitMenu_Click(sender As Object, e As EventArgs) Handles ExitMenu.Click

        End

    End Sub

    Private Sub frm_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Active_User = "سیدامیر موسوی"
        Date_Day = PersianDateTime.Today.Day
        Date_Month = PersianDateTime.Today.Month
        Date_Year = PersianDateTime.Today.Year
        Temp_Date = Date_Year & "/" & Date_Month & "/" & Date_Day
        ToolStrip_Today_Name.Text = PersianDateTime.Today.DayName.ToString
        ToolStrip_Date.Text = Temp_Date.ToString

    End Sub

    Private Sub NewWorkMenu_Click(sender As Object, e As EventArgs) Handles NewWorkMenu.Click

        Dim f2 As New frm_NewWork
        f2.ShowDialog()

    End Sub

    Private Sub TrackMenu_Click(sender As Object, e As EventArgs) Handles TrackMenu.Click

        Dim f2 As New frm_Track
        f2.ShowDialog()

    End Sub
End Class