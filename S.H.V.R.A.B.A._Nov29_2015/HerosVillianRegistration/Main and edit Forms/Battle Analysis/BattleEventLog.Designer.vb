<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BattleEventLog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BattleEventLog))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnFont = New System.Windows.Forms.Button()
        Me.btnMaximize = New System.Windows.Forms.Button()
        Me.btnSaveEvent = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ListEvents = New System.Windows.Forms.ListBox()
        Me.sfdBattleEvents = New System.Windows.Forms.SaveFileDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.HerosVillianRegistration.My.Resources.Resources.FormHeader2BlueGradiant
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.btnFont)
        Me.Panel1.Controls.Add(Me.btnMaximize)
        Me.Panel1.Controls.Add(Me.btnSaveEvent)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(302, 26)
        Me.Panel1.TabIndex = 97
        '
        'btnFont
        '
        Me.btnFont.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFont.Location = New System.Drawing.Point(94, 0)
        Me.btnFont.Name = "btnFont"
        Me.btnFont.Size = New System.Drawing.Size(80, 23)
        Me.btnFont.TabIndex = 5
        Me.btnFont.Text = "Change Font"
        Me.btnFont.UseVisualStyleBackColor = True
        '
        'btnMaximize
        '
        Me.btnMaximize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximize.BackColor = System.Drawing.Color.Gray
        Me.btnMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaximize.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMaximize.Location = New System.Drawing.Point(257, 0)
        Me.btnMaximize.Name = "btnMaximize"
        Me.btnMaximize.Size = New System.Drawing.Size(33, 23)
        Me.btnMaximize.TabIndex = 23
        Me.btnMaximize.Text = "□"
        Me.btnMaximize.UseVisualStyleBackColor = False
        '
        'btnSaveEvent
        '
        Me.btnSaveEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveEvent.Location = New System.Drawing.Point(8, 0)
        Me.btnSaveEvent.Name = "btnSaveEvent"
        Me.btnSaveEvent.Size = New System.Drawing.Size(80, 23)
        Me.btnSaveEvent.TabIndex = 3
        Me.btnSaveEvent.Text = "Save Results"
        Me.btnSaveEvent.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.HerosVillianRegistration.My.Resources.Resources.FormFooterrBlueGradiant
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 422)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(302, 23)
        Me.Panel2.TabIndex = 98
        '
        'Panel4
        '
        Me.Panel4.BackgroundImage = CType(resources.GetObject("Panel4.BackgroundImage"), System.Drawing.Image)
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(299, 26)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(3, 396)
        Me.Panel4.TabIndex = 111
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = Global.HerosVillianRegistration.My.Resources.Resources.FormHeader2BlueGradiant
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 26)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(3, 396)
        Me.Panel3.TabIndex = 112
        '
        'ListEvents
        '
        Me.ListEvents.BackColor = System.Drawing.Color.Black
        Me.ListEvents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListEvents.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListEvents.ForeColor = System.Drawing.Color.Lime
        Me.ListEvents.FormattingEnabled = True
        Me.ListEvents.Location = New System.Drawing.Point(3, 26)
        Me.ListEvents.Name = "ListEvents"
        Me.ListEvents.Size = New System.Drawing.Size(296, 396)
        Me.ListEvents.TabIndex = 113
        '
        'FontDialog1
        '
        '
        'BattleEventLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(302, 445)
        Me.Controls.Add(Me.ListEvents)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BattleEventLog"
        Me.Text = "BattleEventLog"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents ListEvents As System.Windows.Forms.ListBox
    Friend WithEvents btnSaveEvent As System.Windows.Forms.Button
    Friend WithEvents sfdBattleEvents As System.Windows.Forms.SaveFileDialog
    Friend WithEvents btnMaximize As System.Windows.Forms.Button
    Friend WithEvents btnFont As System.Windows.Forms.Button
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
End Class
