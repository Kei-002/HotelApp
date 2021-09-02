Imports System.Data.OleDb
Public Class GuestInfoForm
    Private Sub GuestInfoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkOpen()
        Dim dt As New DataTable

        Dim guestz As New GuestInfoCrystal

        sql = "SELECT guestName as GuestName, guestAddress as Address, guestAge as Age, guestPhone as Phone, guestEmail as Email
               FROM Guest"

        cmd = New OleDbCommand(sql, con)
        dr = cmd.ExecuteReader

        dt.Load(dr)

        guestz.SetDataSource(dt)

        CrystalReportViewer1.ReportSource = guestz

        CrystalReportViewer1.Refresh()

        con.Close()
    End Sub
End Class