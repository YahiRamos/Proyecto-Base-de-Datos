Public Class frmJobs
    Private Sub frmJobs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim userInterfaceUpdater As New UserInterfaceUpdater()
        userInterfaceUpdater.defaultConfigFrmJobs()
    End Sub

    Private Sub btnBackMenu_Click(sender As Object, e As EventArgs) Handles btnBackMenu.Click
        Close()
        menuPrincipal.Visible = True
    End Sub

    Private Sub btnVerDatos_Click(sender As Object, e As EventArgs) Handles btnVerDatos.Click

    End Sub

    Private Sub btnSeleccionarOpcion_Click(sender As Object, e As EventArgs) Handles btnSeleccionarOpcion.Click
        Dim opcion As String
        opcion = cbOpciones.SelectedItem.ToString
        If opcion.Equals("Ver Registro") Then
            btnVerDatos.Visible = True
            txtJobId.Enabled = True
        ElseIf opcion.Equals("Agregar Registro") Then
            btnRegistrar.Visible = True
            txtJobId.Enabled = True
            txtJobTitle.Enabled = True
            txtMaxSalary.Enabled = True
            txtMinSalary.Enabled = True
        ElseIf opcion.Equals("Modificar Registro") Then
            btnModificar.Visible = True
            txtJobId.Enabled = True
            txtJobTitle.Enabled = True
            txtMaxSalary.Enabled = True
            txtMinSalary.Enabled = True
        ElseIf opcion.Equals("Eliminar Registro") Then
            btnEliminar.Visible = True
            txtJobId.Enabled = True
        End If
    End Sub
End Class