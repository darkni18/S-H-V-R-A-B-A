Imports System.IO
Public Class BattleEventLog

    Dim NewPoint As New System.Drawing.Point
    Dim X, Y As Integer

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

#Region "Form Events"
    Private Sub BattleEventLog_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        ListEvents.Items.Add("----------------------------Loaded Successfully!---------------------------")
        ListEvents.Items.Add("---------------" + Date.Now.ToString("ddd MMMM d yyyy ") + Format(Now, "hh:mm:ss tt") + "--------------")
        ListEvents.Items.Add("-----------------------------------------------------------------------------------------")
    End Sub

    Public Sub AddEvent(ByVal strEvent As String)
        'Adds Events from Battle Analysis to Events Console
        ListEvents.Items.Add(strEvent)
    End Sub
#End Region

#Region "Buttons"
    Private Sub btnSaveEvent_Click(sender As System.Object, e As System.EventArgs) Handles btnSaveEvent.Click
        Dim sfd As New SaveFileDialog
        sfd.Filter = "Text Files (*.txt) |*.txt| Word (*.doc)|*.doc| All Files (*.*)|*.*"
        'Prompt the user for a file name to save to.
        If sfd.ShowDialog() = DialogResult.OK Then
            'Create the file to save to.
            Dim output As New IO.StreamWriter(sfd.FileName)

            'Write lines of text to the file.
            For Each item As Object In ListEvents.Items
                output.WriteLine(ListEvents.GetItemText(item))
            Next item
            'Close the file.
            output.Close()
        End If

    End Sub

    Private Sub btnMaximize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMaximize.Click
        'Maximizes Events Console
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        ElseIf WindowState = FormWindowState.Maximized Then
            WindowState = FormWindowState.Normal
        End If

    End Sub

    Private Sub btnFont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFont.Click
        'This is so the user may change the font in the Battle Events Console
        If FontDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.ListEvents.Font = FontDialog1.Font
            ListEvents.Text = FontDialog1.Font.Name

        End If
    End Sub

    Private Sub FontDialog1_Apply(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontDialog1.Apply
        ListEvents.Text = Me.Font.Name
    End Sub


#End Region

End Class