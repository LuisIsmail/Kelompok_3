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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dosen))
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Detail = New System.Windows.Forms.GroupBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Keterangan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NIM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Tabel = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Detail.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tabel.SuspendLayout()
        Me.SuspendLayout()
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
        Me.Detail.Controls.Add(Me.TextBox6)
        Me.Detail.Controls.Add(Me.Label6)
        Me.Detail.Controls.Add(Me.TextBox5)
        Me.Detail.Controls.Add(Me.Label5)
        Me.Detail.Controls.Add(Me.TextBox4)
        Me.Detail.Controls.Add(Me.Label4)
        Me.Detail.ForeColor = System.Drawing.Color.White
        Me.Detail.Location = New System.Drawing.Point(13, 50)
        Me.Detail.Name = "Detail"
        Me.Detail.Size = New System.Drawing.Size(226, 117)
        Me.Detail.TabIndex = 28
        Me.Detail.TabStop = False
        Me.Detail.Text = "Detail"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(81, 78)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(139, 20)
        Me.TextBox6.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Lulusan"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(81, 47)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(139, 20)
        Me.TextBox5.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Nama"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(81, 16)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(139, 20)
        Me.TextBox4.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "NIK"
        '
        'Keterangan
        '
        Me.Keterangan.DataPropertyName = "Keterangan"
        Me.Keterangan.HeaderText = "Keterangan"
        Me.Keterangan.Name = "Keterangan"
        '
        'Nama
        '
        Me.Nama.HeaderText = "Nama"
        Me.Nama.Name = "Nama"
        '
        'NIM
        '
        Me.NIM.DataPropertyName = "NIM"
        Me.NIM.HeaderText = "NIM"
        Me.NIM.Name = "NIM"
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
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToOrderColumns = True
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NIM, Me.Nama, Me.Keterangan})
        Me.DataGridView2.Location = New System.Drawing.Point(6, 19)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(341, 248)
        Me.DataGridView2.TabIndex = 0
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
        'Tabel
        '
        Me.Tabel.BackColor = System.Drawing.Color.Transparent
        Me.Tabel.Controls.Add(Me.DataGridView2)
        Me.Tabel.ForeColor = System.Drawing.Color.White
        Me.Tabel.Location = New System.Drawing.Point(256, 50)
        Me.Tabel.Name = "Tabel"
        Me.Tabel.Size = New System.Drawing.Size(352, 273)
        Me.Tabel.TabIndex = 29
        Me.Tabel.TabStop = False
        Me.Tabel.Text = "Tabel"
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
        'Dosen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 328)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Detail)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Tabel)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Dosen"
        Me.Text = "Dosen"
        Me.Detail.ResumeLayout(False)
        Me.Detail.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tabel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Detail As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Keterangan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nama As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NIM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Tabel As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
