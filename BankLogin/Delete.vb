Imports System.Data.OleDb
Public Class Delete
    Public conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=BancoSeguro.mdb;")
    Public cmd As OleDbCommand
    Public dt As New DataTable
    Public adp As OleDbDataAdapter
    Public query As String

    Dim CanSubmit As Boolean = True

    Private Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click
        If IsNumeric(AccSearchBox.Text) Then
            conn.Open()
            query = "SELECT COUNT(Acc_no) FROM Account WHERE Acc_No = " & AccSearchBox.Text
            cmd = New OleDbCommand(query, conn)
            Dim Int As Integer = cmd.ExecuteScalar()
            Dim Exists = If(Int = 0, False, True)
            conn.Close()

            If Exists Then
                conn.Open()
                query = "SELECT Acc_No FROM Account WHERE Cust_ID = (SELECT Cust_ID FROM Account WHERE Acc_No = " & AccSearchBox.Text & ")"
                adp = New OleDbDataAdapter(query, conn)
                adp.Fill(dt)
                If dt.Rows.Count = 1 Then
                    query = "DELETE FROM Customer WHERE Cust_ID = (SELECT Cust_ID FROM Account WHERE Acc_No = " & AccSearchBox.Text & ")"
                    cmd = New OleDbCommand(query, conn)
                    cmd.ExecuteNonQuery()
                Else
                    query = "DELETE FROM Account WHERE Acc_No = " & AccSearchBox.Text
                    cmd = New OleDbCommand(query, conn)
                    cmd.ExecuteNonQuery()
                End If
                conn.Close()
                DisplayMsg.Message = "Account Deleted Successfully"
                DisplayMsg.ShowDialog()
                AdminForm.BackBtn_Click(e, e)
            Else
                ErrorLabel.Visible = True
                ErrorLabel.Text = "Error : Account Not Found"
            End If
        End If
    End Sub

End Class
