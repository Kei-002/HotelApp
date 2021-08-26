Imports System.Data.OleDb
Public Class RoomReportForm
    Private Sub RoomReportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkOpen()
        Dim dt As New DataTable

        Dim roomReport As New RoomReport

        sql = " SELECT reservationID, roomNum, guestName, reservationDesc, reservationDate, checkIN, checkOUT, advancePayment
                FROM Reservation RV, Guest G WHERE RV.guestID = G.guestID"

        cmd = New OleDbCommand(sql, con)
        dr = cmd.ExecuteReader

        dt.Load(dr)

        roomReport.SetDataSource(dt)

        CrystalReportViewer1.ReportSource = roomReport

        CrystalReportViewer1.Refresh()

        con.Close()
    End Sub
End Class