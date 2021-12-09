Imports System.Data.OleDb

Public Class Frm_customers
    Private Sub Frm_customers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call Clear_form()
        Call Load_data()

    End Sub

    Sub Clear_form()

        txt_name.Clear()
        txt_adres.Clear()
        txt_phone.Clear()
        btn_edit.Enabled = False
        btn_save.Enabled = True
        txt_name.Focus()

    End Sub

    Sub Load_data()

        ds.Reset()
        con = New OleDbConnection(strcon)
        con.Open()

        stroledb = "SELECT S_name AS [نام تحویل گیرنده], S_phone AS [شماره تماس], S_adres AS آدرس FROM tbl_Customer"
        da = New OleDbDataAdapter(stroledb, con)
        da.Fill(ds, "tbl_Customer")

        con.Close()

        dgv_Store.DataBindings.Clear()
        dgv_Store.DataBindings.Add(New Binding("datasource", ds, "tbl_Customer"))
        dgv_Store.ClearSelection()

    End Sub

    Private Sub btn_return_Click(sender As Object, e As EventArgs) Handles btn_return.Click

        Me.Close()

    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click

        If txt_name.Text.Trim = "" Then

            MsgBox("نام تحویل گیرنده نمی تواند خالی باشد",, "انبارداری سامان")
            txt_name.Focus()
            Exit Sub

        End If

        If txt_phone.Text.Trim = "" Then txt_phone.Text = "0"
        If txt_adres.Text.Trim = "" Then txt_adres.Text = "-"

        For i = 0 To dgv_Store.Rows.Count - 1

            If txt_name.Text.Trim = dgv_Store.Item(0, i).Value.ToString Then

                MsgBox("نام تحویل گیرنده نمی تواند تکراری باشد",, "انبارداری سامان")
                dgv_Store.Item(0, i).Selected = True
                txt_name.SelectionStart = 0
                txt_name.SelectionLength = Len(txt_name.Text)
                txt_name.Focus()
                Exit Sub

            End If

        Next

        stroledb = "INSERT INTO tbl_Customer (S_name, S_phone, S_adres) VALUES (@S_name, @S_phone, @S_adres)"

        com = New OleDbCommand(stroledb, con)
        com.Parameters.Add("@S_name", OleDbType.VarChar).Value = txt_name.Text.Trim
        com.Parameters.Add("@S_phone", OleDbType.VarChar).Value = txt_phone.Text.Trim
        com.Parameters.Add("@S_adres", OleDbType.VarChar).Value = txt_adres.Text.Trim

        con.Open()
        com.ExecuteNonQuery()
        con.Close()

        Call Clear_form()
        Call Load_data()

    End Sub



    Private Sub dgv_Store_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Store.CellDoubleClick

        If e.RowIndex = -1 Then Exit Sub

        Row_for_edit = e.RowIndex

        txt_name.Text = dgv_Store.Item(0, Row_for_edit).Value.ToString
        txt_phone.Text = dgv_Store.Item(1, Row_for_edit).Value.ToString
        txt_adres.Text = dgv_Store.Item(2, Row_for_edit).Value.ToString

        btn_edit.Enabled = True
        btn_save.Enabled = False
        Temp_String = txt_name.Text.Trim

    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click

        If txt_name.Text.Trim = "" Then

            MsgBox("نام تحویل گیرنده نمی تواند خالی باشد",, "انبارداری سامان")
            txt_name.Focus()
            Exit Sub

        End If

        If txt_phone.Text.Trim = "" Then txt_phone.Text = "0"
        If txt_adres.Text.Trim = "" Then txt_adres.Text = "-"

        For i = 0 To dgv_Store.Rows.Count - 1

            If txt_name.Text.Trim = dgv_Store.Item(0, i).Value.ToString Then

                If txt_name.Text.Trim = Temp_String Then Exit For

                MsgBox("نام تحویل گیرنده نمی تواند تکراری باشد",, "انبارداری سامان")
                dgv_Store.Item(0, i).Selected = True
                txt_name.SelectionStart = 0
                txt_name.SelectionLength = Len(txt_name.Text)
                txt_name.Focus()
                Exit Sub

            End If

        Next

        stroledb = "UPDATE tbl_Customer SET S_name = @S_name, S_phone = @S_phone, S_adres = @S_adres WHERE (tbl_Customer.S_name = '" & Temp_String & "')"

        com = New OleDbCommand(stroledb, con)
        com.Parameters.Add("@S_name", OleDbType.VarChar).Value = txt_name.Text.Trim
        com.Parameters.Add("@S_phone", OleDbType.VarChar).Value = txt_phone.Text.Trim
        com.Parameters.Add("@S_adres", OleDbType.VarChar).Value = txt_adres.Text.Trim

        con.Open()
        com.ExecuteNonQuery()
        con.Close()

        Call Clear_form()
        Call Load_data()

    End Sub


    Private Sub dgv_Store_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Store.CellClick

        Row_for_del = e.RowIndex

        If btn_edit.Enabled = False And btn_save.Enabled = True And e.RowIndex <> -1 Then
            Temp_String = dgv_Store.Item(0, e.RowIndex).Value.ToString
        End If

    End Sub

    Private Sub btn_del_Click(sender As Object, e As EventArgs) Handles btn_del.Click

        If Row_for_del = -1 Then MsgBox("ردیفی برای حذف انتخاب نشده است",, "انبارداری سامان") : Exit Sub

        Dim Dialog_Resault = MsgBox("آیا برای حذف اطمینان دارید؟", vbYesNo, "انبارداری سامان")

        If Dialog_Resault = MsgBoxResult.Yes Then

            stroledb = "DELETE FROM tbl_Customer WHERE (tbl_Customer.S_name = '" & Temp_String & "')"
            com = New OleDbCommand(stroledb, con)
            con.Open()
            com.ExecuteNonQuery()
            con.Close()

            Call Clear_form()
            Call Load_data()

        End If

    End Sub

    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click

        Call Clear_form()
        Call Load_data()

    End Sub
End Class