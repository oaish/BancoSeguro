Public Class Login
    Public User As String
    Public Pass As String
    Public EmpID As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles Username.Enter
        If Username.Text = "" Or Username.Text = "Enter Username" Then
            Username.Text = ""
            Username.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TextBox2_Click(sender As Object, e As EventArgs) Handles Password.Enter
        If Password.Text = "" Or Password.Text = "Enter Password" Then
            Password.Text = ""
            Password.ForeColor = Color.Black
            Password.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles Password.TextChanged
        If Password.Text = "" Or Password.Text = "Enter Password" Then
            PassIco.Image = My.Resources.passLock
        ElseIf Password.UseSystemPasswordChar Then
            PassIco.Image = My.Resources.passShow
        Else
            PassIco.Image = My.Resources.passHide
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)
        If Password.UseSystemPasswordChar Then
            Password.UseSystemPasswordChar = False
        Else
            Password.UseSystemPasswordChar = True
        End If
        Password.SelectionStart = Password.Text.Length
    End Sub

    Private Sub Username_GotFocus(sender As Object, e As EventArgs) Handles Username.GotFocus
        If Not Me.ActiveControl Is sender Then
            ' Set the focus to the TextBox control
            sender.Focus()
        End If
    End Sub

    Private Sub TextBox1_Validated(sender As Object, e As EventArgs) Handles Username.Validating
        If Username.Text = "" Then
            Username.ForeColor = Color.Gray
            Username.Text = "Enter Username"
        End If
    End Sub

    Private Sub TextBox2_Validated(sender As Object, e As EventArgs) Handles Password.Validating
        If Password.Text = "" Then
            Password.ForeColor = Color.Gray
            Password.Text = "Enter Password"
            Password.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        Dim conn As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=BancoSeguro.mdb;")
        Dim query = "SELECT Username, Password, Emp_Position, E.Emp_ID FROM Employee E INNER JOIN Login L ON E.Emp_ID = L.Emp_ID"
        Dim adp As New OleDb.OleDbDataAdapter(query, conn)
        Dim dt As New DataTable
        adp.Fill(dt)
        Dim CanLogin As Boolean = False
        Dim Role As String = ""

        For x = 0 To dt.Rows.Count - 1
            If Username.Text = dt.Rows(x)("Username").ToString Then
                If Password.Text = dt.Rows(x)("Password").ToString Then
                    CanLogin = True
                    User = dt.Rows(x)("Username").ToString()
                    Pass = dt.Rows(x)("Password").ToString
                    Role = dt.Rows(x)("Emp_Position").ToString()
                    EmpID = dt.Rows(x)("Emp_ID").ToString()
                End If
            End If
        Next

        If CanLogin Then
            If Role = "Admin" Then
                AdminForm.Show()
                Me.Close()
            End If
            If Role = "Bank Teller" Then
                Main.Show()
                Me.Close()
            End If
            If Role = "Loan Officer" Then
                Loan.Show()
                Me.Close()
            End If
        Else
            DisplayMsg.Message = "Invalid Username Or Password"
            DisplayMsg.ShowDialog()
            Username.ForeColor = Color.Gray
            Username.Text = "Enter Username"
            Password.ForeColor = Color.Gray
            Password.Text = "Enter Password"
            Password.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub CloseBtn1_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PassIco.Click
        If Password.UseSystemPasswordChar Then
            PassIco.Image = My.Resources.passHide
            Password.UseSystemPasswordChar = False
        Else
            PassIco.Image = My.Resources.passShow
            Password.UseSystemPasswordChar = True
        End If
        Password.SelectionStart = Password.Text.Length
    End Sub

End Class
