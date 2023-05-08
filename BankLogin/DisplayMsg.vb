Imports System.Windows.Forms

Public Class DisplayMsg
    Public Message As String
    Private Sub ProceedBtn_Click(sender As Object, e As EventArgs) Handles OkBtn.Click
        Me.Close()
    End Sub

    Private Sub Dialog2_Load(sender As Object, e As EventArgs) Handles Me.Load
        MessageLbl.Text = Message
        Me.Width = MessageLbl.Left + MessageLbl.Width + 8
        OkBtn.Location = New Point((Me.ClientSize.Width - OkBtn.Width) / 2, OkBtn.Location.Y)
    End Sub
End Class
