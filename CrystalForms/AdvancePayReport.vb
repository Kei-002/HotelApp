﻿Imports System.Data.OleDb
Public Class AdvancePayReport
    Private Sub AdvancePayReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkOpen()
        Dim dt As New CheckOutData

        Dim cOUTRep As New AdvancePaymentCrystal

        sql = "SELECT guestName as GuestName, paymentDesc, paymentDate, paymentAmount FROM (Payment INNER JOIN Guest
                ON Guest.guestID = Payment.guestID) WHERE paymentDesc = 'Advance payment'"

        da = New OleDbDataAdapter(sql, con)

        da.Fill(dt.Tables("cout"))


        cOUTRep.SetDataSource(dt)

        CrystalReportViewer1.ReportSource = cOUTRep
        CrystalReportViewer1.Refresh()
        con.Close()
    End Sub
End Class