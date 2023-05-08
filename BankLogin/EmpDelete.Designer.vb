<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmpDelete
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EmpDelete))
        Me.LoginGB = New System.Windows.Forms.GroupBox()
        Me.ShowPWLbl = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PasswordTxt = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.UsernameTxt = New System.Windows.Forms.TextBox()
        Me.PassIco = New System.Windows.Forms.PictureBox()
        Me.ENextBtn = New System.Windows.Forms.Button()
        Me.ErrorProviderX = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.LoginGB.SuspendLayout()
        CType(Me.PassIco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProviderX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LoginGB
        '
        Me.LoginGB.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.LoginGB.Controls.Add(Me.ShowPWLbl)
        Me.LoginGB.Controls.Add(Me.PassIco)
        Me.LoginGB.Controls.Add(Me.Label1)
        Me.LoginGB.Controls.Add(Me.PasswordTxt)
        Me.LoginGB.Controls.Add(Me.Label9)
        Me.LoginGB.Controls.Add(Me.UsernameTxt)
        Me.LoginGB.Controls.Add(Me.ENextBtn)
        Me.LoginGB.Font = New System.Drawing.Font("Agency FB", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginGB.ForeColor = System.Drawing.Color.White
        Me.LoginGB.Location = New System.Drawing.Point(191, 148)
        Me.LoginGB.Name = "LoginGB"
        Me.LoginGB.Size = New System.Drawing.Size(529, 365)
        Me.LoginGB.TabIndex = 25
        Me.LoginGB.TabStop = False
        Me.LoginGB.Text = "Enter User Credentials"
        '
        'ShowPWLbl
        '
        Me.ShowPWLbl.AutoSize = True
        Me.ShowPWLbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ShowPWLbl.Font = New System.Drawing.Font("Agency FB", 19.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowPWLbl.Location = New System.Drawing.Point(118, 258)
        Me.ShowPWLbl.Name = "ShowPWLbl"
        Me.ShowPWLbl.Size = New System.Drawing.Size(189, 39)
        Me.ShowPWLbl.TabIndex = 40
        Me.ShowPWLbl.Text = "Show Password"
        Me.ShowPWLbl.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Agency FB", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(74, 172)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 41)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Password : "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'PasswordTxt
        '
        Me.PasswordTxt.Font = New System.Drawing.Font("Agency FB", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTxt.Location = New System.Drawing.Point(231, 176)
        Me.PasswordTxt.Name = "PasswordTxt"
        Me.PasswordTxt.Size = New System.Drawing.Size(230, 37)
        Me.PasswordTxt.TabIndex = 36
        Me.PasswordTxt.UseSystemPasswordChar = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label9.Font = New System.Drawing.Font("Agency FB", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(74, 94)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(151, 41)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Username : "
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'UsernameTxt
        '
        Me.UsernameTxt.Font = New System.Drawing.Font("Agency FB", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameTxt.Location = New System.Drawing.Point(231, 98)
        Me.UsernameTxt.Name = "UsernameTxt"
        Me.UsernameTxt.Size = New System.Drawing.Size(230, 37)
        Me.UsernameTxt.TabIndex = 34
        '
        'PassIco
        '
        Me.PassIco.BackColor = System.Drawing.Color.Transparent
        Me.PassIco.Image = Global.BancoSeguro.My.Resources.Resources.passShow
        Me.PassIco.Location = New System.Drawing.Point(79, 260)
        Me.PassIco.Name = "PassIco"
        Me.PassIco.Size = New System.Drawing.Size(33, 36)
        Me.PassIco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PassIco.TabIndex = 39
        Me.PassIco.TabStop = False
        '
        'ENextBtn
        '
        Me.ENextBtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ENextBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ENextBtn.FlatAppearance.BorderSize = 2
        Me.ENextBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.ENextBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.ENextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ENextBtn.Font = New System.Drawing.Font("Agency FB", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ENextBtn.ForeColor = System.Drawing.Color.White
        Me.ErrorProviderX.SetIconPadding(Me.ENextBtn, 10)
        Me.ENextBtn.Image = Global.BancoSeguro.My.Resources.Resources.del_btn_30x
        Me.ENextBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ENextBtn.Location = New System.Drawing.Point(325, 251)
        Me.ENextBtn.Name = "ENextBtn"
        Me.ENextBtn.Size = New System.Drawing.Size(136, 57)
        Me.ENextBtn.TabIndex = 38
        Me.ENextBtn.Text = "Delete"
        Me.ENextBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ENextBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ENextBtn.UseVisualStyleBackColor = True
        '
        'ErrorProviderX
        '
        Me.ErrorProviderX.ContainerControl = Me
        Me.ErrorProviderX.Icon = CType(resources.GetObject("ErrorProviderX.Icon"), System.Drawing.Icon)
        '
        'EmpDelete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.LoginGB)
        Me.Name = "EmpDelete"
        Me.Size = New System.Drawing.Size(909, 658)
        Me.LoginGB.ResumeLayout(False)
        Me.LoginGB.PerformLayout()
        CType(Me.PassIco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProviderX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LoginGB As System.Windows.Forms.GroupBox
    Friend WithEvents ShowPWLbl As System.Windows.Forms.Label
    Friend WithEvents PassIco As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PasswordTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents UsernameTxt As System.Windows.Forms.TextBox
    Friend WithEvents ENextBtn As System.Windows.Forms.Button
    Friend WithEvents ErrorProviderX As System.Windows.Forms.ErrorProvider

End Class
