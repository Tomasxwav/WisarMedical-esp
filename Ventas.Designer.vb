<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Ventas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Num_facLabel As System.Windows.Forms.Label
        Dim Cod_cliLabel As System.Windows.Forms.Label
        Dim SubtotalLabel As System.Windows.Forms.Label
        Dim IgvLabel As System.Windows.Forms.Label
        Dim TotalLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim PrecioLabel As System.Windows.Forms.Label
        Dim Num_facLabel1 As System.Windows.Forms.Label
        Dim Fec_facLabel As System.Windows.Forms.Label
        Dim StockLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ventas))
        Me.NewDataSet = New prueba1.newDataSet()
        Me.FacturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FacturaTableAdapter = New prueba1.newDataSetTableAdapters.facturaTableAdapter()
        Me.TableAdapterManager = New prueba1.newDataSetTableAdapters.TableAdapterManager()
        Me.FacturaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.FacturaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fec_fac = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Num_facTextBox = New System.Windows.Forms.TextBox()
        Me.Cod_cliTextBox = New System.Windows.Forms.TextBox()
        Me.SubtotalTextBox = New System.Windows.Forms.TextBox()
        Me.IgvTextBox = New System.Windows.Forms.TextBox()
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClienteTableAdapter = New prueba1.newDataSetTableAdapters.clienteTableAdapter()
        Me.Nom_cliComboBox = New System.Windows.Forms.ComboBox()
        Me.ClienteBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NewDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductoTableAdapter = New prueba1.newDataSetTableAdapters.productoTableAdapter()
        Me.VistaprodBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VistaprodTableAdapter = New prueba1.newDataSetTableAdapters.vistaprodTableAdapter()
        Me.VistaprodDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGVDetalle = New System.Windows.Forms.DataGridView()
        Me.CodProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PreUnit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PreTot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.PrecioTextBox = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Fec_facDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Ruc_cliTextBox = New System.Windows.Forms.TextBox()
        Me.DetallefacturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DetallefacturaTableAdapter = New prueba1.newDataSetTableAdapters.detallefacturaTableAdapter()
        Me.Num_facTextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProductoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProdsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProdsTableAdapter = New prueba1.newDataSetTableAdapters.prodsTableAdapter()
        Me.ProdsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.StockTextBox = New System.Windows.Forms.TextBox()
        Num_facLabel = New System.Windows.Forms.Label()
        Cod_cliLabel = New System.Windows.Forms.Label()
        SubtotalLabel = New System.Windows.Forms.Label()
        IgvLabel = New System.Windows.Forms.Label()
        TotalLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        PrecioLabel = New System.Windows.Forms.Label()
        Num_facLabel1 = New System.Windows.Forms.Label()
        Fec_facLabel = New System.Windows.Forms.Label()
        StockLabel = New System.Windows.Forms.Label()
        CType(Me.NewDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FacturaBindingNavigator.SuspendLayout()
        CType(Me.FacturaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaprodBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaprodDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DetallefacturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Num_facLabel
        '
        Num_facLabel.AutoSize = True
        Num_facLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Num_facLabel.Location = New System.Drawing.Point(13, 12)
        Num_facLabel.Name = "Num_facLabel"
        Num_facLabel.Size = New System.Drawing.Size(38, 13)
        Num_facLabel.TabIndex = 2
        Num_facLabel.Text = "Folio:"
        '
        'Cod_cliLabel
        '
        Cod_cliLabel.AutoSize = True
        Cod_cliLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cod_cliLabel.Location = New System.Drawing.Point(13, 41)
        Cod_cliLabel.Name = "Cod_cliLabel"
        Cod_cliLabel.Size = New System.Drawing.Size(46, 13)
        Cod_cliLabel.TabIndex = 4
        Cod_cliLabel.Text = "Cliente"
        '
        'SubtotalLabel
        '
        SubtotalLabel.AutoSize = True
        SubtotalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SubtotalLabel.Location = New System.Drawing.Point(165, 39)
        SubtotalLabel.Name = "SubtotalLabel"
        SubtotalLabel.Size = New System.Drawing.Size(58, 13)
        SubtotalLabel.TabIndex = 8
        SubtotalLabel.Text = "Subtotal:"
        '
        'IgvLabel
        '
        IgvLabel.AutoSize = True
        IgvLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IgvLabel.Location = New System.Drawing.Point(165, 65)
        IgvLabel.Name = "IgvLabel"
        IgvLabel.Size = New System.Drawing.Size(31, 13)
        IgvLabel.TabIndex = 10
        IgvLabel.Text = "IVA:"
        '
        'TotalLabel
        '
        TotalLabel.AutoSize = True
        TotalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TotalLabel.Location = New System.Drawing.Point(214, 93)
        TotalLabel.Name = "TotalLabel"
        TotalLabel.Size = New System.Drawing.Size(54, 20)
        TotalLabel.TabIndex = 12
        TotalLabel.Text = "Total:"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(461, 168)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(64, 13)
        DescripcionLabel.TabIndex = 27
        DescripcionLabel.Text = "descripcion:"
        '
        'PrecioLabel
        '
        PrecioLabel.AutoSize = True
        PrecioLabel.Location = New System.Drawing.Point(461, 198)
        PrecioLabel.Name = "PrecioLabel"
        PrecioLabel.Size = New System.Drawing.Size(39, 13)
        PrecioLabel.TabIndex = 28
        PrecioLabel.Text = "precio:"
        '
        'Num_facLabel1
        '
        Num_facLabel1.AutoSize = True
        Num_facLabel1.Location = New System.Drawing.Point(461, 142)
        Num_facLabel1.Name = "Num_facLabel1"
        Num_facLabel1.Size = New System.Drawing.Size(48, 13)
        Num_facLabel1.TabIndex = 31
        Num_facLabel1.Text = "num fac:"
        '
        'Fec_facLabel
        '
        Fec_facLabel.AutoSize = True
        Fec_facLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Fec_facLabel.Location = New System.Drawing.Point(16, 97)
        Fec_facLabel.Name = "Fec_facLabel"
        Fec_facLabel.Size = New System.Drawing.Size(46, 13)
        Fec_facLabel.TabIndex = 18
        Fec_facLabel.Text = "Fecha:"
        '
        'StockLabel
        '
        StockLabel.AutoSize = True
        StockLabel.Location = New System.Drawing.Point(201, 450)
        StockLabel.Name = "StockLabel"
        StockLabel.Size = New System.Drawing.Size(38, 13)
        StockLabel.TabIndex = 34
        StockLabel.Text = "Stock:"
        '
        'NewDataSet
        '
        Me.NewDataSet.DataSetName = "newDataSet"
        Me.NewDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FacturaBindingSource
        '
        Me.FacturaBindingSource.DataMember = "factura"
        Me.FacturaBindingSource.DataSource = Me.NewDataSet
        '
        'FacturaTableAdapter
        '
        Me.FacturaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.boletaTableAdapter = Nothing
        Me.TableAdapterManager.clienteTableAdapter = Nothing
        Me.TableAdapterManager.detalleboletaTableAdapter = Nothing
        Me.TableAdapterManager.detallefacturaTableAdapter = Nothing
        Me.TableAdapterManager.facturaTableAdapter = Me.FacturaTableAdapter
        Me.TableAdapterManager.productoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = prueba1.newDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FacturaBindingNavigator
        '
        Me.FacturaBindingNavigator.AddNewItem = Nothing
        Me.FacturaBindingNavigator.BindingSource = Me.FacturaBindingSource
        Me.FacturaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.FacturaBindingNavigator.DeleteItem = Nothing
        Me.FacturaBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.FacturaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.FacturaBindingNavigator.Location = New System.Drawing.Point(464, 47)
        Me.FacturaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.FacturaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.FacturaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.FacturaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.FacturaBindingNavigator.Name = "FacturaBindingNavigator"
        Me.FacturaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.FacturaBindingNavigator.Size = New System.Drawing.Size(211, 25)
        Me.FacturaBindingNavigator.TabIndex = 0
        Me.FacturaBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'FacturaDataGridView
        '
        Me.FacturaDataGridView.AllowUserToAddRows = False
        Me.FacturaDataGridView.AllowUserToDeleteRows = False
        Me.FacturaDataGridView.AutoGenerateColumns = False
        Me.FacturaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FacturaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.fec_fac})
        Me.FacturaDataGridView.DataSource = Me.FacturaBindingSource
        Me.FacturaDataGridView.Location = New System.Drawing.Point(399, 75)
        Me.FacturaDataGridView.Name = "FacturaDataGridView"
        Me.FacturaDataGridView.ReadOnly = True
        Me.FacturaDataGridView.RowHeadersWidth = 4
        Me.FacturaDataGridView.Size = New System.Drawing.Size(379, 241)
        Me.FacturaDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "num_fac"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Folio"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 50
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "cod_cli"
        Me.DataGridViewTextBoxColumn2.HeaderText = "IDCliente"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 60
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "subtotal"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Subtotal"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 50
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "igv"
        Me.DataGridViewTextBoxColumn5.HeaderText = "IVA"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 50
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "total"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Total"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 60
        '
        'fec_fac
        '
        Me.fec_fac.DataPropertyName = "fec_fac"
        Me.fec_fac.HeaderText = "Fecha"
        Me.fec_fac.Name = "fec_fac"
        Me.fec_fac.ReadOnly = True
        '
        'Num_facTextBox
        '
        Me.Num_facTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaBindingSource, "num_fac", True))
        Me.Num_facTextBox.Enabled = False
        Me.Num_facTextBox.Location = New System.Drawing.Point(51, 9)
        Me.Num_facTextBox.Name = "Num_facTextBox"
        Me.Num_facTextBox.Size = New System.Drawing.Size(86, 20)
        Me.Num_facTextBox.TabIndex = 3
        '
        'Cod_cliTextBox
        '
        Me.Cod_cliTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaBindingSource, "cod_cli", True))
        Me.Cod_cliTextBox.Location = New System.Drawing.Point(16, 61)
        Me.Cod_cliTextBox.Name = "Cod_cliTextBox"
        Me.Cod_cliTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Cod_cliTextBox.TabIndex = 5
        '
        'SubtotalTextBox
        '
        Me.SubtotalTextBox.Cursor = System.Windows.Forms.Cursors.Default
        Me.SubtotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaBindingSource, "subtotal", True))
        Me.SubtotalTextBox.Location = New System.Drawing.Point(232, 36)
        Me.SubtotalTextBox.Name = "SubtotalTextBox"
        Me.SubtotalTextBox.ReadOnly = True
        Me.SubtotalTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SubtotalTextBox.TabIndex = 9
        Me.SubtotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'IgvTextBox
        '
        Me.IgvTextBox.Cursor = System.Windows.Forms.Cursors.Default
        Me.IgvTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaBindingSource, "igv", True))
        Me.IgvTextBox.Location = New System.Drawing.Point(231, 62)
        Me.IgvTextBox.Name = "IgvTextBox"
        Me.IgvTextBox.ReadOnly = True
        Me.IgvTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IgvTextBox.TabIndex = 11
        Me.IgvTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TotalTextBox
        '
        Me.TotalTextBox.Cursor = System.Windows.Forms.Cursors.Default
        Me.TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaBindingSource, "total", True))
        Me.TotalTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalTextBox.Location = New System.Drawing.Point(168, 120)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.ReadOnly = True
        Me.TotalTextBox.Size = New System.Drawing.Size(164, 26)
        Me.TotalTextBox.TabIndex = 13
        Me.TotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ClienteBindingSource
        '
        Me.ClienteBindingSource.DataMember = "factura_cliente"
        Me.ClienteBindingSource.DataSource = Me.FacturaBindingSource
        '
        'ClienteTableAdapter
        '
        Me.ClienteTableAdapter.ClearBeforeFill = True
        '
        'Nom_cliComboBox
        '
        Me.Nom_cliComboBox.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
        Me.Nom_cliComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "nom_cli", True))
        Me.Nom_cliComboBox.DataSource = Me.ClienteBindingSource1
        Me.Nom_cliComboBox.DisplayMember = "nom_cli"
        Me.Nom_cliComboBox.FormattingEnabled = True
        Me.Nom_cliComboBox.Location = New System.Drawing.Point(16, 61)
        Me.Nom_cliComboBox.Name = "Nom_cliComboBox"
        Me.Nom_cliComboBox.Size = New System.Drawing.Size(121, 21)
        Me.Nom_cliComboBox.TabIndex = 17
        Me.Nom_cliComboBox.ValueMember = "cod_cli"
        '
        'ClienteBindingSource1
        '
        Me.ClienteBindingSource1.DataMember = "cliente"
        Me.ClienteBindingSource1.DataSource = Me.NewDataSet
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(52, 264)
        Me.btnNuevo.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(76, 52)
        Me.btnNuevo.TabIndex = 21
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(181, 264)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(76, 52)
        Me.btnCancelar.TabIndex = 24
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'ProductoBindingSource
        '
        Me.ProductoBindingSource.DataMember = "producto"
        Me.ProductoBindingSource.DataSource = Me.NewDataSet
        '
        'NewDataSetBindingSource
        '
        Me.NewDataSetBindingSource.DataSource = Me.NewDataSet
        Me.NewDataSetBindingSource.Position = 0
        '
        'ProductoTableAdapter
        '
        Me.ProductoTableAdapter.ClearBeforeFill = True
        '
        'VistaprodBindingSource
        '
        Me.VistaprodBindingSource.DataMember = "factura_vistaprod"
        Me.VistaprodBindingSource.DataSource = Me.FacturaBindingSource
        '
        'VistaprodTableAdapter
        '
        Me.VistaprodTableAdapter.ClearBeforeFill = True
        '
        'VistaprodDataGridView
        '
        Me.VistaprodDataGridView.AllowUserToAddRows = False
        Me.VistaprodDataGridView.AllowUserToDeleteRows = False
        Me.VistaprodDataGridView.AutoGenerateColumns = False
        Me.VistaprodDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VistaprodDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13})
        Me.VistaprodDataGridView.DataSource = Me.VistaprodBindingSource
        Me.VistaprodDataGridView.Location = New System.Drawing.Point(36, 361)
        Me.VistaprodDataGridView.Name = "VistaprodDataGridView"
        Me.VistaprodDataGridView.ReadOnly = True
        Me.VistaprodDataGridView.RowHeadersWidth = 4
        Me.VistaprodDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.VistaprodDataGridView.Size = New System.Drawing.Size(443, 142)
        Me.VistaprodDataGridView.TabIndex = 26
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "cod_pro"
        Me.DataGridViewTextBoxColumn9.HeaderText = "CodProducto"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 75
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "des_pro"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 125
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "cant_pro"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Width = 75
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "pre_unit"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Precio Unitario"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Width = 75
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "pre_tot"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Precio Total"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Width = 75
        '
        'DGVDetalle
        '
        Me.DGVDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodProducto, Me.Descripcion, Me.Cantidad, Me.PreUnit, Me.PreTot})
        Me.DGVDetalle.Location = New System.Drawing.Point(36, 361)
        Me.DGVDetalle.Name = "DGVDetalle"
        Me.DGVDetalle.RowHeadersWidth = 4
        Me.DGVDetalle.Size = New System.Drawing.Size(443, 141)
        Me.DGVDetalle.TabIndex = 27
        Me.DGVDetalle.Visible = False
        '
        'CodProducto
        '
        Me.CodProducto.HeaderText = "Cod Producto"
        Me.CodProducto.Name = "CodProducto"
        Me.CodProducto.Width = 75
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Width = 125
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Width = 75
        '
        'PreUnit
        '
        Me.PreUnit.HeaderText = "Precio Unitario"
        Me.PreUnit.Name = "PreUnit"
        Me.PreUnit.ReadOnly = True
        Me.PreUnit.Width = 75
        '
        'PreTot
        '
        Me.PreTot.HeaderText = "Precio Total"
        Me.PreTot.Name = "PreTot"
        Me.PreTot.ReadOnly = True
        Me.PreTot.Width = 75
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(531, 165)
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DescripcionTextBox.TabIndex = 28
        '
        'PrecioTextBox
        '
        Me.PrecioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "precio", True))
        Me.PrecioTextBox.Location = New System.Drawing.Point(531, 195)
        Me.PrecioTextBox.Name = "PrecioTextBox"
        Me.PrecioTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PrecioTextBox.TabIndex = 29
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(304, 264)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(76, 52)
        Me.btnGuardar.TabIndex = 30
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Fec_facLabel)
        Me.Panel1.Controls.Add(Me.Fec_facDateTimePicker)
        Me.Panel1.Controls.Add(Me.Nom_cliComboBox)
        Me.Panel1.Controls.Add(Num_facLabel)
        Me.Panel1.Controls.Add(Me.Num_facTextBox)
        Me.Panel1.Controls.Add(Cod_cliLabel)
        Me.Panel1.Controls.Add(Me.Cod_cliTextBox)
        Me.Panel1.Controls.Add(SubtotalLabel)
        Me.Panel1.Controls.Add(Me.SubtotalTextBox)
        Me.Panel1.Controls.Add(IgvLabel)
        Me.Panel1.Controls.Add(Me.IgvTextBox)
        Me.Panel1.Controls.Add(TotalLabel)
        Me.Panel1.Controls.Add(Me.TotalTextBox)
        Me.Panel1.Controls.Add(Me.Ruc_cliTextBox)
        Me.Panel1.Enabled = False
        Me.Panel1.Location = New System.Drawing.Point(36, 75)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(346, 162)
        Me.Panel1.TabIndex = 31
        '
        'Fec_facDateTimePicker
        '
        Me.Fec_facDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FacturaBindingSource, "fec_fac", True))
        Me.Fec_facDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Fec_facDateTimePicker.Location = New System.Drawing.Point(16, 117)
        Me.Fec_facDateTimePicker.Name = "Fec_facDateTimePicker"
        Me.Fec_facDateTimePicker.Size = New System.Drawing.Size(100, 20)
        Me.Fec_facDateTimePicker.TabIndex = 30
        '
        'Ruc_cliTextBox
        '
        Me.Ruc_cliTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaBindingSource, "ruc_cli", True))
        Me.Ruc_cliTextBox.Location = New System.Drawing.Point(16, 61)
        Me.Ruc_cliTextBox.Name = "Ruc_cliTextBox"
        Me.Ruc_cliTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Ruc_cliTextBox.TabIndex = 18
        '
        'DetallefacturaBindingSource
        '
        Me.DetallefacturaBindingSource.DataMember = "detallefactura"
        Me.DetallefacturaBindingSource.DataSource = Me.NewDataSet
        '
        'DetallefacturaTableAdapter
        '
        Me.DetallefacturaTableAdapter.ClearBeforeFill = True
        '
        'Num_facTextBox1
        '
        Me.Num_facTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DetallefacturaBindingSource, "num_fac", True))
        Me.Num_facTextBox1.Location = New System.Drawing.Point(515, 139)
        Me.Num_facTextBox1.Name = "Num_facTextBox1"
        Me.Num_facTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.Num_facTextBox1.TabIndex = 32
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(123, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 26)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Control de ventas"
        '
        'ProductoBindingSource1
        '
        Me.ProductoBindingSource1.DataMember = "producto"
        Me.ProductoBindingSource1.DataSource = Me.NewDataSet
        '
        'ProdsBindingSource
        '
        Me.ProdsBindingSource.DataMember = "prods"
        Me.ProdsBindingSource.DataSource = Me.NewDataSet
        '
        'ProdsTableAdapter
        '
        Me.ProdsTableAdapter.ClearBeforeFill = True
        '
        'ProdsDataGridView
        '
        Me.ProdsDataGridView.AllowUserToAddRows = False
        Me.ProdsDataGridView.AllowUserToDeleteRows = False
        Me.ProdsDataGridView.AutoGenerateColumns = False
        Me.ProdsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProdsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn14})
        Me.ProdsDataGridView.DataSource = Me.ProdsBindingSource
        Me.ProdsDataGridView.Location = New System.Drawing.Point(506, 372)
        Me.ProdsDataGridView.Name = "ProdsDataGridView"
        Me.ProdsDataGridView.ReadOnly = True
        Me.ProdsDataGridView.RowHeadersWidth = 4
        Me.ProdsDataGridView.Size = New System.Drawing.Size(222, 159)
        Me.ProdsDataGridView.TabIndex = 33
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "cod_pro"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Codigo"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 50
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "descripcion"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Producto"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Stock"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Stock"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Width = 50
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(565, 343)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 26)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Productos"
        '
        'StockTextBox
        '
        Me.StockTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "Stock", True))
        Me.StockTextBox.Location = New System.Drawing.Point(245, 447)
        Me.StockTextBox.Name = "StockTextBox"
        Me.StockTextBox.Size = New System.Drawing.Size(100, 20)
        Me.StockTextBox.TabIndex = 35
        '
        'Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(824, 683)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ProdsDataGridView)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.DGVDetalle)
        Me.Controls.Add(Me.VistaprodDataGridView)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.FacturaDataGridView)
        Me.Controls.Add(Me.FacturaBindingNavigator)
        Me.Controls.Add(Num_facLabel1)
        Me.Controls.Add(Me.DescripcionTextBox)
        Me.Controls.Add(DescripcionLabel)
        Me.Controls.Add(Me.Num_facTextBox1)
        Me.Controls.Add(Me.PrecioTextBox)
        Me.Controls.Add(PrecioLabel)
        Me.Controls.Add(StockLabel)
        Me.Controls.Add(Me.StockTextBox)
        Me.Name = "Ventas"
        Me.Text = "Ventas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.NewDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FacturaBindingNavigator.ResumeLayout(False)
        Me.FacturaBindingNavigator.PerformLayout()
        CType(Me.FacturaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NewDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaprodBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaprodDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DetallefacturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NewDataSet As newDataSet
    Friend WithEvents FacturaBindingSource As BindingSource
    Friend WithEvents FacturaTableAdapter As newDataSetTableAdapters.facturaTableAdapter
    Friend WithEvents TableAdapterManager As newDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FacturaBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents FacturaDataGridView As DataGridView
    Friend WithEvents Num_facTextBox As TextBox
    Friend WithEvents Cod_cliTextBox As TextBox
    Friend WithEvents SubtotalTextBox As TextBox
    Friend WithEvents IgvTextBox As TextBox
    Friend WithEvents TotalTextBox As TextBox
    Friend WithEvents ClienteBindingSource As BindingSource
    Friend WithEvents ClienteTableAdapter As newDataSetTableAdapters.clienteTableAdapter
    Friend WithEvents Nom_cliComboBox As ComboBox
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents ClienteBindingSource1 As BindingSource
    Friend WithEvents NewDataSetBindingSource As BindingSource
    Friend WithEvents ProductoBindingSource As BindingSource
    Friend WithEvents ProductoTableAdapter As newDataSetTableAdapters.productoTableAdapter
    Friend WithEvents VistaprodBindingSource As BindingSource
    Friend WithEvents VistaprodTableAdapter As newDataSetTableAdapters.vistaprodTableAdapter
    Friend WithEvents VistaprodDataGridView As DataGridView
    Friend WithEvents DGVDetalle As DataGridView
    Friend WithEvents DescripcionTextBox As TextBox
    Friend WithEvents PrecioTextBox As TextBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DetallefacturaBindingSource As BindingSource
    Friend WithEvents DetallefacturaTableAdapter As newDataSetTableAdapters.detallefacturaTableAdapter
    Friend WithEvents Num_facTextBox1 As TextBox
    Friend WithEvents Ruc_cliTextBox As TextBox
    Friend WithEvents Fec_facDateTimePicker As DateTimePicker
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents CodProducto As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents PreUnit As DataGridViewTextBoxColumn
    Friend WithEvents PreTot As DataGridViewTextBoxColumn
    Friend WithEvents fec_fac As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents ProductoBindingSource1 As BindingSource
    Friend WithEvents ProdsBindingSource As BindingSource
    Friend WithEvents ProdsTableAdapter As newDataSetTableAdapters.prodsTableAdapter
    Friend WithEvents ProdsDataGridView As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents StockTextBox As TextBox
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
End Class
