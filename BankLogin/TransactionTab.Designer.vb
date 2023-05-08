<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransactionTab
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TransactionTab))
        Me.SearchBar = New System.Windows.Forms.TextBox()
        Me.DetailsPanel = New System.Windows.Forms.Panel()
        Me.ProfilePic = New System.Windows.Forms.PictureBox()
        Me.EmailLbl = New System.Windows.Forms.Label()
        Me.MobLbl = New System.Windows.Forms.Label()
        Me.DOBLbl = New System.Windows.Forms.Label()
        Me.AccTypeLbl = New System.Windows.Forms.Label()
        Me.AccLbl = New System.Windows.Forms.Label()
        Me.BalanceBtn = New System.Windows.Forms.Button()
        Me.NameLbl = New System.Windows.Forms.Label()
        Me.HistoryBtn = New System.Windows.Forms.Button()
        Me.TransferBtn = New System.Windows.Forms.Button()
        Me.WithdrawBtn = New System.Windows.Forms.Button()
        Me.DepositBtn = New System.Windows.Forms.Button()
        Me.SearchBtn = New System.Windows.Forms.PictureBox()
        Me.DetailsPanel.SuspendLayout()
        CType(Me.ProfilePic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SearchBar
        '
        Me.SearchBar.BackColor = System.Drawing.SystemColors.Window
        Me.SearchBar.Font = New System.Drawing.Font("Agency FB", 20.0!)
        Me.SearchBar.ForeColor = System.Drawing.Color.Gray
        Me.SearchBar.Location = New System.Drawing.Point(146, 95)
        Me.SearchBar.Name = "SearchBar"
        Me.SearchBar.Size = New System.Drawing.Size(492, 47)
        Me.SearchBar.TabIndex = 12
        Me.SearchBar.Text = "Search Account No"
        Me.SearchBar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DetailsPanel
        '
        Me.DetailsPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.DetailsPanel.BackgroundImage = CType(resources.GetObject("DetailsPanel.BackgroundImage"), System.Drawing.Image)
        Me.DetailsPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DetailsPanel.Controls.Add(Me.ProfilePic)
        Me.DetailsPanel.Controls.Add(Me.EmailLbl)
        Me.DetailsPanel.Controls.Add(Me.MobLbl)
        Me.DetailsPanel.Controls.Add(Me.DOBLbl)
        Me.DetailsPanel.Controls.Add(Me.AccTypeLbl)
        Me.DetailsPanel.Controls.Add(Me.AccLbl)
        Me.DetailsPanel.Controls.Add(Me.BalanceBtn)
        Me.DetailsPanel.Controls.Add(Me.NameLbl)
        Me.DetailsPanel.Location = New System.Drawing.Point(146, 203)
        Me.DetailsPanel.Name = "DetailsPanel"
        Me.DetailsPanel.Size = New System.Drawing.Size(492, 370)
        Me.DetailsPanel.TabIndex = 16
        Me.DetailsPanel.Visible = False
        '
        'ProfilePic
        '
        Me.ProfilePic.BackColor = System.Drawing.Color.Transparent
        Me.ProfilePic.Location = New System.Drawing.Point(301, 75)
        Me.ProfilePic.Name = "ProfilePic"
        Me.ProfilePic.Size = New System.Drawing.Size(136, 136)
        Me.ProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ProfilePic.TabIndex = 12
        Me.ProfilePic.TabStop = False
        '
        'EmailLbl
        '
        Me.EmailLbl.AutoSize = True
        Me.EmailLbl.BackColor = System.Drawing.Color.Transparent
        Me.EmailLbl.Font = New System.Drawing.Font("Agency FB", 20.0!)
        Me.EmailLbl.ForeColor = System.Drawing.Color.White
        Me.EmailLbl.Location = New System.Drawing.Point(17, 291)
        Me.EmailLbl.Name = "EmailLbl"
        Me.EmailLbl.Size = New System.Drawing.Size(91, 42)
        Me.EmailLbl.TabIndex = 17
        Me.EmailLbl.Text = "Email : "
        '
        'MobLbl
        '
        Me.MobLbl.AutoSize = True
        Me.MobLbl.BackColor = System.Drawing.Color.Transparent
        Me.MobLbl.Font = New System.Drawing.Font("Agency FB", 20.0!)
        Me.MobLbl.ForeColor = System.Drawing.Color.White
        Me.MobLbl.Location = New System.Drawing.Point(17, 237)
        Me.MobLbl.Name = "MobLbl"
        Me.MobLbl.Size = New System.Drawing.Size(100, 42)
        Me.MobLbl.TabIndex = 16
        Me.MobLbl.Text = "Phone : "
        '
        'DOBLbl
        '
        Me.DOBLbl.AutoSize = True
        Me.DOBLbl.BackColor = System.Drawing.Color.Transparent
        Me.DOBLbl.Font = New System.Drawing.Font("Agency FB", 20.0!)
        Me.DOBLbl.ForeColor = System.Drawing.Color.White
        Me.DOBLbl.Location = New System.Drawing.Point(17, 183)
        Me.DOBLbl.Name = "DOBLbl"
        Me.DOBLbl.Size = New System.Drawing.Size(80, 42)
        Me.DOBLbl.TabIndex = 15
        Me.DOBLbl.Text = "DOB : "
        '
        'AccTypeLbl
        '
        Me.AccTypeLbl.AutoSize = True
        Me.AccTypeLbl.BackColor = System.Drawing.Color.Transparent
        Me.AccTypeLbl.Font = New System.Drawing.Font("Agency FB", 20.0!)
        Me.AccTypeLbl.ForeColor = System.Drawing.Color.White
        Me.AccTypeLbl.Location = New System.Drawing.Point(17, 129)
        Me.AccTypeLbl.Name = "AccTypeLbl"
        Me.AccTypeLbl.Size = New System.Drawing.Size(126, 42)
        Me.AccTypeLbl.TabIndex = 14
        Me.AccTypeLbl.Text = "Acc Type : "
        '
        'AccLbl
        '
        Me.AccLbl.AutoSize = True
        Me.AccLbl.BackColor = System.Drawing.Color.Transparent
        Me.AccLbl.Font = New System.Drawing.Font("Agency FB", 20.0!)
        Me.AccLbl.ForeColor = System.Drawing.Color.White
        Me.AccLbl.Location = New System.Drawing.Point(17, 75)
        Me.AccLbl.Name = "AccLbl"
        Me.AccLbl.Size = New System.Drawing.Size(107, 42)
        Me.AccLbl.TabIndex = 13
        Me.AccLbl.Text = "Acc No : "
        '
        'BalanceBtn
        '
        Me.BalanceBtn.BackgroundImage = CType(resources.GetObject("BalanceBtn.BackgroundImage"), System.Drawing.Image)
        Me.BalanceBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BalanceBtn.Font = New System.Drawing.Font("Agency FB", 15.0!, System.Drawing.FontStyle.Bold)
        Me.BalanceBtn.ForeColor = System.Drawing.Color.White
        Me.BalanceBtn.Location = New System.Drawing.Point(301, 215)
        Me.BalanceBtn.Name = "BalanceBtn"
        Me.BalanceBtn.Size = New System.Drawing.Size(136, 40)
        Me.BalanceBtn.TabIndex = 12
        Me.BalanceBtn.Text = "View Balance"
        Me.BalanceBtn.UseVisualStyleBackColor = True
        '
        'NameLbl
        '
        Me.NameLbl.AutoSize = True
        Me.NameLbl.BackColor = System.Drawing.Color.Transparent
        Me.NameLbl.Font = New System.Drawing.Font("Agency FB", 20.0!)
        Me.NameLbl.ForeColor = System.Drawing.Color.White
        Me.NameLbl.Location = New System.Drawing.Point(17, 21)
        Me.NameLbl.Name = "NameLbl"
        Me.NameLbl.Size = New System.Drawing.Size(95, 42)
        Me.NameLbl.TabIndex = 0
        Me.NameLbl.Text = "Name : "
        '
        'HistoryBtn
        '
        Me.HistoryBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HistoryBtn.FlatAppearance.BorderSize = 2
        Me.HistoryBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.HistoryBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.HistoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HistoryBtn.Font = New System.Drawing.Font("Agency FB", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HistoryBtn.ForeColor = System.Drawing.Color.White
        Me.HistoryBtn.Image = Global.BancoSeguro.My.Resources.Resources.history30x
        Me.HistoryBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.HistoryBtn.Location = New System.Drawing.Point(671, 485)
        Me.HistoryBtn.Name = "HistoryBtn"
        Me.HistoryBtn.Size = New System.Drawing.Size(140, 88)
        Me.HistoryBtn.TabIndex = 18
        Me.HistoryBtn.Text = "History"
        Me.HistoryBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.HistoryBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.HistoryBtn.UseVisualStyleBackColor = True
        Me.HistoryBtn.Visible = False
        '
        'TransferBtn
        '
        Me.TransferBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TransferBtn.FlatAppearance.BorderSize = 2
        Me.TransferBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.TransferBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.TransferBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TransferBtn.Font = New System.Drawing.Font("Agency FB", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TransferBtn.ForeColor = System.Drawing.Color.White
        Me.TransferBtn.Image = CType(resources.GetObject("TransferBtn.Image"), System.Drawing.Image)
        Me.TransferBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.TransferBtn.Location = New System.Drawing.Point(671, 391)
        Me.TransferBtn.Name = "TransferBtn"
        Me.TransferBtn.Size = New System.Drawing.Size(140, 88)
        Me.TransferBtn.TabIndex = 17
        Me.TransferBtn.Text = "Transfer"
        Me.TransferBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.TransferBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.TransferBtn.UseVisualStyleBackColor = True
        Me.TransferBtn.Visible = False
        '
        'WithdrawBtn
        '
        Me.WithdrawBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.WithdrawBtn.FlatAppearance.BorderSize = 2
        Me.WithdrawBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.WithdrawBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.WithdrawBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.WithdrawBtn.Font = New System.Drawing.Font("Agency FB", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WithdrawBtn.ForeColor = System.Drawing.Color.White
        Me.WithdrawBtn.Image = Global.BancoSeguro.My.Resources.Resources.cash30x
        Me.WithdrawBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.WithdrawBtn.Location = New System.Drawing.Point(671, 297)
        Me.WithdrawBtn.Name = "WithdrawBtn"
        Me.WithdrawBtn.Size = New System.Drawing.Size(140, 88)
        Me.WithdrawBtn.TabIndex = 15
        Me.WithdrawBtn.Text = "Withdraw"
        Me.WithdrawBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.WithdrawBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.WithdrawBtn.UseVisualStyleBackColor = True
        Me.WithdrawBtn.Visible = False
        '
        'DepositBtn
        '
        Me.DepositBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DepositBtn.FlatAppearance.BorderSize = 2
        Me.DepositBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.DepositBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.DepositBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DepositBtn.Font = New System.Drawing.Font("Agency FB", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DepositBtn.ForeColor = System.Drawing.Color.White
        Me.DepositBtn.Image = Global.BancoSeguro.My.Resources.Resources.stack30x
        Me.DepositBtn.Location = New System.Drawing.Point(671, 203)
        Me.DepositBtn.Name = "DepositBtn"
        Me.DepositBtn.Size = New System.Drawing.Size(140, 88)
        Me.DepositBtn.TabIndex = 14
        Me.DepositBtn.Text = "Deposit "
        Me.DepositBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DepositBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.DepositBtn.UseVisualStyleBackColor = True
        Me.DepositBtn.Visible = False
        '
        'SearchBtn
        '
        Me.SearchBtn.BackColor = System.Drawing.Color.Transparent
        Me.SearchBtn.Image = Global.BancoSeguro.My.Resources.Resources.search
        Me.SearchBtn.Location = New System.Drawing.Point(648, 91)
        Me.SearchBtn.Name = "SearchBtn"
        Me.SearchBtn.Size = New System.Drawing.Size(48, 50)
        Me.SearchBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SearchBtn.TabIndex = 13
        Me.SearchBtn.TabStop = False
        '
        'TransactionTab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.Transparent
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.DetailsPanel)
        Me.Controls.Add(Me.HistoryBtn)
        Me.Controls.Add(Me.TransferBtn)
        Me.Controls.Add(Me.WithdrawBtn)
        Me.Controls.Add(Me.DepositBtn)
        Me.Controls.Add(Me.SearchBtn)
        Me.Controls.Add(Me.SearchBar)
        Me.DoubleBuffered = True
        Me.Name = "TransactionTab"
        Me.Size = New System.Drawing.Size(911, 660)
        Me.DetailsPanel.ResumeLayout(False)
        Me.DetailsPanel.PerformLayout()
        CType(Me.ProfilePic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProfilePic As System.Windows.Forms.PictureBox
    Friend WithEvents EmailLbl As System.Windows.Forms.Label
    Friend WithEvents MobLbl As System.Windows.Forms.Label
    Friend WithEvents DOBLbl As System.Windows.Forms.Label
    Friend WithEvents AccTypeLbl As System.Windows.Forms.Label
    Friend WithEvents AccLbl As System.Windows.Forms.Label
    Friend WithEvents BalanceBtn As System.Windows.Forms.Button
    Friend WithEvents NameLbl As System.Windows.Forms.Label
    Friend WithEvents HistoryBtn As System.Windows.Forms.Button
    Friend WithEvents TransferBtn As System.Windows.Forms.Button
    Friend WithEvents WithdrawBtn As System.Windows.Forms.Button
    Friend WithEvents DepositBtn As System.Windows.Forms.Button
    Friend WithEvents SearchBtn As System.Windows.Forms.PictureBox
    Friend WithEvents SearchBar As System.Windows.Forms.TextBox
    Public WithEvents DetailsPanel As System.Windows.Forms.Panel

End Class
