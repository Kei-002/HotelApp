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
        Guna2ShadowForm1.SetShadowForm(Me)
        'con.ConnectionString = dbcon

        checkOpen()
        sql1 = "SELECT DISTINCT roomType, Capacity FROM Rooms ORDER BY Capacity"

        cmd = New OleDbCommand(sql1, con)
        dr = cmd.ExecuteReader

        While dr.Read
            cmbTypes.Items.Add(dr("roomType"))
        End While

        cmbTypes.SelectedIndex = 0
        dr.Dispose()

        con.Close()
    End Sub


    Private Sub cmbTypes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTypes.SelectedIndexChanged
        checkOpen()
        Dim valAny As String = cmbTypes.SelectedItem

        sql = "SELECT DISTINCT roomRate, Capacity FROM Rooms WHERE roomType = @rDesc"
        cmd = New OleDbCommand(sql, con)
        cmd.Parameters.AddWithValue("@rDesc", valAny)

        dr = cmd.ExecuteReader
        While dr.Read
            txtOccu.Text = dr("Capacity")
            txtRate.Text = dr("roomRate")
        End While

        con.Close()


    End Sub




    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click

        con.Open()
        Dim roomType As String = cmbTypes.SelectedItem

        sql = "INSERT INTO Rooms(roomNum ,roomType, roomRate, NumOfOccupants, Capacity, Status) 
              VALUES (@rNum, @rType, @rRate, @NumOccu, @rCapacity, @rStat)"

        cmd = New OleDbCommand(sql, con)

        With cmd
            .Parameters.AddWithValue("@rNum", txtRoomID.Text)
            .Parameters.AddWithValue("@rType", roomType)
            .Parameters.AddWithValue("@rRate", txtRate.Text)
            .Parameters.AddWithValue("@NumOccu", txtNumOccu.Text)
            .Parameters.AddWithValue("@rCapacity", txtOccu.Text)
            .Parameters.AddWithValue("@rStat", "Available")
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
        sql = "SELECT RoomTypeID FROM Room WHERE RoomDesc = @rName"

        cmd = New OleDbCommand(sql, con)
        cmd.Parameters.AddWithValue("@rName", TypeName)

        dr = cmd.ExecuteReader
        While dr.Read
            tID = dr(0)
        End While
        dr.Dispose()
        Return tID
    End Function

    Public Function getTpeRate(ByVal TypeName As String)

        Dim tID As Integer
        sql = "SELECT roomRate FROM Room WHERE RoomDesc = @rName"

        cmd = New OleDbCommand(sql, con)
        cmd.Parameters.AddWithValue("@rName", TypeName)

        dr = cmd.ExecuteReader
        While dr.Read
            tID = dr(0)
        End While
        dr.Dispose()
        Return tID

    End Function
#End Region



End Class