<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Username = New System.Windows.Forms.TextBox()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.LoginLbl = New System.Windows.Forms.Label()
        Me.LoginBtn = New System.Windows.Forms.Button()
        Me.CloseBtn = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.UserIco = New System.Windows.Forms.PictureBox()
        Me.PassIco = New System.Windows.Forms.PictureBox()
        CType(Me.CloseBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.UserIco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PassIco, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Username
        '
        Me.Username.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Username.ForeColor = System.Drawing.Color.Gray
        Me.Username.Location = New System.Drawing.Point(72, 77)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(204, 36)
        Me.Username.TabIndex = 5
        Me.Username.Text = "Enter Username"
        '
        'Password
        '
        Me.Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password.ForeColor = System.Drawing.Color.Gray
        Me.Password.Location = New System.Drawing.Point(72, 136)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(204, 36)
        Me.Password.TabIndex = 6
        Me.Password.Text = "Enter Password"
        '
        'LoginLbl
        '
        Me.LoginLbl.AutoSize = True
        Me.LoginLbl.BackColor = System.Drawing.Color.Transparent
        Me.LoginLbl.Font = New System.Drawing.Font("Agency FB", 25.0!, System.Drawing.FontStyle.Bold)
        Me.LoginLbl.ForeColor = System.Drawing.SystemColors.Window
        Me.LoginLbl.Location = New System.Drawing.Point(24, 13)
        Me.LoginLbl.Name = "LoginLbl"
        Me.LoginLbl.Size = New System.Drawing.Size(96, 51)
        Me.LoginLbl.TabIndex = 3
        Me.LoginLbl.Text = "Login"
        '
        'LoginBtn
        '
        Me.LoginBtn.AutoEllipsis = True
        Me.LoginBtn.BackColor = System.Drawing.SystemColors.HotTrack
        Me.LoginBtn.BackgroundImage = Global.BancoSeguro.My.Resources.Resources.AppBGBlur
        Me.LoginBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LoginBtn.FlatAppearance.BorderSize = 2
        Me.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LoginBtn.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Bold)
        Me.LoginBtn.ForeColor = System.Drawing.SystemColors.Window
        Me.LoginBtn.Location = New System.Drawing.Point(191, 190)
        Me.LoginBtn.Name = "LoginBtn"
        Me.LoginBtn.Size = New System.Drawing.Size(85, 52)
        Me.LoginBtn.TabIndex = 0
        Me.LoginBtn.Text = "Login"
        Me.LoginBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LoginBtn.UseVisualStyleBackColor = False
        '
        'CloseBtn
        '
        Me.CloseBtn.BackColor = System.Drawing.Color.Transparent
        Me.CloseBtn.Image = CType(resources.GetObject("CloseBtn.Image"), System.Drawing.Image)
        Me.CloseBtn.Location = New System.Drawing.Point(231, 19)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(45, 45)
        Me.CloseBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CloseBtn.TabIndex = 8
        Me.CloseBtn.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Password)
        Me.Panel1.Controls.Add(Me.Username)
        Me.Panel1.Controls.Add(Me.LoginLbl)
        Me.Panel1.Controls.Add(Me.LoginBtn)
        Me.Panel1.Controls.Add(Me.UserIco)
        Me.Panel1.Controls.Add(Me.CloseBtn)
        Me.Panel1.Controls.Add(Me.PassIco)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(313, 276)
        Me.Panel1.TabIndex = 11
        '
        'UserIco
        '
        Me.UserIco.BackColor = System.Drawing.Color.Transparent
        Me.UserIco.Image = Global.BancoSeguro.My.Resources.Resources.contact30x
        Me.UserIco.Location = New System.Drawing.Point(33, 77)
        Me.UserIco.Name = "UserIco"
        Me.UserIco.Size = New System.Drawing.Size(33, 36)
        Me.UserIco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.UserIco.TabIndex = 14
        Me.UserIco.TabStop = False
        '
        'PassIco
        '
        Me.PassIco.BackColor = System.Drawing.Color.Transparent
        Me.PassIco.Image = Global.BancoSeguro.My.Resources.Resources.passLock
        Me.PassIco.Location = New System.Drawing.Point(33, 136)
        Me.PassIco.Name = "PassIco"
        Me.PassIco.Size = New System.Drawing.Size(33, 36)
        Me.PassIco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PassIco.TabIndex = 12
        Me.PassIco.TabStop = False
        '
        'Login
        '
        Me.AcceptButton = Me.LoginBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(313, 276)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.TopMost = True
        CType(Me.CloseBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.UserIco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PassIco, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Username As System.Windows.Forms.TextBox
    Friend WithEvents Password As System.Windows.Forms.TextBox
    Friend WithEvents LoginLbl As System.Windows.Forms.Label
    Friend WithEvents LoginBtn As System.Windows.Forms.Button
    Friend WithEvents CloseBtn As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PassIco As System.Windows.Forms.PictureBox
    Friend WithEvents UserIco As System.Windows.Forms.PictureBox

End Class
