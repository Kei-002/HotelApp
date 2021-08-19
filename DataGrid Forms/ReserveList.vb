Imports System.Data.OleDb
Public Class ReserveList
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

    Private Sub ReserveList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkOpen()
        dt = New DataTable("Guests")

        sql = "Select reservationID, G.guestID As ID, guestName As Guest, R.roomNum As RoomNum, roomType As Type, roomRate As Rate, NumOfOccupants As GuestsInRoom,checkIN As InDate, checkOUT As OutDate FROM Guest G, Reservation RV, Rooms R
              WHERE G.guestID = RV.guestID And RV.roomNum = R.roomNum And reservationDesc = 'Reserve'"

        cmd = New OleDbCommand(sql, con)
        dr = cmd.ExecuteReader

        dt.Load(dr)
        dgList.DataSource = dt
        dr.Dispose()

        dgList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        con.Close()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        checkOpen()
        dt = New DataTable("Guests")

        sql = "Select reservationID, G.guestID As ID, guestName As Guest, R.roomNum As RoomNum, roomType As Type, roomRate As Rate, NumOfOccupants As GuestsInRoom,checkIN As InDate, checkOUT As OutDate FROM Guest G, Reservation RV, Rooms R
              WHERE G.guestID = RV.guestID And RV.roomNum = R.roomNum And reservationDesc = 'Reserve' AND guestName LIKE '%" & txtSearch.Text & "%'"

        cmd = New OleDbCommand(sql, con)
        dr = cmd.ExecuteReader

        dt.Load(dr)
        dgList.DataSource = dt
        dr.Dispose()

        dgList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        con.Close()
    End Sub

    Private Sub cmdCheckIn_Click(sender As Object, e As EventArgs) Handles cmdCheckIn.Click
        Try
            Dim guest_ID As Integer = Me.dgList.CurrentRow.Cells("ID").Value
            Dim room_Num As Integer = Me.dgList.CurrentRow.Cells("RoomNum").Value
            Dim reserveID As Integer = Me.dgList.CurrentRow.Cells("reservationID").Value
            Dim myStatus As String = "Checkin"
            Dim numGuest As Integer = Me.dgList.CurrentRow.Cells("GuestsInRoom").Value

            checkOpen()


            Dim i As Integer = UpdateGuestReservation(reserveID, myStatus, "Active")

            If i > 0 Then
                MsgBox("Customer reservation successfully checked in")
            Else
                MsgBox("Customer reservation check in failed")
            End If



            Dim j As Integer = SetRoomStatus(room_Num, numGuest, myStatus)

            If j > 0 Then
                MsgBox("Room " + room_Num.ToString + " set to Checkin")
            Else
                MsgBox("Room status set failed")
            End If



            Dim k As Integer = SetGuestRemarks(guest_ID, myStatus)
            If k > 0 Then
                MsgBox("Guest set to Checkin")
            Else
                MsgBox("Guest set failed")

            End If



        Catch ex As Exception

            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        checkOpen()


        Dim guest_ID As Integer = Me.dgList.CurrentRow.Cells("ID").Value
        Dim room_Num As Integer = Me.dgList.CurrentRow.Cells("RoomNum").Value
        Dim reserveID As Integer = Me.dgList.CurrentRow.Cells("reservationID").Value
        Dim numGuest As Integer = Me.dgList.CurrentRow.Cells("GuestsInRoom").Value
        Dim myStatus As String = "Available"

        Dim i As Integer = UpdateGuestReservation(reserveID, "Canceled", "Inactive")

        If i > 0 Then
            MsgBox("Customer reservation successfully cancelled")
        Else
            MsgBox("Customer reservation cancel failed")
        End If



        Dim j As Integer = SetRoomStatus(room_Num, numGuest, myStatus)

        If j > 0 Then
            MsgBox("Room " + room_Num.ToString + " set to Available")
        Else
            MsgBox("Room status set failed")
        End If



        Dim k As Integer = SetGuestRemarks(guest_ID, myStatus)
        If k > 0 Then
            MsgBox("Guest set to Available")
        Else
            MsgBox("Guest set failed")

        End If

        con.Close()
    End Sub
End Class