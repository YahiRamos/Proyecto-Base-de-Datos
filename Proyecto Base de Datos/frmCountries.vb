Public Class frmCountries
    Private Sub frmCountries_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim userInterfaceUpdater As New UserInterfaceUpdater()
        userInterfaceUpdater.defaultConfigFrmCountries()
    End Sub

    Private Sub btnBackMenu_Click(sender As Object, e As EventArgs) Handles btnBackMenu.Click
        Close()
        menuPrincipal.Visible = True
    End Sub
    Private Sub Puedemodificar()
        If txtRegionId.TextLength > 0 And txtCountryName.TextLength > 0 And txtCountryId.TextLength > 0 Then
            btnModificar.Enabled = True
        Else
            btnModificar.Enabled = False
        End If
    End Sub
    Private Sub Puederegistrarse()
        If txtRegionId.TextLength > 0 And txtCountryName.TextLength > 0 And txtCountryId.TextLength > 0 Then
            btnRegistrar.Enabled = True
        Else
            btnRegistrar.Enabled = False
        End If
    End Sub
    Private Sub txtCountryId_TextChanged(sender As Object, e As EventArgs) Handles txtCountryId.TextChanged
        Puedemodificar()
        Puederegistrarse()

    End Sub

    Private Sub txtCountryName_TextChanged(sender As Object, e As EventArgs) Handles txtCountryName.TextChanged
        Puedemodificar()
        Puederegistrarse()
    End Sub

    Private Sub txtRegionId_TextChanged(sender As Object, e As EventArgs) Handles txtRegionId.TextChanged
        Puedemodificar()
        Puederegistrarse()
    End Sub
End Class