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

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        checkOpen()
        Dim dt As New DataTable

        Dim paymentWeek As New DailyPaymentReport

        sql = "Select paymentID, guestName, paymentDesc, paymentName, paymentDate, paymentAmount FROM Payment, Guest, PaymentType
               WHERE Payment.guestID = Guest.guestID AND PaymentType.PaymentTypeID = Payment.PaymentTypeID
               ORDER BY paymentID"

        cmd = New OleDbCommand(sql, con)
        dr = cmd.ExecuteReader

        dt.Load(dr)

        paymentWeek.SetDataSource(dt)

        CrystalReportViewer1.ReportSource = paymentWeek

        CrystalReportViewer1.Refresh()

        con.Close()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        checkOpen()
        Dim dt As New DataTable

        Dim paymentMonth As New MonthlyPaymentReport

        sql = "Select paymentID, guestName, paymentDesc, paymentName, paymentDate, paymentAmount FROM Payment, Guest, PaymentType
               WHERE Payment.guestID = Guest.guestID AND PaymentType.PaymentTypeID = Payment.PaymentTypeID
               ORDER BY paymentID"

        cmd = New OleDbCommand(sql, con)
        dr = cmd.ExecuteReader

        dt.Load(dr)

        paymentMonth.SetDataSource(dt)

        CrystalReportViewer1.ReportSource = paymentMonth

        CrystalReportViewer1.Refresh()

        con.Close()
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        checkOpen()
        Dim dt As New DataTable

        Dim paymentYear As New YearlyPaymentReport

        sql = "Select paymentID, guestName, paymentDesc, paymentName, paymentDate, paymentAmount FROM Payment, Guest, PaymentType
               WHERE Payment.guestID = Guest.guestID AND PaymentType.PaymentTypeID = Payment.PaymentTypeID
               ORDER BY paymentID"

        cmd = New OleDbCommand(sql, con)
        dr = cmd.ExecuteReader

        dt.Load(dr)

        paymentYear.SetDataSource(dt)

        CrystalReportViewer1.ReportSource = paymentYear

        CrystalReportViewer1.Refresh()

        con.Close()
    End Sub
End Class