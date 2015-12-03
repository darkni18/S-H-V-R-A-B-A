Imports System.Windows.Forms

Public Class ImageDialog

    'To set image for memory stream event
    Public Property Img As Image


#Region "Buttons "
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        'Sets the image to memory stream so it loads in the Character Image on the Registration form
        Me.DialogResult = System.Windows.Forms.DialogResult.OK

        Dim r As DataRowView = ImageTableBindingSource.Current
        Dim memoryStream As System.IO.MemoryStream =
            New System.IO.MemoryStream(r("Img"), False)
        Img = Image.FromStream(memoryStream)
        Me.Close()

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Img = Nothing
        Me.Close()

    End Sub

#End Region

#Region "Form Load Event "
    Private Sub ImageDialog_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RegistrationDatabaseDataSet.ImageTable' table. You can move, or remove it, as needed.
        Me.ImageTableTableAdapter.Fill(Me.RegistrationDatabaseDataSet.ImageTable)
        Me.ImageTableBindingSource.MoveFirst()

    End Sub

#End Region

    
End Class
