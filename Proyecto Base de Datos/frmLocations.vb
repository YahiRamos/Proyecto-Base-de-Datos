Public Class frmLocations
    Private Sub btnBackMenu_Click(sender As Object, e As EventArgs) Handles btnBackMenu.Click
        Close()
        menuPrincipal.Visible = True
    End Sub

    Private Sub frmLocations_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnEliminar.Visible = False
        btnModificar.Visible = False
        btnRegistrar.Visible = False
        btnVerDatos.Visible = False
        txtCity.Enabled = False
        txtCountryId.Enabled = False
        txtLocationId.Enabled = False
        txtPostalCode.Enabled = False
        txtStateProvince.Enabled = False
        txtStreetAddress.Enabled = False
    End Sub
End Class