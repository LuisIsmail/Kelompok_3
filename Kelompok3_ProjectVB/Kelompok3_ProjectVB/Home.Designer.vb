<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Me.keluar_Button = New System.Windows.Forms.Button()
        Me.waktu_Button = New System.Windows.Forms.Button()
        Me.matkul_Button = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Abseni_Button = New System.Windows.Forms.Button()
        Me.Dosen_Button = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Mhs_Button = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'keluar_Button
        '
        Me.keluar_Button.BackColor = System.Drawing.Color.Red
        Me.keluar_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.keluar_Button.FlatAppearance.BorderSize = 0
        Me.keluar_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.keluar_Button.ForeColor = System.Drawing.Color.Black
        Me.keluar_Button.Location = New System.Drawing.Point(171, 103)
        Me.keluar_Button.Name = "keluar_Button"
        Me.keluar_Button.Size = New System.Drawing.Size(75, 34)
        Me.keluar_Button.TabIndex = 6
        Me.keluar_Button.Text = "Keluar"
        Me.keluar_Button.UseVisualStyleBackColor = False
        '
        'waktu_Button
        '
        Me.waktu_Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.waktu_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.waktu_Button.FlatAppearance.BorderSize = 0
        Me.waktu_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.waktu_Button.ForeColor = System.Drawing.Color.Black
        Me.waktu_Button.Location = New System.Drawing.Point(122, 74)
        Me.waktu_Button.Name = "waktu_Button"
        Me.waktu_Button.Size = New System.Drawing.Size(179, 23)
        Me.waktu_Button.TabIndex = 5
        Me.waktu_Button.Text = "Jadwal"
        Me.waktu_Button.UseVisualStyleBackColor = False
        '
        'matkul_Button
        '
        Me.matkul_Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.matkul_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.matkul_Button.FlatAppearance.BorderSize = 0
        Me.matkul_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.matkul_Button.ForeColor = System.Drawing.Color.Black
        Me.matkul_Button.Location = New System.Drawing.Point(6, 74)
        Me.matkul_Button.Name = "matkul_Button"
        Me.matkul_Button.Size = New System.Drawing.Size(110, 63)
        Me.matkul_Button.TabIndex = 4
        Me.matkul_Button.Text = "Mata Kuliah"
        Me.matkul_Button.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(237, 33)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Aplikasi Perkuliahan"
        '
        'Abseni_Button
        '
        Me.Abseni_Button.BackColor = System.Drawing.Color.SkyBlue
        Me.Abseni_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Abseni_Button.FlatAppearance.BorderSize = 0
        Me.Abseni_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Abseni_Button.ForeColor = System.Drawing.Color.Black
        Me.Abseni_Button.Location = New System.Drawing.Point(203, 19)
        Me.Abseni_Button.Name = "Abseni_Button"
        Me.Abseni_Button.Size = New System.Drawing.Size(98, 49)
        Me.Abseni_Button.TabIndex = 3
        Me.Abseni_Button.Text = "Absensi"
        Me.Abseni_Button.UseVisualStyleBackColor = False
        '
        'Dosen_Button
        '
        Me.Dosen_Button.BackColor = System.Drawing.Color.Cyan
        Me.Dosen_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Dosen_Button.FlatAppearance.BorderSize = 0
        Me.Dosen_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dosen_Button.ForeColor = System.Drawing.Color.Black
        Me.Dosen_Button.Location = New System.Drawing.Point(122, 19)
        Me.Dosen_Button.Name = "Dosen_Button"
        Me.Dosen_Button.Size = New System.Drawing.Size(75, 49)
        Me.Dosen_Button.TabIndex = 2
        Me.Dosen_Button.Text = "Dosen"
        Me.Dosen_Button.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.keluar_Button)
        Me.GroupBox1.Controls.Add(Me.waktu_Button)
        Me.GroupBox1.Controls.Add(Me.matkul_Button)
        Me.GroupBox1.Controls.Add(Me.Abseni_Button)
        Me.GroupBox1.Controls.Add(Me.Dosen_Button)
        Me.GroupBox1.Controls.Add(Me.Mhs_Button)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(18, 68)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(307, 152)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Menu Utama"
        '
        'Mhs_Button
        '
        Me.Mhs_Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Mhs_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Mhs_Button.FlatAppearance.BorderSize = 0
        Me.Mhs_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mhs_Button.ForeColor = System.Drawing.Color.Black
        Me.Mhs_Button.Location = New System.Drawing.Point(6, 19)
        Me.Mhs_Button.Name = "Mhs_Button"
        Me.Mhs_Button.Size = New System.Drawing.Size(110, 49)
        Me.Mhs_Button.TabIndex = 1
        Me.Mhs_Button.Text = "Mahasiswa"
        Me.Mhs_Button.UseVisualStyleBackColor = False
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 229)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Home"
        Me.Text = "Home"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents keluar_Button As System.Windows.Forms.Button
    Friend WithEvents waktu_Button As System.Windows.Forms.Button
    Friend WithEvents matkul_Button As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Abseni_Button As System.Windows.Forms.Button
    Friend WithEvents Dosen_Button As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Mhs_Button As System.Windows.Forms.Button

End Class
