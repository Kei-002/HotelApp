<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reservation
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reservation))
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.cmdMinimize = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.cmdCLose = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.cmdReserve = New Guna.UI2.WinForms.Guna2Button()
        Me.cmdReserveList = New Guna.UI2.WinForms.Guna2Button()
        Me.dtpCheckOut = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.dtpCheckIn = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.cmdAddCount = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.cmdMinusCount = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.cmdSelectRoom = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.cmdSelectGuest = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.txtNumDays = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtTotal = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtRate = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtSubtotal = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtRoomType = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtRoomNum = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtNumGuest = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtGuest = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtAdvPay = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmbTypes = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lblMinPay = New System.Windows.Forms.Label()
        Me.lblMaxOccu = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblGuestID = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdMinimize
        '
        Me.cmdMinimize.CheckedState.Parent = Me.cmdMinimize
        Me.cmdMinimize.CustomImages.Parent = Me.cmdMinimize
        Me.cmdMinimize.FillColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.cmdMinimize.Font = New System.Drawing.Font("Montserrat", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMinimize.ForeColor = System.Drawing.Color.White
        Me.cmdMinimize.HoverState.Parent = Me.cmdMinimize
        Me.cmdMinimize.Location = New System.Drawing.Point(752, 12)
        Me.cmdMinimize.Name = "cmdMinimize"
        Me.cmdMinimize.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.cmdMinimize.ShadowDecoration.Parent = Me.cmdMinimize
        Me.cmdMinimize.Size = New System.Drawing.Size(20, 20)
        Me.cmdMinimize.TabIndex = 65
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
        Me.cmdCLose.Location = New System.Drawing.Point(778, 12)
        Me.cmdCLose.Name = "cmdCLose"
        Me.cmdCLose.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.cmdCLose.ShadowDecoration.Parent = Me.cmdCLose
        Me.cmdCLose.Size = New System.Drawing.Size(20, 20)
        Me.cmdCLose.TabIndex = 66
        Me.cmdCLose.Text = "X"
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 10
        '
        'cmdReserve
        '
        Me.cmdReserve.AutoRoundedCorners = True
        Me.cmdReserve.BorderRadius = 17
        Me.cmdReserve.BorderThickness = 1
        Me.cmdReserve.CheckedState.Parent = Me.cmdReserve
        Me.cmdReserve.CustomImages.Parent = Me.cmdReserve
        Me.cmdReserve.FillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.cmdReserve.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReserve.ForeColor = System.Drawing.Color.White
        Me.cmdReserve.HoverState.Parent = Me.cmdReserve
        Me.cmdReserve.Location = New System.Drawing.Point(640, 360)
        Me.cmdReserve.Name = "cmdReserve"
        Me.cmdReserve.ShadowDecoration.Parent = Me.cmdReserve
        Me.cmdReserve.Size = New System.Drawing.Size(128, 36)
        Me.cmdReserve.TabIndex = 64
        Me.cmdReserve.Text = "Reserve"
        '
        'cmdReserveList
        '
        Me.cmdReserveList.AutoRoundedCorners = True
        Me.cmdReserveList.BorderRadius = 17
        Me.cmdReserveList.BorderThickness = 1
        Me.cmdReserveList.CheckedState.Parent = Me.cmdReserveList
        Me.cmdReserveList.CustomImages.Parent = Me.cmdReserveList
        Me.cmdReserveList.FillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.cmdReserveList.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReserveList.ForeColor = System.Drawing.Color.White
        Me.cmdReserveList.HoverState.Parent = Me.cmdReserveList
        Me.cmdReserveList.Location = New System.Drawing.Point(455, 360)
        Me.cmdReserveList.Name = "cmdReserveList"
        Me.cmdReserveList.ShadowDecoration.Parent = Me.cmdReserveList
        Me.cmdReserveList.Size = New System.Drawing.Size(179, 36)
        Me.cmdReserveList.TabIndex = 63
        Me.cmdReserveList.Text = "View Reservations"
        '
        'dtpCheckOut
        '
        Me.dtpCheckOut.CheckedState.Parent = Me.dtpCheckOut
        Me.dtpCheckOut.FillColor = System.Drawing.Color.Transparent
        Me.dtpCheckOut.Font = New System.Drawing.Font("Source Sans Pro", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpCheckOut.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.dtpCheckOut.HoverState.Parent = Me.dtpCheckOut
        Me.dtpCheckOut.Location = New System.Drawing.Point(148, 290)
        Me.dtpCheckOut.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpCheckOut.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpCheckOut.Name = "dtpCheckOut"
        Me.dtpCheckOut.ShadowDecoration.Parent = Me.dtpCheckOut
        Me.dtpCheckOut.Size = New System.Drawing.Size(200, 36)
        Me.dtpCheckOut.TabIndex = 62
        Me.dtpCheckOut.Value = New Date(2021, 8, 17, 14, 56, 1, 829)
        '
        'dtpCheckIn
        '
        Me.dtpCheckIn.CheckedState.Parent = Me.dtpCheckIn
        Me.dtpCheckIn.FillColor = System.Drawing.Color.Transparent
        Me.dtpCheckIn.Font = New System.Drawing.Font("Source Sans Pro", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpCheckIn.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.dtpCheckIn.HoverState.Parent = Me.dtpCheckIn
        Me.dtpCheckIn.Location = New System.Drawing.Point(148, 248)
        Me.dtpCheckIn.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpCheckIn.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpCheckIn.Name = "dtpCheckIn"
        Me.dtpCheckIn.ShadowDecoration.Parent = Me.dtpCheckIn
        Me.dtpCheckIn.Size = New System.Drawing.Size(200, 36)
        Me.dtpCheckIn.TabIndex = 61
        Me.dtpCheckIn.Value = New Date(2021, 8, 17, 14, 56, 1, 829)
        '
        'cmdAddCount
        '
        Me.cmdAddCount.CheckedState.Parent = Me.cmdAddCount
        Me.cmdAddCount.CustomImages.Parent = Me.cmdAddCount
        Me.cmdAddCount.FillColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdAddCount.Font = New System.Drawing.Font("Montserrat", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddCount.ForeColor = System.Drawing.Color.White
        Me.cmdAddCount.HoverState.Parent = Me.cmdAddCount
        Me.cmdAddCount.Location = New System.Drawing.Point(738, 56)
        Me.cmdAddCount.Name = "cmdAddCount"
        Me.cmdAddCount.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.cmdAddCount.ShadowDecoration.Parent = Me.cmdAddCount
        Me.cmdAddCount.Size = New System.Drawing.Size(30, 30)
        Me.cmdAddCount.TabIndex = 60
        Me.cmdAddCount.Text = ">"
        '
        'cmdMinusCount
        '
        Me.cmdMinusCount.CheckedState.Parent = Me.cmdMinusCount
        Me.cmdMinusCount.CustomImages.Parent = Me.cmdMinusCount
        Me.cmdMinusCount.FillColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdMinusCount.Font = New System.Drawing.Font("Montserrat", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMinusCount.ForeColor = System.Drawing.Color.White
        Me.cmdMinusCount.HoverState.Parent = Me.cmdMinusCount
        Me.cmdMinusCount.Location = New System.Drawing.Point(703, 56)
        Me.cmdMinusCount.Name = "cmdMinusCount"
        Me.cmdMinusCount.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.cmdMinusCount.ShadowDecoration.Parent = Me.cmdMinusCount
        Me.cmdMinusCount.Size = New System.Drawing.Size(30, 30)
        Me.cmdMinusCount.TabIndex = 59
        Me.cmdMinusCount.Text = "<"
        '
        'cmdSelectRoom
        '
        Me.cmdSelectRoom.CheckedState.Parent = Me.cmdSelectRoom
        Me.cmdSelectRoom.CustomImages.Parent = Me.cmdSelectRoom
        Me.cmdSelectRoom.FillColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdSelectRoom.Font = New System.Drawing.Font("Montserrat", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSelectRoom.ForeColor = System.Drawing.Color.White
        Me.cmdSelectRoom.HoverState.Parent = Me.cmdSelectRoom
        Me.cmdSelectRoom.Location = New System.Drawing.Point(325, 103)
        Me.cmdSelectRoom.Name = "cmdSelectRoom"
        Me.cmdSelectRoom.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.cmdSelectRoom.ShadowDecoration.Parent = Me.cmdSelectRoom
        Me.cmdSelectRoom.Size = New System.Drawing.Size(30, 30)
        Me.cmdSelectRoom.TabIndex = 58
        Me.cmdSelectRoom.Text = "V"
        '
        'cmdSelectGuest
        '
        Me.cmdSelectGuest.CheckedState.Parent = Me.cmdSelectGuest
        Me.cmdSelectGuest.CustomImages.Parent = Me.cmdSelectGuest
        Me.cmdSelectGuest.FillColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdSelectGuest.Font = New System.Drawing.Font("Montserrat", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSelectGuest.ForeColor = System.Drawing.Color.White
        Me.cmdSelectGuest.HoverState.Parent = Me.cmdSelectGuest
        Me.cmdSelectGuest.Location = New System.Drawing.Point(325, 55)
        Me.cmdSelectGuest.Name = "cmdSelectGuest"
        Me.cmdSelectGuest.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.cmdSelectGuest.ShadowDecoration.Parent = Me.cmdSelectGuest
        Me.cmdSelectGuest.Size = New System.Drawing.Size(30, 30)
        Me.cmdSelectGuest.TabIndex = 57
        Me.cmdSelectGuest.Text = "V"
        '
        'txtNumDays
        '
        Me.txtNumDays.AutoRoundedCorners = True
        Me.txtNumDays.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.txtNumDays.BorderRadius = 14
        Me.txtNumDays.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNumDays.DefaultText = ""
        Me.txtNumDays.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNumDays.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNumDays.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNumDays.DisabledState.Parent = Me.txtNumDays
        Me.txtNumDays.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNumDays.Enabled = False
        Me.txtNumDays.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.txtNumDays.FocusedState.Parent = Me.txtNumDays
        Me.txtNumDays.Font = New System.Drawing.Font("Source Sans Pro", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumDays.ForeColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.txtNumDays.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNumDays.HoverState.Parent = Me.txtNumDays
        Me.txtNumDays.Location = New System.Drawing.Point(148, 356)
        Me.txtNumDays.Name = "txtNumDays"
        Me.txtNumDays.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNumDays.PlaceholderText = "Select Room"
        Me.txtNumDays.SelectedText = ""
        Me.txtNumDays.ShadowDecoration.Parent = Me.txtNumDays
        Me.txtNumDays.Size = New System.Drawing.Size(96, 31)
        Me.txtNumDays.TabIndex = 55
        Me.txtNumDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTotal
        '
        Me.txtTotal.AutoRoundedCorners = True
        Me.txtTotal.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.txtTotal.BorderRadius = 14
        Me.txtTotal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTotal.DefaultText = ""
        Me.txtTotal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtTotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtTotal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTotal.DisabledState.Parent = Me.txtTotal
        Me.txtTotal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTotal.Enabled = False
        Me.txtTotal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.txtTotal.FocusedState.Parent = Me.txtTotal
        Me.txtTotal.Font = New System.Drawing.Font("Source Sans Pro", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.txtTotal.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTotal.HoverState.Parent = Me.txtTotal
        Me.txtTotal.Location = New System.Drawing.Point(565, 289)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTotal.PlaceholderText = "Select Room"
        Me.txtTotal.SelectedText = ""
        Me.txtTotal.ShadowDecoration.Parent = Me.txtTotal
        Me.txtTotal.Size = New System.Drawing.Size(169, 31)
        Me.txtTotal.TabIndex = 54
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtRate
        '
        Me.txtRate.AutoRoundedCorners = True
        Me.txtRate.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.txtRate.BorderRadius = 14
        Me.txtRate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRate.DefaultText = ""
        Me.txtRate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtRate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtRate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRate.DisabledState.Parent = Me.txtRate
        Me.txtRate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRate.Enabled = False
        Me.txtRate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.txtRate.FocusedState.Parent = Me.txtRate
        Me.txtRate.Font = New System.Drawing.Font("Source Sans Pro", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.txtRate.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRate.HoverState.Parent = Me.txtRate
        Me.txtRate.Location = New System.Drawing.Point(149, 177)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRate.PlaceholderText = "Select Room"
        Me.txtRate.SelectedText = ""
        Me.txtRate.ShadowDecoration.Parent = Me.txtRate
        Me.txtRate.Size = New System.Drawing.Size(96, 31)
        Me.txtRate.TabIndex = 53
        Me.txtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSubtotal
        '
        Me.txtSubtotal.AutoRoundedCorners = True
        Me.txtSubtotal.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.txtSubtotal.BorderRadius = 14
        Me.txtSubtotal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSubtotal.DefaultText = ""
        Me.txtSubtotal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSubtotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSubtotal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSubtotal.DisabledState.Parent = Me.txtSubtotal
        Me.txtSubtotal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSubtotal.Enabled = False
        Me.txtSubtotal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.txtSubtotal.FocusedState.Parent = Me.txtSubtotal
        Me.txtSubtotal.Font = New System.Drawing.Font("Source Sans Pro", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubtotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.txtSubtotal.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSubtotal.HoverState.Parent = Me.txtSubtotal
        Me.txtSubtotal.Location = New System.Drawing.Point(564, 108)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSubtotal.PlaceholderText = "Select Room"
        Me.txtSubtotal.SelectedText = ""
        Me.txtSubtotal.ShadowDecoration.Parent = Me.txtSubtotal
        Me.txtSubtotal.Size = New System.Drawing.Size(169, 31)
        Me.txtSubtotal.TabIndex = 52
        Me.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtRoomType
        '
        Me.txtRoomType.AutoRoundedCorners = True
        Me.txtRoomType.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.txtRoomType.BorderRadius = 14
        Me.txtRoomType.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRoomType.DefaultText = ""
        Me.txtRoomType.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtRoomType.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtRoomType.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRoomType.DisabledState.Parent = Me.txtRoomType
        Me.txtRoomType.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRoomType.Enabled = False
        Me.txtRoomType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.txtRoomType.FocusedState.Parent = Me.txtRoomType
        Me.txtRoomType.Font = New System.Drawing.Font("Source Sans Pro", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRoomType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.txtRoomType.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRoomType.HoverState.Parent = Me.txtRoomType
        Me.txtRoomType.Location = New System.Drawing.Point(149, 140)
        Me.txtRoomType.Name = "txtRoomType"
        Me.txtRoomType.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRoomType.PlaceholderText = "Select Room"
        Me.txtRoomType.SelectedText = ""
        Me.txtRoomType.ShadowDecoration.Parent = Me.txtRoomType
        Me.txtRoomType.Size = New System.Drawing.Size(125, 31)
        Me.txtRoomType.TabIndex = 56
        Me.txtRoomType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtRoomNum
        '
        Me.txtRoomNum.AutoRoundedCorners = True
        Me.txtRoomNum.BorderColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.txtRoomNum.BorderRadius = 14
        Me.txtRoomNum.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRoomNum.DefaultText = ""
        Me.txtRoomNum.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtRoomNum.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtRoomNum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRoomNum.DisabledState.Parent = Me.txtRoomNum
        Me.txtRoomNum.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRoomNum.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.txtRoomNum.FocusedState.Parent = Me.txtRoomNum
        Me.txtRoomNum.Font = New System.Drawing.Font("Source Sans Pro", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRoomNum.ForeColor = System.Drawing.Color.Black
        Me.txtRoomNum.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRoomNum.HoverState.Parent = Me.txtRoomNum
        Me.txtRoomNum.Location = New System.Drawing.Point(149, 103)
        Me.txtRoomNum.Name = "txtRoomNum"
        Me.txtRoomNum.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRoomNum.PlaceholderText = "Select Room"
        Me.txtRoomNum.ReadOnly = True
        Me.txtRoomNum.SelectedText = ""
        Me.txtRoomNum.ShadowDecoration.Parent = Me.txtRoomNum
        Me.txtRoomNum.Size = New System.Drawing.Size(170, 31)
        Me.txtRoomNum.TabIndex = 51
        Me.txtRoomNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNumGuest
        '
        Me.txtNumGuest.AutoRoundedCorners = True
        Me.txtNumGuest.BorderColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.txtNumGuest.BorderRadius = 14
        Me.txtNumGuest.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNumGuest.DefaultText = "1"
        Me.txtNumGuest.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNumGuest.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNumGuest.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNumGuest.DisabledState.Parent = Me.txtNumGuest
        Me.txtNumGuest.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNumGuest.Enabled = False
        Me.txtNumGuest.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.txtNumGuest.FocusedState.Parent = Me.txtNumGuest
        Me.txtNumGuest.Font = New System.Drawing.Font("Source Sans Pro", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumGuest.ForeColor = System.Drawing.Color.Black
        Me.txtNumGuest.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNumGuest.HoverState.Parent = Me.txtNumGuest
        Me.txtNumGuest.Location = New System.Drawing.Point(565, 56)
        Me.txtNumGuest.Name = "txtNumGuest"
        Me.txtNumGuest.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNumGuest.PlaceholderText = "Select Guest"
        Me.txtNumGuest.SelectedText = ""
        Me.txtNumGuest.SelectionStart = 1
        Me.txtNumGuest.ShadowDecoration.Parent = Me.txtNumGuest
        Me.txtNumGuest.Size = New System.Drawing.Size(125, 31)
        Me.txtNumGuest.TabIndex = 50
        Me.txtNumGuest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtGuest
        '
        Me.txtGuest.AutoRoundedCorners = True
        Me.txtGuest.BorderColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.txtGuest.BorderRadius = 14
        Me.txtGuest.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtGuest.DefaultText = ""
        Me.txtGuest.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtGuest.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtGuest.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtGuest.DisabledState.Parent = Me.txtGuest
        Me.txtGuest.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtGuest.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.txtGuest.FocusedState.Parent = Me.txtGuest
        Me.txtGuest.Font = New System.Drawing.Font("Source Sans Pro", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuest.ForeColor = System.Drawing.Color.Black
        Me.txtGuest.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtGuest.HoverState.Parent = Me.txtGuest
        Me.txtGuest.Location = New System.Drawing.Point(148, 56)
        Me.txtGuest.Name = "txtGuest"
        Me.txtGuest.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGuest.PlaceholderText = "Select Guest"
        Me.txtGuest.ReadOnly = True
        Me.txtGuest.SelectedText = ""
        Me.txtGuest.ShadowDecoration.Parent = Me.txtGuest
        Me.txtGuest.Size = New System.Drawing.Size(170, 31)
        Me.txtGuest.TabIndex = 49
        Me.txtGuest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(13, 360)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 17)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "Num of Days:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(487, 295)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(38, 17)
        Me.Label12.TabIndex = 46
        Me.Label12.Text = "Total:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(15, 297)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 17)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "Check Out Date:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(14, 181)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 17)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "Room Rate:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 255)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 17)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "Check In Date:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(486, 114)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 17)
        Me.Label11.TabIndex = 42
        Me.Label11.Text = "Subtotal:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(435, 61)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(109, 17)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "Num of Occupants"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 17)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Room Type:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 17)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Guest Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 17)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Room Num:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 17)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Transaction ID:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Playfair Display Black", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 41)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Reservation"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(200, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(56, 53)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 67
        Me.PictureBox1.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(436, 152)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(107, 17)
        Me.Label13.TabIndex = 42
        Me.Label13.Text = "Advance Payment:"
        '
        'txtAdvPay
        '
        Me.txtAdvPay.AutoRoundedCorners = True
        Me.txtAdvPay.BorderColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.txtAdvPay.BorderRadius = 14
        Me.txtAdvPay.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAdvPay.DefaultText = "0"
        Me.txtAdvPay.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtAdvPay.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtAdvPay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAdvPay.DisabledState.Parent = Me.txtAdvPay
        Me.txtAdvPay.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAdvPay.Enabled = False
        Me.txtAdvPay.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.txtAdvPay.FocusedState.Parent = Me.txtAdvPay
        Me.txtAdvPay.Font = New System.Drawing.Font("Source Sans Pro", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdvPay.ForeColor = System.Drawing.Color.Black
        Me.txtAdvPay.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAdvPay.HoverState.Parent = Me.txtAdvPay
        Me.txtAdvPay.Location = New System.Drawing.Point(564, 146)
        Me.txtAdvPay.Name = "txtAdvPay"
        Me.txtAdvPay.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAdvPay.PlaceholderText = ""
        Me.txtAdvPay.SelectedText = ""
        Me.txtAdvPay.SelectionStart = 1
        Me.txtAdvPay.ShadowDecoration.Parent = Me.txtAdvPay
        Me.txtAdvPay.Size = New System.Drawing.Size(169, 31)
        Me.txtAdvPay.TabIndex = 52
        Me.txtAdvPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmbTypes)
        Me.Panel1.Controls.Add(Me.lblMinPay)
        Me.Panel1.Controls.Add(Me.lblMaxOccu)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.lblGuestID)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.cmdReserve)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.cmdReserveList)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.dtpCheckOut)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.dtpCheckIn)
        Me.Panel1.Controls.Add(Me.cmdAddCount)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.cmdMinusCount)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.cmdSelectRoom)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.cmdSelectGuest)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.txtNumDays)
        Me.Panel1.Controls.Add(Me.txtGuest)
        Me.Panel1.Controls.Add(Me.txtTotal)
        Me.Panel1.Controls.Add(Me.txtNumGuest)
        Me.Panel1.Controls.Add(Me.txtRate)
        Me.Panel1.Controls.Add(Me.txtRoomNum)
        Me.Panel1.Controls.Add(Me.txtAdvPay)
        Me.Panel1.Controls.Add(Me.txtRoomType)
        Me.Panel1.Controls.Add(Me.txtSubtotal)
        Me.Panel1.Location = New System.Drawing.Point(19, 71)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(779, 408)
        Me.Panel1.TabIndex = 68
        '
        'cmbTypes
        '
        Me.cmbTypes.Animated = True
        Me.cmbTypes.AutoRoundedCorners = True
        Me.cmbTypes.BackColor = System.Drawing.Color.Transparent
        Me.cmbTypes.BorderColor = System.Drawing.Color.Black
        Me.cmbTypes.BorderRadius = 14
        Me.cmbTypes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTypes.Enabled = False
        Me.cmbTypes.FocusedColor = System.Drawing.Color.Empty
        Me.cmbTypes.FocusedState.Parent = Me.cmbTypes
        Me.cmbTypes.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbTypes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbTypes.FormattingEnabled = True
        Me.cmbTypes.HoverState.Parent = Me.cmbTypes
        Me.cmbTypes.ItemHeight = 25
        Me.cmbTypes.ItemsAppearance.Parent = Me.cmbTypes
        Me.cmbTypes.Location = New System.Drawing.Point(565, 216)
        Me.cmbTypes.Name = "cmbTypes"
        Me.cmbTypes.ShadowDecoration.Parent = Me.cmbTypes
        Me.cmbTypes.Size = New System.Drawing.Size(169, 31)
        Me.cmbTypes.TabIndex = 70
        '
        'lblMinPay
        '
        Me.lblMinPay.AutoSize = True
        Me.lblMinPay.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinPay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.lblMinPay.Location = New System.Drawing.Point(680, 183)
        Me.lblMinPay.Name = "lblMinPay"
        Me.lblMinPay.Size = New System.Drawing.Size(14, 15)
        Me.lblMinPay.TabIndex = 69
        Me.lblMinPay.Text = "0"
        '
        'lblMaxOccu
        '
        Me.lblMaxOccu.AutoSize = True
        Me.lblMaxOccu.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaxOccu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.lblMaxOccu.Location = New System.Drawing.Point(666, 90)
        Me.lblMaxOccu.Name = "lblMaxOccu"
        Me.lblMaxOccu.Size = New System.Drawing.Size(11, 15)
        Me.lblMaxOccu.TabIndex = 69
        Me.lblMaxOccu.Text = "1"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(541, 183)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(141, 15)
        Me.Label17.TabIndex = 69
        Me.Label17.Text = "Payment should be PHP"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(568, 90)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(95, 15)
        Me.Label15.TabIndex = 69
        Me.Label15.Text = "Max Occupancy:"
        '
        'lblGuestID
        '
        Me.lblGuestID.AutoSize = True
        Me.lblGuestID.Location = New System.Drawing.Point(611, 16)
        Me.lblGuestID.Name = "lblGuestID"
        Me.lblGuestID.Size = New System.Drawing.Size(46, 13)
        Me.lblGuestID.TabIndex = 69
        Me.lblGuestID.Text = "GuestID"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(452, 222)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(87, 17)
        Me.Label16.TabIndex = 42
        Me.Label16.Text = "Payment Type:"
        '
        'Reservation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(810, 491)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cmdMinimize)
        Me.Controls.Add(Me.cmdCLose)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Reservation"
        Me.Text = "Reservation"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents cmdMinimize As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents cmdCLose As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents cmdReserve As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cmdReserveList As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dtpCheckOut As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents dtpCheckIn As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents cmdAddCount As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents cmdMinusCount As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents cmdSelectRoom As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents cmdSelectGuest As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents txtNumDays As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtTotal As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtRate As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtSubtotal As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtRoomType As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtRoomNum As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtNumGuest As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtGuest As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtAdvPay As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblGuestID As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents lblMaxOccu As Label
    Friend WithEvents cmbTypes As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lblMinPay As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
End Class
