<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mhs1
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
        Dim NIMLabel As System.Windows.Forms.Label
        Dim NamaLabel As System.Windows.Forms.Label
        Dim ProdiLabel As System.Windows.Forms.Label
        Dim SemesterLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mhs1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Projekvb1DataSet = New Kelompok3_ProjectVB.projekvb1DataSet()
        Me.Mhs1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Mhs1TableAdapter = New Kelompok3_ProjectVB.projekvb1DataSetTableAdapters.Mhs1TableAdapter()
        Me.TableAdapterManager = New Kelompok3_ProjectVB.projekvb1DataSetTableAdapters.TableAdapterManager()
        Me.NIMTextBox = New System.Windows.Forms.TextBox()
        Me.NamaTextBox = New System.Windows.Forms.TextBox()
        Me.ProdiTextBox = New System.Windows.Forms.TextBox()
        Me.SemesterTextBox = New System.Windows.Forms.TextBox()
        Me.Mhs1DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hapusButton = New System.Windows.Forms.Button()
        Me.homeButton = New System.Windows.Forms.Button()
        Me.cancelButton = New System.Windows.Forms.Button()
        Me.refreshButton = New System.Windows.Forms.Button()
        Me.saveButton = New System.Windows.Forms.Button()
        Me.addButton = New System.Windows.Forms.Button()
        NIMLabel = New System.Windows.Forms.Label()
        NamaLabel = New System.Windows.Forms.Label()
        ProdiLabel = New System.Windows.Forms.Label()
        SemesterLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Projekvb1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mhs1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mhs1DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(NIMLabel)
        Me.GroupBox1.Controls.Add(Me.NIMTextBox)
        Me.GroupBox1.Controls.Add(NamaLabel)
        Me.GroupBox1.Controls.Add(Me.NamaTextBox)
        Me.GroupBox1.Controls.Add(ProdiLabel)
        Me.GroupBox1.Controls.Add(Me.ProdiTextBox)
        Me.GroupBox1.Controls.Add(SemesterLabel)
        Me.GroupBox1.Controls.Add(Me.SemesterTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(249, 119)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detail"
        '
        'Projekvb1DataSet
        '
        Me.Projekvb1DataSet.DataSetName = "projekvb1DataSet"
        Me.Projekvb1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Mhs1BindingSource
        '
        Me.Mhs1BindingSource.DataMember = "Mhs1"
        Me.Mhs1BindingSource.DataSource = Me.Projekvb1DataSet
        '
        'Mhs1TableAdapter
        '
        Me.Mhs1TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AbsenTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DosenTableAdapter = Nothing
        Me.TableAdapterManager.J1TableAdapter = Nothing
        Me.TableAdapterManager.J3TableAdapter = Nothing
        Me.TableAdapterManager.J5TableAdapter = Nothing
        Me.TableAdapterManager.J7TableAdapter = Nothing
        Me.TableAdapterManager.Mhs1TableAdapter = Me.Mhs1TableAdapter
        Me.TableAdapterManager.Mhs3TableAdapter = Nothing
        Me.TableAdapterManager.Mhs5TableAdapter = Nothing
        Me.TableAdapterManager.Mhs7TableAdapter = Nothing
        Me.TableAdapterManager.MK1TableAdapter = Nothing
        Me.TableAdapterManager.MK3TableAdapter = Nothing
        Me.TableAdapterManager.MK5TableAdapter = Nothing
        Me.TableAdapterManager.MK7TableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Kelompok3_ProjectVB.projekvb1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'NIMLabel
        '
        NIMLabel.AutoSize = True
        NIMLabel.Location = New System.Drawing.Point(20, 16)
        NIMLabel.Name = "NIMLabel"
        NIMLabel.Size = New System.Drawing.Size(30, 13)
        NIMLabel.TabIndex = 0
        NIMLabel.Text = "NIM:"
        '
        'NIMTextBox
        '
        Me.NIMTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Mhs1BindingSource, "NIM", True))
        Me.NIMTextBox.Location = New System.Drawing.Point(80, 13)
        Me.NIMTextBox.Name = "NIMTextBox"
        Me.NIMTextBox.Size = New System.Drawing.Size(126, 20)
        Me.NIMTextBox.TabIndex = 1
        '
        'NamaLabel
        '
        NamaLabel.AutoSize = True
        NamaLabel.Location = New System.Drawing.Point(20, 42)
        NamaLabel.Name = "NamaLabel"
        NamaLabel.Size = New System.Drawing.Size(38, 13)
        NamaLabel.TabIndex = 2
        NamaLabel.Text = "Nama:"
        '
        'NamaTextBox
        '
        Me.NamaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Mhs1BindingSource, "Nama", True))
        Me.NamaTextBox.Location = New System.Drawing.Point(80, 39)
        Me.NamaTextBox.Name = "NamaTextBox"
        Me.NamaTextBox.Size = New System.Drawing.Size(152, 20)
        Me.NamaTextBox.TabIndex = 3
        '
        'ProdiLabel
        '
        ProdiLabel.AutoSize = True
        ProdiLabel.Location = New System.Drawing.Point(20, 68)
        ProdiLabel.Name = "ProdiLabel"
        ProdiLabel.Size = New System.Drawing.Size(34, 13)
        ProdiLabel.TabIndex = 4
        ProdiLabel.Text = "Prodi:"
        '
        'ProdiTextBox
        '
        Me.ProdiTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Mhs1BindingSource, "Prodi", True))
        Me.ProdiTextBox.Location = New System.Drawing.Point(80, 65)
        Me.ProdiTextBox.Name = "ProdiTextBox"
        Me.ProdiTextBox.Size = New System.Drawing.Size(152, 20)
        Me.ProdiTextBox.TabIndex = 5
        '
        'SemesterLabel
        '
        SemesterLabel.AutoSize = True
        SemesterLabel.Location = New System.Drawing.Point(20, 94)
        SemesterLabel.Name = "SemesterLabel"
        SemesterLabel.Size = New System.Drawing.Size(54, 13)
        SemesterLabel.TabIndex = 6
        SemesterLabel.Text = "Semester:"
        '
        'SemesterTextBox
        '
        Me.SemesterTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Mhs1BindingSource, "Semester", True))
        Me.SemesterTextBox.Location = New System.Drawing.Point(80, 91)
        Me.SemesterTextBox.Name = "SemesterTextBox"
        Me.SemesterTextBox.Size = New System.Drawing.Size(64, 20)
        Me.SemesterTextBox.TabIndex = 7
        '
        'Mhs1DataGridView
        '
        Me.Mhs1DataGridView.AutoGenerateColumns = False
        Me.Mhs1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Mhs1DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.Mhs1DataGridView.DataSource = Me.Mhs1BindingSource
        Me.Mhs1DataGridView.Location = New System.Drawing.Point(257, 61)
        Me.Mhs1DataGridView.Name = "Mhs1DataGridView"
        Me.Mhs1DataGridView.Size = New System.Drawing.Size(443, 302)
        Me.Mhs1DataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NIM"
        Me.DataGridViewTextBoxColumn1.HeaderText = "NIM"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nama"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nama"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Prodi"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Prodi"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Semester"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Semester"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(257, 45)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(34, 13)
        Label1.TabIndex = 8
        Label1.Text = "Tabel"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(12, 9)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(188, 31)
        Label2.TabIndex = 9
        Label2.Text = "SEMESTER I"
        '
        'hapusButton
        '
        Me.hapusButton.BackColor = System.Drawing.Color.Transparent
        Me.hapusButton.BackgroundImage = CType(resources.GetObject("hapusButton.BackgroundImage"), System.Drawing.Image)
        Me.hapusButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.hapusButton.FlatAppearance.BorderSize = 0
        Me.hapusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.hapusButton.Location = New System.Drawing.Point(93, 269)
        Me.hapusButton.Name = "hapusButton"
        Me.hapusButton.Size = New System.Drawing.Size(64, 63)
        Me.hapusButton.TabIndex = 48
        Me.hapusButton.UseVisualStyleBackColor = False
        '
        'homeButton
        '
        Me.homeButton.BackColor = System.Drawing.Color.Transparent
        Me.homeButton.BackgroundImage = CType(resources.GetObject("homeButton.BackgroundImage"), System.Drawing.Image)
        Me.homeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.homeButton.FlatAppearance.BorderSize = 0
        Me.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.homeButton.Location = New System.Drawing.Point(174, 269)
        Me.homeButton.Name = "homeButton"
        Me.homeButton.Size = New System.Drawing.Size(64, 63)
        Me.homeButton.TabIndex = 49
        Me.homeButton.UseVisualStyleBackColor = False
        '
        'cancelButton
        '
        Me.cancelButton.BackColor = System.Drawing.Color.Transparent
        Me.cancelButton.BackgroundImage = CType(resources.GetObject("cancelButton.BackgroundImage"), System.Drawing.Image)
        Me.cancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cancelButton.FlatAppearance.BorderSize = 0
        Me.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cancelButton.Location = New System.Drawing.Point(12, 269)
        Me.cancelButton.Name = "cancelButton"
        Me.cancelButton.Size = New System.Drawing.Size(64, 63)
        Me.cancelButton.TabIndex = 47
        Me.cancelButton.UseVisualStyleBackColor = False
        '
        'refreshButton
        '
        Me.refreshButton.BackColor = System.Drawing.Color.Transparent
        Me.refreshButton.BackgroundImage = CType(resources.GetObject("refreshButton.BackgroundImage"), System.Drawing.Image)
        Me.refreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.refreshButton.FlatAppearance.BorderSize = 0
        Me.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.refreshButton.Location = New System.Drawing.Point(174, 201)
        Me.refreshButton.Name = "refreshButton"
        Me.refreshButton.Size = New System.Drawing.Size(64, 63)
        Me.refreshButton.TabIndex = 46
        Me.refreshButton.UseVisualStyleBackColor = False
        '
        'saveButton
        '
        Me.saveButton.BackColor = System.Drawing.Color.Transparent
        Me.saveButton.BackgroundImage = CType(resources.GetObject("saveButton.BackgroundImage"), System.Drawing.Image)
        Me.saveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.saveButton.FlatAppearance.BorderSize = 0
        Me.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.saveButton.Location = New System.Drawing.Point(93, 201)
        Me.saveButton.Name = "saveButton"
        Me.saveButton.Size = New System.Drawing.Size(64, 63)
        Me.saveButton.TabIndex = 45
        Me.saveButton.UseVisualStyleBackColor = False
        '
        'addButton
        '
        Me.addButton.BackColor = System.Drawing.Color.Transparent
        Me.addButton.BackgroundImage = CType(resources.GetObject("addButton.BackgroundImage"), System.Drawing.Image)
        Me.addButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.addButton.FlatAppearance.BorderSize = 0
        Me.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addButton.Location = New System.Drawing.Point(12, 201)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(64, 63)
        Me.addButton.TabIndex = 44
        Me.addButton.UseVisualStyleBackColor = False
        '
        'Mhs1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(702, 366)
        Me.Controls.Add(Me.hapusButton)
        Me.Controls.Add(Me.homeButton)
        Me.Controls.Add(Me.cancelButton)
        Me.Controls.Add(Me.refreshButton)
        Me.Controls.Add(Me.saveButton)
        Me.Controls.Add(Me.addButton)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.Mhs1DataGridView)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Mhs1"
        Me.Text = "Mhs1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Projekvb1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mhs1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mhs1DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Projekvb1DataSet As Kelompok3_ProjectVB.projekvb1DataSet
    Friend WithEvents Mhs1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Mhs1TableAdapter As Kelompok3_ProjectVB.projekvb1DataSetTableAdapters.Mhs1TableAdapter
    Friend WithEvents TableAdapterManager As Kelompok3_ProjectVB.projekvb1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents NIMTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NamaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProdiTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SemesterTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Mhs1DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents hapusButton As System.Windows.Forms.Button
    Friend WithEvents homeButton As System.Windows.Forms.Button
    Friend WithEvents cancelButton As System.Windows.Forms.Button
    Friend WithEvents refreshButton As System.Windows.Forms.Button
    Friend WithEvents saveButton As System.Windows.Forms.Button
    Friend WithEvents addButton As System.Windows.Forms.Button
End Class
