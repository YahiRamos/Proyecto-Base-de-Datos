Public Class frmJobHistory
    Private Sub frmJobHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim userInterfaceUpdater As New UserInterfaceUpdater()
        userInterfaceUpdater.defaultConfigFrmJobHistory()
    End Sub
    Private Sub btnBackMenu_Click(sender As Object, e As EventArgs) Handles btnBackMenu.Click
        Close()
        menuPrincipal.Visible = True
    End Sub
    Private Sub Puedemodificar()
        If txtDepartmentId.TextLength > 0 And txtEmployeeId.TextLength > 0 And txtEndDate.TextLength > 0 And txtJobId.TextLength > 0 And txtStartDate.TextLength Then

            btnModificar.Enabled = True
        Else
            btnModificar.Enabled = False
        End If
    End Sub
    Private Sub Puederegistrarse()
        If txtDepartmentId.TextLength > 0 And txtEmployeeId.TextLength > 0 And txtEndDate.TextLength > 0 And txtJobId.TextLength > 0 And txtStartDate.TextLength Then
            btnRegistrar.Enabled = True
        Else
            btnRegistrar.Enabled = False
        End If
    End Sub

    Private Sub txtEmployeeId_TextChanged(sender As Object, e As EventArgs) Handles txtEmployeeId.TextChanged
        Puedemodificar()
        Puederegistrarse()

    End Sub

    Private Sub txtStartDate_TextChanged(sender As Object, e As EventArgs) Handles txtStartDate.TextChanged
        Puedemodificar()
        Puederegistrarse()
    End Sub

    Private Sub txtEndDate_TextChanged(sender As Object, e As EventArgs) Handles txtEndDate.TextChanged
        Puedemodificar()
        Puederegistrarse()
    End Sub

    Private Sub txtJobId_TextChanged(sender As Object, e As EventArgs) Handles txtJobId.TextChanged
        Puedemodificar()
        Puederegistrarse()
    End Sub

    Private Sub txtDepartmentId_TextChanged(sender As Object, e As EventArgs) Handles txtDepartmentId.TextChanged
        Puedemodificar()
        Puederegistrarse()
    End Sub
End Class