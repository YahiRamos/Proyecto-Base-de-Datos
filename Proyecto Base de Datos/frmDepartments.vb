Public Class frmDepartments
    Private Sub frmDepartments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim userInterfaceUpdater As New UserInterfaceUpdater()
        userInterfaceUpdater.defaultConfigFrmDepartments()
    End Sub

    Private Sub btnBackMenu_Click(sender As Object, e As EventArgs) Handles btnBackMenu.Click
        Close()
        menuPrincipal.Visible = True
    End Sub
    Private Sub Puedemodificar()
        If txtDepartmentId.TextLength > 0 And txtDepartmentName.TextLength > 0 And txtLocationId.TextLength > 0 And txtManagerId.TextLength > 0 Then
            btnModificar.Enabled = True
        Else
            btnModificar.Enabled = False
        End If
    End Sub
    Private Sub Puederegistrarse()
        If txtDepartmentId.TextLength > 0 And txtDepartmentName.TextLength > 0 And txtLocationId.TextLength > 0 And txtManagerId.TextLength > 0 Then
            btnRegistrar.Enabled = True
        Else
            btnRegistrar.Enabled = False
        End If
    End Sub

    Private Sub txtDepartmentId_TextChanged(sender As Object, e As EventArgs) Handles txtDepartmentId.TextChanged
        Puederegistrarse()
        Puedemodificar()

    End Sub

    Private Sub txtDepartmentName_TextChanged(sender As Object, e As EventArgs) Handles txtDepartmentName.TextChanged
        Puederegistrarse()
        Puedemodificar()
    End Sub

    Private Sub txtManagerId_TextChanged(sender As Object, e As EventArgs) Handles txtManagerId.TextChanged
        Puederegistrarse()
        Puedemodificar()
    End Sub

    Private Sub txtLocationId_TextChanged(sender As Object, e As EventArgs) Handles txtLocationId.TextChanged
        Puederegistrarse()
        Puedemodificar()
    End Sub
End Class