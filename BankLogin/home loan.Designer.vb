
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class home_loan
    Inherits System.Windows.Forms.Form
    Dim numberofYear As Integer
    Dim iMonthlyPayment, iTotalPayment As String
    Dim InterestRate, mahthlyInterestRate, EnterAmountOfLoan, MonthlyPayment, TotalPayment As Double
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Labeltp = New System.Windows.Forms.Label()
        Me.Labelmntp = New System.Windows.Forms.Label()
        Me.Labelrate = New System.Windows.Forms.Label()
        Me.Labelyr = New System.Windows.Forms.Label()
        Me.Labelamt = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(2, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(960, 122)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Agency FB", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(34, -22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(235, 143)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Loan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Transparent
        Me.Label2.Image = Global.BancoSeguro.My.Resources.Resources.AppBGLowRez
        Me.Label2.Location = New System.Drawing.Point(39, 198)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter Amount Of Loan :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Transparent
        Me.Label3.Image = Global.BancoSeguro.My.Resources.Resources.AppBGLowRez
        Me.Label3.Location = New System.Drawing.Point(39, 259)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Enter No Of Year"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Transparent
        Me.Label4.Image = Global.BancoSeguro.My.Resources.Resources.AppBGLowRez
        Me.Label4.Location = New System.Drawing.Point(39, 326)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Enter Interest  Rate"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Transparent
        Me.Label5.Image = Global.BancoSeguro.My.Resources.Resources.AppBGLowRez
        Me.Label5.Location = New System.Drawing.Point(39, 463)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 24)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Monthly Payement "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Transparent
        Me.Label6.Image = Global.BancoSeguro.My.Resources.Resources.AppBGLowRez
        Me.Label6.Location = New System.Drawing.Point(39, 539)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 24)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Total Payment"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Black
        Me.TextBox1.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.Info
        Me.TextBox1.Location = New System.Drawing.Point(215, 198)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(238, 31)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.Black
        Me.TextBox2.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.SystemColors.Info
        Me.TextBox2.Location = New System.Drawing.Point(215, 259)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(238, 31)
        Me.TextBox2.TabIndex = 6
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.Black
        Me.TextBox3.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.ForeColor = System.Drawing.SystemColors.Info
        Me.TextBox3.Location = New System.Drawing.Point(215, 330)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(238, 31)
        Me.TextBox3.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Labeltp)
        Me.GroupBox1.Controls.Add(Me.Labelmntp)
        Me.GroupBox1.Controls.Add(Me.Labelrate)
        Me.GroupBox1.Controls.Add(Me.Labelyr)
        Me.GroupBox1.Controls.Add(Me.Labelamt)
        Me.GroupBox1.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(547, 180)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(353, 387)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Receipt"
        Me.GroupBox1.Visible = False
        '
        'Labeltp
        '
        Me.Labeltp.AutoSize = True
        Me.Labeltp.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labeltp.ForeColor = System.Drawing.Color.Transparent
        Me.Labeltp.Image = Global.BancoSeguro.My.Resources.Resources.AppBGLowRez
        Me.Labeltp.Location = New System.Drawing.Point(31, 261)
        Me.Labeltp.Name = "Labeltp"
        Me.Labeltp.Size = New System.Drawing.Size(100, 24)
        Me.Labeltp.TabIndex = 19
        Me.Labeltp.Text = "Total Payment : "
        '
        'Labelmntp
        '
        Me.Labelmntp.AutoSize = True
        Me.Labelmntp.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelmntp.ForeColor = System.Drawing.Color.Transparent
        Me.Labelmntp.Image = Global.BancoSeguro.My.Resources.Resources.AppBGLowRez
        Me.Labelmntp.Location = New System.Drawing.Point(30, 218)
        Me.Labelmntp.Name = "Labelmntp"
        Me.Labelmntp.Size = New System.Drawing.Size(123, 24)
        Me.Labelmntp.TabIndex = 18
        Me.Labelmntp.Text = "Monthly Payement : "
        '
        'Labelrate
        '
        Me.Labelrate.AutoSize = True
        Me.Labelrate.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelrate.ForeColor = System.Drawing.Color.Transparent
        Me.Labelrate.Image = Global.BancoSeguro.My.Resources.Resources.AppBGLowRez
        Me.Labelrate.Location = New System.Drawing.Point(30, 173)
        Me.Labelrate.Name = "Labelrate"
        Me.Labelrate.Size = New System.Drawing.Size(100, 24)
        Me.Labelrate.TabIndex = 17
        Me.Labelrate.Text = "Interest  Rate : "
        '
        'Labelyr
        '
        Me.Labelyr.AutoSize = True
        Me.Labelyr.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelyr.ForeColor = System.Drawing.Color.Transparent
        Me.Labelyr.Image = Global.BancoSeguro.My.Resources.Resources.AppBGLowRez
        Me.Labelyr.Location = New System.Drawing.Point(30, 125)
        Me.Labelyr.Name = "Labelyr"
        Me.Labelyr.Size = New System.Drawing.Size(82, 24)
        Me.Labelyr.TabIndex = 16
        Me.Labelyr.Text = "No Of Year : "
        '
        'Labelamt
        '
        Me.Labelamt.AutoSize = True
        Me.Labelamt.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelamt.ForeColor = System.Drawing.Color.Transparent
        Me.Labelamt.Image = Global.BancoSeguro.My.Resources.Resources.AppBGLowRez
        Me.Labelamt.Location = New System.Drawing.Point(31, 81)
        Me.Labelamt.Name = "Labelamt"
        Me.Labelamt.Size = New System.Drawing.Size(109, 24)
        Me.Labelamt.TabIndex = 2
        Me.Labelamt.Text = "Amount Of Loan : "
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.BancoSeguro.My.Resources.Resources.AppBGLowRez
        Me.Button2.Location = New System.Drawing.Point(108, 679)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(163, 47)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Receipt"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.BancoSeguro.My.Resources.Resources.AppBGLowRez
        Me.Button3.Location = New System.Drawing.Point(737, 605)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(126, 49)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "Exit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = Global.BancoSeguro.My.Resources.Resources.AppBGLowRez
        Me.Button4.Location = New System.Drawing.Point(581, 607)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(127, 47)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = "Reset"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.Black
        Me.TextBox4.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.ForeColor = System.Drawing.SystemColors.Info
        Me.TextBox4.Location = New System.Drawing.Point(215, 467)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(238, 31)
        Me.TextBox4.TabIndex = 14
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.Black
        Me.TextBox5.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.ForeColor = System.Drawing.Color.White
        Me.TextBox5.Location = New System.Drawing.Point(215, 543)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(238, 31)
        Me.TextBox5.TabIndex = 15
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.BancoSeguro.My.Resources.Resources.AppBGLowRez
        Me.Button1.Location = New System.Drawing.Point(263, 387)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(127, 47)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Calculate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'home_loan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BancoSeguro.My.Resources.Resources.AppBG
        Me.ClientSize = New System.Drawing.Size(960, 762)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "home_loan"
        Me.Text = "home_loan"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim iExit As DialogResult
        iExit = MessageBox.Show("Confirm if you want to exit", "Loan System", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        Application.Exit()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        GroupBox1.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Then
            MsgBox("Cannot be Empty!")
        Else
            GroupBox1.Visible = True
            Labelamt.Text &= "" & TextBox1.Text
            Labelyr.Text &= "" & TextBox2.Text
            Labelrate.Text &= "" & TextBox3.Text
            Labelmntp.Text &= "" & TextBox4.Text
            Labeltp.Text &= "" & TextBox5.Text
        End If
    End Sub

    Friend WithEvents Labelamt As System.Windows.Forms.Label
    Friend WithEvents Labeltp As System.Windows.Forms.Label
    Friend WithEvents Labelmntp As System.Windows.Forms.Label
    Friend WithEvents Labelrate As System.Windows.Forms.Label
    Friend WithEvents Labelyr As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim LoanAmount, Interest, Tenure, Emi As Decimal
        Try


            LoanAmount = Decimal.Parse(TextBox1.Text)
            Interest = Decimal.Parse(TextBox2.Text)
            Tenure = Decimal.Parse(TextBox3.Text)
        Catch ex As Exception
            MsgBox("Enter All the Fields!!")
        End Try
        Interest = Interest / 1200

        Emi = LoanAmount * Interest * (Math.Pow((1 + Interest), Tenure) / (Math.Pow((1 + Interest), Tenure) - 1))

        TextBox4.Text = Math.Round(Emi, 0)
        '   TextBox5.Text = Math.Round((Emi * Tenure) - LoanAmount, 0)
        TextBox5.Text = Math.Round(Emi * Tenure, 0)
    End Sub

   
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class

