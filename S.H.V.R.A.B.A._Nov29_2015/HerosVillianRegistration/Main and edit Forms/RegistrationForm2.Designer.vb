<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrationForm2
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
        Dim IDLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim LastNameLabel As System.Windows.Forms.Label
        Dim AlignmentLabel As System.Windows.Forms.Label
        Dim ImageLabel As System.Windows.Forms.Label
        Dim AbilitiesLabel As System.Windows.Forms.Label
        Dim IntelligenceLabel As System.Windows.Forms.Label
        Dim StrengthLabel As System.Windows.Forms.Label
        Dim SpeedLabel As System.Windows.Forms.Label
        Dim DurabilityLabel As System.Windows.Forms.Label
        Dim FightingSkillLabel As System.Windows.Forms.Label
        Dim EnergyProjectionLabel As System.Windows.Forms.Label
        Dim BaseNameLabel As System.Windows.Forms.Label
        Dim BasePlanetLabel As System.Windows.Forms.Label
        Dim BaseCountryLabel As System.Windows.Forms.Label
        Dim BaseStateLabel As System.Windows.Forms.Label
        Dim BaseCityLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistrationForm2))
        Me.btnNext2 = New System.Windows.Forms.Button()
        Me.btnPrevious2 = New System.Windows.Forms.Button()
        Me.RegistrationDataGridView = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlignmentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Intelligence = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Strength = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Speed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Durability = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FightingSkill = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EnergyProjection = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegistrationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RegistrationDatabaseDataSet = New HerosVillianRegistration.RegistrationDatabaseDataSet()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.RegistrationTableAdapter = New HerosVillianRegistration.RegistrationDatabaseDataSetTableAdapters.RegistrationTableAdapter()
        Me.TableAdapterManager = New HerosVillianRegistration.RegistrationDatabaseDataSetTableAdapters.TableAdapterManager()
        Me.IDLabel1 = New System.Windows.Forms.Label()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.AlignmentComboBox = New System.Windows.Forms.ComboBox()
        Me.IntelligenceTrackBar = New System.Windows.Forms.TrackBar()
        Me.StrengthTrackBar = New System.Windows.Forms.TrackBar()
        Me.SpeedTrackBar = New System.Windows.Forms.TrackBar()
        Me.DurabilityTrackBar = New System.Windows.Forms.TrackBar()
        Me.FightingSkillTrackBar = New System.Windows.Forms.TrackBar()
        Me.EnergyProjectionTrackBar = New System.Windows.Forms.TrackBar()
        Me.lblIntel = New System.Windows.Forms.Label()
        Me.lblStr = New System.Windows.Forms.Label()
        Me.lblSpe = New System.Windows.Forms.Label()
        Me.lblDur = New System.Windows.Forms.Label()
        Me.lblFS = New System.Windows.Forms.Label()
        Me.lblEP = New System.Windows.Forms.Label()
        Me.btnRandomize = New System.Windows.Forms.Button()
        Me.AbilitiesTextBox = New System.Windows.Forms.TextBox()
        Me.btnDone1 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TeamGroupBox = New System.Windows.Forms.GroupBox()
        Me.TmLogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.TmNameLabel1 = New System.Windows.Forms.Label()
        Me.BaseGroupBox = New System.Windows.Forms.GroupBox()
        Me.BaseImagePictureBox = New System.Windows.Forms.PictureBox()
        Me.BaseCityLabel1 = New System.Windows.Forms.Label()
        Me.BaseStateLabel1 = New System.Windows.Forms.Label()
        Me.BaseCountryLabel1 = New System.Windows.Forms.Label()
        Me.BasePlanetLabel1 = New System.Windows.Forms.Label()
        Me.BaseNameLabel1 = New System.Windows.Forms.Label()
        Me.btnTeam = New System.Windows.Forms.Button()
        Me.TeamsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BaseOfOperationsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AttributeGroupBox = New System.Windows.Forms.GroupBox()
        Me.CharacterGroupBox = New System.Windows.Forms.GroupBox()
        Me.ImagePictureBox = New System.Windows.Forms.PictureBox()
        Me.BaseOfOperationsTableAdapter = New HerosVillianRegistration.RegistrationDatabaseDataSetTableAdapters.BaseOfOperationsTableAdapter()
        Me.TeamsTableAdapter = New HerosVillianRegistration.RegistrationDatabaseDataSetTableAdapters.TeamsTableAdapter()
        Me.SearchGroupBox = New System.Windows.Forms.GroupBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnMinimize = New System.Windows.Forms.Button()
        IDLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        FirstNameLabel = New System.Windows.Forms.Label()
        LastNameLabel = New System.Windows.Forms.Label()
        AlignmentLabel = New System.Windows.Forms.Label()
        ImageLabel = New System.Windows.Forms.Label()
        AbilitiesLabel = New System.Windows.Forms.Label()
        IntelligenceLabel = New System.Windows.Forms.Label()
        StrengthLabel = New System.Windows.Forms.Label()
        SpeedLabel = New System.Windows.Forms.Label()
        DurabilityLabel = New System.Windows.Forms.Label()
        FightingSkillLabel = New System.Windows.Forms.Label()
        EnergyProjectionLabel = New System.Windows.Forms.Label()
        BaseNameLabel = New System.Windows.Forms.Label()
        BasePlanetLabel = New System.Windows.Forms.Label()
        BaseCountryLabel = New System.Windows.Forms.Label()
        BaseStateLabel = New System.Windows.Forms.Label()
        BaseCityLabel = New System.Windows.Forms.Label()
        CType(Me.RegistrationDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegistrationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegistrationDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IntelligenceTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StrengthTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpeedTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DurabilityTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FightingSkillTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnergyProjectionTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TeamGroupBox.SuspendLayout()
        CType(Me.TmLogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BaseGroupBox.SuspendLayout()
        CType(Me.BaseImagePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TeamsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BaseOfOperationsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AttributeGroupBox.SuspendLayout()
        Me.CharacterGroupBox.SuspendLayout()
        CType(Me.ImagePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SearchGroupBox.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(6, 59)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 85
        IDLabel.Text = "ID:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(6, 92)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(38, 13)
        NameLabel.TabIndex = 86
        NameLabel.Text = "Name:"
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Location = New System.Drawing.Point(6, 119)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(60, 13)
        FirstNameLabel.TabIndex = 87
        FirstNameLabel.Text = "First Name:"
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Location = New System.Drawing.Point(6, 144)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(61, 13)
        LastNameLabel.TabIndex = 88
        LastNameLabel.Text = "Last Name:"
        '
        'AlignmentLabel
        '
        AlignmentLabel.AutoSize = True
        AlignmentLabel.Location = New System.Drawing.Point(6, 171)
        AlignmentLabel.Name = "AlignmentLabel"
        AlignmentLabel.Size = New System.Drawing.Size(56, 13)
        AlignmentLabel.TabIndex = 89
        AlignmentLabel.Text = "Alignment:"
        '
        'ImageLabel
        '
        ImageLabel.AutoSize = True
        ImageLabel.Location = New System.Drawing.Point(296, 43)
        ImageLabel.Name = "ImageLabel"
        ImageLabel.Size = New System.Drawing.Size(88, 13)
        ImageLabel.TabIndex = 90
        ImageLabel.Text = "Character Image:"
        '
        'AbilitiesLabel
        '
        AbilitiesLabel.AutoSize = True
        AbilitiesLabel.Location = New System.Drawing.Point(6, 196)
        AbilitiesLabel.Name = "AbilitiesLabel"
        AbilitiesLabel.Size = New System.Drawing.Size(45, 13)
        AbilitiesLabel.TabIndex = 91
        AbilitiesLabel.Text = "Abilities:"
        '
        'IntelligenceLabel
        '
        IntelligenceLabel.AutoSize = True
        IntelligenceLabel.Location = New System.Drawing.Point(25, 16)
        IntelligenceLabel.Name = "IntelligenceLabel"
        IntelligenceLabel.Size = New System.Drawing.Size(64, 13)
        IntelligenceLabel.TabIndex = 92
        IntelligenceLabel.Text = "Intelligence:"
        '
        'StrengthLabel
        '
        StrengthLabel.AutoSize = True
        StrengthLabel.Location = New System.Drawing.Point(25, 64)
        StrengthLabel.Name = "StrengthLabel"
        StrengthLabel.Size = New System.Drawing.Size(50, 13)
        StrengthLabel.TabIndex = 93
        StrengthLabel.Text = "Strength:"
        '
        'SpeedLabel
        '
        SpeedLabel.AutoSize = True
        SpeedLabel.Location = New System.Drawing.Point(25, 112)
        SpeedLabel.Name = "SpeedLabel"
        SpeedLabel.Size = New System.Drawing.Size(41, 13)
        SpeedLabel.TabIndex = 94
        SpeedLabel.Text = "Speed:"
        '
        'DurabilityLabel
        '
        DurabilityLabel.AutoSize = True
        DurabilityLabel.Location = New System.Drawing.Point(25, 158)
        DurabilityLabel.Name = "DurabilityLabel"
        DurabilityLabel.Size = New System.Drawing.Size(53, 13)
        DurabilityLabel.TabIndex = 95
        DurabilityLabel.Text = "Durability:"
        '
        'FightingSkillLabel
        '
        FightingSkillLabel.AutoSize = True
        FightingSkillLabel.Location = New System.Drawing.Point(25, 203)
        FightingSkillLabel.Name = "FightingSkillLabel"
        FightingSkillLabel.Size = New System.Drawing.Size(69, 13)
        FightingSkillLabel.TabIndex = 96
        FightingSkillLabel.Text = "Fighting Skill:"
        '
        'EnergyProjectionLabel
        '
        EnergyProjectionLabel.AutoSize = True
        EnergyProjectionLabel.Location = New System.Drawing.Point(25, 251)
        EnergyProjectionLabel.Name = "EnergyProjectionLabel"
        EnergyProjectionLabel.Size = New System.Drawing.Size(93, 13)
        EnergyProjectionLabel.TabIndex = 97
        EnergyProjectionLabel.Text = "Energy Projection:"
        '
        'BaseNameLabel
        '
        BaseNameLabel.AutoSize = True
        BaseNameLabel.Location = New System.Drawing.Point(131, 16)
        BaseNameLabel.Name = "BaseNameLabel"
        BaseNameLabel.Size = New System.Drawing.Size(34, 13)
        BaseNameLabel.TabIndex = 0
        BaseNameLabel.Text = "Base:"
        '
        'BasePlanetLabel
        '
        BasePlanetLabel.AutoSize = True
        BasePlanetLabel.Location = New System.Drawing.Point(131, 39)
        BasePlanetLabel.Name = "BasePlanetLabel"
        BasePlanetLabel.Size = New System.Drawing.Size(40, 13)
        BasePlanetLabel.TabIndex = 2
        BasePlanetLabel.Text = "Planet:"
        '
        'BaseCountryLabel
        '
        BaseCountryLabel.AutoSize = True
        BaseCountryLabel.Location = New System.Drawing.Point(131, 62)
        BaseCountryLabel.Name = "BaseCountryLabel"
        BaseCountryLabel.Size = New System.Drawing.Size(46, 13)
        BaseCountryLabel.TabIndex = 4
        BaseCountryLabel.Text = "Country:"
        '
        'BaseStateLabel
        '
        BaseStateLabel.AutoSize = True
        BaseStateLabel.Location = New System.Drawing.Point(131, 83)
        BaseStateLabel.Name = "BaseStateLabel"
        BaseStateLabel.Size = New System.Drawing.Size(35, 13)
        BaseStateLabel.TabIndex = 6
        BaseStateLabel.Text = "State:"
        '
        'BaseCityLabel
        '
        BaseCityLabel.AutoSize = True
        BaseCityLabel.Location = New System.Drawing.Point(131, 106)
        BaseCityLabel.Name = "BaseCityLabel"
        BaseCityLabel.Size = New System.Drawing.Size(27, 13)
        BaseCityLabel.TabIndex = 8
        BaseCityLabel.Text = "City:"
        '
        'btnNext2
        '
        Me.btnNext2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNext2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext2.Location = New System.Drawing.Point(71, 32)
        Me.btnNext2.Name = "btnNext2"
        Me.btnNext2.Size = New System.Drawing.Size(45, 25)
        Me.btnNext2.TabIndex = 83
        Me.btnNext2.Text = ">"
        Me.btnNext2.UseVisualStyleBackColor = True
        '
        'btnPrevious2
        '
        Me.btnPrevious2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrevious2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrevious2.Location = New System.Drawing.Point(16, 32)
        Me.btnPrevious2.Name = "btnPrevious2"
        Me.btnPrevious2.Size = New System.Drawing.Size(45, 25)
        Me.btnPrevious2.TabIndex = 82
        Me.btnPrevious2.Text = "<"
        Me.btnPrevious2.UseVisualStyleBackColor = True
        '
        'RegistrationDataGridView
        '
        Me.RegistrationDataGridView.AllowUserToOrderColumns = True
        Me.RegistrationDataGridView.AllowUserToResizeRows = False
        Me.RegistrationDataGridView.AutoGenerateColumns = False
        Me.RegistrationDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.RegistrationDataGridView.BackgroundColor = System.Drawing.Color.LightGray
        Me.RegistrationDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.RegistrationDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.RegistrationDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.RegistrationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RegistrationDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.AlignmentDataGridViewTextBoxColumn, Me.Intelligence, Me.Strength, Me.Speed, Me.Durability, Me.FightingSkill, Me.EnergyProjection})
        Me.RegistrationDataGridView.DataSource = Me.RegistrationBindingSource
        Me.RegistrationDataGridView.Location = New System.Drawing.Point(26, 39)
        Me.RegistrationDataGridView.Name = "RegistrationDataGridView"
        Me.RegistrationDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.RegistrationDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.RegistrationDataGridView.RowHeadersVisible = False
        Me.RegistrationDataGridView.Size = New System.Drawing.Size(1012, 162)
        Me.RegistrationDataGridView.TabIndex = 80
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        '
        'AlignmentDataGridViewTextBoxColumn
        '
        Me.AlignmentDataGridViewTextBoxColumn.DataPropertyName = "Alignment"
        Me.AlignmentDataGridViewTextBoxColumn.HeaderText = "Alignment"
        Me.AlignmentDataGridViewTextBoxColumn.Name = "AlignmentDataGridViewTextBoxColumn"
        '
        'Intelligence
        '
        Me.Intelligence.DataPropertyName = "Intelligence"
        Me.Intelligence.HeaderText = "Intelligence"
        Me.Intelligence.Name = "Intelligence"
        Me.Intelligence.Visible = False
        '
        'Strength
        '
        Me.Strength.DataPropertyName = "Strength"
        Me.Strength.HeaderText = "Strength"
        Me.Strength.Name = "Strength"
        Me.Strength.Visible = False
        '
        'Speed
        '
        Me.Speed.DataPropertyName = "Speed"
        Me.Speed.HeaderText = "Speed"
        Me.Speed.Name = "Speed"
        Me.Speed.Visible = False
        '
        'Durability
        '
        Me.Durability.DataPropertyName = "Durability"
        Me.Durability.HeaderText = "Durability"
        Me.Durability.Name = "Durability"
        Me.Durability.Visible = False
        '
        'FightingSkill
        '
        Me.FightingSkill.DataPropertyName = "FightingSkill"
        Me.FightingSkill.HeaderText = "FightingSkill"
        Me.FightingSkill.Name = "FightingSkill"
        Me.FightingSkill.Visible = False
        '
        'EnergyProjection
        '
        Me.EnergyProjection.DataPropertyName = "EnergyProjection"
        Me.EnergyProjection.HeaderText = "EnergyProjection"
        Me.EnergyProjection.Name = "EnergyProjection"
        Me.EnergyProjection.Visible = False
        '
        'RegistrationBindingSource
        '
        Me.RegistrationBindingSource.DataMember = "Registration"
        Me.RegistrationBindingSource.DataSource = Me.RegistrationDatabaseDataSet
        '
        'RegistrationDatabaseDataSet
        '
        Me.RegistrationDatabaseDataSet.DataSetName = "RegistrationDatabaseDataSet"
        Me.RegistrationDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnDelete
        '
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Location = New System.Drawing.Point(273, 32)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(89, 25)
        Me.btnDelete.TabIndex = 81
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Location = New System.Drawing.Point(368, 32)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(89, 25)
        Me.btnSave.TabIndex = 79
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Location = New System.Drawing.Point(178, 32)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(89, 25)
        Me.btnAdd.TabIndex = 78
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Location = New System.Drawing.Point(124, 13)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 77
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.LightGray
        Me.TextBox1.Location = New System.Drawing.Point(205, 13)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(299, 20)
        Me.TextBox1.TabIndex = 76
        '
        'Button3
        '
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(260, 299)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(160, 23)
        Me.Button3.TabIndex = 69
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(260, 267)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(80, 32)
        Me.Button4.TabIndex = 68
        Me.Button4.Text = "From Com"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(23, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(28, 13)
        Me.Label8.TabIndex = 85
        Me.Label8.Text = "Files"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(68, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 13)
        Me.Label7.TabIndex = 84
        Me.Label7.Text = "0"
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
        'IDLabel1
        '
        Me.IDLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistrationBindingSource, "ID", True))
        Me.IDLabel1.Location = New System.Drawing.Point(127, 59)
        Me.IDLabel1.Name = "IDLabel1"
        Me.IDLabel1.Size = New System.Drawing.Size(124, 23)
        Me.IDLabel1.TabIndex = 86
        Me.IDLabel1.Text = "---------"
        '
        'NameTextBox
        '
        Me.NameTextBox.BackColor = System.Drawing.Color.LightGray
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistrationBindingSource, "Name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(130, 85)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(121, 20)
        Me.NameTextBox.TabIndex = 87
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.BackColor = System.Drawing.Color.LightGray
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistrationBindingSource, "FirstName", True))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(130, 112)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(121, 20)
        Me.FirstNameTextBox.TabIndex = 88
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.BackColor = System.Drawing.Color.LightGray
        Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistrationBindingSource, "LastName", True))
        Me.LastNameTextBox.Location = New System.Drawing.Point(130, 137)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(121, 20)
        Me.LastNameTextBox.TabIndex = 89
        '
        'AlignmentComboBox
        '
        Me.AlignmentComboBox.BackColor = System.Drawing.Color.LightGray
        Me.AlignmentComboBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AlignmentComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistrationBindingSource, "Alignment", True))
        Me.AlignmentComboBox.FormattingEnabled = True
        Me.AlignmentComboBox.Items.AddRange(New Object() {"Good", "Bad", "Neutral"})
        Me.AlignmentComboBox.Location = New System.Drawing.Point(130, 163)
        Me.AlignmentComboBox.Name = "AlignmentComboBox"
        Me.AlignmentComboBox.Size = New System.Drawing.Size(121, 21)
        Me.AlignmentComboBox.TabIndex = 90
        '
        'IntelligenceTrackBar
        '
        Me.IntelligenceTrackBar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IntelligenceTrackBar.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.RegistrationBindingSource, "Intelligence", True))
        Me.IntelligenceTrackBar.LargeChange = 1
        Me.IntelligenceTrackBar.Location = New System.Drawing.Point(144, 16)
        Me.IntelligenceTrackBar.Maximum = 7
        Me.IntelligenceTrackBar.Name = "IntelligenceTrackBar"
        Me.IntelligenceTrackBar.Size = New System.Drawing.Size(109, 42)
        Me.IntelligenceTrackBar.TabIndex = 93
        '
        'StrengthTrackBar
        '
        Me.StrengthTrackBar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.StrengthTrackBar.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.RegistrationBindingSource, "Strength", True))
        Me.StrengthTrackBar.LargeChange = 1
        Me.StrengthTrackBar.Location = New System.Drawing.Point(144, 64)
        Me.StrengthTrackBar.Maximum = 7
        Me.StrengthTrackBar.Name = "StrengthTrackBar"
        Me.StrengthTrackBar.Size = New System.Drawing.Size(109, 42)
        Me.StrengthTrackBar.TabIndex = 94
        '
        'SpeedTrackBar
        '
        Me.SpeedTrackBar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SpeedTrackBar.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.RegistrationBindingSource, "Speed", True))
        Me.SpeedTrackBar.LargeChange = 1
        Me.SpeedTrackBar.Location = New System.Drawing.Point(144, 112)
        Me.SpeedTrackBar.Maximum = 7
        Me.SpeedTrackBar.Name = "SpeedTrackBar"
        Me.SpeedTrackBar.Size = New System.Drawing.Size(109, 42)
        Me.SpeedTrackBar.TabIndex = 95
        '
        'DurabilityTrackBar
        '
        Me.DurabilityTrackBar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DurabilityTrackBar.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.RegistrationBindingSource, "Durability", True))
        Me.DurabilityTrackBar.LargeChange = 1
        Me.DurabilityTrackBar.Location = New System.Drawing.Point(144, 158)
        Me.DurabilityTrackBar.Maximum = 7
        Me.DurabilityTrackBar.Name = "DurabilityTrackBar"
        Me.DurabilityTrackBar.Size = New System.Drawing.Size(109, 42)
        Me.DurabilityTrackBar.TabIndex = 96
        '
        'FightingSkillTrackBar
        '
        Me.FightingSkillTrackBar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FightingSkillTrackBar.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.RegistrationBindingSource, "FightingSkill", True))
        Me.FightingSkillTrackBar.LargeChange = 1
        Me.FightingSkillTrackBar.Location = New System.Drawing.Point(144, 203)
        Me.FightingSkillTrackBar.Maximum = 7
        Me.FightingSkillTrackBar.Name = "FightingSkillTrackBar"
        Me.FightingSkillTrackBar.Size = New System.Drawing.Size(109, 42)
        Me.FightingSkillTrackBar.TabIndex = 97
        '
        'EnergyProjectionTrackBar
        '
        Me.EnergyProjectionTrackBar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EnergyProjectionTrackBar.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.RegistrationBindingSource, "EnergyProjection", True))
        Me.EnergyProjectionTrackBar.LargeChange = 1
        Me.EnergyProjectionTrackBar.Location = New System.Drawing.Point(144, 251)
        Me.EnergyProjectionTrackBar.Maximum = 7
        Me.EnergyProjectionTrackBar.Name = "EnergyProjectionTrackBar"
        Me.EnergyProjectionTrackBar.Size = New System.Drawing.Size(109, 42)
        Me.EnergyProjectionTrackBar.TabIndex = 98
        '
        'lblIntel
        '
        Me.lblIntel.AutoSize = True
        Me.lblIntel.Location = New System.Drawing.Point(124, 16)
        Me.lblIntel.Name = "lblIntel"
        Me.lblIntel.Size = New System.Drawing.Size(13, 13)
        Me.lblIntel.TabIndex = 99
        Me.lblIntel.Text = "0"
        '
        'lblStr
        '
        Me.lblStr.AutoSize = True
        Me.lblStr.Location = New System.Drawing.Point(124, 68)
        Me.lblStr.Name = "lblStr"
        Me.lblStr.Size = New System.Drawing.Size(13, 13)
        Me.lblStr.TabIndex = 100
        Me.lblStr.Text = "0"
        '
        'lblSpe
        '
        Me.lblSpe.AutoSize = True
        Me.lblSpe.Location = New System.Drawing.Point(124, 112)
        Me.lblSpe.Name = "lblSpe"
        Me.lblSpe.Size = New System.Drawing.Size(13, 13)
        Me.lblSpe.TabIndex = 101
        Me.lblSpe.Text = "0"
        '
        'lblDur
        '
        Me.lblDur.AutoSize = True
        Me.lblDur.Location = New System.Drawing.Point(124, 158)
        Me.lblDur.Name = "lblDur"
        Me.lblDur.Size = New System.Drawing.Size(13, 13)
        Me.lblDur.TabIndex = 102
        Me.lblDur.Text = "0"
        '
        'lblFS
        '
        Me.lblFS.AutoSize = True
        Me.lblFS.Location = New System.Drawing.Point(124, 203)
        Me.lblFS.Name = "lblFS"
        Me.lblFS.Size = New System.Drawing.Size(13, 13)
        Me.lblFS.TabIndex = 103
        Me.lblFS.Text = "0"
        '
        'lblEP
        '
        Me.lblEP.AutoSize = True
        Me.lblEP.Location = New System.Drawing.Point(125, 251)
        Me.lblEP.Name = "lblEP"
        Me.lblEP.Size = New System.Drawing.Size(13, 13)
        Me.lblEP.TabIndex = 104
        Me.lblEP.Text = "0"
        '
        'btnRandomize
        '
        Me.btnRandomize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRandomize.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRandomize.Location = New System.Drawing.Point(161, 328)
        Me.btnRandomize.Name = "btnRandomize"
        Me.btnRandomize.Size = New System.Drawing.Size(92, 30)
        Me.btnRandomize.TabIndex = 107
        Me.btnRandomize.Text = "Randomize"
        Me.btnRandomize.UseVisualStyleBackColor = True
        '
        'AbilitiesTextBox
        '
        Me.AbilitiesTextBox.BackColor = System.Drawing.Color.LightGray
        Me.AbilitiesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistrationBindingSource, "Abilities", True))
        Me.AbilitiesTextBox.Location = New System.Drawing.Point(9, 212)
        Me.AbilitiesTextBox.Multiline = True
        Me.AbilitiesTextBox.Name = "AbilitiesTextBox"
        Me.AbilitiesTextBox.Size = New System.Drawing.Size(242, 136)
        Me.AbilitiesTextBox.TabIndex = 108
        '
        'btnDone1
        '
        Me.btnDone1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDone1.Location = New System.Drawing.Point(492, 32)
        Me.btnDone1.Name = "btnDone1"
        Me.btnDone1.Size = New System.Drawing.Size(89, 25)
        Me.btnDone1.TabIndex = 109
        Me.btnDone1.Text = "Done"
        Me.btnDone1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(340, 267)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 32)
        Me.Button1.TabIndex = 110
        Me.Button1.Text = "Database"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TeamGroupBox
        '
        Me.TeamGroupBox.Controls.Add(Me.TmLogoPictureBox)
        Me.TeamGroupBox.Controls.Add(Me.TmNameLabel1)
        Me.TeamGroupBox.Controls.Add(Me.BaseGroupBox)
        Me.TeamGroupBox.Controls.Add(Me.btnTeam)
        Me.TeamGroupBox.Location = New System.Drawing.Point(700, 19)
        Me.TeamGroupBox.Name = "TeamGroupBox"
        Me.TeamGroupBox.Size = New System.Drawing.Size(362, 364)
        Me.TeamGroupBox.TabIndex = 113
        Me.TeamGroupBox.TabStop = False
        Me.TeamGroupBox.Text = "Team"
        '
        'TmLogoPictureBox
        '
        Me.TmLogoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TmLogoPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.RegistrationBindingSource, "TmLogo", True))
        Me.TmLogoPictureBox.Location = New System.Drawing.Point(20, 16)
        Me.TmLogoPictureBox.Name = "TmLogoPictureBox"
        Me.TmLogoPictureBox.Size = New System.Drawing.Size(119, 122)
        Me.TmLogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TmLogoPictureBox.TabIndex = 117
        Me.TmLogoPictureBox.TabStop = False
        '
        'TmNameLabel1
        '
        Me.TmNameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistrationBindingSource, "TmName", True))
        Me.TmNameLabel1.Location = New System.Drawing.Point(145, 16)
        Me.TmNameLabel1.Name = "TmNameLabel1"
        Me.TmNameLabel1.Size = New System.Drawing.Size(100, 23)
        Me.TmNameLabel1.TabIndex = 116
        Me.TmNameLabel1.Text = "Label1"
        '
        'BaseGroupBox
        '
        Me.BaseGroupBox.Controls.Add(Me.BaseImagePictureBox)
        Me.BaseGroupBox.Controls.Add(BaseCityLabel)
        Me.BaseGroupBox.Controls.Add(Me.BaseCityLabel1)
        Me.BaseGroupBox.Controls.Add(BaseStateLabel)
        Me.BaseGroupBox.Controls.Add(Me.BaseStateLabel1)
        Me.BaseGroupBox.Controls.Add(BaseCountryLabel)
        Me.BaseGroupBox.Controls.Add(Me.BaseCountryLabel1)
        Me.BaseGroupBox.Controls.Add(BasePlanetLabel)
        Me.BaseGroupBox.Controls.Add(Me.BasePlanetLabel1)
        Me.BaseGroupBox.Controls.Add(BaseNameLabel)
        Me.BaseGroupBox.Controls.Add(Me.BaseNameLabel1)
        Me.BaseGroupBox.Location = New System.Drawing.Point(14, 152)
        Me.BaseGroupBox.Name = "BaseGroupBox"
        Me.BaseGroupBox.Size = New System.Drawing.Size(342, 171)
        Me.BaseGroupBox.TabIndex = 115
        Me.BaseGroupBox.TabStop = False
        Me.BaseGroupBox.Text = "Base of Operations"
        '
        'BaseImagePictureBox
        '
        Me.BaseImagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BaseImagePictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.RegistrationBindingSource, "BaseImage", True))
        Me.BaseImagePictureBox.Location = New System.Drawing.Point(6, 19)
        Me.BaseImagePictureBox.Name = "BaseImagePictureBox"
        Me.BaseImagePictureBox.Size = New System.Drawing.Size(119, 125)
        Me.BaseImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BaseImagePictureBox.TabIndex = 11
        Me.BaseImagePictureBox.TabStop = False
        '
        'BaseCityLabel1
        '
        Me.BaseCityLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistrationBindingSource, "BaseCity", True))
        Me.BaseCityLabel1.Location = New System.Drawing.Point(183, 106)
        Me.BaseCityLabel1.Name = "BaseCityLabel1"
        Me.BaseCityLabel1.Size = New System.Drawing.Size(100, 23)
        Me.BaseCityLabel1.TabIndex = 9
        Me.BaseCityLabel1.Text = "Label1"
        '
        'BaseStateLabel1
        '
        Me.BaseStateLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistrationBindingSource, "BaseState", True))
        Me.BaseStateLabel1.Location = New System.Drawing.Point(183, 83)
        Me.BaseStateLabel1.Name = "BaseStateLabel1"
        Me.BaseStateLabel1.Size = New System.Drawing.Size(100, 23)
        Me.BaseStateLabel1.TabIndex = 7
        Me.BaseStateLabel1.Text = "Label1"
        '
        'BaseCountryLabel1
        '
        Me.BaseCountryLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistrationBindingSource, "BaseCountry", True))
        Me.BaseCountryLabel1.Location = New System.Drawing.Point(183, 62)
        Me.BaseCountryLabel1.Name = "BaseCountryLabel1"
        Me.BaseCountryLabel1.Size = New System.Drawing.Size(100, 23)
        Me.BaseCountryLabel1.TabIndex = 5
        Me.BaseCountryLabel1.Text = "Label1"
        '
        'BasePlanetLabel1
        '
        Me.BasePlanetLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistrationBindingSource, "BasePlanet", True))
        Me.BasePlanetLabel1.Location = New System.Drawing.Point(183, 39)
        Me.BasePlanetLabel1.Name = "BasePlanetLabel1"
        Me.BasePlanetLabel1.Size = New System.Drawing.Size(100, 23)
        Me.BasePlanetLabel1.TabIndex = 3
        Me.BasePlanetLabel1.Text = "Label1"
        '
        'BaseNameLabel1
        '
        Me.BaseNameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistrationBindingSource, "BaseName", True))
        Me.BaseNameLabel1.Location = New System.Drawing.Point(183, 15)
        Me.BaseNameLabel1.Name = "BaseNameLabel1"
        Me.BaseNameLabel1.Size = New System.Drawing.Size(100, 23)
        Me.BaseNameLabel1.TabIndex = 1
        Me.BaseNameLabel1.Text = "Label1"
        '
        'btnTeam
        '
        Me.btnTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTeam.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTeam.Location = New System.Drawing.Point(246, 328)
        Me.btnTeam.Name = "btnTeam"
        Me.btnTeam.Size = New System.Drawing.Size(92, 30)
        Me.btnTeam.TabIndex = 113
        Me.btnTeam.Text = "Pick Team"
        Me.btnTeam.UseVisualStyleBackColor = True
        '
        'TeamsBindingSource
        '
        Me.TeamsBindingSource.DataMember = "Teams"
        Me.TeamsBindingSource.DataSource = Me.RegistrationDatabaseDataSet
        '
        'BaseOfOperationsBindingSource
        '
        Me.BaseOfOperationsBindingSource.DataMember = "BaseOfOperations"
        Me.BaseOfOperationsBindingSource.DataSource = Me.RegistrationDatabaseDataSet
        '
        'AttributeGroupBox
        '
        Me.AttributeGroupBox.Controls.Add(IntelligenceLabel)
        Me.AttributeGroupBox.Controls.Add(Me.IntelligenceTrackBar)
        Me.AttributeGroupBox.Controls.Add(Me.StrengthTrackBar)
        Me.AttributeGroupBox.Controls.Add(StrengthLabel)
        Me.AttributeGroupBox.Controls.Add(Me.SpeedTrackBar)
        Me.AttributeGroupBox.Controls.Add(Me.btnRandomize)
        Me.AttributeGroupBox.Controls.Add(SpeedLabel)
        Me.AttributeGroupBox.Controls.Add(Me.DurabilityTrackBar)
        Me.AttributeGroupBox.Controls.Add(DurabilityLabel)
        Me.AttributeGroupBox.Controls.Add(Me.lblEP)
        Me.AttributeGroupBox.Controls.Add(Me.FightingSkillTrackBar)
        Me.AttributeGroupBox.Controls.Add(Me.lblFS)
        Me.AttributeGroupBox.Controls.Add(FightingSkillLabel)
        Me.AttributeGroupBox.Controls.Add(Me.lblDur)
        Me.AttributeGroupBox.Controls.Add(Me.EnergyProjectionTrackBar)
        Me.AttributeGroupBox.Controls.Add(Me.lblSpe)
        Me.AttributeGroupBox.Controls.Add(EnergyProjectionLabel)
        Me.AttributeGroupBox.Controls.Add(Me.lblStr)
        Me.AttributeGroupBox.Controls.Add(Me.lblIntel)
        Me.AttributeGroupBox.Location = New System.Drawing.Point(426, 19)
        Me.AttributeGroupBox.Name = "AttributeGroupBox"
        Me.AttributeGroupBox.Size = New System.Drawing.Size(268, 364)
        Me.AttributeGroupBox.TabIndex = 114
        Me.AttributeGroupBox.TabStop = False
        Me.AttributeGroupBox.Text = "Character Attributes"
        '
        'CharacterGroupBox
        '
        Me.CharacterGroupBox.Controls.Add(ImageLabel)
        Me.CharacterGroupBox.Controls.Add(Me.TeamGroupBox)
        Me.CharacterGroupBox.Controls.Add(Me.AbilitiesTextBox)
        Me.CharacterGroupBox.Controls.Add(Me.AttributeGroupBox)
        Me.CharacterGroupBox.Controls.Add(Me.Button4)
        Me.CharacterGroupBox.Controls.Add(Me.Button3)
        Me.CharacterGroupBox.Controls.Add(AbilitiesLabel)
        Me.CharacterGroupBox.Controls.Add(Me.Button1)
        Me.CharacterGroupBox.Controls.Add(Me.ImagePictureBox)
        Me.CharacterGroupBox.Controls.Add(IDLabel)
        Me.CharacterGroupBox.Controls.Add(Me.IDLabel1)
        Me.CharacterGroupBox.Controls.Add(Me.NameTextBox)
        Me.CharacterGroupBox.Controls.Add(AlignmentLabel)
        Me.CharacterGroupBox.Controls.Add(NameLabel)
        Me.CharacterGroupBox.Controls.Add(Me.AlignmentComboBox)
        Me.CharacterGroupBox.Controls.Add(Me.FirstNameTextBox)
        Me.CharacterGroupBox.Controls.Add(LastNameLabel)
        Me.CharacterGroupBox.Controls.Add(FirstNameLabel)
        Me.CharacterGroupBox.Controls.Add(Me.LastNameTextBox)
        Me.CharacterGroupBox.Location = New System.Drawing.Point(16, 63)
        Me.CharacterGroupBox.Name = "CharacterGroupBox"
        Me.CharacterGroupBox.Size = New System.Drawing.Size(1068, 389)
        Me.CharacterGroupBox.TabIndex = 115
        Me.CharacterGroupBox.TabStop = False
        Me.CharacterGroupBox.Text = "Character"
        '
        'ImagePictureBox
        '
        Me.ImagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ImagePictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.RegistrationBindingSource, "Image", True))
        Me.ImagePictureBox.Location = New System.Drawing.Point(264, 59)
        Me.ImagePictureBox.Name = "ImagePictureBox"
        Me.ImagePictureBox.Size = New System.Drawing.Size(150, 200)
        Me.ImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImagePictureBox.TabIndex = 91
        Me.ImagePictureBox.TabStop = False
        '
        'BaseOfOperationsTableAdapter
        '
        Me.BaseOfOperationsTableAdapter.ClearBeforeFill = True
        '
        'TeamsTableAdapter
        '
        Me.TeamsTableAdapter.ClearBeforeFill = True
        '
        'SearchGroupBox
        '
        Me.SearchGroupBox.Controls.Add(Me.RegistrationDataGridView)
        Me.SearchGroupBox.Controls.Add(Me.Label8)
        Me.SearchGroupBox.Controls.Add(Me.Label7)
        Me.SearchGroupBox.Controls.Add(Me.TextBox1)
        Me.SearchGroupBox.Controls.Add(Me.btnSearch)
        Me.SearchGroupBox.Location = New System.Drawing.Point(16, 458)
        Me.SearchGroupBox.Name = "SearchGroupBox"
        Me.SearchGroupBox.Size = New System.Drawing.Size(1062, 207)
        Me.SearchGroupBox.TabIndex = 116
        Me.SearchGroupBox.TabStop = False
        Me.SearchGroupBox.Text = "Search Records"
        '
        'Panel4
        '
        Me.Panel4.BackgroundImage = CType(resources.GetObject("Panel4.BackgroundImage"), System.Drawing.Image)
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(1093, 26)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(3, 645)
        Me.Panel4.TabIndex = 106
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = Global.HerosVillianRegistration.My.Resources.Resources.FormHeader2BlueGradiant
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 26)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(3, 645)
        Me.Panel3.TabIndex = 105
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 671)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1096, 23)
        Me.Panel2.TabIndex = 3
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
        Me.Panel1.Size = New System.Drawing.Size(1096, 26)
        Me.Panel1.TabIndex = 2
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Gray
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(1048, 0)
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
        Me.btnMinimize.Location = New System.Drawing.Point(1010, 0)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(33, 23)
        Me.btnMinimize.TabIndex = 1
        Me.btnMinimize.Text = "-"
        Me.btnMinimize.UseVisualStyleBackColor = False
        '
        'RegistrationForm2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(1096, 694)
        Me.Controls.Add(Me.SearchGroupBox)
        Me.Controls.Add(Me.CharacterGroupBox)
        Me.Controls.Add(Me.btnDone1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.btnNext2)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnPrevious2)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RegistrationForm2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RegistrationForm2"
        Me.TransparencyKey = System.Drawing.Color.SaddleBrown
        CType(Me.RegistrationDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegistrationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegistrationDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IntelligenceTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StrengthTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpeedTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DurabilityTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FightingSkillTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnergyProjectionTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TeamGroupBox.ResumeLayout(False)
        CType(Me.TmLogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BaseGroupBox.ResumeLayout(False)
        Me.BaseGroupBox.PerformLayout()
        CType(Me.BaseImagePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TeamsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BaseOfOperationsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AttributeGroupBox.ResumeLayout(False)
        Me.AttributeGroupBox.PerformLayout()
        Me.CharacterGroupBox.ResumeLayout(False)
        Me.CharacterGroupBox.PerformLayout()
        CType(Me.ImagePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SearchGroupBox.ResumeLayout(False)
        Me.SearchGroupBox.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnMinimize As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnNext2 As System.Windows.Forms.Button
    Friend WithEvents btnPrevious2 As System.Windows.Forms.Button
    Friend WithEvents RegistrationDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents RegistrationDatabaseDataSet As HerosVillianRegistration.RegistrationDatabaseDataSet
    Friend WithEvents RegistrationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RegistrationTableAdapter As HerosVillianRegistration.RegistrationDatabaseDataSetTableAdapters.RegistrationTableAdapter
    Friend WithEvents TableAdapterManager As HerosVillianRegistration.RegistrationDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IDLabel1 As System.Windows.Forms.Label
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FirstNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LastNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AlignmentComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ImagePictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents IntelligenceTrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents StrengthTrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents SpeedTrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents DurabilityTrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents FightingSkillTrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents EnergyProjectionTrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents lblIntel As System.Windows.Forms.Label
    Friend WithEvents lblStr As System.Windows.Forms.Label
    Friend WithEvents lblSpe As System.Windows.Forms.Label
    Friend WithEvents lblDur As System.Windows.Forms.Label
    Friend WithEvents lblFS As System.Windows.Forms.Label
    Friend WithEvents lblEP As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnRandomize As System.Windows.Forms.Button
    Friend WithEvents AbilitiesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnDone1 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AlignmentDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Intelligence As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Strength As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Speed As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Durability As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FightingSkill As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EnergyProjection As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TeamGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents AttributeGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents CharacterGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents BaseGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents BaseOfOperationsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BaseOfOperationsTableAdapter As HerosVillianRegistration.RegistrationDatabaseDataSetTableAdapters.BaseOfOperationsTableAdapter
    Friend WithEvents btnTeam As System.Windows.Forms.Button
    Friend WithEvents TeamsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TeamsTableAdapter As HerosVillianRegistration.RegistrationDatabaseDataSetTableAdapters.TeamsTableAdapter
    Friend WithEvents SearchGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents TmLogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents TmNameLabel1 As System.Windows.Forms.Label
    Friend WithEvents BaseImagePictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents BaseCityLabel1 As System.Windows.Forms.Label
    Friend WithEvents BaseStateLabel1 As System.Windows.Forms.Label
    Friend WithEvents BaseCountryLabel1 As System.Windows.Forms.Label
    Friend WithEvents BasePlanetLabel1 As System.Windows.Forms.Label
    Friend WithEvents BaseNameLabel1 As System.Windows.Forms.Label
End Class
