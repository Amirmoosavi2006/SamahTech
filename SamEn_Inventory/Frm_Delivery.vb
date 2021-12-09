Imports System.Data.OleDb
Imports System.IO
Imports System.Text.RegularExpressions
Imports Microsoft.Office.Interop.Excel
Imports OleDbConnection = System.Data.OleDb.OleDbConnection

Public Class Frm_Delivery
    Private Sub Frm_Delivery_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
        txt_Delivery_No.Clear()
        txt_Delivery_Name.Clear()
        txt_Desc.Clear()
        Temp_String = ""
        Row_for_edit = -1
        Call_Report = False
        txt_Delivery_No.Focus()

    End Sub

    Sub Load_data()

        ds.Reset()
        con = New OleDbConnection(strcon)
        con.Open()

        stroledb = "SELECT DISTINCT O_No AS [شماره سفارش], O_Customer AS [تحویل گیرنده], O_Date AS [تاریخ درخواست], O_Desc AS توضیحات FROM tbl_Order WHERE (O_Delivery = 'No')"
        da = New OleDbDataAdapter(stroledb, con)
        da.Fill(ds, "tbl_Order")

        con.Close()

        dgv_Store.DataBindings.Clear()
        dgv_Store.DataBindings.Add(New Binding("datasource", ds, "tbl_Order"))
        dgv_Store.ClearSelection()

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
    Private Sub btn_Return_Click(sender As Object, e As EventArgs) Handles btn_Return.Click

        Me.Close()

    End Sub
    Private Sub dgv_Store_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Store.CellClick

        If Call_Report = True Then Exit Sub

        Row_for_edit = -1

        If e.RowIndex <> -1 Then

            Row_for_edit = e.RowIndex
            txt_Delivery_No.Text = dgv_Store.Item(0, Row_for_edit).Value

        End If

    End Sub

    Private Sub dgv_Store_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Store.CellDoubleClick

        If Call_Report = True Then Exit Sub

        Row_for_edit = -1

        If e.RowIndex <> -1 Then Row_for_edit = e.RowIndex

        Temp_String = dgv_Store.Item(0, Row_for_edit).Value.ToString

        txt_Delivery_No.Text = dgv_Store.Item(0, Row_for_edit).Value.ToString
        txt_Delivery_Name.Text = dgv_Store.Item(1, Row_for_edit).Value.ToString

        stroledb = "Select tbl_Order.O_Kname As [نام کالا], tbl_Order.O_Count As [تعداد سفارش], tbl_Order.O_Store As [نام انبار], tbl_GinS.Kcount As [موجودی انبار] FROM (tbl_Order INNER JOIN tbl_GinS On tbl_Order.O_Kname = tbl_GinS.Kname And tbl_Order.O_Store = tbl_GinS.Kstore) WHERE (tbl_Order.O_No = '" & Temp_String & "')"

        ds.Reset()
        con = New OleDbConnection(strcon)

        con.Open()
        da = New OleDbDataAdapter(stroledb, con)
        da.Fill(ds, "tbl_find")
        con.Close()

        dgv_Store.DataBindings.Clear()
        dgv_Store.DataBindings.Add(New Binding("datasource", ds, "tbl_find"))
        dgv_Store.ClearSelection()

        Call_Report = True

    End Sub

    Private Sub btn_Print_Click(sender As Object, e As EventArgs) Handles btn_Print.Click

        If Call_Report = False Then

            MsgBox("ابتدا سفارش مورد نظر را انتخاب نمائید",, "انبارداری سامان")
            Exit Sub

        End If

        con.Open()
        stroledb = "SELECT * FROM tbl_Goods"
        da = New OleDbDataAdapter(stroledb, con)
        da.Fill(ds, "tbl_Goods")
        con.Close()

        If Not Directory.Exists("Reports") Then Directory.CreateDirectory(My.Application.Info.DirectoryPath & "\Reports")

        Dim xl_adres As String
        Dim xl_app As Application = New Application
        Dim xl_workbook As Workbook

        If File.Exists(My.Application.Info.DirectoryPath & "\Reports\" & txt_Delivery_No.Text.Trim & ".xls") Then

            xl_adres = My.Application.Info.DirectoryPath & "\Reports\" & txt_Delivery_No.Text.Trim & ".xls"
            xl_workbook = xl_app.Workbooks.Open(xl_adres)

        Else

            xl_adres = My.Application.Info.DirectoryPath.ToString & "\Xl_Print.xls"
            xl_workbook = xl_app.Workbooks.Open(xl_adres)
            xl_app.ActiveWorkbook.SaveAs(My.Application.Info.DirectoryPath & "\Reports\" & txt_Delivery_No.Text.Trim & ".xls")

        End If

        Date_Temp = txt_Exp_year.Text.Trim & "/" & txt_Exp_month.Text.Trim & "/" & txt_Exp_day.Text.Trim
        Dim xl_sheet As Worksheet = xl_app.Sheets("Sheet1")

        xl_sheet.Range("A1").Value = txt_Delivery_No.Text.Trim
        xl_sheet.Range("A2").Value = Date_Temp
        xl_sheet.Range("A3").Value = txt_Delivery_Name.Text.Trim

        xl_sheet = xl_app.Sheets(1)

        For i = 0 To dgv_Store.Rows.Count - 1

            xl_sheet.Range("C" & i + 13).Value = dgv_Store.Item(0, i).Value
            xl_sheet.Range("D" & i + 13).Value = dgv_Store.Item(1, i).Value

            For j = 0 To ds.Tables("tbl_Goods").Rows.Count - 1

                If ds.Tables("tbl_Goods").Rows(j).Item("Kname").ToString = dgv_Store.Item(0, i).Value Then

                    xl_sheet.Range("E" & i + 13).Value = ds.Tables("tbl_Goods").Rows(j).Item("Uname").ToString
                    Exit For

                End If

            Next

        Next

        xl_sheet.Range("D28").Value = txt_Desc.Text

        If Not File.Exists(My.Application.Info.DirectoryPath & "\Reports\" & txt_Delivery_No.Text.Trim & ".pdf") Then
            xl_workbook.ActiveSheet.ExportAsFixedFormat(XlFixedFormatType.xlTypePDF, My.Application.Info.DirectoryPath & "\Reports\" & txt_Delivery_No.Text.Trim)
        End If

        Process.Start(My.Application.Info.DirectoryPath & "\Reports\" & txt_Delivery_No.Text.Trim & ".pdf")

        xl_app.DisplayAlerts = False
        xl_app.Quit()

        releaseObject(xl_app)
        releaseObject(xl_workbook)

    End Sub
    Sub releaseObject(ByVal obj As Object)

        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try

    End Sub

    Private Sub btn_Ok_Click(sender As Object, e As EventArgs) Handles btn_Ok.Click

        If Call_Report = True Then Exit Sub

        If txt_Delivery_No.Text.Trim = "" Then Exit Sub

        Temp_String = txt_Delivery_No.Text.Trim

        For i = 0 To dgv_Store.Rows.Count - 1

            If dgv_Store.Item(0, i).Value = txt_Delivery_No.Text.Trim Then

                txt_Delivery_Name.Text = dgv_Store.Item(1, i).Value
                Exit For

            End If

        Next

        stroledb = "SELECT tbl_Order.O_Kname AS [نام کالا], tbl_Order.O_Count AS [تعداد سفارش], tbl_Order.O_Store AS [نام انبار], tbl_GinS.Kcount AS [موجودی انبار] FROM (tbl_Order INNER JOIN tbl_GinS ON tbl_Order.O_Kname = tbl_GinS.Kname AND tbl_Order.O_Store = tbl_GinS.Kstore) WHERE (tbl_Order.O_No = '" & Temp_String & "')"

        ds.Reset()
        con = New OleDbConnection(strcon)

        con.Open()
        da = New OleDbDataAdapter(stroledb, con)
        da.Fill(ds, "tbl_find")
        con.Close()

        dgv_Store.DataBindings.Clear()
        dgv_Store.DataBindings.Add(New Binding("datasource", ds, "tbl_find"))
        dgv_Store.ClearSelection()

        Call_Report = True

    End Sub

    Private Sub btn_New_Click(sender As Object, e As EventArgs) Handles btn_New.Click

        Call Clear_form()
        Call Load_data()

    End Sub

    Private Sub btn_Delivery_Click(sender As Object, e As EventArgs) Handles btn_Delivery.Click

        If Call_Report = False Then

            MsgBox("ابتدا سفارش مورد نظر را انتخاب نمائید",, "انبارداری سامان")
            Exit Sub

        End If

        Dim Dialog_Result = MsgBox("آیا برای تحویل سفارش اطمینان دارید؟", vbYesNo, "انبارداری سامان")
        If Dialog_Result = vbNo Then Exit Sub

        For i = 0 To dgv_Store.Rows.Count - 1
            If dgv_Store.Item(1, i).Value > dgv_Store.Item(3, i).Value Then
                MsgBox("مقدار سفارش در ردیف " & Str(i + 1) & " در جدول زیر از مقدار موجودی انبار بیشتر می باشد",, "انبارداری سامان")
                Exit Sub
            End If
        Next

        Date_Temp = txt_Exp_year.Text.Trim & "/" & txt_Exp_month.Text.Trim & "/" & txt_Exp_day.Text.Trim

        stroledb = "UPDATE tbl_Order SET O_Delivery =@O_Delivery, D_Date =@D_Date, D_Desc =@D_Desc WHERE (tbl_Order.O_No = '" & txt_Delivery_No.Text.Trim & "')"

        com = New OleDbCommand(stroledb, con)
        com.Parameters.Add("@O_Delivery", OleDbType.VarChar).Value = "Yes"
        com.Parameters.Add("@D_Date", OleDbType.VarChar).Value = Date_Temp
        com.Parameters.Add("@D_Desc", OleDbType.VarChar).Value = txt_Desc.Text

        con.Open()
        com.ExecuteNonQuery()
        con.Close()

        For i = 0 To dgv_Store.Rows.Count - 1

            stroledb = "UPDATE tbl_GinS SET Kcount =@Kcount WHERE (tbl_GinS.Kname = '" & dgv_Store.Item(0, i).Value & "') AND (tbl_GinS.Kstore = '" & dgv_Store.Item(2, i).Value & "')"

            com = New OleDbCommand(stroledb, con)
            com.Parameters.Add("@Kcount", OleDbType.VarChar).Value = Int(dgv_Store.Item(3, i).Value) - Int(dgv_Store.Item(1, i).Value)

            con.Open()
            com.ExecuteNonQuery()
            con.Close()

        Next

        Call Clear_form()
        Call Load_data()

    End Sub


End Class