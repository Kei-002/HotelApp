Imports System.Data.OleDb
Public Class Feedback
    Private Sub Feedback_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkOpen()

        dt = New DataTable("Feedbackz")

        'Di makuha description, reserved word daw eme
        sql = "SELECT feedbackID as FeedbackID, guestName as Guest, feedbackRating as Rating FROM Guest
              INNER JOIN Feedback ON Guest.guestID = Feedback.guestID"

        cmd = New OleDbCommand(sql, con)
        dr = cmd.ExecuteReader

        dt.Load(dr)
        dgList.DataSource = dt
        dr.Dispose()

        dgList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        con.Close()


    End Sub
End Class