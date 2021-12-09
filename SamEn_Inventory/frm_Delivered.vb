Imports System.Data.OleDb

Public Class frm_Delivered
    Private Sub frm_Delivered_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call Clear_form()
        Call Load_data()

    End Sub
    Sub Clear_form()

        txt_Order_No.Enabled = False
        txt_Order_No.Clear()
        txt_Customer.Enabled = False
        txt_Customer.Clear()

        Call_Report = False

    End Sub

    Sub Load_data()

        ds.Reset()
        con = New OleDbConnection(strcon)
        con.Open()

        stroledb = "SELECT O_No AS [شماره سفارش], O_Customer AS [تحویل گیرنده], O_Date AS [تاریخ شفارش], D_Date AS [تاریخ تحویل] FROM tbl_Order WHERE (O_Delivery = 'Yes') GROUP BY O_No, O_Customer, O_Date, D_Date ORDER BY D_Date"
        da = New OleDbDataAdapter(stroledb, con)
        da.Fill(ds, "tbl_Order")

        dgv_Store.DataBindings.Clear()
        dgv_Store.DataBindings.Add(New Binding("datasource", ds, "tbl_Order"))

    End Sub

    Private Sub btn_Return_Click(sender As Object, e As EventArgs) Handles btn_Return.Click

        Me.Close()

    End Sub

    Private Sub btn_Print_Report_Click(sender As Object, e As EventArgs) Handles btn_Print_Reports.Click

        'Print_Report

    End Sub


    Private Sub dgv_Store_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Store.CellDoubleClick

        If e.RowIndex = -1 Then Exit Sub

        Dim Row_find = ""

        Row_find = dgv_Store.Item(0, e.RowIndex).Value

        txt_Order_No.Text = dgv_Store.Item(0, e.RowIndex).Value
        txt_Customer.Text = dgv_Store.Item(1, e.RowIndex).Value

        ds.Reset()
        con = New OleDbConnection(strcon)
        con.Open()

        stroledb = "SELECT O_Kname AS [نام کالا], O_Count AS [تعداد سفارش], O_Store AS انبارمبداء, O_Desc AS توضیحات FROM tbl_Order WHERE (O_No = '" & Row_find & "')"
        da = New OleDbDataAdapter(stroledb, con)
        da.Fill(ds, "tbl_Order")

        dgv_Store.DataBindings.Clear()
        dgv_Store.DataBindings.Add(New Binding("datasource", ds, "tbl_Order"))

    End Sub

    Private Sub btn_Show_Orders_Click(sender As Object, e As EventArgs) Handles btn_Show_Orders.Click

        Call Clear_form()
        Call Load_data()

    End Sub
End Class