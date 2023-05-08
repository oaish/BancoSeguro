<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Loan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Loan))
        Me.TabSpace = New System.Windows.Forms.Panel()
        Me.LogoutBtn = New System.Windows.Forms.Button()
        Me.RecordsBtn = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.LoanBtn = New System.Windows.Forms.Button()
        Me.BankName = New System.Windows.Forms.Label()
        Me.BankLogo = New System.Windows.Forms.Panel()
        Me.DashBoardPanel = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RecordsPanel = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LoanPanel = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BackBtn = New System.Windows.Forms.PictureBox()
        Me.MinimizeBtn = New System.Windows.Forms.PictureBox()
        Me.CloseBtn = New System.Windows.Forms.Button()
        Me.SidePanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.TabSpace.SuspendLayout()
        Me.DashBoardPanel.SuspendLayout()
        Me.RecordsPanel.SuspendLayout()
        Me.LoanPanel.SuspendLayout()
        CType(Me.BackBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MinimizeBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabSpace
        '
        Me.TabSpace.BackColor = System.Drawing.Color.Transparent
        Me.TabSpace.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabSpace.Controls.Add(Me.LogoutBtn)
        Me.TabSpace.Controls.Add(Me.RecordsBtn)
        Me.TabSpace.Controls.Add(Me.FlowLayoutPanel1)
        Me.TabSpace.Controls.Add(Me.SidePanel)
        Me.TabSpace.Controls.Add(Me.LoanBtn)
        Me.TabSpace.Controls.Add(Me.BankName)
        Me.TabSpace.Controls.Add(Me.BankLogo)
        Me.TabSpace.Dock = System.Windows.Forms.DockStyle.Left
        Me.TabSpace.Location = New System.Drawing.Point(0, 0)
        Me.TabSpace.Name = "TabSpace"
        Me.TabSpace.Size = New System.Drawing.Size(237, 720)
        Me.TabSpace.TabIndex = 17
        '
        'LogoutBtn
        '
        Me.LogoutBtn.BackColor = System.Drawing.Color.Transparent
        Me.LogoutBtn.FlatAppearance.BorderSize = 0
        Me.LogoutBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.LogoutBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.LogoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LogoutBtn.Font = New System.Drawing.Font("Agency FB", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogoutBtn.ForeColor = System.Drawing.SystemColors.Window
        Me.LogoutBtn.Image = Global.BancoSeguro.My.Resources.Resources.logout30x
        Me.LogoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LogoutBtn.Location = New System.Drawing.Point(38, 355)
        Me.LogoutBtn.Name = "LogoutBtn"
        Me.LogoutBtn.Size = New System.Drawing.Size(192, 50)
        Me.LogoutBtn.TabIndex = 7
        Me.LogoutBtn.Text = "Logout"
        Me.LogoutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LogoutBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.LogoutBtn.UseVisualStyleBackColor = True
        '
        'RecordsBtn
        '
        Me.RecordsBtn.BackColor = System.Drawing.Color.Transparent
        Me.RecordsBtn.FlatAppearance.BorderSize = 0
        Me.RecordsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.RecordsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.RecordsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RecordsBtn.Font = New System.Drawing.Font("Agency FB", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecordsBtn.ForeColor = System.Drawing.SystemColors.Window
        Me.RecordsBtn.Image = Global.BancoSeguro.My.Resources.Resources.database30x
        Me.RecordsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RecordsBtn.Location = New System.Drawing.Point(38, 299)
        Me.RecordsBtn.Name = "RecordsBtn"
        Me.RecordsBtn.Size = New System.Drawing.Size(192, 50)
        Me.RecordsBtn.TabIndex = 5
        Me.RecordsBtn.Text = "Records"
        Me.RecordsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RecordsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.RecordsBtn.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.SystemColors.Control
        Me.FlowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(23, 135)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(192, 14)
        Me.FlowLayoutPanel1.TabIndex = 3
        '
        'LoanBtn
        '
        Me.LoanBtn.BackColor = System.Drawing.Color.Transparent
        Me.LoanBtn.FlatAppearance.BorderSize = 0
        Me.LoanBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.LoanBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.LoanBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LoanBtn.Font = New System.Drawing.Font("Agency FB", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoanBtn.ForeColor = System.Drawing.SystemColors.Window
        Me.LoanBtn.Image = Global.BancoSeguro.My.Resources.Resources.loan30x
        Me.LoanBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LoanBtn.Location = New System.Drawing.Point(38, 243)
        Me.LoanBtn.Name = "LoanBtn"
        Me.LoanBtn.Size = New System.Drawing.Size(192, 50)
        Me.LoanBtn.TabIndex = 1
        Me.LoanBtn.Text = "Loan"
        Me.LoanBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LoanBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.LoanBtn.UseVisualStyleBackColor = True
        '
        'BankName
        '
        Me.BankName.AutoSize = True
        Me.BankName.BackColor = System.Drawing.Color.Transparent
        Me.BankName.Font = New System.Drawing.Font("Agency FB", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BankName.ForeColor = System.Drawing.SystemColors.Window
        Me.BankName.Location = New System.Drawing.Point(127, 42)
        Me.BankName.Name = "BankName"
        Me.BankName.Size = New System.Drawing.Size(96, 78)
        Me.BankName.TabIndex = 11
        Me.BankName.Text = "Banco " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Seguro"
        '
        'BankLogo
        '
        Me.BankLogo.BackColor = System.Drawing.Color.Transparent
        Me.BankLogo.BackgroundImage = Global.BancoSeguro.My.Resources.Resources.Logo
        Me.BankLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BankLogo.Location = New System.Drawing.Point(23, 26)
        Me.BankLogo.Name = "BankLogo"
        Me.BankLogo.Size = New System.Drawing.Size(98, 96)
        Me.BankLogo.TabIndex = 10
        '
        'DashBoardPanel
        '
        Me.DashBoardPanel.BackColor = System.Drawing.Color.Transparent
        Me.DashBoardPanel.Controls.Add(Me.Label3)
        Me.DashBoardPanel.Location = New System.Drawing.Point(237, 60)
        Me.DashBoardPanel.Name = "DashBoardPanel"
        Me.DashBoardPanel.Size = New System.Drawing.Size(911, 660)
        Me.DashBoardPanel.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Agency FB", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(47, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(176, 51)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Dashboard"
        '
        'RecordsPanel
        '
        Me.RecordsPanel.BackColor = System.Drawing.Color.Transparent
        Me.RecordsPanel.Controls.Add(Me.Label1)
        Me.RecordsPanel.Location = New System.Drawing.Point(237, 60)
        Me.RecordsPanel.Name = "RecordsPanel"
        Me.RecordsPanel.Size = New System.Drawing.Size(911, 660)
        Me.RecordsPanel.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Agency FB", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(47, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 51)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Records"
        '
        'LoanPanel
        '
        Me.LoanPanel.BackColor = System.Drawing.Color.Transparent
        Me.LoanPanel.BackgroundImage = Global.BancoSeguro.My.Resources.Resources.AppBGBlur
        Me.LoanPanel.Controls.Add(Me.Button2)
        Me.LoanPanel.Controls.Add(Me.Button1)
        Me.LoanPanel.Controls.Add(Me.Label2)
        Me.LoanPanel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LoanPanel.Location = New System.Drawing.Point(237, 60)
        Me.LoanPanel.Name = "LoanPanel"
        Me.LoanPanel.Size = New System.Drawing.Size(911, 660)
        Me.LoanPanel.TabIndex = 13
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Agency FB", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.AliceBlue
        Me.Button2.Image = Global.BancoSeguro.My.Resources.Resources.AppBGLowRez
        Me.Button2.Location = New System.Drawing.Point(201, 228)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(200, 140)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Home Loan"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.BackgroundImage = Global.BancoSeguro.My.Resources.Resources.AppBGLowRez
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Agency FB", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1.Image = Global.BancoSeguro.My.Resources.Resources.AppBG
        Me.Button1.Location = New System.Drawing.Point(475, 228)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(200, 140)
        Me.Button1.TabIndex = 2
        Me.Button1.TabStop = False
        Me.Button1.Text = "Emi Calculator"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Agency FB", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(47, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 51)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Loan"
        '
        'BackBtn
        '
        Me.BackBtn.BackColor = System.Drawing.Color.Transparent
        Me.BackBtn.Image = Global.BancoSeguro.My.Resources.Resources.back_40px
        Me.BackBtn.Location = New System.Drawing.Point(256, 11)
        Me.BackBtn.Name = "BackBtn"
        Me.BackBtn.Size = New System.Drawing.Size(37, 36)
        Me.BackBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BackBtn.TabIndex = 21
        Me.BackBtn.TabStop = False
        Me.BackBtn.Visible = False
        '
        'MinimizeBtn
        '
        Me.MinimizeBtn.Image = CType(resources.GetObject("MinimizeBtn.Image"), System.Drawing.Image)
        Me.MinimizeBtn.Location = New System.Drawing.Point(1040, 11)
        Me.MinimizeBtn.Name = "MinimizeBtn"
        Me.MinimizeBtn.Size = New System.Drawing.Size(37, 36)
        Me.MinimizeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.MinimizeBtn.TabIndex = 18
        Me.MinimizeBtn.TabStop = False
        '
        'CloseBtn
        '
        Me.CloseBtn.BackColor = System.Drawing.Color.Transparent
        Me.CloseBtn.FlatAppearance.BorderSize = 0
        Me.CloseBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.CloseBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseBtn.Font = New System.Drawing.Font("Agency FB", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseBtn.ForeColor = System.Drawing.SystemColors.Window
        Me.CloseBtn.Image = CType(resources.GetObject("CloseBtn.Image"), System.Drawing.Image)
        Me.CloseBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CloseBtn.Location = New System.Drawing.Point(1083, 6)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(57, 45)
        Me.CloseBtn.TabIndex = 20
        Me.CloseBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CloseBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CloseBtn.UseVisualStyleBackColor = True
        '
        'SidePanel
        '
        Me.SidePanel.BackColor = System.Drawing.SystemColors.Control
        Me.SidePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SidePanel.Location = New System.Drawing.Point(23, 191)
        Me.SidePanel.Name = "SidePanel"
        Me.SidePanel.Size = New System.Drawing.Size(15, 50)
        Me.SidePanel.TabIndex = 2
        '
        'Loan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1148, 720)
        Me.Controls.Add(Me.LoanPanel)
        Me.Controls.Add(Me.TabSpace)
        Me.Controls.Add(Me.BackBtn)
        Me.Controls.Add(Me.MinimizeBtn)
        Me.Controls.Add(Me.CloseBtn)
        Me.Controls.Add(Me.DashBoardPanel)
        Me.Controls.Add(Me.RecordsPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Loan"
        Me.Text = "Loan"
        Me.TabSpace.ResumeLayout(False)
        Me.TabSpace.PerformLayout()
        Me.DashBoardPanel.ResumeLayout(False)
        Me.DashBoardPanel.PerformLayout()
        Me.RecordsPanel.ResumeLayout(False)
        Me.RecordsPanel.PerformLayout()
        Me.LoanPanel.ResumeLayout(False)
        Me.LoanPanel.PerformLayout()
        CType(Me.BackBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MinimizeBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabSpace As System.Windows.Forms.Panel
    Friend WithEvents LogoutBtn As System.Windows.Forms.Button
    Friend WithEvents RecordsBtn As System.Windows.Forms.Button
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents LoanBtn As System.Windows.Forms.Button
    Friend WithEvents BankName As System.Windows.Forms.Label
    Friend WithEvents BankLogo As System.Windows.Forms.Panel
    Friend WithEvents BackBtn As System.Windows.Forms.PictureBox
    Friend WithEvents MinimizeBtn As System.Windows.Forms.PictureBox
    Friend WithEvents CloseBtn As System.Windows.Forms.Button
    Friend WithEvents DashBoardPanel As System.Windows.Forms.Panel
    Friend WithEvents LoanPanel As System.Windows.Forms.Panel
    Friend WithEvents RecordsPanel As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents SidePanel As System.Windows.Forms.FlowLayoutPanel
End Class
