<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class REGISTER
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.txtPasswordRegister = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtUsernameRegister = New System.Windows.Forms.TextBox()
        Me.lblRegister = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblNumber = New System.Windows.Forms.Label()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.IconButtonLogin = New FontAwesome.Sharp.IconButton()
        Me.IconButtonRegister = New FontAwesome.Sharp.IconButton()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.lblUsername)
        Me.Panel3.Controls.Add(Me.txtPasswordRegister)
        Me.Panel3.Location = New System.Drawing.Point(123, 108)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(365, 49)
        Me.Panel3.TabIndex = 7
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.Black
        Me.lblUsername.Location = New System.Drawing.Point(10, 17)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(104, 24)
        Me.lblUsername.TabIndex = 5
        Me.lblUsername.Text = "UserName:"
        '
        'txtPasswordRegister
        '
        Me.txtPasswordRegister.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPasswordRegister.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPasswordRegister.ForeColor = System.Drawing.Color.Black
        Me.txtPasswordRegister.Location = New System.Drawing.Point(120, 12)
        Me.txtPasswordRegister.Name = "txtPasswordRegister"
        Me.txtPasswordRegister.Size = New System.Drawing.Size(220, 27)
        Me.txtPasswordRegister.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.lblPassword)
        Me.Panel1.Controls.Add(Me.txtUsernameRegister)
        Me.Panel1.Location = New System.Drawing.Point(123, 174)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(365, 50)
        Me.Panel1.TabIndex = 6
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.Black
        Me.lblPassword.Location = New System.Drawing.Point(3, 13)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(95, 24)
        Me.lblPassword.TabIndex = 5
        Me.lblPassword.Text = "Password:"
        '
        'txtUsernameRegister
        '
        Me.txtUsernameRegister.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtUsernameRegister.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsernameRegister.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsernameRegister.ForeColor = System.Drawing.Color.Black
        Me.txtUsernameRegister.Location = New System.Drawing.Point(126, 13)
        Me.txtUsernameRegister.Name = "txtUsernameRegister"
        Me.txtUsernameRegister.Size = New System.Drawing.Size(201, 27)
        Me.txtUsernameRegister.TabIndex = 4
        '
        'lblRegister
        '
        Me.lblRegister.AutoSize = True
        Me.lblRegister.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegister.ForeColor = System.Drawing.Color.Honeydew
        Me.lblRegister.Location = New System.Drawing.Point(238, 59)
        Me.lblRegister.Name = "lblRegister"
        Me.lblRegister.Size = New System.Drawing.Size(90, 28)
        Me.lblRegister.TabIndex = 5
        Me.lblRegister.Text = "Register"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.White
        Me.Panel7.Controls.Add(Me.lblEmail)
        Me.Panel7.Controls.Add(Me.txtEmail)
        Me.Panel7.Location = New System.Drawing.Point(123, 240)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(365, 52)
        Me.Panel7.TabIndex = 9
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.Black
        Me.lblEmail.Location = New System.Drawing.Point(7, 10)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(73, 27)
        Me.lblEmail.TabIndex = 0
        Me.lblEmail.Text = "Email:"
        '
        'txtEmail
        '
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.ForeColor = System.Drawing.Color.Black
        Me.txtEmail.Location = New System.Drawing.Point(86, 14)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(268, 27)
        Me.txtEmail.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.lblNumber)
        Me.Panel2.Controls.Add(Me.txtNumber)
        Me.Panel2.Location = New System.Drawing.Point(123, 307)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(365, 60)
        Me.Panel2.TabIndex = 10
        '
        'lblNumber
        '
        Me.lblNumber.AutoSize = True
        Me.lblNumber.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumber.ForeColor = System.Drawing.Color.Black
        Me.lblNumber.Location = New System.Drawing.Point(7, 10)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(101, 27)
        Me.lblNumber.TabIndex = 0
        Me.lblNumber.Text = "Number:"
        '
        'txtNumber
        '
        Me.txtNumber.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNumber.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumber.ForeColor = System.Drawing.Color.Black
        Me.txtNumber.Location = New System.Drawing.Point(117, 15)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(228, 27)
        Me.txtNumber.TabIndex = 4
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.IconButtonLogin)
        Me.Panel5.Controls.Add(Me.IconButtonRegister)
        Me.Panel5.Controls.Add(Me.Panel3)
        Me.Panel5.Controls.Add(Me.lblRegister)
        Me.Panel5.Controls.Add(Me.Panel2)
        Me.Panel5.Controls.Add(Me.Panel1)
        Me.Panel5.Controls.Add(Me.Panel7)
        Me.Panel5.Location = New System.Drawing.Point(5, 7)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(548, 594)
        Me.Panel5.TabIndex = 15
        '
        'IconButtonLogin
        '
        Me.IconButtonLogin.BackColor = System.Drawing.Color.LightYellow
        Me.IconButtonLogin.ForeColor = System.Drawing.Color.Black
        Me.IconButtonLogin.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt
        Me.IconButtonLogin.IconColor = System.Drawing.Color.Black
        Me.IconButtonLogin.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButtonLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButtonLogin.Location = New System.Drawing.Point(22, 488)
        Me.IconButtonLogin.Name = "IconButtonLogin"
        Me.IconButtonLogin.Size = New System.Drawing.Size(181, 91)
        Me.IconButtonLogin.TabIndex = 12
        Me.IconButtonLogin.Text = "BackToLogin"
        Me.IconButtonLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconButtonLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButtonLogin.UseVisualStyleBackColor = False
        '
        'IconButtonRegister
        '
        Me.IconButtonRegister.BackColor = System.Drawing.Color.LightYellow
        Me.IconButtonRegister.ForeColor = System.Drawing.Color.Black
        Me.IconButtonRegister.IconChar = FontAwesome.Sharp.IconChar.File
        Me.IconButtonRegister.IconColor = System.Drawing.Color.Black
        Me.IconButtonRegister.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButtonRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButtonRegister.Location = New System.Drawing.Point(221, 373)
        Me.IconButtonRegister.Name = "IconButtonRegister"
        Me.IconButtonRegister.Size = New System.Drawing.Size(180, 102)
        Me.IconButtonRegister.TabIndex = 13
        Me.IconButtonRegister.Text = "Register"
        Me.IconButtonRegister.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconButtonRegister.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButtonRegister.UseVisualStyleBackColor = False
        '
        'REGISTER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(601, 598)
        Me.Controls.Add(Me.Panel5)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "REGISTER"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "REGISTER"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtPasswordRegister As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtUsernameRegister As TextBox
    Friend WithEvents lblRegister As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblNumber As Label
    Friend WithEvents txtNumber As TextBox
    Friend WithEvents IconButtonLogin As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButtonRegister As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel5 As Panel
End Class
