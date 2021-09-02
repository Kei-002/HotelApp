Imports System.Data.OleDb
Public Class GuestForm
    Private Sub GuestForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkOpen()
        Dim dt As New DataTable

        Dim guestRe As New GuestCrystal

        sql = "SELECT  G.guestName, Count(R.reservationID) AS Reservations, reservationDate
                FROM Guest AS G INNER JOIN Reservation AS R ON G.guestID = R.guestID
                GROUP BY G.guestName, reservationDate 
                "

        cmd = New OleDbCommand(sql, con)
        dr = cmd.ExecuteReader

        dt.Load(dr)

        guestRe.SetDataSource(dt)

        CrystalReportViewer1.ReportSource = guestRe

        CrystalReportViewer1.Refresh()

        con.Close()
    End Sub
End Class