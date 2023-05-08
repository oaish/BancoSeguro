<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Delete
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
        Me.SearchAccPanel = New System.Windows.Forms.GroupBox()
        Me.ErrorLabel = New System.Windows.Forms.Label()
        Me.SearchBtn = New System.Windows.Forms.Button()
        Me.AccSearchBox = New System.Windows.Forms.TextBox()
        Me.SearchAccPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'SearchAccPanel
        '
        Me.SearchAccPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.SearchAccPanel.Controls.Add(Me.ErrorLabel)
        Me.SearchAccPanel.Controls.Add(Me.SearchBtn)
        Me.SearchAccPanel.Controls.Add(Me.AccSearchBox)
        Me.SearchAccPanel.Font = New System.Drawing.Font("Agency FB", 20.0!, System.Drawing.FontStyle.Bold)
        Me.SearchAccPanel.ForeColor = System.Drawing.Color.White
        Me.SearchAccPanel.Location = New System.Drawing.Point(273, 257)
        Me.SearchAccPanel.Name = "SearchAccPanel"
        Me.SearchAccPanel.Size = New System.Drawing.Size(364, 147)
        Me.SearchAccPanel.TabIndex = 27
        Me.SearchAccPanel.TabStop = False
        Me.SearchAccPanel.Text = "Enter Account No"
        '
        'ErrorLabel
        '
        Me.ErrorLabel.AutoSize = True
        Me.ErrorLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ErrorLabel.Font = New System.Drawing.Font("Agency FB", 15.0!)
        Me.ErrorLabel.Location = New System.Drawing.Point(17, 106)
        Me.ErrorLabel.Name = "ErrorLabel"
        Me.ErrorLabel.Size = New System.Drawing.Size(63, 29)
        Me.ErrorLabel.TabIndex = 21
        Me.ErrorLabel.Text = "Error :"
        Me.ErrorLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.ErrorLabel.Visible = False
        '
        'SearchBtn
        '
        Me.SearchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SearchBtn.FlatAppearance.BorderSize = 0
        Me.SearchBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.SearchBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchBtn.Font = New System.Drawing.Font("Agency FB", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchBtn.ForeColor = System.Drawing.Color.White
        Me.SearchBtn.Image = Global.BancoSeguro.My.Resources.Resources.searchacc30x
        Me.SearchBtn.Location = New System.Drawing.Point(309, 52)
        Me.SearchBtn.Name = "SearchBtn"
        Me.SearchBtn.Size = New System.Drawing.Size(35, 47)
        Me.SearchBtn.TabIndex = 13
        Me.SearchBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.SearchBtn.UseVisualStyleBackColor = True
        '
        'AccSearchBox
        '
        Me.AccSearchBox.Font = New System.Drawing.Font("Agency FB", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccSearchBox.Location = New System.Drawing.Point(16, 52)
        Me.AccSearchBox.Name = "AccSearchBox"
        Me.AccSearchBox.Size = New System.Drawing.Size(278, 47)
        Me.AccSearchBox.TabIndex = 11
        '
        'Delete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.SearchAccPanel)
        Me.Name = "Delete"
        Me.Size = New System.Drawing.Size(911, 660)
        Me.SearchAccPanel.ResumeLayout(False)
        Me.SearchAccPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SearchAccPanel As System.Windows.Forms.GroupBox
    Friend WithEvents ErrorLabel As System.Windows.Forms.Label
    Friend WithEvents SearchBtn As System.Windows.Forms.Button
    Friend WithEvents AccSearchBox As System.Windows.Forms.TextBox

End Class
