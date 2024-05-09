Public Class AgregarCliente

    Private Sub ClienteBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ClienteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.NewDataSet)
    End Sub

    Private Sub AgregarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'NewDataSet.cliente' Puede moverla o quitarla según sea necesario.
        Actualiza()
    End Sub


    Private Sub Actualiza()
        Try
            Me.ClienteTableAdapter.Fill(Me.NewDataSet.cliente)
        Catch
            MsgBox("Error de conexión")
        End Try
    End Sub

    Private Sub BlockBtn()
        ClienteDataGridView.Enabled = False
        btnNuevo.Enabled = False
        btnEliminar.Enabled = False
    End Sub

    Private Sub UnblockBtn()
        ClienteDataGridView.Enabled = True
        btnNuevo.Enabled = True
        btnEliminar.Enabled = True
    End Sub

    Private Sub BlockLabels()
        Cod_cliTextBox.Enabled = False
        Nom_cliTextBox.Enabled = False
        Ape_cliTextBox.Enabled = False
        Tel_cliTextBox.Enabled = False
        Email_cliTextBox.Enabled = False
        Sexo_cliComboBox.Enabled = False
        Dir_cliTextBox.Enabled = False
        Ruc_cliTextBox.Enabled = False
        Dni_cliTextBox.Enabled = False
    End Sub
    Private Sub UnblockLabels()
        Nom_cliTextBox.Enabled = True
        Ape_cliTextBox.Enabled = True
        Dni_cliTextBox.Enabled = True
        Tel_cliTextBox.Enabled = True
        Email_cliTextBox.Enabled = True
        Sexo_cliComboBox.Enabled = True
        Dir_cliTextBox.Enabled = True
        Ruc_cliTextBox.Enabled = True
    End Sub

    Function Completo() As Boolean
        If Cod_cliTextBox.Text = "" Or Nom_cliTextBox.Text = "" Or Tel_cliTextBox.Text = "" Or Ape_cliTextBox.Text = "" Or Email_cliTextBox.Text = "" Or Sexo_cliComboBox.Text = "" Or Dir_cliTextBox.Text = "" Then
            Completo = False
        Else
            Completo = True
        End If
    End Function

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim NuevoFolio As Integer
        Me.ClienteBindingSource.MoveLast()
        NuevoFolio = Val(Cod_cliTextBox.Text) + 1
        BlockBtn()
        UnblockLabels()
        ClienteBindingSource.AddNew()
        Cod_cliTextBox.Text = NuevoFolio
        Nom_cliTextBox.Focus()
        btnEdit.Visible = False
        btnGuardar.Visible = True
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Completo() Then
            ClienteBindingSource.EndEdit()
            ClienteTableAdapter.Update(NewDataSet.cliente)
            UnblockBtn()
            BlockLabels()
            Actualiza()
        Else
            MsgBox("El registro esta incompleto")
        End If
        btnEdit.Visible = True
        btnGuardar.Visible = False
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        ClienteBindingSource.CancelEdit()
        UnblockBtn()
        BlockLabels()
        btnEdit.Visible = True
        btnGuardar.Visible = False
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim Borrar
        Borrar = MsgBox("¿Desea eliminar este registro?", vbCritical + vbYesNo + vbDefaultButton2, "C O N F I R M A R")
        If Borrar = vbYes Then
            ClienteBindingSource.RemoveCurrent()
            ClienteTableAdapter.Update(NewDataSet.cliente)
            Actualiza()
        Else
            ClienteBindingSource.CancelEdit()
        End If
    End Sub
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        UnblockLabels()
        BlockBtn()
        btnEdit.Visible = False
        btnGuardar.Visible = True
    End Sub

    Private Sub Nom_cliTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Nom_cliTextBox.KeyPress
        e.Handled = Not Char.IsLetter(e.KeyChar) And Not Char.IsSeparator(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub


    Private Sub Ape_cliTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Ape_cliTextBox.KeyPress
        e.Handled = Not Char.IsLetter(e.KeyChar) And Not Char.IsSeparator(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub


    Private Sub Tel_cliTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Tel_cliTextBox.KeyPress
        e.Handled = Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

    Private Sub Ruc_cliTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Ruc_cliTextBox.KeyPress
        e.Handled = Not Char.IsLetter(e.KeyChar) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub


End Class