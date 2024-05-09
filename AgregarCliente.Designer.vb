<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AgregarCliente
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
        Dim Cod_cliLabel As System.Windows.Forms.Label
        Dim Nom_cliLabel As System.Windows.Forms.Label
        Dim Ape_cliLabel As System.Windows.Forms.Label
        Dim Sexo_cliLabel As System.Windows.Forms.Label
        Dim Dni_cliLabel As System.Windows.Forms.Label
        Dim Tel_cliLabel As System.Windows.Forms.Label
        Dim Ruc_cliLabel As System.Windows.Forms.Label
        Dim Email_cliLabel As System.Windows.Forms.Label
        Dim Dir_cliLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AgregarCliente))
        Me.ClienteBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NewDataSet = New prueba1.newDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ClienteDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cod_cliTextBox = New System.Windows.Forms.TextBox()
        Me.Nom_cliTextBox = New System.Windows.Forms.TextBox()
        Me.Ape_cliTextBox = New System.Windows.Forms.TextBox()
        Me.Sexo_cliComboBox = New System.Windows.Forms.ComboBox()
        Me.Dni_cliTextBox = New System.Windows.Forms.TextBox()
        Me.Tel_cliTextBox = New System.Windows.Forms.TextBox()
        Me.Ruc_cliTextBox = New System.Windows.Forms.TextBox()
        Me.Email_cliTextBox = New System.Windows.Forms.TextBox()
        Me.Dir_cliTextBox = New System.Windows.Forms.TextBox()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.ClienteTableAdapter = New prueba1.newDataSetTableAdapters.clienteTableAdapter()
        Me.TableAdapterManager = New prueba1.newDataSetTableAdapters.TableAdapterManager()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Cod_cliLabel = New System.Windows.Forms.Label()
        Nom_cliLabel = New System.Windows.Forms.Label()
        Ape_cliLabel = New System.Windows.Forms.Label()
        Sexo_cliLabel = New System.Windows.Forms.Label()
        Dni_cliLabel = New System.Windows.Forms.Label()
        Tel_cliLabel = New System.Windows.Forms.Label()
        Ruc_cliLabel = New System.Windows.Forms.Label()
        Email_cliLabel = New System.Windows.Forms.Label()
        Dir_cliLabel = New System.Windows.Forms.Label()
        CType(Me.ClienteBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ClienteBindingNavigator.SuspendLayout()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cod_cliLabel
        '
        Cod_cliLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Cod_cliLabel.AutoSize = True
        Cod_cliLabel.Location = New System.Drawing.Point(52, 200)
        Cod_cliLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Cod_cliLabel.Name = "Cod_cliLabel"
        Cod_cliLabel.Size = New System.Drawing.Size(43, 13)
        Cod_cliLabel.TabIndex = 2
        Cod_cliLabel.Text = "Código:"
        '
        'Nom_cliLabel
        '
        Nom_cliLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Nom_cliLabel.AutoSize = True
        Nom_cliLabel.Location = New System.Drawing.Point(53, 223)
        Nom_cliLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Nom_cliLabel.Name = "Nom_cliLabel"
        Nom_cliLabel.Size = New System.Drawing.Size(47, 13)
        Nom_cliLabel.TabIndex = 4
        Nom_cliLabel.Text = "Nombre:"
        '
        'Ape_cliLabel
        '
        Ape_cliLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Ape_cliLabel.AutoSize = True
        Ape_cliLabel.Location = New System.Drawing.Point(53, 246)
        Ape_cliLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Ape_cliLabel.Name = "Ape_cliLabel"
        Ape_cliLabel.Size = New System.Drawing.Size(47, 13)
        Ape_cliLabel.TabIndex = 6
        Ape_cliLabel.Text = "Apellido:"
        '
        'Sexo_cliLabel
        '
        Sexo_cliLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Sexo_cliLabel.AutoSize = True
        Sexo_cliLabel.Location = New System.Drawing.Point(272, 200)
        Sexo_cliLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Sexo_cliLabel.Name = "Sexo_cliLabel"
        Sexo_cliLabel.Size = New System.Drawing.Size(34, 13)
        Sexo_cliLabel.TabIndex = 8
        Sexo_cliLabel.Text = "Sexo:"
        '
        'Dni_cliLabel
        '
        Dni_cliLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Dni_cliLabel.AutoSize = True
        Dni_cliLabel.Location = New System.Drawing.Point(272, 225)
        Dni_cliLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Dni_cliLabel.Name = "Dni_cliLabel"
        Dni_cliLabel.Size = New System.Drawing.Size(29, 13)
        Dni_cliLabel.TabIndex = 10
        Dni_cliLabel.Text = "DNI:"
        '
        'Tel_cliLabel
        '
        Tel_cliLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Tel_cliLabel.AutoSize = True
        Tel_cliLabel.Location = New System.Drawing.Point(272, 248)
        Tel_cliLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Tel_cliLabel.Name = "Tel_cliLabel"
        Tel_cliLabel.Size = New System.Drawing.Size(73, 13)
        Tel_cliLabel.TabIndex = 12
        Tel_cliLabel.Text = "Teléfono: (81)"
        '
        'Ruc_cliLabel
        '
        Ruc_cliLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Ruc_cliLabel.AutoSize = True
        Ruc_cliLabel.Location = New System.Drawing.Point(522, 202)
        Ruc_cliLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Ruc_cliLabel.Name = "Ruc_cliLabel"
        Ruc_cliLabel.Size = New System.Drawing.Size(31, 13)
        Ruc_cliLabel.TabIndex = 14
        Ruc_cliLabel.Text = "RFC:"
        '
        'Email_cliLabel
        '
        Email_cliLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Email_cliLabel.AutoSize = True
        Email_cliLabel.Location = New System.Drawing.Point(522, 223)
        Email_cliLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Email_cliLabel.Name = "Email_cliLabel"
        Email_cliLabel.Size = New System.Drawing.Size(41, 13)
        Email_cliLabel.TabIndex = 16
        Email_cliLabel.Text = "Correo:"
        '
        'Dir_cliLabel
        '
        Dir_cliLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Dir_cliLabel.AutoSize = True
        Dir_cliLabel.Location = New System.Drawing.Point(521, 246)
        Dir_cliLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Dir_cliLabel.Name = "Dir_cliLabel"
        Dir_cliLabel.Size = New System.Drawing.Size(55, 13)
        Dir_cliLabel.TabIndex = 18
        Dir_cliLabel.Text = "Dirección:"
        '
        'ClienteBindingNavigator
        '
        Me.ClienteBindingNavigator.AddNewItem = Nothing
        Me.ClienteBindingNavigator.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ClienteBindingNavigator.BindingSource = Me.ClienteBindingSource
        Me.ClienteBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ClienteBindingNavigator.DeleteItem = Nothing
        Me.ClienteBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.ClienteBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ClienteBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.ToolStripButton1})
        Me.ClienteBindingNavigator.Location = New System.Drawing.Point(0, 26699)
        Me.ClienteBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ClienteBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ClienteBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ClienteBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ClienteBindingNavigator.Name = "ClienteBindingNavigator"
        Me.ClienteBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ClienteBindingNavigator.Size = New System.Drawing.Size(226, 27)
        Me.ClienteBindingNavigator.TabIndex = 0
        Me.ClienteBindingNavigator.Text = "BindingNavigator1"
        '
        'ClienteBindingSource
        '
        Me.ClienteBindingSource.DataMember = "cliente"
        Me.ClienteBindingSource.DataSource = Me.NewDataSet
        '
        'NewDataSet
        '
        Me.NewDataSet.DataSetName = "newDataSet"
        Me.NewDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 24)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(38, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 24)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'ClienteDataGridView
        '
        Me.ClienteDataGridView.AllowUserToAddRows = False
        Me.ClienteDataGridView.AllowUserToDeleteRows = False
        Me.ClienteDataGridView.AllowUserToResizeColumns = False
        Me.ClienteDataGridView.AllowUserToResizeRows = False
        Me.ClienteDataGridView.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClienteDataGridView.AutoGenerateColumns = False
        Me.ClienteDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.ClienteDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.ClienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClienteDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn8})
        Me.ClienteDataGridView.DataSource = Me.ClienteBindingSource
        Me.ClienteDataGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ClienteDataGridView.Location = New System.Drawing.Point(115, 315)
        Me.ClienteDataGridView.Margin = New System.Windows.Forms.Padding(2)
        Me.ClienteDataGridView.MultiSelect = False
        Me.ClienteDataGridView.Name = "ClienteDataGridView"
        Me.ClienteDataGridView.ReadOnly = True
        Me.ClienteDataGridView.RowHeadersWidth = 4
        Me.ClienteDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.ClienteDataGridView.RowTemplate.Height = 24
        Me.ClienteDataGridView.Size = New System.Drawing.Size(595, 179)
        Me.ClienteDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "cod_cli"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Codigo"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 80
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nom_cli"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ape_cli"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Apellido"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "tel_cli"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Telefono"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 125
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "email_cli"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 125
        '
        'Cod_cliTextBox
        '
        Me.Cod_cliTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cod_cliTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "cod_cli", True))
        Me.Cod_cliTextBox.Enabled = False
        Me.Cod_cliTextBox.Location = New System.Drawing.Point(132, 198)
        Me.Cod_cliTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Cod_cliTextBox.MaxLength = 6
        Me.Cod_cliTextBox.Name = "Cod_cliTextBox"
        Me.Cod_cliTextBox.Size = New System.Drawing.Size(128, 20)
        Me.Cod_cliTextBox.TabIndex = 3
        '
        'Nom_cliTextBox
        '
        Me.Nom_cliTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Nom_cliTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "nom_cli", True))
        Me.Nom_cliTextBox.Enabled = False
        Me.Nom_cliTextBox.Location = New System.Drawing.Point(132, 221)
        Me.Nom_cliTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Nom_cliTextBox.MaxLength = 30
        Me.Nom_cliTextBox.Name = "Nom_cliTextBox"
        Me.Nom_cliTextBox.Size = New System.Drawing.Size(128, 20)
        Me.Nom_cliTextBox.TabIndex = 5
        '
        'Ape_cliTextBox
        '
        Me.Ape_cliTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Ape_cliTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "ape_cli", True))
        Me.Ape_cliTextBox.Enabled = False
        Me.Ape_cliTextBox.Location = New System.Drawing.Point(132, 243)
        Me.Ape_cliTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Ape_cliTextBox.MaxLength = 30
        Me.Ape_cliTextBox.Name = "Ape_cliTextBox"
        Me.Ape_cliTextBox.Size = New System.Drawing.Size(128, 20)
        Me.Ape_cliTextBox.TabIndex = 7
        '
        'Sexo_cliComboBox
        '
        Me.Sexo_cliComboBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Sexo_cliComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "sexo_cli", True))
        Me.Sexo_cliComboBox.Enabled = False
        Me.Sexo_cliComboBox.FormattingEnabled = True
        Me.Sexo_cliComboBox.Items.AddRange(New Object() {"M", "F"})
        Me.Sexo_cliComboBox.Location = New System.Drawing.Point(350, 198)
        Me.Sexo_cliComboBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Sexo_cliComboBox.MaxLength = 1
        Me.Sexo_cliComboBox.Name = "Sexo_cliComboBox"
        Me.Sexo_cliComboBox.Size = New System.Drawing.Size(163, 21)
        Me.Sexo_cliComboBox.TabIndex = 9
        '
        'Dni_cliTextBox
        '
        Me.Dni_cliTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Dni_cliTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "dni_cli", True))
        Me.Dni_cliTextBox.Enabled = False
        Me.Dni_cliTextBox.Location = New System.Drawing.Point(350, 223)
        Me.Dni_cliTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Dni_cliTextBox.MaxLength = 8
        Me.Dni_cliTextBox.Name = "Dni_cliTextBox"
        Me.Dni_cliTextBox.Size = New System.Drawing.Size(163, 20)
        Me.Dni_cliTextBox.TabIndex = 11
        '
        'Tel_cliTextBox
        '
        Me.Tel_cliTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tel_cliTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "tel_cli", True))
        Me.Tel_cliTextBox.Enabled = False
        Me.Tel_cliTextBox.Location = New System.Drawing.Point(350, 246)
        Me.Tel_cliTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Tel_cliTextBox.MaxLength = 8
        Me.Tel_cliTextBox.Name = "Tel_cliTextBox"
        Me.Tel_cliTextBox.Size = New System.Drawing.Size(163, 20)
        Me.Tel_cliTextBox.TabIndex = 13
        '
        'Ruc_cliTextBox
        '
        Me.Ruc_cliTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Ruc_cliTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "ruc_cli", True))
        Me.Ruc_cliTextBox.Enabled = False
        Me.Ruc_cliTextBox.Location = New System.Drawing.Point(601, 198)
        Me.Ruc_cliTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Ruc_cliTextBox.MaxLength = 13
        Me.Ruc_cliTextBox.Name = "Ruc_cliTextBox"
        Me.Ruc_cliTextBox.Size = New System.Drawing.Size(163, 20)
        Me.Ruc_cliTextBox.TabIndex = 15
        '
        'Email_cliTextBox
        '
        Me.Email_cliTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Email_cliTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "email_cli", True))
        Me.Email_cliTextBox.Enabled = False
        Me.Email_cliTextBox.Location = New System.Drawing.Point(601, 221)
        Me.Email_cliTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Email_cliTextBox.MaxLength = 30
        Me.Email_cliTextBox.Name = "Email_cliTextBox"
        Me.Email_cliTextBox.Size = New System.Drawing.Size(163, 20)
        Me.Email_cliTextBox.TabIndex = 17
        '
        'Dir_cliTextBox
        '
        Me.Dir_cliTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Dir_cliTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "dir_cli", True))
        Me.Dir_cliTextBox.Enabled = False
        Me.Dir_cliTextBox.Location = New System.Drawing.Point(601, 243)
        Me.Dir_cliTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Dir_cliTextBox.MaxLength = 30
        Me.Dir_cliTextBox.Name = "Dir_cliTextBox"
        Me.Dir_cliTextBox.Size = New System.Drawing.Size(163, 20)
        Me.Dir_cliTextBox.TabIndex = 19
        '
        'btnNuevo
        '
        Me.btnNuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNuevo.Location = New System.Drawing.Point(174, 590)
        Me.btnNuevo.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(76, 52)
        Me.btnNuevo.TabIndex = 20
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminar.Location = New System.Drawing.Point(277, 590)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(76, 52)
        Me.btnEliminar.TabIndex = 21
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.Location = New System.Drawing.Point(375, 590)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(76, 52)
        Me.btnGuardar.TabIndex = 22
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        Me.btnGuardar.Visible = False
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Location = New System.Drawing.Point(472, 590)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(76, 52)
        Me.btnCancelar.TabIndex = 23
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEdit.Location = New System.Drawing.Point(375, 589)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(76, 52)
        Me.btnEdit.TabIndex = 24
        Me.btnEdit.Text = "Editar"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'ClienteTableAdapter
        '
        Me.ClienteTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.boletaTableAdapter = Nothing
        Me.TableAdapterManager.clienteTableAdapter = Me.ClienteTableAdapter
        Me.TableAdapterManager.detalleboletaTableAdapter = Nothing
        Me.TableAdapterManager.detallefacturaTableAdapter = Nothing
        Me.TableAdapterManager.facturaTableAdapter = Nothing
        Me.TableAdapterManager.productoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = prueba1.newDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.prueba1.My.Resources.Resources.Logo
        Me.PictureBox1.Location = New System.Drawing.Point(31, 20)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(320, 89)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'AgregarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(824, 683)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Cod_cliLabel)
        Me.Controls.Add(Me.Cod_cliTextBox)
        Me.Controls.Add(Nom_cliLabel)
        Me.Controls.Add(Me.Nom_cliTextBox)
        Me.Controls.Add(Ape_cliLabel)
        Me.Controls.Add(Me.Ape_cliTextBox)
        Me.Controls.Add(Sexo_cliLabel)
        Me.Controls.Add(Me.Sexo_cliComboBox)
        Me.Controls.Add(Dni_cliLabel)
        Me.Controls.Add(Me.Dni_cliTextBox)
        Me.Controls.Add(Tel_cliLabel)
        Me.Controls.Add(Me.Tel_cliTextBox)
        Me.Controls.Add(Ruc_cliLabel)
        Me.Controls.Add(Me.Ruc_cliTextBox)
        Me.Controls.Add(Email_cliLabel)
        Me.Controls.Add(Me.Email_cliTextBox)
        Me.Controls.Add(Dir_cliLabel)
        Me.Controls.Add(Me.Dir_cliTextBox)
        Me.Controls.Add(Me.ClienteDataGridView)
        Me.Controls.Add(Me.ClienteBindingNavigator)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "AgregarCliente"
        Me.Text = "Agregar Cliente"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ClienteBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ClienteBindingNavigator.ResumeLayout(False)
        Me.ClienteBindingNavigator.PerformLayout()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NewDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NewDataSet As newDataSet
    Friend WithEvents ClienteBindingSource As BindingSource
    Friend WithEvents ClienteTableAdapter As newDataSetTableAdapters.clienteTableAdapter
    Friend WithEvents TableAdapterManager As newDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ClienteBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents Cod_cliTextBox As TextBox
    Friend WithEvents Nom_cliTextBox As TextBox
    Friend WithEvents Ape_cliTextBox As TextBox
    Friend WithEvents Sexo_cliComboBox As ComboBox
    Friend WithEvents Dni_cliTextBox As TextBox
    Friend WithEvents Tel_cliTextBox As TextBox
    Friend WithEvents Ruc_cliTextBox As TextBox
    Friend WithEvents Email_cliTextBox As TextBox
    Friend WithEvents Dir_cliTextBox As TextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents ClienteDataGridView As DataGridView
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents PictureBox1 As PictureBox
End Class
