Public Class frmJobs
    Private Sub frmJobs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnEliminar.Visible = False
        btnModificar.Visible = False
        btnRegistrar.Visible = False
        btnVerDatos.Visible = False
        txtJobId.Enabled = False
        txtJobTitle.Enabled = False
        txtMaxSalary.Enabled = False
        txtMinSalary.Enabled = False
    End Sub

    Private Sub btnBackMenu_Click(sender As Object, e As EventArgs) Handles btnBackMenu.Click
        Close()
        menuPrincipal.Visible = True
    End Sub
End Class