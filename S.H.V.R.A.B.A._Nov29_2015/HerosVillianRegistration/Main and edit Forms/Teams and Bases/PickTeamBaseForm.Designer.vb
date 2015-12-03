<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PickTeamBaseForm
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
        Dim BaseNameLabel As System.Windows.Forms.Label
        Dim PlanetLabel As System.Windows.Forms.Label
        Dim CountryLabel As System.Windows.Forms.Label
        Dim StateLabel As System.Windows.Forms.Label
        Dim CityLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PickTeamBaseForm))
        Me.RegistrationDatabaseDataSet = New HerosVillianRegistration.RegistrationDatabaseDataSet()
        Me.BaseOfOperationsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BaseOfOperationsTableAdapter = New HerosVillianRegistration.RegistrationDatabaseDataSetTableAdapters.BaseOfOperationsTableAdapter()
        Me.TableAdapterManager = New HerosVillianRegistration.RegistrationDatabaseDataSetTableAdapters.TableAdapterManager()
        Me.BaseOfOperationsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BaseNameLabel1 = New System.Windows.Forms.Label()
        Me.BaseImagePictureBox = New System.Windows.Forms.PictureBox()
        Me.PlanetLabel1 = New System.Windows.Forms.Label()
        Me.CountryLabel1 = New System.Windows.Forms.Label()
        Me.StateLabel1 = New System.Windows.Forms.Label()
        Me.CityLabel1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        BaseNameLabel = New System.Windows.Forms.Label()
        PlanetLabel = New System.Windows.Forms.Label()
        CountryLabel = New System.Windows.Forms.Label()
        StateLabel = New System.Windows.Forms.Label()
        CityLabel = New System.Windows.Forms.Label()
        CType(Me.RegistrationDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BaseOfOperationsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BaseOfOperationsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BaseImagePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BaseNameLabel
        '
        BaseNameLabel.AutoSize = True
        BaseNameLabel.Location = New System.Drawing.Point(204, 292)
        BaseNameLabel.Name = "BaseNameLabel"
        BaseNameLabel.Size = New System.Drawing.Size(65, 13)
        BaseNameLabel.TabIndex = 4
        BaseNameLabel.Text = "Base Name:"
        '
        'PlanetLabel
        '
        PlanetLabel.AutoSize = True
        PlanetLabel.Location = New System.Drawing.Point(204, 314)
        PlanetLabel.Name = "PlanetLabel"
        PlanetLabel.Size = New System.Drawing.Size(40, 13)
        PlanetLabel.TabIndex = 8
        PlanetLabel.Text = "Planet:"
        '
        'CountryLabel
        '
        CountryLabel.AutoSize = True
        CountryLabel.Location = New System.Drawing.Point(204, 337)
        CountryLabel.Name = "CountryLabel"
        CountryLabel.Size = New System.Drawing.Size(46, 13)
        CountryLabel.TabIndex = 10
        CountryLabel.Text = "Country:"
        '
        'StateLabel
        '
        StateLabel.AutoSize = True
        StateLabel.Location = New System.Drawing.Point(204, 360)
        StateLabel.Name = "StateLabel"
        StateLabel.Size = New System.Drawing.Size(35, 13)
        StateLabel.TabIndex = 12
        StateLabel.Text = "State:"
        '
        'CityLabel
        '
        CityLabel.AutoSize = True
        CityLabel.Location = New System.Drawing.Point(204, 383)
        CityLabel.Name = "CityLabel"
        CityLabel.Size = New System.Drawing.Size(27, 13)
        CityLabel.TabIndex = 14
        CityLabel.Text = "City:"
        '
        'RegistrationDatabaseDataSet
        '
        Me.RegistrationDatabaseDataSet.DataSetName = "RegistrationDatabaseDataSet"
        Me.RegistrationDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BaseOfOperationsTableAdapter = Me.BaseOfOperationsTableAdapter
        Me.TableAdapterManager.ImageTableTableAdapter = Nothing
        Me.TableAdapterManager.LoginTableTableAdapter = Nothing
        Me.TableAdapterManager.RegistrationTableAdapter = Nothing
        Me.TableAdapterManager.TeamsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = HerosVillianRegistration.RegistrationDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BaseOfOperationsDataGridView
        '
        Me.BaseOfOperationsDataGridView.AllowUserToAddRows = False
        Me.BaseOfOperationsDataGridView.AllowUserToDeleteRows = False
        Me.BaseOfOperationsDataGridView.AutoGenerateColumns = False
        Me.BaseOfOperationsDataGridView.BackgroundColor = System.Drawing.Color.LightGray
        Me.BaseOfOperationsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.BaseOfOperationsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BaseOfOperationsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.BaseOfOperationsDataGridView.DataSource = Me.BaseOfOperationsBindingSource
        Me.BaseOfOperationsDataGridView.Location = New System.Drawing.Point(12, 43)
        Me.BaseOfOperationsDataGridView.Name = "BaseOfOperationsDataGridView"
        Me.BaseOfOperationsDataGridView.ReadOnly = True
        Me.BaseOfOperationsDataGridView.Size = New System.Drawing.Size(633, 220)
        Me.BaseOfOperationsDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "BaseID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "BaseID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "BaseName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "BaseName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Planet"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Planet"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Country"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Country"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "State"
        Me.DataGridViewTextBoxColumn5.HeaderText = "State"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "City"
        Me.DataGridViewTextBoxColumn6.HeaderText = "City"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'BaseNameLabel1
        '
        Me.BaseNameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BaseOfOperationsBindingSource, "BaseName", True))
        Me.BaseNameLabel1.Location = New System.Drawing.Point(276, 292)
        Me.BaseNameLabel1.Name = "BaseNameLabel1"
        Me.BaseNameLabel1.Size = New System.Drawing.Size(100, 23)
        Me.BaseNameLabel1.TabIndex = 5
        Me.BaseNameLabel1.Text = "Label1"
        '
        'BaseImagePictureBox
        '
        Me.BaseImagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BaseImagePictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.BaseOfOperationsBindingSource, "BaseImage", True))
        Me.BaseImagePictureBox.Location = New System.Drawing.Point(12, 269)
        Me.BaseImagePictureBox.Name = "BaseImagePictureBox"
        Me.BaseImagePictureBox.Size = New System.Drawing.Size(186, 246)
        Me.BaseImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BaseImagePictureBox.TabIndex = 7
        Me.BaseImagePictureBox.TabStop = False
        '
        'PlanetLabel1
        '
        Me.PlanetLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BaseOfOperationsBindingSource, "Planet", True))
        Me.PlanetLabel1.Location = New System.Drawing.Point(276, 314)
        Me.PlanetLabel1.Name = "PlanetLabel1"
        Me.PlanetLabel1.Size = New System.Drawing.Size(100, 23)
        Me.PlanetLabel1.TabIndex = 9
        Me.PlanetLabel1.Text = "Label1"
        '
        'CountryLabel1
        '
        Me.CountryLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BaseOfOperationsBindingSource, "Country", True))
        Me.CountryLabel1.Location = New System.Drawing.Point(276, 337)
        Me.CountryLabel1.Name = "CountryLabel1"
        Me.CountryLabel1.Size = New System.Drawing.Size(100, 23)
        Me.CountryLabel1.TabIndex = 11
        Me.CountryLabel1.Text = "Label1"
        '
        'StateLabel1
        '
        Me.StateLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BaseOfOperationsBindingSource, "State", True))
        Me.StateLabel1.Location = New System.Drawing.Point(276, 360)
        Me.StateLabel1.Name = "StateLabel1"
        Me.StateLabel1.Size = New System.Drawing.Size(100, 23)
        Me.StateLabel1.TabIndex = 13
        Me.StateLabel1.Text = "Label1"
        '
        'CityLabel1
        '
        Me.CityLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BaseOfOperationsBindingSource, "City", True))
        Me.CityLabel1.Location = New System.Drawing.Point(276, 383)
        Me.CityLabel1.Name = "CityLabel1"
        Me.CityLabel1.Size = New System.Drawing.Size(100, 23)
        Me.CityLabel1.TabIndex = 15
        Me.CityLabel1.Text = "Label1"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(464, 477)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(181, 45)
        Me.TableLayoutPanel1.TabIndex = 16
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OK_Button.Location = New System.Drawing.Point(3, 5)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(84, 34)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancel_Button.Location = New System.Drawing.Point(93, 5)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(85, 34)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.HerosVillianRegistration.My.Resources.Resources.FormFooterrBlueGradiant
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 533)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(665, 23)
        Me.Panel2.TabIndex = 128
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.HerosVillianRegistration.My.Resources.Resources.FormHeader2BlueGradiant
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(665, 26)
        Me.Panel1.TabIndex = 127
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = Global.HerosVillianRegistration.My.Resources.Resources.FormHeader2BlueGradiant
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 26)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(3, 507)
        Me.Panel3.TabIndex = 129
        '
        'Panel4
        '
        Me.Panel4.BackgroundImage = CType(resources.GetObject("Panel4.BackgroundImage"), System.Drawing.Image)
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(662, 26)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(3, 507)
        Me.Panel4.TabIndex = 130
        '
        'PickTeamBaseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(665, 556)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(BaseNameLabel)
        Me.Controls.Add(Me.BaseNameLabel1)
        Me.Controls.Add(Me.BaseImagePictureBox)
        Me.Controls.Add(PlanetLabel)
        Me.Controls.Add(Me.PlanetLabel1)
        Me.Controls.Add(CountryLabel)
        Me.Controls.Add(Me.CountryLabel1)
        Me.Controls.Add(StateLabel)
        Me.Controls.Add(Me.StateLabel1)
        Me.Controls.Add(CityLabel)
        Me.Controls.Add(Me.CityLabel1)
        Me.Controls.Add(Me.BaseOfOperationsDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PickTeamBaseForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PickTeamBaseForm"
        CType(Me.RegistrationDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BaseOfOperationsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BaseOfOperationsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BaseImagePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RegistrationDatabaseDataSet As HerosVillianRegistration.RegistrationDatabaseDataSet
    Friend WithEvents BaseOfOperationsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BaseOfOperationsTableAdapter As HerosVillianRegistration.RegistrationDatabaseDataSetTableAdapters.BaseOfOperationsTableAdapter
    Friend WithEvents TableAdapterManager As HerosVillianRegistration.RegistrationDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BaseOfOperationsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BaseNameLabel1 As System.Windows.Forms.Label
    Friend WithEvents BaseImagePictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents PlanetLabel1 As System.Windows.Forms.Label
    Friend WithEvents CountryLabel1 As System.Windows.Forms.Label
    Friend WithEvents StateLabel1 As System.Windows.Forms.Label
    Friend WithEvents CityLabel1 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
End Class
