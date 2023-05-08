<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProfilePicker
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProfilePicker))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CloseBtn = New System.Windows.Forms.PictureBox()
        Me.DepositLbl = New System.Windows.Forms.Label()
        Me.Female = New System.Windows.Forms.TabPage()
        Me.F1 = New System.Windows.Forms.PictureBox()
        Me.F2 = New System.Windows.Forms.PictureBox()
        Me.F3 = New System.Windows.Forms.PictureBox()
        Me.F4 = New System.Windows.Forms.PictureBox()
        Me.F5 = New System.Windows.Forms.PictureBox()
        Me.F6 = New System.Windows.Forms.PictureBox()
        Me.F7 = New System.Windows.Forms.PictureBox()
        Me.F8 = New System.Windows.Forms.PictureBox()
        Me.Male = New System.Windows.Forms.TabPage()
        Me.M1 = New System.Windows.Forms.PictureBox()
        Me.M2 = New System.Windows.Forms.PictureBox()
        Me.M3 = New System.Windows.Forms.PictureBox()
        Me.M4 = New System.Windows.Forms.PictureBox()
        Me.M5 = New System.Windows.Forms.PictureBox()
        Me.M6 = New System.Windows.Forms.PictureBox()
        Me.M7 = New System.Windows.Forms.PictureBox()
        Me.M8 = New System.Windows.Forms.PictureBox()
        Me.M9 = New System.Windows.Forms.PictureBox()
        Me.M10 = New System.Windows.Forms.PictureBox()
        Me.M11 = New System.Windows.Forms.PictureBox()
        Me.M12 = New System.Windows.Forms.PictureBox()
        Me.GenderTab = New System.Windows.Forms.TabControl()
        Me.Panel1.SuspendLayout()
        CType(Me.CloseBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Female.SuspendLayout()
        CType(Me.F1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.F2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.F3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.F4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.F5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.F6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.F7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.F8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Male.SuspendLayout()
        CType(Me.M1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.M2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.M3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.M4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.M5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.M6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.M7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.M8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.M9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.M10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.M11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.M12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GenderTab.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.CloseBtn)
        Me.Panel1.Controls.Add(Me.GenderTab)
        Me.Panel1.Controls.Add(Me.DepositLbl)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(910, 706)
        Me.Panel1.TabIndex = 23
        '
        'CloseBtn
        '
        Me.CloseBtn.BackColor = System.Drawing.Color.Transparent
        Me.CloseBtn.Image = CType(resources.GetObject("CloseBtn.Image"), System.Drawing.Image)
        Me.CloseBtn.Location = New System.Drawing.Point(799, 21)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(50, 50)
        Me.CloseBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CloseBtn.TabIndex = 25
        Me.CloseBtn.TabStop = False
        '
        'DepositLbl
        '
        Me.DepositLbl.AutoSize = True
        Me.DepositLbl.BackColor = System.Drawing.Color.Transparent
        Me.DepositLbl.Font = New System.Drawing.Font("Agency FB", 30.0!, System.Drawing.FontStyle.Bold)
        Me.DepositLbl.ForeColor = System.Drawing.SystemColors.Window
        Me.DepositLbl.Location = New System.Drawing.Point(57, 10)
        Me.DepositLbl.Name = "DepositLbl"
        Me.DepositLbl.Size = New System.Drawing.Size(271, 61)
        Me.DepositLbl.TabIndex = 24
        Me.DepositLbl.Text = "Profile Picker"
        '
        'Female
        '
        Me.Female.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Female.Controls.Add(Me.F8)
        Me.Female.Controls.Add(Me.F7)
        Me.Female.Controls.Add(Me.F6)
        Me.Female.Controls.Add(Me.F5)
        Me.Female.Controls.Add(Me.F4)
        Me.Female.Controls.Add(Me.F3)
        Me.Female.Controls.Add(Me.F2)
        Me.Female.Controls.Add(Me.F1)
        Me.Female.Location = New System.Drawing.Point(4, 4)
        Me.Female.Name = "Female"
        Me.Female.Padding = New System.Windows.Forms.Padding(3)
        Me.Female.Size = New System.Drawing.Size(774, 549)
        Me.Female.TabIndex = 1
        Me.Female.Text = "Female"
        '
        'F1
        '
        Me.F1.BackColor = System.Drawing.Color.Transparent
        Me.F1.Image = Global.BancoSeguro.My.Resources.Resources.profile500x
        Me.F1.Location = New System.Drawing.Point(44, 127)
        Me.F1.Name = "F1"
        Me.F1.Size = New System.Drawing.Size(136, 136)
        Me.F1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.F1.TabIndex = 30
        Me.F1.TabStop = False
        '
        'F2
        '
        Me.F2.BackColor = System.Drawing.Color.Transparent
        Me.F2.Image = Global.BancoSeguro.My.Resources.Resources.profile500x
        Me.F2.Location = New System.Drawing.Point(226, 127)
        Me.F2.Name = "F2"
        Me.F2.Size = New System.Drawing.Size(136, 136)
        Me.F2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.F2.TabIndex = 31
        Me.F2.TabStop = False
        '
        'F3
        '
        Me.F3.BackColor = System.Drawing.Color.Transparent
        Me.F3.Image = Global.BancoSeguro.My.Resources.Resources.profile500x
        Me.F3.Location = New System.Drawing.Point(403, 127)
        Me.F3.Name = "F3"
        Me.F3.Size = New System.Drawing.Size(136, 136)
        Me.F3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.F3.TabIndex = 32
        Me.F3.TabStop = False
        '
        'F4
        '
        Me.F4.BackColor = System.Drawing.Color.Transparent
        Me.F4.Image = Global.BancoSeguro.My.Resources.Resources.profile500x
        Me.F4.Location = New System.Drawing.Point(589, 127)
        Me.F4.Name = "F4"
        Me.F4.Size = New System.Drawing.Size(136, 136)
        Me.F4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.F4.TabIndex = 33
        Me.F4.TabStop = False
        '
        'F5
        '
        Me.F5.BackColor = System.Drawing.Color.Transparent
        Me.F5.Image = Global.BancoSeguro.My.Resources.Resources.profile500x
        Me.F5.Location = New System.Drawing.Point(44, 286)
        Me.F5.Name = "F5"
        Me.F5.Size = New System.Drawing.Size(136, 136)
        Me.F5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.F5.TabIndex = 34
        Me.F5.TabStop = False
        '
        'F6
        '
        Me.F6.BackColor = System.Drawing.Color.Transparent
        Me.F6.Image = Global.BancoSeguro.My.Resources.Resources.profile500x
        Me.F6.Location = New System.Drawing.Point(226, 286)
        Me.F6.Name = "F6"
        Me.F6.Size = New System.Drawing.Size(136, 136)
        Me.F6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.F6.TabIndex = 35
        Me.F6.TabStop = False
        '
        'F7
        '
        Me.F7.BackColor = System.Drawing.Color.Transparent
        Me.F7.Image = Global.BancoSeguro.My.Resources.Resources.profile500x
        Me.F7.Location = New System.Drawing.Point(403, 286)
        Me.F7.Name = "F7"
        Me.F7.Size = New System.Drawing.Size(136, 136)
        Me.F7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.F7.TabIndex = 36
        Me.F7.TabStop = False
        '
        'F8
        '
        Me.F8.BackColor = System.Drawing.Color.Transparent
        Me.F8.Image = Global.BancoSeguro.My.Resources.Resources.profile500x
        Me.F8.Location = New System.Drawing.Point(589, 286)
        Me.F8.Name = "F8"
        Me.F8.Size = New System.Drawing.Size(136, 136)
        Me.F8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.F8.TabIndex = 37
        Me.F8.TabStop = False
        '
        'Male
        '
        Me.Male.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Male.Controls.Add(Me.M12)
        Me.Male.Controls.Add(Me.M11)
        Me.Male.Controls.Add(Me.M10)
        Me.Male.Controls.Add(Me.M9)
        Me.Male.Controls.Add(Me.M8)
        Me.Male.Controls.Add(Me.M7)
        Me.Male.Controls.Add(Me.M6)
        Me.Male.Controls.Add(Me.M5)
        Me.Male.Controls.Add(Me.M4)
        Me.Male.Controls.Add(Me.M3)
        Me.Male.Controls.Add(Me.M2)
        Me.Male.Controls.Add(Me.M1)
        Me.Male.Location = New System.Drawing.Point(4, 4)
        Me.Male.Name = "Male"
        Me.Male.Padding = New System.Windows.Forms.Padding(3)
        Me.Male.Size = New System.Drawing.Size(774, 549)
        Me.Male.TabIndex = 0
        Me.Male.Text = "Male"
        '
        'M1
        '
        Me.M1.BackColor = System.Drawing.Color.Transparent
        Me.M1.Image = Global.BancoSeguro.My.Resources.Resources.profile500x
        Me.M1.Location = New System.Drawing.Point(47, 42)
        Me.M1.Name = "M1"
        Me.M1.Size = New System.Drawing.Size(136, 136)
        Me.M1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.M1.TabIndex = 22
        Me.M1.TabStop = False
        '
        'M2
        '
        Me.M2.BackColor = System.Drawing.Color.Transparent
        Me.M2.Image = Global.BancoSeguro.My.Resources.Resources.profile500x
        Me.M2.Location = New System.Drawing.Point(229, 42)
        Me.M2.Name = "M2"
        Me.M2.Size = New System.Drawing.Size(136, 136)
        Me.M2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.M2.TabIndex = 23
        Me.M2.TabStop = False
        '
        'M3
        '
        Me.M3.BackColor = System.Drawing.Color.Transparent
        Me.M3.Image = Global.BancoSeguro.My.Resources.Resources.profile500x
        Me.M3.Location = New System.Drawing.Point(406, 42)
        Me.M3.Name = "M3"
        Me.M3.Size = New System.Drawing.Size(136, 136)
        Me.M3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.M3.TabIndex = 24
        Me.M3.TabStop = False
        '
        'M4
        '
        Me.M4.BackColor = System.Drawing.Color.Transparent
        Me.M4.Image = Global.BancoSeguro.My.Resources.Resources.profile500x
        Me.M4.Location = New System.Drawing.Point(592, 42)
        Me.M4.Name = "M4"
        Me.M4.Size = New System.Drawing.Size(136, 136)
        Me.M4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.M4.TabIndex = 25
        Me.M4.TabStop = False
        '
        'M5
        '
        Me.M5.BackColor = System.Drawing.Color.Transparent
        Me.M5.Image = Global.BancoSeguro.My.Resources.Resources.profile500x
        Me.M5.Location = New System.Drawing.Point(47, 204)
        Me.M5.Name = "M5"
        Me.M5.Size = New System.Drawing.Size(136, 136)
        Me.M5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.M5.TabIndex = 26
        Me.M5.TabStop = False
        '
        'M6
        '
        Me.M6.BackColor = System.Drawing.Color.Transparent
        Me.M6.Image = Global.BancoSeguro.My.Resources.Resources.profile500x
        Me.M6.Location = New System.Drawing.Point(229, 204)
        Me.M6.Name = "M6"
        Me.M6.Size = New System.Drawing.Size(136, 136)
        Me.M6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.M6.TabIndex = 27
        Me.M6.TabStop = False
        '
        'M7
        '
        Me.M7.BackColor = System.Drawing.Color.Transparent
        Me.M7.Image = Global.BancoSeguro.My.Resources.Resources.profile500x
        Me.M7.Location = New System.Drawing.Point(406, 204)
        Me.M7.Name = "M7"
        Me.M7.Size = New System.Drawing.Size(136, 136)
        Me.M7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.M7.TabIndex = 28
        Me.M7.TabStop = False
        '
        'M8
        '
        Me.M8.BackColor = System.Drawing.Color.Transparent
        Me.M8.Image = Global.BancoSeguro.My.Resources.Resources.profile500x
        Me.M8.Location = New System.Drawing.Point(592, 204)
        Me.M8.Name = "M8"
        Me.M8.Size = New System.Drawing.Size(136, 136)
        Me.M8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.M8.TabIndex = 29
        Me.M8.TabStop = False
        '
        'M9
        '
        Me.M9.BackColor = System.Drawing.Color.Transparent
        Me.M9.Image = Global.BancoSeguro.My.Resources.Resources.profile500x
        Me.M9.Location = New System.Drawing.Point(47, 371)
        Me.M9.Name = "M9"
        Me.M9.Size = New System.Drawing.Size(136, 136)
        Me.M9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.M9.TabIndex = 30
        Me.M9.TabStop = False
        '
        'M10
        '
        Me.M10.BackColor = System.Drawing.Color.Transparent
        Me.M10.Image = Global.BancoSeguro.My.Resources.Resources.profile500x
        Me.M10.Location = New System.Drawing.Point(229, 371)
        Me.M10.Name = "M10"
        Me.M10.Size = New System.Drawing.Size(136, 136)
        Me.M10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.M10.TabIndex = 31
        Me.M10.TabStop = False
        '
        'M11
        '
        Me.M11.BackColor = System.Drawing.Color.Transparent
        Me.M11.Image = Global.BancoSeguro.My.Resources.Resources.profile500x
        Me.M11.Location = New System.Drawing.Point(406, 371)
        Me.M11.Name = "M11"
        Me.M11.Size = New System.Drawing.Size(136, 136)
        Me.M11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.M11.TabIndex = 32
        Me.M11.TabStop = False
        '
        'M12
        '
        Me.M12.BackColor = System.Drawing.Color.Transparent
        Me.M12.Image = Global.BancoSeguro.My.Resources.Resources.profile500x
        Me.M12.Location = New System.Drawing.Point(592, 371)
        Me.M12.Name = "M12"
        Me.M12.Size = New System.Drawing.Size(136, 136)
        Me.M12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.M12.TabIndex = 33
        Me.M12.TabStop = False
        '
        'GenderTab
        '
        Me.GenderTab.Alignment = System.Windows.Forms.TabAlignment.Bottom
        Me.GenderTab.Controls.Add(Me.Male)
        Me.GenderTab.Controls.Add(Me.Female)
        Me.GenderTab.Font = New System.Drawing.Font("Agency FB", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenderTab.Location = New System.Drawing.Point(67, 80)
        Me.GenderTab.Name = "GenderTab"
        Me.GenderTab.SelectedIndex = 0
        Me.GenderTab.Size = New System.Drawing.Size(782, 602)
        Me.GenderTab.TabIndex = 23
        '
        'ProfilePicker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(910, 706)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ProfilePicker"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ProfilePicker"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.CloseBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Female.ResumeLayout(False)
        CType(Me.F1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.F2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.F3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.F4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.F5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.F6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.F7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.F8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Male.ResumeLayout(False)
        CType(Me.M1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.M2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.M3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.M4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.M5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.M6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.M7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.M8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.M9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.M10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.M11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.M12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GenderTab.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CloseBtn As System.Windows.Forms.PictureBox
    Friend WithEvents DepositLbl As System.Windows.Forms.Label
    Friend WithEvents GenderTab As System.Windows.Forms.TabControl
    Friend WithEvents Male As System.Windows.Forms.TabPage
    Friend WithEvents M12 As System.Windows.Forms.PictureBox
    Friend WithEvents M11 As System.Windows.Forms.PictureBox
    Friend WithEvents M10 As System.Windows.Forms.PictureBox
    Friend WithEvents M9 As System.Windows.Forms.PictureBox
    Friend WithEvents M8 As System.Windows.Forms.PictureBox
    Friend WithEvents M7 As System.Windows.Forms.PictureBox
    Friend WithEvents M6 As System.Windows.Forms.PictureBox
    Friend WithEvents M5 As System.Windows.Forms.PictureBox
    Friend WithEvents M4 As System.Windows.Forms.PictureBox
    Friend WithEvents M3 As System.Windows.Forms.PictureBox
    Friend WithEvents M2 As System.Windows.Forms.PictureBox
    Friend WithEvents M1 As System.Windows.Forms.PictureBox
    Friend WithEvents Female As System.Windows.Forms.TabPage
    Friend WithEvents F8 As System.Windows.Forms.PictureBox
    Friend WithEvents F7 As System.Windows.Forms.PictureBox
    Friend WithEvents F6 As System.Windows.Forms.PictureBox
    Friend WithEvents F5 As System.Windows.Forms.PictureBox
    Friend WithEvents F4 As System.Windows.Forms.PictureBox
    Friend WithEvents F3 As System.Windows.Forms.PictureBox
    Friend WithEvents F2 As System.Windows.Forms.PictureBox
    Friend WithEvents F1 As System.Windows.Forms.PictureBox
End Class
