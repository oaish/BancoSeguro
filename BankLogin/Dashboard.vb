Imports System.Data.OleDb
Public Class Dashboard
    Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=BancoSeguro.mdb;")
    Dim cmd As OleDbCommand
    Dim dt As New DataTable
    Dim adp As OleDbDataAdapter
    Dim query As String
    Dim total As Object
    Dim Num As Integer

    Private Sub Dashboard_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible Then
            PanelSplitter.Left = DateTimeLbl.Left + DateTimeLbl.Width
            WelcomeLbl.Left = PanelSplitter.Left + PanelSplitter.Width
            Dim CurrDate As DateTime = DateTime.Now
            DateTimeLbl.Text = CurrDate.ToString("ddd, d""th"" MMM") & vbCrLf & CurrDate.ToString("h:mm tt")
            WelcomeLbl.Text = "Welcome," & vbCrLf & AdminForm.AdminUser
            conn.Open()

            'Total Clients
            query = "SELECT COUNT(*) FROM Customer"
            cmd = New OleDbCommand(query, conn)
            Dim count = cmd.ExecuteScalar()
            ClientLbl.Text = If(Not IsDBNull(count), count, 0)

            'Total Deposits
            query = "SELECT SUM(Acc_Bal) FROM Account"
            cmd = New OleDbCommand(query, conn)
            total = cmd.ExecuteScalar()
            Num = If(Not IsDBNull(total), CInt(total), 0)
            DepositLbl.Text = CNumToStr(Num)

            'Total Staff
            query = "SELECT COUNT(*) FROM Employee"
            cmd = New OleDbCommand(query, conn)
            count = cmd.ExecuteScalar()
            Num = If(Not IsDBNull(total), CInt(total), 0)
            EmpLbl.Text = If(Not IsDBNull(count), count, 0)

            'Savings Acc Amount
            query = "SELECT SUM(Acc_Bal) FROM Account WHERE Acc_Type = 'Savings'"
            cmd = New OleDbCommand(query, conn)
            total = cmd.ExecuteScalar()
            Num = If(Not IsDBNull(total), CInt(total), 0)
            SALbl.Text = CNumToStr(Num)

            'Current Acc Amount
            query = "SELECT SUM(Acc_Bal) FROM Account WHERE Acc_Type = 'Current'"
            cmd = New OleDbCommand(query, conn)
            total = cmd.ExecuteScalar()
            Num = If(Not IsDBNull(total), CInt(total), 0)
            CALbl.Text = CNumToStr(Num)

            conn.Close()
        End If
    End Sub

    Function CNumToStr(ByVal num As Double) As String
        If num >= 1000000000 Then
            Return "$" & (num / 1000000000).ToString("#,##0.#") & "B"
        ElseIf num >= 1000000 Then
            Return "$" & (num / 1000000).ToString("#,##0.#") & "M"
        ElseIf num >= 1000 Then
            Return "$" & (num / 1000).ToString("#,##0") & "K"
        Else
            Return "$" & num.ToString("#,##0")
        End If
    End Function

End Class
