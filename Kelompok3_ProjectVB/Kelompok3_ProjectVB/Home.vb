Public Class Home

    Private Sub Mhs_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mhs_Button.Click
        Me.Hide()
        Mahasiswa.Show()
    End Sub

    Private Sub Dosen_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dosen_Button.Click
        Me.Hide()
        Dosen.Show()
    End Sub

    Private Sub Abseni_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Abseni_Button.Click
        Me.Hide()
        Absensi.Show()
    End Sub

    Private Sub matkul_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles matkul_Button.Click
        Me.Hide()
        MK.Show()
    End Sub

    Private Sub waktu_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles waktu_Button.Click
        Me.Hide()
        Jadwal.Show()
    End Sub

    Private Sub keluar_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles keluar_Button.Click
        Me.Close()
    End Sub
End Class
