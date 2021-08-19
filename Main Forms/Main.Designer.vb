<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.cmdMinimize = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.cmdCLose = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.cmdFeedback = New Guna.UI2.WinForms.Guna2Button()
        Me.cmdServices = New Guna.UI2.WinForms.Guna2Button()
        Me.cmdRoom = New Guna.UI2.WinForms.Guna2Button()
        Me.cmdGuest = New Guna.UI2.WinForms.Guna2Button()
        Me.cmdReservation = New Guna.UI2.WinForms.Guna2Button()
        Me.cmdCheckOut = New Guna.UI2.WinForms.Guna2Button()
        Me.cmdCheckIn = New Guna.UI2.WinForms.Guna2Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.White
        Me.Guna2Panel1.Controls.Add(Me.cmdFeedback)
        Me.Guna2Panel1.Controls.Add(Me.cmdServices)
        Me.Guna2Panel1.Controls.Add(Me.cmdRoom)
        Me.Guna2Panel1.Controls.Add(Me.cmdGuest)
        Me.Guna2Panel1.Controls.Add(Me.cmdReservation)
        Me.Guna2Panel1.Controls.Add(Me.cmdCheckOut)
        Me.Guna2Panel1.Controls.Add(Me.cmdCheckIn)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel2)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Depth = 10
        Me.Guna2Panel1.ShadowDecoration.Enabled = True
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.Guna2Panel1.Size = New System.Drawing.Size(196, 670)
        Me.Guna2Panel1.TabIndex = 0
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Controls.Add(Me.PictureBox1)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(196, 153)
        Me.Guna2Panel2.TabIndex = 1
        '
        'cmdMinimize
        '
        Me.cmdMinimize.CheckedState.Parent = Me.cmdMinimize
        Me.cmdMinimize.CustomImages.Parent = Me.cmdMinimize
        Me.cmdMinimize.FillColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.cmdMinimize.Font = New System.Drawing.Font("Montserrat", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMinimize.ForeColor = System.Drawing.Color.White
        Me.cmdMinimize.HoverState.Parent = Me.cmdMinimize
        Me.cmdMinimize.Location = New System.Drawing.Point(963, 12)
        Me.cmdMinimize.Name = "cmdMinimize"
        Me.cmdMinimize.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.cmdMinimize.ShadowDecoration.Parent = Me.cmdMinimize
        Me.cmdMinimize.Size = New System.Drawing.Size(20, 20)
        Me.cmdMinimize.TabIndex = 2
        Me.cmdMinimize.Text = "-"
        '
        'cmdCLose
        '
        Me.cmdCLose.CheckedState.Parent = Me.cmdCLose
        Me.cmdCLose.CustomImages.Parent = Me.cmdCLose
        Me.cmdCLose.FillColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.cmdCLose.Font = New System.Drawing.Font("Montserrat", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCLose.ForeColor = System.Drawing.Color.White
        Me.cmdCLose.HoverState.Parent = Me.cmdCLose
        Me.cmdCLose.Location = New System.Drawing.Point(989, 12)
        Me.cmdCLose.Name = "cmdCLose"
        Me.cmdCLose.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.cmdCLose.ShadowDecoration.Parent = Me.cmdCLose
        Me.cmdCLose.Size = New System.Drawing.Size(20, 20)
        Me.cmdCLose.TabIndex = 3
        Me.cmdCLose.Text = "X"
        '
        'cmdFeedback
        '
        Me.cmdFeedback.CheckedState.ForeColor = System.Drawing.Color.Black
        Me.cmdFeedback.CheckedState.Image = CType(resources.GetObject("cmdFeedback.CheckedState.Image"), System.Drawing.Image)
        Me.cmdFeedback.CheckedState.Parent = Me.cmdFeedback
        Me.cmdFeedback.CustomImages.Parent = Me.cmdFeedback
        Me.cmdFeedback.Dock = System.Windows.Forms.DockStyle.Top
        Me.cmdFeedback.FillColor = System.Drawing.Color.Transparent
        Me.cmdFeedback.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFeedback.ForeColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.cmdFeedback.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.cmdFeedback.HoverState.ForeColor = System.Drawing.Color.Black
        Me.cmdFeedback.HoverState.Image = CType(resources.GetObject("cmdFeedback.HoverState.Image"), System.Drawing.Image)
        Me.cmdFeedback.HoverState.Parent = Me.cmdFeedback
        Me.cmdFeedback.Image = CType(resources.GetObject("cmdFeedback.Image"), System.Drawing.Image)
        Me.cmdFeedback.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.cmdFeedback.ImageOffset = New System.Drawing.Point(0, -3)
        Me.cmdFeedback.ImageSize = New System.Drawing.Size(30, 30)
        Me.cmdFeedback.Location = New System.Drawing.Point(0, 507)
        Me.cmdFeedback.Name = "cmdFeedback"
        Me.cmdFeedback.ShadowDecoration.Parent = Me.cmdFeedback
        Me.cmdFeedback.Size = New System.Drawing.Size(196, 59)
        Me.cmdFeedback.TabIndex = 7
        Me.cmdFeedback.Text = "Feedback"
        '
        'cmdServices
        '
        Me.cmdServices.CheckedState.ForeColor = System.Drawing.Color.Black
        Me.cmdServices.CheckedState.Image = CType(resources.GetObject("cmdServices.CheckedState.Image"), System.Drawing.Image)
        Me.cmdServices.CheckedState.Parent = Me.cmdServices
        Me.cmdServices.CustomImages.Parent = Me.cmdServices
        Me.cmdServices.Dock = System.Windows.Forms.DockStyle.Top
        Me.cmdServices.FillColor = System.Drawing.Color.Transparent
        Me.cmdServices.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdServices.ForeColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.cmdServices.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.cmdServices.HoverState.ForeColor = System.Drawing.Color.Black
        Me.cmdServices.HoverState.Image = CType(resources.GetObject("cmdServices.HoverState.Image"), System.Drawing.Image)
        Me.cmdServices.HoverState.Parent = Me.cmdServices
        Me.cmdServices.Image = CType(resources.GetObject("cmdServices.Image"), System.Drawing.Image)
        Me.cmdServices.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.cmdServices.ImageOffset = New System.Drawing.Point(0, -3)
        Me.cmdServices.ImageSize = New System.Drawing.Size(28, 28)
        Me.cmdServices.Location = New System.Drawing.Point(0, 448)
        Me.cmdServices.Name = "cmdServices"
        Me.cmdServices.ShadowDecoration.Parent = Me.cmdServices
        Me.cmdServices.Size = New System.Drawing.Size(196, 59)
        Me.cmdServices.TabIndex = 6
        Me.cmdServices.Text = "Services"
        '
        'cmdRoom
        '
        Me.cmdRoom.CheckedState.ForeColor = System.Drawing.Color.Black
        Me.cmdRoom.CheckedState.Image = CType(resources.GetObject("cmdRoom.CheckedState.Image"), System.Drawing.Image)
        Me.cmdRoom.CheckedState.Parent = Me.cmdRoom
        Me.cmdRoom.CustomImages.Parent = Me.cmdRoom
        Me.cmdRoom.Dock = System.Windows.Forms.DockStyle.Top
        Me.cmdRoom.FillColor = System.Drawing.Color.Transparent
        Me.cmdRoom.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRoom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.cmdRoom.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.cmdRoom.HoverState.ForeColor = System.Drawing.Color.Black
        Me.cmdRoom.HoverState.Image = CType(resources.GetObject("cmdRoom.HoverState.Image"), System.Drawing.Image)
        Me.cmdRoom.HoverState.Parent = Me.cmdRoom
        Me.cmdRoom.Image = CType(resources.GetObject("cmdRoom.Image"), System.Drawing.Image)
        Me.cmdRoom.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.cmdRoom.ImageOffset = New System.Drawing.Point(0, -3)
        Me.cmdRoom.ImageSize = New System.Drawing.Size(30, 30)
        Me.cmdRoom.Location = New System.Drawing.Point(0, 389)
        Me.cmdRoom.Name = "cmdRoom"
        Me.cmdRoom.ShadowDecoration.Parent = Me.cmdRoom
        Me.cmdRoom.Size = New System.Drawing.Size(196, 59)
        Me.cmdRoom.TabIndex = 3
        Me.cmdRoom.Text = "Rooms"
        '
        'cmdGuest
        '
        Me.cmdGuest.CheckedState.ForeColor = System.Drawing.Color.Black
        Me.cmdGuest.CheckedState.Image = Global.zzzz.My.Resources.Resources.traveler
        Me.cmdGuest.CheckedState.Parent = Me.cmdGuest
        Me.cmdGuest.CustomImages.Parent = Me.cmdGuest
        Me.cmdGuest.Dock = System.Windows.Forms.DockStyle.Top
        Me.cmdGuest.FillColor = System.Drawing.Color.Transparent
        Me.cmdGuest.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGuest.ForeColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.cmdGuest.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.cmdGuest.HoverState.ForeColor = System.Drawing.Color.Black
        Me.cmdGuest.HoverState.Image = CType(resources.GetObject("cmdGuest.HoverState.Image"), System.Drawing.Image)
        Me.cmdGuest.HoverState.Parent = Me.cmdGuest
        Me.cmdGuest.Image = CType(resources.GetObject("cmdGuest.Image"), System.Drawing.Image)
        Me.cmdGuest.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.cmdGuest.ImageOffset = New System.Drawing.Point(0, -3)
        Me.cmdGuest.ImageSize = New System.Drawing.Size(30, 30)
        Me.cmdGuest.Location = New System.Drawing.Point(0, 330)
        Me.cmdGuest.Name = "cmdGuest"
        Me.cmdGuest.ShadowDecoration.Parent = Me.cmdGuest
        Me.cmdGuest.Size = New System.Drawing.Size(196, 59)
        Me.cmdGuest.TabIndex = 4
        Me.cmdGuest.Text = "Guest"
        '
        'cmdReservation
        '
        Me.cmdReservation.CheckedState.ForeColor = System.Drawing.Color.Black
        Me.cmdReservation.CheckedState.Image = CType(resources.GetObject("cmdReservation.CheckedState.Image"), System.Drawing.Image)
        Me.cmdReservation.CheckedState.Parent = Me.cmdReservation
        Me.cmdReservation.CustomImages.Parent = Me.cmdReservation
        Me.cmdReservation.Dock = System.Windows.Forms.DockStyle.Top
        Me.cmdReservation.FillColor = System.Drawing.Color.Transparent
        Me.cmdReservation.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReservation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.cmdReservation.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.cmdReservation.HoverState.ForeColor = System.Drawing.Color.Black
        Me.cmdReservation.HoverState.Image = CType(resources.GetObject("cmdReservation.HoverState.Image"), System.Drawing.Image)
        Me.cmdReservation.HoverState.Parent = Me.cmdReservation
        Me.cmdReservation.Image = CType(resources.GetObject("cmdReservation.Image"), System.Drawing.Image)
        Me.cmdReservation.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.cmdReservation.ImageSize = New System.Drawing.Size(30, 30)
        Me.cmdReservation.Location = New System.Drawing.Point(0, 271)
        Me.cmdReservation.Name = "cmdReservation"
        Me.cmdReservation.ShadowDecoration.Parent = Me.cmdReservation
        Me.cmdReservation.Size = New System.Drawing.Size(196, 59)
        Me.cmdReservation.TabIndex = 5
        Me.cmdReservation.Text = "Reservation"
        Me.cmdReservation.TextOffset = New System.Drawing.Point(10, 0)
        '
        'cmdCheckOut
        '
        Me.cmdCheckOut.CheckedState.ForeColor = System.Drawing.Color.Black
        Me.cmdCheckOut.CheckedState.Image = CType(resources.GetObject("cmdCheckOut.CheckedState.Image"), System.Drawing.Image)
        Me.cmdCheckOut.CheckedState.Parent = Me.cmdCheckOut
        Me.cmdCheckOut.CustomImages.Parent = Me.cmdCheckOut
        Me.cmdCheckOut.Dock = System.Windows.Forms.DockStyle.Top
        Me.cmdCheckOut.FillColor = System.Drawing.Color.Transparent
        Me.cmdCheckOut.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCheckOut.ForeColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.cmdCheckOut.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.cmdCheckOut.HoverState.ForeColor = System.Drawing.Color.Black
        Me.cmdCheckOut.HoverState.Image = CType(resources.GetObject("cmdCheckOut.HoverState.Image"), System.Drawing.Image)
        Me.cmdCheckOut.HoverState.Parent = Me.cmdCheckOut
        Me.cmdCheckOut.Image = CType(resources.GetObject("cmdCheckOut.Image"), System.Drawing.Image)
        Me.cmdCheckOut.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.cmdCheckOut.ImageOffset = New System.Drawing.Point(0, -3)
        Me.cmdCheckOut.ImageSize = New System.Drawing.Size(30, 30)
        Me.cmdCheckOut.Location = New System.Drawing.Point(0, 212)
        Me.cmdCheckOut.Name = "cmdCheckOut"
        Me.cmdCheckOut.ShadowDecoration.Parent = Me.cmdCheckOut
        Me.cmdCheckOut.Size = New System.Drawing.Size(196, 59)
        Me.cmdCheckOut.TabIndex = 2
        Me.cmdCheckOut.Text = "Check Out"
        '
        'cmdCheckIn
        '
        Me.cmdCheckIn.CheckedState.ForeColor = System.Drawing.Color.Black
        Me.cmdCheckIn.CheckedState.Image = CType(resources.GetObject("cmdCheckIn.CheckedState.Image"), System.Drawing.Image)
        Me.cmdCheckIn.CheckedState.Parent = Me.cmdCheckIn
        Me.cmdCheckIn.CustomImages.Parent = Me.cmdCheckIn
        Me.cmdCheckIn.Dock = System.Windows.Forms.DockStyle.Top
        Me.cmdCheckIn.FillColor = System.Drawing.Color.Transparent
        Me.cmdCheckIn.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCheckIn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.cmdCheckIn.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.cmdCheckIn.HoverState.ForeColor = System.Drawing.Color.Black
        Me.cmdCheckIn.HoverState.Image = CType(resources.GetObject("cmdCheckIn.HoverState.Image"), System.Drawing.Image)
        Me.cmdCheckIn.HoverState.Parent = Me.cmdCheckIn
        Me.cmdCheckIn.Image = CType(resources.GetObject("cmdCheckIn.Image"), System.Drawing.Image)
        Me.cmdCheckIn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.cmdCheckIn.ImageOffset = New System.Drawing.Point(0, -3)
        Me.cmdCheckIn.ImageSize = New System.Drawing.Size(30, 30)
        Me.cmdCheckIn.Location = New System.Drawing.Point(0, 153)
        Me.cmdCheckIn.Name = "cmdCheckIn"
        Me.cmdCheckIn.ShadowDecoration.Parent = Me.cmdCheckIn
        Me.cmdCheckIn.Size = New System.Drawing.Size(196, 59)
        Me.cmdCheckIn.TabIndex = 1
        Me.cmdCheckIn.Text = "Check In"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.zzzz.My.Resources.Resources.customehtd
        Me.PictureBox1.Location = New System.Drawing.Point(7, -20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(181, 169)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1021, 670)
        Me.Controls.Add(Me.cmdMinimize)
        Me.Controls.Add(Me.cmdCLose)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cmdMinimize As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents cmdCLose As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents cmdCheckIn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cmdRoom As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cmdCheckOut As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cmdGuest As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cmdReservation As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cmdFeedback As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cmdServices As Guna.UI2.WinForms.Guna2Button
End Class
