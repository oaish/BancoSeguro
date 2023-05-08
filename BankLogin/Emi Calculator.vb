Public Class Emi_Calculator
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim LoanAmount, Interest, Tenure, Emi As Decimal
        Try

    
        LoanAmount = Decimal.Parse(TextBox1.Text)
        Interest = Decimal.Parse(TextBox2.Text)
        Tenure = Decimal.Parse(TextBox3.Text)
        Catch ex As Exception
            MsgBox("Enter All the Fields!!")
        End Try
        Interest = Interest / 1200

        Emi = LoanAmount * Interest * (Math.Pow((1 + Interest), Tenure) / (Math.Pow((1 + Interest), Tenure) - 1))

        TextBox4.Text = Math.Round(Emi, 0)
        TextBox5.Text = Math.Round((Emi * Tenure) - LoanAmount, 0)
        TextBox6.Text = Math.Round(Emi * Tenure, 0)
    End Sub
End Class