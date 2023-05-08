Imports System.Data.OleDb
Public Class TransactionTab
    Public Shared conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=BancoSeguro.mdb;")
    Public Shared cmd As OleDbCommand
    Public Shared dt As New DataTable
    Public Shared adp As OleDbDataAdapter
    Public Shared query As String

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles SearchBar.KeyDown
        If e.KeyCode = Keys.Enter And IsNumeric(SearchBar.Text) Then
            SearchRecord(sender, e)
        End If
    End Sub

    Private Sub View_Balance(sender As Object, e As EventArgs) Handles BalanceBtn.Click
        If BalanceBtn.Tag = "" Then
            BalanceBtn.Text = "$" & AccBal
            BalanceBtn.Tag = "X"
        Else
            BalanceBtn.Text = "View Balance"
            BalanceBtn.Tag = ""
        End If
    End Sub


    Public Sub SearchRecord(sender As Object, e As EventArgs) Handles SearchBtn.Click
        If SearchBar.Text <> "" Then
            query = "SELECT * FROM Customer INNER JOIN Account ON Customer.Cust_ID = Account.Cust_ID WHERE Acc_No = " & SearchBar.Text
            adp = New OleDbDataAdapter(query, conn)
            conn.Open()
            adp.Fill(dt)
            If dt.Rows.Count <> 0 Then
                GetData()
                ShowDetails()
            Else
                HideDetails()
                DisplayMsg.Message = "Account Not Found"
                DisplayMsg.ShowDialog()
            End If
            dt.Clear()
            conn.Close()
        End If
    End Sub

    Public Shared AccName, AccNo, AccBal, AccType, DOB, Phone, Email, Profile As String
    Public Shared Sub GetData()
        AccName = dt.Rows(0)("Cust_Name").ToString()
        AccNo = dt.Rows(0)("Acc_No").ToString()
        AccBal = dt.Rows(0)("Acc_Bal").ToString()
        AccType = dt.Rows(0)("Acc_Type").ToString()
        DOB = dt.Rows(0)("Cust_Dob").ToString()
        Phone = dt.Rows(0)("Cust_Phone").ToString()
        Email = dt.Rows(0)("Cust_Email").ToString()
        Profile = dt.Rows(0)("Cust_Profile").ToString()
    End Sub


    Sub ShowDetails()
        DetailsPanel.Visible = True
        DepositBtn.Visible = True
        WithdrawBtn.Visible = True
        TransferBtn.Visible = True
        HistoryBtn.Visible = True

        NameLbl.Text = "Name : " & AccName
        AccLbl.Text = "Acc No : " & AccNo
        AccTypeLbl.Text = "Acc Type : " & AccType
        DOBLbl.Text = "DOB : " & DOB
        MobLbl.Text = "Phone : " & Phone
        EmailLbl.Text = "Email : " & Email
        ProfilePic.ImageLocation = Profile
    End Sub


    Sub HideDetails()
        DetailsPanel.Hide()
        DepositBtn.Hide()
        WithdrawBtn.Hide()
        TransferBtn.Hide()
        HistoryBtn.Hide()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles SearchBar.Click, SearchBar.Enter
        If SearchBar.Text = "Search Account No" Then
            SearchBar.Text = ""
            SearchBar.ForeColor = Color.Black
        End If
    End Sub

    Private Sub DepositBtn_Click(sender As Object, e As EventArgs) Handles DepositBtn.Click
        BalanceBtn.Tag = "X"
        View_Balance(e, e)
        Deposit.ShowDialog()
    End Sub

    Private Sub WithdrawBtn_Click(sender As Object, e As EventArgs) Handles WithdrawBtn.Click
        BalanceBtn.Tag = "X"
        View_Balance(e, e)
        Withdraw.ShowDialog()
    End Sub

    Public Shared Sub TransactionQuery(AccNo As String, Type As String, Amount As String)
        conn.Open()
        query = "SELECT MAX(T_ID) FROM Transactions"
        cmd = New OleDbCommand(query, conn)
        Dim maxID As Object = cmd.ExecuteScalar()
        If IsDBNull(maxID) Then
            maxID = 1
        Else
            maxID = CType(maxID, Integer) + 1
        End If
        query = "INSERT INTO Transactions VALUES(@T_ID, @Acc_No, @Emp_ID, @T_Date, @T_Type, @T_Amount)"
        cmd = New OleDbCommand(query, conn)
        cmd.Parameters.AddWithValue("@T_ID", maxID)
        cmd.Parameters.AddWithValue("@Acc_No", CInt(AccNo))
        cmd.Parameters.AddWithValue("@Emp_ID", AdminForm.AdminID)
        cmd.Parameters.AddWithValue("@T_Date", DateTime.Now.ToString())
        cmd.Parameters.AddWithValue("@T_Type", Type)
        cmd.Parameters.AddWithValue("@T_Amount", CInt(Amount))
        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub

    Private Sub HistoryBtn_Click(sender As Object, e As EventArgs) Handles HistoryBtn.Click
        History.ShowDialog()
    End Sub

    Private Sub TransferBtn_Click(sender As Object, e As EventArgs) Handles TransferBtn.Click
        BalanceBtn.Tag = "X"
        View_Balance(e, e)
        Transfer.ShowDialog()
        SearchRecord(e, e)
    End Sub

End Class
