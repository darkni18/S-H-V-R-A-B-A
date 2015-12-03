Public Class BasesForm

#Region "Form Load Events"
    Private Sub BasesForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RegistrationDatabaseDataSet.BaseOfOperations' table. You can move, or remove it, as needed.
        Me.BaseOfOperationsTableAdapter.Fill(Me.RegistrationDatabaseDataSet.BaseOfOperations)

    End Sub
#End Region

#Region "Buttons"
    Private Sub btnFomCom_Click(sender As System.Object, e As System.EventArgs) Handles btnFomCom.Click
        Dim OpenFileDialog1 As New OpenFileDialog

        OpenFileDialog1.Filter = "Picture Files (*)|*.bmp;*.gif;*.jpg;*.png"

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            BaseImagePictureBox.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub btnFromDB_Click(sender As System.Object, e As System.EventArgs) Handles btnFromDB.Click
        Dim si As New ImageDialog

        If si.ShowDialog = Windows.Forms.DialogResult.OK Then
            BaseImagePictureBox.Image = si.Img
        End If
    End Sub

    Private Sub btnDel_Click(sender As System.Object, e As System.EventArgs) Handles btnDel.Click
        BaseImagePictureBox.Image = Nothing
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
        MainForm2.Show()
    End Sub

    Private Sub btnMinimize_Click(sender As System.Object, e As System.EventArgs) Handles btnMinimize.Click
        'minimizes form
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        Try
            Me.BaseOfOperationsBindingSource.AddNew()
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Me.Validate()
        Me.BaseOfOperationsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.RegistrationDatabaseDataSet)
    End Sub

    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
        Me.BaseOfOperationsBindingSource.RemoveCurrent()
    End Sub

    Private Sub btnDone1_Click(sender As System.Object, e As System.EventArgs) Handles btnDone1.Click
        Me.Validate()
        Me.BaseOfOperationsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.RegistrationDatabaseDataSet)
        Me.Close()
        MainForm2.Show()
    End Sub

    Private Sub btnPrevious2_Click(sender As System.Object, e As System.EventArgs) Handles btnPrevious2.Click
        Me.BaseOfOperationsBindingSource.MovePrevious()
    End Sub

    Private Sub btnNext2_Click(sender As System.Object, e As System.EventArgs) Handles btnNext2.Click
        Me.BaseOfOperationsBindingSource.MoveNext()
    End Sub

#End Region

End Class