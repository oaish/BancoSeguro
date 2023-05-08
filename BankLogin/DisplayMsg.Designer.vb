<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DisplayMsg
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
        Me.MessageLbl = New System.Windows.Forms.Label()
        Me.OkBtn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MessageLbl
        '
        Me.MessageLbl.AutoSize = True
        Me.MessageLbl.BackColor = System.Drawing.Color.Transparent
        Me.MessageLbl.Font = New System.Drawing.Font("Agency FB", 30.0!, System.Drawing.FontStyle.Bold)
        Me.MessageLbl.ForeColor = System.Drawing.SystemColors.Window
        Me.MessageLbl.Location = New System.Drawing.Point(12, 22)
        Me.MessageLbl.Name = "MessageLbl"
        Me.MessageLbl.Size = New System.Drawing.Size(362, 61)
        Me.MessageLbl.TabIndex = 5
        Me.MessageLbl.Text = "Deposit Successful"
        '
        'OkBtn
        '
        Me.OkBtn.AutoSize = True
        Me.OkBtn.BackColor = System.Drawing.SystemColors.HotTrack
        Me.OkBtn.BackgroundImage = Global.BancoSeguro.My.Resources.Resources.AppBGBlur
        Me.OkBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.OkBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OkBtn.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OkBtn.ForeColor = System.Drawing.SystemColors.Window
        Me.OkBtn.Location = New System.Drawing.Point(154, 93)
        Me.OkBtn.Name = "OkBtn"
        Me.OkBtn.Size = New System.Drawing.Size(55, 48)
        Me.OkBtn.TabIndex = 6
        Me.OkBtn.Text = "Ok"
        Me.OkBtn.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.OkBtn)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(379, 171)
        Me.Panel1.TabIndex = 12
        '
        'DisplayMsg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = Global.BancoSeguro.My.Resources.Resources.AppBG
        Me.ClientSize = New System.Drawing.Size(379, 171)
        Me.Controls.Add(Me.MessageLbl)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DisplayMsg"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Dialog2"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MessageLbl As System.Windows.Forms.Label
    Friend WithEvents OkBtn As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

End Class
