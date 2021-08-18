Imports System.ComponentModel
Imports System.Data.OleDb

Public Class Rooms

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

#Region "Form Close"
    Private Sub cmdCLose_Click(sender As Object, e As EventArgs) Handles cmdCLose.Click
        Me.Close()
    End Sub
    Private Sub Rooms_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim exit_app As String = MsgBox("Cancel Transaction?", vbQuestion + vbYesNo, "Cancel Check In")
        If exit_app = vbNo Then
            e.Cancel = True
        Else

        End If
    End Sub

#End Region
    Private Sub Rooms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2ShadowForm1.SetShadowForm(Me)

        con.ConnectionString = dbcon
        con.Open()
        ds = New DataSet

        sql = "SELECT roomNum as RoomNum, roomType as Type, roomRate as RatePerNight, Capacity, Status FROM Rooms"

        da = New OleDbDataAdapter(sql, con)

        da.Fill(ds, "AllRooms")

        dgGuests.DataSource = ds.Tables("AllRooms")
        da.Dispose()


        dgGuests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    'Private Sub dgGuests_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgGuests.MouseDoubleClick
    '    txtRoomID.Text = Me.dgGuests.CurrentRow.Cells("RoomID").Value
    '    cmbTypes.SelectedItem = Me.dgGuests.CurrentRow.Cells("RoomDesc").Value
    '    txtNumOccu.Text = Me.dgGuests.CurrentRow.Cells("NumOccupants").Value
    '    If Me.dgGuests.CurrentRow.Cells("roomStatus").Value = "Available" Then
    '        rbAvail.Checked = True
    '    Else
    '        rbOccu.Checked = True
    '    End If

    'End Sub

    'Private Sub rbAvail_CheckedChanged(sender As Object, e As EventArgs)
    '    If rbAvail.Checked = True Then
    '        txtNumOccu.Text = 0
    '    Else
    '        txtNumOccu.Text = Me.dgGuests.CurrentRow.Cells("NumOccupants").Value
    '    End If
    'End Sub



    'Private Sub cmbTypes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTypes.SelectedIndexChanged
    '    checkOpen()

    '    sql = "SELECT Capacity FROM RoomType WHERE RoomDesc = @rDesc"
    '    cmd = New OleDbCommand(sql, con)
    '    cmd.Parameters.AddWithValue("@rDesc", cmbTypes.SelectedItem)

    '    dr = cmd.ExecuteReader
    '    While dr.Read
    '        txtOccu.Text = dr(0)
    '    End While

    '    con.Close()
    'End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        ''con.ConnectionString = dbcon
        checkOpen()
        ds = New DataSet

        sql = "SELECT roomNum as RoomNum, roomType as Type, roomRate as RatePerNight, Capacity, Status FROM Rooms
               WHERE roomType LIKE '%" & txtSearch.Text & "%'"


        da = New OleDbDataAdapter(sql, con)

        da.Fill(ds, "AllRooms")

        dgGuests.DataSource = ds.Tables("AllRooms")
        da.Dispose()
        con.Close()
    End Sub

    Private Sub cmdNew_Click(sender As Object, e As EventArgs) Handles cmdNew.Click

        Dim nRoom As New NewRoom
        nRoom.ShowDialog()
        Call Rooms_Load(sender, e)
    End Sub
End Class