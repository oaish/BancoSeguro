<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Update
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Update))
        Me.SearchAccPanel = New System.Windows.Forms.GroupBox()
        Me.ErrorLabel = New System.Windows.Forms.Label()
        Me.SearchBtn = New System.Windows.Forms.Button()
        Me.AccSearchBox = New System.Windows.Forms.TextBox()
        Me.UpdateAccountPanel = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.UpdateBtn = New System.Windows.Forms.Button()
        Me.DOBTxt = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MaleRB = New System.Windows.Forms.RadioButton()
        Me.FemaleRB = New System.Windows.Forms.RadioButton()
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
        Me.CurrentRB = New System.Windows.Forms.RadioButton()
        Me.SavingsRB = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NameTxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AccNoTxt = New System.Windows.Forms.TextBox()
        Me.ErrorProviderX = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.SearchAccPanel.SuspendLayout()
        Me.UpdateAccountPanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.ProfilePic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProviderX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SearchAccPanel
        '
        Me.SearchAccPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.SearchAccPanel.Controls.Add(Me.ErrorLabel)
        Me.SearchAccPanel.Controls.Add(Me.SearchBtn)
        Me.SearchAccPanel.Controls.Add(Me.AccSearchBox)
        Me.SearchAccPanel.Font = New System.Drawing.Font("Agency FB", 20.0!, System.Drawing.FontStyle.Bold)
        Me.SearchAccPanel.ForeColor = System.Drawing.Color.White
        Me.SearchAccPanel.Location = New System.Drawing.Point(272, 190)
        Me.SearchAccPanel.Name = "SearchAccPanel"
        Me.SearchAccPanel.Size = New System.Drawing.Size(364, 147)
        Me.SearchAccPanel.TabIndex = 26
        Me.SearchAccPanel.TabStop = False
        Me.SearchAccPanel.Text = "Enter Account No"
        '
        'ErrorLabel
        '
        Me.ErrorLabel.AutoSize = True
        Me.ErrorLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ErrorLabel.Font = New System.Drawing.Font("Agency FB", 15.0!)
        Me.ErrorLabel.Location = New System.Drawing.Point(17, 106)
        Me.ErrorLabel.Name = "ErrorLabel"
        Me.ErrorLabel.Size = New System.Drawing.Size(63, 29)
        Me.ErrorLabel.TabIndex = 21
        Me.ErrorLabel.Text = "Error :"
        Me.ErrorLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.ErrorLabel.Visible = False
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
        Me.SearchBtn.Image = Global.BancoSeguro.My.Resources.Resources.searchacc30x
        Me.SearchBtn.Location = New System.Drawing.Point(300, 51)
        Me.SearchBtn.Name = "SearchBtn"
        Me.SearchBtn.Size = New System.Drawing.Size(55, 50)
        Me.SearchBtn.TabIndex = 13
        Me.SearchBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.SearchBtn.UseVisualStyleBackColor = True
        '
        'AccSearchBox
        '
        Me.AccSearchBox.Font = New System.Drawing.Font("Agency FB", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccSearchBox.Location = New System.Drawing.Point(16, 52)
        Me.AccSearchBox.Name = "AccSearchBox"
        Me.AccSearchBox.Size = New System.Drawing.Size(278, 47)
        Me.AccSearchBox.TabIndex = 11
        '
        'UpdateAccountPanel
        '
        Me.UpdateAccountPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.UpdateAccountPanel.Controls.Add(Me.PictureBox1)
        Me.UpdateAccountPanel.Controls.Add(Me.UpdateBtn)
        Me.UpdateAccountPanel.Controls.Add(Me.DOBTxt)
        Me.UpdateAccountPanel.Controls.Add(Me.Panel1)
        Me.UpdateAccountPanel.Controls.Add(Me.SubmitBtn)
        Me.UpdateAccountPanel.Controls.Add(Me.ChooseBtn)
        Me.UpdateAccountPanel.Controls.Add(Me.ProfilePic)
        Me.UpdateAccountPanel.Controls.Add(Me.Label8)
        Me.UpdateAccountPanel.Controls.Add(Me.AddressTxt)
        Me.UpdateAccountPanel.Controls.Add(Me.Label7)
        Me.UpdateAccountPanel.Controls.Add(Me.EmailIDTxt)
        Me.UpdateAccountPanel.Controls.Add(Me.Label6)
        Me.UpdateAccountPanel.Controls.Add(Me.PhoneNoTxt)
        Me.UpdateAccountPanel.Controls.Add(Me.Label5)
        Me.UpdateAccountPanel.Controls.Add(Me.CurrentRB)
        Me.UpdateAccountPanel.Controls.Add(Me.SavingsRB)
        Me.UpdateAccountPanel.Controls.Add(Me.Label4)
        Me.UpdateAccountPanel.Controls.Add(Me.Label3)
        Me.UpdateAccountPanel.Controls.Add(Me.Label2)
        Me.UpdateAccountPanel.Controls.Add(Me.NameTxt)
        Me.UpdateAccountPanel.Controls.Add(Me.Label1)
        Me.UpdateAccountPanel.Controls.Add(Me.AccNoTxt)
        Me.UpdateAccountPanel.Font = New System.Drawing.Font("Agency FB", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateAccountPanel.ForeColor = System.Drawing.Color.White
        Me.UpdateAccountPanel.Location = New System.Drawing.Point(107, 3)
        Me.UpdateAccountPanel.Name = "UpdateAccountPanel"
        Me.UpdateAccountPanel.Size = New System.Drawing.Size(735, 656)
        Me.UpdateAccountPanel.TabIndex = 28
        Me.UpdateAccountPanel.TabStop = False
        Me.UpdateAccountPanel.Text = " Update Account"
        Me.UpdateAccountPanel.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.BancoSeguro.My.Resources.Resources.copy_40px
        Me.PictureBox1.Location = New System.Drawing.Point(384, 75)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(36, 38)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'UpdateBtn
        '
        Me.UpdateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UpdateBtn.FlatAppearance.BorderSize = 2
        Me.UpdateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.UpdateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UpdateBtn.Font = New System.Drawing.Font("Agency FB", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateBtn.ForeColor = System.Drawing.Color.White
        Me.UpdateBtn.Image = Global.BancoSeguro.My.Resources.Resources.edit_property_30px
        Me.UpdateBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UpdateBtn.Location = New System.Drawing.Point(175, 520)
        Me.UpdateBtn.Name = "UpdateBtn"
        Me.UpdateBtn.Size = New System.Drawing.Size(127, 57)
        Me.UpdateBtn.TabIndex = 23
        Me.UpdateBtn.Text = "Edit"
        Me.UpdateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UpdateBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.UpdateBtn.UseVisualStyleBackColor = True
        '
        'DOBTxt
        '
        Me.DOBTxt.Font = New System.Drawing.Font("Agency FB", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ErrorProviderX.SetIconPadding(Me.DOBTxt, 10)
        Me.DOBTxt.Location = New System.Drawing.Point(267, 299)
        Me.DOBTxt.Name = "DOBTxt"
        Me.DOBTxt.Size = New System.Drawing.Size(183, 37)
        Me.DOBTxt.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.Controls.Add(Me.MaleRB)
        Me.Panel1.Controls.Add(Me.FemaleRB)
        Me.Panel1.Location = New System.Drawing.Point(267, 233)
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
        Me.SubmitBtn.Image = Global.BancoSeguro.My.Resources.Resources.save30x
        Me.SubmitBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SubmitBtn.Location = New System.Drawing.Point(323, 520)
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
        Me.Label8.Location = New System.Drawing.Point(132, 461)
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
        Me.AddressTxt.Location = New System.Drawing.Point(267, 461)
        Me.AddressTxt.Name = "AddressTxt"
        Me.AddressTxt.Size = New System.Drawing.Size(183, 37)
        Me.AddressTxt.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label7.Location = New System.Drawing.Point(132, 406)
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
        Me.EmailIDTxt.Location = New System.Drawing.Point(267, 406)
        Me.EmailIDTxt.Name = "EmailIDTxt"
        Me.EmailIDTxt.Size = New System.Drawing.Size(183, 37)
        Me.EmailIDTxt.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label6.Location = New System.Drawing.Point(117, 351)
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
        Me.PhoneNoTxt.Location = New System.Drawing.Point(267, 351)
        Me.PhoneNoTxt.Name = "PhoneNoTxt"
        Me.PhoneNoTxt.Size = New System.Drawing.Size(183, 37)
        Me.PhoneNoTxt.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label5.Location = New System.Drawing.Point(79, 296)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(173, 41)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Date Of Birth :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'CurrentRB
        '
        Me.CurrentRB.AutoSize = True
        Me.CurrentRB.Location = New System.Drawing.Point(397, 127)
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
        Me.SavingsRB.Location = New System.Drawing.Point(265, 127)
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
        Me.Label4.Location = New System.Drawing.Point(77, 131)
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
        Me.Label3.Location = New System.Drawing.Point(141, 241)
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
        Me.Label2.Location = New System.Drawing.Point(117, 186)
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
        Me.NameTxt.Location = New System.Drawing.Point(267, 186)
        Me.NameTxt.Name = "NameTxt"
        Me.NameTxt.Size = New System.Drawing.Size(183, 37)
        Me.NameTxt.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Location = New System.Drawing.Point(40, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(212, 41)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Account Number :"
        '
        'AccNoTxt
        '
        Me.AccNoTxt.Font = New System.Drawing.Font("Agency FB", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccNoTxt.Location = New System.Drawing.Point(267, 76)
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
        'Update
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.SearchAccPanel)
        Me.Controls.Add(Me.UpdateAccountPanel)
        Me.Name = "Update"
        Me.Size = New System.Drawing.Size(909, 658)
        Me.SearchAccPanel.ResumeLayout(False)
        Me.SearchAccPanel.PerformLayout()
        Me.UpdateAccountPanel.ResumeLayout(False)
        Me.UpdateAccountPanel.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ProfilePic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProviderX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SearchAccPanel As System.Windows.Forms.GroupBox
    Friend WithEvents ErrorLabel As System.Windows.Forms.Label
    Friend WithEvents SearchBtn As System.Windows.Forms.Button
    Friend WithEvents AccSearchBox As System.Windows.Forms.TextBox
    Friend WithEvents UpdateAccountPanel As System.Windows.Forms.GroupBox
    Friend WithEvents UpdateBtn As System.Windows.Forms.Button
    Friend WithEvents DOBTxt As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents MaleRB As System.Windows.Forms.RadioButton
    Friend WithEvents FemaleRB As System.Windows.Forms.RadioButton
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
    Friend WithEvents CurrentRB As System.Windows.Forms.RadioButton
    Friend WithEvents SavingsRB As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NameTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents AccNoTxt As System.Windows.Forms.TextBox
    Friend WithEvents ErrorProviderX As System.Windows.Forms.ErrorProvider
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
