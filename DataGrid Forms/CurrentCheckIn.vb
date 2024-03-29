﻿Imports System.ComponentModel
Imports System.Data.OleDb

Public Class CurrentCheckIn
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

    Private Sub cmdCLose_Click(sender As Object, e As EventArgs) Handles cmdCLose.Click
        Me.Close()
    End Sub

    Private Sub CurrentCheckIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Guna2ShadowForm1.SetShadowForm(Me)
        checkOpen()
        dt = New DataTable("CheckedIN")

        sql = "SELECT G.guestID as ID, guestName as Guest, reservationID as ReserveID, R.roomNum as RoomNum, roomType as Type, roomRate as Rate, NumOfOccupants as GuestsInRoom,checkIN as InDate, checkOUT as OutDate, advancePayment as AdvancePayment
              FROM Guest G, Reservation RV, Rooms R
              WHERE G.guestID = RV.guestID AND RV.roomNum = R.roomNum and reserveStatus = 'Active'"
        'Remarks = 'Checkin'
        cmd = New OleDbCommand(sql, con)
        dr = cmd.ExecuteReader

        dt.Load(dr)
        dgCheckedIn.DataSource = dt
        dr.Dispose()

        dgCheckedIn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgCheckedIn.Sort(dgCheckedIn.Columns(9), ListSortDirection.Ascending)
        con.Close()
        'dgCheckedIn.CurrentCell.Selected = False
        dgCheckedIn.ClearSelection()
    End Sub

    Private Sub dgCheckedIn_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgCheckedIn.MouseDoubleClick
        Dim serviceFees As Decimal = 0
        Dim gID As Integer = Me.dgCheckedIn.CurrentRow.Cells("ID").Value
        CheckOut.lblGuestID.Text = gID
        CheckOut.txtGuest.Text = Me.dgCheckedIn.CurrentRow.Cells("Guest").Value
        CheckOut.txtRoomNum.Text = Me.dgCheckedIn.CurrentRow.Cells("RoomNum").Value
        CheckOut.txtRoomType.Text = Me.dgCheckedIn.CurrentRow.Cells("Type").Value
        CheckOut.txtRate.Text = Me.dgCheckedIn.CurrentRow.Cells("Rate").Value
        CheckOut.lblReserveID.Text = Me.dgCheckedIn.CurrentRow.Cells("ReserveID").Value
        CheckOut.dtpCheckIn.Text = Me.dgCheckedIn.CurrentRow.Cells("InDate").Value
        CheckOut.dtpCheckOut.Text = Me.dgCheckedIn.CurrentRow.Cells("OutDate").Value
        CheckOut.txtNumGuest.Text = Me.dgCheckedIn.CurrentRow.Cells("GuestsInRoom").Value
        CheckOut.txtAdvance.Text = Me.dgCheckedIn.CurrentRow.Cells("AdvancePayment").Value
        checkOpen()
        sql = "SELECT serviceFee FROM Services WHERE Status = 'Active' AND guestID = " & gID

        cmd = New OleDbCommand(sql, con)
        dr = cmd.ExecuteReader

        While dr.Read
            serviceFees = serviceFees + Val(dr(0))
        End While
        dr.Dispose()

        CheckOut.txtServiceAvailed.Text = serviceFees
        con.Close()
        Me.Close()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        checkOpen()
        dt = New DataTable("CheckedIN")

        sql = "SELECT G.guestID as ID, guestName as Guest, reservationID as ReserveID, R.roomNum as RoomNum, roomType as Type, roomRate as Rate, NumOfOccupants as GuestsInRoom,checkIN as InDate, checkOUT as OutDate, advancePayment as AdvancePayment
              FROM Guest G, Reservation RV, Rooms R
              WHERE G.guestID = RV.guestID AND RV.roomNum = R.roomNum AND Remarks = 'Checkin' and reserveStatus = 'Active'
              AND guestName like '%" & txtSearch.Text & "%'"

        cmd = New OleDbCommand(sql, con)
        dr = cmd.ExecuteReader

        dt.Load(dr)
        dgCheckedIn.DataSource = dt
        dr.Dispose()

        dgCheckedIn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        'dgCheckedIn.Sort(dgCheckedIn.Columns(9), ListSortDirection.Ascending)
        con.Close()
    End Sub

    Private Sub cmdSelect_Click(sender As Object, e As EventArgs) Handles cmdSelect.Click
        Dim serviceFees As Decimal = 0
        Dim gID As Integer = Me.dgCheckedIn.CurrentRow.Cells("ID").Value
        CheckOut.lblGuestID.Text = gID
        CheckOut.txtGuest.Text = Me.dgCheckedIn.CurrentRow.Cells("Guest").Value
        CheckOut.txtRoomNum.Text = Me.dgCheckedIn.CurrentRow.Cells("RoomNum").Value
        CheckOut.txtRoomType.Text = Me.dgCheckedIn.CurrentRow.Cells("Type").Value
        CheckOut.txtRate.Text = Me.dgCheckedIn.CurrentRow.Cells("Rate").Value
        CheckOut.lblReserveID.Text = Me.dgCheckedIn.CurrentRow.Cells("ReserveID").Value
        CheckOut.dtpCheckIn.Text = Me.dgCheckedIn.CurrentRow.Cells("InDate").Value
        CheckOut.dtpCheckOut.Text = Me.dgCheckedIn.CurrentRow.Cells("OutDate").Value
        CheckOut.txtNumGuest.Text = Me.dgCheckedIn.CurrentRow.Cells("GuestsInRoom").Value
        CheckOut.txtAdvance.Text = Me.dgCheckedIn.CurrentRow.Cells("AdvancePayment").Value

        Extend.lblGuestID.Text = gID
        Extend.txtGuest.Text = Me.dgCheckedIn.CurrentRow.Cells("Guest").Value
        Extend.txtRoomNum.Text = Me.dgCheckedIn.CurrentRow.Cells("RoomNum").Value
        Extend.txtRoomType.Text = Me.dgCheckedIn.CurrentRow.Cells("Type").Value
        Extend.txtRate.Text = Me.dgCheckedIn.CurrentRow.Cells("Rate").Value
        Extend.lblReserveID.Text = Me.dgCheckedIn.CurrentRow.Cells("ReserveID").Value
        Extend.dtpCheckIn.Text = Me.dgCheckedIn.CurrentRow.Cells("InDate").Value
        Extend.dtpCheckOut.Text = Me.dgCheckedIn.CurrentRow.Cells("OutDate").Value
        Extend.txtNumGuest.Text = Me.dgCheckedIn.CurrentRow.Cells("GuestsInRoom").Value
        Extend.lblOldAdvance.Text = Me.dgCheckedIn.CurrentRow.Cells("AdvancePayment").Value
        'Extend.txtAdvPay.Text = Me.dgCheckedIn.CurrentRow.Cells("AdvancePayment").Value


        checkOpen()
        sql = "SELECT serviceFee FROM Services WHERE Status = 'Active' AND guestID = " & gID

        cmd = New OleDbCommand(sql, con)
        dr = cmd.ExecuteReader

        While dr.Read
            serviceFees = serviceFees + Val(dr(0))
        End While
        dr.Dispose()

        CheckOut.txtServiceAvailed.Text = serviceFees
        con.Close()
        Me.Close()
    End Sub

    Private Sub dgCheckedIn_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgCheckedIn.CellFormatting
        For Each row As DataGridViewRow In dgCheckedIn.Rows

            If row.Cells("OutDate").Value = Now.ToString("dd/MM/yyyy") Then

                row.DefaultCellStyle.ForeColor = Color.White
                row.DefaultCellStyle.BackColor = Color.DarkRed


            End If


        Next

    End Sub
End Class