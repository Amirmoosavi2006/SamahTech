Imports System.Data.OleDb

Public Class frm_Report
    Private Sub frm_Report_Load(sender As Object, e As EventArgs) Handles Me.Load

        Call Clear_form()

    End Sub
    Sub Clear_form()

        TabPage1.Show()
        ds.Reset()
        dgv_Store.DataBindings.Clear()
        ds.Reset()
        con = New OleDbConnection(strcon)

    End Sub

    Private Sub btn_All_Click(sender As Object, e As EventArgs) Handles btn_All.Click

        Call Clear_form()

        con.Open()

        stroledb = "SELECT Kname AS [نام کالا], Uname AS [واحد سنجش], Fee AS [قیمت واحد], Min_Balance AS [حداقل موچودی], Gname AS [گروه اقلام], Cname AS [دسته بندی] FROM tbl_Goods"
        da = New OleDbDataAdapter(stroledb, con)
        da.Fill(ds, "tbl_All")

        con.Close()

        dgv_Store.DataBindings.Clear()
        dgv_Store.DataBindings.Add(New Binding("datasource", ds, "tbl_All"))
        dgv_Store.ClearSelection()

        dgv_Store.Columns("نام کالا").DisplayIndex = 0
        dgv_Store.Columns("واحد سنجش").DisplayIndex = 1
        dgv_Store.Columns("قیمت واحد").DisplayIndex = 2
        dgv_Store.Columns("حداقل موچودی").DisplayIndex = 3
        dgv_Store.Columns("گروه اقلام").DisplayIndex = 4
        dgv_Store.Columns("دسته بندی").DisplayIndex = 5

    End Sub

    Private Sub btn_Fin1_Click(sender As Object, e As EventArgs) Handles btn_Fin1.Click

        Call Clear_form()

        con.Open()

        stroledb = "SELECT tbl_GinS.Kname AS [نام کالا], tbl_GinS.Kcount AS [تعداد موجودی],tbl_Goods.Uname AS [واحد سنجش], tbl_Goods.Min_Balance AS [حداقل موجودی], tbl_GinS.Kstore AS [انبار مبداء] FROM (tbl_GinS INNER JOIN tbl_Goods ON tbl_GinS.Kname = tbl_Goods.Kname) ORDER BY tbl_GinS.Kcount"
        da = New OleDbDataAdapter(stroledb, con)
        da.Fill(ds, "tbl_Fin1")

        con.Close()

        dgv_Store.DataBindings.Clear()
        dgv_Store.DataBindings.Add(New Binding("datasource", ds, "tbl_Fin1"))
        dgv_Store.ClearSelection()

        For i = dgv_Store.RowCount - 1 To 0 Step -1

            If Int(dgv_Store.Item(1, i).Value) > Int(dgv_Store.Item(3, i).Value) Or Int(dgv_Store.Item(1, i).Value) = 0 Then
                dgv_Store.Rows.RemoveAt(i)
            End If

        Next

        dgv_Store.Columns("نام کالا").DisplayIndex = 0
        dgv_Store.Columns("تعداد موجودی").DisplayIndex = 1
        dgv_Store.Columns("واحد سنجش").DisplayIndex = 2
        dgv_Store.Columns("حداقل موجودی").DisplayIndex = 3
        dgv_Store.Columns("انبار مبداء").DisplayIndex = 4

    End Sub

    Private Sub btn_Fin2_Click(sender As Object, e As EventArgs) Handles btn_Fin2.Click

        Call Clear_form()

        con.Open()

        stroledb = "SELECT tbl_GinS.Kname AS [نام کالا], tbl_Goods.Uname AS [واحد سنجش], tbl_GinS.Kstore AS [انبار مبداء] FROM (tbl_GinS INNER JOIN tbl_Goods ON tbl_GinS.Kname = tbl_Goods.Kname) WHERE (tbl_GinS.Kcount = '0')"
        da = New OleDbDataAdapter(stroledb, con)
        da.Fill(ds, "tbl_Fin2")

        con.Close()

        dgv_Store.DataBindings.Clear()
        dgv_Store.DataBindings.Add(New Binding("datasource", ds, "tbl_Fin2"))
        dgv_Store.ClearSelection()

        dgv_Store.Columns("نام کالا").DisplayIndex = 0
        dgv_Store.Columns("واحد سنجش").DisplayIndex = 1
        dgv_Store.Columns("انبار مبداء").DisplayIndex = 2

    End Sub

    Private Sub btn_Return_Click(sender As Object, e As EventArgs) Handles btn_Return.Click

        Me.Close()

    End Sub

    Private Sub btn_Exp1_Click(sender As Object, e As EventArgs) Handles btn_Exp1.Click

        Date_Temp = PersianDateTime.Now.Year
        If PersianDateTime.Now.Month < 10 Then
            Date_Temp = Date_Temp & "/0" & PersianDateTime.Now.Month
        Else
            Date_Temp = Date_Temp & "/" & PersianDateTime.Now.Month
        End If
        If PersianDateTime.Now.Day < 10 Then
            Date_Temp = Date_Temp & "/0" & PersianDateTime.Now.Day
        Else
            Date_Temp = Date_Temp & "/" & PersianDateTime.Now.Day
        End If

        Dim Temp_date2

        Temp_date2 = PersianDateTime.Now.Year
        If PersianDateTime.Now.Month < 10 Then
            Temp_date2 = Temp_date2 & "/0" & PersianDateTime.Now.Month + 1
        Else
            Temp_date2 = Temp_date2 & "/" & PersianDateTime.Now.Month + 1
        End If
        If PersianDateTime.Now.Day < 10 Then
            Temp_date2 = Temp_date2 & "/0" & PersianDateTime.Now.Day
        Else
            Temp_date2 = Temp_date2 & "/" & PersianDateTime.Now.Day
        End If

        Call Clear_form()

        con.Open()

        stroledb = "SELECT tbl_GinS.Kname AS [نام کالا], tbl_GinS.Kcount AS [تعداد کالا], tbl_Goods.Uname AS [واحد سنجش], tbl_GinS.Kstore AS [انبار مبداء], tbl_GinS.Klocating AS جانمایی, tbl_GinS.Kexp AS [تاریخ انقضاء] FROM (tbl_GinS INNER JOIN tbl_Goods ON tbl_GinS.Kname = tbl_Goods.Kname) WHERE (tbl_GinS.Kexp BETWEEN '" & Date_Temp & "' AND '" & Temp_date2 & "')"
        da = New OleDbDataAdapter(stroledb, con)
        da.Fill(ds, "tbl_Exp1")

        con.Close()

        dgv_Store.DataBindings.Clear()
        dgv_Store.DataBindings.Add(New Binding("datasource", ds, "tbl_Exp1"))
        dgv_Store.ClearSelection()

        dgv_Store.Columns("نام کالا").DisplayIndex = 0
        dgv_Store.Columns("تعداد کالا").DisplayIndex = 1
        dgv_Store.Columns("واحد سنجش").DisplayIndex = 2
        dgv_Store.Columns("انبار مبداء").DisplayIndex = 3
        dgv_Store.Columns("جانمایی").DisplayIndex = 4
        dgv_Store.Columns("تاریخ انقضاء").DisplayIndex = 5

    End Sub

    Private Sub btn_Exp2_Click(sender As Object, e As EventArgs) Handles btn_Exp2.Click

        Date_Temp = PersianDateTime.Now.Year
        If PersianDateTime.Now.Month < 10 Then
            Date_Temp = Date_Temp & "/0" & PersianDateTime.Now.Month
        Else
            Date_Temp = Date_Temp & "/" & PersianDateTime.Now.Month
        End If
        If PersianDateTime.Now.Day < 10 Then
            Date_Temp = Date_Temp & "/0" & PersianDateTime.Now.Day
        Else
            Date_Temp = Date_Temp & "/" & PersianDateTime.Now.Day
        End If

        Call Clear_form()

        con.Open()

        stroledb = "SELECT tbl_GinS.Kname AS [نام کالا], tbl_GinS.Kcount AS [تعداد کالا], tbl_Goods.Uname AS [واحد سنجش], tbl_GinS.Kstore AS [انبار مبداء], tbl_GinS.Klocating AS جانمایی, tbl_GinS.Kexp AS [تاریخ انقضاء] FROM (tbl_GinS INNER JOIN tbl_Goods ON tbl_GinS.Kname = tbl_Goods.Kname) WHERE (tbl_GinS.Kexp < '" & Date_Temp & "')"
        da = New OleDbDataAdapter(stroledb, con)
        da.Fill(ds, "tbl_Exp2")

        con.Close()

        dgv_Store.DataBindings.Clear()
        dgv_Store.DataBindings.Add(New Binding("datasource", ds, "tbl_Exp2"))
        dgv_Store.ClearSelection()

        dgv_Store.Columns("نام کالا").DisplayIndex = 0
        dgv_Store.Columns("تعداد کالا").DisplayIndex = 1
        dgv_Store.Columns("واحد سنجش").DisplayIndex = 2
        dgv_Store.Columns("انبار مبداء").DisplayIndex = 3
        dgv_Store.Columns("جانمایی").DisplayIndex = 4
        dgv_Store.Columns("تاریخ انقضاء").DisplayIndex = 5

    End Sub
End Class