Imports System.Data.OleDb
Imports System.Text.RegularExpressions
Public Class EmpCreate
    Dim CanProceed As Boolean
    Dim conn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim adp As OleDbDataAdapter
    Dim dt As DataTable
    Dim query As String

    Private Sub PassIco_Click(sender As Object, e As EventArgs) Handles PassIco.Click
        If PasswordTxt.UseSystemPasswordChar Then
            PassIco.Image = My.Resources.passHide
            PasswordTxt.UseSystemPasswordChar = False
            Confirm.UseSystemPasswordChar = False
            ShowPWLbl.Text = "Hide Password"
        Else
            PassIco.Image = My.Resources.passShow
            PasswordTxt.UseSystemPasswordChar = True
            Confirm.UseSystemPasswordChar = True
            ShowPWLbl.Text = "Show Password"
        End If
        PasswordTxt.SelectionStart = PasswordTxt.Text.Length
    End Sub

    Private Sub Username_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles UsernameTxt.Validating
        Dim Regexp As New System.Text.RegularExpressions.Regex("^(\w+)$")
        If Regexp.IsMatch(sender.Text) Then
            conn = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=BancoSeguro.mdb;")
            conn.Open()
            query = "SELECT Username FROM Login WHERE Username = '" & UsernameTxt.Text & "'"
            adp = New OleDbDataAdapter(query, conn)
            dt = New DataTable
            adp.Fill(dt)
            Dim Valid = If(dt.Rows.Count = 0, True, False)
            conn.Close()
            If Valid Then
                ErrorProviderX.SetError(sender, "")
                CanProceed = True
            Else
                ErrorProviderX.SetError(sender, "Error: Username Already Taken")
                CanProceed = False
            End If
        Else
            ErrorProviderX.SetError(sender, "Error: Invalid Username")
            CanProceed = False
        End If
    End Sub

    Private Sub Password_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles PasswordTxt.Validating
        If sender.Text.length < 4 Then
            ErrorProviderX.SetError(sender, "Error: Password length should be at least 4 Characters")
            CanProceed = False
        Else
            ErrorProviderX.SetError(sender, "")
            CanProceed = True
        End If
    End Sub

    Private Sub ConfirmPassword_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Confirm.Validating
        If sender.Text <> PasswordTxt.Text Then
            ErrorProviderX.SetError(sender, "Error: Passwords do not match")
            CanProceed = False
        Else
            ErrorProviderX.SetError(sender, "")
            CanProceed = True
        End If
    End Sub

    Private Sub ENextBtn_Click(sender As Object, e As EventArgs) Handles ENextBtn.Click
        If UsernameTxt.Text = "" Or PasswordTxt.Text = "" Or Confirm.Text = "" Or RoleBox.SelectedIndex = -1 Then
            If RoleBox.SelectedIndex = -1 Then
                ErrorProviderX.SetError(sender, "Error: Select a Role")
            Else
                ErrorProviderX.SetError(sender, "Error: All Fields Are Required")
            End If
            Exit Sub
        End If
        If CanProceed Then
            ErrorProviderX.SetError(sender, "")
            EmpDetailPanel.Visible = True
        End If
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
        ElseIf ProfilePic.ImageLocation <> "" Then
            CanProceed = True
            ErrorProviderX.SetError(SubmitBtn, "")
        End If
    End Sub

    Private Sub ChooseBtn_Click(sender As Object, e As EventArgs) Handles ChooseBtn.Click
        ProfileGB.Visible = True
        ProfileGB.BringToFront()
    End Sub

    Private Sub EmpDetailPanel_Enter(sender As Object, e As EventArgs) Handles EmpDetailPanel.Enter
        ProfileGB.Visible = False
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

    Private Sub SubmitBtn_Click(sender As Object, e As EventArgs) Handles SubmitBtn.Click
        CheckIfEmpty()
        If CanProceed Then
            conn.Open()
            query = "SELECT MAX(Emp_ID) FROM Employee"
            cmd = New OleDbCommand(query, conn)
            Dim obj As Object = cmd.ExecuteScalar()
            Dim maxEmpID = If(IsDBNull(obj), 1, CInt(obj) + 1)

            'PasswordTxt.UseSystemPasswordChar = False
            Dim user As String = UsernameTxt.Text
            Dim pass As String = PasswordTxt.Text

            query = "INSERT INTO Employee (Emp_ID, Emp_Name, Emp_DOB, Emp_Phone, Emp_Email, Emp_Address, Emp_Position, Emp_Profile) VALUES (@ID, @Name, @DOB, @Phone, @Email, @Address, @Role, @Profile)"
            cmd = New OleDbCommand(query, conn)
            cmd.Parameters.AddWithValue("@ID", maxEmpID)
            cmd.Parameters.AddWithValue("@Name", NameTxt.Text)
            cmd.Parameters.AddWithValue("@DOB", DOBTxt.Text)
            cmd.Parameters.AddWithValue("@Phone", PhoneNoTxt.Text)
            cmd.Parameters.AddWithValue("@Email", EmailIDTxt.Text)
            cmd.Parameters.AddWithValue("@Address", AddressTxt.Text)
            cmd.Parameters.AddWithValue("@Role", RoleBox.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@Profile", ProfilePic.ImageLocation)
            cmd.ExecuteNonQuery()
            conn.Close()

            conn.Open()
            query = "INSERT INTO Login VALUES (@ID, @User, @Pass)"
            cmd = New OleDbCommand(query, conn)
            cmd.Parameters.AddWithValue("@ID", maxEmpID)
            cmd.Parameters.AddWithValue("@User", user)
            cmd.Parameters.AddWithValue("@Pass", pass)
            cmd.ExecuteNonQuery()
            conn.Close()

            DisplayMsg.Message = "Employee Account Created"
            DisplayMsg.ShowDialog()
            AdminForm.BackBtn_Click(e, e)
        End If
    End Sub

End Class
