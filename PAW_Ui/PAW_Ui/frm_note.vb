Public Class frm_note
    Private Sub frm_note_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        frm_main.lbl_title.Text = "برنامه ریزی کارهای اداری / یادداشت ها"

        Dim day_count, counter, days_no
        days_no = 0
        Dim days = PersianDateTime.Now.DayOfWeek

        For i = Int(PersianDateTime.Now.Day) - 1 To 1 Step -1
            If i = 1 Then days -= 1 : Exit For
            days -= 1
            If days = -1 Then days = 6
        Next

        day_count = days
        counter = 0

        Dim l1 As New Label With {
        .Text = "شنبه",
        .Parent = tlp,
        .BackColor = Color.LightBlue,
        .TextAlign = ContentAlignment.MiddleCenter,
        .Dock = DockStyle.Fill
        }
        Dim l2 As New Label With {
        .Text = "یکشنبه",
        .Parent = tlp,
        .BackColor = Color.LightBlue,
        .TextAlign = ContentAlignment.MiddleCenter,
        .Dock = DockStyle.Fill
        }
        Dim l3 As New Label With {
        .Text = "دوشنبه",
        .Parent = tlp,
        .BackColor = Color.LightBlue,
        .TextAlign = ContentAlignment.MiddleCenter,
        .Dock = DockStyle.Fill
        }
        Dim l4 As New Label With {
        .Text = "سه شنبه",
        .Parent = tlp,
        .BackColor = Color.LightBlue,
        .TextAlign = ContentAlignment.MiddleCenter,
        .Dock = DockStyle.Fill
        }
        Dim l5 As New Label With {
        .Text = "چهارشنبه",
        .Parent = tlp,
        .BackColor = Color.LightBlue,
        .TextAlign = ContentAlignment.MiddleCenter,
        .Dock = DockStyle.Fill
        }
        Dim l6 As New Label With {
        .Text = "پنج شنبه",
        .Parent = tlp,
        .BackColor = Color.LightBlue,
        .TextAlign = ContentAlignment.MiddleCenter,
        .Dock = DockStyle.Fill
        }
        Dim l7 As New Label With {
        .Text = "جمعه",
        .Parent = tlp,
        .BackColor = Color.LightBlue,
        .TextAlign = ContentAlignment.MiddleCenter,
        .Dock = DockStyle.Fill
        }
        For j = 1 To day_count
            Dim emptylabel As New Label With {
            .Name = "e" & j.ToString,
            .Text = " ",
            .Parent = tlp,
            .BackColor = Color.Red,
            .TextAlign = ContentAlignment.MiddleCenter,
            .Dock = DockStyle.Fill
            }
        Next
        For i = day_count To day_count + PersianDateTime.GetDaysInMonth(PersianDateTime.Now.Year, PersianDateTime.Now.Month) - 1
            Dim newlabel As New Label With {
            .Name = "ll" & days_no + 1,
            .Text = counter + 1,
            .Parent = tlp,
            .BackColor = Color.LightGreen,
            .AutoSize = True,
            .Dock = DockStyle.Fill,
            .TextAlign = ContentAlignment.MiddleCenter
             }
            counter += 1
            days_no += 1
        Next

        tlp.Controls.Item("ll" & PersianDateTime.Now.Day).BackColor = Color.Green

    End Sub

    Private Sub btn_home_Click(sender As Object, e As EventArgs) Handles btn_home.Click

        frm_main.lbl_title.Text = "برنامه ریزی کارهای اداری / صفحه اصلی"

        For Each obj In frm_main.Panel1.Controls

            obj.enabled = True

        Next

        Me.Close()

    End Sub


End Class