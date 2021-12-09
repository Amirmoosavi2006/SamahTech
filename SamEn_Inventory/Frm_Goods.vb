Imports System.Data.OleDb
Public Class Frm_Goods
    Private Sub Frm_Goods_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call Clear_form()
        Call Load_data()

    End Sub

    Sub Clear_form()

        txt_name.Clear()
        txt_fee.Clear()
        txt_min_balance.Clear()
        cmb_category.Text = ""
        cmb_group.Text = ""
        cmb_unit.Text = ""
        btn_edit.Enabled = False
        btn_save.Enabled = True
        Row_for_del = -1
        Row_for_edit = -1
        txt_name.Focus()

    End Sub

    Sub Load_data()

        ds.Reset()
        con = New OleDbConnection(strcon)
        con.Open()

        stroledb = "SELECT * FROM tbl_Unit"
        da = New OleDbDataAdapter(stroledb, con)
        da.Fill(ds, "tbl_Unit")

        con.Close()

        cmb_unit.Items.Clear()

        For i = 0 To ds.Tables(0).Rows.Count - 1

            'On Error Resume Next
            cmb_unit.Items.Add(ds.Tables(0).Rows(i).Item(1).ToString)

        Next

        ds.Reset()
        con = New OleDbConnection(strcon)
        con.Open()

        stroledb = "SELECT * FROM tbl_Group"
        da = New OleDbDataAdapter(stroledb, con)
        da.Fill(ds, "tbl_Group")

        con.Close()

        cmb_group.Items.Clear()

        For i = 0 To ds.Tables(0).Rows.Count - 1

            'On Error Resume Next

            cmb_group.Items.Add(ds.Tables(0).Rows(i).Item(1).ToString)

        Next

        ds.Reset()
        con = New OleDbConnection(strcon)
        con.Open()

        stroledb = "SELECT * FROM tbl_Category"
        da = New OleDbDataAdapter(stroledb, con)
        da.Fill(ds, "tbl_Category")

        con.Close()

        cmb_category.Items.Clear()
        arr_counter = 0

        For i = 0 To ds.Tables(0).Rows.Count - 1

            ' On Error Resume Next

            cmb_category.Items.Add(ds.Tables(0).Rows(i).Item(1).ToString)

            arr_G(i) = ds.Tables(0).Rows(i).Item(2).ToString
            arr_category(i) = ds.Tables(0).Rows(i).Item(1).ToString
            arr_counter += 1
        Next

        ds.Reset()
        con = New OleDbConnection(strcon)
        con.Open()

        stroledb = "SELECT Kname AS [نام کالا], Uname AS [واحد سنجش], Fee AS [قیمت واحد], Min_Balance AS [حداقل موجودی], Cname AS [دسته بندی], Gname AS [گروه کالا] FROM tbl_Goods"
        da = New OleDbDataAdapter(stroledb, con)
        da.Fill(ds, "tbl_Goods")

        con.Close()

        dgv_Store.DataBindings.Clear()
        dgv_Store.DataBindings.Add(New Binding("datasource", ds, "tbl_Goods"))
        dgv_Store.ClearSelection()

    End Sub

    Private Sub btn_return_Click(sender As Object, e As EventArgs) Handles btn_return.Click

        Me.Close()

    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click

        If txt_name.Text.Trim = "" Then

            MsgBox("نام کالا نمی تواند خالی باشد",, "انبارداری سامان")
            txt_name.Focus()
            Exit Sub

        End If

        If cmb_unit.SelectedIndex = -1 Then

            MsgBox("لطفاً واحد سنجش را انتخاب نمائید",, "انبارداری سامان")
            cmb_unit.Focus()
            Exit Sub

        End If

        If cmb_group.SelectedIndex = -1 Then

            MsgBox("لطفاً گروه اقلام را انتخاب نمائید",, "انبارداری سامان")
            cmb_group.Focus()
            Exit Sub

        End If

        If cmb_category.SelectedIndex = -1 Then

            MsgBox("لطفاً دسته بندی را انتخاب نمائید",, "انبارداری سامان")
            cmb_category.Focus()
            Exit Sub

        End If

        If txt_fee.Text.Trim = "" Then txt_fee.Text = "0"
        If txt_min_balance.Text.Trim = "" Then txt_min_balance.Text = "-"

        For i = 0 To dgv_Store.Rows.Count - 1

            If txt_name.Text.Trim = dgv_Store.Item(0, i).value.tostring Then

                MsgBox("نام کالا نمی تواند تکراری باشد",, "انبارداری سامان")
                dgv_Store.Item(0, i).Selected = True
                txt_name.SelectionStart = 0
                txt_name.SelectionLength = Len(txt_name.Text)
                txt_name.Focus()
                Exit Sub

            End If

        Next

        stroledb = "INSERT INTO tbl_Goods (Kname, Uname, Fee, Min_Balance, Gname, Cname) VALUES (@Kname, @Uname, @Fee, @Min_Balance, @Gname, @Cname)"

        com = New OleDbCommand(stroledb, con)
        com.Parameters.Add("@Kname", OleDbType.VarChar).value = txt_name.Text.Trim
        com.Parameters.Add("@Uname", OleDbType.VarChar).value = cmb_unit.Text.Trim
        com.Parameters.Add("@Fee", OleDbType.VarChar).value = txt_fee.Text.Trim
        com.Parameters.Add("@Min_Balance", OleDbType.VarChar).value = txt_min_balance.Text.Trim
        com.Parameters.Add("@Gname", OleDbType.VarChar).value = cmb_group.Text.Trim
        com.Parameters.Add("@Cname", OleDbType.VarChar).value = cmb_category.Text.Trim

        con.Open()
        com.ExecuteNonQuery()
        con.Close()

        Call Clear_form()
        Call Load_data()

    End Sub

    Private Sub dgv_Store_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Store.CellDoubleClick

        If e.RowIndex = -1 Then Exit Sub

        Row_for_edit = e.RowIndex

        txt_name.Text = dgv_Store.Item(0, Row_for_edit).value.tostring
        cmb_unit.Text = dgv_Store.Item(1, Row_for_edit).value.tostring
        txt_fee.Text = dgv_Store.Item(2, Row_for_edit).value.tostring
        txt_min_balance.Text = dgv_Store.Item(3, Row_for_edit).value.tostring
        cmb_group.Text = dgv_Store.Item(5, Row_for_edit).value.tostring
        cmb_category.Text = dgv_Store.Item(4, Row_for_edit).value.tostring

        btn_edit.Enabled = True
        btn_save.Enabled = False
        Temp_String = txt_name.Text.Trim

    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click

        If txt_name.Text.Trim = "" Then

            MsgBox("نام کالا نمی تواند خالی باشد",, "انبارداری سامان")
            txt_name.Focus()
            Exit Sub

        End If

        If cmb_unit.SelectedIndex = -1 Then

            MsgBox("لطفاً واحد سنجش را انتخاب نمائید",, "انبارداری سامان")
            cmb_unit.Focus()
            Exit Sub

        End If

        If cmb_group.SelectedIndex = -1 Then

            MsgBox("لطفاً گروه اقلام را انتخاب نمائید",, "انبارداری سامان")
            cmb_group.Focus()
            Exit Sub

        End If

        If cmb_category.SelectedIndex = -1 Then

            MsgBox("لطفاً دسته بندی را انتخاب نمائید",, "انبارداری سامان")
            cmb_category.Focus()
            Exit Sub

        End If

        If txt_fee.Text.Trim = "" Then txt_fee.Text = "0"
        If txt_min_balance.Text.Trim = "" Then txt_min_balance.Text = "-"

        For i = 0 To dgv_Store.Rows.Count - 1

            If txt_name.Text.Trim = dgv_Store.Item(0, i).value.tostring Then

                If txt_name.Text.Trim = Temp_String Then Exit For

                MsgBox("نام کالا نمی تواند تکراری باشد",, "انبارداری سامان")
                dgv_Store.Item(0, i).Selected = True
                txt_name.SelectionStart = 0
                txt_name.SelectionLength = Len(txt_name.Text)
                txt_name.Focus()
                Exit Sub

            End If

        Next

        stroledb = "UPDATE tbl_Goods SET Kname =@Kname, Uname =@Uname, Fee =@Fee, Min_Balance =@Min_Balance, Gname =@Gname, Cname =@Cname WHERE (tbl_Goods.Kname = '" & Temp_String & "')"

        com = New OleDbCommand(stroledb, con)
        com.Parameters.Add("@Kname", OleDbType.VarChar).value = txt_name.Text.Trim
        com.Parameters.Add("@Uname", OleDbType.VarChar).value = cmb_unit.Text.Trim
        com.Parameters.Add("@Fee", OleDbType.VarChar).value = txt_fee.Text.Trim
        com.Parameters.Add("@Min_Balance", OleDbType.VarChar).value = txt_min_balance.Text.Trim
        com.Parameters.Add("@Gname", OleDbType.VarChar).value = cmb_group.Text.Trim
        com.Parameters.Add("@Cname", OleDbType.VarChar).value = cmb_category.Text.Trim

        con.Open()
        com.ExecuteNonQuery()
        con.Close()

        Call Clear_form()
        Call Load_data()

    End Sub

    Private Sub dgv_Store_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Store.CellClick

        Row_for_del = e.RowIndex

        If btn_edit.Enabled = False And btn_save.Enabled = True And e.RowIndex <> -1 Then
            Temp_String = dgv_Store.Item(0, e.RowIndex).value.tostring
        End If

    End Sub

    Private Sub btn_del_Click(sender As Object, e As EventArgs) Handles btn_del.Click

        If Row_for_del = -1 Then MsgBox("ردیفی برای حذف انتخاب نشده است",, "انبارداری سامان") : Exit Sub

        Dim Dialog_Resault = MsgBox("آیا برای حذف اطمینان دارید؟", vbYesNo, "انبارداری سامان")

        If Dialog_Resault = MsgBoxResult.Yes Then

            stroledb = "DELETE FROM tbl_Goods WHERE (tbl_Goods.Kname = '" & Temp_String & "')"
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

    Private Sub cmb_group_Leave(sender As Object, e As EventArgs) Handles cmb_group.Leave

        If Not cmb_group.SelectedIndex = -1 Then

            cmb_category.Items.Clear()

            For i = 0 To arr_counter - 1

                If arr_G(i).ToString = cmb_group.Text.ToString Then

                    cmb_category.Items.Add(arr_category(i).ToString)

                End If

            Next

        End If

    End Sub

    Private Sub cmb_category_Leave(sender As Object, e As EventArgs) Handles cmb_category.Leave

        If Not cmb_category.SelectedIndex = -1 Then

            'cmb_group.Items.Clear()

            For i = 0 To arr_counter - 1

                If arr_category(i).ToString = cmb_category.Text.ToString Then

                    cmb_group.Text = arr_G(i).ToString
                    Exit For

                End If

            Next

        End If

    End Sub


End Class