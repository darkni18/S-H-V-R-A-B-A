Imports HerosVillianRegistration.FighterOne
Imports HerosVillianRegistration.FighterTwo
Imports System.IO

Public Class FightForm
    Dim NewPoint As New System.Drawing.Point
    Dim X, Y As Integer
    Private currentOpOne As FighterOne
    Private currentOpTwo As FighterTwo
    Public newLog As New BattleEventLog
    Private logShown As Boolean = True
  
#Region "Form Load events"
    Private Sub FightForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Starts event console
        newLog.Show()

        'Attaches Event Console to Form
        newLog.Location = New Point(Me.Location.X + 603, Me.Location.Y)

    End Sub
#End Region

#Region "Form Movement"
    Private Sub FightForm_Move(sender As Object, e As System.EventArgs) Handles Me.Move
        'So Events console can move with Battle Analyzer Form
        newLog.Location = New Point(Me.Location.X + 603, Me.Location.Y)
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
#End Region

#Region "Minimize and Close Buttons"
    Private Sub btnMinimize_Click(sender As System.Object, e As System.EventArgs) Handles btnMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        newLog.Close()
        Me.Close()
        MainForm2.Show()
    End Sub
#End Region

#Region "Buttons"
    Private Sub btnSelectOp1_Click(sender As System.Object, e As System.EventArgs) Handles btnSelectOp1.Click
        Me.Hide()
        newLog.Hide()
        Dim opone As New SelectedFighter
        opone.ShowDialog()

    End Sub

    Private Sub btnSelectOp2_Click(sender As System.Object, e As System.EventArgs) Handles btnSelectOp2.Click
        Me.Hide()
        newLog.Hide()
        Dim optwo As New SelectFighter2
        optwo.ShowDialog()

    End Sub

    Private Sub btnFight_Click(sender As System.Object, e As System.EventArgs) Handles btnFight.Click

        If Not IsNumeric(txtBattlenum.Text) Or txtBattlenum.Text.Contains(".") Or txtBattlenum.Text.Contains(",") Then
            MsgBox("Can only be a whole Number!")
        End If

        If IsNumeric(txtBattlenum.Text) And Not txtBattlenum.Text.Contains(".") And Not txtBattlenum.Text.Contains(",") Then

            FighteroneTimer.Enabled = True
            FighterTwoTimer.Enabled = True
            TieTimer.Enabled = True
            ProgressTimer.Enabled = True
            lblprogress.Text = "Analyzing"
            FightTime.Enabled = True

        End If
        txtBattlenum.ReadOnly = True
    End Sub


    Private Sub btnReset_Click(sender As System.Object, e As System.EventArgs) Handles btnReset.Click
        newLog.ListEvents.Items.Clear()
        newLog.ListEvents.Items.Add("----------------------------Loaded Successfully!--------------------------------")
        newLog.ListEvents.Items.Add("-----------------" + Date.Now.ToString("ddd MMMM d yyyy ") + Format(Now, "hh:mm:ss tt") + "----------------")
        newLog.ListEvents.Items.Add("-----------------------------------------------------------------------------------------")
        txtBattlenum.ReadOnly = False
        txtBattlenum.Text = 0
        Label14.Text = 0
        Label15.Text = 0
        Label16.Text = 0
        Label17.Text = 0
        lblSum.Text = 0
        lblwinbattledivide1.Text = 0
        lblOp1Wins.Text = 0
        Label23.Text = 0
        Label22.Text = 0
        Label21.Text = 0
        Label20.Text = 0
        lblSum2.Text = 0
        lblWinBattleDivide2.Text = 0
        lblOp2Wins.Text = 0
        lblties.Text = 0
        lblindex.Text = 0
        EventProgressBar.Value = 0
        lblSec.Text = "00"
        lblMin.Text = "00"
        lblHour.Text = "00"

        FighteroneTimer.Enabled = False
        FighterTwoTimer.Enabled = False
        TieTimer.Enabled = False
        ProgressTimer.Enabled = False
        FightTime.Enabled = False
    End Sub

    Private Sub btnEventLog_Click(sender As System.Object, e As System.EventArgs) Handles btnEventLog.Click
        If logShown Then
            newLog.Hide()
            btnEventLog.Text = "Show Log"
            logShown = Not logShown

        Else
            newLog.Show()
            btnEventLog.Text = "Hide Log"
            logShown = Not logShown


        End If
    End Sub

    Private Sub btnStop_Click(sender As System.Object, e As System.EventArgs) Handles btnStop.Click
        FighteroneTimer.Enabled = False
        FighterTwoTimer.Enabled = False
        TieTimer.Enabled = False
        ProgressTimer.Enabled = False
        lblprogress.Text = "Stopped"
        FightTime.Enabled = False
    End Sub

    Private Sub PbOp1_Click(sender As System.Object, e As System.EventArgs) Handles PbOp1.Click
        Me.Hide()
        newLog.Hide()
        Dim opone As New SelectedFighter
        opone.ShowDialog()
    End Sub

    Private Sub pbOp2_Click(sender As System.Object, e As System.EventArgs) Handles pbOp2.Click
        Me.Hide()
        newLog.Hide()
        Dim optwo As New SelectFighter2
        optwo.ShowDialog()
    End Sub

#End Region

