Public Class Account
    Dim CreateUC As Create
    Dim EmpCreateUC As EmpCreate
    Dim EmpUpdateUC As EmpUpdate
    Dim EmpDeleteUC As EmpDelete
    Dim UpdateUC As Update
    Dim DeleteUC As Delete
    Dim ViewAccUC As ViewAccount

    Private Sub CreateBtn_Click(sender As Object, e As EventArgs) Handles CreateBtn.Click
        If Not AdminForm.TabPanel.Controls.Contains(ViewAccUC) Then
            CreateUC = New Create()
            CreateUC.Dock = DockStyle.Fill
            AdminForm.TabPanel.Controls.Add(CreateUC)
        End If
        AdminForm.BackBtn.Show()
        AdminForm.PrevControl = AdminForm.GetUserControl()
        AdminForm.ShowUserControl(CreateUC)
        AdminForm.CurrControl = AdminForm.GetUserControl()
    End Sub

    Private Sub UpdateBtn_Click(sender As Object, e As EventArgs) Handles UpdateBtn.Click
        If Not AdminForm.TabPanel.Controls.Contains(UpdateUC) Then
            UpdateUC = New Update()
            UpdateUC.Dock = DockStyle.Fill
            AdminForm.TabPanel.Controls.Add(UpdateUC)
        End If
        AdminForm.BackBtn.Show()
        AdminForm.PrevControl = AdminForm.GetUserControl()
        AdminForm.ShowUserControl(UpdateUC)
        AdminForm.CurrControl = AdminForm.GetUserControl()
    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        If Not AdminForm.TabPanel.Controls.Contains(DeleteUC) Then
            DeleteUC = New Delete()
            DeleteUC.Dock = DockStyle.Fill
            AdminForm.TabPanel.Controls.Add(DeleteUC)
        End If
        AdminForm.BackBtn.Show()
        AdminForm.PrevControl = AdminForm.GetUserControl()
        AdminForm.ShowUserControl(DeleteUC)
        AdminForm.CurrControl = AdminForm.GetUserControl()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles EmpCreateBtn.Click
        If Not AdminForm.TabPanel.Controls.Contains(EmpCreateUC) Then
            EmpCreateUC = New EmpCreate()
            EmpCreateUC.Dock = DockStyle.Fill
            AdminForm.TabPanel.Controls.Add(EmpCreateUC)
        End If
        AdminForm.BackBtn.Show()
        AdminForm.PrevControl = AdminForm.GetUserControl()
        AdminForm.ShowUserControl(EmpCreateUC)
        AdminForm.CurrControl = AdminForm.GetUserControl()
    End Sub

    Private Sub HistoryBtn_Click(sender As Object, e As EventArgs) Handles CustViewBtn.Click
        If Not AdminForm.TabPanel.Controls.Contains(ViewAccUC) Then
            ViewAccUC = New ViewAccount()
            ViewAccUC.Val = "Cust"
            ViewAccUC.Dock = DockStyle.Fill
            AdminForm.TabPanel.Controls.Add(ViewAccUC)
        End If
        AdminForm.BackBtn.Show()
        AdminForm.PrevControl = AdminForm.GetUserControl()
        AdminForm.ShowUserControl(ViewAccUC)
        AdminForm.CurrControl = AdminForm.GetUserControl()
    End Sub

    Private Sub EmpViewBtn_Click(sender As Object, e As EventArgs) Handles EmpViewBtn.Click
        If Not AdminForm.TabPanel.Controls.Contains(ViewAccUC) Then
            ViewAccUC = New ViewAccount()
            ViewAccUC.Val = "Emp"
            ViewAccUC.Dock = DockStyle.Fill
            AdminForm.TabPanel.Controls.Add(ViewAccUC)
        End If

        AdminForm.BackBtn.Show()
        AdminForm.PrevControl = AdminForm.GetUserControl()
        AdminForm.ShowUserControl(ViewAccUC)
        AdminForm.CurrControl = AdminForm.GetUserControl()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles EmpUpdateBtn.Click
        If Not AdminForm.TabPanel.Controls.Contains(EmpUpdateUC) Then
            EmpUpdateUC = New EmpUpdate()
            EmpUpdateUC.Dock = DockStyle.Fill
            AdminForm.TabPanel.Controls.Add(EmpUpdateUC)
        End If
        AdminForm.BackBtn.Show()
        AdminForm.PrevControl = AdminForm.GetUserControl()
        AdminForm.ShowUserControl(EmpUpdateUC)
        AdminForm.CurrControl = AdminForm.GetUserControl()
    End Sub

    Private Sub EmpDeleteBtn_Click(sender As Object, e As EventArgs) Handles EmpDeleteBtn.Click
        If Not AdminForm.TabPanel.Controls.Contains(EmpDeleteUC) Then
            EmpDeleteUC = New EmpDelete()
            EmpDeleteUC.Dock = DockStyle.Fill
            AdminForm.TabPanel.Controls.Add(EmpDeleteUC)
        End If
        AdminForm.BackBtn.Show()
        AdminForm.PrevControl = AdminForm.GetUserControl()
        AdminForm.ShowUserControl(EmpDeleteUC)
        AdminForm.CurrControl = AdminForm.GetUserControl()
    End Sub
End Class
