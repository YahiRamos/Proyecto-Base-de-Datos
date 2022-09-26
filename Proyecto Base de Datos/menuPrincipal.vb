Imports System.Runtime.CompilerServices

Public Class menuPrincipal
    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        registro.Visible = True

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        pantallaLogin.Close()
    End Sub

    Private Sub btnModificarDatos_Click(sender As Object, e As EventArgs) Handles btnModificarDatos.Click
        modificacion.Visible = True
    End Sub

    Private Sub btnEliminarDatos_Click(sender As Object, e As EventArgs) Handles btnEliminarDatos.Click
        eliminacion.Visible = True
    End Sub

    Private Sub btnVisualizarDatos_Click(sender As Object, e As EventArgs) Handles btnVisualizarDatos.Click
        visualizacion.Visible = True
    End Sub

    Private Sub menuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class