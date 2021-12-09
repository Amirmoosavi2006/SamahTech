Imports System.Data.OleDb

Module Module1

    Public strcon As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & My.Application.Info.DirectoryPath & "\My_Work_db.mdb"
    Public con As OleDbConnection
    Public stroledb As String = ""
    Public da As OleDbDataAdapter
    Public ds As New DataSet
    Public com As OleDbCommand

    Public Temp_date As String = ""

    Public Temp_Work_no, Temp_Work_title As String

    Public P_bool As Boolean = False

    Public Final_Check As Boolean = False

End Module
