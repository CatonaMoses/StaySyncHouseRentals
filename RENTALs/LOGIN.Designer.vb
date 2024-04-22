<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LOGIN
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.IconButtonLogin = New FontAwesome.Sharp.IconButton()
        Me.IconButtonRegister = New FontAwesome.Sharp.IconButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Honeydew
        Me.Label1.Location = New System.Drawing.Point(249, 158)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 28)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Sign In"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.txtUsername)
        Me.Panel1.Controls.Add(Me.PictureBox5)
        Me.Panel1.Location = New System.Drawing.Point(128, 286)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(323, 61)
        Me.Panel1.TabIndex = 2
        '
        'txtUsername
        '
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.ForeColor = System.Drawing.Color.Black
        Me.txtUsername.Location = New System.Drawing.Point(59, 16)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtUsername.Size = New System.Drawing.Size(243, 23)
        Me.txtUsername.TabIndex = 4
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.RENTALs.My.Resources.Resources.locked1
        Me.PictureBox5.Location = New System.Drawing.Point(3, 10)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 3
        Me.PictureBox5.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.RENTALs.My.Resources.Resources.user1
        Me.PictureBox2.Location = New System.Drawing.Point(3, 9)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.txtPassword)
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Location = New System.Drawing.Point(131, 208)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(320, 60)
        Me.Panel3.TabIndex = 3
        '
        'txtPassword
        '
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.Black
        Me.txtPassword.Location = New System.Drawing.Point(62, 17)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(243, 23)
        Me.txtPassword.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.PictureBox1.Image = Global.RENTALs.My.Resources.Resources.staysync231
        Me.PictureBox1.Location = New System.Drawing.Point(6, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(188, 142)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'IconButtonLogin
        '
        Me.IconButtonLogin.BackColor = System.Drawing.Color.LightYellow
        Me.IconButtonLogin.IconChar = FontAwesome.Sharp.IconChar.SignIn
        Me.IconButtonLogin.IconColor = System.Drawing.Color.Black
        Me.IconButtonLogin.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButtonLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButtonLogin.Location = New System.Drawing.Point(238, 16)
        Me.IconButtonLogin.Name = "IconButtonLogin"
        Me.IconButtonLogin.Size = New System.Drawing.Size(152, 86)
        Me.IconButtonLogin.TabIndex = 6
        Me.IconButtonLogin.Text = "Login"
        Me.IconButtonLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconButtonLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButtonLogin.UseVisualStyleBackColor = False
        '
        'IconButtonRegister
        '
        Me.IconButtonRegister.BackColor = System.Drawing.Color.LightYellow
        Me.IconButtonRegister.IconChar = FontAwesome.Sharp.IconChar.File
        Me.IconButtonRegister.IconColor = System.Drawing.Color.Black
        Me.IconButtonRegister.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButtonRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButtonRegister.Location = New System.Drawing.Point(12, 84)
        Me.IconButtonRegister.Name = "IconButtonRegister"
        Me.IconButtonRegister.Size = New System.Drawing.Size(197, 101)
        Me.IconButtonRegister.TabIndex = 7
        Me.IconButtonRegister.Text = "Register"
        Me.IconButtonRegister.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconButtonRegister.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButtonRegister.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Location = New System.Drawing.Point(0, -3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(568, 364)
        Me.Panel2.TabIndex = 8
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.IconButtonLogin)
        Me.Panel4.Controls.Add(Me.IconButtonRegister)
        Me.Panel4.Location = New System.Drawing.Point(0, 384)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(558, 188)
        Me.Panel4.TabIndex = 9
        '
        'LOGIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(597, 594)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LOGIN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LOGIN"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents IconButtonLogin As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButtonRegister As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
End Class
