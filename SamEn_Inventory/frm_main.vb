Imports System.Data.OleDb

Public Class frm_main
    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click

        End

    End Sub

    Private Sub btn_Store_Click(sender As Object, e As EventArgs) Handles btn_Store.Click

        frm_Store.ShowDialog()

    End Sub

    Private Sub frm_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lbl_day_name.Text = "امروز: " & " " & PersianDateTime.Today.DayName
        lbl_DateTime.Text = PersianDateTime.Today.Day _
            & " / " & PersianDateTime.Today.MonthName & " / " & PersianDateTime.Today.Year

        Call Load_data()

        ProgressBar1.Value = lbl_Delivery.Text
        ProgressBar2.Value = lbl_Order.Text
        ProgressBar3.Value = Mid(lbl_percent.Text, 1, lbl_percent.Text.Length - 1)

    End Sub

    Private Sub btn_Customers_Click(sender As Object, e As EventArgs) Handles btn_Customers.Click

        Frm_customers.ShowDialog()

    End Sub

    Private Sub btn_Users_Click(sender As Object, e As EventArgs) Handles btn_Users.Click

        Frm_Users.ShowDialog()

    End Sub

    Private Sub btn_Groups_Click(sender As Object, e As EventArgs) Handles btn_Groups.Click

        Frm_Group.ShowDialog()

    End Sub

    Private Sub bnt_Category_Click(sender As Object, e As EventArgs) Handles bnt_Category.Click

        Frm_Category.ShowDialog()

    End Sub

    Private Sub btn_Units_Click(sender As Object, e As EventArgs) Handles btn_Units.Click

        Frm_Unit.ShowDialog()

    End Sub

    Private Sub btn_Goods_Click(sender As Object, e As EventArgs) Handles btn_Goods.Click

        Frm_Goods.ShowDialog()

    End Sub

    Private Sub btn_GIS_Click(sender As Object, e As EventArgs) Handles btn_GIS.Click

        Frm_GInS.ShowDialog()

    End Sub

    Private Sub btn_Order_Click(sender As Object, e As EventArgs) Handles btn_Order.Click

        Frm_Order.ShowDialog()

    End Sub

    Private Sub btn_Give_Order_Click(sender As Object, e As EventArgs) Handles btn_Give_Order.Click

        Frm_Delivery.ShowDialog()

    End Sub
    Sub Load_data()

        ds.Reset()
        con = New OleDbConnection(strcon)
        con.Open()

        stroledb = "SELECT DISTINCT O_No, O_Delivery FROM tbl_Order"
        da = New OleDbDataAdapter(stroledb, con)
        da.Fill(ds, "tbl_Order")

        con.Close()

        lbl_Order.Text = 0
        lbl_Delivery.Text = 0
        For i = 0 To ds.Tables("tbl_Order").Rows.Count - 1
            If ds.Tables("tbl_Order").Rows(i).Item("O_Delivery") = "No" Then
                lbl_Order.Text += 1
            Else
                lbl_Delivery.Text += 1
            End If
        Next

        If ds.Tables("tbl_Order").Rows.Count = 0 Then
            lbl_percent.Text = "0%"
        Else
            lbl_percent.Text = (Math.Round((lbl_Delivery.Text * 100) / ds.Tables("tbl_Order").Rows.Count)) & "%"
        End If

    End Sub

    Private Sub btn_Archive_Click(sender As Object, e As EventArgs) Handles btn_Archive.Click

        frm_Delivered.ShowDialog()

    End Sub
End Class
