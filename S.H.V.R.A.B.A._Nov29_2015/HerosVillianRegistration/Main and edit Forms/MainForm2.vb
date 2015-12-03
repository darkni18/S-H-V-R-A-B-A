Imports System.IO

Public Class MainForm2
    'For form movement
    Dim NewPoint As New System.Drawing.Point
    Dim X, Y As Integer

#Region "Code for the Form movement"
    Private Sub Panel1_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDown
        X = Control.MousePosition.X - Me.Location.X
        Y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            NewPoint = Control.MousePosition
            NewPoint.X -= (X)
            NewPoint.Y -= (Y)
            Me.Location = NewPoint
        End If
    End Sub
#End Region

#Region "Minimize and Close Buttons"
    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        SplashLoginForm1.Close()
        Me.Close()
    End Sub

    Private Sub btnMinimize_Click(sender As System.Object, e As System.EventArgs) Handles btnMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        SplashLoginForm1.Close()
        Me.Close()
    End Sub
#End Region

#Region "Menu Items "
    Private Sub NewRegistryToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NewRegistryToolStripMenuItem.Click
        Close()
        Dim rf2 As New RegistrationForm2
        rf2.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutForm.ShowDialog()
    End Sub

    Private Sub TestToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TestToolStripMenuItem.Click
        ' This Analyz button opens the FightForm Analysis
        Me.Hide()

        Dim ff As New FightForm
        ff.ShowDialog()

    End Sub

    Private Sub ImageDatabaseToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ImageDatabaseToolStripMenuItem.Click
        Me.Hide()
        Dim idf As New ImageDatabaseForm
        idf.Show()
    End Sub

    Private Sub CharacterToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CharacterToolStripMenuItem.Click
        Me.Hide()
        CharacterReportForm.Show()
    End Sub

    Private Sub BaseOfOperationsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BaseOfOperationsToolStripMenuItem.Click
        Me.Hide()
        Dim bops As New BasesForm
        bops.ShowDialog()
    End Sub

    Private Sub TeamsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TeamsToolStripMenuItem.Click
        Me.Hide()
        Dim ts As New TeamsForm
        ts.ShowDialog()
    End Sub

    Private Sub TeamsToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles TeamsToolStripMenuItem1.Click
        Me.Hide()
        TeamReportForm.Show()
    End Sub


#End Region

#Region "Form Load Event "
    Private Sub MainForm2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RegistrationDatabaseDataSet.Registration' table. You can move, or remove it, as needed.
        Me.RegistrationTableAdapter.Fill(Me.RegistrationDatabaseDataSet.Registration)
        Me.RegistrationBindingSource.ResetBindings(True)

    End Sub







#End Region

#Region "Buttons "
    Private Sub btnSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnSearch.Click
        'This will allow you to search by Name in the txtboxSearch2
        Try
            Me.RegistrationBindingSource.ResetBindings(True)
            Me.RegistrationTableAdapter.FillBy1(Me.RegistrationDatabaseDataSet.Registration, tbseach2.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnPrevious_Click(sender As System.Object, e As System.EventArgs) Handles btnPrevious.Click
        Me.RegistrationBindingSource.MovePrevious()
    End Sub

    Private Sub btnNext_Click(sender As System.Object, e As System.EventArgs) Handles btnNext.Click
        Me.RegistrationBindingSource.MoveNext()
    End Sub



#End Region

End Class