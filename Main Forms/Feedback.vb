Imports System.Data.OleDb
Public Class Feedback
#Region " Move Form "

    ' [ Move Form ]
    '
    ' // By Elektro 

    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point

    Public Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseDown ' Add more handles here (Example: PictureBox1.MouseDown)

        If e.Button = MouseButtons.Left Then
            MoveForm = True
            Me.Cursor = Cursors.NoMove2D
            MoveForm_MousePosition = e.Location
        End If

    End Sub

    Public Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseMove ' Add more handles here (Example: PictureBox1.MouseMove)

        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If

    End Sub

    Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseUp ' Add more handles here (Example: PictureBox1.MouseUp)

        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Me.Cursor = Cursors.Default
        End If

    End Sub




#End Region
    Private Sub Feedback_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2ShadowForm1.SetShadowForm(Me)
        checkOpen()

        dt = New DataTable("Feedbackz")

        'Di makuha description, reserved word daw eme
        sql = "SELECT feedbackID as ID, guestName as Guest, feedbackDesc as Comments,feedbackRating as Rating FROM Guest
              INNER JOIN Feedback ON Guest.guestID = Feedback.guestID"

        cmd = New OleDbCommand(sql, con)
        dr = cmd.ExecuteReader

        dt.Load(dr)
        dgList.DataSource = dt
        dr.Dispose()




        'dgList.Columns(0).Width = 180
        dgList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgList.Columns(0).FillWeight = 10
        dgList.Columns(1).FillWeight = 30
        dgList.Columns(2).FillWeight = 50
        dgList.Columns(3).FillWeight = 10


        con.Close()


    End Sub

    Private Sub cmdCLose_Click(sender As Object, e As EventArgs) Handles cmdCLose.Click
        Me.Close()
    End Sub

    Private Sub cmdFeedbackRep_Click(sender As Object, e As EventArgs) Handles cmdFeedbackRep.Click
        FeedReportForm.Show()
    End Sub
End Class