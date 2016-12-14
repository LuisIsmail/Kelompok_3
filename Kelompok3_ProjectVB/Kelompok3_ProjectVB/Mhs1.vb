Public Class Mhs1

    Private Sub Mhs1BindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.Mhs1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Projekvb1DataSet)

    End Sub

    Private Sub Mhs1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Projekvb1DataSet.Mhs1' table. You can move, or remove it, as needed.
        Me.Mhs1TableAdapter.Fill(Me.Projekvb1DataSet.Mhs1)

    End Sub

    Private Sub addButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addButton.Click
        Mhs1BindingSource.AddNew()
    End Sub

    Private Sub saveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles saveButton.Click
        On Error GoTo SaveErr
        Mhs1BindingSource.EndEdit()
        Mhs1TableAdapter.Update(Projekvb1DataSet.Mhs1)
        MessageBox.Show("Tersimpan !")
SaveErr:
        Exit Sub
    End Sub

    Private Sub refreshButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles refreshButton.Click
        Mhs1BindingSource.ResetCurrentItem()
    End Sub

    Private Sub cancelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancelButton.Click
        Mhs1BindingSource.CancelEdit()
    End Sub

    Private Sub hapusButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hapusButton.Click
        Mhs1BindingSource.RemoveCurrent()
    End Sub

    Private Sub homeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles homeButton.Click
        Me.Close()
        Home.Show()
    End Sub
End Class