Public Class frm_main

    Private isMouseDown As Boolean = False
    Private mouseOffset As Point


    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click, btn_exit.Click

        End

    End Sub



    Private Sub lbl_title_MouseDown(sender As Object, e As MouseEventArgs) Handles lbl_title.MouseDown

        If e.Button = Windows.Forms.MouseButtons.Left Then

            mouseOffset = New Point(-e.X, -e.Y)
            isMouseDown = True

        End If

    End Sub

    Private Sub lbl_title_MouseMove(sender As Object, e As MouseEventArgs) Handles lbl_title.MouseMove

        If isMouseDown Then

            Dim mousePos As Point = Control.MousePosition
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Me.Location = mousePos

        End If

    End Sub

    Private Sub lbl_title_MouseUp(sender As Object, e As MouseEventArgs) Handles lbl_title.MouseUp

        If e.Button = Windows.Forms.MouseButtons.Left Then

            isMouseDown = False

        End If

    End Sub


    Private Sub frm_main_Load(sender As Object, e As EventArgs) Handles Me.Load

        With PersianDateTime.Now
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

        lbl_title.Text = "برنامه ریزی کارهای اداری"

        Current_Date = Temp_Year & "/" & Temp_Month & "/" & Temp_Day

        Dim f2 As New frm_login With {
        .TopLevel = False,
        .TopMost = True,
        .StartPosition = FormStartPosition.CenterParent
        }
        Panel_main.Controls.Add(f2)
        For Each obj In Panel1.Controls
            If obj.GetType = GetType(Button) Then
                If Not obj.name = "btn_exit" Then
                    obj.enabled = False
                End If
            End If
        Next
        f2.Show()

    End Sub

    Private Sub btn_min_Click(sender As Object, e As EventArgs) Handles btn_min.Click

        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub btn_new_work_Click(sender As Object, e As EventArgs) Handles btn_new_work.Click

        Dim f2 As New frm_new_work With {
       .TopLevel = False,
       .TopMost = True,
       .StartPosition = FormStartPosition.CenterParent
       }
        Panel_main.Controls.Add(f2)
        For Each obj In Panel1.Controls
            If obj.GetType = GetType(Button) Then
                If Not obj.name = "btn_exit" Then
                    obj.enabled = False
                End If
            End If
        Next
        f2.Show()

    End Sub

    Private Sub btn_find_edit_Click(sender As Object, e As EventArgs) Handles btn_find_edit.Click, btn_track.Click

        Dim f2 As New frm_find With {
       .TopLevel = False,
       .TopMost = True,
       .StartPosition = FormStartPosition.CenterParent
       }
        Panel_main.Controls.Add(f2)
        For Each obj In Panel1.Controls
            If obj.GetType = GetType(Button) Then
                If Not obj.name = "btn_exit" Then
                    obj.enabled = False
                End If
            End If
        Next
        f2.Show()

    End Sub

    Private Sub btn_users_Click(sender As Object, e As EventArgs) Handles btn_users.Click

        Dim f2 As New frm_users With {
      .TopLevel = False,
      .TopMost = True,
      .StartPosition = FormStartPosition.CenterParent
      }
        Panel_main.Controls.Add(f2)
        For Each obj In Panel1.Controls
            If obj.GetType = GetType(Button) Then
                If Not obj.name = "btn_exit" Then
                    obj.enabled = False
                End If
            End If
        Next
        f2.Show()

    End Sub

    Private Sub btn_msg_Click(sender As Object, e As EventArgs) Handles btn_msg.Click

        Dim f2 As New frm_mails With {
      .TopLevel = False,
      .TopMost = True,
      .StartPosition = FormStartPosition.CenterParent
      }
        Panel_main.Controls.Add(f2)
        For Each obj In Panel1.Controls
            If obj.GetType = GetType(Button) Then
                If Not obj.name = "btn_exit" Then
                    obj.enabled = False
                End If
            End If
        Next
        f2.Show()

    End Sub

    Private Sub btn_notes_Click(sender As Object, e As EventArgs) Handles btn_notes.Click

        Dim f2 As New frm_mails With {
      .TopLevel = False,
      .TopMost = True,
      .StartPosition = FormStartPosition.CenterParent
      }
        Panel_main.Controls.Add(f2)
        For Each obj In Panel1.Controls
            If obj.GetType = GetType(Button) Then
                If Not obj.name = "btn_exit" Then
                    obj.enabled = False
                End If
            End If
        Next
        f2.Show()

    End Sub

    Private Sub btn_reports_Click(sender As Object, e As EventArgs) Handles btn_reports.Click

        Dim f2 As New frm_mails With {
   .TopLevel = False,
   .TopMost = True,
   .StartPosition = FormStartPosition.CenterParent
   }
        Panel_main.Controls.Add(f2)
        For Each obj In Panel1.Controls
            If obj.GetType = GetType(Button) Then
                If Not obj.name = "btn_exit" Then
                    obj.enabled = False
                End If
            End If
        Next
        f2.Show()

    End Sub
End Class