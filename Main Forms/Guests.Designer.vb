<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Guests
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Guests))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgGuests = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.cmdMinimize = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.cmdCLose = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.cmdAdd = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.cmdUpdate = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.cmdDelete = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.cmdClear = New Guna.UI2.WinForms.Guna2Button()
        Me.txtEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPhone = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAge = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAddress = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtGuest = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblCusID = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.dgGuests, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Playfair Display Black", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 41)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "Guest List"
        '
        'dgGuests
        '
        Me.dgGuests.AllowUserToAddRows = False
        Me.dgGuests.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgGuests.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgGuests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgGuests.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.dgGuests.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgGuests.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgGuests.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(61, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgGuests.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgGuests.ColumnHeadersHeight = 35
        Me.dgGuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Source Sans Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgGuests.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgGuests.EnableHeadersVisualStyles = False
        Me.dgGuests.GridColor = System.Drawing.Color.White
        Me.dgGuests.Location = New System.Drawing.Point(12, 65)
        Me.dgGuests.Name = "dgGuests"
        Me.dgGuests.ReadOnly = True
        Me.dgGuests.RowHeadersVisible = False
        Me.dgGuests.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgGuests.RowTemplate.Height = 40
        Me.dgGuests.RowTemplate.ReadOnly = True
        Me.dgGuests.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgGuests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgGuests.Size = New System.Drawing.Size(577, 430)
        Me.dgGuests.TabIndex = 71
        Me.dgGuests.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.dgGuests.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgGuests.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgGuests.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgGuests.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgGuests.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgGuests.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.dgGuests.ThemeStyle.GridColor = System.Drawing.Color.White
        Me.dgGuests.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.dgGuests.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgGuests.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgGuests.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgGuests.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgGuests.ThemeStyle.HeaderStyle.Height = 35
        Me.dgGuests.ThemeStyle.ReadOnly = True
        Me.dgGuests.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgGuests.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgGuests.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Source Sans Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgGuests.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgGuests.ThemeStyle.RowsStyle.Height = 40
        Me.dgGuests.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgGuests.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'cmdMinimize
        '
        Me.cmdMinimize.CheckedState.Parent = Me.cmdMinimize
        Me.cmdMinimize.CustomImages.Parent = Me.cmdMinimize
        Me.cmdMinimize.FillColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.cmdMinimize.Font = New System.Drawing.Font("Montserrat", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMinimize.ForeColor = System.Drawing.Color.White
        Me.cmdMinimize.HoverState.Parent = Me.cmdMinimize
        Me.cmdMinimize.Location = New System.Drawing.Point(839, 12)
        Me.cmdMinimize.Name = "cmdMinimize"
        Me.cmdMinimize.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.cmdMinimize.ShadowDecoration.Parent = Me.cmdMinimize
        Me.cmdMinimize.Size = New System.Drawing.Size(20, 20)
        Me.cmdMinimize.TabIndex = 72
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
        Me.cmdCLose.Location = New System.Drawing.Point(865, 12)
        Me.cmdCLose.Name = "cmdCLose"
        Me.cmdCLose.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.cmdCLose.ShadowDecoration.Parent = Me.cmdCLose
        Me.cmdCLose.Size = New System.Drawing.Size(20, 20)
        Me.cmdCLose.TabIndex = 73
        Me.cmdCLose.Text = "X"
        '
        'cmdAdd
        '
        Me.cmdAdd.Animated = True
        Me.cmdAdd.AutoRoundedCorners = True
        Me.cmdAdd.BorderRadius = 14
        Me.cmdAdd.CheckedState.Parent = Me.cmdAdd
        Me.cmdAdd.CustomImages.Parent = Me.cmdAdd
        Me.cmdAdd.FillColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.cmdAdd.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.cmdAdd.Font = New System.Drawing.Font("Montserrat", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAdd.ForeColor = System.Drawing.Color.White
        Me.cmdAdd.HoverState.Parent = Me.cmdAdd
        Me.cmdAdd.Location = New System.Drawing.Point(661, 312)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.ShadowDecoration.Parent = Me.cmdAdd
        Me.cmdAdd.Size = New System.Drawing.Size(177, 31)
        Me.cmdAdd.TabIndex = 74
        Me.cmdAdd.Text = "Add Customer"
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Animated = True
        Me.cmdUpdate.AutoRoundedCorners = True
        Me.cmdUpdate.BorderRadius = 14
        Me.cmdUpdate.CheckedState.Parent = Me.cmdUpdate
        Me.cmdUpdate.CustomImages.Parent = Me.cmdUpdate
        Me.cmdUpdate.Enabled = False
        Me.cmdUpdate.FillColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.cmdUpdate.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.cmdUpdate.Font = New System.Drawing.Font("Montserrat", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUpdate.ForeColor = System.Drawing.Color.White
        Me.cmdUpdate.HoverState.Parent = Me.cmdUpdate
        Me.cmdUpdate.Location = New System.Drawing.Point(661, 349)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.ShadowDecoration.Parent = Me.cmdUpdate
        Me.cmdUpdate.Size = New System.Drawing.Size(177, 31)
        Me.cmdUpdate.TabIndex = 74
        Me.cmdUpdate.Text = "Update Customer Info"
        '
        'cmdDelete
        '
        Me.cmdDelete.Animated = True
        Me.cmdDelete.AutoRoundedCorners = True
        Me.cmdDelete.BorderRadius = 14
        Me.cmdDelete.CheckedState.Parent = Me.cmdDelete
        Me.cmdDelete.CustomImages.Parent = Me.cmdDelete
        Me.cmdDelete.Enabled = False
        Me.cmdDelete.FillColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.cmdDelete.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.cmdDelete.Font = New System.Drawing.Font("Montserrat", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDelete.ForeColor = System.Drawing.Color.White
        Me.cmdDelete.HoverState.Parent = Me.cmdDelete
        Me.cmdDelete.Location = New System.Drawing.Point(661, 386)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.ShadowDecoration.Parent = Me.cmdDelete
        Me.cmdDelete.Size = New System.Drawing.Size(177, 31)
        Me.cmdDelete.TabIndex = 74
        Me.cmdDelete.Text = "Delete Customer"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.cmdClear)
        Me.Guna2Panel1.Controls.Add(Me.txtEmail)
        Me.Guna2Panel1.Controls.Add(Me.Label6)
        Me.Guna2Panel1.Controls.Add(Me.txtPhone)
        Me.Guna2Panel1.Controls.Add(Me.Label5)
        Me.Guna2Panel1.Controls.Add(Me.txtAge)
        Me.Guna2Panel1.Controls.Add(Me.Label3)
        Me.Guna2Panel1.Controls.Add(Me.txtAddress)
        Me.Guna2Panel1.Controls.Add(Me.Label2)
        Me.Guna2Panel1.Controls.Add(Me.txtGuest)
        Me.Guna2Panel1.Controls.Add(Me.Label4)
        Me.Guna2Panel1.Location = New System.Drawing.Point(599, 65)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(296, 241)
        Me.Guna2Panel1.TabIndex = 75
        '
        'cmdClear
        '
        Me.cmdClear.AutoRoundedCorners = True
        Me.cmdClear.BorderRadius = 12
        Me.cmdClear.CheckedState.Parent = Me.cmdClear
        Me.cmdClear.CustomImages.Parent = Me.cmdClear
        Me.cmdClear.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdClear.ForeColor = System.Drawing.Color.White
        Me.cmdClear.HoverState.Parent = Me.cmdClear
        Me.cmdClear.Location = New System.Drawing.Point(162, 197)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.ShadowDecoration.Parent = Me.cmdClear
        Me.cmdClear.Size = New System.Drawing.Size(124, 26)
        Me.cmdClear.TabIndex = 52
        Me.cmdClear.Text = "Clear Text"
        '
        'txtEmail
        '
        Me.txtEmail.AutoRoundedCorners = True
        Me.txtEmail.BorderColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.txtEmail.BorderRadius = 14
        Me.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmail.DefaultText = ""
        Me.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmail.DisabledState.Parent = Me.txtEmail
        Me.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.txtEmail.FocusedState.Parent = Me.txtEmail
        Me.txtEmail.Font = New System.Drawing.Font("Source Sans Pro", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.ForeColor = System.Drawing.Color.Black
        Me.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmail.HoverState.Parent = Me.txtEmail
        Me.txtEmail.Location = New System.Drawing.Point(116, 157)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmail.PlaceholderText = ""
        Me.txtEmail.SelectedText = ""
        Me.txtEmail.ShadowDecoration.Parent = Me.txtEmail
        Me.txtEmail.Size = New System.Drawing.Size(170, 31)
        Me.txtEmail.TabIndex = 51
        Me.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 162)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 17)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "Email"
        '
        'txtPhone
        '
        Me.txtPhone.AutoRoundedCorners = True
        Me.txtPhone.BorderColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.txtPhone.BorderRadius = 14
        Me.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPhone.DefaultText = ""
        Me.txtPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPhone.DisabledState.Parent = Me.txtPhone
        Me.txtPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.txtPhone.FocusedState.Parent = Me.txtPhone
        Me.txtPhone.Font = New System.Drawing.Font("Source Sans Pro", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.ForeColor = System.Drawing.Color.Black
        Me.txtPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPhone.HoverState.Parent = Me.txtPhone
        Me.txtPhone.Location = New System.Drawing.Point(116, 120)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPhone.PlaceholderText = ""
        Me.txtPhone.SelectedText = ""
        Me.txtPhone.ShadowDecoration.Parent = Me.txtPhone
        Me.txtPhone.Size = New System.Drawing.Size(170, 31)
        Me.txtPhone.TabIndex = 51
        Me.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 17)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "PhoneNum:"
        '
        'txtAge
        '
        Me.txtAge.AutoRoundedCorners = True
        Me.txtAge.BorderColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.txtAge.BorderRadius = 14
        Me.txtAge.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAge.DefaultText = ""
        Me.txtAge.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtAge.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtAge.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAge.DisabledState.Parent = Me.txtAge
        Me.txtAge.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAge.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.txtAge.FocusedState.Parent = Me.txtAge
        Me.txtAge.Font = New System.Drawing.Font("Source Sans Pro", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.ForeColor = System.Drawing.Color.Black
        Me.txtAge.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAge.HoverState.Parent = Me.txtAge
        Me.txtAge.Location = New System.Drawing.Point(116, 83)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAge.PlaceholderText = ""
        Me.txtAge.SelectedText = ""
        Me.txtAge.ShadowDecoration.Parent = Me.txtAge
        Me.txtAge.Size = New System.Drawing.Size(170, 31)
        Me.txtAge.TabIndex = 51
        Me.txtAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 17)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Age:"
        '
        'txtAddress
        '
        Me.txtAddress.AutoRoundedCorners = True
        Me.txtAddress.BorderColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.txtAddress.BorderRadius = 14
        Me.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAddress.DefaultText = ""
        Me.txtAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAddress.DisabledState.Parent = Me.txtAddress
        Me.txtAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.txtAddress.FocusedState.Parent = Me.txtAddress
        Me.txtAddress.Font = New System.Drawing.Font("Source Sans Pro", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.ForeColor = System.Drawing.Color.Black
        Me.txtAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAddress.HoverState.Parent = Me.txtAddress
        Me.txtAddress.Location = New System.Drawing.Point(116, 46)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAddress.PlaceholderText = ""
        Me.txtAddress.SelectedText = ""
        Me.txtAddress.ShadowDecoration.Parent = Me.txtAddress
        Me.txtAddress.Size = New System.Drawing.Size(170, 31)
        Me.txtAddress.TabIndex = 51
        Me.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 17)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Address:"
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
        Me.txtGuest.Location = New System.Drawing.Point(116, 9)
        Me.txtGuest.Name = "txtGuest"
        Me.txtGuest.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGuest.PlaceholderText = ""
        Me.txtGuest.SelectedText = ""
        Me.txtGuest.ShadowDecoration.Parent = Me.txtGuest
        Me.txtGuest.Size = New System.Drawing.Size(170, 31)
        Me.txtGuest.TabIndex = 51
        Me.txtGuest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 17)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Guest Name:"
        '
        'lblCusID
        '
        Me.lblCusID.AutoSize = True
        Me.lblCusID.Location = New System.Drawing.Point(600, 394)
        Me.lblCusID.Name = "lblCusID"
        Me.lblCusID.Size = New System.Drawing.Size(35, 13)
        Me.lblCusID.TabIndex = 76
        Me.lblCusID.Text = "cusID"
        Me.lblCusID.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(173, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(56, 53)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 69
        Me.PictureBox1.TabStop = False
        '
        'Guna2Button1
        '
        Me.Guna2Button1.AutoRoundedCorners = True
        Me.Guna2Button1.BorderRadius = 19
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Location = New System.Drawing.Point(611, 455)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(124, 40)
        Me.Guna2Button1.TabIndex = 52
        Me.Guna2Button1.Text = "Guest Reservation Report"
        '
        'Guna2Button2
        '
        Me.Guna2Button2.AutoRoundedCorners = True
        Me.Guna2Button2.BorderRadius = 19
        Me.Guna2Button2.CheckedState.Parent = Me.Guna2Button2
        Me.Guna2Button2.CustomImages.Parent = Me.Guna2Button2
        Me.Guna2Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.HoverState.Parent = Me.Guna2Button2
        Me.Guna2Button2.Location = New System.Drawing.Point(761, 455)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.ShadowDecoration.Parent = Me.Guna2Button2
        Me.Guna2Button2.Size = New System.Drawing.Size(124, 40)
        Me.Guna2Button2.TabIndex = 52
        Me.Guna2Button2.Text = "Guest Info Report"
        '
        'Guests
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(907, 511)
        Me.Controls.Add(Me.Guna2Button2)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.lblCusID)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdUpdate)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.cmdMinimize)
        Me.Controls.Add(Me.cmdCLose)
        Me.Controls.Add(Me.dgGuests)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Guests"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Guests"
        CType(Me.dgGuests, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgGuests As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents cmdMinimize As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents cmdCLose As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents cmdAdd As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents cmdUpdate As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents cmdDelete As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents txtPhone As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtAge As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtAddress As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtGuest As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblCusID As Label
    Friend WithEvents txtEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmdClear As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
End Class
