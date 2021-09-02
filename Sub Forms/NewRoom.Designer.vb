<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewRoom
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewRoom))
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.cmdAdd = New Guna.UI2.WinForms.Guna2Button()
        Me.rbOccu = New Guna.UI2.WinForms.Guna2ImageRadioButton()
        Me.rbAvail = New Guna.UI2.WinForms.Guna2ImageRadioButton()
        Me.cmbTypes = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRate = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNumOccu = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtOccu = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtRoomID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmdMinimize = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.cmdCLose = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.Controls.Add(Me.cmdAdd)
        Me.Guna2Panel1.Controls.Add(Me.rbOccu)
        Me.Guna2Panel1.Controls.Add(Me.rbAvail)
        Me.Guna2Panel1.Controls.Add(Me.cmbTypes)
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Controls.Add(Me.txtRate)
        Me.Guna2Panel1.Controls.Add(Me.Label6)
        Me.Guna2Panel1.Controls.Add(Me.txtNumOccu)
        Me.Guna2Panel1.Controls.Add(Me.Label5)
        Me.Guna2Panel1.Controls.Add(Me.txtOccu)
        Me.Guna2Panel1.Controls.Add(Me.Label3)
        Me.Guna2Panel1.Controls.Add(Me.Label2)
        Me.Guna2Panel1.Controls.Add(Me.txtRoomID)
        Me.Guna2Panel1.Controls.Add(Me.Label4)
        Me.Guna2Panel1.Location = New System.Drawing.Point(12, 53)
        Me.Guna2Panel1.MinimumSize = New System.Drawing.Size(296, 10)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(296, 320)
        Me.Guna2Panel1.TabIndex = 80
        '
        'cmdAdd
        '
        Me.cmdAdd.Animated = True
        Me.cmdAdd.CheckedState.Parent = Me.cmdAdd
        Me.cmdAdd.CustomImages.Parent = Me.cmdAdd
        Me.cmdAdd.FillColor = System.Drawing.Color.Transparent
        Me.cmdAdd.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAdd.ForeColor = System.Drawing.Color.Black
        Me.cmdAdd.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.cmdAdd.HoverState.Image = CType(resources.GetObject("cmdAdd.HoverState.Image"), System.Drawing.Image)
        Me.cmdAdd.HoverState.Parent = Me.cmdAdd
        Me.cmdAdd.Image = CType(resources.GetObject("cmdAdd.Image"), System.Drawing.Image)
        Me.cmdAdd.ImageSize = New System.Drawing.Size(30, 30)
        Me.cmdAdd.Location = New System.Drawing.Point(66, 267)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.ShadowDecoration.Parent = Me.cmdAdd
        Me.cmdAdd.Size = New System.Drawing.Size(166, 45)
        Me.cmdAdd.TabIndex = 83
        Me.cmdAdd.Text = "Add Room"
        '
        'rbOccu
        '
        Me.rbOccu.CheckedState.Image = CType(resources.GetObject("rbOccu.CheckedState.Image"), System.Drawing.Image)
        Me.rbOccu.CheckedState.ImageSize = New System.Drawing.Size(42, 42)
        Me.rbOccu.CheckedState.Parent = Me.rbOccu
        Me.rbOccu.HoverState.Image = CType(resources.GetObject("rbOccu.HoverState.Image"), System.Drawing.Image)
        Me.rbOccu.HoverState.ImageSize = New System.Drawing.Size(40, 40)
        Me.rbOccu.HoverState.Parent = Me.rbOccu
        Me.rbOccu.Image = CType(resources.GetObject("rbOccu.Image"), System.Drawing.Image)
        Me.rbOccu.ImageSize = New System.Drawing.Size(40, 40)
        Me.rbOccu.Location = New System.Drawing.Point(208, 194)
        Me.rbOccu.Name = "rbOccu"
        Me.rbOccu.PressedState.Parent = Me.rbOccu
        Me.rbOccu.Size = New System.Drawing.Size(79, 50)
        Me.rbOccu.TabIndex = 82
        '
        'rbAvail
        '
        Me.rbAvail.CheckedState.Image = CType(resources.GetObject("rbAvail.CheckedState.Image"), System.Drawing.Image)
        Me.rbAvail.CheckedState.ImageSize = New System.Drawing.Size(42, 42)
        Me.rbAvail.CheckedState.Parent = Me.rbAvail
        Me.rbAvail.HoverState.Image = CType(resources.GetObject("rbAvail.HoverState.Image"), System.Drawing.Image)
        Me.rbAvail.HoverState.ImageSize = New System.Drawing.Size(40, 40)
        Me.rbAvail.HoverState.Parent = Me.rbAvail
        Me.rbAvail.Image = CType(resources.GetObject("rbAvail.Image"), System.Drawing.Image)
        Me.rbAvail.ImageSize = New System.Drawing.Size(40, 40)
        Me.rbAvail.Location = New System.Drawing.Point(116, 194)
        Me.rbAvail.Name = "rbAvail"
        Me.rbAvail.PressedState.Parent = Me.rbAvail
        Me.rbAvail.Size = New System.Drawing.Size(86, 50)
        Me.rbAvail.TabIndex = 82
        '
        'cmbTypes
        '
        Me.cmbTypes.AutoRoundedCorners = True
        Me.cmbTypes.BackColor = System.Drawing.Color.Transparent
        Me.cmbTypes.BorderColor = System.Drawing.Color.Black
        Me.cmbTypes.BorderRadius = 12
        Me.cmbTypes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTypes.FocusedColor = System.Drawing.Color.Empty
        Me.cmbTypes.FocusedState.Parent = Me.cmbTypes
        Me.cmbTypes.Font = New System.Drawing.Font("Montserrat", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTypes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbTypes.FormattingEnabled = True
        Me.cmbTypes.HoverState.Parent = Me.cmbTypes
        Me.cmbTypes.ItemHeight = 20
        Me.cmbTypes.ItemsAppearance.Parent = Me.cmbTypes
        Me.cmbTypes.Location = New System.Drawing.Point(117, 51)
        Me.cmbTypes.Name = "cmbTypes"
        Me.cmbTypes.ShadowDecoration.Parent = Me.cmbTypes
        Me.cmbTypes.Size = New System.Drawing.Size(170, 26)
        Me.cmbTypes.TabIndex = 80
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 199)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 17)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Status:"
        '
        'txtRate
        '
        Me.txtRate.AutoRoundedCorners = True
        Me.txtRate.BorderColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(61, Byte), Integer))
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
        Me.txtRate.ForeColor = System.Drawing.Color.Black
        Me.txtRate.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRate.HoverState.Parent = Me.txtRate
        Me.txtRate.Location = New System.Drawing.Point(141, 83)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRate.PlaceholderText = "Select Guest"
        Me.txtRate.SelectedText = ""
        Me.txtRate.ShadowDecoration.Parent = Me.txtRate
        Me.txtRate.Size = New System.Drawing.Size(146, 31)
        Me.txtRate.TabIndex = 51
        Me.txtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(10, 89)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 17)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "Room Rate:"
        '
        'txtNumOccu
        '
        Me.txtNumOccu.AutoRoundedCorners = True
        Me.txtNumOccu.BorderColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.txtNumOccu.BorderRadius = 14
        Me.txtNumOccu.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNumOccu.DefaultText = ""
        Me.txtNumOccu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNumOccu.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNumOccu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNumOccu.DisabledState.Parent = Me.txtNumOccu
        Me.txtNumOccu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNumOccu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.txtNumOccu.FocusedState.Parent = Me.txtNumOccu
        Me.txtNumOccu.Font = New System.Drawing.Font("Source Sans Pro", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumOccu.ForeColor = System.Drawing.Color.Black
        Me.txtNumOccu.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNumOccu.HoverState.Parent = Me.txtNumOccu
        Me.txtNumOccu.Location = New System.Drawing.Point(141, 120)
        Me.txtNumOccu.Name = "txtNumOccu"
        Me.txtNumOccu.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNumOccu.PlaceholderText = "Select Guest"
        Me.txtNumOccu.SelectedText = ""
        Me.txtNumOccu.ShadowDecoration.Parent = Me.txtNumOccu
        Me.txtNumOccu.Size = New System.Drawing.Size(146, 31)
        Me.txtNumOccu.TabIndex = 51
        Me.txtNumOccu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(10, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 17)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "Num of Occupants:"
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
        Me.txtOccu.Location = New System.Drawing.Point(141, 157)
        Me.txtOccu.Name = "txtOccu"
        Me.txtOccu.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtOccu.PlaceholderText = "Select Guest"
        Me.txtOccu.SelectedText = ""
        Me.txtOccu.ShadowDecoration.Parent = Me.txtOccu
        Me.txtOccu.Size = New System.Drawing.Size(146, 31)
        Me.txtOccu.TabIndex = 51
        Me.txtOccu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 17)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Capacity:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 17)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Room Type:"
        '
        'txtRoomID
        '
        Me.txtRoomID.AutoRoundedCorners = True
        Me.txtRoomID.BorderColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.txtRoomID.BorderRadius = 14
        Me.txtRoomID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRoomID.DefaultText = ""
        Me.txtRoomID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtRoomID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtRoomID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRoomID.DisabledState.Parent = Me.txtRoomID
        Me.txtRoomID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRoomID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.txtRoomID.FocusedState.Parent = Me.txtRoomID
        Me.txtRoomID.Font = New System.Drawing.Font("Source Sans Pro", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRoomID.ForeColor = System.Drawing.Color.Black
        Me.txtRoomID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRoomID.HoverState.Parent = Me.txtRoomID
        Me.txtRoomID.Location = New System.Drawing.Point(117, 12)
        Me.txtRoomID.Name = "txtRoomID"
        Me.txtRoomID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRoomID.PlaceholderText = "Leave Blank if Adding"
        Me.txtRoomID.SelectedText = ""
        Me.txtRoomID.ShadowDecoration.Parent = Me.txtRoomID
        Me.txtRoomID.Size = New System.Drawing.Size(170, 31)
        Me.txtRoomID.TabIndex = 51
        Me.txtRoomID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 17)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Room Num:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Playfair Display Black", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(18, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(163, 41)
        Me.Label7.TabIndex = 85
        Me.Label7.Text = "New Room"
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
        Me.cmdMinimize.Location = New System.Drawing.Point(262, 9)
        Me.cmdMinimize.Name = "cmdMinimize"
        Me.cmdMinimize.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.cmdMinimize.ShadowDecoration.Parent = Me.cmdMinimize
        Me.cmdMinimize.Size = New System.Drawing.Size(20, 20)
        Me.cmdMinimize.TabIndex = 87
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
        Me.cmdCLose.Location = New System.Drawing.Point(288, 9)
        Me.cmdCLose.Name = "cmdCLose"
        Me.cmdCLose.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.cmdCLose.ShadowDecoration.Parent = Me.cmdCLose
        Me.cmdCLose.Size = New System.Drawing.Size(20, 20)
        Me.cmdCLose.TabIndex = 88
        Me.cmdCLose.Text = "X"
        '
        'NewRoom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(319, 388)
        Me.Controls.Add(Me.cmdMinimize)
        Me.Controls.Add(Me.cmdCLose)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "NewRoom"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NewRoom"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents cmdAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents rbOccu As Guna.UI2.WinForms.Guna2ImageRadioButton
    Friend WithEvents rbAvail As Guna.UI2.WinForms.Guna2ImageRadioButton
    Friend WithEvents cmbTypes As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNumOccu As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtOccu As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtRoomID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cmdMinimize As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents cmdCLose As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents txtRate As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
End Class
