﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectedFighter
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
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim LastNameLabel As System.Windows.Forms.Label
        Dim AlignmentLabel As System.Windows.Forms.Label
        Dim IntelligenceLabel As System.Windows.Forms.Label
        Dim StrengthLabel As System.Windows.Forms.Label
        Dim SpeedLabel As System.Windows.Forms.Label
        Dim DurabilityLabel As System.Windows.Forms.Label
        Dim FightingSkillLabel As System.Windows.Forms.Label
        Dim EnergyProjectionLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SelectedFighter))
        Me.RegistrationDatabaseDataSet = New HerosVillianRegistration.RegistrationDatabaseDataSet()
        Me.RegistrationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RegistrationTableAdapter = New HerosVillianRegistration.RegistrationDatabaseDataSetTableAdapters.RegistrationTableAdapter()
        Me.TableAdapterManager = New HerosVillianRegistration.RegistrationDatabaseDataSetTableAdapters.TableAdapterManager()
        Me.RegistrationDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameLabel1 = New System.Windows.Forms.Label()
        Me.LastNameLabel1 = New System.Windows.Forms.Label()
        Me.AlignmentLabel1 = New System.Windows.Forms.Label()
        Me.IntelligenceProgressBar = New System.Windows.Forms.ProgressBar()
        Me.StrengthProgressBar = New System.Windows.Forms.ProgressBar()
        Me.SpeedProgressBar = New System.Windows.Forms.ProgressBar()
        Me.DurabilityProgressBar = New System.Windows.Forms.ProgressBar()
        Me.FightingSkillProgressBar = New System.Windows.Forms.ProgressBar()
        Me.EnergyProjectionProgressBar = New System.Windows.Forms.ProgressBar()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.IntelligenceLabel2 = New System.Windows.Forms.Label()
        Me.StrengthLabel2 = New System.Windows.Forms.Label()
        Me.SpeedLabel2 = New System.Windows.Forms.Label()
        Me.DurabilityLabel2 = New System.Windows.Forms.Label()
        Me.FightingSkillLabel2 = New System.Windows.Forms.Label()
        Me.EnergyProjectionLabel2 = New System.Windows.Forms.Label()
        Me.NameLabel1 = New System.Windows.Forms.Label()
        Me.ImgBox = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        FirstNameLabel = New System.Windows.Forms.Label()
        LastNameLabel = New System.Windows.Forms.Label()
        AlignmentLabel = New System.Windows.Forms.Label()
        IntelligenceLabel = New System.Windows.Forms.Label()
        StrengthLabel = New System.Windows.Forms.Label()
        SpeedLabel = New System.Windows.Forms.Label()
        DurabilityLabel = New System.Windows.Forms.Label()
        FightingSkillLabel = New System.Windows.Forms.Label()
        EnergyProjectionLabel = New System.Windows.Forms.Label()
        CType(Me.RegistrationDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegistrationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegistrationDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Location = New System.Drawing.Point(264, 264)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(60, 13)
        FirstNameLabel.TabIndex = 5
        FirstNameLabel.Text = "First Name:"
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Location = New System.Drawing.Point(264, 287)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(61, 13)
        LastNameLabel.TabIndex = 7
        LastNameLabel.Text = "Last Name:"
        '
        'AlignmentLabel
        '
        AlignmentLabel.AutoSize = True
        AlignmentLabel.Location = New System.Drawing.Point(264, 312)
        AlignmentLabel.Name = "AlignmentLabel"
        AlignmentLabel.Size = New System.Drawing.Size(56, 13)
        AlignmentLabel.TabIndex = 9
        AlignmentLabel.Text = "Alignment:"
        '
        'IntelligenceLabel
        '
        IntelligenceLabel.AutoSize = True
        IntelligenceLabel.Location = New System.Drawing.Point(416, 62)
        IntelligenceLabel.Name = "IntelligenceLabel"
        IntelligenceLabel.Size = New System.Drawing.Size(64, 13)
        IntelligenceLabel.TabIndex = 15
        IntelligenceLabel.Text = "Intelligence:"
        '
        'StrengthLabel
        '
        StrengthLabel.AutoSize = True
        StrengthLabel.Location = New System.Drawing.Point(416, 90)
        StrengthLabel.Name = "StrengthLabel"
        StrengthLabel.Size = New System.Drawing.Size(50, 13)
        StrengthLabel.TabIndex = 17
        StrengthLabel.Text = "Strength:"
        '
        'SpeedLabel
        '
        SpeedLabel.AutoSize = True
        SpeedLabel.Location = New System.Drawing.Point(416, 118)
        SpeedLabel.Name = "SpeedLabel"
        SpeedLabel.Size = New System.Drawing.Size(41, 13)
        SpeedLabel.TabIndex = 19
        SpeedLabel.Text = "Speed:"
        '
        'DurabilityLabel
        '
        DurabilityLabel.AutoSize = True
        DurabilityLabel.Location = New System.Drawing.Point(416, 146)
        DurabilityLabel.Name = "DurabilityLabel"
        DurabilityLabel.Size = New System.Drawing.Size(53, 13)
        DurabilityLabel.TabIndex = 21
        DurabilityLabel.Text = "Durability:"
        '
        'FightingSkillLabel
        '
        FightingSkillLabel.AutoSize = True
        FightingSkillLabel.Location = New System.Drawing.Point(416, 174)
        FightingSkillLabel.Name = "FightingSkillLabel"
        FightingSkillLabel.Size = New System.Drawing.Size(69, 13)
        FightingSkillLabel.TabIndex = 23
        FightingSkillLabel.Text = "Fighting Skill:"
        '
        'EnergyProjectionLabel
        '
        EnergyProjectionLabel.AutoSize = True
        EnergyProjectionLabel.Location = New System.Drawing.Point(416, 202)
        EnergyProjectionLabel.Name = "EnergyProjectionLabel"
        EnergyProjectionLabel.Size = New System.Drawing.Size(93, 13)
        EnergyProjectionLabel.TabIndex = 25
        EnergyProjectionLabel.Text = "Energy Projection:"
        '
        'RegistrationDatabaseDataSet
        '
        Me.RegistrationDatabaseDataSet.DataSetName = "RegistrationDatabaseDataSet"
        Me.RegistrationDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RegistrationBindingSource
        '
        Me.RegistrationBindingSource.DataMember = "Registration"
        Me.RegistrationBindingSource.DataSource = Me.RegistrationDatabaseDataSet
        '
        'RegistrationTableAdapter
        '
        Me.RegistrationTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BaseOfOperationsTableAdapter = Nothing
        Me.TableAdapterManager.ImageTableTableAdapter = Nothing
        Me.TableAdapterManager.LoginTableTableAdapter = Nothing
        Me.TableAdapterManager.RegistrationTableAdapter = Me.RegistrationTableAdapter
        Me.TableAdapterManager.TeamsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = HerosVillianRegistration.RegistrationDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'RegistrationDataGridView
        '
        Me.RegistrationDataGridView.AllowUserToAddRows = False
        Me.RegistrationDataGridView.AllowUserToDeleteRows = False
        Me.RegistrationDataGridView.AutoGenerateColumns = False
        Me.RegistrationDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.RegistrationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RegistrationDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2})
        Me.RegistrationDataGridView.DataSource = Me.RegistrationBindingSource
        Me.RegistrationDataGridView.Location = New System.Drawing.Point(8, 40)
        Me.RegistrationDataGridView.Name = "RegistrationDataGridView"
        Me.RegistrationDataGridView.ReadOnly = True
        Me.RegistrationDataGridView.RowHeadersVisible = False
        Me.RegistrationDataGridView.Size = New System.Drawing.Size(224, 288)
        Me.RegistrationDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'FirstNameLabel1
        '
        Me.FirstNameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistrationBindingSource, "FirstName", True))
        Me.FirstNameLabel1.Location = New System.Drawing.Point(368, 264)
        Me.FirstNameLabel1.Name = "FirstNameLabel1"
        Me.FirstNameLabel1.Size = New System.Drawing.Size(168, 23)
        Me.FirstNameLabel1.TabIndex = 6
        Me.FirstNameLabel1.Text = "Label1"
        '
        'LastNameLabel1
        '
        Me.LastNameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistrationBindingSource, "LastName", True))
        Me.LastNameLabel1.Location = New System.Drawing.Point(368, 287)
        Me.LastNameLabel1.Name = "LastNameLabel1"
        Me.LastNameLabel1.Size = New System.Drawing.Size(168, 23)
        Me.LastNameLabel1.TabIndex = 8
        Me.LastNameLabel1.Text = "Label1"
        '
        'AlignmentLabel1
        '
        Me.AlignmentLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistrationBindingSource, "Alignment", True))
        Me.AlignmentLabel1.Location = New System.Drawing.Point(368, 312)
        Me.AlignmentLabel1.Name = "AlignmentLabel1"
        Me.AlignmentLabel1.Size = New System.Drawing.Size(100, 23)
        Me.AlignmentLabel1.TabIndex = 10
        Me.AlignmentLabel1.Text = "Label1"
        '
        'IntelligenceProgressBar
        '
        Me.IntelligenceProgressBar.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.RegistrationBindingSource, "Intelligence", True))
        Me.IntelligenceProgressBar.Location = New System.Drawing.Point(544, 57)
        Me.IntelligenceProgressBar.Maximum = 7
        Me.IntelligenceProgressBar.Name = "IntelligenceProgressBar"
        Me.IntelligenceProgressBar.Size = New System.Drawing.Size(100, 23)
        Me.IntelligenceProgressBar.TabIndex = 16
        '
        'StrengthProgressBar
        '
        Me.StrengthProgressBar.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.RegistrationBindingSource, "Strength", True))
        Me.StrengthProgressBar.Location = New System.Drawing.Point(544, 85)
        Me.StrengthProgressBar.Maximum = 7
        Me.StrengthProgressBar.Name = "StrengthProgressBar"
        Me.StrengthProgressBar.Size = New System.Drawing.Size(100, 23)
        Me.StrengthProgressBar.TabIndex = 18
        '
        'SpeedProgressBar
        '
        Me.SpeedProgressBar.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.RegistrationBindingSource, "Speed", True))
        Me.SpeedProgressBar.Location = New System.Drawing.Point(543, 113)
        Me.SpeedProgressBar.Maximum = 7
        Me.SpeedProgressBar.Name = "SpeedProgressBar"
        Me.SpeedProgressBar.Size = New System.Drawing.Size(100, 23)
        Me.SpeedProgressBar.TabIndex = 20
        '
        'DurabilityProgressBar
        '
        Me.DurabilityProgressBar.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.RegistrationBindingSource, "Durability", True))
        Me.DurabilityProgressBar.Location = New System.Drawing.Point(544, 141)
        Me.DurabilityProgressBar.Maximum = 7
        Me.DurabilityProgressBar.Name = "DurabilityProgressBar"
        Me.DurabilityProgressBar.Size = New System.Drawing.Size(100, 23)
        Me.DurabilityProgressBar.TabIndex = 22
        '
        'FightingSkillProgressBar
        '
        Me.FightingSkillProgressBar.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.RegistrationBindingSource, "FightingSkill", True))
        Me.FightingSkillProgressBar.Location = New System.Drawing.Point(544, 169)
        Me.FightingSkillProgressBar.Maximum = 7
        Me.FightingSkillProgressBar.Name = "FightingSkillProgressBar"
        Me.FightingSkillProgressBar.Size = New System.Drawing.Size(100, 23)
        Me.FightingSkillProgressBar.TabIndex = 24
        '
        'EnergyProjectionProgressBar
        '
        Me.EnergyProjectionProgressBar.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.RegistrationBindingSource, "EnergyProjection", True))
        Me.EnergyProjectionProgressBar.Location = New System.Drawing.Point(544, 197)
        Me.EnergyProjectionProgressBar.Maximum = 7
        Me.EnergyProjectionProgressBar.Name = "EnergyProjectionProgressBar"
        Me.EnergyProjectionProgressBar.Size = New System.Drawing.Size(100, 23)
        Me.EnergyProjectionProgressBar.TabIndex = 26
        '
        'btnSelect
        '
        Me.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelect.Location = New System.Drawing.Point(536, 344)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(120, 32)
        Me.btnSelect.TabIndex = 27
        Me.btnSelect.Text = "Select Fighter"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'IntelligenceLabel2
        '
        Me.IntelligenceLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistrationBindingSource, "Intelligence", True))
        Me.IntelligenceLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IntelligenceLabel2.Location = New System.Drawing.Point(512, 56)
        Me.IntelligenceLabel2.Name = "IntelligenceLabel2"
        Me.IntelligenceLabel2.Size = New System.Drawing.Size(24, 24)
        Me.IntelligenceLabel2.TabIndex = 28
        Me.IntelligenceLabel2.Text = "0"
        Me.IntelligenceLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StrengthLabel2
        '
        Me.StrengthLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistrationBindingSource, "Strength", True))
        Me.StrengthLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StrengthLabel2.Location = New System.Drawing.Point(512, 84)
        Me.StrengthLabel2.Name = "StrengthLabel2"
        Me.StrengthLabel2.Size = New System.Drawing.Size(24, 24)
        Me.StrengthLabel2.TabIndex = 29
        Me.StrengthLabel2.Text = "0"
        Me.StrengthLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SpeedLabel2
        '
        Me.SpeedLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistrationBindingSource, "Speed", True))
        Me.SpeedLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpeedLabel2.Location = New System.Drawing.Point(512, 112)
        Me.SpeedLabel2.Name = "SpeedLabel2"
        Me.SpeedLabel2.Size = New System.Drawing.Size(24, 24)
        Me.SpeedLabel2.TabIndex = 30
        Me.SpeedLabel2.Text = "0"
        Me.SpeedLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DurabilityLabel2
        '
        Me.DurabilityLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistrationBindingSource, "Durability", True))
        Me.DurabilityLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DurabilityLabel2.Location = New System.Drawing.Point(512, 140)
        Me.DurabilityLabel2.Name = "DurabilityLabel2"
        Me.DurabilityLabel2.Size = New System.Drawing.Size(24, 24)
        Me.DurabilityLabel2.TabIndex = 31
        Me.DurabilityLabel2.Text = "0"
        Me.DurabilityLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FightingSkillLabel2
        '
        Me.FightingSkillLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistrationBindingSource, "FightingSkill", True))
        Me.FightingSkillLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FightingSkillLabel2.Location = New System.Drawing.Point(512, 168)
        Me.FightingSkillLabel2.Name = "FightingSkillLabel2"
        Me.FightingSkillLabel2.Size = New System.Drawing.Size(24, 24)
        Me.FightingSkillLabel2.TabIndex = 32
        Me.FightingSkillLabel2.Text = "0"
        Me.FightingSkillLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EnergyProjectionLabel2
        '
        Me.EnergyProjectionLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistrationBindingSource, "EnergyProjection", True))
        Me.EnergyProjectionLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnergyProjectionLabel2.Location = New System.Drawing.Point(512, 196)
        Me.EnergyProjectionLabel2.Name = "EnergyProjectionLabel2"
        Me.EnergyProjectionLabel2.Size = New System.Drawing.Size(24, 24)
        Me.EnergyProjectionLabel2.TabIndex = 33
        Me.EnergyProjectionLabel2.Text = "0"
        Me.EnergyProjectionLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NameLabel1
        '
        Me.NameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistrationBindingSource, "Name", True))
        Me.NameLabel1.Location = New System.Drawing.Point(264, 32)
        Me.NameLabel1.Name = "NameLabel1"
        Me.NameLabel1.Size = New System.Drawing.Size(152, 23)
        Me.NameLabel1.TabIndex = 34
        Me.NameLabel1.Text = "Label1"
        Me.NameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ImgBox
        '
        Me.ImgBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ImgBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.RegistrationBindingSource, "Image", True))
        Me.ImgBox.Location = New System.Drawing.Point(264, 56)
        Me.ImgBox.Name = "ImgBox"
        Me.ImgBox.Size = New System.Drawing.Size(150, 200)
        Me.ImgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgBox.TabIndex = 12
        Me.ImgBox.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.HerosVillianRegistration.My.Resources.Resources.FormHeader2BlueGradiant
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.btnMinimize)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(662, 26)
        Me.Panel1.TabIndex = 97
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Gray
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(630, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(24, 20)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnMinimize
        '
        Me.btnMinimize.BackColor = System.Drawing.Color.Gray
        Me.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMinimize.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinimize.Location = New System.Drawing.Point(600, 0)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(24, 20)
        Me.btnMinimize.TabIndex = 1
        Me.btnMinimize.Text = "-"
        Me.btnMinimize.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.HerosVillianRegistration.My.Resources.Resources.FormFooterrBlueGradiant
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 379)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(662, 23)
        Me.Panel2.TabIndex = 98
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = Global.HerosVillianRegistration.My.Resources.Resources.FormHeader2BlueGradiant
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 26)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(3, 353)
        Me.Panel3.TabIndex = 110
        '
        'Panel4
        '
        Me.Panel4.BackgroundImage = CType(resources.GetObject("Panel4.BackgroundImage"), System.Drawing.Image)
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(659, 26)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(3, 353)
        Me.Panel4.TabIndex = 111
        '
        'SelectedFighter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(662, 402)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.NameLabel1)
        Me.Controls.Add(Me.EnergyProjectionLabel2)
        Me.Controls.Add(Me.FightingSkillLabel2)
        Me.Controls.Add(Me.DurabilityLabel2)
        Me.Controls.Add(Me.SpeedLabel2)
        Me.Controls.Add(Me.StrengthLabel2)
        Me.Controls.Add(Me.IntelligenceLabel2)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(FirstNameLabel)
        Me.Controls.Add(Me.FirstNameLabel1)
        Me.Controls.Add(LastNameLabel)
        Me.Controls.Add(Me.LastNameLabel1)
        Me.Controls.Add(AlignmentLabel)
        Me.Controls.Add(Me.AlignmentLabel1)
        Me.Controls.Add(Me.ImgBox)
        Me.Controls.Add(IntelligenceLabel)
        Me.Controls.Add(Me.IntelligenceProgressBar)
        Me.Controls.Add(StrengthLabel)
        Me.Controls.Add(Me.StrengthProgressBar)
        Me.Controls.Add(SpeedLabel)
        Me.Controls.Add(Me.SpeedProgressBar)
        Me.Controls.Add(DurabilityLabel)
        Me.Controls.Add(Me.DurabilityProgressBar)
        Me.Controls.Add(FightingSkillLabel)
        Me.Controls.Add(Me.FightingSkillProgressBar)
        Me.Controls.Add(EnergyProjectionLabel)
        Me.Controls.Add(Me.EnergyProjectionProgressBar)
        Me.Controls.Add(Me.RegistrationDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SelectedFighter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SelectedFighter"
        CType(Me.RegistrationDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegistrationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegistrationDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RegistrationDatabaseDataSet As HerosVillianRegistration.RegistrationDatabaseDataSet
    Friend WithEvents RegistrationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RegistrationTableAdapter As HerosVillianRegistration.RegistrationDatabaseDataSetTableAdapters.RegistrationTableAdapter
    Friend WithEvents TableAdapterManager As HerosVillianRegistration.RegistrationDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents RegistrationDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstNameLabel1 As System.Windows.Forms.Label
    Friend WithEvents LastNameLabel1 As System.Windows.Forms.Label
    Friend WithEvents AlignmentLabel1 As System.Windows.Forms.Label
    Friend WithEvents ImgBox As System.Windows.Forms.PictureBox
    Friend WithEvents IntelligenceProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents StrengthProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents SpeedProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents DurabilityProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents FightingSkillProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents EnergyProjectionProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents IntelligenceLabel2 As System.Windows.Forms.Label
    Friend WithEvents StrengthLabel2 As System.Windows.Forms.Label
    Friend WithEvents SpeedLabel2 As System.Windows.Forms.Label
    Friend WithEvents DurabilityLabel2 As System.Windows.Forms.Label
    Friend WithEvents FightingSkillLabel2 As System.Windows.Forms.Label
    Friend WithEvents EnergyProjectionLabel2 As System.Windows.Forms.Label
    Friend WithEvents NameLabel1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnMinimize As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
End Class
