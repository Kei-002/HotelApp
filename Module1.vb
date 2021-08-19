Imports System.Data.OleDb

Module Module1
    Public da As OleDbDataAdapter
    Public ds As New DataSet 'Temporarily Stores Data'

    Public sql, sql1 As String
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

    ''' <summary>
    ''' Inserts the info to Reservation Table
    ''' </summary>
    Public Function InsertGuestReservation(ByVal gID As Integer, ByVal rNum As Integer, ByVal rDesc As String, ByVal rDate As Date,
                                           ByVal cIN As Date, ByVal cOUT As Date, ByVal advPay As Decimal)

        sql = "INSERT INTO Reservation(guestID, roomNum, reservationDesc,reservationDate, checkIN, checkOUT, advancePayment)
               VALUES  (@gID, @rNum,@rDesc , @rDate, @cIN, @cOUT, @advPay)"

        cmd = New OleDbCommand(sql, con)

        With cmd
            .Parameters.AddWithValue("@gID", gID)
            .Parameters.AddWithValue("@rNum", rNum)
            .Parameters.AddWithValue("@rDesc", rDesc)
            .Parameters.AddWithValue("@rDate", rDate)
            .Parameters.AddWithValue("@cIN", cIN)
            .Parameters.AddWithValue("@cOUT", cOUT)
            .Parameters.AddWithValue("@advPay", advPay)
        End With

        Dim i As Integer = cmd.ExecuteNonQuery

        cmd.Dispose()

        Return i
    End Function

    ''' <summary>
    ''' Updates the Reservation Info based on the reservationID
    ''' </summary>
    Public Function UpdateGuestReservation(ByVal reserveID As Integer, ByVal rDesc As String)

        sql = "UPDATE Reservation SET reservationDesc = @rDesc WHERE reservationID = @reID"
        cmd = New OleDbCommand(sql, con)

        With cmd
            .Parameters.AddWithValue("@rDesc", rDesc)
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


End Module

