<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImageDatabaseForm
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
        Dim ImgIDLabel As System.Windows.Forms.Label
        Dim ImageNameLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ImageDatabaseForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.RegistrationDatabaseDataSet = New HerosVillianRegistration.RegistrationDatabaseDataSet()
        Me.ImageTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ImageTableTableAdapter = New HerosVillianRegistration.RegistrationDatabaseDataSetTableAdapters.ImageTableTableAdapter()
        Me.TableAdapterManager = New HerosVillianRegistration.RegistrationDatabaseDataSetTableAdapters.TableAdapterManager()
        Me.ImgIDLabel1 = New System.Windows.Forms.Label()
        Me.ImageNameTextBox = New System.Windows.Forms.TextBox()
        Me.ImgPictureBox = New System.Windows.Forms.PictureBox()
        Me.ImageTableDataGridView = New System.Windows.Forms.DataGridView()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDone1 = New System.Windows.Forms.Button()
        Me.btnNext2 = New System.Windows.Forms.Button()
        Me.btnPrevious2 = New System.Windows.Forms.Button()
        Me.btnPickImage = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        ImgIDLabel = New System.Windows.Forms.Label()
        ImageNameLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.RegistrationDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageTableDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImgIDLabel
        '
        ImgIDLabel.AutoSize = True
        ImgIDLabel.Location = New System.Drawing.Point(16, 104)
        ImgIDLabel.Name = "ImgIDLabel"
        ImgIDLabel.Size = New System.Drawing.Size(41, 13)
        ImgIDLabel.TabIndex = 114
        ImgIDLabel.Text = "Img ID:"
        '
        'ImageNameLabel
        '
        ImageNameLabel.AutoSize = True
        ImageNameLabel.Location = New System.Drawing.Point(16, 133)
        ImageNameLabel.Name = "ImageNameLabel"
        ImageNameLabel.Size = New System.Drawing.Size(70, 13)
        ImageNameLabel.TabIndex = 116
        ImageNameLabel.Text = "Image Name:"
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
        Me.Panel1.Size = New System.Drawing.Size(747, 26)
        Me.Panel1.TabIndex = 98
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Gray
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(710, 0)
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
        Me.btnMinimize.Location = New System.Drawing.Point(680, 0)
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
        Me.Panel2.Location = New System.Drawing.Point(0, 505)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(747, 23)
        Me.Panel2.TabIndex = 99
        '
        'Panel4
        '
        Me.Panel4.BackgroundImage = CType(resources.GetObject("Panel4.BackgroundImage"), System.Drawing.Image)
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(744, 26)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(3, 479)
        Me.Panel4.TabIndex = 112
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = Global.HerosVillianRegistration.My.Resources.Resources.FormHeader2BlueGradiant
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 26)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(3, 479)
        Me.Panel3.TabIndex = 113
        '
        'RegistrationDatabaseDataSet
        '
        Me.RegistrationDatabaseDataSet.DataSetName = "RegistrationDatabaseDataSet"
        Me.RegistrationDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ImageTableBindingSource
        '
        Me.ImageTableBindingSource.DataMember = "ImageTable"
        Me.ImageTableBindingSource.DataSource = Me.RegistrationDatabaseDataSet
        '
        'ImageTableTableAdapter
        '
        Me.ImageTableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BaseOfOperationsTableAdapter = Nothing
        Me.TableAdapterManager.ImageTableTableAdapter = Me.ImageTableTableAdapter
        Me.TableAdapterManager.LoginTableTableAdapter = Nothing
        Me.TableAdapterManager.RegistrationTableAdapter = Nothing
        Me.TableAdapterManager.TeamsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = HerosVillianRegistration.RegistrationDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ImgIDLabel1
        '
        Me.ImgIDLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ImageTableBindingSource, "ImgID", True))
        Me.ImgIDLabel1.Location = New System.Drawing.Point(96, 104)
        Me.ImgIDLabel1.Name = "ImgIDLabel1"
        Me.ImgIDLabel1.Size = New System.Drawing.Size(100, 23)
        Me.ImgIDLabel1.TabIndex = 115
        Me.ImgIDLabel1.Text = "Label1"
        '
        'ImageNameTextBox
        '
        Me.ImageNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ImageTableBindingSource, "ImageName", True))
        Me.ImageNameTextBox.Location = New System.Drawing.Point(16, 152)
        Me.ImageNameTextBox.Name = "ImageNameTextBox"
        Me.ImageNameTextBox.Size = New System.Drawing.Size(224, 20)
        Me.ImageNameTextBox.TabIndex = 117
        '
        'ImgPictureBox
        '
        Me.ImgPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ImgPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.ImageTableBindingSource, "Img", True))
        Me.ImgPictureBox.Location = New System.Drawing.Point(48, 192)
        Me.ImgPictureBox.Name = "ImgPictureBox"
        Me.ImgPictureBox.Size = New System.Drawing.Size(150, 200)
        Me.ImgPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgPictureBox.TabIndex = 119
        Me.ImgPictureBox.TabStop = False
        '
        'ImageTableDataGridView
        '
        Me.ImageTableDataGridView.AllowUserToResizeRows = False
        Me.ImageTableDataGridView.AutoGenerateColumns = False
        Me.ImageTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ImageTableDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.ImageTableDataGridView.DataSource = Me.ImageTableBindingSource
        Me.ImageTableDataGridView.Location = New System.Drawing.Point(344, 88)
        Me.ImageTableDataGridView.Name = "ImageTableDataGridView"
        Me.ImageTableDataGridView.Size = New System.Drawing.Size(384, 400)
        Me.ImageTableDataGridView.TabIndex = 119
        '
        'btnDelete
        '
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Location = New System.Drawing.Point(341, 32)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(89, 25)
        Me.btnDelete.TabIndex = 122
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Location = New System.Drawing.Point(246, 32)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(89, 25)
        Me.btnSave.TabIndex = 121
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Location = New System.Drawing.Point(151, 32)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(89, 25)
        Me.btnAdd.TabIndex = 120
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnDone1
        '
        Me.btnDone1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDone1.Location = New System.Drawing.Point(487, 32)
        Me.btnDone1.Name = "btnDone1"
        Me.btnDone1.Size = New System.Drawing.Size(89, 25)
        Me.btnDone1.TabIndex = 123
        Me.btnDone1.Text = "Done"
        Me.btnDone1.UseVisualStyleBackColor = True
        '
        'btnNext2
        '
        Me.btnNext2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNext2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext2.Location = New System.Drawing.Point(71, 32)
        Me.btnNext2.Name = "btnNext2"
        Me.btnNext2.Size = New System.Drawing.Size(45, 25)
        Me.btnNext2.TabIndex = 125
        Me.btnNext2.Text = ">"
        Me.btnNext2.UseVisualStyleBackColor = True
        '
        'btnPrevious2
        '
        Me.btnPrevious2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrevious2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrevious2.Location = New System.Drawing.Point(16, 32)
        Me.btnPrevious2.Name = "btnPrevious2"
        Me.btnPrevious2.Size = New System.Drawing.Size(49, 25)
        Me.btnPrevious2.TabIndex = 124
        Me.btnPrevious2.Text = "<"
        Me.btnPrevious2.UseVisualStyleBackColor = True
        '
        'btnPickImage
        '
        Me.btnPickImage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPickImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPickImage.Location = New System.Drawing.Point(48, 398)
        Me.btnPickImage.Name = "btnPickImage"
        Me.btnPickImage.Size = New System.Drawing.Size(150, 25)
        Me.btnPickImage.TabIndex = 126
        Me.btnPickImage.Text = "Add Image"
        Me.btnPickImage.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ImgID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ImgID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ImageName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ImageName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'ImageDatabaseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(747, 528)
        Me.Controls.Add(Me.btnPickImage)
        Me.Controls.Add(Me.btnNext2)
        Me.Controls.Add(Me.btnPrevious2)
        Me.Controls.Add(Me.btnDone1)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.ImageTableDataGridView)
        Me.Controls.Add(ImgIDLabel)
        Me.Controls.Add(Me.ImgIDLabel1)
        Me.Controls.Add(ImageNameLabel)
        Me.Controls.Add(Me.ImageNameTextBox)
        Me.Controls.Add(Me.ImgPictureBox)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ImageDatabaseForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ImageDatabaseForm"
        Me.Panel1.ResumeLayout(False)
        CType(Me.RegistrationDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageTableDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnMinimize As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents RegistrationDatabaseDataSet As HerosVillianRegistration.RegistrationDatabaseDataSet
    Friend WithEvents ImageTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ImageTableTableAdapter As HerosVillianRegistration.RegistrationDatabaseDataSetTableAdapters.ImageTableTableAdapter
    Friend WithEvents TableAdapterManager As HerosVillianRegistration.RegistrationDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ImgIDLabel1 As System.Windows.Forms.Label
    Friend WithEvents ImageNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ImgPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents ImageTableDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnDone1 As System.Windows.Forms.Button
    Friend WithEvents btnNext2 As System.Windows.Forms.Button
    Friend WithEvents btnPrevious2 As System.Windows.Forms.Button
    Friend WithEvents btnPickImage As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
