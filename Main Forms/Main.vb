Imports System.Data.OleDb
Public Class Main
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

#Region " Form Closing "
    Private Sub cmdCLose_Click(sender As Object, e As EventArgs) Handles cmdCLose.Click
        Me.Close()
    End Sub


    Private Sub Main_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.Closing
        Dim exit_app As String = MsgBox("Exit application?", vbQuestion + vbYesNo, "Exit")
        If exit_app = vbNo Then
            e.Cancel = True
        Else
            End
        End If
    End Sub


#End Region

    Private Sub cmdMinimize_Click(sender As Object, e As EventArgs) Handles cmdMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2ShadowForm1.SetShadowForm(Me)

        checkOpen()

        sql = "SELECT COUNT(guestID) FROM Guest"
        cmd = New OleDbCommand(sql, con)

        dr = cmd.ExecuteReader
        While dr.Read
            lblGuests.Text = dr(0)
        End While
        dr.Dispose()


        sql1 = "SELECT COUNT(roomNum) FROM Rooms WHERE Status = 'Available'"

        cmd = New OleDbCommand(sql1, con)

        dr = cmd.ExecuteReader

        While dr.Read
            lblRoomsOccupied.Text = dr(0)
        End While
        dr.Dispose()


        sql2 = "SELECT COUNT(reservationID) from Reservation WHERE reserveStatus = 'Active'
                AND checkOUT = #" & Now.ToString("dd/MM/yyyy") & "#"

        cmd = New OleDbCommand(sql2, con)

        dr = cmd.ExecuteReader

        While dr.Read
            lblCheckOut.Text = dr(0)
        End While
        dr.Dispose()


        con.Close()
    End Sub

    Private Sub cmdCheckIn_Click(sender As Object, e As EventArgs) Handles cmdCheckIn.Click


        cmdCheckIn.Checked = True
        CheckIn.ShowDialog()

        cmdCheckIn.Checked = False
        Call Main_Load(sender, e)
    End Sub

    Private Sub cmdCheckOut_Click(sender As Object, e As EventArgs) Handles cmdCheckOut.Click
        cmdCheckOut.Checked = True
        CheckOut.ShowDialog()
        Call Main_Load(sender, e)
        cmdCheckOut.Checked = False
    End Sub

    Private Sub cmdReservation_Click(sender As Object, e As EventArgs) Handles cmdReservation.Click
        cmdReservation.Checked = True
        Reservation.ShowDialog()
        Call Main_Load(sender, e)
        cmdReservation.Checked = False
    End Sub

    Private Sub cmdGuest_Click(sender As Object, e As EventArgs) Handles cmdGuest.Click
        cmdGuest.Checked = True
        Guests.ShowDialog()
        Call Main_Load(sender, e)
        cmdGuest.Checked = False
    End Sub

    Private Sub cmdRoom_Click(sender As Object, e As EventArgs) Handles cmdRoom.Click
        cmdRoom.Checked = True
        Rooms.ShowDialog()
        Call Main_Load(sender, e)
        cmdRoom.Checked = False
    End Sub

    Private Sub cmdServices_Click(sender As Object, e As EventArgs) Handles cmdServices.Click
        cmdServices.Checked = True
        Services.ShowDialog()
        Call Main_Load(sender, e)
        cmdServices.Checked = False
    End Sub

    Private Sub cmdFeedback_Click(sender As Object, e As EventArgs) Handles cmdFeedback.Click
        cmdFeedback.Checked = True
        Feedback.ShowDialog()
        Call Main_Load(sender, e)
        cmdFeedback.Checked = False
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs)
        ServicesReportForm.Show()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        PaymentReport.Show()
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs)
        RoomReportForm.Show()
    End Sub

    Private Sub cmdFeedbackRep_Click(sender As Object, e As EventArgs)
        FeedReportForm.Show()
    End Sub

    Private Sub Guna2Button1_Click_1(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Call Main_Load(sender, e)
    End Sub
End Class
