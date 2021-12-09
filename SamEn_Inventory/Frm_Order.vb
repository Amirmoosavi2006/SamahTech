Imports System.Data.OleDb

Public Class Frm_Order
    Private Sub Frm_Order_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call Clear_form()
        Call Load_data()

    End Sub
    Sub Clear_form()

        If PersianDateTime.Now.Day < 10 Then
            txt_Exp_day.Text = "0" & PersianDateTime.Now.Day
        Else
            txt_Exp_day.Text = PersianDateTime.Now.Day
        End If
        If PersianDateTime.Now.Month < 10 Then
            txt_Exp_month.Text = "0" & PersianDateTime.Now.Month
        Else
            txt_Exp_month.Text = PersianDateTime.Now.Month
        End If
        txt_Exp_year.Text = PersianDateTime.Now.Year
        dgv_Store.Rows.Clear()
        dgv_Store.ClearSelection()
        txt_Kcount.Clear()
        txt_Order_No.Clear()
        txt_Desc.Text = "شماره نامه اتوماسیونی: " & vbNewLine & "تاریخ درخواست:  " & vbNewLine & "سایر توضیحات: "
        Temp_String = txt_Desc.Text
        Temp_String2 = ""
        Temp_Count = 0
        cmb_Customer.Text = ""
        cmb_Store.Items.Clear()
        cmb_Store.Text = ""
        txt_Balance.Clear()
        txt_AfterOrder.Clear()
        txt_balance1.Clear()
        txt_AfterOrder1.Clear()
        cmb_Kname.Text = ""
        cmb_Customer.Focus()

    End Sub

    Sub Load_data()

        ds.Reset()
        con = New OleDbConnection(strcon)
        con.Open()

        stroledb = "SELECT * FROM tbl_Customer"
        da = New OleDbDataAdapter(stroledb, con)
        da.Fill(ds, "tbl_Customer")

        cmb_Customer.Items.Clear()

        For i = 0 To ds.Tables("tbl_Customer").Rows.Count - 1

            cmb_Customer.Items.Add(ds.Tables("tbl_Customer").Rows(i).Item("S_name").ToString)

        Next

        stroledb = "SELECT * FROM tbl_Store"
        da = New OleDbDataAdapter(stroledb, con)
        da.Fill(ds, "tbl_Store")

        cmb_Store.Items.Clear()

        For i = 0 To ds.Tables("tbl_Store").Rows.Count - 1

            cmb_Store.Items.Add(ds.Tables("tbl_Store").Rows(i).Item("S_name").ToString)

        Next

        stroledb = "SELECT * FROM tbl_Goods"
        da = New OleDbDataAdapter(stroledb, con)
        da.Fill(ds, "tbl_Goods")

        cmb_Kname.Items.Clear()

        For i = 0 To ds.Tables("tbl_Goods").Rows.Count - 1

            cmb_Kname.Items.Add(ds.Tables("tbl_Goods").Rows(i).Item("Kname").ToString)

        Next

        stroledb = "SELECT * FROM tbl_Code"
        da = New OleDbDataAdapter(stroledb, con)
        da.Fill(ds, "tbl_Code")

        Dim Code_Generate As Long
        Code_Generate = ds.Tables("tbl_Code").Rows(ds.Tables("tbl_Code").Rows.Count - 1).Item("Uniq_Code")

        txt_Order_No.Text = Code_Generate + 1

        stroledb = "SELECT * FROM tbl_GinS"
        da = New OleDbDataAdapter(stroledb, con)
        da.Fill(ds, "tbl_GinS")

        stroledb = "SELECT * FROM tbl_Order"
        da = New OleDbDataAdapter(stroledb, con)
        da.Fill(ds, "tbl_Order")

        con.Close()

    End Sub

    Private Sub btn_New_Click(sender As Object, e As EventArgs) Handles btn_New.Click

        Call Clear_form()
        Call Load_data()

    End Sub

    Private Sub btn_Return_Click(sender As Object, e As EventArgs) Handles btn_Return.Click

        Me.Close()

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

    Private Sub cmb_Kname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_Kname.SelectedIndexChanged

        Dim temp_unit As String = ""

        If Not cmb_Kname.SelectedIndex = -1 Then

            cmb_Store.SelectedIndex = 0

        Else

            cmb_Store.SelectedIndex = -1

        End If

    End Sub

    Private Sub btn_Add_Click(sender As Object, e As EventArgs) Handles btn_Add.Click

        If cmb_Kname.Text = "" Then
            MsgBox("کالایی برای ثبت انتخاب نشده است",, "انبارداری سامان")
            cmb_Kname.Focus()
            Exit Sub
        End If

        For i = 0 To dgv_Store.Rows.Count - 1

            If cmb_Kname.Text.Trim = dgv_Store.Item(0, i).Value Then

                MsgBox("این کالا قبلاً دراین سفارش ثبت شده است",, "انبارداری سامان")
                cmb_Kname.Focus()
                Exit Sub

            End If

        Next

        If txt_Kcount.Text = "" Then
            MsgBox("تعداد کالای مورد ثبت وارد نشده است",, "انبارداری سامان")
            txt_Kcount.Focus()
            Exit Sub
        End If

        If IsNumeric(txt_Kcount.Text) = False Then
            MsgBox("تعداد کالا باید بصورت عددی وارد شود",, "انبارداری سامان")
            txt_Kcount.SelectionStart = 0
            txt_Kcount.SelectionLength = txt_Kcount.Text.Length
            txt_Kcount.Focus()
            Exit Sub
        End If

        If txt_Balance.Text.Trim = "0" Or txt_Balance.Text.Trim = "" Then

            Dim Dialog_Result = MsgBox("کالای انتخابی در هیچ انباری موجودی ندارد" & vbNewLine & "آیا برای ثبت اطمینان دارید؟", vbYesNo, "انبارداری سامان")

            If Dialog_Result = vbNo Then Exit Sub

            dgv_Store.Rows.Add()
            dgv_Store.Item(0, dgv_Store.Rows.Count - 1).Value = cmb_Kname.Text.Trim
            dgv_Store.Item(1, dgv_Store.Rows.Count - 1).Value = Int(txt_Kcount.Text.Trim)
            dgv_Store.Item(2, dgv_Store.Rows.Count - 1).Value = cmb_Store.Text
            dgv_Store.Rows(dgv_Store.Rows.Count - 1).DefaultCellStyle.BackColor = Color.Red

        Else

            dgv_Store.Rows.Add()
            dgv_Store.Item(0, dgv_Store.Rows.Count - 1).Value = cmb_Kname.Text.Trim
            dgv_Store.Item(1, dgv_Store.Rows.Count - 1).Value = Int(txt_Kcount.Text.Trim)
            dgv_Store.Item(2, dgv_Store.Rows.Count - 1).Value = cmb_Store.Text.Trim

            If Int(txt_Kcount.Text.Trim) > Int(txt_Balance.Text.Trim) Then

                dgv_Store.Rows(dgv_Store.Rows.Count - 1).DefaultCellStyle.BackColor = Color.Yellow

            End If

        End If

        cmb_Kname.Text = ""
        Temp_String2 = ""
        txt_Kcount.Clear()
        dgv_Store.ClearSelection()
        cmb_Kname.Focus()

    End Sub

    Private Sub btn_Del_Click(sender As Object, e As EventArgs) Handles btn_Del.Click

        If dgv_Store.Rows.Count = 0 Then Exit Sub

        If Row_for_del = -1 Then

            dgv_Store.Rows.RemoveAt(dgv_Store.Rows.Count - 1)

        Else

            dgv_Store.Rows.RemoveAt(Row_for_del)

        End If

        Row_for_del = -1
        dgv_Store.ClearSelection()

    End Sub

    Private Sub dgv_Store_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Store.CellClick

        Row_for_del = -1

        If e.RowIndex <> -1 Then Row_for_del = e.RowIndex

    End Sub

    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click

        If cmb_Customer.SelectedIndex = -1 Then
            MsgBox("پیش از ثبت سفارش، واحد سفارش دهنده را انتخاب نمایید",, "انبارداری سامان")
            cmb_Customer.Focus()
            Exit Sub
        End If

        If Len(txt_Exp_day.Text.Trim) < 2 Then
            MsgBox("خطا در ثبت تاریخ",, "انبارداری سامان")
            txt_Exp_day.SelectionStart = 0
            txt_Exp_day.SelectionLength = txt_Exp_day.Text.Length
            txt_Exp_day.Focus()
            Exit Sub
        End If

        If Len(txt_Exp_month.Text.Trim) < 2 Then
            MsgBox("خطا در ثبت تاریخ",, "انبارداری سامان")
            txt_Exp_month.SelectionStart = 0
            txt_Exp_month.SelectionLength = txt_Exp_month.Text.Length
            txt_Exp_month.Focus()
            Exit Sub
        End If

        If Len(txt_Exp_year.Text.Trim) < 4 Then
            MsgBox("خطا در ثبت تاریخ",, "انبارداری سامان")
            txt_Exp_year.SelectionStart = 0
            txt_Exp_year.SelectionLength = txt_Exp_year.Text.Length
            txt_Exp_year.Focus()
            Exit Sub
        End If

        If dgv_Store.Rows.Count = 0 Then
            MsgBox("کالایی برای ثبت سفارش انتخاب نشده است",, "انبارداری سامان")
            cmb_Kname.Focus()
            Exit Sub
        End If

        If txt_Desc.Text.Trim = "" Or txt_Desc.Text = Temp_String Then txt_Desc.Text = "-"
        Date_Temp = txt_Exp_year.Text & "/" & txt_Exp_month.Text & "/" & txt_Exp_day.Text

        For i = 0 To dgv_Store.Rows.Count - 1

            stroledb = "INSERT INTO tbl_Order (O_No, O_Customer, O_Date, O_Kname, O_Count, O_Store, O_Desc, O_Delivery) VALUES (@O_No, @O_Customer, @O_Date, @O_Kname, @O_Count, @O_Store, @O_Desc, @O_Delivery)"

            com = New OleDbCommand(stroledb, con)
            com.Parameters.Add("@O_No", OleDbType.VarChar).Value = txt_Order_No.Text.Trim
            com.Parameters.Add("@O_Customer", OleDbType.VarChar).Value = cmb_Customer.Text.Trim
            com.Parameters.Add("@O_Date", OleDbType.VarChar).Value = Date_Temp
            com.Parameters.Add("@O_Kname", OleDbType.VarChar).Value = dgv_Store.Item(0, i).Value
            com.Parameters.Add("@O_Count", OleDbType.VarChar).Value = dgv_Store.Item(1, i).Value
            com.Parameters.Add("@O_Store", OleDbType.VarChar).Value = dgv_Store.Item(2, i).Value
            com.Parameters.Add("@O_Desc", OleDbType.VarChar).Value = txt_Desc.Text
            com.Parameters.Add("@O_Delivery", OleDbType.VarChar).Value = "No"
            con.Open()
            com.ExecuteNonQuery()
            con.Close()

        Next i

        stroledb = "INSERT INTO tbl_Code (Uniq_Code) VALUES (@Uniq_Code)"

        com = New OleDbCommand(stroledb, con)
        com.Parameters.Add("@Uniq_Code", OleDbType.VarChar).Value = txt_Order_No.Text.Trim
        con.Open()
        com.ExecuteNonQuery()
        con.Close()

        MsgBox("سفارش شما با شماره  " & txt_Order_No.Text.Trim & " ثبت گردید",, "انبارداری سامان")

        Call Clear_form()
        Call Load_data()

    End Sub

    Private Sub txt_Kcount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Kcount.KeyPress

        If Asc(e.KeyChar) <> 8 Then

            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then

                e.Handled = True

            End If

        End If

    End Sub

    Private Sub cmb_Store_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_Store.SelectedIndexChanged

        If cmb_Kname.SelectedIndex = -1 Or cmb_Kname.Text = "" Then Exit Sub

        For i = 0 To ds.Tables("tbl_GinS").Rows.Count - 1

            If ds.Tables("tbl_GinS").Rows(i).Item("kname").ToString = cmb_Kname.Text.Trim And ds.Tables("tbl_GinS").Rows(i).Item("Kstore").ToString = cmb_Store.Text.Trim Then

                txt_Balance.Text = ds.Tables("tbl_GinS").Rows(i).Item("Kcount").ToString
                'یافتن واحد سنجش کالا
                For j = 0 To ds.Tables("tbl_Goods").Rows.Count - 1
                    If ds.Tables("tbl_Goods").Rows(j).Item("Kname").ToString = cmb_Kname.Text.Trim Then
                        txt_balance1.Text = ds.Tables("tbl_Goods").Rows(j).Item("Uname").ToString
                        Exit For
                    End If
                Next

                Exit For

            End If

            txt_Balance.Clear()
            txt_balance1.Clear()

        Next

        Dim Order_temp As Integer = 0

        For z = 0 To ds.Tables("tbl_Order").Rows.Count - 1

            If ds.Tables("tbl_Order").Rows(z).Item("O_Kname").ToString = cmb_Kname.Text.Trim And ds.Tables("tbl_Order").Rows(z).Item("O_Store").ToString = cmb_Store.Text.Trim Then

                Order_temp += Int(ds.Tables("tbl_Order").Rows(z).Item("O_Count"))

            End If

        Next

        txt_AfterOrder.Clear()
        txt_AfterOrder1.Clear()

        txt_AfterOrder.Text = Order_temp.ToString

        If txt_AfterOrder.Text.Trim = "" Or txt_AfterOrder.Text.Trim = "0" Then Exit Sub

        For j = 0 To ds.Tables("tbl_Goods").Rows.Count - 1
                If ds.Tables("tbl_Goods").Rows(j).Item("Kname").ToString = cmb_Kname.Text.Trim Then
                    txt_AfterOrder1.Text = ds.Tables("tbl_Goods").Rows(j).Item("Uname").ToString
                    Exit For
                End If
            Next

    End Sub


End Class