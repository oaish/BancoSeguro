Imports System.Data.OleDb
Public Class Records
    Dim ShowAccQry As String
    Dim AccNoQry As String
    Dim AccTypeQry As String
    Dim AccBalQry As String
    Dim GenderQry As String
    Dim DOBQry As String
    Dim PhoneQry As String
    Dim EmailQry As String
    Dim AddressQry As String
    Dim RowLimitQry As String

    Dim LoginQry As String
    Dim UserQry As String
    Dim PassQry As String
    Dim EPosQry As String
    Dim EDOBQry As String
    Dim EPhoneQry As String
    Dim EEmailQry As String
    Dim EAddressQry As String
    Dim ERowLimitQry As String
    Dim RoleQry As String

    Public conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=BancoSeguro.mdb;")
    Public cmd As OleDbCommand
    Public ds As New DataSet
    Public adp As OleDbDataAdapter
    Public qry As String

    Private Sub CCheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles ShowAccCB.CheckedChanged
        If sender.Checked Then
            AccBalCB.Enabled = True
            AccTypeCB.Enabled = True
            ShowAccQry = "INNER JOIN Account ON Customer.Cust_ID = Account.Cust_ID"
            AccNoQry = "Acc_No"
        Else
            AccBalCB.Enabled = False
            AccBalCB.Checked = False
            AccTypeCB.Enabled = False
            AccTypeCB.Checked = False
            ShowAccQry = ""
            AccNoQry = ""
        End If
    End Sub

    Private Sub RowLmtTxt_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles RowLmtTxt.Validating
        If sender.Text <> "" Then
            If IsNumeric(sender.Text) Then
                ErrorProviderX.SetError(sender, "")
                RowLimitQry = "TOP " & sender.Text & " "
            Else
                ErrorProviderX.SetError(sender, "Error: Enter a Valid Integer")
                RowLimitQry = ""
            End If
        Else
            RowLimitQry = ""
        End If
    End Sub


    Private Sub CSubmitBtn_Click(sender As Object, e As EventArgs) Handles NextBtn.Click
        qry = "SELECT " & RowLimitQry & ColumnsToString() &
              " FROM Customer " & ShowAccQry
        conn.Open()
        adp = New OleDbDataAdapter(qry, conn)
        ds.Tables.Clear()
        adp.Fill(ds)
        If ds.Tables.Count <> 0 Then
            RecordsGridView.DataSource = ds.Tables(0)
        End If
        conn.Close()
        CustFiltersGB.Visible = False
    End Sub

    Private Sub AccTypeCB_CheckedChanged(sender As Object, e As EventArgs) Handles AccTypeCB.CheckedChanged
        If sender.Checked Then
            AccTypeQry = "Acc_Type"
        Else
            AccTypeQry = ""
        End If
    End Sub

    Private Sub AccBalCB_CheckedChanged(sender As Object, e As EventArgs) Handles AccBalCB.CheckedChanged
        If sender.Checked Then
            AccBalQry = "Acc_Bal"
        Else
            AccBalQry = ""
        End If
    End Sub

    Private Sub GenderCB_CheckedChanged(sender As Object, e As EventArgs) Handles GenderCB.CheckedChanged
        If sender.Checked Then
            GenderQry = "Cust_Gender"
        Else
            GenderQry = ""
        End If
    End Sub

    Private Sub DOBCB_CheckedChanged(sender As Object, e As EventArgs) Handles DOBCB.CheckedChanged
        If sender.Checked Then
            DOBQry = "Cust_DOB"
        Else
            DOBQry = ""
        End If
    End Sub

    Private Sub CPhone_CheckedChanged(sender As Object, e As EventArgs) Handles PhoneCB.CheckedChanged
        If sender.Checked Then
            PhoneQry = "Cust_Phone"
        Else
            PhoneQry = ""
        End If
    End Sub

    Private Sub EmailCB_CheckedChanged(sender As Object, e As EventArgs) Handles EmailCB.CheckedChanged
        If sender.Checked Then
            EmailQry = "Cust_Email"
        Else
            EmailQry = ""
        End If
    End Sub

    Private Sub AddressCB_CheckedChanged(sender As Object, e As EventArgs) Handles AddressCB.CheckedChanged
        If sender.Checked Then
            AddressQry = "Cust_Address"
        Else
            AddressQry = ""
        End If
    End Sub

    Private Sub UpdateBtn_Click(sender As Object, e As EventArgs) Handles SelectAllBtn.Click
        If SelectAllBtn.Text = "Select All" Then
            ShowAccCB.Checked = True
            AccTypeCB.Checked = True
            AccBalCB.Checked = True
            GenderCB.Checked = True
            DOBCB.Checked = True
            PhoneCB.Checked = True
            EmailCB.Checked = True
            AddressCB.Checked = True
            SelectAllBtn.Text = "Deselect"
            SelectAllBtn.Image = My.Resources.uncheck_all_30px
        Else
            ShowAccCB.Checked = False
            AccTypeCB.Checked = False
            AccBalCB.Checked = False
            GenderCB.Checked = False
            DOBCB.Checked = False
            PhoneCB.Checked = False
            EmailCB.Checked = False
            AddressCB.Checked = False
            SelectAllBtn.Text = "Select All"
            SelectAllBtn.Image = My.Resources.check_all_30px
        End If
    End Sub

    Function ColumnsToString() As String
        Dim ColQry As String = "Customer.Cust_ID, Cust_Name, "
        If ShowAccCB.Checked Then
            ColQry &= AccNoQry & ", "
        End If
        If GenderCB.Checked Then
            ColQry &= GenderQry & ", "
        End If
        If DOBCB.Checked Then
            ColQry &= DOBQry & ", "
        End If
        If PhoneCB.Checked Then
            ColQry &= PhoneQry & ", "
        End If
        If EmailCB.Checked Then
            ColQry &= EmailQry & ", "
        End If
        If AddressCB.Checked Then
            ColQry &= AddressQry & ", "
        End If
        If AccTypeCB.Checked Then
            ColQry &= AccTypeQry & ", "
        End If
        If AccBalCB.Checked Then
            ColQry &= AccBalQry & ", "
        End If
        Return ColQry.Substring(0, ColQry.Length - 2)
    End Function

    Private Sub CustRecordBtn_Click(sender As Object, e As EventArgs) Handles CustRecordBtn.Click
        CustFiltersGB.Visible = True
        EmpFiltersGB.Visible = False
        RecordsGridView.SendToBack()
    End Sub

    Private Sub EmpRecordBtn_Click(sender As Object, e As EventArgs) Handles EmpRecordBtn.Click
        CustFiltersGB.Visible = False
        EmpFiltersGB.Visible = True
        RecordsGridView.SendToBack()
    End Sub

    '''''''''''''''
    'Employee Part'
    '''''''''''''''

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles LoginCB.CheckedChanged
        If sender.Checked Then
            UserCB.Enabled = True
            PassCB.Enabled = True
            LoginQry = "INNER JOIN Login ON Employee.Emp_ID = Login.Emp_ID"
        Else
            UserCB.Enabled = False
            UserCB.Checked = False
            PassCB.Enabled = False
            PassCB.Checked = False
            LoginQry = ""
        End If
    End Sub

    Private Sub ERowLmtTxt_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ERowLmtTxt.Validating
        If sender.Text <> "" Then
            If IsNumeric(sender.Text) Then
                ErrorProviderX.SetError(sender, "")
                ERowLimitQry = "TOP " & sender.Text & " "
            Else
                ErrorProviderX.SetError(sender, "Error: Enter a Valid Integer")
                ERowLimitQry = ""
            End If
        Else
            ERowLimitQry = ""
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RoleCB.SelectedIndexChanged
        If RoleCB.SelectedIndex <> -1 Then
            RoleQry = " WHERE Emp_Position = '" & RoleCB.SelectedItem.ToString() & "'"
        Else
            RoleQry = ""
        End If
    End Sub

    Private Sub SubmitBtn_Click(sender As Object, e As EventArgs) Handles ENextBtn.Click
        qry = "SELECT " & ERowLimitQry & EColumnsToString() &
              " FROM Employee " & LoginQry & RoleQry
        conn.Open()
        adp = New OleDbDataAdapter(qry, conn)
        ds.Tables.Clear()
        adp.Fill(ds)
        If ds.Tables.Count <> 0 Then
            RecordsGridView.DataSource = ds.Tables(0)
        End If
        conn.Close()
        EmpFiltersGB.Visible = False
    End Sub

    Private Sub PassCB_CheckedChanged(sender As Object, e As EventArgs) Handles PassCB.CheckedChanged
        If sender.Checked Then
            PassQry = "Password"
        Else
            PassQry = ""
        End If
    End Sub

    Private Sub UserCB_CheckedChanged(sender As Object, e As EventArgs) Handles UserCB.CheckedChanged
        If sender.Checked Then
            UserQry = "Username"
        Else
            UserQry = ""
        End If
    End Sub

    Private Sub EGenderCB_CheckedChanged(sender As Object, e As EventArgs) Handles EPosCB.CheckedChanged
        If sender.Checked Then
            EPosQry = "Emp_Position"
        Else
            EPosQry = ""
        End If
    End Sub

    Private Sub EDOBCB_CheckedChanged(sender As Object, e As EventArgs) Handles EDOBCB.CheckedChanged
        If sender.Checked Then
            EDOBQry = "Emp_DOB"
        Else
            EDOBQry = ""
        End If
    End Sub

    Private Sub Phone_CheckedChanged(sender As Object, e As EventArgs) Handles EPhoneCB.CheckedChanged
        If sender.Checked Then
            EPhoneQry = "Emp_Phone"
        Else
            EPhoneQry = ""
        End If
    End Sub

    Private Sub EEmailCB_CheckedChanged(sender As Object, e As EventArgs) Handles EEmailCB.CheckedChanged
        If sender.Checked Then
            EEmailQry = "Emp_Email"
        Else
            EEmailQry = ""
        End If
    End Sub

    Private Sub EAddressCB_CheckedChanged(sender As Object, e As EventArgs) Handles EAddressCB.CheckedChanged
        If sender.Checked Then
            EAddressQry = "Emp_Address"
        Else
            EAddressQry = ""
        End If
    End Sub

    Private Sub EUpdateBtn_Click(sender As Object, e As EventArgs) Handles ESelectAllBtn.Click
        If ESelectAllBtn.Text = "Select All" Then
            LoginCB.Checked = True
            PassCB.Checked = True
            UserCB.Checked = True
            EPosCB.Checked = True
            EDOBCB.Checked = True
            EPhoneCB.Checked = True
            EEmailCB.Checked = True
            EAddressCB.Checked = True
            ESelectAllBtn.Text = "Deselect"
            ESelectAllBtn.Image = My.Resources.uncheck_all_30px
        Else
            LoginCB.Checked = False
            PassCB.Checked = False
            UserCB.Checked = False
            EPosCB.Checked = False
            EDOBCB.Checked = False
            EPhoneCB.Checked = False
            EEmailCB.Checked = False
            EAddressCB.Checked = False
            ESelectAllBtn.Text = "Select All"
            ESelectAllBtn.Image = My.Resources.check_all_30px
        End If

    End Sub

    Function EColumnsToString() As String
        Dim ColQry As String = "Employee.Emp_ID, Emp_Name, "
        If EPosCB.Checked Then
            ColQry &= EPosQry & ", "
        End If
        If EDOBCB.Checked Then
            ColQry &= EDOBQry & ", "
        End If
        If EPhoneCB.Checked Then
            ColQry &= EPhoneQry & ", "
        End If
        If EEmailCB.Checked Then
            ColQry &= EEmailQry & ", "
        End If
        If EAddressCB.Checked Then
            ColQry &= EAddressQry & ", "
        End If
        If UserCB.Checked Then
            ColQry &= UserQry & ", "
        End If
        If PassCB.Checked Then
            ColQry &= PassQry & ", "
        End If
        Return ColQry.Substring(0, ColQry.Length - 2)
    End Function

End Class
