<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormTenants
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ID_NumberLabel As System.Windows.Forms.Label
        Dim Tenant_NamesLabel As System.Windows.Forms.Label
        Dim Phone_NumberLabel As System.Windows.Forms.Label
        Dim Date_Of_RENTINGLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTenants))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.IconBtnAdd = New FontAwesome.Sharp.IconButton()
        Me.IconButtonDelete = New FontAwesome.Sharp.IconButton()
        Me.IconButton1save = New FontAwesome.Sharp.IconButton()
        Me._TENANTS_REANTALS_BACKUPDataSet = New RENTALs._TENANTS_REANTALS_BACKUPDataSet()
        Me.TenantsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TenantsTableAdapter = New RENTALs._TENANTS_REANTALS_BACKUPDataSetTableAdapters.TenantsTableAdapter()
        Me.TableAdapterManager = New RENTALs._TENANTS_REANTALS_BACKUPDataSetTableAdapters.TableAdapterManager()
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
        Me.ID_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.Tenant_NamesTextBox = New System.Windows.Forms.TextBox()
        Me.Phone_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.Date_Of_RENTINGDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenantNamesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateOfRENTINGDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        ID_NumberLabel = New System.Windows.Forms.Label()
        Tenant_NamesLabel = New System.Windows.Forms.Label()
        Phone_NumberLabel = New System.Windows.Forms.Label()
        Date_Of_RENTINGLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me._TENANTS_REANTALS_BACKUPDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TenantsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TenantsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TenantsBindingNavigator.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ID_NumberLabel
        '
        ID_NumberLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        ID_NumberLabel.AutoSize = True
        ID_NumberLabel.Font = New System.Drawing.Font("Segoe UI", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ID_NumberLabel.Location = New System.Drawing.Point(38, 52)
        ID_NumberLabel.Name = "ID_NumberLabel"
        ID_NumberLabel.Size = New System.Drawing.Size(112, 25)
        ID_NumberLabel.TabIndex = 19
        ID_NumberLabel.Text = "ID-Number:"
        '
        'Tenant_NamesLabel
        '
        Tenant_NamesLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Tenant_NamesLabel.AutoSize = True
        Tenant_NamesLabel.Font = New System.Drawing.Font("Segoe UI", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Tenant_NamesLabel.Location = New System.Drawing.Point(38, 99)
        Tenant_NamesLabel.Name = "Tenant_NamesLabel"
        Tenant_NamesLabel.Size = New System.Drawing.Size(140, 25)
        Tenant_NamesLabel.TabIndex = 21
        Tenant_NamesLabel.Text = "Tenant Names:"
        '
        'Phone_NumberLabel
        '
        Phone_NumberLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Phone_NumberLabel.AutoSize = True
        Phone_NumberLabel.Font = New System.Drawing.Font("Segoe UI", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Phone_NumberLabel.Location = New System.Drawing.Point(38, 149)
        Phone_NumberLabel.Name = "Phone_NumberLabel"
        Phone_NumberLabel.Size = New System.Drawing.Size(142, 25)
        Phone_NumberLabel.TabIndex = 23
        Phone_NumberLabel.Text = "Phone Number:"
        '
        'Date_Of_RENTINGLabel
        '
        Date_Of_RENTINGLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Date_Of_RENTINGLabel.AutoSize = True
        Date_Of_RENTINGLabel.Font = New System.Drawing.Font("Segoe UI", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Date_Of_RENTINGLabel.Location = New System.Drawing.Point(38, 199)
        Date_Of_RENTINGLabel.Name = "Date_Of_RENTINGLabel"
        Date_Of_RENTINGLabel.Size = New System.Drawing.Size(173, 25)
        Date_Of_RENTINGLabel.TabIndex = 25
        Date_Of_RENTINGLabel.Text = "Date-Of-RENTING:"
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Panel1.Controls.Add(Me.IconBtnAdd)
        Me.Panel1.Controls.Add(Me.IconButtonDelete)
        Me.Panel1.Controls.Add(Me.IconButton1save)
        Me.Panel1.Location = New System.Drawing.Point(83, 340)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(532, 201)
        Me.Panel1.TabIndex = 18
        '
        'IconBtnAdd
        '
        Me.IconBtnAdd.BackColor = System.Drawing.Color.Linen
        Me.IconBtnAdd.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal
        Me.IconBtnAdd.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconBtnAdd.IconChar = FontAwesome.Sharp.IconChar.Add
        Me.IconBtnAdd.IconColor = System.Drawing.Color.Black
        Me.IconBtnAdd.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconBtnAdd.Location = New System.Drawing.Point(8, 13)
        Me.IconBtnAdd.Name = "IconBtnAdd"
        Me.IconBtnAdd.Size = New System.Drawing.Size(183, 78)
        Me.IconBtnAdd.TabIndex = 15
        Me.IconBtnAdd.Text = "ADD"
        Me.IconBtnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconBtnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconBtnAdd.UseVisualStyleBackColor = False
        '
        'IconButtonDelete
        '
        Me.IconButtonDelete.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.IconButtonDelete.BackColor = System.Drawing.Color.Linen
        Me.IconButtonDelete.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButtonDelete.IconChar = FontAwesome.Sharp.IconChar.Eraser
        Me.IconButtonDelete.IconColor = System.Drawing.Color.Black
        Me.IconButtonDelete.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButtonDelete.Location = New System.Drawing.Point(8, 119)
        Me.IconButtonDelete.Name = "IconButtonDelete"
        Me.IconButtonDelete.Size = New System.Drawing.Size(10, 57)
        Me.IconButtonDelete.TabIndex = 17
        Me.IconButtonDelete.Text = "DELETE"
        Me.IconButtonDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButtonDelete.UseVisualStyleBackColor = False
        '
        'IconButton1save
        '
        Me.IconButton1save.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.IconButton1save.BackColor = System.Drawing.Color.Linen
        Me.IconButton1save.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton1save.IconChar = FontAwesome.Sharp.IconChar.Stamp
        Me.IconButton1save.IconColor = System.Drawing.Color.Black
        Me.IconButton1save.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1save.Location = New System.Drawing.Point(246, 13)
        Me.IconButton1save.Name = "IconButton1save"
        Me.IconButton1save.Size = New System.Drawing.Size(178, 78)
        Me.IconButton1save.TabIndex = 16
        Me.IconButton1save.Text = "SAVE"
        Me.IconButton1save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton1save.UseVisualStyleBackColor = False
        '
        '_TENANTS_REANTALS_BACKUPDataSet
        '
        Me._TENANTS_REANTALS_BACKUPDataSet.DataSetName = "_TENANTS_REANTALS_BACKUPDataSet"
        Me._TENANTS_REANTALS_BACKUPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TenantsBindingSource
        '
        Me.TenantsBindingSource.DataMember = "Tenants"
        Me.TenantsBindingSource.DataSource = Me._TENANTS_REANTALS_BACKUPDataSet
        '
        'TenantsTableAdapter
        '
        Me.TenantsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ExpensesTableAdapter = Nothing
        Me.TableAdapterManager.FinancesTableAdapter = Nothing
        Me.TableAdapterManager.HousesTableAdapter = Nothing
        Me.TableAdapterManager.TenantsTableAdapter = Me.TenantsTableAdapter
        Me.TableAdapterManager.UpdateOrder = RENTALs._TENANTS_REANTALS_BACKUPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
        Me.TenantsBindingNavigator.Size = New System.Drawing.Size(1410, 27)
        Me.TenantsBindingNavigator.TabIndex = 19
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
        'ID_NumberTextBox
        '
        Me.ID_NumberTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ID_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TenantsBindingSource, "ID-Number", True))
        Me.ID_NumberTextBox.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID_NumberTextBox.Location = New System.Drawing.Point(304, 39)
        Me.ID_NumberTextBox.Name = "ID_NumberTextBox"
        Me.ID_NumberTextBox.Size = New System.Drawing.Size(200, 38)
        Me.ID_NumberTextBox.TabIndex = 20
        '
        'Tenant_NamesTextBox
        '
        Me.Tenant_NamesTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Tenant_NamesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TenantsBindingSource, "Tenant_Names", True))
        Me.Tenant_NamesTextBox.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tenant_NamesTextBox.Location = New System.Drawing.Point(304, 86)
        Me.Tenant_NamesTextBox.Name = "Tenant_NamesTextBox"
        Me.Tenant_NamesTextBox.Size = New System.Drawing.Size(200, 38)
        Me.Tenant_NamesTextBox.TabIndex = 22
        '
        'Phone_NumberTextBox
        '
        Me.Phone_NumberTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Phone_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TenantsBindingSource, "Phone_Number", True))
        Me.Phone_NumberTextBox.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Phone_NumberTextBox.Location = New System.Drawing.Point(304, 136)
        Me.Phone_NumberTextBox.Name = "Phone_NumberTextBox"
        Me.Phone_NumberTextBox.Size = New System.Drawing.Size(200, 38)
        Me.Phone_NumberTextBox.TabIndex = 24
        '
        'Date_Of_RENTINGDateTimePicker
        '
        Me.Date_Of_RENTINGDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Date_Of_RENTINGDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TenantsBindingSource, "Date-Of-RENTING", True))
        Me.Date_Of_RENTINGDateTimePicker.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date_Of_RENTINGDateTimePicker.Location = New System.Drawing.Point(304, 186)
        Me.Date_Of_RENTINGDateTimePicker.Name = "Date_Of_RENTINGDateTimePicker"
        Me.Date_Of_RENTINGDateTimePicker.Size = New System.Drawing.Size(200, 38)
        Me.Date_Of_RENTINGDateTimePicker.TabIndex = 26
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDNumberDataGridViewTextBoxColumn, Me.TenantNamesDataGridViewTextBoxColumn, Me.PhoneNumberDataGridViewTextBoxColumn, Me.DateOfRENTINGDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TenantsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(644, 46)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(766, 304)
        Me.DataGridView1.TabIndex = 27
        '
        'IDNumberDataGridViewTextBoxColumn
        '
        Me.IDNumberDataGridViewTextBoxColumn.DataPropertyName = "ID-Number"
        Me.IDNumberDataGridViewTextBoxColumn.HeaderText = "ID-Number"
        Me.IDNumberDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IDNumberDataGridViewTextBoxColumn.Name = "IDNumberDataGridViewTextBoxColumn"
        Me.IDNumberDataGridViewTextBoxColumn.Width = 125
        '
        'TenantNamesDataGridViewTextBoxColumn
        '
        Me.TenantNamesDataGridViewTextBoxColumn.DataPropertyName = "Tenant_Names"
        Me.TenantNamesDataGridViewTextBoxColumn.HeaderText = "Tenant_Names"
        Me.TenantNamesDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TenantNamesDataGridViewTextBoxColumn.Name = "TenantNamesDataGridViewTextBoxColumn"
        Me.TenantNamesDataGridViewTextBoxColumn.Width = 125
        '
        'PhoneNumberDataGridViewTextBoxColumn
        '
        Me.PhoneNumberDataGridViewTextBoxColumn.DataPropertyName = "Phone_Number"
        Me.PhoneNumberDataGridViewTextBoxColumn.HeaderText = "Phone_Number"
        Me.PhoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PhoneNumberDataGridViewTextBoxColumn.Name = "PhoneNumberDataGridViewTextBoxColumn"
        Me.PhoneNumberDataGridViewTextBoxColumn.Width = 125
        '
        'DateOfRENTINGDataGridViewTextBoxColumn
        '
        Me.DateOfRENTINGDataGridViewTextBoxColumn.DataPropertyName = "Date-Of-RENTING"
        Me.DateOfRENTINGDataGridViewTextBoxColumn.HeaderText = "Date-Of-RENTING"
        Me.DateOfRENTINGDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DateOfRENTINGDataGridViewTextBoxColumn.Name = "DateOfRENTINGDataGridViewTextBoxColumn"
        Me.DateOfRENTINGDataGridViewTextBoxColumn.Width = 125
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel2.Controls.Add(Me.ID_NumberTextBox)
        Me.Panel2.Controls.Add(Me.Date_Of_RENTINGDateTimePicker)
        Me.Panel2.Controls.Add(ID_NumberLabel)
        Me.Panel2.Controls.Add(Date_Of_RENTINGLabel)
        Me.Panel2.Controls.Add(Me.Phone_NumberTextBox)
        Me.Panel2.Controls.Add(Tenant_NamesLabel)
        Me.Panel2.Controls.Add(Phone_NumberLabel)
        Me.Panel2.Controls.Add(Me.Tenant_NamesTextBox)
        Me.Panel2.Location = New System.Drawing.Point(40, 62)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(598, 260)
        Me.Panel2.TabIndex = 28
        '
        'FormTenants
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.ClientSize = New System.Drawing.Size(1410, 553)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TenantsBindingNavigator)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormTenants"
        Me.Text = "FormTenants"
        Me.Panel1.ResumeLayout(False)
        CType(Me._TENANTS_REANTALS_BACKUPDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TenantsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TenantsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TenantsBindingNavigator.ResumeLayout(False)
        Me.TenantsBindingNavigator.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IconButtonDelete As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton1save As FontAwesome.Sharp.IconButton
    Friend WithEvents IconBtnAdd As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents _TENANTS_REANTALS_BACKUPDataSet As _TENANTS_REANTALS_BACKUPDataSet
    Friend WithEvents TenantsBindingSource As BindingSource
    Friend WithEvents TenantsTableAdapter As _TENANTS_REANTALS_BACKUPDataSetTableAdapters.TenantsTableAdapter
    Friend WithEvents TableAdapterManager As _TENANTS_REANTALS_BACKUPDataSetTableAdapters.TableAdapterManager
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
    Friend WithEvents ID_NumberTextBox As TextBox
    Friend WithEvents Tenant_NamesTextBox As TextBox
    Friend WithEvents Phone_NumberTextBox As TextBox
    Friend WithEvents Date_Of_RENTINGDateTimePicker As DateTimePicker
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents IDNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TenantNamesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhoneNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateOfRENTINGDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Panel2 As Panel
End Class
