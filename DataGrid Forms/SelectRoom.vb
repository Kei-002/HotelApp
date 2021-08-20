Imports System.Data.OleDb
Public Class SelectRoom
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

    Private Sub SelectRoom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbTypes.Items.Clear()
        cmbTypes.Items.Add("Any")
        Guna2ShadowForm1.SetShadowForm(Me)
        checkOpen()
        dt = New DataTable("Guests")

        sql = "SELECT roomNum as RoomNum, roomtype as Type, roomRate as Rate, Capacity, Status FROM Rooms
               WHERE Status = 'Available'"

        cmd = New OleDbCommand(sql, con)
        dr = cmd.ExecuteReader

        dt.Load(dr)
        dgList.DataSource = dt
        dr.Dispose()


        sql1 = "SELECT DISTINCT roomType, Capacity FROM Rooms ORDER BY Capacity"

        cmd = New OleDbCommand(sql1, con)
        dr = cmd.ExecuteReader

        While dr.Read
            cmbTypes.Items.Add(dr("roomType"))
        End While

        cmbTypes.SelectedIndex = 0
        dr.Dispose()

        dgList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        con.Close()
    End Sub

    Private Sub cmdCLose_Click(sender As Object, e As EventArgs) Handles cmdCLose.Click
        Me.Close()
    End Sub

    Private Sub cmbTypes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTypes.SelectedIndexChanged
        dt = New DataTable
        Dim valAny As String
        If cmbTypes.SelectedItem = "Any" Then
            valAny = ""
        Else
            valAny = cmbTypes.SelectedItem
        End If

        checkOpen()
        sql = "SELECT roomNum as RoomNum, roomType as Type, roomRate as Rate, Capacity, Status FROM Rooms
               WHERE Status = 'Available' AND roomType like '%" & valAny & "%'"

        da = New OleDbDataAdapter(sql, con)

        da.Fill(dt)

        dgList.DataSource = dt
        con.Close()

    End Sub

    Private Sub dgList_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgList.MouseDoubleClick
        CheckIn.txtRoomNum.Text = Me.dgList.CurrentRow.Cells("RoomNum").Value
        CheckIn.txtRoomType.Text = Me.dgList.CurrentRow.Cells("Type").Value
        CheckIn.txtRate.Text = Me.dgList.CurrentRow.Cells("Rate").Value
        CheckIn.lblMaxOccu.Text = Me.dgList.CurrentRow.Cells("Capacity").Value

        Reservation.txtRoomNum.Text = Me.dgList.CurrentRow.Cells("RoomNum").Value
        Reservation.txtRoomType.Text = Me.dgList.CurrentRow.Cells("Type").Value
        Reservation.txtRate.Text = Me.dgList.CurrentRow.Cells("Rate").Value
        Reservation.lblMaxOccu.Text = Me.dgList.CurrentRow.Cells("Capacity").Value
        Me.Close()
    End Sub

    Private Sub cmdSelect_Click(sender As Object, e As EventArgs) Handles cmdSelect.Click
        CheckIn.txtRoomNum.Text = Me.dgList.CurrentRow.Cells("RoomNum").Value
        CheckIn.txtRoomType.Text = Me.dgList.CurrentRow.Cells("Type").Value
        CheckIn.txtRate.Text = Me.dgList.CurrentRow.Cells("Rate").Value
        CheckIn.lblMaxOccu.Text = Me.dgList.CurrentRow.Cells("Capacity").Value

        Reservation.txtRoomNum.Text = Me.dgList.CurrentRow.Cells("RoomNum").Value
        Reservation.txtRoomType.Text = Me.dgList.CurrentRow.Cells("Type").Value
        Reservation.txtRate.Text = Me.dgList.CurrentRow.Cells("Rate").Value
        Reservation.lblMaxOccu.Text = Me.dgList.CurrentRow.Cells("Capacity").Value
        Me.Close()
    End Sub

    Private Sub cmdRegister_Click(sender As Object, e As EventArgs) Handles cmdRegister.Click
        NewRoom.ShowDialog()
    End Sub
End Class