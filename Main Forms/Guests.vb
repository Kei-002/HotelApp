Imports System.ComponentModel
Imports System.Data.OleDb
Public Class Guests
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

    Private Sub Guests_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim exit_app As String = MsgBox("Cancel Transaction?", vbQuestion + vbYesNo, "Cancel Check In")
        If exit_app = vbNo Then
            e.Cancel = True
        Else

        End If
    End Sub
#End Region

    Private Sub Guests_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Guna2ShadowForm1.SetShadowForm(Me)

        checkOpen()
        ds = New DataSet

        sql = "SELECT guestID as ID, guestName as Name, guestAddress as Address, guestAge as Age, guestPhone as Phone,
              guestEmail as Email, Remarks as Status FROM Guest"

        da = New OleDbDataAdapter(sql, con)

        da.Fill(ds, "AllGuest")

        dgGuests.DataSource = ds.Tables("AllGuest")
        da.Dispose()
        con.Close()

        cmdUpdate.Enabled = False
        cmdDelete.Enabled = False
        dgGuests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
        Call Guests_Load(sender, e)
    End Sub

    Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click
        Call Guests_Load(sender, e)
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click

        Call Guests_Load(sender, e)
    End Sub

    Private Sub dgGuests_DoubleClick(sender As Object, e As EventArgs) Handles dgGuests.DoubleClick
        txtGuest.Text = Me.dgGuests.CurrentRow.Cells("Name").Value
        txtAddress.Text = Me.dgGuests.CurrentRow.Cells("Address").Value
        txtAge.Text = Me.dgGuests.CurrentRow.Cells("Age").Value
        txtPhone.Text = Me.dgGuests.CurrentRow.Cells("Phone").Value
        lblCusID.Text = Me.dgGuests.CurrentRow.Cells("ID").Value

        cmdUpdate.Enabled = True
        cmdDelete.Enabled = True
    End Sub
End Class