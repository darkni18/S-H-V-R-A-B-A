Public Class FighterOne
    Public strName As String
    Dim Op1num1(6) As Integer
    Dim Op1num2(6) As Integer
    Dim Op1num3(6) As Integer
    Dim Op1num4(6) As Integer

    Sub New()
        'Randomly picks 4 out of the 6 character attributes
        Dim rnd As New Random
        Op1num1(0) = FightForm.lblintOp1.Text
        Op1num1(1) = FightForm.lblstrOp1.Text
        Op1num1(2) = FightForm.lblspdOp1.Text
        Op1num1(3) = FightForm.lbldurOp1.Text
        Op1num1(4) = FightForm.lblfsOp1.Text
        Op1num1(5) = FightForm.lblepOp1.Text
        FightForm.Label14.Text = Op1num1(rnd.Next(0, 6))

        Op1num2(0) = FightForm.lblintOp1.Text
        Op1num2(1) = FightForm.lblstrOp1.Text
        Op1num2(2) = FightForm.lblspdOp1.Text
        Op1num2(3) = FightForm.lbldurOp1.Text
        Op1num2(4) = FightForm.lblfsOp1.Text
        Op1num2(5) = FightForm.lblepOp1.Text
        FightForm.Label15.Text = Op1num2(rnd.Next(0, 6))

        Op1num3(0) = FightForm.lblintOp1.Text
        Op1num3(1) = FightForm.lblstrOp1.Text
        Op1num3(2) = FightForm.lblspdOp1.Text
        Op1num3(3) = FightForm.lbldurOp1.Text
        Op1num3(4) = FightForm.lblfsOp1.Text
        Op1num3(5) = FightForm.lblepOp1.Text
        FightForm.Label16.Text = Op1num3(rnd.Next(0, 6))

        Op1num4(0) = FightForm.lblintOp1.Text
        Op1num4(1) = FightForm.lblstrOp1.Text
        Op1num4(2) = FightForm.lblspdOp1.Text
        Op1num4(3) = FightForm.lbldurOp1.Text
        Op1num4(4) = FightForm.lblfsOp1.Text
        Op1num4(5) = FightForm.lblepOp1.Text
        FightForm.Label17.Text = Op1num4(rnd.Next(0, 6))

        'Multiplys the four random attributes and divides the by six then sets the sum to 2 decimal places
        FightForm.lblSum.Text = FormatNumber((FightForm.Label14.Text * FightForm.Label15.Text * FightForm.Label16.Text * FightForm.Label17.Text) / 6, 2)
    End Sub

End Class
