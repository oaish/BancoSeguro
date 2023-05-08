Public Class AdminForm
    Public AdminID = Login.EmpID
    Public AdminUser As String = Login.User
    Public AdminPass As String = Login.Pass
    Public ProfileImage As String

    Dim DashboardUC As New Dashboard()
    Dim AccountUC As New Account()
    Dim TransactionUC = New TransactionTab()
    Dim RecordsUC As New Records()
    Dim ManageUC As New Manage()
    Public PrevControl As UserControl
    Public CurrControl As UserControl


    Private Sub AdminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeTabs()
        Me.BackgroundImage = My.Resources.AppBGLowRez
    End Sub

    Sub ChangeSidePanel(Tab As Object)
        SidePanel.Top = Tab.Top
    End Sub

    Private Sub DashboardBtn_Click(sender As Object, e As EventArgs) Handles DashboardBtn.Click
        ChangeSidePanel(sender)
        ShowUserControl(DashboardUC)
    End Sub

    Private Sub AccountBtn_Click(sender As Object, e As EventArgs) Handles AccountBtn.Click
        ChangeSidePanel(sender)
        ShowUserControl(AccountUC)
    End Sub

    Private Sub TransactionBtn_Click(sender As Object, e As EventArgs) Handles TransactionBtn.Click
        ChangeSidePanel(sender)
        ShowUserControl(TransactionUC)
    End Sub

    Private Sub RecordsBtn_Click(sender As Object, e As EventArgs) Handles RecordsBtn.Click
        ChangeSidePanel(sender)
        ShowUserControl(RecordsUC)
    End Sub

    Private Sub ManageBtn_Click(sender As Object, e As EventArgs) Handles ManageBtn.Click
        ChangeSidePanel(sender)
        ShowUserControl(ManageUC)
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

    Private Sub CloseBtn_Click_1(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Application.Exit()
    End Sub

    Private Sub MinimizeBtn_Click(sender As Object, e As EventArgs) Handles MinimizeBtn.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Public  Sub ShowUserControl(userControl As UserControl)
        For Each ctrl As UserControl In TabPanel.Controls
            If ctrl Is userControl Then
                ctrl.Show()
            Else
                ctrl.Hide()
            End If
        Next
    End Sub

    Public Function GetUserControl() As UserControl
        For Each ctrl As UserControl In TabPanel.Controls
            If ctrl.Visible Then
                Return ctrl
            End If
        Next
        Return Nothing
    End Function

    Sub InitializeTabs()
        DashboardUC.Dock = DockStyle.Fill
        TabPanel.Controls.Add(DashboardUC)

        AccountUC.Dock = DockStyle.Fill
        TabPanel.Controls.Add(AccountUC)

        TransactionUC.Dock = DockStyle.Fill
        TabPanel.Controls.Add(TransactionUC)

        RecordsUC.Dock = DockStyle.Fill
        TabPanel.Controls.Add(RecordsUC)

        ManageUC.Dock = DockStyle.Fill
        TabPanel.Controls.Add(ManageUC)
    End Sub

    Public Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        TabPanel.Controls.Remove(CurrControl)
        ShowUserControl(PrevControl)
        BackBtn.Hide()
    End Sub
End Class