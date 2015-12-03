
Public Class CharacterReportForm
    Dim NewPoint As New System.Drawing.Point
    Dim X, Y As Integer
    Private Sub CharacterReportForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RegistrationDatabaseDataSet.Registration' table. You can move, or remove it, as needed.
        Me.RegistrationTableAdapter.Fill(Me.RegistrationDatabaseDataSet.Registration)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        MainForm2.Show()
        Me.Close()
    End Sub

    Private Sub btnMinimize_Click(sender As System.Object, e As System.EventArgs) Handles btnMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

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

    Private Sub btnMaximize_Click(sender As System.Object, e As System.EventArgs) Handles btnMaximize.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        ElseIf WindowState = FormWindowState.Maximized Then
            WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub btnSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnSearch.Click
        Try
            Me.RegistrationTableAdapter.FillBy1(Me.RegistrationDatabaseDataSet.Registration, TextBox1.Text)
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnReset_Click(sender As System.Object, e As System.EventArgs) Handles btnReset.Click
        Try
            Me.RegistrationTableAdapter.Fill(Me.RegistrationDatabaseDataSet.Registration)
            Me.ReportViewer1.RefreshReport()
            TextBox1.Text = Nothing
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

End Class