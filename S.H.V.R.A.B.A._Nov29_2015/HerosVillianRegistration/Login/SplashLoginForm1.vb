
Public Class SplashLoginForm1
    Private userLogin As New UserLoginDataContext

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

   
#Region "Buttons"
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub OK_Click(sender As System.Object, e As System.EventArgs) Handles OK.Click
        'Compares username and password to whats in the database
        Dim Check = From User In userLogin.LoginTables _
                    Where UsernameTextBox.Text = User.Username And PasswordTextBox.Text = User.Password

        'If correct opens form if wrong opens msgFail form
        If Not Check.Count = 0 Then
            Me.Hide()
            MainForm2.Show()
        Else
            msgFail.Show()
            UsernameTextBox.Text = Nothing
            PasswordTextBox.Text = Nothing
        End If
    End Sub
#End Region

#Region "Register Label"
    Private Sub lblRegister_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lblRegister.MouseClick
        RegisterForm.Show()
    End Sub
#End Region

End Class
