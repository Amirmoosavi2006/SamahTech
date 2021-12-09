Imports System.Data.OleDb

Module variables

    Public Date_Name, Current_Date, Temp_Day, Temp_Month, Temp_Year, Temp_Date
    Public Temp_Username, user_role

    Public strcon As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & My.Application.Info.DirectoryPath & "\paw_db.mdb;Jet OLEDB:Database Password=Amir/1206;"
    Public con As New OleDbConnection(strcon)
    Public stroledb As String = ""
    Public da As OleDbDataAdapter
    Public ds As New DataSet
    Public com As OleDbCommand

    Public Work_no 'return selected work number for edit

End Module

