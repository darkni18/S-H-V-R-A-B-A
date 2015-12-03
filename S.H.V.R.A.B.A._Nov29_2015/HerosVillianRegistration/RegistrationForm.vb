Public Class RegistrationForm

    Private Sub RegistrationBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.RegistrationBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.RegistrationDatabaseDataSet)

    End Sub

    Private Sub RegistrationForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RegistrationDatabaseDataSet.Registration' table. You can move, or remove it, as needed.
        Me.RegistrationTableAdapter.Fill(Me.RegistrationDatabaseDataSet.Registration)

    End Sub

    Private Sub IntelligenceTrackBar_Scroll(sender As System.Object, e As System.EventArgs) Handles IntelligenceTrackBar.Scroll
        Label1.Text = IntelligenceTrackBar.Value
    End Sub

    Private Sub StrengthTrackBar_Scroll(sender As System.Object, e As System.EventArgs) Handles StrengthTrackBar.Scroll
        Label2.Text = StrengthTrackBar.Value
    End Sub

    Private Sub SpeedTrackBar_Scroll(sender As System.Object, e As System.EventArgs) Handles SpeedTrackBar.Scroll
        Label3.Text = SpeedTrackBar.Value
    End Sub

    Private Sub DurabilityTrackBar_Scroll(sender As System.Object, e As System.EventArgs) Handles DurabilityTrackBar.Scroll
        Label4.Text = DurabilityTrackBar.Value
    End Sub

    Private Sub FightingSkillTrackBar_Scroll(sender As System.Object, e As System.EventArgs) Handles FightingSkillTrackBar.Scroll
        Label5.Text = FightingSkillTrackBar.Value
    End Sub

    Private Sub EnergyProjectionTrackBar_Scroll(sender As System.Object, e As System.EventArgs) Handles EnergyProjectionTrackBar.Scroll
        Label6.Text = EnergyProjectionTrackBar.Value
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim OpenFileDialog1 As New OpenFileDialog

        OpenFileDialog1.Filter = "Picture Files (*)|*.bmp;*.gif;*.jpg"

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            ImagePictureBox.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        ImagePictureBox.Image = Nothing

    End Sub


  

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        Me.RegistrationBindingSource.AddNew()

    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Me.Validate()
        Me.RegistrationBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.RegistrationDatabaseDataSet)
    End Sub

    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
        Me.RegistrationBindingSource.RemoveCurrent()

    End Sub

    Private Sub btnSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnSearch.Click
        Try
            Me.RegistrationTableAdapter.FillBy1(Me.RegistrationDatabaseDataSet.Registration, TextBox1.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

End Class