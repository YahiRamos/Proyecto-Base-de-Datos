Imports System.Diagnostics.Eventing.Reader
Imports Oracle.DataAccess.Client
Public Class pantallaLogin
    Private Sub pantallaLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUser.Clear()
        txtPassword.Clear()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtUser.TextChanged

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim dataSource = "Data Source=XE;", userId = "User Id=", password As String
        If txtUser.Text.ToLower.Equals("hr") And txtPassword.Text.Equals("hr") Then
            userId += txtUser.Text + ";"
            password = "Password=" + txtPassword.Text + ";"
            Dim connection = New OracleConnection(dataSource + userId + password)
            MessageBox.Show("conexion establecida")
            Dim menu = New menuPrincipal()
            menu.Show()
            Hide()
        Else
            MessageBox.Show("conexion no establecida, usuario o contraseña no validas")
        End If
    End Sub
End Class