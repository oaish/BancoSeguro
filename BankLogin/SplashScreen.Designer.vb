<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SplashScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SplashScreen))
        Me.BankLogo = New System.Windows.Forms.PictureBox()
        Me.BankName = New System.Windows.Forms.Label()
        Me.LoadText = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.BankLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BankLogo
        '
        Me.BankLogo.BackColor = System.Drawing.Color.Transparent
        Me.BankLogo.Image = CType(resources.GetObject("BankLogo.Image"), System.Drawing.Image)
        Me.BankLogo.Location = New System.Drawing.Point(74, 20)
        Me.BankLogo.Name = "BankLogo"
        Me.BankLogo.Size = New System.Drawing.Size(152, 140)
        Me.BankLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BankLogo.TabIndex = 7
        Me.BankLogo.TabStop = False
        '
        'BankName
        '
        Me.BankName.AutoSize = True
        Me.BankName.BackColor = System.Drawing.Color.Transparent
        Me.BankName.Font = New System.Drawing.Font("Agency FB", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BankName.ForeColor = System.Drawing.SystemColors.Window
        Me.BankName.Location = New System.Drawing.Point(21, 163)
        Me.BankName.Name = "BankName"
        Me.BankName.Size = New System.Drawing.Size(273, 61)
        Me.BankName.TabIndex = 8
        Me.BankName.Text = "Banco Seguro"
        '
        'LoadText
        '
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.BankLogo)
        Me.Panel1.Controls.Add(Me.BankName)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(305, 264)
        Me.Panel1.TabIndex = 10
        '
        'SplashScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackgroundImage = Global.BancoSeguro.My.Resources.Resources.AppBG
        Me.ClientSize = New System.Drawing.Size(305, 264)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SplashScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        CType(Me.BankLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BankLogo As System.Windows.Forms.PictureBox
    Friend WithEvents BankName As System.Windows.Forms.Label
    Friend WithEvents LoadText As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
