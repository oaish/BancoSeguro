<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Me.DateTimeLbl = New System.Windows.Forms.Label()
        Me.WelcomeLbl = New System.Windows.Forms.Label()
        Me.PanelSplitter = New System.Windows.Forms.Panel()
        Me.ClientsGB = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ClientLbl = New System.Windows.Forms.Label()
        Me.DepositGB = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.DepositLbl = New System.Windows.Forms.Label()
        Me.EmpGB = New System.Windows.Forms.GroupBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.EmpLbl = New System.Windows.Forms.Label()
        Me.CurrentGB = New System.Windows.Forms.GroupBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.CALbl = New System.Windows.Forms.Label()
        Me.SavingsGB = New System.Windows.Forms.GroupBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.SALbl = New System.Windows.Forms.Label()
        Me.ClientsGB.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DepositGB.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EmpGB.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CurrentGB.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SavingsGB.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateTimeLbl
        '
        Me.DateTimeLbl.AutoSize = True
        Me.DateTimeLbl.BackColor = System.Drawing.Color.Transparent
        Me.DateTimeLbl.Font = New System.Drawing.Font("Agency FB", 35.0!)
        Me.DateTimeLbl.ForeColor = System.Drawing.Color.White
        Me.DateTimeLbl.Location = New System.Drawing.Point(197, 46)
        Me.DateTimeLbl.Name = "DateTimeLbl"
        Me.DateTimeLbl.Size = New System.Drawing.Size(290, 144)
        Me.DateTimeLbl.TabIndex = 0
        Me.DateTimeLbl.Text = "Mon, 24th Apr" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "3:05 AM"
        Me.DateTimeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'WelcomeLbl
        '
        Me.WelcomeLbl.AutoSize = True
        Me.WelcomeLbl.BackColor = System.Drawing.Color.Transparent
        Me.WelcomeLbl.Font = New System.Drawing.Font("Agency FB", 35.0!)
        Me.WelcomeLbl.ForeColor = System.Drawing.Color.White
        Me.WelcomeLbl.Location = New System.Drawing.Point(501, 46)
        Me.WelcomeLbl.Name = "WelcomeLbl"
        Me.WelcomeLbl.Size = New System.Drawing.Size(204, 144)
        Me.WelcomeLbl.TabIndex = 1
        Me.WelcomeLbl.Text = "Welcome," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Admin" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.WelcomeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PanelSplitter
        '
        Me.PanelSplitter.BackColor = System.Drawing.Color.White
        Me.PanelSplitter.Location = New System.Drawing.Point(493, 46)
        Me.PanelSplitter.Name = "PanelSplitter"
        Me.PanelSplitter.Size = New System.Drawing.Size(7, 144)
        Me.PanelSplitter.TabIndex = 2
        '
        'ClientsGB
        '
        Me.ClientsGB.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.ClientsGB.Controls.Add(Me.PictureBox1)
        Me.ClientsGB.Controls.Add(Me.ClientLbl)
        Me.ClientsGB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClientsGB.Font = New System.Drawing.Font("Agency FB", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClientsGB.ForeColor = System.Drawing.Color.White
        Me.ClientsGB.Location = New System.Drawing.Point(133, 229)
        Me.ClientsGB.Name = "ClientsGB"
        Me.ClientsGB.Size = New System.Drawing.Size(187, 163)
        Me.ClientsGB.TabIndex = 0
        Me.ClientsGB.TabStop = False
        Me.ClientsGB.Text = "Total Clients"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.BancoSeguro.My.Resources.Resources.clients40x
        Me.PictureBox1.Location = New System.Drawing.Point(124, 106)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 45)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'ClientLbl
        '
        Me.ClientLbl.AutoSize = True
        Me.ClientLbl.Font = New System.Drawing.Font("Agency FB", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClientLbl.Location = New System.Drawing.Point(59, 56)
        Me.ClientLbl.Name = "ClientLbl"
        Me.ClientLbl.Size = New System.Drawing.Size(58, 51)
        Me.ClientLbl.TabIndex = 3
        Me.ClientLbl.Text = "20"
        '
        'DepositGB
        '
        Me.DepositGB.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.DepositGB.Controls.Add(Me.PictureBox2)
        Me.DepositGB.Controls.Add(Me.DepositLbl)
        Me.DepositGB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DepositGB.Font = New System.Drawing.Font("Agency FB", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DepositGB.ForeColor = System.Drawing.Color.White
        Me.DepositGB.Location = New System.Drawing.Point(362, 229)
        Me.DepositGB.Name = "DepositGB"
        Me.DepositGB.Size = New System.Drawing.Size(187, 163)
        Me.DepositGB.TabIndex = 4
        Me.DepositGB.TabStop = False
        Me.DepositGB.Text = "Total Deposit"
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.BancoSeguro.My.Resources.Resources.deposit40x
        Me.PictureBox2.Location = New System.Drawing.Point(124, 106)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(50, 45)
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'DepositLbl
        '
        Me.DepositLbl.AutoSize = True
        Me.DepositLbl.Font = New System.Drawing.Font("Agency FB", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DepositLbl.Location = New System.Drawing.Point(36, 54)
        Me.DepositLbl.Name = "DepositLbl"
        Me.DepositLbl.Size = New System.Drawing.Size(115, 51)
        Me.DepositLbl.TabIndex = 3
        Me.DepositLbl.Text = "$40 Bn"
        '
        'EmpGB
        '
        Me.EmpGB.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.EmpGB.Controls.Add(Me.PictureBox3)
        Me.EmpGB.Controls.Add(Me.EmpLbl)
        Me.EmpGB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EmpGB.Font = New System.Drawing.Font("Agency FB", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpGB.ForeColor = System.Drawing.Color.White
        Me.EmpGB.Location = New System.Drawing.Point(591, 229)
        Me.EmpGB.Name = "EmpGB"
        Me.EmpGB.Size = New System.Drawing.Size(187, 163)
        Me.EmpGB.TabIndex = 5
        Me.EmpGB.TabStop = False
        Me.EmpGB.Text = "Total Staffs"
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = Global.BancoSeguro.My.Resources.Resources.user_groups_40px
        Me.PictureBox3.Location = New System.Drawing.Point(124, 106)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(50, 45)
        Me.PictureBox3.TabIndex = 3
        Me.PictureBox3.TabStop = False
        '
        'EmpLbl
        '
        Me.EmpLbl.AutoSize = True
        Me.EmpLbl.Font = New System.Drawing.Font("Agency FB", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpLbl.Location = New System.Drawing.Point(68, 56)
        Me.EmpLbl.Name = "EmpLbl"
        Me.EmpLbl.Size = New System.Drawing.Size(31, 51)
        Me.EmpLbl.TabIndex = 3
        Me.EmpLbl.Text = "1"
        '
        'CurrentGB
        '
        Me.CurrentGB.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.CurrentGB.Controls.Add(Me.PictureBox4)
        Me.CurrentGB.Controls.Add(Me.CALbl)
        Me.CurrentGB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CurrentGB.Font = New System.Drawing.Font("Agency FB", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentGB.ForeColor = System.Drawing.Color.White
        Me.CurrentGB.Location = New System.Drawing.Point(486, 415)
        Me.CurrentGB.Name = "CurrentGB"
        Me.CurrentGB.Size = New System.Drawing.Size(187, 163)
        Me.CurrentGB.TabIndex = 7
        Me.CurrentGB.TabStop = False
        Me.CurrentGB.Text = "Current Acc Amount"
        '
        'PictureBox4
        '
        Me.PictureBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = Global.BancoSeguro.My.Resources.Resources.ca40x
        Me.PictureBox4.Location = New System.Drawing.Point(124, 106)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(50, 45)
        Me.PictureBox4.TabIndex = 3
        Me.PictureBox4.TabStop = False
        '
        'CALbl
        '
        Me.CALbl.AutoSize = True
        Me.CALbl.Font = New System.Drawing.Font("Agency FB", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CALbl.Location = New System.Drawing.Point(36, 56)
        Me.CALbl.Name = "CALbl"
        Me.CALbl.Size = New System.Drawing.Size(115, 51)
        Me.CALbl.TabIndex = 3
        Me.CALbl.Text = "$40 Bn"
        '
        'SavingsGB
        '
        Me.SavingsGB.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.SavingsGB.Controls.Add(Me.PictureBox5)
        Me.SavingsGB.Controls.Add(Me.SALbl)
        Me.SavingsGB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SavingsGB.Font = New System.Drawing.Font("Agency FB", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SavingsGB.ForeColor = System.Drawing.Color.White
        Me.SavingsGB.Location = New System.Drawing.Point(257, 415)
        Me.SavingsGB.Name = "SavingsGB"
        Me.SavingsGB.Size = New System.Drawing.Size(187, 163)
        Me.SavingsGB.TabIndex = 6
        Me.SavingsGB.TabStop = False
        Me.SavingsGB.Text = "Savings Acc Amount"
        '
        'PictureBox5
        '
        Me.PictureBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.Image = Global.BancoSeguro.My.Resources.Resources.sa40x
        Me.PictureBox5.Location = New System.Drawing.Point(124, 106)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(50, 45)
        Me.PictureBox5.TabIndex = 3
        Me.PictureBox5.TabStop = False
        '
        'SALbl
        '
        Me.SALbl.AutoSize = True
        Me.SALbl.Font = New System.Drawing.Font("Agency FB", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SALbl.Location = New System.Drawing.Point(36, 56)
        Me.SALbl.Name = "SALbl"
        Me.SALbl.Size = New System.Drawing.Size(115, 51)
        Me.SALbl.TabIndex = 3
        Me.SALbl.Text = "$40 Bn"
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.Transparent
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.CurrentGB)
        Me.Controls.Add(Me.SavingsGB)
        Me.Controls.Add(Me.EmpGB)
        Me.Controls.Add(Me.DepositGB)
        Me.Controls.Add(Me.ClientsGB)
        Me.Controls.Add(Me.PanelSplitter)
        Me.Controls.Add(Me.WelcomeLbl)
        Me.Controls.Add(Me.DateTimeLbl)
        Me.DoubleBuffered = True
        Me.Name = "Dashboard"
        Me.Size = New System.Drawing.Size(911, 660)
        Me.ClientsGB.ResumeLayout(False)
        Me.ClientsGB.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DepositGB.ResumeLayout(False)
        Me.DepositGB.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EmpGB.ResumeLayout(False)
        Me.EmpGB.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CurrentGB.ResumeLayout(False)
        Me.CurrentGB.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SavingsGB.ResumeLayout(False)
        Me.SavingsGB.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateTimeLbl As System.Windows.Forms.Label
    Friend WithEvents WelcomeLbl As System.Windows.Forms.Label
    Friend WithEvents PanelSplitter As System.Windows.Forms.Panel
    Friend WithEvents ClientsGB As System.Windows.Forms.GroupBox
    Friend WithEvents ClientLbl As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents DepositGB As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents DepositLbl As System.Windows.Forms.Label
    Friend WithEvents EmpGB As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents EmpLbl As System.Windows.Forms.Label
    Friend WithEvents CurrentGB As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents CALbl As System.Windows.Forms.Label
    Friend WithEvents SavingsGB As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents SALbl As System.Windows.Forms.Label

End Class
