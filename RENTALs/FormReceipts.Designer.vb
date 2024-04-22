<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReceipts
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
        Dim Tenant_NamesLabel As System.Windows.Forms.Label
        Dim House_NameLabel As System.Windows.Forms.Label
        Dim Amount_paidLabel As System.Windows.Forms.Label
        Dim Month_Of_PaymentLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormReceipts))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtResult = New System.Windows.Forms.RichTextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ComboBoxMonth = New System.Windows.Forms.ComboBox()
        Me.PaymentsTblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._TENANTS_REANTALS_BACKUPDataSet1 = New RENTALs._TENANTS_REANTALS_BACKUPDataSet1()
        Me.ComboBoxAmount = New System.Windows.Forms.ComboBox()
        Me.ComboBoxHouse = New System.Windows.Forms.ComboBox()
        Me.HousesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBoxTenant = New System.Windows.Forms.ComboBox()
        Me.TenantsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IconButtonPrint = New FontAwesome.Sharp.IconButton()
        Me.IconButtonReset = New FontAwesome.Sharp.IconButton()
        Me.IconButtonGenerate = New FontAwesome.Sharp.IconButton()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.TenantsTableAdapter = New RENTALs._TENANTS_REANTALS_BACKUPDataSet1TableAdapters.TenantsTableAdapter()
        Me.TableAdapterManager = New RENTALs._TENANTS_REANTALS_BACKUPDataSet1TableAdapters.TableAdapterManager()
        Me.HousesTableAdapter = New RENTALs._TENANTS_REANTALS_BACKUPDataSet1TableAdapters.HousesTableAdapter()
        Me.PaymentsTblTableAdapter = New RENTALs._TENANTS_REANTALS_BACKUPDataSet1TableAdapters.PaymentsTblTableAdapter()
        Me.TenantsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.TenantsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Tenant_NamesLabel = New System.Windows.Forms.Label()
        House_NameLabel = New System.Windows.Forms.Label()
        Amount_paidLabel = New System.Windows.Forms.Label()
        Month_Of_PaymentLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PaymentsTblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._TENANTS_REANTALS_BACKUPDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HousesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TenantsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TenantsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TenantsBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tenant_NamesLabel
        '
        Tenant_NamesLabel.AutoSize = True
        Tenant_NamesLabel.Font = New System.Drawing.Font("Segoe UI Black", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Tenant_NamesLabel.Location = New System.Drawing.Point(36, 74)
        Tenant_NamesLabel.Name = "Tenant_NamesLabel"
        Tenant_NamesLabel.Size = New System.Drawing.Size(145, 25)
        Tenant_NamesLabel.TabIndex = 11
        Tenant_NamesLabel.Text = "Tenant Names:"
        '
        'House_NameLabel
        '
        House_NameLabel.AutoSize = True
        House_NameLabel.Font = New System.Drawing.Font("Segoe UI Black", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        House_NameLabel.Location = New System.Drawing.Point(36, 145)
        House_NameLabel.Name = "House_NameLabel"
        House_NameLabel.Size = New System.Drawing.Size(133, 25)
        House_NameLabel.TabIndex = 12
        House_NameLabel.Text = "House-Name:"
        '
        'Amount_paidLabel
        '
        Amount_paidLabel.AutoSize = True
        Amount_paidLabel.Font = New System.Drawing.Font("Segoe UI Black", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Amount_paidLabel.Location = New System.Drawing.Point(36, 322)
        Amount_paidLabel.Name = "Amount_paidLabel"
        Amount_paidLabel.Size = New System.Drawing.Size(135, 25)
        Amount_paidLabel.TabIndex = 14
        Amount_paidLabel.Text = "Amount-paid:"
        '
        'Month_Of_PaymentLabel
        '
        Month_Of_PaymentLabel.AutoSize = True
        Month_Of_PaymentLabel.Font = New System.Drawing.Font("Segoe UI Black", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Month_Of_PaymentLabel.Location = New System.Drawing.Point(36, 229)
        Month_Of_PaymentLabel.Name = "Month_Of_PaymentLabel"
        Month_Of_PaymentLabel.Size = New System.Drawing.Size(190, 25)
        Month_Of_PaymentLabel.TabIndex = 15
        Month_Of_PaymentLabel.Text = "Month-Of-Payment:"
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.Controls.Add(Me.txtResult)
        Me.Panel1.Location = New System.Drawing.Point(907, 100)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(608, 538)
        Me.Panel1.TabIndex = 0
        '
        'txtResult
        '
        Me.txtResult.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtResult.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResult.Location = New System.Drawing.Point(84, 37)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(483, 472)
        Me.txtResult.TabIndex = 0
        Me.txtResult.Text = ""
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel2.Controls.Add(Month_Of_PaymentLabel)
        Me.Panel2.Controls.Add(Me.ComboBoxMonth)
        Me.Panel2.Controls.Add(Amount_paidLabel)
        Me.Panel2.Controls.Add(Me.ComboBoxAmount)
        Me.Panel2.Controls.Add(House_NameLabel)
        Me.Panel2.Controls.Add(Me.ComboBoxHouse)
        Me.Panel2.Controls.Add(Tenant_NamesLabel)
        Me.Panel2.Controls.Add(Me.ComboBoxTenant)
        Me.Panel2.Controls.Add(Me.IconButtonPrint)
        Me.Panel2.Controls.Add(Me.IconButtonReset)
        Me.Panel2.Controls.Add(Me.IconButtonGenerate)
        Me.Panel2.Location = New System.Drawing.Point(234, 96)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(649, 542)
        Me.Panel2.TabIndex = 1
        '
        'ComboBoxMonth
        '
        Me.ComboBoxMonth.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PaymentsTblBindingSource, "Month-Of-Payment", True))
        Me.ComboBoxMonth.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxMonth.FormattingEnabled = True
        Me.ComboBoxMonth.Location = New System.Drawing.Point(378, 229)
        Me.ComboBoxMonth.Name = "ComboBoxMonth"
        Me.ComboBoxMonth.Size = New System.Drawing.Size(196, 39)
        Me.ComboBoxMonth.TabIndex = 16
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
        'ComboBoxAmount
        '
        Me.ComboBoxAmount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PaymentsTblBindingSource, "Amount-paid", True))
        Me.ComboBoxAmount.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxAmount.FormattingEnabled = True
        Me.ComboBoxAmount.Location = New System.Drawing.Point(378, 314)
        Me.ComboBoxAmount.Name = "ComboBoxAmount"
        Me.ComboBoxAmount.Size = New System.Drawing.Size(196, 39)
        Me.ComboBoxAmount.TabIndex = 15
        '
        'ComboBoxHouse
        '
        Me.ComboBoxHouse.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HousesBindingSource, "House-Name", True))
        Me.ComboBoxHouse.DataSource = Me.PaymentsTblBindingSource
        Me.ComboBoxHouse.DisplayMember = "House-Name"
        Me.ComboBoxHouse.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxHouse.FormattingEnabled = True
        Me.ComboBoxHouse.Location = New System.Drawing.Point(378, 131)
        Me.ComboBoxHouse.Name = "ComboBoxHouse"
        Me.ComboBoxHouse.Size = New System.Drawing.Size(196, 39)
        Me.ComboBoxHouse.TabIndex = 13
        '
        'HousesBindingSource
        '
        Me.HousesBindingSource.DataMember = "Houses"
        Me.HousesBindingSource.DataSource = Me._TENANTS_REANTALS_BACKUPDataSet1
        '
        'ComboBoxTenant
        '
        Me.ComboBoxTenant.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TenantsBindingSource, "Tenant_Names", True))
        Me.ComboBoxTenant.DataSource = Me.PaymentsTblBindingSource
        Me.ComboBoxTenant.DisplayMember = "Tenant-Name"
        Me.ComboBoxTenant.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxTenant.FormattingEnabled = True
        Me.ComboBoxTenant.Location = New System.Drawing.Point(378, 60)
        Me.ComboBoxTenant.Name = "ComboBoxTenant"
        Me.ComboBoxTenant.Size = New System.Drawing.Size(196, 39)
        Me.ComboBoxTenant.TabIndex = 12
        '
        'TenantsBindingSource
        '
        Me.TenantsBindingSource.DataMember = "Tenants"
        Me.TenantsBindingSource.DataSource = Me._TENANTS_REANTALS_BACKUPDataSet1
        '
        'IconButtonPrint
        '
        Me.IconButtonPrint.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.IconButtonPrint.BackColor = System.Drawing.Color.Ivory
        Me.IconButtonPrint.IconChar = FontAwesome.Sharp.IconChar.Print
        Me.IconButtonPrint.IconColor = System.Drawing.Color.Black
        Me.IconButtonPrint.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButtonPrint.Location = New System.Drawing.Point(419, 379)
        Me.IconButtonPrint.Name = "IconButtonPrint"
        Me.IconButtonPrint.Size = New System.Drawing.Size(155, 91)
        Me.IconButtonPrint.TabIndex = 11
        Me.IconButtonPrint.Text = "Print"
        Me.IconButtonPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButtonPrint.UseVisualStyleBackColor = False
        '
        'IconButtonReset
        '
        Me.IconButtonReset.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.IconButtonReset.BackColor = System.Drawing.Color.Ivory
        Me.IconButtonReset.IconChar = FontAwesome.Sharp.IconChar.Resolving
        Me.IconButtonReset.IconColor = System.Drawing.Color.Black
        Me.IconButtonReset.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButtonReset.Location = New System.Drawing.Point(239, 379)
        Me.IconButtonReset.Name = "IconButtonReset"
        Me.IconButtonReset.Size = New System.Drawing.Size(158, 91)
        Me.IconButtonReset.TabIndex = 10
        Me.IconButtonReset.Text = "Reset"
        Me.IconButtonReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButtonReset.UseVisualStyleBackColor = False
        '
        'IconButtonGenerate
        '
        Me.IconButtonGenerate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.IconButtonGenerate.BackColor = System.Drawing.Color.Ivory
        Me.IconButtonGenerate.IconChar = FontAwesome.Sharp.IconChar.Gears
        Me.IconButtonGenerate.IconColor = System.Drawing.Color.Black
        Me.IconButtonGenerate.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButtonGenerate.Location = New System.Drawing.Point(17, 379)
        Me.IconButtonGenerate.Name = "IconButtonGenerate"
        Me.IconButtonGenerate.Size = New System.Drawing.Size(182, 91)
        Me.IconButtonGenerate.TabIndex = 9
        Me.IconButtonGenerate.Text = "Generate"
        Me.IconButtonGenerate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconButtonGenerate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButtonGenerate.UseVisualStyleBackColor = False
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'TenantsTableAdapter
        '
        Me.TenantsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BalancesTblTableAdapter = Nothing
        Me.TableAdapterManager.ExpensesTableAdapter = Nothing
        Me.TableAdapterManager.FinancesTableAdapter = Nothing
        Me.TableAdapterManager.HousesTableAdapter = Me.HousesTableAdapter
        Me.TableAdapterManager.MonthsTBLTableAdapter = Nothing
        Me.TableAdapterManager.PaymentsTblTableAdapter = Me.PaymentsTblTableAdapter
        Me.TableAdapterManager.TenantsTableAdapter = Me.TenantsTableAdapter
        Me.TableAdapterManager.UpdateOrder = RENTALs._TENANTS_REANTALS_BACKUPDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'HousesTableAdapter
        '
        Me.HousesTableAdapter.ClearBeforeFill = True
        '
        'PaymentsTblTableAdapter
        '
        Me.PaymentsTblTableAdapter.ClearBeforeFill = True
        '
        'TenantsBindingNavigator
        '
        Me.TenantsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TenantsBindingNavigator.BindingSource = Me.TenantsBindingSource
        Me.TenantsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TenantsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TenantsBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.TenantsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TenantsBindingNavigatorSaveItem})
        Me.TenantsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TenantsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TenantsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TenantsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TenantsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TenantsBindingNavigator.Name = "TenantsBindingNavigator"
        Me.TenantsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TenantsBindingNavigator.Size = New System.Drawing.Size(1680, 31)
        Me.TenantsBindingNavigator.TabIndex = 2
        Me.TenantsBindingNavigator.Text = "BindingNavigator1"
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
        'TenantsBindingNavigatorSaveItem
        '
        Me.TenantsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TenantsBindingNavigatorSaveItem.Image = CType(resources.GetObject("TenantsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TenantsBindingNavigatorSaveItem.Name = "TenantsBindingNavigatorSaveItem"
        Me.TenantsBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 24)
        Me.TenantsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'FormReceipts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1680, 714)
        Me.Controls.Add(Me.TenantsBindingNavigator)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormReceipts"
        Me.Text = "FormReceipts"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PaymentsTblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._TENANTS_REANTALS_BACKUPDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HousesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TenantsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TenantsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TenantsBindingNavigator.ResumeLayout(False)
        Me.TenantsBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtResult As RichTextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents IconButtonPrint As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButtonReset As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButtonGenerate As FontAwesome.Sharp.IconButton
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents _TENANTS_REANTALS_BACKUPDataSet1 As _TENANTS_REANTALS_BACKUPDataSet1
    Friend WithEvents TenantsBindingSource As BindingSource
    Friend WithEvents TenantsTableAdapter As _TENANTS_REANTALS_BACKUPDataSet1TableAdapters.TenantsTableAdapter
    Friend WithEvents TableAdapterManager As _TENANTS_REANTALS_BACKUPDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents TenantsBindingNavigator As BindingNavigator
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
    Friend WithEvents TenantsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ComboBoxTenant As ComboBox
    Friend WithEvents HousesTableAdapter As _TENANTS_REANTALS_BACKUPDataSet1TableAdapters.HousesTableAdapter
    Friend WithEvents HousesBindingSource As BindingSource
    Friend WithEvents ComboBoxHouse As ComboBox
    Friend WithEvents PaymentsTblTableAdapter As _TENANTS_REANTALS_BACKUPDataSet1TableAdapters.PaymentsTblTableAdapter
    Friend WithEvents PaymentsTblBindingSource As BindingSource
    Friend WithEvents ComboBoxMonth As ComboBox
    Friend WithEvents ComboBoxAmount As ComboBox
End Class
