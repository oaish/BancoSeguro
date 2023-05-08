<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Withdraw
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Withdraw))
        Me.WithdrawLbl = New System.Windows.Forms.Label()
        Me.AmountTxt = New System.Windows.Forms.TextBox()
        Me.WithdrawError = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CloseBtn = New System.Windows.Forms.PictureBox()
        Me.InfoPanel = New System.Windows.Forms.Panel()
        Me.AccLbl = New System.Windows.Forms.Label()
        Me.BalanceLbl = New System.Windows.Forms.Label()
        Me.NameLbl = New System.Windows.Forms.Label()
        Me.ProceedBtn = New System.Windows.Forms.Button()
        CType(Me.WithdrawError, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.CloseBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.InfoPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'WithdrawLbl
        '
        Me.WithdrawLbl.AutoSize = True
        Me.WithdrawLbl.BackColor = System.Drawing.Color.Transparent
        Me.WithdrawLbl.Font = New System.Drawing.Font("Agency FB", 30.0!, System.Drawing.FontStyle.Bold)
        Me.WithdrawLbl.ForeColor = System.Drawing.SystemColors.Window
        Me.WithdrawLbl.Location = New System.Drawing.Point(4, 9)
        Me.WithdrawLbl.Name = "WithdrawLbl"
        Me.WithdrawLbl.Size = New System.Drawing.Size(189, 61)
        Me.WithdrawLbl.TabIndex = 14
        Me.WithdrawLbl.Text = "Withdraw"
        '
        'AmountTxt
        '
        Me.AmountTxt.Font = New System.Drawing.Font("Agency FB", 17.0!)
        Me.AmountTxt.ForeColor = System.Drawing.Color.Gray
        Me.AmountTxt.Location = New System.Drawing.Point(15, 254)
        Me.AmountTxt.Name = "AmountTxt"
        Me.AmountTxt.Size = New System.Drawing.Size(168, 41)
        Me.AmountTxt.TabIndex = 13
        Me.AmountTxt.Text = "Enter Amount"
        '
        'WithdrawError
        '
        Me.WithdrawError.ContainerControl = Me
        Me.WithdrawError.Icon = CType(resources.GetObject("WithdrawError.Icon"), System.Drawing.Icon)
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.CloseBtn)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(336, 325)
        Me.Panel1.TabIndex = 17
        '
        'CloseBtn
        '
        Me.CloseBtn.BackColor = System.Drawing.Color.Transparent
        Me.CloseBtn.Image = CType(resources.GetObject("CloseBtn.Image"), System.Drawing.Image)
        Me.CloseBtn.Location = New System.Drawing.Point(270, 17)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(45, 45)
        Me.CloseBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CloseBtn.TabIndex = 18
        Me.CloseBtn.TabStop = False
        '
        'InfoPanel
        '
        Me.InfoPanel.BackgroundImage = Global.BancoSeguro.My.Resources.Resources.BlackBG
        Me.InfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.InfoPanel.Controls.Add(Me.AccLbl)
        Me.InfoPanel.Controls.Add(Me.BalanceLbl)
        Me.InfoPanel.Controls.Add(Me.NameLbl)
        Me.InfoPanel.Location = New System.Drawing.Point(15, 73)
        Me.InfoPanel.Name = "InfoPanel"
        Me.InfoPanel.Size = New System.Drawing.Size(303, 159)
        Me.InfoPanel.TabIndex = 15
        '
        'AccLbl
        '
        Me.AccLbl.AutoSize = True
        Me.AccLbl.BackColor = System.Drawing.Color.Transparent
        Me.AccLbl.Font = New System.Drawing.Font("Agency FB", 20.0!)
        Me.AccLbl.ForeColor = System.Drawing.Color.White
        Me.AccLbl.Location = New System.Drawing.Point(3, 6)
        Me.AccLbl.Name = "AccLbl"
        Me.AccLbl.Size = New System.Drawing.Size(107, 42)
        Me.AccLbl.TabIndex = 3
        Me.AccLbl.Text = "Acc No : "
        '
        'BalanceLbl
        '
        Me.BalanceLbl.AutoSize = True
        Me.BalanceLbl.BackColor = System.Drawing.Color.Transparent
        Me.BalanceLbl.Font = New System.Drawing.Font("Agency FB", 20.0!)
        Me.BalanceLbl.ForeColor = System.Drawing.Color.White
        Me.BalanceLbl.Location = New System.Drawing.Point(3, 105)
        Me.BalanceLbl.Name = "BalanceLbl"
        Me.BalanceLbl.Size = New System.Drawing.Size(131, 42)
        Me.BalanceLbl.TabIndex = 2
        Me.BalanceLbl.Text = "Balance : $"
        '
        'NameLbl
        '
        Me.NameLbl.AutoSize = True
        Me.NameLbl.BackColor = System.Drawing.Color.Transparent
        Me.NameLbl.Font = New System.Drawing.Font("Agency FB", 20.0!)
        Me.NameLbl.ForeColor = System.Drawing.Color.White
        Me.NameLbl.Location = New System.Drawing.Point(3, 56)
        Me.NameLbl.Name = "NameLbl"
        Me.NameLbl.Size = New System.Drawing.Size(95, 42)
        Me.NameLbl.TabIndex = 1
        Me.NameLbl.Text = "Name : "
        '
        'ProceedBtn
        '
        Me.ProceedBtn.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ProceedBtn.BackgroundImage = Global.BancoSeguro.My.Resources.Resources.AppBGBlur
        Me.ProceedBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ProceedBtn.FlatAppearance.BorderSize = 2
        Me.ProceedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ProceedBtn.Font = New System.Drawing.Font("Agency FB", 13.0!, System.Drawing.FontStyle.Bold)
        Me.ProceedBtn.ForeColor = System.Drawing.SystemColors.Window
        Me.ProceedBtn.Location = New System.Drawing.Point(216, 253)
        Me.ProceedBtn.Name = "ProceedBtn"
        Me.ProceedBtn.Size = New System.Drawing.Size(102, 42)
        Me.ProceedBtn.TabIndex = 12
        Me.ProceedBtn.Text = "Proceed"
        Me.ProceedBtn.UseVisualStyleBackColor = False
        '
        'Withdraw
        '
        Me.AcceptButton = Me.ProceedBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(336, 325)
        Me.Controls.Add(Me.InfoPanel)
        Me.Controls.Add(Me.WithdrawLbl)
        Me.Controls.Add(Me.AmountTxt)
        Me.Controls.Add(Me.ProceedBtn)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Withdraw"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Withdraw"
        CType(Me.WithdrawError, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.CloseBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.InfoPanel.ResumeLayout(False)
        Me.InfoPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents InfoPanel As System.Windows.Forms.Panel
    Friend WithEvents AccLbl As System.Windows.Forms.Label
    Friend WithEvents BalanceLbl As System.Windows.Forms.Label
    Friend WithEvents NameLbl As System.Windows.Forms.Label
    Friend WithEvents WithdrawLbl As System.Windows.Forms.Label
    Friend WithEvents AmountTxt As System.Windows.Forms.TextBox
    Friend WithEvents WithdrawError As System.Windows.Forms.ErrorProvider
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CloseBtn As System.Windows.Forms.PictureBox
    Friend WithEvents ProceedBtn As System.Windows.Forms.Button

End Class
