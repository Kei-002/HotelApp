<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CustomerFeedback
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
        Me.ctRating = New Guna.UI2.WinForms.Guna2RatingStar()
        Me.txtFeedback = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtGuestName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdSubmit = New Guna.UI2.WinForms.Guna2Button()
        Me.lblGuestID = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ctRating
        '
        Me.ctRating.Location = New System.Drawing.Point(74, 325)
        Me.ctRating.Name = "ctRating"
        Me.ctRating.Size = New System.Drawing.Size(186, 44)
        Me.ctRating.TabIndex = 0
        '
        'txtFeedback
        '
        Me.txtFeedback.Location = New System.Drawing.Point(12, 152)
        Me.txtFeedback.Multiline = True
        Me.txtFeedback.Name = "txtFeedback"
        Me.txtFeedback.Size = New System.Drawing.Size(307, 134)
        Me.txtFeedback.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Playfair Display", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(82, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(165, 29)
        Me.Label7.TabIndex = 103
        Me.Label7.Text = "Guest Feedback"
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
        Me.txtGuestName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.txtGuestName.FocusedState.Parent = Me.txtGuestName
        Me.txtGuestName.Font = New System.Drawing.Font("Source Sans Pro", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuestName.ForeColor = System.Drawing.Color.Black
        Me.txtGuestName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtGuestName.HoverState.Parent = Me.txtGuestName
        Me.txtGuestName.Location = New System.Drawing.Point(134, 84)
        Me.txtGuestName.Name = "txtGuestName"
        Me.txtGuestName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGuestName.PlaceholderText = "Leave Blank if Adding"
        Me.txtGuestName.SelectedText = ""
        Me.txtGuestName.ShadowDecoration.Parent = Me.txtGuestName
        Me.txtGuestName.Size = New System.Drawing.Size(170, 31)
        Me.txtGuestName.TabIndex = 105
        Me.txtGuestName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(27, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 15)
        Me.Label4.TabIndex = 104
        Me.Label4.Text = "Guest Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(126, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 18)
        Me.Label1.TabIndex = 104
        Me.Label1.Text = "Feedback:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(134, 303)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 18)
        Me.Label2.TabIndex = 104
        Me.Label2.Text = "Rating:"
        '
        'cmdSubmit
        '
        Me.cmdSubmit.Animated = True
        Me.cmdSubmit.AutoRoundedCorners = True
        Me.cmdSubmit.BorderRadius = 21
        Me.cmdSubmit.CheckedState.Parent = Me.cmdSubmit
        Me.cmdSubmit.CustomImages.Parent = Me.cmdSubmit
        Me.cmdSubmit.FillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.cmdSubmit.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmdSubmit.ForeColor = System.Drawing.Color.White
        Me.cmdSubmit.HoverState.Parent = Me.cmdSubmit
        Me.cmdSubmit.Location = New System.Drawing.Point(74, 397)
        Me.cmdSubmit.Name = "cmdSubmit"
        Me.cmdSubmit.ShadowDecoration.Parent = Me.cmdSubmit
        Me.cmdSubmit.Size = New System.Drawing.Size(180, 45)
        Me.cmdSubmit.TabIndex = 106
        Me.cmdSubmit.Text = "Submit feedback"
        '
        'lblGuestID
        '
        Me.lblGuestID.AutoSize = True
        Me.lblGuestID.Location = New System.Drawing.Point(268, 41)
        Me.lblGuestID.Name = "lblGuestID"
        Me.lblGuestID.Size = New System.Drawing.Size(39, 13)
        Me.lblGuestID.TabIndex = 107
        Me.lblGuestID.Text = "Label3"
        Me.lblGuestID.Visible = False
        '
        'CustomerFeedback
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(330, 459)
        Me.Controls.Add(Me.lblGuestID)
        Me.Controls.Add(Me.cmdSubmit)
        Me.Controls.Add(Me.txtGuestName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtFeedback)
        Me.Controls.Add(Me.ctRating)
        Me.Name = "CustomerFeedback"
        Me.Text = "CustomerFeedback"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ctRating As Guna.UI2.WinForms.Guna2RatingStar
    Friend WithEvents txtFeedback As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtGuestName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmdSubmit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblGuestID As Label
End Class
