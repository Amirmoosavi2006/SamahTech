Public Class frm_Calendar
    Private Sub frm_Calendar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_return_Click(sender As Object, e As EventArgs) Handles btn_return.Click

        Me.Close()

    End Sub

    Private Sub chb_reminder_CheckedChanged(sender As Object, e As EventArgs) Handles chb_reminder.CheckedChanged

        If sender.checked = True Then
            Panel2.Visible = True
        Else
            Panel2.Visible = False
        End If

    End Sub

    Private Sub RemindList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RemindList.SelectedIndexChanged

        If RemindList.GetItemCheckState(3) = CheckState.Checked Then
            PeopleList.Visible = True
        Else
            PeopleList.Visible = False
        End If

    End Sub

    Private Sub txt_min_ValueChanged(sender As Object, e As EventArgs) Handles txt_min.ValueChanged

        If txt_min.Value > 59 Then txt_min.Value = 0
        If txt_min.Value < 0 Then txt_min.Value = 59

    End Sub

    Private Sub txt_h_ValueChanged(sender As Object, e As EventArgs) Handles txt_h.ValueChanged

        If txt_h.Value > 23 Then txt_h.Value = 0
        If txt_h.Value < 0 Then txt_h.Value = 23

    End Sub
End Class