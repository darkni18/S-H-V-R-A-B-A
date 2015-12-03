Public Class RegistrationForm2
    'This is for form movment
    Dim NewPoint As New System.Drawing.Point
    Dim X, Y As Integer

#Region "Close and Minimize Buttons "
    Private Sub btnMinimize_Click_1(sender As System.Object, e As System.EventArgs) Handles btnMinimize.Click
        'minimizes form
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnClose_Click_1(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        'closes form and opens Mainform
        MainForm2.Show()
        Me.Close()
    End Sub
#End Region

#Region "Form Movement "
    Private Sub Panel1_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDown
        'Mouse down event so you are able to move form
        X = Control.MousePosition.X - Me.Location.X
        Y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        ' Mouse movment so when mouse down is enable you are able to move the form
        If e.Button = Windows.Forms.MouseButtons.Left Then
            NewPoint = Control.MousePosition
            NewPoint.X -= (X)
            NewPoint.Y -= (Y)
            Me.Location = NewPoint
        End If
    End Sub
#End Region

#Region "Form Load Events "
    Private Sub RegistrationForm_Load(sender As System.Object, e As System.EventArgs)
        'This line of code loads data into the 'RegistrationDatabaseDataSet.Registration' table. You can move, or remove it, as needed.
        Me.RegistrationTableAdapter.Fill(Me.RegistrationDatabaseDataSet.Registration)
    End Sub

    Private Sub RegistrationBindingSource_BindingComplete(sender As Object, e As System.Windows.Forms.BindingCompleteEventArgs) Handles RegistrationBindingSource.BindingComplete
        'This keeps file count
        Label7.Text = RegistrationBindingSource.Count
    End Sub

    Private Sub RegistrationForm2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'This line of code loads data into the 'RegistrationDatabaseDataSet.Teams' table. You can move, or remove it, as needed.
        Me.TeamsTableAdapter.Fill(Me.RegistrationDatabaseDataSet.Teams)
        'This line of code loads data into the 'RegistrationDatabaseDataSet.BaseOfOperations' table. You can move, or remove it, as needed.
        Me.BaseOfOperationsTableAdapter.Fill(Me.RegistrationDatabaseDataSet.BaseOfOperations)
        'This line of code loads data into the 'RegistrationDatabaseDataSet.BaseOfOperations' table. You can move, or remove it, as needed.
        Me.BaseOfOperationsTableAdapter.Fill(Me.RegistrationDatabaseDataSet.BaseOfOperations)
        ' This line of code loads data into the 'RegistrationDatabaseDataSet.Teams' table. You can move, or remove it, as needed.
        Me.TeamsTableAdapter.Fill(Me.RegistrationDatabaseDataSet.Teams)
        ' This line of code loads data into the 'RegistrationDatabaseDataSet.Registration' table. You can move, or remove it, as needed.
        Me.RegistrationTableAdapter.Fill(Me.RegistrationDatabaseDataSet.Registration)

    End Sub

#End Region

#Region "Buttons "
    Private Sub btnAdd_Click_1(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        'This lets you add a new character
        Try
            Me.RegistrationBindingSource.AddNew()
        Catch ex As System.Exception
            'Error Handler
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        'Resets TrackBars and Labeles to 0 When Adding
        IntelligenceTrackBar.Value = 0
        StrengthTrackBar.Value = 0
        SpeedTrackBar.Value = 0
        DurabilityTrackBar.Value = 0
        FightingSkillTrackBar.Value = 0
        EnergyProjectionTrackBar.Value = 0
        lblIntel.Text = IntelligenceTrackBar.Value
        lblStr.Text = StrengthTrackBar.Value
        lblSpe.Text = SpeedTrackBar.Value
        lblDur.Text = DurabilityTrackBar.Value
        lblFS.Text = FightingSkillTrackBar.Value
        lblEP.Text = EnergyProjectionTrackBar.Value
    End Sub

    Private Sub btnSave_Click_1(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        'This saves your unsaved charater and details
        Try
            Me.Validate()
            Me.RegistrationBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.RegistrationDatabaseDataSet)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnDelete_Click_1(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
        'Delets record
        Me.RegistrationBindingSource.RemoveCurrent()
    End Sub

    Private Sub btnPrevious2_Click_1(sender As System.Object, e As System.EventArgs) Handles btnPrevious2.Click
        'Lets you go to previous record
        Me.RegistrationBindingSource.MovePrevious()
    End Sub

    Private Sub btnNext2_Click_1(sender As System.Object, e As System.EventArgs) Handles btnNext2.Click
        'Lets you go to next record
        Me.RegistrationBindingSource.MoveNext()
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        ' Code to add a picture from the computer to Character image picture box
        Dim OpenFileDialog1 As New OpenFileDialog

        OpenFileDialog1.Filter = "Picture Files (*)|*.bmp;*.gif;*.jpg;*.png"

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            ImagePictureBox.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        'This will delete the image in the charater picture box
        ImagePictureBox.Image = Nothing
    End Sub

    Private Sub btnDone1_Click(sender As System.Object, e As System.EventArgs) Handles btnDone1.Click
        ' This will save any unsaved records and close Registration form and open Main Form
        Me.Validate()
        Me.RegistrationBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.RegistrationDatabaseDataSet)
        Me.RegistrationBindingSource.ResetBindings(True)
        MainForm2.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        ' Lets you add and image to the charater image picture box from the Image Database

        Dim si As New ImageDialog

        If si.ShowDialog = Windows.Forms.DialogResult.OK Then
            ImagePictureBox.Image = si.Img
        End If
    End Sub

    Private Sub btnTeam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTeam.Click

        ' This will let you open a dialog box to pick a team that has already been created and stored in the database
        Dim rpt As New RegTeamPick
        If rpt.ShowDialog = Windows.Forms.DialogResult.OK Then
            TmLogoPictureBox.Image = rpt.TeamLogo
            TmNameLabel1.Text = rpt.TeamNameLabel1.Text

            BaseImagePictureBox.Image = rpt.TBImage
            BaseNameLabel1.Text = rpt.TBNameLabel1.Text
            BasePlanetLabel1.Text = rpt.TBPlanetLabel1.Text
            BaseCountryLabel1.Text = rpt.TBCountryLabel1.Text
            BaseStateLabel1.Text = rpt.TBStateLabel1.Text
            BaseCityLabel1.Text = rpt.TBCityLabel1.Text
        End If
    End Sub

#End Region

#Region "Search"
    Private Sub btnSearch_Click_1(sender As System.Object, e As System.EventArgs) Handles btnSearch.Click
        'This will let you search records by charater name
        Try
            Me.RegistrationTableAdapter.FillBy1(Me.RegistrationDatabaseDataSet.Registration, TextBox1.Text)
        Catch ex As System.Exception
            'Error Handler
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        'This will alow you to press enter to do a search
        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
                Me.RegistrationTableAdapter.FillBy1(Me.RegistrationDatabaseDataSet.Registration, TextBox1.Text)

            End If
        Catch ex As System.Exception
            'Error Handler
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "Trackbar Events "
    Private Sub RegistrationDataGridView_SelectionChanged(sender As Object, e As System.EventArgs) Handles RegistrationDataGridView.SelectionChanged
        lblIntel.Text = IntelligenceTrackBar.Value
        lblStr.Text = StrengthTrackBar.Value
        lblSpe.Text = SpeedTrackBar.Value
        lblDur.Text = DurabilityTrackBar.Value
        lblFS.Text = FightingSkillTrackBar.Value
        lblEP.Text = EnergyProjectionTrackBar.Value
    End Sub

    Private Sub IntelligenceTrackBar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IntelligenceTrackBar.Scroll
        lblIntel.Text = IntelligenceTrackBar.Value
    End Sub

    Private Sub StrengthTrackBar_Scroll(sender As System.Object, e As System.EventArgs) Handles StrengthTrackBar.Scroll
        lblStr.Text = StrengthTrackBar.Value
    End Sub

    Private Sub SpeedTrackBar_Scroll(sender As System.Object, e As System.EventArgs) Handles SpeedTrackBar.Scroll
        lblSpe.Text = SpeedTrackBar.Value
    End Sub

    Private Sub DurabilityTrackBar_Scroll(sender As System.Object, e As System.EventArgs) Handles DurabilityTrackBar.Scroll
        lblDur.Text = DurabilityTrackBar.Value
    End Sub

    Private Sub FightingSkillTrackBar_Scroll(sender As System.Object, e As System.EventArgs) Handles FightingSkillTrackBar.Scroll
        lblFS.Text = FightingSkillTrackBar.Value
    End Sub

    Private Sub EnergyProjectionTrackBar_Scroll(sender As System.Object, e As System.EventArgs) Handles EnergyProjectionTrackBar.Scroll
        lblEP.Text = EnergyProjectionTrackBar.Value
    End Sub

    Private Sub btnRandomize_Click(sender As System.Object, e As System.EventArgs) Handles btnRandomize.Click
        Dim rnd As New Random
        Dim rndIntel As Integer = rnd.Next(1, 8)
        Dim rndStr As Integer = rnd.Next(1, 8)
        Dim rndSpd As Integer = rnd.Next(1, 8)
        Dim rndDur As Integer = rnd.Next(1, 8)
        Dim rndFs As Integer = rnd.Next(1, 8)
        Dim rndEp As Integer = rnd.Next(1, 8)


        IntelligenceTrackBar.Value = rndIntel
        StrengthTrackBar.Value = rndStr
        SpeedTrackBar.Value = rndSpd
        DurabilityTrackBar.Value = rndDur
        FightingSkillTrackBar.Value = rndFs
        EnergyProjectionTrackBar.Value = rndEp

        lblIntel.Text = IntelligenceTrackBar.Value
        lblStr.Text = StrengthTrackBar.Value
        lblSpe.Text = SpeedTrackBar.Value
        lblDur.Text = DurabilityTrackBar.Value
        lblFS.Text = FightingSkillTrackBar.Value
        lblEP.Text = EnergyProjectionTrackBar.Value
    End Sub
#End Region



End Class