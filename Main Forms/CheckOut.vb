Imports System.ComponentModel
Imports System.Data.OleDb
Public Class CheckOut
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

    Private Sub CheckOut_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2ShadowForm1.SetShadowForm(Me)
        checkOpen()

        sql = "Select * FROM PaymentType"
        cmd = New OleDbCommand(sql, con)

        dr = cmd.ExecuteReader

        While dr.Read

            cmbType.Items.Add(dr(0).ToString + " - " + dr(1).ToString)

        End While

        con.Close()

        cmbType.SelectedIndex = 0
    End Sub


    Private Sub cmdCLose_Click(sender As Object, e As EventArgs) Handles cmdCLose.Click
        Me.Close()
    End Sub

    Private Sub CheckOut_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim exit_app As String = MsgBox("Cancel Transaction?", vbQuestion + vbYesNo, "Cancel Check In")
        If exit_app = vbNo Then
            e.Cancel = True


        End If
    End Sub

    Private Sub cmdCheckList_Click(sender As Object, e As EventArgs) Handles cmdCheckList.Click

        CurrentCheckIn.ShowDialog()
        Dim T As TimeSpan = dtpCheckOut.Value - dtpCheckIn.Value
        If T.Days < 1 Then
            dtpCheckOut.Text = dtpCheckIn.Value.AddDays(1D)
            txtNumDays.Text = "1"
        Else
            txtNumDays.Text = T.Days
        End If

        txtTotal.Text = Val(txtRate.Text) * Val(txtNumDays.Text)
        txtSubtotal.Text = Val(txtRate.Text) * Val(txtNumDays.Text)
    End Sub

    Private Sub txtCash_TextChanged(sender As Object, e As EventArgs) Handles txtCash.TextChanged
        Dim gCash As Decimal
        If txtCash.Text = "" Then
            gCash = 0
        Else
            gCash = txtCash.Text
            txtChange.Text = gCash - Val(txtTotal.Text)

        End If
    End Sub

    Private Sub txtCheckOut_Click(sender As Object, e As EventArgs) Handles txtCheckOut.Click


        Dim guestID As Integer = lblGuestID.Text
        Dim roomNum As Integer = txtRoomNum.Text
        Dim payDesc As String = "Checkout payment"
        Dim payType() As String = (cmbType.SelectedItem).ToString.Split(" ")
        Dim payTID As Integer = CInt(payType(0))
        Dim payDate As Date = Now.ToString("dd/MM/yyyy")
        Dim payAmount As Decimal = txtTotal.Text

        checkOpen()

        Dim gCash As Decimal
        gCash = txtCash.Text
        If gCash < CDec(txtTotal.Text) Then
            MsgBox("Insuffecient Cash")
            txtCash.Text = 0
            txtChange.Text = 0
        Else
            gCash = txtCash.Text
            txtChange.Text = Val(txtTotal.Text) - gCash

            Dim i As Integer = InsertIntoPayment(guestID, payDesc, payTID, payDate, payAmount)

            If i > 0 Then

                MsgBox("Payment Complete. Hope you enjoyed your stay")

            Else
                MsgBox("Payment Failed. Try Again")
            End If



            Dim j As Integer = SetGuestRemarks(guestID, "Available")
            If j > 0 Then

                MsgBox("Guest set to Available")

            Else
                MsgBox("Guest set failed")
            End If


            Dim k As Integer = SetRoomStatus(roomNum, "Available")

            If k > 0 Then

                MsgBox("Room " + roomNum.ToString + " set to Available")

            Else
                MsgBox("Room set failed")
            End If
        End If


        con.Close()
        clear_text()
    End Sub


    Private Sub clear_text()
        txtGuest.Clear()
        txtNumDays.Text = 1
        txtRoomNum.Clear()
        txtRoomType.Clear()
        txtRate.Clear()
        txtNumGuest.Text = 0
        'lblMaxOccu.Text = "X"

        dtpCheckIn.Value = Now
        dtpCheckOut.Text = Now.AddDays(1D)

        txtSubtotal.Clear()
        txtTotal.Clear()

        txtCash.Text = 0
        txtChange.Text = 0
    End Sub


End Class