Imports System.Data.OleDb
Imports System.Text.RegularExpressions

Public Class Update
    Public conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=BancoSeguro.mdb;")
    Public cmd As OleDbCommand
    Public dt As New DataTable
    Public adp As OleDbDataAdapter
    Public query As String

    Dim CanSubmit As Boolean = True

    Private Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click
        If IsNumeric(AccSearchBox.Text) Then
            conn.Open()
            query = "UPDATE Account SET Acc_Type = Acc_Type WHERE Acc_No = " & AccSearchBox.Text
            cmd = New OleDbCommand(query, conn)
            Dim Exists = If(cmd.ExecuteNonQuery() = 0, False, True)
            conn.Close()

            If Exists Then
                UpdateAccountPanel.Visible = True
                SearchAccPanel.Visible = False
                ReadOnlyTB(True)
                ErrorLabel.Visible = False
                IntializeAccountDetails()
            Else
                ErrorLabel.Visible = True
                ErrorLabel.Text = "Error : Account Not Found"
            End If
        End If
    End Sub

    Sub ReadOnlyTB(isReadOnly As Boolean)
        If isReadOnly Then
            NameTxt.Enabled = False
            DOBTxt.Enabled = False
            PhoneNoTxt.Enabled = False
            EmailIDTxt.Enabled = False
            AddressTxt.Enabled = False
            SavingsRB.Enabled = False
            CurrentRB.Enabled = False
            MaleRB.Enabled = False
            FemaleRB.Enabled = False
            ChooseBtn.Enabled = False
        Else
            NameTxt.Enabled = True
            DOBTxt.Enabled = True
            PhoneNoTxt.Enabled = True
            EmailIDTxt.Enabled = True
            AddressTxt.Enabled = True
            SavingsRB.Enabled = True
            CurrentRB.Enabled = True
            MaleRB.Enabled = True
            FemaleRB.Enabled = True
            ChooseBtn.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles UpdateBtn.Click
        ReadOnlyTB(False)
    End Sub

    Private Sub AccSearchBox_KeyDown(sender As Object, e As KeyEventArgs) Handles AccSearchBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            SearchBtn_Click(e, e)
        End If
    End Sub

    Private Sub NameTxt_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles NameTxt.Validating
        If sender.Text = "" Then
            Exit Sub
        End If

        Dim RE As New Regex("^([a-zA-Z\s]+)$")
        If RE.IsMatch(sender.Text) Then
            ErrorProviderX.SetError(sender, "")
            CanSubmit = True
        Else
            ErrorProviderX.SetError(sender, "Enter a Valid Name")
            CanSubmit = False
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
                CanSubmit = True
            Else
                ErrorProviderX.SetError(sender, "Applicants must be at least 18 years old to open a bank account.")
                CanSubmit = False
            End If
        Else
            ErrorProviderX.SetError(sender, "Error : Incorrect Date Format" & vbCrLf & "DOB Format : DD/MM/YYYY")
            CanSubmit = False
        End If
    End Sub

    Private Sub PhoneNoTxt_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles PhoneNoTxt.Validating
        If sender.Text = "" Then
            Exit Sub
        End If

        Dim RE As New Regex("^([6-9][0-9]{9})$")
        If RE.IsMatch(sender.Text) Then
            ErrorProviderX.SetError(sender, "")
            CanSubmit = True
        Else
            ErrorProviderX.SetError(sender, "Enter a Valid Phone Number")
            CanSubmit = False
        End If
    End Sub

    Private Sub EmailIDTxt_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles EmailIDTxt.Validating
        If sender.Text = "" Then
            Exit Sub
        End If

        Dim RE As New Regex("^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$")
        If RE.IsMatch(sender.Text) Then
            ErrorProviderX.SetError(sender, "")
            CanSubmit = True
        Else
            ErrorProviderX.SetError(sender, "Enter a Valid Email")
            CanSubmit = False
        End If
    End Sub

    Sub CheckIfEmpty()
        If NameTxt.Text = "" Or DOBTxt.Text = "" Or PhoneNoTxt.Text = "" Or EmailIDTxt.Text = "" Or AddressTxt.Text = "" Then
            CanSubmit = False
            ErrorProviderX.SetError(SubmitBtn, "Error : All Fields Are Required")
        ElseIf ProfilePic.Tag = "" Then
            CanSubmit = False
            ErrorProviderX.SetError(SubmitBtn, "Error : Choose a Profile Picture")
        End If
    End Sub

    Private Sub SubmitBtn_Click(sender As Object, e As EventArgs) Handles SubmitBtn.Click
        CheckIfEmpty()
        If CanSubmit Then
            Dim AccType = If(SavingsRB.Checked, "Savings", "Current")
            Dim Gender = If(MaleRB.Checked, "Male", "Female")
            Dim AccNo As Integer = Integer.Parse(AccNoTxt.Text)

            conn.Open()
            query = "SELECT Cust_ID FROM Account WHERE Acc_No = " & AccNoTxt.Text
            cmd = New OleDbCommand(query, conn)
            Dim CustID As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            conn.Close()

            conn.Open()
            query = "UPDATE Customer SET Cust_Name = @Name, Cust_Gender = @Gender, Cust_DOB = @DOB, Cust_Phone = @Phone, Cust_Email = @Email, Cust_Address = @Address, Cust_Profile =  @Profile WHERE Cust_ID = @C_ID"
            cmd = New OleDbCommand(query, conn)
            cmd.Parameters.AddWithValue("@Name", NameTxt.Text)
            cmd.Parameters.AddWithValue("@Gender", Gender)
            cmd.Parameters.AddWithValue("@DOB", DOBTxt.Text)
            cmd.Parameters.AddWithValue("@Phone", PhoneNoTxt.Text)
            cmd.Parameters.AddWithValue("@Email", EmailIDTxt.Text)
            cmd.Parameters.AddWithValue("@Address", AddressTxt.Text)
            cmd.Parameters.AddWithValue("@Profile", ProfilePic.Tag)
            cmd.Parameters.AddWithValue("@ID", CustID)
            cmd.ExecuteNonQuery()
            conn.Close()

            conn.Open()
            query = "UPDATE Account SET Acc_Type = @AccType WHERE Acc_No = @AccNo"
            cmd = New OleDbCommand(query, conn)
            cmd.Parameters.AddWithValue("@AccType", AccType)
            cmd.Parameters.AddWithValue("@AccNo", CInt(AccNoTxt.Text))
            cmd.ExecuteNonQuery()
            conn.Close()

            DisplayMsg.Message = ("Account Updated Succesfully")
            DisplayMsg.ShowDialog()
            AdminForm.BackBtn_Click(e, e)
        End If
    End Sub

    Sub IntializeAccountDetails()

        AccNoTxt.Text = AccSearchBox.Text
        conn.Open()
        query = "SELECT * FROM Customer WHERE Cust_ID = (SELECT Cust_ID FROM Account WHERE Acc_No = " & AccSearchBox.Text & ")"
        adp = New OleDbDataAdapter(query, conn)
        adp.Fill(dt)
        NameTxt.Text = dt.Rows(0)("Cust_Name").ToString()
        FemaleRB.Checked = If(dt.Rows(0)("Cust_Gender").ToString() = "Female", True, False)
        DOBTxt.Text = dt.Rows(0)("Cust_DOB").ToString()
        PhoneNoTxt.Text = dt.Rows(0)("Cust_Phone").ToString()
        EmailIDTxt.Text = dt.Rows(0)("Cust_Email").ToString()
        AddressTxt.Text = dt.Rows(0)("Cust_Address").ToString()
        ProfilePic.ImageLocation = dt.Rows(0)("Cust_Profile").ToString()
        ProfilePic.Tag = dt.Rows(0)("Cust_Profile").ToString()
        dt.Clear()
        conn.Close()

    End Sub

    Private Sub ChooseBtn_Click(sender As Object, e As EventArgs) Handles ChooseBtn.Click
        If MaleRB.Checked Then
            ProfilePicker.Tag = "Male"
        Else
            ProfilePicker.Tag = "Female"
        End If
        Dim DialogResult = ProfilePicker.ShowDialog()
        If Not DialogResult = Windows.Forms.DialogResult.Cancel Then
            ProfilePic.ImageLocation = AdminForm.ProfileImage
            ProfilePic.Tag = AdminForm.ProfileImage
        End If
    End Sub

    Private Async Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Clipboard.SetText(AccNoTxt.Text)
        sender.Image = My.Resources.copied_40px
        Await Task.Delay(400)
        sender.Image = My.Resources.copy_40px
    End Sub
End Class
