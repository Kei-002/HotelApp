<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckOut
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CheckOut))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.cmdMinimize = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.cmdCLose = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.txtCheckOut = New Guna.UI2.WinForms.Guna2Button()
        Me.dtpCheckOut = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.dtpCheckIn = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.cmdCheckList = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.txtNumDays = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtTotal = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtRate = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtRoomType = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtRoomNum = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtNumGuest = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtGuest = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSubtotal = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtChange = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtCash = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblGuestID = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cmbType = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2ShadowPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 10
        Me.Guna2Elipse1.TargetControl = Me
        '
        'cmdMinimize
        '
        Me.cmdMinimize.CheckedState.Parent = Me.cmdMinimize
        Me.cmdMinimize.CustomImages.Parent = Me.cmdMinimize
        Me.cmdMinimize.FillColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.cmdMinimize.Font = New System.Drawing.Font("Montserrat", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMinimize.ForeColor = System.Drawing.Color.White
        Me.cmdMinimize.HoverState.Parent = Me.cmdMinimize
        Me.cmdMinimize.Location = New System.Drawing.Point(710, 12)
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
        Me.cmdCLose.Location = New System.Drawing.Point(736, 12)
        Me.cmdCLose.Name = "cmdCLose"
        Me.cmdCLose.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.cmdCLose.ShadowDecoration.Parent = Me.cmdCLose
        Me.cmdCLose.Size = New System.Drawing.Size(20, 20)
        Me.cmdCLose.TabIndex = 66
        Me.cmdCLose.Text = "X"
        '
        'txtCheckOut
        '
        Me.txtCheckOut.AutoRoundedCorners = True
        Me.txtCheckOut.BorderRadius = 17
        Me.txtCheckOut.BorderThickness = 1
        Me.txtCheckOut.CheckedState.Parent = Me.txtCheckOut
        Me.txtCheckOut.CustomImages.Parent = Me.txtCheckOut
        Me.txtCheckOut.FillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.txtCheckOut.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCheckOut.ForeColor = System.Drawing.Color.White
        Me.txtCheckOut.HoverState.Parent = Me.txtCheckOut
        Me.txtCheckOut.Location = New System.Drawing.Point(212, 140)
        Me.txtCheckOut.Name = "txtCheckOut"
        Me.txtCheckOut.ShadowDecoration.Parent = Me.txtCheckOut
        Me.txtCheckOut.Size = New System.Drawing.Size(128, 36)
        Me.txtCheckOut.TabIndex = 64
        Me.txtCheckOut.Text = "Check Out"
        '
        'dtpCheckOut
        '
        Me.dtpCheckOut.CheckedState.Parent = Me.dtpCheckOut
        Me.dtpCheckOut.FillColor = System.Drawing.Color.Transparent
        Me.dtpCheckOut.Font = New System.Drawing.Font("Source Sans Pro", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpCheckOut.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.dtpCheckOut.HoverState.Parent = Me.dtpCheckOut
        Me.dtpCheckOut.Location = New System.Drawing.Point(159, 330)
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
        Me.dtpCheckIn.Location = New System.Drawing.Point(159, 288)
        Me.dtpCheckIn.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpCheckIn.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpCheckIn.Name = "dtpCheckIn"
        Me.dtpCheckIn.ShadowDecoration.Parent = Me.dtpCheckIn
        Me.dtpCheckIn.Size = New System.Drawing.Size(200, 36)
        Me.dtpCheckIn.TabIndex = 61
        Me.dtpCheckIn.Value = New Date(2021, 8, 17, 14, 56, 1, 829)
        '
        'cmdCheckList
        '
        Me.cmdCheckList.CheckedState.Parent = Me.cmdCheckList
        Me.cmdCheckList.CustomImages.Parent = Me.cmdCheckList
        Me.cmdCheckList.FillColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdCheckList.Font = New System.Drawing.Font("Montserrat", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCheckList.ForeColor = System.Drawing.Color.White
        Me.cmdCheckList.HoverState.Parent = Me.cmdCheckList
        Me.cmdCheckList.Location = New System.Drawing.Point(335, 118)
        Me.cmdCheckList.Name = "cmdCheckList"
        Me.cmdCheckList.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.cmdCheckList.ShadowDecoration.Parent = Me.cmdCheckList
        Me.cmdCheckList.Size = New System.Drawing.Size(30, 30)
        Me.cmdCheckList.TabIndex = 57
        Me.cmdCheckList.Text = "V"
        '
        'txtNumDays
        '
        Me.txtNumDays.AutoRoundedCorners = True
        Me.txtNumDays.BorderColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.txtNumDays.BorderRadius = 14
        Me.txtNumDays.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNumDays.DefaultText = ""
        Me.txtNumDays.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNumDays.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNumDays.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNumDays.DisabledState.Parent = Me.txtNumDays
        Me.txtNumDays.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNumDays.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.txtNumDays.FocusedState.Parent = Me.txtNumDays
        Me.txtNumDays.Font = New System.Drawing.Font("Source Sans Pro", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumDays.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNumDays.HoverState.Parent = Me.txtNumDays
        Me.txtNumDays.Location = New System.Drawing.Point(159, 379)
        Me.txtNumDays.Name = "txtNumDays"
        Me.txtNumDays.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNumDays.PlaceholderText = "Days staying"
        Me.txtNumDays.SelectedText = ""
        Me.txtNumDays.ShadowDecoration.Parent = Me.txtNumDays
        Me.txtNumDays.Size = New System.Drawing.Size(96, 31)
        Me.txtNumDays.TabIndex = 55
        Me.txtNumDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTotal
        '
        Me.txtTotal.AutoRoundedCorners = True
        Me.txtTotal.BorderColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.txtTotal.BorderRadius = 14
        Me.txtTotal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTotal.DefaultText = ""
        Me.txtTotal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtTotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtTotal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTotal.DisabledState.Parent = Me.txtTotal
        Me.txtTotal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTotal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.txtTotal.FocusedState.Parent = Me.txtTotal
        Me.txtTotal.Font = New System.Drawing.Font("Source Sans Pro", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTotal.HoverState.Parent = Me.txtTotal
        Me.txtTotal.Location = New System.Drawing.Point(534, 219)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTotal.PlaceholderText = "Select Room"
        Me.txtTotal.SelectedText = ""
        Me.txtTotal.ShadowDecoration.Parent = Me.txtTotal
        Me.txtTotal.Size = New System.Drawing.Size(125, 31)
        Me.txtTotal.TabIndex = 54
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtRate
        '
        Me.txtRate.AutoRoundedCorners = True
        Me.txtRate.BorderColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.txtRate.BorderRadius = 14
        Me.txtRate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRate.DefaultText = ""
        Me.txtRate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtRate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtRate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRate.DisabledState.Parent = Me.txtRate
        Me.txtRate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.txtRate.FocusedState.Parent = Me.txtRate
        Me.txtRate.Font = New System.Drawing.Font("Source Sans Pro", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRate.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRate.HoverState.Parent = Me.txtRate
        Me.txtRate.Location = New System.Drawing.Point(159, 240)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRate.PlaceholderText = ""
        Me.txtRate.SelectedText = ""
        Me.txtRate.ShadowDecoration.Parent = Me.txtRate
        Me.txtRate.Size = New System.Drawing.Size(96, 31)
        Me.txtRate.TabIndex = 53
        Me.txtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtRoomType
        '
        Me.txtRoomType.AutoRoundedCorners = True
        Me.txtRoomType.BorderColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.txtRoomType.BorderRadius = 14
        Me.txtRoomType.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRoomType.DefaultText = ""
        Me.txtRoomType.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtRoomType.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtRoomType.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRoomType.DisabledState.Parent = Me.txtRoomType
        Me.txtRoomType.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRoomType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.txtRoomType.FocusedState.Parent = Me.txtRoomType
        Me.txtRoomType.Font = New System.Drawing.Font("Source Sans Pro", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRoomType.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRoomType.HoverState.Parent = Me.txtRoomType
        Me.txtRoomType.Location = New System.Drawing.Point(159, 203)
        Me.txtRoomType.Name = "txtRoomType"
        Me.txtRoomType.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRoomType.PlaceholderText = ""
        Me.txtRoomType.SelectedText = ""
        Me.txtRoomType.ShadowDecoration.Parent = Me.txtRoomType
        Me.txtRoomType.Size = New System.Drawing.Size(125, 31)
        Me.txtRoomType.TabIndex = 56
        Me.txtRoomType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtRoomNum
        '
        Me.txtRoomNum.AutoRoundedCorners = True
        Me.txtRoomNum.BorderColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
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
        Me.txtRoomNum.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRoomNum.HoverState.Parent = Me.txtRoomNum
        Me.txtRoomNum.Location = New System.Drawing.Point(159, 166)
        Me.txtRoomNum.Name = "txtRoomNum"
        Me.txtRoomNum.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRoomNum.PlaceholderText = "Select Room"
        Me.txtRoomNum.SelectedText = ""
        Me.txtRoomNum.ShadowDecoration.Parent = Me.txtRoomNum
        Me.txtRoomNum.Size = New System.Drawing.Size(170, 31)
        Me.txtRoomNum.TabIndex = 51
        Me.txtRoomNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNumGuest
        '
        Me.txtNumGuest.AutoRoundedCorners = True
        Me.txtNumGuest.BorderColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.txtNumGuest.BorderRadius = 14
        Me.txtNumGuest.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNumGuest.DefaultText = ""
        Me.txtNumGuest.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNumGuest.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNumGuest.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNumGuest.DisabledState.Parent = Me.txtNumGuest
        Me.txtNumGuest.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNumGuest.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.txtNumGuest.FocusedState.Parent = Me.txtNumGuest
        Me.txtNumGuest.Font = New System.Drawing.Font("Source Sans Pro", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumGuest.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNumGuest.HoverState.Parent = Me.txtNumGuest
        Me.txtNumGuest.Location = New System.Drawing.Point(534, 119)
        Me.txtNumGuest.Name = "txtNumGuest"
        Me.txtNumGuest.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNumGuest.PlaceholderText = "Enter guests"
        Me.txtNumGuest.SelectedText = ""
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
        Me.txtGuest.Location = New System.Drawing.Point(158, 119)
        Me.txtGuest.Name = "txtGuest"
        Me.txtGuest.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGuest.PlaceholderText = "Select Guest"
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
        Me.Label9.Location = New System.Drawing.Point(50, 385)
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
        Me.Label12.Location = New System.Drawing.Point(456, 225)
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
        Me.Label8.Location = New System.Drawing.Point(52, 339)
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
        Me.Label7.Location = New System.Drawing.Point(50, 246)
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
        Me.Label6.Location = New System.Drawing.Point(52, 297)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 17)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "Check In Date:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(404, 124)
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
        Me.Label5.Location = New System.Drawing.Point(51, 209)
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
        Me.Label4.Location = New System.Drawing.Point(51, 124)
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
        Me.Label3.Location = New System.Drawing.Point(51, 172)
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
        Me.Label2.Location = New System.Drawing.Point(51, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 17)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Transaction ID:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Playfair Display Black", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 41)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Check Out"
        '
        'txtSubtotal
        '
        Me.txtSubtotal.AutoRoundedCorners = True
        Me.txtSubtotal.BorderColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.txtSubtotal.BorderRadius = 14
        Me.txtSubtotal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSubtotal.DefaultText = ""
        Me.txtSubtotal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSubtotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSubtotal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSubtotal.DisabledState.Parent = Me.txtSubtotal
        Me.txtSubtotal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSubtotal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.txtSubtotal.FocusedState.Parent = Me.txtSubtotal
        Me.txtSubtotal.Font = New System.Drawing.Font("Source Sans Pro", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubtotal.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSubtotal.HoverState.Parent = Me.txtSubtotal
        Me.txtSubtotal.Location = New System.Drawing.Point(534, 182)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSubtotal.PlaceholderText = "Select Room"
        Me.txtSubtotal.SelectedText = ""
        Me.txtSubtotal.ShadowDecoration.Parent = Me.txtSubtotal
        Me.txtSubtotal.Size = New System.Drawing.Size(125, 31)
        Me.txtSubtotal.TabIndex = 52
        Me.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(456, 188)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 17)
        Me.Label11.TabIndex = 42
        Me.Label11.Text = "Subtotal:"
        '
        'txtChange
        '
        Me.txtChange.AutoRoundedCorners = True
        Me.txtChange.BorderColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.txtChange.BorderRadius = 15
        Me.txtChange.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtChange.DefaultText = ""
        Me.txtChange.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtChange.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtChange.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtChange.DisabledState.Parent = Me.txtChange
        Me.txtChange.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtChange.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtChange.FocusedState.Parent = Me.txtChange
        Me.txtChange.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtChange.HoverState.Parent = Me.txtChange
        Me.txtChange.Location = New System.Drawing.Point(183, 96)
        Me.txtChange.Name = "txtChange"
        Me.txtChange.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtChange.PlaceholderText = ""
        Me.txtChange.ReadOnly = True
        Me.txtChange.SelectedText = ""
        Me.txtChange.ShadowDecoration.Parent = Me.txtChange
        Me.txtChange.Size = New System.Drawing.Size(162, 32)
        Me.txtChange.TabIndex = 70
        '
        'txtCash
        '
        Me.txtCash.AutoRoundedCorners = True
        Me.txtCash.BorderColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.txtCash.BorderRadius = 15
        Me.txtCash.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCash.DefaultText = ""
        Me.txtCash.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCash.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCash.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCash.DisabledState.Parent = Me.txtCash
        Me.txtCash.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCash.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCash.FocusedState.Parent = Me.txtCash
        Me.txtCash.ForeColor = System.Drawing.Color.Black
        Me.txtCash.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCash.HoverState.Parent = Me.txtCash
        Me.txtCash.Location = New System.Drawing.Point(183, 58)
        Me.txtCash.Name = "txtCash"
        Me.txtCash.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCash.PlaceholderText = ""
        Me.txtCash.SelectedText = ""
        Me.txtCash.ShadowDecoration.Parent = Me.txtCash
        Me.txtCash.Size = New System.Drawing.Size(162, 32)
        Me.txtCash.TabIndex = 71
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Source Sans Pro", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(33, 104)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(64, 19)
        Me.Label14.TabIndex = 68
        Me.Label14.Text = "Change:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Source Sans Pro", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(35, 64)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(47, 20)
        Me.Label13.TabIndex = 69
        Me.Label13.Text = "Cash:"
        '
        'Guna2ShadowPanel1
        '
        Me.Guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel1.Controls.Add(Me.cmbType)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Label15)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Label13)
        Me.Guna2ShadowPanel1.Controls.Add(Me.txtChange)
        Me.Guna2ShadowPanel1.Controls.Add(Me.txtCheckOut)
        Me.Guna2ShadowPanel1.Controls.Add(Me.txtCash)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Label14)
        Me.Guna2ShadowPanel1.FillColor = System.Drawing.Color.White
        Me.Guna2ShadowPanel1.Location = New System.Drawing.Point(407, 256)
        Me.Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Me.Guna2ShadowPanel1.Radius = 5
        Me.Guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.Guna2ShadowPanel1.ShadowDepth = 20
        Me.Guna2ShadowPanel1.Size = New System.Drawing.Size(358, 189)
        Me.Guna2ShadowPanel1.TabIndex = 72
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(181, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(56, 53)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 67
        Me.PictureBox1.TabStop = False
        '
        'lblGuestID
        '
        Me.lblGuestID.AutoSize = True
        Me.lblGuestID.Location = New System.Drawing.Point(605, 49)
        Me.lblGuestID.Name = "lblGuestID"
        Me.lblGuestID.Size = New System.Drawing.Size(46, 13)
        Me.lblGuestID.TabIndex = 73
        Me.lblGuestID.Text = "GuestID"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Source Sans Pro", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(35, 28)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(113, 20)
        Me.Label15.TabIndex = 69
        Me.Label15.Text = "Payment Type:"
        '
        'cmbType
        '
        Me.cmbType.Animated = True
        Me.cmbType.AutoRoundedCorners = True
        Me.cmbType.BackColor = System.Drawing.Color.Transparent
        Me.cmbType.BorderColor = System.Drawing.Color.Black
        Me.cmbType.BorderRadius = 12
        Me.cmbType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbType.FocusedColor = System.Drawing.Color.Empty
        Me.cmbType.FocusedState.Parent = Me.cmbType
        Me.cmbType.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.HoverState.Parent = Me.cmbType
        Me.cmbType.ItemHeight = 20
        Me.cmbType.ItemsAppearance.Parent = Me.cmbType
        Me.cmbType.Location = New System.Drawing.Point(200, 27)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.ShadowDecoration.Parent = Me.cmbType
        Me.cmbType.Size = New System.Drawing.Size(140, 26)
        Me.cmbType.TabIndex = 72
        '
        'CheckOut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(768, 457)
        Me.Controls.Add(Me.lblGuestID)
        Me.Controls.Add(Me.Guna2ShadowPanel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cmdMinimize)
        Me.Controls.Add(Me.cmdCLose)
        Me.Controls.Add(Me.dtpCheckOut)
        Me.Controls.Add(Me.dtpCheckIn)
        Me.Controls.Add(Me.cmdCheckList)
        Me.Controls.Add(Me.txtNumDays)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtRate)
        Me.Controls.Add(Me.txtSubtotal)
        Me.Controls.Add(Me.txtRoomType)
        Me.Controls.Add(Me.txtRoomNum)
        Me.Controls.Add(Me.txtNumGuest)
        Me.Controls.Add(Me.txtGuest)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CheckOut"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CheckOut"
        Me.Guna2ShadowPanel1.ResumeLayout(False)
        Me.Guna2ShadowPanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cmdMinimize As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents cmdCLose As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents txtCheckOut As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dtpCheckOut As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents dtpCheckIn As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents cmdCheckList As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents txtNumDays As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtTotal As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtRate As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtRoomType As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtRoomNum As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtNumGuest As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtGuest As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Label13 As Label
    Friend WithEvents txtChange As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtCash As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtSubtotal As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents lblGuestID As Label
    Friend WithEvents cmbType As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label15 As Label
End Class
