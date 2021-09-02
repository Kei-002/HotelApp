Imports System.Data.OleDb
Public Class RecieptForm
    Private Sub RecieptForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim gID As Integer = CheckOut.lblGuestID.Text

        checkOpen()
        Dim dt As New DataTable

        Dim recieptC As New RecieptCrystal

        sql = "SELECT guestName as GuestName, roomNum as RoomNum, checkIN as CheckIn, checkOUT as CheckOut, advancePayment as RoomFee,
               serviceDesc as Service, serviceFee as ServiceFee FROM ((Reservation as R
               INNER JOIN Guest as G ON G.guestID = R.guestID)
               INNER JOIN Services as S ON S.guestID = R.guestID)
               WHERE R.guestID = " & gID & "
               AND S.Status = 'Active' AND R.reserveStatus = 'Active'"

        cmd = New OleDbCommand(sql, con)
        dr = cmd.ExecuteReader

        dt.Load(dr)

        recieptC.SetDataSource(dt)

        recieptC.SetParameterValue("paramRoomFee", CheckOut.lblBalance.Text)
        recieptC.SetParameterValue("paramTotal", CheckOut.txtTotal.Text)
        CrystalReportViewer1.ReportSource = recieptC

        CrystalReportViewer1.Refresh()

        con.Close()


    End Sub
End Class