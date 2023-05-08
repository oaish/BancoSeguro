Imports System.Data.OleDb
Public Class Manage
    Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=BancoSeguro.mdb;")
    Dim query As String
    Dim cmd As OleDbCommand
    Dim adp As OleDbDataAdapter
    Dim dt As New DataTable()
    Dim CanReset As Boolean

    Private Sub Manage_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            conn.Open()
            query = "SELECT Username, Emp_Profile FROM Employee E INNER JOIN Login L ON E.Emp_ID = L.Emp_ID WHERE Username = '" & AdminForm.AdminUser & "'"
            adp = New OleDbDataAdapter(query, conn)
            adp.Fill(dt)
            ProfilePic.ImageLocation = dt.Rows(0)("Emp_Profile").ToString
            UserLbl.Text = dt.Rows(0)("Username").ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub OldTxt_Enter(sender As Object, e As EventArgs) Handles OldTxt.Enter, OldTxt.Click
        If OldTxt.Text = "Old Password" Then
            OldTxt.ForeColor = Color.Black
            OldTxt.Text = ""
        End If
    End Sub

    Private Sub OldTxt_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OldTxt.Validating
        If OldTxt.Text = "" Then
            OldTxt.Text = "Old Password"
            OldTxt.ForeColor = Color.Gray
        ElseIf OldTxt.Text <> AdminForm.AdminPass Then
            ErrorProviderX.SetError(sender, "Error: Incorrect Password " & AdminForm.AdminPass)
            CanReset = False
        End If
    End Sub


    Private Sub Password_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles NewTxt.Validating
        If sender.Text.length < 4 Then
            ErrorProviderX.SetError(sender, "Error: Password length should be at least 4 Characters")
            CanReset = False
        Else
            ErrorProviderX.SetError(sender, "")
            CanReset = True
        End If
    End Sub


    Private Sub ConfirmPassword_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ConfirmTxt.Validating
        If sender.Text <> NewTxt.Text Then
            ErrorProviderX.SetError(sender, "Error: Passwords do not match")
            CanReset = False
        Else
            ErrorProviderX.SetError(sender, "")
            CanReset = True
        End If
    End Sub

    Private Sub NewTxt_Enter(sender As Object, e As EventArgs) Handles NewTxt.Enter, NewTxt.Click
        If NewTxt.Text = "New Password" Then
            NewTxt.ForeColor = Color.Black
            NewTxt.Text = ""
        End If
    End Sub

    Private Sub NewTxt_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles NewTxt.Validating
        If NewTxt.Text = "" Then
            NewTxt.Text = "New Password"
            NewTxt.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub ConfirmTxt_Enter(sender As Object, e As EventArgs) Handles ConfirmTxt.Enter, ConfirmTxt.Click
        If ConfirmTxt.Text = "Confirm Password" Then
            ConfirmTxt.ForeColor = Color.Black
            ConfirmTxt.Text = ""
        End If
    End Sub

    Private Sub ConfirmTxt_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ConfirmTxt.Validating
        If ConfirmTxt.Text = "" Then
            ConfirmTxt.Text = "Confirm Password"
            ConfirmTxt.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub PswrdResetBtn_Click(sender As Object, e As EventArgs) Handles PswrdResetBtn.Click
        PasswordRstPanel.Visible = True
    End Sub

    Private Sub ResetBtn_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click
        If AdminForm.AdminUser = "Admin" And AdminForm.AdminPass = "1234" Then
            ErrorProviderX.SetError(sender, "Error: Cannot Reset Admin Password")
            CanReset = False
        End If
        If OldTxt.Text = "Old Password" Or NewTxt.Text = "New Password" Or ConfirmTxt.Text = "Confirm Password" Then
            ErrorProviderX.SetError(sender, "Error: All Fields Are Required")
            CanReset = False
        End If
        If CanReset Then
            ErrorProviderX.SetError(sender, "")
            query = "UPDATE [Login] SET [Password] = '" & NewTxt.Text & "' WHERE [Username] = '" & AdminForm.AdminUser & "'"
            cmd = New OleDbCommand(query, conn)
            Try
                conn.Open()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try
            AdminForm.AdminPass = NewTxt.Text
            DisplayMsg.Message = "Password Reset Successful"
            DisplayMsg.ShowDialog()
            PasswordRstPanel.Visible = False
            ClearTxt()
        End If
    End Sub

    Sub ClearTxt()
        OldTxt.Text = "Old Password"
        NewTxt.Text = "New Password"
        ConfirmTxt.Text = "Confirm Password"
        OldTxt.ForeColor = Color.Gray
        NewTxt.ForeColor = Color.Gray
        ConfirmTxt.ForeColor = Color.Gray
    End Sub
End Class
