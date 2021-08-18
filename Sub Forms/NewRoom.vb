Imports System.Data.OleDb
Public Class NewRoom
#Region " Move Form "

    ' [ Move Form ]
    '
    ' // By Elektro 

    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point

    Public Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseDown ' Add more handles here (Example: PictureBox1.MouseDown)

        If e.Button = MouseButtons.Left Then
            MoveForm = True
            Me.Cursor = Cursors.NoMove2D
            MoveForm_MousePosition = e.Location
        End If

    End Sub

    Public Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseMove ' Add more handles here (Example: PictureBox1.MouseMove)

        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If

    End Sub

    Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseUp ' Add more handles here (Example: PictureBox1.MouseUp)

        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Me.Cursor = Cursors.Default
        End If

    End Sub




#End Region

    Private Sub NewRoom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'con.ConnectionString = dbcon

        checkOpen()

        txtRoomID.Text = getLastRoomID() + 1
        sql1 = "SELECT RoomDesc FROM RoomType"

        cmd = New OleDbCommand(sql1, con)

        dr = cmd.ExecuteReader
        While dr.Read
            cmbTypes.Items.Add(dr("RoomDesc"))
        End While

        dr.Dispose()
        con.Close()

    End Sub


    Private Sub cmbTypes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTypes.SelectedIndexChanged
        checkOpen()

        sql = "SELECT Capacity FROM RoomType WHERE RoomDesc = @rDesc"
        cmd = New OleDbCommand(sql, con)
        cmd.Parameters.AddWithValue("@rDesc", cmbTypes.SelectedItem)

        dr = cmd.ExecuteReader
        While dr.Read
            txtOccu.Text = dr(0)
        End While

        con.Close()

    End Sub




    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click

        con.Open()
        Dim rTypeID As Integer = getTypeID(cmbTypes.SelectedItem)

        sql = "INSERT INTO Rooms(RoomType, NumOccupants, RoomStatus) 
              VALUES (@rType, @rNum, @rStatus)"

        cmd = New OleDbCommand(sql, con)

        With cmd
            ' .Parameters.AddWithValue("@rID", txtRoomID.Text)
            .Parameters.AddWithValue("@rType", rTypeID)
            .Parameters.AddWithValue("@rNum", txtNumOccu.Text)
            .Parameters.AddWithValue("@rStatus", "Available")
        End With

        Dim i As Integer = cmd.ExecuteNonQuery

        If i > 0 Then
            MsgBox("Data Saved")
        Else
            MsgBox("Data save failed")
        End If

        cmd.Dispose()

        con.Close()

        Me.Close()
    End Sub


#Region "Functions"

    Private Function getTypeID(ByVal TypeName As String)
        Dim tID As Integer
        sql = "SELECT RoomTypeID FROM RoomType WHERE RoomDesc = @rName"

        cmd = New OleDbCommand(sql, con)
        cmd.Parameters.AddWithValue("@rName", TypeName)

        dr = cmd.ExecuteReader
        While dr.Read
            tID = dr(0)
        End While
        dr.Dispose()
        Return tID
    End Function

    Private Function getLastRoomID()
        Dim lastRoom As Integer
        sql = "SELECT LAST(RoomID) FROM Rooms"

        cmd = New OleDbCommand(sql, con)

        dr = cmd.ExecuteReader

        While dr.Read
            lastRoom = dr(0)
        End While

        dr.Dispose()

        Return lastRoom
    End Function
#End Region



End Class