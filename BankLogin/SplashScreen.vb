Public Class SplashScreen
    Dim str As String = "Banco Seguro       "
    Dim ch() As Char = str.ToCharArray()
    Dim idx As Integer = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles LoadText.Tick
        If idx = ch.Length Then
            LoadText.Stop()
            Exit Sub
        End If
        BankName.Text &= ch(idx)
        idx += 1
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BankName.Text = ""
        LoadText.Start()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub
End Class