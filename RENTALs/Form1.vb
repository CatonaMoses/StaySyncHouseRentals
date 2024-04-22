Imports System.Runtime.InteropServices
Imports FontAwesome.Sharp

Public Class Form1
    'Fields
    Private currentBtn As IconButton
    Private leftBorderBtn As Panel
    Private currentChildForm As Form

    'Constructor
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        leftBorderBtn = New Panel()
        leftBorderBtn.Size = New Size(7, 60)
        PanelMenu.Controls.Add(leftBorderBtn)
        'Form
        Me.Text = String.Empty
        Me.ControlBox = False
        Me.DoubleBuffered = True
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea
    End Sub

    'Methods
    Private Sub ActivateButton(senderBtn As Object, customColor As Color)
        If senderBtn IsNot Nothing Then
            DisableButton()
            'Button
            currentBtn = CType(senderBtn, IconButton)
            currentBtn.BackColor = Color.FromArgb(37, 36, 81)
            currentBtn.ForeColor = customColor
            currentBtn.IconColor = customColor
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.ImageAlign = ContentAlignment.MiddleRight
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage
            'Left Border
            leftBorderBtn.BackColor = customColor
            leftBorderBtn.Location = New Point(0, currentBtn.Location.Y)
            leftBorderBtn.Visible = True
            leftBorderBtn.BringToFront()
            'current Form icon
            IconPictureBoxTitle.IconChar = currentBtn.IconChar
            IconPictureBoxTitle.IconColor = customColor

        End If
    End Sub

    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.FromArgb(31, 30, 68)
            currentBtn.ForeColor = Color.Gainsboro
            currentBtn.IconColor = Color.Gainsboro
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub

    Private Sub OpenChildForm(childForm As Form)
        'Open only form
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        currentChildForm = childForm
        'end
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        panelPutDesktop.Controls.Add(childForm)
        panelPutDesktop.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
        LabelTitle.Text = childForm.Text
    End Sub

    'Events

    Private Sub IconButtonTenants_Click(sender As Object, e As EventArgs) Handles IconButtonTenants.Click
        ActivateButton(sender, Color.BlanchedAlmond)
        OpenChildForm(New FormTenants)
    End Sub

    Private Sub IconButtonFinances_Click(sender As Object, e As EventArgs) Handles IconButtonFinances.Click
        ActivateButton(sender, Color.AntiqueWhite)
        OpenChildForm(New FormFinances)
    End Sub

    Private Sub IconButtonExpenses_Click(sender As Object, e As EventArgs) Handles IconButtonExpenses.Click
        ActivateButton(sender, Color.GhostWhite)
        OpenChildForm(New FormExpenses)
    End Sub

    Private Sub IconButtonHouses_Click(sender As Object, e As EventArgs) Handles IconButtonHouses.Click
        ActivateButton(sender, Color.Snow)
        OpenChildForm(New FormHouses)
    End Sub

    Private Sub ImageHome_Click(sender As Object, e As EventArgs) Handles ImageHome.Click
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        Reset()
    End Sub

    Private Sub Reset()
        DisableButton()
        leftBorderBtn.Visible = False
        IconPictureBoxTitle.IconChar = IconChar.Home
        IconPictureBoxTitle.IconColor = Color.Bisque
        LabelTitle.Text = "Home"
    End Sub
    'Drag Form
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal IParam As Integer)
    End Sub

    Private Sub PanelTitle_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelTitle.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If WindowState = FormWindowState.Maximized Then
            FormBorderStyle = FormBorderStyle.None
        Else
            FormBorderStyle = FormBorderStyle.Sizable
        End If
    End Sub

    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Application.Exit()
    End Sub

    Private Sub ButtonRestore_Click(sender As Object, e As EventArgs) Handles ButtonRestore.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        Else
            WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub ButtonMinimize_Click(sender As Object, e As EventArgs) Handles ButtonMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub IconButtonPayments_Click(sender As Object, e As EventArgs) Handles IconButtonPayments.Click
        ActivateButton(sender, Color.Azure)
        OpenChildForm(New PaymentsForm)
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        ActivateButton(sender, Color.Cyan)
        OpenChildForm(New FormReceipts)
    End Sub
End Class
