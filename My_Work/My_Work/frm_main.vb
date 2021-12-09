Imports System.Data.OleDb

Public Class frm_main
    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click

        Me.Hide()
        frm_new.ShowDialog()

    End Sub

    Sub Clear_form()

        Final_Check = False
        txt_find_word.Clear()
        txt_find_word.Focus()

    End Sub
    Sub Load_data()

        ds.Reset()
        con = New OleDbConnection(strcon)
        con.Open()

        stroledb = "SELECT work_no AS [شماره کار], work_title AS عنوان, work_date AS [تاریخ ثبت], p_date AS [تاریخ پیگیری] FROM tbl_work WHERE (final_ok = 'N') ORDER BY p_date"
        da = New OleDbDataAdapter(stroledb, con)
        da.Fill(ds, "tbl_work")

        con.Close()

        dgv_w.DataBindings.Clear()
        dgv_w.DataBindings.Add(New Binding("datasource", ds, "tbl_work"))

    End Sub

    Private Sub btn_return_Click(sender As Object, e As EventArgs) Handles btn_return.Click

        Me.Close()

    End Sub

    Private Sub frm_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call Clear_form()
        Call Load_data()

    End Sub

    Private Sub btn_wfinal_Click(sender As Object, e As EventArgs) Handles btn_wfinal.Click

        ds.Reset()
        con = New OleDbConnection(strcon)
        con.Open()

        stroledb = "SELECT work_no AS [شماره کار], work_title AS عنوان, work_date AS [تاریخ ثبت], final_desc AS [شرح نهایی], final_date AS [تاریخ انجام] FROM tbl_work WHERE (final_ok = 'Y') ORDER BY final_date"
        da = New OleDbDataAdapter(stroledb, con)
        da.Fill(ds, "tbl_work")

        con.Close()

        dgv_w.DataBindings.Clear()
        dgv_w.DataBindings.Add(New Binding("datasource", ds, "tbl_work"))

        Final_Check = True

    End Sub

    Private Sub btn_all_w_Click(sender As Object, e As EventArgs) Handles btn_all_w.Click

        Call Clear_form()
        Call Load_data()

    End Sub

    Private Sub btn_today_p_Click(sender As Object, e As EventArgs) Handles btn_today_p.Click

        Dim Temp_d, Temp_m, Temp_y As String
        Temp_d = PersianDateTime.Today.Day
        If Len(Temp_d) < 2 Then Temp_d = "0" & Temp_d
        Temp_m = PersianDateTime.Today.Month
        If Len(Temp_m) < 2 Then Temp_m = "0" & Temp_m
        Temp_y = PersianDateTime.Today.Year
        Temp_date = Temp_y & "/" & Temp_m & "/" & Temp_d

        ds.Reset()
        con = New OleDbConnection(strcon)
        con.Open()

        stroledb = "SELECT work_no AS [شماره کار], work_title AS عنوان, work_date AS [تاریخ ثبت], p_date AS [تاریخ پیگیری] FROM tbl_work WHERE (p_date = '" & Temp_date & "') AND (final_ok = 'N') ORDER BY work_date"
        da = New OleDbDataAdapter(stroledb, con)
        da.Fill(ds, "tbl_work")

        con.Close()

        dgv_w.DataBindings.Clear()
        dgv_w.DataBindings.Add(New Binding("datasource", ds, "tbl_work"))

        Final_Check = False

    End Sub


    Private Sub dgv_w_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_w.CellDoubleClick

        If e.RowIndex = -1 Then Exit Sub

        Temp_Work_no = dgv_w.Item(0, e.RowIndex).Value
        P_bool = True
        frm_new.Show()
        Me.Close()

    End Sub

End Class