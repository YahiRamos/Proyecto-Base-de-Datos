Public Class frmDepartments
    Private Sub frmDepartments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnEliminar.Visible = False
        btnModificar.Visible = False
        btnRegistrar.Visible = False
        btnVerDatos.Visible = False
        txtDepartmentId.Enabled = False
        txtDepartmentName.Enabled = False
        txtLocationId.Enabled = False
        txtManagerId.Enabled = False
    End Sub

    Private Sub btnBackMenu_Click(sender As Object, e As EventArgs) Handles btnBackMenu.Click
        Close()
        menuPrincipal.Visible = True
    End Sub
End Class