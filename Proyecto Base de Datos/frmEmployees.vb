Public Class frmEmployees
    Private Sub frmEmployees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnEliminar.Visible = False
        btnModificar.Visible = False
        btnRegistrar.Visible = False
        btnVerDatos.Visible = False
        txtCommissionPct.Enabled = False
        txtDepartmentId.Enabled = False
        txtEmail.Enabled = False
        txtEmployeeId.Enabled = False
        txtFirstName.Enabled = False
        txtHireDate.Enabled = False
        txtJobId.Enabled = False
        txtLastName.Enabled = False
        txtManagerId.Enabled = False
        txtPhoneNumber.Enabled = False
        txtSalary.Enabled = False

    End Sub

    Private Sub btnBackMenu_Click(sender As Object, e As EventArgs) Handles btnBackMenu.Click
        Close()
        menuPrincipal.Visible = True
    End Sub
End Class