﻿Imports System.ComponentModel
Imports System.Data.OleDb
Public Class SelectGuest
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
    Private Sub SelectGuest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2ShadowForm1.SetShadowForm(Me)
        checkOpen()
        dt = New DataTable("Guests")

        sql = "SELECT guestID as ID, guestName as Guest, guestAddress as Address, guestAge as Age, guestPhone as PhoneNum,
               guestEmail as Email FROM Guest WHERE Remarks = 'Available'"

        cmd = New OleDbCommand(sql, con)
        dr = cmd.ExecuteReader

        dt.Load(dr)
        dgList.DataSource = dt
        dr.Dispose()

        dgList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgList.Sort(dgList.Columns(0), ListSortDirection.Ascending)
        con.Close()
    End Sub

    Private Sub cmdCLose_Click(sender As Object, e As EventArgs) Handles cmdCLose.Click
        Me.Close()
    End Sub


    Private Sub dgList_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgList.MouseDoubleClick
        CheckIn.lblGuestID.Text = Me.dgList.CurrentRow.Cells("ID").Value
        CheckIn.txtGuest.Text = Me.dgList.CurrentRow.Cells("Guest").Value

        Reservation.txtGuest.Text = Me.dgList.CurrentRow.Cells("Guest").Value
        Reservation.lblGuestID.Text = Me.dgList.CurrentRow.Cells("ID").Value
        dt.Clear()
        Me.Close()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        checkOpen()
        dt = New DataTable("Guests")

        sql = "SELECT guestID as ID, guestName as Guest, guestAddress as Address, guestAge as Age, guestPhone as PhoneNum,
               guestEmail as Email FROM Guest WHERE Remarks = 'Available'
               AND guestName like '%" & txtSearch.Text & "%'"

        cmd = New OleDbCommand(sql, con)
        dr = cmd.ExecuteReader

        dt.Load(dr)
        dgList.DataSource = dt
        dr.Dispose()

        dgList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        con.Close()
    End Sub

    Private Sub cmdRegister_Click(sender As Object, e As EventArgs) Handles cmdRegister.Click
        RegisterGuest.ShowDialog()

        Call SelectGuest_Load(sender, e)
    End Sub

    Private Sub cmdSelect_Click(sender As Object, e As EventArgs) Handles cmdSelect.Click
        CheckIn.lblGuestID.Text = Me.dgList.CurrentRow.Cells("ID").Value
        CheckIn.txtGuest.Text = Me.dgList.CurrentRow.Cells("Guest").Value

        Reservation.txtGuest.Text = Me.dgList.CurrentRow.Cells("Guest").Value
        Reservation.lblGuestID.Text = Me.dgList.CurrentRow.Cells("ID").Value
        dt.Clear()
        Me.Close()
    End Sub
End Class