Imports System.Data.OleDb
Imports System.Text.RegularExpressions

Public Class Create
    Public conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=BancoSeguro.mdb;")
    Public cmd As OleDbCommand
    Public dt As New DataTable
    Public adp As OleDbDataAdapter
    Public query As String

    Dim NewCustomer As Boolean = True
    Dim CanSubmit As Boolean = True
    Dim AccNoRNG As New Random()

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ChooseBtn.Click
        If MaleRB.Checked Then
            ProfilePicker.Tag = "Male"
        Else
            ProfilePicker.Tag = "Female"
        End If
        Dim DialogResult = ProfilePicker.ShowDialog()
        If Not DialogResult = Windows.Forms.DialogResult.Cancel Then
            ProfilePic.ImageLocation = AdminForm.ProfileImage
            ProfilePic.Tag = "Selected"
            CanSubmit = True
        End If
    End Sub

    Private Sub CreateBtn_Click(sender As Object, e As EventArgs) Handles NewCreateBtn.Click
        CreateAccountPanel.Visible = True
        AccPrompt.Visible = False
        NewCustomer = True
        ReadOnlyTB(False)
        IntializeAccountDetails()
    End Sub

    Sub IntializeAccountDetails()
        Dim AccNo = AccNoRNG.Next(10000000, 99999999)
        Dim Match As Boolean

        conn.Open()
        query = "Select Acc_no From Account"
        adp = New OleDbDataAdapter(query, conn)
        adp.Fill(dt)
        If dt.Rows.Count <> 0 Then
            While True
                Match = False
                For Each AccNum In dt.Rows
                    If AccNum.Equals(AccNo) Then
                        AccNoRNG.Next(10000000, 99999999)
                        Match = True
                    End If
                Next
                If Not Match Then
                    Exit While
                End If
            End While
        End If
        dt.Clear()
        conn.Close()

        AccNoTxt.Text = AccNo
        If NewCustomer Then
            Exit Sub
        End If

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
        ProfilePic.Tag = "Selected"
        dt.Clear()
        conn.Close()

    End Sub

    Private Sub OldCreateBtn_Click(sender As Object, e As EventArgs) Handles OldCreateBtn.Click
        OldCreateBtn.Visible = False
        SearchAccPanel.Visible = True
    End Sub

    Private Sub Search_Record(sender As Object, e As EventArgs) Handles SearchBtn.Click
        If IsNumeric(AccSearchBox.Text) Then
            conn.Open()
            query = "UPDATE Account SET Acc_no  = " & AccSearchBox.Text & " WHERE Acc_No = " & AccSearchBox.Text
            cmd = New OleDbCommand(query, conn)
            Dim Exists = If(cmd.ExecuteNonQuery() = 0, False, True)
            conn.Close()

            If Exists Then
                CreateAccountPanel.Visible = True
                AccPrompt.Visible = False
                NewCustomer = False
                ReadOnlyTB(True)
                IntializeAccountDetails()
            Else
                DisplayMsg.Message = "Account Not Found"
                DisplayMsg.ShowDialog()
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
            MaleRB.Enabled = False
            FemaleRB.Enabled = False
            ChooseBtn.Enabled = False

        Else
            NameTxt.Enabled = True
            DOBTxt.Enabled = True
            PhoneNoTxt.Enabled = True
            EmailIDTxt.Enabled = True
            AddressTxt.Enabled = True
            MaleRB.Enabled = True
            FemaleRB.Enabled = True
            ChooseBtn.Enabled = True

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

    Private Sub InitBalTxt_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles InitBalTxt.Validating
        If sender.Text = "" Then
            Exit Sub
        End If

        If SavingsRB.Checked Then
            If Integer.Parse(sender.text) < 3000 Then
                ErrorProviderX.SetError(sender, "Minimum Balance for Savings Account Type is $3000")
                CanSubmit = False
            Else
                ErrorProviderX.SetError(sender, "")
            End If
        ElseIf CurrentRB.Checked Then
            If Integer.Parse(sender.text) < 10000 Then
                ErrorProviderX.SetError(sender, "Minimum Balance for Current Account Type is $10000")
                CanSubmit = False
            Else
                ErrorProviderX.SetError(sender, "")
                CanSubmit = True
            End If
        End If
    End Sub

    Sub CheckIfEmpty()
        If NameTxt.Text = "" Or DOBTxt.Text = "" Or PhoneNoTxt.Text = "" Or EmailIDTxt.Text = "" Or AddressTxt.Text = "" Or InitBalTxt.Text = "" Then
            CanSubmit = False
            ErrorProviderX.SetError(SubmitBtn, "Error : All Fields Are Required")
        ElseIf ProfilePic.Tag = "" Then
            CanSubmit = False
            ErrorProviderX.SetError(SubmitBtn, "Error : Choose a Profile Picture")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles SubmitBtn.Click
        CheckIfEmpty()
        If CanSubmit Then
            
            Dim AccType = If(SavingsRB.Checked, "Savings", "Current")
            Dim Gender = If(MaleRB.Checked, "Male", "Female")
            Dim AccNo As Integer = Integer.Parse(AccNoTxt.Text)
            Dim AccBal As Integer = Integer.Parse(InitBalTxt.Text)
            Dim maxCustID As Integer

            If NewCustomer Then
                conn.Open()
                query = "SELECT MAX(Cust_ID) FROM Customer"
                cmd = New OleDbCommand(query, conn)
                Dim obj As Object = cmd.ExecuteScalar()
                maxCustID = If(IsDBNull(obj), 1, CInt(obj) + 1)

                query = "INSERT INTO Customer (Cust_ID, Cust_Name, Cust_Gender, Cust_DOB, Cust_Phone, Cust_Email, Cust_Address, Cust_Profile) VALUES (@ID, @Name, @Gender, @DOB, @Phone, @Email, @Address, @Profile)"
                cmd = New OleDbCommand(query, conn)
                cmd.Parameters.AddWithValue("@ID", maxCustID)
                cmd.Parameters.AddWithValue("@Name", NameTxt.Text)
                cmd.Parameters.AddWithValue("@Gender", Gender)
                cmd.Parameters.AddWithValue("@DOB", DOBTxt.Text)
                cmd.Parameters.AddWithValue("@Phone", PhoneNoTxt.Text)
                cmd.Parameters.AddWithValue("@Email", EmailIDTxt.Text)
                cmd.Parameters.AddWithValue("@Address", AddressTxt.Text)
                cmd.Parameters.AddWithValue("@Profile", AdminForm.ProfileImage)
                cmd.ExecuteNonQuery()
                conn.Close()
            Else
                conn.Open()
                query = "SELECT Cust_ID FROM Customer WHERE Cust_ID = (SELECT Cust_ID FROM Account WHERE Acc_No = " & AccSearchBox.Text & ")"
                cmd = New OleDbCommand(query, conn)
                Dim obj As Object = cmd.ExecuteScalar()
                maxCustID = CType(obj, Integer)
                conn.Close()
            End If

            conn.Open()

            query = "INSERT INTO Account VALUES (" & AccNo & ", '" & AccType & "', " & AccBal & ", " & maxCustID & ")"
            cmd = New OleDbCommand(query, conn)
            cmd.ExecuteNonQuery()

            DisplayMsg.Message = "Account Created Successfully"
            DisplayMsg.ShowDialog()
            AdminForm.BackBtn_Click(e, e)

            conn.Close()
        End If
    End Sub

    Private Sub AccSearchBox_KeyDown(sender As Object, e As KeyEventArgs) Handles AccSearchBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Search_Record(e, e)
        End If
    End Sub

    Private Async Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Clipboard.SetText(AccNoTxt.Text)
        sender.Image = My.Resources.copied_40px
        Await Task.Delay(400)
        sender.Image = My.Resources.copy_40px
    End Sub

End Class
