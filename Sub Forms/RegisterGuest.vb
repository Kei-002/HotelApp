Imports System.Data.OleDb
Public Class RegisterGuest
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

    Private Sub RegisterGuest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2ShadowForm1.SetShadowForm(Me)
        clear_text()
    End Sub

    Private Sub cmdRegister_Click(sender As Object, e As EventArgs) Handles cmdRegister.Click
        checkOpen()


        sql = "INSERT INTO Guest (guestName, guestAddress, guestAge, guestPhone, guestEmail, Remarks) 
        VALUES ('" & txtGuest.Text & "','" & txtAddress.Text & "','" & txtAge.Text & "','" & txtPhone.Text & "','" & txtEmail.Text & "', 'Available')"
        cmd = New OleDbCommand(sql, con)
        Dim i As Integer = cmd.ExecuteNonQuery

        If i > 0 Then
            MsgBox("User successfully registered! registration form will now close", Title:="Registration Success")
        Else
            MsgBox("User registration failed. registration form will now close", "Registration failed")
        End If

        con.Close()

        Dim ans As String = MsgBox("Register another user?", vbQuestion + vbYesNo, "User registration")
        If ans = vbNo Then
            Me.Close()
        Else
            clear_text()
        End If

    End Sub


    Private Sub clear_text()
        txtAddress.Clear()
        txtGuest.Clear()
        txtAge.Clear()
        txtEmail.Clear()
        txtPhone.Clear()
    End Sub

    Private Sub cmdCLose_Click(sender As Object, e As EventArgs) Handles cmdCLose.Click
        Me.Close()
    End Sub
End Class