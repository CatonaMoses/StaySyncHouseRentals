Imports System.Data.OleDb
Public Class REGISTER
    Dim mycon As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Loginn.accdb")

    Private Sub IconButtonRegister_Click(sender As Object, e As EventArgs) Handles IconButtonRegister.Click
        mycon.Open()
        Dim mycmd As New OleDbCommand("Insert into Account(Uname,Passw,Email,Num) Values ('" & txtUsernameRegister.Text & "','" & txtPasswordRegister.Text & "','" & txtEmail.Text & "','" & txtNumber.Text & "')", mycon)
        Try
            mycmd.ExecuteNonQuery()
            mycon.Close()
            txtUsernameRegister.Clear()
            txtPasswordRegister.Clear()
            txtEmail.Clear()
            txtNumber.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub IconButtonLogin_Click(sender As Object, e As EventArgs) Handles IconButtonLogin.Click
        Me.Close()
        LOGIN.Show()
    End Sub

End Class