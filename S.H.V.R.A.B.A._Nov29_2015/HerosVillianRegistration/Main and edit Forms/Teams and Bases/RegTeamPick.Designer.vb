<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegTeamPick
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
        Dim TeamNameLabel As System.Windows.Forms.Label
        Dim TBNameLabel As System.Windows.Forms.Label
        Dim TBPlanetLabel As System.Windows.Forms.Label
        Dim TBCountryLabel As System.Windows.Forms.Label
        Dim TBStateLabel As System.Windows.Forms.Label
        Dim TBCityLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegTeamPick))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.RegistrationDatabaseDataSet = New HerosVillianRegistration.RegistrationDatabaseDataSet()
        Me.TeamsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TeamsTableAdapter = New HerosVillianRegistration.RegistrationDatabaseDataSetTableAdapters.TeamsTableAdapter()
        Me.TableAdapterManager = New HerosVillianRegistration.RegistrationDatabaseDataSetTableAdapters.TableAdapterManager()
        Me.TeamsDataGridView = New System.Windows.Forms.DataGridView()
        Me.TeamNameLabel1 = New System.Windows.Forms.Label()
        Me.TeamLogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.TBNameLabel1 = New System.Windows.Forms.Label()
        Me.TBPlanetLabel1 = New System.Windows.Forms.Label()
        Me.TBCountryLabel1 = New System.Windows.Forms.Label()
        Me.TBStateLabel1 = New System.Windows.Forms.Label()
        Me.TBCityLabel1 = New System.Windows.Forms.Label()
        Me.TBImagePictureBox = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        TeamNameLabel = New System.Windows.Forms.Label()
        TBNameLabel = New System.Windows.Forms.Label()
        TBPlanetLabel = New System.Windows.Forms.Label()
        TBCountryLabel = New System.Windows.Forms.Label()
        TBStateLabel = New System.Windows.Forms.Label()
        TBCityLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.RegistrationDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TeamsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TeamsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TeamLogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBImagePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TeamNameLabel
        '
        TeamNameLabel.AutoSize = True
        TeamNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TeamNameLabel.Location = New System.Drawing.Point(604, 46)
        TeamNameLabel.Name = "TeamNameLabel"
        TeamNameLabel.Size = New System.Drawing.Size(78, 13)
        TeamNameLabel.TabIndex = 3
        TeamNameLabel.Text = "Team Name:"
        '
        'TBNameLabel
        '
        TBNameLabel.AutoSize = True
        TBNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TBNameLabel.Location = New System.Drawing.Point(619, 318)
        TBNameLabel.Name = "TBNameLabel"
        TBNameLabel.Size = New System.Drawing.Size(43, 13)
        TBNameLabel.TabIndex = 7
        TBNameLabel.Text = "Name:"
        '
        'TBPlanetLabel
        '
        TBPlanetLabel.AutoSize = True
        TBPlanetLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TBPlanetLabel.Location = New System.Drawing.Point(619, 342)
        TBPlanetLabel.Name = "TBPlanetLabel"
        TBPlanetLabel.Size = New System.Drawing.Size(47, 13)
        TBPlanetLabel.TabIndex = 9
        TBPlanetLabel.Text = "Planet:"
        '
        'TBCountryLabel
        '
        TBCountryLabel.AutoSize = True
        TBCountryLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TBCountryLabel.Location = New System.Drawing.Point(619, 366)
        TBCountryLabel.Name = "TBCountryLabel"
        TBCountryLabel.Size = New System.Drawing.Size(54, 13)
        TBCountryLabel.TabIndex = 11
        TBCountryLabel.Text = "Country:"
        '
        'TBStateLabel
        '
        TBStateLabel.AutoSize = True
        TBStateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TBStateLabel.Location = New System.Drawing.Point(619, 390)
        TBStateLabel.Name = "TBStateLabel"
        TBStateLabel.Size = New System.Drawing.Size(41, 13)
        TBStateLabel.TabIndex = 13
        TBStateLabel.Text = "State:"
        '
        'TBCityLabel
        '
        TBCityLabel.AutoSize = True
        TBCityLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TBCityLabel.Location = New System.Drawing.Point(619, 414)
        TBCityLabel.Name = "TBCityLabel"
        TBCityLabel.Size = New System.Drawing.Size(32, 13)
        TBCityLabel.TabIndex = 15
        TBCityLabel.Text = "City:"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(655, 576)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(174, 42)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OK_Button.Location = New System.Drawing.Point(3, 5)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(81, 32)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancel_Button.Location = New System.Drawing.Point(90, 5)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(81, 32)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'RegistrationDatabaseDataSet
        '
        Me.RegistrationDatabaseDataSet.DataSetName = "RegistrationDatabaseDataSet"
        Me.RegistrationDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TeamsBindingSource
        '
        Me.TeamsBindingSource.DataMember = "Teams"
        Me.TeamsBindingSource.DataSource = Me.RegistrationDatabaseDataSet
        '
        'TeamsTableAdapter
        '
        Me.TeamsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BaseOfOperationsTableAdapter = Nothing
        Me.TableAdapterManager.ImageTableTableAdapter = Nothing
        Me.TableAdapterManager.LoginTableTableAdapter = Nothing
        Me.TableAdapterManager.RegistrationTableAdapter = Nothing
        Me.TableAdapterManager.TeamsTableAdapter = Me.TeamsTableAdapter
        Me.TableAdapterManager.UpdateOrder = HerosVillianRegistration.RegistrationDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TeamsDataGridView
        '
        Me.TeamsDataGridView.AllowUserToAddRows = False
        Me.TeamsDataGridView.AllowUserToDeleteRows = False
        Me.TeamsDataGridView.AutoGenerateColumns = False
        Me.TeamsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TeamsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.TeamsDataGridView.DataSource = Me.TeamsBindingSource
        Me.TeamsDataGridView.Location = New System.Drawing.Point(12, 46)
        Me.TeamsDataGridView.Name = "TeamsDataGridView"
        Me.TeamsDataGridView.ReadOnly = True
        Me.TeamsDataGridView.RowHeadersVisible = False
        Me.TeamsDataGridView.Size = New System.Drawing.Size(403, 514)
        Me.TeamsDataGridView.TabIndex = 2
        '
        'TeamNameLabel1
        '
        Me.TeamNameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TeamsBindingSource, "TeamName", True))
        Me.TeamNameLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TeamNameLabel1.Location = New System.Drawing.Point(678, 46)
        Me.TeamNameLabel1.Name = "TeamNameLabel1"
        Me.TeamNameLabel1.Size = New System.Drawing.Size(100, 23)
        Me.TeamNameLabel1.TabIndex = 4
        Me.TeamNameLabel1.Text = "Label1"
        '
        'TeamLogoPictureBox
        '
        Me.TeamLogoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TeamLogoPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.TeamsBindingSource, "TeamLogo", True))
        Me.TeamLogoPictureBox.Location = New System.Drawing.Point(422, 46)
        Me.TeamLogoPictureBox.Name = "TeamLogoPictureBox"
        Me.TeamLogoPictureBox.Size = New System.Drawing.Size(181, 183)
        Me.TeamLogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TeamLogoPictureBox.TabIndex = 6
        Me.TeamLogoPictureBox.TabStop = False
        '
        'TBNameLabel1
        '
        Me.TBNameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TeamsBindingSource, "TBName", True))
        Me.TBNameLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBNameLabel1.Location = New System.Drawing.Point(677, 318)
        Me.TBNameLabel1.Name = "TBNameLabel1"
        Me.TBNameLabel1.Size = New System.Drawing.Size(100, 23)
        Me.TBNameLabel1.TabIndex = 8
        Me.TBNameLabel1.Text = "Label1"
        '
        'TBPlanetLabel1
        '
        Me.TBPlanetLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TeamsBindingSource, "TBPlanet", True))
        Me.TBPlanetLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBPlanetLabel1.Location = New System.Drawing.Point(677, 342)
        Me.TBPlanetLabel1.Name = "TBPlanetLabel1"
        Me.TBPlanetLabel1.Size = New System.Drawing.Size(100, 23)
        Me.TBPlanetLabel1.TabIndex = 10
        Me.TBPlanetLabel1.Text = "Label1"
        '
        'TBCountryLabel1
        '
        Me.TBCountryLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TeamsBindingSource, "TBCountry", True))
        Me.TBCountryLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBCountryLabel1.Location = New System.Drawing.Point(677, 366)
        Me.TBCountryLabel1.Name = "TBCountryLabel1"
        Me.TBCountryLabel1.Size = New System.Drawing.Size(100, 23)
        Me.TBCountryLabel1.TabIndex = 12
        Me.TBCountryLabel1.Text = "Label1"
        '
        'TBStateLabel1
        '
        Me.TBStateLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TeamsBindingSource, "TBState", True))
        Me.TBStateLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBStateLabel1.Location = New System.Drawing.Point(677, 390)
        Me.TBStateLabel1.Name = "TBStateLabel1"
        Me.TBStateLabel1.Size = New System.Drawing.Size(100, 23)
        Me.TBStateLabel1.TabIndex = 14
        Me.TBStateLabel1.Text = "Label1"
        '
        'TBCityLabel1
        '
        Me.TBCityLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TeamsBindingSource, "TBCity", True))
        Me.TBCityLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBCityLabel1.Location = New System.Drawing.Point(677, 414)
        Me.TBCityLabel1.Name = "TBCityLabel1"
        Me.TBCityLabel1.Size = New System.Drawing.Size(100, 23)
        Me.TBCityLabel1.TabIndex = 16
        Me.TBCityLabel1.Text = "Label1"
        '
        'TBImagePictureBox
        '
        Me.TBImagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TBImagePictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.TeamsBindingSource, "TBImage", True))
        Me.TBImagePictureBox.Location = New System.Drawing.Point(421, 318)
        Me.TBImagePictureBox.Name = "TBImagePictureBox"
        Me.TBImagePictureBox.Size = New System.Drawing.Size(182, 242)
        Me.TBImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TBImagePictureBox.TabIndex = 18
        Me.TBImagePictureBox.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.BackgroundImage = CType(resources.GetObject("Panel4.BackgroundImage"), System.Drawing.Image)
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(838, 26)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(3, 598)
        Me.Panel4.TabIndex = 134
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = Global.HerosVillianRegistration.My.Resources.Resources.FormHeader2BlueGradiant
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 26)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(3, 598)
        Me.Panel3.TabIndex = 133
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.HerosVillianRegistration.My.Resources.Resources.FormFooterrBlueGradiant
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 624)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(841, 23)
        Me.Panel2.TabIndex = 132
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.HerosVillianRegistration.My.Resources.Resources.FormHeader2BlueGradiant
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(841, 26)
        Me.Panel1.TabIndex = 131
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "TeamID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "TeamID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "TeamName"
        Me.DataGridViewTextBoxColumn2.FillWeight = 200.0!
        Me.DataGridViewTextBoxColumn2.HeaderText = "Team Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 200
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "TBName"
        Me.DataGridViewTextBoxColumn3.FillWeight = 200.0!
        Me.DataGridViewTextBoxColumn3.HeaderText = "Base Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 200
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "TBPlanet"
        Me.DataGridViewTextBoxColumn4.HeaderText = "TBPlanet"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "TBCountry"
        Me.DataGridViewTextBoxColumn5.HeaderText = "TBCountry"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "TBState"
        Me.DataGridViewTextBoxColumn6.HeaderText = "TBState"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "TBCity"
        Me.DataGridViewTextBoxColumn7.HeaderText = "TBCity"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'RegTeamPick
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(841, 647)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TBImagePictureBox)
        Me.Controls.Add(TBCityLabel)
        Me.Controls.Add(Me.TBCityLabel1)
        Me.Controls.Add(TBStateLabel)
        Me.Controls.Add(Me.TBStateLabel1)
        Me.Controls.Add(TBCountryLabel)
        Me.Controls.Add(Me.TBCountryLabel1)
        Me.Controls.Add(TBPlanetLabel)
        Me.Controls.Add(Me.TBPlanetLabel1)
        Me.Controls.Add(TBNameLabel)
        Me.Controls.Add(Me.TBNameLabel1)
        Me.Controls.Add(Me.TeamLogoPictureBox)
        Me.Controls.Add(TeamNameLabel)
        Me.Controls.Add(Me.TeamNameLabel1)
        Me.Controls.Add(Me.TeamsDataGridView)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RegTeamPick"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RegTeamPick"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.RegistrationDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TeamsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TeamsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TeamLogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBImagePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents RegistrationDatabaseDataSet As HerosVillianRegistration.RegistrationDatabaseDataSet
    Friend WithEvents TeamsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TeamsTableAdapter As HerosVillianRegistration.RegistrationDatabaseDataSetTableAdapters.TeamsTableAdapter
    Friend WithEvents TableAdapterManager As HerosVillianRegistration.RegistrationDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TeamsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents TeamNameLabel1 As System.Windows.Forms.Label
    Friend WithEvents TeamLogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents TBNameLabel1 As System.Windows.Forms.Label
    Friend WithEvents TBPlanetLabel1 As System.Windows.Forms.Label
    Friend WithEvents TBCountryLabel1 As System.Windows.Forms.Label
    Friend WithEvents TBStateLabel1 As System.Windows.Forms.Label
    Friend WithEvents TBCityLabel1 As System.Windows.Forms.Label
    Friend WithEvents TBImagePictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
