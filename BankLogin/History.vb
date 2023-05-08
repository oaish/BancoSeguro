Imports System.Windows.Forms

Public Class History
    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        TransactionTab.dt.Clear()
        Me.Close()
    End Sub

    Private Sub History_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TransactionTab.conn.Open()
        TransactionTab.query = "SELECT * FROM Transactions WHERE Acc_No = " & TransactionTab.AccNo & " ORDER BY T_ID"
        TransactionTab.adp = New OleDb.OleDbDataAdapter(TransactionTab.query, TransactionTab.conn)
        TransactionTab.adp.Fill(TransactionTab.dt)
        HistoryGrid.DataSource = TransactionTab.dt
        HistoryGrid.DataMember = TransactionTab.dt.TableName
        TransactionTab.conn.Close()
    End Sub
End Class
