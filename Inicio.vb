Public Class Inicio
    Private Sub btnMenuClientes_Click(sender As Object, e As EventArgs) Handles btnMenuClientes.Click
        Dim MdiForm As New AgregarCliente
        MdiForm.MdiParent = Me
        MdiForm.Show()
    End Sub




    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem.Click
        Dim MdiForm As New AgregarProducto
        MdiForm.MdiParent = Me
        MdiForm.Show()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        Dim MdiForm As New Ventas
        MdiForm.MdiParent = Me
        MdiForm.Show()
        Dim MdiForm2 As New AgregarCliente
        MdiForm2.MdiParent = Me
        MdiForm2.Close()
        Dim MdiForm3 As New AgregarProducto
        MdiForm3.MdiParent = Me
        MdiForm3.Close()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()

    End Sub

End Class
