Public Class Ventas

    Dim Col, Ren
    Dim NewReg As Boolean = False

    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'NewDataSet.prods' Puede moverla o quitarla según sea necesario.
        Me.ProdsTableAdapter.Fill(Me.NewDataSet.prods)
        'TODO: esta línea de código carga datos en la tabla 'NewDataSet.prods' Puede moverla o quitarla según sea necesario.
        ' Me.ProdsTableAdapter.Fill(Me.NewDataSet.prods)
        'TODO: esta línea de código carga datos en la tabla 'NewDataSet.prods' Puede moverla o quitarla según sea necesario.
        ' Me.ProdsTableAdapter.Fill(Me.NewDataSet.prods)
        'TODO: esta línea de código carga datos en la tabla 'NewDataSet.prods' Puede moverla o quitarla según sea necesario.
        'Me.ProdsTableAdapter.Fill(Me.NewDataSet.prods)
        'TODO: esta línea de código carga datos en la tabla 'NewDataSet.detallefactura' Puede moverla o quitarla según sea necesario.
        Me.DetallefacturaTableAdapter.Fill(Me.NewDataSet.detallefactura)
        'TODO: esta línea de código carga datos en la tabla 'NewDataSet.vistaprod' Puede moverla o quitarla según sea necesario.
        Me.VistaprodTableAdapter.Fill(Me.NewDataSet.vistaprod)
        'TODO: esta línea de código carga datos en la tabla 'NewDataSet.producto' Puede moverla o quitarla según sea necesario.
        Me.ProductoTableAdapter.Fill(Me.NewDataSet.producto)
        'TODO: esta línea de código carga datos en la tabla 'NewDataSet.detallefactura' Puede moverla o quitarla según sea necesario.

        Me.ClienteTableAdapter.Fill(Me.NewDataSet.cliente)
        'TODO: esta línea de código carga datos en la tabla 'NewDataSet.factura' Puede moverla o quitarla según sea necesario.
        Me.FacturaTableAdapter.Fill(Me.NewDataSet.factura)
        'TODO: esta línea de código carga datos en la tabla 'NewDataSet.factura' Puede moverla o quitarla según sea necesario.


    End Sub

    Private Sub BlockBtn()
        FacturaDataGridView.Enabled = False
        btnNuevo.Enabled = False
        DGVDetalle.Visible = True
        Panel1.Enabled = True
    End Sub

    Private Sub UnblockBtn()
        FacturaDataGridView.Enabled = False
        btnNuevo.Enabled = True
        DGVDetalle.Visible = False
        Panel1.Enabled = False
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        BlockBtn()

        Dim NuevoFolio As Integer
        Me.FacturaBindingSource.MoveLast()
        NuevoFolio = Val(Num_facTextBox.Text) + 1
        FacturaBindingSource.AddNew()
        Num_facTextBox.Text = NuevoFolio
        Nom_cliComboBox.Focus()
        SubtotalTextBox.Text = 0
        Fec_facDateTimePicker.Text = Now
        IgvTextBox.Text = 0
        NewReg = True
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        UnblockBtn()
        FacturaBindingSource.CancelEdit()
        NewReg = False
    End Sub

    Private Sub Nom_cliComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Nom_cliComboBox.SelectedIndexChanged
        Cod_cliTextBox.Text = Nom_cliComboBox.SelectedValue
        Ruc_cliTextBox.Text = Nom_cliComboBox.SelectedValue
    End Sub

    Private Sub CalculaSubtotal()
        DGVDetalle.Item(4, Ren).Value = Val(PrecioTextBox.Text) * DGVDetalle.Item(2, Ren).Value
    End Sub

    Private Sub Calcula()
        Dim R = 0, Pie = 0, Tot = 0, Tot_R = 0
        Tot_R = DGVDetalle.RowCount - 1
        For R = 0 To Tot_R
            If DGVDetalle.Item(0, R).Value IsNot "" Then
                Pie = Pie + DGVDetalle.Item(2, R).Value
                Tot = Tot + DGVDetalle.Item(4, R).Value
            End If
        Next
        SubtotalTextBox.Text = Tot
        TotalTextBox.Text = (Tot * 0.16) + Tot
        IgvTextBox.Text = Tot * 0.16
    End Sub

    Private Sub DGVDetalle_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles DGVDetalle.RowsRemoved
        Calcula()
    End Sub

    Private Sub DGVDetalle_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DGVDetalle.CellEndEdit
        Dim CodPro
        Col = e.ColumnIndex
        Ren = e.RowIndex
        CodPro = DGVDetalle.Item(0, Ren).Value
        If CodPro <> "" Then
            If Col = 0 Then

                Me.ProductoTableAdapter.FillByCod(Me.NewDataSet.producto, CodPro)
                If DescripcionTextBox.Text <> "" Then
                    'DGVDetalle.Item(1, Ren).Value = 
                    DGVDetalle.Item(1, Ren).Value = DescripcionTextBox.Text
                    DGVDetalle.Item(2, Ren).Value = 1
                    DGVDetalle.Item(3, Ren).Value = PrecioTextBox.Text
                    CalculaSubtotal()
                    Calcula()
                Else
                    DGVDetalle.Item(0, Ren).Value = 0
                End If
            End If
            If Col = 2 Then
                CalculaSubtotal()
                Calcula()
            End If
            If Col = 3 Then
                CalculaSubtotal()
                Calcula()
            End If
        Else
            DGVDetalle.Item(1, Ren).Value = ""
            DGVDetalle.Item(2, Ren).Value = ""
            DGVDetalle.Item(3, Ren).Value = ""
            DGVDetalle.Item(4, Ren).Value = ""
            Calcula()

        End If

        ChecarStock()
    End Sub

    Private Sub DGVDetalle_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVDetalle.CellClick
        Col = e.ColumnIndex
        Ren = e.RowIndex
    End Sub

    Function completo() As Boolean
        If Cod_cliTextBox.Text = "" Or TotalTextBox.Text = 0 Then
            completo = False
            MsgBox("registro incompleto")
        Else
            completo = True
        End If
    End Function



    Private Sub GrabaDetalle()
        Dim Cod = "", Folio = "", cant = 0, precio = 0, subtotal = 0, R = 0, desc = ""
        Me.FacturaBindingSource.MoveLast()
        Folio = Val(Num_facTextBox.Text)
        For R = 0 To DGVDetalle.RowCount - 2
            Cod = DGVDetalle.Item(0, R).Value
            desc = DGVDetalle.Item(1, R).Value
            cant = DGVDetalle.Item(2, R).Value
            precio = DGVDetalle.Item(3, R).Value
            subtotal = DGVDetalle.Item(4, R).Value
            Me.DetallefacturaTableAdapter.InsNuevoDetalle(Folio, Cod, desc, cant, precio, subtotal)
        Next
    End Sub

    Private Sub GrabaFactura()
        'Dim Folio = Num_facTextBox.Text, Codcli = Cod_cliTextBox.Text, rfc = "NA", subtotal = SubtotalTextBox.Text, iva = IgvTextBox.Text, total = TotalTextBox.Text, fecha = Fec_facTextBox.Text
        FacturaBindingSource.EndEdit()
        FacturaTableAdapter.Update(NewDataSet.factura)
        Me.FacturaTableAdapter.Fill(Me.NewDataSet.factura)
    End Sub



    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim Pos
        'If ChecarStock() Then
        If NewReg = True Then
                Calcula()
                If completo() Then
                    GrabaFactura()
                    GrabaDetalle()
                    Me.VistaprodTableAdapter.Fill(Me.NewDataSet.vistaprod)
                    UnblockBtn()
                    NewReg = False
                End If
            Else
                Pos = FacturaBindingSource.Position
                GrabaFactura()
                GrabaDetalle()
                FacturaBindingSource.Position = Pos
            End If
        'Else
        'Pos = FacturaBindingSource.Position
        'FacturaBindingSource.Position = Pos
        'End If
    End Sub

    Function ChecarStock() As Boolean
        Dim CodPro = "", cantPro = 0, newStock = 0
        Dim Stock As Integer
        Stock = StockTextBox.Text
        If DGVDetalle.Item(2, Ren).Value <= Stock Then
            CodPro = DGVDetalle.Item(0, Ren).Value
            cantPro = DGVDetalle.Item(2, Ren).Value
            newStock = Stock - cantPro
            Me.ProductoTableAdapter.UpdateStock(newStock, CodPro)
            Me.ProdsTableAdapter.Fill(Me.NewDataSet.prods)
            ChecarStock = True
        Else
            MsgBox("Usted no cuenta con el stock requerido")
            ChecarStock = False
        End If
    End Function

    Private Sub ActualizaStock()
        Dim CodPro, cantPro, Stock, newStock
        CodPro = DGVDetalle.Item(0, Ren).Value
        cantPro = DGVDetalle.Item(2, Ren).Value
        Stock = StockTextBox.Text

        Dim R = 0, Tot_R = DGVDetalle.RowCount - 1

        Do While R
            CodPro = DGVDetalle.Item(0, R).Value
            cantPro = DGVDetalle.Item(2, R).Value
            newStock = Stock - cantPro
            Me.ProductoTableAdapter.UpdateStock(newStock, CodPro)
            R = R + 1
        Loop

    End Sub




    Private Sub DGVDetalle_RowLeave(sender As Object, e As DataGridViewCellEventArgs) Handles DGVDetalle.RowLeave

    End Sub

End Class