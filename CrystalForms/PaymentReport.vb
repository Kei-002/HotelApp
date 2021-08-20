Imports System.Data.OleDb
Public Class PaymentReport
    Private Sub PaymentReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkOpen()
        Dim dt As New DataTable

        Dim paymentX As New PaymentReportX

        sql = "Select paymentID, guestName, paymentDesc, paymentName, paymentDate, paymentAmount FROM Payment, Guest, PaymentType
               WHERE Payment.guestID = Guest.guestID AND PaymentType.PaymentTypeID = Payment.PaymentTypeID
               ORDER BY paymentID"

        cmd = New OleDbCommand(sql, con)
        dr = cmd.ExecuteReader

        dt.Load(dr)

        paymentX.SetDataSource(dt)

        CrystalReportViewer1.ReportSource = paymentX

        CrystalReportViewer1.Refresh()

        con.Close()
    End Sub
End Class