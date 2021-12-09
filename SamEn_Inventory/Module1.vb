Imports System.Data.OleDb

Module Module1

    Public strcon As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & My.Application.Info.DirectoryPath & "\Inventory_db.mdb"
    Public con As OleDbConnection
    Public stroledb As String = ""
    Public da As OleDbDataAdapter
    Public ds As New DataSet
    Public com As OleDbCommand

    Public Row_for_edit As Integer = 0
    Public Temp_String As String = ""
    Public Temp_String2 As String = ""
    Public Row_for_del As Integer = -1
    Public Temp_Count As Integer = 0

    Public arr_category(9) As String
    Public arr_G(9) As String
    Public arr_counter As Integer = 0

    Public Seperate_int As String = ""

    Public Date_Temp As String = "0000/00/00"

    Public Call_Report As Boolean = False
    Public User_Admin As Boolean = False
End Module
