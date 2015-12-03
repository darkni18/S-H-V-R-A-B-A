Public Class ImageDatabaseForm

    'for form movement
    Dim NewPoint As New System.Drawing.Point
    Dim X, Y As Integer

#Region "Form Loading and Closing Events"
    Private Sub ImageDatabaseForm_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Validate()
        Me.ImageTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.RegistrationDatabaseDataSet)
    End Sub

    Private Sub ImageDatabaseForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RegistrationDatabaseDataSet.ImageTable' table. You can move, or remove it, as needed.
        Me.ImageTableTableAdapter.Fill(Me.RegistrationDatabaseDataSet.ImageTable)

    End Sub
#End Region

#Region "Image Picture Box Event"
    Private Sub ImgPictureBox_Click(sender As System.Object, e As System.EventArgs) Handles ImgPictureBox.Click
        'Lets you click on Picture Box to open a dialog to set an Image from computer
        Dim OpenFileDialog1 As New OpenFileDialog

        OpenFileDialog1.Filter = "Picture Files (*)|*.bmp;*.gif;*.jpg;*.png"

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            ImgPictureBox.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub
#End Region

#Region "Database Buttons"
    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        Me.ImageTableBindingSource.AddNew()
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Me.Validate()
        Me.ImageTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.RegistrationDatabaseDataSet)
    End Sub

    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
        'Deletes current record
        Me.ImageTableBindingSource.RemoveCurrent()
    End Sub

    Private Sub btnDone1_Click(sender As System.Object, e As System.EventArgs) Handles btnDone1.Click
        'Saves and closes form
        Me.Validate()
        Me.ImageTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.RegistrationDatabaseDataSet)
        MainForm2.Show()
        Me.Close()
    End Sub

    Private Sub btnPrevious2_Click(sender As System.Object, e As System.EventArgs) Handles btnPrevious2.Click
        'Goes to previous record
        Me.ImageTableBindingSource.MovePrevious()
    End Sub

    Private Sub btnNext2_Click(sender As System.Object, e As System.EventArgs) Handles btnNext2.Click
        'Goes to next record
        Me.ImageTableBindingSource.MoveNext()
    End Sub

    Private Sub btnPickImage_Click(sender As System.Object, e As System.EventArgs) Handles btnPickImage.Click
        Dim OpenFileDialog1 As New OpenFileDialog

        OpenFileDialog1.Filter = "Picture Files (*)|*.bmp;*.gif;*.jpg;*.png"

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            ImgPictureBox.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

#End Region

#Region "Form Movment Code"
    Private Sub ImageDatabaseForm_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        'Mouse down event so you are able to move form
        X = Control.MousePosition.X - Me.Location.X
        Y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub ImageDatabaseForm_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        ' Mouse movment so when mouse down is enable you are able to move the form
        If e.Button = Windows.Forms.MouseButtons.Left Then
            NewPoint = Control.MousePosition
            NewPoint.X -= (X)
            NewPoint.Y -= (Y)
            Me.Location = NewPoint
        End If
    End Sub
#End Region

#Region "Minimize and Close Buttons"
    Private Sub btnMinimize_Click(sender As System.Object, e As System.EventArgs) Handles btnMinimize.Click
        'Minimizes form
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        'closes form and opens Mainform
        MainForm2.Show()
        Me.Close()
    End Sub
#End Region


End Class