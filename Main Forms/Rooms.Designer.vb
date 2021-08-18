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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Rooms))
        Me.dgGuests = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmdMinimize = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.cmdCLose = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.txtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cmdNew = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.dgGuests, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgGuests.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgGuests.ColumnHeadersHeight = 20
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
        Me.dgGuests.Location = New System.Drawing.Point(9, 122)
        Me.dgGuests.Name = "dgGuests"
        Me.dgGuests.ReadOnly = True
        Me.dgGuests.RowHeadersVisible = False
        Me.dgGuests.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgGuests.RowTemplate.Height = 25
        Me.dgGuests.RowTemplate.ReadOnly = True
        Me.dgGuests.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgGuests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgGuests.Size = New System.Drawing.Size(807, 430)
        Me.dgGuests.TabIndex = 72
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
        Me.dgGuests.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgGuests.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgGuests.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgGuests.ThemeStyle.HeaderStyle.Height = 20
        Me.dgGuests.ThemeStyle.ReadOnly = True
        Me.dgGuests.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgGuests.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgGuests.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Source Sans Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgGuests.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgGuests.ThemeStyle.RowsStyle.Height = 25
        Me.dgGuests.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgGuests.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
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
        Me.cmdMinimize.Location = New System.Drawing.Point(770, 9)
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
        Me.cmdCLose.Location = New System.Drawing.Point(796, 9)
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
        Me.cmdNew.Location = New System.Drawing.Point(636, 91)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.ShadowDecoration.Parent = Me.cmdNew
        Me.cmdNew.Size = New System.Drawing.Size(180, 25)
        Me.cmdNew.TabIndex = 88
        Me.cmdNew.Text = "New Room"
        '
        'Rooms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(828, 563)
        Me.Controls.Add(Me.cmdNew)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.cmdMinimize)
        Me.Controls.Add(Me.cmdCLose)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dgGuests)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Rooms"
        Me.Text = "Rooms"
        CType(Me.dgGuests, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgGuests As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents cmdMinimize As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents cmdCLose As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents txtSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cmdNew As Guna.UI2.WinForms.Guna2Button
End Class
