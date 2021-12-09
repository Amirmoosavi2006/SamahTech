Public Class MainForm
    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point
    Private currentchildform As Form
    Dim Today_date, Today_Day, Today_Month, Today_Year As String

    Public Sub TitleLabel_MouseDown(sender As Object, e As MouseEventArgs) Handles _
    TitleLabel.MouseDown, LogoLabel.MouseDown ' Add more handles here (Example: PictureBox1.MouseDown)

        If e.Button = MouseButtons.Left Then
            MoveForm = True
            Me.Cursor = Cursors.NoMove2D
            MoveForm_MousePosition = e.Location
        End If

    End Sub

    Public Sub TitleLabel_MouseMove(sender As Object, e As MouseEventArgs) Handles _
   TitleLabel.MouseMove, LogoLabel.MouseMove ' Add more handles here (Example: PictureBox1.MouseMove)

        If MoveForm Then
            Me.Location += (e.Location - MoveForm_MousePosition)
        End If

    End Sub

    Public Sub TitleLabel_MouseUp(sender As Object, e As MouseEventArgs) Handles _
    TitleLabel.MouseUp, LogoLabel.MouseUp ' Add more handles here (Example: PictureBox1.MouseUp)

        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Me.Cursor = Cursors.Default
        End If

    End Sub

    Private Sub CommandLine_Click(sender As Object, e As EventArgs) Handles CommandLine.Click
        For Each a As Object In CommandPanel.Controls
            If a.GetType Is GetType(Button) Then
                If a.visible = False Then a.visible = True Else a.visible = False
            End If
        Next
    End Sub

    Private Sub OCF(childform As Form)

        If currentchildform IsNot Nothing Then
            currentchildform.Close()
        End If

        currentchildform = childform
        childform.TopLevel = False
        childform.Dock = DockStyle.Fill
        MainPanel.Controls.Add(childform)
        MainPanel.Tag = childform
        MainPanel.BringToFront()
        childform.BringToFront()
        childform.Show()
        TitleLabel.Text = childform.Text

    End Sub

    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click, ExitBtn.Click

        Application.Exit()

    End Sub

    Private Sub NewWorkBtn_Click(sender As Object, e As EventArgs) Handles NewWorkBtn.Click

        FormClose()
        OCF(New NewWorkForm)

    End Sub

    Private Sub MainFormBtn_Click(sender As Object, e As EventArgs) Handles MainFormBtn.Click

        FormClose()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'TimeLabel.Text = PersianDateTime.Now.ToShortTimeString
        Time_Maker()
    End Sub

    Private Sub Time_Maker()

        MLabel.Text = PersianDateTime.Now.Minute
        If MLabel.Text.Length = 1 Then MLabel.Text = "0" & MLabel.Text
        HLabel.Text = PersianDateTime.Now.Hour

    End Sub

    Private Sub FindEditBtn_Click(sender As Object, e As EventArgs) Handles FindEditBtn.Click

        FormClose()
        OCF(New FEForm)

    End Sub

    Private Sub ArchiveBtn_Click(sender As Object, e As EventArgs) Handles ArchiveBtn.Click

        FormClose()
        OCF(New ArchiveForm)

    End Sub

    Private Sub UserAccountBtn_Click(sender As Object, e As EventArgs) Handles UserAccountBtn.Click

        FormClose()
        OCF(New UsersForm)

    End Sub

    Private Sub GroupBtn_Click(sender As Object, e As EventArgs) Handles GroupBtn.Click

        FormClose()
        OCF(New GroupsForm)

    End Sub

    Private Sub FormClose()

        TitleLabel.Text = Me.Text

        Try

            For Each Form As Form In Application.OpenForms
                If Not Form.Name = Me.Name Then

                    Try
                        Form.Close()
                    Catch ex As Exception
                        Return
                    End Try

                End If
            Next

        Catch ex As Exception
            Return
        End Try

    End Sub

    Private Sub MinBtn_Click(sender As Object, e As EventArgs) Handles MinBtn.Click

        Me.WindowState = FormWindowState.Minimized

    End Sub


    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load

        TitleLabel.Text = Me.Text
        DayNameStatus.Text = PersianDateTime.Today.DayName.ToString
        Today_Day = PersianDateTime.Today.Day
        If Today_Day.Length = 1 Then Today_Day = "0" & Today_Day
        Today_Month = PersianDateTime.Today.Month
        If Today_Month.Length = 1 Then Today_Month = "0" & Today_Month
        Today_Year = PersianDateTime.Today.Year
        Today_date = Today_Day & " / " & Today_Month & " / " & Today_Year
        DateStatus.Text = Today_date
        CommandPanel.Enabled = False
        Timer1.Enabled = True

        OCF(New UserLoginForm)

    End Sub
End Class