Public Class Transfer
    Dim CurrAcc As String
    Dim CurrBal As String
    Dim CanProceed As Boolean = False

    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Me.Close()
    End Sub

    Private Sub ToAccTxt_Enter(sender As Object, e As EventArgs) Handles ToAccTxt.Enter
        If ToAccTxt.Text = "Enter Acc No To Transfer" Then
            ToAccTxt.Text = ""
            ToAccTxt.ForeColor = Color.Black
        End If
    End Sub

    Private Sub AmountTxt_Enter(sender As Object, e As EventArgs) Handles AmountTxt.Enter
        If AmountTxt.Text = "Enter Amount To Transfer" Then
            AmountTxt.Text = ""
            AmountTxt.ForeColor = Color.Black
        End If
    End Sub

    Private Sub ToAccTxt_Validating(sender As Object, e As EventArgs) Handles ToAccTxt.Validating
        If ToAccTxt.Text <> "" Then
            AccCheck.Visible = True
            If IsNumeric(ToAccTxt.Text) Then
                AccCheck.Image = My.Resources.Load
            End If
        End If
    End Sub

    Private Async Sub ToAccTxt_Validated(sender As Object, e As EventArgs) Handles ToAccTxt.Validated
        If CurrAcc <> ToAccTxt.Text Then
            If Not IsNumeric(ToAccTxt.Text) Then
                Await Task.Delay(1000)
                SetError(My.Resources.NotVerified, "Error", ToolTipIcon.Error, "Invalid Number")
                Exit Sub
            End If
            TransactionTab.conn.Open()
            TransactionTab.query = "SELECT * FROM Account A INNER JOIN Customer C ON A.Cust_ID = C.Cust_ID WHERE Acc_No = " & ToAccTxt.Text
            TransactionTab.adp = New OleDb.OleDbDataAdapter(TransactionTab.query, TransactionTab.conn)
            TransactionTab.adp.Fill(TransactionTab.dt)
            If TransactionTab.dt.Rows.Count > 0 Then
                Await Task.Delay(1000)
                TransactionTab.GetData()
                ToAccLbl.Text = "Acc No : " & TransactionTab.AccNo
                ToNameLbl.Text = "Name : " & TransactionTab.AccName
                ToBalanceLbl.Text = "Balance : $" & TransactionTab.AccBal
                SetError(My.Resources.Verified, "Verified", ToolTipIcon.Info, "Account Verified")
            Else
                Await Task.Delay(1000)
                SetError(My.Resources.NotVerified, "Error", ToolTipIcon.Error, "Account Does Not Exist")
            End If
            TransactionTab.dt.Clear()
            TransactionTab.conn.Close()
        Else
            Await Task.Delay(1000)
            SetError(My.Resources.NotVerified, "Warning", ToolTipIcon.Warning, "Cannot Transfer Money To Self")
        End If

    End Sub

    Private Sub AmountTxt_Validating(sender As Object, e As EventArgs) Handles AmountTxt.Validating
        If AmountTxt.Text <> "" Then

        End If
    End Sub

    Sub SetError(Image As System.Drawing.Bitmap, Title As String, Icon As ToolTipIcon, Message As String)
        AccCheck.Image = Image
        ErrorToolTip.ToolTipTitle = Title
        ErrorToolTip.ToolTipIcon = Icon
        ErrorToolTip.SetToolTip(AccCheck, Message)
        If Icon = ToolTipIcon.Info Then
            CanProceed = True
        Else
            CanProceed = False
            ClearLabels()
        End If
    End Sub

    Sub ClearLabels()
        ToNameLbl.Text = "Name : "
        ToAccLbl.Text = "Acc No : "
        ToBalanceLbl.Text = "Balance : "
    End Sub

    Private Sub Transfer_Load(sender As Object, e As EventArgs) Handles Me.Load
        FromNameLbl.Text = "Name : " & TransactionTab.AccName
        FromAccLbl.Text = "Acc No : " & TransactionTab.AccNo
        FromBalanceLbl.Text = "Balance : $" & TransactionTab.AccBal
        ToNameLbl.Text = "Name : "
        ToAccLbl.Text = "Acc No : "
        ToBalanceLbl.Text = "Balance : "
        ToAccTxt.Text = "Enter Acc No To Transfer"
        AmountTxt.Text = "Enter Amount To Transfer"
        AccCheck.Visible = False
        CurrAcc = TransactionTab.AccNo
        CurrBal = TransactionTab.AccBal
    End Sub

    Private Sub ProceedBtn_Click(sender As Object, e As EventArgs) Handles ProceedBtn.Click
        Me.DialogResult = Windows.Forms.DialogResult.None
        If AmountTxt.Text <> "" And IsNumeric(AmountTxt.Text) And CanProceed Then
            If CurrBal < Integer.Parse(AmountTxt.Text) Then
                DisplayMsg.Message = "Entered Amount Exceeds Current Balance"
                DisplayMsg.ShowDialog()
                Exit Sub
            End If
            CurrBal -= Integer.Parse(AmountTxt.Text)
            TransactionTab.AccBal += Integer.Parse(AmountTxt.Text)
            TransactionTab.conn.Open()
            TransactionTab.query = "UPDATE Account SET Acc_Bal = " & CurrBal & " WHERE Acc_No = " & CurrAcc
            TransactionTab.cmd = New OleDb.OleDbCommand(TransactionTab.query, TransactionTab.conn)
            TransactionTab.cmd.ExecuteNonQuery()
            TransactionTab.query = "UPDATE Account SET Acc_Bal = " & TransactionTab.AccBal & " WHERE Acc_No = " & TransactionTab.AccNo
            TransactionTab.cmd = New OleDb.OleDbCommand(TransactionTab.query, TransactionTab.conn)
            TransactionTab.cmd.ExecuteNonQuery()
            TransactionTab.conn.Close()
            DisplayMsg.Message = "Transfer Successful"
            DisplayMsg.ShowDialog()

            TransactionTab.TransactionQuery(CurrAcc, "Transfer", AmountTxt.Text)
            TransactionTab.TransactionQuery(TransactionTab.AccNo, "Recieve", AmountTxt.Text)

            Me.Close()
        End If
    End Sub

End Class
