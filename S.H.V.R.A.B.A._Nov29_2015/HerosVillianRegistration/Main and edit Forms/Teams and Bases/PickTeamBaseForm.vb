Imports System.Windows.Forms

Public Class PickTeamBaseForm

    Public Property BaseImage As Image

#Region "Form Load Events"
    Private Sub PickTeamBaseForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'This line of code loads data into the 'RegistrationDatabaseDataSet.BaseOfOperations' table. You can move, or remove it, as needed.
        Me.BaseOfOperationsTableAdapter.Fill(Me.RegistrationDatabaseDataSet.BaseOfOperations)
        Me.BaseOfOperationsBindingSource.MoveFirst()
    End Sub
#End Region

#Region "Buttons"
    Private Sub OK_Button_Click(sender As System.Object, e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        'Ok results set BaseImage to memorystream
        Dim r As DataRowView = BaseOfOperationsBindingSource.Current
        Dim memoryStream As System.IO.MemoryStream =
            New System.IO.MemoryStream(r("BaseImage"), False)
        BaseImage = Image.FromStream(memoryStream)

        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(sender As System.Object, e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        BaseImage = Nothing
        Me.Close()
    End Sub

#End Region

End Class