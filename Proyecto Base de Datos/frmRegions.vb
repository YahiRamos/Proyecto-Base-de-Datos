Public Class frmRegions

    Dim userInterfaceUpdater As New UserInterfaceUpdater()
    Private Sub frmRegions_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        UserInterfaceUpdater.defaultConfigFrmRegions()
    End Sub
    Private Sub btnBackMenu_Click(sender As Object, e As EventArgs) Handles btnBackMenu.Click
        Close()
        menuPrincipal.Visible = True
    End Sub

    Private Sub btnClean_Click(sender As Object, e As EventArgs) Handles btnClean.Click
        userInterfaceUpdater.defaultConfigFrmRegions()
    End Sub

    Private Sub btnSeleccionarOpcion_Click(sender As Object, e As EventArgs) Handles btnSeleccionarOpcion.Click
        userInterfaceUpdater.selectionButtonConfigFrmRegions()
    End Sub
End Class