<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TeamsForm
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
        Dim TeamIDLabel As System.Windows.Forms.Label
        Dim TeamNameLabel As System.Windows.Forms.Label
        Dim TeamLogoLabel As System.Windows.Forms.Label
        Dim TBNameLabel As System.Windows.Forms.Label
        Dim TBPlanetLabel As System.Windows.Forms.Label
        Dim TBCountryLabel As System.Windows.Forms.Label
        Dim TBStateLabel As System.Windows.Forms.Label
        Dim TBCityLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TeamsForm))
        Me.RegistrationDatabaseDataSet = New HerosVillianRegistration.RegistrationDatabaseDataSet()
        Me.TeamsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TeamsTableAdapter = New HerosVillianRegistration.RegistrationDatabaseDataSetTableAdapters.TeamsTableAdapter()
        Me.TableAdapterManager = New HerosVillianRegistration.RegistrationDatabaseDataSetTableAdapters.TableAdapterManager()
        Me.TeamIDLabel1 = New System.Windows.Forms.Label()
        Me.TeamNameTextBox = New System.Windows.Forms.TextBox()
        Me.btnFromCom = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnFromDB = New System.Windows.Forms.Button()
        Me.btnPickBase = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.TeamLogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.BaseOfOperationsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BaseOfOperationsTableAdapter = New HerosVillianRegistration.RegistrationDatabaseDataSetTableAdapters.BaseOfOperationsTableAdapter()
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
        Me.btnDone1 = New System.Windows.Forms.Button()
        Me.btnNext2 = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnPrevious2 = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        TeamIDLabel = New System.Windows.Forms.Label()
        TeamNameLabel = New System.Windows.Forms.Label()
        TeamLogoLabel = New System.Windows.Forms.Label()
        TBNameLabel = New System.Windows.Forms.Label()
        TBPlanetLabel = New System.Windows.Forms.Label()
        TBCountryLabel = New System.Windows.Forms.Label()
        TBStateLabel = New System.Windows.Forms.Label()
        TBCityLabel = New System.Windows.Forms.Label()
        CType(Me.RegistrationDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TeamsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TeamLogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BaseOfOperationsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBImagePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TeamIDLabel
        '
        TeamIDLabel.AutoSize = True
        TeamIDLabel.Location = New System.Drawing.Point(21, 105)
        TeamIDLabel.Name = "TeamIDLabel"
        TeamIDLabel.Size = New System.Drawing.Size(51, 13)
        TeamIDLabel.TabIndex = 1
        TeamIDLabel.Text = "Team ID:"
        '
        'TeamNameLabel
        '
        TeamNameLabel.AutoSize = True
        TeamNameLabel.Location = New System.Drawing.Point(21, 128)
        TeamNameLabel.Name = "TeamNameLabel"
        TeamNameLabel.Size = New System.Drawing.Size(68, 13)
        TeamNameLabel.TabIndex = 3
        TeamNameLabel.Text = "Team Name:"
        '
        'TeamLogoLabel
        '
        TeamLogoLabel.AutoSize = True
        TeamLogoLabel.Location = New System.Drawing.Point(21, 174)
        TeamLogoLabel.Name = "TeamLogoLabel"
        TeamLogoLabel.Size = New System.Drawing.Size(64, 13)
        TeamLogoLabel.TabIndex = 5
        TeamLogoLabel.Text = "Team Logo:"
        '
        'TBNameLabel
        '
        TBNameLabel.AutoSize = True
        TBNameLabel.Location = New System.Drawing.Point(384, 151)
        TBNameLabel.Name = "TBNameLabel"
        TBNameLabel.Size = New System.Drawing.Size(68, 13)
        TBNameLabel.TabIndex = 122
        TBNameLabel.Text = "Team Name:"
        '
        'TBPlanetLabel
        '
        TBPlanetLabel.AutoSize = True
        TBPlanetLabel.Location = New System.Drawing.Point(384, 173)
        TBPlanetLabel.Name = "TBPlanetLabel"
        TBPlanetLabel.Size = New System.Drawing.Size(40, 13)
        TBPlanetLabel.TabIndex = 123
        TBPlanetLabel.Text = "Planet:"
        '
        'TBCountryLabel
        '
        TBCountryLabel.AutoSize = True
        TBCountryLabel.Location = New System.Drawing.Point(384, 196)
        TBCountryLabel.Name = "TBCountryLabel"
        TBCountryLabel.Size = New System.Drawing.Size(46, 13)
        TBCountryLabel.TabIndex = 124
        TBCountryLabel.Text = "Country:"
        '
        'TBStateLabel
        '
        TBStateLabel.AutoSize = True
        TBStateLabel.Location = New System.Drawing.Point(384, 219)
        TBStateLabel.Name = "TBStateLabel"
        TBStateLabel.Size = New System.Drawing.Size(35, 13)
        TBStateLabel.TabIndex = 125
        TBStateLabel.Text = "State:"
        '
        'TBCityLabel
        '
        TBCityLabel.AutoSize = True
        TBCityLabel.Location = New System.Drawing.Point(384, 243)
        TBCityLabel.Name = "TBCityLabel"
        TBCityLabel.Size = New System.Drawing.Size(27, 13)
        TBCityLabel.TabIndex = 126
        TBCityLabel.Text = "City:"
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
        'TeamIDLabel1
        '
        Me.TeamIDLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TeamsBindingSource, "TeamID", True))
        Me.TeamIDLabel1.Location = New System.Drawing.Point(78, 105)
        Me.TeamIDLabel1.Name = "TeamIDLabel1"
        Me.TeamIDLabel1.Size = New System.Drawing.Size(100, 23)
        Me.TeamIDLabel1.TabIndex = 2
        Me.TeamIDLabel1.Text = "Label1"
        '
        'TeamNameTextBox
        '
        Me.TeamNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TeamsBindingSource, "TeamName", True))
        Me.TeamNameTextBox.Location = New System.Drawing.Point(24, 144)
        Me.TeamNameTextBox.Name = "TeamNameTextBox"
        Me.TeamNameTextBox.Size = New System.Drawing.Size(156, 20)
        Me.TeamNameTextBox.TabIndex = 4
        '
        'btnFromCom
        '
        Me.btnFromCom.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFromCom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFromCom.Location = New System.Drawing.Point(20, 396)
        Me.btnFromCom.Name = "btnFromCom"
        Me.btnFromCom.Size = New System.Drawing.Size(80, 32)
        Me.btnFromCom.TabIndex = 111
        Me.btnFromCom.Text = "From Com"
        Me.btnFromCom.UseVisualStyleBackColor = True
        '
        'btnDel
        '
        Me.btnDel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDel.Location = New System.Drawing.Point(20, 428)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(160, 23)
        Me.btnDel.TabIndex = 112
        Me.btnDel.Text = "Delete"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'btnFromDB
        '
        Me.btnFromDB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFromDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFromDB.Location = New System.Drawing.Point(100, 396)
        Me.btnFromDB.Name = "btnFromDB"
        Me.btnFromDB.Size = New System.Drawing.Size(80, 32)
        Me.btnFromDB.TabIndex = 113
        Me.btnFromDB.Text = "Database"
        Me.btnFromDB.UseVisualStyleBackColor = True
        '
        'btnPickBase
        '
        Me.btnPickBase.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPickBase.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPickBase.Location = New System.Drawing.Point(228, 357)
        Me.btnPickBase.Name = "btnPickBase"
        Me.btnPickBase.Size = New System.Drawing.Size(150, 23)
        Me.btnPickBase.TabIndex = 114
        Me.btnPickBase.Text = "Pick Base of Operations"
        Me.btnPickBase.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Gray
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(610, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(24, 20)
        Me.btnClose.TabIndex = 121
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnMinimize
        '
        Me.btnMinimize.BackColor = System.Drawing.Color.Gray
        Me.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMinimize.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinimize.Location = New System.Drawing.Point(580, 3)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(24, 20)
        Me.btnMinimize.TabIndex = 122
        Me.btnMinimize.Text = "-"
        Me.btnMinimize.UseVisualStyleBackColor = False
        '
        'TeamLogoPictureBox
        '
        Me.TeamLogoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TeamLogoPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.TeamsBindingSource, "TeamLogo", True))
        Me.TeamLogoPictureBox.Location = New System.Drawing.Point(20, 190)
        Me.TeamLogoPictureBox.Name = "TeamLogoPictureBox"
        Me.TeamLogoPictureBox.Size = New System.Drawing.Size(158, 200)
        Me.TeamLogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TeamLogoPictureBox.TabIndex = 6
        Me.TeamLogoPictureBox.TabStop = False
        '
        'BaseOfOperationsBindingSource
        '
        Me.BaseOfOperationsBindingSource.DataMember = "BaseOfOperations"
        Me.BaseOfOperationsBindingSource.DataSource = Me.RegistrationDatabaseDataSet
        '
        'BaseOfOperationsTableAdapter
        '
        Me.BaseOfOperationsTableAdapter.ClearBeforeFill = True
        '
        'TBNameLabel1
        '
        Me.TBNameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TeamsBindingSource, "TBName", True))
        Me.TBNameLabel1.Location = New System.Drawing.Point(463, 151)
        Me.TBNameLabel1.Name = "TBNameLabel1"
        Me.TBNameLabel1.Size = New System.Drawing.Size(100, 23)
        Me.TBNameLabel1.TabIndex = 123
        Me.TBNameLabel1.Text = "Label1"
        '
        'TBPlanetLabel1
        '
        Me.TBPlanetLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TeamsBindingSource, "TBPlanet", True))
        Me.TBPlanetLabel1.Location = New System.Drawing.Point(463, 174)
        Me.TBPlanetLabel1.Name = "TBPlanetLabel1"
        Me.TBPlanetLabel1.Size = New System.Drawing.Size(100, 23)
        Me.TBPlanetLabel1.TabIndex = 124
        Me.TBPlanetLabel1.Text = "Label1"
        '
        'TBCountryLabel1
        '
        Me.TBCountryLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TeamsBindingSource, "TBCountry", True))
        Me.TBCountryLabel1.Location = New System.Drawing.Point(463, 197)
        Me.TBCountryLabel1.Name = "TBCountryLabel1"
        Me.TBCountryLabel1.Size = New System.Drawing.Size(100, 23)
        Me.TBCountryLabel1.TabIndex = 125
        Me.TBCountryLabel1.Text = "Label1"
        '
        'TBStateLabel1
        '
        Me.TBStateLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TeamsBindingSource, "TBState", True))
        Me.TBStateLabel1.Location = New System.Drawing.Point(463, 220)
        Me.TBStateLabel1.Name = "TBStateLabel1"
        Me.TBStateLabel1.Size = New System.Drawing.Size(100, 23)
        Me.TBStateLabel1.TabIndex = 126
        Me.TBStateLabel1.Text = "Label1"
        '
        'TBCityLabel1
        '
        Me.TBCityLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TeamsBindingSource, "TBCity", True))
        Me.TBCityLabel1.Location = New System.Drawing.Point(463, 244)
        Me.TBCityLabel1.Name = "TBCityLabel1"
        Me.TBCityLabel1.Size = New System.Drawing.Size(100, 23)
        Me.TBCityLabel1.TabIndex = 127
        Me.TBCityLabel1.Text = "Label1"
        '
        'TBImagePictureBox
        '
        Me.TBImagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TBImagePictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.TeamsBindingSource, "TBImage", True))
        Me.TBImagePictureBox.Location = New System.Drawing.Point(228, 147)
        Me.TBImagePictureBox.Name = "TBImagePictureBox"
        Me.TBImagePictureBox.Size = New System.Drawing.Size(150, 200)
        Me.TBImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TBImagePictureBox.TabIndex = 128
        Me.TBImagePictureBox.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.BackgroundImage = CType(resources.GetObject("Panel4.BackgroundImage"), System.Drawing.Image)
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(642, 26)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(3, 438)
        Me.Panel4.TabIndex = 134
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = Global.HerosVillianRegistration.My.Resources.Resources.FormHeader2BlueGradiant
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 26)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(3, 438)
        Me.Panel3.TabIndex = 133
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.HerosVillianRegistration.My.Resources.Resources.FormFooterrBlueGradiant
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 464)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(645, 23)
        Me.Panel2.TabIndex = 132
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.HerosVillianRegistration.My.Resources.Resources.FormHeader2BlueGradiant
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.btnMinimize)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(645, 26)
        Me.Panel1.TabIndex = 131
        '
        'btnDone1
        '
        Me.btnDone1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDone1.Location = New System.Drawing.Point(544, 32)
        Me.btnDone1.Name = "btnDone1"
        Me.btnDone1.Size = New System.Drawing.Size(89, 25)
        Me.btnDone1.TabIndex = 140
        Me.btnDone1.Text = "Done"
        Me.btnDone1.UseVisualStyleBackColor = True
        '
        'btnNext2
        '
        Me.btnNext2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNext2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext2.Location = New System.Drawing.Point(69, 32)
        Me.btnNext2.Name = "btnNext2"
        Me.btnNext2.Size = New System.Drawing.Size(45, 25)
        Me.btnNext2.TabIndex = 139
        Me.btnNext2.Text = ">"
        Me.btnNext2.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Location = New System.Drawing.Point(322, 32)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(89, 25)
        Me.btnDelete.TabIndex = 137
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Location = New System.Drawing.Point(227, 32)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(89, 25)
        Me.btnSave.TabIndex = 136
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnPrevious2
        '
        Me.btnPrevious2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrevious2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrevious2.Location = New System.Drawing.Point(20, 32)
        Me.btnPrevious2.Name = "btnPrevious2"
        Me.btnPrevious2.Size = New System.Drawing.Size(45, 25)
        Me.btnPrevious2.TabIndex = 138
        Me.btnPrevious2.Text = "<"
        Me.btnPrevious2.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Location = New System.Drawing.Point(132, 32)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(89, 25)
        Me.btnAdd.TabIndex = 135
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'TeamsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(645, 487)
        Me.Controls.Add(Me.btnDone1)
        Me.Controls.Add(Me.btnNext2)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnPrevious2)
        Me.Controls.Add(Me.btnAdd)
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
        Me.Controls.Add(Me.btnPickBase)
        Me.Controls.Add(Me.btnFromCom)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnFromDB)
        Me.Controls.Add(TeamIDLabel)
        Me.Controls.Add(Me.TeamIDLabel1)
        Me.Controls.Add(TeamNameLabel)
        Me.Controls.Add(Me.TeamNameTextBox)
        Me.Controls.Add(TeamLogoLabel)
        Me.Controls.Add(Me.TeamLogoPictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "TeamsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TeamsForm"
        CType(Me.RegistrationDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TeamsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TeamLogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BaseOfOperationsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBImagePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RegistrationDatabaseDataSet As HerosVillianRegistration.RegistrationDatabaseDataSet
    Friend WithEvents TeamsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TeamsTableAdapter As HerosVillianRegistration.RegistrationDatabaseDataSetTableAdapters.TeamsTableAdapter
    Friend WithEvents TableAdapterManager As HerosVillianRegistration.RegistrationDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TeamIDLabel1 As System.Windows.Forms.Label
    Friend WithEvents TeamNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TeamLogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents btnFromCom As System.Windows.Forms.Button
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents btnFromDB As System.Windows.Forms.Button
    Friend WithEvents btnPickBase As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnMinimize As System.Windows.Forms.Button
    Friend WithEvents BaseOfOperationsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BaseOfOperationsTableAdapter As HerosVillianRegistration.RegistrationDatabaseDataSetTableAdapters.BaseOfOperationsTableAdapter
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
    Friend WithEvents btnDone1 As System.Windows.Forms.Button
    Friend WithEvents btnNext2 As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnPrevious2 As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
End Class
