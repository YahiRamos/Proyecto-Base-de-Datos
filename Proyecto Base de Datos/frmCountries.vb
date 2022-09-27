Public Class frmCountries
    Private Sub frmCountries_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        menuPrincipal.Close()
        btnEliminar.Visible = False
        btnModificar.Visible = False
        btnRegistrar.Visible = False
        btnVerDatos.Visible = False
        txtCountryId.Enabled = False
        txtCountryName.Enabled = False
        txtRegionId.Enabled = False
    End Sub

    Private Sub btnBackMenu_Click(sender As Object, e As EventArgs) Handles btnBackMenu.Click
        Close()
        menuPrincipal.Visible = True
    End Sub
End Class