Imports System.Data.OleDb
Public Class Services
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
    Private Sub Services_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2ShadowForm1.SetShadowForm(Me)
        checkOpen()

        dt = New DataTable("CheckedIN")

        sql = "SELECT G.guestID as ID, guestName as Guest, R.roomNum as RoomNum, NumOfOccupants as GuestsInRoom
              FROM Guest G, Reservation RV, Rooms R
              WHERE G.guestID = RV.guestID AND RV.roomNum = R.roomNum AND Remarks = 'Checkin' and reserveStatus = 'Active'
              "

        cmd = New OleDbCommand(sql, con)
        dr = cmd.ExecuteReader

        dt.Load(dr)
        dgCheckedIn.DataSource = dt
        dr.Dispose()

        dgCheckedIn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        con.Close()


    End Sub

    Private Sub cmdCLose_Click(sender As Object, e As EventArgs) Handles cmdCLose.Click
        Me.Close()
    End Sub

    Private Sub cmdRoomService_Click(sender As Object, e As EventArgs) Handles cmdRoomService.Click
        Dim prompt As String = MsgBox("Avail room service?", vbQuestion + vbYesNo, "Avail")
        If prompt = vbNo Then
            MsgBox("Canceled")
        Else
            AvailService.txtGuestName.Text = Me.dgCheckedIn.CurrentRow.Cells("Guest").Value
            AvailService.txtRoomNum.Text = Me.dgCheckedIn.CurrentRow.Cells("RoomNum").Value
            AvailService.txtGuestID.Text = Me.dgCheckedIn.CurrentRow.Cells("ID").Value
            AvailService.txtOccu.Text = Me.dgCheckedIn.CurrentRow.Cells("GuestsInRoom").Value
            'AvailService.cmbServices.SelectedItem = ""
            AvailService.Show()
            AvailService.cmbServices.SelectedItem = "Room Service"
        End If
    End Sub

    Private Sub cmdCleaning_Click(sender As Object, e As EventArgs) Handles cmdCleaning.Click
        Dim prompt As String = MsgBox("Avail Cleaning service?", vbQuestion + vbYesNo, "Avail")
        If prompt = vbNo Then
            MsgBox("Canceled")
        Else
            AvailService.txtGuestName.Text = Me.dgCheckedIn.CurrentRow.Cells("Guest").Value
            AvailService.txtRoomNum.Text = Me.dgCheckedIn.CurrentRow.Cells("RoomNum").Value
            AvailService.txtGuestID.Text = Me.dgCheckedIn.CurrentRow.Cells("ID").Value
            AvailService.txtOccu.Text = Me.dgCheckedIn.CurrentRow.Cells("GuestsInRoom").Value
            'AvailService.cmbServices.SelectedItem = ""
            AvailService.Show()
            AvailService.cmbServices.SelectedItem = "Cleaning Service"
        End If
    End Sub

    Private Sub cmdDoctor_Click(sender As Object, e As EventArgs) Handles cmdDoctor.Click
        Dim prompt As String = MsgBox("Avail Doctor on Call Service?", vbQuestion + vbYesNo, "Avail")
        If prompt = vbNo Then
            MsgBox("Canceled")
        Else
            AvailService.txtGuestName.Text = Me.dgCheckedIn.CurrentRow.Cells("Guest").Value
            AvailService.txtRoomNum.Text = Me.dgCheckedIn.CurrentRow.Cells("RoomNum").Value
            AvailService.txtGuestID.Text = Me.dgCheckedIn.CurrentRow.Cells("ID").Value
            AvailService.txtOccu.Text = Me.dgCheckedIn.CurrentRow.Cells("GuestsInRoom").Value
            'AvailService.cmbServices.SelectedItem = ""
            AvailService.Show()
            AvailService.cmbServices.SelectedItem = "Doctor On Call"
        End If
    End Sub

    Private Sub cmdLaundry_Click(sender As Object, e As EventArgs) Handles cmdLaundry.Click
        Dim prompt As String = MsgBox("Avail Laundry service?", vbQuestion + vbYesNo, "Avail")
        If prompt = vbNo Then
            MsgBox("Canceled")
        Else
            AvailService.txtGuestName.Text = Me.dgCheckedIn.CurrentRow.Cells("Guest").Value
            AvailService.txtRoomNum.Text = Me.dgCheckedIn.CurrentRow.Cells("RoomNum").Value
            AvailService.txtGuestID.Text = Me.dgCheckedIn.CurrentRow.Cells("ID").Value
            AvailService.txtOccu.Text = Me.dgCheckedIn.CurrentRow.Cells("GuestsInRoom").Value
            'AvailService.cmbServices.SelectedItem = ""
            AvailService.Show()
            AvailService.cmbServices.SelectedItem = "Laundry Service"
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        checkOpen()

        dt = New DataTable

        sql = "SELECT G.guestID as ID, guestName as Guest, R.roomNum as RoomNum, NumOfOccupants as GuestsInRoom
              FROM Guest G, Reservation RV, Rooms R
              WHERE G.guestID = RV.guestID AND RV.roomNum = R.roomNum AND Remarks = 'Checkin' and reserveStatus = 'Active'
              AND guestName like '% " & txtSearch.Text & " %'
              "
        da = New OleDbDataAdapter(sql, con)

        da.Fill(dt)

        dgCheckedIn.DataSource = dt

        con.Close()
    End Sub
End Class