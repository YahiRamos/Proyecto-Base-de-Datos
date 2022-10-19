Imports Oracle.ManagedDataAccess.Client
Public Class pantallaLogin
    Private Sub pantallaLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUser.Clear()
        txtPassword.Clear()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtUser.TextChanged

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If txtPassword.Text = "" And txtUser.Text = "" Or txtPassword.Text = "" Or txtUser.Text = "" Then
            MessageBox.Show("Ingrese Datos de Inicio de Sesion")
        Else
            Dim dataSource = "Data Source=127.0.0.1;", userId = "User Id=", password As String
            If txtUser.Text.ToLower.Equals("hr") And txtPassword.Text.ToLower.Equals("hr") Then
                userId += txtUser.Text + ";"
                password = "Password=" + txtPassword.Text + ";"
                Dim connection = New OracleConnection(dataSource + userId + password)
                connection.Open()
                MessageBox.Show("conexion establecida")
                Dim menu = New menuPrincipal()
                menu.Show()
                Hide()
                connection.Close()
            Else
                MessageBox.Show("conexion no establecida, usuario o contraseña no validas")
            End If
        End If
    End Sub
End Class