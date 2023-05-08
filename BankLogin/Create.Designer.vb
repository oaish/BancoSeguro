<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Create
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Create))
        Me.AccPrompt = New System.Windows.Forms.GroupBox()
        Me.SearchAccPanel = New System.Windows.Forms.GroupBox()
        Me.SearchBtn = New System.Windows.Forms.Button()
        Me.AccSearchBox = New System.Windows.Forms.TextBox()
        Me.OldCreateBtn = New System.Windows.Forms.Button()
        Me.NewCreateBtn = New System.Windows.Forms.Button()
        Me.CreateAccountPanel = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DOBTxt = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MaleRB = New System.Windows.Forms.RadioButton()
        Me.FemaleRB = New System.Windows.Forms.RadioButton()
        Me.SubmitBtn = New System.Windows.Forms.Button()
        Me.ChooseBtn = New System.Windows.Forms.Button()
        Me.ProfilePic = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.InitBalTxt = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.AddressTxt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.EmailIDTxt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PhoneNoTxt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CurrentRB = New System.Windows.Forms.RadioButton()
        Me.SavingsRB = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NameTxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AccNoTxt = New System.Windows.Forms.TextBox()
        Me.ErrorProviderX = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.AccPrompt.SuspendLayout()
        Me.SearchAccPanel.SuspendLayout()
        Me.CreateAccountPanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.ProfilePic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProviderX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AccPrompt
        '
        Me.AccPrompt.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.AccPrompt.Controls.Add(Me.SearchAccPanel)
        Me.AccPrompt.Controls.Add(Me.OldCreateBtn)
        Me.AccPrompt.Controls.Add(Me.NewCreateBtn)
        Me.AccPrompt.Font = New System.Drawing.Font("Agency FB", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccPrompt.ForeColor = System.Drawing.Color.White
        Me.AccPrompt.Location = New System.Drawing.Point(343, 140)
        Me.AccPrompt.Name = "AccPrompt"
        Me.AccPrompt.Size = New System.Drawing.Size(221, 322)
        Me.AccPrompt.TabIndex = 24
        Me.AccPrompt.TabStop = False
        Me.AccPrompt.Text = "Customer"
        '
        'SearchAccPanel
        '
        Me.SearchAccPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.SearchAccPanel.Controls.Add(Me.SearchBtn)
        Me.SearchAccPanel.Controls.Add(Me.AccSearchBox)
        Me.SearchAccPanel.Font = New System.Drawing.Font("Agency FB", 15.0!, System.Drawing.FontStyle.Bold)
        Me.SearchAccPanel.ForeColor = System.Drawing.Color.White
        Me.SearchAccPanel.Location = New System.Drawing.Point(21, 168)
        Me.SearchAccPanel.Name = "SearchAccPanel"
        Me.SearchAccPanel.Size = New System.Drawing.Size(179, 105)
        Me.SearchAccPanel.TabIndex = 25
        Me.SearchAccPanel.TabStop = False
        Me.SearchAccPanel.Text = "Enter Account No"
        Me.SearchAccPanel.Visible = False
        '
        'SearchBtn
        '
        Me.SearchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SearchBtn.FlatAppearance.BorderSize = 0
        Me.SearchBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.SearchBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchBtn.Font = New System.Drawing.Font("Agency FB", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchBtn.ForeColor = System.Drawing.Color.White
        Me.SearchBtn.Image = CType(resources.GetObject("SearchBtn.Image"), System.Drawing.Image)
        Me.SearchBtn.Location = New System.Drawing.Point(125, 39)
        Me.SearchBtn.Name = "SearchBtn"
        Me.SearchBtn.Size = New System.Drawing.Size(35, 47)
        Me.SearchBtn.TabIndex = 13
        Me.SearchBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.SearchBtn.UseVisualStyleBackColor = True
        '
        'AccSearchBox
        '
        Me.AccSearchBox.Font = New System.Drawing.Font("Agency FB", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccSearchBox.Location = New System.Drawing.Point(16, 43)
        Me.AccSearchBox.Name = "AccSearchBox"
        Me.AccSearchBox.Size = New System.Drawing.Size(103, 37)
        Me.AccSearchBox.TabIndex = 11
        '
        'OldCreateBtn
        '
        Me.OldCreateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.OldCreateBtn.FlatAppearance.BorderSize = 2
        Me.OldCreateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.OldCreateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.OldCreateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OldCreateBtn.Font = New System.Drawing.Font("Agency FB", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OldCreateBtn.ForeColor = System.Drawing.Color.White
        Me.OldCreateBtn.Image = Global.BancoSeguro.My.Resources.Resources.update30x
        Me.OldCreateBtn.Location = New System.Drawing.Point(37, 184)
        Me.OldCreateBtn.Name = "OldCreateBtn"
        Me.OldCreateBtn.Size = New System.Drawing.Size(147, 88)
        Me.OldCreateBtn.TabIndex = 20
        Me.OldCreateBtn.Text = "Existing " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Customer"
        Me.OldCreateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.OldCreateBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.OldCreateBtn.UseVisualStyleBackColor = True
        '
        'NewCreateBtn
        '
        Me.NewCreateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.NewCreateBtn.FlatAppearance.BorderSize = 2
        Me.NewCreateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.NewCreateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.NewCreateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NewCreateBtn.Font = New System.Drawing.Font("Agency FB", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewCreateBtn.ForeColor = System.Drawing.Color.White
        Me.NewCreateBtn.Image = Global.BancoSeguro.My.Resources.Resources.create_30x
        Me.NewCreateBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.NewCreateBtn.Location = New System.Drawing.Point(37, 66)
        Me.NewCreateBtn.Name = "NewCreateBtn"
        Me.NewCreateBtn.Size = New System.Drawing.Size(147, 88)
        Me.NewCreateBtn.TabIndex = 19
        Me.NewCreateBtn.Text = "New " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Customer"
        Me.NewCreateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewCreateBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.NewCreateBtn.UseVisualStyleBackColor = True
        '
        'CreateAccountPanel
        '
        Me.CreateAccountPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.CreateAccountPanel.Controls.Add(Me.PictureBox1)
        Me.CreateAccountPanel.Controls.Add(Me.DOBTxt)
        Me.CreateAccountPanel.Controls.Add(Me.Panel1)
        Me.CreateAccountPanel.Controls.Add(Me.SubmitBtn)
        Me.CreateAccountPanel.Controls.Add(Me.ChooseBtn)
        Me.CreateAccountPanel.Controls.Add(Me.ProfilePic)
        Me.CreateAccountPanel.Controls.Add(Me.Label9)
        Me.CreateAccountPanel.Controls.Add(Me.InitBalTxt)
        Me.CreateAccountPanel.Controls.Add(Me.Label8)
        Me.CreateAccountPanel.Controls.Add(Me.AddressTxt)
        Me.CreateAccountPanel.Controls.Add(Me.Label7)
        Me.CreateAccountPanel.Controls.Add(Me.EmailIDTxt)
        Me.CreateAccountPanel.Controls.Add(Me.Label6)
        Me.CreateAccountPanel.Controls.Add(Me.PhoneNoTxt)
        Me.CreateAccountPanel.Controls.Add(Me.Label5)
        Me.CreateAccountPanel.Controls.Add(Me.CurrentRB)
        Me.CreateAccountPanel.Controls.Add(Me.SavingsRB)
        Me.CreateAccountPanel.Controls.Add(Me.Label4)
        Me.CreateAccountPanel.Controls.Add(Me.Label3)
        Me.CreateAccountPanel.Controls.Add(Me.Label2)
        Me.CreateAccountPanel.Controls.Add(Me.NameTxt)
        Me.CreateAccountPanel.Controls.Add(Me.Label1)
        Me.CreateAccountPanel.Controls.Add(Me.AccNoTxt)
        Me.CreateAccountPanel.Font = New System.Drawing.Font("Agency FB", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreateAccountPanel.ForeColor = System.Drawing.Color.White
        Me.ErrorProviderX.SetIconPadding(Me.CreateAccountPanel, 10)
        Me.CreateAccountPanel.Location = New System.Drawing.Point(103, 3)
        Me.CreateAccountPanel.Name = "CreateAccountPanel"
        Me.CreateAccountPanel.Size = New System.Drawing.Size(735, 656)
        Me.CreateAccountPanel.TabIndex = 25
        Me.CreateAccountPanel.TabStop = False
        Me.CreateAccountPanel.Text = "Create Account"
        Me.CreateAccountPanel.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.BancoSeguro.My.Resources.Resources.copy_40px
        Me.PictureBox1.Location = New System.Drawing.Point(361, 54)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(36, 38)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'DOBTxt
        '
        Me.DOBTxt.Font = New System.Drawing.Font("Agency FB", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ErrorProviderX.SetIconPadding(Me.DOBTxt, 10)
        Me.DOBTxt.Location = New System.Drawing.Point(244, 278)
        Me.DOBTxt.Name = "DOBTxt"
        Me.DOBTxt.Size = New System.Drawing.Size(183, 37)
        Me.DOBTxt.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.Controls.Add(Me.MaleRB)
        Me.Panel1.Controls.Add(Me.FemaleRB)
        Me.Panel1.Location = New System.Drawing.Point(244, 212)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(249, 56)
        Me.Panel1.TabIndex = 22
        '
        'MaleRB
        '
        Me.MaleRB.AutoSize = True
        Me.MaleRB.Checked = True
        Me.MaleRB.Location = New System.Drawing.Point(0, 8)
        Me.MaleRB.Name = "MaleRB"
        Me.MaleRB.Size = New System.Drawing.Size(91, 45)
        Me.MaleRB.TabIndex = 24
        Me.MaleRB.TabStop = True
        Me.MaleRB.Text = "Male"
        Me.MaleRB.UseVisualStyleBackColor = True
        '
        'FemaleRB
        '
        Me.FemaleRB.AutoSize = True
        Me.FemaleRB.Location = New System.Drawing.Point(132, 8)
        Me.FemaleRB.Name = "FemaleRB"
        Me.FemaleRB.Size = New System.Drawing.Size(114, 45)
        Me.FemaleRB.TabIndex = 25
        Me.FemaleRB.Text = "Female"
        Me.FemaleRB.UseVisualStyleBackColor = True
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
        Me.SubmitBtn.Location = New System.Drawing.Point(244, 560)
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
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label9.Location = New System.Drawing.Point(47, 495)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(184, 41)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Initial Balance :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'InitBalTxt
        '
        Me.InitBalTxt.Font = New System.Drawing.Font("Agency FB", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ErrorProviderX.SetIconPadding(Me.InitBalTxt, 10)
        Me.InitBalTxt.Location = New System.Drawing.Point(244, 495)
        Me.InitBalTxt.Name = "InitBalTxt"
        Me.InitBalTxt.Size = New System.Drawing.Size(183, 37)
        Me.InitBalTxt.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label8.Location = New System.Drawing.Point(109, 440)
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
        Me.AddressTxt.Location = New System.Drawing.Point(244, 440)
        Me.AddressTxt.Name = "AddressTxt"
        Me.AddressTxt.Size = New System.Drawing.Size(183, 37)
        Me.AddressTxt.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label7.Location = New System.Drawing.Point(109, 385)
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
        Me.EmailIDTxt.Location = New System.Drawing.Point(244, 385)
        Me.EmailIDTxt.Name = "EmailIDTxt"
        Me.EmailIDTxt.Size = New System.Drawing.Size(183, 37)
        Me.EmailIDTxt.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label6.Location = New System.Drawing.Point(94, 330)
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
        Me.PhoneNoTxt.Location = New System.Drawing.Point(244, 330)
        Me.PhoneNoTxt.Name = "PhoneNoTxt"
        Me.PhoneNoTxt.Size = New System.Drawing.Size(183, 37)
        Me.PhoneNoTxt.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label5.Location = New System.Drawing.Point(56, 275)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(173, 41)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Date Of Birth :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'CurrentRB
        '
        Me.CurrentRB.AutoSize = True
        Me.CurrentRB.Location = New System.Drawing.Point(374, 106)
        Me.CurrentRB.Name = "CurrentRB"
        Me.CurrentRB.Size = New System.Drawing.Size(126, 45)
        Me.CurrentRB.TabIndex = 17
        Me.CurrentRB.Text = "Current"
        Me.CurrentRB.UseVisualStyleBackColor = True
        '
        'SavingsRB
        '
        Me.SavingsRB.AutoSize = True
        Me.SavingsRB.Checked = True
        Me.SavingsRB.Location = New System.Drawing.Point(242, 106)
        Me.SavingsRB.Name = "SavingsRB"
        Me.SavingsRB.Size = New System.Drawing.Size(125, 45)
        Me.SavingsRB.TabIndex = 15
        Me.SavingsRB.TabStop = True
        Me.SavingsRB.Text = "Savings"
        Me.SavingsRB.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label4.Location = New System.Drawing.Point(54, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(175, 41)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Account Type :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label3.Location = New System.Drawing.Point(118, 220)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 41)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Gender :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label2.Location = New System.Drawing.Point(94, 165)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 41)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Full Name :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'NameTxt
        '
        Me.NameTxt.Font = New System.Drawing.Font("Agency FB", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ErrorProviderX.SetIconPadding(Me.NameTxt, 10)
        Me.NameTxt.Location = New System.Drawing.Point(244, 165)
        Me.NameTxt.Name = "NameTxt"
        Me.NameTxt.Size = New System.Drawing.Size(183, 37)
        Me.NameTxt.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Location = New System.Drawing.Point(17, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(212, 41)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Account Number :"
        '
        'AccNoTxt
        '
        Me.AccNoTxt.Enabled = False
        Me.AccNoTxt.Font = New System.Drawing.Font("Agency FB", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ErrorProviderX.SetIconPadding(Me.AccNoTxt, 10)
        Me.AccNoTxt.Location = New System.Drawing.Point(244, 55)
        Me.AccNoTxt.Name = "AccNoTxt"
        Me.AccNoTxt.ReadOnly = True
        Me.AccNoTxt.Size = New System.Drawing.Size(111, 37)
        Me.AccNoTxt.TabIndex = 20
        '
        'ErrorProviderX
        '
        Me.ErrorProviderX.ContainerControl = Me
        Me.ErrorProviderX.Icon = CType(resources.GetObject("ErrorProviderX.Icon"), System.Drawing.Icon)
        '
        'Create
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.AccPrompt)
        Me.Controls.Add(Me.CreateAccountPanel)
        Me.Name = "Create"
        Me.Size = New System.Drawing.Size(909, 658)
        Me.AccPrompt.ResumeLayout(False)
        Me.SearchAccPanel.ResumeLayout(False)
        Me.SearchAccPanel.PerformLayout()
        Me.CreateAccountPanel.ResumeLayout(False)
        Me.CreateAccountPanel.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ProfilePic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProviderX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AccPrompt As System.Windows.Forms.GroupBox
    Friend WithEvents OldCreateBtn As System.Windows.Forms.Button
    Friend WithEvents NewCreateBtn As System.Windows.Forms.Button
    Friend WithEvents CreateAccountPanel As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NameTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents AccNoTxt As System.Windows.Forms.TextBox
    Friend WithEvents FemaleRB As System.Windows.Forms.RadioButton
    Friend WithEvents MaleRB As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CurrentRB As System.Windows.Forms.RadioButton
    Friend WithEvents SavingsRB As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents InitBalTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents AddressTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents EmailIDTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PhoneNoTxt As System.Windows.Forms.TextBox
    Friend WithEvents ChooseBtn As System.Windows.Forms.Button
    Friend WithEvents SubmitBtn As System.Windows.Forms.Button
    Friend WithEvents ErrorProviderX As System.Windows.Forms.ErrorProvider
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Public WithEvents ProfilePic As System.Windows.Forms.PictureBox
    Friend WithEvents SearchAccPanel As System.Windows.Forms.GroupBox
    Friend WithEvents AccSearchBox As System.Windows.Forms.TextBox
    Friend WithEvents SearchBtn As System.Windows.Forms.Button
    Friend WithEvents DOBTxt As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
