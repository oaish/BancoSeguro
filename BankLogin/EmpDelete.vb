Imports System.Data.OleDb

Public Class EmpDelete
    Dim CanDelete As Boolean = True
    Private Sub ENextBtn_Click(sender As Object, e As EventArgs) Handles ENextBtn.Click
        If UsernameTxt.Text.Equals("Admin") And PasswordTxt.Text.Equals("1234") Then
            ErrorProviderX.SetError(ENextBtn, "Error: Admin User cannot be deleted")
            CanDelete = False
            Exit Sub
        Else
            If Not CanDelete Then
                ErrorProviderX.SetError(ENextBtn, "")
            End If
        End If
        Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=BancoSeguro.mdb;")
        Dim query = "DELETE FROM Employee WHERE Emp_ID = (SELECT Emp_ID FROM Login WHERE Username = @User)"
        Dim cmd As New OleDbCommand(query, conn)
        cmd.Parameters.AddWithValue("@User", UsernameTxt.Text)
        conn.Open()
        Dim count = cmd.ExecuteNonQuery()
        conn.Close()

        If count = 1 Then
            DisplayMsg.Message = ("Employee Deleted Succesfully")
            DisplayMsg.ShowDialog()
        Else
            DisplayMsg.Message = ("Employee Does Not Exist")
            DisplayMsg.ShowDialog()
            Exit Sub
        End If
        AdminForm.BackBtn_Click(e, e)
    End Sub
End Class
