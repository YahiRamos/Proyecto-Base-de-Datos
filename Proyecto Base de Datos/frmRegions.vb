Public Class frmRegions
    Private Sub btnBackMenu_Click(sender As Object, e As EventArgs) Handles btnBackMenu.Click
        Close()
        menuPrincipal.Visible = True
    End Sub

    Private Sub frmRegions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnEliminar.Visible = False
        btnModificar.Visible = False
        btnRegistrar.Visible = False
        btnVerDatos.Visible = False
        txtRegionId.Enabled = False
        txtRegionName.Enabled = False
    End Sub
End Class