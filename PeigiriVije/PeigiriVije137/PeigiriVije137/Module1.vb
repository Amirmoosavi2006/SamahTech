Imports System.Data.OleDb

Module Module1

    Public strcon As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & My.Application.Info.DirectoryPath & "\PV_db.mdb"
    Public con As OleDbConnection
    Public stroledb As String = ""
    Public da As OleDbDataAdapter
    Public ds As New DataSet
    Public com As OleDbCommand

    Public Temp_Date = ""
    Public User_Name = ""
    Public User_Role As Boolean
    Public Row_for_edit = ""
    Public Temp_String = ""
    Public Row_for_del = ""
    Public Pass_Keeper = ""

    Public Change_Check As Boolean = False
    Public temp_i

End Module
