Imports System.Data.OleDb
Public Class CustomerFeedback
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
            MsgBox("Thank you for your feedback! Hope you enjoyed your stay.")
        Else
            MsgBox("Feedback saving failed")
        End If
        con.Close()
    End Sub
End Class