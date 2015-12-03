<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrationForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistrationForm))
        Me.IDLabel1 = New System.Windows.Forms.Label()
        Me.RegistrationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RegistrationDatabaseDataSet = New HerosVillianRegistration.RegistrationDatabaseDataSet()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.AlignmentComboBox = New System.Windows.Forms.ComboBox()
        Me.ImagePictureBox = New System.Windows.Forms.PictureBox()
        Me.AbilitiesTextBox = New System.Windows.Forms.TextBox()
        Me.IntelligenceTrackBar = New System.Windows.Forms.TrackBar()
        Me.StrengthTrackBar = New System.Windows.Forms.TrackBar()
        Me.SpeedTrackBar = New System.Windows.Forms.TrackBar()
        Me.DurabilityTrackBar = New System.Windows.Forms.TrackBar()
        Me.FightingSkillTrackBar = New System.Windows.Forms.TrackBar()
        Me.EnergyProjectionTrackBar = New System.Windows.Forms.TrackBar()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.RegistrationDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegistrationTableAdapter = New HerosVillianRegistration.RegistrationDatabaseDataSetTableAdapters.RegistrationTableAdapter()
        Me.TableAdapterManager = New HerosVillianRegistration.RegistrationDatabaseDataSetTableAdapters.TableAdapterManager()
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
        CType(Me.RegistrationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegistrationDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImagePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IntelligenceTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StrengthTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpeedTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DurabilityTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FightingSkillTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnergyProjectionTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegistrationDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(12, 34)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 1
        IDLabel.Text = "ID:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(12, 63)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(38, 13)
        NameLabel.TabIndex = 3
        NameLabel.Text = "Name:"
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Location = New System.Drawing.Point(12, 89)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(60, 13)
        FirstNameLabel.TabIndex = 5
        FirstNameLabel.Text = "First Name:"
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Location = New System.Drawing.Point(12, 115)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(61, 13)
        LastNameLabel.TabIndex = 7
        LastNameLabel.Text = "Last Name:"
        '
        'AlignmentLabel
        '
        AlignmentLabel.AutoSize = True
        AlignmentLabel.Location = New System.Drawing.Point(12, 141)
        AlignmentLabel.Name = "AlignmentLabel"
        AlignmentLabel.Size = New System.Drawing.Size(56, 13)
        AlignmentLabel.TabIndex = 9
        AlignmentLabel.Text = "Alignment:"
        '
        'ImageLabel
        '
        ImageLabel.AutoSize = True
        ImageLabel.Location = New System.Drawing.Point(340, 204)
        ImageLabel.Name = "ImageLabel"
        ImageLabel.Size = New System.Drawing.Size(39, 13)
        ImageLabel.TabIndex = 11
        ImageLabel.Text = "Image:"
        '
        'AbilitiesLabel
        '
        AbilitiesLabel.AutoSize = True
        AbilitiesLabel.Location = New System.Drawing.Point(523, 204)
        AbilitiesLabel.Name = "AbilitiesLabel"
        AbilitiesLabel.Size = New System.Drawing.Size(45, 13)
        AbilitiesLabel.TabIndex = 13
        AbilitiesLabel.Text = "Abilities:"
        '
        'IntelligenceLabel
        '
        IntelligenceLabel.AutoSize = True
        IntelligenceLabel.Location = New System.Drawing.Point(15, 175)
        IntelligenceLabel.Name = "IntelligenceLabel"
        IntelligenceLabel.Size = New System.Drawing.Size(64, 13)
        IntelligenceLabel.TabIndex = 15
        IntelligenceLabel.Text = "Intelligence:"
        '
        'StrengthLabel
        '
        StrengthLabel.AutoSize = True
        StrengthLabel.Location = New System.Drawing.Point(15, 223)
        StrengthLabel.Name = "StrengthLabel"
        StrengthLabel.Size = New System.Drawing.Size(50, 13)
        StrengthLabel.TabIndex = 17
        StrengthLabel.Text = "Strength:"
        '
        'SpeedLabel
        '
        SpeedLabel.AutoSize = True
        SpeedLabel.Location = New System.Drawing.Point(15, 271)
        SpeedLabel.Name = "SpeedLabel"
        SpeedLabel.Size = New System.Drawing.Size(41, 13)
        SpeedLabel.TabIndex = 19
        SpeedLabel.Text = "Speed:"
        '
        'DurabilityLabel
        '
        DurabilityLabel.AutoSize = True
        DurabilityLabel.Location = New System.Drawing.Point(15, 319)
        DurabilityLabel.Name = "DurabilityLabel"
        DurabilityLabel.Size = New System.Drawing.Size(53, 13)
        DurabilityLabel.TabIndex = 21
        DurabilityLabel.Text = "Durability:"
        '
        'FightingSkillLabel
        '
        FightingSkillLabel.AutoSize = True
        FightingSkillLabel.Location = New System.Drawing.Point(15, 367)
        FightingSkillLabel.Name = "FightingSkillLabel"
        FightingSkillLabel.Size = New System.Drawing.Size(69, 13)
        FightingSkillLabel.TabIndex = 23
        FightingSkillLabel.Text = "Fighting Skill:"
        '
        'EnergyProjectionLabel
        '
        EnergyProjectionLabel.AutoSize = True
        EnergyProjectionLabel.Location = New System.Drawing.Point(15, 415)
        EnergyProjectionLabel.Name = "EnergyProjectionLabel"
        EnergyProjectionLabel.Size = New System.Drawing.Size(93, 13)
        EnergyProjectionLabel.TabIndex = 25
        EnergyProjectionLabel.Text = "Energy Projection:"
        '
        'IDLabel1
        '
        Me.IDLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistrationBindingSource, "ID", True))
        Me.IDLabel1.Location = New System.Drawing.Point(111, 34)
        Me.IDLabel1.Name = "IDLabel1"
        Me.IDLabel1.Size = New System.Drawing.Size(121, 23)
        Me.IDLabel1.TabIndex = 2
        Me.IDLabel1.Text = "--------"
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
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistrationBindingSource, "Name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(111, 60)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(121, 20)
        Me.NameTextBox.TabIndex = 4
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistrationBindingSource, "FirstName", True))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(111, 86)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(121, 20)
        Me.FirstNameTextBox.TabIndex = 6
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistrationBindingSource, "LastName", True))
        Me.LastNameTextBox.Location = New System.Drawing.Point(111, 112)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(121, 20)
        Me.LastNameTextBox.TabIndex = 8
        '
        'AlignmentComboBox
        '
        Me.AlignmentComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistrationBindingSource, "Alignment", True))
        Me.AlignmentComboBox.FormattingEnabled = True
        Me.AlignmentComboBox.Items.AddRange(New Object() {"Good", "Bad", "Neutral"})
        Me.AlignmentComboBox.Location = New System.Drawing.Point(111, 138)
        Me.AlignmentComboBox.Name = "AlignmentComboBox"
        Me.AlignmentComboBox.Size = New System.Drawing.Size(121, 21)
        Me.AlignmentComboBox.TabIndex = 10
        '
        'ImagePictureBox
        '
        Me.ImagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ImagePictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.RegistrationBindingSource, "Image", True))
        Me.ImagePictureBox.Location = New System.Drawing.Point(285, 223)
        Me.ImagePictureBox.Name = "ImagePictureBox"
        Me.ImagePictureBox.Size = New System.Drawing.Size(150, 220)
        Me.ImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImagePictureBox.TabIndex = 12
        Me.ImagePictureBox.TabStop = False
        '
        'AbilitiesTextBox
        '
        Me.AbilitiesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistrationBindingSource, "Abilities", True))
        Me.AbilitiesTextBox.Location = New System.Drawing.Point(441, 223)
        Me.AbilitiesTextBox.Multiline = True
        Me.AbilitiesTextBox.Name = "AbilitiesTextBox"
        Me.AbilitiesTextBox.Size = New System.Drawing.Size(263, 258)
        Me.AbilitiesTextBox.TabIndex = 14
        '
        'IntelligenceTrackBar
        '
        Me.IntelligenceTrackBar.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.RegistrationBindingSource, "Intelligence", True))
        Me.IntelligenceTrackBar.LargeChange = 1
        Me.IntelligenceTrackBar.Location = New System.Drawing.Point(158, 175)
        Me.IntelligenceTrackBar.Maximum = 7
        Me.IntelligenceTrackBar.Name = "IntelligenceTrackBar"
        Me.IntelligenceTrackBar.Size = New System.Drawing.Size(121, 42)
        Me.IntelligenceTrackBar.TabIndex = 16
        '
        'StrengthTrackBar
        '
        Me.StrengthTrackBar.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.RegistrationBindingSource, "Strength", True))
        Me.StrengthTrackBar.LargeChange = 1
        Me.StrengthTrackBar.Location = New System.Drawing.Point(158, 223)
        Me.StrengthTrackBar.Maximum = 7
        Me.StrengthTrackBar.Name = "StrengthTrackBar"
        Me.StrengthTrackBar.Size = New System.Drawing.Size(121, 42)
        Me.StrengthTrackBar.TabIndex = 18
        '
        'SpeedTrackBar
        '
        Me.SpeedTrackBar.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.RegistrationBindingSource, "Speed", True))
        Me.SpeedTrackBar.LargeChange = 1
        Me.SpeedTrackBar.Location = New System.Drawing.Point(158, 271)
        Me.SpeedTrackBar.Maximum = 7
        Me.SpeedTrackBar.Name = "SpeedTrackBar"
        Me.SpeedTrackBar.Size = New System.Drawing.Size(121, 42)
        Me.SpeedTrackBar.TabIndex = 20
        '
        'DurabilityTrackBar
        '
        Me.DurabilityTrackBar.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.RegistrationBindingSource, "Durability", True))
        Me.DurabilityTrackBar.LargeChange = 1
        Me.DurabilityTrackBar.Location = New System.Drawing.Point(158, 319)
        Me.DurabilityTrackBar.Maximum = 7
        Me.DurabilityTrackBar.Name = "DurabilityTrackBar"
        Me.DurabilityTrackBar.Size = New System.Drawing.Size(121, 42)
        Me.DurabilityTrackBar.TabIndex = 22
        '
        'FightingSkillTrackBar
        '
        Me.FightingSkillTrackBar.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.RegistrationBindingSource, "FightingSkill", True))
        Me.FightingSkillTrackBar.LargeChange = 1
        Me.FightingSkillTrackBar.Location = New System.Drawing.Point(158, 367)
        Me.FightingSkillTrackBar.Maximum = 7
        Me.FightingSkillTrackBar.Name = "FightingSkillTrackBar"
        Me.FightingSkillTrackBar.Size = New System.Drawing.Size(121, 42)
        Me.FightingSkillTrackBar.TabIndex = 24
        '
        'EnergyProjectionTrackBar
        '
        Me.EnergyProjectionTrackBar.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.RegistrationBindingSource, "EnergyProjection", True))
        Me.EnergyProjectionTrackBar.LargeChange = 1
        Me.EnergyProjectionTrackBar.Location = New System.Drawing.Point(158, 415)
        Me.EnergyProjectionTrackBar.Maximum = 7
        Me.EnergyProjectionTrackBar.Name = "EnergyProjectionTrackBar"
        Me.EnergyProjectionTrackBar.Size = New System.Drawing.Size(121, 42)
        Me.EnergyProjectionTrackBar.TabIndex = 26
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(285, 449)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(55, 23)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "Upload"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(380, 449)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(55, 23)
        Me.Button2.TabIndex = 28
        Me.Button2.Text = "Delete"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(139, 175)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(139, 226)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(137, 271)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 13)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(139, 319)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(13, 13)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(139, 367)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(13, 13)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(139, 415)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(13, 13)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "0"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(467, 8)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(237, 20)
        Me.TextBox1.TabIndex = 35
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(380, 8)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 20)
        Me.btnSearch.TabIndex = 36
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(12, 8)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 37
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(93, 8)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 38
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(174, 8)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 39
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'RegistrationDataGridView
        '
        Me.RegistrationDataGridView.AutoGenerateColumns = False
        Me.RegistrationDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.RegistrationDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.RegistrationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RegistrationDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.RegistrationDataGridView.DataSource = Me.RegistrationBindingSource
        Me.RegistrationDataGridView.Location = New System.Drawing.Point(285, 45)
        Me.RegistrationDataGridView.Name = "RegistrationDataGridView"
        Me.RegistrationDataGridView.ReadOnly = True
        Me.RegistrationDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.RegistrationDataGridView.RowHeadersVisible = False
        Me.RegistrationDataGridView.Size = New System.Drawing.Size(419, 143)
        Me.RegistrationDataGridView.TabIndex = 39
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "FirstName"
        Me.DataGridViewTextBoxColumn3.HeaderText = "FirstName"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "LastName"
        Me.DataGridViewTextBoxColumn4.HeaderText = "LastName"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Alignment"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Alignment"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'RegistrationTableAdapter
        '
        Me.RegistrationTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.RegistrationTableAdapter = Me.RegistrationTableAdapter
        Me.TableAdapterManager.UpdateOrder = HerosVillianRegistration.RegistrationDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'RegistrationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(724, 598)
        Me.Controls.Add(Me.RegistrationDataGridView)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDLabel1)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(FirstNameLabel)
        Me.Controls.Add(Me.FirstNameTextBox)
        Me.Controls.Add(LastNameLabel)
        Me.Controls.Add(Me.LastNameTextBox)
        Me.Controls.Add(AlignmentLabel)
        Me.Controls.Add(Me.AlignmentComboBox)
        Me.Controls.Add(ImageLabel)
        Me.Controls.Add(Me.ImagePictureBox)
        Me.Controls.Add(AbilitiesLabel)
        Me.Controls.Add(Me.AbilitiesTextBox)
        Me.Controls.Add(IntelligenceLabel)
        Me.Controls.Add(Me.IntelligenceTrackBar)
        Me.Controls.Add(StrengthLabel)
        Me.Controls.Add(Me.StrengthTrackBar)
        Me.Controls.Add(SpeedLabel)
        Me.Controls.Add(Me.SpeedTrackBar)
        Me.Controls.Add(DurabilityLabel)
        Me.Controls.Add(Me.DurabilityTrackBar)
        Me.Controls.Add(FightingSkillLabel)
        Me.Controls.Add(Me.FightingSkillTrackBar)
        Me.Controls.Add(EnergyProjectionLabel)
        Me.Controls.Add(Me.EnergyProjectionTrackBar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "RegistrationForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registration"
        CType(Me.RegistrationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegistrationDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImagePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IntelligenceTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StrengthTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpeedTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DurabilityTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FightingSkillTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnergyProjectionTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegistrationDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents AbilitiesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IntelligenceTrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents StrengthTrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents SpeedTrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents DurabilityTrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents FightingSkillTrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents EnergyProjectionTrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents RegistrationDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
