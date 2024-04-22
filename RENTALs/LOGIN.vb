Imports System.Data.OleDb

Public Class LOGIN
    Dim mycon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Loginn.accdb")

    Private Sub IconButtonLogin_Click(sender As Object, e As EventArgs) Handles IconButtonLogin.Click
        mycon.Open()
        Dim mycmd As New OleDbCommand("Select * from Account where Uname = '" & txtUsername.Text & "' And Passw = '" & txtPassword.Text & "'", mycon)
        Dim myread As OleDbDataReader = mycmd.ExecuteReader
        If myread.Read Then
            MsgBox("Success")
            txtUsername.Clear()
            txtPassword.Clear()
            Form1.Show()
            Me.Hide()
        Else
            MsgBox("The Password/Username seems incorrect ")
        End If
        mycon.Close()
    End Sub

    Private Sub IconButtonRegister_Click(sender As Object, e As EventArgs) Handles IconButtonRegister.Click
        REGISTER.Show()
        Me.Hide()
    End Sub

End Class