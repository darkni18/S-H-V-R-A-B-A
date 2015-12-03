<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FightForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FightForm))
        Me.lblNameOp1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblNameOp2 = New System.Windows.Forms.Label()
        Me.lblepOp1 = New System.Windows.Forms.Label()
        Me.lblfsOp1 = New System.Windows.Forms.Label()
        Me.lbldurOp1 = New System.Windows.Forms.Label()
        Me.lblspdOp1 = New System.Windows.Forms.Label()
        Me.lblstrOp1 = New System.Windows.Forms.Label()
        Me.lblintOp1 = New System.Windows.Forms.Label()
        Me.btnSelectOp1 = New System.Windows.Forms.Button()
        Me.lblEpOp2 = New System.Windows.Forms.Label()
        Me.lblFsOp2 = New System.Windows.Forms.Label()
        Me.lblDurOp2 = New System.Windows.Forms.Label()
        Me.lblSpdOp2 = New System.Windows.Forms.Label()
        Me.lblStrOp2 = New System.Windows.Forms.Label()
        Me.lblIntOp2 = New System.Windows.Forms.Label()
        Me.btnSelectOp2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnFight = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblSum = New System.Windows.Forms.Label()
        Me.lblSum2 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.lblOp1Wins = New System.Windows.Forms.Label()
        Me.lblwinbattledivide1 = New System.Windows.Forms.Label()
        Me.lblBattleNumOp1 = New System.Windows.Forms.Label()
        Me.lblOp2Wins = New System.Windows.Forms.Label()
        Me.lblWinBattleDivide2 = New System.Windows.Forms.Label()
        Me.lblBattleNumOp2 = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.lblPercOp1 = New System.Windows.Forms.Label()
        Me.lblPercOp2 = New System.Windows.Forms.Label()
        Me.txtBattlenum = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.lblties = New System.Windows.Forms.Label()
        Me.lblindex = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnEventLog = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.pbOp2 = New System.Windows.Forms.PictureBox()
        Me.PbOp1 = New System.Windows.Forms.PictureBox()
        Me.FighteroneTimer = New System.Windows.Forms.Timer(Me.components)
        Me.FighterTwoTimer = New System.Windows.Forms.Timer(Me.components)
        Me.TieTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressTimer = New System.Windows.Forms.Timer(Me.components)
        Me.EventProgressBar = New System.Windows.Forms.ProgressBar()
        Me.lblprogress = New System.Windows.Forms.Label()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.lblHour = New System.Windows.Forms.Label()
        Me.lblMin = New System.Windows.Forms.Label()
        Me.lblSec = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.FightTime = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.pbOp2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbOp1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNameOp1
        '
        Me.lblNameOp1.AutoSize = True
        Me.lblNameOp1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameOp1.Location = New System.Drawing.Point(40, 72)
        Me.lblNameOp1.Name = "lblNameOp1"
        Me.lblNameOp1.Size = New System.Drawing.Size(55, 20)
        Me.lblNameOp1.TabIndex = 0
        Me.lblNameOp1.Text = "Name"
        Me.lblNameOp1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 216)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Intellegence"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 240)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Strength"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 264)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Speed"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 288)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Durability"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 312)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Fighting Skill"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 336)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Energy Projection"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(456, 336)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Energy Projection"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(456, 312)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 13)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Fighting Skill"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(456, 288)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 13)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Durability"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(456, 264)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(38, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Speed"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(456, 240)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(47, 13)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Strength"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(456, 216)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(65, 13)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "Intellegence"
        '
        'lblNameOp2
        '
        Me.lblNameOp2.AutoSize = True
        Me.lblNameOp2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameOp2.Location = New System.Drawing.Point(480, 72)
        Me.lblNameOp2.Name = "lblNameOp2"
        Me.lblNameOp2.Size = New System.Drawing.Size(55, 20)
        Me.lblNameOp2.TabIndex = 7
        Me.lblNameOp2.Text = "Name"
        Me.lblNameOp2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblepOp1
        '
        Me.lblepOp1.AutoSize = True
        Me.lblepOp1.Location = New System.Drawing.Point(112, 336)
        Me.lblepOp1.Name = "lblepOp1"
        Me.lblepOp1.Size = New System.Drawing.Size(13, 13)
        Me.lblepOp1.TabIndex = 21
        Me.lblepOp1.Text = "0"
        '
        'lblfsOp1
        '
        Me.lblfsOp1.AutoSize = True
        Me.lblfsOp1.Location = New System.Drawing.Point(112, 312)
        Me.lblfsOp1.Name = "lblfsOp1"
        Me.lblfsOp1.Size = New System.Drawing.Size(13, 13)
        Me.lblfsOp1.TabIndex = 20
        Me.lblfsOp1.Text = "0"
        '
        'lbldurOp1
        '
        Me.lbldurOp1.AutoSize = True
        Me.lbldurOp1.Location = New System.Drawing.Point(112, 288)
        Me.lbldurOp1.Name = "lbldurOp1"
        Me.lbldurOp1.Size = New System.Drawing.Size(13, 13)
        Me.lbldurOp1.TabIndex = 19
        Me.lbldurOp1.Text = "0"
        '
        'lblspdOp1
        '
        Me.lblspdOp1.AutoSize = True
        Me.lblspdOp1.Location = New System.Drawing.Point(112, 264)
        Me.lblspdOp1.Name = "lblspdOp1"
        Me.lblspdOp1.Size = New System.Drawing.Size(13, 13)
        Me.lblspdOp1.TabIndex = 18
        Me.lblspdOp1.Text = "0"
        '
        'lblstrOp1
        '
        Me.lblstrOp1.AutoSize = True
        Me.lblstrOp1.Location = New System.Drawing.Point(112, 240)
        Me.lblstrOp1.Name = "lblstrOp1"
        Me.lblstrOp1.Size = New System.Drawing.Size(13, 13)
        Me.lblstrOp1.TabIndex = 17
        Me.lblstrOp1.Text = "0"
        '
        'lblintOp1
        '
        Me.lblintOp1.AutoSize = True
        Me.lblintOp1.Location = New System.Drawing.Point(112, 216)
        Me.lblintOp1.Name = "lblintOp1"
        Me.lblintOp1.Size = New System.Drawing.Size(13, 13)
        Me.lblintOp1.TabIndex = 16
        Me.lblintOp1.Text = "0"
        '
        'btnSelectOp1
        '
        Me.btnSelectOp1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelectOp1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectOp1.Location = New System.Drawing.Point(16, 360)
        Me.btnSelectOp1.Name = "btnSelectOp1"
        Me.btnSelectOp1.Size = New System.Drawing.Size(109, 34)
        Me.btnSelectOp1.TabIndex = 22
        Me.btnSelectOp1.Text = "Select Fighter"
        Me.btnSelectOp1.UseVisualStyleBackColor = True
        '
        'lblEpOp2
        '
        Me.lblEpOp2.AutoSize = True
        Me.lblEpOp2.Location = New System.Drawing.Point(560, 336)
        Me.lblEpOp2.Name = "lblEpOp2"
        Me.lblEpOp2.Size = New System.Drawing.Size(13, 13)
        Me.lblEpOp2.TabIndex = 29
        Me.lblEpOp2.Text = "0"
        '
        'lblFsOp2
        '
        Me.lblFsOp2.AutoSize = True
        Me.lblFsOp2.Location = New System.Drawing.Point(560, 312)
        Me.lblFsOp2.Name = "lblFsOp2"
        Me.lblFsOp2.Size = New System.Drawing.Size(13, 13)
        Me.lblFsOp2.TabIndex = 28
        Me.lblFsOp2.Text = "0"
        '
        'lblDurOp2
        '
        Me.lblDurOp2.AutoSize = True
        Me.lblDurOp2.Location = New System.Drawing.Point(560, 288)
        Me.lblDurOp2.Name = "lblDurOp2"
        Me.lblDurOp2.Size = New System.Drawing.Size(13, 13)
        Me.lblDurOp2.TabIndex = 27
        Me.lblDurOp2.Text = "0"
        '
        'lblSpdOp2
        '
        Me.lblSpdOp2.AutoSize = True
        Me.lblSpdOp2.Location = New System.Drawing.Point(560, 264)
        Me.lblSpdOp2.Name = "lblSpdOp2"
        Me.lblSpdOp2.Size = New System.Drawing.Size(13, 13)
        Me.lblSpdOp2.TabIndex = 26
        Me.lblSpdOp2.Text = "0"
        '
        'lblStrOp2
        '
        Me.lblStrOp2.AutoSize = True
        Me.lblStrOp2.Location = New System.Drawing.Point(560, 240)
        Me.lblStrOp2.Name = "lblStrOp2"
        Me.lblStrOp2.Size = New System.Drawing.Size(13, 13)
        Me.lblStrOp2.TabIndex = 25
        Me.lblStrOp2.Text = "0"
        '
        'lblIntOp2
        '
        Me.lblIntOp2.AutoSize = True
        Me.lblIntOp2.Location = New System.Drawing.Point(560, 216)
        Me.lblIntOp2.Name = "lblIntOp2"
        Me.lblIntOp2.Size = New System.Drawing.Size(13, 13)
        Me.lblIntOp2.TabIndex = 24
        Me.lblIntOp2.Text = "0"
        '
        'btnSelectOp2
        '
        Me.btnSelectOp2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelectOp2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectOp2.Location = New System.Drawing.Point(459, 360)
        Me.btnSelectOp2.Name = "btnSelectOp2"
        Me.btnSelectOp2.Size = New System.Drawing.Size(109, 34)
        Me.btnSelectOp2.TabIndex = 30
        Me.btnSelectOp2.Text = "Select Fighter"
        Me.btnSelectOp2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(272, 152)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 25)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "V.S."
        '
        'btnFight
        '
        Me.btnFight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFight.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFight.Location = New System.Drawing.Point(240, 288)
        Me.btnFight.Name = "btnFight"
        Me.btnFight.Size = New System.Drawing.Size(112, 47)
        Me.btnFight.TabIndex = 32
        Me.btnFight.Text = "Analyze Fight"
        Me.btnFight.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(16, 32)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(13, 13)
        Me.Label14.TabIndex = 33
        Me.Label14.Text = "0"
        Me.Label14.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(37, 32)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(13, 13)
        Me.Label15.TabIndex = 34
        Me.Label15.Text = "0"
        Me.Label15.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(58, 32)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(13, 13)
        Me.Label16.TabIndex = 35
        Me.Label16.Text = "0"
        Me.Label16.Visible = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(72, 32)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(13, 13)
        Me.Label17.TabIndex = 36
        Me.Label17.Text = "0"
        Me.Label17.Visible = False
        '
        'lblSum
        '
        Me.lblSum.AutoSize = True
        Me.lblSum.Location = New System.Drawing.Point(16, 48)
        Me.lblSum.Name = "lblSum"
        Me.lblSum.Size = New System.Drawing.Size(13, 13)
        Me.lblSum.TabIndex = 37
        Me.lblSum.Text = "0"
        Me.lblSum.Visible = False
        '
        'lblSum2
        '
        Me.lblSum2.AutoSize = True
        Me.lblSum2.Location = New System.Drawing.Point(456, 48)
        Me.lblSum2.Name = "lblSum2"
        Me.lblSum2.Size = New System.Drawing.Size(13, 13)
        Me.lblSum2.TabIndex = 42
        Me.lblSum2.Text = "0"
        Me.lblSum2.Visible = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(519, 32)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(13, 13)
        Me.Label20.TabIndex = 41
        Me.Label20.Text = "0"
        Me.Label20.Visible = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(498, 32)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(13, 13)
        Me.Label21.TabIndex = 40
        Me.Label21.Text = "0"
        Me.Label21.Visible = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(477, 32)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(13, 13)
        Me.Label22.TabIndex = 39
        Me.Label22.Text = "0"
        Me.Label22.Visible = False
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(456, 32)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(13, 13)
        Me.Label23.TabIndex = 38
        Me.Label23.Text = "0"
        Me.Label23.Visible = False
        '
        'lblOp1Wins
        '
        Me.lblOp1Wins.AutoSize = True
        Me.lblOp1Wins.Location = New System.Drawing.Point(32, 48)
        Me.lblOp1Wins.Name = "lblOp1Wins"
        Me.lblOp1Wins.Size = New System.Drawing.Size(13, 13)
        Me.lblOp1Wins.TabIndex = 111
        Me.lblOp1Wins.Text = "0"
        Me.lblOp1Wins.Visible = False
        '
        'lblwinbattledivide1
        '
        Me.lblwinbattledivide1.AutoSize = True
        Me.lblwinbattledivide1.Location = New System.Drawing.Point(72, 48)
        Me.lblwinbattledivide1.Name = "lblwinbattledivide1"
        Me.lblwinbattledivide1.Size = New System.Drawing.Size(13, 13)
        Me.lblwinbattledivide1.TabIndex = 112
        Me.lblwinbattledivide1.Text = "0"
        Me.lblwinbattledivide1.Visible = False
        '
        'lblBattleNumOp1
        '
        Me.lblBattleNumOp1.AutoSize = True
        Me.lblBattleNumOp1.Location = New System.Drawing.Point(88, 48)
        Me.lblBattleNumOp1.Name = "lblBattleNumOp1"
        Me.lblBattleNumOp1.Size = New System.Drawing.Size(13, 13)
        Me.lblBattleNumOp1.TabIndex = 113
        Me.lblBattleNumOp1.Text = "0"
        Me.lblBattleNumOp1.Visible = False
        '
        'lblOp2Wins
        '
        Me.lblOp2Wins.AutoSize = True
        Me.lblOp2Wins.Location = New System.Drawing.Point(472, 48)
        Me.lblOp2Wins.Name = "lblOp2Wins"
        Me.lblOp2Wins.Size = New System.Drawing.Size(13, 13)
        Me.lblOp2Wins.TabIndex = 114
        Me.lblOp2Wins.Text = "0"
        Me.lblOp2Wins.Visible = False
        '
        'lblWinBattleDivide2
        '
        Me.lblWinBattleDivide2.AutoSize = True
        Me.lblWinBattleDivide2.Location = New System.Drawing.Point(520, 48)
        Me.lblWinBattleDivide2.Name = "lblWinBattleDivide2"
        Me.lblWinBattleDivide2.Size = New System.Drawing.Size(13, 13)
        Me.lblWinBattleDivide2.TabIndex = 115
        Me.lblWinBattleDivide2.Text = "0"
        Me.lblWinBattleDivide2.Visible = False
        '
        'lblBattleNumOp2
        '
        Me.lblBattleNumOp2.AutoSize = True
        Me.lblBattleNumOp2.Location = New System.Drawing.Point(536, 48)
        Me.lblBattleNumOp2.Name = "lblBattleNumOp2"
        Me.lblBattleNumOp2.Size = New System.Drawing.Size(13, 13)
        Me.lblBattleNumOp2.TabIndex = 116
        Me.lblBattleNumOp2.Text = "0"
        Me.lblBattleNumOp2.Visible = False
        '
        'btnReset
        '
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(300, 341)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(64, 30)
        Me.btnReset.TabIndex = 117
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'lblPercOp1
        '
        Me.lblPercOp1.AutoSize = True
        Me.lblPercOp1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPercOp1.Location = New System.Drawing.Point(136, 136)
        Me.lblPercOp1.Name = "lblPercOp1"
        Me.lblPercOp1.Size = New System.Drawing.Size(21, 24)
        Me.lblPercOp1.TabIndex = 118
        Me.lblPercOp1.Text = "0"
        '
        'lblPercOp2
        '
        Me.lblPercOp2.AutoSize = True
        Me.lblPercOp2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPercOp2.Location = New System.Drawing.Point(368, 136)
        Me.lblPercOp2.Name = "lblPercOp2"
        Me.lblPercOp2.Size = New System.Drawing.Size(21, 24)
        Me.lblPercOp2.TabIndex = 119
        Me.lblPercOp2.Text = "0"
        '
        'txtBattlenum
        '
        Me.txtBattlenum.Location = New System.Drawing.Point(240, 256)
        Me.txtBattlenum.Name = "txtBattlenum"
        Me.txtBattlenum.Size = New System.Drawing.Size(112, 20)
        Me.txtBattlenum.TabIndex = 120
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(192, 136)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(26, 24)
        Me.Label18.TabIndex = 121
        Me.Label18.Text = "%"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(424, 136)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(26, 24)
        Me.Label19.TabIndex = 122
        Me.Label19.Text = "%"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(232, 240)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(131, 16)
        Me.Label24.TabIndex = 123
        Me.Label24.Text = "How many Battels"
        '
        'lblties
        '
        Me.lblties.AutoSize = True
        Me.lblties.Location = New System.Drawing.Point(288, 136)
        Me.lblties.Name = "lblties"
        Me.lblties.Size = New System.Drawing.Size(13, 13)
        Me.lblties.TabIndex = 124
        Me.lblties.Text = "0"
        Me.lblties.Visible = False
        '
        'lblindex
        '
        Me.lblindex.AutoSize = True
        Me.lblindex.Location = New System.Drawing.Point(288, 216)
        Me.lblindex.Name = "lblindex"
        Me.lblindex.Size = New System.Drawing.Size(13, 13)
        Me.lblindex.TabIndex = 125
        Me.lblindex.Text = "0"
        Me.lblindex.Visible = False
        '
        'Panel4
        '
        Me.Panel4.BackgroundImage = CType(resources.GetObject("Panel4.BackgroundImage"), System.Drawing.Image)
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(600, 26)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(3, 396)
        Me.Panel4.TabIndex = 110
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = Global.HerosVillianRegistration.My.Resources.Resources.FormHeader2BlueGradiant
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 26)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(3, 396)
        Me.Panel3.TabIndex = 109
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.HerosVillianRegistration.My.Resources.Resources.FormFooterrBlueGradiant
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 422)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(603, 23)
        Me.Panel2.TabIndex = 97
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.HerosVillianRegistration.My.Resources.Resources.FormHeader2BlueGradiant
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.btnEventLog)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.btnMinimize)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(603, 26)
        Me.Panel1.TabIndex = 96
        '
        'btnEventLog
        '
        Me.btnEventLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEventLog.Location = New System.Drawing.Point(8, 0)
        Me.btnEventLog.Name = "btnEventLog"
        Me.btnEventLog.Size = New System.Drawing.Size(72, 23)
        Me.btnEventLog.TabIndex = 2
        Me.btnEventLog.Text = "Show Log"
        Me.btnEventLog.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Gray
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(563, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(33, 23)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnMinimize
        '
        Me.btnMinimize.BackColor = System.Drawing.Color.Gray
        Me.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinimize.Location = New System.Drawing.Point(524, 0)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(33, 23)
        Me.btnMinimize.TabIndex = 1
        Me.btnMinimize.Text = "-"
        Me.btnMinimize.UseVisualStyleBackColor = False
        '
        'pbOp2
        '
        Me.pbOp2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbOp2.Location = New System.Drawing.Point(456, 96)
        Me.pbOp2.Name = "pbOp2"
        Me.pbOp2.Size = New System.Drawing.Size(112, 112)
        Me.pbOp2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbOp2.TabIndex = 15
        Me.pbOp2.TabStop = False
        '
        'PbOp1
        '
        Me.PbOp1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PbOp1.Location = New System.Drawing.Point(16, 96)
        Me.PbOp1.Name = "PbOp1"
        Me.PbOp1.Size = New System.Drawing.Size(112, 112)
        Me.PbOp1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbOp1.TabIndex = 14
        Me.PbOp1.TabStop = False
        '
        'FighteroneTimer
        '
        '
        'FighterTwoTimer
        '
        '
        'TieTimer
        '
        '
        'ProgressTimer
        '
        '
        'EventProgressBar
        '
        Me.EventProgressBar.Location = New System.Drawing.Point(8, 400)
        Me.EventProgressBar.Name = "EventProgressBar"
        Me.EventProgressBar.Size = New System.Drawing.Size(588, 22)
        Me.EventProgressBar.TabIndex = 126
        '
        'lblprogress
        '
        Me.lblprogress.AutoSize = True
        Me.lblprogress.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprogress.Location = New System.Drawing.Point(274, 384)
        Me.lblprogress.Name = "lblprogress"
        Me.lblprogress.Size = New System.Drawing.Size(35, 13)
        Me.lblprogress.TabIndex = 127
        Me.lblprogress.Text = "-------"
        Me.lblprogress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnStop
        '
        Me.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStop.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStop.Location = New System.Drawing.Point(228, 341)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(64, 30)
        Me.btnStop.TabIndex = 128
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'lblHour
        '
        Me.lblHour.AutoSize = True
        Me.lblHour.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHour.Location = New System.Drawing.Point(224, 56)
        Me.lblHour.Name = "lblHour"
        Me.lblHour.Size = New System.Drawing.Size(32, 24)
        Me.lblHour.TabIndex = 129
        Me.lblHour.Text = "00"
        '
        'lblMin
        '
        Me.lblMin.AutoSize = True
        Me.lblMin.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMin.Location = New System.Drawing.Point(284, 56)
        Me.lblMin.Name = "lblMin"
        Me.lblMin.Size = New System.Drawing.Size(32, 24)
        Me.lblMin.TabIndex = 130
        Me.lblMin.Text = "00"
        '
        'lblSec
        '
        Me.lblSec.AutoSize = True
        Me.lblSec.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSec.Location = New System.Drawing.Point(344, 56)
        Me.lblSec.Name = "lblSec"
        Me.lblSec.Size = New System.Drawing.Size(32, 24)
        Me.lblSec.TabIndex = 131
        Me.lblSec.Text = "00"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(262, 56)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(16, 24)
        Me.Label25.TabIndex = 132
        Me.Label25.Text = ":"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(322, 56)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(16, 24)
        Me.Label26.TabIndex = 133
        Me.Label26.Text = ":"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(224, 32)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(34, 18)
        Me.Label27.TabIndex = 134
        Me.Label27.Text = "HR"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(284, 32)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(39, 18)
        Me.Label28.TabIndex = 135
        Me.Label28.Text = "Min"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(344, 32)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(31, 18)
        Me.Label29.TabIndex = 136
        Me.Label29.Text = "Sec"
        '
        'FightTime
        '
        Me.FightTime.Interval = 1000
        '
        'FightForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(603, 445)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.lblSec)
        Me.Controls.Add(Me.lblMin)
        Me.Controls.Add(Me.lblHour)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.lblprogress)
        Me.Controls.Add(Me.EventProgressBar)
        Me.Controls.Add(Me.lblindex)
        Me.Controls.Add(Me.lblties)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtBattlenum)
        Me.Controls.Add(Me.lblPercOp2)
        Me.Controls.Add(Me.lblPercOp1)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.lblBattleNumOp2)
        Me.Controls.Add(Me.lblWinBattleDivide2)
        Me.Controls.Add(Me.lblOp2Wins)
        Me.Controls.Add(Me.lblBattleNumOp1)
        Me.Controls.Add(Me.lblwinbattledivide1)
        Me.Controls.Add(Me.lblOp1Wins)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblSum2)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.lblSum)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.btnFight)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSelectOp2)
        Me.Controls.Add(Me.lblEpOp2)
        Me.Controls.Add(Me.lblFsOp2)
        Me.Controls.Add(Me.lblDurOp2)
        Me.Controls.Add(Me.lblSpdOp2)
        Me.Controls.Add(Me.lblStrOp2)
        Me.Controls.Add(Me.lblIntOp2)
        Me.Controls.Add(Me.btnSelectOp1)
        Me.Controls.Add(Me.lblepOp1)
        Me.Controls.Add(Me.lblfsOp1)
        Me.Controls.Add(Me.lbldurOp1)
        Me.Controls.Add(Me.lblspdOp1)
        Me.Controls.Add(Me.lblstrOp1)
        Me.Controls.Add(Me.lblintOp1)
        Me.Controls.Add(Me.pbOp2)
        Me.Controls.Add(Me.PbOp1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lblNameOp2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblNameOp1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FightForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FightForm"
        Me.Panel1.ResumeLayout(False)
        CType(Me.pbOp2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbOp1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNameOp1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblNameOp2 As System.Windows.Forms.Label
    Friend WithEvents PbOp1 As System.Windows.Forms.PictureBox
    Friend WithEvents pbOp2 As System.Windows.Forms.PictureBox
    Friend WithEvents lblepOp1 As System.Windows.Forms.Label
    Friend WithEvents lblfsOp1 As System.Windows.Forms.Label
    Friend WithEvents lbldurOp1 As System.Windows.Forms.Label
    Friend WithEvents lblspdOp1 As System.Windows.Forms.Label
    Friend WithEvents lblstrOp1 As System.Windows.Forms.Label
    Friend WithEvents lblintOp1 As System.Windows.Forms.Label
    Friend WithEvents btnSelectOp1 As System.Windows.Forms.Button
    Friend WithEvents lblEpOp2 As System.Windows.Forms.Label
    Friend WithEvents lblFsOp2 As System.Windows.Forms.Label
    Friend WithEvents lblDurOp2 As System.Windows.Forms.Label
    Friend WithEvents lblSpdOp2 As System.Windows.Forms.Label
    Friend WithEvents lblStrOp2 As System.Windows.Forms.Label
    Friend WithEvents lblIntOp2 As System.Windows.Forms.Label
    Friend WithEvents btnSelectOp2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnFight As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents lblSum As System.Windows.Forms.Label
    Friend WithEvents lblSum2 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnMinimize As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents lblOp1Wins As System.Windows.Forms.Label
    Friend WithEvents lblwinbattledivide1 As System.Windows.Forms.Label
    Friend WithEvents lblBattleNumOp1 As System.Windows.Forms.Label
    Friend WithEvents lblOp2Wins As System.Windows.Forms.Label
    Friend WithEvents lblWinBattleDivide2 As System.Windows.Forms.Label
    Friend WithEvents lblBattleNumOp2 As System.Windows.Forms.Label
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents lblPercOp1 As System.Windows.Forms.Label
    Friend WithEvents lblPercOp2 As System.Windows.Forms.Label
    Friend WithEvents txtBattlenum As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents lblties As System.Windows.Forms.Label
    Friend WithEvents lblindex As System.Windows.Forms.Label
    Friend WithEvents btnEventLog As System.Windows.Forms.Button
    Friend WithEvents FighteroneTimer As System.Windows.Forms.Timer
    Friend WithEvents FighterTwoTimer As System.Windows.Forms.Timer
    Friend WithEvents TieTimer As System.Windows.Forms.Timer
    Friend WithEvents ProgressTimer As System.Windows.Forms.Timer
    Friend WithEvents EventProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents lblprogress As System.Windows.Forms.Label
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents lblHour As System.Windows.Forms.Label
    Friend WithEvents lblMin As System.Windows.Forms.Label
    Friend WithEvents lblSec As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents FightTime As System.Windows.Forms.Timer
End Class
