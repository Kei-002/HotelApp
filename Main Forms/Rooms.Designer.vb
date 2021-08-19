<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Rooms
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Rooms))
        Me.dgRooms = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmdMinimize = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.cmdCLose = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.txtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cmdNew = New Guna.UI2.WinForms.Guna2Button()
        Me.cmdDelete = New Guna.UI2.WinForms.Guna2Button()
        Me.cmdUpdate = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rbReserved = New Guna.UI2.WinForms.Guna2ImageRadioButton()
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
        CType(Me.dgRooms, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgRooms
        '
        Me.dgRooms.AllowUserToAddRows = False
        Me.dgRooms.AllowUserToDeleteRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        Me.dgRooms.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dgRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgRooms.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.dgRooms.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgRooms.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgRooms.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(61, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgRooms.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgRooms.ColumnHeadersHeight = 20
        Me.dgRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Source Sans Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgRooms.DefaultCellStyle = DataGridViewCellStyle9
        Me.dgRooms.EnableHeadersVisualStyles = False
        Me.dgRooms.GridColor = System.Drawing.Color.White
        Me.dgRooms.Location = New System.Drawing.Point(9, 122)
        Me.dgRooms.Name = "dgRooms"
        Me.dgRooms.ReadOnly = True
        Me.dgRooms.RowHeadersVisible = False
        Me.dgRooms.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgRooms.RowTemplate.Height = 25
        Me.dgRooms.RowTemplate.ReadOnly = True
        Me.dgRooms.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgRooms.Size = New System.Drawing.Size(768, 488)
        Me.dgRooms.TabIndex = 72
        Me.dgRooms.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.dgRooms.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgRooms.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgRooms.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgRooms.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgRooms.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgRooms.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.dgRooms.ThemeStyle.GridColor = System.Drawing.Color.White
        Me.dgRooms.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.dgRooms.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgRooms.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgRooms.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgRooms.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgRooms.ThemeStyle.HeaderStyle.Height = 20
        Me.dgRooms.ThemeStyle.ReadOnly = True
        Me.dgRooms.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgRooms.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgRooms.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Source Sans Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgRooms.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgRooms.ThemeStyle.RowsStyle.Height = 25
        Me.dgRooms.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgRooms.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Playfair Display Black", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 41)
        Me.Label7.TabIndex = 84
        Me.Label7.Text = "Rooms"
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
        Me.cmdMinimize.Location = New System.Drawing.Point(938, 9)
        Me.cmdMinimize.Name = "cmdMinimize"
        Me.cmdMinimize.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.cmdMinimize.ShadowDecoration.Parent = Me.cmdMinimize
        Me.cmdMinimize.Size = New System.Drawing.Size(20, 20)
        Me.cmdMinimize.TabIndex = 85
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
        Me.cmdCLose.Location = New System.Drawing.Point(964, 9)
        Me.cmdCLose.Name = "cmdCLose"
        Me.cmdCLose.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.cmdCLose.ShadowDecoration.Parent = Me.cmdCLose
        Me.cmdCLose.Size = New System.Drawing.Size(20, 20)
        Me.cmdCLose.TabIndex = 86
        Me.cmdCLose.Text = "X"
        '
        'txtSearch
        '
        Me.txtSearch.AutoRoundedCorners = True
        Me.txtSearch.BorderRadius = 11
        Me.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearch.DefaultText = ""
        Me.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearch.DisabledState.Parent = Me.txtSearch
        Me.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearch.FocusedState.Parent = Me.txtSearch
        Me.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearch.HoverState.Parent = Me.txtSearch
        Me.txtSearch.IconLeft = CType(resources.GetObject("txtSearch.IconLeft"), System.Drawing.Image)
        Me.txtSearch.IconLeftOffset = New System.Drawing.Point(5, 1)
        Me.txtSearch.IconLeftSize = New System.Drawing.Size(10, 10)
        Me.txtSearch.Location = New System.Drawing.Point(19, 91)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.PlaceholderText = "Search"
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.ShadowDecoration.Parent = Me.txtSearch
        Me.txtSearch.Size = New System.Drawing.Size(168, 25)
        Me.txtSearch.TabIndex = 87
        Me.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmdNew
        '
        Me.cmdNew.Animated = True
        Me.cmdNew.AutoRoundedCorners = True
        Me.cmdNew.BorderRadius = 11
        Me.cmdNew.CheckedState.Parent = Me.cmdNew
        Me.cmdNew.CustomImages.Parent = Me.cmdNew
        Me.cmdNew.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.cmdNew.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdNew.ForeColor = System.Drawing.Color.White
        Me.cmdNew.HoverState.Parent = Me.cmdNew
        Me.cmdNew.Location = New System.Drawing.Point(669, 91)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.ShadowDecoration.Parent = Me.cmdNew
        Me.cmdNew.Size = New System.Drawing.Size(108, 25)
        Me.cmdNew.TabIndex = 88
        Me.cmdNew.Text = "New Room"
        '
        'cmdDelete
        '
        Me.cmdDelete.Animated = True
        Me.cmdDelete.AutoRoundedCorners = True
        Me.cmdDelete.BorderRadius = 18
        Me.cmdDelete.CheckedState.Parent = Me.cmdDelete
        Me.cmdDelete.CustomImages.Parent = Me.cmdDelete
        Me.cmdDelete.Enabled = False
        Me.cmdDelete.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.cmdDelete.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdDelete.ForeColor = System.Drawing.Color.White
        Me.cmdDelete.HoverState.Parent = Me.cmdDelete
        Me.cmdDelete.Location = New System.Drawing.Point(39, 437)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.ShadowDecoration.Parent = Me.cmdDelete
        Me.cmdDelete.Size = New System.Drawing.Size(131, 39)
        Me.cmdDelete.TabIndex = 88
        Me.cmdDelete.Text = "Delete"
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Animated = True
        Me.cmdUpdate.AutoRoundedCorners = True
        Me.cmdUpdate.BorderRadius = 18
        Me.cmdUpdate.CheckedState.Parent = Me.cmdUpdate
        Me.cmdUpdate.CustomImages.Parent = Me.cmdUpdate
        Me.cmdUpdate.Enabled = False
        Me.cmdUpdate.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.cmdUpdate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdUpdate.ForeColor = System.Drawing.Color.White
        Me.cmdUpdate.HoverState.Parent = Me.cmdUpdate
        Me.cmdUpdate.Location = New System.Drawing.Point(39, 392)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.ShadowDecoration.Parent = Me.cmdUpdate
        Me.cmdUpdate.Size = New System.Drawing.Size(131, 39)
        Me.cmdUpdate.TabIndex = 88
        Me.cmdUpdate.Text = "Update"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rbReserved)
        Me.Panel1.Controls.Add(Me.rbOccu)
        Me.Panel1.Controls.Add(Me.rbAvail)
        Me.Panel1.Controls.Add(Me.cmbTypes)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtRate)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtNumOccu)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtOccu)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtRoomID)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.cmdUpdate)
        Me.Panel1.Controls.Add(Me.cmdDelete)
        Me.Panel1.Location = New System.Drawing.Point(783, 122)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(202, 488)
        Me.Panel1.TabIndex = 89
        '
        'rbReserved
        '
        Me.rbReserved.CheckedState.Image = CType(resources.GetObject("Guna2ImageRadioButton1.CheckedState.Image"), System.Drawing.Image)
        Me.rbReserved.CheckedState.ImageSize = New System.Drawing.Size(42, 42)
        Me.rbReserved.CheckedState.Parent = Me.rbReserved
        Me.rbReserved.HoverState.Image = CType(resources.GetObject("Guna2ImageRadioButton1.HoverState.Image"), System.Drawing.Image)
        Me.rbReserved.HoverState.ImageSize = New System.Drawing.Size(40, 40)
        Me.rbReserved.HoverState.Parent = Me.rbReserved
        Me.rbReserved.Image = CType(resources.GetObject("rbReserved.Image"), System.Drawing.Image)
        Me.rbReserved.ImageSize = New System.Drawing.Size(40, 40)
        Me.rbReserved.Location = New System.Drawing.Point(133, 317)
        Me.rbReserved.Name = "rbReserved"
        Me.rbReserved.PressedState.Parent = Me.rbReserved
        Me.rbReserved.Size = New System.Drawing.Size(54, 50)
        Me.rbReserved.TabIndex = 100
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
        Me.rbOccu.Location = New System.Drawing.Point(74, 317)
        Me.rbOccu.Name = "rbOccu"
        Me.rbOccu.PressedState.Parent = Me.rbOccu
        Me.rbOccu.Size = New System.Drawing.Size(54, 50)
        Me.rbOccu.TabIndex = 100
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
        Me.rbAvail.Location = New System.Drawing.Point(19, 317)
        Me.rbAvail.Name = "rbAvail"
        Me.rbAvail.PressedState.Parent = Me.rbAvail
        Me.rbAvail.Size = New System.Drawing.Size(54, 50)
        Me.rbAvail.TabIndex = 101
        '
        'cmbTypes
        '
        Me.cmbTypes.AutoRoundedCorners = True
        Me.cmbTypes.BackColor = System.Drawing.Color.Transparent
        Me.cmbTypes.BorderColor = System.Drawing.Color.Black
        Me.cmbTypes.BorderRadius = 14
        Me.cmbTypes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTypes.Enabled = False
        Me.cmbTypes.FocusedColor = System.Drawing.Color.Empty
        Me.cmbTypes.FocusedState.Parent = Me.cmbTypes
        Me.cmbTypes.Font = New System.Drawing.Font("Montserrat", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTypes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbTypes.FormattingEnabled = True
        Me.cmbTypes.HoverState.Parent = Me.cmbTypes
        Me.cmbTypes.ItemHeight = 24
        Me.cmbTypes.ItemsAppearance.Parent = Me.cmbTypes
        Me.cmbTypes.Location = New System.Drawing.Point(19, 90)
        Me.cmbTypes.Name = "cmbTypes"
        Me.cmbTypes.ShadowDecoration.Parent = Me.cmbTypes
        Me.cmbTypes.Size = New System.Drawing.Size(170, 30)
        Me.cmbTypes.TabIndex = 99
        Me.cmbTypes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(83, 291)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 17)
        Me.Label1.TabIndex = 89
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
        Me.txtRate.Location = New System.Drawing.Point(19, 142)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRate.PlaceholderText = "Select Guest"
        Me.txtRate.SelectedText = ""
        Me.txtRate.ShadowDecoration.Parent = Me.txtRate
        Me.txtRate.Size = New System.Drawing.Size(170, 31)
        Me.txtRate.TabIndex = 95
        Me.txtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(73, 122)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 17)
        Me.Label6.TabIndex = 90
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
        Me.txtNumOccu.Enabled = False
        Me.txtNumOccu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.txtNumOccu.FocusedState.Parent = Me.txtNumOccu
        Me.txtNumOccu.Font = New System.Drawing.Font("Source Sans Pro", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumOccu.ForeColor = System.Drawing.Color.Black
        Me.txtNumOccu.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNumOccu.HoverState.Parent = Me.txtNumOccu
        Me.txtNumOccu.Location = New System.Drawing.Point(19, 202)
        Me.txtNumOccu.Name = "txtNumOccu"
        Me.txtNumOccu.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNumOccu.PlaceholderText = "Select Guest"
        Me.txtNumOccu.SelectedText = ""
        Me.txtNumOccu.ShadowDecoration.Parent = Me.txtNumOccu
        Me.txtNumOccu.Size = New System.Drawing.Size(170, 31)
        Me.txtNumOccu.TabIndex = 96
        Me.txtNumOccu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(48, 182)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 17)
        Me.Label5.TabIndex = 91
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
        Me.txtOccu.Location = New System.Drawing.Point(19, 257)
        Me.txtOccu.Name = "txtOccu"
        Me.txtOccu.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtOccu.PlaceholderText = "Select Guest"
        Me.txtOccu.SelectedText = ""
        Me.txtOccu.ShadowDecoration.Parent = Me.txtOccu
        Me.txtOccu.Size = New System.Drawing.Size(170, 31)
        Me.txtOccu.TabIndex = 97
        Me.txtOccu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(76, 237)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 17)
        Me.Label3.TabIndex = 92
        Me.Label3.Text = "Capacity:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(69, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 17)
        Me.Label2.TabIndex = 93
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
        Me.txtRoomID.Enabled = False
        Me.txtRoomID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.txtRoomID.FocusedState.Parent = Me.txtRoomID
        Me.txtRoomID.Font = New System.Drawing.Font("Source Sans Pro", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRoomID.ForeColor = System.Drawing.Color.Black
        Me.txtRoomID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRoomID.HoverState.Parent = Me.txtRoomID
        Me.txtRoomID.Location = New System.Drawing.Point(19, 32)
        Me.txtRoomID.Name = "txtRoomID"
        Me.txtRoomID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRoomID.PlaceholderText = "Leave Blank if Adding"
        Me.txtRoomID.SelectedText = ""
        Me.txtRoomID.ShadowDecoration.Parent = Me.txtRoomID
        Me.txtRoomID.Size = New System.Drawing.Size(170, 31)
        Me.txtRoomID.TabIndex = 98
        Me.txtRoomID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Source Sans Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(65, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 17)
        Me.Label4.TabIndex = 94
        Me.Label4.Text = "Room Num:"
        '
        'Rooms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(996, 636)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cmdNew)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.cmdMinimize)
        Me.Controls.Add(Me.cmdCLose)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dgRooms)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Rooms"
        Me.Text = "Rooms"
        CType(Me.dgRooms, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgRooms As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents cmdMinimize As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents cmdCLose As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents txtSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cmdNew As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cmdDelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cmdUpdate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents rbOccu As Guna.UI2.WinForms.Guna2ImageRadioButton
    Friend WithEvents rbAvail As Guna.UI2.WinForms.Guna2ImageRadioButton
    Friend WithEvents cmbTypes As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtRate As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNumOccu As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtOccu As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtRoomID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents rbReserved As Guna.UI2.WinForms.Guna2ImageRadioButton
End Class
