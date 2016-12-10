Public Class Absensi

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Hide()
        Home.Show()
    End Sub

    Private Sub Absensi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Projekvb1DataSet.Absen' table. You can move, or remove it, as needed.
        Me.AbsenTableAdapter.Fill(Me.Projekvb1DataSet.Absen)

    End Sub
End Class