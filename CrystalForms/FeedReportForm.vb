Imports System.Data.OleDb
Public Class FeedReportForm
    Private Sub FeedReportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkOpen()
        Dim dt As New DataTable

        Dim feedbackX As New FeedbackReport

        sql = "SELECT feedbackID, guestName, feedbackDesc, feedbackRating FROM Feedback, Guest WHERE
               Feedback.guestID = Guest.guestID"

        cmd = New OleDbCommand(sql, con)
        dr = cmd.ExecuteReader

        dt.Load(dr)

        feedbackX.SetDataSource(dt)

        CrystalReportViewer1.ReportSource = feedbackX

        CrystalReportViewer1.Refresh()

        con.Close()


    End Sub
End Class