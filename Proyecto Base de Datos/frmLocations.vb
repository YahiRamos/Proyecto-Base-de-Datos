Public Class frmLocations

    Private Sub frmLocations_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim userInterfaceUpdater As New UserInterfaceUpdater()
        userInterfaceUpdater.defaultConfigFrmLocations()
    End Sub
    Private Sub btnBackMenu_Click(sender As Object, e As EventArgs) Handles btnBackMenu.Click
        Close()
        menuPrincipal.Visible = True
    End Sub
    Private Sub Puedemodificar()
        If txtLocationId.TextLength > 0 And txtCity.TextLength > 0 And txtCountryId.TextLength > 0 And txtPostalCode.TextLength > 0 And txtStateProvince.TextLength > 0 And txtStreetAddress.TextLength > 0 Then
            btnModificar.Enabled = True
        Else
            btnModificar.Enabled = False
        End If
    End Sub
    Private Sub Puederegistrarse()
        If txtLocationId.TextLength > 0 And txtCity.TextLength > 0 And txtCountryId.TextLength > 0 And txtPostalCode.TextLength > 0 And txtStateProvince.TextLength > 0 And txtStreetAddress.TextLength > 0 Then
            btnRegistrar.Enabled = True
        Else
            btnRegistrar.Enabled = False
        End If
    End Sub

    Private Sub txtLocationId_TextChanged(sender As Object, e As EventArgs) Handles txtLocationId.TextChanged
        Puedemodificar()
        Puederegistrarse()

    End Sub

    Private Sub txtStreetAddress_TextChanged(sender As Object, e As EventArgs) Handles txtStreetAddress.TextChanged
        Puedemodificar()
        Puederegistrarse()
    End Sub

    Private Sub txtPostalCode_TextChanged(sender As Object, e As EventArgs) Handles txtPostalCode.TextChanged
        Puedemodificar()
        Puederegistrarse()
    End Sub

    Private Sub txtCity_TextChanged(sender As Object, e As EventArgs) Handles txtCity.TextChanged
        Puedemodificar()
        Puederegistrarse()
    End Sub

    Private Sub txtStateProvince_TextChanged(sender As Object, e As EventArgs) Handles txtStateProvince.TextChanged
        Puedemodificar()
        Puederegistrarse()
    End Sub

    Private Sub txtCountryId_TextChanged(sender As Object, e As EventArgs) Handles txtCountryId.TextChanged
        Puedemodificar()
        Puederegistrarse()
    End Sub
End Class