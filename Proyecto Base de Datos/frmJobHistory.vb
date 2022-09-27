Public Class frmJobHistory
    Private Sub btnBackMenu_Click(sender As Object, e As EventArgs) Handles btnBackMenu.Click
        Close()
        menuPrincipal.Visible = True
    End Sub

    Private Sub frmJobHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnEliminar.Visible = False
        btnModificar.Visible = False
        btnRegistrar.Visible = False
        btnVerDatos.Visible = False
        txtDepartmentId.Enabled = False
        txtEmployeeId.Enabled = False
        txtEndDate.Enabled = False
        txtJobId.Enabled = False
        txtStartDate.Enabled = False
    End Sub
End Class