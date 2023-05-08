
Public Class Loan

    Private Sub DashboardBtn_Click(sender As Object, e As EventArgs)
        ChangeSidePanel(sender)
        DashBoardPanel.BringToFront()
    End Sub

    Private Sub AccountBtn_Click(sender As Object, e As EventArgs) Handles LoanBtn.Click
        ChangeSidePanel(sender)
        LoanPanel.BringToFront()
    End Sub

    Private Sub RecordsBtn_Click(sender As Object, e As EventArgs) Handles RecordsBtn.Click
        ChangeSidePanel(sender)
        RecordsPanel.BringToFront()
    End Sub

    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Application.Exit()
    End Sub

    Private Sub MinimizeBtn_Click(sender As Object, e As EventArgs) Handles MinimizeBtn.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Sub ChangeSidePanel(Tab As Object)
        SidePanel.Top = Tab.Top
    End Sub

    Private Sub LogoutBtn_Click(sender As Object, e As EventArgs) Handles LogoutBtn.Click
        Dim SP = SidePanel.Top
        ChangeSidePanel(sender)
        Dim DialogResult = Logout.ShowDialog()
        If DialogResult = MsgBoxResult.Yes Then
            Login.Show()
            Me.Close()
        End If
        SidePanel.Top = SP
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Emi_Calculator.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        home_loan.Show()
    End Sub
End Class



