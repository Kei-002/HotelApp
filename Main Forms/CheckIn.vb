Imports System.ComponentModel
Imports System.Data.OleDb

Public Class CheckIn
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


    Private Sub CheckIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2ShadowForm1.SetShadowForm(Me)
        Dim time As DateTime = DateTime.Now

        dtpCheckIn.Text = time
        dtpCheckOut.Text = Now.AddDays(1D)
        txtNumDays.Text = 1


        checkOpen()

        sql = "Select * FROM PaymentType"
        cmd = New OleDbCommand(sql, con)

        dr = cmd.ExecuteReader

        While dr.Read

            cmbTypes.Items.Add(dr(0).ToString + " - " + dr(1).ToString)

        End While

        con.Close()

        cmbTypes.SelectedIndex = 0

    End Sub

    Private Sub cmdCLose_Click(sender As Object, e As EventArgs) Handles cmdCLose.Click
        Me.Close()
    End Sub





    Private Sub CheckIn_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim exit_app As String = MsgBox("Cancel Transaction?", vbQuestion + vbYesNo, "Cancel Check In")
        If exit_app = vbNo Then
            e.Cancel = True
        Else

        End If
    End Sub

    Private Sub cmdSelectGuest_Click(sender As Object, e As EventArgs) Handles cmdSelectGuest.Click
        SelectGuest.Show()
    End Sub

    Private Sub cmdSelectRoom_Click(sender As Object, e As EventArgs) Handles cmdSelectRoom.Click
        SelectRoom.ShowDialog()
        txtTotal.Text = Val(txtRate.Text) * Val(txtNumDays.Text)
        txtSubtotal.Text = Val(txtRate.Text) * Val(txtNumDays.Text)
        lblMinPay.Text = Val(txtSubtotal.Text) / 2
    End Sub

    Private Sub dtpCheckOut_ValueChanged(sender As Object, e As EventArgs) Handles dtpCheckOut.ValueChanged
        Dim T As TimeSpan = dtpCheckOut.Value - dtpCheckIn.Value
        If T.Days < 1 Then
            dtpCheckOut.Text = dtpCheckIn.Value.AddDays(1D)
            txtNumDays.Text = "1"
        Else
            txtNumDays.Text = T.Days
        End If

        txtTotal.Text = Val(txtRate.Text) * Val(txtNumDays.Text)
        txtSubtotal.Text = Val(txtRate.Text) * Val(txtNumDays.Text)

        lblMinPay.Text = Val(txtSubtotal.Text) / 2
    End Sub

    Private Sub cmdMinusCount_Click(sender As Object, e As EventArgs) Handles cmdMinusCount.Click
        totalOccupants = txtNumGuest.Text
        maxOccupants = lblMaxOccu.Text

        If totalOccupants > 1 Then
            txtNumGuest.Text = txtNumGuest.Text - 1
        End If
    End Sub

    Private Sub cmdAddCount_Click(sender As Object, e As EventArgs) Handles cmdAddCount.Click
        totalOccupants = txtNumGuest.Text
        maxOccupants = lblMaxOccu.Text

        If totalOccupants < maxOccupants Then
            txtNumGuest.Text = txtNumGuest.Text + 1
        End If
    End Sub

    Private Sub txtNumGuest_TextChanged(sender As Object, e As EventArgs) Handles txtNumGuest.TextChanged


        If txtNumGuest.Text = "" Or lblMaxOccu.Text = "" Then
            totalOccupants = 0
            maxOccupants = 0
        Else
            maxOccupants = lblMaxOccu.Text
            totalOccupants = txtNumGuest.Text
            If totalOccupants > maxOccupants Then
                MsgBox("Num of Occupants exceeds maximum capacity of the room")
                txtNumGuest.Text = 1
            End If
        End If


    End Sub

    Private Sub cmdCheckIn_Click(sender As Object, e As EventArgs) Handles cmdCheckIn.Click

        If txtAdvPay.Text < lblMinPay.Text Then
            MsgBox("Advance Payment insufficient. Amount should be half of subtotal")
            txtAdvPay.Text = 0
        Else

            Dim guest_ID As Integer = lblGuestID.Text
            Dim room_Num As Integer = txtRoomNum.Text
            Dim reserveDate As Date = Now.ToString("dd/MM/yyyy")
            Dim inDate As Date = Now.ToString("dd/MM/yyyy")
            Dim outDate As Date = dtpCheckOut.Value.ToString("dd/MM/yyyy")
            Dim numGuest As Integer = txtNumGuest.Text
            Dim advancePay As Decimal = txtAdvPay.Text
            Dim reserveDesc As String = "Checkin"
            Dim payType() As String = (cmbTypes.SelectedItem).ToString.Split(" ")
            Dim payTID As Integer = CInt(payType(0))

            checkOpen()


            Dim i As Integer = InsertGuestReservation(guest_ID, room_Num, reserveDesc, reserveDate, inDate, outDate, advancePay)
            If i > 0 Then
                MsgBox("Check In Complete. Enjoy your stay!")
            Else
                MsgBox("Check in failed. Try Again")
            End If


            Dim j As Integer = SetRoomStatus(room_Num, numGuest, "Occupied")

            If j > 0 Then
                MsgBox("Room " + room_Num.ToString + " status set to Occupied")
            Else
                MsgBox("Room set status failed")
            End If

            SetGuestRemarks(guest_ID, "Checkin")

            Dim k As Integer = InsertIntoPayment(guest_ID, "Advance Payment", payTID, inDate, advancePay)

            clear_text()

            con.Close()

        End If

    End Sub




    Private Sub clear_text()
        txtGuest.Clear()
        txtNumDays.Text = 1
        txtRoomNum.Clear()
        txtRoomType.Clear()
        txtRate.Clear()
        txtNumGuest.Text = 0
        lblMaxOccu.Text = "X"

        dtpCheckIn.Value = Now
        dtpCheckOut.Text = Now.AddDays(1D)

        txtSubtotal.Clear()
        txtTotal.Clear()
    End Sub

    Private Sub cmdViewCheckIns_Click(sender As Object, e As EventArgs) Handles cmdViewCheckIns.Click
        CurrentCheckIn.Show()
    End Sub

    Private Sub txtAdvPay_TextChanged(sender As Object, e As EventArgs) Handles txtAdvPay.TextChanged
        Dim adPay As Decimal
        If txtAdvPay.Text = "" Then
            adPay = 0
        ElseIf txtAdvPay.Text Like "[A-Za-z]" Then
            MsgBox("Advance only accepts numbers,")
            txtAdvPay.Text = 0
        Else
            adPay = txtAdvPay.Text
            txtTotal.Text = Val(txtSubtotal.Text) - adPay
        End If
    End Sub
End Class