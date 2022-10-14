Public Class frmEmployees
    Private Sub frmEmployees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim userInterfaceUpdater As New UserInterfaceUpdater()
        userInterfaceUpdater.defaultConfigFrmEmployees()
    End Sub

    Private Sub btnBackMenu_Click(sender As Object, e As EventArgs) Handles btnBackMenu.Click
        Close()
        menuPrincipal.Visible = True
    End Sub
    Private Sub Puedemodificar()
        If txtDepartmentId.TextLength > 0 And txtFirstName.TextLength > 0 And txtHireDate.TextLength > 0 And txtSalary.TextLength > 0 And txtPhoneNumber.TextLength > 0 And txtManagerId.TextLength > 0 And txtLastName.TextLength > 0 And txtEmployeeId.TextLength > 0 And txtCommissionPct.TextLength > 0 And txtJobId.TextLength > 0 And txtEmail.TextLength Then

            btnModificar.Enabled = True
        Else
            btnModificar.Enabled = False
        End If
    End Sub
    Private Sub Puederegistrarse()
        If txtDepartmentId.TextLength > 0 And txtFirstName.TextLength > 0 And txtHireDate.TextLength > 0 And txtSalary.TextLength > 0 And txtPhoneNumber.TextLength > 0 And txtManagerId.TextLength > 0 And txtLastName.TextLength > 0 And txtEmployeeId.TextLength > 0 And txtCommissionPct.TextLength > 0 And txtJobId.TextLength > 0 And txtEmail.TextLength Then

            btnRegistrar.Enabled = True
        Else
            btnRegistrar.Enabled = False
        End If
    End Sub

    Private Sub txtEmployeeId_TextChanged(sender As Object, e As EventArgs) Handles txtEmployeeId.TextChanged
        Puedemodificar()
        Puederegistrarse()

    End Sub

    Private Sub txtJobId_TextChanged(sender As Object, e As EventArgs) Handles txtJobId.TextChanged
        Puedemodificar()
        Puederegistrarse()

    End Sub

    Private Sub txtFirstName_TextChanged(sender As Object, e As EventArgs) Handles txtFirstName.TextChanged
        Puedemodificar()
        Puederegistrarse()

    End Sub

    Private Sub txtSalary_TextChanged(sender As Object, e As EventArgs) Handles txtSalary.TextChanged
        Puedemodificar()
        Puederegistrarse()

    End Sub

    Private Sub txtLastName_TextChanged(sender As Object, e As EventArgs) Handles txtLastName.TextChanged
        Puedemodificar()
        Puederegistrarse()

    End Sub

    Private Sub txtCommissionPct_TextChanged(sender As Object, e As EventArgs) Handles txtCommissionPct.TextChanged
        Puedemodificar()
        Puederegistrarse()

    End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        Puedemodificar()
        Puederegistrarse()

    End Sub

    Private Sub txtManagerId_TextChanged(sender As Object, e As EventArgs) Handles txtManagerId.TextChanged
        Puedemodificar()
        Puederegistrarse()

    End Sub

    Private Sub txtPhoneNumber_TextChanged(sender As Object, e As EventArgs) Handles txtPhoneNumber.TextChanged
        Puedemodificar()
        Puederegistrarse()

    End Sub

    Private Sub txtDepartmentId_TextChanged(sender As Object, e As EventArgs) Handles txtDepartmentId.TextChanged
        Puedemodificar()
        Puederegistrarse()

    End Sub

    Private Sub txtHireDate_TextChanged(sender As Object, e As EventArgs) Handles txtHireDate.TextChanged
        Puedemodificar()
        Puederegistrarse()

    End Sub
End Class