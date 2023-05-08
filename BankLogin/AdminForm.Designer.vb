<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminForm))
        Me.TabSpace = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.SidePanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.BankName = New System.Windows.Forms.Label()
        Me.BackBtn = New System.Windows.Forms.PictureBox()
        Me.MinimizeBtn = New System.Windows.Forms.PictureBox()
        Me.CloseBtn = New System.Windows.Forms.Button()
        Me.LogoutBtn = New System.Windows.Forms.Button()
        Me.ManageBtn = New System.Windows.Forms.Button()
        Me.RecordsBtn = New System.Windows.Forms.Button()
        Me.TransactionBtn = New System.Windows.Forms.Button()
        Me.AccountBtn = New System.Windows.Forms.Button()
        Me.BankLogo = New System.Windows.Forms.Panel()
        Me.DashboardBtn = New System.Windows.Forms.Button()
        Me.TabPanel = New System.Windows.Forms.Panel()
        Me.TabSpace.SuspendLayout()
        CType(Me.BackBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MinimizeBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabSpace
        '
        Me.TabSpace.BackColor = System.Drawing.Color.Transparent
        Me.TabSpace.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabSpace.Controls.Add(Me.LogoutBtn)
        Me.TabSpace.Controls.Add(Me.ManageBtn)
        Me.TabSpace.Controls.Add(Me.RecordsBtn)
        Me.TabSpace.Controls.Add(Me.FlowLayoutPanel1)
        Me.TabSpace.Controls.Add(Me.SidePanel)
        Me.TabSpace.Controls.Add(Me.TransactionBtn)
        Me.TabSpace.Controls.Add(Me.AccountBtn)
        Me.TabSpace.Controls.Add(Me.BankName)
        Me.TabSpace.Controls.Add(Me.BankLogo)
        Me.TabSpace.Controls.Add(Me.DashboardBtn)
        Me.TabSpace.Dock = System.Windows.Forms.DockStyle.Left
        Me.TabSpace.Location = New System.Drawing.Point(0, 0)
        Me.TabSpace.Name = "TabSpace"
        Me.TabSpace.Size = New System.Drawing.Size(237, 720)
        Me.TabSpace.TabIndex = 0
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
        'SidePanel
        '
        Me.SidePanel.BackColor = System.Drawing.SystemColors.Control
        Me.SidePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SidePanel.Location = New System.Drawing.Point(23, 191)
        Me.SidePanel.Name = "SidePanel"
        Me.SidePanel.Size = New System.Drawing.Size(15, 50)
        Me.SidePanel.TabIndex = 2
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
        'BackBtn
        '
        Me.BackBtn.BackColor = System.Drawing.Color.Transparent
        Me.BackBtn.Image = Global.BancoSeguro.My.Resources.Resources.back_40px
        Me.BackBtn.Location = New System.Drawing.Point(256, 11)
        Me.BackBtn.Name = "BackBtn"
        Me.BackBtn.Size = New System.Drawing.Size(37, 36)
        Me.BackBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BackBtn.TabIndex = 16
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
        Me.MinimizeBtn.TabIndex = 0
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
        Me.CloseBtn.TabIndex = 15
        Me.CloseBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CloseBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CloseBtn.UseVisualStyleBackColor = True
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
        Me.LogoutBtn.Location = New System.Drawing.Point(38, 451)
        Me.LogoutBtn.Name = "LogoutBtn"
        Me.LogoutBtn.Size = New System.Drawing.Size(192, 50)
        Me.LogoutBtn.TabIndex = 7
        Me.LogoutBtn.Text = "Logout"
        Me.LogoutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LogoutBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.LogoutBtn.UseVisualStyleBackColor = True
        '
        'ManageBtn
        '
        Me.ManageBtn.BackColor = System.Drawing.Color.Transparent
        Me.ManageBtn.FlatAppearance.BorderSize = 0
        Me.ManageBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.ManageBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.ManageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ManageBtn.Font = New System.Drawing.Font("Agency FB", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManageBtn.ForeColor = System.Drawing.SystemColors.Window
        Me.ManageBtn.Image = Global.BancoSeguro.My.Resources.Resources.setting30x
        Me.ManageBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ManageBtn.Location = New System.Drawing.Point(38, 399)
        Me.ManageBtn.Name = "ManageBtn"
        Me.ManageBtn.Size = New System.Drawing.Size(192, 50)
        Me.ManageBtn.TabIndex = 6
        Me.ManageBtn.Text = "Manage"
        Me.ManageBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ManageBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ManageBtn.UseVisualStyleBackColor = True
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
        Me.RecordsBtn.Location = New System.Drawing.Point(38, 347)
        Me.RecordsBtn.Name = "RecordsBtn"
        Me.RecordsBtn.Size = New System.Drawing.Size(192, 50)
        Me.RecordsBtn.TabIndex = 5
        Me.RecordsBtn.Text = "Records"
        Me.RecordsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RecordsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.RecordsBtn.UseVisualStyleBackColor = True
        '
        'TransactionBtn
        '
        Me.TransactionBtn.BackColor = System.Drawing.Color.Transparent
        Me.TransactionBtn.FlatAppearance.BorderSize = 0
        Me.TransactionBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.TransactionBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.TransactionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TransactionBtn.Font = New System.Drawing.Font("Agency FB", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TransactionBtn.ForeColor = System.Drawing.SystemColors.Window
        Me.TransactionBtn.Image = Global.BancoSeguro.My.Resources.Resources.banknotes30x
        Me.TransactionBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.TransactionBtn.Location = New System.Drawing.Point(38, 295)
        Me.TransactionBtn.Name = "TransactionBtn"
        Me.TransactionBtn.Size = New System.Drawing.Size(192, 50)
        Me.TransactionBtn.TabIndex = 2
        Me.TransactionBtn.Text = "Transaction"
        Me.TransactionBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.TransactionBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.TransactionBtn.UseVisualStyleBackColor = True
        '
        'AccountBtn
        '
        Me.AccountBtn.BackColor = System.Drawing.Color.Transparent
        Me.AccountBtn.FlatAppearance.BorderSize = 0
        Me.AccountBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.AccountBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.AccountBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AccountBtn.Font = New System.Drawing.Font("Agency FB", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccountBtn.ForeColor = System.Drawing.SystemColors.Window
        Me.AccountBtn.Image = Global.BancoSeguro.My.Resources.Resources.contact30x
        Me.AccountBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AccountBtn.Location = New System.Drawing.Point(38, 243)
        Me.AccountBtn.Name = "AccountBtn"
        Me.AccountBtn.Size = New System.Drawing.Size(192, 50)
        Me.AccountBtn.TabIndex = 1
        Me.AccountBtn.Text = "Account"
        Me.AccountBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AccountBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.AccountBtn.UseVisualStyleBackColor = True
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
        'DashboardBtn
        '
        Me.DashboardBtn.BackColor = System.Drawing.Color.Transparent
        Me.DashboardBtn.FlatAppearance.BorderSize = 0
        Me.DashboardBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.DashboardBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.DashboardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DashboardBtn.Font = New System.Drawing.Font("Agency FB", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DashboardBtn.ForeColor = System.Drawing.SystemColors.Window
        Me.DashboardBtn.Image = CType(resources.GetObject("DashboardBtn.Image"), System.Drawing.Image)
        Me.DashboardBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DashboardBtn.Location = New System.Drawing.Point(38, 191)
        Me.DashboardBtn.Name = "DashboardBtn"
        Me.DashboardBtn.Size = New System.Drawing.Size(192, 50)
        Me.DashboardBtn.TabIndex = 0
        Me.DashboardBtn.Text = "Dashboard"
        Me.DashboardBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DashboardBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.DashboardBtn.UseVisualStyleBackColor = True
        '
        'TabPanel
        '
        Me.TabPanel.BackgroundImage = Global.BancoSeguro.My.Resources.Resources.AppBGBlurRez
        Me.TabPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPanel.Location = New System.Drawing.Point(237, 60)
        Me.TabPanel.Name = "TabPanel"
        Me.TabPanel.Size = New System.Drawing.Size(911, 660)
        Me.TabPanel.TabIndex = 2
        '
        'AdminForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1148, 720)
        Me.Controls.Add(Me.BackBtn)
        Me.Controls.Add(Me.MinimizeBtn)
        Me.Controls.Add(Me.CloseBtn)
        Me.Controls.Add(Me.TabSpace)
        Me.Controls.Add(Me.TabPanel)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AdminForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = ""
        Me.Text = "AdminForm"
        Me.TabSpace.ResumeLayout(False)
        Me.TabSpace.PerformLayout()
        CType(Me.BackBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MinimizeBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabSpace As System.Windows.Forms.Panel
    Friend WithEvents DashboardBtn As System.Windows.Forms.Button
    Friend WithEvents BankName As System.Windows.Forms.Label
    Friend WithEvents BankLogo As System.Windows.Forms.Panel
    Friend WithEvents TransactionBtn As System.Windows.Forms.Button
    Friend WithEvents AccountBtn As System.Windows.Forms.Button
    Friend WithEvents TabPanel As System.Windows.Forms.Panel
    Friend WithEvents CloseBtn As System.Windows.Forms.Button
    Friend WithEvents MinimizeBtn As System.Windows.Forms.PictureBox
    Friend WithEvents SidePanel As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents RecordsBtn As System.Windows.Forms.Button
    Friend WithEvents ManageBtn As System.Windows.Forms.Button
    Friend WithEvents LogoutBtn As System.Windows.Forms.Button
    Friend WithEvents BackBtn As System.Windows.Forms.PictureBox
End Class
