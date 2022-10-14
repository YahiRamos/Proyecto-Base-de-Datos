Imports System.Windows.Forms.Design.AxImporter

Public Class UserInterfaceUpdater
    Public Sub defaultConfigFrmJobs()

        frmJobs.btnEliminar.Visible = False
        frmJobs.btnModificar.Visible = False
        frmJobs.btnRegistrar.Visible = False
        frmJobs.btnVerDatos.Visible = False
        frmJobs.txtJobId.Enabled = False
        frmJobs.txtJobTitle.Enabled = False
        frmJobs.txtMaxSalary.Enabled = False
        frmJobs.txtMinSalary.Enabled = False
        frmJobs.txtJobId.Clear()
        frmJobs.txtJobTitle.Clear()
        frmJobs.txtMaxSalary.Clear()
        frmJobs.txtMinSalary.Clear()

    End Sub

    Public Sub defaultConfigFrmCountries()

        frmCountries.btnEliminar.Visible = False
        frmCountries.btnModificar.Visible = False
        frmCountries.btnRegistrar.Visible = False
        frmCountries.btnVerDatos.Visible = False
        frmCountries.txtCountryId.Enabled = False
        frmCountries.txtCountryName.Enabled = False
        frmCountries.txtRegionId.Enabled = False
        frmCountries.txtCountryId.Clear()
        frmCountries.txtCountryName.Clear()
        frmCountries.txtRegionId.Clear()
    End Sub

    Public Sub defaultConfigFrmDepartments()

        frmDepartments.btnEliminar.Visible = False
        frmDepartments.btnModificar.Visible = False
        frmDepartments.btnRegistrar.Visible = False
        frmDepartments.btnVerDatos.Visible = False
        frmDepartments.txtDepartmentId.Enabled = False
        frmDepartments.txtDepartmentName.Enabled = False
        frmDepartments.txtLocationId.Enabled = False
        frmDepartments.txtManagerId.Enabled = False
        frmDepartments.txtManagerId.Clear()
        frmDepartments.txtDepartmentId.Clear()
        frmDepartments.txtDepartmentName.Clear()
        frmDepartments.txtLocationId.Clear()
    End Sub

    Public Sub defaultConfigFrmEmployees()

        frmEmployees.btnEliminar.Visible = False
        frmEmployees.btnModificar.Visible = False
        frmEmployees.btnRegistrar.Visible = False
        frmEmployees.btnVerDatos.Visible = False
        frmEmployees.txtCommissionPct.Enabled = False
        frmEmployees.txtDepartmentId.Enabled = False
        frmEmployees.txtEmail.Enabled = False
        frmEmployees.txtEmployeeId.Enabled = False
        frmEmployees.txtFirstName.Enabled = False
        frmEmployees.txtHireDate.Enabled = False
        frmEmployees.txtJobId.Enabled = False
        frmEmployees.txtLastName.Enabled = False
        frmEmployees.txtManagerId.Enabled = False
        frmEmployees.txtPhoneNumber.Enabled = False
        frmEmployees.txtSalary.Enabled = False
        frmEmployees.txtCommissionPct.Clear()
        frmEmployees.txtDepartmentId.Clear()
        frmEmployees.txtEmail.Clear()
        frmEmployees.txtEmployeeId.Clear()
        frmEmployees.txtFirstName.Clear()
        frmEmployees.txtHireDate.Clear()
        frmEmployees.txtJobId.Clear()
        frmEmployees.txtLastName.Clear()
        frmEmployees.txtManagerId.Clear()
        frmEmployees.txtPhoneNumber.Clear()
        frmEmployees.txtSalary.Clear()
    End Sub

    Public Sub defaultConfigFrmJobHistory()

        frmJobHistory.btnEliminar.Visible = False
        frmJobHistory.btnModificar.Visible = False
        frmJobHistory.btnRegistrar.Visible = False
        frmJobHistory.btnVerDatos.Visible = False
        frmJobHistory.txtDepartmentId.Enabled = False
        frmJobHistory.txtEmployeeId.Enabled = False
        frmJobHistory.txtEndDate.Enabled = False
        frmJobHistory.txtJobId.Enabled = False
        frmJobHistory.txtStartDate.Enabled = False
        frmJobHistory.txtDepartmentId.Clear()
        frmJobHistory.txtEmployeeId.Clear()
        frmJobHistory.txtEndDate.Clear()
        frmJobHistory.txtJobId.Clear()
        frmJobHistory.txtStartDate.Clear()
    End Sub

    Public Sub defaultConfigFrmLocations()
        frmLocations.btnEliminar.Visible = False
        frmLocations.btnModificar.Visible = False
        frmLocations.btnRegistrar.Visible = False
        frmLocations.btnVerDatos.Visible = False
        frmLocations.txtCity.Enabled = False
        frmLocations.txtCountryId.Enabled = False
        frmLocations.txtLocationId.Enabled = False
        frmLocations.txtPostalCode.Enabled = False
        frmLocations.txtStateProvince.Enabled = False
        frmLocations.txtStreetAddress.Enabled = False
        frmLocations.txtCity.Clear()
        frmLocations.txtCountryId.Clear()
        frmLocations.txtLocationId.Clear()
        frmLocations.txtPostalCode.Clear()
        frmLocations.txtStateProvince.Clear()
        frmLocations.txtStreetAddress.Clear()
    End Sub

    Public Sub defaultConfigFrmRegions()
        frmRegions.btnEliminar.Visible = False
        frmRegions.btnModificar.Visible = False
        frmRegions.btnRegistrar.Visible = False
        frmRegions.btnVerDatos.Visible = False
        frmRegions.txtRegionId.Enabled = False
        frmRegions.txtRegionName.Enabled = False
        frmRegions.txtRegionId.Clear()
        frmRegions.txtRegionName.Clear()
    End Sub

    Public Sub selectionButtonConfigFrmJobs()
        Dim opcion As String
        opcion = frmJobs.cbOpciones.SelectedItem.ToString
        If opcion.Equals("Ver Registro") Then
            frmJobs.btnVerDatos.Visible = True
            frmJobs.txtJobId.Enabled = True
        ElseIf opcion.Equals("Agregar Registro") Then
            frmJobs.btnRegistrar.Visible = True
            frmJobs.txtJobId.Enabled = True
            frmJobs.txtJobTitle.Enabled = True
            frmJobs.txtMaxSalary.Enabled = True
            frmJobs.txtMinSalary.Enabled = True
        ElseIf opcion.Equals("Modificar Registro") Then
            frmJobs.btnVerDatos.Visible = True
            frmJobs.txtJobId.Enabled = True
        ElseIf opcion.Equals("Eliminar Registro") Then
            frmJobs.btnEliminar.Visible = True
            frmJobs.txtJobId.Enabled = True
        End If
    End Sub

    Public Sub selectionButtonConfigFrmRegions()
        Dim opcion As String
        opcion = frmRegions.cbOpciones.SelectedItem.ToString
        If opcion.Equals("Ver Registro") Then
            frmRegions.btnVerDatos.Visible = True
            frmRegions.txtRegionId.Enabled = True
        ElseIf opcion.Equals("Agregar Registro") Then
            frmRegions.btnRegistrar.Visible = True
            frmRegions.txtRegionId.Enabled = True
            frmRegions.txtRegionName.Enabled = True
        ElseIf opcion.Equals("Modificar Registro") Then
            frmRegions.btnVerDatos.Visible = True
            frmRegions.txtRegionId.Enabled = True
        ElseIf opcion.Equals("Eliminar Registro") Then
            frmRegions.btnEliminar.Visible = True
            frmRegions.txtRegionId.Enabled = True
        End If
    End Sub

    Public Sub selectionButtonConfigFrmCountries()
        Dim opcion As String
        opcion = frmCountries.cbOpciones.SelectedItem.ToString
        If opcion.Equals("Ver Registro") Then
            frmCountries.btnVerDatos.Visible = True
            frmCountries.txtCountryId.Enabled = True
        ElseIf opcion.Equals("Agregar Registro") Then
            frmCountries.btnRegistrar.Visible = True
            frmCountries.txtCountryId.Enabled = True
            frmCountries.txtCountryName.Enabled = True
            frmCountries.txtRegionId.Enabled = True
        ElseIf opcion.Equals("Modificar Registro") Then
            frmCountries.btnVerDatos.Visible = True
            frmCountries.txtCountryId.Enabled = True
        ElseIf opcion.Equals("Eliminar Registro") Then
            frmCountries.btnEliminar.Visible = True
            frmCountries.txtCountryId.Enabled = True
        End If
    End Sub

    Public Sub selectionButtonConfigFrmLocations()
        Dim opcion As String
        opcion = frmLocations.cbOpciones.SelectedItem.ToString
        If opcion.Equals("Ver Registro") Then
            frmLocations.btnVerDatos.Visible = True
            frmLocations.txtLocationId.Enabled = True
        ElseIf opcion.Equals("Agregar Registro") Then
            frmLocations.btnRegistrar.Visible = True
            frmLocations.txtLocationId.Enabled = True
            frmLocations.txtCity.Enabled = True
            frmLocations.txtCountryId.Enabled = True
            frmLocations.txtPostalCode.Enabled = True
            frmLocations.txtStateProvince.Enabled = True
            frmLocations.txtStreetAddress.Enabled = True
        ElseIf opcion.Equals("Modificar Registro") Then
            frmLocations.btnVerDatos.Visible = True
            frmLocations.txtLocationId.Enabled = True
        ElseIf opcion.Equals("Eliminar Registro") Then
            frmLocations.btnEliminar.Visible = True
            frmLocations.txtLocationId.Enabled = True
        End If
    End Sub

    Public Sub selectionButtonConfigFrmDepartments()
        Dim opcion As String
        opcion = frmDepartments.cbOpciones.SelectedItem.ToString
        If opcion.Equals("Ver Registro") Then
            frmDepartments.btnVerDatos.Visible = True
            frmDepartments.txtDepartmentId.Enabled = True
        ElseIf opcion.Equals("Agregar Registro") Then
            frmDepartments.btnRegistrar.Visible = True
            frmDepartments.txtDepartmentId.Enabled = True
            frmDepartments.txtDepartmentName.Enabled = True
            frmDepartments.txtLocationId.Enabled = True
            frmDepartments.txtManagerId.Enabled = True
        ElseIf opcion.Equals("Modificar Registro") Then
            frmDepartments.btnVerDatos.Visible = True
            frmDepartments.txtDepartmentId.Enabled = True
        ElseIf opcion.Equals("Eliminar Registro") Then
            frmDepartments.btnEliminar.Visible = True
            frmDepartments.txtDepartmentId.Enabled = True
        End If
    End Sub

    Public Sub selectionButtonConfigFrmEmployees()
        Dim opcion As String
        opcion = frmEmployees.cbOpciones.SelectedItem.ToString
        If opcion.Equals("Ver Registro") Then
            frmEmployees.btnVerDatos.Visible = True
            frmEmployees.txtEmployeeId.Enabled = True
        ElseIf opcion.Equals("Agregar Registro") Then
            frmEmployees.btnRegistrar.Visible = True
            frmEmployees.txtCommissionPct.Enabled = True
            frmEmployees.txtDepartmentId.Enabled = True
            frmEmployees.txtEmail.Enabled = True
            frmEmployees.txtEmployeeId.Enabled = True
            frmEmployees.txtFirstName.Enabled = True
            frmEmployees.txtHireDate.Enabled = True
            frmEmployees.txtJobId.Enabled = True
            frmEmployees.txtLastName.Enabled = True
            frmEmployees.txtManagerId.Enabled = True
            frmEmployees.txtPhoneNumber.Enabled = True
            frmEmployees.txtSalary.Enabled = True
        ElseIf opcion.Equals("Modificar Registro") Then
            frmEmployees.btnVerDatos.Visible = True
            frmEmployees.txtEmployeeId.Enabled = True
        ElseIf opcion.Equals("Eliminar Registro") Then
            frmEmployees.btnEliminar.Visible = True
            frmEmployees.txtEmployeeId.Enabled = True
        End If
    End Sub

    Public Sub selectionButtonConfigFrmJobHistory()
        Dim opcion As String
        opcion = frmJobHistory.cbOpciones.SelectedItem.ToString
        If opcion.Equals("Ver Registro") Then
            frmJobHistory.btnVerDatos.Visible = True
            frmJobHistory.txtEmployeeId.Enabled = True
            frmJobHistory.txtStartDate.Enabled = True
        ElseIf opcion.Equals("Agregar Registro") Then
            frmJobHistory.btnRegistrar.Visible = True
            frmJobHistory.txtDepartmentId.Enabled = True
            frmJobHistory.txtEmployeeId.Enabled = True
            frmJobHistory.txtEndDate.Enabled = True
            frmJobHistory.txtJobId.Enabled = True
            frmJobHistory.txtStartDate.Enabled = True
        ElseIf opcion.Equals("Modificar Registro") Then
            frmJobHistory.btnVerDatos.Visible = True
            frmJobHistory.txtEmployeeId.Enabled = True
            frmJobHistory.txtStartDate.Enabled = True
        ElseIf opcion.Equals("Eliminar Registro") Then
            frmJobHistory.btnEliminar.Visible = True
            frmJobHistory.txtEmployeeId.Enabled = True
            frmJobHistory.txtStartDate.Enabled = True
        End If
    End Sub

End Class
