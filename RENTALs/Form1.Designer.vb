<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.IconButtonPayments = New FontAwesome.Sharp.IconButton()
        Me.IconButtonHouses = New FontAwesome.Sharp.IconButton()
        Me.IconButtonExpenses = New FontAwesome.Sharp.IconButton()
        Me.IconButtonFinances = New FontAwesome.Sharp.IconButton()
        Me.IconButtonTenants = New FontAwesome.Sharp.IconButton()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.ImageHome = New System.Windows.Forms.PictureBox()
        Me.PanelTitle = New System.Windows.Forms.Panel()
        Me.ButtonMinimize = New System.Windows.Forms.Button()
        Me.ButtonExit = New System.Windows.Forms.Button()
        Me.ButtonRestore = New System.Windows.Forms.Button()
        Me.LabelTitle = New System.Windows.Forms.Label()
        Me.IconPictureBoxTitle = New FontAwesome.Sharp.IconPictureBox()
        Me.panelPutDesktop = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelMenu.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        CType(Me.ImageHome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTitle.SuspendLayout()
        CType(Me.IconPictureBoxTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelPutDesktop.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.IconButton1)
        Me.PanelMenu.Controls.Add(Me.IconButtonPayments)
        Me.PanelMenu.Controls.Add(Me.IconButtonHouses)
        Me.PanelMenu.Controls.Add(Me.IconButtonExpenses)
        Me.PanelMenu.Controls.Add(Me.IconButtonFinances)
        Me.PanelMenu.Controls.Add(Me.IconButtonTenants)
        Me.PanelMenu.Controls.Add(Me.PanelLogo)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(220, 605)
        Me.PanelMenu.TabIndex = 0
        '
        'IconButton1
        '
        Me.IconButton1.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.Receipt
        Me.IconButton1.IconColor = System.Drawing.Color.WhiteSmoke
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.Location = New System.Drawing.Point(0, 390)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.IconButton1.Size = New System.Drawing.Size(220, 60)
        Me.IconButton1.TabIndex = 7
        Me.IconButton1.Text = "Receipts"
        Me.IconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton1.UseVisualStyleBackColor = True
        '
        'IconButtonPayments
        '
        Me.IconButtonPayments.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButtonPayments.FlatAppearance.BorderSize = 0
        Me.IconButtonPayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButtonPayments.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButtonPayments.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.IconButtonPayments.IconChar = FontAwesome.Sharp.IconChar.Coins
        Me.IconButtonPayments.IconColor = System.Drawing.Color.WhiteSmoke
        Me.IconButtonPayments.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButtonPayments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButtonPayments.Location = New System.Drawing.Point(0, 330)
        Me.IconButtonPayments.Name = "IconButtonPayments"
        Me.IconButtonPayments.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.IconButtonPayments.Size = New System.Drawing.Size(220, 60)
        Me.IconButtonPayments.TabIndex = 6
        Me.IconButtonPayments.Text = "Payments"
        Me.IconButtonPayments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButtonPayments.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButtonPayments.UseVisualStyleBackColor = True
        '
        'IconButtonHouses
        '
        Me.IconButtonHouses.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButtonHouses.FlatAppearance.BorderSize = 0
        Me.IconButtonHouses.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButtonHouses.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButtonHouses.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.IconButtonHouses.IconChar = FontAwesome.Sharp.IconChar.House
        Me.IconButtonHouses.IconColor = System.Drawing.Color.WhiteSmoke
        Me.IconButtonHouses.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButtonHouses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButtonHouses.Location = New System.Drawing.Point(0, 270)
        Me.IconButtonHouses.Name = "IconButtonHouses"
        Me.IconButtonHouses.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.IconButtonHouses.Size = New System.Drawing.Size(220, 60)
        Me.IconButtonHouses.TabIndex = 5
        Me.IconButtonHouses.Text = "Houses"
        Me.IconButtonHouses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButtonHouses.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButtonHouses.UseVisualStyleBackColor = True
        '
        'IconButtonExpenses
        '
        Me.IconButtonExpenses.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButtonExpenses.FlatAppearance.BorderSize = 0
        Me.IconButtonExpenses.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButtonExpenses.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButtonExpenses.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.IconButtonExpenses.IconChar = FontAwesome.Sharp.IconChar.MoneyBill1Wave
        Me.IconButtonExpenses.IconColor = System.Drawing.Color.WhiteSmoke
        Me.IconButtonExpenses.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButtonExpenses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButtonExpenses.Location = New System.Drawing.Point(0, 210)
        Me.IconButtonExpenses.Name = "IconButtonExpenses"
        Me.IconButtonExpenses.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.IconButtonExpenses.Size = New System.Drawing.Size(220, 60)
        Me.IconButtonExpenses.TabIndex = 4
        Me.IconButtonExpenses.Text = "Expenses"
        Me.IconButtonExpenses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButtonExpenses.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButtonExpenses.UseVisualStyleBackColor = True
        '
        'IconButtonFinances
        '
        Me.IconButtonFinances.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButtonFinances.FlatAppearance.BorderSize = 0
        Me.IconButtonFinances.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButtonFinances.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButtonFinances.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.IconButtonFinances.IconChar = FontAwesome.Sharp.IconChar.MoneyBills
        Me.IconButtonFinances.IconColor = System.Drawing.Color.WhiteSmoke
        Me.IconButtonFinances.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButtonFinances.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButtonFinances.Location = New System.Drawing.Point(0, 200)
        Me.IconButtonFinances.Name = "IconButtonFinances"
        Me.IconButtonFinances.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.IconButtonFinances.Size = New System.Drawing.Size(220, 10)
        Me.IconButtonFinances.TabIndex = 3
        Me.IconButtonFinances.Text = "Finances"
        Me.IconButtonFinances.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButtonFinances.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButtonFinances.UseVisualStyleBackColor = True
        '
        'IconButtonTenants
        '
        Me.IconButtonTenants.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButtonTenants.FlatAppearance.BorderSize = 0
        Me.IconButtonTenants.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButtonTenants.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButtonTenants.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.IconButtonTenants.IconChar = FontAwesome.Sharp.IconChar.T
        Me.IconButtonTenants.IconColor = System.Drawing.Color.WhiteSmoke
        Me.IconButtonTenants.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButtonTenants.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButtonTenants.Location = New System.Drawing.Point(0, 140)
        Me.IconButtonTenants.Name = "IconButtonTenants"
        Me.IconButtonTenants.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.IconButtonTenants.Size = New System.Drawing.Size(220, 60)
        Me.IconButtonTenants.TabIndex = 2
        Me.IconButtonTenants.Text = "Tenants"
        Me.IconButtonTenants.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButtonTenants.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButtonTenants.UseVisualStyleBackColor = True
        '
        'PanelLogo
        '
        Me.PanelLogo.Controls.Add(Me.ImageHome)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(220, 140)
        Me.PanelLogo.TabIndex = 0
        '
        'ImageHome
        '
        Me.ImageHome.Image = Global.RENTALs.My.Resources.Resources.staysync23
        Me.ImageHome.Location = New System.Drawing.Point(12, 12)
        Me.ImageHome.Name = "ImageHome"
        Me.ImageHome.Size = New System.Drawing.Size(185, 128)
        Me.ImageHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ImageHome.TabIndex = 0
        Me.ImageHome.TabStop = False
        '
        'PanelTitle
        '
        Me.PanelTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.PanelTitle.Controls.Add(Me.ButtonMinimize)
        Me.PanelTitle.Controls.Add(Me.ButtonExit)
        Me.PanelTitle.Controls.Add(Me.ButtonRestore)
        Me.PanelTitle.Controls.Add(Me.LabelTitle)
        Me.PanelTitle.Controls.Add(Me.IconPictureBoxTitle)
        Me.PanelTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitle.Font = New System.Drawing.Font("Century", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelTitle.Location = New System.Drawing.Point(220, 0)
        Me.PanelTitle.Name = "PanelTitle"
        Me.PanelTitle.Size = New System.Drawing.Size(805, 75)
        Me.PanelTitle.TabIndex = 1
        '
        'ButtonMinimize
        '
        Me.ButtonMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonMinimize.Font = New System.Drawing.Font("Century", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonMinimize.Image = Global.RENTALs.My.Resources.Resources.newminimi
        Me.ButtonMinimize.Location = New System.Drawing.Point(598, 13)
        Me.ButtonMinimize.Name = "ButtonMinimize"
        Me.ButtonMinimize.Size = New System.Drawing.Size(57, 49)
        Me.ButtonMinimize.TabIndex = 4
        Me.ButtonMinimize.UseVisualStyleBackColor = True
        '
        'ButtonExit
        '
        Me.ButtonExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ButtonExit.Image = Global.RENTALs.My.Resources.Resources.newclosenn
        Me.ButtonExit.Location = New System.Drawing.Point(720, 12)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(55, 50)
        Me.ButtonExit.TabIndex = 3
        Me.ButtonExit.UseVisualStyleBackColor = True
        '
        'ButtonRestore
        '
        Me.ButtonRestore.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonRestore.Image = Global.RENTALs.My.Resources.Resources.newrrestiore
        Me.ButtonRestore.Location = New System.Drawing.Point(661, 13)
        Me.ButtonRestore.Name = "ButtonRestore"
        Me.ButtonRestore.Size = New System.Drawing.Size(53, 49)
        Me.ButtonRestore.TabIndex = 2
        Me.ButtonRestore.UseVisualStyleBackColor = True
        '
        'LabelTitle
        '
        Me.LabelTitle.AutoSize = True
        Me.LabelTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.LabelTitle.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitle.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LabelTitle.Location = New System.Drawing.Point(106, 23)
        Me.LabelTitle.Name = "LabelTitle"
        Me.LabelTitle.Size = New System.Drawing.Size(81, 24)
        Me.LabelTitle.TabIndex = 1
        Me.LabelTitle.Text = "Staysync"
        '
        'IconPictureBoxTitle
        '
        Me.IconPictureBoxTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.IconPictureBoxTitle.ForeColor = System.Drawing.Color.Bisque
        Me.IconPictureBoxTitle.IconChar = FontAwesome.Sharp.IconChar.UniversalAccess
        Me.IconPictureBoxTitle.IconColor = System.Drawing.Color.Bisque
        Me.IconPictureBoxTitle.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBoxTitle.IconSize = 59
        Me.IconPictureBoxTitle.Location = New System.Drawing.Point(16, 13)
        Me.IconPictureBoxTitle.Name = "IconPictureBoxTitle"
        Me.IconPictureBoxTitle.Size = New System.Drawing.Size(83, 59)
        Me.IconPictureBoxTitle.TabIndex = 0
        Me.IconPictureBoxTitle.TabStop = False
        '
        'panelPutDesktop
        '
        Me.panelPutDesktop.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.panelPutDesktop.Controls.Add(Me.PictureBox1)
        Me.panelPutDesktop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelPutDesktop.Location = New System.Drawing.Point(220, 75)
        Me.panelPutDesktop.Name = "panelPutDesktop"
        Me.panelPutDesktop.Size = New System.Drawing.Size(805, 530)
        Me.panelPutDesktop.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.RENTALs.My.Resources.Resources.staysync23
        Me.PictureBox1.Location = New System.Drawing.Point(295, 185)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(185, 128)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1025, 605)
        Me.Controls.Add(Me.panelPutDesktop)
        Me.Controls.Add(Me.PanelTitle)
        Me.Controls.Add(Me.PanelMenu)
        Me.Name = "Form1"
        Me.Text = "  "
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelLogo.ResumeLayout(False)
        CType(Me.ImageHome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTitle.ResumeLayout(False)
        Me.PanelTitle.PerformLayout()
        CType(Me.IconPictureBoxTitle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelPutDesktop.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents ImageHome As PictureBox
    Friend WithEvents IconButtonExpenses As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButtonFinances As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButtonTenants As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButtonHouses As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelTitle As Panel
    Friend WithEvents LabelTitle As Label
    Friend WithEvents IconPictureBoxTitle As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents panelPutDesktop As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ButtonMinimize As Button
    Friend WithEvents ButtonExit As Button
    Friend WithEvents ButtonRestore As Button
    Friend WithEvents IconButtonPayments As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
End Class
