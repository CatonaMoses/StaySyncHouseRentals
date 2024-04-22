<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaymentsForm
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
        Dim Tenant_NameLabel As System.Windows.Forms.Label
        Dim House_NameLabel As System.Windows.Forms.Label
        Dim Amount_paidLabel As System.Windows.Forms.Label
        Dim Month_Of_PaymentLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PaymentsForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Tenant_NameComboBox = New System.Windows.Forms.ComboBox()
        Me.PaymentsTblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._TENANTS_REANTALS_BACKUPDataSet1 = New RENTALs._TENANTS_REANTALS_BACKUPDataSet1()
        Me.TenantsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.House_NameComboBox = New System.Windows.Forms.ComboBox()
        Me.HousesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Amount_paidComboBox = New System.Windows.Forms.ComboBox()
        Me.Month_Of_PaymentComboBox = New System.Windows.Forms.ComboBox()
        Me.MonthsTBLBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PaymentsTblTableAdapter = New RENTALs._TENANTS_REANTALS_BACKUPDataSet1TableAdapters.PaymentsTblTableAdapter()
        Me.TableAdapterManager = New RENTALs._TENANTS_REANTALS_BACKUPDataSet1TableAdapters.TableAdapterManager()
        Me.HousesTableAdapter = New RENTALs._TENANTS_REANTALS_BACKUPDataSet1TableAdapters.HousesTableAdapter()
        Me.MonthsTBLTableAdapter = New RENTALs._TENANTS_REANTALS_BACKUPDataSet1TableAdapters.MonthsTBLTableAdapter()
        Me.TenantsTableAdapter = New RENTALs._TENANTS_REANTALS_BACKUPDataSet1TableAdapters.TenantsTableAdapter()
        Me.PaymentsTblBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.PaymentsTblBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.IconButtonDelete = New FontAwesome.Sharp.IconButton()
        Me.IconButtonSave = New FontAwesome.Sharp.IconButton()
        Me.IconBtnAdd = New FontAwesome.Sharp.IconButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TenantNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HouseNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountpaidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MonthOfPaymentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Tenant_NameLabel = New System.Windows.Forms.Label()
        House_NameLabel = New System.Windows.Forms.Label()
        Amount_paidLabel = New System.Windows.Forms.Label()
        Month_Of_PaymentLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PaymentsTblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._TENANTS_REANTALS_BACKUPDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TenantsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HousesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MonthsTBLBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaymentsTblBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PaymentsTblBindingNavigator.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Tenant_NameLabel
        '
        Tenant_NameLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Tenant_NameLabel.AutoSize = True
        Tenant_NameLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Tenant_NameLabel.Location = New System.Drawing.Point(14, 25)
        Tenant_NameLabel.Name = "Tenant_NameLabel"
        Tenant_NameLabel.Size = New System.Drawing.Size(112, 20)
        Tenant_NameLabel.TabIndex = 0
        Tenant_NameLabel.Text = "Tenant-Name:"
        '
        'House_NameLabel
        '
        House_NameLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        House_NameLabel.AutoSize = True
        House_NameLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        House_NameLabel.Location = New System.Drawing.Point(20, 73)
        House_NameLabel.Name = "House_NameLabel"
        House_NameLabel.Size = New System.Drawing.Size(106, 20)
        House_NameLabel.TabIndex = 2
        House_NameLabel.Text = "House-Name:"
        '
        'Amount_paidLabel
        '
        Amount_paidLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Amount_paidLabel.AutoSize = True
        Amount_paidLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Amount_paidLabel.Location = New System.Drawing.Point(20, 120)
        Amount_paidLabel.Name = "Amount_paidLabel"
        Amount_paidLabel.Size = New System.Drawing.Size(109, 20)
        Amount_paidLabel.TabIndex = 4
        Amount_paidLabel.Text = "Amount-paid:"
        '
        'Month_Of_PaymentLabel
        '
        Month_Of_PaymentLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Month_Of_PaymentLabel.AutoSize = True
        Month_Of_PaymentLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Month_Of_PaymentLabel.Location = New System.Drawing.Point(20, 168)
        Month_Of_PaymentLabel.Name = "Month_Of_PaymentLabel"
        Month_Of_PaymentLabel.Size = New System.Drawing.Size(151, 20)
        Month_Of_PaymentLabel.TabIndex = 6
        Month_Of_PaymentLabel.Text = "Month-Of-Payment:"
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.Controls.Add(Tenant_NameLabel)
        Me.Panel1.Controls.Add(Me.Tenant_NameComboBox)
        Me.Panel1.Controls.Add(House_NameLabel)
        Me.Panel1.Controls.Add(Me.House_NameComboBox)
        Me.Panel1.Controls.Add(Amount_paidLabel)
        Me.Panel1.Controls.Add(Me.Amount_paidComboBox)
        Me.Panel1.Controls.Add(Month_Of_PaymentLabel)
        Me.Panel1.Controls.Add(Me.Month_Of_PaymentComboBox)
        Me.Panel1.Location = New System.Drawing.Point(77, 54)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(484, 200)
        Me.Panel1.TabIndex = 0
        '
        'Tenant_NameComboBox
        '
        Me.Tenant_NameComboBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Tenant_NameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PaymentsTblBindingSource, "Tenant-Name", True))
        Me.Tenant_NameComboBox.DataSource = Me.TenantsBindingSource
        Me.Tenant_NameComboBox.DisplayMember = "Tenant_Names"
        Me.Tenant_NameComboBox.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tenant_NameComboBox.FormattingEnabled = True
        Me.Tenant_NameComboBox.Location = New System.Drawing.Point(217, 12)
        Me.Tenant_NameComboBox.Name = "Tenant_NameComboBox"
        Me.Tenant_NameComboBox.Size = New System.Drawing.Size(241, 33)
        Me.Tenant_NameComboBox.TabIndex = 1
        '
        'PaymentsTblBindingSource
        '
        Me.PaymentsTblBindingSource.DataMember = "PaymentsTbl"
        Me.PaymentsTblBindingSource.DataSource = Me._TENANTS_REANTALS_BACKUPDataSet1
        '
        '_TENANTS_REANTALS_BACKUPDataSet1
        '
        Me._TENANTS_REANTALS_BACKUPDataSet1.DataSetName = "_TENANTS_REANTALS_BACKUPDataSet1"
        Me._TENANTS_REANTALS_BACKUPDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TenantsBindingSource
        '
        Me.TenantsBindingSource.DataMember = "Tenants"
        Me.TenantsBindingSource.DataSource = Me._TENANTS_REANTALS_BACKUPDataSet1
        '
        'House_NameComboBox
        '
        Me.House_NameComboBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.House_NameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PaymentsTblBindingSource, "House-Name", True))
        Me.House_NameComboBox.DataSource = Me.HousesBindingSource
        Me.House_NameComboBox.DisplayMember = "House-Name"
        Me.House_NameComboBox.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.House_NameComboBox.FormattingEnabled = True
        Me.House_NameComboBox.Location = New System.Drawing.Point(217, 60)
        Me.House_NameComboBox.Name = "House_NameComboBox"
        Me.House_NameComboBox.Size = New System.Drawing.Size(241, 33)
        Me.House_NameComboBox.TabIndex = 3
        '
        'HousesBindingSource
        '
        Me.HousesBindingSource.DataMember = "Houses"
        Me.HousesBindingSource.DataSource = Me._TENANTS_REANTALS_BACKUPDataSet1
        '
        'Amount_paidComboBox
        '
        Me.Amount_paidComboBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Amount_paidComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PaymentsTblBindingSource, "Amount-paid", True))
        Me.Amount_paidComboBox.DataSource = Me.HousesBindingSource
        Me.Amount_paidComboBox.DisplayMember = "Monthly-Payments"
        Me.Amount_paidComboBox.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Amount_paidComboBox.FormattingEnabled = True
        Me.Amount_paidComboBox.Location = New System.Drawing.Point(217, 107)
        Me.Amount_paidComboBox.Name = "Amount_paidComboBox"
        Me.Amount_paidComboBox.Size = New System.Drawing.Size(241, 33)
        Me.Amount_paidComboBox.TabIndex = 5
        '
        'Month_Of_PaymentComboBox
        '
        Me.Month_Of_PaymentComboBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Month_Of_PaymentComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PaymentsTblBindingSource, "Month-Of-Payment", True))
        Me.Month_Of_PaymentComboBox.DataSource = Me.MonthsTBLBindingSource
        Me.Month_Of_PaymentComboBox.DisplayMember = "Month-Name"
        Me.Month_Of_PaymentComboBox.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Month_Of_PaymentComboBox.FormattingEnabled = True
        Me.Month_Of_PaymentComboBox.Location = New System.Drawing.Point(217, 155)
        Me.Month_Of_PaymentComboBox.Name = "Month_Of_PaymentComboBox"
        Me.Month_Of_PaymentComboBox.Size = New System.Drawing.Size(241, 33)
        Me.Month_Of_PaymentComboBox.TabIndex = 7
        '
        'MonthsTBLBindingSource
        '
        Me.MonthsTBLBindingSource.DataMember = "MonthsTBL"
        Me.MonthsTBLBindingSource.DataSource = Me._TENANTS_REANTALS_BACKUPDataSet1
        '
        'PaymentsTblTableAdapter
        '
        Me.PaymentsTblTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BalancesTblTableAdapter = Nothing
        Me.TableAdapterManager.ExpensesTableAdapter = Nothing
        Me.TableAdapterManager.FinancesTableAdapter = Nothing
        Me.TableAdapterManager.HousesTableAdapter = Me.HousesTableAdapter
        Me.TableAdapterManager.MonthsTBLTableAdapter = Me.MonthsTBLTableAdapter
        Me.TableAdapterManager.PaymentsTblTableAdapter = Me.PaymentsTblTableAdapter
        Me.TableAdapterManager.TenantsTableAdapter = Me.TenantsTableAdapter
        Me.TableAdapterManager.UpdateOrder = RENTALs._TENANTS_REANTALS_BACKUPDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'HousesTableAdapter
        '
        Me.HousesTableAdapter.ClearBeforeFill = True
        '
        'MonthsTBLTableAdapter
        '
        Me.MonthsTBLTableAdapter.ClearBeforeFill = True
        '
        'TenantsTableAdapter
        '
        Me.TenantsTableAdapter.ClearBeforeFill = True
        '
        'PaymentsTblBindingNavigator
        '
        Me.PaymentsTblBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PaymentsTblBindingNavigator.BindingSource = Me.PaymentsTblBindingSource
        Me.PaymentsTblBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PaymentsTblBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PaymentsTblBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.PaymentsTblBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PaymentsTblBindingNavigatorSaveItem})
        Me.PaymentsTblBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PaymentsTblBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PaymentsTblBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PaymentsTblBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PaymentsTblBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PaymentsTblBindingNavigator.Name = "PaymentsTblBindingNavigator"
        Me.PaymentsTblBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PaymentsTblBindingNavigator.Size = New System.Drawing.Size(1271, 27)
        Me.PaymentsTblBindingNavigator.TabIndex = 1
        Me.PaymentsTblBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 24)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
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
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'PaymentsTblBindingNavigatorSaveItem
        '
        Me.PaymentsTblBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PaymentsTblBindingNavigatorSaveItem.Image = CType(resources.GetObject("PaymentsTblBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PaymentsTblBindingNavigatorSaveItem.Name = "PaymentsTblBindingNavigatorSaveItem"
        Me.PaymentsTblBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 24)
        Me.PaymentsTblBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel2.Controls.Add(Me.IconButtonDelete)
        Me.Panel2.Controls.Add(Me.IconButtonSave)
        Me.Panel2.Controls.Add(Me.IconBtnAdd)
        Me.Panel2.Location = New System.Drawing.Point(95, 260)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(500, 197)
        Me.Panel2.TabIndex = 2
        '
        'IconButtonDelete
        '
        Me.IconButtonDelete.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.IconButtonDelete.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.IconButtonDelete.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButtonDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.IconButtonDelete.IconChar = FontAwesome.Sharp.IconChar.Add
        Me.IconButtonDelete.IconColor = System.Drawing.Color.WhiteSmoke
        Me.IconButtonDelete.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButtonDelete.Location = New System.Drawing.Point(27, 96)
        Me.IconButtonDelete.Name = "IconButtonDelete"
        Me.IconButtonDelete.Size = New System.Drawing.Size(10, 62)
        Me.IconButtonDelete.TabIndex = 2
        Me.IconButtonDelete.Text = "Delete"
        Me.IconButtonDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.IconButtonDelete.UseVisualStyleBackColor = False
        '
        'IconButtonSave
        '
        Me.IconButtonSave.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.IconButtonSave.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.IconButtonSave.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButtonSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.IconButtonSave.IconChar = FontAwesome.Sharp.IconChar.Stamp
        Me.IconButtonSave.IconColor = System.Drawing.Color.WhiteSmoke
        Me.IconButtonSave.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButtonSave.Location = New System.Drawing.Point(252, 8)
        Me.IconButtonSave.Name = "IconButtonSave"
        Me.IconButtonSave.Size = New System.Drawing.Size(138, 82)
        Me.IconButtonSave.TabIndex = 1
        Me.IconButtonSave.Text = "Save"
        Me.IconButtonSave.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.IconButtonSave.UseVisualStyleBackColor = False
        '
        'IconBtnAdd
        '
        Me.IconBtnAdd.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.IconBtnAdd.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.IconBtnAdd.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconBtnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.IconBtnAdd.IconChar = FontAwesome.Sharp.IconChar.Add
        Me.IconBtnAdd.IconColor = System.Drawing.Color.WhiteSmoke
        Me.IconBtnAdd.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconBtnAdd.Location = New System.Drawing.Point(53, 8)
        Me.IconBtnAdd.Name = "IconBtnAdd"
        Me.IconBtnAdd.Size = New System.Drawing.Size(135, 82)
        Me.IconBtnAdd.TabIndex = 0
        Me.IconBtnAdd.Text = "AddNew"
        Me.IconBtnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.IconBtnAdd.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TenantNameDataGridViewTextBoxColumn, Me.HouseNameDataGridViewTextBoxColumn, Me.AmountpaidDataGridViewTextBoxColumn, Me.MonthOfPaymentDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PaymentsTblBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(605, 44)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(654, 210)
        Me.DataGridView1.TabIndex = 3
        '
        'TenantNameDataGridViewTextBoxColumn
        '
        Me.TenantNameDataGridViewTextBoxColumn.DataPropertyName = "Tenant-Name"
        Me.TenantNameDataGridViewTextBoxColumn.HeaderText = "Tenant-Name"
        Me.TenantNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TenantNameDataGridViewTextBoxColumn.Name = "TenantNameDataGridViewTextBoxColumn"
        Me.TenantNameDataGridViewTextBoxColumn.Width = 125
        '
        'HouseNameDataGridViewTextBoxColumn
        '
        Me.HouseNameDataGridViewTextBoxColumn.DataPropertyName = "House-Name"
        Me.HouseNameDataGridViewTextBoxColumn.HeaderText = "House-Name"
        Me.HouseNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.HouseNameDataGridViewTextBoxColumn.Name = "HouseNameDataGridViewTextBoxColumn"
        Me.HouseNameDataGridViewTextBoxColumn.Width = 125
        '
        'AmountpaidDataGridViewTextBoxColumn
        '
        Me.AmountpaidDataGridViewTextBoxColumn.DataPropertyName = "Amount-paid"
        Me.AmountpaidDataGridViewTextBoxColumn.HeaderText = "Amount-paid"
        Me.AmountpaidDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AmountpaidDataGridViewTextBoxColumn.Name = "AmountpaidDataGridViewTextBoxColumn"
        Me.AmountpaidDataGridViewTextBoxColumn.Width = 125
        '
        'MonthOfPaymentDataGridViewTextBoxColumn
        '
        Me.MonthOfPaymentDataGridViewTextBoxColumn.DataPropertyName = "Month-Of-Payment"
        Me.MonthOfPaymentDataGridViewTextBoxColumn.HeaderText = "Month-Of-Payment"
        Me.MonthOfPaymentDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MonthOfPaymentDataGridViewTextBoxColumn.Name = "MonthOfPaymentDataGridViewTextBoxColumn"
        Me.MonthOfPaymentDataGridViewTextBoxColumn.Width = 125
        '
        'PaymentsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1271, 490)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PaymentsTblBindingNavigator)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "PaymentsForm"
        Me.Text = "PaymentsForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PaymentsTblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._TENANTS_REANTALS_BACKUPDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TenantsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HousesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MonthsTBLBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaymentsTblBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PaymentsTblBindingNavigator.ResumeLayout(False)
        Me.PaymentsTblBindingNavigator.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents _TENANTS_REANTALS_BACKUPDataSet1 As _TENANTS_REANTALS_BACKUPDataSet1
    Friend WithEvents PaymentsTblBindingSource As BindingSource
    Friend WithEvents PaymentsTblTableAdapter As _TENANTS_REANTALS_BACKUPDataSet1TableAdapters.PaymentsTblTableAdapter
    Friend WithEvents TableAdapterManager As _TENANTS_REANTALS_BACKUPDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents PaymentsTblBindingNavigator As BindingNavigator
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
    Friend WithEvents PaymentsTblBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Tenant_NameComboBox As ComboBox
    Friend WithEvents House_NameComboBox As ComboBox
    Friend WithEvents Amount_paidComboBox As ComboBox
    Friend WithEvents Month_Of_PaymentComboBox As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents IconButtonDelete As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButtonSave As FontAwesome.Sharp.IconButton
    Friend WithEvents IconBtnAdd As FontAwesome.Sharp.IconButton
    Friend WithEvents TenantsTableAdapter As _TENANTS_REANTALS_BACKUPDataSet1TableAdapters.TenantsTableAdapter
    Friend WithEvents TenantsBindingSource As BindingSource
    Friend WithEvents HousesTableAdapter As _TENANTS_REANTALS_BACKUPDataSet1TableAdapters.HousesTableAdapter
    Friend WithEvents HousesBindingSource As BindingSource
    Friend WithEvents MonthsTBLTableAdapter As _TENANTS_REANTALS_BACKUPDataSet1TableAdapters.MonthsTBLTableAdapter
    Friend WithEvents MonthsTBLBindingSource As BindingSource
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TenantNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HouseNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AmountpaidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MonthOfPaymentDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
