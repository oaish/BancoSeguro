﻿Imports System.Windows.Forms

Public Class Withdraw

    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles AmountTxt.Click, AmountTxt.Enter
        If AmountTxt.Text = "Enter Amount" Then
            AmountTxt.Text = ""
            AmountTxt.ForeColor = Color.Black
        End If
    End Sub

    Private Sub ProceedBtn_Click(sender As Object, e As EventArgs) Handles ProceedBtn.Click
        If IsNumeric(AmountTxt.Text) Then
            TransactionTab.AccBal = TransactionTab.AccBal - Integer.Parse(AmountTxt.Text)
            TransactionTab.conn.Open()
            TransactionTab.query = "UPDATE Account SET Acc_Bal = " & TransactionTab.AccBal & " WHERE Acc_No = " & TransactionTab.AccNo
            TransactionTab.cmd = New OleDb.OleDbCommand(TransactionTab.query, TransactionTab.conn)
            TransactionTab.cmd.ExecuteNonQuery()
            TransactionTab.conn.Close()
            DisplayMsg.Message = "Withdraw Successful"
            DisplayMsg.ShowDialog()
            TransactionTab.TransactionQuery(TransactionTab.AccNo, "Withdraw", AmountTxt.Text)
            Me.Close()
        End If
    End Sub

    Private Sub AmountTxt_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles AmountTxt.Validating
        If Not IsNumeric(AmountTxt.Text) And AmountTxt.Text <> "" Then
            WithdrawError.SetError(AmountTxt, "Error: Enter A Valid Number")
            e.Cancel = True
        ElseIf Integer.Parse(AmountTxt.Text) > TransactionTab.AccBal Then
            WithdrawError.SetError(AmountTxt, "Error: Entered Amount Exceeds Current Balance")
            e.Cancel = True
        Else
            WithdrawError.SetError(AmountTxt, "")
        End If
    End Sub

    Private Sub Withdraw_Load(sender As Object, e As EventArgs) Handles Me.Load
        NameLbl.Text = "Name : " & TransactionTab.AccName
        AccLbl.Text = "Acc No : " & TransactionTab.AccNo
        BalanceLbl.Text = "Balance : $" & TransactionTab.AccBal
        AmountTxt.Text = "Enter Amount"
    End Sub
End Class
