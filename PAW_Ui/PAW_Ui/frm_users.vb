Imports System.Data.OleDb

Public Class frm_users

    Dim Role_no As Integer
    Dim Temp_Attach_Name, Pic_Adres As String

    Sub Clear_Form()

        txt_email.Clear()
        txt_fname.Clear()
        txt_inphone.Clear()
        txt_lname.Clear()
        txt_mobile.Clear()
        txt_password.Clear()
        txt_phone.Clear()
        txt_semat.Clear()
        txt_username.Clear()

        rbtn_2.Checked = True
        pic_user.Image = pic_def.Image
        Role_no = 2
        Temp_Attach_Name = ""
        Pic_Adres = ""
        btn_edit.Enabled = False
        btn_save.Enabled = True

        ActiveControl = txt_fname

    End Sub

    Sub Load_Data()

        ds.Reset()
        con.Open()

        stroledb = "SELECT * FROM tbl_users"
        da = New OleDbDataAdapter(stroledb, con)
        da.Fill(ds, "tbl_users")

        dgv_users.Rows.Clear()

        With ds.Tables("tbl_users")
            For i = 0 To .Rows.Count - 1
                dgv_users.Rows.Add()
                dgv_users.Item(0, i).Value = .Rows(i).Item("first_name")
                dgv_users.Item(1, i).Value = .Rows(i).Item("last_name")
                dgv_users.Item(2, i).Value = .Rows(i).Item("semat")
                Select Case .Rows(i).Item("user_role")
                    Case 1
                        dgv_users.Item(3, i).Value = "مدیر"
                    Case 2
                        dgv_users.Item(3, i).Value = "کارشناس فنی"
                    Case 3
                        dgv_users.Item(3, i).Value = "کارشناس آمار"
                End Select
                dgv_users.Item(4, i).Value = .Rows(i).Item("user_name")
            Next
        End With

        con.Close()

    End Sub

    Private Sub frm_users_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Clear_Form()
        Load_Data()

        frm_main.lbl_title.Text = "برنامه ریزی کارهای اداری / اطلاعات کاربران"

    End Sub

    Private Sub btn_home_Click(sender As Object, e As EventArgs) Handles btn_home.Click

        frm_main.lbl_title.Text = "برنامه ریزی کارهای اداری / صفحه اصلی"

        For Each obj In frm_main.Panel1.Controls

            obj.enabled = True

        Next

        Me.Close()

    End Sub

    Private Sub btn_attach_Click(sender As Object, e As EventArgs) Handles btn_attach.Click

        Dim ofd As New OpenFileDialog With {
       .RestoreDirectory = False,
       .Multiselect = False,
       .Title = "PAW",
       .Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG"
      }
        ofd.ShowDialog()

        If ofd.FileName = "" Then
            Exit Sub
        Else
            Try
                pic_user.Image = Image.FromFile(ofd.FileName)
                Pic_Adres = ofd.FileName.ToString
            Catch ex As Exception
                Pic_Adres = ""
                pic_user.Image = pic_def.Image
            End Try
        End If

    End Sub

    Private Sub btn_attach_del_Click(sender As Object, e As EventArgs) Handles btn_attach_del.Click

        pic_user.Image = pic_def.Image

    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click

        If txt_fname.Text.Trim = "" Or txt_lname.Text.Trim = "" Or txt_username.Text.Trim = "" Or txt_password.Text.Trim = "" Then
            MessageBox.Show("پر نمودن فیلدهای ستاره دار الزامی می باشند", "PAW", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        With ds.Tables("tbl_users")
            For i = 0 To .Rows.Count - 1
                If .Rows(i).Item("user_name").ToString = txt_username.Text.Trim Then
                    MessageBox.Show("نام کاربری شما از قبل رزرو شده است", "PAW", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txt_username.SelectAll()
                    txt_username.Focus()
                    Exit Sub
                End If
            Next
        End With

        If IO.Directory.Exists(My.Application.Info.DirectoryPath & "\UserPics\") = False Then
            IO.Directory.CreateDirectory(My.Application.Info.DirectoryPath & "\UserPics\")
        End If

        Temp_Attach_Name = txt_fname.Text & "_" & txt_lname.Text

        If Pic_Adres = "" Then
            Temp_Attach_Name = "def"
        Else
            IO.File.Copy(Pic_Adres, My.Application.Info.DirectoryPath & "\UserPics\" & Temp_Attach_Name, True)
        End If

        stroledb = "INSERT INTO tbl_users (first_name, last_name, semat, mobile_no, phone_no, inside_no, user_role, user_name, user_pass, pic_adres, e_mail) VALUES (@first_name, @last_name, @semat, @mobile_no, @phone_no, @inside_no, @user_role, @user_name, @user_pass, @pic_adres, @e_mail)"

        If Role_no < 1 Or Role_no > 3 Then Role_no = -1
        If Temp_Attach_Name.Trim = "" Then Temp_Attach_Name = "def"

        com = New OleDbCommand(stroledb, con)
        com.Parameters.Add("@first_name", OleDbType.VarChar).Value = txt_fname.Text.Trim
        com.Parameters.Add("@last_name", OleDbType.VarChar).Value = txt_lname.Text.Trim
        com.Parameters.Add("@semat", OleDbType.VarChar).Value = txt_semat.Text.Trim
        com.Parameters.Add("@mobile_no", OleDbType.VarChar).Value = txt_mobile.Text.Trim
        com.Parameters.Add("@phone_no", OleDbType.VarChar).Value = txt_phone.Text.Trim
        com.Parameters.Add("@inside_no", OleDbType.VarChar).Value = txt_inphone.Text.Trim
        com.Parameters.Add("@user_role", OleDbType.VarChar).Value = Role_no
        com.Parameters.Add("@user_name", OleDbType.VarChar).Value = txt_username.Text.Trim
        com.Parameters.Add("@user_pass", OleDbType.VarChar).Value = txt_password.Text.Trim
        com.Parameters.Add("@pic_adres", OleDbType.VarChar).Value = Temp_Attach_Name
        com.Parameters.Add("@e_mail", OleDbType.VarChar).Value = txt_email.Text.Trim

        con.Open()
        com.ExecuteNonQuery()
        con.Close()

        Clear_Form()
        Load_Data()

    End Sub

    Private Sub rbtn_1_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn_1.CheckedChanged, rbtn_2.CheckedChanged, rbtn_3.CheckedChanged

        If rbtn_1.Checked = True Then
            Role_no = 1
        ElseIf rbtn_2.Checked = True Then
            Role_no = 2
        Else
            Role_no = 3
        End If

    End Sub

    Private Sub dgv_users_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgv_users.CellFormatting

        For i = 0 To dgv_users.RowCount - 1

            If i Mod 2 = 0 Then
                dgv_users.Rows(i).DefaultCellStyle.BackColor = Color.Cyan
            Else
                dgv_users.Rows(i).DefaultCellStyle.BackColor = Color.LightCyan
            End If

        Next

    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click

        Clear_Form()
        Load_Data()


    End Sub

    Private Sub btn_del_all_Click(sender As Object, e As EventArgs) Handles btn_del_all.Click

        With dgv_users

            If .SelectedRows.Count = 0 Then Exit Sub

            If MessageBox.Show("این عملیات غیرقابل بازگشت می باشد" & vbNewLine & "آیا برای حذف اطمینان دارید؟", "PAW", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign) = DialogResult.No Then

                Exit Sub

            Else

                stroledb = "DELETE FROM tbl_users WHERE (tbl_users.user_name = '" & .Item(4, .CurrentRow.Index).Value & "')"
                com = New OleDbCommand(stroledb, con)
                con.Open()
                com.ExecuteNonQuery()
                con.Close()

                .Rows.RemoveAt(.CurrentRow.Index)

            End If

        End With

    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click

        If txt_fname.Text.Trim = "" Or txt_lname.Text.Trim = "" Or txt_username.Text.Trim = "" Or txt_password.Text.Trim = "" Then
            MessageBox.Show("پر نمودن فیلدهای ستاره دار الزامی می باشند", "PAW", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Not txt_username.Text.Trim = dgv_users.Item(4, dgv_users.CurrentRow.Index).Value Then
            With ds.Tables("tbl_users")
                For i = 0 To .Rows.Count - 1
                    If .Rows(i).Item("user_name").ToString = txt_username.Text.Trim Then
                        MessageBox.Show("نام کاربری شما از قبل رزرو شده است", "PAW", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txt_username.SelectAll()
                        txt_username.Focus()
                        Exit Sub
                    End If
                Next
            End With
        End If

        If IO.Directory.Exists(My.Application.Info.DirectoryPath & "\UserPics\") = False Then
            IO.Directory.CreateDirectory(My.Application.Info.DirectoryPath & "\UserPics\")
        End If

        Temp_Attach_Name = txt_fname.Text & "_" & txt_lname.Text

        If Pic_Adres = "" Then
            Temp_Attach_Name = "def"
        Else
            IO.File.Copy(Pic_Adres, My.Application.Info.DirectoryPath & "\UserPics\" & Temp_Attach_Name, True)
        End If

        stroledb = "UPDATE tbl_users SET first_name =@first_name, last_name =@last_name, semat =@semat, mobile_no =@mobile_no, phone_no =@phone_no, inside_no =@inside_no, user_role =@user_role, user_name =@user_name, user_pass =@user_pass, pic_adres =@pic_adres, e_mail =@e_mail WHERE (tbl_users.user_name = '" & dgv_users.Item(4, dgv_users.CurrentRow.Index).Value & "')"

        If Role_no < 1 Or Role_no > 3 Then Role_no = -1
        If Temp_Attach_Name.Trim = "" Then Temp_Attach_Name = "def"

        com = New OleDbCommand(stroledb, con)
        com.Parameters.Add("@first_name", OleDbType.VarChar).Value = txt_fname.Text.Trim
        com.Parameters.Add("@last_name", OleDbType.VarChar).Value = txt_lname.Text.Trim
        com.Parameters.Add("@semat", OleDbType.VarChar).Value = txt_semat.Text.Trim
        com.Parameters.Add("@mobile_no", OleDbType.VarChar).Value = txt_mobile.Text.Trim
        com.Parameters.Add("@phone_no", OleDbType.VarChar).Value = txt_phone.Text.Trim
        com.Parameters.Add("@inside_no", OleDbType.VarChar).Value = txt_inphone.Text.Trim
        com.Parameters.Add("@user_role", OleDbType.VarChar).Value = Role_no
        com.Parameters.Add("@user_name", OleDbType.VarChar).Value = txt_username.Text.Trim
        com.Parameters.Add("@user_pass", OleDbType.VarChar).Value = txt_password.Text.Trim
        com.Parameters.Add("@pic_adres", OleDbType.VarChar).Value = Temp_Attach_Name
        com.Parameters.Add("@e_mail", OleDbType.VarChar).Value = txt_email.Text.Trim

        con.Open()
        com.ExecuteNonQuery()
        con.Close()

        Clear_Form()
        Load_Data()

    End Sub

    Private Sub dgv_users_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_users.CellDoubleClick

        If e.RowIndex = -1 Then Exit Sub

        With ds.Tables("tbl_users")
            For i = 0 To .Rows.Count - 1
                If .Rows(i).Item("user_name").ToString = dgv_users.Item(4, e.RowIndex).Value.ToString Then
                    txt_fname.Text = .Rows(i).Item("first_name").ToString
                    txt_lname.Text = .Rows(i).Item("last_name").ToString
                    txt_semat.Text = .Rows(i).Item("semat").ToString
                    txt_mobile.Text = .Rows(i).Item("mobile_no").ToString
                    txt_phone.Text = .Rows(i).Item("phone_no").ToString
                    txt_inphone.Text = .Rows(i).Item("inside_no").ToString
                    txt_username.Text = .Rows(i).Item("user_name").ToString
                    txt_password.Text = .Rows(i).Item("user_pass").ToString
                    txt_email.Text = .Rows(i).Item("e_mail").ToString
                    Select Case .Rows(i).Item("user_role")
                        Case 1
                            rbtn_1.Checked = True
                        Case 2
                            rbtn_2.Checked = True
                        Case 3
                            rbtn_3.Checked = True
                    End Select
                    Try
                        pic_user.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\UserPics\" & .Rows(i).Item("pic_adres").ToString)
                    Catch ex As Exception
                        pic_user.Image = pic_def.Image
                    End Try
                End If
            Next
        End With

        btn_edit.Enabled = True
        btn_save.Enabled = False

    End Sub
End Class