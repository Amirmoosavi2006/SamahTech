Public Class Form1

    Dim Counter = 0
    Dim Ar(8, 8) As Integer
    Dim Chess1, Chess2 As Integer
    Dim Checker As Boolean = False

    Private Sub CELL_11_Click(sender As Object, e As EventArgs) Handles CELL_11.Click, CELL_12.Click, CELL_13.Click, CELL_14.Click, CELL_15.Click, CELL_16.Click, CELL_17.Click, CELL_18.Click, CELL_21.Click, CELL_22.Click, CELL_23.Click, CELL_24.Click, CELL_25.Click, CELL_26.Click, CELL_27.Click, CELL_28.Click, CELL_31.Click, CELL_32.Click, CELL_33.Click, CELL_34.Click, CELL_35.Click, CELL_36.Click, CELL_37.Click, CELL_38.Click, CELL_41.Click, CELL_42.Click, CELL_43.Click, CELL_44.Click, CELL_45.Click, CELL_46.Click, CELL_47.Click, CELL_48.Click, CELL_51.Click, CELL_52.Click, CELL_53.Click, CELL_54.Click, CELL_55.Click, CELL_56.Click, CELL_57.Click, CELL_58.Click, CELL_61.Click, CELL_62.Click, CELL_63.Click, CELL_64.Click, CELL_65.Click, CELL_66.Click, CELL_67.Click, CELL_68.Click, CELL_71.Click, CELL_72.Click, CELL_73.Click, CELL_74.Click, CELL_75.Click, CELL_76.Click, CELL_77.Click, CELL_78.Click, CELL_81.Click, CELL_82.Click, CELL_83.Click, CELL_84.Click, CELL_85.Click, CELL_86.Click, CELL_87.Click, CELL_88.Click

        If Counter = 8 Then Exit Sub

        If sender.Image Is PictureBox2.Image Then

            sender.Image = PictureBox1.Image
            Counter += 1
            Chess1 = Mid(sender.name, 6, 1)
            Chess1 = Mid(sender.name, 7, 1)
            Ar(Chess1, Chess2) = 1
            Checker = True

        Else

            sender.Image = PictureBox2.Image
            Counter -= 1
            Chess1 = Mid(sender.name, 6, 1)
            Chess1 = Mid(sender.name, 7, 1)
            Ar(Chess1, Chess2) = 0
            Checker = False

        End If

        If Checker = True Then

            For i = 1 To Chess1



            Next

        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
