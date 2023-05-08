<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transfer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Transfer))
        Me.TransferLbl = New System.Windows.Forms.Label()
        Me.AmountTxt = New System.Windows.Forms.TextBox()
        Me.ToAccTxt = New System.Windows.Forms.TextBox()
        Me.AccCheck = New System.Windows.Forms.PictureBox()
        Me.ProceedBtn = New System.Windows.Forms.Button()
        Me.ToPanel = New System.Windows.Forms.Panel()
        Me.ToGB = New System.Windows.Forms.GroupBox()
        Me.ToAccLbl = New System.Windows.Forms.Label()
        Me.ToBalanceLbl = New System.Windows.Forms.Label()
        Me.ToNameLbl = New System.Windows.Forms.Label()
        Me.CloseBtn = New System.Windows.Forms.PictureBox()
        Me.FromPanel = New System.Windows.Forms.Panel()
        Me.FromGB = New System.Windows.Forms.GroupBox()
        Me.FromAccLbl = New System.Windows.Forms.Label()
        Me.FromBalanceLbl = New System.Windows.Forms.Label()
        Me.FromNameLbl = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ErrorToolTip = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.AccCheck, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToPanel.SuspendLayout()
        Me.ToGB.SuspendLayout()
        CType(Me.CloseBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FromPanel.SuspendLayout()
        Me.FromGB.SuspendLayout()
        Me.SuspendLayout()
        '
        'TransferLbl
        '
        Me.TransferLbl.AutoSize = True
        Me.TransferLbl.BackColor = System.Drawing.Color.Transparent
        Me.TransferLbl.Font = New System.Drawing.Font("Agency FB", 30.0!, System.Drawing.FontStyle.Bold)
        Me.TransferLbl.ForeColor = System.Drawing.SystemColors.Window
        Me.TransferLbl.Location = New System.Drawing.Point(36, 9)
        Me.TransferLbl.Name = "TransferLbl"
        Me.TransferLbl.Size = New System.Drawing.Size(182, 61)
        Me.TransferLbl.TabIndex = 20
        Me.TransferLbl.Text = "Transfer"
        '
        'AmountTxt
        '
        Me.AmountTxt.Font = New System.Drawing.Font("Agency FB", 17.0!)
        Me.AmountTxt.ForeColor = System.Drawing.Color.Gray
        Me.AmountTxt.Location = New System.Drawing.Point(43, 369)
        Me.AmountTxt.Name = "AmountTxt"
        Me.AmountTxt.Size = New System.Drawing.Size(303, 41)
        Me.AmountTxt.TabIndex = 25
        Me.AmountTxt.Text = "Enter Amount To Transfer"
        '
        'ToAccTxt
        '
        Me.ToAccTxt.Font = New System.Drawing.Font("Agency FB", 17.0!)
        Me.ToAccTxt.ForeColor = System.Drawing.Color.Gray
        Me.ToAccTxt.Location = New System.Drawing.Point(43, 307)
        Me.ToAccTxt.Name = "ToAccTxt"
        Me.ToAccTxt.Size = New System.Drawing.Size(303, 41)
        Me.ToAccTxt.TabIndex = 24
        Me.ToAccTxt.Text = "Enter Acc No To Transfer"
        '
        'AccCheck
        '
        Me.AccCheck.BackColor = System.Drawing.Color.Transparent
        Me.AccCheck.Image = Global.BancoSeguro.My.Resources.Resources.Verified
        Me.AccCheck.Location = New System.Drawing.Point(363, 307)
        Me.AccCheck.Name = "AccCheck"
        Me.AccCheck.Size = New System.Drawing.Size(46, 41)
        Me.AccCheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.AccCheck.TabIndex = 26
        Me.AccCheck.TabStop = False
        Me.AccCheck.Visible = False
        '
        'ProceedBtn
        '
        Me.ProceedBtn.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ProceedBtn.BackgroundImage = Global.BancoSeguro.My.Resources.Resources.AppBGBlur
        Me.ProceedBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ProceedBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ProceedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ProceedBtn.Font = New System.Drawing.Font("Agency FB", 13.0!, System.Drawing.FontStyle.Bold)
        Me.ProceedBtn.ForeColor = System.Drawing.SystemColors.Window
        Me.ProceedBtn.Location = New System.Drawing.Point(371, 368)
        Me.ProceedBtn.Name = "ProceedBtn"
        Me.ProceedBtn.Size = New System.Drawing.Size(102, 42)
        Me.ProceedBtn.TabIndex = 23
        Me.ProceedBtn.Text = "Proceed"
        Me.ProceedBtn.UseVisualStyleBackColor = False
        '
        'ToPanel
        '
        Me.ToPanel.BackgroundImage = Global.BancoSeguro.My.Resources.Resources.BlackBG
        Me.ToPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ToPanel.Controls.Add(Me.ToGB)
        Me.ToPanel.Location = New System.Drawing.Point(371, 74)
        Me.ToPanel.Name = "ToPanel"
        Me.ToPanel.Size = New System.Drawing.Size(303, 199)
        Me.ToPanel.TabIndex = 22
        '
        'ToGB
        '
        Me.ToGB.BackColor = System.Drawing.Color.Transparent
        Me.ToGB.Controls.Add(Me.ToAccLbl)
        Me.ToGB.Controls.Add(Me.ToBalanceLbl)
        Me.ToGB.Controls.Add(Me.ToNameLbl)
        Me.ToGB.Font = New System.Drawing.Font("Agency FB", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToGB.ForeColor = System.Drawing.Color.White
        Me.ToGB.Location = New System.Drawing.Point(-1, 0)
        Me.ToGB.Name = "ToGB"
        Me.ToGB.Size = New System.Drawing.Size(303, 199)
        Me.ToGB.TabIndex = 5
        Me.ToGB.TabStop = False
        Me.ToGB.Text = "To"
        '
        'ToAccLbl
        '
        Me.ToAccLbl.AutoSize = True
        Me.ToAccLbl.BackColor = System.Drawing.Color.Transparent
        Me.ToAccLbl.Font = New System.Drawing.Font("Agency FB", 20.0!)
        Me.ToAccLbl.ForeColor = System.Drawing.Color.White
        Me.ToAccLbl.Location = New System.Drawing.Point(6, 43)
        Me.ToAccLbl.Name = "ToAccLbl"
        Me.ToAccLbl.Size = New System.Drawing.Size(107, 42)
        Me.ToAccLbl.TabIndex = 3
        Me.ToAccLbl.Text = "Acc No : "
        '
        'ToBalanceLbl
        '
        Me.ToBalanceLbl.AutoSize = True
        Me.ToBalanceLbl.BackColor = System.Drawing.Color.Transparent
        Me.ToBalanceLbl.Font = New System.Drawing.Font("Agency FB", 20.0!)
        Me.ToBalanceLbl.ForeColor = System.Drawing.Color.White
        Me.ToBalanceLbl.Location = New System.Drawing.Point(6, 142)
        Me.ToBalanceLbl.Name = "ToBalanceLbl"
        Me.ToBalanceLbl.Size = New System.Drawing.Size(117, 42)
        Me.ToBalanceLbl.TabIndex = 2
        Me.ToBalanceLbl.Text = "Balance : "
        '
        'ToNameLbl
        '
        Me.ToNameLbl.AutoSize = True
        Me.ToNameLbl.BackColor = System.Drawing.Color.Transparent
        Me.ToNameLbl.Font = New System.Drawing.Font("Agency FB", 20.0!)
        Me.ToNameLbl.ForeColor = System.Drawing.Color.White
        Me.ToNameLbl.Location = New System.Drawing.Point(6, 93)
        Me.ToNameLbl.Name = "ToNameLbl"
        Me.ToNameLbl.Size = New System.Drawing.Size(95, 42)
        Me.ToNameLbl.TabIndex = 1
        Me.ToNameLbl.Text = "Name : "
        '
        'CloseBtn
        '
        Me.CloseBtn.BackColor = System.Drawing.Color.Transparent
        Me.CloseBtn.Image = CType(resources.GetObject("CloseBtn.Image"), System.Drawing.Image)
        Me.CloseBtn.Location = New System.Drawing.Point(629, 19)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(45, 45)
        Me.CloseBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CloseBtn.TabIndex = 21
        Me.CloseBtn.TabStop = False
        '
        'FromPanel
        '
        Me.FromPanel.BackgroundImage = Global.BancoSeguro.My.Resources.Resources.BlackBG
        Me.FromPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.FromPanel.Controls.Add(Me.FromGB)
        Me.FromPanel.Location = New System.Drawing.Point(43, 74)
        Me.FromPanel.Name = "FromPanel"
        Me.FromPanel.Size = New System.Drawing.Size(303, 199)
        Me.FromPanel.TabIndex = 10
        '
        'FromGB
        '
        Me.FromGB.BackColor = System.Drawing.Color.Transparent
        Me.FromGB.Controls.Add(Me.FromAccLbl)
        Me.FromGB.Controls.Add(Me.FromBalanceLbl)
        Me.FromGB.Controls.Add(Me.FromNameLbl)
        Me.FromGB.Font = New System.Drawing.Font("Agency FB", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FromGB.ForeColor = System.Drawing.Color.White
        Me.FromGB.Location = New System.Drawing.Point(-1, 0)
        Me.FromGB.Name = "FromGB"
        Me.FromGB.Size = New System.Drawing.Size(303, 199)
        Me.FromGB.TabIndex = 4
        Me.FromGB.TabStop = False
        Me.FromGB.Text = "From"
        '
        'FromAccLbl
        '
        Me.FromAccLbl.AutoSize = True
        Me.FromAccLbl.BackColor = System.Drawing.Color.Transparent
        Me.FromAccLbl.Font = New System.Drawing.Font("Agency FB", 20.0!)
        Me.FromAccLbl.ForeColor = System.Drawing.Color.White
        Me.FromAccLbl.Location = New System.Drawing.Point(6, 43)
        Me.FromAccLbl.Name = "FromAccLbl"
        Me.FromAccLbl.Size = New System.Drawing.Size(107, 42)
        Me.FromAccLbl.TabIndex = 3
        Me.FromAccLbl.Text = "Acc No : "
        '
        'FromBalanceLbl
        '
        Me.FromBalanceLbl.AutoSize = True
        Me.FromBalanceLbl.BackColor = System.Drawing.Color.Transparent
        Me.FromBalanceLbl.Font = New System.Drawing.Font("Agency FB", 20.0!)
        Me.FromBalanceLbl.ForeColor = System.Drawing.Color.White
        Me.FromBalanceLbl.Location = New System.Drawing.Point(6, 142)
        Me.FromBalanceLbl.Name = "FromBalanceLbl"
        Me.FromBalanceLbl.Size = New System.Drawing.Size(131, 42)
        Me.FromBalanceLbl.TabIndex = 2
        Me.FromBalanceLbl.Text = "Balance : $"
        '
        'FromNameLbl
        '
        Me.FromNameLbl.AutoSize = True
        Me.FromNameLbl.BackColor = System.Drawing.Color.Transparent
        Me.FromNameLbl.Font = New System.Drawing.Font("Agency FB", 20.0!)
        Me.FromNameLbl.ForeColor = System.Drawing.Color.White
        Me.FromNameLbl.Location = New System.Drawing.Point(6, 93)
        Me.FromNameLbl.Name = "FromNameLbl"
        Me.FromNameLbl.Size = New System.Drawing.Size(95, 42)
        Me.FromNameLbl.TabIndex = 1
        Me.FromNameLbl.Text = "Name : "
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(717, 445)
        Me.Panel1.TabIndex = 27
        '
        'ErrorToolTip
        '
        Me.ErrorToolTip.AutoPopDelay = 5000
        Me.ErrorToolTip.InitialDelay = 100
        Me.ErrorToolTip.ReshowDelay = 100
        '
        'Transfer
        '
        Me.AcceptButton = Me.ProceedBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.CancelButton = Me.ProceedBtn
        Me.ClientSize = New System.Drawing.Size(717, 445)
        Me.Controls.Add(Me.AccCheck)
        Me.Controls.Add(Me.ToAccTxt)
        Me.Controls.Add(Me.ProceedBtn)
        Me.Controls.Add(Me.AmountTxt)
        Me.Controls.Add(Me.ToPanel)
        Me.Controls.Add(Me.CloseBtn)
        Me.Controls.Add(Me.TransferLbl)
        Me.Controls.Add(Me.FromPanel)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimizeBox = False
        Me.Name = "Transfer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transfer"
        CType(Me.AccCheck, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToPanel.ResumeLayout(False)
        Me.ToGB.ResumeLayout(False)
        Me.ToGB.PerformLayout()
        CType(Me.CloseBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FromPanel.ResumeLayout(False)
        Me.FromGB.ResumeLayout(False)
        Me.FromGB.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FromPanel As System.Windows.Forms.Panel
    Friend WithEvents FromAccLbl As System.Windows.Forms.Label
    Friend WithEvents FromBalanceLbl As System.Windows.Forms.Label
    Friend WithEvents FromNameLbl As System.Windows.Forms.Label
    Friend WithEvents CloseBtn As System.Windows.Forms.PictureBox
    Friend WithEvents TransferLbl As System.Windows.Forms.Label
    Friend WithEvents FromGB As System.Windows.Forms.GroupBox
    Friend WithEvents ToGB As System.Windows.Forms.GroupBox
    Friend WithEvents ToAccLbl As System.Windows.Forms.Label
    Friend WithEvents ToBalanceLbl As System.Windows.Forms.Label
    Friend WithEvents ToNameLbl As System.Windows.Forms.Label
    Friend WithEvents ToPanel As System.Windows.Forms.Panel
    Friend WithEvents ProceedBtn As System.Windows.Forms.Button
    Friend WithEvents AmountTxt As System.Windows.Forms.TextBox
    Friend WithEvents ToAccTxt As System.Windows.Forms.TextBox
    Friend WithEvents AccCheck As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ErrorToolTip As System.Windows.Forms.ToolTip

End Class
