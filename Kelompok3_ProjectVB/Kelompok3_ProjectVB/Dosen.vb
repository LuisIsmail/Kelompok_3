Public Class Dosen

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Hide()
        Home.Show()
    End Sub

    Private Sub Dosen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Projekvb1DataSet.Dosen' table. You can move, or remove it, as needed.
        Me.DosenTableAdapter.Fill(Me.Projekvb1DataSet.Dosen)
        'TODO: This line of code loads data into the 'Projekvb1DataSet.Dosen' table. You can move, or remove it, as needed.
        Me.DosenTableAdapter.Fill(Me.Projekvb1DataSet.Dosen)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        On Error GoTo SaveErr
        DosenBindingSource.EndEdit()
        DosenTableAdapter.Update(Projekvb1DataSet.Dosen)
        MessageBox.Show("Tersimpan !")
SaveErr:
        Exit Sub
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        DosenBindingSource.AddNew()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.DosenTableAdapter.Fill(Me.Projekvb1DataSet.Dosen)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        DosenBindingSource.CancelEdit()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        DosenBindingSource.RemoveCurrent()
        MessageBox.Show("Terhapus !")
    End Sub

    Private Sub CariButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CariButton.Click
        DosenTableAdapter.cariQuery(Projekvb1DataSet.Dosen)
    End Sub
End Class