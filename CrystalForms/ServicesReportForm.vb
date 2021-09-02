Imports System.Data.OleDb

Public Class ServicesReportForm
    Private Sub ServicesReportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkOpen()
        Dim dt As New DataTable


        Dim serviceRep As New ServiceReport

        sql = "  SELECT serviceID, serviceDesc, guestName, employeeName, serviceFee FROM Services,Guest, Employee
                WHERE Employee.employeeID = Services.employeeID AND Guest.guestID = Services.guestID"

        cmd = New OleDbCommand(sql, con)
        dr = cmd.ExecuteReader

        dt.Load(dr)

        serviceRep.SetDataSource(dt)

        CrystalReportViewer1.ReportSource = serviceRep

        CrystalReportViewer1.Refresh()

        con.Close()
    End Sub
End Class