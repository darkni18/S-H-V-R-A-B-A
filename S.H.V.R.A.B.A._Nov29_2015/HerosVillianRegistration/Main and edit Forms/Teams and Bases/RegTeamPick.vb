Imports System.Windows.Forms

Public Class RegTeamPick
    Public Property TeamLogo As Image
    Public Property TBImage As Image

#Region "Buttons"
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        ' For TeamLogo Image
        Dim r As DataRowView = TeamsBindingSource.Current
        Dim memoryStream As System.IO.MemoryStream =
            New System.IO.MemoryStream(r("TeamLogo"), False)
        TeamLogo = Image.FromStream(memoryStream)

        ' For Team Base Image
        Dim s As DataRowView = TeamsBindingSource.Current
        Dim memoryStream2 As System.IO.MemoryStream =
            New System.IO.MemoryStream(s("TBImage"), False)
        TBImage = Image.FromStream(memoryStream2)

        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        'Closes form sets Registration2Form team pick to nothing
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        TeamLogo = Nothing
        TBImage = Nothing
        Me.Close()
    End Sub

    Private Sub RegTeamPick_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RegistrationDatabaseDataSet.Teams' table. You can move, or remove it, as needed.
        Me.TeamsTableAdapter.Fill(Me.RegistrationDatabaseDataSet.Teams)
        Me.TeamsBindingSource.MoveFirst()
    End Sub

    Private Sub btnMinimize_Click(sender As System.Object, e As System.EventArgs)
        'minimizes form
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs)
        Me.Close()
    End Sub

#End Region

End Class
