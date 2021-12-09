Imports System.Data.OleDb

Public Class frm_p
    Private Sub frm_p_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call Clear_form()
        Call Load_data()

    End Sub
    Sub Clear_form()

        txt_wno.Text = Temp_Work_no
        txt_wtitle.Text = Temp_Work_title
        txt_pd.Text = PersianDateTime.Today.Day
        If txt_pd.TextLength < 2 Then txt_pd.Text = "0" & txt_pd.Text
        txt_pm.Text = PersianDateTime.Today.Month
        If txt_pm.TextLength < 2 Then txt_pm.Text = "0" & txt_pm.Text
        txt_py.Text = PersianDateTime.Today.Year
        txt_pdesc.Clear()
        txt_pdesc.Focus()

    End Sub
    Sub Load_data()

        ds.Reset()
        con = New OleDbConnection(strcon)
        con.Open()

        stroledb = "SELECT p_no AS [شماره پیگیری], p_desc AS [شرح پیگیری], p_date AS [تاریخ ثبت پیگیری] FROM tbl_p WHERE (work_no = " & Temp_Work_no & ") ORDER BY p_no"
        da = New OleDbDataAdapter(stroledb, con)
        da.Fill(ds, "tbl_p")

        con.Close()

        dgv_p.DataBindings.Clear()
        dgv_p.DataBindings.Add(New Binding("datasource", ds, "tbl_p"))

    End Sub

    Private Sub btn_return_Click(sender As Object, e As EventArgs) Handles btn_return.Click

        frm_new.Show()
        Me.Close()

    End Sub

    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click

        Call Clear_form()
        Call Load_data()

    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click

        If txt_pdesc.Text = "" Then
            MsgBox("شرح پیگیری نمی تواند خالی باشد")
            txt_pdesc.Focus()
            Exit Sub
        End If

        Temp_date = txt_py.Text & "/" & txt_pm.Text & "/" & txt_pd.Text

        If Len(Temp_date) < 10 Then
            MsgBox("خطا در ثبت تاریخ")
            txt_pd.Focus()
            Exit Sub
        End If

        stroledb = "INSERT INTO tbl_p (work_no, p_no, p_desc, p_date) VALUES (@work_no, @p_no, @p_desc, @p_date)"

        com = New OleDbCommand(stroledb, con)
        com.Parameters.Add("@work_no", OleDbType.VarChar).Value = txt_wno.Text
        com.Parameters.Add("@p_no", OleDbType.VarChar).Value = dgv_p.Rows.Count + 1
        com.Parameters.Add("@p_desc", OleDbType.VarChar).Value = txt_pdesc.Text
        com.Parameters.Add("@p_date", OleDbType.VarChar).Value = Temp_date

        con.Open()
        com.ExecuteNonQuery()
        con.Close()

        Call Clear_form()
        Call Load_data()

    End Sub
    Private Sub txt_pd_Leave(sender As Object, e As EventArgs) Handles txt_pd.Leave

        On Error Resume Next
        If sender.text = "" Then Exit Sub
        If Int(sender.text) < 1 Or Int(sender.text) > 31 Then sender.text = "" : sender.focus() : Exit Sub
        If sender.text.Length < 2 Then sender.text = "0" & sender.text

    End Sub

    Private Sub txt_pm_Leave(sender As Object, e As EventArgs) Handles txt_pm.Leave

        On Error Resume Next
        If sender.text = "" Then Exit Sub
        If Int(sender.text) < 1 Or Int(sender.text) > 12 Then sender.text = "" : sender.focus() : Exit Sub
        If sender.text.Length < 2 Then sender.text = "0" & sender.text

    End Sub

    Private Sub txt_py_Leave(sender As Object, e As EventArgs) Handles txt_py.Leave

        If sender.text = "" Then Exit Sub
        If sender.text.Length < 4 Then sender.text = "" : sender.focus()

    End Sub
End Class