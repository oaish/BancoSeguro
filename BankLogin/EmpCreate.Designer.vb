<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmpCreate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EmpCreate))
        Me.AccPrompt = New System.Windows.Forms.GroupBox()
        Me.ShowPWLbl = New System.Windows.Forms.Label()
        Me.PassIco = New System.Windows.Forms.PictureBox()
        Me.RoleBox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Confirm = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PasswordTxt = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.UsernameTxt = New System.Windows.Forms.TextBox()
        Me.ENextBtn = New System.Windows.Forms.Button()
        Me.ErrorProviderX = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.EmpDetailPanel = New System.Windows.Forms.GroupBox()
        Me.DOBTxt = New System.Windows.Forms.TextBox()
        Me.SubmitBtn = New System.Windows.Forms.Button()
        Me.ChooseBtn = New System.Windows.Forms.Button()
        Me.ProfilePic = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.AddressTxt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.EmailIDTxt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PhoneNoTxt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.NameTxt = New System.Windows.Forms.TextBox()
        Me.ProfileGB = New System.Windows.Forms.GroupBox()
        Me.AM4 = New System.Windows.Forms.PictureBox()
        Me.AM3 = New System.Windows.Forms.PictureBox()
        Me.AM2 = New System.Windows.Forms.PictureBox()
        Me.AM1 = New System.Windows.Forms.PictureBox()
        Me.AccPrompt.SuspendLayout()
        CType(Me.PassIco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProviderX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EmpDetailPanel.SuspendLayout()
        CType(Me.ProfilePic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProfileGB.SuspendLayout()
        CType(Me.AM4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AM3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AM2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AM1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AccPrompt
        '
        Me.AccPrompt.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.AccPrompt.Controls.Add(Me.ShowPWLbl)
        Me.AccPrompt.Controls.Add(Me.PassIco)
        Me.AccPrompt.Controls.Add(Me.RoleBox)
        Me.AccPrompt.Controls.Add(Me.Label2)
        Me.AccPrompt.Controls.Add(Me.Confirm)
        Me.AccPrompt.Controls.Add(Me.Label1)
        Me.AccPrompt.Controls.Add(Me.PasswordTxt)
        Me.AccPrompt.Controls.Add(Me.Label9)
        Me.AccPrompt.Controls.Add(Me.UsernameTxt)
        Me.AccPrompt.Controls.Add(Me.ENextBtn)
        Me.AccPrompt.Font = New System.Drawing.Font("Agency FB", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccPrompt.ForeColor = System.Drawing.Color.White
        Me.AccPrompt.Location = New System.Drawing.Point(163, 132)
        Me.AccPrompt.Name = "AccPrompt"
        Me.AccPrompt.Size = New System.Drawing.Size(584, 397)
        Me.AccPrompt.TabIndex = 25
        Me.AccPrompt.TabStop = False
        Me.AccPrompt.Text = "Sign Up"
        '
        'ShowPWLbl
        '
        Me.ShowPWLbl.AutoSize = True
        Me.ShowPWLbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ShowPWLbl.Font = New System.Drawing.Font("Agency FB", 19.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowPWLbl.Location = New System.Drawing.Point(68, 323)
        Me.ShowPWLbl.Name = "ShowPWLbl"
        Me.ShowPWLbl.Size = New System.Drawing.Size(189, 39)
        Me.ShowPWLbl.TabIndex = 34
        Me.ShowPWLbl.Text = "Show Password"
        Me.ShowPWLbl.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'PassIco
        '
        Me.PassIco.BackColor = System.Drawing.Color.Transparent
        Me.PassIco.Image = Global.BancoSeguro.My.Resources.Resources.passShow
        Me.PassIco.Location = New System.Drawing.Point(29, 325)
        Me.PassIco.Name = "PassIco"
        Me.PassIco.Size = New System.Drawing.Size(33, 36)
        Me.PassIco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PassIco.TabIndex = 33
        Me.PassIco.TabStop = False
        '
        'RoleBox
        '
        Me.RoleBox.Font = New System.Drawing.Font("Agency FB", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoleBox.FormattingEnabled = True
        Me.RoleBox.Items.AddRange(New Object() {"Admin", "Bank Teller", "Loan Officer"})
        Me.RoleBox.Location = New System.Drawing.Point(422, 89)
        Me.RoleBox.Name = "RoleBox"
        Me.RoleBox.Size = New System.Drawing.Size(136, 42)
        Me.RoleBox.TabIndex = 32
        Me.RoleBox.Text = "Select Roles"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label2.Font = New System.Drawing.Font("Agency FB", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 244)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 41)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "    Confirm :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Confirm
        '
        Me.Confirm.Font = New System.Drawing.Font("Agency FB", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ErrorProviderX.SetIconPadding(Me.Confirm, 5)
        Me.Confirm.Location = New System.Drawing.Point(179, 248)
        Me.Confirm.Name = "Confirm"
        Me.Confirm.Size = New System.Drawing.Size(183, 37)
        Me.Confirm.TabIndex = 30
        Me.Confirm.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Agency FB", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 166)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 41)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Password : "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'PasswordTxt
        '
        Me.PasswordTxt.Font = New System.Drawing.Font("Agency FB", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ErrorProviderX.SetIconPadding(Me.PasswordTxt, 5)
        Me.PasswordTxt.Location = New System.Drawing.Point(179, 170)
        Me.PasswordTxt.Name = "PasswordTxt"
        Me.PasswordTxt.Size = New System.Drawing.Size(183, 37)
        Me.PasswordTxt.TabIndex = 28
        Me.PasswordTxt.UseSystemPasswordChar = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label9.Font = New System.Drawing.Font("Agency FB", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(22, 88)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(151, 41)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Username : "
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'UsernameTxt
        '
        Me.UsernameTxt.Font = New System.Drawing.Font("Agency FB", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ErrorProviderX.SetIconPadding(Me.UsernameTxt, 5)
        Me.UsernameTxt.Location = New System.Drawing.Point(179, 92)
        Me.UsernameTxt.Name = "UsernameTxt"
        Me.UsernameTxt.Size = New System.Drawing.Size(183, 37)
        Me.UsernameTxt.TabIndex = 26
        '
        'ENextBtn
        '
        Me.ENextBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ENextBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ENextBtn.FlatAppearance.BorderSize = 2
        Me.ENextBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.ENextBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.ENextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ENextBtn.Font = New System.Drawing.Font("Agency FB", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ENextBtn.ForeColor = System.Drawing.Color.White
        Me.ENextBtn.Image = CType(resources.GetObject("ENextBtn.Image"), System.Drawing.Image)
        Me.ENextBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ENextBtn.Location = New System.Drawing.Point(422, 315)
        Me.ENextBtn.Name = "ENextBtn"
        Me.ENextBtn.Size = New System.Drawing.Size(136, 57)
        Me.ENextBtn.TabIndex = 33
        Me.ENextBtn.Text = "Next"
        Me.ENextBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ENextBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ENextBtn.UseVisualStyleBackColor = True
        '
        'ErrorProviderX
        '
        Me.ErrorProviderX.ContainerControl = Me
        Me.ErrorProviderX.Icon = CType(resources.GetObject("ErrorProviderX.Icon"), System.Drawing.Icon)
        '
        'EmpDetailPanel
        '
        Me.EmpDetailPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.EmpDetailPanel.Controls.Add(Me.DOBTxt)
        Me.EmpDetailPanel.Controls.Add(Me.SubmitBtn)
        Me.EmpDetailPanel.Controls.Add(Me.ChooseBtn)
        Me.EmpDetailPanel.Controls.Add(Me.ProfilePic)
        Me.EmpDetailPanel.Controls.Add(Me.Label8)
        Me.EmpDetailPanel.Controls.Add(Me.AddressTxt)
        Me.EmpDetailPanel.Controls.Add(Me.Label7)
        Me.EmpDetailPanel.Controls.Add(Me.EmailIDTxt)
        Me.EmpDetailPanel.Controls.Add(Me.Label6)
        Me.EmpDetailPanel.Controls.Add(Me.PhoneNoTxt)
        Me.EmpDetailPanel.Controls.Add(Me.Label5)
        Me.EmpDetailPanel.Controls.Add(Me.Label11)
        Me.EmpDetailPanel.Controls.Add(Me.NameTxt)
        Me.EmpDetailPanel.Font = New System.Drawing.Font("Agency FB", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpDetailPanel.ForeColor = System.Drawing.Color.White
        Me.ErrorProviderX.SetIconPadding(Me.EmpDetailPanel, 10)
        Me.EmpDetailPanel.Location = New System.Drawing.Point(105, 55)
        Me.EmpDetailPanel.Name = "EmpDetailPanel"
        Me.EmpDetailPanel.Size = New System.Drawing.Size(732, 550)
        Me.EmpDetailPanel.TabIndex = 26
        Me.EmpDetailPanel.TabStop = False
        Me.EmpDetailPanel.Text = "Employee Details"
        Me.EmpDetailPanel.Visible = False
        '
        'DOBTxt
        '
        Me.DOBTxt.Font = New System.Drawing.Font("Agency FB", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ErrorProviderX.SetIconPadding(Me.DOBTxt, 10)
        Me.DOBTxt.Location = New System.Drawing.Point(244, 160)
        Me.DOBTxt.Name = "DOBTxt"
        Me.DOBTxt.Size = New System.Drawing.Size(183, 37)
        Me.DOBTxt.TabIndex = 1
        '
        'SubmitBtn
        '
        Me.SubmitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SubmitBtn.FlatAppearance.BorderSize = 2
        Me.SubmitBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.SubmitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.SubmitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SubmitBtn.Font = New System.Drawing.Font("Agency FB", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubmitBtn.ForeColor = System.Drawing.Color.White
        Me.ErrorProviderX.SetIconPadding(Me.SubmitBtn, 10)
        Me.SubmitBtn.Image = Global.BancoSeguro.My.Resources.Resources.save30x
        Me.SubmitBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SubmitBtn.Location = New System.Drawing.Point(268, 457)
        Me.SubmitBtn.Name = "SubmitBtn"
        Me.SubmitBtn.Size = New System.Drawing.Size(127, 57)
        Me.SubmitBtn.TabIndex = 7
        Me.SubmitBtn.Text = "Save"
        Me.SubmitBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SubmitBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.SubmitBtn.UseVisualStyleBackColor = True
        '
        'ChooseBtn
        '
        Me.ChooseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ChooseBtn.FlatAppearance.BorderSize = 2
        Me.ChooseBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.ChooseBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.ChooseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChooseBtn.Font = New System.Drawing.Font("Agency FB", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChooseBtn.ForeColor = System.Drawing.Color.White
        Me.ChooseBtn.Image = Global.BancoSeguro.My.Resources.Resources.choose30x
        Me.ChooseBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChooseBtn.Location = New System.Drawing.Point(551, 212)
        Me.ChooseBtn.Name = "ChooseBtn"
        Me.ChooseBtn.Size = New System.Drawing.Size(136, 52)
        Me.ChooseBtn.TabIndex = 6
        Me.ChooseBtn.Text = "Choose"
        Me.ChooseBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ChooseBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ChooseBtn.UseVisualStyleBackColor = True
        '
        'ProfilePic
        '
        Me.ProfilePic.BackColor = System.Drawing.Color.White
        Me.ProfilePic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ProfilePic.Image = Global.BancoSeguro.My.Resources.Resources.profile_500x
        Me.ProfilePic.Location = New System.Drawing.Point(551, 59)
        Me.ProfilePic.Name = "ProfilePic"
        Me.ProfilePic.Size = New System.Drawing.Size(136, 136)
        Me.ProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ProfilePic.TabIndex = 21
        Me.ProfilePic.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label8.Location = New System.Drawing.Point(109, 390)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(122, 41)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Address :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'AddressTxt
        '
        Me.AddressTxt.Font = New System.Drawing.Font("Agency FB", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ErrorProviderX.SetIconPadding(Me.AddressTxt, 10)
        Me.AddressTxt.Location = New System.Drawing.Point(244, 390)
        Me.AddressTxt.Name = "AddressTxt"
        Me.AddressTxt.Size = New System.Drawing.Size(183, 37)
        Me.AddressTxt.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label7.Location = New System.Drawing.Point(109, 312)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 41)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Email ID :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'EmailIDTxt
        '
        Me.EmailIDTxt.Font = New System.Drawing.Font("Agency FB", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ErrorProviderX.SetIconPadding(Me.EmailIDTxt, 10)
        Me.EmailIDTxt.Location = New System.Drawing.Point(244, 316)
        Me.EmailIDTxt.Name = "EmailIDTxt"
        Me.EmailIDTxt.Size = New System.Drawing.Size(183, 37)
        Me.EmailIDTxt.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label6.Location = New System.Drawing.Point(94, 234)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(135, 41)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Phone No :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'PhoneNoTxt
        '
        Me.PhoneNoTxt.Font = New System.Drawing.Font("Agency FB", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ErrorProviderX.SetIconPadding(Me.PhoneNoTxt, 10)
        Me.PhoneNoTxt.Location = New System.Drawing.Point(244, 238)
        Me.PhoneNoTxt.Name = "PhoneNoTxt"
        Me.PhoneNoTxt.Size = New System.Drawing.Size(183, 37)
        Me.PhoneNoTxt.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label5.Location = New System.Drawing.Point(56, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(173, 41)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Date Of Birth :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label11.Location = New System.Drawing.Point(94, 78)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(135, 41)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Full Name :"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'NameTxt
        '
        Me.NameTxt.Font = New System.Drawing.Font("Agency FB", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ErrorProviderX.SetIconPadding(Me.NameTxt, 10)
        Me.NameTxt.Location = New System.Drawing.Point(244, 82)
        Me.NameTxt.Name = "NameTxt"
        Me.NameTxt.Size = New System.Drawing.Size(183, 37)
        Me.NameTxt.TabIndex = 0
        '
        'ProfileGB
        '
        Me.ProfileGB.Controls.Add(Me.AM4)
        Me.ProfileGB.Controls.Add(Me.AM3)
        Me.ProfileGB.Controls.Add(Me.AM2)
        Me.ProfileGB.Controls.Add(Me.AM1)
        Me.ProfileGB.Font = New System.Drawing.Font("Agency FB", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProfileGB.ForeColor = System.Drawing.Color.White
        Me.ProfileGB.Location = New System.Drawing.Point(294, 158)
        Me.ProfileGB.Name = "ProfileGB"
        Me.ProfileGB.Size = New System.Drawing.Size(322, 353)
        Me.ProfileGB.TabIndex = 31
        Me.ProfileGB.TabStop = False
        Me.ProfileGB.Text = "Select Profile Pic"
        Me.ProfileGB.Visible = False
        '
        'AM4
        '
        Me.AM4.BackColor = System.Drawing.Color.Transparent
        Me.AM4.Image = Global.BancoSeguro.My.Resources.Resources.AM4
        Me.AM4.Location = New System.Drawing.Point(172, 202)
        Me.AM4.Name = "AM4"
        Me.AM4.Size = New System.Drawing.Size(136, 136)
        Me.AM4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AM4.TabIndex = 39
        Me.AM4.TabStop = False
        Me.AM4.Tag = "Users\AM4.png"
        '
        'AM3
        '
        Me.AM3.BackColor = System.Drawing.Color.Transparent
        Me.AM3.Image = Global.BancoSeguro.My.Resources.Resources.AM3
        Me.AM3.Location = New System.Drawing.Point(14, 202)
        Me.AM3.Name = "AM3"
        Me.AM3.Size = New System.Drawing.Size(136, 136)
        Me.AM3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AM3.TabIndex = 38
        Me.AM3.TabStop = False
        Me.AM3.Tag = "Users\AM3.png"
        '
        'AM2
        '
        Me.AM2.BackColor = System.Drawing.Color.Transparent
        Me.AM2.Image = Global.BancoSeguro.My.Resources.Resources.AM2
        Me.AM2.Location = New System.Drawing.Point(172, 45)
        Me.AM2.Name = "AM2"
        Me.AM2.Size = New System.Drawing.Size(136, 136)
        Me.AM2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AM2.TabIndex = 37
        Me.AM2.TabStop = False
        Me.AM2.Tag = "Users\AM2.png"
        '
        'AM1
        '
        Me.AM1.BackColor = System.Drawing.Color.Transparent
        Me.AM1.Image = Global.BancoSeguro.My.Resources.Resources.AM1
        Me.AM1.Location = New System.Drawing.Point(14, 45)
        Me.AM1.Name = "AM1"
        Me.AM1.Size = New System.Drawing.Size(136, 136)
        Me.AM1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AM1.TabIndex = 36
        Me.AM1.TabStop = False
        Me.AM1.Tag = "Users\AM1.png"
        '
        'EmpCreate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.EmpDetailPanel)
        Me.Controls.Add(Me.AccPrompt)
        Me.Controls.Add(Me.ProfileGB)
        Me.Name = "EmpCreate"
        Me.Size = New System.Drawing.Size(911, 660)
        Me.AccPrompt.ResumeLayout(False)
        Me.AccPrompt.PerformLayout()
        CType(Me.PassIco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProviderX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EmpDetailPanel.ResumeLayout(False)
        Me.EmpDetailPanel.PerformLayout()
        CType(Me.ProfilePic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProfileGB.ResumeLayout(False)
        CType(Me.AM4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AM3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AM2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AM1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AccPrompt As System.Windows.Forms.GroupBox
    Friend WithEvents ENextBtn As System.Windows.Forms.Button
    Friend WithEvents RoleBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Confirm As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PasswordTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents UsernameTxt As System.Windows.Forms.TextBox
    Friend WithEvents PassIco As System.Windows.Forms.PictureBox
    Friend WithEvents ShowPWLbl As System.Windows.Forms.Label
    Friend WithEvents ErrorProviderX As System.Windows.Forms.ErrorProvider
    Friend WithEvents EmpDetailPanel As System.Windows.Forms.GroupBox
    Friend WithEvents DOBTxt As System.Windows.Forms.TextBox
    Friend WithEvents SubmitBtn As System.Windows.Forms.Button
    Friend WithEvents ChooseBtn As System.Windows.Forms.Button
    Public WithEvents ProfilePic As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents AddressTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents EmailIDTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PhoneNoTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents NameTxt As System.Windows.Forms.TextBox
    Friend WithEvents ProfileGB As System.Windows.Forms.GroupBox
    Friend WithEvents AM4 As System.Windows.Forms.PictureBox
    Friend WithEvents AM3 As System.Windows.Forms.PictureBox
    Friend WithEvents AM2 As System.Windows.Forms.PictureBox
    Friend WithEvents AM1 As System.Windows.Forms.PictureBox

End Class
