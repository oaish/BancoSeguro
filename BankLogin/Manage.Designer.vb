<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Manage
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Manage))
        Me.UserLbl = New System.Windows.Forms.Label()
        Me.RoleLbl = New System.Windows.Forms.Label()
        Me.PasswordRstPanel = New System.Windows.Forms.GroupBox()
        Me.ConfirmTxt = New System.Windows.Forms.TextBox()
        Me.NewTxt = New System.Windows.Forms.TextBox()
        Me.OldTxt = New System.Windows.Forms.TextBox()
        Me.PswrdResetBtn = New System.Windows.Forms.Button()
        Me.ProfilePic = New System.Windows.Forms.PictureBox()
        Me.ErrorProviderX = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ResetBtn = New System.Windows.Forms.Button()
        Me.PasswordRstPanel.SuspendLayout()
        CType(Me.ProfilePic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProviderX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UserLbl
        '
        Me.UserLbl.AutoSize = True
        Me.UserLbl.BackColor = System.Drawing.Color.Transparent
        Me.UserLbl.Font = New System.Drawing.Font("Agency FB", 35.0!, System.Drawing.FontStyle.Bold)
        Me.UserLbl.ForeColor = System.Drawing.Color.White
        Me.UserLbl.Location = New System.Drawing.Point(248, 77)
        Me.UserLbl.Name = "UserLbl"
        Me.UserLbl.Size = New System.Drawing.Size(151, 72)
        Me.UserLbl.TabIndex = 14
        Me.UserLbl.Text = "Admin"
        Me.UserLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RoleLbl
        '
        Me.RoleLbl.AutoSize = True
        Me.RoleLbl.BackColor = System.Drawing.Color.Transparent
        Me.RoleLbl.Font = New System.Drawing.Font("Agency FB", 30.0!)
        Me.RoleLbl.ForeColor = System.Drawing.Color.White
        Me.RoleLbl.Location = New System.Drawing.Point(248, 149)
        Me.RoleLbl.Name = "RoleLbl"
        Me.RoleLbl.Size = New System.Drawing.Size(236, 60)
        Me.RoleLbl.TabIndex = 15
        Me.RoleLbl.Text = "Administrator" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.RoleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordRstPanel
        '
        Me.PasswordRstPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.PasswordRstPanel.BackgroundImage = Global.BancoSeguro.My.Resources.Resources.BlackBG
        Me.PasswordRstPanel.Controls.Add(Me.ResetBtn)
        Me.PasswordRstPanel.Controls.Add(Me.ConfirmTxt)
        Me.PasswordRstPanel.Controls.Add(Me.NewTxt)
        Me.PasswordRstPanel.Controls.Add(Me.OldTxt)
        Me.PasswordRstPanel.Font = New System.Drawing.Font("Agency FB", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordRstPanel.ForeColor = System.Drawing.Color.White
        Me.PasswordRstPanel.Location = New System.Drawing.Point(409, 261)
        Me.PasswordRstPanel.Name = "PasswordRstPanel"
        Me.PasswordRstPanel.Size = New System.Drawing.Size(420, 360)
        Me.PasswordRstPanel.TabIndex = 21
        Me.PasswordRstPanel.TabStop = False
        Me.PasswordRstPanel.Text = "Password Reset"
        Me.PasswordRstPanel.Visible = False
        '
        'ConfirmTxt
        '
        Me.ConfirmTxt.ForeColor = System.Drawing.Color.Gray
        Me.ErrorProviderX.SetIconPadding(Me.ConfirmTxt, 10)
        Me.ConfirmTxt.Location = New System.Drawing.Point(49, 203)
        Me.ConfirmTxt.Name = "ConfirmTxt"
        Me.ConfirmTxt.Size = New System.Drawing.Size(300, 47)
        Me.ConfirmTxt.TabIndex = 2
        Me.ConfirmTxt.Text = "Confirm Password"
        '
        'NewTxt
        '
        Me.NewTxt.ForeColor = System.Drawing.Color.Gray
        Me.ErrorProviderX.SetIconPadding(Me.NewTxt, 10)
        Me.NewTxt.Location = New System.Drawing.Point(47, 135)
        Me.NewTxt.Name = "NewTxt"
        Me.NewTxt.Size = New System.Drawing.Size(300, 47)
        Me.NewTxt.TabIndex = 1
        Me.NewTxt.Text = "New Password"
        '
        'OldTxt
        '
        Me.OldTxt.ForeColor = System.Drawing.Color.Gray
        Me.ErrorProviderX.SetIconPadding(Me.OldTxt, 10)
        Me.OldTxt.Location = New System.Drawing.Point(49, 68)
        Me.OldTxt.Name = "OldTxt"
        Me.OldTxt.Size = New System.Drawing.Size(300, 47)
        Me.OldTxt.TabIndex = 0
        Me.OldTxt.Text = "Old Password"
        '
        'PswrdResetBtn
        '
        Me.PswrdResetBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PswrdResetBtn.FlatAppearance.BorderSize = 2
        Me.PswrdResetBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.PswrdResetBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.PswrdResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PswrdResetBtn.Font = New System.Drawing.Font("Agency FB", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PswrdResetBtn.ForeColor = System.Drawing.Color.White
        Me.PswrdResetBtn.Image = Global.BancoSeguro.My.Resources.Resources.key_40px
        Me.PswrdResetBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PswrdResetBtn.Location = New System.Drawing.Point(59, 285)
        Me.PswrdResetBtn.Name = "PswrdResetBtn"
        Me.PswrdResetBtn.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.PswrdResetBtn.Size = New System.Drawing.Size(272, 88)
        Me.PswrdResetBtn.TabIndex = 20
        Me.PswrdResetBtn.Text = "Reset Password"
        Me.PswrdResetBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.PswrdResetBtn.UseVisualStyleBackColor = True
        '
        'ProfilePic
        '
        Me.ProfilePic.BackColor = System.Drawing.Color.White
        Me.ProfilePic.Image = Global.BancoSeguro.My.Resources.Resources.profile500x
        Me.ProfilePic.ImageLocation = ""
        Me.ProfilePic.Location = New System.Drawing.Point(59, 54)
        Me.ProfilePic.Name = "ProfilePic"
        Me.ProfilePic.Size = New System.Drawing.Size(183, 184)
        Me.ProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ProfilePic.TabIndex = 13
        Me.ProfilePic.TabStop = False
        '
        'ErrorProviderX
        '
        Me.ErrorProviderX.ContainerControl = Me
        Me.ErrorProviderX.Icon = CType(resources.GetObject("ErrorProviderX.Icon"), System.Drawing.Icon)
        '
        'ResetBtn
        '
        Me.ResetBtn.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ResetBtn.BackgroundImage = Global.BancoSeguro.My.Resources.Resources.AppBGBlur
        Me.ResetBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ResetBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ResetBtn.FlatAppearance.BorderSize = 3
        Me.ResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ResetBtn.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Bold)
        Me.ResetBtn.ForeColor = System.Drawing.SystemColors.Window
        Me.ErrorProviderX.SetIconPadding(Me.ResetBtn, 10)
        Me.ResetBtn.Location = New System.Drawing.Point(145, 277)
        Me.ResetBtn.Name = "ResetBtn"
        Me.ResetBtn.Size = New System.Drawing.Size(131, 53)
        Me.ResetBtn.TabIndex = 24
        Me.ResetBtn.Text = "Reset"
        Me.ResetBtn.UseVisualStyleBackColor = False
        '
        'Manage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.Transparent
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.PasswordRstPanel)
        Me.Controls.Add(Me.PswrdResetBtn)
        Me.Controls.Add(Me.RoleLbl)
        Me.Controls.Add(Me.UserLbl)
        Me.Controls.Add(Me.ProfilePic)
        Me.Name = "Manage"
        Me.Size = New System.Drawing.Size(909, 658)
        Me.PasswordRstPanel.ResumeLayout(False)
        Me.PasswordRstPanel.PerformLayout()
        CType(Me.ProfilePic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProviderX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProfilePic As System.Windows.Forms.PictureBox
    Friend WithEvents UserLbl As System.Windows.Forms.Label
    Friend WithEvents RoleLbl As System.Windows.Forms.Label
    Friend WithEvents PswrdResetBtn As System.Windows.Forms.Button
    Friend WithEvents PasswordRstPanel As System.Windows.Forms.GroupBox
    Friend WithEvents OldTxt As System.Windows.Forms.TextBox
    Friend WithEvents ConfirmTxt As System.Windows.Forms.TextBox
    Friend WithEvents NewTxt As System.Windows.Forms.TextBox
    Friend WithEvents ErrorProviderX As System.Windows.Forms.ErrorProvider
    Friend WithEvents ResetBtn As System.Windows.Forms.Button

End Class
