Public Class Clientes
    Private Sub ClienteBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) 
        Me.Validate()
        Me.ClienteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.NewDataSet)

    End Sub

    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'NewDataSet.cliente' Puede moverla o quitarla según sea necesario.
        Me.ClienteTableAdapter.Fill(Me.NewDataSet.cliente)

    End Sub

    Private Sub ClienteDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ClienteDataGridView.CellContentClick

    End Sub
End Class