Public Class FighterTwo
    Public strName As String
    Dim Op2num1(6) As Integer
    Dim Op2num2(6) As Integer
    Dim Op2num3(6) As Integer
    Dim Op2num4(6) As Integer

    Sub New()
        'Randomly picks 4 out of the 6 character attributes
        Dim rnd As New Random
        Op2num1(0) = FightForm.lblIntOp2.Text
        Op2num1(1) = FightForm.lblStrOp2.Text
        Op2num1(2) = FightForm.lblSpdOp2.Text
        Op2num1(3) = FightForm.lblDurOp2.Text
        Op2num1(4) = FightForm.lblFsOp2.Text
        Op2num1(5) = FightForm.lblEpOp2.Text
        FightForm.Label23.Text = Op2num1(rnd.Next(0, 6))

        Op2num2(0) = FightForm.lblIntOp2.Text
        Op2num2(1) = FightForm.lblStrOp2.Text
        Op2num2(2) = FightForm.lblSpdOp2.Text
        Op2num2(3) = FightForm.lblDurOp2.Text
        Op2num2(4) = FightForm.lblFsOp2.Text
        Op2num2(5) = FightForm.lblEpOp2.Text
        FightForm.Label22.Text = Op2num2(rnd.Next(0, 6))

        Op2num3(0) = FightForm.lblIntOp2.Text
        Op2num3(1) = FightForm.lblStrOp2.Text
        Op2num3(2) = FightForm.lblSpdOp2.Text
        Op2num3(3) = FightForm.lblDurOp2.Text
        Op2num3(4) = FightForm.lblFsOp2.Text
        Op2num3(5) = FightForm.lblEpOp2.Text
        FightForm.Label21.Text = Op2num3(rnd.Next(0, 6))

        Op2num4(0) = FightForm.lblIntOp2.Text
        Op2num4(1) = FightForm.lblStrOp2.Text
        Op2num4(2) = FightForm.lblSpdOp2.Text
        Op2num4(3) = FightForm.lblDurOp2.Text
        Op2num4(4) = FightForm.lblFsOp2.Text
        Op2num4(5) = FightForm.lblEpOp2.Text
        FightForm.Label20.Text = Op2num4(rnd.Next(0, 6))

        'Multiplys the four random attributes and divides the by six then sets the sum to 2 decimal places
        FightForm.lblSum2.Text = FormatNumber((FightForm.Label23.Text * FightForm.Label22.Text * FightForm.Label21.Text * FightForm.Label20.Text) / 6, 2)





    End Sub
  
End Class
