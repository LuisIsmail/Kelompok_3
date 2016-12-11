Public Class Absensi

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Hide()
        Home.Show()
    End Sub

    Private Sub Absensi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Projekvb1DataSet.Absen' table. You can move, or remove it, as needed.
        Me.AbsenTableAdapter.Fill(Me.Projekvb1DataSet.Absen)
        'TODO: This line of code loads data into the 'Projekvb1DataSet.Absen' table. You can move, or remove it, as needed.
        Me.AbsenTableAdapter.Fill(Me.Projekvb1DataSet.Absen)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        AbsenBindingSource.AddNew()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        On Error GoTo SaveErr
        AbsenBindingSource.EndEdit()
        AbsenTableAdapter.Update(Projekvb1DataSet.Absen)
        MessageBox.Show("Tersimpan !")
SaveErr:
        Exit Sub
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        AbsenBindingSource.CancelEdit()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        AbsenBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        AbsenBindingSource.RemoveCurrent()
    End Sub
End Class