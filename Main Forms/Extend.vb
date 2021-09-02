Public Class Extend


    Private Sub cmdSelectGuest_Click(sender As Object, e As EventArgs) Handles cmdSelectGuest.Click
        CurrentCheckIn.ShowDialog()

        Dim T As TimeSpan = dtpCheckOut.Value - dtpCheckIn.Value
        If T.Days < 1 Then
            dtpCheckOut.Text = dtpCheckIn.Value.AddDays(1D)
            txtNumDays.Text = "1"
        Else
            txtNumDays.Text = T.Days
            lblPrevNum.Text = T.Days
        End If

        lblOldSub.Text = Val(txtRate.Text) * Val(txtNumDays.Text)
        lblOldTotal.Text = Val(lblOldSub.Text) - Val(lblOldAdvance.Text)

        txtPrevPay.Text = lblOldAdvance.Text


        txtSubtotal.Text = Val(txtRate.Text) * Val(txtNumDays.Text)
        txtTotal.Text = Val(txtSubtotal.Text) - Val(lblOldAdvance.Text) ' + Val(txtServiceAvailed.Text)
        'lblBalance.Text = Val(txtSubtotal.Text) - Val(txtAdvPay.Text)

    End Sub

    Private Sub dtpCheckOut_ValueChanged(sender As Object, e As EventArgs) Handles dtpCheckOut.ValueChanged

        Dim T As TimeSpan = dtpCheckOut.Value - dtpCheckIn.Value
        If T.Days < 1 Then
            dtpCheckOut.Text = dtpCheckIn.Value.AddDays(1D)
            txtNumDays.Text = "1"
        Else
            txtNumDays.Text = T.Days
        End If

        Dim disNum As Integer = T.Days - Val(lblPrevNum.Text)


        txtSubtotal.Text = Val(lblOldSub.Text) + (Val(txtRate.Text) * Val(disNum))
        txtTotal.Text = Val(txtSubtotal.Text) - Val(txtAdvPay.Text) - Val(lblOldAdvance.Text)

        Dim miPay As Decimal = Val(txtSubtotal.Text) - Val(lblOldSub.Text)

        lblMinPay.Text = miPay / 2
    End Sub

    Private Sub txtAdvPay_TextChanged(sender As Object, e As EventArgs) Handles txtAdvPay.TextChanged, txtPrevPay.TextChanged
        Dim gCash As Decimal
        If txtAdvPay.Text = "" Then
            gCash = 0
        Else
            gCash = txtAdvPay.Text
            txtTotal.Text = Val(txtSubtotal.Text) - (gCash + Val(lblOldAdvance.Text))

        End If
    End Sub

    Private Sub cmdCheckIn_Click(sender As Object, e As EventArgs) Handles cmdCheckIn.Click

        If txtAdvPay.Text < lblMinPay.Text Then
            MsgBox("Advance Payment insufficient. Amount should be half of subtotal")
            txtAdvPay.Text = 0
        Else

            Dim resID As Integer = lblReserveID.Text
            Dim guest_ID As Integer = lblGuestID.Text
            Dim room_Num As Integer = txtRoomNum.Text
            Dim reserveDate As Date = Now.ToString("dd/MM/yyyy")
            Dim inDate As Date = Now.ToString("dd/MM/yyyy")
            Dim outDate As Date = dtpCheckOut.Value.ToString("dd/MM/yyyy")
            Dim numGuest As Integer = txtNumGuest.Text
            Dim advancePay As Decimal = Val(txtPrevPay.Text) + Val(txtAdvPay.Text)
            Dim reserveDesc As String = "Extended"
            'Dim payType() As String = (cmbTypes.SelectedItem).ToString.Split(" ")
            'Dim payTID As Integer = CInt(payType(0))

            checkOpen()


            Dim i As Integer = UpdateGuestExtend(resID, reserveDesc, outDate, advancePay)
            If i > 0 Then
                MsgBox("Check In Extended . Enjoy your stay!")
            Else
                MsgBox("Extension failed. Try Again")
            End If


            'Dim j As Integer = SetRoomStatus(room_Num, numGuest, "Occupied")

            'If j > 0 Then
            '    MsgBox("Room " + room_Num.ToString + " status set to Occupied")
            'Else
            '    MsgBox("Room set status failed")
            'End If

            'SetGuestRemarks(guest_ID, "Checkin")

            'Dim k As Integer = InsertIntoPayment(guest_ID, "Advance Payment", payTID, inDate, advancePay)


            con.Close()
        End If
    End Sub

    Private Sub cmdCLose_Click(sender As Object, e As EventArgs) Handles cmdCLose.Click
        Me.Close()
    End Sub
End Class