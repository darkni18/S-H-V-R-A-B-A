<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BasesForm
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
        Dim BaseIDLabel As System.Windows.Forms.Label
        Dim BaseNameLabel As System.Windows.Forms.Label
        Dim BaseImageLabel As System.Windows.Forms.Label
        Dim PlanetLabel As System.Windows.Forms.Label
        Dim CountryLabel As System.Windows.Forms.Label
        Dim StateLabel As System.Windows.Forms.Label
        Dim CityLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BasesForm))
        Me.RegistrationDatabaseDataSet = New HerosVillianRegistration.RegistrationDatabaseDataSet()
        Me.BaseOfOperationsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BaseOfOperationsTableAdapter = New HerosVillianRegistration.RegistrationDatabaseDataSetTableAdapters.BaseOfOperationsTableAdapter()
        Me.TableAdapterManager = New HerosVillianRegistration.RegistrationDatabaseDataSetTableAdapters.TableAdapterManager()
        Me.BaseIDLabel1 = New System.Windows.Forms.Label()
        Me.BaseNameTextBox = New System.Windows.Forms.TextBox()
        Me.BaseImagePictureBox = New System.Windows.Forms.PictureBox()
        Me.PlanetTextBox = New System.Windows.Forms.TextBox()
        Me.CountryTextBox = New System.Windows.Forms.TextBox()
        Me.StateTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.btnFomCom = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnFromDB = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnDone1 = New System.Windows.Forms.Button()
        Me.btnNext2 = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnPrevious2 = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        BaseIDLabel = New System.Windows.Forms.Label()
        BaseNameLabel = New System.Windows.Forms.Label()
        BaseImageLabel = New System.Windows.Forms.Label()
        PlanetLabel = New System.Windows.Forms.Label()
        CountryLabel = New System.Windows.Forms.Label()
        StateLabel = New System.Windows.Forms.Label()
        CityLabel = New System.Windows.Forms.Label()
        CType(Me.RegistrationDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BaseOfOperationsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BaseImagePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BaseIDLabel
        '
        BaseIDLabel.AutoSize = True
        BaseIDLabel.Location = New System.Drawing.Point(22, 103)
        BaseIDLabel.Name = "BaseIDLabel"
        BaseIDLabel.Size = New System.Drawing.Size(48, 13)
        BaseIDLabel.TabIndex = 1
        BaseIDLabel.Text = "Base ID:"
        '
        'BaseNameLabel
        '
        BaseNameLabel.AutoSize = True
        BaseNameLabel.Location = New System.Drawing.Point(22, 132)
        BaseNameLabel.Name = "BaseNameLabel"
        BaseNameLabel.Size = New System.Drawing.Size(65, 13)
        BaseNameLabel.TabIndex = 3
        BaseNameLabel.Text = "Base Name:"
        '
        'BaseImageLabel
        '
        BaseImageLabel.AutoSize = True
        BaseImageLabel.Location = New System.Drawing.Point(308, 103)
        BaseImageLabel.Name = "BaseImageLabel"
        BaseImageLabel.Size = New System.Drawing.Size(66, 13)
        BaseImageLabel.TabIndex = 5
        BaseImageLabel.Text = "Base Image:"
        '
        'PlanetLabel
        '
        PlanetLabel.AutoSize = True
        PlanetLabel.Location = New System.Drawing.Point(22, 157)
        PlanetLabel.Name = "PlanetLabel"
        PlanetLabel.Size = New System.Drawing.Size(40, 13)
        PlanetLabel.TabIndex = 7
        PlanetLabel.Text = "Planet:"
        '
        'CountryLabel
        '
        CountryLabel.AutoSize = True
        CountryLabel.Location = New System.Drawing.Point(22, 183)
        CountryLabel.Name = "CountryLabel"
        CountryLabel.Size = New System.Drawing.Size(46, 13)
        CountryLabel.TabIndex = 9
        CountryLabel.Text = "Country:"
        '
        'StateLabel
        '
        StateLabel.AutoSize = True
        StateLabel.Location = New System.Drawing.Point(22, 209)
        StateLabel.Name = "StateLabel"
        StateLabel.Size = New System.Drawing.Size(35, 13)
        StateLabel.TabIndex = 11
        StateLabel.Text = "State:"
        '
        'CityLabel
        '
        CityLabel.AutoSize = True
        CityLabel.Location = New System.Drawing.Point(22, 235)
        CityLabel.Name = "CityLabel"
        CityLabel.Size = New System.Drawing.Size(27, 13)
        CityLabel.TabIndex = 13
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
        'BaseIDLabel1
        '
        Me.BaseIDLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BaseOfOperationsBindingSource, "BaseID", True))
        Me.BaseIDLabel1.Location = New System.Drawing.Point(94, 103)
        Me.BaseIDLabel1.Name = "BaseIDLabel1"
        Me.BaseIDLabel1.Size = New System.Drawing.Size(100, 23)
        Me.BaseIDLabel1.TabIndex = 2
        Me.BaseIDLabel1.Text = "Label1"
        '
        'BaseNameTextBox
        '
        Me.BaseNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BaseOfOperationsBindingSource, "BaseName", True))
        Me.BaseNameTextBox.Location = New System.Drawing.Point(94, 129)
        Me.BaseNameTextBox.Name = "BaseNameTextBox"
        Me.BaseNameTextBox.Size = New System.Drawing.Size(162, 20)
        Me.BaseNameTextBox.TabIndex = 4
        '
        'BaseImagePictureBox
        '
        Me.BaseImagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BaseImagePictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.BaseOfOperationsBindingSource, "BaseImage", True))
        Me.BaseImagePictureBox.Location = New System.Drawing.Point(262, 119)
        Me.BaseImagePictureBox.Name = "BaseImagePictureBox"
        Me.BaseImagePictureBox.Size = New System.Drawing.Size(160, 200)
        Me.BaseImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BaseImagePictureBox.TabIndex = 6
        Me.BaseImagePictureBox.TabStop = False
        '
        'PlanetTextBox
        '
        Me.PlanetTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BaseOfOperationsBindingSource, "Planet", True))
        Me.PlanetTextBox.Location = New System.Drawing.Point(94, 154)
        Me.PlanetTextBox.Name = "PlanetTextBox"
        Me.PlanetTextBox.Size = New System.Drawing.Size(162, 20)
        Me.PlanetTextBox.TabIndex = 8
        '
        'CountryTextBox
        '
        Me.CountryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BaseOfOperationsBindingSource, "Country", True))
        Me.CountryTextBox.Location = New System.Drawing.Point(94, 180)
        Me.CountryTextBox.Name = "CountryTextBox"
        Me.CountryTextBox.Size = New System.Drawing.Size(162, 20)
        Me.CountryTextBox.TabIndex = 10
        '
        'StateTextBox
        '
        Me.StateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BaseOfOperationsBindingSource, "State", True))
        Me.StateTextBox.Location = New System.Drawing.Point(94, 206)
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.Size = New System.Drawing.Size(162, 20)
        Me.StateTextBox.TabIndex = 12
        '
        'CityTextBox
        '
        Me.CityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BaseOfOperationsBindingSource, "City", True))
        Me.CityTextBox.Location = New System.Drawing.Point(94, 232)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(162, 20)
        Me.CityTextBox.TabIndex = 14
        '
        'btnFomCom
        '
        Me.btnFomCom.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFomCom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFomCom.Location = New System.Drawing.Point(262, 325)
        Me.btnFomCom.Name = "btnFomCom"
        Me.btnFomCom.Size = New System.Drawing.Size(80, 32)
        Me.btnFomCom.TabIndex = 111
        Me.btnFomCom.Text = "From Com"
        Me.btnFomCom.UseVisualStyleBackColor = True
        '
        'btnDel
        '
        Me.btnDel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDel.Location = New System.Drawing.Point(262, 357)
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
        Me.btnFromDB.Location = New System.Drawing.Point(342, 325)
        Me.btnFromDB.Name = "btnFromDB"
        Me.btnFromDB.Size = New System.Drawing.Size(80, 32)
        Me.btnFromDB.TabIndex = 113
        Me.btnFromDB.Text = "Database"
        Me.btnFromDB.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Gray
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(480, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(33, 23)
        Me.btnClose.TabIndex = 123
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnMinimize
        '
        Me.btnMinimize.BackColor = System.Drawing.Color.Gray
        Me.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinimize.Location = New System.Drawing.Point(441, 0)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(33, 23)
        Me.btnMinimize.TabIndex = 124
        Me.btnMinimize.Text = "-"
        Me.btnMinimize.UseVisualStyleBackColor = False
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
        Me.Panel1.Size = New System.Drawing.Size(525, 26)
        Me.Panel1.TabIndex = 125
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.HerosVillianRegistration.My.Resources.Resources.FormFooterrBlueGradiant
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 425)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(525, 23)
        Me.Panel2.TabIndex = 126
        '
        'Panel4
        '
        Me.Panel4.BackgroundImage = CType(resources.GetObject("Panel4.BackgroundImage"), System.Drawing.Image)
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(522, 26)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(3, 399)
        Me.Panel4.TabIndex = 127
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = Global.HerosVillianRegistration.My.Resources.Resources.FormHeader2BlueGradiant
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 26)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(3, 399)
        Me.Panel3.TabIndex = 128
        '
        'btnDone1
        '
        Me.btnDone1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDone1.Location = New System.Drawing.Point(424, 32)
        Me.btnDone1.Name = "btnDone1"
        Me.btnDone1.Size = New System.Drawing.Size(89, 25)
        Me.btnDone1.TabIndex = 134
        Me.btnDone1.Text = "Done"
        Me.btnDone1.UseVisualStyleBackColor = True
        '
        'btnNext2
        '
        Me.btnNext2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNext2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext2.Location = New System.Drawing.Point(55, 32)
        Me.btnNext2.Name = "btnNext2"
        Me.btnNext2.Size = New System.Drawing.Size(31, 25)
        Me.btnNext2.TabIndex = 133
        Me.btnNext2.Text = ">"
        Me.btnNext2.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Location = New System.Drawing.Point(303, 32)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(89, 25)
        Me.btnDelete.TabIndex = 131
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Location = New System.Drawing.Point(208, 32)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(89, 25)
        Me.btnSave.TabIndex = 130
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnPrevious2
        '
        Me.btnPrevious2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrevious2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrevious2.Location = New System.Drawing.Point(14, 32)
        Me.btnPrevious2.Name = "btnPrevious2"
        Me.btnPrevious2.Size = New System.Drawing.Size(35, 25)
        Me.btnPrevious2.TabIndex = 132
        Me.btnPrevious2.Text = "<"
        Me.btnPrevious2.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Location = New System.Drawing.Point(113, 32)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(89, 25)
        Me.btnAdd.TabIndex = 129
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'BasesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(525, 448)
        Me.Controls.Add(Me.btnDone1)
        Me.Controls.Add(Me.btnNext2)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnPrevious2)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnFomCom)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnFromDB)
        Me.Controls.Add(BaseIDLabel)
        Me.Controls.Add(Me.BaseIDLabel1)
        Me.Controls.Add(BaseNameLabel)
        Me.Controls.Add(Me.BaseNameTextBox)
        Me.Controls.Add(BaseImageLabel)
        Me.Controls.Add(Me.BaseImagePictureBox)
        Me.Controls.Add(PlanetLabel)
        Me.Controls.Add(Me.PlanetTextBox)
        Me.Controls.Add(CountryLabel)
        Me.Controls.Add(Me.CountryTextBox)
        Me.Controls.Add(StateLabel)
        Me.Controls.Add(Me.StateTextBox)
        Me.Controls.Add(CityLabel)
        Me.Controls.Add(Me.CityTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BasesForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BasesForm"
        CType(Me.RegistrationDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BaseOfOperationsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BaseImagePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RegistrationDatabaseDataSet As HerosVillianRegistration.RegistrationDatabaseDataSet
    Friend WithEvents BaseOfOperationsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BaseOfOperationsTableAdapter As HerosVillianRegistration.RegistrationDatabaseDataSetTableAdapters.BaseOfOperationsTableAdapter
    Friend WithEvents TableAdapterManager As HerosVillianRegistration.RegistrationDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BaseIDLabel1 As System.Windows.Forms.Label
    Friend WithEvents BaseNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BaseImagePictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents PlanetTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CountryTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnFomCom As System.Windows.Forms.Button
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents btnFromDB As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnMinimize As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnDone1 As System.Windows.Forms.Button
    Friend WithEvents btnNext2 As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnPrevious2 As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
End Class
