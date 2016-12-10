<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dosen
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
        Dim NIKLabel As System.Windows.Forms.Label
        Dim NamaLabel As System.Windows.Forms.Label
        Dim Lulusan__S1__S2__S3_Label As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dosen))
        Dim Label1 As System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Detail = New System.Windows.Forms.GroupBox()
        Me.NIKTextBox = New System.Windows.Forms.TextBox()
        Me.DosenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Projekvb1DataSet = New Kelompok3_ProjectVB.projekvb1DataSet()
        Me.NamaTextBox = New System.Windows.Forms.TextBox()
        Me.Lulusan__S1__S2__S3_TextBox = New System.Windows.Forms.TextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DosenDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DosenTableAdapter = New Kelompok3_ProjectVB.projekvb1DataSetTableAdapters.DosenTableAdapter()
        Me.TableAdapterManager = New Kelompok3_ProjectVB.projekvb1DataSetTableAdapters.TableAdapterManager()
        NIKLabel = New System.Windows.Forms.Label()
        NamaLabel = New System.Windows.Forms.Label()
        Lulusan__S1__S2__S3_Label = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Me.Detail.SuspendLayout()
        CType(Me.DosenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Projekvb1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DosenDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NIKLabel
        '
        NIKLabel.AutoSize = True
        NIKLabel.Location = New System.Drawing.Point(18, 22)
        NIKLabel.Name = "NIKLabel"
        NIKLabel.Size = New System.Drawing.Size(28, 13)
        NIKLabel.TabIndex = 0
        NIKLabel.Text = "NIK:"
        '
        'NamaLabel
        '
        NamaLabel.AutoSize = True
        NamaLabel.Location = New System.Drawing.Point(18, 48)
        NamaLabel.Name = "NamaLabel"
        NamaLabel.Size = New System.Drawing.Size(38, 13)
        NamaLabel.TabIndex = 2
        NamaLabel.Text = "Nama:"
        '
        'Lulusan__S1__S2__S3_Label
        '
        Lulusan__S1__S2__S3_Label.AutoSize = True
        Lulusan__S1__S2__S3_Label.Location = New System.Drawing.Point(18, 74)
        Lulusan__S1__S2__S3_Label.Name = "Lulusan__S1__S2__S3_Label"
        Lulusan__S1__S2__S3_Label.Size = New System.Drawing.Size(107, 13)
        Lulusan__S1__S2__S3_Label.TabIndex = 4
        Lulusan__S1__S2__S3_Label.Text = "Lulusan (S1, S2, S3):"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(7, 7)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(178, 33)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Data Dosen"
        '
        'Detail
        '
        Me.Detail.BackColor = System.Drawing.Color.Transparent
        Me.Detail.Controls.Add(NIKLabel)
        Me.Detail.Controls.Add(Me.NIKTextBox)
        Me.Detail.Controls.Add(NamaLabel)
        Me.Detail.Controls.Add(Me.NamaTextBox)
        Me.Detail.Controls.Add(Lulusan__S1__S2__S3_Label)
        Me.Detail.Controls.Add(Me.Lulusan__S1__S2__S3_TextBox)
        Me.Detail.ForeColor = System.Drawing.Color.White
        Me.Detail.Location = New System.Drawing.Point(13, 50)
        Me.Detail.Name = "Detail"
        Me.Detail.Size = New System.Drawing.Size(237, 124)
        Me.Detail.TabIndex = 28
        Me.Detail.TabStop = False
        Me.Detail.Text = "Detail"
        '
        'NIKTextBox
        '
        Me.NIKTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DosenBindingSource, "NIK", True))
        Me.NIKTextBox.Location = New System.Drawing.Point(131, 19)
        Me.NIKTextBox.Name = "NIKTextBox"
        Me.NIKTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NIKTextBox.TabIndex = 1
        '
        'DosenBindingSource
        '
        Me.DosenBindingSource.DataMember = "Dosen"
        Me.DosenBindingSource.DataSource = Me.Projekvb1DataSet
        '
        'Projekvb1DataSet
        '
        Me.Projekvb1DataSet.DataSetName = "projekvb1DataSet"
        Me.Projekvb1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NamaTextBox
        '
        Me.NamaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DosenBindingSource, "Nama", True))
        Me.NamaTextBox.Location = New System.Drawing.Point(131, 45)
        Me.NamaTextBox.Name = "NamaTextBox"
        Me.NamaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NamaTextBox.TabIndex = 3
        '
        'Lulusan__S1__S2__S3_TextBox
        '
        Me.Lulusan__S1__S2__S3_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DosenBindingSource, "Lulusan (S1, S2, S3)", True))
        Me.Lulusan__S1__S2__S3_TextBox.Location = New System.Drawing.Point(131, 71)
        Me.Lulusan__S1__S2__S3_TextBox.Name = "Lulusan__S1__S2__S3_TextBox"
        Me.Lulusan__S1__S2__S3_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Lulusan__S1__S2__S3_TextBox.TabIndex = 5
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Transparent
        Me.Button6.BackgroundImage = CType(resources.GetObject("Button6.BackgroundImage"), System.Drawing.Image)
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Location = New System.Drawing.Point(175, 258)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(64, 63)
        Me.Button6.TabIndex = 34
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(94, 258)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(64, 63)
        Me.Button5.TabIndex = 33
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(13, 258)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(64, 63)
        Me.Button4.TabIndex = 32
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(175, 190)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(64, 63)
        Me.Button3.TabIndex = 31
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(94, 190)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(64, 63)
        Me.Button2.TabIndex = 30
        Me.Button2.UseVisualStyleBackColor = False
        '
        'DosenDataGridView
        '
        Me.DosenDataGridView.AutoGenerateColumns = False
        Me.DosenDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DosenDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.DosenDataGridView.DataSource = Me.DosenBindingSource
        Me.DosenDataGridView.Location = New System.Drawing.Point(278, 69)
        Me.DosenDataGridView.Name = "DosenDataGridView"
        Me.DosenDataGridView.Size = New System.Drawing.Size(345, 252)
        Me.DosenDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NIK"
        Me.DataGridViewTextBoxColumn1.HeaderText = "NIK"
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
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Lulusan (S1, S2, S3)"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Lulusan (S1, S2, S3)"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(13, 190)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(64, 63)
        Me.Button1.TabIndex = 27
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DosenTableAdapter
        '
        Me.DosenTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AbsenTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DosenTableAdapter = Me.DosenTableAdapter
        Me.TableAdapterManager.J1TableAdapter = Nothing
        Me.TableAdapterManager.J3TableAdapter = Nothing
        Me.TableAdapterManager.J5TableAdapter = Nothing
        Me.TableAdapterManager.J7TableAdapter = Nothing
        Me.TableAdapterManager.Mhs1TableAdapter = Nothing
        Me.TableAdapterManager.Mhs3TableAdapter = Nothing
        Me.TableAdapterManager.Mhs5TableAdapter = Nothing
        Me.TableAdapterManager.Mhs7TableAdapter = Nothing
        Me.TableAdapterManager.MK1TableAdapter = Nothing
        Me.TableAdapterManager.MK3TableAdapter = Nothing
        Me.TableAdapterManager.MK5TableAdapter = Nothing
        Me.TableAdapterManager.MK7TableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Kelompok3_ProjectVB.projekvb1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.BackColor = System.Drawing.Color.Transparent
        Label1.ForeColor = System.Drawing.Color.White
        Label1.Location = New System.Drawing.Point(277, 55)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(34, 13)
        Label1.TabIndex = 6
        Label1.Text = "Tabel"
        '
        'Dosen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(655, 336)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.DosenDataGridView)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Detail)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Dosen"
        Me.Text = "Dosen"
        Me.Detail.ResumeLayout(False)
        Me.Detail.PerformLayout()
        CType(Me.DosenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Projekvb1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DosenDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Detail As System.Windows.Forms.GroupBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Projekvb1DataSet As Kelompok3_ProjectVB.projekvb1DataSet
    Friend WithEvents DosenBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DosenTableAdapter As Kelompok3_ProjectVB.projekvb1DataSetTableAdapters.DosenTableAdapter
    Friend WithEvents TableAdapterManager As Kelompok3_ProjectVB.projekvb1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents NIKTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NamaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Lulusan__S1__S2__S3_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents DosenDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
