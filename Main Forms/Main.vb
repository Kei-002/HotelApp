
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

    End Sub

    Private Sub cmdCheckIn_Click(sender As Object, e As EventArgs) Handles cmdCheckIn.Click
        cmdCheckIn.Checked = True
        CheckIn.ShowDialog()
        cmdCheckIn.Checked = False
    End Sub

    Private Sub cmdCheckOut_Click(sender As Object, e As EventArgs) Handles cmdCheckOut.Click
        cmdCheckOut.Checked = True
        CheckOut.ShowDialog()
        cmdCheckOut.Checked = False
    End Sub

    Private Sub cmdReservation_Click(sender As Object, e As EventArgs) Handles cmdReservation.Click
        cmdReservation.Checked = True
        Reservation.ShowDialog()
        cmdReservation.Checked = False
    End Sub

    Private Sub cmdGuest_Click(sender As Object, e As EventArgs) Handles cmdGuest.Click
        cmdGuest.Checked = True
        Guests.ShowDialog()
        cmdGuest.Checked = False
    End Sub

    Private Sub cmdRoom_Click(sender As Object, e As EventArgs) Handles cmdRoom.Click
        cmdRoom.Checked = True
        Rooms.ShowDialog()
        cmdRoom.Checked = False
    End Sub

    Private Sub cmdServices_Click(sender As Object, e As EventArgs) Handles cmdServices.Click
        cmdServices.Checked = True
        Services.ShowDialog()
        cmdServices.Checked = False
    End Sub

    Private Sub cmdFeedback_Click(sender As Object, e As EventArgs) Handles cmdFeedback.Click
        cmdFeedback.Checked = True
        Feedback.ShowDialog()
        cmdFeedback.Checked = False
    End Sub
End Class
