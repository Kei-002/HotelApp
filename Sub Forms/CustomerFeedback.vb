Imports System.Data.OleDb
Public Class CustomerFeedback
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

    Private Sub cmdSubmit_Click(sender As Object, e As EventArgs) Handles cmdSubmit.Click

        checkOpen()

        Dim guestID As Integer = lblGuestID.Text
        Dim rate As Integer = ctRating.Value
        Dim feedback As String = txtFeedback.Text

        sql = "INSERT INTO Feedback(guestID, feedbackDesc, feedbackRating) VALUES (@guestID, [@feedDesc], @feedRating)"
        cmd = New OleDbCommand(sql, con)

        With cmd
            .Parameters.AddWithValue("@guestID", guestID)
            .Parameters.AddWithValue("@feedDesc", feedback)
            .Parameters.AddWithValue("@feedRating", rate)
        End With

        Dim i As Integer = cmd.ExecuteNonQuery
        If i > 0 Then
            MsgBox("Thank you for your feedback! Hope you enjoyed your stay. This form will now close", Title:="Feedback Submitted")
            Me.Close()
        Else
            MsgBox("Feedback saving failed")
        End If
        con.Close()
    End Sub

    Private Sub CustomerFeedback_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2ShadowForm1.SetShadowForm(Me)
        txtFeedback.Clear()
        ctRating.Value = 0
    End Sub
End Class