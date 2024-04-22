<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormExpenses
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
        Dim House_repairLabel As System.Windows.Forms.Label
        Dim HouseRepairsAmountLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormExpenses))
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.IconButtonDelete = New FontAwesome.Sharp.IconButton()
        Me.IconButton1save = New FontAwesome.Sharp.IconButton()
        Me.IconBtnAdd = New FontAwesome.Sharp.IconButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.House_IDComboBox = New System.Windows.Forms.ComboBox()
        Me.ExpensesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._TENANTS_REANTALS_BACKUPDataSet = New RENTALs._TENANTS_REANTALS_BACKUPDataSet()
        Me.HousesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.House_repairTextBox = New System.Windows.Forms.TextBox()
        Me.HouseRepairsAmountTextBox = New System.Windows.Forms.TextBox()
        Me.ExpensesTableAdapter = New RENTALs._TENANTS_REANTALS_BACKUPDataSetTableAdapters.ExpensesTableAdapter()
        Me.TableAdapterManager = New RENTALs._TENANTS_REANTALS_BACKUPDataSetTableAdapters.TableAdapterManager()
        Me.ExpensesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ExpensesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.HouseIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HouserepairDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HouseRepairsAmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HousesTableAdapter = New RENTALs._TENANTS_REANTALS_BACKUPDataSetTableAdapters.HousesTableAdapter()
        House_IDLabel = New System.Windows.Forms.Label()
        House_repairLabel = New System.Windows.Forms.Label()
        HouseRepairsAmountLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.ExpensesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._TENANTS_REANTALS_BACKUPDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HousesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExpensesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ExpensesBindingNavigator.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'House_IDLabel
        '
        House_IDLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        House_IDLabel.AutoSize = True
        House_IDLabel.Font = New System.Drawing.Font("Segoe UI", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        House_IDLabel.Location = New System.Drawing.Point(3, 43)
        House_IDLabel.Name = "House_IDLabel"
        House_IDLabel.Size = New System.Drawing.Size(89, 23)
        House_IDLabel.TabIndex = 0
        House_IDLabel.Text = "House-ID:"
        '
        'House_repairLabel
        '
        House_repairLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        House_repairLabel.AutoSize = True
        House_repairLabel.Font = New System.Drawing.Font("Segoe UI", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        House_repairLabel.Location = New System.Drawing.Point(3, 118)
        House_repairLabel.Name = "House_repairLabel"
        House_repairLabel.Size = New System.Drawing.Size(119, 23)
        House_repairLabel.TabIndex = 2
        House_repairLabel.Text = "House-repair:"
        '
        'HouseRepairsAmountLabel
        '
        HouseRepairsAmountLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        HouseRepairsAmountLabel.AutoSize = True
        HouseRepairsAmountLabel.Font = New System.Drawing.Font("Segoe UI", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        HouseRepairsAmountLabel.Location = New System.Drawing.Point(3, 188)
        HouseRepairsAmountLabel.Name = "HouseRepairsAmountLabel"
        HouseRepairsAmountLabel.Size = New System.Drawing.Size(196, 23)
        HouseRepairsAmountLabel.TabIndex = 4
        HouseRepairsAmountLabel.Text = "House Repairs Amount:"
        '
        'IconButtonDelete
        '
        Me.IconButtonDelete.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.IconButtonDelete.BackColor = System.Drawing.Color.Transparent
        Me.IconButtonDelete.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButtonDelete.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.IconButtonDelete.IconChar = FontAwesome.Sharp.IconChar.Eraser
        Me.IconButtonDelete.IconColor = System.Drawing.Color.Honeydew
        Me.IconButtonDelete.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButtonDelete.Location = New System.Drawing.Point(5, 145)
        Me.IconButtonDelete.Name = "IconButtonDelete"
        Me.IconButtonDelete.Size = New System.Drawing.Size(14, 37)
        Me.IconButtonDelete.TabIndex = 15
        Me.IconButtonDelete.Text = "DELETE"
        Me.IconButtonDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButtonDelete.UseVisualStyleBackColor = False
        '
        'IconButton1save
        '
        Me.IconButton1save.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.IconButton1save.BackColor = System.Drawing.Color.Black
        Me.IconButton1save.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton1save.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.IconButton1save.IconChar = FontAwesome.Sharp.IconChar.Stamp
        Me.IconButton1save.IconColor = System.Drawing.Color.Honeydew
        Me.IconButton1save.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1save.Location = New System.Drawing.Point(256, 18)
        Me.IconButton1save.Name = "IconButton1save"
        Me.IconButton1save.Size = New System.Drawing.Size(153, 79)
        Me.IconButton1save.TabIndex = 14
        Me.IconButton1save.Text = "SAVE"
        Me.IconButton1save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton1save.UseVisualStyleBackColor = False
        '
        'IconBtnAdd
        '
        Me.IconBtnAdd.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.IconBtnAdd.BackColor = System.Drawing.Color.Black
        Me.IconBtnAdd.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal
        Me.IconBtnAdd.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconBtnAdd.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.IconBtnAdd.IconChar = FontAwesome.Sharp.IconChar.Add
        Me.IconBtnAdd.IconColor = System.Drawing.Color.Honeydew
        Me.IconBtnAdd.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconBtnAdd.Location = New System.Drawing.Point(5, 18)
        Me.IconBtnAdd.Name = "IconBtnAdd"
        Me.IconBtnAdd.Size = New System.Drawing.Size(142, 79)
        Me.IconBtnAdd.TabIndex = 13
        Me.IconBtnAdd.Text = "ADD"
        Me.IconBtnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconBtnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconBtnAdd.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.Controls.Add(Me.IconBtnAdd)
        Me.Panel1.Controls.Add(Me.IconButtonDelete)
        Me.Panel1.Controls.Add(Me.IconButton1save)
        Me.Panel1.Location = New System.Drawing.Point(63, 310)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(519, 204)
        Me.Panel1.TabIndex = 16
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel2.Controls.Add(House_IDLabel)
        Me.Panel2.Controls.Add(Me.House_IDComboBox)
        Me.Panel2.Controls.Add(House_repairLabel)
        Me.Panel2.Controls.Add(Me.House_repairTextBox)
        Me.Panel2.Controls.Add(HouseRepairsAmountLabel)
        Me.Panel2.Controls.Add(Me.HouseRepairsAmountTextBox)
        Me.Panel2.Location = New System.Drawing.Point(26, 57)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(556, 247)
        Me.Panel2.TabIndex = 17
        '
        'House_IDComboBox
        '
        Me.House_IDComboBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.House_IDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ExpensesBindingSource, "House-ID", True))
        Me.House_IDComboBox.DataSource = Me.HousesBindingSource
        Me.House_IDComboBox.DisplayMember = "House-ID"
        Me.House_IDComboBox.Font = New System.Drawing.Font("Segoe UI", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.House_IDComboBox.FormattingEnabled = True
        Me.House_IDComboBox.Location = New System.Drawing.Point(307, 33)
        Me.House_IDComboBox.Name = "House_IDComboBox"
        Me.House_IDComboBox.Size = New System.Drawing.Size(203, 39)
        Me.House_IDComboBox.TabIndex = 1
        '
        'ExpensesBindingSource
        '
        Me.ExpensesBindingSource.DataMember = "Expenses"
        Me.ExpensesBindingSource.DataSource = Me._TENANTS_REANTALS_BACKUPDataSet
        '
        '_TENANTS_REANTALS_BACKUPDataSet
        '
        Me._TENANTS_REANTALS_BACKUPDataSet.DataSetName = "_TENANTS_REANTALS_BACKUPDataSet"
        Me._TENANTS_REANTALS_BACKUPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HousesBindingSource
        '
        Me.HousesBindingSource.DataMember = "Houses"
        Me.HousesBindingSource.DataSource = Me._TENANTS_REANTALS_BACKUPDataSet
        '
        'House_repairTextBox
        '
        Me.House_repairTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.House_repairTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ExpensesBindingSource, "House-repair", True))
        Me.House_repairTextBox.Font = New System.Drawing.Font("Segoe UI", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.House_repairTextBox.Location = New System.Drawing.Point(307, 108)
        Me.House_repairTextBox.Name = "House_repairTextBox"
        Me.House_repairTextBox.Size = New System.Drawing.Size(201, 38)
        Me.House_repairTextBox.TabIndex = 3
        '
        'HouseRepairsAmountTextBox
        '
        Me.HouseRepairsAmountTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.HouseRepairsAmountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ExpensesBindingSource, "HouseRepairsAmount", True))
        Me.HouseRepairsAmountTextBox.Font = New System.Drawing.Font("Segoe UI", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HouseRepairsAmountTextBox.Location = New System.Drawing.Point(307, 178)
        Me.HouseRepairsAmountTextBox.Name = "HouseRepairsAmountTextBox"
        Me.HouseRepairsAmountTextBox.Size = New System.Drawing.Size(201, 38)
        Me.HouseRepairsAmountTextBox.TabIndex = 5
        '
        'ExpensesTableAdapter
        '
        Me.ExpensesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ExpensesTableAdapter = Me.ExpensesTableAdapter
        Me.TableAdapterManager.FinancesTableAdapter = Nothing
        Me.TableAdapterManager.HousesTableAdapter = Nothing
        Me.TableAdapterManager.TenantsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = RENTALs._TENANTS_REANTALS_BACKUPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ExpensesBindingNavigator
        '
        Me.ExpensesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ExpensesBindingNavigator.BindingSource = Me.ExpensesBindingSource
        Me.ExpensesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ExpensesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ExpensesBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ExpensesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ExpensesBindingNavigatorSaveItem})
        Me.ExpensesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ExpensesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ExpensesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ExpensesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ExpensesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ExpensesBindingNavigator.Name = "ExpensesBindingNavigator"
        Me.ExpensesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ExpensesBindingNavigator.Size = New System.Drawing.Size(1371, 27)
        Me.ExpensesBindingNavigator.TabIndex = 18
        Me.ExpensesBindingNavigator.Text = "BindingNavigator1"
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
        'ExpensesBindingNavigatorSaveItem
        '
        Me.ExpensesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ExpensesBindingNavigatorSaveItem.Image = CType(resources.GetObject("ExpensesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ExpensesBindingNavigatorSaveItem.Name = "ExpensesBindingNavigatorSaveItem"
        Me.ExpensesBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 24)
        Me.ExpensesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.HouseIDDataGridViewTextBoxColumn, Me.HouserepairDataGridViewTextBoxColumn, Me.HouseRepairsAmountDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ExpensesBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(642, 66)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(592, 300)
        Me.DataGridView1.TabIndex = 19
        '
        'HouseIDDataGridViewTextBoxColumn
        '
        Me.HouseIDDataGridViewTextBoxColumn.DataPropertyName = "House-ID"
        Me.HouseIDDataGridViewTextBoxColumn.HeaderText = "House-ID"
        Me.HouseIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.HouseIDDataGridViewTextBoxColumn.Name = "HouseIDDataGridViewTextBoxColumn"
        Me.HouseIDDataGridViewTextBoxColumn.Width = 125
        '
        'HouserepairDataGridViewTextBoxColumn
        '
        Me.HouserepairDataGridViewTextBoxColumn.DataPropertyName = "House-repair"
        Me.HouserepairDataGridViewTextBoxColumn.HeaderText = "House-repair"
        Me.HouserepairDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.HouserepairDataGridViewTextBoxColumn.Name = "HouserepairDataGridViewTextBoxColumn"
        Me.HouserepairDataGridViewTextBoxColumn.Width = 125
        '
        'HouseRepairsAmountDataGridViewTextBoxColumn
        '
        Me.HouseRepairsAmountDataGridViewTextBoxColumn.DataPropertyName = "HouseRepairsAmount"
        Me.HouseRepairsAmountDataGridViewTextBoxColumn.HeaderText = "HouseRepairsAmount"
        Me.HouseRepairsAmountDataGridViewTextBoxColumn.MinimumWidth = 10
        Me.HouseRepairsAmountDataGridViewTextBoxColumn.Name = "HouseRepairsAmountDataGridViewTextBoxColumn"
        Me.HouseRepairsAmountDataGridViewTextBoxColumn.Width = 150
        '
        'HousesTableAdapter
        '
        Me.HousesTableAdapter.ClearBeforeFill = True
        '
        'FormExpenses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(1371, 572)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ExpensesBindingNavigator)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Name = "FormExpenses"
        Me.Text = "FormExpenses"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.ExpensesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._TENANTS_REANTALS_BACKUPDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HousesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExpensesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ExpensesBindingNavigator.ResumeLayout(False)
        Me.ExpensesBindingNavigator.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents IconButtonDelete As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton1save As FontAwesome.Sharp.IconButton
    Friend WithEvents IconBtnAdd As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents _TENANTS_REANTALS_BACKUPDataSet As _TENANTS_REANTALS_BACKUPDataSet
    Friend WithEvents ExpensesBindingSource As BindingSource
    Friend WithEvents ExpensesTableAdapter As _TENANTS_REANTALS_BACKUPDataSetTableAdapters.ExpensesTableAdapter
    Friend WithEvents TableAdapterManager As _TENANTS_REANTALS_BACKUPDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ExpensesBindingNavigator As BindingNavigator
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
    Friend WithEvents ExpensesBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents House_IDComboBox As ComboBox
    Friend WithEvents House_repairTextBox As TextBox
    Friend WithEvents HouseRepairsAmountTextBox As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents HousesBindingSource As BindingSource
    Friend WithEvents HousesTableAdapter As _TENANTS_REANTALS_BACKUPDataSetTableAdapters.HousesTableAdapter
    Friend WithEvents HouseIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HouserepairDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HouseRepairsAmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
