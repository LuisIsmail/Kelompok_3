<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Absensi
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
        Dim KeteranganLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Absensi))
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Detail = New System.Windows.Forms.GroupBox()
        Me.NIMTextBox = New System.Windows.Forms.TextBox()
        Me.AbsenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Projekvb1DataSet = New Kelompok3_ProjectVB.projekvb1DataSet()
        Me.NamaTextBox = New System.Windows.Forms.TextBox()
        Me.KeteranganTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.AbsenTableAdapter = New Kelompok3_ProjectVB.projekvb1DataSetTableAdapters.AbsenTableAdapter()
        Me.TableAdapterManager = New Kelompok3_ProjectVB.projekvb1DataSetTableAdapters.TableAdapterManager()
        Me.AbsenDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        NIMLabel = New System.Windows.Forms.Label()
        NamaLabel = New System.Windows.Forms.Label()
        KeteranganLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Me.Detail.SuspendLayout()
        CType(Me.AbsenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Projekvb1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AbsenDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NIMLabel
        '
        NIMLabel.AutoSize = True
        NIMLabel.Location = New System.Drawing.Point(17, 16)
        NIMLabel.Name = "NIMLabel"
        NIMLabel.Size = New System.Drawing.Size(30, 13)
        NIMLabel.TabIndex = 0
        NIMLabel.Text = "NIM:"
        '
        'NamaLabel
        '
        NamaLabel.AutoSize = True
        NamaLabel.Location = New System.Drawing.Point(17, 42)
        NamaLabel.Name = "NamaLabel"
        NamaLabel.Size = New System.Drawing.Size(38, 13)
        NamaLabel.TabIndex = 2
        NamaLabel.Text = "Nama:"
        '
        'KeteranganLabel
        '
        KeteranganLabel.AutoSize = True
        KeteranganLabel.Location = New System.Drawing.Point(17, 68)
        KeteranganLabel.Name = "KeteranganLabel"
        KeteranganLabel.Size = New System.Drawing.Size(65, 13)
        KeteranganLabel.TabIndex = 4
        KeteranganLabel.Text = "Keterangan:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.BackColor = System.Drawing.Color.Transparent
        Label1.ForeColor = System.Drawing.Color.Transparent
        Label1.Location = New System.Drawing.Point(258, 50)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(34, 13)
        Label1.TabIndex = 46
        Label1.Text = "Tabel"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(7, 7)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(333, 33)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "Absensi Mahasiswa MI"
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
        Me.Button5.TabIndex = 42
        Me.Button5.UseVisualStyleBackColor = False
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
        Me.Button6.TabIndex = 43
        Me.Button6.UseVisualStyleBackColor = False
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
        Me.Button4.TabIndex = 41
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
        Me.Button3.TabIndex = 40
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
        Me.Button2.TabIndex = 39
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Detail
        '
        Me.Detail.BackColor = System.Drawing.Color.Transparent
        Me.Detail.Controls.Add(NIMLabel)
        Me.Detail.Controls.Add(Me.NIMTextBox)
        Me.Detail.Controls.Add(NamaLabel)
        Me.Detail.Controls.Add(Me.NamaTextBox)
        Me.Detail.Controls.Add(KeteranganLabel)
        Me.Detail.Controls.Add(Me.KeteranganTextBox)
        Me.Detail.ForeColor = System.Drawing.Color.White
        Me.Detail.Location = New System.Drawing.Point(13, 50)
        Me.Detail.Name = "Detail"
        Me.Detail.Size = New System.Drawing.Size(226, 96)
        Me.Detail.TabIndex = 37
        Me.Detail.TabStop = False
        Me.Detail.Text = "Detail"
        '
        'NIMTextBox
        '
        Me.NIMTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AbsenBindingSource, "NIM", True))
        Me.NIMTextBox.Location = New System.Drawing.Point(88, 13)
        Me.NIMTextBox.Name = "NIMTextBox"
        Me.NIMTextBox.Size = New System.Drawing.Size(132, 20)
        Me.NIMTextBox.TabIndex = 1
        '
        'AbsenBindingSource
        '
        Me.AbsenBindingSource.DataMember = "Absen"
        Me.AbsenBindingSource.DataSource = Me.Projekvb1DataSet
        '
        'Projekvb1DataSet
        '
        Me.Projekvb1DataSet.DataSetName = "projekvb1DataSet"
        Me.Projekvb1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NamaTextBox
        '
        Me.NamaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AbsenBindingSource, "Nama", True))
        Me.NamaTextBox.Location = New System.Drawing.Point(88, 39)
        Me.NamaTextBox.Name = "NamaTextBox"
        Me.NamaTextBox.Size = New System.Drawing.Size(132, 20)
        Me.NamaTextBox.TabIndex = 3
        '
        'KeteranganTextBox
        '
        Me.KeteranganTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AbsenBindingSource, "Keterangan", True))
        Me.KeteranganTextBox.Location = New System.Drawing.Point(88, 65)
        Me.KeteranganTextBox.Name = "KeteranganTextBox"
        Me.KeteranganTextBox.Size = New System.Drawing.Size(132, 20)
        Me.KeteranganTextBox.TabIndex = 5
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
        Me.Button1.TabIndex = 36
        Me.Button1.UseVisualStyleBackColor = False
        '
        'AbsenTableAdapter
        '
        Me.AbsenTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AbsenTableAdapter = Me.AbsenTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DosenTableAdapter = Nothing
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
        'AbsenDataGridView
        '
        Me.AbsenDataGridView.AutoGenerateColumns = False
        Me.AbsenDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AbsenDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.AbsenDataGridView.DataSource = Me.AbsenBindingSource
        Me.AbsenDataGridView.Location = New System.Drawing.Point(259, 63)
        Me.AbsenDataGridView.Name = "AbsenDataGridView"
        Me.AbsenDataGridView.Size = New System.Drawing.Size(343, 258)
        Me.AbsenDataGridView.TabIndex = 0
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
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Keterangan"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Keterangan"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'Absensi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(614, 359)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.AbsenDataGridView)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Detail)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Absensi"
        Me.Text = "Absensi"
        Me.Detail.ResumeLayout(False)
        Me.Detail.PerformLayout()
        CType(Me.AbsenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Projekvb1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AbsenDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Detail As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Projekvb1DataSet As Kelompok3_ProjectVB.projekvb1DataSet
    Friend WithEvents AbsenBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AbsenTableAdapter As Kelompok3_ProjectVB.projekvb1DataSetTableAdapters.AbsenTableAdapter
    Friend WithEvents TableAdapterManager As Kelompok3_ProjectVB.projekvb1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents AbsenDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NIMTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NamaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents KeteranganTextBox As System.Windows.Forms.TextBox
End Class
