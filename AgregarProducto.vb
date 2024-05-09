Public Class AgregarProducto
    Private Sub ProductoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ProductoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.NewDataSet)
    End Sub

    Private Sub AgregarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'NewDataSet.producto' Puede moverla o quitarla según sea necesario.
        Actualiza()
    End Sub
    Private Sub Actualiza()
        Me.ProductoTableAdapter.Fill(Me.NewDataSet.producto)
    End Sub

    Function Completo() As Boolean
        If Cod_proTextBox.Text = "" Or DescripcionTextBox.Text = "" Or PrecioTextBox.Text = "" Or StockTextBox.Text = "" Then
            Completo = False
        Else
            Completo = True
        End If
    End Function
    Private Sub BlockBtn()
        ProductoDataGridView.Enabled = False
        btnNuevo.Visible = False
        btnEliminar.Visible = False
    End Sub

    Private Sub UnblockBtn()
        ProductoDataGridView.Enabled = True
        btnNuevo.Visible = True
        btnEliminar.Visible = True
    End Sub

    Private Sub BlockLabels()
        Cod_proTextBox.Enabled = False
        DescripcionTextBox.Enabled = False
        PrecioTextBox.Enabled = False
        StockTextBox.Enabled = False
    End Sub
    Private Sub UnblockLabels()
        DescripcionTextBox.Enabled = True
        PrecioTextBox.Enabled = True
        StockTextBox.Enabled = True
    End Sub
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim NuevoFolio As Integer
        Me.ProductoBindingSource.MoveLast()
        NuevoFolio = Val(Cod_proTextBox.Text) + 1
        BlockBtn()
        UnblockLabels()
        ProductoBindingSource.AddNew()
        Cod_proTextBox.Text = NuevoFolio
        DescripcionTextBox.Focus()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        Dim Borrar
        Borrar = MsgBox("¿Desea eliminar este registro?", vbCritical + vbYesNo + vbDefaultButton2, "C O N F I R M A R")
        If Borrar = vbYes Then
            ProductoBindingSource.RemoveCurrent()
            ProductoTableAdapter.Update(NewDataSet.producto)
            Actualiza()
        Else
            ProductoBindingSource.CancelEdit()
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Completo() Then
            ProductoBindingSource.EndEdit()
            ProductoTableAdapter.Update(NewDataSet.producto)
            UnblockBtn()
            BlockLabels()
            Actualiza()
        Else
            MsgBox("El registro esta incompleto")
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        UnblockBtn()
        BlockLabels()
        ProductoBindingSource.CancelEdit()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        UnblockLabels()
        BlockBtn()
    End Sub

End Class