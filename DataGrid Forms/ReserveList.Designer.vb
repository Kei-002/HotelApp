<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReserveList
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReserveList))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmdCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.dgList = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.cmdMinimize = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.cmdCLose = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.txtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cmdCheckIn = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.dgList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(307, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(161, 15)
        Me.Label2.TabIndex = 100
        Me.Label2.Text = "Click to select a reservavtion"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Playfair Display", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(307, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(173, 29)
        Me.Label7.TabIndex = 99
        Me.Label7.Text = "Reservation List"
        '
        'cmdCancel
        '
        Me.cmdCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCancel.Animated = True
        Me.cmdCancel.AutoRoundedCorners = True
        Me.cmdCancel.BorderRadius = 15
        Me.cmdCancel.CheckedState.Parent = Me.cmdCancel
        Me.cmdCancel.CustomImages.Parent = Me.cmdCancel
        Me.cmdCancel.FillColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.cmdCancel.Font = New System.Drawing.Font("Montserrat", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.ForeColor = System.Drawing.Color.White
        Me.cmdCancel.HoverState.Parent = Me.cmdCancel
        Me.cmdCancel.Location = New System.Drawing.Point(571, 392)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.ShadowDecoration.Parent = Me.cmdCancel
        Me.cmdCancel.Size = New System.Drawing.Size(169, 32)
        Me.cmdCancel.TabIndex = 97
        Me.cmdCancel.Text = "Cancel Reservation"
        '
        'dgList
        '
        Me.dgList.AllowUserToAddRows = False
        Me.dgList.AllowUserToDeleteRows = False
        Me.dgList.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.dgList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgList.BackgroundColor = System.Drawing.Color.White
        Me.dgList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgList.ColumnHeadersHeight = 4
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgList.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgList.EnableHeadersVisualStyles = False
        Me.dgList.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgList.Location = New System.Drawing.Point(12, 102)
        Me.dgList.Name = "dgList"
        Me.dgList.ReadOnly = True
        Me.dgList.RowHeadersVisible = False
        Me.dgList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgList.Size = New System.Drawing.Size(729, 284)
        Me.dgList.TabIndex = 96
        Me.dgList.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.dgList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgList.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgList.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgList.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgList.ThemeStyle.HeaderStyle.Height = 4
        Me.dgList.ThemeStyle.ReadOnly = True
        Me.dgList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgList.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgList.ThemeStyle.RowsStyle.Height = 22
        Me.dgList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
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
        Me.cmdMinimize.Location = New System.Drawing.Point(696, 7)
        Me.cmdMinimize.Name = "cmdMinimize"
        Me.cmdMinimize.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.cmdMinimize.ShadowDecoration.Parent = Me.cmdMinimize
        Me.cmdMinimize.Size = New System.Drawing.Size(20, 20)
        Me.cmdMinimize.TabIndex = 94
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
        Me.cmdCLose.Location = New System.Drawing.Point(722, 7)
        Me.cmdCLose.Name = "cmdCLose"
        Me.cmdCLose.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.cmdCLose.ShadowDecoration.Parent = Me.cmdCLose
        Me.cmdCLose.Size = New System.Drawing.Size(20, 20)
        Me.cmdCLose.TabIndex = 95
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
        Me.txtSearch.Location = New System.Drawing.Point(12, 71)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.PlaceholderText = "Search Guest"
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.ShadowDecoration.Parent = Me.txtSearch
        Me.txtSearch.Size = New System.Drawing.Size(168, 25)
        Me.txtSearch.TabIndex = 98
        Me.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmdCheckIn
        '
        Me.cmdCheckIn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCheckIn.Animated = True
        Me.cmdCheckIn.AutoRoundedCorners = True
        Me.cmdCheckIn.BorderRadius = 15
        Me.cmdCheckIn.CheckedState.Parent = Me.cmdCheckIn
        Me.cmdCheckIn.CustomImages.Parent = Me.cmdCheckIn
        Me.cmdCheckIn.FillColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.cmdCheckIn.Font = New System.Drawing.Font("Montserrat", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCheckIn.ForeColor = System.Drawing.Color.White
        Me.cmdCheckIn.HoverState.Parent = Me.cmdCheckIn
        Me.cmdCheckIn.Location = New System.Drawing.Point(396, 392)
        Me.cmdCheckIn.Name = "cmdCheckIn"
        Me.cmdCheckIn.ShadowDecoration.Parent = Me.cmdCheckIn
        Me.cmdCheckIn.Size = New System.Drawing.Size(169, 32)
        Me.cmdCheckIn.TabIndex = 97
        Me.cmdCheckIn.Text = "Check In"
        '
        'ReserveList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(752, 436)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.cmdCheckIn)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.dgList)
        Me.Controls.Add(Me.cmdMinimize)
        Me.Controls.Add(Me.cmdCLose)
        Me.Name = "ReserveList"
        Me.Text = "ReserveList"
        CType(Me.dgList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cmdCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dgList As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents cmdMinimize As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents cmdCLose As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents cmdCheckIn As Guna.UI2.WinForms.Guna2Button
End Class
