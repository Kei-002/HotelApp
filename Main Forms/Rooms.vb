Imports System.ComponentModel
Imports System.Data.OleDb

Public Class Rooms

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

#Region "Form Close"
    Private Sub cmdCLose_Click(sender As Object, e As EventArgs) Handles cmdCLose.Click
        Me.Close()
    End Sub
    Private Sub Rooms_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim exit_app As String = MsgBox("Cancel Transaction?", vbQuestion + vbYesNo, "Cancel Check In")
        If exit_app = vbNo Then
            e.Cancel = True
        Else

        End If
    End Sub

#End Region
    Private Sub Rooms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2ShadowForm1.SetShadowForm(Me)

        checkOpen()
        ds = New DataSet

        sql = "SELECT roomNum as RoomNum, roomType as Type, roomRate as RatePerNight, NumOfOccupants as GuestInRoom, Capacity, Status
               FROM Rooms"


        da = New OleDbDataAdapter(sql, con)

        da.Fill(ds, "AllRooms")

        dgRooms.DataSource = ds.Tables("AllRooms")
        da.Dispose()


        sql1 = "SELECT DISTINCT roomType, Capacity FROM Rooms ORDER BY Capacity"

        cmd = New OleDbCommand(sql1, con)
        dr = cmd.ExecuteReader

        While dr.Read
            cmbTypes.Items.Add(dr("roomType"))
        End While

        cmbTypes.SelectedIndex = 0

        dgRooms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub


    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        ''con.ConnectionString = dbcon
        checkOpen()
        ds = New DataSet

        sql = "SELECT roomNum as RoomNum, roomType as Type, roomRate as RatePerNight, NumOfOccupants as GuestInRoom,Capacity, Status FROM Rooms
               WHERE roomType LIKE '%" & txtSearch.Text & "%'"


        da = New OleDbDataAdapter(sql, con)

        da.Fill(ds, "AllRooms")

        dgRooms.DataSource = ds.Tables("AllRooms")
        da.Dispose()
        con.Close()
    End Sub

    Private Sub dgGuests_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgRooms.MouseDoubleClick
        txtRoomID.Text = Me.dgRooms.CurrentRow.Cells("RoomNum").Value
        cmbTypes.SelectedItem = Me.dgRooms.CurrentRow.Cells("Type").Value
        txtRate.Text = Me.dgRooms.CurrentRow.Cells("RatePerNight").Value
        txtNumOccu.Text = Me.dgRooms.CurrentRow.Cells("GuestInRoom").Value
        txtOccu.Text = Me.dgRooms.CurrentRow.Cells("Capacity").Value

        Dim stat As String = Me.dgRooms.CurrentRow.Cells("Status").Value

        If stat = "Available" Then
            rbAvail.Checked = True
        ElseIf stat = "Reserved" Then
            rbReserved.Checked = True
        Else
            rbOccu.Checked = True
        End If

        'txtRoomID.Enabled = True
        cmbTypes.Enabled = True
        txtRate.Enabled = True
        txtNumOccu.Enabled = True
        txtOccu.Enabled = True

        cmdUpdate.Enabled = True
        cmdDelete.Enabled = True

    End Sub


    Private Sub cmdNew_Click(sender As Object, e As EventArgs) Handles cmdNew.Click

        Dim nRoom As New NewRoom
        nRoom.ShowDialog()
        Call Rooms_Load(sender, e)
    End Sub


    Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click

        Dim room_Num As Integer = txtRoomID.Text
        Dim room_type As String = cmbTypes.SelectedItem
        Dim room_rate As Decimal = txtRate.Text
        Dim NumOccu As Integer = txtNumOccu.Text
        Dim capa As Integer = txtOccu.Text
        Dim stat As String
        If rbAvail.Checked = True Then
            stat = "Available"
        ElseIf rbReserved.Checked = True Then
            stat = "Reserved"
        Else
            stat = "Occupied"
        End If


        checkOpen()

        sql = "UPDATE Rooms SET roomType = @rType, roomRate = @rRate,
              NumOfOccupants = @NumOccu, Capacity = @capa, Status = @stat
              WHERE roomNum = @rNum"

        cmd = New OleDbCommand(sql, con)

        cmd.Parameters.AddWithValue("@rType", room_type)
        cmd.Parameters.AddWithValue("@rRate", room_rate)
        cmd.Parameters.AddWithValue("@NumOccu", NumOccu)
        cmd.Parameters.AddWithValue("@capa", capa)
        cmd.Parameters.AddWithValue("@stat", stat)
        cmd.Parameters.AddWithValue("@rNum", room_Num)

        Dim i As Integer = cmd.ExecuteNonQuery

        If i > 0 Then
            MsgBox("Room successfully updated")
        Else
            MsgBox("Room update failed")
        End If


        con.Close()

        Call Rooms_Load(sender, e)
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        checkOpen()
        Dim room_Num As Integer = txtRoomID.Text

        sql = "DELETE FROM Rooms WHERE roomNum = @rNum"
        cmd = New OleDbCommand(sql, con)

        cmd.Parameters.AddWithValue("@rNum", room_Num)
        Dim i As Integer = cmd.ExecuteNonQuery

        If i > 0 Then
            MsgBox("Room successfully deleted")
        Else
            MsgBox("Room delete failed")
        End If

        con.Close()

        Call Rooms_Load(sender, e)
    End Sub
End Class