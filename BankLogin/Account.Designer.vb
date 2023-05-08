<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Account
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.EmpUpdateBtn = New System.Windows.Forms.Button()
        Me.EmpViewBtn = New System.Windows.Forms.Button()
        Me.EmpCreateBtn = New System.Windows.Forms.Button()
        Me.EmpDeleteBtn = New System.Windows.Forms.Button()
        Me.UpdateBtn = New System.Windows.Forms.Button()
        Me.CustViewBtn = New System.Windows.Forms.Button()
        Me.CreateBtn = New System.Windows.Forms.Button()
        Me.DeleteBtn = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.UpdateBtn)
        Me.GroupBox1.Controls.Add(Me.CustViewBtn)
        Me.GroupBox1.Controls.Add(Me.CreateBtn)
        Me.GroupBox1.Controls.Add(Me.DeleteBtn)
        Me.GroupBox1.Font = New System.Drawing.Font("Agency FB", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(88, 64)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(734, 211)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.EmpUpdateBtn)
        Me.GroupBox2.Controls.Add(Me.EmpViewBtn)
        Me.GroupBox2.Controls.Add(Me.EmpCreateBtn)
        Me.GroupBox2.Controls.Add(Me.EmpDeleteBtn)
        Me.GroupBox2.Font = New System.Drawing.Font("Agency FB", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(88, 355)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(734, 211)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Employee"
        '
        'EmpUpdateBtn
        '
        Me.EmpUpdateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.EmpUpdateBtn.FlatAppearance.BorderSize = 2
        Me.EmpUpdateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.EmpUpdateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.EmpUpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EmpUpdateBtn.Font = New System.Drawing.Font("Agency FB", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpUpdateBtn.ForeColor = System.Drawing.Color.White
        Me.EmpUpdateBtn.Image = Global.BancoSeguro.My.Resources.Resources.update30x
        Me.EmpUpdateBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.EmpUpdateBtn.Location = New System.Drawing.Point(208, 71)
        Me.EmpUpdateBtn.Name = "EmpUpdateBtn"
        Me.EmpUpdateBtn.Size = New System.Drawing.Size(140, 88)
        Me.EmpUpdateBtn.TabIndex = 20
        Me.EmpUpdateBtn.Text = "Update"
        Me.EmpUpdateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EmpUpdateBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.EmpUpdateBtn.UseVisualStyleBackColor = True
        '
        'EmpViewBtn
        '
        Me.EmpViewBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.EmpViewBtn.FlatAppearance.BorderSize = 2
        Me.EmpViewBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.EmpViewBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.EmpViewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EmpViewBtn.Font = New System.Drawing.Font("Agency FB", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpViewBtn.ForeColor = System.Drawing.Color.White
        Me.EmpViewBtn.Image = Global.BancoSeguro.My.Resources.Resources.create30x
        Me.EmpViewBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.EmpViewBtn.Location = New System.Drawing.Point(564, 71)
        Me.EmpViewBtn.Name = "EmpViewBtn"
        Me.EmpViewBtn.Size = New System.Drawing.Size(140, 88)
        Me.EmpViewBtn.TabIndex = 22
        Me.EmpViewBtn.Text = "View"
        Me.EmpViewBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EmpViewBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.EmpViewBtn.UseVisualStyleBackColor = True
        '
        'EmpCreateBtn
        '
        Me.EmpCreateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.EmpCreateBtn.FlatAppearance.BorderSize = 2
        Me.EmpCreateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.EmpCreateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.EmpCreateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EmpCreateBtn.Font = New System.Drawing.Font("Agency FB", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpCreateBtn.ForeColor = System.Drawing.Color.White
        Me.EmpCreateBtn.Image = Global.BancoSeguro.My.Resources.Resources.create_30x
        Me.EmpCreateBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.EmpCreateBtn.Location = New System.Drawing.Point(30, 71)
        Me.EmpCreateBtn.Name = "EmpCreateBtn"
        Me.EmpCreateBtn.Size = New System.Drawing.Size(140, 88)
        Me.EmpCreateBtn.TabIndex = 19
        Me.EmpCreateBtn.Text = "Create"
        Me.EmpCreateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EmpCreateBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.EmpCreateBtn.UseVisualStyleBackColor = True
        '
        'EmpDeleteBtn
        '
        Me.EmpDeleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.EmpDeleteBtn.FlatAppearance.BorderSize = 2
        Me.EmpDeleteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.EmpDeleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.EmpDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EmpDeleteBtn.Font = New System.Drawing.Font("Agency FB", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpDeleteBtn.ForeColor = System.Drawing.Color.White
        Me.EmpDeleteBtn.Image = Global.BancoSeguro.My.Resources.Resources.delete30x
        Me.EmpDeleteBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.EmpDeleteBtn.Location = New System.Drawing.Point(386, 71)
        Me.EmpDeleteBtn.Name = "EmpDeleteBtn"
        Me.EmpDeleteBtn.Size = New System.Drawing.Size(140, 88)
        Me.EmpDeleteBtn.TabIndex = 21
        Me.EmpDeleteBtn.Text = "Delete"
        Me.EmpDeleteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EmpDeleteBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.EmpDeleteBtn.UseVisualStyleBackColor = True
        '
        'UpdateBtn
        '
        Me.UpdateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UpdateBtn.FlatAppearance.BorderSize = 2
        Me.UpdateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.UpdateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UpdateBtn.Font = New System.Drawing.Font("Agency FB", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateBtn.ForeColor = System.Drawing.Color.White
        Me.UpdateBtn.Image = Global.BancoSeguro.My.Resources.Resources.update30x
        Me.UpdateBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UpdateBtn.Location = New System.Drawing.Point(208, 71)
        Me.UpdateBtn.Name = "UpdateBtn"
        Me.UpdateBtn.Size = New System.Drawing.Size(140, 88)
        Me.UpdateBtn.TabIndex = 20
        Me.UpdateBtn.Text = "Update"
        Me.UpdateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UpdateBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.UpdateBtn.UseVisualStyleBackColor = True
        '
        'CustViewBtn
        '
        Me.CustViewBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CustViewBtn.FlatAppearance.BorderSize = 2
        Me.CustViewBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.CustViewBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.CustViewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CustViewBtn.Font = New System.Drawing.Font("Agency FB", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustViewBtn.ForeColor = System.Drawing.Color.White
        Me.CustViewBtn.Image = Global.BancoSeguro.My.Resources.Resources.create30x
        Me.CustViewBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CustViewBtn.Location = New System.Drawing.Point(564, 71)
        Me.CustViewBtn.Name = "CustViewBtn"
        Me.CustViewBtn.Size = New System.Drawing.Size(140, 88)
        Me.CustViewBtn.TabIndex = 22
        Me.CustViewBtn.Text = "View"
        Me.CustViewBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CustViewBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CustViewBtn.UseVisualStyleBackColor = True
        '
        'CreateBtn
        '
        Me.CreateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CreateBtn.FlatAppearance.BorderSize = 2
        Me.CreateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.CreateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.CreateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CreateBtn.Font = New System.Drawing.Font("Agency FB", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreateBtn.ForeColor = System.Drawing.Color.White
        Me.CreateBtn.Image = Global.BancoSeguro.My.Resources.Resources.create_30x
        Me.CreateBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CreateBtn.Location = New System.Drawing.Point(30, 71)
        Me.CreateBtn.Name = "CreateBtn"
        Me.CreateBtn.Size = New System.Drawing.Size(140, 88)
        Me.CreateBtn.TabIndex = 19
        Me.CreateBtn.Text = "Create"
        Me.CreateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CreateBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CreateBtn.UseVisualStyleBackColor = True
        '
        'DeleteBtn
        '
        Me.DeleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DeleteBtn.FlatAppearance.BorderSize = 2
        Me.DeleteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.DeleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteBtn.Font = New System.Drawing.Font("Agency FB", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteBtn.ForeColor = System.Drawing.Color.White
        Me.DeleteBtn.Image = Global.BancoSeguro.My.Resources.Resources.delete30x
        Me.DeleteBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DeleteBtn.Location = New System.Drawing.Point(386, 71)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.Size = New System.Drawing.Size(140, 88)
        Me.DeleteBtn.TabIndex = 21
        Me.DeleteBtn.Text = "Delete"
        Me.DeleteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DeleteBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.DeleteBtn.UseVisualStyleBackColor = True
        '
        'Account
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.Transparent
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Account"
        Me.Size = New System.Drawing.Size(911, 660)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CustViewBtn As System.Windows.Forms.Button
    Friend WithEvents DeleteBtn As System.Windows.Forms.Button
    Friend WithEvents UpdateBtn As System.Windows.Forms.Button
    Friend WithEvents CreateBtn As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents EmpUpdateBtn As System.Windows.Forms.Button
    Friend WithEvents EmpViewBtn As System.Windows.Forms.Button
    Friend WithEvents EmpCreateBtn As System.Windows.Forms.Button
    Friend WithEvents EmpDeleteBtn As System.Windows.Forms.Button

End Class
