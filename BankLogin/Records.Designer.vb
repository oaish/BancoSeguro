<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Records
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Records))
        Me.CustFiltersGB = New System.Windows.Forms.GroupBox()
        Me.SelectAllBtn = New System.Windows.Forms.Button()
        Me.NextBtn = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.RowLmtTxt = New System.Windows.Forms.TextBox()
        Me.AccBalCB = New System.Windows.Forms.CheckBox()
        Me.AccTypeCB = New System.Windows.Forms.CheckBox()
        Me.ShowAccCB = New System.Windows.Forms.CheckBox()
        Me.AddressCB = New System.Windows.Forms.CheckBox()
        Me.EmailCB = New System.Windows.Forms.CheckBox()
        Me.PhoneCB = New System.Windows.Forms.CheckBox()
        Me.DOBCB = New System.Windows.Forms.CheckBox()
        Me.GenderCB = New System.Windows.Forms.CheckBox()
        Me.ErrorProviderX = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ERowLmtTxt = New System.Windows.Forms.TextBox()
        Me.EmpFiltersGB = New System.Windows.Forms.GroupBox()
        Me.PassCB = New System.Windows.Forms.CheckBox()
        Me.UserCB = New System.Windows.Forms.CheckBox()
        Me.LoginCB = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RoleCB = New System.Windows.Forms.ComboBox()
        Me.ESelectAllBtn = New System.Windows.Forms.Button()
        Me.ENextBtn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.EAddressCB = New System.Windows.Forms.CheckBox()
        Me.EEmailCB = New System.Windows.Forms.CheckBox()
        Me.EPhoneCB = New System.Windows.Forms.CheckBox()
        Me.EDOBCB = New System.Windows.Forms.CheckBox()
        Me.EPosCB = New System.Windows.Forms.CheckBox()
        Me.EmpRecordBtn = New System.Windows.Forms.Button()
        Me.CustRecordBtn = New System.Windows.Forms.Button()
        Me.RecordsGridView = New System.Windows.Forms.DataGridView()
        Me.CustFiltersGB.SuspendLayout()
        CType(Me.ErrorProviderX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EmpFiltersGB.SuspendLayout()
        CType(Me.RecordsGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CustFiltersGB
        '
        Me.CustFiltersGB.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.CustFiltersGB.Controls.Add(Me.SelectAllBtn)
        Me.CustFiltersGB.Controls.Add(Me.NextBtn)
        Me.CustFiltersGB.Controls.Add(Me.Label7)
        Me.CustFiltersGB.Controls.Add(Me.RowLmtTxt)
        Me.CustFiltersGB.Controls.Add(Me.AccBalCB)
        Me.CustFiltersGB.Controls.Add(Me.AccTypeCB)
        Me.CustFiltersGB.Controls.Add(Me.ShowAccCB)
        Me.CustFiltersGB.Controls.Add(Me.AddressCB)
        Me.CustFiltersGB.Controls.Add(Me.EmailCB)
        Me.CustFiltersGB.Controls.Add(Me.PhoneCB)
        Me.CustFiltersGB.Controls.Add(Me.DOBCB)
        Me.CustFiltersGB.Controls.Add(Me.GenderCB)
        Me.CustFiltersGB.Font = New System.Drawing.Font("Agency FB", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustFiltersGB.ForeColor = System.Drawing.Color.White
        Me.CustFiltersGB.Location = New System.Drawing.Point(211, 61)
        Me.CustFiltersGB.Name = "CustFiltersGB"
        Me.CustFiltersGB.Size = New System.Drawing.Size(656, 541)
        Me.CustFiltersGB.TabIndex = 10
        Me.CustFiltersGB.TabStop = False
        Me.CustFiltersGB.Text = "Filters - Customer"
        Me.CustFiltersGB.Visible = False
        '
        'SelectAllBtn
        '
        Me.SelectAllBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SelectAllBtn.FlatAppearance.BorderSize = 2
        Me.SelectAllBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.SelectAllBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.SelectAllBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SelectAllBtn.Font = New System.Drawing.Font("Agency FB", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelectAllBtn.ForeColor = System.Drawing.Color.White
        Me.SelectAllBtn.Image = Global.BancoSeguro.My.Resources.Resources.check_all_30px
        Me.SelectAllBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SelectAllBtn.Location = New System.Drawing.Point(154, 414)
        Me.SelectAllBtn.Name = "SelectAllBtn"
        Me.SelectAllBtn.Size = New System.Drawing.Size(150, 57)
        Me.SelectAllBtn.TabIndex = 25
        Me.SelectAllBtn.Text = "Select All"
        Me.SelectAllBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SelectAllBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.SelectAllBtn.UseVisualStyleBackColor = True
        '
        'NextBtn
        '
        Me.NextBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.NextBtn.FlatAppearance.BorderSize = 2
        Me.NextBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.NextBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.NextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NextBtn.Font = New System.Drawing.Font("Agency FB", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NextBtn.ForeColor = System.Drawing.Color.White
        Me.NextBtn.Image = CType(resources.GetObject("NextBtn.Image"), System.Drawing.Image)
        Me.NextBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.NextBtn.Location = New System.Drawing.Point(325, 414)
        Me.NextBtn.Name = "NextBtn"
        Me.NextBtn.Size = New System.Drawing.Size(127, 57)
        Me.NextBtn.TabIndex = 24
        Me.NextBtn.Text = "Next"
        Me.NextBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NextBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.NextBtn.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label7.Location = New System.Drawing.Point(42, 310)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(137, 41)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Row Limit :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'RowLmtTxt
        '
        Me.RowLmtTxt.Font = New System.Drawing.Font("Agency FB", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ErrorProviderX.SetIconPadding(Me.RowLmtTxt, 10)
        Me.RowLmtTxt.Location = New System.Drawing.Point(192, 311)
        Me.RowLmtTxt.Name = "RowLmtTxt"
        Me.RowLmtTxt.Size = New System.Drawing.Size(67, 37)
        Me.RowLmtTxt.TabIndex = 17
        '
        'AccBalCB
        '
        Me.AccBalCB.AutoSize = True
        Me.AccBalCB.Enabled = False
        Me.AccBalCB.Location = New System.Drawing.Point(75, 204)
        Me.AccBalCB.Name = "AccBalCB"
        Me.AccBalCB.Size = New System.Drawing.Size(127, 45)
        Me.AccBalCB.TabIndex = 7
        Me.AccBalCB.Text = "Balance"
        Me.AccBalCB.UseVisualStyleBackColor = True
        '
        'AccTypeCB
        '
        Me.AccTypeCB.AutoSize = True
        Me.AccTypeCB.Enabled = False
        Me.AccTypeCB.Location = New System.Drawing.Point(75, 153)
        Me.AccTypeCB.Name = "AccTypeCB"
        Me.AccTypeCB.Size = New System.Drawing.Size(184, 45)
        Me.AccTypeCB.TabIndex = 6
        Me.AccTypeCB.Text = "Account Type"
        Me.AccTypeCB.UseVisualStyleBackColor = True
        '
        'ShowAccCB
        '
        Me.ShowAccCB.AutoSize = True
        Me.ShowAccCB.Location = New System.Drawing.Point(49, 102)
        Me.ShowAccCB.Name = "ShowAccCB"
        Me.ShowAccCB.Size = New System.Drawing.Size(335, 45)
        Me.ShowAccCB.TabIndex = 5
        Me.ShowAccCB.Text = "Show Associated Accounts"
        Me.ShowAccCB.UseVisualStyleBackColor = True
        '
        'AddressCB
        '
        Me.AddressCB.AutoSize = True
        Me.AddressCB.Location = New System.Drawing.Point(462, 306)
        Me.AddressCB.Name = "AddressCB"
        Me.AddressCB.Size = New System.Drawing.Size(131, 45)
        Me.AddressCB.TabIndex = 4
        Me.AddressCB.Text = "Address"
        Me.AddressCB.UseVisualStyleBackColor = True
        '
        'EmailCB
        '
        Me.EmailCB.AutoSize = True
        Me.EmailCB.Location = New System.Drawing.Point(462, 255)
        Me.EmailCB.Name = "EmailCB"
        Me.EmailCB.Size = New System.Drawing.Size(99, 45)
        Me.EmailCB.TabIndex = 3
        Me.EmailCB.Text = "Email"
        Me.EmailCB.UseVisualStyleBackColor = True
        '
        'PhoneCB
        '
        Me.PhoneCB.AutoSize = True
        Me.PhoneCB.Location = New System.Drawing.Point(462, 204)
        Me.PhoneCB.Name = "PhoneCB"
        Me.PhoneCB.Size = New System.Drawing.Size(108, 45)
        Me.PhoneCB.TabIndex = 2
        Me.PhoneCB.Text = "Phone"
        Me.PhoneCB.UseVisualStyleBackColor = True
        '
        'DOBCB
        '
        Me.DOBCB.AutoSize = True
        Me.DOBCB.Location = New System.Drawing.Point(462, 153)
        Me.DOBCB.Name = "DOBCB"
        Me.DOBCB.Size = New System.Drawing.Size(88, 45)
        Me.DOBCB.TabIndex = 1
        Me.DOBCB.Text = "DOB"
        Me.DOBCB.UseVisualStyleBackColor = True
        '
        'GenderCB
        '
        Me.GenderCB.AutoSize = True
        Me.GenderCB.Location = New System.Drawing.Point(462, 102)
        Me.GenderCB.Name = "GenderCB"
        Me.GenderCB.Size = New System.Drawing.Size(120, 45)
        Me.GenderCB.TabIndex = 0
        Me.GenderCB.Text = "Gender"
        Me.GenderCB.UseVisualStyleBackColor = True
        '
        'ErrorProviderX
        '
        Me.ErrorProviderX.ContainerControl = Me
        Me.ErrorProviderX.Icon = CType(resources.GetObject("ErrorProviderX.Icon"), System.Drawing.Icon)
        '
        'ERowLmtTxt
        '
        Me.ERowLmtTxt.Font = New System.Drawing.Font("Agency FB", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ErrorProviderX.SetIconPadding(Me.ERowLmtTxt, 10)
        Me.ERowLmtTxt.Location = New System.Drawing.Point(192, 311)
        Me.ERowLmtTxt.Name = "ERowLmtTxt"
        Me.ERowLmtTxt.Size = New System.Drawing.Size(67, 37)
        Me.ERowLmtTxt.TabIndex = 17
        '
        'EmpFiltersGB
        '
        Me.EmpFiltersGB.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.EmpFiltersGB.Controls.Add(Me.PassCB)
        Me.EmpFiltersGB.Controls.Add(Me.UserCB)
        Me.EmpFiltersGB.Controls.Add(Me.LoginCB)
        Me.EmpFiltersGB.Controls.Add(Me.Label2)
        Me.EmpFiltersGB.Controls.Add(Me.RoleCB)
        Me.EmpFiltersGB.Controls.Add(Me.ESelectAllBtn)
        Me.EmpFiltersGB.Controls.Add(Me.ENextBtn)
        Me.EmpFiltersGB.Controls.Add(Me.Label3)
        Me.EmpFiltersGB.Controls.Add(Me.ERowLmtTxt)
        Me.EmpFiltersGB.Controls.Add(Me.EAddressCB)
        Me.EmpFiltersGB.Controls.Add(Me.EEmailCB)
        Me.EmpFiltersGB.Controls.Add(Me.EPhoneCB)
        Me.EmpFiltersGB.Controls.Add(Me.EDOBCB)
        Me.EmpFiltersGB.Controls.Add(Me.EPosCB)
        Me.EmpFiltersGB.Font = New System.Drawing.Font("Agency FB", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpFiltersGB.ForeColor = System.Drawing.Color.White
        Me.EmpFiltersGB.Location = New System.Drawing.Point(211, 61)
        Me.EmpFiltersGB.Name = "EmpFiltersGB"
        Me.EmpFiltersGB.Size = New System.Drawing.Size(656, 541)
        Me.EmpFiltersGB.TabIndex = 11
        Me.EmpFiltersGB.TabStop = False
        Me.EmpFiltersGB.Text = "Filters - Employee"
        Me.EmpFiltersGB.Visible = False
        '
        'PassCB
        '
        Me.PassCB.AutoSize = True
        Me.PassCB.Enabled = False
        Me.PassCB.Location = New System.Drawing.Point(75, 194)
        Me.PassCB.Name = "PassCB"
        Me.PassCB.Size = New System.Drawing.Size(153, 45)
        Me.PassCB.TabIndex = 30
        Me.PassCB.Text = "Password"
        Me.PassCB.UseVisualStyleBackColor = True
        '
        'UserCB
        '
        Me.UserCB.AutoSize = True
        Me.UserCB.Enabled = False
        Me.UserCB.Location = New System.Drawing.Point(75, 143)
        Me.UserCB.Name = "UserCB"
        Me.UserCB.Size = New System.Drawing.Size(153, 45)
        Me.UserCB.TabIndex = 29
        Me.UserCB.Text = "Username"
        Me.UserCB.UseVisualStyleBackColor = True
        '
        'LoginCB
        '
        Me.LoginCB.AutoSize = True
        Me.LoginCB.Location = New System.Drawing.Point(49, 92)
        Me.LoginCB.Name = "LoginCB"
        Me.LoginCB.Size = New System.Drawing.Size(297, 45)
        Me.LoginCB.TabIndex = 28
        Me.LoginCB.Text = "Show Login Credentials"
        Me.LoginCB.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label2.Location = New System.Drawing.Point(42, 257)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 41)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Role : "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'RoleCB
        '
        Me.RoleCB.Font = New System.Drawing.Font("Agency FB", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoleCB.FormattingEnabled = True
        Me.RoleCB.Items.AddRange(New Object() {"Admin", "Bank Teller", "Loan Officer"})
        Me.RoleCB.Location = New System.Drawing.Point(192, 255)
        Me.RoleCB.Name = "RoleCB"
        Me.RoleCB.Size = New System.Drawing.Size(121, 39)
        Me.RoleCB.TabIndex = 26
        '
        'ESelectAllBtn
        '
        Me.ESelectAllBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ESelectAllBtn.FlatAppearance.BorderSize = 2
        Me.ESelectAllBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.ESelectAllBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.ESelectAllBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ESelectAllBtn.Font = New System.Drawing.Font("Agency FB", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ESelectAllBtn.ForeColor = System.Drawing.Color.White
        Me.ESelectAllBtn.Image = Global.BancoSeguro.My.Resources.Resources.check_all_30px
        Me.ESelectAllBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ESelectAllBtn.Location = New System.Drawing.Point(154, 414)
        Me.ESelectAllBtn.Name = "ESelectAllBtn"
        Me.ESelectAllBtn.Size = New System.Drawing.Size(150, 57)
        Me.ESelectAllBtn.TabIndex = 25
        Me.ESelectAllBtn.Text = "Select All"
        Me.ESelectAllBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ESelectAllBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ESelectAllBtn.UseVisualStyleBackColor = True
        '
        'ENextBtn
        '
        Me.ENextBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ENextBtn.FlatAppearance.BorderSize = 2
        Me.ENextBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.ENextBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.ENextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ENextBtn.Font = New System.Drawing.Font("Agency FB", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ENextBtn.ForeColor = System.Drawing.Color.White
        Me.ENextBtn.Image = CType(resources.GetObject("ENextBtn.Image"), System.Drawing.Image)
        Me.ENextBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ENextBtn.Location = New System.Drawing.Point(325, 414)
        Me.ENextBtn.Name = "ENextBtn"
        Me.ENextBtn.Size = New System.Drawing.Size(127, 57)
        Me.ENextBtn.TabIndex = 24
        Me.ENextBtn.Text = "Next"
        Me.ENextBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ENextBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ENextBtn.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label3.Location = New System.Drawing.Point(42, 310)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 41)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Row Limit :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'EAddressCB
        '
        Me.EAddressCB.AutoSize = True
        Me.EAddressCB.Location = New System.Drawing.Point(462, 306)
        Me.EAddressCB.Name = "EAddressCB"
        Me.EAddressCB.Size = New System.Drawing.Size(131, 45)
        Me.EAddressCB.TabIndex = 4
        Me.EAddressCB.Text = "Address"
        Me.EAddressCB.UseVisualStyleBackColor = True
        '
        'EEmailCB
        '
        Me.EEmailCB.AutoSize = True
        Me.EEmailCB.Location = New System.Drawing.Point(462, 255)
        Me.EEmailCB.Name = "EEmailCB"
        Me.EEmailCB.Size = New System.Drawing.Size(99, 45)
        Me.EEmailCB.TabIndex = 3
        Me.EEmailCB.Text = "Email"
        Me.EEmailCB.UseVisualStyleBackColor = True
        '
        'EPhoneCB
        '
        Me.EPhoneCB.AutoSize = True
        Me.EPhoneCB.Location = New System.Drawing.Point(462, 204)
        Me.EPhoneCB.Name = "EPhoneCB"
        Me.EPhoneCB.Size = New System.Drawing.Size(108, 45)
        Me.EPhoneCB.TabIndex = 2
        Me.EPhoneCB.Text = "Phone"
        Me.EPhoneCB.UseVisualStyleBackColor = True
        '
        'EDOBCB
        '
        Me.EDOBCB.AutoSize = True
        Me.EDOBCB.Location = New System.Drawing.Point(462, 153)
        Me.EDOBCB.Name = "EDOBCB"
        Me.EDOBCB.Size = New System.Drawing.Size(88, 45)
        Me.EDOBCB.TabIndex = 1
        Me.EDOBCB.Text = "DOB"
        Me.EDOBCB.UseVisualStyleBackColor = True
        '
        'EPosCB
        '
        Me.EPosCB.AutoSize = True
        Me.EPosCB.Location = New System.Drawing.Point(462, 102)
        Me.EPosCB.Name = "EPosCB"
        Me.EPosCB.Size = New System.Drawing.Size(128, 45)
        Me.EPosCB.TabIndex = 0
        Me.EPosCB.Text = "Position"
        Me.EPosCB.UseVisualStyleBackColor = True
        '
        'EmpRecordBtn
        '
        Me.EmpRecordBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.EmpRecordBtn.FlatAppearance.BorderSize = 2
        Me.EmpRecordBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.EmpRecordBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.EmpRecordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EmpRecordBtn.Font = New System.Drawing.Font("Agency FB", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpRecordBtn.ForeColor = System.Drawing.Color.White
        Me.EmpRecordBtn.Image = Global.BancoSeguro.My.Resources.Resources.management_30px
        Me.EmpRecordBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.EmpRecordBtn.Location = New System.Drawing.Point(32, 141)
        Me.EmpRecordBtn.Name = "EmpRecordBtn"
        Me.EmpRecordBtn.Size = New System.Drawing.Size(151, 57)
        Me.EmpRecordBtn.TabIndex = 8
        Me.EmpRecordBtn.Text = "Employee"
        Me.EmpRecordBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EmpRecordBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.EmpRecordBtn.UseVisualStyleBackColor = True
        '
        'CustRecordBtn
        '
        Me.CustRecordBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CustRecordBtn.FlatAppearance.BorderSize = 2
        Me.CustRecordBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.CustRecordBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.CustRecordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CustRecordBtn.Font = New System.Drawing.Font("Agency FB", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustRecordBtn.ForeColor = System.Drawing.Color.White
        Me.CustRecordBtn.Image = Global.BancoSeguro.My.Resources.Resources.people_30px
        Me.CustRecordBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CustRecordBtn.Location = New System.Drawing.Point(32, 68)
        Me.CustRecordBtn.Name = "CustRecordBtn"
        Me.CustRecordBtn.Size = New System.Drawing.Size(151, 57)
        Me.CustRecordBtn.TabIndex = 7
        Me.CustRecordBtn.Text = "Customer"
        Me.CustRecordBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CustRecordBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CustRecordBtn.UseVisualStyleBackColor = True
        '
        'RecordsGridView
        '
        Me.RecordsGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.RecordsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RecordsGridView.Location = New System.Drawing.Point(211, 61)
        Me.RecordsGridView.Name = "RecordsGridView"
        Me.RecordsGridView.RowTemplate.Height = 24
        Me.RecordsGridView.Size = New System.Drawing.Size(656, 541)
        Me.RecordsGridView.TabIndex = 12
        '
        'Records
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.Transparent
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.EmpRecordBtn)
        Me.Controls.Add(Me.CustRecordBtn)
        Me.Controls.Add(Me.EmpFiltersGB)
        Me.Controls.Add(Me.CustFiltersGB)
        Me.Controls.Add(Me.RecordsGridView)
        Me.Name = "Records"
        Me.Size = New System.Drawing.Size(911, 660)
        Me.CustFiltersGB.ResumeLayout(False)
        Me.CustFiltersGB.PerformLayout()
        CType(Me.ErrorProviderX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EmpFiltersGB.ResumeLayout(False)
        Me.EmpFiltersGB.PerformLayout()
        CType(Me.RecordsGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CustRecordBtn As System.Windows.Forms.Button
    Friend WithEvents EmpRecordBtn As System.Windows.Forms.Button
    Friend WithEvents CustFiltersGB As System.Windows.Forms.GroupBox
    Friend WithEvents AddressCB As System.Windows.Forms.CheckBox
    Friend WithEvents EmailCB As System.Windows.Forms.CheckBox
    Friend WithEvents PhoneCB As System.Windows.Forms.CheckBox
    Friend WithEvents DOBCB As System.Windows.Forms.CheckBox
    Friend WithEvents GenderCB As System.Windows.Forms.CheckBox
    Friend WithEvents ShowAccCB As System.Windows.Forms.CheckBox
    Friend WithEvents AccBalCB As System.Windows.Forms.CheckBox
    Friend WithEvents AccTypeCB As System.Windows.Forms.CheckBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents RowLmtTxt As System.Windows.Forms.TextBox
    Friend WithEvents SelectAllBtn As System.Windows.Forms.Button
    Friend WithEvents NextBtn As System.Windows.Forms.Button
    Friend WithEvents ErrorProviderX As System.Windows.Forms.ErrorProvider
    Friend WithEvents query As System.Windows.Forms.Label
    Friend WithEvents EmpFiltersGB As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents RoleCB As System.Windows.Forms.ComboBox
    Friend WithEvents ESelectAllBtn As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ERowLmtTxt As System.Windows.Forms.TextBox
    Friend WithEvents EAddressCB As System.Windows.Forms.CheckBox
    Friend WithEvents EEmailCB As System.Windows.Forms.CheckBox
    Friend WithEvents EPhoneCB As System.Windows.Forms.CheckBox
    Friend WithEvents EDOBCB As System.Windows.Forms.CheckBox
    Friend WithEvents EPosCB As System.Windows.Forms.CheckBox
    Friend WithEvents PassCB As System.Windows.Forms.CheckBox
    Friend WithEvents UserCB As System.Windows.Forms.CheckBox
    Friend WithEvents LoginCB As System.Windows.Forms.CheckBox
    Friend WithEvents RecordsGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ENextBtn As System.Windows.Forms.Button

End Class
