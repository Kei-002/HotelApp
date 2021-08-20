<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AvailService
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AvailService))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.cmbEmployee = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cmbServices = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cmdAvail = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRoomNum = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtGuestID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtGuestName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtOccu = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtFee = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmdMinimize = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.cmdCLose = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(60, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(216, 15)
        Me.Label2.TabIndex = 104
        Me.Label2.Text = "Services for guests that are checked in"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Playfair Display", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(104, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(140, 29)
        Me.Label7.TabIndex = 103
        Me.Label7.Text = "Avail Service"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.Controls.Add(Me.cmbEmployee)
        Me.Guna2Panel1.Controls.Add(Me.cmbServices)
        Me.Guna2Panel1.Controls.Add(Me.cmdAvail)
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Controls.Add(Me.txtRoomNum)
        Me.Guna2Panel1.Controls.Add(Me.Label5)
        Me.Guna2Panel1.Controls.Add(Me.txtGuestID)
        Me.Guna2Panel1.Controls.Add(Me.txtGuestName)
        Me.Guna2Panel1.Controls.Add(Me.txtOccu)
        Me.Guna2Panel1.Controls.Add(Me.Label6)
        Me.Guna2Panel1.Controls.Add(Me.txtFee)
        Me.Guna2Panel1.Controls.Add(Me.Label3)
        Me.Guna2Panel1.Controls.Add(Me.Label4)
        Me.Guna2Panel1.Controls.Add(Me.Label8)
        Me.Guna2Panel1.Location = New System.Drawing.Point(12, 76)
        Me.Guna2Panel1.MinimumSize = New System.Drawing.Size(296, 10)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(305, 377)
        Me.Guna2Panel1.TabIndex = 105
        '
        'cmbEmployee
        '
        Me.cmbEmployee.AutoRoundedCorners = True
        Me.cmbEmployee.BackColor = System.Drawing.Color.Transparent
        Me.cmbEmployee.BorderColor = System.Drawing.Color.Black
        Me.cmbEmployee.BorderRadius = 13
        Me.cmbEmployee.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEmployee.FocusedColor = System.Drawing.Color.Empty
        Me.cmbEmployee.FocusedState.Parent = Me.cmbEmployee
        Me.cmbEmployee.Font = New System.Drawing.Font("Montserrat", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEmployee.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbEmployee.FormattingEnabled = True
        Me.cmbEmployee.HoverState.Parent = Me.cmbEmployee
        Me.cmbEmployee.ItemHeight = 23
        Me.cmbEmployee.ItemsAppearance.Parent = Me.cmbEmployee
        Me.cmbEmployee.Location = New System.Drawing.Point(119, 195)
        Me.cmbEmployee.Name = "cmbEmployee"
        Me.cmbEmployee.ShadowDecoration.Parent = Me.cmbEmployee
        Me.cmbEmployee.Size = New System.Drawing.Size(170, 29)
        Me.cmbEmployee.TabIndex = 84
        '
        'cmbServices
        '
        Me.cmbServices.AutoRoundedCorners = True
        Me.cmbServices.BackColor = System.Drawing.Color.Transparent
        Me.cmbServices.BorderColor = System.Drawing.Color.Black
        Me.cmbServices.BorderRadius = 13
        Me.cmbServices.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbServices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbServices.FocusedColor = System.Drawing.Color.Empty
        Me.cmbServices.FocusedState.Parent = Me.cmbServices
        Me.cmbServices.Font = New System.Drawing.Font("Montserrat", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbServices.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbServices.FormattingEnabled = True
        Me.cmbServices.HoverState.Parent = Me.cmbServices
        Me.cmbServices.ItemHeight = 23
        Me.cmbServices.ItemsAppearance.Parent = Me.cmbServices
        Me.cmbServices.Location = New System.Drawing.Point(119, 18)
        Me.cmbServices.Name = "cmbServices"
        Me.cmbServices.ShadowDecoration.Parent = Me.cmbServices
        Me.cmbServices.Size = New System.Drawing.Size(170, 29)
        Me.cmbServices.TabIndex = 84
        '
        'cmdAvail
        '
        Me.cmdAvail.Animated = True
        Me.cmdAvail.CheckedState.Parent = Me.cmdAvail
        Me.cmdAvail.CustomImages.Parent = Me.cmdAvail
        Me.cmdAvail.FillColor = System.Drawing.Color.Transparent
        Me.cmdAvail.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAvail.ForeColor = System.Drawing.Color.Black
        Me.cmdAvail.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.cmdAvail.HoverState.Image = CType(resources.GetObject("cmdAvail.HoverState.Image"), System.Drawing.Image)
        Me.cmdAvail.HoverState.Parent = Me.cmdAvail
        Me.cmdAvail.Image = Global.zzzz.My.Resources.Resources.bell
        Me.cmdAvail.ImageSize = New System.Drawing.Size(30, 30)
        Me.cmdAvail.Location = New System.Drawing.Point(66, 319)
        Me.cmdAvail.Name = "cmdAvail"
        Me.cmdAvail.ShadowDecoration.Parent = Me.cmdAvail
        Me.cmdAvail.Size = New System.Drawing.Size(166, 45)
        Me.cmdAvail.TabIndex = 83
        Me.cmdAvail.Text = "Avail Service"
        Me.cmdAvail.TextOffset = New System.Drawing.Point(0, 3)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 200)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 17)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Employee:"
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
        Me.txtRoomNum.Enabled = False
        Me.txtRoomNum.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.txtRoomNum.FocusedState.Parent = Me.txtRoomNum
        Me.txtRoomNum.Font = New System.Drawing.Font("Source Sans Pro", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRoomNum.ForeColor = System.Drawing.Color.Black
        Me.txtRoomNum.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRoomNum.HoverState.Parent = Me.txtRoomNum
        Me.txtRoomNum.Location = New System.Drawing.Point(140, 108)
        Me.txtRoomNum.Name = "txtRoomNum"
        Me.txtRoomNum.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRoomNum.PlaceholderText = ""
        Me.txtRoomNum.SelectedText = ""
        Me.txtRoomNum.ShadowDecoration.Parent = Me.txtRoomNum
        Me.txtRoomNum.Size = New System.Drawing.Size(146, 31)
        Me.txtRoomNum.TabIndex = 51
        Me.txtRoomNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 17)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "Service Availed:"
        '
        'txtGuestID
        '
        Me.txtGuestID.AutoRoundedCorners = True
        Me.txtGuestID.BorderColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.txtGuestID.BorderRadius = 14
        Me.txtGuestID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtGuestID.DefaultText = ""
        Me.txtGuestID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtGuestID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtGuestID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtGuestID.DisabledState.Parent = Me.txtGuestID
        Me.txtGuestID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtGuestID.Enabled = False
        Me.txtGuestID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.txtGuestID.FocusedState.Parent = Me.txtGuestID
        Me.txtGuestID.Font = New System.Drawing.Font("Source Sans Pro", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuestID.ForeColor = System.Drawing.Color.Black
        Me.txtGuestID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtGuestID.HoverState.Parent = Me.txtGuestID
        Me.txtGuestID.Location = New System.Drawing.Point(97, 71)
        Me.txtGuestID.Name = "txtGuestID"
        Me.txtGuestID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGuestID.PlaceholderText = ""
        Me.txtGuestID.SelectedText = ""
        Me.txtGuestID.ShadowDecoration.Parent = Me.txtGuestID
        Me.txtGuestID.Size = New System.Drawing.Size(37, 31)
        Me.txtGuestID.TabIndex = 51
        Me.txtGuestID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtGuestName
        '
        Me.txtGuestName.AutoRoundedCorners = True
        Me.txtGuestName.BorderColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.txtGuestName.BorderRadius = 14
        Me.txtGuestName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtGuestName.DefaultText = ""
        Me.txtGuestName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtGuestName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtGuestName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtGuestName.DisabledState.Parent = Me.txtGuestName
        Me.txtGuestName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtGuestName.Enabled = False
        Me.txtGuestName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.txtGuestName.FocusedState.Parent = Me.txtGuestName
        Me.txtGuestName.Font = New System.Drawing.Font("Source Sans Pro", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuestName.ForeColor = System.Drawing.Color.Black
        Me.txtGuestName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtGuestName.HoverState.Parent = Me.txtGuestName
        Me.txtGuestName.Location = New System.Drawing.Point(140, 71)
        Me.txtGuestName.Name = "txtGuestName"
        Me.txtGuestName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGuestName.PlaceholderText = ""
        Me.txtGuestName.SelectedText = ""
        Me.txtGuestName.ShadowDecoration.Parent = Me.txtGuestName
        Me.txtGuestName.Size = New System.Drawing.Size(146, 31)
        Me.txtGuestName.TabIndex = 51
        Me.txtGuestName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtOccu
        '
        Me.txtOccu.AutoRoundedCorners = True
        Me.txtOccu.BorderColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.txtOccu.BorderRadius = 14
        Me.txtOccu.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtOccu.DefaultText = ""
        Me.txtOccu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtOccu.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtOccu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtOccu.DisabledState.Parent = Me.txtOccu
        Me.txtOccu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtOccu.Enabled = False
        Me.txtOccu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.txtOccu.FocusedState.Parent = Me.txtOccu
        Me.txtOccu.Font = New System.Drawing.Font("Source Sans Pro", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOccu.ForeColor = System.Drawing.Color.Black
        Me.txtOccu.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtOccu.HoverState.Parent = Me.txtOccu
        Me.txtOccu.Location = New System.Drawing.Point(140, 145)
        Me.txtOccu.Name = "txtOccu"
        Me.txtOccu.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtOccu.PlaceholderText = ""
        Me.txtOccu.SelectedText = ""
        Me.txtOccu.ShadowDecoration.Parent = Me.txtOccu
        Me.txtOccu.Size = New System.Drawing.Size(146, 31)
        Me.txtOccu.TabIndex = 51
        Me.txtOccu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 17)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "Guests Inside:"
        '
        'txtFee
        '
        Me.txtFee.AutoRoundedCorners = True
        Me.txtFee.BorderColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.txtFee.BorderRadius = 14
        Me.txtFee.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFee.DefaultText = ""
        Me.txtFee.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtFee.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtFee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFee.DisabledState.Parent = Me.txtFee
        Me.txtFee.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFee.Enabled = False
        Me.txtFee.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.txtFee.FocusedState.Parent = Me.txtFee
        Me.txtFee.Font = New System.Drawing.Font("Source Sans Pro", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFee.ForeColor = System.Drawing.Color.Black
        Me.txtFee.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFee.HoverState.Parent = Me.txtFee
        Me.txtFee.Location = New System.Drawing.Point(140, 265)
        Me.txtFee.Name = "txtFee"
        Me.txtFee.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFee.PlaceholderText = ""
        Me.txtFee.SelectedText = ""
        Me.txtFee.ShadowDecoration.Parent = Me.txtFee
        Me.txtFee.Size = New System.Drawing.Size(146, 31)
        Me.txtFee.TabIndex = 51
        Me.txtFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 270)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 17)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "ServiceFee:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 17)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Guest:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(9, 115)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 17)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "Room Num:"
        '
        'cmdMinimize
        '
        Me.cmdMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdMinimize.CheckedState.Parent = Me.cmdMinimize
        Me.cmdMinimize.CustomImages.Parent = Me.cmdMinimize
        Me.cmdMinimize.FillColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.cmdMinimize.Font = New System.Drawing.Font("Montserrat", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMinimize.ForeColor = System.Drawing.Color.White
        Me.cmdMinimize.HoverState.Parent = Me.cmdMinimize
        Me.cmdMinimize.Location = New System.Drawing.Point(272, 9)
        Me.cmdMinimize.Name = "cmdMinimize"
        Me.cmdMinimize.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.cmdMinimize.ShadowDecoration.Parent = Me.cmdMinimize
        Me.cmdMinimize.Size = New System.Drawing.Size(20, 20)
        Me.cmdMinimize.TabIndex = 106
        Me.cmdMinimize.Text = "-"
        '
        'cmdCLose
        '
        Me.cmdCLose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCLose.CheckedState.Parent = Me.cmdCLose
        Me.cmdCLose.CustomImages.Parent = Me.cmdCLose
        Me.cmdCLose.FillColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.cmdCLose.Font = New System.Drawing.Font("Montserrat", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCLose.ForeColor = System.Drawing.Color.White
        Me.cmdCLose.HoverState.Parent = Me.cmdCLose
        Me.cmdCLose.Location = New System.Drawing.Point(298, 9)
        Me.cmdCLose.Name = "cmdCLose"
        Me.cmdCLose.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.cmdCLose.ShadowDecoration.Parent = Me.cmdCLose
        Me.cmdCLose.Size = New System.Drawing.Size(20, 20)
        Me.cmdCLose.TabIndex = 107
        Me.cmdCLose.Text = "X"
        '
        'AvailService
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(330, 465)
        Me.Controls.Add(Me.cmdMinimize)
        Me.Controls.Add(Me.cmdCLose)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AvailService"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AvailService"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents cmdAvail As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtOccu As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtFee As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtRoomNum As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtGuestName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cmbServices As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtGuestID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cmbEmployee As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmdMinimize As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents cmdCLose As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
End Class
