Imports System.Data.OleDb
Public Class AvailService
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

    Private Sub AvailService_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkOpen()

        sql = "SELECT DISTINCT serviceDesc FROM Services"
        cmd = New OleDbCommand(sql, con)
        dr = cmd.ExecuteReader

        While dr.Read
            cmbServices.Items.Add(dr(0))
        End While
        dr.Dispose()

        sql1 = "SELECT employeeID, employeeName FROM Employee"
        cmd = New OleDbCommand(sql1, con)
        dr = cmd.ExecuteReader

        While dr.Read
            cmbEmployee.Items.Add(dr(0).ToString + " - " + dr(1).ToString)
        End While


        dr.Dispose()


        con.Close()
    End Sub




    Private Sub cmdAvail_Click(sender As Object, e As EventArgs) Handles cmdAvail.Click
        Dim guestID As Integer = txtGuestID.Text
        Dim serviceDesc As String = cmbServices.SelectedItem
        Dim serviceFee As Decimal = Val(txtFee.Text)
        Dim empFull() As String = (cmbEmployee.SelectedItem).ToString.Split(" ")
        Dim empID As Integer = CInt(empFull(0))



        checkOpen()

        Dim i As Integer = InsertIntoServices(serviceDesc, guestID, serviceFee, empID)
        If i > 0 Then
            MsgBox("Service Avail Successful")
        Else
            MsgBox("Service Avail Failed")
        End If

        con.Close()


    End Sub

    Private Sub cmbServices_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbServices.SelectedIndexChanged
        checkOpen()

        txtFee.Text = getFee(cmbServices.SelectedItem)

        con.Close()
    End Sub

    Private Function getFee(ByVal serveDesc As String)
        Dim fee As Decimal

        sql = "Select DISTINCT serviceFee FROM Services WHERE serviceDesc = @serDesc"
        cmd = New OleDbCommand(sql, con)
        cmd.Parameters.AddWithValue("@servDesc", serveDesc)
        dr = cmd.ExecuteReader

        While dr.Read()

            fee = dr(0)
        End While
        dr.Dispose()
        Return fee
    End Function
End Class