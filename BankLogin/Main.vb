
Imports System.Data.OleDb
Imports System.Text.RegularExpressions
Public Class Main
    Dim s As String
    Dim dtime As String
    Shared random As New Random()
    Dim gender As String
    Dim AccType, History As String
    Dim type As String
    Dim myrandom As Integer = random.Next(10000000, 99999999)
    Dim myconn As OleDbConnection = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=BancoSeguro.mdb")
    Dim mycomm As OleDbCommand
    Dim da As OleDbDataAdapter
    Dim ds As New DataSet
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles AccCreateBtn.Click
        'PanelDash.Visible = False
        PanelDelAcc.Visible = False
        PanelAccountChoose.Visible = True
        PanelNewAccCreation.Visible = False
        PanelExistingAcc.Visible = False
        PanelDash.Visible = False
        PanelAccountChoose.BringToFront()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles DashBtn.Click
        'PanelAccountCreation.Visible = False
        PanelNewAccCreation.Visible = False
        PanelAccountChoose.Visible = False
        PanelExistingAcc.Visible = False
        PanelDash.Visible = True
        PanelDash.BringToFront()
        PanelTransfer.Visible = False

    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Button9.Visible = False
        'CAncelbtn.Visible = False
        ' PanelAccountCreation.Visible = False
        PanelNewAccCreation.Visible = False
        PanelAccountChoose.Visible = False
        PanelExistingAcc.Visible = False
        PanelDash.Visible = True
        PanelDash.BringToFront()
        PanelDelAcc.Visible = False
        Panelwithdraw.Visible = False
        PanelTransfer.Visible = False
    End Sub

    Private Sub PanelDash_Paint(sender As Object, e As PaintEventArgs) Handles PanelDash.Paint
        s = Date.Now.ToString
        Label4.Text = s
    End Sub

    Private Sub TextBox1_validating(sender As Object, e As EventArgs) Handles NameTxt.Validating
        If IsNumeric(NameTxt.Text) Then
            ErrorProvider1.SetError(NameTxt, "need Characters")
        ElseIf NameTxt.Text = "" Then
            ErrorProvider1.SetError(NameTxt, "Cannot be empty!")
            ' e.cancel = True
        Else
            ErrorProvider1.SetError(NameTxt, "")
        End If
    End Sub

    Private Sub TextBox3_validating(sender As Object, e As EventArgs) Handles EmailTxt.Validating
        If EmailTxt.Text.Contains("@gmail.com") Then
            ErrorProvider1.SetError(EmailTxt, "")
        Else
            ErrorProvider1.SetError(EmailTxt, "Invalid Email Id ")
        End If
    End Sub

    Private Sub TextBox5_Validating(sender As Object, e As EventArgs) Handles ContactTxt.Validating
        Dim exp = New Regex("\d{10}")
        Dim isvalid As Boolean = exp.IsMatch(ContactTxt.Text)
        If isvalid Then
            ErrorProvider1.SetError(ContactTxt, "")
        Else
            ErrorProvider1.SetError(ContactTxt, "Invalid Phone Number")
        End If
    End Sub
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs)
        If RadioButton1.Checked Then
            gender = "Male"
            Button9.Visible = True

        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs)
        If RadioButton2.Checked Then
            gender = "Female"
            Button9.Visible = True

        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)
        AccType = AccTypeCB.SelectedItem.ToString
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)
        '    If ((Date.Now.ToString) - (DateTimePicker1.Value.ToString) >= 18) Then
        'ErrorProvider1.SetError(DateTimePicker1, "")
        '    dtime = DateTimePicker1.Value.ToShortDateString
        '   Else
        '  ErrorProvider1.SetError(DateTimePicker1, "Account holder Must be an Adult")
        ' End If
    End Sub

    Private Sub AccCBBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AccCBBox.SelectedIndexChanged

        type = AccCBBox.SelectedItem.ToString ' Bruh Moment 100

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If NameTxt.Text = "" Or AddressTxt.Text = "" Or ContactTxt.Text = "" Or EmailTxt.Text = "" Or AccTypeCB.SelectedIndex = -1 Then
            MsgBox("Please Enter All the Details!!", vbInformation)
        Else

            Dim a As Integer = MsgBox("Create Account??", vbOKCancel, "Account Creation")
            If a = 1 Then
                If RadioButton2.Checked Then
                    gender = "Female"
                ElseIf RadioButton1.Checked Then
                    gender = "Male"
                End If
                AccType = AccTypeCB.SelectedItem.ToString
                dtime = DateTimePicker1.Value.ToShortDateString
                myconn.Open()
                Dim str, str1 As String
                str = "SELECT MAX(Cust_ID) FROM Customer"
                mycomm = New OleDbCommand(str, myconn)
                Dim Obj = mycomm.ExecuteScalar()
                Dim MaxID As Integer
                If IsDBNull(Obj) Then
                    MaxID = 1
                Else
                    MaxID = CType(Obj, Integer) + 1
                End If

                str = "INSERT INTO Customer (Cust_ID, Cust_Name, Cust_Gender, Cust_DOB, Cust_Phone, Cust_Email, Cust_Address)" &
                      "VALUES (@ID, @Name, @Gender, @DOB, @Phone, @Email, @Address)"
                mycomm = New OleDbCommand(str, myconn)
                mycomm.Parameters.AddWithValue("@ID", MaxID) 'Idhar ID ka variable aayega agar hai to
                mycomm.Parameters.AddWithValue("@Name", NameTxt.Text)
                mycomm.Parameters.AddWithValue("@Gender", gender)
                mycomm.Parameters.AddWithValue("@DOB", dtime)
                mycomm.Parameters.AddWithValue("@Phone", ContactTxt.Text)
                mycomm.Parameters.AddWithValue("@Email", EmailTxt.Text)
                mycomm.Parameters.AddWithValue("@Address", AddressTxt.Text)

                mycomm.ExecuteNonQuery()
                str1 = "INSERT INTO Account (Acc_No, Acc_Type, Acc_Bal, Cust_ID) VALUES (@rand , @Acctype, @Bal, @ID)"
                mycomm = New OleDbCommand(str1, myconn)
                mycomm.Parameters.AddWithValue("@rand", myrandom)
                mycomm.Parameters.AddWithValue("@Acctype", AccType)
                mycomm.Parameters.AddWithValue("@Bal", 500)
                mycomm.Parameters.AddWithValue("@ID", MaxID)
                Dim count As Integer = mycomm.ExecuteNonQuery()
                MsgBox(count & " Account Created!", vbOKOnly)
                History = NameTxt.Text & "'s Account has been Created at " & Date.Now.ToString
                Labelhist.Text &= "" & History & vbCrLf
            End If
        End If
        myconn.Close()
    End Sub


    Private Sub accSubmitbtn_Click(sender As Object, e As EventArgs) Handles accSubmitbtn.Click
        If type = "NewAccount" Then
            PanelNewAccCreation.Visible = True
            PanelNewAccCreation.BringToFront()
            PanelAccountChoose.Visible = False
        ElseIf type = "ExistingAccount" Then
            PanelExistingAcc.Visible = True
            PanelExistingAcc.BringToFront()
            PanelAccountChoose.Visible = False
        End If
    End Sub

    Private Sub ViewSearchbtn_Click(sender As Object, e As EventArgs) Handles ViewSearchbtn.Click
        myconn.Open()
        Dim cgender, cemail, caddress, cdob, cphone As String
        Dim cAcNo, bal As Integer
        Dim query = "Select Cust_Name,Acc_Bal,Acc_No,Cust_Email,Cust_Gender,Cust_Phone,Cust_DOB,Cust_Address,C.Cust_ID from Customer C INNER JOIN Account A on C.Cust_ID = A.Cust_ID"
        da = New OleDbDataAdapter(query, myconn)
        Dim dt As New DataTable
        da.Fill(dt)
        If TextBox1.Text = "" Then
            MsgBox("No Record Found!!", vbExclamation)
        Else
            For x As Integer = 0 To dt.Rows.Count - 1
                If TextBox1.Text = dt.Rows(x)("Cust_Name").ToString Then
                    cgender = dt.Rows(x)("Cust_Gender").ToString()
                    cemail = dt.Rows(x)("Cust_Email").ToString()
                    caddress = dt.Rows(x)("Cust_Address").ToString()
                    cAcNo = dt.Rows(x)("Acc_No").ToString()
                    cphone = dt.Rows(x)("Cust_Phone")
                    cdob = dt.Rows(x)("Cust_DOB")
                    bal = dt.Rows(x)("Acc_Bal")
                End If
            Next
            If dt.Rows.Count = 0 Then
                MsgBox("Employee doesn't exit")
            Else
                TextBoxnumber.Text = cphone
                TextBoxgender.Text = cgender
                TextBoxid.Text = cemail
                TextBoxNo.Text = cAcNo
                TextBoxdob.Text = cdob
                TextBoxaddress.Text = caddress
                TextBoxbalance.Text = bal
            End If
        End If
        myconn.Close()
    End Sub

    Private Sub ViewAccBtn_Click(sender As Object, e As EventArgs) Handles ViewAccBtn.Click
        PanelViewAcc.Visible = True
        PanelViewAcc.BringToFront()
        PanelNewAccCreation.Visible = False
        PanelAccountChoose.Visible = False
        PanelExistingAcc.Visible = False
        PanelDash.Visible = False
        PanelDelAcc.Visible = False
    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        PanelViewAcc.Visible = False
        PanelNewAccCreation.Visible = False
        PanelAccountChoose.Visible = False
        PanelExistingAcc.Visible = True
        PanelExistingAcc.BringToFront()
        PanelDash.Visible = False
        PanelDelAcc.Visible = False
        TextBox1.Text = ""
        TextBoxNo.Text = ""
        TextBoxnumber.Text = ""
        TextBoxgender.Text = ""
        TextBoxdob.Text = ""
        TextBoxbalance.Text = ""
        TextBoxid.Text = ""
        TextBoxaddress.Text = ""
    End Sub

    Private Sub Button8_Click_1(sender As Object, e As EventArgs) Handles Button8.Click
        PanelViewAcc.Visible = False
        PanelNewAccCreation.Visible = False
        PanelAccountChoose.Visible = True
        PanelAccountChoose.BringToFront()
        PanelExistingAcc.Visible = False
        PanelDash.Visible = False
        PanelDelAcc.Visible = False
    End Sub

    Private Sub DeleteAccBtn_Click(sender As Object, e As EventArgs) Handles DeleteAccBtn.Click
        PanelDelAcc.Visible = True
        PanelDelAcc.BringToFront()
        PanelViewAcc.Visible = False
        PanelNewAccCreation.Visible = False
        PanelAccountChoose.Visible = False
        PanelExistingAcc.Visible = False
        PanelDash.Visible = False
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        PanelExistingAcc.Visible = True
        PanelExistingAcc.BringToFront()
        PanelDelAcc.Visible = False
        PanelViewAcc.Visible = False
        PanelNewAccCreation.Visible = False
        PanelAccountChoose.Visible = False
        PanelDash.Visible = False
        acctext.Text = ""
        nametext.Text = ""
        dobtext.Text = ""
        emailtext.Text = ""
        phonetext.Text = ""
        addresstext.Text = ""
        gendertext.Text = ""
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        myconn.Open()
        '  Dim cgender, cemail, caddress, cdob, cphone As String
        '   Dim cAcNo As Integer
        Dim query = "Select Cust_Name,Acc_No,Cust_Email,Cust_Gender,Cust_Phone,Cust_DOB,Cust_Address,C.Cust_ID from Customer C INNER JOIN Account A on C.Cust_ID = A.Cust_ID"
        da = New OleDbDataAdapter(query, myconn)
        Dim dt As New DataTable
        da.Fill(dt)
        If acctext.Text = "" Then
            MsgBox("Enter Account Number!!")
        Else
           

                For x As Integer = 0 To dt.Rows.Count - 1

                    If acctext.Text = dt.Rows(x)("Acc_No") Then
                        gendertext.Text = dt.Rows(x)("Cust_Gender").ToString()
                        emailtext.Text = dt.Rows(x)("Cust_Email").ToString()
                        addresstext.Text = dt.Rows(x)("Cust_Address").ToString()
                        nametext.Text = dt.Rows(x)("Cust_Name").ToString()
                        phonetext.Text = dt.Rows(x)("Cust_Phone")
                        dobtext.Text = dt.Rows(x)("Cust_DOB")
                    End If

                Next

            End If

        myconn.Close()

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        myconn.Open()
        Dim query = "Select Cust_ID from Account where Acc_No = " & acctext.Text & " "
        If acctext.Text = "" Then
            MsgBox("Enter Account Number!!")
        Else

            mycomm = New OleDbCommand(query, myconn)
            Dim id = mycomm.ExecuteScalar()
            If id = 0 Then
                MsgBox("No Record found!!")
            Else
                Dim str = "Update Customer set Cust_Name = '" & nametext.Text & "', Cust_Gender = '" & gendertext.Text & "' , Cust_DOB = '" & dobtext.Text & "', Cust_Phone = '" & phonetext.Text & "', Cust_Email = '" & emailtext.Text & "', Cust_Address = '" & addresstext.Text & "' where Cust_ID = " & id
                mycomm = New OleDbCommand(str, myconn)
                mycomm.ExecuteNonQuery()
                MsgBox(nametext.Text & "'s Account has been updated")
                History = nametext.Text & "'s Account has been Updated at " & Date.Now.ToString
                Labelhist.Text &= "" & History & vbCrLf
            End If
        End If
        myconn.Close()
    End Sub



    Private Sub Button10_Click_1(sender As Object, e As EventArgs) Handles Button10.Click
        myconn.Open()
        Dim query = " Select Cust_ID from Account where Acc_No = " & TextBox2.Text & " "
        If TextBox2.Text = "" Then
            MsgBox("Enter Account Number!!")
        Else

            mycomm = New OleDbCommand(query, myconn)
            Dim id = mycomm.ExecuteScalar()
            If id = 0 Then
                MsgBox("No Record Found", vbExclamation, "Account Deletion")
            Else
                Dim a = MsgBox("Account found! Want to delete?", vbOKCancel)
                If a = 1 Then
                    Dim str = "Delete from Account where Acc_No = " & TextBox2.Text & ""
                    mycomm = New OleDbCommand(str, myconn)
                    mycomm.ExecuteNonQuery()
                    Dim str1 = "Delete from Customer where Cust_ID = " & id
                    mycomm = New OleDbCommand(str1, myconn)
                    mycomm.ExecuteNonQuery()
                    MsgBox("Account has been Deleted", vbOKOnly, "Deleted")
                    History = TextBox2.Text & "'s Account has been Deleted at " & Date.Now.ToString
                    Labelhist.Text &= "" & History & vbCrLf
                End If

            End If
        End If
        myconn.Close()
    End Sub

    Private Sub UpdateAccBtn_Click(sender As Object, e As EventArgs) Handles UpdateAccBtn.Click
        PanelUpdateAcc.Visible = True
        PanelUpdateAcc.BringToFront()
        PanelDash.Visible = False
        PanelDelAcc.Visible = False

    End Sub



   
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        PanelAccountChoose.Visible = True
        PanelAccountChoose.BringToFront()
        NameTxt.Text = ""
        AddressTxt.Text = ""
        ContactTxt.Text = ""
        EmailTxt.Text = ""
        ' AccCBBox.SelectedIndex = -1
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        PanelExistingAcc.Visible = True
        PanelExistingAcc.BringToFront()
        TextBox2.Text = ""
    End Sub

    
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        TextBoxnumber.Text = ""
        TextBoxaddress.Text = ""
        TextBoxid.Text = ""
        TextBoxNo.Text = ""
        TextBoxdob.Text = ""
        TextBoxaddress.Text = ""
        TextBoxbalance.Text = ""
        TextBoxgender.Text = ""
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        gendertext.Text = ""
        emailtext.Text = ""
        addresstext.Text = ""
        nametext.Text = ""
        phonetext.Text = ""
        dobtext.Text = ""
        acctext.Text = " "
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Panelwithdraw.Visible = True
        Panelwithdraw.BringToFront()
        TextBoxWithAcccNo.Text = ""
        TextBoxWithAmt.Text = ""
    End Sub

    Private Sub Withdrawbtn_Click(sender As Object, e As EventArgs) Handles Withdrawbtn.Click
        myconn.Open()
        Dim query = " Select Acc_Bal from Account where Acc_No = " & TextBoxWithAcccNo.Text & " "
        mycomm = New OleDbCommand(query, myconn)
        Dim bal = mycomm.ExecuteScalar()
        bal = bal - TextBoxWithAmt.Text
        If bal >= 500 Then
            Dim str = "Update Account set Acc_Bal = " & bal & " where Acc_No = " & TextBoxWithAcccNo.Text
            mycomm = New OleDbCommand(Str, myconn)
            mycomm.ExecuteNonQuery()
            MsgBox(" Amount has been withdrawn from your Account")
            History = TextBoxWithAcccNo.Text & "'s Account has been Withdrawn amount of $" & TextBoxWithAmt.Text & "at " & Date.Now.ToString
            Labelhist.Text &= "" & History & vbCrLf
        Else
            TextBoxWithAmt.Text = ""
            MsgBox("Your Balance is less than 500$ ", vbCritical, "Withdraw")
        End If
       
        myconn.Close()
    End Sub

  
    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        TextBoxWithAcccNo.Text = ""
        TextBoxWithAmt.Text = ""
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        myconn.Open()
        Dim query = " Select Acc_Bal from Account where Acc_No = " & TextBoxdepno.Text & " "
        If TextBoxdepno.Text = "" Then

            MsgBox("Enter Account number")
        Else
            mycomm = New OleDbCommand(query, myconn)
            Dim bal = mycomm.ExecuteScalar()
            If bal = 0 Then
                MsgBox("No Such Record Found!!", vbExclamation, "NO Record")
            Else
                bal = bal + TextBoxdepamt.Text

                Dim str = "Update Account set Acc_Bal = " & bal & " where Acc_No = " & TextBoxdepno.Text
                mycomm = New OleDbCommand(str, myconn)
                mycomm.ExecuteNonQuery()
                MsgBox(" Amount has been deposited in your Account")
                History = TextBoxdepno.Text & "'s Account has been deposited by amount of $" & TextBoxdepamt.Text & " at " & Date.Now.ToString
                Labelhist.Text &= "" & History & vbCrLf
            End If
        End If
        myconn.Close()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        TextBoxdepno.Text = ""
        TextBoxdepamt.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PanelDeposit.Visible = True
        PanelDeposit.BringToFront()
        TextBoxdepno.Text = ""
        TextBoxdepamt.Text = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBoxtsendnumber.Text = ""
        TextBoxreceivnumber.Text = ""
        TextBoxamt.Text = ""
        PanelTransfer.Visible = True  ' trans
        PanelTransfer.BringToFront()
        PanelDeposit.Visible = False
        Panelwithdraw.Visible = False
        PanelExistingAcc.Visible = False
        PanelUpdateAcc.Visible = False

        PanelExistingAcc.Visible = False
        PanelDelAcc.Visible = False
        PanelViewAcc.Visible = False
        PanelNewAccCreation.Visible = False
        PanelAccountChoose.Visible = False
        PanelDash.Visible = False
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click

            myconn.Open()
            'sender
        Dim query = " Select Acc_Bal from Account where Acc_No = " & TextBoxtsendnumber.Text & " "
        If TextBoxtsendnumber.Text = "" Then

            MsgBox("Enter Sender's Account number")
        Else

            mycomm = New OleDbCommand(query, myconn)
            Dim bal = mycomm.ExecuteScalar()
            If IsDBNull(bal) Then
                MsgBox("No Such Record Found!!", vbExclamation, "NO Record")
            Else
                bal = bal - TextBoxamt.Text
                If bal >= 500 Then
                    Dim str = "Update Account set Acc_Bal = " & bal & " where Acc_No = " & TextBoxtsendnumber.Text
                    mycomm = New OleDbCommand(str, myconn)
                    mycomm.ExecuteNonQuery()
                    '  MsgBox(" Amount has been withdrawn from your Account")
                Else
                    TextBoxWithAmt.Text = ""
                    MsgBox("Your Balance is less than 500$ ", vbCritical, "Withdraw")
                    Return
                End If


                'receiver
                Dim query1 = " Select Acc_Bal from Account where Acc_No = " & TextBoxreceivnumber.Text & " "
                If TextBoxreceivnumber.Text = "" Then

                    MsgBox("Enter Receiver's Account number")
                Else
                    mycomm = New OleDbCommand(query1, myconn)
                    Dim bal1 = mycomm.ExecuteScalar()
                    bal1 = bal1 + TextBoxamt.Text

                    Dim str1 = "Update Account set Acc_Bal = " & bal1 & " where Acc_No = " & TextBoxreceivnumber.Text
                    mycomm = New OleDbCommand(str1, myconn)
                    mycomm.ExecuteNonQuery()
                    MsgBox("Transaction Completed!")
                End If
            End If
        End If
        myconn.Close()
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        TextBoxreceivnumber.Text = ""
        TextBoxtsendnumber.Text = ""
        TextBoxamt.Text = ""

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        PanelHistory.Visible = True
        PanelHistory.BringToFront()
    End Sub

    Private Sub DashBtn_MouseEnter(sender As Object, e As EventArgs) Handles DashBtn.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub
    Private Sub DashBtn_MouseLeave(sender As Object, e As EventArgs) Handles DashBtn.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub AccCreateBtn_MouseEnter(sender As Object, e As EventArgs) Handles AccCreateBtn.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub
    Private Sub AccCreateBtn_MouseEnter1(sender As Object, e As EventArgs) Handles AccCreateBtn.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Button2_MouseEnter(sender As Object, e As EventArgs) Handles Button2.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub
    Private Sub Button2_MouseEnter1(sender As Object, e As EventArgs) Handles Button2.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Button5_MouseEnter(sender As Object, e As EventArgs) Handles Button5.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub
    Private Sub Button5_MouseEnter1(sender As Object, e As EventArgs) Handles Button5.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Button4_MouseEnter(sender As Object, e As EventArgs) Handles Button4.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub
    Private Sub Button4_MouseEnter1(sender As Object, e As EventArgs) Handles Button4.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Button3_MouseEnter(sender As Object, e As EventArgs) Handles Button3.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub
    Private Sub Button3_MouseEnter1(sender As Object, e As EventArgs) Handles Button3.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub DeleteAccBtn_MouseEnter(sender As Object, e As EventArgs) Handles DeleteAccBtn.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub DeleteAccBtn_MouseLeave(sender As Object, e As EventArgs) Handles DeleteAccBtn.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ViewAccBtn_MouseEnter(sender As Object, e As EventArgs) Handles ViewAccBtn.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub ViewAccBtn_MouseLeave(sender As Object, e As EventArgs) Handles ViewAccBtn.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub UpdateAccBtn_MouseEnter(sender As Object, e As EventArgs) Handles UpdateAccBtn.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub UpdateAccBtn_MouseLeave(sender As Object, e As EventArgs) Handles UpdateAccBtn.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Button8_MouseEnter(sender As Object, e As EventArgs) Handles Button8.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub Button8_MouseLeave(sender As Object, e As EventArgs) Handles Button8.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Button9_MouseEnter(sender As Object, e As EventArgs) Handles Button9.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub Button9_MouseLeave(sender As Object, e As EventArgs) Handles Button9.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub CAncelbtn_MouseEnter(sender As Object, e As EventArgs)
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub CAncelbtn_MouseLeave(sender As Object, e As EventArgs)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Button7_MouseEnter(sender As Object, e As EventArgs) Handles Button7.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub Button7_MouseLeave(sender As Object, e As EventArgs) Handles Button7.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub accSubmitbtn_MouseEnter(sender As Object, e As EventArgs) Handles accSubmitbtn.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub accSubmitbtn_MouseLeave(sender As Object, e As EventArgs) Handles accSubmitbtn.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Button19_MouseEnter(sender As Object, e As EventArgs) Handles Button19.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub Button19_MouseLeave(sender As Object, e As EventArgs) Handles Button19.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Button20_MouseEnter(sender As Object, e As EventArgs) Handles Button20.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub Button20_MouseLeave(sender As Object, e As EventArgs) Handles Button20.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Button13_MouseEnter(sender As Object, e As EventArgs) Handles Button13.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub Button13_MouseLeave(sender As Object, e As EventArgs) Handles Button13.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Button15_MouseEnter(sender As Object, e As EventArgs) Handles Button15.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub Button15_MouseLeave(sender As Object, e As EventArgs) Handles Button15.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Button12_MouseEnter(sender As Object, e As EventArgs) Handles Button12.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub Button12_MouseLeave(sender As Object, e As EventArgs) Handles Button12.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Button11_MouseEnter(sender As Object, e As EventArgs) Handles Button11.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub Button11_MouseLeave(sender As Object, e As EventArgs) Handles Button11.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Button10_MouseEnter(sender As Object, e As EventArgs) Handles Button10.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub Button10_MouseLeave(sender As Object, e As EventArgs) Handles Button10.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Button14_MouseEnter(sender As Object, e As EventArgs) Handles Button14.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub Button14_MouseLeave(sender As Object, e As EventArgs) Handles Button14.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Button17_MouseEnter(sender As Object, e As EventArgs) Handles Button17.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub Button17_MouseLeave(sender As Object, e As EventArgs) Handles Button17.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Button18_MouseEnter(sender As Object, e As EventArgs) Handles Button18.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub Button18_MouseLeave(sender As Object, e As EventArgs) Handles Button18.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Button16_MouseEnter(sender As Object, e As EventArgs) Handles Button16.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub Button16_MouseLeave(sender As Object, e As EventArgs) Handles Button16.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Withdrawbtn_MouseEnter(sender As Object, e As EventArgs) Handles Withdrawbtn.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub Withdrawbtn_MouseLeave(sender As Object, e As EventArgs) Handles Withdrawbtn.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ViewSearchbtn_MouseEnter(sender As Object, e As EventArgs) Handles ViewSearchbtn.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub ViewSearchbtn_MouseLeave(sender As Object, e As EventArgs) Handles ViewSearchbtn.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Button6_MouseEnter(sender As Object, e As EventArgs) Handles Button6.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub Button6_MouseLeave(sender As Object, e As EventArgs) Handles Button6.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub


    Private Sub TextBoxtsendnumber_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextBoxtsendnumber.Validating
        If TextBoxtsendnumber.Text = "" Then
            ErrorProvider1.SetError(TextBoxtsendnumber, "Cannot be Empty!")
            e.Cancel = True
        Else
            ErrorProvider1.SetError(TextBoxtsendnumber, "")
        End If
    End Sub

    Private Sub TextBoxreceivnumber_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextBoxreceivnumber.Validating
        If TextBoxreceivnumber.Text = "" Then
            ErrorProvider1.SetError(TextBoxreceivnumber, "Cannot be Empty!")
            e.Cancel = True
        Else
            ErrorProvider1.SetError(TextBoxreceivnumber, "")
        End If
    End Sub

    Private Sub TextBoxamt_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextBoxamt.Validating
        If TextBoxamt.Text = "" Then
            ErrorProvider1.SetError(TextBoxamt, "Cannot be Empty!")
            e.Cancel = True
        Else
            ErrorProvider1.SetError(TextBoxamt, "")
        End If
    End Sub

    Private Sub acctext_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles acctext.Validating
        ''
        If Not IsNumeric(acctext.Text) Then

            ErrorProvider1.SetError(acctext, "No such Record Found!!")
            e.Cancel = True
        Else
            ErrorProvider1.SetError(acctext, "")
        End If
    End Sub

    Private Sub TextBox2_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextBox2.Validating
        If Not IsNumeric(TextBox2.Text) Then

            ErrorProvider1.SetError(TextBox2, "No such Record Found!!")
            e.Cancel = True
        Else
            ErrorProvider1.SetError(TextBox2, "")
        End If
    End Sub
End Class