<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormFinances
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim House_IDLabel As System.Windows.Forms.Label
        Dim Tenant_NamesLabel As System.Windows.Forms.Label
        Dim Amounts_PayingLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormFinances))
        Me.IconButtonAdd = New FontAwesome.Sharp.IconButton()
        Me.IconButtoNSave = New FontAwesome.Sharp.IconButton()
        Me.IconButtonDeletee = New FontAwesome.Sharp.IconButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me._TENANTS_REANTALS_BACKUPDataSet1 = New RENTALs._TENANTS_REANTALS_BACKUPDataSet()
        Me.FinancesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.FinancesTableAdapter1 = New RENTALs._TENANTS_REANTALS_BACKUPDataSetTableAdapters.FinancesTableAdapter()
        Me.TableAdapterManager1 = New RENTALs._TENANTS_REANTALS_BACKUPDataSetTableAdapters.TableAdapterManager()
        Me.FinancesBindingSource1BindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.FinancesBindingSource1BindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.House_IDComboBox = New System.Windows.Forms.ComboBox()
        Me.HousesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tenant_NamesComboBox = New System.Windows.Forms.ComboBox()
        Me.TenantsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Amounts_PayingComboBox = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountsPayingDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TENANTSREANTALSBACKUPDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HousesTableAdapter = New RENTALs._TENANTS_REANTALS_BACKUPDataSetTableAdapters.HousesTableAdapter()
        Me.TenantsTableAdapter = New RENTALs._TENANTS_REANTALS_BACKUPDataSetTableAdapters.TenantsTableAdapter()
        House_IDLabel = New System.Windows.Forms.Label()
        Tenant_NamesLabel = New System.Windows.Forms.Label()
        Amounts_PayingLabel = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        CType(Me._TENANTS_REANTALS_BACKUPDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinancesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinancesBindingSource1BindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FinancesBindingSource1BindingNavigator.SuspendLayout()
        CType(Me.HousesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TenantsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TENANTSREANTALSBACKUPDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'House_IDLabel
        '
        House_IDLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        House_IDLabel.AutoSize = True
        House_IDLabel.Font = New System.Drawing.Font("Segoe UI", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        House_IDLabel.Location = New System.Drawing.Point(82, 35)
        House_IDLabel.Name = "House_IDLabel"
        House_IDLabel.Size = New System.Drawing.Size(89, 23)
        House_IDLabel.TabIndex = 15
        House_IDLabel.Text = "House-ID:"
        '
        'Tenant_NamesLabel
        '
        Tenant_NamesLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Tenant_NamesLabel.AutoSize = True
        Tenant_NamesLabel.Font = New System.Drawing.Font("Segoe UI", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Tenant_NamesLabel.Location = New System.Drawing.Point(82, 96)
        Tenant_NamesLabel.Name = "Tenant_NamesLabel"
        Tenant_NamesLabel.Size = New System.Drawing.Size(130, 23)
        Tenant_NamesLabel.TabIndex = 17
        Tenant_NamesLabel.Text = "Tenant Names:"
        '
        'Amounts_PayingLabel
        '
        Amounts_PayingLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Amounts_PayingLabel.AutoSize = True
        Amounts_PayingLabel.Font = New System.Drawing.Font("Segoe UI", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Amounts_PayingLabel.Location = New System.Drawing.Point(82, 168)
        Amounts_PayingLabel.Name = "Amounts_PayingLabel"
        Amounts_PayingLabel.Size = New System.Drawing.Size(147, 23)
        Amounts_PayingLabel.TabIndex = 19
        Amounts_PayingLabel.Text = "Amounts-Paying:"
        '
        'IconButtonAdd
        '
        Me.IconButtonAdd.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.IconButtonAdd.BackColor = System.Drawing.Color.Black
        Me.IconButtonAdd.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButtonAdd.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.IconButtonAdd.IconChar = FontAwesome.Sharp.IconChar.Add
        Me.IconButtonAdd.IconColor = System.Drawing.Color.Gainsboro
        Me.IconButtonAdd.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButtonAdd.Location = New System.Drawing.Point(73, 9)
        Me.IconButtonAdd.Name = "IconButtonAdd"
        Me.IconButtonAdd.Size = New System.Drawing.Size(127, 62)
        Me.IconButtonAdd.TabIndex = 11
        Me.IconButtonAdd.Text = "Add"
        Me.IconButtonAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconButtonAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButtonAdd.UseVisualStyleBackColor = False
        '
        'IconButtoNSave
        '
        Me.IconButtoNSave.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.IconButtoNSave.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.IconButtoNSave.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButtoNSave.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.IconButtoNSave.IconChar = FontAwesome.Sharp.IconChar.Stamp
        Me.IconButtoNSave.IconColor = System.Drawing.Color.WhiteSmoke
        Me.IconButtoNSave.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButtoNSave.Location = New System.Drawing.Point(253, 9)
        Me.IconButtoNSave.Name = "IconButtoNSave"
        Me.IconButtoNSave.Size = New System.Drawing.Size(130, 62)
        Me.IconButtoNSave.TabIndex = 12
        Me.IconButtoNSave.Text = "SAVE"
        Me.IconButtoNSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButtoNSave.UseVisualStyleBackColor = False
        '
        'IconButtonDeletee
        '
        Me.IconButtonDeletee.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.IconButtonDeletee.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.IconButtonDeletee.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButtonDeletee.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.IconButtonDeletee.IconChar = FontAwesome.Sharp.IconChar.Eraser
        Me.IconButtonDeletee.IconColor = System.Drawing.Color.WhiteSmoke
        Me.IconButtonDeletee.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButtonDeletee.Location = New System.Drawing.Point(19, 75)
        Me.IconButtonDeletee.Name = "IconButtonDeletee"
        Me.IconButtonDeletee.Size = New System.Drawing.Size(10, 45)
        Me.IconButtonDeletee.TabIndex = 13
        Me.IconButtonDeletee.Text = "DELETE"
        Me.IconButtonDeletee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButtonDeletee.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel3.Controls.Add(Me.IconButtonAdd)
        Me.Panel3.Controls.Add(Me.IconButtonDeletee)
        Me.Panel3.Controls.Add(Me.IconButtoNSave)
        Me.Panel3.Location = New System.Drawing.Point(120, 313)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(487, 141)
        Me.Panel3.TabIndex = 14
        '
        '_TENANTS_REANTALS_BACKUPDataSet1
        '
        Me._TENANTS_REANTALS_BACKUPDataSet1.DataSetName = "_TENANTS_REANTALS_BACKUPDataSet"
        Me._TENANTS_REANTALS_BACKUPDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FinancesBindingSource1
        '
        Me.FinancesBindingSource1.DataMember = "Finances"
        Me.FinancesBindingSource1.DataSource = Me._TENANTS_REANTALS_BACKUPDataSet1
        '
        'FinancesTableAdapter1
        '
        Me.FinancesTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.ExpensesTableAdapter = Nothing
        Me.TableAdapterManager1.FinancesTableAdapter = Me.FinancesTableAdapter1
        Me.TableAdapterManager1.HousesTableAdapter = Nothing
        Me.TableAdapterManager1.TenantsTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = RENTALs._TENANTS_REANTALS_BACKUPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FinancesBindingSource1BindingNavigator
        '
        Me.FinancesBindingSource1BindingNavigator.AddNewItem = Me.ToolStripButton5
        Me.FinancesBindingSource1BindingNavigator.BindingSource = Me.FinancesBindingSource1
        Me.FinancesBindingSource1BindingNavigator.CountItem = Me.ToolStripLabel1
        Me.FinancesBindingSource1BindingNavigator.DeleteItem = Me.ToolStripButton6
        Me.FinancesBindingSource1BindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.FinancesBindingSource1BindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripSeparator1, Me.ToolStripTextBox1, Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripSeparator3, Me.ToolStripButton5, Me.ToolStripButton6, Me.FinancesBindingSource1BindingNavigatorSaveItem})
        Me.FinancesBindingSource1BindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.FinancesBindingSource1BindingNavigator.MoveFirstItem = Me.ToolStripButton1
        Me.FinancesBindingSource1BindingNavigator.MoveLastItem = Me.ToolStripButton4
        Me.FinancesBindingSource1BindingNavigator.MoveNextItem = Me.ToolStripButton3
        Me.FinancesBindingSource1BindingNavigator.MovePreviousItem = Me.ToolStripButton2
        Me.FinancesBindingSource1BindingNavigator.Name = "FinancesBindingSource1BindingNavigator"
        Me.FinancesBindingSource1BindingNavigator.PositionItem = Me.ToolStripTextBox1
        Me.FinancesBindingSource1BindingNavigator.Size = New System.Drawing.Size(1321, 27)
        Me.FinancesBindingSource1BindingNavigator.TabIndex = 15
        Me.FinancesBindingSource1BindingNavigator.Text = "BindingNavigator1"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton5.Size = New System.Drawing.Size(29, 24)
        Me.ToolStripButton5.Text = "Add new"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(45, 24)
        Me.ToolStripLabel1.Text = "of {0}"
        Me.ToolStripLabel1.ToolTipText = "Total number of items"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton6.Size = New System.Drawing.Size(29, 24)
        Me.ToolStripButton6.Text = "Delete"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton1.Size = New System.Drawing.Size(29, 24)
        Me.ToolStripButton1.Text = "Move first"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton2.Size = New System.Drawing.Size(29, 24)
        Me.ToolStripButton2.Text = "Move previous"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.AccessibleName = "Position"
        Me.ToolStripTextBox1.AutoSize = False
        Me.ToolStripTextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(50, 27)
        Me.ToolStripTextBox1.Text = "0"
        Me.ToolStripTextBox1.ToolTipText = "Current position"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton3.Size = New System.Drawing.Size(29, 24)
        Me.ToolStripButton3.Text = "Move next"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton4.Size = New System.Drawing.Size(29, 24)
        Me.ToolStripButton4.Text = "Move last"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 27)
        '
        'FinancesBindingSource1BindingNavigatorSaveItem
        '
        Me.FinancesBindingSource1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FinancesBindingSource1BindingNavigatorSaveItem.Image = CType(resources.GetObject("FinancesBindingSource1BindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.FinancesBindingSource1BindingNavigatorSaveItem.Name = "FinancesBindingSource1BindingNavigatorSaveItem"
        Me.FinancesBindingSource1BindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 24)
        Me.FinancesBindingSource1BindingNavigatorSaveItem.Text = "Save Data"
        '
        'House_IDComboBox
        '
        Me.House_IDComboBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.House_IDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FinancesBindingSource1, "House-ID", True))
        Me.House_IDComboBox.DataSource = Me.HousesBindingSource
        Me.House_IDComboBox.DisplayMember = "House-ID"
        Me.House_IDComboBox.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.House_IDComboBox.FormattingEnabled = True
        Me.House_IDComboBox.Location = New System.Drawing.Point(329, 19)
        Me.House_IDComboBox.Name = "House_IDComboBox"
        Me.House_IDComboBox.Size = New System.Drawing.Size(121, 39)
        Me.House_IDComboBox.TabIndex = 16
        '
        'HousesBindingSource
        '
        Me.HousesBindingSource.DataMember = "Houses"
        Me.HousesBindingSource.DataSource = Me._TENANTS_REANTALS_BACKUPDataSet1
        '
        'Tenant_NamesComboBox
        '
        Me.Tenant_NamesComboBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Tenant_NamesComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FinancesBindingSource1, "Tenant_Names", True))
        Me.Tenant_NamesComboBox.DataSource = Me.TenantsBindingSource
        Me.Tenant_NamesComboBox.DisplayMember = "Tenant_Names"
        Me.Tenant_NamesComboBox.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tenant_NamesComboBox.FormattingEnabled = True
        Me.Tenant_NamesComboBox.Location = New System.Drawing.Point(329, 80)
        Me.Tenant_NamesComboBox.Name = "Tenant_NamesComboBox"
        Me.Tenant_NamesComboBox.Size = New System.Drawing.Size(121, 39)
        Me.Tenant_NamesComboBox.TabIndex = 18
        '
        'TenantsBindingSource
        '
        Me.TenantsBindingSource.DataMember = "Tenants"
        Me.TenantsBindingSource.DataSource = Me._TENANTS_REANTALS_BACKUPDataSet1
        '
        'Amounts_PayingComboBox
        '
        Me.Amounts_PayingComboBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Amounts_PayingComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FinancesBindingSource1, "Amounts-Paying", True))
        Me.Amounts_PayingComboBox.DataSource = Me.HousesBindingSource
        Me.Amounts_PayingComboBox.DisplayMember = "Monthly-Payments"
        Me.Amounts_PayingComboBox.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Amounts_PayingComboBox.FormattingEnabled = True
        Me.Amounts_PayingComboBox.Location = New System.Drawing.Point(329, 152)
        Me.Amounts_PayingComboBox.Name = "Amounts_PayingComboBox"
        Me.Amounts_PayingComboBox.Size = New System.Drawing.Size(121, 39)
        Me.Amounts_PayingComboBox.TabIndex = 20
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel2.Controls.Add(House_IDLabel)
        Me.Panel2.Controls.Add(Me.Amounts_PayingComboBox)
        Me.Panel2.Controls.Add(Me.House_IDComboBox)
        Me.Panel2.Controls.Add(Amounts_PayingLabel)
        Me.Panel2.Controls.Add(Tenant_NamesLabel)
        Me.Panel2.Controls.Add(Me.Tenant_NamesComboBox)
        Me.Panel2.Location = New System.Drawing.Point(53, 63)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(554, 236)
        Me.Panel2.TabIndex = 21
        '
        'DataGridView2
        '
        Me.DataGridView2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.AmountsPayingDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.FinancesBindingSource1
        Me.DataGridView2.Location = New System.Drawing.Point(666, 53)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(536, 301)
        Me.DataGridView2.TabIndex = 22
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "House-ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "House-ID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Tenant_Names"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Tenant_Names"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'AmountsPayingDataGridViewTextBoxColumn
        '
        Me.AmountsPayingDataGridViewTextBoxColumn.DataPropertyName = "Amounts-Paying"
        Me.AmountsPayingDataGridViewTextBoxColumn.HeaderText = "Amounts-Paying"
        Me.AmountsPayingDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AmountsPayingDataGridViewTextBoxColumn.Name = "AmountsPayingDataGridViewTextBoxColumn"
        Me.AmountsPayingDataGridViewTextBoxColumn.Width = 125
        '
        'TENANTSREANTALSBACKUPDataSet1BindingSource
        '
        Me.TENANTSREANTALSBACKUPDataSet1BindingSource.DataSource = Me._TENANTS_REANTALS_BACKUPDataSet1
        Me.TENANTSREANTALSBACKUPDataSet1BindingSource.Position = 0
        '
        'HousesTableAdapter
        '
        Me.HousesTableAdapter.ClearBeforeFill = True
        '
        'TenantsTableAdapter
        '
        Me.TenantsTableAdapter.ClearBeforeFill = True
        '
        'FormFinances
        '
        Me.BackColor = System.Drawing.SystemColors.HighlightText
        Me.ClientSize = New System.Drawing.Size(1321, 483)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.FinancesBindingSource1BindingNavigator)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "FormFinances"
        Me.Panel3.ResumeLayout(False)
        CType(Me._TENANTS_REANTALS_BACKUPDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinancesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinancesBindingSource1BindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FinancesBindingSource1BindingNavigator.ResumeLayout(False)
        Me.FinancesBindingSource1BindingNavigator.PerformLayout()
        CType(Me.HousesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TenantsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TENANTSREANTALSBACKUPDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents _TENANTS_REANTALS_BACKUPDataSet As _TENANTS_REANTALS_BACKUPDataSet
    Friend WithEvents FinancesBindingSource As BindingSource
    Friend WithEvents FinancesTableAdapter As _TENANTS_REANTALS_BACKUPDataSetTableAdapters.FinancesTableAdapter
    Friend WithEvents TableAdapterManager As _TENANTS_REANTALS_BACKUPDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FinancesBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents FinancesBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ID_NumberTextBox As TextBox
    Friend WithEvents House_IDTextBox As TextBox
    Friend WithEvents Tenant_NamesTextBox As TextBox
    Friend WithEvents Amounts_PaidTextBox As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents IDNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HouseIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TenantNamesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AmountsPaidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IconButtonDelete As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton1save As FontAwesome.Sharp.IconButton
    Friend WithEvents IconBtnAdd As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents IconButtonAdd As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButtoNSave As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButtonDeletee As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents _TENANTS_REANTALS_BACKUPDataSet1 As _TENANTS_REANTALS_BACKUPDataSet
    Friend WithEvents FinancesBindingSource1 As BindingSource
    Friend WithEvents FinancesTableAdapter1 As _TENANTS_REANTALS_BACKUPDataSetTableAdapters.FinancesTableAdapter
    Friend WithEvents TableAdapterManager1 As _TENANTS_REANTALS_BACKUPDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FinancesBindingSource1BindingNavigator As BindingNavigator
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripButton6 As ToolStripButton
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents FinancesBindingSource1BindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents House_IDComboBox As ComboBox
    Friend WithEvents Tenant_NamesComboBox As ComboBox
    Friend WithEvents Amounts_PayingComboBox As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents AmountsPayingDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TENANTSREANTALSBACKUPDataSet1BindingSource As BindingSource
    Friend WithEvents HousesBindingSource As BindingSource
    Friend WithEvents HousesTableAdapter As _TENANTS_REANTALS_BACKUPDataSetTableAdapters.HousesTableAdapter
    Friend WithEvents TenantsBindingSource As BindingSource
    Friend WithEvents TenantsTableAdapter As _TENANTS_REANTALS_BACKUPDataSetTableAdapters.TenantsTableAdapter
End Class
