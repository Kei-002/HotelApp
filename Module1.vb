Imports System.Data.OleDb

Module Module1
    Public da As OleDbDataAdapter
    Public ds As New DataSet 'Temporarily Stores Data'

    Public sql, sql1 As String
    Public cmd, cmd1 As OleDbCommand
    Public dt As New DataTable

    Public dr As OleDbDataReader
    Public dbread As OleDbDataReader

    Public dbcon As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|/HotelTest.accdb"
    Public con As New OleDbConnection



    'Forms
    Public totalOccupants As Integer
    Public maxOccupants As Integer



    Public Sub checkOpen()

        If con.State = ConnectionState.Closed Then
            con.ConnectionString = dbcon
            con.Open()

        End If
    End Sub
End Module
