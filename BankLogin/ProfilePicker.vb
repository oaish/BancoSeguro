Public Class ProfilePicker

    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Sub InitializeProfile()
        M1.ImageLocation = "Users\M1.png"
        M2.ImageLocation = "Users\M2.png"
        M3.ImageLocation = "Users\M3.png"
        M4.ImageLocation = "Users\M4.png"
        M5.ImageLocation = "Users\M5.png"
        M6.ImageLocation = "Users\M6.png"
        M7.ImageLocation = "Users\M7.png"
        M8.ImageLocation = "Users\M8.png"
        M9.ImageLocation = "Users\M9.png"
        M10.ImageLocation = "Users\M10.png"
        M11.ImageLocation = "Users\M11.png"
        M12.ImageLocation = "Users\M12.png"

        F1.ImageLocation = "Users\F1.png"
        F2.ImageLocation = "Users\F2.png"
        F3.ImageLocation = "Users\F3.png"
        F4.ImageLocation = "Users\F4.png"
        F5.ImageLocation = "Users\F5.png"
        F6.ImageLocation = "Users\F6.png"
        F7.ImageLocation = "Users\F7.png"
        F8.ImageLocation = "Users\F8.png"
    End Sub

    Private Sub ProfilePicker_Load(sender As Object, e As EventArgs) Handles Me.Load
        InitializeProfile()

        If Me.Tag = "Male" Then
            GenderTab.SelectTab(0)
        Else
            GenderTab.SelectTab(1)
        End If
    End Sub

    Private Sub M1_Click(PB As Object, e As EventArgs) Handles M1.Click, M2.Click, M3.Click, M4.Click, M5.Click, M6.Click, M7.Click, M8.Click, M9.Click, M10.Click, M11.Click, M12.Click, F1.Click, F2.Click, F3.Click, F4.Click, F5.Click, F6.Click, F7.Click, F8.Click
        AdminForm.ProfileImage = PB.ImageLocation
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
End Class