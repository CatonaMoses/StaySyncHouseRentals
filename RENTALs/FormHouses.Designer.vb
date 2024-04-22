<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHouses
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
        Dim House_NameLabel As System.Windows.Forms.Label
        Dim House_IDLabel As System.Windows.Forms.Label
        Dim Monthly_PaymentsLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormHouses))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.IconBtnAdd = New FontAwesome.Sharp.IconButton()
        Me.IconButton1save = New FontAwesome.Sharp.IconButton()
        Me.IconButtonDelete = New FontAwesome.Sharp.IconButton()
        Me._TENANTS_REANTALS_BACKUPDataSet = New RENTALs._TENANTS_REANTALS_BACKUPDataSet()
        Me.HousesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HousesTableAdapter = New RENTALs._TENANTS_REANTALS_BACKUPDataSetTableAdapters.HousesTableAdapter()
        Me.TableAdapterManager = New RENTALs._TENANTS_REANTALS_BACKUPDataSetTableAdapters.TableAdapterManager()
        Me.HousesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.HousesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.House_NameTextBox = New System.Windows.Forms.TextBox()
        Me.House_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Monthly_PaymentsTextBox = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.HouseNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HouseIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MonthlyPaymentsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        House_NameLabel = New System.Windows.Forms.Label()
        House_IDLabel = New System.Windows.Forms.Label()
        Monthly_PaymentsLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me._TENANTS_REANTALS_BACKUPDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HousesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HousesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HousesBindingNavigator.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'House_NameLabel
        '
        House_NameLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        House_NameLabel.AutoSize = True
        House_NameLabel.Font = New System.Drawing.Font("Segoe UI", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        House_NameLabel.Location = New System.Drawing.Point(14, 27)
        House_NameLabel.Name = "House_NameLabel"
        House_NameLabel.Size = New System.Drawing.Size(119, 23)
        House_NameLabel.TabIndex = 13
        House_NameLabel.Text = "House-Name:"
        '
        'House_IDLabel
        '
        House_IDLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        House_IDLabel.AutoSize = True
        House_IDLabel.Font = New System.Drawing.Font("Segoe UI", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        House_IDLabel.Location = New System.Drawing.Point(14, 83)
        House_IDLabel.Name = "House_IDLabel"
        House_IDLabel.Size = New System.Drawing.Size(89, 23)
        House_IDLabel.TabIndex = 15
        House_IDLabel.Text = "House-ID:"
        '
        'Monthly_PaymentsLabel
        '
        Monthly_PaymentsLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Monthly_PaymentsLabel.AutoSize = True
        Monthly_PaymentsLabel.Font = New System.Drawing.Font("Segoe UI", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Monthly_PaymentsLabel.Location = New System.Drawing.Point(14, 142)
        Monthly_PaymentsLabel.Name = "Monthly_PaymentsLabel"
        Monthly_PaymentsLabel.Size = New System.Drawing.Size(164, 23)
        Monthly_PaymentsLabel.TabIndex = 17
        Monthly_PaymentsLabel.Text = "Monthly-Payments:"
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.Controls.Add(Me.IconBtnAdd)
        Me.Panel1.Controls.Add(Me.IconButton1save)
        Me.Panel1.Controls.Add(Me.IconButtonDelete)
        Me.Panel1.Location = New System.Drawing.Point(122, 293)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(555, 168)
        Me.Panel1.TabIndex = 12
        '
        'IconBtnAdd
        '
        Me.IconBtnAdd.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.IconBtnAdd.BackColor = System.Drawing.Color.OldLace
        Me.IconBtnAdd.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal
        Me.IconBtnAdd.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconBtnAdd.IconChar = FontAwesome.Sharp.IconChar.Add
        Me.IconBtnAdd.IconColor = System.Drawing.Color.Black
        Me.IconBtnAdd.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconBtnAdd.Location = New System.Drawing.Point(36, 14)
        Me.IconBtnAdd.Name = "IconBtnAdd"
        Me.IconBtnAdd.Size = New System.Drawing.Size(153, 69)
        Me.IconBtnAdd.TabIndex = 9
        Me.IconBtnAdd.Text = "ADD"
        Me.IconBtnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconBtnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconBtnAdd.UseVisualStyleBackColor = False
        '
        'IconButton1save
        '
        Me.IconButton1save.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.IconButton1save.BackColor = System.Drawing.Color.OldLace
        Me.IconButton1save.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton1save.IconChar = FontAwesome.Sharp.IconChar.Stamp
        Me.IconButton1save.IconColor = System.Drawing.Color.Black
        Me.IconButton1save.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1save.Location = New System.Drawing.Point(260, 14)
        Me.IconButton1save.Name = "IconButton1save"
        Me.IconButton1save.Size = New System.Drawing.Size(165, 69)
        Me.IconButton1save.TabIndex = 10
        Me.IconButton1save.Text = "SAVE"
        Me.IconButton1save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton1save.UseVisualStyleBackColor = False
        '
        'IconButtonDelete
        '
        Me.IconButtonDelete.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.IconButtonDelete.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.IconButtonDelete.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButtonDelete.IconChar = FontAwesome.Sharp.IconChar.Eraser
        Me.IconButtonDelete.IconColor = System.Drawing.Color.Black
        Me.IconButtonDelete.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButtonDelete.Location = New System.Drawing.Point(16, 93)
        Me.IconButtonDelete.Name = "IconButtonDelete"
        Me.IconButtonDelete.Size = New System.Drawing.Size(10, 57)
        Me.IconButtonDelete.TabIndex = 11
        Me.IconButtonDelete.Text = "DELETE"
        Me.IconButtonDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButtonDelete.UseVisualStyleBackColor = False
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
        'HousesTableAdapter
        '
        Me.HousesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ExpensesTableAdapter = Nothing
        Me.TableAdapterManager.FinancesTableAdapter = Nothing
        Me.TableAdapterManager.HousesTableAdapter = Me.HousesTableAdapter
        Me.TableAdapterManager.TenantsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = RENTALs._TENANTS_REANTALS_BACKUPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'HousesBindingNavigator
        '
        Me.HousesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.HousesBindingNavigator.BindingSource = Me.HousesBindingSource
        Me.HousesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.HousesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.HousesBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.HousesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.HousesBindingNavigatorSaveItem})
        Me.HousesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.HousesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.HousesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.HousesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.HousesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.HousesBindingNavigator.Name = "HousesBindingNavigator"
        Me.HousesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.HousesBindingNavigator.Size = New System.Drawing.Size(1297, 27)
        Me.HousesBindingNavigator.TabIndex = 13
        Me.HousesBindingNavigator.Text = "BindingNavigator1"
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
        'HousesBindingNavigatorSaveItem
        '
        Me.HousesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.HousesBindingNavigatorSaveItem.Image = CType(resources.GetObject("HousesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.HousesBindingNavigatorSaveItem.Name = "HousesBindingNavigatorSaveItem"
        Me.HousesBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 24)
        Me.HousesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'House_NameTextBox
        '
        Me.House_NameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.House_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HousesBindingSource, "House-Name", True))
        Me.House_NameTextBox.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.House_NameTextBox.Location = New System.Drawing.Point(254, 12)
        Me.House_NameTextBox.Name = "House_NameTextBox"
        Me.House_NameTextBox.Size = New System.Drawing.Size(200, 43)
        Me.House_NameTextBox.TabIndex = 14
        '
        'House_IDTextBox
        '
        Me.House_IDTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.House_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HousesBindingSource, "House-ID", True))
        Me.House_IDTextBox.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.House_IDTextBox.Location = New System.Drawing.Point(254, 68)
        Me.House_IDTextBox.Name = "House_IDTextBox"
        Me.House_IDTextBox.Size = New System.Drawing.Size(200, 43)
        Me.House_IDTextBox.TabIndex = 16
        '
        'Monthly_PaymentsTextBox
        '
        Me.Monthly_PaymentsTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Monthly_PaymentsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HousesBindingSource, "Monthly-Payments", True))
        Me.Monthly_PaymentsTextBox.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Monthly_PaymentsTextBox.Location = New System.Drawing.Point(254, 127)
        Me.Monthly_PaymentsTextBox.Name = "Monthly_PaymentsTextBox"
        Me.Monthly_PaymentsTextBox.Size = New System.Drawing.Size(200, 43)
        Me.Monthly_PaymentsTextBox.TabIndex = 18
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel2.Controls.Add(Me.House_NameTextBox)
        Me.Panel2.Controls.Add(House_NameLabel)
        Me.Panel2.Controls.Add(Me.Monthly_PaymentsTextBox)
        Me.Panel2.Controls.Add(Monthly_PaymentsLabel)
        Me.Panel2.Controls.Add(House_IDLabel)
        Me.Panel2.Controls.Add(Me.House_IDTextBox)
        Me.Panel2.Location = New System.Drawing.Point(67, 71)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(573, 201)
        Me.Panel2.TabIndex = 19
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.HouseNameDataGridViewTextBoxColumn, Me.HouseIDDataGridViewTextBoxColumn, Me.MonthlyPaymentsDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.HousesBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(716, 71)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(543, 245)
        Me.DataGridView1.TabIndex = 20
        '
        'HouseNameDataGridViewTextBoxColumn
        '
        Me.HouseNameDataGridViewTextBoxColumn.DataPropertyName = "House-Name"
        Me.HouseNameDataGridViewTextBoxColumn.HeaderText = "House-Name"
        Me.HouseNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.HouseNameDataGridViewTextBoxColumn.Name = "HouseNameDataGridViewTextBoxColumn"
        Me.HouseNameDataGridViewTextBoxColumn.Width = 125
        '
        'HouseIDDataGridViewTextBoxColumn
        '
        Me.HouseIDDataGridViewTextBoxColumn.DataPropertyName = "House-ID"
        Me.HouseIDDataGridViewTextBoxColumn.HeaderText = "House-ID"
        Me.HouseIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.HouseIDDataGridViewTextBoxColumn.Name = "HouseIDDataGridViewTextBoxColumn"
        Me.HouseIDDataGridViewTextBoxColumn.Width = 125
        '
        'MonthlyPaymentsDataGridViewTextBoxColumn
        '
        Me.MonthlyPaymentsDataGridViewTextBoxColumn.DataPropertyName = "Monthly-Payments"
        Me.MonthlyPaymentsDataGridViewTextBoxColumn.HeaderText = "Monthly-Payments"
        Me.MonthlyPaymentsDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MonthlyPaymentsDataGridViewTextBoxColumn.Name = "MonthlyPaymentsDataGridViewTextBoxColumn"
        Me.MonthlyPaymentsDataGridViewTextBoxColumn.Width = 125
        '
        'FormHouses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(1297, 483)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.HousesBindingNavigator)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormHouses"
        Me.Text = "FormHouses"
        Me.Panel1.ResumeLayout(False)
        CType(Me._TENANTS_REANTALS_BACKUPDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HousesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HousesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HousesBindingNavigator.ResumeLayout(False)
        Me.HousesBindingNavigator.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IconBtnAdd As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton1save As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButtonDelete As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents _TENANTS_REANTALS_BACKUPDataSet As _TENANTS_REANTALS_BACKUPDataSet
    Friend WithEvents HousesBindingSource As BindingSource
    Friend WithEvents HousesTableAdapter As _TENANTS_REANTALS_BACKUPDataSetTableAdapters.HousesTableAdapter
    Friend WithEvents TableAdapterManager As _TENANTS_REANTALS_BACKUPDataSetTableAdapters.TableAdapterManager
    Friend WithEvents HousesBindingNavigator As BindingNavigator
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
    Friend WithEvents HousesBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents House_NameTextBox As TextBox
    Friend WithEvents House_IDTextBox As TextBox
    Friend WithEvents Monthly_PaymentsTextBox As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents HouseNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HouseIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MonthlyPaymentsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
