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
    End Sub

    Public Sub defaultConfigFrmCountries()

        frmCountries.btnEliminar.Visible = False
        frmCountries.btnModificar.Visible = False
        frmCountries.btnRegistrar.Visible = False
        frmCountries.btnVerDatos.Visible = False
        frmCountries.txtCountryId.Enabled = False
        frmCountries.txtCountryName.Enabled = False
        frmCountries.txtRegionId.Enabled = False
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
    End Sub

    Public Sub defaultConfigFrmRegions()
        frmRegions.btnEliminar.Visible = False
        frmRegions.btnModificar.Visible = False
        frmRegions.btnRegistrar.Visible = False
        frmRegions.btnVerDatos.Visible = False
        frmRegions.txtRegionId.Enabled = False
        frmRegions.txtRegionName.Enabled = False
    End Sub
End Class
