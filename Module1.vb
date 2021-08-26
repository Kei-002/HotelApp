Imports System.Data.OleDb

Module Module1
    Public da As OleDbDataAdapter
    Public ds As New DataSet 'Temporarily Stores Data'

    Public sql, sql1, sql2 As String
    Public cmd, cmd1 As OleDbCommand
    Public dt As New DataTable

    Public dr As OleDbDataReader
    Public dbread As OleDbDataReader

    Public dbcon As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|/HotelTest.accdb"
    Public con As New OleDbConnection



    'Forms
    Public totalOccupants As Integer
    Public maxOccupants As Integer



    Public Sub checkOpen()

        If con.State = ConnectionState.Closed Then
            con.ConnectionString = dbcon
            con.Open()

        End If
    End Sub

#Region "Update Functions"

    ''' <summary>
    ''' Updates the Reservation Info based on the reservationID
    ''' </summary>
    Public Function UpdateGuestReservation(ByVal reserveID As Integer, ByVal rDesc As String, ByVal rStat As String)

        sql = "UPDATE Reservation SET reservationDesc = @rDesc, reserveStatus = @rStat WHERE reservationID = @reID"
        cmd = New OleDbCommand(sql, con)

        With cmd
            .Parameters.AddWithValue("@rDesc", rDesc)
            .Parameters.AddWithValue("@rStat", rStat)
            .Parameters.AddWithValue("@reID", reserveID)
        End With
        Dim i As Integer = cmd.ExecuteNonQuery

        cmd.Dispose()

        Return i

    End Function
    'Sets the room status based on the pased string
    Public Function SetRoomStatus(ByVal roomNum As Integer, ByVal numGuest As Integer, ByVal status As String)
        If status = "Checkin" Then
            status = "Occupied"
        End If

        sql = "UPDATE Rooms SET Status = @stat, NumOfOccupants = @numG WHERE roomNum = @rNum"

        cmd = New OleDbCommand(sql, con)

        With cmd
            .Parameters.AddWithValue("@stat", status)
            .Parameters.AddWithValue("@numG", numGuest)
            .Parameters.AddWithValue("@rNum", roomNum)
        End With

        Dim i As Integer = cmd.ExecuteNonQuery

        cmd.Dispose()

        Return i
    End Function

    ''' <summary>
    ''' Sets the remarks of the guest based on the given string
    ''' </summary>
    Public Function SetGuestRemarks(ByVal guestID As Integer, ByVal remark As String)

        sql = "UPDATE Guest SET Remarks = @rem WHERE guestID = @gID"

        cmd = New OleDbCommand(sql, con)

        With cmd
            .Parameters.AddWithValue("@rem", remark)
            .Parameters.AddWithValue("@gID", guestID)
        End With

        Dim i As Integer = cmd.ExecuteNonQuery


        cmd.Dispose()

        Return i

    End Function


    Public Function SetReservationStatus(ByVal reID As Integer, ByVal reStatus As String)

        sql = "UPDATE Reservation SET reserveStatus = @reStat WHERE reservationID = @rID"

        cmd = New OleDbCommand(sql, con)

        With cmd
            .Parameters.AddWithValue("@reStat", reStatus)
            .Parameters.AddWithValue("@rID", reID)
        End With

        Dim i As Integer = cmd.ExecuteNonQuery


        cmd.Dispose()

        Return i

    End Function


    Public Function SetServiceStatus(ByVal gID As Integer, ByVal stat As String)

        sql = "UPDATE Services SET Status = @stat WHERE guestID = @gID AND Status = 'Active'"

        cmd = New OleDbCommand(sql, con)

        With cmd
            .Parameters.AddWithValue("@stat", stat)
            .Parameters.AddWithValue("@gID", gID)
        End With

        Dim i As Integer = cmd.ExecuteNonQuery


        cmd.Dispose()

        Return i



    End Function

#End Region


#Region "Insert Functions"
    ''' <summary>
    ''' Inserts the info to Reservation Table
    ''' </summary>
    Public Function InsertGuestReservation(ByVal gID As Integer, ByVal rNum As Integer, ByVal rDesc As String, ByVal rDate As Date,
                                           ByVal cIN As Date, ByVal cOUT As Date, ByVal advPay As Decimal, ByVal reStatus As String)

        sql = "INSERT INTO Reservation(guestID, roomNum, reservationDesc,reservationDate, checkIN, checkOUT, advancePayment, reserveStatus)
               VALUES  (@gID, @rNum,@rDesc , @rDate, @cIN, @cOUT, @advPay, @rStatus)"

        cmd = New OleDbCommand(sql, con)

        With cmd
            .Parameters.AddWithValue("@gID", gID)
            .Parameters.AddWithValue("@rNum", rNum)
            .Parameters.AddWithValue("@rDesc", rDesc)
            .Parameters.AddWithValue("@rDate", rDate)
            .Parameters.AddWithValue("@cIN", cIN)
            .Parameters.AddWithValue("@cOUT", cOUT)
            .Parameters.AddWithValue("@advPay", advPay)
            .Parameters.AddWithValue("rStatus", reStatus)
        End With

        Dim i As Integer = cmd.ExecuteNonQuery

        cmd.Dispose()

        Return i
    End Function


    ''' <summary>
    ''' Inserts payment with guestID and the paymentDescription
    ''' </summary>
    Public Function InsertIntoPayment(ByVal gID As Integer, payDesc As String, payTypeID As Integer, payDate As Date, payAmount As Decimal)


        sql = "INSERT INTO Payment(guestID, paymentDesc, paymentTypeID, paymentDate, paymentAmount)
               VALUES  (@gID, @payDesc, @pID, @pDate, @pAmount)"

        cmd = New OleDbCommand(sql, con)

        With cmd
            .Parameters.AddWithValue("@gID", gID)
            .Parameters.AddWithValue("@payDesc", payDesc)
            .Parameters.AddWithValue("@pID", payTypeID)
            .Parameters.AddWithValue("@pDate", payDate)
            .Parameters.AddWithValue("@pAmount", payAmount)
        End With

        Dim i As Integer = cmd.ExecuteNonQuery

        cmd.Dispose()

        Return i


    End Function




    Public Function InsertIntoServices(ByVal serviceDesc As String, ByVal guestID As Integer, ByVal serviceFee As Decimal, ByVal empID As Integer, ByVal stat As String)
        sql = "INSERT INTO Services(serviceDesc, guestID, serviceFee, employeeID, Status)
               VALUES  (@serDesc, @gID, @serFee, @empID, @stat)"

        cmd = New OleDbCommand(sql, con)

        With cmd
            .Parameters.AddWithValue("@serDesc", serviceDesc)
            .Parameters.AddWithValue("@gID", guestID)
            .Parameters.AddWithValue("@serFee", serviceFee)
            .Parameters.AddWithValue("@empID", empID)
            .Parameters.AddWithValue("@stat", stat)
        End With

        Dim i As Integer = cmd.ExecuteNonQuery

        cmd.Dispose()

        Return i

    End Function
#End Region

End Module

