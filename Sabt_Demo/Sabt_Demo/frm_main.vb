Public Class frm_main

    Dim Sabt_check As Boolean
    Sub frm_Reset()

        Panel5.Controls.Clear()

        If Sabt_check = True Then
            Button7.Visible = True
            Button8.Visible = True
            Button9.Visible = True
            Button10.Visible = True
            Button11.Visible = True
        Else
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
            Button10.Visible = False
            Button11.Visible = False
        End If

        Button1.BackColor = Color.SkyBlue
        Button2.BackColor = Color.SkyBlue
        Button3.BackColor = Color.SkyBlue
        Button4.BackColor = Color.SkyBlue
        Button5.BackColor = Color.SkyBlue
        Button6.BackColor = Color.SkyBlue
        Button7.BackColor = Color.LightBlue
        Button8.BackColor = Color.LightBlue
        Button9.BackColor = Color.LightBlue
        Button10.BackColor = Color.LightBlue
        Button11.BackColor = Color.LightBlue

        Sabt_check = False

    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Sabt_check = True

        frm_Reset()

        Button5.BackColor = Color.AliceBlue

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click

        Sabt_check = True
        frm_Reset()

        Dim f2 As New frm_sabt137 With {
       .TopLevel = False,
       .TopMost = True,
       .StartPosition = FormStartPosition.CenterParent
       }
        Panel5.Controls.Add(f2)

        f2.Show()

        Button11.BackColor = Color.Lavender

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        frm_Reset()

        Dim f2 As New frm_peygiri With {
       .TopLevel = False,
       .TopMost = True,
       .StartPosition = FormStartPosition.CenterParent
       }
        Panel5.Controls.Add(f2)

        f2.Show()

        f2.Controls.Item("label1").Text = "شرح پیگیری"

        Button4.BackColor = Color.AliceBlue

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        frm_Reset()

        Dim f2 As New frm_other With {
       .TopLevel = False,
       .TopMost = True,
       .StartPosition = FormStartPosition.CenterParent
       }
        Panel5.Controls.Add(f2)

        f2.Show()

        Button6.BackColor = Color.AliceBlue

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        frm_Reset()

        Dim f2 As New frm_other With {
       .TopLevel = False,
       .TopMost = True,
       .StartPosition = FormStartPosition.CenterParent
       }
        Panel5.Controls.Add(f2)

        f2.Show()

        Button2.BackColor = Color.AliceBlue

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        frm_Reset()

        Dim f2 As New frm_other With {
       .TopLevel = False,
       .TopMost = True,
       .StartPosition = FormStartPosition.CenterParent
       }
        Panel5.Controls.Add(f2)

        f2.Show()

        Button1.BackColor = Color.AliceBlue

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        frm_Reset()

        Dim f2 As New frm_other With {
       .TopLevel = False,
       .TopMost = True,
       .StartPosition = FormStartPosition.CenterParent
       }
        Panel5.Controls.Add(f2)

        f2.Show()

        Button3.BackColor = Color.AliceBlue

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

        Sabt_check = True
        frm_Reset()

        Dim f2 As New frm_sabt1888 With {
       .TopLevel = False,
       .TopMost = True,
       .StartPosition = FormStartPosition.CenterParent
       }
        Panel5.Controls.Add(f2)

        f2.Show()

        Button10.BackColor = Color.Lavender

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

        Sabt_check = True
        frm_Reset()

        Dim f2 As New frm_sabt1888 With {
       .TopLevel = False,
       .TopMost = True,
       .StartPosition = FormStartPosition.CenterParent
       }
        Panel5.Controls.Add(f2)

        f2.Show()

        Button9.BackColor = Color.Lavender

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        Sabt_check = True
        frm_Reset()

        Dim f2 As New frm_sabt1888 With {
       .TopLevel = False,
       .TopMost = True,
       .StartPosition = FormStartPosition.CenterParent
       }
        Panel5.Controls.Add(f2)

        f2.Show()

        Button8.BackColor = Color.Lavender

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        Sabt_check = True
        frm_Reset()

        Dim f2 As New frm_sabt1888 With {
       .TopLevel = False,
       .TopMost = True,
       .StartPosition = FormStartPosition.CenterParent
       }
        Panel5.Controls.Add(f2)

        f2.Show()

        Button7.BackColor = Color.Lavender

    End Sub

    Private Sub frm_main_Load(sender As Object, e As EventArgs) Handles Me.Load

        frm_Reset()

        DataGridView1.Rows.Add()
        DataGridView1.Item(0, 0).Value = "1"
        DataGridView1.Item(1, 0).Value = "90525165498"
        DataGridView1.Item(2, 0).Value = "1400/05/21"
        DataGridView1.Item(3, 0).Value = "نظافت معبر کوچه"
        DataGridView1.Item(4, 0).Value = "باتشکر"
        DataGridView1.Item(5, 0).Value = "خیابان - کوچه - مقابل پلاک32"
        DataGridView1.Item(6, 0).Value = "انجام شد و تایید گردید"
        DataGridView1.Item(7, 0).Value = "انتخاب"

    End Sub
End Class
