Imports System.IO
Public Class SelectedFighter

    Dim NewPoint As New System.Drawing.Point
    Dim X, Y As Integer

#Region "Formload Events"
    Private Sub SelectedFighter_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ' This line of code loads data into the 'RegistrationDatabaseDataSet.Registration' table. You can move, or remove it, as needed.
        Me.RegistrationTableAdapter.Fill(Me.RegistrationDatabaseDataSet.Registration)
    End Sub
#End Region

#Region "Buttons"
    Private Sub btnSelect_Click(sender As System.Object, e As System.EventArgs) Handles btnSelect.Click
        'Sets text and image to Fight form text and image
        FightForm.lblintOp1.Text = IntelligenceLabel2.Text
        FightForm.lblstrOp1.Text = StrengthLabel2.Text
        FightForm.lblspdOp1.Text = SpeedLabel2.Text
        FightForm.lbldurOp1.Text = DurabilityLabel2.Text
        FightForm.lblfsOp1.Text = FightingSkillLabel2.Text
        FightForm.lblepOp1.Text = EnergyProjectionLabel2.Text
        FightForm.lblNameOp1.Text = NameLabel1.Text
        FightForm.PbOp1.Image = ImgBox.Image
        Close()
        FightForm.Show()
        FightForm.newLog.Show()
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Close()
        FightForm.Show()
        FightForm.newLog.Show()
    End Sub

    Private Sub btnMinimize_Click(sender As System.Object, e As System.EventArgs) Handles btnMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub
#End Region

#Region "Form Movement"
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

End Class