<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm2
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
        Dim AbilitiesLabel As System.Windows.Forms.Label
        Dim TmNameLabel As System.Windows.Forms.Label
        Dim BaseNameLabel As System.Windows.Forms.Label
        Dim BasePlanetLabel As System.Windows.Forms.Label
        Dim BaseCountryLabel As System.Windows.Forms.Label
        Dim BaseStateLabel As System.Windows.Forms.Label
        Dim BaseCityLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm2))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegisterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BaseOfOperationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TeamsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewRegistryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CharacterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TeamsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TmName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Alignment = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegistrationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RegistrationDatabaseDataSet = New HerosVillianRegistration.RegistrationDatabaseDataSet()
        Me.RegistrationTableAdapter = New HerosVillianRegistration.RegistrationDatabaseDataSetTableAdapters.RegistrationTableAdapter()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.tbseach2 = New System.Windows.Forms.TextBox()
        Me.EnergyProjectionLabel2 = New System.Windows.Forms.Label()
        Me.FightingSkillLabel2 = New System.Windows.Forms.Label()
        Me.DurabilityLabel2 = New System.Windows.Forms.Label()
        Me.SpeedLabel2 = New System.Windows.Forms.Label()
        Me.StrengthLabel2 = New System.Windows.Forms.Label()
        Me.IntelligenceLabel2 = New System.Windows.Forms.Label()
        Me.NameLabel1 = New System.Windows.Forms.Label()
        Me.FirstNameLabel1 = New System.Windows.Forms.Label()
        Me.LastNameLabel1 = New System.Windows.Forms.Label()
        Me.AlignmentLabel1 = New System.Windows.Forms.Label()
        Me.ImagePictureBox = New System.Windows.Forms.PictureBox()
        Me.IntelligenceProgressBar = New System.Windows.Forms.ProgressBar()
        Me.StrengthProgressBar = New System.Windows.Forms.ProgressBar()
        Me.SpeedProgressBar = New System.Windows.Forms.ProgressBar()
        Me.DurabilityProgressBar = New System.Windows.Forms.ProgressBar()
        Me.FightingSkillProgressBar = New System.Windows.Forms.ProgressBar()
        Me.EnergyProjectionProgressBar = New System.Windows.Forms.ProgressBar()
        Me.AbilitiesTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.CharacterGroupBox = New System.Windows.Forms.GroupBox()
        Me.TeamGroupBox = New System.Windows.Forms.GroupBox()
        Me.BaseGroupBox = New System.Windows.Forms.GroupBox()
        Me.BaseCityLabel1 = New System.Windows.Forms.Label()
        Me.BaseStateLabel1 = New System.Windows.Forms.Label()
        Me.BaseCountryLabel1 = New System.Windows.Forms.Label()
        Me.BasePlanetLabel1 = New System.Windows.Forms.Label()
        Me.BaseNameLabel1 = New System.Windows.Forms.Label()
        Me.BaseImagePictureBox = New System.Windows.Forms.PictureBox()
        Me.TmLogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.TmNameLabel1 = New System.Windows.Forms.Label()
        Me.TableAdapterManager = New HerosVillianRegistration.RegistrationDatabaseDataSetTableAdapters.TableAdapterManager()
        FirstNameLabel = New System.Windows.Forms.Label()
        LastNameLabel = New System.Windows.Forms.Label()
        AlignmentLabel = New System.Windows.Forms.Label()
        IntelligenceLabel = New System.Windows.Forms.Label()
        StrengthLabel = New System.Windows.Forms.Label()
        SpeedLabel = New System.Windows.Forms.Label()
        DurabilityLabel = New System.Windows.Forms.Label()
        FightingSkillLabel = New System.Windows.Forms.Label()
        EnergyProjectionLabel = New System.Windows.Forms.Label()
        AbilitiesLabel = New System.Windows.Forms.Label()
        TmNameLabel = New System.Windows.Forms.Label()
        BaseNameLabel = New System.Windows.Forms.Label()
        BasePlanetLabel = New System.Windows.Forms.Label()
        BaseCountryLabel = New System.Windows.Forms.Label()
        BaseStateLabel = New System.Windows.Forms.Label()
        BaseCityLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegistrationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegistrationDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImagePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.CharacterGroupBox.SuspendLayout()
        Me.TeamGroupBox.SuspendLayout()
        Me.BaseGroupBox.SuspendLayout()
        CType(Me.BaseImagePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TmLogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Location = New System.Drawing.Point(172, 24)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(60, 13)
        FirstNameLabel.TabIndex = 68
        FirstNameLabel.Text = "First Name:"
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Location = New System.Drawing.Point(172, 47)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(61, 13)
        LastNameLabel.TabIndex = 70
        LastNameLabel.Text = "Last Name:"
        '
        'AlignmentLabel
        '
        AlignmentLabel.AutoSize = True
        AlignmentLabel.Location = New System.Drawing.Point(172, 70)
        AlignmentLabel.Name = "AlignmentLabel"
        AlignmentLabel.Size = New System.Drawing.Size(56, 13)
        AlignmentLabel.TabIndex = 72
        AlignmentLabel.Text = "Alignment:"
        '
        'IntelligenceLabel
        '
        IntelligenceLabel.AutoSize = True
        IntelligenceLabel.Location = New System.Drawing.Point(172, 104)
        IntelligenceLabel.Name = "IntelligenceLabel"
        IntelligenceLabel.Size = New System.Drawing.Size(64, 13)
        IntelligenceLabel.TabIndex = 75
        IntelligenceLabel.Text = "Intelligence:"
        '
        'StrengthLabel
        '
        StrengthLabel.AutoSize = True
        StrengthLabel.Location = New System.Drawing.Point(172, 133)
        StrengthLabel.Name = "StrengthLabel"
        StrengthLabel.Size = New System.Drawing.Size(50, 13)
        StrengthLabel.TabIndex = 77
        StrengthLabel.Text = "Strength:"
        '
        'SpeedLabel
        '
        SpeedLabel.AutoSize = True
        SpeedLabel.Location = New System.Drawing.Point(172, 162)
        SpeedLabel.Name = "SpeedLabel"
        SpeedLabel.Size = New System.Drawing.Size(41, 13)
        SpeedLabel.TabIndex = 79
        SpeedLabel.Text = "Speed:"
        '
        'DurabilityLabel
        '
        DurabilityLabel.AutoSize = True
        DurabilityLabel.Location = New System.Drawing.Point(172, 191)
        DurabilityLabel.Name = "DurabilityLabel"
        DurabilityLabel.Size = New System.Drawing.Size(53, 13)
        DurabilityLabel.TabIndex = 81
        DurabilityLabel.Text = "Durability:"
        '
        'FightingSkillLabel
        '
        FightingSkillLabel.AutoSize = True
        FightingSkillLabel.Location = New System.Drawing.Point(172, 220)
        FightingSkillLabel.Name = "FightingSkillLabel"
        FightingSkillLabel.Size = New System.Drawing.Size(69, 13)
        FightingSkillLabel.TabIndex = 83
        FightingSkillLabel.Text = "Fighting Skill:"
        '
        'EnergyProjectionLabel
        '
        EnergyProjectionLabel.AutoSize = True
        EnergyProjectionLabel.Location = New System.Drawing.Point(172, 249)
        EnergyProjectionLabel.Name = "EnergyProjectionLabel"
        EnergyProjectionLabel.Size = New System.Drawing.Size(93, 13)
        EnergyProjectionLabel.TabIndex = 85
        EnergyProjectionLabel.Text = "Energy Projection:"
        '
        'AbilitiesLabel
        '
        AbilitiesLabel.AutoSize = True
        AbilitiesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AbilitiesLabel.Location = New System.Drawing.Point(15, 287)
        AbilitiesLabel.Name = "AbilitiesLabel"
        AbilitiesLabel.Size = New System.Drawing.Size(77, 20)
        AbilitiesLabel.TabIndex = 93
        AbilitiesLabel.Text = "Abilities:"
        '
        'TmNameLabel
        '
        TmNameLabel.AutoSize = True
        TmNameLabel.Location = New System.Drawing.Point(150, 21)
        TmNameLabel.Name = "TmNameLabel"
        TmNameLabel.Size = New System.Drawing.Size(37, 13)
        TmNameLabel.TabIndex = 94
        TmNameLabel.Text = "Team:"
        '
        'BaseNameLabel
        '
        BaseNameLabel.AutoSize = True
        BaseNameLabel.Location = New System.Drawing.Point(188, 29)
        BaseNameLabel.Name = "BaseNameLabel"
        BaseNameLabel.Size = New System.Drawing.Size(34, 13)
        BaseNameLabel.TabIndex = 1
        BaseNameLabel.Text = "Base:"
        '
        'BasePlanetLabel
        '
        BasePlanetLabel.AutoSize = True
        BasePlanetLabel.Location = New System.Drawing.Point(188, 64)
        BasePlanetLabel.Name = "BasePlanetLabel"
        BasePlanetLabel.Size = New System.Drawing.Size(40, 13)
        BasePlanetLabel.TabIndex = 3
        BasePlanetLabel.Text = "Planet:"
        '
        'BaseCountryLabel
        '
        BaseCountryLabel.AutoSize = True
        BaseCountryLabel.Location = New System.Drawing.Point(188, 99)
        BaseCountryLabel.Name = "BaseCountryLabel"
        BaseCountryLabel.Size = New System.Drawing.Size(46, 13)
        BaseCountryLabel.TabIndex = 5
        BaseCountryLabel.Text = "Country:"
        '
        'BaseStateLabel
        '
        BaseStateLabel.AutoSize = True
        BaseStateLabel.Location = New System.Drawing.Point(188, 134)
        BaseStateLabel.Name = "BaseStateLabel"
        BaseStateLabel.Size = New System.Drawing.Size(35, 13)
        BaseStateLabel.TabIndex = 7
        BaseStateLabel.Text = "State:"
        '
        'BaseCityLabel
        '
        BaseCityLabel.AutoSize = True
        BaseCityLabel.Location = New System.Drawing.Point(188, 169)
        BaseCityLabel.Name = "BaseCityLabel"
        BaseCityLabel.Size = New System.Drawing.Size(27, 13)
        BaseCityLabel.TabIndex = 9
        BaseCityLabel.Text = "City:"
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.HerosVillianRegistration.My.Resources.Resources.FormFooterrBlueGradiant
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 701)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(895, 23)
        Me.Panel2.TabIndex = 1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Gray
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.RegisterToolStripMenuItem, Me.TestToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(9, 29)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(340, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(36, 20)
        Me.ToolStripMenuItem1.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'RegisterToolStripMenuItem
        '
        Me.RegisterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImageDatabaseToolStripMenuItem, Me.BaseOfOperationsToolStripMenuItem, Me.TeamsToolStripMenuItem, Me.NewRegistryToolStripMenuItem})
        Me.RegisterToolStripMenuItem.Name = "RegisterToolStripMenuItem"
        Me.RegisterToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.RegisterToolStripMenuItem.Text = "Edit"
        '
        'ImageDatabaseToolStripMenuItem
        '
        Me.ImageDatabaseToolStripMenuItem.Name = "ImageDatabaseToolStripMenuItem"
        Me.ImageDatabaseToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.ImageDatabaseToolStripMenuItem.Text = "Image Database"
        '
        'BaseOfOperationsToolStripMenuItem
        '
        Me.BaseOfOperationsToolStripMenuItem.Name = "BaseOfOperationsToolStripMenuItem"
        Me.BaseOfOperationsToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.BaseOfOperationsToolStripMenuItem.Text = "Base of Operations"
        '
        'TeamsToolStripMenuItem
        '
        Me.TeamsToolStripMenuItem.Name = "TeamsToolStripMenuItem"
        Me.TeamsToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.TeamsToolStripMenuItem.Text = "Teams"
        '
        'NewRegistryToolStripMenuItem
        '
        Me.NewRegistryToolStripMenuItem.Name = "NewRegistryToolStripMenuItem"
        Me.NewRegistryToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.NewRegistryToolStripMenuItem.Text = "New Character"
        '
        'TestToolStripMenuItem
        '
        Me.TestToolStripMenuItem.Name = "TestToolStripMenuItem"
        Me.TestToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.TestToolStripMenuItem.Text = "Analyze"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CharacterToolStripMenuItem, Me.TeamsToolStripMenuItem1})
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'CharacterToolStripMenuItem
        '
        Me.CharacterToolStripMenuItem.Name = "CharacterToolStripMenuItem"
        Me.CharacterToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.CharacterToolStripMenuItem.Text = "Character"
        '
        'TeamsToolStripMenuItem1
        '
        Me.TeamsToolStripMenuItem1.Name = "TeamsToolStripMenuItem1"
        Me.TeamsToolStripMenuItem1.Size = New System.Drawing.Size(126, 22)
        Me.TeamsToolStripMenuItem1.Text = "Teams"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.LightGray
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NameDataGridViewTextBoxColumn, Me.TmName, Me.Alignment})
        Me.DataGridView1.DataSource = Me.RegistrationBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(15, 488)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(868, 207)
        Me.DataGridView1.TabIndex = 8
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.FillWeight = 200.0!
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TmName
        '
        Me.TmName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TmName.DataPropertyName = "TmName"
        Me.TmName.HeaderText = "TeamName"
        Me.TmName.Name = "TmName"
        Me.TmName.ReadOnly = True
        '
        'Alignment
        '
        Me.Alignment.DataPropertyName = "Alignment"
        Me.Alignment.FillWeight = 200.0!
        Me.Alignment.HeaderText = "Alignment"
        Me.Alignment.Name = "Alignment"
        Me.Alignment.ReadOnly = True
        Me.Alignment.Width = 150
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
        'RegistrationTableAdapter
        '
        Me.RegistrationTableAdapter.ClearBeforeFill = True
        '
        'btnSearch
        '
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Location = New System.Drawing.Point(337, 32)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 25)
        Me.btnSearch.TabIndex = 9
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrevious.Location = New System.Drawing.Point(766, 32)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(31, 24)
        Me.btnPrevious.TabIndex = 38
        Me.btnPrevious.Text = "<"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.Location = New System.Drawing.Point(803, 32)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(31, 24)
        Me.btnNext.TabIndex = 39
        Me.btnNext.Text = ">"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'tbseach2
        '
        Me.tbseach2.BackColor = System.Drawing.Color.LightGray
        Me.tbseach2.Location = New System.Drawing.Point(428, 32)
        Me.tbseach2.Multiline = True
        Me.tbseach2.Name = "tbseach2"
        Me.tbseach2.Size = New System.Drawing.Size(332, 24)
        Me.tbseach2.TabIndex = 40
        '
        'EnergyProjectionLabel2
        '
        Me.EnergyProjectionLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistrationBindingSource, "EnergyProjection", True))
        Me.EnergyProjectionLabel2.Location = New System.Drawing.Point(276, 249)
        Me.EnergyProjectionLabel2.Name = "EnergyProjectionLabel2"
        Me.EnergyProjectionLabel2.Size = New System.Drawing.Size(34, 23)
        Me.EnergyProjectionLabel2.TabIndex = 92
        Me.EnergyProjectionLabel2.Text = "0"
        '
        'FightingSkillLabel2
        '
        Me.FightingSkillLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistrationBindingSource, "FightingSkill", True))
        Me.FightingSkillLabel2.Location = New System.Drawing.Point(276, 220)
        Me.FightingSkillLabel2.Name = "FightingSkillLabel2"
        Me.FightingSkillLabel2.Size = New System.Drawing.Size(34, 23)
        Me.FightingSkillLabel2.TabIndex = 91
        Me.FightingSkillLabel2.Text = "0"
        '
        'DurabilityLabel2
        '
        Me.DurabilityLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistrationBindingSource, "Durability", True))
        Me.DurabilityLabel2.Location = New System.Drawing.Point(276, 191)
        Me.DurabilityLabel2.Name = "DurabilityLabel2"
        Me.DurabilityLabel2.Size = New System.Drawing.Size(34, 23)
        Me.DurabilityLabel2.TabIndex = 90
        Me.DurabilityLabel2.Text = "0"
        '
        'SpeedLabel2
        '
        Me.SpeedLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistrationBindingSource, "Speed", True))
        Me.SpeedLabel2.Location = New System.Drawing.Point(276, 162)
        Me.SpeedLabel2.Name = "SpeedLabel2"
        Me.SpeedLabel2.Size = New System.Drawing.Size(34, 23)
        Me.SpeedLabel2.TabIndex = 89
        Me.SpeedLabel2.Text = "0"
        '
        'StrengthLabel2
        '
        Me.StrengthLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistrationBindingSource, "Strength", True))
        Me.StrengthLabel2.Location = New System.Drawing.Point(276, 133)
        Me.StrengthLabel2.Name = "StrengthLabel2"
        Me.StrengthLabel2.Size = New System.Drawing.Size(34, 23)
        Me.StrengthLabel2.TabIndex = 88
        Me.StrengthLabel2.Text = "0"
        '
        'IntelligenceLabel2
        '
        Me.IntelligenceLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistrationBindingSource, "Intelligence", True))
        Me.IntelligenceLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IntelligenceLabel2.Location = New System.Drawing.Point(276, 104)
        Me.IntelligenceLabel2.Name = "IntelligenceLabel2"
        Me.IntelligenceLabel2.Size = New System.Drawing.Size(34, 23)
        Me.IntelligenceLabel2.TabIndex = 87
        Me.IntelligenceLabel2.Text = "0"
        '
        'NameLabel1
        '
        Me.NameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistrationBindingSource, "Name", True))
        Me.NameLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameLabel1.Location = New System.Drawing.Point(16, 24)
        Me.NameLabel1.Name = "NameLabel1"
        Me.NameLabel1.Size = New System.Drawing.Size(150, 20)
        Me.NameLabel1.TabIndex = 67
        Me.NameLabel1.Text = "------------------Name-----------------"
        '
        'FirstNameLabel1
        '
        Me.FirstNameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistrationBindingSource, "FirstName", True))
        Me.FirstNameLabel1.Location = New System.Drawing.Point(251, 24)
        Me.FirstNameLabel1.Name = "FirstNameLabel1"
        Me.FirstNameLabel1.Size = New System.Drawing.Size(100, 23)
        Me.FirstNameLabel1.TabIndex = 69
        Me.FirstNameLabel1.Text = "--------"
        '
        'LastNameLabel1
        '
        Me.LastNameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistrationBindingSource, "LastName", True))
        Me.LastNameLabel1.Location = New System.Drawing.Point(251, 47)
        Me.LastNameLabel1.Name = "LastNameLabel1"
        Me.LastNameLabel1.Size = New System.Drawing.Size(100, 23)
        Me.LastNameLabel1.TabIndex = 71
        Me.LastNameLabel1.Text = "--------"
        '
        'AlignmentLabel1
        '
        Me.AlignmentLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistrationBindingSource, "Alignment", True))
        Me.AlignmentLabel1.Location = New System.Drawing.Point(251, 70)
        Me.AlignmentLabel1.Name = "AlignmentLabel1"
        Me.AlignmentLabel1.Size = New System.Drawing.Size(100, 23)
        Me.AlignmentLabel1.TabIndex = 73
        Me.AlignmentLabel1.Text = "--------"
        '
        'ImagePictureBox
        '
        Me.ImagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ImagePictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.RegistrationBindingSource, "Image", True))
        Me.ImagePictureBox.Location = New System.Drawing.Point(16, 47)
        Me.ImagePictureBox.Name = "ImagePictureBox"
        Me.ImagePictureBox.Size = New System.Drawing.Size(150, 229)
        Me.ImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImagePictureBox.TabIndex = 74
        Me.ImagePictureBox.TabStop = False
        '
        'IntelligenceProgressBar
        '
        Me.IntelligenceProgressBar.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.RegistrationBindingSource, "Intelligence", True))
        Me.IntelligenceProgressBar.Location = New System.Drawing.Point(316, 104)
        Me.IntelligenceProgressBar.Maximum = 7
        Me.IntelligenceProgressBar.Name = "IntelligenceProgressBar"
        Me.IntelligenceProgressBar.Size = New System.Drawing.Size(100, 23)
        Me.IntelligenceProgressBar.TabIndex = 76
        '
        'StrengthProgressBar
        '
        Me.StrengthProgressBar.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.RegistrationBindingSource, "Strength", True))
        Me.StrengthProgressBar.Location = New System.Drawing.Point(316, 133)
        Me.StrengthProgressBar.Maximum = 7
        Me.StrengthProgressBar.Name = "StrengthProgressBar"
        Me.StrengthProgressBar.Size = New System.Drawing.Size(100, 23)
        Me.StrengthProgressBar.TabIndex = 78
        '
        'SpeedProgressBar
        '
        Me.SpeedProgressBar.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.RegistrationBindingSource, "Speed", True))
        Me.SpeedProgressBar.Location = New System.Drawing.Point(316, 162)
        Me.SpeedProgressBar.Maximum = 7
        Me.SpeedProgressBar.Name = "SpeedProgressBar"
        Me.SpeedProgressBar.Size = New System.Drawing.Size(100, 23)
        Me.SpeedProgressBar.TabIndex = 80
        '
        'DurabilityProgressBar
        '
        Me.DurabilityProgressBar.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.RegistrationBindingSource, "Durability", True))
        Me.DurabilityProgressBar.Location = New System.Drawing.Point(316, 191)
        Me.DurabilityProgressBar.Maximum = 7
        Me.DurabilityProgressBar.Name = "DurabilityProgressBar"
        Me.DurabilityProgressBar.Size = New System.Drawing.Size(100, 23)
        Me.DurabilityProgressBar.TabIndex = 82
        '
        'FightingSkillProgressBar
        '
        Me.FightingSkillProgressBar.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.RegistrationBindingSource, "FightingSkill", True))
        Me.FightingSkillProgressBar.Location = New System.Drawing.Point(316, 220)
        Me.FightingSkillProgressBar.Maximum = 7
        Me.FightingSkillProgressBar.Name = "FightingSkillProgressBar"
        Me.FightingSkillProgressBar.Size = New System.Drawing.Size(100, 23)
        Me.FightingSkillProgressBar.TabIndex = 84
        '
        'EnergyProjectionProgressBar
        '
        Me.EnergyProjectionProgressBar.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.RegistrationBindingSource, "EnergyProjection", True))
        Me.EnergyProjectionProgressBar.Location = New System.Drawing.Point(316, 249)
        Me.EnergyProjectionProgressBar.Maximum = 7
        Me.EnergyProjectionProgressBar.Name = "EnergyProjectionProgressBar"
        Me.EnergyProjectionProgressBar.Size = New System.Drawing.Size(100, 23)
        Me.EnergyProjectionProgressBar.TabIndex = 86
        '
        'AbilitiesTextBox
        '
        Me.AbilitiesTextBox.BackColor = System.Drawing.Color.LightGray
        Me.AbilitiesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistrationBindingSource, "Abilities", True))
        Me.AbilitiesTextBox.Location = New System.Drawing.Point(16, 310)
        Me.AbilitiesTextBox.Multiline = True
        Me.AbilitiesTextBox.Name = "AbilitiesTextBox"
        Me.AbilitiesTextBox.ReadOnly = True
        Me.AbilitiesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.AbilitiesTextBox.Size = New System.Drawing.Size(294, 91)
        Me.AbilitiesTextBox.TabIndex = 94
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
        Me.Panel1.Size = New System.Drawing.Size(895, 26)
        Me.Panel1.TabIndex = 95
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Gray
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(842, 0)
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
        Me.btnMinimize.Location = New System.Drawing.Point(803, 0)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(33, 23)
        Me.btnMinimize.TabIndex = 1
        Me.btnMinimize.Text = "-"
        Me.btnMinimize.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackgroundImage = CType(resources.GetObject("Panel4.BackgroundImage"), System.Drawing.Image)
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(892, 26)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(3, 675)
        Me.Panel4.TabIndex = 107
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = Global.HerosVillianRegistration.My.Resources.Resources.FormHeader2BlueGradiant
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 26)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(3, 675)
        Me.Panel3.TabIndex = 108
        '
        'CharacterGroupBox
        '
        Me.CharacterGroupBox.Controls.Add(Me.TeamGroupBox)
        Me.CharacterGroupBox.Controls.Add(Me.ImagePictureBox)
        Me.CharacterGroupBox.Controls.Add(Me.EnergyProjectionProgressBar)
        Me.CharacterGroupBox.Controls.Add(EnergyProjectionLabel)
        Me.CharacterGroupBox.Controls.Add(Me.FightingSkillProgressBar)
        Me.CharacterGroupBox.Controls.Add(AbilitiesLabel)
        Me.CharacterGroupBox.Controls.Add(FightingSkillLabel)
        Me.CharacterGroupBox.Controls.Add(Me.AbilitiesTextBox)
        Me.CharacterGroupBox.Controls.Add(Me.DurabilityProgressBar)
        Me.CharacterGroupBox.Controls.Add(Me.EnergyProjectionLabel2)
        Me.CharacterGroupBox.Controls.Add(DurabilityLabel)
        Me.CharacterGroupBox.Controls.Add(Me.FightingSkillLabel2)
        Me.CharacterGroupBox.Controls.Add(Me.SpeedProgressBar)
        Me.CharacterGroupBox.Controls.Add(Me.DurabilityLabel2)
        Me.CharacterGroupBox.Controls.Add(SpeedLabel)
        Me.CharacterGroupBox.Controls.Add(Me.SpeedLabel2)
        Me.CharacterGroupBox.Controls.Add(Me.StrengthProgressBar)
        Me.CharacterGroupBox.Controls.Add(Me.StrengthLabel2)
        Me.CharacterGroupBox.Controls.Add(StrengthLabel)
        Me.CharacterGroupBox.Controls.Add(Me.IntelligenceLabel2)
        Me.CharacterGroupBox.Controls.Add(Me.IntelligenceProgressBar)
        Me.CharacterGroupBox.Controls.Add(Me.NameLabel1)
        Me.CharacterGroupBox.Controls.Add(IntelligenceLabel)
        Me.CharacterGroupBox.Controls.Add(FirstNameLabel)
        Me.CharacterGroupBox.Controls.Add(Me.AlignmentLabel1)
        Me.CharacterGroupBox.Controls.Add(Me.FirstNameLabel1)
        Me.CharacterGroupBox.Controls.Add(AlignmentLabel)
        Me.CharacterGroupBox.Controls.Add(LastNameLabel)
        Me.CharacterGroupBox.Controls.Add(Me.LastNameLabel1)
        Me.CharacterGroupBox.Location = New System.Drawing.Point(15, 63)
        Me.CharacterGroupBox.Name = "CharacterGroupBox"
        Me.CharacterGroupBox.Size = New System.Drawing.Size(868, 421)
        Me.CharacterGroupBox.TabIndex = 109
        Me.CharacterGroupBox.TabStop = False
        Me.CharacterGroupBox.Text = "Character"
        '
        'TeamGroupBox
        '
        Me.TeamGroupBox.Controls.Add(Me.BaseGroupBox)
        Me.TeamGroupBox.Controls.Add(Me.TmLogoPictureBox)
        Me.TeamGroupBox.Controls.Add(Me.TmNameLabel1)
        Me.TeamGroupBox.Controls.Add(TmNameLabel)
        Me.TeamGroupBox.Location = New System.Drawing.Point(422, 10)
        Me.TeamGroupBox.Name = "TeamGroupBox"
        Me.TeamGroupBox.Size = New System.Drawing.Size(440, 405)
        Me.TeamGroupBox.TabIndex = 97
        Me.TeamGroupBox.TabStop = False
        Me.TeamGroupBox.Text = "Team"
        '
        'BaseGroupBox
        '
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
        Me.BaseGroupBox.Controls.Add(Me.BaseImagePictureBox)
        Me.BaseGroupBox.Location = New System.Drawing.Point(15, 152)
        Me.BaseGroupBox.Name = "BaseGroupBox"
        Me.BaseGroupBox.Size = New System.Drawing.Size(419, 239)
        Me.BaseGroupBox.TabIndex = 97
        Me.BaseGroupBox.TabStop = False
        Me.BaseGroupBox.Text = "Base of Operations"
        '
        'BaseCityLabel1
        '
        Me.BaseCityLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistrationBindingSource, "BaseCity", True))
        Me.BaseCityLabel1.Location = New System.Drawing.Point(248, 169)
        Me.BaseCityLabel1.Name = "BaseCityLabel1"
        Me.BaseCityLabel1.Size = New System.Drawing.Size(134, 23)
        Me.BaseCityLabel1.TabIndex = 10
        Me.BaseCityLabel1.Text = "Label1"
        '
        'BaseStateLabel1
        '
        Me.BaseStateLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistrationBindingSource, "BaseState", True))
        Me.BaseStateLabel1.Location = New System.Drawing.Point(248, 134)
        Me.BaseStateLabel1.Name = "BaseStateLabel1"
        Me.BaseStateLabel1.Size = New System.Drawing.Size(134, 23)
        Me.BaseStateLabel1.TabIndex = 8
        Me.BaseStateLabel1.Text = "Label1"
        '
        'BaseCountryLabel1
        '
        Me.BaseCountryLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistrationBindingSource, "BaseCountry", True))
        Me.BaseCountryLabel1.Location = New System.Drawing.Point(248, 99)
        Me.BaseCountryLabel1.Name = "BaseCountryLabel1"
        Me.BaseCountryLabel1.Size = New System.Drawing.Size(134, 23)
        Me.BaseCountryLabel1.TabIndex = 6
        Me.BaseCountryLabel1.Text = "Label1"
        '
        'BasePlanetLabel1
        '
        Me.BasePlanetLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistrationBindingSource, "BasePlanet", True))
        Me.BasePlanetLabel1.Location = New System.Drawing.Point(248, 64)
        Me.BasePlanetLabel1.Name = "BasePlanetLabel1"
        Me.BasePlanetLabel1.Size = New System.Drawing.Size(134, 23)
        Me.BasePlanetLabel1.TabIndex = 4
        Me.BasePlanetLabel1.Text = "Label1"
        '
        'BaseNameLabel1
        '
        Me.BaseNameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistrationBindingSource, "BaseName", True))
        Me.BaseNameLabel1.Location = New System.Drawing.Point(248, 29)
        Me.BaseNameLabel1.Name = "BaseNameLabel1"
        Me.BaseNameLabel1.Size = New System.Drawing.Size(134, 23)
        Me.BaseNameLabel1.TabIndex = 2
        Me.BaseNameLabel1.Text = "Label1"
        '
        'BaseImagePictureBox
        '
        Me.BaseImagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BaseImagePictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.RegistrationBindingSource, "BaseImage", True))
        Me.BaseImagePictureBox.Location = New System.Drawing.Point(15, 29)
        Me.BaseImagePictureBox.Name = "BaseImagePictureBox"
        Me.BaseImagePictureBox.Size = New System.Drawing.Size(157, 182)
        Me.BaseImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BaseImagePictureBox.TabIndex = 1
        Me.BaseImagePictureBox.TabStop = False
        '
        'TmLogoPictureBox
        '
        Me.TmLogoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TmLogoPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.RegistrationBindingSource, "TmLogo", True))
        Me.TmLogoPictureBox.Location = New System.Drawing.Point(20, 19)
        Me.TmLogoPictureBox.Name = "TmLogoPictureBox"
        Me.TmLogoPictureBox.Size = New System.Drawing.Size(124, 117)
        Me.TmLogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TmLogoPictureBox.TabIndex = 96
        Me.TmLogoPictureBox.TabStop = False
        '
        'TmNameLabel1
        '
        Me.TmNameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistrationBindingSource, "TmName", True))
        Me.TmNameLabel1.Location = New System.Drawing.Point(212, 21)
        Me.TmNameLabel1.Name = "TmNameLabel1"
        Me.TmNameLabel1.Size = New System.Drawing.Size(100, 23)
        Me.TmNameLabel1.TabIndex = 95
        Me.TmNameLabel1.Text = "Label1"
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
        'MainForm2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(895, 724)
        Me.Controls.Add(Me.CharacterGroupBox)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.tbseach2)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainForm2"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegistrationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegistrationDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImagePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.CharacterGroupBox.ResumeLayout(False)
        Me.CharacterGroupBox.PerformLayout()
        Me.TeamGroupBox.ResumeLayout(False)
        Me.TeamGroupBox.PerformLayout()
        Me.BaseGroupBox.ResumeLayout(False)
        Me.BaseGroupBox.PerformLayout()
        CType(Me.BaseImagePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TmLogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegisterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewRegistryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents RegistrationDatabaseDataSet As HerosVillianRegistration.RegistrationDatabaseDataSet
    Friend WithEvents RegistrationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RegistrationTableAdapter As HerosVillianRegistration.RegistrationDatabaseDataSetTableAdapters.RegistrationTableAdapter
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents tbseach2 As System.Windows.Forms.TextBox
    Friend WithEvents EnergyProjectionLabel2 As System.Windows.Forms.Label
    Friend WithEvents FightingSkillLabel2 As System.Windows.Forms.Label
    Friend WithEvents DurabilityLabel2 As System.Windows.Forms.Label
    Friend WithEvents SpeedLabel2 As System.Windows.Forms.Label
    Friend WithEvents StrengthLabel2 As System.Windows.Forms.Label
    Friend WithEvents IntelligenceLabel2 As System.Windows.Forms.Label
    Friend WithEvents NameLabel1 As System.Windows.Forms.Label
    Friend WithEvents FirstNameLabel1 As System.Windows.Forms.Label
    Friend WithEvents LastNameLabel1 As System.Windows.Forms.Label
    Friend WithEvents AlignmentLabel1 As System.Windows.Forms.Label
    Friend WithEvents ImagePictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents IntelligenceProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents StrengthProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents SpeedProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents DurabilityProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents FightingSkillProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents EnergyProjectionProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents AbilitiesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnMinimize As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents TestToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImageDatabaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CharacterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BaseOfOperationsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TeamsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CharacterGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents TeamGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents BaseGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents TmLogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents TmNameLabel1 As System.Windows.Forms.Label
    Friend WithEvents TableAdapterManager As HerosVillianRegistration.RegistrationDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BaseCityLabel1 As System.Windows.Forms.Label
    Friend WithEvents BaseStateLabel1 As System.Windows.Forms.Label
    Friend WithEvents BaseCountryLabel1 As System.Windows.Forms.Label
    Friend WithEvents BasePlanetLabel1 As System.Windows.Forms.Label
    Friend WithEvents BaseNameLabel1 As System.Windows.Forms.Label
    Friend WithEvents BaseImagePictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents TeamsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TmName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Alignment As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
