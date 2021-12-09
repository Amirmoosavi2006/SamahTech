Imports System.Data.OleDb

Public Class Frm_GInS
    Private Sub Frm_GInS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call Clear_form()
        Call Load_data()

    End Sub

    Sub Clear_form()

        cmb_Kname.Text = ""
        cmb_Store.Text = ""
        txt_Category.Clear()
        txt_Exp_day.Clear()
        txt_Exp_month.Clear()
        txt_Exp_year.Clear()
        txt_Group.Clear()
        txt_Kcount.Clear()
        txt_Locating.Clear()
        txt_Unit.Clear()
        btn_edit.Enabled = False
        btn_save.Enabled = True
        Row_for_del = -1
        Row_for_edit = -1
        cmb_Kname.Focus()

    End Sub

    Sub Load_data()

        ds.Reset()
        con = New OleDbConnection(strcon)
        con.Open()

        stroledb = "SELECT * FROM tbl_Goods"
        da = New OleDbDataAdapter(stroledb, con)
        da.Fill(ds, "tbl_Goods")

        con.Close()

        cmb_Kname.Items.Clear()

        For i = 0 To ds.Tables(0).Rows.Count - 1

            'On Error Resume Next
            cmb_Kname.Items.Add(ds.Tables(0).Rows(i).Item(1).ToString)

        Next

        ds.Reset()
        con = New OleDbConnection(strcon)
        con.Open()

        stroledb = "SELECT * FROM tbl_Store"
        da = New OleDbDataAdapter(stroledb, con)
        da.Fill(ds, "tbl_Store")

        con.Close()

        cmb_Store.Items.Clear()

        For i = 0 To ds.Tables(0).Rows.Count - 1

            'On Error Resume Next

            cmb_Store.Items.Add(ds.Tables(0).Rows(i).Item(1).ToString)

        Next

        ds.Reset()
        con = New OleDbConnection(strcon)
        con.Open()

        stroledb = "SELECT tbl_GinS.Kname AS کالا, tbl_GinS.Kcount AS تعداد, tbl_Goods.Uname AS [واحد سنجش], tbl_GinS.Kstore AS انبارمقصد, tbl_GinS.Klocating AS جانمایی, tbl_GinS.Kexp AS [تاریخ انقضاء] FROM (tbl_GinS INNER JOIN tbl_Goods ON tbl_GinS.Kname = tbl_Goods.Kname)"
        da = New OleDbDataAdapter(stroledb, con)
        da.Fill(ds, "tbl_GinS, tbl_Goods")

        con.Close()

        dgv_Store.DataBindings.Clear()
        dgv_Store.DataBindings.Add(New Binding("datasource", ds, "tbl_GinS, tbl_Goods"))
        dgv_Store.ClearSelection()

    End Sub

    Private Sub btn_return_Click(sender As Object, e As EventArgs) Handles btn_return.Click

        Me.Close()

    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click

        If cmb_Kname.SelectedIndex = -1 Then

            MsgBox("لطفاً نام کالا را انتخاب نمائید",, "انبارداری سامان")
            cmb_Kname.Focus()
            Exit Sub

        End If

        If txt_Kcount.Text.Trim = "" Then

            MsgBox("لطفاً تعداد کالا را مشخص نمائید",, "انبارداری سامان")
            txt_Kcount.Focus()
            Exit Sub

        End If

        If cmb_Store.SelectedIndex = -1 Then

            MsgBox("لطفاً انبار مقصد را تعیین نمائید",, "انبارداری سامان")
            cmb_Store.Focus()
            Exit Sub

        End If

        For i = 0 To dgv_Store.Rows.Count - 1

            If cmb_Kname.Text.Trim = dgv_Store.Item(0, i).value.tostring And cmb_Store.Text.Trim = dgv_Store.Item(3, i).value.tostring Then

                stroledb = "UPDATE tbl_GinS SET Kcount =@Kcount WHERE (tbl_GinS.Kname = '" & cmb_Kname.Text.Trim & "') AND (tbl_GinS.Kstore = '" & cmb_Store.Text.Trim & "')"

                com = New OleDbCommand(stroledb, con)
                com.Parameters.Add("@Kcount", OleDbType.VarChar).value = Int(dgv_Store.Item(1, i).value.tostring) + Int(txt_Kcount.Text.Trim)

                con.Open()
                com.ExecuteNonQuery()
                con.Close()

                Call Clear_form()
                Call Load_data()

                dgv_Store.ClearSelection()
                dgv_Store.Item(0, i).Selected = True
                cmb_Kname.Focus()
                Exit Sub

            End If

        Next

        stroledb = "INSERT INTO tbl_GinS (Kname, Kcount, Kstore, Klocating, Kexp) VALUES (@Kname, @Kcount, @Kstore, @Klocating, @Kexp)"

        com = New OleDbCommand(stroledb, con)
        com.Parameters.Add("@Kname", OleDbType.VarChar).value = cmb_Kname.Text.Trim
        com.Parameters.Add("@Kcount", OleDbType.VarChar).value = txt_Kcount.Text.Trim
        com.Parameters.Add("@Kstore", OleDbType.VarChar).value = cmb_Store.Text.Trim
        com.Parameters.Add("@Klocating", OleDbType.VarChar).value = txt_Locating.Text.Trim

        Date_Temp = txt_Exp_year.Text.Trim & "/" & txt_Exp_month.Text.Trim & "/" & txt_Exp_day.Text.Trim
        If Date_Temp = "//" Then Date_Temp = ""

        com.Parameters.Add("@Kexp", OleDbType.VarChar).value = Date_Temp

        con.Open()
        com.ExecuteNonQuery()
        con.Close()

        Call Clear_form()
        Call Load_data()

        dgv_Store.ClearSelection()
        dgv_Store.Item(0, dgv_Store.Rows.Count - 1).Selected = True

    End Sub

    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click

        Call Clear_form()
        Call Load_data()

    End Sub

    Private Sub dgv_Store_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Store.CellDoubleClick

        If e.RowIndex = -1 Then Exit Sub

        Row_for_edit = e.RowIndex

        Dim temp_a = dgv_Store.Item(0, Row_for_edit).value.tostring
        Dim temp_b = dgv_Store.Item(3, Row_for_edit).value.tostring

        'ds.Reset()
        con = New OleDbConnection(strcon)
        con.Open()

        stroledb = "SELECT tbl_GinS.*, tbl_Goods.* FROM (tbl_GinS INNER JOIN tbl_Goods ON tbl_GinS.Kname = tbl_Goods.Kname) WHERE (tbl_GinS.Kname = '" & temp_a & "') AND (tbl_GinS.Kstore = '" & temp_b & "')"

        da = New OleDbDataAdapter(stroledb, con)
        da.Fill(ds, "tbl_temp1")

        con.Close()

        cmb_Kname.Text = ds.Tables("tbl_temp1").Rows(0).Item(1).ToString
        txt_Kcount.Text = ds.Tables("tbl_temp1").Rows(0).Item(2).ToString
        cmb_Store.Text = ds.Tables("tbl_temp1").Rows(0).Item(3).ToString
        txt_Locating.Text = ds.Tables("tbl_temp1").Rows(0).Item(4).ToString
        txt_Unit.Text = ds.Tables("tbl_temp1").Rows(0).Item(8).ToString
        txt_Group.Text = ds.Tables("tbl_temp1").Rows(0).Item(11).ToString
        txt_Category.Text = ds.Tables("tbl_temp1").Rows(0).Item(12).ToString

        Date_Temp = ds.Tables("tbl_temp1").Rows(0).Item(5).ToString

        txt_Exp_year.Text = Mid(Date_Temp, 1, 4)
        txt_Exp_month.Text = Mid(Date_Temp, 6, 2)
        txt_Exp_day.Text = Mid(Date_Temp, 9, 2)

        btn_edit.Enabled = True
        btn_save.Enabled = False
        Temp_String = cmb_Kname.Text.Trim
        Temp_String2 = cmb_Store.Text.Trim

    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click

        If cmb_Kname.SelectedIndex = -1 Then

            MsgBox("لطفاً نام کالا را انتخاب نمائید",, "انبارداری سامان")
            cmb_Kname.Focus()
            Exit Sub

        End If

        If txt_Kcount.Text.Trim = "" Then

            MsgBox("لطفاً تعداد کالا را مشخص نمائید",, "انبارداری سامان")
            txt_Kcount.Focus()
            Exit Sub

        End If

        If cmb_Store.SelectedIndex = -1 Then

            MsgBox("لطفاً انبار مقصد را تعیین نمائید",, "انبارداری سامان")
            cmb_Store.Focus()
            Exit Sub

        End If

        For i = 0 To dgv_Store.Rows.Count - 1

            If cmb_Kname.Text.Trim = dgv_Store.Item(0, i).value.tostring And cmb_Store.Text.Trim = dgv_Store.Item(3, i).value.tostring Then

                If cmb_Kname.Text.Trim = Temp_String And cmb_Store.Text.Trim = Temp_String2 Then Exit For

                dgv_Store.Item(0, i).Selected = True

                MsgBox("کالای مورد نظر در انبار انتخاب شده قبلاً ثبت شده است",, "انبارداری سامان")
                dgv_Store.Item(0, i).Selected = True
                cmb_Kname.SelectionStart = 0
                cmb_Kname.SelectionLength = Len(cmb_Kname.Text)
                cmb_Kname.Focus()
                Exit Sub

            End If

        Next

        stroledb = "UPDATE tbl_GinS SET Kname =@Kname, Kcount =@Kcount, Kstore =@Kstore, Klocating =@Klocating, Kexp =@Kexp WHERE (Kname = '" & Temp_String & "') AND (Kstore = '" & Temp_String2 & "')"

        com = New OleDbCommand(stroledb, con)
        com.Parameters.Add("@Kname", OleDbType.VarChar).value = cmb_Kname.Text.Trim
        com.Parameters.Add("@Kcount", OleDbType.VarChar).value = txt_Kcount.Text.Trim
        com.Parameters.Add("@Kstore", OleDbType.VarChar).value = cmb_Store.Text.Trim
        com.Parameters.Add("@Klocating", OleDbType.VarChar).value = txt_Locating.Text.Trim

        Date_Temp = txt_Exp_year.Text.Trim & "/" & txt_Exp_month.Text.Trim & "/" & txt_Exp_day.Text.Trim
        If Date_Temp = "//" Then Date_Temp = ""

        com.Parameters.Add("@Kexp", OleDbType.VarChar).value = Date_Temp

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

            stroledb = "DELETE FROM tbl_GinS WHERE (tbl_GinS.Kname = '" & Temp_String & "')"
            com = New OleDbCommand(stroledb, con)
            con.Open()
            com.ExecuteNonQuery()
            con.Close()

            Call Clear_form()
            Call Load_data()

        End If

    End Sub

    Private Sub cmb_Kname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_Kname.SelectedIndexChanged, cmb_Kname.Leave

        If cmb_Kname.SelectedIndex = -1 Or cmb_Kname.Text = "" Then Exit Sub

        'ds.Reset()
        con = New OleDbConnection(strcon)
        con.Open()

        stroledb = "SELECT * FROM tbl_Goods"

        da = New OleDbDataAdapter(stroledb, con)
        da.Fill(ds, "tbl_temp")

        con.Close()

        If Not ds.Tables("tbl_temp").Rows.Count = 0 Then

            For i = 0 To ds.Tables("tbl_temp").Rows.Count - 1

                If ds.Tables("tbl_temp").Rows(i).Item("Kname").ToString = cmb_Kname.Text.Trim Then

                    txt_Unit.Text = ds.Tables("tbl_temp").Rows(i).Item("Uname").ToString
                    txt_Category.Text = ds.Tables("tbl_temp").Rows(i).Item("Cname").ToString
                    txt_Group.Text = ds.Tables("tbl_temp").Rows(i).Item("Gname").ToString
                    Exit Sub

                End If

            Next

        End If

    End Sub

    Private Sub txt_Exp_day_leave(sender As Object, e As EventArgs) Handles txt_Exp_day.Leave

        If IsNumeric(txt_Exp_day.Text.Trim) = False Then txt_Exp_day.Text = "" : Exit Sub

        If Int(txt_Exp_day.Text.Trim) > 31 Then txt_Exp_day.Text = "31"
        If Int(txt_Exp_day.Text.Trim) < 1 Then txt_Exp_day.Text = "1"

        If Int(txt_Exp_day.Text.Trim) < 10 And Len(txt_Exp_day.Text.Trim) = 1 Then txt_Exp_day.Text = "0" & txt_Exp_day.Text.Trim

    End Sub

    Private Sub txt_Exp_month_leave(sender As Object, e As EventArgs) Handles txt_Exp_month.Leave

        If IsNumeric(txt_Exp_month.Text.Trim) = False Then txt_Exp_month.Text = "" : Exit Sub

        If Int(txt_Exp_month.Text.Trim) > 12 Then txt_Exp_month.Text = "12"
        If Int(txt_Exp_month.Text.Trim) < 1 Then txt_Exp_month.Text = "1"

        If Int(txt_Exp_month.Text.Trim) < 10 And Len(txt_Exp_month.Text.Trim) = 1 Then txt_Exp_month.Text = "0" & txt_Exp_month.Text.Trim

        If Int(txt_Exp_month.Text.Trim) > 6 And txt_Exp_day.Text.Trim = "31" Then txt_Exp_day.Text = "30"

    End Sub

    Private Sub txt_Exp_year_leave(sender As Object, e As EventArgs) Handles txt_Exp_year.Leave

        If IsNumeric(txt_Exp_year.Text.Trim) = False Then txt_Exp_year.Text = "" : Exit Sub

        If Len(txt_Exp_year.Text.Trim) < 4 Then

            MsgBox("عدد سال باید چهار رقمی باشد",, "انبارداری سامان")
            txt_Exp_year.SelectionStart = 0
            txt_Exp_year.SelectionLength = Len(txt_Exp_year.Text)
            txt_Exp_year.Focus()

        End If

    End Sub

End Class