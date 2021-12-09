Public Class Form2

    Dim today_no, week_day
    Dim month_name As ListBox
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Form1.Show()
        Me.Close()

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        today_no = PersianDateTime.Now.Day
        week_day = PersianDateTime.Now.DayOfWeek
        fill_calendar()

        For i = 4 To 9
            For Each item In Panel1.Controls.Item("Panel" & i).Controls

                If item.text = PersianDateTime.Now.Day.ToString Then item.backcolor = Color.LightGreen

            Next
        Next
        'month_name.Items.Add("فروردین", "اردیبهشت", "خرداد", "تیر", "مرداد", "شهریور", "مهر", "آبان", "آذر", "دی", "بهمن", "اسفند")
        'MsgBox(month_name(0))
    End Sub

    Private Sub btn_month_back_Click(sender As Object, e As EventArgs) Handles btn_month_back.Click

        'For i = 0 To 11
        '    If month_name(i).ToString = lbl_month_name.Text Then
        '        lbl_month_name.Text = month_name(i - 1)
        '        Exit Sub
        '    End If
        'Next

    End Sub

    Sub fill_calendar()


        For i = today_no - 1 To 1 Step -1

            week_day -= 1
            If week_day = -1 Then week_day = 6

        Next

        For i = 4 To 9
            For Each item In Panel1.Controls.Item("Panel" & i).Controls

                item.text = ""

            Next
        Next

        Dim counter = 1

        For i = week_day + 1 To PersianDateTime.Now.DaysInMonth + week_day
            If i < 8 Then
                Panel4.Controls.Item("lbl" & i).Text = counter
                counter += 1
            ElseIf i >= 8 And i < 15 Then
                Panel5.Controls.Item("lbl" & i).Text = counter
                counter += 1
            ElseIf i >= 15 And i < 22 Then
                Panel6.Controls.Item("lbl" & i).Text = counter
                counter += 1
            ElseIf i >= 22 And i < 29 Then
                Panel7.Controls.Item("lbl" & i).Text = counter
                counter += 1
            ElseIf i >= 29 And i < 36 Then
                Panel8.Controls.Item("lbl" & i).Text = counter
                counter += 1
            Else
                Panel9.Controls.Item("lbl" & i).Text = counter
                counter += 1
            End If
        Next

    End Sub


End Class