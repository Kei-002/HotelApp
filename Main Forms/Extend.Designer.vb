<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Extend
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Extend))
        Me.cmdMinimize = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.cmdCLose = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmbTypes = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblMinPay = New System.Windows.Forms.Label()
        Me.lblReserveID = New System.Windows.Forms.Label()
        Me.lblGuestID = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtTotal = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPrevPay = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtAdvPay = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtSubtotal = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmdCheckIn = New Guna.UI2.WinForms.Guna2Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpCheckOut = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtpCheckIn = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.txtGuest = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtNumGuest = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtRoomNum = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtRoomType = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cmdSelectGuest = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.txtNumDays = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtRate = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblPrevNum = New System.Windows.Forms.Label()
        Me.lblOldSub = New System.Windows.Forms.Label()
        Me.lblOldTotal = New System.Windows.Forms.Label()
        Me.lblOldAdvance = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.cmdMinimize.Location = New System.Drawing.Point(712, 12)
        Me.cmdMinimize.Name = "cmdMinimize"
        Me.cmdMinimize.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.cmdMinimize.ShadowDecoration.Parent = Me.cmdMinimize
        Me.cmdMinimize.Size = New System.Drawing.Size(20, 20)
        Me.cmdMinimize.TabIndex = 96
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
        Me.cmdCLose.Location = New System.Drawing.Point(738, 12)
        Me.cmdCLose.Name = "cmdCLose"
        Me.cmdCLose.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.cmdCLose.ShadowDecoration.Parent = Me.cmdCLose
        Me.cmdCLose.Size = New System.Drawing.Size(20, 20)
        Me.cmdCLose.TabIndex = 97
        Me.cmdCLose.Text = "X"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmbTypes)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.lblMinPay)
        Me.Panel1.Controls.Add(Me.lblReserveID)
        Me.Panel1.Controls.Add(Me.lblGuestID)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.txtTotal)
        Me.Panel1.Controls.Add(Me.txtPrevPay)
        Me.Panel1.Controls.Add(Me.txtAdvPay)
        Me.Panel1.Controls.Add(Me.txtSubtotal)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.cmdCheckIn)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.dtpCheckOut)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.dtpCheckIn)
        Me.Panel1.Controls.Add(Me.txtGuest)
        Me.Panel1.Controls.Add(Me.txtNumGuest)
        Me.Panel1.Controls.Add(Me.txtRoomNum)
        Me.Panel1.Controls.Add(Me.txtRoomType)
        Me.Panel1.Controls.Add(Me.cmdSelectGuest)
        Me.Panel1.Controls.Add(Me.txtNumDays)
        Me.Panel1.Controls.Add(Me.txtRate)
        Me.Panel1.Location = New System.Drawing.Point(19, 66)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(737, 396)
        Me.Panel1.TabIndex = 100
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
        Me.cmbTypes.FocusedColor = System.Drawing.Color.Empty
        Me.cmbTypes.FocusedState.Parent = Me.cmbTypes
        Me.cmbTypes.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbTypes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbTypes.FormattingEnabled = True
        Me.cmbTypes.HoverState.Parent = Me.cmbTypes
        Me.cmbTypes.ItemHeight = 25
        Me.cmbTypes.ItemsAppearance.Parent = Me.cmbTypes
        Me.cmbTypes.Location = New System.Drawing.Point(509, 243)
        Me.cmbTypes.Name = "cmbTypes"
        Me.cmbTypes.ShadowDecoration.Parent = Me.cmbTypes
        Me.cmbTypes.Size = New System.Drawing.Size(169, 31)
        Me.cmbTypes.TabIndex = 80
        Me.cmbTypes.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(430, 107)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 17)
        Me.Label11.TabIndex = 71
        Me.Label11.Text = "Subtotal:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(396, 249)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(87, 17)
        Me.Label16.TabIndex = 72
        Me.Label16.Text = "Payment Type:"
        Me.Label16.Visible = False
        '
        'lblMinPay
        '
        Me.lblMinPay.AutoSize = True
        Me.lblMinPay.Location = New System.Drawing.Point(634, 19)
        Me.lblMinPay.Name = "lblMinPay"
        Me.lblMinPay.Size = New System.Drawing.Size(13, 13)
        Me.lblMinPay.TabIndex = 101
        Me.lblMinPay.Text = "0"
        Me.lblMinPay.Visible = False
        '
        'lblReserveID
        '
        Me.lblReserveID.AutoSize = True
        Me.lblReserveID.Location = New System.Drawing.Point(136, 17)
        Me.lblReserveID.Name = "lblReserveID"
        Me.lblReserveID.Size = New System.Drawing.Size(18, 13)
        Me.lblReserveID.TabIndex = 101
        Me.lblReserveID.Text = "ID"
        '
        'lblGuestID
        '
        Me.lblGuestID.AutoSize = True
        Me.lblGuestID.Location = New System.Drawing.Point(296, 15)
        Me.lblGuestID.Name = "lblGuestID"
        Me.lblGuestID.Size = New System.Drawing.Size(44, 13)
        Me.lblGuestID.TabIndex = 101
        Me.lblGuestID.Text = "guestID"
        Me.lblGuestID.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(381, 162)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(107, 17)
        Me.Label14.TabIndex = 73
        Me.Label14.Text = "Previous Payment:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(380, 199)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(107, 17)
        Me.Label12.TabIndex = 73
        Me.Label12.Text = "Advance Payment:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(431, 300)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(38, 17)
        Me.Label15.TabIndex = 74
        Me.Label15.Text = "Total:"
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
        Me.txtTotal.Location = New System.Drawing.Point(509, 294)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTotal.PlaceholderText = ""
        Me.txtTotal.SelectedText = ""
        Me.txtTotal.ShadowDecoration.Parent = Me.txtTotal
        Me.txtTotal.Size = New System.Drawing.Size(169, 31)
        Me.txtTotal.TabIndex = 77
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPrevPay
        '
        Me.txtPrevPay.AutoRoundedCorners = True
        Me.txtPrevPay.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.txtPrevPay.BorderRadius = 14
        Me.txtPrevPay.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPrevPay.DefaultText = "0"
        Me.txtPrevPay.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPrevPay.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPrevPay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPrevPay.DisabledState.Parent = Me.txtPrevPay
        Me.txtPrevPay.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPrevPay.Enabled = False
        Me.txtPrevPay.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.txtPrevPay.FocusedState.Parent = Me.txtPrevPay
        Me.txtPrevPay.Font = New System.Drawing.Font("Source Sans Pro", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrevPay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.txtPrevPay.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPrevPay.HoverState.Parent = Me.txtPrevPay
        Me.txtPrevPay.Location = New System.Drawing.Point(509, 156)
        Me.txtPrevPay.Name = "txtPrevPay"
        Me.txtPrevPay.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPrevPay.PlaceholderText = ""
        Me.txtPrevPay.SelectedText = ""
        Me.txtPrevPay.SelectionStart = 1
        Me.txtPrevPay.ShadowDecoration.Parent = Me.txtPrevPay
        Me.txtPrevPay.Size = New System.Drawing.Size(169, 31)
        Me.txtPrevPay.TabIndex = 75
        Me.txtPrevPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.txtAdvPay.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.txtAdvPay.FocusedState.Parent = Me.txtAdvPay
        Me.txtAdvPay.Font = New System.Drawing.Font("Source Sans Pro", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdvPay.ForeColor = System.Drawing.Color.Black
        Me.txtAdvPay.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAdvPay.HoverState.Parent = Me.txtAdvPay
        Me.txtAdvPay.Location = New System.Drawing.Point(508, 193)
        Me.txtAdvPay.Name = "txtAdvPay"
        Me.txtAdvPay.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAdvPay.PlaceholderText = ""
        Me.txtAdvPay.SelectedText = ""
        Me.txtAdvPay.SelectionStart = 1
        Me.txtAdvPay.ShadowDecoration.Parent = Me.txtAdvPay
        Me.txtAdvPay.Size = New System.Drawing.Size(169, 31)
        Me.txtAdvPay.TabIndex = 75
        Me.txtAdvPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.txtSubtotal.Location = New System.Drawing.Point(508, 101)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSubtotal.PlaceholderText = ""
        Me.txtSubtotal.SelectedText = ""
        Me.txtSubtotal.ShadowDecoration.Parent = Me.txtSubtotal
        Me.txtSubtotal.Size = New System.Drawing.Size(169, 31)
        Me.txtSubtotal.TabIndex = 76
        Me.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 17)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Transaction ID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Room Num:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Guest Name:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Room Type:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(136, 38)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(178, 15)
        Me.Label13.TabIndex = 37
        Me.Label13.Text = "Select a Guest using the button"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(368, 62)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(109, 17)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Num of Occupants"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 235)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 17)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Check In Date:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(14, 187)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 17)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Room Rate:"
        '
        'cmdCheckIn
        '
        Me.cmdCheckIn.AutoRoundedCorners = True
        Me.cmdCheckIn.BorderRadius = 17
        Me.cmdCheckIn.BorderThickness = 1
        Me.cmdCheckIn.CheckedState.Parent = Me.cmdCheckIn
        Me.cmdCheckIn.CustomImages.Parent = Me.cmdCheckIn
        Me.cmdCheckIn.FillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.cmdCheckIn.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCheckIn.ForeColor = System.Drawing.Color.White
        Me.cmdCheckIn.HoverState.Parent = Me.cmdCheckIn
        Me.cmdCheckIn.Location = New System.Drawing.Point(585, 354)
        Me.cmdCheckIn.Name = "cmdCheckIn"
        Me.cmdCheckIn.ShadowDecoration.Parent = Me.cmdCheckIn
        Me.cmdCheckIn.Size = New System.Drawing.Size(128, 36)
        Me.cmdCheckIn.TabIndex = 33
        Me.cmdCheckIn.Text = "Extend"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 277)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 17)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Check Out Date:"
        '
        'dtpCheckOut
        '
        Me.dtpCheckOut.AutoRoundedCorners = True
        Me.dtpCheckOut.BorderRadius = 17
        Me.dtpCheckOut.BorderThickness = 1
        Me.dtpCheckOut.CheckedState.Parent = Me.dtpCheckOut
        Me.dtpCheckOut.FillColor = System.Drawing.Color.Transparent
        Me.dtpCheckOut.Font = New System.Drawing.Font("Source Sans Pro", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpCheckOut.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dtpCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpCheckOut.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.dtpCheckOut.HoverState.Parent = Me.dtpCheckOut
        Me.dtpCheckOut.Location = New System.Drawing.Point(123, 268)
        Me.dtpCheckOut.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpCheckOut.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpCheckOut.Name = "dtpCheckOut"
        Me.dtpCheckOut.ShadowDecoration.Parent = Me.dtpCheckOut
        Me.dtpCheckOut.Size = New System.Drawing.Size(200, 36)
        Me.dtpCheckOut.TabIndex = 31
        Me.dtpCheckOut.Value = New Date(2021, 8, 17, 14, 56, 1, 829)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(14, 323)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 17)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Num of Days:"
        '
        'dtpCheckIn
        '
        Me.dtpCheckIn.AutoRoundedCorners = True
        Me.dtpCheckIn.BorderColor = System.Drawing.Color.DarkGray
        Me.dtpCheckIn.BorderRadius = 17
        Me.dtpCheckIn.BorderThickness = 1
        Me.dtpCheckIn.CheckedState.Parent = Me.dtpCheckIn
        Me.dtpCheckIn.FillColor = System.Drawing.Color.Transparent
        Me.dtpCheckIn.Font = New System.Drawing.Font("Source Sans Pro", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpCheckIn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.dtpCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpCheckIn.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.dtpCheckIn.HoverState.Parent = Me.dtpCheckIn
        Me.dtpCheckIn.Location = New System.Drawing.Point(123, 226)
        Me.dtpCheckIn.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpCheckIn.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpCheckIn.Name = "dtpCheckIn"
        Me.dtpCheckIn.ShadowDecoration.Parent = Me.dtpCheckIn
        Me.dtpCheckIn.Size = New System.Drawing.Size(200, 36)
        Me.dtpCheckIn.TabIndex = 30
        Me.dtpCheckIn.Value = New Date(2021, 8, 17, 14, 56, 1, 829)
        '
        'txtGuest
        '
        Me.txtGuest.Animated = True
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
        Me.txtGuest.Location = New System.Drawing.Point(122, 57)
        Me.txtGuest.Name = "txtGuest"
        Me.txtGuest.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGuest.PlaceholderText = ""
        Me.txtGuest.ReadOnly = True
        Me.txtGuest.SelectedText = ""
        Me.txtGuest.ShadowDecoration.Parent = Me.txtGuest
        Me.txtGuest.Size = New System.Drawing.Size(170, 31)
        Me.txtGuest.TabIndex = 18
        Me.txtGuest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.txtNumGuest.Location = New System.Drawing.Point(498, 57)
        Me.txtNumGuest.Name = "txtNumGuest"
        Me.txtNumGuest.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNumGuest.PlaceholderText = ""
        Me.txtNumGuest.SelectedText = ""
        Me.txtNumGuest.SelectionStart = 1
        Me.txtNumGuest.ShadowDecoration.Parent = Me.txtNumGuest
        Me.txtNumGuest.Size = New System.Drawing.Size(179, 31)
        Me.txtNumGuest.TabIndex = 19
        Me.txtNumGuest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.txtRoomNum.Location = New System.Drawing.Point(123, 107)
        Me.txtRoomNum.Name = "txtRoomNum"
        Me.txtRoomNum.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRoomNum.PlaceholderText = ""
        Me.txtRoomNum.ReadOnly = True
        Me.txtRoomNum.SelectedText = ""
        Me.txtRoomNum.ShadowDecoration.Parent = Me.txtRoomNum
        Me.txtRoomNum.Size = New System.Drawing.Size(170, 31)
        Me.txtRoomNum.TabIndex = 20
        Me.txtRoomNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtRoomType
        '
        Me.txtRoomType.AutoRoundedCorners = True
        Me.txtRoomType.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
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
        Me.txtRoomType.ForeColor = System.Drawing.Color.Black
        Me.txtRoomType.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRoomType.HoverState.Parent = Me.txtRoomType
        Me.txtRoomType.Location = New System.Drawing.Point(123, 144)
        Me.txtRoomType.Name = "txtRoomType"
        Me.txtRoomType.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRoomType.PlaceholderText = ""
        Me.txtRoomType.ReadOnly = True
        Me.txtRoomType.SelectedText = ""
        Me.txtRoomType.ShadowDecoration.Parent = Me.txtRoomType
        Me.txtRoomType.Size = New System.Drawing.Size(125, 31)
        Me.txtRoomType.TabIndex = 25
        Me.txtRoomType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmdSelectGuest
        '
        Me.cmdSelectGuest.CheckedState.Parent = Me.cmdSelectGuest
        Me.cmdSelectGuest.CustomImages.Parent = Me.cmdSelectGuest
        Me.cmdSelectGuest.FillColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdSelectGuest.Font = New System.Drawing.Font("Montserrat", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSelectGuest.ForeColor = System.Drawing.Color.White
        Me.cmdSelectGuest.HoverState.Parent = Me.cmdSelectGuest
        Me.cmdSelectGuest.Location = New System.Drawing.Point(299, 56)
        Me.cmdSelectGuest.Name = "cmdSelectGuest"
        Me.cmdSelectGuest.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.cmdSelectGuest.ShadowDecoration.Parent = Me.cmdSelectGuest
        Me.cmdSelectGuest.Size = New System.Drawing.Size(30, 30)
        Me.cmdSelectGuest.TabIndex = 26
        Me.cmdSelectGuest.Text = "V"
        '
        'txtNumDays
        '
        Me.txtNumDays.AutoRoundedCorners = True
        Me.txtNumDays.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
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
        Me.txtNumDays.ForeColor = System.Drawing.Color.Black
        Me.txtNumDays.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNumDays.HoverState.Parent = Me.txtNumDays
        Me.txtNumDays.Location = New System.Drawing.Point(123, 317)
        Me.txtNumDays.Name = "txtNumDays"
        Me.txtNumDays.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNumDays.PlaceholderText = ""
        Me.txtNumDays.ReadOnly = True
        Me.txtNumDays.SelectedText = ""
        Me.txtNumDays.ShadowDecoration.Parent = Me.txtNumDays
        Me.txtNumDays.Size = New System.Drawing.Size(96, 31)
        Me.txtNumDays.TabIndex = 24
        Me.txtNumDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtRate
        '
        Me.txtRate.AutoRoundedCorners = True
        Me.txtRate.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
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
        Me.txtRate.ForeColor = System.Drawing.Color.Black
        Me.txtRate.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRate.HoverState.Parent = Me.txtRate
        Me.txtRate.Location = New System.Drawing.Point(123, 181)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRate.PlaceholderText = ""
        Me.txtRate.ReadOnly = True
        Me.txtRate.SelectedText = ""
        Me.txtRate.ShadowDecoration.Parent = Me.txtRate
        Me.txtRate.Size = New System.Drawing.Size(96, 31)
        Me.txtRate.TabIndex = 22
        Me.txtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Playfair Display Black", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 41)
        Me.Label1.TabIndex = 98
        Me.Label1.Text = "Extend Stay"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(196, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(56, 53)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 99
        Me.PictureBox1.TabStop = False
        '
        'lblPrevNum
        '
        Me.lblPrevNum.AutoSize = True
        Me.lblPrevNum.Location = New System.Drawing.Point(315, 35)
        Me.lblPrevNum.Name = "lblPrevNum"
        Me.lblPrevNum.Size = New System.Drawing.Size(98, 13)
        Me.lblPrevNum.TabIndex = 101
        Me.lblPrevNum.Text = "Previous Num days"
        Me.lblPrevNum.Visible = False
        '
        'lblOldSub
        '
        Me.lblOldSub.AutoSize = True
        Me.lblOldSub.Location = New System.Drawing.Point(449, 35)
        Me.lblOldSub.Name = "lblOldSub"
        Me.lblOldSub.Size = New System.Drawing.Size(42, 13)
        Me.lblOldSub.TabIndex = 101
        Me.lblOldSub.Text = "OldSub"
        Me.lblOldSub.Visible = False
        '
        'lblOldTotal
        '
        Me.lblOldTotal.AutoSize = True
        Me.lblOldTotal.Location = New System.Drawing.Point(524, 35)
        Me.lblOldTotal.Name = "lblOldTotal"
        Me.lblOldTotal.Size = New System.Drawing.Size(47, 13)
        Me.lblOldTotal.TabIndex = 101
        Me.lblOldTotal.Text = "OldTotal"
        Me.lblOldTotal.Visible = False
        '
        'lblOldAdvance
        '
        Me.lblOldAdvance.AutoSize = True
        Me.lblOldAdvance.Location = New System.Drawing.Point(610, 35)
        Me.lblOldAdvance.Name = "lblOldAdvance"
        Me.lblOldAdvance.Size = New System.Drawing.Size(66, 13)
        Me.lblOldAdvance.TabIndex = 101
        Me.lblOldAdvance.Text = "OldAdvance"
        Me.lblOldAdvance.Visible = False
        '
        'Extend
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(770, 477)
        Me.Controls.Add(Me.lblOldAdvance)
        Me.Controls.Add(Me.lblOldTotal)
        Me.Controls.Add(Me.lblOldSub)
        Me.Controls.Add(Me.lblPrevNum)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdMinimize)
        Me.Controls.Add(Me.cmdCLose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Extend"
        Me.Text = "Extend"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdMinimize As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents cmdCLose As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cmbTypes As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtTotal As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtAdvPay As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtSubtotal As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cmdCheckIn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label8 As Label
    Friend WithEvents dtpCheckOut As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents dtpCheckIn As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents txtGuest As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtNumGuest As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtRoomNum As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtRoomType As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cmdSelectGuest As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents txtNumDays As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtRate As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblPrevNum As Label
    Friend WithEvents lblOldSub As Label
    Friend WithEvents lblOldTotal As Label
    Friend WithEvents lblOldAdvance As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtPrevPay As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblGuestID As Label
    Friend WithEvents lblMinPay As Label
    Friend WithEvents lblReserveID As Label
End Class
