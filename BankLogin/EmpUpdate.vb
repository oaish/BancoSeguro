Imports System.Data.OleDb
Imports System.Text.RegularExpressions

Public Class EmpUpdate
    Public conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=BancoSeguro.mdb;")
    Public cmd As OleDbCommand
    Public dt As New DataTable
    Public adp As OleDbDataAdapter
    Public query As String
    Dim CanProceed As Boolean = True


    Sub ReadOnlyTB(isReadOnly As Boolean)
        If isReadOnly Then
            NameTxt.Enabled = False
            DOBTxt.Enabled = False
            PhoneNoTxt.Enabled = False
            EmailIDTxt.Enabled = False
            AddressTxt.Enabled = False
            ChooseBtn.Enabled = False
            RoleBox.Enabled = False
        Else
            NameTxt.Enabled = True
            DOBTxt.Enabled = True
            PhoneNoTxt.Enabled = True
            EmailIDTxt.Enabled = True
            AddressTxt.Enabled = True
            ChooseBtn.Enabled = True
            RoleBox.Enabled = True
        End If
    End Sub

    Private Sub EmpUpdate_Load(sender As Object, e As EventArgs) Handles Me.Load
        ReadOnlyTB(True)
    End Sub

    Private Sub UpdateBtn_Click(sender As Object, e As EventArgs) Handles UpdateBtn.Click
        ReadOnlyTB(False)
    End Sub

    Private Sub SubmitBtn_Click(sender As Object, e As EventArgs) Handles SubmitBtn.Click
        CheckIfEmpty()
        If CanProceed Then
            Dim Role = RoleBox.SelectedItem.ToString()
            Dim EmpID As Integer

            conn.Open()
            query = "SELECT E.Emp_ID FROM Employee E INNER JOIN Login L ON E.Emp_ID = L.Emp_ID WHERE username = @user"
            cmd = New OleDbCommand(query, conn)
            cmd.Parameters.AddWithValue("@user", UsernameTxt.Text)
            EmpID = cmd.ExecuteScalar()
            conn.Close()

            conn.Open()
            query = "UPDATE Employee SET Emp_Name = @Name, Emp_DOB = @DOB, Emp_Phone = @Phone, Emp_Email = @Email, Emp_Address = @Address, Emp_Profile =  @Profile, Emp_Position = @Role WHERE Emp_ID = @ID"
            cmd = New OleDbCommand(query, conn)
            cmd.Parameters.AddWithValue("@Name", NameTxt.Text)
            cmd.Parameters.AddWithValue("@DOB", DOBTxt.Text)
            cmd.Parameters.AddWithValue("@Phone", PhoneNoTxt.Text)
            cmd.Parameters.AddWithValue("@Email", EmailIDTxt.Text)
            cmd.Parameters.AddWithValue("@Address", AddressTxt.Text)
            cmd.Parameters.AddWithValue("@Profile", ProfilePic.Tag)
            cmd.Parameters.AddWithValue("@Role", Role)
            cmd.Parameters.AddWithValue("@ID", EmpID)
            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(query & vbCrLf & vbCrLf & ex.Message)
            End Try

            conn.Close()

            DisplayMsg.Message = ("Employee Updated Succesfully")
            DisplayMsg.ShowDialog()
            AdminForm.BackBtn_Click(e, e)
        End If
    End Sub

    Private Sub ENextBtn_Click(sender As Object, e As EventArgs) Handles ENextBtn.Click
        IntializeAccountDetails()
        If UsernameTxt.Text = "" Or PasswordTxt.Text = "" Then
            ErrorProviderX.SetError(sender, "Error: All Fields Are Required")
            Exit Sub
        End If
        If CanProceed Then
            ErrorProviderX.SetError(sender, "")
            EmpDetailPanel.Visible = True
            LoginGB.Visible = False
        End If
    End Sub

    Sub IntializeAccountDetails()
        If UsernameTxt.Text.Equals("Admin") And PasswordTxt.Text.Equals("1234") Then
            ErrorProviderX.SetError(ENextBtn, "Error: Admin User cannot be modified")
            CanProceed = False
            Exit Sub
        Else
            If Not CanProceed Then
                ErrorProviderX.SetError(ENextBtn, "")
            End If
        End If
        query = "SELECT * FROM Employee E INNER JOIN Login L ON E.Emp_ID = L.Emp_ID WHERE username = '" & UsernameTxt.Text & "' AND password = '" & PasswordTxt.Text & "'"
        adp = New OleDbDataAdapter(query, conn)
        dt = New DataTable()
        Try
            conn.Open()
            adp.Fill(dt)
            If dt.Rows.Count = 0 Then
                Throw New KeyNotFoundException()
            End If
            NameTxt.Text = dt.Rows(0)("Emp_Name").ToString()
            DOBTxt.Text = dt.Rows(0)("Emp_DOB").ToString()
            PhoneNoTxt.Text = dt.Rows(0)("Emp_Phone").ToString()
            EmailIDTxt.Text = dt.Rows(0)("Emp_Email").ToString()
            AddressTxt.Text = dt.Rows(0)("Emp_Address").ToString()
            ProfilePic.ImageLocation = dt.Rows(0)("Emp_Profile").ToString()
            ProfilePic.Tag = dt.Rows(0)("Emp_Profile").ToString()
            RoleBox.SelectedIndex = RoleBox.Items.IndexOf(dt.Rows(0)("Emp_Position").ToString())
            dt.Clear()
        Catch ex As KeyNotFoundException
            DisplayMsg.Message = "Username or Password is Incorrect"
            DisplayMsg.ShowDialog()
            CanProceed = False
        Catch ex As Exception
            MsgBox(query & vbCrLf & vbCrLf & ex.Message)
            CanProceed = False
        Finally
            conn.Close()
        End Try

    End Sub

    Private Sub PassIco_Click(sender As Object, e As EventArgs) Handles PassIco.Click
        If PasswordTxt.UseSystemPasswordChar Then
            PassIco.Image = My.Resources.passHide
            PasswordTxt.UseSystemPasswordChar = False
            ShowPWLbl.Text = "Hide Password"
        Else
            PassIco.Image = My.Resources.passShow
            PasswordTxt.UseSystemPasswordChar = True
            ShowPWLbl.Text = "Show Password"
        End If
        PasswordTxt.SelectionStart = PasswordTxt.Text.Length
    End Sub

    Private Sub NameTxt_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles NameTxt.Validating
        If sender.Text = "" Then
            Exit Sub
        End If

        Dim RE As New Regex("^([a-zA-Z\s]+)$")
        If RE.IsMatch(sender.Text) Then
            ErrorProviderX.SetError(sender, "")
            CanProceed = True
        Else
            ErrorProviderX.SetError(sender, "Enter a Valid Name")
            CanProceed = False
        End If
    End Sub

    Private Sub DOBTxt_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles DOBTxt.Validating
        If sender.Text = "" Then
            Exit Sub
        End If

        Dim RE As New Regex("^(0?[1-9]|[1|2][0-9]|3[01])\/(0?[1-9]|1[0-2])\/(19[0-9]{2}|20[0-1][0-9]|202[0-3])$")
        If RE.IsMatch(sender.Text) Then
            RE = New Regex("^(0?[1-9]|[1|2][0-9]|3[01])\/(0?[1-9]|1[0-2])\/(19[0-9]{2}|200[0-5])$")
            If RE.IsMatch(sender.Text) Then
                ErrorProviderX.SetError(sender, "")
                CanProceed = True
            Else
                ErrorProviderX.SetError(sender, "Applicants must be at least 18 years old to open a bank account.")
                CanProceed = False
            End If
        Else
            ErrorProviderX.SetError(sender, "Error : Incorrect Date Format" & vbCrLf & "DOB Format : DD/MM/YYYY")
            CanProceed = False
        End If
    End Sub

    Private Sub PhoneNoTxt_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles PhoneNoTxt.Validating
        If sender.Text = "" Then
            Exit Sub
        End If

        Dim RE As New Regex("^([6-9][0-9]{9})$")
        If RE.IsMatch(sender.Text) Then
            ErrorProviderX.SetError(sender, "")
            CanProceed = True
        Else
            ErrorProviderX.SetError(sender, "Enter a Valid Phone Number")
            CanProceed = False
        End If
    End Sub

    Private Sub EmailIDTxt_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles EmailIDTxt.Validating
        If sender.Text = "" Then
            Exit Sub
        End If

        Dim RE As New Regex("^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$")
        If RE.IsMatch(sender.Text) Then
            ErrorProviderX.SetError(sender, "")
            CanProceed = True
        Else
            ErrorProviderX.SetError(sender, "Enter a Valid Email")
            CanProceed = False
        End If
    End Sub

    Sub CheckIfEmpty()
        If NameTxt.Text = "" Or DOBTxt.Text = "" Or PhoneNoTxt.Text = "" Or EmailIDTxt.Text = "" Or AddressTxt.Text = "" Then
            CanProceed = False
            ErrorProviderX.SetError(SubmitBtn, "Error : All Fields Are Required")
        ElseIf ProfilePic.ImageLocation = "" Then
            CanProceed = False
            ErrorProviderX.SetError(SubmitBtn, "Error : Choose a Profile Picture")
        End If
    End Sub

    Private Sub ChooseBtn_Click(sender As Object, e As EventArgs) Handles ChooseBtn.Click
        ProfileGB.Visible = True
        ProfileGB.BringToFront()
    End Sub

    Private Sub AM1_Click(sender As Object, e As EventArgs) Handles AM1.Click
        ProfilePic.ImageLocation = AM1.Tag
        ProfileGB.SendToBack()
    End Sub

    Private Sub AM2_Click(sender As Object, e As EventArgs) Handles AM2.Click
        ProfilePic.ImageLocation = AM2.Tag
        ProfileGB.SendToBack()
    End Sub

    Private Sub AM3_Click(sender As Object, e As EventArgs) Handles AM3.Click
        ProfilePic.ImageLocation = AM3.Tag
        ProfileGB.SendToBack()
    End Sub

    Private Sub AM4_Click(sender As Object, e As EventArgs) Handles AM4.Click
        ProfilePic.ImageLocation = AM4.Tag
        ProfileGB.SendToBack()
    End Sub

End Class