#Region " Created Event Function"
    Private Function CreateEvet(ByVal strName As String) As String

        If strName = lblNameOp1.Text Then
            Return strName + "  " + " " + "Won the battle!"

        ElseIf strName = lblNameOp2.Text Then
            Return strName + "  " + " " + "Won the battle!"

        Else
            Return strName

        End If

    End Function
#End Region

#Region "TextBox"
    Private Sub txtBattlenum_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtBattlenum.TextChanged
        Try
            lblindex.Text = txtBattlenum.Text
            lblBattleNumOp1.Text = txtBattlenum.Text
            lblBattleNumOp2.Text = txtBattlenum.Text
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
#End Region

#Region "Timers"
    Private Sub FighteroneTimer_Tick(sender As System.Object, e As System.EventArgs) Handles FighteroneTimer.Tick
        Dim foc As New FighterOne
        foc.ToString()
        Dim a As Single
        Dim b As Single
        a = lblSum.Text
        b = lblSum2.Text
        Dim z As Integer
        z = 1
        If a > b Then
            newLog.AddEvent(CreateEvet(lblNameOp1.Text + "  " + "  " + "Won the battle!" + "-->" + "  " + lblSum.Text + " to " + lblSum2.Text))
            lblindex.Text -= z
            lblOp1Wins.Text += 1
        End If
        lblPercOp1.Text = FormatNumber((lblOp1Wins.Text / lblBattleNumOp1.Text) * 100, 2)


    End Sub

    Private Sub FighterTwoTimer_Tick(sender As System.Object, e As System.EventArgs) Handles FighterTwoTimer.Tick
        Dim foctwo As New FighterTwo
        foctwo.ToString()
        Dim a As Single
        Dim b As Single
        a = lblSum.Text
        b = lblSum2.Text
        Dim z As Integer
        z = 1
        If b > a Then
            newLog.AddEvent(CreateEvet(lblNameOp2.Text + " " + "  " + "Won the battle!" + "-->" + "  " + lblSum2.Text + " to " + lblSum.Text))
            lblindex.Text -= z
            lblOp2Wins.Text += 1
        End If
        lblPercOp2.Text = FormatNumber((lblOp2Wins.Text / lblBattleNumOp2.Text) * 100, 2)

    End Sub

    Private Sub TieTimer_Tick(sender As System.Object, e As System.EventArgs) Handles TieTimer.Tick
        Dim foc As New FighterOne
        foc.ToString()
        Dim foctwo As New FighterTwo
        foctwo.ToString()
        Dim a As Single
        Dim b As Single
        a = lblSum.Text
        b = lblSum2.Text
        Dim z As Integer
        z = 1

        If b = a Or a = b Then
            newLog.AddEvent(CreateEvet("It's a TIE!" + "  " + "  " + lblNameOp1.Text + " " + "  " + lblSum.Text + " " + " to " + "  " + lblNameOp2.Text + " " + "  " + lblSum2.Text))
            lblindex.Text -= z
            lblties.Text += 1

        End If


    End Sub

    Private Sub ProgressTimer_Tick(sender As System.Object, e As System.EventArgs) Handles ProgressTimer.Tick

        EventProgressBar.Maximum = CInt(txtBattlenum.Text)
        If lblindex.Text - 1 Then
            EventProgressBar.Increment(1)

        End If
        If EventProgressBar.Value = EventProgressBar.Maximum Then
            ProgressTimer.Enabled = False
            lblprogress.Text = "Done"
            FightTime.Enabled = False
            newLog.ListEvents.Items.Add("-----------------------------------------------------------------------------------------")
            newLog.ListEvents.Items.Add("Results")
            newLog.ListEvents.Items.Add("Time it took to analyze:" + " " + lblHour.Text + ":" + lblMin.Text + ":" + lblSec.Text)
            newLog.ListEvents.Items.Add("------------")
            newLog.AddEvent(CreateEvet(lblNameOp1.Text + " " + lblPercOp1.Text + "%"))
            newLog.AddEvent(CreateEvet(lblNameOp2.Text + " " + lblPercOp2.Text + "%"))
            newLog.AddEvent(CreateEvet(lblNameOp1.Text + " " + "Won" + " " + lblOp1Wins.Text + " " + "out of" + " " + txtBattlenum.Text + " " + "Battles"))
            newLog.AddEvent(CreateEvet(lblNameOp2.Text + " " + "Won" + " " + lblOp2Wins.Text + " " + "out of" + " " + txtBattlenum.Text + " " + "Battles"))
            newLog.ListEvents.Items.Add("-----------------------------------------------------------------------------------------")
        End If


    End Sub

    Private Sub FightTime_Tick(sender As System.Object, e As System.EventArgs) Handles FightTime.Tick
        Dim a As Integer
        Dim b As Integer
        Dim c As Integer
        Dim z As Integer
        a = lblSec.Text
        b = lblMin.Text
        c = lblHour.Text
        z = 1

        lblSec.Text = a + z
        If lblSec.Text = "60" Then
            lblMin.Text = b + z
            lblSec.Text = "0"
        ElseIf lblMin.Text = "60" Then
            lblHour.Text = c + z
            lblMin.Text = "0"
        End If

    End Sub




#End Region

#Region "Index Label"
    Private Sub lblindex_TextChanged(sender As Object, e As System.EventArgs) Handles lblindex.TextChanged
        If lblindex.Text <= 0 Then
            FighteroneTimer.Enabled = False
            FighterTwoTimer.Enabled = False
            TieTimer.Enabled = False

        End If
    End Sub

#End Region


End Class