Public Class frm_login


    Private Sub txt_username_GotFocus(sender As Object, e As EventArgs) Handles txt_username.GotFocus

        With txt_username
            If .Text.ToLower = "username".ToLower Then
                .Text = ""
            End If
        End With

    End Sub


    Private Sub txt_username_LostFocus(sender As Object, e As EventArgs) Handles txt_username.LostFocus

        With txt_username
            If .Text = "" Then
                .Text = "UserName"
            End If
        End With

    End Sub
End Class