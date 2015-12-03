Public Class TeamsForm

#Region "Load Form Events"
    Private Sub TeamsForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'This line of code loads data into the 'RegistrationDatabaseDataSet.BaseOfOperations' table. You can move, or remove it, as needed.
        Me.BaseOfOperationsTableAdapter.Fill(Me.RegistrationDatabaseDataSet.BaseOfOperations)

        'This line of code loads data into the 'RegistrationDatabaseDataSet.Teams' table. You can move, or remove it, as needed.
        Me.TeamsTableAdapter.Fill(Me.RegistrationDatabaseDataSet.Teams)
    End Sub
#End Region

#Region "Buttons"
    Private Sub btnFromCom_Click(sender As System.Object, e As System.EventArgs) Handles btnFromCom.Click
        ' Opens a fildialog to the computers directory to pick an image
        Dim OpenFileDialog1 As New OpenFileDialog
        ' Dialog filter to show only the image types in Picture File
        OpenFileDialog1.Filter = "Picture Files (*)|*.bmp;*.gif;*.jpg;*.png"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            TeamLogoPictureBox.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub btnFromDB_Click(sender As System.Object, e As System.EventArgs) Handles btnFromDB.Click
        'Opens the imageDialog to choose a logo
        Dim si As New ImageDialog
        'Dialog OK result will take image in memorystream and set it as TeamLogo
        If si.ShowDialog = Windows.Forms.DialogResult.OK Then
            TeamLogoPictureBox.Image = si.Img
        End If
    End Sub

    Private Sub btnDel_Click(sender As System.Object, e As System.EventArgs) Handles btnDel.Click
        'Clears Image
        TeamLogoPictureBox.Image = Nothing
    End Sub

    Private Sub btnPickBase_Click(sender As System.Object, e As System.EventArgs) Handles btnPickBase.Click
        'Opens the PickTeamBaseForm
        Dim pbo As New PickTeamBaseForm

        ' OK result set the base you chose to the team you created
        If pbo.ShowDialog = Windows.Forms.DialogResult.OK Then
            TBImagePictureBox.Image = pbo.BaseImage
            TBNameLabel1.Text = pbo.BaseNameLabel1.Text
            TBPlanetLabel1.Text = pbo.PlanetLabel1.Text
            TBCountryLabel1.Text = pbo.CountryLabel1.Text
            TBStateLabel1.Text = pbo.StateLabel1.Text
            TBCityLabel1.Text = pbo.StateLabel1.Text

        End If

    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
        MainForm2.Show()
    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        'Lets you add new database info
        Try
            Me.TeamsBindingSource.AddNew()
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        'Saves data
        Try
            Me.Validate()
            Me.TeamsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.RegistrationDatabaseDataSet)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
        'Removes database info that you are currently on
        Me.TeamsBindingSource.RemoveCurrent()
    End Sub

    Private Sub btnDone1_Click(sender As System.Object, e As System.EventArgs) Handles btnDone1.Click
        'This will save any unsaved changes before closing
        Me.Validate()
        Me.TeamsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.RegistrationDatabaseDataSet)
        Me.Close()
        MainForm2.Show()
    End Sub

    Private Sub btnPrevious2_Click(sender As System.Object, e As System.EventArgs) Handles btnPrevious2.Click
        'Goes to previous record
        Me.TeamsBindingSource.MovePrevious()
    End Sub

    Private Sub btnNext2_Click(sender As System.Object, e As System.EventArgs) Handles btnNext2.Click
        'Goes to next record
        Me.TeamsBindingSource.MoveNext()
    End Sub
#End Region

End Class