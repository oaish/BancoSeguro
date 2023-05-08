Imports System.Data.OleDb
Public Class ViewAccount
    Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=BancoSeguro.mdb;")
    Dim query As String
    Dim cmd As OleDbCommand
    Dim adp As OleDbDataAdapter
    Dim dt As DataTable
    Dim Count As Object
    Public Val As String

    Private Sub ViewAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Val = "Cust" Then
            ViewAccLbl.Text = "Customer Accounts : "
            conn.Open()
            query = "SELECT * FROM Account"
            adp = New OleDbDataAdapter(query, conn)
            dt = New DataTable()
            adp.Fill(dt)
            DataGridView1.DataSource = dt
            conn.Close()
            InitializeCust()
        ElseIf Val = "Emp" Then
            ViewAccLbl.Text = "Employee Details : "
            conn.Open()
            query = "SELECT E.Emp_ID, E.Emp_Name, L.Username, L.Password, E.Emp_Position FROM Employee E INNER JOIN Login L ON E.Emp_ID = L.Emp_ID"
            adp = New OleDbDataAdapter(query, conn)
            dt = New DataTable()
            adp.Fill(dt)
            DataGridView1.DataSource = dt
            conn.Close()
            InitializeEmp()
        End If
    End Sub

    Sub InitializeCust()
        GB1.Text = "Total Accounts"
        GB2.Text = "Total Savings"
        GB3.Text = "Total Current"
        GB4.Text = "Total Balance"

        conn.Open()
        query = "SELECT COUNT(*) FROM Account"
        cmd = New OleDbCommand(query, conn)
        Count = cmd.ExecuteScalar()
        Count &= If(Count = 1, " Account", " Accounts")
        Lbl1.Text = CType(Count, String)

        query = "SELECT COUNT(*) FROM Account WHERE Acc_Type = 'Savings'"
        cmd = New OleDbCommand(query, conn)
        Count = cmd.ExecuteScalar()
        Count &= If(Count = 1, " Account", " Accounts")
        Lbl2.Text = CType(Count, String)

        query = "SELECT COUNT(*) FROM Account WHERE Acc_Type = 'Current'"
        cmd = New OleDbCommand(query, conn)
        Count = cmd.ExecuteScalar()
        Count &= If(Count = 1, " Account", " Accounts")
        Lbl3.Text = CType(Count, String)

        query = "SELECT SUM(Acc_Bal) FROM Account"
        cmd = New OleDbCommand(query, conn)
        Count = cmd.ExecuteScalar()
        Lbl4.Text = "$" & CType(Count, String)
        conn.Close()
    End Sub

    Sub InitializeEmp()
        GB1.Text = "Total Users"
        GB2.Text = "Total Admins"
        GB3.Text = "Total Tellers"
        GB4.Text = "Total Loan Officers"

        conn.Open()
        query = "SELECT COUNT(*) FROM Login"
        cmd = New OleDbCommand(query, conn)
        Count = cmd.ExecuteScalar()
        Count &= If(Count = 1, " User", " Users")
        Lbl1.Text = CType(Count, String)

        query = "SELECT COUNT(*) FROM Employee WHERE Emp_Position = 'Admin'"
        cmd = New OleDbCommand(query, conn)
        Count = cmd.ExecuteScalar()
        Count &= If(Count = 1, " Admin", " Admins")
        Lbl2.Text = CType(Count, String)

        query = "SELECT COUNT(*) FROM Employee WHERE Emp_Position = 'Bank Teller'"
        cmd = New OleDbCommand(query, conn)
        Count = cmd.ExecuteScalar()
        Count &= If(Count = 1, " Teller", " Tellers")
        Lbl3.Text = CType(Count, String)

        query = "SELECT COUNT(*) FROM Employee WHERE Emp_Position = 'Loan Officer'"
        cmd = New OleDbCommand(query, conn)
        Count = cmd.ExecuteScalar()
        Count &= If(Count = 1, " Officer", " Officers")
        Lbl4.Text = CType(Count, String)
        conn.Close()
    End Sub

End Class
