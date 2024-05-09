<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clientes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
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
        Me.NewDataSet = New prueba1.newDataSet()
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClienteTableAdapter = New prueba1.newDataSetTableAdapters.clienteTableAdapter()
        Me.TableAdapterManager = New prueba1.newDataSetTableAdapters.TableAdapterManager()
        Me.ClienteDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cod_cliTextBox = New System.Windows.Forms.TextBox()
        Me.Nom_cliTextBox = New System.Windows.Forms.TextBox()
        Me.Ape_cliTextBox = New System.Windows.Forms.TextBox()
        Me.Sexo_cliComboBox = New System.Windows.Forms.ComboBox()
        Me.Dni_cliTextBox = New System.Windows.Forms.TextBox()
        Me.Tel_cliTextBox = New System.Windows.Forms.TextBox()
        Me.Ruc_cliTextBox = New System.Windows.Forms.TextBox()
        Me.Email_cliTextBox = New System.Windows.Forms.TextBox()
        Me.Dir_cliTextBox = New System.Windows.Forms.TextBox()
        Cod_cliLabel = New System.Windows.Forms.Label()
        Nom_cliLabel = New System.Windows.Forms.Label()
        Ape_cliLabel = New System.Windows.Forms.Label()
        Sexo_cliLabel = New System.Windows.Forms.Label()
        Dni_cliLabel = New System.Windows.Forms.Label()
        Tel_cliLabel = New System.Windows.Forms.Label()
        Ruc_cliLabel = New System.Windows.Forms.Label()
        Email_cliLabel = New System.Windows.Forms.Label()
        Dir_cliLabel = New System.Windows.Forms.Label()
        CType(Me.NewDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NewDataSet
        '
        Me.NewDataSet.DataSetName = "newDataSet"
        Me.NewDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClienteBindingSource
        '
        Me.ClienteBindingSource.DataMember = "cliente"
        Me.ClienteBindingSource.DataSource = Me.NewDataSet
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
        'ClienteDataGridView
        '
        Me.ClienteDataGridView.AllowUserToAddRows = False
        Me.ClienteDataGridView.AllowUserToDeleteRows = False
        Me.ClienteDataGridView.AutoGenerateColumns = False
        Me.ClienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClienteDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.ClienteDataGridView.DataSource = Me.ClienteBindingSource
        Me.ClienteDataGridView.Location = New System.Drawing.Point(241, 104)
        Me.ClienteDataGridView.Name = "ClienteDataGridView"
        Me.ClienteDataGridView.ReadOnly = True
        Me.ClienteDataGridView.RowHeadersWidth = 51
        Me.ClienteDataGridView.RowTemplate.Height = 24
        Me.ClienteDataGridView.Size = New System.Drawing.Size(623, 198)
        Me.ClienteDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "cod_cli"
        Me.DataGridViewTextBoxColumn1.HeaderText = "CODIGO"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn1.ToolTipText = "CODIGO"
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nom_cli"
        Me.DataGridViewTextBoxColumn2.HeaderText = "NOMBRE"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ape_cli"
        Me.DataGridViewTextBoxColumn3.HeaderText = "APELLIDO"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "sexo_cli"
        Me.DataGridViewTextBoxColumn4.HeaderText = "SEXO"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "dni_cli"
        Me.DataGridViewTextBoxColumn5.HeaderText = "dni_cli"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Visible = False
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "tel_cli"
        Me.DataGridViewTextBoxColumn6.HeaderText = "tel_cli"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Visible = False
        Me.DataGridViewTextBoxColumn6.Width = 125
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "ruc_cli"
        Me.DataGridViewTextBoxColumn7.HeaderText = "ruc_cli"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Visible = False
        Me.DataGridViewTextBoxColumn7.Width = 125
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "email_cli"
        Me.DataGridViewTextBoxColumn8.HeaderText = "EMAIL"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 125
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "dir_cli"
        Me.DataGridViewTextBoxColumn9.HeaderText = "dir_cli"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Visible = False
        Me.DataGridViewTextBoxColumn9.Width = 125
        '
        'Cod_cliLabel
        '
        Cod_cliLabel.AutoSize = True
        Cod_cliLabel.Location = New System.Drawing.Point(12, 67)
        Cod_cliLabel.Name = "Cod_cliLabel"
        Cod_cliLabel.Size = New System.Drawing.Size(52, 17)
        Cod_cliLabel.TabIndex = 1
        Cod_cliLabel.Text = "cod cli:"
        '
        'Cod_cliTextBox
        '
        Me.Cod_cliTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "cod_cli", True))
        Me.Cod_cliTextBox.Location = New System.Drawing.Point(80, 64)
        Me.Cod_cliTextBox.Name = "Cod_cliTextBox"
        Me.Cod_cliTextBox.Size = New System.Drawing.Size(121, 22)
        Me.Cod_cliTextBox.TabIndex = 2
        '
        'Nom_cliLabel
        '
        Nom_cliLabel.AutoSize = True
        Nom_cliLabel.Location = New System.Drawing.Point(12, 95)
        Nom_cliLabel.Name = "Nom_cliLabel"
        Nom_cliLabel.Size = New System.Drawing.Size(56, 17)
        Nom_cliLabel.TabIndex = 3
        Nom_cliLabel.Text = "nom cli:"
        '
        'Nom_cliTextBox
        '
        Me.Nom_cliTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "nom_cli", True))
        Me.Nom_cliTextBox.Location = New System.Drawing.Point(80, 92)
        Me.Nom_cliTextBox.Name = "Nom_cliTextBox"
        Me.Nom_cliTextBox.Size = New System.Drawing.Size(121, 22)
        Me.Nom_cliTextBox.TabIndex = 4
        '
        'Ape_cliLabel
        '
        Ape_cliLabel.AutoSize = True
        Ape_cliLabel.Location = New System.Drawing.Point(12, 123)
        Ape_cliLabel.Name = "Ape_cliLabel"
        Ape_cliLabel.Size = New System.Drawing.Size(53, 17)
        Ape_cliLabel.TabIndex = 5
        Ape_cliLabel.Text = "ape cli:"
        '
        'Ape_cliTextBox
        '
        Me.Ape_cliTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "ape_cli", True))
        Me.Ape_cliTextBox.Location = New System.Drawing.Point(80, 120)
        Me.Ape_cliTextBox.Name = "Ape_cliTextBox"
        Me.Ape_cliTextBox.Size = New System.Drawing.Size(121, 22)
        Me.Ape_cliTextBox.TabIndex = 6
        '
        'Sexo_cliLabel
        '
        Sexo_cliLabel.AutoSize = True
        Sexo_cliLabel.Location = New System.Drawing.Point(12, 151)
        Sexo_cliLabel.Name = "Sexo_cliLabel"
        Sexo_cliLabel.Size = New System.Drawing.Size(58, 17)
        Sexo_cliLabel.TabIndex = 7
        Sexo_cliLabel.Text = "sexo cli:"
        '
        'Sexo_cliComboBox
        '
        Me.Sexo_cliComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "sexo_cli", True))
        Me.Sexo_cliComboBox.FormattingEnabled = True
        Me.Sexo_cliComboBox.Location = New System.Drawing.Point(80, 148)
        Me.Sexo_cliComboBox.Name = "Sexo_cliComboBox"
        Me.Sexo_cliComboBox.Size = New System.Drawing.Size(121, 24)
        Me.Sexo_cliComboBox.TabIndex = 8
        '
        'Dni_cliLabel
        '
        Dni_cliLabel.AutoSize = True
        Dni_cliLabel.Location = New System.Drawing.Point(12, 182)
        Dni_cliLabel.Name = "Dni_cliLabel"
        Dni_cliLabel.Size = New System.Drawing.Size(48, 17)
        Dni_cliLabel.TabIndex = 9
        Dni_cliLabel.Text = "dni cli:"
        '
        'Dni_cliTextBox
        '
        Me.Dni_cliTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "dni_cli", True))
        Me.Dni_cliTextBox.Location = New System.Drawing.Point(80, 179)
        Me.Dni_cliTextBox.Name = "Dni_cliTextBox"
        Me.Dni_cliTextBox.Size = New System.Drawing.Size(121, 22)
        Me.Dni_cliTextBox.TabIndex = 10
        '
        'Tel_cliLabel
        '
        Tel_cliLabel.AutoSize = True
        Tel_cliLabel.Location = New System.Drawing.Point(12, 210)
        Tel_cliLabel.Name = "Tel_cliLabel"
        Tel_cliLabel.Size = New System.Drawing.Size(44, 17)
        Tel_cliLabel.TabIndex = 11
        Tel_cliLabel.Text = "tel cli:"
        '
        'Tel_cliTextBox
        '
        Me.Tel_cliTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "tel_cli", True))
        Me.Tel_cliTextBox.Location = New System.Drawing.Point(80, 207)
        Me.Tel_cliTextBox.Name = "Tel_cliTextBox"
        Me.Tel_cliTextBox.Size = New System.Drawing.Size(121, 22)
        Me.Tel_cliTextBox.TabIndex = 12
        '
        'Ruc_cliLabel
        '
        Ruc_cliLabel.AutoSize = True
        Ruc_cliLabel.Location = New System.Drawing.Point(12, 238)
        Ruc_cliLabel.Name = "Ruc_cliLabel"
        Ruc_cliLabel.Size = New System.Drawing.Size(49, 17)
        Ruc_cliLabel.TabIndex = 13
        Ruc_cliLabel.Text = "ruc cli:"
        '
        'Ruc_cliTextBox
        '
        Me.Ruc_cliTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "ruc_cli", True))
        Me.Ruc_cliTextBox.Location = New System.Drawing.Point(80, 235)
        Me.Ruc_cliTextBox.Name = "Ruc_cliTextBox"
        Me.Ruc_cliTextBox.Size = New System.Drawing.Size(121, 22)
        Me.Ruc_cliTextBox.TabIndex = 14
        '
        'Email_cliLabel
        '
        Email_cliLabel.AutoSize = True
        Email_cliLabel.Location = New System.Drawing.Point(12, 266)
        Email_cliLabel.Name = "Email_cliLabel"
        Email_cliLabel.Size = New System.Drawing.Size(62, 17)
        Email_cliLabel.TabIndex = 15
        Email_cliLabel.Text = "email cli:"
        '
        'Email_cliTextBox
        '
        Me.Email_cliTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "email_cli", True))
        Me.Email_cliTextBox.Location = New System.Drawing.Point(80, 263)
        Me.Email_cliTextBox.Name = "Email_cliTextBox"
        Me.Email_cliTextBox.Size = New System.Drawing.Size(121, 22)
        Me.Email_cliTextBox.TabIndex = 16
        '
        'Dir_cliLabel
        '
        Dir_cliLabel.AutoSize = True
        Dir_cliLabel.Location = New System.Drawing.Point(12, 294)
        Dir_cliLabel.Name = "Dir_cliLabel"
        Dir_cliLabel.Size = New System.Drawing.Size(45, 17)
        Dir_cliLabel.TabIndex = 17
        Dir_cliLabel.Text = "dir cli:"
        '
        'Dir_cliTextBox
        '
        Me.Dir_cliTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "dir_cli", True))
        Me.Dir_cliTextBox.Location = New System.Drawing.Point(80, 291)
        Me.Dir_cliTextBox.Name = "Dir_cliTextBox"
        Me.Dir_cliTextBox.Size = New System.Drawing.Size(121, 22)
        Me.Dir_cliTextBox.TabIndex = 18
        '
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(893, 562)
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
        Me.Name = "Clientes"
        Me.Text = "Clientes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.NewDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NewDataSet As newDataSet
    Friend WithEvents ClienteBindingSource As BindingSource
    Friend WithEvents ClienteTableAdapter As newDataSetTableAdapters.clienteTableAdapter
    Friend WithEvents TableAdapterManager As newDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ClienteDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents Cod_cliTextBox As TextBox
    Friend WithEvents Nom_cliTextBox As TextBox
    Friend WithEvents Ape_cliTextBox As TextBox
    Friend WithEvents Sexo_cliComboBox As ComboBox
    Friend WithEvents Dni_cliTextBox As TextBox
    Friend WithEvents Tel_cliTextBox As TextBox
    Friend WithEvents Ruc_cliTextBox As TextBox
    Friend WithEvents Email_cliTextBox As TextBox
    Friend WithEvents Dir_cliTextBox As TextBox
End Class
